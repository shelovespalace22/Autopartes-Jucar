using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;

namespace Contracts.Products
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);

        Category GetCategory(Guid categoryId, bool trackChanges);

        /* Crear Categoria */
        void CreateCategory(Category category);

        /* Obteniendo Colección de Categorias */
        IEnumerable<Category> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        /* Eliminar Categoria */
        void DeleteCategory(Category category);
    }
}
