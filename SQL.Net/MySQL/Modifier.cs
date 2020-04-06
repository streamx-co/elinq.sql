using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL.MySQL {
    [ToStringFormatter("_", " ")]
    public enum Modifier {
        LOW_PRIORITY, DELAYED, HIGH_PRIORITY, IGNORE
    }
}
