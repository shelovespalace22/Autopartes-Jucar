using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models.Products;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext repositoryContext)
        :base(repositoryContext)
        {
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        public Category GetCategory(Guid categoryId, bool trackChanges) =>
            FindByCondition(c => c.CategoryID.Equals(categoryId), trackChanges)
            .SingleOrDefault();

        public void CreateCategory(Category category) => Create(category);
    }
}
