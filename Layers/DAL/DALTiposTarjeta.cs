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
    internal class DALTiposTarjeta : IDALTiposTarjeta
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static TiposTarjeta Map(IDataReader r) => new TiposTarjeta
        {
            TipoTarjetaID = r.GetInt32(r.GetOrdinal("TipoTarjetaID")),
            NombreTarjeta = r.GetString(r.GetOrdinal("NombreTarjeta"))
        };

        public TiposTarjeta SaveTipoTarjeta(TiposTarjeta tipoTarjeta)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_TiposTarjeta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreTarjeta", tipoTarjeta.NombreTarjeta ?? string.Empty);
                    SqlParameter outID = new SqlParameter("@TipoTarjetaID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    tipoTarjeta.TipoTarjetaID = (int)outID.Value;
                }
                return tipoTarjeta;
            }
            catch (Exception er) { _log.ErrorFormat("Error SaveTipoTarjeta: {0}", er.Message); throw; }
        }

        public TiposTarjeta UpdateTipoTarjeta(TiposTarjeta tipoTarjeta)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_TiposTarjeta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoTarjetaID", tipoTarjeta.TipoTarjetaID);
                    cmd.Parameters.AddWithValue("@NombreTarjeta", tipoTarjeta.NombreTarjeta ?? string.Empty);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetTipoTarjetaByID(tipoTarjeta.TipoTarjetaID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdateTipoTarjeta: {0}", er.Message); throw; }
        }

        public bool DeleteTipoTarjeta(int tipoTarjetaID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_TiposTarjeta_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoTarjetaID", tipoTarjetaID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeleteTipoTarjeta: {0}", er.Message); throw; }
        }

        public TiposTarjeta GetTipoTarjetaByID(int tipoTarjetaID)
        {
            TiposTarjeta obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_TiposTarjeta_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoTarjetaID", tipoTarjetaID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = Map(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetTipoTarjetaByID: {0}", er.Message); throw; }
        }

        public IEnumerable<TiposTarjeta> GetAllTiposTarjeta()
        {
            var lista = new List<TiposTarjeta>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_TiposTarjeta_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(Map(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetAllTiposTarjeta: {0}", er.Message); throw; }
        }
    }
}
