using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>Entidad que representa una marca de dispositivo electrónico.</summary>
    internal class Marcas
    {
        /// <summary>Identificador único de la marca.</summary>
        public int MarcaID { get; set; }
        /// <summary>Código alfanumérico de la marca.</summary>
        public string Codigo { get; set; }
        /// <summary>Descripción o nombre de la marca.</summary>
        public string Descripcion { get; set; }
    }
}
