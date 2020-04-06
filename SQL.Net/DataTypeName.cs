using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public abstract class DataTypeName : EnumWithBlanks {
        [Local]
        public DataType<T> Create<T>() {
            var typeName = ToString();
            return DataType<T>.Create(typeName);
        }

        [Local]
        public DataType<T> Create<T>(int length) {
            var created = Create<T>();
            return created.Length(length);
        }

        [Local]
        public DataType<T> Create<T>(int precision, int scale) {
            var created = Create<T>();
            return created.Numeric(precision, scale);
        }
    }
}
