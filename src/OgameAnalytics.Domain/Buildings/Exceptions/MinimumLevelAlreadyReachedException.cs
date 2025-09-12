using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class MinimumLevelAlreadyReachedException : DomainException
    {
        public MinimumLevelAlreadyReachedException() : base("Minimum level has been reached. Operation canceled.")
        {
        }
    }
}
