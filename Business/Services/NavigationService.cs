using Business.Models;

namespace Business.Services
{
    public class NavigationService
    {
        public Product NavigateToProductPage(Guid productId)
        {
            return new Product
            {
                Id = productId,
                Name = "Sample Product",
                Price = 100,
                Description = "Sample Description"
            };
        }
    }
}
