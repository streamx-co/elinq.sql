using System;

namespace Streamx.Linq.SQL.Grammar {
    public sealed class Capability {
        private readonly Enum _hint;

        public static readonly Capability ALIAS_INSERT = new Capability(ParameterContext.From);
        public static readonly Capability ALIAS_UPDATE = new Capability(ParameterContext.From);
        public static readonly Capability ALIAS_DELETE = new Capability(ParameterContext.From);
        public static readonly Capability TABLE_AS_ALIAS = new Capability(null);

        private Capability(Enum hint) {
            _hint = hint;
        }

        public T Hint<T>() where T : Enum {
            return (T)_hint;
        }

        public static Capability Parse(string name) {
            switch (name) {
                case "ALIAS_INSERT": return ALIAS_INSERT;
                case "ALIAS_UPDATE": return ALIAS_UPDATE;
                case "ALIAS_DELETE": return ALIAS_DELETE;
                case "TABLE_AS_ALIAS": return TABLE_AS_ALIAS;

                default: throw new ArgumentException(nameof(name));
            }
        }

        // protected Cap
    }
}