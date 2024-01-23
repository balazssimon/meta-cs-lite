#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax
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
		private QualifierGreen _name;
		private __InternalSyntaxToken _tSemicolon;
		private __GreenNode _usingList;
		private DeclarationsGreen _declarations;
		private __InternalSyntaxToken _endOfFileToken;
	
		public MainGreen(MetaSyntaxKind kind, __InternalSyntaxToken kNamespace, QualifierGreen name, __InternalSyntaxToken tSemicolon, __GreenNode usingList, DeclarationsGreen declarations, __InternalSyntaxToken endOfFileToken)
			: base(kind, null, null)
		{
			SlotCount = 6;
			if (kNamespace != null)
			{
				AdjustFlagsAndWidth(kNamespace);
				_kNamespace = kNamespace;
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
			if (usingList != null)
			{
				AdjustFlagsAndWidth(usingList);
				_usingList = usingList;
			}
			if (declarations != null)
			{
				AdjustFlagsAndWidth(declarations);
				_declarations = declarations;
			}
			if (endOfFileToken != null)
			{
				AdjustFlagsAndWidth(endOfFileToken);
				_endOfFileToken = endOfFileToken;
			}
		}
	
		public MainGreen(MetaSyntaxKind kind, __InternalSyntaxToken kNamespace, QualifierGreen name, __InternalSyntaxToken tSemicolon, __GreenNode usingList, DeclarationsGreen declarations, __InternalSyntaxToken endOfFileToken, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 6;
			if (kNamespace != null)
			{
				AdjustFlagsAndWidth(kNamespace);
				_kNamespace = kNamespace;
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
			if (usingList != null)
			{
				AdjustFlagsAndWidth(usingList);
				_usingList = usingList;
			}
			if (declarations != null)
			{
				AdjustFlagsAndWidth(declarations);
				_declarations = declarations;
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
		public QualifierGreen Name { get { return _name; } }
		public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> UsingList { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen>(_usingList); } }
		public DeclarationsGreen Declarations { get { return _declarations; } }
		public __InternalSyntaxToken EndOfFileToken { get { return _endOfFileToken; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MainSyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kNamespace;
				case 1: return _name;
				case 2: return _tSemicolon;
				case 3: return _usingList;
				case 4: return _declarations;
				case 5: return _endOfFileToken;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMainGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new MainGreen(this.Kind, _kNamespace, _name, _tSemicolon, _usingList, _declarations, _endOfFileToken, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new MainGreen(this.Kind, _kNamespace, _name, _tSemicolon, _usingList, _declarations, _endOfFileToken, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new MainGreen(this.Kind, _kNamespace, _name, _tSemicolon, _usingList, _declarations, _endOfFileToken, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MainGreen Update(__InternalSyntaxToken kNamespace, QualifierGreen name, __InternalSyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> usingList, DeclarationsGreen declarations, __InternalSyntaxToken endOfFileToken)
		{
			if (_kNamespace != kNamespace || _name != name || _tSemicolon != tSemicolon || _usingList != usingList.Node || _declarations != declarations || _endOfFileToken != endOfFileToken)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.Main(kNamespace, name, tSemicolon, usingList, declarations, endOfFileToken);
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
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.UsingSyntax(this, (MetaSyntaxNode)parent, position);
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
	
	
	internal class DeclarationsGreen : GreenSyntaxNode
	{
		internal static new readonly DeclarationsGreen __Missing = new DeclarationsGreen();
		private __GreenNode _declarations;
	
		public DeclarationsGreen(MetaSyntaxKind kind, __GreenNode declarations)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (declarations != null)
			{
				AdjustFlagsAndWidth(declarations);
				_declarations = declarations;
			}
		}
	
		public DeclarationsGreen(MetaSyntaxKind kind, __GreenNode declarations, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (declarations != null)
			{
				AdjustFlagsAndWidth(declarations);
				_declarations = declarations;
			}
		}
	
		private DeclarationsGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.Declarations, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen> Declarations { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen>(_declarations); } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.DeclarationsSyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _declarations;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitDeclarationsGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitDeclarationsGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new DeclarationsGreen(this.Kind, _declarations, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new DeclarationsGreen(this.Kind, _declarations, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new DeclarationsGreen(this.Kind, _declarations, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public DeclarationsGreen Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen> declarations)
		{
			if (_declarations != declarations.Node)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.Declarations(declarations);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (DeclarationsGreen)newNode;
			}
			return this;
		}
	}
	
	internal abstract class MetaDeclarationGreen : GreenSyntaxNode
	{
		internal static readonly MetaDeclarationGreen __Missing = MetaModelGreen.__Missing;
	
	    protected MetaDeclarationGreen(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class MetaModelGreen : MetaDeclarationGreen
	{
		internal static new readonly MetaModelGreen __Missing = new MetaModelGreen();
		private __InternalSyntaxToken _kMetamodel;
		private NameGreen _name;
		private __InternalSyntaxToken _tSemicolon;
	
		public MetaModelGreen(MetaSyntaxKind kind, __InternalSyntaxToken kMetamodel, NameGreen name, __InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 3;
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
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		public MetaModelGreen(MetaSyntaxKind kind, __InternalSyntaxToken kMetamodel, NameGreen name, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
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
		public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MetaModelSyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kMetamodel;
				case 1: return _name;
				case 2: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaModelGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaModelGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new MetaModelGreen(this.Kind, _kMetamodel, _name, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new MetaModelGreen(this.Kind, _kMetamodel, _name, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new MetaModelGreen(this.Kind, _kMetamodel, _name, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaModelGreen Update(__InternalSyntaxToken kMetamodel, NameGreen name, __InternalSyntaxToken tSemicolon)
		{
			if (_kMetamodel != kMetamodel || _name != name || _tSemicolon != tSemicolon)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaModel(kMetamodel, name, tSemicolon);
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
	
	internal class MetaConstantGreen : MetaDeclarationGreen
	{
		internal static new readonly MetaConstantGreen __Missing = new MetaConstantGreen();
		private __InternalSyntaxToken _kConst;
		private TypeReferenceGreen _type;
		private NameGreen _name;
		private __InternalSyntaxToken _tSemicolon;
	
		public MetaConstantGreen(MetaSyntaxKind kind, __InternalSyntaxToken kConst, TypeReferenceGreen type, NameGreen name, __InternalSyntaxToken tSemicolon)
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
	
		public MetaConstantGreen(MetaSyntaxKind kind, __InternalSyntaxToken kConst, TypeReferenceGreen type, NameGreen name, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
		public TypeReferenceGreen Type { get { return _type; } }
		public NameGreen Name { get { return _name; } }
		public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MetaConstantSyntax(this, (MetaSyntaxNode)parent, position);
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
	
	
		public MetaConstantGreen Update(__InternalSyntaxToken kConst, TypeReferenceGreen type, NameGreen name, __InternalSyntaxToken tSemicolon)
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
	
	internal class MetaEnumGreen : MetaDeclarationGreen
	{
		internal static new readonly MetaEnumGreen __Missing = new MetaEnumGreen();
		private __InternalSyntaxToken _kEnum;
		private NameGreen _name;
		private EnumBodyGreen _enumBody;
	
		public MetaEnumGreen(MetaSyntaxKind kind, __InternalSyntaxToken kEnum, NameGreen name, EnumBodyGreen enumBody)
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
			if (enumBody != null)
			{
				AdjustFlagsAndWidth(enumBody);
				_enumBody = enumBody;
			}
		}
	
		public MetaEnumGreen(MetaSyntaxKind kind, __InternalSyntaxToken kEnum, NameGreen name, EnumBodyGreen enumBody, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
			if (enumBody != null)
			{
				AdjustFlagsAndWidth(enumBody);
				_enumBody = enumBody;
			}
		}
	
		private MetaEnumGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.MetaEnum, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KEnum { get { return _kEnum; } }
		public NameGreen Name { get { return _name; } }
		public EnumBodyGreen EnumBody { get { return _enumBody; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MetaEnumSyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kEnum;
				case 1: return _name;
				case 2: return _enumBody;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaEnumGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaEnumGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new MetaEnumGreen(this.Kind, _kEnum, _name, _enumBody, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new MetaEnumGreen(this.Kind, _kEnum, _name, _enumBody, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new MetaEnumGreen(this.Kind, _kEnum, _name, _enumBody, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaEnumGreen Update(__InternalSyntaxToken kEnum, NameGreen name, EnumBodyGreen enumBody)
		{
			if (_kEnum != kEnum || _name != name || _enumBody != enumBody)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaEnum(kEnum, name, enumBody);
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
	
	internal class MetaClassGreen : MetaDeclarationGreen
	{
		internal static new readonly MetaClassGreen __Missing = new MetaClassGreen();
		private __InternalSyntaxToken _isAbstract;
		private __InternalSyntaxToken _kClass;
		private ClassNameGreen _className;
		private BaseClassesGreen _baseClasses;
		private ClassBodyGreen _classBody;
	
		public MetaClassGreen(MetaSyntaxKind kind, __InternalSyntaxToken isAbstract, __InternalSyntaxToken kClass, ClassNameGreen className, BaseClassesGreen baseClasses, ClassBodyGreen classBody)
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
			if (className != null)
			{
				AdjustFlagsAndWidth(className);
				_className = className;
			}
			if (baseClasses != null)
			{
				AdjustFlagsAndWidth(baseClasses);
				_baseClasses = baseClasses;
			}
			if (classBody != null)
			{
				AdjustFlagsAndWidth(classBody);
				_classBody = classBody;
			}
		}
	
		public MetaClassGreen(MetaSyntaxKind kind, __InternalSyntaxToken isAbstract, __InternalSyntaxToken kClass, ClassNameGreen className, BaseClassesGreen baseClasses, ClassBodyGreen classBody, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
			if (className != null)
			{
				AdjustFlagsAndWidth(className);
				_className = className;
			}
			if (baseClasses != null)
			{
				AdjustFlagsAndWidth(baseClasses);
				_baseClasses = baseClasses;
			}
			if (classBody != null)
			{
				AdjustFlagsAndWidth(classBody);
				_classBody = classBody;
			}
		}
	
		private MetaClassGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.MetaClass, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken IsAbstract { get { return _isAbstract; } }
		public __InternalSyntaxToken KClass { get { return _kClass; } }
		public ClassNameGreen ClassName { get { return _className; } }
		public BaseClassesGreen BaseClasses { get { return _baseClasses; } }
		public ClassBodyGreen ClassBody { get { return _classBody; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MetaClassSyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _isAbstract;
				case 1: return _kClass;
				case 2: return _className;
				case 3: return _baseClasses;
				case 4: return _classBody;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaClassGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaClassGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new MetaClassGreen(this.Kind, _isAbstract, _kClass, _className, _baseClasses, _classBody, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new MetaClassGreen(this.Kind, _isAbstract, _kClass, _className, _baseClasses, _classBody, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new MetaClassGreen(this.Kind, _isAbstract, _kClass, _className, _baseClasses, _classBody, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaClassGreen Update(__InternalSyntaxToken isAbstract, __InternalSyntaxToken kClass, ClassNameGreen className, BaseClassesGreen baseClasses, ClassBodyGreen classBody)
		{
			if (_isAbstract != isAbstract || _kClass != kClass || _className != className || _baseClasses != baseClasses || _classBody != classBody)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaClass(isAbstract, kClass, className, baseClasses, classBody);
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
	
	
	internal class EnumBodyGreen : GreenSyntaxNode
	{
		internal static new readonly EnumBodyGreen __Missing = new EnumBodyGreen();
		private __InternalSyntaxToken _tLBrace;
		private __GreenNode _enumLiterals;
		private __InternalSyntaxToken _tRBrace;
	
		public EnumBodyGreen(MetaSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode enumLiterals, __InternalSyntaxToken tRBrace)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (enumLiterals != null)
			{
				AdjustFlagsAndWidth(enumLiterals);
				_enumLiterals = enumLiterals;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		public EnumBodyGreen(MetaSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode enumLiterals, __InternalSyntaxToken tRBrace, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (enumLiterals != null)
			{
				AdjustFlagsAndWidth(enumLiterals);
				_enumLiterals = enumLiterals;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		private EnumBodyGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.EnumBody, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TLBrace { get { return _tLBrace; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen> EnumLiterals { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen>(_enumLiterals, reversed: false); } }
		public __InternalSyntaxToken TRBrace { get { return _tRBrace; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.EnumBodySyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLBrace;
				case 1: return _enumLiterals;
				case 2: return _tRBrace;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitEnumBodyGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitEnumBodyGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new EnumBodyGreen(this.Kind, _tLBrace, _enumLiterals, _tRBrace, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new EnumBodyGreen(this.Kind, _tLBrace, _enumLiterals, _tRBrace, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new EnumBodyGreen(this.Kind, _tLBrace, _enumLiterals, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public EnumBodyGreen Update(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen> enumLiterals, __InternalSyntaxToken tRBrace)
		{
			if (_tLBrace != tLBrace || _enumLiterals != enumLiterals.Node || _tRBrace != tRBrace)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.EnumBody(tLBrace, enumLiterals, tRBrace);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (EnumBodyGreen)newNode;
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
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MetaEnumLiteralSyntax(this, (MetaSyntaxNode)parent, position);
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
	
	internal abstract class ClassNameGreen : GreenSyntaxNode
	{
		internal static readonly ClassNameGreen __Missing = ClassNameAlt1Green.__Missing;
	
	    protected ClassNameGreen(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class ClassNameAlt1Green : ClassNameGreen
	{
		internal static new readonly ClassNameAlt1Green __Missing = new ClassNameAlt1Green();
		private IdentifierGreen _identifier;
		private __InternalSyntaxToken _tDollar;
		private IdentifierGreen _symbolType;
	
		public ClassNameAlt1Green(MetaSyntaxKind kind, IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolType)
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
	
		public ClassNameAlt1Green(MetaSyntaxKind kind, IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolType, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private ClassNameAlt1Green()
			: base((MetaSyntaxKind)MetaSyntaxKind.ClassNameAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Identifier { get { return _identifier; } }
		public __InternalSyntaxToken TDollar { get { return _tDollar; } }
		public IdentifierGreen SymbolType { get { return _symbolType; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.ClassNameAlt1Syntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitClassNameAlt1Green(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitClassNameAlt1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ClassNameAlt1Green(this.Kind, _identifier, _tDollar, _symbolType, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ClassNameAlt1Green(this.Kind, _identifier, _tDollar, _symbolType, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ClassNameAlt1Green(this.Kind, _identifier, _tDollar, _symbolType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ClassNameAlt1Green Update(IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolType)
		{
			if (_identifier != identifier || _tDollar != tDollar || _symbolType != symbolType)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.ClassNameAlt1(identifier, tDollar, symbolType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ClassNameAlt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class ClassNameAlt2Green : ClassNameGreen
	{
		internal static new readonly ClassNameAlt2Green __Missing = new ClassNameAlt2Green();
		private IdentifierGreen _identifier;
	
		public ClassNameAlt2Green(MetaSyntaxKind kind, IdentifierGreen identifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
		}
	
		public ClassNameAlt2Green(MetaSyntaxKind kind, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
		}
	
		private ClassNameAlt2Green()
			: base((MetaSyntaxKind)MetaSyntaxKind.ClassNameAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Identifier { get { return _identifier; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.ClassNameAlt2Syntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _identifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitClassNameAlt2Green(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitClassNameAlt2Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ClassNameAlt2Green(this.Kind, _identifier, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ClassNameAlt2Green(this.Kind, _identifier, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ClassNameAlt2Green(this.Kind, _identifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ClassNameAlt2Green Update(IdentifierGreen identifier)
		{
			if (_identifier != identifier)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.ClassNameAlt2(identifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ClassNameAlt2Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class BaseClassesGreen : GreenSyntaxNode
	{
		internal static new readonly BaseClassesGreen __Missing = new BaseClassesGreen();
		private __InternalSyntaxToken _tColon;
		private __GreenNode _baseTypes;
	
		public BaseClassesGreen(MetaSyntaxKind kind, __InternalSyntaxToken tColon, __GreenNode baseTypes)
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
	
		public BaseClassesGreen(MetaSyntaxKind kind, __InternalSyntaxToken tColon, __GreenNode baseTypes, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private BaseClassesGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.BaseClasses, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TColon { get { return _tColon; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> BaseTypes { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_baseTypes, reversed: false); } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.BaseClassesSyntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBaseClassesGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitBaseClassesGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new BaseClassesGreen(this.Kind, _tColon, _baseTypes, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new BaseClassesGreen(this.Kind, _tColon, _baseTypes, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new BaseClassesGreen(this.Kind, _tColon, _baseTypes, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public BaseClassesGreen Update(__InternalSyntaxToken tColon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> baseTypes)
		{
			if (_tColon != tColon || _baseTypes != baseTypes.Node)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.BaseClasses(tColon, baseTypes);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (BaseClassesGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class ClassBodyGreen : GreenSyntaxNode
	{
		internal static new readonly ClassBodyGreen __Missing = new ClassBodyGreen();
		private __InternalSyntaxToken _tLBrace;
		private __GreenNode _classMemberList;
		private __InternalSyntaxToken _tRBrace;
	
		public ClassBodyGreen(MetaSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode classMemberList, __InternalSyntaxToken tRBrace)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (classMemberList != null)
			{
				AdjustFlagsAndWidth(classMemberList);
				_classMemberList = classMemberList;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		public ClassBodyGreen(MetaSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode classMemberList, __InternalSyntaxToken tRBrace, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (classMemberList != null)
			{
				AdjustFlagsAndWidth(classMemberList);
				_classMemberList = classMemberList;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		private ClassBodyGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.ClassBody, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TLBrace { get { return _tLBrace; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ClassMemberGreen> ClassMemberList { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ClassMemberGreen>(_classMemberList); } }
		public __InternalSyntaxToken TRBrace { get { return _tRBrace; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.ClassBodySyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLBrace;
				case 1: return _classMemberList;
				case 2: return _tRBrace;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitClassBodyGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitClassBodyGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ClassBodyGreen(this.Kind, _tLBrace, _classMemberList, _tRBrace, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ClassBodyGreen(this.Kind, _tLBrace, _classMemberList, _tRBrace, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ClassBodyGreen(this.Kind, _tLBrace, _classMemberList, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ClassBodyGreen Update(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ClassMemberGreen> classMemberList, __InternalSyntaxToken tRBrace)
		{
			if (_tLBrace != tLBrace || _classMemberList != classMemberList.Node || _tRBrace != tRBrace)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.ClassBody(tLBrace, classMemberList, tRBrace);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ClassBodyGreen)newNode;
			}
			return this;
		}
	}
	
	internal abstract class ClassMemberGreen : GreenSyntaxNode
	{
		internal static readonly ClassMemberGreen __Missing = ClassMemberAlt1Green.__Missing;
	
	    protected ClassMemberGreen(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class ClassMemberAlt1Green : ClassMemberGreen
	{
		internal static new readonly ClassMemberAlt1Green __Missing = new ClassMemberAlt1Green();
		private MetaPropertyGreen _properties;
	
		public ClassMemberAlt1Green(MetaSyntaxKind kind, MetaPropertyGreen properties)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (properties != null)
			{
				AdjustFlagsAndWidth(properties);
				_properties = properties;
			}
		}
	
		public ClassMemberAlt1Green(MetaSyntaxKind kind, MetaPropertyGreen properties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (properties != null)
			{
				AdjustFlagsAndWidth(properties);
				_properties = properties;
			}
		}
	
		private ClassMemberAlt1Green()
			: base((MetaSyntaxKind)MetaSyntaxKind.ClassMemberAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaPropertyGreen Properties { get { return _properties; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.ClassMemberAlt1Syntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _properties;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitClassMemberAlt1Green(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitClassMemberAlt1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ClassMemberAlt1Green(this.Kind, _properties, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ClassMemberAlt1Green(this.Kind, _properties, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ClassMemberAlt1Green(this.Kind, _properties, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ClassMemberAlt1Green Update(MetaPropertyGreen properties)
		{
			if (_properties != properties)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.ClassMemberAlt1(properties);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ClassMemberAlt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class ClassMemberAlt2Green : ClassMemberGreen
	{
		internal static new readonly ClassMemberAlt2Green __Missing = new ClassMemberAlt2Green();
		private MetaOperationGreen _operations;
	
		public ClassMemberAlt2Green(MetaSyntaxKind kind, MetaOperationGreen operations)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (operations != null)
			{
				AdjustFlagsAndWidth(operations);
				_operations = operations;
			}
		}
	
		public ClassMemberAlt2Green(MetaSyntaxKind kind, MetaOperationGreen operations, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (operations != null)
			{
				AdjustFlagsAndWidth(operations);
				_operations = operations;
			}
		}
	
		private ClassMemberAlt2Green()
			: base((MetaSyntaxKind)MetaSyntaxKind.ClassMemberAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaOperationGreen Operations { get { return _operations; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.ClassMemberAlt2Syntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _operations;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitClassMemberAlt2Green(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitClassMemberAlt2Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ClassMemberAlt2Green(this.Kind, _operations, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ClassMemberAlt2Green(this.Kind, _operations, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ClassMemberAlt2Green(this.Kind, _operations, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ClassMemberAlt2Green Update(MetaOperationGreen operations)
		{
			if (_operations != operations)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.ClassMemberAlt2(operations);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ClassMemberAlt2Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class MetaPropertyGreen : GreenSyntaxNode
	{
		internal static new readonly MetaPropertyGreen __Missing = new MetaPropertyGreen();
		private __InternalSyntaxToken _tokens;
		private TypeReferenceGreen _type;
		private PropertyNameGreen _propertyName;
		private __GreenNode _block;
		private __InternalSyntaxToken _tSemicolon;
	
		public MetaPropertyGreen(MetaSyntaxKind kind, __InternalSyntaxToken tokens, TypeReferenceGreen type, PropertyNameGreen propertyName, __GreenNode block, __InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 5;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
			if (type != null)
			{
				AdjustFlagsAndWidth(type);
				_type = type;
			}
			if (propertyName != null)
			{
				AdjustFlagsAndWidth(propertyName);
				_propertyName = propertyName;
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
	
		public MetaPropertyGreen(MetaSyntaxKind kind, __InternalSyntaxToken tokens, TypeReferenceGreen type, PropertyNameGreen propertyName, __GreenNode block, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 5;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
			if (type != null)
			{
				AdjustFlagsAndWidth(type);
				_type = type;
			}
			if (propertyName != null)
			{
				AdjustFlagsAndWidth(propertyName);
				_propertyName = propertyName;
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
	
		private MetaPropertyGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.MetaProperty, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken Tokens { get { return _tokens; } }
		public TypeReferenceGreen Type { get { return _type; } }
		public PropertyNameGreen PropertyName { get { return _propertyName; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock1Green> Block { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock1Green>(_block); } }
		public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MetaPropertySyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tokens;
				case 1: return _type;
				case 2: return _propertyName;
				case 3: return _block;
				case 4: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new MetaPropertyGreen(this.Kind, _tokens, _type, _propertyName, _block, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new MetaPropertyGreen(this.Kind, _tokens, _type, _propertyName, _block, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new MetaPropertyGreen(this.Kind, _tokens, _type, _propertyName, _block, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaPropertyGreen Update(__InternalSyntaxToken tokens, TypeReferenceGreen type, PropertyNameGreen propertyName, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock1Green> block, __InternalSyntaxToken tSemicolon)
		{
			if (_tokens != tokens || _type != type || _propertyName != propertyName || _block != block.Node || _tSemicolon != tSemicolon)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaProperty(tokens, type, propertyName, block, tSemicolon);
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
	
	internal abstract class PropertyNameGreen : GreenSyntaxNode
	{
		internal static readonly PropertyNameGreen __Missing = PropertyNameAlt1Green.__Missing;
	
	    protected PropertyNameGreen(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class PropertyNameAlt1Green : PropertyNameGreen
	{
		internal static new readonly PropertyNameAlt1Green __Missing = new PropertyNameAlt1Green();
		private IdentifierGreen _identifier;
		private __InternalSyntaxToken _tDollar;
		private IdentifierGreen _symbolProperty;
	
		public PropertyNameAlt1Green(MetaSyntaxKind kind, IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolProperty)
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
	
		public PropertyNameAlt1Green(MetaSyntaxKind kind, IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolProperty, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private PropertyNameAlt1Green()
			: base((MetaSyntaxKind)MetaSyntaxKind.PropertyNameAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Identifier { get { return _identifier; } }
		public __InternalSyntaxToken TDollar { get { return _tDollar; } }
		public IdentifierGreen SymbolProperty { get { return _symbolProperty; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.PropertyNameAlt1Syntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyNameAlt1Green(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitPropertyNameAlt1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new PropertyNameAlt1Green(this.Kind, _identifier, _tDollar, _symbolProperty, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new PropertyNameAlt1Green(this.Kind, _identifier, _tDollar, _symbolProperty, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new PropertyNameAlt1Green(this.Kind, _identifier, _tDollar, _symbolProperty, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyNameAlt1Green Update(IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolProperty)
		{
			if (_identifier != identifier || _tDollar != tDollar || _symbolProperty != symbolProperty)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.PropertyNameAlt1(identifier, tDollar, symbolProperty);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PropertyNameAlt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class PropertyNameAlt2Green : PropertyNameGreen
	{
		internal static new readonly PropertyNameAlt2Green __Missing = new PropertyNameAlt2Green();
		private IdentifierGreen _identifier;
	
		public PropertyNameAlt2Green(MetaSyntaxKind kind, IdentifierGreen identifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
		}
	
		public PropertyNameAlt2Green(MetaSyntaxKind kind, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
		}
	
		private PropertyNameAlt2Green()
			: base((MetaSyntaxKind)MetaSyntaxKind.PropertyNameAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Identifier { get { return _identifier; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.PropertyNameAlt2Syntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _identifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyNameAlt2Green(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitPropertyNameAlt2Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new PropertyNameAlt2Green(this.Kind, _identifier, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new PropertyNameAlt2Green(this.Kind, _identifier, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new PropertyNameAlt2Green(this.Kind, _identifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyNameAlt2Green Update(IdentifierGreen identifier)
		{
			if (_identifier != identifier)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.PropertyNameAlt2(identifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PropertyNameAlt2Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class MetaOperationGreen : GreenSyntaxNode
	{
		internal static new readonly MetaOperationGreen __Missing = new MetaOperationGreen();
		private TypeReferenceGreen _returnType;
		private NameGreen _name;
		private __InternalSyntaxToken _tLParen;
		private __GreenNode _parameterList;
		private __InternalSyntaxToken _tRParen;
		private __InternalSyntaxToken _tSemicolon;
	
		public MetaOperationGreen(MetaSyntaxKind kind, TypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, __GreenNode parameterList, __InternalSyntaxToken tRParen, __InternalSyntaxToken tSemicolon)
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
			if (parameterList != null)
			{
				AdjustFlagsAndWidth(parameterList);
				_parameterList = parameterList;
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
	
		public MetaOperationGreen(MetaSyntaxKind kind, TypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, __GreenNode parameterList, __InternalSyntaxToken tRParen, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
			if (parameterList != null)
			{
				AdjustFlagsAndWidth(parameterList);
				_parameterList = parameterList;
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
	
		public TypeReferenceGreen ReturnType { get { return _returnType; } }
		public NameGreen Name { get { return _name; } }
		public __InternalSyntaxToken TLParen { get { return _tLParen; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaParameterGreen> ParameterList { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaParameterGreen>(_parameterList, reversed: false); } }
		public __InternalSyntaxToken TRParen { get { return _tRParen; } }
		public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MetaOperationSyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _returnType;
				case 1: return _name;
				case 2: return _tLParen;
				case 3: return _parameterList;
				case 4: return _tRParen;
				case 5: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaOperationGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaOperationGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new MetaOperationGreen(this.Kind, _returnType, _name, _tLParen, _parameterList, _tRParen, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new MetaOperationGreen(this.Kind, _returnType, _name, _tLParen, _parameterList, _tRParen, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new MetaOperationGreen(this.Kind, _returnType, _name, _tLParen, _parameterList, _tRParen, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaOperationGreen Update(TypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaParameterGreen> parameterList, __InternalSyntaxToken tRParen, __InternalSyntaxToken tSemicolon)
		{
			if (_returnType != returnType || _name != name || _tLParen != tLParen || _parameterList != parameterList.Node || _tRParen != tRParen || _tSemicolon != tSemicolon)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaOperation(returnType, name, tLParen, parameterList, tRParen, tSemicolon);
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
		private TypeReferenceGreen _type;
		private NameGreen _name;
	
		public MetaParameterGreen(MetaSyntaxKind kind, TypeReferenceGreen type, NameGreen name)
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
	
		public MetaParameterGreen(MetaSyntaxKind kind, TypeReferenceGreen type, NameGreen name, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		public TypeReferenceGreen Type { get { return _type; } }
		public NameGreen Name { get { return _name; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MetaParameterSyntax(this, (MetaSyntaxNode)parent, position);
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
	
	
		public MetaParameterGreen Update(TypeReferenceGreen type, NameGreen name)
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
	
	internal abstract class TypeReferenceGreen : GreenSyntaxNode
	{
		internal static readonly TypeReferenceGreen __Missing = TypeReferenceTokensGreen.__Missing;
	
	    protected TypeReferenceGreen(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class TypeReferenceTokensGreen : TypeReferenceGreen
	{
		internal static new readonly TypeReferenceTokensGreen __Missing = new TypeReferenceTokensGreen();
		private __InternalSyntaxToken _token;
	
		public TypeReferenceTokensGreen(MetaSyntaxKind kind, __InternalSyntaxToken token)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (token != null)
			{
				AdjustFlagsAndWidth(token);
				_token = token;
			}
		}
	
		public TypeReferenceTokensGreen(MetaSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (token != null)
			{
				AdjustFlagsAndWidth(token);
				_token = token;
			}
		}
	
		private TypeReferenceTokensGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.TypeReferenceTokens, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken Token { get { return _token; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.TypeReferenceTokensSyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _token;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceTokensGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceTokensGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new TypeReferenceTokensGreen(this.Kind, _token, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new TypeReferenceTokensGreen(this.Kind, _token, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new TypeReferenceTokensGreen(this.Kind, _token, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TypeReferenceTokensGreen Update(__InternalSyntaxToken token)
		{
			if (_token != token)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.TypeReferenceTokens(token);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TypeReferenceTokensGreen)newNode;
			}
			return this;
		}
	}
	
	internal class SimpleTypeReferenceAlt2Green : TypeReferenceGreen
	{
		internal static new readonly SimpleTypeReferenceAlt2Green __Missing = new SimpleTypeReferenceAlt2Green();
		private QualifierGreen _qualifier;
	
		public SimpleTypeReferenceAlt2Green(MetaSyntaxKind kind, QualifierGreen qualifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		public SimpleTypeReferenceAlt2Green(MetaSyntaxKind kind, QualifierGreen qualifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
			: base((MetaSyntaxKind)MetaSyntaxKind.SimpleTypeReferenceAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public QualifierGreen Qualifier { get { return _qualifier; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.SimpleTypeReferenceAlt2Syntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _qualifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSimpleTypeReferenceAlt2Green(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitSimpleTypeReferenceAlt2Green(this);
	
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
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.SimpleTypeReferenceAlt2(qualifier);
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
	
	internal class MetaArrayTypeGreen : TypeReferenceGreen
	{
		internal static new readonly MetaArrayTypeGreen __Missing = new MetaArrayTypeGreen();
		private TypeReferenceGreen _itemType;
		private __InternalSyntaxToken _tLBracket;
		private __InternalSyntaxToken _tRBracket;
	
		public MetaArrayTypeGreen(MetaSyntaxKind kind, TypeReferenceGreen itemType, __InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (itemType != null)
			{
				AdjustFlagsAndWidth(itemType);
				_itemType = itemType;
			}
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
	
		public MetaArrayTypeGreen(MetaSyntaxKind kind, TypeReferenceGreen itemType, __InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (itemType != null)
			{
				AdjustFlagsAndWidth(itemType);
				_itemType = itemType;
			}
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
	
		private MetaArrayTypeGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.MetaArrayType, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public TypeReferenceGreen ItemType { get { return _itemType; } }
		public __InternalSyntaxToken TLBracket { get { return _tLBracket; } }
		public __InternalSyntaxToken TRBracket { get { return _tRBracket; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MetaArrayTypeSyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _itemType;
				case 1: return _tLBracket;
				case 2: return _tRBracket;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaArrayTypeGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaArrayTypeGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new MetaArrayTypeGreen(this.Kind, _itemType, _tLBracket, _tRBracket, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new MetaArrayTypeGreen(this.Kind, _itemType, _tLBracket, _tRBracket, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new MetaArrayTypeGreen(this.Kind, _itemType, _tLBracket, _tRBracket, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaArrayTypeGreen Update(TypeReferenceGreen itemType, __InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket)
		{
			if (_itemType != itemType || _tLBracket != tLBracket || _tRBracket != tRBracket)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaArrayType(itemType, tLBracket, tRBracket);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (MetaArrayTypeGreen)newNode;
			}
			return this;
		}
	}
	
	internal class MetaNullableTypeGreen : TypeReferenceGreen
	{
		internal static new readonly MetaNullableTypeGreen __Missing = new MetaNullableTypeGreen();
		private TypeReferenceGreen _innerType;
		private __InternalSyntaxToken _tQuestion;
	
		public MetaNullableTypeGreen(MetaSyntaxKind kind, TypeReferenceGreen innerType, __InternalSyntaxToken tQuestion)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (innerType != null)
			{
				AdjustFlagsAndWidth(innerType);
				_innerType = innerType;
			}
			if (tQuestion != null)
			{
				AdjustFlagsAndWidth(tQuestion);
				_tQuestion = tQuestion;
			}
		}
	
		public MetaNullableTypeGreen(MetaSyntaxKind kind, TypeReferenceGreen innerType, __InternalSyntaxToken tQuestion, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (innerType != null)
			{
				AdjustFlagsAndWidth(innerType);
				_innerType = innerType;
			}
			if (tQuestion != null)
			{
				AdjustFlagsAndWidth(tQuestion);
				_tQuestion = tQuestion;
			}
		}
	
		private MetaNullableTypeGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.MetaNullableType, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public TypeReferenceGreen InnerType { get { return _innerType; } }
		public __InternalSyntaxToken TQuestion { get { return _tQuestion; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MetaNullableTypeSyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _innerType;
				case 1: return _tQuestion;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaNullableTypeGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaNullableTypeGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new MetaNullableTypeGreen(this.Kind, _innerType, _tQuestion, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new MetaNullableTypeGreen(this.Kind, _innerType, _tQuestion, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new MetaNullableTypeGreen(this.Kind, _innerType, _tQuestion, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaNullableTypeGreen Update(TypeReferenceGreen innerType, __InternalSyntaxToken tQuestion)
		{
			if (_innerType != innerType || _tQuestion != tQuestion)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaNullableType(innerType, tQuestion);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (MetaNullableTypeGreen)newNode;
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
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.NameSyntax(this, (MetaSyntaxNode)parent, position);
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
		private __GreenNode _qualifier;
	
		public QualifierGreen(MetaSyntaxKind kind, __GreenNode qualifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		public QualifierGreen(MetaSyntaxKind kind, __GreenNode qualifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		private QualifierGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.Qualifier, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> Qualifier { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_qualifier, reversed: false); } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.QualifierSyntax(this, (MetaSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _qualifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitQualifierGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new QualifierGreen(this.Kind, _qualifier, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new QualifierGreen(this.Kind, _qualifier, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new QualifierGreen(this.Kind, _qualifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public QualifierGreen Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier)
		{
			if (_qualifier != qualifier.Node)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.Qualifier(qualifier);
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
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.IdentifierSyntax(this, (MetaSyntaxNode)parent, position);
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
	
	
	internal class EnumBodyEnumLiteralsBlockGreen : GreenSyntaxNode
	{
		internal static new readonly EnumBodyEnumLiteralsBlockGreen __Missing = new EnumBodyEnumLiteralsBlockGreen();
		private __InternalSyntaxToken _tComma;
		private MetaEnumLiteralGreen _literals;
	
		public EnumBodyEnumLiteralsBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, MetaEnumLiteralGreen literals)
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
	
		public EnumBodyEnumLiteralsBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, MetaEnumLiteralGreen literals, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private EnumBodyEnumLiteralsBlockGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.EnumBodyEnumLiteralsBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TComma { get { return _tComma; } }
		public MetaEnumLiteralGreen Literals { get { return _literals; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.EnumBodyEnumLiteralsBlockSyntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitEnumBodyEnumLiteralsBlockGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitEnumBodyEnumLiteralsBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new EnumBodyEnumLiteralsBlockGreen(this.Kind, _tComma, _literals, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new EnumBodyEnumLiteralsBlockGreen(this.Kind, _tComma, _literals, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new EnumBodyEnumLiteralsBlockGreen(this.Kind, _tComma, _literals, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public EnumBodyEnumLiteralsBlockGreen Update(__InternalSyntaxToken tComma, MetaEnumLiteralGreen literals)
		{
			if (_tComma != tComma || _literals != literals)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.EnumBodyEnumLiteralsBlock(tComma, literals);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (EnumBodyEnumLiteralsBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class BaseClassesBaseTypesBlockGreen : GreenSyntaxNode
	{
		internal static new readonly BaseClassesBaseTypesBlockGreen __Missing = new BaseClassesBaseTypesBlockGreen();
		private __InternalSyntaxToken _tComma;
		private QualifierGreen _baseTypes;
	
		public BaseClassesBaseTypesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen baseTypes)
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
	
		public BaseClassesBaseTypesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen baseTypes, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private BaseClassesBaseTypesBlockGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.BaseClassesBaseTypesBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TComma { get { return _tComma; } }
		public QualifierGreen BaseTypes { get { return _baseTypes; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.BaseClassesBaseTypesBlockSyntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBaseClassesBaseTypesBlockGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitBaseClassesBaseTypesBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new BaseClassesBaseTypesBlockGreen(this.Kind, _tComma, _baseTypes, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new BaseClassesBaseTypesBlockGreen(this.Kind, _tComma, _baseTypes, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new BaseClassesBaseTypesBlockGreen(this.Kind, _tComma, _baseTypes, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public BaseClassesBaseTypesBlockGreen Update(__InternalSyntaxToken tComma, QualifierGreen baseTypes)
		{
			if (_tComma != tComma || _baseTypes != baseTypes)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.BaseClassesBaseTypesBlock(tComma, baseTypes);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (BaseClassesBaseTypesBlockGreen)newNode;
			}
			return this;
		}
	}
	
	internal abstract class MetaPropertyBlock1Green : GreenSyntaxNode
	{
		internal static readonly MetaPropertyBlock1Green __Missing = PropertyOppositeGreen.__Missing;
	
	    protected MetaPropertyBlock1Green(MetaSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class PropertyOppositeGreen : MetaPropertyBlock1Green
	{
		internal static new readonly PropertyOppositeGreen __Missing = new PropertyOppositeGreen();
		private __InternalSyntaxToken _kOpposite;
		private __GreenNode _oppositeProperties;
	
		public PropertyOppositeGreen(MetaSyntaxKind kind, __InternalSyntaxToken kOpposite, __GreenNode oppositeProperties)
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
	
		public PropertyOppositeGreen(MetaSyntaxKind kind, __InternalSyntaxToken kOpposite, __GreenNode oppositeProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private PropertyOppositeGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.PropertyOpposite, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KOpposite { get { return _kOpposite; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> OppositeProperties { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_oppositeProperties, reversed: false); } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.PropertyOppositeSyntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyOppositeGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitPropertyOppositeGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new PropertyOppositeGreen(this.Kind, _kOpposite, _oppositeProperties, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new PropertyOppositeGreen(this.Kind, _kOpposite, _oppositeProperties, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new PropertyOppositeGreen(this.Kind, _kOpposite, _oppositeProperties, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyOppositeGreen Update(__InternalSyntaxToken kOpposite, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> oppositeProperties)
		{
			if (_kOpposite != kOpposite || _oppositeProperties != oppositeProperties.Node)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.PropertyOpposite(kOpposite, oppositeProperties);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PropertyOppositeGreen)newNode;
			}
			return this;
		}
	}
	
	internal class PropertySubsetsGreen : MetaPropertyBlock1Green
	{
		internal static new readonly PropertySubsetsGreen __Missing = new PropertySubsetsGreen();
		private __InternalSyntaxToken _kSubsets;
		private __GreenNode _subsettedProperties;
	
		public PropertySubsetsGreen(MetaSyntaxKind kind, __InternalSyntaxToken kSubsets, __GreenNode subsettedProperties)
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
	
		public PropertySubsetsGreen(MetaSyntaxKind kind, __InternalSyntaxToken kSubsets, __GreenNode subsettedProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private PropertySubsetsGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.PropertySubsets, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KSubsets { get { return _kSubsets; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> SubsettedProperties { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_subsettedProperties, reversed: false); } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.PropertySubsetsSyntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertySubsetsGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitPropertySubsetsGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new PropertySubsetsGreen(this.Kind, _kSubsets, _subsettedProperties, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new PropertySubsetsGreen(this.Kind, _kSubsets, _subsettedProperties, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new PropertySubsetsGreen(this.Kind, _kSubsets, _subsettedProperties, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertySubsetsGreen Update(__InternalSyntaxToken kSubsets, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> subsettedProperties)
		{
			if (_kSubsets != kSubsets || _subsettedProperties != subsettedProperties.Node)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.PropertySubsets(kSubsets, subsettedProperties);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PropertySubsetsGreen)newNode;
			}
			return this;
		}
	}
	
	internal class PropertyRedefinesGreen : MetaPropertyBlock1Green
	{
		internal static new readonly PropertyRedefinesGreen __Missing = new PropertyRedefinesGreen();
		private __InternalSyntaxToken _kRedefines;
		private __GreenNode _redefinedProperties;
	
		public PropertyRedefinesGreen(MetaSyntaxKind kind, __InternalSyntaxToken kRedefines, __GreenNode redefinedProperties)
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
	
		public PropertyRedefinesGreen(MetaSyntaxKind kind, __InternalSyntaxToken kRedefines, __GreenNode redefinedProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private PropertyRedefinesGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.PropertyRedefines, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KRedefines { get { return _kRedefines; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> RedefinedProperties { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_redefinedProperties, reversed: false); } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.PropertyRedefinesSyntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyRedefinesGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitPropertyRedefinesGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new PropertyRedefinesGreen(this.Kind, _kRedefines, _redefinedProperties, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new PropertyRedefinesGreen(this.Kind, _kRedefines, _redefinedProperties, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new PropertyRedefinesGreen(this.Kind, _kRedefines, _redefinedProperties, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyRedefinesGreen Update(__InternalSyntaxToken kRedefines, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> redefinedProperties)
		{
			if (_kRedefines != kRedefines || _redefinedProperties != redefinedProperties.Node)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.PropertyRedefines(kRedefines, redefinedProperties);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PropertyRedefinesGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class PropertyOppositeOppositePropertiesBlockGreen : GreenSyntaxNode
	{
		internal static new readonly PropertyOppositeOppositePropertiesBlockGreen __Missing = new PropertyOppositeOppositePropertiesBlockGreen();
		private __InternalSyntaxToken _tComma;
		private QualifierGreen _oppositeProperties;
	
		public PropertyOppositeOppositePropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen oppositeProperties)
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
	
		public PropertyOppositeOppositePropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen oppositeProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private PropertyOppositeOppositePropertiesBlockGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.PropertyOppositeOppositePropertiesBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TComma { get { return _tComma; } }
		public QualifierGreen OppositeProperties { get { return _oppositeProperties; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.PropertyOppositeOppositePropertiesBlockSyntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyOppositeOppositePropertiesBlockGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitPropertyOppositeOppositePropertiesBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new PropertyOppositeOppositePropertiesBlockGreen(this.Kind, _tComma, _oppositeProperties, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new PropertyOppositeOppositePropertiesBlockGreen(this.Kind, _tComma, _oppositeProperties, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new PropertyOppositeOppositePropertiesBlockGreen(this.Kind, _tComma, _oppositeProperties, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyOppositeOppositePropertiesBlockGreen Update(__InternalSyntaxToken tComma, QualifierGreen oppositeProperties)
		{
			if (_tComma != tComma || _oppositeProperties != oppositeProperties)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.PropertyOppositeOppositePropertiesBlock(tComma, oppositeProperties);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PropertyOppositeOppositePropertiesBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class PropertySubsetsSubsettedPropertiesBlockGreen : GreenSyntaxNode
	{
		internal static new readonly PropertySubsetsSubsettedPropertiesBlockGreen __Missing = new PropertySubsetsSubsettedPropertiesBlockGreen();
		private __InternalSyntaxToken _tComma;
		private QualifierGreen _subsettedProperties;
	
		public PropertySubsetsSubsettedPropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen subsettedProperties)
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
	
		public PropertySubsetsSubsettedPropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen subsettedProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private PropertySubsetsSubsettedPropertiesBlockGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.PropertySubsetsSubsettedPropertiesBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TComma { get { return _tComma; } }
		public QualifierGreen SubsettedProperties { get { return _subsettedProperties; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.PropertySubsetsSubsettedPropertiesBlockSyntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertySubsetsSubsettedPropertiesBlockGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitPropertySubsetsSubsettedPropertiesBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new PropertySubsetsSubsettedPropertiesBlockGreen(this.Kind, _tComma, _subsettedProperties, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new PropertySubsetsSubsettedPropertiesBlockGreen(this.Kind, _tComma, _subsettedProperties, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new PropertySubsetsSubsettedPropertiesBlockGreen(this.Kind, _tComma, _subsettedProperties, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertySubsetsSubsettedPropertiesBlockGreen Update(__InternalSyntaxToken tComma, QualifierGreen subsettedProperties)
		{
			if (_tComma != tComma || _subsettedProperties != subsettedProperties)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.PropertySubsetsSubsettedPropertiesBlock(tComma, subsettedProperties);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PropertySubsetsSubsettedPropertiesBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class PropertyRedefinesRedefinedPropertiesBlockGreen : GreenSyntaxNode
	{
		internal static new readonly PropertyRedefinesRedefinedPropertiesBlockGreen __Missing = new PropertyRedefinesRedefinedPropertiesBlockGreen();
		private __InternalSyntaxToken _tComma;
		private QualifierGreen _redefinedProperties;
	
		public PropertyRedefinesRedefinedPropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen redefinedProperties)
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
	
		public PropertyRedefinesRedefinedPropertiesBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, QualifierGreen redefinedProperties, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private PropertyRedefinesRedefinedPropertiesBlockGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.PropertyRedefinesRedefinedPropertiesBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TComma { get { return _tComma; } }
		public QualifierGreen RedefinedProperties { get { return _redefinedProperties; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.PropertyRedefinesRedefinedPropertiesBlockSyntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyRedefinesRedefinedPropertiesBlockGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitPropertyRedefinesRedefinedPropertiesBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new PropertyRedefinesRedefinedPropertiesBlockGreen(this.Kind, _tComma, _redefinedProperties, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new PropertyRedefinesRedefinedPropertiesBlockGreen(this.Kind, _tComma, _redefinedProperties, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new PropertyRedefinesRedefinedPropertiesBlockGreen(this.Kind, _tComma, _redefinedProperties, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyRedefinesRedefinedPropertiesBlockGreen Update(__InternalSyntaxToken tComma, QualifierGreen redefinedProperties)
		{
			if (_tComma != tComma || _redefinedProperties != redefinedProperties)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.PropertyRedefinesRedefinedPropertiesBlock(tComma, redefinedProperties);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PropertyRedefinesRedefinedPropertiesBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class MetaOperationParameterListBlockGreen : GreenSyntaxNode
	{
		internal static new readonly MetaOperationParameterListBlockGreen __Missing = new MetaOperationParameterListBlockGreen();
		private __InternalSyntaxToken _tComma;
		private MetaParameterGreen _parameters;
	
		public MetaOperationParameterListBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, MetaParameterGreen parameters)
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
	
		public MetaOperationParameterListBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tComma, MetaParameterGreen parameters, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private MetaOperationParameterListBlockGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.MetaOperationParameterListBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TComma { get { return _tComma; } }
		public MetaParameterGreen Parameters { get { return _parameters; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.MetaOperationParameterListBlockSyntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaOperationParameterListBlockGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitMetaOperationParameterListBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new MetaOperationParameterListBlockGreen(this.Kind, _tComma, _parameters, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new MetaOperationParameterListBlockGreen(this.Kind, _tComma, _parameters, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new MetaOperationParameterListBlockGreen(this.Kind, _tComma, _parameters, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaOperationParameterListBlockGreen Update(__InternalSyntaxToken tComma, MetaParameterGreen parameters)
		{
			if (_tComma != tComma || _parameters != parameters)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.MetaOperationParameterListBlock(tComma, parameters);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (MetaOperationParameterListBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class QualifierQualifierBlockGreen : GreenSyntaxNode
	{
		internal static new readonly QualifierQualifierBlockGreen __Missing = new QualifierQualifierBlockGreen();
		private __InternalSyntaxToken _tDot;
		private IdentifierGreen _identifier;
	
		public QualifierQualifierBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tDot, IdentifierGreen identifier)
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
	
		public QualifierQualifierBlockGreen(MetaSyntaxKind kind, __InternalSyntaxToken tDot, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private QualifierQualifierBlockGreen()
			: base((MetaSyntaxKind)MetaSyntaxKind.QualifierQualifierBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TDot { get { return _tDot; } }
		public IdentifierGreen Identifier { get { return _identifier; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Languages.MetaModel.Compiler.Syntax.QualifierQualifierBlockSyntax(this, (MetaSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierQualifierBlockGreen(this);
	
		public override void Accept(MetaInternalSyntaxVisitor visitor) => visitor.VisitQualifierQualifierBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new QualifierQualifierBlockGreen(this.Kind, _tDot, _identifier, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new QualifierQualifierBlockGreen(this.Kind, _tDot, _identifier, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new QualifierQualifierBlockGreen(this.Kind, _tDot, _identifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public QualifierQualifierBlockGreen Update(__InternalSyntaxToken tDot, IdentifierGreen identifier)
		{
			if (_tDot != tDot || _identifier != identifier)
			{
				__InternalSyntaxNode newNode = MetaLanguage.Instance.InternalSyntaxFactory.QualifierQualifierBlock(tDot, identifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (QualifierQualifierBlockGreen)newNode;
			}
			return this;
		}
	}
	
}
