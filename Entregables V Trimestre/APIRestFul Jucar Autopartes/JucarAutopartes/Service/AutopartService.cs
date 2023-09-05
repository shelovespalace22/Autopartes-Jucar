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
    internal sealed class AutopartService : IAutopartService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AutopartService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<AutopartDto> GetAllAutoparts(bool trackChanges)
        {
            var autoparts = _repository.Autopart.GetAllAutoparts(trackChanges);

            var autopartsDto = _mapper.Map<IEnumerable<AutopartDto>>(autoparts);

            return autopartsDto;
        }

        public AutopartDto GetAutopart(Guid id, bool trackChanges)
        {
            var autopart = _repository.Autopart.GetAutopart(id, trackChanges);

            var autopartDto = _mapper.Map<AutopartDto>(autopart);

            return autopartDto;
        }
    }
}
