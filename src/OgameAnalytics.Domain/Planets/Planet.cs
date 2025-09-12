using OgameAnalytics.Domain.Buildings;
using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Buildings.ValueObjects;
using OgameAnalytics.Domain.Planets.Enums;
using OgameAnalytics.Domain.Planets.ValueObjects;

namespace OgameAnalytics.Domain.Planets
{
    public class Planet
    {

        public PlanetId Id { get; private set; }

        public PlanetName Name { get; private set; }

        public PlanetCoordinate Coordinates { get; private set; }

        public PlanetTemperature Temperature { get; private set; }

        public PlanetLifeForm LifeForm { get; private set; }

        private readonly Dictionary<BuildingIdentity, Building> _buildingsByIdentity;

        public IReadOnlyCollection<Building> Buildings => _buildingsByIdentity.Values;

        // Convenience methods for accessing specific buildings
        public Building GetBuilding(ResourceBuilding type) => _buildingsByIdentity[BuildingIdentity.FromBuildingType(type)];
        public Building GetBuilding(FacilitiesBuilding type) => _buildingsByIdentity[BuildingIdentity.FromBuildingType(type)];
        public Building GetBuilding(HumanBuilding type) => _buildingsByIdentity[BuildingIdentity.FromBuildingType(type)];
        public Building GetBuilding(RocktalBuilding type) => _buildingsByIdentity[BuildingIdentity.FromBuildingType(type)];
        public Building GetBuilding(KaeleshBuildings type) => _buildingsByIdentity[BuildingIdentity.FromBuildingType(type)];
        public Building GetBuilding(MechaBuildings type) => _buildingsByIdentity[BuildingIdentity.FromBuildingType(type)];

        //// Convenience properties for common buildings
        //public Building MetalMine => GetBuilding(ResourceBuilding.MetalMine);
        //public Building CrystalMine => GetBuilding(ResourceBuilding.CrystalMine);
        //public Building DeuteriumSynthesiser => GetBuilding(ResourceBuilding.DeuteriumSynthesiser);
        //public Building SolarPlant => GetBuilding(ResourceBuilding.SolarPlant);
        //public Building FusionReactor => GetBuilding(ResourceBuilding.FusionReactor);
        //public Building MetalStorage => GetBuilding(ResourceBuilding.MetalStorage);
        //public Building CrystalStorage => GetBuilding(ResourceBuilding.CrystalStorage);
        //public Building DeuteriumTank => GetBuilding(ResourceBuilding.DeuteriumTank);

        //public Building RoboticsFactory => GetBuilding(FacilitiesBuilding.RoboticsFactory);
        //public Building Shipyard => GetBuilding(FacilitiesBuilding.Shipyard);
        //public Building ResearchLab => GetBuilding(FacilitiesBuilding.ResearchLab);
        //public Building AllianceDepot => GetBuilding(FacilitiesBuilding.AllianceDepot);
        //public Building MissileSilo => GetBuilding(FacilitiesBuilding.MissileSilo);
        //public Building NaniteFactory => GetBuilding(FacilitiesBuilding.NaniteFactory);
        //public Building Terraformer => GetBuilding(FacilitiesBuilding.Terraformer);
        //public Building SpaceDock => GetBuilding(FacilitiesBuilding.SpaceDock);

        private Planet(
            PlanetId id,
            PlanetName name,
            PlanetCoordinate coordinates,
            PlanetTemperature temperature,
            PlanetLifeForm lifeForm,
            Dictionary<BuildingIdentity, Building> buildingsByIdentity)
        {
            Id = id;
            Name = name;
            Coordinates = coordinates;
            Temperature = temperature;
            LifeForm = lifeForm;
            _buildingsByIdentity = buildingsByIdentity;
        }




        public static Planet CreateEmpty(PlanetId id, PlanetName name, PlanetCoordinate coordinates, PlanetTemperature temperature, PlanetLifeForm lifeForm)
        {
            Dictionary<BuildingIdentity, Building> buildingsByIdentity = GenerateBuildingsDictionaryForSelectedLifeForm(lifeForm);

            return new Planet(id, name, coordinates, temperature, lifeForm, buildingsByIdentity);
        }


        private static Dictionary<BuildingIdentity, Building> GenerateBuildingsDictionaryForSelectedLifeForm(PlanetLifeForm lifeForm)
        {
            Dictionary<BuildingIdentity, Building> outputDictionary = [];
            PopulateWithResourceBuildings(outputDictionary);
            PopulateWithFacilitiesBuildings(outputDictionary);
            switch (lifeForm.Value)
            {
                case LifeFormType.Humans:
                    PopulateWithHumanBuildings(outputDictionary);
                    break;
                case LifeFormType.Rocktal:
                    PopulateWithRocktalBuildings(outputDictionary);
                    break;
                case LifeFormType.Kaelesh:
                    PopulateWithKaeleshBuildings(outputDictionary);
                    break;
                case LifeFormType.Mechas:
                    PopulateWithMechaBuildings(outputDictionary);
                    break;


            }

            return outputDictionary;

        }

        private static void PopulateWithMechaBuildings(Dictionary<BuildingIdentity, Building> outputDictionary)
        {
            foreach (MechaBuildings buildingType in Enum.GetValues<MechaBuildings>())
            {
                BuildingIdentity identity = BuildingIdentity.FromBuildingType(buildingType);
                Building building = Building.Create(identity, BuildingLevel.FromPrimitive(0));
                outputDictionary.Add(identity, building);
            }
        }

