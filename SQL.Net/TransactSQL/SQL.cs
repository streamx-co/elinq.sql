using System;
using System.Collections.Generic;
using Streamx.Linq.SQL.Grammar;
using Streamx.Linq.SQL.Grammar.Configuration;

namespace Streamx.Linq.SQL.TransactSQL {
    // ReSharper disable once InconsistentNaming
    public static class SQL {
        // Clauses

        [Function(OmitParentheses = true)]
        public static T CROSS_APPLY<T>(T subQuery) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static T OUTER_APPLY<T>(T subQuery) {
            throw new NotSupportedException();
        }

        [Function]
        public static ITopClause TOP(long expression) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IInsertClause INSERT(IWithTiesClause top) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IDeleteClause DELETE(IWithTiesClause top) {
            throw new NotSupportedException();
        }

        // String

        [Function]
        public static String CHAR(int charCode) {
            throw new NotSupportedException();
        }

        [Function]
        public static String NCHAR(int charCode) {
            throw new NotSupportedException();
        }

        [Function]
        public static int CHARINDEX(String expressionToFind,
            String expressionToSearch) {
            throw new NotSupportedException();
        }

        [Function]
        public static int CHARINDEX(String expressionToFind,
            String expressionToSearch,
            int startLocation) {
            throw new NotSupportedException();
        }

        [Function]
        public static int PATINDEX(String patternToFind,
            String expressionToSearch) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DIFFERENCE(String expression1,
            String expression2) {
            throw new NotSupportedException();
        }

        [Function]
        public static String FORMAT(IComparable expression,
            String format) {
            throw new NotSupportedException();
        }

        [Function]
        public static String FORMAT(IComparable expression,
            String format,
            String culture) {
            throw new NotSupportedException();
        }

