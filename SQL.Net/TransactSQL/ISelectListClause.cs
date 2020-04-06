using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL.TransactSQL {
    public interface ISelectListClause {
        [Function("", OmitParentheses = true)]
        T Of<T>(T expression) where T : IComparable;
        
        [Function("", OmitParentheses = true)]
        T? Of<T>(T? expression) where T : struct, IComparable;

        [Function("", OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        T Of<T>(params IAlias[] expressions) where T : class, new();
        
        [Function("", OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        T Of<T>(T entity, params IAlias[] expressions) where T : class, new();
    }
    
    public interface ITopClause : IWithTiesClause {
        [Function(OmitParentheses = true)]
        IWithTiesClause PERCENT();
    }

    public interface IWithTiesClause : ISelectListClause {
        [Function(OmitParentheses = true)]
        ISelectListClause WITH_TIES();
    }
}
