using Entities.Models.Ubications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Ubications
{
    public interface INeighborhoodRepository
    {
        Task<IEnumerable<Neighborhood>> GetNeighborhoodsAsync(Guid municipalityId, bool trackChanges);
    }
}
