using Contracts.Sales;
using Entities.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sales
{
    public class PaymentMethodRepository : RepositoryBase<PaymentMethod>, IPaymentMethodRepository
    {
        public PaymentMethodRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Crear */
        public void CreatePaymentMethod(PaymentMethod paymentMethod) => Create(paymentMethod);

        /* Eliminar */
        public void DeletePaymentMethod(PaymentMethod paymentMethod) => Delete(paymentMethod);

        /* Listar */
        public IEnumerable<PaymentMethod> GetAllPaymentMethods(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(p => p.PaymentMethodName)
            .ToList();

        /* Un registro */
        public PaymentMethod GetPaymentMethod(Guid paymentMethodId, bool trackChanges) =>
            FindByCondition(p => p.PaymentMethodID.Equals(paymentMethodId), trackChanges)
            .SingleOrDefault();
    }
}
