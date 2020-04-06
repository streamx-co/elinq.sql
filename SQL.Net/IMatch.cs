using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface IMatchThen {
        [Function(OmitParentheses = true)]
        void THEN(Action subQuery);

        [Function(OmitParentheses = true)]
        void THEN(IClause subQuery);
    }

    public interface MergeClause {
        [Function(OmitParentheses = true, ParameterContext = ParameterContext.From)]
        MergeUsing INTO(Object targetTableReference);
    }

    public interface MergeUsing {
        [Function(OmitParentheses = true, ParameterContext = ParameterContext.From)]
        MergeCondition USING(Object sourceTableReference);
    }

    public interface MergeCondition {
        [Function(OmitParentheses = true)]
        void ON(bool condition);
    }
}
