using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Products;
using Entities.Models.Products;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository.Products
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {       
        }

        /* Crear categoria */
        public void CreateCategory(Category category) => Create(category);

        /* Obtener todos los registros de la tabla */
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();

        /* Obtener un registro especifico */
        public async Task<Category> GetCategoryAsync(Guid categoryId, bool trackChanges) =>
            await FindByCondition(c => c.CategoryID.Equals(categoryId), trackChanges)
            .SingleOrDefaultAsync();

        /* Obtener una colección de registros */
        public async Task<IEnumerable<Category>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.CategoryID), trackChanges)
            .ToListAsync();

        /* Eliminar un registro y sus hijos*/
        public void DeleteCategory(Category category) => Delete(category);
    }
}
