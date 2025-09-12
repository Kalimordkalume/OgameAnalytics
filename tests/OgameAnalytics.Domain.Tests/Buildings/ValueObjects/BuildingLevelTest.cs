using OgameAnalytics.Domain.Buildings.Exceptions;
using OgameAnalytics.Domain.Buildings.ValueObjects;

namespace OgameAnalytics.Domain.Tests.Buildings.ValueObjects
{
    public class BuildingLevelTest
    {
        public const int minValue = 0;
        public const int maxValue = 200;

        // Construction Tests
        [Fact]
        public void FromPrimitive_WithNegativeValue_ThrowsLevelCannotBeNegativeException()
        {
            int invalidValue = minValue - 1;
            Assert.Throws<LevelCannotBeNegativeException>(() => BuildingLevel.FromPrimitive(invalidValue));
        }

        [Fact]
        public void FromPrimitive_WithMinValue_CreatesSuccessfully()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(minValue);
            Assert.Equal(minValue, buildingLevel.Value);
        }

        [Fact]
        public void FromPrimitive_WithValidValue_CreatesSuccessfully()
        {
            int validValue = 50;
            var buildingLevel = BuildingLevel.FromPrimitive(validValue);
            Assert.Equal(validValue, buildingLevel.Value);
        }

        [Fact]
        public void FromPrimitive_WithMaxValue_CreatesSuccessfully()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(maxValue);
            Assert.Equal(maxValue, buildingLevel.Value);
        }

        [Fact]
        public void FromPrimitive_WithValueGreaterThanMax_ThrowsLevelIsTooBigException()
        {
            int invalidValue = maxValue + 1;
            Assert.Throws<LevelIsTooBigException>(() => BuildingLevel.FromPrimitive(invalidValue));
        }

        // Increase Tests
        [Fact]
        public void Increase_WithinValidRange_ReturnsIncrementedValue()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(50);
            var increased = buildingLevel.Increase();
            Assert.Equal(51, increased.Value);
        }

        [Fact]
        public void Increase_FromMinValue_ReturnsMinValuePlusOne()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(minValue);
            var increased = buildingLevel.Increase();
            Assert.Equal(minValue + 1, increased.Value);
        }

        [Fact]
        public void Increase_FromMaxValue_ThrowsMaximumLevelAlreadyReachedException()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(maxValue);
            Assert.Throws<MaximumLevelAlreadyReachedException>(() => buildingLevel.Increase());
        }

        // Decrease Tests
        [Fact]
        public void Decrease_WithinValidRange_ReturnsDecrementedValue()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(50);
            var decreased = buildingLevel.Decrease();
            Assert.Equal(49, decreased.Value);
        }

        [Fact]
        public void Decrease_FromMinValue_ThrowsMinimumLevelAlreadyReachedException()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(minValue);
            Assert.Throws<MinimumLevelAlreadyReachedException>(() => buildingLevel.Decrease());
        }

        [Fact]
        public void Decrease_FromMaxValue_ReturnsMaxValueMinusOne()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(maxValue);
            var decreased = buildingLevel.Decrease();
            Assert.Equal(maxValue - 1, decreased.Value);
        }

        // IncreaseBy Tests
        [Fact]
        public void IncreaseBy_ResultExceedsMaxValue_ThrowsMaximumLevelAlreadyReachedException()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(maxValue - 1);
            int increaseAmount = 2;
            Assert.Throws<MaximumLevelAlreadyReachedException>(() => buildingLevel.IncreaseBy(increaseAmount));
        }

        [Fact]
        public void IncreaseBy_WithNegativeAmount_ThrowsIncreaseLevelByNegativeNumberNotAllowedException()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(50);
            int negativeAmount = -1;
            Assert.Throws<IncreaseLevelByNegativeNumberNotAllowedException>(() => buildingLevel.IncreaseBy(negativeAmount));
        }

        [Fact]
        public void IncreaseBy_WithinValidRange_ReturnsCorrectValue()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(50);
            int increaseAmount = 10;
            var increased = buildingLevel.IncreaseBy(increaseAmount);
            Assert.Equal(60, increased.Value);
        }

        [Fact]
        public void IncreaseBy_WithZeroAmount_ReturnsSameValue()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(50);
            int increaseAmount = 0;
            var increased = buildingLevel.IncreaseBy(increaseAmount);
            Assert.Equal(50, increased.Value);
        }

        [Fact]
        public void IncreaseBy_ToExactlyMaxValue_ReturnsMaxValue()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(maxValue - 1);
            int increaseAmount = 1;
            var increased = buildingLevel.IncreaseBy(increaseAmount);
            Assert.Equal(maxValue, increased.Value);
        }

        // DecreaseBy Tests
        [Fact]
        public void DecreaseBy_WithNegativeAmount_ThrowsDecreaseLevelByNegativeNumberNotAllowedException()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(50);
            int negativeAmount = -1;
            Assert.Throws<DecreaseLevelByNegativeNumberNotAllowedException>(() => buildingLevel.DecreaseBy(negativeAmount));
        }

        [Fact]
        public void DecreaseBy_WithZeroAmount_ReturnsSameValue()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(50);
            int decreaseAmount = 0;
            var decreased = buildingLevel.DecreaseBy(decreaseAmount);
            Assert.Equal(50, decreased.Value);
        }

        [Fact]
        public void DecreaseBy_WithinValidRange_ReturnsCorrectValue()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(50);
            int decreaseAmount = 10;
            var decreased = buildingLevel.DecreaseBy(decreaseAmount);
            Assert.Equal(40, decreased.Value);
        }

        [Fact]
        public void DecreaseBy_ToExactlyMinValue_ReturnsMinValue()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(50);
            int decreaseAmount = 50;
            var decreased = buildingLevel.DecreaseBy(decreaseAmount);
            Assert.Equal(minValue, decreased.Value);
        }

        [Fact]
        public void DecreaseBy_AmountGreaterThanCurrentLevel_ThrowsSubstractionNotAllowed()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(50);
            int decreaseAmount = 51;
            Assert.Throws<SubstractionNotAllowed>(() => buildingLevel.DecreaseBy(decreaseAmount));
        }

        [Fact]
        public void DecreaseBy_FromMinValue_ThrowsMinimumLevelAlreadyReachedException()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(minValue);
            int decreaseAmount = 1;
            Assert.Throws<MinimumLevelAlreadyReachedException>(() => buildingLevel.DecreaseBy(decreaseAmount));
        }

        [Fact]
        public void DecreaseBy_FromMaxValue_ReturnsCorrectValue()
        {
            var buildingLevel = BuildingLevel.FromPrimitive(maxValue);
            int decreaseAmount = 10;
            var decreased = buildingLevel.DecreaseBy(decreaseAmount);
            Assert.Equal(maxValue - 10, decreased.Value);
        }

        [Fact]
        public void BuildingLevel_RecordEquality_WorksCorrectly()
        {
            var level1 = BuildingLevel.FromPrimitive(50);
            var level2 = BuildingLevel.FromPrimitive(50);
            var level3 = BuildingLevel.FromPrimitive(51);
            Assert.Equal(level1, level2);
            Assert.NotEqual(level1, level3);
        }
    }
}
