using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions
{
    public class MissingPlanetNameException : DomainException
    {
        public MissingPlanetNameException() : base("Planet requires a name.")
        {
        }
    }
}
