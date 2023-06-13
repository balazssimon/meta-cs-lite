// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// WARNING: This is an auto-generated file. Any manual changes will be lost when the file is regenerated.
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax
{
    using System.Runtime.CompilerServices;
    using MetaDslx.CodeAnalysis;
    using MetaDslx.CodeAnalysis.Syntax;
    using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
    using Roslyn.Utilities;
    //using MetaDslx.CodeAnalysis.Antlr4;
    using MetaDslx.CodeAnalysis.Text;
    //using global::Antlr4.Runtime;

    internal abstract class GreenSyntaxNode : InternalSyntaxNode
    {
        protected GreenSyntaxNode(SandySyntaxKind kind)
            : base((ushort)kind)
        {
        }

        protected GreenSyntaxNode(SandySyntaxKind kind, int fullWidth)
            : base((ushort)kind, fullWidth)
        {
        }

        protected GreenSyntaxNode(SandySyntaxKind kind, DiagnosticInfo[] diagnostics)
            : base((ushort)kind, diagnostics)
        {
        }

        protected GreenSyntaxNode(SandySyntaxKind kind, DiagnosticInfo[] diagnostics, int fullWidth)
            : base((ushort)kind, diagnostics, fullWidth)
        {
        }

        protected GreenSyntaxNode(SandySyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
            : base((ushort)kind, diagnostics, annotations)
        {
        }

        protected GreenSyntaxNode(SandySyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations, int fullWidth)
            : base((ushort)kind, diagnostics, annotations, fullWidth)
        {
        }

        public override TResult Accept<TResult>(InternalSyntaxVisitor<TResult> visitor)
        {
            if (visitor is SandyInternalSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public override void Accept(InternalSyntaxVisitor visitor) 
        {
            if (visitor is SandyInternalSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor);
        public abstract void Accept(SandyInternalSyntaxVisitor visitor);

        public override SandyLanguage Language => SandyLanguage.Instance;
        public SandySyntaxKind Kind => (SandySyntaxKind)this.RawKind;
		public override string KindText => SandyLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		// Use conditional weak table so we always return same identity for structured trivia
		private static readonly ConditionalWeakTable<SyntaxNode, Dictionary<SyntaxTrivia, SyntaxNode>> s_structuresTable
			= new ConditionalWeakTable<SyntaxNode, Dictionary<SyntaxTrivia, SyntaxNode>>();

		/// <summary>
		/// Gets the syntax node represented the structure of this trivia, if any. The HasStructure property can be used to 
		/// determine if this trivia has structure.
		/// </summary>
		/// <returns>
		/// A SandySyntaxNode derived from StructuredTriviaSyntax, with the structured view of this trivia node. 
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
							structure = SandyStructuredTriviaSyntax.Create(trivia);
							structsInParent.Add(trivia, structure);
						}
					}

					return structure;
				}
				else
				{
					return SandyStructuredTriviaSyntax.Create(trivia);
				}
			}

			return null;
		}

	}

    internal class GreenSyntaxTrivia : InternalSyntaxTrivia
    {
        internal GreenSyntaxTrivia(SandySyntaxKind kind, string text, DiagnosticInfo[] diagnostics = null, SyntaxAnnotation[] annotations = null)
            : base((ushort)kind, text, diagnostics, annotations)
        {
        }

		public override SandyLanguage Language => SandyLanguage.Instance;
		public SandySyntaxKind Kind => (SandySyntaxKind)this.RawKind;
		public override string KindText => SandyLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		internal static GreenSyntaxTrivia Create(SandySyntaxKind kind, string text)
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
        internal GreenStructuredTriviaSyntax(SandySyntaxKind kind, DiagnosticInfo[] diagnostics = null, SyntaxAnnotation[] annotations = null)
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

        internal GreenSkippedTokensTriviaSyntax(SandySyntaxKind kind, GreenNode tokens, DiagnosticInfo[] diagnostics = null, SyntaxAnnotation[] annotations = null)
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

        protected override SyntaxNode CreateRed(SyntaxNode parent, int position) => new SandySkippedTokensTriviaSyntax(this, (SandySyntaxNode)parent, position);

        public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSkippedTokensTrivia(this);

        public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitSkippedTokensTrivia(this);

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
	    internal GreenSyntaxToken(SandySyntaxKind kind)
	        : base((ushort)kind)
	    {
	    }
	    internal GreenSyntaxToken(SandySyntaxKind kind, DiagnosticInfo[] diagnostics)
	        : base((ushort)kind, diagnostics)
	    {
	    }
	    internal GreenSyntaxToken(SandySyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base((ushort)kind, diagnostics, annotations)
	    {
	    }
	    internal GreenSyntaxToken(SandySyntaxKind kind, int fullWidth)
	        : base((ushort)kind, fullWidth)
	    {
	    }
	    internal GreenSyntaxToken(SandySyntaxKind kind, int fullWidth, DiagnosticInfo[] diagnostics)
	        : base((ushort)kind, fullWidth, diagnostics)
	    {
	    }
	    internal GreenSyntaxToken(SandySyntaxKind kind, int fullWidth, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base((ushort)kind, fullWidth, diagnostics, annotations)
	    {
	    }

	    public override SandyLanguage Language => SandyLanguage.Instance;
	    public SandySyntaxKind Kind => (SandySyntaxKind)this.RawKind;
		public override string KindText => SandyLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		//====================
		internal static GreenSyntaxToken Create(SandySyntaxKind kind)
	    {
	        if (kind > LastTokenWithWellKnownText)
	        {
	            if (!SandyLanguage.Instance.SyntaxFacts.IsToken(kind))
	            {
	                throw new ArgumentException(string.Format("Invalid SandySyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
	            }
	            return CreateMissing(kind, null, null);
	        }
	        return s_tokensWithNoTrivia[(int)kind].Value;
	    }
	    internal static GreenSyntaxToken Create(SandySyntaxKind kind, GreenNode? leading, GreenNode? trailing)
	    {
	        if (kind > LastTokenWithWellKnownText)
	        {
	            if (!SandyLanguage.Instance.SyntaxFacts.IsToken(kind))
	            {
	                throw new ArgumentException(string.Format("Invalid SandySyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
	            }
	            return CreateMissing(kind, leading, trailing);
	        }
	        if (leading == null)
	        {
	            if (trailing == null)
	            {
	                return s_tokensWithNoTrivia[(int)kind].Value;
	            }
	            else if (trailing == SandyLanguage.Instance.InternalSyntaxFactory.Space)
	            {
	                return s_tokensWithSingleTrailingSpace[(int)kind].Value;
	            }
	            else if (trailing == SandyLanguage.Instance.InternalSyntaxFactory.CarriageReturnLineFeed)
	            {
	                return s_tokensWithSingleTrailingCRLF[(int)kind].Value;
	            }
	        }
	        if (leading == SandyLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace && trailing == SandyLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace)
	        {
	            return s_tokensWithElasticTrivia[(int)kind].Value;
	        }
	        return new SyntaxTokenWithTrivia(kind, leading, trailing);
	    }
	    internal static GreenSyntaxToken CreateMissing(SandySyntaxKind kind, GreenNode? leading, GreenNode? trailing)
	    {
	        return new MissingTokenWithTrivia(kind, leading, trailing);
	    }
	    internal static readonly SandySyntaxKind FirstTokenWithWellKnownText;
	    internal static readonly SandySyntaxKind LastTokenWithWellKnownText;
	    // TODO: eliminate the blank space before the first interesting element?
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithNoTrivia;
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithElasticTrivia;
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingSpace;
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingCRLF;
	    static GreenSyntaxToken()
	    {
	        FirstTokenWithWellKnownText = SandySyntaxKind.__FirstFixedToken;
	        LastTokenWithWellKnownText = SandySyntaxKind.__LastFixedToken;
	        s_tokensWithNoTrivia = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithElasticTrivia = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithSingleTrailingSpace = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithSingleTrailingCRLF = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
			InternalSyntaxFactory factory = SandyLanguage.Instance.InternalSyntaxFactory;
	        for (SandySyntaxKind kind = FirstTokenWithWellKnownText; kind <= LastTokenWithWellKnownText; kind++)
	        {
	            s_tokensWithNoTrivia[(int)kind].Value = new GreenSyntaxToken((SandySyntaxKind)kind);
	            s_tokensWithElasticTrivia[(int)kind].Value = new SyntaxTokenWithTrivia((SandySyntaxKind)kind, factory.ElasticZeroSpace, factory.ElasticZeroSpace);
	            s_tokensWithSingleTrailingSpace[(int)kind].Value = new SyntaxTokenWithTrivia((SandySyntaxKind)kind, null, factory.Space);
	            s_tokensWithSingleTrailingCRLF[(int)kind].Value = new SyntaxTokenWithTrivia((SandySyntaxKind)kind, null, factory.CarriageReturnLineFeed);
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
	    internal static GreenSyntaxToken Identifier(SandySyntaxKind kind, string text)
	    {
	        return new SyntaxIdentifier(kind, text);
	    }
	    internal static GreenSyntaxToken Identifier(SandySyntaxKind kind, GreenNode leading, string text, GreenNode trailing)
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
	    internal static GreenSyntaxToken Identifier(SandySyntaxKind kind, SandySyntaxKind contextualKind, GreenNode leading, string text, string valueText, GreenNode trailing)
	    {
	        if (contextualKind == kind && valueText == text)
	        {
	            return Identifier(kind, leading, text, trailing);
	        }
	        return new SyntaxIdentifierWithTrivia(kind, contextualKind, text, valueText, leading, trailing);
	    }
	    internal static GreenSyntaxToken WithValue<T>(SandySyntaxKind kind, string text, T value)
	    {
	        return new SyntaxTokenWithValue<T>(kind, text, value);
	    }
	    internal static GreenSyntaxToken WithValue<T>(SandySyntaxKind kind, GreenNode? leading, string text, T value, GreenNode? trailing)
	    {
	        return new SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing);
	    }
	    public new virtual SandySyntaxKind ContextualKind => this.Kind;
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
	        internal MissingTokenWithTrivia(SandySyntaxKind kind, GreenNode? leading, GreenNode? trailing)
	            : base(kind, leading, trailing)
	        {
	            this.flags &= ~NodeFlags.IsNotMissing;
	        }
	        internal MissingTokenWithTrivia(SandySyntaxKind kind, GreenNode? leading, GreenNode? trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	                if (Language.SyntaxFacts.IsIdentifier(this.Kind)) return string.Empty;
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
	        internal SyntaxIdentifier(SandySyntaxKind kind, string text)
	            : base(kind, text.Length)
	        {
	            this.TextField = text;
	        }
	        internal SyntaxIdentifier(SandySyntaxKind kind, string text, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	        protected readonly SandySyntaxKind contextualKind;
	        protected readonly string valueText;
	        internal SyntaxIdentifierExtended(SandySyntaxKind kind, SandySyntaxKind contextualKind, string text, string valueText)
	            : base(kind, text)
	        {
	            this.contextualKind = contextualKind;
	            this.valueText = valueText;
	        }
	        internal SyntaxIdentifierExtended(SandySyntaxKind kind, SandySyntaxKind contextualKind, string text, string valueText, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	            : base(kind, text, diagnostics, annotations)
	        {
	            this.contextualKind = contextualKind;
	            this.valueText = valueText;
	        }
	        public override SandySyntaxKind ContextualKind
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
	        internal SyntaxIdentifierWithTrailingTrivia(SandySyntaxKind kind, string text, GreenNode? trailing)
	            : base(kind, text)
	        {
	            if (trailing != null)
	            {
	                this.AdjustFlagsAndWidth(trailing);
	                _trailing = trailing;
	            }
	        }
	        internal SyntaxIdentifierWithTrailingTrivia(SandySyntaxKind kind, string text, GreenNode? trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	            SandySyntaxKind kind,
	            SandySyntaxKind contextualKind,
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
	            SandySyntaxKind kind,
	            SandySyntaxKind contextualKind,
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
	        internal SyntaxTokenWithValue(SandySyntaxKind kind, string text, T value)
	            : base(kind, text.Length)
	        {
	            this.TextField = text;
	            this.ValueField = value;
	        }
	        internal SyntaxTokenWithValue(SandySyntaxKind kind, string text, T value, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	        internal SyntaxTokenWithValueAndTrivia(SandySyntaxKind kind, string text, T value, GreenNode? leading, GreenNode? trailing)
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
	            SandySyntaxKind kind,
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
	        internal SyntaxTokenWithTrivia(SandySyntaxKind kind, GreenNode? leading, GreenNode? trailing)
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
	        internal SyntaxTokenWithTrivia(SandySyntaxKind kind, GreenNode? leading, GreenNode? trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
		internal static readonly MainGreen __Missing = new MainGreen();
		private GreenNode line;
		private InternalSyntaxToken eOF;

		public MainGreen(SandySyntaxKind kind, GreenNode line, InternalSyntaxToken eOF)
			: base(kind, null, null)
		{
			this.SlotCount = 2;
			if (line != null)
			{
				this.AdjustFlagsAndWidth(line);
				this.line = line;
			}
			if (eOF != null)
			{
				this.AdjustFlagsAndWidth(eOF);
				this.eOF = eOF;
			}
		}

		public MainGreen(SandySyntaxKind kind, GreenNode line, InternalSyntaxToken eOF, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 2;
			if (line != null)
			{
				this.AdjustFlagsAndWidth(line);
				this.line = line;
			}
			if (eOF != null)
			{
				this.AdjustFlagsAndWidth(eOF);
				this.eOF = eOF;
			}
		}

		private MainGreen()
			: base((SandySyntaxKind)SandySyntaxKind.Main, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LineGreen> Line { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LineGreen>(this.line); } }
		public InternalSyntaxToken EndOfFileToken { get { return this.eOF; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.MainSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.line;
				case 1: return this.eOF;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitMainGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MainGreen(this.Kind, this.line, this.eOF, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MainGreen(this.Kind, this.line, this.eOF, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new MainGreen(this.Kind, this.line, this.eOF, this.GetDiagnostics(), this.GetAnnotations());
		}


		public MainGreen Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LineGreen> line, InternalSyntaxToken eOF)
		{
			if (this.Line != line ||
				this.EndOfFileToken != eOF)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.Main(line, eOF);
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

	internal class LineGreen : GreenSyntaxNode
	{
		internal static readonly LineGreen __Missing = new LineGreen();
		private StatementGreen statement;

		public LineGreen(SandySyntaxKind kind, StatementGreen statement)
			: base(kind, null, null)
		{
			this.SlotCount = 2;
			if (statement != null)
			{
				this.AdjustFlagsAndWidth(statement);
				this.statement = statement;
			}
		}

		public LineGreen(SandySyntaxKind kind, StatementGreen statement, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 2;
			if (statement != null)
			{
				this.AdjustFlagsAndWidth(statement);
				this.statement = statement;
			}
		}

		private LineGreen()
			: base((SandySyntaxKind)SandySyntaxKind.Line, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public StatementGreen Statement { get { return this.statement; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.LineSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.statement;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitLineGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitLineGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new LineGreen(this.Kind, this.statement, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new LineGreen(this.Kind, this.statement, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new LineGreen(this.Kind, this.statement, this.GetDiagnostics(), this.GetAnnotations());
		}


		public LineGreen Update(StatementGreen statement, InternalSyntaxToken nEWLINE)
		{
			if (this.Statement != statement)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.Line(statement);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (LineGreen)newNode;
			}
			return this;
		}
	}

	internal class StatementGreen : GreenSyntaxNode
	{
		internal static readonly StatementGreen __Missing = new StatementGreen();
		private VarDeclarationGreen varDeclaration;
		private AssignmentGreen assignment;
		private PrintGreen print;

		public StatementGreen(SandySyntaxKind kind, VarDeclarationGreen varDeclaration, AssignmentGreen assignment, PrintGreen print)
			: base(kind, null, null)
		{
			this.SlotCount = 3;
			if (varDeclaration != null)
			{
				this.AdjustFlagsAndWidth(varDeclaration);
				this.varDeclaration = varDeclaration;
			}
			if (assignment != null)
			{
				this.AdjustFlagsAndWidth(assignment);
				this.assignment = assignment;
			}
			if (print != null)
			{
				this.AdjustFlagsAndWidth(print);
				this.print = print;
			}
		}

		public StatementGreen(SandySyntaxKind kind, VarDeclarationGreen varDeclaration, AssignmentGreen assignment, PrintGreen print, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 3;
			if (varDeclaration != null)
			{
				this.AdjustFlagsAndWidth(varDeclaration);
				this.varDeclaration = varDeclaration;
			}
			if (assignment != null)
			{
				this.AdjustFlagsAndWidth(assignment);
				this.assignment = assignment;
			}
			if (print != null)
			{
				this.AdjustFlagsAndWidth(print);
				this.print = print;
			}
		}

		private StatementGreen()
			: base((SandySyntaxKind)SandySyntaxKind.Statement, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public VarDeclarationGreen VarDeclaration { get { return this.varDeclaration; } }
		public AssignmentGreen Assignment { get { return this.assignment; } }
		public PrintGreen Print { get { return this.print; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.StatementSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.varDeclaration;
				case 1: return this.assignment;
				case 2: return this.print;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitStatementGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitStatementGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new StatementGreen(this.Kind, this.varDeclaration, this.assignment, this.print, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new StatementGreen(this.Kind, this.varDeclaration, this.assignment, this.print, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new StatementGreen(this.Kind, this.varDeclaration, this.assignment, this.print, this.GetDiagnostics(), this.GetAnnotations());
		}


		public StatementGreen Update(VarDeclarationGreen varDeclaration)
		{
			if (this.varDeclaration != varDeclaration)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.Statement(varDeclaration);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (StatementGreen)newNode;
			}
			return this;
		}

		public StatementGreen Update(AssignmentGreen assignment)
		{
			if (this.assignment != assignment)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.Statement(assignment);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (StatementGreen)newNode;
			}
			return this;
		}

		public StatementGreen Update(PrintGreen print)
		{
			if (this.print != print)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.Statement(print);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (StatementGreen)newNode;
			}
			return this;
		}
	}

	internal class PrintGreen : GreenSyntaxNode
	{
		internal static readonly PrintGreen __Missing = new PrintGreen();
		private InternalSyntaxToken pRINT;
		private InternalSyntaxToken lPAREN;
		private ExpressionGreen expression;
		private InternalSyntaxToken rPAREN;

		public PrintGreen(SandySyntaxKind kind, InternalSyntaxToken pRINT, InternalSyntaxToken lPAREN, ExpressionGreen expression, InternalSyntaxToken rPAREN)
			: base(kind, null, null)
		{
			this.SlotCount = 4;
			if (pRINT != null)
			{
				this.AdjustFlagsAndWidth(pRINT);
				this.pRINT = pRINT;
			}
			if (lPAREN != null)
			{
				this.AdjustFlagsAndWidth(lPAREN);
				this.lPAREN = lPAREN;
			}
			if (expression != null)
			{
				this.AdjustFlagsAndWidth(expression);
				this.expression = expression;
			}
			if (rPAREN != null)
			{
				this.AdjustFlagsAndWidth(rPAREN);
				this.rPAREN = rPAREN;
			}
		}

		public PrintGreen(SandySyntaxKind kind, InternalSyntaxToken pRINT, InternalSyntaxToken lPAREN, ExpressionGreen expression, InternalSyntaxToken rPAREN, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 4;
			if (pRINT != null)
			{
				this.AdjustFlagsAndWidth(pRINT);
				this.pRINT = pRINT;
			}
			if (lPAREN != null)
			{
				this.AdjustFlagsAndWidth(lPAREN);
				this.lPAREN = lPAREN;
			}
			if (expression != null)
			{
				this.AdjustFlagsAndWidth(expression);
				this.expression = expression;
			}
			if (rPAREN != null)
			{
				this.AdjustFlagsAndWidth(rPAREN);
				this.rPAREN = rPAREN;
			}
		}

		private PrintGreen()
			: base((SandySyntaxKind)SandySyntaxKind.Print, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public InternalSyntaxToken PRINT { get { return this.pRINT; } }
		public InternalSyntaxToken LPAREN { get { return this.lPAREN; } }
		public ExpressionGreen Expression { get { return this.expression; } }
		public InternalSyntaxToken RPAREN { get { return this.rPAREN; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.PrintSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.pRINT;
				case 1: return this.lPAREN;
				case 2: return this.expression;
				case 3: return this.rPAREN;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPrintGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitPrintGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PrintGreen(this.Kind, this.pRINT, this.lPAREN, this.expression, this.rPAREN, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PrintGreen(this.Kind, this.pRINT, this.lPAREN, this.expression, this.rPAREN, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new PrintGreen(this.Kind, this.pRINT, this.lPAREN, this.expression, this.rPAREN, this.GetDiagnostics(), this.GetAnnotations());
		}


		public PrintGreen Update(InternalSyntaxToken pRINT, InternalSyntaxToken lPAREN, ExpressionGreen expression, InternalSyntaxToken rPAREN)
		{
			if (this.PRINT != pRINT ||
				this.LPAREN != lPAREN ||
				this.Expression != expression ||
				this.RPAREN != rPAREN)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.Print(pRINT, lPAREN, expression, rPAREN);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PrintGreen)newNode;
			}
			return this;
		}
	}

	internal class VarDeclarationGreen : GreenSyntaxNode
	{
		internal static readonly VarDeclarationGreen __Missing = new VarDeclarationGreen();
		private InternalSyntaxToken vAR;
		private AssignmentGreen assignment;

		public VarDeclarationGreen(SandySyntaxKind kind, InternalSyntaxToken vAR, AssignmentGreen assignment)
			: base(kind, null, null)
		{
			this.SlotCount = 2;
			if (vAR != null)
			{
				this.AdjustFlagsAndWidth(vAR);
				this.vAR = vAR;
			}
			if (assignment != null)
			{
				this.AdjustFlagsAndWidth(assignment);
				this.assignment = assignment;
			}
		}

		public VarDeclarationGreen(SandySyntaxKind kind, InternalSyntaxToken vAR, AssignmentGreen assignment, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 2;
			if (vAR != null)
			{
				this.AdjustFlagsAndWidth(vAR);
				this.vAR = vAR;
			}
			if (assignment != null)
			{
				this.AdjustFlagsAndWidth(assignment);
				this.assignment = assignment;
			}
		}

		private VarDeclarationGreen()
			: base((SandySyntaxKind)SandySyntaxKind.VarDeclaration, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public InternalSyntaxToken VAR { get { return this.vAR; } }
		public AssignmentGreen Assignment { get { return this.assignment; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.VarDeclarationSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.vAR;
				case 1: return this.assignment;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitVarDeclarationGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitVarDeclarationGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new VarDeclarationGreen(this.Kind, this.vAR, this.assignment, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new VarDeclarationGreen(this.Kind, this.vAR, this.assignment, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new VarDeclarationGreen(this.Kind, this.vAR, this.assignment, this.GetDiagnostics(), this.GetAnnotations());
		}


		public VarDeclarationGreen Update(InternalSyntaxToken vAR, AssignmentGreen assignment)
		{
			if (this.VAR != vAR ||
				this.Assignment != assignment)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.VarDeclaration(vAR, assignment);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (VarDeclarationGreen)newNode;
			}
			return this;
		}
	}

	internal class AssignmentGreen : GreenSyntaxNode
	{
		internal static readonly AssignmentGreen __Missing = new AssignmentGreen();
		private InternalSyntaxToken iD;
		private InternalSyntaxToken aSSIGN;
		private ExpressionGreen expression;

		public AssignmentGreen(SandySyntaxKind kind, InternalSyntaxToken iD, InternalSyntaxToken aSSIGN, ExpressionGreen expression)
			: base(kind, null, null)
		{
			this.SlotCount = 3;
			if (iD != null)
			{
				this.AdjustFlagsAndWidth(iD);
				this.iD = iD;
			}
			if (aSSIGN != null)
			{
				this.AdjustFlagsAndWidth(aSSIGN);
				this.aSSIGN = aSSIGN;
			}
			if (expression != null)
			{
				this.AdjustFlagsAndWidth(expression);
				this.expression = expression;
			}
		}

		public AssignmentGreen(SandySyntaxKind kind, InternalSyntaxToken iD, InternalSyntaxToken aSSIGN, ExpressionGreen expression, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 3;
			if (iD != null)
			{
				this.AdjustFlagsAndWidth(iD);
				this.iD = iD;
			}
			if (aSSIGN != null)
			{
				this.AdjustFlagsAndWidth(aSSIGN);
				this.aSSIGN = aSSIGN;
			}
			if (expression != null)
			{
				this.AdjustFlagsAndWidth(expression);
				this.expression = expression;
			}
		}

		private AssignmentGreen()
			: base((SandySyntaxKind)SandySyntaxKind.Assignment, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public InternalSyntaxToken ID { get { return this.iD; } }
		public InternalSyntaxToken ASSIGN { get { return this.aSSIGN; } }
		public ExpressionGreen Expression { get { return this.expression; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.AssignmentSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.iD;
				case 1: return this.aSSIGN;
				case 2: return this.expression;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitAssignmentGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitAssignmentGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new AssignmentGreen(this.Kind, this.iD, this.aSSIGN, this.expression, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new AssignmentGreen(this.Kind, this.iD, this.aSSIGN, this.expression, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new AssignmentGreen(this.Kind, this.iD, this.aSSIGN, this.expression, this.GetDiagnostics(), this.GetAnnotations());
		}


		public AssignmentGreen Update(InternalSyntaxToken iD, InternalSyntaxToken aSSIGN, ExpressionGreen expression)
		{
			if (this.ID != iD ||
				this.ASSIGN != aSSIGN ||
				this.Expression != expression)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.Assignment(iD, aSSIGN, expression);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (AssignmentGreen)newNode;
			}
			return this;
		}
	}

	internal abstract class ExpressionGreen : GreenSyntaxNode
	{
		internal static readonly ExpressionGreen __Missing = BinaryMulOperationGreen.__Missing;

		public ExpressionGreen(SandySyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 0;
		}
	}

	internal class BinaryMulOperationGreen : ExpressionGreen
	{
		internal static new readonly BinaryMulOperationGreen __Missing = new BinaryMulOperationGreen();
		private ExpressionGreen left;
		private InternalSyntaxToken op;
		private ExpressionGreen right;

		public BinaryMulOperationGreen(SandySyntaxKind kind, ExpressionGreen left, InternalSyntaxToken op, ExpressionGreen right)
			: base(kind, null, null)
		{
			this.SlotCount = 3;
			if (left != null)
			{
				this.AdjustFlagsAndWidth(left);
				this.left = left;
			}
			if (op != null)
			{
				this.AdjustFlagsAndWidth(op);
				this.op = op;
			}
			if (right != null)
			{
				this.AdjustFlagsAndWidth(right);
				this.right = right;
			}
		}

		public BinaryMulOperationGreen(SandySyntaxKind kind, ExpressionGreen left, InternalSyntaxToken op, ExpressionGreen right, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 3;
			if (left != null)
			{
				this.AdjustFlagsAndWidth(left);
				this.left = left;
			}
			if (op != null)
			{
				this.AdjustFlagsAndWidth(op);
				this.op = op;
			}
			if (right != null)
			{
				this.AdjustFlagsAndWidth(right);
				this.right = right;
			}
		}

		private BinaryMulOperationGreen()
			: base((SandySyntaxKind)SandySyntaxKind.BinaryMulOperation, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public ExpressionGreen Left { get { return this.left; } }
		public InternalSyntaxToken Op { get { return this.op; } }
		public ExpressionGreen Right { get { return this.right; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.BinaryMulOperationSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.left;
				case 1: return this.op;
				case 2: return this.right;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBinaryMulOperationGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitBinaryMulOperationGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new BinaryMulOperationGreen(this.Kind, this.left, this.op, this.right, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new BinaryMulOperationGreen(this.Kind, this.left, this.op, this.right, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new BinaryMulOperationGreen(this.Kind, this.left, this.op, this.right, this.GetDiagnostics(), this.GetAnnotations());
		}


		public BinaryMulOperationGreen Update(ExpressionGreen left, InternalSyntaxToken op, ExpressionGreen right)
		{
			if (this.Left != left ||
				this.Op != op ||
				this.Right != right)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.BinaryMulOperation(left, op, right);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (BinaryMulOperationGreen)newNode;
			}
			return this;
		}
	}

	internal class BinaryAddOperationGreen : ExpressionGreen
	{
		internal static new readonly BinaryAddOperationGreen __Missing = new BinaryAddOperationGreen();
		private ExpressionGreen left;
		private InternalSyntaxToken op;
		private ExpressionGreen right;

		public BinaryAddOperationGreen(SandySyntaxKind kind, ExpressionGreen left, InternalSyntaxToken op, ExpressionGreen right)
			: base(kind, null, null)
		{
			this.SlotCount = 3;
			if (left != null)
			{
				this.AdjustFlagsAndWidth(left);
				this.left = left;
			}
			if (op != null)
			{
				this.AdjustFlagsAndWidth(op);
				this.op = op;
			}
			if (right != null)
			{
				this.AdjustFlagsAndWidth(right);
				this.right = right;
			}
		}

		public BinaryAddOperationGreen(SandySyntaxKind kind, ExpressionGreen left, InternalSyntaxToken op, ExpressionGreen right, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 3;
			if (left != null)
			{
				this.AdjustFlagsAndWidth(left);
				this.left = left;
			}
			if (op != null)
			{
				this.AdjustFlagsAndWidth(op);
				this.op = op;
			}
			if (right != null)
			{
				this.AdjustFlagsAndWidth(right);
				this.right = right;
			}
		}

		private BinaryAddOperationGreen()
			: base((SandySyntaxKind)SandySyntaxKind.BinaryAddOperation, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public ExpressionGreen Left { get { return this.left; } }
		public InternalSyntaxToken Op { get { return this.op; } }
		public ExpressionGreen Right { get { return this.right; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.BinaryAddOperationSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.left;
				case 1: return this.op;
				case 2: return this.right;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBinaryAddOperationGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitBinaryAddOperationGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new BinaryAddOperationGreen(this.Kind, this.left, this.op, this.right, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new BinaryAddOperationGreen(this.Kind, this.left, this.op, this.right, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new BinaryAddOperationGreen(this.Kind, this.left, this.op, this.right, this.GetDiagnostics(), this.GetAnnotations());
		}


		public BinaryAddOperationGreen Update(ExpressionGreen left, InternalSyntaxToken op, ExpressionGreen right)
		{
			if (this.Left != left ||
				this.Op != op ||
				this.Right != right)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.BinaryAddOperation(left, op, right);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (BinaryAddOperationGreen)newNode;
			}
			return this;
		}
	}

	internal class TypeConversionGreen : ExpressionGreen
	{
		internal static new readonly TypeConversionGreen __Missing = new TypeConversionGreen();
		private ExpressionGreen value;
		private InternalSyntaxToken aS;
		private TypeGreen targetType;

		public TypeConversionGreen(SandySyntaxKind kind, ExpressionGreen value, InternalSyntaxToken aS, TypeGreen targetType)
			: base(kind, null, null)
		{
			this.SlotCount = 3;
			if (value != null)
			{
				this.AdjustFlagsAndWidth(value);
				this.value = value;
			}
			if (aS != null)
			{
				this.AdjustFlagsAndWidth(aS);
				this.aS = aS;
			}
			if (targetType != null)
			{
				this.AdjustFlagsAndWidth(targetType);
				this.targetType = targetType;
			}
		}

		public TypeConversionGreen(SandySyntaxKind kind, ExpressionGreen value, InternalSyntaxToken aS, TypeGreen targetType, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 3;
			if (value != null)
			{
				this.AdjustFlagsAndWidth(value);
				this.value = value;
			}
			if (aS != null)
			{
				this.AdjustFlagsAndWidth(aS);
				this.aS = aS;
			}
			if (targetType != null)
			{
				this.AdjustFlagsAndWidth(targetType);
				this.targetType = targetType;
			}
		}

		private TypeConversionGreen()
			: base((SandySyntaxKind)SandySyntaxKind.TypeConversion, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public ExpressionGreen Value { get { return this.value; } }
		public InternalSyntaxToken AS { get { return this.aS; } }
		public TypeGreen TargetType { get { return this.targetType; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.TypeConversionSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.value;
				case 1: return this.aS;
				case 2: return this.targetType;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeConversionGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitTypeConversionGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new TypeConversionGreen(this.Kind, this.value, this.aS, this.targetType, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new TypeConversionGreen(this.Kind, this.value, this.aS, this.targetType, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new TypeConversionGreen(this.Kind, this.value, this.aS, this.targetType, this.GetDiagnostics(), this.GetAnnotations());
		}


		public TypeConversionGreen Update(ExpressionGreen value, InternalSyntaxToken aS, TypeGreen targetType)
		{
			if (this.Value != value ||
				this.AS != aS ||
				this.TargetType != targetType)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.TypeConversion(value, aS, targetType);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TypeConversionGreen)newNode;
			}
			return this;
		}
	}

	internal class ParenExpressionGreen : ExpressionGreen
	{
		internal static new readonly ParenExpressionGreen __Missing = new ParenExpressionGreen();
		private InternalSyntaxToken lPAREN;
		private ExpressionGreen expression;
		private InternalSyntaxToken rPAREN;

		public ParenExpressionGreen(SandySyntaxKind kind, InternalSyntaxToken lPAREN, ExpressionGreen expression, InternalSyntaxToken rPAREN)
			: base(kind, null, null)
		{
			this.SlotCount = 3;
			if (lPAREN != null)
			{
				this.AdjustFlagsAndWidth(lPAREN);
				this.lPAREN = lPAREN;
			}
			if (expression != null)
			{
				this.AdjustFlagsAndWidth(expression);
				this.expression = expression;
			}
			if (rPAREN != null)
			{
				this.AdjustFlagsAndWidth(rPAREN);
				this.rPAREN = rPAREN;
			}
		}

		public ParenExpressionGreen(SandySyntaxKind kind, InternalSyntaxToken lPAREN, ExpressionGreen expression, InternalSyntaxToken rPAREN, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 3;
			if (lPAREN != null)
			{
				this.AdjustFlagsAndWidth(lPAREN);
				this.lPAREN = lPAREN;
			}
			if (expression != null)
			{
				this.AdjustFlagsAndWidth(expression);
				this.expression = expression;
			}
			if (rPAREN != null)
			{
				this.AdjustFlagsAndWidth(rPAREN);
				this.rPAREN = rPAREN;
			}
		}

		private ParenExpressionGreen()
			: base((SandySyntaxKind)SandySyntaxKind.ParenExpression, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public InternalSyntaxToken LPAREN { get { return this.lPAREN; } }
		public ExpressionGreen Expression { get { return this.expression; } }
		public InternalSyntaxToken RPAREN { get { return this.rPAREN; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.ParenExpressionSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.lPAREN;
				case 1: return this.expression;
				case 2: return this.rPAREN;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitParenExpressionGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitParenExpressionGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ParenExpressionGreen(this.Kind, this.lPAREN, this.expression, this.rPAREN, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ParenExpressionGreen(this.Kind, this.lPAREN, this.expression, this.rPAREN, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new ParenExpressionGreen(this.Kind, this.lPAREN, this.expression, this.rPAREN, this.GetDiagnostics(), this.GetAnnotations());
		}


		public ParenExpressionGreen Update(InternalSyntaxToken lPAREN, ExpressionGreen expression, InternalSyntaxToken rPAREN)
		{
			if (this.LPAREN != lPAREN ||
				this.Expression != expression ||
				this.RPAREN != rPAREN)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.ParenExpression(lPAREN, expression, rPAREN);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (ParenExpressionGreen)newNode;
			}
			return this;
		}
	}

	internal class VarReferenceGreen : ExpressionGreen
	{
		internal static new readonly VarReferenceGreen __Missing = new VarReferenceGreen();
		private InternalSyntaxToken iD;

		public VarReferenceGreen(SandySyntaxKind kind, InternalSyntaxToken iD)
			: base(kind, null, null)
		{
			this.SlotCount = 1;
			if (iD != null)
			{
				this.AdjustFlagsAndWidth(iD);
				this.iD = iD;
			}
		}

		public VarReferenceGreen(SandySyntaxKind kind, InternalSyntaxToken iD, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 1;
			if (iD != null)
			{
				this.AdjustFlagsAndWidth(iD);
				this.iD = iD;
			}
		}

		private VarReferenceGreen()
			: base((SandySyntaxKind)SandySyntaxKind.VarReference, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public InternalSyntaxToken ID { get { return this.iD; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.VarReferenceSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.iD;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitVarReferenceGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitVarReferenceGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new VarReferenceGreen(this.Kind, this.iD, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new VarReferenceGreen(this.Kind, this.iD, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new VarReferenceGreen(this.Kind, this.iD, this.GetDiagnostics(), this.GetAnnotations());
		}


		public VarReferenceGreen Update(InternalSyntaxToken iD)
		{
			if (this.ID != iD)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.VarReference(iD);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (VarReferenceGreen)newNode;
			}
			return this;
		}
	}

	internal class MinusExpressionGreen : ExpressionGreen
	{
		internal static new readonly MinusExpressionGreen __Missing = new MinusExpressionGreen();
		private InternalSyntaxToken mINUS;
		private ExpressionGreen expression;

		public MinusExpressionGreen(SandySyntaxKind kind, InternalSyntaxToken mINUS, ExpressionGreen expression)
			: base(kind, null, null)
		{
			this.SlotCount = 2;
			if (mINUS != null)
			{
				this.AdjustFlagsAndWidth(mINUS);
				this.mINUS = mINUS;
			}
			if (expression != null)
			{
				this.AdjustFlagsAndWidth(expression);
				this.expression = expression;
			}
		}

		public MinusExpressionGreen(SandySyntaxKind kind, InternalSyntaxToken mINUS, ExpressionGreen expression, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 2;
			if (mINUS != null)
			{
				this.AdjustFlagsAndWidth(mINUS);
				this.mINUS = mINUS;
			}
			if (expression != null)
			{
				this.AdjustFlagsAndWidth(expression);
				this.expression = expression;
			}
		}

		private MinusExpressionGreen()
			: base((SandySyntaxKind)SandySyntaxKind.MinusExpression, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public InternalSyntaxToken MINUS { get { return this.mINUS; } }
		public ExpressionGreen Expression { get { return this.expression; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.MinusExpressionSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.mINUS;
				case 1: return this.expression;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMinusExpressionGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitMinusExpressionGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MinusExpressionGreen(this.Kind, this.mINUS, this.expression, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MinusExpressionGreen(this.Kind, this.mINUS, this.expression, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new MinusExpressionGreen(this.Kind, this.mINUS, this.expression, this.GetDiagnostics(), this.GetAnnotations());
		}


		public MinusExpressionGreen Update(InternalSyntaxToken mINUS, ExpressionGreen expression)
		{
			if (this.MINUS != mINUS ||
				this.Expression != expression)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.MinusExpression(mINUS, expression);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (MinusExpressionGreen)newNode;
			}
			return this;
		}
	}

	internal class IntLiteralGreen : ExpressionGreen
	{
		internal static new readonly IntLiteralGreen __Missing = new IntLiteralGreen();
		private InternalSyntaxToken iNTLIT;

		public IntLiteralGreen(SandySyntaxKind kind, InternalSyntaxToken iNTLIT)
			: base(kind, null, null)
		{
			this.SlotCount = 1;
			if (iNTLIT != null)
			{
				this.AdjustFlagsAndWidth(iNTLIT);
				this.iNTLIT = iNTLIT;
			}
		}

		public IntLiteralGreen(SandySyntaxKind kind, InternalSyntaxToken iNTLIT, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 1;
			if (iNTLIT != null)
			{
				this.AdjustFlagsAndWidth(iNTLIT);
				this.iNTLIT = iNTLIT;
			}
		}

		private IntLiteralGreen()
			: base((SandySyntaxKind)SandySyntaxKind.IntLiteral, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public InternalSyntaxToken INTLIT { get { return this.iNTLIT; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.IntLiteralSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.iNTLIT;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitIntLiteralGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitIntLiteralGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new IntLiteralGreen(this.Kind, this.iNTLIT, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new IntLiteralGreen(this.Kind, this.iNTLIT, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new IntLiteralGreen(this.Kind, this.iNTLIT, this.GetDiagnostics(), this.GetAnnotations());
		}


		public IntLiteralGreen Update(InternalSyntaxToken iNTLIT)
		{
			if (this.INTLIT != iNTLIT)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.IntLiteral(iNTLIT);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (IntLiteralGreen)newNode;
			}
			return this;
		}
	}

	internal class DecimalLiteralGreen : ExpressionGreen
	{
		internal static new readonly DecimalLiteralGreen __Missing = new DecimalLiteralGreen();
		private InternalSyntaxToken dECLIT;

		public DecimalLiteralGreen(SandySyntaxKind kind, InternalSyntaxToken dECLIT)
			: base(kind, null, null)
		{
			this.SlotCount = 1;
			if (dECLIT != null)
			{
				this.AdjustFlagsAndWidth(dECLIT);
				this.dECLIT = dECLIT;
			}
		}

		public DecimalLiteralGreen(SandySyntaxKind kind, InternalSyntaxToken dECLIT, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 1;
			if (dECLIT != null)
			{
				this.AdjustFlagsAndWidth(dECLIT);
				this.dECLIT = dECLIT;
			}
		}

		private DecimalLiteralGreen()
			: base((SandySyntaxKind)SandySyntaxKind.DecimalLiteral, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public InternalSyntaxToken DECLIT { get { return this.dECLIT; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.DecimalLiteralSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.dECLIT;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitDecimalLiteralGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitDecimalLiteralGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new DecimalLiteralGreen(this.Kind, this.dECLIT, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new DecimalLiteralGreen(this.Kind, this.dECLIT, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new DecimalLiteralGreen(this.Kind, this.dECLIT, this.GetDiagnostics(), this.GetAnnotations());
		}


		public DecimalLiteralGreen Update(InternalSyntaxToken dECLIT)
		{
			if (this.DECLIT != dECLIT)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.DecimalLiteral(dECLIT);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (DecimalLiteralGreen)newNode;
			}
			return this;
		}
	}

	internal class TypeGreen : GreenSyntaxNode
	{
		internal static readonly TypeGreen __Missing = new TypeGreen();
		private InternalSyntaxToken type;

		public TypeGreen(SandySyntaxKind kind, InternalSyntaxToken type)
			: base(kind, null, null)
		{
			this.SlotCount = 1;
			if (type != null)
			{
				this.AdjustFlagsAndWidth(type);
				this.type = type;
			}
		}

		public TypeGreen(SandySyntaxKind kind, InternalSyntaxToken type, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			this.SlotCount = 1;
			if (type != null)
			{
				this.AdjustFlagsAndWidth(type);
				this.type = type;
			}
		}

		private TypeGreen()
			: base((SandySyntaxKind)SandySyntaxKind.Type, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}

		public InternalSyntaxToken Type { get { return this.type; } }

		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.TypeSyntax(this, (SandySyntaxNode)parent, position);
		}

		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return this.type;
				default: return null;
			}
		}

		public override TResult Accept<TResult>(SandyInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeGreen(this);

		public override void Accept(SandyInternalSyntaxVisitor visitor) => visitor.VisitTypeGreen(this);

		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new TypeGreen(this.Kind, this.type, diagnostics, this.GetAnnotations());
		}

		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new TypeGreen(this.Kind, this.type, this.GetDiagnostics(), annotations);
		}

		public override GreenNode Clone()
		{
			return new TypeGreen(this.Kind, this.type, this.GetDiagnostics(), this.GetAnnotations());
		}


		public TypeGreen Update(InternalSyntaxToken type)
		{
			if (this.Type != type)
			{
				InternalSyntaxNode newNode = SandyLanguage.Instance.InternalSyntaxFactory.Type(type);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TypeGreen)newNode;
			}
			return this;
		}
	}

	internal class SandyInternalSyntaxVisitor : InternalSyntaxVisitor
	{
		public virtual void VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
		public virtual void VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
		public virtual void VisitLineGreen(LineGreen node) => this.DefaultVisit(node);
		public virtual void VisitStatementGreen(StatementGreen node) => this.DefaultVisit(node);
		public virtual void VisitPrintGreen(PrintGreen node) => this.DefaultVisit(node);
		public virtual void VisitVarDeclarationGreen(VarDeclarationGreen node) => this.DefaultVisit(node);
		public virtual void VisitAssignmentGreen(AssignmentGreen node) => this.DefaultVisit(node);
		public virtual void VisitBinaryMulOperationGreen(BinaryMulOperationGreen node) => this.DefaultVisit(node);
		public virtual void VisitBinaryAddOperationGreen(BinaryAddOperationGreen node) => this.DefaultVisit(node);
		public virtual void VisitTypeConversionGreen(TypeConversionGreen node) => this.DefaultVisit(node);
		public virtual void VisitParenExpressionGreen(ParenExpressionGreen node) => this.DefaultVisit(node);
		public virtual void VisitVarReferenceGreen(VarReferenceGreen node) => this.DefaultVisit(node);
		public virtual void VisitMinusExpressionGreen(MinusExpressionGreen node) => this.DefaultVisit(node);
		public virtual void VisitIntLiteralGreen(IntLiteralGreen node) => this.DefaultVisit(node);
		public virtual void VisitDecimalLiteralGreen(DecimalLiteralGreen node) => this.DefaultVisit(node);
		public virtual void VisitTypeGreen(TypeGreen node) => this.DefaultVisit(node);
	}

	internal class SandyInternalSyntaxVisitor<TResult> : InternalSyntaxVisitor<TResult>
	{
		public virtual TResult VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
		public virtual TResult VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitLineGreen(LineGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitStatementGreen(StatementGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPrintGreen(PrintGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitVarDeclarationGreen(VarDeclarationGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitAssignmentGreen(AssignmentGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitBinaryMulOperationGreen(BinaryMulOperationGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitBinaryAddOperationGreen(BinaryAddOperationGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitTypeConversionGreen(TypeConversionGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitParenExpressionGreen(ParenExpressionGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitVarReferenceGreen(VarReferenceGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMinusExpressionGreen(MinusExpressionGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitIntLiteralGreen(IntLiteralGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitDecimalLiteralGreen(DecimalLiteralGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitTypeGreen(TypeGreen node) => this.DefaultVisit(node);
	}

	public class SandyInternalSyntaxFactory : InternalSyntaxFactory, IAntlr4SyntaxFactory
	{
		public SandyInternalSyntaxFactory(SandySyntaxFacts syntaxFacts) 
		    : base(syntaxFacts)
		{
		}
	
	    Antlr4Lexer IAntlr4SyntaxFactory.CreateAntlr4Lexer(ICharStream input)
	    {
	        return new SandyLexer(input);
	    }
	
	    Antlr4Parser IAntlr4SyntaxFactory.CreateAntlr4Parser(ITokenStream input)
	    {
	        return new SandyParser(input);
	    }
	
		public override SandySyntaxLexer CreateLexer(SourceText text, ParseOptions? options)
		{
			return new SandySyntaxLexer(text, (SandyParseOptions)(options ?? SandyParseOptions.Default));
		}

		public override SandySyntaxParser CreateParser(AbstractLexer lexer, SyntaxNode? oldTree, ParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken = default)
        {
			return new SandySyntaxParser((SandySyntaxLexer)lexer, (SandySyntaxNode?)oldTree, oldParseData, changes, cancellationToken);
		}

		public InternalSyntaxTrivia Trivia(SandySyntaxKind kind, string text, bool elastic = false)
        {
			var trivia = GreenSyntaxTrivia.Create(kind, text);
			if (!elastic)
			{
				return trivia;
			}
			return trivia.WithAnnotationsGreen(new[] { SyntaxAnnotation.ElasticAnnotation });
		}

		protected override InternalSyntaxTrivia Trivia(int kind, string text, bool elastic = false)
	    {
	        return Trivia((SandySyntaxKind)kind, text, elastic);
	    }
	
		public override InternalSyntaxNode SkippedTokensTrivia(GreenNode token)
		{
			return new GreenSkippedTokensTriviaSyntax((SandySyntaxKind)InternalSyntaxKind.SkippedTokensTrivia, token);
		}
	
	    public InternalSyntaxToken Token(SandySyntaxKind kind)
	    {
	        return GreenSyntaxToken.Create(kind);
	    }

        protected override InternalSyntaxToken Token(int kind)
        {
			return Token((SandySyntaxKind)kind);
        }

        public InternalSyntaxToken Token(GreenNode? leading, SandySyntaxKind kind, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.Create(kind, leading, trailing);
	    }

        protected override InternalSyntaxToken Token(GreenNode? leading, int kind, GreenNode? trailing)
        {
			return Token(leading, (SandySyntaxKind)kind, trailing);
        }

        public InternalSyntaxToken Token(GreenNode? leading, SandySyntaxKind kind, string text, GreenNode? trailing)
	    {
	        Debug.Assert(SandyLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = SandyLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.Identifier(kind, leading, text, trailing);
	    }

        protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, GreenNode? trailing)
        {
            return Token(leading, (SandySyntaxKind)kind, text, trailing);
        }

        public InternalSyntaxToken Token(GreenNode? leading, SandySyntaxKind kind, string text, string valueText, GreenNode? trailing)
	    {
	        Debug.Assert(SandyLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = SandyLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && valueText == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, valueText, trailing);
	    }

		protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, string valueText, GreenNode? trailing)
		{
			return Token(leading, (SandySyntaxKind)kind, text, valueText, trailing);
		}

		public InternalSyntaxToken Token(GreenNode? leading, SandySyntaxKind kind, string text, object value, GreenNode? trailing)
	    {
	        Debug.Assert(SandyLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = SandyLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && defaultText.Equals(value)
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, value, trailing);
	    }

		protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, object value, GreenNode? trailing)
		{
			return Token(leading, (SandySyntaxKind)kind, text, value, trailing);
		}

		public InternalSyntaxToken MissingToken(SandySyntaxKind kind)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, null, null);
	    }

        protected override InternalSyntaxToken MissingToken(int kind)
        {
			return MissingToken((SandySyntaxKind)kind);
        }

        public InternalSyntaxToken MissingToken(GreenNode? leading, SandySyntaxKind kind, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, leading, trailing);
	    }

        protected override InternalSyntaxToken MissingToken(GreenNode? leading, int kind, GreenNode? trailing)
        {
			return MissingToken(leading, (SandySyntaxKind)kind, trailing);
        }

        public override InternalSyntaxToken BadToken(GreenNode? leading, string text, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.WithValue((SandySyntaxKind)InternalSyntaxKind.BadToken, leading, text, text, trailing);
	    }

        public override IEnumerable<InternalSyntaxToken> GetWellKnownTokens()
	    {
	        return GreenSyntaxToken.GetWellKnownTokens();
	    }
	
	
	    internal InternalSyntaxToken NEWLINE(string text)
	    {
	        return Token(null, SandySyntaxKind.NEWLINE, text, null);
	    }
	
	    internal InternalSyntaxToken NEWLINE(string text, object value)
	    {
	        return Token(null, SandySyntaxKind.NEWLINE, text, value, null);
	    }
	
	    internal InternalSyntaxToken WS(string text)
	    {
	        return Token(null, SandySyntaxKind.WS, text, null);
	    }
	
	    internal InternalSyntaxToken WS(string text, object value)
	    {
	        return Token(null, SandySyntaxKind.WS, text, value, null);
	    }
	
	    internal InternalSyntaxToken INTLIT(string text)
	    {
	        return Token(null, SandySyntaxKind.INTLIT, text, null);
	    }
	
	    internal InternalSyntaxToken INTLIT(string text, object value)
	    {
	        return Token(null, SandySyntaxKind.INTLIT, text, value, null);
	    }
	
	    internal InternalSyntaxToken DECLIT(string text)
	    {
	        return Token(null, SandySyntaxKind.DECLIT, text, null);
	    }
	
	    internal InternalSyntaxToken DECLIT(string text, object value)
	    {
	        return Token(null, SandySyntaxKind.DECLIT, text, value, null);
	    }
	
	    internal InternalSyntaxToken ID(string text)
	    {
	        return Token(null, SandySyntaxKind.ID, text, null);
	    }
	
	    internal InternalSyntaxToken ID(string text, object value)
	    {
	        return Token(null, SandySyntaxKind.ID, text, value, null);
	    }

		internal MainGreen Main(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LineGreen> line, InternalSyntaxToken eOF)
		{
#if DEBUG
			if (eOF == null) throw new ArgumentNullException(nameof(eOF));
			if (eOF.RawKind != (int)SandySyntaxKind.Eof) throw new ArgumentException(nameof(eOF));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.Main, line.Node, eOF, out hash);
			if (cached != null) return (MainGreen)cached;
			var result = new MainGreen(SandySyntaxKind.Main, line.Node, eOF);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal LineGreen Line(StatementGreen statement)
		{
#if DEBUG
			if (statement == null) throw new ArgumentNullException(nameof(statement));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.Line, statement, out hash);
			if (cached != null) return (LineGreen)cached;
			var result = new LineGreen(SandySyntaxKind.Line, statement);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal StatementGreen Statement(VarDeclarationGreen varDeclaration)
		{
#if DEBUG
			if (varDeclaration == null) throw new ArgumentNullException(nameof(varDeclaration));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.Statement, varDeclaration, out hash);
			if (cached != null) return (StatementGreen)cached;
			var result = new StatementGreen(SandySyntaxKind.Statement, varDeclaration, null, null);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal StatementGreen Statement(AssignmentGreen assignment)
		{
#if DEBUG
			if (assignment == null) throw new ArgumentNullException(nameof(assignment));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.Statement, assignment, out hash);
			if (cached != null) return (StatementGreen)cached;
			var result = new StatementGreen(SandySyntaxKind.Statement, null, assignment, null);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal StatementGreen Statement(PrintGreen print)
		{
#if DEBUG
			if (print == null) throw new ArgumentNullException(nameof(print));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.Statement, print, out hash);
			if (cached != null) return (StatementGreen)cached;
			var result = new StatementGreen(SandySyntaxKind.Statement, null, null, print);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal PrintGreen Print(InternalSyntaxToken pRINT, InternalSyntaxToken lPAREN, ExpressionGreen expression, InternalSyntaxToken rPAREN)
		{
#if DEBUG
			if (pRINT == null) throw new ArgumentNullException(nameof(pRINT));
			if (pRINT.RawKind != (int)SandySyntaxKind.PRINT) throw new ArgumentException(nameof(pRINT));
			if (lPAREN == null) throw new ArgumentNullException(nameof(lPAREN));
			if (lPAREN.RawKind != (int)SandySyntaxKind.LPAREN) throw new ArgumentException(nameof(lPAREN));
			if (expression == null) throw new ArgumentNullException(nameof(expression));
			if (rPAREN == null) throw new ArgumentNullException(nameof(rPAREN));
			if (rPAREN.RawKind != (int)SandySyntaxKind.RPAREN) throw new ArgumentException(nameof(rPAREN));
#endif
			return new PrintGreen(SandySyntaxKind.Print, pRINT, lPAREN, expression, rPAREN);
		}

		internal VarDeclarationGreen VarDeclaration(InternalSyntaxToken vAR, AssignmentGreen assignment)
		{
#if DEBUG
			if (vAR == null) throw new ArgumentNullException(nameof(vAR));
			if (vAR.RawKind != (int)SandySyntaxKind.VAR) throw new ArgumentException(nameof(vAR));
			if (assignment == null) throw new ArgumentNullException(nameof(assignment));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.VarDeclaration, vAR, assignment, out hash);
			if (cached != null) return (VarDeclarationGreen)cached;
			var result = new VarDeclarationGreen(SandySyntaxKind.VarDeclaration, vAR, assignment);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal AssignmentGreen Assignment(InternalSyntaxToken iD, InternalSyntaxToken aSSIGN, ExpressionGreen expression)
		{
#if DEBUG
			if (iD == null) throw new ArgumentNullException(nameof(iD));
			if (iD.RawKind != (int)SandySyntaxKind.ID) throw new ArgumentException(nameof(iD));
			if (aSSIGN == null) throw new ArgumentNullException(nameof(aSSIGN));
			if (aSSIGN.RawKind != (int)SandySyntaxKind.ASSIGN) throw new ArgumentException(nameof(aSSIGN));
			if (expression == null) throw new ArgumentNullException(nameof(expression));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.Assignment, iD, aSSIGN, expression, out hash);
			if (cached != null) return (AssignmentGreen)cached;
			var result = new AssignmentGreen(SandySyntaxKind.Assignment, iD, aSSIGN, expression);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal BinaryMulOperationGreen BinaryMulOperation(ExpressionGreen left, InternalSyntaxToken op, ExpressionGreen right)
		{
#if DEBUG
			if (left == null) throw new ArgumentNullException(nameof(left));
			if (op == null) throw new ArgumentNullException(nameof(op));
			if (right == null) throw new ArgumentNullException(nameof(right));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.BinaryMulOperation, left, op, right, out hash);
			if (cached != null) return (BinaryMulOperationGreen)cached;
			var result = new BinaryMulOperationGreen(SandySyntaxKind.BinaryMulOperation, left, op, right);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal BinaryAddOperationGreen BinaryAddOperation(ExpressionGreen left, InternalSyntaxToken op, ExpressionGreen right)
		{
#if DEBUG
			if (left == null) throw new ArgumentNullException(nameof(left));
			if (op == null) throw new ArgumentNullException(nameof(op));
			if (right == null) throw new ArgumentNullException(nameof(right));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.BinaryAddOperation, left, op, right, out hash);
			if (cached != null) return (BinaryAddOperationGreen)cached;
			var result = new BinaryAddOperationGreen(SandySyntaxKind.BinaryAddOperation, left, op, right);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal TypeConversionGreen TypeConversion(ExpressionGreen value, InternalSyntaxToken aS, TypeGreen targetType)
		{
#if DEBUG
			if (value == null) throw new ArgumentNullException(nameof(value));
			if (aS == null) throw new ArgumentNullException(nameof(aS));
			if (aS.RawKind != (int)SandySyntaxKind.AS) throw new ArgumentException(nameof(aS));
			if (targetType == null) throw new ArgumentNullException(nameof(targetType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.TypeConversion, value, aS, targetType, out hash);
			if (cached != null) return (TypeConversionGreen)cached;
			var result = new TypeConversionGreen(SandySyntaxKind.TypeConversion, value, aS, targetType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal ParenExpressionGreen ParenExpression(InternalSyntaxToken lPAREN, ExpressionGreen expression, InternalSyntaxToken rPAREN)
		{
#if DEBUG
			if (lPAREN == null) throw new ArgumentNullException(nameof(lPAREN));
			if (lPAREN.RawKind != (int)SandySyntaxKind.LPAREN) throw new ArgumentException(nameof(lPAREN));
			if (expression == null) throw new ArgumentNullException(nameof(expression));
			if (rPAREN == null) throw new ArgumentNullException(nameof(rPAREN));
			if (rPAREN.RawKind != (int)SandySyntaxKind.RPAREN) throw new ArgumentException(nameof(rPAREN));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.ParenExpression, lPAREN, expression, rPAREN, out hash);
			if (cached != null) return (ParenExpressionGreen)cached;
			var result = new ParenExpressionGreen(SandySyntaxKind.ParenExpression, lPAREN, expression, rPAREN);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal VarReferenceGreen VarReference(InternalSyntaxToken iD)
		{
#if DEBUG
			if (iD == null) throw new ArgumentNullException(nameof(iD));
			if (iD.RawKind != (int)SandySyntaxKind.ID) throw new ArgumentException(nameof(iD));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.VarReference, iD, out hash);
			if (cached != null) return (VarReferenceGreen)cached;
			var result = new VarReferenceGreen(SandySyntaxKind.VarReference, iD);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal MinusExpressionGreen MinusExpression(InternalSyntaxToken mINUS, ExpressionGreen expression)
		{
#if DEBUG
			if (mINUS == null) throw new ArgumentNullException(nameof(mINUS));
			if (mINUS.RawKind != (int)SandySyntaxKind.MINUS) throw new ArgumentException(nameof(mINUS));
			if (expression == null) throw new ArgumentNullException(nameof(expression));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.MinusExpression, mINUS, expression, out hash);
			if (cached != null) return (MinusExpressionGreen)cached;
			var result = new MinusExpressionGreen(SandySyntaxKind.MinusExpression, mINUS, expression);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal IntLiteralGreen IntLiteral(InternalSyntaxToken iNTLIT)
		{
#if DEBUG
			if (iNTLIT == null) throw new ArgumentNullException(nameof(iNTLIT));
			if (iNTLIT.RawKind != (int)SandySyntaxKind.INTLIT) throw new ArgumentException(nameof(iNTLIT));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.IntLiteral, iNTLIT, out hash);
			if (cached != null) return (IntLiteralGreen)cached;
			var result = new IntLiteralGreen(SandySyntaxKind.IntLiteral, iNTLIT);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal DecimalLiteralGreen DecimalLiteral(InternalSyntaxToken dECLIT)
		{
#if DEBUG
			if (dECLIT == null) throw new ArgumentNullException(nameof(dECLIT));
			if (dECLIT.RawKind != (int)SandySyntaxKind.DECLIT) throw new ArgumentException(nameof(dECLIT));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.DecimalLiteral, dECLIT, out hash);
			if (cached != null) return (DecimalLiteralGreen)cached;
			var result = new DecimalLiteralGreen(SandySyntaxKind.DecimalLiteral, dECLIT);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal TypeGreen Type(InternalSyntaxToken type)
		{
#if DEBUG
			if (type == null) throw new ArgumentNullException(nameof(type));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(SandySyntaxKind)SandySyntaxKind.Type, type, out hash);
			if (cached != null) return (TypeGreen)cached;
			var result = new TypeGreen(SandySyntaxKind.Type, type);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
			return result;
		}

		internal static IEnumerable<Type> GetNodeTypes()
		{
			return new Type[] {
				typeof(MainGreen),
				typeof(LineGreen),
				typeof(StatementGreen),
				typeof(PrintGreen),
				typeof(VarDeclarationGreen),
				typeof(AssignmentGreen),
				typeof(BinaryMulOperationGreen),
				typeof(BinaryAddOperationGreen),
				typeof(TypeConversionGreen),
				typeof(ParenExpressionGreen),
				typeof(VarReferenceGreen),
				typeof(MinusExpressionGreen),
				typeof(IntLiteralGreen),
				typeof(DecimalLiteralGreen),
				typeof(TypeGreen),
			};
		}

	}
}

