using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Ibll
{
    internal interface IBLLTiposTarjeta
    {
        TiposTarjeta SaveTipoTarjeta(TiposTarjeta tipoTarjeta);
        TiposTarjeta UpdateTipoTarjeta(TiposTarjeta tipoTarjeta);
        bool DeleteTipoTarjeta(int tipoTarjetaID);
        TiposTarjeta GetTipoTarjetaByID(int tipoTarjetaID);
        IEnumerable<TiposTarjeta> GetAllTiposTarjeta();
    }
}
