using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Providers;
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
        public ProviderDto CreateProvider(ProviderForCreationDto provider)
        {
            var providerEntity = _mapper.Map<Provider>(provider);

            _repository.Provider.CreateProvider(providerEntity);

            _repository.Save();

            var providerToReturn = _mapper.Map<ProviderDto>(providerEntity);

            return providerToReturn;
        }

        /* Eliminar */
        public void DeleteProvider(Guid providerId, bool trackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            _repository.Provider.DeleteProvider(provider);

            _repository.Save();
        }

        /* Listar */
        public IEnumerable<ProviderDto> GetAllProviders(bool trackChanges)
        {
            var providers = _repository.Provider.GetAllProviders(trackChanges);

            var providersDto = _mapper.Map<IEnumerable<ProviderDto>>(providers);

            return providersDto;
        }

        /* Un registro */
        public ProviderDto GetProvider(Guid providerId, bool trackChanges)
        {
            var provider = _repository.Provider.GetProvider(providerId, trackChanges);

            if (provider is null)
                throw new ProviderNotFoundException(providerId);

            var providerDto = _mapper.Map<ProviderDto>(provider);

            return providerDto;
        }

        /* Actualizar */
        public void UpdateProvider(Guid providerId, ProviderForUpdateDto providerForUpdate, bool trackChanges)
        {
            var providerEntity = _repository.Provider.GetProvider(providerId, trackChanges);

            if (providerEntity is null)
                throw new ProviderNotFoundException(providerId);

            _mapper.Map(providerForUpdate, providerEntity);

            providerEntity.setModificationDate();

            _repository.Save();
        }
    }
}
