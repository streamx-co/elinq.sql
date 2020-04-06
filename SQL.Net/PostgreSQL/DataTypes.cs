using System;

namespace Streamx.Linq.SQL.PostgreSQL {
    /// <summary>
    /// https://www.npgsql.org/doc/types/basic.html
    /// </summary>
    public static class DataTypes {
        public static readonly DataType<DateTime> TIMESTAMP = DataTypeNames.TIMESTAMP.Create<DateTime>();
        public static readonly DataType<DateTime> DATE = DataTypeNames.DATE.Create<DateTime>();
        public static readonly DataType<TimeSpan> TIME = DataTypeNames.TIME.Create<TimeSpan>();
        public static readonly DataType<DateTimeOffset> TIMETZ = DataTypeNames.TIME_WITH_TIME_ZONE.Create<DateTimeOffset>();
        public static readonly DataType<TimeSpan> INTERVAL = DataTypeNames.INTERVAL.Create<TimeSpan>();

        /**
     * 2 bytes
     */
        public static readonly DataType<short> SMALLINT = DataTypeNames.SMALLINT.Create<short>();

        /**
     * 4 bytes
     */
        public static readonly DataType<int> INT = DataTypeNames.INTEGER.Create<int>();

        /**
     * 8 bytes
     */
        public static readonly DataType<long> BIGINT = DataTypeNames.BIGINT.Create<long>();

        public static readonly DataType<Decimal> DECIMAL = DataTypeNames.NUMERIC.Create<Decimal>();
        public static readonly DataType<Decimal> MONEY = DataTypeNames.MONEY.Create<Decimal>();

        public static readonly DataType<float> REAL = DataTypeNames.REAL.Create<float>();
        public static readonly DataType<double> DOUBLE = DataTypeNames.FLOAT8.Create<double>();

        // Serial types effectively Create an appropriate integer column type

        public static readonly DataType<bool> BOOLEAN = DataTypeNames.BOOLEAN.Create<bool>();
        public static readonly DataType<string> TEXT = DataTypeNames.TEXT.Create<string>();
        public static readonly DataType<char[]> TEXT_LOB = DataTypeNames.TEXT.Create<char[]>();
    }
}
