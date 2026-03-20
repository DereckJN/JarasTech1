using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>
    /// Entidad que representa un usuario del sistema JarasTech.
    /// </summary>
    internal class Usuarios
    {
        /// <summary>Identificador único del usuario.</summary>
        public int UsuarioID { get; set; }

        /// <summary>Nombre de usuario para iniciar sesión.</summary>
        public string NombreUsuario { get; set; }

        /// <summary>Contraseña del usuario (almacenada con hash).</summary>
        public string Contrasena { get; set; }

        /// <summary>ID del perfil de seguridad asignado.</summary>
        public int PerfilID { get; set; }

        /// <summary>Estado del usuario: true = activo, false = inactivo.</summary>
        public bool Estado { get; set; }

        /// <summary>Nombre del perfil .</summary>
        public string NombrePerfil { get; set; }
    }
}
