namespace JarasTech.Layers.UI.Mantenimientos
{
    partial class FrmTiposDispositivo
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreTipo = new System.Windows.Forms.TextBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();

            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(700, 60);

            this.lblTitulo.Text = "⚙  Tipos de Dispositivo";
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.AutoSize = true;

            this.grpFiltro.Text = "Búsqueda";
            this.grpFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFiltro.Location = new System.Drawing.Point(12, 70);
            this.grpFiltro.Size = new System.Drawing.Size(676, 60);
            this.grpFiltro.Controls.Add(this.lblFiltro);
            this.grpFiltro.Controls.Add(this.txtFiltro);
            this.grpFiltro.Controls.Add(this.btnBuscar);

            this.lblFiltro.Text = "Tipo de dispositivo:";
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltro.Location = new System.Drawing.Point(10, 26);
            this.lblFiltro.AutoSize = true;

            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFiltro.Location = new System.Drawing.Point(145, 22);
            this.txtFiltro.Size = new System.Drawing.Size(400, 25);

            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(558, 20);
            this.btnBuscar.Size = new System.Drawing.Size(108, 30);

            this.dgvTipos.AllowUserToAddRows = false;
            this.dgvTipos.AllowUserToDeleteRows = false;
            this.dgvTipos.ReadOnly = true;
            this.dgvTipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipos.MultiSelect = false;
            this.dgvTipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipos.RowHeadersVisible = false;
            this.dgvTipos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvTipos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.dgvTipos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTipos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvTipos.ColumnHeadersHeight = 34;
            this.dgvTipos.EnableHeadersVisualStyles = false;
            this.dgvTipos.Location = new System.Drawing.Point(12, 140);
            this.dgvTipos.Size = new System.Drawing.Size(676, 340);

            this.grpDatos.Text = "Datos del Tipo de Dispositivo";
            this.grpDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDatos.Location = new System.Drawing.Point(12, 490);
            this.grpDatos.Size = new System.Drawing.Size(676, 80);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNombreTipo);

            this.lblNombre.Text = "Nombre del Tipo:";
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.Location = new System.Drawing.Point(15, 32);
            this.lblNombre.AutoSize = true;

            this.txtNombreTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreTipo.MaxLength = 100;
            this.txtNombreTipo.Location = new System.Drawing.Point(145, 28);
            this.txtNombreTipo.Size = new System.Drawing.Size(510, 25);

            this.pnlBotones.Location = new System.Drawing.Point(12, 580);
            this.pnlBotones.Size = new System.Drawing.Size(676, 50);
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnEliminar);

            this.btnNuevo.Text = "➕ Nuevo";
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(0, 8);
            this.btnNuevo.Size = new System.Drawing.Size(130, 36);

            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(145, 8);
            this.btnGuardar.Size = new System.Drawing.Size(130, 36);

            this.btnEliminar.Text = "🗑 Eliminar";
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(290, 8);
            this.btnEliminar.Size = new System.Drawing.Size(130, 36);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 645);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.dgvTipos);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTiposDispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JarasTech - Tipos de Dispositivo";

            this.pnlTop.ResumeLayout(false); this.pnlTop.PerformLayout();
            this.grpFiltro.ResumeLayout(false); this.grpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
            this.grpDatos.ResumeLayout(false); this.grpDatos.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvTipos;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreTipo;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
    }
}