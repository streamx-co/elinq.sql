using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Streamx.Linq.SQL.Grammar;
using Streamx.Linq.SQL.Grammar.Configuration;

namespace Streamx.Linq.SQL {
    public static class SQL {
        
        /// <summary>
        /// Generates SQL <code>SELECT *</code> clause. 
        /// </summary>
        [Function(OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static IEntitySelectClause<T> SELECT<T>(T entity,
            params IAlias[] expressions) where T : class, new() {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Generates SQL <code>SELECT</code> clause without aliases. 
        /// </summary>
        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<T> SELECT<T>(T expression) where T : IComparable {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Generates SQL <code>SELECT</code> clause without aliases. 
        /// </summary>
        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<T?> SELECT<T>(T? expression) where T : struct, IComparable {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Generates SQL <code>SELECT</code> clause. 
        /// </summary>
        [Function(OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static IEntitySelectClause<T> SELECT<T>(params IAlias[] expressions)
            where T : class, new() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static T DISTINCT<T>(T entity, params IAlias[] expressions) where T : class, new() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static T DISTINCT<T>(T expression) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static T? DISTINCT<T>(T? expression) where T : struct, IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static T DISTINCT<T>(params IAlias[] expressions)
            where T : class, new() {
            throw new NotSupportedException();
        }

        [Function("", OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static T ALL<T>(T entity, params IAlias[] expressions) where T : class, new() {
            throw new NotSupportedException();
        }

        [Function("", OmitParentheses = true)]
        public static T ALL<T>(T expression) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function("", OmitParentheses = true)]
        public static T? ALL<T>(T? expression) where T : struct, IComparable {
            throw new NotSupportedException();
        }

        [Function("", OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static T ALL<T>(params IAlias[] expressions)
            where T : class, new() {
            throw new NotSupportedException();
        }

        [Function]
        public static T ROW<T>(T expression)
            where T : struct, ITuple {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ILockingClause FOR(LockStrength lockStrength) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IVersioningClause FOR(Versioning versioning) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true, ParameterContext = ParameterContext.From)]
        public static IJoinClause FROM<T>(T entity, params object[] entities) where T : class {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IWhereClause WHERE(bool condition) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IHavingClause HAVING(bool condition) {
            throw new NotSupportedException();
        }

        [Function("ORDER BY", OmitParentheses = true)]
        public static IWindowFrame ORDER(params ISortOrder[] sorts) {
            throw new NotSupportedException();
        }

        [Function("", OmitParentheses = true)]
        public static IBy BY(IComparable expression) {
            throw new NotSupportedException();
        }

        [Function("PARTITION BY", OmitParentheses = true)]
        public static IWindowOrder PARTITION(params IBy[] expressions) {
            throw new NotSupportedException();
        }

        [Function("GROUP BY", OmitParentheses = true)]
        public static IGroupByClause GROUP(params IBy[] expressions) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IInsertClause INSERT() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true,
            ParameterContext = ParameterContext.FromWithoutAlias,
            ParameterContextCapabilities = new[] {nameof(Capability.ALIAS_UPDATE)})]
        public static IUpdateSet UPDATE<T>(T tableReference) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true, RequiresAlias = true)]
        public static T VALUES<T>(params T[] rows) where T : struct, ITuple {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IComparable DEFAULT() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static T DEFAULT<T>() {
            throw new NotSupportedException();
        }

        [Function]
        public static IGroupingSet CUBE(params IComparable[] expressions) {
            throw new NotSupportedException();
        }

        [Function]
        public static IGroupingSet ROLLUP(params IComparable[] expressions) {
            throw new NotSupportedException();
        }

        [Function]
        public static IComparable GROUPING_SETS(params IGroupingSet[] expressions) {
            throw new NotSupportedException();
        }

        [Function("")]
        public static IGroupingSet SET(params IComparable[] expressions) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IDeleteClause DELETE(params Keyword[] hints) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IOffset OFFSET(int offset) {
            throw new NotSupportedException();
        }

        [CommonTableExpression(CommonTableExpressionType.Declaration)]
        public static void WITH(params Object[] subQueries) {
            throw new NotSupportedException();
        }

        [CommonTableExpression(CommonTableExpressionType.Declaration)]
        public static void WITH(Keyword inject, params Object[] subQueries) {
            throw new NotSupportedException();
        }

        [CommonTableExpression(CommonTableExpressionType.Decorator)]
        [Function(OmitParentheses = true)]
        public static T RECURSIVE<T>(T cte) {
            throw new NotSupportedException();
        }

        public static void RegisterGenericCapabilities(this IConfiguration config) {


            config.RegisterMethodSubstitution((ICollection<int> c, int item) => c.Contains(item), (ICollection<int> c, int i) => Operators.IN(i, c));
            config.RegisterMethodSubstitution((IEnumerable<int> c, int item) => c.Contains(item), (IEnumerable<int> c, int i) => Operators.IN(i, c));
            config.RegisterMethodSubstitution((IEnumerable<int> c) => c.Any(), (IEnumerable<int> c) => Operators.EXISTS(c));

            config.RegisterMethodSubstitution((Object s1, Object s2) => String.Concat(s1, s2),
                (Object s1, Object s2) => ScalarFunctions.CONCAT((String) s1, (String) s2));
            config.RegisterMethodSubstitution((Object s1, Object s2, Object s3) => String.Concat(s1, s2, s3),
                (Object s1, Object s2, Object s3) => ScalarFunctions.CONCAT((String) s1, (String) s2, (String) s3));
            config.RegisterMethodSubstitution((Object s1, Object s2, Object s3, Object s4) => String.Concat(s1, s2, s3, s4),
                (Object s1, Object s2, Object s3, Object s4) => ScalarFunctions.CONCAT((String) s1, (String) s2, (String) s3, (String) s4));
            config.RegisterMethodSubstitution((Object s1, Object s2, Object s3, Object s4, Object s5) => String.Concat(s1, s2, s3, s4, s5),
                (Object s1, Object s2, Object s3, Object s4, Object s5) =>
                    ScalarFunctions.CONCAT((String) s1, (String) s2, (String) s3, (String) s4, (String) s5));

            config.RegisterMethodSubstitution((string s1) => s1.ToLower(), (string s1) => ScalarFunctions.LOWER(s1));
            config.RegisterMethodSubstitution((string s1) => s1.ToLowerInvariant(), (string s1) => ScalarFunctions.LOWER(s1));
            config.RegisterMethodSubstitution((string s1) => s1.ToUpper(), (string s1) => ScalarFunctions.UPPER(s1));
            config.RegisterMethodSubstitution((string s1) => s1.ToUpperInvariant(), (string s1) => ScalarFunctions.UPPER(s1));

            config.RegisterMethodSubstitution((string s1, string s2, string s3) => s1.Replace(s2, s3),
                (string s1, string s2, string s3) => ScalarFunctions.REPLACE(s1, s2, s3));

            config.RegisterMethodSubstitution((string s1) => s1.Trim(), (string s1) => ScalarFunctions.TRIM(s1));
            config.RegisterMethodSubstitution((string s1) => s1.TrimEnd(), (string s1) => ScalarFunctions.RTRIM(s1));
            config.RegisterMethodSubstitution((string s1) => s1.TrimStart(), (string s1) => ScalarFunctions.LTRIM(s1));
            config.RegisterMethodSubstitution((string s1, string s2) => s1.Contains(s2), (string s1, string s2) => Operators.LIKE(s1, '%' + s2 + '%'));
            config.RegisterMethodSubstitution((string s1, string s2) => s1.StartsWith(s2), (string s1, string s2) => Operators.LIKE(s1, s2 + '%'));
            config.RegisterMethodSubstitution((string s1, string s2) => s1.EndsWith(s2), (string s1, string s2) => Operators.LIKE(s1, '%' + s2));

        }
    }

    public interface IOffset {
        [Function(OmitParentheses = true)]
        IFetchNext ROWS();
    }

    public interface IFetchNext {
        [Function(OmitParentheses = true)]
        IFetch FETCH_NEXT(int rowCount);
    }

    public interface IFetch {
        [Function(OmitParentheses = true)]
        IClause ROWS_ONLY();

        [Function(OmitParentheses = true)]
        IClause ROWS_WITH_TIES();
    }
}
