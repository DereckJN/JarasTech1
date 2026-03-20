using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Ibll
{
    internal interface IBLLTiposMovimientoStock
    {
        TiposMovimientoStock SaveTipoMovimiento(TiposMovimientoStock tipo);
        TiposMovimientoStock UpdateTipoMovimiento(TiposMovimientoStock tipo);
        bool DeleteTipoMovimiento(int tipoMovimientoID);
        TiposMovimientoStock GetTipoMovimientoByID(int tipoMovimientoID);
        IEnumerable<TiposMovimientoStock> GetAllTiposMovimiento();
    }
}
