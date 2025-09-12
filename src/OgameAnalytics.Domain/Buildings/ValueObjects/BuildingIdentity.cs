using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Buildings.Exceptions;

namespace OgameAnalytics.Domain.Buildings.ValueObjects
{
    public sealed record BuildingIdentity
    {
        public BuildingName Name { get; }
        public Enum Type { get; }

        private BuildingIdentity(BuildingName name, Enum type)
        {
            Name = name;
            Type = type;
        }

        private static readonly Dictionary<ResourceBuilding, string> ResourceBuildingsDisplayName = new()
        {
            {ResourceBuilding.MetalMine, "Metal Mine"},
            {ResourceBuilding.CrystalMine, "Crystal Mine"},
            {ResourceBuilding.DeuteriumSynthesiser, "Deuterium Synthesiser"},
            {ResourceBuilding.SolarPlant, "Solar Plant"},
            {ResourceBuilding.FusionReactor,"Fusion Reactor"},
            {ResourceBuilding.MetalStorage, "Metal Storage"},
            {ResourceBuilding.CrystalStorage, "Crystal Storage"},
            { ResourceBuilding.DeuteriumTank, "Deuterium Tank" }
        };

        private static readonly Dictionary<FacilitiesBuilding, string> FacilitiesBuildingDisplayName = new()
        {
                {FacilitiesBuilding.RoboticsFactory, "Robotics Factory"},
                {FacilitiesBuilding.Shipyard,"Shipyard" },
                { FacilitiesBuilding.ResearchLab,"Research Lab"},
                { FacilitiesBuilding.AllianceDepot,"Alliance Depot"},
                { FacilitiesBuilding.MissileSilo, "Missile Silo"},
                { FacilitiesBuilding.NaniteFactory,"Nanite Factory"},
                { FacilitiesBuilding.Terraformer,"Terraformer"},
                { FacilitiesBuilding.SpaceDock,"Space Dock"}
        };

        private static readonly Dictionary<HumanBuilding, string> HumanBuildingsDisplayName = new()
        {
            {
                HumanBuilding.ResidentialSector, "Residential Sector"
            },
            {HumanBuilding.BiosphereFarm,"Biosphere Farm"},
            {HumanBuilding.ResearchCentre,"Research Centre"},
            {HumanBuilding.AcademyOfSciences,"Academy of Sciences"},
            {HumanBuilding.NeuroCablibrationCentre, "Neuro-Calibration Centre"},
            {HumanBuilding.HighEnergySmelting, "High Energy Smelting"},
            {HumanBuilding.FoodSilo, "Food Silo"},
            {HumanBuilding.FusionPoweredProduction, "Fusion-Powered Production" },
            {HumanBuilding.Skycraper,"Skycraper"},
            {HumanBuilding.BiotechLab,"Biotech Lab"},
            {HumanBuilding.Metropolis,"Metropolis"},
            {HumanBuilding.PlanetaryShield,"Planetary Shield"},
        };

        private static readonly Dictionary<RocktalBuilding, string> RocktalBuildingsDisplayName = new()
        {
            {RocktalBuilding.MeditationEnclave,"Meditation Enclave" },
            { RocktalBuilding.CrystalFarm,"Crystal Farm" },
            { RocktalBuilding.RuneTechnologium,"Rune Technologium"},
            { RocktalBuilding.RuneForge,"Rune Forge"},
            { RocktalBuilding.Oriktorium,"Oriktorium"},
            { RocktalBuilding.MagmaForge,"Magma Forge"},
            { RocktalBuilding.DisruptionChamber,"Disruption Chamber"},
            { RocktalBuilding.Megalith,"Monolith"},
            { RocktalBuilding.CrystalRefinery, "Crystal Refinery"},
            { RocktalBuilding.DeuteriumSynthesiser, "Deuterium Synthesiser"},
            { RocktalBuilding.MineralResearchCenter,"Mineral Research Center"},
            { RocktalBuilding.AdvancedRecyclingPlant,"Advanced Recycling Plant"}
        };

        private static readonly Dictionary<KaeleshBuildings, string> KaeleshBuildingsDisplayName = new()
        {
            {KaeleshBuildings.Sanctuary,"Sanctuary" },
            { KaeleshBuildings.AntimatterCondenser, "Antimatter Condenser"},
            { KaeleshBuildings.VortexChamber,"Vortex Chamber"},
            { KaeleshBuildings.HallsOfRealisation,"Halls of Realisation"},
            { KaeleshBuildings.ForumOfTranscendence,"Forum of Transcendence"},
            { KaeleshBuildings.AntimatterConvector,"Antimatter Convector"},
            { KaeleshBuildings.CloningLaboratory,"Cloning Laboratory"},
            { KaeleshBuildings.ChrysalisAccelerator,"Chrysalis Accelerator"},
            { KaeleshBuildings.BioModifier,"Bio Modifier"},
            { KaeleshBuildings.PsionicModulator,"Psionic Modulator"},
            { KaeleshBuildings.ShipManufacturingHall,"Ship Manufacturing Hall"},
            { KaeleshBuildings.SupraRefractor,"Supra Refractor"}
        };

        private static readonly Dictionary<MechaBuildings, string> MechaBuildingsDisplayName = new()
        {
            {MechaBuildings.AssemblyLine,"Assembly Line" },
            { MechaBuildings.FusionCellFactory,"Fusion Cell Factory"},
            { MechaBuildings.RoboticsResearchCentre,"Robotics Research Centre"},
            { MechaBuildings.UpdateNetwork,"Update Network"},
            { MechaBuildings.QuantumComputerCentre,"Quantum Computer Centre"},
            { MechaBuildings.AutomatisedAssemblyCentre,"Automatised Assembly Centre"},
            { MechaBuildings.HighPerformanceTransformer,"High Performance Transformer"},
            {MechaBuildings.MicrochipAssemblyLine,"Microchip Assembly Line" },
            {MechaBuildings.ProductionAssemblyHall,"Production Assembly Hall" },
            { MechaBuildings.HighPerformanceSynthesiser,"High Performance Synthesiser"},
            { MechaBuildings.ChipMassProduction,"Chip Mass Production"},
            { MechaBuildings.NanoRepairBots,"Nano Repair Bots"}
        };
        public static BuildingIdentity FromBuildingType(Enum buildingEnum)
        {
            var displayName = GetDisplayName(buildingEnum);
            var name = BuildingName.FromPrimitive(displayName);
            return new BuildingIdentity(name, buildingEnum);
        }

        private static string GetDisplayName(Enum buildingEnum)
        {
            return buildingEnum switch
            {
                ResourceBuilding resourceType => ResourceBuildingsDisplayName[resourceType],
                FacilitiesBuilding facilitiesBuilding => FacilitiesBuildingDisplayName[facilitiesBuilding],
                HumanBuilding humanBuilding => HumanBuildingsDisplayName[humanBuilding],
                RocktalBuilding rocktalBuilding => RocktalBuildingsDisplayName[rocktalBuilding],
                KaeleshBuildings kaeleshBuildings => KaeleshBuildingsDisplayName[kaeleshBuildings],
                MechaBuildings mechaBuildings => MechaBuildingsDisplayName[mechaBuildings],
                _ => throw new UnknownBuildingTypeException(buildingEnum)
            };
        }

    }
}
