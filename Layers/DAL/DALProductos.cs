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
    internal class DALProductos : IDALProductos
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static Productos MapProducto(IDataReader r)
        {
            return new Productos
            {
                ProductoID = r.GetInt32(0),
                CodigoInterno = r.GetString(1),
                CodigoIndustria = r.IsDBNull(2) ? string.Empty : r.GetString(2),
                TipoDispositivoID = r.GetInt32(3),
                ModeloID = r.GetInt32(4),
                MarcaID = r.GetInt32(5),
                Color = r.IsDBNull(6) ? string.Empty : r.GetString(6),
                Caracteristicas = r.IsDBNull(7) ? string.Empty : r.GetString(7),
                Fotografia = r.IsDBNull(8) ? null : (byte[])r.GetValue(8),
                DocumentoEspecificaciones = r.IsDBNull(9) ? null : (byte[])r.GetValue(9),
                NombreDocumento = r.IsDBNull(10) ? string.Empty : r.GetString(10),
                Extras = r.IsDBNull(11) ? string.Empty : r.GetString(11),
                CantidadStock = r.GetInt32(12),
                PrecioColones = r.GetDecimal(13),
                PrecioDolares = r.GetDecimal(14),
                Estado = r.GetBoolean(15),
                NombreTipoDispositivo = r.IsDBNull(16) ? string.Empty : r.GetString(16),
                NombreModelo = r.IsDBNull(17) ? string.Empty : r.GetString(17),
                NombreMarca = r.IsDBNull(18) ? string.Empty : r.GetString(18)
            };
        }

        /// <summary>Comprueba si una columna existe en el reader.</summary>
        private static bool HasColumn(IDataReader r, string columnName)
        {
            for (int i = 0; i < r.FieldCount; i++)
                if (r.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }

        // ── SAVE ──────────────────────────────────────────────────────

        /// <summary>Guarda un nuevo producto en la base de datos.</summary>
        public Productos SaveProducto(Productos producto)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_INSERT_Productos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CodigoInterno", producto.CodigoInterno ?? string.Empty);
                    cmd.Parameters.AddWithValue("@CodigoIndustria", producto.CodigoIndustria ?? string.Empty);
                    cmd.Parameters.AddWithValue("@TipoDispositivoID", producto.TipoDispositivoID);
                    cmd.Parameters.AddWithValue("@ModeloID", producto.ModeloID);
                    cmd.Parameters.AddWithValue("@MarcaID", producto.MarcaID);
                    cmd.Parameters.AddWithValue("@Color", producto.Color ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Caracteristicas", producto.Caracteristicas ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Extras", producto.Extras ?? string.Empty);
                    cmd.Parameters.AddWithValue("@CantidadStock", producto.CantidadStock);
                    cmd.Parameters.AddWithValue("@PrecioColones", producto.PrecioColones);
                    cmd.Parameters.AddWithValue("@PrecioDolares", producto.PrecioDolares);
                    cmd.Parameters.AddWithValue("@Estado", producto.Estado);
                    cmd.Parameters.AddWithValue("@NombreDocumento", producto.NombreDocumento ?? string.Empty);

                    AddBinaryParam(cmd, "@Fotografia", producto.Fotografia);
                    AddBinaryParam(cmd, "@DocumentoEspecificaciones", producto.DocumentoEspecificaciones);

                    SqlParameter outID = new SqlParameter("@ProductoID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outID);

                    db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                    producto.ProductoID = (int)outID.Value;
                }
                return producto;
            }
            catch (Exception er) { _log.ErrorFormat("Error SaveProducto: {0}", er.Message); throw; }
        }

        // ── UPDATE ────────────────────────────────────────────────────

        /// <summary>Actualiza los datos de un producto existente.</summary>
        public Productos UpdateProducto(Productos producto)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_Productos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID);
                    cmd.Parameters.AddWithValue("@CodigoInterno", producto.CodigoInterno ?? string.Empty);
                    cmd.Parameters.AddWithValue("@CodigoIndustria", producto.CodigoIndustria ?? string.Empty);
                    cmd.Parameters.AddWithValue("@TipoDispositivoID", producto.TipoDispositivoID);
                    cmd.Parameters.AddWithValue("@ModeloID", producto.ModeloID);
                    cmd.Parameters.AddWithValue("@MarcaID", producto.MarcaID);
                    cmd.Parameters.AddWithValue("@Color", producto.Color ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Caracteristicas", producto.Caracteristicas ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Extras", producto.Extras ?? string.Empty);
                    cmd.Parameters.AddWithValue("@CantidadStock", producto.CantidadStock);
                    cmd.Parameters.AddWithValue("@PrecioColones", producto.PrecioColones);
                    cmd.Parameters.AddWithValue("@PrecioDolares", producto.PrecioDolares);
                    cmd.Parameters.AddWithValue("@Estado", producto.Estado);
                    cmd.Parameters.AddWithValue("@NombreDocumento", producto.NombreDocumento ?? string.Empty);

                    AddBinaryParam(cmd, "@Fotografia", producto.Fotografia);
                    AddBinaryParam(cmd, "@DocumentoEspecificaciones", producto.DocumentoEspecificaciones);

                    if (db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0)
                        return GetProductoByID(producto.ProductoID);
                }
                return null;
            }
            catch (Exception er) { _log.ErrorFormat("Error UpdateProducto: {0}", er.Message); throw; }
        }

        // ── DELETE ────────────────────────────────────────────────────

        /// <summary>Elimina un producto por su ID.</summary>
        public bool DeleteProducto(int productoID)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_DELETE_Productos_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error DeleteProducto: {0}", er.Message); throw; }
        }

        // ── GET BY ID ─────────────────────────────────────────────────

        /// <summary>Obtiene un producto por su ID.</summary>
        public Productos GetProductoByID(int productoID)
        {
            Productos obj = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Productos_ByID";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        if (r.Read()) obj = MapProducto(r);
                }
                return obj;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetProductoByID: {0}", er.Message); throw; }
        }

        // ── FILTRO UI (reemplaza ComboBox) ────────────────────────────

        /// <summary>Busca productos por código interno, marca o modelo.</summary>
        public IEnumerable<Productos> GetProductosByFiltro(string filtro)
        {
            var lista = new List<Productos>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Productos_ByFiltro";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Filtro", filtro ?? string.Empty);
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(MapProducto(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetProductosByFiltro: {0}", er.Message); throw; }
        }

        // ── FILTRO REPORTE A ──────────────────────────────────────────

        /// <summary>Filtra por marca, modelo y tipo de dispositivo (Reporte A).</summary>
        public IEnumerable<Productos> GetProductosByFiltros(int? marcaID, int? modeloID, int? tipoDispositivoID)
        {
            var lista = new List<Productos>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Productos_ByFiltros";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MarcaID", SqlDbType.Int).Value = marcaID ?? (object)DBNull.Value;
                    cmd.Parameters.Add("@ModeloID", SqlDbType.Int).Value = modeloID ?? (object)DBNull.Value;
                    cmd.Parameters.Add("@TipoDispositivoID", SqlDbType.Int).Value = tipoDispositivoID ?? (object)DBNull.Value;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(MapProducto(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetProductosByFiltros: {0}", er.Message); throw; }
        }

        // ── CON STOCK (validación antes de vender) ────────────────────

        /// <summary>Devuelve solo productos con stock mayor a 0.</summary>
        public IEnumerable<Productos> GetProductosConStock()
        {
            // Reutiliza el SP que ya tiene todas las columnas correctas
            return GetProductosByFiltros(null, null, null)
                   .Where(p => p.CantidadStock > 0 && p.Estado);
        }

        // ── GET ALL ───────────────────────────────────────────────────

        /// <summary>Obtiene todos los productos.</summary>
        public IEnumerable<Productos> GetAllProductos()
        {
            var lista = new List<Productos>();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_SELECT_Productos_All";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader r = db.ExecuteReader(cmd))
                        while (r.Read()) lista.Add(MapProducto(r));
                }
                return lista;
            }
            catch (Exception er) { _log.ErrorFormat("Error GetAllProductos: {0}", er.Message); throw; }
        }

        // ── STOCK ─────────────────────────────────────────────────────

        /// <summary>Rebaja stock al concretar una venta.</summary>
        public bool RebajarStock(int productoID, int cantidad)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_Productos_RebajarStock";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error RebajarStock: {0}", er.Message); throw; }
        }

        /// <summary>Aumenta stock al ingresar mercadería.</summary>
        public bool AumentarStock(int productoID, int cantidad)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    cmd.CommandText = "usp_UPDATE_Productos_AumentarStock";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    return db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er) { _log.ErrorFormat("Error AumentarStock: {0}", er.Message); throw; }
        }

        // ── Auxiliar binario ──────────────────────────────────────────
        private static void AddBinaryParam(SqlCommand cmd, string name, byte[] value)
        {
            if (value != null && value.Length > 0)
                cmd.Parameters.AddWithValue(name, value);
            else
                cmd.Parameters.Add(name, SqlDbType.VarBinary).Value = DBNull.Value;
        }
    }
}
