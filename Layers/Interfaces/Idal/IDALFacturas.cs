using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Idal
{
    /// <summary>Interfaz DAL para Facturas.</summary>
    internal interface IDALFacturas
    {
        Facturas SaveFactura(Facturas factura);
        Facturas UpdateFactura(Facturas factura);
        bool DeleteFactura(int facturaID);
        Facturas GetFacturaByID(int facturaID);
        /// <summary>Obtiene facturas en un rango de fechas (Reporte B).</summary>
        IEnumerable<Facturas> GetFacturasByRangoFecha(System.DateTime fechaInicio, System.DateTime fechaFin);
        IEnumerable<Facturas> GetAllFacturas();
    }
}
