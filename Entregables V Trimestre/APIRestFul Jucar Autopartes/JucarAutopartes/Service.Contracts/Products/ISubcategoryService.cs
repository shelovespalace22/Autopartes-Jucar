using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;
using Shared.DataTransferObjects.Products;

namespace Service.Contracts.Products
{
    public interface ISubcategoryService
    {
        /* Crear Subcategoria */
        Task<SubcategoryDto> CreateSubcategoryForCategoryAsync(Guid categoryId, SubcategoryForCreationDto subcategoryForCreation, bool trackChanges);

        /* Obtener todas las Subcategorias en general*/
        Task<IEnumerable<SubcategoryDto>> GetAllSubcategoriesAsync(bool trackChanges);

        /* Obtener una Subcategoria especifica */
        Task<SubcategoryDto> GetSubcategoryByIdAsync(Guid subcategoryId, bool trackChanges);

        /* Obtener todas las subcategorias de una Categoria */
        Task<IEnumerable<SubcategoryDto>> GetSubcategoriesAsync(Guid categoryId, bool trackChanges);

        /* Obtener una Subcategoria especifica de una Categoria */
        Task<SubcategoryDto> GetSubcategoryByCategoryAsync(Guid categoryId, Guid id, bool trackChanges);

        /* Obtener Collección de Subcategorías de una Categoría */
        Task<IEnumerable<SubcategoryDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);

        /* Actualizar una Subcategoría */
        Task UpdateSubcategoryForCategoryAsync(Guid categoryId, Guid id, SubcategoryForUpdateDto subcategoryForUpdate, bool catTrackChanges, bool subTrackChanges);

        /* Eliminar una Subcategoria */
        Task DeleteSubcategoryForCategoryAsync(Guid categoryId, Guid id, bool trackChanges);
    }
}
