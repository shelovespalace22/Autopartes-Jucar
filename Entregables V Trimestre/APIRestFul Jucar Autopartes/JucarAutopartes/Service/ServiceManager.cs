using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Service.Contracts;
using Service.Contracts.Products;
using Service.Contracts.Proveedores;
using Service.Contracts.Sales;
using Service.Products;
using Service.Proveedores;
using Service.Sales;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        /* Productos */

        private readonly Lazy<ICategoryService> _categoryService;

        private readonly Lazy<ISubcategoryService> _subcategoryService;

        private readonly Lazy<IAutopartService> _autopartService;

        private readonly Lazy<IRawMaterialService> _rawMaterialService;

        private readonly Lazy<IStockService> _stockService;

        private readonly Lazy<ILossService> _lossService;

        private readonly Lazy<IMovementService> _movementService;

        /* Proveedores */

        private readonly Lazy<IProviderService> _providerService;

        private readonly Lazy<IProviderAddressService> _providerAddressService;

        private readonly Lazy<IProviderPhoneService> _providerPhoneService;

        /* Ventas */

        private readonly Lazy<ICustomerService> _customerService;

        private readonly Lazy<ICustomerAddressService> _customerAddressService;

        private readonly Lazy<ICustomerPhoneService> _customerPhoneService;

        private readonly Lazy<IOrderService> _orderService;

        private readonly Lazy<IOrderDetailService> _orderDetailService;

        private readonly Lazy<IPaymentMethodService> _paymentMethodService;

        private readonly Lazy<IContributionService> _contributionService;


        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            /* Productos */

            _categoryService = new Lazy<ICategoryService>(() =>
                new CategoryService(repositoryManager, logger, mapper));

            _subcategoryService = new Lazy<ISubcategoryService>(() =>
                new SubcategoryService(repositoryManager, logger, mapper));

            _autopartService = new Lazy<IAutopartService>(() =>
                new AutopartService(repositoryManager, logger, mapper));

            _rawMaterialService = new Lazy<IRawMaterialService>(() =>
                new RawMaterialService(repositoryManager, logger, mapper));

            _stockService = new Lazy<IStockService>(() =>
                new StockService(repositoryManager, logger, mapper));

            _lossService = new Lazy<ILossService>(() =>
                new LossService(repositoryManager, logger, mapper));

            _movementService = new Lazy<IMovementService>(() =>
                new MovementService(repositoryManager, logger, mapper));

            /* Proveedores */

            _providerService = new Lazy<IProviderService>(() =>
                new ProviderService(repositoryManager, logger, mapper));

            _providerAddressService = new Lazy<IProviderAddressService>(() =>
                new ProviderAddressService(repositoryManager, logger, mapper));

            _providerPhoneService = new Lazy<IProviderPhoneService>(() =>
                new ProviderPhoneService(repositoryManager, logger, mapper));

            /* Ventas */

            _customerService = new Lazy<ICustomerService>(() =>
                new CustomerService(repositoryManager, logger, mapper));

            _customerAddressService = new Lazy<ICustomerAddressService>(() =>
                new CustomerAddressService(repositoryManager, logger, mapper));

            _customerPhoneService = new Lazy<ICustomerPhoneService>(() =>
                new CustomerPhoneService(repositoryManager, logger, mapper));

            _orderService = new Lazy<IOrderService>(() =>
                new OrderService(repositoryManager, logger, mapper));

            _orderDetailService = new Lazy<IOrderDetailService>(() =>
                new OrderDetailService(repositoryManager, logger, mapper));

            _paymentMethodService = new Lazy<IPaymentMethodService>(() =>
                new PaymentMethodService(repositoryManager, logger, mapper));

            _contributionService = new Lazy<IContributionService>(() =>
                new ContributionService(repositoryManager, logger, mapper));

        }

        /* Productos */

        public ICategoryService CategoryService => _categoryService.Value;
        public ISubcategoryService SubcategoryService => _subcategoryService.Value;
        public IAutopartService AutopartService => _autopartService.Value;
        public IRawMaterialService RawMaterialService => _rawMaterialService.Value;
        public IStockService StockService => _stockService.Value;
        public ILossService LossService => _lossService.Value;
        public IMovementService MovementService => _movementService.Value;

        /* Proveedores */

        public IProviderService ProviderService => _providerService.Value;
        public IProviderAddressService ProviderAddressService => _providerAddressService.Value;
        public IProviderPhoneService ProviderPhoneService => _providerPhoneService.Value;

        /* Ventas */

        public ICustomerService CustomerService => _customerService.Value;
        public ICustomerAddressService CustomerAddressService => _customerAddressService.Value;
        public ICustomerPhoneService CustomerPhoneService => _customerPhoneService.Value;
        public IOrderService OrderService => _orderService.Value;
        public IOrderDetailService OrderDetailService => _orderDetailService.Value;
        public IPaymentMethodService PaymentMethodService => _paymentMethodService.Value;
        public IContributionService ContributionService => _contributionService.Value;
    }
}
