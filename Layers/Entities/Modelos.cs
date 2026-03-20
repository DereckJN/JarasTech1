using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>Entidad que representa un modelo de dispositivo electrónico.</summary>
    internal class Modelos
    {
        /// <summary>Identificador único del modelo.</summary>
        public int ModeloID { get; set; }
        /// <summary>Código alfanumérico del modelo.</summary>
        public string Codigo { get; set; }
        /// <summary>Descripción o nombre del modelo.</summary>
        public string Descripcion { get; set; } 
    }
}
