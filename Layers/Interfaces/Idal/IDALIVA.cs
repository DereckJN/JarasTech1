using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Idal
{

    /// <summary>Interfaz DAL para IVA.</summary>
    internal interface IDALIVA
    {
        IVA SaveIVA(IVA iva);
        IVA UpdateIVA(IVA iva);
        bool DeleteIVA(int ivaID);
        IVA GetIVAByID(int ivaID);
        IEnumerable<IVA> GetAllIVA();
    }
}
