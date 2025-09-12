namespace OgameAnalytics.Domain.Resources.ValueObjects
{
    public readonly record struct MetalAmount(ulong Value)
    {
        public MetalAmount Add(MetalAmount other) => new(checked(Value + other.Value));
        public MetalAmount Multiply(double factor) => new(checked((ulong)Math.Floor(Value * factor)));
    }
}
