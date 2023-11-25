using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Providers;
using Entities.Models.Providers;
using Service.Contracts.Proveedores;
using Shared.DataTransferObjects.Providers.ProviderPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Proveedores
{
    internal sealed class ProviderPhoneService : IProviderPhoneService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProviderPhoneService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear */
        public async Task<ProviderPhoneDto> CreatePhoneForProviderAsync(Guid providerId, ProviderPhoneForCreationDto phone, bool trackChanges)
        {
            var provider = await _repository.Provider.GetProviderAsync(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var phoneEntity = _mapper.Map<ProviderPhone>(phone);

            _repository.ProviderPhone.CreatePhoneForProvider(providerId, phoneEntity);

            await _repository.SaveAsync();

            var phoneToReturn = _mapper.Map<ProviderPhoneDto>(phoneEntity);

            return phoneToReturn;
        }

        /* Eliminar */
        public async Task DeletePhoneForProviderAsync(Guid providerId, Guid id, bool trackChanges)
        {
            var provider = await _repository.Provider.GetProviderAsync(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var phoneForProvider = await _repository.ProviderPhone.GetPhoneByProviderAsync(providerId, id, trackChanges);

            if (phoneForProvider is null)
                throw new ProviderPhoneNotFoundException(id);

            _repository.ProviderPhone.DeleteProviderPhone(phoneForProvider);

            await _repository.SaveAsync();
        }

        /* Un registro */
        public async Task<ProviderPhoneDto> GetPhoneForProviderAsync(Guid providerId, Guid id, bool trackChanges)
        {
            var provider = await _repository.Provider.GetProviderAsync(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var phoneDb = await _repository.ProviderPhone.GetPhoneByProviderAsync(providerId, id, trackChanges);

            if (phoneDb is null)
                throw new ProviderPhoneNotFoundException(id);

            var phone = _mapper.Map<ProviderPhoneDto>(phoneDb);

            return phone;
        }

        /* Listar */
        public async Task<IEnumerable<ProviderPhoneDto>> GetPhonesAsync(Guid providerId, bool trackChanges)
        {
            var provider = await _repository.Provider.GetProviderAsync(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var phonesFromDb = await _repository.ProviderPhone.GetPhonesForProviderAsync(providerId, trackChanges);

            var phonesDto = _mapper.Map<IEnumerable<ProviderPhoneDto>>(phonesFromDb);

            return phonesDto;
        }

        /* Actualizar */
        public async Task UpdatePhoneForProviderAsync(Guid providerId, Guid id, ProviderPhoneForUpdateDto phoneForUpdate, bool proTrackChanges, bool phoTrackChanges)
        {
            var provider = await _repository.Provider.GetProviderAsync(providerId, proTrackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var phoneEntity = await _repository.ProviderPhone.GetPhoneByProviderAsync(providerId, id, phoTrackChanges);

            if (phoneEntity is null)
                throw new ProviderPhoneNotFoundException(id);

            _mapper.Map(phoneForUpdate, phoneEntity);

            phoneEntity.setModificationDate();

            await _repository.SaveAsync();
        }
    }
}
