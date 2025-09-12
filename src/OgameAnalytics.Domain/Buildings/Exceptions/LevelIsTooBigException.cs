using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class LevelIsTooBigException : DomainException
    {
        public LevelIsTooBigException(string message) : base(message)
        {
        }
    }
}
