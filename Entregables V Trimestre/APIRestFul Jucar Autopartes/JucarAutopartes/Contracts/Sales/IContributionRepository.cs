using Entities.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Sales
{
    public interface IContributionRepository
    {
        /* Crear */
        void CreateContribution(Guid orderId, Contribution contribution);

        /* Listar */
        Task<IEnumerable<Contribution>> GetContributionsAsync(Guid orderId, bool trackChanges);

        /* Un registro */
        Task<Contribution> GetContributionByOrderAsync(Guid orderId, Guid id, bool trackChanges);

        /* Eliminar */
        void DeleteContribution(Contribution contribution);
    }
}
