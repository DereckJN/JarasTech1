namespace JarasTech
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitulo = new System.Windows.Forms.Label();
            this.lblHeaderSubtitulo = new System.Windows.Forms.Label();
            this.lblHeaderUsuario = new System.Windows.Forms.Label();
            this.lblHeaderPerfil = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.picSideLogo = new System.Windows.Forms.PictureBox();
            this.lblSideSep = new System.Windows.Forms.Label();
            this.pnlSecMantenimientos = new System.Windows.Forms.Panel();
            this.lblSecMant = new System.Windows.Forms.Label();
            this.btnSideClientes = new System.Windows.Forms.Button();
            this.btnSideIVA = new System.Windows.Forms.Button();
            this.btnSideMarcas = new System.Windows.Forms.Button();
            this.btnSideModelos = new System.Windows.Forms.Button();
            this.btnSideProductos = new System.Windows.Forms.Button();
            this.btnSideTipos = new System.Windows.Forms.Button();
            this.btnSideStock = new System.Windows.Forms.Button();
            this.pnlSecProcesos = new System.Windows.Forms.Panel();
            this.lblSecProc = new System.Windows.Forms.Label();
            this.btnSideFacturacion = new System.Windows.Forms.Button();
            this.pnlSecReportes = new System.Windows.Forms.Panel();
            this.lblSecRep = new System.Windows.Forms.Label();
            this.btnSideReportes = new System.Windows.Forms.Button();
            this.pnlSecSeguridad = new System.Windows.Forms.Panel();
            this.lblSecSeg = new System.Windows.Forms.Label();
            this.btnSideUsuarios = new System.Windows.Forms.Button();
            this.lblSideSep2 = new System.Windows.Forms.Label();
            this.btnSideAcercaDe = new System.Windows.Forms.Button();
            this.btnSideSalir = new System.Windows.Forms.Button();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSideLogo)).BeginInit();
            this.pnlSecMantenimientos.SuspendLayout();
            this.pnlSecProcesos.SuspendLayout();
            this.pnlSecReportes.SuspendLayout();
            this.pnlSecSeguridad.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.pnlHeader.Controls.Add(this.lblHeaderTitulo);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitulo);
            this.pnlHeader.Controls.Add(this.lblHeaderUsuario);
            this.pnlHeader.Controls.Add(this.lblHeaderPerfil);
            this.pnlHeader.Controls.Add(this.lblFecha);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(215, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1163, 62);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitulo
            // 
            this.lblHeaderTitulo.AutoSize = true;
            this.lblHeaderTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitulo.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitulo.Location = new System.Drawing.Point(6, 7);
            this.lblHeaderTitulo.Name = "lblHeaderTitulo";
            this.lblHeaderTitulo.Size = new System.Drawing.Size(127, 35);
            this.lblHeaderTitulo.TabIndex = 1;
            this.lblHeaderTitulo.Text = "JarasTech";
            // 
            // lblHeaderSubtitulo
            // 
            this.lblHeaderSubtitulo.AutoSize = true;
            this.lblHeaderSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblHeaderSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.lblHeaderSubtitulo.Location = new System.Drawing.Point(8, 39);
            this.lblHeaderSubtitulo.Name = "lblHeaderSubtitulo";
            this.lblHeaderSubtitulo.Size = new System.Drawing.Size(299, 20);
            this.lblHeaderSubtitulo.TabIndex = 2;
            this.lblHeaderSubtitulo.Text = "Sistema de Venta de Dispositivos Electrónicos";
            // 
            // lblHeaderUsuario
            // 
            this.lblHeaderUsuario.AutoSize = true;
            this.lblHeaderUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHeaderUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblHeaderUsuario.Location = new System.Drawing.Point(870, 14);
            this.lblHeaderUsuario.Name = "lblHeaderUsuario";
            this.lblHeaderUsuario.Size = new System.Drawing.Size(57, 20);
            this.lblHeaderUsuario.TabIndex = 3;
            this.lblHeaderUsuario.Text = "👤  ---";
            // 
            // lblHeaderPerfil
            // 
            this.lblHeaderPerfil.AutoSize = true;
            this.lblHeaderPerfil.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblHeaderPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblHeaderPerfil.Location = new System.Drawing.Point(870, 38);
            this.lblHeaderPerfil.Name = "lblHeaderPerfil";
            this.lblHeaderPerfil.Size = new System.Drawing.Size(27, 19);
            this.lblHeaderPerfil.TabIndex = 4;
            this.lblHeaderPerfil.Text = "---";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(185)))));
            this.lblFecha.Location = new System.Drawing.Point(1010, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(133, 20);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "🕐  --/--/----  --:--";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoScroll = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.pnlSidebar.Controls.Add(this.picSideLogo);
            this.pnlSidebar.Controls.Add(this.lblSideSep);
            this.pnlSidebar.Controls.Add(this.pnlSecMantenimientos);
            this.pnlSidebar.Controls.Add(this.pnlSecProcesos);
            this.pnlSidebar.Controls.Add(this.pnlSecReportes);
            this.pnlSidebar.Controls.Add(this.pnlSecSeguridad);
            this.pnlSidebar.Controls.Add(this.lblSideSep2);
            this.pnlSidebar.Controls.Add(this.btnSideAcercaDe);
            this.pnlSidebar.Controls.Add(this.btnSideSalir);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(215, 686);
            this.pnlSidebar.TabIndex = 1;
            // 
            // picSideLogo
            // 
            this.picSideLogo.BackColor = System.Drawing.Color.Transparent;
            this.picSideLogo.Image = global::JarasTech.Properties.Resources.Logo_JarasTech;
            this.picSideLogo.Location = new System.Drawing.Point(19, 14);
            this.picSideLogo.Name = "picSideLogo";
            this.picSideLogo.Size = new System.Drawing.Size(160, 99);
            this.picSideLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSideLogo.TabIndex = 0;
            this.picSideLogo.TabStop = false;
            // 
            // lblSideSep
            // 
            this.lblSideSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblSideSep.Location = new System.Drawing.Point(15, 127);
            this.lblSideSep.Name = "lblSideSep";
            this.lblSideSep.Size = new System.Drawing.Size(185, 2);
            this.lblSideSep.TabIndex = 98;
            // 
            // pnlSecMantenimientos
            // 
            this.pnlSecMantenimientos.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecMantenimientos.Controls.Add(this.lblSecMant);
            this.pnlSecMantenimientos.Controls.Add(this.btnSideClientes);
            this.pnlSecMantenimientos.Controls.Add(this.btnSideIVA);
            this.pnlSecMantenimientos.Controls.Add(this.btnSideMarcas);
            this.pnlSecMantenimientos.Controls.Add(this.btnSideModelos);
            this.pnlSecMantenimientos.Controls.Add(this.btnSideProductos);
            this.pnlSecMantenimientos.Controls.Add(this.btnSideTipos);
            this.pnlSecMantenimientos.Controls.Add(this.btnSideStock);
            this.pnlSecMantenimientos.Location = new System.Drawing.Point(0, 134);
            this.pnlSecMantenimientos.Name = "pnlSecMantenimientos";
            this.pnlSecMantenimientos.Size = new System.Drawing.Size(215, 254);
            this.pnlSecMantenimientos.TabIndex = 10;
            // 
            // lblSecMant
            // 
            this.lblSecMant.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblSecMant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.lblSecMant.Location = new System.Drawing.Point(12, 6);
            this.lblSecMant.Name = "lblSecMant";
            this.lblSecMant.Size = new System.Drawing.Size(191, 16);
            this.lblSecMant.TabIndex = 0;
            this.lblSecMant.Text = "MANTENIMIENTOS";
            // 
            // btnSideClientes
            // 
            this.btnSideClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnSideClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideClientes.FlatAppearance.BorderSize = 0;
            this.btnSideClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(185)))));
            this.btnSideClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideClientes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSideClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.btnSideClientes.Location = new System.Drawing.Point(0, 26);
            this.btnSideClientes.Name = "btnSideClientes";
            this.btnSideClientes.Size = new System.Drawing.Size(215, 32);
            this.btnSideClientes.TabIndex = 1;
            this.btnSideClientes.Text = "  👥  Clientes";
            this.btnSideClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideClientes.UseVisualStyleBackColor = false;
            this.btnSideClientes.Click += new System.EventHandler(this.btnSideClientes_Click);
            // 
            // btnSideIVA
            // 
            this.btnSideIVA.BackColor = System.Drawing.Color.Transparent;
            this.btnSideIVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideIVA.FlatAppearance.BorderSize = 0;
            this.btnSideIVA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(185)))));
            this.btnSideIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideIVA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSideIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.btnSideIVA.Location = new System.Drawing.Point(0, 58);
            this.btnSideIVA.Name = "btnSideIVA";
            this.btnSideIVA.Size = new System.Drawing.Size(215, 32);
            this.btnSideIVA.TabIndex = 2;
            this.btnSideIVA.Text = "  💲  IVA";
            this.btnSideIVA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideIVA.UseVisualStyleBackColor = false;
            this.btnSideIVA.Click += new System.EventHandler(this.btnSideIVA_Click);
            // 
            // btnSideMarcas
            // 
            this.btnSideMarcas.BackColor = System.Drawing.Color.Transparent;
            this.btnSideMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideMarcas.FlatAppearance.BorderSize = 0;
            this.btnSideMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(185)))));
            this.btnSideMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideMarcas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSideMarcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.btnSideMarcas.Location = new System.Drawing.Point(0, 90);
            this.btnSideMarcas.Name = "btnSideMarcas";
            this.btnSideMarcas.Size = new System.Drawing.Size(215, 32);
            this.btnSideMarcas.TabIndex = 3;
            this.btnSideMarcas.Text = "  🏷  Marcas";
            this.btnSideMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideMarcas.UseVisualStyleBackColor = false;
            this.btnSideMarcas.Click += new System.EventHandler(this.btnSideMarcas_Click);
            // 
            // btnSideModelos
            // 
            this.btnSideModelos.BackColor = System.Drawing.Color.Transparent;
            this.btnSideModelos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideModelos.FlatAppearance.BorderSize = 0;
            this.btnSideModelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(185)))));
            this.btnSideModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideModelos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSideModelos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.btnSideModelos.Location = new System.Drawing.Point(0, 122);
            this.btnSideModelos.Name = "btnSideModelos";
            this.btnSideModelos.Size = new System.Drawing.Size(215, 32);
            this.btnSideModelos.TabIndex = 4;
            this.btnSideModelos.Text = "  📱  Modelos";
            this.btnSideModelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideModelos.UseVisualStyleBackColor = false;
            this.btnSideModelos.Click += new System.EventHandler(this.btnSideModelos_Click);
            // 
            // btnSideProductos
            // 
            this.btnSideProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnSideProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideProductos.FlatAppearance.BorderSize = 0;
            this.btnSideProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(185)))));
            this.btnSideProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideProductos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSideProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.btnSideProductos.Location = new System.Drawing.Point(0, 154);
            this.btnSideProductos.Name = "btnSideProductos";
            this.btnSideProductos.Size = new System.Drawing.Size(215, 32);
            this.btnSideProductos.TabIndex = 5;
            this.btnSideProductos.Text = "  📦  Productos";
            this.btnSideProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideProductos.UseVisualStyleBackColor = false;
            this.btnSideProductos.Click += new System.EventHandler(this.btnSideProductos_Click);
            // 
            // btnSideTipos
            // 
            this.btnSideTipos.BackColor = System.Drawing.Color.Transparent;
            this.btnSideTipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideTipos.FlatAppearance.BorderSize = 0;
            this.btnSideTipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(185)))));
            this.btnSideTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideTipos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSideTipos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.btnSideTipos.Location = new System.Drawing.Point(0, 186);
            this.btnSideTipos.Name = "btnSideTipos";
            this.btnSideTipos.Size = new System.Drawing.Size(215, 32);
            this.btnSideTipos.TabIndex = 6;
            this.btnSideTipos.Text = "  🗂  Tipo Dispositivo";
            this.btnSideTipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideTipos.UseVisualStyleBackColor = false;
            this.btnSideTipos.Click += new System.EventHandler(this.btnSideTipos_Click);
            // 
            // btnSideStock
            // 
            this.btnSideStock.BackColor = System.Drawing.Color.Transparent;
            this.btnSideStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideStock.FlatAppearance.BorderSize = 0;
            this.btnSideStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(185)))));
            this.btnSideStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideStock.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSideStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.btnSideStock.Location = new System.Drawing.Point(0, 218);
            this.btnSideStock.Name = "btnSideStock";
            this.btnSideStock.Size = new System.Drawing.Size(215, 32);
            this.btnSideStock.TabIndex = 7;
            this.btnSideStock.Text = "  📊  Stock / Inventario";
            this.btnSideStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideStock.UseVisualStyleBackColor = false;
            this.btnSideStock.Click += new System.EventHandler(this.btnSideStock_Click);
            // 
            // pnlSecProcesos
            // 
            this.pnlSecProcesos.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecProcesos.Controls.Add(this.lblSecProc);
            this.pnlSecProcesos.Controls.Add(this.btnSideFacturacion);
            this.pnlSecProcesos.Location = new System.Drawing.Point(0, 394);
            this.pnlSecProcesos.Name = "pnlSecProcesos";
            this.pnlSecProcesos.Size = new System.Drawing.Size(215, 60);
            this.pnlSecProcesos.TabIndex = 11;
            // 
            // lblSecProc
            // 
            this.lblSecProc.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblSecProc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.lblSecProc.Location = new System.Drawing.Point(12, 6);
            this.lblSecProc.Name = "lblSecProc";
            this.lblSecProc.Size = new System.Drawing.Size(191, 16);
            this.lblSecProc.TabIndex = 0;
            this.lblSecProc.Text = "PROCESOS";
            // 
            // btnSideFacturacion
            // 
            this.btnSideFacturacion.BackColor = System.Drawing.Color.Transparent;
            this.btnSideFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideFacturacion.FlatAppearance.BorderSize = 0;
            this.btnSideFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(185)))));
            this.btnSideFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideFacturacion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSideFacturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.btnSideFacturacion.Location = new System.Drawing.Point(0, 26);
            this.btnSideFacturacion.Name = "btnSideFacturacion";
            this.btnSideFacturacion.Size = new System.Drawing.Size(215, 32);
            this.btnSideFacturacion.TabIndex = 1;
            this.btnSideFacturacion.Text = "  🧾  Facturación";
            this.btnSideFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideFacturacion.UseVisualStyleBackColor = false;
            this.btnSideFacturacion.Click += new System.EventHandler(this.btnSideFacturacion_Click);
            // 
            // pnlSecReportes
            // 
            this.pnlSecReportes.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecReportes.Controls.Add(this.lblSecRep);
            this.pnlSecReportes.Controls.Add(this.btnSideReportes);
            this.pnlSecReportes.Location = new System.Drawing.Point(0, 458);
            this.pnlSecReportes.Name = "pnlSecReportes";
            this.pnlSecReportes.Size = new System.Drawing.Size(215, 60);
            this.pnlSecReportes.TabIndex = 12;
            // 
            // lblSecRep
            // 
            this.lblSecRep.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblSecRep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.lblSecRep.Location = new System.Drawing.Point(12, 6);
            this.lblSecRep.Name = "lblSecRep";
            this.lblSecRep.Size = new System.Drawing.Size(191, 16);
            this.lblSecRep.TabIndex = 0;
            this.lblSecRep.Text = "REPORTES";
            // 
            // btnSideReportes
            // 
            this.btnSideReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnSideReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideReportes.FlatAppearance.BorderSize = 0;
            this.btnSideReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(185)))));
            this.btnSideReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideReportes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSideReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.btnSideReportes.Location = new System.Drawing.Point(0, 26);
            this.btnSideReportes.Name = "btnSideReportes";
            this.btnSideReportes.Size = new System.Drawing.Size(215, 32);
            this.btnSideReportes.TabIndex = 1;
            this.btnSideReportes.Text = "  📈  Ver Reportes";
            this.btnSideReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideReportes.UseVisualStyleBackColor = false;
            this.btnSideReportes.Click += new System.EventHandler(this.btnSideReportes_Click);
            // 
            // pnlSecSeguridad
            // 
            this.pnlSecSeguridad.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecSeguridad.Controls.Add(this.lblSecSeg);
            this.pnlSecSeguridad.Controls.Add(this.btnSideUsuarios);
            this.pnlSecSeguridad.Location = new System.Drawing.Point(0, 522);
            this.pnlSecSeguridad.Name = "pnlSecSeguridad";
            this.pnlSecSeguridad.Size = new System.Drawing.Size(215, 60);
            this.pnlSecSeguridad.TabIndex = 13;
            // 
            // lblSecSeg
            // 
            this.lblSecSeg.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblSecSeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.lblSecSeg.Location = new System.Drawing.Point(12, 6);
            this.lblSecSeg.Name = "lblSecSeg";
            this.lblSecSeg.Size = new System.Drawing.Size(191, 16);
            this.lblSecSeg.TabIndex = 0;
            this.lblSecSeg.Text = "SEGURIDAD";
            // 
            // btnSideUsuarios
            // 
            this.btnSideUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnSideUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideUsuarios.FlatAppearance.BorderSize = 0;
            this.btnSideUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(185)))));
            this.btnSideUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSideUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.btnSideUsuarios.Location = new System.Drawing.Point(0, 26);
            this.btnSideUsuarios.Name = "btnSideUsuarios";
            this.btnSideUsuarios.Size = new System.Drawing.Size(215, 32);
            this.btnSideUsuarios.TabIndex = 1;
            this.btnSideUsuarios.Text = "  👤  Usuarios";
            this.btnSideUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideUsuarios.UseVisualStyleBackColor = false;
            this.btnSideUsuarios.Click += new System.EventHandler(this.btnSideUsuarios_Click);
            // 
            // lblSideSep2
            // 
            this.lblSideSep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
            this.lblSideSep2.Location = new System.Drawing.Point(0, 590);
            this.lblSideSep2.Name = "lblSideSep2";
            this.lblSideSep2.Size = new System.Drawing.Size(215, 2);
            this.lblSideSep2.TabIndex = 97;
            // 
            // btnSideAcercaDe
            // 
            this.btnSideAcercaDe.BackColor = System.Drawing.Color.Transparent;
            this.btnSideAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnSideAcercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
            this.btnSideAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideAcercaDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSideAcercaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(165)))), ((int)(((byte)(185)))));
            this.btnSideAcercaDe.Location = new System.Drawing.Point(0, 596);
            this.btnSideAcercaDe.Name = "btnSideAcercaDe";
            this.btnSideAcercaDe.Size = new System.Drawing.Size(215, 32);
            this.btnSideAcercaDe.TabIndex = 19;
            this.btnSideAcercaDe.Text = "  ℹ  Acerca de...";
            this.btnSideAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideAcercaDe.UseVisualStyleBackColor = false;
            this.btnSideAcercaDe.Click += new System.EventHandler(this.btnSideAcercaDe_Click);
            // 
            // btnSideSalir
            // 
            this.btnSideSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSideSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideSalir.FlatAppearance.BorderSize = 0;
            this.btnSideSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSideSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSideSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSideSalir.Location = new System.Drawing.Point(0, 628);
            this.btnSideSalir.Name = "btnSideSalir";
            this.btnSideSalir.Size = new System.Drawing.Size(215, 36);
            this.btnSideSalir.TabIndex = 20;
            this.btnSideSalir.Text = "  🔓  Cerrar Sesión";
            this.btnSideSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideSalir.UseVisualStyleBackColor = false;
            this.btnSideSalir.Click += new System.EventHandler(this.btnSideSalir_Click);
            // 
            // timerReloj
            // 
            this.timerReloj.Enabled = true;
            this.timerReloj.Interval = 30000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.BackgroundImage = global::JarasTech.Properties.Resources.Logo_JarasTech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1378, 686);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 520);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JarasTech — Sistema de Venta de Dispositivos Electrónicos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSideLogo)).EndInit();
            this.pnlSecMantenimientos.ResumeLayout(false);
            this.pnlSecProcesos.ResumeLayout(false);
            this.pnlSecReportes.ResumeLayout(false);
            this.pnlSecSeguridad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitulo;
        private System.Windows.Forms.Label lblHeaderSubtitulo;
        private System.Windows.Forms.Label lblHeaderUsuario;
        private System.Windows.Forms.Label lblHeaderPerfil;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox picSideLogo;
        private System.Windows.Forms.Label lblSideSep;
        private System.Windows.Forms.Panel pnlSecMantenimientos;
        private System.Windows.Forms.Label lblSecMant;
        private System.Windows.Forms.Button btnSideClientes;
        private System.Windows.Forms.Button btnSideIVA;
        private System.Windows.Forms.Button btnSideMarcas;
        private System.Windows.Forms.Button btnSideModelos;
        private System.Windows.Forms.Button btnSideProductos;
        private System.Windows.Forms.Button btnSideTipos;
        private System.Windows.Forms.Button btnSideStock;
        private System.Windows.Forms.Panel pnlSecProcesos;
        private System.Windows.Forms.Label lblSecProc;
        private System.Windows.Forms.Button btnSideFacturacion;
        private System.Windows.Forms.Panel pnlSecReportes;
        private System.Windows.Forms.Label lblSecRep;
        private System.Windows.Forms.Button btnSideReportes;
        private System.Windows.Forms.Panel pnlSecSeguridad;
        private System.Windows.Forms.Label lblSecSeg;
        private System.Windows.Forms.Button btnSideUsuarios;
        private System.Windows.Forms.Label lblSideSep2;
        private System.Windows.Forms.Button btnSideAcercaDe;
        private System.Windows.Forms.Button btnSideSalir;
        private System.Windows.Forms.Timer timerReloj;
    }
}