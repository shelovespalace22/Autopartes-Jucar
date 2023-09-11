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
        IEnumerable<Subcategory> GetAllSubcategories(bool trackChanges);

        /* Obtener una Subcategoria especifica */
        Subcategory GetSubcategoryById(Guid subcategoryId, bool trackChanges);
       
        /* Obtener todas las Subcategorias de una Categoria */
        IEnumerable<Subcategory> GetSubcategories(Guid subcategoryId, bool trackChanges);

        /* Obtener una Subcategoria especifica de una Categoria */
        Subcategory GetSubcategoryByCategory(Guid categoryId, Guid id, bool trackChanges);

        /* Obtener una colección de Subcategorías de una Categoría*/
        IEnumerable<Subcategory> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        /* Actualizar una Subcategoría */



        /* Eliminar una Subcategoria */
        void DeleteSubcategory(Subcategory subcategory);
    }
}
