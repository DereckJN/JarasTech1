using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>
    /// Entidad que representa la información del pago de una factura.
    /// </summary>
    internal class PagosFactura
    {
        /// <summary>Identificador único del pago.</summary>
        public int PagoID { get; set; }

        /// <summary>ID de la factura asociada.</summary>
        public int FacturaID { get; set; }

        /// <summary>ID del tipo de pago (Tarjeta, Transferencia, SINPE).</summary>
        public int TipoPagoID { get; set; }

        /// <summary>Número de tarjeta de crédito (solo si pago con tarjeta).</summary>
        public string NumeroTarjeta { get; set; }

        /// <summary>ID del banco emisor (para tarjeta o transferencia).</summary>
        public int? BancoID { get; set; }

        /// <summary>ID del tipo de tarjeta (VISA, MASTERCARD, AMEX).</summary>
        public int? TipoTarjetaID { get; set; }

        /// <summary>Número de transferencia bancaria (solo si pago por transferencia).</summary>
        public string NumeroTransferencia { get; set; }

        /// <summary>Número de teléfono SINPE Móvil (solo si pago por SINPE).</summary>
        public string NumeroSINPE { get; set; }

        // ── Propiedades de navegación ──

        /// <summary>Nombre del tipo de pago (cargado desde JOIN).</summary>
        public string NombreTipoPago { get; set; }

        /// <summary>Nombre del banco (cargado desde JOIN).</summary>
        public string NombreBanco { get; set; }

        /// <summary>Nombre del tipo de tarjeta (cargado desde JOIN).</summary>
        public string NombreTipoTarjeta { get; set; }
    }
}
