using OgameAnalytics.Domain.Buildings;
using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Buildings.Services;
using OgameAnalytics.Domain.Buildings.ValueObjects;
using OgameAnalytics.Domain.Tests.Buildings.TestData;

namespace OgameAnalytics.Domain.Tests.Buildings.Services;
public class BuildingProductionServiceTest
{
    BuildingProductionService _service = new BuildingProductionService();
    Dictionary<int, ulong> _metalValuesForTesting = BasicMinesProduction.ProductionValuesForMetalMine;
    Dictionary<int, ulong> _crystalValuesForTesting = BasicMinesProduction.ProductionValuesForCrystalMine;
    Dictionary<int, ulong> _deuteriumValuesForTesting = BasicMinesProduction.ProductionValuesForDeuteriumMine;
    Dictionary<int, ulong> _solarPlantValuesForTesting = BasicMinesProduction.ProductionValuesForSolarPlant;
    Dictionary<int, ulong> _fusionReactorValuesForTesting = BasicMinesProduction.ProductionValuesForFusionReactor;
    public void CalculateProductionOf_MetalMine_WithKnownValues_ShouldPass()
    {
        BuildingIdentity mockedIdentity = BuildingIdentity.FromBuildingType(ResourceBuilding.MetalMine);
        foreach (KeyValuePair<int, ulong> item in _metalValuesForTesting)
        {
            BuildingLevel mockedLevel = BuildingLevel.FromPrimitive(item.Key);
            Building testBuilding = Building.Create(mockedIdentity, mockedLevel);
            var computedValue = _service.CalculateProductionOf(testBuilding);

            Assert.Equal(item.Value, computedValue.MetalValue);

        }
    }

    public void CalculateProductionOf_CrystalMine_WithKnownValues_ShouldPass()
    {
        BuildingIdentity mockedIdentity = BuildingIdentity.FromBuildingType(ResourceBuilding.CrystalMine);
        foreach (KeyValuePair<int, ulong> item in _crystalValuesForTesting)
        {
            BuildingLevel mockedLevel = BuildingLevel.FromPrimitive(item.Key);
            Building testBuilding = Building.Create(mockedIdentity, mockedLevel);
            var computedValue = _service.CalculateProductionOf(testBuilding);

            Assert.Equal(item.Value, computedValue.CrystalValue);

        }
    }

    public void CalculateProductionOf_DeuteriumMine_WithKnownValues_ShouldPass()
    {
        BuildingIdentity mockedIdentity = BuildingIdentity.FromBuildingType(ResourceBuilding.DeuteriumSynthesiser);
        foreach (KeyValuePair<int, ulong> item in _deuteriumValuesForTesting)
        {
            BuildingLevel mockedLevel = BuildingLevel.FromPrimitive(item.Key);
            Building testBuilding = Building.Create(mockedIdentity, mockedLevel);
            var computedValue = _service.CalculateProductionOf(testBuilding);

            Assert.Equal(item.Value, computedValue.DeuteriumValue);

        }
    }
    public void CalculateProductionOf_SolarPlant_WithKnownValues_ShouldPass()
    {
        BuildingIdentity mockedIdentity = BuildingIdentity.FromBuildingType(ResourceBuilding.SolarPlant);
        foreach (KeyValuePair<int, ulong> item in _solarPlantValuesForTesting)
        {
            BuildingLevel mockedLevel = BuildingLevel.FromPrimitive(item.Key);
            Building testBuilding = Building.Create(mockedIdentity, mockedLevel);
            var computedValue = _service.CalculateProductionOf(testBuilding);

            Assert.Equal(item.Value, computedValue.EnergyValue);

        }
    }

    public void CalculateProductionOf_FusionReactor_WithKnownValues_ShouldPass()
    {
        BuildingIdentity mockedIdentity = BuildingIdentity.FromBuildingType(ResourceBuilding.FusionReactor);
        foreach (KeyValuePair<int, ulong> item in _fusionReactorValuesForTesting)
        {
            BuildingLevel mockedLevel = BuildingLevel.FromPrimitive(item.Key);
            Building testBuilding = Building.Create(mockedIdentity, mockedLevel);
            var computedValue = _service.CalculateProductionOf(testBuilding);

            Assert.Equal(item.Value, computedValue.EnergyValue);

        }
    }
}
