using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces.Ibll;
using JarasTech.Layers.Persistencia;
using JarasTech.Layers.Util;
using log4net;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using IContainer = QuestPDF.Infrastructure.IContainer;
using Image = System.Drawing.Image;
using Size = System.Drawing.Size;

namespace JarasTech.Layers.UI.Procesos
{
    public partial class FrmFacturacion : Form
    {
        // ════════════════════════════════════════════════════════════════════
        // DTO en memoria — NO es la entidad DetalleFactura de la BD
        // ════════════════════════════════════════════════════════════════════
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

        // BLLs
        private readonly IBLLClientes _bllClientes = new BLLClientes();
        private readonly IBLLProductos _bllProductos = new BLLProductos();
        private readonly IBLLFacturas _bllFacturas = new BLLFacturas();
        private readonly IBLLDetalleFactura _bllDetalle = new BLLDetalleFactura();
        private readonly IBLLPagosFactura _bllPagos = new BLLPagosFactura();
        private readonly IBLLIVA _bllIVA = new BLLIVA();
        private readonly IBLLBancos _bllBancos = new BLLBancos();

        // Sesión
        internal Usuarios UsuarioActivo { get; set; }

        // Estado
        private Clientes _cliente = null;
        private decimal _tipoCambio = 0m;
        private decimal _porcIVA = 13m;
        private int _ivaID = 1;
        private byte[] _firma = null;
        private readonly List<DetalleFacturaItem> _detalle = new List<DetalleFacturaItem>();

        // Tipo de cambio
        private Timer timerTipoCambio;
        private DateTime ultimaFechaActualizacion;

        // ErrorProvider
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
                if (UsuarioActivo != null)
                    lblVendedorVal.Text = UsuarioActivo.NombreUsuario;


                _ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                dtpFecha.Value = DateTime.Now;

                if (UsuarioActivo != null)
                    lblVendedorVal.Text = UsuarioActivo.NombreUsuario;

                CargarTipoCambio();
                CargarCombos();
                CargarIVA();
                LimpiarFormulario();

                timerTipoCambio = new Timer();
                timerTipoCambio.Interval = 3600000;
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
                Error(tabCliente, txtBusqCli, "Ingrese cédula o nombre.",
                    "Tab 1 — Cliente: ingrese cédula o nombre."); return;
            }
            LimpiarError(txtBusqCli);

            var lista = _bllClientes.GetClientesByNombre(filtro).ToList();
            if (!lista.Any())
            {
                Error(tabCliente, txtBusqCli, "Sin resultados.",
                    "Tab 1 — Cliente: no se encontraron clientes."); return;
            }
            if (lista.Count == 1) { SeleccionarCliente(lista.First()); return; }

            using (Form dlg = new Form())
            {
                // ── Diseño del diálogo ────────────────────────────────────────
                dlg.Text = "Seleccione el cliente";
                dlg.Size = new Size(780, 420);
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.MaximizeBox = false;
                dlg.BackColor = Color.FromArgb(245, 246, 250);

                // Header interno
                var pnlHdr = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 42,
                    BackColor = Color.FromArgb(22, 22, 55)
                };
                var lblHdr = new Label
                {
                    Text = "  👥  Se encontraron " + lista.Count + " clientes",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                };
                pnlHdr.Controls.Add(lblHdr);
                dlg.Controls.Add(pnlHdr);

