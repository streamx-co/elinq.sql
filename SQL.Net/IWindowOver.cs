using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface IWindowOver<TContinuation> : IValue<TContinuation> where TContinuation : IComparable {
        [Function]
        TContinuation OVER();

        [Function]
        TContinuation OVER(IWindowDef windowDefinition);
    }

    public interface IAggregateGroup<TContinuation> : IAggregateFilter<TContinuation> where TContinuation : IComparable {
        [Function]
        IAggregateFilter<TContinuation> WITHIN_GROUP(IWindowFrame orderByClause);
    }

    public interface IAggregateFilter<TContinuation> : IWindowOver<TContinuation> where TContinuation : IComparable {
        [Function]
        IWindowOver<TContinuation> FILTER(IWhereClause filterClause);
    }

    public interface IValue<TContinuation> where TContinuation : IComparable {
        [Alias]
        IAlias<TContinuation> @as(TContinuation label);

        [Alias]
        TContinuation Value { get; }
    }
}
