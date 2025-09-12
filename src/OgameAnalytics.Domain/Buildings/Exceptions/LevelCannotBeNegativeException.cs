using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class LevelCannotBeNegativeException : DomainException
    {
        public LevelCannotBeNegativeException(string message) : base(message)
        {
        }
    }
}
