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
    internal class DALMarcas : IDALMarcas
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static Marcas Map(IDataReader r) => new Marcas
        {
            MarcaID = r.GetInt32(r.GetOrdinal("MarcaID")),
            Codigo = r.GetString(r.GetOrdinal("Codigo")),
            Descripcion = r.GetString(r.GetOrdinal("Descripcion"))
        };

        public Marcas SaveMarca(Marcas marca)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_Marcas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", marca.Codigo ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Descripcion", marca.Descripcion ?? string.Empty);
                    SqlParameter outID = new SqlParameter("@MarcaID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);
                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    marca.MarcaID = (int)outID.Value;
                }
                return marca;
            }
            catch (Exception er) { _log.ErrorFormat("Error SaveMarca: {0}", er.Message); throw; }
        }

        public Marcas UpdateMarca(Marcas marca)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_Marcas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MarcaID", marca.MarcaID);
                    cmd.Parameters.AddWithValue("@Codigo", marca.Codigo ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Descripcion", marca.Descripcion ?? string.Empty);
                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetMarcaByID(marca.MarcaID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdateMarca: {0}", er.Message); throw; }
        }

        public bool DeleteMarca(int marcaID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_Marcas_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MarcaID", marcaID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeleteMarca: {0}", er.Message); throw; }
        }

        public Marcas GetMarcaByID(int marcaID)
        {
            Marcas obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Marcas_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MarcaID", marcaID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = Map(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetMarcaByID: {0}", er.Message); throw; }
        }

        public IEnumerable<Marcas> GetAllMarcas()
        {
            var lista = new List<Marcas>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Marcas_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(Map(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetAllMarcas: {0}", er.Message); throw; }
        }
    }
}
