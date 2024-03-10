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
    public class MunicipalityRepository : RepositoryBase<Municipality>, IMunicipalityRepository
    {
        public MunicipalityRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Municipality>> GetMunicipalitiesAsync(Guid departmentId, bool trackChanges) =>
            await FindByCondition(m => m.DepartmentId.Equals(departmentId), trackChanges)
            .OrderBy(m => m.Name)
            .ToListAsync();

        public async Task<Municipality> GetMunicipalityAsync(Guid municipalityId, bool trackChanges) =>
            await FindByCondition(m => m.MunicipalityID.Equals(municipalityId), trackChanges)
            .SingleOrDefaultAsync();
    }
}
