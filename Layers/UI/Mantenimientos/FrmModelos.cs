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
    public partial class FrmModelos : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IBLLModelos _bll = new BLLModelos();
        private int _modeloIDSeleccionado = 0;

        public FrmModelos()
        {
            InitializeComponent();
        }

        private void FrmModelos_Load(object sender, EventArgs e)
        {
            try { CargarGrilla(string.Empty); LimpiarFormulario(); }
            catch (Exception ex) { _log.ErrorFormat("Error Load: {0}", ex.Message); }
        }
        private void CargarGrilla(string filtro)
        {
            var lista = _bll.GetAllModelos()
                .Where(m => string.IsNullOrEmpty(filtro) ||
                            m.Codigo != null && m.Codigo.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            m.Descripcion != null && m.Descripcion.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            dgvModelos.DataSource = lista;
            if (dgvModelos.Columns["ModeloID"] != null) dgvModelos.Columns["ModeloID"].Visible = false;
            if (dgvModelos.Columns["Codigo"] != null) dgvModelos.Columns["Codigo"].HeaderText = "Código";
            if (dgvModelos.Columns["Descripcion"] != null) dgvModelos.Columns["Descripcion"].HeaderText = "Descripción";
        }

        private void dgvModelos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModelos.CurrentRow?.DataBoundItem is Modelos m)
            {
                _modeloIDSeleccionado = m.ModeloID;
                txtCodigo.Text = m.Codigo;
                txtDescripcion.Text = m.Descripcion;
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
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            { MessageBox.Show("Código y Descripción son requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                _bll.SaveModelo(new Modelos { ModeloID = _modeloIDSeleccionado, Codigo = txtCodigo.Text.Trim().ToUpper(), Descripcion = txtDescripcion.Text.Trim() });
                MessageBox.Show("Modelo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario(); CargarGrilla(string.Empty);
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_modeloIDSeleccionado == 0) { MessageBox.Show("Seleccione un modelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("¿Eliminar el modelo seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try { _bll.DeleteModelo(_modeloIDSeleccionado); LimpiarFormulario(); CargarGrilla(string.Empty); }
                catch (Exception ex) { MessageBox.Show($"No se puede eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void LimpiarFormulario()
        {
            _modeloIDSeleccionado = 0;
            txtCodigo.Clear(); txtDescripcion.Clear();
            btnGuardar.Text = "Guardar"; txtCodigo.Focus();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CargarGrilla(txtFiltro.Text.Trim());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