                // DataGridView solo con columnas útiles
                var dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
                    RowHeadersVisible = false,
                    BackgroundColor = Color.White,
                    BorderStyle = BorderStyle.None,
                    AutoGenerateColumns = false,
                    ColumnHeadersHeight = 32,
                    EnableHeadersVisualStyles = false
                };

                // Estilo encabezado
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 56, 110);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

                // Estilo filas
                dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
                dgv.DefaultCellStyle.ForeColor = Color.FromArgb(22, 56, 110);
                dgv.DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(22, 56, 110);
                dgv.DefaultCellStyle.SelectionForeColor = Color.White;

                // Filas alternas
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(243, 246, 251);
                dgv.RowTemplate.Height = 28;

                // Columnas — solo lo esencial
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NumeroIdentificacion",
                    HeaderText = "Identificación",
                    Width = 130,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Nombre",
                    HeaderText = "Nombre",
                    Width = 160,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    FillWeight = 40
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Apellidos",
                    HeaderText = "Apellidos",
                    Width = 160,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    FillWeight = 40
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Telefono",
                    HeaderText = "Teléfono",
                    Width = 105,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "CorreoElectronico",
                    HeaderText = "Correo",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    FillWeight = 20
                });

                dgv.DataSource = lista;

                dgv.CellDoubleClick += (s, ev) =>
                {
                    if (ev.RowIndex >= 0 && dgv.Rows[ev.RowIndex].DataBoundItem is Clientes c)
                    { SeleccionarCliente(c); dlg.Close(); }
                };

                // Instrucción al pie
                var pnlFoot = new Panel
                {
                    Dock = DockStyle.Bottom,
                    Height = 36,
                    BackColor = Color.FromArgb(235, 237, 245)
                };
                var lblTip = new Label
                {
                    Text = "  Doble clic sobre una fila para seleccionar el cliente",
                    ForeColor = Color.FromArgb(100, 110, 130),
                    Font = new Font("Segoe UI", 8.5f, FontStyle.Italic),
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                };
                pnlFoot.Controls.Add(lblTip);
                dlg.Controls.Add(pnlFoot);
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
                Error(tabProductos, txtBusqProd, "Ingrese un criterio.",
                    "Tab 2 — Productos: ingrese el nombre del producto."); return;
            }
            LimpiarError(txtBusqProd);

            var lista = _bllProductos.GetProductosConStock()
                .Where(p =>
                    p.CodigoInterno.ToLower().IndexOf(filtro) >= 0 ||
                    (p.NombreMarca ?? "").ToLower().IndexOf(filtro) >= 0 ||
                    (p.NombreModelo ?? "").ToLower().IndexOf(filtro) >= 0)
                .ToList();

            if (!lista.Any())
            {
                Error(tabProductos, txtBusqProd, "Sin productos con stock.",
                    "Tab 2 — Productos: sin resultados con stock."); return;
            }
            if (lista.Count == 1) { AgregarProducto(lista.First()); txtBusqProd.Clear(); return; }

            using (Form dlg = new Form())
            {
                dlg.Text = "Seleccione el producto";
                dlg.Size = new Size(860, 440);
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.MaximizeBox = false;
                dlg.BackColor = Color.FromArgb(245, 246, 250);

                // Header
                var pnlHdr = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 42,
                    BackColor = Color.FromArgb(22, 22, 55)
                };
                var lblHdr = new Label
                {
                    Text = "  📦  Se encontraron " + lista.Count + " productos — doble clic para agregar",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                };
                pnlHdr.Controls.Add(lblHdr);
                dlg.Controls.Add(pnlHdr);

                // DataGridView con columnas controladas
                var dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                    AutoGenerateColumns = false,
                    RowHeadersVisible = false,
                    BackgroundColor = Color.White,
                    BorderStyle = BorderStyle.None,
                    ColumnHeadersHeight = 32,
                    EnableHeadersVisualStyles = false
                };

                // Estilo encabezado
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 56, 110);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

                // Estilo filas
                dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
                dgv.DefaultCellStyle.ForeColor = Color.FromArgb(22, 56, 110);
                dgv.DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(22, 56, 110);
                dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(243, 246, 251);
                dgv.RowTemplate.Height = 28;

                // Columnas — solo las relevantes
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "CodigoInterno",
                    HeaderText = "Código",
                    Width = 90,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NombreMarca",
                    HeaderText = "Marca",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    FillWeight = 22
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NombreModelo",
                    HeaderText = "Modelo",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    FillWeight = 22
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NombreTipoDispositivo",
                    HeaderText = "Tipo",
                    Width = 120,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Color",
                    HeaderText = "Color",
                    Width = 80,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "CantidadStock",
                    HeaderText = "Stock",
                    Width = 60,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "PrecioColones",
                    HeaderText = "Precio ₡",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    FillWeight = 34
                });

                dgv.DataSource = lista;

                dgv.CellDoubleClick += (s, ev) =>
                {
                    if (ev.RowIndex >= 0 && dgv.Rows[ev.RowIndex].DataBoundItem is Productos p)
                    { AgregarProducto(p); txtBusqProd.Clear(); dlg.Close(); }
                };

                // Pie
                var pnlFoot = new Panel
                {
                    Dock = DockStyle.Bottom,
                    Height = 36,
                    BackColor = Color.FromArgb(235, 237, 245)
                };
                var lblTip = new Label
                {
                    Text = "  Doble clic sobre una fila para agregar el producto a la factura",
                    ForeColor = Color.FromArgb(100, 110, 130),
                    Font = new Font("Segoe UI", 8.5f, FontStyle.Italic),
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                };
                pnlFoot.Controls.Add(lblTip);
                dlg.Controls.Add(pnlFoot);
                dlg.Controls.Add(dgv);

                dlg.ShowDialog(this);
            }
        }

        private void AgregarProducto(Productos p)
        {
            DetalleFacturaItem existente = null;
            foreach (var d in _detalle)
                if (d.ProductoID == p.ProductoID) { existente = d; break; }

            if (existente != null)
            {
                if (existente.Cantidad < p.CantidadStock)
                {
                    existente.Cantidad++;
                    existente.SubtotalLinea = existente.Cantidad * existente.PrecioUnitarioColones;
                    RefrescarDetalle(); RecalcularTotales();
                }
                else
                    MessageBox.Show("No hay suficiente stock.", "Stock",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal precioDolares = _tipoCambio > 0
                ? Math.Round(p.PrecioColones / _tipoCambio, 2) : p.PrecioDolares;

            _detalle.Add(new DetalleFacturaItem
            {
                ProductoID = p.ProductoID,
                CodigoInterno = p.CodigoInterno,
                Descripcion = ((p.NombreMarca ?? "") + " " +
                                         (p.NombreModelo ?? "") + " " +
                                         (p.Color ?? "")).Trim(),
                TipoDispositivo = p.NombreTipoDispositivo ?? "",
                Cantidad = 1,
                PrecioUnitarioColones = p.PrecioColones,
                PrecioUnitarioDolares = precioDolares,
                SubtotalLinea = p.PrecioColones,
                StockDisponible = p.CantidadStock
            });
            RefrescarDetalle(); RecalcularTotales(); OcultarError();
        }

        private void btnQuitarLinea_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null &&
                dgvDetalle.CurrentRow.DataBoundItem is DetalleFacturaItem item)
            { _detalle.Remove(item); RefrescarDetalle(); RecalcularTotales(); }
        }

        private void RefrescarDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = _detalle.ToList();
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

        /// <summary>
        /// Devuelve una descripción del método de pago sin datos sensibles completos.
        /// Tarjeta: muestra solo los últimos 4 dígitos. Transferencia/SINPE: referencia parcial.
        /// </summary>
        private string ObtenerDescripcionPago()
        {
            switch (cboTipoPago.SelectedIndex)
            {
                case 0: // Tarjeta de Crédito
                    string numTarjeta = txtNumTarjeta.Text.Trim();
                    string ultimos = numTarjeta.Length >= 4
                        ? "**** **** **** " + numTarjeta.Substring(numTarjeta.Length - 4)
                        : "****";
                    string tipoTarj = cboTipoTarjeta.SelectedIndex >= 0
                        ? cboTipoTarjeta.SelectedItem.ToString() : "";
                    string bancoTarj = cboBanco.SelectedIndex >= 0
                        ? ((dynamic)cboBanco.SelectedItem).NombreBanco : "";
                    return "Tarjeta de Crédito " + tipoTarj
                        + "\nN°: " + ultimos
                        + (string.IsNullOrEmpty(bancoTarj) ? "" : "\nBanco: " + bancoTarj);

                case 1: // Transferencia
                    string numTransf = txtNumTransf.Text.Trim();
                    string refTransf = numTransf.Length >= 4
                        ? numTransf.Substring(0, 4) + "****"
                        : "****";
                    string bancoTransf = cboBancoTransf.SelectedIndex >= 0
                        ? ((dynamic)cboBancoTransf.SelectedItem).NombreBanco : "";
                    return "Transferencia Bancaria"
                        + (string.IsNullOrEmpty(bancoTransf) ? "" : "\nBanco: " + bancoTransf)
                        + "\nRef.: " + refTransf;

                case 2: // SINPE
                    string numSinpe = txtNumSINPE.Text.Trim();
                    string sinpeMask = numSinpe.Length >= 4
                        ? "****" + numSinpe.Substring(numSinpe.Length - 4)
                        : "****";
                    return "SINPE Móvil\nN°: " + sinpeMask;

                default:
                    return "—";
            }
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
                    picFirma.Image = System.Drawing.Image.FromStream(new MemoryStream(_firma));
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
                Cursor = Cursors.WaitCursor; btnGuardar.Enabled = false;

                decimal sub = 0;
                foreach (var d in _detalle) sub += d.SubtotalLinea;
                decimal iva = Math.Round(sub * _porcIVA / 100, 2);
                decimal totC = sub + iva;
                decimal totD = _tipoCambio > 0 ? Math.Round(totC / _tipoCambio, 2) : 0;

                // 1 — Encabezado
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

                // 2 — Detalle + stock
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

                // 4 — QR placeholder
                MostrarQR(facturaGuardada.FacturaID);

                // 5 — PDF + XML + Correo
                string xml = GenerarXMLFactura(facturaGuardada);
                string rutaPDF = GenerarPDF(facturaGuardada);

                if (!string.IsNullOrEmpty(_cliente.CorreoElectronico))
                    EnviarCorreo(_cliente.CorreoElectronico, rutaPDF, xml,
                                 facturaGuardada.FacturaID);

                MessageBox.Show(
                    "Factura #" + facturaGuardada.FacturaID.ToString("D8") +
                    " generada exitosamente.\n" +
                    "PDF guardado en carpeta Facturas.",
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
                Cursor = Cursors.Default; btnGuardar.Enabled = true;
            }
        }

        private void GuardarPago(int facturaID)
        {
            int idx = cboTipoPago.SelectedIndex;
            var pago = new PagosFactura { FacturaID = facturaID, TipoPagoID = idx + 1 };
            switch (idx)
            {
                case 0:
                    pago.NumeroTarjeta = txtNumTarjeta.Text.Trim();
                    pago.BancoID = cboBanco.SelectedValue as int?; break;
                case 1:
                    pago.BancoID = cboBancoTransf.SelectedValue as int?;
                    pago.NumeroTransferencia = txtNumTransf.Text.Trim(); break;
                case 2:
                    pago.NumeroSINPE = txtNumSINPE.Text.Trim(); break;
            }
            _bllPagos.SavePago(pago);
        }

        private void MostrarQR(int facturaID)
        {
            try
            {
                // Contenido del QR — datos clave de la factura
                string contenido =
                    "JarasTech" +
                    "|FAC#" + facturaID.ToString("D8");

                // Generar QR con QRCoder
                using (var qrGenerator = new QRCoder.QRCodeGenerator())
                {
                    var qrData = qrGenerator.CreateQrCode(
                        contenido,
                        QRCoder.QRCodeGenerator.ECCLevel.Q);

                    using (var qrCode = new QRCoder.QRCode(qrData))
                    {
                        // 10 = pixelsPorModulo (tamaño de cada cuadrito del QR)
                        Bitmap qrBitmap = qrCode.GetGraphic(10);
                        picQR.Image = qrBitmap;
                    }
                }

                lblNumQR.Text = "Factura # " + facturaID.ToString("D8");
                tabMain.SelectedIndex = 4;
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error generando QR: {0}", ex.Message);
                // Fallback al placeholder si QRCoder falla
                var bmp = new Bitmap(200, 200);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                    g.DrawRectangle(Pens.Black, 4, 4, 192, 192);
                    g.DrawString("FAC\n#" + facturaID.ToString("D8") + "\nJARAS\nTECH",
                        new Font("Consolas", 13, FontStyle.Bold), Brushes.Black,
                        new RectangleF(18, 35, 165, 160));
                }
                picQR.Image = bmp;
                lblNumQR.Text = "Factura # " + facturaID.ToString("D8");
                tabMain.SelectedIndex = 4;
            }
        }

        #endregion

        // ════════════════════════════════════════════════════════════════════
        // PDF — QuestPDF
        // ════════════════════════════════════════════════════════════════════
        #region PDF y Correo

        /// <summary>
        /// Genera el PDF de la factura con QuestPDF y lo guarda en la carpeta Facturas.
        /// Devuelve la ruta completa del archivo generado.
        /// </summary>
        private string GenerarPDF(Facturas factura)
        {
            byte[] logoBytes = PDFHelper.ObtenerLogoBytes();
            QuestPDF.Settings.License = LicenseType.Community;

            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Facturas");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            string ruta = Path.Combine(dir,
                "Factura_" + factura.FacturaID.ToString("D8") + ".pdf");

            decimal sub = 0; foreach (var d in _detalle) sub += d.SubtotalLinea;
            decimal iva = Math.Round(sub * _porcIVA / 100, 2);
            decimal totC = sub + iva;
            decimal totD = _tipoCambio > 0 ? Math.Round(totC / _tipoCambio, 2) : 0;

            // Convertir QR a bytes PNG
            byte[] qrBytes = null;
            if (picQR.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    picQR.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    qrBytes = ms.ToArray();
                }
            }

            // Firma ya está como byte[] en _firma
            byte[] firmaBytes = (_firma != null && _firma.Length > 0) ? _firma : null;

            Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(30);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontFamily("Segoe UI").FontSize(10));

                    // ── ENCABEZADO ────────────────────────────────────────
                    page.Header().Column(h =>
                    {
                        h.Item().Row(row =>
                        {
                            // ── Logo ──────────────────────────────────────────────
                            if (logoBytes != null)
                                row.ConstantItem(70).Height(55).Image(logoBytes);
                            else
                                row.ConstantItem(70);

                            // ── Datos empresa ──────────────────────────────────────
                            row.RelativeItem().PaddingLeft(8).Column(col =>
                            {
                                col.Item().Text("JarasTech")
                                    .FontSize(22).Bold().FontColor(Colors.Blue.Darken3);
                                col.Item().Text("Venta de Dispositivos Electrónicos")
                                    .FontSize(10).FontColor(Colors.Grey.Darken1);
                                col.Item().Text("ventas@jarastech.com  |  San José, Costa Rica")
                                    .FontSize(9);
                            });

                            // ── Datos factura ──────────────────────────────────────
                            row.RelativeItem().AlignRight().Column(col =>
                            {
                                col.Item().Text("FACTURA ELECTRÓNICA")
                                    .FontSize(16).Bold().FontColor(Colors.Blue.Darken2);
                                col.Item().Text("# " + factura.FacturaID.ToString("D8"))
                                    .FontSize(12).Bold();
                                col.Item().Text("Fecha: " +
                                    factura.FechaFactura.ToString("dd/MM/yyyy HH:mm"))
                                    .FontSize(9);
                                if (UsuarioActivo != null)
                                    col.Item().PaddingTop(4)
                                        .Text("Atendido por: " + UsuarioActivo.NombreUsuario)
                                        .FontSize(9).FontColor(Colors.Grey.Darken1);
                            });
                        });
                        h.Item().PaddingTop(6).LineHorizontal(2).LineColor(Colors.Blue.Darken2);
                    });

                    // ── CONTENIDO ─────────────────────────────────────────
                    page.Content().PaddingVertical(12).Column(content =>
                    {
                        // Datos cliente + pago
                        content.Item().Background(Colors.Grey.Lighten4).Padding(10).Row(r =>
                        {
                            r.RelativeItem().Column(col =>
                            {
                                col.Item().Text("CLIENTE").Bold().FontSize(8)
                                    .FontColor(Colors.Grey.Darken2);
                                col.Item().Text(_cliente.Nombre + " " + _cliente.Apellidos)
                                    .FontSize(11).Bold();
                                col.Item().Text("Cédula: " + _cliente.NumeroIdentificacion).FontSize(9);
                                col.Item().Text("Correo: " + _cliente.CorreoElectronico).FontSize(9);
                                col.Item().Text("Tel: " + _cliente.Telefono).FontSize(9);
                            });
                            r.ConstantItem(20);
                            r.RelativeItem().Column(col =>
                            {
                                col.Item().Text("DATOS DE PAGO").Bold().FontSize(8)
                                    .FontColor(Colors.Grey.Darken2);
                                col.Item().Text("Tipo cambio: ₡ " + _tipoCambio.ToString("N2")).FontSize(9);
                                col.Item().Text("IVA aplicado: " + _porcIVA + "%").FontSize(9);
                                if (UsuarioActivo != null)
                                    col.Item().Text("Vendedor: " + UsuarioActivo.NombreUsuario).FontSize(9);

                                // Método de pago con datos no sensibles
                                col.Item().PaddingTop(4).Text("MÉTODO DE PAGO").Bold().FontSize(8)
                                    .FontColor(Colors.Grey.Darken2);
                                string[] lineasPago = ObtenerDescripcionPago().Split('\n');
                                foreach (string linea in lineasPago)
                                    col.Item().Text(linea).FontSize(9);
                            });
                        });

                        content.Item().PaddingVertical(10);

                        // Tabla detalle
                        content.Item().Table(table =>
                        {
                            table.ColumnsDefinition(c =>
                            {
                                c.ConstantColumn(70);
                                c.RelativeColumn(4);
                                c.ConstantColumn(70);
                                c.ConstantColumn(40);
                                c.ConstantColumn(95);
                                c.ConstantColumn(95);
                            });

                            Func<IContainer, IContainer> encHdr = c =>
                                c.Background(Colors.Blue.Darken2).Padding(6)
                                 .DefaultTextStyle(t => t.Bold().FontSize(9)
                                     .FontColor(Colors.White));

                            table.Header(h =>
                            {
                                h.Cell().Element(encHdr).Text("Código");
                                h.Cell().Element(encHdr).Text("Descripción");
                                h.Cell().Element(encHdr).AlignCenter().Text("Tipo");
                                h.Cell().Element(encHdr).AlignCenter().Text("Cant.");
                                h.Cell().Element(encHdr).AlignRight().Text("Precio ₡");
                                h.Cell().Element(encHdr).AlignRight().Text("Subtotal ₡");
                            });

                            bool alterno = false;
                            foreach (DetalleFacturaItem item in _detalle)
                            {
                                bool alt = alterno;
                                Func<IContainer, IContainer> cel = c =>
                                {
                                    if (alt) c = c.Background(Colors.Grey.Lighten5);
                                    return c.BorderBottom(1)
                                            .BorderColor(Colors.Grey.Lighten2)
                                            .Padding(5)
                                            .DefaultTextStyle(t => t.FontSize(9));
                                };
                                table.Cell().Element(cel).Text(item.CodigoInterno);
                                table.Cell().Element(cel).Text(item.Descripcion);
                                table.Cell().Element(cel).AlignCenter().Text(item.TipoDispositivo);
                                table.Cell().Element(cel).AlignCenter().Text(item.Cantidad.ToString());
                                table.Cell().Element(cel).AlignRight()
                                    .Text("₡ " + item.PrecioUnitarioColones.ToString("N2"));
                                table.Cell().Element(cel).AlignRight()
                                    .Text("₡ " + item.SubtotalLinea.ToString("N2"));
                                alterno = !alterno;
                            }
                        });

                        content.Item().PaddingTop(12);

                        // Totales
                        content.Item().AlignRight().Width(300).Column(tot =>
                        {
                            tot.Item().Row(r =>
                            {
                                r.RelativeItem().Text("Subtotal:").FontSize(10);
                                r.ConstantItem(130).AlignRight()
                                    .Text("₡ " + sub.ToString("N2")).FontSize(10);
                            });
                            tot.Item().Row(r =>
                            {
                                r.RelativeItem().Text("IVA (" + _porcIVA + "%):").FontSize(10);
                                r.ConstantItem(130).AlignRight()
                                    .Text("₡ " + iva.ToString("N2")).FontSize(10);
                            });
                            tot.Item().PaddingVertical(3).LineHorizontal(1)
                                .LineColor(Colors.Blue.Darken2);
                            tot.Item().Row(r =>
                            {
                                r.RelativeItem().Text("TOTAL ₡:").FontSize(13).Bold()
                                    .FontColor(Colors.Green.Darken2);
                                r.ConstantItem(130).AlignRight()
                                    .Text("₡ " + totC.ToString("N2")).FontSize(13).Bold()
                                    .FontColor(Colors.Green.Darken2);
                            });
                            // ── Total en letras ────────────────────────────────────────
                            content.Item().PaddingTop(8)
                                .Background(Colors.Blue.Lighten5)
                                .Padding(8)
                                .Column(col =>
                                {
                                    col.Item().Text("SON:").Bold().FontSize(8)
            .FontColor(Colors.Grey.Darken2);
                                    col.Item().Text(PDFHelper.Capitalizar(PDFHelper.MontoALetras(totC)))
            .FontSize(10).Bold().FontColor(Colors.Blue.Darken3);
                                });

                            tot.Item().Row(r =>
                            {
                                r.RelativeItem().Text("TOTAL $:").FontSize(13).Bold()
                                    .FontColor(Colors.Blue.Darken2);
                                r.ConstantItem(130).AlignRight()
                                    .Text("$ " + totD.ToString("N2")).FontSize(13).Bold()
                                    .FontColor(Colors.Blue.Darken2);
                            });
                        });

                        content.Item().PaddingTop(20).LineHorizontal(1)
                            .LineColor(Colors.Grey.Lighten2);

                        // ── QR + FIRMA lado a lado ─────────────────────────
                        content.Item().PaddingTop(15).Row(row =>
                        {
                            // QR
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("Código QR de verificación")
                                    .Bold().FontSize(9).FontColor(Colors.Grey.Darken2);
                                col.Item().PaddingTop(4);
                                if (qrBytes != null)
                                    col.Item().Width(120).Height(120).Image(qrBytes);
                                else
                                    col.Item().Width(120).Height(120)
                                        .Background(Colors.Grey.Lighten3)
                                        .AlignCenter().AlignMiddle()
                                        .Text("Sin QR").FontSize(8);
                                col.Item().PaddingTop(3)
                                    .Text("FAC #" + factura.FacturaID.ToString("D8"))
                                    .FontSize(8).FontColor(Colors.Grey.Darken1);
                            });

                            // Firma
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("Firma digital del cliente")
                                    .Bold().FontSize(9).FontColor(Colors.Grey.Darken2);
                                col.Item().PaddingTop(4);
                                if (firmaBytes != null)
                                    col.Item().Width(200).Height(80).Image(firmaBytes);
                                else
                                    col.Item().Width(200).Height(80)
                                        .Background(Colors.Grey.Lighten3)
                                        .Border(1).BorderColor(Colors.Grey.Lighten2)
                                        .AlignCenter().AlignMiddle()
                                        .Text("Sin firma capturada").FontSize(8)
                                        .FontColor(Colors.Grey.Darken1);

                                col.Item().PaddingTop(3).LineHorizontal(1)
                                    .LineColor(Colors.Grey.Darken1);
                                col.Item().Text(_cliente.Nombre + " " + _cliente.Apellidos)
                                    .FontSize(8).FontColor(Colors.Grey.Darken1);
                                col.Item().Text("C.I. " + _cliente.NumeroIdentificacion)
                                    .FontSize(8).FontColor(Colors.Grey.Darken1);
                            });
                        });
                    });

                    // ── PIE ───────────────────────────────────────────────
                    page.Footer().AlignCenter()
                        .Text("Gracias por su compra en JarasTech. ¡Vuelva pronto!")
                        .FontSize(9).FontColor(Colors.Grey.Darken1);
                });
            }).GeneratePdf(ruta);

            return ruta;
        }

        private string GenerarXMLFactura(Facturas factura)
        {
            decimal sub = 0; foreach (var d in _detalle) sub += d.SubtotalLinea;
            decimal iva = Math.Round(sub * _porcIVA / 100, 2);
            decimal totC = sub + iva;
            decimal totD = _tipoCambio > 0 ? Math.Round(totC / _tipoCambio, 2) : 0;

            var sb = new System.Text.StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            sb.AppendLine("<Factura>");
            sb.AppendLine("  <Encabezado>");
            sb.AppendLine("    <FacturaID>" + factura.FacturaID + "</FacturaID>");
            sb.AppendLine("    <Fecha>" + factura.FechaFactura.ToString("yyyy-MM-ddTHH:mm:ss") + "</Fecha>");
            sb.AppendLine("    <TipoCambio>" + _tipoCambio + "</TipoCambio>");
            sb.AppendLine("    <PorcIVA>" + _porcIVA + "</PorcIVA>");
            sb.AppendLine("    <Subtotal>" + sub + "</Subtotal>");
            sb.AppendLine("    <MontoIVA>" + iva + "</MontoIVA>");
            sb.AppendLine("    <TotalColones>" + totC + "</TotalColones>");
            sb.AppendLine("    <TotalDolares>" + totD + "</TotalDolares>");
            sb.AppendLine("    <Cliente>");
            sb.AppendLine("      <Identificacion>" + _cliente.NumeroIdentificacion + "</Identificacion>");
            sb.AppendLine("      <Nombre>" + _cliente.Nombre + " " + _cliente.Apellidos + "</Nombre>");
            sb.AppendLine("      <Correo>" + _cliente.CorreoElectronico + "</Correo>");
            sb.AppendLine("    </Cliente>");
            if (UsuarioActivo != null)
                sb.AppendLine("    <Vendedor>" + UsuarioActivo.NombreUsuario + "</Vendedor>");
            sb.AppendLine("  </Encabezado>");
            sb.AppendLine("  <Detalle>");
            foreach (DetalleFacturaItem item in _detalle)
            {
                sb.AppendLine("    <Linea>");
                sb.AppendLine("      <Codigo>" + item.CodigoInterno + "</Codigo>");
                sb.AppendLine("      <Descripcion>" + item.Descripcion + "</Descripcion>");
                sb.AppendLine("      <Tipo>" + item.TipoDispositivo + "</Tipo>");
                sb.AppendLine("      <Cantidad>" + item.Cantidad + "</Cantidad>");
                sb.AppendLine("      <PrecioUnit>" + item.PrecioUnitarioColones + "</PrecioUnit>");
                sb.AppendLine("      <Subtotal>" + item.SubtotalLinea + "</Subtotal>");
                sb.AppendLine("    </Linea>");
            }
            sb.AppendLine("  </Detalle>");
            sb.AppendLine("</Factura>");
            return sb.ToString();
        }

        /// <summary>
        /// Envía la factura por correo al cliente con PDF y XML adjuntos.
        /// Si falla no interrumpe el flujo — solo muestra un aviso.
        /// </summary>
        private void EnviarCorreo(string destinatario, string rutaPDF,
                                  string xmlContenido, int facturaID)
        {
            try
            {
                var mail = new MailMessage();
                mail.From = new MailAddress("jarastech.ventas@gmail.com", "JarasTech");
                mail.To.Add(destinatario);
                mail.Subject = "Factura JarasTech #" + facturaID.ToString("D8");
                mail.Body =
                    "Estimado/a cliente,\n\n" +
                    "Adjunto encontrará su factura electrónica en formato PDF y XML.\n\n" +
                    "Gracias por su compra en JarasTech.\n" +
                    "Atención al cliente: ventas@jarastech.com";

                // Adjunto PDF
                mail.Attachments.Add(new Attachment(rutaPDF));

                // Adjunto XML
                byte[] xmlBytes = Encoding.UTF8.GetBytes(xmlContenido);
                mail.Attachments.Add(new Attachment(
                    new MemoryStream(xmlBytes),
                    "Factura_" + facturaID.ToString("D8") + ".xml",
                    "text/xml"));

                var smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential(
                    "jaracycle@gmail.com",
                    "ilhs ccar mhtr iuso"); // ← contraseña de app Gmail

                smtp.Send(mail);
                _log.InfoFormat("Correo enviado a {0} — Factura #{1}",
                    destinatario, facturaID);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error al enviar correo: {0}", ex.Message);
                MessageBox.Show(
                    "La factura se guardó correctamente pero no se pudo enviar el correo:\n" +
                    ex.Message,
                    "Aviso correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        // ════════════════════════════════════════════════════════════════════
        // VALIDACIÓN
        // ════════════════════════════════════════════════════════════════════
        #region Validación

        private bool Validar()
        {
            _ep.Clear(); OcultarError();

            if (_cliente == null)
            {
                Error(tabCliente, txtBusqCli, "Seleccione un cliente.",
                    "Tab 1 — Cliente: debe seleccionar un cliente.");
                tabMain.SelectedIndex = 0; return false;
            }
            if (_detalle.Count == 0)
            {
                Error(tabProductos, txtBusqProd, "Agregue al menos un producto.",
                    "Tab 2 — Productos: agregue al menos un producto.");
                tabMain.SelectedIndex = 1; return false;
            }
            if (_tipoCambio <= 0)
            {
                Error(tabProductos, txtBusqProd, "Tipo de cambio no disponible.",
                    "Tab 2 — Productos: el tipo de cambio no está disponible.");
                tabMain.SelectedIndex = 1; return false;
            }
            if (cboTipoPago.SelectedIndex < 0)
            {
                Error(tabPago, cboTipoPago, "Seleccione el tipo de pago.",
                    "Tab 3 — Pago: seleccione el tipo de pago.");
                tabMain.SelectedIndex = 2; return false;
            }
            if (cboTipoPago.SelectedIndex == 0 &&
                string.IsNullOrWhiteSpace(txtNumTarjeta.Text))
            {
                Error(tabPago, txtNumTarjeta, "Ingrese el número de tarjeta.",
                    "Tab 3 — Pago: ingrese el número de tarjeta.");
                tabMain.SelectedIndex = 2; return false;
            }
            if (cboTipoPago.SelectedIndex == 1 &&
                string.IsNullOrWhiteSpace(txtNumTransf.Text))
            {
                Error(tabPago, txtNumTransf, "Ingrese el número de transferencia.",
                    "Tab 3 — Pago: ingrese el número de transferencia.");
                tabMain.SelectedIndex = 2; return false;
            }
            if (cboTipoPago.SelectedIndex == 2 &&
                string.IsNullOrWhiteSpace(txtNumSINPE.Text))
            {
                Error(tabPago, txtNumSINPE, "Ingrese el número SINPE.",
                    "Tab 3 — Pago: ingrese el número de SINPE Móvil.");
                tabMain.SelectedIndex = 2; return false;
            }
            if (_firma == null)
            {
                if (MessageBox.Show("No se capturó la firma. ¿Continuar sin firma?",
                    "Firma pendiente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                {
                    Error(tabFirma, btnCapturarFirma, "Capture la firma.",
                        "Tab 4 — Firma: capture la firma del cliente.");
                    tabMain.SelectedIndex = 3; return false;
                }
            }
            return true;
        }

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

        private void btnNueva_Click(object sender, EventArgs e) { LimpiarFormulario(); }

        private void LimpiarFormulario()
        {
            _cliente = null; _firma = null; _detalle.Clear();
            _ep.Clear(); OcultarError();

            txtBusqCli.Clear(); txtBusqProd.Clear();
            lblNombreCli.Text = "Nombre: —"; lblCedulaCli.Text = "Cédula: —";
            lblCorreoCli.Text = "Correo: —"; lblTelCli.Text = "Tel: —";
            picCliente.Image = null; picFirma.Image = null;

            lblFirmaEstado.Text = "Sin firma capturada.";
            lblFirmaEstado.ForeColor = System.Drawing.Color.OrangeRed;
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
                if (MessageBox.Show("¿Desea cancelar la factura en progreso?",
                    "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No) return;
            }
            Close();
        }

        #endregion
    }
}