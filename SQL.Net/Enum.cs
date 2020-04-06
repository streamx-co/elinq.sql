using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public abstract class Enum : IKeyword {
        public override string ToString() => FieldMap[this];

        protected static IDictionary<object, string> ComputeFieldMap(Type type) =>
            type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly).
                Select(i => (i.Name, Value: i.GetValue(null))).
                ToDictionary(v => v.Value, v => v.Name);

        protected abstract IDictionary<object, string> FieldMap { get; }
    }
}
