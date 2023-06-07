// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// WARNING: This is an auto-generated file. Any manual changes will be lost when the file is regenerated.
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Antlr4;
using MetaDslx.CodeAnalysis.Text;

namespace MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax
{
    public class SandySyntaxLexer : Antlr4SyntaxLexer
    {
        public SandySyntaxLexer(SourceText text, SandyParseOptions options) 
            : base(text, options)
        {
        }
        protected override InternalSyntaxToken CreateToken(GreenNode? leadingTrivia, int kind, string text, GreenNode? trailingTrivia)
        {
            return SandyLanguage.Instance.InternalSyntaxFactory.Token(leadingTrivia, (SandySyntaxKind)kind, text, trailingTrivia);
        }
        protected override InternalSyntaxTrivia CreateTrivia(int kind, string text)
        {
            return SandyLanguage.Instance.InternalSyntaxFactory.Trivia((SandySyntaxKind)kind, text);
        }
    }
}

