namespace OgameAnalytics.Domain.Resources.ValueObjects
{
    public readonly record struct DeuteriumAmount(ulong Value)
    {
        public DeuteriumAmount Add(DeuteriumAmount other) => new(checked(Value + other.Value));
        public DeuteriumAmount Multiply(double factor) => new(checked((ulong)Math.Floor(Value * factor)));
    }
}
