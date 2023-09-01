using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models.Products;

namespace Repository
{
    public class AutopartRepository : RepositoryBase<Autopart>, IAutopartRepository
    {
        public AutopartRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        public IEnumerable<Autopart> GetAllAutoparts(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();
    }
}
