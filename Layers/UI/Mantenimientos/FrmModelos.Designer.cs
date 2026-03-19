namespace JarasTech.Layers.UI.Mantenimientos
{
    partial class FrmModelos
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
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(900, 60);

            this.lblTitulo.Text = "⚙  Mantenimiento de Modelos";
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.AutoSize = true;

            // grpFiltro
            this.grpFiltro.Text = "Búsqueda";
            this.grpFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFiltro.Location = new System.Drawing.Point(12, 70);
            this.grpFiltro.Size = new System.Drawing.Size(876, 60);
            this.grpFiltro.Controls.Add(this.lblFiltro);
            this.grpFiltro.Controls.Add(this.txtFiltro);
            this.grpFiltro.Controls.Add(this.btnBuscar);

            this.lblFiltro.Text = "Código / Descripción:";
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltro.Location = new System.Drawing.Point(10, 26);
            this.lblFiltro.AutoSize = true;

            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFiltro.Location = new System.Drawing.Point(155, 22);
            this.txtFiltro.Size = new System.Drawing.Size(540, 25);


            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(710, 20);
            this.btnBuscar.Size = new System.Drawing.Size(120, 30);


            // dgvModelos
            this.dgvModelos.AllowUserToAddRows = false;
            this.dgvModelos.AllowUserToDeleteRows = false;
            this.dgvModelos.ReadOnly = true;
            this.dgvModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelos.MultiSelect = false;
            this.dgvModelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModelos.BackgroundColor = System.Drawing.Color.White;
            this.dgvModelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModelos.RowHeadersVisible = false;
            this.dgvModelos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvModelos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.dgvModelos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvModelos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvModelos.ColumnHeadersHeight = 34;
            this.dgvModelos.EnableHeadersVisualStyles = false;
            this.dgvModelos.Location = new System.Drawing.Point(12, 140);
            this.dgvModelos.Size = new System.Drawing.Size(876, 320);


            // grpDatos
            this.grpDatos.Text = "Datos del Modelo";
            this.grpDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDatos.Location = new System.Drawing.Point(12, 470);
            this.grpDatos.Size = new System.Drawing.Size(876, 100);
            this.grpDatos.Controls.Add(this.lblCodigo);
            this.grpDatos.Controls.Add(this.txtCodigo);
            this.grpDatos.Controls.Add(this.lblDescripcion);
            this.grpDatos.Controls.Add(this.txtDescripcion);

            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCodigo.Location = new System.Drawing.Point(15, 40);
            this.lblCodigo.AutoSize = true;

            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(100, 36);
            this.txtCodigo.Size = new System.Drawing.Size(150, 25);

            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion.Location = new System.Drawing.Point(275, 40);
            this.lblDescripcion.AutoSize = true;

            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Location = new System.Drawing.Point(375, 36);
            this.txtDescripcion.Size = new System.Drawing.Size(480, 25);

            // pnlBotones
            this.pnlBotones.Location = new System.Drawing.Point(12, 580);
            this.pnlBotones.Size = new System.Drawing.Size(876, 50);
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


            // FrmModelos
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 645);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.dgvModelos);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmModelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JarasTech - Modelos";


            this.pnlTop.ResumeLayout(false); this.pnlTop.PerformLayout();
            this.grpFiltro.ResumeLayout(false); this.grpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
    }
}