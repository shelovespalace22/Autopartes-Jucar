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
        public ContributionDto CreateContribution(Guid orderId, ContributionForCreationDto contribution, bool trackChanges)
        {
            var order = _repository.Order.GetOrder(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var contributionEntity = _mapper.Map<Contribution>(contribution);

            _repository.Contribution.CreateContribution(orderId, contributionEntity);

            _repository.Save();

            var contributionToRetun = _mapper.Map<ContributionDto>(contributionEntity);

            return contributionToRetun;
        }

        /* Eliminar */
        public void DeleteContribution(Guid orderId, Guid id, bool trackChanges)
        {
            var order = _repository.Order.GetOrder(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var contributionFromOrder = _repository.Contribution.GetContributionByOrder(orderId, id, trackChanges);

            if (contributionFromOrder is null)
                throw new ContributionNotFoundException(id);

            _repository.Contribution.DeleteContribution(contributionFromOrder);

            _repository.Save();
        }

        /* Un registro */
        public ContributionDto GetContribution(Guid orderId, Guid id, bool trackChanges)
        {
            var order = _repository.Order.GetOrder(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var contributionDb = _repository.Contribution.GetContributionByOrder(orderId, id, trackChanges);

            if (contributionDb is null)
                throw new ContributionNotFoundException(id);

            var contribution = _mapper.Map<ContributionDto>(contributionDb);

            return contribution;
        }

        /* Listar */
        public IEnumerable<ContributionDto> GetContributions(Guid orderId, bool trackChanges)
        {
            var order = _repository.Order.GetOrder(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var contributionsFromDb = _repository.Contribution.GetContributions(orderId, trackChanges);

            var contributionsDto = _mapper.Map<IEnumerable<ContributionDto>>(contributionsFromDb);

            return contributionsDto;
        }

        /* Actualizar */
        public void UpdateContribution(Guid orderId, Guid id, ContributionForUpdateDto contributionForUpdate, bool ordTrackChanges, bool conTrackChanges)
        {
            var order = _repository.Order.GetOrder(orderId, ordTrackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var contributionEntity = _repository.Contribution.GetContributionByOrder(orderId, id, conTrackChanges);

            if (contributionEntity is null)
                throw new ContributionNotFoundException(id);

            _mapper.Map(contributionForUpdate, contributionEntity);

            contributionEntity.setModificationDate();

            _repository.Save();
        }
    }
}
