using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>Entidad que representa un tipo de dispositivo electrónico.</summary>
    internal class TiposDispositivo
    {
        /// <summary>Identificador único del tipo de dispositivo.</summary>
        public int TipoDispositivoID { get; set; }
        /// <summary>Nombre del tipo (ej. Smartphone, Tablet, Laptop, Smartwatch).</summary>
        public string NombreTipo { get; set; }
    }
}
