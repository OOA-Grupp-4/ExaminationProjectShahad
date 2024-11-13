using Business.Models;

namespace Business.Services
{
    public class SortingService
    {
        public List<Product> SortByName(List<Product> products)
        {
            return products.OrderBy(p => p.Name).ToList();
        }
    }
}
