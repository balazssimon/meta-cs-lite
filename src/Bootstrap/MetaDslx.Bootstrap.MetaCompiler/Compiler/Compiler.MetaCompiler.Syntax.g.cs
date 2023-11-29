using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
{

    public abstract class CompilerSyntaxNode : SyntaxNode
    {
        protected CompilerSyntaxNode(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }

        protected CompilerSyntaxNode(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public override Language Language => CompilerLanguage.Instance;
        public CompilerSyntaxKind Kind => (CompilerSyntaxKind)this.RawKind;
		internal new GreenNode Green => base.Green;

        protected override SyntaxTree CreateSyntaxTreeForRoot()
        {
            return CompilerSyntaxTree.CreateWithoutClone(this, IncrementalParseData.Empty);
        }

        public override TResult Accept<TArg, TResult>(SyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            if (visitor is ICompilerSyntaxVisitor<TArg, TResult> typedVisitor) return this.Accept(typedVisitor, argument);
            else return visitor.DefaultVisit(this, argument);
        }

        public abstract TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument);

        public override TResult Accept<TResult>(SyntaxVisitor<TResult> visitor)
        {
            if (visitor is ICompilerSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor);

        public override void Accept(SyntaxVisitor visitor)
        {
            if (visitor is ICompilerSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }
        public abstract void Accept(ICompilerSyntaxVisitor visitor);
    }

    /// <summary>
    /// It's a non terminal Trivia CompilerSyntaxNode that has a tree underneath it.
    /// </summary>
    public abstract partial class CompilerStructuredTriviaSyntax : CompilerSyntaxNode, IStructuredTriviaSyntax
    {
        private SyntaxTrivia _parent;
        internal CompilerStructuredTriviaSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent == null ? null : (CompilerSyntaxTree)parent.SyntaxTree, position)
        {
            System.Diagnostics.Debug.Assert(parent == null || position >= 0);
        }
		internal static CompilerStructuredTriviaSyntax Create(SyntaxTrivia trivia)
		{
			var red = (CompilerStructuredTriviaSyntax)CompilerLanguage.Instance.SyntaxFactory.CreateStructure(trivia);
			red._parent = trivia;
			return red;
		}
        /// <summary>
        /// Get parent trivia.
        /// </summary>
        public override SyntaxTrivia ParentTrivia => _parent;
    }

    public sealed partial class CompilerSkippedTokensTriviaSyntax : CompilerStructuredTriviaSyntax
    {
        internal CompilerSkippedTokensTriviaSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public SyntaxTokenList Tokens 
        {
            get
            {
				var slot = ((global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.GreenSkippedTokensTriviaSyntax)this.Green).Tokens;
				if (slot != null)
				{
					return new SyntaxTokenList(this, slot.Node, this.GetChildPosition(0), this.GetChildIndex(0));
				}
                return default;
            }
        }

        protected override SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                default: return null;
            }
        }

		protected override SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                default: return null;
            }
        }

		public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
		{
			return visitor.VisitSkippedTokensTrivia(this, argument);
		}

		public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSkippedTokensTrivia(this);
        }

        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitSkippedTokensTrivia(this);
        }

        public CompilerSkippedTokensTriviaSyntax Update(SyntaxTokenList tokens)
        {
            if (tokens != this.Tokens)
            {
                var newNode = (CompilerSkippedTokensTriviaSyntax)Language.SyntaxFactory.SkippedTokensTrivia(tokens);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    return newNode.WithAnnotations(annotations);
                return newNode;
            }
            return this;
        }

        public CompilerSkippedTokensTriviaSyntax WithTokens(SyntaxTokenList tokens)
        {
            return this.Update(tokens);
        }

        public CompilerSkippedTokensTriviaSyntax AddTokens(params SyntaxToken[] items)
        {
            return this.WithTokens(this.Tokens.AddRange(items));
        }
    }

	public sealed class MainSyntax : CompilerSyntaxNode, ICompilationUnitSyntax
	{
		private QualifierSyntax _name;
		private MetaDslx.CodeAnalysis.SyntaxNode _using;
		private DeclarationsSyntax _declarations;
	
	    public MainSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MainSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KNamespace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
				var greenToken = green.KNamespace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax Name => this.GetRed(ref this._name, 1);
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
				var greenToken = green.TSemicolon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	    public MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> Using 
		{ 
			get
			{
				var red = this.GetRed(ref this._using, 3);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax>(red);
				return default;
			} 
		}
	    public DeclarationsSyntax Declarations => this.GetRed(ref this._declarations, 4);
	    public SyntaxToken EndOfFileToken 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
				var greenToken = green.EndOfFileToken;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._name, 1);
				case 3: return this.GetRed(ref this._using, 3);
				case 4: return this.GetRed(ref this._declarations, 4);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._name;
				case 3: return this._using;
				case 4: return this._declarations;
				default: return null;
	        }
	    }
	
	    public MainSyntax WithKNamespace(SyntaxToken kNamespace)
		{
			return this.Update(kNamespace, this.Name, this.TSemicolon, this.Using, this.Declarations, this.EndOfFileToken);
		}
	
	    public MainSyntax WithName(QualifierSyntax name)
		{
			return this.Update(this.KNamespace, name, this.TSemicolon, this.Using, this.Declarations, this.EndOfFileToken);
		}
	
	    public MainSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.KNamespace, this.Name, tSemicolon, this.Using, this.Declarations, this.EndOfFileToken);
		}
	
	    public MainSyntax WithUsing(MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using)
		{
			return this.Update(this.KNamespace, this.Name, this.TSemicolon, @using, this.Declarations, this.EndOfFileToken);
		}
	
	    public MainSyntax AddUsing(params UsingSyntax[] @using)
		{
			return this.WithUsing(this.Using.AddRange(@using));
		}
	
	    public MainSyntax WithDeclarations(DeclarationsSyntax declarations)
		{
			return this.Update(this.KNamespace, this.Name, this.TSemicolon, this.Using, declarations, this.EndOfFileToken);
		}
	
	    public MainSyntax WithEndOfFileToken(SyntaxToken eof)
		{
			return this.Update(this.KNamespace, this.Name, this.TSemicolon, this.Using, this.Declarations, eof);
		}
	
	    public MainSyntax Update(SyntaxToken kNamespace, QualifierSyntax name, SyntaxToken tSemicolon, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations, SyntaxToken eof)
	    {
	        if (this.KNamespace != kNamespace || this.Name != name || this.TSemicolon != tSemicolon || this.Using != @using || this.Declarations != declarations || this.EndOfFileToken != eof)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Main(kNamespace, name, tSemicolon, @using, declarations, eof);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MainSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMain(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMain(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitMain(this);
	    }
	
	}
	public sealed class UsingSyntax : CompilerSyntaxNode
	{
		private QualifierSyntax _namespaces;
	
	    public UsingSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public UsingSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KUsing 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
				var greenToken = green.KUsing;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax Namespaces => this.GetRed(ref this._namespaces, 1);
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
				var greenToken = green.TSemicolon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._namespaces, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._namespaces;
				default: return null;
	        }
	    }
	
	    public UsingSyntax WithKUsing(SyntaxToken kUsing)
		{
			return this.Update(kUsing, this.Namespaces, this.TSemicolon);
		}
	
	    public UsingSyntax WithNamespaces(QualifierSyntax namespaces)
		{
			return this.Update(this.KUsing, namespaces, this.TSemicolon);
		}
	
	    public UsingSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.KUsing, this.Namespaces, tSemicolon);
		}
	
	    public UsingSyntax Update(SyntaxToken kUsing, QualifierSyntax namespaces, SyntaxToken tSemicolon)
	    {
	        if (this.KUsing != kUsing || this.Namespaces != namespaces || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Using(kUsing, namespaces, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (UsingSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitUsing(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitUsing(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitUsing(this);
	    }
	
	}
	public sealed class DeclarationsSyntax : CompilerSyntaxNode
	{
		private LanguageDeclarationSyntax _declarations;
		private MetaDslx.CodeAnalysis.SyntaxNode _declarations1;
	
	    public DeclarationsSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public DeclarationsSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public LanguageDeclarationSyntax Declarations => this.GetRed(ref this._declarations, 0);
	    public MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> Declarations1 
		{ 
			get
			{
				var red = this.GetRed(ref this._declarations1, 1);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax>(red);
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._declarations, 0);
				case 1: return this.GetRed(ref this._declarations1, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._declarations;
				case 1: return this._declarations1;
				default: return null;
	        }
	    }
	
	    public DeclarationsSyntax WithDeclarations(LanguageDeclarationSyntax declarations)
		{
			return this.Update(declarations, this.Declarations1);
		}
	
	    public DeclarationsSyntax WithDeclarations1(MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> declarations1)
		{
			return this.Update(this.Declarations, declarations1);
		}
	
	    public DeclarationsSyntax AddDeclarations1(params RuleSyntax[] declarations1)
		{
			return this.WithDeclarations1(this.Declarations1.AddRange(declarations1));
		}
	
	    public DeclarationsSyntax Update(LanguageDeclarationSyntax declarations, MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> declarations1)
	    {
	        if (this.Declarations != declarations || this.Declarations1 != declarations1)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Declarations(declarations, declarations1);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (DeclarationsSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitDeclarations(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitDeclarations(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitDeclarations(this);
	    }
	
	}
	public sealed class LanguageDeclarationSyntax : CompilerSyntaxNode
	{
		private NameSyntax _name;
		private GrammarSyntax _grammar;
	
	    public LanguageDeclarationSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LanguageDeclarationSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KLanguage 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LanguageDeclarationGreen)this.Green;
				var greenToken = green.KLanguage;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public NameSyntax Name => this.GetRed(ref this._name, 1);
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LanguageDeclarationGreen)this.Green;
				var greenToken = green.TSemicolon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	    public GrammarSyntax Grammar => this.GetRed(ref this._grammar, 3);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._name, 1);
				case 3: return this.GetRed(ref this._grammar, 3);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._name;
				case 3: return this._grammar;
				default: return null;
	        }
	    }
	
	    public LanguageDeclarationSyntax WithKLanguage(SyntaxToken kLanguage)
		{
			return this.Update(kLanguage, this.Name, this.TSemicolon, this.Grammar);
		}
	
	    public LanguageDeclarationSyntax WithName(NameSyntax name)
		{
			return this.Update(this.KLanguage, name, this.TSemicolon, this.Grammar);
		}
	
	    public LanguageDeclarationSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.KLanguage, this.Name, tSemicolon, this.Grammar);
		}
	
	    public LanguageDeclarationSyntax WithGrammar(GrammarSyntax grammar)
		{
			return this.Update(this.KLanguage, this.Name, this.TSemicolon, grammar);
		}
	
	    public LanguageDeclarationSyntax Update(SyntaxToken kLanguage, NameSyntax name, SyntaxToken tSemicolon, GrammarSyntax grammar)
	    {
	        if (this.KLanguage != kLanguage || this.Name != name || this.TSemicolon != tSemicolon || this.Grammar != grammar)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LanguageDeclaration(kLanguage, name, tSemicolon, grammar);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LanguageDeclarationSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLanguageDeclaration(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLanguageDeclaration(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLanguageDeclaration(this);
	    }
	
	}
	public sealed class GrammarSyntax : CompilerSyntaxNode
	{
		private GrammarBlock1Syntax _grammarBlock1;
	
	    public GrammarSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public GrammarSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public GrammarBlock1Syntax GrammarBlock1 => this.GetRed(ref this._grammarBlock1, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._grammarBlock1, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._grammarBlock1;
				default: return null;
	        }
	    }
	
	    public GrammarSyntax WithGrammarBlock1(GrammarBlock1Syntax grammarBlock1)
		{
			return this.Update(grammarBlock1);
		}
	
	    public GrammarSyntax Update(GrammarBlock1Syntax grammarBlock1)
	    {
	        if (this.GrammarBlock1 != grammarBlock1)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Grammar(grammarBlock1);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (GrammarSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitGrammar(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitGrammar(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitGrammar(this);
	    }
	
	}
	public abstract class RuleSyntax : CompilerSyntaxNode
	{
	    protected RuleSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected RuleSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ParserRuleSyntax : RuleSyntax
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _annotations1;
		private ParserRuleBlock1Syntax _parserRuleBlock1;
		private MetaDslx.CodeAnalysis.SyntaxNode _pAlternativeList;
	
	    public ParserRuleSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserRuleSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> Annotations1 
		{ 
			get
			{
				var red = this.GetRed(ref this._annotations1, 0);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax>(red);
				return default;
			} 
		}
	    public ParserRuleBlock1Syntax ParserRuleBlock1 => this.GetRed(ref this._parserRuleBlock1, 1);
	    public SyntaxToken TColon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserRuleGreen)this.Green;
				var greenToken = green.TColon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> PAlternativeList 
		{ 
			get
			{
				var red = this.GetRed(ref this._pAlternativeList, 3);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax>(red, this.GetChildIndex(3), reversed: false);
				}
				return default;
			} 
		}
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserRuleGreen)this.Green;
				var greenToken = green.TSemicolon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._annotations1, 0);
				case 1: return this.GetRed(ref this._parserRuleBlock1, 1);
				case 3: return this.GetRed(ref this._pAlternativeList, 3);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._annotations1;
				case 1: return this._parserRuleBlock1;
				case 3: return this._pAlternativeList;
				default: return null;
	        }
	    }
	
	    public ParserRuleSyntax WithAnnotations1(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
		{
			return this.Update(annotations1, this.ParserRuleBlock1, this.TColon, this.PAlternativeList, this.TSemicolon);
		}
	
	    public ParserRuleSyntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
		{
			return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
		}
	
	    public ParserRuleSyntax WithParserRuleBlock1(ParserRuleBlock1Syntax parserRuleBlock1)
		{
			return this.Update(this.Annotations1, parserRuleBlock1, this.TColon, this.PAlternativeList, this.TSemicolon);
		}
	
	    public ParserRuleSyntax WithTColon(SyntaxToken tColon)
		{
			return this.Update(this.Annotations1, this.ParserRuleBlock1, tColon, this.PAlternativeList, this.TSemicolon);
		}
	
	    public ParserRuleSyntax WithPAlternativeList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList)
		{
			return this.Update(this.Annotations1, this.ParserRuleBlock1, this.TColon, pAlternativeList, this.TSemicolon);
		}
	
	    public ParserRuleSyntax AddPAlternativeList(params PAlternativeSyntax[] pAlternativeList)
		{
			return this.WithPAlternativeList(this.PAlternativeList.AddRange(pAlternativeList));
		}
	
	    public ParserRuleSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.Annotations1, this.ParserRuleBlock1, this.TColon, this.PAlternativeList, tSemicolon);
		}
	
	    public ParserRuleSyntax Update(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, ParserRuleBlock1Syntax parserRuleBlock1, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList, SyntaxToken tSemicolon)
	    {
	        if (this.Annotations1 != annotations1 || this.ParserRuleBlock1 != parserRuleBlock1 || this.TColon != tColon || this.PAlternativeList != pAlternativeList || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserRule(annotations1, parserRuleBlock1, tColon, pAlternativeList, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserRule(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserRule(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserRule(this);
	    }
	
	}
	public sealed class PBlockSyntax : RuleSyntax
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _annotations1;
		private NameSyntax _name;
		private PBlockBlock1Syntax _pBlockBlock1;
		private MetaDslx.CodeAnalysis.SyntaxNode _pAlternativeList;
	
	    public PBlockSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PBlockSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> Annotations1 
		{ 
			get
			{
				var red = this.GetRed(ref this._annotations1, 0);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax>(red);
				return default;
			} 
		}
	    public SyntaxToken KBlock 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PBlockGreen)this.Green;
				var greenToken = green.KBlock;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public NameSyntax Name => this.GetRed(ref this._name, 2);
	    public PBlockBlock1Syntax PBlockBlock1 => this.GetRed(ref this._pBlockBlock1, 3);
	    public SyntaxToken TColon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PBlockGreen)this.Green;
				var greenToken = green.TColon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
			}
		}
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> PAlternativeList 
		{ 
			get
			{
				var red = this.GetRed(ref this._pAlternativeList, 5);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax>(red, this.GetChildIndex(5), reversed: false);
				}
				return default;
			} 
		}
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PBlockGreen)this.Green;
				var greenToken = green.TSemicolon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(6), this.GetChildIndex(6));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._annotations1, 0);
				case 2: return this.GetRed(ref this._name, 2);
				case 3: return this.GetRed(ref this._pBlockBlock1, 3);
				case 5: return this.GetRed(ref this._pAlternativeList, 5);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._annotations1;
				case 2: return this._name;
				case 3: return this._pBlockBlock1;
				case 5: return this._pAlternativeList;
				default: return null;
	        }
	    }
	
	    public PBlockSyntax WithAnnotations1(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
		{
			return this.Update(annotations1, this.KBlock, this.Name, this.PBlockBlock1, this.TColon, this.PAlternativeList, this.TSemicolon);
		}
	
	    public PBlockSyntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
		{
			return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
		}
	
	    public PBlockSyntax WithKBlock(SyntaxToken kBlock)
		{
			return this.Update(this.Annotations1, kBlock, this.Name, this.PBlockBlock1, this.TColon, this.PAlternativeList, this.TSemicolon);
		}
	
	    public PBlockSyntax WithName(NameSyntax name)
		{
			return this.Update(this.Annotations1, this.KBlock, name, this.PBlockBlock1, this.TColon, this.PAlternativeList, this.TSemicolon);
		}
	
	    public PBlockSyntax WithPBlockBlock1(PBlockBlock1Syntax pBlockBlock1)
		{
			return this.Update(this.Annotations1, this.KBlock, this.Name, pBlockBlock1, this.TColon, this.PAlternativeList, this.TSemicolon);
		}
	
	    public PBlockSyntax WithTColon(SyntaxToken tColon)
		{
			return this.Update(this.Annotations1, this.KBlock, this.Name, this.PBlockBlock1, tColon, this.PAlternativeList, this.TSemicolon);
		}
	
	    public PBlockSyntax WithPAlternativeList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList)
		{
			return this.Update(this.Annotations1, this.KBlock, this.Name, this.PBlockBlock1, this.TColon, pAlternativeList, this.TSemicolon);
		}
	
	    public PBlockSyntax AddPAlternativeList(params PAlternativeSyntax[] pAlternativeList)
		{
			return this.WithPAlternativeList(this.PAlternativeList.AddRange(pAlternativeList));
		}
	
	    public PBlockSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.Annotations1, this.KBlock, this.Name, this.PBlockBlock1, this.TColon, this.PAlternativeList, tSemicolon);
		}
	
	    public PBlockSyntax Update(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, SyntaxToken kBlock, NameSyntax name, PBlockBlock1Syntax pBlockBlock1, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList, SyntaxToken tSemicolon)
	    {
	        if (this.Annotations1 != annotations1 || this.KBlock != kBlock || this.Name != name || this.PBlockBlock1 != pBlockBlock1 || this.TColon != tColon || this.PAlternativeList != pAlternativeList || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PBlock(annotations1, kBlock, name, pBlockBlock1, tColon, pAlternativeList, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPBlock(this);
	    }
	
	}
	public sealed class LexerRuleSyntax : RuleSyntax
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _annotations1;
		private LexerRuleBlock1Syntax _lexerRuleBlock1;
		private MetaDslx.CodeAnalysis.SyntaxNode _lAlternativeList;
	
	    public LexerRuleSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LexerRuleSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> Annotations1 
		{ 
			get
			{
				var red = this.GetRed(ref this._annotations1, 0);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax>(red);
				return default;
			} 
		}
	    public LexerRuleBlock1Syntax LexerRuleBlock1 => this.GetRed(ref this._lexerRuleBlock1, 1);
	    public SyntaxToken TColon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerRuleGreen)this.Green;
				var greenToken = green.TColon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> LAlternativeList 
		{ 
			get
			{
				var red = this.GetRed(ref this._lAlternativeList, 3);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax>(red, this.GetChildIndex(3), reversed: false);
				}
				return default;
			} 
		}
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerRuleGreen)this.Green;
				var greenToken = green.TSemicolon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._annotations1, 0);
				case 1: return this.GetRed(ref this._lexerRuleBlock1, 1);
				case 3: return this.GetRed(ref this._lAlternativeList, 3);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._annotations1;
				case 1: return this._lexerRuleBlock1;
				case 3: return this._lAlternativeList;
				default: return null;
	        }
	    }
	
	    public LexerRuleSyntax WithAnnotations1(MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1)
		{
			return this.Update(annotations1, this.LexerRuleBlock1, this.TColon, this.LAlternativeList, this.TSemicolon);
		}
	
	    public LexerRuleSyntax AddAnnotations1(params LexerAnnotationSyntax[] annotations1)
		{
			return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
		}
	
	    public LexerRuleSyntax WithLexerRuleBlock1(LexerRuleBlock1Syntax lexerRuleBlock1)
		{
			return this.Update(this.Annotations1, lexerRuleBlock1, this.TColon, this.LAlternativeList, this.TSemicolon);
		}
	
	    public LexerRuleSyntax WithTColon(SyntaxToken tColon)
		{
			return this.Update(this.Annotations1, this.LexerRuleBlock1, tColon, this.LAlternativeList, this.TSemicolon);
		}
	
	    public LexerRuleSyntax WithLAlternativeList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList)
		{
			return this.Update(this.Annotations1, this.LexerRuleBlock1, this.TColon, lAlternativeList, this.TSemicolon);
		}
	
	    public LexerRuleSyntax AddLAlternativeList(params LAlternativeSyntax[] lAlternativeList)
		{
			return this.WithLAlternativeList(this.LAlternativeList.AddRange(lAlternativeList));
		}
	
	    public LexerRuleSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.Annotations1, this.LexerRuleBlock1, this.TColon, this.LAlternativeList, tSemicolon);
		}
	
	    public LexerRuleSyntax Update(MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, LexerRuleBlock1Syntax lexerRuleBlock1, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList, SyntaxToken tSemicolon)
	    {
	        if (this.Annotations1 != annotations1 || this.LexerRuleBlock1 != lexerRuleBlock1 || this.TColon != tColon || this.LAlternativeList != lAlternativeList || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerRule(annotations1, lexerRuleBlock1, tColon, lAlternativeList, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLexerRule(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLexerRule(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLexerRule(this);
	    }
	
	}
	public sealed class PAlternativeSyntax : CompilerSyntaxNode
	{
		private PAlternativeBlock1Syntax _pAlternativeBlock1;
		private MetaDslx.CodeAnalysis.SyntaxNode _elements;
		private PAlternativeBlock2Syntax _pAlternativeBlock2;
	
	    public PAlternativeSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PAlternativeSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public PAlternativeBlock1Syntax PAlternativeBlock1 => this.GetRed(ref this._pAlternativeBlock1, 0);
	    public MetaDslx.CodeAnalysis.SyntaxList<PElementSyntax> Elements 
		{ 
			get
			{
				var red = this.GetRed(ref this._elements, 1);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<PElementSyntax>(red);
				return default;
			} 
		}
	    public PAlternativeBlock2Syntax PAlternativeBlock2 => this.GetRed(ref this._pAlternativeBlock2, 2);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._pAlternativeBlock1, 0);
				case 1: return this.GetRed(ref this._elements, 1);
				case 2: return this.GetRed(ref this._pAlternativeBlock2, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._pAlternativeBlock1;
				case 1: return this._elements;
				case 2: return this._pAlternativeBlock2;
				default: return null;
	        }
	    }
	
	    public PAlternativeSyntax WithPAlternativeBlock1(PAlternativeBlock1Syntax pAlternativeBlock1)
		{
			return this.Update(pAlternativeBlock1, this.Elements, this.PAlternativeBlock2);
		}
	
	    public PAlternativeSyntax WithElements(MetaDslx.CodeAnalysis.SyntaxList<PElementSyntax> elements)
		{
			return this.Update(this.PAlternativeBlock1, elements, this.PAlternativeBlock2);
		}
	
	    public PAlternativeSyntax AddElements(params PElementSyntax[] elements)
		{
			return this.WithElements(this.Elements.AddRange(elements));
		}
	
	    public PAlternativeSyntax WithPAlternativeBlock2(PAlternativeBlock2Syntax pAlternativeBlock2)
		{
			return this.Update(this.PAlternativeBlock1, this.Elements, pAlternativeBlock2);
		}
	
	    public PAlternativeSyntax Update(PAlternativeBlock1Syntax pAlternativeBlock1, MetaDslx.CodeAnalysis.SyntaxList<PElementSyntax> elements, PAlternativeBlock2Syntax pAlternativeBlock2)
	    {
	        if (this.PAlternativeBlock1 != pAlternativeBlock1 || this.Elements != elements || this.PAlternativeBlock2 != pAlternativeBlock2)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PAlternative(pAlternativeBlock1, elements, pAlternativeBlock2);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PAlternativeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPAlternative(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPAlternative(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPAlternative(this);
	    }
	
	}
	public sealed class PElementSyntax : CompilerSyntaxNode
	{
		private PElementBlock1Syntax _pElementBlock1;
		private MetaDslx.CodeAnalysis.SyntaxNode _valueAnnotations;
		private PElementValueSyntax _value;
	
	    public PElementSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PElementSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public PElementBlock1Syntax PElementBlock1 => this.GetRed(ref this._pElementBlock1, 0);
	    public MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> ValueAnnotations 
		{ 
			get
			{
				var red = this.GetRed(ref this._valueAnnotations, 1);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax>(red);
				return default;
			} 
		}
	    public PElementValueSyntax Value => this.GetRed(ref this._value, 2);
	    public SyntaxToken Multiplicity 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PElementGreen)this.Green;
				var greenToken = green.Multiplicity;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._pElementBlock1, 0);
				case 1: return this.GetRed(ref this._valueAnnotations, 1);
				case 2: return this.GetRed(ref this._value, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._pElementBlock1;
				case 1: return this._valueAnnotations;
				case 2: return this._value;
				default: return null;
	        }
	    }
	
	    public PElementSyntax WithPElementBlock1(PElementBlock1Syntax pElementBlock1)
		{
			return this.Update(pElementBlock1, this.ValueAnnotations, this.Value, this.Multiplicity);
		}
	
	    public PElementSyntax WithValueAnnotations(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> valueAnnotations)
		{
			return this.Update(this.PElementBlock1, valueAnnotations, this.Value, this.Multiplicity);
		}
	
	    public PElementSyntax AddValueAnnotations(params ParserAnnotationSyntax[] valueAnnotations)
		{
			return this.WithValueAnnotations(this.ValueAnnotations.AddRange(valueAnnotations));
		}
	
	    public PElementSyntax WithValue(PElementValueSyntax value)
		{
			return this.Update(this.PElementBlock1, this.ValueAnnotations, value, this.Multiplicity);
		}
	
	    public PElementSyntax WithMultiplicity(SyntaxToken multiplicity)
		{
			return this.Update(this.PElementBlock1, this.ValueAnnotations, this.Value, multiplicity);
		}
	
	    public PElementSyntax Update(PElementBlock1Syntax pElementBlock1, MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> valueAnnotations, PElementValueSyntax value, SyntaxToken multiplicity)
	    {
	        if (this.PElementBlock1 != pElementBlock1 || this.ValueAnnotations != valueAnnotations || this.Value != value || this.Multiplicity != multiplicity)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PElement(pElementBlock1, valueAnnotations, value, multiplicity);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PElementSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPElement(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPElement(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPElement(this);
	    }
	
	}
	public abstract class PElementValueSyntax : CompilerSyntaxNode
	{
	    protected PElementValueSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected PElementValueSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class PBlockInlineSyntax : PElementValueSyntax
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _pAlternativeList;
	
	    public PBlockInlineSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PBlockInlineSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TLParen 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PBlockInlineGreen)this.Green;
				var greenToken = green.TLParen;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> PAlternativeList 
		{ 
			get
			{
				var red = this.GetRed(ref this._pAlternativeList, 1);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax>(red, this.GetChildIndex(1), reversed: false);
				}
				return default;
			} 
		}
	    public SyntaxToken TRParen 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PBlockInlineGreen)this.Green;
				var greenToken = green.TRParen;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._pAlternativeList, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._pAlternativeList;
				default: return null;
	        }
	    }
	
	    public PBlockInlineSyntax WithTLParen(SyntaxToken tLParen)
		{
			return this.Update(tLParen, this.PAlternativeList, this.TRParen);
		}
	
	    public PBlockInlineSyntax WithPAlternativeList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList)
		{
			return this.Update(this.TLParen, pAlternativeList, this.TRParen);
		}
	
	    public PBlockInlineSyntax AddPAlternativeList(params PAlternativeSyntax[] pAlternativeList)
		{
			return this.WithPAlternativeList(this.PAlternativeList.AddRange(pAlternativeList));
		}
	
	    public PBlockInlineSyntax WithTRParen(SyntaxToken tRParen)
		{
			return this.Update(this.TLParen, this.PAlternativeList, tRParen);
		}
	
	    public PBlockInlineSyntax Update(SyntaxToken tLParen, MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList, SyntaxToken tRParen)
	    {
	        if (this.TLParen != tLParen || this.PAlternativeList != pAlternativeList || this.TRParen != tRParen)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PBlockInline(tLParen, pAlternativeList, tRParen);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PBlockInlineSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPBlockInline(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPBlockInline(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPBlockInline(this);
	    }
	
	}
	public sealed class PEofSyntax : PElementValueSyntax
	{
	
	    public PEofSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PEofSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KEof 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PEofGreen)this.Green;
				var greenToken = green.KEof;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public PEofSyntax WithKEof(SyntaxToken kEof)
		{
			return this.Update(kEof);
		}
	
	    public PEofSyntax Update(SyntaxToken kEof)
	    {
	        if (this.KEof != kEof)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PEof(kEof);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PEofSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPEof(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPEof(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPEof(this);
	    }
	
	}
	public sealed class PKeywordSyntax : PElementValueSyntax
	{
	
	    public PKeywordSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PKeywordSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken Text 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PKeywordGreen)this.Green;
				var greenToken = green.Text;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public PKeywordSyntax WithText(SyntaxToken text)
		{
			return this.Update(text);
		}
	
	    public PKeywordSyntax Update(SyntaxToken text)
	    {
	        if (this.Text != text)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PKeyword(text);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PKeywordSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPKeyword(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPKeyword(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPKeyword(this);
	    }
	
	}
	public sealed class PReferenceAlt1Syntax : PElementValueSyntax
	{
		private IdentifierSyntax _rule;
	
	    public PReferenceAlt1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PReferenceAlt1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public IdentifierSyntax Rule => this.GetRed(ref this._rule, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._rule, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._rule;
				default: return null;
	        }
	    }
	
	    public PReferenceAlt1Syntax WithRule(IdentifierSyntax rule)
		{
			return this.Update(rule);
		}
	
	    public PReferenceAlt1Syntax Update(IdentifierSyntax rule)
	    {
	        if (this.Rule != rule)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PReferenceAlt1(rule);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PReferenceAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPReferenceAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPReferenceAlt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPReferenceAlt1(this);
	    }
	
	}
	public sealed class PReferenceAlt2Syntax : PElementValueSyntax
	{
		private ReturnTypeQualifierSyntax _referencedTypes;
	
	    public PReferenceAlt2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PReferenceAlt2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken THash 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PReferenceAlt2Green)this.Green;
				var greenToken = green.THash;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public ReturnTypeQualifierSyntax ReferencedTypes => this.GetRed(ref this._referencedTypes, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._referencedTypes, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._referencedTypes;
				default: return null;
	        }
	    }
	
	    public PReferenceAlt2Syntax WithTHash(SyntaxToken tHash)
		{
			return this.Update(tHash, this.ReferencedTypes);
		}
	
	    public PReferenceAlt2Syntax WithReferencedTypes(ReturnTypeQualifierSyntax referencedTypes)
		{
			return this.Update(this.THash, referencedTypes);
		}
	
	    public PReferenceAlt2Syntax Update(SyntaxToken tHash, ReturnTypeQualifierSyntax referencedTypes)
	    {
	        if (this.THash != tHash || this.ReferencedTypes != referencedTypes)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PReferenceAlt2(tHash, referencedTypes);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PReferenceAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPReferenceAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPReferenceAlt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPReferenceAlt2(this);
	    }
	
	}
	public sealed class PReferenceAlt3Syntax : PElementValueSyntax
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _returnTypeQualifierList;
	
	    public PReferenceAlt3Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PReferenceAlt3Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken THashLBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PReferenceAlt3Green)this.Green;
				var greenToken = green.THashLBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> ReturnTypeQualifierList 
		{ 
			get
			{
				var red = this.GetRed(ref this._returnTypeQualifierList, 1);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
				}
				return default;
			} 
		}
	    public SyntaxToken TRBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PReferenceAlt3Green)this.Green;
				var greenToken = green.TRBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._returnTypeQualifierList, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._returnTypeQualifierList;
				default: return null;
	        }
	    }
	
	    public PReferenceAlt3Syntax WithTHashLBrace(SyntaxToken tHashLBrace)
		{
			return this.Update(tHashLBrace, this.ReturnTypeQualifierList, this.TRBrace);
		}
	
	    public PReferenceAlt3Syntax WithReturnTypeQualifierList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> returnTypeQualifierList)
		{
			return this.Update(this.THashLBrace, returnTypeQualifierList, this.TRBrace);
		}
	
	    public PReferenceAlt3Syntax AddReturnTypeQualifierList(params ReturnTypeQualifierSyntax[] returnTypeQualifierList)
		{
			return this.WithReturnTypeQualifierList(this.ReturnTypeQualifierList.AddRange(returnTypeQualifierList));
		}
	
	    public PReferenceAlt3Syntax WithTRBrace(SyntaxToken tRBrace)
		{
			return this.Update(this.THashLBrace, this.ReturnTypeQualifierList, tRBrace);
		}
	
	    public PReferenceAlt3Syntax Update(SyntaxToken tHashLBrace, MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> returnTypeQualifierList, SyntaxToken tRBrace)
	    {
	        if (this.THashLBrace != tHashLBrace || this.ReturnTypeQualifierList != returnTypeQualifierList || this.TRBrace != tRBrace)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PReferenceAlt3(tHashLBrace, returnTypeQualifierList, tRBrace);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PReferenceAlt3Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPReferenceAlt3(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPReferenceAlt3(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPReferenceAlt3(this);
	    }
	
	}
	public sealed class LAlternativeSyntax : CompilerSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _elements;
	
	    public LAlternativeSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LAlternativeSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax> Elements 
		{ 
			get
			{
				var red = this.GetRed(ref this._elements, 0);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax>(red);
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._elements, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._elements;
				default: return null;
	        }
	    }
	
	    public LAlternativeSyntax WithElements(MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax> elements)
		{
			return this.Update(elements);
		}
	
	    public LAlternativeSyntax AddElements(params LElementSyntax[] elements)
		{
			return this.WithElements(this.Elements.AddRange(elements));
		}
	
	    public LAlternativeSyntax Update(MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax> elements)
	    {
	        if (this.Elements != elements)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LAlternative(elements);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LAlternativeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLAlternative(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLAlternative(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLAlternative(this);
	    }
	
	}
	public sealed class LElementSyntax : CompilerSyntaxNode
	{
		private LElementValueSyntax _value;
	
	    public LElementSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LElementSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken IsNegated 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LElementGreen)this.Green;
				var greenToken = green.IsNegated;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public LElementValueSyntax Value => this.GetRed(ref this._value, 1);
	    public SyntaxToken Multiplicity 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LElementGreen)this.Green;
				var greenToken = green.Multiplicity;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._value, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._value;
				default: return null;
	        }
	    }
	
	    public LElementSyntax WithIsNegated(SyntaxToken isNegated)
		{
			return this.Update(isNegated, this.Value, this.Multiplicity);
		}
	
	    public LElementSyntax WithValue(LElementValueSyntax value)
		{
			return this.Update(this.IsNegated, value, this.Multiplicity);
		}
	
	    public LElementSyntax WithMultiplicity(SyntaxToken multiplicity)
		{
			return this.Update(this.IsNegated, this.Value, multiplicity);
		}
	
	    public LElementSyntax Update(SyntaxToken isNegated, LElementValueSyntax value, SyntaxToken multiplicity)
	    {
	        if (this.IsNegated != isNegated || this.Value != value || this.Multiplicity != multiplicity)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LElement(isNegated, value, multiplicity);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LElementSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLElement(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLElement(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLElement(this);
	    }
	
	}
	public abstract class LElementValueSyntax : CompilerSyntaxNode
	{
	    protected LElementValueSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected LElementValueSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class LBlockSyntax : LElementValueSyntax
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _lAlternativeList;
	
	    public LBlockSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LBlockSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TLParen 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LBlockGreen)this.Green;
				var greenToken = green.TLParen;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> LAlternativeList 
		{ 
			get
			{
				var red = this.GetRed(ref this._lAlternativeList, 1);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax>(red, this.GetChildIndex(1), reversed: false);
				}
				return default;
			} 
		}
	    public SyntaxToken TRParen 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LBlockGreen)this.Green;
				var greenToken = green.TRParen;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._lAlternativeList, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._lAlternativeList;
				default: return null;
	        }
	    }
	
	    public LBlockSyntax WithTLParen(SyntaxToken tLParen)
		{
			return this.Update(tLParen, this.LAlternativeList, this.TRParen);
		}
	
	    public LBlockSyntax WithLAlternativeList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList)
		{
			return this.Update(this.TLParen, lAlternativeList, this.TRParen);
		}
	
	    public LBlockSyntax AddLAlternativeList(params LAlternativeSyntax[] lAlternativeList)
		{
			return this.WithLAlternativeList(this.LAlternativeList.AddRange(lAlternativeList));
		}
	
	    public LBlockSyntax WithTRParen(SyntaxToken tRParen)
		{
			return this.Update(this.TLParen, this.LAlternativeList, tRParen);
		}
	
	    public LBlockSyntax Update(SyntaxToken tLParen, MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList, SyntaxToken tRParen)
	    {
	        if (this.TLParen != tLParen || this.LAlternativeList != lAlternativeList || this.TRParen != tRParen)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LBlock(tLParen, lAlternativeList, tRParen);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLBlock(this);
	    }
	
	}
	public sealed class LFixedSyntax : LElementValueSyntax
	{
	
	    public LFixedSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LFixedSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken Text 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LFixedGreen)this.Green;
				var greenToken = green.Text;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public LFixedSyntax WithText(SyntaxToken text)
		{
			return this.Update(text);
		}
	
	    public LFixedSyntax Update(SyntaxToken text)
	    {
	        if (this.Text != text)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LFixed(text);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LFixedSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLFixed(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLFixed(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLFixed(this);
	    }
	
	}
	public sealed class LWildCardSyntax : LElementValueSyntax
	{
	
	    public LWildCardSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LWildCardSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TDot 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LWildCardGreen)this.Green;
				var greenToken = green.TDot;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public LWildCardSyntax WithTDot(SyntaxToken tDot)
		{
			return this.Update(tDot);
		}
	
	    public LWildCardSyntax Update(SyntaxToken tDot)
	    {
	        if (this.TDot != tDot)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LWildCard(tDot);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LWildCardSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLWildCard(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLWildCard(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLWildCard(this);
	    }
	
	}
	public sealed class LRangeSyntax : LElementValueSyntax
	{
	
	    public LRangeSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LRangeSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken StartChar 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LRangeGreen)this.Green;
				var greenToken = green.StartChar;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public SyntaxToken TDotDot 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LRangeGreen)this.Green;
				var greenToken = green.TDotDot;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public SyntaxToken EndChar 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LRangeGreen)this.Green;
				var greenToken = green.EndChar;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public LRangeSyntax WithStartChar(SyntaxToken startChar)
		{
			return this.Update(startChar, this.TDotDot, this.EndChar);
		}
	
	    public LRangeSyntax WithTDotDot(SyntaxToken tDotDot)
		{
			return this.Update(this.StartChar, tDotDot, this.EndChar);
		}
	
	    public LRangeSyntax WithEndChar(SyntaxToken endChar)
		{
			return this.Update(this.StartChar, this.TDotDot, endChar);
		}
	
	    public LRangeSyntax Update(SyntaxToken startChar, SyntaxToken tDotDot, SyntaxToken endChar)
	    {
	        if (this.StartChar != startChar || this.TDotDot != tDotDot || this.EndChar != endChar)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LRange(startChar, tDotDot, endChar);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LRangeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLRange(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLRange(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLRange(this);
	    }
	
	}
	public sealed class LReferenceSyntax : LElementValueSyntax
	{
		private IdentifierSyntax _rule;
	
	    public LReferenceSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LReferenceSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public IdentifierSyntax Rule => this.GetRed(ref this._rule, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._rule, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._rule;
				default: return null;
	        }
	    }
	
	    public LReferenceSyntax WithRule(IdentifierSyntax rule)
		{
			return this.Update(rule);
		}
	
	    public LReferenceSyntax Update(IdentifierSyntax rule)
	    {
	        if (this.Rule != rule)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LReference(rule);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LReferenceSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLReference(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLReference(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLReference(this);
	    }
	
	}
	public abstract class ExpressionSyntax : CompilerSyntaxNode
	{
	    protected ExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ExpressionAlt1Syntax : ExpressionSyntax
	{
		private SingleExpressionSyntax _singleExpression;
	
	    public ExpressionAlt1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ExpressionAlt1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SingleExpressionSyntax SingleExpression => this.GetRed(ref this._singleExpression, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._singleExpression, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._singleExpression;
				default: return null;
	        }
	    }
	
	    public ExpressionAlt1Syntax WithSingleExpression(SingleExpressionSyntax singleExpression)
		{
			return this.Update(singleExpression);
		}
	
	    public ExpressionAlt1Syntax Update(SingleExpressionSyntax singleExpression)
	    {
	        if (this.SingleExpression != singleExpression)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ExpressionAlt1(singleExpression);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ExpressionAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitExpressionAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitExpressionAlt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitExpressionAlt1(this);
	    }
	
	}
	public sealed class ArrayExpressionSyntax : ExpressionSyntax
	{
		private ArrayExpressionBlock1Syntax _arrayExpressionBlock1;
	
	    public ArrayExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ArrayExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TLBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ArrayExpressionGreen)this.Green;
				var greenToken = green.TLBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public ArrayExpressionBlock1Syntax ArrayExpressionBlock1 => this.GetRed(ref this._arrayExpressionBlock1, 1);
	    public SyntaxToken TRBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ArrayExpressionGreen)this.Green;
				var greenToken = green.TRBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._arrayExpressionBlock1, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._arrayExpressionBlock1;
				default: return null;
	        }
	    }
	
	    public ArrayExpressionSyntax WithTLBrace(SyntaxToken tLBrace)
		{
			return this.Update(tLBrace, this.ArrayExpressionBlock1, this.TRBrace);
		}
	
	    public ArrayExpressionSyntax WithArrayExpressionBlock1(ArrayExpressionBlock1Syntax arrayExpressionBlock1)
		{
			return this.Update(this.TLBrace, arrayExpressionBlock1, this.TRBrace);
		}
	
	    public ArrayExpressionSyntax WithTRBrace(SyntaxToken tRBrace)
		{
			return this.Update(this.TLBrace, this.ArrayExpressionBlock1, tRBrace);
		}
	
	    public ArrayExpressionSyntax Update(SyntaxToken tLBrace, ArrayExpressionBlock1Syntax arrayExpressionBlock1, SyntaxToken tRBrace)
	    {
	        if (this.TLBrace != tLBrace || this.ArrayExpressionBlock1 != arrayExpressionBlock1 || this.TRBrace != tRBrace)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ArrayExpression(tLBrace, arrayExpressionBlock1, tRBrace);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ArrayExpressionSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitArrayExpression(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitArrayExpression(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitArrayExpression(this);
	    }
	
	}
	public sealed class SingleExpressionSyntax : CompilerSyntaxNode
	{
		private SingleExpressionBlock1Syntax _value;
	
	    public SingleExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SingleExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SingleExpressionBlock1Syntax Value => this.GetRed(ref this._value, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._value, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._value;
				default: return null;
	        }
	    }
	
	    public SingleExpressionSyntax WithValue(SingleExpressionBlock1Syntax value)
		{
			return this.Update(value);
		}
	
	    public SingleExpressionSyntax Update(SingleExpressionBlock1Syntax value)
	    {
	        if (this.Value != value)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpression(value);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (SingleExpressionSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSingleExpression(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSingleExpression(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitSingleExpression(this);
	    }
	
	}
	public sealed class ParserAnnotationSyntax : CompilerSyntaxNode
	{
		private QualifierSyntax _attributeClass;
		private AnnotationArgumentsSyntax _annotationArguments;
	
	    public ParserAnnotationSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserAnnotationSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TLBracket 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationGreen)this.Green;
				var greenToken = green.TLBracket;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax AttributeClass => this.GetRed(ref this._attributeClass, 1);
	    public AnnotationArgumentsSyntax AnnotationArguments => this.GetRed(ref this._annotationArguments, 2);
	    public SyntaxToken TRBracket 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationGreen)this.Green;
				var greenToken = green.TRBracket;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._attributeClass, 1);
				case 2: return this.GetRed(ref this._annotationArguments, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._attributeClass;
				case 2: return this._annotationArguments;
				default: return null;
	        }
	    }
	
	    public ParserAnnotationSyntax WithTLBracket(SyntaxToken tLBracket)
		{
			return this.Update(tLBracket, this.AttributeClass, this.AnnotationArguments, this.TRBracket);
		}
	
	    public ParserAnnotationSyntax WithAttributeClass(QualifierSyntax attributeClass)
		{
			return this.Update(this.TLBracket, attributeClass, this.AnnotationArguments, this.TRBracket);
		}
	
	    public ParserAnnotationSyntax WithAnnotationArguments(AnnotationArgumentsSyntax annotationArguments)
		{
			return this.Update(this.TLBracket, this.AttributeClass, annotationArguments, this.TRBracket);
		}
	
	    public ParserAnnotationSyntax WithTRBracket(SyntaxToken tRBracket)
		{
			return this.Update(this.TLBracket, this.AttributeClass, this.AnnotationArguments, tRBracket);
		}
	
	    public ParserAnnotationSyntax Update(SyntaxToken tLBracket, QualifierSyntax attributeClass, AnnotationArgumentsSyntax annotationArguments, SyntaxToken tRBracket)
	    {
	        if (this.TLBracket != tLBracket || this.AttributeClass != attributeClass || this.AnnotationArguments != annotationArguments || this.TRBracket != tRBracket)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserAnnotation(tLBracket, attributeClass, annotationArguments, tRBracket);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParserAnnotationSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserAnnotation(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserAnnotation(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserAnnotation(this);
	    }
	
	}
	public sealed class LexerAnnotationSyntax : CompilerSyntaxNode
	{
		private QualifierSyntax _attributeClass;
		private AnnotationArgumentsSyntax _annotationArguments;
	
	    public LexerAnnotationSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LexerAnnotationSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TLBracket 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationGreen)this.Green;
				var greenToken = green.TLBracket;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax AttributeClass => this.GetRed(ref this._attributeClass, 1);
	    public AnnotationArgumentsSyntax AnnotationArguments => this.GetRed(ref this._annotationArguments, 2);
	    public SyntaxToken TRBracket 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationGreen)this.Green;
				var greenToken = green.TRBracket;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._attributeClass, 1);
				case 2: return this.GetRed(ref this._annotationArguments, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._attributeClass;
				case 2: return this._annotationArguments;
				default: return null;
	        }
	    }
	
	    public LexerAnnotationSyntax WithTLBracket(SyntaxToken tLBracket)
		{
			return this.Update(tLBracket, this.AttributeClass, this.AnnotationArguments, this.TRBracket);
		}
	
	    public LexerAnnotationSyntax WithAttributeClass(QualifierSyntax attributeClass)
		{
			return this.Update(this.TLBracket, attributeClass, this.AnnotationArguments, this.TRBracket);
		}
	
	    public LexerAnnotationSyntax WithAnnotationArguments(AnnotationArgumentsSyntax annotationArguments)
		{
			return this.Update(this.TLBracket, this.AttributeClass, annotationArguments, this.TRBracket);
		}
	
	    public LexerAnnotationSyntax WithTRBracket(SyntaxToken tRBracket)
		{
			return this.Update(this.TLBracket, this.AttributeClass, this.AnnotationArguments, tRBracket);
		}
	
	    public LexerAnnotationSyntax Update(SyntaxToken tLBracket, QualifierSyntax attributeClass, AnnotationArgumentsSyntax annotationArguments, SyntaxToken tRBracket)
	    {
	        if (this.TLBracket != tLBracket || this.AttributeClass != attributeClass || this.AnnotationArguments != annotationArguments || this.TRBracket != tRBracket)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerAnnotation(tLBracket, attributeClass, annotationArguments, tRBracket);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LexerAnnotationSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLexerAnnotation(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLexerAnnotation(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLexerAnnotation(this);
	    }
	
	}
	public sealed class AnnotationArgumentsSyntax : CompilerSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _annotationArgumentList;
	
	    public AnnotationArgumentsSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AnnotationArgumentsSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TLParen 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AnnotationArgumentsGreen)this.Green;
				var greenToken = green.TLParen;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> AnnotationArgumentList 
		{ 
			get
			{
				var red = this.GetRed(ref this._annotationArgumentList, 1);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax>(red, this.GetChildIndex(1), reversed: false);
				}
				return default;
			} 
		}
	    public SyntaxToken TRParen 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AnnotationArgumentsGreen)this.Green;
				var greenToken = green.TRParen;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._annotationArgumentList, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._annotationArgumentList;
				default: return null;
	        }
	    }
	
	    public AnnotationArgumentsSyntax WithTLParen(SyntaxToken tLParen)
		{
			return this.Update(tLParen, this.AnnotationArgumentList, this.TRParen);
		}
	
	    public AnnotationArgumentsSyntax WithAnnotationArgumentList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> annotationArgumentList)
		{
			return this.Update(this.TLParen, annotationArgumentList, this.TRParen);
		}
	
	    public AnnotationArgumentsSyntax AddAnnotationArgumentList(params AnnotationArgumentSyntax[] annotationArgumentList)
		{
			return this.WithAnnotationArgumentList(this.AnnotationArgumentList.AddRange(annotationArgumentList));
		}
	
	    public AnnotationArgumentsSyntax WithTRParen(SyntaxToken tRParen)
		{
			return this.Update(this.TLParen, this.AnnotationArgumentList, tRParen);
		}
	
	    public AnnotationArgumentsSyntax Update(SyntaxToken tLParen, MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> annotationArgumentList, SyntaxToken tRParen)
	    {
	        if (this.TLParen != tLParen || this.AnnotationArgumentList != annotationArgumentList || this.TRParen != tRParen)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.AnnotationArguments(tLParen, annotationArgumentList, tRParen);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (AnnotationArgumentsSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitAnnotationArguments(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitAnnotationArguments(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitAnnotationArguments(this);
	    }
	
	}
	public sealed class AnnotationArgumentSyntax : CompilerSyntaxNode
	{
		private AnnotationArgumentBlock1Syntax _annotationArgumentBlock1;
		private ExpressionSyntax _value;
	
	    public AnnotationArgumentSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AnnotationArgumentSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public AnnotationArgumentBlock1Syntax AnnotationArgumentBlock1 => this.GetRed(ref this._annotationArgumentBlock1, 0);
	    public ExpressionSyntax Value => this.GetRed(ref this._value, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._annotationArgumentBlock1, 0);
				case 1: return this.GetRed(ref this._value, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._annotationArgumentBlock1;
				case 1: return this._value;
				default: return null;
	        }
	    }
	
	    public AnnotationArgumentSyntax WithAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax annotationArgumentBlock1)
		{
			return this.Update(annotationArgumentBlock1, this.Value);
		}
	
	    public AnnotationArgumentSyntax WithValue(ExpressionSyntax value)
		{
			return this.Update(this.AnnotationArgumentBlock1, value);
		}
	
	    public AnnotationArgumentSyntax Update(AnnotationArgumentBlock1Syntax annotationArgumentBlock1, ExpressionSyntax value)
	    {
	        if (this.AnnotationArgumentBlock1 != annotationArgumentBlock1 || this.Value != value)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.AnnotationArgument(annotationArgumentBlock1, value);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (AnnotationArgumentSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitAnnotationArgument(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitAnnotationArgument(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitAnnotationArgument(this);
	    }
	
	}
	public abstract class ReturnTypeIdentifierSyntax : CompilerSyntaxNode
	{
	    protected ReturnTypeIdentifierSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ReturnTypeIdentifierSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ReturnTypeIdentifierAlt1Syntax : ReturnTypeIdentifierSyntax
	{
	
	    public ReturnTypeIdentifierAlt1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ReturnTypeIdentifierAlt1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TPrimitiveType 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ReturnTypeIdentifierAlt1Green)this.Green;
				var greenToken = green.TPrimitiveType;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public ReturnTypeIdentifierAlt1Syntax WithTPrimitiveType(SyntaxToken tPrimitiveType)
		{
			return this.Update(tPrimitiveType);
		}
	
	    public ReturnTypeIdentifierAlt1Syntax Update(SyntaxToken tPrimitiveType)
	    {
	        if (this.TPrimitiveType != tPrimitiveType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ReturnTypeIdentifierAlt1(tPrimitiveType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ReturnTypeIdentifierAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitReturnTypeIdentifierAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitReturnTypeIdentifierAlt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitReturnTypeIdentifierAlt1(this);
	    }
	
	}
	public sealed class ReturnTypeIdentifierAlt2Syntax : ReturnTypeIdentifierSyntax
	{
		private IdentifierSyntax _identifier;
	
	    public ReturnTypeIdentifierAlt2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ReturnTypeIdentifierAlt2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public IdentifierSyntax Identifier => this.GetRed(ref this._identifier, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._identifier, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._identifier;
				default: return null;
	        }
	    }
	
	    public ReturnTypeIdentifierAlt2Syntax WithIdentifier(IdentifierSyntax identifier)
		{
			return this.Update(identifier);
		}
	
	    public ReturnTypeIdentifierAlt2Syntax Update(IdentifierSyntax identifier)
	    {
	        if (this.Identifier != identifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ReturnTypeIdentifierAlt2(identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ReturnTypeIdentifierAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitReturnTypeIdentifierAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitReturnTypeIdentifierAlt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitReturnTypeIdentifierAlt2(this);
	    }
	
	}
	public abstract class ReturnTypeQualifierSyntax : CompilerSyntaxNode
	{
	    protected ReturnTypeQualifierSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ReturnTypeQualifierSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ReturnTypeQualifierAlt1Syntax : ReturnTypeQualifierSyntax
	{
	
	    public ReturnTypeQualifierAlt1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ReturnTypeQualifierAlt1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TPrimitiveType 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ReturnTypeQualifierAlt1Green)this.Green;
				var greenToken = green.TPrimitiveType;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public ReturnTypeQualifierAlt1Syntax WithTPrimitiveType(SyntaxToken tPrimitiveType)
		{
			return this.Update(tPrimitiveType);
		}
	
	    public ReturnTypeQualifierAlt1Syntax Update(SyntaxToken tPrimitiveType)
	    {
	        if (this.TPrimitiveType != tPrimitiveType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ReturnTypeQualifierAlt1(tPrimitiveType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ReturnTypeQualifierAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitReturnTypeQualifierAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitReturnTypeQualifierAlt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitReturnTypeQualifierAlt1(this);
	    }
	
	}
	public sealed class ReturnTypeQualifierAlt2Syntax : ReturnTypeQualifierSyntax
	{
		private QualifierSyntax _qualifier;
	
	    public ReturnTypeQualifierAlt2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ReturnTypeQualifierAlt2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public QualifierSyntax Qualifier => this.GetRed(ref this._qualifier, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._qualifier, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._qualifier;
				default: return null;
	        }
	    }
	
	    public ReturnTypeQualifierAlt2Syntax WithQualifier(QualifierSyntax qualifier)
		{
			return this.Update(qualifier);
		}
	
	    public ReturnTypeQualifierAlt2Syntax Update(QualifierSyntax qualifier)
	    {
	        if (this.Qualifier != qualifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ReturnTypeQualifierAlt2(qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ReturnTypeQualifierAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitReturnTypeQualifierAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitReturnTypeQualifierAlt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitReturnTypeQualifierAlt2(this);
	    }
	
	}
	public sealed class NameSyntax : CompilerSyntaxNode
	{
		private IdentifierSyntax _identifier;
	
	    public NameSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public NameSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public IdentifierSyntax Identifier => this.GetRed(ref this._identifier, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._identifier, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._identifier;
				default: return null;
	        }
	    }
	
	    public NameSyntax WithIdentifier(IdentifierSyntax identifier)
		{
			return this.Update(identifier);
		}
	
	    public NameSyntax Update(IdentifierSyntax identifier)
	    {
	        if (this.Identifier != identifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Name(identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (NameSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitName(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitName(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitName(this);
	    }
	
	}
	public sealed class QualifierSyntax : CompilerSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _identifierList;
	
	    public QualifierSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> IdentifierList 
		{ 
			get
			{
				var red = this.GetRed(ref this._identifierList, 0);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax>(red, this.GetChildIndex(0), reversed: false);
				}
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._identifierList, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._identifierList;
				default: return null;
	        }
	    }
	
	    public QualifierSyntax WithIdentifierList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifierList)
		{
			return this.Update(identifierList);
		}
	
	    public QualifierSyntax AddIdentifierList(params IdentifierSyntax[] identifierList)
		{
			return this.WithIdentifierList(this.IdentifierList.AddRange(identifierList));
		}
	
	    public QualifierSyntax Update(MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifierList)
	    {
	        if (this.IdentifierList != identifierList)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Qualifier(identifierList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (QualifierSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifier(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifier(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifier(this);
	    }
	
	}
	public sealed class QualifierListSyntax : CompilerSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _qualifierList;
	
	    public QualifierListSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierListSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> QualifierList 
		{ 
			get
			{
				var red = this.GetRed(ref this._qualifierList, 0);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax>(red, this.GetChildIndex(0), reversed: false);
				}
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._qualifierList, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._qualifierList;
				default: return null;
	        }
	    }
	
	    public QualifierListSyntax WithQualifierList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
		{
			return this.Update(qualifierList);
		}
	
	    public QualifierListSyntax AddQualifierList(params QualifierSyntax[] qualifierList)
		{
			return this.WithQualifierList(this.QualifierList.AddRange(qualifierList));
		}
	
	    public QualifierListSyntax Update(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
	    {
	        if (this.QualifierList != qualifierList)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.QualifierList(qualifierList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (QualifierListSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifierList(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifierList(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifierList(this);
	    }
	
	}
	public abstract class IdentifierSyntax : CompilerSyntaxNode
	{
	    protected IdentifierSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected IdentifierSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class IdentifierAlt1Syntax : IdentifierSyntax
	{
	
	    public IdentifierAlt1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public IdentifierAlt1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.IdentifierAlt1Green)this.Green;
				var greenToken = green.TIdentifier;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public IdentifierAlt1Syntax WithTIdentifier(SyntaxToken tIdentifier)
		{
			return this.Update(tIdentifier);
		}
	
	    public IdentifierAlt1Syntax Update(SyntaxToken tIdentifier)
	    {
	        if (this.TIdentifier != tIdentifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.IdentifierAlt1(tIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (IdentifierAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitIdentifierAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitIdentifierAlt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitIdentifierAlt1(this);
	    }
	
	}
	public sealed class IdentifierAlt2Syntax : IdentifierSyntax
	{
	
	    public IdentifierAlt2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public IdentifierAlt2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TVerbatimIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.IdentifierAlt2Green)this.Green;
				var greenToken = green.TVerbatimIdentifier;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public IdentifierAlt2Syntax WithTVerbatimIdentifier(SyntaxToken tVerbatimIdentifier)
		{
			return this.Update(tVerbatimIdentifier);
		}
	
	    public IdentifierAlt2Syntax Update(SyntaxToken tVerbatimIdentifier)
	    {
	        if (this.TVerbatimIdentifier != tVerbatimIdentifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.IdentifierAlt2(tVerbatimIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (IdentifierAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitIdentifierAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitIdentifierAlt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitIdentifierAlt2(this);
	    }
	
	}
	public sealed class SimpleQualifierSyntax : CompilerSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _simpleIdentifierList;
	
	    public SimpleQualifierSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SimpleQualifierSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<SimpleIdentifierSyntax> SimpleIdentifierList 
		{ 
			get
			{
				var red = this.GetRed(ref this._simpleIdentifierList, 0);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<SimpleIdentifierSyntax>(red, this.GetChildIndex(0), reversed: false);
				}
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._simpleIdentifierList, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._simpleIdentifierList;
				default: return null;
	        }
	    }
	
	    public SimpleQualifierSyntax WithSimpleIdentifierList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<SimpleIdentifierSyntax> simpleIdentifierList)
		{
			return this.Update(simpleIdentifierList);
		}
	
	    public SimpleQualifierSyntax AddSimpleIdentifierList(params SimpleIdentifierSyntax[] simpleIdentifierList)
		{
			return this.WithSimpleIdentifierList(this.SimpleIdentifierList.AddRange(simpleIdentifierList));
		}
	
	    public SimpleQualifierSyntax Update(MetaDslx.CodeAnalysis.SeparatedSyntaxList<SimpleIdentifierSyntax> simpleIdentifierList)
	    {
	        if (this.SimpleIdentifierList != simpleIdentifierList)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SimpleQualifier(simpleIdentifierList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (SimpleQualifierSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSimpleQualifier(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSimpleQualifier(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitSimpleQualifier(this);
	    }
	
	}
	public sealed class SimpleIdentifierSyntax : CompilerSyntaxNode
	{
	
	    public SimpleIdentifierSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SimpleIdentifierSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.SimpleIdentifierGreen)this.Green;
				var greenToken = green.TIdentifier;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public SimpleIdentifierSyntax WithTIdentifier(SyntaxToken tIdentifier)
		{
			return this.Update(tIdentifier);
		}
	
	    public SimpleIdentifierSyntax Update(SyntaxToken tIdentifier)
	    {
	        if (this.TIdentifier != tIdentifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SimpleIdentifier(tIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (SimpleIdentifierSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSimpleIdentifier(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSimpleIdentifier(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitSimpleIdentifier(this);
	    }
	
	}
	public sealed class GrammarBlock1Syntax : CompilerSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _rules;
	
	    public GrammarBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public GrammarBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> Rules 
		{ 
			get
			{
				var red = this.GetRed(ref this._rules, 0);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax>(red);
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._rules, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._rules;
				default: return null;
	        }
	    }
	
	    public GrammarBlock1Syntax WithRules(MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> rules)
		{
			return this.Update(rules);
		}
	
	    public GrammarBlock1Syntax AddRules(params RuleSyntax[] rules)
		{
			return this.WithRules(this.Rules.AddRange(rules));
		}
	
	    public GrammarBlock1Syntax Update(MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> rules)
	    {
	        if (this.Rules != rules)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.GrammarBlock1(rules);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (GrammarBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitGrammarBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitGrammarBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitGrammarBlock1(this);
	    }
	
	}
	public abstract class ParserRuleBlock1Syntax : CompilerSyntaxNode
	{
	    protected ParserRuleBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ParserRuleBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ParserRuleBlock1Alt1Syntax : ParserRuleBlock1Syntax
	{
		private ReturnTypeIdentifierSyntax _returnType;
	
	    public ParserRuleBlock1Alt1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserRuleBlock1Alt1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public ReturnTypeIdentifierSyntax ReturnType => this.GetRed(ref this._returnType, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._returnType, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._returnType;
				default: return null;
	        }
	    }
	
	    public ParserRuleBlock1Alt1Syntax WithReturnType(ReturnTypeIdentifierSyntax returnType)
		{
			return this.Update(returnType);
		}
	
	    public ParserRuleBlock1Alt1Syntax Update(ReturnTypeIdentifierSyntax returnType)
	    {
	        if (this.ReturnType != returnType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserRuleBlock1Alt1(returnType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleBlock1Alt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserRuleBlock1Alt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserRuleBlock1Alt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserRuleBlock1Alt1(this);
	    }
	
	}
	public sealed class ParserRuleBlock1Alt2Syntax : ParserRuleBlock1Syntax
	{
		private IdentifierSyntax _identifier;
		private ReturnTypeQualifierSyntax _returnType;
	
	    public ParserRuleBlock1Alt2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserRuleBlock1Alt2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public IdentifierSyntax Identifier => this.GetRed(ref this._identifier, 0);
	    public SyntaxToken KReturns 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserRuleBlock1Alt2Green)this.Green;
				var greenToken = green.KReturns;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public ReturnTypeQualifierSyntax ReturnType => this.GetRed(ref this._returnType, 2);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._identifier, 0);
				case 2: return this.GetRed(ref this._returnType, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._identifier;
				case 2: return this._returnType;
				default: return null;
	        }
	    }
	
	    public ParserRuleBlock1Alt2Syntax WithIdentifier(IdentifierSyntax identifier)
		{
			return this.Update(identifier, this.KReturns, this.ReturnType);
		}
	
	    public ParserRuleBlock1Alt2Syntax WithKReturns(SyntaxToken kReturns)
		{
			return this.Update(this.Identifier, kReturns, this.ReturnType);
		}
	
	    public ParserRuleBlock1Alt2Syntax WithReturnType(ReturnTypeQualifierSyntax returnType)
		{
			return this.Update(this.Identifier, this.KReturns, returnType);
		}
	
	    public ParserRuleBlock1Alt2Syntax Update(IdentifierSyntax identifier, SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
	    {
	        if (this.Identifier != identifier || this.KReturns != kReturns || this.ReturnType != returnType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserRuleBlock1Alt2(identifier, kReturns, returnType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleBlock1Alt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserRuleBlock1Alt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserRuleBlock1Alt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserRuleBlock1Alt2(this);
	    }
	
	}
	public sealed class ParserRuleBlock2Syntax : CompilerSyntaxNode
	{
		private PAlternativeSyntax _alternatives;
	
	    public ParserRuleBlock2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserRuleBlock2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TBar 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserRuleBlock2Green)this.Green;
				var greenToken = green.TBar;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public PAlternativeSyntax Alternatives => this.GetRed(ref this._alternatives, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._alternatives, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._alternatives;
				default: return null;
	        }
	    }
	
	    public ParserRuleBlock2Syntax WithTBar(SyntaxToken tBar)
		{
			return this.Update(tBar, this.Alternatives);
		}
	
	    public ParserRuleBlock2Syntax WithAlternatives(PAlternativeSyntax alternatives)
		{
			return this.Update(this.TBar, alternatives);
		}
	
	    public ParserRuleBlock2Syntax Update(SyntaxToken tBar, PAlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserRuleBlock2(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleBlock2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserRuleBlock2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserRuleBlock2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserRuleBlock2(this);
	    }
	
	}
	public sealed class PBlockBlock1Syntax : CompilerSyntaxNode
	{
		private ReturnTypeQualifierSyntax _returnType;
	
	    public PBlockBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PBlockBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KReturns 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PBlockBlock1Green)this.Green;
				var greenToken = green.KReturns;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public ReturnTypeQualifierSyntax ReturnType => this.GetRed(ref this._returnType, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._returnType, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._returnType;
				default: return null;
	        }
	    }
	
	    public PBlockBlock1Syntax WithKReturns(SyntaxToken kReturns)
		{
			return this.Update(kReturns, this.ReturnType);
		}
	
	    public PBlockBlock1Syntax WithReturnType(ReturnTypeQualifierSyntax returnType)
		{
			return this.Update(this.KReturns, returnType);
		}
	
	    public PBlockBlock1Syntax Update(SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
	    {
	        if (this.KReturns != kReturns || this.ReturnType != returnType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PBlockBlock1(kReturns, returnType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PBlockBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPBlockBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPBlockBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPBlockBlock1(this);
	    }
	
	}
	public sealed class PBlockBlock2Syntax : CompilerSyntaxNode
	{
		private PAlternativeSyntax _alternatives;
	
	    public PBlockBlock2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PBlockBlock2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TBar 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PBlockBlock2Green)this.Green;
				var greenToken = green.TBar;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public PAlternativeSyntax Alternatives => this.GetRed(ref this._alternatives, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._alternatives, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._alternatives;
				default: return null;
	        }
	    }
	
	    public PBlockBlock2Syntax WithTBar(SyntaxToken tBar)
		{
			return this.Update(tBar, this.Alternatives);
		}
	
	    public PBlockBlock2Syntax WithAlternatives(PAlternativeSyntax alternatives)
		{
			return this.Update(this.TBar, alternatives);
		}
	
	    public PBlockBlock2Syntax Update(SyntaxToken tBar, PAlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PBlockBlock2(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PBlockBlock2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPBlockBlock2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPBlockBlock2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPBlockBlock2(this);
	    }
	
	}
	public sealed class PBlockInlineBlock1Syntax : CompilerSyntaxNode
	{
		private PAlternativeSyntax _alternatives;
	
	    public PBlockInlineBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PBlockInlineBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TBar 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PBlockInlineBlock1Green)this.Green;
				var greenToken = green.TBar;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public PAlternativeSyntax Alternatives => this.GetRed(ref this._alternatives, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._alternatives, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._alternatives;
				default: return null;
	        }
	    }
	
	    public PBlockInlineBlock1Syntax WithTBar(SyntaxToken tBar)
		{
			return this.Update(tBar, this.Alternatives);
		}
	
	    public PBlockInlineBlock1Syntax WithAlternatives(PAlternativeSyntax alternatives)
		{
			return this.Update(this.TBar, alternatives);
		}
	
	    public PBlockInlineBlock1Syntax Update(SyntaxToken tBar, PAlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PBlockInlineBlock1(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PBlockInlineBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPBlockInlineBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPBlockInlineBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPBlockInlineBlock1(this);
	    }
	
	}
	public sealed class PAlternativeBlock1Syntax : CompilerSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _annotations1;
		private NameSyntax _name;
		private PAlternativeBlock1Block1Syntax _pAlternativeBlock1Block1;
	
	    public PAlternativeBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PAlternativeBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> Annotations1 
		{ 
			get
			{
				var red = this.GetRed(ref this._annotations1, 0);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax>(red);
				return default;
			} 
		}
	    public SyntaxToken KAlt 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PAlternativeBlock1Green)this.Green;
				var greenToken = green.KAlt;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public NameSyntax Name => this.GetRed(ref this._name, 2);
	    public PAlternativeBlock1Block1Syntax PAlternativeBlock1Block1 => this.GetRed(ref this._pAlternativeBlock1Block1, 3);
	    public SyntaxToken TColon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PAlternativeBlock1Green)this.Green;
				var greenToken = green.TColon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._annotations1, 0);
				case 2: return this.GetRed(ref this._name, 2);
				case 3: return this.GetRed(ref this._pAlternativeBlock1Block1, 3);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._annotations1;
				case 2: return this._name;
				case 3: return this._pAlternativeBlock1Block1;
				default: return null;
	        }
	    }
	
	    public PAlternativeBlock1Syntax WithAnnotations1(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
		{
			return this.Update(annotations1, this.KAlt, this.Name, this.PAlternativeBlock1Block1, this.TColon);
		}
	
	    public PAlternativeBlock1Syntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
		{
			return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
		}
	
	    public PAlternativeBlock1Syntax WithKAlt(SyntaxToken kAlt)
		{
			return this.Update(this.Annotations1, kAlt, this.Name, this.PAlternativeBlock1Block1, this.TColon);
		}
	
	    public PAlternativeBlock1Syntax WithName(NameSyntax name)
		{
			return this.Update(this.Annotations1, this.KAlt, name, this.PAlternativeBlock1Block1, this.TColon);
		}
	
	    public PAlternativeBlock1Syntax WithPAlternativeBlock1Block1(PAlternativeBlock1Block1Syntax pAlternativeBlock1Block1)
		{
			return this.Update(this.Annotations1, this.KAlt, this.Name, pAlternativeBlock1Block1, this.TColon);
		}
	
	    public PAlternativeBlock1Syntax WithTColon(SyntaxToken tColon)
		{
			return this.Update(this.Annotations1, this.KAlt, this.Name, this.PAlternativeBlock1Block1, tColon);
		}
	
	    public PAlternativeBlock1Syntax Update(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, SyntaxToken kAlt, NameSyntax name, PAlternativeBlock1Block1Syntax pAlternativeBlock1Block1, SyntaxToken tColon)
	    {
	        if (this.Annotations1 != annotations1 || this.KAlt != kAlt || this.Name != name || this.PAlternativeBlock1Block1 != pAlternativeBlock1Block1 || this.TColon != tColon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PAlternativeBlock1(annotations1, kAlt, name, pAlternativeBlock1Block1, tColon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PAlternativeBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPAlternativeBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPAlternativeBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPAlternativeBlock1(this);
	    }
	
	}
	public sealed class PAlternativeBlock2Syntax : CompilerSyntaxNode
	{
		private ExpressionSyntax _returnValue;
	
	    public PAlternativeBlock2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PAlternativeBlock2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TEqGt 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PAlternativeBlock2Green)this.Green;
				var greenToken = green.TEqGt;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public ExpressionSyntax ReturnValue => this.GetRed(ref this._returnValue, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._returnValue, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._returnValue;
				default: return null;
	        }
	    }
	
	    public PAlternativeBlock2Syntax WithTEqGt(SyntaxToken tEqGt)
		{
			return this.Update(tEqGt, this.ReturnValue);
		}
	
	    public PAlternativeBlock2Syntax WithReturnValue(ExpressionSyntax returnValue)
		{
			return this.Update(this.TEqGt, returnValue);
		}
	
	    public PAlternativeBlock2Syntax Update(SyntaxToken tEqGt, ExpressionSyntax returnValue)
	    {
	        if (this.TEqGt != tEqGt || this.ReturnValue != returnValue)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PAlternativeBlock2(tEqGt, returnValue);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PAlternativeBlock2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPAlternativeBlock2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPAlternativeBlock2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPAlternativeBlock2(this);
	    }
	
	}
	public sealed class PElementBlock1Syntax : CompilerSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _nameAnnotations;
		private IdentifierSyntax _symbolProperty;
	
	    public PElementBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PElementBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> NameAnnotations 
		{ 
			get
			{
				var red = this.GetRed(ref this._nameAnnotations, 0);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax>(red);
				return default;
			} 
		}
	    public IdentifierSyntax SymbolProperty => this.GetRed(ref this._symbolProperty, 1);
	    public SyntaxToken Assignment 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PElementBlock1Green)this.Green;
				var greenToken = green.Assignment;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._nameAnnotations, 0);
				case 1: return this.GetRed(ref this._symbolProperty, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._nameAnnotations;
				case 1: return this._symbolProperty;
				default: return null;
	        }
	    }
	
	    public PElementBlock1Syntax WithNameAnnotations(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> nameAnnotations)
		{
			return this.Update(nameAnnotations, this.SymbolProperty, this.Assignment);
		}
	
	    public PElementBlock1Syntax AddNameAnnotations(params ParserAnnotationSyntax[] nameAnnotations)
		{
			return this.WithNameAnnotations(this.NameAnnotations.AddRange(nameAnnotations));
		}
	
	    public PElementBlock1Syntax WithSymbolProperty(IdentifierSyntax symbolProperty)
		{
			return this.Update(this.NameAnnotations, symbolProperty, this.Assignment);
		}
	
	    public PElementBlock1Syntax WithAssignment(SyntaxToken assignment)
		{
			return this.Update(this.NameAnnotations, this.SymbolProperty, assignment);
		}
	
	    public PElementBlock1Syntax Update(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> nameAnnotations, IdentifierSyntax symbolProperty, SyntaxToken assignment)
	    {
	        if (this.NameAnnotations != nameAnnotations || this.SymbolProperty != symbolProperty || this.Assignment != assignment)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PElementBlock1(nameAnnotations, symbolProperty, assignment);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PElementBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPElementBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPElementBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPElementBlock1(this);
	    }
	
	}
	public sealed class PReferenceAlt3Block1Syntax : CompilerSyntaxNode
	{
		private ReturnTypeQualifierSyntax _referencedTypes;
	
	    public PReferenceAlt3Block1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PReferenceAlt3Block1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PReferenceAlt3Block1Green)this.Green;
				var greenToken = green.TComma;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public ReturnTypeQualifierSyntax ReferencedTypes => this.GetRed(ref this._referencedTypes, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._referencedTypes, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._referencedTypes;
				default: return null;
	        }
	    }
	
	    public PReferenceAlt3Block1Syntax WithTComma(SyntaxToken tComma)
		{
			return this.Update(tComma, this.ReferencedTypes);
		}
	
	    public PReferenceAlt3Block1Syntax WithReferencedTypes(ReturnTypeQualifierSyntax referencedTypes)
		{
			return this.Update(this.TComma, referencedTypes);
		}
	
	    public PReferenceAlt3Block1Syntax Update(SyntaxToken tComma, ReturnTypeQualifierSyntax referencedTypes)
	    {
	        if (this.TComma != tComma || this.ReferencedTypes != referencedTypes)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PReferenceAlt3Block1(tComma, referencedTypes);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PReferenceAlt3Block1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPReferenceAlt3Block1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPReferenceAlt3Block1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPReferenceAlt3Block1(this);
	    }
	
	}
	public abstract class LexerRuleBlock1Syntax : CompilerSyntaxNode
	{
	    protected LexerRuleBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected LexerRuleBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class LexerRuleBlock1Alt1Syntax : LexerRuleBlock1Syntax
	{
		private NameSyntax _name;
		private LexerRuleBlock1Alt1Block1Syntax _lexerRuleBlock1Alt1Block1;
	
	    public LexerRuleBlock1Alt1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LexerRuleBlock1Alt1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KToken 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerRuleBlock1Alt1Green)this.Green;
				var greenToken = green.KToken;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public NameSyntax Name => this.GetRed(ref this._name, 1);
	    public LexerRuleBlock1Alt1Block1Syntax LexerRuleBlock1Alt1Block1 => this.GetRed(ref this._lexerRuleBlock1Alt1Block1, 2);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._name, 1);
				case 2: return this.GetRed(ref this._lexerRuleBlock1Alt1Block1, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._name;
				case 2: return this._lexerRuleBlock1Alt1Block1;
				default: return null;
	        }
	    }
	
	    public LexerRuleBlock1Alt1Syntax WithKToken(SyntaxToken kToken)
		{
			return this.Update(kToken, this.Name, this.LexerRuleBlock1Alt1Block1);
		}
	
	    public LexerRuleBlock1Alt1Syntax WithName(NameSyntax name)
		{
			return this.Update(this.KToken, name, this.LexerRuleBlock1Alt1Block1);
		}
	
	    public LexerRuleBlock1Alt1Syntax WithLexerRuleBlock1Alt1Block1(LexerRuleBlock1Alt1Block1Syntax lexerRuleBlock1Alt1Block1)
		{
			return this.Update(this.KToken, this.Name, lexerRuleBlock1Alt1Block1);
		}
	
	    public LexerRuleBlock1Alt1Syntax Update(SyntaxToken kToken, NameSyntax name, LexerRuleBlock1Alt1Block1Syntax lexerRuleBlock1Alt1Block1)
	    {
	        if (this.KToken != kToken || this.Name != name || this.LexerRuleBlock1Alt1Block1 != lexerRuleBlock1Alt1Block1)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerRuleBlock1Alt1(kToken, name, lexerRuleBlock1Alt1Block1);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleBlock1Alt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLexerRuleBlock1Alt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLexerRuleBlock1Alt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLexerRuleBlock1Alt1(this);
	    }
	
	}
	public sealed class LexerRuleBlock1Alt2Syntax : LexerRuleBlock1Syntax
	{
		private NameSyntax _name;
	
	    public LexerRuleBlock1Alt2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LexerRuleBlock1Alt2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken IsHidden 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerRuleBlock1Alt2Green)this.Green;
				var greenToken = green.IsHidden;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public NameSyntax Name => this.GetRed(ref this._name, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._name, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._name;
				default: return null;
	        }
	    }
	
	    public LexerRuleBlock1Alt2Syntax WithIsHidden(SyntaxToken isHidden)
		{
			return this.Update(isHidden, this.Name);
		}
	
	    public LexerRuleBlock1Alt2Syntax WithName(NameSyntax name)
		{
			return this.Update(this.IsHidden, name);
		}
	
	    public LexerRuleBlock1Alt2Syntax Update(SyntaxToken isHidden, NameSyntax name)
	    {
	        if (this.IsHidden != isHidden || this.Name != name)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerRuleBlock1Alt2(isHidden, name);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleBlock1Alt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLexerRuleBlock1Alt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLexerRuleBlock1Alt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLexerRuleBlock1Alt2(this);
	    }
	
	}
	public sealed class LexerRuleBlock1Alt3Syntax : LexerRuleBlock1Syntax
	{
		private NameSyntax _name;
	
	    public LexerRuleBlock1Alt3Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LexerRuleBlock1Alt3Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken IsFragment 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerRuleBlock1Alt3Green)this.Green;
				var greenToken = green.IsFragment;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public NameSyntax Name => this.GetRed(ref this._name, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._name, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._name;
				default: return null;
	        }
	    }
	
	    public LexerRuleBlock1Alt3Syntax WithIsFragment(SyntaxToken isFragment)
		{
			return this.Update(isFragment, this.Name);
		}
	
	    public LexerRuleBlock1Alt3Syntax WithName(NameSyntax name)
		{
			return this.Update(this.IsFragment, name);
		}
	
	    public LexerRuleBlock1Alt3Syntax Update(SyntaxToken isFragment, NameSyntax name)
	    {
	        if (this.IsFragment != isFragment || this.Name != name)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerRuleBlock1Alt3(isFragment, name);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleBlock1Alt3Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLexerRuleBlock1Alt3(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLexerRuleBlock1Alt3(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLexerRuleBlock1Alt3(this);
	    }
	
	}
	public sealed class LexerRuleBlock2Syntax : CompilerSyntaxNode
	{
		private LAlternativeSyntax _alternatives;
	
	    public LexerRuleBlock2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LexerRuleBlock2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TBar 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerRuleBlock2Green)this.Green;
				var greenToken = green.TBar;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public LAlternativeSyntax Alternatives => this.GetRed(ref this._alternatives, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._alternatives, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._alternatives;
				default: return null;
	        }
	    }
	
	    public LexerRuleBlock2Syntax WithTBar(SyntaxToken tBar)
		{
			return this.Update(tBar, this.Alternatives);
		}
	
	    public LexerRuleBlock2Syntax WithAlternatives(LAlternativeSyntax alternatives)
		{
			return this.Update(this.TBar, alternatives);
		}
	
	    public LexerRuleBlock2Syntax Update(SyntaxToken tBar, LAlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerRuleBlock2(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleBlock2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLexerRuleBlock2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLexerRuleBlock2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLexerRuleBlock2(this);
	    }
	
	}
	public sealed class LBlockBlock1Syntax : CompilerSyntaxNode
	{
		private LAlternativeSyntax _alternatives;
	
	    public LBlockBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LBlockBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TBar 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LBlockBlock1Green)this.Green;
				var greenToken = green.TBar;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public LAlternativeSyntax Alternatives => this.GetRed(ref this._alternatives, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._alternatives, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._alternatives;
				default: return null;
	        }
	    }
	
	    public LBlockBlock1Syntax WithTBar(SyntaxToken tBar)
		{
			return this.Update(tBar, this.Alternatives);
		}
	
	    public LBlockBlock1Syntax WithAlternatives(LAlternativeSyntax alternatives)
		{
			return this.Update(this.TBar, alternatives);
		}
	
	    public LBlockBlock1Syntax Update(SyntaxToken tBar, LAlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LBlockBlock1(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LBlockBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLBlockBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLBlockBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLBlockBlock1(this);
	    }
	
	}
	public abstract class SingleExpressionBlock1Syntax : CompilerSyntaxNode
	{
	    protected SingleExpressionBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected SingleExpressionBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class SingleExpressionBlock1Alt4Syntax : SingleExpressionBlock1Syntax
	{
	
	    public SingleExpressionBlock1Alt4Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SingleExpressionBlock1Alt4Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TInteger 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.SingleExpressionBlock1Alt4Green)this.Green;
				var greenToken = green.TInteger;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public SingleExpressionBlock1Alt4Syntax WithTInteger(SyntaxToken tInteger)
		{
			return this.Update(tInteger);
		}
	
	    public SingleExpressionBlock1Alt4Syntax Update(SyntaxToken tInteger)
	    {
	        if (this.TInteger != tInteger)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionBlock1Alt4(tInteger);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (SingleExpressionBlock1Alt4Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt4(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt4(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitSingleExpressionBlock1Alt4(this);
	    }
	
	}
	public sealed class SingleExpressionBlock1Alt5Syntax : SingleExpressionBlock1Syntax
	{
	
	    public SingleExpressionBlock1Alt5Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SingleExpressionBlock1Alt5Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TString 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.SingleExpressionBlock1Alt5Green)this.Green;
				var greenToken = green.TString;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public SingleExpressionBlock1Alt5Syntax WithTString(SyntaxToken tString)
		{
			return this.Update(tString);
		}
	
	    public SingleExpressionBlock1Alt5Syntax Update(SyntaxToken tString)
	    {
	        if (this.TString != tString)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionBlock1Alt5(tString);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (SingleExpressionBlock1Alt5Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt5(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt5(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitSingleExpressionBlock1Alt5(this);
	    }
	
	}
	public sealed class SingleExpressionBlock1Alt6Syntax : SingleExpressionBlock1Syntax
	{
		private SimpleQualifierSyntax _simpleQualifier;
	
	    public SingleExpressionBlock1Alt6Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SingleExpressionBlock1Alt6Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SimpleQualifierSyntax SimpleQualifier => this.GetRed(ref this._simpleQualifier, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._simpleQualifier, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._simpleQualifier;
				default: return null;
	        }
	    }
	
	    public SingleExpressionBlock1Alt6Syntax WithSimpleQualifier(SimpleQualifierSyntax simpleQualifier)
		{
			return this.Update(simpleQualifier);
		}
	
	    public SingleExpressionBlock1Alt6Syntax Update(SimpleQualifierSyntax simpleQualifier)
	    {
	        if (this.SimpleQualifier != simpleQualifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionBlock1Alt6(simpleQualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (SingleExpressionBlock1Alt6Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt6(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt6(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitSingleExpressionBlock1Alt6(this);
	    }
	
	}
	public sealed class SingleExpressionBlock1TokensSyntax : SingleExpressionBlock1Syntax
	{
	
	    public SingleExpressionBlock1TokensSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SingleExpressionBlock1TokensSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken Tokens 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.SingleExpressionBlock1TokensGreen)this.Green;
				var greenToken = green.Tokens;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public SingleExpressionBlock1TokensSyntax WithTokens(SyntaxToken tokens)
		{
			return this.Update(tokens);
		}
	
	    public SingleExpressionBlock1TokensSyntax Update(SyntaxToken tokens)
	    {
	        if (this.Tokens != tokens)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionBlock1Tokens(tokens);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (SingleExpressionBlock1TokensSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSingleExpressionBlock1Tokens(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSingleExpressionBlock1Tokens(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitSingleExpressionBlock1Tokens(this);
	    }
	
	}
	public sealed class ArrayExpressionBlock1Syntax : CompilerSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _singleExpressionList;
	
	    public ArrayExpressionBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ArrayExpressionBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> SingleExpressionList 
		{ 
			get
			{
				var red = this.GetRed(ref this._singleExpressionList, 0);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax>(red, this.GetChildIndex(0), reversed: false);
				}
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._singleExpressionList, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._singleExpressionList;
				default: return null;
	        }
	    }
	
	    public ArrayExpressionBlock1Syntax WithSingleExpressionList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> singleExpressionList)
		{
			return this.Update(singleExpressionList);
		}
	
	    public ArrayExpressionBlock1Syntax AddSingleExpressionList(params SingleExpressionSyntax[] singleExpressionList)
		{
			return this.WithSingleExpressionList(this.SingleExpressionList.AddRange(singleExpressionList));
		}
	
	    public ArrayExpressionBlock1Syntax Update(MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> singleExpressionList)
	    {
	        if (this.SingleExpressionList != singleExpressionList)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ArrayExpressionBlock1(singleExpressionList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ArrayExpressionBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitArrayExpressionBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitArrayExpressionBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitArrayExpressionBlock1(this);
	    }
	
	}
	public sealed class AnnotationArgumentsBlock1Syntax : CompilerSyntaxNode
	{
		private AnnotationArgumentSyntax _arguments;
	
	    public AnnotationArgumentsBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AnnotationArgumentsBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AnnotationArgumentsBlock1Green)this.Green;
				var greenToken = green.TComma;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public AnnotationArgumentSyntax Arguments => this.GetRed(ref this._arguments, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._arguments, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._arguments;
				default: return null;
	        }
	    }
	
	    public AnnotationArgumentsBlock1Syntax WithTComma(SyntaxToken tComma)
		{
			return this.Update(tComma, this.Arguments);
		}
	
	    public AnnotationArgumentsBlock1Syntax WithArguments(AnnotationArgumentSyntax arguments)
		{
			return this.Update(this.TComma, arguments);
		}
	
	    public AnnotationArgumentsBlock1Syntax Update(SyntaxToken tComma, AnnotationArgumentSyntax arguments)
	    {
	        if (this.TComma != tComma || this.Arguments != arguments)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.AnnotationArgumentsBlock1(tComma, arguments);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (AnnotationArgumentsBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitAnnotationArgumentsBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitAnnotationArgumentsBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitAnnotationArgumentsBlock1(this);
	    }
	
	}
	public sealed class AnnotationArgumentBlock1Syntax : CompilerSyntaxNode
	{
		private IdentifierSyntax _namedParameter;
	
	    public AnnotationArgumentBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AnnotationArgumentBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public IdentifierSyntax NamedParameter => this.GetRed(ref this._namedParameter, 0);
	    public SyntaxToken TColon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AnnotationArgumentBlock1Green)this.Green;
				var greenToken = green.TColon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._namedParameter, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._namedParameter;
				default: return null;
	        }
	    }
	
	    public AnnotationArgumentBlock1Syntax WithNamedParameter(IdentifierSyntax namedParameter)
		{
			return this.Update(namedParameter, this.TColon);
		}
	
	    public AnnotationArgumentBlock1Syntax WithTColon(SyntaxToken tColon)
		{
			return this.Update(this.NamedParameter, tColon);
		}
	
	    public AnnotationArgumentBlock1Syntax Update(IdentifierSyntax namedParameter, SyntaxToken tColon)
	    {
	        if (this.NamedParameter != namedParameter || this.TColon != tColon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.AnnotationArgumentBlock1(namedParameter, tColon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (AnnotationArgumentBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitAnnotationArgumentBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitAnnotationArgumentBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitAnnotationArgumentBlock1(this);
	    }
	
	}
	public sealed class QualifierBlock1Syntax : CompilerSyntaxNode
	{
		private IdentifierSyntax _identifier;
	
	    public QualifierBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TDot 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.QualifierBlock1Green)this.Green;
				var greenToken = green.TDot;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public IdentifierSyntax Identifier => this.GetRed(ref this._identifier, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._identifier, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._identifier;
				default: return null;
	        }
	    }
	
	    public QualifierBlock1Syntax WithTDot(SyntaxToken tDot)
		{
			return this.Update(tDot, this.Identifier);
		}
	
	    public QualifierBlock1Syntax WithIdentifier(IdentifierSyntax identifier)
		{
			return this.Update(this.TDot, identifier);
		}
	
	    public QualifierBlock1Syntax Update(SyntaxToken tDot, IdentifierSyntax identifier)
	    {
	        if (this.TDot != tDot || this.Identifier != identifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.QualifierBlock1(tDot, identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (QualifierBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifierBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifierBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifierBlock1(this);
	    }
	
	}
	public sealed class QualifierListBlock1Syntax : CompilerSyntaxNode
	{
		private QualifierSyntax _qualifier;
	
	    public QualifierListBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierListBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.QualifierListBlock1Green)this.Green;
				var greenToken = green.TComma;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax Qualifier => this.GetRed(ref this._qualifier, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._qualifier, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._qualifier;
				default: return null;
	        }
	    }
	
	    public QualifierListBlock1Syntax WithTComma(SyntaxToken tComma)
		{
			return this.Update(tComma, this.Qualifier);
		}
	
	    public QualifierListBlock1Syntax WithQualifier(QualifierSyntax qualifier)
		{
			return this.Update(this.TComma, qualifier);
		}
	
	    public QualifierListBlock1Syntax Update(SyntaxToken tComma, QualifierSyntax qualifier)
	    {
	        if (this.TComma != tComma || this.Qualifier != qualifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.QualifierListBlock1(tComma, qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (QualifierListBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifierListBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifierListBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifierListBlock1(this);
	    }
	
	}
	public sealed class SimpleQualifierBlock1Syntax : CompilerSyntaxNode
	{
		private SimpleIdentifierSyntax _simpleIdentifier;
	
	    public SimpleQualifierBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SimpleQualifierBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TDot 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.SimpleQualifierBlock1Green)this.Green;
				var greenToken = green.TDot;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public SimpleIdentifierSyntax SimpleIdentifier => this.GetRed(ref this._simpleIdentifier, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._simpleIdentifier, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._simpleIdentifier;
				default: return null;
	        }
	    }
	
	    public SimpleQualifierBlock1Syntax WithTDot(SyntaxToken tDot)
		{
			return this.Update(tDot, this.SimpleIdentifier);
		}
	
	    public SimpleQualifierBlock1Syntax WithSimpleIdentifier(SimpleIdentifierSyntax simpleIdentifier)
		{
			return this.Update(this.TDot, simpleIdentifier);
		}
	
	    public SimpleQualifierBlock1Syntax Update(SyntaxToken tDot, SimpleIdentifierSyntax simpleIdentifier)
	    {
	        if (this.TDot != tDot || this.SimpleIdentifier != simpleIdentifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SimpleQualifierBlock1(tDot, simpleIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (SimpleQualifierBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSimpleQualifierBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSimpleQualifierBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitSimpleQualifierBlock1(this);
	    }
	
	}
	public sealed class PAlternativeBlock1Block1Syntax : CompilerSyntaxNode
	{
		private ReturnTypeQualifierSyntax _returnType;
	
	    public PAlternativeBlock1Block1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PAlternativeBlock1Block1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KReturns 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.PAlternativeBlock1Block1Green)this.Green;
				var greenToken = green.KReturns;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public ReturnTypeQualifierSyntax ReturnType => this.GetRed(ref this._returnType, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._returnType, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._returnType;
				default: return null;
	        }
	    }
	
	    public PAlternativeBlock1Block1Syntax WithKReturns(SyntaxToken kReturns)
		{
			return this.Update(kReturns, this.ReturnType);
		}
	
	    public PAlternativeBlock1Block1Syntax WithReturnType(ReturnTypeQualifierSyntax returnType)
		{
			return this.Update(this.KReturns, returnType);
		}
	
	    public PAlternativeBlock1Block1Syntax Update(SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
	    {
	        if (this.KReturns != kReturns || this.ReturnType != returnType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.PAlternativeBlock1Block1(kReturns, returnType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PAlternativeBlock1Block1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPAlternativeBlock1Block1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPAlternativeBlock1Block1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitPAlternativeBlock1Block1(this);
	    }
	
	}
	public sealed class LexerRuleBlock1Alt1Block1Syntax : CompilerSyntaxNode
	{
		private ReturnTypeQualifierSyntax _returnType;
	
	    public LexerRuleBlock1Alt1Block1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LexerRuleBlock1Alt1Block1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KReturns 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerRuleBlock1Alt1Block1Green)this.Green;
				var greenToken = green.KReturns;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public ReturnTypeQualifierSyntax ReturnType => this.GetRed(ref this._returnType, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._returnType, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._returnType;
				default: return null;
	        }
	    }
	
	    public LexerRuleBlock1Alt1Block1Syntax WithKReturns(SyntaxToken kReturns)
		{
			return this.Update(kReturns, this.ReturnType);
		}
	
	    public LexerRuleBlock1Alt1Block1Syntax WithReturnType(ReturnTypeQualifierSyntax returnType)
		{
			return this.Update(this.KReturns, returnType);
		}
	
	    public LexerRuleBlock1Alt1Block1Syntax Update(SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
	    {
	        if (this.KReturns != kReturns || this.ReturnType != returnType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerRuleBlock1Alt1Block1(kReturns, returnType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LexerRuleBlock1Alt1Block1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLexerRuleBlock1Alt1Block1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLexerRuleBlock1Alt1Block1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLexerRuleBlock1Alt1Block1(this);
	    }
	
	}
	public sealed class ArrayExpressionBlock1Block1Syntax : CompilerSyntaxNode
	{
		private SingleExpressionSyntax _items;
	
	    public ArrayExpressionBlock1Block1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ArrayExpressionBlock1Block1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ArrayExpressionBlock1Block1Green)this.Green;
				var greenToken = green.TComma;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public SingleExpressionSyntax Items => this.GetRed(ref this._items, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._items, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._items;
				default: return null;
	        }
	    }
	
	    public ArrayExpressionBlock1Block1Syntax WithTComma(SyntaxToken tComma)
		{
			return this.Update(tComma, this.Items);
		}
	
	    public ArrayExpressionBlock1Block1Syntax WithItems(SingleExpressionSyntax items)
		{
			return this.Update(this.TComma, items);
		}
	
	    public ArrayExpressionBlock1Block1Syntax Update(SyntaxToken tComma, SingleExpressionSyntax items)
	    {
	        if (this.TComma != tComma || this.Items != items)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ArrayExpressionBlock1Block1(tComma, items);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ArrayExpressionBlock1Block1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitArrayExpressionBlock1Block1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitArrayExpressionBlock1Block1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitArrayExpressionBlock1Block1(this);
	    }
	
	}
}
