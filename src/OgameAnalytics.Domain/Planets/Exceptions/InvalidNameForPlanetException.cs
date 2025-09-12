using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions
{
    public class InvalidNameForPlanetException : DomainException
    {
        public string AttemptedName { get; }
        public InvalidNameForPlanetException(string attemptedName) : base(BuildMessage(attemptedName))
        {
            AttemptedName = attemptedName;
        }

        private static string BuildMessage(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Planet name cannot be null, empty, or whitespace. Valid length is [1,150].";
            if (name.Length > 150)
                return $"Planet name '{name}' is too long. Valid length is [1,150].";

            return $"Planet name '{name}' is invalid.";

        }
    }
}
