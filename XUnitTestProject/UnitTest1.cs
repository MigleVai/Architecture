using Architecture.API.Controllers;
using Architecture.Domain;
using Architecture.Domain.Storage;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using Xunit;
using Assert = Xunit.Assert;

namespace XUnitTestProject
{
    public class UnitTest1
    {

        // --------------------------GetID()---------------------------
        [Fact]
        public void GetSaleModelIDTest()
        {
            var id = Guid.NewGuid();
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>();
            mockRepository.Setup(x => x.Get(It.IsAny<Guid>())).Returns(new SaleModel
            {
                Id = id
            });
            var controller = new SaleAPIController(mockRepository.Object);

            // Act
            var actionResult = controller.GetSaleModel(id) as OkObjectResult;

            // Assert
            Assert.NotNull(actionResult);
            Assert.Equal((int)HttpStatusCode.OK, actionResult.StatusCode);
            Assert.NotNull(actionResult.Value);
            Assert.IsType<SaleModel>(actionResult.Value);
            Assert.Equal(id, (actionResult.Value as SaleModel).Id);
        }

        [Fact]
        public void GetSaleModelIDBadRequestTest()
        {
            var id = Guid.NewGuid();
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>();
            var controller = new SaleAPIController(mockRepository.Object);
            controller.ModelState.AddModelError("Error", "Error");
            // Act
            var actionResult = controller.GetSaleModel(id) as BadRequestObjectResult;
            // Assert
            Assert.NotNull(actionResult);
            Assert.Equal((int)HttpStatusCode.BadRequest, actionResult.StatusCode);
        }

        [Fact]
        public void GetSaleModelIDNotFoundTest()
        {
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>().Object;
            var controller = new SaleAPIController(mockRepository);
            var fakeId = Guid.NewGuid();
            // Act
            var actionResult = controller.GetSaleModel(fakeId) as NotFoundResult;
            // Assert
            Assert.NotNull(actionResult);
            Assert.Equal((int)HttpStatusCode.NotFound, actionResult.StatusCode);
        }

        // --------------------------GetAll()---------------------------

        [Fact]
        public void GetSaleModelEmptyTest()
        {
            var id = Guid.NewGuid();
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>();
            mockRepository.Setup(x => x.GetAll()).Returns(new List<SaleModel>());
            var controller = new SaleAPIController(mockRepository.Object);
 
            // Act
            var actionResult = controller.GetSaleModel() as List<SaleModel>;
            // Assert
            Assert.NotNull(actionResult);
            CollectionAssert.IsEmpty(actionResult);
           // CollectionAssert.AllItemsAreInstancesOfType(actionResult, SaleModel);
        }

        [Fact]
        public void GetSaleModelTest()
        {
            var id = Guid.NewGuid();
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>();
            mockRepository.Setup(x => x.GetAll()).Returns(new List<SaleModel> {
                new SaleModel()
            });
            var controller = new SaleAPIController(mockRepository.Object);

            // Act
            var actionResult = controller.GetSaleModel() as List<SaleModel>;
            // Assert
            Assert.NotNull(actionResult);
            CollectionAssert.IsNotEmpty(actionResult);
        }

        // --------------------------Put()---------------------------
        [Fact]
        public void PutSaleModelBadIDTest()
        {
            var id = Guid.NewGuid();
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>();
            var controller = new SaleAPIController(mockRepository.Object);

            // Act
            var actionResult = controller.PutSaleModel(id, new SaleModel()) as BadRequestResult;

            // Assert
            Assert.NotNull(actionResult);
            Assert.Equal((int)HttpStatusCode.BadRequest, actionResult.StatusCode);
        }

        [Fact]
        public void PutSaleModelBadRequestTest()
        {
            var id = Guid.NewGuid();
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>();
            var controller = new SaleAPIController(mockRepository.Object);
            controller.ModelState.AddModelError("Error", "Error");
            // Act
            var actionResult = controller.PutSaleModel(id, new SaleModel()) as BadRequestObjectResult;
            // Assert
            Assert.NotNull(actionResult);
            Assert.Equal((int)HttpStatusCode.BadRequest, actionResult.StatusCode);
        }

        [Fact]
        public void PutSaleModelTest()
        {
            var id = Guid.NewGuid();
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>();
            mockRepository.Setup(x => x.Remove(It.IsAny<Guid>()));
            mockRepository.Setup(x => x.Add(new SaleModel()));
            var controller = new SaleAPIController(mockRepository.Object);
            var tempSale = new SaleModel() { Id = id};
            // Act
            var actionResult = controller.PutSaleModel(id, tempSale) as NoContentResult;

            // Assert
            Assert.NotNull(actionResult);
            Assert.Equal((int)HttpStatusCode.NoContent, actionResult.StatusCode);
        }

        // --------------------------Post()---------------------------

        [Fact]
        public void PostSaleModelBadRequestTest()
        {
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>();
            var controller = new SaleAPIController(mockRepository.Object);
            controller.ModelState.AddModelError("Error", "Error");
            // Act
            var actionResult = controller.PostSaleModel(new SaleModel()) as BadRequestObjectResult;
            // Assert
            Assert.NotNull(actionResult);
            Assert.Equal((int)HttpStatusCode.BadRequest, actionResult.StatusCode);
        }

        [Fact]
        public void PostSaleModelTest()
        {
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>();
            mockRepository.Setup(x => x.Add(new SaleModel()));
            var controller = new SaleAPIController(mockRepository.Object);
            // Act
            var actionResult = controller.PostSaleModel(new SaleModel()) as CreatedAtActionResult;

            // Assert
            Assert.NotNull(actionResult);
            Assert.Equal((int)HttpStatusCode.Created, actionResult.StatusCode);
            Assert.NotNull(actionResult.Value);
        }

        // --------------------------Delete()---------------------------

        [Fact]
        public void DeleteSaleModelBadRequestTest()
        {
            var id = Guid.NewGuid();
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>();
            var controller = new SaleAPIController(mockRepository.Object);
            controller.ModelState.AddModelError("Error", "Error");
            // Act
            var actionResult = controller.DeleteSaleModel(id) as BadRequestObjectResult;
            // Assert
            Assert.NotNull(actionResult);
            Assert.Equal((int)HttpStatusCode.BadRequest, actionResult.StatusCode);
        }

        [Fact]
        public void DeleteSaleModelNotFoundTest()
        {
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>().Object;
            var controller = new SaleAPIController(mockRepository);
            var id = Guid.NewGuid();
            // Act
            var actionResult = controller.DeleteSaleModel(id) as NotFoundResult;
            // Assert
            Assert.NotNull(actionResult);
            Assert.Equal((int)HttpStatusCode.NotFound, actionResult.StatusCode);
        }

        [Fact]
        public void DeleteSaleModelTest()
        {
            var id = Guid.NewGuid();
            // Arrange
            var mockRepository = new Mock<IStorage<SaleModel>>();
            mockRepository.Setup(x => x.Get(id)).Returns(new SaleModel() { Id = id});
            mockRepository.Setup(x => x.Remove(It.IsAny<Guid>()));
            var controller = new SaleAPIController(mockRepository.Object);
            // Act
            var actionResult = controller.DeleteSaleModel(id) as OkObjectResult;

            // Assert
            Assert.NotNull(actionResult);
            Assert.Equal((int)HttpStatusCode.OK, actionResult.StatusCode);
            Assert.NotNull(actionResult.Value);
            Assert.IsType<SaleModel>(actionResult.Value);
            Assert.Equal(id, (actionResult.Value as SaleModel).Id);
        }
    }
}
