using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions
{
    public class MissingPlanetTemperatureException : DomainException
    {
        public MissingPlanetTemperatureException() : base("A planet must have temperature.")
        {
        }
    }
}
