using Contracts.Products;
using Entities.Models.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Products
{
    public class RawMaterialRepository : RepositoryBase<RawMaterial>, IRawMaterialRepository
    {
        public RawMaterialRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        /* Obtener todas las Materias Primas */

        public async Task<IEnumerable<RawMaterial>> GetAllRawMaterialsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(r => r.Name)
            .ToListAsync();

        /* Obtener una Materia Prima */

        public async Task<RawMaterial> GetRawMaterialAsync(Guid rawMaterialId, bool trackChanges) =>
            await FindByCondition(r => r.RawMaterialID.Equals(rawMaterialId), trackChanges)
            .Include(r => r.Stock)
            .SingleOrDefaultAsync();

        /* Crear Materia Prima*/

        public void CreateRawMaterial(RawMaterial rawMaterial) => Create(rawMaterial);

        /* Obtener colección de Materias Primas */

        public async Task<IEnumerable<RawMaterial>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.RawMaterialID), trackChanges)
            .ToListAsync();

        /* Eliminar una Materia Prima */
        public void DeleteRawMaterial(RawMaterial rawMaterial) => Delete(rawMaterial);
    }
}
