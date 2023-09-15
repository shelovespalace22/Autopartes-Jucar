using Contracts.Products;
using Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Products
{
    public class AutopartMaterialRepository : RepositoryBase<AutopartMaterial>, IAutopartMaterialRepository
    {
        public AutopartMaterialRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Obtener todos los materiales */
        public IEnumerable<AutopartMaterial> GetAllMaterials(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(m => m.CreationDate)
            .ToList();
    }
}
