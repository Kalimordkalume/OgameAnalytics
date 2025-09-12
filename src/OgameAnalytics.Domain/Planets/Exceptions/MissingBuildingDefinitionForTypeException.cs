using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions
{
    public class MissingBuildingDefinitionForTypeException : DomainException
    {
        public MissingBuildingDefinitionForTypeException(ResourceBuilding type)
            : base($"Missing building definition for type: {type}.")
        {
        }
    }
}



