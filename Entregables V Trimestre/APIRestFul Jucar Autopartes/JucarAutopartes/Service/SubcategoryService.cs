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
    internal sealed class SubcategoryService : ISubcategoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SubcategoryService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<SubcategoryDto> GetAllSubcategories(bool trackChanges)
        {
            var subcategories = _repository.Subcategory.GetAllSubcategories(trackChanges);

            var subcategoriesDto = _mapper.Map<IEnumerable<SubcategoryDto>>(subcategories);

            return subcategoriesDto;
        }

        public SubcategoryDto GetSubcategory(Guid id, bool trackChanges)
        {
            var subcategory = _repository.Subcategory.GetSubcategory(id, trackChanges);

            if (subcategory is null)
                throw new SubcategoryNotFoundException(id);

            var subcategoryDto = _mapper.Map<SubcategoryDto>(subcategory);

            return subcategoryDto;
        }
    }
}
