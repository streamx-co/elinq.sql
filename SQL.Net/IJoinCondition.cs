using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface IJoinCondition<T> where T : class {
        [Function(OmitParentheses = true)]
        IJoinClause ON(bool condition);

        [Function(ParameterContext = ParameterContext.Alias)]
        IJoinClause USING(params IComparable[] columns);

        [Function(OmitParentheses = true)]
        IJoinClause NATURAL();
    }
}