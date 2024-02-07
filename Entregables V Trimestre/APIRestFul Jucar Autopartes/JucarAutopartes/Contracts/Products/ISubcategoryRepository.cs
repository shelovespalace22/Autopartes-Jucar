using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;

namespace Contracts.Products
{
    public interface ISubcategoryRepository
    {
        /* Crear una Subcategoria */
        void CreateSubcategoryForCategory(Guid categoryId, Subcategory subcategory);

        /* Obtener todas las Subcategorias en general*/
        Task<IEnumerable<Subcategory>> GetAllSubcategoriesAsync(bool trackChanges);

        /* Obtener una Subcategoria especifica */
        Task<Subcategory> GetSubcategoryByIdAsync(Guid subcategoryId, bool trackChanges);

        /* Obtener todas las Subcategorias de una Categoria */
        Task<IEnumerable<Subcategory>> GetSubcategoriesAsync(Guid categoryId, bool trackChanges);

        /* Obtener una Subcategoria especifica de una Categoria */
        Task<Subcategory> GetSubcategoryByCategoryAsync(Guid categoryId, Guid id, bool trackChanges);

        /* Obtener una colección de Subcategorías de una Categoría*/
        Task<IEnumerable<Subcategory>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);

        /* Eliminar una Subcategoria */
        void DeleteSubcategory(Subcategory subcategory);
    }
}
