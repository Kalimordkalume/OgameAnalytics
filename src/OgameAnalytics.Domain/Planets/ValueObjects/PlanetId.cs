namespace OgameAnalytics.Domain.Planets.ValueObjects
{
    public record PlanetId(Guid Value)
    {
        public static PlanetId Generate() => new(Guid.NewGuid());
        public static PlanetId From(string value) => new(Guid.Parse(value));

        public static PlanetId From(Guid value) => new(value);

        public override string ToString() => Value.ToString();

    }
}
