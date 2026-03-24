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
    internal class BLLIVA : IBLLIVA
    {
        private readonly IDALIVA _dal = new DALIVA();

        /// <summary>
        /// Guarda un nuevo registro de IVA o actualiza el existente.
        /// </summary>
        public IVA SaveIVA(IVA iva)
        {
            if (_dal.GetIVAByID(iva.IVAID) != null)
                return _dal.UpdateIVA(iva);
            return _dal.SaveIVA(iva);
        }

        /// <summary>Actualiza el porcentaje de IVA.</summary>
        public IVA UpdateIVA(IVA iva)
        {
            return _dal.UpdateIVA(iva);
        }

        /// <summary>Elimina un registro de IVA por su ID.</summary>
        public bool DeleteIVA(int ivaID)
        {
            return _dal.DeleteIVA(ivaID);
        }

        /// <summary>Obtiene un registro de IVA por su ID.</summary>
        public IVA GetIVAByID(int ivaID)
        {
            return _dal.GetIVAByID(ivaID);
        }

        /// <summary>Obtiene todos los registros de IVA.</summary>
        public IEnumerable<IVA> GetAllIVA()
        {
            return _dal.GetAllIVA();
        }
    }
}
