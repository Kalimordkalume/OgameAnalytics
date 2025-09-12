using OgameAnalytics.Domain.Buildings.Enums;

namespace OgameAnalytics.Application.UseCases.Buildings.CalculateBuildingUpgradeCost
{
    public record CalculateBuildingUpgradeCostRequest(ResourceBuilding BuildingType, int Level);

}
