using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<ISubcategoryService> _subcategoryService;
        private readonly Lazy<IAutopartService> _autopartService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _categoryService = new Lazy<ICategoryService>(() => 
                new CategoryService(repositoryManager, logger));

            _subcategoryService = new Lazy<ISubcategoryService>(() =>
                new SubcategoryService(repositoryManager, logger));

            _autopartService = new Lazy<IAutopartService>(() =>
                new AutopartService(repositoryManager, logger));
        }

        public ICategoryService CategoryService => _categoryService.Value;
        public ISubcategoryService SubcategoryService => _subcategoryService.Value;
        public IAutopartService AutopartService => _autopartService.Value;
    }
}
