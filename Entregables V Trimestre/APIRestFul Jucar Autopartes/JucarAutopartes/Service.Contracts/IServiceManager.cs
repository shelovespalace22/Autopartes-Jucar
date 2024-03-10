using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Contracts.Products;
using Service.Contracts.Proveedores;
using Service.Contracts.Sales;
using Service.Contracts.Ubications;
using Service.Contracts.Users;

namespace Service.Contracts
{
    public interface IServiceManager
    {

        /* Productos */

        ICategoryService CategoryService { get; }
        ISubcategoryService SubcategoryService { get; }
        IAutopartService AutopartService { get; }
        IRawMaterialService RawMaterialService { get; }
        IStockService StockService {  get; }
        ILossService LossService { get; }
        IMovementService MovementService  { get; }


        /* Proveedores */

        IProviderService ProviderService { get; }
        IProviderAddressService ProviderAddressService { get; }
        IProviderPhoneService ProviderPhoneService { get; }


        /* Ventas */

        ICustomerService CustomerService { get; }
        ICustomerPhoneService CustomerPhoneService { get; }
        ICustomerAddressService CustomerAddressService { get; }
        IOrderService OrderService { get; }
        IOrderDetailService OrderDetailService { get; }
        IPaymentMethodService PaymentMethodService { get; }
        IContributionService ContributionService { get; }


        /* Usuarios */

        IAuthenticationService AuthenticationService { get; }


        /* Ubicaciones */

        IDepartmentService DepartmentService { get; }
        IMunicipaliityService MunicipaliityService { get; }
        INeighborhoodService NeighborhoodService { get; }
    }
}
