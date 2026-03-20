using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>Entidad que representa un perfil de seguridad del sistema.</summary>
    internal class Perfiles
    {
        /// <summary>Identificador único del perfil.</summary>
        public int PerfilID { get; set; }
        /// <summary>Nombre del perfil (ADMINISTRADOR, VENDEDOR, REPORTES).</summary>
        public string NombrePerfil { get; set; }
    }
}
