using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Planets.Exceptions;
public sealed class PlanetTemperatureOutOfRangeException : DomainException
{
    public int AttemptedMin { get; }
    public int AttemptedMax { get; }

    public PlanetTemperatureOutOfRangeException(int attemptedMin, int attemptedMax, int minAllowed, int maxAllowed)
        : base(Generate(attemptedMin, attemptedMax, minAllowed, maxAllowed))
    {
        AttemptedMin = attemptedMin;
        AttemptedMax = attemptedMax;

    }

    private static string Generate(int attemptedMin, int attemptedMax, int minAllowed, int maxAllowed)
    {
        if (attemptedMin < minAllowed || attemptedMax > maxAllowed)
        {
            return $"Temperature range [{attemptedMin}, {attemptedMax}] is invalid. " +
                   $"Allowed bounds are [{minAllowed}, {maxAllowed}].";
        }

        if (attemptedMin > attemptedMax)
        {
            return $"Temperature range [{attemptedMin}, {attemptedMax}] is invalid. " +
                   $"Lower bound cannot be greater than upper bound.";
        }

        return $"Temperature range [{attemptedMin}, {attemptedMax}] is invalid.";
    }
}
