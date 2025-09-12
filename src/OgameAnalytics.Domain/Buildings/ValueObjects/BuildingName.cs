using OgameAnalytics.Domain.Buildings.Exceptions;

namespace OgameAnalytics.Domain.Buildings.ValueObjects
{
    public sealed record BuildingName
    {
        public string Value { get; }

        private BuildingName(string value)
        {
            Value = value;
        }

        public static BuildingName FromPrimitive(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new BuildingNameIsEmptyException();

            if (name.Length <= 3)
                throw new BuildingNameTooShortException();

            if (name.Length > 255)
                throw new BuildingNameTooLongException();

            return new BuildingName(name);
        }
    }
}
