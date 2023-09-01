using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;

namespace Service.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
    }
}
