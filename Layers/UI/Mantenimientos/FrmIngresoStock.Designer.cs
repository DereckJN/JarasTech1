namespace JarasTech.Layers.UI.Mantenimientos
{
    partial class FrmIngresoStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTipoIndicador = new System.Windows.Forms.Panel();
            this.lblTipoIndicador = new System.Windows.Forms.Label();
            this.grpTipoMovimiento = new System.Windows.Forms.GroupBox();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.rbSalida = new System.Windows.Forms.RadioButton();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.lblProdLbl = new System.Windows.Forms.Label();
            this.lblProductoNombre = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.grpMovimiento = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtFacturaCompra = new System.Windows.Forms.TextBox();
            this.lblAvisoSalida = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.btnRefrescarHistorial = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlTipoIndicador.SuspendLayout();
            this.grpTipoMovimiento.SuspendLayout();
            this.grpBusqueda.SuspendLayout();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.grpProducto.SuspendLayout();
            this.grpMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1134, 55);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(346, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Control de Inventario / Stock";
            // 
            // pnlTipoIndicador
            // 
            this.pnlTipoIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pnlTipoIndicador.Controls.Add(this.lblTipoIndicador);
            this.pnlTipoIndicador.Location = new System.Drawing.Point(12, 62);
            this.pnlTipoIndicador.Name = "pnlTipoIndicador";
            this.pnlTipoIndicador.Size = new System.Drawing.Size(520, 34);
            this.pnlTipoIndicador.TabIndex = 1;
            // 
            // lblTipoIndicador
            // 
            this.lblTipoIndicador.AutoSize = true;
            this.lblTipoIndicador.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTipoIndicador.ForeColor = System.Drawing.Color.White;
            this.lblTipoIndicador.Location = new System.Drawing.Point(10, 6);
            this.lblTipoIndicador.Name = "lblTipoIndicador";
            this.lblTipoIndicador.Size = new System.Drawing.Size(193, 25);
            this.lblTipoIndicador.TabIndex = 0;
            this.lblTipoIndicador.Text = "ENTRADA DE STOCK";
            // 
            // grpTipoMovimiento
            // 
            this.grpTipoMovimiento.Controls.Add(this.rbEntrada);
            this.grpTipoMovimiento.Controls.Add(this.rbSalida);
            this.grpTipoMovimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTipoMovimiento.Location = new System.Drawing.Point(12, 103);
            this.grpTipoMovimiento.Name = "grpTipoMovimiento";
            this.grpTipoMovimiento.Size = new System.Drawing.Size(520, 55);
            this.grpTipoMovimiento.TabIndex = 2;
            this.grpTipoMovimiento.TabStop = false;
            this.grpTipoMovimiento.Text = "Tipo de Movimiento";
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Checked = true;
            this.rbEntrada.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rbEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.rbEntrada.Location = new System.Drawing.Point(15, 22);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(247, 27);
            this.rbEntrada.TabIndex = 0;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada (incrementa stock)";
            this.rbEntrada.CheckedChanged += new System.EventHandler(this.rbEntrada_CheckedChanged);
            // 
            // rbSalida
            // 
            this.rbSalida.AutoSize = true;
            this.rbSalida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rbSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.rbSalida.Location = new System.Drawing.Point(270, 22);
            this.rbSalida.Name = "rbSalida";
            this.rbSalida.Size = new System.Drawing.Size(225, 27);
            this.rbSalida.TabIndex = 1;
            this.rbSalida.Text = "Salida (inventario físico)";
            this.rbSalida.CheckedChanged += new System.EventHandler(this.rbSalida_CheckedChanged);
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.lblBuscar);
            this.grpBusqueda.Controls.Add(this.txtBuscarProducto);
            this.grpBusqueda.Controls.Add(this.btnBuscarProducto);
            this.grpBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBusqueda.Location = new System.Drawing.Point(12, 166);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(520, 65);
            this.grpBusqueda.TabIndex = 3;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Buscar Producto";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBuscar.Location = new System.Drawing.Point(10, 28);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(130, 20);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Código / Nombre:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscarProducto.Location = new System.Drawing.Point(120, 24);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(270, 29);
            this.txtBuscarProducto.TabIndex = 1;
            this.txtBuscarProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProducto_KeyDown);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Location = new System.Drawing.Point(400, 22);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(108, 28);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.dgvResultados);
            this.grpResultados.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.grpResultados.Location = new System.Drawing.Point(12, 238);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(520, 170);
            this.grpResultados.TabIndex = 4;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados — doble clic para seleccionar";
            this.grpResultados.Visible = false;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados.ColumnHeadersHeight = 28;
            this.dgvResultados.EnableHeadersVisualStyles = false;
            this.dgvResultados.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgvResultados.Location = new System.Drawing.Point(8, 22);
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(500, 135);
            this.dgvResultados.TabIndex = 0;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.lblProdLbl);
            this.grpProducto.Controls.Add(this.lblProductoNombre);
            this.grpProducto.Controls.Add(this.lblStockActual);
            this.grpProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpProducto.Location = new System.Drawing.Point(12, 415);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(520, 80);
            this.grpProducto.TabIndex = 5;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Producto Seleccionado";
            // 
            // lblProdLbl
            // 
            this.lblProdLbl.AutoSize = true;
            this.lblProdLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProdLbl.Location = new System.Drawing.Point(10, 26);
            this.lblProdLbl.Name = "lblProdLbl";
            this.lblProdLbl.Size = new System.Drawing.Size(77, 20);
            this.lblProdLbl.TabIndex = 0;
            this.lblProdLbl.Text = "Producto:";
            // 
            // lblProductoNombre
            // 
            this.lblProductoNombre.AutoSize = true;
            this.lblProductoNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProductoNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.lblProductoNombre.Location = new System.Drawing.Point(85, 26);
            this.lblProductoNombre.Name = "lblProductoNombre";
            this.lblProductoNombre.Size = new System.Drawing.Size(26, 21);
            this.lblProductoNombre.TabIndex = 1;
            this.lblProductoNombre.Text = "—";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStockActual.ForeColor = System.Drawing.Color.DimGray;
            this.lblStockActual.Location = new System.Drawing.Point(10, 52);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(127, 21);
            this.lblStockActual.TabIndex = 2;
            this.lblStockActual.Text = "Stock actual: —";
            // 
            // grpMovimiento
            // 
            this.grpMovimiento.Controls.Add(this.lblCantidad);
            this.grpMovimiento.Controls.Add(this.numCantidad);
            this.grpMovimiento.Controls.Add(this.lblFecha);
            this.grpMovimiento.Controls.Add(this.dtpFecha);
            this.grpMovimiento.Controls.Add(this.lblFactura);
            this.grpMovimiento.Controls.Add(this.txtFacturaCompra);
            this.grpMovimiento.Controls.Add(this.lblAvisoSalida);
            this.grpMovimiento.Controls.Add(this.lblObservaciones);
            this.grpMovimiento.Controls.Add(this.txtObservaciones);
            this.grpMovimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpMovimiento.Location = new System.Drawing.Point(12, 502);
            this.grpMovimiento.Name = "grpMovimiento";
            this.grpMovimiento.Size = new System.Drawing.Size(520, 220);
            this.grpMovimiento.TabIndex = 6;
            this.grpMovimiento.TabStop = false;
            this.grpMovimiento.Text = "Datos del Movimiento";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCantidad.Location = new System.Drawing.Point(10, 28);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 20);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numCantidad.Location = new System.Drawing.Point(78, 24);
            this.numCantidad.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(90, 30);
            this.numCantidad.TabIndex = 1;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.Location = new System.Drawing.Point(185, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(235, 24);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(140, 29);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFactura.Location = new System.Drawing.Point(10, 68);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(116, 20);
            this.lblFactura.TabIndex = 4;
            this.lblFactura.Text = "Factura Compra:";
            // 
            // txtFacturaCompra
            // 
            this.txtFacturaCompra.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFacturaCompra.Location = new System.Drawing.Point(120, 64);
            this.txtFacturaCompra.MaxLength = 100;
            this.txtFacturaCompra.Name = "txtFacturaCompra";
            this.txtFacturaCompra.Size = new System.Drawing.Size(380, 29);
            this.txtFacturaCompra.TabIndex = 5;
            // 
            // lblAvisoSalida
            // 
            this.lblAvisoSalida.AutoSize = true;
            this.lblAvisoSalida.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblAvisoSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblAvisoSalida.Location = new System.Drawing.Point(10, 68);
            this.lblAvisoSalida.Name = "lblAvisoSalida";
            this.lblAvisoSalida.Size = new System.Drawing.Size(439, 20);
            this.lblAvisoSalida.TabIndex = 6;
            this.lblAvisoSalida.Text = "Las salidas se realizan únicamente contra toma de inventario físico.";
            this.lblAvisoSalida.Visible = false;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblObservaciones.Location = new System.Drawing.Point(10, 108);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(108, 20);
            this.lblObservaciones.TabIndex = 7;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtObservaciones.Location = new System.Drawing.Point(10, 126);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(495, 75);
            this.txtObservaciones.TabIndex = 8;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnRegistrar);
            this.pnlBotones.Controls.Add(this.btnLimpiar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 728);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(520, 50);
            this.pnlBotones.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(351, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 8);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 36);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar Movimiento";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(215, 8);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 36);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpHistorial
            // 
            this.grpHistorial.Controls.Add(this.dgvHistorial);
            this.grpHistorial.Controls.Add(this.btnRefrescarHistorial);
            this.grpHistorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpHistorial.Location = new System.Drawing.Point(548, 62);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Size = new System.Drawing.Size(540, 720);
            this.grpHistorial.TabIndex = 8;
            this.grpHistorial.TabStop = false;
            this.grpHistorial.Text = "Historial de Movimientos (verde = entrada | rojo = salida)";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorial.ColumnHeadersHeight = 30;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgvHistorial.Location = new System.Drawing.Point(8, 24);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(520, 640);
            this.dgvHistorial.TabIndex = 0;
            // 
            // btnRefrescarHistorial
            // 
            this.btnRefrescarHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRefrescarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescarHistorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefrescarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnRefrescarHistorial.Location = new System.Drawing.Point(8, 672);
            this.btnRefrescarHistorial.Name = "btnRefrescarHistorial";
            this.btnRefrescarHistorial.Size = new System.Drawing.Size(160, 30);
            this.btnRefrescarHistorial.TabIndex = 1;
            this.btnRefrescarHistorial.Text = "Refrescar historial";
            this.btnRefrescarHistorial.UseVisualStyleBackColor = false;
            this.btnRefrescarHistorial.Click += new System.EventHandler(this.btnRefrescarHistorial_Click);
            // 
            // FrmIngresoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1134, 810);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlTipoIndicador);
            this.Controls.Add(this.grpTipoMovimiento);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.grpProducto);
            this.Controls.Add(this.grpMovimiento);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.grpHistorial);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmIngresoStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JarasTech - Control de Stock";
            this.Load += new System.EventHandler(this.FrmIngresoStock_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlTipoIndicador.ResumeLayout(false);
            this.pnlTipoIndicador.PerformLayout();
            this.grpTipoMovimiento.ResumeLayout(false);
            this.grpTipoMovimiento.PerformLayout();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.grpResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            this.grpMovimiento.ResumeLayout(false);
            this.grpMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTipoIndicador;
        private System.Windows.Forms.Label lblTipoIndicador;
        private System.Windows.Forms.GroupBox grpTipoMovimiento;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.RadioButton rbSalida;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Label lblProdLbl;
        private System.Windows.Forms.Label lblProductoNombre;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.GroupBox grpMovimiento;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtFacturaCompra;
        private System.Windows.Forms.Label lblAvisoSalida;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btnRefrescarHistorial;
        private System.Windows.Forms.Button btnCancelar;
    }
}