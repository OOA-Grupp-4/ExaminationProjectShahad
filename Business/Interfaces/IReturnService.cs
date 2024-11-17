using Business.Models;

namespace Business.Interfaces
{
    public interface IReturnService
    {
        ReturnResult InitiateReturn(Product product);
    }
}
