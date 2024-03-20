#nullable enable

namespace MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax
{
    using __Debug = System.Diagnostics.Debug;
    using __Language = global::MetaDslx.CodeAnalysis.Language;
    using __DiagnosticInfo = global::MetaDslx.CodeAnalysis.DiagnosticInfo;
    using __SyntaxAnnotation = global::MetaDslx.CodeAnalysis.SyntaxAnnotation;
    using __GreenNode = global::MetaDslx.CodeAnalysis.GreenNode;
    using __InternalSyntaxKind = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxKind;
    using __InternalSyntaxToken = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxToken;
    using __InternalSyntaxTrivia = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxTrivia;
    using __InternalSyntaxNode = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxNode;
    using __SyntaxToken = global::MetaDslx.CodeAnalysis.SyntaxToken;
    using __SyntaxTrivia = global::MetaDslx.CodeAnalysis.SyntaxTrivia;
    using __SyntaxNode = global::MetaDslx.CodeAnalysis.SyntaxNode;
    using __ArgumentNullException = global::System.ArgumentNullException;
    using __ArgumentException = global::System.ArgumentException;

    internal abstract class GreenSyntaxNode : __InternalSyntaxNode
    {
        protected GreenSyntaxNode(SoalSyntaxKind kind)
            : base((ushort)kind)
        {
        }

        protected GreenSyntaxNode(SoalSyntaxKind kind, int fullWidth)
            : base((ushort)kind, fullWidth)
        {
        }

        protected GreenSyntaxNode(SoalSyntaxKind kind, __DiagnosticInfo[] diagnostics)
            : base((ushort)kind, diagnostics)
        {
        }

        protected GreenSyntaxNode(SoalSyntaxKind kind, __DiagnosticInfo[] diagnostics, int fullWidth)
            : base((ushort)kind, diagnostics, fullWidth)
        {
        }

        protected GreenSyntaxNode(SoalSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base((ushort)kind, diagnostics, annotations)
        {
        }

        protected GreenSyntaxNode(SoalSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations, int fullWidth)
            : base((ushort)kind, diagnostics, annotations, fullWidth)
        {
        }

        public override TResult Accept<TResult>(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult> visitor)
        {
            if (visitor is SoalInternalSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public override void Accept(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor visitor) 
        {
            if (visitor is SoalInternalSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor);
        public abstract void Accept(SoalInternalSyntaxVisitor visitor);

        public override __Language Language => SoalLanguage.Instance;
        public SoalSyntaxKind Kind => (SoalSyntaxKind)this.RawKind;
        public override string KindText => SoalLanguage.Instance.SyntaxFacts.GetKindText(Kind);

        // Use conditional weak table so we always return same identity for structured trivia
        private static readonly global::System.Runtime.CompilerServices.ConditionalWeakTable<__SyntaxNode, global::System.Collections.Generic.Dictionary<__SyntaxTrivia, __SyntaxNode>> s_structuresTable
            = new global::System.Runtime.CompilerServices.ConditionalWeakTable<__SyntaxNode, global::System.Collections.Generic.Dictionary<__SyntaxTrivia, __SyntaxNode>>();

        /// <summary>
        /// Gets the syntax node represented the structure of this trivia, if any. The HasStructure property can be used to 
        /// determine if this trivia has structure.
        /// </summary>
        /// <returns>
        /// A SoalSyntaxNode derived from StructuredTriviaSyntax, with the structured view of this trivia node. 
        /// If this trivia node does not have structure, returns null.
        /// </returns>
        /// <remarks>
        /// Some types of trivia have structure that can be accessed as additional syntax nodes.
        /// These forms of trivia include: 
        ///   directives, where the structure describes the structure of the directive.
        ///   documentation comments, where the structure describes the XML structure of the comment.
        ///   skipped tokens, where the structure describes the tokens that were skipped by the parser.
        /// </remarks>
        public override __SyntaxNode GetStructure(__SyntaxTrivia trivia)
        {
            if (trivia.HasStructure)
            {
                var parent = trivia.Token.Parent;
                if (parent != null)
                {
                    __SyntaxNode structure;
                    var structsInParent = s_structuresTable.GetOrCreateValue(parent);
                    lock (structsInParent)
                    {
                        if (!structsInParent.TryGetValue(trivia, out structure))
                        {
                            structure = SoalStructuredTriviaSyntax.Create(trivia);
                            structsInParent.Add(trivia, structure);
                        }
                    }

                    return structure;
                }
                else
                {
                    return SoalStructuredTriviaSyntax.Create(trivia);
                }
            }

            return null;
        }

    }

    internal class GreenSyntaxTrivia : __InternalSyntaxTrivia
    {
        internal GreenSyntaxTrivia(SoalSyntaxKind kind, string text, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
            : base((ushort)kind, text, diagnostics, annotations)
        {
        }

        public override __Language Language => SoalLanguage.Instance;
        public SoalSyntaxKind Kind => (SoalSyntaxKind)this.RawKind;
        public override string KindText => SoalLanguage.Instance.SyntaxFacts.GetKindText(Kind);

        internal static GreenSyntaxTrivia Create(SoalSyntaxKind kind, string text)
        {
            return new GreenSyntaxTrivia(kind, text);
        }

        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new GreenSyntaxTrivia(this.Kind, this.Text, diagnostics, GetAnnotations());
        }

        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new GreenSyntaxTrivia(this.Kind, this.Text, GetDiagnostics(), annotations);
        }

        public override __GreenNode Clone()
        {
            return new GreenSyntaxTrivia(this.Kind, this.Text, GetDiagnostics(), GetAnnotations());
        }

        public static implicit operator __SyntaxTrivia(GreenSyntaxTrivia trivia)
        {
            return new __SyntaxTrivia(default, trivia, position: 0, index: 0);
        }
    }

    internal abstract class GreenStructuredTriviaSyntax : GreenSyntaxNode
    {
        internal GreenStructuredTriviaSyntax(SoalSyntaxKind kind, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
            : base(kind, diagnostics, annotations)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            this.flags |= NodeFlags.ContainsStructuredTrivia;

            if (this.RawKind == (int)__InternalSyntaxKind.SkippedTokensTrivia)
            {
                this.flags |= NodeFlags.ContainsSkippedText;
            }
        }

        public override bool IsStructuredTrivia => true;
    }

    internal sealed partial class GreenSkippedTokensTriviaSyntax : GreenStructuredTriviaSyntax
    {
        internal readonly __GreenNode tokens;

        internal GreenSkippedTokensTriviaSyntax(SoalSyntaxKind kind, __GreenNode tokens, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
            : base(kind, diagnostics, annotations)
        {
            this.SlotCount = 1;
            if (tokens != null)
            {
                this.AdjustFlagsAndWidth(tokens);
                this.tokens = tokens;
            }
        }

        public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<__InternalSyntaxToken> Tokens => new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<__InternalSyntaxToken>(this.tokens);

        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return this.tokens;
                default: return null;
            }
        }

        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position) => new SoalSkippedTokensTriviaSyntax(this, (SoalSyntaxNode)parent, position);

        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSkippedTokensTrivia(this);

        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSkippedTokensTrivia(this);

        public GreenSkippedTokensTriviaSyntax Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<__InternalSyntaxToken> tokens)
        {
            if (tokens != this.Tokens)
            {
                var newNode = Language.InternalSyntaxFactory.SkippedTokensTrivia(tokens.Node);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = global::MetaDslx.CodeAnalysis.GreenNodeExtensions.WithDiagnosticsGreen(newNode, diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = global::MetaDslx.CodeAnalysis.GreenNodeExtensions.WithAnnotationsGreen(newNode, annotations);
                return (GreenSkippedTokensTriviaSyntax)newNode;
            }
            return this;
        }

        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new GreenSkippedTokensTriviaSyntax(this.Kind, this.tokens, diagnostics, GetAnnotations());
        }

        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new GreenSkippedTokensTriviaSyntax(this.Kind, this.tokens, GetDiagnostics(), annotations);
        }

