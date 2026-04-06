using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces;
using JarasTech.Layers.Interfaces.Ibll;
using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace JarasTech.Layers.UI.Mantenimientos
{
    /// <summary>
    /// Formulario de control de stock.
    /// Permite registrar entradas de mercadería y salidas por toma de inventario físico.
    /// El historial completo se muestra en la grilla inferior.
    /// </summary>
    public partial class FrmIngresoStock : Form
    {
        private static readonly ILog _log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly IBLLProductos _bllProductos = new BLLProductos();
        private readonly IBLLMovimientosStock _bllMovimientos = new BLLMovimientosStock();
        private readonly IBLLTiposMovimientoStock _bllTipos = new BLLTiposMovimientoStock();

        /// <summary>ID del usuario activo (asignar desde el MDI al abrir el form).</summary>
        public int UsuarioIDActivo { get; set; } = 1;

        private Productos _productoSeleccionado = null;

        // TipoMovimientoID: 1 = Entrada, 2 = Salida
        private const int ENTRADA = 1;
        private const int SALIDA = 2;

        public FrmIngresoStock()
        {
            InitializeComponent();
        }

        // ── Carga ─────────────────────────────────────────────────────
        private void FrmIngresoStock_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFecha.Value = DateTime.Now;
                CargarHistorial();
                ActualizarPanelPorTipo();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error FrmIngresoStock_Load: {0}", ex.Message);
            }
        }

        // ── Tipo de movimiento ────────────────────────────────────────
        private void rbEntrada_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarPanelPorTipo();
        }

        private void rbSalida_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarPanelPorTipo();
        }

        private void ActualizarPanelPorTipo()
        {
            bool esEntrada = rbEntrada.Checked;

            // Campos exclusivos de ENTRADA
            lblFactura.Visible = esEntrada;
            txtFacturaCompra.Visible = esEntrada;

            // Aviso exclusivo de SALIDA
            lblAvisoSalida.Visible = !esEntrada;

            // Colores del panel
            if (esEntrada)
            {
                pnlTipoIndicador.BackColor = Color.FromArgb(40, 167, 69);
                lblTipoIndicador.Text = "ENTRADA DE STOCK";
            }
            else
            {
                pnlTipoIndicador.BackColor = Color.FromArgb(220, 53, 69);
                lblTipoIndicador.Text = "SALIDA DE STOCK";
            }
        }

        // ── Búsqueda de producto ──────────────────────────────────────
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BuscarProducto();
        }

        private void BuscarProducto()
        {
            string filtro = txtBuscarProducto.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show("Ingrese un código o nombre para buscar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IEnumerable<Productos> todos = _bllProductos.GetAllProductos();
            List<Productos> resultados = todos
                .Where(p => p.CodigoInterno.ToLower().IndexOf(filtro) >= 0 ||
                            (p.NombreMarca ?? "").ToLower().IndexOf(filtro) >= 0 ||
                            (p.NombreModelo ?? "").ToLower().IndexOf(filtro) >= 0)
                .ToList();

            if (!resultados.Any())
            {
                MessageBox.Show("No se encontraron productos con ese criterio.", "Sin resultados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (resultados.Count == 1)
            {
                SeleccionarProducto(resultados.First());
                return;
            }

            // Mostrar grilla de resultados
            dgvResultados.DataSource = resultados;
            grpResultados.Visible = true;
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dgvResultados.Rows[e.RowIndex].DataBoundItem is Productos p)
            {
                SeleccionarProducto(p);
                grpResultados.Visible = false;
            }
        }

        private void SeleccionarProducto(Productos p)
        {
            _productoSeleccionado = p;
            lblProductoNombre.Text = p.CodigoInterno + "  —  " +
                                         (p.NombreMarca ?? "") + " " +
                                         (p.NombreModelo ?? "") + " " +
                                         (p.Color ?? "");
            lblStockActual.Text = "Stock actual: " + p.CantidadStock + " unidades";
            lblStockActual.ForeColor = p.CantidadStock > 0
                                         ? Color.DarkGreen : Color.Red;
            grpResultados.Visible = false;
        }

        // ── Registrar movimiento ──────────────────────────────────────
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int cantidad = (int)numCantidad.Value;
            bool esEntrada = rbEntrada.Checked;
            int tipoMovimiento = esEntrada ? ENTRADA : SALIDA;

            // Validar stock disponible para salidas
            if (!esEntrada && _productoSeleccionado.CantidadStock < cantidad)
            {
                MessageBox.Show(
                    "No hay suficiente stock.\n" +
                    "Disponible: " + _productoSeleccionado.CantidadStock + " unidades.",
                    "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1 — Registrar movimiento
                MovimientosStock movimiento = new MovimientosStock
                {
                    ProductoID = _productoSeleccionado.ProductoID,
                    TipoMovimientoID = tipoMovimiento,
                    Cantidad = cantidad,
                    FechaMovimiento = dtpFecha.Value,
                    FacturaCompra = esEntrada ? txtFacturaCompra.Text.Trim() : string.Empty,
                    Observaciones = txtObservaciones.Text.Trim(),
                    UsuarioID = UsuarioIDActivo
                };
                _bllMovimientos.SaveMovimiento(movimiento);

                // 2 — Actualizar stock del producto
                if (esEntrada)
                    _bllProductos.AumentarStock(_productoSeleccionado.ProductoID, cantidad);
                else
                    _bllProductos.RebajarStock(_productoSeleccionado.ProductoID, cantidad);

                string tipoTexto = esEntrada ? "Entrada" : "Salida";
                MessageBox.Show(
                    tipoTexto + " de " + cantidad + " unidades registrada exitosamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarHistorial();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnRegistrar: {0}", ex.Message);
                MessageBox.Show("Error al registrar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Historial ─────────────────────────────────────────────────
        private void CargarHistorial()
        {
            try
            {
                List<MovimientosStock> lista = _bllMovimientos.GetAllMovimientos()
                    .OrderByDescending(m => m.FechaMovimiento)
                    .ToList();

                dgvHistorial.DataSource = lista;

                // Ocultar columnas internas
                string[] ocultar = { "ProductoID", "TipoMovimientoID", "UsuarioID" };
                foreach (string col in ocultar)
                    if (dgvHistorial.Columns[col] != null)
                        dgvHistorial.Columns[col].Visible = false;

                SetHdr("MovimientoID", "ID");
                SetHdr("CodigoProducto", "Producto");
                SetHdr("NombreTipoMovimiento", "Tipo");
                SetHdr("Cantidad", "Cantidad");
                SetHdr("FechaMovimiento", "Fecha");
                SetHdr("FacturaCompra", "Factura Compra");
                SetHdr("Observaciones", "Observaciones");
                SetHdr("NombreUsuario", "Usuario");

                // Color por tipo de movimiento
                foreach (DataGridViewRow row in dgvHistorial.Rows)
                {
                    if (row.DataBoundItem is MovimientosStock m)
                    {
                        row.DefaultCellStyle.ForeColor =
                            m.TipoMovimientoID == ENTRADA
                            ? Color.DarkGreen
                            : Color.FromArgb(220, 53, 69);
                    }
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error CargarHistorial: {0}", ex.Message);
            }
        }

        private void SetHdr(string col, string header)
        {
            if (dgvHistorial.Columns[col] != null)
                dgvHistorial.Columns[col].HeaderText = header;
        }

        private void btnRefrescarHistorial_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        // ── Limpiar / Cancelar ────────────────────────────────────────
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            _productoSeleccionado = null;
            txtBuscarProducto.Clear();
            lblProductoNombre.Text = "—";
            lblStockActual.Text = "Stock actual: —";
            lblStockActual.ForeColor = Color.DimGray;
            numCantidad.Value = 1;
            txtFacturaCompra.Clear();
            txtObservaciones.Clear();
            dtpFecha.Value = DateTime.Now;
            rbEntrada.Checked = true;
            grpResultados.Visible = false;
            ActualizarPanelPorTipo();
        }

        // ── Validación ────────────────────────────────────────────────
        private bool ValidarCampos()
        {
            if (_productoSeleccionado == null)
            {
                MessageBox.Show("Debe buscar y seleccionar un producto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarProducto.Focus();
                return false;
            }
            if (numCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCantidad.Focus();
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}