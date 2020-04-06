using System;

namespace Streamx.Linq.SQL.Grammar {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public sealed class TupleAttribute : Attribute { }
}