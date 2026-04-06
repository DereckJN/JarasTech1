using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces;
using JarasTech.Layers.Interfaces.Ibll;
using JarasTech.Layers.Persistencia;
using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace JarasTech.Layers.UI.Mantenimientos
{
    /// <summary>
    /// Formulario de mantenimiento para Productos electrónicos.
    /// El precio en dólares se calcula automáticamente usando el tipo de
    /// cambio de venta del BCCR en cuanto se escribe el precio en colones.
    /// </summary>
    public partial class FrmProductos : Form
    {
        private static readonly ILog _log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly IBLLProductos _bllProductos = new BLLProductos();
        private readonly IBLLMarcas _bllMarcas = new BLLMarcas();
        private readonly IBLLModelos _bllModelos = new BLLModelos();
        private readonly IBLLTiposDispositivo _bllTipos = new BLLTiposDispositivo();
        private readonly ServiceBCCR _bccr = new ServiceBCCR();

        private int _productoID = 0;
        private byte[] _fotografia = null;
        private byte[] _documento = null;
        private string _nombreDocumento = string.Empty;

        // Tipo de cambio de VENTA del BCCR (colones por dólar)
        private double _tipoCambioVenta = 0;

        // Bloquea el recalculo automático mientras se carga un producto
        private bool _cargandoProducto = false;

        public FrmProductos()
        {
            InitializeComponent();
        }


        private void FrmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                ConsultarTipoCambio();
                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error FrmProductos_Load: {0}", ex.Message);
                MessageBox.Show("Error al cargar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Consulta el tipo de cambio de venta del día al BCCR.
        /// Si tiene éxito, numPrecioD queda bloqueado (solo lectura) y
        /// se actualiza automáticamente al escribir el precio en colones.
        /// Si falla, numPrecioD queda editable manualmente.
        /// </summary>
        private void ConsultarTipoCambio()
        {
            try
            {
                DateTime hoy = DateTime.Today;
                IEnumerable<Dolar> resultado = _bccr.GetDolar(hoy, hoy, "v");
                Dolar ultimo = resultado.OrderByDescending(d => d.Fecha).FirstOrDefault();

                if (ultimo != null && ultimo.Monto > 0)
                {
                    _tipoCambioVenta = ultimo.Monto;
                    lblTCInfo.Text = "TC venta BCCR: ₡ "
                                          + _tipoCambioVenta.ToString("N2")
                                          + "  (" + ultimo.Fecha.ToString("dd/MM/yyyy") + ")";
                    lblTCInfo.ForeColor = Color.DarkGreen;
                    numPrecioD.ReadOnly = true;   // calculado automáticamente
                }
                else
                {
                    UsarTCManual("BCCR sin datos para hoy.");
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("BCCR error: {0}", ex.Message);
                UsarTCManual("Sin conexión al BCCR.");
            }
        }

        private void UsarTCManual(string motivo)
        {
            _tipoCambioVenta = 0;
            lblTCInfo.Text = motivo + " Ingrese precio $ manualmente.";
            lblTCInfo.ForeColor = Color.OrangeRed;
            numPrecioD.ReadOnly = false;
        }

        /// <summary>
        /// Cada vez que cambia numPrecioC, recalcula numPrecioD con el TC del BCCR.
        /// Solo actúa si tenemos un tipo de cambio válido y no estamos cargando datos.
        /// </summary>
        private void numPrecioC_ValueChanged(object sender, EventArgs e)
        {
            if (_cargandoProducto) return;
            if (_tipoCambioVenta <= 0) return;
            if (numPrecioC.Value <= 0) { numPrecioD.Value = 0; return; }

            decimal dolares = Math.Round(numPrecioC.Value / (decimal)_tipoCambioVenta, 2);
            numPrecioD.Value = dolares > numPrecioD.Maximum ? numPrecioD.Maximum : dolares;
        }


        private void CargarCombos()
        {
            List<Marcas> marcas = _bllMarcas.GetAllMarcas().ToList();
            cboMarca.DataSource = marcas;
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.ValueMember = "MarcaID";
            cboMarca.SelectedIndex = -1;

            cboFiltroMarca.DataSource = marcas.ToList();
            cboFiltroMarca.DisplayMember = "Descripcion";
            cboFiltroMarca.ValueMember = "MarcaID";
            cboFiltroMarca.SelectedIndex = -1;

            List<Modelos> modelos = _bllModelos.GetAllModelos().ToList();
            cboModelo.DataSource = modelos;
            cboModelo.DisplayMember = "Descripcion";
            cboModelo.ValueMember = "ModeloID";
            cboModelo.SelectedIndex = -1;

            cboFiltroModelo.DataSource = modelos.ToList();
            cboFiltroModelo.DisplayMember = "Descripcion";
            cboFiltroModelo.ValueMember = "ModeloID";
            cboFiltroModelo.SelectedIndex = -1;

            List<TiposDispositivo> tipos = _bllTipos.GetAllTiposDispositivo().ToList();
            cboTipo.DataSource = tipos;
            cboTipo.DisplayMember = "NombreTipo";
            cboTipo.ValueMember = "TipoDispositivoID";
            cboTipo.SelectedIndex = -1;

            cboFiltroTipo.DataSource = tipos.ToList();
            cboFiltroTipo.DisplayMember = "NombreTipo";
            cboFiltroTipo.ValueMember = "TipoDispositivoID";
            cboFiltroTipo.SelectedIndex = -1;
        }


        private void CargarGrilla()
        {
            try
            {
                int? marcaID = cboFiltroMarca.SelectedValue is int m && m > 0 ? (int?)m : null;
                int? modeloID = cboFiltroModelo.SelectedValue is int mo && mo > 0 ? (int?)mo : null;
                int? tipoID = cboFiltroTipo.SelectedValue is int t && t > 0 ? (int?)t : null;
                string texto = txtFiltro.Text.Trim().ToLower();

                IEnumerable<Productos> lista =
                    _bllProductos.GetProductosByFiltros(marcaID, modeloID, tipoID);

                if (!string.IsNullOrEmpty(texto))
                    lista = lista.Where(p =>
                        p.CodigoInterno.ToLower().IndexOf(texto) >= 0 ||
                        (p.NombreMarca ?? "").ToLower().IndexOf(texto) >= 0 ||
                        (p.NombreModelo ?? "").ToLower().IndexOf(texto) >= 0 ||
                        (p.Color ?? "").ToLower().IndexOf(texto) >= 0);

                dgvProductos.DataSource = lista.ToList();

                string[] ocultar = {
                    "Fotografia", "DocumentoEspecificaciones",
                    "Caracteristicas", "Extras", "NombreDocumento", "HayStock"
                };
                foreach (string col in ocultar)
                    if (dgvProductos.Columns[col] != null)
                        dgvProductos.Columns[col].Visible = false;

                SetHeader("ProductoID", "ID");
                SetHeader("CodigoInterno", "Código");
                SetHeader("CodigoIndustria", "Cód. Barras");
                SetHeader("NombreTipoDispositivo", "Tipo");
                SetHeader("NombreMarca", "Marca");
                SetHeader("NombreModelo", "Modelo");
                SetHeader("Color", "Color");
                SetHeader("CantidadStock", "Stock");
                SetHeader("PrecioColones", "Precio ₡");
                SetHeader("PrecioDolares", "Precio $");
                SetHeader("Estado", "Activo");

                foreach (string col in new[] { "ProductoID", "TipoDispositivoID", "ModeloID", "MarcaID" })
                    if (dgvProductos.Columns[col] != null)
                        dgvProductos.Columns[col].Visible = false;
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error CargarGrilla: {0}", ex.Message);
            }
        }

        private void SetHeader(string col, string header)
        {
            if (dgvProductos.Columns[col] != null)
                dgvProductos.Columns[col].HeaderText = header;
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;
            if (!(dgvProductos.CurrentRow.DataBoundItem is Productos p)) return;

            _cargandoProducto = true;

            _productoID = p.ProductoID;
            _fotografia = p.Fotografia;
            _documento = p.DocumentoEspecificaciones;
            _nombreDocumento = p.NombreDocumento ?? string.Empty;

            txtCodigoInterno.Text = p.CodigoInterno;
            txtCodigoBarras.Text = p.CodigoIndustria;
            txtColor.Text = p.Color;
            txtCaracteristicas.Text = p.Caracteristicas;
            txtExtras.Text = p.Extras;
            numStock.Value = p.CantidadStock;
            numPrecioC.Value = p.PrecioColones;
            numPrecioD.Value = p.PrecioDolares;
            chkEstado.Checked = p.Estado;
            lblNombreDoc.Text = string.IsNullOrEmpty(_nombreDocumento)
                                      ? "(sin documento)" : _nombreDocumento;

            SeleccionarCombo(cboTipo, "TipoDispositivoID", p.TipoDispositivoID);
            SeleccionarCombo(cboMarca, "MarcaID", p.MarcaID);
            SeleccionarCombo(cboModelo, "ModeloID", p.ModeloID);

            picFoto.Image = _fotografia != null
                ? Image.FromStream(new MemoryStream(_fotografia))
                : null;

            btnGuardar.Text = "Actualizar";
            _cargandoProducto = false;
            tabProducto.SelectedIndex = 1;
        }

        private void SeleccionarCombo(ComboBox cbo, string campoID, int valor)
        {
            foreach (object item in cbo.Items)
            {
                System.Reflection.PropertyInfo prop = item.GetType().GetProperty(campoID);
                if (prop != null && (int)prop.GetValue(item) == valor)
                {
                    cbo.SelectedItem = item; return;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) { CargarGrilla(); }
        private void txtFiltro_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) CargarGrilla(); }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            cboFiltroMarca.SelectedIndex = -1;
            cboFiltroModelo.SelectedIndex = -1;
            cboFiltroTipo.SelectedIndex = -1;
            CargarGrilla();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            tabProducto.SelectedIndex = 1;
            txtCodigoInterno.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            try
            {
                Productos p = new Productos
                {
                    ProductoID = _productoID,
                    CodigoInterno = txtCodigoInterno.Text.Trim().ToUpper(),
                    CodigoIndustria = txtCodigoBarras.Text.Trim(),
                    TipoDispositivoID = (int)cboTipo.SelectedValue,
                    ModeloID = (int)cboModelo.SelectedValue,
                    MarcaID = (int)cboMarca.SelectedValue,
                    Color = txtColor.Text.Trim(),
                    Caracteristicas = txtCaracteristicas.Text.Trim(),
                    Extras = txtExtras.Text.Trim(),
                    CantidadStock = (int)numStock.Value,
                    PrecioColones = numPrecioC.Value,
                    PrecioDolares = numPrecioD.Value,
                    Estado = chkEstado.Checked,
                    Fotografia = _fotografia,
                    DocumentoEspecificaciones = _documento,
                    NombreDocumento = _nombreDocumento
                };
                _bllProductos.SaveProducto(p);
                MessageBox.Show("Producto guardado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnGuardar: {0}", ex.Message);
                MessageBox.Show("Error al guardar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_productoID == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (MessageBox.Show("¿Desea eliminar el producto seleccionado?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    _bllProductos.DeleteProducto(_productoID);
                    MessageBox.Show("Producto eliminado.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarGrilla();
                }
                catch (Exception ex)
                {
                    _log.ErrorFormat("Error btnEliminar: {0}", ex.Message);
                    MessageBox.Show("No se puede eliminar: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                dlg.Title = "Seleccionar fotografía del producto";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _fotografia = File.ReadAllBytes(dlg.FileName);
                    picFoto.Image = Image.FromFile(dlg.FileName);
                }
            }
        }

        private void btnQuitarFoto_Click(object sender, EventArgs e)
        {
            _fotografia = null; picFoto.Image = null;
        }


        private void btnCargarDoc_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Documentos|*.pdf;*.docx";
                dlg.Title = "Seleccionar documento de especificaciones";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _documento = File.ReadAllBytes(dlg.FileName);
                    _nombreDocumento = Path.GetFileName(dlg.FileName);
                    lblNombreDoc.Text = _nombreDocumento;
                }
            }
        }

        private void btnQuitarDoc_Click(object sender, EventArgs e)
        {
            _documento = null; _nombreDocumento = string.Empty;
            lblNombreDoc.Text = "(sin documento)";
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoInterno.Text))
            { MessageBox.Show("El código interno es requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCodigoInterno.Focus(); return false; }
            if (cboTipo.SelectedValue == null)
            { MessageBox.Show("Seleccione el tipo de dispositivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (cboMarca.SelectedValue == null)
            { MessageBox.Show("Seleccione la marca.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (cboModelo.SelectedValue == null)
            { MessageBox.Show("Seleccione el modelo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (numPrecioC.Value <= 0)
            { MessageBox.Show("El precio en colones debe ser mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        private void LimpiarFormulario()
        {
            _cargandoProducto = true;
            _productoID = 0; _fotografia = null; _documento = null; _nombreDocumento = string.Empty;
            txtCodigoInterno.Clear(); txtCodigoBarras.Clear(); txtColor.Clear();
            txtCaracteristicas.Clear(); txtExtras.Clear();
            cboTipo.SelectedIndex = -1; cboMarca.SelectedIndex = -1; cboModelo.SelectedIndex = -1;
            numStock.Value = 0; numPrecioC.Value = 0; numPrecioD.Value = 0;
            chkEstado.Checked = true; picFoto.Image = null;
            lblNombreDoc.Text = "(sin documento)"; btnGuardar.Text = "Guardar";
            _cargandoProducto = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}