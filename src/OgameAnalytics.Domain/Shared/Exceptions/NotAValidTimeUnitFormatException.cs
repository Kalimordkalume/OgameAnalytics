using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgameAnalytics.Domain.Exceptions;

namespace OgameAnalytics.Domain.Shared.Exceptions;
public class NotAValidTimeUnitFormatException : DomainException
{
    int AttemptedInt;

    public NotAValidTimeUnitFormatException(int attemptedInt) : base(Generate(attemptedInt))
    {
        AttemptedInt = attemptedInt;

    }

    private static string Generate(int attempt)
    {
        return $"The value used for the time unit {attempt} isn't a valid number. Try a positive value.";


    }

}
