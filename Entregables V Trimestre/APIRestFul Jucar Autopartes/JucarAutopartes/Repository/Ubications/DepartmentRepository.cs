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
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

        public async Task<Department> GetDepartmentAsync(Guid departmentId, bool trackChanges) =>
            await FindByCondition(d => d.DepartmentID.Equals(departmentId), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<IEnumerable<Department>> GetDepartmentsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(d => d.Name)
            .ToListAsync();
        
    }
}
