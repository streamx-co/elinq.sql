using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface IVersioningClause {
        [Function(OmitParentheses = true)]
        void AS_OF(DateTime date);

        [Function(OmitParentheses = true)]
        void AS_OF(DateTimeOffset date);

        [Function("FROM", OmitParentheses = true, ArgumentsDelimiter = " TO")]
        void FROM_TO(DateTime start,
            DateTime end);

        [Function("FROM", OmitParentheses = true, ArgumentsDelimiter = " TO")]
        void FROM_TO(DateTimeOffset start,
            DateTimeOffset end);

        [Function(OmitParentheses = true, ArgumentsDelimiter = " AND")]
        void BETWEEN(DateTime start,
            DateTime end);

        [Function(OmitParentheses = true, ArgumentsDelimiter = " AND")]
        void BETWEEN(DateTimeOffset start,
            DateTimeOffset end);

        [Function]
        void CONTAINED_IN(DateTime start,
            DateTime end);

        [Function]
        void CONTAINED_IN(DateTimeOffset start,
            DateTimeOffset end);

        [Function(OmitParentheses = true)]
        void ALL();
    }
}
