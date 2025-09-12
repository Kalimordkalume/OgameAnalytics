using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class MaximumLevelAlreadyReachedException : DomainException
    {
        public MaximumLevelAlreadyReachedException() : base("The maximum level has already been reached. Operation canceled.")
        {
        }
    }
}