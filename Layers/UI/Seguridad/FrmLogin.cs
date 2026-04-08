using JarasTech.Layers.BLL;
using JarasTech.Layers.Entities;
using log4net;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace JarasTech.Layers.UI.Seguridad
{
    public partial class FrmLogin : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly BLLUsuarios _bllUsuarios = new BLLUsuarios();

        public FrmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnAceptar;
            this.CancelButton = btnCancelar;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string pass = txtContrasena.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Usuarios user = _bllUsuarios.Login(usuario, pass);
                if (user != null && user.Estado)
                {
                    // Guardar sesión
                    SesionActual.Usuario = user;

                    _log.InfoFormat("Login exitoso: {0} - Perfil: {1}",
                        user.NombreUsuario, user.NombrePerfil);

                    // Abrir formulario principal
                    Form1 principal = new Form1();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    _log.WarnFormat("Intento fallido de login: {0}", usuario);
                    MessageBox.Show("Usuario o contraseña incorrectos, o usuario inactivo.",
                        "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Error en login: {0}", ex.Message);
                MessageBox.Show("Error al intentar autenticar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}