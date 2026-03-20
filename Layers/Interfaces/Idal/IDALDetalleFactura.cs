using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Idal
{
    /// <summary>Interfaz DAL para DetalleFactura.</summary>
    internal interface IDALDetalleFactura
    {
        DetalleFactura SaveDetalle(DetalleFactura detalle);
        DetalleFactura UpdateDetalle(DetalleFactura detalle);
        bool DeleteDetalle(int detalleFacturaID);
        DetalleFactura GetDetalleByID(int detalleFacturaID);
        /// <summary>Obtiene todas las líneas de una factura específica.</summary>
        IEnumerable<DetalleFactura> GetDetalleByFacturaID(int facturaID);
    }
}
