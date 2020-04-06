using System;
using System.Collections.Generic;
using Streamx.Linq.SQL.Grammar;
using Streamx.Linq.SQL.Grammar.Configuration;
using Streamx.Linq.SQL.PostgreSQL;

namespace Streamx.Linq.SQL.MySQL {
    public static class SQL {
        // Clauses

        [Function(OmitParentheses = true)]
        public static IClause ON_DUPLICATE_KEY_UPDATE(Action updates) {
            throw new NotSupportedException();
        }

        [Function]
        public static int LENGTH(String expression) {
            throw new NotSupportedException();
        }

        /**
     * Use {@link co.streamx.fluent.SQL.SQL#ALL(Comparable...) ALL} or
     * {@link co.streamx.fluent.SQL.SQL#DISTINCT(Comparable...) DISTINCT} to pass multiple expressions
     */
        [Function(UnderscoresAsBlanks = false)]
        public static String GROUP_CONCAT(IComparable expr) {
            throw new NotSupportedException();
        }

        /**
     * Use {@link co.streamx.fluent.SQL.SQL#ALL(Comparable...) ALL} or
     * {@link co.streamx.fluent.SQL.SQL#DISTINCT(Comparable...) DISTINCT} to pass multiple expressions
     */
        [Function(UnderscoresAsBlanks = false, OmitArgumentsDelimiter = true)]
        public static String GROUP_CONCAT(IComparable expr, IWindowFrame order) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false, OmitArgumentsDelimiter = true)]
        public static String GROUP_CONCAT(IComparable expr,
            [Context(ParameterContext.Inherit, Format = "SEPARATOR {0}")]
            String separator) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false, OmitArgumentsDelimiter = true)]
        public static String GROUP_CONCAT(IComparable expr,
            IWindowFrame order,
            [Context(ParameterContext.Inherit, Format = "SEPARATOR {0}")]
            String separator) {
            throw new NotSupportedException();
        }


        [Function(OmitParentheses = true)]
        public static IInsertClause INSERT(params Modifier[] hints) {
            throw new NotSupportedException();
        }

        // DateTime and Time
        [Function]
        public static DateTime ADDDATE(DateTime date,
            TimeSpan interval) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset ADDDATE(DateTimeOffset date,
            TimeSpan interval) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime ADDTIME(DateTime date,
            TimeSpan time) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset ADDTIME(DateTimeOffset date,
            TimeSpan time) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime CONVERT_TZ(DateTime date,
            String from_tz,
            String to_tz) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTimeOffset CONVERT_TZ(DateTimeOffset date,
            String from_tz,
            String to_tz) {
            throw new NotSupportedException();
        }

        [Function]
        public static int CURDATE() {
            throw new NotSupportedException();
        }

        [Function]
        public static int CURTIME() {
            throw new NotSupportedException();
        }

        [Function]
        public static float CURTIME(int fsp) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime DATE(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset DATE(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DATEDIFF(DateTime from,
            DateTime to) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DATEDIFF(DateTimeOffset from,
            DateTimeOffset to) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime DATE_ADD(DateTime date,
            TimeSpan interval) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTimeOffset DATE_ADD(DateTimeOffset date,
            TimeSpan interval) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String DATE_ADD(String date,
            TimeSpan interval) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String DATE_FORMAT(DateTime date,
            String format) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String DATE_FORMAT(DateTimeOffset date,
            String format) {
            throw new NotSupportedException();
        }

        [Function]
        public static String DAYNAME(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static String DAYNAME(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DAYOFMONTH(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DAYOFMONTH(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DAYOFWEEK(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DAYOFWEEK(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DAYOFYEAR(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DAYOFYEAR(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function(ArgumentsDelimiter = " FROM")]
        public static int EXTRACT(TimeUnit unit,
            DateTime date) {
            throw new NotSupportedException();
        }

        [Function(ArgumentsDelimiter = " FROM")]
        public static int EXTRACT(TimeUnit unit,
            DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String GET_FORMAT(DataTypeNames dateTypeName,
            [Literal] DateFormatType formatType) {
            throw new NotSupportedException();
        }

        [Function]
        public static int HOUR(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int HOUR(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int HOUR(String date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime LAST_DAY(DateTime date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTimeOffset LAST_DAY(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime MAKEDATE(int year,
            int dayofyear) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime MAKETIME(int hour,
            int minute,
            int second) {
            throw new NotSupportedException();
        }

        [Function]
        public static int MICROSECOND(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int MICROSECOND(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int MINUTE(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int MINUTE(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int MONTH(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int MONTH(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static String MONTHNAME(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static String MONTHNAME(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime NOW() {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime NOW(int fsp) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int PERIOD_ADD(int period,
            int nMonths) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int PERIOD_DIFF(int period1,
            int period2) {
            throw new NotSupportedException();
        }

        [Function]
        public static int QUARTER(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int QUARTER(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int SECOND(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int SECOND(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime SEC_TO_TIME(int seconds) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime STR_TO_DATE(String date,
            String format) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime SUBDATE(DateTime date,
            TimeSpan interval) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset SUBDATE(DateTimeOffset date,
            TimeSpan interval) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime SUBDATE(DateTime date,
            int days) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset SUBDATE(DateTimeOffset date,
            int days) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime SUBTIME(DateTime expr1,
            DateTime expr2) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset SUBTIME(DateTimeOffset expr1,
            DateTimeOffset expr2) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime SYSDATE() {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime SYSDATE(int fsp) {
            throw new NotSupportedException();
        }

        [Function]
        public static TimeSpan TIME(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset TIME(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime TIMEDIFF(DateTime expr1,
            DateTime expr2) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset TIMEDIFF(DateTimeOffset expr1,
            DateTimeOffset expr2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static long TO_DAYS(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static long TO_DAYS(DateTime date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static long TO_SECONDS(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static long TO_SECONDS(DateTime date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static long UNIX_TIMESTAMP() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double UNIX_TIMESTAMP(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double UNIX_TIMESTAMP(DateTime date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime UTC_DATE() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime UTC_TIME() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime UTC_TIME(int fsp) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime UTC_TIMESTAMP() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime UTC_TIMESTAMP(int fsp) {
            throw new NotSupportedException();
        }

        [Function]
        public static int WEEK(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int WEEK(DateTimeOffset date,
            int mode) {
            throw new NotSupportedException();
        }

        [Function]
        public static int WEEK(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int WEEK(DateTime date,
            int mode) {
            throw new NotSupportedException();
        }

        [Function]
        public static int WEEKDAY(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int WEEKDAY(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int WEEKOFYEAR(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int WEEKOFYEAR(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int YEAR(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int YEAR(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int YEARWEEK(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int YEARWEEK(DateTimeOffset date,
            int mode) {
            throw new NotSupportedException();
        }

        [Function]
        public static int YEARWEEK(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int YEARWEEK(DateTime date,
            int mode) {
            throw new NotSupportedException();
        }

        public static void RegisterVendorCapabilities(this IConfiguration config) {
            config.Capabilities = new HashSet<Capability>(new[] {Capability.TABLE_AS_ALIAS});

            config.RegisterMethodSubstitution((String s) => s.Length, (String s) => SQL.LENGTH(s));
            config.RegisterMethodSubstitution((DateTime dt) => dt.Month, (DateTime dt) => SQL.MONTH(dt));
            config.RegisterMethodSubstitution((DateTime dt) => dt.Year, (DateTime dt) => SQL.YEAR(dt));
            config.RegisterMethodSubstitution((DateTime dt) => dt.Date, (DateTime dt) => SQL.DATE(dt));
            config.RegisterMethodSubstitution((DateTime dt) => dt.Day, (DateTime dt) => SQL.DAYOFMONTH(dt));
            config.RegisterMethodSubstitution((DateTime dt) => dt.Hour, (DateTime dt) => SQL.HOUR(dt));
            config.RegisterMethodSubstitution((DateTime dt) => dt.Minute, (DateTime dt) => SQL.MINUTE(dt));
            config.RegisterMethodSubstitution((DateTime dt) => dt.Second, (DateTime dt) => SQL.SECOND(dt));
            config.RegisterMethodSubstitution((DateTime dt) => dt.TimeOfDay, (DateTime dt) => SQL.TIME(dt));
            config.RegisterMethodSubstitution((DateTime dt) => dt.DayOfYear, (DateTime dt) => SQL.DAYOFYEAR(dt));
            
            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.Month, (DateTimeOffset dt) => SQL.MONTH(dt));
            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.Year, (DateTimeOffset dt) => SQL.YEAR(dt));
            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.Date, (DateTimeOffset dt) => SQL.DATE(dt));
            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.Day, (DateTimeOffset dt) => SQL.DAYOFMONTH(dt));
            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.Hour, (DateTimeOffset dt) => SQL.HOUR(dt));
            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.Minute, (DateTimeOffset dt) => SQL.MINUTE(dt));
            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.Second, (DateTimeOffset dt) => SQL.SECOND(dt));
            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.TimeOfDay, (DateTimeOffset dt) => SQL.TIME(dt));
            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.DayOfYear, (DateTimeOffset dt) => SQL.DAYOFYEAR(dt));
            config.RegisterGenericCapabilities();
            config.RegisterIdentifierQuoter(s => $"`{s}`");
        }
    }
}
