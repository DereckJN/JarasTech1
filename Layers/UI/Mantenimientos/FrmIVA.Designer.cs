namespace JarasTech.Layers.UI.Mantenimientos
{
    partial class FrmIVA
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvIVA = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblPorc = new System.Windows.Forms.Label();
            this.numPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.lblAviso = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIVA)).BeginInit();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();

            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(500, 60);

            this.lblTitulo.Text = "💰  Mantenimiento de IVA";
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.AutoSize = true;

            this.dgvIVA.AllowUserToAddRows = false; this.dgvIVA.AllowUserToDeleteRows = false; this.dgvIVA.ReadOnly = true;
            this.dgvIVA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.dgvIVA.MultiSelect = false;
            this.dgvIVA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIVA.BackgroundColor = System.Drawing.Color.White; this.dgvIVA.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvIVA.RowHeadersVisible = false;
            this.dgvIVA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvIVA.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.dgvIVA.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvIVA.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvIVA.ColumnHeadersHeight = 34; this.dgvIVA.EnableHeadersVisualStyles = false;
            this.dgvIVA.Location = new System.Drawing.Point(12, 70); this.dgvIVA.Size = new System.Drawing.Size(476, 200);
            this.dgvIVA.SelectionChanged += new System.EventHandler(this.dgvIVA_SelectionChanged);

            this.grpDatos.Text = "Configuración del IVA";
            this.grpDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDatos.Location = new System.Drawing.Point(12, 280); this.grpDatos.Size = new System.Drawing.Size(476, 110);
            this.grpDatos.Controls.Add(this.lblPorc); this.grpDatos.Controls.Add(this.numPorcentaje); this.grpDatos.Controls.Add(this.lblAviso);

            this.lblPorc.Text = "Porcentaje IVA (%):"; this.lblPorc.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblPorc.Location = new System.Drawing.Point(15, 38); this.lblPorc.AutoSize = true;
            this.numPorcentaje.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold); this.numPorcentaje.Location = new System.Drawing.Point(190, 32); this.numPorcentaje.Size = new System.Drawing.Size(100, 32); this.numPorcentaje.Minimum = 1; this.numPorcentaje.Maximum = 100; this.numPorcentaje.Value = 13; this.numPorcentaje.DecimalPlaces = 2;
            this.lblAviso.Text = "⚠  IVA actual en Costa Rica: 13%"; this.lblAviso.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic); this.lblAviso.ForeColor = System.Drawing.Color.DarkOrange; this.lblAviso.Location = new System.Drawing.Point(15, 75); this.lblAviso.AutoSize = true;

            this.pnlBotones.Location = new System.Drawing.Point(12, 400); this.pnlBotones.Size = new System.Drawing.Size(476, 50); this.pnlBotones.Controls.Add(this.btnNuevo); this.pnlBotones.Controls.Add(this.btnGuardar);
            this.btnNuevo.Text = "➕ Nuevo"; this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold); this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnNuevo.ForeColor = System.Drawing.Color.White; this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnNuevo.Location = new System.Drawing.Point(0, 8); this.btnNuevo.Size = new System.Drawing.Size(120, 36); this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnGuardar.Text = "💾 Guardar"; this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold); this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 120, 215); this.btnGuardar.ForeColor = System.Drawing.Color.White; this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnGuardar.Location = new System.Drawing.Point(135, 8); this.btnGuardar.Size = new System.Drawing.Size(120, 36); this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(500, 465);
            this.Controls.Add(this.pnlTop); this.Controls.Add(this.dgvIVA); this.Controls.Add(this.grpDatos); this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; this.Name = "FrmIVA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JarasTech - IVA";
            this.Load += new System.EventHandler(this.FrmIVA_Load);

            this.pnlTop.ResumeLayout(false); this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIVA)).EndInit();
            this.grpDatos.ResumeLayout(false); this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvIVA;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblPorc, lblAviso;
        private System.Windows.Forms.NumericUpDown numPorcentaje;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnNuevo, btnGuardar;
    }
}