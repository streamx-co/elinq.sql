namespace Streamx.Linq.SQL {
    public abstract class EnumWithBlanks : Enum {
        private string replaced;

        public override string ToString() => replaced ?? (replaced = base.ToString().Replace('_', ' '));
    }
}