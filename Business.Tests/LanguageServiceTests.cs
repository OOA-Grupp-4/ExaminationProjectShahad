using Business.Factories;
using Business.Interfaces;
using Xunit;

namespace Business.Tests
{
    public class LanguageServiceTests
    {
        private readonly ILanguageService _languageService;

        public LanguageServiceTests()
        {
            _languageService = LanguageFactory.CreateLanguageService();
        }

        [Fact]
        public void SetLanguage_ShouldChangeLanguage_WhenValidLanguageCodeIsProvided()
        {
            // Arrange
            var languageCode = "sv";

            // Act
            var result = _languageService.SetLanguage(languageCode);

            // Assert
            Assert.Equal("Swedish", result.Language);
            Assert.True(result.IsLanguageChanged);
        }

        [Fact]
        public void SetLanguage_ShouldNotChangeLanguage_WhenSameLanguageCodeIsProvided()
        {
            // Arrange
            var languageCode = "en"; 

            // Act
            var result = _languageService.SetLanguage(languageCode);

            // Assert
            Assert.Equal("English", result.Language);
            Assert.False(result.IsLanguageChanged);
        }

        [Fact]
        public void SetLanguage_ShouldDefaultToEnglish_WhenInvalidLanguageCodeIsProvided()
        {
            // Arrange
            var languageCode = "de";

            // Act
            var result = _languageService.SetLanguage(languageCode);

            // Assert
            Assert.Equal("English", result.Language);
            Assert.False(result.IsLanguageChanged);
        }
    }
}
