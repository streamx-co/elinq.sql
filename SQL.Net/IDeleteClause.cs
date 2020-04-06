using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface IDeleteClause : IClause {
        [Function(OmitParentheses = true, ParameterContext = ParameterContext.FromWithoutAlias,
            ParameterContextCapabilities = new[] {nameof(Capability.ALIAS_DELETE)})]
        IDeleteUsing FROM<T>(T tableReference) where T : class;
    }

    public interface IDeleteUsing : IClause {
        [Function(OmitParentheses = true, ParameterContext = ParameterContext.FromWithoutAlias,
            ParameterContextCapabilities = new[] {nameof(Capability.ALIAS_DELETE)})]
        IClause USING(params Object[] tableReferences);
    }
}
