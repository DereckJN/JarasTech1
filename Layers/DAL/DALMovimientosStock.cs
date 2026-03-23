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
    internal class DALMovimientosStock : IDALMovimientosStock
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static MovimientosStock MapMovimiento(IDataReader r) => new MovimientosStock
        {
            MovimientoID = r.GetInt32(r.GetOrdinal("MovimientoID")),
            ProductoID = r.GetInt32(r.GetOrdinal("ProductoID")),
            TipoMovimientoID = r.GetInt32(r.GetOrdinal("TipoMovimientoID")),
            Cantidad = r.GetInt32(r.GetOrdinal("Cantidad")),
            FechaMovimiento = r.GetDateTime(r.GetOrdinal("FechaMovimiento")),
            FacturaCompra = r.IsDBNull(r.GetOrdinal("FacturaCompra")) ? null : r.GetString(r.GetOrdinal("FacturaCompra")),
            Observaciones = r.IsDBNull(r.GetOrdinal("Observaciones")) ? null : r.GetString(r.GetOrdinal("Observaciones")),
            UsuarioID = r.GetInt32(r.GetOrdinal("UsuarioID")),
            CodigoProducto = HasCol(r, "CodigoInterno") ? r.IsDBNull(r.GetOrdinal("CodigoInterno")) ? null : r.GetString(r.GetOrdinal("CodigoInterno")) : null,
            NombreTipoMovimiento = HasCol(r, "TipoMovimiento") ? r.IsDBNull(r.GetOrdinal("TipoMovimiento")) ? null : r.GetString(r.GetOrdinal("TipoMovimiento")) : null,
            NombreUsuario = HasCol(r, "Usuario") ? r.IsDBNull(r.GetOrdinal("Usuario")) ? null : r.GetString(r.GetOrdinal("Usuario")) : null
        };

        private static bool HasCol(IDataReader r, string col)
        {
            for (int i = 0; i < r.FieldCount; i++)
                if (r.GetName(i).Equals(col, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }

        public MovimientosStock SaveMovimiento(MovimientosStock movimiento)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_MovimientosStock";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", movimiento.ProductoID);
                    cmd.Parameters.AddWithValue("@TipoMovimientoID", movimiento.TipoMovimientoID);
                    cmd.Parameters.AddWithValue("@Cantidad", movimiento.Cantidad);
                    cmd.Parameters.AddWithValue("@FechaMovimiento", movimiento.FechaMovimiento);
                    cmd.Parameters.AddWithValue("@FacturaCompra", movimiento.FacturaCompra ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Observaciones", movimiento.Observaciones ?? string.Empty);
                    cmd.Parameters.AddWithValue("@UsuarioID", movimiento.UsuarioID);
                    SqlParameter outID = new SqlParameter("@MovimientoID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    movimiento.MovimientoID = (int)outID.Value;
                }
                return movimiento;
            }
            catch (Exception er) { _log.ErrorFormat("Error SaveMovimiento: {0}", er.Message); throw; }
        }

        public MovimientosStock UpdateMovimiento(MovimientosStock movimiento)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_MovimientosStock";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MovimientoID", movimiento.MovimientoID);
                    cmd.Parameters.AddWithValue("@ProductoID", movimiento.ProductoID);
                    cmd.Parameters.AddWithValue("@TipoMovimientoID", movimiento.TipoMovimientoID);
                    cmd.Parameters.AddWithValue("@Cantidad", movimiento.Cantidad);
                    cmd.Parameters.AddWithValue("@FechaMovimiento", movimiento.FechaMovimiento);
                    cmd.Parameters.AddWithValue("@FacturaCompra", movimiento.FacturaCompra ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Observaciones", movimiento.Observaciones ?? string.Empty);
                    cmd.Parameters.AddWithValue("@UsuarioID", movimiento.UsuarioID);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetMovimientoByID(movimiento.MovimientoID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdateMovimiento: {0}", er.Message); throw; }
        }

        public bool DeleteMovimiento(int movimientoID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_MovimientosStock_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MovimientoID", movimientoID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeleteMovimiento: {0}", er.Message); throw; }
        }

        public MovimientosStock GetMovimientoByID(int movimientoID)
        {
            MovimientosStock obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_MovimientosStock_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MovimientoID", movimientoID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = MapMovimiento(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetMovimientoByID: {0}", er.Message); throw; }
        }

        public IEnumerable<MovimientosStock> GetMovimientosByProductoID(int productoID)
        {
            var lista = new List<MovimientosStock>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_MovimientosStock_ByProductoID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(MapMovimiento(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetMovimientosByProductoID: {0}", er.Message); throw; }
        }

        public IEnumerable<MovimientosStock> GetAllMovimientos()
        {
            var lista = new List<MovimientosStock>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_MovimientosStock_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(MapMovimiento(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetAllMovimientos: {0}", er.Message); throw; }
        }
    }
}
