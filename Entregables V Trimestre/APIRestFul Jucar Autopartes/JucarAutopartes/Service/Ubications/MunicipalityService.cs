using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Ubications;
using Entities.Models.Ubications;
using Service.Contracts.Ubications;
using Shared.DataTransferObjects.Ubications.Municipality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Ubications
{
    internal sealed class MunicipalityService : IMunicipaliityService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MunicipalityService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MunicipalityDto>> GetMunicipalitiesAsync(Guid departmentId, bool trackChanges)
        {
            await CheckIfDepartmentExists(departmentId, trackChanges);

            var municipalitiesFromDb = await _repository.Municipality.GetMunicipalitiesAsync(departmentId, trackChanges);

            var municipalitiesDto = _mapper.Map<IEnumerable<MunicipalityDto>>(municipalitiesFromDb);

            return municipalitiesDto;
        }



        /* Métodos Privados */

        private async Task<Department> CheckIfDepartmentExists(Guid departmentId, bool trackChanges)
        {
            var department = await _repository.Department.GetDepartmentAsync(departmentId, trackChanges);

            if (department is null)
                throw new DepartmentNotFoundException(departmentId);

            return department;
        }
    }
}
