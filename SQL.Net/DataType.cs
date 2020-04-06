using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public abstract class DataType<T> : IKeyword {
        [Function("", OmitArgumentsDelimiter = true, OmitParentheses = true)]
        public T Of(String constant) {
            throw new NotSupportedException();
        }

        [Function("", OmitArgumentsDelimiter = true, OmitParentheses = true)]
        public T Of(String constant,
            Keyword postfix) {
            throw new NotSupportedException();
        }

        /**
     * Perform the same operation as {@link #of(String)} and adds {@code postfix} at the end
     */
        [Function("", OmitArgumentsDelimiter = true, OmitParentheses = true)]
        public T Of([Literal] long constant) {
            throw new NotSupportedException();
        }

        /**
     * Perform the same operation as {@link #of(String)} and adds {@code postfix} at the end
     */
        [Function("", OmitArgumentsDelimiter = true, OmitParentheses = true)]
        public T Of([Literal] long constant,
            Keyword postfix) {
            throw new NotSupportedException();
        }

        public static DataType<T> Create(string typeName) =>
            new NamedDataType<T>(typeName);

        /// <summary>
        /// Outputs the <code>value</code> as is
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public T Raw(String value) => (T) (object) value;

        public T Cast<TExpression>(TExpression expression)
            where TExpression : IComparable<TExpression> =>
            ScalarFunctions.CAST<T, DataType<T>, TExpression>(expression, this);

        public T Cast<TExpression>(TExpression? expression)
            where TExpression : struct, IComparable<TExpression> =>
            ScalarFunctions.CAST<T, DataType<T>, TExpression>(expression, this);

        /**
     * Appends {@code length} modifier to "this" type. E.g. {@code VARCHAR(255)}. The mapped Java type
     * ({@link DataType}} is preserved.
     */
        [Local]
        public DataType<T> Length(int length) {
            String typeName = ToString() + '(' + length + ')';
            return Create(typeName);
        }

        [Local]
        public DataType<T> Numeric(int precision) {
            String typeName = ToString() + '(' + precision + ')';
            return Create(typeName);
        }

        [Local]
        public DataType<T> Numeric(int precision, int scale) {
            String typeName = ToString() + '(' + precision + ',' + scale + ')';
            return Create(typeName);
        }

        /**
     * Create a derived type. Uses {@link MessageFormat#format(Object)} for formatting. {@code this} is passed as an
     * argument.
     * 
     * <pre>
     * <code>
     * // produces DATE[] type
     * DATE.derive("{0}[]");</code>
     * </pre>
     * 
     */
        [Local]
        public DataType<TX> Derive<TX>(String format) {
            String typeName = String.Format(format, this);
            return DataType<TX>.Create(typeName);
        }

        private class NamedDataType<TX> : DataType<TX> {
            private readonly string name;

            public NamedDataType(string name) {
                this.name = name;
            }

            public override string ToString() => name;
        }
    }
}
