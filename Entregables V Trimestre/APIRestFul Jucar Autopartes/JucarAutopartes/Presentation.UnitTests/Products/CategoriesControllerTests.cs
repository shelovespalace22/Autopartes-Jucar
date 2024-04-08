using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.UnitTests.Products
{
    public class CategoriesControllerTests
    {
        [Fact]
        public async Task CreateCategory_ReturnsCreatedAtRouteResult_WithMovementDto()
        {
            //Arrange
            var serviceManagerMock = new Mock<IServiceManager>();

            var categoryServiceMock = new Mock<ICategoryService>();

            var categoryForCreation = new CategoryForCreationDto
            {
                Name = "Category Test",
            };

            var categoryDto = new CategoryDto
            {
                CategoryId = Guid.NewGuid(),
                Name = "Category Test",
                State = true,
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
            };

            categoryServiceMock.Setup(service => service.CreateCategoryAsync(categoryForCreation))
                .ReturnsAsync(categoryDto);

            serviceManagerMock.SetupGet(x => x.CategoryService).Returns(categoryServiceMock.Object);

            var controller = new CategoriesController(serviceManagerMock.Object);

            //Act
            var actionResult = await controller.CreateCategory(categoryForCreation);

            //Assert
            var createdAtRouteResult = Assert.IsType<CreatedAtRouteResult>(actionResult);

            var returnedDto = Assert.IsType<CategoryDto>(createdAtRouteResult.Value);

            Assert.Equal(categoryDto.CategoryId, returnedDto.CategoryId);
            Assert.Equal(categoryForCreation.Name, returnedDto.Name);

            Assert.Equal(returnedDto.CategoryId, createdAtRouteResult.RouteValues["id"]);
        }
    }
}
