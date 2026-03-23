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
    internal class BLLDetalleFactura : IBLLDetalleFactura
    {
        private readonly IDALDetalleFactura _dal = new DALDetalleFactura();

        public DetalleFactura SaveDetalle(DetalleFactura d) => _dal.SaveDetalle(d);
        public DetalleFactura UpdateDetalle(DetalleFactura d) => _dal.UpdateDetalle(d);
        public bool DeleteDetalle(int id) => _dal.DeleteDetalle(id);
        public DetalleFactura GetDetalleByID(int id) => _dal.GetDetalleByID(id);
        public IEnumerable<DetalleFactura> GetDetalleByFacturaID(int facturaID) => _dal.GetDetalleByFacturaID(facturaID);
    }
}
