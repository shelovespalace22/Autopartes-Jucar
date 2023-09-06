using Contracts;
using Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RawMaterialRepository : RepositoryBase<RawMaterial>, IRawMaterialRepository
    {
        public RawMaterialRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Crear un RawMaterial */
        public void CreateRawMaterial(RawMaterial rawMaterial) => Create(rawMaterial);
    }
}
