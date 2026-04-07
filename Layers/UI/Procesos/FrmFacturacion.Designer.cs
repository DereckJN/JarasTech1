namespace JarasTech.Layers.UI.Procesos
{
    partial class FrmFacturacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.grpBusqCli = new System.Windows.Forms.GroupBox();
            this.lblBusqCli = new System.Windows.Forms.Label();
            this.txtBusqCli = new System.Windows.Forms.TextBox();
            this.btnBusqCli = new System.Windows.Forms.Button();
            this.grpDatosCli = new System.Windows.Forms.GroupBox();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.lblCedulaCli = new System.Windows.Forms.Label();
            this.lblCorreoCli = new System.Windows.Forms.Label();
            this.lblTelCli = new System.Windows.Forms.Label();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.grpBusqProd = new System.Windows.Forms.GroupBox();
            this.lblBusqProd = new System.Windows.Forms.Label();
            this.txtBusqProd = new System.Windows.Forms.TextBox();
            this.btnBusqProd = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnQuitarLinea = new System.Windows.Forms.Button();
            this.lblSubtotalLbl = new System.Windows.Forms.Label();
            this.lblSubtotalVal = new System.Windows.Forms.Label();
            this.lblIVALbl = new System.Windows.Forms.Label();
            this.lblIVAVal = new System.Windows.Forms.Label();
            this.lblTotalCLbl = new System.Windows.Forms.Label();
            this.lblTotalCVal = new System.Windows.Forms.Label();
            this.lblTotalDLbl = new System.Windows.Forms.Label();
            this.lblTotalDVal = new System.Windows.Forms.Label();
            this.tabPago = new System.Windows.Forms.TabPage();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.grpTarjeta = new System.Windows.Forms.GroupBox();
            this.lblNumTarjeta = new System.Windows.Forms.Label();
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.lblBancoTarjeta = new System.Windows.Forms.Label();
            this.cboBanco = new System.Windows.Forms.ComboBox();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.cboTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.grpTransf = new System.Windows.Forms.GroupBox();
            this.lblBancoTransf = new System.Windows.Forms.Label();
            this.cboBancoTransf = new System.Windows.Forms.ComboBox();
            this.lblNumTransf = new System.Windows.Forms.Label();
            this.txtNumTransf = new System.Windows.Forms.TextBox();
            this.grpSINPE = new System.Windows.Forms.GroupBox();
            this.lblNumSINPE = new System.Windows.Forms.Label();
            this.txtNumSINPE = new System.Windows.Forms.TextBox();
            this.tabFirma = new System.Windows.Forms.TabPage();
            this.lblFirmaInfo = new System.Windows.Forms.Label();
            this.picFirma = new System.Windows.Forms.PictureBox();
            this.btnCapturarFirma = new System.Windows.Forms.Button();
            this.lblFirmaEstado = new System.Windows.Forms.Label();
            this.tabResumen = new System.Windows.Forms.TabPage();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.lblNumQR = new System.Windows.Forms.Label();
            this.lblTipoCambioLbl = new System.Windows.Forms.Label();
            this.lblTipoCambioVal = new System.Windows.Forms.Label();
            this.lblResumenC = new System.Windows.Forms.Label();
            this.lblResumenD = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaLbl = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblVendedorLbl = new System.Windows.Forms.Label();
            this.lblVendedorVal = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.grpBusqCli.SuspendLayout();
            this.grpDatosCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            this.tabProductos.SuspendLayout();
            this.grpBusqProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.tabPago.SuspendLayout();
            this.grpTarjeta.SuspendLayout();
            this.grpTransf.SuspendLayout();
            this.grpSINPE.SuspendLayout();
            this.tabFirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirma)).BeginInit();
            this.tabResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabCliente);
            this.tabMain.Controls.Add(this.tabProductos);
            this.tabMain.Controls.Add(this.tabPago);
            this.tabMain.Controls.Add(this.tabFirma);
            this.tabMain.Controls.Add(this.tabResumen);
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabMain.Location = new System.Drawing.Point(0, 55);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1100, 631);
            this.tabMain.TabIndex = 1;
            // 
            // tabCliente
            // 
            this.tabCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCliente.Controls.Add(this.grpBusqCli);
            this.tabCliente.Controls.Add(this.grpDatosCli);
            this.tabCliente.Location = new System.Drawing.Point(4, 30);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Size = new System.Drawing.Size(1092, 597);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "  1. Cliente  ";
            // 
            // grpBusqCli
            // 
            this.grpBusqCli.Controls.Add(this.lblBusqCli);
            this.grpBusqCli.Controls.Add(this.txtBusqCli);
            this.grpBusqCli.Controls.Add(this.btnBusqCli);
            this.grpBusqCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBusqCli.Location = new System.Drawing.Point(10, 10);
            this.grpBusqCli.Name = "grpBusqCli";
            this.grpBusqCli.Size = new System.Drawing.Size(1070, 65);
            this.grpBusqCli.TabIndex = 0;
            this.grpBusqCli.TabStop = false;
            this.grpBusqCli.Text = "Buscar Cliente";
            // 
            // lblBusqCli
            // 
            this.lblBusqCli.AutoSize = true;
            this.lblBusqCli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBusqCli.Location = new System.Drawing.Point(10, 28);
            this.lblBusqCli.Name = "lblBusqCli";
            this.lblBusqCli.Size = new System.Drawing.Size(127, 20);
            this.lblBusqCli.TabIndex = 0;
            this.lblBusqCli.Text = "Cédula / Nombre:";
            // 
            // txtBusqCli
            // 
            this.txtBusqCli.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBusqCli.Location = new System.Drawing.Point(140, 24);
            this.txtBusqCli.Name = "txtBusqCli";
            this.txtBusqCli.Size = new System.Drawing.Size(500, 29);
            this.txtBusqCli.TabIndex = 1;
            // 
            // btnBusqCli
            // 
            this.btnBusqCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnBusqCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBusqCli.ForeColor = System.Drawing.Color.White;
            this.btnBusqCli.Location = new System.Drawing.Point(655, 22);
            this.btnBusqCli.Name = "btnBusqCli";
            this.btnBusqCli.Size = new System.Drawing.Size(100, 28);
            this.btnBusqCli.TabIndex = 2;
            this.btnBusqCli.Text = "Buscar";
            this.btnBusqCli.UseVisualStyleBackColor = false;
            // 
            // grpDatosCli
            // 
            this.grpDatosCli.Controls.Add(this.picCliente);
            this.grpDatosCli.Controls.Add(this.lblNombreCli);
            this.grpDatosCli.Controls.Add(this.lblCedulaCli);
            this.grpDatosCli.Controls.Add(this.lblCorreoCli);
            this.grpDatosCli.Controls.Add(this.lblTelCli);
            this.grpDatosCli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDatosCli.Location = new System.Drawing.Point(10, 85);
            this.grpDatosCli.Name = "grpDatosCli";
            this.grpDatosCli.Size = new System.Drawing.Size(1070, 140);
            this.grpDatosCli.TabIndex = 1;
            this.grpDatosCli.TabStop = false;
            this.grpDatosCli.Text = "Datos del Cliente Seleccionado";
            // 
            // picCliente
            // 
            this.picCliente.BackColor = System.Drawing.Color.LightGray;
            this.picCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCliente.Location = new System.Drawing.Point(10, 22);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(80, 105);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCliente.TabIndex = 0;
            this.picCliente.TabStop = false;
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombreCli.Location = new System.Drawing.Point(105, 28);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(91, 21);
            this.lblNombreCli.TabIndex = 1;
            this.lblNombreCli.Text = "Nombre: —";
            // 
            // lblCedulaCli
            // 
            this.lblCedulaCli.AutoSize = true;
            this.lblCedulaCli.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCedulaCli.Location = new System.Drawing.Point(105, 55);
            this.lblCedulaCli.Name = "lblCedulaCli";
            this.lblCedulaCli.Size = new System.Drawing.Size(81, 21);
            this.lblCedulaCli.TabIndex = 2;
            this.lblCedulaCli.Text = "Cédula: —";
            // 
            // lblCorreoCli
            // 
            this.lblCorreoCli.AutoSize = true;
            this.lblCorreoCli.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCorreoCli.Location = new System.Drawing.Point(105, 82);
            this.lblCorreoCli.Name = "lblCorreoCli";
            this.lblCorreoCli.Size = new System.Drawing.Size(81, 21);
            this.lblCorreoCli.TabIndex = 3;
            this.lblCorreoCli.Text = "Correo: —";
            // 
            // lblTelCli
            // 
            this.lblTelCli.AutoSize = true;
            this.lblTelCli.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTelCli.Location = new System.Drawing.Point(105, 109);
            this.lblTelCli.Name = "lblTelCli";
            this.lblTelCli.Size = new System.Drawing.Size(51, 21);
            this.lblTelCli.TabIndex = 4;
            this.lblTelCli.Text = "Tel: —";
            // 
            // tabProductos
            // 
            this.tabProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabProductos.Controls.Add(this.grpBusqProd);
            this.tabProductos.Controls.Add(this.dgvDetalle);
            this.tabProductos.Controls.Add(this.btnQuitarLinea);
            this.tabProductos.Controls.Add(this.lblSubtotalLbl);
            this.tabProductos.Controls.Add(this.lblSubtotalVal);
            this.tabProductos.Controls.Add(this.lblIVALbl);
            this.tabProductos.Controls.Add(this.lblIVAVal);
            this.tabProductos.Controls.Add(this.lblTotalCLbl);
            this.tabProductos.Controls.Add(this.lblTotalCVal);
            this.tabProductos.Controls.Add(this.lblTotalDLbl);
            this.tabProductos.Controls.Add(this.lblTotalDVal);
            this.tabProductos.Location = new System.Drawing.Point(4, 30);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(1092, 597);
            this.tabProductos.TabIndex = 1;
            this.tabProductos.Text = "  2. Productos  ";
            // 
            // grpBusqProd
            // 
            this.grpBusqProd.Controls.Add(this.lblBusqProd);
            this.grpBusqProd.Controls.Add(this.txtBusqProd);
            this.grpBusqProd.Controls.Add(this.btnBusqProd);
            this.grpBusqProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBusqProd.Location = new System.Drawing.Point(10, 10);
            this.grpBusqProd.Name = "grpBusqProd";
            this.grpBusqProd.Size = new System.Drawing.Size(1070, 65);
            this.grpBusqProd.TabIndex = 0;
            this.grpBusqProd.TabStop = false;
            this.grpBusqProd.Text = "Buscar Producto (solo con stock disponible)";
            // 
            // lblBusqProd
            // 
            this.lblBusqProd.AutoSize = true;
            this.lblBusqProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBusqProd.Location = new System.Drawing.Point(10, 28);
            this.lblBusqProd.Name = "lblBusqProd";
            this.lblBusqProd.Size = new System.Drawing.Size(182, 20);
            this.lblBusqProd.TabIndex = 0;
            this.lblBusqProd.Text = "Código / Marca / Modelo:";
            // 
            // txtBusqProd
            // 
            this.txtBusqProd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBusqProd.Location = new System.Drawing.Point(165, 24);
            this.txtBusqProd.Name = "txtBusqProd";
            this.txtBusqProd.Size = new System.Drawing.Size(460, 29);
            this.txtBusqProd.TabIndex = 1;
            // 
            // btnBusqProd
            // 
            this.btnBusqProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnBusqProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBusqProd.ForeColor = System.Drawing.Color.White;
            this.btnBusqProd.Location = new System.Drawing.Point(640, 22);
            this.btnBusqProd.Name = "btnBusqProd";
            this.btnBusqProd.Size = new System.Drawing.Size(100, 28);
            this.btnBusqProd.TabIndex = 2;
            this.btnBusqProd.Text = "Buscar";
            this.btnBusqProd.UseVisualStyleBackColor = false;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeight = 30;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDetalle.Location = new System.Drawing.Point(10, 85);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(1070, 400);
            this.dgvDetalle.TabIndex = 1;
            // 
            // btnQuitarLinea
            // 
            this.btnQuitarLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnQuitarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarLinea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuitarLinea.ForeColor = System.Drawing.Color.White;
            this.btnQuitarLinea.Location = new System.Drawing.Point(10, 495);
            this.btnQuitarLinea.Name = "btnQuitarLinea";
            this.btnQuitarLinea.Size = new System.Drawing.Size(200, 28);
            this.btnQuitarLinea.TabIndex = 2;
            this.btnQuitarLinea.Text = "Quitar línea seleccionada";
            this.btnQuitarLinea.UseVisualStyleBackColor = false;
            // 
            // lblSubtotalLbl
            // 
            this.lblSubtotalLbl.AutoSize = true;
            this.lblSubtotalLbl.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalLbl.Location = new System.Drawing.Point(750, 495);
            this.lblSubtotalLbl.Name = "lblSubtotalLbl";
            this.lblSubtotalLbl.Size = new System.Drawing.Size(79, 21);
            this.lblSubtotalLbl.TabIndex = 3;
            this.lblSubtotalLbl.Text = "Subtotal:";
            // 
            // lblSubtotalVal
            // 
            this.lblSubtotalVal.AutoSize = true;
            this.lblSubtotalVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtotalVal.Location = new System.Drawing.Point(880, 495);
            this.lblSubtotalVal.Name = "lblSubtotalVal";
            this.lblSubtotalVal.Size = new System.Drawing.Size(53, 21);
            this.lblSubtotalVal.TabIndex = 4;
            this.lblSubtotalVal.Text = "₡ 0.00";
            // 
            // lblIVALbl
            // 
            this.lblIVALbl.AutoSize = true;
            this.lblIVALbl.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblIVALbl.Location = new System.Drawing.Point(750, 520);
            this.lblIVALbl.Name = "lblIVALbl";
            this.lblIVALbl.Size = new System.Drawing.Size(88, 21);
            this.lblIVALbl.TabIndex = 5;
            this.lblIVALbl.Text = "IVA (13%):";
            // 
            // lblIVAVal
            // 
            this.lblIVAVal.AutoSize = true;
            this.lblIVAVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIVAVal.Location = new System.Drawing.Point(880, 520);
            this.lblIVAVal.Name = "lblIVAVal";
            this.lblIVAVal.Size = new System.Drawing.Size(53, 21);
            this.lblIVAVal.TabIndex = 6;
            this.lblIVAVal.Text = "₡ 0.00";
            // 
            // lblTotalCLbl
            // 
            this.lblTotalCLbl.AutoSize = true;
            this.lblTotalCLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalCLbl.Location = new System.Drawing.Point(750, 548);
            this.lblTotalCLbl.Name = "lblTotalCLbl";
            this.lblTotalCLbl.Size = new System.Drawing.Size(75, 25);
            this.lblTotalCLbl.TabIndex = 7;
            this.lblTotalCLbl.Text = "Total ₡:";
            // 
            // lblTotalCVal
            // 
            this.lblTotalCVal.AutoSize = true;
            this.lblTotalCVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalCVal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalCVal.Location = new System.Drawing.Point(880, 548);
            this.lblTotalCVal.Name = "lblTotalCVal";
            this.lblTotalCVal.Size = new System.Drawing.Size(65, 25);
            this.lblTotalCVal.TabIndex = 8;
            this.lblTotalCVal.Text = "₡ 0.00";
            // 
            // lblTotalDLbl
            // 
            this.lblTotalDLbl.AutoSize = true;
            this.lblTotalDLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalDLbl.Location = new System.Drawing.Point(750, 575);
            this.lblTotalDLbl.Name = "lblTotalDLbl";
            this.lblTotalDLbl.Size = new System.Drawing.Size(76, 25);
            this.lblTotalDLbl.TabIndex = 9;
            this.lblTotalDLbl.Text = "Total $:";
            // 
            // lblTotalDVal
            // 
            this.lblTotalDVal.AutoSize = true;
            this.lblTotalDVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalDVal.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalDVal.Location = new System.Drawing.Point(880, 575);
            this.lblTotalDVal.Name = "lblTotalDVal";
            this.lblTotalDVal.Size = new System.Drawing.Size(66, 25);
            this.lblTotalDVal.TabIndex = 10;
            this.lblTotalDVal.Text = "$ 0.00";
            // 
            // tabPago
            // 
            this.tabPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPago.Controls.Add(this.lblTipoPago);
            this.tabPago.Controls.Add(this.cboTipoPago);
            this.tabPago.Controls.Add(this.grpTarjeta);
            this.tabPago.Controls.Add(this.grpTransf);
            this.tabPago.Controls.Add(this.grpSINPE);
            this.tabPago.Location = new System.Drawing.Point(4, 30);
            this.tabPago.Name = "tabPago";
            this.tabPago.Size = new System.Drawing.Size(1092, 597);
            this.tabPago.TabIndex = 2;
            this.tabPago.Text = "  3. Pago  ";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTipoPago.Location = new System.Drawing.Point(10, 25);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(114, 21);
            this.lblTipoPago.TabIndex = 0;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTipoPago.Items.AddRange(new object[] {
            "Tarjeta de Crédito",
            "Transferencia",
            "SINPE Móvil"});
            this.cboTipoPago.Location = new System.Drawing.Point(115, 21);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(250, 31);
            this.cboTipoPago.TabIndex = 1;
            // 
            // grpTarjeta
            // 
            this.grpTarjeta.Controls.Add(this.lblNumTarjeta);
            this.grpTarjeta.Controls.Add(this.txtNumTarjeta);
            this.grpTarjeta.Controls.Add(this.lblBancoTarjeta);
            this.grpTarjeta.Controls.Add(this.cboBanco);
            this.grpTarjeta.Controls.Add(this.lblTipoTarjeta);
            this.grpTarjeta.Controls.Add(this.cboTipoTarjeta);
            this.grpTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTarjeta.Location = new System.Drawing.Point(10, 60);
            this.grpTarjeta.Name = "grpTarjeta";
            this.grpTarjeta.Size = new System.Drawing.Size(800, 120);
            this.grpTarjeta.TabIndex = 2;
            this.grpTarjeta.TabStop = false;
            this.grpTarjeta.Text = "Datos de Tarjeta de Crédito";
            // 
            // lblNumTarjeta
            // 
            this.lblNumTarjeta.AutoSize = true;
            this.lblNumTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumTarjeta.Location = new System.Drawing.Point(10, 30);
            this.lblNumTarjeta.Name = "lblNumTarjeta";
            this.lblNumTarjeta.Size = new System.Drawing.Size(77, 20);
            this.lblNumTarjeta.TabIndex = 0;
            this.lblNumTarjeta.Text = "N° Tarjeta:";
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNumTarjeta.Location = new System.Drawing.Point(110, 27);
            this.txtNumTarjeta.MaxLength = 20;
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(200, 29);
            this.txtNumTarjeta.TabIndex = 1;
            // 
            // lblBancoTarjeta
            // 
            this.lblBancoTarjeta.AutoSize = true;
            this.lblBancoTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBancoTarjeta.Location = new System.Drawing.Point(10, 68);
            this.lblBancoTarjeta.Name = "lblBancoTarjeta";
            this.lblBancoTarjeta.Size = new System.Drawing.Size(102, 20);
            this.lblBancoTarjeta.TabIndex = 2;
            this.lblBancoTarjeta.Text = "Banco emisor:";
            // 
            // cboBanco
            // 
            this.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanco.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboBanco.Location = new System.Drawing.Point(110, 65);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(230, 29);
            this.cboBanco.TabIndex = 3;
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoTarjeta.Location = new System.Drawing.Point(380, 30);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(89, 20);
            this.lblTipoTarjeta.TabIndex = 4;
            this.lblTipoTarjeta.Text = "Tipo tarjeta:";
            // 
            // cboTipoTarjeta
            // 
            this.cboTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTarjeta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTipoTarjeta.Items.AddRange(new object[] {
            "VISA",
            "MASTERCARD",
            "AMERICAN EXPRESS",
            "DISCOVER"});
            this.cboTipoTarjeta.Location = new System.Drawing.Point(475, 27);
            this.cboTipoTarjeta.Name = "cboTipoTarjeta";
            this.cboTipoTarjeta.Size = new System.Drawing.Size(200, 29);
            this.cboTipoTarjeta.TabIndex = 5;
            // 
            // grpTransf
            // 
            this.grpTransf.Controls.Add(this.lblBancoTransf);
            this.grpTransf.Controls.Add(this.cboBancoTransf);
            this.grpTransf.Controls.Add(this.lblNumTransf);
            this.grpTransf.Controls.Add(this.txtNumTransf);
            this.grpTransf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTransf.Location = new System.Drawing.Point(10, 60);
            this.grpTransf.Name = "grpTransf";
            this.grpTransf.Size = new System.Drawing.Size(800, 110);
            this.grpTransf.TabIndex = 3;
            this.grpTransf.TabStop = false;
            this.grpTransf.Text = "Datos de Transferencia Bancaria";
            this.grpTransf.Visible = false;
            // 
            // lblBancoTransf
            // 
            this.lblBancoTransf.AutoSize = true;
            this.lblBancoTransf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBancoTransf.Location = new System.Drawing.Point(10, 30);
            this.lblBancoTransf.Name = "lblBancoTransf";
            this.lblBancoTransf.Size = new System.Drawing.Size(53, 20);
            this.lblBancoTransf.TabIndex = 0;
            this.lblBancoTransf.Text = "Banco:";
            // 
            // cboBancoTransf
            // 
            this.cboBancoTransf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBancoTransf.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboBancoTransf.Location = new System.Drawing.Point(65, 27);
            this.cboBancoTransf.Name = "cboBancoTransf";
            this.cboBancoTransf.Size = new System.Drawing.Size(250, 29);
            this.cboBancoTransf.TabIndex = 1;
            // 
            // lblNumTransf
            // 
            this.lblNumTransf.AutoSize = true;
            this.lblNumTransf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumTransf.Location = new System.Drawing.Point(10, 68);
            this.lblNumTransf.Name = "lblNumTransf";
            this.lblNumTransf.Size = new System.Drawing.Size(120, 20);
            this.lblNumTransf.TabIndex = 2;
            this.lblNumTransf.Text = "N° Transferencia:";
            // 
            // txtNumTransf
            // 
            this.txtNumTransf.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNumTransf.Location = new System.Drawing.Point(130, 65);
            this.txtNumTransf.MaxLength = 50;
            this.txtNumTransf.Name = "txtNumTransf";
            this.txtNumTransf.Size = new System.Drawing.Size(380, 29);
            this.txtNumTransf.TabIndex = 3;
            // 
            // grpSINPE
            // 
            this.grpSINPE.Controls.Add(this.lblNumSINPE);
            this.grpSINPE.Controls.Add(this.txtNumSINPE);
            this.grpSINPE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpSINPE.Location = new System.Drawing.Point(10, 60);
            this.grpSINPE.Name = "grpSINPE";
            this.grpSINPE.Size = new System.Drawing.Size(550, 85);
            this.grpSINPE.TabIndex = 4;
            this.grpSINPE.TabStop = false;
            this.grpSINPE.Text = "SINPE Móvil";
            this.grpSINPE.Visible = false;
            // 
            // lblNumSINPE
            // 
            this.lblNumSINPE.AutoSize = true;
            this.lblNumSINPE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumSINPE.Location = new System.Drawing.Point(10, 32);
            this.lblNumSINPE.Name = "lblNumSINPE";
            this.lblNumSINPE.Size = new System.Drawing.Size(134, 20);
            this.lblNumSINPE.TabIndex = 0;
            this.lblNumSINPE.Text = "N° Teléfono SINPE:";
            // 
            // txtNumSINPE
            // 
            this.txtNumSINPE.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNumSINPE.Location = new System.Drawing.Point(145, 29);
            this.txtNumSINPE.MaxLength = 20;
            this.txtNumSINPE.Name = "txtNumSINPE";
            this.txtNumSINPE.Size = new System.Drawing.Size(190, 29);
            this.txtNumSINPE.TabIndex = 1;
            // 
            // tabFirma
            // 
            this.tabFirma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabFirma.Controls.Add(this.lblFirmaInfo);
            this.tabFirma.Controls.Add(this.picFirma);
            this.tabFirma.Controls.Add(this.btnCapturarFirma);
            this.tabFirma.Controls.Add(this.lblFirmaEstado);
            this.tabFirma.Location = new System.Drawing.Point(4, 30);
            this.tabFirma.Name = "tabFirma";
            this.tabFirma.Size = new System.Drawing.Size(1092, 597);
            this.tabFirma.TabIndex = 3;
            this.tabFirma.Text = "  4. Firma  ";
            // 
            // lblFirmaInfo
            // 
            this.lblFirmaInfo.AutoSize = true;
            this.lblFirmaInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblFirmaInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblFirmaInfo.Location = new System.Drawing.Point(10, 12);
            this.lblFirmaInfo.Name = "lblFirmaInfo";
            this.lblFirmaInfo.Size = new System.Drawing.Size(398, 20);
            this.lblFirmaInfo.TabIndex = 0;
            this.lblFirmaInfo.Text = "El cliente debe firmar. La firma se guarda en la base de datos.";
            // 
            // picFirma
            // 
            this.picFirma.BackColor = System.Drawing.Color.LightGray;
            this.picFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFirma.Location = new System.Drawing.Point(10, 35);
            this.picFirma.Name = "picFirma";
            this.picFirma.Size = new System.Drawing.Size(820, 220);
            this.picFirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFirma.TabIndex = 1;
            this.picFirma.TabStop = false;
            // 
            // btnCapturarFirma
            // 
            this.btnCapturarFirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCapturarFirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturarFirma.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCapturarFirma.ForeColor = System.Drawing.Color.White;
            this.btnCapturarFirma.Location = new System.Drawing.Point(10, 265);
            this.btnCapturarFirma.Name = "btnCapturarFirma";
            this.btnCapturarFirma.Size = new System.Drawing.Size(230, 40);
            this.btnCapturarFirma.TabIndex = 2;
            this.btnCapturarFirma.Text = "Capturar Firma del Cliente";
            this.btnCapturarFirma.UseVisualStyleBackColor = false;
            // 
            // lblFirmaEstado
            // 
            this.lblFirmaEstado.AutoSize = true;
            this.lblFirmaEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblFirmaEstado.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblFirmaEstado.Location = new System.Drawing.Point(255, 278);
            this.lblFirmaEstado.Name = "lblFirmaEstado";
            this.lblFirmaEstado.Size = new System.Drawing.Size(152, 21);
            this.lblFirmaEstado.TabIndex = 3;
            this.lblFirmaEstado.Text = "Sin firma capturada.";
            // 
            // tabResumen
            // 
            this.tabResumen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabResumen.Controls.Add(this.picQR);
            this.tabResumen.Controls.Add(this.lblNumQR);
            this.tabResumen.Controls.Add(this.lblTipoCambioLbl);
            this.tabResumen.Controls.Add(this.lblTipoCambioVal);
            this.tabResumen.Controls.Add(this.lblResumenC);
            this.tabResumen.Controls.Add(this.lblResumenD);
            this.tabResumen.Location = new System.Drawing.Point(4, 30);
            this.tabResumen.Name = "tabResumen";
            this.tabResumen.Size = new System.Drawing.Size(1092, 597);
            this.tabResumen.TabIndex = 4;
            this.tabResumen.Text = "  5. Resumen / QR  ";
            // 
            // picQR
            // 
            this.picQR.BackColor = System.Drawing.Color.White;
            this.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQR.Location = new System.Drawing.Point(80, 20);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(200, 200);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 0;
            this.picQR.TabStop = false;
            // 
            // lblNumQR
            // 
            this.lblNumQR.AutoSize = true;
            this.lblNumQR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumQR.Location = new System.Drawing.Point(60, 228);
            this.lblNumQR.Name = "lblNumQR";
            this.lblNumQR.Size = new System.Drawing.Size(27, 23);
            this.lblNumQR.TabIndex = 1;
            this.lblNumQR.Text = "—";
            // 
            // lblTipoCambioLbl
            // 
            this.lblTipoCambioLbl.AutoSize = true;
            this.lblTipoCambioLbl.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTipoCambioLbl.Location = new System.Drawing.Point(380, 20);
            this.lblTipoCambioLbl.Name = "lblTipoCambioLbl";
            this.lblTipoCambioLbl.Size = new System.Drawing.Size(145, 21);
            this.lblTipoCambioLbl.TabIndex = 2;
            this.lblTipoCambioLbl.Text = "Tipo de cambio $:";
            // 
            // lblTipoCambioVal
            // 
            this.lblTipoCambioVal.AutoSize = true;
            this.lblTipoCambioVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTipoCambioVal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTipoCambioVal.Location = new System.Drawing.Point(531, 20);
            this.lblTipoCambioVal.Name = "lblTipoCambioVal";
            this.lblTipoCambioVal.Size = new System.Drawing.Size(58, 21);
            this.lblTipoCambioVal.TabIndex = 3;
            this.lblTipoCambioVal.Text = "₡ 0.00 ";
            // 
            // lblResumenC
            // 
            this.lblResumenC.AutoSize = true;
            this.lblResumenC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblResumenC.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResumenC.Location = new System.Drawing.Point(380, 80);
            this.lblResumenC.Name = "lblResumenC";
            this.lblResumenC.Size = new System.Drawing.Size(128, 32);
            this.lblResumenC.TabIndex = 4;
            this.lblResumenC.Text = "Total ₡: —";
            // 
            // lblResumenD
            // 
            this.lblResumenD.AutoSize = true;
            this.lblResumenD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblResumenD.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblResumenD.Location = new System.Drawing.Point(380, 120);
            this.lblResumenD.Name = "lblResumenD";
            this.lblResumenD.Size = new System.Drawing.Size(129, 32);
            this.lblResumenD.TabIndex = 5;
            this.lblResumenD.Text = "Total $: —";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Controls.Add(this.lblFechaLbl);
            this.pnlTop.Controls.Add(this.dtpFecha);
            this.pnlTop.Controls.Add(this.lblVendedorLbl);
            this.pnlTop.Controls.Add(this.lblVendedorVal);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 55);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(266, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Facturación — JarasTech";
            // 
            // lblFechaLbl
            // 
            this.lblFechaLbl.AutoSize = true;
            this.lblFechaLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaLbl.ForeColor = System.Drawing.Color.White;
            this.lblFechaLbl.Location = new System.Drawing.Point(520, 17);
            this.lblFechaLbl.Name = "lblFechaLbl";
            this.lblFechaLbl.Size = new System.Drawing.Size(53, 20);
            this.lblFechaLbl.TabIndex = 1;
            this.lblFechaLbl.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(570, 14);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(110, 27);
            this.dtpFecha.TabIndex = 2;
            // 
            // lblVendedorLbl
            // 
            this.lblVendedorLbl.AutoSize = true;
            this.lblVendedorLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendedorLbl.ForeColor = System.Drawing.Color.White;
            this.lblVendedorLbl.Location = new System.Drawing.Point(700, 17);
            this.lblVendedorLbl.Name = "lblVendedorLbl";
            this.lblVendedorLbl.Size = new System.Drawing.Size(81, 20);
            this.lblVendedorLbl.TabIndex = 3;
            this.lblVendedorLbl.Text = "Vendedor:";
            // 
            // lblVendedorVal
            // 
            this.lblVendedorVal.AutoSize = true;
            this.lblVendedorVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVendedorVal.ForeColor = System.Drawing.Color.White;
            this.lblVendedorVal.Location = new System.Drawing.Point(770, 17);
            this.lblVendedorVal.Name = "lblVendedorVal";
            this.lblVendedorVal.Size = new System.Drawing.Size(24, 20);
            this.lblVendedorVal.TabIndex = 4;
            this.lblVendedorVal.Text = "—";
            // 
            // btnNueva
            // 
            this.btnNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNueva.ForeColor = System.Drawing.Color.White;
            this.btnNueva.Location = new System.Drawing.Point(10, 745);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(160, 38);
            this.btnNueva.TabIndex = 2;
            this.btnNueva.Text = "Nueva Factura";
            this.btnNueva.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(185, 745);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 38);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar y Emitir Factura";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 701);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hacerlo interactivo para los errores con el error provider";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(400, 745);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 38);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = " ❌ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 795);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JarasTech - Facturación";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.tabMain.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.grpBusqCli.ResumeLayout(false);
            this.grpBusqCli.PerformLayout();
            this.grpDatosCli.ResumeLayout(false);
            this.grpDatosCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            this.tabProductos.ResumeLayout(false);
            this.tabProductos.PerformLayout();
            this.grpBusqProd.ResumeLayout(false);
            this.grpBusqProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.tabPago.ResumeLayout(false);
            this.tabPago.PerformLayout();
            this.grpTarjeta.ResumeLayout(false);
            this.grpTarjeta.PerformLayout();
            this.grpTransf.ResumeLayout(false);
            this.grpTransf.PerformLayout();
            this.grpSINPE.ResumeLayout(false);
            this.grpSINPE.PerformLayout();
            this.tabFirma.ResumeLayout(false);
            this.tabFirma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirma)).EndInit();
            this.tabResumen.ResumeLayout(false);
            this.tabResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaLbl;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblVendedorLbl;
        private System.Windows.Forms.Label lblVendedorVal;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.GroupBox grpBusqCli;
        private System.Windows.Forms.Label lblBusqCli;
        private System.Windows.Forms.TextBox txtBusqCli;
        private System.Windows.Forms.Button btnBusqCli;
        private System.Windows.Forms.GroupBox grpDatosCli;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.Label lblCedulaCli;
        private System.Windows.Forms.Label lblCorreoCli;
        private System.Windows.Forms.Label lblTelCli;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.GroupBox grpBusqProd;
        private System.Windows.Forms.Label lblBusqProd;
        private System.Windows.Forms.TextBox txtBusqProd;
        private System.Windows.Forms.Button btnBusqProd;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnQuitarLinea;
        private System.Windows.Forms.Label lblSubtotalLbl;
        private System.Windows.Forms.Label lblSubtotalVal;
        private System.Windows.Forms.Label lblIVALbl;
        private System.Windows.Forms.Label lblIVAVal;
        private System.Windows.Forms.Label lblTotalCLbl;
        private System.Windows.Forms.Label lblTotalCVal;
        private System.Windows.Forms.Label lblTotalDLbl;
        private System.Windows.Forms.Label lblTotalDVal;
        private System.Windows.Forms.TabPage tabPago;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.GroupBox grpTarjeta;
        private System.Windows.Forms.Label lblNumTarjeta;
        private System.Windows.Forms.TextBox txtNumTarjeta;
        private System.Windows.Forms.Label lblBancoTarjeta;
        private System.Windows.Forms.ComboBox cboBanco;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.ComboBox cboTipoTarjeta;
        private System.Windows.Forms.GroupBox grpTransf;
        private System.Windows.Forms.Label lblBancoTransf;
        private System.Windows.Forms.ComboBox cboBancoTransf;
        private System.Windows.Forms.Label lblNumTransf;
        private System.Windows.Forms.TextBox txtNumTransf;
        private System.Windows.Forms.GroupBox grpSINPE;
        private System.Windows.Forms.Label lblNumSINPE;
        private System.Windows.Forms.TextBox txtNumSINPE;
        private System.Windows.Forms.TabPage tabFirma;
        private System.Windows.Forms.Label lblFirmaInfo;
        private System.Windows.Forms.PictureBox picFirma;
        private System.Windows.Forms.Button btnCapturarFirma;
        private System.Windows.Forms.Label lblFirmaEstado;
        private System.Windows.Forms.TabPage tabResumen;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Label lblNumQR;
        private System.Windows.Forms.Label lblTipoCambioLbl;
        private System.Windows.Forms.Label lblTipoCambioVal;
        private System.Windows.Forms.Label lblResumenC;
        private System.Windows.Forms.Label lblResumenD;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}