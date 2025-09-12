using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgameAnalytics.Domain.Shared.Exceptions;

namespace OgameAnalytics.Domain.Shared.ValueObject;
public record TimeUnit
{
    // We will always work with seconds. A valid time unit wherever its come from must be transformed into TimeUnit with its Value in Seconds.
    // Use the provided factory methods according the different needs.

    public ulong Value { get; set; }

    private TimeUnit(ulong value) => Value = value;



    public static TimeUnit FromHours(ulong hours)
    {
        return new TimeUnit(hours * 3600);

    }

    public static TimeUnit FromHours(double hours)
    {
        return new TimeUnit((ulong)(hours * 3600));

    }

    public static TimeUnit FromHours(int hours)
    {
        if (hours < 0) throw new NotAValidTimeUnitFormatException(hours);
        return new TimeUnit((ulong)hours * 3600);

    }

}
