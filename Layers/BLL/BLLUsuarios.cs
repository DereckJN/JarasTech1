using JarasTech.Layers.DAL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces.Ibll;
using JarasTech.Layers.Interfaces.Idal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.BLL
{
    internal class BLLUsuarios : IBLLUsuarios
    {
        private readonly IDALUsuarios _dal = new DALUsuarios();

        public Usuarios SaveUsuario(Usuarios u) => _dal.GetUsuarioByID(u.UsuarioID) != null ? _dal.UpdateUsuario(u) : _dal.SaveUsuario(u);
        public Usuarios UpdateUsuario(Usuarios u) => _dal.UpdateUsuario(u);
        public bool DeleteUsuario(int id) => _dal.DeleteUsuario(id);
        public Usuarios GetUsuarioByID(int id) => _dal.GetUsuarioByID(id);
        public IEnumerable<Usuarios> GetAllUsuarios() => _dal.GetAllUsuarios();

        /// <summary>
        /// Valida credenciales. Retorna el usuario autenticado (con NombrePerfil) o null si falla.
        /// </summary>
        public Usuarios Login(string nombreUsuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
                return null;
            return _dal.GetUsuarioByCredenciales(nombreUsuario, contrasena);
        }
    }
}
