using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Buildings.Exceptions
{
    public class BuildingNameTooLongException : DomainException
    {


        public BuildingNameTooLongException() : base("Building name is out of range. Try with one in this range: [4,255]")
        {
        }
    }
}
