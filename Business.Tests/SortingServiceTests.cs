using Business.Models;
using Business.Services;
using FluentAssertions;

namespace Business.Tests
{
    public class SortingServiceTests
    {
        private readonly SortingService _sortingService;

        public SortingServiceTests()
        {
            _sortingService = new SortingService();
        }

        [Fact]
        public void SortByName_ShouldReturnProductsSortedByName()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "Smartphone", Category = "Electronics" },
                new Product { Id = Guid.NewGuid(), Name = "Laptop", Category = "Electronics" },
                new Product { Id = Guid.NewGuid(), Name = "Tablet", Category = "Electronics" }
            };

            // Act
            var result = _sortingService.SortByName(products);

            // Assert
            result.Should().NotBeNull();
            result.Should().HaveCount(3);
            result[0].Name.Should().Be("Laptop");
            result[1].Name.Should().Be("Smartphone");
            result[2].Name.Should().Be("Tablet");
        }
    }
}
