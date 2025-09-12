using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Buildings.Exceptions;
using OgameAnalytics.Domain.Buildings.ValueObjects;

namespace OgameAnalytics.Domain.Tests.Buildings.ValueObjects;

public class BuildingIdentityTest
{
    // Resource Building Tests
    [Fact]
    public void FromBuildingType_WithResourceBuilding_CreatesSuccessfully()
    {
        // Arrange
        var resourceBuilding = ResourceBuilding.MetalMine;

        // Act
        var buildingIdentity = BuildingIdentity.FromBuildingType(resourceBuilding);

        // Assert
        Assert.NotNull(buildingIdentity);
        Assert.Equal(resourceBuilding, buildingIdentity.Type);
        Assert.Equal("Metal Mine", buildingIdentity.Name.Value);
    }

    [Theory]
    [InlineData(ResourceBuilding.MetalMine, "Metal Mine")]
    [InlineData(ResourceBuilding.CrystalMine, "Crystal Mine")]
    [InlineData(ResourceBuilding.DeuteriumSynthesiser, "Deuterium Synthesiser")]
    [InlineData(ResourceBuilding.SolarPlant, "Solar Plant")]
    [InlineData(ResourceBuilding.FusionReactor, "Fusion Reactor")]
    [InlineData(ResourceBuilding.MetalStorage, "Metal Storage")]
    [InlineData(ResourceBuilding.CrystalStorage, "Crystal Storage")]
    [InlineData(ResourceBuilding.DeuteriumTank, "Deuterium Tank")]
    public void FromBuildingType_WithAllResourceBuildings_CreatesWithCorrectDisplayNames(ResourceBuilding building, string expectedDisplayName)
    {
        // Act
        var buildingIdentity = BuildingIdentity.FromBuildingType(building);

        // Assert
        Assert.Equal(expectedDisplayName, buildingIdentity.Name.Value);
        Assert.Equal(building, buildingIdentity.Type);
    }

    // Facilities Building Tests
    [Theory]
    [InlineData(FacilitiesBuilding.RoboticsFactory, "Robotics Factory")]
    [InlineData(FacilitiesBuilding.Shipyard, "Shipyard")]
    [InlineData(FacilitiesBuilding.ResearchLab, "Research Lab")]
    [InlineData(FacilitiesBuilding.AllianceDepot, "Alliance Depot")]
    [InlineData(FacilitiesBuilding.MissileSilo, "Missile Silo")]
    [InlineData(FacilitiesBuilding.NaniteFactory, "Nanite Factory")]
    [InlineData(FacilitiesBuilding.Terraformer, "Terraformer")]
    [InlineData(FacilitiesBuilding.SpaceDock, "Space Dock")]
    public void FromBuildingType_WithAllFacilitiesBuildings_CreatesWithCorrectDisplayNames(FacilitiesBuilding building, string expectedDisplayName)
    {
        // Act
        var buildingIdentity = BuildingIdentity.FromBuildingType(building);

        // Assert
        Assert.Equal(expectedDisplayName, buildingIdentity.Name.Value);
        Assert.Equal(building, buildingIdentity.Type);
    }

    // Human Building Tests
    [Theory]
    [InlineData(HumanBuilding.ResidentialSector, "Residential Sector")]
    [InlineData(HumanBuilding.BiosphereFarm, "Biosphere Farm")]
    [InlineData(HumanBuilding.ResearchCentre, "Research Centre")]
    [InlineData(HumanBuilding.AcademyOfSciences, "Academy of Sciences")]
    [InlineData(HumanBuilding.NeuroCablibrationCentre, "Neuro-Calibration Centre")]
    [InlineData(HumanBuilding.HighEnergySmelting, "High Energy Smelting")]
    [InlineData(HumanBuilding.FoodSilo, "Food Silo")]
    [InlineData(HumanBuilding.FusionPoweredProduction, "Fusion-Powered Production")]
    [InlineData(HumanBuilding.Skycraper, "Skycraper")]
    [InlineData(HumanBuilding.BiotechLab, "Biotech Lab")]
    [InlineData(HumanBuilding.Metropolis, "Metropolis")]
    [InlineData(HumanBuilding.PlanetaryShield, "Planetary Shield")]
    public void FromBuildingType_WithAllHumanBuildings_CreatesWithCorrectDisplayNames(HumanBuilding building, string expectedDisplayName)
    {
        // Act
        var buildingIdentity = BuildingIdentity.FromBuildingType(building);

        // Assert
        Assert.Equal(expectedDisplayName, buildingIdentity.Name.Value);
        Assert.Equal(building, buildingIdentity.Type);
    }

