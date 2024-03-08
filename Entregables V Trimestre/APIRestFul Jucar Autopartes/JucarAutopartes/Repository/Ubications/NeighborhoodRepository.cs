using Contracts.Ubications;
using Entities.Models.Ubications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Ubications
{
    public class NeighborhoodRepository : RepositoryBase<Neighborhood>, INeighborhoodRepository
    {
        public NeighborhoodRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Neighborhood>> GetNeighborhoodsAsync(Guid municipalityId, bool trackChanges) =>
            await FindByCondition(n => n.MunicipalityId.Equals(municipalityId), trackChanges)
            .OrderBy(n => n.Name)
            .ToListAsync();
    }
}
