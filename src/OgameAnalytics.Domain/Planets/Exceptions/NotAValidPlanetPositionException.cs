using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions
{
    public class NotAValidPlanetPositionException : DomainException
    {
        public NotAValidPlanetPositionException(string message) : base(message)
        {
        }
    }
}
