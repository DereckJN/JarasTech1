using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>
    /// Entidad que representa una línea de detalle dentro de una factura.
    /// </summary>
    internal class DetalleFactura
    {
        /// <summary>Identificador único del detalle.</summary>
        public int DetalleFacturaID { get; set; }

        /// <summary>ID de la factura a la que pertenece.</summary>
        public int FacturaID { get; set; }

        /// <summary>ID del producto vendido.</summary>
        public int ProductoID { get; set; }

        /// <summary>Cantidad de unidades vendidas.</summary>
        public int Cantidad { get; set; }

        /// <summary>Precio unitario en colones al momento de la venta.</summary>
        public decimal PrecioUnitarioColones { get; set; }

        /// <summary>Precio unitario en dólares al momento de la venta.</summary>
        public decimal PrecioUnitarioDolares { get; set; }

        /// <summary>Subtotal de la línea en colones (Cantidad × PrecioUnitarioColones).</summary>
        public decimal SubtotalLinea { get; set; }

        // ── Propiedades de navegación ──

        /// <summary>Código interno del producto (cargado desde JOIN).</summary>
        public string CodigoInterno { get; set; }

        /// <summary>Nombre de la marca (cargado desde JOIN).</summary>
        public string Marca { get; set; }

        /// <summary>Nombre del modelo (cargado desde JOIN).</summary>
        public string Modelo { get; set; }

        /// <summary>Tipo de dispositivo (cargado desde JOIN).</summary>
        public string TipoDispositivo { get; set; }

        /// <summary>Color del producto (cargado desde JOIN).</summary>
        public string Color { get; set; }
    }
}
