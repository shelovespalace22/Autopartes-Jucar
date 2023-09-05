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

        public IEnumerable<Subcategory> GetAllSubcategories(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        public Subcategory GetSubcategory(Guid subcategoryId, bool trackChanges) =>
            FindByCondition(s => s.SubcategoryID.Equals(subcategoryId), trackChanges)
            .SingleOrDefault();
    }
}
