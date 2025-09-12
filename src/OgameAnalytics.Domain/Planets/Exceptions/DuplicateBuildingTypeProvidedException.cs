using OgameAnalytics.Domain.Buildings.Enums;
using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions
{
    public class DuplicateBuildingTypeProvidedException : DomainException
    {
        public ResourceBuilding AttemptedKey;
        public DuplicateBuildingTypeProvidedException(ResourceBuilding attemptedKey) : base(GenerateMessage(attemptedKey))
        {
            AttemptedKey = attemptedKey;
        }


        private static string GenerateMessage(ResourceBuilding attemptedKey)

        {
            return $"{attemptedKey} is already present on the collection. The collection must have uniques values.";
        }
    }
}
