using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Products;
using Entities.Exceptions.NotFound.Providers;
using Entities.Models.Products;
using Entities.Models.Providers;
using Service.Contracts.Proveedores;
using Shared.DataTransferObjects.Providers.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Proveedores
{
    internal sealed class ProviderService : IProviderService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProviderService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear */
        public async Task<ProviderDto> CreateProviderAsync(ProviderForCreationDto provider)
        {
            var providerEntity = _mapper.Map<Provider>(provider);

            _repository.Provider.CreateProvider(providerEntity);

            await _repository.SaveAsync();

            var providerToReturn = _mapper.Map<ProviderDto>(providerEntity);

            return providerToReturn;
        }

        /* Eliminar */
        public async Task DeleteProviderAsync(Guid providerId, bool trackChanges)
        {
            var provider = await GetProviderAndCheckIfItExists(providerId, trackChanges);

            _repository.Provider.DeleteProvider(provider);

            await _repository.SaveAsync();
        }

        /* Listar */
        public async Task<IEnumerable<ProviderDto>> GetAllProvidersAsync(bool trackChanges)
        {
            var providers = await _repository.Provider.GetAllProvidersAsync(trackChanges);

            var providersDto = _mapper.Map<IEnumerable<ProviderDto>>(providers);

            return providersDto;
        }

        /* Un registro */
        public async Task<ProviderDto> GetProviderAsync(Guid providerId, bool trackChanges)
        {
            var provider = await GetProviderAndCheckIfItExists(providerId, trackChanges);

            var providerDto = _mapper.Map<ProviderDto>(provider);

            return providerDto;
        }

        /* Actualizar */
        public async Task UpdateProviderAsync(Guid providerId, ProviderForUpdateDto providerForUpdate, bool trackChanges)
        {
            var providerEntity = await GetProviderAndCheckIfItExists(providerId, trackChanges);

            _mapper.Map(providerForUpdate, providerEntity);

            providerEntity.setModificationDate();

            await _repository.SaveAsync();
        }







        /* <----- Métodos Privados -----> */

        private async Task<Provider> GetProviderAndCheckIfItExists(Guid id, bool trackChanges)
        {
            var provider = await _repository.Provider.GetProviderAsync(id, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(id);

            return provider;
        }
    }
}
