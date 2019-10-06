using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetReturnsOk()
        {
            // Arrange
            var mockRepository = new Mock<IStorage>();
            var controller = new Products2Controller(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.Put(new Product { Id = 10, Name = "Product" });
            var contentResult = actionResult as NegotiatedContentResult<Product>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.AreEqual(HttpStatusCode.Accepted, contentResult.StatusCode);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(10, contentResult.Content.Id);
        }
    }
}
