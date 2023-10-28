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
        CategoryDto CreateCategory(CategoryForCreationDto category);

        /* Crear Collección de Categorias */
        (IEnumerable<CategoryDto> categories, string ids) CreateCategoryCollection
            (IEnumerable<CategoryForCreationDto> categoryCollection);

        /* Obtener todos los registros de la tabla */
        IEnumerable<CategoryDto> GetAllCategories(bool trackChanges);

        /* Obtener un registro especifico */
        CategoryDto GetCategory(Guid categoryId, bool trackChanges);

        /* Obtener Collección de Categorias */
        IEnumerable<CategoryDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        /* Actualizar una categoria */
        void UpdateCategory(Guid categoryId, CategoryForUpdateDto categoryForUpdate, bool trackChanges);

        /* Eliminar una Categoria */
        void DeleteCategory(Guid categoryId, bool trackChanges);

    }
}
