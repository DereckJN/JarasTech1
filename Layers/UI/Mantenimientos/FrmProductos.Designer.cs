namespace JarasTech.Layers.UI.Mantenimientos
{
    partial class FrmProductos
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabProducto = new System.Windows.Forms.TabControl();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
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
            this.pnlBotonesList = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.grpGenerales = new System.Windows.Forms.GroupBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.tabProducto.SuspendLayout();
            this.tabLista.SuspendLayout();
            this.grpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlBotonesList.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.grpGenerales.SuspendLayout();
            this.grpDetalle.SuspendLayout();
            this.grpMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.pnlBotonesDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1257, 64);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(445, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📱  Mantenimiento de Productos";
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.tabLista);
            this.tabProducto.Controls.Add(this.tabDatos);
            this.tabProducto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabProducto.Location = new System.Drawing.Point(14, 75);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.SelectedIndex = 0;
            this.tabProducto.Size = new System.Drawing.Size(1230, 768);
            this.tabProducto.TabIndex = 1;
            // 
            // tabLista
            // 
            this.tabLista.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabLista.Controls.Add(this.grpFiltro);
            this.tabLista.Controls.Add(this.dgvProductos);
            this.tabLista.Controls.Add(this.pnlBotonesList);
            this.tabLista.Location = new System.Drawing.Point(4, 30);
            this.tabLista.Name = "tabLista";
            this.tabLista.Size = new System.Drawing.Size(1222, 734);
            this.tabLista.TabIndex = 0;
            this.tabLista.Text = "  📋  Lista de Productos  ";
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.lblFiltroTexto);
            this.grpFiltro.Controls.Add(this.txtFiltro);
            this.grpFiltro.Controls.Add(this.lblFiltroMarca);
            this.grpFiltro.Controls.Add(this.cboFiltroMarca);
            this.grpFiltro.Controls.Add(this.lblFiltroModelo);
            this.grpFiltro.Controls.Add(this.cboFiltroModelo);
            this.grpFiltro.Controls.Add(this.lblFiltroTipo);
            this.grpFiltro.Controls.Add(this.cboFiltroTipo);
            this.grpFiltro.Controls.Add(this.btnBuscar);
            this.grpFiltro.Controls.Add(this.btnLimpiarFiltro);
            this.grpFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFiltro.Location = new System.Drawing.Point(9, 9);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(1206, 101);
            this.grpFiltro.TabIndex = 0;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtros de Búsqueda";
            // 
            // lblFiltroTexto
            // 
            this.lblFiltroTexto.AutoSize = true;
            this.lblFiltroTexto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroTexto.Location = new System.Drawing.Point(11, 26);
            this.lblFiltroTexto.Name = "lblFiltroTexto";
            this.lblFiltroTexto.Size = new System.Drawing.Size(116, 20);
            this.lblFiltroTexto.TabIndex = 0;
            this.lblFiltroTexto.Text = "Código / Marca:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFiltro.Location = new System.Drawing.Point(131, 21);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(228, 29);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroMarca.Location = new System.Drawing.Point(377, 26);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(53, 20);
            this.lblFiltroMarca.TabIndex = 2;
            this.lblFiltroMarca.Text = "Marca:";
            // 
            // cboFiltroMarca
            // 
            this.cboFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroMarca.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboFiltroMarca.Location = new System.Drawing.Point(434, 21);
            this.cboFiltroMarca.Name = "cboFiltroMarca";
            this.cboFiltroMarca.Size = new System.Drawing.Size(194, 29);
            this.cboFiltroMarca.TabIndex = 3;
            // 
            // lblFiltroModelo
            // 
            this.lblFiltroModelo.AutoSize = true;
            this.lblFiltroModelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroModelo.Location = new System.Drawing.Point(646, 26);
            this.lblFiltroModelo.Name = "lblFiltroModelo";
            this.lblFiltroModelo.Size = new System.Drawing.Size(64, 20);
            this.lblFiltroModelo.TabIndex = 4;
            this.lblFiltroModelo.Text = "Modelo:";
            // 
            // cboFiltroModelo
            // 
            this.cboFiltroModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroModelo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboFiltroModelo.Location = new System.Drawing.Point(711, 21);
            this.cboFiltroModelo.Name = "cboFiltroModelo";
            this.cboFiltroModelo.Size = new System.Drawing.Size(194, 29);
            this.cboFiltroModelo.TabIndex = 5;
            // 
            // lblFiltroTipo
            // 
            this.lblFiltroTipo.AutoSize = true;
            this.lblFiltroTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroTipo.Location = new System.Drawing.Point(11, 62);
            this.lblFiltroTipo.Name = "lblFiltroTipo";
            this.lblFiltroTipo.Size = new System.Drawing.Size(42, 20);
            this.lblFiltroTipo.TabIndex = 6;
            this.lblFiltroTipo.Text = "Tipo:";
            // 
            // cboFiltroTipo
            // 
            this.cboFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboFiltroTipo.Location = new System.Drawing.Point(57, 58);
            this.cboFiltroTipo.Name = "cboFiltroTipo";
            this.cboFiltroTipo.Size = new System.Drawing.Size(228, 29);
            this.cboFiltroTipo.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(937, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 32);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(1074, 23);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(120, 32);
            this.btnLimpiarFiltro.TabIndex = 9;
            this.btnLimpiarFiltro.Text = "🔄 Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeight = 34;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvProductos.Location = new System.Drawing.Point(9, 119);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1206, 512);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // pnlBotonesList
            // 
            this.pnlBotonesList.Controls.Add(this.btnNuevo);
            this.pnlBotonesList.Controls.Add(this.btnEliminar);
            this.pnlBotonesList.Location = new System.Drawing.Point(9, 640);
            this.pnlBotonesList.Name = "pnlBotonesList";
            this.pnlBotonesList.Size = new System.Drawing.Size(1206, 53);
            this.pnlBotonesList.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(0, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(183, 38);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "➕ Nuevo Producto";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(200, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 38);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "🗑 Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tabDatos
            // 
            this.tabDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDatos.Controls.Add(this.grpGenerales);
            this.tabDatos.Controls.Add(this.grpDetalle);
            this.tabDatos.Controls.Add(this.grpMedia);
            this.tabDatos.Controls.Add(this.pnlBotonesDatos);
            this.tabDatos.Location = new System.Drawing.Point(4, 30);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Size = new System.Drawing.Size(1222, 734);
            this.tabDatos.TabIndex = 1;
            this.tabDatos.Text = "  📝  Datos del Producto  ";
            // 
            // grpGenerales
            // 
            this.grpGenerales.Controls.Add(this.textBox1);
            this.grpGenerales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpGenerales.Location = new System.Drawing.Point(9, 9);
            this.grpGenerales.Name = "grpGenerales";
            this.grpGenerales.Size = new System.Drawing.Size(1206, 192);
            this.grpGenerales.TabIndex = 0;
            this.grpGenerales.TabStop = false;
            this.grpGenerales.Text = "Información General";
            // 
            // grpDetalle
            // 
            this.grpDetalle.Controls.Add(this.lblCaract);
            this.grpDetalle.Controls.Add(this.txtCaracteristicas);
            this.grpDetalle.Controls.Add(this.lblExtras);
            this.grpDetalle.Controls.Add(this.txtExtras);
            this.grpDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetalle.Location = new System.Drawing.Point(9, 211);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(743, 277);
            this.grpDetalle.TabIndex = 1;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Características y Extras";
            // 
            // lblCaract
            // 
            this.lblCaract.AutoSize = true;
            this.lblCaract.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCaract.Location = new System.Drawing.Point(11, 23);
            this.lblCaract.Name = "lblCaract";
            this.lblCaract.Size = new System.Drawing.Size(164, 20);
            this.lblCaract.TabIndex = 0;
            this.lblCaract.Text = "Características técnicas:";
            // 
            // txtCaracteristicas
            // 
            this.txtCaracteristicas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCaracteristicas.Location = new System.Drawing.Point(11, 43);
            this.txtCaracteristicas.Name = "txtCaracteristicas";
            this.txtCaracteristicas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCaracteristicas.Size = new System.Drawing.Size(714, 96);
            this.txtCaracteristicas.TabIndex = 1;
            this.txtCaracteristicas.Text = "";
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExtras.Location = new System.Drawing.Point(11, 151);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(199, 20);
            this.lblExtras.TabIndex = 2;
            this.lblExtras.Text = "Extras / Accesorios incluidos:";
            // 
            // txtExtras
            // 
            this.txtExtras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExtras.Location = new System.Drawing.Point(11, 171);
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtExtras.Size = new System.Drawing.Size(714, 90);
            this.txtExtras.TabIndex = 3;
            this.txtExtras.Text = "";
            // 
            // grpMedia
            // 
            this.grpMedia.Controls.Add(this.picFoto);
            this.grpMedia.Controls.Add(this.btnCargarFoto);
            this.grpMedia.Controls.Add(this.btnQuitarFoto);
            this.grpMedia.Controls.Add(this.lblNombreDoc);
            this.grpMedia.Controls.Add(this.btnCargarDoc);
            this.grpMedia.Controls.Add(this.btnQuitarDoc);
            this.grpMedia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpMedia.Location = new System.Drawing.Point(766, 211);
            this.grpMedia.Name = "grpMedia";
            this.grpMedia.Size = new System.Drawing.Size(449, 277);
            this.grpMedia.TabIndex = 2;
            this.grpMedia.TabStop = false;
            this.grpMedia.Text = "Fotografía y Documento";
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.LightGray;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(11, 23);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(228, 160);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFoto.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnCargarFoto.ForeColor = System.Drawing.Color.White;
            this.btnCargarFoto.Location = new System.Drawing.Point(251, 23);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(183, 36);
            this.btnCargarFoto.TabIndex = 1;
            this.btnCargarFoto.Text = "📷 Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = false;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // btnQuitarFoto
            // 
            this.btnQuitarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnQuitarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarFoto.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnQuitarFoto.ForeColor = System.Drawing.Color.White;
            this.btnQuitarFoto.Location = new System.Drawing.Point(251, 66);
            this.btnQuitarFoto.Name = "btnQuitarFoto";
            this.btnQuitarFoto.Size = new System.Drawing.Size(183, 36);
            this.btnQuitarFoto.TabIndex = 2;
            this.btnQuitarFoto.Text = "❌ Quitar Foto";
            this.btnQuitarFoto.UseVisualStyleBackColor = false;
            this.btnQuitarFoto.Click += new System.EventHandler(this.btnQuitarFoto_Click);
            // 
            // lblNombreDoc
            // 
            this.lblNombreDoc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblNombreDoc.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombreDoc.Location = new System.Drawing.Point(11, 197);
            this.lblNombreDoc.Name = "lblNombreDoc";
            this.lblNombreDoc.Size = new System.Drawing.Size(423, 21);
            this.lblNombreDoc.TabIndex = 3;
            this.lblNombreDoc.Text = "(sin documento)";
            // 
            // btnCargarDoc
            // 
            this.btnCargarDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCargarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDoc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnCargarDoc.ForeColor = System.Drawing.Color.White;
            this.btnCargarDoc.Location = new System.Drawing.Point(11, 222);
            this.btnCargarDoc.Name = "btnCargarDoc";
            this.btnCargarDoc.Size = new System.Drawing.Size(217, 36);
            this.btnCargarDoc.TabIndex = 4;
            this.btnCargarDoc.Text = "📄 Cargar Doc (PDF/DOCX)";
            this.btnCargarDoc.UseVisualStyleBackColor = false;
            this.btnCargarDoc.Click += new System.EventHandler(this.btnCargarDoc_Click);
            // 
            // btnQuitarDoc
            // 
            this.btnQuitarDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnQuitarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarDoc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnQuitarDoc.ForeColor = System.Drawing.Color.White;
            this.btnQuitarDoc.Location = new System.Drawing.Point(240, 222);
            this.btnQuitarDoc.Name = "btnQuitarDoc";
            this.btnQuitarDoc.Size = new System.Drawing.Size(114, 36);
            this.btnQuitarDoc.TabIndex = 5;
            this.btnQuitarDoc.Text = "❌ Quitar";
            this.btnQuitarDoc.UseVisualStyleBackColor = false;
            this.btnQuitarDoc.Click += new System.EventHandler(this.btnQuitarDoc_Click);
            // 
            // pnlBotonesDatos
            // 
            this.pnlBotonesDatos.Controls.Add(this.btnGuardar);
            this.pnlBotonesDatos.Location = new System.Drawing.Point(9, 499);
            this.pnlBotonesDatos.Name = "pnlBotonesDatos";
            this.pnlBotonesDatos.Size = new System.Drawing.Size(1206, 53);
            this.pnlBotonesDatos.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(0, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(183, 38);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1188, 27);
            this.textBox1.TabIndex = 0;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1257, 864);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.tabProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JarasTech - Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabProducto.ResumeLayout(false);
            this.tabLista.ResumeLayout(false);
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlBotonesList.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.grpGenerales.ResumeLayout(false);
            this.grpGenerales.PerformLayout();
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            this.grpMedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.pnlBotonesDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Helpers para reducir repetición en el designer
        private void SetLabel(System.Windows.Forms.Label lbl, string text, int x, int y) { lbl.Text = text; lbl.Font = new System.Drawing.Font("Segoe UI", 9F); lbl.Location = new System.Drawing.Point(x, y); lbl.AutoSize = true; }
        private void SetText(System.Windows.Forms.TextBox txt, int x, int y, int w, int h, int max, bool upper) { txt.Font = new System.Drawing.Font("Segoe UI", 9.5F); txt.Location = new System.Drawing.Point(x, y); txt.Size = new System.Drawing.Size(w, h); txt.MaxLength = max; if (upper) txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper; }
        private void SetComboBox(System.Windows.Forms.ComboBox cbo, int x, int y, int w, int h) { cbo.Font = new System.Drawing.Font("Segoe UI", 9.5F); cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; cbo.Location = new System.Drawing.Point(x, y); cbo.Size = new System.Drawing.Size(w, h); }
        private void SetNumeric(System.Windows.Forms.NumericUpDown num, int x, int y, int w, int h, decimal min, decimal max, int dec) { num.Font = new System.Drawing.Font("Segoe UI", 9.5F); num.Location = new System.Drawing.Point(x, y); num.Size = new System.Drawing.Size(w, h); num.Minimum = min; num.Maximum = max; num.DecimalPlaces = dec; num.ThousandsSeparator = true; }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabProducto;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.Label lblFiltroTexto, lblFiltroMarca, lblFiltroModelo, lblFiltroTipo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboFiltroMarca, cboFiltroModelo, cboFiltroTipo;
        private System.Windows.Forms.Button btnBuscar, btnLimpiarFiltro;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel pnlBotonesList;
        private System.Windows.Forms.Button btnNuevo, btnEliminar;
        private System.Windows.Forms.TabPage tabDatos;
        private System.Windows.Forms.GroupBox grpGenerales;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.Label lblCaract, lblExtras;
        private System.Windows.Forms.RichTextBox txtCaracteristicas, txtExtras;
        private System.Windows.Forms.GroupBox grpMedia;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnCargarFoto, btnQuitarFoto, btnCargarDoc, btnQuitarDoc;
        private System.Windows.Forms.Label lblNombreDoc;
        private System.Windows.Forms.Panel pnlBotonesDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox1;
    }
}