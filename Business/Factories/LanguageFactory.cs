using Business.Interfaces;
using Business.Services;

namespace Business.Factories
{
    public static class LanguageFactory
    {
        public static ILanguageService CreateLanguageService()
        {
            return new LanguageService();
        }
    }
}
