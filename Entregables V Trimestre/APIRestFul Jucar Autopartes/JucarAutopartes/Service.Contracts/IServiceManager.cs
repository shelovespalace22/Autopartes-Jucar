using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Contracts.Products;
using Service.Contracts.Proveedores;

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


    }
}
