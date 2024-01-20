using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace MetaDslx.Languages.MetaGenerator.Syntax
{
    public enum MetaGeneratorTokenKind
    {
        None,
        EndOfFile,
        Whitespace,
        EndOfLine,
        IgnoredEndOfLine,
        SingleLineComment,
        MultiLineComment,
        Identifier,
        VerbatimIdentifier,
        Keyword,
        FormatterKeyword,
        String,
        VerbatimString,
        Number,
        TemplateOutputText,
        TemplateOutputWhitespace,
        TemplateOutputIgnoredWhitespace,
        TemplateOutputControlIgnoredWhitespace,
        TemplateOutputInvalidWhitespace,
        TemplateControlBegin,
        TemplateControlEnd,
        Other
    }

    public static class MetaGeneratorTokenKindExtensions
    {
        public static bool IsTemplateOutput(this MetaGeneratorTokenKind kind)
        {
            switch (kind)
            {
                case MetaGeneratorTokenKind.TemplateOutputText:
                case MetaGeneratorTokenKind.TemplateOutputWhitespace:
                case MetaGeneratorTokenKind.TemplateOutputIgnoredWhitespace:
                case MetaGeneratorTokenKind.TemplateOutputControlIgnoredWhitespace:
                case MetaGeneratorTokenKind.TemplateOutputInvalidWhitespace:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsTemplateWhitespace(this MetaGeneratorTokenKind kind)
        {
            switch (kind)
            {
                case MetaGeneratorTokenKind.TemplateOutputWhitespace:
                case MetaGeneratorTokenKind.TemplateOutputIgnoredWhitespace:
                case MetaGeneratorTokenKind.TemplateOutputControlIgnoredWhitespace:
                case MetaGeneratorTokenKind.TemplateOutputInvalidWhitespace:
                    return true;
                default:
                    return false;
            }
        }
    }
}
