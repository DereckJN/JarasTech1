using JarasTech.Layers.Entities;
using JarasTech.Layers.UI;
using JarasTech.Layers.UI.Mantenimientos;
using JarasTech.Layers.UI.Procesos;
using JarasTech.Layers.UI.Reportes;
using JarasTech.Layers.UI.Seguridad;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JarasTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (SesionActual.Usuario != null)
            {
                // Mostrar nombre completo en la barra de estado
                string nombreCompleto = (SesionActual.Usuario.NombreUsuario).Trim();
                if (string.IsNullOrEmpty(nombreCompleto))
                    nombreCompleto = SesionActual.Usuario.NombreUsuario;

                lblUsuarioLogueado.Text = "  👤  " + nombreCompleto;
                lblPerfil.Text = "  🔑  " + SesionActual.NombrePerfil;

                AplicarPermisosPorPerfil();
            }
            else
            {
                this.Close();
                Application.Exit();
            }
        }

        private void AplicarPermisosPorPerfil()
        {
            string perfil = SesionActual.NombrePerfil?.ToUpper().Trim();

            switch (perfil)
            {
                case "ADMINISTRADOR":
                    mantenimientosToolStripMenuItem.Enabled = true;
                    procesosToolStripMenuItem.Enabled = true;
                    seguridadToolStripMenuItem.Visible = true;
                    usuariosToolStripMenuItem.Enabled = true;
                    break;

                case "VENDEDOR":
                    mantenimientosToolStripMenuItem.Enabled = true;
                    procesosToolStripMenuItem.Enabled = true;
                    seguridadToolStripMenuItem.Visible = false;
                    break;

                case "REPORTES":
                    mantenimientosToolStripMenuItem.Enabled = false;
                    procesosToolStripMenuItem.Enabled = true;  // puede ver reportes
                    seguridadToolStripMenuItem.Visible = false;
                    break;

                default:
                    mantenimientosToolStripMenuItem.Enabled = false;
                    procesosToolStripMenuItem.Enabled = false;
                    seguridadToolStripMenuItem.Visible = false;
                    break;
            }
        }

        // ════════════════════════════════════════════════════════════════
        // ARCHIVO
        // ════════════════════════════════════════════════════════════════
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SesionActual.Usuario = null;
                this.Close();
                new FrmLogin().ShowDialog();
            }
        }

        // ════════════════════════════════════════════════════════════════
        // MANTENIMIENTOS
        // ════════════════════════════════════════════════════════════════
        private void mantenimientoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new mantenimientoClientes());
        }

        private void iVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmIVA());
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmMarcas());
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmModelos());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmProductos());
        }

        private void tipoDeDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmTiposDispositivo());
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmIngresoStock());
        }

        // ════════════════════════════════════════════════════════════════
        // PROCESOS — pasa el usuario activo a FrmFacturacion
        // ════════════════════════════════════════════════════════════════
        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmFacturacion();
            frm.UsuarioActivo = SesionActual.Usuario; // ← pasa el usuario de la sesión
            AbrirForm(frm);
        }

        // ════════════════════════════════════════════════════════════════
        // SEGURIDAD
        // ════════════════════════════════════════════════════════════════
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        // ════════════════════════════════════════════════════════════════
        // HELPER — abre cada form centrado en el Form1
        // ════════════════════════════════════════════════════════════════
        private void AbrirForm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

     

        private void formularioReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmReportes());
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAcercaDe().ShowDialog(this);
        }
    }
}