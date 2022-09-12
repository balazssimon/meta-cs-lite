using Antlr4.Runtime;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Antlr4
{
    public abstract class Antlr4SyntaxToken : InternalSyntaxToken, IToken
    {
        protected Antlr4SyntaxToken(ushort kind) : base(kind)
        {
        }

        protected Antlr4SyntaxToken(ushort kind, DiagnosticInfo[]? diagnostics) : base(kind, diagnostics)
        {
        }

        protected Antlr4SyntaxToken(ushort kind, int fullWidth) : base(kind, fullWidth)
        {
        }

        protected Antlr4SyntaxToken(ushort kind, DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations) : base(kind, diagnostics, annotations)
        {
        }

        protected Antlr4SyntaxToken(ushort kind, int fullWidth, DiagnosticInfo[]? diagnostics) : base(kind, fullWidth, diagnostics)
        {
        }

        protected Antlr4SyntaxToken(ushort kind, int fullWidth, DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations) : base(kind, fullWidth, diagnostics, annotations)
        {
        }

        string IToken.Text => this.Text;

        int IToken.Type => Antlr4SyntaxKind.ToAntlr4(this.RawKind);

        int IToken.Line => -1;

        int IToken.Column => -1;

        int IToken.Channel => 0;

        int IToken.TokenIndex => -1;

        int IToken.StartIndex => -1;

        int IToken.StopIndex => -1;

        ITokenSource IToken.TokenSource => null!;

        ICharStream IToken.InputStream => null!;
    }
}
