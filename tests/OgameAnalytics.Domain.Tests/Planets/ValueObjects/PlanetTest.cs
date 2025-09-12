using OgameAnalytics.Domain.Buildings;
using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Planets;
using OgameAnalytics.Domain.Planets.ValueObjects;

namespace OgameAnalytics.Domain.Tests.Planets.ValueObjects;
public class PlanetTest
{


    [Fact]
    public void CreateEmpty_ReturnsExpectedValues_ForHumans()

    {
        PlanetId validId = PlanetId.Generate();
        PlanetName validName = PlanetName.Create("Gaia");
        PlanetCoordinate validCoordinates = PlanetCoordinate.From(1, 300, 8);
        PlanetTemperature validTemperature = PlanetTemperature.FromPrimitives(30, 60);
        PlanetLifeForm validLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Humans);

        Planet createdPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, validLifeForm);

        Assert.NotNull(createdPlanet);
        Assert.Equal(validId.Value, createdPlanet.Id.Value);
        Assert.Equal(validName.Value, createdPlanet.Name.Value);
        Assert.Equal(validCoordinates.GalaxyValue, createdPlanet.Coordinates.GalaxyValue);
        Assert.Equal(validCoordinates.SolarSystemValue, createdPlanet.Coordinates.SolarSystemValue);
        Assert.Equal(validCoordinates.PlanetPositionValue, createdPlanet.Coordinates.PlanetPositionValue);
        Assert.Equal(validTemperature.MaxValue, createdPlanet.Temperature.MaxValue);
        Assert.Equal(validTemperature.MinValue, createdPlanet.Temperature.MinValue);
        Assert.Equal(validLifeForm.Value, createdPlanet.LifeForm.Value);


        foreach (Building building in createdPlanet.Buildings)
        {
            Assert.Equal(0, building.Level.Value);

        }

        int expectedCountOfBuildings = Enum.GetValues<ResourceBuilding>().Length;
        expectedCountOfBuildings += Enum.GetValues<FacilitiesBuilding>().Length;
        expectedCountOfBuildings += Enum.GetValues<HumanBuilding>().Length;

        Assert.Equal(expectedCountOfBuildings, createdPlanet.Buildings.Count);
    }

    [Fact]
    public void CreateEmpty_ReturnsExpectedValues_ForRocktal()
    {
        PlanetId validId = PlanetId.Generate();
        PlanetName validName = PlanetName.Create("Gaia");
        PlanetCoordinate validCoordinates = PlanetCoordinate.From(1, 300, 8);
        PlanetTemperature validTemperature = PlanetTemperature.FromPrimitives(30, 60);
        PlanetLifeForm validLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Rocktal);

        Planet createdPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, validLifeForm);

        Assert.NotNull(createdPlanet);
        Assert.Equal(validId.Value, createdPlanet.Id.Value);
        Assert.Equal(validName.Value, createdPlanet.Name.Value);
        Assert.Equal(validCoordinates.GalaxyValue, createdPlanet.Coordinates.GalaxyValue);
        Assert.Equal(validCoordinates.SolarSystemValue, createdPlanet.Coordinates.SolarSystemValue);
        Assert.Equal(validCoordinates.PlanetPositionValue, createdPlanet.Coordinates.PlanetPositionValue);
        Assert.Equal(validTemperature.MaxValue, createdPlanet.Temperature.MaxValue);
        Assert.Equal(validTemperature.MinValue, createdPlanet.Temperature.MinValue);
        Assert.Equal(validLifeForm.Value, createdPlanet.LifeForm.Value);


        foreach (Building building in createdPlanet.Buildings)
        {
            Assert.Equal(0, building.Level.Value);

        }

        int expectedCountOfBuildings = Enum.GetValues<ResourceBuilding>().Length;
        expectedCountOfBuildings += Enum.GetValues<FacilitiesBuilding>().Length;
        expectedCountOfBuildings += Enum.GetValues<RocktalBuilding>().Length;

        Assert.Equal(expectedCountOfBuildings, createdPlanet.Buildings.Count);
    }

    [Fact]
    public void CreateEmpty_ReturnsExpectedValues_ForKaelesh()

    {
        PlanetId validId = PlanetId.Generate();
        PlanetName validName = PlanetName.Create("Gaia");
        PlanetCoordinate validCoordinates = PlanetCoordinate.From(1, 300, 8);
        PlanetTemperature validTemperature = PlanetTemperature.FromPrimitives(30, 60);
        PlanetLifeForm validLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Kaelesh);

        Planet createdPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, validLifeForm);

        Assert.NotNull(createdPlanet);
        Assert.Equal(validId.Value, createdPlanet.Id.Value);
        Assert.Equal(validName.Value, createdPlanet.Name.Value);
        Assert.Equal(validCoordinates.GalaxyValue, createdPlanet.Coordinates.GalaxyValue);
        Assert.Equal(validCoordinates.SolarSystemValue, createdPlanet.Coordinates.SolarSystemValue);
        Assert.Equal(validCoordinates.PlanetPositionValue, createdPlanet.Coordinates.PlanetPositionValue);
        Assert.Equal(validTemperature.MaxValue, createdPlanet.Temperature.MaxValue);
        Assert.Equal(validTemperature.MinValue, createdPlanet.Temperature.MinValue);
        Assert.Equal(validLifeForm.Value, createdPlanet.LifeForm.Value);


        foreach (Building building in createdPlanet.Buildings)
        {
            Assert.Equal(0, building.Level.Value);

        }

        int expectedCountOfBuildings = Enum.GetValues<ResourceBuilding>().Length;
        expectedCountOfBuildings += Enum.GetValues<FacilitiesBuilding>().Length;
        expectedCountOfBuildings += Enum.GetValues<KaeleshBuildings>().Length;

        Assert.Equal(expectedCountOfBuildings, createdPlanet.Buildings.Count);
    }

    [Fact]
    public void CreateEmpty_ReturnsExpectedValues_ForMechas()
    {
        PlanetId validId = PlanetId.Generate();
        PlanetName validName = PlanetName.Create("Gaia");
        PlanetCoordinate validCoordinates = PlanetCoordinate.From(1, 300, 8);
        PlanetTemperature validTemperature = PlanetTemperature.FromPrimitives(30, 60);
        PlanetLifeForm validLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Mechas);

        Planet createdPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, validLifeForm);

        Assert.NotNull(createdPlanet);
        Assert.Equal(validId.Value, createdPlanet.Id.Value);
        Assert.Equal(validName.Value, createdPlanet.Name.Value);
        Assert.Equal(validCoordinates.GalaxyValue, createdPlanet.Coordinates.GalaxyValue);
        Assert.Equal(validCoordinates.SolarSystemValue, createdPlanet.Coordinates.SolarSystemValue);
        Assert.Equal(validCoordinates.PlanetPositionValue, createdPlanet.Coordinates.PlanetPositionValue);
        Assert.Equal(validTemperature.MaxValue, createdPlanet.Temperature.MaxValue);
        Assert.Equal(validTemperature.MinValue, createdPlanet.Temperature.MinValue);
        Assert.Equal(validLifeForm.Value, createdPlanet.LifeForm.Value);


        foreach (Building building in createdPlanet.Buildings)
        {
            Assert.Equal(0, building.Level.Value);

        }

        int expectedCountOfBuildings = Enum.GetValues<ResourceBuilding>().Length;
        expectedCountOfBuildings += Enum.GetValues<FacilitiesBuilding>().Length;
        expectedCountOfBuildings += Enum.GetValues<MechaBuildings>().Length;

        Assert.Equal(expectedCountOfBuildings, createdPlanet.Buildings.Count);
    }


    [Fact]
    public void Upgrade_HumansPlanet_WithBuilding_ShouldPass()
    {
        // Arrange
        PlanetId validId = PlanetId.Generate();
        PlanetName validName = PlanetName.Create("Gaia");
        PlanetCoordinate validCoordinates = PlanetCoordinate.From(1, 300, 8);
        PlanetTemperature validTemperature = PlanetTemperature.FromPrimitives(30, 60);

        // Test Humans planet
        PlanetLifeForm humanLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Humans);
        Planet humanPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, humanLifeForm);

        // Act
        humanPlanet.Upgrade(FacilitiesBuilding.RoboticsFactory);
        humanPlanet.Upgrade(ResourceBuilding.MetalMine);
        humanPlanet.Upgrade(HumanBuilding.BiosphereFarm);

        // Assert
        Assert.Equal(1, humanPlanet.GetBuilding(ResourceBuilding.MetalMine).Level.Value);
        Assert.Equal(1, humanPlanet.GetBuilding(ResourceBuilding.MetalMine).Level.Value);
        Assert.Equal(1, humanPlanet.GetBuilding(HumanBuilding.BiosphereFarm).Level.Value);

        // Test Rocktal planet
        PlanetLifeForm rocktalLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Rocktal);
        Planet rocktalPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, rocktalLifeForm);

        // Act
        rocktalPlanet.Upgrade(RocktalBuilding.AdvancedRecyclingPlant);

        // Assert
        Assert.Equal(1, rocktalPlanet.GetBuilding(RocktalBuilding.AdvancedRecyclingPlant).Level.Value);

        // Test Kaelesh planet
        PlanetLifeForm kaeleshLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Kaelesh);
        Planet kaeleshPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, kaeleshLifeForm);

        // Act
        kaeleshPlanet.Upgrade(KaeleshBuildings.ChrysalisAccelerator);

        // Assert
        Assert.Equal(1, kaeleshPlanet.GetBuilding(KaeleshBuildings.ChrysalisAccelerator).Level.Value);

        // Test Mechas planet
        PlanetLifeForm mechasLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Mechas);
        Planet mechasPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, mechasLifeForm);

        // Act
        mechasPlanet.Upgrade(MechaBuildings.UpdateNetwork);

        // Assert
        Assert.Equal(1, mechasPlanet.GetBuilding(MechaBuildings.UpdateNetwork).Level.Value);
    }

    [Fact]
    public void UpgradeBy_HumansPlanet_WithBuilding_ShouldPass()
    {
        // Arrange
        PlanetId validId = PlanetId.Generate();
        PlanetName validName = PlanetName.Create("Gaia");
        PlanetCoordinate validCoordinates = PlanetCoordinate.From(1, 300, 8);
        PlanetTemperature validTemperature = PlanetTemperature.FromPrimitives(30, 60);
        PlanetLifeForm humanLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Humans);
        Planet humanPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, humanLifeForm);

        // Act
        humanPlanet.UpgradeBy(FacilitiesBuilding.RoboticsFactory, 3);
        humanPlanet.UpgradeBy(ResourceBuilding.MetalMine, 5);
        humanPlanet.UpgradeBy(HumanBuilding.BiosphereFarm, 2);

        // Assert
        Assert.Equal(3, humanPlanet.GetBuilding(FacilitiesBuilding.RoboticsFactory).Level.Value);
        Assert.Equal(5, humanPlanet.GetBuilding(ResourceBuilding.MetalMine).Level.Value);
        Assert.Equal(2, humanPlanet.GetBuilding(HumanBuilding.BiosphereFarm).Level.Value);
    }

    [Fact]
    public void UpgradeBy_RocktalPlanet_WithBuilding_ShouldPass()
    {
        // Arrange
        PlanetId validId = PlanetId.Generate();
        PlanetName validName = PlanetName.Create("Gaia");
        PlanetCoordinate validCoordinates = PlanetCoordinate.From(1, 300, 8);
        PlanetTemperature validTemperature = PlanetTemperature.FromPrimitives(30, 60);
        PlanetLifeForm rocktalLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Rocktal);
        Planet rocktalPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, rocktalLifeForm);

        // Act
        rocktalPlanet.UpgradeBy(RocktalBuilding.AdvancedRecyclingPlant, 4);
        rocktalPlanet.UpgradeBy(RocktalBuilding.MeditationEnclave, 1);

        // Assert
        Assert.Equal(4, rocktalPlanet.GetBuilding(RocktalBuilding.AdvancedRecyclingPlant).Level.Value);
        Assert.Equal(1, rocktalPlanet.GetBuilding(RocktalBuilding.MeditationEnclave).Level.Value);
    }

    [Fact]
    public void Downgrade_HumansPlanet_WithBuilding_ShouldPass()
    {
        // Arrange
        PlanetId validId = PlanetId.Generate();
        PlanetName validName = PlanetName.Create("Gaia");
        PlanetCoordinate validCoordinates = PlanetCoordinate.From(1, 300, 8);
        PlanetTemperature validTemperature = PlanetTemperature.FromPrimitives(30, 60);
        PlanetLifeForm humanLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Humans);
        Planet humanPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, humanLifeForm);

        // Setup: Upgrade buildings first
        humanPlanet.UpgradeBy(FacilitiesBuilding.RoboticsFactory, 3);
        humanPlanet.UpgradeBy(ResourceBuilding.MetalMine, 2);

        // Act
        humanPlanet.Downgrade(FacilitiesBuilding.RoboticsFactory);
        humanPlanet.Downgrade(ResourceBuilding.MetalMine);

        // Assert
        Assert.Equal(2, humanPlanet.GetBuilding(FacilitiesBuilding.RoboticsFactory).Level.Value);
        Assert.Equal(1, humanPlanet.GetBuilding(ResourceBuilding.MetalMine).Level.Value);
    }

    [Fact]
    public void DowngradeBy_HumansPlanet_WithBuilding_ShouldPass()
    {
        // Arrange
        PlanetId validId = PlanetId.Generate();
        PlanetName validName = PlanetName.Create("Gaia");
        PlanetCoordinate validCoordinates = PlanetCoordinate.From(1, 300, 8);
        PlanetTemperature validTemperature = PlanetTemperature.FromPrimitives(30, 60);
        PlanetLifeForm humanLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Humans);
        Planet humanPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, humanLifeForm);

        // Setup: Upgrade buildings first
        humanPlanet.UpgradeBy(FacilitiesBuilding.RoboticsFactory, 5);
        humanPlanet.UpgradeBy(ResourceBuilding.MetalMine, 4);

        // Act
        humanPlanet.DowngradeBy(FacilitiesBuilding.RoboticsFactory, 2);
        humanPlanet.DowngradeBy(ResourceBuilding.MetalMine, 3);

        // Assert
        Assert.Equal(3, humanPlanet.GetBuilding(FacilitiesBuilding.RoboticsFactory).Level.Value);
        Assert.Equal(1, humanPlanet.GetBuilding(ResourceBuilding.MetalMine).Level.Value);
    }

    [Fact]
    public void DowngradeBy_KaeleshPlanet_WithBuilding_ShouldPass()
    {
        // Arrange
        PlanetId validId = PlanetId.Generate();
        PlanetName validName = PlanetName.Create("Gaia");
        PlanetCoordinate validCoordinates = PlanetCoordinate.From(1, 300, 8);
        PlanetTemperature validTemperature = PlanetTemperature.FromPrimitives(30, 60);
        PlanetLifeForm kaeleshLifeForm = PlanetLifeForm.From(Domain.Planets.Enums.LifeFormType.Kaelesh);
        Planet kaeleshPlanet = Planet.CreateEmpty(validId, validName, validCoordinates, validTemperature, kaeleshLifeForm);

        // Setup: Upgrade buildings first
        kaeleshPlanet.UpgradeBy(KaeleshBuildings.ChrysalisAccelerator, 6);
        kaeleshPlanet.UpgradeBy(KaeleshBuildings.Sanctuary, 3);

        // Act
        kaeleshPlanet.DowngradeBy(KaeleshBuildings.ChrysalisAccelerator, 2);
        kaeleshPlanet.DowngradeBy(KaeleshBuildings.Sanctuary, 1);

        // Assert
        Assert.Equal(4, kaeleshPlanet.GetBuilding(KaeleshBuildings.ChrysalisAccelerator).Level.Value);
        Assert.Equal(2, kaeleshPlanet.GetBuilding(KaeleshBuildings.Sanctuary).Level.Value);
    }


}
