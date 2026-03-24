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
    /// <summary>
    /// Acceso a datos para la entidad TiposMovimientoStock.
    /// Gestiona los tipos de movimiento de inventario: Entrada y Salida.
    /// </summary>
    internal class DALTiposMovimientoStock : IDALTiposMovimientoStock
    {
        private static readonly ILog _log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static TiposMovimientoStock Map(IDataReader r) => new TiposMovimientoStock
        {
            TipoMovimientoID = r.GetInt32(r.GetOrdinal("TipoMovimientoID")),
            NombreTipo = r.GetString(r.GetOrdinal("NombreTipo"))
        };

        /// <summary>Guarda un nuevo tipo de movimiento de stock y devuelve el ID generado.</summary>
        public TiposMovimientoStock SaveTipoMovimiento(TiposMovimientoStock tipo)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_TiposMovimientoStock";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreTipo", tipo.NombreTipo ?? string.Empty);
                    SqlParameter outID = new SqlParameter("@TipoMovimientoID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    tipo.TipoMovimientoID = (int)outID.Value;
                }
                return tipo;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error SaveTipoMovimiento: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Actualiza un tipo de movimiento de stock existente.</summary>
        public TiposMovimientoStock UpdateTipoMovimiento(TiposMovimientoStock tipo)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_TiposMovimientoStock";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoMovimientoID", tipo.TipoMovimientoID);
                    cmd.Parameters.AddWithValue("@NombreTipo", tipo.NombreTipo ?? string.Empty);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetTipoMovimientoByID(tipo.TipoMovimientoID);
                }
                return null;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error UpdateTipoMovimiento: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Elimina un tipo de movimiento de stock por su ID.</summary>
        public bool DeleteTipoMovimiento(int tipoMovimientoID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_TiposMovimientoStock_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoMovimientoID", tipoMovimientoID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error DeleteTipoMovimiento: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Obtiene un tipo de movimiento de stock por su ID.</summary>
        public TiposMovimientoStock GetTipoMovimientoByID(int tipoMovimientoID)
        {
            TiposMovimientoStock obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_TiposMovimientoStock_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoMovimientoID", tipoMovimientoID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = Map(r);
                }
                return obj;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error GetTipoMovimientoByID: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Obtiene todos los tipos de movimiento de stock.</summary>
        public IEnumerable<TiposMovimientoStock> GetAllTiposMovimiento()
        {
            List<TiposMovimientoStock> lista = new List<TiposMovimientoStock>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_TiposMovimientoStock_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(Map(r));
                }
                return lista;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error GetAllTiposMovimiento: {0}", er.Message);
                throw;
            }
        }
    }
}
