using Entities.Models.Ubications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Ubications
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartmentsAsync(bool trackChanges);

        Task<Department> GetDepartmentAsync(Guid departmentId, bool trackChanges);
    }
}
