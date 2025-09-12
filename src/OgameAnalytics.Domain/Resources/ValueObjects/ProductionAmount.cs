namespace OgameAnalytics.Domain.Resources.ValueObjects
{
    public readonly record struct ProductionAmount(
        MetalAmount Metal,
        CrystalAmount Crystal,
        DeuteriumAmount Deuterium,
        EnergyAmount Energy)
    {
        public static ProductionAmount From(ulong metal, ulong crystal, ulong deuterium, ulong energy)
    => new(new(metal), new(crystal), new(deuterium), new(energy));

        public ProductionAmount Add(ProductionAmount other) => new(
            Metal.Add(other.Metal),
            Crystal.Add(other.Crystal),
            Deuterium.Add(other.Deuterium),
            Energy.Add(other.Energy)
        );

        public ProductionAmount Multiply(double factor) => new(
            Metal.Multiply(factor),
            Crystal.Multiply(factor),
            Deuterium.Multiply(factor),
            Energy.Multiply(factor)
        );
    }
}
