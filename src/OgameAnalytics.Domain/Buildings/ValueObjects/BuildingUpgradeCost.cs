using OgameAnalytics.Domain.Resources.ValueObjects;

namespace OgameAnalytics.Domain.Buildings.ValueObjects
{
    public readonly record struct BuildingUpgradeCost(
        MetalAmount Metal,
        CrystalAmount Crystal,
        DeuteriumAmount Deuterium,
        EnergyAmount Energy)
    {
        public static BuildingUpgradeCost From(ResourceCost c) => new(c.Metal, c.Crystal, c.Deuterium, c.Energy);
        public ResourceCost AsResourceCost() => new(Metal, Crystal, Deuterium, Energy);
    }
}
