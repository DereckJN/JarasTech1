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
    internal class BLLTiposPago : IBLLTiposPago
    {
        private readonly IDALTiposPago _dal = new DALTiposPago();
        public TiposPago SaveTipoPago(TiposPago t) => _dal.GetTipoPagoByID(t.TipoPagoID) != null ? _dal.UpdateTipoPago(t) : _dal.SaveTipoPago(t);
        public TiposPago UpdateTipoPago(TiposPago t) => _dal.UpdateTipoPago(t);
        public bool DeleteTipoPago(int id) => _dal.DeleteTipoPago(id);
        public TiposPago GetTipoPagoByID(int id) => _dal.GetTipoPagoByID(id);
        public IEnumerable<TiposPago> GetAllTiposPago() => _dal.GetAllTiposPago();
    }
}
