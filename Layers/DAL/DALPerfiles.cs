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
    internal class DALPerfiles : IDALPerfiles
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static Perfiles Map(IDataReader r) => new Perfiles
        {
            PerfilID = r.GetInt32(r.GetOrdinal("PerfilID")),
            NombrePerfil = r.GetString(r.GetOrdinal("NombrePerfil"))
        };

        public Perfiles SavePerfil(Perfiles perfil)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_Perfiles";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombrePerfil", perfil.NombrePerfil ?? string.Empty);
                    SqlParameter outID = new SqlParameter("@PerfilID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    perfil.PerfilID = (int)outID.Value;
                }
                return perfil;
            }
            catch (Exception er) { _log.ErrorFormat("Error SavePerfil: {0}", er.Message); throw; }
        }

        public Perfiles UpdatePerfil(Perfiles perfil)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_Perfiles";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PerfilID", perfil.PerfilID);
                    cmd.Parameters.AddWithValue("@NombrePerfil", perfil.NombrePerfil ?? string.Empty);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetPerfilByID(perfil.PerfilID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdatePerfil: {0}", er.Message); throw; }
        }

        public bool DeletePerfil(int perfilID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_Perfiles_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PerfilID", perfilID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeletePerfil: {0}", er.Message); throw; }
        }

        public Perfiles GetPerfilByID(int perfilID)
        {
            Perfiles obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Perfiles_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PerfilID", perfilID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = Map(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetPerfilByID: {0}", er.Message); throw; }
        }

        public IEnumerable<Perfiles> GetAllPerfiles()
        {
            var lista = new List<Perfiles>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Perfiles_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(Map(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetAllPerfiles: {0}", er.Message); throw; }
        }
    }
}
