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

        public LossDto CreateLossForAutopart(Guid autopartId, LossForCreationDto lossForCreation, bool trackChanges)
        {
            var autopart = _repository.Autopart.GetAutopartById(autopartId, trackChanges);

            if (autopart is null)
                throw new AutopartNotFoundException(autopartId);

            var lossEntity = _mapper.Map<Loss>(lossForCreation);

            _repository.Loss.CreateLossForAutopart(autopartId, lossEntity);

            _repository.Save();

            var lossToReturn = _mapper.Map<LossDto>(lossEntity);

            return lossToReturn;
        }


        /* Eliminar */

        public void DeleteLossForAutopart(Guid autopartId, Guid id, bool trackChanges)
        {
            var autopart = _repository.Autopart.GetAutopartById(autopartId, trackChanges);

            if (autopart is null)
                throw new AutopartNotFoundException(autopartId);

            var lossForAutopart = _repository.Loss.GetLossByAutopart(autopartId, id, trackChanges);

            if (lossForAutopart is null)
                throw new LossNotFoundException(id);

            _repository.Loss.DeleteLoss(lossForAutopart);

            _repository.Save();
        }


        /* Único Registro */

        public LossDto GetLossByAutopart(Guid autopartId, Guid id, bool trackChanges)
        {
            var autopart = _repository.Autopart.GetAutopartById(autopartId, trackChanges);

            if (autopart is null)
                throw new AutopartNotFoundException(autopartId);

            var lossDb = _repository.Loss.GetLossByAutopart(autopartId, id, trackChanges);

            if (lossDb is null)
                throw new LossNotFoundException(id);

            var loss = _mapper.Map<LossDto>(lossDb);

            return loss;
        }


        /* Listar */

        public IEnumerable<LossDto> GetLosses(Guid autopartId, bool trackChanges)
        {
            var autopart = _repository.Autopart.GetAutopartById(autopartId, trackChanges);

            if (autopart is null)
                throw new AutopartNotFoundException(autopartId);

            var lossesFromDb = _repository.Loss.GetLosses(autopartId, trackChanges);

            var lossesDto = _mapper.Map<IEnumerable<LossDto>>(lossesFromDb);

            return lossesDto;
        }


        /* Actualizar */

        public void UpdateLossForAutopart(Guid autopartId, Guid id, LossForUpdateDto lossForUpdate, bool autTrackChanges, bool losTrackChanges)
        {
            var autopart = _repository.Autopart.GetAutopartById(autopartId, autTrackChanges);

            if (autopart is null)
                throw new AutopartNotFoundException(autopartId);

            var lossEntity = _repository.Loss.GetLossByAutopart(autopartId, id, losTrackChanges);

            if (lossEntity is null)
                throw new LossNotFoundException(id);

            _mapper.Map(lossForUpdate, lossEntity);

            lossEntity.setModificationDate();

            _repository.Save();
        }


        



        
    }
}
