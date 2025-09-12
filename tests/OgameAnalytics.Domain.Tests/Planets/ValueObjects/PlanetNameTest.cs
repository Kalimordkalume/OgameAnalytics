using OgameAnalytics.Domain.Planets.Exceptions;
using OgameAnalytics.Domain.Planets.ValueObjects;

namespace OgameAnalytics.Domain.Tests.Planets.ValueObjects
{
    public class PlanetNameTest
    {
        [Theory]
        [InlineData("Terra")]
        [InlineData("Mars")]
        [InlineData("A")]
        [InlineData("A very long planet name that is still valid")]
        public void Create_WithValidName_ShouldReturnPlanetName(string validName)
        {
            var planetName = PlanetName.Create(validName);

            Assert.Equal(validName, planetName.Value);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Create_WithInvalidName_ShouldThrowInvalidNameForPlanetException(string invalidName)
        {
            Assert.Throws<InvalidNameForPlanetException>(() => PlanetName.Create(invalidName));
        }

        [Fact]
        public void Create_WithNameTooLong_ShouldThrowInvalidNameForPlanetException()
        {
            var tooLongName = new string('A', 151); // Exactly 151 characters

            Assert.Throws<InvalidNameForPlanetException>(() => PlanetName.Create(tooLongName));
        }

        [Fact]
        public void Create_WithMaximumValidLength_ShouldReturnPlanetName()
        {
            var maxLengthName = "A".PadRight(150, 'A'); // Exactly 150 characters

            var planetName = PlanetName.Create(maxLengthName);

            Assert.Equal(maxLengthName, planetName.Value);
        }

        [Fact]
        public void Create_WithWhitespaceOnly_ShouldThrowInvalidNameForPlanetException()
        {
            Assert.Throws<InvalidNameForPlanetException>(() => PlanetName.Create("   \t   \n   "));
        }
    }
}
