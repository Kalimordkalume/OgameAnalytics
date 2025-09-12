using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Buildings.ValueObjects;
using OgameAnalytics.Domain.Shared.ValueObject;

namespace OgameAnalytics.Domain.Buildings.Services
{
    public class BuildingConstructionTimeService
    {
        private readonly BuildingCostService _costService = new();

        public TimeUnit Calculate(Building building, Building roboticsFactory, Building naniteFactory, int universeSpeed)
        {
            if (IsLegacyBuilding(building.Identity.Type))
                return CalculateForLegacyBuildings(building, roboticsFactory, naniteFactory, universeSpeed);
            return CalculateForModernBuildings(building, roboticsFactory, naniteFactory);


        }

        private TimeUnit CalculateForModernBuildings(Building building, Building roboticsFactory, Building naniteFactory) => throw new NotImplementedException();

        private TimeUnit CalculateForLegacyBuildings(Building legacyBuilding, Building roboticsFactory, Building naniteFactory, int universeSpeed)
        {
            

            BuildingLevel roboticsLevel = roboticsFactory.Level;
            BuildingLevel naniteLevel = naniteFactory.Level;

            var calculatedCosts = _costService.Calculate(legacyBuilding);

            ulong metalValue = calculatedCosts.MetalValue;
            ulong crystalValue = calculatedCosts.CrystalValue;

            var numerator = metalValue + crystalValue;
            var denominator = universeSpeed * 2500 * (1 + roboticsFactory.Level.Value) * Math.Pow(2, naniteFactory.Level.Value);

            Console.WriteLine(numerator);
            Console.WriteLine(denominator);
            return TimeUnit.FromHours(numerator / denominator);


        }
        private bool IsLegacyBuilding(Enum buildingType)
        {
            return buildingType is ResourceBuilding || buildingType is FacilitiesBuilding;
        }
    }
}
