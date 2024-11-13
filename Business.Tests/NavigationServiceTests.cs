using Business.Services;
using FluentAssertions;

namespace Business.Tests
{
    public class NavigationServiceTests
    {
        private readonly NavigationService _navigationService;

        public NavigationServiceTests()
        {
            _navigationService = new NavigationService();
        }

        [Fact]
        public void NavigateToProductPage_ShouldReturnProductPageForSelectedProduct()
        {
            // Arrange
            var productId = Guid.NewGuid();

            // Act
            var result = _navigationService.NavigateToProductPage(productId);

            // Assert
            result.Should().NotBeNull();
            result.Id.Should().Be(productId);
        }
    }
}
