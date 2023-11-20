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
        LossDto CreateLossForAutopart(Guid autopartId, LossForCreationDto lossForCreation, bool trackChanges);

        /* Listar */
        IEnumerable<LossDto> GetLosses(Guid autopartId, bool trackChanges);

        /* Único Registro */
        LossDto GetLossByAutopart(Guid autopartId, Guid id, bool trackChanges);

        /* Actualizar */
        void UpdateLossForAutopart(Guid autopartId, Guid id, LossForUpdateDto lossForUpdate, bool autTrackChanges, bool losTrackChanges);

        /* Eliminar */
        void DeleteLossForAutopart(Guid autopartId, Guid id, bool trackChanges);
    }
}
