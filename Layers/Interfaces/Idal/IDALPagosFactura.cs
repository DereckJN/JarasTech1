using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Idal
{
    /// <summary>Interfaz DAL para PagosFactura.</summary>
    internal interface IDALPagosFactura
    {
        PagosFactura SavePago(PagosFactura pago);
        PagosFactura UpdatePago(PagosFactura pago);
        bool DeletePago(int pagoID);
        PagosFactura GetPagoByID(int pagoID);
        /// <summary>Obtiene el pago asociado a una factura.</summary>
        PagosFactura GetPagoByFacturaID(int facturaID);
    }
}
