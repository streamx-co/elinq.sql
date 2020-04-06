using System;
using System.Text.RegularExpressions;

namespace Streamx.Linq.SQL.Grammar {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
    public class ToStringFormatterAttribute : Attribute {
        public ToStringFormatterAttribute(string pattern, string replacement) {
            Pattern = pattern;
            Replacement = replacement;
        }

        public String Pattern { get; }
        public String Replacement { get; }
        public bool IsRegex { get; set; }

        public string Replace(String input) => 
            IsRegex ? Regex.Replace(input, Pattern, Replacement) : input.Replace(Pattern, Replacement);
    }
}
