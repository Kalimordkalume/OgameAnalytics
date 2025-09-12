using OgameAnalytics.Domain.Buildings.Exceptions;

namespace OgameAnalytics.Domain.Buildings.ValueObjects
{
    public record BuildingLevel
    {
        public int Value { get; }

        private BuildingLevel(int value)
        {
            Value = value;
        }

        public static BuildingLevel FromPrimitive(int value)
        {
            if (value < 0)
                throw new LevelCannotBeNegativeException("Level value is too low. Valid range is [0,200]");
            if (value > 200)
                throw new LevelIsTooBigException("Level value is too high. Valid range is [0,200]");

            return new BuildingLevel(value);
        }

        public BuildingLevel Increase()
        {
            if (Value == 200) throw new MaximumLevelAlreadyReachedException();
            return new BuildingLevel(Value + 1);
        }

        public BuildingLevel IncreaseBy(int quantity)

        {
            if (quantity < 0)
                throw new IncreaseLevelByNegativeNumberNotAllowedException();

            if (Value + quantity > 200) throw new MaximumLevelAlreadyReachedException();
            return new BuildingLevel(Value + quantity);
        }

        public BuildingLevel Decrease()
        {
            if (Value == 0) throw new MinimumLevelAlreadyReachedException();

            return new BuildingLevel(Value - 1);
        }
        public BuildingLevel DecreaseBy(int quantity)
        {
            if (Value == 0) throw new MinimumLevelAlreadyReachedException();

            if (quantity > Value) throw new SubstractionNotAllowed();

            if (quantity < 0) throw new DecreaseLevelByNegativeNumberNotAllowedException();

            return new BuildingLevel(Value - quantity);

        }



    }
}
