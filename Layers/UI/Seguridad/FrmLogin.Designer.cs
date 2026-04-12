namespace JarasTech.Layers.UI.Seguridad
{
    partial class FrmLogin
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
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblSepLine = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlTxtUsuario = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.pnlTxtPass = new System.Windows.Forms.Panel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();

            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDerecho.SuspendLayout();
            this.pnlTxtUsuario.SuspendLayout();
            this.pnlTxtPass.SuspendLayout();
            this.SuspendLayout();

            // ── Panel izquierdo (dark brand panel) ───────────────────────
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(20, 20, 50);
            this.pnlIzquierdo.Controls.Add(this.picLogo);
            this.pnlIzquierdo.Controls.Add(this.lblMarca);
            this.pnlIzquierdo.Controls.Add(this.lblSlogan);
            this.pnlIzquierdo.Controls.Add(this.lblVersion);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(280, 500);
            this.pnlIzquierdo.TabIndex = 0;

            // Logo
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::JarasTech.Properties.Resources.Logo_JarasTech;
            this.picLogo.Location = new System.Drawing.Point(75, 60);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(130, 130);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;

            // Marca
            this.lblMarca.AutoSize = false;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(0, 210);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(280, 40);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "JarasTech";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Slogan
            this.lblSlogan.AutoSize = false;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(150, 180, 220);
            this.lblSlogan.Location = new System.Drawing.Point(0, 258);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(280, 40);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Venta de Dispositivos Electrónicos";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Línea decorativa
            this.lblSepLine.AutoSize = false;
            this.lblSepLine.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblSepLine.Location = new System.Drawing.Point(90, 308);
            this.lblSepLine.Name = "lblSepLine";
            this.lblSepLine.Size = new System.Drawing.Size(100, 3);
            this.lblSepLine.TabIndex = 99;
            this.pnlIzquierdo.Controls.Add(this.lblSepLine);

            // Versión
            this.lblVersion.AutoSize = false;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(100, 130, 160);
            this.lblVersion.Location = new System.Drawing.Point(0, 450);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(280, 20);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "v1.0  —  ISW-411  UTN";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Panel derecho (formulario) ───────────────────────────────
            this.pnlDerecho.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlDerecho.Controls.Add(this.lblTitulo);
            this.pnlDerecho.Controls.Add(this.lblSubtitulo);
            this.pnlDerecho.Controls.Add(this.lblUsuario);
            this.pnlDerecho.Controls.Add(this.pnlTxtUsuario);
            this.pnlDerecho.Controls.Add(this.lblContrasena);
            this.pnlDerecho.Controls.Add(this.pnlTxtPass);
            this.pnlDerecho.Controls.Add(this.btnAceptar);
            this.pnlDerecho.Controls.Add(this.btnCancelar);
            this.pnlDerecho.Controls.Add(this.lblCopyright);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.pnlDerecho.TabIndex = 1;

            // Título
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(20, 20, 50);
            this.lblTitulo.Location = new System.Drawing.Point(40, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(310, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Iniciar Sesión";

            // Subtítulo
            this.lblSubtitulo.AutoSize = false;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 113);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(310, 22);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Ingrese sus credenciales para continuar";

            // Label usuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblUsuario.Location = new System.Drawing.Point(40, 160);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "USUARIO";

            // Panel textbox usuario (da el border estilo card)
            this.pnlTxtUsuario.BackColor = System.Drawing.Color.White;
            this.pnlTxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTxtUsuario.Controls.Add(this.txtUsuario);
            this.pnlTxtUsuario.Location = new System.Drawing.Point(40, 183);
            this.pnlTxtUsuario.Name = "pnlTxtUsuario";
            this.pnlTxtUsuario.Size = new System.Drawing.Size(310, 38);
            this.pnlTxtUsuario.TabIndex = 3;

            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "admin";

            // Label contraseña
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblContrasena.Location = new System.Drawing.Point(40, 238);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(98, 20);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "CONTRASEÑA";

            // Panel textbox contraseña
            this.pnlTxtPass.BackColor = System.Drawing.Color.White;
            this.pnlTxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTxtPass.Controls.Add(this.txtContrasena);
            this.pnlTxtPass.Location = new System.Drawing.Point(40, 261);
            this.pnlTxtPass.Name = "pnlTxtPass";
            this.pnlTxtPass.Size = new System.Drawing.Size(310, 38);
            this.pnlTxtPass.TabIndex = 5;

            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.Text = "admin123";
            this.txtContrasena.UseSystemPasswordChar = true;

            // Botón Ingresar
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(40, 325);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(310, 44);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "INGRESAR  →";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);

            // Botón Cancelar (discreto)
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 210, 220);
            this.btnCancelar.FlatAppearance.BorderSize = 1;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
            this.btnCancelar.Location = new System.Drawing.Point(40, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(310, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Salir del sistema";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // Copyright
            this.lblCopyright.AutoSize = false;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(180, 190, 200);
            this.lblCopyright.Location = new System.Drawing.Point(40, 462);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(310, 18);
            this.lblCopyright.TabIndex = 8;
            this.lblCopyright.Text = "© 2026 JarasTech  —  ISW-411 UTN";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── FrmLogin ─────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(670, 500);
            this.Controls.Add(this.pnlDerecho);
            this.Controls.Add(this.pnlIzquierdo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JarasTech — Acceso";

            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDerecho.ResumeLayout(false);
            this.pnlDerecho.PerformLayout();
            this.pnlTxtUsuario.ResumeLayout(false);
            this.pnlTxtUsuario.PerformLayout();
            this.pnlTxtPass.ResumeLayout(false);
            this.pnlTxtPass.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblSepLine;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlTxtUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Panel pnlTxtPass;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCopyright;
    }
}