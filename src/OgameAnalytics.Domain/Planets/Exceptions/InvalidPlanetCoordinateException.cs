using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions;
public sealed class InvalidPlanetCoordinateException : DomainException
{
    public int AttemptedGalaxy { get; }
    public int AttemptedSolarSystem { get; }
    public int AttemptedPlanetPosition { get; }

    public InvalidPlanetCoordinateException(
        int attemptedGalaxy,
        int attemptedSolarSystem,
        int attemptedPlanetPosition,
        int[] validGalaxyRange,
        int[] validSolarSystemRange,
        int[] validPlanetPositionRange) : base(Generate(attemptedGalaxy,
            attemptedSolarSystem,
            attemptedPlanetPosition,
            validGalaxyRange,
            validSolarSystemRange,
            validPlanetPositionRange))
    {
        AttemptedGalaxy = attemptedGalaxy;
        AttemptedSolarSystem = attemptedSolarSystem;
        AttemptedPlanetPosition = attemptedPlanetPosition;
    }

    private static string Generate(
        int attemptedGalaxy,
        int attemptedSolarSystem,
        int attemptedPlanetPosition,
        int[] validGalaxyRange,
        int[] validSolarSystemRange,
        int[] validPlanetPositionRange)
    {
        if ((attemptedGalaxy < validGalaxyRange[0]) || (attemptedGalaxy > validGalaxyRange[1]))
            return $"Galaxy input {attemptedGalaxy}, is NOt valid." +
            $"Allowed values are [{validGalaxyRange[0]}, {validGalaxyRange[1]}]";

        if ((attemptedSolarSystem < validSolarSystemRange[0]) || (attemptedSolarSystem > validSolarSystemRange[1]))
            return $"Solar System input {attemptedSolarSystem}, is NOT valid." +
                $"Allowed values are [{validSolarSystemRange[0]},{validSolarSystemRange[1]}]";

        if ((attemptedPlanetPosition < validPlanetPositionRange[0]) || (attemptedPlanetPosition > validPlanetPositionRange[1]))
            return $"Planet Position input {attemptedPlanetPosition} is NOT valid." +
                $"Allowed values are [{validPlanetPositionRange[0]},{validPlanetPositionRange[1]}]";

        return $"Coordinates: [{attemptedGalaxy}:{attemptedSolarSystem}:{attemptedPlanetPosition}] are NOT valid.";

    }
}
