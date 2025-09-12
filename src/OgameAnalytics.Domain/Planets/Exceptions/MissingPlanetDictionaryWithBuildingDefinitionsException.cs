using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions
{
    public class MissingPlanetDictionaryWithBuildingDefinitionsException : DomainException
    {
        public MissingPlanetDictionaryWithBuildingDefinitionsException() : base("A planet must have a dictionary with the building definitions.")
        {
        }
    }
}
