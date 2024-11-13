using Business.Models;
using Business.Services;
using FluentAssertions;

namespace Business.Tests
{
    public class ProductDetailsTests
    {
        private readonly ProductDetailsService _productDetailsService;

        public ProductDetailsTests()
        {
            _productDetailsService = new ProductDetailsService();
        }

        [Fact]
        public void GetProductDetails_ShouldReturnDetailedInformationForSelectedProduct()
        {
            // Arrange
            var productId = Guid.NewGuid();
            var expectedProduct = new Product
            {
                Id = productId,
                Name = "Sample Product",
                Price = 99.99m,
                Description = "This is a sample product.",
                Images = new List<string> { "image1.jpg", "image2.jpg" },
                StockStatus = "In Stock"
            };

            _productDetailsService.AddProduct(expectedProduct);

            // Act
            var result = _productDetailsService.GetProductDetails(productId);

            // Assert
            result.Should().NotBeNull();
            result.Id.Should().Be(productId);
            result.Price.Should().Be(expectedProduct.Price);
            result.Description.Should().Be(expectedProduct.Description);
            result.Images.Should().BeEquivalentTo(expectedProduct.Images);
            result.StockStatus.Should().Be(expectedProduct.StockStatus);
        }
    }
}
