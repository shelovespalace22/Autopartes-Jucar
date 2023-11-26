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
        public async Task<MovementDto> CreateMovementForRawmaterialAsync(Guid rawMaterialId, MovementForCreationDto movementForCreation, bool trackChanges)
        {
            var rawMaterial = await CheckIfRawMaterialExists(rawMaterialId, trackChanges);

            UpdateStockQuantity(rawMaterial, movementForCreation);

            var movementEntity = _mapper.Map<Movement>(movementForCreation);

            _repository.Movement.CreateMovementForRawmaterial(rawMaterialId, movementEntity);

            await _repository.SaveAsync();

            var movementToReturn = _mapper.Map<MovementDto>(movementEntity);

            return movementToReturn;
        }


        /* Eliminar */
        public async Task DeleteMovementForRawmaterialAsync(Guid rawMaterialId, Guid id, bool trackChanges)
        {
            await CheckIfRawMaterialExists(rawMaterialId, trackChanges);

            var movementForRawmaterial = await GetMovementForRawMaterialAndCheckIfItExists(rawMaterialId, id, trackChanges);

            _repository.Movement.DeleteMovement(movementForRawmaterial);

            await _repository.SaveAsync();
        }


        /* Único Registro */
        public async Task<MovementDto> GetMovementForRawmaterialAsync(Guid rawMaterialId, Guid id, bool trackChanges)
        {
            await CheckIfRawMaterialExists(rawMaterialId, trackChanges);

            var movementDb = await GetMovementForRawMaterialAndCheckIfItExists(rawMaterialId, id, trackChanges);

            var movement = _mapper.Map<MovementDto>(movementDb);

            return movement;
        }


        /* Listar */
        public async Task<IEnumerable<MovementDto>> GetMovementsAsync(Guid rawMaterialId, bool trackChanges)
        {
            await CheckIfRawMaterialExists(rawMaterialId, trackChanges);

            var movementsFromDb = await _repository.Movement.GetMovementsAsync(rawMaterialId, trackChanges);

            var movementsDto = _mapper.Map<IEnumerable<MovementDto>>(movementsFromDb);

            return movementsDto;
        }


        /* Actualizar */
        public async Task UpdateMovementForRawmaterialAsync(Guid rawMaterialId, Guid id, MovementForUpdateDto movementForUpdate, bool rawTrackChanges, bool movTrackChanges)
        {
            await CheckIfRawMaterialExists(rawMaterialId, rawTrackChanges);

            var movementEntity = await GetMovementForRawMaterialAndCheckIfItExists(rawMaterialId, id, movTrackChanges);

            _mapper.Map(movementForUpdate, movementEntity);

            movementEntity.setModificationDate();

            await _repository.SaveAsync();
        }






        /* <--- Métodos Privados ---> */

        public enum MovementType
        {
            Entrada,
            Salida
        }

        private async Task UpdateStockQuantity(RawMaterial rawMaterial, MovementForCreationDto movement)
        {
            // Verificar si 'rawMaterial.Stock' es null antes de acceder a 'StockID'
            if (rawMaterial.Stock is null)
                throw new StockNotFoundException(rawMaterial.Stock.StockID);

            // Buscar el stock correspondiente a la materia prima
            var stock = await _repository.Stock.GetStockByRawMaterialAsync(rawMaterial.RawMaterialID, rawMaterial.Stock.StockID, false);

            // Actualizar 'QuantityAvailable' del stock dependiendo del tipo de movimiento
            if (movement.MovementType == "Entrada" || movement.MovementType == "entrada")
            {
                stock.QuantityAvailable += movement.Quantity;
            }
            else if (movement.MovementType == "Salida" || movement.MovementType == "salida")
            {
                stock.QuantityAvailable -= movement.Quantity;
            }

            stock.setModificationDate();

            _repository.Stock.UpdateStockQuantity(stock);

            await _repository.SaveAsync();
        }

        private async Task<RawMaterial> CheckIfRawMaterialExists(Guid rawMaterialId, bool trackChanges)
        {
            var rawMaterial = await _repository.RawMaterial.GetRawMaterialAsync(rawMaterialId, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            return rawMaterial;
        }

        private async Task<Movement> GetMovementForRawMaterialAndCheckIfItExists(Guid rawMaterialId, Guid id, bool trackChanges)
        {
            var movementDb = await _repository.Movement.GetMovementByRawmaterialAsync(rawMaterialId, id, trackChanges);

            if (movementDb is null)
                throw new MovementNotFoundException(id);

            return movementDb;
        }
    }
}