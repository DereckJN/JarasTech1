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
    internal class DALBancos : IDALBancos
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static Bancos Map(IDataReader r) => new Bancos
        {
            BancoID = r.GetInt32(r.GetOrdinal("BancoID")),
            NombreBanco = r.GetString(r.GetOrdinal("NombreBanco"))
        };

        public Bancos SaveBanco(Bancos banco)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_Bancos";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreBanco", banco.NombreBanco ?? string.Empty);
                    SqlParameter outID = new SqlParameter("@BancoID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    banco.BancoID = (int)outID.Value;
                }
                return banco;
            }
            catch (Exception er) { _log.ErrorFormat("Error SaveBanco: {0}", er.Message); throw; }
        }

        public Bancos UpdateBanco(Bancos banco)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_Bancos";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BancoID", banco.BancoID);
                    cmd.Parameters.AddWithValue("@NombreBanco", banco.NombreBanco ?? string.Empty);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetBancoByID(banco.BancoID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdateBanco: {0}", er.Message); throw; }
        }

        public bool DeleteBanco(int bancoID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_Bancos_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BancoID", bancoID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeleteBanco: {0}", er.Message); throw; }
        }

        public Bancos GetBancoByID(int bancoID)
        {
            Bancos obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Bancos_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BancoID", bancoID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = Map(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetBancoByID: {0}", er.Message); throw; }
        }

        public IEnumerable<Bancos> GetAllBancos()
        {
            var lista = new List<Bancos>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Bancos_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(Map(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetAllBancos: {0}", er.Message); throw; }
        }
    }
}
