using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>
    /// Representa el tipo de cambio del dólar para una fecha específica.
    /// </summary>
    internal class Dolar
    {
        /// <summary>
        /// Código de la moneda (por ejemplo, "USD").
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Fecha del tipo de cambio.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Monto del tipo de cambio del dólar (por ejemplo, colones por dólar).
        /// </summary>
        public double Monto { get; set; }
    }
}
