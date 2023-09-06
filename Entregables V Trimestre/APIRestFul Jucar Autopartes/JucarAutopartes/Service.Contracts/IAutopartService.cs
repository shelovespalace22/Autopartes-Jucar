using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IAutopartService
    {
        /* Obteniendo todas las Autopartes en general */
        IEnumerable<AutopartDto> GetAllAutoparts(bool trackChanges);

        /* Obteniendo Autoparte por su Id */
        AutopartDto GetAutopartById(Guid autopartId, bool trackChanges);

        /* Obtener todas las Autopartes de una Subcategoria */
        IEnumerable<AutopartDto> GetAutoparts(Guid subcategoryId, bool trackChanges);

        /* Obtener una Autopartes especifica de una Subcategoria */
        AutopartDto GetAutopartBySubcategory(Guid subcategoryId, Guid id, bool trackChanges);

        /* Crear autoparte */
        AutopartDto CreateAutopartForSubcategory(Guid subcategoryId, AutopartForCreationDto autopartForCreation, bool trackChanges);

        /* Actualizar una Autoparte */
        void UpdateAutopartForSubcategory(Guid subcategoryId, Guid id, AutopartForUpdateDto autopartForUpdate, bool subcTrackChanges, bool trackChanges);
    }
}
