using Contracts.Sales;
using Entities.Models.Sales;
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
        public Contribution GetContributionByOrder(Guid orderId, Guid id, bool trackChanges) =>
            FindByCondition(c => c.OrderId.Equals(orderId) && c.ContributionID.Equals(id), trackChanges)
            .SingleOrDefault();

        /* Listar */
        public IEnumerable<Contribution> GetContributions(Guid orderId, bool trackChanges) =>
            FindByCondition(c => c.OrderId.Equals(orderId), trackChanges)
            .OrderBy(c => c.AmountPaid)
            .ToList();
    }
}
