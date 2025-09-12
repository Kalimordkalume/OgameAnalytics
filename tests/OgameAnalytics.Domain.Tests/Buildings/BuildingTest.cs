using OgameAnalytics.Domain.Buildings;
using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Buildings.ValueObjects;

namespace OgameAnalytics.Domain.Tests.Buildings;

public class BuildingTest
{
    [Fact]
    public void Create_WithValueObjects_CreatesSuccessfully()
    {
        // Arrange
        var identity = BuildingIdentity.FromBuildingType(ResourceBuilding.MetalMine);
        var level = BuildingLevel.FromPrimitive(3);

        // Act
        var building = Building.Create(identity, level);

        // Assert
        Assert.NotNull(building);
        Assert.Equal(identity, building.Identity);
        Assert.Equal(level, building.Level);
    }

    [Fact]
    public void Create_WithEnumAndLevel_CreatesSuccessfully()
    {
        // Arrange
        var level = BuildingLevel.FromPrimitive(1);

        // Act
        var building = Building.Create(ResourceBuilding.CrystalMine, level);

        // Assert
        Assert.Equal(level, building.Level);
        Assert.Equal(ResourceBuilding.CrystalMine, building.Identity.Type);
        Assert.Equal("Crystal Mine", building.Identity.Name.Value);
    }

    [Fact]
    public void Create_WithEnum_DefaultsLevelToZero()
    {
        // Act
        var building = Building.Create(ResourceBuilding.DeuteriumSynthesiser);

        // Assert
        Assert.Equal(0, building.Level.Value);
        Assert.Equal(ResourceBuilding.DeuteriumSynthesiser, building.Identity.Type);
    }

    [Fact]
    public void Upgrade_IncreasesLevelByOne()
    {
        // Arrange
        var building = Building.Create(ResourceBuilding.MetalMine, BuildingLevel.FromPrimitive(5));

        // Act
        building.Upgrade();

        // Assert
        Assert.Equal(6, building.Level.Value);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(0, 3)]
    [InlineData(10, 4)]
    public void UpgradeBy_IncreasesLevel_ByQuantity(int initialLevel, int increaseBy)
    {
        // Arrange
        var building = Building.Create(ResourceBuilding.SolarPlant, BuildingLevel.FromPrimitive(initialLevel));

        // Act
        building.UpgradeBy(increaseBy);

        // Assert
        Assert.Equal(initialLevel + increaseBy, building.Level.Value);
    }

    [Fact]
    public void Downgrade_DecreasesLevelByOne()
    {
        // Arrange
        var building = Building.Create(ResourceBuilding.FusionReactor, BuildingLevel.FromPrimitive(2));

        // Act
        building.Downgrade();

        // Assert
        Assert.Equal(1, building.Level.Value);
    }

    [Theory]
    [InlineData(10, 3, 7)]
    [InlineData(5, 5, 0)]
    public void DowngradeBy_DecreasesLevel_ByQuantity(int initialLevel, int decreaseBy, int expected)
    {
        // Arrange
        var building = Building.Create(ResourceBuilding.MetalStorage, BuildingLevel.FromPrimitive(initialLevel));

        // Act
        building.DowngradeBy(decreaseBy);

        // Assert
        Assert.Equal(expected, building.Level.Value);
    }
}


