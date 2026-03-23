using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces.Idal;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.DAL
{
    internal class DALUsuarios : IDALUsuarios
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static Usuarios MapUsuario(IDataReader r) => new Usuarios
        {
            UsuarioID = r.GetInt32(r.GetOrdinal("UsuarioID")),
            NombreUsuario = r.GetString(r.GetOrdinal("NombreUsuario")),
            Contrasena = r.GetString(r.GetOrdinal("Contrasena")),
            PerfilID = r.GetInt32(r.GetOrdinal("PerfilID")),
            Estado = r.GetBoolean(r.GetOrdinal("Estado")),
            NombrePerfil = HasColumn(r, "NombrePerfil") && !r.IsDBNull(r.GetOrdinal("NombrePerfil"))
                                ? r.GetString(r.GetOrdinal("NombrePerfil")) : null
        };

        private static bool HasColumn(IDataReader r, string col)
        {
            for (int i = 0; i < r.FieldCount; i++)
                if (r.GetName(i).Equals(col, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }

        /// <summary>Guarda un nuevo usuario.</summary>
        public Usuarios SaveUsuario(Usuarios usuario)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_Usuarios";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena ?? string.Empty);
                    cmd.Parameters.AddWithValue("@PerfilID", usuario.PerfilID);
                    cmd.Parameters.AddWithValue("@Estado", usuario.Estado);
                    SqlParameter outID = new SqlParameter("@UsuarioID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    usuario.UsuarioID = (int)outID.Value;
                }
                return usuario;
            }
            catch (Exception er) { _log.ErrorFormat("Error SaveUsuario: {0}", er.Message); throw; }
        }

        /// <summary>Actualiza los datos de un usuario.</summary>
        public Usuarios UpdateUsuario(Usuarios usuario)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_Usuarios";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena ?? string.Empty);
                    cmd.Parameters.AddWithValue("@PerfilID", usuario.PerfilID);
                    cmd.Parameters.AddWithValue("@Estado", usuario.Estado);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetUsuarioByID(usuario.UsuarioID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdateUsuario: {0}", er.Message); throw; }
        }

        /// <summary>Elimina un usuario por su ID.</summary>
        public bool DeleteUsuario(int usuarioID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_Usuarios_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeleteUsuario: {0}", er.Message); throw; }
        }

        /// <summary>Obtiene un usuario por su ID.</summary>
        public Usuarios GetUsuarioByID(int usuarioID)
        {
            Usuarios obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Usuarios_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = MapUsuario(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetUsuarioByID: {0}", er.Message); throw; }
        }

        /// <summary>
        /// Valida credenciales de login.
        /// Retorna el usuario con NombrePerfil cargado, o null si las credenciales son incorrectas.
        /// </summary>
        public Usuarios GetUsuarioByCredenciales(string nombreUsuario, string contrasena)
        {
            Usuarios obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Usuarios_ByCredenciales";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena ?? string.Empty);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = MapUsuario(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetUsuarioByCredenciales: {0}", er.Message); throw; }
        }

        /// <summary>Obtiene todos los usuarios.</summary>
        public IEnumerable<Usuarios> GetAllUsuarios()
        {
            var lista = new List<Usuarios>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Usuarios_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(MapUsuario(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetAllUsuarios: {0}", er.Message); throw; }
        }
    }
}
