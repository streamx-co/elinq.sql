using System.Collections.Generic;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    [ToStringFormatter("_", " ")]
    public enum FrameBounds {
        UNBOUNDED_PRECEDING,
        PRECEDING,
        CURRENT_ROW,
        FOLLOWING,
        UNBOUNDED_FOLLOWING,
    }
}
