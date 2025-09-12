using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class SubstractionNotAllowed : DomainException
    {
        public SubstractionNotAllowed() : base(Generate())
        {
        }

        private static string Generate()
        {
            return "The operation is not allowed. You are trying to substract something that ends up in a negative value.";


        }
    }
}
