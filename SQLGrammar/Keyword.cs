using System;

namespace Streamx.Linq.SQL.Grammar {
    public interface IKeyword { }

    public sealed class Keyword : IKeyword, IComparable {
        public Keyword(string value) {
            Value = value;
        }

        private string Value { get; }

        public override string ToString() => Value;

        public int CompareTo(object obj) =>
            obj is Keyword key ? String.Compare(key.Value, Value, StringComparison.Ordinal) : 1;
    }
}
