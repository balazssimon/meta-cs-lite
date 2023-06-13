using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Roslyn.Utilities
{
    public static class StringUtilities
    {
        private static readonly IDictionary<string, string> escapeChars = new Dictionary<string, string>();
        private static readonly IDictionary<string, string> unescapeChars = new Dictionary<string, string>();
        private static readonly HashSet<string> csharpKeywords = new HashSet<string>() { 
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue",
            "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally",
            "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", 
            "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", 
            "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", 
            "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", 
            "using", "virtual", "void", "volatile", "while" };

        private const string regexStringEscapes = @"[\a\b\f\n\r\t\v\\""]";
        private const string regexStringUnescapes = @"\\[abfnrtv\\""]";
        private const string regexCharEscapes = @"[\a\b\f\n\r\t\v\\']";
        private const string regexCharUnescapes = @"\\[abfnrtv\\']";

        public static string EscapeStringLiteralValue(string text)
        {
            return Regex.Replace(text, regexStringEscapes, matchEscape);
        }

        public static string UnescapeStringLiteralValue(string text)
        {
            return Regex.Replace(text, regexStringUnescapes, matchUnescape);
        }

        public static string EscapeCharLiteralValue(string text)
        {
            return Regex.Replace(text, regexCharEscapes, matchEscape);
        }

        public static string UnescapeCharLiteralValue(string text)
        {
            return Regex.Replace(text, regexCharUnescapes, matchUnescape);
        }

        private static string matchEscape(Match m)
        {
            string match = m.ToString();
            if (escapeChars.ContainsKey(match))
            {
                return escapeChars[match];
            }
            throw new NotSupportedException();
        }

        private static string matchUnescape(Match m)
        {
            string match = m.ToString();
            if (unescapeChars.ContainsKey(match))
            {
                return unescapeChars[match];
            }
            throw new NotSupportedException();
        }

        static StringUtilities()
        {
            escapeChars.Add("\a", @"\a");
            escapeChars.Add("\b", @"\b");
            escapeChars.Add("\f", @"\f");
            escapeChars.Add("\n", @"\n");
            escapeChars.Add("\r", @"\r");
            escapeChars.Add("\t", @"\t");
            escapeChars.Add("\v", @"\v");
            escapeChars.Add("\\", @"\\");
            escapeChars.Add("\0", @"\0");
            escapeChars.Add("\"", "\\\"");
            escapeChars.Add("\'", "\\\'");

            unescapeChars.Add(@"\a", "\a");
            unescapeChars.Add(@"\b", "\b");
            unescapeChars.Add(@"\f", "\f");
            unescapeChars.Add(@"\n", "\n");
            unescapeChars.Add(@"\r", "\r");
            unescapeChars.Add(@"\t", "\t");
            unescapeChars.Add(@"\v", "\v");
            unescapeChars.Add(@"\\", "\\");
            unescapeChars.Add(@"\0", "\0");
            unescapeChars.Add("\\\"", "\"");
            unescapeChars.Add("\\\'", "\'");

        }

        public static string ToPascalCase(this string name)
        {
            if (string.IsNullOrEmpty(name)) return name;
            else return name[0].ToString().ToUpper() + name.Substring(1);
        }

        public static string ToCamelCase(this string name)
        {
            if (string.IsNullOrEmpty(name)) return name;
            else return name[0].ToString().ToLower() + name.Substring(1);
        }

        public static string EscapeCSharpKeyword(this string identifier)
        {
            if (string.IsNullOrEmpty(identifier)) return identifier;
            else if (csharpKeywords.Contains(identifier)) return $"@{identifier}";
            else return identifier;
        }

    }
}
