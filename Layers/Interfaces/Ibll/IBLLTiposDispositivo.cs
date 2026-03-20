using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Ibll
{
    internal interface IBLLTiposDispositivo
    {
        TiposDispositivo SaveTipoDispositivo(TiposDispositivo tipo);
        TiposDispositivo UpdateTipoDispositivo(TiposDispositivo tipo);
        bool DeleteTipoDispositivo(int tipoDispositivoID);
        TiposDispositivo GetTipoDispositivoByID(int tipoDispositivoID);
        IEnumerable<TiposDispositivo> GetAllTiposDispositivo();
    }
}
