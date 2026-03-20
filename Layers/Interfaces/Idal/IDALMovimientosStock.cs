using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Idal
{
    /// <summary>Interfaz DAL para MovimientosStock.</summary>
    internal interface IDALMovimientosStock
    {
        MovimientosStock SaveMovimiento(MovimientosStock movimiento);
        MovimientosStock UpdateMovimiento(MovimientosStock movimiento);
        bool DeleteMovimiento(int movimientoID);
        MovimientosStock GetMovimientoByID(int movimientoID);
        /// <summary>Obtiene el historial de movimientos de un producto.</summary>
        IEnumerable<MovimientosStock> GetMovimientosByProductoID(int productoID);
        IEnumerable<MovimientosStock> GetAllMovimientos();
    }
}
