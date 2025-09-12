using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions
{
    public class MissingPlanetCoordinatesException : DomainException
    {
        public MissingPlanetCoordinatesException() : base("Planet requires coordinates.")
        {

        }
    }
}
