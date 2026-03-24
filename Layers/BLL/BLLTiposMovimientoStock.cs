using JarasTech.Layers.DAL;
using JarasTech.Layers.Entities;
using JarasTech.Layers.Interfaces.Ibll;
using JarasTech.Layers.Interfaces.Idal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.BLL
{
    /// <summary>
    /// Lógica de negocio para TiposMovimientoStock.
    /// Gestiona los tipos de movimiento de inventario: Entrada y Salida.
    /// </summary>
    internal class BLLTiposMovimientoStock : IBLLTiposMovimientoStock
    {
        private readonly IDALTiposMovimientoStock _dal = new DALTiposMovimientoStock();

        /// <summary>
        /// Guarda un nuevo tipo de movimiento o actualiza el existente.
        /// </summary>
        public TiposMovimientoStock SaveTipoMovimiento(TiposMovimientoStock tipo)
        {
            if (_dal.GetTipoMovimientoByID(tipo.TipoMovimientoID) != null)
                return _dal.UpdateTipoMovimiento(tipo);
            return _dal.SaveTipoMovimiento(tipo);
        }

        /// <summary>Actualiza un tipo de movimiento de stock existente.</summary>
        public TiposMovimientoStock UpdateTipoMovimiento(TiposMovimientoStock tipo)
        {
            return _dal.UpdateTipoMovimiento(tipo);
        }

        /// <summary>Elimina un tipo de movimiento de stock por su ID.</summary>
        public bool DeleteTipoMovimiento(int tipoMovimientoID)
        {
            return _dal.DeleteTipoMovimiento(tipoMovimientoID);
        }

        /// <summary>Obtiene un tipo de movimiento de stock por su ID.</summary>
        public TiposMovimientoStock GetTipoMovimientoByID(int tipoMovimientoID)
        {
            return _dal.GetTipoMovimientoByID(tipoMovimientoID);
        }

        /// <summary>Obtiene todos los tipos de movimiento de stock.</summary>
        public IEnumerable<TiposMovimientoStock> GetAllTiposMovimiento()
        {
            return _dal.GetAllTiposMovimiento();
        }
    }
}
