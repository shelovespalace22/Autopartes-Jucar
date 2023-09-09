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
        /* Obtener todas las Subcategorias en general*/
        IEnumerable<SubcategoryDto> GetAllSubcategories(bool trackChanges);

        /* Obtener una Subcategoria por su Id */
        SubcategoryDto GetSubcategoryById(Guid subcategoryId, bool trackChanges);

        /* Obtener todas las subcategorias de una Categoria */
        IEnumerable<SubcategoryDto> GetSubcategories(Guid categoryId, bool trackChanges);

        /* Obtener una Subcategoria especifica de una Categoria */
        SubcategoryDto GetSubcategoryByCategory(Guid categoryId, Guid id, bool trackChanges);

        /* Crear Subcategoria */
        SubcategoryDto CreateSubcategoryForCategory(Guid categoryId, SubcategoryForCreationDto subcategoryForCreation, bool trackChanges);

        /* Eliminar una Subcategoria */
        void DeleteSubcategoryForCategory(Guid categoryId, Guid id, bool trackChanges);
    }
}
