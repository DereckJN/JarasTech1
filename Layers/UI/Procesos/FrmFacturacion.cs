using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
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

namespace JarasTech.Layers.UI.Procesos
{


    public partial class FrmFacturacion : Form
    {

        public class DetalleFacturaItem
        {
            public int ProductoID { get; set; }
            public string CodigoInterno { get; set; }
            public string Descripcion { get; set; }
            public string TipoDispositivo { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitarioColones { get; set; }
            public decimal PrecioUnitarioDolares { get; set; }
            public decimal SubtotalLinea { get; set; }
            public int StockDisponible { get; set; }
        }

        private static readonly ILog _log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        // ── BLLs ─────────────────────────────────────────────────────────
        private readonly IBLLClientes _bllClientes = new BLLClientes();
        private readonly IBLLProductos _bllProductos = new BLLProductos();
        private readonly IBLLFacturas _bllFacturas = new BLLFacturas();
        private readonly IBLLDetalleFactura _bllDetalle = new BLLDetalleFactura();
        private readonly IBLLPagosFactura _bllPagos = new BLLPagosFactura();
        private readonly IBLLIVA _bllIVA = new BLLIVA();
        private readonly IBLLBancos _bllBancos = new BLLBancos();

        // ── Sesión ────────────────────────────────────────────────────────
        internal Usuarios UsuarioActivo { get; set; }

        // ── Estado ────────────────────────────────────────────────────────
        private Clientes _cliente = null;
        private decimal _tipoCambio = 0m;
        private decimal _porcIVA = 13m;
        private int _ivaID = 1;
        private byte[] _firma = null;

        // Lista en memoria usa el DTO, NO la entidad
        private readonly List<DetalleFacturaItem> _detalle = new List<DetalleFacturaItem>();

        // ── Tipo de cambio ────────────────────────────────────────────────
        private Timer timerTipoCambio;
        private DateTime ultimaFechaActualizacion;

        // ── ErrorProvider ─────────────────────────────────────────────────
        private readonly ErrorProvider _ep = new ErrorProvider();

        // ════════════════════════════════════════════════════════════════════
        // CONSTRUCTOR
        // ════════════════════════════════════════════════════════════════════
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════════════════
        // LOAD
        // ════════════════════════════════════════════════════════════════════
        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                _ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                dtpFecha.Value = DateTime.Now;

                if (UsuarioActivo != null)
                    lblVendedorVal.Text = UsuarioActivo.NombreUsuario;

                CargarTipoCambio();
                CargarCombos();
                CargarIVA();
                LimpiarFormulario();

