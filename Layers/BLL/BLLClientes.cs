using JarasTech.Layers.DAL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces;
using JarasTech.Layers.Interfaces.Ibll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.BLL
{
    internal class BLLClientes : IBLLClientes
    {
        /// <summary>Instancia de acceso a datos para clientes.</summary>
        private readonly IDALClientes _dalCliente = new DALClientes();

        // ─────────────────────────────────────────────
        // SAVE (Insert o Update según si ya existe)
        // ─────────────────────────────────────────────

        /// <summary>
        /// Guarda un nuevo cliente o actualiza uno existente según su ClienteID.
        /// </summary>
        /// <param name="cliente">Objeto <see cref="Clientes"/> a guardar o actualizar.</param>
        /// <returns>El cliente guardado o actualizado.</returns>
        public Clientes SaveCliente(Clientes cliente)
        {
            if (_dalCliente.GetClienteByID(cliente.ClienteID) != null)
                return _dalCliente.UpdateCliente(cliente);
            else
                return _dalCliente.SaveCliente(cliente);
        }

        // ─────────────────────────────────────────────
        // UPDATE
        // ─────────────────────────────────────────────

        /// <summary>
        /// Actualiza la información de un cliente existente.
        /// </summary>
        /// <param name="cliente">Objeto <see cref="Clientes"/> con la información actualizada.</param>
        /// <returns>El cliente actualizado.</returns>
        public Clientes UpdateCliente(Clientes cliente)
        {
            return _dalCliente.UpdateCliente(cliente);
        }

        // ─────────────────────────────────────────────
        // DELETE
        // ─────────────────────────────────────────────

        /// <summary>
        /// Elimina un cliente a partir de su identificador único.
        /// </summary>
        /// <param name="clienteID">Identificador único del cliente.</param>
        /// <returns>True si la operación fue exitosa; de lo contrario, False.</returns>
        public bool DeleteCliente(int clienteID)
        {
            return _dalCliente.DeleteCliente(clienteID);
        }

        // ─────────────────────────────────────────────
        // GET BY ID
        // ─────────────────────────────────────────────

        /// <summary>
        /// Obtiene un cliente por su identificador único.
        /// </summary>
        /// <param name="clienteID">Identificador único del cliente.</param>
        /// <returns>Un objeto <see cref="Clientes"/> si existe; de lo contrario, null.</returns>
        public Clientes GetClienteByID(int clienteID)
        {
            return _dalCliente.GetClienteByID(clienteID);
        }

        // ─────────────────────────────────────────────
        // GET BY NUMERO IDENTIFICACION
        // ─────────────────────────────────────────────

        /// <summary>
        /// Busca un cliente por su número de identificación (cédula o pasaporte).
        /// Útil para verificar si un cliente ya está registrado al consumir el API de Hacienda.
        /// </summary>
        /// <param name="numeroIdentificacion">Número de identificación a buscar.</param>
        /// <returns>Un objeto <see cref="Clientes"/> si existe; de lo contrario, null.</returns>
        public Clientes GetClienteByNumeroIdentificacion(string numeroIdentificacion)
        {
            return _dalCliente.GetClienteByNumeroIdentificacion(numeroIdentificacion);
        }

        // ─────────────────────────────────────────────
        // GET BY NOMBRE (filtro UI)
        // ─────────────────────────────────────────────

        /// <summary>
        /// Busca clientes por nombre, apellido o número de identificación.
        /// Utilizado en los filtros de búsqueda de la UI (reemplaza al ComboBox).
        /// </summary>
        /// <param name="filtro">Texto a buscar.</param>
        /// <returns>Una colección de objetos <see cref="Clientes"/> que coinciden con el filtro.</returns>
        public IEnumerable<Clientes> GetClientesByNombre(string filtro)
        {
            return _dalCliente.GetClientesByNombre(filtro);
        }

        // ─────────────────────────────────────────────
        // GET ALL
        // ─────────────────────────────────────────────

        /// <summary>
        /// Obtiene todos los clientes registrados en el sistema.
        /// </summary>
        /// <returns>Una colección de objetos <see cref="Clientes"/>.</returns>
        public IEnumerable<Clientes> GetAllClientes()
        {
            return _dalCliente.GetAllClientes();
        }
    }
}
