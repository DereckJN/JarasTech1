using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Idal
{
    /// <summary>Interfaz DAL para TiposPago.</summary>
    internal interface IDALTiposPago
    {
        TiposPago SaveTipoPago(TiposPago tipoPago);
        TiposPago UpdateTipoPago(TiposPago tipoPago);
        bool DeleteTipoPago(int tipoPagoID);
        TiposPago GetTipoPagoByID(int tipoPagoID);
        IEnumerable<TiposPago> GetAllTiposPago();
    }
}
