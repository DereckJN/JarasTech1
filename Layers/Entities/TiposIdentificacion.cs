using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>Entidad que representa un tipo de identificación de cliente.</summary>
    internal class TiposIdentificacion
    {
        /// <summary>Identificador único del tipo de identificación.</summary>
        public int TipoIdentificacionID { get; set; }
        /// <summary>Nombre del tipo (Nacional / Extranjero).</summary>
        public string NombreTipo { get; set; }
    }
}
