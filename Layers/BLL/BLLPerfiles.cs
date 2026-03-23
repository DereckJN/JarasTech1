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
    internal class BLLPerfiles : IBLLPerfiles
    {
        private readonly IDALPerfiles _dal = new DALPerfiles();
        public Perfiles SavePerfil(Perfiles p) => _dal.GetPerfilByID(p.PerfilID) != null ? _dal.UpdatePerfil(p) : _dal.SavePerfil(p);
        public Perfiles UpdatePerfil(Perfiles p) => _dal.UpdatePerfil(p);
        public bool DeletePerfil(int id) => _dal.DeletePerfil(id);
        public Perfiles GetPerfilByID(int id) => _dal.GetPerfilByID(id);
        public IEnumerable<Perfiles> GetAllPerfiles() => _dal.GetAllPerfiles();
    }
}
