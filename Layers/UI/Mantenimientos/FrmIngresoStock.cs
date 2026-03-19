using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces;
using log4net;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace JarasTech.Layers.UI.Mantenimientos
{
    /// <summary>
    /// Formulario de control de stock.
    /// Permite registrar entradas de mercadería y salidas por inventario físico.
    /// </summary>
    public partial class FrmIngresoStock : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //private readonly IBLLProductos _bllProductos = new BLLProductos();
        //private readonly IBLLMovimientosStock _bllMovimientos = new BLLMovimientosStock();
        //private readonly IBLLTiposMovimientoStock _bllTipos = new BLLTiposMovimientoStock();

        // UsuarioID activo (asignado desde el MDI al abrir el form)
        public int UsuarioIDActivo { get; set; }

        //private Productos _productoSeleccionado = null;

        public FrmIngresoStock() { InitializeComponent(); }

        private void FrmIngresoStock_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    // Tipos de movimiento
            //    cboTipoMovimiento.DataSource = _bllTipos.GetAllTiposMovimiento().ToList();
            //    cboTipoMovimiento.DisplayMember = "NombreTipo";
            //    cboTipoMovimiento.ValueMember = "TipoMovimientoID";
            //    cboTipoMovimiento.SelectedIndex = 0;

            //    dtpFecha.Value = DateTime.Now;
            //    CargarHistorial(string.Empty);
            //    ActualizarPanelPorTipo();
            //}
            //catch (Exception ex) { _log.ErrorFormat("Error Load Stock: {0}", ex.Message); }
        }

        // ── Búsqueda de producto ────────────────────────────────────

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //string filtro = txtBuscarProducto.Text.Trim();
            //if (string.IsNullOrEmpty(filtro))
            //{ MessageBox.Show("Ingrese un código o nombre para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            //var resultados = _bllProductos.GetProductosByFiltro(filtro).ToList();
            //if (!resultados.Any())
            //{ MessageBox.Show("No se encontraron productos.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            //if (resultados.Count == 1)
            //{
            //    SeleccionarProducto(resultados.First());
            //}
            //else
            //{
            //    // Mostrar lista para seleccionar
            //    dgvResultados.DataSource = resultados;
            //    grpResultados.Visible = true;
            //}
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvResultados.Rows[e.RowIndex].DataBoundItem is char p) //cambiar a Productos el char
            {
                SeleccionarProducto(p);
                grpResultados.Visible = false;
            }
        }

        private void SeleccionarProducto(char p) //cambiar a Productos el char
        {
            //_productoSeleccionado = p;
            //lblProductoNombre.Text = $"{p.CodigoInterno} - {p.NombreMarca} {p.NombreModelo} {p.Color}";
            //lblStockActual.Text = $"Stock actual: {p.CantidadStock} unidades";
            //lblStockActual.ForeColor = p.CantidadStock > 0
            //    ? System.Drawing.Color.DarkGreen
            //    : System.Drawing.Color.Red;
        }

        // ── Tipo de movimiento ──────────────────────────────────────

        private void cboTipoMovimiento_SelectedIndexChanged(object sender, EventArgs e) =>
            ActualizarPanelPorTipo();

        private void ActualizarPanelPorTipo()
        {
            bool esEntrada = cboTipoMovimiento.SelectedValue is int id && id == 1;
            lblFacturaCompra.Visible = esEntrada;
            txtFacturaCompra.Visible = esEntrada;
            lblInfoSalida.Visible = !esEntrada;
        }

        // ── Registrar movimiento ────────────────────────────────────

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //if (!ValidarCampos()) return;
            //try
            //{
            //    int tipoMovimientoID = (int)cboTipoMovimiento.SelectedValue;
            //    int cantidad = (int)numCantidad.Value;

            //    // Validar stock para salidas
            //    if (tipoMovimientoID == 2 && _productoSeleccionado.CantidadStock < cantidad)
            //    {
            //        MessageBox.Show($"No hay suficiente stock. Disponible: {_productoSeleccionado.CantidadStock}",
            //            "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    // Registrar movimiento
            //    var movimiento = new MovimientosStock
            //    {
            //        ProductoID = _productoSeleccionado.ProductoID,
            //        TipoMovimientoID = tipoMovimientoID,
            //        Cantidad = cantidad,
            //        FechaMovimiento = dtpFecha.Value,
            //        FacturaCompra = txtFacturaCompra.Text.Trim(),
            //        Observaciones = txtObservaciones.Text.Trim(),
            //        UsuarioID = UsuarioIDActivo
            //    };
            //    _bllMovimientos.SaveMovimiento(movimiento);

            //    // Actualizar stock
            //    if (tipoMovimientoID == 1)
            //        _bllProductos.AumentarStock(_productoSeleccionado.ProductoID, cantidad);
            //    else
            //        _bllProductos.RebajarStock(_productoSeleccionado.ProductoID, cantidad);

            //    MessageBox.Show("Movimiento registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    LimpiarFormulario();
            //    CargarHistorial(string.Empty);
            //}
            //catch (Exception ex)
            //{
            //    _log.ErrorFormat("Error RegistrarMovimiento: {0}", ex.Message);
            //    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void CargarHistorial(string filtro)
        {
            //try
            //{
            //    var lista = _bllMovimientos.GetAllMovimientos()
            //        .Where(m => string.IsNullOrEmpty(filtro) ||
            //                    (m.CodigoProducto ?? "").Contains(filtro, StringComparison.OrdinalIgnoreCase))
            //        .OrderByDescending(m => m.FechaMovimiento)
            //        .ToList();
            //    dgvHistorial.DataSource = lista;

            //    string[] ocultar = { "ProductoID", "TipoMovimientoID", "UsuarioID" };
            //    foreach (var c in ocultar)
            //        if (dgvHistorial.Columns[c] != null) dgvHistorial.Columns[c].Visible = false;

            //    SetHdr("MovimientoID", "ID");
            //    SetHdr("CodigoProducto", "Producto");
            //    SetHdr("NombreTipoMovimiento", "Tipo");
            //    SetHdr("Cantidad", "Cantidad");
            //    SetHdr("FechaMovimiento", "Fecha");
            //    SetHdr("FacturaCompra", "Factura Compra");
            //    SetHdr("Observaciones", "Observaciones");
            //    SetHdr("NombreUsuario", "Usuario");
            //}
            //catch (Exception ex) { _log.ErrorFormat("Error CargarHistorial: {0}", ex.Message); }
        }

        private void SetHdr(string col, string hdr)
        { if (dgvHistorial.Columns[col] != null) dgvHistorial.Columns[col].HeaderText = hdr; }

        private void LimpiarFormulario()
        {
            //_productoSeleccionado = null;
            //txtBuscarProducto.Clear();
            //lblProductoNombre.Text = "—";
            //lblStockActual.Text = "Stock actual: —";
            //numCantidad.Value = 1;
            //txtFacturaCompra.Clear();
            //txtObservaciones.Clear();
            //dtpFecha.Value = DateTime.Now;
            //cboTipoMovimiento.SelectedIndex = 0;
            //grpResultados.Visible = false;
        }

        private bool ValidarCampos()
        {
            //if (_productoSeleccionado == null)
            //{ MessageBox.Show("Seleccione un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            //if (numCantidad.Value <= 0)
            //{ MessageBox.Show("La cantidad debe ser mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarFormulario();

        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) btnBuscarProducto_Click(sender, e); }
    }
}