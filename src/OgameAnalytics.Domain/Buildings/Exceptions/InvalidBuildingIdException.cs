using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class InvalidBuildingIdException : DomainException
    {
        public InvalidBuildingIdException() : base("A building must have a valid identifier.")
        {
        }
    }
}
