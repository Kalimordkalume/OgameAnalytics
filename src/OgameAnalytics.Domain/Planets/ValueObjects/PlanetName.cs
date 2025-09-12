using OgameAnalytics.Domain.Planets.Exceptions;

namespace OgameAnalytics.Domain.Planets.ValueObjects
{
    public record PlanetName
    {
        public string Value { get; set; }

        private PlanetName(string name)
        {
            Value = name;
        }


        public static PlanetName Create(string name)

        {
            if (IsAValidName(name))
                return new PlanetName(name);

            throw new InvalidNameForPlanetException(attemptedName: name);
        }

        private static bool IsAValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;
            if (name.Length > 150)
                return false;
            return true;

        }
    }


}
