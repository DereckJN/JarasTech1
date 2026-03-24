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
    internal class DALIVA : IDALIVA
    {
        private static readonly ILog _log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static IVA Map(IDataReader r) => new IVA
        {
            IVAID = r.GetInt32(r.GetOrdinal("IVAID")),
            Porcentaje = r.GetDecimal(r.GetOrdinal("Porcentaje"))
        };

        /// <summary>Guarda un nuevo registro de IVA y devuelve el ID generado.</summary>
        public IVA SaveIVA(IVA iva)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_IVA";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Porcentaje", iva.Porcentaje);
                    SqlParameter outID = new SqlParameter("@IVAID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    iva.IVAID = (int)outID.Value;
                }
                return iva;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error SaveIVA: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Actualiza el porcentaje de un registro de IVA existente.</summary>
        public IVA UpdateIVA(IVA iva)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_IVA";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IVAID", iva.IVAID);
                    cmd.Parameters.AddWithValue("@Porcentaje", iva.Porcentaje);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetIVAByID(iva.IVAID);
                }
                return null;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error UpdateIVA: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Elimina un registro de IVA por su ID.</summary>
        public bool DeleteIVA(int ivaID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_IVA_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IVAID", ivaID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error DeleteIVA: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Obtiene un registro de IVA por su ID.</summary>
        public IVA GetIVAByID(int ivaID)
        {
            IVA obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_IVA_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IVAID", ivaID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = Map(r);
                }
                return obj;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error GetIVAByID: {0}", er.Message);
                throw;
            }
        }

        /// <summary>Obtiene todos los registros de IVA.</summary>
        public IEnumerable<IVA> GetAllIVA()
        {
            List<IVA> lista = new List<IVA>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_IVA_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(Map(r));
                }
                return lista;
            }
            catch (Exception er)
            {
                _log.ErrorFormat("Error GetAllIVA: {0}", er.Message);
                throw;
            }
        }
    }
}
