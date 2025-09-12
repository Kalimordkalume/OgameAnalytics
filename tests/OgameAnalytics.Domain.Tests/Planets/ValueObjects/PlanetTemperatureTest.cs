using OgameAnalytics.Domain.Planets.Exceptions;
using OgameAnalytics.Domain.Planets.ValueObjects;

namespace OgameAnalytics.Domain.Tests.Planets.ValueObjects
{
    public class PlanetTemperatureTest
    {
        [Theory]
        [InlineData(30, 90)]
        [InlineData(-50, 40)]
        [InlineData(PlanetTemperature.MinAllowed, PlanetTemperature.MaxAllowed)]
        public void FromPrimitives_WithValidValues_ShouldPass(int minTemp, int maxTemp)
        {
            PlanetTemperature tempToBeTested = PlanetTemperature.FromPrimitives(minTemp, maxTemp);
            Assert.Equal(minTemp, tempToBeTested.MinValue);
            Assert.Equal(maxTemp, tempToBeTested.MaxValue);
        }

        [Theory]
        [InlineData(90, 30)]
        [InlineData(PlanetTemperature.MaxAllowed, PlanetTemperature.MinAllowed)]
        [InlineData(0, 4000)]
        [InlineData(-3000, 0)]
        public void FromPrimitives_WithValuesOutOfRange_ShouldThrow_PlanetTemperatureOutOfRangeException(int minTemp, int maxTemp)
        {
            Assert.Throws<PlanetTemperatureOutOfRangeException>(() => PlanetTemperature.FromPrimitives(minTemp, maxTemp));

        }
    }
}
