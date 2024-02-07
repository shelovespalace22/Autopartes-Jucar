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
        Task<MovementDto> CreateMovementForRawmaterialAsync(Guid rawMaterialId, MovementForCreationDto movementForCreation, bool trackChanges);

        /* Listar */
        Task<IEnumerable<MovementDto>> GetMovementsAsync(Guid rawMaterialId, bool trackChanges);

        /* Único Registro */
        Task<MovementDto> GetMovementForRawmaterialAsync(Guid rawMaterialId, Guid id, bool trackChanges);

        /* Actualizar */
        Task UpdateMovementForRawmaterialAsync(Guid rawMaterialId, Guid id, MovementForUpdateDto movementForUpdate, bool rawTrackChanges, bool movTrackChanges);

        /* Eliminar */
        Task DeleteMovementForRawmaterialAsync(Guid rawMaterialId, Guid id, bool trackChanges);
    }
}
