using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Providers;
using Entities.Models.Providers;
using Service.Contracts.Proveedores;
using Shared.DataTransferObjects.Providers.ProviderAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Proveedores
{
    internal sealed class ProviderAddressService : IProviderAddressService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProviderAddressService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear */
        public ProviderAddressDto CreateAddressForProvider(Guid providerId, ProviderAddressForCreationDto address, bool trackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var addressEntity = _mapper.Map<ProviderAddress>(address);

            _repository.ProviderAddress.CreateAddressForProvider(providerId, addressEntity);

            _repository.Save();

            var addressToReturn = _mapper.Map<ProviderAddressDto>(addressEntity);

            return addressToReturn;
        }

        /* Eliminar */
        public void DeleteAddressForProvider(Guid providerId, Guid id, bool trackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var addressForProvider = _repository.ProviderAddress.GetAddressByProvider(providerId, id, trackChanges);

            if (addressForProvider is null)
                throw new ProviderAddressNotFoundException(id);

            _repository.ProviderAddress.DeleteProviderAddress(addressForProvider);

            _repository.Save();
        }

        /* Listar */
        public IEnumerable<ProviderAddressDto> GetAddresses(Guid providerId, bool trackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var addressesFromDb = _repository.ProviderAddress.GetAddressesForProvider(providerId, trackChanges);

            var addressesDto = _mapper.Map<IEnumerable<ProviderAddressDto>>(addressesFromDb);

            return addressesDto;
        }

        /* Un registro */
        public ProviderAddressDto GetAddressForProvider(Guid providerId, Guid id, bool trackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var addressDb = _repository.ProviderAddress.GetAddressByProvider(providerId, id, trackChanges);

            if (addressDb is null)
                throw new ProviderAddressNotFoundException(id);

            var address = _mapper.Map<ProviderAddressDto>(addressDb);

            return address;
        }

        /* Actualizar */
        public void UpdateAddressForProvider(Guid providerId, Guid id, ProviderAddressForUpdateDto addressForUpdate, bool proTrackChanges, bool adrTrackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, proTrackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var addressEntity = _repository.ProviderAddress.GetAddressByProvider(providerId, id, adrTrackChanges);

            if (addressEntity is null)
                throw new ProviderAddressNotFoundException(id);

            _mapper.Map(addressForUpdate, addressEntity);

            addressEntity.setModificationDate();

            _repository.Save();
        }
    }
}
