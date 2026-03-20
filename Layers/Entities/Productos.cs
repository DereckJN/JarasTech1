using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    /// <summary>
    /// Entidad que representa un producto electrónico en el inventario de JarasTech.
    /// </summary>
    internal class Productos
    {
        /// <summary>Identificador único del producto.</summary>
        public int ProductoID { get; set; }

        /// <summary>Código interno del producto (generado por la empresa).</summary>
        public string CodigoInterno { get; set; }

        /// <summary>Código de industria / código de barras del fabricante.</summary>
        public string CodigoIndustria { get; set; }

        /// <summary>ID del tipo de dispositivo (Smartphone, Tablet, Laptop, etc.).</summary>
        public int TipoDispositivoID { get; set; }

        /// <summary>ID del modelo del producto.</summary>
        public int ModeloID { get; set; }

        /// <summary>ID de la marca del producto.</summary>
        public int MarcaID { get; set; }

        /// <summary>Color del dispositivo.</summary>
        public string Color { get; set; }

        /// <summary>Características técnicas del producto (RAM, almacenamiento, etc.).</summary>
        public string Caracteristicas { get; set; }

        /// <summary>Fotografía del producto almacenada como arreglo de bytes.</summary>
        public byte[] Fotografia { get; set; }

        /// <summary>Documento de especificaciones (PDF o DOCX) en bytes.</summary>
        public byte[] DocumentoEspecificaciones { get; set; }

        /// <summary>Nombre del archivo del documento de especificaciones.</summary>
        public string NombreDocumento { get; set; }

        /// <summary>Extras o accesorios incluidos con el producto.</summary>
        public string Extras { get; set; }

        /// <summary>Cantidad disponible en inventario.</summary>
        public int CantidadStock { get; set; }

        /// <summary>Precio de venta en colones costarricenses.</summary>
        public decimal PrecioColones { get; set; }

        /// <summary>Precio de venta en dólares (calculado según tipo de cambio BCCR).</summary>
        public decimal PrecioDolares { get; set; }

        /// <summary>Estado del producto: true = activo, false = inactivo.</summary>
        public bool Estado { get; set; }

        // ── Propiedades de navegación (para mostrar en UI sin joins adicionales) ──

        /// <summary>Nombre de la marca (cargado desde JOIN).</summary>
        public string NombreMarca { get; set; }

        /// <summary>Nombre del modelo (cargado desde JOIN).</summary>
        public string NombreModelo { get; set; }

        /// <summary>Nombre del tipo de dispositivo (cargado desde JOIN).</summary>
        public string NombreTipoDispositivo { get; set; }

        /// <summary>Indica si el producto tiene stock disponible.</summary>
        public bool HayStock => CantidadStock > 0;
    }
}
