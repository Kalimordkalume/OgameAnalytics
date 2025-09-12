using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Buildings.Exceptions;
using OgameAnalytics.Domain.Buildings.ValueObjects;
using OgameAnalytics.Domain.Shared.ValueObject;

namespace OgameAnalytics.Domain.Buildings.Services
{
    public class BuildingProductionService()
    {
        public EconomicUnit CalculateProductionOf(Building building)
        {
            if (building.Identity.Type is ResourceBuilding.MetalMine)
                return EconomicUnit.CreateNewMineralUnit(GetMetalProduction(building.Level), 0, 0);

            if (building.Identity.Type is ResourceBuilding.CrystalMine)
                return EconomicUnit.CreateNewMineralUnit(0, GetCrystalProduction(building.Level), 0);

            if (building.Identity.Type is ResourceBuilding.DeuteriumSynthesiser)
                return EconomicUnit.CreateNewMineralUnit(0, 0, GetDeuteriumProduction(building.Level));

            if (building.Identity.Type is ResourceBuilding.SolarPlant)
                return EconomicUnit.CreateNewEnergyUnit(GetEnergyProductionFromSolarPlant(building.Level));

            if (building.Identity.Type is ResourceBuilding.FusionReactor)
                return EconomicUnit.CreateNewEnergyUnit(GetEnergyProductionFromFusionPlant(building.Level));

            throw new UnknownBuildingTypeException(building.Identity.Type);

        }

        private static ulong GetEnergyProductionFromFusionPlant(BuildingLevel buildingLevel)
        {
            return (ulong)(30 * buildingLevel.Value);
        }

        private static ulong GetEnergyProductionFromSolarPlant(BuildingLevel buildingLevel)
        {
            return (ulong)(20 * buildingLevel.Value * Math.Pow(1.1, buildingLevel.Value));
        }

        private static ulong GetDeuteriumProduction(BuildingLevel buildingLevel)
        {
            return (ulong)(10 * buildingLevel.Value * Math.Pow(1.1, buildingLevel.Value));
        }

        private static ulong GetCrystalProduction(BuildingLevel buildingLevel)
        {
            return (ulong)(20 * buildingLevel.Value * Math.Pow(1.1, buildingLevel.Value));
        }

        private static ulong GetMetalProduction(BuildingLevel buildingLevel)
        {
            return (ulong)(30 * buildingLevel.Value * Math.Pow(1.1, buildingLevel.Value));

        }

    }
}
