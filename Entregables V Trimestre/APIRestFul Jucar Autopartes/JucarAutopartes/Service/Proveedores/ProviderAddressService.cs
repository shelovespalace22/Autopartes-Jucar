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
        public async Task<ProviderAddressDto> CreateAddressForProviderAsync(Guid providerId, ProviderAddressForCreationDto address, bool trackChanges)
        {
            await CheckIfProviderExists(providerId, trackChanges);

            var addressEntity = _mapper.Map<ProviderAddress>(address);

            _repository.ProviderAddress.CreateAddressForProvider(providerId, addressEntity);

            await _repository.SaveAsync();

            var addressToReturn = _mapper.Map<ProviderAddressDto>(addressEntity);

            return addressToReturn;
        }

        /* Eliminar */
        public async Task DeleteAddressForProviderAsync(Guid providerId, Guid id, bool trackChanges)
        {
            await CheckIfProviderExists(providerId, trackChanges);

            var addressForProvider = await GetAddressForProviderAndCheckIfItExists(providerId, id, trackChanges);

            _repository.ProviderAddress.DeleteProviderAddress(addressForProvider);

            await _repository.SaveAsync();
        }

        /* Listar */
        public async Task<IEnumerable<ProviderAddressDto>> GetAddressesAsync(Guid providerId, bool trackChanges)
        {
            await CheckIfProviderExists(providerId, trackChanges);

            var addressesFromDb = await _repository.ProviderAddress.GetAddressesForProviderAsync(providerId, trackChanges);

            var addressesDto = _mapper.Map<IEnumerable<ProviderAddressDto>>(addressesFromDb);

            return addressesDto;
        }

        /* Un registro */
        public async Task<ProviderAddressDto> GetAddressForProviderAsync(Guid providerId, Guid id, bool trackChanges)
        {
            await CheckIfProviderExists(providerId, trackChanges);

            var addressDb = await GetAddressForProviderAndCheckIfItExists(providerId, id, trackChanges);

            var address = _mapper.Map<ProviderAddressDto>(addressDb);

            return address;
        }

        /* Actualizar */
        public async Task UpdateAddressForProviderAsync(Guid providerId, Guid id, ProviderAddressForUpdateDto addressForUpdate, bool proTrackChanges, bool adrTrackChanges)
        {
            await CheckIfProviderExists(providerId, proTrackChanges);

            var addressEntity = await GetAddressForProviderAndCheckIfItExists(providerId, id, adrTrackChanges);

            _mapper.Map(addressForUpdate, addressEntity);

            addressEntity.setModificationDate();

            await _repository.SaveAsync();
        }





        /* <----- Métodos Privados -----> */

        private async Task CheckIfProviderExists(Guid providerId, bool trackChanges)
        {
            var provider = await _repository.Provider.GetProviderAsync(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);
        }


        private async Task<ProviderAddress> GetAddressForProviderAndCheckIfItExists(Guid providerId, Guid id, bool trackChanges)
        {
            var addressDb = await _repository.ProviderAddress.GetAddressByProviderAsync(providerId, id, trackChanges);

            if (addressDb is null)
                throw new ProviderAddressNotFoundException(id);

            return addressDb;
        }
    }
}
