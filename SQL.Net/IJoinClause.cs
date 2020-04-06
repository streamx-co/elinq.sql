using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface IJoinClause {
        /**
     * Creates an INNER JOIN
     */
        [Function("INNER JOIN", OmitParentheses = true, ParameterContext = ParameterContext.From)]
        IJoinCondition<T> JOIN<T>(T tableReference) where T : class;

        /**
     * Creates an INNER JOIN
     */
        [Function("INNER JOIN", OmitParentheses = true, ArgumentsDelimiter = " ON", ParameterContext = ParameterContext.From)]
        IJoinClause JOIN<T>(T tableReference,
            [Context(ParameterContext.Expression)] bool condition) where T : class;

        /**
     * Creates an INNER JOIN
     */
        [Function("INNER JOIN", OmitParentheses = true, ParameterContext = ParameterContext.From)]
        IJoinClause JOIN<T>(T tableReference,
            params Object[] @using) where T : class;

        /**
     * Creates an LEFT JOIN
     */
        [Function(OmitParentheses = true, ParameterContext = ParameterContext.From)]
        IJoinCondition<T> LEFT_JOIN<T>(T tableReference) where T : class;

        /**
     * Creates an RIGHT JOIN
     */
        [Function(OmitParentheses = true, ParameterContext = ParameterContext.From)]
        IJoinCondition<T> RIGHT_JOIN<T>(T tableReference) where T : class;

        /**
     * Creates an FULL OUTER JOIN
     */
        [Function("FULL OUTER JOIN", OmitParentheses = true, ParameterContext = ParameterContext.From)]
        IJoinCondition<T> FULL_JOIN<T>(T tableReference) where T : class;

        /**
     * Creates an CROSS JOIN
     */
        [Function(OmitParentheses = true, ParameterContext = ParameterContext.From)]
        IJoinClause CROSS_JOIN<T>(T tableReference) where T : class;

        /**
     * PARTITION BY extension
     */
        [Function("PARTITION BY", OmitParentheses = true)]
        IJoinClause PARTITION(params IBy[] expressions);
    }
}