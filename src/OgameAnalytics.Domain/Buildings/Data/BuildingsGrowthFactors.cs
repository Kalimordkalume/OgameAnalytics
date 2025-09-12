using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Shared.ValueObject;

namespace OgameAnalytics.Domain.Buildings.Data;
public class BuildingsGrowthFactors
{
    public  Dictionary<ResourceBuilding, GrowthFactors> ResourceBuildingsGrowingFactors = PopulateResourceBuildingDictionary();

    public  Dictionary<FacilitiesBuilding, GrowthFactors> FacilitiesBuildingsGrowingFactors = PopulateFacilitiesBuildingDictionary();

    public  Dictionary<HumanBuilding, GrowthFactors> HumanBuildingsGrowingFactors = PopulateHumanBuildingsDictionary();

    public  Dictionary<RocktalBuilding, GrowthFactors> RocktalBuildingsGrowingFactors = PopulateRocktalBuildingsDictionary();


    public Dictionary<KaeleshBuildings, GrowthFactors> KaeleshBuildingsGrowingFactors = PopulateKaeleshBuildingsDictionary();

    public Dictionary<MechaBuildings, GrowthFactors> MechaBuildingsGrowingFactors = PopulateMechaBuildingsDictionary();

    private static Dictionary<MechaBuildings, GrowthFactors> PopulateMechaBuildingsDictionary()
    {
        Dictionary<MechaBuildings, GrowthFactors> output = new Dictionary<MechaBuildings, GrowthFactors>()
        {
            { MechaBuildings.AssemblyLine,GrowthFactors.FromPrimitives(1.21,1.21,1,1,1.205,1.2,1.22)},
            { MechaBuildings.FusionCellFactory,GrowthFactors.FromPrimitives(1.18,1.18,1,1.02,1.15,1.12,1.2)},
            { MechaBuildings.RoboticsResearchCentre,GrowthFactors.FromPrimitives(1.3,1.3,1.3,1.08,1,1,1.25)},
            { MechaBuildings.UpdateNetwork,GrowthFactors.FromPrimitives(1.8,1.8,1.8,1.2,1.1,1,1.6)},
            { MechaBuildings.QuantumComputerCentre,GrowthFactors.FromPrimitives(1.8,1.8,1.8,1.2,1.1,1,1.7)},
            { MechaBuildings.AutomatisedAssemblyCentre,GrowthFactors.FromPrimitives(1.3,1.3,1.3,1,1,1,1.3)},
            { MechaBuildings.HighPerformanceTransformer,GrowthFactors.FromPrimitives(1.5,1.5,1.5,1.05,1,1,1.4)},
            { MechaBuildings.MicrochipAssemblyLine,GrowthFactors.FromPrimitives(1.07,1.07,1.07,1.01,1,1,1.17)},
            { MechaBuildings.ProductionAssemblyHall,GrowthFactors.FromPrimitives(1.14,1.14,1.14,1.04,1,1,1.3)},
            { MechaBuildings.HighPerformanceSynthesiser,GrowthFactors.FromPrimitives(1.5,1.5,1.5,1.1,1,1,1.2)},
            { MechaBuildings.ChipMassProduction,GrowthFactors.FromPrimitives(1.5,1.5,1.5,1.05,1,1,1.3)},
            { MechaBuildings.NanoRepairBots,GrowthFactors.FromPrimitives(1.4,1.4,1.4,1.05,1,1,1.4)}
        };
        return output;

    }

