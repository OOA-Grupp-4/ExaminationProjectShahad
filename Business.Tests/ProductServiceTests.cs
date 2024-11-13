using Business.Services;
using FluentAssertions;

namespace Business.Tests
{
    public class ProductServiceTests
    {
        private readonly ProductService _productService;
        public ProductServiceTests()

        {
            _productService = new ProductService();
        }

        [Fact]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            //(Arrange]

            var expectedProductCount = 3; 
            // Act

            var result = _productService.GetAllProducts();
            // Assert

            result.Should().NotBeNull();
            result.Should().HaveCount(expectedProductCount);
        }
    }
}
