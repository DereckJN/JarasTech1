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
    public partial class FrmMarcas : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IBLLMarcas _bll = new BLLMarcas();
        private int _marcaIDSeleccionada = 0;

        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrilla(string.Empty);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error FrmMarcas_Load: {0}", ex.Message);
                MessageBox.Show("Error al cargar el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarGrilla(string filtro)
        {
            try
            {
                var lista = _bll.GetAllMarcas()
                    .Where(m => string.IsNullOrEmpty(filtro) ||
                                (m.Codigo != null && m.Codigo.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0) ||
                                (m.Descripcion != null && m.Descripcion.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0))
                    .ToList();

                dgvMarcas.DataSource = lista;

                // Alias de columnas
                if (dgvMarcas.Columns["MarcaID"] != null) dgvMarcas.Columns["MarcaID"].HeaderText = "ID";
                if (dgvMarcas.Columns["Codigo"] != null) dgvMarcas.Columns["Codigo"].HeaderText = "Código";
                if (dgvMarcas.Columns["Descripcion"] != null) dgvMarcas.Columns["Descripcion"].HeaderText = "Descripción";

                dgvMarcas.Columns["MarcaID"].Visible = false;
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error CargarGrilla Marcas: {0}", ex.Message);
            }
        }

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow?.DataBoundItem is Marcas marca)
            {
                _marcaIDSeleccionada = marca.MarcaID;
                txtCodigo.Text = marca.Codigo;
                txtDescripcion.Text = marca.Descripcion;
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
            if (!ValidarCampos()) return;
            try
            {
                var marca = new Marcas
                {
                    MarcaID = _marcaIDSeleccionada,
                    Codigo = txtCodigo.Text.Trim().ToUpper(),
                    Descripcion = txtDescripcion.Text.Trim()
                };

                _bll.SaveMarca(marca);
                MessageBox.Show("Marca guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarGrilla(string.Empty);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnGuardar Marcas: {0}", ex.Message);
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_marcaIDSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una marca.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar la marca seleccionada?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            try
            {
                _bll.DeleteMarca(_marcaIDSeleccionada);
                MessageBox.Show("Marca eliminada.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarGrilla(string.Empty);
            }
            catch (System.Data.SqlClient.SqlException ex)
                when (ex.Number == 547) 
            {
                MessageBox.Show(
                    "No se puede eliminar esta marca porque tiene productos asociados.\n\n" +
                    "Primero elimine o reasigne los productos que usan esta marca.",
                    "Operación no permitida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _log.ErrorFormat("FK violation al eliminar marca {0}: {1}",
                    _marcaIDSeleccionada, ex.Message);
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnEliminar Marcas: {0}", ex.Message);
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormulario()
        {
            _marcaIDSeleccionada = 0;
            txtCodigo.Clear();
            txtDescripcion.Clear();
            btnGuardar.Text = "Guardar";
            txtCodigo.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El código es requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es requerida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            return true;
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

