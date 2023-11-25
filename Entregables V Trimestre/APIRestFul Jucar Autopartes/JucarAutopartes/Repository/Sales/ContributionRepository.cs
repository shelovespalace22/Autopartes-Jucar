using Contracts.Sales;
using Entities.Models.Sales;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sales
{
    public class ContributionRepository : RepositoryBase<Contribution>, IContributionRepository
    {
        public ContributionRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Crear */
        public void CreateContribution(Guid orderId, Contribution contribution)
        {
            contribution.OrderId = orderId;

            Create(contribution);
        }

        /* Eliminar */
        public void DeleteContribution(Contribution contribution) => Delete(contribution);

        /* Un registro */
        public async Task<Contribution> GetContributionByOrderAsync(Guid orderId, Guid id, bool trackChanges) =>
            await FindByCondition(c => c.OrderId.Equals(orderId) && c.ContributionID.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        /* Listar */
        public async Task<IEnumerable<Contribution>> GetContributionsAsync(Guid orderId, bool trackChanges) =>
            await FindByCondition(c => c.OrderId.Equals(orderId), trackChanges)
            .OrderBy(c => c.AmountPaid)
            .ToListAsync();
    }
}
