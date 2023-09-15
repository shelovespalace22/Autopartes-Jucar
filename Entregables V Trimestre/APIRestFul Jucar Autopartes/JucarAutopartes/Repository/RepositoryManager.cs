using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Contracts.Products;
using Repository.Products;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;

        private readonly Lazy<ICategoryRepository> _categoryRepository;

        private readonly Lazy<ISubcategoryRepository> _subcategoryRepository;

        private readonly Lazy<IAutopartRepository> _autopartRepository;

        private readonly Lazy<IRawMaterialRepository> _rawMaterialRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;


            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(repositoryContext));

            _subcategoryRepository = new Lazy<ISubcategoryRepository>(() => new SubcategoryRepository(repositoryContext));

            _autopartRepository = new Lazy<IAutopartRepository>(() => new AutopartRepository(repositoryContext));

            _rawMaterialRepository = new Lazy<IRawMaterialRepository>(() => new RawMaterialRepository(repositoryContext));

        }

        public ICategoryRepository Category => _categoryRepository.Value;

        public ISubcategoryRepository Subcategory => _subcategoryRepository.Value;

        public IAutopartRepository Autopart => _autopartRepository.Value;

        public IRawMaterialRepository RawMaterial => _rawMaterialRepository.Value;
        

        

        public void Save() => _repositoryContext.SaveChanges();
    }
}
