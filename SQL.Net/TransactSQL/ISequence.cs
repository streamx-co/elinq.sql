using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL.TransactSQL {
    public interface ISequence<out T> : IKeyword where T : IComparable<T> { }
}
