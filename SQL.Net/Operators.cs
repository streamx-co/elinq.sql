using System;
using System.Collections.Generic;
using Streamx.Linq.SQL.Grammar;

// ReSharper disable InconsistentNaming

namespace Streamx.Linq.SQL {
    public static class Operators {
        // Set operators
        
        /// <summary>
        /// Check your vendor support
        /// </summary>
        [Function(OmitParentheses = true)]
        public static void EXCEPT() {
            throw new NotSupportedException();
        }
        
        /// <summary>
        /// Check your vendor support
        /// </summary>
        [Function(OmitParentheses = true)]
        public static void EXCEPT_ALL() {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Check your vendor support
        /// </summary>
        [Function(OmitParentheses = true)]
        public static void INTERSECT() {
            throw new NotSupportedException();
        }
        
        /// <summary>
        /// Check your vendor support
        /// </summary>
        [Function(OmitParentheses = true)]
        public static void INTERSECT_ALL() {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Same as UNION DISTINCT
        /// </summary>
        [Function(OmitParentheses = true)]
        public static void UNION() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static void UNION_ALL() {
            throw new NotSupportedException();
        }

        // Logical operators
        [Function(OmitParentheses = true)]
        public static T ALL<T>(IEnumerable<T> subQuery) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function]
        [Operator(OmitParentheses = true)]
        public static bool AND(bool left,
            bool right) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static T ANY<T>(IEnumerable<T> subQuery) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function(ArgumentsDelimiter = " AND")]
        [Operator(OmitParentheses = true)]
        public static bool BETWEEN<T>(T expressionToMatch,
            T lowLimit,
            T highLimit) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function(ArgumentsDelimiter = " AND")]
        [Operator(OmitParentheses = true)]
        public static bool BETWEEN<T>(T? expressionToMatch,
            T lowLimit,
            T highLimit) where T : struct, IComparable {
            throw new NotSupportedException();
        }

        [Function]
        [Operator(OmitParentheses = true)]
        public static String COLLATE(String expression,
            String collation) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static bool EXISTS(Object subQuery) {
            throw new NotSupportedException();
        }

        /*[Function]
        [Operator]
        public static bool IN<T>(T expressionToMatch,
            params T[] valuesOrCollectionOrSubQuery) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function]
        [Operator]
        public static bool IN<T>(T? expressionToMatch,
            params T[] valuesOrCollectionOrSubQuery) where T : struct, IComparable {
            throw new NotSupportedException();
        }*/

        [Function]
        [Operator(OmitParentheses = true)]
        public static bool IN<T>(T expressionToMatch,
            IEnumerable<T> collection) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function]
        [Operator(OmitParentheses = true)]
        public static bool IN<T>(T? expressionToMatch,
            IEnumerable<T> collection) where T : struct, IComparable {
            throw new NotSupportedException();
        }

        [Function]
        [Operator(OmitParentheses = true)]
        public static bool LIKE(String stringToMatch,
            String pattern) {
            throw new NotSupportedException();
        }

        [Function(ArgumentsDelimiter = " ESCAPE")]
        [Operator(OmitParentheses = true)]
        public static bool LIKE(String stringToMatch,
            String pattern,
            char escapeCharacter) {
            throw new NotSupportedException();
        }

        [Function]
        [Operator(OmitParentheses = true)]
        public static bool SIMILAR_TO(String stringToMatch,
            String pattern) {
            throw new NotSupportedException();
        }

        [Function(ArgumentsDelimiter = " ESCAPE")]
        [Operator(OmitParentheses = true)]
        public static bool SIMILAR_TO(String stringToMatch,
            String pattern,
            char escapeCharacter) {
            throw new NotSupportedException();
        }

        [Function]
        [Operator(Right = false)]
        public static bool NOT(bool expression) {
            throw new NotSupportedException();
        }

        [Function]
        [Operator(OmitParentheses = true)]
        public static bool OR(bool left, bool right) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static T SOME<T>(IEnumerable<T> subQuery) {
            throw new NotSupportedException();
        }

        // relational comparison

        [Function("=")]
        [Operator(OmitParentheses = true)]
        public static bool equal(this IComparable left, IComparable right) =>
            throw new NotSupportedException();

        [Function("!=")]
        [Operator(OmitParentheses = true)]
        public static bool notEqual(this IComparable left, IComparable right) =>
            throw new NotSupportedException();

        [Function("<")]
        [Operator(OmitParentheses = true)]
        public static bool less(this IComparable left, IComparable right) =>
            throw new NotSupportedException();

        [Function("<=")]
        [Operator(OmitParentheses = true)]
        public static bool lessEqual(this IComparable left, IComparable right) =>
            throw new NotSupportedException();

        [Function(">")]
        [Operator(OmitParentheses = true)]
        public static bool greater(this IComparable left, IComparable right) =>
            throw new NotSupportedException();

        [Function(">=")]
        [Operator(OmitParentheses = true)]
        public static bool greaterEqual(this IComparable left, IComparable right) =>
            throw new NotSupportedException();
        
        // Date / Time
        
        [Function("AT TIME ZONE")]
        [Operator(OmitParentheses = true)]
        public static DateTime atTimeZone(this DateTime dt, String timeZone) =>
                throw new NotSupportedException();

        /// <summary>
        /// A shortcut for <code>atTimeZone("UTC")</code>
        /// </summary>
        public static DateTime atUTC(this DateTime dt) => dt.atTimeZone("UTC");
        
        [Function("AT TIME ZONE")]
        [Operator(OmitParentheses = true)]
        public static DateTimeOffset atTimeZone(this DateTimeOffset dt, String timeZone) =>
                throw new NotSupportedException();
        
        /// <summary>
        /// A shortcut for <code>atTimeZone("UTC")</code>
        /// </summary>
        public static DateTimeOffset atUTC(this DateTimeOffset dt) => dt.atTimeZone("UTC");
    }
}