    // Rocktal Building Tests
    [Theory]
    [InlineData(RocktalBuilding.MeditationEnclave, "Meditation Enclave")]
    [InlineData(RocktalBuilding.CrystalFarm, "Crystal Farm")]
    [InlineData(RocktalBuilding.RuneTechnologium, "Rune Technologium")]
    [InlineData(RocktalBuilding.RuneForge, "Rune Forge")]
    [InlineData(RocktalBuilding.Oriktorium, "Oriktorium")]
    [InlineData(RocktalBuilding.MagmaForge, "Magma Forge")]
    [InlineData(RocktalBuilding.DisruptionChamber, "Disruption Chamber")]
    [InlineData(RocktalBuilding.Megalith, "Monolith")]
    [InlineData(RocktalBuilding.CrystalRefinery, "Crystal Refinery")]
    [InlineData(RocktalBuilding.DeuteriumSynthesiser, "Deuterium Synthesiser")]
    [InlineData(RocktalBuilding.MineralResearchCenter, "Mineral Research Center")]
    [InlineData(RocktalBuilding.AdvancedRecyclingPlant, "Advanced Recycling Plant")]
    public void FromBuildingType_WithAllRocktalBuildings_CreatesWithCorrectDisplayNames(RocktalBuilding building, string expectedDisplayName)
    {
        // Act
        var buildingIdentity = BuildingIdentity.FromBuildingType(building);

        // Assert
        Assert.Equal(expectedDisplayName, buildingIdentity.Name.Value);
        Assert.Equal(building, buildingIdentity.Type);
    }

    // Kaelesh Building Tests
    [Theory]
    [InlineData(KaeleshBuildings.Sanctuary, "Sanctuary")]
    [InlineData(KaeleshBuildings.AntimatterCondenser, "Antimatter Condenser")]
    [InlineData(KaeleshBuildings.VortexChamber, "Vortex Chamber")]
    [InlineData(KaeleshBuildings.HallsOfRealisation, "Halls of Realisation")]
    [InlineData(KaeleshBuildings.ForumOfTranscendence, "Forum of Transcendence")]
    [InlineData(KaeleshBuildings.AntimatterConvector, "Antimatter Convector")]
    [InlineData(KaeleshBuildings.CloningLaboratory, "Cloning Laboratory")]
    [InlineData(KaeleshBuildings.ChrysalisAccelerator, "Chrysalis Accelerator")]
    [InlineData(KaeleshBuildings.BioModifier, "Bio Modifier")]
    [InlineData(KaeleshBuildings.PsionicModulator, "Psionic Modulator")]
    [InlineData(KaeleshBuildings.ShipManufacturingHall, "Ship Manufacturing Hall")]
    [InlineData(KaeleshBuildings.SupraRefractor, "Supra Refractor")]
    public void FromBuildingType_WithAllKaeleshBuildings_CreatesWithCorrectDisplayNames(KaeleshBuildings building, string expectedDisplayName)
    {
        // Act
        var buildingIdentity = BuildingIdentity.FromBuildingType(building);

        // Assert
        Assert.Equal(expectedDisplayName, buildingIdentity.Name.Value);
        Assert.Equal(building, buildingIdentity.Type);
    }

