using OgameAnalytics.Domain.Resources.ValueObjects;

namespace OgameAnalytics.Domain.Buildings.ValueObjects
{
    public readonly record struct BuildingProductionAmount(
        MetalAmount Metal,
        CrystalAmount Crystal,
        DeuteriumAmount Deuterium,
        EnergyAmount Energy)
    {
        public static BuildingProductionAmount From(ResourceCost resources) =>
            new(resources.Metal, resources.Crystal, resources.Deuterium, resources.Energy);
    }
}
