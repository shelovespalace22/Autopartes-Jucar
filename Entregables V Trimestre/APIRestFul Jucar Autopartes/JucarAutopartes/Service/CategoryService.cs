using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.Models.Products;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    public class CategoryService : ICategoryService
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

        public CategoryDto GetCategory(int id, bool trackChanges) 
        {
            var category = _repository.Category.GetCategory(id, trackChanges);

            var categoryDto = _mapper.Map<CategoryDto>(category);   

            return categoryDto;
        }

    }
}
