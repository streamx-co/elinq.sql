using System;

namespace Streamx.Linq.SQL.Grammar {
    [AttributeUsage(AttributeTargets.Method), Notation]
    public sealed class SubQueryAttribute : Attribute { }
}