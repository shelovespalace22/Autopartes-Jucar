using Shared.DataTransferObjects.Providers.ProviderPhone;
using Shared.DataTransferObjects.Sales.Contribution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Sales
{
    public interface IContributionService
    {
        /* Crear */
        Task<ContributionDto> CreateContributionAsync(Guid orderId, ContributionForCreationDto contribution, bool trackChanges);

        /* Listar */
        Task<IEnumerable<ContributionDto>> GetContributionsAsync(Guid orderId, bool trackChanges);

        /* Un registro */
        Task<ContributionDto> GetContributionAsync(Guid orderId, Guid id, bool trackChanges);

        /* Actualizar */
        Task UpdateContributionAsync(Guid orderId, Guid id, ContributionForUpdateDto contributionForUpdate, bool ordTrackChanges, bool conTrackChanges);

        /* Eliminar */
        Task DeleteContributionAsync(Guid orderId, Guid id, bool trackChanges);
    }
}
