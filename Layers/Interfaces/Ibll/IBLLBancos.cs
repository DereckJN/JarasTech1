using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Ibll
{
    internal interface IBLLBancos
    {
        Bancos SaveBanco(Bancos banco);
        Bancos UpdateBanco(Bancos banco);
        bool DeleteBanco(int bancoID);
        Bancos GetBancoByID(int bancoID);
        IEnumerable<Bancos> GetAllBancos();
    }
}
