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
		private QualifierGreen _name;
		private InternalSyntaxToken _tSemicolon;
		private GreenNode _using;
		private DeclarationsGreen _declarations;
		private InternalSyntaxToken _eof;
	
		public MainGreen(CompilerSyntaxKind kind, InternalSyntaxToken kNamespace, QualifierGreen name, InternalSyntaxToken tSemicolon, GreenNode @using, DeclarationsGreen declarations, InternalSyntaxToken eof)
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
	
		public MainGreen(CompilerSyntaxKind kind, InternalSyntaxToken kNamespace, QualifierGreen name, InternalSyntaxToken tSemicolon, GreenNode @using, DeclarationsGreen declarations, InternalSyntaxToken eof, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
		public QualifierGreen Name { get { return _name; } }
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
				case 1: return _name;
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
			return new MainGreen(this.Kind, _kNamespace, _name, _tSemicolon, _using, _declarations, _eof, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MainGreen(this.Kind, _kNamespace, _name, _tSemicolon, _using, _declarations, _eof, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new MainGreen(this.Kind, _kNamespace, _name, _tSemicolon, _using, _declarations, _eof, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MainGreen Update(InternalSyntaxToken kNamespace, QualifierGreen name, InternalSyntaxToken tSemicolon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> @using, DeclarationsGreen declarations, InternalSyntaxToken eof)
		{
			if (_kNamespace != kNamespace || _name != name || _tSemicolon != tSemicolon || _using != @using.Node || _declarations != declarations || _eof != eof)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Main((InternalSyntaxToken)kNamespace, name, (InternalSyntaxToken)tSemicolon, @using, declarations, (InternalSyntaxToken)eof);
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
		private QualifierGreen _namespaces;
		private InternalSyntaxToken _tSemicolon;
	
		public UsingGreen(CompilerSyntaxKind kind, InternalSyntaxToken kUsing, QualifierGreen namespaces, InternalSyntaxToken tSemicolon)
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
	
		public UsingGreen(CompilerSyntaxKind kind, InternalSyntaxToken kUsing, QualifierGreen namespaces, InternalSyntaxToken tSemicolon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Using, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KUsing { get { return _kUsing; } }
		public QualifierGreen Namespaces { get { return _namespaces; } }
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
				case 1: return _namespaces;
				case 2: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitUsingGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitUsingGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new UsingGreen(this.Kind, _kUsing, _namespaces, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new UsingGreen(this.Kind, _kUsing, _namespaces, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new UsingGreen(this.Kind, _kUsing, _namespaces, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public UsingGreen Update(InternalSyntaxToken kUsing, QualifierGreen namespaces, InternalSyntaxToken tSemicolon)
		{
			if (_kUsing != kUsing || _namespaces != namespaces || _tSemicolon != tSemicolon)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Using((InternalSyntaxToken)kUsing, namespaces, (InternalSyntaxToken)tSemicolon);
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
		private GrammarGreen _grammar;
	
		public LanguageDeclarationGreen(CompilerSyntaxKind kind, InternalSyntaxToken kLanguage, NameGreen name, InternalSyntaxToken tSemicolon, GrammarGreen grammar)
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
	
		public LanguageDeclarationGreen(CompilerSyntaxKind kind, InternalSyntaxToken kLanguage, NameGreen name, InternalSyntaxToken tSemicolon, GrammarGreen grammar, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		public InternalSyntaxToken KLanguage { get { return _kLanguage; } }
		public NameGreen Name { get { return _name; } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
		public GrammarGreen Grammar { get { return _grammar; } }
	
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
				case 3: return _grammar;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLanguageDeclarationGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLanguageDeclarationGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LanguageDeclarationGreen(this.Kind, _kLanguage, _name, _tSemicolon, _grammar, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LanguageDeclarationGreen(this.Kind, _kLanguage, _name, _tSemicolon, _grammar, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LanguageDeclarationGreen(this.Kind, _kLanguage, _name, _tSemicolon, _grammar, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LanguageDeclarationGreen Update(InternalSyntaxToken kLanguage, NameGreen name, InternalSyntaxToken tSemicolon, GrammarGreen grammar)
		{
			if (_kLanguage != kLanguage || _name != name || _tSemicolon != tSemicolon || _grammar != grammar)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LanguageDeclaration((InternalSyntaxToken)kLanguage, name, (InternalSyntaxToken)tSemicolon, grammar);
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
		private GrammarBlock1Green _grammarBlock1;
	
		public GrammarGreen(CompilerSyntaxKind kind, GrammarBlock1Green grammarBlock1)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (grammarBlock1 != null)
			{
				AdjustFlagsAndWidth(grammarBlock1);
				_grammarBlock1 = grammarBlock1;
			}
		}
	
		public GrammarGreen(CompilerSyntaxKind kind, GrammarBlock1Green grammarBlock1, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (grammarBlock1 != null)
			{
				AdjustFlagsAndWidth(grammarBlock1);
				_grammarBlock1 = grammarBlock1;
			}
		}
	
		private GrammarGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.Grammar, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public GrammarBlock1Green GrammarBlock1 { get { return _grammarBlock1; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.GrammarSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _grammarBlock1;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitGrammarGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitGrammarGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new GrammarGreen(this.Kind, _grammarBlock1, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new GrammarGreen(this.Kind, _grammarBlock1, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new GrammarGreen(this.Kind, _grammarBlock1, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public GrammarGreen Update(GrammarBlock1Green grammarBlock1)
		{
			if (_grammarBlock1 != grammarBlock1)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.Grammar(grammarBlock1);
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
		private GreenNode _annotations1;
		private ParserRuleBlock1Green _parserRuleBlock1;
		private InternalSyntaxToken _tColon;
		private GreenNode _pAlternativeList;
		private InternalSyntaxToken _tSemicolon;
	
		public ParserRuleGreen(CompilerSyntaxKind kind, GreenNode annotations1, ParserRuleBlock1Green parserRuleBlock1, InternalSyntaxToken tColon, GreenNode pAlternativeList, InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
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
			if (pAlternativeList != null)
			{
				AdjustFlagsAndWidth(pAlternativeList);
				_pAlternativeList = pAlternativeList;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		public ParserRuleGreen(CompilerSyntaxKind kind, GreenNode annotations1, ParserRuleBlock1Green parserRuleBlock1, InternalSyntaxToken tColon, GreenNode pAlternativeList, InternalSyntaxToken tSemicolon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
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
			if (pAlternativeList != null)
			{
				AdjustFlagsAndWidth(pAlternativeList);
				_pAlternativeList = pAlternativeList;
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
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> Annotations1 { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_annotations1); } }
		public ParserRuleBlock1Green ParserRuleBlock1 { get { return _parserRuleBlock1; } }
		public InternalSyntaxToken TColon { get { return _tColon; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<PAlternativeGreen> PAlternativeList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<PAlternativeGreen>(_pAlternativeList, reversed: false); } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserRuleSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _parserRuleBlock1;
				case 2: return _tColon;
				case 3: return _pAlternativeList;
				case 4: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserRuleGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserRuleGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParserRuleGreen(this.Kind, _annotations1, _parserRuleBlock1, _tColon, _pAlternativeList, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParserRuleGreen(this.Kind, _annotations1, _parserRuleBlock1, _tColon, _pAlternativeList, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ParserRuleGreen(this.Kind, _annotations1, _parserRuleBlock1, _tColon, _pAlternativeList, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserRuleGreen Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, ParserRuleBlock1Green parserRuleBlock1, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<PAlternativeGreen> pAlternativeList, InternalSyntaxToken tSemicolon)
		{
			if (_annotations1 != annotations1.Node || _parserRuleBlock1 != parserRuleBlock1 || _tColon != tColon || _pAlternativeList != pAlternativeList.Node || _tSemicolon != tSemicolon)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserRule(annotations1, parserRuleBlock1, (InternalSyntaxToken)tColon, pAlternativeList, (InternalSyntaxToken)tSemicolon);
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
	
	internal class PBlockGreen : RuleGreen
	{
		internal static new readonly PBlockGreen __Missing = new PBlockGreen();
		private GreenNode _annotations1;
		private InternalSyntaxToken _kBlock;
		private NameGreen _name;
		private InternalSyntaxToken _tColon;
		private GreenNode _pAlternativeList;
		private InternalSyntaxToken _tSemicolon;
	
		public PBlockGreen(CompilerSyntaxKind kind, GreenNode annotations1, InternalSyntaxToken kBlock, NameGreen name, InternalSyntaxToken tColon, GreenNode pAlternativeList, InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 6;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (kBlock != null)
			{
				AdjustFlagsAndWidth(kBlock);
				_kBlock = kBlock;
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
			if (pAlternativeList != null)
			{
				AdjustFlagsAndWidth(pAlternativeList);
				_pAlternativeList = pAlternativeList;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		public PBlockGreen(CompilerSyntaxKind kind, GreenNode annotations1, InternalSyntaxToken kBlock, NameGreen name, InternalSyntaxToken tColon, GreenNode pAlternativeList, InternalSyntaxToken tSemicolon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 6;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (kBlock != null)
			{
				AdjustFlagsAndWidth(kBlock);
				_kBlock = kBlock;
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
			if (pAlternativeList != null)
			{
				AdjustFlagsAndWidth(pAlternativeList);
				_pAlternativeList = pAlternativeList;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		private PBlockGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PBlock, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> Annotations1 { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_annotations1); } }
		public InternalSyntaxToken KBlock { get { return _kBlock; } }
		public NameGreen Name { get { return _name; } }
		public InternalSyntaxToken TColon { get { return _tColon; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<PAlternativeGreen> PAlternativeList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<PAlternativeGreen>(_pAlternativeList, reversed: false); } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _kBlock;
				case 2: return _name;
				case 3: return _tColon;
				case 4: return _pAlternativeList;
				case 5: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPBlockGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PBlockGreen(this.Kind, _annotations1, _kBlock, _name, _tColon, _pAlternativeList, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PBlockGreen(this.Kind, _annotations1, _kBlock, _name, _tColon, _pAlternativeList, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PBlockGreen(this.Kind, _annotations1, _kBlock, _name, _tColon, _pAlternativeList, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PBlockGreen Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, InternalSyntaxToken kBlock, NameGreen name, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<PAlternativeGreen> pAlternativeList, InternalSyntaxToken tSemicolon)
		{
			if (_annotations1 != annotations1.Node || _kBlock != kBlock || _name != name || _tColon != tColon || _pAlternativeList != pAlternativeList.Node || _tSemicolon != tSemicolon)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PBlock(annotations1, (InternalSyntaxToken)kBlock, name, (InternalSyntaxToken)tColon, pAlternativeList, (InternalSyntaxToken)tSemicolon);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PBlockGreen)newNode;
			}
			return this;
		}
	}
	
	internal class LexerRuleGreen : RuleGreen
	{
		internal static new readonly LexerRuleGreen __Missing = new LexerRuleGreen();
		private GreenNode _annotations1;
		private LexerRuleBlock1Green _lexerRuleBlock1;
		private InternalSyntaxToken _tColon;
		private GreenNode _lAlternativeList;
		private InternalSyntaxToken _tSemicolon;
	
		public LexerRuleGreen(CompilerSyntaxKind kind, GreenNode annotations1, LexerRuleBlock1Green lexerRuleBlock1, InternalSyntaxToken tColon, GreenNode lAlternativeList, InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (lexerRuleBlock1 != null)
			{
				AdjustFlagsAndWidth(lexerRuleBlock1);
				_lexerRuleBlock1 = lexerRuleBlock1;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
			if (lAlternativeList != null)
			{
				AdjustFlagsAndWidth(lAlternativeList);
				_lAlternativeList = lAlternativeList;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		public LexerRuleGreen(CompilerSyntaxKind kind, GreenNode annotations1, LexerRuleBlock1Green lexerRuleBlock1, InternalSyntaxToken tColon, GreenNode lAlternativeList, InternalSyntaxToken tSemicolon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 5;
			if (annotations1 != null)
			{
				AdjustFlagsAndWidth(annotations1);
				_annotations1 = annotations1;
			}
			if (lexerRuleBlock1 != null)
			{
				AdjustFlagsAndWidth(lexerRuleBlock1);
				_lexerRuleBlock1 = lexerRuleBlock1;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
			if (lAlternativeList != null)
			{
				AdjustFlagsAndWidth(lAlternativeList);
				_lAlternativeList = lAlternativeList;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		private LexerRuleGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LexerRule, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LexerAnnotationGreen> Annotations1 { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LexerAnnotationGreen>(_annotations1); } }
		public LexerRuleBlock1Green LexerRuleBlock1 { get { return _lexerRuleBlock1; } }
		public InternalSyntaxToken TColon { get { return _tColon; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> LAlternativeList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen>(_lAlternativeList, reversed: false); } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LexerRuleSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _lexerRuleBlock1;
				case 2: return _tColon;
				case 3: return _lAlternativeList;
				case 4: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLexerRuleGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLexerRuleGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LexerRuleGreen(this.Kind, _annotations1, _lexerRuleBlock1, _tColon, _lAlternativeList, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LexerRuleGreen(this.Kind, _annotations1, _lexerRuleBlock1, _tColon, _lAlternativeList, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LexerRuleGreen(this.Kind, _annotations1, _lexerRuleBlock1, _tColon, _lAlternativeList, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LexerRuleGreen Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LexerAnnotationGreen> annotations1, LexerRuleBlock1Green lexerRuleBlock1, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> lAlternativeList, InternalSyntaxToken tSemicolon)
		{
			if (_annotations1 != annotations1.Node || _lexerRuleBlock1 != lexerRuleBlock1 || _tColon != tColon || _lAlternativeList != lAlternativeList.Node || _tSemicolon != tSemicolon)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LexerRule(annotations1, lexerRuleBlock1, (InternalSyntaxToken)tColon, lAlternativeList, (InternalSyntaxToken)tSemicolon);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleGreen)newNode;
			}
			return this;
		}
	}
	
	internal class PAlternativeGreen : GreenSyntaxNode
	{
		internal static new readonly PAlternativeGreen __Missing = new PAlternativeGreen();
		private PAlternativeBlock1Green _pAlternativeBlock1;
		private GreenNode _elements;
		private PAlternativeBlock2Green _pAlternativeBlock2;
	
		public PAlternativeGreen(CompilerSyntaxKind kind, PAlternativeBlock1Green pAlternativeBlock1, GreenNode elements, PAlternativeBlock2Green pAlternativeBlock2)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (pAlternativeBlock1 != null)
			{
				AdjustFlagsAndWidth(pAlternativeBlock1);
				_pAlternativeBlock1 = pAlternativeBlock1;
			}
			if (elements != null)
			{
				AdjustFlagsAndWidth(elements);
				_elements = elements;
			}
			if (pAlternativeBlock2 != null)
			{
				AdjustFlagsAndWidth(pAlternativeBlock2);
				_pAlternativeBlock2 = pAlternativeBlock2;
			}
		}
	
		public PAlternativeGreen(CompilerSyntaxKind kind, PAlternativeBlock1Green pAlternativeBlock1, GreenNode elements, PAlternativeBlock2Green pAlternativeBlock2, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (pAlternativeBlock1 != null)
			{
				AdjustFlagsAndWidth(pAlternativeBlock1);
				_pAlternativeBlock1 = pAlternativeBlock1;
			}
			if (elements != null)
			{
				AdjustFlagsAndWidth(elements);
				_elements = elements;
			}
			if (pAlternativeBlock2 != null)
			{
				AdjustFlagsAndWidth(pAlternativeBlock2);
				_pAlternativeBlock2 = pAlternativeBlock2;
			}
		}
	
		private PAlternativeGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PAlternative, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public PAlternativeBlock1Green PAlternativeBlock1 { get { return _pAlternativeBlock1; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<PElementGreen> Elements { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<PElementGreen>(_elements); } }
		public PAlternativeBlock2Green PAlternativeBlock2 { get { return _pAlternativeBlock2; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PAlternativeSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _pAlternativeBlock1;
				case 1: return _elements;
				case 2: return _pAlternativeBlock2;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPAlternativeGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPAlternativeGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PAlternativeGreen(this.Kind, _pAlternativeBlock1, _elements, _pAlternativeBlock2, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PAlternativeGreen(this.Kind, _pAlternativeBlock1, _elements, _pAlternativeBlock2, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PAlternativeGreen(this.Kind, _pAlternativeBlock1, _elements, _pAlternativeBlock2, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PAlternativeGreen Update(PAlternativeBlock1Green pAlternativeBlock1, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<PElementGreen> elements, PAlternativeBlock2Green pAlternativeBlock2)
		{
			if (_pAlternativeBlock1 != pAlternativeBlock1 || _elements != elements.Node || _pAlternativeBlock2 != pAlternativeBlock2)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PAlternative(pAlternativeBlock1, elements, pAlternativeBlock2);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PAlternativeGreen)newNode;
			}
			return this;
		}
	}
	
	internal class PElementGreen : GreenSyntaxNode
	{
		internal static new readonly PElementGreen __Missing = new PElementGreen();
		private PElementBlock1Green _pElementBlock1;
		private GreenNode _valueAnnotations;
		private PElementValueGreen _value;
		private InternalSyntaxToken _multiplicity;
	
		public PElementGreen(CompilerSyntaxKind kind, PElementBlock1Green pElementBlock1, GreenNode valueAnnotations, PElementValueGreen value, InternalSyntaxToken multiplicity)
			: base(kind, null, null)
		{
			SlotCount = 4;
			if (pElementBlock1 != null)
			{
				AdjustFlagsAndWidth(pElementBlock1);
				_pElementBlock1 = pElementBlock1;
			}
			if (valueAnnotations != null)
			{
				AdjustFlagsAndWidth(valueAnnotations);
				_valueAnnotations = valueAnnotations;
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
	
		public PElementGreen(CompilerSyntaxKind kind, PElementBlock1Green pElementBlock1, GreenNode valueAnnotations, PElementValueGreen value, InternalSyntaxToken multiplicity, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 4;
			if (pElementBlock1 != null)
			{
				AdjustFlagsAndWidth(pElementBlock1);
				_pElementBlock1 = pElementBlock1;
			}
			if (valueAnnotations != null)
			{
				AdjustFlagsAndWidth(valueAnnotations);
				_valueAnnotations = valueAnnotations;
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
	
		private PElementGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PElement, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public PElementBlock1Green PElementBlock1 { get { return _pElementBlock1; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> ValueAnnotations { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_valueAnnotations); } }
		public PElementValueGreen Value { get { return _value; } }
		public InternalSyntaxToken Multiplicity { get { return _multiplicity; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PElementSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _pElementBlock1;
				case 1: return _valueAnnotations;
				case 2: return _value;
				case 3: return _multiplicity;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPElementGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPElementGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PElementGreen(this.Kind, _pElementBlock1, _valueAnnotations, _value, _multiplicity, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PElementGreen(this.Kind, _pElementBlock1, _valueAnnotations, _value, _multiplicity, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PElementGreen(this.Kind, _pElementBlock1, _valueAnnotations, _value, _multiplicity, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PElementGreen Update(PElementBlock1Green pElementBlock1, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> valueAnnotations, PElementValueGreen value, InternalSyntaxToken multiplicity)
		{
			if (_pElementBlock1 != pElementBlock1 || _valueAnnotations != valueAnnotations.Node || _value != value || _multiplicity != multiplicity)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PElement(pElementBlock1, valueAnnotations, value, (InternalSyntaxToken)multiplicity);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PElementGreen)newNode;
			}
			return this;
		}
	}
	
	internal abstract class PElementValueGreen : GreenSyntaxNode
	{
		internal static readonly PElementValueGreen __Missing = PBlockInlineGreen.__Missing;
	
	    protected PElementValueGreen(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class PBlockInlineGreen : PElementValueGreen
	{
		internal static new readonly PBlockInlineGreen __Missing = new PBlockInlineGreen();
		private InternalSyntaxToken _tLParen;
		private GreenNode _pAlternativeList;
		private InternalSyntaxToken _tRParen;
	
		public PBlockInlineGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLParen, GreenNode pAlternativeList, InternalSyntaxToken tRParen)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (pAlternativeList != null)
			{
				AdjustFlagsAndWidth(pAlternativeList);
				_pAlternativeList = pAlternativeList;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
		}
	
		public PBlockInlineGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLParen, GreenNode pAlternativeList, InternalSyntaxToken tRParen, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (pAlternativeList != null)
			{
				AdjustFlagsAndWidth(pAlternativeList);
				_pAlternativeList = pAlternativeList;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
		}
	
		private PBlockInlineGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PBlockInline, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TLParen { get { return _tLParen; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<PAlternativeGreen> PAlternativeList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<PAlternativeGreen>(_pAlternativeList, reversed: false); } }
		public InternalSyntaxToken TRParen { get { return _tRParen; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PBlockInlineSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLParen;
				case 1: return _pAlternativeList;
				case 2: return _tRParen;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPBlockInlineGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPBlockInlineGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PBlockInlineGreen(this.Kind, _tLParen, _pAlternativeList, _tRParen, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PBlockInlineGreen(this.Kind, _tLParen, _pAlternativeList, _tRParen, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PBlockInlineGreen(this.Kind, _tLParen, _pAlternativeList, _tRParen, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PBlockInlineGreen Update(InternalSyntaxToken tLParen, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<PAlternativeGreen> pAlternativeList, InternalSyntaxToken tRParen)
		{
			if (_tLParen != tLParen || _pAlternativeList != pAlternativeList.Node || _tRParen != tRParen)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PBlockInline((InternalSyntaxToken)tLParen, pAlternativeList, (InternalSyntaxToken)tRParen);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PBlockInlineGreen)newNode;
			}
			return this;
		}
	}
	
	internal class PEofGreen : PElementValueGreen
	{
		internal static new readonly PEofGreen __Missing = new PEofGreen();
		private InternalSyntaxToken _kEof;
	
		public PEofGreen(CompilerSyntaxKind kind, InternalSyntaxToken kEof)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (kEof != null)
			{
				AdjustFlagsAndWidth(kEof);
				_kEof = kEof;
			}
		}
	
		public PEofGreen(CompilerSyntaxKind kind, InternalSyntaxToken kEof, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (kEof != null)
			{
				AdjustFlagsAndWidth(kEof);
				_kEof = kEof;
			}
		}
	
		private PEofGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PEof, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KEof { get { return _kEof; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PEofSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kEof;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPEofGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPEofGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PEofGreen(this.Kind, _kEof, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PEofGreen(this.Kind, _kEof, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PEofGreen(this.Kind, _kEof, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PEofGreen Update(InternalSyntaxToken kEof)
		{
			if (_kEof != kEof)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PEof((InternalSyntaxToken)kEof);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PEofGreen)newNode;
			}
			return this;
		}
	}
	
	internal class PKeywordGreen : PElementValueGreen
	{
		internal static new readonly PKeywordGreen __Missing = new PKeywordGreen();
		private InternalSyntaxToken _text;
	
		public PKeywordGreen(CompilerSyntaxKind kind, InternalSyntaxToken text)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (text != null)
			{
				AdjustFlagsAndWidth(text);
				_text = text;
			}
		}
	
		public PKeywordGreen(CompilerSyntaxKind kind, InternalSyntaxToken text, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (text != null)
			{
				AdjustFlagsAndWidth(text);
				_text = text;
			}
		}
	
		private PKeywordGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PKeyword, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken Text { get { return _text; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PKeywordSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _text;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPKeywordGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPKeywordGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PKeywordGreen(this.Kind, _text, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PKeywordGreen(this.Kind, _text, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PKeywordGreen(this.Kind, _text, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PKeywordGreen Update(InternalSyntaxToken text)
		{
			if (_text != text)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PKeyword((InternalSyntaxToken)text);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PKeywordGreen)newNode;
			}
			return this;
		}
	}
	
	internal class PReferenceAlt1Green : PElementValueGreen
	{
		internal static new readonly PReferenceAlt1Green __Missing = new PReferenceAlt1Green();
		private IdentifierGreen _rule;
	
		public PReferenceAlt1Green(CompilerSyntaxKind kind, IdentifierGreen rule)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (rule != null)
			{
				AdjustFlagsAndWidth(rule);
				_rule = rule;
			}
		}
	
		public PReferenceAlt1Green(CompilerSyntaxKind kind, IdentifierGreen rule, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (rule != null)
			{
				AdjustFlagsAndWidth(rule);
				_rule = rule;
			}
		}
	
		private PReferenceAlt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PReferenceAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Rule { get { return _rule; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PReferenceAlt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _rule;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPReferenceAlt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPReferenceAlt1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PReferenceAlt1Green(this.Kind, _rule, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PReferenceAlt1Green(this.Kind, _rule, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PReferenceAlt1Green(this.Kind, _rule, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PReferenceAlt1Green Update(IdentifierGreen rule)
		{
			if (_rule != rule)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PReferenceAlt1(rule);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PReferenceAlt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class PReferenceAlt2Green : PElementValueGreen
	{
		internal static new readonly PReferenceAlt2Green __Missing = new PReferenceAlt2Green();
		private InternalSyntaxToken _tHash;
		private ReturnTypeQualifierGreen _referencedTypes;
	
		public PReferenceAlt2Green(CompilerSyntaxKind kind, InternalSyntaxToken tHash, ReturnTypeQualifierGreen referencedTypes)
			: base(kind, null, null)
		{
			SlotCount = 2;
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
	
		public PReferenceAlt2Green(CompilerSyntaxKind kind, InternalSyntaxToken tHash, ReturnTypeQualifierGreen referencedTypes, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
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
	
		private PReferenceAlt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PReferenceAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken THash { get { return _tHash; } }
		public ReturnTypeQualifierGreen ReferencedTypes { get { return _referencedTypes; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PReferenceAlt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tHash;
				case 1: return _referencedTypes;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPReferenceAlt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPReferenceAlt2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PReferenceAlt2Green(this.Kind, _tHash, _referencedTypes, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PReferenceAlt2Green(this.Kind, _tHash, _referencedTypes, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PReferenceAlt2Green(this.Kind, _tHash, _referencedTypes, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PReferenceAlt2Green Update(InternalSyntaxToken tHash, ReturnTypeQualifierGreen referencedTypes)
		{
			if (_tHash != tHash || _referencedTypes != referencedTypes)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PReferenceAlt2((InternalSyntaxToken)tHash, referencedTypes);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PReferenceAlt2Green)newNode;
			}
			return this;
		}
	}
	
	internal class PReferenceAlt3Green : PElementValueGreen
	{
		internal static new readonly PReferenceAlt3Green __Missing = new PReferenceAlt3Green();
		private InternalSyntaxToken _tHashLBrace;
		private GreenNode _returnTypeQualifierList;
		private InternalSyntaxToken _tRBrace;
	
		public PReferenceAlt3Green(CompilerSyntaxKind kind, InternalSyntaxToken tHashLBrace, GreenNode returnTypeQualifierList, InternalSyntaxToken tRBrace)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tHashLBrace != null)
			{
				AdjustFlagsAndWidth(tHashLBrace);
				_tHashLBrace = tHashLBrace;
			}
			if (returnTypeQualifierList != null)
			{
				AdjustFlagsAndWidth(returnTypeQualifierList);
				_returnTypeQualifierList = returnTypeQualifierList;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		public PReferenceAlt3Green(CompilerSyntaxKind kind, InternalSyntaxToken tHashLBrace, GreenNode returnTypeQualifierList, InternalSyntaxToken tRBrace, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tHashLBrace != null)
			{
				AdjustFlagsAndWidth(tHashLBrace);
				_tHashLBrace = tHashLBrace;
			}
			if (returnTypeQualifierList != null)
			{
				AdjustFlagsAndWidth(returnTypeQualifierList);
				_returnTypeQualifierList = returnTypeQualifierList;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		private PReferenceAlt3Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PReferenceAlt3, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken THashLBrace { get { return _tHashLBrace; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ReturnTypeQualifierGreen> ReturnTypeQualifierList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ReturnTypeQualifierGreen>(_returnTypeQualifierList, reversed: false); } }
		public InternalSyntaxToken TRBrace { get { return _tRBrace; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PReferenceAlt3Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tHashLBrace;
				case 1: return _returnTypeQualifierList;
				case 2: return _tRBrace;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPReferenceAlt3Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPReferenceAlt3Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PReferenceAlt3Green(this.Kind, _tHashLBrace, _returnTypeQualifierList, _tRBrace, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PReferenceAlt3Green(this.Kind, _tHashLBrace, _returnTypeQualifierList, _tRBrace, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PReferenceAlt3Green(this.Kind, _tHashLBrace, _returnTypeQualifierList, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PReferenceAlt3Green Update(InternalSyntaxToken tHashLBrace, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ReturnTypeQualifierGreen> returnTypeQualifierList, InternalSyntaxToken tRBrace)
		{
			if (_tHashLBrace != tHashLBrace || _returnTypeQualifierList != returnTypeQualifierList.Node || _tRBrace != tRBrace)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PReferenceAlt3((InternalSyntaxToken)tHashLBrace, returnTypeQualifierList, (InternalSyntaxToken)tRBrace);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PReferenceAlt3Green)newNode;
			}
			return this;
		}
	}
	
	internal class LAlternativeGreen : GreenSyntaxNode
	{
		internal static new readonly LAlternativeGreen __Missing = new LAlternativeGreen();
		private GreenNode _elements;
	
		public LAlternativeGreen(CompilerSyntaxKind kind, GreenNode elements)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (elements != null)
			{
				AdjustFlagsAndWidth(elements);
				_elements = elements;
			}
		}
	
		public LAlternativeGreen(CompilerSyntaxKind kind, GreenNode elements, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LElementGreen> Elements { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LElementGreen>(_elements); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LAlternativeSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _elements;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLAlternativeGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLAlternativeGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LAlternativeGreen(this.Kind, _elements, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LAlternativeGreen(this.Kind, _elements, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LAlternativeGreen(this.Kind, _elements, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LAlternativeGreen Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LElementGreen> elements)
		{
			if (_elements != elements.Node)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LAlternative(elements);
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
		private InternalSyntaxToken _isNegated;
		private LElementValueGreen _value;
		private InternalSyntaxToken _multiplicity;
	
		public LElementGreen(CompilerSyntaxKind kind, InternalSyntaxToken isNegated, LElementValueGreen value, InternalSyntaxToken multiplicity)
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
	
		public LElementGreen(CompilerSyntaxKind kind, InternalSyntaxToken isNegated, LElementValueGreen value, InternalSyntaxToken multiplicity, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		public InternalSyntaxToken IsNegated { get { return _isNegated; } }
		public LElementValueGreen Value { get { return _value; } }
		public InternalSyntaxToken Multiplicity { get { return _multiplicity; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LElementSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
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
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LElementGreen(this.Kind, _isNegated, _value, _multiplicity, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LElementGreen(this.Kind, _isNegated, _value, _multiplicity, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LElementGreen(this.Kind, _isNegated, _value, _multiplicity, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LElementGreen Update(InternalSyntaxToken isNegated, LElementValueGreen value, InternalSyntaxToken multiplicity)
		{
			if (_isNegated != isNegated || _value != value || _multiplicity != multiplicity)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LElement((InternalSyntaxToken)isNegated, value, (InternalSyntaxToken)multiplicity);
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
		internal static readonly LElementValueGreen __Missing = LBlockGreen.__Missing;
	
	    protected LElementValueGreen(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class LBlockGreen : LElementValueGreen
	{
		internal static new readonly LBlockGreen __Missing = new LBlockGreen();
		private InternalSyntaxToken _tLParen;
		private GreenNode _lAlternativeList;
		private InternalSyntaxToken _tRParen;
	
		public LBlockGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLParen, GreenNode lAlternativeList, InternalSyntaxToken tRParen)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (lAlternativeList != null)
			{
				AdjustFlagsAndWidth(lAlternativeList);
				_lAlternativeList = lAlternativeList;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
		}
	
		public LBlockGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLParen, GreenNode lAlternativeList, InternalSyntaxToken tRParen, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (lAlternativeList != null)
			{
				AdjustFlagsAndWidth(lAlternativeList);
				_lAlternativeList = lAlternativeList;
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
	
		public InternalSyntaxToken TLParen { get { return _tLParen; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> LAlternativeList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen>(_lAlternativeList, reversed: false); } }
		public InternalSyntaxToken TRParen { get { return _tRParen; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LBlockSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLParen;
				case 1: return _lAlternativeList;
				case 2: return _tRParen;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLBlockGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLBlockGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LBlockGreen(this.Kind, _tLParen, _lAlternativeList, _tRParen, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LBlockGreen(this.Kind, _tLParen, _lAlternativeList, _tRParen, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LBlockGreen(this.Kind, _tLParen, _lAlternativeList, _tRParen, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LBlockGreen Update(InternalSyntaxToken tLParen, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> lAlternativeList, InternalSyntaxToken tRParen)
		{
			if (_tLParen != tLParen || _lAlternativeList != lAlternativeList.Node || _tRParen != tRParen)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LBlock((InternalSyntaxToken)tLParen, lAlternativeList, (InternalSyntaxToken)tRParen);
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
	
	internal class LFixedGreen : LElementValueGreen
	{
		internal static new readonly LFixedGreen __Missing = new LFixedGreen();
		private InternalSyntaxToken _text;
	
		public LFixedGreen(CompilerSyntaxKind kind, InternalSyntaxToken text)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (text != null)
			{
				AdjustFlagsAndWidth(text);
				_text = text;
			}
		}
	
		public LFixedGreen(CompilerSyntaxKind kind, InternalSyntaxToken text, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (text != null)
			{
				AdjustFlagsAndWidth(text);
				_text = text;
			}
		}
	
		private LFixedGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LFixed, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken Text { get { return _text; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LFixedSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _text;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLFixedGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLFixedGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LFixedGreen(this.Kind, _text, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LFixedGreen(this.Kind, _text, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LFixedGreen(this.Kind, _text, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LFixedGreen Update(InternalSyntaxToken text)
		{
			if (_text != text)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LFixed((InternalSyntaxToken)text);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LFixedGreen)newNode;
			}
			return this;
		}
	}
	
	internal class LWildCardGreen : LElementValueGreen
	{
		internal static new readonly LWildCardGreen __Missing = new LWildCardGreen();
		private InternalSyntaxToken _tDot;
	
		public LWildCardGreen(CompilerSyntaxKind kind, InternalSyntaxToken tDot)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tDot != null)
			{
				AdjustFlagsAndWidth(tDot);
				_tDot = tDot;
			}
		}
	
		public LWildCardGreen(CompilerSyntaxKind kind, InternalSyntaxToken tDot, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tDot != null)
			{
				AdjustFlagsAndWidth(tDot);
				_tDot = tDot;
			}
		}
	
		private LWildCardGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LWildCard, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TDot { get { return _tDot; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LWildCardSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tDot;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLWildCardGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLWildCardGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LWildCardGreen(this.Kind, _tDot, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LWildCardGreen(this.Kind, _tDot, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LWildCardGreen(this.Kind, _tDot, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LWildCardGreen Update(InternalSyntaxToken tDot)
		{
			if (_tDot != tDot)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LWildCard((InternalSyntaxToken)tDot);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LWildCardGreen)newNode;
			}
			return this;
		}
	}
	
	internal class LRangeGreen : LElementValueGreen
	{
		internal static new readonly LRangeGreen __Missing = new LRangeGreen();
		private InternalSyntaxToken _startChar;
		private InternalSyntaxToken _tDotDot;
		private InternalSyntaxToken _endChar;
	
		public LRangeGreen(CompilerSyntaxKind kind, InternalSyntaxToken startChar, InternalSyntaxToken tDotDot, InternalSyntaxToken endChar)
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
	
		public LRangeGreen(CompilerSyntaxKind kind, InternalSyntaxToken startChar, InternalSyntaxToken tDotDot, InternalSyntaxToken endChar, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		public InternalSyntaxToken StartChar { get { return _startChar; } }
		public InternalSyntaxToken TDotDot { get { return _tDotDot; } }
		public InternalSyntaxToken EndChar { get { return _endChar; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LRangeSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
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
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LRangeGreen(this.Kind, _startChar, _tDotDot, _endChar, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LRangeGreen(this.Kind, _startChar, _tDotDot, _endChar, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LRangeGreen(this.Kind, _startChar, _tDotDot, _endChar, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LRangeGreen Update(InternalSyntaxToken startChar, InternalSyntaxToken tDotDot, InternalSyntaxToken endChar)
		{
			if (_startChar != startChar || _tDotDot != tDotDot || _endChar != endChar)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LRange((InternalSyntaxToken)startChar, (InternalSyntaxToken)tDotDot, (InternalSyntaxToken)endChar);
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
	
		public LReferenceGreen(CompilerSyntaxKind kind, IdentifierGreen rule, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LReferenceSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _rule;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLReferenceGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLReferenceGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LReferenceGreen(this.Kind, _rule, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LReferenceGreen(this.Kind, _rule, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LReferenceGreen(this.Kind, _rule, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LReferenceGreen Update(IdentifierGreen rule)
		{
			if (_rule != rule)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LReference(rule);
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
		private QualifierGreen _symbolValue;
	
		public ReferenceExpressionGreen(CompilerSyntaxKind kind, QualifierGreen symbolValue)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (symbolValue != null)
			{
				AdjustFlagsAndWidth(symbolValue);
				_symbolValue = symbolValue;
			}
		}
	
		public ReferenceExpressionGreen(CompilerSyntaxKind kind, QualifierGreen symbolValue, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (symbolValue != null)
			{
				AdjustFlagsAndWidth(symbolValue);
				_symbolValue = symbolValue;
			}
		}
	
		private ReferenceExpressionGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ReferenceExpression, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public QualifierGreen SymbolValue { get { return _symbolValue; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ReferenceExpressionSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _symbolValue;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitReferenceExpressionGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitReferenceExpressionGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ReferenceExpressionGreen(this.Kind, _symbolValue, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ReferenceExpressionGreen(this.Kind, _symbolValue, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ReferenceExpressionGreen(this.Kind, _symbolValue, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ReferenceExpressionGreen Update(QualifierGreen symbolValue)
		{
			if (_symbolValue != symbolValue)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ReferenceExpression(symbolValue);
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
	
	internal class ArrayExpressionGreen : ExpressionGreen
	{
		internal static new readonly ArrayExpressionGreen __Missing = new ArrayExpressionGreen();
		private InternalSyntaxToken _tLBrace;
		private ArrayExpressionBlock1Green _arrayExpressionBlock1;
		private InternalSyntaxToken _tRBrace;
	
		public ArrayExpressionGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLBrace, ArrayExpressionBlock1Green arrayExpressionBlock1, InternalSyntaxToken tRBrace)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (arrayExpressionBlock1 != null)
			{
				AdjustFlagsAndWidth(arrayExpressionBlock1);
				_arrayExpressionBlock1 = arrayExpressionBlock1;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		public ArrayExpressionGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLBrace, ArrayExpressionBlock1Green arrayExpressionBlock1, InternalSyntaxToken tRBrace, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (arrayExpressionBlock1 != null)
			{
				AdjustFlagsAndWidth(arrayExpressionBlock1);
				_arrayExpressionBlock1 = arrayExpressionBlock1;
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
	
		public InternalSyntaxToken TLBrace { get { return _tLBrace; } }
		public ArrayExpressionBlock1Green ArrayExpressionBlock1 { get { return _arrayExpressionBlock1; } }
		public InternalSyntaxToken TRBrace { get { return _tRBrace; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ArrayExpressionSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLBrace;
				case 1: return _arrayExpressionBlock1;
				case 2: return _tRBrace;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitArrayExpressionGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitArrayExpressionGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ArrayExpressionGreen(this.Kind, _tLBrace, _arrayExpressionBlock1, _tRBrace, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ArrayExpressionGreen(this.Kind, _tLBrace, _arrayExpressionBlock1, _tRBrace, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ArrayExpressionGreen(this.Kind, _tLBrace, _arrayExpressionBlock1, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ArrayExpressionGreen Update(InternalSyntaxToken tLBrace, ArrayExpressionBlock1Green arrayExpressionBlock1, InternalSyntaxToken tRBrace)
		{
			if (_tLBrace != tLBrace || _arrayExpressionBlock1 != arrayExpressionBlock1 || _tRBrace != tRBrace)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpression((InternalSyntaxToken)tLBrace, arrayExpressionBlock1, (InternalSyntaxToken)tRBrace);
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
	
	internal class ParserAnnotationGreen : GreenSyntaxNode
	{
		internal static new readonly ParserAnnotationGreen __Missing = new ParserAnnotationGreen();
		private InternalSyntaxToken _tLBracket;
		private QualifierGreen _type;
		private AnnotationArgumentsGreen _annotationArguments;
		private InternalSyntaxToken _tRBracket;
	
		public ParserAnnotationGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLBracket, QualifierGreen type, AnnotationArgumentsGreen annotationArguments, InternalSyntaxToken tRBracket)
			: base(kind, null, null)
		{
			SlotCount = 4;
			if (tLBracket != null)
			{
				AdjustFlagsAndWidth(tLBracket);
				_tLBracket = tLBracket;
			}
			if (type != null)
			{
				AdjustFlagsAndWidth(type);
				_type = type;
			}
			if (annotationArguments != null)
			{
				AdjustFlagsAndWidth(annotationArguments);
				_annotationArguments = annotationArguments;
			}
			if (tRBracket != null)
			{
				AdjustFlagsAndWidth(tRBracket);
				_tRBracket = tRBracket;
			}
		}
	
		public ParserAnnotationGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLBracket, QualifierGreen type, AnnotationArgumentsGreen annotationArguments, InternalSyntaxToken tRBracket, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 4;
			if (tLBracket != null)
			{
				AdjustFlagsAndWidth(tLBracket);
				_tLBracket = tLBracket;
			}
			if (type != null)
			{
				AdjustFlagsAndWidth(type);
				_type = type;
			}
			if (annotationArguments != null)
			{
				AdjustFlagsAndWidth(annotationArguments);
				_annotationArguments = annotationArguments;
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
	
		public InternalSyntaxToken TLBracket { get { return _tLBracket; } }
		public QualifierGreen Type { get { return _type; } }
		public AnnotationArgumentsGreen AnnotationArguments { get { return _annotationArguments; } }
		public InternalSyntaxToken TRBracket { get { return _tRBracket; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserAnnotationSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLBracket;
				case 1: return _type;
				case 2: return _annotationArguments;
				case 3: return _tRBracket;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserAnnotationGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserAnnotationGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParserAnnotationGreen(this.Kind, _tLBracket, _type, _annotationArguments, _tRBracket, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParserAnnotationGreen(this.Kind, _tLBracket, _type, _annotationArguments, _tRBracket, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ParserAnnotationGreen(this.Kind, _tLBracket, _type, _annotationArguments, _tRBracket, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserAnnotationGreen Update(InternalSyntaxToken tLBracket, QualifierGreen type, AnnotationArgumentsGreen annotationArguments, InternalSyntaxToken tRBracket)
		{
			if (_tLBracket != tLBracket || _type != type || _annotationArguments != annotationArguments || _tRBracket != tRBracket)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserAnnotation((InternalSyntaxToken)tLBracket, type, annotationArguments, (InternalSyntaxToken)tRBracket);
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
		private InternalSyntaxToken _tLBracket;
		private QualifierGreen _type;
		private AnnotationArgumentsGreen _annotationArguments;
		private InternalSyntaxToken _tRBracket;
	
		public LexerAnnotationGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLBracket, QualifierGreen type, AnnotationArgumentsGreen annotationArguments, InternalSyntaxToken tRBracket)
			: base(kind, null, null)
		{
			SlotCount = 4;
			if (tLBracket != null)
			{
				AdjustFlagsAndWidth(tLBracket);
				_tLBracket = tLBracket;
			}
			if (type != null)
			{
				AdjustFlagsAndWidth(type);
				_type = type;
			}
			if (annotationArguments != null)
			{
				AdjustFlagsAndWidth(annotationArguments);
				_annotationArguments = annotationArguments;
			}
			if (tRBracket != null)
			{
				AdjustFlagsAndWidth(tRBracket);
				_tRBracket = tRBracket;
			}
		}
	
		public LexerAnnotationGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLBracket, QualifierGreen type, AnnotationArgumentsGreen annotationArguments, InternalSyntaxToken tRBracket, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 4;
			if (tLBracket != null)
			{
				AdjustFlagsAndWidth(tLBracket);
				_tLBracket = tLBracket;
			}
			if (type != null)
			{
				AdjustFlagsAndWidth(type);
				_type = type;
			}
			if (annotationArguments != null)
			{
				AdjustFlagsAndWidth(annotationArguments);
				_annotationArguments = annotationArguments;
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
	
		public InternalSyntaxToken TLBracket { get { return _tLBracket; } }
		public QualifierGreen Type { get { return _type; } }
		public AnnotationArgumentsGreen AnnotationArguments { get { return _annotationArguments; } }
		public InternalSyntaxToken TRBracket { get { return _tRBracket; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LexerAnnotationSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLBracket;
				case 1: return _type;
				case 2: return _annotationArguments;
				case 3: return _tRBracket;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLexerAnnotationGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLexerAnnotationGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LexerAnnotationGreen(this.Kind, _tLBracket, _type, _annotationArguments, _tRBracket, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LexerAnnotationGreen(this.Kind, _tLBracket, _type, _annotationArguments, _tRBracket, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LexerAnnotationGreen(this.Kind, _tLBracket, _type, _annotationArguments, _tRBracket, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LexerAnnotationGreen Update(InternalSyntaxToken tLBracket, QualifierGreen type, AnnotationArgumentsGreen annotationArguments, InternalSyntaxToken tRBracket)
		{
			if (_tLBracket != tLBracket || _type != type || _annotationArguments != annotationArguments || _tRBracket != tRBracket)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LexerAnnotation((InternalSyntaxToken)tLBracket, type, annotationArguments, (InternalSyntaxToken)tRBracket);
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
	
	internal class AnnotationArgumentsGreen : GreenSyntaxNode
	{
		internal static new readonly AnnotationArgumentsGreen __Missing = new AnnotationArgumentsGreen();
		private InternalSyntaxToken _tLParen;
		private GreenNode _annotationArgumentList;
		private InternalSyntaxToken _tRParen;
	
		public AnnotationArgumentsGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLParen, GreenNode annotationArgumentList, InternalSyntaxToken tRParen)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (annotationArgumentList != null)
			{
				AdjustFlagsAndWidth(annotationArgumentList);
				_annotationArgumentList = annotationArgumentList;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
		}
	
		public AnnotationArgumentsGreen(CompilerSyntaxKind kind, InternalSyntaxToken tLParen, GreenNode annotationArgumentList, InternalSyntaxToken tRParen, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tLParen != null)
			{
				AdjustFlagsAndWidth(tLParen);
				_tLParen = tLParen;
			}
			if (annotationArgumentList != null)
			{
				AdjustFlagsAndWidth(annotationArgumentList);
				_annotationArgumentList = annotationArgumentList;
			}
			if (tRParen != null)
			{
				AdjustFlagsAndWidth(tRParen);
				_tRParen = tRParen;
			}
		}
	
		private AnnotationArgumentsGreen()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArguments, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TLParen { get { return _tLParen; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AnnotationArgumentGreen> AnnotationArgumentList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AnnotationArgumentGreen>(_annotationArgumentList, reversed: false); } }
		public InternalSyntaxToken TRParen { get { return _tRParen; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.AnnotationArgumentsSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLParen;
				case 1: return _annotationArgumentList;
				case 2: return _tRParen;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitAnnotationArgumentsGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitAnnotationArgumentsGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new AnnotationArgumentsGreen(this.Kind, _tLParen, _annotationArgumentList, _tRParen, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new AnnotationArgumentsGreen(this.Kind, _tLParen, _annotationArgumentList, _tRParen, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new AnnotationArgumentsGreen(this.Kind, _tLParen, _annotationArgumentList, _tRParen, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public AnnotationArgumentsGreen Update(InternalSyntaxToken tLParen, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AnnotationArgumentGreen> annotationArgumentList, InternalSyntaxToken tRParen)
		{
			if (_tLParen != tLParen || _annotationArgumentList != annotationArgumentList.Node || _tRParen != tRParen)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArguments((InternalSyntaxToken)tLParen, annotationArgumentList, (InternalSyntaxToken)tRParen);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (AnnotationArgumentsGreen)newNode;
			}
			return this;
		}
	}
	
	internal class AnnotationArgumentGreen : GreenSyntaxNode
	{
		internal static new readonly AnnotationArgumentGreen __Missing = new AnnotationArgumentGreen();
		private AnnotationArgumentBlock1Green _annotationArgumentBlock1;
		private ExpressionGreen _value;
	
		public AnnotationArgumentGreen(CompilerSyntaxKind kind, AnnotationArgumentBlock1Green annotationArgumentBlock1, ExpressionGreen value)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (annotationArgumentBlock1 != null)
			{
				AdjustFlagsAndWidth(annotationArgumentBlock1);
				_annotationArgumentBlock1 = annotationArgumentBlock1;
			}
			if (value != null)
			{
				AdjustFlagsAndWidth(value);
				_value = value;
			}
		}
	
		public AnnotationArgumentGreen(CompilerSyntaxKind kind, AnnotationArgumentBlock1Green annotationArgumentBlock1, ExpressionGreen value, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (annotationArgumentBlock1 != null)
			{
				AdjustFlagsAndWidth(annotationArgumentBlock1);
				_annotationArgumentBlock1 = annotationArgumentBlock1;
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
	
		public AnnotationArgumentBlock1Green AnnotationArgumentBlock1 { get { return _annotationArgumentBlock1; } }
		public ExpressionGreen Value { get { return _value; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.AnnotationArgumentSyntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotationArgumentBlock1;
				case 1: return _value;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitAnnotationArgumentGreen(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitAnnotationArgumentGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new AnnotationArgumentGreen(this.Kind, _annotationArgumentBlock1, _value, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new AnnotationArgumentGreen(this.Kind, _annotationArgumentBlock1, _value, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new AnnotationArgumentGreen(this.Kind, _annotationArgumentBlock1, _value, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public AnnotationArgumentGreen Update(AnnotationArgumentBlock1Green annotationArgumentBlock1, ExpressionGreen value)
		{
			if (_annotationArgumentBlock1 != annotationArgumentBlock1 || _value != value)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgument(annotationArgumentBlock1, value);
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
	
	internal abstract class ReturnTypeIdentifierGreen : GreenSyntaxNode
	{
		internal static readonly ReturnTypeIdentifierGreen __Missing = ReturnTypeIdentifierAlt1Green.__Missing;
	
	    protected ReturnTypeIdentifierGreen(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class ReturnTypeIdentifierAlt1Green : ReturnTypeIdentifierGreen
	{
		internal static new readonly ReturnTypeIdentifierAlt1Green __Missing = new ReturnTypeIdentifierAlt1Green();
		private InternalSyntaxToken _tPrimitiveType;
	
		public ReturnTypeIdentifierAlt1Green(CompilerSyntaxKind kind, InternalSyntaxToken tPrimitiveType)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tPrimitiveType != null)
			{
				AdjustFlagsAndWidth(tPrimitiveType);
				_tPrimitiveType = tPrimitiveType;
			}
		}
	
		public ReturnTypeIdentifierAlt1Green(CompilerSyntaxKind kind, InternalSyntaxToken tPrimitiveType, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tPrimitiveType != null)
			{
				AdjustFlagsAndWidth(tPrimitiveType);
				_tPrimitiveType = tPrimitiveType;
			}
		}
	
		private ReturnTypeIdentifierAlt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeIdentifierAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TPrimitiveType { get { return _tPrimitiveType; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ReturnTypeIdentifierAlt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tPrimitiveType;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitReturnTypeIdentifierAlt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitReturnTypeIdentifierAlt1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ReturnTypeIdentifierAlt1Green(this.Kind, _tPrimitiveType, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ReturnTypeIdentifierAlt1Green(this.Kind, _tPrimitiveType, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ReturnTypeIdentifierAlt1Green(this.Kind, _tPrimitiveType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ReturnTypeIdentifierAlt1Green Update(InternalSyntaxToken tPrimitiveType)
		{
			if (_tPrimitiveType != tPrimitiveType)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeIdentifierAlt1((InternalSyntaxToken)tPrimitiveType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ReturnTypeIdentifierAlt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class ReturnTypeIdentifierAlt2Green : ReturnTypeIdentifierGreen
	{
		internal static new readonly ReturnTypeIdentifierAlt2Green __Missing = new ReturnTypeIdentifierAlt2Green();
		private IdentifierGreen _identifier;
	
		public ReturnTypeIdentifierAlt2Green(CompilerSyntaxKind kind, IdentifierGreen identifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
		}
	
		public ReturnTypeIdentifierAlt2Green(CompilerSyntaxKind kind, IdentifierGreen identifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
		}
	
		private ReturnTypeIdentifierAlt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeIdentifierAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Identifier { get { return _identifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ReturnTypeIdentifierAlt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _identifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitReturnTypeIdentifierAlt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitReturnTypeIdentifierAlt2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ReturnTypeIdentifierAlt2Green(this.Kind, _identifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ReturnTypeIdentifierAlt2Green(this.Kind, _identifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ReturnTypeIdentifierAlt2Green(this.Kind, _identifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ReturnTypeIdentifierAlt2Green Update(IdentifierGreen identifier)
		{
			if (_identifier != identifier)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeIdentifierAlt2(identifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ReturnTypeIdentifierAlt2Green)newNode;
			}
			return this;
		}
	}
	
	internal abstract class ReturnTypeQualifierGreen : GreenSyntaxNode
	{
		internal static readonly ReturnTypeQualifierGreen __Missing = ReturnTypeQualifierAlt1Green.__Missing;
	
	    protected ReturnTypeQualifierGreen(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class ReturnTypeQualifierAlt1Green : ReturnTypeQualifierGreen
	{
		internal static new readonly ReturnTypeQualifierAlt1Green __Missing = new ReturnTypeQualifierAlt1Green();
		private InternalSyntaxToken _tPrimitiveType;
	
		public ReturnTypeQualifierAlt1Green(CompilerSyntaxKind kind, InternalSyntaxToken tPrimitiveType)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tPrimitiveType != null)
			{
				AdjustFlagsAndWidth(tPrimitiveType);
				_tPrimitiveType = tPrimitiveType;
			}
		}
	
		public ReturnTypeQualifierAlt1Green(CompilerSyntaxKind kind, InternalSyntaxToken tPrimitiveType, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tPrimitiveType != null)
			{
				AdjustFlagsAndWidth(tPrimitiveType);
				_tPrimitiveType = tPrimitiveType;
			}
		}
	
		private ReturnTypeQualifierAlt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeQualifierAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TPrimitiveType { get { return _tPrimitiveType; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ReturnTypeQualifierAlt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tPrimitiveType;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitReturnTypeQualifierAlt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitReturnTypeQualifierAlt1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ReturnTypeQualifierAlt1Green(this.Kind, _tPrimitiveType, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ReturnTypeQualifierAlt1Green(this.Kind, _tPrimitiveType, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ReturnTypeQualifierAlt1Green(this.Kind, _tPrimitiveType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ReturnTypeQualifierAlt1Green Update(InternalSyntaxToken tPrimitiveType)
		{
			if (_tPrimitiveType != tPrimitiveType)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeQualifierAlt1((InternalSyntaxToken)tPrimitiveType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ReturnTypeQualifierAlt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class ReturnTypeQualifierAlt2Green : ReturnTypeQualifierGreen
	{
		internal static new readonly ReturnTypeQualifierAlt2Green __Missing = new ReturnTypeQualifierAlt2Green();
		private QualifierGreen _qualifier;
	
		public ReturnTypeQualifierAlt2Green(CompilerSyntaxKind kind, QualifierGreen qualifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		public ReturnTypeQualifierAlt2Green(CompilerSyntaxKind kind, QualifierGreen qualifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		private ReturnTypeQualifierAlt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeQualifierAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public QualifierGreen Qualifier { get { return _qualifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ReturnTypeQualifierAlt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _qualifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitReturnTypeQualifierAlt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitReturnTypeQualifierAlt2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ReturnTypeQualifierAlt2Green(this.Kind, _qualifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ReturnTypeQualifierAlt2Green(this.Kind, _qualifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ReturnTypeQualifierAlt2Green(this.Kind, _qualifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ReturnTypeQualifierAlt2Green Update(QualifierGreen qualifier)
		{
			if (_qualifier != qualifier)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeQualifierAlt2(qualifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ReturnTypeQualifierAlt2Green)newNode;
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
	
	internal abstract class IdentifierGreen : GreenSyntaxNode
	{
		internal static readonly IdentifierGreen __Missing = IdentifierAlt1Green.__Missing;
	
	    protected IdentifierGreen(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class IdentifierAlt1Green : IdentifierGreen
	{
		internal static new readonly IdentifierAlt1Green __Missing = new IdentifierAlt1Green();
		private InternalSyntaxToken _tIdentifier;
	
		public IdentifierAlt1Green(CompilerSyntaxKind kind, InternalSyntaxToken tIdentifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
			}
		}
	
		public IdentifierAlt1Green(CompilerSyntaxKind kind, InternalSyntaxToken tIdentifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
			}
		}
	
		private IdentifierAlt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.IdentifierAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TIdentifier { get { return _tIdentifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.IdentifierAlt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tIdentifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitIdentifierAlt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitIdentifierAlt1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new IdentifierAlt1Green(this.Kind, _tIdentifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new IdentifierAlt1Green(this.Kind, _tIdentifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new IdentifierAlt1Green(this.Kind, _tIdentifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public IdentifierAlt1Green Update(InternalSyntaxToken tIdentifier)
		{
			if (_tIdentifier != tIdentifier)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.IdentifierAlt1((InternalSyntaxToken)tIdentifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (IdentifierAlt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class IdentifierAlt2Green : IdentifierGreen
	{
		internal static new readonly IdentifierAlt2Green __Missing = new IdentifierAlt2Green();
		private InternalSyntaxToken _tVerbatimIdentifier;
	
		public IdentifierAlt2Green(CompilerSyntaxKind kind, InternalSyntaxToken tVerbatimIdentifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tVerbatimIdentifier != null)
			{
				AdjustFlagsAndWidth(tVerbatimIdentifier);
				_tVerbatimIdentifier = tVerbatimIdentifier;
			}
		}
	
		public IdentifierAlt2Green(CompilerSyntaxKind kind, InternalSyntaxToken tVerbatimIdentifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tVerbatimIdentifier != null)
			{
				AdjustFlagsAndWidth(tVerbatimIdentifier);
				_tVerbatimIdentifier = tVerbatimIdentifier;
			}
		}
	
		private IdentifierAlt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.IdentifierAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TVerbatimIdentifier { get { return _tVerbatimIdentifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.IdentifierAlt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tVerbatimIdentifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitIdentifierAlt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitIdentifierAlt2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new IdentifierAlt2Green(this.Kind, _tVerbatimIdentifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new IdentifierAlt2Green(this.Kind, _tVerbatimIdentifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new IdentifierAlt2Green(this.Kind, _tVerbatimIdentifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public IdentifierAlt2Green Update(InternalSyntaxToken tVerbatimIdentifier)
		{
			if (_tVerbatimIdentifier != tVerbatimIdentifier)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.IdentifierAlt2((InternalSyntaxToken)tVerbatimIdentifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (IdentifierAlt2Green)newNode;
			}
			return this;
		}
	}
	
	internal class GrammarBlock1Green : GreenSyntaxNode
	{
		internal static new readonly GrammarBlock1Green __Missing = new GrammarBlock1Green();
		private GreenNode _rules;
	
		public GrammarBlock1Green(CompilerSyntaxKind kind, GreenNode rules)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (rules != null)
			{
				AdjustFlagsAndWidth(rules);
				_rules = rules;
			}
		}
	
		public GrammarBlock1Green(CompilerSyntaxKind kind, GreenNode rules, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (rules != null)
			{
				AdjustFlagsAndWidth(rules);
				_rules = rules;
			}
		}
	
		private GrammarBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.GrammarBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<RuleGreen> Rules { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<RuleGreen>(_rules); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.GrammarBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _rules;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitGrammarBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitGrammarBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new GrammarBlock1Green(this.Kind, _rules, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new GrammarBlock1Green(this.Kind, _rules, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new GrammarBlock1Green(this.Kind, _rules, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public GrammarBlock1Green Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<RuleGreen> rules)
		{
			if (_rules != rules.Node)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.GrammarBlock1(rules);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (GrammarBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal abstract class ParserRuleBlock1Green : GreenSyntaxNode
	{
		internal static readonly ParserRuleBlock1Green __Missing = ParserRuleBlock1Alt1Green.__Missing;
	
	    protected ParserRuleBlock1Green(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class ParserRuleBlock1Alt1Green : ParserRuleBlock1Green
	{
		internal static new readonly ParserRuleBlock1Alt1Green __Missing = new ParserRuleBlock1Alt1Green();
		private ReturnTypeIdentifierGreen _returnType;
	
		public ParserRuleBlock1Alt1Green(CompilerSyntaxKind kind, ReturnTypeIdentifierGreen returnType)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
		}
	
		public ParserRuleBlock1Alt1Green(CompilerSyntaxKind kind, ReturnTypeIdentifierGreen returnType, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (returnType != null)
			{
				AdjustFlagsAndWidth(returnType);
				_returnType = returnType;
			}
		}
	
		private ParserRuleBlock1Alt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleBlock1Alt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public ReturnTypeIdentifierGreen ReturnType { get { return _returnType; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserRuleBlock1Alt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _returnType;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserRuleBlock1Alt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserRuleBlock1Alt1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParserRuleBlock1Alt1Green(this.Kind, _returnType, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParserRuleBlock1Alt1Green(this.Kind, _returnType, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ParserRuleBlock1Alt1Green(this.Kind, _returnType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserRuleBlock1Alt1Green Update(ReturnTypeIdentifierGreen returnType)
		{
			if (_returnType != returnType)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleBlock1Alt1(returnType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleBlock1Alt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class ParserRuleBlock1Alt2Green : ParserRuleBlock1Green
	{
		internal static new readonly ParserRuleBlock1Alt2Green __Missing = new ParserRuleBlock1Alt2Green();
		private IdentifierGreen _identifier;
		private InternalSyntaxToken _kReturns;
		private ReturnTypeQualifierGreen _returnType;
	
		public ParserRuleBlock1Alt2Green(CompilerSyntaxKind kind, IdentifierGreen identifier, InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
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
	
		public ParserRuleBlock1Alt2Green(CompilerSyntaxKind kind, IdentifierGreen identifier, InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private ParserRuleBlock1Alt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleBlock1Alt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Identifier { get { return _identifier; } }
		public InternalSyntaxToken KReturns { get { return _kReturns; } }
		public ReturnTypeQualifierGreen ReturnType { get { return _returnType; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ParserRuleBlock1Alt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _identifier;
				case 1: return _kReturns;
				case 2: return _returnType;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParserRuleBlock1Alt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitParserRuleBlock1Alt2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParserRuleBlock1Alt2Green(this.Kind, _identifier, _kReturns, _returnType, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParserRuleBlock1Alt2Green(this.Kind, _identifier, _kReturns, _returnType, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ParserRuleBlock1Alt2Green(this.Kind, _identifier, _kReturns, _returnType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ParserRuleBlock1Alt2Green Update(IdentifierGreen identifier, InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
		{
			if (_identifier != identifier || _kReturns != kReturns || _returnType != returnType)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleBlock1Alt2(identifier, (InternalSyntaxToken)kReturns, returnType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleBlock1Alt2Green)newNode;
			}
			return this;
		}
	}
	
	internal class ParserRuleBlock2Green : GreenSyntaxNode
	{
		internal static new readonly ParserRuleBlock2Green __Missing = new ParserRuleBlock2Green();
		private InternalSyntaxToken _tBar;
		private PAlternativeGreen _alternatives;
	
		public ParserRuleBlock2Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, PAlternativeGreen alternatives)
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
	
		public ParserRuleBlock2Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, PAlternativeGreen alternatives, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
		public PAlternativeGreen Alternatives { get { return _alternatives; } }
	
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
	
	
		public ParserRuleBlock2Green Update(InternalSyntaxToken tBar, PAlternativeGreen alternatives)
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
	
	internal class PBlockBlock1Green : GreenSyntaxNode
	{
		internal static new readonly PBlockBlock1Green __Missing = new PBlockBlock1Green();
		private InternalSyntaxToken _tBar;
		private PAlternativeGreen _alternatives;
	
		public PBlockBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, PAlternativeGreen alternatives)
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
	
		public PBlockBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, PAlternativeGreen alternatives, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private PBlockBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PBlockBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TBar { get { return _tBar; } }
		public PAlternativeGreen Alternatives { get { return _alternatives; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PBlockBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPBlockBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPBlockBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PBlockBlock1Green(this.Kind, _tBar, _alternatives, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PBlockBlock1Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PBlockBlock1Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PBlockBlock1Green Update(InternalSyntaxToken tBar, PAlternativeGreen alternatives)
		{
			if (_tBar != tBar || _alternatives != alternatives)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PBlockBlock1((InternalSyntaxToken)tBar, alternatives);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PBlockBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class PBlockInlineBlock1Green : GreenSyntaxNode
	{
		internal static new readonly PBlockInlineBlock1Green __Missing = new PBlockInlineBlock1Green();
		private InternalSyntaxToken _tBar;
		private PAlternativeGreen _alternatives;
	
		public PBlockInlineBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, PAlternativeGreen alternatives)
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
	
		public PBlockInlineBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, PAlternativeGreen alternatives, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private PBlockInlineBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PBlockInlineBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TBar { get { return _tBar; } }
		public PAlternativeGreen Alternatives { get { return _alternatives; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PBlockInlineBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPBlockInlineBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPBlockInlineBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PBlockInlineBlock1Green(this.Kind, _tBar, _alternatives, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PBlockInlineBlock1Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PBlockInlineBlock1Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PBlockInlineBlock1Green Update(InternalSyntaxToken tBar, PAlternativeGreen alternatives)
		{
			if (_tBar != tBar || _alternatives != alternatives)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PBlockInlineBlock1((InternalSyntaxToken)tBar, alternatives);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PBlockInlineBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class PAlternativeBlock1Green : GreenSyntaxNode
	{
		internal static new readonly PAlternativeBlock1Green __Missing = new PAlternativeBlock1Green();
		private GreenNode _annotations1;
		private InternalSyntaxToken _kAlt;
		private NameGreen _name;
		private PAlternativeBlock1Block1Green _pAlternativeBlock1Block1;
		private InternalSyntaxToken _tColon;
	
		public PAlternativeBlock1Green(CompilerSyntaxKind kind, GreenNode annotations1, InternalSyntaxToken kAlt, NameGreen name, PAlternativeBlock1Block1Green pAlternativeBlock1Block1, InternalSyntaxToken tColon)
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
			if (pAlternativeBlock1Block1 != null)
			{
				AdjustFlagsAndWidth(pAlternativeBlock1Block1);
				_pAlternativeBlock1Block1 = pAlternativeBlock1Block1;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
		}
	
		public PAlternativeBlock1Green(CompilerSyntaxKind kind, GreenNode annotations1, InternalSyntaxToken kAlt, NameGreen name, PAlternativeBlock1Block1Green pAlternativeBlock1Block1, InternalSyntaxToken tColon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			if (pAlternativeBlock1Block1 != null)
			{
				AdjustFlagsAndWidth(pAlternativeBlock1Block1);
				_pAlternativeBlock1Block1 = pAlternativeBlock1Block1;
			}
			if (tColon != null)
			{
				AdjustFlagsAndWidth(tColon);
				_tColon = tColon;
			}
		}
	
		private PAlternativeBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PAlternativeBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> Annotations1 { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_annotations1); } }
		public InternalSyntaxToken KAlt { get { return _kAlt; } }
		public NameGreen Name { get { return _name; } }
		public PAlternativeBlock1Block1Green PAlternativeBlock1Block1 { get { return _pAlternativeBlock1Block1; } }
		public InternalSyntaxToken TColon { get { return _tColon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PAlternativeBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _annotations1;
				case 1: return _kAlt;
				case 2: return _name;
				case 3: return _pAlternativeBlock1Block1;
				case 4: return _tColon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPAlternativeBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPAlternativeBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PAlternativeBlock1Green(this.Kind, _annotations1, _kAlt, _name, _pAlternativeBlock1Block1, _tColon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PAlternativeBlock1Green(this.Kind, _annotations1, _kAlt, _name, _pAlternativeBlock1Block1, _tColon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PAlternativeBlock1Green(this.Kind, _annotations1, _kAlt, _name, _pAlternativeBlock1Block1, _tColon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PAlternativeBlock1Green Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, InternalSyntaxToken kAlt, NameGreen name, PAlternativeBlock1Block1Green pAlternativeBlock1Block1, InternalSyntaxToken tColon)
		{
			if (_annotations1 != annotations1.Node || _kAlt != kAlt || _name != name || _pAlternativeBlock1Block1 != pAlternativeBlock1Block1 || _tColon != tColon)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PAlternativeBlock1(annotations1, (InternalSyntaxToken)kAlt, name, pAlternativeBlock1Block1, (InternalSyntaxToken)tColon);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PAlternativeBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class PAlternativeBlock2Green : GreenSyntaxNode
	{
		internal static new readonly PAlternativeBlock2Green __Missing = new PAlternativeBlock2Green();
		private InternalSyntaxToken _tEqGt;
		private ExpressionGreen _returnValue;
	
		public PAlternativeBlock2Green(CompilerSyntaxKind kind, InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
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
	
		public PAlternativeBlock2Green(CompilerSyntaxKind kind, InternalSyntaxToken tEqGt, ExpressionGreen returnValue, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private PAlternativeBlock2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PAlternativeBlock2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TEqGt { get { return _tEqGt; } }
		public ExpressionGreen ReturnValue { get { return _returnValue; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PAlternativeBlock2Syntax(this, (CompilerSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPAlternativeBlock2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPAlternativeBlock2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PAlternativeBlock2Green(this.Kind, _tEqGt, _returnValue, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PAlternativeBlock2Green(this.Kind, _tEqGt, _returnValue, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PAlternativeBlock2Green(this.Kind, _tEqGt, _returnValue, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PAlternativeBlock2Green Update(InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
		{
			if (_tEqGt != tEqGt || _returnValue != returnValue)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PAlternativeBlock2((InternalSyntaxToken)tEqGt, returnValue);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PAlternativeBlock2Green)newNode;
			}
			return this;
		}
	}
	
	internal class PElementBlock1Green : GreenSyntaxNode
	{
		internal static new readonly PElementBlock1Green __Missing = new PElementBlock1Green();
		private GreenNode _nameAnnotations;
		private IdentifierGreen _symbolProperty;
		private InternalSyntaxToken _assignment;
	
		public PElementBlock1Green(CompilerSyntaxKind kind, GreenNode nameAnnotations, IdentifierGreen symbolProperty, InternalSyntaxToken assignment)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (nameAnnotations != null)
			{
				AdjustFlagsAndWidth(nameAnnotations);
				_nameAnnotations = nameAnnotations;
			}
			if (symbolProperty != null)
			{
				AdjustFlagsAndWidth(symbolProperty);
				_symbolProperty = symbolProperty;
			}
			if (assignment != null)
			{
				AdjustFlagsAndWidth(assignment);
				_assignment = assignment;
			}
		}
	
		public PElementBlock1Green(CompilerSyntaxKind kind, GreenNode nameAnnotations, IdentifierGreen symbolProperty, InternalSyntaxToken assignment, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (nameAnnotations != null)
			{
				AdjustFlagsAndWidth(nameAnnotations);
				_nameAnnotations = nameAnnotations;
			}
			if (symbolProperty != null)
			{
				AdjustFlagsAndWidth(symbolProperty);
				_symbolProperty = symbolProperty;
			}
			if (assignment != null)
			{
				AdjustFlagsAndWidth(assignment);
				_assignment = assignment;
			}
		}
	
		private PElementBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PElementBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> NameAnnotations { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen>(_nameAnnotations); } }
		public IdentifierGreen SymbolProperty { get { return _symbolProperty; } }
		public InternalSyntaxToken Assignment { get { return _assignment; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PElementBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _nameAnnotations;
				case 1: return _symbolProperty;
				case 2: return _assignment;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPElementBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPElementBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PElementBlock1Green(this.Kind, _nameAnnotations, _symbolProperty, _assignment, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PElementBlock1Green(this.Kind, _nameAnnotations, _symbolProperty, _assignment, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PElementBlock1Green(this.Kind, _nameAnnotations, _symbolProperty, _assignment, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PElementBlock1Green Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> nameAnnotations, IdentifierGreen symbolProperty, InternalSyntaxToken assignment)
		{
			if (_nameAnnotations != nameAnnotations.Node || _symbolProperty != symbolProperty || _assignment != assignment)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PElementBlock1(nameAnnotations, symbolProperty, (InternalSyntaxToken)assignment);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PElementBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class PReferenceAlt3Block1Green : GreenSyntaxNode
	{
		internal static new readonly PReferenceAlt3Block1Green __Missing = new PReferenceAlt3Block1Green();
		private InternalSyntaxToken _tComma;
		private ReturnTypeQualifierGreen _referencedTypes;
	
		public PReferenceAlt3Block1Green(CompilerSyntaxKind kind, InternalSyntaxToken tComma, ReturnTypeQualifierGreen referencedTypes)
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
	
		public PReferenceAlt3Block1Green(CompilerSyntaxKind kind, InternalSyntaxToken tComma, ReturnTypeQualifierGreen referencedTypes, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private PReferenceAlt3Block1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PReferenceAlt3Block1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TComma { get { return _tComma; } }
		public ReturnTypeQualifierGreen ReferencedTypes { get { return _referencedTypes; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PReferenceAlt3Block1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _referencedTypes;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPReferenceAlt3Block1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPReferenceAlt3Block1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PReferenceAlt3Block1Green(this.Kind, _tComma, _referencedTypes, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PReferenceAlt3Block1Green(this.Kind, _tComma, _referencedTypes, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PReferenceAlt3Block1Green(this.Kind, _tComma, _referencedTypes, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PReferenceAlt3Block1Green Update(InternalSyntaxToken tComma, ReturnTypeQualifierGreen referencedTypes)
		{
			if (_tComma != tComma || _referencedTypes != referencedTypes)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PReferenceAlt3Block1((InternalSyntaxToken)tComma, referencedTypes);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PReferenceAlt3Block1Green)newNode;
			}
			return this;
		}
	}
	
	internal abstract class LexerRuleBlock1Green : GreenSyntaxNode
	{
		internal static readonly LexerRuleBlock1Green __Missing = LexerRuleBlock1Alt1Green.__Missing;
	
	    protected LexerRuleBlock1Green(CompilerSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class LexerRuleBlock1Alt1Green : LexerRuleBlock1Green
	{
		internal static new readonly LexerRuleBlock1Alt1Green __Missing = new LexerRuleBlock1Alt1Green();
		private InternalSyntaxToken _kToken;
		private NameGreen _name;
		private LexerRuleBlock1Alt1Block1Green _lexerRuleBlock1Alt1Block1;
	
		public LexerRuleBlock1Alt1Green(CompilerSyntaxKind kind, InternalSyntaxToken kToken, NameGreen name, LexerRuleBlock1Alt1Block1Green lexerRuleBlock1Alt1Block1)
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
			if (lexerRuleBlock1Alt1Block1 != null)
			{
				AdjustFlagsAndWidth(lexerRuleBlock1Alt1Block1);
				_lexerRuleBlock1Alt1Block1 = lexerRuleBlock1Alt1Block1;
			}
		}
	
		public LexerRuleBlock1Alt1Green(CompilerSyntaxKind kind, InternalSyntaxToken kToken, NameGreen name, LexerRuleBlock1Alt1Block1Green lexerRuleBlock1Alt1Block1, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			if (lexerRuleBlock1Alt1Block1 != null)
			{
				AdjustFlagsAndWidth(lexerRuleBlock1Alt1Block1);
				_lexerRuleBlock1Alt1Block1 = lexerRuleBlock1Alt1Block1;
			}
		}
	
		private LexerRuleBlock1Alt1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LexerRuleBlock1Alt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KToken { get { return _kToken; } }
		public NameGreen Name { get { return _name; } }
		public LexerRuleBlock1Alt1Block1Green LexerRuleBlock1Alt1Block1 { get { return _lexerRuleBlock1Alt1Block1; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LexerRuleBlock1Alt1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kToken;
				case 1: return _name;
				case 2: return _lexerRuleBlock1Alt1Block1;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLexerRuleBlock1Alt1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLexerRuleBlock1Alt1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LexerRuleBlock1Alt1Green(this.Kind, _kToken, _name, _lexerRuleBlock1Alt1Block1, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LexerRuleBlock1Alt1Green(this.Kind, _kToken, _name, _lexerRuleBlock1Alt1Block1, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LexerRuleBlock1Alt1Green(this.Kind, _kToken, _name, _lexerRuleBlock1Alt1Block1, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LexerRuleBlock1Alt1Green Update(InternalSyntaxToken kToken, NameGreen name, LexerRuleBlock1Alt1Block1Green lexerRuleBlock1Alt1Block1)
		{
			if (_kToken != kToken || _name != name || _lexerRuleBlock1Alt1Block1 != lexerRuleBlock1Alt1Block1)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleBlock1Alt1((InternalSyntaxToken)kToken, name, lexerRuleBlock1Alt1Block1);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleBlock1Alt1Green)newNode;
			}
			return this;
		}
	}
	
	internal class LexerRuleBlock1Alt2Green : LexerRuleBlock1Green
	{
		internal static new readonly LexerRuleBlock1Alt2Green __Missing = new LexerRuleBlock1Alt2Green();
		private InternalSyntaxToken _isHidden;
		private NameGreen _name;
	
		public LexerRuleBlock1Alt2Green(CompilerSyntaxKind kind, InternalSyntaxToken isHidden, NameGreen name)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (isHidden != null)
			{
				AdjustFlagsAndWidth(isHidden);
				_isHidden = isHidden;
			}
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
		}
	
		public LexerRuleBlock1Alt2Green(CompilerSyntaxKind kind, InternalSyntaxToken isHidden, NameGreen name, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (isHidden != null)
			{
				AdjustFlagsAndWidth(isHidden);
				_isHidden = isHidden;
			}
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
		}
	
		private LexerRuleBlock1Alt2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LexerRuleBlock1Alt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken IsHidden { get { return _isHidden; } }
		public NameGreen Name { get { return _name; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LexerRuleBlock1Alt2Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _isHidden;
				case 1: return _name;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLexerRuleBlock1Alt2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLexerRuleBlock1Alt2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LexerRuleBlock1Alt2Green(this.Kind, _isHidden, _name, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LexerRuleBlock1Alt2Green(this.Kind, _isHidden, _name, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LexerRuleBlock1Alt2Green(this.Kind, _isHidden, _name, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LexerRuleBlock1Alt2Green Update(InternalSyntaxToken isHidden, NameGreen name)
		{
			if (_isHidden != isHidden || _name != name)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleBlock1Alt2((InternalSyntaxToken)isHidden, name);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleBlock1Alt2Green)newNode;
			}
			return this;
		}
	}
	
	internal class LexerRuleBlock1Alt3Green : LexerRuleBlock1Green
	{
		internal static new readonly LexerRuleBlock1Alt3Green __Missing = new LexerRuleBlock1Alt3Green();
		private InternalSyntaxToken _isFragment;
		private NameGreen _name;
	
		public LexerRuleBlock1Alt3Green(CompilerSyntaxKind kind, InternalSyntaxToken isFragment, NameGreen name)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (isFragment != null)
			{
				AdjustFlagsAndWidth(isFragment);
				_isFragment = isFragment;
			}
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
		}
	
		public LexerRuleBlock1Alt3Green(CompilerSyntaxKind kind, InternalSyntaxToken isFragment, NameGreen name, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (isFragment != null)
			{
				AdjustFlagsAndWidth(isFragment);
				_isFragment = isFragment;
			}
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
		}
	
		private LexerRuleBlock1Alt3Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LexerRuleBlock1Alt3, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken IsFragment { get { return _isFragment; } }
		public NameGreen Name { get { return _name; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LexerRuleBlock1Alt3Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _isFragment;
				case 1: return _name;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLexerRuleBlock1Alt3Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLexerRuleBlock1Alt3Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LexerRuleBlock1Alt3Green(this.Kind, _isFragment, _name, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LexerRuleBlock1Alt3Green(this.Kind, _isFragment, _name, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LexerRuleBlock1Alt3Green(this.Kind, _isFragment, _name, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LexerRuleBlock1Alt3Green Update(InternalSyntaxToken isFragment, NameGreen name)
		{
			if (_isFragment != isFragment || _name != name)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleBlock1Alt3((InternalSyntaxToken)isFragment, name);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleBlock1Alt3Green)newNode;
			}
			return this;
		}
	}
	
	internal class LexerRuleBlock2Green : GreenSyntaxNode
	{
		internal static new readonly LexerRuleBlock2Green __Missing = new LexerRuleBlock2Green();
		private InternalSyntaxToken _tBar;
		private LAlternativeGreen _alternatives;
	
		public LexerRuleBlock2Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, LAlternativeGreen alternatives)
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
	
		public LexerRuleBlock2Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, LAlternativeGreen alternatives, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private LexerRuleBlock2Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LexerRuleBlock2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TBar { get { return _tBar; } }
		public LAlternativeGreen Alternatives { get { return _alternatives; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LexerRuleBlock2Syntax(this, (CompilerSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLexerRuleBlock2Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLexerRuleBlock2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LexerRuleBlock2Green(this.Kind, _tBar, _alternatives, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LexerRuleBlock2Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LexerRuleBlock2Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LexerRuleBlock2Green Update(InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
			if (_tBar != tBar || _alternatives != alternatives)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleBlock2((InternalSyntaxToken)tBar, alternatives);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleBlock2Green)newNode;
			}
			return this;
		}
	}
	
	internal class LBlockBlock1Green : GreenSyntaxNode
	{
		internal static new readonly LBlockBlock1Green __Missing = new LBlockBlock1Green();
		private InternalSyntaxToken _tBar;
		private LAlternativeGreen _alternatives;
	
		public LBlockBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, LAlternativeGreen alternatives)
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
	
		public LBlockBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tBar, LAlternativeGreen alternatives, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private LBlockBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LBlockBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TBar { get { return _tBar; } }
		public LAlternativeGreen Alternatives { get { return _alternatives; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LBlockBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLBlockBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLBlockBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LBlockBlock1Green(this.Kind, _tBar, _alternatives, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LBlockBlock1Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LBlockBlock1Green(this.Kind, _tBar, _alternatives, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LBlockBlock1Green Update(InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
			if (_tBar != tBar || _alternatives != alternatives)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LBlockBlock1((InternalSyntaxToken)tBar, alternatives);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LBlockBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class ArrayExpressionBlock1Green : GreenSyntaxNode
	{
		internal static new readonly ArrayExpressionBlock1Green __Missing = new ArrayExpressionBlock1Green();
		private GreenNode _expressionList;
	
		public ArrayExpressionBlock1Green(CompilerSyntaxKind kind, GreenNode expressionList)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (expressionList != null)
			{
				AdjustFlagsAndWidth(expressionList);
				_expressionList = expressionList;
			}
		}
	
		public ArrayExpressionBlock1Green(CompilerSyntaxKind kind, GreenNode expressionList, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (expressionList != null)
			{
				AdjustFlagsAndWidth(expressionList);
				_expressionList = expressionList;
			}
		}
	
		private ArrayExpressionBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ArrayExpressionBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ExpressionGreen> ExpressionList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ExpressionGreen>(_expressionList, reversed: false); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ArrayExpressionBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _expressionList;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitArrayExpressionBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitArrayExpressionBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ArrayExpressionBlock1Green(this.Kind, _expressionList, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ArrayExpressionBlock1Green(this.Kind, _expressionList, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ArrayExpressionBlock1Green(this.Kind, _expressionList, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ArrayExpressionBlock1Green Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ExpressionGreen> expressionList)
		{
			if (_expressionList != expressionList.Node)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpressionBlock1(expressionList);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ArrayExpressionBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class AnnotationArgumentsBlock1Green : GreenSyntaxNode
	{
		internal static new readonly AnnotationArgumentsBlock1Green __Missing = new AnnotationArgumentsBlock1Green();
		private InternalSyntaxToken _tComma;
		private AnnotationArgumentGreen _arguments;
	
		public AnnotationArgumentsBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tComma, AnnotationArgumentGreen arguments)
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
	
		public AnnotationArgumentsBlock1Green(CompilerSyntaxKind kind, InternalSyntaxToken tComma, AnnotationArgumentGreen arguments, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private AnnotationArgumentsBlock1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArgumentsBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TComma { get { return _tComma; } }
		public AnnotationArgumentGreen Arguments { get { return _arguments; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.AnnotationArgumentsBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _arguments;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitAnnotationArgumentsBlock1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitAnnotationArgumentsBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new AnnotationArgumentsBlock1Green(this.Kind, _tComma, _arguments, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new AnnotationArgumentsBlock1Green(this.Kind, _tComma, _arguments, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new AnnotationArgumentsBlock1Green(this.Kind, _tComma, _arguments, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public AnnotationArgumentsBlock1Green Update(InternalSyntaxToken tComma, AnnotationArgumentGreen arguments)
		{
			if (_tComma != tComma || _arguments != arguments)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgumentsBlock1((InternalSyntaxToken)tComma, arguments);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (AnnotationArgumentsBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class AnnotationArgumentBlock1Green : GreenSyntaxNode
	{
		internal static new readonly AnnotationArgumentBlock1Green __Missing = new AnnotationArgumentBlock1Green();
		private IdentifierGreen _namedParameter;
		private InternalSyntaxToken _tColon;
	
		public AnnotationArgumentBlock1Green(CompilerSyntaxKind kind, IdentifierGreen namedParameter, InternalSyntaxToken tColon)
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
	
		public AnnotationArgumentBlock1Green(CompilerSyntaxKind kind, IdentifierGreen namedParameter, InternalSyntaxToken tColon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
		public InternalSyntaxToken TColon { get { return _tColon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.AnnotationArgumentBlock1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
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
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new AnnotationArgumentBlock1Green(this.Kind, _namedParameter, _tColon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new AnnotationArgumentBlock1Green(this.Kind, _namedParameter, _tColon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new AnnotationArgumentBlock1Green(this.Kind, _namedParameter, _tColon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public AnnotationArgumentBlock1Green Update(IdentifierGreen namedParameter, InternalSyntaxToken tColon)
		{
			if (_namedParameter != namedParameter || _tColon != tColon)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgumentBlock1(namedParameter, (InternalSyntaxToken)tColon);
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
	
	internal class PAlternativeBlock1Block1Green : GreenSyntaxNode
	{
		internal static new readonly PAlternativeBlock1Block1Green __Missing = new PAlternativeBlock1Block1Green();
		private InternalSyntaxToken _kReturns;
		private ReturnTypeQualifierGreen _returnType;
	
		public PAlternativeBlock1Block1Green(CompilerSyntaxKind kind, InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
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
	
		public PAlternativeBlock1Block1Green(CompilerSyntaxKind kind, InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private PAlternativeBlock1Block1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.PAlternativeBlock1Block1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KReturns { get { return _kReturns; } }
		public ReturnTypeQualifierGreen ReturnType { get { return _returnType; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.PAlternativeBlock1Block1Syntax(this, (CompilerSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPAlternativeBlock1Block1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitPAlternativeBlock1Block1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PAlternativeBlock1Block1Green(this.Kind, _kReturns, _returnType, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PAlternativeBlock1Block1Green(this.Kind, _kReturns, _returnType, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PAlternativeBlock1Block1Green(this.Kind, _kReturns, _returnType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PAlternativeBlock1Block1Green Update(InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
		{
			if (_kReturns != kReturns || _returnType != returnType)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.PAlternativeBlock1Block1((InternalSyntaxToken)kReturns, returnType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PAlternativeBlock1Block1Green)newNode;
			}
			return this;
		}
	}
	
	internal class LexerRuleBlock1Alt1Block1Green : GreenSyntaxNode
	{
		internal static new readonly LexerRuleBlock1Alt1Block1Green __Missing = new LexerRuleBlock1Alt1Block1Green();
		private InternalSyntaxToken _kReturns;
		private ReturnTypeQualifierGreen _returnType;
	
		public LexerRuleBlock1Alt1Block1Green(CompilerSyntaxKind kind, InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
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
	
		public LexerRuleBlock1Alt1Block1Green(CompilerSyntaxKind kind, InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private LexerRuleBlock1Alt1Block1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.LexerRuleBlock1Alt1Block1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KReturns { get { return _kReturns; } }
		public ReturnTypeQualifierGreen ReturnType { get { return _returnType; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.LexerRuleBlock1Alt1Block1Syntax(this, (CompilerSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLexerRuleBlock1Alt1Block1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitLexerRuleBlock1Alt1Block1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LexerRuleBlock1Alt1Block1Green(this.Kind, _kReturns, _returnType, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LexerRuleBlock1Alt1Block1Green(this.Kind, _kReturns, _returnType, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new LexerRuleBlock1Alt1Block1Green(this.Kind, _kReturns, _returnType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public LexerRuleBlock1Alt1Block1Green Update(InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
		{
			if (_kReturns != kReturns || _returnType != returnType)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleBlock1Alt1Block1((InternalSyntaxToken)kReturns, returnType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleBlock1Alt1Block1Green)newNode;
			}
			return this;
		}
	}
	
	internal class ArrayExpressionBlock1Block1Green : GreenSyntaxNode
	{
		internal static new readonly ArrayExpressionBlock1Block1Green __Missing = new ArrayExpressionBlock1Block1Green();
		private InternalSyntaxToken _tComma;
		private ExpressionGreen _items;
	
		public ArrayExpressionBlock1Block1Green(CompilerSyntaxKind kind, InternalSyntaxToken tComma, ExpressionGreen items)
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
	
		public ArrayExpressionBlock1Block1Green(CompilerSyntaxKind kind, InternalSyntaxToken tComma, ExpressionGreen items, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private ArrayExpressionBlock1Block1Green()
			: base((CompilerSyntaxKind)CompilerSyntaxKind.ArrayExpressionBlock1Block1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TComma { get { return _tComma; } }
		public ExpressionGreen Items { get { return _items; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.ArrayExpressionBlock1Block1Syntax(this, (CompilerSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _items;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(CompilerInternalSyntaxVisitor<TResult> visitor) => visitor.VisitArrayExpressionBlock1Block1Green(this);
	
		public override void Accept(CompilerInternalSyntaxVisitor visitor) => visitor.VisitArrayExpressionBlock1Block1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ArrayExpressionBlock1Block1Green(this.Kind, _tComma, _items, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ArrayExpressionBlock1Block1Green(this.Kind, _tComma, _items, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ArrayExpressionBlock1Block1Green(this.Kind, _tComma, _items, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ArrayExpressionBlock1Block1Green Update(InternalSyntaxToken tComma, ExpressionGreen items)
		{
			if (_tComma != tComma || _items != items)
			{
				InternalSyntaxNode newNode = CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpressionBlock1Block1((InternalSyntaxToken)tComma, items);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ArrayExpressionBlock1Block1Green)newNode;
			}
			return this;
		}
	}
	
}
