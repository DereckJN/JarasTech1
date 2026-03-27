using jara_s_Veterinary.Layers.JSON;
using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Entities.DTO;
using JarasTech.Layers.Interfaces.Ibll;
using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static jara_s_Veterinary.Layers.JSON.Direcciones;

namespace JarasTech.Layers.UI
{
    public partial class mantenimientoClientes : Form
    {
        #region Campos privados
        private List<Provincia> provincias;

        private static readonly ILog _log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly HttpClient _httpClient = new HttpClient();
        private readonly IBLLClientes _bllCliente = new BLLClientes();
        private readonly ErrorProvider _erp = new ErrorProvider();

        /// <summary>ID del cliente actualmente en edición; 0 = nuevo.</summary>
        private int _clienteIDActual = 0;

        #endregion
        public mantenimientoClientes()
        {
            InitializeComponent();
        }

        private async void mantenimientoClientes_Load(object sender, EventArgs e)
        {
            try
            {
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

        /// <summary>
        /// Define las columnas del DataGridView de clientes.
        /// </summary>
        private void ConfigurarGrid()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ClienteID",
                HeaderText = "ID",
                Width = 45,
                FillWeight = 5
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroIdentificacion",
                HeaderText = "Identificación",
                FillWeight = 15
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                FillWeight = 18
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Apellidos",
                HeaderText = "Apellidos",
                FillWeight = 18
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono",
                FillWeight = 12
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CorreoElectronico",
                HeaderText = "Correo",
                FillWeight = 20
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Provincia",
                HeaderText = "Provincia",
                FillWeight = 12
            });

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /// <summary>
        /// Carga las provincias en el ComboBox de forma asincrónica.
        /// </summary>
        private async Task LoadProvinciasAsync()
        {
            try
            {
                provincias = await Direcciones.GetProvinciasAsync();
                if (provincias != null)
                {
                    cboProvincia.DataSource = null; // Limpiar el DataSource
                    cboProvincia.DisplayMember = "Descripcion";
                    cboProvincia.ValueMember = "IdProvincia";
                    cboProvincia.DataSource = provincias;
                }
            }
            catch (Exception er)
            {
                string msg = "";
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                //MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ─────────────────────────────────────────────────────────────────
        // Carga del grid
        // ─────────────────────────────────────────────────────────────────

        /// <summary>
        /// Carga todos los clientes en el DataGridView.
        /// </summary>
        private async Task CargarDatosAsync()
        {
            try
            {
                await Task.Delay(100); // pequeño delay para que la UI responda
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = _bllCliente.GetAllClientes();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error CargarDatosAsync: {0}", ex);
                MostrarError("Error al cargar clientes: " + ex.Message);
            }
        }

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

            btnConsultarAPI.Enabled = false;

            try
            {
                string url = $"https://api.hacienda.go.cr/fe/ae?identificacion={cedula}";
                string respuesta = await ConsultarConReintentoAsync(url);

                if (respuesta == null) return; // El método ya mostró el error

                var datos = JObject.Parse(respuesta);

                // El API devuelve "nombre" con el nombre completo en formato
                // APELLIDO1 APELLIDO2 NOMBRE(S) — orden costarricense
                string nombreCompleto = datos["nombre"]?.ToString()?.Trim() ?? string.Empty;

                if (!string.IsNullOrEmpty(nombreCompleto))
                {
                    string[] partes = nombreCompleto.Split(new[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries);

                    if (partes.Length >= 3)
                    {
                        txtApellidos.Text = $"{partes[0]} {partes[1]}";
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
                }

                // Verificar si el cliente ya existe en el sistema
                var existente = _bllCliente.GetClienteByNumeroIdentificacion(cedula);
                if (existente != null)
                {
                    CargarClienteEnFormulario(existente);
                    MessageBox.Show("Cliente ya registrado. Sus datos han sido cargados.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnConsultarAPI_Click: {0}", ex);
                MostrarError("Error inesperado al consultar API: " + ex.Message);
            }
            finally
            {
                btnConsultarAPI.Enabled = true;
                btnConsultarAPI.Text = "Consultar API Hacienda";
            }
        }

        /// <summary>
        /// Realiza la petición HTTP con hasta 3 reintentos ante respuestas 429.
        /// Espera 2 segundos entre cada intento y actualiza el texto del botón
        /// para que el usuario vea la cuenta regresiva.
        /// </summary>
        /// <param name="url">URL a consultar.</param>
        /// <returns>Cuerpo de la respuesta como string, o null si fallaron todos los intentos.</returns>
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

                    // 429 = demasiadas solicitudes → esperar y reintentar
                    if ((int)response.StatusCode == 429)
                    {
                        _log.WarnFormat("API Hacienda 429 - intento {0}/{1}", intento, maxIntentos);

                        if (intento < maxIntentos)
                        {
                            for (int seg = esperaSegundos; seg > 0; seg--)
                            {
                                btnConsultarAPI.Text = $"Esperando {seg}s (límite API)...";
                                await Task.Delay(1000);
                            }
                            continue; // reintentar
                        }

                        // Se agotaron los reintentos
                        MessageBox.Show(
                            "El API de Hacienda ha limitado las consultas.\n" +
                            "Espere unos segundos e intente nuevamente.",
                            "Límite de consultas (429)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return null;
                    }

                    // Cualquier otro error HTTP
                    MessageBox.Show(
                        $"El API de Hacienda respondió con error: {(int)response.StatusCode} {response.ReasonPhrase}",
                        "Error en API",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return null;
                }
                catch (HttpRequestException ex) when (intento < maxIntentos)
                {
                    _log.WarnFormat("Error de red intento {0}/{1}: {2}", intento, maxIntentos, ex.Message);
                    await Task.Delay(esperaSegundos * 1000);
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show(
                        "No se pudo conectar al API de Hacienda.\nVerifique su conexión a internet.",
                        "Error de conexión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return null;
                }
            }

            return null;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text.Trim();

                if (string.IsNullOrEmpty(filtro))
                {
                    await CargarDatosAsync();
                    return;
                }

                var resultado = _bllCliente.GetClientesByNombre(filtro);
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = resultado;
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnBuscar_Click: {0}", ex);
                MostrarError("Error al buscar: " + ex.Message);
            }
        }

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
        /// <summary>
        /// Carga los datos de un cliente en todos los campos del formulario.
        /// </summary>
        /// <param name="cliente">Entidad Cliente a mostrar.</param>
        private void CargarClienteEnFormulario(Clientes cliente)
        {
            _clienteIDActual = cliente.ClienteID;

            // Tipo identificación
            rdoNacional.Checked = cliente.TipoIdentificacionID == 1;
            rdoExtranjero.Checked = cliente.TipoIdentificacionID == 2;

            txtNumeroIdentificacion.Text = cliente.NumeroIdentificacion;
            txtNombre.Text = cliente.Nombre;
            txtApellidos.Text = cliente.Apellidos;
            rdoMasculino.Checked = cliente.Sexo == 'M';
            rdoFemenino.Checked = cliente.Sexo == 'F';
            txtTelefono.Text = cliente.Telefono;
            txtCorreoElectronico.Text = cliente.CorreoElectronico;
            txtDireccionExacta.Text = cliente.DireccionExacta;

            // Provincia
            int idx = cboProvincia.Items.IndexOf(cliente.Provincia);
            cboProvincia.SelectedIndex = idx >= 0 ? idx : 0;

            // Fotografía
            if (cliente.Fotografia != null && cliente.Fotografia.Length > 0)
            {
                using (var ms = new MemoryStream(cliente.Fotografia))
                    picFotografia.Image = Image.FromStream(ms);
            }
            else
            {
                picFotografia.Image = null;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerModoNuevo();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                Clientes cliente = new Clientes
                {
                    ClienteID = _clienteIDActual,
                    TipoIdentificacionID = rdoNacional.Checked ? 1 : 2,
                    NumeroIdentificacion = txtNumeroIdentificacion.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    Sexo = rdoMasculino.Checked ? 'M' : 'F',
                    Telefono = txtTelefono.Text.Trim(),
                    CorreoElectronico = txtCorreoElectronico.Text.Trim(),
                    Provincia = cboProvincia.SelectedItem?.ToString(),
                    DireccionExacta = txtDireccionExacta.Text.Trim(),
                    Fotografia = ObtenerBytesImagen()
                };

                cliente = _bllCliente.SaveCliente(cliente);

                if (cliente != null)
                {
                    await CargarDatosAsync();
                    EstablecerModoNuevo();
                    MessageBox.Show("Cliente guardado exitosamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _log.InfoFormat("Cliente guardado: ID={0}, Identificacion={1}",
                        cliente.ClienteID, cliente.NumeroIdentificacion);
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnGuardar_Click: {0}", ex);
                MostrarError("Error al guardar cliente: " + ex.Message);
            }
        }

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

                var confirmacion = MessageBox.Show(
                    $"¿Desea eliminar al cliente\n{cliente.NombreCompleto} ({cliente.NumeroIdentificacion})?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion != DialogResult.Yes) return;

                bool eliminado = _bllCliente.DeleteCliente(cliente.ClienteID);

                if (eliminado)
                {
                    await CargarDatosAsync();
                    EstablecerModoNuevo();
                    MessageBox.Show("Cliente eliminado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _log.InfoFormat("Cliente eliminado: ID={0}", cliente.ClienteID);
                }
                else
                {
                    MostrarError("No se pudo eliminar el cliente.");
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnEliminar_Click: {0}", ex);
                MostrarError("Error al eliminar cliente: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Abre un diálogo para seleccionar la fotografía del cliente
        /// y la muestra en el PictureBox.
        /// </summary>
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Seleccionar fotografía del cliente";
                    ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        picFotografia.Image = Image.FromFile(ofd.FileName);
                        picFotografia.SizeMode = PictureBoxSizeMode.Zoom;
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
        {
            btnCargarFoto_Click(sender, e);
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBuscar_Click(sender, EventArgs.Empty);
        }

        private void rdoNacional_CheckedChanged(object sender, EventArgs e)
        {
            btnConsultarAPI.Enabled = rdoNacional.Checked;
            txtNumeroIdentificacion.MaxLength = rdoNacional.Checked ? 9 : 20;
        }
        /// <summary>
        /// Limpia todos los campos y deja el formulario listo para un nuevo cliente.
        /// </summary>
        private void EstablecerModoNuevo()
        {
            _clienteIDActual = 0;
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
            picFotografia.Image = null;

            if (cboProvincia.Items.Count > 0)
                cboProvincia.SelectedIndex = 0;

            btnConsultarAPI.Enabled = true;
            txtNumeroIdentificacion.Focus();
        }
        /// <summary>
        /// Valida todos los campos requeridos usando ErrorProvider.
        /// </summary>
        /// <returns>True si todos los campos son válidos.</returns>
        private bool ValidarCampos()
        {
            bool valido = true;
            _erp.Clear();

            if (string.IsNullOrWhiteSpace(txtNumeroIdentificacion.Text))
            {
                _erp.SetError(txtNumeroIdentificacion, "Ingrese el número de identificación.");
                valido = false;
            }
            else if (rdoNacional.Checked && !Regex.IsMatch(txtNumeroIdentificacion.Text.Trim(), @"^\d{9}$"))
            {
                _erp.SetError(txtNumeroIdentificacion, "La cédula nacional debe tener 9 dígitos.");
                valido = false;
            }
            else if (rdoExtranjero.Checked && !Regex.IsMatch(txtNumeroIdentificacion.Text.Trim(), @"^[A-Za-z]\d{6}$"))
            {
                _erp.SetError(txtNumeroIdentificacion, "El pasaporte debe tener 1 letra seguida de 6 dígitos.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                _erp.SetError(txtNombre, "Ingrese el nombre.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                _erp.SetError(txtApellidos, "Ingrese los apellidos.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                _erp.SetError(txtTelefono, "Ingrese el teléfono.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                !Regex.IsMatch(txtCorreoElectronico.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                _erp.SetError(txtCorreoElectronico, "Ingrese un correo electrónico válido.");
                valido = false;
            }

            if (cboProvincia.SelectedItem == null)
            {
                _erp.SetError(cboProvincia, "Seleccione una provincia.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccionExacta.Text))
            {
                _erp.SetError(txtDireccionExacta, "Ingrese la dirección exacta.");
                valido = false;
            }

            return valido;
        }

        /// <summary>
        /// Convierte la imagen del PictureBox en un arreglo de bytes para guardar en BD.
        /// </summary>
        /// <returns>Arreglo de bytes de la imagen, o null si no hay imagen.</returns>
        private byte[] ObtenerBytesImagen()
        {
            if (picFotografia.Image == null) return null;

            using (var ms = new MemoryStream())
            {
                picFotografia.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Muestra un mensaje de error al usuario.
        /// </summary>
        private static void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
