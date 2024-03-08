using Shared.DataTransferObjects.Ubications.Municipality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Ubications
{
    public interface IMunicipaliityService
    {
        Task<IEnumerable<MunicipalityDto>> GetMunicipalitiesAsync(Guid departmentId, bool trackChanges);
    }
}
