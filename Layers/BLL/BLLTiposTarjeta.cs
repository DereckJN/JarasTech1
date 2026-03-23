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
    internal class BLLTiposTarjeta : IBLLTiposTarjeta
    {
        private readonly IDALTiposTarjeta _dal = new DALTiposTarjeta();
        public TiposTarjeta SaveTipoTarjeta(TiposTarjeta t) => _dal.GetTipoTarjetaByID(t.TipoTarjetaID) != null ? _dal.UpdateTipoTarjeta(t) : _dal.SaveTipoTarjeta(t);
        public TiposTarjeta UpdateTipoTarjeta(TiposTarjeta t) => _dal.UpdateTipoTarjeta(t);
        public bool DeleteTipoTarjeta(int id) => _dal.DeleteTipoTarjeta(id);
        public TiposTarjeta GetTipoTarjetaByID(int id) => _dal.GetTipoTarjetaByID(id);
        public IEnumerable<TiposTarjeta> GetAllTiposTarjeta() => _dal.GetAllTiposTarjeta();
    }
}
