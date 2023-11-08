using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Service.Contracts;
using Service.Contracts.Products;
using Service.Products;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICategoryService> _categoryService;

        private readonly Lazy<ISubcategoryService> _subcategoryService;

        private readonly Lazy<IAutopartService> _autopartService;

        private readonly Lazy<IRawMaterialService> _rawMaterialService;

        private readonly Lazy<IStockService> _stockService;

        private readonly Lazy<ILossService> _lossService;

        private readonly Lazy<IMovementService> _movementService;


        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
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

        }

        public ICategoryService CategoryService => _categoryService.Value;
        public ISubcategoryService SubcategoryService => _subcategoryService.Value;
        public IAutopartService AutopartService => _autopartService.Value;
        public IRawMaterialService RawMaterialService => _rawMaterialService.Value;
        public IStockService StockService => _stockService.Value;
        public ILossService LossService => _lossService.Value;
        public IMovementService MovementService => _movementService.Value;
    }
}
