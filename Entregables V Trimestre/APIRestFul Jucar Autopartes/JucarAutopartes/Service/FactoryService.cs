using AutoMapper;
using Contracts;
using Entities.Models.Factories;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class FactoryService : IFactoryService
    {

        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper ;

        public FactoryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<Factory> GetAllFactories(bool trackChanges)
        {
            try
            {
                var companies = _repository.Factory.GetAllFactories(trackChanges);
                return companies;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllFactories)}servive method {ex}");
                throw;
            }
        }

       
    }

    
}
