using System;

namespace Streamx.Linq.SQL.Grammar {
    [AttributeUsage(AttributeTargets.Method), Notation]
    public sealed class ViewDeclarationAttribute : Attribute {

        [AttributeUsage(AttributeTargets.Method), Notation]
        public sealed class FromAttribute : Attribute {
            public bool Aliased { get; set; }
        }

        [AttributeUsage(AttributeTargets.Method), Notation]
        public sealed class RowAttribute : Attribute {
            public bool Aliased { get; set; }
        }
        
        // [AttributeUsage(AttributeTargets.Method)]
        // public sealed class ColumnsAttribute : Attribute { }
        
        // [AttributeUsage(AttributeTargets.Method)]
        // public sealed class AliasAttribute : Attribute { }
    }
}