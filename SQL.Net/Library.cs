using System;
using System.Collections.Generic;
using Streamx.Linq.SQL.Grammar;
using static Streamx.Linq.SQL.SQL;
using static Streamx.Linq.SQL.Directives;

namespace Streamx.Linq.SQL {
    public static class Library {
        /// <summary>
        /// Create projection returning a single value (assuming the result has only single row)
        /// </summary>
        public static TProperty PickSingle<TEntity, TProperty>(TEntity entity, TProperty expression)
            where TEntity : class, new()
            where TProperty : IComparable {
            return SubQuery(() => {
                var r = SELECT(expression);
                FROM(entity);
                return r.AsSingle();
            });
        }

        /// <summary>
        /// Create projection returning a single value (assuming the result has only single row)
        /// </summary>
        public static TProperty? PickSingle<TEntity, TProperty>(TEntity entity, TProperty? expression)
            where TEntity : class, new()
            where TProperty : struct, IComparable {
            return SubQuery(() => {
                var r = SELECT(expression);
                FROM(entity);
                return r.AsSingle();
            });
        }

        /// <summary>
        /// Create projection returning a collection (e.g. column)
        /// </summary>
        public static ICollection<TProperty> PickMany<TEntity, TProperty>(TEntity entity, TProperty expression)
            where TEntity : class, new()
            where TProperty : IComparable {
            return SubQuery(() => {
                var r = SELECT(expression);
                FROM(entity);
                return r.AsCollection();
            });
        }

        /// <summary>
        /// Create projection returning a collection (e.g. column)
        /// </summary>
        public static ICollection<TProperty> PickMany<TEntity, TProperty>(TEntity entity, TProperty? expression)
            where TEntity : class, new()
            where TProperty : struct, IComparable {
            return SubQuery(() => {
                var r = SELECT(expression);
                FROM(entity);
                return r.AsCollection();
            });
        }

        private static readonly Keyword ASTERISK = new Keyword("*");

        /// <summary>
        /// A shortcut for COUNT(*)
        /// </summary>
        public static int COUNT() {
            return AggregateFunctions.COUNT(ASTERISK);
        }


        /// <summary>
        /// <para>
        /// A shortcut for
        /// </para>
        /// <code>
        /// SELECT(&lt;tableRef&gt;);
        /// FROM(&lt;tableRef&gt;);
        /// </code>
        /// </summary>
        public static IEntitySelectClause<T> SelectAll<T>(T tableRef) where T : class, new() {
            var r = SELECT(tableRef);
            FROM(tableRef);
            return r;
        }
    }
}
