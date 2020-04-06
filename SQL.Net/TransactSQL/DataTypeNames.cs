using System.Collections.Generic;

namespace Streamx.Linq.SQL.TransactSQL {
    public sealed class DataTypeNames : DataTypeName {
        private DataTypeNames() { }

        // Exact numerics
        public static readonly DataTypeNames BIGINT = new DataTypeNames();

        /**
     * Synonym for DECIMAL
     */
        public static readonly DataTypeNames NUMERIC = new DataTypeNames();

        public static readonly DataTypeNames BIT = new DataTypeNames();

        /**
     * INT2
     */
        public static readonly DataTypeNames SMALLINT = new DataTypeNames();

        public static readonly DataTypeNames DECIMAL = new DataTypeNames();
        public static readonly DataTypeNames SMALLMONEY = new DataTypeNames();

        /**
     * INT4
     */
        public static readonly DataTypeNames INT = new DataTypeNames();

        /**
     * INT1
     */
        public static readonly DataTypeNames TINYINT = new DataTypeNames();

        public static readonly DataTypeNames MONEY = new DataTypeNames();

        // Approximate numerics
        /**
     * Double precision (Java double)
     */
        public static readonly DataTypeNames FLOAT = new DataTypeNames();

        /**
     * Single precision (Java float)
     */
        public static readonly DataTypeNames REAL = new DataTypeNames();

        // Date and time
        public static readonly DataTypeNames DATE = new DataTypeNames();
        public static readonly DataTypeNames DATETIMEOFFSET = new DataTypeNames();
        public static readonly DataTypeNames DATETIME2 = new DataTypeNames();
        public static readonly DataTypeNames SMALLDATETIME = new DataTypeNames();
        public static readonly DataTypeNames DATETIME = new DataTypeNames();
        public static readonly DataTypeNames TIME = new DataTypeNames();

        // Character strings
        public static readonly DataTypeNames CHAR = new DataTypeNames();
        public static readonly DataTypeNames VARCHAR = new DataTypeNames();
        public static readonly DataTypeNames TEXT = new DataTypeNames();

        // Unicode character strings
        public static readonly DataTypeNames NCHAR = new DataTypeNames();
        public static readonly DataTypeNames NVARCHAR = new DataTypeNames();
        public static readonly DataTypeNames NTEXT = new DataTypeNames();

        // Binary strings
        public static readonly DataTypeNames BINARY = new DataTypeNames();
        public static readonly DataTypeNames VARBINARY = new DataTypeNames();
        public static readonly DataTypeNames IMAGE = new DataTypeNames();
        public static readonly DataTypeNames FILESTREAM = new DataTypeNames();
        public static readonly DataTypeNames TIMESTAMP = new DataTypeNames();

        // Other data types
        // public static readonly DataTypeNames CURSOR = new DataTypeNames();
        public static readonly DataTypeNames ROWVERSION = new DataTypeNames();
        public static readonly DataTypeNames UNIQUEIDENTIFIER = new DataTypeNames();
        public static readonly DataTypeNames SQL_VARIANT = new DataTypeNames();
        public static readonly DataTypeNames XML = new DataTypeNames();

        private static readonly IDictionary<object, string> fieldMap = ComputeFieldMap(typeof(DataTypeNames));
        protected override IDictionary<object, string> FieldMap => fieldMap;
    }
}
