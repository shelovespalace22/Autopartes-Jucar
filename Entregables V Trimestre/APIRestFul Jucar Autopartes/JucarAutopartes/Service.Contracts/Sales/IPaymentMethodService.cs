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
        PaymentMethodDto CreatePaymentMethod(PaymentMethodForCreationDto paymentMethod);

        /* Listar */
        IEnumerable<PaymentMethodDto> GetAllPaymentMethods(bool trackChanges);

        /* Un registro */
        PaymentMethodDto GetPaymentMethod(Guid paymentMethodId, bool trackChanges);

        /* Actualizar */
        void UpdatePaymentMethod(Guid paymentMethodId, PaymentMethodForUpdateDto paymentMethodForUpdate, bool trackChanges);

        /* Eliminar */
        void DeletePaymentMethod(Guid paymentMethodId, bool trackChanges);
    }
}
