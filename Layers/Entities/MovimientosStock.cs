using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>
    /// Entidad que representa un movimiento de inventario (entrada o salida de stock).
    /// </summary>
    internal class MovimientosStock
    {
        /// <summary>Identificador único del movimiento.</summary>
        public int MovimientoID { get; set; }

        /// <summary>ID del producto al que aplica el movimiento.</summary>
        public int ProductoID { get; set; }

        /// <summary>ID del tipo de movimiento (Entrada / Salida).</summary>
        public int TipoMovimientoID { get; set; }

        /// <summary>Cantidad de unidades del movimiento.</summary>
        public int Cantidad { get; set; }

        /// <summary>Fecha y hora del movimiento.</summary>
        public DateTime FechaMovimiento { get; set; }

        /// <summary>Número de factura de compra (para entradas de mercadería).</summary>
        public string FacturaCompra { get; set; }

        /// <summary>Observaciones adicionales del movimiento.</summary>
        public string Observaciones { get; set; }

        /// <summary>ID del usuario que registró el movimiento.</summary>
        public int UsuarioID { get; set; }

        // ── Propiedades de navegación ──

        /// <summary>Código interno del producto (cargado desde JOIN).</summary>
        public string CodigoProducto { get; set; }

        /// <summary>Nombre del tipo de movimiento (cargado desde JOIN).</summary>
        public string NombreTipoMovimiento { get; set; }

        /// <summary>Nombre del usuario que registró (cargado desde JOIN).</summary>
        public string NombreUsuario { get; set; }
    }
}
