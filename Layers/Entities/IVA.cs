using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>Entidad que representa el porcentaje del Impuesto al Valor Agregado.</summary>
    internal class IVA
    {
        /// <summary>Identificador único del registro IVA.</summary>
        public int IVAID { get; set; }
        /// <summary>Porcentaje del IVA (constante 13% en Costa Rica).</summary>
        public decimal Porcentaje { get; set; }
    }
}
