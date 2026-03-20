using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>Entidad que representa un tipo de pago aceptado en facturación.</summary>
    internal class TiposPago
    {
        /// <summary>Identificador único del tipo de pago.</summary>
        public int TipoPagoID { get; set; }
        /// <summary>Nombre del tipo de pago (Tarjeta de Crédito, Transferencia, SINPE Móvil).</summary>
        public string NombreTipo { get; set; }
    }
}
