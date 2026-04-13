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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioLogueado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparador = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPerfil = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.formularioReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(825, 27);
            this.menuStrip1.TabIndex = 0;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cerrarSesionToolStripMenuItem.Text = "🔓  Cerrar Sesión";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cerrarToolStripMenuItem.Text = "✖  Salir";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoClientesToolStripMenuItem,
            this.iVAToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.modelosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.tipoDeDToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(121, 21);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mantenimientoClientesToolStripMenuItem
            // 
            this.mantenimientoClientesToolStripMenuItem.Name = "mantenimientoClientesToolStripMenuItem";
            this.mantenimientoClientesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.mantenimientoClientesToolStripMenuItem.Text = "👥  Clientes";
            this.mantenimientoClientesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoClientesToolStripMenuItem_Click);
            // 
            // iVAToolStripMenuItem
            // 
            this.iVAToolStripMenuItem.Name = "iVAToolStripMenuItem";
            this.iVAToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.iVAToolStripMenuItem.Text = "💲  IVA";
            this.iVAToolStripMenuItem.Click += new System.EventHandler(this.iVAToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.marcasToolStripMenuItem.Text = "🏷  Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.modelosToolStripMenuItem.Text = "📱  Modelos";
            this.modelosToolStripMenuItem.Click += new System.EventHandler(this.modelosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.productosToolStripMenuItem.Text = "📦  Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // tipoDeDToolStripMenuItem
            // 
            this.tipoDeDToolStripMenuItem.Name = "tipoDeDToolStripMenuItem";
            this.tipoDeDToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.tipoDeDToolStripMenuItem.Text = "🗂  Tipo de Dispositivo";
            this.tipoDeDToolStripMenuItem.Click += new System.EventHandler(this.tipoDeDToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.stockToolStripMenuItem.Text = "📊  Stock / Inventario";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem});
            this.procesosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.facturacionToolStripMenuItem.Text = "🧾  Facturación";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.seguridadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "👤  Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioReportesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.ForeColor = System.Drawing.Color.White;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioLogueado,
            this.lblSeparador,
            this.lblPerfil,
            this.lblSpring,
            this.lblFecha});
            this.statusStrip.Location = new System.Drawing.Point(0, 425);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(825, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioLogueado.ForeColor = System.Drawing.Color.LightCyan;
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(47, 17);
            this.lblUsuarioLogueado.Text = "  👤  ---";
            // 
            // lblSeparador
            // 
            this.lblSeparador.ForeColor = System.Drawing.Color.Gray;
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(22, 17);
            this.lblSeparador.Text = "  |  ";
            // 
            // lblPerfil
            // 
            this.lblPerfil.ForeColor = System.Drawing.Color.LightYellow;
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(46, 17);
            this.lblPerfil.Text = "  🔑  ---";
            // 
            // lblSpring
            // 
            this.lblSpring.Name = "lblSpring";
            this.lblSpring.Size = new System.Drawing.Size(577, 17);
            this.lblSpring.Spring = true;
            // 
            // lblFecha
            // 
            this.lblFecha.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblFecha.ForeColor = System.Drawing.Color.LightGray;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(122, 17);
            this.lblFecha.Text = "  🕐  13/04/2026  11:25";
            // 
            // timerReloj
            // 
            this.timerReloj.Enabled = true;
            this.timerReloj.Interval = 30000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // formularioReportesToolStripMenuItem
            // 
            this.formularioReportesToolStripMenuItem.Name = "formularioReportesToolStripMenuItem";
            this.formularioReportesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.formularioReportesToolStripMenuItem.Text = "Formulario Reportes";
            this.formularioReportesToolStripMenuItem.Click += new System.EventHandler(this.formularioReportesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JarasTech.Properties.Resources.Logo_JarasTech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 447);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(679, 414);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JarasTech — Sistema de Venta de Dispositivos Electrónicos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // ── Renderer personalizado para menú oscuro ──────────────────────
        private class DarkMenuRenderer : System.Windows.Forms.ToolStripProfessionalRenderer
        {
            public DarkMenuRenderer()
                : base(new DarkColorTable()) { }
        }

        private class DarkColorTable : System.Windows.Forms.ProfessionalColorTable
        {
            public override System.Drawing.Color MenuItemSelected =>
                System.Drawing.Color.FromArgb(0, 120, 215);
            public override System.Drawing.Color MenuItemBorder =>
                System.Drawing.Color.FromArgb(0, 120, 215);
            public override System.Drawing.Color MenuBorder =>
                System.Drawing.Color.FromArgb(30, 30, 60);
            public override System.Drawing.Color ToolStripDropDownBackground =>
                System.Drawing.Color.FromArgb(40, 40, 75);
            public override System.Drawing.Color ImageMarginGradientBegin =>
                System.Drawing.Color.FromArgb(30, 30, 60);
            public override System.Drawing.Color ImageMarginGradientMiddle =>
                System.Drawing.Color.FromArgb(30, 30, 60);
            public override System.Drawing.Color ImageMarginGradientEnd =>
                System.Drawing.Color.FromArgb(30, 30, 60);
            public override System.Drawing.Color MenuItemSelectedGradientBegin =>
                System.Drawing.Color.FromArgb(0, 120, 215);
            public override System.Drawing.Color MenuItemSelectedGradientEnd =>
                System.Drawing.Color.FromArgb(0, 100, 190);
            public override System.Drawing.Color MenuItemPressedGradientBegin =>
                System.Drawing.Color.FromArgb(0, 100, 190);
            public override System.Drawing.Color MenuItemPressedGradientEnd =>
                System.Drawing.Color.FromArgb(0, 80, 160);
        }

        private void timerReloj_Tick(object sender, System.EventArgs e)
        {
            lblFecha.Text = "  🕐  " + System.DateTime.Now.ToString("dd/MM/yyyy  HH:mm");
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioLogueado;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparador;
        private System.Windows.Forms.ToolStripStatusLabel lblPerfil;
        private System.Windows.Forms.ToolStripStatusLabel lblSpring;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioReportesToolStripMenuItem;
    }
}