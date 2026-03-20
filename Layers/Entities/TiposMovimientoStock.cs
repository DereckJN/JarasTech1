using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>Entidad que representa un tipo de movimiento de inventario.</summary>
    internal class TiposMovimientoStock
    {
        /// <summary>Identificador único del tipo de movimiento.</summary>
        public int TipoMovimientoID { get; set; }
        /// <summary>Nombre del tipo de movimiento (Entrada / Salida).</summary>
        public string NombreTipo { get; set; }
    }
}
