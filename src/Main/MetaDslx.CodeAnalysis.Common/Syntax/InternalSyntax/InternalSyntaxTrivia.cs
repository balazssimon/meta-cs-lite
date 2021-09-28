using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public abstract class InternalSyntaxTrivia : InternalSyntaxNode
    {
        public readonly string Text;

        protected InternalSyntaxTrivia(ushort kind, string text, DiagnosticInfo[]? diagnostics = null, SyntaxAnnotation[]? annotations = null)
            : base(kind, diagnostics, annotations, text.Length)
        {
            this.Text = text;
        }

        public override Language Language => throw ExceptionUtilities.Unreachable;

        public override bool IsTrivia => true;

        public override string ToFullString()
        {
            return this.Text;
        }

        public override string ToString()
        {
            return this.Text;
        }

        internal protected override GreenNode GetSlot(int index)
        {
            throw ExceptionUtilities.Unreachable;
        }

        public override int Width
        {
            get
            {
                Debug.Assert(this.FullWidth == this.Text.Length);
                return this.FullWidth;
            }
        }

        public override int GetLeadingTriviaWidth()
        {
            return 0;
        }

        public override int GetTrailingTriviaWidth()
        {
            return 0;
        }

        public override TResult Accept<TResult>(InternalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitTrivia(this);
        }

        public override void Accept(InternalSyntaxVisitor visitor)
        {
            visitor.VisitTrivia(this);
        }

        protected override void WriteTriviaTo(System.IO.TextWriter writer)
        {
            writer.Write(Text);
        }

        public static implicit operator SyntaxTrivia(InternalSyntaxTrivia trivia)
        {
            return new SyntaxTrivia(default(SyntaxToken), trivia, position: 0, index: 0);
        }

        public override bool IsEquivalentTo(GreenNode? other)
        {
            if (!base.IsEquivalentTo(other))
            {
                return false;
            }

            if (this.Text != ((InternalSyntaxTrivia)other).Text)
            {
                return false;
            }

            return true;
        }

        internal protected override SyntaxNode CreateRed(SyntaxNode? parent, int position)
        {
            throw ExceptionUtilities.Unreachable;
        }

        protected static DiagnosticInfo[] ExtractDiagnosticsFromGreenNode(GreenNode node)
        {
            return node.GetDiagnostics();
        }

        protected static SyntaxAnnotation[] ExtractAnnotationsFromGreenNode(GreenNode node)
        {
            return node.GetAnnotations();
        }
    }
}
