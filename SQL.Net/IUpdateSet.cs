using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface IUpdateSet {
        [Function(OmitParentheses = true)]
        IClause SET([Context(ParameterContext.Inherit, BlockSequenceSeparator = ",")] Action action);
        
        [Function(OmitParentheses = true)]
        IClause SET(IClause action);
    }
}
