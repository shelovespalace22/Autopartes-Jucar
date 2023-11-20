using Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Products
{
    public interface IMovementRepository
    {
        /* Crear */
        void CreateMovementForRawmaterial(Guid rawMaterialId, Movement movement);

        /* Listar */
        IEnumerable<Movement> GetMovements(Guid rawMaterialId, bool trackChanges);

        /* Único Registro */
        Movement GetMovementByRawmaterial(Guid rawMaterialId, Guid id, bool trackChanges);

        /* Eliminar*/
        void DeleteMovement(Movement movement);
    }
}
