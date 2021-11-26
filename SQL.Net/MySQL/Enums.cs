// ReSharper disable InconsistentNaming

using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL.MySQL {
public enum DateFormatType {
    EUR,
    USA,
    JIS,
    ISO,
    INTERNAL
}

public sealed class TimeUnit : Keyword {
    public static readonly TimeUnit
            MICROSECOND        = new TimeUnit("MICROSECOND"),
            SECOND             = new TimeUnit("SECOND"),
            MINUTE             = new TimeUnit("MINUTE"),
            HOUR               = new TimeUnit("HOUR"),
            DAY                = new TimeUnit("DAY"),
            WEEK               = new TimeUnit("WEEK"),
            MONTH              = new TimeUnit("MONTH"),
            QUARTER            = new TimeUnit("QUARTER"),
            YEAR               = new TimeUnit("YEAR"),
            SECOND_MICROSECOND = new TimeUnit("SECOND_MICROSECOND"),
            MINUTE_MICROSECOND = new TimeUnit("MINUTE_MICROSECOND"),
            MINUTE_SECOND      = new TimeUnit("MINUTE_SECOND"),
            HOUR_MICROSECOND   = new TimeUnit("HOUR_MICROSECOND"),
            HOUR_SECOND        = new TimeUnit("HOUR_SECOND"),
            HOUR_MINUTE        = new TimeUnit("HOUR_MINUTE"),
            DAY_MICROSECOND    = new TimeUnit("DAY_MICROSECOND"),
            DAY_SECOND         = new TimeUnit("DAY_SECOND"),
            DAY_MINUTE         = new TimeUnit("DAY_MINUTE"),
            DAY_HOUR           = new TimeUnit("DAY_HOUR"),
            YEAR_MONTH         = new TimeUnit("YEAR_MONTH");

    private TimeUnit(string value) : base(value) { }
}
}
