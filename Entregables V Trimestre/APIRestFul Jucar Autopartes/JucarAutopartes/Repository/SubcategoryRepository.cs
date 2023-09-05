using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models.Products;

namespace Repository
{
    public class SubcategoryRepository : RepositoryBase<Subcategory>, ISubcategoryRepository
    {
        public SubcategoryRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Obtener todas las Subcategorias en general*/
        public IEnumerable<Subcategory> GetAllSubcategories(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        /* Obtener una Subcategoria por su Id */
        public Subcategory GetSubcategoryById(Guid subcategoryId, bool trackChanges) =>
            FindByCondition(s => s.SubcategoryID.Equals(subcategoryId), trackChanges)
            .SingleOrDefault();

        /* Obtener todas las Subcategorias de una Categoria */
        public IEnumerable<Subcategory> GetSubcategories(Guid categoryId, bool trackChanges) =>
            FindByCondition(s => s.CategoryId.Equals(categoryId), trackChanges)
            .OrderBy(s => s.Name)
            .ToList();

        public Subcategory GetSubcategoryByCompany(Guid categoryId, Guid id, bool trackChanges) =>
            FindByCondition(s => s.CategoryId.Equals(categoryId) && s.SubcategoryID.Equals(id), trackChanges)
            .SingleOrDefault();
    }
}
