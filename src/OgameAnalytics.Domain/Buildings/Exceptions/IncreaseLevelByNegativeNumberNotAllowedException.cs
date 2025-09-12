using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class IncreaseLevelByNegativeNumberNotAllowedException : DomainException
    {
        public IncreaseLevelByNegativeNumberNotAllowedException() : base(Generate())
        {
        }

        private static string Generate()
        {
            return "You are trying to add a negative number. Operation not allowed. Try the method Decrease() or DecreaseBy()";
        }
    }
}
