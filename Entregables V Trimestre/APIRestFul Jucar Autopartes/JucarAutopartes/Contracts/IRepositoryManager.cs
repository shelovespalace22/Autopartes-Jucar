using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Products;
using Contracts.Providers;
using Contracts.Sales;
using Contracts.Ubications;

namespace Contracts
{
    public interface IRepositoryManager
    {

        /* Productos */
        ICategoryRepository Category { get; }
        ISubcategoryRepository Subcategory { get; }
        IAutopartRepository Autopart { get; }
        IRawMaterialRepository RawMaterial { get; }
        IStockRepository Stock { get; }
        ILossRepository Loss { get; }
        IMovementRepository Movement { get; }

        /* Proveedores */

        IProviderRepository Provider { get; }
        IProviderAddressRepository ProviderAddress { get; }
        IProviderPhoneRepository ProviderPhone { get; }

        /* Ventas */

        ICustomerRepository Customer { get; }
        ICustomerPhoneRepository CustomerPhone { get; }
        ICustomerAddressRepository CustomerAddress { get; }
        IOrderRepository Order { get; }
        IOrderDetailRepository OrderDetail { get; }
        IPaymentMethodRepository PaymentMethod { get; }
        IContributionRepository Contribution { get; }


        /* Ubicaciones */


        IDepartmentRepository Department { get; }
        IMunicipalityRepository Municipality { get; }
        INeighborhoodRepository Neighborhood { get; }

        Task SaveAsync();

    }
}
