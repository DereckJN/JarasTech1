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
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly BLLUsuarios _bllUsuarios = new BLLUsuarios();
        private readonly BLLPerfiles _bllPerfiles = new BLLPerfiles();

        private int _usuarioID = 0;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
            CargarGrilla();
            LimpiarFormulario();
        }

        private void CargarPerfiles()
        {
            List<Perfiles> perfiles = _bllPerfiles.GetAllPerfiles() as List<Perfiles>;
            if (perfiles == null) perfiles = new List<Perfiles>(_bllPerfiles.GetAllPerfiles());

            cboPerfil.DataSource = perfiles;
            cboPerfil.DisplayMember = "NombrePerfil";
            cboPerfil.ValueMember = "PerfilID";
            cboPerfil.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {
            try
            {
                IEnumerable<Usuarios> lista = _bllUsuarios.GetAllUsuarios();
                dgvUsuarios.DataSource = new List<Usuarios>(lista);

                // Configurar columnas
                if (dgvUsuarios.Columns["Contrasena"] != null)
                    dgvUsuarios.Columns["Contrasena"].Visible = false;
                if (dgvUsuarios.Columns["UsuarioID"] != null)
                    dgvUsuarios.Columns["UsuarioID"].Visible = false;
                if (dgvUsuarios.Columns["PerfilID"] != null)
                    dgvUsuarios.Columns["PerfilID"].Visible = false;

                dgvUsuarios.Columns["NombreUsuario"].HeaderText = "Usuario";
                dgvUsuarios.Columns["Estado"].HeaderText = "Activo";
                dgvUsuarios.Columns["NombrePerfil"].HeaderText = "Perfil";
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error CargarGrilla: {0}", ex.Message);
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;
            Usuarios u = dgvUsuarios.CurrentRow.DataBoundItem as Usuarios;
            if (u == null) return;

            _usuarioID = u.UsuarioID;
            txtUsuario.Text = u.NombreUsuario;
            txtContrasena.Text = u.Contrasena; // Si está encriptada, deberías mostrar vacío o un placeholder
            chkEstado.Checked = u.Estado;

            // Seleccionar perfil en el combo
            if (cboPerfil.Items.Count > 0)
            {
                foreach (Perfiles p in cboPerfil.Items)
                {
                    if (p.PerfilID == u.PerfilID)
                    {
                        cboPerfil.SelectedItem = p;
                        break;
                    }
                }
            }

            btnGuardar.Text = "Actualizar";
            btnEliminar.Enabled = true;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                Usuarios u = new Usuarios
                {
                    UsuarioID = _usuarioID,
                    NombreUsuario = txtUsuario.Text.Trim(),
                    Contrasena = txtContrasena.Text.Trim(),
                    PerfilID = (int)cboPerfil.SelectedValue,
                    Estado = chkEstado.Checked
                };

                _bllUsuarios.SaveUsuario(u);
                MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error btnGuardar: {0}", ex.Message);
                MessageBox.Show("Error al guardar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtContrasena.Text) && _usuarioID == 0)
            {
                MessageBox.Show("Ingrese la contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return false;
            }
            if (cboPerfil.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un perfil.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPerfil.Focus();
                return false;
            }
            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_usuarioID == 0)
            {
                MessageBox.Show("Seleccione un usuario de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este usuario permanentemente?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _bllUsuarios.DeleteUsuario(_usuarioID);
                    MessageBox.Show("Usuario eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarGrilla();
                }
                catch (Exception ex)
                {
                    _log.ErrorFormat("Error btnEliminar: {0}", ex.Message);
                    MessageBox.Show("No se puede eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}