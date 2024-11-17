using Business.Interfaces;
using Business.Models;

namespace Business.Services
{
    public class ReturnService : IReturnService
    {
        public ReturnResult InitiateReturn(Product product)
        {
            if (product == null || !product.IsPurchased)
                return new ReturnResult { IsReturnPageDisplayed = false };

            return new ReturnResult { IsReturnPageDisplayed = true };
        }
    }
}
