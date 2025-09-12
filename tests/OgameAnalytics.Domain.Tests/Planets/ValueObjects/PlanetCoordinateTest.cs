using OgameAnalytics.Domain.Planets.Exceptions;
using OgameAnalytics.Domain.Planets.ValueObjects;

namespace OgameAnalytics.Domain.Tests.Planets.ValueObjects
{
    public class PlanetCoordinateTest
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(15, 499, 15)]
        [InlineData(8, 250, 8)]
        [InlineData(1, 499, 1)]
        [InlineData(15, 1, 15)]
        public void From_WithValidCoordinates_ShouldReturnPlanetCoordinate(int galaxy, int solarSystem, int position)
        {
            var coordinate = PlanetCoordinate.From(galaxy, solarSystem, position);

            Assert.Equal(galaxy, coordinate.GalaxyValue);
            Assert.Equal(solarSystem, coordinate.SolarSystemValue);
            Assert.Equal(position, coordinate.PlanetPositionValue);
        }

        [Theory]
        [InlineData(0, 1, 1, typeof(NotAValidGalaxyException))]
        [InlineData(16, 1, 1, typeof(NotAValidGalaxyException))]
        [InlineData(-1, 1, 1, typeof(NotAValidGalaxyException))]
        public void From_WithInvalidGalaxy_ShouldThrowNotAValidGalaxyException(int galaxy, int solarSystem, int position, Type expectedException)
        {
            Assert.Throws(expectedException, () => PlanetCoordinate.From(galaxy, solarSystem, position));
        }

        [Theory]
        [InlineData(1, 0, 1, typeof(NotAValidSolarSystemException))]
        [InlineData(1, 500, 1, typeof(NotAValidSolarSystemException))]
        [InlineData(1, -1, 1, typeof(NotAValidSolarSystemException))]
        public void From_WithInvalidSolarSystem_ShouldThrowNotAValidSolarSystemException(int galaxy, int solarSystem, int position, Type expectedException)
        {
            Assert.Throws(expectedException, () => PlanetCoordinate.From(galaxy, solarSystem, position));
        }

        [Theory]
        [InlineData(1, 1, 0, typeof(NotAValidPlanetPositionException))]
        [InlineData(1, 1, 16, typeof(NotAValidPlanetPositionException))]
        [InlineData(1, 1, -1, typeof(NotAValidPlanetPositionException))]
        public void From_WithInvalidPlanetPosition_ShouldThrowNotAValidPlanetPositionException(int galaxy, int solarSystem, int position, Type expectedException)
        {
            Assert.Throws(expectedException, () => PlanetCoordinate.From(galaxy, solarSystem, position));
        }

        [Fact]
        public void From_WithBoundaryValues_ShouldReturnValidCoordinate()
        {
            var coordinate = PlanetCoordinate.From(1, 1, 1);

            Assert.Equal(1, coordinate.GalaxyValue);
            Assert.Equal(1, coordinate.SolarSystemValue);
            Assert.Equal(1, coordinate.PlanetPositionValue);
        }

        [Fact]
        public void From_WithUpperBoundaryValues_ShouldReturnValidCoordinate()
        {
            var coordinate = PlanetCoordinate.From(15, 499, 15);

            Assert.Equal(15, coordinate.GalaxyValue);
            Assert.Equal(499, coordinate.SolarSystemValue);
            Assert.Equal(15, coordinate.PlanetPositionValue);
        }
    }
}
