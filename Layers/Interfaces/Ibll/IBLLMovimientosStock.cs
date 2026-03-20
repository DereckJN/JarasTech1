using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Ibll
{
    internal interface IBLLMovimientosStock
    {
        MovimientosStock SaveMovimiento(MovimientosStock movimiento);
        MovimientosStock UpdateMovimiento(MovimientosStock movimiento);
        bool DeleteMovimiento(int movimientoID);
        MovimientosStock GetMovimientoByID(int movimientoID);
        IEnumerable<MovimientosStock> GetMovimientosByProductoID(int productoID);
        IEnumerable<MovimientosStock> GetAllMovimientos();
    }
}
