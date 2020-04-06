using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface ISortOrder { }
    
    public interface IBy : INullsSortOrder {
        [Function(OmitParentheses = true)]
        INullsSortOrder ASC { get; }

        [Function(OmitParentheses = true)]
        INullsSortOrder DESC { get; }

        [Function(OmitParentheses = true)]
        INullsSortOrder USING(string @operator);
    }

    public interface INullsSortOrder : ISortOrder {
        [Function(OmitParentheses = true)]
        ISortOrder NULLS_FIRST { get; }

        [Function(OmitParentheses = true)]
        ISortOrder NULLS_LAST { get; }
    }
}