using System;

namespace Streamx.Linq.SQL.Grammar {
    [AttributeUsage(AttributeTargets.Method), Notation]
    public sealed class CommonTableExpressionAttribute : Attribute {
        public CommonTableExpressionType Value { get; }

        public CommonTableExpressionAttribute(CommonTableExpressionType value) {
            Value = value;
        }
    }
}