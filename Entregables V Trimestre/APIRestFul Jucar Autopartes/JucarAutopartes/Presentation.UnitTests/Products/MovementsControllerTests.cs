using Castle.Components.DictionaryAdapter;

namespace Presentation.UnitTests.Products
{
    public class MovementsControllerTests
    {
        [Fact]
        public async Task CreateMovementForRawMaterial_ReturnsCreatedAtRouteResult_WithMovementDto()
        {
            // Arrange
            var serviceManagerMock = new Mock<IServiceManager>();
            var movementServiceMock = new Mock<IMovementService>();

            var rawMaterialId = Guid.NewGuid();

            var movementForCreation = new MovementForCreationDto
            {
                Quantity = 150,
                MovementType = "Entrada",
                MovementDate = new DateTime(2024, 3, 30)
            };

            var movementDto = new MovementDto
            {
                MovementID = Guid.NewGuid(),
                Quantity = movementForCreation.Quantity,
                MovementType = movementForCreation.MovementType,
                MovementDate = movementForCreation.MovementDate,
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                RawMaterialId = rawMaterialId
            };

            movementServiceMock.Setup(service => service.CreateMovementForRawmaterialAsync(rawMaterialId, movementForCreation, It.IsAny<bool>()))
                .ReturnsAsync(movementDto);

            serviceManagerMock.SetupGet(x => x.MovementService).Returns(movementServiceMock.Object);

            var controller = new MovementsController(serviceManagerMock.Object);

            // Act
            var actionResult = await controller.CreateMovementForRawmaterial(rawMaterialId, movementForCreation);

            // Assert
            var createdAtRouteResult = Assert.IsType<CreatedAtRouteResult>(actionResult);

            Assert.Equal("GetMovementByRawmaterial", createdAtRouteResult.RouteName);

            var returnedDto = Assert.IsType<MovementDto>(createdAtRouteResult.Value);
            Assert.Equal(movementDto.MovementID, returnedDto.MovementID);
            Assert.Equal(movementForCreation.Quantity, returnedDto.Quantity);
            Assert.Equal(movementForCreation.MovementType, returnedDto.MovementType);
            Assert.Equal(movementForCreation.MovementDate, returnedDto.MovementDate);
            Assert.Equal(rawMaterialId, returnedDto.RawMaterialId);

            Assert.Equal(rawMaterialId, createdAtRouteResult.RouteValues["rawMaterialId"]);
            Assert.Equal(returnedDto.MovementID, createdAtRouteResult.RouteValues["id"]);
        }

