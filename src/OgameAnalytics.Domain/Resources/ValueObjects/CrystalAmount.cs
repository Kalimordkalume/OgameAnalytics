namespace OgameAnalytics.Domain.Resources.ValueObjects
{
    public readonly record struct CrystalAmount(ulong Value)
    {
        public CrystalAmount Add(CrystalAmount other) => new(checked(Value + other.Value));
        public CrystalAmount Multiply(double factor) => new(checked((ulong)Math.Floor(Value * factor)));
    }
}