                timerTipoCambio = new Timer();
                timerTipoCambio.Interval = 3600000; // 1 hora
                timerTipoCambio.Tick += new EventHandler(TimerTipoCambio_Tick);
                timerTipoCambio.Start();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error Load: {0}", ex.Message);
                MessageBox.Show("Error al cargar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════════════════
        // TIPO DE CAMBIO — BCCR
        // ════════════════════════════════════════════════════════════════════
        #region Tipo de Cambio

        private void CargarTipoCambio()
        {
            decimal tc = ObtenerTipoCambioVenta();
            if (tc > 0)
            {
                _tipoCambio = tc;
                lblTipoCambioVal.Text = "₡ " + tc.ToString("N2");
                lblTipoCambioVal.ForeColor = Color.DarkGreen;
                ultimaFechaActualizacion = DateTime.Today;
            }
            else
            {
                lblTipoCambioVal.Text = "No disponible";
                lblTipoCambioVal.ForeColor = Color.OrangeRed;
            }
        }

        private void TimerTipoCambio_Tick(object sender, EventArgs e)
        {
            if (DateTime.Today > ultimaFechaActualizacion)
                CargarTipoCambio();
        }

        private decimal ObtenerTipoCambioVenta()
        {
            try
            {
                ServiceBCCR service = new ServiceBCCR();
                var resultado = service.GetDolar(DateTime.Now, DateTime.Now, "v")
                                             .FirstOrDefault();
                if (resultado != null) return (decimal)resultado.Monto;
                return 0m;
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("BCCR error: {0}", ex.Message);
                return 0m;
            }
        }

        #endregion

        // ════════════════════════════════════════════════════════════════════
        // COMBOS E IVA
        // ════════════════════════════════════════════════════════════════════
        #region Combos e IVA

        private void CargarCombos()
        {
            var bancos = _bllBancos.GetAllBancos().ToList();

            cboBanco.DataSource = bancos;
            cboBanco.DisplayMember = "NombreBanco";
            cboBanco.ValueMember = "BancoID";
            cboBanco.SelectedIndex = -1;

            cboBancoTransf.DataSource = bancos.ToList();
            cboBancoTransf.DisplayMember = "NombreBanco";
            cboBancoTransf.ValueMember = "BancoID";
            cboBancoTransf.SelectedIndex = -1;
        }

        private void CargarIVA()
        {
            var iva = _bllIVA.GetAllIVA().FirstOrDefault();
            if (iva != null) { _porcIVA = iva.Porcentaje; _ivaID = iva.IVAID; }
            lblIVALbl.Text = "IVA (" + _porcIVA.ToString() + "%):";
        }

        #endregion

        // ════════════════════════════════════════════════════════════════════
        // TAB 1 — CLIENTE
        // ════════════════════════════════════════════════════════════════════
        #region Cliente

        private void btnBusqCli_Click(object sender, EventArgs e) { BuscarCliente(); }

        private void txtBusqCli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BuscarCliente();
        }

        private void BuscarCliente()
        {
            string filtro = txtBusqCli.Text.Trim();
            if (string.IsNullOrEmpty(filtro))
            {
                Error(tabCliente, txtBusqCli,
                    "Ingrese cédula o nombre.",
                    "Tab 1 — Cliente: ingrese cédula o nombre.");
                return;
            }
            LimpiarError(txtBusqCli);

            var lista = _bllClientes.GetClientesByNombre(filtro).ToList();
            if (!lista.Any())
            {
                Error(tabCliente, txtBusqCli,
                    "Sin resultados.",
                    "Tab 1 — Cliente: no se encontraron clientes.");
                return;
            }
            if (lista.Count == 1) { SeleccionarCliente(lista.First()); return; }

            using (Form dlg = new Form())
            {
                dlg.Text = "Seleccione el cliente";
                dlg.Size = new Size(720, 360);
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.MaximizeBox = false;
                DataGridView dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    RowHeadersVisible = false,
                    DataSource = lista
                };
                dgv.CellDoubleClick += (s, ev) =>
                {
                    if (ev.RowIndex >= 0 && dgv.Rows[ev.RowIndex].DataBoundItem is Clientes c)
                    { SeleccionarCliente(c); dlg.Close(); }
                };
                dlg.Controls.Add(dgv);
                dlg.ShowDialog(this);
            }
        }

        private void SeleccionarCliente(Clientes c)
        {
            _cliente = c;
            lblNombreCli.Text = "Nombre: " + c.Nombre + " " + c.Apellidos;
            lblCedulaCli.Text = "Cédula: " + c.NumeroIdentificacion;
            lblCorreoCli.Text = "Correo: " + c.CorreoElectronico;
            lblTelCli.Text = "Tel: " + c.Telefono;
            picCliente.Image = c.Fotografia != null
                                ? Image.FromStream(new MemoryStream(c.Fotografia)) : null;
            LimpiarError(txtBusqCli);
            OcultarError();
        }

        #endregion

        // ════════════════════════════════════════════════════════════════════
        // TAB 2 — PRODUCTOS
        // ════════════════════════════════════════════════════════════════════
        #region Productos

        private void btnBusqProd_Click(object sender, EventArgs e) { BuscarProducto(); }

        private void txtBusqProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BuscarProducto();
        }