    private static Dictionary<KaeleshBuildings, GrowthFactors> PopulateKaeleshBuildingsDictionary()
    {
        Dictionary<KaeleshBuildings, GrowthFactors> output = new Dictionary<KaeleshBuildings, GrowthFactors>()
        {
            { KaeleshBuildings.Sanctuary,GrowthFactors.FromPrimitives(1.21,1.21,1,1,1.21,1.2,1.22)},
            { KaeleshBuildings.AntimatterConvector,GrowthFactors.FromPrimitives(1.21,1.21,1,1.02,1.15,1.14,1.22)},
            { KaeleshBuildings.VortexChamber,GrowthFactors.FromPrimitives(1.3,1.3,1.3,1.08,1,1,1.25)},
            { KaeleshBuildings.HallsOfRealisation,GrowthFactors.FromPrimitives(1.8,1.8,1.8,1.3,1.1,1,1.7)},
            { KaeleshBuildings.ForumOfTranscendence,GrowthFactors.FromPrimitives(1.8,1.8,1.8,1.3,1.1,1,1.8)},
            { KaeleshBuildings.AntimatterCondenser,GrowthFactors.FromPrimitives(1.25,1.25,1.25,1,1,1,1.35)},
            { KaeleshBuildings.CloningLaboratory,GrowthFactors.FromPrimitives(1.2,1.2,1.2,1,1,1,1.2)},
            { KaeleshBuildings.ChrysalisAccelerator,GrowthFactors.FromPrimitives(1.05,1.05,1.05,1.03,1,1,1.18)},
            { KaeleshBuildings.BioModifier,GrowthFactors.FromPrimitives(1.2,1.2,1.2,1.02,1,1,1.2)},
            { KaeleshBuildings.PsionicModulator,GrowthFactors.FromPrimitives(1.5,1.5,1.5,1.05,1,1,1.8)},
            { KaeleshBuildings.ShipManufacturingHall,GrowthFactors.FromPrimitives(1.2,1.2,1.2,1.04,1,1,1.3)},
            { KaeleshBuildings.SupraRefractor,GrowthFactors.FromPrimitives(1.4,1.4,1.4,1.05,1,1,1.3)}
        };
        return output;
    }

    private static Dictionary<RocktalBuilding, GrowthFactors> PopulateRocktalBuildingsDictionary()
    {
        Dictionary<RocktalBuilding, GrowthFactors> output = new Dictionary<RocktalBuilding, GrowthFactors>()
        {
            { RocktalBuilding.MeditationEnclave,GrowthFactors.FromPrimitives(1.2,1.2,1,1,1.216,1.2,1.21)},
            { RocktalBuilding.CrystalFarm,GrowthFactors.FromPrimitives(1.2,1.2,1,1.03,1.15,1.14,1.21)},
            { RocktalBuilding.RuneTechnologium,GrowthFactors.FromPrimitives(1.3,1.3,1.3,1.1,1,1,1.25)},
            { RocktalBuilding.RuneForge,GrowthFactors.FromPrimitives(1.7,1.7,1.7,1.35,1.14,1,1.6)},
            { RocktalBuilding.Oriktorium,GrowthFactors.FromPrimitives(1.65,1.65,1.65,1.3,1.1,1,1.7)},
            { RocktalBuilding.MagmaForge,GrowthFactors.FromPrimitives(1.4,1.4,1.4,1.1,1,1,1.3)},
            { RocktalBuilding.DisruptionChamber,GrowthFactors.FromPrimitives(1.2,1.2,1.2,1,1,1,1.25)},
            { RocktalBuilding.Megalith,GrowthFactors.FromPrimitives(1.5,1.5,1.5,1.3,1,1,1.4)},
            { RocktalBuilding.CrystalRefinery,GrowthFactors.FromPrimitives(1.4,1.4,1.4,1.1,1,1,1.2)},
            { RocktalBuilding.DeuteriumSynthesiser,GrowthFactors.FromPrimitives(1.4,1.4,1.4,1.1,1,1,1.2)},
            { RocktalBuilding.MineralResearchCenter,GrowthFactors.FromPrimitives(1.8,1.8,1.8,1.3,1,1,1.3)},
            { RocktalBuilding.AdvancedRecyclingPlant,GrowthFactors.FromPrimitives(1.5,1.5,1.5,1.1,1,1,1.3)}
        };
        return output;
    }

