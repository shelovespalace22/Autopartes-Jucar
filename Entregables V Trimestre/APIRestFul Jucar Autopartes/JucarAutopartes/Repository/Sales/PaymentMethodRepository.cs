using Contracts.Sales;
using Entities.Models.Sales;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(p => p.PaymentMethodName)
            .ToListAsync();

        /* Un registro */
        public async Task<PaymentMethod> GetPaymentMethodAsync(Guid paymentMethodId, bool trackChanges) =>
            await FindByCondition(p => p.PaymentMethodID.Equals(paymentMethodId), trackChanges)
            .SingleOrDefaultAsync();
    }
}
