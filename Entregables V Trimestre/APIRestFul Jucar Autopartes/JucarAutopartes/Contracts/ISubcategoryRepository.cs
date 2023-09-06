using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;

namespace Contracts
{
    public interface ISubcategoryRepository
    {
        /* Obtener todas las Subcategorias en general*/
        IEnumerable<Subcategory> GetAllSubcategories(bool trackChanges);

        /* Obtener una Subcategoria por su Id */
        Subcategory GetSubcategoryById(Guid subcategoryId, bool trackChanges);

        /* Obtener todas las Subcategorias de una Categoria */
        IEnumerable<Subcategory> GetSubcategories(Guid subcategoryId, bool trackChanges);

        /* Obtener una Subcategoria especifica de una Categoria */
        Subcategory GetSubcategoryByCategory(Guid categoryId, Guid id, bool trackChanges);

        /* Crear una Subcategoria */
        void CreateSubcategoryForCategory(Guid categoryId, Subcategory subcategory);
    }
}
