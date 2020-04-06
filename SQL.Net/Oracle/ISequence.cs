using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL.Oracle {
    public interface ISequence<out T> : IKeyword where T : IComparable<T> {
        [Function(OmitParentheses = true)]
        T CURRVAL();

        [Function(OmitParentheses = true)]
        T NEXTVAL();
    }
}
