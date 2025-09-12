using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class DecreaseLevelByNegativeNumberNotAllowedException : DomainException
    {
        public DecreaseLevelByNegativeNumberNotAllowedException() : base(Generate())
        {
        }

        private static string Generate()
        {
            return "You are trying to susbtract a negative number. Operation not allowed. Try the method Increase() or IncreaseBy()";

        }
    }
}
