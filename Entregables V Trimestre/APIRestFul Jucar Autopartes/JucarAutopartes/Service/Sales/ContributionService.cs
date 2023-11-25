using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Sales;
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
            var order = await _repository.Order.GetOrderAsync(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var contributionEntity = _mapper.Map<Contribution>(contribution);

            _repository.Contribution.CreateContribution(orderId, contributionEntity);

            await _repository.SaveAsync();

            var contributionToRetun = _mapper.Map<ContributionDto>(contributionEntity);

            return contributionToRetun;
        }

        /* Eliminar */
        public async Task DeleteContributionAsync(Guid orderId, Guid id, bool trackChanges)
        {
            var order = await _repository.Order.GetOrderAsync(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var contributionFromOrder = await _repository.Contribution.GetContributionByOrderAsync(orderId, id, trackChanges);

            if (contributionFromOrder is null)
                throw new ContributionNotFoundException(id);

            _repository.Contribution.DeleteContribution(contributionFromOrder);

            await _repository.SaveAsync();
        }

        /* Un registro */
        public async Task<ContributionDto> GetContributionAsync(Guid orderId, Guid id, bool trackChanges)
        {
            var order = await _repository.Order.GetOrderAsync(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var contributionDb = await _repository.Contribution.GetContributionByOrderAsync(orderId, id, trackChanges);

            if (contributionDb is null)
                throw new ContributionNotFoundException(id);

            var contribution = _mapper.Map<ContributionDto>(contributionDb);

            return contribution;
        }

        /* Listar */
        public async Task<IEnumerable<ContributionDto>> GetContributionsAsync(Guid orderId, bool trackChanges)
        {
            var order = await _repository.Order.GetOrderAsync(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var contributionsFromDb = await _repository.Contribution.GetContributionsAsync(orderId, trackChanges);

            var contributionsDto = _mapper.Map<IEnumerable<ContributionDto>>(contributionsFromDb);

            return contributionsDto;
        }

        /* Actualizar */
        public async Task UpdateContributionAsync(Guid orderId, Guid id, ContributionForUpdateDto contributionForUpdate, bool ordTrackChanges, bool conTrackChanges)
        {
            var order = await _repository.Order.GetOrderAsync(orderId, ordTrackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var contributionEntity = await _repository.Contribution.GetContributionByOrderAsync(orderId, id, conTrackChanges);

            if (contributionEntity is null)
                throw new ContributionNotFoundException(id);

            _mapper.Map(contributionForUpdate, contributionEntity);

            contributionEntity.setModificationDate();

            await _repository.SaveAsync();
        }
    }
}
