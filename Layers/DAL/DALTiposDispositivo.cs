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
    internal class DALTiposDispositivo : IDALTiposDispositivo
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static TiposDispositivo Map(IDataReader r) => new TiposDispositivo
        {
            TipoDispositivoID = r.GetInt32(r.GetOrdinal("TipoDispositivoID")),
            NombreTipo = r.GetString(r.GetOrdinal("NombreTipo"))
        };

        public TiposDispositivo SaveTipoDispositivo(TiposDispositivo tipo)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_TiposDispositivo";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreTipo", tipo.NombreTipo ?? string.Empty);
                    SqlParameter outID = new SqlParameter("@TipoDispositivoID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    tipo.TipoDispositivoID = (int)outID.Value;
                }
                return tipo;
            }
            catch (Exception er) { _log.ErrorFormat("Error SaveTipoDispositivo: {0}", er.Message); throw; }
        }

        public TiposDispositivo UpdateTipoDispositivo(TiposDispositivo tipo)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_TiposDispositivo";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoDispositivoID", tipo.TipoDispositivoID);
                    cmd.Parameters.AddWithValue("@NombreTipo", tipo.NombreTipo ?? string.Empty);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetTipoDispositivoByID(tipo.TipoDispositivoID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdateTipoDispositivo: {0}", er.Message); throw; }
        }

        public bool DeleteTipoDispositivo(int tipoDispositivoID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_TiposDispositivo_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoDispositivoID", tipoDispositivoID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeleteTipoDispositivo: {0}", er.Message); throw; }
        }

        public TiposDispositivo GetTipoDispositivoByID(int tipoDispositivoID)
        {
            TiposDispositivo obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_TiposDispositivo_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoDispositivoID", tipoDispositivoID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = Map(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetTipoDispositivoByID: {0}", er.Message); throw; }
        }

        public IEnumerable<TiposDispositivo> GetAllTiposDispositivo()
        {
            var lista = new List<TiposDispositivo>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_TiposDispositivo_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(Map(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetAllTiposDispositivo: {0}", er.Message); throw; }
        }

    }
}
