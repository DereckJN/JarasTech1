using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Interfaces
{
    internal interface IDALClientes
    {
        /// <summary>Guarda un nuevo cliente en la base de datos.</summary>
        /// <param name="cliente">Entidad Cliente a guardar.</param>
        /// <returns>Entidad Cliente con el ClienteID generado.</returns>
        Clientes SaveCliente(Clientes cliente);

        /// <summary>Actualiza los datos de un cliente existente.</summary>
        /// <param name="cliente">Entidad Cliente con la información actualizada.</param>
        /// <returns>Entidad Cliente actualizada, o null si falló.</returns>
        Clientes UpdateCliente(Clientes cliente);

        /// <summary>Elimina un cliente por su ID.</summary>
        /// <param name="clienteID">ID del cliente a eliminar.</param>
        /// <returns>True si la eliminación fue exitosa; false en caso contrario.</returns>
        bool DeleteCliente(int clienteID);

        /// <summary>Obtiene un cliente por su ID.</summary>
        /// <param name="clienteID">ID del cliente a buscar.</param>
        /// <returns>Entidad Cliente encontrada, o null si no existe.</returns>
        Clientes GetClienteByID(int clienteID);

        /// <summary>Busca un cliente por su número de identificación (cédula o pasaporte).</summary>
        /// <param name="numeroIdentificacion">Número de identificación a buscar.</param>
        /// <returns>Entidad Cliente encontrada, o null si no existe.</returns>
        Clientes GetClienteByNumeroIdentificacion(string numeroIdentificacion);

        /// <summary>Busca clientes por nombre, apellido o número de identificación.</summary>
        /// <param name="filtro">Texto a buscar.</param>
        /// <returns>Lista de clientes que coinciden con el filtro.</returns>
        IEnumerable<Clientes> GetClientesByNombre(string filtro);

        /// <summary>Obtiene todos los clientes registrados.</summary>
        /// <returns>Lista de entidades Cliente.</returns>
        IEnumerable<Clientes> GetAllClientes();
    }
}
