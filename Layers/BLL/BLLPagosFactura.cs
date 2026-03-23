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
    internal class BLLPagosFactura : IBLLPagosFactura
    {
        private readonly IDALPagosFactura _dal = new DALPagosFactura();

        public PagosFactura SavePago(PagosFactura p) => _dal.SavePago(p);
        public PagosFactura UpdatePago(PagosFactura p) => _dal.UpdatePago(p);
        public bool DeletePago(int id) => _dal.DeletePago(id);
        public PagosFactura GetPagoByID(int id) => _dal.GetPagoByID(id);
        public PagosFactura GetPagoByFacturaID(int facturaID) => _dal.GetPagoByFacturaID(facturaID);
    }
}
