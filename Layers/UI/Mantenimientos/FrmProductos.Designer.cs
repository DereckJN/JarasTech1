namespace JarasTech.Layers.UI.Mantenimientos
{
    partial class FrmProductos
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
            this.tabProducto = new System.Windows.Forms.TabControl();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblFiltroTexto = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.cboFiltroMarca = new System.Windows.Forms.ComboBox();
            this.lblFiltroModelo = new System.Windows.Forms.Label();
            this.cboFiltroModelo = new System.Windows.Forms.ComboBox();
            this.lblFiltroTipo = new System.Windows.Forms.Label();
            this.cboFiltroTipo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pnlBotonesLista = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.grpGenerales = new System.Windows.Forms.GroupBox();
            this.lblCodInterno = new System.Windows.Forms.Label();
            this.txtCodigoInterno = new System.Windows.Forms.TextBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioC = new System.Windows.Forms.Label();
            this.numPrecioC = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioD = new System.Windows.Forms.Label();
            this.numPrecioD = new System.Windows.Forms.NumericUpDown();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.lblCaract = new System.Windows.Forms.Label();
            this.txtCaracteristicas = new System.Windows.Forms.RichTextBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.txtExtras = new System.Windows.Forms.RichTextBox();
            this.grpMedia = new System.Windows.Forms.GroupBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.btnQuitarFoto = new System.Windows.Forms.Button();
            this.lblNombreDoc = new System.Windows.Forms.Label();
            this.btnCargarDoc = new System.Windows.Forms.Button();
            this.btnQuitarDoc = new System.Windows.Forms.Button();
            this.pnlBotonesDatos = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();

            this.pnlTop.SuspendLayout();
            this.tabProducto.SuspendLayout();
            this.tabLista.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlBotonesLista.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.grpGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioD)).BeginInit();
            this.grpDetalle.SuspendLayout();
            this.grpMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.pnlBotonesDatos.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 55);
            this.pnlTop.TabIndex = 0;
            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mantenimiento de Productos";

            // tabProducto
            this.tabProducto.Controls.Add(this.tabLista);
            this.tabProducto.Controls.Add(this.tabDatos);
            this.tabProducto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabProducto.Location = new System.Drawing.Point(0, 55);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Size = new System.Drawing.Size(1100, 750);
            this.tabProducto.TabIndex = 1;

            // ── tabLista ─────────────────────────────────────────────────
            this.tabLista.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabLista.Controls.Add(this.grpFiltros);
            this.tabLista.Controls.Add(this.dgvProductos);
            this.tabLista.Controls.Add(this.pnlBotonesLista);
            this.tabLista.Location = new System.Drawing.Point(4, 26);
            this.tabLista.Name = "tabLista";
            this.tabLista.Size = new System.Drawing.Size(1092, 720);
            this.tabLista.TabIndex = 0;
            this.tabLista.Text = "  Lista de Productos  ";

            // grpFiltros
            this.grpFiltros.Controls.Add(this.lblFiltroTexto);
            this.grpFiltros.Controls.Add(this.txtFiltro);
            this.grpFiltros.Controls.Add(this.lblFiltroMarca);
            this.grpFiltros.Controls.Add(this.cboFiltroMarca);
            this.grpFiltros.Controls.Add(this.lblFiltroModelo);
            this.grpFiltros.Controls.Add(this.cboFiltroModelo);
            this.grpFiltros.Controls.Add(this.lblFiltroTipo);
            this.grpFiltros.Controls.Add(this.cboFiltroTipo);
            this.grpFiltros.Controls.Add(this.btnBuscar);
            this.grpFiltros.Controls.Add(this.btnLimpiarFiltro);
            this.grpFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFiltros.Location = new System.Drawing.Point(8, 8);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(1072, 95);
            this.grpFiltros.TabIndex = 0;
            this.grpFiltros.Text = "Filtros de Búsqueda";
            // fila 1
            this.lblFiltroTexto.AutoSize = true; this.lblFiltroTexto.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblFiltroTexto.Location = new System.Drawing.Point(10, 24); this.lblFiltroTexto.Name = "lblFiltroTexto"; this.lblFiltroTexto.Size = new System.Drawing.Size(90, 15); this.lblFiltroTexto.TabIndex = 0; this.lblFiltroTexto.Text = "Código / Marca:";
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtFiltro.Location = new System.Drawing.Point(110, 20); this.txtFiltro.Name = "txtFiltro"; this.txtFiltro.Size = new System.Drawing.Size(200, 23); this.txtFiltro.TabIndex = 1;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            this.lblFiltroMarca.AutoSize = true; this.lblFiltroMarca.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblFiltroMarca.Location = new System.Drawing.Point(322, 24); this.lblFiltroMarca.Name = "lblFiltroMarca"; this.lblFiltroMarca.Size = new System.Drawing.Size(45, 15); this.lblFiltroMarca.TabIndex = 2; this.lblFiltroMarca.Text = "Marca:";
            this.cboFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboFiltroMarca.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.cboFiltroMarca.Location = new System.Drawing.Point(372, 20); this.cboFiltroMarca.Name = "cboFiltroMarca"; this.cboFiltroMarca.Size = new System.Drawing.Size(170, 25); this.cboFiltroMarca.TabIndex = 3;
            this.lblFiltroModelo.AutoSize = true; this.lblFiltroModelo.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblFiltroModelo.Location = new System.Drawing.Point(554, 24); this.lblFiltroModelo.Name = "lblFiltroModelo"; this.lblFiltroModelo.Size = new System.Drawing.Size(52, 15); this.lblFiltroModelo.TabIndex = 4; this.lblFiltroModelo.Text = "Modelo:";
            this.cboFiltroModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboFiltroModelo.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.cboFiltroModelo.Location = new System.Drawing.Point(610, 20); this.cboFiltroModelo.Name = "cboFiltroModelo"; this.cboFiltroModelo.Size = new System.Drawing.Size(170, 25); this.cboFiltroModelo.TabIndex = 5;
            // fila 2
            this.lblFiltroTipo.AutoSize = true; this.lblFiltroTipo.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblFiltroTipo.Location = new System.Drawing.Point(10, 58); this.lblFiltroTipo.Name = "lblFiltroTipo"; this.lblFiltroTipo.Size = new System.Drawing.Size(35, 15); this.lblFiltroTipo.TabIndex = 6; this.lblFiltroTipo.Text = "Tipo:";
            this.cboFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboFiltroTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.cboFiltroTipo.Location = new System.Drawing.Point(50, 54); this.cboFiltroTipo.Name = "cboFiltroTipo"; this.cboFiltroTipo.Size = new System.Drawing.Size(200, 25); this.cboFiltroTipo.TabIndex = 7;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(0, 120, 215); this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.btnBuscar.ForeColor = System.Drawing.Color.White; this.btnBuscar.Location = new System.Drawing.Point(830, 22); this.btnBuscar.Name = "btnBuscar"; this.btnBuscar.Size = new System.Drawing.Size(105, 28); this.btnBuscar.TabIndex = 8; this.btnBuscar.Text = "Buscar"; this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.FromArgb(108, 117, 125); this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLimpiarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.btnLimpiarFiltro.ForeColor = System.Drawing.Color.White; this.btnLimpiarFiltro.Location = new System.Drawing.Point(945, 22); this.btnLimpiarFiltro.Name = "btnLimpiarFiltro"; this.btnLimpiarFiltro.Size = new System.Drawing.Size(112, 28); this.btnLimpiarFiltro.TabIndex = 9; this.btnLimpiarFiltro.Text = "Limpiar filtros"; this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);

            // dgvProductos
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.dgvProductos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeight = 30;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvProductos.Location = new System.Drawing.Point(8, 112);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1072, 545);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);

            // pnlBotonesLista
            this.pnlBotonesLista.Controls.Add(this.btnNuevo);
            this.pnlBotonesLista.Controls.Add(this.btnEliminar);
            this.pnlBotonesLista.Location = new System.Drawing.Point(8, 662);
            this.pnlBotonesLista.Name = "pnlBotonesLista";
            this.pnlBotonesLista.Size = new System.Drawing.Size(1072, 48);
            this.pnlBotonesLista.TabIndex = 2;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold); this.btnNuevo.ForeColor = System.Drawing.Color.White; this.btnNuevo.Location = new System.Drawing.Point(0, 8); this.btnNuevo.Name = "btnNuevo"; this.btnNuevo.Size = new System.Drawing.Size(150, 36); this.btnNuevo.TabIndex = 0; this.btnNuevo.Text = "Nuevo Producto"; this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold); this.btnEliminar.ForeColor = System.Drawing.Color.White; this.btnEliminar.Location = new System.Drawing.Point(160, 8); this.btnEliminar.Name = "btnEliminar"; this.btnEliminar.Size = new System.Drawing.Size(120, 36); this.btnEliminar.TabIndex = 1; this.btnEliminar.Text = "Eliminar"; this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // ── tabDatos ──────────────────────────────────────────────────
            this.tabDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDatos.Controls.Add(this.grpGenerales);
            this.tabDatos.Controls.Add(this.grpDetalle);
            this.tabDatos.Controls.Add(this.grpMedia);
            this.tabDatos.Controls.Add(this.pnlBotonesDatos);
            this.tabDatos.Location = new System.Drawing.Point(4, 26);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Size = new System.Drawing.Size(1092, 720);
            this.tabDatos.TabIndex = 1;
            this.tabDatos.Text = "  Datos del Producto  ";

            // grpGenerales
            this.grpGenerales.Controls.Add(this.lblCodInterno);
            this.grpGenerales.Controls.Add(this.txtCodigoInterno);
            this.grpGenerales.Controls.Add(this.lblCodBarras);
            this.grpGenerales.Controls.Add(this.txtCodigoBarras);
            this.grpGenerales.Controls.Add(this.lblTipo);
            this.grpGenerales.Controls.Add(this.cboTipo);
            this.grpGenerales.Controls.Add(this.lblMarca);
            this.grpGenerales.Controls.Add(this.cboMarca);
            this.grpGenerales.Controls.Add(this.lblModelo);
            this.grpGenerales.Controls.Add(this.cboModelo);
            this.grpGenerales.Controls.Add(this.lblColor);
            this.grpGenerales.Controls.Add(this.txtColor);
            this.grpGenerales.Controls.Add(this.lblStock);
            this.grpGenerales.Controls.Add(this.numStock);
            this.grpGenerales.Controls.Add(this.lblPrecioC);
            this.grpGenerales.Controls.Add(this.numPrecioC);
            this.grpGenerales.Controls.Add(this.lblPrecioD);
            this.grpGenerales.Controls.Add(this.numPrecioD);
            this.grpGenerales.Controls.Add(this.chkEstado);
            this.grpGenerales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpGenerales.Location = new System.Drawing.Point(8, 8);
            this.grpGenerales.Name = "grpGenerales";
            this.grpGenerales.Size = new System.Drawing.Size(1072, 165);
            this.grpGenerales.TabIndex = 0;
            this.grpGenerales.Text = "Información General";
            // fila 1
            this.lblCodInterno.AutoSize = true; this.lblCodInterno.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblCodInterno.Location = new System.Drawing.Point(10, 28); this.lblCodInterno.Name = "lblCodInterno"; this.lblCodInterno.Size = new System.Drawing.Size(95, 15); this.lblCodInterno.TabIndex = 0; this.lblCodInterno.Text = "Código Interno:";
            this.txtCodigoInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper; this.txtCodigoInterno.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtCodigoInterno.Location = new System.Drawing.Point(115, 24); this.txtCodigoInterno.MaxLength = 20; this.txtCodigoInterno.Name = "txtCodigoInterno"; this.txtCodigoInterno.Size = new System.Drawing.Size(130, 23); this.txtCodigoInterno.TabIndex = 1;
            this.lblCodBarras.AutoSize = true; this.lblCodBarras.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblCodBarras.Location = new System.Drawing.Point(260, 28); this.lblCodBarras.Name = "lblCodBarras"; this.lblCodBarras.Size = new System.Drawing.Size(88, 15); this.lblCodBarras.TabIndex = 2; this.lblCodBarras.Text = "Cód. Barras:";
            this.txtCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtCodigoBarras.Location = new System.Drawing.Point(355, 24); this.txtCodigoBarras.MaxLength = 50; this.txtCodigoBarras.Name = "txtCodigoBarras"; this.txtCodigoBarras.Size = new System.Drawing.Size(165, 23); this.txtCodigoBarras.TabIndex = 3;
            this.lblTipo.AutoSize = true; this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblTipo.Location = new System.Drawing.Point(534, 28); this.lblTipo.Name = "lblTipo"; this.lblTipo.Size = new System.Drawing.Size(100, 15); this.lblTipo.TabIndex = 4; this.lblTipo.Text = "Tipo Dispositivo:";
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.cboTipo.Location = new System.Drawing.Point(638, 24); this.cboTipo.Name = "cboTipo"; this.cboTipo.Size = new System.Drawing.Size(210, 25); this.cboTipo.TabIndex = 5;
            // fila 2
            this.lblMarca.AutoSize = true; this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblMarca.Location = new System.Drawing.Point(10, 63); this.lblMarca.Name = "lblMarca"; this.lblMarca.Size = new System.Drawing.Size(45, 15); this.lblMarca.TabIndex = 6; this.lblMarca.Text = "Marca:";
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboMarca.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.cboMarca.Location = new System.Drawing.Point(60, 59); this.cboMarca.Name = "cboMarca"; this.cboMarca.Size = new System.Drawing.Size(200, 25); this.cboMarca.TabIndex = 7;
            this.lblModelo.AutoSize = true; this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblModelo.Location = new System.Drawing.Point(275, 63); this.lblModelo.Name = "lblModelo"; this.lblModelo.Size = new System.Drawing.Size(52, 15); this.lblModelo.TabIndex = 8; this.lblModelo.Text = "Modelo:";
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboModelo.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.cboModelo.Location = new System.Drawing.Point(332, 59); this.cboModelo.Name = "cboModelo"; this.cboModelo.Size = new System.Drawing.Size(200, 25); this.cboModelo.TabIndex = 9;
            this.lblColor.AutoSize = true; this.lblColor.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblColor.Location = new System.Drawing.Point(548, 63); this.lblColor.Name = "lblColor"; this.lblColor.Size = new System.Drawing.Size(40, 15); this.lblColor.TabIndex = 10; this.lblColor.Text = "Color:";
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtColor.Location = new System.Drawing.Point(594, 59); this.txtColor.MaxLength = 50; this.txtColor.Name = "txtColor"; this.txtColor.Size = new System.Drawing.Size(150, 23); this.txtColor.TabIndex = 11;
            // fila 3
            this.lblStock.AutoSize = true; this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblStock.Location = new System.Drawing.Point(10, 102); this.lblStock.Name = "lblStock"; this.lblStock.Size = new System.Drawing.Size(42, 15); this.lblStock.TabIndex = 12; this.lblStock.Text = "Stock:";
            this.numStock.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.numStock.Location = new System.Drawing.Point(58, 98); this.numStock.Maximum = new decimal(new int[] { 99999, 0, 0, 0 }); this.numStock.Name = "numStock"; this.numStock.Size = new System.Drawing.Size(90, 23); this.numStock.TabIndex = 13; this.numStock.ThousandsSeparator = true;
            this.lblPrecioC.AutoSize = true; this.lblPrecioC.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblPrecioC.Location = new System.Drawing.Point(162, 102); this.lblPrecioC.Name = "lblPrecioC"; this.lblPrecioC.Size = new System.Drawing.Size(58, 15); this.lblPrecioC.TabIndex = 14; this.lblPrecioC.Text = "Precio ₡:";
            this.numPrecioC.DecimalPlaces = 2; this.numPrecioC.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.numPrecioC.Location = new System.Drawing.Point(224, 98); this.numPrecioC.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 }); this.numPrecioC.Name = "numPrecioC"; this.numPrecioC.Size = new System.Drawing.Size(140, 23); this.numPrecioC.TabIndex = 15; this.numPrecioC.ThousandsSeparator = true;
            this.lblPrecioD.AutoSize = true; this.lblPrecioD.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblPrecioD.Location = new System.Drawing.Point(378, 102); this.lblPrecioD.Name = "lblPrecioD"; this.lblPrecioD.Size = new System.Drawing.Size(55, 15); this.lblPrecioD.TabIndex = 16; this.lblPrecioD.Text = "Precio $:";
            this.numPrecioD.DecimalPlaces = 2; this.numPrecioD.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.numPrecioD.Location = new System.Drawing.Point(438, 98); this.numPrecioD.Maximum = new decimal(new int[] { 999999, 0, 0, 0 }); this.numPrecioD.Name = "numPrecioD"; this.numPrecioD.Size = new System.Drawing.Size(120, 23); this.numPrecioD.TabIndex = 17; this.numPrecioD.ThousandsSeparator = true;
            this.chkEstado.AutoSize = true; this.chkEstado.Checked = true; this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked; this.chkEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold); this.chkEstado.Location = new System.Drawing.Point(580, 100); this.chkEstado.Name = "chkEstado"; this.chkEstado.Size = new System.Drawing.Size(120, 21); this.chkEstado.TabIndex = 18; this.chkEstado.Text = "Producto Activo";

            // grpDetalle
            this.grpDetalle.Controls.Add(this.lblCaract);
            this.grpDetalle.Controls.Add(this.txtCaracteristicas);
            this.grpDetalle.Controls.Add(this.lblExtras);
            this.grpDetalle.Controls.Add(this.txtExtras);
            this.grpDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetalle.Location = new System.Drawing.Point(8, 182);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(650, 270);
            this.grpDetalle.TabIndex = 1;
            this.grpDetalle.Text = "Características y Extras";
            this.lblCaract.AutoSize = true; this.lblCaract.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblCaract.Location = new System.Drawing.Point(10, 22); this.lblCaract.Name = "lblCaract"; this.lblCaract.Size = new System.Drawing.Size(145, 15); this.lblCaract.TabIndex = 0; this.lblCaract.Text = "Características técnicas:";
            this.txtCaracteristicas.Font = new System.Drawing.Font("Segoe UI", 9F); this.txtCaracteristicas.Location = new System.Drawing.Point(10, 40); this.txtCaracteristicas.Name = "txtCaracteristicas"; this.txtCaracteristicas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical; this.txtCaracteristicas.Size = new System.Drawing.Size(628, 90); this.txtCaracteristicas.TabIndex = 1;
            this.lblExtras.AutoSize = true; this.lblExtras.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblExtras.Location = new System.Drawing.Point(10, 142); this.lblExtras.Name = "lblExtras"; this.lblExtras.Size = new System.Drawing.Size(170, 15); this.lblExtras.TabIndex = 2; this.lblExtras.Text = "Extras / Accesorios incluidos:";
            this.txtExtras.Font = new System.Drawing.Font("Segoe UI", 9F); this.txtExtras.Location = new System.Drawing.Point(10, 160); this.txtExtras.Name = "txtExtras"; this.txtExtras.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical; this.txtExtras.Size = new System.Drawing.Size(628, 90); this.txtExtras.TabIndex = 3;

            // grpMedia
            this.grpMedia.Controls.Add(this.picFoto);
            this.grpMedia.Controls.Add(this.btnCargarFoto);
            this.grpMedia.Controls.Add(this.btnQuitarFoto);
            this.grpMedia.Controls.Add(this.lblNombreDoc);
            this.grpMedia.Controls.Add(this.btnCargarDoc);
            this.grpMedia.Controls.Add(this.btnQuitarDoc);
            this.grpMedia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpMedia.Location = new System.Drawing.Point(670, 182);
            this.grpMedia.Name = "grpMedia";
            this.grpMedia.Size = new System.Drawing.Size(410, 270);
            this.grpMedia.TabIndex = 2;
            this.grpMedia.Text = "Fotografía y Documento";
            this.picFoto.BackColor = System.Drawing.Color.LightGray; this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.picFoto.Location = new System.Drawing.Point(10, 22); this.picFoto.Name = "picFoto"; this.picFoto.Size = new System.Drawing.Size(200, 150); this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom; this.picFoto.TabIndex = 0;
            this.btnCargarFoto.BackColor = System.Drawing.Color.FromArgb(0, 120, 215); this.btnCargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnCargarFoto.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold); this.btnCargarFoto.ForeColor = System.Drawing.Color.White; this.btnCargarFoto.Location = new System.Drawing.Point(220, 22); this.btnCargarFoto.Name = "btnCargarFoto"; this.btnCargarFoto.Size = new System.Drawing.Size(178, 32); this.btnCargarFoto.TabIndex = 1; this.btnCargarFoto.Text = "Cargar Foto"; this.btnCargarFoto.UseVisualStyleBackColor = false;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            this.btnQuitarFoto.BackColor = System.Drawing.Color.FromArgb(108, 117, 125); this.btnQuitarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnQuitarFoto.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold); this.btnQuitarFoto.ForeColor = System.Drawing.Color.White; this.btnQuitarFoto.Location = new System.Drawing.Point(220, 62); this.btnQuitarFoto.Name = "btnQuitarFoto"; this.btnQuitarFoto.Size = new System.Drawing.Size(178, 32); this.btnQuitarFoto.TabIndex = 2; this.btnQuitarFoto.Text = "Quitar Foto"; this.btnQuitarFoto.UseVisualStyleBackColor = false;
            this.btnQuitarFoto.Click += new System.EventHandler(this.btnQuitarFoto_Click);
            this.lblNombreDoc.AutoSize = true; this.lblNombreDoc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic); this.lblNombreDoc.ForeColor = System.Drawing.Color.DimGray; this.lblNombreDoc.Location = new System.Drawing.Point(10, 185); this.lblNombreDoc.Name = "lblNombreDoc"; this.lblNombreDoc.Size = new System.Drawing.Size(95, 15); this.lblNombreDoc.TabIndex = 3; this.lblNombreDoc.Text = "(sin documento)";
            this.btnCargarDoc.BackColor = System.Drawing.Color.FromArgb(0, 120, 215); this.btnCargarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnCargarDoc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold); this.btnCargarDoc.ForeColor = System.Drawing.Color.White; this.btnCargarDoc.Location = new System.Drawing.Point(10, 208); this.btnCargarDoc.Name = "btnCargarDoc"; this.btnCargarDoc.Size = new System.Drawing.Size(190, 32); this.btnCargarDoc.TabIndex = 4; this.btnCargarDoc.Text = "Cargar Doc (PDF/DOCX)"; this.btnCargarDoc.UseVisualStyleBackColor = false;
            this.btnCargarDoc.Click += new System.EventHandler(this.btnCargarDoc_Click);
            this.btnQuitarDoc.BackColor = System.Drawing.Color.FromArgb(108, 117, 125); this.btnQuitarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnQuitarDoc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold); this.btnQuitarDoc.ForeColor = System.Drawing.Color.White; this.btnQuitarDoc.Location = new System.Drawing.Point(210, 208); this.btnQuitarDoc.Name = "btnQuitarDoc"; this.btnQuitarDoc.Size = new System.Drawing.Size(100, 32); this.btnQuitarDoc.TabIndex = 5; this.btnQuitarDoc.Text = "Quitar"; this.btnQuitarDoc.UseVisualStyleBackColor = false;
            this.btnQuitarDoc.Click += new System.EventHandler(this.btnQuitarDoc_Click);

            // pnlBotonesDatos
            this.pnlBotonesDatos.Controls.Add(this.btnGuardar);
            this.pnlBotonesDatos.Location = new System.Drawing.Point(8, 462);
            this.pnlBotonesDatos.Name = "pnlBotonesDatos";
            this.pnlBotonesDatos.Size = new System.Drawing.Size(1072, 48);
            this.pnlBotonesDatos.TabIndex = 3;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 120, 215); this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnGuardar.ForeColor = System.Drawing.Color.White; this.btnGuardar.Location = new System.Drawing.Point(0, 6); this.btnGuardar.Name = "btnGuardar"; this.btnGuardar.Size = new System.Drawing.Size(160, 38); this.btnGuardar.TabIndex = 0; this.btnGuardar.Text = "Guardar"; this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // FrmProductos
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 805);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.tabProducto);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JarasTech - Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);

            this.pnlTop.ResumeLayout(false); this.pnlTop.PerformLayout();
            this.tabProducto.ResumeLayout(false);
            this.tabLista.ResumeLayout(false);
            this.grpFiltros.ResumeLayout(false); this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlBotonesLista.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.grpGenerales.ResumeLayout(false); this.grpGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioD)).EndInit();
            this.grpDetalle.ResumeLayout(false);
            this.grpMedia.ResumeLayout(false); this.grpMedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.pnlBotonesDatos.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabProducto;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblFiltroTexto;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.ComboBox cboFiltroMarca;
        private System.Windows.Forms.Label lblFiltroModelo;
        private System.Windows.Forms.ComboBox cboFiltroModelo;
        private System.Windows.Forms.Label lblFiltroTipo;
        private System.Windows.Forms.ComboBox cboFiltroTipo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel pnlBotonesLista;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabPage tabDatos;
        private System.Windows.Forms.GroupBox grpGenerales;
        private System.Windows.Forms.Label lblCodInterno;
        private System.Windows.Forms.TextBox txtCodigoInterno;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label lblPrecioC;
        private System.Windows.Forms.NumericUpDown numPrecioC;
        private System.Windows.Forms.Label lblPrecioD;
        private System.Windows.Forms.NumericUpDown numPrecioD;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.Label lblCaract;
        private System.Windows.Forms.RichTextBox txtCaracteristicas;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.RichTextBox txtExtras;
        private System.Windows.Forms.GroupBox grpMedia;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Button btnQuitarFoto;
        private System.Windows.Forms.Label lblNombreDoc;
        private System.Windows.Forms.Button btnCargarDoc;
        private System.Windows.Forms.Button btnQuitarDoc;
        private System.Windows.Forms.Panel pnlBotonesDatos;
        private System.Windows.Forms.Button btnGuardar;
    }
}