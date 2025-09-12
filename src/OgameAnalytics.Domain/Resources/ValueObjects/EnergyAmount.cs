namespace OgameAnalytics.Domain.Resources.ValueObjects
{
    public readonly record struct EnergyAmount(ulong Value)
    {
        public EnergyAmount Add(EnergyAmount other) => new(checked(Value + other.Value));
        public EnergyAmount Multiply(double factor) => new(checked((ulong)Math.Floor(Value * factor)));
    }
}
