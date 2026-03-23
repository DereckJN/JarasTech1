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
    internal class BLLTiposDispositivo : IBLLTiposDispositivo
    {
        private readonly IDALTiposDispositivo _dal = new DALTiposDispositivo();
        public TiposDispositivo SaveTipoDispositivo(TiposDispositivo t) => _dal.GetTipoDispositivoByID(t.TipoDispositivoID) != null ? _dal.UpdateTipoDispositivo(t) : _dal.SaveTipoDispositivo(t);
        public TiposDispositivo UpdateTipoDispositivo(TiposDispositivo t) => _dal.UpdateTipoDispositivo(t);
        public bool DeleteTipoDispositivo(int id) => _dal.DeleteTipoDispositivo(id);
        public TiposDispositivo GetTipoDispositivoByID(int id) => _dal.GetTipoDispositivoByID(id);
        public IEnumerable<TiposDispositivo> GetAllTiposDispositivo() => _dal.GetAllTiposDispositivo();
    }
}
