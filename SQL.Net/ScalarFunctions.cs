using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public static class ScalarFunctions {
        // String

        [Function]
        public static int ASCII(String characterExpression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String CONCAT(params IComparable[] expressions) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String CONCAT_WS(String separator,
            params IComparable[] expressions) {
            throw new NotSupportedException();
        }

        [Function]
        public static String LOWER(String characterExpression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String UPPER(String characterExpression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String LTRIM(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String RTRIM(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String LEFT(String expression,
            int length) {
            throw new NotSupportedException();
        }

        [Function]
        public static String RIGHT(String expression,
            int length) {
            throw new NotSupportedException();
        }

        [Function]
        public static String TRIM(String expression) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Use with <see cref="TRIM(ITrim)"/> 
        /// </summary>
        [Function(OmitParentheses = true)]
        public static ITrim BOTH(String expression) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Use with <see cref="TRIM(ITrim)"/> 
        /// </summary>
        [Function(OmitParentheses = true)]
        public static ITrim LEADING() {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Use with <see cref="TRIM(ITrim)"/> 
        /// </summary>
        [Function(OmitParentheses = true)]
        public static ITrim LEADING(String expression) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Use with <see cref="TRIM(ITrim)"/> 
        /// </summary>
        [Function(OmitParentheses = true)]
        public static ITrim TRAILING() {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Use with <see cref="TRIM(ITrim)"/> 
        /// </summary>
        [Function(OmitParentheses = true)]
        public static ITrim TRAILING(String expression) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Example: <code>TRIM(TRAILING("xyz").FROM("barxxyz"))</code>
        /// <seealso cref="LEADING()"/>, <seealso cref="TRAILING()"/>, <seealso cref="BOTH"/>
        /// </summary>
        [Function]
        public static String TRIM(ITrim trim) {
            throw new NotSupportedException();
        }

        [Function]
        public static String REVERSE(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String TRANSLATE(String expression,
            String characters,
            String translations) {
            throw new NotSupportedException();
        }

        [Function]
        public static String REPLACE(String expression,
            String pattern,
            String replacement) {
            throw new NotSupportedException();
        }

        // Mathematical

        [Function]
        public static long ABS(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long ACOS(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long ASIN(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long ATAN(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long CEILING(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long COS(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long COT(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long DEGREES(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long EXP(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long FLOOR(long numeric) {
            throw new NotSupportedException();
        }

        /**
     * Implementation varies between vendors. Some calculate natural, while others base-10 logarithm.
     */
        [Function]
        public static long LOG(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long LOG(long numeric,
            int @base) {
            throw new NotSupportedException();
        }

        [Function]
        public static double PI() {
            throw new NotSupportedException();
        }

        [Function]
        public static long POWER(long numeric,
            int power) {
            throw new NotSupportedException();
        }

        [Function]
        public static long RADIANS(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static T ROUND<T>(T numeric,
            int length) {
            throw new NotSupportedException();
        }

        [Function]
        public static long SIGN(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long SIN(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long SQRT(long numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static long TAN(long numeric) {
            throw new NotSupportedException();
        }

        // Conditional

        [Function(OmitParentheses = true)]
        public static ICaseEnd<T> CASE<T>(IWhen<T> caseExpression) {
            throw new NotSupportedException();
        }

        [Function(ArgumentsDelimiter = " THEN", OmitParentheses = true)]
        public static ICaseWhen<T> WHEN<T>(bool condition,
            T result) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ICaseThenFirst WHEN(bool condition) {
            throw new NotSupportedException();
        }

        [Function]
        public static T COALESCE<T>(params T[] expressions) {
            throw new NotSupportedException();
        }

        [Function]
        public static T NULLIF<T>(T expression1, T expression2) {
            throw new NotSupportedException();
        }

        // Date / Time

        /**
     * Not supported in SQL Server. See <a href=
     * "https://docs.microsoft.com/en-us/sql/t-sql/functions/date-and-time-data-types-and-functions-transact-sql">docs</a>
     */
        [Function(UnderscoresAsBlanks = false, OmitParentheses = true)]
        public static DateTime CURRENT_DATE() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false, OmitParentheses = true)]
        public static DateTime CURRENT_TIMESTAMP() {
            throw new NotSupportedException();
        }

        // Conversion
        [Function(ArgumentsDelimiter = " AS")]
        internal static T CAST<T, TType, TExpression>(TExpression expression, TType dataType)
            where TType : DataType<T>
            where TExpression : IComparable<TExpression> {
            throw new NotSupportedException();
        }
        
        [Function(ArgumentsDelimiter = " AS")]
        internal static T CAST<T, TType, TExpression>(TExpression? expression, TType dataType)
            where TType : DataType<T>
            where TExpression : struct, IComparable<TExpression> {
            throw new NotSupportedException();
        }
    }

    public interface ITrim {
        [Function(OmitParentheses = true)]
        String FROM(String expression);
    }
}
