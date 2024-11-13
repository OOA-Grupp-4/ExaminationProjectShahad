using System.Collections.Generic;
using System.Linq;
using Business.Models;

namespace Business.Services
{
    public class FilteringService
    {
        public IEnumerable<Product> FilterByCategory(IEnumerable<Product> products, string category)
        {
            return products.Where(p => p.Category == category);
        }
    }
}
