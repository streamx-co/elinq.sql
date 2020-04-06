using System;
using System.Runtime.CompilerServices;
using Streamx.Linq.SQL.Grammar;

namespace Streamx.Linq.SQL {

    public interface IProjection<T> where T : class {
        [Function(""), ViewDeclarationAttribute.From(Aliased = true)]
        T EntityAliased(T source, params IComparable[] overrides);
    }
    
    public interface IProjection<T, TTuple> : IProjection<T>
        where T : class
        where TTuple : struct, ITuple {
        
        /// <summary>
        /// Generates column names declaration (e.g. for INSERT)
        /// </summary>
        [Function(""), ViewDeclarationAttribute.From]
        IColumnsClause<T, TTuple> ColumnNames();

        /// <summary>
        /// Generate a record for VALUES by specifying value for each column
        /// </summary>
        /// <param name="tuple">C# value tuple, e.g. <code>(blog.Name, blog.Author)</code></param>
        [Function(""), ViewDeclarationAttribute.Row]
        TTuple Row(TTuple tuple);
        
        /// <summary>
        /// Logically cast tuple to entity (e.g. for SELECT)
        /// </summary>
        [Function(""), ViewDeclarationAttribute.Row(Aliased = true)]
        T Entity(TTuple tuple);

        /// <summary>
        /// Logically cast tuple to entity with alias (e.g. for FROM)
        /// </summary>
        [Function(""), ViewDeclarationAttribute.From(Aliased = true)]
        T EntityAliased(TTuple tuple);
        
        /// <summary>
        /// Generate a record for VALUES from an entity
        /// </summary>
        /// <param name="source">entity</param>
        /// <param name="overrides">override some fields, in <code>@using</code> order, from the end</param>
        [Function(""), ViewDeclarationAttribute.From]
        TTuple RowFrom(T source, params IComparable[] overrides);
        
        /// <summary>
        /// Generate a record for VALUES from a tuple
        /// </summary>
        /// <param name="tuple">tuple</param>
        /// <param name="overrides">override some fields, in <code>@using</code> order, from the end</param>
        [Function(""), ViewDeclarationAttribute.From]
        TTuple RowFrom(TTuple tuple, params IComparable[] overrides);
    }
}
