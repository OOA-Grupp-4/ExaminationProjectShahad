using Business.Models;

namespace Business.Interfaces
{
    public interface ILanguageService
    {
        LanguageResult SetLanguage(string languageCode);
        void SaveLanguagePreference(string languageCode);
    }
}
