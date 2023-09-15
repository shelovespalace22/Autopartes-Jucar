using AutoMapper;
using Contracts;
using Service.Contracts.Products;
using Shared.DataTransferObjects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Products
{
    internal sealed class AutopartMaterialService : IAutopartMaterialService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AutopartMaterialService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Obtener todos los Materiales */

        public IEnumerable<AutopartMaterialDto> GetAllMaterials(bool trackChanges)
        {
            var materials = _repository.AutopartMaterial.GetAllMaterials(trackChanges);

            var materialsDto = _mapper.Map<IEnumerable<AutopartMaterialDto>>(materials);

            return materialsDto;
        }
    }
}
