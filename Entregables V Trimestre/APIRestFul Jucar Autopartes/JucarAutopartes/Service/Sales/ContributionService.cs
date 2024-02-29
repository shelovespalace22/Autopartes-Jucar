using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Providers;
using Entities.Exceptions.NotFound.Sales;
using Entities.Models.Providers;
using Entities.Models.Sales;
using Service.Contracts.Sales;
using Shared.DataTransferObjects.Sales.Contribution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Sales
{
    internal sealed class ContributionService : IContributionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ContributionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear */
        public async Task<ContributionDto> CreateContributionAsync(Guid orderId, ContributionForCreationDto contribution, bool trackChanges)
        {
            await CheckIfOrderExists(orderId, trackChanges);

            var contributionEntity = _mapper.Map<Contribution>(contribution);

            _repository.Contribution.CreateContribution(orderId, contributionEntity);

            await _repository.SaveAsync();

            var contributionToRetun = _mapper.Map<ContributionDto>(contributionEntity);

            return contributionToRetun;
        }

        /* Eliminar */
        public async Task DeleteContributionAsync(Guid orderId, Guid id, bool trackChanges)
        {
            await CheckIfOrderExists(orderId, trackChanges);

            var contributionFromOrder = await GetContributionForOrderAndCheckIfItExists(orderId, id, trackChanges);

            _repository.Contribution.DeleteContribution(contributionFromOrder);

            await _repository.SaveAsync();
        }

        /* Un registro */
        public async Task<ContributionDto> GetContributionAsync(Guid orderId, Guid id, bool trackChanges)
        {
            await CheckIfOrderExists(orderId, trackChanges);

            var contributionDb = await GetContributionForOrderAndCheckIfItExists(orderId, id, trackChanges);

            var contribution = _mapper.Map<ContributionDto>(contributionDb);

            return contribution;
        }

        /* Listar */
        public async Task<IEnumerable<ContributionDto>> GetContributionsAsync(Guid orderId, bool trackChanges)
        {
            await CheckIfOrderExists(orderId, trackChanges);

            var contributionsFromDb = await _repository.Contribution.GetContributionsAsync(orderId, trackChanges);

            var contributionsDto = _mapper.Map<IEnumerable<ContributionDto>>(contributionsFromDb);

            return contributionsDto;
        }

        /* Actualizar */
        public async Task UpdateContributionAsync(Guid orderId, Guid id, ContributionForUpdateDto contributionForUpdate, bool ordTrackChanges, bool conTrackChanges)
        {
            await CheckIfOrderExists(orderId, ordTrackChanges);

            var contributionEntity = await GetContributionForOrderAndCheckIfItExists(orderId, id, conTrackChanges);

            _mapper.Map(contributionForUpdate, contributionEntity);

            contributionEntity.setModificationDate();

            await _repository.SaveAsync();
        }





        /* <----- Métodos Privados -----> */

        private async Task CheckIfOrderExists(Guid orderId, bool trackChanges)
        {
            var order = await _repository.Order.GetOrderByIdAsync(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);
        }


        private async Task<Contribution> GetContributionForOrderAndCheckIfItExists(Guid orderId, Guid id, bool trackChanges)
        {
            var contribution = await _repository.Contribution.GetContributionByOrderAsync(orderId, id, trackChanges);

            if (contribution is null)
                throw new ContributionNotFoundException(id);

            return contribution;
        }
    }
}
