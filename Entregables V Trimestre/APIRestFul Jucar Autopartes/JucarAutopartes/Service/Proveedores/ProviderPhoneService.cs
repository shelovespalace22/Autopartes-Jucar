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
        public ProviderPhoneDto CreatePhoneForProvider(Guid providerId, ProviderPhoneForCreationDto phone, bool trackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var phoneEntity = _mapper.Map<ProviderPhone>(phone);

            _repository.ProviderPhone.CreatePhoneForProvider(providerId, phoneEntity);

            _repository.Save();

            var phoneToReturn = _mapper.Map<ProviderPhoneDto>(phoneEntity);

            return phoneToReturn;
        }

        /* Eliminar */
        public void DeletePhoneForProvider(Guid providerId, Guid id, bool trackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var phoneForProvider = _repository.ProviderPhone.GetPhoneByProvider(providerId, id, trackChanges);

            if (phoneForProvider is null)
                throw new ProviderPhoneNotFoundException(id);

            _repository.ProviderPhone.DeleteProviderPhone(phoneForProvider);

            _repository.Save();
        }

        /* Un registro */
        public ProviderPhoneDto GetPhoneForProvider(Guid providerId, Guid id, bool trackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var phoneDb = _repository.ProviderPhone.GetPhoneByProvider(providerId, id, trackChanges);

            if (phoneDb is null)
                throw new ProviderPhoneNotFoundException(id);

            var phone = _mapper.Map<ProviderPhoneDto>(phoneDb);

            return phone;
        }

        /* Listar */
        public IEnumerable<ProviderPhoneDto> GetPhones(Guid providerId, bool trackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var phonesFromDb = _repository.ProviderPhone.GetPhonesForProvider(providerId, trackChanges);

            var phonesDto = _mapper.Map<IEnumerable<ProviderPhoneDto>>(phonesFromDb);

            return phonesDto;
        }

        /* Actualizar */
        public void UpdatePhoneForProvider(Guid providerId, Guid id, ProviderPhoneForUpdateDto phoneForUpdate, bool proTrackChanges, bool phoTrackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, proTrackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var phoneEntity = _repository.ProviderPhone.GetPhoneByProvider(providerId, id, phoTrackChanges);

            if (phoneEntity is null)
                throw new ProviderPhoneNotFoundException(id);

            _mapper.Map(phoneForUpdate, phoneEntity);

            phoneEntity.setModificationDate();

            _repository.Save();
        }
    }
}
