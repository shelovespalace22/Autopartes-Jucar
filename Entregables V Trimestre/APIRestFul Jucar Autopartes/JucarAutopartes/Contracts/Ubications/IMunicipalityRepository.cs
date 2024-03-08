using Entities.Models.Ubications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Ubications
{
    public interface IMunicipalityRepository
    {
        Task<IEnumerable<Municipality>> GetMunicipalitiesAsync(Guid departmentId, bool trackChanges);

        Task<Municipality> GetMunicipalityAsync(Guid municipalityId, bool trackChanges);
    }
}
