using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface IWindowFrame : IWindowDef {
        [Function(OmitParentheses = true)]
        IWindowFrameBetween RANGE();

        [Function(OmitParentheses = true, OmitArgumentsDelimiter = true)]
        IWindowFrameExclusion RANGE(IComparable offset,
            FrameBounds bounds);

        [Function(OmitParentheses = true)]
        IWindowFrameExclusion RANGE(FrameBounds bounds);

        [Function(OmitParentheses = true)]
        IWindowFrameBetween ROWS();

        [Function(OmitParentheses = true, OmitArgumentsDelimiter = true)]
        IWindowFrameExclusion ROWS(IComparable offset,
            FrameBounds bounds);

        [Function(OmitParentheses = true)]
        IWindowFrameExclusion ROWS(FrameBounds bounds);

        [Function(OmitParentheses = true)]
        IWindowFrameBetween GROUPS();

        [Function(OmitParentheses = true, OmitArgumentsDelimiter = true)]
        IWindowFrameExclusion GROUPS(IComparable offset,
            FrameBounds bounds);

        [Function(OmitParentheses = true)]
        IWindowFrameExclusion GROUPS(FrameBounds bounds);
    }

    public interface IWindowFrameExclusion : IWindowDef {
        [Function(OmitParentheses = true)]
        IWindowDef EXCLUDE_CURRENT_ROW { get; }

        [Function(OmitParentheses = true)]
        IWindowDef EXCLUDE_GROUP { get; }

        [Function(OmitParentheses = true)]
        IWindowDef EXCLUDE_TIES { get; }

        [Function(OmitParentheses = true)]
        IWindowDef EXCLUDE_NO_OTHERS { get; }
    }

    public interface IWindowDef { }

    public interface IWindowFrameBetween {
        [Function(OmitParentheses = true, OmitArgumentsDelimiter = true)]
        IWindowFrameAnd BETWEEN(IComparable offset,
            FrameBounds bounds);

        [Function(OmitParentheses = true)]
        IWindowFrameAnd BETWEEN(FrameBounds bounds);
    }

    public interface IWindowFrameAnd {
        [Function(OmitParentheses = true, OmitArgumentsDelimiter = true)]
        IWindowFrameExclusion AND(IComparable offset,
            FrameBounds bounds);

        [Function(OmitParentheses = true)]
        IWindowFrameExclusion AND(FrameBounds bounds);
    }

    public interface IWindowOrder : IWindowFrame {
        [Function("ORDER BY", OmitParentheses = true)]
        IWindowFrame ORDER(params ISortOrder[] sorts);
    }
}