        private static void PopulateWithKaeleshBuildings(Dictionary<BuildingIdentity, Building> outputDictionary)
        {
            foreach (KaeleshBuildings buildingType in Enum.GetValues<KaeleshBuildings>())
            {
                BuildingIdentity identity = BuildingIdentity.FromBuildingType(buildingType);
                Building building = Building.Create(identity, BuildingLevel.FromPrimitive(0));
                outputDictionary.Add(identity, building);
            }
        }

        private static void PopulateWithRocktalBuildings(Dictionary<BuildingIdentity, Building> outputDictionary)
        {
            foreach (RocktalBuilding buildingType in Enum.GetValues<RocktalBuilding>())
            {
                BuildingIdentity identity = BuildingIdentity.FromBuildingType(buildingType);
                Building building = Building.Create(identity, BuildingLevel.FromPrimitive(0));
                outputDictionary.Add(identity, building);
            }

        }

        private static void PopulateWithFacilitiesBuildings(Dictionary<BuildingIdentity, Building> outputDictionary)

        {
            foreach (FacilitiesBuilding buildingType in Enum.GetValues<FacilitiesBuilding>())
            {
                BuildingIdentity identity = BuildingIdentity.FromBuildingType(buildingType);
                Building building = Building.Create(identity, BuildingLevel.FromPrimitive(0));
                outputDictionary.Add(identity, building);
            }
        }


        private static void PopulateWithResourceBuildings(Dictionary<BuildingIdentity, Building> outputDictionary)
        {
            foreach (ResourceBuilding buildingType in Enum.GetValues<ResourceBuilding>())
            {
                BuildingIdentity identity = BuildingIdentity.FromBuildingType(buildingType);
                Building building = Building.Create(identity, BuildingLevel.FromPrimitive(0));
                outputDictionary.Add(identity, building);
            }

        }

        private static void PopulateWithHumanBuildings(Dictionary<BuildingIdentity, Building> outputDictionary)
        {
            foreach (HumanBuilding buildingType in Enum.GetValues<HumanBuilding>())
            {
                BuildingIdentity identity = BuildingIdentity.FromBuildingType(buildingType);
                Building building = Building.Create(identity, BuildingLevel.FromPrimitive(0));
                outputDictionary.Add(identity, building);
            }


        }


        public void Upgrade(ResourceBuilding type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuilding(identity);

        }
        public void Upgrade(FacilitiesBuilding type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuilding(identity);

        }
        public void Upgrade(HumanBuilding type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuilding(identity);

        }

        public void Upgrade(KaeleshBuildings type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuilding(identity);

        }
        public void Upgrade(RocktalBuilding type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuilding(identity);

        }
        public void Upgrade(MechaBuildings type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuilding(identity);

        }
        private void UpgradeBuilding(BuildingIdentity identity)
        {
            _buildingsByIdentity[identity].Upgrade();
        }

        private void DowngradeBuilding(BuildingIdentity identity)
        {
            _buildingsByIdentity[identity].Downgrade();
        }

        private void UpgradeBuildingBy(BuildingIdentity identity, int quantity)
        {
            _buildingsByIdentity[identity].UpgradeBy(quantity);
        }

        private void DowngradeBuildingBy(BuildingIdentity identity, int quantity)
        {
            _buildingsByIdentity[identity].DowngradeBy(quantity);
        }

        public void UpgradeBy(ResourceBuilding type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuildingBy(identity, quantity);
        }

        public void UpgradeBy(FacilitiesBuilding type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuildingBy(identity, quantity);
        }

        public void UpgradeBy(HumanBuilding type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuildingBy(identity, quantity);
        }

        public void UpgradeBy(KaeleshBuildings type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuildingBy(identity, quantity);
        }

        public void UpgradeBy(RocktalBuilding type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuildingBy(identity, quantity);
        }

        public void UpgradeBy(MechaBuildings type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            UpgradeBuildingBy(identity, quantity);
        }

        public void Downgrade(ResourceBuilding type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuilding(identity);

        }
        public void Downgrade(FacilitiesBuilding type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuilding(identity);

        }
        public void Downgrade(HumanBuilding type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuilding(identity);

        }
        public void Downgrade(RocktalBuilding type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuilding(identity);

        }

        public void Downgrade(KaeleshBuildings type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuilding(identity);

        }

        public void Downgrade(MechaBuildings type)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuilding(identity);

        }

        public void DowngradeBy(ResourceBuilding type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuildingBy(identity, quantity);
        }

        public void DowngradeBy(FacilitiesBuilding type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuildingBy(identity, quantity);
        }

        public void DowngradeBy(HumanBuilding type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuildingBy(identity, quantity);
        }

        public void DowngradeBy(RocktalBuilding type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuildingBy(identity, quantity);
        }

        public void DowngradeBy(KaeleshBuildings type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuildingBy(identity, quantity);
        }

        public void DowngradeBy(MechaBuildings type, int quantity)
        {
            BuildingIdentity identity = BuildingIdentity.FromBuildingType(type);
            DowngradeBuildingBy(identity, quantity);
        }
    }

}



