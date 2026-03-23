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
    internal class DALModelos : IDALModelos
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static Modelos Map(IDataReader r) => new Modelos
        {
            ModeloID = r.GetInt32(r.GetOrdinal("ModeloID")),
            Codigo = r.GetString(r.GetOrdinal("Codigo")),
            Descripcion = r.GetString(r.GetOrdinal("Descripcion"))
        };

        public Modelos SaveModelo(Modelos modelo)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_Modelos";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", modelo.Codigo ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Descripcion", modelo.Descripcion ?? string.Empty);
                    SqlParameter outID = new SqlParameter("@ModeloID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    modelo.ModeloID = (int)outID.Value;
                }
                return modelo;
            }
            catch (Exception er) { _log.ErrorFormat("Error SaveModelo: {0}", er.Message); throw; }
        }

        public Modelos UpdateModelo(Modelos modelo)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_Modelos";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ModeloID", modelo.ModeloID);
                    cmd.Parameters.AddWithValue("@Codigo", modelo.Codigo ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Descripcion", modelo.Descripcion ?? string.Empty);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetModeloByID(modelo.ModeloID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdateModelo: {0}", er.Message); throw; }
        }

        public bool DeleteModelo(int modeloID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_Modelos_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ModeloID", modeloID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeleteModelo: {0}", er.Message); throw; }
        }

        public Modelos GetModeloByID(int modeloID)
        {
            Modelos obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Modelos_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ModeloID", modeloID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = Map(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetModeloByID: {0}", er.Message); throw; }
        }

        public IEnumerable<Modelos> GetAllModelos()
        {
            var lista = new List<Modelos>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Modelos_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(Map(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetAllModelos: {0}", er.Message); throw; }
        }
    }
}
