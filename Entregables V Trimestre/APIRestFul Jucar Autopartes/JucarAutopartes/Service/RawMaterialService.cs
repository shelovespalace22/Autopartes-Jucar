using AutoMapper;
using Contracts;
using Entities.Models.Products;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RawMaterialService : IRawMaterialService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RawMaterialService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear un RawMaterial */
        public RawMaterialDto CreateRawMaterial(RawMaterialForCreationDto rawMaterial)
        {
            var rawMaterialEntity = _mapper.Map<RawMaterial>(rawMaterial);

            _repository.RawMaterial.CreateRawMaterial(rawMaterialEntity);

            _repository.Save();

            var rawMaterialToReturn = _mapper.Map<RawMaterialDto>(rawMaterialEntity);

            return rawMaterialToReturn;
        }
    }
}
