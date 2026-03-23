using JarasTech.Layers.DAL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces.Ibll;
using JarasTech.Layers.Interfaces.Idal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.BLL
{
    internal class BLLMovimientosStock : IBLLMovimientosStock
    {
        private readonly IDALMovimientosStock _dal = new DALMovimientosStock();

        public MovimientosStock SaveMovimiento(MovimientosStock m) => _dal.SaveMovimiento(m);
        public MovimientosStock UpdateMovimiento(MovimientosStock m) => _dal.UpdateMovimiento(m);
        public bool DeleteMovimiento(int id) => _dal.DeleteMovimiento(id);
        public MovimientosStock GetMovimientoByID(int id) => _dal.GetMovimientoByID(id);
        public IEnumerable<MovimientosStock> GetMovimientosByProductoID(int productoID) => _dal.GetMovimientosByProductoID(productoID);
        public IEnumerable<MovimientosStock> GetAllMovimientos() => _dal.GetAllMovimientos();
    }
}
