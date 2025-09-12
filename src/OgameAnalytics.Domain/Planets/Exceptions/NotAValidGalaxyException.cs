using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions
{
    public class NotAValidGalaxyException : DomainException
    {
        public NotAValidGalaxyException(string message) : base(message)
        {
        }
    }
}
