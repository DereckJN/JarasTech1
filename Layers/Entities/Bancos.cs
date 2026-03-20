using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>Entidad que representa un banco para pagos con tarjeta o transferencia.</summary>
    internal class Bancos
    {
        /// <summary>Identificador único del banco.</summary>
        public int BancoID { get; set; }
        /// <summary>Nombre del banco (ej. Banco Nacional de Costa Rica).</summary>
        public string NombreBanco { get; set; }
    }
}
