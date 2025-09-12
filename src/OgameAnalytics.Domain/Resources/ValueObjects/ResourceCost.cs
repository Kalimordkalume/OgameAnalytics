namespace OgameAnalytics.Domain.Resources.ValueObjects
{
    public readonly record struct ResourceCost(
        MetalAmount Metal,
        CrystalAmount Crystal,
        DeuteriumAmount Deuterium,
        EnergyAmount Energy)
    {
        public static ResourceCost From(ulong metal, ulong crystal, ulong deuterium, ulong energy)
            => new(new(metal), new(crystal), new(deuterium), new(energy));

        public ResourceCost Add(ResourceCost other) => new(
            Metal.Add(other.Metal),
            Crystal.Add(other.Crystal),
            Deuterium.Add(other.Deuterium),
            Energy.Add(other.Energy)
        );

        public ResourceCost Multiply(double factor) => new(
            Metal.Multiply(factor),
            Crystal.Multiply(factor),
            Deuterium.Multiply(factor),
            Energy.Multiply(factor)
        );
    }
}




