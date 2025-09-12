using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions
{
    public class InvalidPlanetTemperatureException : DomainException
    {
        public InvalidPlanetTemperatureException(int value)
            : base($"Invalid planet max temperature: {value}. Valid range is [-180, 260].")
        {
        }
    }
}


