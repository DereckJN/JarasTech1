using JarasTech.Layers.UI;
using JarasTech.Layers.UI.Mantenimientos;
using JarasTech.Layers.UI.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarasTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
