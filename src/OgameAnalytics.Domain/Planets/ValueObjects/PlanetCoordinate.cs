using OgameAnalytics.Domain.Planets.Exceptions;

namespace OgameAnalytics.Domain.Planets.ValueObjects
{
    public record PlanetCoordinate
    {
        public int GalaxyValue { get; }
        public int SolarSystemValue { get; }
        public int PlanetPositionValue { get; }

        public readonly int[] ValidGalaxyRange = [1, 15];
        public readonly int[] ValidSolarSystemRange = [1, 499];
        public readonly int[] ValidPlanetPositionRange = [1, 15];

        private PlanetCoordinate(int galaxyValue, int solarSystemValue, int planetPositionValue)
        {
            GalaxyValue = galaxyValue;
            SolarSystemValue = solarSystemValue;
            PlanetPositionValue = planetPositionValue;
        }

        public static PlanetCoordinate From(int galaxyValue, int solarSystemValue, int planetPositionValue)
        {
            EnsureCordinates(galaxyValue, solarSystemValue, planetPositionValue);
            return new PlanetCoordinate(galaxyValue, solarSystemValue, planetPositionValue);
        }



        private static bool EnsureCordinates(int galaxyValue, int solarSystemValue, int planetPositionValue)
        {
            if (!IsAValidGalaxy(galaxyValue))
            {
                throw new NotAValidGalaxyException($"{galaxyValue} must be between this range [1,15].");
            }

            if (!IsAValidSolarSystem(solarSystemValue))
            {
                throw new NotAValidSolarSystemException($"{solarSystemValue} must be between this range [1,499].");
            }
            if (!IsAValidPlanetPosition(planetPositionValue))
            {
                throw new NotAValidPlanetPositionException($"{planetPositionValue} must be between this range [1,15]");
            }
            return true;
        }



        private static bool IsAValidPlanetPosition(int planetPositionValue)
        {
            if (planetPositionValue >= 1 && planetPositionValue <= 15)
            {
                return true;
            }
            return false;
        }

        private static bool IsAValidSolarSystem(int solarSystemValue)
        {
            if (solarSystemValue >= 1 && solarSystemValue <= 499)
            {
                return true;

            }
            return false;
        }

        private static bool IsAValidGalaxy(int galaxyValue)
        {
            if (galaxyValue >= 1 && galaxyValue <= 15)
            {
                return true;
            }
            return false;
        }
    }
}
