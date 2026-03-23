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
    internal class BLLModelos : IBLLModelos
    {
        private readonly IDALModelos _dal = new DALModelos();
        public Modelos SaveModelo(Modelos m) => _dal.GetModeloByID(m.ModeloID) != null ? _dal.UpdateModelo(m) : _dal.SaveModelo(m);
        public Modelos UpdateModelo(Modelos m) => _dal.UpdateModelo(m);
        public bool DeleteModelo(int id) => _dal.DeleteModelo(id);
        public Modelos GetModeloByID(int id) => _dal.GetModeloByID(id);
        public IEnumerable<Modelos> GetAllModelos() => _dal.GetAllModelos();
    }
}
