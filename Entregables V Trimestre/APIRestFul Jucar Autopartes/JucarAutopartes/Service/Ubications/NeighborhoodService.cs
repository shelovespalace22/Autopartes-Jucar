using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Ubications;
using Entities.Models.Ubications;
using Service.Contracts.Ubications;
using Shared.DataTransferObjects.Ubications.Neighborhood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Ubications
{
    internal sealed class NeighborhoodService : INeighborhoodService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public NeighborhoodService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<NeighborhoodDto>> GetNeighborhoodsAsync(Guid municipalityId, bool trackChanges)
        {
            await CheckIfMunicipalityExists(municipalityId, trackChanges);

            var neighborhoodsFromDb = await _repository.Neighborhood.GetNeighborhoodsAsync(municipalityId, trackChanges);

            var neighborhoodsDto = _mapper.Map<IEnumerable<NeighborhoodDto>>(neighborhoodsFromDb);

            return neighborhoodsDto;
        }



        /* Métodos Privados */

        private async Task<Municipality> CheckIfMunicipalityExists(Guid municipalityId, bool trackChanges)
        {
            var municipality = await _repository.Municipality.GetMunicipalityAsync(municipalityId, trackChanges);

            if (municipality is null)
                throw new MunicipalityNotFoundException(municipalityId);

            return municipality;
        }
    }
}
