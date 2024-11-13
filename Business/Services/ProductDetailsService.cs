using Business.Models;

namespace Business.Services
{
    public class ProductDetailsService
    {
        private readonly List<Product> _products = [];

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public Product? GetProductDetails(Guid productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
