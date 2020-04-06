using System.Collections.Generic;

namespace Streamx.Linq.SQL.PostgreSQL {
    public sealed class DataTypeNames : DataTypeName {

        private DataTypeNames() { }

        // Exact numerics
        public static readonly DataTypeNames SMALLINT = new DataTypeNames();
        public static readonly DataTypeNames INTEGER = new DataTypeNames();
        public static readonly DataTypeNames BIGINT = new DataTypeNames();

        /// <summary>
        /// Synonym for DECIMAL
        /// </summary>
        public static readonly DataTypeNames NUMERIC = new DataTypeNames();

        // Autoincrementing
        public static readonly DataTypeNames SMALLSERIAL = new DataTypeNames();
        public static readonly DataTypeNames SERIAL = new DataTypeNames();
        public static readonly DataTypeNames BIGSERIAL = new DataTypeNames();

        // Approximate numerics
        /**
     * Single precision (Java float)
     */
        public static readonly DataTypeNames REAL = new DataTypeNames();

        /**
     * Alias: DOUBLE PRECISION (Java double)
     */
        public static readonly DataTypeNames FLOAT8 = new DataTypeNames();

        // Monetary
        public static readonly DataTypeNames MONEY = new DataTypeNames();

        // Character strings
        public static readonly DataTypeNames VARCHAR = new DataTypeNames();
        public static readonly DataTypeNames CHAR = new DataTypeNames();
        public static readonly DataTypeNames TEXT = new DataTypeNames();

        // Binary strings
        public static readonly DataTypeNames BYTEA = new DataTypeNames();

        // Date and time
        public static readonly DataTypeNames TIMESTAMP = new DataTypeNames();
        public static readonly DataTypeNames TIMESTAMP_WITH_TIME_ZONE = new DataTypeNames();
        public static readonly DataTypeNames DATE = new DataTypeNames();
        public static readonly DataTypeNames TIME = new DataTypeNames();
        public static readonly DataTypeNames TIME_WITH_TIME_ZONE = new DataTypeNames();
        public static readonly DataTypeNames INTERVAL = new DataTypeNames();

        // Boolean
        public static readonly DataTypeNames BOOLEAN = new DataTypeNames();

        // Geometry data types
        public static readonly DataTypeNames BOX = new DataTypeNames();
        public static readonly DataTypeNames CIRCLE = new DataTypeNames();
        public static readonly DataTypeNames LINE = new DataTypeNames();
        public static readonly DataTypeNames LSEG = new DataTypeNames();
        public static readonly DataTypeNames PATH = new DataTypeNames();
        public static readonly DataTypeNames POINT = new DataTypeNames();
        public static readonly DataTypeNames POLYGON = new DataTypeNames();

        // network data types
        public static readonly DataTypeNames CIDR = new DataTypeNames();
        public static readonly DataTypeNames INET = new DataTypeNames();
        public static readonly DataTypeNames MACADDR = new DataTypeNames();
        public static readonly DataTypeNames MACADDR8 = new DataTypeNames();

        // Bit strings
        public static readonly DataTypeNames BIT = new DataTypeNames();
        public static readonly DataTypeNames VARBIT = new DataTypeNames();

        // textsearch data types
        public static readonly DataTypeNames TSQUERY = new DataTypeNames();
        public static readonly DataTypeNames TSVECTOR = new DataTypeNames();

        // JSON data types
        public static readonly DataTypeNames JSON = new DataTypeNames();
        public static readonly DataTypeNames JSONB = new DataTypeNames();

        // Other data types
        public static readonly DataTypeNames UUID = new DataTypeNames();
        public static readonly DataTypeNames XML = new DataTypeNames();
        public static readonly DataTypeNames OID = new DataTypeNames();
        public static readonly DataTypeNames PG_LSN = new DataTypeNames();
        public static readonly DataTypeNames TXID_SNAPSHOT = new DataTypeNames();
        
        private static readonly IDictionary<object, string> fieldMap = ComputeFieldMap(typeof(DataTypeNames));
        protected override IDictionary<object, string> FieldMap => fieldMap;
    }
}
