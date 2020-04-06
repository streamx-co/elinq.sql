using System;
using System.Collections.Generic;
using Streamx.Linq.SQL.Grammar;
using Streamx.Linq.SQL.Grammar.Configuration;
using Streamx.Linq.SQL.TransactSQL;

namespace Streamx.Linq.SQL.Oracle {
    public static class SQL {
        /**
     * Ubiquitous Oracle's DUAL table
     */
        public interface IDual { }

        /**
     * @return {@link DUAL} table
     */
        [Function(OmitParentheses = true)]
        public static IDual DUAL() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static T CROSS_APPLY<T>(T subQuery) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static T OUTER_APPLY<T>(T subQuery) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static void MINUS() {
            throw new NotSupportedException();
        }

        // Math

        [Function]
        public static double ATAN2(double n1,
            double n2) {
            throw new NotSupportedException();
        }

        [Function]
        public static double BITAND(double n1,
            double n2) {
            throw new NotSupportedException();
        }

        [Function]
        public static double COSH(double n) {
            throw new NotSupportedException();
        }

        [Function]
        public static double LN(double numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static double MOD(double n2,
            double n1) {
            throw new NotSupportedException();
        }

        [Function]
        public static double NANVL(double n2,
            double n1) {
            throw new NotSupportedException();
        }

        [Function]
        public static double REMAINDER(double n2,
            double n1) {
            throw new NotSupportedException();
        }

        [Function]
        public static double ROUND(double numeric) {
            throw new NotSupportedException();
        }

        [Function]
        public static double SINH(double n) {
            throw new NotSupportedException();
        }

        [Function]
        public static double TANH(double n) {
            throw new NotSupportedException();
        }

        [Function]
        public static double TRUNC(double numeric,
            int length) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static T WIDTH_BUCKET<T>(T expr,
            T min,
            T max,
            int numBuckets) {
            throw new NotSupportedException();
        }

        // String

        [Function]
        public static String CHR(int charCode) {
            throw new NotSupportedException();
        }

        [Function(ArgumentsDelimiter = " USING")]
        public static String CHR(int charCode,
            String charset) {
            throw new NotSupportedException();
        }

        [Function]
        public static String INITCAP(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String LPAD(String expression,
            int length) {
            throw new NotSupportedException();
        }

        [Function]
        public static String LPAD(String expression,
            int length,
            String padWith) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String NLS_INITCAP(String expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String NLS_INITCAP(String expression,
            String nlsParam) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String NLS_LOWER(String expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String NLS_LOWER(String expression,
            String nlsParam) {
            throw new NotSupportedException();
        }

        [Function]
        public static String NLSSORT(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String NLSSORT(String expression,
            String nlsParam) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String NLS_UPPER(String expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String NLS_UPPER(String expression,
            String nlsParam) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_REPLACE(String expression,
            String pattern) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_REPLACE(String expression,
            String pattern,
            String replaceExpression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_REPLACE(String expression,
            String pattern,
            String replaceExpression,
            int position) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_REPLACE(String expression,
            String pattern,
            String replaceExpression,
            int position,
            int occurence) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_REPLACE(String expression,
            String pattern,
            String replaceExpression,
            int position,
            int occurence,
            String matchParam) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_SUBSTR(String expression,
            String pattern) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_SUBSTR(String expression,
            String pattern,
            int position) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_SUBSTR(String expression,
            String pattern,
            int position,
            int occurence) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_SUBSTR(String expression,
            String pattern,
            int position,
            int occurence,
            String matchParam) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_SUBSTR(String expression,
            String pattern,
            int position,
            int occurence,
            String matchParam,
            int subExpr) {
            throw new NotSupportedException();
        }

        [Function]
        public static String RPAD(String expression,
            int length) {
            throw new NotSupportedException();
        }

        [Function]
        public static String RPAD(String expression,
            int length,
            String padWith) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SOUNDEX(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTR(String expression,
            int from,
            int count) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTR(String expression,
            int from) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTRB(String expression,
            int from,
            int count) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTRB(String expression,
            int from) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTRC(String expression,
            int from,
            int count) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTRC(String expression,
            int from) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTR2(String expression,
            int from,
            int count) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTR2(String expression,
            int from) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTR4(String expression,
            int from,
            int count) {
            throw new NotSupportedException();
        }

        [Function]
        public static String SUBSTR4(String expression,
            int from) {
            throw new NotSupportedException();
        }
        
        [Function(ArgumentsDelimiter = " AS")]
        public static T TREAT<T, TypeName>(Object expression,
            TypeName dataType) where T : IComparable<T> where TypeName : DataType<T> {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTR(String @string,
            String substring) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTR(String @string,
            String substring,
            int position) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTR(String @string,
            String substring,
            int position,
            int occurrence) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTRB(String @string,
            String substring) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTRB(String @string,
            String substring,
            int position) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTRB(String @string,
            String substring,
            int position,
            int occurrence) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTRC(String @string,
            String substring) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTRC(String @string,
            String substring,
            int position) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTRC(String @string,
            String substring,
            int position,
            int occurrence) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTR2(String @string,
            String substring) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTR2(String @string,
            String substring,
            int position) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTR2(String @string,
            String substring,
            int position,
            int occurrence) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTR4(String @string,
            String substring) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTR4(String @string,
            String substring,
            int position) {
            throw new NotSupportedException();
        }

        [Function]
        public static int INSTR4(String @string,
            String substring,
            int position,
            int occurrence) {
            throw new NotSupportedException();
        }

        [Function]
        public static int LENGTH(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static int LENGTHB(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static int LENGTHC(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static int LENGTH2(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static int LENGTH4(String expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_INSTR(String expression,
            String pattern) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_INSTR(String expression,
            String pattern,
            int position) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_INSTR(String expression,
            String pattern,
            int position,
            int occurence) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_INSTR(String expression,
            String pattern,
            int position,
            int occurence,
            int returnOption) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_INSTR(String expression,
            String pattern,
            int position,
            int occurence,
            int returnOption,
            String matchParam) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String REGEXP_INSTR(String expression,
            String pattern,
            int position,
            int occurence,
            int returnOption,
            String matchParam,
            int subExpr) {
            throw new NotSupportedException();
        }

        // DateTime / Time

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime ADD_MONTHS(DateTime date,
            int toAdd) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static String DBTIMEZONE() {
            throw new NotSupportedException();
        }

        /**
     * Since this function returns {@code int}, it's not type-safe for TIMEZONE_REGION or TIMEZONE_ABBR extraction since
     * the return type is {@code String}. Use {@link #EXTRACT_STRING(DatePart, DateTime) EXTRACT_STRING} in these cases.
     */
        [Function(ArgumentsDelimiter = " FROM")]
        public static int EXTRACT(DatePart datePart,
            DateTime datetime) {
            throw new NotSupportedException();
        }

        /**
     * {@link #EXTRACT(DatePart, DateTime) EXTRACT} function returning {@code String}.
     */
        [Function("EXTRACT", ArgumentsDelimiter = " FROM")]
        public static String EXTRACT_STRING(DatePart datePart,
            DateTime datetime) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTimeOffset FROM_TZ(DateTimeOffset timestamp,
            String timeZone) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime LAST_DAY(DateTime date) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static DateTimeOffset LOCALTIMESTAMP() {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTimeOffset LOCALTIMESTAMP(int precision) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static float MONTHS_BETWEEN(DateTime date1,
            DateTime date2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime NEW_TIME(DateTime date,
            TimeZone timeZone1,
            TimeZone timeZone2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime NEXT_DAY(DateTime date,
            WeekDay weekDay) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime NUMTODSINTERVAL(int n,
            Interval intervalUnit) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime NUMTOYMINTERVAL(int n,
            Interval intervalUnit) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime ROUND(DateTime date,
            String fmt) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime ROUND(DateTime date,
            Format fmt) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static String SESSIONTIMEZONE() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime SYS_EXTRACT_UTC(DateTime date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime SYS_EXTRACT_UTC(String date) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static DateTime SYSDATE() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static DateTimeOffset SYSTIMESTAMP() {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime TRUNC(DateTime date,
            String fmt) {
            throw new NotSupportedException();
        }

        [Function]
        public static DateTime TRUNC(DateTime date,
            Format fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TZ_OFFSET(String timeZone) {
            throw new NotSupportedException();
        }

        // General Comparison

        [Function]
        public static T GREATEST<T>(params T[] expressions) {
            throw new NotSupportedException();
        }

        [Function]
        public static T LEAST<T>(params T[] expressions) {
            throw new NotSupportedException();
        }

        // Multiset / nested tables
        [Function]
        public static int CARDINALITY(Object tableReference) {
            throw new NotSupportedException();
        }

        [Function]
        public static T MULTISET<T>(Object tableReference) {
            throw new NotSupportedException();
        }

        [Function]
        public static T POWERMULTISET<T>(Object tableReference) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static T POWERMULTISET_BY_CARDINALITY<T>(Object tableReference,
            int cardinality) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        [Operator(OmitParentheses = true)]
        public static T MULTISET_EXCEPT<T>(Object nestedTable1,
            Object nestedTable2) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        [Operator(OmitParentheses = true)]
        public static T MULTISET_INTERSECT<T>(Object nestedTable1,
            Object nestedTable2) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        [Operator(OmitParentheses = true)]
        public static T MULTISET_UNION<T>(Object nestedTable1,
            Object nestedTable2) {
            throw new NotSupportedException();
        }

        // Conversion

        [Function]
        public static String ASCIISTR(String expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int BIN_TO_NUM(params Object[] expressions) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(String expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(DateTime date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(DateTime date,
            String fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(DateTime date,
            Format fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(DateTime date,
            String fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(DateTime date,
            Format fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(long n) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(long n,
            String fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(long n,
            Format fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(long n,
            String fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_CHAR(long n,
            Format fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime TO_DATE(String date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime TO_DATE(String date,
            String fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime TO_DATE(String date,
            Format fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime TO_DATE(String date,
            String fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTime TO_DATE(String date,
            Format fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NCHAR(String expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NCHAR(DateTime date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NCHAR(DateTime date,
            String fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NCHAR(DateTime date,
            Format fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NCHAR(DateTime date,
            String fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NCHAR(DateTime date,
            Format fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NCHAR(long n) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NCHAR(long n,
            String fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NCHAR(long n,
            Format fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NCHAR(long n,
            String fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NCHAR(long n,
            Format fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NUMBER(Object expr) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NUMBER(Object expr,
            String fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NUMBER(Object expr,
            Format fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NUMBER(Object expr,
            String fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String TO_NUMBER(Object expr,
            Format fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTimeOffset TO_TIMESTAMP(String date) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTimeOffset TO_TIMESTAMP(String date,
            String fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTimeOffset TO_TIMESTAMP(String date,
            Format fmt) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTimeOffset TO_TIMESTAMP(String date,
            String fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static DateTimeOffset TO_TIMESTAMP(String date,
            Format fmt,
            String nls) {
            throw new NotSupportedException();
        }

        [Function]
        public static String COMPOSE(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String DECOMPOSE(String expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String CONVERT(String expression,
            String destinationCharSet) {
            throw new NotSupportedException();
        }

        [Function]
        public static String CONVERT(String expression,
            String destinationCharSet,
            String sourceCharSet) {
            throw new NotSupportedException();
        }

        [Function]
        public static String UNISTR(String expression) {
            throw new NotSupportedException();
        }

        // Hierarchical

        [Function(UnderscoresAsBlanks = false)]
        public static String SYS_CONNECT_BY_PATH(String column,
            String separator) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String ORA_HASH(Object expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String ORA_HASH(Object expression,
            long maxBucket) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String ORA_HASH(Object expression,
            long maxBucket,
            long seed) {
            throw new NotSupportedException();
        }

        // control flow

        [Function]
        public static bool LNNVL(bool condition) {
            throw new NotSupportedException();
        }

        [Function]
        public static T NVL<T>(T ifNotNull,
            T otherwise) {
            throw new NotSupportedException();
        }

        [Function]
        public static T NVL2<T>(Object checkForNull,
            T ifNotNull,
            T ifNull) {
            throw new NotSupportedException();
        }

        // Aggregate

        [Function]
        public static T COLLECT<T>(Object expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static double CORR(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double CORR_K(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double CORR_K(Object expression1,
            Object expression2,
            Correlation correlation) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double CORR_S(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double CORR_S(Object expression1,
            Object expression2,
            Correlation correlation) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double COVAR_POP(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double COVAR_SAMP(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int DENSE_RANK(params int[] expressions) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int GROUPING_ID(params IComparable[] expressions) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int GROUP_ID() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String JSON_ARRAYAGG(IComparable expr) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String JSON_OBJECTAGG(IComparable key,
            IComparable value) {
            throw new NotSupportedException();
        }

        [Function]
        public static String LISTAGG(IComparable expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static String LISTAGG(IComparable expression,
            String delimiter) {
            throw new NotSupportedException();
        }

        [Function]
        public static int MEDIAN(Object expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_SLOPE(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_INTERCEPT(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static int REGR_COUNT(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_R2(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_AVGX(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_AVGY(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_SXX(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_SYY(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double REGR_SXY(Object expression1,
            Object expression2) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false, OmitArgumentsDelimiter = true)]
        public static T FIRST_VALUE<T>(T expression,
            Ignore ignore) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false, OmitArgumentsDelimiter = true)]
        public static T LAST_VALUE<T>(T expression,
            Ignore ignore) {
            throw new NotSupportedException();
        }

        // General

        [Function("ORDER SIBLINGS BY", OmitParentheses = true)]
        public static IWindowFrame ORDER_SIBLINGS(params ISortOrder[] sorts) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static IEntitySelectClause<T> RETURNING<T>(T entity,
            params IAlias[] expressions) where T : class, new() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<T> RETURNING<T>(T expression) where T : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2)> RETURNING<T1, T2>((T1, T2) expression)
            where T1 : IComparable
            where T2 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3)> RETURNING<T1, T2, T3>((T1, T2, T3) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3, T4)> RETURNING<T1, T2, T3, T4>((T1, T2, T3, T4) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable
            where T4 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3, T4, T5)> RETURNING<T1, T2, T3, T4, T5>((T1, T2, T3, T4, T5) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable
            where T4 : IComparable
            where T5 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static ITupleSelectClause<(T1, T2, T3, T4, T5, T6)> RETURNING<T1, T2, T3, T4, T5, T6>((T1, T2, T3, T4, T5, T6) expression)
            where T1 : IComparable
            where T2 : IComparable
            where T3 : IComparable
            where T4 : IComparable
            where T5 : IComparable
            where T6 : IComparable {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true, ParameterContext = ParameterContext.Select)]
        public static IEntitySelectClause<T> RETURNING<T>(params IAlias[] expressions)
            where T : class, new() {
            throw new NotSupportedException();
        }

        // MERGE declarations (same TSQL/Oracle)

        [Function(OmitParentheses = true, ParameterContext = ParameterContext.From)]
        public static MergeClause MERGE() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IMatchThen WHEN_MATCHED() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IMatchThen WHEN_NOT_MATCHED() {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Name changed to avoid clashing with <see cref="Linq.SQL.SQL.UPDATE{T}"/>
        /// </summary>
        [Function("UPDATE", OmitParentheses = true)]
        public static IUpdateSet MERGE_UPDATE() {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Name changed to avoid clashing with <see cref="Linq.SQL.SQL.INSERT"/>
        /// </summary>
        [Function("INSERT", OmitParentheses = true, OmitArgumentsDelimiter = true)]
        public static IClause MERGE_INSERT<T>(T columns,
            T values) {
            throw new NotSupportedException();
        }
        
        [Function("INSERT", OmitParentheses = true, OmitArgumentsDelimiter = true)]
        public static IClause MERGE_INSERT<TE, T>(IColumnsClause<TE, T> columns,
            T values) {
            throw new NotSupportedException();
        }

        // Sequence
        sealed class SequenceImpl<T> : ISequence<T> where T : IComparable<T> {
            private readonly String name;

            public SequenceImpl(string name) => this.name = name + ".";

            public override string ToString() => name;

            public T CURRVAL() => throw new NotSupportedException();

            public T NEXTVAL() => throw new NotSupportedException();
        }

        [Local]
        public static ISequence<T> Sequence<T>(String name) where T : IComparable<T> {
            return new SequenceImpl<T>(name);
        }

        // pseudocolumns

        [Function(OmitParentheses = true)]
        public static String ROWID() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static int ROWNUM() {
            throw new NotSupportedException();
        }

        // Error Logging

        [Function(OmitParentheses = true)]
        public static IErrorsInto LOG_ERRORS() {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IClause REJECT_LIMIT(int limit) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static int UNLIMITED() {
            throw new NotSupportedException();
        }

        // INSERT

        /**
     * Special INSERT, which translates to INTO clause. Used in multi-table inserts.
     */
        [Function("INTO", OmitParentheses = true, ParameterContext = ParameterContext.FromWithoutAlias)]
        public static IClause INSERT_INTO(Object tableReference) {
            throw new NotSupportedException();
        }

        // Flashback

        [Function(OmitParentheses = true)]
        public static IClause AS_OF(long SCN) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true)]
        public static IClause AS_OF(DateTimeOffset timestamp) {
            throw new NotSupportedException();
        }

        [Function(OmitParentheses = true, OmitArgumentsDelimiter = true)]
        public static DateTimeOffset PERIOD_FOR(String valid_time_column,
            DateTimeOffset timestamp) {
            throw new NotSupportedException();
        }

        public static void RegisterVendorCapabilities(this IConfiguration config) {
            config.Capabilities = new HashSet<Capability>(new[] {
                Capability.ALIAS_INSERT, Capability.ALIAS_UPDATE, Capability.ALIAS_DELETE
            });


            config.RegisterMethodSubstitution((String s) => s.Length, (String s) => SQL.LENGTH(s));
            config.RegisterGenericCapabilities();
            config.RegisterIdentifierQuoter(s => $"\"{s}\"");
        }
    }
}
