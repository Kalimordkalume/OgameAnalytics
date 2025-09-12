using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    internal class BuildingModificationNotAllowed : DomainException
    {
        public BuildingModificationNotAllowed(string message) : base(message)
        {
        }
    }
}
