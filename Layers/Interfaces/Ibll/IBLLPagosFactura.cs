using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Ibll
{
    internal interface IBLLPagosFactura
    {
        PagosFactura SavePago(PagosFactura pago);
        PagosFactura UpdatePago(PagosFactura pago);
        bool DeletePago(int pagoID);
        PagosFactura GetPagoByID(int pagoID);
        PagosFactura GetPagoByFacturaID(int facturaID);
    }
}
