using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Idal
{
    internal interface IDALMarcas
    {
        Marcas SaveMarca(Marcas marca);
        Marcas UpdateMarca(Marcas marca);
        bool DeleteMarca(int marcaID);
        Marcas GetMarcaByID(int marcaID);
        IEnumerable<Marcas> GetAllMarcas();
    }
}
