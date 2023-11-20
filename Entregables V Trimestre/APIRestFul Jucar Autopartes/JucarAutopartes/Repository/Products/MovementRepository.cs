using Contracts.Products;
using Entities.Models.Products;
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

        public Movement GetMovementByRawmaterial(Guid rawMaterialId, Guid id, bool trackChanges) =>
            FindByCondition(m => m.RawMaterialId.Equals(rawMaterialId) && m.MovementID.Equals(id), trackChanges)
            .SingleOrDefault();


        /* Listar */

        public IEnumerable<Movement> GetMovements(Guid rawMaterialId, bool trackChanges) =>
            FindByCondition(m => m.RawMaterialId.Equals(rawMaterialId), trackChanges)
            .OrderBy(m => m.MovementDate)
            .ToList();
    }
}
