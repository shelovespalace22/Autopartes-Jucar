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
        ContributionDto CreateContribution(Guid orderId, ContributionForCreationDto contribution, bool trackChanges);

        /* Listar */
        IEnumerable<ContributionDto> GetContributions(Guid orderId, bool trackChanges);

        /* Un registro */
        ContributionDto GetContribution(Guid orderId, Guid id, bool trackChanges);

        /* Actualizar */
        void UpdateContribution(Guid orderId, Guid id, ContributionForUpdateDto contributionForUpdate, bool ordTrackChanges, bool conTrackChanges);

        /* Eliminar */
        void DeleteContribution(Guid orderId, Guid id, bool trackChanges);
    }
}
