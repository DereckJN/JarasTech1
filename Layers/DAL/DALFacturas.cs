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
    internal class DALFacturas : IDALFacturas
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static Facturas MapFactura(IDataReader r) => new Facturas
        {
            FacturaID = r.GetInt32(r.GetOrdinal("FacturaID")),
            ClienteID = r.GetInt32(r.GetOrdinal("ClienteID")),
            UsuarioID = r.GetInt32(r.GetOrdinal("UsuarioID")),
            FechaFactura = r.GetDateTime(r.GetOrdinal("FechaFactura")),
            SubtotalColones = r.GetDecimal(r.GetOrdinal("SubtotalColones")),
            MontoIVA = r.GetDecimal(r.GetOrdinal("MontoIVA")),
            TotalColones = r.GetDecimal(r.GetOrdinal("TotalColones")),
            TipoCambio = r.GetDecimal(r.GetOrdinal("TipoCambio")),
            TotalDolares = r.GetDecimal(r.GetOrdinal("TotalDolares")),
            IVAID = r.GetInt32(r.GetOrdinal("IVAID")),
            FirmaDigital = r.IsDBNull(r.GetOrdinal("FirmaDigital")) ? null : (byte[])r["FirmaDigital"],
            Estado = r.GetBoolean(r.GetOrdinal("Estado")),
            // Propiedades de navegación presentes en SPs con JOIN
            NombreCliente = HasCol(r, "NombreCliente") ? r.IsDBNull(r.GetOrdinal("NombreCliente")) ? null : r.GetString(r.GetOrdinal("NombreCliente")) : null,
            NombreVendedor = HasCol(r, "NombreVendedor") ? r.IsDBNull(r.GetOrdinal("NombreVendedor")) ? null : r.GetString(r.GetOrdinal("NombreVendedor")) : null,
            CorreoCliente = HasCol(r, "CorreoElectronico") ? r.IsDBNull(r.GetOrdinal("CorreoElectronico")) ? null : r.GetString(r.GetOrdinal("CorreoElectronico")) : null
        };

        private static Facturas MapFacturaReporte(IDataReader r) => new Facturas
        {
            FacturaID = r.GetInt32(r.GetOrdinal("FacturaID")),
            ClienteID = HasCol(r, "ClienteID") ? r.GetInt32(r.GetOrdinal("ClienteID")) : 0,
            UsuarioID = HasCol(r, "UsuarioID") ? r.GetInt32(r.GetOrdinal("UsuarioID")) : 0,
            FechaFactura = r.GetDateTime(r.GetOrdinal("FechaFactura")),
            SubtotalColones = HasCol(r, "SubtotalColones") ? r.GetDecimal(r.GetOrdinal("SubtotalColones")) : 0m,
            MontoIVA = HasCol(r, "MontoIVA") ? r.GetDecimal(r.GetOrdinal("MontoIVA")) : 0m,
            TotalColones = HasCol(r, "TotalColones") ? r.GetDecimal(r.GetOrdinal("TotalColones")) : 0m,
            TipoCambio = HasCol(r, "TipoCambio") ? r.GetDecimal(r.GetOrdinal("TipoCambio")) : 0m,
            TotalDolares = HasCol(r, "TotalDolares") ? r.GetDecimal(r.GetOrdinal("TotalDolares")) : 0m,
            IVAID = HasCol(r, "IVAID") ? r.GetInt32(r.GetOrdinal("IVAID")) : 0,
            FirmaDigital = HasCol(r, "FirmaDigital") && !r.IsDBNull(r.GetOrdinal("FirmaDigital"))
        ? (byte[])r["FirmaDigital"]
        : null,
            Estado = HasCol(r, "Estado") && !r.IsDBNull(r.GetOrdinal("Estado"))
        && r.GetBoolean(r.GetOrdinal("Estado")),
            NombreCliente = HasCol(r, "NombreCliente") && !r.IsDBNull(r.GetOrdinal("NombreCliente"))
        ? r.GetString(r.GetOrdinal("NombreCliente"))
        : null,
            NombreVendedor = HasCol(r, "Vendedor") && !r.IsDBNull(r.GetOrdinal("Vendedor"))
        ? r.GetString(r.GetOrdinal("Vendedor"))
        : null,
            CorreoCliente = HasCol(r, "CorreoElectronico") && !r.IsDBNull(r.GetOrdinal("CorreoElectronico"))
        ? r.GetString(r.GetOrdinal("CorreoElectronico"))
        : null
        };


        private static bool HasCol(IDataReader r, string col)
        {
            for (int i = 0; i < r.FieldCount; i++)
                if (r.GetName(i).Equals(col, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }

        /// <summary>Guarda una nueva factura y retorna su ID generado.</summary>
        public Facturas SaveFactura(Facturas factura)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_Facturas";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ClienteID", factura.ClienteID);
                    cmd.Parameters.AddWithValue("@UsuarioID", factura.UsuarioID);
                    cmd.Parameters.AddWithValue("@FechaFactura", factura.FechaFactura);
                    cmd.Parameters.AddWithValue("@SubtotalColones", factura.SubtotalColones);
                    cmd.Parameters.AddWithValue("@MontoIVA", factura.MontoIVA);
                    cmd.Parameters.AddWithValue("@TotalColones", factura.TotalColones);
                    cmd.Parameters.AddWithValue("@TipoCambio", factura.TipoCambio);
                    cmd.Parameters.AddWithValue("@TotalDolares", factura.TotalDolares);
                    cmd.Parameters.AddWithValue("@IVAID", factura.IVAID);
                    cmd.Parameters.AddWithValue("@Estado", factura.Estado);

                    // XML puede ser null al crear; se actualiza luego de generar el XML completo
                    if (!string.IsNullOrEmpty(factura.XMLFactura))
                        cmd.Parameters.AddWithValue("@XMLFactura", factura.XMLFactura);
                    else
                        cmd.Parameters.Add("@XMLFactura", SqlDbType.Xml).Value = DBNull.Value;

                    // Firma digital
                    if (factura.FirmaDigital != null && factura.FirmaDigital.Length > 0)
                        cmd.Parameters.AddWithValue("@FirmaDigital", factura.FirmaDigital);
                    else
                        cmd.Parameters.Add("@FirmaDigital", SqlDbType.VarBinary).Value = DBNull.Value;

                    SqlParameter outID = new SqlParameter("@FacturaID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);

                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    factura.FacturaID = (int)outID.Value;
                }
                return factura;
            }
            catch (Exception er) { _log.ErrorFormat("Error SaveFactura: {0}", er.Message); throw; }
        }

        /// <summary>Actualiza una factura existente (incluye XML y firma digital).</summary>
        public Facturas UpdateFactura(Facturas factura)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_Facturas";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FacturaID", factura.FacturaID);
                    cmd.Parameters.AddWithValue("@ClienteID", factura.ClienteID);
                    cmd.Parameters.AddWithValue("@UsuarioID", factura.UsuarioID);
                    cmd.Parameters.AddWithValue("@FechaFactura", factura.FechaFactura);
                    cmd.Parameters.AddWithValue("@SubtotalColones", factura.SubtotalColones);
                    cmd.Parameters.AddWithValue("@MontoIVA", factura.MontoIVA);
                    cmd.Parameters.AddWithValue("@TotalColones", factura.TotalColones);
                    cmd.Parameters.AddWithValue("@TipoCambio", factura.TipoCambio);
                    cmd.Parameters.AddWithValue("@TotalDolares", factura.TotalDolares);
                    cmd.Parameters.AddWithValue("@IVAID", factura.IVAID);
                    cmd.Parameters.AddWithValue("@Estado", factura.Estado);

                    if (!string.IsNullOrEmpty(factura.XMLFactura))
                        cmd.Parameters.AddWithValue("@XMLFactura", factura.XMLFactura);
                    else
                        cmd.Parameters.Add("@XMLFactura", SqlDbType.Xml).Value = DBNull.Value;

                    if (factura.FirmaDigital != null && factura.FirmaDigital.Length > 0)
                        cmd.Parameters.AddWithValue("@FirmaDigital", factura.FirmaDigital);
                    else
                        cmd.Parameters.Add("@FirmaDigital", SqlDbType.VarBinary).Value = DBNull.Value;

                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetFacturaByID(factura.FacturaID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdateFactura: {0}", er.Message); throw; }
        }

        /// <summary>Elimina una factura por su ID.</summary>
        public bool DeleteFactura(int facturaID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_Facturas_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FacturaID", facturaID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeleteFactura: {0}", er.Message); throw; }
        }

        /// <summary>Obtiene una factura por su ID.</summary>
        public Facturas GetFacturaByID(int facturaID)
        {
            Facturas obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Facturas_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FacturaID", facturaID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = MapFactura(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetFacturaByID: {0}", er.Message); throw; }
        }

        /// <summary>Obtiene facturas en un rango de fechas (Reporte B).</summary>
        public IEnumerable<Facturas> GetFacturasByRangoFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            var lista = new List<Facturas>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Facturas_ByRangoFecha";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(MapFacturaReporte(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetFacturasByRangoFecha: {0}", er.Message); throw; }
        }

        /// <summary>Obtiene todas las facturas.</summary>
        public IEnumerable<Facturas> GetAllFacturas()
        {
            var lista = new List<Facturas>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Facturas_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(MapFactura(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetAllFacturas: {0}", er.Message); throw; }
        }
    }
}
