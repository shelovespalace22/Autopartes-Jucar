using Shared.DataTransferObjects.Providers.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Proveedores
{
    public interface IProviderService
    {
        /* Crear */
        ProviderDto CreateProvider(ProviderForCreationDto provider);

        /* Listar */
        IEnumerable<ProviderDto> GetAllProviders(bool trackChanges);

        /* Un registro */
        ProviderDto GetProvider(Guid providerId, bool trackChanges);

        /* Actualizar */
        void UpdateProvider(Guid providerId, ProviderForUpdateDto providerForUpdate, bool trackChanges);

        /* Eliminar */
        void DeleteProvider(Guid providerId, bool trackChanges);
    }   
}
