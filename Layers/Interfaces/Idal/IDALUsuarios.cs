using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Idal
{
    /// <summary>Interfaz DAL para Usuarios.</summary>
    internal interface IDALUsuarios
    {
        Usuarios SaveUsuario(Usuarios usuario);
        Usuarios UpdateUsuario(Usuarios usuario);
        bool DeleteUsuario(int usuarioID);
        Usuarios GetUsuarioByID(int usuarioID);
        /// <summary>Valida credenciales de login y retorna el usuario con su perfil.</summary>
        Usuarios GetUsuarioByCredenciales(string nombreUsuario, string contrasena);
        IEnumerable<Usuarios> GetAllUsuarios();
    }
}
