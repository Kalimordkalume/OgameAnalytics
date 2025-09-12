using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class BuildingNameTooShortException : DomainException
    {
        public BuildingNameTooShortException() : base("The selected name is too short. Try with one between [4,255]")
        {
        }
    }
}
