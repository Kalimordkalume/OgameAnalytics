using OgameAnalytics.Domain.Buildings.ValueObjects;

namespace OgameAnalytics.Domain.Buildings
{
    //He decidido rehacer la clase Building puesto que no necesita una propiedad ID propia.
    //La unicidad de un edificio viene dada únicamente por su pertenencia al agregado Planet y su propiedad Definition
    // Es decir, al tipo de edificio al que pertenece.
    // Faltaría modelar correctamente el BuildingDefinition.
    // Faltaría modelar el Building.
    public class Building
    {

        public BuildingIdentity Identity { get; private set; }
        public BuildingLevel Level { get; private set; }

        private Building(BuildingIdentity identity, BuildingLevel level)
        {
            Identity = identity ?? throw new ArgumentNullException(nameof(identity));
            Level = level ?? throw new ArgumentNullException(nameof(level));
        }

        // Factory: provide VOs directly
        public static Building Create(BuildingIdentity identity, BuildingLevel level)
            => new Building(identity, level);

        // Factory: from building enum and level VO
        public static Building Create(Enum buildingType, BuildingLevel level)
            => new Building(BuildingIdentity.FromBuildingType(buildingType), level);

        // Factory: from building enum, default level = 0
        public static Building Create(Enum buildingType)
            => new Building(BuildingIdentity.FromBuildingType(buildingType), BuildingLevel.FromPrimitive(0));

        public void Upgrade()
        {
            Level = Level.Increase();
        }

        public void UpgradeBy(int quantity)
        {
            Level = Level.IncreaseBy(quantity);
        }

        public void Downgrade()
        {
            Level = Level.Decrease();
        }

        public void DowngradeBy(int quantity)
        {
            Level = Level.DecreaseBy(quantity);
        }
    }
}
