using JarasTech.Layers.Entities;
using JarasTech.Layers.UI;
using JarasTech.Layers.UI.Mantenimientos;
using JarasTech.Layers.UI.Procesos;
using JarasTech.Layers.UI.Reportes;
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
                string nombre = SesionActual.Usuario.NombreUsuario.Trim();
                lblHeaderUsuario.Text = "👤  " + nombre;
                lblHeaderPerfil.Text = SesionActual.NombrePerfil ?? "";
                lblFecha.Text = "🕐  " + DateTime.Now.ToString("dd/MM/yyyy  HH:mm");
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
            bool esAdmin = perfil == "ADMINISTRADOR";
            bool esVendedor = perfil == "VENDEDOR";

            pnlSecMantenimientos.Visible = esAdmin || esVendedor;
            pnlSecProcesos.Visible = esAdmin || esVendedor;
            pnlSecSeguridad.Visible = esAdmin;
        }

        // ── Sidebar handlers ─────────────────────────────────────────────
        private void btnSideClientes_Click(object sender, EventArgs e)
        { AbrirForm(new mantenimientoClientes()); }

        private void btnSideIVA_Click(object sender, EventArgs e)
        { AbrirForm(new FrmIVA()); }

        private void btnSideMarcas_Click(object sender, EventArgs e)
        { AbrirForm(new FrmMarcas()); }

        private void btnSideModelos_Click(object sender, EventArgs e)
        { AbrirForm(new FrmModelos()); }

        private void btnSideProductos_Click(object sender, EventArgs e)
        { AbrirForm(new FrmProductos()); }

        private void btnSideTipos_Click(object sender, EventArgs e)
        { AbrirForm(new FrmTiposDispositivo()); }

        private void btnSideStock_Click(object sender, EventArgs e)
        { AbrirForm(new FrmIngresoStock()); }

        private void btnSideFacturacion_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmFacturacion { UsuarioActivo = SesionActual.Usuario });
        }

        private void btnSideReportes_Click(object sender, EventArgs e)
        { AbrirForm(new FrmReportes()); }

        private void btnSideUsuarios_Click(object sender, EventArgs e)
        { AbrirForm(new FrmUsuarios()); }

        private void btnSideAcercaDe_Click(object sender, EventArgs e)
        { new FrmAcercaDe().ShowDialog(this); }

        private void btnSideSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SesionActual.Usuario = null;
                this.Close();
                new FrmLogin().ShowDialog();
            }
        }

        // ── Helper ───────────────────────────────────────────────────────
        private void AbrirForm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = "🕐  " + DateTime.Now.ToString("dd/MM/yyyy  HH:mm");
        }
    }
}