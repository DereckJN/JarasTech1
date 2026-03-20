using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Ibll
{
    internal interface IBLLFacturas
    {
        Facturas SaveFactura(Facturas factura);
        Facturas UpdateFactura(Facturas factura);
        bool DeleteFactura(int facturaID);
        Facturas GetFacturaByID(int facturaID);
        IEnumerable<Facturas> GetFacturasByRangoFecha(System.DateTime fechaInicio, System.DateTime fechaFin);
        IEnumerable<Facturas> GetAllFacturas();
    }
}
