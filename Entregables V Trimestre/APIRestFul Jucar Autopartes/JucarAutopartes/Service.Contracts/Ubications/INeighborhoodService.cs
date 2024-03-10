using Shared.DataTransferObjects.Ubications.Neighborhood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Ubications
{
    public interface INeighborhoodService
    {
        Task<IEnumerable<NeighborhoodDto>> GetNeighborhoodsAsync(Guid municipalityId, bool trackChanges);
    }
}
