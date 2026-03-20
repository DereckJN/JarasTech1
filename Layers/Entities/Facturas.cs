using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>
    /// Entidad que representa el encabezado de una factura de venta.
    /// </summary>
    internal class Facturas
    {
        /// <summary>Identificador único de la factura.</summary>
        public int FacturaID { get; set; }

        /// <summary>ID del cliente asociado a la factura.</summary>
        public int ClienteID { get; set; }

        /// <summary>ID del usuario (vendedor) que generó la factura.</summary>
        public int UsuarioID { get; set; }

        /// <summary>Fecha y hora en que se generó la factura.</summary>
        public DateTime FechaFactura { get; set; }

        /// <summary>Subtotal en colones antes de IVA.</summary>
        public decimal SubtotalColones { get; set; }

        /// <summary>Monto del IVA en colones.</summary>
        public decimal MontoIVA { get; set; }

        /// <summary>Total en colones incluyendo IVA.</summary>
        public decimal TotalColones { get; set; }

        /// <summary>Tipo de cambio del dólar al momento de la factura (obtenido del BCCR).</summary>
        public decimal TipoCambio { get; set; }

        /// <summary>Total en dólares (TotalColones / TipoCambio).</summary>
        public decimal TotalDolares { get; set; }

        /// <summary>ID del registro IVA aplicado.</summary>
        public int IVAID { get; set; }

        /// <summary>XML de la factura generado y enviado al cliente.</summary>
        public string XMLFactura { get; set; }

        /// <summary>Firma digital del cliente capturada con el mouse (bytes).</summary>
        public byte[] FirmaDigital { get; set; }

        /// <summary>Estado de la factura: true = activa, false = anulada.</summary>
        public bool Estado { get; set; }

        // ── Propiedades de navegación ──

        /// <summary>Nombre completo del cliente (cargado desde JOIN).</summary>
        public string NombreCliente { get; set; }

        /// <summary>Nombre del vendedor (cargado desde JOIN).</summary>
        public string NombreVendedor { get; set; }

        /// <summary>Porcentaje de IVA aplicado (cargado desde JOIN).</summary>
        public decimal PorcentajeIVA { get; set; }

        /// <summary>Correo electrónico del cliente para envío de factura.</summary>
        public string CorreoCliente { get; set; }

        /// <summary>Líneas de detalle de la factura.</summary>
        public List<DetalleFactura> Detalle { get; set; } = new List<DetalleFactura>();

        /// <summary>Información del pago de la factura.</summary>
        public PagosFactura Pago { get; set; }
    }
}
