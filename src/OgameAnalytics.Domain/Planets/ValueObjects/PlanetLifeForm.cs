using OgameAnalytics.Domain.Planets.Enums;

namespace OgameAnalytics.Domain.Planets.ValueObjects;
public record PlanetLifeForm
{
    public LifeFormType Value { get; }

    private PlanetLifeForm(LifeFormType value) => Value = value;

    public static PlanetLifeForm From(LifeFormType type)
    {
        return new(type);
    }
}
