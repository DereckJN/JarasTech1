using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    internal class Clientes
    {
        public int ClienteID { set; get; }
        public int TipoIdentificacionID { set; get; }
        public string NumeroIdentificacion { set; get; }
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public char Sexo { set; get; }
        public string Telefono { set; get; }
        public string CorreoElectronico { set; get; }
        public string Provincia { set; get; }
        public string DireccionExacta { set; get; }
        public byte[] Fotografia { set; get; }

        /// <summary>
        /// Nombre completo del cliente (calculado).
        /// </summary>
        public string NombreCompleto => $"{Nombre} {Apellidos}";

    }
}
