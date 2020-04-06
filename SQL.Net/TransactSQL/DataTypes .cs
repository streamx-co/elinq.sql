using System;
using System.Collections.Generic;

namespace Streamx.Linq.SQL.TransactSQL {
   /// <summary>
   /// https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
   /// </summary>
    public static class DataTypes {

        // Exact numerics
        public static readonly DataType<long> BIGINT = DataTypeNames.BIGINT.Create<long>();

        /**
     * Synonym for DECIMAL
     */
        public static readonly DataType<decimal> NUMERIC = DataTypeNames.NUMERIC.Create<decimal>();

        public static readonly DataType<bool> BIT = DataTypeNames.BIT.Create<bool>();

        /**
     * INT2
     */
        public static readonly DataType<short> SMALLINT = DataTypeNames.SMALLINT.Create<short>();

        public static readonly DataType<decimal> DECIMAL = DataTypeNames.DECIMAL.Create<decimal>();
        public static readonly DataType<decimal> SMALLMONEY = DataTypeNames.SMALLMONEY.Create<decimal>();

        /**
     * INT4
     */
        public static readonly DataType<int> INT = DataTypeNames.INT.Create<int>();

        /**
     * INT1
     */
        public static readonly DataType<byte> TINYINT = DataTypeNames.TINYINT.Create<byte>();

        public static readonly DataType<decimal> MONEY = DataTypeNames.MONEY.Create<decimal>();

        // Approximate numerics
        /**
     * Double precision (Java double)
     */
        public static readonly DataType<double> FLOAT = DataTypeNames.FLOAT.Create<double>();

        /**
     * Single precision (Java float)
     */
        public static readonly DataType<float> REAL = DataTypeNames.REAL.Create<float>();

        // Date and time
        public static readonly DataType<DateTime> DATE = DataTypeNames.DATE.Create<DateTime>();
        public static readonly DataType<DateTimeOffset> DATETIMEOFFSET = DataTypeNames.DATETIMEOFFSET.Create<DateTimeOffset>();
        public static readonly DataType<DateTime> DATETIME2 = DataTypeNames.DATETIME2.Create<DateTime>();
        public static readonly DataType<DateTime> SMALLDATETIME = DataTypeNames.SMALLDATETIME.Create<DateTime>();
        public static readonly DataType<DateTime> DATETIME = DataTypeNames.DATETIME.Create<DateTime>();
        public static readonly DataType<TimeSpan> TIME = DataTypeNames.TIME.Create<TimeSpan>();

        // Character strings
        public static readonly DataType<String> CHAR = DataTypeNames.CHAR.Create<String>();
        public static readonly DataType<String> VARCHAR = DataTypeNames.VARCHAR.Create<String>();
        public static readonly DataType<String> TEXT = DataTypeNames.TEXT.Create<String>();

        // Unicode character strings
        public static readonly DataType<String> NCHAR = DataTypeNames.NCHAR.Create<String>();
        public static readonly DataType<String> NVARCHAR = DataTypeNames.NVARCHAR.Create<String>();
        public static readonly DataType<String> NTEXT = DataTypeNames.NTEXT.Create<String>();

        // Binary strings
        public static readonly DataType<byte[]> BINARY = DataTypeNames.BINARY.Create<byte[]>();
        public static readonly DataType<byte[]> VARBINARY = DataTypeNames.VARBINARY.Create<byte[]>();
        public static readonly DataType<byte[]> IMAGE = DataTypeNames.IMAGE.Create<byte[]>();
        public static readonly DataType<byte[]> FILESTREAM = DataTypeNames.FILESTREAM.Create<byte[]>();
        public static readonly DataType<byte[]> TIMESTAMP = DataTypeNames.TIMESTAMP.Create<byte[]>();

        // Other data types
        public static readonly DataType<byte[]> ROWVERSION = DataTypeNames.ROWVERSION.Create<byte[]>();
        public static readonly DataType<Guid> UNIQUEIDENTIFIER = DataTypeNames.UNIQUEIDENTIFIER.Create<Guid>();
        public static readonly DataType<Object> SQL_VARIANT = DataTypeNames.SQL_VARIANT.Create<Object>();
        public static readonly DataType<String> XML = DataTypeNames.XML.Create<String>();
        
    }
}