        private void BuscarProducto()
        {
            string filtro = txtBusqProd.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filtro))
            {
                Error(tabProductos, txtBusqProd,
                    "Ingrese un criterio.",
                    "Tab 2 — Productos: ingrese un criterio de búsqueda.");
                return;
            }
            LimpiarError(txtBusqProd);

            // Usamos IndexOf en lugar de Contains para compatibilidad con .NET 4.8
            var lista = _bllProductos.GetProductosConStock()
                .Where(p =>
                    p.CodigoInterno.ToLower().IndexOf(filtro) >= 0 ||
                    (p.NombreMarca ?? "").ToLower().IndexOf(filtro) >= 0 ||
                    (p.NombreModelo ?? "").ToLower().IndexOf(filtro) >= 0)
                .ToList();

            if (!lista.Any())
            {
                Error(tabProductos, txtBusqProd,
                    "Sin productos con stock.",
                    "Tab 2 — Productos: sin resultados con stock.");
                return;
            }
            if (lista.Count == 1) { AgregarProducto(lista.First()); txtBusqProd.Clear(); return; }

            using (Form dlg = new Form())
            {
                dlg.Text = "Seleccione el producto";
                dlg.Size = new Size(820, 400);
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.MaximizeBox = false;
                DataGridView dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    RowHeadersVisible = false,
                    DataSource = lista
                };
                dgv.CellDoubleClick += (s, ev) =>
                {
                    if (ev.RowIndex >= 0 && dgv.Rows[ev.RowIndex].DataBoundItem is Productos p)
                    { AgregarProducto(p); txtBusqProd.Clear(); dlg.Close(); }
                };
                dlg.Controls.Add(dgv);
                dlg.ShowDialog(this);
            }
        }

        private void AgregarProducto(Productos p)
        {
            // Verificar si el producto ya está en el detalle
            DetalleFacturaItem existente = null;
            foreach (var d in _detalle)
                if (d.ProductoID == p.ProductoID) { existente = d; break; }

            if (existente != null)
            {
                if (existente.Cantidad < p.CantidadStock)
                {
                    existente.Cantidad++;
                    existente.SubtotalLinea = existente.Cantidad * existente.PrecioUnitarioColones;
                    RefrescarDetalle();
                    RecalcularTotales();
                }
                else
                    MessageBox.Show("No hay suficiente stock.", "Stock",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal precioDolares = _tipoCambio > 0
                ? Math.Round(p.PrecioColones / _tipoCambio, 2)
                : p.PrecioDolares;

            string descripcion = ((p.NombreMarca ?? "") + " " +
                                  (p.NombreModelo ?? "") + " " +
                                  (p.Color ?? "")).Trim();

            _detalle.Add(new DetalleFacturaItem
            {
                ProductoID = p.ProductoID,
                CodigoInterno = p.CodigoInterno,
                Descripcion = descripcion,
                TipoDispositivo = p.NombreTipoDispositivo ?? "",
                Cantidad = 1,
                PrecioUnitarioColones = p.PrecioColones,
                PrecioUnitarioDolares = precioDolares,
                SubtotalLinea = p.PrecioColones,
                StockDisponible = p.CantidadStock
            });

            RefrescarDetalle();
            RecalcularTotales();
            OcultarError();
        }

        private void btnQuitarLinea_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null &&
                dgvDetalle.CurrentRow.DataBoundItem is DetalleFacturaItem item)
            {
                _detalle.Remove(item);
                RefrescarDetalle();
                RecalcularTotales();
            }
        }

        private void RefrescarDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = _detalle.ToList();

            // Ocultar columnas internas
            string[] ocultar = { "ProductoID", "StockDisponible", "PrecioUnitarioDolares" };
            foreach (string col in ocultar)
                if (dgvDetalle.Columns[col] != null) dgvDetalle.Columns[col].Visible = false;

            SetHeader("CodigoInterno", "Código");
            SetHeader("Descripcion", "Descripción");
            SetHeader("TipoDispositivo", "Tipo");
            SetHeader("Cantidad", "Cant.");
            SetHeader("PrecioUnitarioColones", "Precio Unit. ₡");
            SetHeader("SubtotalLinea", "Subtotal ₡");
        }

        private void SetHeader(string col, string header)
        {
            if (dgvDetalle.Columns[col] != null)
                dgvDetalle.Columns[col].HeaderText = header;
        }

        private void RecalcularTotales()
        {
            decimal sub = 0;
            foreach (var d in _detalle) sub += d.SubtotalLinea;

            decimal iva = Math.Round(sub * _porcIVA / 100, 2);
            decimal totC = sub + iva;
            decimal totD = _tipoCambio > 0 ? Math.Round(totC / _tipoCambio, 2) : 0;

            lblSubtotalVal.Text = "₡ " + sub.ToString("N2");
            lblIVAVal.Text = "₡ " + iva.ToString("N2");
            lblTotalCVal.Text = "₡ " + totC.ToString("N2");
            lblTotalDVal.Text = "$ " + totD.ToString("N2");
            lblResumenC.Text = "Total ₡: " + totC.ToString("N2");
            lblResumenD.Text = "Total $: " + totD.ToString("N2");
        }

        #endregion

        // ════════════════════════════════════════════════════════════════════
        // TAB 3 — PAGO
        // ════════════════════════════════════════════════════════════════════
        #region Pago

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpTarjeta.Visible = (cboTipoPago.SelectedIndex == 0);
            grpTransf.Visible = (cboTipoPago.SelectedIndex == 1);
            grpSINPE.Visible = (cboTipoPago.SelectedIndex == 2);
            LimpiarError(cboTipoPago);
            OcultarError();
        }

        #endregion

        // ════════════════════════════════════════════════════════════════════
        // TAB 4 — FIRMA
        // ════════════════════════════════════════════════════════════════════
        #region Firma

        private void btnCapturarFirma_Click(object sender, EventArgs e)
        {
            using (var fFirma = new FrmFirmaDigital())
            {
                if (fFirma.ShowDialog(this) == DialogResult.OK)
                {
                    _firma = fFirma.FirmaBytes;
                    picFirma.Image = Image.FromStream(new MemoryStream(_firma));
                    lblFirmaEstado.Text = "Firma capturada correctamente.";
                    lblFirmaEstado.ForeColor = Color.DarkGreen;
                    btnCapturarFirma.Text = "Volver a Firmar";
                    LimpiarError(btnCapturarFirma);
                    OcultarError();
                }
            }
        }

        #endregion

        // ════════════════════════════════════════════════════════════════════
        // GUARDAR FACTURA
        // ════════════════════════════════════════════════════════════════════
        #region Guardar Factura

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            try
            {
                Cursor = Cursors.WaitCursor;
                btnGuardar.Enabled = false;

                decimal sub = 0;
                foreach (var d in _detalle) sub += d.SubtotalLinea;
                decimal iva = Math.Round(sub * _porcIVA / 100, 2);
                decimal totC = sub + iva;
                decimal totD = _tipoCambio > 0 ? Math.Round(totC / _tipoCambio, 2) : 0;

                // 1 — Encabezado factura
                var factura = new Facturas
                {
                    ClienteID = _cliente.ClienteID,
                    UsuarioID = UsuarioActivo != null ? UsuarioActivo.UsuarioID : 1,
                    FechaFactura = dtpFecha.Value,
                    SubtotalColones = sub,
                    MontoIVA = iva,
                    TotalColones = totC,
                    TipoCambio = _tipoCambio,
                    TotalDolares = totD,
                    IVAID = _ivaID,
                    FirmaDigital = _firma,
                    Estado = true
                };
                Facturas facturaGuardada = _bllFacturas.SaveFactura(factura);

                // 2 — Detalle + rebajar stock
                // Aquí convertimos el DTO al objeto entidad DetalleFactura
                foreach (DetalleFacturaItem item in _detalle)
                {
                    _bllDetalle.SaveDetalle(new DetalleFactura
                    {
                        FacturaID = facturaGuardada.FacturaID,
                        ProductoID = item.ProductoID,
                        Cantidad = item.Cantidad,
                        PrecioUnitarioColones = item.PrecioUnitarioColones,
                        PrecioUnitarioDolares = item.PrecioUnitarioDolares,
                        SubtotalLinea = item.SubtotalLinea
                    });
                    _bllProductos.RebajarStock(item.ProductoID, item.Cantidad);
                }

                // 3 — Pago
                GuardarPago(facturaGuardada.FacturaID);

                // 4 — QR
                MostrarQR(facturaGuardada.FacturaID);

                MessageBox.Show(
                    "Factura #" + facturaGuardada.FacturaID.ToString("D8") + " generada exitosamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error GuardarFactura: {0}", ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnGuardar.Enabled = true;
            }
        }

        private void GuardarPago(int facturaID)
        {
            int idx = cboTipoPago.SelectedIndex;
            var pago = new PagosFactura { FacturaID = facturaID, TipoPagoID = idx + 1 };

            switch (idx)
            {
                case 0: // Tarjeta de Crédito — TipoPagoID = 1
                    pago.NumeroTarjeta = txtNumTarjeta.Text.Trim();
                    pago.BancoID = cboBanco.SelectedValue as int?;
                    break;
                case 1: // Transferencia — TipoPagoID = 2
                    pago.BancoID = cboBancoTransf.SelectedValue as int?;
                    pago.NumeroTransferencia = txtNumTransf.Text.Trim();
                    break;
                case 2: // SINPE Móvil — TipoPagoID = 3
                    pago.NumeroSINPE = txtNumSINPE.Text.Trim();
                    break;
            }
            _bllPagos.SavePago(pago);
        }

        private void MostrarQR(int facturaID)
        {
            var bmp = new Bitmap(200, 200);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.DrawRectangle(Pens.Black, 4, 4, 192, 192);
                g.DrawString(
                    "FAC\n#" + facturaID.ToString("D8") + "\nJARAS\nTECH",
                    new Font("Consolas", 13, FontStyle.Bold),
                    Brushes.Black,
                    new RectangleF(18, 35, 165, 160));
            }
            picQR.Image = bmp;
            lblNumQR.Text = "Factura # " + facturaID.ToString("D8");
            tabMain.SelectedIndex = 4; // ir al tab Resumen
        }

        #endregion

        // ════════════════════════════════════════════════════════════════════
        // VALIDACIÓN — ErrorProvider + lblIndicarError
        // ════════════════════════════════════════════════════════════════════
        #region Validación

        private bool Validar()
        {
            _ep.Clear();
            OcultarError();

            // Tab 1 — Cliente
            if (_cliente == null)
            {
                Error(tabCliente, txtBusqCli,
                    "Seleccione un cliente.",
                    "Tab 1 — Cliente: debe seleccionar un cliente.");
                tabMain.SelectedIndex = 0;
                return false;
            }

            // Tab 2 — Productos
            if (_detalle.Count == 0)
            {
                Error(tabProductos, txtBusqProd,
                    "Agregue al menos un producto.",
                    "Tab 2 — Productos: agregue al menos un producto.");
                tabMain.SelectedIndex = 1;
                return false;
            }
            if (_tipoCambio <= 0)
            {
                Error(tabProductos, txtBusqProd,
                    "Tipo de cambio no disponible.",
                    "Tab 2 — Productos: el tipo de cambio no está disponible.");
                tabMain.SelectedIndex = 1;
                return false;
            }

            // Tab 3 — Pago
            if (cboTipoPago.SelectedIndex < 0)
            {
                Error(tabPago, cboTipoPago,
                    "Seleccione el tipo de pago.",
                    "Tab 3 — Pago: seleccione el tipo de pago.");
                tabMain.SelectedIndex = 2;
                return false;
            }
            if (cboTipoPago.SelectedIndex == 0 &&
                string.IsNullOrWhiteSpace(txtNumTarjeta.Text))
            {
                Error(tabPago, txtNumTarjeta,
                    "Ingrese el número de tarjeta.",
                    "Tab 3 — Pago: ingrese el número de tarjeta.");
                tabMain.SelectedIndex = 2;
                return false;
            }
            if (cboTipoPago.SelectedIndex == 1 &&
                string.IsNullOrWhiteSpace(txtNumTransf.Text))
            {
                Error(tabPago, txtNumTransf,
                    "Ingrese el número de transferencia.",
                    "Tab 3 — Pago: ingrese el número de transferencia.");
                tabMain.SelectedIndex = 2;
                return false;
            }
            if (cboTipoPago.SelectedIndex == 2 &&
                string.IsNullOrWhiteSpace(txtNumSINPE.Text))
            {
                Error(tabPago, txtNumSINPE,
                    "Ingrese el número SINPE.",
                    "Tab 3 — Pago: ingrese el número de SINPE Móvil.");
                tabMain.SelectedIndex = 2;
                return false;
            }

            // Tab 4 — Firma (opcional)
            if (_firma == null)
            {
                if (MessageBox.Show(
                    "No se capturó la firma. ¿Continuar sin firma?",
                    "Firma pendiente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                {
                    Error(tabFirma, btnCapturarFirma,
                        "Capture la firma.",
                        "Tab 4 — Firma: capture la firma del cliente.");
                    tabMain.SelectedIndex = 3;
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Pone el icono de error en el control Y escribe en lblIndicarError
        /// indicando en qué tab está el problema.
        /// </summary>
        private void Error(TabPage tab, Control control,
                           string msgControl, string msgLabel)
        {
            _ep.SetError(control, msgControl);
            lblIndicarError.Text = "⚠  " + msgLabel;
            lblIndicarError.ForeColor = Color.Red;
        }

        private void LimpiarError(Control control)
        {
            _ep.SetError(control, string.Empty);
        }

        private void OcultarError()
        {
            lblIndicarError.Text = string.Empty;
        }

        #endregion

        // ════════════════════════════════════════════════════════════════════
        // NUEVA FACTURA / CANCELAR
        // ════════════════════════════════════════════════════════════════════
        #region Limpiar / Nueva Factura

        private void btnNueva_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            _cliente = null; _firma = null; _detalle.Clear();
            _ep.Clear(); OcultarError();

            txtBusqCli.Clear(); txtBusqProd.Clear();
            lblNombreCli.Text = "Nombre: —"; lblCedulaCli.Text = "Cédula: —";
            lblCorreoCli.Text = "Correo: —"; lblTelCli.Text = "Tel: —";
            picCliente.Image = null; picFirma.Image = null;

            lblFirmaEstado.Text = "Sin firma capturada.";
            lblFirmaEstado.ForeColor = Color.OrangeRed;
            btnCapturarFirma.Text = "Capturar Firma del Cliente";

            cboTipoPago.SelectedIndex = -1;
            grpTarjeta.Visible = false; grpTransf.Visible = false; grpSINPE.Visible = false;
            txtNumTarjeta.Clear(); txtNumTransf.Clear(); txtNumSINPE.Clear();
            cboBanco.SelectedIndex = -1; cboBancoTransf.SelectedIndex = -1;
            cboTipoTarjeta.SelectedIndex = -1;

            dgvDetalle.DataSource = null;
            RecalcularTotales();
            dtpFecha.Value = DateTime.Now;
            tabMain.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_detalle.Count > 0)
            {
                if (MessageBox.Show(
                    "¿Desea cancelar la factura en progreso?",
                    "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                    return;
            }
            Close();
        }

        #endregion
    }
}