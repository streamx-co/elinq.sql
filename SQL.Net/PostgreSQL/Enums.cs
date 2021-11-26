using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL.PostgreSQL {
public enum DatePart {
    EPOCH,
    CENTURY,
    DECADE,
    MILLENNIUM,
    YEAR,
    ISOYEAR,
    QUARTER,
    MONTH,
    WEEK,
    DAY,
    DOW,
    DOY,
    ISODOW,
    HOUR,
    MINUTE,
    SECOND,
    MILLISECONDS,
    MICROSECONDS,
    TIMEZONE,
    TIMEZONE_HOUR,
    TIMEZONE_MINUTE,
}

public sealed class TimeUnit : Keyword {
    public static readonly TimeUnit
            MICROSECOND = new TimeUnit("MICROSECOND"),
            MILLISECOND = new TimeUnit("MILLISECOND"),
            SECOND      = new TimeUnit("SECOND"),
            MINUTE      = new TimeUnit("MINUTE"),
            HOUR        = new TimeUnit("HOUR"),
            DAY         = new TimeUnit("DAY"),
            WEEK        = new TimeUnit("WEEK"),
            MONTH       = new TimeUnit("MONTH"),
            QUARTER     = new TimeUnit("QUARTER"),
            YEAR        = new TimeUnit("YEAR"),
            DECADE      = new TimeUnit("DECADE"),
            CENTURY     = new TimeUnit("CENTURY"),
            MILLENNIUM  = new TimeUnit("MILLENNIUM");

    private TimeUnit(string value) : base(value) { }
}
}
