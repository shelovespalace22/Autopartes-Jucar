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
        IEnumerable<Subcategory> GetAllSubcategories(bool trackChanges);

        Subcategory GetSubcategory(Guid subcategoryId, bool trackChanges);
    }
}