        [Function]
        public static int LEN(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String REPLICATE(String expression,
            int count) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SOUNDEX(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SPACE(int count) {
            throw new NotSupportedException();
        }

        [Function]
        public static String STR(String numericExpression,
            int length,
            int decimals) {
            throw new NotSupportedException();
        }

        [Function]
        public static String STRING_ESCAPE(String expression,
            String type) {
            throw new NotSupportedException();
        }

        [Function]
        public static ICollection<String> STRING_SPLIT(String expression,
            String separator) {
            throw new NotSupportedException();
        }

        [Function]
        public static String STUFF(String expression,
            int start,
            int length,
            String replaceWithExpression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTRING(String expression,
            int start,
            int length) {
            throw new NotSupportedException();
        }

        [Function]
        public static int UNICODE(String ncharacterExpression) {
            throw new NotSupportedException();
        }

        // Date/Time

        [Function("@@DATEFIRST", OmitParentheses = true)]
        public static int DATEFIRST() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false, OmitParentheses = true)]
        public static String CURRENT_TIMEZONE() {
            throw new NotSupportedException();
        }

        [Function]
        public static int YEAR(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int YEAR(DateTime? date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int YEAR(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int YEAR(DateTimeOffset? date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int MONTH(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int MONTH(DateTime? date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int MONTH(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int MONTH(DateTimeOffset? date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DAY(DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DAY(DateTime? date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DAY(DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DAY(DateTimeOffset? date) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime DATEADD(DatePart datepart,
            int delta,
            DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset DATEADD(DatePart datepart,
            int delta,
            DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DATEDIFF(DatePart datepart,
            DateTime from,
            DateTime to) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DATEDIFF(DatePart datepart,
            DateTimeOffset from,
            DateTimeOffset to) {
            throw new NotSupportedException();
        }

        [Function]
        public static long DATEDIFF_BIG(DatePart datepart,
            DateTime from,
            DateTime to) {
            throw new NotSupportedException();
        }

        [Function]
        public static long DATEDIFF_BIG(DatePart datepart,
            DateTimeOffset from,
            DateTimeOffset to) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime DATEFROMPARTS(int year,
            int month,
            int day) {
            throw new NotSupportedException();
        }

        [Function]
        // ReSharper disable once InconsistentNaming
        public static DateTime DATETIME2FROMPARTS(int year,
            int month,
            int day,
            int hour,
            int minute,
            int seconds,
            int fractions,
            int precision) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime DATETIMEFROMPARTS(int year,
            int month,
            int day,
            int hour,
            int minute,
            int seconds,
            int milliseconds) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset DATETIMEOFFSETFROMPARTS(int year,
            int month,
            int day,
            int hour,
            int minute,
            int seconds,
            int fractions,
            int hourOffset,
            int minuteOffset,
            int precision) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime SMALLDATETIMEFROMPARTS(int year,
            int month,
            int day,
            int hour,
            int minute) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset TIMEFROMPARTS(int hour,
            int minute,
            int seconds,
            int fractions,
            int precision) {
            throw new NotSupportedException();
        }

        [Function]
        public static String DATENAME(DatePart datepart,
            DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static String DATENAME(DatePart datepart,
            DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static String DATENAME(DatePart datepart,
            int date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DATEPART(DatePart datepart,
            DateTime date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DATEPART(DatePart datepart,
            DateTimeOffset date) {
            throw new NotSupportedException();
        }

        [Function]
        public static int DATEPART(DatePart datepart,
            int date) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime GETDATE() {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime GETUTCDATE() {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime SYSDATETIME() {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset SYSDATETIMEOFFSET() {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime SYSUTCDATETIME() {
            throw new NotSupportedException();
        }

        [Function]
        public static bool ISDATE(Object expression) {
            throw new NotSupportedException();
        }

        // System

        [Function]
        public static int CHECKSUM(params IComparable[] expressions) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int BINARY_CHECKSUM(params IComparable[] expressions) {
            throw new NotSupportedException();
        }

        [Function]
        public static String HASHBYTES([Literal] HashingAlgorithm hashingAlgorithm,
            Object expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static int ISNULL<T>(T checkExpression, T replacementValue) {
            throw new NotSupportedException();
        }

        [Function]
        public static int ISNUMERIC(IComparable expression) {
            throw new NotSupportedException();
        }

        // Logical

        [Function]
        public static T CHOOSE<T>(int index,
            params T[] expressions) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function]
        public static T IIF<T>(bool condition,
            T ifTrue,
            T otherwise) where T : IComparable {
            throw new NotSupportedException();
        }

        // Aggregate

        [Function(UnderscoresAsBlanks = false)]
        public static int GROUPING_ID(params IComparable[] expressions) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int CHECKSUM_AGG(Object expression) {
            throw new NotSupportedException();
        }

        // Math

        [Function]
        public static double ATN2(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function]
        public static double LOG10(double numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static double RAND() {
            throw new NotSupportedException();
        }

        [Function]
        public static double RAND(int seed) {
            throw new NotSupportedException();
        }

        [Function]
        public static double SQUARE(double numeric) {
            throw new NotSupportedException();
        }

        // General
        // OUTPUT Clause
        [Function(OmitParentheses = true), Tuple]
        public static T INSERTED<T>() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true), Tuple]
        public static T DELETED<T>() {
            throw new NotSupportedException();
        }

        [Function("$action", OmitParentheses = true)]
        public static MergeAction MergeAction() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static IEntitySelectClause<T> OUTPUT<T>(T entity,
            params IAlias[] expressions) where T : class, new() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<T> OUTPUT<T>(T expression) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2)> OUTPUT<T1, T2>((T1, T2) expression)
            where T1 : IComparable
            where T2 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3)> OUTPUT<T1, T2, T3>((T1, T2, T3) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3, T4)> OUTPUT<T1, T2, T3, T4>((T1, T2, T3, T4) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable
            where T4 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3, T4, T5)> OUTPUT<T1, T2, T3, T4, T5>((T1, T2, T3, T4, T5) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable
            where T4 : IComparable
            where T5 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3, T4, T5, T6)> OUTPUT<T1, T2, T3, T4, T5, T6>((T1, T2, T3, T4, T5, T6) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable
            where T4 : IComparable
            where T5 : IComparable
            where T6 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static IEntitySelectClause<T> OUTPUT<T>(params IAlias[] expressions)
            where T : class, new() {
            throw new NotSupportedException();
        }

        // MERGE declarations (SQL:2003 + extensions)

        [Function(OmitParentheses = true)]
        public static MergeClause MERGE() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static MergeClause MERGE(IWithTiesClause top) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IMatchThen WHEN_MATCHED() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IMatchThen WHEN_MATCHED_AND(bool searchCondition) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IMatchThen WHEN_NOT_MATCHED() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IMatchThen WHEN_NOT_MATCHED_AND(bool searchCondition) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IMatchThen WHEN_NOT_MATCHED_BY_SOURCE() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IMatchThen WHEN_NOT_MATCHED_BY_SOURCE_AND(bool searchCondition) {
            throw new NotSupportedException();
        }

        /**
     * Used in {@link SQL#MERGE()} only
     * Name changed to avoid clashing
     */
        [Function("UPDATE", OmitParentheses = true)]
        public static IUpdateSet MERGE_UPDATE() {
            throw new NotSupportedException();
        }

        /**
     * Used in {@link SQL#MERGE()} only<br/>
     * Name changed to avoid clashing with {@link co.streamx.fluent.SQL.SQL#INSERT(co.streamx.fluent.notation.Keyword...)
     * INSERT}
     */
        [Function("INSERT", OmitParentheses = true, OmitArgumentsDelimiter = true)]
        public static IClause MERGE_INSERT<TE, T>(IColumnsClause<TE, T> columns,
            T values) {
            throw new NotSupportedException();
        }

        // Sequence
        sealed class SequenceImpl<T> : ISequence<T> where T : IComparable<T> {
            private readonly String name;

            public SequenceImpl(string name) => this.name = name;

            public override string ToString() => name;
        }

        [Local]
        public static ISequence<T> Sequence<T>(String name) where T : IComparable<T> {
            return new SequenceImpl<T>(name);
        }

        [Function(OmitParentheses = true)]
        public static IWindowOver<T> NEXT_VALUE_FOR<T>(ISequence<T> sequence) where T : IComparable, IComparable<T> {
            throw new NotSupportedException();
        }

        public static void RegisterVendorCapabilities(this IConfiguration config) {
            config.Capabilities = new HashSet<Capability>(new[] {Capability.TABLE_AS_ALIAS});

            config.RegisterMethodSubstitution((String s) => s.Length, (String s) => SQL.LEN(s));
            config.RegisterMethodSubstitution((String s, int start, int length) => s.Substring(start, length),
                (String s, int start, int length) => SQL.SUBSTRING(s, start, length));
            config.RegisterMethodSubstitution((DateTime dt) => dt.Month, (DateTime dt) => SQL.MONTH(dt));
            config.RegisterMethodSubstitution((DateTime dt) => dt.Year, (DateTime dt) => SQL.YEAR(dt));
            config.RegisterMethodSubstitution((DateTime dt) => dt.Day, (DateTime dt) => SQL.DAY(dt));

            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.Month, (DateTimeOffset dt) => SQL.MONTH(dt));
            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.Year, (DateTimeOffset dt) => SQL.YEAR(dt));
            config.RegisterMethodSubstitution((DateTimeOffset dt) => dt.Day, (DateTimeOffset dt) => SQL.DAY(dt));
            config.RegisterGenericCapabilities();
            config.RegisterIdentifierQuoter(s => $"[{s}]");
        }
    }
}
