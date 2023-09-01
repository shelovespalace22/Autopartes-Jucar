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
    public class AutopartService : IAutopartService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public AutopartService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<Autopart> GetAllAutoparts(bool trackChanges)
        {
            try
            {
                var autoparts = _repository.Autopart.GetAllAutoparts(trackChanges);
                return autoparts;
            }
            catch (Exception ex)
            {

                _logger.LogError($"Something went wrong in the {nameof(GetAllAutoparts)} service method {ex} ");

                throw;
            }
        }
    }
}
