using Business.Interfaces;
using Business.Models;

namespace Business.Services
{
    public class LanguageService : ILanguageService
    {
        private string _currentLanguage = "English";

        public LanguageResult SetLanguage(string languageCode)
        {
         
            string validatedLanguage = languageCode switch
            {
                "sv" => "Swedish",
                "en" => "English",
                _ => "English"
            };

            var previousLanguage = _currentLanguage;
            _currentLanguage = validatedLanguage;

            return new LanguageResult
            {
                Language = _currentLanguage,
                IsLanguageChanged = _currentLanguage != previousLanguage
            };
        }

        public void SaveLanguagePreference(string languageCode)
        {
         
        }
    }
}
