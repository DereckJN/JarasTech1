using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>Entidad que representa un tipo de tarjeta de crédito.</summary>
    internal class TiposTarjeta
    {
        /// <summary>Identificador único del tipo de tarjeta.</summary>
        public int TipoTarjetaID { get; set; }
        /// <summary>Nombre de la tarjeta (VISA, MASTERCARD, AMERICAN EXPRESS).</summary>
        public string NombreTarjeta { get; set; }
    }
}
