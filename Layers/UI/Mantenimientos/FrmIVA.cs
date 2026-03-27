// ══════════════════════════════════════════════════════════════════
// FrmIVA.cs
// ══════════════════════════════════════════════════════════════════
using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces;
using JarasTech.Layers.Interfaces.Ibll;
using log4net;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace JarasTech.Layers.UI.Mantenimientos
{
    /// <summary>Formulario de mantenimiento del IVA (constante 13%).</summary>
    public partial class FrmIVA : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IBLLIVA _bll = new BLLIVA();
        private int _ivaID = 0;

        public FrmIVA() { InitializeComponent(); }

        private void FrmIVA_Load(object sender, EventArgs e)
        {
            try
            {
                var lista = _bll.GetAllIVA().ToList();
                dgvIVA.DataSource = lista;
                if (dgvIVA.Columns["IVAID"] != null) dgvIVA.Columns["IVAID"].Visible = false;
                if (dgvIVA.Columns["Porcentaje"] != null) dgvIVA.Columns["Porcentaje"].HeaderText = "Porcentaje (%)";

                // Cargar el registro activo (solo 1 normalmente)
                var iva = lista.FirstOrDefault();
                if (iva != null) { _ivaID = iva.IVAID; numPorcentaje.Value = iva.Porcentaje; }
            }
            catch (Exception ex) 
            {
                _log.ErrorFormat("Error Load IVA: {0}", ex.Message);
            }
        }
      

        private void dgvIVA_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIVA.CurrentRow?.DataBoundItem is IVA iva)
            { _ivaID = iva.IVAID; numPorcentaje.Value = iva.Porcentaje; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _bll.SaveIVA(new IVA { IVAID = _ivaID, Porcentaje = numPorcentaje.Value });
                MessageBox.Show("IVA guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmIVA_Load(sender, e);
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

   
        private void btnNuevo_Click(object sender, EventArgs e)
        { 
            _ivaID = 0; numPorcentaje.Value = 13; 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}