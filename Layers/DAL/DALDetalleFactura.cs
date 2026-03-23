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
    internal class DALDetalleFactura : IDALDetalleFactura
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static DetalleFactura MapDetalle(IDataReader r) => new DetalleFactura
        {
            DetalleFacturaID = r.GetInt32(r.GetOrdinal("DetalleFacturaID")),
            FacturaID = r.GetInt32(r.GetOrdinal("FacturaID")),
            ProductoID = r.GetInt32(r.GetOrdinal("ProductoID")),
            Cantidad = r.GetInt32(r.GetOrdinal("Cantidad")),
            PrecioUnitarioColones = r.GetDecimal(r.GetOrdinal("PrecioUnitarioColones")),
            PrecioUnitarioDolares = r.GetDecimal(r.GetOrdinal("PrecioUnitarioDolares")),
            SubtotalLinea = r.GetDecimal(r.GetOrdinal("SubtotalLinea")),
            CodigoInterno = HasCol(r, "CodigoInterno") ? r.IsDBNull(r.GetOrdinal("CodigoInterno")) ? null : r.GetString(r.GetOrdinal("CodigoInterno")) : null,
            Marca = HasCol(r, "Marca") ? r.IsDBNull(r.GetOrdinal("Marca")) ? null : r.GetString(r.GetOrdinal("Marca")) : null,
            Modelo = HasCol(r, "Modelo") ? r.IsDBNull(r.GetOrdinal("Modelo")) ? null : r.GetString(r.GetOrdinal("Modelo")) : null,
            TipoDispositivo = HasCol(r, "TipoDispositivo") ? r.IsDBNull(r.GetOrdinal("TipoDispositivo")) ? null : r.GetString(r.GetOrdinal("TipoDispositivo")) : null,
            Color = HasCol(r, "Color") ? r.IsDBNull(r.GetOrdinal("Color")) ? null : r.GetString(r.GetOrdinal("Color")) : null
        };

        private static bool HasCol(IDataReader r, string col)
        {
            for (int i = 0; i < r.FieldCount; i++)
                if (r.GetName(i).Equals(col, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }

        public DetalleFactura SaveDetalle(DetalleFactura detalle)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_DetalleFactura";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FacturaID", detalle.FacturaID);
                    cmd.Parameters.AddWithValue("@ProductoID", detalle.ProductoID);
                    cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitarioColones", detalle.PrecioUnitarioColones);
                    cmd.Parameters.AddWithValue("@PrecioUnitarioDolares", detalle.PrecioUnitarioDolares);
                    cmd.Parameters.AddWithValue("@SubtotalLinea", detalle.SubtotalLinea);
                    SqlParameter outID = new SqlParameter("@DetalleFacturaID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    detalle.DetalleFacturaID = (int)outID.Value;
                }
                return detalle;
            }
            catch (Exception er) { _log.ErrorFormat("Error SaveDetalle: {0}", er.Message); throw; }
        }

        public DetalleFactura UpdateDetalle(DetalleFactura detalle)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_DetalleFactura";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetalleFacturaID", detalle.DetalleFacturaID);
                    cmd.Parameters.AddWithValue("@FacturaID", detalle.FacturaID);
                    cmd.Parameters.AddWithValue("@ProductoID", detalle.ProductoID);
                    cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitarioColones", detalle.PrecioUnitarioColones);
                    cmd.Parameters.AddWithValue("@PrecioUnitarioDolares", detalle.PrecioUnitarioDolares);
                    cmd.Parameters.AddWithValue("@SubtotalLinea", detalle.SubtotalLinea);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetDetalleByID(detalle.DetalleFacturaID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdateDetalle: {0}", er.Message); throw; }
        }

        public bool DeleteDetalle(int detalleFacturaID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_DetalleFactura_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetalleFacturaID", detalleFacturaID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeleteDetalle: {0}", er.Message); throw; }
        }

        public DetalleFactura GetDetalleByID(int detalleFacturaID)
        {
            DetalleFactura obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_DetalleFactura_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetalleFacturaID", detalleFacturaID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = MapDetalle(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetDetalleByID: {0}", er.Message); throw; }
        }

        /// <summary>Obtiene todas las líneas de una factura específica (con JOIN de producto).</summary>
        public IEnumerable<DetalleFactura> GetDetalleByFacturaID(int facturaID)
        {
            var lista = new List<DetalleFactura>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_DetalleFactura_ByFacturaID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FacturaID", facturaID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(MapDetalle(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetDetalleByFacturaID: {0}", er.Message); throw; }
        }
    }
}
