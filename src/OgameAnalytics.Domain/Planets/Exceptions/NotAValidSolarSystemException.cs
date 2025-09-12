using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions
{
    public class NotAValidSolarSystemException : DomainException
    {
        public NotAValidSolarSystemException(string message) : base(message)
        {
        }
    }
}
