using OgameAnalytics.Domain.Buildings;
using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Buildings.Services;
using OgameAnalytics.Domain.Buildings.ValueObjects;
using OgameAnalytics.Domain.Shared.ValueObject;
namespace OgameAnalytics.Domain.Tests.Buildings.Services;
public class BuildingCostServicesTest
{

    BuildingCostService service = new BuildingCostService();

    [Theory]
    [InlineData(HumanBuilding.ResidentialSector, 0, 7, 2, 0, 0, 0)]
    [InlineData(HumanBuilding.ResidentialSector, 1, 16, 4, 0, 0, 0)]
    [InlineData(HumanBuilding.ResidentialSector, 2, 30, 8, 0, 0, 0)]
    [InlineData(HumanBuilding.ResidentialSector, 7, 200, 57, 0, 0, 0)]


    [InlineData(HumanBuilding.BiosphereFarm, 0, 5, 2, 0, 8, 0)]
    [InlineData(HumanBuilding.BiosphereFarm, 1, 12, 4, 0, 16, 0)]
    [InlineData(HumanBuilding.BiosphereFarm, 2, 22, 9, 0, 25, 0)]
    [InlineData(HumanBuilding.BiosphereFarm, 8, 235, 94, 0, 86, 0)]

    [InlineData(HumanBuilding.ResearchCentre, 0, 20_000, 25_000, 10_000, 10, 0)]

    [InlineData(HumanBuilding.AcademyOfSciences, 0, 5_000, 3_200, 1_500, 15, 20_000_000)]

    [InlineData(HumanBuilding.NeuroCablibrationCentre, 0, 50_000, 40_000, 50_000, 30, 100_000_000)]

    [InlineData(HumanBuilding.HighEnergySmelting, 0, 9_000, 6_000, 3_000, 40, 0)]

    [InlineData(HumanBuilding.FoodSilo, 0, 25_000, 13_000, 7_000, 0, 0)]

    [InlineData(HumanBuilding.FusionPoweredProduction, 0, 50_000, 25_000, 15_000, 80, 0)]

    [InlineData(HumanBuilding.Skycraper, 0, 75_000, 20_000, 25_000, 50, 0)]

    [InlineData(HumanBuilding.BiotechLab, 0, 150_000, 30_000, 15_000, 60, 0)]

    [InlineData(HumanBuilding.Metropolis, 0, 80_000, 35_000, 60_000, 90, 0)]

    [InlineData(HumanBuilding.PlanetaryShield, 0, 250_000, 125_000, 125_000, 100, 0)]
    void Calculate_ForHumanBuildings_WithGivenValues_ShouldPass(
        HumanBuilding buildingId,
        int testedLevel,
        ulong expectedMetalValue,
        ulong expectedCrystalValue,
        ulong expectedDeuteriumValue,
        ulong expectedEnergyValue,
        ulong expectedPopulationValue)
    {

        Building testObject = Building.Create(BuildingIdentity.FromBuildingType(buildingId), BuildingLevel.FromPrimitive(testedLevel));

        EconomicUnit result = service.Calculate(testObject);

        Assert.Equal(expectedMetalValue, result.MetalValue);
        Assert.Equal(expectedCrystalValue, result.CrystalValue);
        Assert.Equal(expectedDeuteriumValue, result.DeuteriumValue);
        Assert.Equal(expectedEnergyValue, result.EnergyValue);
        Assert.Equal(expectedPopulationValue, result.PopulationValue);

    }

    [Theory]
    [InlineData(MechaBuildings.AssemblyLine, 72, 399_963_880, 133_321_293, 0, 0, 0)]

    [InlineData(MechaBuildings.FusionCellFactory, 83, 388_558_037, 155_423_214, 0, 3546, 0)]

    [InlineData(MechaBuildings.QuantumComputerCentre, 9, 99_179_645, 79_343_716, 99_179_645, 2476, 306_533_199)]


