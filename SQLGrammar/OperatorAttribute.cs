using System;

namespace Streamx.Linq.SQL.Grammar {
    [AttributeUsage(AttributeTargets.Method), Notation]
    public sealed class OperatorAttribute : Attribute {
        public bool Right { get; set; } = true;
        public bool OmitParentheses { get; set; }
    }
}