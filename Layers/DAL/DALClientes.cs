using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces;
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
    internal class DALClientes : IDALClientes
    {
        private static readonly ILog _MyLogControlEventos =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        // ─────────────────────────────────────────────
        // Método auxiliar: mapea un IDataReader a Clientes
        // ─────────────────────────────────────────────
        private static Clientes MapCliente(IDataReader reader)
        {
            return new Clientes
            {
                ClienteID = reader.GetInt32(reader.GetOrdinal("ClienteID")),
                TipoIdentificacionID = reader.GetInt32(reader.GetOrdinal("TipoIdentificacionID")),
                NumeroIdentificacion = reader.GetString(reader.GetOrdinal("NumeroIdentificacion")),
                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                Apellidos = reader.GetString(reader.GetOrdinal("Apellidos")),
                Sexo = reader.GetString(reader.GetOrdinal("Sexo"))[0],
                Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                CorreoElectronico = reader.GetString(reader.GetOrdinal("CorreoElectronico")),
                Provincia = reader.GetString(reader.GetOrdinal("Provincia")),
                DireccionExacta = reader.GetString(reader.GetOrdinal("DireccionExacta")),
                Fotografia = reader.IsDBNull(reader.GetOrdinal("Fotografia"))
                                            ? null
                                            : (byte[])reader["Fotografia"]
            };
        }

        // ─────────────────────────────────────────────
        // SAVE
        // ─────────────────────────────────────────────

        /// <summary>
        /// Guarda un nuevo cliente en la base de datos.
        /// </summary>
        /// <param name="cliente">Entidad Cliente a guardar.</param>
        /// <returns>Entidad Cliente con el ClienteID generado.</returns>
        /// <exception cref="Exception">Si ocurre un error durante la operación.</exception>
        public Clientes SaveCliente(Clientes cliente)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    command.CommandText = "usp_INSERT_Clientes";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TipoIdentificacionID", cliente.TipoIdentificacionID);
                    command.Parameters.AddWithValue("@NumeroIdentificacion", cliente.NumeroIdentificacion ?? string.Empty);
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre ?? string.Empty);
                    command.Parameters.AddWithValue("@Apellidos", cliente.Apellidos ?? string.Empty);
                    command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                    command.Parameters.AddWithValue("@Telefono", cliente.Telefono ?? string.Empty);
                    command.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico ?? string.Empty);
                    command.Parameters.AddWithValue("@Provincia", cliente.Provincia ?? string.Empty);
                    command.Parameters.AddWithValue("@DireccionExacta", cliente.DireccionExacta ?? string.Empty);

                    // Fotografía puede ser null
                    if (cliente.Fotografia != null && cliente.Fotografia.Length > 0)
                        command.Parameters.AddWithValue("@Fotografia", cliente.Fotografia);
                    else
                        command.Parameters.Add("@Fotografia", SqlDbType.VarBinary).Value = DBNull.Value;

                    SqlParameter outputIdParam = new SqlParameter("@ClienteID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);

                    db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);

                    cliente.ClienteID = (int)outputIdParam.Value;
                }
                return cliente;
            }
            catch (Exception er)
            {
                _MyLogControlEventos.ErrorFormat("Error SaveCliente: {0}", er.Message);
                throw;
            }
        }

        // ─────────────────────────────────────────────
        // UPDATE
        // ─────────────────────────────────────────────

        /// <summary>
        /// Actualiza los datos de un cliente existente.
        /// </summary>
        /// <param name="cliente">Entidad Cliente con la información actualizada.</param>
        /// <returns>Entidad Cliente actualizada, o null si la actualización falló.</returns>
        /// <exception cref="Exception">Si ocurre un error durante la operación.</exception>
        public Clientes UpdateCliente(Clientes cliente)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    command.CommandText = "usp_UPDATE_Clientes";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);
                    command.Parameters.AddWithValue("@TipoIdentificacionID", cliente.TipoIdentificacionID);
                    command.Parameters.AddWithValue("@NumeroIdentificacion", cliente.NumeroIdentificacion ?? string.Empty);
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre ?? string.Empty);
                    command.Parameters.AddWithValue("@Apellidos", cliente.Apellidos ?? string.Empty);
                    command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                    command.Parameters.AddWithValue("@Telefono", cliente.Telefono ?? string.Empty);
                    command.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico ?? string.Empty);
                    command.Parameters.AddWithValue("@Provincia", cliente.Provincia ?? string.Empty);
                    command.Parameters.AddWithValue("@DireccionExacta", cliente.DireccionExacta ?? string.Empty);

                    if (cliente.Fotografia != null && cliente.Fotografia.Length > 0)
                        command.Parameters.AddWithValue("@Fotografia", cliente.Fotografia);
                    else
                        command.Parameters.Add("@Fotografia", SqlDbType.VarBinary).Value = DBNull.Value;

                    if (db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted) > 0)
                        return GetClienteByID(cliente.ClienteID);
                }
                return null;
            }
            catch (Exception er)
            {
                _MyLogControlEventos.ErrorFormat("Error UpdateCliente: {0}", er.Message);
                throw;
            }
        }

        // ─────────────────────────────────────────────
        // DELETE
        // ─────────────────────────────────────────────

        /// <summary>
        /// Elimina un cliente por su ID.
        /// </summary>
        /// <param name="clienteID">ID del cliente a eliminar.</param>
        /// <returns>True si la eliminación fue exitosa; false en caso contrario.</returns>
        /// <exception cref="Exception">Si ocurre un error durante la operación.</exception>
        public bool DeleteCliente(int clienteID)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    command.CommandText = "usp_DELETE_Clientes_ByID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClienteID", clienteID);

                    return db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted) > 0;
                }
            }
            catch (Exception er)
            {
                _MyLogControlEventos.ErrorFormat("Error DeleteCliente: {0}", er.Message);
                throw;
            }
        }

        // ─────────────────────────────────────────────
        // GET BY ID
        // ─────────────────────────────────────────────

        /// <summary>
        /// Obtiene un cliente por su ID.
        /// </summary>
        /// <param name="clienteID">ID del cliente a buscar.</param>
        /// <returns>Entidad Cliente encontrada, o null si no existe.</returns>
        /// <exception cref="Exception">Si ocurre un error durante la consulta.</exception>
        public Clientes GetClienteByID(int clienteID)
        {
            Clientes oCliente = null;
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    command.CommandText = "usp_SELECT_Clientes_ByID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClienteID", clienteID);

                    using (IDataReader reader = db.ExecuteReader(command))
                    {
                        if (reader.Read())
                            oCliente = MapCliente(reader);
                    }
                }
                return oCliente;
            }
            catch (Exception er)
            {
                _MyLogControlEventos.ErrorFormat("Error GetClienteByID: {0}", er.Message);
                throw;
            }
        }

        // ─────────────────────────────────────────────
        // GET BY NUMERO IDENTIFICACION
        // ─────────────────────────────────────────────

        /// <summary>
        /// Busca un cliente por su número de identificación (cédula o pasaporte).
        /// Usado al consumir el API de Hacienda para autocompletar datos.
        /// </summary>
        /// <param name="numeroIdentificacion">Número de identificación a buscar.</param>
        /// <returns>Entidad Cliente encontrada, o null si no existe.</returns>
        /// <exception cref="Exception">Si ocurre un error durante la consulta.</exception>
        public Clientes GetClienteByNumeroIdentificacion(string numeroIdentificacion)
        {
            Clientes oCliente = null;
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    command.CommandText = "usp_SELECT_Clientes_ByNumeroIdentificacion";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NumeroIdentificacion", numeroIdentificacion);

                    using (IDataReader reader = db.ExecuteReader(command))
                    {
                        if (reader.Read())
                            oCliente = MapCliente(reader);
                    }
                }
                return oCliente;
            }
            catch (Exception er)
            {
                _MyLogControlEventos.ErrorFormat("Error GetClienteByNumeroIdentificacion: {0}", er.Message);
                throw;
            }
        }

        // ─────────────────────────────────────────────
        // GET BY NOMBRE (filtro para búsqueda en UI)
        // ─────────────────────────────────────────────

        /// <summary>
        /// Busca clientes por nombre, apellido o número de identificación.
        /// Utilizado en los filtros de búsqueda de la UI (reemplaza al ComboBox).
        /// </summary>
        /// <param name="filtro">Texto a buscar.</param>
        /// <returns>Lista de clientes que coinciden con el filtro.</returns>
        /// <exception cref="Exception">Si ocurre un error durante la consulta.</exception>
        public IEnumerable<Clientes> GetClientesByNombre(string filtro)
        {
            List<Clientes> clientes = new List<Clientes>();
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    command.CommandText = "usp_SELECT_Clientes_ByNombre";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Filtro", filtro ?? string.Empty);

                    using (IDataReader reader = db.ExecuteReader(command))
                    {
                        while (reader.Read())
                            clientes.Add(MapCliente(reader));
                    }
                }
                return clientes;
            }
            catch (Exception er)
            {
                _MyLogControlEventos.ErrorFormat("Error GetClientesByNombre: {0}", er.Message);
                throw;
            }
        }

        // ─────────────────────────────────────────────
        // GET ALL
        // ─────────────────────────────────────────────

        /// <summary>
        /// Obtiene todos los clientes registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de entidades Cliente.</returns>
        /// <exception cref="Exception">Si ocurre un error durante la consulta.</exception>
        public IEnumerable<Clientes> GetAllClientes()
        {
            List<Clientes> clientes = new List<Clientes>();
            SqlCommand command = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    command.CommandText = "usp_SELECT_Clientes_All";
                    command.CommandType = CommandType.StoredProcedure;

                    using (IDataReader reader = db.ExecuteReader(command))
                    {
                        while (reader.Read())
                            clientes.Add(MapCliente(reader));
                    }
                }
                return clientes;
            }
            catch (Exception er)
            {
                _MyLogControlEventos.ErrorFormat("Error GetAllClientes: {0}", er.Message);
                throw;
            }
        }
    }
}