    private static Dictionary<HumanBuilding, GrowthFactors> PopulateHumanBuildingsDictionary()
    {
        Dictionary<HumanBuilding, GrowthFactors> output = new Dictionary<HumanBuilding, GrowthFactors>()
        {
            {HumanBuilding.ResidentialSector,GrowthFactors.FromPrimitives(1.2,1.2,1,1,1.21,1.2,1.21) },
            { HumanBuilding.BiosphereFarm,GrowthFactors.FromPrimitives(1.23,1.23,1,1.02,1.15,1.14,1.25)},
            { HumanBuilding.ResearchCentre, GrowthFactors.FromPrimitives(1.30,1.30,1.30,1.08,1,1,1.25)},
            { HumanBuilding.AcademyOfSciences,GrowthFactors.FromPrimitives(1.7,1.7,1.7,1.25,1.1,1,1.6)},
            { HumanBuilding.NeuroCablibrationCentre,GrowthFactors.FromPrimitives(1.7,1.7,1.7,1.25,1.1,1,1.7)},
            { HumanBuilding.HighEnergySmelting,GrowthFactors.FromPrimitives(1.5,1.5,1.5,1.1,1,1,1.3)},
            { HumanBuilding.FoodSilo,GrowthFactors.FromPrimitives(1.09,1.09,1.09,1,1,1,1.17)},
            { HumanBuilding.FusionPoweredProduction,GrowthFactors.FromPrimitives(1.5,1.5,1.5,1.1,1,1,1.2)},
            { HumanBuilding.Skycraper,GrowthFactors.FromPrimitives(1.09,1.09,1.09,1.02,1,1,1.2)},
            { HumanBuilding.BiotechLab,GrowthFactors.FromPrimitives(1.12,1.12,1.12,1.03,1,1,1.2)},
            { HumanBuilding.Metropolis,GrowthFactors.FromPrimitives(1.5,1.5,1.5,1.05,1,1,1.3)},
            { HumanBuilding.PlanetaryShield,GrowthFactors.FromPrimitives(1.2,1.2,1.2,1.02,1,1,1.2)}
        };
        return output;
    }


    private static Dictionary<FacilitiesBuilding, GrowthFactors> PopulateFacilitiesBuildingDictionary()
    {
        Dictionary<FacilitiesBuilding, GrowthFactors> output = new Dictionary<FacilitiesBuilding, GrowthFactors>()
        {
            { FacilitiesBuilding.RoboticsFactory,GrowthFactors.FromPrimitives(2,2,2,1,1,1,1)},
            { FacilitiesBuilding.Shipyard, GrowthFactors.FromPrimitives(2,2,2,1,1,1,1)},
            { FacilitiesBuilding.ResearchLab, GrowthFactors.FromPrimitives(2,2,2,1,1,1,1)},
            { FacilitiesBuilding.AllianceDepot, GrowthFactors.FromPrimitives(2,2,2,1,1,1,1)},
            { FacilitiesBuilding.MissileSilo, GrowthFactors.FromPrimitives(2,2,2,1,1,1,1)},
            { FacilitiesBuilding.NaniteFactory, GrowthFactors.FromPrimitives(2,2,2,1,1,1,1)},
            { FacilitiesBuilding.Terraformer, GrowthFactors.FromPrimitives(2,2,2,2,1,1,1)},
            { FacilitiesBuilding.SpaceDock, GrowthFactors.FromPrimitives(2,2,2,1,1,1,1)},


        };

        return output;
    }

    private static Dictionary<ResourceBuilding, GrowthFactors> PopulateResourceBuildingDictionary()
    {
        Dictionary<ResourceBuilding, GrowthFactors> output = new Dictionary<ResourceBuilding, GrowthFactors>()
        {
            { ResourceBuilding.MetalMine,GrowthFactors.FromPrimitives(1.5,1.5,1,1.1,1,1,1)},
            { ResourceBuilding.CrystalMine,GrowthFactors.FromPrimitives(1.6,1.6,1,1.1,1,1,1)},
            { ResourceBuilding.DeuteriumSynthesiser,GrowthFactors.FromPrimitives(1.5,1.5,1,1.1,1,1,1)},
            { ResourceBuilding.SolarPlant,GrowthFactors.FromPrimitives(1.5,1.5,1,1,1,1,1)},
            { ResourceBuilding.FusionReactor,GrowthFactors.FromPrimitives(1.8,1.8,1.8,1,1,1,1)},
            { ResourceBuilding.MetalStorage,GrowthFactors.FromPrimitives(2,2,2,1,1,1,1)},
            { ResourceBuilding.CrystalStorage,GrowthFactors.FromPrimitives(2,2,2,1,1,1,1)},
            { ResourceBuilding.DeuteriumTank,GrowthFactors.FromPrimitives(2,2,2,1,1,1,1)},
            

        };

        return output;
    }


}
