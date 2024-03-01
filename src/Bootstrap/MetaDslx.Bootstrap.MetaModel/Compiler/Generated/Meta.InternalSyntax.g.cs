#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax
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
        protected GreenSyntaxNode(MetaSyntaxKind kind)
            : base((ushort)kind)
        {
        }

        protected GreenSyntaxNode(MetaSyntaxKind kind, int fullWidth)
            : base((ushort)kind, fullWidth)
        {
        }

        protected GreenSyntaxNode(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics)
            : base((ushort)kind, diagnostics)
        {
        }

        protected GreenSyntaxNode(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, int fullWidth)
            : base((ushort)kind, diagnostics, fullWidth)
        {
        }

        protected GreenSyntaxNode(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base((ushort)kind, diagnostics, annotations)
        {
        }

        protected GreenSyntaxNode(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations, int fullWidth)
            : base((ushort)kind, diagnostics, annotations, fullWidth)
        {
        }

        public override TResult Accept<TResult>(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult> visitor)
        {
            if (visitor is MetaInternalSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public override void Accept(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor visitor) 
        {
            if (visitor is MetaInternalSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor);
        public abstract void Accept(MetaInternalSyntaxVisitor visitor);

        public override __Language Language => MetaLanguage.Instance;
        public MetaSyntaxKind Kind => (MetaSyntaxKind)this.RawKind;
        public override string KindText => MetaLanguage.Instance.SyntaxFacts.GetKindText(Kind);

        // Use conditional weak table so we always return same identity for structured trivia
        private static readonly global::System.Runtime.CompilerServices.ConditionalWeakTable<__SyntaxNode, global::System.Collections.Generic.Dictionary<__SyntaxTrivia, __SyntaxNode>> s_structuresTable
            = new global::System.Runtime.CompilerServices.ConditionalWeakTable<__SyntaxNode, global::System.Collections.Generic.Dictionary<__SyntaxTrivia, __SyntaxNode>>();

        /// <summary>
        /// Gets the syntax node represented the structure of this trivia, if any. The HasStructure property can be used to 
        /// determine if this trivia has structure.
        /// </summary>
        /// <returns>
        /// A MetaSyntaxNode derived from StructuredTriviaSyntax, with the structured view of this trivia node. 
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
                            structure = MetaStructuredTriviaSyntax.Create(trivia);
                            structsInParent.Add(trivia, structure);
                        }
                    }

                    return structure;
                }
                else
                {
                    return MetaStructuredTriviaSyntax.Create(trivia);
                }
            }

            return null;
        }

    }

    internal class GreenSyntaxTrivia : __InternalSyntaxTrivia
    {
        internal GreenSyntaxTrivia(MetaSyntaxKind kind, string text, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
            : base((ushort)kind, text, diagnostics, annotations)
        {
        }

        public override __Language Language => MetaLanguage.Instance;
        public MetaSyntaxKind Kind => (MetaSyntaxKind)this.RawKind;
        public override string KindText => MetaLanguage.Instance.SyntaxFacts.GetKindText(Kind);

        internal static GreenSyntaxTrivia Create(MetaSyntaxKind kind, string text)
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
        internal GreenStructuredTriviaSyntax(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
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

        internal GreenSkippedTokensTriviaSyntax(MetaSyntaxKind kind, __GreenNode tokens, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
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

        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position) => new MetaSkippedTokensTriviaSyntax(this, (MetaSyntaxNode)parent, position);

        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSkippedTokensTrivia(this);

        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitSkippedTokensTrivia(this);

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
        internal GreenSyntaxToken(MetaSyntaxKind kind)
            : base((ushort)kind)
        {
        }
        internal GreenSyntaxToken(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics)
            : base((ushort)kind, diagnostics)
        {
        }
        internal GreenSyntaxToken(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base((ushort)kind, diagnostics, annotations)
        {
        }
        internal GreenSyntaxToken(MetaSyntaxKind kind, int fullWidth)
            : base((ushort)kind, fullWidth)
        {
        }
        internal GreenSyntaxToken(MetaSyntaxKind kind, int fullWidth, __DiagnosticInfo[] diagnostics)
            : base((ushort)kind, fullWidth, diagnostics)
        {
        }
        internal GreenSyntaxToken(MetaSyntaxKind kind, int fullWidth, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base((ushort)kind, fullWidth, diagnostics, annotations)
        {
        }

        public override __Language Language => MetaLanguage.Instance;
        public MetaSyntaxKind Kind => (MetaSyntaxKind)this.RawKind;
        public override string KindText => MetaLanguage.Instance.SyntaxFacts.GetKindText(Kind);

        //====================

        internal static GreenSyntaxToken Create(MetaSyntaxKind kind)
        {
            if (kind > LastTokenWithWellKnownText)
            {
                if (!MetaLanguage.Instance.SyntaxFacts.IsToken(kind))
                {
                    throw new __ArgumentNullException(string.Format("Invalid MetaSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
                }
                return CreateMissing(kind, null, null);
            }
            return s_tokensWithNoTrivia[(int)kind].Value;
        }

        internal static GreenSyntaxToken Create(MetaSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
        {
            if (kind > LastTokenWithWellKnownText)
            {
                if (!MetaLanguage.Instance.SyntaxFacts.IsToken(kind))
                {
                    throw new __ArgumentNullException(string.Format("Invalid MetaSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
                }
                return CreateMissing(kind, leading, trailing);
            }
            if (leading == null)
            {
                if (trailing == null)
                {
                    return s_tokensWithNoTrivia[(int)kind].Value;
                }
                else if (trailing == MetaLanguage.Instance.InternalSyntaxFactory.Space)
                {
                    return s_tokensWithSingleTrailingSpace[(int)kind].Value;
                }
                else if (trailing == MetaLanguage.Instance.InternalSyntaxFactory.CarriageReturnLineFeed)
                {
                    return s_tokensWithSingleTrailingCRLF[(int)kind].Value;
                }
            }
            if (leading == MetaLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace && trailing == MetaLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace)
            {
                return s_tokensWithElasticTrivia[(int)kind].Value;
            }
            return new SyntaxTokenWithTrivia(kind, leading, trailing);
        }

        internal static GreenSyntaxToken CreateMissing(MetaSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
        {
            return new MissingTokenWithTrivia(kind, leading, trailing);
        }

        internal static readonly MetaSyntaxKind FirstTokenWithWellKnownText;
        internal static readonly MetaSyntaxKind LastTokenWithWellKnownText;
        // TODO: eliminate the blank space before the first interesting element?
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithNoTrivia;
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithElasticTrivia;
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingSpace;
        private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingCRLF;

        static GreenSyntaxToken()
        {
            FirstTokenWithWellKnownText = MetaSyntaxKind.__FirstFixedToken;
            LastTokenWithWellKnownText = MetaSyntaxKind.__LastFixedToken;
            s_tokensWithNoTrivia = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            s_tokensWithElasticTrivia = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            s_tokensWithSingleTrailingSpace = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            s_tokensWithSingleTrailingCRLF = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
            var factory = MetaLanguage.Instance.InternalSyntaxFactory;
            for (MetaSyntaxKind kind = FirstTokenWithWellKnownText; kind <= LastTokenWithWellKnownText; kind++)
            {
                s_tokensWithNoTrivia[(int)kind].Value = new GreenSyntaxToken((MetaSyntaxKind)kind);
                s_tokensWithElasticTrivia[(int)kind].Value = new SyntaxTokenWithTrivia((MetaSyntaxKind)kind, factory.ElasticZeroSpace, factory.ElasticZeroSpace);
                s_tokensWithSingleTrailingSpace[(int)kind].Value = new SyntaxTokenWithTrivia((MetaSyntaxKind)kind, null, factory.Space);
                s_tokensWithSingleTrailingCRLF[(int)kind].Value = new SyntaxTokenWithTrivia((MetaSyntaxKind)kind, null, factory.CarriageReturnLineFeed);
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

        internal static GreenSyntaxToken Identifier(MetaSyntaxKind kind, string text)
        {
            return new SyntaxIdentifier(kind, text);
        }

        internal static GreenSyntaxToken Identifier(MetaSyntaxKind kind, __GreenNode leading, string text, __GreenNode trailing)
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

        internal static GreenSyntaxToken Identifier(MetaSyntaxKind kind, MetaSyntaxKind contextualKind, __GreenNode leading, string text, string valueText, __GreenNode trailing)
        {
            if (contextualKind == kind && valueText == text)
            {
                return Identifier(kind, leading, text, trailing);
            }
            return new SyntaxIdentifierWithTrivia(kind, contextualKind, text, valueText, leading, trailing);
        }

        internal static GreenSyntaxToken WithValue<T>(MetaSyntaxKind kind, string text, T value)
        {
            return new SyntaxTokenWithValue<T>(kind, text, value);
        }

        internal static GreenSyntaxToken WithValue<T>(MetaSyntaxKind kind, __GreenNode? leading, string text, T value, __GreenNode? trailing)
        {
            return new SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing);
        }

        public new virtual MetaSyntaxKind ContextualKind => this.Kind;
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
            internal MissingTokenWithTrivia(MetaSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
                : base(kind, leading, trailing)
            {
                this.flags &= ~NodeFlags.IsNotMissing;
            }

            internal MissingTokenWithTrivia(MetaSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
                    if (MetaLanguage.Instance.SyntaxFacts.IsIdentifier(this.Kind)) return string.Empty;
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

            internal SyntaxIdentifier(MetaSyntaxKind kind, string text)
                : base(kind, text.Length)
            {
                this.TextField = text;
            }

            internal SyntaxIdentifier(MetaSyntaxKind kind, string text, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            protected readonly MetaSyntaxKind contextualKind;
            protected readonly string valueText;

            internal SyntaxIdentifierExtended(MetaSyntaxKind kind, MetaSyntaxKind contextualKind, string text, string valueText)
                : base(kind, text)
            {
                this.contextualKind = contextualKind;
                this.valueText = valueText;
            }

            internal SyntaxIdentifierExtended(MetaSyntaxKind kind, MetaSyntaxKind contextualKind, string text, string valueText, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
                : base(kind, text, diagnostics, annotations)
            {
                this.contextualKind = contextualKind;
                this.valueText = valueText;
            }

            public override MetaSyntaxKind ContextualKind
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

            internal SyntaxIdentifierWithTrailingTrivia(MetaSyntaxKind kind, string text, __GreenNode? trailing)
                : base(kind, text)
            {
                if (trailing != null)
                {
                    this.AdjustFlagsAndWidth(trailing);
                    _trailing = trailing;
                }
            }

            internal SyntaxIdentifierWithTrailingTrivia(MetaSyntaxKind kind, string text, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
                MetaSyntaxKind kind,
                MetaSyntaxKind contextualKind,
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
                MetaSyntaxKind kind,
                MetaSyntaxKind contextualKind,
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

            internal SyntaxTokenWithValue(MetaSyntaxKind kind, string text, T value)
                : base(kind, text.Length)
            {
                this.TextField = text;
                this.ValueField = value;
            }

            internal SyntaxTokenWithValue(MetaSyntaxKind kind, string text, T value, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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

            internal SyntaxTokenWithValueAndTrivia(MetaSyntaxKind kind, string text, T value, __GreenNode? leading, __GreenNode? trailing)
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
                MetaSyntaxKind kind,
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

            internal SyntaxTokenWithTrivia(MetaSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
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

            internal SyntaxTokenWithTrivia(MetaSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
    
        public MainGreen(MetaSyntaxKind kind, __InternalSyntaxToken kNamespace, QualifierGreen qualifier, __InternalSyntaxToken tSemicolon, __GreenNode usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken)
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
    
        public MainGreen(MetaSyntaxKind kind, __InternalSyntaxToken kNamespace, QualifierGreen qualifier, __InternalSyntaxToken tSemicolon, __GreenNode usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.Main, null, null)
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
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MainSyntax(this, (MetaSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMainGreen(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.Main(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
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
    
        public UsingGreen(MetaSyntaxKind kind, __InternalSyntaxToken kUsing, QualifierGreen namespaces, __InternalSyntaxToken tSemicolon)
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
    
        public UsingGreen(MetaSyntaxKind kind, __InternalSyntaxToken kUsing, QualifierGreen namespaces, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.Using, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KUsing { get { return _kUsing; } }
        public QualifierGreen Namespaces { get { return _namespaces; } }
        public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.UsingSyntax(this, (MetaSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitUsingGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitUsingGreen(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.Using(kUsing, namespaces, tSemicolon);
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
    internal class MetaModelGreen : GreenSyntaxNode
    {
        internal static new readonly MetaModelGreen __Missing = new MetaModelGreen();
        private __InternalSyntaxToken _kMetamodel;
        private NameGreen _name;
        private MetaModelBlock1Green _block;
        private __InternalSyntaxToken _tSemicolon;
    
        public MetaModelGreen(MetaSyntaxKind kind, __InternalSyntaxToken kMetamodel, NameGreen name, MetaModelBlock1Green block, __InternalSyntaxToken tSemicolon)
            : base(kind, null, null)
        {
            SlotCount = 4;
            if (kMetamodel != null)
            {
                AdjustFlagsAndWidth(kMetamodel);
                _kMetamodel = kMetamodel;
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
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        public MetaModelGreen(MetaSyntaxKind kind, __InternalSyntaxToken kMetamodel, NameGreen name, MetaModelBlock1Green block, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 4;
            if (kMetamodel != null)
            {
                AdjustFlagsAndWidth(kMetamodel);
                _kMetamodel = kMetamodel;
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
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        private MetaModelGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaModel, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KMetamodel { get { return _kMetamodel; } }
        public NameGreen Name { get { return _name; } }
        public MetaModelBlock1Green Block { get { return _block; } }
        public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaModelSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kMetamodel;
                case 1: return _name;
                case 2: return _block;
                case 3: return _tSemicolon;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaModelGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaModelGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaModelGreen(this.Kind, _kMetamodel, _name, _block, _tSemicolon, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaModelGreen(this.Kind, _kMetamodel, _name, _block, _tSemicolon, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaModelGreen(this.Kind, _kMetamodel, _name, _block, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaModelGreen Update(__InternalSyntaxToken kMetamodel, NameGreen name, MetaModelBlock1Green block, __InternalSyntaxToken tSemicolon)
        {
            if (_kMetamodel != kMetamodel || _name != name || _block != block || _tSemicolon != tSemicolon)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaModel(kMetamodel, name, block, tSemicolon);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaModelGreen)newNode;
            }
            return this;
        }
    }
    internal abstract class MetaDeclarationGreen : GreenSyntaxNode
    {
        internal static readonly MetaDeclarationGreen __Missing = MetaDeclarationAlt1Green.__Missing;
    
        protected MetaDeclarationGreen(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class MetaDeclarationAlt1Green : MetaDeclarationGreen
    {
        internal static new readonly MetaDeclarationAlt1Green __Missing = new MetaDeclarationAlt1Green();
        private MetaConstantGreen _metaConstant;
    
        public MetaDeclarationAlt1Green(MetaSyntaxKind kind, MetaConstantGreen metaConstant)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (metaConstant != null)
            {
                AdjustFlagsAndWidth(metaConstant);
                _metaConstant = metaConstant;
            }
        }
    
        public MetaDeclarationAlt1Green(MetaSyntaxKind kind, MetaConstantGreen metaConstant, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (metaConstant != null)
            {
                AdjustFlagsAndWidth(metaConstant);
                _metaConstant = metaConstant;
            }
        }
    
        private MetaDeclarationAlt1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaDeclarationAlt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public MetaConstantGreen MetaConstant { get { return _metaConstant; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaDeclarationAlt1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _metaConstant;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaDeclarationAlt1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaDeclarationAlt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaDeclarationAlt1Green(this.Kind, _metaConstant, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaDeclarationAlt1Green(this.Kind, _metaConstant, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaDeclarationAlt1Green(this.Kind, _metaConstant, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaDeclarationAlt1Green Update(MetaConstantGreen metaConstant)
        {
            if (_metaConstant != metaConstant)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaDeclarationAlt1(metaConstant);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaDeclarationAlt1Green)newNode;
            }
            return this;
        }
    }
    internal class MetaDeclarationAlt2Green : MetaDeclarationGreen
    {
        internal static new readonly MetaDeclarationAlt2Green __Missing = new MetaDeclarationAlt2Green();
        private MetaEnumGreen _metaEnum;
    
        public MetaDeclarationAlt2Green(MetaSyntaxKind kind, MetaEnumGreen metaEnum)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (metaEnum != null)
            {
                AdjustFlagsAndWidth(metaEnum);
                _metaEnum = metaEnum;
            }
        }
    
        public MetaDeclarationAlt2Green(MetaSyntaxKind kind, MetaEnumGreen metaEnum, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (metaEnum != null)
            {
                AdjustFlagsAndWidth(metaEnum);
                _metaEnum = metaEnum;
            }
        }
    
        private MetaDeclarationAlt2Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaDeclarationAlt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public MetaEnumGreen MetaEnum { get { return _metaEnum; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaDeclarationAlt2Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _metaEnum;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaDeclarationAlt2Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaDeclarationAlt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaDeclarationAlt2Green(this.Kind, _metaEnum, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaDeclarationAlt2Green(this.Kind, _metaEnum, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaDeclarationAlt2Green(this.Kind, _metaEnum, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaDeclarationAlt2Green Update(MetaEnumGreen metaEnum)
        {
            if (_metaEnum != metaEnum)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaDeclarationAlt2(metaEnum);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaDeclarationAlt2Green)newNode;
            }
            return this;
        }
    }
    internal class MetaDeclarationAlt3Green : MetaDeclarationGreen
    {
        internal static new readonly MetaDeclarationAlt3Green __Missing = new MetaDeclarationAlt3Green();
        private MetaClassGreen _metaClass;
    
        public MetaDeclarationAlt3Green(MetaSyntaxKind kind, MetaClassGreen metaClass)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (metaClass != null)
            {
                AdjustFlagsAndWidth(metaClass);
                _metaClass = metaClass;
            }
        }
    
        public MetaDeclarationAlt3Green(MetaSyntaxKind kind, MetaClassGreen metaClass, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (metaClass != null)
            {
                AdjustFlagsAndWidth(metaClass);
                _metaClass = metaClass;
            }
        }
    
        private MetaDeclarationAlt3Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaDeclarationAlt3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public MetaClassGreen MetaClass { get { return _metaClass; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaDeclarationAlt3Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _metaClass;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaDeclarationAlt3Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaDeclarationAlt3Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaDeclarationAlt3Green(this.Kind, _metaClass, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaDeclarationAlt3Green(this.Kind, _metaClass, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaDeclarationAlt3Green(this.Kind, _metaClass, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaDeclarationAlt3Green Update(MetaClassGreen metaClass)
        {
            if (_metaClass != metaClass)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaDeclarationAlt3(metaClass);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaDeclarationAlt3Green)newNode;
            }
            return this;
        }
    }
    internal class MetaConstantGreen : GreenSyntaxNode
    {
        internal static new readonly MetaConstantGreen __Missing = new MetaConstantGreen();
        private __InternalSyntaxToken _kConst;
        private MetaTypeReferenceGreen _type;
        private NameGreen _name;
        private __InternalSyntaxToken _tSemicolon;
    
        public MetaConstantGreen(MetaSyntaxKind kind, __InternalSyntaxToken kConst, MetaTypeReferenceGreen type, NameGreen name, __InternalSyntaxToken tSemicolon)
            : base(kind, null, null)
        {
            SlotCount = 4;
            if (kConst != null)
            {
                AdjustFlagsAndWidth(kConst);
                _kConst = kConst;
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
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        public MetaConstantGreen(MetaSyntaxKind kind, __InternalSyntaxToken kConst, MetaTypeReferenceGreen type, NameGreen name, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 4;
            if (kConst != null)
            {
                AdjustFlagsAndWidth(kConst);
                _kConst = kConst;
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
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        private MetaConstantGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaConstant, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KConst { get { return _kConst; } }
        public MetaTypeReferenceGreen Type { get { return _type; } }
        public NameGreen Name { get { return _name; } }
        public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaConstantSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kConst;
                case 1: return _type;
                case 2: return _name;
                case 3: return _tSemicolon;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaConstantGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaConstantGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaConstantGreen(this.Kind, _kConst, _type, _name, _tSemicolon, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaConstantGreen(this.Kind, _kConst, _type, _name, _tSemicolon, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaConstantGreen(this.Kind, _kConst, _type, _name, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaConstantGreen Update(__InternalSyntaxToken kConst, MetaTypeReferenceGreen type, NameGreen name, __InternalSyntaxToken tSemicolon)
        {
            if (_kConst != kConst || _type != type || _name != name || _tSemicolon != tSemicolon)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaConstant(kConst, type, name, tSemicolon);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaConstantGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaEnumGreen : GreenSyntaxNode
    {
        internal static new readonly MetaEnumGreen __Missing = new MetaEnumGreen();
        private __InternalSyntaxToken _kEnum;
        private NameGreen _name;
        private MetaEnumBlock1Green _block;
    
        public MetaEnumGreen(MetaSyntaxKind kind, __InternalSyntaxToken kEnum, NameGreen name, MetaEnumBlock1Green block)
            : base(kind, null, null)
        {
            SlotCount = 3;
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
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
        }
    
        public MetaEnumGreen(MetaSyntaxKind kind, __InternalSyntaxToken kEnum, NameGreen name, MetaEnumBlock1Green block, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
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
            if (block != null)
            {
                AdjustFlagsAndWidth(block);
                _block = block;
            }
        }
    
        private MetaEnumGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaEnum, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KEnum { get { return _kEnum; } }
        public NameGreen Name { get { return _name; } }
        public MetaEnumBlock1Green Block { get { return _block; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaEnumSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kEnum;
                case 1: return _name;
                case 2: return _block;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaEnumGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaEnumGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaEnumGreen(this.Kind, _kEnum, _name, _block, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaEnumGreen(this.Kind, _kEnum, _name, _block, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaEnumGreen(this.Kind, _kEnum, _name, _block, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaEnumGreen Update(__InternalSyntaxToken kEnum, NameGreen name, MetaEnumBlock1Green block)
        {
            if (_kEnum != kEnum || _name != name || _block != block)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaEnum(kEnum, name, block);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaEnumGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaEnumLiteralGreen : GreenSyntaxNode
    {
        internal static new readonly MetaEnumLiteralGreen __Missing = new MetaEnumLiteralGreen();
        private NameGreen _name;
    
        public MetaEnumLiteralGreen(MetaSyntaxKind kind, NameGreen name)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
        }
    
        public MetaEnumLiteralGreen(MetaSyntaxKind kind, NameGreen name, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (name != null)
            {
                AdjustFlagsAndWidth(name);
                _name = name;
            }
        }
    
        private MetaEnumLiteralGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaEnumLiteral, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public NameGreen Name { get { return _name; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaEnumLiteralSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _name;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaEnumLiteralGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaEnumLiteralGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaEnumLiteralGreen(this.Kind, _name, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaEnumLiteralGreen(this.Kind, _name, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaEnumLiteralGreen(this.Kind, _name, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaEnumLiteralGreen Update(NameGreen name)
        {
            if (_name != name)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaEnumLiteral(name);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaEnumLiteralGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaClassGreen : GreenSyntaxNode
    {
        internal static new readonly MetaClassGreen __Missing = new MetaClassGreen();
        private __InternalSyntaxToken _isAbstract;
        private __InternalSyntaxToken _kClass;
        private MetaClassBlock1Green _block1;
        private MetaClassBlock2Green _block2;
        private MetaClassBlock3Green _block3;
    
        public MetaClassGreen(MetaSyntaxKind kind, __InternalSyntaxToken isAbstract, __InternalSyntaxToken kClass, MetaClassBlock1Green block1, MetaClassBlock2Green block2, MetaClassBlock3Green block3)
            : base(kind, null, null)
        {
            SlotCount = 5;
            if (isAbstract != null)
            {
                AdjustFlagsAndWidth(isAbstract);
                _isAbstract = isAbstract;
            }
            if (kClass != null)
            {
                AdjustFlagsAndWidth(kClass);
                _kClass = kClass;
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
            if (block3 != null)
            {
                AdjustFlagsAndWidth(block3);
                _block3 = block3;
            }
        }
    
        public MetaClassGreen(MetaSyntaxKind kind, __InternalSyntaxToken isAbstract, __InternalSyntaxToken kClass, MetaClassBlock1Green block1, MetaClassBlock2Green block2, MetaClassBlock3Green block3, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 5;
            if (isAbstract != null)
            {
                AdjustFlagsAndWidth(isAbstract);
                _isAbstract = isAbstract;
            }
            if (kClass != null)
            {
                AdjustFlagsAndWidth(kClass);
                _kClass = kClass;
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
            if (block3 != null)
            {
                AdjustFlagsAndWidth(block3);
                _block3 = block3;
            }
        }
    
        private MetaClassGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaClass, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsAbstract { get { return _isAbstract; } }
        public __InternalSyntaxToken KClass { get { return _kClass; } }
        public MetaClassBlock1Green Block1 { get { return _block1; } }
        public MetaClassBlock2Green Block2 { get { return _block2; } }
        public MetaClassBlock3Green Block3 { get { return _block3; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaClassSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isAbstract;
                case 1: return _kClass;
                case 2: return _block1;
                case 3: return _block2;
                case 4: return _block3;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaClassGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaClassGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaClassGreen(this.Kind, _isAbstract, _kClass, _block1, _block2, _block3, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaClassGreen(this.Kind, _isAbstract, _kClass, _block1, _block2, _block3, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaClassGreen(this.Kind, _isAbstract, _kClass, _block1, _block2, _block3, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaClassGreen Update(__InternalSyntaxToken isAbstract, __InternalSyntaxToken kClass, MetaClassBlock1Green block1, MetaClassBlock2Green block2, MetaClassBlock3Green block3)
        {
            if (_isAbstract != isAbstract || _kClass != kClass || _block1 != block1 || _block2 != block2 || _block3 != block3)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaClass(isAbstract, kClass, block1, block2, block3);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaClassGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaPropertyGreen : GreenSyntaxNode
    {
        internal static new readonly MetaPropertyGreen __Missing = new MetaPropertyGreen();
        private MetaPropertyBlock1Green _block1;
        private MetaTypeReferenceGreen _type;
        private MetaPropertyBlock2Green _block2;
        private MetaPropertyBlock3Green _block3;
        private __GreenNode _block4;
        private __InternalSyntaxToken _tSemicolon;
    
        public MetaPropertyGreen(MetaSyntaxKind kind, MetaPropertyBlock1Green block1, MetaTypeReferenceGreen type, MetaPropertyBlock2Green block2, MetaPropertyBlock3Green block3, __GreenNode block4, __InternalSyntaxToken tSemicolon)
            : base(kind, null, null)
        {
            SlotCount = 6;
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
            if (block4 != null)
            {
                AdjustFlagsAndWidth(block4);
                _block4 = block4;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        public MetaPropertyGreen(MetaSyntaxKind kind, MetaPropertyBlock1Green block1, MetaTypeReferenceGreen type, MetaPropertyBlock2Green block2, MetaPropertyBlock3Green block3, __GreenNode block4, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 6;
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
            if (block4 != null)
            {
                AdjustFlagsAndWidth(block4);
                _block4 = block4;
            }
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        private MetaPropertyGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaProperty, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public MetaPropertyBlock1Green Block1 { get { return _block1; } }
        public MetaTypeReferenceGreen Type { get { return _type; } }
        public MetaPropertyBlock2Green Block2 { get { return _block2; } }
        public MetaPropertyBlock3Green Block3 { get { return _block3; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock4Green> Block4 { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock4Green>(_block4); } }
        public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertySyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _block1;
                case 1: return _type;
                case 2: return _block2;
                case 3: return _block3;
                case 4: return _block4;
                case 5: return _tSemicolon;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyGreen(this.Kind, _block1, _type, _block2, _block3, _block4, _tSemicolon, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyGreen(this.Kind, _block1, _type, _block2, _block3, _block4, _tSemicolon, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyGreen(this.Kind, _block1, _type, _block2, _block3, _block4, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyGreen Update(MetaPropertyBlock1Green block1, MetaTypeReferenceGreen type, MetaPropertyBlock2Green block2, MetaPropertyBlock3Green block3, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock4Green> block4, __InternalSyntaxToken tSemicolon)
        {
            if (_block1 != block1 || _type != type || _block2 != block2 || _block3 != block3 || _block4 != block4.Node || _tSemicolon != tSemicolon)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaProperty(block1, type, block2, block3, block4, tSemicolon);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaOperationGreen : GreenSyntaxNode
    {
        internal static new readonly MetaOperationGreen __Missing = new MetaOperationGreen();
        private MetaTypeReferenceGreen _returnType;
        private NameGreen _name;
        private __InternalSyntaxToken _tLParen;
        private MetaOperationBlock1Green _block;
        private __InternalSyntaxToken _tRParen;
        private __InternalSyntaxToken _tSemicolon;
    
        public MetaOperationGreen(MetaSyntaxKind kind, MetaTypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, MetaOperationBlock1Green block, __InternalSyntaxToken tRParen, __InternalSyntaxToken tSemicolon)
            : base(kind, null, null)
        {
            SlotCount = 6;
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
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        public MetaOperationGreen(MetaSyntaxKind kind, MetaTypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, MetaOperationBlock1Green block, __InternalSyntaxToken tRParen, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 6;
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
            if (tSemicolon != null)
            {
                AdjustFlagsAndWidth(tSemicolon);
                _tSemicolon = tSemicolon;
            }
        }
    
        private MetaOperationGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaOperation, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public MetaTypeReferenceGreen ReturnType { get { return _returnType; } }
        public NameGreen Name { get { return _name; } }
        public __InternalSyntaxToken TLParen { get { return _tLParen; } }
        public MetaOperationBlock1Green Block { get { return _block; } }
        public __InternalSyntaxToken TRParen { get { return _tRParen; } }
        public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaOperationSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _returnType;
                case 1: return _name;
                case 2: return _tLParen;
                case 3: return _block;
                case 4: return _tRParen;
                case 5: return _tSemicolon;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaOperationGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaOperationGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaOperationGreen(this.Kind, _returnType, _name, _tLParen, _block, _tRParen, _tSemicolon, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaOperationGreen(this.Kind, _returnType, _name, _tLParen, _block, _tRParen, _tSemicolon, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaOperationGreen(this.Kind, _returnType, _name, _tLParen, _block, _tRParen, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaOperationGreen Update(MetaTypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, MetaOperationBlock1Green block, __InternalSyntaxToken tRParen, __InternalSyntaxToken tSemicolon)
        {
            if (_returnType != returnType || _name != name || _tLParen != tLParen || _block != block || _tRParen != tRParen || _tSemicolon != tSemicolon)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaOperation(returnType, name, tLParen, block, tRParen, tSemicolon);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaOperationGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaParameterGreen : GreenSyntaxNode
    {
        internal static new readonly MetaParameterGreen __Missing = new MetaParameterGreen();
        private MetaTypeReferenceGreen _type;
        private NameGreen _name;
    
        public MetaParameterGreen(MetaSyntaxKind kind, MetaTypeReferenceGreen type, NameGreen name)
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
    
        public MetaParameterGreen(MetaSyntaxKind kind, MetaTypeReferenceGreen type, NameGreen name, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
    
        private MetaParameterGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaParameter, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public MetaTypeReferenceGreen Type { get { return _type; } }
        public NameGreen Name { get { return _name; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaParameterSyntax(this, (MetaSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaParameterGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaParameterGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaParameterGreen(this.Kind, _type, _name, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaParameterGreen(this.Kind, _type, _name, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaParameterGreen(this.Kind, _type, _name, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaParameterGreen Update(MetaTypeReferenceGreen type, NameGreen name)
        {
            if (_type != type || _name != name)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaParameter(type, name);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaParameterGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaTypeReferenceGreen : GreenSyntaxNode
    {
        internal static new readonly MetaTypeReferenceGreen __Missing = new MetaTypeReferenceGreen();
        private TypeReferenceGreen _type;
        private MetaTypeReferenceBlock1Green _block1;
        private MetaTypeReferenceBlock2Green _block2;
    
        public MetaTypeReferenceGreen(MetaSyntaxKind kind, TypeReferenceGreen type, MetaTypeReferenceBlock1Green block1, MetaTypeReferenceBlock2Green block2)
            : base(kind, null, null)
        {
            SlotCount = 3;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
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
    
        public MetaTypeReferenceGreen(MetaSyntaxKind kind, TypeReferenceGreen type, MetaTypeReferenceBlock1Green block1, MetaTypeReferenceBlock2Green block2, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
            if (type != null)
            {
                AdjustFlagsAndWidth(type);
                _type = type;
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
    
        private MetaTypeReferenceGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaTypeReference, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public TypeReferenceGreen Type { get { return _type; } }
        public MetaTypeReferenceBlock1Green Block1 { get { return _block1; } }
        public MetaTypeReferenceBlock2Green Block2 { get { return _block2; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaTypeReferenceSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _type;
                case 1: return _block1;
                case 2: return _block2;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaTypeReferenceGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaTypeReferenceGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaTypeReferenceGreen(this.Kind, _type, _block1, _block2, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaTypeReferenceGreen(this.Kind, _type, _block1, _block2, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaTypeReferenceGreen(this.Kind, _type, _block1, _block2, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaTypeReferenceGreen Update(TypeReferenceGreen type, MetaTypeReferenceBlock1Green block1, MetaTypeReferenceBlock2Green block2)
        {
            if (_type != type || _block1 != block1 || _block2 != block2)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaTypeReference(type, block1, block2);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaTypeReferenceGreen)newNode;
            }
            return this;
        }
    }
    internal abstract class TypeReferenceGreen : GreenSyntaxNode
    {
        internal static readonly TypeReferenceGreen __Missing = TypeReferenceAlt1Green.__Missing;
    
        protected TypeReferenceGreen(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class TypeReferenceAlt1Green : TypeReferenceGreen
    {
        internal static new readonly TypeReferenceAlt1Green __Missing = new TypeReferenceAlt1Green();
        private PrimitiveTypeGreen _primitiveType;
    
        public TypeReferenceAlt1Green(MetaSyntaxKind kind, PrimitiveTypeGreen primitiveType)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (primitiveType != null)
            {
                AdjustFlagsAndWidth(primitiveType);
                _primitiveType = primitiveType;
            }
        }
    
        public TypeReferenceAlt1Green(MetaSyntaxKind kind, PrimitiveTypeGreen primitiveType, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (primitiveType != null)
            {
                AdjustFlagsAndWidth(primitiveType);
                _primitiveType = primitiveType;
            }
        }
    
        private TypeReferenceAlt1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.TypeReferenceAlt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public PrimitiveTypeGreen PrimitiveType { get { return _primitiveType; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.TypeReferenceAlt1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _primitiveType;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceAlt1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceAlt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new TypeReferenceAlt1Green(this.Kind, _primitiveType, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new TypeReferenceAlt1Green(this.Kind, _primitiveType, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new TypeReferenceAlt1Green(this.Kind, _primitiveType, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public TypeReferenceAlt1Green Update(PrimitiveTypeGreen primitiveType)
        {
            if (_primitiveType != primitiveType)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt1(primitiveType);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (TypeReferenceAlt1Green)newNode;
            }
            return this;
        }
    }
    internal class TypeReferenceAlt2Green : TypeReferenceGreen
    {
        internal static new readonly TypeReferenceAlt2Green __Missing = new TypeReferenceAlt2Green();
        private QualifierGreen _qualifier;
    
        public TypeReferenceAlt2Green(MetaSyntaxKind kind, QualifierGreen qualifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (qualifier != null)
            {
                AdjustFlagsAndWidth(qualifier);
                _qualifier = qualifier;
            }
        }
    
        public TypeReferenceAlt2Green(MetaSyntaxKind kind, QualifierGreen qualifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (qualifier != null)
            {
                AdjustFlagsAndWidth(qualifier);
                _qualifier = qualifier;
            }
        }
    
        private TypeReferenceAlt2Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.TypeReferenceAlt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public QualifierGreen Qualifier { get { return _qualifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.TypeReferenceAlt2Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _qualifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceAlt2Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceAlt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new TypeReferenceAlt2Green(this.Kind, _qualifier, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new TypeReferenceAlt2Green(this.Kind, _qualifier, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new TypeReferenceAlt2Green(this.Kind, _qualifier, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public TypeReferenceAlt2Green Update(QualifierGreen qualifier)
        {
            if (_qualifier != qualifier)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt2(qualifier);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (TypeReferenceAlt2Green)newNode;
            }
            return this;
        }
    }
    internal class PrimitiveTypeGreen : GreenSyntaxNode
    {
        internal static new readonly PrimitiveTypeGreen __Missing = new PrimitiveTypeGreen();
        private __InternalSyntaxToken _token;
    
        public PrimitiveTypeGreen(MetaSyntaxKind kind, __InternalSyntaxToken token)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        public PrimitiveTypeGreen(MetaSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.PrimitiveType, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken Token { get { return _token; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.PrimitiveTypeSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _token;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPrimitiveTypeGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitPrimitiveTypeGreen(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.PrimitiveType(token);
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
    
        protected ValueGreen(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class ValueAlt1Green : ValueGreen
    {
        internal static new readonly ValueAlt1Green __Missing = new ValueAlt1Green();
        private __InternalSyntaxToken _tString;
    
        public ValueAlt1Green(MetaSyntaxKind kind, __InternalSyntaxToken tString)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (tString != null)
            {
                AdjustFlagsAndWidth(tString);
                _tString = tString;
            }
        }
    
        public ValueAlt1Green(MetaSyntaxKind kind, __InternalSyntaxToken tString, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.ValueAlt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TString { get { return _tString; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.ValueAlt1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tString;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitValueAlt1Green(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.ValueAlt1(tString);
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
    
        public ValueAlt2Green(MetaSyntaxKind kind, __InternalSyntaxToken tInteger)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (tInteger != null)
            {
                AdjustFlagsAndWidth(tInteger);
                _tInteger = tInteger;
            }
        }
    
        public ValueAlt2Green(MetaSyntaxKind kind, __InternalSyntaxToken tInteger, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.ValueAlt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TInteger { get { return _tInteger; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.ValueAlt2Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tInteger;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt2Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitValueAlt2Green(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.ValueAlt2(tInteger);
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
    
        public ValueAlt3Green(MetaSyntaxKind kind, __InternalSyntaxToken tDecimal)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (tDecimal != null)
            {
                AdjustFlagsAndWidth(tDecimal);
                _tDecimal = tDecimal;
            }
        }
    
        public ValueAlt3Green(MetaSyntaxKind kind, __InternalSyntaxToken tDecimal, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.ValueAlt3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TDecimal { get { return _tDecimal; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.ValueAlt3Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tDecimal;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt3Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitValueAlt3Green(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.ValueAlt3(tDecimal);
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
    
        public ValueAlt4Green(MetaSyntaxKind kind, TBooleanGreen tBoolean)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (tBoolean != null)
            {
                AdjustFlagsAndWidth(tBoolean);
                _tBoolean = tBoolean;
            }
        }
    
        public ValueAlt4Green(MetaSyntaxKind kind, TBooleanGreen tBoolean, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.ValueAlt4, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public TBooleanGreen TBoolean { get { return _tBoolean; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.ValueAlt4Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tBoolean;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt4Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitValueAlt4Green(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.ValueAlt4(tBoolean);
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
    
        public ValueAlt5Green(MetaSyntaxKind kind, __InternalSyntaxToken kNull)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (kNull != null)
            {
                AdjustFlagsAndWidth(kNull);
                _kNull = kNull;
            }
        }
    
        public ValueAlt5Green(MetaSyntaxKind kind, __InternalSyntaxToken kNull, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.ValueAlt5, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KNull { get { return _kNull; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.ValueAlt5Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kNull;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt5Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitValueAlt5Green(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.ValueAlt5(kNull);
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
    
        public ValueAlt6Green(MetaSyntaxKind kind, QualifierGreen qualifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (qualifier != null)
            {
                AdjustFlagsAndWidth(qualifier);
                _qualifier = qualifier;
            }
        }
    
        public ValueAlt6Green(MetaSyntaxKind kind, QualifierGreen qualifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.ValueAlt6, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public QualifierGreen Qualifier { get { return _qualifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.ValueAlt6Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _qualifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitValueAlt6Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitValueAlt6Green(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.ValueAlt6(qualifier);
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
    
        public NameGreen(MetaSyntaxKind kind, IdentifierGreen identifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        public NameGreen(MetaSyntaxKind kind, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.Name, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public IdentifierGreen Identifier { get { return _identifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.NameSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _identifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitNameGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitNameGreen(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.Name(identifier);
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
    
        public QualifierGreen(MetaSyntaxKind kind, __GreenNode identifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        public QualifierGreen(MetaSyntaxKind kind, __GreenNode identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.Qualifier, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> Identifier { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_identifier, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.QualifierSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _identifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitQualifierGreen(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.Qualifier(identifier);
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
    
        public IdentifierGreen(MetaSyntaxKind kind, __InternalSyntaxToken token)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        public IdentifierGreen(MetaSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.Identifier, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken Token { get { return _token; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.IdentifierSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _token;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitIdentifierGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitIdentifierGreen(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.Identifier(token);
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
    
        public TBooleanGreen(MetaSyntaxKind kind, __InternalSyntaxToken token)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (token != null)
            {
                AdjustFlagsAndWidth(token);
                _token = token;
            }
        }
    
        public TBooleanGreen(MetaSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.TBoolean, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken Token { get { return _token; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.TBooleanSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _token;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTBooleanGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitTBooleanGreen(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.TBoolean(token);
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
        private MetaModelGreen _members1;
        private __GreenNode _members2;
    
        public MainBlock1Green(MetaSyntaxKind kind, MetaModelGreen members1, __GreenNode members2)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (members1 != null)
            {
                AdjustFlagsAndWidth(members1);
                _members1 = members1;
            }
            if (members2 != null)
            {
                AdjustFlagsAndWidth(members2);
                _members2 = members2;
            }
        }
    
        public MainBlock1Green(MetaSyntaxKind kind, MetaModelGreen members1, __GreenNode members2, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (members1 != null)
            {
                AdjustFlagsAndWidth(members1);
                _members1 = members1;
            }
            if (members2 != null)
            {
                AdjustFlagsAndWidth(members2);
                _members2 = members2;
            }
        }
    
        private MainBlock1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MainBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public MetaModelGreen Members1 { get { return _members1; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen> Members2 { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen>(_members2); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MainBlock1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _members1;
                case 1: return _members2;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainBlock1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMainBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MainBlock1Green(this.Kind, _members1, _members2, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MainBlock1Green(this.Kind, _members1, _members2, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MainBlock1Green(this.Kind, _members1, _members2, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MainBlock1Green Update(MetaModelGreen members1, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen> members2)
        {
            if (_members1 != members1 || _members2 != members2.Node)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MainBlock1(members1, members2);
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
    internal class MetaModelBlock1Green : GreenSyntaxNode
    {
        internal static new readonly MetaModelBlock1Green __Missing = new MetaModelBlock1Green();
        private __InternalSyntaxToken _tEq;
        private __InternalSyntaxToken _uri;
    
        public MetaModelBlock1Green(MetaSyntaxKind kind, __InternalSyntaxToken tEq, __InternalSyntaxToken uri)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tEq != null)
            {
                AdjustFlagsAndWidth(tEq);
                _tEq = tEq;
            }
            if (uri != null)
            {
                AdjustFlagsAndWidth(uri);
                _uri = uri;
            }
        }
    
        public MetaModelBlock1Green(MetaSyntaxKind kind, __InternalSyntaxToken tEq, __InternalSyntaxToken uri, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tEq != null)
            {
                AdjustFlagsAndWidth(tEq);
                _tEq = tEq;
            }
            if (uri != null)
            {
                AdjustFlagsAndWidth(uri);
                _uri = uri;
            }
        }
    
        private MetaModelBlock1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaModelBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TEq { get { return _tEq; } }
        public __InternalSyntaxToken Uri { get { return _uri; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaModelBlock1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tEq;
                case 1: return _uri;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaModelBlock1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaModelBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaModelBlock1Green(this.Kind, _tEq, _uri, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaModelBlock1Green(this.Kind, _tEq, _uri, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaModelBlock1Green(this.Kind, _tEq, _uri, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaModelBlock1Green Update(__InternalSyntaxToken tEq, __InternalSyntaxToken uri)
        {
            if (_tEq != tEq || _uri != uri)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaModelBlock1(tEq, uri);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaModelBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class MetaEnumBlock1Green : GreenSyntaxNode
    {
        internal static new readonly MetaEnumBlock1Green __Missing = new MetaEnumBlock1Green();
        private __InternalSyntaxToken _tLBrace;
        private __GreenNode _literals;
        private __InternalSyntaxToken _tRBrace;
    
        public MetaEnumBlock1Green(MetaSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode literals, __InternalSyntaxToken tRBrace)
            : base(kind, null, null)
        {
            SlotCount = 3;
            if (tLBrace != null)
            {
                AdjustFlagsAndWidth(tLBrace);
                _tLBrace = tLBrace;
            }
            if (literals != null)
            {
                AdjustFlagsAndWidth(literals);
                _literals = literals;
            }
            if (tRBrace != null)
            {
                AdjustFlagsAndWidth(tRBrace);
                _tRBrace = tRBrace;
            }
        }
    
        public MetaEnumBlock1Green(MetaSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode literals, __InternalSyntaxToken tRBrace, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
            if (tLBrace != null)
            {
                AdjustFlagsAndWidth(tLBrace);
                _tLBrace = tLBrace;
            }
            if (literals != null)
            {
                AdjustFlagsAndWidth(literals);
                _literals = literals;
            }
            if (tRBrace != null)
            {
                AdjustFlagsAndWidth(tRBrace);
                _tRBrace = tRBrace;
            }
        }
    
        private MetaEnumBlock1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaEnumBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TLBrace { get { return _tLBrace; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen> Literals { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen>(_literals, reversed: false); } }
        public __InternalSyntaxToken TRBrace { get { return _tRBrace; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaEnumBlock1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tLBrace;
                case 1: return _literals;
                case 2: return _tRBrace;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaEnumBlock1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaEnumBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaEnumBlock1Green(this.Kind, _tLBrace, _literals, _tRBrace, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaEnumBlock1Green(this.Kind, _tLBrace, _literals, _tRBrace, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaEnumBlock1Green(this.Kind, _tLBrace, _literals, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaEnumBlock1Green Update(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen> literals, __InternalSyntaxToken tRBrace)
        {
            if (_tLBrace != tLBrace || _literals != literals.Node || _tRBrace != tRBrace)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaEnumBlock1(tLBrace, literals, tRBrace);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaEnumBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class MetaEnumBlock1literalsBlockGreen : GreenSyntaxNode
    {
        internal static new readonly MetaEnumBlock1literalsBlockGreen __Missing = new MetaEnumBlock1literalsBlockGreen();
        private __InternalSyntaxToken _tComma;
        private MetaEnumLiteralGreen _literals;
    
        public MetaEnumBlock1literalsBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, MetaEnumLiteralGreen literals)
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
    
        public MetaEnumBlock1literalsBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, MetaEnumLiteralGreen literals, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
    
        private MetaEnumBlock1literalsBlockGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaEnumBlock1literalsBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public MetaEnumLiteralGreen Literals { get { return _literals; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaEnumBlock1literalsBlockSyntax(this, (MetaSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaEnumBlock1literalsBlockGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaEnumBlock1literalsBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaEnumBlock1literalsBlockGreen(this.Kind, _tComma, _literals, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaEnumBlock1literalsBlockGreen(this.Kind, _tComma, _literals, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaEnumBlock1literalsBlockGreen(this.Kind, _tComma, _literals, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaEnumBlock1literalsBlockGreen Update(__InternalSyntaxToken tComma, MetaEnumLiteralGreen literals)
        {
            if (_tComma != tComma || _literals != literals)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaEnumBlock1literalsBlock(tComma, literals);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaEnumBlock1literalsBlockGreen)newNode;
            }
            return this;
        }
    }
    internal abstract class MetaClassBlock1Green : GreenSyntaxNode
    {
        internal static readonly MetaClassBlock1Green __Missing = MetaClassBlock1Alt1Green.__Missing;
    
        protected MetaClassBlock1Green(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class MetaClassBlock1Alt1Green : MetaClassBlock1Green
    {
        internal static new readonly MetaClassBlock1Alt1Green __Missing = new MetaClassBlock1Alt1Green();
        private IdentifierGreen _identifier;
        private __InternalSyntaxToken _tDollar;
        private IdentifierGreen _symbolType;
    
        public MetaClassBlock1Alt1Green(MetaSyntaxKind kind, IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolType)
            : base(kind, null, null)
        {
            SlotCount = 3;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
            if (tDollar != null)
            {
                AdjustFlagsAndWidth(tDollar);
                _tDollar = tDollar;
            }
            if (symbolType != null)
            {
                AdjustFlagsAndWidth(symbolType);
                _symbolType = symbolType;
            }
        }
    
        public MetaClassBlock1Alt1Green(MetaSyntaxKind kind, IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolType, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
            if (tDollar != null)
            {
                AdjustFlagsAndWidth(tDollar);
                _tDollar = tDollar;
            }
            if (symbolType != null)
            {
                AdjustFlagsAndWidth(symbolType);
                _symbolType = symbolType;
            }
        }
    
        private MetaClassBlock1Alt1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock1Alt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public IdentifierGreen Identifier { get { return _identifier; } }
        public __InternalSyntaxToken TDollar { get { return _tDollar; } }
        public IdentifierGreen SymbolType { get { return _symbolType; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaClassBlock1Alt1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _identifier;
                case 1: return _tDollar;
                case 2: return _symbolType;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaClassBlock1Alt1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaClassBlock1Alt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaClassBlock1Alt1Green(this.Kind, _identifier, _tDollar, _symbolType, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaClassBlock1Alt1Green(this.Kind, _identifier, _tDollar, _symbolType, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaClassBlock1Alt1Green(this.Kind, _identifier, _tDollar, _symbolType, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaClassBlock1Alt1Green Update(IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolType)
        {
            if (_identifier != identifier || _tDollar != tDollar || _symbolType != symbolType)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock1Alt1(identifier, tDollar, symbolType);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaClassBlock1Alt1Green)newNode;
            }
            return this;
        }
    }
    internal class MetaClassBlock1Alt2Green : MetaClassBlock1Green
    {
        internal static new readonly MetaClassBlock1Alt2Green __Missing = new MetaClassBlock1Alt2Green();
        private IdentifierGreen _identifier;
    
        public MetaClassBlock1Alt2Green(MetaSyntaxKind kind, IdentifierGreen identifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        public MetaClassBlock1Alt2Green(MetaSyntaxKind kind, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        private MetaClassBlock1Alt2Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock1Alt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public IdentifierGreen Identifier { get { return _identifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaClassBlock1Alt2Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _identifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaClassBlock1Alt2Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaClassBlock1Alt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaClassBlock1Alt2Green(this.Kind, _identifier, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaClassBlock1Alt2Green(this.Kind, _identifier, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaClassBlock1Alt2Green(this.Kind, _identifier, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaClassBlock1Alt2Green Update(IdentifierGreen identifier)
        {
            if (_identifier != identifier)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock1Alt2(identifier);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaClassBlock1Alt2Green)newNode;
            }
            return this;
        }
    }
    internal class MetaClassBlock2Green : GreenSyntaxNode
    {
        internal static new readonly MetaClassBlock2Green __Missing = new MetaClassBlock2Green();
        private __InternalSyntaxToken _tColon;
        private __GreenNode _baseTypes;
    
        public MetaClassBlock2Green(MetaSyntaxKind kind, __InternalSyntaxToken tColon, __GreenNode baseTypes)
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
    
        public MetaClassBlock2Green(MetaSyntaxKind kind, __InternalSyntaxToken tColon, __GreenNode baseTypes, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
    
        private MetaClassBlock2Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TColon { get { return _tColon; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> BaseTypes { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_baseTypes, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaClassBlock2Syntax(this, (MetaSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaClassBlock2Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaClassBlock2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaClassBlock2Green(this.Kind, _tColon, _baseTypes, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaClassBlock2Green(this.Kind, _tColon, _baseTypes, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaClassBlock2Green(this.Kind, _tColon, _baseTypes, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaClassBlock2Green Update(__InternalSyntaxToken tColon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> baseTypes)
        {
            if (_tColon != tColon || _baseTypes != baseTypes.Node)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock2(tColon, baseTypes);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaClassBlock2Green)newNode;
            }
            return this;
        }
    }
    internal class MetaClassBlock2baseTypesBlockGreen : GreenSyntaxNode
    {
        internal static new readonly MetaClassBlock2baseTypesBlockGreen __Missing = new MetaClassBlock2baseTypesBlockGreen();
        private __InternalSyntaxToken _tComma;
        private QualifierGreen _baseTypes;
    
        public MetaClassBlock2baseTypesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen baseTypes)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (baseTypes != null)
            {
                AdjustFlagsAndWidth(baseTypes);
                _baseTypes = baseTypes;
            }
        }
    
        public MetaClassBlock2baseTypesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen baseTypes, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (baseTypes != null)
            {
                AdjustFlagsAndWidth(baseTypes);
                _baseTypes = baseTypes;
            }
        }
    
        private MetaClassBlock2baseTypesBlockGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock2baseTypesBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public QualifierGreen BaseTypes { get { return _baseTypes; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaClassBlock2baseTypesBlockSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tComma;
                case 1: return _baseTypes;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaClassBlock2baseTypesBlockGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaClassBlock2baseTypesBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaClassBlock2baseTypesBlockGreen(this.Kind, _tComma, _baseTypes, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaClassBlock2baseTypesBlockGreen(this.Kind, _tComma, _baseTypes, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaClassBlock2baseTypesBlockGreen(this.Kind, _tComma, _baseTypes, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaClassBlock2baseTypesBlockGreen Update(__InternalSyntaxToken tComma, QualifierGreen baseTypes)
        {
            if (_tComma != tComma || _baseTypes != baseTypes)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock2baseTypesBlock(tComma, baseTypes);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaClassBlock2baseTypesBlockGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaClassBlock3Green : GreenSyntaxNode
    {
        internal static new readonly MetaClassBlock3Green __Missing = new MetaClassBlock3Green();
        private __InternalSyntaxToken _tLBrace;
        private __GreenNode _block;
        private __InternalSyntaxToken _tRBrace;
    
        public MetaClassBlock3Green(MetaSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode block, __InternalSyntaxToken tRBrace)
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
    
        public MetaClassBlock3Green(MetaSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode block, __InternalSyntaxToken tRBrace, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
    
        private MetaClassBlock3Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TLBrace { get { return _tLBrace; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaClassBlock3Block1Green> Block { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaClassBlock3Block1Green>(_block); } }
        public __InternalSyntaxToken TRBrace { get { return _tRBrace; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaClassBlock3Syntax(this, (MetaSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaClassBlock3Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaClassBlock3Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaClassBlock3Green(this.Kind, _tLBrace, _block, _tRBrace, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaClassBlock3Green(this.Kind, _tLBrace, _block, _tRBrace, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaClassBlock3Green(this.Kind, _tLBrace, _block, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaClassBlock3Green Update(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaClassBlock3Block1Green> block, __InternalSyntaxToken tRBrace)
        {
            if (_tLBrace != tLBrace || _block != block.Node || _tRBrace != tRBrace)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock3(tLBrace, block, tRBrace);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaClassBlock3Green)newNode;
            }
            return this;
        }
    }
    internal abstract class MetaClassBlock3Block1Green : GreenSyntaxNode
    {
        internal static readonly MetaClassBlock3Block1Green __Missing = MetaClassBlock3Block1Alt1Green.__Missing;
    
        protected MetaClassBlock3Block1Green(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class MetaClassBlock3Block1Alt1Green : MetaClassBlock3Block1Green
    {
        internal static new readonly MetaClassBlock3Block1Alt1Green __Missing = new MetaClassBlock3Block1Alt1Green();
        private MetaPropertyGreen _properties;
    
        public MetaClassBlock3Block1Alt1Green(MetaSyntaxKind kind, MetaPropertyGreen properties)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (properties != null)
            {
                AdjustFlagsAndWidth(properties);
                _properties = properties;
            }
        }
    
        public MetaClassBlock3Block1Alt1Green(MetaSyntaxKind kind, MetaPropertyGreen properties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (properties != null)
            {
                AdjustFlagsAndWidth(properties);
                _properties = properties;
            }
        }
    
        private MetaClassBlock3Block1Alt1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock3Block1Alt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public MetaPropertyGreen Properties { get { return _properties; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaClassBlock3Block1Alt1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _properties;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaClassBlock3Block1Alt1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaClassBlock3Block1Alt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaClassBlock3Block1Alt1Green(this.Kind, _properties, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaClassBlock3Block1Alt1Green(this.Kind, _properties, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaClassBlock3Block1Alt1Green(this.Kind, _properties, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaClassBlock3Block1Alt1Green Update(MetaPropertyGreen properties)
        {
            if (_properties != properties)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock3Block1Alt1(properties);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaClassBlock3Block1Alt1Green)newNode;
            }
            return this;
        }
    }
    internal class MetaClassBlock3Block1Alt2Green : MetaClassBlock3Block1Green
    {
        internal static new readonly MetaClassBlock3Block1Alt2Green __Missing = new MetaClassBlock3Block1Alt2Green();
        private MetaOperationGreen _operations;
    
        public MetaClassBlock3Block1Alt2Green(MetaSyntaxKind kind, MetaOperationGreen operations)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (operations != null)
            {
                AdjustFlagsAndWidth(operations);
                _operations = operations;
            }
        }
    
        public MetaClassBlock3Block1Alt2Green(MetaSyntaxKind kind, MetaOperationGreen operations, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (operations != null)
            {
                AdjustFlagsAndWidth(operations);
                _operations = operations;
            }
        }
    
        private MetaClassBlock3Block1Alt2Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock3Block1Alt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public MetaOperationGreen Operations { get { return _operations; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaClassBlock3Block1Alt2Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _operations;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaClassBlock3Block1Alt2Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaClassBlock3Block1Alt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaClassBlock3Block1Alt2Green(this.Kind, _operations, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaClassBlock3Block1Alt2Green(this.Kind, _operations, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaClassBlock3Block1Alt2Green(this.Kind, _operations, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaClassBlock3Block1Alt2Green Update(MetaOperationGreen operations)
        {
            if (_operations != operations)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock3Block1Alt2(operations);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaClassBlock3Block1Alt2Green)newNode;
            }
            return this;
        }
    }
    internal abstract class MetaPropertyBlock1Green : GreenSyntaxNode
    {
        internal static readonly MetaPropertyBlock1Green __Missing = MetaPropertyBlock1Alt1Green.__Missing;
    
        protected MetaPropertyBlock1Green(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class MetaPropertyBlock1Alt1Green : MetaPropertyBlock1Green
    {
        internal static new readonly MetaPropertyBlock1Alt1Green __Missing = new MetaPropertyBlock1Alt1Green();
        private __InternalSyntaxToken _isContainment;
    
        public MetaPropertyBlock1Alt1Green(MetaSyntaxKind kind, __InternalSyntaxToken isContainment)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (isContainment != null)
            {
                AdjustFlagsAndWidth(isContainment);
                _isContainment = isContainment;
            }
        }
    
        public MetaPropertyBlock1Alt1Green(MetaSyntaxKind kind, __InternalSyntaxToken isContainment, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (isContainment != null)
            {
                AdjustFlagsAndWidth(isContainment);
                _isContainment = isContainment;
            }
        }
    
        private MetaPropertyBlock1Alt1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock1Alt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsContainment { get { return _isContainment; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock1Alt1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isContainment;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock1Alt1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock1Alt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock1Alt1Green(this.Kind, _isContainment, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock1Alt1Green(this.Kind, _isContainment, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock1Alt1Green(this.Kind, _isContainment, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock1Alt1Green Update(__InternalSyntaxToken isContainment)
        {
            if (_isContainment != isContainment)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock1Alt1(isContainment);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock1Alt1Green)newNode;
            }
            return this;
        }
    }
    internal class MetaPropertyBlock1Alt2Green : MetaPropertyBlock1Green
    {
        internal static new readonly MetaPropertyBlock1Alt2Green __Missing = new MetaPropertyBlock1Alt2Green();
        private __InternalSyntaxToken _isDerived;
    
        public MetaPropertyBlock1Alt2Green(MetaSyntaxKind kind, __InternalSyntaxToken isDerived)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (isDerived != null)
            {
                AdjustFlagsAndWidth(isDerived);
                _isDerived = isDerived;
            }
        }
    
        public MetaPropertyBlock1Alt2Green(MetaSyntaxKind kind, __InternalSyntaxToken isDerived, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (isDerived != null)
            {
                AdjustFlagsAndWidth(isDerived);
                _isDerived = isDerived;
            }
        }
    
        private MetaPropertyBlock1Alt2Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock1Alt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsDerived { get { return _isDerived; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock1Alt2Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isDerived;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock1Alt2Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock1Alt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock1Alt2Green(this.Kind, _isDerived, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock1Alt2Green(this.Kind, _isDerived, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock1Alt2Green(this.Kind, _isDerived, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock1Alt2Green Update(__InternalSyntaxToken isDerived)
        {
            if (_isDerived != isDerived)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock1Alt2(isDerived);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock1Alt2Green)newNode;
            }
            return this;
        }
    }
    internal class MetaPropertyBlock1Alt3Green : MetaPropertyBlock1Green
    {
        internal static new readonly MetaPropertyBlock1Alt3Green __Missing = new MetaPropertyBlock1Alt3Green();
        private __InternalSyntaxToken _isUnion;
    
        public MetaPropertyBlock1Alt3Green(MetaSyntaxKind kind, __InternalSyntaxToken isUnion)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (isUnion != null)
            {
                AdjustFlagsAndWidth(isUnion);
                _isUnion = isUnion;
            }
        }
    
        public MetaPropertyBlock1Alt3Green(MetaSyntaxKind kind, __InternalSyntaxToken isUnion, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (isUnion != null)
            {
                AdjustFlagsAndWidth(isUnion);
                _isUnion = isUnion;
            }
        }
    
        private MetaPropertyBlock1Alt3Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock1Alt3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsUnion { get { return _isUnion; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock1Alt3Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isUnion;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock1Alt3Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock1Alt3Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock1Alt3Green(this.Kind, _isUnion, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock1Alt3Green(this.Kind, _isUnion, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock1Alt3Green(this.Kind, _isUnion, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock1Alt3Green Update(__InternalSyntaxToken isUnion)
        {
            if (_isUnion != isUnion)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock1Alt3(isUnion);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock1Alt3Green)newNode;
            }
            return this;
        }
    }
    internal class MetaPropertyBlock1Alt4Green : MetaPropertyBlock1Green
    {
        internal static new readonly MetaPropertyBlock1Alt4Green __Missing = new MetaPropertyBlock1Alt4Green();
        private __InternalSyntaxToken _isReadOnly;
    
        public MetaPropertyBlock1Alt4Green(MetaSyntaxKind kind, __InternalSyntaxToken isReadOnly)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (isReadOnly != null)
            {
                AdjustFlagsAndWidth(isReadOnly);
                _isReadOnly = isReadOnly;
            }
        }
    
        public MetaPropertyBlock1Alt4Green(MetaSyntaxKind kind, __InternalSyntaxToken isReadOnly, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (isReadOnly != null)
            {
                AdjustFlagsAndWidth(isReadOnly);
                _isReadOnly = isReadOnly;
            }
        }
    
        private MetaPropertyBlock1Alt4Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock1Alt4, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsReadOnly { get { return _isReadOnly; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock1Alt4Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isReadOnly;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock1Alt4Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock1Alt4Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock1Alt4Green(this.Kind, _isReadOnly, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock1Alt4Green(this.Kind, _isReadOnly, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock1Alt4Green(this.Kind, _isReadOnly, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock1Alt4Green Update(__InternalSyntaxToken isReadOnly)
        {
            if (_isReadOnly != isReadOnly)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock1Alt4(isReadOnly);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock1Alt4Green)newNode;
            }
            return this;
        }
    }
    internal abstract class MetaPropertyBlock2Green : GreenSyntaxNode
    {
        internal static readonly MetaPropertyBlock2Green __Missing = MetaPropertyBlock2Alt1Green.__Missing;
    
        protected MetaPropertyBlock2Green(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class MetaPropertyBlock2Alt1Green : MetaPropertyBlock2Green
    {
        internal static new readonly MetaPropertyBlock2Alt1Green __Missing = new MetaPropertyBlock2Alt1Green();
        private IdentifierGreen _identifier;
        private __InternalSyntaxToken _tDollar;
        private IdentifierGreen _symbolProperty;
    
        public MetaPropertyBlock2Alt1Green(MetaSyntaxKind kind, IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolProperty)
            : base(kind, null, null)
        {
            SlotCount = 3;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
            if (tDollar != null)
            {
                AdjustFlagsAndWidth(tDollar);
                _tDollar = tDollar;
            }
            if (symbolProperty != null)
            {
                AdjustFlagsAndWidth(symbolProperty);
                _symbolProperty = symbolProperty;
            }
        }
    
        public MetaPropertyBlock2Alt1Green(MetaSyntaxKind kind, IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolProperty, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 3;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
            if (tDollar != null)
            {
                AdjustFlagsAndWidth(tDollar);
                _tDollar = tDollar;
            }
            if (symbolProperty != null)
            {
                AdjustFlagsAndWidth(symbolProperty);
                _symbolProperty = symbolProperty;
            }
        }
    
        private MetaPropertyBlock2Alt1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock2Alt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public IdentifierGreen Identifier { get { return _identifier; } }
        public __InternalSyntaxToken TDollar { get { return _tDollar; } }
        public IdentifierGreen SymbolProperty { get { return _symbolProperty; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock2Alt1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _identifier;
                case 1: return _tDollar;
                case 2: return _symbolProperty;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock2Alt1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock2Alt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock2Alt1Green(this.Kind, _identifier, _tDollar, _symbolProperty, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock2Alt1Green(this.Kind, _identifier, _tDollar, _symbolProperty, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock2Alt1Green(this.Kind, _identifier, _tDollar, _symbolProperty, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock2Alt1Green Update(IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolProperty)
        {
            if (_identifier != identifier || _tDollar != tDollar || _symbolProperty != symbolProperty)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock2Alt1(identifier, tDollar, symbolProperty);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock2Alt1Green)newNode;
            }
            return this;
        }
    }
    internal class MetaPropertyBlock2Alt2Green : MetaPropertyBlock2Green
    {
        internal static new readonly MetaPropertyBlock2Alt2Green __Missing = new MetaPropertyBlock2Alt2Green();
        private IdentifierGreen _identifier;
    
        public MetaPropertyBlock2Alt2Green(MetaSyntaxKind kind, IdentifierGreen identifier)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        public MetaPropertyBlock2Alt2Green(MetaSyntaxKind kind, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (identifier != null)
            {
                AdjustFlagsAndWidth(identifier);
                _identifier = identifier;
            }
        }
    
        private MetaPropertyBlock2Alt2Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock2Alt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public IdentifierGreen Identifier { get { return _identifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock2Alt2Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _identifier;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock2Alt2Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock2Alt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock2Alt2Green(this.Kind, _identifier, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock2Alt2Green(this.Kind, _identifier, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock2Alt2Green(this.Kind, _identifier, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock2Alt2Green Update(IdentifierGreen identifier)
        {
            if (_identifier != identifier)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock2Alt2(identifier);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock2Alt2Green)newNode;
            }
            return this;
        }
    }
    internal class MetaPropertyBlock3Green : GreenSyntaxNode
    {
        internal static new readonly MetaPropertyBlock3Green __Missing = new MetaPropertyBlock3Green();
        private __InternalSyntaxToken _tEq;
        private ValueGreen _defaultValue;
    
        public MetaPropertyBlock3Green(MetaSyntaxKind kind, __InternalSyntaxToken tEq, ValueGreen defaultValue)
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
    
        public MetaPropertyBlock3Green(MetaSyntaxKind kind, __InternalSyntaxToken tEq, ValueGreen defaultValue, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
    
        private MetaPropertyBlock3Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TEq { get { return _tEq; } }
        public ValueGreen DefaultValue { get { return _defaultValue; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock3Syntax(this, (MetaSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock3Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock3Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock3Green(this.Kind, _tEq, _defaultValue, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock3Green(this.Kind, _tEq, _defaultValue, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock3Green(this.Kind, _tEq, _defaultValue, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock3Green Update(__InternalSyntaxToken tEq, ValueGreen defaultValue)
        {
            if (_tEq != tEq || _defaultValue != defaultValue)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock3(tEq, defaultValue);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock3Green)newNode;
            }
            return this;
        }
    }
    internal abstract class MetaPropertyBlock4Green : GreenSyntaxNode
    {
        internal static readonly MetaPropertyBlock4Green __Missing = MetaPropertyBlock4Alt1Green.__Missing;
    
        protected MetaPropertyBlock4Green(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
        }
    }
    internal class MetaPropertyBlock4Alt1Green : MetaPropertyBlock4Green
    {
        internal static new readonly MetaPropertyBlock4Alt1Green __Missing = new MetaPropertyBlock4Alt1Green();
        private __InternalSyntaxToken _kOpposite;
        private __GreenNode _oppositeProperties;
    
        public MetaPropertyBlock4Alt1Green(MetaSyntaxKind kind, __InternalSyntaxToken kOpposite, __GreenNode oppositeProperties)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (kOpposite != null)
            {
                AdjustFlagsAndWidth(kOpposite);
                _kOpposite = kOpposite;
            }
            if (oppositeProperties != null)
            {
                AdjustFlagsAndWidth(oppositeProperties);
                _oppositeProperties = oppositeProperties;
            }
        }
    
        public MetaPropertyBlock4Alt1Green(MetaSyntaxKind kind, __InternalSyntaxToken kOpposite, __GreenNode oppositeProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (kOpposite != null)
            {
                AdjustFlagsAndWidth(kOpposite);
                _kOpposite = kOpposite;
            }
            if (oppositeProperties != null)
            {
                AdjustFlagsAndWidth(oppositeProperties);
                _oppositeProperties = oppositeProperties;
            }
        }
    
        private MetaPropertyBlock4Alt1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KOpposite { get { return _kOpposite; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> OppositeProperties { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_oppositeProperties, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock4Alt1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kOpposite;
                case 1: return _oppositeProperties;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock4Alt1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock4Alt1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock4Alt1Green(this.Kind, _kOpposite, _oppositeProperties, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock4Alt1Green(this.Kind, _kOpposite, _oppositeProperties, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock4Alt1Green(this.Kind, _kOpposite, _oppositeProperties, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock4Alt1Green Update(__InternalSyntaxToken kOpposite, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> oppositeProperties)
        {
            if (_kOpposite != kOpposite || _oppositeProperties != oppositeProperties.Node)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock4Alt1(kOpposite, oppositeProperties);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock4Alt1Green)newNode;
            }
            return this;
        }
    }
    internal class MetaPropertyBlock4Alt2Green : MetaPropertyBlock4Green
    {
        internal static new readonly MetaPropertyBlock4Alt2Green __Missing = new MetaPropertyBlock4Alt2Green();
        private __InternalSyntaxToken _kSubsets;
        private __GreenNode _subsettedProperties;
    
        public MetaPropertyBlock4Alt2Green(MetaSyntaxKind kind, __InternalSyntaxToken kSubsets, __GreenNode subsettedProperties)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (kSubsets != null)
            {
                AdjustFlagsAndWidth(kSubsets);
                _kSubsets = kSubsets;
            }
            if (subsettedProperties != null)
            {
                AdjustFlagsAndWidth(subsettedProperties);
                _subsettedProperties = subsettedProperties;
            }
        }
    
        public MetaPropertyBlock4Alt2Green(MetaSyntaxKind kind, __InternalSyntaxToken kSubsets, __GreenNode subsettedProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (kSubsets != null)
            {
                AdjustFlagsAndWidth(kSubsets);
                _kSubsets = kSubsets;
            }
            if (subsettedProperties != null)
            {
                AdjustFlagsAndWidth(subsettedProperties);
                _subsettedProperties = subsettedProperties;
            }
        }
    
        private MetaPropertyBlock4Alt2Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KSubsets { get { return _kSubsets; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> SubsettedProperties { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_subsettedProperties, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock4Alt2Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kSubsets;
                case 1: return _subsettedProperties;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock4Alt2Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock4Alt2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock4Alt2Green(this.Kind, _kSubsets, _subsettedProperties, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock4Alt2Green(this.Kind, _kSubsets, _subsettedProperties, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock4Alt2Green(this.Kind, _kSubsets, _subsettedProperties, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock4Alt2Green Update(__InternalSyntaxToken kSubsets, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> subsettedProperties)
        {
            if (_kSubsets != kSubsets || _subsettedProperties != subsettedProperties.Node)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock4Alt2(kSubsets, subsettedProperties);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock4Alt2Green)newNode;
            }
            return this;
        }
    }
    internal class MetaPropertyBlock4Alt3Green : MetaPropertyBlock4Green
    {
        internal static new readonly MetaPropertyBlock4Alt3Green __Missing = new MetaPropertyBlock4Alt3Green();
        private __InternalSyntaxToken _kRedefines;
        private __GreenNode _redefinedProperties;
    
        public MetaPropertyBlock4Alt3Green(MetaSyntaxKind kind, __InternalSyntaxToken kRedefines, __GreenNode redefinedProperties)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (kRedefines != null)
            {
                AdjustFlagsAndWidth(kRedefines);
                _kRedefines = kRedefines;
            }
            if (redefinedProperties != null)
            {
                AdjustFlagsAndWidth(redefinedProperties);
                _redefinedProperties = redefinedProperties;
            }
        }
    
        public MetaPropertyBlock4Alt3Green(MetaSyntaxKind kind, __InternalSyntaxToken kRedefines, __GreenNode redefinedProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (kRedefines != null)
            {
                AdjustFlagsAndWidth(kRedefines);
                _kRedefines = kRedefines;
            }
            if (redefinedProperties != null)
            {
                AdjustFlagsAndWidth(redefinedProperties);
                _redefinedProperties = redefinedProperties;
            }
        }
    
        private MetaPropertyBlock4Alt3Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt3, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken KRedefines { get { return _kRedefines; } }
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> RedefinedProperties { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_redefinedProperties, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock4Alt3Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _kRedefines;
                case 1: return _redefinedProperties;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock4Alt3Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock4Alt3Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock4Alt3Green(this.Kind, _kRedefines, _redefinedProperties, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock4Alt3Green(this.Kind, _kRedefines, _redefinedProperties, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock4Alt3Green(this.Kind, _kRedefines, _redefinedProperties, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock4Alt3Green Update(__InternalSyntaxToken kRedefines, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> redefinedProperties)
        {
            if (_kRedefines != kRedefines || _redefinedProperties != redefinedProperties.Node)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock4Alt3(kRedefines, redefinedProperties);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock4Alt3Green)newNode;
            }
            return this;
        }
    }
    internal class MetaPropertyBlock4Alt1oppositePropertiesBlockGreen : GreenSyntaxNode
    {
        internal static new readonly MetaPropertyBlock4Alt1oppositePropertiesBlockGreen __Missing = new MetaPropertyBlock4Alt1oppositePropertiesBlockGreen();
        private __InternalSyntaxToken _tComma;
        private QualifierGreen _oppositeProperties;
    
        public MetaPropertyBlock4Alt1oppositePropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen oppositeProperties)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (oppositeProperties != null)
            {
                AdjustFlagsAndWidth(oppositeProperties);
                _oppositeProperties = oppositeProperties;
            }
        }
    
        public MetaPropertyBlock4Alt1oppositePropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen oppositeProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (oppositeProperties != null)
            {
                AdjustFlagsAndWidth(oppositeProperties);
                _oppositeProperties = oppositeProperties;
            }
        }
    
        private MetaPropertyBlock4Alt1oppositePropertiesBlockGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt1oppositePropertiesBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public QualifierGreen OppositeProperties { get { return _oppositeProperties; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock4Alt1oppositePropertiesBlockSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tComma;
                case 1: return _oppositeProperties;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock4Alt1oppositePropertiesBlockGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock4Alt1oppositePropertiesBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock4Alt1oppositePropertiesBlockGreen(this.Kind, _tComma, _oppositeProperties, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock4Alt1oppositePropertiesBlockGreen(this.Kind, _tComma, _oppositeProperties, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock4Alt1oppositePropertiesBlockGreen(this.Kind, _tComma, _oppositeProperties, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock4Alt1oppositePropertiesBlockGreen Update(__InternalSyntaxToken tComma, QualifierGreen oppositeProperties)
        {
            if (_tComma != tComma || _oppositeProperties != oppositeProperties)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock4Alt1oppositePropertiesBlock(tComma, oppositeProperties);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock4Alt1oppositePropertiesBlockGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen : GreenSyntaxNode
    {
        internal static new readonly MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen __Missing = new MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen();
        private __InternalSyntaxToken _tComma;
        private QualifierGreen _subsettedProperties;
    
        public MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen subsettedProperties)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (subsettedProperties != null)
            {
                AdjustFlagsAndWidth(subsettedProperties);
                _subsettedProperties = subsettedProperties;
            }
        }
    
        public MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen subsettedProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (subsettedProperties != null)
            {
                AdjustFlagsAndWidth(subsettedProperties);
                _subsettedProperties = subsettedProperties;
            }
        }
    
        private MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt2subsettedPropertiesBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public QualifierGreen SubsettedProperties { get { return _subsettedProperties; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock4Alt2subsettedPropertiesBlockSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tComma;
                case 1: return _subsettedProperties;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock4Alt2subsettedPropertiesBlockGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock4Alt2subsettedPropertiesBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen(this.Kind, _tComma, _subsettedProperties, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen(this.Kind, _tComma, _subsettedProperties, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen(this.Kind, _tComma, _subsettedProperties, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen Update(__InternalSyntaxToken tComma, QualifierGreen subsettedProperties)
        {
            if (_tComma != tComma || _subsettedProperties != subsettedProperties)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock4Alt2subsettedPropertiesBlock(tComma, subsettedProperties);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen : GreenSyntaxNode
    {
        internal static new readonly MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen __Missing = new MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen();
        private __InternalSyntaxToken _tComma;
        private QualifierGreen _redefinedProperties;
    
        public MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen redefinedProperties)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (redefinedProperties != null)
            {
                AdjustFlagsAndWidth(redefinedProperties);
                _redefinedProperties = redefinedProperties;
            }
        }
    
        public MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen redefinedProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (tComma != null)
            {
                AdjustFlagsAndWidth(tComma);
                _tComma = tComma;
            }
            if (redefinedProperties != null)
            {
                AdjustFlagsAndWidth(redefinedProperties);
                _redefinedProperties = redefinedProperties;
            }
        }
    
        private MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt3redefinedPropertiesBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public QualifierGreen RedefinedProperties { get { return _redefinedProperties; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock4Alt3redefinedPropertiesBlockSyntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _tComma;
                case 1: return _redefinedProperties;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock4Alt3redefinedPropertiesBlockGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock4Alt3redefinedPropertiesBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen(this.Kind, _tComma, _redefinedProperties, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen(this.Kind, _tComma, _redefinedProperties, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen(this.Kind, _tComma, _redefinedProperties, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen Update(__InternalSyntaxToken tComma, QualifierGreen redefinedProperties)
        {
            if (_tComma != tComma || _redefinedProperties != redefinedProperties)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock4Alt3redefinedPropertiesBlock(tComma, redefinedProperties);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaOperationBlock1Green : GreenSyntaxNode
    {
        internal static new readonly MetaOperationBlock1Green __Missing = new MetaOperationBlock1Green();
        private __GreenNode _parameters;
    
        public MetaOperationBlock1Green(MetaSyntaxKind kind, __GreenNode parameters)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        public MetaOperationBlock1Green(MetaSyntaxKind kind, __GreenNode parameters, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (parameters != null)
            {
                AdjustFlagsAndWidth(parameters);
                _parameters = parameters;
            }
        }
    
        private MetaOperationBlock1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaOperationBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaParameterGreen> Parameters { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaParameterGreen>(_parameters, reversed: false); } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaOperationBlock1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _parameters;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaOperationBlock1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaOperationBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaOperationBlock1Green(this.Kind, _parameters, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaOperationBlock1Green(this.Kind, _parameters, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaOperationBlock1Green(this.Kind, _parameters, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaOperationBlock1Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaParameterGreen> parameters)
        {
            if (_parameters != parameters.Node)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaOperationBlock1(parameters);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaOperationBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class MetaOperationBlock1parametersBlockGreen : GreenSyntaxNode
    {
        internal static new readonly MetaOperationBlock1parametersBlockGreen __Missing = new MetaOperationBlock1parametersBlockGreen();
        private __InternalSyntaxToken _tComma;
        private MetaParameterGreen _parameters;
    
        public MetaOperationBlock1parametersBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, MetaParameterGreen parameters)
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
    
        public MetaOperationBlock1parametersBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, MetaParameterGreen parameters, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
    
        private MetaOperationBlock1parametersBlockGreen()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaOperationBlock1parametersBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TComma { get { return _tComma; } }
        public MetaParameterGreen Parameters { get { return _parameters; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaOperationBlock1parametersBlockSyntax(this, (MetaSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaOperationBlock1parametersBlockGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaOperationBlock1parametersBlockGreen(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaOperationBlock1parametersBlockGreen(this.Kind, _tComma, _parameters, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaOperationBlock1parametersBlockGreen(this.Kind, _tComma, _parameters, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaOperationBlock1parametersBlockGreen(this.Kind, _tComma, _parameters, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaOperationBlock1parametersBlockGreen Update(__InternalSyntaxToken tComma, MetaParameterGreen parameters)
        {
            if (_tComma != tComma || _parameters != parameters)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaOperationBlock1parametersBlock(tComma, parameters);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaOperationBlock1parametersBlockGreen)newNode;
            }
            return this;
        }
    }
    internal class MetaTypeReferenceBlock1Green : GreenSyntaxNode
    {
        internal static new readonly MetaTypeReferenceBlock1Green __Missing = new MetaTypeReferenceBlock1Green();
        private __InternalSyntaxToken _isNullable;
    
        public MetaTypeReferenceBlock1Green(MetaSyntaxKind kind, __InternalSyntaxToken isNullable)
            : base(kind, null, null)
        {
            SlotCount = 1;
            if (isNullable != null)
            {
                AdjustFlagsAndWidth(isNullable);
                _isNullable = isNullable;
            }
        }
    
        public MetaTypeReferenceBlock1Green(MetaSyntaxKind kind, __InternalSyntaxToken isNullable, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 1;
            if (isNullable != null)
            {
                AdjustFlagsAndWidth(isNullable);
                _isNullable = isNullable;
            }
        }
    
        private MetaTypeReferenceBlock1Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaTypeReferenceBlock1, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsNullable { get { return _isNullable; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaTypeReferenceBlock1Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isNullable;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaTypeReferenceBlock1Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaTypeReferenceBlock1Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaTypeReferenceBlock1Green(this.Kind, _isNullable, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaTypeReferenceBlock1Green(this.Kind, _isNullable, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaTypeReferenceBlock1Green(this.Kind, _isNullable, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaTypeReferenceBlock1Green Update(__InternalSyntaxToken isNullable)
        {
            if (_isNullable != isNullable)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaTypeReferenceBlock1(isNullable);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaTypeReferenceBlock1Green)newNode;
            }
            return this;
        }
    }
    internal class MetaTypeReferenceBlock2Green : GreenSyntaxNode
    {
        internal static new readonly MetaTypeReferenceBlock2Green __Missing = new MetaTypeReferenceBlock2Green();
        private __InternalSyntaxToken _isArray;
        private __InternalSyntaxToken _tRBracket;
    
        public MetaTypeReferenceBlock2Green(MetaSyntaxKind kind, __InternalSyntaxToken isArray, __InternalSyntaxToken tRBracket)
            : base(kind, null, null)
        {
            SlotCount = 2;
            if (isArray != null)
            {
                AdjustFlagsAndWidth(isArray);
                _isArray = isArray;
            }
            if (tRBracket != null)
            {
                AdjustFlagsAndWidth(tRBracket);
                _tRBracket = tRBracket;
            }
        }
    
        public MetaTypeReferenceBlock2Green(MetaSyntaxKind kind, __InternalSyntaxToken isArray, __InternalSyntaxToken tRBracket, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base(kind, diagnostics, annotations)
        {
            SlotCount = 2;
            if (isArray != null)
            {
                AdjustFlagsAndWidth(isArray);
                _isArray = isArray;
            }
            if (tRBracket != null)
            {
                AdjustFlagsAndWidth(tRBracket);
                _tRBracket = tRBracket;
            }
        }
    
        private MetaTypeReferenceBlock2Green()
            : base((MetaSyntaxKind)MetaSyntaxKind.MetaTypeReferenceBlock2, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken IsArray { get { return _isArray; } }
        public __InternalSyntaxToken TRBracket { get { return _tRBracket; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaTypeReferenceBlock2Syntax(this, (MetaSyntaxNode)parent, position);
        }
    
        protected override __GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return _isArray;
                case 1: return _tRBracket;
                default: return null;
            }
        }
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaTypeReferenceBlock2Green(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaTypeReferenceBlock2Green(this);
    
        public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
        {
            return new MetaTypeReferenceBlock2Green(this.Kind, _isArray, _tRBracket, diagnostics, this.GetAnnotations());
        }
    
        public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
        {
            return new MetaTypeReferenceBlock2Green(this.Kind, _isArray, _tRBracket, this.GetDiagnostics(), annotations);
        }
    
        public override __GreenNode Clone()
        {
            return new MetaTypeReferenceBlock2Green(this.Kind, _isArray, _tRBracket, this.GetDiagnostics(), this.GetAnnotations());
        }
    
    
        public MetaTypeReferenceBlock2Green Update(__InternalSyntaxToken isArray, __InternalSyntaxToken tRBracket)
        {
            if (_isArray != isArray || _tRBracket != tRBracket)
            {
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaTypeReferenceBlock2(isArray, tRBracket);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnostics(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotations(annotations);
                return (MetaTypeReferenceBlock2Green)newNode;
            }
            return this;
        }
    }
    internal class QualifierIdentifierBlockGreen : GreenSyntaxNode
    {
        internal static new readonly QualifierIdentifierBlockGreen __Missing = new QualifierIdentifierBlockGreen();
        private __InternalSyntaxToken _tDot;
        private IdentifierGreen _identifier;
    
        public QualifierIdentifierBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tDot, IdentifierGreen identifier)
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
    
        public QualifierIdentifierBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tDot, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
            : base((MetaSyntaxKind)MetaSyntaxKind.QualifierIdentifierBlock, null, null)
        {
            this.flags &= ~NodeFlags.IsNotMissing;
        }
    
        public __InternalSyntaxToken TDot { get { return _tDot; } }
        public IdentifierGreen Identifier { get { return _identifier; } }
    
        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
        {
            return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.QualifierIdentifierBlockSyntax(this, (MetaSyntaxNode)parent, position);
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
    
        public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierIdentifierBlockGreen(this);
    
        public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitQualifierIdentifierBlockGreen(this);
    
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
                __InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.QualifierIdentifierBlock(tDot, identifier);
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
