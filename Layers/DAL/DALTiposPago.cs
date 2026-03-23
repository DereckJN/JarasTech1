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
    internal class DALTiposPago : IDALTiposPago
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static TiposPago Map(IDataReader r) => new TiposPago
        {
            TipoPagoID = r.GetInt32(r.GetOrdinal("TipoPagoID")),
            NombreTipo = r.GetString(r.GetOrdinal("NombreTipo"))
        };

        public TiposPago SaveTipoPago(TiposPago tipoPago)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_TiposPago";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreTipo", tipoPago.NombreTipo ?? string.Empty);
                    SqlParameter outID = new SqlParameter("@TipoPagoID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    tipoPago.TipoPagoID = (int)outID.Value;
                }
                return tipoPago;
            }
            catch (Exception er) { _log.ErrorFormat("Error SaveTipoPago: {0}", er.Message); throw; }
        }

        public TiposPago UpdateTipoPago(TiposPago tipoPago)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_TiposPago";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoPagoID", tipoPago.TipoPagoID);
                    cmd.Parameters.AddWithValue("@NombreTipo", tipoPago.NombreTipo ?? string.Empty);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetTipoPagoByID(tipoPago.TipoPagoID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdateTipoPago: {0}", er.Message); throw; }
        }

        public bool DeleteTipoPago(int tipoPagoID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_TiposPago_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoPagoID", tipoPagoID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeleteTipoPago: {0}", er.Message); throw; }
        }

        public TiposPago GetTipoPagoByID(int tipoPagoID)
        {
            TiposPago obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_TiposPago_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoPagoID", tipoPagoID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = Map(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetTipoPagoByID: {0}", er.Message); throw; }
        }

        public IEnumerable<TiposPago> GetAllTiposPago()
        {
            var lista = new List<TiposPago>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_TiposPago_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(Map(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetAllTiposPago: {0}", er.Message); throw; }
        }
    }
}
