using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Products;
using Entities.Models.Products;
using Service.Contracts.Products;
using Shared.DataTransferObjects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Products
{
    internal sealed class LossService : ILossService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public LossService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear */
        public async Task<LossDto> CreateLossForAutopartAsync(Guid autopartId, LossForCreationDto lossForCreation, bool trackChanges)
        {
            await CheckIfAutopartExists(autopartId, trackChanges);

            var lossEntity = _mapper.Map<Loss>(lossForCreation);

            await UpdateAutopartInventory(autopartId, lossEntity.AmountLoss);

            _repository.Loss.CreateLossForAutopart(autopartId, lossEntity);

            await _repository.SaveAsync();

            var lossToReturn = _mapper.Map<LossDto>(lossEntity);

            return lossToReturn;
        }


        /* Eliminar */
        public async Task DeleteLossForAutopartAsync(Guid autopartId, Guid id, bool trackChanges)
        {
            await CheckIfAutopartExists(autopartId, trackChanges);

            var lossForAutopart = await GetLossForAutopartAndCheckIfItExists(autopartId, id, trackChanges);

            _repository.Loss.DeleteLoss(lossForAutopart);

            await _repository.SaveAsync();
        }


        /* Único Registro */
        public async Task<LossDto> GetLossByAutopartAsync(Guid autopartId, Guid id, bool trackChanges)
        {
            await CheckIfAutopartExists(autopartId, trackChanges);

            var lossDb = await GetLossForAutopartAndCheckIfItExists(autopartId, id, trackChanges);

            var loss = _mapper.Map<LossDto>(lossDb);

            return loss;
        }


        /* Listar */
        public async Task<IEnumerable<LossDto>> GetLossesAsync(Guid autopartId, bool trackChanges)
        {
            await CheckIfAutopartExists(autopartId, trackChanges);

            var lossesFromDb = await _repository.Loss.GetLossesAsync(autopartId, trackChanges);

            var lossesDto = _mapper.Map<IEnumerable<LossDto>>(lossesFromDb);

            return lossesDto;
        }


        /* Actualizar */
        public async Task UpdateLossForAutopartAsync(Guid autopartId, Guid id, LossForUpdateDto lossForUpdate, bool autTrackChanges, bool losTrackChanges)
        {
            await CheckIfAutopartExists(autopartId, autTrackChanges);

            var lossEntity = await GetLossForAutopartAndCheckIfItExists(autopartId, id, losTrackChanges);

            _mapper.Map(lossForUpdate, lossEntity);

            lossEntity.setModificationDate();

            await _repository.SaveAsync();
        }






        /* <--- Métodos Privados ---> */
        private async Task UpdateAutopartInventory(Guid autopartId, int amountLoss)
        {
            var autopart = await _repository.Autopart.GetAutopartByIdAsync(autopartId, false);

            if (autopart != null)
            {
                autopart.Inventory -= amountLoss;
                autopart.setModificationDate();
                _repository.Autopart.UpdateAutopartInventory(autopart);
                await _repository.SaveAsync();
            }
        }

        private async Task CheckIfAutopartExists(Guid autopartId, bool trackChanges)
        {
            var autopart = await _repository.Autopart.GetAutopartByIdAsync(autopartId, trackChanges);

            if (autopart is null)
                throw new AutopartNotFoundException(autopartId);
        }

        private async Task<Loss> GetLossForAutopartAndCheckIfItExists(Guid autopartId, Guid id, bool trackChanges)
        {
            var lossDb = await _repository.Loss.GetLossByAutopartAsync(autopartId, id, trackChanges);

            if (lossDb is null)
                throw new LossNotFoundException(id);

            return lossDb;
        }

    }
}
