using Business.Models;

namespace Business.Services
{
    public class ProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "Produkt 1", Price = 99.99m, Description = "Beskrivning 1", InStock = true },
                new Product { Id = Guid.NewGuid(), Name = "Produkt 2", Price = 149.99m, Description = "Beskrivning 2", InStock = true },
                new Product { Id = Guid.NewGuid(), Name = "Produkt 3", Price = 199.99m, Description = "Beskrivning 3", InStock = false }
            };
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
