using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Contracts.Products;
using Contracts.Providers;
using Contracts.Sales;
using Repository.Products;
using Repository.Providers;
using Repository.Sales;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;


        /* Productos */

        private readonly Lazy<ICategoryRepository> _categoryRepository;

        private readonly Lazy<ISubcategoryRepository> _subcategoryRepository;

        private readonly Lazy<IAutopartRepository> _autopartRepository;

        private readonly Lazy<IRawMaterialRepository> _rawMaterialRepository;

        private readonly Lazy<IStockRepository> _stockRepository;

        private readonly Lazy<ILossRepository> _lossRepository;

        private readonly Lazy<IMovementRepository> _movementRepository;

        /* Proveedores */

        private readonly Lazy<IProviderRepository> _providerRepository;

        private readonly Lazy<IProviderAddressRepository> _providerAddressRepository;

        private readonly Lazy<IProviderPhoneRepository> _providerPhoneRepository;

        /* Ventas */

        private readonly Lazy<ICustomerRepository> _customerRepository;

        private readonly Lazy<ICustomerPhoneRepository> _customerPhoneRepository;

        private readonly Lazy<ICustomerAddressRepository> _customerAddressRepository;

        private readonly Lazy<IOrderRepository> _orderRepository;

        private readonly Lazy<IOrderDetailRepository> _orderDetailRepository;

        private readonly Lazy<IPaymentMethodRepository> _paymentMethodRepository;

        private readonly Lazy<IContributionRepository> _contributionRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;


            /* Productos */

            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(repositoryContext));

            _subcategoryRepository = new Lazy<ISubcategoryRepository>(() => new SubcategoryRepository(repositoryContext));

            _autopartRepository = new Lazy<IAutopartRepository>(() => new AutopartRepository(repositoryContext));

            _rawMaterialRepository = new Lazy<IRawMaterialRepository>(() => new RawMaterialRepository(repositoryContext));

            _stockRepository = new Lazy<IStockRepository>(() => new StockRepository(repositoryContext));

            _lossRepository = new Lazy<ILossRepository>(() => new LossRepository(repositoryContext));

            _movementRepository = new Lazy<IMovementRepository>(() => new MovementRepository(repositoryContext));

            /* Proveedores */

            _providerRepository = new Lazy<IProviderRepository>(() => new ProviderRepository(repositoryContext));

            _providerAddressRepository = new Lazy<IProviderAddressRepository>(() => new ProviderAddressRepository(repositoryContext));

            _providerPhoneRepository = new Lazy<IProviderPhoneRepository>(() => new ProviderPhoneRepository(repositoryContext));

            /* Ventas */

            _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(repositoryContext));

            _customerPhoneRepository = new Lazy<ICustomerPhoneRepository>(() => new CustomerPhoneRepository(repositoryContext));

            _customerAddressRepository = new Lazy<ICustomerAddressRepository>(() => new CustomerAddressRepository(repositoryContext));

            _orderRepository = new Lazy<IOrderRepository>(() => new OrderRepository(repositoryContext));

            _orderDetailRepository = new Lazy<IOrderDetailRepository>(() => new OrderDetailRepository(repositoryContext));

            _paymentMethodRepository = new Lazy<IPaymentMethodRepository>(() => new PaymentMethodRepository(repositoryContext));

            _contributionRepository = new Lazy<IContributionRepository>(() => new ContributionRepository(repositoryContext));
        }

        /* Productos */

        public ICategoryRepository Category => _categoryRepository.Value;

        public ISubcategoryRepository Subcategory => _subcategoryRepository.Value;

        public IAutopartRepository Autopart => _autopartRepository.Value;

        public IRawMaterialRepository RawMaterial => _rawMaterialRepository.Value;

        public IStockRepository Stock => _stockRepository.Value;

        public ILossRepository Loss => _lossRepository.Value;

        public IMovementRepository Movement => _movementRepository.Value;

        /* Proveedores */

        public IProviderRepository Provider => _providerRepository.Value;

        public IProviderAddressRepository ProviderAddress => _providerAddressRepository.Value;

        public IProviderPhoneRepository ProviderPhone => _providerPhoneRepository.Value;

        /* Ventas */

        public ICustomerRepository Customer => _customerRepository.Value;

        public ICustomerPhoneRepository CustomerPhone => _customerPhoneRepository.Value;

        public ICustomerAddressRepository CustomerAddress => _customerAddressRepository.Value;

        public IOrderRepository Order => _orderRepository.Value;

        public IOrderDetailRepository OrderDetail => _orderDetailRepository.Value;

        public IPaymentMethodRepository PaymentMethod => _paymentMethodRepository.Value;

        public IContributionRepository Contribution => _contributionRepository.Value;



        public void Save() => _repositoryContext.SaveChanges();
    }
}
