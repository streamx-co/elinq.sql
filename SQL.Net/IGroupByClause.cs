using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface IGroupByClause {
        /**
     * Use {@link SQL#ROLLUP(Comparable...)}, if supported by the DB vendor
     */
        [Obsolete]
        [Function(OmitParentheses = true)]
        void WITH_ROLLUP();
    }
    
    public interface IGroupingSet : IBy, IComparable { }
}