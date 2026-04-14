namespace JarasTech.Layers.UI.Seguridad
{
    partial class FrmAcercaDe
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
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblProductoLbl = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.lblVersionLbl = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.lblCopyrightLbl = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.lblCompanyLbl = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.lblDescLbl = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();

            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();

            // ── pnlLogo (panel izquierdo oscuro) ────────────────────────
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(20, 20, 50);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Controls.Add(this.lblAppName);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 460);
            this.pnlLogo.TabIndex = 0;

            // picLogo
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::JarasTech.Properties.Resources.Logo_JarasTech;
            this.picLogo.Location = new System.Drawing.Point(35, 60);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(130, 130);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;

            // lblAppName
            this.lblAppName.AutoSize = false;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(0, 210);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(200, 36);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "JarasTech";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── pnlDatos (panel derecho) ─────────────────────────────────
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlDatos.Controls.Add(this.lblProductoLbl);
            this.pnlDatos.Controls.Add(this.labelProductName);
            this.pnlDatos.Controls.Add(this.lblVersionLbl);
            this.pnlDatos.Controls.Add(this.labelVersion);
            this.pnlDatos.Controls.Add(this.lblCopyrightLbl);
            this.pnlDatos.Controls.Add(this.labelCopyright);
            this.pnlDatos.Controls.Add(this.lblCompanyLbl);
            this.pnlDatos.Controls.Add(this.labelCompanyName);
            this.pnlDatos.Controls.Add(this.lblDescLbl);
            this.pnlDatos.Controls.Add(this.textBoxDescription);
            this.pnlDatos.Controls.Add(this.btnOK);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(200, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.pnlDatos.Size = new System.Drawing.Size(380, 460);
            this.pnlDatos.TabIndex = 1;

            // lblProductoLbl
            this.lblProductoLbl.AutoSize = true;
            this.lblProductoLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProductoLbl.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblProductoLbl.Location = new System.Drawing.Point(24, 22);
            this.lblProductoLbl.Name = "lblProductoLbl";
            this.lblProductoLbl.Size = new System.Drawing.Size(58, 19);
            this.lblProductoLbl.TabIndex = 0;
            this.lblProductoLbl.Text = "PRODUCTO";

            // labelProductName
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelProductName.ForeColor = System.Drawing.Color.FromArgb(20, 20, 50);
            this.labelProductName.Location = new System.Drawing.Point(24, 42);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(100, 25);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "—";

            // lblVersionLbl
            this.lblVersionLbl.AutoSize = true;
            this.lblVersionLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblVersionLbl.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblVersionLbl.Location = new System.Drawing.Point(24, 82);
            this.lblVersionLbl.Name = "lblVersionLbl";
            this.lblVersionLbl.Size = new System.Drawing.Size(55, 19);
            this.lblVersionLbl.TabIndex = 2;
            this.lblVersionLbl.Text = "VERSIÓN";

            // labelVersion
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.labelVersion.Location = new System.Drawing.Point(24, 102);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(60, 23);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "—";

            // lblCopyrightLbl
            this.lblCopyrightLbl.AutoSize = true;
            this.lblCopyrightLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCopyrightLbl.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblCopyrightLbl.Location = new System.Drawing.Point(24, 138);
            this.lblCopyrightLbl.Name = "lblCopyrightLbl";
            this.lblCopyrightLbl.Size = new System.Drawing.Size(68, 19);
            this.lblCopyrightLbl.TabIndex = 4;
            this.lblCopyrightLbl.Text = "COPYRIGHT";

            // labelCopyright
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCopyright.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.labelCopyright.Location = new System.Drawing.Point(24, 158);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(20, 20);
            this.labelCopyright.TabIndex = 5;
            this.labelCopyright.Text = "—";

            // lblCompanyLbl
            this.lblCompanyLbl.AutoSize = true;
            this.lblCompanyLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCompanyLbl.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblCompanyLbl.Location = new System.Drawing.Point(24, 192);
            this.lblCompanyLbl.Name = "lblCompanyLbl";
            this.lblCompanyLbl.Size = new System.Drawing.Size(60, 19);
            this.lblCompanyLbl.TabIndex = 6;
            this.lblCompanyLbl.Text = "EMPRESA";

            // labelCompanyName
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCompanyName.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.labelCompanyName.Location = new System.Drawing.Point(24, 212);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(20, 20);
            this.labelCompanyName.TabIndex = 7;
            this.labelCompanyName.Text = "—";

            // lblDescLbl
            this.lblDescLbl.AutoSize = true;
            this.lblDescLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDescLbl.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblDescLbl.Location = new System.Drawing.Point(24, 246);
            this.lblDescLbl.Name = "lblDescLbl";
            this.lblDescLbl.Size = new System.Drawing.Size(72, 19);
            this.lblDescLbl.TabIndex = 8;
            this.lblDescLbl.Text = "DESCRIPCIÓN";

            // textBoxDescription
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.textBoxDescription.Location = new System.Drawing.Point(24, 268);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(332, 90);
            this.textBoxDescription.TabIndex = 9;
            this.textBoxDescription.TabStop = false;

            // btnOK
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(24, 374);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(332, 42);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Aceptar";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // FrmAcercaDe
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(580, 460);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcercaDe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de JarasTech";

            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblProductoLbl;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label lblVersionLbl;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label lblCopyrightLbl;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label lblCompanyLbl;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label lblDescLbl;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button btnOK;
    }
}