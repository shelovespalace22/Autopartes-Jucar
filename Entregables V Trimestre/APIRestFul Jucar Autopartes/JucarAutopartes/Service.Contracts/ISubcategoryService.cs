using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;
using Shared.DataTransferObjects;

namespace Service.Contracts
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
        SubcategoryDto GetSubcategoryByCompany(Guid categoryId, Guid id, bool trackChanges);
    }
}