        [Fact]
        public async Task GetMovementsForRawmaterial_ReturnsOkResult_WithMovements()
        {
            // Arrange
            var serviceManagerMock = new Mock<IServiceManager>();
            var movementServiceMock = new Mock<IMovementService>();
            
            var rawMaterialId = Guid.NewGuid();

            var movementsDto = new List<MovementDto>
            {
                new MovementDto
                {
                    MovementID = Guid.NewGuid(),
                    Quantity = 3,
                    MovementType = "Salida",
                    MovementDate = new DateTime(2024, 3, 13),
                    CreationDate = new DateTime(2024, 3, 13, 9, 45, 7),
                    ModificationDate = new DateTime(2024, 3, 13, 9, 45, 7),
                    RawMaterialId = rawMaterialId
                },
                new MovementDto
                {
                    MovementID = Guid.NewGuid(),
                    Quantity = 20,
                    MovementType = "Entrada",
                    MovementDate = new DateTime(2024, 3, 13),
                    CreationDate = new DateTime(2024, 3, 13, 9, 45, 27),
                    ModificationDate = new DateTime(2024, 3, 13, 9, 45, 27),
                    RawMaterialId = rawMaterialId
                }
            };

            movementServiceMock.Setup(service => service.GetMovementsAsync(rawMaterialId, false))
                .ReturnsAsync(movementsDto);

            serviceManagerMock.SetupGet(x => x.MovementService).Returns(movementServiceMock.Object);

            var controller = new MovementsController(serviceManagerMock.Object);

            // Act
            var result = await controller.GetMovementsForRawmaterial(rawMaterialId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedMovements = Assert.IsType<List<MovementDto>>(okResult.Value);
            
            Assert.Equal(movementsDto[0].MovementID, returnedMovements[0].MovementID);
            Assert.Equal(movementsDto[1].MovementID, returnedMovements[1].MovementID);
            
        }

        [Fact]
        public async Task GetMovementByRawmaterial_ReturnsOkResult_WithMovement()
        {
            // Arrange
            var serviceManagerMock = new Mock<IServiceManager>();
            var movementServiceMock = new Mock<IMovementService>();

            var rawMaterialId = Guid.NewGuid();
            var movementId = Guid.NewGuid();

            var movementDto = new MovementDto
            {
                MovementID = movementId,
                Quantity = 20,
                MovementType = "Entrada",
                MovementDate = new DateTime(2024, 3, 13),
                CreationDate = new DateTime(2024, 3, 13, 9, 45, 27),
                ModificationDate = new DateTime(2024, 3, 13, 9, 45, 27),
                RawMaterialId = rawMaterialId
            };

            movementServiceMock.Setup(service => service.GetMovementForRawmaterialAsync(rawMaterialId, movementId, false))
                .ReturnsAsync(movementDto);

            serviceManagerMock.SetupGet(x => x.MovementService).Returns(movementServiceMock.Object);

            var controller = new MovementsController(serviceManagerMock.Object);

            // Act
            var result = await controller.GetMovementByRawmaterial(rawMaterialId, movementId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedMovement = Assert.IsType<MovementDto>(okResult.Value);
            Assert.Equal(movementDto.MovementID, returnedMovement.MovementID);
            Assert.Equal(movementDto.Quantity, returnedMovement.Quantity);
            Assert.Equal(movementDto.MovementType, returnedMovement.MovementType);
            Assert.Equal(movementDto.MovementDate, returnedMovement.MovementDate);
            Assert.Equal(movementDto.RawMaterialId, returnedMovement.RawMaterialId);
        }

        [Fact]
        public async Task UpdateMovementForRawMaterial_ReturnsNoContentResult()
        {
            // Arrange
            var serviceManagerMock = new Mock<IServiceManager>();
            var movementServiceMock = new Mock<IMovementService>();

            var rawMaterialId = Guid.NewGuid();
            var movementId = Guid.NewGuid();

            var movementForUpdateDto = new MovementForUpdateDto
            {
                Quantity = 10,
                MovementType = "Salida",
                MovementDate = new DateTime(2023, 12, 7)
            };

            movementServiceMock.Setup(service => service.UpdateMovementForRawmaterialAsync(rawMaterialId, movementId, movementForUpdateDto, false, true))
                .Verifiable();

            serviceManagerMock.SetupGet(x => x.MovementService).Returns(movementServiceMock.Object);

            var controller = new MovementsController(serviceManagerMock.Object);

            // Act
            var result = await controller.UpdateMovementForRawmaterial(rawMaterialId, movementId, movementForUpdateDto);

            // Assert
            Assert.IsType<NoContentResult>(result);

            movementServiceMock.Verify(service => service.UpdateMovementForRawmaterialAsync(rawMaterialId, movementId, movementForUpdateDto, false, true), Times.Once());
        }

        [Fact]
        public async Task DeleteMovementForRawMaterial_ReturnsNoContentResult()
        {
            // Arrange
            var serviceManagerMock = new Mock<IServiceManager>();
            var movementServiceMock = new Mock<IMovementService>();

            var rawMaterialId = Guid.NewGuid();
            var movementId = Guid.NewGuid();

            
            movementServiceMock.Setup(service => service.DeleteMovementForRawmaterialAsync(rawMaterialId, movementId, false))
                .Verifiable("El servicio no fue llamado con los parámetros esperados.");

            serviceManagerMock.SetupGet(x => x.MovementService).Returns(movementServiceMock.Object);

            var controller = new MovementsController(serviceManagerMock.Object);

            // Act
            var result = await controller.DeleteMovementForRawmaterial(rawMaterialId, movementId);

            // Assert
            Assert.IsType<NoContentResult>(result);

            movementServiceMock.Verify(service => service.DeleteMovementForRawmaterialAsync(rawMaterialId, movementId, false), Times.Once());
        }
    }
}
