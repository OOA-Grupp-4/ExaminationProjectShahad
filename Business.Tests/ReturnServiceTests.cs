using Business.Interfaces;
using Business.Models;
using Business.Services;


namespace Business.Tests
{
    public class ReturnServiceTests
    {
        private readonly IReturnService _returnService;

        public ReturnServiceTests()
        {
            _returnService = new ReturnService();
        }

        [Fact]
        public void InitiateReturn_ShouldShowReturnReasonPage_WhenProductIsEligibleForReturn()
        {
            // Arrange
            var product = new Product { Name = "TestProduct", IsPurchased = true };

            // Act
            var result = _returnService.InitiateReturn(product);

            // Assert
            Assert.True(result.IsReturnPageDisplayed);
        }
    }
}
