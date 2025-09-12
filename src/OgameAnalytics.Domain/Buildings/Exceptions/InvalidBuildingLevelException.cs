using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Buildings.ValueObjects;
using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class InvalidBuildingLevelException : DomainException
    {
        public BuildingLevel AttemptedLevel { get; }
        public ResourceBuilding? BuildingType { get; }

        public InvalidBuildingLevelException(BuildingLevel level, ResourceBuilding? buildingType = null)
            : base(CreateMessage(level, buildingType))
        {
            AttemptedLevel = level;
            BuildingType = buildingType;
        }

        private static string CreateMessage(BuildingLevel level, ResourceBuilding? buildingType)
        {
            var levelValue = level?.Value ?? -1;
            var buildingName = buildingType?.ToString() ?? "building";
            return levelValue switch
            {
                < 0 => $"Cannot create a {buildingName} with negative level {levelValue}. Buildings start at level 0.",
                > 50 => $"Cannot create a {buildingName} at level {levelValue}. Maximum building level is 50.",
                _ => $"Cannot create a {buildingName} at invalid level {levelValue}."
            };
        }
    }
}