    // Mecha Building Tests
    [Theory]
    [InlineData(MechaBuildings.AssemblyLine, "Assembly Line")]
    [InlineData(MechaBuildings.FusionCellFactory, "Fusion Cell Factory")]
    [InlineData(MechaBuildings.RoboticsResearchCentre, "Robotics Research Centre")]
    [InlineData(MechaBuildings.UpdateNetwork, "Update Network")]
    [InlineData(MechaBuildings.QuantumComputerCentre, "Quantum Computer Centre")]
    [InlineData(MechaBuildings.AutomatisedAssemblyCentre, "Automatised Assembly Centre")]
    [InlineData(MechaBuildings.HighPerformanceTransformer, "High Performance Transformer")]
    [InlineData(MechaBuildings.MicrochipAssemblyLine, "Microchip Assembly Line")]
    [InlineData(MechaBuildings.ProductionAssemblyHall, "Production Assembly Hall")]
    [InlineData(MechaBuildings.HighPerformanceSynthesiser, "High Performance Synthesiser")]
    [InlineData(MechaBuildings.ChipMassProduction, "Chip Mass Production")]
    [InlineData(MechaBuildings.NanoRepairBots, "Nano Repair Bots")]
    public void FromBuildingType_WithAllMechaBuildings_CreatesWithCorrectDisplayNames(MechaBuildings building, string expectedDisplayName)
    {
        // Act
        var buildingIdentity = BuildingIdentity.FromBuildingType(building);

        // Assert
        Assert.Equal(expectedDisplayName, buildingIdentity.Name.Value);
        Assert.Equal(building, buildingIdentity.Type);
    }

    // Edge Cases and Error Tests
    [Fact]
    public void FromBuildingType_WithNullEnum_ThrowsNotABuildingEnumException()
    {
        // Arrange
        Enum? nullEnum = null;

        // Act & Assert
        Assert.Throws<UnknownBuildingTypeException>(() => BuildingIdentity.FromBuildingType(nullEnum!));
    }

    [Fact]
    public void FromBuildingType_WithInvalidEnumType_ThrowsNotABuildingEnumException()
    {
        // Arrange
        var invalidEnum = System.DayOfWeek.Monday;

        // Act & Assert
        Assert.Throws<UnknownBuildingTypeException>(() => BuildingIdentity.FromBuildingType(invalidEnum));
    }

    // Value Object Properties Tests
    [Fact]
    public void BuildingIdentity_Properties_AreCorrectlySet()
    {
        // Arrange
        var building = ResourceBuilding.MetalMine;

        // Act
        var buildingIdentity = BuildingIdentity.FromBuildingType(building);

        // Assert
        Assert.NotNull(buildingIdentity.Name);
        Assert.Equal("Metal Mine", buildingIdentity.Name.Value);
        Assert.Equal(building, buildingIdentity.Type);
    }

    // Immutability Tests
    [Fact]
    public void BuildingIdentity_IsImmutable()
    {
        // Arrange
        var building = ResourceBuilding.MetalMine;
        var buildingIdentity = BuildingIdentity.FromBuildingType(building);

        // Act & Assert
        Assert.NotNull(buildingIdentity.Name);
        Assert.NotNull(buildingIdentity.Type);

        // Verify properties are read-only (can't be modified after creation)
        var nameProperty = typeof(BuildingIdentity).GetProperty(nameof(BuildingIdentity.Name));
        var typeProperty = typeof(BuildingIdentity).GetProperty(nameof(BuildingIdentity.Type));

        Assert.True(nameProperty?.CanWrite == false);
        Assert.True(typeProperty?.CanWrite == false);
    }

    // Comprehensive Test for All Building Types
    [Fact]
    public void FromBuildingType_WithAllBuildingTypes_CreatesSuccessfully()
    {
        // Arrange
        var allBuildings = new List<Enum>
        {
            ResourceBuilding.MetalMine,
            FacilitiesBuilding.RoboticsFactory,
            HumanBuilding.ResidentialSector,
            RocktalBuilding.MeditationEnclave,
            KaeleshBuildings.Sanctuary,
            MechaBuildings.AssemblyLine
        };

        // Act & Assert
        foreach (var building in allBuildings)
        {
            var buildingIdentity = BuildingIdentity.FromBuildingType(building);
            Assert.NotNull(buildingIdentity);
            Assert.Equal(building, buildingIdentity.Type);
            Assert.NotNull(buildingIdentity.Name);
            Assert.False(string.IsNullOrEmpty(buildingIdentity.Name.Value));
        }
    }
}
