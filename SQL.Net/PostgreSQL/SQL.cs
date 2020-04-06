using System;
using System.Collections.Generic;
using Streamx.Linq.SQL.Grammar;
using Streamx.Linq.SQL.Grammar.Configuration;

namespace Streamx.Linq.SQL.PostgreSQL {
    public static class SQL {
        [Function]
        public static IConflictAction ON_CONFLICT<T>([Context(ParameterContext.Alias)] T expression) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static T LATERAL<T>(T subQuery) {
            throw new NotSupportedException();
        }

        // String

        [Function]
        public static String CHR(int charCode) {
            throw new NotSupportedException();
        }

        [Function]
        public static String CONVERT_FROM(String expression,
            String sourceCharSet) {
            throw new NotSupportedException();
        }

        [Function]
        public static String CONVERT_TO(String expression,
            String destinationCharSet) {
            throw new NotSupportedException();
        }

        [Function]
        public static String CONVERT(String expression,
            String destinationCharSet,
            String sourceCharSet) {
            throw new NotSupportedException();
        }

        [Function]
        public static String DECODE(String expression,
            String format) {
            throw new NotSupportedException();
        }

        [Function]
        public static String ENCODE(String expression,
            String format) {
            throw new NotSupportedException();
        }

        [Function]
        public static String FORMAT(String format,
            params Object[] arguments) {
            throw new NotSupportedException();
        }

        [Function]
        public static String INITCAP(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static int LENGTH(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static int LENGTH(String expression,
            String encoding) {
            throw new NotSupportedException();
        }

        [Function]
        public static String LPAD(String expression,
            int length) {
            throw new NotSupportedException();
        }

        [Function]
        public static String LPAD(String expression,
            int length,
            String padWith) {
            throw new NotSupportedException();
        }

        [Function]
        public static String MD5(String expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_REPLACE(String expression,
            String pattern,
            String replaceExpression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_REPLACE(String expression,
            String pattern,
            String replaceExpression,
            String flags) {
            throw new NotSupportedException();
        }

        [Function]
        public static String RPAD(String expression,
            int length) {
            throw new NotSupportedException();
        }

        [Function]
        public static String RPAD(String expression,
            int length,
            String padWith) {
            throw new NotSupportedException();
        }

        [Function(ArgumentsDelimiter = " IN")]
        public static int POSITION(String expressionToFind,
            String expressionToSearch) {
            throw new NotSupportedException();
        }

        [Function]
        public static String REPEAT(String expression,
            int count) {
            throw new NotSupportedException();
        }

        [Function]
        public static int STRPOS(String expressionToFind,
            String expressionToSearch) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int STARTS_WITH(String expression,
            String prefix) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTR(String expression,
            int from,
            int count) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTR(String expression,
            int from) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(Object expression,
            String format) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime TO_DATE(String expression,
            String format) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_HEX(int integralExpression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int TO_NUMBER(String expression,
            String format) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTimeOffset TO_TIMESTAMP(String expression,
            String format) {
            throw new NotSupportedException();
        }

        /**
     * Special EXCLUDED table is used to reference values originally proposed for insertion.
     * 
     * @see <a href="https://www.postgresql.org/docs/current/sql-insert.html">SQL INSERT</a>
     * 
     *      <blockquote>To use, cast it to the table being updated, e.g.
     * 
     *      <pre>
     * {@code
     *     Distributor excluded = EXCLUDED();
     *     // and later access it's properties as usual:
     *     excluded.getDname()
     * }
     * </pre>
     * 
     * </blockquote>
     */
        [Function(OmitParentheses = true)]
        public static T EXCLUDED<T>() {
            throw new NotSupportedException();
        }

        [Function]
        public static T GREATEST<T>(params T[] expressions) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function]
        public static T LEAST<T>(params T[] expressions) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static IEntitySelectClause<T> RETURNING<T>(T entity,
            params IAlias[] expressions) where T : class, new() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<T> RETURNING<T>(T expression) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2)> RETURNING<T1, T2>((T1, T2) expression)
            where T1 : IComparable
            where T2 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3)> RETURNING<T1, T2, T3>((T1, T2, T3) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3, T4)> RETURNING<T1, T2, T3, T4>((T1, T2, T3, T4) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable
            where T4 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3, T4, T5)> RETURNING<T1, T2, T3, T4, T5>((T1, T2, T3, T4, T5) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable
            where T4 : IComparable
            where T5 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3, T4, T5, T6)> RETURNING<T1, T2, T3, T4, T5, T6>((T1, T2, T3, T4, T5, T6) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable
            where T4 : IComparable
            where T5 : IComparable
            where T6 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static IEntitySelectClause<T> RETURNING<T>(params IAlias[] expressions)
            where T : class, new() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false, RequiresAlias = true)]
        public static T GENERATE_SERIES<T>(T start,
            T stop) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false, RequiresAlias = true)]
        public static T GENERATE_SERIES<T>(T start,
            T stop,
            T step) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static void LIMIT(long rowCount) {
            throw new NotSupportedException();
        }

