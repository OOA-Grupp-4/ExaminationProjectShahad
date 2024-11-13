using Business.Models;
using Business.Services;
using FluentAssertions;


namespace Business.Tests
{
    public class FilteringServiceTests
    {
        private readonly FilteringService _filteringService;

        public FilteringServiceTests()
        {
            _filteringService = new FilteringService();
        }

        [Fact]
        public void FilterByCategory_ShouldReturnOnlyProductsOfSpecifiedCategory()
        {
            // Arrange
            var products = new List<Product> { new() { Id = Guid.NewGuid(), Name = "Product 1", Category = "Electronics" }, new Product { Id = Guid.NewGuid(), Name = "Product 2", Category = "Books" }, new Product { Id = Guid.NewGuid(), Name = "Product 3", Category = "Electronics" } };
            string categoryToFilter = "Electronics";

            // Act
            var result = _filteringService.FilterByCategory(products, categoryToFilter);

            // Assert
            result.Should().NotBeNull();
            result.Should().HaveCount(2);
            result.All(p => p.Category == categoryToFilter).Should().BeTrue();
        }
    }
}
