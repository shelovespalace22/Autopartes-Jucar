using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Products;
using Entities.Models.Products;
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
        public IEnumerable<Category> GetAllCategories(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        /* Obtener un registro especifico */
        public Category GetCategory(Guid categoryId, bool trackChanges) =>
            FindByCondition(c => c.CategoryID.Equals(categoryId), trackChanges)
            .SingleOrDefault();

        /* Obtener una colección de registros */
        public IEnumerable<Category> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.CategoryID), trackChanges)
            .ToList();

        /* Eliminar un registro y sus hijos*/
        public void DeleteCategory(Category category) => Delete(category);
    }
}
