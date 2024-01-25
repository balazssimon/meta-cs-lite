#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax
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
        protected GreenSyntaxNode(CompilerSyntaxKind kind)
            : base((ushort)kind)
        {
        }

        protected GreenSyntaxNode(CompilerSyntaxKind kind, int fullWidth)
            : base((ushort)kind, fullWidth)
        {
        }

        protected GreenSyntaxNode(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics)
            : base((ushort)kind, diagnostics)
        {
        }

        protected GreenSyntaxNode(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, int fullWidth)
            : base((ushort)kind, diagnostics, fullWidth)
        {
        }

        protected GreenSyntaxNode(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
            : base((ushort)kind, diagnostics, annotations)
        {
        }

        protected GreenSyntaxNode(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations, int fullWidth)
            : base((ushort)kind, diagnostics, annotations, fullWidth)
        {
        }

        public override TResult Accept<TResult>(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult> visitor)
        {
            if (visitor is CompilerInternalSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public override void Accept(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor visitor) 
        {
            if (visitor is CompilerInternalSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor);
        public abstract void Accept(CompilerInternalSyntaxVisitor visitor);

        public override __Language Language => CompilerLanguage.Instance;
        public CompilerSyntaxKind Kind => (CompilerSyntaxKind)this.RawKind;
		public override string KindText => CompilerLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		// Use conditional weak table so we always return same identity for structured trivia
		private static readonly global::System.Runtime.CompilerServices.ConditionalWeakTable<__SyntaxNode, global::System.Collections.Generic.Dictionary<__SyntaxTrivia, __SyntaxNode>> s_structuresTable
			= new global::System.Runtime.CompilerServices.ConditionalWeakTable<__SyntaxNode, global::System.Collections.Generic.Dictionary<__SyntaxTrivia, __SyntaxNode>>();

		/// <summary>
		/// Gets the syntax node represented the structure of this trivia, if any. The HasStructure property can be used to 
		/// determine if this trivia has structure.
		/// </summary>
		/// <returns>
		/// A CompilerSyntaxNode derived from StructuredTriviaSyntax, with the structured view of this trivia node. 
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
							structure = CompilerStructuredTriviaSyntax.Create(trivia);
							structsInParent.Add(trivia, structure);
						}
					}

					return structure;
				}
				else
				{
					return CompilerStructuredTriviaSyntax.Create(trivia);
				}
			}

			return null;
		}

	}

    internal class GreenSyntaxTrivia : __InternalSyntaxTrivia
    {
        internal GreenSyntaxTrivia(CompilerSyntaxKind kind, string text, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
            : base((ushort)kind, text, diagnostics, annotations)
        {
        }

		public override __Language Language => CompilerLanguage.Instance;
		public CompilerSyntaxKind Kind => (CompilerSyntaxKind)this.RawKind;
		public override string KindText => CompilerLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		internal static GreenSyntaxTrivia Create(CompilerSyntaxKind kind, string text)
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
        internal GreenStructuredTriviaSyntax(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
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

        internal GreenSkippedTokensTriviaSyntax(CompilerSyntaxKind kind, __GreenNode tokens, __DiagnosticInfo[] diagnostics = null, __SyntaxAnnotation[] annotations = null)
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

        protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position) => new CompilerSkippedTokensTriviaSyntax(this, (CompilerSyntaxNode)parent, position);

        public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSkippedTokensTrivia(this);

        public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitSkippedTokensTrivia(this);

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
	    internal GreenSyntaxToken(CompilerSyntaxKind kind)
	        : base((ushort)kind)
	    {
	    }
	    internal GreenSyntaxToken(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics)
	        : base((ushort)kind, diagnostics)
	    {
	    }
	    internal GreenSyntaxToken(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base((ushort)kind, diagnostics, annotations)
	    {
	    }
	    internal GreenSyntaxToken(CompilerSyntaxKind kind, int fullWidth)
	        : base((ushort)kind, fullWidth)
	    {
	    }
	    internal GreenSyntaxToken(CompilerSyntaxKind kind, int fullWidth, __DiagnosticInfo[] diagnostics)
	        : base((ushort)kind, fullWidth, diagnostics)
	    {
	    }
	    internal GreenSyntaxToken(CompilerSyntaxKind kind, int fullWidth, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base((ushort)kind, fullWidth, diagnostics, annotations)
	    {
	    }

	    public override __Language Language => CompilerLanguage.Instance;
	    public CompilerSyntaxKind Kind => (CompilerSyntaxKind)this.RawKind;
		public override string KindText => CompilerLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		//====================
		internal static GreenSyntaxToken Create(CompilerSyntaxKind kind)
	    {
	        if (kind > LastTokenWithWellKnownText)
	        {
	            if (!CompilerLanguage.Instance.SyntaxFacts.IsToken(kind))
	            {
	                throw new __ArgumentNullException(string.Format("Invalid CompilerSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
	            }
	            return CreateMissing(kind, null, null);
	        }
	        return s_tokensWithNoTrivia[(int)kind].Value;
	    }
	    internal static GreenSyntaxToken Create(CompilerSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
	    {
	        if (kind > LastTokenWithWellKnownText)
	        {
	            if (!CompilerLanguage.Instance.SyntaxFacts.IsToken(kind))
	            {
	                throw new __ArgumentNullException(string.Format("Invalid CompilerSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
	            }
	            return CreateMissing(kind, leading, trailing);
	        }
	        if (leading == null)
	        {
	            if (trailing == null)
	            {
	                return s_tokensWithNoTrivia[(int)kind].Value;
	            }
	            else if (trailing == CompilerLanguage.Instance.InternalSyntaxFactory.Space)
	            {
	                return s_tokensWithSingleTrailingSpace[(int)kind].Value;
	            }
	            else if (trailing == CompilerLanguage.Instance.InternalSyntaxFactory.CarriageReturnLineFeed)
	            {
	                return s_tokensWithSingleTrailingCRLF[(int)kind].Value;
	            }
	        }
	        if (leading == CompilerLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace && trailing == CompilerLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace)
	        {
	            return s_tokensWithElasticTrivia[(int)kind].Value;
	        }
	        return new SyntaxTokenWithTrivia(kind, leading, trailing);
	    }
	    internal static GreenSyntaxToken CreateMissing(CompilerSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
	    {
	        return new MissingTokenWithTrivia(kind, leading, trailing);
	    }
	    internal static readonly CompilerSyntaxKind FirstTokenWithWellKnownText;
	    internal static readonly CompilerSyntaxKind LastTokenWithWellKnownText;
	    // TODO: eliminate the blank space before the first interesting element?
	    private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithNoTrivia;
	    private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithElasticTrivia;
	    private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingSpace;
	    private static readonly global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingCRLF;
	    static GreenSyntaxToken()
	    {
	        FirstTokenWithWellKnownText = CompilerSyntaxKind.__FirstFixedToken;
	        LastTokenWithWellKnownText = CompilerSyntaxKind.__LastFixedToken;
	        s_tokensWithNoTrivia = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithElasticTrivia = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithSingleTrailingSpace = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithSingleTrailingCRLF = new global::MetaDslx.CodeAnalysis.ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
			var factory = CompilerLanguage.Instance.InternalSyntaxFactory;
	        for (CompilerSyntaxKind kind = FirstTokenWithWellKnownText; kind <= LastTokenWithWellKnownText; kind++)
	        {
	            s_tokensWithNoTrivia[(int)kind].Value = new GreenSyntaxToken((CompilerSyntaxKind)kind);
	            s_tokensWithElasticTrivia[(int)kind].Value = new SyntaxTokenWithTrivia((CompilerSyntaxKind)kind, factory.ElasticZeroSpace, factory.ElasticZeroSpace);
	            s_tokensWithSingleTrailingSpace[(int)kind].Value = new SyntaxTokenWithTrivia((CompilerSyntaxKind)kind, null, factory.Space);
	            s_tokensWithSingleTrailingCRLF[(int)kind].Value = new SyntaxTokenWithTrivia((CompilerSyntaxKind)kind, null, factory.CarriageReturnLineFeed);
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
	    internal static GreenSyntaxToken Identifier(CompilerSyntaxKind kind, string text)
	    {
	        return new SyntaxIdentifier(kind, text);
	    }
	    internal static GreenSyntaxToken Identifier(CompilerSyntaxKind kind, __GreenNode leading, string text, __GreenNode trailing)
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
	    internal static GreenSyntaxToken Identifier(CompilerSyntaxKind kind, CompilerSyntaxKind contextualKind, __GreenNode leading, string text, string valueText, __GreenNode trailing)
	    {
	        if (contextualKind == kind && valueText == text)
	        {
	            return Identifier(kind, leading, text, trailing);
	        }
	        return new SyntaxIdentifierWithTrivia(kind, contextualKind, text, valueText, leading, trailing);
	    }
	    internal static GreenSyntaxToken WithValue<T>(CompilerSyntaxKind kind, string text, T value)
	    {
	        return new SyntaxTokenWithValue<T>(kind, text, value);
	    }
	    internal static GreenSyntaxToken WithValue<T>(CompilerSyntaxKind kind, __GreenNode? leading, string text, T value, __GreenNode? trailing)
	    {
	        return new SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing);
	    }
	    public new virtual CompilerSyntaxKind ContextualKind => this.Kind;
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
	        internal MissingTokenWithTrivia(CompilerSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
	            : base(kind, leading, trailing)
	        {
	            this.flags &= ~NodeFlags.IsNotMissing;
	        }
	        internal MissingTokenWithTrivia(CompilerSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	                if (CompilerLanguage.Instance.SyntaxFacts.IsIdentifier(this.Kind)) return string.Empty;
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
	        internal SyntaxIdentifier(CompilerSyntaxKind kind, string text)
	            : base(kind, text.Length)
	        {
	            this.TextField = text;
	        }
	        internal SyntaxIdentifier(CompilerSyntaxKind kind, string text, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	        protected readonly CompilerSyntaxKind contextualKind;
	        protected readonly string valueText;
	        internal SyntaxIdentifierExtended(CompilerSyntaxKind kind, CompilerSyntaxKind contextualKind, string text, string valueText)
	            : base(kind, text)
	        {
	            this.contextualKind = contextualKind;
	            this.valueText = valueText;
	        }
	        internal SyntaxIdentifierExtended(CompilerSyntaxKind kind, CompilerSyntaxKind contextualKind, string text, string valueText, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	            : base(kind, text, diagnostics, annotations)
	        {
	            this.contextualKind = contextualKind;
	            this.valueText = valueText;
	        }
	        public override CompilerSyntaxKind ContextualKind
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
	        internal SyntaxIdentifierWithTrailingTrivia(CompilerSyntaxKind kind, string text, __GreenNode? trailing)
	            : base(kind, text)
	        {
	            if (trailing != null)
	            {
	                this.AdjustFlagsAndWidth(trailing);
	                _trailing = trailing;
	            }
	        }
	        internal SyntaxIdentifierWithTrailingTrivia(CompilerSyntaxKind kind, string text, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	            CompilerSyntaxKind kind,
	            CompilerSyntaxKind contextualKind,
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
	            CompilerSyntaxKind kind,
	            CompilerSyntaxKind contextualKind,
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
	        internal SyntaxTokenWithValue(CompilerSyntaxKind kind, string text, T value)
	            : base(kind, text.Length)
	        {
	            this.TextField = text;
	            this.ValueField = value;
	        }
	        internal SyntaxTokenWithValue(CompilerSyntaxKind kind, string text, T value, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	        internal SyntaxTokenWithValueAndTrivia(CompilerSyntaxKind kind, string text, T value, __GreenNode? leading, __GreenNode? trailing)
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
	            CompilerSyntaxKind kind,
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
	        internal SyntaxTokenWithTrivia(CompilerSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing)
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
	        internal SyntaxTokenWithTrivia(CompilerSyntaxKind kind, __GreenNode? leading, __GreenNode? trailing, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
		private __GreenNode _qualifier;
		private __InternalSyntaxToken _tSemicolon;
		private __GreenNode _usingList;
		private MainBlock1Green _block;
		private __InternalSyntaxToken _endOfFileToken;
	
		public MainGreen(CompilerSyntaxKind kind, __InternalSyntaxToken kNamespace, __GreenNode qualifier, __InternalSyntaxToken tSemicolon, __GreenNode usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken)
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
	
		public MainGreen(CompilerSyntaxKind kind, __InternalSyntaxToken kNamespace, __GreenNode qualifier, __InternalSyntaxToken tSemicolon, __GreenNode usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Main, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KNamespace { get { return _kNamespace; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> Qualifier { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_qualifier, reversed: false); } }
		public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> UsingList { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen>(_usingList); } }
		public MainBlock1Green Block { get { return _block; } }
		public __InternalSyntaxToken EndOfFileToken { get { return _endOfFileToken; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.MainSyntax(this, (CompilerSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitMainGreen(this);
	
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
	
	
		public MainGreen Update(__InternalSyntaxToken kNamespace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier, __InternalSyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken)
		{
			if (_kNamespace != kNamespace || _qualifier != qualifier.Node || _tSemicolon != tSemicolon || _usingList != usingList.Node || _block != block || _endOfFileToken != endOfFileToken)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Main(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
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
		private __GreenNode _qualifier;
		private __InternalSyntaxToken _tSemicolon;
	
		public UsingGreen(CompilerSyntaxKind kind, __InternalSyntaxToken kUsing, __GreenNode qualifier, __InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (kUsing != null)
			{
				AdjustFlagsAndWidth(kUsing);
				_kUsing = kUsing;
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
		}
	
		public UsingGreen(CompilerSyntaxKind kind, __InternalSyntaxToken kUsing, __GreenNode qualifier, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (kUsing != null)
			{
				AdjustFlagsAndWidth(kUsing);
				_kUsing = kUsing;
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
		}
	
		private UsingGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Using, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KUsing { get { return _kUsing; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> Qualifier { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_qualifier, reversed: false); } }
		public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.UsingSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kUsing;
				case 1: return _qualifier;
				case 2: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitUsingGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitUsingGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new UsingGreen(this.Kind, _kUsing, _qualifier, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new UsingGreen(this.Kind, _kUsing, _qualifier, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new UsingGreen(this.Kind, _kUsing, _qualifier, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public UsingGreen Update(__InternalSyntaxToken kUsing, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier, __InternalSyntaxToken tSemicolon)
		{
			if (_kUsing != kUsing || _qualifier != qualifier.Node || _tSemicolon != tSemicolon)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Using(kUsing, qualifier, tSemicolon);
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
	
	
	internal class LanguageDeclarationGreen : GreenSyntaxNode
	{
		internal static new readonly LanguageDeclarationGreen __Missing = new LanguageDeclarationGreen();
		private __InternalSyntaxToken _kLanguage;
		private NameGreen _name;
		private __InternalSyntaxToken _tSemicolon;
		private GrammarGreen _grammar;
	
		public LanguageDeclarationGreen(CompilerSyntaxKind kind, __InternalSyntaxToken kLanguage, NameGreen name, __InternalSyntaxToken tSemicolon, GrammarGreen grammar)
			: base(kind, null, null)
		{
			SlotCount = 4;
			if (kLanguage != null)
			{
				AdjustFlagsAndWidth(kLanguage);
				_kLanguage = kLanguage;
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
			if (grammar != null)
			{
				AdjustFlagsAndWidth(grammar);
				_grammar = grammar;
			}
		}
	
		public LanguageDeclarationGreen(CompilerSyntaxKind kind, __InternalSyntaxToken kLanguage, NameGreen name, __InternalSyntaxToken tSemicolon, GrammarGreen grammar, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 4;
			if (kLanguage != null)
			{
				AdjustFlagsAndWidth(kLanguage);
				_kLanguage = kLanguage;
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
			if (grammar != null)
			{
				AdjustFlagsAndWidth(grammar);
				_grammar = grammar;
			}
		}
	
		private LanguageDeclarationGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LanguageDeclaration, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KLanguage { get { return _kLanguage; } }
		public NameGreen Name { get { return _name; } }
		public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
		public GrammarGreen Grammar { get { return _grammar; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LanguageDeclarationSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kLanguage;
				case 1: return _name;
				case 2: return _tSemicolon;
				case 3: return _grammar;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLanguageDeclarationGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLanguageDeclarationGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new LanguageDeclarationGreen(this.Kind, _kLanguage, _name, _tSemicolon, _grammar, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new LanguageDeclarationGreen(this.Kind, _kLanguage, _name, _tSemicolon, _grammar, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new LanguageDeclarationGreen(this.Kind, _kLanguage, _name, _tSemicolon, _grammar, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LanguageDeclarationGreen Update(__InternalSyntaxToken kLanguage, NameGreen name, __InternalSyntaxToken tSemicolon, GrammarGreen grammar)
		{
			if (_kLanguage != kLanguage || _name != name || _tSemicolon != tSemicolon || _grammar != grammar)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LanguageDeclaration(kLanguage, name, tSemicolon, grammar);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LanguageDeclarationGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class GrammarGreen : GreenSyntaxNode
	{
		internal static new readonly GrammarGreen __Missing = new GrammarGreen();
		private __GreenNode _grammarRules;
	
		public GrammarGreen(CompilerSyntaxKind kind, __GreenNode grammarRules)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (grammarRules != null)
			{
				AdjustFlagsAndWidth(grammarRules);
				_grammarRules = grammarRules;
			}
		}
	
		public GrammarGreen(CompilerSyntaxKind kind, __GreenNode grammarRules, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (grammarRules != null)
			{
				AdjustFlagsAndWidth(grammarRules);
				_grammarRules = grammarRules;
			}
		}
	
		private GrammarGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Grammar, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<GrammarRuleGreen> GrammarRules { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<GrammarRuleGreen>(_grammarRules); } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.GrammarSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _grammarRules;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitGrammarGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitGrammarGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new GrammarGreen(this.Kind, _grammarRules, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new GrammarGreen(this.Kind, _grammarRules, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new GrammarGreen(this.Kind, _grammarRules, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public GrammarGreen Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<GrammarRuleGreen> grammarRules)
		{
			if (_grammarRules != grammarRules.Node)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Grammar(grammarRules);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (GrammarGreen)newNode;
			}
			return this;
		}
	}
	
	internal abstract class GrammarRuleGreen : GreenSyntaxNode
	{
		internal static readonly GrammarRuleGreen __Missing = RuleGreen.__Missing;
	
	    protected GrammarRuleGreen(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class RuleGreen : GrammarRuleGreen
	{
		internal static new readonly RuleGreen __Missing = new RuleGreen();
		private __GreenNode _annotations1;
		private RuleBlock1Green _block;
		private __InternalSyntaxToken _tColon;
		private __GreenNode _alternatives;
		private __InternalSyntaxToken _tSemicolon;
	
		public RuleGreen(CompilerSyntaxKind kind, __GreenNode annotations1, RuleBlock1Green block, __InternalSyntaxToken tColon, __GreenNode alternatives, __InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (block != null)
			{
				AdjustFlagsAndWidth(block);
				_block = block;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		public RuleGreen(CompilerSyntaxKind kind, __GreenNode annotations1, RuleBlock1Green block, __InternalSyntaxToken tColon, __GreenNode alternatives, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (block != null)
			{
				AdjustFlagsAndWidth(block);
				_block = block;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		private RuleGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Rule, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> Annotations1 { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_annotations1); } }
		public RuleBlock1Green Block { get { return _block; } }
		public __InternalSyntaxToken TColon { get { return _tColon; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AlternativeGreen> Alternatives { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AlternativeGreen>(_alternatives, reversed: false); } }
		public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.RuleSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _block;
				case 2: return _tColon;
				case 3: return _alternatives;
				case 4: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitRuleGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitRuleGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new RuleGreen(this.Kind, _annotations1, _block, _tColon, _alternatives, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new RuleGreen(this.Kind, _annotations1, _block, _tColon, _alternatives, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new RuleGreen(this.Kind, _annotations1, _block, _tColon, _alternatives, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public RuleGreen Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, RuleBlock1Green block, __InternalSyntaxToken tColon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AlternativeGreen> alternatives, __InternalSyntaxToken tSemicolon)
		{
			if (_annotations1 != annotations1.Node || _block != block || _tColon != tColon || _alternatives != alternatives.Node || _tSemicolon != tSemicolon)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Rule(annotations1, block, tColon, alternatives, tSemicolon);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (RuleGreen)newNode;
			}
			return this;
		}
	}
	
	internal class TokenGreen : GrammarRuleGreen
	{
		internal static new readonly TokenGreen __Missing = new TokenGreen();
		private __GreenNode _annotations1;
		private TokenBlock1Green _block;
		private __InternalSyntaxToken _tColon;
		private __GreenNode _alternatives;
		private __InternalSyntaxToken _tSemicolon;
	
		public TokenGreen(CompilerSyntaxKind kind, __GreenNode annotations1, TokenBlock1Green block, __InternalSyntaxToken tColon, __GreenNode alternatives, __InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (block != null)
			{
				AdjustFlagsAndWidth(block);
				_block = block;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		public TokenGreen(CompilerSyntaxKind kind, __GreenNode annotations1, TokenBlock1Green block, __InternalSyntaxToken tColon, __GreenNode alternatives, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (block != null)
			{
				AdjustFlagsAndWidth(block);
				_block = block;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		private TokenGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Token, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LexerAnnotationGreen> Annotations1 { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LexerAnnotationGreen>(_annotations1); } }
		public TokenBlock1Green Block { get { return _block; } }
		public __InternalSyntaxToken TColon { get { return _tColon; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> Alternatives { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen>(_alternatives, reversed: false); } }
		public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.TokenSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _block;
				case 2: return _tColon;
				case 3: return _alternatives;
				case 4: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTokenGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitTokenGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new TokenGreen(this.Kind, _annotations1, _block, _tColon, _alternatives, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new TokenGreen(this.Kind, _annotations1, _block, _tColon, _alternatives, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new TokenGreen(this.Kind, _annotations1, _block, _tColon, _alternatives, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TokenGreen Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LexerAnnotationGreen> annotations1, TokenBlock1Green block, __InternalSyntaxToken tColon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> alternatives, __InternalSyntaxToken tSemicolon)
		{
			if (_annotations1 != annotations1.Node || _block != block || _tColon != tColon || _alternatives != alternatives.Node || _tSemicolon != tSemicolon)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Token(annotations1, block, tColon, alternatives, tSemicolon);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TokenGreen)newNode;
			}
			return this;
		}
	}
	
	internal class FragmentGreen : GrammarRuleGreen
	{
		internal static new readonly FragmentGreen __Missing = new FragmentGreen();
		private __InternalSyntaxToken _kFragment;
		private NameGreen _name;
		private __InternalSyntaxToken _tColon;
		private __GreenNode _alternatives;
		private __InternalSyntaxToken _tSemicolon;
	
		public FragmentGreen(CompilerSyntaxKind kind, __InternalSyntaxToken kFragment, NameGreen name, __InternalSyntaxToken tColon, __GreenNode alternatives, __InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 5;
			if (kFragment != null)
			{
				AdjustFlagsAndWidth(kFragment);
				_kFragment = kFragment;
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
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		public FragmentGreen(CompilerSyntaxKind kind, __InternalSyntaxToken kFragment, NameGreen name, __InternalSyntaxToken tColon, __GreenNode alternatives, __InternalSyntaxToken tSemicolon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 5;
			if (kFragment != null)
			{
				AdjustFlagsAndWidth(kFragment);
				_kFragment = kFragment;
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
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		private FragmentGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Fragment, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KFragment { get { return _kFragment; } }
		public NameGreen Name { get { return _name; } }
		public __InternalSyntaxToken TColon { get { return _tColon; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> Alternatives { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen>(_alternatives, reversed: false); } }
		public __InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.FragmentSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kFragment;
				case 1: return _name;
				case 2: return _tColon;
				case 3: return _alternatives;
				case 4: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitFragmentGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitFragmentGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new FragmentGreen(this.Kind, _kFragment, _name, _tColon, _alternatives, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new FragmentGreen(this.Kind, _kFragment, _name, _tColon, _alternatives, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new FragmentGreen(this.Kind, _kFragment, _name, _tColon, _alternatives, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public FragmentGreen Update(__InternalSyntaxToken kFragment, NameGreen name, __InternalSyntaxToken tColon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> alternatives, __InternalSyntaxToken tSemicolon)
		{
			if (_kFragment != kFragment || _name != name || _tColon != tColon || _alternatives != alternatives.Node || _tSemicolon != tSemicolon)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Fragment(kFragment, name, tColon, alternatives, tSemicolon);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (FragmentGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class AlternativeGreen : GreenSyntaxNode
	{
		internal static new readonly AlternativeGreen __Missing = new AlternativeGreen();
		private AlternativeBlock1Green _block1;
		private __GreenNode _elements;
		private AlternativeBlock2Green _block2;
	
		public AlternativeGreen(CompilerSyntaxKind kind, AlternativeBlock1Green block1, __GreenNode elements, AlternativeBlock2Green block2)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (block1 != null)
			{
				AdjustFlagsAndWidth(block1);
				_block1 = block1;
			}
			if (elements != null)
			{
				AdjustFlagsAndWidth(elements);
				_elements = elements;
			}
			if (block2 != null)
			{
				AdjustFlagsAndWidth(block2);
				_block2 = block2;
			}
		}
	
		public AlternativeGreen(CompilerSyntaxKind kind, AlternativeBlock1Green block1, __GreenNode elements, AlternativeBlock2Green block2, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (block1 != null)
			{
				AdjustFlagsAndWidth(block1);
				_block1 = block1;
			}
			if (elements != null)
			{
				AdjustFlagsAndWidth(elements);
				_elements = elements;
			}
			if (block2 != null)
			{
				AdjustFlagsAndWidth(block2);
				_block2 = block2;
			}
		}
	
		private AlternativeGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Alternative, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public AlternativeBlock1Green Block1 { get { return _block1; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ElementGreen> Elements { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ElementGreen>(_elements); } }
		public AlternativeBlock2Green Block2 { get { return _block2; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.AlternativeSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _block1;
				case 1: return _elements;
				case 2: return _block2;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitAlternativeGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitAlternativeGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new AlternativeGreen(this.Kind, _block1, _elements, _block2, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new AlternativeGreen(this.Kind, _block1, _elements, _block2, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new AlternativeGreen(this.Kind, _block1, _elements, _block2, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public AlternativeGreen Update(AlternativeBlock1Green block1, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ElementGreen> elements, AlternativeBlock2Green block2)
		{
			if (_block1 != block1 || _elements != elements.Node || _block2 != block2)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Alternative(block1, elements, block2);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (AlternativeGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class ElementGreen : GreenSyntaxNode
	{
		internal static new readonly ElementGreen __Missing = new ElementGreen();
		private ElementBlock1Green _block;
		private ElementValueGreen _value;
		private __InternalSyntaxToken _multiplicity;
	
		public ElementGreen(CompilerSyntaxKind kind, ElementBlock1Green block, ElementValueGreen value, __InternalSyntaxToken multiplicity)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (block != null)
			{
				AdjustFlagsAndWidth(block);
				_block = block;
			}
			if (value != null)
			{
				AdjustFlagsAndWidth(value);
				_value = value;
			}
			if (multiplicity != null)
			{
				AdjustFlagsAndWidth(multiplicity);
				_multiplicity = multiplicity;
			}
		}
	
		public ElementGreen(CompilerSyntaxKind kind, ElementBlock1Green block, ElementValueGreen value, __InternalSyntaxToken multiplicity, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (block != null)
			{
				AdjustFlagsAndWidth(block);
				_block = block;
			}
			if (value != null)
			{
				AdjustFlagsAndWidth(value);
				_value = value;
			}
			if (multiplicity != null)
			{
				AdjustFlagsAndWidth(multiplicity);
				_multiplicity = multiplicity;
			}
		}
	
		private ElementGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Element, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public ElementBlock1Green Block { get { return _block; } }
		public ElementValueGreen Value { get { return _value; } }
		public __InternalSyntaxToken Multiplicity { get { return _multiplicity; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ElementSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _block;
				case 1: return _value;
				case 2: return _multiplicity;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitElementGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitElementGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ElementGreen(this.Kind, _block, _value, _multiplicity, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ElementGreen(this.Kind, _block, _value, _multiplicity, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ElementGreen(this.Kind, _block, _value, _multiplicity, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ElementGreen Update(ElementBlock1Green block, ElementValueGreen value, __InternalSyntaxToken multiplicity)
		{
			if (_block != block || _value != value || _multiplicity != multiplicity)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Element(block, value, multiplicity);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ElementGreen)newNode;
			}
			return this;
		}
	}
	
	internal abstract class ElementValueGreen : GreenSyntaxNode
	{
		internal static readonly ElementValueGreen __Missing = BlockGreen.__Missing;
	
	    protected ElementValueGreen(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class BlockGreen : ElementValueGreen
	{
		internal static new readonly BlockGreen __Missing = new BlockGreen();
		private __GreenNode _annotations1;
		private __InternalSyntaxToken _tLParen;
		private __GreenNode _alternatives;
		private __InternalSyntaxToken _tRParen;
	
		public BlockGreen(CompilerSyntaxKind kind, __GreenNode annotations1, __InternalSyntaxToken tLParen, __GreenNode alternatives, __InternalSyntaxToken tRParen)
			: base(kind, null, null)
		{
			SlotCount = 4;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
		}
	
		public BlockGreen(CompilerSyntaxKind kind, __GreenNode annotations1, __InternalSyntaxToken tLParen, __GreenNode alternatives, __InternalSyntaxToken tRParen, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 4;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
		}
	
		private BlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Block, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> Annotations1 { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_annotations1); } }
		public __InternalSyntaxToken TLParen { get { return _tLParen; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<BlockAlternativeGreen> Alternatives { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<BlockAlternativeGreen>(_alternatives, reversed: false); } }
		public __InternalSyntaxToken TRParen { get { return _tRParen; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.BlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _tLParen;
				case 2: return _alternatives;
				case 3: return _tRParen;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new BlockGreen(this.Kind, _annotations1, _tLParen, _alternatives, _tRParen, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new BlockGreen(this.Kind, _annotations1, _tLParen, _alternatives, _tRParen, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new BlockGreen(this.Kind, _annotations1, _tLParen, _alternatives, _tRParen, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public BlockGreen Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, __InternalSyntaxToken tLParen, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<BlockAlternativeGreen> alternatives, __InternalSyntaxToken tRParen)
		{
			if (_annotations1 != annotations1.Node || _tLParen != tLParen || _alternatives != alternatives.Node || _tRParen != tRParen)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Block(annotations1, tLParen, alternatives, tRParen);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (BlockGreen)newNode;
			}
			return this;
		}
	}
	
	internal class Eof1Green : ElementValueGreen
	{
		internal static new readonly Eof1Green __Missing = new Eof1Green();
		private __InternalSyntaxToken _kEof;
	
		public Eof1Green(CompilerSyntaxKind kind, __InternalSyntaxToken kEof)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (kEof != null)
			{
				AdjustFlagsAndWidth(kEof);
				_kEof = kEof;
			}
		}
	
		public Eof1Green(CompilerSyntaxKind kind, __InternalSyntaxToken kEof, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (kEof != null)
			{
				AdjustFlagsAndWidth(kEof);
				_kEof = kEof;
			}
		}
	
		private Eof1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Eof1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KEof { get { return _kEof; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.Eof1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kEof;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitEof1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitEof1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new Eof1Green(this.Kind, _kEof, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new Eof1Green(this.Kind, _kEof, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new Eof1Green(this.Kind, _kEof, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public Eof1Green Update(__InternalSyntaxToken kEof)
		{
			if (_kEof != kEof)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Eof1(kEof);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (Eof1Green)newNode;
			}
			return this;
		}
	}
	
	internal class FixedGreen : ElementValueGreen
	{
		internal static new readonly FixedGreen __Missing = new FixedGreen();
		private __GreenNode _annotations1;
		private __InternalSyntaxToken _text;
	
		public FixedGreen(CompilerSyntaxKind kind, __GreenNode annotations1, __InternalSyntaxToken text)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (text != null)
			{
				AdjustFlagsAndWidth(text);
				_text = text;
			}
		}
	
		public FixedGreen(CompilerSyntaxKind kind, __GreenNode annotations1, __InternalSyntaxToken text, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (text != null)
			{
				AdjustFlagsAndWidth(text);
				_text = text;
			}
		}
	
		private FixedGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Fixed, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> Annotations1 { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_annotations1); } }
		public __InternalSyntaxToken Text { get { return _text; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.FixedSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _text;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitFixedGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitFixedGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new FixedGreen(this.Kind, _annotations1, _text, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new FixedGreen(this.Kind, _annotations1, _text, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new FixedGreen(this.Kind, _annotations1, _text, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public FixedGreen Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, __InternalSyntaxToken text)
		{
			if (_annotations1 != annotations1.Node || _text != text)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Fixed(annotations1, text);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (FixedGreen)newNode;
			}
			return this;
		}
	}
	
	internal class RuleRefAlt1Green : ElementValueGreen
	{
		internal static new readonly RuleRefAlt1Green __Missing = new RuleRefAlt1Green();
		private __GreenNode _annotations1;
		private IdentifierGreen _grammarRule;
	
		public RuleRefAlt1Green(CompilerSyntaxKind kind, __GreenNode annotations1, IdentifierGreen grammarRule)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (grammarRule != null)
			{
				AdjustFlagsAndWidth(grammarRule);
				_grammarRule = grammarRule;
			}
		}
	
		public RuleRefAlt1Green(CompilerSyntaxKind kind, __GreenNode annotations1, IdentifierGreen grammarRule, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (grammarRule != null)
			{
				AdjustFlagsAndWidth(grammarRule);
				_grammarRule = grammarRule;
			}
		}
	
		private RuleRefAlt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> Annotations1 { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_annotations1); } }
		public IdentifierGreen GrammarRule { get { return _grammarRule; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.RuleRefAlt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _grammarRule;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitRuleRefAlt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitRuleRefAlt1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new RuleRefAlt1Green(this.Kind, _annotations1, _grammarRule, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new RuleRefAlt1Green(this.Kind, _annotations1, _grammarRule, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new RuleRefAlt1Green(this.Kind, _annotations1, _grammarRule, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public RuleRefAlt1Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, IdentifierGreen grammarRule)
		{
			if (_annotations1 != annotations1.Node || _grammarRule != grammarRule)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt1(annotations1, grammarRule);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (RuleRefAlt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class RuleRefAlt2Green : ElementValueGreen
	{
		internal static new readonly RuleRefAlt2Green __Missing = new RuleRefAlt2Green();
		private __GreenNode _annotations1;
		private __InternalSyntaxToken _tHash;
		private TypeReferenceGreen _referencedTypes;
	
		public RuleRefAlt2Green(CompilerSyntaxKind kind, __GreenNode annotations1, __InternalSyntaxToken tHash, TypeReferenceGreen referencedTypes)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (tHash != null)
			{
				AdjustFlagsAndWidth(tHash);
				_tHash = tHash;
			}
			if (referencedTypes != null)
			{
				AdjustFlagsAndWidth(referencedTypes);
				_referencedTypes = referencedTypes;
			}
		}
	
		public RuleRefAlt2Green(CompilerSyntaxKind kind, __GreenNode annotations1, __InternalSyntaxToken tHash, TypeReferenceGreen referencedTypes, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (tHash != null)
			{
				AdjustFlagsAndWidth(tHash);
				_tHash = tHash;
			}
			if (referencedTypes != null)
			{
				AdjustFlagsAndWidth(referencedTypes);
				_referencedTypes = referencedTypes;
			}
		}
	
		private RuleRefAlt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> Annotations1 { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_annotations1); } }
		public __InternalSyntaxToken THash { get { return _tHash; } }
		public TypeReferenceGreen ReferencedTypes { get { return _referencedTypes; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.RuleRefAlt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _tHash;
				case 2: return _referencedTypes;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitRuleRefAlt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitRuleRefAlt2Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new RuleRefAlt2Green(this.Kind, _annotations1, _tHash, _referencedTypes, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new RuleRefAlt2Green(this.Kind, _annotations1, _tHash, _referencedTypes, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new RuleRefAlt2Green(this.Kind, _annotations1, _tHash, _referencedTypes, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public RuleRefAlt2Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, __InternalSyntaxToken tHash, TypeReferenceGreen referencedTypes)
		{
			if (_annotations1 != annotations1.Node || _tHash != tHash || _referencedTypes != referencedTypes)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt2(annotations1, tHash, referencedTypes);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (RuleRefAlt2Green)newNode;
			}
			return this;
		}
	}
	
	internal class RuleRefAlt3Green : ElementValueGreen
	{
		internal static new readonly RuleRefAlt3Green __Missing = new RuleRefAlt3Green();
		private __GreenNode _annotations1;
		private __InternalSyntaxToken _tHashLBrace;
		private __GreenNode _referencedTypes;
		private RuleRefAlt3Block1Green _block;
		private __InternalSyntaxToken _tRBrace;
	
		public RuleRefAlt3Green(CompilerSyntaxKind kind, __GreenNode annotations1, __InternalSyntaxToken tHashLBrace, __GreenNode referencedTypes, RuleRefAlt3Block1Green block, __InternalSyntaxToken tRBrace)
			: base(kind, null, null)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (tHashLBrace != null)
			{
				AdjustFlagsAndWidth(tHashLBrace);
				_tHashLBrace = tHashLBrace;
			}
			if (referencedTypes != null)
			{
				AdjustFlagsAndWidth(referencedTypes);
				_referencedTypes = referencedTypes;
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
	
		public RuleRefAlt3Green(CompilerSyntaxKind kind, __GreenNode annotations1, __InternalSyntaxToken tHashLBrace, __GreenNode referencedTypes, RuleRefAlt3Block1Green block, __InternalSyntaxToken tRBrace, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (tHashLBrace != null)
			{
				AdjustFlagsAndWidth(tHashLBrace);
				_tHashLBrace = tHashLBrace;
			}
			if (referencedTypes != null)
			{
				AdjustFlagsAndWidth(referencedTypes);
				_referencedTypes = referencedTypes;
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
	
		private RuleRefAlt3Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt3, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> Annotations1 { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_annotations1); } }
		public __InternalSyntaxToken THashLBrace { get { return _tHashLBrace; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TypeReferenceGreen> ReferencedTypes { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TypeReferenceGreen>(_referencedTypes, reversed: false); } }
		public RuleRefAlt3Block1Green Block { get { return _block; } }
		public __InternalSyntaxToken TRBrace { get { return _tRBrace; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.RuleRefAlt3Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _tHashLBrace;
				case 2: return _referencedTypes;
				case 3: return _block;
				case 4: return _tRBrace;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitRuleRefAlt3Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitRuleRefAlt3Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new RuleRefAlt3Green(this.Kind, _annotations1, _tHashLBrace, _referencedTypes, _block, _tRBrace, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new RuleRefAlt3Green(this.Kind, _annotations1, _tHashLBrace, _referencedTypes, _block, _tRBrace, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new RuleRefAlt3Green(this.Kind, _annotations1, _tHashLBrace, _referencedTypes, _block, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public RuleRefAlt3Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, __InternalSyntaxToken tHashLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TypeReferenceGreen> referencedTypes, RuleRefAlt3Block1Green block, __InternalSyntaxToken tRBrace)
		{
			if (_annotations1 != annotations1.Node || _tHashLBrace != tHashLBrace || _referencedTypes != referencedTypes.Node || _block != block || _tRBrace != tRBrace)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3(annotations1, tHashLBrace, referencedTypes, block, tRBrace);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (RuleRefAlt3Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class BlockAlternativeGreen : GreenSyntaxNode
	{
		internal static new readonly BlockAlternativeGreen __Missing = new BlockAlternativeGreen();
		private __GreenNode _elements;
		private BlockAlternativeBlock1Green _block;
	
		public BlockAlternativeGreen(CompilerSyntaxKind kind, __GreenNode elements, BlockAlternativeBlock1Green block)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (elements != null)
			{
				AdjustFlagsAndWidth(elements);
				_elements = elements;
			}
			if (block != null)
			{
				AdjustFlagsAndWidth(block);
				_block = block;
			}
		}
	
		public BlockAlternativeGreen(CompilerSyntaxKind kind, __GreenNode elements, BlockAlternativeBlock1Green block, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (elements != null)
			{
				AdjustFlagsAndWidth(elements);
				_elements = elements;
			}
			if (block != null)
			{
				AdjustFlagsAndWidth(block);
				_block = block;
			}
		}
	
		private BlockAlternativeGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.BlockAlternative, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ElementGreen> Elements { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ElementGreen>(_elements); } }
		public BlockAlternativeBlock1Green Block { get { return _block; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.BlockAlternativeSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _elements;
				case 1: return _block;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBlockAlternativeGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitBlockAlternativeGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new BlockAlternativeGreen(this.Kind, _elements, _block, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new BlockAlternativeGreen(this.Kind, _elements, _block, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new BlockAlternativeGreen(this.Kind, _elements, _block, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public BlockAlternativeGreen Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ElementGreen> elements, BlockAlternativeBlock1Green block)
		{
			if (_elements != elements.Node || _block != block)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.BlockAlternative(elements, block);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (BlockAlternativeGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class LAlternativeGreen : GreenSyntaxNode
	{
		internal static new readonly LAlternativeGreen __Missing = new LAlternativeGreen();
		private __GreenNode _elements;
	
		public LAlternativeGreen(CompilerSyntaxKind kind, __GreenNode elements)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (elements != null)
			{
				AdjustFlagsAndWidth(elements);
				_elements = elements;
			}
		}
	
		public LAlternativeGreen(CompilerSyntaxKind kind, __GreenNode elements, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (elements != null)
			{
				AdjustFlagsAndWidth(elements);
				_elements = elements;
			}
		}
	
		private LAlternativeGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LAlternative, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LElementGreen> Elements { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LElementGreen>(_elements); } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LAlternativeSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _elements;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLAlternativeGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLAlternativeGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new LAlternativeGreen(this.Kind, _elements, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new LAlternativeGreen(this.Kind, _elements, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new LAlternativeGreen(this.Kind, _elements, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LAlternativeGreen Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LElementGreen> elements)
		{
			if (_elements != elements.Node)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LAlternative(elements);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LAlternativeGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class LElementGreen : GreenSyntaxNode
	{
		internal static new readonly LElementGreen __Missing = new LElementGreen();
		private __InternalSyntaxToken _isNegated;
		private LElementValueGreen _value;
		private __InternalSyntaxToken _multiplicity;
	
		public LElementGreen(CompilerSyntaxKind kind, __InternalSyntaxToken isNegated, LElementValueGreen value, __InternalSyntaxToken multiplicity)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (isNegated != null)
			{
				AdjustFlagsAndWidth(isNegated);
				_isNegated = isNegated;
			}
			if (value != null)
			{
				AdjustFlagsAndWidth(value);
				_value = value;
			}
			if (multiplicity != null)
			{
				AdjustFlagsAndWidth(multiplicity);
				_multiplicity = multiplicity;
			}
		}
	
		public LElementGreen(CompilerSyntaxKind kind, __InternalSyntaxToken isNegated, LElementValueGreen value, __InternalSyntaxToken multiplicity, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (isNegated != null)
			{
				AdjustFlagsAndWidth(isNegated);
				_isNegated = isNegated;
			}
			if (value != null)
			{
				AdjustFlagsAndWidth(value);
				_value = value;
			}
			if (multiplicity != null)
			{
				AdjustFlagsAndWidth(multiplicity);
				_multiplicity = multiplicity;
			}
		}
	
		private LElementGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LElement, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken IsNegated { get { return _isNegated; } }
		public LElementValueGreen Value { get { return _value; } }
		public __InternalSyntaxToken Multiplicity { get { return _multiplicity; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LElementSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _isNegated;
				case 1: return _value;
				case 2: return _multiplicity;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLElementGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLElementGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new LElementGreen(this.Kind, _isNegated, _value, _multiplicity, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new LElementGreen(this.Kind, _isNegated, _value, _multiplicity, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new LElementGreen(this.Kind, _isNegated, _value, _multiplicity, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LElementGreen Update(__InternalSyntaxToken isNegated, LElementValueGreen value, __InternalSyntaxToken multiplicity)
		{
			if (_isNegated != isNegated || _value != value || _multiplicity != multiplicity)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LElement(isNegated, value, multiplicity);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LElementGreen)newNode;
			}
			return this;
		}
	}
	
	internal abstract class LElementValueGreen : GreenSyntaxNode
	{
		internal static readonly LElementValueGreen __Missing = LElementValueTokensGreen.__Missing;
	
	    protected LElementValueGreen(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class LElementValueTokensGreen : LElementValueGreen
	{
		internal static new readonly LElementValueTokensGreen __Missing = new LElementValueTokensGreen();
		private __InternalSyntaxToken _token;
	
		public LElementValueTokensGreen(CompilerSyntaxKind kind, __InternalSyntaxToken token)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (token != null)
			{
				AdjustFlagsAndWidth(token);
				_token = token;
			}
		}
	
		public LElementValueTokensGreen(CompilerSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (token != null)
			{
				AdjustFlagsAndWidth(token);
				_token = token;
			}
		}
	
		private LElementValueTokensGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LElementValueTokens, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken Token { get { return _token; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LElementValueTokensSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _token;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLElementValueTokensGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLElementValueTokensGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new LElementValueTokensGreen(this.Kind, _token, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new LElementValueTokensGreen(this.Kind, _token, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new LElementValueTokensGreen(this.Kind, _token, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LElementValueTokensGreen Update(__InternalSyntaxToken token)
		{
			if (_token != token)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LElementValueTokens(token);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LElementValueTokensGreen)newNode;
			}
			return this;
		}
	}
	
	internal class LBlockGreen : LElementValueGreen
	{
		internal static new readonly LBlockGreen __Missing = new LBlockGreen();
		private __InternalSyntaxToken _tLParen;
		private __GreenNode _alternatives;
		private __InternalSyntaxToken _tRParen;
	
		public LBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tLParen, __GreenNode alternatives, __InternalSyntaxToken tRParen)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
		}
	
		public LBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tLParen, __GreenNode alternatives, __InternalSyntaxToken tRParen, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
		}
	
		private LBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TLParen { get { return _tLParen; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> Alternatives { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen>(_alternatives, reversed: false); } }
		public __InternalSyntaxToken TRParen { get { return _tRParen; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLParen;
				case 1: return _alternatives;
				case 2: return _tRParen;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new LBlockGreen(this.Kind, _tLParen, _alternatives, _tRParen, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new LBlockGreen(this.Kind, _tLParen, _alternatives, _tRParen, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new LBlockGreen(this.Kind, _tLParen, _alternatives, _tRParen, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LBlockGreen Update(__InternalSyntaxToken tLParen, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> alternatives, __InternalSyntaxToken tRParen)
		{
			if (_tLParen != tLParen || _alternatives != alternatives.Node || _tRParen != tRParen)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LBlock(tLParen, alternatives, tRParen);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LBlockGreen)newNode;
			}
			return this;
		}
	}
	
	internal class LRangeGreen : LElementValueGreen
	{
		internal static new readonly LRangeGreen __Missing = new LRangeGreen();
		private __InternalSyntaxToken _startChar;
		private __InternalSyntaxToken _tDotDot;
		private __InternalSyntaxToken _endChar;
	
		public LRangeGreen(CompilerSyntaxKind kind, __InternalSyntaxToken startChar, __InternalSyntaxToken tDotDot, __InternalSyntaxToken endChar)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (startChar != null)
			{
				AdjustFlagsAndWidth(startChar);
				_startChar = startChar;
			}
			if (tDotDot != null)
			{
				AdjustFlagsAndWidth(tDotDot);
				_tDotDot = tDotDot;
			}
			if (endChar != null)
			{
				AdjustFlagsAndWidth(endChar);
				_endChar = endChar;
			}
		}
	
		public LRangeGreen(CompilerSyntaxKind kind, __InternalSyntaxToken startChar, __InternalSyntaxToken tDotDot, __InternalSyntaxToken endChar, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (startChar != null)
			{
				AdjustFlagsAndWidth(startChar);
				_startChar = startChar;
			}
			if (tDotDot != null)
			{
				AdjustFlagsAndWidth(tDotDot);
				_tDotDot = tDotDot;
			}
			if (endChar != null)
			{
				AdjustFlagsAndWidth(endChar);
				_endChar = endChar;
			}
		}
	
		private LRangeGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LRange, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken StartChar { get { return _startChar; } }
		public __InternalSyntaxToken TDotDot { get { return _tDotDot; } }
		public __InternalSyntaxToken EndChar { get { return _endChar; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LRangeSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _startChar;
				case 1: return _tDotDot;
				case 2: return _endChar;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLRangeGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLRangeGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new LRangeGreen(this.Kind, _startChar, _tDotDot, _endChar, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new LRangeGreen(this.Kind, _startChar, _tDotDot, _endChar, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new LRangeGreen(this.Kind, _startChar, _tDotDot, _endChar, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LRangeGreen Update(__InternalSyntaxToken startChar, __InternalSyntaxToken tDotDot, __InternalSyntaxToken endChar)
		{
			if (_startChar != startChar || _tDotDot != tDotDot || _endChar != endChar)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LRange(startChar, tDotDot, endChar);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LRangeGreen)newNode;
			}
			return this;
		}
	}
	
	internal class LReferenceGreen : LElementValueGreen
	{
		internal static new readonly LReferenceGreen __Missing = new LReferenceGreen();
		private IdentifierGreen _rule;
	
		public LReferenceGreen(CompilerSyntaxKind kind, IdentifierGreen rule)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (rule != null)
			{
				AdjustFlagsAndWidth(rule);
				_rule = rule;
			}
		}
	
		public LReferenceGreen(CompilerSyntaxKind kind, IdentifierGreen rule, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (rule != null)
			{
				AdjustFlagsAndWidth(rule);
				_rule = rule;
			}
		}
	
		private LReferenceGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LReference, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Rule { get { return _rule; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LReferenceSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _rule;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLReferenceGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLReferenceGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new LReferenceGreen(this.Kind, _rule, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new LReferenceGreen(this.Kind, _rule, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new LReferenceGreen(this.Kind, _rule, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LReferenceGreen Update(IdentifierGreen rule)
		{
			if (_rule != rule)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LReference(rule);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LReferenceGreen)newNode;
			}
			return this;
		}
	}
	
	internal abstract class ExpressionGreen : GreenSyntaxNode
	{
		internal static readonly ExpressionGreen __Missing = ExpressionAlt1Green.__Missing;
	
	    protected ExpressionGreen(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class ExpressionAlt1Green : ExpressionGreen
	{
		internal static new readonly ExpressionAlt1Green __Missing = new ExpressionAlt1Green();
		private SingleExpressionGreen _singleExpression;
	
		public ExpressionAlt1Green(CompilerSyntaxKind kind, SingleExpressionGreen singleExpression)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (singleExpression != null)
			{
				AdjustFlagsAndWidth(singleExpression);
				_singleExpression = singleExpression;
			}
		}
	
		public ExpressionAlt1Green(CompilerSyntaxKind kind, SingleExpressionGreen singleExpression, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (singleExpression != null)
			{
				AdjustFlagsAndWidth(singleExpression);
				_singleExpression = singleExpression;
			}
		}
	
		private ExpressionAlt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ExpressionAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public SingleExpressionGreen SingleExpression { get { return _singleExpression; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ExpressionAlt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _singleExpression;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitExpressionAlt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitExpressionAlt1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ExpressionAlt1Green(this.Kind, _singleExpression, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ExpressionAlt1Green(this.Kind, _singleExpression, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ExpressionAlt1Green(this.Kind, _singleExpression, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ExpressionAlt1Green Update(SingleExpressionGreen singleExpression)
		{
			if (_singleExpression != singleExpression)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ExpressionAlt1(singleExpression);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ExpressionAlt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class ArrayExpressionGreen : ExpressionGreen
	{
		internal static new readonly ArrayExpressionGreen __Missing = new ArrayExpressionGreen();
		private __InternalSyntaxToken _tLBrace;
		private __GreenNode _items;
		private __InternalSyntaxToken _tRBrace;
	
		public ArrayExpressionGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode items, __InternalSyntaxToken tRBrace)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (items != null)
			{
				AdjustFlagsAndWidth(items);
				_items = items;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		public ArrayExpressionGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tLBrace, __GreenNode items, __InternalSyntaxToken tRBrace, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (items != null)
			{
				AdjustFlagsAndWidth(items);
				_items = items;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		private ArrayExpressionGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ArrayExpression, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TLBrace { get { return _tLBrace; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<SingleExpressionGreen> Items { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<SingleExpressionGreen>(_items, reversed: false); } }
		public __InternalSyntaxToken TRBrace { get { return _tRBrace; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ArrayExpressionSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLBrace;
				case 1: return _items;
				case 2: return _tRBrace;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitArrayExpressionGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitArrayExpressionGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ArrayExpressionGreen(this.Kind, _tLBrace, _items, _tRBrace, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ArrayExpressionGreen(this.Kind, _tLBrace, _items, _tRBrace, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ArrayExpressionGreen(this.Kind, _tLBrace, _items, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ArrayExpressionGreen Update(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<SingleExpressionGreen> items, __InternalSyntaxToken tRBrace)
		{
			if (_tLBrace != tLBrace || _items != items.Node || _tRBrace != tRBrace)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpression(tLBrace, items, tRBrace);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ArrayExpressionGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class SingleExpressionGreen : GreenSyntaxNode
	{
		internal static new readonly SingleExpressionGreen __Missing = new SingleExpressionGreen();
		private SingleExpressionBlock1Green _value;
	
		public SingleExpressionGreen(CompilerSyntaxKind kind, SingleExpressionBlock1Green value)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (value != null)
			{
				AdjustFlagsAndWidth(value);
				_value = value;
			}
		}
	
		public SingleExpressionGreen(CompilerSyntaxKind kind, SingleExpressionBlock1Green value, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (value != null)
			{
				AdjustFlagsAndWidth(value);
				_value = value;
			}
		}
	
		private SingleExpressionGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.SingleExpression, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public SingleExpressionBlock1Green Value { get { return _value; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.SingleExpressionSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _value;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSingleExpressionGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitSingleExpressionGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new SingleExpressionGreen(this.Kind, _value, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new SingleExpressionGreen(this.Kind, _value, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new SingleExpressionGreen(this.Kind, _value, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public SingleExpressionGreen Update(SingleExpressionBlock1Green value)
		{
			if (_value != value)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpression(value);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (SingleExpressionGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class ParserAnnotationGreen : GreenSyntaxNode
	{
		internal static new readonly ParserAnnotationGreen __Missing = new ParserAnnotationGreen();
		private __InternalSyntaxToken _tLBracket;
		private __GreenNode _qualifier;
		private __InternalSyntaxToken _tLParen;
		private __GreenNode _arguments;
		private __InternalSyntaxToken _tRParen;
		private __InternalSyntaxToken _tRBracket;
	
		public ParserAnnotationGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tLBracket, __GreenNode qualifier, __InternalSyntaxToken tLParen, __GreenNode arguments, __InternalSyntaxToken tRParen, __InternalSyntaxToken tRBracket)
			: base(kind, null, null)
		{
			SlotCount = 6;
			if (tLBracket != null)
			{
				AdjustFlagsAndWidth(tLBracket);
				_tLBracket = tLBracket;
			}
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (arguments != null)
			{
				AdjustFlagsAndWidth(arguments);
				_arguments = arguments;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
			if (tRBracket != null)
			{
				AdjustFlagsAndWidth(tRBracket);
				_tRBracket = tRBracket;
			}
		}
	
		public ParserAnnotationGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tLBracket, __GreenNode qualifier, __InternalSyntaxToken tLParen, __GreenNode arguments, __InternalSyntaxToken tRParen, __InternalSyntaxToken tRBracket, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 6;
			if (tLBracket != null)
			{
				AdjustFlagsAndWidth(tLBracket);
				_tLBracket = tLBracket;
			}
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (arguments != null)
			{
				AdjustFlagsAndWidth(arguments);
				_arguments = arguments;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
			if (tRBracket != null)
			{
				AdjustFlagsAndWidth(tRBracket);
				_tRBracket = tRBracket;
			}
		}
	
		private ParserAnnotationGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ParserAnnotation, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TLBracket { get { return _tLBracket; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> Qualifier { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_qualifier, reversed: false); } }
		public __InternalSyntaxToken TLParen { get { return _tLParen; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AnnotationArgumentGreen> Arguments { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AnnotationArgumentGreen>(_arguments, reversed: false); } }
		public __InternalSyntaxToken TRParen { get { return _tRParen; } }
		public __InternalSyntaxToken TRBracket { get { return _tRBracket; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserAnnotationSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLBracket;
				case 1: return _qualifier;
				case 2: return _tLParen;
				case 3: return _arguments;
				case 4: return _tRParen;
				case 5: return _tRBracket;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserAnnotationGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserAnnotationGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ParserAnnotationGreen(this.Kind, _tLBracket, _qualifier, _tLParen, _arguments, _tRParen, _tRBracket, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ParserAnnotationGreen(this.Kind, _tLBracket, _qualifier, _tLParen, _arguments, _tRParen, _tRBracket, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ParserAnnotationGreen(this.Kind, _tLBracket, _qualifier, _tLParen, _arguments, _tRParen, _tRBracket, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserAnnotationGreen Update(__InternalSyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier, __InternalSyntaxToken tLParen, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AnnotationArgumentGreen> arguments, __InternalSyntaxToken tRParen, __InternalSyntaxToken tRBracket)
		{
			if (_tLBracket != tLBracket || _qualifier != qualifier.Node || _tLParen != tLParen || _arguments != arguments.Node || _tRParen != tRParen || _tRBracket != tRBracket)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserAnnotation(tLBracket, qualifier, tLParen, arguments, tRParen, tRBracket);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParserAnnotationGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class LexerAnnotationGreen : GreenSyntaxNode
	{
		internal static new readonly LexerAnnotationGreen __Missing = new LexerAnnotationGreen();
		private __InternalSyntaxToken _tLBracket;
		private __GreenNode _qualifier;
		private __InternalSyntaxToken _tLParen;
		private __GreenNode _arguments;
		private __InternalSyntaxToken _tRParen;
		private __InternalSyntaxToken _tRBracket;
	
		public LexerAnnotationGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tLBracket, __GreenNode qualifier, __InternalSyntaxToken tLParen, __GreenNode arguments, __InternalSyntaxToken tRParen, __InternalSyntaxToken tRBracket)
			: base(kind, null, null)
		{
			SlotCount = 6;
			if (tLBracket != null)
			{
				AdjustFlagsAndWidth(tLBracket);
				_tLBracket = tLBracket;
			}
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (arguments != null)
			{
				AdjustFlagsAndWidth(arguments);
				_arguments = arguments;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
			if (tRBracket != null)
			{
				AdjustFlagsAndWidth(tRBracket);
				_tRBracket = tRBracket;
			}
		}
	
		public LexerAnnotationGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tLBracket, __GreenNode qualifier, __InternalSyntaxToken tLParen, __GreenNode arguments, __InternalSyntaxToken tRParen, __InternalSyntaxToken tRBracket, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 6;
			if (tLBracket != null)
			{
				AdjustFlagsAndWidth(tLBracket);
				_tLBracket = tLBracket;
			}
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (arguments != null)
			{
				AdjustFlagsAndWidth(arguments);
				_arguments = arguments;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
			if (tRBracket != null)
			{
				AdjustFlagsAndWidth(tRBracket);
				_tRBracket = tRBracket;
			}
		}
	
		private LexerAnnotationGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LexerAnnotation, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TLBracket { get { return _tLBracket; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> Qualifier { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_qualifier, reversed: false); } }
		public __InternalSyntaxToken TLParen { get { return _tLParen; } }
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AnnotationArgumentGreen> Arguments { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AnnotationArgumentGreen>(_arguments, reversed: false); } }
		public __InternalSyntaxToken TRParen { get { return _tRParen; } }
		public __InternalSyntaxToken TRBracket { get { return _tRBracket; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LexerAnnotationSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLBracket;
				case 1: return _qualifier;
				case 2: return _tLParen;
				case 3: return _arguments;
				case 4: return _tRParen;
				case 5: return _tRBracket;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLexerAnnotationGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLexerAnnotationGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new LexerAnnotationGreen(this.Kind, _tLBracket, _qualifier, _tLParen, _arguments, _tRParen, _tRBracket, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new LexerAnnotationGreen(this.Kind, _tLBracket, _qualifier, _tLParen, _arguments, _tRParen, _tRBracket, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new LexerAnnotationGreen(this.Kind, _tLBracket, _qualifier, _tLParen, _arguments, _tRParen, _tRBracket, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LexerAnnotationGreen Update(__InternalSyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier, __InternalSyntaxToken tLParen, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AnnotationArgumentGreen> arguments, __InternalSyntaxToken tRParen, __InternalSyntaxToken tRBracket)
		{
			if (_tLBracket != tLBracket || _qualifier != qualifier.Node || _tLParen != tLParen || _arguments != arguments.Node || _tRParen != tRParen || _tRBracket != tRBracket)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LexerAnnotation(tLBracket, qualifier, tLParen, arguments, tRParen, tRBracket);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LexerAnnotationGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class AnnotationArgumentGreen : GreenSyntaxNode
	{
		internal static new readonly AnnotationArgumentGreen __Missing = new AnnotationArgumentGreen();
		private AnnotationArgumentBlock1Green _block;
		private ExpressionGreen _value;
	
		public AnnotationArgumentGreen(CompilerSyntaxKind kind, AnnotationArgumentBlock1Green block, ExpressionGreen value)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (block != null)
			{
				AdjustFlagsAndWidth(block);
				_block = block;
			}
			if (value != null)
			{
				AdjustFlagsAndWidth(value);
				_value = value;
			}
		}
	
		public AnnotationArgumentGreen(CompilerSyntaxKind kind, AnnotationArgumentBlock1Green block, ExpressionGreen value, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (block != null)
			{
				AdjustFlagsAndWidth(block);
				_block = block;
			}
			if (value != null)
			{
				AdjustFlagsAndWidth(value);
				_value = value;
			}
		}
	
		private AnnotationArgumentGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArgument, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public AnnotationArgumentBlock1Green Block { get { return _block; } }
		public ExpressionGreen Value { get { return _value; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.AnnotationArgumentSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _block;
				case 1: return _value;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitAnnotationArgumentGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitAnnotationArgumentGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new AnnotationArgumentGreen(this.Kind, _block, _value, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new AnnotationArgumentGreen(this.Kind, _block, _value, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new AnnotationArgumentGreen(this.Kind, _block, _value, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public AnnotationArgumentGreen Update(AnnotationArgumentBlock1Green block, ExpressionGreen value)
		{
			if (_block != block || _value != value)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgument(block, value);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (AnnotationArgumentGreen)newNode;
			}
			return this;
		}
	}
	
	internal abstract class TypeReferenceIdentifierGreen : GreenSyntaxNode
	{
		internal static readonly TypeReferenceIdentifierGreen __Missing = TypeReferenceIdentifierAlt1Green.__Missing;
	
	    protected TypeReferenceIdentifierGreen(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class TypeReferenceIdentifierAlt1Green : TypeReferenceIdentifierGreen
	{
		internal static new readonly TypeReferenceIdentifierAlt1Green __Missing = new TypeReferenceIdentifierAlt1Green();
		private __InternalSyntaxToken _tokens;
	
		public TypeReferenceIdentifierAlt1Green(CompilerSyntaxKind kind, __InternalSyntaxToken tokens)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
		}
	
		public TypeReferenceIdentifierAlt1Green(CompilerSyntaxKind kind, __InternalSyntaxToken tokens, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
		}
	
		private TypeReferenceIdentifierAlt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.TypeReferenceIdentifierAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken Tokens { get { return _tokens; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.TypeReferenceIdentifierAlt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tokens;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceIdentifierAlt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceIdentifierAlt1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new TypeReferenceIdentifierAlt1Green(this.Kind, _tokens, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new TypeReferenceIdentifierAlt1Green(this.Kind, _tokens, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new TypeReferenceIdentifierAlt1Green(this.Kind, _tokens, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TypeReferenceIdentifierAlt1Green Update(__InternalSyntaxToken tokens)
		{
			if (_tokens != tokens)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceIdentifierAlt1(tokens);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TypeReferenceIdentifierAlt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class TypeReferenceIdentifierAlt2Green : TypeReferenceIdentifierGreen
	{
		internal static new readonly TypeReferenceIdentifierAlt2Green __Missing = new TypeReferenceIdentifierAlt2Green();
		private IdentifierGreen _identifier;
	
		public TypeReferenceIdentifierAlt2Green(CompilerSyntaxKind kind, IdentifierGreen identifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
		}
	
		public TypeReferenceIdentifierAlt2Green(CompilerSyntaxKind kind, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
		}
	
		private TypeReferenceIdentifierAlt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.TypeReferenceIdentifierAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Identifier { get { return _identifier; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.TypeReferenceIdentifierAlt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _identifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceIdentifierAlt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceIdentifierAlt2Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new TypeReferenceIdentifierAlt2Green(this.Kind, _identifier, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new TypeReferenceIdentifierAlt2Green(this.Kind, _identifier, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new TypeReferenceIdentifierAlt2Green(this.Kind, _identifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TypeReferenceIdentifierAlt2Green Update(IdentifierGreen identifier)
		{
			if (_identifier != identifier)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceIdentifierAlt2(identifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TypeReferenceIdentifierAlt2Green)newNode;
			}
			return this;
		}
	}
	
	internal abstract class TypeReferenceGreen : GreenSyntaxNode
	{
		internal static readonly TypeReferenceGreen __Missing = TypeReferenceAlt1Green.__Missing;
	
	    protected TypeReferenceGreen(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class TypeReferenceAlt1Green : TypeReferenceGreen
	{
		internal static new readonly TypeReferenceAlt1Green __Missing = new TypeReferenceAlt1Green();
		private __InternalSyntaxToken _tokens;
	
		public TypeReferenceAlt1Green(CompilerSyntaxKind kind, __InternalSyntaxToken tokens)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
		}
	
		public TypeReferenceAlt1Green(CompilerSyntaxKind kind, __InternalSyntaxToken tokens, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
		}
	
		private TypeReferenceAlt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.TypeReferenceAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken Tokens { get { return _tokens; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.TypeReferenceAlt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tokens;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceAlt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceAlt1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new TypeReferenceAlt1Green(this.Kind, _tokens, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new TypeReferenceAlt1Green(this.Kind, _tokens, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new TypeReferenceAlt1Green(this.Kind, _tokens, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TypeReferenceAlt1Green Update(__InternalSyntaxToken tokens)
		{
			if (_tokens != tokens)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt1(tokens);
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
		private __GreenNode _qualifier;
	
		public TypeReferenceAlt2Green(CompilerSyntaxKind kind, __GreenNode qualifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		public TypeReferenceAlt2Green(CompilerSyntaxKind kind, __GreenNode qualifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
			: base((CompilerSyntaxKind)CompilerSyntaxKind.TypeReferenceAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> Qualifier { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_qualifier, reversed: false); } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.TypeReferenceAlt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _qualifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceAlt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceAlt2Green(this);
	
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
	
	
		public TypeReferenceAlt2Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier)
		{
			if (_qualifier != qualifier.Node)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt2(qualifier);
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
	
	
	internal class NameGreen : GreenSyntaxNode
	{
		internal static new readonly NameGreen __Missing = new NameGreen();
		private IdentifierGreen _identifier;
	
		public NameGreen(CompilerSyntaxKind kind, IdentifierGreen identifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
		}
	
		public NameGreen(CompilerSyntaxKind kind, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Name, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Identifier { get { return _identifier; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.NameSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _identifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitNameGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitNameGreen(this);
	
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
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Name(identifier);
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
	
	
	internal class IdentifierGreen : GreenSyntaxNode
	{
		internal static new readonly IdentifierGreen __Missing = new IdentifierGreen();
		private __InternalSyntaxToken _token;
	
		public IdentifierGreen(CompilerSyntaxKind kind, __InternalSyntaxToken token)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (token != null)
			{
				AdjustFlagsAndWidth(token);
				_token = token;
			}
		}
	
		public IdentifierGreen(CompilerSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Identifier, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken Token { get { return _token; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.IdentifierSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _token;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitIdentifierGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitIdentifierGreen(this);
	
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
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Identifier(token);
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
		private LanguageDeclarationGreen _declarations;
	
		public MainBlock1Green(CompilerSyntaxKind kind, LanguageDeclarationGreen declarations)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (declarations != null)
			{
				AdjustFlagsAndWidth(declarations);
				_declarations = declarations;
			}
		}
	
		public MainBlock1Green(CompilerSyntaxKind kind, LanguageDeclarationGreen declarations, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
			: base((CompilerSyntaxKind)CompilerSyntaxKind.MainBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public LanguageDeclarationGreen Declarations { get { return _declarations; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.MainBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _declarations;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitMainBlock1Green(this);
	
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
	
	
		public MainBlock1Green Update(LanguageDeclarationGreen declarations)
		{
			if (_declarations != declarations)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.MainBlock1(declarations);
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
	
	internal abstract class RuleBlock1Green : GreenSyntaxNode
	{
		internal static readonly RuleBlock1Green __Missing = RuleBlock1Alt1Green.__Missing;
	
	    protected RuleBlock1Green(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class RuleBlock1Alt1Green : RuleBlock1Green
	{
		internal static new readonly RuleBlock1Alt1Green __Missing = new RuleBlock1Alt1Green();
		private TypeReferenceIdentifierGreen _returnType;
	
		public RuleBlock1Alt1Green(CompilerSyntaxKind kind, TypeReferenceIdentifierGreen returnType)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
		}
	
		public RuleBlock1Alt1Green(CompilerSyntaxKind kind, TypeReferenceIdentifierGreen returnType, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
		}
	
		private RuleBlock1Alt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.RuleBlock1Alt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public TypeReferenceIdentifierGreen ReturnType { get { return _returnType; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.RuleBlock1Alt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _returnType;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitRuleBlock1Alt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitRuleBlock1Alt1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new RuleBlock1Alt1Green(this.Kind, _returnType, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new RuleBlock1Alt1Green(this.Kind, _returnType, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new RuleBlock1Alt1Green(this.Kind, _returnType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public RuleBlock1Alt1Green Update(TypeReferenceIdentifierGreen returnType)
		{
			if (_returnType != returnType)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.RuleBlock1Alt1(returnType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (RuleBlock1Alt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class RuleBlock1Alt2Green : RuleBlock1Green
	{
		internal static new readonly RuleBlock1Alt2Green __Missing = new RuleBlock1Alt2Green();
		private IdentifierGreen _identifier;
		private __InternalSyntaxToken _kReturns;
		private TypeReferenceGreen _returnType;
	
		public RuleBlock1Alt2Green(CompilerSyntaxKind kind, IdentifierGreen identifier, __InternalSyntaxToken kReturns, TypeReferenceGreen returnType)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
			if (kReturns != null)
			{
				AdjustFlagsAndWidth(kReturns);
				_kReturns = kReturns;
			}
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
		}
	
		public RuleBlock1Alt2Green(CompilerSyntaxKind kind, IdentifierGreen identifier, __InternalSyntaxToken kReturns, TypeReferenceGreen returnType, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
			if (kReturns != null)
			{
				AdjustFlagsAndWidth(kReturns);
				_kReturns = kReturns;
			}
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
		}
	
		private RuleBlock1Alt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.RuleBlock1Alt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Identifier { get { return _identifier; } }
		public __InternalSyntaxToken KReturns { get { return _kReturns; } }
		public TypeReferenceGreen ReturnType { get { return _returnType; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.RuleBlock1Alt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _identifier;
				case 1: return _kReturns;
				case 2: return _returnType;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitRuleBlock1Alt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitRuleBlock1Alt2Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new RuleBlock1Alt2Green(this.Kind, _identifier, _kReturns, _returnType, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new RuleBlock1Alt2Green(this.Kind, _identifier, _kReturns, _returnType, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new RuleBlock1Alt2Green(this.Kind, _identifier, _kReturns, _returnType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public RuleBlock1Alt2Green Update(IdentifierGreen identifier, __InternalSyntaxToken kReturns, TypeReferenceGreen returnType)
		{
			if (_identifier != identifier || _kReturns != kReturns || _returnType != returnType)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.RuleBlock1Alt2(identifier, kReturns, returnType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (RuleBlock1Alt2Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class RuleAlternativesBlockGreen : GreenSyntaxNode
	{
		internal static new readonly RuleAlternativesBlockGreen __Missing = new RuleAlternativesBlockGreen();
		private __InternalSyntaxToken _tBar;
		private AlternativeGreen _alternatives;
	
		public RuleAlternativesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, AlternativeGreen alternatives)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
		}
	
		public RuleAlternativesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, AlternativeGreen alternatives, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
		}
	
		private RuleAlternativesBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.RuleAlternativesBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TBar { get { return _tBar; } }
		public AlternativeGreen Alternatives { get { return _alternatives; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.RuleAlternativesBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tBar;
				case 1: return _alternatives;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitRuleAlternativesBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitRuleAlternativesBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new RuleAlternativesBlockGreen(this.Kind, _tBar, _alternatives, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new RuleAlternativesBlockGreen(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new RuleAlternativesBlockGreen(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public RuleAlternativesBlockGreen Update(__InternalSyntaxToken tBar, AlternativeGreen alternatives)
		{
			if (_tBar != tBar || _alternatives != alternatives)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.RuleAlternativesBlock(tBar, alternatives);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (RuleAlternativesBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class AlternativeBlock1Green : GreenSyntaxNode
	{
		internal static new readonly AlternativeBlock1Green __Missing = new AlternativeBlock1Green();
		private __GreenNode _annotations1;
		private __InternalSyntaxToken _kAlt;
		private NameGreen _name;
		private AlternativeBlock1Block1Green _block;
		private __InternalSyntaxToken _tColon;
	
		public AlternativeBlock1Green(CompilerSyntaxKind kind, __GreenNode annotations1, __InternalSyntaxToken kAlt, NameGreen name, AlternativeBlock1Block1Green block, __InternalSyntaxToken tColon)
			: base(kind, null, null)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (kAlt != null)
			{
				AdjustFlagsAndWidth(kAlt);
				_kAlt = kAlt;
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
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
		}
	
		public AlternativeBlock1Green(CompilerSyntaxKind kind, __GreenNode annotations1, __InternalSyntaxToken kAlt, NameGreen name, AlternativeBlock1Block1Green block, __InternalSyntaxToken tColon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (kAlt != null)
			{
				AdjustFlagsAndWidth(kAlt);
				_kAlt = kAlt;
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
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
		}
	
		private AlternativeBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.AlternativeBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> Annotations1 { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_annotations1); } }
		public __InternalSyntaxToken KAlt { get { return _kAlt; } }
		public NameGreen Name { get { return _name; } }
		public AlternativeBlock1Block1Green Block { get { return _block; } }
		public __InternalSyntaxToken TColon { get { return _tColon; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.AlternativeBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _kAlt;
				case 2: return _name;
				case 3: return _block;
				case 4: return _tColon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitAlternativeBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitAlternativeBlock1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new AlternativeBlock1Green(this.Kind, _annotations1, _kAlt, _name, _block, _tColon, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new AlternativeBlock1Green(this.Kind, _annotations1, _kAlt, _name, _block, _tColon, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new AlternativeBlock1Green(this.Kind, _annotations1, _kAlt, _name, _block, _tColon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public AlternativeBlock1Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, __InternalSyntaxToken kAlt, NameGreen name, AlternativeBlock1Block1Green block, __InternalSyntaxToken tColon)
		{
			if (_annotations1 != annotations1.Node || _kAlt != kAlt || _name != name || _block != block || _tColon != tColon)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock1(annotations1, kAlt, name, block, tColon);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (AlternativeBlock1Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class AlternativeBlock2Green : GreenSyntaxNode
	{
		internal static new readonly AlternativeBlock2Green __Missing = new AlternativeBlock2Green();
		private __InternalSyntaxToken _tEqGt;
		private ExpressionGreen _returnValue;
	
		public AlternativeBlock2Green(CompilerSyntaxKind kind, __InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tEqGt != null)
			{
				AdjustFlagsAndWidth(tEqGt);
				_tEqGt = tEqGt;
			}
			if (returnValue != null)
			{
				AdjustFlagsAndWidth(returnValue);
				_returnValue = returnValue;
			}
		}
	
		public AlternativeBlock2Green(CompilerSyntaxKind kind, __InternalSyntaxToken tEqGt, ExpressionGreen returnValue, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tEqGt != null)
			{
				AdjustFlagsAndWidth(tEqGt);
				_tEqGt = tEqGt;
			}
			if (returnValue != null)
			{
				AdjustFlagsAndWidth(returnValue);
				_returnValue = returnValue;
			}
		}
	
		private AlternativeBlock2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.AlternativeBlock2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TEqGt { get { return _tEqGt; } }
		public ExpressionGreen ReturnValue { get { return _returnValue; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.AlternativeBlock2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tEqGt;
				case 1: return _returnValue;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitAlternativeBlock2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitAlternativeBlock2Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new AlternativeBlock2Green(this.Kind, _tEqGt, _returnValue, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new AlternativeBlock2Green(this.Kind, _tEqGt, _returnValue, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new AlternativeBlock2Green(this.Kind, _tEqGt, _returnValue, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public AlternativeBlock2Green Update(__InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
		{
			if (_tEqGt != tEqGt || _returnValue != returnValue)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock2(tEqGt, returnValue);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (AlternativeBlock2Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class ElementBlock1Green : GreenSyntaxNode
	{
		internal static new readonly ElementBlock1Green __Missing = new ElementBlock1Green();
		private __GreenNode _annotations1;
		private NameGreen _name;
		private __InternalSyntaxToken _assignment;
	
		public ElementBlock1Green(CompilerSyntaxKind kind, __GreenNode annotations1, NameGreen name, __InternalSyntaxToken assignment)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
			if (assignment != null)
			{
				AdjustFlagsAndWidth(assignment);
				_assignment = assignment;
			}
		}
	
		public ElementBlock1Green(CompilerSyntaxKind kind, __GreenNode annotations1, NameGreen name, __InternalSyntaxToken assignment, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
			if (assignment != null)
			{
				AdjustFlagsAndWidth(assignment);
				_assignment = assignment;
			}
		}
	
		private ElementBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ElementBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> Annotations1 { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_annotations1); } }
		public NameGreen Name { get { return _name; } }
		public __InternalSyntaxToken Assignment { get { return _assignment; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ElementBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _name;
				case 2: return _assignment;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitElementBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitElementBlock1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ElementBlock1Green(this.Kind, _annotations1, _name, _assignment, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ElementBlock1Green(this.Kind, _annotations1, _name, _assignment, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ElementBlock1Green(this.Kind, _annotations1, _name, _assignment, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ElementBlock1Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, NameGreen name, __InternalSyntaxToken assignment)
		{
			if (_annotations1 != annotations1.Node || _name != name || _assignment != assignment)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ElementBlock1(annotations1, name, assignment);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ElementBlock1Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class BlockAlternativesBlockGreen : GreenSyntaxNode
	{
		internal static new readonly BlockAlternativesBlockGreen __Missing = new BlockAlternativesBlockGreen();
		private __InternalSyntaxToken _tBar;
		private BlockAlternativeGreen _alternatives;
	
		public BlockAlternativesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, BlockAlternativeGreen alternatives)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
		}
	
		public BlockAlternativesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, BlockAlternativeGreen alternatives, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
		}
	
		private BlockAlternativesBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.BlockAlternativesBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TBar { get { return _tBar; } }
		public BlockAlternativeGreen Alternatives { get { return _alternatives; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.BlockAlternativesBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tBar;
				case 1: return _alternatives;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBlockAlternativesBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitBlockAlternativesBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new BlockAlternativesBlockGreen(this.Kind, _tBar, _alternatives, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new BlockAlternativesBlockGreen(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new BlockAlternativesBlockGreen(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public BlockAlternativesBlockGreen Update(__InternalSyntaxToken tBar, BlockAlternativeGreen alternatives)
		{
			if (_tBar != tBar || _alternatives != alternatives)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.BlockAlternativesBlock(tBar, alternatives);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (BlockAlternativesBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class BlockAlternativeBlock1Green : GreenSyntaxNode
	{
		internal static new readonly BlockAlternativeBlock1Green __Missing = new BlockAlternativeBlock1Green();
		private __InternalSyntaxToken _tEqGt;
		private ExpressionGreen _returnValue;
	
		public BlockAlternativeBlock1Green(CompilerSyntaxKind kind, __InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tEqGt != null)
			{
				AdjustFlagsAndWidth(tEqGt);
				_tEqGt = tEqGt;
			}
			if (returnValue != null)
			{
				AdjustFlagsAndWidth(returnValue);
				_returnValue = returnValue;
			}
		}
	
		public BlockAlternativeBlock1Green(CompilerSyntaxKind kind, __InternalSyntaxToken tEqGt, ExpressionGreen returnValue, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tEqGt != null)
			{
				AdjustFlagsAndWidth(tEqGt);
				_tEqGt = tEqGt;
			}
			if (returnValue != null)
			{
				AdjustFlagsAndWidth(returnValue);
				_returnValue = returnValue;
			}
		}
	
		private BlockAlternativeBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.BlockAlternativeBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TEqGt { get { return _tEqGt; } }
		public ExpressionGreen ReturnValue { get { return _returnValue; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.BlockAlternativeBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tEqGt;
				case 1: return _returnValue;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBlockAlternativeBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitBlockAlternativeBlock1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new BlockAlternativeBlock1Green(this.Kind, _tEqGt, _returnValue, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new BlockAlternativeBlock1Green(this.Kind, _tEqGt, _returnValue, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new BlockAlternativeBlock1Green(this.Kind, _tEqGt, _returnValue, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public BlockAlternativeBlock1Green Update(__InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
		{
			if (_tEqGt != tEqGt || _returnValue != returnValue)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.BlockAlternativeBlock1(tEqGt, returnValue);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (BlockAlternativeBlock1Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class RuleRefAlt3ReferencedTypesBlockGreen : GreenSyntaxNode
	{
		internal static new readonly RuleRefAlt3ReferencedTypesBlockGreen __Missing = new RuleRefAlt3ReferencedTypesBlockGreen();
		private __InternalSyntaxToken _tComma;
		private TypeReferenceGreen _referencedTypes;
	
		public RuleRefAlt3ReferencedTypesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tComma, TypeReferenceGreen referencedTypes)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tComma != null)
			{
				AdjustFlagsAndWidth(tComma);
				_tComma = tComma;
			}
			if (referencedTypes != null)
			{
				AdjustFlagsAndWidth(referencedTypes);
				_referencedTypes = referencedTypes;
			}
		}
	
		public RuleRefAlt3ReferencedTypesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tComma, TypeReferenceGreen referencedTypes, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tComma != null)
			{
				AdjustFlagsAndWidth(tComma);
				_tComma = tComma;
			}
			if (referencedTypes != null)
			{
				AdjustFlagsAndWidth(referencedTypes);
				_referencedTypes = referencedTypes;
			}
		}
	
		private RuleRefAlt3ReferencedTypesBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt3ReferencedTypesBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TComma { get { return _tComma; } }
		public TypeReferenceGreen ReferencedTypes { get { return _referencedTypes; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.RuleRefAlt3ReferencedTypesBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _referencedTypes;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitRuleRefAlt3ReferencedTypesBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitRuleRefAlt3ReferencedTypesBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new RuleRefAlt3ReferencedTypesBlockGreen(this.Kind, _tComma, _referencedTypes, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new RuleRefAlt3ReferencedTypesBlockGreen(this.Kind, _tComma, _referencedTypes, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new RuleRefAlt3ReferencedTypesBlockGreen(this.Kind, _tComma, _referencedTypes, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public RuleRefAlt3ReferencedTypesBlockGreen Update(__InternalSyntaxToken tComma, TypeReferenceGreen referencedTypes)
		{
			if (_tComma != tComma || _referencedTypes != referencedTypes)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3ReferencedTypesBlock(tComma, referencedTypes);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (RuleRefAlt3ReferencedTypesBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class RuleRefAlt3Block1Green : GreenSyntaxNode
	{
		internal static new readonly RuleRefAlt3Block1Green __Missing = new RuleRefAlt3Block1Green();
		private __InternalSyntaxToken _tBar;
		private IdentifierGreen _grammarRule;
	
		public RuleRefAlt3Block1Green(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, IdentifierGreen grammarRule)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (grammarRule != null)
			{
				AdjustFlagsAndWidth(grammarRule);
				_grammarRule = grammarRule;
			}
		}
	
		public RuleRefAlt3Block1Green(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, IdentifierGreen grammarRule, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (grammarRule != null)
			{
				AdjustFlagsAndWidth(grammarRule);
				_grammarRule = grammarRule;
			}
		}
	
		private RuleRefAlt3Block1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt3Block1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TBar { get { return _tBar; } }
		public IdentifierGreen GrammarRule { get { return _grammarRule; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.RuleRefAlt3Block1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tBar;
				case 1: return _grammarRule;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitRuleRefAlt3Block1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitRuleRefAlt3Block1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new RuleRefAlt3Block1Green(this.Kind, _tBar, _grammarRule, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new RuleRefAlt3Block1Green(this.Kind, _tBar, _grammarRule, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new RuleRefAlt3Block1Green(this.Kind, _tBar, _grammarRule, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public RuleRefAlt3Block1Green Update(__InternalSyntaxToken tBar, IdentifierGreen grammarRule)
		{
			if (_tBar != tBar || _grammarRule != grammarRule)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3Block1(tBar, grammarRule);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (RuleRefAlt3Block1Green)newNode;
			}
			return this;
		}
	}
	
	internal abstract class TokenBlock1Green : GreenSyntaxNode
	{
		internal static readonly TokenBlock1Green __Missing = TokenBlock1Alt1Green.__Missing;
	
	    protected TokenBlock1Green(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class TokenBlock1Alt1Green : TokenBlock1Green
	{
		internal static new readonly TokenBlock1Alt1Green __Missing = new TokenBlock1Alt1Green();
		private __InternalSyntaxToken _kToken;
		private NameGreen _name;
		private TokenBlock1Alt1Block1Green _block;
	
		public TokenBlock1Alt1Green(CompilerSyntaxKind kind, __InternalSyntaxToken kToken, NameGreen name, TokenBlock1Alt1Block1Green block)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (kToken != null)
			{
				AdjustFlagsAndWidth(kToken);
				_kToken = kToken;
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
	
		public TokenBlock1Alt1Green(CompilerSyntaxKind kind, __InternalSyntaxToken kToken, NameGreen name, TokenBlock1Alt1Block1Green block, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (kToken != null)
			{
				AdjustFlagsAndWidth(kToken);
				_kToken = kToken;
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
	
		private TokenBlock1Alt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.TokenBlock1Alt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KToken { get { return _kToken; } }
		public NameGreen Name { get { return _name; } }
		public TokenBlock1Alt1Block1Green Block { get { return _block; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.TokenBlock1Alt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kToken;
				case 1: return _name;
				case 2: return _block;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTokenBlock1Alt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitTokenBlock1Alt1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new TokenBlock1Alt1Green(this.Kind, _kToken, _name, _block, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new TokenBlock1Alt1Green(this.Kind, _kToken, _name, _block, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new TokenBlock1Alt1Green(this.Kind, _kToken, _name, _block, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TokenBlock1Alt1Green Update(__InternalSyntaxToken kToken, NameGreen name, TokenBlock1Alt1Block1Green block)
		{
			if (_kToken != kToken || _name != name || _block != block)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt1(kToken, name, block);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TokenBlock1Alt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class TokenBlock1Alt2Green : TokenBlock1Green
	{
		internal static new readonly TokenBlock1Alt2Green __Missing = new TokenBlock1Alt2Green();
		private __InternalSyntaxToken _isTrivia;
		private NameGreen _name;
	
		public TokenBlock1Alt2Green(CompilerSyntaxKind kind, __InternalSyntaxToken isTrivia, NameGreen name)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (isTrivia != null)
			{
				AdjustFlagsAndWidth(isTrivia);
				_isTrivia = isTrivia;
			}
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
		}
	
		public TokenBlock1Alt2Green(CompilerSyntaxKind kind, __InternalSyntaxToken isTrivia, NameGreen name, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (isTrivia != null)
			{
				AdjustFlagsAndWidth(isTrivia);
				_isTrivia = isTrivia;
			}
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
		}
	
		private TokenBlock1Alt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.TokenBlock1Alt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken IsTrivia { get { return _isTrivia; } }
		public NameGreen Name { get { return _name; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.TokenBlock1Alt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _isTrivia;
				case 1: return _name;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTokenBlock1Alt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitTokenBlock1Alt2Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new TokenBlock1Alt2Green(this.Kind, _isTrivia, _name, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new TokenBlock1Alt2Green(this.Kind, _isTrivia, _name, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new TokenBlock1Alt2Green(this.Kind, _isTrivia, _name, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TokenBlock1Alt2Green Update(__InternalSyntaxToken isTrivia, NameGreen name)
		{
			if (_isTrivia != isTrivia || _name != name)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt2(isTrivia, name);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TokenBlock1Alt2Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class TokenAlternativesBlockGreen : GreenSyntaxNode
	{
		internal static new readonly TokenAlternativesBlockGreen __Missing = new TokenAlternativesBlockGreen();
		private __InternalSyntaxToken _tBar;
		private LAlternativeGreen _alternatives;
	
		public TokenAlternativesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, LAlternativeGreen alternatives)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
		}
	
		public TokenAlternativesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, LAlternativeGreen alternatives, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
		}
	
		private TokenAlternativesBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.TokenAlternativesBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TBar { get { return _tBar; } }
		public LAlternativeGreen Alternatives { get { return _alternatives; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.TokenAlternativesBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tBar;
				case 1: return _alternatives;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTokenAlternativesBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitTokenAlternativesBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new TokenAlternativesBlockGreen(this.Kind, _tBar, _alternatives, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new TokenAlternativesBlockGreen(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new TokenAlternativesBlockGreen(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TokenAlternativesBlockGreen Update(__InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
			if (_tBar != tBar || _alternatives != alternatives)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.TokenAlternativesBlock(tBar, alternatives);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TokenAlternativesBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class FragmentAlternativesBlockGreen : GreenSyntaxNode
	{
		internal static new readonly FragmentAlternativesBlockGreen __Missing = new FragmentAlternativesBlockGreen();
		private __InternalSyntaxToken _tBar;
		private LAlternativeGreen _alternatives;
	
		public FragmentAlternativesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, LAlternativeGreen alternatives)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
		}
	
		public FragmentAlternativesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, LAlternativeGreen alternatives, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
		}
	
		private FragmentAlternativesBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.FragmentAlternativesBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TBar { get { return _tBar; } }
		public LAlternativeGreen Alternatives { get { return _alternatives; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.FragmentAlternativesBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tBar;
				case 1: return _alternatives;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitFragmentAlternativesBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitFragmentAlternativesBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new FragmentAlternativesBlockGreen(this.Kind, _tBar, _alternatives, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new FragmentAlternativesBlockGreen(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new FragmentAlternativesBlockGreen(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public FragmentAlternativesBlockGreen Update(__InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
			if (_tBar != tBar || _alternatives != alternatives)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.FragmentAlternativesBlock(tBar, alternatives);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (FragmentAlternativesBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class LBlockAlternativesBlockGreen : GreenSyntaxNode
	{
		internal static new readonly LBlockAlternativesBlockGreen __Missing = new LBlockAlternativesBlockGreen();
		private __InternalSyntaxToken _tBar;
		private LAlternativeGreen _alternatives;
	
		public LBlockAlternativesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, LAlternativeGreen alternatives)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
		}
	
		public LBlockAlternativesBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tBar, LAlternativeGreen alternatives, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tBar != null)
			{
				AdjustFlagsAndWidth(tBar);
				_tBar = tBar;
			}
			if (alternatives != null)
			{
				AdjustFlagsAndWidth(alternatives);
				_alternatives = alternatives;
			}
		}
	
		private LBlockAlternativesBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LBlockAlternativesBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TBar { get { return _tBar; } }
		public LAlternativeGreen Alternatives { get { return _alternatives; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LBlockAlternativesBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tBar;
				case 1: return _alternatives;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLBlockAlternativesBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLBlockAlternativesBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new LBlockAlternativesBlockGreen(this.Kind, _tBar, _alternatives, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new LBlockAlternativesBlockGreen(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new LBlockAlternativesBlockGreen(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LBlockAlternativesBlockGreen Update(__InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
			if (_tBar != tBar || _alternatives != alternatives)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LBlockAlternativesBlock(tBar, alternatives);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LBlockAlternativesBlockGreen)newNode;
			}
			return this;
		}
	}
	
	internal abstract class SingleExpressionBlock1Green : GreenSyntaxNode
	{
		internal static readonly SingleExpressionBlock1Green __Missing = TokensGreen.__Missing;
	
	    protected SingleExpressionBlock1Green(CompilerSyntaxKind kind, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class TokensGreen : SingleExpressionBlock1Green
	{
		internal static new readonly TokensGreen __Missing = new TokensGreen();
		private __InternalSyntaxToken _token;
	
		public TokensGreen(CompilerSyntaxKind kind, __InternalSyntaxToken token)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (token != null)
			{
				AdjustFlagsAndWidth(token);
				_token = token;
			}
		}
	
		public TokensGreen(CompilerSyntaxKind kind, __InternalSyntaxToken token, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (token != null)
			{
				AdjustFlagsAndWidth(token);
				_token = token;
			}
		}
	
		private TokensGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Tokens, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken Token { get { return _token; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.TokensSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _token;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTokensGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitTokensGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new TokensGreen(this.Kind, _token, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new TokensGreen(this.Kind, _token, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new TokensGreen(this.Kind, _token, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TokensGreen Update(__InternalSyntaxToken token)
		{
			if (_token != token)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Tokens(token);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TokensGreen)newNode;
			}
			return this;
		}
	}
	
	internal class SingleExpressionBlock1Alt2Green : SingleExpressionBlock1Green
	{
		internal static new readonly SingleExpressionBlock1Alt2Green __Missing = new SingleExpressionBlock1Alt2Green();
		private __InternalSyntaxToken _tokens;
	
		public SingleExpressionBlock1Alt2Green(CompilerSyntaxKind kind, __InternalSyntaxToken tokens)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
		}
	
		public SingleExpressionBlock1Alt2Green(CompilerSyntaxKind kind, __InternalSyntaxToken tokens, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
		}
	
		private SingleExpressionBlock1Alt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.SingleExpressionBlock1Alt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken Tokens { get { return _tokens; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.SingleExpressionBlock1Alt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tokens;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSingleExpressionBlock1Alt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitSingleExpressionBlock1Alt2Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new SingleExpressionBlock1Alt2Green(this.Kind, _tokens, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new SingleExpressionBlock1Alt2Green(this.Kind, _tokens, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new SingleExpressionBlock1Alt2Green(this.Kind, _tokens, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public SingleExpressionBlock1Alt2Green Update(__InternalSyntaxToken tokens)
		{
			if (_tokens != tokens)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt2(tokens);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (SingleExpressionBlock1Alt2Green)newNode;
			}
			return this;
		}
	}
	
	internal class SingleExpressionBlock1Alt3Green : SingleExpressionBlock1Green
	{
		internal static new readonly SingleExpressionBlock1Alt3Green __Missing = new SingleExpressionBlock1Alt3Green();
		private __GreenNode _qualifier;
	
		public SingleExpressionBlock1Alt3Green(CompilerSyntaxKind kind, __GreenNode qualifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		public SingleExpressionBlock1Alt3Green(CompilerSyntaxKind kind, __GreenNode qualifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		private SingleExpressionBlock1Alt3Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.SingleExpressionBlock1Alt3, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> Qualifier { get { return new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_qualifier, reversed: false); } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.SingleExpressionBlock1Alt3Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _qualifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSingleExpressionBlock1Alt3Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitSingleExpressionBlock1Alt3Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new SingleExpressionBlock1Alt3Green(this.Kind, _qualifier, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new SingleExpressionBlock1Alt3Green(this.Kind, _qualifier, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new SingleExpressionBlock1Alt3Green(this.Kind, _qualifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public SingleExpressionBlock1Alt3Green Update(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier)
		{
			if (_qualifier != qualifier.Node)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt3(qualifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (SingleExpressionBlock1Alt3Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class ParserAnnotationArgumentsBlockGreen : GreenSyntaxNode
	{
		internal static new readonly ParserAnnotationArgumentsBlockGreen __Missing = new ParserAnnotationArgumentsBlockGreen();
		private __InternalSyntaxToken _tComma;
		private AnnotationArgumentGreen _arguments;
	
		public ParserAnnotationArgumentsBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tComma, AnnotationArgumentGreen arguments)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tComma != null)
			{
				AdjustFlagsAndWidth(tComma);
				_tComma = tComma;
			}
			if (arguments != null)
			{
				AdjustFlagsAndWidth(arguments);
				_arguments = arguments;
			}
		}
	
		public ParserAnnotationArgumentsBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tComma, AnnotationArgumentGreen arguments, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tComma != null)
			{
				AdjustFlagsAndWidth(tComma);
				_tComma = tComma;
			}
			if (arguments != null)
			{
				AdjustFlagsAndWidth(arguments);
				_arguments = arguments;
			}
		}
	
		private ParserAnnotationArgumentsBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ParserAnnotationArgumentsBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TComma { get { return _tComma; } }
		public AnnotationArgumentGreen Arguments { get { return _arguments; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserAnnotationArgumentsBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _arguments;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserAnnotationArgumentsBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserAnnotationArgumentsBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ParserAnnotationArgumentsBlockGreen(this.Kind, _tComma, _arguments, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ParserAnnotationArgumentsBlockGreen(this.Kind, _tComma, _arguments, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ParserAnnotationArgumentsBlockGreen(this.Kind, _tComma, _arguments, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserAnnotationArgumentsBlockGreen Update(__InternalSyntaxToken tComma, AnnotationArgumentGreen arguments)
		{
			if (_tComma != tComma || _arguments != arguments)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserAnnotationArgumentsBlock(tComma, arguments);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParserAnnotationArgumentsBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class LexerAnnotationArgumentsBlockGreen : GreenSyntaxNode
	{
		internal static new readonly LexerAnnotationArgumentsBlockGreen __Missing = new LexerAnnotationArgumentsBlockGreen();
		private __InternalSyntaxToken _tComma;
		private AnnotationArgumentGreen _arguments;
	
		public LexerAnnotationArgumentsBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tComma, AnnotationArgumentGreen arguments)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tComma != null)
			{
				AdjustFlagsAndWidth(tComma);
				_tComma = tComma;
			}
			if (arguments != null)
			{
				AdjustFlagsAndWidth(arguments);
				_arguments = arguments;
			}
		}
	
		public LexerAnnotationArgumentsBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tComma, AnnotationArgumentGreen arguments, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tComma != null)
			{
				AdjustFlagsAndWidth(tComma);
				_tComma = tComma;
			}
			if (arguments != null)
			{
				AdjustFlagsAndWidth(arguments);
				_arguments = arguments;
			}
		}
	
		private LexerAnnotationArgumentsBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LexerAnnotationArgumentsBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TComma { get { return _tComma; } }
		public AnnotationArgumentGreen Arguments { get { return _arguments; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LexerAnnotationArgumentsBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _arguments;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLexerAnnotationArgumentsBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLexerAnnotationArgumentsBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new LexerAnnotationArgumentsBlockGreen(this.Kind, _tComma, _arguments, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new LexerAnnotationArgumentsBlockGreen(this.Kind, _tComma, _arguments, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new LexerAnnotationArgumentsBlockGreen(this.Kind, _tComma, _arguments, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LexerAnnotationArgumentsBlockGreen Update(__InternalSyntaxToken tComma, AnnotationArgumentGreen arguments)
		{
			if (_tComma != tComma || _arguments != arguments)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LexerAnnotationArgumentsBlock(tComma, arguments);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LexerAnnotationArgumentsBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class AnnotationArgumentBlock1Green : GreenSyntaxNode
	{
		internal static new readonly AnnotationArgumentBlock1Green __Missing = new AnnotationArgumentBlock1Green();
		private IdentifierGreen _namedParameter;
		private __InternalSyntaxToken _tColon;
	
		public AnnotationArgumentBlock1Green(CompilerSyntaxKind kind, IdentifierGreen namedParameter, __InternalSyntaxToken tColon)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (namedParameter != null)
			{
				AdjustFlagsAndWidth(namedParameter);
				_namedParameter = namedParameter;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
		}
	
		public AnnotationArgumentBlock1Green(CompilerSyntaxKind kind, IdentifierGreen namedParameter, __InternalSyntaxToken tColon, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (namedParameter != null)
			{
				AdjustFlagsAndWidth(namedParameter);
				_namedParameter = namedParameter;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
		}
	
		private AnnotationArgumentBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArgumentBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen NamedParameter { get { return _namedParameter; } }
		public __InternalSyntaxToken TColon { get { return _tColon; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.AnnotationArgumentBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _namedParameter;
				case 1: return _tColon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitAnnotationArgumentBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitAnnotationArgumentBlock1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new AnnotationArgumentBlock1Green(this.Kind, _namedParameter, _tColon, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new AnnotationArgumentBlock1Green(this.Kind, _namedParameter, _tColon, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new AnnotationArgumentBlock1Green(this.Kind, _namedParameter, _tColon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public AnnotationArgumentBlock1Green Update(IdentifierGreen namedParameter, __InternalSyntaxToken tColon)
		{
			if (_namedParameter != namedParameter || _tColon != tColon)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgumentBlock1(namedParameter, tColon);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (AnnotationArgumentBlock1Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class MainQualifierBlockGreen : GreenSyntaxNode
	{
		internal static new readonly MainQualifierBlockGreen __Missing = new MainQualifierBlockGreen();
		private __InternalSyntaxToken _tDot;
		private IdentifierGreen _identifier;
	
		public MainQualifierBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tDot, IdentifierGreen identifier)
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
	
		public MainQualifierBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tDot, IdentifierGreen identifier, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
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
	
		private MainQualifierBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.MainQualifierBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TDot { get { return _tDot; } }
		public IdentifierGreen Identifier { get { return _identifier; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.MainQualifierBlockSyntax(this, (CompilerSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainQualifierBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitMainQualifierBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new MainQualifierBlockGreen(this.Kind, _tDot, _identifier, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new MainQualifierBlockGreen(this.Kind, _tDot, _identifier, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new MainQualifierBlockGreen(this.Kind, _tDot, _identifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MainQualifierBlockGreen Update(__InternalSyntaxToken tDot, IdentifierGreen identifier)
		{
			if (_tDot != tDot || _identifier != identifier)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.MainQualifierBlock(tDot, identifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (MainQualifierBlockGreen)newNode;
			}
			return this;
		}
	}
	
	
	internal class AlternativeBlock1Block1Green : GreenSyntaxNode
	{
		internal static new readonly AlternativeBlock1Block1Green __Missing = new AlternativeBlock1Block1Green();
		private __InternalSyntaxToken _kReturns;
		private TypeReferenceGreen _returnType;
	
		public AlternativeBlock1Block1Green(CompilerSyntaxKind kind, __InternalSyntaxToken kReturns, TypeReferenceGreen returnType)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (kReturns != null)
			{
				AdjustFlagsAndWidth(kReturns);
				_kReturns = kReturns;
			}
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
		}
	
		public AlternativeBlock1Block1Green(CompilerSyntaxKind kind, __InternalSyntaxToken kReturns, TypeReferenceGreen returnType, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (kReturns != null)
			{
				AdjustFlagsAndWidth(kReturns);
				_kReturns = kReturns;
			}
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
		}
	
		private AlternativeBlock1Block1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.AlternativeBlock1Block1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KReturns { get { return _kReturns; } }
		public TypeReferenceGreen ReturnType { get { return _returnType; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.AlternativeBlock1Block1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kReturns;
				case 1: return _returnType;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitAlternativeBlock1Block1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitAlternativeBlock1Block1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new AlternativeBlock1Block1Green(this.Kind, _kReturns, _returnType, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new AlternativeBlock1Block1Green(this.Kind, _kReturns, _returnType, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new AlternativeBlock1Block1Green(this.Kind, _kReturns, _returnType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public AlternativeBlock1Block1Green Update(__InternalSyntaxToken kReturns, TypeReferenceGreen returnType)
		{
			if (_kReturns != kReturns || _returnType != returnType)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock1Block1(kReturns, returnType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (AlternativeBlock1Block1Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class TokenBlock1Alt1Block1Green : GreenSyntaxNode
	{
		internal static new readonly TokenBlock1Alt1Block1Green __Missing = new TokenBlock1Alt1Block1Green();
		private __InternalSyntaxToken _kReturns;
		private TypeReferenceGreen _returnType;
	
		public TokenBlock1Alt1Block1Green(CompilerSyntaxKind kind, __InternalSyntaxToken kReturns, TypeReferenceGreen returnType)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (kReturns != null)
			{
				AdjustFlagsAndWidth(kReturns);
				_kReturns = kReturns;
			}
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
		}
	
		public TokenBlock1Alt1Block1Green(CompilerSyntaxKind kind, __InternalSyntaxToken kReturns, TypeReferenceGreen returnType, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (kReturns != null)
			{
				AdjustFlagsAndWidth(kReturns);
				_kReturns = kReturns;
			}
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
		}
	
		private TokenBlock1Alt1Block1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.TokenBlock1Alt1Block1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken KReturns { get { return _kReturns; } }
		public TypeReferenceGreen ReturnType { get { return _returnType; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.TokenBlock1Alt1Block1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kReturns;
				case 1: return _returnType;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTokenBlock1Alt1Block1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitTokenBlock1Alt1Block1Green(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new TokenBlock1Alt1Block1Green(this.Kind, _kReturns, _returnType, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new TokenBlock1Alt1Block1Green(this.Kind, _kReturns, _returnType, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new TokenBlock1Alt1Block1Green(this.Kind, _kReturns, _returnType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TokenBlock1Alt1Block1Green Update(__InternalSyntaxToken kReturns, TypeReferenceGreen returnType)
		{
			if (_kReturns != kReturns || _returnType != returnType)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt1Block1(kReturns, returnType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TokenBlock1Alt1Block1Green)newNode;
			}
			return this;
		}
	}
	
	
	internal class ArrayExpressionItemsBlockGreen : GreenSyntaxNode
	{
		internal static new readonly ArrayExpressionItemsBlockGreen __Missing = new ArrayExpressionItemsBlockGreen();
		private __InternalSyntaxToken _tComma;
		private SingleExpressionGreen _items;
	
		public ArrayExpressionItemsBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tComma, SingleExpressionGreen items)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tComma != null)
			{
				AdjustFlagsAndWidth(tComma);
				_tComma = tComma;
			}
			if (items != null)
			{
				AdjustFlagsAndWidth(items);
				_items = items;
			}
		}
	
		public ArrayExpressionItemsBlockGreen(CompilerSyntaxKind kind, __InternalSyntaxToken tComma, SingleExpressionGreen items, __DiagnosticInfo[] diagnostics, __SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tComma != null)
			{
				AdjustFlagsAndWidth(tComma);
				_tComma = tComma;
			}
			if (items != null)
			{
				AdjustFlagsAndWidth(items);
				_items = items;
			}
		}
	
		private ArrayExpressionItemsBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ArrayExpressionItemsBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public __InternalSyntaxToken TComma { get { return _tComma; } }
		public SingleExpressionGreen Items { get { return _items; } }
	
		protected override __SyntaxNode CreateRed(__SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ArrayExpressionItemsBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override __GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _items;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitArrayExpressionItemsBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitArrayExpressionItemsBlockGreen(this);
	
		public override __InternalSyntaxNode WithDiagnostics(__DiagnosticInfo[] diagnostics)
		{
			return new ArrayExpressionItemsBlockGreen(this.Kind, _tComma, _items, diagnostics, this.GetAnnotations());
		}
	
		public override __InternalSyntaxNode WithAnnotations(__SyntaxAnnotation[] annotations)
		{
			return new ArrayExpressionItemsBlockGreen(this.Kind, _tComma, _items, this.GetDiagnostics(), annotations);
		}
	
		public override __GreenNode Clone()
		{
			return new ArrayExpressionItemsBlockGreen(this.Kind, _tComma, _items, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ArrayExpressionItemsBlockGreen Update(__InternalSyntaxToken tComma, SingleExpressionGreen items)
		{
			if (_tComma != tComma || _items != items)
			{
				__InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpressionItemsBlock(tComma, items);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ArrayExpressionItemsBlockGreen)newNode;
			}
			return this;
		}
	}
	
}
