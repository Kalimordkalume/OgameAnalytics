using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class BuildingNameIsEmptyException : DomainException
    {
        public BuildingNameIsEmptyException() : base("The name cannot be empty. Try again.")
        {
        }
    }
}
