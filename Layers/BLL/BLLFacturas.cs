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
    internal class BLLFacturas : IBLLFacturas
    {
        private readonly IDALFacturas _dal = new DALFacturas();

        public Facturas SaveFactura(Facturas f) => _dal.SaveFactura(f);  // siempre INSERT en facturación
        public Facturas UpdateFactura(Facturas f) => _dal.UpdateFactura(f);
        public bool DeleteFactura(int id) => _dal.DeleteFactura(id);
        public Facturas GetFacturaByID(int id) => _dal.GetFacturaByID(id);
        public IEnumerable<Facturas> GetFacturasByRangoFecha(DateTime fi, DateTime ff) => _dal.GetFacturasByRangoFecha(fi, ff);
        public IEnumerable<Facturas> GetAllFacturas() => _dal.GetAllFacturas();
    }
}
