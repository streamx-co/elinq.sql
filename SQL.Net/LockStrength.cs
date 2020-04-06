using System;
using System.Collections.Generic;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    [ToStringFormatter("_", " ")]
    public enum LockStrength {
        UPDATE,
        NO_KEY_UPDATE,
        SHARE,
        KEY_SHARE,
    }

    public interface ILockingClause : ILockWaitingMode {
        [Function(OmitParentheses = true)]
        ILockWaitingMode OF(params Object[] tables);
    }

    public interface ILockWaitingMode {
        [Function(OmitParentheses = true)]
        IClause NOWAIT { get; }

        [Function(OmitParentheses = true)]
        IClause SKIP_LOCKED { get; }
    }
}
