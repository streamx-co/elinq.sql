namespace Streamx.Linq.SQL.Grammar {
    public enum CommonTableExpressionType {
        Declaration,

        /**
     * "Pass through" the CTE for later declaration
     */
        Decorator,

        /**
     * Reference the CTE which will be declared later
     */
        Reference,

        /**
     * Indicates that the annotated function marks the table to recurse on (i.e. should be the current sub-query return
     * type).
     */
        Self
    }
}