using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class InvalidProductionTimeCompositionException : DomainException
    {

        public InvalidProductionTimeCompositionException(string message) : base(message)
        {
        }
    }
}
