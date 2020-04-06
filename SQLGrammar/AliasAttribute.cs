using System;

namespace Streamx.Linq.SQL.Grammar {
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property), Notation]
    public sealed class AliasAttribute : Attribute {
        public bool Value { get; } = true;

        public AliasAttribute() { }

        public AliasAttribute(bool value) {
            Value = value;
        }

        [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter), Notation]
        public class UseAttribute : Attribute { }
    }
}