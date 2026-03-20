using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Ibll
{
    internal interface IBLLDetalleFactura
    {
        DetalleFactura SaveDetalle(DetalleFactura detalle);
        DetalleFactura UpdateDetalle(DetalleFactura detalle);
        bool DeleteDetalle(int detalleFacturaID);
        DetalleFactura GetDetalleByID(int detalleFacturaID);
        IEnumerable<DetalleFactura> GetDetalleByFacturaID(int facturaID);
    }
}
