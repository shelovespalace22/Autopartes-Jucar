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
    public class MovementRepository : RepositoryBase<Movement>, IMovementRepository
    {
        public MovementRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }


        /* Crear */

        public void CreateMovementForRawmaterial(Guid rawMaterialId, Movement movement)
        {
            movement.RawMaterialId = rawMaterialId;

            Create(movement);
        }


        /* Eliminar */

        public void DeleteMovement(Movement movement) => Delete(movement);


        /* Único Registro */

        public async Task<Movement> GetMovementByRawmaterialAsync(Guid rawMaterialId, Guid id, bool trackChanges) =>
            await FindByCondition(m => m.RawMaterialId.Equals(rawMaterialId) && m.MovementID.Equals(id), trackChanges)
            .SingleOrDefaultAsync();


        /* Listar */

        public async Task<IEnumerable<Movement>> GetMovementsAsync(Guid rawMaterialId, bool trackChanges) =>
            await FindByCondition(m => m.RawMaterialId.Equals(rawMaterialId), trackChanges)
            .OrderBy(m => m.MovementDate)
            .ToListAsync();
    }
}
