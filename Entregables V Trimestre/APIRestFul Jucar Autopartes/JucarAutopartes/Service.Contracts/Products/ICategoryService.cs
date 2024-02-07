using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;
using Shared.DataTransferObjects.Products;

namespace Service.Contracts.Products
{
    public interface ICategoryService
    {
        /* Crear Categoria */
        Task<CategoryDto> CreateCategoryAsync(CategoryForCreationDto category);

        /* Crear Collección de Categorias */
        Task<(IEnumerable<CategoryDto> categories, string ids)> CreateCategoryCollectionAsync
            (IEnumerable<CategoryForCreationDto> categoryCollection);

        /* Obtener todos los registros de la tabla */
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync(bool trackChanges);

        /* Obtener un registro especifico */
        Task<CategoryDto> GetCategoryAsync(Guid categoryId, bool trackChanges);

        /* Obtener Collección de Categorias */
        Task<IEnumerable<CategoryDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);

        /* Actualizar una categoria */
        Task UpdateCategoryAsync(Guid categoryId, CategoryForUpdateDto categoryForUpdate, bool trackChanges);

        /* Eliminar una Categoria */
        Task DeleteCategoryAsync(Guid categoryId, bool trackChanges);

    }
}
