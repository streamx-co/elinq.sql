using System;
using System.Collections.Generic;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface ITupleSelect<T> {
        [NoOp]
        IQueryResult<T> AsSingle(); //row value

        [NoOp]
        IQueryResult<ICollection<T>> AsCollection();
    }

    public interface ISelectClause : IClause { }

    [NoOp]
    public interface IEntitySelectClause<T> : ISelectClause, IQueryResult<T> where T : class {
        [CommonTableExpression(CommonTableExpressionType.Self)]
        T Current();

        [Function(OmitParentheses = true,
            ParameterContext = ParameterContext.FromWithoutAlias,
            ParameterContextCapabilities = new[] {nameof(Capability.ALIAS_INSERT)})]
        IClause INTO(T tableReference);
    }

    [NoOp]
    public interface ITupleSelectClause<T> : ISelectClause, ITupleSelect<T> { }
}
