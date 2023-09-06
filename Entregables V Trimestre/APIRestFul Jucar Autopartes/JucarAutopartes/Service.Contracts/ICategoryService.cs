using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAllCategories(bool trackChanges);

        CategoryDto GetCategory(Guid categoryId, bool trackChanges);

        /* Crear Categoria */
        CategoryDto CreateCategory(CategoryForCreationDto category);

        /* Obtener Collección de Categorias */
        IEnumerable<CategoryDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        /* Crear Collección de Categorias */
        (IEnumerable<CategoryDto> categories, string ids) CreateCategoryCollection
            (IEnumerable<CategoryForCreationDto> categoryCollection);

        /* Eliminar una Categoria */
        void DeleteCategory(Guid categoryId, bool trackChanges);

    }
}
