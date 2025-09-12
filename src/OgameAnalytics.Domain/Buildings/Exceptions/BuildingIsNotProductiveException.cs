using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class BuildingIsNotProductiveException : DomainException
    {
        public ResourceBuilding? BuildingType { get; }

        public BuildingIsNotProductiveException(ResourceBuilding? buildingType = null)
            : base(CreateMessage(buildingType))
        {
            BuildingType = buildingType;
        }

        private static string CreateMessage(ResourceBuilding? buildingType)
        {
            var buildingName = buildingType?.ToString() ?? "building";
            return $"The {buildingName} is not a productive building and cannot generate resources.";
        }
    }
}
