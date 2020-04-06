using System;
using System.Collections.Generic;

namespace Streamx.Linq.SQL.Grammar.Configuration {
    public interface IConfiguration {
        ISet<Capability> Capabilities { get; set; }

        void RegisterMethodSubstitution<T1, T2, TResult1, TResult2>(Func<T1, TResult1> from,
            Func<T2, TResult2> to,
            bool considerParameterTypes = false);

        void RegisterMethodSubstitution<T1, T2, T3, T4, TResult1, TResult2>(Func<T1, T2, TResult1> from,
            Func<T3, T4, TResult2> to,
            bool considerParameterTypes = false);

        void RegisterMethodSubstitution<T1, T2, T3, T4, T5, T6, TResult1, TResult2>(Func<T1, T2, T5, TResult1> from,
            Func<T3, T4, T6, TResult2> to,
            bool considerParameterTypes = false);

        void RegisterMethodSubstitution<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2>(Func<T1, T2, T5, T7, TResult1> from,
            Func<T3, T4, T6, T8, TResult2> to,
            bool considerParameterTypes = false);

        void RegisterMethodSubstitution<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2>(Func<T1, T2, T5, T7, T9, TResult1> from,
            Func<T3, T4, T6, T8, T10, TResult2> to,
            bool considerParameterTypes = false);

        void RegisterIdentifierQuoter(Func<String, String> quoter);
    }
}
