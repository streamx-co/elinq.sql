using System;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {
    public interface IWhen<T> { }

    public interface ICaseThenFirst {
        [Function(OmitParentheses = true)]
        ICaseWhen<T> THEN<T>(T t) where T : IComparable;
        
        [Function(OmitParentheses = true)]
        ICaseWhen<T?> THEN<T>(T? t) where T : struct, IComparable;

        [Function(OmitParentheses = true)]
        ICaseWhen<Action> THEN(Action subQuery);

        [Function(OmitParentheses = true)]
        ICaseWhen<Action<T>> THEN<T>(Action<T> subQuery);
    }

    public interface ICaseWhen<T> : IWhen<T> {
        [Function(OmitParentheses = true)]
        ICaseThen<T> WHEN(bool condition);

        [Function(ArgumentsDelimiter = " THEN", OmitParentheses = true)]
        ICaseWhen<T> WHEN(bool condition,
            T result);

        [Function(OmitParentheses = true)]
        IWhen<T> ELSE(T expression);

        [Function(OmitParentheses = true)]
        IWhen<Action> ELSE(Action subQuery);

        [Function(OmitParentheses = true)]
        IWhen<Action<T1>> ELSE<T1>(Action<T1> subQuery);
    }

    public interface ICaseThen<T> {
        [Function(OmitParentheses = true)]
        ICaseWhen<T> THEN(T t);
    }

    public interface ICaseEnd<out T> {
        [Function(OmitParentheses = true)]
        T END { get; }
    }
}
