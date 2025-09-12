using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Shared.ValueObject;

namespace OgameAnalytics.Domain.Buildings.Data;

public class BuildingsBasicCost
{
    public Dictionary<ResourceBuilding, EconomicUnit> ResourceBuildingsCost = PopulateResourceBuildings();
    public Dictionary<FacilitiesBuilding, EconomicUnit> FacilitiesBuildingsCost = PopulateFacilityBuildings();
    public Dictionary<HumanBuilding, EconomicUnit> HumanBuildingsCost = PopulateHumanBuildings();

    public Dictionary<RocktalBuilding, EconomicUnit> RocktalBuildingsCost = PopulateRocktalBuildings();
    public Dictionary<KaeleshBuildings, EconomicUnit> KaeleshBuildingsCost = PopulateKaeleshBuildings();
    public Dictionary<MechaBuildings, EconomicUnit> MechaBuildingsCost = PopulateMechaBuildings();

    private static Dictionary<MechaBuildings, EconomicUnit> PopulateMechaBuildings()
    {
        Dictionary<MechaBuildings, EconomicUnit> output = new Dictionary<MechaBuildings, EconomicUnit>()
    {
        {MechaBuildings.AssemblyLine, EconomicUnit.CreateNewMineralUnit(6,2,0) },
        { MechaBuildings.FusionCellFactory,EconomicUnit.FromPrimitives(5,2,0,8,0,0)},
        { MechaBuildings.RoboticsResearchCentre,EconomicUnit.FromPrimitives(30_000,20_000,10_000,13,0,0)},
        { MechaBuildings.UpdateNetwork,EconomicUnit.FromPrimitives(5_000,3_800,1_000,10,40_000_000,0)},
        { MechaBuildings.QuantumComputerCentre,EconomicUnit.FromPrimitives(50_000,40_000,50_000,40,130_000_000,0)},
        { MechaBuildings.AutomatisedAssemblyCentre,EconomicUnit.CreateNewMineralUnit(7_500,7_000,1_000)},
        { MechaBuildings.HighPerformanceTransformer,EconomicUnit.FromPrimitives(35_000,15_000,10_000,40,0,0)},
        { MechaBuildings.MicrochipAssemblyLine,EconomicUnit.FromPrimitives(35_000,15_000,10_000,40,0,0)},
        { MechaBuildings.ProductionAssemblyHall,EconomicUnit.FromPrimitives(100_000, 10_000, 3_000, 80, 0, 0)},
        { MechaBuildings.HighPerformanceSynthesiser,EconomicUnit.FromPrimitives(100_000, 40_000, 20_000, 60, 0, 0)},
        { MechaBuildings.ChipMassProduction,EconomicUnit.FromPrimitives(55_000, 50_000, 30_000, 70, 0, 0)},
        { MechaBuildings.NanoRepairBots,EconomicUnit.FromPrimitives(250_000, 125_000, 125_000, 100, 0, 0)}
    };
        return output;
    }
    private static Dictionary<KaeleshBuildings, EconomicUnit> PopulateKaeleshBuildings()
    {
        Dictionary<KaeleshBuildings, EconomicUnit> output = new Dictionary<KaeleshBuildings, EconomicUnit>
    {
        { KaeleshBuildings.Sanctuary,EconomicUnit.CreateNewMineralUnit(4,3,0)},
        { KaeleshBuildings.AntimatterCondenser,EconomicUnit.FromPrimitives(6,3,0,9,0,0)},
        { KaeleshBuildings.VortexChamber,EconomicUnit.FromPrimitives(20_000,20_000,30_000,10,0,0)},
        { KaeleshBuildings.HallsOfRealisation,EconomicUnit.FromPrimitives(7_500,5_000,800,15,30_000_000,0)},
        { KaeleshBuildings.ForumOfTranscendence,EconomicUnit.FromPrimitives(60_000,30_000,50_000,30,100_000_000,0)},
        { KaeleshBuildings.AntimatterConvector,EconomicUnit.CreateNewMineralUnit(8_500,5_000,3_000)},
        { KaeleshBuildings.CloningLaboratory,EconomicUnit.CreateNewMineralUnit(15_000,15_000,20_000) },
        { KaeleshBuildings.ChrysalisAccelerator,EconomicUnit.FromPrimitives(75_000,25_000,30_000,30,0,0)},
        { KaeleshBuildings.BioModifier,EconomicUnit.FromPrimitives(87_500,25_000,30_000,40,0,0)},
        { KaeleshBuildings.PsionicModulator, EconomicUnit.FromPrimitives(150_000,30_000,30_000,140,0,0) },
        { KaeleshBuildings.ShipManufacturingHall,EconomicUnit.FromPrimitives(75_000,50_000,55_000,90,0,0)},
        { KaeleshBuildings.SupraRefractor,EconomicUnit.FromPrimitives(500_000,250_000,250_000,100,0,0)}

    };

        return output;
    }
    private static Dictionary<RocktalBuilding, EconomicUnit> PopulateRocktalBuildings()
    {
        Dictionary<RocktalBuilding, EconomicUnit> output = new Dictionary<RocktalBuilding, EconomicUnit>()
    {
        {RocktalBuilding.MeditationEnclave,EconomicUnit.CreateNewMineralUnit(9,3,0) },
        { RocktalBuilding.CrystalFarm,EconomicUnit.FromPrimitives(7,2,0,10,0,0)},
        { RocktalBuilding.RuneTechnologium,EconomicUnit.FromPrimitives(40_000,10_000,15_000,15,0,0)},
        { RocktalBuilding.RuneForge,EconomicUnit.FromPrimitives(5_000,3_800,1_000,20,16_000_000,0)},
        { RocktalBuilding.Oriktorium,EconomicUnit.FromPrimitives(50_000,40_000,50_000,60,90_000_000,0)},
        { RocktalBuilding.MagmaForge,EconomicUnit.FromPrimitives(10_000,8_000,1_000,40,0,0)},
        { RocktalBuilding.DisruptionChamber,EconomicUnit.CreateNewMineralUnit(20_000,15_000,10_000)},
        { RocktalBuilding.Megalith,EconomicUnit.FromPrimitives(50_000,35_000,15_000,80,0,0)},
        { RocktalBuilding.CrystalRefinery,EconomicUnit.FromPrimitives(85_000,44_000,25_000,90,0,0)},
        { RocktalBuilding.DeuteriumSynthesiser,EconomicUnit.FromPrimitives(120_000,50_000,20_000,90,0,0)},
        { RocktalBuilding.MineralResearchCenter,EconomicUnit.FromPrimitives(250_000,150_000,100_000,120,0,0)},
        { RocktalBuilding.AdvancedRecyclingPlant,EconomicUnit.FromPrimitives(250_000,125_000,125_000,100,0,0)}
    };
        return output;

    }
    private static Dictionary<HumanBuilding, EconomicUnit> PopulateHumanBuildings()
    {
        Dictionary<HumanBuilding, EconomicUnit> output = new Dictionary<HumanBuilding, EconomicUnit>()
    {
        { HumanBuilding.ResidentialSector,EconomicUnit.CreateNewMineralUnit(7,2,0)},
        { HumanBuilding.BiosphereFarm,EconomicUnit.FromPrimitives(5,2,0,8,0,0)},
        { HumanBuilding.ResearchCentre, EconomicUnit.FromPrimitives(20_000,25_000,10_000,10,0,0)},
        { HumanBuilding.AcademyOfSciences,EconomicUnit.FromPrimitives(5_000,3_200,1_500,15,20_000_000,0)},
        { HumanBuilding.NeuroCablibrationCentre,EconomicUnit.FromPrimitives(50_000,40_000,50_000,30,100_000_000,0)},
        { HumanBuilding.HighEnergySmelting,EconomicUnit.FromPrimitives(9_000,6_000,3_000,40,0,0)},
        { HumanBuilding.FoodSilo,EconomicUnit.CreateNewMineralUnit(25_000,13_000,7_000)},
        { HumanBuilding.FusionPoweredProduction,EconomicUnit.FromPrimitives(50_000,25_000,15_000,80,0,0)},
        { HumanBuilding.Skycraper,EconomicUnit.FromPrimitives(75_000,20_000,25_000,50,0,0)},
        { HumanBuilding.BiotechLab,EconomicUnit.FromPrimitives(150_000,30_000,15_000,60,0,0)},
        { HumanBuilding.Metropolis, EconomicUnit.FromPrimitives(80_000,35_000,60_000,90,0,0)},
        { HumanBuilding.PlanetaryShield,EconomicUnit.FromPrimitives(250_000,125_000,125_000,100,0,0)}

    };
        return output;

    }
    private static Dictionary<FacilitiesBuilding, EconomicUnit> PopulateFacilityBuildings()
    {
        Dictionary<FacilitiesBuilding, EconomicUnit> output = new()
    {
        {FacilitiesBuilding.RoboticsFactory,EconomicUnit.CreateNewMineralUnit(400,120,200) },
        { FacilitiesBuilding.Shipyard, EconomicUnit.CreateNewMineralUnit(400,200,100)},
        { FacilitiesBuilding.ResearchLab,EconomicUnit.CreateNewMineralUnit(200,400,200)},
        { FacilitiesBuilding.AllianceDepot,EconomicUnit.CreateNewMineralUnit(20_000,40_000,0)},
        { FacilitiesBuilding.MissileSilo,EconomicUnit.CreateNewMineralUnit(20_000,20_000,1_000)},
        { FacilitiesBuilding.NaniteFactory,EconomicUnit.CreateNewMineralUnit(1_000_000,500_000,100_000)},
        { FacilitiesBuilding.Terraformer,EconomicUnit.FromPrimitives(0,50_000,100_000,1_000,0,0)},
        { FacilitiesBuilding.SpaceDock,EconomicUnit.FromPrimitives(200,0,50,50,0,0)}
    };

        return output;

    }
    private static Dictionary<ResourceBuilding, EconomicUnit> PopulateResourceBuildings()
    {
        Dictionary<ResourceBuilding, EconomicUnit> output = new()
    {
        { ResourceBuilding.MetalMine,EconomicUnit.FromPrimitives(60,15,0,10,0,0)},
        { ResourceBuilding.CrystalMine,EconomicUnit.FromPrimitives(48,24,0,10,0,0)},
        { ResourceBuilding.DeuteriumSynthesiser, EconomicUnit.FromPrimitives(225,75,0,20,0,0)},
        { ResourceBuilding.SolarPlant, EconomicUnit.CreateNewMineralUnit(75,30,0)},
        { ResourceBuilding.FusionReactor,EconomicUnit.CreateNewMineralUnit(900,360,180)},
        { ResourceBuilding.MetalStorage,EconomicUnit.CreateNewMineralUnit(1_000,0,0)},
        { ResourceBuilding.CrystalStorage,EconomicUnit.CreateNewMineralUnit(1_000,500,0)},
        { ResourceBuilding.DeuteriumTank,EconomicUnit.CreateNewMineralUnit(1_000,1_000,0)}
    };
        return output;
    }
}
