using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models.Products;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CategoryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<CategoryDto> GetAllCategories(bool trackChanges)
        {
            var categories = _repository.Category.GetAllCategories(trackChanges);

            var categoriesDto = _mapper.Map<IEnumerable<CategoryDto>>(categories);

            return categoriesDto;
        }

        public CategoryDto GetCategory(Guid id, bool trackChanges) 
        {
            var category = _repository.Category.GetCategory(id, trackChanges);

            if (category is null)
                throw new CategoryNotFoundException(id);

            var categoryDto = _mapper.Map<CategoryDto>(category);   

            return categoryDto;
        }

        public CategoryDto CreateCategory(CategoryForCreationDto category)
        {
            var categoryEntity = _mapper.Map<Category>(category);

            _repository.Category.CreateCategory(categoryEntity);

            _repository.Save();

            var categoryToReturn = _mapper.Map<CategoryDto>(categoryEntity);

            return categoryToReturn;
        }

    }
}
