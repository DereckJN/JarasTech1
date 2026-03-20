using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Idal
{
    /// <summary>Interfaz DAL para TiposIdentificacion.</summary>
    internal interface IDALTiposIdentificacion
    {
        TiposIdentificacion SaveTipoIdentificacion(TiposIdentificacion tipo);
        TiposIdentificacion UpdateTipoIdentificacion(TiposIdentificacion tipo);
        bool DeleteTipoIdentificacion(int tipoIdentificacionID);
        TiposIdentificacion GetTipoIdentificacionByID(int tipoIdentificacionID);
        IEnumerable<TiposIdentificacion> GetAllTiposIdentificacion();
    }
}
