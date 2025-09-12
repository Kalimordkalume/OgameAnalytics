using System.Numerics;
using OgameAnalytics.Domain.Buildings.Data;
using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Buildings.Exceptions;
using OgameAnalytics.Domain.Buildings.ValueObjects;
using OgameAnalytics.Domain.Shared.ValueObject;


namespace OgameAnalytics.Domain.Buildings.Services
{
    public class BuildingCostService
    {

        private BuildingsBasicCost buildingsCostHolder = new BuildingsBasicCost();

        private BuildingsGrowthFactors growthFactorsHolder = new BuildingsGrowthFactors();


        public EconomicUnit Calculate(Building building)
        {
            EconomicUnit basicCost = FindBasicCostFor(building);

            GrowthFactors growthFactor = FindGrowthFactorFor(building);

            BuildingLevel currentLevel = building.Level;



            if (IsLegacyBuilding(building.Identity.Type))
            {
                return CalculateForLegacyBuildings(basicCost, growthFactor, currentLevel);
            }

            return CalculateForModernBuildings(basicCost, growthFactor, currentLevel);

        }
        private EconomicUnit CalculateForModernBuildings(EconomicUnit basicCost, GrowthFactors growthFactor, BuildingLevel currentLevel)
        {
            currentLevel = BuildingLevel.FromPrimitive(currentLevel.Value + 1);

            ulong metalCost = (ulong)Math.Floor(basicCost.MetalValue * Math.Pow(growthFactor.MetalFactor, currentLevel.Value - 1) * currentLevel.Value);
            ulong crystalCost = (ulong)Math.Floor(basicCost.CrystalValue * Math.Pow(growthFactor.CrystalFactor, currentLevel.Value - 1) * currentLevel.Value);
            ulong deuteriumCost = (ulong)Math.Floor(basicCost.DeuteriumValue * Math.Pow(growthFactor.DeuteriumFactor, currentLevel.Value - 1) * currentLevel.Value);
            ulong energyCost = CalculateEnergy(basicCost, growthFactor, currentLevel);
            ulong populationCost = (ulong)Math.Floor(basicCost.PopulationValue * Math.Pow(growthFactor.PopulationFactor, currentLevel.Value - 1));
            ulong foodCost = (ulong)Math.Floor(basicCost.FoodValue * Math.Pow(growthFactor.FoodFactor, currentLevel.Value));

            return EconomicUnit.FromPrimitives(metalCost, crystalCost, deuteriumCost, energyCost, populationCost, foodCost);
        }
        private static ulong CalculateEnergy(EconomicUnit basicCost, GrowthFactors growthFactor, BuildingLevel currentLevel)
        {
            ulong basicEnergy = basicCost.EnergyValue;
            double energyFactor = growthFactor.EnergyFactor;

            if (currentLevel.Value == 1)
                return basicEnergy;

            return (ulong)(basicCost.EnergyValue * Math.Pow(growthFactor.EnergyFactor, currentLevel.Value) * currentLevel.Value);
        }

        private bool IsLegacyBuilding(Enum buildingType)
        {
            return buildingType is ResourceBuilding || buildingType is FacilitiesBuilding;
        }


        private EconomicUnit CalculateForLegacyBuildings(EconomicUnit basicCost, GrowthFactors growthFactor, BuildingLevel currentLevel)
        {
            

            ulong metalCost = (ulong)(basicCost.MetalValue * Math.Pow(growthFactor.MetalFactor, currentLevel.Value));

            ulong crystalCost = (ulong)(basicCost.CrystalValue * Math.Pow(growthFactor.CrystalFactor, currentLevel.Value));

            ulong deuteriumCost = (ulong)(basicCost.DeuteriumValue * Math.Pow(growthFactor.DeuteriumFactor, currentLevel.Value));

            ulong energyCost = (ulong)(basicCost.EnergyValue * ((currentLevel.Value+1) * Math.Pow(growthFactor.EnergyFactor, (currentLevel.Value+1))));

            ulong populationCost = (ulong)(basicCost.PopulationValue * Math.Pow(growthFactor.PopulationFactor, currentLevel.Value));

            ulong foodCost = (ulong)(basicCost.FoodValue * Math.Pow(growthFactor.FoodFactor, currentLevel.Value));

            return EconomicUnit.FromPrimitives(metalCost, crystalCost, deuteriumCost, energyCost, populationCost, foodCost);
        }
        private GrowthFactors FindGrowthFactorFor(Building building)
        {
            Enum buildingType = building.Identity.Type;

            if (buildingType is ResourceBuilding resourceBuildingType)
                return growthFactorsHolder.ResourceBuildingsGrowingFactors[resourceBuildingType];

            if (buildingType is FacilitiesBuilding facilitiesBuildingType)
                return growthFactorsHolder.FacilitiesBuildingsGrowingFactors[facilitiesBuildingType];

            if (buildingType is HumanBuilding humanBuildingType)
                return growthFactorsHolder.HumanBuildingsGrowingFactors[humanBuildingType];

            if (buildingType is RocktalBuilding rocktalBuildingType)
                return growthFactorsHolder.RocktalBuildingsGrowingFactors[rocktalBuildingType];

            if (buildingType is KaeleshBuildings kaeleshBuildingType)
                return growthFactorsHolder.KaeleshBuildingsGrowingFactors[kaeleshBuildingType];

            if (buildingType is MechaBuildings mechasBuildingType)
                return growthFactorsHolder.MechaBuildingsGrowingFactors[mechasBuildingType];

            throw new UnknownBuildingTypeException(buildingType);

        }

        private EconomicUnit FindBasicCostFor(Building building)
        {
            Enum buildingType = building.Identity.Type;

            if (buildingType is ResourceBuilding resourceBuildingType)
                return buildingsCostHolder.ResourceBuildingsCost[resourceBuildingType];

            if (buildingType is FacilitiesBuilding facilitiesBuildingType)
                return buildingsCostHolder.FacilitiesBuildingsCost[facilitiesBuildingType];


            if (buildingType is HumanBuilding humanBuildingType)
                return buildingsCostHolder.HumanBuildingsCost[humanBuildingType];

            if (buildingType is RocktalBuilding rocktalBuildingType)
                return buildingsCostHolder.RocktalBuildingsCost[rocktalBuildingType];

            if (buildingType is KaeleshBuildings kaeleshBuildingType)
                return buildingsCostHolder.KaeleshBuildingsCost[kaeleshBuildingType];

            if (buildingType is MechaBuildings mechasBuildingType)
                return buildingsCostHolder.MechaBuildingsCost[mechasBuildingType];

            throw new UnknownBuildingTypeException(buildingType);
        }
    }
}
