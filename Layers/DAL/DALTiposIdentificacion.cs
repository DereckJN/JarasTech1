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
    internal class DALTiposIdentificacion : IDALTiposIdentificacion
    {
        private static readonly ILog _log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static TiposIdentificacion Map(IDataReader r) => new TiposIdentificacion
        {
            TipoIdentificacionID = r.GetInt32(r.GetOrdinal("TipoIdentificacionID")),
            NombreTipo = r.GetString(r.GetOrdinal("NombreTipo"))
        };

        /// <summary>Guarda un nuevo tipo de identificación y devuelve el ID generado.</summary>
        public TiposIdentificacion SaveTipoIdentificacion(TiposIdentificacion tipo)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_TiposIdentificacion";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreTipo", tipo.NombreTipo ?? string.Empty);
                    SqlParameter outID = new SqlParameter("@TipoIdentificacionID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    tipo.TipoIdentificacionID = (int)outID.Value;
                }
                return tipo;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error SaveTipoIdentificacion: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Actualiza un tipo de identificación existente.</summary>
        public TiposIdentificacion UpdateTipoIdentificacion(TiposIdentificacion tipo)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_TiposIdentificacion";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoIdentificacionID", tipo.TipoIdentificacionID);
                    cmd.Parameters.AddWithValue("@NombreTipo", tipo.NombreTipo ?? string.Empty);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetTipoIdentificacionByID(tipo.TipoIdentificacionID);
                }
                return null;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error UpdateTipoIdentificacion: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Elimina un tipo de identificación por su ID.</summary>
        public bool DeleteTipoIdentificacion(int tipoIdentificacionID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_TiposIdentificacion_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoIdentificacionID", tipoIdentificacionID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error DeleteTipoIdentificacion: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Obtiene un tipo de identificación por su ID.</summary>
        public TiposIdentificacion GetTipoIdentificacionByID(int tipoIdentificacionID)
        {
            TiposIdentificacion obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_TiposIdentificacion_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoIdentificacionID", tipoIdentificacionID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = Map(r);
                }
                return obj;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error GetTipoIdentificacionByID: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Obtiene todos los tipos de identificación.</summary>
        public IEnumerable<TiposIdentificacion> GetAllTiposIdentificacion()
        {
            List<TiposIdentificacion> lista = new List<TiposIdentificacion>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_TiposIdentificacion_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(Map(r));
                }
                return lista;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error GetAllTiposIdentificacion: {0}", er.Message);
                throw;
            }
        }
    }
}
