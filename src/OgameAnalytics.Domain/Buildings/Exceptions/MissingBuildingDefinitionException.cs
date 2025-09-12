using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class MissingBuildingDefinitionException : DomainException
    {
        public MissingBuildingDefinitionException() : base("Cannot create a building without specifications.")
        {
        }
    }
}
