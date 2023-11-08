using Shared.DataTransferObjects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Products
{
    public interface IMovementService
    {
        /* Crear*/
        MovementDto CreateMovementForRawmaterial(Guid rawMaterialId, MovementForCreationDto movementForCreation, bool trackChanges);

        /* Listar */
        IEnumerable<MovementDto> GetMovements(Guid rawMaterialId, bool trackChanges);

        /* Único Registro */
        MovementDto GetMovementForRawmaterial(Guid rawMaterialId, Guid id, bool trackChanges);

        /* Actualizar */
        void UpdateMovementForRawmaterial(Guid rawMaterialId, Guid id, MovementForUpdateDto movementForUpdate, bool rawTrackChanges, bool movTrackChanges);

        /* Eliminar */
        void DeleteMovementForRawmaterial(Guid rawMaterialId, Guid id, bool trackChanges);
    }
}
