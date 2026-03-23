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
    internal class BLLBancos : IBLLBancos
    {
        private readonly IDALBancos _dal = new DALBancos();
        public Bancos SaveBanco(Bancos b) => _dal.GetBancoByID(b.BancoID) != null ? _dal.UpdateBanco(b) : _dal.SaveBanco(b);
        public Bancos UpdateBanco(Bancos b) => _dal.UpdateBanco(b);
        public bool DeleteBanco(int id) => _dal.DeleteBanco(id);
        public Bancos GetBancoByID(int id) => _dal.GetBancoByID(id);
        public IEnumerable<Bancos> GetAllBancos() => _dal.GetAllBancos();
    }
}
