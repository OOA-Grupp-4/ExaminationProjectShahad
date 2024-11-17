using Business.Interfaces;
using Business.Services;

namespace Business.Factories
{
    public static class ReturnServiceFactory
    {
        public static IReturnService CreateReturnService()
        {
            return new ReturnService();
        }
    }
}
