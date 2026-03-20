using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces.Ibll
{
    internal interface IBLLUsuarios
    {
        Usuarios SaveUsuario(Usuarios usuario);
        Usuarios UpdateUsuario(Usuarios usuario);
        bool DeleteUsuario(int usuarioID);
        Usuarios GetUsuarioByID(int usuarioID);
        Usuarios Login(string nombreUsuario, string contrasena);
        IEnumerable<Usuarios> GetAllUsuarios();
    }
}
