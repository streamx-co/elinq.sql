using System;

namespace Streamx.Linq.SQL.Grammar {
    [AttributeUsage(AttributeTargets.Parameter), Notation]
    public sealed class ContextAttribute : Attribute {
        public ParameterContext Value { get; }
        public String Format { get; set; }
        public String BlockSequenceSeparator { get; set; }

        public ContextAttribute(ParameterContext value) {
            Value = value;
        }
    }
}