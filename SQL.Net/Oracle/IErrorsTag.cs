using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL.Oracle {
    public interface IErrorsTag {
        [Function("")]
        IClause TAG(IComparable simpleExpression);
    }
    
    public interface IErrorsInto : IErrorsTag {
        [Function(OmitParentheses = true, ParameterContext = ParameterContext.FromWithoutAlias)]
        IErrorsTag INTO(Object tableReference);
    }
}
