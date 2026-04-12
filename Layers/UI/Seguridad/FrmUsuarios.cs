using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace JarasTech.Layers.UI.Seguridad
{
    public partial class FrmUsuarios : Form
    {
        private static readonly ILog _log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly BLLUsuarios _bllUsuarios = new BLLUsuarios();
        private readonly BLLPerfiles _bllPerfiles = new BLLPerfiles();

        private int _usuarioID = 0;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPerfiles();
                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error FrmUsuarios_Load: {0}", ex.Message);
                MessageBox.Show("Error al cargar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPerfiles()
        {
            var perfiles = new List<Perfiles>(_bllPerfiles.GetAllPerfiles());
            cboPerfil.DataSource = perfiles;
            cboPerfil.DisplayMember = "NombrePerfil";
            cboPerfil.ValueMember = "PerfilID";
            cboPerfil.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {
            try
            {
                dgvUsuarios.DataSource = new List<Usuarios>(_bllUsuarios.GetAllUsuarios());

                // Ocultar columnas sensibles/internas
                string[] ocultar = { "Contrasena", "UsuarioID", "PerfilID" };
                foreach (string col in ocultar)
                    if (dgvUsuarios.Columns[col] != null)
                        dgvUsuarios.Columns[col].Visible = false;

                if (dgvUsuarios.Columns["NombreUsuario"] != null)
                    dgvUsuarios.Columns["NombreUsuario"].HeaderText = "Usuario";
                if (dgvUsuarios.Columns["Estado"] != null)
                    dgvUsuarios.Columns["Estado"].HeaderText = "Activo";
                if (dgvUsuarios.Columns["NombrePerfil"] != null)
                    dgvUsuarios.Columns["NombrePerfil"].HeaderText = "Perfil";
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error CargarGrilla: {0}", ex.Message);
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow?.DataBoundItem is Usuarios u)
            {
                _usuarioID = u.UsuarioID;
                txtUsuario.Text = u.NombreUsuario;
                txtContrasena.Text = string.Empty; // nunca mostrar contraseña real
                chkEstado.Checked = u.Estado;

                foreach (Perfiles p in cboPerfil.Items)
                    if (p.PerfilID == u.PerfilID) { cboPerfil.SelectedItem = p; break; }

                btnGuardar.Text = "Actualizar";
                btnEliminar.Enabled = true;
            }
        }

        private void LimpiarFormulario()
        {
            _usuarioID = 0;
            txtUsuario.Clear();
            txtContrasena.Clear();
            chkEstado.Checked = true;
            cboPerfil.SelectedIndex = -1;
            btnGuardar.Text = "Guardar";
            btnEliminar.Enabled = false;
            txtUsuario.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e) { LimpiarFormulario(); }
        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            try
            {
                var u = new Usuarios
                {
                    UsuarioID = _usuarioID,
                    NombreUsuario = txtUsuario.Text.Trim(),
                    Contrasena = string.IsNullOrWhiteSpace(txtContrasena.Text)
                                    ? null : txtContrasena.Text.Trim(),
                    PerfilID = (int)cboPerfil.SelectedValue,
                    Estado = chkEstado.Checked
                };
                _bllUsuarios.SaveUsuario(u);
                MessageBox.Show("Usuario guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnGuardar: {0}", ex.Message);
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_usuarioID == 0)
            {
                MessageBox.Show("Seleccione un usuario.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (MessageBox.Show("¿Eliminar este usuario?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _bllUsuarios.DeleteUsuario(_usuarioID);
                    MessageBox.Show("Usuario eliminado.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarGrilla();
                }
                catch (Exception ex)
                {
                    _log.ErrorFormat("Error btnEliminar: {0}", ex.Message);
                    MessageBox.Show("No se puede eliminar: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus(); return false;
            }
            if (_usuarioID == 0 && string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Ingrese la contraseña para el nuevo usuario.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus(); return false;
            }
            if (cboPerfil.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un perfil.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }
            return true;
        }
    }
}