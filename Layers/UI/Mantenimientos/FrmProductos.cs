using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces;
using log4net;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace JarasTech.Layers.UI.Mantenimientos
{
    /// <summary>
    /// Formulario de mantenimiento para Productos electrónicos.
    /// Gestiona código interno, código de barras, marca, modelo, tipo, color,
    /// características, fotografía, documento de especificaciones, extras y stock.
    /// </summary>
    public partial class FrmProductos : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //private readonly IBLLProductos _bllProductos = new BLLProductos();
        //private readonly IBLLMarcas _bllMarcas = new BLLMarcas();
        //private readonly IBLLModelos _bllModelos = new BLLModelos();
        //private readonly IBLLTiposDispositivo _bllTipos = new BLLTiposDispositivo();

        private int _productoIDSeleccionado = 0;
        private byte[] _fotografia = null;
        private byte[] _documento = null;
        private string _nombreDocumento = string.Empty;

        public FrmProductos() { InitializeComponent(); }

        // ── Carga ──────────────────────────────────────────────────────

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                CargarGrilla(string.Empty, null, null, null);
                LimpiarFormulario();
            }
            catch (Exception ex) { _log.ErrorFormat("Error Load Productos: {0}", ex.Message); }
        }

        private void CargarCombos()
        {
            //// Marcas
            //cboMarca.DataSource = _bllMarcas.GetAllMarcas().ToList();
            //cboMarca.DisplayMember = "Descripcion";
            //cboMarca.ValueMember = "MarcaID";
            //cboMarca.SelectedIndex = -1;

            //// Filtro Marcas
            //cboFiltroMarca.DataSource = _bllMarcas.GetAllMarcas().ToList();
            //cboFiltroMarca.DisplayMember = "Descripcion";
            //cboFiltroMarca.ValueMember = "MarcaID";
            //cboFiltroMarca.SelectedIndex = -1;

            //// Modelos
            //cboModelo.DataSource = _bllModelos.GetAllModelos().ToList();
            //cboModelo.DisplayMember = "Descripcion";
            //cboModelo.ValueMember = "ModeloID";
            //cboModelo.SelectedIndex = -1;

            //// Filtro Modelos
            //cboFiltroModelo.DataSource = _bllModelos.GetAllModelos().ToList();
            //cboFiltroModelo.DisplayMember = "Descripcion";
            //cboFiltroModelo.ValueMember = "ModeloID";
            //cboFiltroModelo.SelectedIndex = -1;

            //// Tipos Dispositivo
            //cboTipo.DataSource = _bllTipos.GetAllTiposDispositivo().ToList();
            //cboTipo.DisplayMember = "NombreTipo";
            //cboTipo.ValueMember = "TipoDispositivoID";
            //cboTipo.SelectedIndex = -1;

            //// Filtro Tipos
            //cboFiltroTipo.DataSource = _bllTipos.GetAllTiposDispositivo().ToList();
            //cboFiltroTipo.DisplayMember = "NombreTipo";
            //cboFiltroTipo.ValueMember = "TipoDispositivoID";
            //cboFiltroTipo.SelectedIndex = -1;
        }

        // ── Grid ───────────────────────────────────────────────────────

        private void CargarGrilla(string filtro, int? marcaID, int? modeloID, int? tipoID)
        {
            //try
            //{
            //    var lista = _bllProductos.GetProductosByFiltros(marcaID, modeloID, tipoID)
            //        .Where(p => string.IsNullOrEmpty(filtro) ||
            //                    p.CodigoInterno.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
            //                    (p.NombreMarca ?? "").Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
            //                    (p.NombreModelo ?? "").Contains(filtro, StringComparison.OrdinalIgnoreCase))
            //        .ToList();

            //    dgvProductos.DataSource = lista;

            //    // Columnas ocultas y de bytes
            //    string[] ocultar = { "ProductoID", "Fotografia", "DocumentoEspecificaciones",
            //                         "Caracteristicas", "Extras", "TipoDispositivoID",
            //                         "ModeloID", "MarcaID", "NombreDocumento" };
            //    foreach (var col in ocultar)
            //        if (dgvProductos.Columns[col] != null) dgvProductos.Columns[col].Visible = false;

            //    SetHeader("CodigoInterno", "Código");
            //    SetHeader("CodigoIndustria", "Cód. Barras");
            //    SetHeader("NombreMarca", "Marca");
            //    SetHeader("NombreModelo", "Modelo");
            //    SetHeader("NombreTipoDispositivo", "Tipo");
            //    SetHeader("Color", "Color");
            //    SetHeader("CantidadStock", "Stock");
            //    SetHeader("PrecioColones", "Precio ₡");
            //    SetHeader("PrecioDolares", "Precio $");
            //    SetHeader("Estado", "Activo");
            //    SetHeader("HayStock", "Disponible");
            //}
            //catch (Exception ex) { _log.ErrorFormat("Error CargarGrilla Productos: {0}", ex.Message); }
        }

        private void SetHeader(string col, string header)
        {
            if (dgvProductos.Columns[col] != null) dgvProductos.Columns[col].HeaderText = header;
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvProductos.CurrentRow?.DataBoundItem is Productos p)
            //{
            //    _productoIDSeleccionado = p.ProductoID;
            //    txtCodigoInterno.Text = p.CodigoInterno;
            //    txtCodigoBarras.Text = p.CodigoIndustria;
            //    txtColor.Text = p.Color;
            //    txtCaracteristicas.Text = p.Caracteristicas;
            //    txtExtras.Text = p.Extras;
            //    numStock.Value = p.CantidadStock;
            //    numPrecioColones.Value = p.PrecioColones;
            //    numPrecioDolares.Value = p.PrecioDolares;
            //    chkEstado.Checked = p.Estado;
            //    _fotografia = p.Fotografia;
            //    _documento = p.DocumentoEspecificaciones;
            //    _nombreDocumento = p.NombreDocumento ?? string.Empty;
            //    lblNombreDoc.Text = string.IsNullOrEmpty(_nombreDocumento) ? "(sin documento)" : _nombreDocumento;

            //    // Seleccionar en combos
            //    SetCombo(cboTipo, "TipoDispositivoID", p.TipoDispositivoID);
            //    SetCombo(cboMarca, "MarcaID", p.MarcaID);
            //    SetCombo(cboModelo, "ModeloID", p.ModeloID);

            //    // Mostrar foto
            //    if (_fotografia != null)
            //        picFoto.Image = Image.FromStream(new MemoryStream(_fotografia));
            //    else
            //        picFoto.Image = null;

            //    btnGuardar.Text = "Actualizar";
            //    tabProducto.SelectedIndex = 1; // ir a datos
            //}
        }

        private void SetCombo(ComboBox cbo, string valueMember, int value)
        {
            foreach (var item in cbo.Items)
            {
                var prop = item.GetType().GetProperty(valueMember);
                if (prop != null && (int)prop.GetValue(item) == value)
                { cbo.SelectedItem = item; return; }
            }
        }

        // ── Botones de búsqueda ────────────────────────────────────────

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int? marcaID = cboFiltroMarca.SelectedValue is int m && m > 0 ? (int?)m : null;
            int? modeloID = cboFiltroModelo.SelectedValue is int mo && mo > 0 ? (int?)mo : null;
            int? tipoID = cboFiltroTipo.SelectedValue is int t && t > 0 ? (int?)t : null;
            CargarGrilla(txtFiltro.Text.Trim(), marcaID, modeloID, tipoID);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            cboFiltroMarca.SelectedIndex = -1;
            cboFiltroModelo.SelectedIndex = -1;
            cboFiltroTipo.SelectedIndex = -1;
            CargarGrilla(string.Empty, null, null, null);
        }

        // ── Botones CRUD ───────────────────────────────────────────────

        private void btnNuevo_Click(object sender, EventArgs e) { LimpiarFormulario(); tabProducto.SelectedIndex = 1; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (!ValidarCampos()) return;
            //try
            //{
            //    var producto = new Productos
            //    {
            //        ProductoID = _productoIDSeleccionado,
            //        CodigoInterno = txtCodigoInterno.Text.Trim().ToUpper(),
            //        CodigoIndustria = txtCodigoBarras.Text.Trim(),
            //        TipoDispositivoID = (int)cboTipo.SelectedValue,
            //        ModeloID = (int)cboModelo.SelectedValue,
            //        MarcaID = (int)cboMarca.SelectedValue,
            //        Color = txtColor.Text.Trim(),
            //        Caracteristicas = txtCaracteristicas.Text.Trim(),
            //        Extras = txtExtras.Text.Trim(),
            //        CantidadStock = (int)numStock.Value,
            //        PrecioColones = numPrecioColones.Value,
            //        PrecioDolares = numPrecioDolares.Value,
            //        Estado = chkEstado.Checked,
            //        Fotografia = _fotografia,
            //        DocumentoEspecificaciones = _documento,
            //        NombreDocumento = _nombreDocumento
            //    };

            //    _bllProductos.SaveProducto(producto);
            //    MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    LimpiarFormulario();
            //    CargarGrilla(string.Empty, null, null, null);
            //}
            //catch (Exception ex)
            //{
            //    _log.ErrorFormat("Error GuardarProducto: {0}", ex.Message);
            //    MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (_productoIDSeleccionado == 0) { MessageBox.Show("Seleccione un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            //if (MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    try
            //    {
            //        _bllProductos.DeleteProducto(_productoIDSeleccionado);
            //        LimpiarFormulario();
            //        CargarGrilla(string.Empty, null, null, null);
            //    }
            //    catch (Exception ex) { MessageBox.Show($"No se puede eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //}
        }

        // ── Fotografía ─────────────────────────────────────────────────

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog { Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp", Title = "Seleccionar fotografía del producto" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _fotografia = File.ReadAllBytes(dlg.FileName);
                    picFoto.Image = Image.FromFile(dlg.FileName);
                }
            }
        }

        private void btnQuitarFoto_Click(object sender, EventArgs e)
        { _fotografia = null; picFoto.Image = null; }

        // ── Documento de especificaciones ──────────────────────────────

        private void btnCargarDoc_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog { Filter = "Documentos|*.pdf;*.docx", Title = "Seleccionar documento de especificaciones" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _documento = File.ReadAllBytes(dlg.FileName);
                    _nombreDocumento = Path.GetFileName(dlg.FileName);
                    lblNombreDoc.Text = _nombreDocumento;
                }
            }
        }

        private void btnQuitarDoc_Click(object sender, EventArgs e)
        { _documento = null; _nombreDocumento = string.Empty; lblNombreDoc.Text = "(sin documento)"; }

        // ── Helpers ────────────────────────────────────────────────────

        private void LimpiarFormulario()
        {
            
        }

        

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) btnBuscar_Click(sender, e); }
    }
}