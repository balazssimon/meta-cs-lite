using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax
{
    using System.Runtime.CompilerServices;
    using MetaDslx.CodeAnalysis;
    using MetaDslx.CodeAnalysis.Syntax;
    using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
    using MetaDslx.CodeAnalysis.Text;
    using Roslyn.Utilities;

    internal abstract class GreenSyntaxNode : InternalSyntaxNode
    {
        protected GreenSyntaxNode(CompilerSyntaxKind kind)
            : base((ushort)kind)
        {
        }

        protected GreenSyntaxNode(CompilerSyntaxKind kind, int fullWidth)
            : base((ushort)kind, fullWidth)
        {
        }

        protected GreenSyntaxNode(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics)
            : base((ushort)kind, diagnostics)
        {
        }

        protected GreenSyntaxNode(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, int fullWidth)
            : base((ushort)kind, diagnostics, fullWidth)
        {
        }

        protected GreenSyntaxNode(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
            : base((ushort)kind, diagnostics, annotations)
        {
        }

        protected GreenSyntaxNode(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations, int fullWidth)
            : base((ushort)kind, diagnostics, annotations, fullWidth)
        {
        }

        public override TResult Accept<TResult>(InternalSyntaxVisitor<TResult> visitor)
        {
            if (visitor is CompilerInternalSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public override void Accept(InternalSyntaxVisitor visitor) 
        {
            if (visitor is CompilerInternalSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor);
        public abstract void Accept(CompilerInternalSyntaxVisitor visitor);

        public override Language Language => CompilerLanguage.Instance;
        public CompilerSyntaxKind Kind => (CompilerSyntaxKind)this.RawKind;
		public override string KindText => CompilerLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		// Use conditional weak table so we always return same identity for structured trivia
		private static readonly ConditionalWeakTable<SyntaxNode, Dictionary<SyntaxTrivia, SyntaxNode>> s_structuresTable
			= new ConditionalWeakTable<SyntaxNode, Dictionary<SyntaxTrivia, SyntaxNode>>();

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
		public override SyntaxNode GetStructure(SyntaxTrivia trivia)
		{
			if (trivia.HasStructure)
			{
				var parent = trivia.Token.Parent;
				if (parent != null)
				{
					SyntaxNode structure;
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

    internal class GreenSyntaxTrivia : InternalSyntaxTrivia
    {
        internal GreenSyntaxTrivia(CompilerSyntaxKind kind, string text, DiagnosticInfo[] diagnostics = null, SyntaxAnnotation[] annotations = null)
            : base((ushort)kind, text, diagnostics, annotations)
        {
        }

		public override Language Language => CompilerLanguage.Instance;
		public CompilerSyntaxKind Kind => (CompilerSyntaxKind)this.RawKind;
		public override string KindText => CompilerLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		internal static GreenSyntaxTrivia Create(CompilerSyntaxKind kind, string text)
        {
            return new GreenSyntaxTrivia(kind, text);
        }

        public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
        {
            return new GreenSyntaxTrivia(this.Kind, this.Text, diagnostics, GetAnnotations());
        }

        public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
        {
            return new GreenSyntaxTrivia(this.Kind, this.Text, GetDiagnostics(), annotations);
        }

        public override GreenNode Clone()
        {
			return new GreenSyntaxTrivia(this.Kind, this.Text, GetDiagnostics(), GetAnnotations());
		}

        public static implicit operator SyntaxTrivia(GreenSyntaxTrivia trivia)
        {
            return new SyntaxTrivia(default, trivia, position: 0, index: 0);
        }
    }

    internal abstract class GreenStructuredTriviaSyntax : GreenSyntaxNode
    {
        internal GreenStructuredTriviaSyntax(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics = null, SyntaxAnnotation[] annotations = null)
            : base(kind, diagnostics, annotations)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            this.flags |= NodeFlags.ContainsStructuredTrivia;

            if (this.RawKind == (int)InternalSyntaxKind.SkippedTokensTrivia)
            {
                this.flags |= NodeFlags.ContainsSkippedText;
            }
        }

        public override bool IsStructuredTrivia => true;
    }

    internal sealed partial class GreenSkippedTokensTriviaSyntax : GreenStructuredTriviaSyntax
    {
        internal readonly GreenNode tokens;

        internal GreenSkippedTokensTriviaSyntax(CompilerSyntaxKind kind, GreenNode tokens, DiagnosticInfo[] diagnostics = null, SyntaxAnnotation[] annotations = null)
            : base(kind, diagnostics, annotations)
        {
            this.SlotCount = 1;
            if (tokens != null)
            {
                this.AdjustFlagsAndWidth(tokens);
                this.tokens = tokens;
            }
        }

        public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<InternalSyntaxToken> Tokens => new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<InternalSyntaxToken>(this.tokens);

        protected override GreenNode GetSlot(int index)
        {
            switch (index)
            {
                case 0: return this.tokens;
                default: return null;
            }
        }

        protected override SyntaxNode CreateRed(SyntaxNode parent, int position) => new CompilerSkippedTokensTriviaSyntax(this, (CompilerSyntaxNode)parent, position);

        public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSkippedTokensTrivia(this);

        public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitSkippedTokensTrivia(this);

        public GreenSkippedTokensTriviaSyntax Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<InternalSyntaxToken> tokens)
        {
            if (tokens != this.Tokens)
            {
                var newNode = Language.InternalSyntaxFactory.SkippedTokensTrivia(tokens.Node);
                var diags = this.GetDiagnostics();
                if (diags != null && diags.Length > 0)
                    newNode = newNode.WithDiagnosticsGreen(diags);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    newNode = newNode.WithAnnotationsGreen(annotations);
                return (GreenSkippedTokensTriviaSyntax)newNode;
            }
            return this;
        }

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new GreenSkippedTokensTriviaSyntax(this.Kind, this.tokens, diagnostics, GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new GreenSkippedTokensTriviaSyntax(this.Kind, this.tokens, GetDiagnostics(), annotations);
		}

        public override GreenNode Clone()
        {
			return new GreenSkippedTokensTriviaSyntax(this.Kind, this.tokens, GetDiagnostics(), GetAnnotations());
		}
    }

	internal partial class GreenSyntaxToken : InternalSyntaxToken
	{
	    //====================
	    // Optimization: Normally, we wouldn't accept this much duplicate code, but these constructors
	    // are called A LOT and we want to keep them as short and simple as possible and increase the
	    // likelihood that they will be inlined.
	    internal GreenSyntaxToken(CompilerSyntaxKind kind)
	        : base((ushort)kind)
	    {
	    }
	    internal GreenSyntaxToken(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics)
	        : base((ushort)kind, diagnostics)
	    {
	    }
	    internal GreenSyntaxToken(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base((ushort)kind, diagnostics, annotations)
	    {
	    }
	    internal GreenSyntaxToken(CompilerSyntaxKind kind, int fullWidth)
	        : base((ushort)kind, fullWidth)
	    {
	    }
	    internal GreenSyntaxToken(CompilerSyntaxKind kind, int fullWidth, DiagnosticInfo[] diagnostics)
	        : base((ushort)kind, fullWidth, diagnostics)
	    {
	    }
	    internal GreenSyntaxToken(CompilerSyntaxKind kind, int fullWidth, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base((ushort)kind, fullWidth, diagnostics, annotations)
	    {
	    }

	    public override Language Language => CompilerLanguage.Instance;
	    public CompilerSyntaxKind Kind => (CompilerSyntaxKind)this.RawKind;
		public override string KindText => CompilerLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		//====================
		internal static GreenSyntaxToken Create(CompilerSyntaxKind kind)
	    {
	        if (kind > LastTokenWithWellKnownText)
	        {
	            if (!CompilerLanguage.Instance.SyntaxFacts.IsToken(kind))
	            {
	                throw new ArgumentException(string.Format("Invalid CompilerSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
	            }
	            return CreateMissing(kind, null, null);
	        }
	        return s_tokensWithNoTrivia[(int)kind].Value;
	    }
	    internal static GreenSyntaxToken Create(CompilerSyntaxKind kind, GreenNode? leading, GreenNode? trailing)
	    {
	        if (kind > LastTokenWithWellKnownText)
	        {
	            if (!CompilerLanguage.Instance.SyntaxFacts.IsToken(kind))
	            {
	                throw new ArgumentException(string.Format("Invalid CompilerSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
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
	    internal static GreenSyntaxToken CreateMissing(CompilerSyntaxKind kind, GreenNode? leading, GreenNode? trailing)
	    {
	        return new MissingTokenWithTrivia(kind, leading, trailing);
	    }
	    internal static readonly CompilerSyntaxKind FirstTokenWithWellKnownText;
	    internal static readonly CompilerSyntaxKind LastTokenWithWellKnownText;
	    // TODO: eliminate the blank space before the first interesting element?
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithNoTrivia;
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithElasticTrivia;
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingSpace;
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingCRLF;
	    static GreenSyntaxToken()
	    {
	        FirstTokenWithWellKnownText = CompilerSyntaxKind.__FirstFixedToken;
	        LastTokenWithWellKnownText = CompilerSyntaxKind.__LastFixedToken;
	        s_tokensWithNoTrivia = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithElasticTrivia = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithSingleTrailingSpace = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithSingleTrailingCRLF = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
			InternalSyntaxFactory factory = CompilerLanguage.Instance.InternalSyntaxFactory;
	        for (CompilerSyntaxKind kind = FirstTokenWithWellKnownText; kind <= LastTokenWithWellKnownText; kind++)
	        {
	            s_tokensWithNoTrivia[(int)kind].Value = new GreenSyntaxToken((CompilerSyntaxKind)kind);
	            s_tokensWithElasticTrivia[(int)kind].Value = new SyntaxTokenWithTrivia((CompilerSyntaxKind)kind, factory.ElasticZeroSpace, factory.ElasticZeroSpace);
	            s_tokensWithSingleTrailingSpace[(int)kind].Value = new SyntaxTokenWithTrivia((CompilerSyntaxKind)kind, null, factory.Space);
	            s_tokensWithSingleTrailingCRLF[(int)kind].Value = new SyntaxTokenWithTrivia((CompilerSyntaxKind)kind, null, factory.CarriageReturnLineFeed);
	        }
	    }
	    internal static IEnumerable<GreenSyntaxToken> GetWellKnownTokens()
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
	    internal static GreenSyntaxToken Identifier(CompilerSyntaxKind kind, GreenNode leading, string text, GreenNode trailing)
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
	    internal static GreenSyntaxToken Identifier(CompilerSyntaxKind kind, CompilerSyntaxKind contextualKind, GreenNode leading, string text, string valueText, GreenNode trailing)
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
	    internal static GreenSyntaxToken WithValue<T>(CompilerSyntaxKind kind, GreenNode? leading, string text, T value, GreenNode? trailing)
	    {
	        return new SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing);
	    }
	    public new virtual CompilerSyntaxKind ContextualKind => this.Kind;
	    public override int RawContextualKind => (int)this.ContextualKind;
        public override GreenNode WithLeadingTrivia(GreenNode? trivia)
        {
            return TokenWithLeadingTrivia(trivia);
        }
		public override GreenNode WithTrailingTrivia(GreenNode? trivia)
		{
			return TokenWithTrailingTrivia(trivia);
		}
		public virtual InternalSyntaxToken TokenWithLeadingTrivia(GreenNode? trivia)
	    {
	        return new SyntaxTokenWithTrivia(this.Kind, trivia, null, this.GetDiagnostics(), this.GetAnnotations());
	    }
	    public virtual InternalSyntaxToken TokenWithTrailingTrivia(GreenNode? trivia)
	    {
	        return new SyntaxTokenWithTrivia(this.Kind, null, trivia, this.GetDiagnostics(), this.GetAnnotations());
	    }
	    public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
	    {
	        System.Diagnostics.Debug.Assert(this.GetType() == typeof(GreenSyntaxToken));
	        return new GreenSyntaxToken(this.Kind, this.FullWidth, diagnostics, this.GetAnnotations());
	    }
	    public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
	    {
	        System.Diagnostics.Debug.Assert(this.GetType() == typeof(GreenSyntaxToken));
	        return new GreenSyntaxToken(this.Kind, this.FullWidth, this.GetDiagnostics(), annotations);
	    }
		public override GreenNode Clone()
		{
	        System.Diagnostics.Debug.Assert(this.GetType() == typeof(GreenSyntaxToken));
			return new GreenSyntaxToken(this.Kind, this.FullWidth, GetDiagnostics(), GetAnnotations());
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
	        internal MissingTokenWithTrivia(CompilerSyntaxKind kind, GreenNode? leading, GreenNode? trailing)
	            : base(kind, leading, trailing)
	        {
	            this.flags &= ~NodeFlags.IsNotMissing;
	        }
	        internal MissingTokenWithTrivia(CompilerSyntaxKind kind, GreenNode? leading, GreenNode? trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	        public override InternalSyntaxToken TokenWithLeadingTrivia(GreenNode? trivia)
	        {
	            return new MissingTokenWithTrivia(this.Kind, trivia, this.TrailingField, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxToken TokenWithTrailingTrivia(GreenNode? trivia)
	        {
	            return new MissingTokenWithTrivia(this.Kind, this.LeadingField, trivia, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
	        {
	            return new MissingTokenWithTrivia(this.Kind, this.LeadingField, this.TrailingField, diagnostics, this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
	        {
	            return new MissingTokenWithTrivia(this.Kind, this.LeadingField, this.TrailingField, this.GetDiagnostics(), annotations);
	        }
		    public override GreenNode Clone()
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
	        internal SyntaxIdentifier(CompilerSyntaxKind kind, string text, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	        public override InternalSyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
	        {
	            return new SyntaxIdentifierWithTrivia(this.Kind, this.ContextualKind, this.TextField, this.TextField, trivia, null, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
	        {
	            return new SyntaxIdentifierWithTrivia(this.Kind, this.ContextualKind, this.TextField, this.TextField, null, trivia, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
	        {
	            return new SyntaxIdentifier(this.Kind, this.Text, diagnostics, this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
	        {
	            return new SyntaxIdentifier(this.Kind, this.Text, this.GetDiagnostics(), annotations);
	        }
		    public override GreenNode Clone()
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
	        internal SyntaxIdentifierExtended(CompilerSyntaxKind kind, CompilerSyntaxKind contextualKind, string text, string valueText, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	        public override InternalSyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
	        {
	            return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, trivia, null, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
	        {
	            return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, null, trivia, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
	        {
	            return new SyntaxIdentifierExtended(this.Kind, this.contextualKind, this.TextField, this.valueText, diagnostics, this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
	        {
	            return new SyntaxIdentifierExtended(this.Kind, this.contextualKind, this.TextField, this.valueText, this.GetDiagnostics(), annotations);
	        }
		    public override GreenNode Clone()
		    {
			    return new SyntaxIdentifierExtended(this.Kind, this.contextualKind, this.TextField, this.valueText, this.GetDiagnostics(), this.GetAnnotations());
		    }
	    }
	
		internal class SyntaxIdentifierWithTrailingTrivia : SyntaxIdentifier
	    {
	        private readonly GreenNode? _trailing;
	        internal SyntaxIdentifierWithTrailingTrivia(CompilerSyntaxKind kind, string text, GreenNode? trailing)
	            : base(kind, text)
	        {
	            if (trailing != null)
	            {
	                this.AdjustFlagsAndWidth(trailing);
	                _trailing = trailing;
	            }
	        }
	        internal SyntaxIdentifierWithTrailingTrivia(CompilerSyntaxKind kind, string text, GreenNode? trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	            : base(kind, text, diagnostics, annotations)
	        {
	            if (trailing != null)
	            {
	                this.AdjustFlagsAndWidth(trailing);
	                _trailing = trailing;
	            }
	        }
	        public override GreenNode? GetTrailingTrivia()
	        {
	            return _trailing;
	        }
	        public override InternalSyntaxToken TokenWithLeadingTrivia(GreenNode? trivia)
	        {
	            return new SyntaxIdentifierWithTrivia(this.Kind, this.ContextualKind, this.TextField, this.TextField, trivia, _trailing, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxToken TokenWithTrailingTrivia(GreenNode? trivia)
	        {
	            return new SyntaxIdentifierWithTrailingTrivia(this.Kind, this.TextField, trivia, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
	        {
	            return new SyntaxIdentifierWithTrailingTrivia(this.Kind, this.TextField, _trailing, diagnostics, this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
	        {
	            return new SyntaxIdentifierWithTrailingTrivia(this.Kind, this.TextField, _trailing, this.GetDiagnostics(), annotations);
	        }
		    public override GreenNode Clone()
		    {
			    return new SyntaxIdentifierWithTrailingTrivia(this.Kind, this.TextField, _trailing, this.GetDiagnostics(), this.GetAnnotations());
		    }
	    }
	
	    internal class SyntaxIdentifierWithTrivia : SyntaxIdentifierExtended
	    {
	        private readonly GreenNode? _leading;
	        private readonly GreenNode? _trailing;
	        internal SyntaxIdentifierWithTrivia(
	            CompilerSyntaxKind kind,
	            CompilerSyntaxKind contextualKind,
	            string text,
	            string valueText,
	            GreenNode? leading,
	            GreenNode? trailing)
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
	            GreenNode? leading,
	            GreenNode? trailing,
	            DiagnosticInfo[] diagnostics,
	            SyntaxAnnotation[] annotations)
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
	        public override GreenNode? GetLeadingTrivia()
	        {
	            return _leading;
	        }
	        public override GreenNode? GetTrailingTrivia()
	        {
	            return _trailing;
	        }
	        public override InternalSyntaxToken TokenWithLeadingTrivia(GreenNode? trivia)
	        {
	            return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, trivia, _trailing, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxToken TokenWithTrailingTrivia(GreenNode? trivia)
	        {
	            return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, _leading, trivia, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
	        {
	            return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, _leading, _trailing, diagnostics, this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
	        {
	            return new SyntaxIdentifierWithTrivia(this.Kind, this.contextualKind, this.TextField, this.valueText, _leading, _trailing, this.GetDiagnostics(), annotations);
	        }
		    public override GreenNode Clone()
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
	        internal SyntaxTokenWithValue(CompilerSyntaxKind kind, string text, T value, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	                return Convert.ToString(this.ValueField, CultureInfo.InvariantCulture);
	            }
	        }
	        public override InternalSyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
	        {
	            return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, trivia, null, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
	        {
	            return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, null, trivia, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
	        {
	            return new SyntaxTokenWithValue<T>(this.Kind, this.TextField, this.ValueField, diagnostics, this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
	        {
	            return new SyntaxTokenWithValue<T>(this.Kind, this.TextField, this.ValueField, this.GetDiagnostics(), annotations);
	        }
		    public override GreenNode Clone()
		    {
			    return new SyntaxTokenWithValue<T>(this.Kind, this.TextField, this.ValueField, this.GetDiagnostics(), this.GetAnnotations());
		    }
	    }
	
	    internal class SyntaxTokenWithValueAndTrivia<T> : SyntaxTokenWithValue<T>
	    {
	        private readonly GreenNode? _leading;
	        private readonly GreenNode? _trailing;
	        internal SyntaxTokenWithValueAndTrivia(CompilerSyntaxKind kind, string text, T value, GreenNode? leading, GreenNode? trailing)
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
	            GreenNode? leading,
	            GreenNode? trailing,
	            DiagnosticInfo[] diagnostics,
	            SyntaxAnnotation[] annotations)
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
	        public override GreenNode? GetLeadingTrivia()
	        {
	            return _leading;
	        }
	        public override GreenNode? GetTrailingTrivia()
	        {
	            return _trailing;
	        }
	        public override InternalSyntaxToken TokenWithLeadingTrivia(GreenNode? trivia)
	        {
	            return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, trivia, _trailing, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxToken TokenWithTrailingTrivia(GreenNode? trivia)
	        {
	            return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, _leading, trivia, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
	        {
	            return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, _leading, _trailing, diagnostics, this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
	        {
	            return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, _leading, _trailing, this.GetDiagnostics(), annotations);
	        }
		    public override GreenNode Clone()
		    {
			    return new SyntaxTokenWithValueAndTrivia<T>(this.Kind, this.TextField, this.ValueField, _leading, _trailing, this.GetDiagnostics(), this.GetAnnotations());
		    }
	    }
	
	    internal class SyntaxTokenWithTrivia : GreenSyntaxToken
	    {
	        protected readonly GreenNode? LeadingField;
	        protected readonly GreenNode? TrailingField;
	        internal SyntaxTokenWithTrivia(CompilerSyntaxKind kind, GreenNode? leading, GreenNode? trailing)
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
	        internal SyntaxTokenWithTrivia(CompilerSyntaxKind kind, GreenNode? leading, GreenNode? trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	        public override GreenNode? GetLeadingTrivia()
	        {
	            return this.LeadingField;
	        }
	        public override GreenNode? GetTrailingTrivia()
	        {
	            return this.TrailingField;
	        }
	        public override InternalSyntaxToken TokenWithLeadingTrivia(GreenNode? trivia)
	        {
	            return new SyntaxTokenWithTrivia(this.Kind, trivia, this.TrailingField, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxToken TokenWithTrailingTrivia(GreenNode? trivia)
	        {
	            return new SyntaxTokenWithTrivia(this.Kind, this.LeadingField, trivia, this.GetDiagnostics(), this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
	        {
	            return new SyntaxTokenWithTrivia(this.Kind, this.LeadingField, this.TrailingField, diagnostics, this.GetAnnotations());
	        }
	        public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
	        {
	            return new SyntaxTokenWithTrivia(this.Kind, this.LeadingField, this.TrailingField, this.GetDiagnostics(), annotations);
	        }
		    public override GreenNode Clone()
		    {
			    return new SyntaxTokenWithTrivia(this.Kind, this.LeadingField, this.TrailingField, this.GetDiagnostics(), this.GetAnnotations());
		    }
	    }
	}

	internal class MainGreen : GreenSyntaxNode
	{
		internal static new readonly MainGreen __Missing = new MainGreen();
		private InternalSyntaxToken _kNamespace;
		private QualifierGreen _qualifier;
		private InternalSyntaxToken _tSemicolon;
		private GreenNode _using;
		private DeclarationsGreen _declarations;
		private InternalSyntaxToken _eof;
	
		public MainGreen(CompilerSyntaxKind kind, InternalSyntaxToken kNamespace, QualifierGreen qualifier, InternalSyntaxToken tSemicolon, GreenNode @using, DeclarationsGreen declarations, InternalSyntaxToken eof)
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
			if (@using != null)
			{
				AdjustFlagsAndWidth(@using);
				_using = @using;
			}
			if (declarations != null)
			{
				AdjustFlagsAndWidth(declarations);
				_declarations = declarations;
			}
			if (eof != null)
			{
				AdjustFlagsAndWidth(eof);
				_eof = eof;
			}
		}
	
		public MainGreen(CompilerSyntaxKind kind, InternalSyntaxToken kNamespace, QualifierGreen qualifier, InternalSyntaxToken tSemicolon, GreenNode @using, DeclarationsGreen declarations, InternalSyntaxToken eof, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			if (@using != null)
			{
				AdjustFlagsAndWidth(@using);
				_using = @using;
			}
			if (declarations != null)
			{
				AdjustFlagsAndWidth(declarations);
				_declarations = declarations;
			}
			if (eof != null)
			{
				AdjustFlagsAndWidth(eof);
				_eof = eof;
			}
		}
	
		private MainGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Main, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KNamespace { get { return _kNamespace; } }
		public QualifierGreen Qualifier { get { return _qualifier; } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> Using { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen>(_using); } }
		public DeclarationsGreen Declarations { get { return _declarations; } }
		public InternalSyntaxToken EndOfFileToken { get { return _eof; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.MainSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kNamespace;
				case 1: return _qualifier;
				case 2: return _tSemicolon;
				case 3: return _using;
				case 4: return _declarations;
				case 5: return _eof;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitMainGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MainGreen(this.Kind, _kNamespace, _qualifier, _tSemicolon, _using, _declarations, _eof, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MainGreen(this.Kind, _kNamespace, _qualifier, _tSemicolon, _using, _declarations, _eof, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new MainGreen(this.Kind, _kNamespace, _qualifier, _tSemicolon, _using, _declarations, _eof, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MainGreen Update(InternalSyntaxToken kNamespace, QualifierGreen qualifier, InternalSyntaxToken tSemicolon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> @using, DeclarationsGreen declarations, InternalSyntaxToken eof)
		{
			if (_kNamespace != kNamespace || _qualifier != qualifier || _tSemicolon != tSemicolon || _using != @using.Node || _declarations != declarations || _eof != eof)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Main((InternalSyntaxToken)kNamespace, qualifier, (InternalSyntaxToken)tSemicolon, @using, declarations, (InternalSyntaxToken)eof);
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
		private InternalSyntaxToken _kUsing;
		private UsingBlock1Green _usingBlock1;
		private InternalSyntaxToken _tSemicolon;
	
		public UsingGreen(CompilerSyntaxKind kind, InternalSyntaxToken kUsing, UsingBlock1Green usingBlock1, InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (kUsing != null)
			{
				AdjustFlagsAndWidth(kUsing);
				_kUsing = kUsing;
			}
			if (usingBlock1 != null)
			{
				AdjustFlagsAndWidth(usingBlock1);
				_usingBlock1 = usingBlock1;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		public UsingGreen(CompilerSyntaxKind kind, InternalSyntaxToken kUsing, UsingBlock1Green usingBlock1, InternalSyntaxToken tSemicolon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (kUsing != null)
			{
				AdjustFlagsAndWidth(kUsing);
				_kUsing = kUsing;
			}
			if (usingBlock1 != null)
			{
				AdjustFlagsAndWidth(usingBlock1);
				_usingBlock1 = usingBlock1;
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
	
		public InternalSyntaxToken KUsing { get { return _kUsing; } }
		public UsingBlock1Green UsingBlock1 { get { return _usingBlock1; } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.UsingSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kUsing;
				case 1: return _usingBlock1;
				case 2: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitUsingGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitUsingGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new UsingGreen(this.Kind, _kUsing, _usingBlock1, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new UsingGreen(this.Kind, _kUsing, _usingBlock1, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new UsingGreen(this.Kind, _kUsing, _usingBlock1, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public UsingGreen Update(InternalSyntaxToken kUsing, UsingBlock1Green usingBlock1, InternalSyntaxToken tSemicolon)
		{
			if (_kUsing != kUsing || _usingBlock1 != usingBlock1 || _tSemicolon != tSemicolon)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Using((InternalSyntaxToken)kUsing, usingBlock1, (InternalSyntaxToken)tSemicolon);
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
		private LanguageDeclarationGreen _declarations;
		private GreenNode _declarations1;
	
		public DeclarationsGreen(CompilerSyntaxKind kind, LanguageDeclarationGreen declarations, GreenNode declarations1)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (declarations != null)
			{
				AdjustFlagsAndWidth(declarations);
				_declarations = declarations;
			}
			if (declarations1 != null)
			{
				AdjustFlagsAndWidth(declarations1);
				_declarations1 = declarations1;
			}
		}
	
		public DeclarationsGreen(CompilerSyntaxKind kind, LanguageDeclarationGreen declarations, GreenNode declarations1, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (declarations != null)
			{
				AdjustFlagsAndWidth(declarations);
				_declarations = declarations;
			}
			if (declarations1 != null)
			{
				AdjustFlagsAndWidth(declarations1);
				_declarations1 = declarations1;
			}
		}
	
		private DeclarationsGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Declarations, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public LanguageDeclarationGreen Declarations { get { return _declarations; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<RuleGreen> Declarations1 { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<RuleGreen>(_declarations1); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.DeclarationsSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _declarations;
				case 1: return _declarations1;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitDeclarationsGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitDeclarationsGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new DeclarationsGreen(this.Kind, _declarations, _declarations1, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new DeclarationsGreen(this.Kind, _declarations, _declarations1, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new DeclarationsGreen(this.Kind, _declarations, _declarations1, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public DeclarationsGreen Update(LanguageDeclarationGreen declarations, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<RuleGreen> declarations1)
		{
			if (_declarations != declarations || _declarations1 != declarations1.Node)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Declarations(declarations, declarations1);
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
	
	internal class LanguageDeclarationGreen : GreenSyntaxNode
	{
		internal static new readonly LanguageDeclarationGreen __Missing = new LanguageDeclarationGreen();
		private InternalSyntaxToken _kLanguage;
		private NameGreen _name;
		private InternalSyntaxToken _tSemicolon;
	
		public LanguageDeclarationGreen(CompilerSyntaxKind kind, InternalSyntaxToken kLanguage, NameGreen name, InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 3;
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
		}
	
		public LanguageDeclarationGreen(CompilerSyntaxKind kind, InternalSyntaxToken kLanguage, NameGreen name, InternalSyntaxToken tSemicolon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
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
		}
	
		private LanguageDeclarationGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LanguageDeclaration, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KLanguage { get { return _kLanguage; } }
		public NameGreen Name { get { return _name; } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LanguageDeclarationSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kLanguage;
				case 1: return _name;
				case 2: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLanguageDeclarationGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLanguageDeclarationGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LanguageDeclarationGreen(this.Kind, _kLanguage, _name, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LanguageDeclarationGreen(this.Kind, _kLanguage, _name, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LanguageDeclarationGreen(this.Kind, _kLanguage, _name, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LanguageDeclarationGreen Update(InternalSyntaxToken kLanguage, NameGreen name, InternalSyntaxToken tSemicolon)
		{
			if (_kLanguage != kLanguage || _name != name || _tSemicolon != tSemicolon)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LanguageDeclaration((InternalSyntaxToken)kLanguage, name, (InternalSyntaxToken)tSemicolon);
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
	
	internal abstract class RuleGreen : GreenSyntaxNode
	{
		internal static readonly RuleGreen __Missing = ParserRuleGreen.__Missing;
	
	    protected RuleGreen(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class ParserRuleGreen : RuleGreen
	{
		internal static new readonly ParserRuleGreen __Missing = new ParserRuleGreen();
		private NameGreen _name;
		private ParserRuleBlock1Green _parserRuleBlock1;
		private InternalSyntaxToken _tColon;
		private GreenNode _parserRuleAlternativeList;
		private InternalSyntaxToken _tSemicolon;
	
		public ParserRuleGreen(CompilerSyntaxKind kind, NameGreen name, ParserRuleBlock1Green parserRuleBlock1, InternalSyntaxToken tColon, GreenNode parserRuleAlternativeList, InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 5;
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
			if (parserRuleBlock1 != null)
			{
				AdjustFlagsAndWidth(parserRuleBlock1);
				_parserRuleBlock1 = parserRuleBlock1;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
			if (parserRuleAlternativeList != null)
			{
				AdjustFlagsAndWidth(parserRuleAlternativeList);
				_parserRuleAlternativeList = parserRuleAlternativeList;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		public ParserRuleGreen(CompilerSyntaxKind kind, NameGreen name, ParserRuleBlock1Green parserRuleBlock1, InternalSyntaxToken tColon, GreenNode parserRuleAlternativeList, InternalSyntaxToken tSemicolon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 5;
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
			if (parserRuleBlock1 != null)
			{
				AdjustFlagsAndWidth(parserRuleBlock1);
				_parserRuleBlock1 = parserRuleBlock1;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
			if (parserRuleAlternativeList != null)
			{
				AdjustFlagsAndWidth(parserRuleAlternativeList);
				_parserRuleAlternativeList = parserRuleAlternativeList;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		private ParserRuleGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ParserRule, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public NameGreen Name { get { return _name; } }
		public ParserRuleBlock1Green ParserRuleBlock1 { get { return _parserRuleBlock1; } }
		public InternalSyntaxToken TColon { get { return _tColon; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParserRuleAlternativeGreen> ParserRuleAlternativeList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParserRuleAlternativeGreen>(_parserRuleAlternativeList, reversed: false); } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserRuleSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _name;
				case 1: return _parserRuleBlock1;
				case 2: return _tColon;
				case 3: return _parserRuleAlternativeList;
				case 4: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserRuleGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserRuleGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParserRuleGreen(this.Kind, _name, _parserRuleBlock1, _tColon, _parserRuleAlternativeList, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParserRuleGreen(this.Kind, _name, _parserRuleBlock1, _tColon, _parserRuleAlternativeList, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ParserRuleGreen(this.Kind, _name, _parserRuleBlock1, _tColon, _parserRuleAlternativeList, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserRuleGreen Update(NameGreen name, ParserRuleBlock1Green parserRuleBlock1, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParserRuleAlternativeGreen> parserRuleAlternativeList, InternalSyntaxToken tSemicolon)
		{
			if (_name != name || _parserRuleBlock1 != parserRuleBlock1 || _tColon != tColon || _parserRuleAlternativeList != parserRuleAlternativeList.Node || _tSemicolon != tSemicolon)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserRule(name, parserRuleBlock1, (InternalSyntaxToken)tColon, parserRuleAlternativeList, (InternalSyntaxToken)tSemicolon);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleGreen)newNode;
			}
			return this;
		}
	}
	
	internal class BlockRuleGreen : RuleGreen
	{
		internal static new readonly BlockRuleGreen __Missing = new BlockRuleGreen();
		private InternalSyntaxToken _isBlock;
		private NameGreen _name;
		private InternalSyntaxToken _tColon;
		private GreenNode _parserRuleAlternativeList;
		private InternalSyntaxToken _tSemicolon;
	
		public BlockRuleGreen(CompilerSyntaxKind kind, InternalSyntaxToken isBlock, NameGreen name, InternalSyntaxToken tColon, GreenNode parserRuleAlternativeList, InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 5;
			if (isBlock != null)
			{
				AdjustFlagsAndWidth(isBlock);
				_isBlock = isBlock;
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
			if (parserRuleAlternativeList != null)
			{
				AdjustFlagsAndWidth(parserRuleAlternativeList);
				_parserRuleAlternativeList = parserRuleAlternativeList;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		public BlockRuleGreen(CompilerSyntaxKind kind, InternalSyntaxToken isBlock, NameGreen name, InternalSyntaxToken tColon, GreenNode parserRuleAlternativeList, InternalSyntaxToken tSemicolon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 5;
			if (isBlock != null)
			{
				AdjustFlagsAndWidth(isBlock);
				_isBlock = isBlock;
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
			if (parserRuleAlternativeList != null)
			{
				AdjustFlagsAndWidth(parserRuleAlternativeList);
				_parserRuleAlternativeList = parserRuleAlternativeList;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		private BlockRuleGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.BlockRule, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken IsBlock { get { return _isBlock; } }
		public NameGreen Name { get { return _name; } }
		public InternalSyntaxToken TColon { get { return _tColon; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParserRuleAlternativeGreen> ParserRuleAlternativeList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParserRuleAlternativeGreen>(_parserRuleAlternativeList, reversed: false); } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.BlockRuleSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _isBlock;
				case 1: return _name;
				case 2: return _tColon;
				case 3: return _parserRuleAlternativeList;
				case 4: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBlockRuleGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitBlockRuleGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new BlockRuleGreen(this.Kind, _isBlock, _name, _tColon, _parserRuleAlternativeList, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new BlockRuleGreen(this.Kind, _isBlock, _name, _tColon, _parserRuleAlternativeList, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new BlockRuleGreen(this.Kind, _isBlock, _name, _tColon, _parserRuleAlternativeList, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public BlockRuleGreen Update(InternalSyntaxToken isBlock, NameGreen name, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParserRuleAlternativeGreen> parserRuleAlternativeList, InternalSyntaxToken tSemicolon)
		{
			if (_isBlock != isBlock || _name != name || _tColon != tColon || _parserRuleAlternativeList != parserRuleAlternativeList.Node || _tSemicolon != tSemicolon)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.BlockRule((InternalSyntaxToken)isBlock, name, (InternalSyntaxToken)tColon, parserRuleAlternativeList, (InternalSyntaxToken)tSemicolon);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (BlockRuleGreen)newNode;
			}
			return this;
		}
	}
	
	internal class ParserRuleAlternativeGreen : GreenSyntaxNode
	{
		internal static new readonly ParserRuleAlternativeGreen __Missing = new ParserRuleAlternativeGreen();
		private ParserRuleAlternativeBlock1Green _parserRuleAlternativeBlock1;
		private GreenNode _elements;
		private ParserRuleAlternativeBlock2Green _parserRuleAlternativeBlock2;
	
		public ParserRuleAlternativeGreen(CompilerSyntaxKind kind, ParserRuleAlternativeBlock1Green parserRuleAlternativeBlock1, GreenNode elements, ParserRuleAlternativeBlock2Green parserRuleAlternativeBlock2)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (parserRuleAlternativeBlock1 != null)
			{
				AdjustFlagsAndWidth(parserRuleAlternativeBlock1);
				_parserRuleAlternativeBlock1 = parserRuleAlternativeBlock1;
			}
			if (elements != null)
			{
				AdjustFlagsAndWidth(elements);
				_elements = elements;
			}
			if (parserRuleAlternativeBlock2 != null)
			{
				AdjustFlagsAndWidth(parserRuleAlternativeBlock2);
				_parserRuleAlternativeBlock2 = parserRuleAlternativeBlock2;
			}
		}
	
		public ParserRuleAlternativeGreen(CompilerSyntaxKind kind, ParserRuleAlternativeBlock1Green parserRuleAlternativeBlock1, GreenNode elements, ParserRuleAlternativeBlock2Green parserRuleAlternativeBlock2, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (parserRuleAlternativeBlock1 != null)
			{
				AdjustFlagsAndWidth(parserRuleAlternativeBlock1);
				_parserRuleAlternativeBlock1 = parserRuleAlternativeBlock1;
			}
			if (elements != null)
			{
				AdjustFlagsAndWidth(elements);
				_elements = elements;
			}
			if (parserRuleAlternativeBlock2 != null)
			{
				AdjustFlagsAndWidth(parserRuleAlternativeBlock2);
				_parserRuleAlternativeBlock2 = parserRuleAlternativeBlock2;
			}
		}
	
		private ParserRuleAlternativeGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleAlternative, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public ParserRuleAlternativeBlock1Green ParserRuleAlternativeBlock1 { get { return _parserRuleAlternativeBlock1; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserRuleElementGreen> Elements { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserRuleElementGreen>(_elements); } }
		public ParserRuleAlternativeBlock2Green ParserRuleAlternativeBlock2 { get { return _parserRuleAlternativeBlock2; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserRuleAlternativeSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _parserRuleAlternativeBlock1;
				case 1: return _elements;
				case 2: return _parserRuleAlternativeBlock2;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserRuleAlternativeGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserRuleAlternativeGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParserRuleAlternativeGreen(this.Kind, _parserRuleAlternativeBlock1, _elements, _parserRuleAlternativeBlock2, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParserRuleAlternativeGreen(this.Kind, _parserRuleAlternativeBlock1, _elements, _parserRuleAlternativeBlock2, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ParserRuleAlternativeGreen(this.Kind, _parserRuleAlternativeBlock1, _elements, _parserRuleAlternativeBlock2, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserRuleAlternativeGreen Update(ParserRuleAlternativeBlock1Green parserRuleAlternativeBlock1, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserRuleElementGreen> elements, ParserRuleAlternativeBlock2Green parserRuleAlternativeBlock2)
		{
			if (_parserRuleAlternativeBlock1 != parserRuleAlternativeBlock1 || _elements != elements.Node || _parserRuleAlternativeBlock2 != parserRuleAlternativeBlock2)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleAlternative(parserRuleAlternativeBlock1, elements, parserRuleAlternativeBlock2);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleAlternativeGreen)newNode;
			}
			return this;
		}
	}
	
	internal class ParserRuleElementGreen : GreenSyntaxNode
	{
		internal static new readonly ParserRuleElementGreen __Missing = new ParserRuleElementGreen();
		private NameGreen _name;
	
		public ParserRuleElementGreen(CompilerSyntaxKind kind, NameGreen name)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
		}
	
		public ParserRuleElementGreen(CompilerSyntaxKind kind, NameGreen name, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
		}
	
		private ParserRuleElementGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleElement, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public NameGreen Name { get { return _name; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserRuleElementSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _name;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserRuleElementGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserRuleElementGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParserRuleElementGreen(this.Kind, _name, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParserRuleElementGreen(this.Kind, _name, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ParserRuleElementGreen(this.Kind, _name, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserRuleElementGreen Update(NameGreen name)
		{
			if (_name != name)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleElement(name);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleElementGreen)newNode;
			}
			return this;
		}
	}
	
	internal abstract class ExpressionGreen : GreenSyntaxNode
	{
		internal static readonly ExpressionGreen __Missing = IntExpressionGreen.__Missing;
	
	    protected ExpressionGreen(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class IntExpressionGreen : ExpressionGreen
	{
		internal static new readonly IntExpressionGreen __Missing = new IntExpressionGreen();
		private InternalSyntaxToken _intValue;
	
		public IntExpressionGreen(CompilerSyntaxKind kind, InternalSyntaxToken intValue)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (intValue != null)
			{
				AdjustFlagsAndWidth(intValue);
				_intValue = intValue;
			}
		}
	
		public IntExpressionGreen(CompilerSyntaxKind kind, InternalSyntaxToken intValue, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (intValue != null)
			{
				AdjustFlagsAndWidth(intValue);
				_intValue = intValue;
			}
		}
	
		private IntExpressionGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.IntExpression, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken IntValue { get { return _intValue; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.IntExpressionSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _intValue;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitIntExpressionGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitIntExpressionGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new IntExpressionGreen(this.Kind, _intValue, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new IntExpressionGreen(this.Kind, _intValue, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new IntExpressionGreen(this.Kind, _intValue, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public IntExpressionGreen Update(InternalSyntaxToken intValue)
		{
			if (_intValue != intValue)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.IntExpression((InternalSyntaxToken)intValue);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (IntExpressionGreen)newNode;
			}
			return this;
		}
	}
	
	internal class StringExpressionGreen : ExpressionGreen
	{
		internal static new readonly StringExpressionGreen __Missing = new StringExpressionGreen();
		private InternalSyntaxToken _stringValue;
	
		public StringExpressionGreen(CompilerSyntaxKind kind, InternalSyntaxToken stringValue)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (stringValue != null)
			{
				AdjustFlagsAndWidth(stringValue);
				_stringValue = stringValue;
			}
		}
	
		public StringExpressionGreen(CompilerSyntaxKind kind, InternalSyntaxToken stringValue, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (stringValue != null)
			{
				AdjustFlagsAndWidth(stringValue);
				_stringValue = stringValue;
			}
		}
	
		private StringExpressionGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.StringExpression, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken StringValue { get { return _stringValue; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.StringExpressionSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _stringValue;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitStringExpressionGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitStringExpressionGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new StringExpressionGreen(this.Kind, _stringValue, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new StringExpressionGreen(this.Kind, _stringValue, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new StringExpressionGreen(this.Kind, _stringValue, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public StringExpressionGreen Update(InternalSyntaxToken stringValue)
		{
			if (_stringValue != stringValue)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.StringExpression((InternalSyntaxToken)stringValue);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (StringExpressionGreen)newNode;
			}
			return this;
		}
	}
	
	internal class ReferenceExpressionGreen : ExpressionGreen
	{
		internal static new readonly ReferenceExpressionGreen __Missing = new ReferenceExpressionGreen();
		private QualifierGreen _qualifier;
	
		public ReferenceExpressionGreen(CompilerSyntaxKind kind, QualifierGreen qualifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		public ReferenceExpressionGreen(CompilerSyntaxKind kind, QualifierGreen qualifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		private ReferenceExpressionGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ReferenceExpression, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public QualifierGreen Qualifier { get { return _qualifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ReferenceExpressionSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _qualifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitReferenceExpressionGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitReferenceExpressionGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ReferenceExpressionGreen(this.Kind, _qualifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ReferenceExpressionGreen(this.Kind, _qualifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ReferenceExpressionGreen(this.Kind, _qualifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ReferenceExpressionGreen Update(QualifierGreen qualifier)
		{
			if (_qualifier != qualifier)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ReferenceExpression(qualifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ReferenceExpressionGreen)newNode;
			}
			return this;
		}
	}
	
	internal class ExpressionTokensGreen : ExpressionGreen
	{
		internal static new readonly ExpressionTokensGreen __Missing = new ExpressionTokensGreen();
		private InternalSyntaxToken _tokens;
	
		public ExpressionTokensGreen(CompilerSyntaxKind kind, InternalSyntaxToken tokens)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
		}
	
		public ExpressionTokensGreen(CompilerSyntaxKind kind, InternalSyntaxToken tokens, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
		}
	
		private ExpressionTokensGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ExpressionTokens, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken Tokens { get { return _tokens; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ExpressionTokensSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tokens;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitExpressionTokensGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitExpressionTokensGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ExpressionTokensGreen(this.Kind, _tokens, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ExpressionTokensGreen(this.Kind, _tokens, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ExpressionTokensGreen(this.Kind, _tokens, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ExpressionTokensGreen Update(InternalSyntaxToken tokens)
		{
			if (_tokens != tokens)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ExpressionTokens((InternalSyntaxToken)tokens);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ExpressionTokensGreen)newNode;
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
	
		public NameGreen(CompilerSyntaxKind kind, IdentifierGreen identifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.NameSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _identifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitNameGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitNameGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new NameGreen(this.Kind, _identifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new NameGreen(this.Kind, _identifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new NameGreen(this.Kind, _identifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public NameGreen Update(IdentifierGreen identifier)
		{
			if (_identifier != identifier)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Name(identifier);
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
		private GreenNode _identifierList;
	
		public QualifierGreen(CompilerSyntaxKind kind, GreenNode identifierList)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (identifierList != null)
			{
				AdjustFlagsAndWidth(identifierList);
				_identifierList = identifierList;
			}
		}
	
		public QualifierGreen(CompilerSyntaxKind kind, GreenNode identifierList, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (identifierList != null)
			{
				AdjustFlagsAndWidth(identifierList);
				_identifierList = identifierList;
			}
		}
	
		private QualifierGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Qualifier, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> IdentifierList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_identifierList, reversed: false); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.QualifierSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _identifierList;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitQualifierGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new QualifierGreen(this.Kind, _identifierList, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new QualifierGreen(this.Kind, _identifierList, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new QualifierGreen(this.Kind, _identifierList, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public QualifierGreen Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> identifierList)
		{
			if (_identifierList != identifierList.Node)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Qualifier(identifierList);
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
	
	internal class QualifierListGreen : GreenSyntaxNode
	{
		internal static new readonly QualifierListGreen __Missing = new QualifierListGreen();
		private GreenNode _qualifierList;
	
		public QualifierListGreen(CompilerSyntaxKind kind, GreenNode qualifierList)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (qualifierList != null)
			{
				AdjustFlagsAndWidth(qualifierList);
				_qualifierList = qualifierList;
			}
		}
	
		public QualifierListGreen(CompilerSyntaxKind kind, GreenNode qualifierList, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (qualifierList != null)
			{
				AdjustFlagsAndWidth(qualifierList);
				_qualifierList = qualifierList;
			}
		}
	
		private QualifierListGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.QualifierList, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> QualifierList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_qualifierList, reversed: false); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.QualifierListSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _qualifierList;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierListGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitQualifierListGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new QualifierListGreen(this.Kind, _qualifierList, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new QualifierListGreen(this.Kind, _qualifierList, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new QualifierListGreen(this.Kind, _qualifierList, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public QualifierListGreen Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> qualifierList)
		{
			if (_qualifierList != qualifierList.Node)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.QualifierList(qualifierList);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (QualifierListGreen)newNode;
			}
			return this;
		}
	}
	
	internal class IdentifierGreen : GreenSyntaxNode
	{
		internal static new readonly IdentifierGreen __Missing = new IdentifierGreen();
		private InternalSyntaxToken _tIdentifier;
	
		public IdentifierGreen(CompilerSyntaxKind kind, InternalSyntaxToken tIdentifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
			}
		}
	
		public IdentifierGreen(CompilerSyntaxKind kind, InternalSyntaxToken tIdentifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
			}
		}
	
		private IdentifierGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Identifier, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TIdentifier { get { return _tIdentifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.IdentifierSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tIdentifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitIdentifierGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitIdentifierGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new IdentifierGreen(this.Kind, _tIdentifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new IdentifierGreen(this.Kind, _tIdentifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new IdentifierGreen(this.Kind, _tIdentifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public IdentifierGreen Update(InternalSyntaxToken tIdentifier)
		{
			if (_tIdentifier != tIdentifier)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Identifier((InternalSyntaxToken)tIdentifier);
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
	
	internal abstract class UsingBlock1Green : GreenSyntaxNode
	{
		internal static readonly UsingBlock1Green __Missing = UsingBlock1Alt1Green.__Missing;
	
	    protected UsingBlock1Green(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class UsingBlock1Alt1Green : UsingBlock1Green
	{
		internal static new readonly UsingBlock1Alt1Green __Missing = new UsingBlock1Alt1Green();
		private QualifierGreen _namespaces;
	
		public UsingBlock1Alt1Green(CompilerSyntaxKind kind, QualifierGreen namespaces)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (namespaces != null)
			{
				AdjustFlagsAndWidth(namespaces);
				_namespaces = namespaces;
			}
		}
	
		public UsingBlock1Alt1Green(CompilerSyntaxKind kind, QualifierGreen namespaces, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (namespaces != null)
			{
				AdjustFlagsAndWidth(namespaces);
				_namespaces = namespaces;
			}
		}
	
		private UsingBlock1Alt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.UsingBlock1Alt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public QualifierGreen Namespaces { get { return _namespaces; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.UsingBlock1Alt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _namespaces;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitUsingBlock1Alt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitUsingBlock1Alt1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new UsingBlock1Alt1Green(this.Kind, _namespaces, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new UsingBlock1Alt1Green(this.Kind, _namespaces, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new UsingBlock1Alt1Green(this.Kind, _namespaces, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public UsingBlock1Alt1Green Update(QualifierGreen namespaces)
		{
			if (_namespaces != namespaces)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.UsingBlock1Alt1(namespaces);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (UsingBlock1Alt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class UsingBlock1Alt2Green : UsingBlock1Green
	{
		internal static new readonly UsingBlock1Alt2Green __Missing = new UsingBlock1Alt2Green();
		private InternalSyntaxToken _kMetamodel;
		private QualifierGreen _metaModels;
	
		public UsingBlock1Alt2Green(CompilerSyntaxKind kind, InternalSyntaxToken kMetamodel, QualifierGreen metaModels)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (kMetamodel != null)
			{
				AdjustFlagsAndWidth(kMetamodel);
				_kMetamodel = kMetamodel;
			}
			if (metaModels != null)
			{
				AdjustFlagsAndWidth(metaModels);
				_metaModels = metaModels;
			}
		}
	
		public UsingBlock1Alt2Green(CompilerSyntaxKind kind, InternalSyntaxToken kMetamodel, QualifierGreen metaModels, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (kMetamodel != null)
			{
				AdjustFlagsAndWidth(kMetamodel);
				_kMetamodel = kMetamodel;
			}
			if (metaModels != null)
			{
				AdjustFlagsAndWidth(metaModels);
				_metaModels = metaModels;
			}
		}
	
		private UsingBlock1Alt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.UsingBlock1Alt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KMetamodel { get { return _kMetamodel; } }
		public QualifierGreen MetaModels { get { return _metaModels; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.UsingBlock1Alt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kMetamodel;
				case 1: return _metaModels;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitUsingBlock1Alt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitUsingBlock1Alt2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new UsingBlock1Alt2Green(this.Kind, _kMetamodel, _metaModels, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new UsingBlock1Alt2Green(this.Kind, _kMetamodel, _metaModels, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new UsingBlock1Alt2Green(this.Kind, _kMetamodel, _metaModels, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public UsingBlock1Alt2Green Update(InternalSyntaxToken kMetamodel, QualifierGreen metaModels)
		{
			if (_kMetamodel != kMetamodel || _metaModels != metaModels)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.UsingBlock1Alt2((InternalSyntaxToken)kMetamodel, metaModels);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (UsingBlock1Alt2Green)newNode;
			}
			return this;
		}
	}
	
	internal class ParserRuleBlock1Green : GreenSyntaxNode
	{
		internal static new readonly ParserRuleBlock1Green __Missing = new ParserRuleBlock1Green();
		private InternalSyntaxToken _kReturns;
		private QualifierGreen _returnType;
	
		public ParserRuleBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken kReturns, QualifierGreen returnType)
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
	
		public ParserRuleBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken kReturns, QualifierGreen returnType, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private ParserRuleBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KReturns { get { return _kReturns; } }
		public QualifierGreen ReturnType { get { return _returnType; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserRuleBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kReturns;
				case 1: return _returnType;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserRuleBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserRuleBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParserRuleBlock1Green(this.Kind, _kReturns, _returnType, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParserRuleBlock1Green(this.Kind, _kReturns, _returnType, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ParserRuleBlock1Green(this.Kind, _kReturns, _returnType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserRuleBlock1Green Update(InternalSyntaxToken kReturns, QualifierGreen returnType)
		{
			if (_kReturns != kReturns || _returnType != returnType)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleBlock1((InternalSyntaxToken)kReturns, returnType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class ParserRuleBlock2Green : GreenSyntaxNode
	{
		internal static new readonly ParserRuleBlock2Green __Missing = new ParserRuleBlock2Green();
		private InternalSyntaxToken _tBar;
		private ParserRuleAlternativeGreen _alternatives;
	
		public ParserRuleBlock2Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, ParserRuleAlternativeGreen alternatives)
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
	
		public ParserRuleBlock2Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, ParserRuleAlternativeGreen alternatives, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private ParserRuleBlock2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleBlock2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TBar { get { return _tBar; } }
		public ParserRuleAlternativeGreen Alternatives { get { return _alternatives; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserRuleBlock2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tBar;
				case 1: return _alternatives;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserRuleBlock2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserRuleBlock2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParserRuleBlock2Green(this.Kind, _tBar, _alternatives, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParserRuleBlock2Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ParserRuleBlock2Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserRuleBlock2Green Update(InternalSyntaxToken tBar, ParserRuleAlternativeGreen alternatives)
		{
			if (_tBar != tBar || _alternatives != alternatives)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleBlock2((InternalSyntaxToken)tBar, alternatives);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleBlock2Green)newNode;
			}
			return this;
		}
	}
	
	internal class BlockRuleBlock1Green : GreenSyntaxNode
	{
		internal static new readonly BlockRuleBlock1Green __Missing = new BlockRuleBlock1Green();
		private InternalSyntaxToken _tBar;
		private ParserRuleAlternativeGreen _alternatives;
	
		public BlockRuleBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, ParserRuleAlternativeGreen alternatives)
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
	
		public BlockRuleBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, ParserRuleAlternativeGreen alternatives, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private BlockRuleBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.BlockRuleBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TBar { get { return _tBar; } }
		public ParserRuleAlternativeGreen Alternatives { get { return _alternatives; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.BlockRuleBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tBar;
				case 1: return _alternatives;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBlockRuleBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitBlockRuleBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new BlockRuleBlock1Green(this.Kind, _tBar, _alternatives, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new BlockRuleBlock1Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new BlockRuleBlock1Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public BlockRuleBlock1Green Update(InternalSyntaxToken tBar, ParserRuleAlternativeGreen alternatives)
		{
			if (_tBar != tBar || _alternatives != alternatives)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.BlockRuleBlock1((InternalSyntaxToken)tBar, alternatives);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (BlockRuleBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class ParserRuleAlternativeBlock1Green : GreenSyntaxNode
	{
		internal static new readonly ParserRuleAlternativeBlock1Green __Missing = new ParserRuleAlternativeBlock1Green();
		private InternalSyntaxToken _tLBrace;
		private QualifierGreen _returnType;
		private InternalSyntaxToken _tRBrace;
	
		public ParserRuleAlternativeBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tLBrace, QualifierGreen returnType, InternalSyntaxToken tRBrace)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		public ParserRuleAlternativeBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tLBrace, QualifierGreen returnType, InternalSyntaxToken tRBrace, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		private ParserRuleAlternativeBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleAlternativeBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TLBrace { get { return _tLBrace; } }
		public QualifierGreen ReturnType { get { return _returnType; } }
		public InternalSyntaxToken TRBrace { get { return _tRBrace; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserRuleAlternativeBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLBrace;
				case 1: return _returnType;
				case 2: return _tRBrace;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserRuleAlternativeBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserRuleAlternativeBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParserRuleAlternativeBlock1Green(this.Kind, _tLBrace, _returnType, _tRBrace, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParserRuleAlternativeBlock1Green(this.Kind, _tLBrace, _returnType, _tRBrace, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ParserRuleAlternativeBlock1Green(this.Kind, _tLBrace, _returnType, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserRuleAlternativeBlock1Green Update(InternalSyntaxToken tLBrace, QualifierGreen returnType, InternalSyntaxToken tRBrace)
		{
			if (_tLBrace != tLBrace || _returnType != returnType || _tRBrace != tRBrace)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleAlternativeBlock1((InternalSyntaxToken)tLBrace, returnType, (InternalSyntaxToken)tRBrace);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleAlternativeBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class ParserRuleAlternativeBlock2Green : GreenSyntaxNode
	{
		internal static new readonly ParserRuleAlternativeBlock2Green __Missing = new ParserRuleAlternativeBlock2Green();
		private InternalSyntaxToken _tEqGt;
		private ExpressionGreen _returnValue;
	
		public ParserRuleAlternativeBlock2Green(CompilerSyntaxKind kind, InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
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
	
		public ParserRuleAlternativeBlock2Green(CompilerSyntaxKind kind, InternalSyntaxToken tEqGt, ExpressionGreen returnValue, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private ParserRuleAlternativeBlock2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleAlternativeBlock2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TEqGt { get { return _tEqGt; } }
		public ExpressionGreen ReturnValue { get { return _returnValue; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserRuleAlternativeBlock2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tEqGt;
				case 1: return _returnValue;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserRuleAlternativeBlock2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserRuleAlternativeBlock2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParserRuleAlternativeBlock2Green(this.Kind, _tEqGt, _returnValue, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParserRuleAlternativeBlock2Green(this.Kind, _tEqGt, _returnValue, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ParserRuleAlternativeBlock2Green(this.Kind, _tEqGt, _returnValue, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserRuleAlternativeBlock2Green Update(InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
		{
			if (_tEqGt != tEqGt || _returnValue != returnValue)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleAlternativeBlock2((InternalSyntaxToken)tEqGt, returnValue);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleAlternativeBlock2Green)newNode;
			}
			return this;
		}
	}
	
	internal class QualifierBlock1Green : GreenSyntaxNode
	{
		internal static new readonly QualifierBlock1Green __Missing = new QualifierBlock1Green();
		private InternalSyntaxToken _tDot;
		private IdentifierGreen _identifier;
	
		public QualifierBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tDot, IdentifierGreen identifier)
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
	
		public QualifierBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tDot, IdentifierGreen identifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private QualifierBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.QualifierBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TDot { get { return _tDot; } }
		public IdentifierGreen Identifier { get { return _identifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.QualifierBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tDot;
				case 1: return _identifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitQualifierBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new QualifierBlock1Green(this.Kind, _tDot, _identifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new QualifierBlock1Green(this.Kind, _tDot, _identifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new QualifierBlock1Green(this.Kind, _tDot, _identifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public QualifierBlock1Green Update(InternalSyntaxToken tDot, IdentifierGreen identifier)
		{
			if (_tDot != tDot || _identifier != identifier)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.QualifierBlock1((InternalSyntaxToken)tDot, identifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (QualifierBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class QualifierListBlock1Green : GreenSyntaxNode
	{
		internal static new readonly QualifierListBlock1Green __Missing = new QualifierListBlock1Green();
		private InternalSyntaxToken _tComma;
		private QualifierGreen _qualifier;
	
		public QualifierListBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tComma, QualifierGreen qualifier)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (tComma != null)
			{
				AdjustFlagsAndWidth(tComma);
				_tComma = tComma;
			}
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		public QualifierListBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tComma, QualifierGreen qualifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (tComma != null)
			{
				AdjustFlagsAndWidth(tComma);
				_tComma = tComma;
			}
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		private QualifierListBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.QualifierListBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TComma { get { return _tComma; } }
		public QualifierGreen Qualifier { get { return _qualifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.QualifierListBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _qualifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierListBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitQualifierListBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new QualifierListBlock1Green(this.Kind, _tComma, _qualifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new QualifierListBlock1Green(this.Kind, _tComma, _qualifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new QualifierListBlock1Green(this.Kind, _tComma, _qualifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public QualifierListBlock1Green Update(InternalSyntaxToken tComma, QualifierGreen qualifier)
		{
			if (_tComma != tComma || _qualifier != qualifier)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.QualifierListBlock1((InternalSyntaxToken)tComma, qualifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (QualifierListBlock1Green)newNode;
			}
			return this;
		}
	}
	
}
