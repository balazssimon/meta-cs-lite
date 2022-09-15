using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MetaDslx.CodeAnalysis.CodeGeneration
{
    public class CodeTemplateLexer
    {
        private static readonly Regex IdentifierRegex = new Regex("[a-zA-Z_][a-zA-Z_0-9]*");
        private static readonly Regex NumberRegex = new Regex(@"[0-9]+\.?[0-9]*");
        private static readonly Regex StringRegex = new Regex(@"""[^""\\]*(?:\\.[^""\\]*)*"")");
        private static readonly Regex VerbatimStringRegex = new Regex(@"@(""[^""]*"")+");
        private static readonly Regex SingleLineCommentRegex = new Regex(@"//[^\r\n]*");
        private static readonly Regex MultiLineCommentStartRegex = new Regex(@"/\*([^*]*\*?)*?");
        private static readonly Regex MultiLineCommentEndRegex = new Regex(@"([^*]*\*)*?/");
        private static readonly Regex MultiLineCommentSingleLineRegex = new Regex(@"/\*([^*]*\*)*?/");
        // new Regex(@"/\*.*?\*/", RegexOptions.Singleline);
        // https://stackoverflow.com/questions/4400348/match-c-sharp-unicode-identifier-using-regex

        private enum State
        {
            None,
            MatchedNamespace,
            MatchedGenerator,
            MatchedControl,
            MatchedUsings,
            MatchedTemplate,
            MultiLineComment,
            TemplateName,
            TemplateParams,
            TemplateOutput,
            TemplateControl
        }

        private State _state;
        private SlidingTextWindow _text;

        public CodeTemplateLexer(SourceText text)
        {
            _state = State.None;
            _text = new SlidingTextWindow(text);
        }

        public CodeTemplateToken Lex()
        {
            
        }
    }
}
