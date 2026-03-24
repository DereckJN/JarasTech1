using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces.Ibll;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarasTech.Layers.UI.Mantenimientos
{
    public partial class FrmTiposDispositivo : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IBLLTiposDispositivo _bll = new BLLTiposDispositivo();
        private int _tipoIDSeleccionado = 0;

        public FrmTiposDispositivo()
        {
            InitializeComponent();
        }

        private void FrmTiposDispositivo_Load(object sender, EventArgs e)
        {
            try { CargarGrilla(string.Empty); LimpiarFormulario(); }
            catch (Exception ex) { _log.ErrorFormat("Error Load: {0}", ex.Message); }
        }

        private void CargarGrilla(string filtro)
        {
            var lista = _bll.GetAllTiposDispositivo()
                .Where(t => string.IsNullOrEmpty(filtro) || 
                    (t.NombreTipo != null && t.NombreTipo.ToLower().Contains(filtro.ToLower())))
                .ToList();
            dgvTipos.DataSource = lista;
            if (dgvTipos.Columns["TipoDispositivoID"] != null) dgvTipos.Columns["TipoDispositivoID"].Visible = false;
            if (dgvTipos.Columns["NombreTipo"] != null) dgvTipos.Columns["NombreTipo"].HeaderText = "Tipo de Dispositivo";
        }

        private void dgvTipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTipos.CurrentRow?.DataBoundItem is TiposDispositivo t)
            {
                _tipoIDSeleccionado = t.TipoDispositivoID;
                txtNombreTipo.Text = t.NombreTipo;
                btnGuardar.Text = "Actualizar";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla(txtFiltro.Text.Trim());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreTipo.Text))
            { MessageBox.Show("El nombre del tipo es requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                _bll.SaveTipoDispositivo(new TiposDispositivo { TipoDispositivoID = _tipoIDSeleccionado, NombreTipo = txtNombreTipo.Text.Trim() });
                MessageBox.Show("Tipo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario(); CargarGrilla(string.Empty);
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_tipoIDSeleccionado == 0) { MessageBox.Show("Seleccione un tipo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("¿Eliminar el tipo seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try { _bll.DeleteTipoDispositivo(_tipoIDSeleccionado); LimpiarFormulario(); CargarGrilla(string.Empty); }
                catch (Exception ex) { MessageBox.Show($"No se puede eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void LimpiarFormulario()
        { 
            _tipoIDSeleccionado = 0; txtNombreTipo.Clear(); btnGuardar.Text = "Guardar"; txtNombreTipo.Focus(); 
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CargarGrilla(txtFiltro.Text.Trim());
        }
    }
}
