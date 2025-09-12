using OgameAnalytics.Domain.Planets.Exceptions;

namespace OgameAnalytics.Domain.Planets.ValueObjects
{
    public record PlanetTemperature
    {
        public int MinValue { get; }
        public int MaxValue { get; }

        public const int MinAllowed = -180;
        public const int MaxAllowed = 260;

        private PlanetTemperature(int minTemperature, int maxTemperature)
        {
            MinValue = minTemperature;
            MaxValue = maxTemperature;
        }


        public static PlanetTemperature FromPrimitives(int minTemp, int maxTemp)
        {
            EnsureTemperaturesAreInRange(minTemp, maxTemp);
            return new PlanetTemperature(minTemp, maxTemp);
        }

        private static void EnsureTemperaturesAreInRange(int minTemp, int maxTemp)
        {
            if (minTemp < MinAllowed || maxTemp > MaxAllowed || minTemp > maxTemp)
                throw new PlanetTemperatureOutOfRangeException(minTemp, maxTemp, MinAllowed, MaxAllowed);

        }
    }

}
