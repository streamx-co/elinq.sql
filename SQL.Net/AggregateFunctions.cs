using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public static class AggregateFunctions {
        [Function]
        public static T AVG<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static byte GROUPING(params IComparable[] expressions) {
            throw new NotSupportedException();
        }

        [Function]
        public static int COUNT(IComparable expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static T MAX<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static T MIN<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static T SUM<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static T STDDEV<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static T STDDEV_POP<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static T STDDEV_SAMP<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static T VARIANCE<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static T VAR_POP<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static T VAR_SAMP<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static long ROW_NUMBER() {
            throw new NotSupportedException();
        }

        [Function]
        public static long RANK() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static long DENSE_RANK() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double PERCENTILE_CONT(double percentile) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        static double PERCENTILE_DISC(double percentile) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double PERCENT_RANK() {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static double CUME_DIST() {
            throw new NotSupportedException();
        }

        [Function]
        public static long NTILE(int numBuckets) {
            throw new NotSupportedException();
        }

        [Function]
        public static T LAG<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static T LAG<T>(T expression,
            int offset) {
            throw new NotSupportedException();
        }

        [Function]
        public static T LAG<T>(T expression,
            int offset,
            T defaultValue) {
            throw new NotSupportedException();
        }

        [Function]
        public static T LEAD<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function]
        public static T LEAD<T>(T expression,
            int offset) {
            throw new NotSupportedException();
        }

        [Function]
        public static T LEAD<T>(T expression,
            int offset,
            T defaultValue) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static T FIRST_VALUE<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static T LAST_VALUE<T>(T expression) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static T NTH_VALUE<T>(T expression,
            int nth) {
            throw new NotSupportedException();
        }

        [Function(UnderscoresAsBlanks = false)]
        public static String STRING_AGG(IComparable expression, String separator) {
            throw new NotSupportedException();
        }
    }
}
