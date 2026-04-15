using jara_s_Veterinary.Layers.JSON;
using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces.Ibll;
using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static jara_s_Veterinary.Layers.JSON.Direcciones;

namespace JarasTech.Layers.UI
{
    public partial class mantenimientoClientes : Form
    {
        #region Campos privados

        private List<Provincia> _provincias;
        private bool _imagenModificada = false;
        private int _clienteIDActual = 0;

        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly IBLLClientes _bllCliente = new BLLClientes();
        private readonly ErrorProvider _erp = new ErrorProvider();

        #endregion

        public mantenimientoClientes()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════════════
        // LOAD
        // ════════════════════════════════════════════════════════════════
        private async void mantenimientoClientes_Load(object sender, EventArgs e)
        {
            try
            {
                _erp.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                ConfigurarGrid();
                await LoadProvinciasAsync();
                await CargarDatosAsync();
                EstablecerModoNuevo();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error Load: {0}", ex);
                MostrarError("Error al cargar el formulario: " + ex.Message);
            }
        }

        // ════════════════════════════════════════════════════════════════
        // GRID
        // ════════════════════════════════════════════════════════════════
        private void ConfigurarGrid()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "ClienteID", HeaderText = "ID", Width = 45 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "NumeroIdentificacion", HeaderText = "Identificación", FillWeight = 15 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Nombre", HeaderText = "Nombre", FillWeight = 18 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Apellidos", HeaderText = "Apellidos", FillWeight = 18 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Telefono", HeaderText = "Teléfono", FillWeight = 12 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "CorreoElectronico", HeaderText = "Correo", FillWeight = 20 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Provincia", HeaderText = "Provincia", FillWeight = 12 });

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ════════════════════════════════════════════════════════════════
        // PROVINCIAS
        // ════════════════════════════════════════════════════════════════
        private async Task LoadProvinciasAsync()
        {
            try
            {
                _provincias = await Direcciones.GetProvinciasAsync();
                if (_provincias != null && _provincias.Any())
                {
                    cboProvincia.DataSource = null;
                    cboProvincia.DisplayMember = "Descripcion";
                    cboProvincia.ValueMember = "IdProvincia";
                    cboProvincia.DataSource = _provincias;
                    cboProvincia.SelectedIndex = -1;
                }
                else
                {
                    _log.Warn("No se pudieron cargar provincias.");
                    lblEstadoAPI.Text = "⚠ Provincias no disponibles";
                    lblEstadoAPI.ForeColor = Color.OrangeRed;
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error LoadProvinciasAsync: {0}", ex);
                lblEstadoAPI.Text = "⚠ Sin conexión para provincias";
                lblEstadoAPI.ForeColor = Color.OrangeRed;
            }
        }

        // ════════════════════════════════════════════════════════════════
        // CARGAR DATOS
        // ════════════════════════════════════════════════════════════════
        private async Task CargarDatosAsync()
        {
            try
            {
                await Task.Delay(50);
                var lista = _bllCliente.GetAllClientes().ToList();
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = lista;
                lblConteo.Text = "Total: " + lista.Count + " clientes";
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error CargarDatosAsync: {0}", ex);
                MostrarError("Error al cargar clientes: " + ex.Message);
            }
        }

        // ════════════════════════════════════════════════════════════════
        // API HACIENDA
        // ════════════════════════════════════════════════════════════════
        private async void btnConsultarAPI_Click(object sender, EventArgs e)
        {
            string cedula = txtNumeroIdentificacion.Text.Trim();

            if (string.IsNullOrEmpty(cedula))
            {
                _erp.SetError(txtNumeroIdentificacion, "Ingrese el número de cédula.");
                return;
            }
            if (!rdoNacional.Checked)
            {
                MessageBox.Show("La consulta al API de Hacienda aplica solo para nacionales.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _erp.Clear();
            btnConsultarAPI.Enabled = false;
            lblEstadoAPI.ForeColor = Color.DodgerBlue;
            lblEstadoAPI.Text = "Consultando API...";

            try
            {
                // Verificar primero si ya existe en el sistema
                var existente = _bllCliente.GetClienteByNumeroIdentificacion(cedula);
                if (existente != null)
                {
                    CargarClienteEnFormulario(existente);
                    lblEstadoAPI.Text = "✔ Cliente ya registrado — datos cargados";
                    lblEstadoAPI.ForeColor = Color.DarkGreen;
                    MessageBox.Show("Este cliente ya está registrado. Sus datos han sido cargados.",
                        "Cliente existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string url = $"https://api.hacienda.go.cr/fe/ae?identificacion={cedula}";
                string respuesta = await ConsultarConReintentoAsync(url);
                if (respuesta == null) return;

                var datos = JObject.Parse(respuesta);
                string nombreCompleto = datos["nombre"]?.ToString()?.Trim() ?? string.Empty;

                if (!string.IsNullOrEmpty(nombreCompleto))
                {
                    string[] partes = nombreCompleto.Split(
                        new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (partes.Length >= 3)
                    {
                        txtApellidos.Text = partes[0] + " " + partes[1];
                        txtNombre.Text = string.Join(" ", partes, 2, partes.Length - 2);
                    }
                    else if (partes.Length == 2)
                    {
                        txtApellidos.Text = partes[0];
                        txtNombre.Text = partes[1];
                    }
                    else
                    {
                        txtNombre.Text = nombreCompleto;
                        txtApellidos.Text = string.Empty;
                    }

                    lblEstadoAPI.Text = "✔ Datos obtenidos de API Hacienda";
                    lblEstadoAPI.ForeColor = Color.DarkGreen;
                    txtTelefono.Focus();
                }
                else
                {
                    lblEstadoAPI.Text = "⚠ Cédula no encontrada en Hacienda";
                    lblEstadoAPI.ForeColor = Color.OrangeRed;
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnConsultarAPI_Click: {0}", ex);
                MostrarError("Error inesperado al consultar API: " + ex.Message);
                lblEstadoAPI.Text = "✖ Error al consultar";
                lblEstadoAPI.ForeColor = Color.Red;
            }
            finally
            {
                btnConsultarAPI.Enabled = true;
                btnConsultarAPI.Text = "🔍 Consultar API Hacienda";
            }
        }

        private async Task<string> ConsultarConReintentoAsync(string url)
        {
            const int maxIntentos = 3;
            const int esperaSegundos = 2;

            for (int intento = 1; intento <= maxIntentos; intento++)
            {
                try
                {
                    btnConsultarAPI.Text = intento == 1
                        ? "Consultando..."
                        : $"Reintentando ({intento}/{maxIntentos})...";

                    HttpResponseMessage response = await _httpClient.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                        return await response.Content.ReadAsStringAsync();

                    if ((int)response.StatusCode == 429)
                    {
                        if (intento < maxIntentos)
                        {
                            for (int seg = esperaSegundos; seg > 0; seg--)
                            {
                                btnConsultarAPI.Text = $"Esperando {seg}s (límite API)...";
                                lblEstadoAPI.Text = $"⏳ Límite de API — esperando {seg}s...";
                                lblEstadoAPI.ForeColor = Color.OrangeRed;
                                await Task.Delay(1000);
                            }
                            continue;
                        }
                        MessageBox.Show(
                            "El API de Hacienda ha limitado las consultas.\nEspere unos segundos e intente nuevamente.",
                            "Límite de consultas (429)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }

                    MessageBox.Show(
                        $"El API respondió con error: {(int)response.StatusCode} {response.ReasonPhrase}",
                        "Error en API", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                catch (HttpRequestException ex) when (intento < maxIntentos)
                {
                    _log.WarnFormat("Error de red intento {0}/{1}: {2}", intento, maxIntentos, ex.Message);
                    await Task.Delay(esperaSegundos * 1000);
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("No se pudo conectar al API de Hacienda.\nVerifique su conexión a internet.",
                        "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            return null;
        }

        // ════════════════════════════════════════════════════════════════
        // BÚSQUEDA
        // ════════════════════════════════════════════════════════════════
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text.Trim();
                if (string.IsNullOrEmpty(filtro))
                { await CargarDatosAsync(); return; }

                var resultado = _bllCliente.GetClientesByNombre(filtro).ToList();
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = resultado;
                lblConteo.Text = "Resultados: " + resultado.Count;
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnBuscar_Click: {0}", ex);
                MostrarError("Error al buscar: " + ex.Message);
            }
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnBuscar_Click(sender, EventArgs.Empty);
        }

        private void txtNumeroIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnConsultarAPI_Click(sender, EventArgs.Empty);
        }

        // ════════════════════════════════════════════════════════════════
        // GRID SELECTION
        // ════════════════════════════════════════════════════════════════
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count == 0) return;
                var cliente = dgvClientes.SelectedRows[0].DataBoundItem as Clientes;
                if (cliente == null) return;
                CargarClienteEnFormulario(cliente);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error dgvClientes_SelectionChanged: {0}", ex);
            }
        }

        private void CargarClienteEnFormulario(Clientes cliente)
        {
            _clienteIDActual = cliente.ClienteID;
            _erp.Clear();

            // Tipo identificación
            rdoNacional.Checked = cliente.TipoIdentificacionID != 2;
            rdoExtranjero.Checked = cliente.TipoIdentificacionID == 2;

            // Sexo
            rdoMasculino.Checked = cliente.Sexo != 'F';
            rdoFemenino.Checked = cliente.Sexo == 'F';

            txtNumeroIdentificacion.Text = cliente.NumeroIdentificacion;
            txtNombre.Text = cliente.Nombre;
            txtApellidos.Text = cliente.Apellidos;
            txtTelefono.Text = cliente.Telefono;
            txtCorreoElectronico.Text = cliente.CorreoElectronico;
            txtDireccionExacta.Text = cliente.DireccionExacta;

            // Provincia — comparar por descripción string
            // FIX: el combo tiene objetos Provincia, no strings
            if (_provincias != null)
            {
                var prov = _provincias.FirstOrDefault(p =>
                    string.Equals(p.Descripcion, cliente.Provincia,
                        StringComparison.OrdinalIgnoreCase));
                if (prov != null)
                    cboProvincia.SelectedValue = prov.IdProvincia;
                else if (cboProvincia.Items.Count > 0)
                    cboProvincia.SelectedIndex = 0;
            }

            // Fotografía
            if (picFotografia.Image != null) { picFotografia.Image.Dispose(); picFotografia.Image = null; }
            if (cliente.Fotografia != null && cliente.Fotografia.Length > 0)
            {
                using (var ms = new MemoryStream(cliente.Fotografia))
                {
                    var img = Image.FromStream(ms);
                    picFotografia.Image = new Bitmap(img);
                    img.Dispose();
                }
            }

            lblEstadoAPI.Text = "✔ Cliente cargado";
            lblEstadoAPI.ForeColor = Color.DarkGreen;
            _imagenModificada = false;
        }

        // ════════════════════════════════════════════════════════════════
        // GUARDAR
        // ════════════════════════════════════════════════════════════════
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            try
            {
                btnGuardar.Enabled = false;
                Cursor = Cursors.WaitCursor;

                // FIX: obtener la descripción de la provincia del item seleccionado
                string nombreProvincia = string.Empty;
                if (cboProvincia.SelectedItem is Provincia p)
                    nombreProvincia = p.Descripcion;

                var cliente = new Clientes
                {
                    ClienteID = _clienteIDActual,
                    TipoIdentificacionID = rdoNacional.Checked ? 1 : 2,
                    NumeroIdentificacion = txtNumeroIdentificacion.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    Sexo = rdoMasculino.Checked ? 'M' : 'F',
                    Telefono = txtTelefono.Text.Trim(),
                    CorreoElectronico = txtCorreoElectronico.Text.Trim(),
                    Provincia = nombreProvincia,
                    DireccionExacta = txtDireccionExacta.Text.Trim(),
                    Fotografia = ObtenerBytesImagen()
                };

                cliente = _bllCliente.SaveCliente(cliente);
                if (cliente != null)
                {
                    _log.InfoFormat("Cliente guardado: ID={0}, Cédula={1}",
                        cliente.ClienteID, cliente.NumeroIdentificacion);
                    await CargarDatosAsync();
                    EstablecerModoNuevo();
                    MessageBox.Show("Cliente guardado exitosamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnGuardar_Click: {0}", ex);
                MostrarError("Error al guardar cliente: " + ex.Message);
            }
            finally
            {
                btnGuardar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        // ════════════════════════════════════════════════════════════════
        // ELIMINAR
        // ════════════════════════════════════════════════════════════════
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un cliente de la lista.",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cliente = dgvClientes.SelectedRows[0].DataBoundItem as Clientes;
                if (cliente == null) return;

                if (MessageBox.Show(
                    "¿Eliminar al cliente\n" + cliente.NombreCompleto +
                    " (" + cliente.NumeroIdentificacion + ")?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                if (_bllCliente.DeleteCliente(cliente.ClienteID))
                {
                    _log.InfoFormat("Cliente eliminado: ID={0}", cliente.ClienteID);
                    await CargarDatosAsync();
                    EstablecerModoNuevo();
                    MessageBox.Show("Cliente eliminado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MostrarError("No se pudo eliminar el cliente. Puede tener facturas asociadas.");
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnEliminar_Click: {0}", ex);
                MostrarError("Error al eliminar cliente: " + ex.Message);
            }
        }

        // ════════════════════════════════════════════════════════════════
        // FOTO
        // ════════════════════════════════════════════════════════════════
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ofd = new OpenFileDialog())
                {
                    ofd.Title = "Seleccionar fotografía del cliente";
                    ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        if (picFotografia.Image != null)
                            picFotografia.Image.Dispose();
                        picFotografia.Image = Image.FromFile(ofd.FileName);
                        picFotografia.SizeMode = PictureBoxSizeMode.Zoom;
                        _imagenModificada = true;
                    }
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnCargarFoto_Click: {0}", ex);
                MostrarError("Error al cargar fotografía: " + ex.Message);
            }
        }

        private void picFotografia_Click(object sender, EventArgs e)
        { btnCargarFoto_Click(sender, e); }

        // ════════════════════════════════════════════════════════════════
        // EVENTOS AUXILIARES
        // ════════════════════════════════════════════════════════════════
        private void rdoNacional_CheckedChanged(object sender, EventArgs e)
        {
            btnConsultarAPI.Enabled = rdoNacional.Checked;
            txtNumeroIdentificacion.MaxLength = rdoNacional.Checked ? 9 : 20;
            if (rdoNacional.Checked)
                lblEstadoAPI.Text = "Ingrese la cédula y presione Consultar";
        }

        private void btnNuevo_Click(object sender, EventArgs e) { EstablecerModoNuevo(); }
        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }

        // ════════════════════════════════════════════════════════════════
        // HELPERS
        // ════════════════════════════════════════════════════════════════
        private void EstablecerModoNuevo()
        {
            _clienteIDActual = 0;
            _imagenModificada = false;
            _erp.Clear();

            rdoNacional.Checked = true;
            rdoMasculino.Checked = true;

            txtNumeroIdentificacion.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCorreoElectronico.Clear();
            txtDireccionExacta.Clear();
            txtFiltro.Clear();

            if (picFotografia.Image != null)
            { picFotografia.Image.Dispose(); picFotografia.Image = null; }

            if (cboProvincia.Items.Count > 0)
                cboProvincia.SelectedIndex = 0;

            lblEstadoAPI.Text = "Ingrese la cédula y presione Consultar";
            lblEstadoAPI.ForeColor = Color.FromArgb(100, 120, 160);

            btnConsultarAPI.Enabled = true;
            btnConsultarAPI.Text = "🔍 Consultar API Hacienda";
            txtNumeroIdentificacion.Focus();
        }

        private bool ValidarCampos()
        {
            bool valido = true;
            _erp.Clear();

            if (string.IsNullOrWhiteSpace(txtNumeroIdentificacion.Text))
            { _erp.SetError(txtNumeroIdentificacion, "Ingrese el número de identificación."); valido = false; }
            else if (rdoNacional.Checked && !Regex.IsMatch(txtNumeroIdentificacion.Text.Trim(), @"^\d{9}$"))
            { _erp.SetError(txtNumeroIdentificacion, "La cédula nacional debe tener 9 dígitos."); valido = false; }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { _erp.SetError(txtNombre, "Ingrese el nombre."); valido = false; }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            { _erp.SetError(txtApellidos, "Ingrese los apellidos."); valido = false; }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            { _erp.SetError(txtTelefono, "Ingrese el teléfono."); valido = false; }

            if (string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                !Regex.IsMatch(txtCorreoElectronico.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            { _erp.SetError(txtCorreoElectronico, "Ingrese un correo electrónico válido."); valido = false; }

            if (cboProvincia.SelectedItem == null)
            { _erp.SetError(cboProvincia, "Seleccione una provincia."); valido = false; }

            if (string.IsNullOrWhiteSpace(txtDireccionExacta.Text))
            { _erp.SetError(txtDireccionExacta, "Ingrese la dirección exacta."); valido = false; }

            return valido;
        }

        private byte[] ObtenerBytesImagen()
        {
            if (picFotografia.Image == null) return null;
            try
            {
                using (var bmp = new Bitmap(picFotografia.Image))
                using (var ms = new MemoryStream())
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error al convertir imagen a bytes: {0}", ex);
                return null;
            }
        }

        private static void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}