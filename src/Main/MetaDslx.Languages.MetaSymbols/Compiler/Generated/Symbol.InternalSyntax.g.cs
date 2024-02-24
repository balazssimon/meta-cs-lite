#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax
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
        protected GreenSyntaxNode(SymbolSyntaxKind kind)
            : base((ushort)kind)
        {
        }

        protected GreenSyntaxNode(SymbolSyntaxKind kind, int fullWidth)
            : base((ushort)kind, fullWidth)
        {
        }

        protected GreenSyntaxNode(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics)
            : base((ushort)kind, diagnostics)
        {
        }

        protected GreenSyntaxNode(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics, int fullWidth)
            : base((ushort)kind, diagnostics, fullWidth)
        {
        }

        protected GreenSyntaxNode(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base((ushort)kind, diagnostics, annotations)
        {
        }

        protected GreenSyntaxNode(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations, int fullWidth)
            : base((ushort)kind, diagnostics, annotations, fullWidth)
        {
        }

        public override TResult Accept<TResult>(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult> visitor)
        {
            if (visitor is SymbolInternalSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public override void Accept(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor visitor) 
        {
            if (visitor is SymbolInternalSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor);
        public abstract void Accept(SymbolInternalSyntaxVisitor visitor);

        public override __Language Language => SymbolLanguage.Instance;
        public SymbolSyntaxKind Kind => (SymbolSyntaxKind)this.RawKind;
        public override string KindText => SymbolLanguage.Instance.SyntaxFacts.GetKindText(Kind);

        // Use conditional weak table so we always return same identity for structured trivia
        private static readonly global::System.Runtime.CompilerServices.ConditionalWeakTable<__SyntaxNode, global::System.Collections.Generic.Dictionary<__SyntaxTrivia, __SyntaxNode>> s_structuresTable
            = new global::System.Runtime.CompilerServices.ConditionalWeakTable<__SyntaxNode, global::System.Collections.Generic.Dictionary<__SyntaxTrivia, __SyntaxNode>>();

        /// <summary>
        /// Gets the syntax node represented the structure of this trivia, if any. The HasStructure property can be used to 
        /// determine if this trivia has structure.
        /// </summary>
        /// <returns>
        /// A SymbolSyntaxNode derived from StructuredTriviaSyntax, with the structured view of this trivia node. 
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
                            structure = SymbolStructuredTriviaSyntax.Create(trivia);
                            structsInParent.Add(trivia, structure);
                        }
                    }

                    return structure;
                }
                else
                {
                    return SymbolStructuredTriviaSyntax.Create(trivia);
                }
            }

            return null;
        }

    }

    internal class GreenSyntaxTrivia : __InternalSyntaxTrivia
    {
        internal GreenSyntaxTrivia(SymbolSyntaxKind kind, string text, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
            : base((ushort)kind, text, diagnostics, annotations)
        {
        }

        public override __Language Language => SymbolLanguage.Instance;
        public SymbolSyntaxKind Kind => (SymbolSyntaxKind)this.RawKind;
        public override string KindText => SymbolLanguage.Instance.SyntaxFacts.GetKindText(Kind);

        internal static GreenSyntaxTrivia Create(SymbolSyntaxKind kind, string text)
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
        internal GreenStructuredTriviaSyntax(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
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

        internal GreenSkippedTokensTriviaSyntax(SymbolSyntaxKind kind, __GreenNode tokens, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
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

        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position) => new SymbolSkippedTokensTriviaSyntax(this, (SymbolSyntaxNode)parent, position);

        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSkippedTokensTrivia(this);

        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitSkippedTokensTrivia(this);

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
        internal GreenSyntaxToken(SymbolSyntaxKind kind)
            : base((ushort)kind)
        {
        }
        internal GreenSyntaxToken(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics)
            : base((ushort)kind, diagnostics)
        {
        }
        internal GreenSyntaxToken(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base((ushort)kind, diagnostics, annotations)
        {
        }
        internal GreenSyntaxToken(SymbolSyntaxKind kind, int fullWidth)
            : base((ushort)kind, fullWidth)
        {
        }
        internal GreenSyntaxToken(SymbolSyntaxKind kind, int fullWidth, __DiagnosticInfo[] diagnostics)
            : base((ushort)kind, fullWidth, diagnostics)
        {
        }
        internal GreenSyntaxToken(SymbolSyntaxKind kind, int fullWidth, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base((ushort)kind, fullWidth, diagnostics, annotations)
        {
        }

        public override __Language Language => SymbolLanguage.Instance;
        public SymbolSyntaxKind Kind => (SymbolSyntaxKind)this.RawKind;
        public override string KindText => SymbolLanguage.Instance.SyntaxFacts.GetKindText(Kind);

        //====================

        internal static GreenSyntaxToken Create(SymbolSyntaxKind kind)
        {
            if (kind > LastTokenWithWellKnownText)
            {
                if (!SymbolLanguage.Instance.SyntaxFacts.IsToken(kind))
                {
                    throw new __ArgumentNullException(string.Format("Invalid SymbolSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
                }
                return CreateMissing(kind, null, null);
            }
            return s_tokensWithNoTrivia[(int)kind].Value;
        }

        internal static GreenSyntaxToken Create(SymbolSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
        {
            if (kind > LastTokenWithWellKnownText)
            {
                if (!SymbolLanguage.Instance.SyntaxFacts.IsToken(kind))
                {
                    throw new __ArgumentNullException(string.Format("Invalid SymbolSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
                }
                return CreateMissing(kind, leading, trailing);
            }
            if (leading == null)
            {
                if (trailing == null)
                {
                    return s_tokensWithNoTrivia[(int)kind].Value;
                }
                else if (trailing == SymbolLanguage.Instance.InternalSyntaxFactory.Space)
                {
                    return s_tokensWithSingleTrailingSpace[(int)kind].Value;
                }
                else if (trailing == SymbolLanguage.Instance.InternalSyntaxFactory.CarriageReturnLineFeed)
                {
                    return s_tokensWithSingleTrailingCRLF[(int)kind].Value;
                }
            }
            if (leading == SymbolLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace && trailing == SymbolLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace)
            {
                return s_tokensWithElasticTrivia[(int)kind].Value;
            }
            return new SyntaxTokenWithTrivia(kind, leading, trailing);
        }

        internal static GreenSyntaxToken CreateMissing(SymbolSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
        {
            return new MissingTokenWithTrivia(kind, leading, trailing);
        }

        internal static readonly SymbolSyntaxKind FirstTokenWithWellKnownText;
        internal static readonly SymbolSyntaxKind LastTokenWithWellKnownText;
        // TODO: eliminate the blank space before the first interesting element?
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithNoTrivia;
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithElasticTrivia;
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingSpace;
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingCRLF;

        static GreenSyntaxToken()
        {
            FirstTokenWithWellKnownText = SymbolSyntaxKind.__FirstFixedToken;
            LastTokenWithWellKnownText = SymbolSyntaxKind.__LastFixedToken;
            s_tokensWithNoTrivia = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            s_tokensWithElasticTrivia = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            s_tokensWithSingleTrailingSpace = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            s_tokensWithSingleTrailingCRLF = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            var factory = SymbolLanguage.Instance.InternalSyntaxFactory;
            for (SymbolSyntaxKind kind = FirstTokenWithWellKnownText; kind <= LastTokenWithWellKnownText; kind++)
            {
                s_tokensWithNoTrivia[(int)kind].Value = new GreenSyntaxToken((SymbolSyntaxKind)kind);
                s_tokensWithElasticTrivia[(int)kind].Value = new SyntaxTokenWithTrivia((SymbolSyntaxKind)kind, factory.ElasticZeroSpace, factory.ElasticZeroSpace);
                s_tokensWithSingleTrailingSpace[(int)kind].Value = new SyntaxTokenWithTrivia((SymbolSyntaxKind)kind, null, factory.Space);
                s_tokensWithSingleTrailingCRLF[(int)kind].Value = new SyntaxTokenWithTrivia((SymbolSyntaxKind)kind, null, factory.CarriageReturnLineFeed);
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

        internal static GreenSyntaxToken Identifier(SymbolSyntaxKind kind, string text)
        {
            return new SyntaxIdentifier(kind, text);
        }

        internal static GreenSyntaxToken Identifier(SymbolSyntaxKind kind, __GreenNode leading, string text, __GreenNode trailing)
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

        internal static GreenSyntaxToken Identifier(SymbolSyntaxKind kind, SymbolSyntaxKind contextualKind, __GreenNode leading, string text, string valueText, __GreenNode trailing)
        {
            if (contextualKind == kind && valueText == text)
            {
                return Identifier(kind, leading, text, trailing);
            }
            return new SyntaxIdentifierWithTrivia(kind, contextualKind, text, valueText, leading, trailing);
        }

        internal static GreenSyntaxToken WithValue<T>(SymbolSyntaxKind kind, string text, T value)
        {
            return new SyntaxTokenWithValue<T>(kind, text, value);
        }

        internal static GreenSyntaxToken WithValue<T>(SymbolSyntaxKind kind, __GreenNode? leading, string text, T value, __GreenNode? trailing)
        {
            return new SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing);
        }

        public new virtual SymbolSyntaxKind ContextualKind => this.Kind;
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
            internal MissingTokenWithTrivia(SymbolSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
                : base(kind, leading, trailing)
            {
                this.flags &= ~NodeFlags.IsNotMissing;
            }

            internal MissingTokenWithTrivia(SymbolSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
                    if (SymbolLanguage.Instance.SyntaxFacts.IsIdentifier(this.Kind)) return string.Empty;
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

            internal SyntaxIdentifier(SymbolSyntaxKind kind, string text)
                : base(kind, text.Length)
            {
                this.TextField = text;
            }

            internal SyntaxIdentifier(SymbolSyntaxKind kind, string text, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            protected readonly SymbolSyntaxKind contextualKind;
            protected readonly string valueText;

            internal SyntaxIdentifierExtended(SymbolSyntaxKind kind, SymbolSyntaxKind contextualKind, string text, string valueText)
                : base(kind, text)
            {
                this.contextualKind = contextualKind;
                this.valueText = valueText;
            }

            internal SyntaxIdentifierExtended(SymbolSyntaxKind kind, SymbolSyntaxKind contextualKind, string text, string valueText, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
                : base(kind, text, diagnostics, annotations)
            {
                this.contextualKind = contextualKind;
                this.valueText = valueText;
            }

            public override SymbolSyntaxKind ContextualKind
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

            internal SyntaxIdentifierWithTrailingTrivia(SymbolSyntaxKind kind, string text, __GreenNode? trailing)
                : base(kind, text)
            {
                if (trailing != null)
                {
                    this.AdjustFlagsAndWidth(trailing);
                    _trailing = trailing;
                }
            }

            internal SyntaxIdentifierWithTrailingTrivia(SymbolSyntaxKind kind, string text, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
                SymbolSyntaxKind kind,
                SymbolSyntaxKind contextualKind,
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
                SymbolSyntaxKind kind,
                SymbolSyntaxKind contextualKind,
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

            internal SyntaxTokenWithValue(SymbolSyntaxKind kind, string text, T value)
                : base(kind, text.Length)
            {
                this.TextField = text;
                this.ValueField = value;
            }

            internal SyntaxTokenWithValue(SymbolSyntaxKind kind, string text, T value, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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

            internal SyntaxTokenWithValueAndTrivia(SymbolSyntaxKind kind, string text, T value, __GreenNode? leading, __GreenNode? trailing)
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
                SymbolSyntaxKind kind,
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

            internal SyntaxTokenWithTrivia(SymbolSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
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

            internal SyntaxTokenWithTrivia(SymbolSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
        private __GreenNode _usingList;
        private MainBlock1Green _block;
        private __InternalSyntaxToken _endOfFileToken;
    
        public MainGreen(SymbolSyntaxKind kind, __InternalSyntaxToken kNamespace, QualifierGreen qualifier, __GreenNode usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken)
            : base(kind, null, null)
        {
            SlotCount = 5;
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
    
        public MainGreen(SymbolSyntaxKind kind, __InternalSyntaxToken kNamespace, QualifierGreen qualifier, __GreenNode usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 5;
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
            : base((SymbolSyntaxKind)SymbolSyntaxKind.Main, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KNamespace { get { return _kNamespace; } }
        public QualifierGreen Qualifier { get { return _qualifier; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> UsingList { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen>(_usingList); } }
        public MainBlock1Green Block { get { return _block; } }
        public __InternalSyntaxToken EndOfFileToken { get { return _endOfFileToken; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.MainSyntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kNamespace;
                case 1: return _qualifier;
                case 2: return _usingList;
                case 3: return _block;
                case 4: return _endOfFileToken;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitMainGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MainGreen(this.Kind, _kNamespace, _qualifier, _usingList, _block, _endOfFileToken, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MainGreen(this.Kind, _kNamespace, _qualifier, _usingList, _block, _endOfFileToken, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MainGreen(this.Kind, _kNamespace, _qualifier, _usingList, _block, _endOfFileToken, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MainGreen Update(__InternalSyntaxToken kNamespace, QualifierGreen qualifier, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken)
        {
            if (_kNamespace != kNamespace || _qualifier != qualifier || _usingList != usingList.Node || _block != block || _endOfFileToken != endOfFileToken)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.Main(kNamespace, qualifier, usingList, block, endOfFileToken);
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
    
        public UsingGreen(SymbolSyntaxKind kind, __InternalSyntaxToken kUsing, QualifierGreen namespaces)
            : base(kind, null, null)
        {
            SlotCount = 2;
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
        }
    
        public UsingGreen(SymbolSyntaxKind kind, __InternalSyntaxToken kUsing, QualifierGreen namespaces, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
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
        }
    
        private UsingGreen()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.Using, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KUsing { get { return _kUsing; } }
        public QualifierGreen Namespaces { get { return _namespaces; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.UsingSyntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kUsing;
                case 1: return _namespaces;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitUsingGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitUsingGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new UsingGreen(this.Kind, _kUsing, _namespaces, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new UsingGreen(this.Kind, _kUsing, _namespaces, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new UsingGreen(this.Kind, _kUsing, _namespaces, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public UsingGreen Update(__InternalSyntaxToken kUsing, QualifierGreen namespaces)
        {
            if (_kUsing != kUsing || _namespaces != namespaces)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.Using(kUsing, namespaces);
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
    internal class SymbolGreen : GreenSyntaxNode
    {
        internal static new readonly SymbolGreen __Missing = new SymbolGreen();
        private __InternalSyntaxToken _isAbstract;
        private __InternalSyntaxToken _kSymbol;
        private NameGreen _name;
        private SymbolBlock1Green _block1;
        private SymbolBlock2Green _block2;
    
        public SymbolGreen(SymbolSyntaxKind kind, __InternalSyntaxToken isAbstract, __InternalSyntaxToken kSymbol, NameGreen name, SymbolBlock1Green block1, SymbolBlock2Green block2)
            : base(kind, null, null)
        {
            SlotCount = 5;
            if (isAbstract != null)
            {
                AdjustFlagsAndWidth(isAbstract);
                _isAbstract = isAbstract;
            }
            if (kSymbol != null)
            {
                AdjustFlagsAndWidth(kSymbol);
                _kSymbol = kSymbol;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (block1 != null)
            {
                AdjustFlagsAndWidth(block1);
                _block1 = block1;
            }
            if (block2 != null)
            {
                AdjustFlagsAndWidth(block2);
                _block2 = block2;
            }
        }
    
        public SymbolGreen(SymbolSyntaxKind kind, __InternalSyntaxToken isAbstract, __InternalSyntaxToken kSymbol, NameGreen name, SymbolBlock1Green block1, SymbolBlock2Green block2, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 5;
            if (isAbstract != null)
            {
                AdjustFlagsAndWidth(isAbstract);
                _isAbstract = isAbstract;
            }
            if (kSymbol != null)
            {
                AdjustFlagsAndWidth(kSymbol);
                _kSymbol = kSymbol;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (block1 != null)
            {
                AdjustFlagsAndWidth(block1);
                _block1 = block1;
            }
            if (block2 != null)
            {
                AdjustFlagsAndWidth(block2);
                _block2 = block2;
            }
        }
    
        private SymbolGreen()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.Symbol, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsAbstract { get { return _isAbstract; } }
        public __InternalSyntaxToken KSymbol { get { return _kSymbol; } }
        public NameGreen Name { get { return _name; } }
        public SymbolBlock1Green Block1 { get { return _block1; } }
        public SymbolBlock2Green Block2 { get { return _block2; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.SymbolSyntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isAbstract;
                case 1: return _kSymbol;
                case 2: return _name;
                case 3: return _block1;
                case 4: return _block2;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSymbolGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitSymbolGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SymbolGreen(this.Kind, _isAbstract, _kSymbol, _name, _block1, _block2, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SymbolGreen(this.Kind, _isAbstract, _kSymbol, _name, _block1, _block2, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SymbolGreen(this.Kind, _isAbstract, _kSymbol, _name, _block1, _block2, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SymbolGreen Update(__InternalSyntaxToken isAbstract, __InternalSyntaxToken kSymbol, NameGreen name, SymbolBlock1Green block1, SymbolBlock2Green block2)
        {
            if (_isAbstract != isAbstract || _kSymbol != kSymbol || _name != name || _block1 != block1 || _block2 != block2)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.Symbol(isAbstract, kSymbol, name, block1, block2);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SymbolGreen)newNode;
            }
            return this;
        }
    }
    internal class PropertyGreen : GreenSyntaxNode
    {
        internal static new readonly PropertyGreen __Missing = new PropertyGreen();
        private PropertyBlock1Green _block1;
        private TypeReferenceGreen _type;
        private NameGreen _name;
        private PropertyBlock2Green _block2;
        private PropertyBlock3Green _block3;
    
        public PropertyGreen(SymbolSyntaxKind kind, PropertyBlock1Green block1, TypeReferenceGreen type, NameGreen name, PropertyBlock2Green block2, PropertyBlock3Green block3)
            : base(kind, null, null)
        {
            SlotCount = 5;
            if (block1 != null)
            {
                AdjustFlagsAndWidth(block1);
                _block1 = block1;
            }
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
            if (block2 != null)
            {
                AdjustFlagsAndWidth(block2);
                _block2 = block2;
            }
            if (block3 != null)
            {
                AdjustFlagsAndWidth(block3);
                _block3 = block3;
            }
        }
    
        public PropertyGreen(SymbolSyntaxKind kind, PropertyBlock1Green block1, TypeReferenceGreen type, NameGreen name, PropertyBlock2Green block2, PropertyBlock3Green block3, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 5;
            if (block1 != null)
            {
                AdjustFlagsAndWidth(block1);
                _block1 = block1;
            }
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
            if (block2 != null)
            {
                AdjustFlagsAndWidth(block2);
                _block2 = block2;
            }
            if (block3 != null)
            {
                AdjustFlagsAndWidth(block3);
                _block3 = block3;
            }
        }
    
        private PropertyGreen()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.Property, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public PropertyBlock1Green Block1 { get { return _block1; } }
        public TypeReferenceGreen Type { get { return _type; } }
        public NameGreen Name { get { return _name; } }
        public PropertyBlock2Green Block2 { get { return _block2; } }
        public PropertyBlock3Green Block3 { get { return _block3; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.PropertySyntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _block1;
                case 1: return _type;
                case 2: return _name;
                case 3: return _block2;
                case 4: return _block3;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitPropertyGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new PropertyGreen(this.Kind, _block1, _type, _name, _block2, _block3, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new PropertyGreen(this.Kind, _block1, _type, _name, _block2, _block3, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new PropertyGreen(this.Kind, _block1, _type, _name, _block2, _block3, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public PropertyGreen Update(PropertyBlock1Green block1, TypeReferenceGreen type, NameGreen name, PropertyBlock2Green block2, PropertyBlock3Green block3)
        {
            if (_block1 != block1 || _type != type || _name != name || _block2 != block2 || _block3 != block3)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.Property(block1, type, name, block2, block3);
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
    internal abstract class OperationGreen : GreenSyntaxNode
    {
        internal static readonly OperationGreen __Missing = OperationAlt1Green.__Missing;
    
        protected OperationGreen(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class OperationAlt1Green : OperationGreen
    {
        internal static new readonly OperationAlt1Green __Missing = new OperationAlt1Green();
        private __InternalSyntaxToken _isPhase;
        private NameGreen _name;
        private __InternalSyntaxToken _tLParen;
        private __InternalSyntaxToken _tRParen;
    
        public OperationAlt1Green(SymbolSyntaxKind kind, __InternalSyntaxToken isPhase, NameGreen name, __InternalSyntaxToken tLParen, __InternalSyntaxToken tRParen)
            : base(kind, null, null)
        {
            SlotCount = 4;
            if (isPhase != null)
            {
                AdjustFlagsAndWidth(isPhase);
                _isPhase = isPhase;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tLParen != null)
            {
                AdjustFlagsAndWidth(tLParen);
                _tLParen = tLParen;
            }
            if (tRParen != null)
            {
                AdjustFlagsAndWidth(tRParen);
                _tRParen = tRParen;
            }
        }
    
        public OperationAlt1Green(SymbolSyntaxKind kind, __InternalSyntaxToken isPhase, NameGreen name, __InternalSyntaxToken tLParen, __InternalSyntaxToken tRParen, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 4;
            if (isPhase != null)
            {
                AdjustFlagsAndWidth(isPhase);
                _isPhase = isPhase;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tLParen != null)
            {
                AdjustFlagsAndWidth(tLParen);
                _tLParen = tLParen;
            }
            if (tRParen != null)
            {
                AdjustFlagsAndWidth(tRParen);
                _tRParen = tRParen;
            }
        }
    
        private OperationAlt1Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.OperationAlt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsPhase { get { return _isPhase; } }
        public NameGreen Name { get { return _name; } }
        public __InternalSyntaxToken TLParen { get { return _tLParen; } }
        public __InternalSyntaxToken TRParen { get { return _tRParen; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.OperationAlt1Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isPhase;
                case 1: return _name;
                case 2: return _tLParen;
                case 3: return _tRParen;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOperationAlt1Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitOperationAlt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OperationAlt1Green(this.Kind, _isPhase, _name, _tLParen, _tRParen, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OperationAlt1Green(this.Kind, _isPhase, _name, _tLParen, _tRParen, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OperationAlt1Green(this.Kind, _isPhase, _name, _tLParen, _tRParen, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OperationAlt1Green Update(__InternalSyntaxToken isPhase, NameGreen name, __InternalSyntaxToken tLParen, __InternalSyntaxToken tRParen)
        {
            if (_isPhase != isPhase || _name != name || _tLParen != tLParen || _tRParen != tRParen)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.OperationAlt1(isPhase, name, tLParen, tRParen);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OperationAlt1Green)newNode;
            }
            return this;
        }
    }
    internal class OperationAlt2Green : OperationGreen
    {
        internal static new readonly OperationAlt2Green __Missing = new OperationAlt2Green();
        private __InternalSyntaxToken _isCached;
        private TypeReferenceGreen _returnType;
        private NameGreen _name;
        private __InternalSyntaxToken _tLParen;
        private OperationAlt2Block1Green _block1;
        private __InternalSyntaxToken _tRParen;
        private OperationAlt2Block2Green _block2;
    
        public OperationAlt2Green(SymbolSyntaxKind kind, __InternalSyntaxToken isCached, TypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, OperationAlt2Block1Green block1, __InternalSyntaxToken tRParen, OperationAlt2Block2Green block2)
            : base(kind, null, null)
        {
            SlotCount = 7;
            if (isCached != null)
            {
                AdjustFlagsAndWidth(isCached);
                _isCached = isCached;
            }
            if (returnType != null)
            {
                AdjustFlagsAndWidth(returnType);
                _returnType = returnType;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tLParen != null)
            {
                AdjustFlagsAndWidth(tLParen);
                _tLParen = tLParen;
            }
            if (block1 != null)
            {
                AdjustFlagsAndWidth(block1);
                _block1 = block1;
            }
            if (tRParen != null)
            {
                AdjustFlagsAndWidth(tRParen);
                _tRParen = tRParen;
            }
            if (block2 != null)
            {
                AdjustFlagsAndWidth(block2);
                _block2 = block2;
            }
        }
    
        public OperationAlt2Green(SymbolSyntaxKind kind, __InternalSyntaxToken isCached, TypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, OperationAlt2Block1Green block1, __InternalSyntaxToken tRParen, OperationAlt2Block2Green block2, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 7;
            if (isCached != null)
            {
                AdjustFlagsAndWidth(isCached);
                _isCached = isCached;
            }
            if (returnType != null)
            {
                AdjustFlagsAndWidth(returnType);
                _returnType = returnType;
            }
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
            if (tLParen != null)
            {
                AdjustFlagsAndWidth(tLParen);
                _tLParen = tLParen;
            }
            if (block1 != null)
            {
                AdjustFlagsAndWidth(block1);
                _block1 = block1;
            }
            if (tRParen != null)
            {
                AdjustFlagsAndWidth(tRParen);
                _tRParen = tRParen;
            }
            if (block2 != null)
            {
                AdjustFlagsAndWidth(block2);
                _block2 = block2;
            }
        }
    
        private OperationAlt2Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.OperationAlt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsCached { get { return _isCached; } }
        public TypeReferenceGreen ReturnType { get { return _returnType; } }
        public NameGreen Name { get { return _name; } }
        public __InternalSyntaxToken TLParen { get { return _tLParen; } }
        public OperationAlt2Block1Green Block1 { get { return _block1; } }
        public __InternalSyntaxToken TRParen { get { return _tRParen; } }
        public OperationAlt2Block2Green Block2 { get { return _block2; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.OperationAlt2Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isCached;
                case 1: return _returnType;
                case 2: return _name;
                case 3: return _tLParen;
                case 4: return _block1;
                case 5: return _tRParen;
                case 6: return _block2;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOperationAlt2Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitOperationAlt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OperationAlt2Green(this.Kind, _isCached, _returnType, _name, _tLParen, _block1, _tRParen, _block2, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OperationAlt2Green(this.Kind, _isCached, _returnType, _name, _tLParen, _block1, _tRParen, _block2, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OperationAlt2Green(this.Kind, _isCached, _returnType, _name, _tLParen, _block1, _tRParen, _block2, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OperationAlt2Green Update(__InternalSyntaxToken isCached, TypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, OperationAlt2Block1Green block1, __InternalSyntaxToken tRParen, OperationAlt2Block2Green block2)
        {
            if (_isCached != isCached || _returnType != returnType || _name != name || _tLParen != tLParen || _block1 != block1 || _tRParen != tRParen || _block2 != block2)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.OperationAlt2(isCached, returnType, name, tLParen, block1, tRParen, block2);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OperationAlt2Green)newNode;
            }
            return this;
        }
    }
    internal class ParameterGreen : GreenSyntaxNode
    {
        internal static new readonly ParameterGreen __Missing = new ParameterGreen();
        private TypeReferenceGreen _type;
        private NameGreen _name;
    
        public ParameterGreen(SymbolSyntaxKind kind, TypeReferenceGreen type, NameGreen name)
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
    
        public ParameterGreen(SymbolSyntaxKind kind, TypeReferenceGreen type, NameGreen name, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((SymbolSyntaxKind)SymbolSyntaxKind.Parameter, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public TypeReferenceGreen Type { get { return _type; } }
        public NameGreen Name { get { return _name; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.ParameterSyntax(this, (SymbolSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParameterGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitParameterGreen(this);
    
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
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.Parameter(type, name);
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
    internal class TypeReferenceGreen : GreenSyntaxNode
    {
        internal static new readonly TypeReferenceGreen __Missing = new TypeReferenceGreen();
        private SimpleTypeReferenceGreen _type;
        private TypeReferenceBlock1Green _block;
        private ArrayDimensionsGreen _dimensions;
    
        public TypeReferenceGreen(SymbolSyntaxKind kind, SimpleTypeReferenceGreen type, TypeReferenceBlock1Green block, ArrayDimensionsGreen dimensions)
            : base(kind, null, null)
        {
            SlotCount = 3;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (dimensions != null)
            {
                AdjustFlagsAndWidth(dimensions);
                _dimensions = dimensions;
            }
        }
    
        public TypeReferenceGreen(SymbolSyntaxKind kind, SimpleTypeReferenceGreen type, TypeReferenceBlock1Green block, ArrayDimensionsGreen dimensions, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
            if (dimensions != null)
            {
                AdjustFlagsAndWidth(dimensions);
                _dimensions = dimensions;
            }
        }
    
        private TypeReferenceGreen()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.TypeReference, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public SimpleTypeReferenceGreen Type { get { return _type; } }
        public TypeReferenceBlock1Green Block { get { return _block; } }
        public ArrayDimensionsGreen Dimensions { get { return _dimensions; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.TypeReferenceSyntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _type;
                case 1: return _block;
                case 2: return _dimensions;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new TypeReferenceGreen(this.Kind, _type, _block, _dimensions, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new TypeReferenceGreen(this.Kind, _type, _block, _dimensions, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new TypeReferenceGreen(this.Kind, _type, _block, _dimensions, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public TypeReferenceGreen Update(SimpleTypeReferenceGreen type, TypeReferenceBlock1Green block, ArrayDimensionsGreen dimensions)
        {
            if (_type != type || _block != block || _dimensions != dimensions)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.TypeReference(type, block, dimensions);
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
    internal class ArrayDimensionsGreen : GreenSyntaxNode
    {
        internal static new readonly ArrayDimensionsGreen __Missing = new ArrayDimensionsGreen();
        private __GreenNode _block;
    
        public ArrayDimensionsGreen(SymbolSyntaxKind kind, __GreenNode block)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
        }
    
        public ArrayDimensionsGreen(SymbolSyntaxKind kind, __GreenNode block, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
        }
    
        private ArrayDimensionsGreen()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.ArrayDimensions, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ArrayDimensionsBlock1Green> Block { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ArrayDimensionsBlock1Green>(_block); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.ArrayDimensionsSyntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _block;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitArrayDimensionsGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitArrayDimensionsGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ArrayDimensionsGreen(this.Kind, _block, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ArrayDimensionsGreen(this.Kind, _block, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ArrayDimensionsGreen(this.Kind, _block, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ArrayDimensionsGreen Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ArrayDimensionsBlock1Green> block)
        {
            if (_block != block.Node)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.ArrayDimensions(block);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ArrayDimensionsGreen)newNode;
            }
            return this;
        }
    }
    internal abstract class SimpleTypeReferenceGreen : GreenSyntaxNode
    {
        internal static readonly SimpleTypeReferenceGreen __Missing = SimpleTypeReferenceAlt1Green.__Missing;
    
        protected SimpleTypeReferenceGreen(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class SimpleTypeReferenceAlt1Green : SimpleTypeReferenceGreen
    {
        internal static new readonly SimpleTypeReferenceAlt1Green __Missing = new SimpleTypeReferenceAlt1Green();
        private PrimitiveTypeGreen _primitiveType;
    
        public SimpleTypeReferenceAlt1Green(SymbolSyntaxKind kind, PrimitiveTypeGreen primitiveType)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (primitiveType != null)
            {
                AdjustFlagsAndWidth(primitiveType);
                _primitiveType = primitiveType;
            }
        }
    
        public SimpleTypeReferenceAlt1Green(SymbolSyntaxKind kind, PrimitiveTypeGreen primitiveType, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (primitiveType != null)
            {
                AdjustFlagsAndWidth(primitiveType);
                _primitiveType = primitiveType;
            }
        }
    
        private SimpleTypeReferenceAlt1Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.SimpleTypeReferenceAlt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public PrimitiveTypeGreen PrimitiveType { get { return _primitiveType; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.SimpleTypeReferenceAlt1Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _primitiveType;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeReferenceAlt1Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeReferenceAlt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeReferenceAlt1Green(this.Kind, _primitiveType, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeReferenceAlt1Green(this.Kind, _primitiveType, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeReferenceAlt1Green(this.Kind, _primitiveType, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeReferenceAlt1Green Update(PrimitiveTypeGreen primitiveType)
        {
            if (_primitiveType != primitiveType)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.SimpleTypeReferenceAlt1(primitiveType);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeReferenceAlt1Green)newNode;
            }
            return this;
        }
    }
    internal class SimpleTypeReferenceAlt2Green : SimpleTypeReferenceGreen
    {
        internal static new readonly SimpleTypeReferenceAlt2Green __Missing = new SimpleTypeReferenceAlt2Green();
        private QualifierGreen _qualifier;
    
        public SimpleTypeReferenceAlt2Green(SymbolSyntaxKind kind, QualifierGreen qualifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (qualifier != null)
            {
                AdjustFlagsAndWidth(qualifier);
                _qualifier = qualifier;
            }
        }
    
        public SimpleTypeReferenceAlt2Green(SymbolSyntaxKind kind, QualifierGreen qualifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (qualifier != null)
            {
                AdjustFlagsAndWidth(qualifier);
                _qualifier = qualifier;
            }
        }
    
        private SimpleTypeReferenceAlt2Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.SimpleTypeReferenceAlt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public QualifierGreen Qualifier { get { return _qualifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.SimpleTypeReferenceAlt2Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _qualifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeReferenceAlt2Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeReferenceAlt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SimpleTypeReferenceAlt2Green(this.Kind, _qualifier, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SimpleTypeReferenceAlt2Green(this.Kind, _qualifier, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SimpleTypeReferenceAlt2Green(this.Kind, _qualifier, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SimpleTypeReferenceAlt2Green Update(QualifierGreen qualifier)
        {
            if (_qualifier != qualifier)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.SimpleTypeReferenceAlt2(qualifier);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SimpleTypeReferenceAlt2Green)newNode;
            }
            return this;
        }
    }
    internal class PrimitiveTypeGreen : GreenSyntaxNode
    {
        internal static new readonly PrimitiveTypeGreen __Missing = new PrimitiveTypeGreen();
        private __InternalSyntaxToken _token;
    
        public PrimitiveTypeGreen(SymbolSyntaxKind kind, __InternalSyntaxToken token)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        public PrimitiveTypeGreen(SymbolSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        private PrimitiveTypeGreen()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.PrimitiveType, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken Token { get { return _token; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.PrimitiveTypeSyntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _token;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPrimitiveTypeGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitPrimitiveTypeGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new PrimitiveTypeGreen(this.Kind, _token, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new PrimitiveTypeGreen(this.Kind, _token, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new PrimitiveTypeGreen(this.Kind, _token, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public PrimitiveTypeGreen Update(__InternalSyntaxToken token)
        {
            if (_token != token)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.PrimitiveType(token);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (PrimitiveTypeGreen)newNode;
            }
            return this;
        }
    }
    internal abstract class ValueGreen : GreenSyntaxNode
    {
        internal static readonly ValueGreen __Missing = ValueAlt1Green.__Missing;
    
        protected ValueGreen(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class ValueAlt1Green : ValueGreen
    {
        internal static new readonly ValueAlt1Green __Missing = new ValueAlt1Green();
        private __InternalSyntaxToken _tString;
    
        public ValueAlt1Green(SymbolSyntaxKind kind, __InternalSyntaxToken tString)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (tString != null)
            {
                AdjustFlagsAndWidth(tString);
                _tString = tString;
            }
        }
    
        public ValueAlt1Green(SymbolSyntaxKind kind, __InternalSyntaxToken tString, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (tString != null)
            {
                AdjustFlagsAndWidth(tString);
                _tString = tString;
            }
        }
    
        private ValueAlt1Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TString { get { return _tString; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.ValueAlt1Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tString;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt1Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitValueAlt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ValueAlt1Green(this.Kind, _tString, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ValueAlt1Green(this.Kind, _tString, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ValueAlt1Green(this.Kind, _tString, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ValueAlt1Green Update(__InternalSyntaxToken tString)
        {
            if (_tString != tString)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt1(tString);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ValueAlt1Green)newNode;
            }
            return this;
        }
    }
    internal class ValueAlt2Green : ValueGreen
    {
        internal static new readonly ValueAlt2Green __Missing = new ValueAlt2Green();
        private __InternalSyntaxToken _tInteger;
    
        public ValueAlt2Green(SymbolSyntaxKind kind, __InternalSyntaxToken tInteger)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (tInteger != null)
            {
                AdjustFlagsAndWidth(tInteger);
                _tInteger = tInteger;
            }
        }
    
        public ValueAlt2Green(SymbolSyntaxKind kind, __InternalSyntaxToken tInteger, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (tInteger != null)
            {
                AdjustFlagsAndWidth(tInteger);
                _tInteger = tInteger;
            }
        }
    
        private ValueAlt2Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TInteger { get { return _tInteger; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.ValueAlt2Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tInteger;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt2Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitValueAlt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ValueAlt2Green(this.Kind, _tInteger, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ValueAlt2Green(this.Kind, _tInteger, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ValueAlt2Green(this.Kind, _tInteger, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ValueAlt2Green Update(__InternalSyntaxToken tInteger)
        {
            if (_tInteger != tInteger)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt2(tInteger);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ValueAlt2Green)newNode;
            }
            return this;
        }
    }
    internal class ValueAlt3Green : ValueGreen
    {
        internal static new readonly ValueAlt3Green __Missing = new ValueAlt3Green();
        private __InternalSyntaxToken _tDecimal;
    
        public ValueAlt3Green(SymbolSyntaxKind kind, __InternalSyntaxToken tDecimal)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (tDecimal != null)
            {
                AdjustFlagsAndWidth(tDecimal);
                _tDecimal = tDecimal;
            }
        }
    
        public ValueAlt3Green(SymbolSyntaxKind kind, __InternalSyntaxToken tDecimal, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (tDecimal != null)
            {
                AdjustFlagsAndWidth(tDecimal);
                _tDecimal = tDecimal;
            }
        }
    
        private ValueAlt3Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TDecimal { get { return _tDecimal; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.ValueAlt3Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tDecimal;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt3Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitValueAlt3Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ValueAlt3Green(this.Kind, _tDecimal, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ValueAlt3Green(this.Kind, _tDecimal, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ValueAlt3Green(this.Kind, _tDecimal, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ValueAlt3Green Update(__InternalSyntaxToken tDecimal)
        {
            if (_tDecimal != tDecimal)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt3(tDecimal);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ValueAlt3Green)newNode;
            }
            return this;
        }
    }
    internal class ValueAlt4Green : ValueGreen
    {
        internal static new readonly ValueAlt4Green __Missing = new ValueAlt4Green();
        private TBooleanGreen _tBoolean;
    
        public ValueAlt4Green(SymbolSyntaxKind kind, TBooleanGreen tBoolean)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (tBoolean != null)
            {
                AdjustFlagsAndWidth(tBoolean);
                _tBoolean = tBoolean;
            }
        }
    
        public ValueAlt4Green(SymbolSyntaxKind kind, TBooleanGreen tBoolean, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (tBoolean != null)
            {
                AdjustFlagsAndWidth(tBoolean);
                _tBoolean = tBoolean;
            }
        }
    
        private ValueAlt4Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt4, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public TBooleanGreen TBoolean { get { return _tBoolean; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.ValueAlt4Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tBoolean;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt4Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitValueAlt4Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ValueAlt4Green(this.Kind, _tBoolean, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ValueAlt4Green(this.Kind, _tBoolean, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ValueAlt4Green(this.Kind, _tBoolean, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ValueAlt4Green Update(TBooleanGreen tBoolean)
        {
            if (_tBoolean != tBoolean)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt4(tBoolean);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ValueAlt4Green)newNode;
            }
            return this;
        }
    }
    internal class ValueAlt5Green : ValueGreen
    {
        internal static new readonly ValueAlt5Green __Missing = new ValueAlt5Green();
        private __InternalSyntaxToken _kNull;
    
        public ValueAlt5Green(SymbolSyntaxKind kind, __InternalSyntaxToken kNull)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kNull != null)
            {
                AdjustFlagsAndWidth(kNull);
                _kNull = kNull;
            }
        }
    
        public ValueAlt5Green(SymbolSyntaxKind kind, __InternalSyntaxToken kNull, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (kNull != null)
            {
                AdjustFlagsAndWidth(kNull);
                _kNull = kNull;
            }
        }
    
        private ValueAlt5Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt5, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KNull { get { return _kNull; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.ValueAlt5Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kNull;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt5Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitValueAlt5Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ValueAlt5Green(this.Kind, _kNull, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ValueAlt5Green(this.Kind, _kNull, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ValueAlt5Green(this.Kind, _kNull, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ValueAlt5Green Update(__InternalSyntaxToken kNull)
        {
            if (_kNull != kNull)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt5(kNull);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ValueAlt5Green)newNode;
            }
            return this;
        }
    }
    internal class ValueAlt6Green : ValueGreen
    {
        internal static new readonly ValueAlt6Green __Missing = new ValueAlt6Green();
        private QualifierGreen _qualifier;
    
        public ValueAlt6Green(SymbolSyntaxKind kind, QualifierGreen qualifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (qualifier != null)
            {
                AdjustFlagsAndWidth(qualifier);
                _qualifier = qualifier;
            }
        }
    
        public ValueAlt6Green(SymbolSyntaxKind kind, QualifierGreen qualifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (qualifier != null)
            {
                AdjustFlagsAndWidth(qualifier);
                _qualifier = qualifier;
            }
        }
    
        private ValueAlt6Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt6, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public QualifierGreen Qualifier { get { return _qualifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.ValueAlt6Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _qualifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt6Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitValueAlt6Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ValueAlt6Green(this.Kind, _qualifier, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ValueAlt6Green(this.Kind, _qualifier, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ValueAlt6Green(this.Kind, _qualifier, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ValueAlt6Green Update(QualifierGreen qualifier)
        {
            if (_qualifier != qualifier)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt6(qualifier);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ValueAlt6Green)newNode;
            }
            return this;
        }
    }
    internal class NameGreen : GreenSyntaxNode
    {
        internal static new readonly NameGreen __Missing = new NameGreen();
        private IdentifierGreen _identifier;
    
        public NameGreen(SymbolSyntaxKind kind, IdentifierGreen identifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        public NameGreen(SymbolSyntaxKind kind, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((SymbolSyntaxKind)SymbolSyntaxKind.Name, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public IdentifierGreen Identifier { get { return _identifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.NameSyntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _identifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitNameGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitNameGreen(this);
    
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
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.Name(identifier);
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
    
        public QualifierGreen(SymbolSyntaxKind kind, __GreenNode identifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        public QualifierGreen(SymbolSyntaxKind kind, __GreenNode identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((SymbolSyntaxKind)SymbolSyntaxKind.Qualifier, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> Identifier { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_identifier, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.QualifierSyntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _identifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitQualifierGreen(this);
    
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
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.Qualifier(identifier);
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
    
        public IdentifierGreen(SymbolSyntaxKind kind, __InternalSyntaxToken token)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        public IdentifierGreen(SymbolSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((SymbolSyntaxKind)SymbolSyntaxKind.Identifier, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken Token { get { return _token; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.IdentifierSyntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _token;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitIdentifierGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitIdentifierGreen(this);
    
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
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.Identifier(token);
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
    internal class TBooleanGreen : GreenSyntaxNode
    {
        internal static new readonly TBooleanGreen __Missing = new TBooleanGreen();
        private __InternalSyntaxToken _token;
    
        public TBooleanGreen(SymbolSyntaxKind kind, __InternalSyntaxToken token)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        public TBooleanGreen(SymbolSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        private TBooleanGreen()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.TBoolean, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken Token { get { return _token; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.TBooleanSyntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _token;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTBooleanGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitTBooleanGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new TBooleanGreen(this.Kind, _token, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new TBooleanGreen(this.Kind, _token, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new TBooleanGreen(this.Kind, _token, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public TBooleanGreen Update(__InternalSyntaxToken token)
        {
            if (_token != token)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.TBoolean(token);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (TBooleanGreen)newNode;
            }
            return this;
        }
    }
    internal class MainBlock1Green : GreenSyntaxNode
    {
        internal static new readonly MainBlock1Green __Missing = new MainBlock1Green();
        private __GreenNode _declarations;
    
        public MainBlock1Green(SymbolSyntaxKind kind, __GreenNode declarations)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (declarations != null)
            {
                AdjustFlagsAndWidth(declarations);
                _declarations = declarations;
            }
        }
    
        public MainBlock1Green(SymbolSyntaxKind kind, __GreenNode declarations, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (declarations != null)
            {
                AdjustFlagsAndWidth(declarations);
                _declarations = declarations;
            }
        }
    
        private MainBlock1Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.MainBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<SymbolGreen> Declarations { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<SymbolGreen>(_declarations); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.MainBlock1Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _declarations;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainBlock1Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitMainBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MainBlock1Green(this.Kind, _declarations, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MainBlock1Green(this.Kind, _declarations, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MainBlock1Green(this.Kind, _declarations, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MainBlock1Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<SymbolGreen> declarations)
        {
            if (_declarations != declarations.Node)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.MainBlock1(declarations);
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
    internal class SymbolBlock1Green : GreenSyntaxNode
    {
        internal static new readonly SymbolBlock1Green __Missing = new SymbolBlock1Green();
        private __InternalSyntaxToken _tColon;
        private QualifierGreen _baseTypes;
    
        public SymbolBlock1Green(SymbolSyntaxKind kind, __InternalSyntaxToken tColon, QualifierGreen baseTypes)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tColon != null)
            {
                AdjustFlagsAndWidth(tColon);
                _tColon = tColon;
            }
            if (baseTypes != null)
            {
                AdjustFlagsAndWidth(baseTypes);
                _baseTypes = baseTypes;
            }
        }
    
        public SymbolBlock1Green(SymbolSyntaxKind kind, __InternalSyntaxToken tColon, QualifierGreen baseTypes, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tColon != null)
            {
                AdjustFlagsAndWidth(tColon);
                _tColon = tColon;
            }
            if (baseTypes != null)
            {
                AdjustFlagsAndWidth(baseTypes);
                _baseTypes = baseTypes;
            }
        }
    
        private SymbolBlock1Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.SymbolBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TColon { get { return _tColon; } }
        public QualifierGreen BaseTypes { get { return _baseTypes; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.SymbolBlock1Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tColon;
                case 1: return _baseTypes;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSymbolBlock1Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitSymbolBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SymbolBlock1Green(this.Kind, _tColon, _baseTypes, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SymbolBlock1Green(this.Kind, _tColon, _baseTypes, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SymbolBlock1Green(this.Kind, _tColon, _baseTypes, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SymbolBlock1Green Update(__InternalSyntaxToken tColon, QualifierGreen baseTypes)
        {
            if (_tColon != tColon || _baseTypes != baseTypes)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.SymbolBlock1(tColon, baseTypes);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SymbolBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class SymbolBlock2Green : GreenSyntaxNode
    {
        internal static new readonly SymbolBlock2Green __Missing = new SymbolBlock2Green();
        private __InternalSyntaxToken _tLBrace;
        private __GreenNode _block;
        private __InternalSyntaxToken _tRBrace;
    
        public SymbolBlock2Green(SymbolSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode block, __InternalSyntaxToken tRBrace)
            : base(kind, null, null)
        {
            SlotCount = 3;
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
    
        public SymbolBlock2Green(SymbolSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode block, __InternalSyntaxToken tRBrace, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
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
    
        private SymbolBlock2Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.SymbolBlock2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TLBrace { get { return _tLBrace; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<SymbolBlock2Block1Green> Block { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<SymbolBlock2Block1Green>(_block); } }
        public __InternalSyntaxToken TRBrace { get { return _tRBrace; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.SymbolBlock2Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tLBrace;
                case 1: return _block;
                case 2: return _tRBrace;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSymbolBlock2Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitSymbolBlock2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SymbolBlock2Green(this.Kind, _tLBrace, _block, _tRBrace, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SymbolBlock2Green(this.Kind, _tLBrace, _block, _tRBrace, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SymbolBlock2Green(this.Kind, _tLBrace, _block, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SymbolBlock2Green Update(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<SymbolBlock2Block1Green> block, __InternalSyntaxToken tRBrace)
        {
            if (_tLBrace != tLBrace || _block != block.Node || _tRBrace != tRBrace)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.SymbolBlock2(tLBrace, block, tRBrace);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SymbolBlock2Green)newNode;
            }
            return this;
        }
    }
    internal abstract class SymbolBlock2Block1Green : GreenSyntaxNode
    {
        internal static readonly SymbolBlock2Block1Green __Missing = SymbolBlock2Block1Alt1Green.__Missing;
    
        protected SymbolBlock2Block1Green(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class SymbolBlock2Block1Alt1Green : SymbolBlock2Block1Green
    {
        internal static new readonly SymbolBlock2Block1Alt1Green __Missing = new SymbolBlock2Block1Alt1Green();
        private PropertyGreen _properties;
    
        public SymbolBlock2Block1Alt1Green(SymbolSyntaxKind kind, PropertyGreen properties)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (properties != null)
            {
                AdjustFlagsAndWidth(properties);
                _properties = properties;
            }
        }
    
        public SymbolBlock2Block1Alt1Green(SymbolSyntaxKind kind, PropertyGreen properties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (properties != null)
            {
                AdjustFlagsAndWidth(properties);
                _properties = properties;
            }
        }
    
        private SymbolBlock2Block1Alt1Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.SymbolBlock2Block1Alt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public PropertyGreen Properties { get { return _properties; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.SymbolBlock2Block1Alt1Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _properties;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSymbolBlock2Block1Alt1Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitSymbolBlock2Block1Alt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SymbolBlock2Block1Alt1Green(this.Kind, _properties, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SymbolBlock2Block1Alt1Green(this.Kind, _properties, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SymbolBlock2Block1Alt1Green(this.Kind, _properties, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SymbolBlock2Block1Alt1Green Update(PropertyGreen properties)
        {
            if (_properties != properties)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.SymbolBlock2Block1Alt1(properties);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SymbolBlock2Block1Alt1Green)newNode;
            }
            return this;
        }
    }
    internal class SymbolBlock2Block1Alt2Green : SymbolBlock2Block1Green
    {
        internal static new readonly SymbolBlock2Block1Alt2Green __Missing = new SymbolBlock2Block1Alt2Green();
        private OperationGreen _operations;
    
        public SymbolBlock2Block1Alt2Green(SymbolSyntaxKind kind, OperationGreen operations)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (operations != null)
            {
                AdjustFlagsAndWidth(operations);
                _operations = operations;
            }
        }
    
        public SymbolBlock2Block1Alt2Green(SymbolSyntaxKind kind, OperationGreen operations, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (operations != null)
            {
                AdjustFlagsAndWidth(operations);
                _operations = operations;
            }
        }
    
        private SymbolBlock2Block1Alt2Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.SymbolBlock2Block1Alt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public OperationGreen Operations { get { return _operations; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.SymbolBlock2Block1Alt2Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _operations;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSymbolBlock2Block1Alt2Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitSymbolBlock2Block1Alt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new SymbolBlock2Block1Alt2Green(this.Kind, _operations, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new SymbolBlock2Block1Alt2Green(this.Kind, _operations, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new SymbolBlock2Block1Alt2Green(this.Kind, _operations, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public SymbolBlock2Block1Alt2Green Update(OperationGreen operations)
        {
            if (_operations != operations)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.SymbolBlock2Block1Alt2(operations);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (SymbolBlock2Block1Alt2Green)newNode;
            }
            return this;
        }
    }
    internal abstract class PropertyBlock1Green : GreenSyntaxNode
    {
        internal static readonly PropertyBlock1Green __Missing = PropertyBlock1Alt1Green.__Missing;
    
        protected PropertyBlock1Green(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class PropertyBlock1Alt1Green : PropertyBlock1Green
    {
        internal static new readonly PropertyBlock1Alt1Green __Missing = new PropertyBlock1Alt1Green();
        private __InternalSyntaxToken _isPlain;
        private PropertyBlock1Alt1Block1Green _block;
    
        public PropertyBlock1Alt1Green(SymbolSyntaxKind kind, __InternalSyntaxToken isPlain, PropertyBlock1Alt1Block1Green block)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (isPlain != null)
            {
                AdjustFlagsAndWidth(isPlain);
                _isPlain = isPlain;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
        }
    
        public PropertyBlock1Alt1Green(SymbolSyntaxKind kind, __InternalSyntaxToken isPlain, PropertyBlock1Alt1Block1Green block, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (isPlain != null)
            {
                AdjustFlagsAndWidth(isPlain);
                _isPlain = isPlain;
            }
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
        }
    
        private PropertyBlock1Alt1Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock1Alt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsPlain { get { return _isPlain; } }
        public PropertyBlock1Alt1Block1Green Block { get { return _block; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.PropertyBlock1Alt1Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isPlain;
                case 1: return _block;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyBlock1Alt1Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitPropertyBlock1Alt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new PropertyBlock1Alt1Green(this.Kind, _isPlain, _block, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new PropertyBlock1Alt1Green(this.Kind, _isPlain, _block, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new PropertyBlock1Alt1Green(this.Kind, _isPlain, _block, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public PropertyBlock1Alt1Green Update(__InternalSyntaxToken isPlain, PropertyBlock1Alt1Block1Green block)
        {
            if (_isPlain != isPlain || _block != block)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock1Alt1(isPlain, block);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (PropertyBlock1Alt1Green)newNode;
            }
            return this;
        }
    }
    internal class PropertyBlock1Alt2Green : PropertyBlock1Green
    {
        internal static new readonly PropertyBlock1Alt2Green __Missing = new PropertyBlock1Alt2Green();
        private __InternalSyntaxToken _isDerived;
        private __InternalSyntaxToken _isCached;
        private __InternalSyntaxToken _isWeak;
    
        public PropertyBlock1Alt2Green(SymbolSyntaxKind kind, __InternalSyntaxToken isDerived, __InternalSyntaxToken isCached, __InternalSyntaxToken isWeak)
            : base(kind, null, null)
        {
            SlotCount = 3;
            if (isDerived != null)
            {
                AdjustFlagsAndWidth(isDerived);
                _isDerived = isDerived;
            }
            if (isCached != null)
            {
                AdjustFlagsAndWidth(isCached);
                _isCached = isCached;
            }
            if (isWeak != null)
            {
                AdjustFlagsAndWidth(isWeak);
                _isWeak = isWeak;
            }
        }
    
        public PropertyBlock1Alt2Green(SymbolSyntaxKind kind, __InternalSyntaxToken isDerived, __InternalSyntaxToken isCached, __InternalSyntaxToken isWeak, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
            if (isDerived != null)
            {
                AdjustFlagsAndWidth(isDerived);
                _isDerived = isDerived;
            }
            if (isCached != null)
            {
                AdjustFlagsAndWidth(isCached);
                _isCached = isCached;
            }
            if (isWeak != null)
            {
                AdjustFlagsAndWidth(isWeak);
                _isWeak = isWeak;
            }
        }
    
        private PropertyBlock1Alt2Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock1Alt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsDerived { get { return _isDerived; } }
        public __InternalSyntaxToken IsCached { get { return _isCached; } }
        public __InternalSyntaxToken IsWeak { get { return _isWeak; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.PropertyBlock1Alt2Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isDerived;
                case 1: return _isCached;
                case 2: return _isWeak;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyBlock1Alt2Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitPropertyBlock1Alt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new PropertyBlock1Alt2Green(this.Kind, _isDerived, _isCached, _isWeak, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new PropertyBlock1Alt2Green(this.Kind, _isDerived, _isCached, _isWeak, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new PropertyBlock1Alt2Green(this.Kind, _isDerived, _isCached, _isWeak, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public PropertyBlock1Alt2Green Update(__InternalSyntaxToken isDerived, __InternalSyntaxToken isCached, __InternalSyntaxToken isWeak)
        {
            if (_isDerived != isDerived || _isCached != isCached || _isWeak != isWeak)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock1Alt2(isDerived, isCached, isWeak);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (PropertyBlock1Alt2Green)newNode;
            }
            return this;
        }
    }
    internal class PropertyBlock1Alt3Green : PropertyBlock1Green
    {
        internal static new readonly PropertyBlock1Alt3Green __Missing = new PropertyBlock1Alt3Green();
        private __InternalSyntaxToken _isWeak;
    
        public PropertyBlock1Alt3Green(SymbolSyntaxKind kind, __InternalSyntaxToken isWeak)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (isWeak != null)
            {
                AdjustFlagsAndWidth(isWeak);
                _isWeak = isWeak;
            }
        }
    
        public PropertyBlock1Alt3Green(SymbolSyntaxKind kind, __InternalSyntaxToken isWeak, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (isWeak != null)
            {
                AdjustFlagsAndWidth(isWeak);
                _isWeak = isWeak;
            }
        }
    
        private PropertyBlock1Alt3Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock1Alt3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsWeak { get { return _isWeak; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.PropertyBlock1Alt3Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isWeak;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyBlock1Alt3Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitPropertyBlock1Alt3Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new PropertyBlock1Alt3Green(this.Kind, _isWeak, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new PropertyBlock1Alt3Green(this.Kind, _isWeak, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new PropertyBlock1Alt3Green(this.Kind, _isWeak, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public PropertyBlock1Alt3Green Update(__InternalSyntaxToken isWeak)
        {
            if (_isWeak != isWeak)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock1Alt3(isWeak);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (PropertyBlock1Alt3Green)newNode;
            }
            return this;
        }
    }
    internal abstract class PropertyBlock1Alt1Block1Green : GreenSyntaxNode
    {
        internal static readonly PropertyBlock1Alt1Block1Green __Missing = PropertyBlock1Alt1Block1Alt1Green.__Missing;
    
        protected PropertyBlock1Alt1Block1Green(SymbolSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class PropertyBlock1Alt1Block1Alt1Green : PropertyBlock1Alt1Block1Green
    {
        internal static new readonly PropertyBlock1Alt1Block1Alt1Green __Missing = new PropertyBlock1Alt1Block1Alt1Green();
        private __InternalSyntaxToken _isAbstract;
    
        public PropertyBlock1Alt1Block1Alt1Green(SymbolSyntaxKind kind, __InternalSyntaxToken isAbstract)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (isAbstract != null)
            {
                AdjustFlagsAndWidth(isAbstract);
                _isAbstract = isAbstract;
            }
        }
    
        public PropertyBlock1Alt1Block1Alt1Green(SymbolSyntaxKind kind, __InternalSyntaxToken isAbstract, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (isAbstract != null)
            {
                AdjustFlagsAndWidth(isAbstract);
                _isAbstract = isAbstract;
            }
        }
    
        private PropertyBlock1Alt1Block1Alt1Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock1Alt1Block1Alt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsAbstract { get { return _isAbstract; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.PropertyBlock1Alt1Block1Alt1Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isAbstract;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyBlock1Alt1Block1Alt1Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitPropertyBlock1Alt1Block1Alt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new PropertyBlock1Alt1Block1Alt1Green(this.Kind, _isAbstract, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new PropertyBlock1Alt1Block1Alt1Green(this.Kind, _isAbstract, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new PropertyBlock1Alt1Block1Alt1Green(this.Kind, _isAbstract, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public PropertyBlock1Alt1Block1Alt1Green Update(__InternalSyntaxToken isAbstract)
        {
            if (_isAbstract != isAbstract)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock1Alt1Block1Alt1(isAbstract);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (PropertyBlock1Alt1Block1Alt1Green)newNode;
            }
            return this;
        }
    }
    internal class PropertyBlock1Alt1Block1Alt2Green : PropertyBlock1Alt1Block1Green
    {
        internal static new readonly PropertyBlock1Alt1Block1Alt2Green __Missing = new PropertyBlock1Alt1Block1Alt2Green();
        private __InternalSyntaxToken _isWeak;
    
        public PropertyBlock1Alt1Block1Alt2Green(SymbolSyntaxKind kind, __InternalSyntaxToken isWeak)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (isWeak != null)
            {
                AdjustFlagsAndWidth(isWeak);
                _isWeak = isWeak;
            }
        }
    
        public PropertyBlock1Alt1Block1Alt2Green(SymbolSyntaxKind kind, __InternalSyntaxToken isWeak, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (isWeak != null)
            {
                AdjustFlagsAndWidth(isWeak);
                _isWeak = isWeak;
            }
        }
    
        private PropertyBlock1Alt1Block1Alt2Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock1Alt1Block1Alt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsWeak { get { return _isWeak; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.PropertyBlock1Alt1Block1Alt2Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isWeak;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyBlock1Alt1Block1Alt2Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitPropertyBlock1Alt1Block1Alt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new PropertyBlock1Alt1Block1Alt2Green(this.Kind, _isWeak, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new PropertyBlock1Alt1Block1Alt2Green(this.Kind, _isWeak, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new PropertyBlock1Alt1Block1Alt2Green(this.Kind, _isWeak, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public PropertyBlock1Alt1Block1Alt2Green Update(__InternalSyntaxToken isWeak)
        {
            if (_isWeak != isWeak)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock1Alt1Block1Alt2(isWeak);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (PropertyBlock1Alt1Block1Alt2Green)newNode;
            }
            return this;
        }
    }
    internal class PropertyBlock2Green : GreenSyntaxNode
    {
        internal static new readonly PropertyBlock2Green __Missing = new PropertyBlock2Green();
        private __InternalSyntaxToken _tEq;
        private ValueGreen _defaultValue;
    
        public PropertyBlock2Green(SymbolSyntaxKind kind, __InternalSyntaxToken tEq, ValueGreen defaultValue)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tEq != null)
            {
                AdjustFlagsAndWidth(tEq);
                _tEq = tEq;
            }
            if (defaultValue != null)
            {
                AdjustFlagsAndWidth(defaultValue);
                _defaultValue = defaultValue;
            }
        }
    
        public PropertyBlock2Green(SymbolSyntaxKind kind, __InternalSyntaxToken tEq, ValueGreen defaultValue, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tEq != null)
            {
                AdjustFlagsAndWidth(tEq);
                _tEq = tEq;
            }
            if (defaultValue != null)
            {
                AdjustFlagsAndWidth(defaultValue);
                _defaultValue = defaultValue;
            }
        }
    
        private PropertyBlock2Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TEq { get { return _tEq; } }
        public ValueGreen DefaultValue { get { return _defaultValue; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.PropertyBlock2Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tEq;
                case 1: return _defaultValue;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyBlock2Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitPropertyBlock2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new PropertyBlock2Green(this.Kind, _tEq, _defaultValue, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new PropertyBlock2Green(this.Kind, _tEq, _defaultValue, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new PropertyBlock2Green(this.Kind, _tEq, _defaultValue, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public PropertyBlock2Green Update(__InternalSyntaxToken tEq, ValueGreen defaultValue)
        {
            if (_tEq != tEq || _defaultValue != defaultValue)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock2(tEq, defaultValue);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (PropertyBlock2Green)newNode;
            }
            return this;
        }
    }
    internal class PropertyBlock3Green : GreenSyntaxNode
    {
        internal static new readonly PropertyBlock3Green __Missing = new PropertyBlock3Green();
        private __InternalSyntaxToken _kPhase;
        private IdentifierGreen _phase;
    
        public PropertyBlock3Green(SymbolSyntaxKind kind, __InternalSyntaxToken kPhase, IdentifierGreen phase)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (kPhase != null)
            {
                AdjustFlagsAndWidth(kPhase);
                _kPhase = kPhase;
            }
            if (phase != null)
            {
                AdjustFlagsAndWidth(phase);
                _phase = phase;
            }
        }
    
        public PropertyBlock3Green(SymbolSyntaxKind kind, __InternalSyntaxToken kPhase, IdentifierGreen phase, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (kPhase != null)
            {
                AdjustFlagsAndWidth(kPhase);
                _kPhase = kPhase;
            }
            if (phase != null)
            {
                AdjustFlagsAndWidth(phase);
                _phase = phase;
            }
        }
    
        private PropertyBlock3Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KPhase { get { return _kPhase; } }
        public IdentifierGreen Phase { get { return _phase; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.PropertyBlock3Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kPhase;
                case 1: return _phase;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyBlock3Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitPropertyBlock3Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new PropertyBlock3Green(this.Kind, _kPhase, _phase, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new PropertyBlock3Green(this.Kind, _kPhase, _phase, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new PropertyBlock3Green(this.Kind, _kPhase, _phase, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public PropertyBlock3Green Update(__InternalSyntaxToken kPhase, IdentifierGreen phase)
        {
            if (_kPhase != kPhase || _phase != phase)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock3(kPhase, phase);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (PropertyBlock3Green)newNode;
            }
            return this;
        }
    }
    internal class OperationAlt2Block1Green : GreenSyntaxNode
    {
        internal static new readonly OperationAlt2Block1Green __Missing = new OperationAlt2Block1Green();
        private __GreenNode _parameters;
    
        public OperationAlt2Block1Green(SymbolSyntaxKind kind, __GreenNode parameters)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        public OperationAlt2Block1Green(SymbolSyntaxKind kind, __GreenNode parameters, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        private OperationAlt2Block1Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.OperationAlt2Block1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen> Parameters { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen>(_parameters, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.OperationAlt2Block1Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _parameters;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOperationAlt2Block1Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitOperationAlt2Block1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OperationAlt2Block1Green(this.Kind, _parameters, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OperationAlt2Block1Green(this.Kind, _parameters, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OperationAlt2Block1Green(this.Kind, _parameters, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OperationAlt2Block1Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen> parameters)
        {
            if (_parameters != parameters.Node)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.OperationAlt2Block1(parameters);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OperationAlt2Block1Green)newNode;
            }
            return this;
        }
    }
    internal class OperationAlt2Block1parametersBlockGreen : GreenSyntaxNode
    {
        internal static new readonly OperationAlt2Block1parametersBlockGreen __Missing = new OperationAlt2Block1parametersBlockGreen();
        private __InternalSyntaxToken _tComma;
        private ParameterGreen _parameters;
    
        public OperationAlt2Block1parametersBlockGreen(SymbolSyntaxKind kind, __InternalSyntaxToken tComma, ParameterGreen parameters)
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
    
        public OperationAlt2Block1parametersBlockGreen(SymbolSyntaxKind kind, __InternalSyntaxToken tComma, ParameterGreen parameters, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
    
        private OperationAlt2Block1parametersBlockGreen()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.OperationAlt2Block1parametersBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public ParameterGreen Parameters { get { return _parameters; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.OperationAlt2Block1parametersBlockSyntax(this, (SymbolSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOperationAlt2Block1parametersBlockGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitOperationAlt2Block1parametersBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OperationAlt2Block1parametersBlockGreen(this.Kind, _tComma, _parameters, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OperationAlt2Block1parametersBlockGreen(this.Kind, _tComma, _parameters, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OperationAlt2Block1parametersBlockGreen(this.Kind, _tComma, _parameters, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OperationAlt2Block1parametersBlockGreen Update(__InternalSyntaxToken tComma, ParameterGreen parameters)
        {
            if (_tComma != tComma || _parameters != parameters)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.OperationAlt2Block1parametersBlock(tComma, parameters);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OperationAlt2Block1parametersBlockGreen)newNode;
            }
            return this;
        }
    }
    internal class OperationAlt2Block2Green : GreenSyntaxNode
    {
        internal static new readonly OperationAlt2Block2Green __Missing = new OperationAlt2Block2Green();
        private __InternalSyntaxToken _kIf;
        private __InternalSyntaxToken _cacheCondition;
    
        public OperationAlt2Block2Green(SymbolSyntaxKind kind, __InternalSyntaxToken kIf, __InternalSyntaxToken cacheCondition)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (kIf != null)
            {
                AdjustFlagsAndWidth(kIf);
                _kIf = kIf;
            }
            if (cacheCondition != null)
            {
                AdjustFlagsAndWidth(cacheCondition);
                _cacheCondition = cacheCondition;
            }
        }
    
        public OperationAlt2Block2Green(SymbolSyntaxKind kind, __InternalSyntaxToken kIf, __InternalSyntaxToken cacheCondition, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (kIf != null)
            {
                AdjustFlagsAndWidth(kIf);
                _kIf = kIf;
            }
            if (cacheCondition != null)
            {
                AdjustFlagsAndWidth(cacheCondition);
                _cacheCondition = cacheCondition;
            }
        }
    
        private OperationAlt2Block2Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.OperationAlt2Block2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KIf { get { return _kIf; } }
        public __InternalSyntaxToken CacheCondition { get { return _cacheCondition; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.OperationAlt2Block2Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kIf;
                case 1: return _cacheCondition;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitOperationAlt2Block2Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitOperationAlt2Block2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new OperationAlt2Block2Green(this.Kind, _kIf, _cacheCondition, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new OperationAlt2Block2Green(this.Kind, _kIf, _cacheCondition, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new OperationAlt2Block2Green(this.Kind, _kIf, _cacheCondition, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public OperationAlt2Block2Green Update(__InternalSyntaxToken kIf, __InternalSyntaxToken cacheCondition)
        {
            if (_kIf != kIf || _cacheCondition != cacheCondition)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.OperationAlt2Block2(kIf, cacheCondition);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (OperationAlt2Block2Green)newNode;
            }
            return this;
        }
    }
    internal class TypeReferenceBlock1Green : GreenSyntaxNode
    {
        internal static new readonly TypeReferenceBlock1Green __Missing = new TypeReferenceBlock1Green();
        private __InternalSyntaxToken _isNullable;
    
        public TypeReferenceBlock1Green(SymbolSyntaxKind kind, __InternalSyntaxToken isNullable)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (isNullable != null)
            {
                AdjustFlagsAndWidth(isNullable);
                _isNullable = isNullable;
            }
        }
    
        public TypeReferenceBlock1Green(SymbolSyntaxKind kind, __InternalSyntaxToken isNullable, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (isNullable != null)
            {
                AdjustFlagsAndWidth(isNullable);
                _isNullable = isNullable;
            }
        }
    
        private TypeReferenceBlock1Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.TypeReferenceBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsNullable { get { return _isNullable; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.TypeReferenceBlock1Syntax(this, (SymbolSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isNullable;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceBlock1Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new TypeReferenceBlock1Green(this.Kind, _isNullable, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new TypeReferenceBlock1Green(this.Kind, _isNullable, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new TypeReferenceBlock1Green(this.Kind, _isNullable, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public TypeReferenceBlock1Green Update(__InternalSyntaxToken isNullable)
        {
            if (_isNullable != isNullable)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.TypeReferenceBlock1(isNullable);
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
    internal class ArrayDimensionsBlock1Green : GreenSyntaxNode
    {
        internal static new readonly ArrayDimensionsBlock1Green __Missing = new ArrayDimensionsBlock1Green();
        private __InternalSyntaxToken _tLBracket;
        private __InternalSyntaxToken _tRBracket;
    
        public ArrayDimensionsBlock1Green(SymbolSyntaxKind kind, __InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket)
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
    
        public ArrayDimensionsBlock1Green(SymbolSyntaxKind kind, __InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
    
        private ArrayDimensionsBlock1Green()
            : base((SymbolSyntaxKind)SymbolSyntaxKind.ArrayDimensionsBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TLBracket { get { return _tLBracket; } }
        public __InternalSyntaxToken TRBracket { get { return _tRBracket; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.ArrayDimensionsBlock1Syntax(this, (SymbolSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitArrayDimensionsBlock1Green(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitArrayDimensionsBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new ArrayDimensionsBlock1Green(this.Kind, _tLBracket, _tRBracket, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new ArrayDimensionsBlock1Green(this.Kind, _tLBracket, _tRBracket, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new ArrayDimensionsBlock1Green(this.Kind, _tLBracket, _tRBracket, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public ArrayDimensionsBlock1Green Update(__InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket)
        {
            if (_tLBracket != tLBracket || _tRBracket != tRBracket)
            {
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.ArrayDimensionsBlock1(tLBracket, tRBracket);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (ArrayDimensionsBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class QualifierIdentifierBlockGreen : GreenSyntaxNode
    {
        internal static new readonly QualifierIdentifierBlockGreen __Missing = new QualifierIdentifierBlockGreen();
        private __InternalSyntaxToken _tDot;
        private IdentifierGreen _identifier;
    
        public QualifierIdentifierBlockGreen(SymbolSyntaxKind kind, __InternalSyntaxToken tDot, IdentifierGreen identifier)
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
    
        public QualifierIdentifierBlockGreen(SymbolSyntaxKind kind, __InternalSyntaxToken tDot, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((SymbolSyntaxKind)SymbolSyntaxKind.QualifierIdentifierBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TDot { get { return _tDot; } }
        public IdentifierGreen Identifier { get { return _identifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.QualifierIdentifierBlockSyntax(this, (SymbolSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(SymbolInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierIdentifierBlockGreen(this);
    
        public override void Accept(SymbolInternalSyntaxVisitor visitor) => visitor.VisitQualifierIdentifierBlockGreen(this);
    
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
                __InternalSyntaxNode newNode = SymbolLanguage.Instance.InternalSyntaxFactory.QualifierIdentifierBlock(tDot, identifier);
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
