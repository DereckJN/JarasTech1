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
    /// Lógica de negocio para TiposIdentificacion.
    /// Gestiona los tipos de documento: Nacional (cédula) y Extranjero (pasaporte).
    /// </summary>
    internal class BLLTiposIdentificacion : IBLLTiposIdentificacion
    {
        private readonly IDALTiposIdentificacion _dal = new DALTiposIdentificacion();

        /// <summary>
        /// Guarda un nuevo tipo de identificación o actualiza el existente.
        /// </summary>
        public TiposIdentificacion SaveTipoIdentificacion(TiposIdentificacion tipo)
        {
            if (_dal.GetTipoIdentificacionByID(tipo.TipoIdentificacionID) != null)
                return _dal.UpdateTipoIdentificacion(tipo);
            return _dal.SaveTipoIdentificacion(tipo);
        }

        /// <summary>Actualiza un tipo de identificación existente.</summary>
        public TiposIdentificacion UpdateTipoIdentificacion(TiposIdentificacion tipo)
        {
            return _dal.UpdateTipoIdentificacion(tipo);
        }

        /// <summary>Elimina un tipo de identificación por su ID.</summary>
        public bool DeleteTipoIdentificacion(int tipoIdentificacionID)
        {
            return _dal.DeleteTipoIdentificacion(tipoIdentificacionID);
        }

        /// <summary>Obtiene un tipo de identificación por su ID.</summary>
        public TiposIdentificacion GetTipoIdentificacionByID(int tipoIdentificacionID)
        {
            return _dal.GetTipoIdentificacionByID(tipoIdentificacionID);
        }

        /// <summary>Obtiene todos los tipos de identificación.</summary>
        public IEnumerable<TiposIdentificacion> GetAllTiposIdentificacion()
        {
            return _dal.GetAllTiposIdentificacion();
        }
    }
}
