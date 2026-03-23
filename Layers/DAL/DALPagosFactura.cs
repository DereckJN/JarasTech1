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
    internal class DALPagosFactura : IDALPagosFactura
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static PagosFactura MapPago(IDataReader r) => new PagosFactura
        {
            PagoID = r.GetInt32(r.GetOrdinal("PagoID")),
            FacturaID = r.GetInt32(r.GetOrdinal("FacturaID")),
            TipoPagoID = r.GetInt32(r.GetOrdinal("TipoPagoID")),
            NumeroTarjeta = r.IsDBNull(r.GetOrdinal("NumeroTarjeta")) ? null : r.GetString(r.GetOrdinal("NumeroTarjeta")),
            BancoID = r.IsDBNull(r.GetOrdinal("BancoID")) ? (int?)null : r.GetInt32(r.GetOrdinal("BancoID")),
            TipoTarjetaID = r.IsDBNull(r.GetOrdinal("TipoTarjetaID")) ? (int?)null : r.GetInt32(r.GetOrdinal("TipoTarjetaID")),
            NumeroTransferencia = r.IsDBNull(r.GetOrdinal("NumeroTransferencia")) ? null : r.GetString(r.GetOrdinal("NumeroTransferencia")),
            NumeroSINPE = r.IsDBNull(r.GetOrdinal("NumeroSINPE")) ? null : r.GetString(r.GetOrdinal("NumeroSINPE")),
            NombreTipoPago = HasCol(r, "TipoPago") ? r.IsDBNull(r.GetOrdinal("TipoPago")) ? null : r.GetString(r.GetOrdinal("TipoPago")) : null,
            NombreBanco = HasCol(r, "Banco") ? r.IsDBNull(r.GetOrdinal("Banco")) ? null : r.GetString(r.GetOrdinal("Banco")) : null,
            NombreTipoTarjeta = HasCol(r, "TipoTarjeta") ? r.IsDBNull(r.GetOrdinal("TipoTarjeta")) ? null : r.GetString(r.GetOrdinal("TipoTarjeta")) : null
        };

        private static bool HasCol(IDataReader r, string col)
        {
            for (int i = 0; i < r.FieldCount; i++)
                if (r.GetName(i).Equals(col, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }

        private static void AddNullableInt(SqlCommand cmd, string name, int? value)
        {
            cmd.Parameters.Add(name, SqlDbType.Int).Value = value.HasValue ? (object)value.Value : DBNull.Value;
        }

        private static void AddNullableString(SqlCommand cmd, string name, string value)
        {
            cmd.Parameters.Add(name, SqlDbType.NVarChar).Value = value != null ? (object)value : DBNull.Value;
        }

        public PagosFactura SavePago(PagosFactura pago)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_PagosFactura";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FacturaID", pago.FacturaID);
                    cmd.Parameters.AddWithValue("@TipoPagoID", pago.TipoPagoID);
                    AddNullableString(cmd, "@NumeroTarjeta", pago.NumeroTarjeta);
                    AddNullableInt(cmd, "@BancoID", pago.BancoID);
                    AddNullableInt(cmd, "@TipoTarjetaID", pago.TipoTarjetaID);
                    AddNullableString(cmd, "@NumeroTransferencia", pago.NumeroTransferencia);
                    AddNullableString(cmd, "@NumeroSINPE", pago.NumeroSINPE);
                    SqlParameter outID = new SqlParameter("@PagoID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    pago.PagoID = (int)outID.Value;
                }
                return pago;
            }
            catch (Exception er) { _log.ErrorFormat("Error SavePago: {0}", er.Message); throw; }
        }

        public PagosFactura UpdatePago(PagosFactura pago)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_PagosFactura";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PagoID", pago.PagoID);
                    cmd.Parameters.AddWithValue("@FacturaID", pago.FacturaID);
                    cmd.Parameters.AddWithValue("@TipoPagoID", pago.TipoPagoID);
                    AddNullableString(cmd, "@NumeroTarjeta", pago.NumeroTarjeta);
                    AddNullableInt(cmd, "@BancoID", pago.BancoID);
                    AddNullableInt(cmd, "@TipoTarjetaID", pago.TipoTarjetaID);
                    AddNullableString(cmd, "@NumeroTransferencia", pago.NumeroTransferencia);
                    AddNullableString(cmd, "@NumeroSINPE", pago.NumeroSINPE);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetPagoByID(pago.PagoID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdatePago: {0}", er.Message); throw; }
        }

        public bool DeletePago(int pagoID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_PagosFactura_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PagoID", pagoID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeletePago: {0}", er.Message); throw; }
        }

        public PagosFactura GetPagoByID(int pagoID)
        {
            PagosFactura obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_PagosFactura_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PagoID", pagoID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = MapPago(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetPagoByID: {0}", er.Message); throw; }
        }

        public PagosFactura GetPagoByFacturaID(int facturaID)
        {
            PagosFactura obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_PagosFactura_ByFacturaID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FacturaID", facturaID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = MapPago(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetPagoByFacturaID: {0}", er.Message); throw; }
        }
    }
}