    void Calculate_ForMechasBuildings_WithGivenValues_ShouldPass(MechaBuildings buildingId,
        int testedLevel,
        ulong expectedMetalValue,
        ulong expectedCrystalValue,
        ulong expectedDeuteriumValue,
        ulong expectedEnergyValue,
        ulong expectedPopulationValue)
    {

        Building testObject = Building.Create(BuildingIdentity.FromBuildingType(buildingId), BuildingLevel.FromPrimitive(testedLevel));
        EconomicUnit result = service.Calculate(testObject);
        Assert.Equal(expectedMetalValue, result.MetalValue);
        Assert.Equal(expectedCrystalValue, result.CrystalValue);
        Assert.Equal(expectedDeuteriumValue, result.DeuteriumValue);
        Assert.Equal(expectedEnergyValue, result.EnergyValue);
        Assert.Equal(expectedPopulationValue, result.PopulationValue);
    }

    //[Theory]
    //[InlineData(KaeleshBuildings)]
    //public void Calculate_ForKaeleshBuildings_WithGivenValues_ShouldPass(KaeleshBuildings buildingId,
    //int testedLevel,
    //ulong expectedMetalValue,
    //ulong expectedCrystalValue,
    //ulong expectedDeuteriumValue,
    //ulong expectedEnergyValue,
    //ulong expectedPopulationValue)
    //{

    //    Building testObject = Building.Create(BuildingIdentity.FromBuildingType(buildingId), BuildingLevel.FromPrimitive(testedLevel));
    //    EconomicUnit result = service.Calculate(testObject);
    //    Assert.Equal(expectedMetalValue, result.MetalValue);
    //    Assert.Equal(expectedCrystalValue, result.CrystalValue);
    //    Assert.Equal(expectedDeuteriumValue, result.DeuteriumValue);
    //    Assert.Equal(expectedEnergyValue, result.EnergyValue);
    //    Assert.Equal(expectedPopulationValue, result.PopulationValue);
    //}


    [Theory]
    [InlineData(ResourceBuilding.MetalMine,0,60,15,0,11)]
    [InlineData(ResourceBuilding.MetalMine,1,90,22,0,24)]
    [InlineData(ResourceBuilding.MetalMine,2,135,33,0,39)]
    [InlineData(ResourceBuilding.MetalMine,3,202,50,0,58)]
    [InlineData(ResourceBuilding.MetalMine,4,303,75,0,80)]
    [InlineData(ResourceBuilding.MetalMine,5,455,113,0,106)]
    [InlineData(ResourceBuilding.MetalMine, 10, 3459, 864, 0, 313)]

    [InlineData(ResourceBuilding.CrystalMine,0,48,24,0,11)]
    [InlineData(ResourceBuilding.CrystalMine,1,76,38,0,24)]
    [InlineData(ResourceBuilding.CrystalMine,2,122,61,0,39)]
    [InlineData(ResourceBuilding.CrystalMine,3,196,98,0,58)]
    [InlineData(ResourceBuilding.CrystalMine,4,314,157,0,80)]
    [InlineData(ResourceBuilding.CrystalMine,5,503,251,0,106)]
    [InlineData(ResourceBuilding.CrystalMine,8,2061,1030,0,212)]

    [InlineData(ResourceBuilding.DeuteriumSynthesiser,0,225,75,0,22)]
    [InlineData(ResourceBuilding.DeuteriumSynthesiser,1,337,112,0,48)]
    [InlineData(ResourceBuilding.DeuteriumSynthesiser, 2, 506, 168, 0, 79)]
    [InlineData(ResourceBuilding.DeuteriumSynthesiser,3,759,253,0,117)]
    [InlineData(ResourceBuilding.DeuteriumSynthesiser,4,1139,379,0,161)]
    [InlineData(ResourceBuilding.DeuteriumSynthesiser,5,1708,569,0,212)]
    

    void Calculate_ForResourceBuildings_WithGivenValues_ShouldPass(ResourceBuilding buildingId,
        int testedLevel,
        ulong expectedMetalValue,
        ulong expectedCrystalValue,
        ulong expectedDeuteriumValue,
        ulong expectedEnergyValue)
    {

        Building testObject = Building.Create(BuildingIdentity.FromBuildingType(buildingId), BuildingLevel.FromPrimitive(testedLevel));
        EconomicUnit result = service.Calculate(testObject);
        Assert.Equal(expectedMetalValue, result.MetalValue);
        Assert.Equal(expectedCrystalValue, result.CrystalValue);
        Assert.Equal(expectedDeuteriumValue, result.DeuteriumValue);
        Assert.Equal(expectedEnergyValue, result.EnergyValue);

    }

}