        // Math

        [Function]
        public static T DIV<T>(T x,
            T y) {
            throw new NotSupportedException();
        }

        [Function]
        public static T LN<T>(T numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static T MOD<T>(T x,
            T y) {
            throw new NotSupportedException();
        }

        [Function]
        public static double RANDOM() {
            throw new NotSupportedException();
        }

        // DateTime / Time

        /**
     * 1970-01-01 00:00:00+00 (Unix system time zero)
     */
        [Function(OmitParentheses = true)]
        public static DateTime EPOCH() {
            throw new NotSupportedException();
        }

        /**
     * later than all other time stamps
     */
        [Function(OmitParentheses = true)]
        public static DateTime INFINITY() {
            throw new NotSupportedException();
        }

        /**
     * earlier than all other time stamps
     */
        [Function("-INFINITY", OmitParentheses = true)]
        public static DateTime negativeINFINITY() {
            throw new NotSupportedException();
        }

        /**
     * current transaction's start time
     */
        [Function]
        public static DateTime NOW() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false, OmitParentheses = true)]
        public static DateTime CURRENT_TIME() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static DateTime LOCALTIME() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static DateTimeOffset LOCALTIMESTAMP() {
            throw new NotSupportedException();
        }

        [Function(ArgumentsDelimiter = " FROM")]
        public static int EXTRACT(DatePart datePart,
            DateTime datetime) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int DATE_TRUNC([Literal] DatePart datePart,
            DateTime datetime) {
            throw new NotSupportedException();
        }

        [Operator]
        [Function(OmitParentheses = true)]
        public static bool OVERLAPS((DateTime?, DateTime?) range1,
            (DateTime?, DateTime?) tange2) {
            throw new NotSupportedException();
        }

        [Operator]
        [Function(OmitParentheses = true)]
        public static bool IS_DISTINCT_FROM<T>(T expr1,
            T expr2) {
            throw new NotSupportedException();
        }

        // Aggregate / statistics

        [Function]
        public static double CORR(Object x,
            Object y) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double COVAR_POP(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double COVAR_SAMP(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_SLOPE(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_INTERCEPT(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int REGR_COUNT(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_R2(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_AVGX(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_AVGY(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_SXX(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_SYY(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_SXY(double y,
            double x) {
            throw new NotSupportedException();
        }

        [Function]
        public static T MODE<T>() where T : IComparable {
            throw new NotSupportedException();
        }

        // Sequence Manipulation Functions
        [Function]
        public static long CURRVAL(String sequence) {
            throw new NotSupportedException();
        }

        [Function]
        public static long LASTVAL() {
            throw new NotSupportedException();
        }

        [Function]
        public static long NEXTVAL(String sequence) {
            throw new NotSupportedException();
        }

        [Function]
        public static long SETVAL(String sequence,
            long value) {
            throw new NotSupportedException();
        }

        [Function]
        public static long SETVAL(String sequence,
            long value,
            bool isCalled) {
            throw new NotSupportedException();
        }

        public static void RegisterVendorCapabilities(this IConfiguration config) {
            config.Capabilities = new HashSet<Capability>(new[] {
                Capability.ALIAS_INSERT, Capability.ALIAS_UPDATE, Capability.ALIAS_DELETE, Capability.TABLE_AS_ALIAS
            });

            config.RegisterMethodSubstitution((String s) => s.Length, (String s) => SQL.LENGTH(s));
            config.RegisterGenericCapabilities();
            config.RegisterIdentifierQuoter(s => $"\"{s}\"");
        }
    }

    public interface IConflictAction {
        [Function(OmitParentheses = true)]
        void DO_NOTHING();

        [Function(OmitParentheses = true)]
        IUpdateSet DO_UPDATE();
    }
}
