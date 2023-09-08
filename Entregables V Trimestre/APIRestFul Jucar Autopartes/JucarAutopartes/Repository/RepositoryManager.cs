using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Contracts.Factory;
using Contracts.Products;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<ISubcategoryRepository> _subcategoryRepository;
        private readonly Lazy<IAutopartRepository> _autopartRepository;
        private readonly Lazy<IFactoryRepository> _factoryRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(repositoryContext));
            _subcategoryRepository = new Lazy<ISubcategoryRepository>(() => new SubcategoryRepository(repositoryContext));
            _autopartRepository = new Lazy<IAutopartRepository>(() => new AutopartRepository(repositoryContext));
            _factoryRepository = new Lazy<IFactoryRepository>(() => new FactoryRepository(repositoryContext));
        }

        public ICategoryRepository Category => _categoryRepository.Value;

        public ISubcategoryRepository Subcategory => _subcategoryRepository.Value;

        public IAutopartRepository Autopart => _autopartRepository.Value;
        
        public IFactoryRepository Factory => _factoryRepository.Value;

        

        public void Save() => _repositoryContext.SaveChanges();
    }
}
