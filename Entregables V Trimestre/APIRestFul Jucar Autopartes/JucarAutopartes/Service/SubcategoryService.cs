using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models.Products;
using Service.Contracts;

namespace Service
{
    public class SubcategoryService : ISubcategoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public SubcategoryService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<Subcategory> GetAllSubcategories(bool trackChanges)
        {
            try
            {
                var subcategories = _repository.Subcategory.GetAllSubcategories(trackChanges);
                return subcategories;
            }
            catch (Exception ex)
            {

                _logger.LogError($"Something went wrong in the {nameof(GetAllSubcategories)} service method {ex} ");

                throw;
            }
        }
    }
}
