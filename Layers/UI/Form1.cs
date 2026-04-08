using JarasTech.Layers.Entities;
using JarasTech.Layers.UI;
using JarasTech.Layers.UI.Mantenimientos;
using JarasTech.Layers.UI.Procesos;
using JarasTech.Layers.UI.Seguridad;
using System;
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
                lblUsuarioLogueado.Text = $"Usuario: {SesionActual.Usuario.NombreUsuario}";
                lblPerfil.Text = $"Perfil: {SesionActual.Usuario.NombrePerfil}";
                AplicarPermisosPorPerfil();
            }
            else
            {
                // Si no hay sesión (por seguridad), cerramos
                this.Close();
                Application.Exit();
            }
        }

        private void AplicarPermisosPorPerfil()
        {
            string perfil = SesionActual.NombrePerfil?.ToUpper();

            switch (perfil)
            {
                case "ADMINISTRADOR":
                    usuariosToolStripMenuItem.Enabled = true;
                    usuariosToolStripMenuItem.Visible = true;
                    break;

                case "VENDEDOR":
                    // El vendedor no puede ver/editar usuarios
                    // Si tienes un menú de usuarios, deshabilítalo
                    // Por ahora no hay menú de usuarios en tu Form1
                    break;

                case "REPORTES":
                    // Solo reportes (deshabilitar mantenimientos y procesos)
                    mantenimientosToolStripMenuItem.Enabled = false;
                    procesosToolStripMenuItem.Enabled = false;
                    break;

                default:
                    mantenimientosToolStripMenuItem.Enabled = false;
                    procesosToolStripMenuItem.Enabled = false;
                    break;
            }
        }


        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mantenimientoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoClientes frmMenu = new mantenimientoClientes();
            frmMenu.Show();
        }

        private void iVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIVA frmMenu = new FrmIVA();
            frmMenu.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarcas frmMenu = new FrmMarcas();
            frmMenu.Show();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModelos frmMenu = new FrmModelos();
            frmMenu.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos frmMenu = new FrmProductos();
            frmMenu.Show();
        }

        private void tipoDeDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposDispositivo frmMenu = new FrmTiposDispositivo();
            frmMenu.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresoStock frmMenu = new FrmIngresoStock();
            frmMenu.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturacion frmMenu = new FrmFacturacion();
            frmMenu.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
        }
    }
}