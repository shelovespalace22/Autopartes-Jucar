using Shared.DataTransferObjects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Products
{
    public interface ILossService
    {
        /* Crear*/
        Task<LossDto> CreateLossForAutopartAsync(Guid autopartId, LossForCreationDto lossForCreation, bool trackChanges);

        /* Listar */
        Task<IEnumerable<LossDto>> GetLossesAsync(Guid autopartId, bool trackChanges);

        /* Único Registro */
        Task<LossDto> GetLossByAutopartAsync(Guid autopartId, Guid id, bool trackChanges);

        /* Actualizar */
        Task UpdateLossForAutopartAsync(Guid autopartId, Guid id, LossForUpdateDto lossForUpdate, bool autTrackChanges, bool losTrackChanges);

        /* Eliminar */
        Task DeleteLossForAutopartAsync(Guid autopartId, Guid id, bool trackChanges);
    }
}
