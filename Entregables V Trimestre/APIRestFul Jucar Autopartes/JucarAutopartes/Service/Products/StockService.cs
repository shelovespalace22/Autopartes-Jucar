using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Products;
using Entities.Models.Products;
using Service.Contracts.Products;
using Shared.DataTransferObjects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Products
{
    internal sealed class StockService : IStockService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public StockService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear */
        public StockDto CreateStockForRawMaterial(Guid rawMaterialId, StockForCreationDto stockForCreation, bool trackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(rawMaterialId, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            var stockEntity = _mapper.Map<Stock>(stockForCreation);

            _repository.Stock.CreateStockForRawMaterial(rawMaterialId, stockEntity);

            _repository.Save();

            var stockToReturn = _mapper.Map<StockDto>(stockEntity);

            return stockToReturn;
        }


        /* Eliminar */

        public void DeleteStockForRawMaterial(Guid rawMaterialId, Guid id, bool trackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(rawMaterialId, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            var stockForRawMaterial = _repository.Stock.GetStockByRawMaterial(rawMaterialId, id, trackChanges);

            if (stockForRawMaterial is null)
                throw new StockNotFoundException(id);

            _repository.Stock.DeleteStock(stockForRawMaterial);

            _repository.Save();
        }


        /* Único Registro */

        public StockDto GetStockForRawMaterial(Guid rawMaterialId, Guid id, bool trackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(rawMaterialId, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            var stockDb = _repository.Stock.GetStockByRawMaterial(rawMaterialId, id, trackChanges);

            if (stockDb is null)
                throw new StockNotFoundException(id);

            var stock = _mapper.Map<StockDto>(stockDb);

            return stock;
        }


        /* Listar */

        public IEnumerable<StockDto> GetStocks(Guid rawMaterialId, bool trackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(rawMaterialId, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            var stocksFromDb = _repository.Stock.GetStocks(rawMaterialId, trackChanges);

            var stocksDto = _mapper.Map<IEnumerable<StockDto>>(stocksFromDb);

            return stocksDto;
        }


        /* Actualizar */

        public void UpdateStockForRawMaterial(Guid rawMaterialId, Guid id, StockForUpdateDto stockForUpdate, bool rawTrackChanges, bool stcTrackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(rawMaterialId, rawTrackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            var stockEntity = _repository.Stock.GetStockByRawMaterial(rawMaterialId, id, stcTrackChanges);

            if (stockEntity is null)
                throw new StockNotFoundException(id);

            _mapper.Map(stockForUpdate, stockEntity);

            stockEntity.setModificationDate();

            _repository.Save();
        }
    }
}
