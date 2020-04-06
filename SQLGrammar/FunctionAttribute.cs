using System;

namespace Streamx.Linq.SQL.Grammar {
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property), Notation]
    public sealed class FunctionAttribute : Attribute {
        public string Name { get; }
        public bool OmitParentheses { get; set; }
        public bool OmitParenthesesIfArgumentless { get; set; }
        public bool OmitArgumentsDelimiter { get; set; }
        public ParameterContext ParameterContext { get; set; } = ParameterContext.Inherit;
        public string[] ParameterContextCapabilities { get; set; } = Array.Empty<string>();
        public string ArgumentsDelimiter { get; set; } = ",";
        public bool UnderscoresAsBlanks { get; set; } = true;
        public bool RequiresAlias { get; set; }

        public FunctionAttribute() { }

        public FunctionAttribute(string name) {
            Name = name;
        }
    }
}