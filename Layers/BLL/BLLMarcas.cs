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
    internal class BLLMarcas : IBLLMarcas
    {
        private readonly IDALMarcas _dal = new DALMarcas();
        public Marcas SaveMarca(Marcas m) => _dal.GetMarcaByID(m.MarcaID) != null ? _dal.UpdateMarca(m) : _dal.SaveMarca(m);
        public Marcas UpdateMarca(Marcas m) => _dal.UpdateMarca(m);
        public bool DeleteMarca(int id) => _dal.DeleteMarca(id);
        public Marcas GetMarcaByID(int id) => _dal.GetMarcaByID(id);
        public IEnumerable<Marcas> GetAllMarcas() => _dal.GetAllMarcas();
    }
}