        public override __GreenNode Clone()
        {
            return new GreenSkippedTokensTriviaSyntax(this.Kind, this.tokens, GetDiagnostics(), GetAnnotations());
        }
    }

    internal partial class GreenSyntaxToken : __InternalSyntaxToken
    {
        //====================
        // Optimization: Normally, we wouldn't accept this much duplicate code, but these constructors
        // are called A LOT and we want to keep them as short and simple as possible and increase the
        // likelihood that they will be inlined.
        internal GreenSyntaxToken(SoalSyntaxKind kind)
            : base((ushort)kind)
        {
        }
        internal GreenSyntaxToken(SoalSyntaxKind kind, __DiagnosticInfo[] diagnostics)
            : base((ushort)kind, diagnostics)
        {
        }
        internal GreenSyntaxToken(SoalSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base((ushort)kind, diagnostics, annotations)
        {
        }
        internal GreenSyntaxToken(SoalSyntaxKind kind, int fullWidth)
            : base((ushort)kind, fullWidth)
        {
        }
        internal GreenSyntaxToken(SoalSyntaxKind kind, int fullWidth, __DiagnosticInfo[] diagnostics)
            : base((ushort)kind, fullWidth, diagnostics)
        {
        }
        internal GreenSyntaxToken(SoalSyntaxKind kind, int fullWidth, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base((ushort)kind, fullWidth, diagnostics, annotations)
        {
        }

        public override __Language Language => SoalLanguage.Instance;
        public SoalSyntaxKind Kind => (SoalSyntaxKind)this.RawKind;
        public override string KindText => SoalLanguage.Instance.SyntaxFacts.GetKindText(Kind);

        //====================

        internal static GreenSyntaxToken Create(SoalSyntaxKind kind)
        {
            if (kind > LastTokenWithWellKnownText)
            {
                if (!SoalLanguage.Instance.SyntaxFacts.IsToken(kind))
                {
                    throw new __ArgumentNullException(string.Format("Invalid SoalSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
                }
                return CreateMissing(kind, null, null);
            }
            return s_tokensWithNoTrivia[(int)kind].Value;
        }

        internal static GreenSyntaxToken Create(SoalSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
        {
            if (kind > LastTokenWithWellKnownText)
            {
                if (!SoalLanguage.Instance.SyntaxFacts.IsToken(kind))
                {
                    throw new __ArgumentNullException(string.Format("Invalid SoalSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
                }
                return CreateMissing(kind, leading, trailing);
            }
            if (leading == null)
            {
                if (trailing == null)
                {
                    return s_tokensWithNoTrivia[(int)kind].Value;
                }
                else if (trailing == SoalLanguage.Instance.InternalSyntaxFactory.Space)
                {
                    return s_tokensWithSingleTrailingSpace[(int)kind].Value;
                }
                else if (trailing == SoalLanguage.Instance.InternalSyntaxFactory.CarriageReturnLineFeed)
                {
                    return s_tokensWithSingleTrailingCRLF[(int)kind].Value;
                }
            }
            if (leading == SoalLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace && trailing == SoalLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace)
            {
                return s_tokensWithElasticTrivia[(int)kind].Value;
            }
            return new SyntaxTokenWithTrivia(kind, leading, trailing);
        }

        internal static GreenSyntaxToken CreateMissing(SoalSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
        {
            return new MissingTokenWithTrivia(kind, leading, trailing);
        }

        internal static readonly SoalSyntaxKind FirstTokenWithWellKnownText;
        internal static readonly SoalSyntaxKind LastTokenWithWellKnownText;
        // TODO: eliminate the blank space before the first interesting element?
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithNoTrivia;
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithElasticTrivia;
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingSpace;
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingCRLF;

        static GreenSyntaxToken()
        {
            FirstTokenWithWellKnownText = SoalSyntaxKind.__FirstFixedToken;
            LastTokenWithWellKnownText = SoalSyntaxKind.__LastFixedToken;
            s_tokensWithNoTrivia = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            s_tokensWithElasticTrivia = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            s_tokensWithSingleTrailingSpace = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            s_tokensWithSingleTrailingCRLF = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            var factory = SoalLanguage.Instance.InternalSyntaxFactory;
            for (SoalSyntaxKind kind = FirstTokenWithWellKnownText; kind <= LastTokenWithWellKnownText; kind++)
            {
                s_tokensWithNoTrivia[(int)kind].Value = new GreenSyntaxToken((SoalSyntaxKind)kind);
                s_tokensWithElasticTrivia[(int)kind].Value = new SyntaxTokenWithTrivia((SoalSyntaxKind)kind, factory.ElasticZeroSpace, factory.ElasticZeroSpace);
                s_tokensWithSingleTrailingSpace[(int)kind].Value = new SyntaxTokenWithTrivia((SoalSyntaxKind)kind, null, factory.Space);
                s_tokensWithSingleTrailingCRLF[(int)kind].Value = new SyntaxTokenWithTrivia((SoalSyntaxKind)kind, null, factory.CarriageReturnLineFeed);
            }
        }

        internal static global::System.Collections.Generic.IEnumerable<GreenSyntaxToken> GetWellKnownTokens()
        {
            foreach (var element in s_tokensWithNoTrivia)
            {
                if (element.Value != null)
                {
                    yield return element.Value;
                }
            }
            foreach (var element in s_tokensWithElasticTrivia)
            {
                if (element.Value != null)
                {
                    yield return element.Value;
                }
            }
            foreach (var element in s_tokensWithSingleTrailingSpace)
            {
                if (element.Value != null)
                {
                    yield return element.Value;
                }
            }
            foreach (var element in s_tokensWithSingleTrailingCRLF)
            {
                if (element.Value != null)
                {
                    yield return element.Value;
                }
            }
        }

        internal static GreenSyntaxToken Identifier(SoalSyntaxKind kind, string text)
        {
            return new SyntaxIdentifier(kind, text);
        }

        internal static GreenSyntaxToken Identifier(SoalSyntaxKind kind, __GreenNode leading, string text, __GreenNode trailing)
        {
            if (leading == null)
            {
                if (trailing == null)
                {
                    return Identifier(kind, text);
                }
                else
                {
                    return new SyntaxIdentifierWithTrailingTrivia(kind, text, trailing);
                }
            }
            return new SyntaxIdentifierWithTrivia(kind, kind, text, text, leading, trailing);
        }

        internal static GreenSyntaxToken Identifier(SoalSyntaxKind kind, SoalSyntaxKind contextualKind, __GreenNode leading, string text, string valueText, __GreenNode trailing)
        {
            if (contextualKind == kind && valueText == text)
            {
                return Identifier(kind, leading, text, trailing);
            }
            return new SyntaxIdentifierWithTrivia(kind, contextualKind, text, valueText, leading, trailing);
        }

        internal static GreenSyntaxToken WithValue<T>(SoalSyntaxKind kind, string text, T value)
        {
            return new SyntaxTokenWithValue<T>(kind, text, value);
        }

        internal static GreenSyntaxToken WithValue<T>(SoalSyntaxKind kind, __GreenNode? leading, string text, T value, __GreenNode? trailing)
        {
            return new SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing);
        }

        public new virtual SoalSyntaxKind ContextualKind => this.Kind;
        public override int RawContextualKind => (int)this.ContextualKind;

        public override __GreenNode WithLeadingTrivia(__GreenNode? trivia)
        {
            return TokenWithLeadingTrivia(trivia);
        }

        public override __GreenNode WithTrailingTrivia(__GreenNode? trivia)
        {
            return TokenWithTrailingTrivia(trivia);
        }

        public virtual __InternalSyntaxToken TokenWithLeadingTrivia(__GreenNode? trivia)
        {
            return new SyntaxTokenWithTrivia(this.Kind, trivia, null, this.GetDiagnostics(), this.GetAnnotations());
        }

        public virtual __InternalSyntaxToken TokenWithTrailingTrivia(__GreenNode? trivia)
        {
            return new SyntaxTokenWithTrivia(this.Kind, null, trivia, this.GetDiagnostics(), this.GetAnnotations());
        }

        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            __Debug.Assert(this.GetType() == typeof(GreenSyntaxToken));
            return new GreenSyntaxToken(this.Kind, this.FullWidth, diagnostics, this.GetAnnotations());
        }

        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            __Debug.Assert(this.GetType() == typeof(GreenSyntaxToken));
            return new GreenSyntaxToken(this.Kind, this.FullWidth, this.GetDiagnostics(), annotations);
        }

        public override __GreenNode Clone()
        {
            __Debug.Assert(this.GetType() == typeof(GreenSyntaxToken));
            return new GreenSyntaxToken(this.Kind, this.FullWidth, GetDiagnostics(), GetAnnotations());
        }

        public override TResult Accept<TResult>(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitToken(this);
        }

        public override void Accept(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor visitor)
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
                    trivia.WriteTo(writer);
                }
            }
            writer.Write(this.Text);
            if (trailing)
            {
                var trivia = this.GetTrailingTrivia();
                if (trivia != null)
                {
                    trivia.WriteTo(writer);
                }
            }
        }
    
        internal class MissingTokenWithTrivia : SyntaxTokenWithTrivia
        {
            internal MissingTokenWithTrivia(SoalSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
                : base(kind, leading, trailing)
            {
                this.flags &= ~NodeFlags.IsNotMissing;
            }

            internal MissingTokenWithTrivia(SoalSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
                : base(kind, leading, trailing, diagnostics, annotations)
            {
                this.flags &= ~NodeFlags.IsNotMissing;
            }

            public override string Text
            {
                get { return string.Empty; }
            }

            public override object Value
            {
                get
                {
                    if (SoalLanguage.Instance.SyntaxFacts.IsIdentifier(this.Kind)) return string.Empty;
                    else return null;
                }
            }

            public override __InternalSyntaxToken TokenWithLeadingTrivia(__GreenNode? trivia)
            {
                return new MissingTokenWithTrivia(this.Kind, trivia, this.TrailingField, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxToken TokenWithTrailingTrivia(__GreenNode? trivia)
            {
                return new MissingTokenWithTrivia(this.Kind, this.LeadingField, trivia, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
            {
                return new MissingTokenWithTrivia(this.Kind, this.LeadingField, this.TrailingField, diagnostics, this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
            {
                return new MissingTokenWithTrivia(this.Kind, this.LeadingField, this.TrailingField, this.GetDiagnostics(), annotations);
            }

            public override __GreenNode Clone()
            {
                return new MissingTokenWithTrivia(this.Kind, this.LeadingField, this.TrailingField, this.GetDiagnostics(), this.GetAnnotations());
            }
        }

        internal class SyntaxIdentifier : GreenSyntaxToken
        {
            protected readonly string TextField;

            internal SyntaxIdentifier(SoalSyntaxKind kind, string text)
                : base(kind, text.Length)
            {
                this.TextField = text;
            }

            internal SyntaxIdentifier(SoalSyntaxKind kind, string text, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
                : base(kind, text.Length, diagnostics, annotations)
            {
                this.TextField = text;
            }

            public override string Text
            {
                get { return this.TextField; }
            }

            public override object Value
            {
                get { return this.TextField; }
            }

            public override string ValueText
            {
                get { return this.TextField; }
            }

            public override __InternalSyntaxToken TokenWithLeadingTrivia(__GreenNode trivia)
            {
                return new SyntaxIdentifierWithTrivia(this.Kind, this.ContextualKind, this.TextField, this.TextField, trivia, null, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxToken TokenWithTrailingTrivia(__GreenNode trivia)
            {
                return new SyntaxIdentifierWithTrivia(this.Kind, this.ContextualKind, this.TextField, this.TextField, null, trivia, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
            {
                return new SyntaxIdentifier(this.Kind, this.Text, diagnostics, this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
            {
                return new SyntaxIdentifier(this.Kind, this.Text, this.GetDiagnostics(), annotations);
            }

            public override __GreenNode Clone()
            {
                return new SyntaxIdentifier(this.Kind, this.Text, this.GetDiagnostics(), this.GetAnnotations());
            }
        }

        internal class SyntaxIdentifierExtended : SyntaxIdentifier
        {
            protected readonly SoalSyntaxKind contextualKind;
            protected readonly string valueText;

            internal SyntaxIdentifierExtended(SoalSyntaxKind kind, SoalSyntaxKind contextualKind, string text, string valueText)
                : base(kind, text)
            {
                this.contextualKind = contextualKind;
                this.valueText = valueText;
            }

            internal SyntaxIdentifierExtended(SoalSyntaxKind kind, SoalSyntaxKind contextualKind, string text, string valueText, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
                : base(kind, text, diagnostics, annotations)
            {
                this.contextualKind = contextualKind;
                this.valueText = valueText;
            }

            public override SoalSyntaxKind ContextualKind
            {
                get { return this.contextualKind; }
            }

            public override string ValueText
            {
                get { return this.valueText; }
            }

            public override object Value
            {
                get { return this.valueText; }
            }

            public override __InternalSyntaxToken TokenWithLeadingTrivia(__GreenNode trivia)
            {
                return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, trivia, null, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxToken TokenWithTrailingTrivia(__GreenNode trivia)
            {
                return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, null, trivia, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
            {
                return new SyntaxIdentifierExtended(this.Kind, this.contextualKind, this.TextField, this.valueText, diagnostics, this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
            {
                return new SyntaxIdentifierExtended(this.Kind, this.contextualKind, this.TextField, this.valueText, this.GetDiagnostics(), annotations);
            }

            public override __GreenNode Clone()
            {
                return new SyntaxIdentifierExtended(this.Kind, this.contextualKind, this.TextField, this.valueText, this.GetDiagnostics(), this.GetAnnotations());
            }
        }

        internal class SyntaxIdentifierWithTrailingTrivia : SyntaxIdentifier
        {
            private readonly __GreenNode? _trailing;

            internal SyntaxIdentifierWithTrailingTrivia(SoalSyntaxKind kind, string text, __GreenNode? trailing)
                : base(kind, text)
            {
                if (trailing != null)
                {
                    this.AdjustFlagsAndWidth(trailing);
                    _trailing = trailing;
                }
            }

            internal SyntaxIdentifierWithTrailingTrivia(SoalSyntaxKind kind, string text, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
                : base(kind, text, diagnostics, annotations)
            {
                if (trailing != null)
                {
                    this.AdjustFlagsAndWidth(trailing);
                    _trailing = trailing;
                }
            }

            public override __GreenNode? GetTrailingTrivia()
            {
                return _trailing;
            }

            public override __InternalSyntaxToken TokenWithLeadingTrivia(__GreenNode? trivia)
            {
                return new SyntaxIdentifierWithTrivia(this.Kind, this.ContextualKind, this.TextField, this.TextField, trivia, _trailing, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxToken TokenWithTrailingTrivia(__GreenNode? trivia)
            {
                return new SyntaxIdentifierWithTrailingTrivia(this.Kind, this.TextField, trivia, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
            {
                return new SyntaxIdentifierWithTrailingTrivia(this.Kind, this.TextField, _trailing, diagnostics, this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
            {
                return new SyntaxIdentifierWithTrailingTrivia(this.Kind, this.TextField, _trailing, this.GetDiagnostics(), annotations);
            }

            public override __GreenNode Clone()
            {
                return new SyntaxIdentifierWithTrailingTrivia(this.Kind, this.TextField, _trailing, this.GetDiagnostics(), this.GetAnnotations());
            }
        }

        internal class SyntaxIdentifierWithTrivia : SyntaxIdentifierExtended
        {
            private readonly __GreenNode? _leading;
            private readonly __GreenNode? _trailing;

            internal SyntaxIdentifierWithTrivia(
                SoalSyntaxKind kind,
                SoalSyntaxKind contextualKind,
                string text,
                string valueText,
                __GreenNode? leading,
                __GreenNode? trailing)
                : base(kind, contextualKind, text, valueText)
            {
                if (leading != null)
                {
                    this.AdjustFlagsAndWidth(leading);
                    _leading = leading;
                }
                if (trailing != null)
                {
                    this.AdjustFlagsAndWidth(trailing);
                    _trailing = trailing;
                }
            }

            internal SyntaxIdentifierWithTrivia(
                SoalSyntaxKind kind,
                SoalSyntaxKind contextualKind,
                string text,
                string valueText,
                __GreenNode? leading,
                __GreenNode? trailing,
                __DiagnosticInfo[] diagnostics,
                __SyntaxAnnotation[] annotations)
                : base(kind, contextualKind, text, valueText, diagnostics, annotations)
            {
                if (leading != null)
                {
                    this.AdjustFlagsAndWidth(leading);
                    _leading = leading;
                }
                if (trailing != null)
                {
                    this.AdjustFlagsAndWidth(trailing);
                    _trailing = trailing;
                }
            }

            public override __GreenNode? GetLeadingTrivia()
            {
                return _leading;
            }

            public override __GreenNode? GetTrailingTrivia()
            {
                return _trailing;
            }

            public override __InternalSyntaxToken TokenWithLeadingTrivia(__GreenNode? trivia)
            {
                return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, trivia, _trailing, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxToken TokenWithTrailingTrivia(__GreenNode? trivia)
            {
                return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, _leading, trivia, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
            {
                return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, _leading, _trailing, diagnostics, this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
            {
                return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, _leading, _trailing, this.GetDiagnostics(), annotations);
            }

            public override __GreenNode Clone()
            {
                return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, _leading, _trailing, this.GetDiagnostics(), this.GetAnnotations());
            }
        }

        internal class SyntaxTokenWithValue<T> : GreenSyntaxToken
        {
            protected readonly string TextField;
            protected readonly T ValueField;

            internal SyntaxTokenWithValue(SoalSyntaxKind kind, string text, T value)
                : base(kind, text.Length)
            {
                this.TextField = text;
                this.ValueField = value;
            }

            internal SyntaxTokenWithValue(SoalSyntaxKind kind, string text, T value, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
                : base(kind, text.Length, diagnostics, annotations)
            {
                this.TextField = text;
                this.ValueField = value;
            }

            public override string Text
            {
                get
                {
                    return this.TextField;
                }
            }

            public override object Value
            {
                get
                {
                    return this.ValueField;
                }
            }

            public override string ValueText
            {
                get
                {
                    return global::System.Convert.ToString(this.ValueField, global::System.Globalization.CultureInfo.InvariantCulture);
                }
            }

            public override __InternalSyntaxToken TokenWithLeadingTrivia(__GreenNode trivia)
            {
                return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, trivia, null, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxToken TokenWithTrailingTrivia(__GreenNode trivia)
            {
                return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, null, trivia, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
            {
                return new SyntaxTokenWithValue<T>(this.Kind, this.TextField, this.ValueField, diagnostics, this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
            {
                return new SyntaxTokenWithValue<T>(this.Kind, this.TextField, this.ValueField, this.GetDiagnostics(), annotations);
            }

            public override __GreenNode Clone()
            {
                return new SyntaxTokenWithValue<T>(this.Kind, this.TextField, this.ValueField, this.GetDiagnostics(), this.GetAnnotations());
            }
        }
    
        internal class SyntaxTokenWithValueAndTrivia<T> : SyntaxTokenWithValue<T>
        {
            private readonly __GreenNode? _leading;
            private readonly __GreenNode? _trailing;

            internal SyntaxTokenWithValueAndTrivia(SoalSyntaxKind kind, string text, T value, __GreenNode? leading, __GreenNode? trailing)
                : base(kind, text, value)
            {
                if (leading != null)
                {
                    this.AdjustFlagsAndWidth(leading);
                    _leading = leading;
                }
                if (trailing != null)
                {
                    this.AdjustFlagsAndWidth(trailing);
                    _trailing = trailing;
                }
            }

            internal SyntaxTokenWithValueAndTrivia(
                SoalSyntaxKind kind,
                string text,
                T value,
                __GreenNode? leading,
                __GreenNode? trailing,
                __DiagnosticInfo[] diagnostics,
                __SyntaxAnnotation[] annotations)
                : base(kind, text, value, diagnostics, annotations)
            {
                if (leading != null)
                {
                    this.AdjustFlagsAndWidth(leading);
                    _leading = leading;
                }
                if (trailing != null)
                {
                    this.AdjustFlagsAndWidth(trailing);
                    _trailing = trailing;
                }
            }

            public override __GreenNode? GetLeadingTrivia()
            {
                return _leading;
            }

            public override __GreenNode? GetTrailingTrivia()
            {
                return _trailing;
            }

            public override __InternalSyntaxToken TokenWithLeadingTrivia(__GreenNode? trivia)
            {
                return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, trivia, _trailing, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxToken TokenWithTrailingTrivia(__GreenNode? trivia)
            {
                return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, _leading, trivia, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
            {
                return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, _leading, _trailing, diagnostics, this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
            {
                return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, _leading, _trailing, this.GetDiagnostics(), annotations);
            }

            public override __GreenNode Clone()
            {
                return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, _leading, _trailing, this.GetDiagnostics(), this.GetAnnotations());
            }
        }

        internal class SyntaxTokenWithTrivia : GreenSyntaxToken
        {
            protected readonly __GreenNode? LeadingField;
            protected readonly __GreenNode? TrailingField;

            internal SyntaxTokenWithTrivia(SoalSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
                : base(kind)
            {
                if (leading != null)
                {
                    this.AdjustFlagsAndWidth(leading);
                    this.LeadingField = leading;
                }
                if (trailing != null)
                {
                    this.AdjustFlagsAndWidth(trailing);
                    this.TrailingField = trailing;
                }
            }

            internal SyntaxTokenWithTrivia(SoalSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
                : base(kind, diagnostics, annotations)
            {
                if (leading != null)
                {
                    this.AdjustFlagsAndWidth(leading);
                    this.LeadingField = leading;
                }
                if (trailing != null)
                {
                    this.AdjustFlagsAndWidth(trailing);
                    this.TrailingField = trailing;
                }
            }

            public override __GreenNode? GetLeadingTrivia()
            {
                return this.LeadingField;
            }

            public override __GreenNode? GetTrailingTrivia()
            {
                return this.TrailingField;
            }

            public override __InternalSyntaxToken TokenWithLeadingTrivia(__GreenNode? trivia)
            {
                return new SyntaxTokenWithTrivia(this.Kind, trivia, this.TrailingField, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxToken TokenWithTrailingTrivia(__GreenNode? trivia)
            {
                return new SyntaxTokenWithTrivia(this.Kind, this.LeadingField, trivia, this.GetDiagnostics(), this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
            {
                return new SyntaxTokenWithTrivia(this.Kind, this.LeadingField, this.TrailingField, diagnostics, this.GetAnnotations());
            }

            public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
            {
                return new SyntaxTokenWithTrivia(this.Kind, this.LeadingField, this.TrailingField, this.GetDiagnostics(), annotations);
            }

            public override __GreenNode Clone()
            {
                return new SyntaxTokenWithTrivia(this.Kind, this.LeadingField, this.TrailingField, this.GetDiagnostics(), this.GetAnnotations());
            }
        }
    }

    internal class MainGreen : GreenSyntaxNode
    {
        internal static new readonly MainGreen __Missing = new MainGreen();
        private __InternalSyntaxToken _kNamespace;
        private QualifierGreen _qualifier;
        private __InternalSyntaxToken _tSemicolon;
        private __GreenNode _usingList;
        private MainBlock1Green _block;
        private __InternalSyntaxToken _endOfFileToken;
    
        public MainGreen(SoalSyntaxKind kind, __InternalSyntaxToken kNamespace, QualifierGreen qualifier, __InternalSyntaxToken tSemicolon, __GreenNode usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken)
            : base(kind, null, null)
        {
            SlotCount = 6;
            if (kNamespace != null)
            {
                AdjustFlagsAndWidth(kNamespace);
                _kNamespace = kNamespace;
            }
            if (qualifier != null)
            {
                AdjustFlagsAndWidth(qualifier);
                _qualifier = qualifier;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
            if (usingList != null)
            {
                AdjustFlagsAndWidth(usingList);
                _usingList = usingList;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (endOfFileToken != null)
            {
                AdjustFlagsAndWidth(endOfFileToken);
                _endOfFileToken = endOfFileToken;
            }
        }
    
        public MainGreen(SoalSyntaxKind kind, __InternalSyntaxToken kNamespace, QualifierGreen qualifier, __InternalSyntaxToken tSemicolon, __GreenNode usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 6;
            if (kNamespace != null)
            {
                AdjustFlagsAndWidth(kNamespace);
                _kNamespace = kNamespace;
            }
            if (qualifier != null)
            {
                AdjustFlagsAndWidth(qualifier);
                _qualifier = qualifier;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
            if (usingList != null)
            {
                AdjustFlagsAndWidth(usingList);
                _usingList = usingList;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (endOfFileToken != null)
            {
                AdjustFlagsAndWidth(endOfFileToken);
                _endOfFileToken = endOfFileToken;
            }
        }
    
        private MainGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.Main, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KNamespace { get { return _kNamespace; } }
        public QualifierGreen Qualifier { get { return _qualifier; } }
        public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> UsingList { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen>(_usingList); } }
        public MainBlock1Green Block { get { return _block; } }
        public __InternalSyntaxToken EndOfFileToken { get { return _endOfFileToken; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.MainSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kNamespace;
                case 1: return _qualifier;
                case 2: return _tSemicolon;
                case 3: return _usingList;
                case 4: return _block;
                case 5: return _endOfFileToken;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitMainGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MainGreen(this.Kind, _kNamespace, _qualifier, _tSemicolon, _usingList, _block, _endOfFileToken, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MainGreen(this.Kind, _kNamespace, _qualifier, _tSemicolon, _usingList, _block, _endOfFileToken, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MainGreen(this.Kind, _kNamespace, _qualifier, _tSemicolon, _usingList, _block, _endOfFileToken, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MainGreen Update(__InternalSyntaxToken kNamespace, QualifierGreen qualifier, __InternalSyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken)
        {
            if (_kNamespace != kNamespace || _qualifier != qualifier || _tSemicolon != tSemicolon || _usingList != usingList.Node || _block != block || _endOfFileToken != endOfFileToken)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.Main(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MainGreen)newNode;
            }
            return this;
        }
    }
    internal class UsingGreen : GreenSyntaxNode
    {
        internal static new readonly UsingGreen __Missing = new UsingGreen();
        private __InternalSyntaxToken _kUsing;
        private QualifierGreen _namespaces;
        private __InternalSyntaxToken _tSemicolon;
    
        public UsingGreen(SoalSyntaxKind kind, __InternalSyntaxToken kUsing, QualifierGreen namespaces, __InternalSyntaxToken tSemicolon)
            : base(kind, null, null)
        {
            SlotCount = 3;
            if (kUsing != null)
            {
                AdjustFlagsAndWidth(kUsing);
                _kUsing = kUsing;
            }
            if (namespaces != null)
            {
                AdjustFlagsAndWidth(namespaces);
                _namespaces = namespaces;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        public UsingGreen(SoalSyntaxKind kind, __InternalSyntaxToken kUsing, QualifierGreen namespaces, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
            if (kUsing != null)
            {
                AdjustFlagsAndWidth(kUsing);
                _kUsing = kUsing;
            }
            if (namespaces != null)
            {
                AdjustFlagsAndWidth(namespaces);
                _namespaces = namespaces;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        private UsingGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.Using, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KUsing { get { return _kUsing; } }
        public QualifierGreen Namespaces { get { return _namespaces; } }
        public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.UsingSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kUsing;
                case 1: return _namespaces;
                case 2: return _tSemicolon;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitUsingGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitUsingGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new UsingGreen(this.Kind, _kUsing, _namespaces, _tSemicolon, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new UsingGreen(this.Kind, _kUsing, _namespaces, _tSemicolon, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new UsingGreen(this.Kind, _kUsing, _namespaces, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public UsingGreen Update(__InternalSyntaxToken kUsing, QualifierGreen namespaces, __InternalSyntaxToken tSemicolon)
        {
            if (_kUsing != kUsing || _namespaces != namespaces || _tSemicolon != tSemicolon)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.Using(kUsing, namespaces, tSemicolon);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (UsingGreen)newNode;
            }
            return this;
        }
    }
    internal abstract class DeclarationGreen : GreenSyntaxNode
    {
        internal static readonly DeclarationGreen __Missing = DeclarationAlt1Green.__Missing;
    
        protected DeclarationGreen(SoalSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class DeclarationAlt1Green : DeclarationGreen
    {
        internal static new readonly DeclarationAlt1Green __Missing = new DeclarationAlt1Green();
        private EnumTypeGreen _enumType;
    
        public DeclarationAlt1Green(SoalSyntaxKind kind, EnumTypeGreen enumType)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (enumType != null)
            {
                AdjustFlagsAndWidth(enumType);
                _enumType = enumType;
            }
        }
    
        public DeclarationAlt1Green(SoalSyntaxKind kind, EnumTypeGreen enumType, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (enumType != null)
            {
                AdjustFlagsAndWidth(enumType);
                _enumType = enumType;
            }
        }
    
        private DeclarationAlt1Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.DeclarationAlt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public EnumTypeGreen EnumType { get { return _enumType; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.DeclarationAlt1Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _enumType;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitDeclarationAlt1Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitDeclarationAlt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new DeclarationAlt1Green(this.Kind, _enumType, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new DeclarationAlt1Green(this.Kind, _enumType, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new DeclarationAlt1Green(this.Kind, _enumType, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public DeclarationAlt1Green Update(EnumTypeGreen enumType)
        {
            if (_enumType != enumType)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.DeclarationAlt1(enumType);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (DeclarationAlt1Green)newNode;
            }
            return this;
        }
    }
    internal class DeclarationAlt2Green : DeclarationGreen
    {
        internal static new readonly DeclarationAlt2Green __Missing = new DeclarationAlt2Green();
        private StructTypeGreen _structType;
    
        public DeclarationAlt2Green(SoalSyntaxKind kind, StructTypeGreen structType)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (structType != null)
            {
                AdjustFlagsAndWidth(structType);
                _structType = structType;
            }
        }
    
        public DeclarationAlt2Green(SoalSyntaxKind kind, StructTypeGreen structType, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (structType != null)
            {
                AdjustFlagsAndWidth(structType);
                _structType = structType;
            }
        }
    
        private DeclarationAlt2Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.DeclarationAlt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public StructTypeGreen StructType { get { return _structType; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.DeclarationAlt2Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _structType;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitDeclarationAlt2Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitDeclarationAlt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new DeclarationAlt2Green(this.Kind, _structType, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new DeclarationAlt2Green(this.Kind, _structType, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new DeclarationAlt2Green(this.Kind, _structType, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public DeclarationAlt2Green Update(StructTypeGreen structType)
        {
            if (_structType != structType)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.DeclarationAlt2(structType);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (DeclarationAlt2Green)newNode;
            }
            return this;
        }
    }
    internal class DeclarationAlt3Green : DeclarationGreen
    {
        internal static new readonly DeclarationAlt3Green __Missing = new DeclarationAlt3Green();
        private InterfaceGreen _interface;
    
        public DeclarationAlt3Green(SoalSyntaxKind kind, InterfaceGreen @interface)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (@interface != null)
            {
                AdjustFlagsAndWidth(@interface);
                _interface = @interface;
            }
        }
    
        public DeclarationAlt3Green(SoalSyntaxKind kind, InterfaceGreen @interface, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (@interface != null)
            {
                AdjustFlagsAndWidth(@interface);
                _interface = @interface;
            }
        }
    
        private DeclarationAlt3Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.DeclarationAlt3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public InterfaceGreen Interface { get { return _interface; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.DeclarationAlt3Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _interface;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitDeclarationAlt3Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitDeclarationAlt3Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new DeclarationAlt3Green(this.Kind, _interface, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new DeclarationAlt3Green(this.Kind, _interface, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new DeclarationAlt3Green(this.Kind, _interface, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public DeclarationAlt3Green Update(InterfaceGreen @interface)
        {
            if (_interface != @interface)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.DeclarationAlt3(@interface);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (DeclarationAlt3Green)newNode;
            }
            return this;
        }
    }
    internal class DeclarationAlt4Green : DeclarationGreen
    {
        internal static new readonly DeclarationAlt4Green __Missing = new DeclarationAlt4Green();
        private ServiceGreen _service;
    
        public DeclarationAlt4Green(SoalSyntaxKind kind, ServiceGreen service)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (service != null)
            {
                AdjustFlagsAndWidth(service);
                _service = service;
            }
        }
    
        public DeclarationAlt4Green(SoalSyntaxKind kind, ServiceGreen service, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (service != null)
            {
                AdjustFlagsAndWidth(service);
                _service = service;
            }
        }
    
        private DeclarationAlt4Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.DeclarationAlt4, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public ServiceGreen Service { get { return _service; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.DeclarationAlt4Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _service;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitDeclarationAlt4Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitDeclarationAlt4Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new DeclarationAlt4Green(this.Kind, _service, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new DeclarationAlt4Green(this.Kind, _service, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new DeclarationAlt4Green(this.Kind, _service, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public DeclarationAlt4Green Update(ServiceGreen service)
        {
            if (_service != service)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.DeclarationAlt4(service);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (DeclarationAlt4Green)newNode;
            }
            return this;
        }
    }
    internal class EnumTypeGreen : GreenSyntaxNode
    {
        internal static new readonly EnumTypeGreen __Missing = new EnumTypeGreen();
        private __InternalSyntaxToken _kEnum;
        private NameGreen _name;
        private __InternalSyntaxToken _tLBrace;
        private EnumTypeBlock1Green _block;
        private __InternalSyntaxToken _tRBrace;
    
        public EnumTypeGreen(SoalSyntaxKind kind, __InternalSyntaxToken kEnum, NameGreen name, __InternalSyntaxToken tLBrace, EnumTypeBlock1Green block, __InternalSyntaxToken tRBrace)
            : base(kind, null, null)
        {
            SlotCount = 5;
            if (kEnum != null)
            {
                AdjustFlagsAndWidth(kEnum);
                _kEnum = kEnum;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tLBrace != null)
            {
                AdjustFlagsAndWidth(tLBrace);
                _tLBrace = tLBrace;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (tRBrace != null)
            {
                AdjustFlagsAndWidth(tRBrace);
                _tRBrace = tRBrace;
            }
        }
    
        public EnumTypeGreen(SoalSyntaxKind kind, __InternalSyntaxToken kEnum, NameGreen name, __InternalSyntaxToken tLBrace, EnumTypeBlock1Green block, __InternalSyntaxToken tRBrace, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 5;
            if (kEnum != null)
            {
                AdjustFlagsAndWidth(kEnum);
                _kEnum = kEnum;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tLBrace != null)
            {
                AdjustFlagsAndWidth(tLBrace);
                _tLBrace = tLBrace;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (tRBrace != null)
            {
                AdjustFlagsAndWidth(tRBrace);
                _tRBrace = tRBrace;
            }
        }
    
        private EnumTypeGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.EnumType, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KEnum { get { return _kEnum; } }
        public NameGreen Name { get { return _name; } }
        public __InternalSyntaxToken TLBrace { get { return _tLBrace; } }
        public EnumTypeBlock1Green Block { get { return _block; } }
        public __InternalSyntaxToken TRBrace { get { return _tRBrace; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.EnumTypeSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kEnum;
                case 1: return _name;
                case 2: return _tLBrace;
                case 3: return _block;
                case 4: return _tRBrace;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitEnumTypeGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitEnumTypeGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new EnumTypeGreen(this.Kind, _kEnum, _name, _tLBrace, _block, _tRBrace, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new EnumTypeGreen(this.Kind, _kEnum, _name, _tLBrace, _block, _tRBrace, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new EnumTypeGreen(this.Kind, _kEnum, _name, _tLBrace, _block, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public EnumTypeGreen Update(__InternalSyntaxToken kEnum, NameGreen name, __InternalSyntaxToken tLBrace, EnumTypeBlock1Green block, __InternalSyntaxToken tRBrace)
        {
            if (_kEnum != kEnum || _name != name || _tLBrace != tLBrace || _block != block || _tRBrace != tRBrace)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.EnumType(kEnum, name, tLBrace, block, tRBrace);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (EnumTypeGreen)newNode;
            }
            return this;
        }
    }
    internal class EnumLiteralGreen : GreenSyntaxNode
    {
        internal static new readonly EnumLiteralGreen __Missing = new EnumLiteralGreen();
        private NameGreen _name;
    
        public EnumLiteralGreen(SoalSyntaxKind kind, NameGreen name)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
        }
    
        public EnumLiteralGreen(SoalSyntaxKind kind, NameGreen name, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
        }
    
        private EnumLiteralGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.EnumLiteral, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public NameGreen Name { get { return _name; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.EnumLiteralSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _name;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitEnumLiteralGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitEnumLiteralGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new EnumLiteralGreen(this.Kind, _name, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new EnumLiteralGreen(this.Kind, _name, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new EnumLiteralGreen(this.Kind, _name, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public EnumLiteralGreen Update(NameGreen name)
        {
            if (_name != name)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.EnumLiteral(name);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (EnumLiteralGreen)newNode;
            }
            return this;
        }
    }
    internal class StructTypeGreen : GreenSyntaxNode
    {
        internal static new readonly StructTypeGreen __Missing = new StructTypeGreen();
        private __InternalSyntaxToken _kStruct;
        private NameGreen _name;
        private StructTypeBlock1Green _block;
        private __InternalSyntaxToken _tLBrace;
        private __GreenNode _fields;
        private __InternalSyntaxToken _tRBrace;
    
        public StructTypeGreen(SoalSyntaxKind kind, __InternalSyntaxToken kStruct, NameGreen name, StructTypeBlock1Green block, __InternalSyntaxToken tLBrace, __GreenNode fields, __InternalSyntaxToken tRBrace)
            : base(kind, null, null)
        {
            SlotCount = 6;
            if (kStruct != null)
            {
                AdjustFlagsAndWidth(kStruct);
                _kStruct = kStruct;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (tLBrace != null)
            {
                AdjustFlagsAndWidth(tLBrace);
                _tLBrace = tLBrace;
            }
            if (fields != null)
            {
                AdjustFlagsAndWidth(fields);
                _fields = fields;
            }
            if (tRBrace != null)
            {
                AdjustFlagsAndWidth(tRBrace);
                _tRBrace = tRBrace;
            }
        }
    
        public StructTypeGreen(SoalSyntaxKind kind, __InternalSyntaxToken kStruct, NameGreen name, StructTypeBlock1Green block, __InternalSyntaxToken tLBrace, __GreenNode fields, __InternalSyntaxToken tRBrace, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 6;
            if (kStruct != null)
            {
                AdjustFlagsAndWidth(kStruct);
                _kStruct = kStruct;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (tLBrace != null)
            {
                AdjustFlagsAndWidth(tLBrace);
                _tLBrace = tLBrace;
            }
            if (fields != null)
            {
                AdjustFlagsAndWidth(fields);
                _fields = fields;
            }
            if (tRBrace != null)
            {
                AdjustFlagsAndWidth(tRBrace);
                _tRBrace = tRBrace;
            }
        }
    
        private StructTypeGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.StructType, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KStruct { get { return _kStruct; } }
        public NameGreen Name { get { return _name; } }
        public StructTypeBlock1Green Block { get { return _block; } }
        public __InternalSyntaxToken TLBrace { get { return _tLBrace; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<PropertyGreen> Fields { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<PropertyGreen>(_fields); } }
        public __InternalSyntaxToken TRBrace { get { return _tRBrace; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.StructTypeSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kStruct;
                case 1: return _name;
                case 2: return _block;
                case 3: return _tLBrace;
                case 4: return _fields;
                case 5: return _tRBrace;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitStructTypeGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitStructTypeGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new StructTypeGreen(this.Kind, _kStruct, _name, _block, _tLBrace, _fields, _tRBrace, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new StructTypeGreen(this.Kind, _kStruct, _name, _block, _tLBrace, _fields, _tRBrace, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new StructTypeGreen(this.Kind, _kStruct, _name, _block, _tLBrace, _fields, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public StructTypeGreen Update(__InternalSyntaxToken kStruct, NameGreen name, StructTypeBlock1Green block, __InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<PropertyGreen> fields, __InternalSyntaxToken tRBrace)
        {
            if (_kStruct != kStruct || _name != name || _block != block || _tLBrace != tLBrace || _fields != fields.Node || _tRBrace != tRBrace)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.StructType(kStruct, name, block, tLBrace, fields, tRBrace);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (StructTypeGreen)newNode;
            }
            return this;
        }
    }
    internal class PropertyGreen : GreenSyntaxNode
    {
        internal static new readonly PropertyGreen __Missing = new PropertyGreen();
        private TypeReferenceGreen _type;
        private NameGreen _name;
        private __InternalSyntaxToken _tSemicolon;
    
        public PropertyGreen(SoalSyntaxKind kind, TypeReferenceGreen type, NameGreen name, __InternalSyntaxToken tSemicolon)
            : base(kind, null, null)
        {
            SlotCount = 3;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        public PropertyGreen(SoalSyntaxKind kind, TypeReferenceGreen type, NameGreen name, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        private PropertyGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.Property, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public TypeReferenceGreen Type { get { return _type; } }
        public NameGreen Name { get { return _name; } }
        public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.PropertySyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _type;
                case 1: return _name;
                case 2: return _tSemicolon;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitPropertyGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new PropertyGreen(this.Kind, _type, _name, _tSemicolon, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new PropertyGreen(this.Kind, _type, _name, _tSemicolon, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new PropertyGreen(this.Kind, _type, _name, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public PropertyGreen Update(TypeReferenceGreen type, NameGreen name, __InternalSyntaxToken tSemicolon)
        {
            if (_type != type || _name != name || _tSemicolon != tSemicolon)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.Property(type, name, tSemicolon);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (PropertyGreen)newNode;
            }
            return this;
        }
    }
    internal class InterfaceGreen : GreenSyntaxNode
    {
        internal static new readonly InterfaceGreen __Missing = new InterfaceGreen();
        private __InternalSyntaxToken _kInterface;
        private NameGreen _name;
        private __InternalSyntaxToken _tLBrace;
        private __GreenNode _resources;
        private __GreenNode _operations;
        private __InternalSyntaxToken _tRBrace;
    
        public InterfaceGreen(SoalSyntaxKind kind, __InternalSyntaxToken kInterface, NameGreen name, __InternalSyntaxToken tLBrace, __GreenNode resources, __GreenNode operations, __InternalSyntaxToken tRBrace)
            : base(kind, null, null)
        {
            SlotCount = 6;
            if (kInterface != null)
            {
                AdjustFlagsAndWidth(kInterface);
                _kInterface = kInterface;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tLBrace != null)
            {
                AdjustFlagsAndWidth(tLBrace);
                _tLBrace = tLBrace;
            }
            if (resources != null)
            {
                AdjustFlagsAndWidth(resources);
                _resources = resources;
            }
            if (operations != null)
            {
                AdjustFlagsAndWidth(operations);
                _operations = operations;
            }
            if (tRBrace != null)
            {
                AdjustFlagsAndWidth(tRBrace);
                _tRBrace = tRBrace;
            }
        }
    
        public InterfaceGreen(SoalSyntaxKind kind, __InternalSyntaxToken kInterface, NameGreen name, __InternalSyntaxToken tLBrace, __GreenNode resources, __GreenNode operations, __InternalSyntaxToken tRBrace, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 6;
            if (kInterface != null)
            {
                AdjustFlagsAndWidth(kInterface);
                _kInterface = kInterface;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tLBrace != null)
            {
                AdjustFlagsAndWidth(tLBrace);
                _tLBrace = tLBrace;
            }
            if (resources != null)
            {
                AdjustFlagsAndWidth(resources);
                _resources = resources;
            }
            if (operations != null)
            {
                AdjustFlagsAndWidth(operations);
                _operations = operations;
            }
            if (tRBrace != null)
            {
                AdjustFlagsAndWidth(tRBrace);
                _tRBrace = tRBrace;
            }
        }
    
        private InterfaceGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.Interface, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KInterface { get { return _kInterface; } }
        public NameGreen Name { get { return _name; } }
        public __InternalSyntaxToken TLBrace { get { return _tLBrace; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ResourceGreen> Resources { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ResourceGreen>(_resources); } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<OperationGreen> Operations { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<OperationGreen>(_operations); } }
        public __InternalSyntaxToken TRBrace { get { return _tRBrace; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.InterfaceSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kInterface;
                case 1: return _name;
                case 2: return _tLBrace;
                case 3: return _resources;
                case 4: return _operations;
                case 5: return _tRBrace;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitInterfaceGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitInterfaceGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new InterfaceGreen(this.Kind, _kInterface, _name, _tLBrace, _resources, _operations, _tRBrace, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new InterfaceGreen(this.Kind, _kInterface, _name, _tLBrace, _resources, _operations, _tRBrace, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new InterfaceGreen(this.Kind, _kInterface, _name, _tLBrace, _resources, _operations, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public InterfaceGreen Update(__InternalSyntaxToken kInterface, NameGreen name, __InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ResourceGreen> resources, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<OperationGreen> operations, __InternalSyntaxToken tRBrace)
        {
            if (_kInterface != kInterface || _name != name || _tLBrace != tLBrace || _resources != resources.Node || _operations != operations.Node || _tRBrace != tRBrace)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.Interface(kInterface, name, tLBrace, resources, operations, tRBrace);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (InterfaceGreen)newNode;
            }
            return this;
        }
    }
    internal class ResourceGreen : GreenSyntaxNode
    {
        internal static new readonly ResourceGreen __Missing = new ResourceGreen();
        private __InternalSyntaxToken _isReadOnly;
        private __InternalSyntaxToken _kResource;
        private QualifierGreen _entity;
        private ResourceBlock1Green _block;
        private __InternalSyntaxToken _tSemicolon;
    
        public ResourceGreen(SoalSyntaxKind kind, __InternalSyntaxToken isReadOnly, __InternalSyntaxToken kResource, QualifierGreen entity, ResourceBlock1Green block, __InternalSyntaxToken tSemicolon)
            : base(kind, null, null)
        {
            SlotCount = 5;
            if (isReadOnly != null)
            {
                AdjustFlagsAndWidth(isReadOnly);
                _isReadOnly = isReadOnly;
            }
            if (kResource != null)
            {
                AdjustFlagsAndWidth(kResource);
                _kResource = kResource;
            }
            if (entity != null)
            {
                AdjustFlagsAndWidth(entity);
                _entity = entity;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        public ResourceGreen(SoalSyntaxKind kind, __InternalSyntaxToken isReadOnly, __InternalSyntaxToken kResource, QualifierGreen entity, ResourceBlock1Green block, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 5;
            if (isReadOnly != null)
            {
                AdjustFlagsAndWidth(isReadOnly);
                _isReadOnly = isReadOnly;
            }
            if (kResource != null)
            {
                AdjustFlagsAndWidth(kResource);
                _kResource = kResource;
            }
            if (entity != null)
            {
                AdjustFlagsAndWidth(entity);
                _entity = entity;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        private ResourceGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.Resource, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsReadOnly { get { return _isReadOnly; } }
        public __InternalSyntaxToken KResource { get { return _kResource; } }
        public QualifierGreen Entity { get { return _entity; } }
        public ResourceBlock1Green Block { get { return _block; } }
        public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.ResourceSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isReadOnly;
                case 1: return _kResource;
                case 2: return _entity;
                case 3: return _block;
                case 4: return _tSemicolon;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitResourceGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitResourceGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ResourceGreen(this.Kind, _isReadOnly, _kResource, _entity, _block, _tSemicolon, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ResourceGreen(this.Kind, _isReadOnly, _kResource, _entity, _block, _tSemicolon, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ResourceGreen(this.Kind, _isReadOnly, _kResource, _entity, _block, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ResourceGreen Update(__InternalSyntaxToken isReadOnly, __InternalSyntaxToken kResource, QualifierGreen entity, ResourceBlock1Green block, __InternalSyntaxToken tSemicolon)
        {
            if (_isReadOnly != isReadOnly || _kResource != kResource || _entity != entity || _block != block || _tSemicolon != tSemicolon)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.Resource(isReadOnly, kResource, entity, block, tSemicolon);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ResourceGreen)newNode;
            }
            return this;
        }
    }
    internal class OperationGreen : GreenSyntaxNode
    {
        internal static new readonly OperationGreen __Missing = new OperationGreen();
        private __InternalSyntaxToken _isAsync;
        private OutputParameterListGreen _responseParameters;
        private NameGreen _name;
        private InputParameterListGreen _requestParameters;
        private OperationBlock1Green _block;
        private __InternalSyntaxToken _tSemicolon;
    
        public OperationGreen(SoalSyntaxKind kind, __InternalSyntaxToken isAsync, OutputParameterListGreen responseParameters, NameGreen name, InputParameterListGreen requestParameters, OperationBlock1Green block, __InternalSyntaxToken tSemicolon)
            : base(kind, null, null)
        {
            SlotCount = 6;
            if (isAsync != null)
            {
                AdjustFlagsAndWidth(isAsync);
                _isAsync = isAsync;
            }
            if (responseParameters != null)
            {
                AdjustFlagsAndWidth(responseParameters);
                _responseParameters = responseParameters;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (requestParameters != null)
            {
                AdjustFlagsAndWidth(requestParameters);
                _requestParameters = requestParameters;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        public OperationGreen(SoalSyntaxKind kind, __InternalSyntaxToken isAsync, OutputParameterListGreen responseParameters, NameGreen name, InputParameterListGreen requestParameters, OperationBlock1Green block, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 6;
            if (isAsync != null)
            {
                AdjustFlagsAndWidth(isAsync);
                _isAsync = isAsync;
            }
            if (responseParameters != null)
            {
                AdjustFlagsAndWidth(responseParameters);
                _responseParameters = responseParameters;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (requestParameters != null)
            {
                AdjustFlagsAndWidth(requestParameters);
                _requestParameters = requestParameters;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        private OperationGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.Operation, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsAsync { get { return _isAsync; } }
        public OutputParameterListGreen ResponseParameters { get { return _responseParameters; } }
        public NameGreen Name { get { return _name; } }
        public InputParameterListGreen RequestParameters { get { return _requestParameters; } }
        public OperationBlock1Green Block { get { return _block; } }
        public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.OperationSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isAsync;
                case 1: return _responseParameters;
                case 2: return _name;
                case 3: return _requestParameters;
                case 4: return _block;
                case 5: return _tSemicolon;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOperationGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitOperationGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OperationGreen(this.Kind, _isAsync, _responseParameters, _name, _requestParameters, _block, _tSemicolon, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OperationGreen(this.Kind, _isAsync, _responseParameters, _name, _requestParameters, _block, _tSemicolon, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OperationGreen(this.Kind, _isAsync, _responseParameters, _name, _requestParameters, _block, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OperationGreen Update(__InternalSyntaxToken isAsync, OutputParameterListGreen responseParameters, NameGreen name, InputParameterListGreen requestParameters, OperationBlock1Green block, __InternalSyntaxToken tSemicolon)
        {
            if (_isAsync != isAsync || _responseParameters != responseParameters || _name != name || _requestParameters != requestParameters || _block != block || _tSemicolon != tSemicolon)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.Operation(isAsync, responseParameters, name, requestParameters, block, tSemicolon);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OperationGreen)newNode;
            }
            return this;
        }
    }
    internal class InputParameterListGreen : GreenSyntaxNode
    {
        internal static new readonly InputParameterListGreen __Missing = new InputParameterListGreen();
        private __InternalSyntaxToken _tLParen;
        private InputParameterListBlock1Green _block;
        private __InternalSyntaxToken _tRParen;
    
        public InputParameterListGreen(SoalSyntaxKind kind, __InternalSyntaxToken tLParen, InputParameterListBlock1Green block, __InternalSyntaxToken tRParen)
            : base(kind, null, null)
        {
            SlotCount = 3;
            if (tLParen != null)
            {
                AdjustFlagsAndWidth(tLParen);
                _tLParen = tLParen;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (tRParen != null)
            {
                AdjustFlagsAndWidth(tRParen);
                _tRParen = tRParen;
            }
        }
    
        public InputParameterListGreen(SoalSyntaxKind kind, __InternalSyntaxToken tLParen, InputParameterListBlock1Green block, __InternalSyntaxToken tRParen, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
            if (tLParen != null)
            {
                AdjustFlagsAndWidth(tLParen);
                _tLParen = tLParen;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (tRParen != null)
            {
                AdjustFlagsAndWidth(tRParen);
                _tRParen = tRParen;
            }
        }
    
        private InputParameterListGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.InputParameterList, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TLParen { get { return _tLParen; } }
        public InputParameterListBlock1Green Block { get { return _block; } }
        public __InternalSyntaxToken TRParen { get { return _tRParen; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.InputParameterListSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tLParen;
                case 1: return _block;
                case 2: return _tRParen;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitInputParameterListGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitInputParameterListGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new InputParameterListGreen(this.Kind, _tLParen, _block, _tRParen, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new InputParameterListGreen(this.Kind, _tLParen, _block, _tRParen, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new InputParameterListGreen(this.Kind, _tLParen, _block, _tRParen, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public InputParameterListGreen Update(__InternalSyntaxToken tLParen, InputParameterListBlock1Green block, __InternalSyntaxToken tRParen)
        {
            if (_tLParen != tLParen || _block != block || _tRParen != tRParen)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.InputParameterList(tLParen, block, tRParen);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (InputParameterListGreen)newNode;
            }
            return this;
        }
    }
    internal abstract class OutputParameterListGreen : GreenSyntaxNode
    {
        internal static readonly OutputParameterListGreen __Missing = OutputParameterListAlt1Green.__Missing;
    
        protected OutputParameterListGreen(SoalSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class OutputParameterListAlt1Green : OutputParameterListGreen
    {
        internal static new readonly OutputParameterListAlt1Green __Missing = new OutputParameterListAlt1Green();
        private __InternalSyntaxToken _kVoid;
    
        public OutputParameterListAlt1Green(SoalSyntaxKind kind, __InternalSyntaxToken kVoid)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kVoid != null)
            {
                AdjustFlagsAndWidth(kVoid);
                _kVoid = kVoid;
            }
        }
    
        public OutputParameterListAlt1Green(SoalSyntaxKind kind, __InternalSyntaxToken kVoid, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kVoid != null)
            {
                AdjustFlagsAndWidth(kVoid);
                _kVoid = kVoid;
            }
        }
    
        private OutputParameterListAlt1Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.OutputParameterListAlt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KVoid { get { return _kVoid; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.OutputParameterListAlt1Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kVoid;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOutputParameterListAlt1Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitOutputParameterListAlt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OutputParameterListAlt1Green(this.Kind, _kVoid, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OutputParameterListAlt1Green(this.Kind, _kVoid, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OutputParameterListAlt1Green(this.Kind, _kVoid, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OutputParameterListAlt1Green Update(__InternalSyntaxToken kVoid)
        {
            if (_kVoid != kVoid)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.OutputParameterListAlt1(kVoid);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OutputParameterListAlt1Green)newNode;
            }
            return this;
        }
    }
    internal class OutputParameterListAlt2Green : OutputParameterListGreen
    {
        internal static new readonly OutputParameterListAlt2Green __Missing = new OutputParameterListAlt2Green();
        private SingleReturnParameterGreen _parameters;
    
        public OutputParameterListAlt2Green(SoalSyntaxKind kind, SingleReturnParameterGreen parameters)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        public OutputParameterListAlt2Green(SoalSyntaxKind kind, SingleReturnParameterGreen parameters, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        private OutputParameterListAlt2Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.OutputParameterListAlt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public SingleReturnParameterGreen Parameters { get { return _parameters; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.OutputParameterListAlt2Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _parameters;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOutputParameterListAlt2Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitOutputParameterListAlt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OutputParameterListAlt2Green(this.Kind, _parameters, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OutputParameterListAlt2Green(this.Kind, _parameters, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OutputParameterListAlt2Green(this.Kind, _parameters, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OutputParameterListAlt2Green Update(SingleReturnParameterGreen parameters)
        {
            if (_parameters != parameters)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.OutputParameterListAlt2(parameters);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OutputParameterListAlt2Green)newNode;
            }
            return this;
        }
    }
    internal class OutputParameterListAlt3Green : OutputParameterListGreen
    {
        internal static new readonly OutputParameterListAlt3Green __Missing = new OutputParameterListAlt3Green();
        private __InternalSyntaxToken _tLParen;
        private __GreenNode _parameters;
        private __InternalSyntaxToken _tRParen;
    
        public OutputParameterListAlt3Green(SoalSyntaxKind kind, __InternalSyntaxToken tLParen, __GreenNode parameters, __InternalSyntaxToken tRParen)
            : base(kind, null, null)
        {
            SlotCount = 3;
            if (tLParen != null)
            {
                AdjustFlagsAndWidth(tLParen);
                _tLParen = tLParen;
            }
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
            if (tRParen != null)
            {
                AdjustFlagsAndWidth(tRParen);
                _tRParen = tRParen;
            }
        }
    
        public OutputParameterListAlt3Green(SoalSyntaxKind kind, __InternalSyntaxToken tLParen, __GreenNode parameters, __InternalSyntaxToken tRParen, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
            if (tLParen != null)
            {
                AdjustFlagsAndWidth(tLParen);
                _tLParen = tLParen;
            }
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
            if (tRParen != null)
            {
                AdjustFlagsAndWidth(tRParen);
                _tRParen = tRParen;
            }
        }
    
        private OutputParameterListAlt3Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.OutputParameterListAlt3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TLParen { get { return _tLParen; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen> Parameters { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen>(_parameters, reversed: false); } }
        public __InternalSyntaxToken TRParen { get { return _tRParen; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.OutputParameterListAlt3Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tLParen;
                case 1: return _parameters;
                case 2: return _tRParen;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOutputParameterListAlt3Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitOutputParameterListAlt3Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OutputParameterListAlt3Green(this.Kind, _tLParen, _parameters, _tRParen, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OutputParameterListAlt3Green(this.Kind, _tLParen, _parameters, _tRParen, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OutputParameterListAlt3Green(this.Kind, _tLParen, _parameters, _tRParen, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OutputParameterListAlt3Green Update(__InternalSyntaxToken tLParen, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen> parameters, __InternalSyntaxToken tRParen)
        {
            if (_tLParen != tLParen || _parameters != parameters.Node || _tRParen != tRParen)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.OutputParameterListAlt3(tLParen, parameters, tRParen);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OutputParameterListAlt3Green)newNode;
            }
            return this;
        }
    }
    internal class ParameterGreen : GreenSyntaxNode
    {
        internal static new readonly ParameterGreen __Missing = new ParameterGreen();
        private TypeReferenceGreen _type;
        private NameGreen _name;
    
        public ParameterGreen(SoalSyntaxKind kind, TypeReferenceGreen type, NameGreen name)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
        }
    
        public ParameterGreen(SoalSyntaxKind kind, TypeReferenceGreen type, NameGreen name, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
        }
    
        private ParameterGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.Parameter, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public TypeReferenceGreen Type { get { return _type; } }
        public NameGreen Name { get { return _name; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.ParameterSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _type;
                case 1: return _name;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParameterGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitParameterGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ParameterGreen(this.Kind, _type, _name, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ParameterGreen(this.Kind, _type, _name, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ParameterGreen(this.Kind, _type, _name, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ParameterGreen Update(TypeReferenceGreen type, NameGreen name)
        {
            if (_type != type || _name != name)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.Parameter(type, name);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ParameterGreen)newNode;
            }
            return this;
        }
    }
    internal class SingleReturnParameterGreen : GreenSyntaxNode
    {
        internal static new readonly SingleReturnParameterGreen __Missing = new SingleReturnParameterGreen();
        private TypeReferenceGreen _type;
    
        public SingleReturnParameterGreen(SoalSyntaxKind kind, TypeReferenceGreen type)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
            }
        }
    
        public SingleReturnParameterGreen(SoalSyntaxKind kind, TypeReferenceGreen type, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
            }
        }
    
        private SingleReturnParameterGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.SingleReturnParameter, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public TypeReferenceGreen Type { get { return _type; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SingleReturnParameterSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _type;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSingleReturnParameterGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSingleReturnParameterGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SingleReturnParameterGreen(this.Kind, _type, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SingleReturnParameterGreen(this.Kind, _type, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SingleReturnParameterGreen(this.Kind, _type, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SingleReturnParameterGreen Update(TypeReferenceGreen type)
        {
            if (_type != type)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SingleReturnParameter(type);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SingleReturnParameterGreen)newNode;
            }
            return this;
        }
    }
    internal class ServiceGreen : GreenSyntaxNode
    {
        internal static new readonly ServiceGreen __Missing = new ServiceGreen();
        private __InternalSyntaxToken _kService;
        private NameGreen _name;
        private __InternalSyntaxToken _tColon;
        private QualifierGreen _interface;
        private __InternalSyntaxToken _tLBrace;
        private __InternalSyntaxToken _kBinding;
        private BindingKindGreen _binding;
        private __InternalSyntaxToken _tSemicolon;
        private __InternalSyntaxToken _tRBrace;
    
        public ServiceGreen(SoalSyntaxKind kind, __InternalSyntaxToken kService, NameGreen name, __InternalSyntaxToken tColon, QualifierGreen @interface, __InternalSyntaxToken tLBrace, __InternalSyntaxToken kBinding, BindingKindGreen binding, __InternalSyntaxToken tSemicolon, __InternalSyntaxToken tRBrace)
            : base(kind, null, null)
        {
            SlotCount = 9;
            if (kService != null)
            {
                AdjustFlagsAndWidth(kService);
                _kService = kService;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tColon != null)
            {
                AdjustFlagsAndWidth(tColon);
                _tColon = tColon;
            }
            if (@interface != null)
            {
                AdjustFlagsAndWidth(@interface);
                _interface = @interface;
            }
            if (tLBrace != null)
            {
                AdjustFlagsAndWidth(tLBrace);
                _tLBrace = tLBrace;
            }
            if (kBinding != null)
            {
                AdjustFlagsAndWidth(kBinding);
                _kBinding = kBinding;
            }
            if (binding != null)
            {
                AdjustFlagsAndWidth(binding);
                _binding = binding;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
            if (tRBrace != null)
            {
                AdjustFlagsAndWidth(tRBrace);
                _tRBrace = tRBrace;
            }
        }
    
        public ServiceGreen(SoalSyntaxKind kind, __InternalSyntaxToken kService, NameGreen name, __InternalSyntaxToken tColon, QualifierGreen @interface, __InternalSyntaxToken tLBrace, __InternalSyntaxToken kBinding, BindingKindGreen binding, __InternalSyntaxToken tSemicolon, __InternalSyntaxToken tRBrace, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 9;
            if (kService != null)
            {
                AdjustFlagsAndWidth(kService);
                _kService = kService;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tColon != null)
            {
                AdjustFlagsAndWidth(tColon);
                _tColon = tColon;
            }
            if (@interface != null)
            {
                AdjustFlagsAndWidth(@interface);
                _interface = @interface;
            }
            if (tLBrace != null)
            {
                AdjustFlagsAndWidth(tLBrace);
                _tLBrace = tLBrace;
            }
            if (kBinding != null)
            {
                AdjustFlagsAndWidth(kBinding);
                _kBinding = kBinding;
            }
            if (binding != null)
            {
                AdjustFlagsAndWidth(binding);
                _binding = binding;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
            if (tRBrace != null)
            {
                AdjustFlagsAndWidth(tRBrace);
                _tRBrace = tRBrace;
            }
        }
    
        private ServiceGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.Service, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KService { get { return _kService; } }
        public NameGreen Name { get { return _name; } }
        public __InternalSyntaxToken TColon { get { return _tColon; } }
        public QualifierGreen Interface { get { return _interface; } }
        public __InternalSyntaxToken TLBrace { get { return _tLBrace; } }
        public __InternalSyntaxToken KBinding { get { return _kBinding; } }
        public BindingKindGreen Binding { get { return _binding; } }
        public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
        public __InternalSyntaxToken TRBrace { get { return _tRBrace; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.ServiceSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kService;
                case 1: return _name;
                case 2: return _tColon;
                case 3: return _interface;
                case 4: return _tLBrace;
                case 5: return _kBinding;
                case 6: return _binding;
                case 7: return _tSemicolon;
                case 8: return _tRBrace;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitServiceGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitServiceGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ServiceGreen(this.Kind, _kService, _name, _tColon, _interface, _tLBrace, _kBinding, _binding, _tSemicolon, _tRBrace, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ServiceGreen(this.Kind, _kService, _name, _tColon, _interface, _tLBrace, _kBinding, _binding, _tSemicolon, _tRBrace, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ServiceGreen(this.Kind, _kService, _name, _tColon, _interface, _tLBrace, _kBinding, _binding, _tSemicolon, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ServiceGreen Update(__InternalSyntaxToken kService, NameGreen name, __InternalSyntaxToken tColon, QualifierGreen @interface, __InternalSyntaxToken tLBrace, __InternalSyntaxToken kBinding, BindingKindGreen binding, __InternalSyntaxToken tSemicolon, __InternalSyntaxToken tRBrace)
        {
            if (_kService != kService || _name != name || _tColon != tColon || _interface != @interface || _tLBrace != tLBrace || _kBinding != kBinding || _binding != binding || _tSemicolon != tSemicolon || _tRBrace != tRBrace)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.Service(kService, name, tColon, @interface, tLBrace, kBinding, binding, tSemicolon, tRBrace);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ServiceGreen)newNode;
            }
            return this;
        }
    }
    internal class BindingKindGreen : GreenSyntaxNode
    {
        internal static new readonly BindingKindGreen __Missing = new BindingKindGreen();
        private __InternalSyntaxToken _token;
    
        public BindingKindGreen(SoalSyntaxKind kind, __InternalSyntaxToken token)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        public BindingKindGreen(SoalSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        private BindingKindGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.BindingKind, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken Token { get { return _token; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.BindingKindSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _token;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBindingKindGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitBindingKindGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new BindingKindGreen(this.Kind, _token, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new BindingKindGreen(this.Kind, _token, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new BindingKindGreen(this.Kind, _token, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public BindingKindGreen Update(__InternalSyntaxToken token)
        {
            if (_token != token)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.BindingKind(token);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (BindingKindGreen)newNode;
            }
            return this;
        }
    }
    internal class TypeReferenceGreen : GreenSyntaxNode
    {
        internal static new readonly TypeReferenceGreen __Missing = new TypeReferenceGreen();
        private SimpleTypeGreen _type;
        private __InternalSyntaxToken _isNullable;
        private TypeReferenceBlock1Green _isArray;
    
        public TypeReferenceGreen(SoalSyntaxKind kind, SimpleTypeGreen type, __InternalSyntaxToken isNullable, TypeReferenceBlock1Green isArray)
            : base(kind, null, null)
        {
            SlotCount = 3;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
            }
            if (isNullable != null)
            {
                AdjustFlagsAndWidth(isNullable);
                _isNullable = isNullable;
            }
            if (isArray != null)
            {
                AdjustFlagsAndWidth(isArray);
                _isArray = isArray;
            }
        }
    
        public TypeReferenceGreen(SoalSyntaxKind kind, SimpleTypeGreen type, __InternalSyntaxToken isNullable, TypeReferenceBlock1Green isArray, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
            }
            if (isNullable != null)
            {
                AdjustFlagsAndWidth(isNullable);
                _isNullable = isNullable;
            }
            if (isArray != null)
            {
                AdjustFlagsAndWidth(isArray);
                _isArray = isArray;
            }
        }
    
        private TypeReferenceGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.TypeReference, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public SimpleTypeGreen Type { get { return _type; } }
        public __InternalSyntaxToken IsNullable { get { return _isNullable; } }
        public TypeReferenceBlock1Green IsArray { get { return _isArray; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.TypeReferenceSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _type;
                case 1: return _isNullable;
                case 2: return _isArray;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new TypeReferenceGreen(this.Kind, _type, _isNullable, _isArray, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new TypeReferenceGreen(this.Kind, _type, _isNullable, _isArray, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new TypeReferenceGreen(this.Kind, _type, _isNullable, _isArray, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public TypeReferenceGreen Update(SimpleTypeGreen type, __InternalSyntaxToken isNullable, TypeReferenceBlock1Green isArray)
        {
            if (_type != type || _isNullable != isNullable || _isArray != isArray)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.TypeReference(type, isNullable, isArray);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (TypeReferenceGreen)newNode;
            }
            return this;
        }
    }
    internal abstract class SimpleTypeGreen : GreenSyntaxNode
    {
        internal static readonly SimpleTypeGreen __Missing = SimpleTypeAlt1Green.__Missing;
    
        protected SimpleTypeGreen(SoalSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class SimpleTypeAlt1Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt1Green __Missing = new SimpleTypeAlt1Green();
        private __InternalSyntaxToken _kObject;
    
        public SimpleTypeAlt1Green(SoalSyntaxKind kind, __InternalSyntaxToken kObject)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kObject != null)
            {
                AdjustFlagsAndWidth(kObject);
                _kObject = kObject;
            }
        }
    
        public SimpleTypeAlt1Green(SoalSyntaxKind kind, __InternalSyntaxToken kObject, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kObject != null)
            {
                AdjustFlagsAndWidth(kObject);
                _kObject = kObject;
            }
        }
    
        private SimpleTypeAlt1Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KObject { get { return _kObject; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt1Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kObject;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt1Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt1Green(this.Kind, _kObject, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt1Green(this.Kind, _kObject, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt1Green(this.Kind, _kObject, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt1Green Update(__InternalSyntaxToken kObject)
        {
            if (_kObject != kObject)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt1(kObject);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt1Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt2Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt2Green __Missing = new SimpleTypeAlt2Green();
        private __InternalSyntaxToken _kBinary;
    
        public SimpleTypeAlt2Green(SoalSyntaxKind kind, __InternalSyntaxToken kBinary)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kBinary != null)
            {
                AdjustFlagsAndWidth(kBinary);
                _kBinary = kBinary;
            }
        }
    
        public SimpleTypeAlt2Green(SoalSyntaxKind kind, __InternalSyntaxToken kBinary, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kBinary != null)
            {
                AdjustFlagsAndWidth(kBinary);
                _kBinary = kBinary;
            }
        }
    
        private SimpleTypeAlt2Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KBinary { get { return _kBinary; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt2Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kBinary;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt2Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt2Green(this.Kind, _kBinary, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt2Green(this.Kind, _kBinary, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt2Green(this.Kind, _kBinary, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt2Green Update(__InternalSyntaxToken kBinary)
        {
            if (_kBinary != kBinary)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt2(kBinary);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt2Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt3Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt3Green __Missing = new SimpleTypeAlt3Green();
        private __InternalSyntaxToken _kBool;
    
        public SimpleTypeAlt3Green(SoalSyntaxKind kind, __InternalSyntaxToken kBool)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kBool != null)
            {
                AdjustFlagsAndWidth(kBool);
                _kBool = kBool;
            }
        }
    
        public SimpleTypeAlt3Green(SoalSyntaxKind kind, __InternalSyntaxToken kBool, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kBool != null)
            {
                AdjustFlagsAndWidth(kBool);
                _kBool = kBool;
            }
        }
    
        private SimpleTypeAlt3Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KBool { get { return _kBool; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt3Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kBool;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt3Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt3Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt3Green(this.Kind, _kBool, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt3Green(this.Kind, _kBool, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt3Green(this.Kind, _kBool, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt3Green Update(__InternalSyntaxToken kBool)
        {
            if (_kBool != kBool)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt3(kBool);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt3Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt4Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt4Green __Missing = new SimpleTypeAlt4Green();
        private __InternalSyntaxToken _kString;
    
        public SimpleTypeAlt4Green(SoalSyntaxKind kind, __InternalSyntaxToken kString)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kString != null)
            {
                AdjustFlagsAndWidth(kString);
                _kString = kString;
            }
        }
    
        public SimpleTypeAlt4Green(SoalSyntaxKind kind, __InternalSyntaxToken kString, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kString != null)
            {
                AdjustFlagsAndWidth(kString);
                _kString = kString;
            }
        }
    
        private SimpleTypeAlt4Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt4, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KString { get { return _kString; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt4Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kString;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt4Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt4Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt4Green(this.Kind, _kString, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt4Green(this.Kind, _kString, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt4Green(this.Kind, _kString, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt4Green Update(__InternalSyntaxToken kString)
        {
            if (_kString != kString)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt4(kString);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt4Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt5Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt5Green __Missing = new SimpleTypeAlt5Green();
        private __InternalSyntaxToken _kInt;
    
        public SimpleTypeAlt5Green(SoalSyntaxKind kind, __InternalSyntaxToken kInt)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kInt != null)
            {
                AdjustFlagsAndWidth(kInt);
                _kInt = kInt;
            }
        }
    
        public SimpleTypeAlt5Green(SoalSyntaxKind kind, __InternalSyntaxToken kInt, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kInt != null)
            {
                AdjustFlagsAndWidth(kInt);
                _kInt = kInt;
            }
        }
    
        private SimpleTypeAlt5Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt5, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KInt { get { return _kInt; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt5Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kInt;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt5Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt5Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt5Green(this.Kind, _kInt, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt5Green(this.Kind, _kInt, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt5Green(this.Kind, _kInt, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt5Green Update(__InternalSyntaxToken kInt)
        {
            if (_kInt != kInt)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt5(kInt);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt5Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt6Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt6Green __Missing = new SimpleTypeAlt6Green();
        private __InternalSyntaxToken _kLong;
    
        public SimpleTypeAlt6Green(SoalSyntaxKind kind, __InternalSyntaxToken kLong)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kLong != null)
            {
                AdjustFlagsAndWidth(kLong);
                _kLong = kLong;
            }
        }
    
        public SimpleTypeAlt6Green(SoalSyntaxKind kind, __InternalSyntaxToken kLong, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kLong != null)
            {
                AdjustFlagsAndWidth(kLong);
                _kLong = kLong;
            }
        }
    
        private SimpleTypeAlt6Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt6, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KLong { get { return _kLong; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt6Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kLong;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt6Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt6Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt6Green(this.Kind, _kLong, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt6Green(this.Kind, _kLong, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt6Green(this.Kind, _kLong, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt6Green Update(__InternalSyntaxToken kLong)
        {
            if (_kLong != kLong)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt6(kLong);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt6Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt7Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt7Green __Missing = new SimpleTypeAlt7Green();
        private __InternalSyntaxToken _kFloat;
    
        public SimpleTypeAlt7Green(SoalSyntaxKind kind, __InternalSyntaxToken kFloat)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kFloat != null)
            {
                AdjustFlagsAndWidth(kFloat);
                _kFloat = kFloat;
            }
        }
    
        public SimpleTypeAlt7Green(SoalSyntaxKind kind, __InternalSyntaxToken kFloat, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kFloat != null)
            {
                AdjustFlagsAndWidth(kFloat);
                _kFloat = kFloat;
            }
        }
    
        private SimpleTypeAlt7Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt7, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KFloat { get { return _kFloat; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt7Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kFloat;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt7Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt7Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt7Green(this.Kind, _kFloat, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt7Green(this.Kind, _kFloat, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt7Green(this.Kind, _kFloat, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt7Green Update(__InternalSyntaxToken kFloat)
        {
            if (_kFloat != kFloat)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt7(kFloat);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt7Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt8Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt8Green __Missing = new SimpleTypeAlt8Green();
        private __InternalSyntaxToken _kDouble;
    
        public SimpleTypeAlt8Green(SoalSyntaxKind kind, __InternalSyntaxToken kDouble)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kDouble != null)
            {
                AdjustFlagsAndWidth(kDouble);
                _kDouble = kDouble;
            }
        }
    
        public SimpleTypeAlt8Green(SoalSyntaxKind kind, __InternalSyntaxToken kDouble, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kDouble != null)
            {
                AdjustFlagsAndWidth(kDouble);
                _kDouble = kDouble;
            }
        }
    
        private SimpleTypeAlt8Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt8, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KDouble { get { return _kDouble; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt8Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kDouble;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt8Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt8Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt8Green(this.Kind, _kDouble, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt8Green(this.Kind, _kDouble, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt8Green(this.Kind, _kDouble, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt8Green Update(__InternalSyntaxToken kDouble)
        {
            if (_kDouble != kDouble)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt8(kDouble);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt8Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt9Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt9Green __Missing = new SimpleTypeAlt9Green();
        private __InternalSyntaxToken _kDate;
    
        public SimpleTypeAlt9Green(SoalSyntaxKind kind, __InternalSyntaxToken kDate)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kDate != null)
            {
                AdjustFlagsAndWidth(kDate);
                _kDate = kDate;
            }
        }
    
        public SimpleTypeAlt9Green(SoalSyntaxKind kind, __InternalSyntaxToken kDate, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kDate != null)
            {
                AdjustFlagsAndWidth(kDate);
                _kDate = kDate;
            }
        }
    
        private SimpleTypeAlt9Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt9, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KDate { get { return _kDate; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt9Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kDate;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt9Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt9Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt9Green(this.Kind, _kDate, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt9Green(this.Kind, _kDate, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt9Green(this.Kind, _kDate, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt9Green Update(__InternalSyntaxToken kDate)
        {
            if (_kDate != kDate)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt9(kDate);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt9Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt10Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt10Green __Missing = new SimpleTypeAlt10Green();
        private __InternalSyntaxToken _kTime;
    
        public SimpleTypeAlt10Green(SoalSyntaxKind kind, __InternalSyntaxToken kTime)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kTime != null)
            {
                AdjustFlagsAndWidth(kTime);
                _kTime = kTime;
            }
        }
    
        public SimpleTypeAlt10Green(SoalSyntaxKind kind, __InternalSyntaxToken kTime, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kTime != null)
            {
                AdjustFlagsAndWidth(kTime);
                _kTime = kTime;
            }
        }
    
        private SimpleTypeAlt10Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt10, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KTime { get { return _kTime; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt10Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kTime;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt10Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt10Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt10Green(this.Kind, _kTime, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt10Green(this.Kind, _kTime, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt10Green(this.Kind, _kTime, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt10Green Update(__InternalSyntaxToken kTime)
        {
            if (_kTime != kTime)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt10(kTime);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt10Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt11Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt11Green __Missing = new SimpleTypeAlt11Green();
        private __InternalSyntaxToken _kDatetime;
    
        public SimpleTypeAlt11Green(SoalSyntaxKind kind, __InternalSyntaxToken kDatetime)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kDatetime != null)
            {
                AdjustFlagsAndWidth(kDatetime);
                _kDatetime = kDatetime;
            }
        }
    
        public SimpleTypeAlt11Green(SoalSyntaxKind kind, __InternalSyntaxToken kDatetime, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kDatetime != null)
            {
                AdjustFlagsAndWidth(kDatetime);
                _kDatetime = kDatetime;
            }
        }
    
        private SimpleTypeAlt11Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt11, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KDatetime { get { return _kDatetime; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt11Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kDatetime;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt11Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt11Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt11Green(this.Kind, _kDatetime, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt11Green(this.Kind, _kDatetime, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt11Green(this.Kind, _kDatetime, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt11Green Update(__InternalSyntaxToken kDatetime)
        {
            if (_kDatetime != kDatetime)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt11(kDatetime);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt11Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt12Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt12Green __Missing = new SimpleTypeAlt12Green();
        private __InternalSyntaxToken _kDuration;
    
        public SimpleTypeAlt12Green(SoalSyntaxKind kind, __InternalSyntaxToken kDuration)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kDuration != null)
            {
                AdjustFlagsAndWidth(kDuration);
                _kDuration = kDuration;
            }
        }
    
        public SimpleTypeAlt12Green(SoalSyntaxKind kind, __InternalSyntaxToken kDuration, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kDuration != null)
            {
                AdjustFlagsAndWidth(kDuration);
                _kDuration = kDuration;
            }
        }
    
        private SimpleTypeAlt12Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt12, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KDuration { get { return _kDuration; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt12Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kDuration;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt12Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt12Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt12Green(this.Kind, _kDuration, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt12Green(this.Kind, _kDuration, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt12Green(this.Kind, _kDuration, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt12Green Update(__InternalSyntaxToken kDuration)
        {
            if (_kDuration != kDuration)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt12(kDuration);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt12Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeAlt13Green : SimpleTypeGreen
    {
        internal static new readonly SimpleTypeAlt13Green __Missing = new SimpleTypeAlt13Green();
        private QualifierGreen _qualifier;
    
        public SimpleTypeAlt13Green(SoalSyntaxKind kind, QualifierGreen qualifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (qualifier != null)
            {
                AdjustFlagsAndWidth(qualifier);
                _qualifier = qualifier;
            }
        }
    
        public SimpleTypeAlt13Green(SoalSyntaxKind kind, QualifierGreen qualifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (qualifier != null)
            {
                AdjustFlagsAndWidth(qualifier);
                _qualifier = qualifier;
            }
        }
    
        private SimpleTypeAlt13Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt13, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public QualifierGreen Qualifier { get { return _qualifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.SimpleTypeAlt13Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _qualifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeAlt13Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeAlt13Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeAlt13Green(this.Kind, _qualifier, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeAlt13Green(this.Kind, _qualifier, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeAlt13Green(this.Kind, _qualifier, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeAlt13Green Update(QualifierGreen qualifier)
        {
            if (_qualifier != qualifier)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt13(qualifier);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeAlt13Green)newNode;
            }
            return this;
        }
    }
    internal class NameGreen : GreenSyntaxNode
    {
        internal static new readonly NameGreen __Missing = new NameGreen();
        private IdentifierGreen _identifier;
    
        public NameGreen(SoalSyntaxKind kind, IdentifierGreen identifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        public NameGreen(SoalSyntaxKind kind, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        private NameGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.Name, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public IdentifierGreen Identifier { get { return _identifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.NameSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _identifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitNameGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitNameGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new NameGreen(this.Kind, _identifier, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new NameGreen(this.Kind, _identifier, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new NameGreen(this.Kind, _identifier, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public NameGreen Update(IdentifierGreen identifier)
        {
            if (_identifier != identifier)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.Name(identifier);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (NameGreen)newNode;
            }
            return this;
        }
    }
    internal class QualifierGreen : GreenSyntaxNode
    {
        internal static new readonly QualifierGreen __Missing = new QualifierGreen();
        private __GreenNode _identifier;
    
        public QualifierGreen(SoalSyntaxKind kind, __GreenNode identifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        public QualifierGreen(SoalSyntaxKind kind, __GreenNode identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        private QualifierGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.Qualifier, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> Identifier { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_identifier, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.QualifierSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _identifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitQualifierGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new QualifierGreen(this.Kind, _identifier, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new QualifierGreen(this.Kind, _identifier, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new QualifierGreen(this.Kind, _identifier, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public QualifierGreen Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> identifier)
        {
            if (_identifier != identifier.Node)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.Qualifier(identifier);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (QualifierGreen)newNode;
            }
            return this;
        }
    }
    internal class IdentifierGreen : GreenSyntaxNode
    {
        internal static new readonly IdentifierGreen __Missing = new IdentifierGreen();
        private __InternalSyntaxToken _token;
    
        public IdentifierGreen(SoalSyntaxKind kind, __InternalSyntaxToken token)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        public IdentifierGreen(SoalSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        private IdentifierGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.Identifier, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken Token { get { return _token; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.IdentifierSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _token;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitIdentifierGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitIdentifierGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new IdentifierGreen(this.Kind, _token, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new IdentifierGreen(this.Kind, _token, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new IdentifierGreen(this.Kind, _token, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public IdentifierGreen Update(__InternalSyntaxToken token)
        {
            if (_token != token)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.Identifier(token);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (IdentifierGreen)newNode;
            }
            return this;
        }
    }
    internal class MainBlock1Green : GreenSyntaxNode
    {
        internal static new readonly MainBlock1Green __Missing = new MainBlock1Green();
        private __GreenNode _declarationList;
    
        public MainBlock1Green(SoalSyntaxKind kind, __GreenNode declarationList)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (declarationList != null)
            {
                AdjustFlagsAndWidth(declarationList);
                _declarationList = declarationList;
            }
        }
    
        public MainBlock1Green(SoalSyntaxKind kind, __GreenNode declarationList, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (declarationList != null)
            {
                AdjustFlagsAndWidth(declarationList);
                _declarationList = declarationList;
            }
        }
    
        private MainBlock1Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.MainBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<DeclarationGreen> DeclarationList { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<DeclarationGreen>(_declarationList); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.MainBlock1Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _declarationList;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainBlock1Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitMainBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MainBlock1Green(this.Kind, _declarationList, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MainBlock1Green(this.Kind, _declarationList, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MainBlock1Green(this.Kind, _declarationList, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MainBlock1Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<DeclarationGreen> declarationList)
        {
            if (_declarationList != declarationList.Node)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.MainBlock1(declarationList);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MainBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class EnumTypeBlock1Green : GreenSyntaxNode
    {
        internal static new readonly EnumTypeBlock1Green __Missing = new EnumTypeBlock1Green();
        private __GreenNode _literals;
    
        public EnumTypeBlock1Green(SoalSyntaxKind kind, __GreenNode literals)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (literals != null)
            {
                AdjustFlagsAndWidth(literals);
                _literals = literals;
            }
        }
    
        public EnumTypeBlock1Green(SoalSyntaxKind kind, __GreenNode literals, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (literals != null)
            {
                AdjustFlagsAndWidth(literals);
                _literals = literals;
            }
        }
    
        private EnumTypeBlock1Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.EnumTypeBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<EnumLiteralGreen> Literals { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<EnumLiteralGreen>(_literals, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.EnumTypeBlock1Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _literals;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitEnumTypeBlock1Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitEnumTypeBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new EnumTypeBlock1Green(this.Kind, _literals, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new EnumTypeBlock1Green(this.Kind, _literals, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new EnumTypeBlock1Green(this.Kind, _literals, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public EnumTypeBlock1Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<EnumLiteralGreen> literals)
        {
            if (_literals != literals.Node)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.EnumTypeBlock1(literals);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (EnumTypeBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class EnumTypeBlock1literalsBlockGreen : GreenSyntaxNode
    {
        internal static new readonly EnumTypeBlock1literalsBlockGreen __Missing = new EnumTypeBlock1literalsBlockGreen();
        private __InternalSyntaxToken _tComma;
        private EnumLiteralGreen _literals;
    
        public EnumTypeBlock1literalsBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tComma, EnumLiteralGreen literals)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (literals != null)
            {
                AdjustFlagsAndWidth(literals);
                _literals = literals;
            }
        }
    
        public EnumTypeBlock1literalsBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tComma, EnumLiteralGreen literals, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (literals != null)
            {
                AdjustFlagsAndWidth(literals);
                _literals = literals;
            }
        }
    
        private EnumTypeBlock1literalsBlockGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.EnumTypeBlock1literalsBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public EnumLiteralGreen Literals { get { return _literals; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.EnumTypeBlock1literalsBlockSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tComma;
                case 1: return _literals;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitEnumTypeBlock1literalsBlockGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitEnumTypeBlock1literalsBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new EnumTypeBlock1literalsBlockGreen(this.Kind, _tComma, _literals, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new EnumTypeBlock1literalsBlockGreen(this.Kind, _tComma, _literals, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new EnumTypeBlock1literalsBlockGreen(this.Kind, _tComma, _literals, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public EnumTypeBlock1literalsBlockGreen Update(__InternalSyntaxToken tComma, EnumLiteralGreen literals)
        {
            if (_tComma != tComma || _literals != literals)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.EnumTypeBlock1literalsBlock(tComma, literals);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (EnumTypeBlock1literalsBlockGreen)newNode;
            }
            return this;
        }
    }
    internal class StructTypeBlock1Green : GreenSyntaxNode
    {
        internal static new readonly StructTypeBlock1Green __Missing = new StructTypeBlock1Green();
        private __InternalSyntaxToken _tColon;
        private QualifierGreen _baseType;
    
        public StructTypeBlock1Green(SoalSyntaxKind kind, __InternalSyntaxToken tColon, QualifierGreen baseType)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tColon != null)
            {
                AdjustFlagsAndWidth(tColon);
                _tColon = tColon;
            }
            if (baseType != null)
            {
                AdjustFlagsAndWidth(baseType);
                _baseType = baseType;
            }
        }
    
        public StructTypeBlock1Green(SoalSyntaxKind kind, __InternalSyntaxToken tColon, QualifierGreen baseType, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tColon != null)
            {
                AdjustFlagsAndWidth(tColon);
                _tColon = tColon;
            }
            if (baseType != null)
            {
                AdjustFlagsAndWidth(baseType);
                _baseType = baseType;
            }
        }
    
        private StructTypeBlock1Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.StructTypeBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TColon { get { return _tColon; } }
        public QualifierGreen BaseType { get { return _baseType; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.StructTypeBlock1Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tColon;
                case 1: return _baseType;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitStructTypeBlock1Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitStructTypeBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new StructTypeBlock1Green(this.Kind, _tColon, _baseType, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new StructTypeBlock1Green(this.Kind, _tColon, _baseType, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new StructTypeBlock1Green(this.Kind, _tColon, _baseType, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public StructTypeBlock1Green Update(__InternalSyntaxToken tColon, QualifierGreen baseType)
        {
            if (_tColon != tColon || _baseType != baseType)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.StructTypeBlock1(tColon, baseType);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (StructTypeBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class ResourceBlock1Green : GreenSyntaxNode
    {
        internal static new readonly ResourceBlock1Green __Missing = new ResourceBlock1Green();
        private __InternalSyntaxToken _kThrows;
        private __GreenNode _exceptions;
    
        public ResourceBlock1Green(SoalSyntaxKind kind, __InternalSyntaxToken kThrows, __GreenNode exceptions)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (kThrows != null)
            {
                AdjustFlagsAndWidth(kThrows);
                _kThrows = kThrows;
            }
            if (exceptions != null)
            {
                AdjustFlagsAndWidth(exceptions);
                _exceptions = exceptions;
            }
        }
    
        public ResourceBlock1Green(SoalSyntaxKind kind, __InternalSyntaxToken kThrows, __GreenNode exceptions, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (kThrows != null)
            {
                AdjustFlagsAndWidth(kThrows);
                _kThrows = kThrows;
            }
            if (exceptions != null)
            {
                AdjustFlagsAndWidth(exceptions);
                _exceptions = exceptions;
            }
        }
    
        private ResourceBlock1Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.ResourceBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KThrows { get { return _kThrows; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> Exceptions { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_exceptions, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.ResourceBlock1Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kThrows;
                case 1: return _exceptions;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitResourceBlock1Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitResourceBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ResourceBlock1Green(this.Kind, _kThrows, _exceptions, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ResourceBlock1Green(this.Kind, _kThrows, _exceptions, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ResourceBlock1Green(this.Kind, _kThrows, _exceptions, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ResourceBlock1Green Update(__InternalSyntaxToken kThrows, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> exceptions)
        {
            if (_kThrows != kThrows || _exceptions != exceptions.Node)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.ResourceBlock1(kThrows, exceptions);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ResourceBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class ResourceBlock1exceptionsBlockGreen : GreenSyntaxNode
    {
        internal static new readonly ResourceBlock1exceptionsBlockGreen __Missing = new ResourceBlock1exceptionsBlockGreen();
        private __InternalSyntaxToken _tComma;
        private QualifierGreen _exceptions;
    
        public ResourceBlock1exceptionsBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen exceptions)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (exceptions != null)
            {
                AdjustFlagsAndWidth(exceptions);
                _exceptions = exceptions;
            }
        }
    
        public ResourceBlock1exceptionsBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen exceptions, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (exceptions != null)
            {
                AdjustFlagsAndWidth(exceptions);
                _exceptions = exceptions;
            }
        }
    
        private ResourceBlock1exceptionsBlockGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.ResourceBlock1exceptionsBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public QualifierGreen Exceptions { get { return _exceptions; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.ResourceBlock1exceptionsBlockSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tComma;
                case 1: return _exceptions;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitResourceBlock1exceptionsBlockGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitResourceBlock1exceptionsBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ResourceBlock1exceptionsBlockGreen(this.Kind, _tComma, _exceptions, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ResourceBlock1exceptionsBlockGreen(this.Kind, _tComma, _exceptions, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ResourceBlock1exceptionsBlockGreen(this.Kind, _tComma, _exceptions, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ResourceBlock1exceptionsBlockGreen Update(__InternalSyntaxToken tComma, QualifierGreen exceptions)
        {
            if (_tComma != tComma || _exceptions != exceptions)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.ResourceBlock1exceptionsBlock(tComma, exceptions);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ResourceBlock1exceptionsBlockGreen)newNode;
            }
            return this;
        }
    }
    internal class OperationBlock1Green : GreenSyntaxNode
    {
        internal static new readonly OperationBlock1Green __Missing = new OperationBlock1Green();
        private __InternalSyntaxToken _kThrows;
        private __GreenNode _exceptions;
    
        public OperationBlock1Green(SoalSyntaxKind kind, __InternalSyntaxToken kThrows, __GreenNode exceptions)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (kThrows != null)
            {
                AdjustFlagsAndWidth(kThrows);
                _kThrows = kThrows;
            }
            if (exceptions != null)
            {
                AdjustFlagsAndWidth(exceptions);
                _exceptions = exceptions;
            }
        }
    
        public OperationBlock1Green(SoalSyntaxKind kind, __InternalSyntaxToken kThrows, __GreenNode exceptions, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (kThrows != null)
            {
                AdjustFlagsAndWidth(kThrows);
                _kThrows = kThrows;
            }
            if (exceptions != null)
            {
                AdjustFlagsAndWidth(exceptions);
                _exceptions = exceptions;
            }
        }
    
        private OperationBlock1Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.OperationBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KThrows { get { return _kThrows; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> Exceptions { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_exceptions, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.OperationBlock1Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kThrows;
                case 1: return _exceptions;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOperationBlock1Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitOperationBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OperationBlock1Green(this.Kind, _kThrows, _exceptions, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OperationBlock1Green(this.Kind, _kThrows, _exceptions, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OperationBlock1Green(this.Kind, _kThrows, _exceptions, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OperationBlock1Green Update(__InternalSyntaxToken kThrows, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> exceptions)
        {
            if (_kThrows != kThrows || _exceptions != exceptions.Node)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.OperationBlock1(kThrows, exceptions);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OperationBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class OperationBlock1exceptionsBlockGreen : GreenSyntaxNode
    {
        internal static new readonly OperationBlock1exceptionsBlockGreen __Missing = new OperationBlock1exceptionsBlockGreen();
        private __InternalSyntaxToken _tComma;
        private QualifierGreen _exceptions;
    
        public OperationBlock1exceptionsBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen exceptions)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (exceptions != null)
            {
                AdjustFlagsAndWidth(exceptions);
                _exceptions = exceptions;
            }
        }
    
        public OperationBlock1exceptionsBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen exceptions, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (exceptions != null)
            {
                AdjustFlagsAndWidth(exceptions);
                _exceptions = exceptions;
            }
        }
    
        private OperationBlock1exceptionsBlockGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.OperationBlock1exceptionsBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public QualifierGreen Exceptions { get { return _exceptions; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.OperationBlock1exceptionsBlockSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tComma;
                case 1: return _exceptions;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOperationBlock1exceptionsBlockGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitOperationBlock1exceptionsBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OperationBlock1exceptionsBlockGreen(this.Kind, _tComma, _exceptions, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OperationBlock1exceptionsBlockGreen(this.Kind, _tComma, _exceptions, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OperationBlock1exceptionsBlockGreen(this.Kind, _tComma, _exceptions, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OperationBlock1exceptionsBlockGreen Update(__InternalSyntaxToken tComma, QualifierGreen exceptions)
        {
            if (_tComma != tComma || _exceptions != exceptions)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.OperationBlock1exceptionsBlock(tComma, exceptions);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OperationBlock1exceptionsBlockGreen)newNode;
            }
            return this;
        }
    }
    internal class InputParameterListBlock1Green : GreenSyntaxNode
    {
        internal static new readonly InputParameterListBlock1Green __Missing = new InputParameterListBlock1Green();
        private __GreenNode _parameters;
    
        public InputParameterListBlock1Green(SoalSyntaxKind kind, __GreenNode parameters)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        public InputParameterListBlock1Green(SoalSyntaxKind kind, __GreenNode parameters, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        private InputParameterListBlock1Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.InputParameterListBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen> Parameters { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen>(_parameters, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.InputParameterListBlock1Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _parameters;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitInputParameterListBlock1Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitInputParameterListBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new InputParameterListBlock1Green(this.Kind, _parameters, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new InputParameterListBlock1Green(this.Kind, _parameters, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new InputParameterListBlock1Green(this.Kind, _parameters, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public InputParameterListBlock1Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen> parameters)
        {
            if (_parameters != parameters.Node)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.InputParameterListBlock1(parameters);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (InputParameterListBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class InputParameterListBlock1parametersBlockGreen : GreenSyntaxNode
    {
        internal static new readonly InputParameterListBlock1parametersBlockGreen __Missing = new InputParameterListBlock1parametersBlockGreen();
        private __InternalSyntaxToken _tComma;
        private ParameterGreen _parameters;
    
        public InputParameterListBlock1parametersBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tComma, ParameterGreen parameters)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        public InputParameterListBlock1parametersBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tComma, ParameterGreen parameters, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        private InputParameterListBlock1parametersBlockGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.InputParameterListBlock1parametersBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public ParameterGreen Parameters { get { return _parameters; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.InputParameterListBlock1parametersBlockSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tComma;
                case 1: return _parameters;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitInputParameterListBlock1parametersBlockGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitInputParameterListBlock1parametersBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new InputParameterListBlock1parametersBlockGreen(this.Kind, _tComma, _parameters, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new InputParameterListBlock1parametersBlockGreen(this.Kind, _tComma, _parameters, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new InputParameterListBlock1parametersBlockGreen(this.Kind, _tComma, _parameters, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public InputParameterListBlock1parametersBlockGreen Update(__InternalSyntaxToken tComma, ParameterGreen parameters)
        {
            if (_tComma != tComma || _parameters != parameters)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.InputParameterListBlock1parametersBlock(tComma, parameters);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (InputParameterListBlock1parametersBlockGreen)newNode;
            }
            return this;
        }
    }
    internal class OutputParameterListAlt3parametersBlockGreen : GreenSyntaxNode
    {
        internal static new readonly OutputParameterListAlt3parametersBlockGreen __Missing = new OutputParameterListAlt3parametersBlockGreen();
        private __InternalSyntaxToken _tComma;
        private ParameterGreen _parameters;
    
        public OutputParameterListAlt3parametersBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tComma, ParameterGreen parameters)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        public OutputParameterListAlt3parametersBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tComma, ParameterGreen parameters, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        private OutputParameterListAlt3parametersBlockGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.OutputParameterListAlt3parametersBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public ParameterGreen Parameters { get { return _parameters; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.OutputParameterListAlt3parametersBlockSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tComma;
                case 1: return _parameters;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOutputParameterListAlt3parametersBlockGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitOutputParameterListAlt3parametersBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OutputParameterListAlt3parametersBlockGreen(this.Kind, _tComma, _parameters, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OutputParameterListAlt3parametersBlockGreen(this.Kind, _tComma, _parameters, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OutputParameterListAlt3parametersBlockGreen(this.Kind, _tComma, _parameters, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OutputParameterListAlt3parametersBlockGreen Update(__InternalSyntaxToken tComma, ParameterGreen parameters)
        {
            if (_tComma != tComma || _parameters != parameters)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.OutputParameterListAlt3parametersBlock(tComma, parameters);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OutputParameterListAlt3parametersBlockGreen)newNode;
            }
            return this;
        }
    }
    internal class TypeReferenceBlock1Green : GreenSyntaxNode
    {
        internal static new readonly TypeReferenceBlock1Green __Missing = new TypeReferenceBlock1Green();
        private __InternalSyntaxToken _tLBracket;
        private __InternalSyntaxToken _tRBracket;
    
        public TypeReferenceBlock1Green(SoalSyntaxKind kind, __InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tLBracket != null)
            {
                AdjustFlagsAndWidth(tLBracket);
                _tLBracket = tLBracket;
            }
            if (tRBracket != null)
            {
                AdjustFlagsAndWidth(tRBracket);
                _tRBracket = tRBracket;
            }
        }
    
        public TypeReferenceBlock1Green(SoalSyntaxKind kind, __InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tLBracket != null)
            {
                AdjustFlagsAndWidth(tLBracket);
                _tLBracket = tLBracket;
            }
            if (tRBracket != null)
            {
                AdjustFlagsAndWidth(tRBracket);
                _tRBracket = tRBracket;
            }
        }
    
        private TypeReferenceBlock1Green()
            : base((SoalSyntaxKind)SoalSyntaxKind.TypeReferenceBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TLBracket { get { return _tLBracket; } }
        public __InternalSyntaxToken TRBracket { get { return _tRBracket; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.TypeReferenceBlock1Syntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tLBracket;
                case 1: return _tRBracket;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceBlock1Green(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new TypeReferenceBlock1Green(this.Kind, _tLBracket, _tRBracket, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new TypeReferenceBlock1Green(this.Kind, _tLBracket, _tRBracket, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new TypeReferenceBlock1Green(this.Kind, _tLBracket, _tRBracket, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public TypeReferenceBlock1Green Update(__InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket)
        {
            if (_tLBracket != tLBracket || _tRBracket != tRBracket)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.TypeReferenceBlock1(tLBracket, tRBracket);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (TypeReferenceBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class QualifierIdentifierBlockGreen : GreenSyntaxNode
    {
        internal static new readonly QualifierIdentifierBlockGreen __Missing = new QualifierIdentifierBlockGreen();
        private __InternalSyntaxToken _tDot;
        private IdentifierGreen _identifier;
    
        public QualifierIdentifierBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tDot, IdentifierGreen identifier)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tDot != null)
            {
                AdjustFlagsAndWidth(tDot);
                _tDot = tDot;
            }
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        public QualifierIdentifierBlockGreen(SoalSyntaxKind kind, __InternalSyntaxToken tDot, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tDot != null)
            {
                AdjustFlagsAndWidth(tDot);
                _tDot = tDot;
            }
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        private QualifierIdentifierBlockGreen()
            : base((SoalSyntaxKind)SoalSyntaxKind.QualifierIdentifierBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TDot { get { return _tDot; } }
        public IdentifierGreen Identifier { get { return _identifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Syntax.QualifierIdentifierBlockSyntax(this, (SoalSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tDot;
                case 1: return _identifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SoalInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierIdentifierBlockGreen(this);
    
        public override void Accept(SoalInternalSyntaxVisitor visitor) => visitor.VisitQualifierIdentifierBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new QualifierIdentifierBlockGreen(this.Kind, _tDot, _identifier, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new QualifierIdentifierBlockGreen(this.Kind, _tDot, _identifier, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new QualifierIdentifierBlockGreen(this.Kind, _tDot, _identifier, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public QualifierIdentifierBlockGreen Update(__InternalSyntaxToken tDot, IdentifierGreen identifier)
        {
            if (_tDot != tDot || _identifier != identifier)
            {
                __InternalSyntaxNode newNode = SoalLanguage.Instance.InternalSyntaxFactory.QualifierIdentifierBlock(tDot, identifier);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (QualifierIdentifierBlockGreen)newNode;
            }
            return this;
        }
    }
}
