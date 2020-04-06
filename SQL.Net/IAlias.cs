using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {

    public interface IAlias { }

    public interface IAlias<T> : IComparable<T>, IComparable, IAlias where T : IComparable {
        [Function("", OmitParentheses = true)]
        T Aliased { get; }
    }
}