using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<ISubcategoryService> _subcategoryService;
        private readonly Lazy<IAutopartService> _autopartService;
        private readonly Lazy<IFactoryService> _factoryService;
       

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _categoryService = new Lazy<ICategoryService>(() => 
                new CategoryService(repositoryManager, logger, mapper));

            _subcategoryService = new Lazy<ISubcategoryService>(() =>
                new SubcategoryService(repositoryManager, logger, mapper));

            _autopartService = new Lazy<IAutopartService>(() =>
                new AutopartService(repositoryManager, logger, mapper));
            _factoryService = new Lazy<IFactoryService>(() =>
                new FactoryService(repositoryManager, logger, mapper));



        }

        public ICategoryService CategoryService => _categoryService.Value;
        public ISubcategoryService SubcategoryService => _subcategoryService.Value;
        public IAutopartService AutopartService => _autopartService.Value;
        public IFactoryService FactoryService => _factoryService.Value;

        
    }
}
