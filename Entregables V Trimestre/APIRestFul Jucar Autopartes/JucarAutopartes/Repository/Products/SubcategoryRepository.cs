using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Products;
using Entities.Models.Products;
using Microsoft.EntityFrameworkCore;

namespace Repository.Products
{
    public class SubcategoryRepository : RepositoryBase<Subcategory>, ISubcategoryRepository
    {
        public SubcategoryRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        /* Crear una Subcategoria */
        public void CreateSubcategoryForCategory(Guid categoryId, Subcategory subcategory)
        {
            subcategory.CategoryId = categoryId;

            Create(subcategory);
        }

        /* Obtener todas las Subcategorias en general*/
        public async Task<IEnumerable<Subcategory>> GetAllSubcategoriesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();

        /* Obteber una Subcategoria */
        public async Task<Subcategory> GetSubcategoryByIdAsync(Guid subcategoryId, bool trackChanges) =>
            await FindByCondition(s => s.SubcategoryID.Equals(subcategoryId), trackChanges)
            .SingleOrDefaultAsync();

        /* Obtener todas las Subcategorias de una Categoria */
        public async Task<IEnumerable<Subcategory>> GetSubcategoriesAsync(Guid categoryId, bool trackChanges) =>
            await FindByCondition(s => s.CategoryId.Equals(categoryId), trackChanges)
            .OrderBy(s => s.Name)
            .ToListAsync();

        /* Obteniendo una Subcategoria especifica de la Categoria */
        public async Task<Subcategory> GetSubcategoryByCategoryAsync(Guid categoryId, Guid id, bool trackChanges) =>
            await FindByCondition(s => s.CategoryId.Equals(categoryId) && s.SubcategoryID.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        /* Obtener una colección de Subcategorías de una Categoría*/
        public async Task<IEnumerable<Subcategory>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.SubcategoryID), trackChanges)
            .ToListAsync();

        /* Eliminar una Subcategoria */
        public void DeleteSubcategory(Subcategory subcategory) => Delete(subcategory);
    }
}
