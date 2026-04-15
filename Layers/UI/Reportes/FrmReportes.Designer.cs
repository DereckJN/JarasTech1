namespace JarasTech.Layers.UI.Reportes
{
    partial class FrmReportes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabReportes = new System.Windows.Forms.TabControl();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.grpFiltrosA = new System.Windows.Forms.GroupBox();
            this.lblMarcaA = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblModeloA = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.lblTipoA = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnReporteProductos = new System.Windows.Forms.Button();
            this.lblInfoA = new System.Windows.Forms.Label();
            this.tabFacturas = new System.Windows.Forms.TabPage();
            this.grpFiltrosB = new System.Windows.Forms.GroupBox();
            this.lblDesdeB = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHastaB = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnReporteFacturas = new System.Windows.Forms.Button();
            this.lblInfoB = new System.Windows.Forms.Label();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.grpFiltrosC = new System.Windows.Forms.GroupBox();
            this.lblFiltroC = new System.Windows.Forms.Label();
            this.txtFiltroCliente = new System.Windows.Forms.TextBox();
            this.btnReporteClientes = new System.Windows.Forms.Button();
            this.lblInfoC = new System.Windows.Forms.Label();
            this.tabGrafico = new System.Windows.Forms.TabPage();
            this.grpFiltrosD = new System.Windows.Forms.GroupBox();
            this.lblDesdeD = new System.Windows.Forms.Label();
            this.dtpDesde3 = new System.Windows.Forms.DateTimePicker();
            this.lblHastaD = new System.Windows.Forms.Label();
            this.dtpHasta3 = new System.Windows.Forms.DateTimePicker();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.picGrafico = new System.Windows.Forms.PictureBox();
            this.pnlGraficoTotales = new System.Windows.Forms.Panel();
            this.lblGraficoTotal = new System.Windows.Forms.Label();
            this.lblGraficoFacturas = new System.Windows.Forms.Label();
            this.lblGraficoPromedio = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.grpFiltrosA.SuspendLayout();
            this.tabFacturas.SuspendLayout();
            this.grpFiltrosB.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.grpFiltrosC.SuspendLayout();
            this.tabGrafico.SuspendLayout();
            this.grpFiltrosD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafico)).BeginInit();
            this.pnlGraficoTotales.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 52);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reportes — JarasTech";
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.tabProductos);
            this.tabReportes.Controls.Add(this.tabFacturas);
            this.tabReportes.Controls.Add(this.tabClientes);
            this.tabReportes.Controls.Add(this.tabGrafico);
            this.tabReportes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabReportes.Location = new System.Drawing.Point(0, 52);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.SelectedIndex = 0;
            this.tabReportes.Size = new System.Drawing.Size(1100, 688);
            this.tabReportes.TabIndex = 1;
            // 
            // tabProductos
            // 
            this.tabProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabProductos.Controls.Add(this.grpFiltrosA);
            this.tabProductos.Controls.Add(this.lblInfoA);
            this.tabProductos.Location = new System.Drawing.Point(4, 30);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(1092, 654);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.Text = "  A. Productos  ";
            // 
            // grpFiltrosA
            // 
            this.grpFiltrosA.Controls.Add(this.lblMarcaA);
            this.grpFiltrosA.Controls.Add(this.cboMarca);
            this.grpFiltrosA.Controls.Add(this.lblModeloA);
            this.grpFiltrosA.Controls.Add(this.cboModelo);
            this.grpFiltrosA.Controls.Add(this.lblTipoA);
            this.grpFiltrosA.Controls.Add(this.cboTipo);
            this.grpFiltrosA.Controls.Add(this.btnReporteProductos);
            this.grpFiltrosA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFiltrosA.Location = new System.Drawing.Point(12, 12);
            this.grpFiltrosA.Name = "grpFiltrosA";
            this.grpFiltrosA.Size = new System.Drawing.Size(1060, 75);
            this.grpFiltrosA.TabIndex = 0;
            this.grpFiltrosA.TabStop = false;
            this.grpFiltrosA.Text = "Filtros (mínimo uno — deje en blanco para mostrar todos)";
            // 
            // lblMarcaA
            // 
            this.lblMarcaA.AutoSize = true;
            this.lblMarcaA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMarcaA.Location = new System.Drawing.Point(10, 30);
            this.lblMarcaA.Name = "lblMarcaA";
            this.lblMarcaA.Size = new System.Drawing.Size(53, 20);
            this.lblMarcaA.TabIndex = 0;
            this.lblMarcaA.Text = "Marca:";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboMarca.Location = new System.Drawing.Point(62, 26);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(195, 29);
            this.cboMarca.TabIndex = 1;
            // 
            // lblModeloA
            // 
            this.lblModeloA.AutoSize = true;
            this.lblModeloA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblModeloA.Location = new System.Drawing.Point(270, 30);
            this.lblModeloA.Name = "lblModeloA";
            this.lblModeloA.Size = new System.Drawing.Size(64, 20);
            this.lblModeloA.TabIndex = 2;
            this.lblModeloA.Text = "Modelo:";
            // 
            // cboModelo
            // 
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboModelo.Location = new System.Drawing.Point(328, 26);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(195, 29);
            this.cboModelo.TabIndex = 3;
            // 
            // lblTipoA
            // 
            this.lblTipoA.AutoSize = true;
            this.lblTipoA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoA.Location = new System.Drawing.Point(538, 30);
            this.lblTipoA.Name = "lblTipoA";
            this.lblTipoA.Size = new System.Drawing.Size(120, 20);
            this.lblTipoA.TabIndex = 4;
            this.lblTipoA.Text = "Tipo Dispositivo:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTipo.Location = new System.Drawing.Point(647, 26);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(195, 29);
            this.cboTipo.TabIndex = 5;
            // 
            // btnReporteProductos
            // 
            this.btnReporteProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnReporteProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteProductos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReporteProductos.ForeColor = System.Drawing.Color.White;
            this.btnReporteProductos.Location = new System.Drawing.Point(888, 22);
            this.btnReporteProductos.Name = "btnReporteProductos";
            this.btnReporteProductos.Size = new System.Drawing.Size(160, 36);
            this.btnReporteProductos.TabIndex = 6;
            this.btnReporteProductos.Text = "Generar PDF  →";
            this.btnReporteProductos.UseVisualStyleBackColor = false;
            this.btnReporteProductos.Click += new System.EventHandler(this.btnReporteProductos_Click);
            // 
            // lblInfoA
            // 
            this.lblInfoA.AutoSize = true;
            this.lblInfoA.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblInfoA.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfoA.Location = new System.Drawing.Point(12, 96);
            this.lblInfoA.Name = "lblInfoA";
            this.lblInfoA.Size = new System.Drawing.Size(519, 20);
            this.lblInfoA.TabIndex = 1;
            this.lblInfoA.Text = "El PDF incluye la fotografía de cada producto, precio ₡/$, stock y característica" +
    "s.";
            // 
            // tabFacturas
            // 
            this.tabFacturas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabFacturas.Controls.Add(this.grpFiltrosB);
            this.tabFacturas.Controls.Add(this.lblInfoB);
            this.tabFacturas.Location = new System.Drawing.Point(4, 30);
            this.tabFacturas.Name = "tabFacturas";
            this.tabFacturas.Size = new System.Drawing.Size(1092, 654);
            this.tabFacturas.TabIndex = 1;
            this.tabFacturas.Text = "  B. Facturas  ";
            // 
            // grpFiltrosB
            // 
            this.grpFiltrosB.Controls.Add(this.lblDesdeB);
            this.grpFiltrosB.Controls.Add(this.dtpDesde);
            this.grpFiltrosB.Controls.Add(this.lblHastaB);
            this.grpFiltrosB.Controls.Add(this.dtpHasta);
            this.grpFiltrosB.Controls.Add(this.btnReporteFacturas);
            this.grpFiltrosB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFiltrosB.Location = new System.Drawing.Point(12, 12);
            this.grpFiltrosB.Name = "grpFiltrosB";
            this.grpFiltrosB.Size = new System.Drawing.Size(1060, 70);
            this.grpFiltrosB.TabIndex = 0;
            this.grpFiltrosB.TabStop = false;
            this.grpFiltrosB.Text = "Rango de Fechas";
            // 
            // lblDesdeB
            // 
            this.lblDesdeB.AutoSize = true;
            this.lblDesdeB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesdeB.Location = new System.Drawing.Point(10, 28);
            this.lblDesdeB.Name = "lblDesdeB";
            this.lblDesdeB.Size = new System.Drawing.Size(54, 20);
            this.lblDesdeB.TabIndex = 0;
            this.lblDesdeB.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(56, 24);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(130, 29);
            this.dtpDesde.TabIndex = 1;
            // 
            // lblHastaB
            // 
            this.lblHastaB.AutoSize = true;
            this.lblHastaB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHastaB.Location = new System.Drawing.Point(202, 28);
            this.lblHastaB.Name = "lblHastaB";
            this.lblHastaB.Size = new System.Drawing.Size(50, 20);
            this.lblHastaB.TabIndex = 2;
            this.lblHastaB.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(249, 24);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(130, 29);
            this.dtpHasta.TabIndex = 3;
            // 
            // btnReporteFacturas
            // 
            this.btnReporteFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnReporteFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteFacturas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReporteFacturas.ForeColor = System.Drawing.Color.White;
            this.btnReporteFacturas.Location = new System.Drawing.Point(888, 18);
            this.btnReporteFacturas.Name = "btnReporteFacturas";
            this.btnReporteFacturas.Size = new System.Drawing.Size(160, 36);
            this.btnReporteFacturas.TabIndex = 4;
            this.btnReporteFacturas.Text = "Generar PDF  →";
            this.btnReporteFacturas.UseVisualStyleBackColor = false;
            this.btnReporteFacturas.Click += new System.EventHandler(this.btnReporteFacturas_Click);
            // 
            // lblInfoB
            // 
            this.lblInfoB.AutoSize = true;
            this.lblInfoB.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblInfoB.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfoB.Location = new System.Drawing.Point(12, 90);
            this.lblInfoB.Name = "lblInfoB";
            this.lblInfoB.Size = new System.Drawing.Size(503, 20);
            this.lblInfoB.TabIndex = 1;
            this.lblInfoB.Text = "El PDF muestra todas las facturas del período y totaliza IVA, Total ₡ y Total $.";
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabClientes.Controls.Add(this.grpFiltrosC);
            this.tabClientes.Controls.Add(this.lblInfoC);
            this.tabClientes.Location = new System.Drawing.Point(4, 30);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Size = new System.Drawing.Size(1092, 654);
            this.tabClientes.TabIndex = 2;
            this.tabClientes.Text = "  C. Clientes  ";
            // 
            // grpFiltrosC
            // 
            this.grpFiltrosC.Controls.Add(this.lblFiltroC);
            this.grpFiltrosC.Controls.Add(this.txtFiltroCliente);
            this.grpFiltrosC.Controls.Add(this.btnReporteClientes);
            this.grpFiltrosC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFiltrosC.Location = new System.Drawing.Point(12, 12);
            this.grpFiltrosC.Name = "grpFiltrosC";
            this.grpFiltrosC.Size = new System.Drawing.Size(1060, 70);
            this.grpFiltrosC.TabIndex = 0;
            this.grpFiltrosC.TabStop = false;
            this.grpFiltrosC.Text = "Filtro (opcional — vacío = todos los clientes)";
            // 
            // lblFiltroC
            // 
            this.lblFiltroC.AutoSize = true;
            this.lblFiltroC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroC.Location = new System.Drawing.Point(10, 28);
            this.lblFiltroC.Name = "lblFiltroC";
            this.lblFiltroC.Size = new System.Drawing.Size(127, 20);
            this.lblFiltroC.TabIndex = 0;
            this.lblFiltroC.Text = "Nombre / Cédula:";
            // 
            // txtFiltroCliente
            // 
            this.txtFiltroCliente.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFiltroCliente.Location = new System.Drawing.Point(122, 24);
            this.txtFiltroCliente.Name = "txtFiltroCliente";
            this.txtFiltroCliente.Size = new System.Drawing.Size(300, 29);
            this.txtFiltroCliente.TabIndex = 1;
            // 
            // btnReporteClientes
            // 
            this.btnReporteClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnReporteClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteClientes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReporteClientes.ForeColor = System.Drawing.Color.White;
            this.btnReporteClientes.Location = new System.Drawing.Point(888, 18);
            this.btnReporteClientes.Name = "btnReporteClientes";
            this.btnReporteClientes.Size = new System.Drawing.Size(160, 36);
            this.btnReporteClientes.TabIndex = 2;
            this.btnReporteClientes.Text = "Generar PDF  →";
            this.btnReporteClientes.UseVisualStyleBackColor = false;
            this.btnReporteClientes.Click += new System.EventHandler(this.btnReporteClientes_Click);
            // 
            // lblInfoC
            // 
            this.lblInfoC.AutoSize = true;
            this.lblInfoC.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblInfoC.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfoC.Location = new System.Drawing.Point(12, 90);
            this.lblInfoC.Name = "lblInfoC";
            this.lblInfoC.Size = new System.Drawing.Size(530, 20);
            this.lblInfoC.TabIndex = 1;
            this.lblInfoC.Text = "El PDF incluye la fotografía de cada cliente junto con todos sus datos de contact" +
    "o.";
            // 
            // tabGrafico
            // 
            this.tabGrafico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabGrafico.Controls.Add(this.grpFiltrosD);
            this.tabGrafico.Controls.Add(this.picGrafico);
            this.tabGrafico.Controls.Add(this.pnlGraficoTotales);
            this.tabGrafico.Location = new System.Drawing.Point(4, 30);
            this.tabGrafico.Name = "tabGrafico";
            this.tabGrafico.Size = new System.Drawing.Size(1092, 654);
            this.tabGrafico.TabIndex = 3;
            this.tabGrafico.Text = "  D. Gráfico Ventas  ";
            // 
            // grpFiltrosD
            // 
            this.grpFiltrosD.Controls.Add(this.lblDesdeD);
            this.grpFiltrosD.Controls.Add(this.dtpDesde3);
            this.grpFiltrosD.Controls.Add(this.lblHastaD);
            this.grpFiltrosD.Controls.Add(this.dtpHasta3);
            this.grpFiltrosD.Controls.Add(this.btnGrafico);
            this.grpFiltrosD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFiltrosD.Location = new System.Drawing.Point(12, 12);
            this.grpFiltrosD.Name = "grpFiltrosD";
            this.grpFiltrosD.Size = new System.Drawing.Size(1060, 70);
            this.grpFiltrosD.TabIndex = 0;
            this.grpFiltrosD.TabStop = false;
            this.grpFiltrosD.Text = "Rango de Fechas para el Gráfico";
            // 
            // lblDesdeD
            // 
            this.lblDesdeD.AutoSize = true;
            this.lblDesdeD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesdeD.Location = new System.Drawing.Point(10, 28);
            this.lblDesdeD.Name = "lblDesdeD";
            this.lblDesdeD.Size = new System.Drawing.Size(54, 20);
            this.lblDesdeD.TabIndex = 0;
            this.lblDesdeD.Text = "Desde:";
            // 
            // dtpDesde3
            // 
            this.dtpDesde3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDesde3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde3.Location = new System.Drawing.Point(56, 24);
            this.dtpDesde3.Name = "dtpDesde3";
            this.dtpDesde3.Size = new System.Drawing.Size(130, 29);
            this.dtpDesde3.TabIndex = 1;
            // 
            // lblHastaD
            // 
            this.lblHastaD.AutoSize = true;
            this.lblHastaD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHastaD.Location = new System.Drawing.Point(202, 28);
            this.lblHastaD.Name = "lblHastaD";
            this.lblHastaD.Size = new System.Drawing.Size(50, 20);
            this.lblHastaD.TabIndex = 2;
            this.lblHastaD.Text = "Hasta:";
            // 
            // dtpHasta3
            // 
            this.dtpHasta3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpHasta3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta3.Location = new System.Drawing.Point(249, 24);
            this.dtpHasta3.Name = "dtpHasta3";
            this.dtpHasta3.Size = new System.Drawing.Size(130, 29);
            this.dtpHasta3.TabIndex = 3;
            // 
            // btnGrafico
            // 
            this.btnGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafico.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGrafico.ForeColor = System.Drawing.Color.White;
            this.btnGrafico.Location = new System.Drawing.Point(888, 18);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(160, 36);
            this.btnGrafico.TabIndex = 4;
            this.btnGrafico.Text = "Generar Gráfico";
            this.btnGrafico.UseVisualStyleBackColor = false;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // picGrafico
            // 
            this.picGrafico.BackColor = System.Drawing.Color.White;
            this.picGrafico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGrafico.Location = new System.Drawing.Point(12, 90);
            this.picGrafico.Name = "picGrafico";
            this.picGrafico.Size = new System.Drawing.Size(820, 520);
            this.picGrafico.TabIndex = 1;
            this.picGrafico.TabStop = false;
            // 
            // pnlGraficoTotales
            // 
            this.pnlGraficoTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.pnlGraficoTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraficoTotales.Controls.Add(this.lblGraficoTotal);
            this.pnlGraficoTotales.Controls.Add(this.lblGraficoFacturas);
            this.pnlGraficoTotales.Controls.Add(this.lblGraficoPromedio);
            this.pnlGraficoTotales.Location = new System.Drawing.Point(844, 90);
            this.pnlGraficoTotales.Name = "pnlGraficoTotales";
            this.pnlGraficoTotales.Size = new System.Drawing.Size(235, 160);
            this.pnlGraficoTotales.TabIndex = 2;
            // 
            // lblGraficoTotal
            // 
            this.lblGraficoTotal.AutoSize = true;
            this.lblGraficoTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGraficoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblGraficoTotal.Location = new System.Drawing.Point(10, 18);
            this.lblGraficoTotal.Name = "lblGraficoTotal";
            this.lblGraficoTotal.Size = new System.Drawing.Size(126, 21);
            this.lblGraficoTotal.TabIndex = 0;
            this.lblGraficoTotal.Text = "Total ventas: —";
            // 
            // lblGraficoFacturas
            // 
            this.lblGraficoFacturas.AutoSize = true;
            this.lblGraficoFacturas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGraficoFacturas.Location = new System.Drawing.Point(10, 52);
            this.lblGraficoFacturas.Name = "lblGraficoFacturas";
            this.lblGraficoFacturas.Size = new System.Drawing.Size(105, 20);
            this.lblGraficoFacturas.TabIndex = 1;
            this.lblGraficoFacturas.Text = "N° Facturas: —";
            // 
            // lblGraficoPromedio
            // 
            this.lblGraficoPromedio.AutoSize = true;
            this.lblGraficoPromedio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGraficoPromedio.Location = new System.Drawing.Point(10, 84);
            this.lblGraficoPromedio.Name = "lblGraficoPromedio";
            this.lblGraficoPromedio.Size = new System.Drawing.Size(123, 20);
            this.lblGraficoPromedio.TabIndex = 2;
            this.lblGraficoPromedio.Text = "Promedio/día: —";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCerrar);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 736);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1100, 48);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(960, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(130, 36);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 784);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.tabReportes);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JarasTech — Reportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.tabProductos.PerformLayout();
            this.grpFiltrosA.ResumeLayout(false);
            this.grpFiltrosA.PerformLayout();
            this.tabFacturas.ResumeLayout(false);
            this.tabFacturas.PerformLayout();
            this.grpFiltrosB.ResumeLayout(false);
            this.grpFiltrosB.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            this.grpFiltrosC.ResumeLayout(false);
            this.grpFiltrosC.PerformLayout();
            this.tabGrafico.ResumeLayout(false);
            this.grpFiltrosD.ResumeLayout(false);
            this.grpFiltrosD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafico)).EndInit();
            this.pnlGraficoTotales.ResumeLayout(false);
            this.pnlGraficoTotales.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabReportes;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.GroupBox grpFiltrosA;
        private System.Windows.Forms.Label lblMarcaA;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblModeloA;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label lblTipoA;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnReporteProductos;
        private System.Windows.Forms.Label lblInfoA;
        private System.Windows.Forms.TabPage tabFacturas;
        private System.Windows.Forms.GroupBox grpFiltrosB;
        private System.Windows.Forms.Label lblDesdeB;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHastaB;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnReporteFacturas;
        private System.Windows.Forms.Label lblInfoB;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.GroupBox grpFiltrosC;
        private System.Windows.Forms.Label lblFiltroC;
        private System.Windows.Forms.TextBox txtFiltroCliente;
        private System.Windows.Forms.Button btnReporteClientes;
        private System.Windows.Forms.Label lblInfoC;
        private System.Windows.Forms.TabPage tabGrafico;
        private System.Windows.Forms.GroupBox grpFiltrosD;
        private System.Windows.Forms.Label lblDesdeD;
        private System.Windows.Forms.DateTimePicker dtpDesde3;
        private System.Windows.Forms.Label lblHastaD;
        private System.Windows.Forms.DateTimePicker dtpHasta3;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.PictureBox picGrafico;
        private System.Windows.Forms.Panel pnlGraficoTotales;
        private System.Windows.Forms.Label lblGraficoTotal;
        private System.Windows.Forms.Label lblGraficoFacturas;
        private System.Windows.Forms.Label lblGraficoPromedio;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCerrar;
    }
}