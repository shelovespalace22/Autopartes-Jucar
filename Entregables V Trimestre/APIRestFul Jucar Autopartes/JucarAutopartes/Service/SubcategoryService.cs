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

        /* Obtener todas las Subcategorias en general*/
        public IEnumerable<SubcategoryDto> GetAllSubcategories(bool trackChanges)
        {
            var subcategories = _repository.Subcategory.GetAllSubcategories(trackChanges);

            var subcategoriesDto = _mapper.Map<IEnumerable<SubcategoryDto>>(subcategories);

            return subcategoriesDto;
        }

        /* Obtener una Subcategoria por su Id */
        public SubcategoryDto GetSubcategoryById(Guid id, bool trackChanges)
        {
            var subcategory = _repository.Subcategory.GetSubcategoryById(id, trackChanges);

            if (subcategory is null)
                throw new SubcategoryNotFoundException(id);

            var subcategoryDto = _mapper.Map<SubcategoryDto>(subcategory);

            return subcategoryDto;
        }

        /* Obteniendo las Subcategorias de una Categoria */

        public IEnumerable<SubcategoryDto> GetSubcategories(Guid categoryId, bool trackChanges)
        {
            var category = _repository.Category.GetCategory(categoryId, trackChanges);

            if(category is null)
                throw new CategoryNotFoundException(categoryId);

            var subcategoriesFromDb = _repository.Subcategory.GetSubcategories(categoryId, trackChanges);

            var subcategoriesDto = _mapper.Map<IEnumerable<SubcategoryDto>>(subcategoriesFromDb);

            return subcategoriesDto;
        }
    }
}
