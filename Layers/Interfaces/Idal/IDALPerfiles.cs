using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Idal
{

    /// <summary>Interfaz DAL para Perfiles.</summary>
    internal interface IDALPerfiles
    {
        Perfiles SavePerfil(Perfiles perfil);
        Perfiles UpdatePerfil(Perfiles perfil);
        bool DeletePerfil(int perfilID);
        Perfiles GetPerfilByID(int perfilID);
        IEnumerable<Perfiles> GetAllPerfiles();
    }
}
