using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface IInsertClause {
        [Function(OmitParentheses = true, ParameterContext = ParameterContext.FromWithoutAlias,
            ParameterContextCapabilities = new[] {nameof(Capability.ALIAS_INSERT)})]
        IClause INTO<T>(IProjection<T> projection) where T : class;
    }
}
