using OgameAnalytics.Domain.Buildings.Exceptions;

namespace OgameAnalytics.Domain.Buildings.ValueObjects
{
    public record class ProductionTime
    {
        public int Years { get; }
        public int Months { get; }
        public int Weeks { get; }
        public int Days { get; }
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        private ProductionTime(int years, int months, int weeks, int days, int hours, int minutes, int seconds)
        {
            Years = years;
            Months = months;
            Weeks = weeks;
            Days = days;
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public static ProductionTime FromMinutesAndSeconds(int minutes, int seconds)
        {
            if ((minutes < 0 || seconds < 0) || (minutes > 60 || seconds > 60))
            {
                throw new InvalidProductionTimeCompositionException($"Minutes and seconds should be lesser than 60 or greater or equal than 0: You have used the current values {{ Minutes: {minutes}, Seconds: {seconds}");
            }
            return new ProductionTime(0, 0, 0, 0, 0, minutes, seconds);
        }
        public static ProductionTime FromHoursMinutesSeconds(int hours, int minutes, int seconds)
        {

            return new ProductionTime(0, 0, 0, 0, hours, minutes, seconds);
        }

        public static ProductionTime FromHours(double hours)
        {
            const double Second = 1;
            const double Minute = Second * 60;
            const double Hour = Minute * 60;
            const double Day = Hour * 24;
            const double Week = Day * 7;
            const double Month = Week * 4;
            const double Year = Day * 365;

            double totalSeconds = GetSecondsFromHours(hours);


            double remaining = totalSeconds;

            double years = remaining / Year;
            remaining %= Year;

            double months = remaining / Month;
            remaining %= Month;

            double weeks = remaining / Week;
            remaining %= Week;

            double days = remaining / Day;
            remaining %= Day;

            double hoursComponent = remaining / Hour;
            remaining %= Hour;

            double minutes = remaining / Minute;
            double seconds = remaining % Minute;

            return new ProductionTime(
                (int)years,
                (int)months,
                (int)weeks,
                (int)days,
                (int)hoursComponent,
                (int)minutes,
                (int)seconds);
        }

        private static double GetSecondsFromHours(double hours)
        {
            return hours * 3600;
        }
    }
}
