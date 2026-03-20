using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Ibll
{
    internal interface IBLLModelos
    {
        Modelos SaveModelo(Modelos modelo);
        Modelos UpdateModelo(Modelos modelo);
        bool DeleteModelo(int modeloID);
        Modelos GetModeloByID(int modeloID);
        IEnumerable<Modelos> GetAllModelos();
    }
}
