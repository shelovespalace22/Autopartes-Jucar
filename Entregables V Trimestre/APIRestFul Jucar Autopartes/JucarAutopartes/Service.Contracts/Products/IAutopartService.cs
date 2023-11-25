using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;
using Shared.DataTransferObjects.Products;

namespace Service.Contracts.Products
{
    public interface IAutopartService
    {
        /* Crear autoparte */
        Task<AutopartDto> CreateAutopartForSubcategoryAsync(Guid subcategoryId, AutopartForCreationDto autopartForCreation, bool trackChanges);

        /* Obteniendo todas las Autopartes en general */
        Task<IEnumerable<AutopartDto>> GetAllAutopartsAsync(bool trackChanges);

        /* Obteniendo Autoparte por su Id */
        Task<AutopartDto> GetAutopartByIdAsync(Guid autopartId, bool trackChanges);

        /* Obtener todas las Autopartes de una Subcategoria */
        Task<IEnumerable<AutopartDto>> GetAutopartsAsync(Guid subcategoryId, bool trackChanges);

        /* Obtener una Autoparte especifica de una Subcategoria */
        Task<AutopartDto> GetAutopartBySubcategoryAsync(Guid subcategoryId, Guid id, bool trackChanges);

        /* Obtener Collección de Subcategorías de una Categoría */
        Task<IEnumerable<AutopartDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);

        /* Actualizar una Autoparte */
        Task UpdateAutopartForSubcategoryAsync(Guid subcategoryId, Guid id, AutopartForUpdateDto autopartForUpdate, bool subcTrackChanges, bool trackChanges);

        /* Eliminar una Autoparte */
        Task DeleteAutopartForSubcategoryAsync(Guid subcategoryId, Guid id, bool trackChanges);
    }
}
