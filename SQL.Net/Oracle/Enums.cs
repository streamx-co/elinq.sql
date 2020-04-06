using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL.Oracle {
    [ToStringFormatter("^", "IGNORE ", IsRegex = true)]
    public enum Ignore {
        NULLS
    }
    
    [Literal]
    public enum Correlation {
        COEFFICIENT,
        ONE_SIDED_SIG,
        ONE_SIDED_SIG_POS,
        ONE_SIDED_SIG_NEG,
        TWO_SIDED_SIG,
    }
    
    [Literal]
    public enum Format {
        /**
     * One greater than the first two digits of a four-digit year
     */
        CC,
        SCC,

        /**
     * Year (rounds up on July 1)
     */
        SYYYY,
        YYYY,
        YEAR,
        SYEAR,
        YYY,
        YY,
        Y,

        /**
     * ISO Year
     */
        IYYY,
        IY,
        I,

        /**
     * Quarter (rounds up on the sixteenth day of the second month of the quarter)
     */
        Q,

        /**
     * Month (rounds up on the sixteenth day)
     */
        MON,
        MONTH,
        MM,
        RM,

        /**
     * Same day of the week as the first day of the year
     */
        WW,

        /**
     * Same day of the week as the first day of the ISO year
     */
        IW,

        /**
     * Same day of the week as the first day of the month
     */
        W,

        /**
     * Day
     */
        DD,
        DDD,
        J,

        /**
     * Starting day of the week
     */
        DAY,
        DY,
        D,

        /**
     * Hour
     */
        HH,
        HH12,
        HH24,

        /**
     * Minute
     */
        MI,
    }
    
    [Literal]
    public enum WeekDay {
       SUNDAY,
       MONDAY,
       TUESDAY,
       WEDNESDAY,
       THURSDAY,
       FRIDAY,
       SATURDAY,
    }
    
    [Literal]
    public enum TimeZone {
       AST,
       ADT, // Atlantic Standard or Daylight Time

       BST,
       BDT, // Bering Standard or Daylight Time

       CST,
       CDT, // Central Standard or Daylight Time

       EST,
       EDT, // Eastern Standard or Daylight Time

       GMT, // Greenwich Mean Time

       HST,
       HDT, // Alaska-Hawaii Standard Time or Daylight Time.

       MST,
       MDT, // Mountain Standard or Daylight Time

       NST, // Newfoundland Standard Time

       PST,
       PDT, // Pacific Standard or Daylight Time

       YST,
       YDT, // Yukon Standard or Daylight Time
    }
    
    [Literal]
    [ToStringFormatter("_", " ")]
    public enum Interval {
       DAY_TO_SECOND,

       DAY_TO_MINUTE,

       DAY_TO_HOUR,

       HOUR_TO_SECOND,

       HOUR_TO_MINUTE,

       MINUTE_TO_SECOND,

       DAY, HOUR, MUNUTE, SECOND,

       YEAR_TO_MONTH,

       YEAR, MONTH,
    }
}
