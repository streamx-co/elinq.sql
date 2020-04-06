using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public static class Directives {
        /// <summary>
        /// Creates an XLINQ subquery.
        /// </summary>
        [SubQuery]
        public static T SubQuery<T>(Func<IQueryResult<T>> query) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Creates an XLINQ subquery.
        /// </summary>
        [SubQuery]
        public static T SubQuery<TEntity0, T>(Func<TEntity0, IQueryResult<T>> query) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Creates an XLINQ subquery.
        /// </summary>
        [SubQuery]
        public static T SubQuery<TEntity0, TEntity1, T>(Func<TEntity0, TEntity1, IQueryResult<T>> query) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Creates an XLINQ subquery.
        /// </summary>
        [SubQuery]
        public static T SubQuery<TEntity0, TEntity1, TEntity2, T>(Func<TEntity0, TEntity1, TEntity2, IQueryResult<T>> query) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Creates an XLINQ subquery.
        /// </summary>
        [SubQuery]
        public static T SubQuery<TEntity0, TEntity1, TEntity2, TEntity3, T>(Func<TEntity0, TEntity1, TEntity2, TEntity3, IQueryResult<T>> query) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Creates an XLINQ subquery.
        /// </summary>
        [SubQuery]
        public static T SubQuery<TEntity0, TEntity1, TEntity2, TEntity3, TEntity4, T>(
            Func<TEntity0, TEntity1, TEntity2, TEntity3, TEntity4, IQueryResult<T>> query) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Creates an XLINQ subquery.
        /// </summary>
        [SubQuery]
        public static T SubQuery<TEntity0, TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, T>(
            Func<TEntity0, TEntity1, TEntity2, TEntity3, TEntity4, TEntity5, IQueryResult<T>> query) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Lets specify a window frame in OVER clause
        /// </summary>
        [Function("", OmitParentheses = true)]
        public static IWindowFrame WindowFrame() {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Starts Window Function (OVER clause)
        /// </summary>
        [Function("", OmitParentheses = true)]
        public static IAggregateGroup<T> AggregateBy<T>(T aggregateFunction) where T : IComparable {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Starts Window Function (OVER clause)
        /// </summary>
        [Function("", OmitParentheses = true)]
        public static IAggregateGroup<T> AggregateBy<T>(T? aggregateFunction) where T : struct, IComparable {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Alias column for SELECT.
        /// </summary>
        [Alias]
        // ReSharper disable once InconsistentNaming
        public static IAlias<T> @as<T>(this T field,
            [Context(ParameterContext.Alias)] T alias) where T : IComparable {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Alias column for SELECT.
        /// </summary>
        [Alias]
        // ReSharper disable once InconsistentNaming
        public static IAlias<T> @as<T>(this T field) where T : IComparable {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Alias column for SELECT.
        /// </summary>
        [Alias]
        // ReSharper disable once InconsistentNaming
        public static IAlias<T> @as<T>(this T field,
            [Context(ParameterContext.Alias)] T? alias) where T : struct, IComparable {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Alias column for SELECT.
        /// </summary>
        [Alias]
        // ReSharper disable once InconsistentNaming
        public static IAlias<T> @as<T>(this T? field,
            [Context(ParameterContext.Alias)] T alias) where T : struct, IComparable {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Alias column for SELECT.
        /// </summary>
        [Alias]
        // ReSharper disable once InconsistentNaming
        public static IAlias<T> @as<T>(this T? field,
            [Context(ParameterContext.Alias)] T? alias) where T : struct, IComparable {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Alias column for SELECT.
        /// </summary>
        [Alias]
        // ReSharper disable once InconsistentNaming
        public static IAlias<T> @as<T>(this T? field) where T : struct, IComparable {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Creates table projection for INSERT, UPDATE
        /// </summary>
        /// <param name="tuple">C# value tuple, e.g. <code>(blog.Name, blog.Author)</code></param>
        [CommonTableExpression(CommonTableExpressionType.Decorator)]
        [Function("",
            OmitParentheses = true,
            ParameterContext = ParameterContext.FromWithoutAlias,
            ParameterContextCapabilities = new[] {
                nameof(Capability.ALIAS_INSERT)
            })]
        [Operator]
        [ViewDeclaration]
        // ReSharper disable once InconsistentNaming
        public static IProjection<T, TTuple> @using<T, TTuple>(this T tableReference,
            [Context(ParameterContext.Alias)] TTuple tuple)
            where T : class
            where TTuple : struct, ITuple {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Creates table projection for INSERT, UPDATE
        /// </summary>
        [CommonTableExpression(CommonTableExpressionType.Decorator)]
        [Function("",
            OmitParentheses = true,
            ParameterContext = ParameterContext.FromWithoutAlias,
            ParameterContextCapabilities = new[] {
                nameof(Capability.ALIAS_INSERT)
            })]
        [Operator]
        [ViewDeclaration]
        // ReSharper disable once InconsistentNaming
        public static IProjection<T> @using<T>(this T tableReference)
            where T : class {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Block terminator (statement separator)
        /// </summary>
        [BlockTerminator]
        [Function(";", OmitParentheses = true)]
        public static void Semicolon() {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Give an ad-hoc SQL table name. Overrides the model configuration.
        /// </summary>
        [TableDeclaration, Tuple]
        public static T ToTable<T>(String table, String schema = null) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Prepends an additional element to an existing <code>params</code> array.
        /// Used in <seealso cref="RowsFrom{TE,T}(Streamx.Linq.SQL.IProjection{TE,T},System.Collections.Generic.IEnumerable{TE})"/>
        /// </summary>
        [Function("", OmitParentheses = true)]
        public static T[] Params<T>(T prepend, params T[] args) {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Generate multiple records for VALUES
        /// </summary>
        public static T[] RowsFrom<TE, T>(this IProjection<TE, T> set, IEnumerable<TE> batch)
            where T : struct, ITuple
            where TE : class {
            return RowsFrom<TE, T>(batch)(set);
        }

        /// <summary>
        /// Generate multiple records for VALUES
        /// </summary>
        [Local]
        public static Func<IProjection<TE, T>, T[]> RowsFrom<TE, T>(IEnumerable<TE> batch)
            where T : struct, ITuple
            where TE : class {
            Func<IProjection<TE, T>, T[]> result = set => new T[] { };

            foreach (var item in batch) {
                var current = result;
                result = set => Params(set.RowFrom(item), current(set));
            }

            return result;
        }
    }
}
