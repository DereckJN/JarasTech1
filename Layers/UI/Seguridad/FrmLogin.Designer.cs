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
            this.lblSepLine = new System.Windows.Forms.Label();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
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
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.pnlIzquierdo.Controls.Add(this.picLogo);
            this.pnlIzquierdo.Controls.Add(this.lblMarca);
            this.pnlIzquierdo.Controls.Add(this.lblSlogan);
            this.pnlIzquierdo.Controls.Add(this.lblVersion);
            this.pnlIzquierdo.Controls.Add(this.lblSepLine);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(280, 500);
            this.pnlIzquierdo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::JarasTech.Properties.Resources.Logo_JarasTech;
            this.picLogo.Location = new System.Drawing.Point(75, 60);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(130, 130);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(0, 210);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(280, 40);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "JarasTech";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSlogan
            // 
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.lblSlogan.Location = new System.Drawing.Point(0, 258);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(280, 40);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Venta de Dispositivos Electrónicos";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(130)))), ((int)(((byte)(160)))));
            this.lblVersion.Location = new System.Drawing.Point(0, 450);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(280, 20);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "v1.0  —  ISW-411  UTN";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSepLine
            // 
            this.lblSepLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblSepLine.Location = new System.Drawing.Point(90, 308);
            this.lblSepLine.Name = "lblSepLine";
            this.lblSepLine.Size = new System.Drawing.Size(100, 3);
            this.lblSepLine.TabIndex = 99;
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
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
            this.pnlDerecho.Location = new System.Drawing.Point(280, 0);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.pnlDerecho.Size = new System.Drawing.Size(390, 500);
            this.pnlDerecho.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.lblTitulo.Location = new System.Drawing.Point(40, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(310, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Iniciar Sesión";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 113);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(310, 22);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Ingrese sus credenciales para continuar";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblUsuario.Location = new System.Drawing.Point(40, 160);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "USUARIO";
            // 
            // pnlTxtUsuario
            // 
            this.pnlTxtUsuario.BackColor = System.Drawing.Color.White;
            this.pnlTxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTxtUsuario.Controls.Add(this.txtUsuario);
            this.pnlTxtUsuario.Location = new System.Drawing.Point(40, 183);
            this.pnlTxtUsuario.Name = "pnlTxtUsuario";
            this.pnlTxtUsuario.Size = new System.Drawing.Size(310, 38);
            this.pnlTxtUsuario.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txtUsuario.Location = new System.Drawing.Point(0, 0);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(308, 25);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "admin";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblContrasena.Location = new System.Drawing.Point(40, 238);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(110, 20);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "CONTRASEÑA";
            // 
            // pnlTxtPass
            // 
            this.pnlTxtPass.BackColor = System.Drawing.Color.White;
            this.pnlTxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTxtPass.Controls.Add(this.txtContrasena);
            this.pnlTxtPass.Location = new System.Drawing.Point(40, 261);
            this.pnlTxtPass.Name = "pnlTxtPass";
            this.pnlTxtPass.Size = new System.Drawing.Size(310, 38);
            this.pnlTxtPass.TabIndex = 5;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txtContrasena.Location = new System.Drawing.Point(0, 0);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(308, 25);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.Text = "admin123";
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.btnCancelar.Location = new System.Drawing.Point(40, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(310, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Salir del sistema";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblCopyright.Location = new System.Drawing.Point(40, 462);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(310, 18);
            this.lblCopyright.TabIndex = 8;
            this.lblCopyright.Text = "© 2026 JarasTech  —  ISW-411 UTN";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
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