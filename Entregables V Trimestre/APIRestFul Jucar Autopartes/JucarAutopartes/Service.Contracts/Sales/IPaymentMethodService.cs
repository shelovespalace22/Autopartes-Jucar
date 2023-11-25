using Shared.DataTransferObjects.Providers.Provider;
using Shared.DataTransferObjects.Sales.PaymentMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Sales
{
    public interface IPaymentMethodService
    {
        /* Crear */
        Task<PaymentMethodDto> CreatePaymentMethodAsync(PaymentMethodForCreationDto paymentMethod);

        /* Listar */
        Task<IEnumerable<PaymentMethodDto>> GetAllPaymentMethodsAsync(bool trackChanges);

        /* Un registro */
        Task<PaymentMethodDto> GetPaymentMethodAsync(Guid paymentMethodId, bool trackChanges);

        /* Actualizar */
        Task UpdatePaymentMethodAsync(Guid paymentMethodId, PaymentMethodForUpdateDto paymentMethodForUpdate, bool trackChanges);

        /* Eliminar */
        Task DeletePaymentMethodAsync(Guid paymentMethodId, bool trackChanges);
    }
}
