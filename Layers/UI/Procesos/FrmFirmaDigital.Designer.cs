namespace JarasTech.Layers.UI.Procesos
{
    partial class FrmFirmaDigital
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelFirma = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelFirma
            // 
            this.panelFirma.BackColor = System.Drawing.Color.White;
            this.panelFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFirma.Location = new System.Drawing.Point(12, 50);
            this.panelFirma.Name = "panelFirma";
            this.panelFirma.Size = new System.Drawing.Size(500, 200);
            this.panelFirma.TabIndex = 0;
            this.panelFirma.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFirma_Paint);
            this.panelFirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFirma_MouseDown);
            this.panelFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFirma_MouseMove);
            this.panelFirma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFirma_MouseUp);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 260);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(250, 260);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 35);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(390, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInstrucciones.Location = new System.Drawing.Point(12, 20);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(63, 23);
            this.lblInstrucciones.TabIndex = 4;
            this.lblInstrucciones.Text = "Firmar";
            // 
            // FrmFirmaDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 315);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.panelFirma);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFirmaDigital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Firma Digital del Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelFirma;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblInstrucciones;
    }
}