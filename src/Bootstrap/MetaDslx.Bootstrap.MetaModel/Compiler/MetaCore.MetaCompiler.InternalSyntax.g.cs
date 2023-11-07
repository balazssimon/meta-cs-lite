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

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax
{
    using System.Runtime.CompilerServices;
    using MetaDslx.CodeAnalysis;
    using MetaDslx.CodeAnalysis.Syntax;
    using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
    using MetaDslx.CodeAnalysis.Text;
    using Roslyn.Utilities;

    internal abstract class GreenSyntaxNode : InternalSyntaxNode
    {
        protected GreenSyntaxNode(MetaCoreSyntaxKind kind)
            : base((ushort)kind)
        {
        }

        protected GreenSyntaxNode(MetaCoreSyntaxKind kind, int fullWidth)
            : base((ushort)kind, fullWidth)
        {
        }

        protected GreenSyntaxNode(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics)
            : base((ushort)kind, diagnostics)
        {
        }

        protected GreenSyntaxNode(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics, int fullWidth)
            : base((ushort)kind, diagnostics, fullWidth)
        {
        }

        protected GreenSyntaxNode(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
            : base((ushort)kind, diagnostics, annotations)
        {
        }

        protected GreenSyntaxNode(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations, int fullWidth)
            : base((ushort)kind, diagnostics, annotations, fullWidth)
        {
        }

        public override TResult Accept<TResult>(InternalSyntaxVisitor<TResult> visitor)
        {
            if (visitor is MetaCoreInternalSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public override void Accept(InternalSyntaxVisitor visitor) 
        {
            if (visitor is MetaCoreInternalSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor);
        public abstract void Accept(MetaCoreInternalSyntaxVisitor visitor);

        public override Language Language => MetaCoreLanguage.Instance;
        public MetaCoreSyntaxKind Kind => (MetaCoreSyntaxKind)this.RawKind;
		public override string KindText => MetaCoreLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		// Use conditional weak table so we always return same identity for structured trivia
		private static readonly ConditionalWeakTable<SyntaxNode, Dictionary<SyntaxTrivia, SyntaxNode>> s_structuresTable
			= new ConditionalWeakTable<SyntaxNode, Dictionary<SyntaxTrivia, SyntaxNode>>();

		/// <summary>
		/// Gets the syntax node represented the structure of this trivia, if any. The HasStructure property can be used to 
		/// determine if this trivia has structure.
		/// </summary>
		/// <returns>
		/// A MetaCoreSyntaxNode derived from StructuredTriviaSyntax, with the structured view of this trivia node. 
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
							structure = MetaCoreStructuredTriviaSyntax.Create(trivia);
							structsInParent.Add(trivia, structure);
						}
					}

					return structure;
				}
				else
				{
					return MetaCoreStructuredTriviaSyntax.Create(trivia);
				}
			}

			return null;
		}

	}

    internal class GreenSyntaxTrivia : InternalSyntaxTrivia
    {
        internal GreenSyntaxTrivia(MetaCoreSyntaxKind kind, string text, DiagnosticInfo[] diagnostics = null, SyntaxAnnotation[] annotations = null)
            : base((ushort)kind, text, diagnostics, annotations)
        {
        }

		public override Language Language => MetaCoreLanguage.Instance;
		public MetaCoreSyntaxKind Kind => (MetaCoreSyntaxKind)this.RawKind;
		public override string KindText => MetaCoreLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		internal static GreenSyntaxTrivia Create(MetaCoreSyntaxKind kind, string text)
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
        internal GreenStructuredTriviaSyntax(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics = null, SyntaxAnnotation[] annotations = null)
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

        internal GreenSkippedTokensTriviaSyntax(MetaCoreSyntaxKind kind, GreenNode tokens, DiagnosticInfo[] diagnostics = null, SyntaxAnnotation[] annotations = null)
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

        protected override SyntaxNode CreateRed(SyntaxNode parent, int position) => new MetaCoreSkippedTokensTriviaSyntax(this, (MetaCoreSyntaxNode)parent, position);

        public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitSkippedTokensTrivia(this);

        public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitSkippedTokensTrivia(this);

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
	    internal GreenSyntaxToken(MetaCoreSyntaxKind kind)
	        : base((ushort)kind)
	    {
	    }
	    internal GreenSyntaxToken(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics)
	        : base((ushort)kind, diagnostics)
	    {
	    }
	    internal GreenSyntaxToken(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base((ushort)kind, diagnostics, annotations)
	    {
	    }
	    internal GreenSyntaxToken(MetaCoreSyntaxKind kind, int fullWidth)
	        : base((ushort)kind, fullWidth)
	    {
	    }
	    internal GreenSyntaxToken(MetaCoreSyntaxKind kind, int fullWidth, DiagnosticInfo[] diagnostics)
	        : base((ushort)kind, fullWidth, diagnostics)
	    {
	    }
	    internal GreenSyntaxToken(MetaCoreSyntaxKind kind, int fullWidth, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base((ushort)kind, fullWidth, diagnostics, annotations)
	    {
	    }

	    public override Language Language => MetaCoreLanguage.Instance;
	    public MetaCoreSyntaxKind Kind => (MetaCoreSyntaxKind)this.RawKind;
		public override string KindText => MetaCoreLanguage.Instance.SyntaxFacts.GetKindText(Kind);

		//====================
		internal static GreenSyntaxToken Create(MetaCoreSyntaxKind kind)
	    {
	        if (kind > LastTokenWithWellKnownText)
	        {
	            if (!MetaCoreLanguage.Instance.SyntaxFacts.IsToken(kind))
	            {
	                throw new ArgumentException(string.Format("Invalid MetaCoreSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
	            }
	            return CreateMissing(kind, null, null);
	        }
	        return s_tokensWithNoTrivia[(int)kind].Value;
	    }
	    internal static GreenSyntaxToken Create(MetaCoreSyntaxKind kind, GreenNode? leading, GreenNode? trailing)
	    {
	        if (kind > LastTokenWithWellKnownText)
	        {
	            if (!MetaCoreLanguage.Instance.SyntaxFacts.IsToken(kind))
	            {
	                throw new ArgumentException(string.Format("Invalid MetaCoreSyntaxKind: {0}. This method can only be used to create tokens.", kind), nameof(kind));
	            }
	            return CreateMissing(kind, leading, trailing);
	        }
	        if (leading == null)
	        {
	            if (trailing == null)
	            {
	                return s_tokensWithNoTrivia[(int)kind].Value;
	            }
	            else if (trailing == MetaCoreLanguage.Instance.InternalSyntaxFactory.Space)
	            {
	                return s_tokensWithSingleTrailingSpace[(int)kind].Value;
	            }
	            else if (trailing == MetaCoreLanguage.Instance.InternalSyntaxFactory.CarriageReturnLineFeed)
	            {
	                return s_tokensWithSingleTrailingCRLF[(int)kind].Value;
	            }
	        }
	        if (leading == MetaCoreLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace && trailing == MetaCoreLanguage.Instance.InternalSyntaxFactory.ElasticZeroSpace)
	        {
	            return s_tokensWithElasticTrivia[(int)kind].Value;
	        }
	        return new SyntaxTokenWithTrivia(kind, leading, trailing);
	    }
	    internal static GreenSyntaxToken CreateMissing(MetaCoreSyntaxKind kind, GreenNode? leading, GreenNode? trailing)
	    {
	        return new MissingTokenWithTrivia(kind, leading, trailing);
	    }
	    internal static readonly MetaCoreSyntaxKind FirstTokenWithWellKnownText;
	    internal static readonly MetaCoreSyntaxKind LastTokenWithWellKnownText;
	    // TODO: eliminate the blank space before the first interesting element?
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithNoTrivia;
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithElasticTrivia;
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingSpace;
	    private static readonly ArrayElement<GreenSyntaxToken>[] s_tokensWithSingleTrailingCRLF;
	    static GreenSyntaxToken()
	    {
	        FirstTokenWithWellKnownText = MetaCoreSyntaxKind.__FirstFixedToken;
	        LastTokenWithWellKnownText = MetaCoreSyntaxKind.__LastFixedToken;
	        s_tokensWithNoTrivia = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithElasticTrivia = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithSingleTrailingSpace = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
	        s_tokensWithSingleTrailingCRLF = new ArrayElement<GreenSyntaxToken>[(int)LastTokenWithWellKnownText + 1];
			InternalSyntaxFactory factory = MetaCoreLanguage.Instance.InternalSyntaxFactory;
	        for (MetaCoreSyntaxKind kind = FirstTokenWithWellKnownText; kind <= LastTokenWithWellKnownText; kind++)
	        {
	            s_tokensWithNoTrivia[(int)kind].Value = new GreenSyntaxToken((MetaCoreSyntaxKind)kind);
	            s_tokensWithElasticTrivia[(int)kind].Value = new SyntaxTokenWithTrivia((MetaCoreSyntaxKind)kind, factory.ElasticZeroSpace, factory.ElasticZeroSpace);
	            s_tokensWithSingleTrailingSpace[(int)kind].Value = new SyntaxTokenWithTrivia((MetaCoreSyntaxKind)kind, null, factory.Space);
	            s_tokensWithSingleTrailingCRLF[(int)kind].Value = new SyntaxTokenWithTrivia((MetaCoreSyntaxKind)kind, null, factory.CarriageReturnLineFeed);
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
	    internal static GreenSyntaxToken Identifier(MetaCoreSyntaxKind kind, string text)
	    {
	        return new SyntaxIdentifier(kind, text);
	    }
	    internal static GreenSyntaxToken Identifier(MetaCoreSyntaxKind kind, GreenNode leading, string text, GreenNode trailing)
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
	    internal static GreenSyntaxToken Identifier(MetaCoreSyntaxKind kind, MetaCoreSyntaxKind contextualKind, GreenNode leading, string text, string valueText, GreenNode trailing)
	    {
	        if (contextualKind == kind && valueText == text)
	        {
	            return Identifier(kind, leading, text, trailing);
	        }
	        return new SyntaxIdentifierWithTrivia(kind, contextualKind, text, valueText, leading, trailing);
	    }
	    internal static GreenSyntaxToken WithValue<T>(MetaCoreSyntaxKind kind, string text, T value)
	    {
	        return new SyntaxTokenWithValue<T>(kind, text, value);
	    }
	    internal static GreenSyntaxToken WithValue<T>(MetaCoreSyntaxKind kind, GreenNode? leading, string text, T value, GreenNode? trailing)
	    {
	        return new SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing);
	    }
	    public new virtual MetaCoreSyntaxKind ContextualKind => this.Kind;
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
	        internal MissingTokenWithTrivia(MetaCoreSyntaxKind kind, GreenNode? leading, GreenNode? trailing)
	            : base(kind, leading, trailing)
	        {
	            this.flags &= ~NodeFlags.IsNotMissing;
	        }
	        internal MissingTokenWithTrivia(MetaCoreSyntaxKind kind, GreenNode? leading, GreenNode? trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	                if (MetaCoreLanguage.Instance.SyntaxFacts.IsIdentifier(this.Kind)) return string.Empty;
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
	        internal SyntaxIdentifier(MetaCoreSyntaxKind kind, string text)
	            : base(kind, text.Length)
	        {
	            this.TextField = text;
	        }
	        internal SyntaxIdentifier(MetaCoreSyntaxKind kind, string text, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	        protected readonly MetaCoreSyntaxKind contextualKind;
	        protected readonly string valueText;
	        internal SyntaxIdentifierExtended(MetaCoreSyntaxKind kind, MetaCoreSyntaxKind contextualKind, string text, string valueText)
	            : base(kind, text)
	        {
	            this.contextualKind = contextualKind;
	            this.valueText = valueText;
	        }
	        internal SyntaxIdentifierExtended(MetaCoreSyntaxKind kind, MetaCoreSyntaxKind contextualKind, string text, string valueText, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	            : base(kind, text, diagnostics, annotations)
	        {
	            this.contextualKind = contextualKind;
	            this.valueText = valueText;
	        }
	        public override MetaCoreSyntaxKind ContextualKind
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
	        internal SyntaxIdentifierWithTrailingTrivia(MetaCoreSyntaxKind kind, string text, GreenNode? trailing)
	            : base(kind, text)
	        {
	            if (trailing != null)
	            {
	                this.AdjustFlagsAndWidth(trailing);
	                _trailing = trailing;
	            }
	        }
	        internal SyntaxIdentifierWithTrailingTrivia(MetaCoreSyntaxKind kind, string text, GreenNode? trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	            MetaCoreSyntaxKind kind,
	            MetaCoreSyntaxKind contextualKind,
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
	            MetaCoreSyntaxKind kind,
	            MetaCoreSyntaxKind contextualKind,
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
	        internal SyntaxTokenWithValue(MetaCoreSyntaxKind kind, string text, T value)
	            : base(kind, text.Length)
	        {
	            this.TextField = text;
	            this.ValueField = value;
	        }
	        internal SyntaxTokenWithValue(MetaCoreSyntaxKind kind, string text, T value, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	        internal SyntaxTokenWithValueAndTrivia(MetaCoreSyntaxKind kind, string text, T value, GreenNode? leading, GreenNode? trailing)
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
	            MetaCoreSyntaxKind kind,
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
	        internal SyntaxTokenWithTrivia(MetaCoreSyntaxKind kind, GreenNode? leading, GreenNode? trailing)
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
	        internal SyntaxTokenWithTrivia(MetaCoreSyntaxKind kind, GreenNode? leading, GreenNode? trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		public MainGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kNamespace, QualifierGreen name, InternalSyntaxToken tSemicolon, GreenNode @using, DeclarationsGreen declarations, InternalSyntaxToken eof)
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
	
		public MainGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kNamespace, QualifierGreen name, InternalSyntaxToken tSemicolon, GreenNode @using, DeclarationsGreen declarations, InternalSyntaxToken eof, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.Main, null, null)
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
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MainSyntax(this, (MetaCoreSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMainGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitMainGreen(this);
	
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
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.Main((InternalSyntaxToken)kNamespace, name, (InternalSyntaxToken)tSemicolon, @using, declarations, (InternalSyntaxToken)eof);
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
	
		public UsingGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kUsing, QualifierGreen namespaces, InternalSyntaxToken tSemicolon)
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
	
		public UsingGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kUsing, QualifierGreen namespaces, InternalSyntaxToken tSemicolon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.Using, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KUsing { get { return _kUsing; } }
		public QualifierGreen Namespaces { get { return _namespaces; } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.UsingSyntax(this, (MetaCoreSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitUsingGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitUsingGreen(this);
	
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
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.Using((InternalSyntaxToken)kUsing, namespaces, (InternalSyntaxToken)tSemicolon);
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
		private GreenNode _declarations;
	
		public DeclarationsGreen(MetaCoreSyntaxKind kind, GreenNode declarations)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (declarations != null)
			{
				AdjustFlagsAndWidth(declarations);
				_declarations = declarations;
			}
		}
	
		public DeclarationsGreen(MetaCoreSyntaxKind kind, GreenNode declarations, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.Declarations, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen> Declarations { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen>(_declarations); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.DeclarationsSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _declarations;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitDeclarationsGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitDeclarationsGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new DeclarationsGreen(this.Kind, _declarations, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new DeclarationsGreen(this.Kind, _declarations, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new DeclarationsGreen(this.Kind, _declarations, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public DeclarationsGreen Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen> declarations)
		{
			if (_declarations != declarations.Node)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.Declarations(declarations);
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
	
	    protected MetaDeclarationGreen(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class MetaModelGreen : MetaDeclarationGreen
	{
		internal static new readonly MetaModelGreen __Missing = new MetaModelGreen();
		private InternalSyntaxToken _kMetamodel;
		private NameGreen _name;
		private InternalSyntaxToken _tSemicolon;
	
		public MetaModelGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kMetamodel, NameGreen name, InternalSyntaxToken tSemicolon)
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
	
		public MetaModelGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kMetamodel, NameGreen name, InternalSyntaxToken tSemicolon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaModel, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KMetamodel { get { return _kMetamodel; } }
		public NameGreen Name { get { return _name; } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaModelSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kMetamodel;
				case 1: return _name;
				case 2: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaModelGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitMetaModelGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MetaModelGreen(this.Kind, _kMetamodel, _name, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MetaModelGreen(this.Kind, _kMetamodel, _name, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new MetaModelGreen(this.Kind, _kMetamodel, _name, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaModelGreen Update(InternalSyntaxToken kMetamodel, NameGreen name, InternalSyntaxToken tSemicolon)
		{
			if (_kMetamodel != kMetamodel || _name != name || _tSemicolon != tSemicolon)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaModel((InternalSyntaxToken)kMetamodel, name, (InternalSyntaxToken)tSemicolon);
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
	
	internal class MetaEnumTypeGreen : MetaDeclarationGreen
	{
		internal static new readonly MetaEnumTypeGreen __Missing = new MetaEnumTypeGreen();
		private InternalSyntaxToken _kEnum;
		private NameGreen _name;
		private EnumBodyGreen _enumBody;
	
		public MetaEnumTypeGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kEnum, NameGreen name, EnumBodyGreen enumBody)
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
	
		public MetaEnumTypeGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kEnum, NameGreen name, EnumBodyGreen enumBody, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private MetaEnumTypeGreen()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaEnumType, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KEnum { get { return _kEnum; } }
		public NameGreen Name { get { return _name; } }
		public EnumBodyGreen EnumBody { get { return _enumBody; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaEnumTypeSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kEnum;
				case 1: return _name;
				case 2: return _enumBody;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaEnumTypeGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitMetaEnumTypeGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MetaEnumTypeGreen(this.Kind, _kEnum, _name, _enumBody, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MetaEnumTypeGreen(this.Kind, _kEnum, _name, _enumBody, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new MetaEnumTypeGreen(this.Kind, _kEnum, _name, _enumBody, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaEnumTypeGreen Update(InternalSyntaxToken kEnum, NameGreen name, EnumBodyGreen enumBody)
		{
			if (_kEnum != kEnum || _name != name || _enumBody != enumBody)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaEnumType((InternalSyntaxToken)kEnum, name, enumBody);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (MetaEnumTypeGreen)newNode;
			}
			return this;
		}
	}
	
	internal class MetaClassGreen : MetaDeclarationGreen
	{
		internal static new readonly MetaClassGreen __Missing = new MetaClassGreen();
		private InternalSyntaxToken _isAbstract;
		private InternalSyntaxToken _kClass;
		private ClassNameGreen _name;
		private BaseClassesGreen _baseClasses;
		private ClassBodyGreen _classBody;
	
		public MetaClassGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken isAbstract, InternalSyntaxToken kClass, ClassNameGreen name, BaseClassesGreen baseClasses, ClassBodyGreen classBody)
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
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
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
	
		public MetaClassGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken isAbstract, InternalSyntaxToken kClass, ClassNameGreen name, BaseClassesGreen baseClasses, ClassBodyGreen classBody, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaClass, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken IsAbstract { get { return _isAbstract; } }
		public InternalSyntaxToken KClass { get { return _kClass; } }
		public ClassNameGreen Name { get { return _name; } }
		public BaseClassesGreen BaseClasses { get { return _baseClasses; } }
		public ClassBodyGreen ClassBody { get { return _classBody; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaClassSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _isAbstract;
				case 1: return _kClass;
				case 2: return _name;
				case 3: return _baseClasses;
				case 4: return _classBody;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaClassGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitMetaClassGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MetaClassGreen(this.Kind, _isAbstract, _kClass, _name, _baseClasses, _classBody, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MetaClassGreen(this.Kind, _isAbstract, _kClass, _name, _baseClasses, _classBody, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new MetaClassGreen(this.Kind, _isAbstract, _kClass, _name, _baseClasses, _classBody, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaClassGreen Update(InternalSyntaxToken isAbstract, InternalSyntaxToken kClass, ClassNameGreen name, BaseClassesGreen baseClasses, ClassBodyGreen classBody)
		{
			if (_isAbstract != isAbstract || _kClass != kClass || _name != name || _baseClasses != baseClasses || _classBody != classBody)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaClass((InternalSyntaxToken)isAbstract, (InternalSyntaxToken)kClass, name, baseClasses, classBody);
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
		private InternalSyntaxToken _tLBrace;
		private EnumLiteralsGreen _enumLiterals;
		private InternalSyntaxToken _tRBrace;
	
		public EnumBodyGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken tLBrace, EnumLiteralsGreen enumLiterals, InternalSyntaxToken tRBrace)
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
	
		public EnumBodyGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken tLBrace, EnumLiteralsGreen enumLiterals, InternalSyntaxToken tRBrace, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.EnumBody, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TLBrace { get { return _tLBrace; } }
		public EnumLiteralsGreen EnumLiterals { get { return _enumLiterals; } }
		public InternalSyntaxToken TRBrace { get { return _tRBrace; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.EnumBodySyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLBrace;
				case 1: return _enumLiterals;
				case 2: return _tRBrace;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitEnumBodyGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitEnumBodyGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new EnumBodyGreen(this.Kind, _tLBrace, _enumLiterals, _tRBrace, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new EnumBodyGreen(this.Kind, _tLBrace, _enumLiterals, _tRBrace, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new EnumBodyGreen(this.Kind, _tLBrace, _enumLiterals, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public EnumBodyGreen Update(InternalSyntaxToken tLBrace, EnumLiteralsGreen enumLiterals, InternalSyntaxToken tRBrace)
		{
			if (_tLBrace != tLBrace || _enumLiterals != enumLiterals || _tRBrace != tRBrace)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.EnumBody((InternalSyntaxToken)tLBrace, enumLiterals, (InternalSyntaxToken)tRBrace);
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
	
	internal class EnumLiteralsGreen : GreenSyntaxNode
	{
		internal static new readonly EnumLiteralsGreen __Missing = new EnumLiteralsGreen();
		private GreenNode _metaEnumLiteralList;
	
		public EnumLiteralsGreen(MetaCoreSyntaxKind kind, GreenNode metaEnumLiteralList)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (metaEnumLiteralList != null)
			{
				AdjustFlagsAndWidth(metaEnumLiteralList);
				_metaEnumLiteralList = metaEnumLiteralList;
			}
		}
	
		public EnumLiteralsGreen(MetaCoreSyntaxKind kind, GreenNode metaEnumLiteralList, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (metaEnumLiteralList != null)
			{
				AdjustFlagsAndWidth(metaEnumLiteralList);
				_metaEnumLiteralList = metaEnumLiteralList;
			}
		}
	
		private EnumLiteralsGreen()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.EnumLiterals, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen> MetaEnumLiteralList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen>(_metaEnumLiteralList, reversed: false); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.EnumLiteralsSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _metaEnumLiteralList;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitEnumLiteralsGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitEnumLiteralsGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new EnumLiteralsGreen(this.Kind, _metaEnumLiteralList, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new EnumLiteralsGreen(this.Kind, _metaEnumLiteralList, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new EnumLiteralsGreen(this.Kind, _metaEnumLiteralList, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public EnumLiteralsGreen Update(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen> metaEnumLiteralList)
		{
			if (_metaEnumLiteralList != metaEnumLiteralList.Node)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.EnumLiterals(metaEnumLiteralList);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (EnumLiteralsGreen)newNode;
			}
			return this;
		}
	}
	
	internal class MetaEnumLiteralGreen : GreenSyntaxNode
	{
		internal static new readonly MetaEnumLiteralGreen __Missing = new MetaEnumLiteralGreen();
		private NameGreen _name;
	
		public MetaEnumLiteralGreen(MetaCoreSyntaxKind kind, NameGreen name)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (name != null)
			{
				AdjustFlagsAndWidth(name);
				_name = name;
			}
		}
	
		public MetaEnumLiteralGreen(MetaCoreSyntaxKind kind, NameGreen name, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaEnumLiteral, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public NameGreen Name { get { return _name; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaEnumLiteralSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _name;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaEnumLiteralGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitMetaEnumLiteralGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MetaEnumLiteralGreen(this.Kind, _name, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MetaEnumLiteralGreen(this.Kind, _name, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new MetaEnumLiteralGreen(this.Kind, _name, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaEnumLiteralGreen Update(NameGreen name)
		{
			if (_name != name)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaEnumLiteral(name);
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
	
	    protected ClassNameGreen(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class ClassNameAlt1Green : ClassNameGreen
	{
		internal static new readonly ClassNameAlt1Green __Missing = new ClassNameAlt1Green();
		private InternalSyntaxToken _tIdentifier;
		private InternalSyntaxToken _tDollar;
		private IdentifierGreen _symbolType;
	
		public ClassNameAlt1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tIdentifier, InternalSyntaxToken tDollar, IdentifierGreen symbolType)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
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
	
		public ClassNameAlt1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tIdentifier, InternalSyntaxToken tDollar, IdentifierGreen symbolType, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.ClassNameAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TIdentifier { get { return _tIdentifier; } }
		public InternalSyntaxToken TDollar { get { return _tDollar; } }
		public IdentifierGreen SymbolType { get { return _symbolType; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.ClassNameAlt1Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tIdentifier;
				case 1: return _tDollar;
				case 2: return _symbolType;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitClassNameAlt1Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitClassNameAlt1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ClassNameAlt1Green(this.Kind, _tIdentifier, _tDollar, _symbolType, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ClassNameAlt1Green(this.Kind, _tIdentifier, _tDollar, _symbolType, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ClassNameAlt1Green(this.Kind, _tIdentifier, _tDollar, _symbolType, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ClassNameAlt1Green Update(InternalSyntaxToken tIdentifier, InternalSyntaxToken tDollar, IdentifierGreen symbolType)
		{
			if (_tIdentifier != tIdentifier || _tDollar != tDollar || _symbolType != symbolType)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.ClassNameAlt1((InternalSyntaxToken)tIdentifier, (InternalSyntaxToken)tDollar, symbolType);
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
		private InternalSyntaxToken _tIdentifier;
	
		public ClassNameAlt2Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tIdentifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
			}
		}
	
		public ClassNameAlt2Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tIdentifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
			}
		}
	
		private ClassNameAlt2Green()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.ClassNameAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TIdentifier { get { return _tIdentifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.ClassNameAlt2Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tIdentifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitClassNameAlt2Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitClassNameAlt2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ClassNameAlt2Green(this.Kind, _tIdentifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ClassNameAlt2Green(this.Kind, _tIdentifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ClassNameAlt2Green(this.Kind, _tIdentifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ClassNameAlt2Green Update(InternalSyntaxToken tIdentifier)
		{
			if (_tIdentifier != tIdentifier)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.ClassNameAlt2((InternalSyntaxToken)tIdentifier);
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
		private BaseClassesBlock1Green _baseClassesBlock1;
	
		public BaseClassesGreen(MetaCoreSyntaxKind kind, BaseClassesBlock1Green baseClassesBlock1)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (baseClassesBlock1 != null)
			{
				AdjustFlagsAndWidth(baseClassesBlock1);
				_baseClassesBlock1 = baseClassesBlock1;
			}
		}
	
		public BaseClassesGreen(MetaCoreSyntaxKind kind, BaseClassesBlock1Green baseClassesBlock1, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (baseClassesBlock1 != null)
			{
				AdjustFlagsAndWidth(baseClassesBlock1);
				_baseClassesBlock1 = baseClassesBlock1;
			}
		}
	
		private BaseClassesGreen()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.BaseClasses, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public BaseClassesBlock1Green BaseClassesBlock1 { get { return _baseClassesBlock1; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.BaseClassesSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _baseClassesBlock1;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBaseClassesGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitBaseClassesGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new BaseClassesGreen(this.Kind, _baseClassesBlock1, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new BaseClassesGreen(this.Kind, _baseClassesBlock1, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new BaseClassesGreen(this.Kind, _baseClassesBlock1, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public BaseClassesGreen Update(BaseClassesBlock1Green baseClassesBlock1)
		{
			if (_baseClassesBlock1 != baseClassesBlock1)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.BaseClasses(baseClassesBlock1);
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
		private InternalSyntaxToken _tLBrace;
		private GreenNode _properties;
		private InternalSyntaxToken _tRBrace;
	
		public ClassBodyGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken tLBrace, GreenNode properties, InternalSyntaxToken tRBrace)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (properties != null)
			{
				AdjustFlagsAndWidth(properties);
				_properties = properties;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		public ClassBodyGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken tLBrace, GreenNode properties, InternalSyntaxToken tRBrace, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tLBrace != null)
			{
				AdjustFlagsAndWidth(tLBrace);
				_tLBrace = tLBrace;
			}
			if (properties != null)
			{
				AdjustFlagsAndWidth(properties);
				_properties = properties;
			}
			if (tRBrace != null)
			{
				AdjustFlagsAndWidth(tRBrace);
				_tRBrace = tRBrace;
			}
		}
	
		private ClassBodyGreen()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.ClassBody, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TLBrace { get { return _tLBrace; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyGreen> Properties { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyGreen>(_properties); } }
		public InternalSyntaxToken TRBrace { get { return _tRBrace; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.ClassBodySyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tLBrace;
				case 1: return _properties;
				case 2: return _tRBrace;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitClassBodyGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitClassBodyGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new ClassBodyGreen(this.Kind, _tLBrace, _properties, _tRBrace, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new ClassBodyGreen(this.Kind, _tLBrace, _properties, _tRBrace, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new ClassBodyGreen(this.Kind, _tLBrace, _properties, _tRBrace, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public ClassBodyGreen Update(InternalSyntaxToken tLBrace, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyGreen> properties, InternalSyntaxToken tRBrace)
		{
			if (_tLBrace != tLBrace || _properties != properties.Node || _tRBrace != tRBrace)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.ClassBody((InternalSyntaxToken)tLBrace, properties, (InternalSyntaxToken)tRBrace);
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
	
	internal class MetaPropertyGreen : GreenSyntaxNode
	{
		internal static new readonly MetaPropertyGreen __Missing = new MetaPropertyGreen();
		private InternalSyntaxToken _element;
		private TypeReferenceGreen _type;
		private PropertyNameGreen _name;
		private GreenNode _metaPropertyBlock2;
		private InternalSyntaxToken _tSemicolon;
	
		public MetaPropertyGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken element, TypeReferenceGreen type, PropertyNameGreen name, GreenNode metaPropertyBlock2, InternalSyntaxToken tSemicolon)
			: base(kind, null, null)
		{
			SlotCount = 5;
			if (element != null)
			{
				AdjustFlagsAndWidth(element);
				_element = element;
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
			if (metaPropertyBlock2 != null)
			{
				AdjustFlagsAndWidth(metaPropertyBlock2);
				_metaPropertyBlock2 = metaPropertyBlock2;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		public MetaPropertyGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken element, TypeReferenceGreen type, PropertyNameGreen name, GreenNode metaPropertyBlock2, InternalSyntaxToken tSemicolon, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 5;
			if (element != null)
			{
				AdjustFlagsAndWidth(element);
				_element = element;
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
			if (metaPropertyBlock2 != null)
			{
				AdjustFlagsAndWidth(metaPropertyBlock2);
				_metaPropertyBlock2 = metaPropertyBlock2;
			}
			if (tSemicolon != null)
			{
				AdjustFlagsAndWidth(tSemicolon);
				_tSemicolon = tSemicolon;
			}
		}
	
		private MetaPropertyGreen()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaProperty, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken Element { get { return _element; } }
		public TypeReferenceGreen Type { get { return _type; } }
		public PropertyNameGreen Name { get { return _name; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock2Green> MetaPropertyBlock2 { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock2Green>(_metaPropertyBlock2); } }
		public InternalSyntaxToken TSemicolon { get { return _tSemicolon; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertySyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _element;
				case 1: return _type;
				case 2: return _name;
				case 3: return _metaPropertyBlock2;
				case 4: return _tSemicolon;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MetaPropertyGreen(this.Kind, _element, _type, _name, _metaPropertyBlock2, _tSemicolon, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MetaPropertyGreen(this.Kind, _element, _type, _name, _metaPropertyBlock2, _tSemicolon, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new MetaPropertyGreen(this.Kind, _element, _type, _name, _metaPropertyBlock2, _tSemicolon, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaPropertyGreen Update(InternalSyntaxToken element, TypeReferenceGreen type, PropertyNameGreen name, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock2Green> metaPropertyBlock2, InternalSyntaxToken tSemicolon)
		{
			if (_element != element || _type != type || _name != name || _metaPropertyBlock2 != metaPropertyBlock2.Node || _tSemicolon != tSemicolon)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaProperty((InternalSyntaxToken)element, type, name, metaPropertyBlock2, (InternalSyntaxToken)tSemicolon);
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
	
	    protected PropertyNameGreen(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class PropertyNameAlt1Green : PropertyNameGreen
	{
		internal static new readonly PropertyNameAlt1Green __Missing = new PropertyNameAlt1Green();
		private InternalSyntaxToken _tIdentifier;
		private InternalSyntaxToken _tDollar;
		private InternalSyntaxToken _symbolProperty;
	
		public PropertyNameAlt1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tIdentifier, InternalSyntaxToken tDollar, InternalSyntaxToken symbolProperty)
			: base(kind, null, null)
		{
			SlotCount = 3;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
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
	
		public PropertyNameAlt1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tIdentifier, InternalSyntaxToken tDollar, InternalSyntaxToken symbolProperty, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 3;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.PropertyNameAlt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TIdentifier { get { return _tIdentifier; } }
		public InternalSyntaxToken TDollar { get { return _tDollar; } }
		public InternalSyntaxToken SymbolProperty { get { return _symbolProperty; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.PropertyNameAlt1Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tIdentifier;
				case 1: return _tDollar;
				case 2: return _symbolProperty;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyNameAlt1Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitPropertyNameAlt1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PropertyNameAlt1Green(this.Kind, _tIdentifier, _tDollar, _symbolProperty, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PropertyNameAlt1Green(this.Kind, _tIdentifier, _tDollar, _symbolProperty, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PropertyNameAlt1Green(this.Kind, _tIdentifier, _tDollar, _symbolProperty, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyNameAlt1Green Update(InternalSyntaxToken tIdentifier, InternalSyntaxToken tDollar, InternalSyntaxToken symbolProperty)
		{
			if (_tIdentifier != tIdentifier || _tDollar != tDollar || _symbolProperty != symbolProperty)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.PropertyNameAlt1((InternalSyntaxToken)tIdentifier, (InternalSyntaxToken)tDollar, (InternalSyntaxToken)symbolProperty);
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
		private InternalSyntaxToken _tIdentifier;
	
		public PropertyNameAlt2Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tIdentifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
			}
		}
	
		public PropertyNameAlt2Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tIdentifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
			}
		}
	
		private PropertyNameAlt2Green()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.PropertyNameAlt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TIdentifier { get { return _tIdentifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.PropertyNameAlt2Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tIdentifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyNameAlt2Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitPropertyNameAlt2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PropertyNameAlt2Green(this.Kind, _tIdentifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PropertyNameAlt2Green(this.Kind, _tIdentifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PropertyNameAlt2Green(this.Kind, _tIdentifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyNameAlt2Green Update(InternalSyntaxToken tIdentifier)
		{
			if (_tIdentifier != tIdentifier)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.PropertyNameAlt2((InternalSyntaxToken)tIdentifier);
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
	
	internal class PropertyOppositeGreen : GreenSyntaxNode
	{
		internal static new readonly PropertyOppositeGreen __Missing = new PropertyOppositeGreen();
		private InternalSyntaxToken _kOpposite;
		private GreenNode _qualifierList;
	
		public PropertyOppositeGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kOpposite, GreenNode qualifierList)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (kOpposite != null)
			{
				AdjustFlagsAndWidth(kOpposite);
				_kOpposite = kOpposite;
			}
			if (qualifierList != null)
			{
				AdjustFlagsAndWidth(qualifierList);
				_qualifierList = qualifierList;
			}
		}
	
		public PropertyOppositeGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kOpposite, GreenNode qualifierList, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (kOpposite != null)
			{
				AdjustFlagsAndWidth(kOpposite);
				_kOpposite = kOpposite;
			}
			if (qualifierList != null)
			{
				AdjustFlagsAndWidth(qualifierList);
				_qualifierList = qualifierList;
			}
		}
	
		private PropertyOppositeGreen()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.PropertyOpposite, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KOpposite { get { return _kOpposite; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> QualifierList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_qualifierList, reversed: false); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.PropertyOppositeSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kOpposite;
				case 1: return _qualifierList;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyOppositeGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitPropertyOppositeGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PropertyOppositeGreen(this.Kind, _kOpposite, _qualifierList, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PropertyOppositeGreen(this.Kind, _kOpposite, _qualifierList, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PropertyOppositeGreen(this.Kind, _kOpposite, _qualifierList, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyOppositeGreen Update(InternalSyntaxToken kOpposite, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> qualifierList)
		{
			if (_kOpposite != kOpposite || _qualifierList != qualifierList.Node)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.PropertyOpposite((InternalSyntaxToken)kOpposite, qualifierList);
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
	
	internal class PropertySubsetsGreen : GreenSyntaxNode
	{
		internal static new readonly PropertySubsetsGreen __Missing = new PropertySubsetsGreen();
		private InternalSyntaxToken _kSubsets;
		private GreenNode _qualifierList;
	
		public PropertySubsetsGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kSubsets, GreenNode qualifierList)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (kSubsets != null)
			{
				AdjustFlagsAndWidth(kSubsets);
				_kSubsets = kSubsets;
			}
			if (qualifierList != null)
			{
				AdjustFlagsAndWidth(qualifierList);
				_qualifierList = qualifierList;
			}
		}
	
		public PropertySubsetsGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kSubsets, GreenNode qualifierList, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (kSubsets != null)
			{
				AdjustFlagsAndWidth(kSubsets);
				_kSubsets = kSubsets;
			}
			if (qualifierList != null)
			{
				AdjustFlagsAndWidth(qualifierList);
				_qualifierList = qualifierList;
			}
		}
	
		private PropertySubsetsGreen()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.PropertySubsets, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KSubsets { get { return _kSubsets; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> QualifierList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_qualifierList, reversed: false); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.PropertySubsetsSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kSubsets;
				case 1: return _qualifierList;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertySubsetsGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitPropertySubsetsGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PropertySubsetsGreen(this.Kind, _kSubsets, _qualifierList, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PropertySubsetsGreen(this.Kind, _kSubsets, _qualifierList, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PropertySubsetsGreen(this.Kind, _kSubsets, _qualifierList, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertySubsetsGreen Update(InternalSyntaxToken kSubsets, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> qualifierList)
		{
			if (_kSubsets != kSubsets || _qualifierList != qualifierList.Node)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.PropertySubsets((InternalSyntaxToken)kSubsets, qualifierList);
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
	
	internal class PropertyRedefinesGreen : GreenSyntaxNode
	{
		internal static new readonly PropertyRedefinesGreen __Missing = new PropertyRedefinesGreen();
		private InternalSyntaxToken _kRedefines;
		private GreenNode _qualifierList;
	
		public PropertyRedefinesGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kRedefines, GreenNode qualifierList)
			: base(kind, null, null)
		{
			SlotCount = 2;
			if (kRedefines != null)
			{
				AdjustFlagsAndWidth(kRedefines);
				_kRedefines = kRedefines;
			}
			if (qualifierList != null)
			{
				AdjustFlagsAndWidth(qualifierList);
				_qualifierList = qualifierList;
			}
		}
	
		public PropertyRedefinesGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken kRedefines, GreenNode qualifierList, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 2;
			if (kRedefines != null)
			{
				AdjustFlagsAndWidth(kRedefines);
				_kRedefines = kRedefines;
			}
			if (qualifierList != null)
			{
				AdjustFlagsAndWidth(qualifierList);
				_qualifierList = qualifierList;
			}
		}
	
		private PropertyRedefinesGreen()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.PropertyRedefines, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken KRedefines { get { return _kRedefines; } }
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> QualifierList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_qualifierList, reversed: false); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.PropertyRedefinesSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _kRedefines;
				case 1: return _qualifierList;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyRedefinesGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitPropertyRedefinesGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PropertyRedefinesGreen(this.Kind, _kRedefines, _qualifierList, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PropertyRedefinesGreen(this.Kind, _kRedefines, _qualifierList, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PropertyRedefinesGreen(this.Kind, _kRedefines, _qualifierList, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyRedefinesGreen Update(InternalSyntaxToken kRedefines, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> qualifierList)
		{
			if (_kRedefines != kRedefines || _qualifierList != qualifierList.Node)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.PropertyRedefines((InternalSyntaxToken)kRedefines, qualifierList);
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
	
	internal abstract class TypeReferenceGreen : GreenSyntaxNode
	{
		internal static readonly TypeReferenceGreen __Missing = MetaArrayTypeGreen.__Missing;
	
	    protected TypeReferenceGreen(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class MetaArrayTypeGreen : TypeReferenceGreen
	{
		internal static new readonly MetaArrayTypeGreen __Missing = new MetaArrayTypeGreen();
		private TypeReferenceGreen _itemType;
		private InternalSyntaxToken _tLBracket;
		private InternalSyntaxToken _tRBracket;
	
		public MetaArrayTypeGreen(MetaCoreSyntaxKind kind, TypeReferenceGreen itemType, InternalSyntaxToken tLBracket, InternalSyntaxToken tRBracket)
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
	
		public MetaArrayTypeGreen(MetaCoreSyntaxKind kind, TypeReferenceGreen itemType, InternalSyntaxToken tLBracket, InternalSyntaxToken tRBracket, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaArrayType, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public TypeReferenceGreen ItemType { get { return _itemType; } }
		public InternalSyntaxToken TLBracket { get { return _tLBracket; } }
		public InternalSyntaxToken TRBracket { get { return _tRBracket; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaArrayTypeSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _itemType;
				case 1: return _tLBracket;
				case 2: return _tRBracket;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaArrayTypeGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitMetaArrayTypeGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MetaArrayTypeGreen(this.Kind, _itemType, _tLBracket, _tRBracket, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MetaArrayTypeGreen(this.Kind, _itemType, _tLBracket, _tRBracket, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new MetaArrayTypeGreen(this.Kind, _itemType, _tLBracket, _tRBracket, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaArrayTypeGreen Update(TypeReferenceGreen itemType, InternalSyntaxToken tLBracket, InternalSyntaxToken tRBracket)
		{
			if (_itemType != itemType || _tLBracket != tLBracket || _tRBracket != tRBracket)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaArrayType(itemType, (InternalSyntaxToken)tLBracket, (InternalSyntaxToken)tRBracket);
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
	
	internal class TypeReferenceAlt3Green : TypeReferenceGreen
	{
		internal static new readonly TypeReferenceAlt3Green __Missing = new TypeReferenceAlt3Green();
		private QualifierGreen _qualifier;
	
		public TypeReferenceAlt3Green(MetaCoreSyntaxKind kind, QualifierGreen qualifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		public TypeReferenceAlt3Green(MetaCoreSyntaxKind kind, QualifierGreen qualifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (qualifier != null)
			{
				AdjustFlagsAndWidth(qualifier);
				_qualifier = qualifier;
			}
		}
	
		private TypeReferenceAlt3Green()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.TypeReferenceAlt3, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public QualifierGreen Qualifier { get { return _qualifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.TypeReferenceAlt3Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _qualifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceAlt3Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceAlt3Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new TypeReferenceAlt3Green(this.Kind, _qualifier, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new TypeReferenceAlt3Green(this.Kind, _qualifier, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new TypeReferenceAlt3Green(this.Kind, _qualifier, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TypeReferenceAlt3Green Update(QualifierGreen qualifier)
		{
			if (_qualifier != qualifier)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt3(qualifier);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (TypeReferenceAlt3Green)newNode;
			}
			return this;
		}
	}
	
	internal class TypeReferenceTokensGreen : TypeReferenceGreen
	{
		internal static new readonly TypeReferenceTokensGreen __Missing = new TypeReferenceTokensGreen();
		private InternalSyntaxToken _tokens;
	
		public TypeReferenceTokensGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken tokens)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
		}
	
		public TypeReferenceTokensGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken tokens, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (tokens != null)
			{
				AdjustFlagsAndWidth(tokens);
				_tokens = tokens;
			}
		}
	
		private TypeReferenceTokensGreen()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.TypeReferenceTokens, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken Tokens { get { return _tokens; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.TypeReferenceTokensSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tokens;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitTypeReferenceTokensGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitTypeReferenceTokensGreen(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new TypeReferenceTokensGreen(this.Kind, _tokens, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new TypeReferenceTokensGreen(this.Kind, _tokens, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new TypeReferenceTokensGreen(this.Kind, _tokens, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public TypeReferenceTokensGreen Update(InternalSyntaxToken tokens)
		{
			if (_tokens != tokens)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.TypeReferenceTokens((InternalSyntaxToken)tokens);
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
	
	internal class NameGreen : GreenSyntaxNode
	{
		internal static new readonly NameGreen __Missing = new NameGreen();
		private IdentifierGreen _identifier;
	
		public NameGreen(MetaCoreSyntaxKind kind, IdentifierGreen identifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (identifier != null)
			{
				AdjustFlagsAndWidth(identifier);
				_identifier = identifier;
			}
		}
	
		public NameGreen(MetaCoreSyntaxKind kind, IdentifierGreen identifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.Name, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public IdentifierGreen Identifier { get { return _identifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.NameSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _identifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitNameGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitNameGreen(this);
	
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
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.Name(identifier);
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
	
		public QualifierGreen(MetaCoreSyntaxKind kind, GreenNode identifierList)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (identifierList != null)
			{
				AdjustFlagsAndWidth(identifierList);
				_identifierList = identifierList;
			}
		}
	
		public QualifierGreen(MetaCoreSyntaxKind kind, GreenNode identifierList, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.Qualifier, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> IdentifierList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen>(_identifierList, reversed: false); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.QualifierSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _identifierList;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitQualifierGreen(this);
	
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
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.Qualifier(identifierList);
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
	
		public QualifierListGreen(MetaCoreSyntaxKind kind, GreenNode qualifierList)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (qualifierList != null)
			{
				AdjustFlagsAndWidth(qualifierList);
				_qualifierList = qualifierList;
			}
		}
	
		public QualifierListGreen(MetaCoreSyntaxKind kind, GreenNode qualifierList, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.QualifierList, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> QualifierList { get { return new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen>(_qualifierList, reversed: false); } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.QualifierListSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _qualifierList;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierListGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitQualifierListGreen(this);
	
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
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.QualifierList(qualifierList);
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
	
		public IdentifierGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken tIdentifier)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (tIdentifier != null)
			{
				AdjustFlagsAndWidth(tIdentifier);
				_tIdentifier = tIdentifier;
			}
		}
	
		public IdentifierGreen(MetaCoreSyntaxKind kind, InternalSyntaxToken tIdentifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.Identifier, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TIdentifier { get { return _tIdentifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.IdentifierSyntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tIdentifier;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitIdentifierGreen(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitIdentifierGreen(this);
	
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
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.Identifier((InternalSyntaxToken)tIdentifier);
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
	
	internal class EnumLiteralsBlock1Green : GreenSyntaxNode
	{
		internal static new readonly EnumLiteralsBlock1Green __Missing = new EnumLiteralsBlock1Green();
		private InternalSyntaxToken _tComma;
		private MetaEnumLiteralGreen _literals;
	
		public EnumLiteralsBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tComma, MetaEnumLiteralGreen literals)
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
	
		public EnumLiteralsBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tComma, MetaEnumLiteralGreen literals, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private EnumLiteralsBlock1Green()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.EnumLiteralsBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TComma { get { return _tComma; } }
		public MetaEnumLiteralGreen Literals { get { return _literals; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.EnumLiteralsBlock1Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _literals;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitEnumLiteralsBlock1Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitEnumLiteralsBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new EnumLiteralsBlock1Green(this.Kind, _tComma, _literals, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new EnumLiteralsBlock1Green(this.Kind, _tComma, _literals, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new EnumLiteralsBlock1Green(this.Kind, _tComma, _literals, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public EnumLiteralsBlock1Green Update(InternalSyntaxToken tComma, MetaEnumLiteralGreen literals)
		{
			if (_tComma != tComma || _literals != literals)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.EnumLiteralsBlock1((InternalSyntaxToken)tComma, literals);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (EnumLiteralsBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class BaseClassesBlock1Green : GreenSyntaxNode
	{
		internal static new readonly BaseClassesBlock1Green __Missing = new BaseClassesBlock1Green();
		private InternalSyntaxToken _tColon;
		private QualifierListGreen _baseTypes;
	
		public BaseClassesBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tColon, QualifierListGreen baseTypes)
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
	
		public BaseClassesBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tColon, QualifierListGreen baseTypes, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private BaseClassesBlock1Green()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.BaseClassesBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TColon { get { return _tColon; } }
		public QualifierListGreen BaseTypes { get { return _baseTypes; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.BaseClassesBlock1Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tColon;
				case 1: return _baseTypes;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitBaseClassesBlock1Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitBaseClassesBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new BaseClassesBlock1Green(this.Kind, _tColon, _baseTypes, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new BaseClassesBlock1Green(this.Kind, _tColon, _baseTypes, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new BaseClassesBlock1Green(this.Kind, _tColon, _baseTypes, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public BaseClassesBlock1Green Update(InternalSyntaxToken tColon, QualifierListGreen baseTypes)
		{
			if (_tColon != tColon || _baseTypes != baseTypes)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.BaseClassesBlock1((InternalSyntaxToken)tColon, baseTypes);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (BaseClassesBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal abstract class MetaPropertyBlock2Green : GreenSyntaxNode
	{
		internal static readonly MetaPropertyBlock2Green __Missing = MetaPropertyBlock2Alt1Green.__Missing;
	
	    protected MetaPropertyBlock2Green(MetaCoreSyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
	        : base(kind, diagnostics, annotations)
	    {
	    }
	}
	
	internal class MetaPropertyBlock2Alt1Green : MetaPropertyBlock2Green
	{
		internal static new readonly MetaPropertyBlock2Alt1Green __Missing = new MetaPropertyBlock2Alt1Green();
		private PropertyOppositeGreen _propertyOpposite;
	
		public MetaPropertyBlock2Alt1Green(MetaCoreSyntaxKind kind, PropertyOppositeGreen propertyOpposite)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (propertyOpposite != null)
			{
				AdjustFlagsAndWidth(propertyOpposite);
				_propertyOpposite = propertyOpposite;
			}
		}
	
		public MetaPropertyBlock2Alt1Green(MetaCoreSyntaxKind kind, PropertyOppositeGreen propertyOpposite, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (propertyOpposite != null)
			{
				AdjustFlagsAndWidth(propertyOpposite);
				_propertyOpposite = propertyOpposite;
			}
		}
	
		private MetaPropertyBlock2Alt1Green()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaPropertyBlock2Alt1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public PropertyOppositeGreen PropertyOpposite { get { return _propertyOpposite; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock2Alt1Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _propertyOpposite;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock2Alt1Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock2Alt1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MetaPropertyBlock2Alt1Green(this.Kind, _propertyOpposite, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MetaPropertyBlock2Alt1Green(this.Kind, _propertyOpposite, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new MetaPropertyBlock2Alt1Green(this.Kind, _propertyOpposite, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaPropertyBlock2Alt1Green Update(PropertyOppositeGreen propertyOpposite)
		{
			if (_propertyOpposite != propertyOpposite)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock2Alt1(propertyOpposite);
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
		private PropertySubsetsGreen _propertySubsets;
	
		public MetaPropertyBlock2Alt2Green(MetaCoreSyntaxKind kind, PropertySubsetsGreen propertySubsets)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (propertySubsets != null)
			{
				AdjustFlagsAndWidth(propertySubsets);
				_propertySubsets = propertySubsets;
			}
		}
	
		public MetaPropertyBlock2Alt2Green(MetaCoreSyntaxKind kind, PropertySubsetsGreen propertySubsets, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (propertySubsets != null)
			{
				AdjustFlagsAndWidth(propertySubsets);
				_propertySubsets = propertySubsets;
			}
		}
	
		private MetaPropertyBlock2Alt2Green()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaPropertyBlock2Alt2, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public PropertySubsetsGreen PropertySubsets { get { return _propertySubsets; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock2Alt2Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _propertySubsets;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock2Alt2Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock2Alt2Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MetaPropertyBlock2Alt2Green(this.Kind, _propertySubsets, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MetaPropertyBlock2Alt2Green(this.Kind, _propertySubsets, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new MetaPropertyBlock2Alt2Green(this.Kind, _propertySubsets, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaPropertyBlock2Alt2Green Update(PropertySubsetsGreen propertySubsets)
		{
			if (_propertySubsets != propertySubsets)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock2Alt2(propertySubsets);
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
	
	internal class MetaPropertyBlock2Alt3Green : MetaPropertyBlock2Green
	{
		internal static new readonly MetaPropertyBlock2Alt3Green __Missing = new MetaPropertyBlock2Alt3Green();
		private PropertyRedefinesGreen _propertyRedefines;
	
		public MetaPropertyBlock2Alt3Green(MetaCoreSyntaxKind kind, PropertyRedefinesGreen propertyRedefines)
			: base(kind, null, null)
		{
			SlotCount = 1;
			if (propertyRedefines != null)
			{
				AdjustFlagsAndWidth(propertyRedefines);
				_propertyRedefines = propertyRedefines;
			}
		}
	
		public MetaPropertyBlock2Alt3Green(MetaCoreSyntaxKind kind, PropertyRedefinesGreen propertyRedefines, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
			: base(kind, diagnostics, annotations)
		{
			SlotCount = 1;
			if (propertyRedefines != null)
			{
				AdjustFlagsAndWidth(propertyRedefines);
				_propertyRedefines = propertyRedefines;
			}
		}
	
		private MetaPropertyBlock2Alt3Green()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaPropertyBlock2Alt3, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public PropertyRedefinesGreen PropertyRedefines { get { return _propertyRedefines; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.MetaPropertyBlock2Alt3Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _propertyRedefines;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitMetaPropertyBlock2Alt3Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitMetaPropertyBlock2Alt3Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new MetaPropertyBlock2Alt3Green(this.Kind, _propertyRedefines, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new MetaPropertyBlock2Alt3Green(this.Kind, _propertyRedefines, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new MetaPropertyBlock2Alt3Green(this.Kind, _propertyRedefines, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public MetaPropertyBlock2Alt3Green Update(PropertyRedefinesGreen propertyRedefines)
		{
			if (_propertyRedefines != propertyRedefines)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock2Alt3(propertyRedefines);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (MetaPropertyBlock2Alt3Green)newNode;
			}
			return this;
		}
	}
	
	internal class PropertyOppositeBlock1Green : GreenSyntaxNode
	{
		internal static new readonly PropertyOppositeBlock1Green __Missing = new PropertyOppositeBlock1Green();
		private InternalSyntaxToken _tComma;
		private QualifierGreen _oppositeProperties;
	
		public PropertyOppositeBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tComma, QualifierGreen oppositeProperties)
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
	
		public PropertyOppositeBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tComma, QualifierGreen oppositeProperties, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private PropertyOppositeBlock1Green()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.PropertyOppositeBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TComma { get { return _tComma; } }
		public QualifierGreen OppositeProperties { get { return _oppositeProperties; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.PropertyOppositeBlock1Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _oppositeProperties;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyOppositeBlock1Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitPropertyOppositeBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PropertyOppositeBlock1Green(this.Kind, _tComma, _oppositeProperties, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PropertyOppositeBlock1Green(this.Kind, _tComma, _oppositeProperties, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PropertyOppositeBlock1Green(this.Kind, _tComma, _oppositeProperties, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyOppositeBlock1Green Update(InternalSyntaxToken tComma, QualifierGreen oppositeProperties)
		{
			if (_tComma != tComma || _oppositeProperties != oppositeProperties)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.PropertyOppositeBlock1((InternalSyntaxToken)tComma, oppositeProperties);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PropertyOppositeBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class PropertySubsetsBlock1Green : GreenSyntaxNode
	{
		internal static new readonly PropertySubsetsBlock1Green __Missing = new PropertySubsetsBlock1Green();
		private InternalSyntaxToken _tComma;
		private QualifierGreen _subsettedProperties;
	
		public PropertySubsetsBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tComma, QualifierGreen subsettedProperties)
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
	
		public PropertySubsetsBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tComma, QualifierGreen subsettedProperties, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private PropertySubsetsBlock1Green()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.PropertySubsetsBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TComma { get { return _tComma; } }
		public QualifierGreen SubsettedProperties { get { return _subsettedProperties; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.PropertySubsetsBlock1Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _subsettedProperties;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertySubsetsBlock1Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitPropertySubsetsBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PropertySubsetsBlock1Green(this.Kind, _tComma, _subsettedProperties, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PropertySubsetsBlock1Green(this.Kind, _tComma, _subsettedProperties, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PropertySubsetsBlock1Green(this.Kind, _tComma, _subsettedProperties, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertySubsetsBlock1Green Update(InternalSyntaxToken tComma, QualifierGreen subsettedProperties)
		{
			if (_tComma != tComma || _subsettedProperties != subsettedProperties)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.PropertySubsetsBlock1((InternalSyntaxToken)tComma, subsettedProperties);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PropertySubsetsBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class PropertyRedefinesBlock1Green : GreenSyntaxNode
	{
		internal static new readonly PropertyRedefinesBlock1Green __Missing = new PropertyRedefinesBlock1Green();
		private InternalSyntaxToken _tComma;
		private QualifierGreen _redefinedProperties;
	
		public PropertyRedefinesBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tComma, QualifierGreen redefinedProperties)
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
	
		public PropertyRedefinesBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tComma, QualifierGreen redefinedProperties, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
	
		private PropertyRedefinesBlock1Green()
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.PropertyRedefinesBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TComma { get { return _tComma; } }
		public QualifierGreen RedefinedProperties { get { return _redefinedProperties; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.PropertyRedefinesBlock1Syntax(this, (MetaCoreSyntaxNode)parent, position);
		}
	
		protected override GreenNode GetSlot(int index)
		{
			switch (index)
			{
				case 0: return _tComma;
				case 1: return _redefinedProperties;
				default: return null;
			}
		}
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitPropertyRedefinesBlock1Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitPropertyRedefinesBlock1Green(this);
	
		public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[] diagnostics)
		{
			return new PropertyRedefinesBlock1Green(this.Kind, _tComma, _redefinedProperties, diagnostics, this.GetAnnotations());
		}
	
		public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[] annotations)
		{
			return new PropertyRedefinesBlock1Green(this.Kind, _tComma, _redefinedProperties, this.GetDiagnostics(), annotations);
		}
	
		public override GreenNode Clone()
		{
			return new PropertyRedefinesBlock1Green(this.Kind, _tComma, _redefinedProperties, this.GetDiagnostics(), this.GetAnnotations());
		}
	
	
		public PropertyRedefinesBlock1Green Update(InternalSyntaxToken tComma, QualifierGreen redefinedProperties)
		{
			if (_tComma != tComma || _redefinedProperties != redefinedProperties)
			{
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.PropertyRedefinesBlock1((InternalSyntaxToken)tComma, redefinedProperties);
				var diags = this.GetDiagnostics();
				if (diags != null && diags.Length > 0)
					newNode = newNode.WithDiagnostics(diags);
				var annotations = this.GetAnnotations();
				if (annotations != null && annotations.Length > 0)
					newNode = newNode.WithAnnotations(annotations);
				return (PropertyRedefinesBlock1Green)newNode;
			}
			return this;
		}
	}
	
	internal class QualifierBlock1Green : GreenSyntaxNode
	{
		internal static new readonly QualifierBlock1Green __Missing = new QualifierBlock1Green();
		private InternalSyntaxToken _tDot;
		private IdentifierGreen _identifier;
	
		public QualifierBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tDot, IdentifierGreen identifier)
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
	
		public QualifierBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tDot, IdentifierGreen identifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.QualifierBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TDot { get { return _tDot; } }
		public IdentifierGreen Identifier { get { return _identifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.QualifierBlock1Syntax(this, (MetaCoreSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierBlock1Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitQualifierBlock1Green(this);
	
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
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.QualifierBlock1((InternalSyntaxToken)tDot, identifier);
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
	
		public QualifierListBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tComma, QualifierGreen qualifier)
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
	
		public QualifierListBlock1Green(MetaCoreSyntaxKind kind, InternalSyntaxToken tComma, QualifierGreen qualifier, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
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
			: base((MetaCoreSyntaxKind)MetaCoreSyntaxKind.QualifierListBlock1, null, null)
		{
			this.flags &= ~NodeFlags.IsNotMissing;
		}
	
		public InternalSyntaxToken TComma { get { return _tComma; } }
		public QualifierGreen Qualifier { get { return _qualifier; } }
	
		protected override SyntaxNode CreateRed(SyntaxNode parent, int position)
		{
			return new global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.QualifierListBlock1Syntax(this, (MetaCoreSyntaxNode)parent, position);
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
	
		public override TResult Accept<TResult>(MetaCoreInternalSyntaxVisitor<TResult> visitor) => visitor.VisitQualifierListBlock1Green(this);
	
		public override void Accept(MetaCoreInternalSyntaxVisitor visitor) => visitor.VisitQualifierListBlock1Green(this);
	
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
				InternalSyntaxNode newNode = MetaCoreLanguage.Instance.InternalSyntaxFactory.QualifierListBlock1((InternalSyntaxToken)tComma, qualifier);
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
