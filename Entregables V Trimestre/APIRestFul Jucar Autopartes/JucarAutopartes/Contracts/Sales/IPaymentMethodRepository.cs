using Entities.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Sales
{
    public interface IPaymentMethodRepository
    {
        /* Crear */
        void CreatePaymentMethod(PaymentMethod paymentMethod);

        /* Listar */
        IEnumerable<PaymentMethod> GetAllPaymentMethods(bool trackChanges);

        /* Un registro */
        PaymentMethod GetPaymentMethod(Guid paymentMethodId, bool trackChanges);

        /* Eliminar */
        void DeletePaymentMethod(PaymentMethod paymentMethod);
    }
}
