using System;
using System.Collections.Generic;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public abstract class InternalSyntaxToken : InternalSyntaxNode
    {
        //====================
        // Optimization: Normally, we wouldn't accept this much duplicate code, but these constructors
        // are called A LOT and we want to keep them as short and simple as possible and increase the
        // likelihood that they will be inlined.

        protected InternalSyntaxToken(ushort kind)
            : base(kind)
        {
            FullWidth = this.Text.Length;
            this.flags |= NodeFlags.IsNotMissing; //note: cleared by subclasses representing missing tokens
        }

        protected InternalSyntaxToken(ushort kind, DiagnosticInfo[]? diagnostics)
            : base(kind, diagnostics)
        {
            FullWidth = this.Text.Length;
            this.flags |= NodeFlags.IsNotMissing; //note: cleared by subclasses representing missing tokens
        }

        protected InternalSyntaxToken(ushort kind, DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations)
            : base(kind, diagnostics, annotations)
        {
            FullWidth = this.Text.Length;
            this.flags |= NodeFlags.IsNotMissing; //note: cleared by subclasses representing missing tokens
        }

        protected InternalSyntaxToken(ushort kind, int fullWidth)
            : base(kind, fullWidth)
        {
            this.flags |= NodeFlags.IsNotMissing; //note: cleared by subclasses representing missing tokens
        }

        protected InternalSyntaxToken(ushort kind, int fullWidth, DiagnosticInfo[]? diagnostics)
            : base(kind, diagnostics, fullWidth)
        {
            this.flags |= NodeFlags.IsNotMissing; //note: cleared by subclasses representing missing tokens
        }

        protected InternalSyntaxToken(ushort kind, int fullWidth, DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations)
            : base(kind, diagnostics, annotations, fullWidth)
        {
            this.flags |= NodeFlags.IsNotMissing; //note: cleared by subclasses representing missing tokens
        }

        //====================

        public override bool IsToken => true;

        internal protected override GreenNode GetSlot(int index)
        {
            throw ExceptionUtilities.Unreachable;
        }

        public virtual string Text
        {
            get { return Language.SyntaxFacts.GetText(this.RawKind); }
        }

        /// <summary>
        /// Returns the string representation of this token, not including its leading and trailing trivia.
        /// </summary>
        /// <returns>The string representation of this token, not including its leading and trailing trivia.</returns>
        /// <remarks>The length of the returned string is always the same as Span.Length</remarks>
        public override string ToString()
        {
            return this.Text;
        }

        public virtual object Value
        {
            get { return Language.SyntaxFacts.GetValue(this.RawKind); }
        }

        public override object GetValue()
        {
            return this.Value;
        }

        public virtual string ValueText
        {
            get { return this.Text; }
        }

        public override string GetValueText()
        {
            return this.ValueText;
        }

        public override int Width
        {
            get { return this.Text.Length; }
        }

        public override int GetLeadingTriviaWidth()
        {
            var leading = this.GetLeadingTrivia();
            return leading != null ? leading.FullWidth : 0;
        }

        public override int GetTrailingTriviaWidth()
        {
            var trailing = this.GetTrailingTrivia();
            return trailing != null ? trailing.FullWidth : 0;
        }

        internal InternalSyntax.SyntaxList<InternalSyntaxNode> LeadingTrivia
        {
            get { return new InternalSyntax.SyntaxList<InternalSyntaxNode>(this.GetLeadingTrivia()); }
        }

        internal InternalSyntax.SyntaxList<InternalSyntaxNode> TrailingTrivia
        {
            get { return new InternalSyntax.SyntaxList<InternalSyntaxNode>(this.GetTrailingTrivia()); }
        }

        internal override DirectiveStack ApplyDirectives(DirectiveStack stack)
        {
            if (this.ContainsDirectives)
            {
                stack = ApplyDirectivesToTrivia(this.GetLeadingTrivia(), stack);
                stack = ApplyDirectivesToTrivia(this.GetTrailingTrivia(), stack);
            }

            return stack;
        }

        private static DirectiveStack ApplyDirectivesToTrivia(GreenNode? triviaList, DirectiveStack stack)
        {
            if (triviaList != null && triviaList.ContainsDirectives)
            {
                return ApplyDirectivesToListOrNode(triviaList, stack);
            }

            return stack;
        }

        public override TResult Accept<TResult>(InternalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitToken(this);
        }

        public override void Accept(InternalSyntaxVisitor visitor)
        {
            visitor.VisitToken(this);
        }

        protected override void WriteTokenTo(System.IO.TextWriter writer, bool leading, bool trailing)
        {
            if (leading)
            {
                var trivia = this.GetLeadingTrivia();
                if (trivia != null)
                {
                    trivia.WriteTo(writer, true, true);
                }
            }

            writer.Write(this.Text);

            if (trailing)
            {
                var trivia = this.GetTrailingTrivia();
                if (trivia != null)
                {
                    trivia.WriteTo(writer, true, true);
                }
            }
        }

        public override bool IsEquivalentTo(GreenNode? other)
        {
            if (!base.IsEquivalentTo(other))
            {
                return false;
            }

            var otherToken = (InternalSyntaxToken)other;

            if (this.Text != otherToken.Text)
            {
                return false;
            }

            var thisLeading = this.GetLeadingTrivia();
            var otherLeading = otherToken.GetLeadingTrivia();
            if (thisLeading != otherLeading)
            {
                if (thisLeading == null || otherLeading == null)
                {
                    return false;
                }

                if (!thisLeading.IsEquivalentTo(otherLeading))
                {
                    return false;
                }
            }

            var thisTrailing = this.GetTrailingTrivia();
            var otherTrailing = otherToken.GetTrailingTrivia();
            if (thisTrailing != otherTrailing)
            {
                if (thisTrailing == null || otherTrailing == null)
                {
                    return false;
                }

                if (!thisTrailing.IsEquivalentTo(otherTrailing))
                {
                    return false;
                }
            }

            return true;
        }

        internal protected override SyntaxNode CreateRed(SyntaxNode? parent, int position)
        {
            throw ExceptionUtilities.Unreachable;
        }
    }
}
