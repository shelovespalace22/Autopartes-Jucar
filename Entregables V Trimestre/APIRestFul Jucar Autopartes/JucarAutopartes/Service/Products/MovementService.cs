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
    internal sealed class MovementService : IMovementService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MovementService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }


        /* Crear */

        public MovementDto CreateMovementForRawmaterial(Guid rawMaterialId, MovementForCreationDto movementForCreation, bool trackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(rawMaterialId, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            var movementEntity = _mapper.Map<Movement>(movementForCreation);

            UpdateStockQuantityAvailable(rawMaterialId, movementEntity.Quantity, movementEntity.MovementType);

            _repository.Movement.CreateMovementForRawmaterial(rawMaterialId, movementEntity);

            _repository.Save();

            var movementToReturn = _mapper.Map<MovementDto>(movementEntity);

            return movementToReturn;
        }


        /* Eliminar */

        public void DeleteMovementForRawmaterial(Guid rawMaterialId, Guid id, bool trackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(rawMaterialId, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            var movementForRawmaterial = _repository.Movement.GetMovementByRawmaterial(rawMaterialId, id, trackChanges);

            if (movementForRawmaterial is null)
                throw new MovementNotFoundException(id);

            _repository.Movement.DeleteMovement(movementForRawmaterial);

            _repository.Save();
        }


        /* Único Registro */

        public MovementDto GetMovementForRawmaterial(Guid rawMaterialId, Guid id, bool trackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(rawMaterialId, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            var movementDb = _repository.Movement.GetMovementByRawmaterial(rawMaterialId, id, trackChanges);

            if (movementDb is null)
                throw new MovementNotFoundException(id);

            var movement = _mapper.Map<MovementDto>(movementDb);

            return movement;
        }


        /* Listar */

        public IEnumerable<MovementDto> GetMovements(Guid rawMaterialId, bool trackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(rawMaterialId, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            var movementsFromDb = _repository.Movement.GetMovements(rawMaterialId, trackChanges);

            var movementsDto = _mapper.Map<IEnumerable<MovementDto>>(movementsFromDb);

            return movementsDto;
        }


        /* Actualizar */

        public void UpdateMovementForRawmaterial(Guid rawMaterialId, Guid id, MovementForUpdateDto movementForUpdate, bool rawTrackChanges, bool movTrackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(rawMaterialId, rawTrackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            var movementEntity = _repository.Movement.GetMovementByRawmaterial(rawMaterialId, id, movTrackChanges);

            if (movementEntity is null)
                throw new MovementNotFoundException(id);

            _mapper.Map(movementForUpdate, movementEntity);

            movementEntity.setModificationDate();

            _repository.Save();
        }






        /* <--- Métodos Privados ---> */
        private void UpdateStockQuantityAvailable(Guid rawMaterialId, int quantity, string movementType)
        {
            var rawM = _repository.RawMaterial.GetRawMaterial(rawMaterialId, false);

            var stock = rawM.Stock;

            var stockId = stock.StockID;

            var stocDSDSDk = _repository.Stock.GetStockByRawMaterial(rawMaterialId, stockId, false);

            if (stocDSDSDk != null)
            {
                if (movementType.ToLower() == "entrada")
                {
                    stocDSDSDk.QuantityAvailable += quantity;
                }
                else if (movementType.ToLower() == "salida")
                {
                    stocDSDSDk.QuantityAvailable -= quantity;
                }

                stocDSDSDk.setModificationDate();

                _repository.Stock.UpdateStockQuantity(stock);

                _repository.Save();
            }
        }
    }
}