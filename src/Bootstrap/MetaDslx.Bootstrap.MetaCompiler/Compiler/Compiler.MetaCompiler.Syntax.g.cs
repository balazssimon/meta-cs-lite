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
		private QualifierSyntax _qualifier;
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
	    public QualifierSyntax Qualifier => this.GetRed(ref this._qualifier, 1);
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
				case 1: return this.GetRed(ref this._qualifier, 1);
				case 3: return this.GetRed(ref this._using, 3);
				case 4: return this.GetRed(ref this._declarations, 4);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._qualifier;
				case 3: return this._using;
				case 4: return this._declarations;
				default: return null;
	        }
	    }
	
	    public MainSyntax WithKNamespace(SyntaxToken kNamespace)
		{
			return this.Update(kNamespace, this.Qualifier, this.TSemicolon, this.Using, this.Declarations, this.EndOfFileToken);
		}
	
	    public MainSyntax WithQualifier(QualifierSyntax qualifier)
		{
			return this.Update(this.KNamespace, qualifier, this.TSemicolon, this.Using, this.Declarations, this.EndOfFileToken);
		}
	
	    public MainSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.KNamespace, this.Qualifier, tSemicolon, this.Using, this.Declarations, this.EndOfFileToken);
		}
	
	    public MainSyntax WithUsing(MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using)
		{
			return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, @using, this.Declarations, this.EndOfFileToken);
		}
	
	    public MainSyntax AddUsing(params UsingSyntax[] @using)
		{
			return this.WithUsing(this.Using.AddRange(@using));
		}
	
	    public MainSyntax WithDeclarations(DeclarationsSyntax declarations)
		{
			return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, this.Using, declarations, this.EndOfFileToken);
		}
	
	    public MainSyntax WithEndOfFileToken(SyntaxToken eof)
		{
			return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, this.Using, this.Declarations, eof);
		}
	
	    public MainSyntax Update(SyntaxToken kNamespace, QualifierSyntax qualifier, SyntaxToken tSemicolon, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations, SyntaxToken eof)
	    {
	        if (this.KNamespace != kNamespace || this.Qualifier != qualifier || this.TSemicolon != tSemicolon || this.Using != @using || this.Declarations != declarations || this.EndOfFileToken != eof)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Main(kNamespace, qualifier, tSemicolon, @using, declarations, eof);
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
		private UsingBlock1Syntax _usingBlock1;
	
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
	    public UsingBlock1Syntax UsingBlock1 => this.GetRed(ref this._usingBlock1, 1);
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
				case 1: return this.GetRed(ref this._usingBlock1, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._usingBlock1;
				default: return null;
	        }
	    }
	
	    public UsingSyntax WithKUsing(SyntaxToken kUsing)
		{
			return this.Update(kUsing, this.UsingBlock1, this.TSemicolon);
		}
	
	    public UsingSyntax WithUsingBlock1(UsingBlock1Syntax usingBlock1)
		{
			return this.Update(this.KUsing, usingBlock1, this.TSemicolon);
		}
	
	    public UsingSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.KUsing, this.UsingBlock1, tSemicolon);
		}
	
	    public UsingSyntax Update(SyntaxToken kUsing, UsingBlock1Syntax usingBlock1, SyntaxToken tSemicolon)
	    {
	        if (this.KUsing != kUsing || this.UsingBlock1 != usingBlock1 || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Using(kUsing, usingBlock1, tSemicolon);
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
	
	    public LanguageDeclarationSyntax WithKLanguage(SyntaxToken kLanguage)
		{
			return this.Update(kLanguage, this.Name, this.TSemicolon);
		}
	
	    public LanguageDeclarationSyntax WithName(NameSyntax name)
		{
			return this.Update(this.KLanguage, name, this.TSemicolon);
		}
	
	    public LanguageDeclarationSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.KLanguage, this.Name, tSemicolon);
		}
	
	    public LanguageDeclarationSyntax Update(SyntaxToken kLanguage, NameSyntax name, SyntaxToken tSemicolon)
	    {
	        if (this.KLanguage != kLanguage || this.Name != name || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LanguageDeclaration(kLanguage, name, tSemicolon);
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
		private NameSyntax _name;
		private ParserRuleBlock1Syntax _parserRuleBlock1;
		private MetaDslx.CodeAnalysis.SyntaxNode _parserRuleAlternativeList;
	
	    public ParserRuleSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserRuleSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public NameSyntax Name => this.GetRed(ref this._name, 0);
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
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax> ParserRuleAlternativeList 
		{ 
			get
			{
				var red = this.GetRed(ref this._parserRuleAlternativeList, 3);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax>(red, this.GetChildIndex(3), reversed: false);
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
				case 0: return this.GetRed(ref this._name, 0);
				case 1: return this.GetRed(ref this._parserRuleBlock1, 1);
				case 3: return this.GetRed(ref this._parserRuleAlternativeList, 3);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._name;
				case 1: return this._parserRuleBlock1;
				case 3: return this._parserRuleAlternativeList;
				default: return null;
	        }
	    }
	
	    public ParserRuleSyntax WithName(NameSyntax name)
		{
			return this.Update(name, this.ParserRuleBlock1, this.TColon, this.ParserRuleAlternativeList, this.TSemicolon);
		}
	
	    public ParserRuleSyntax WithParserRuleBlock1(ParserRuleBlock1Syntax parserRuleBlock1)
		{
			return this.Update(this.Name, parserRuleBlock1, this.TColon, this.ParserRuleAlternativeList, this.TSemicolon);
		}
	
	    public ParserRuleSyntax WithTColon(SyntaxToken tColon)
		{
			return this.Update(this.Name, this.ParserRuleBlock1, tColon, this.ParserRuleAlternativeList, this.TSemicolon);
		}
	
	    public ParserRuleSyntax WithParserRuleAlternativeList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax> parserRuleAlternativeList)
		{
			return this.Update(this.Name, this.ParserRuleBlock1, this.TColon, parserRuleAlternativeList, this.TSemicolon);
		}
	
	    public ParserRuleSyntax AddParserRuleAlternativeList(params ParserRuleAlternativeSyntax[] parserRuleAlternativeList)
		{
			return this.WithParserRuleAlternativeList(this.ParserRuleAlternativeList.AddRange(parserRuleAlternativeList));
		}
	
	    public ParserRuleSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.Name, this.ParserRuleBlock1, this.TColon, this.ParserRuleAlternativeList, tSemicolon);
		}
	
	    public ParserRuleSyntax Update(NameSyntax name, ParserRuleBlock1Syntax parserRuleBlock1, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax> parserRuleAlternativeList, SyntaxToken tSemicolon)
	    {
	        if (this.Name != name || this.ParserRuleBlock1 != parserRuleBlock1 || this.TColon != tColon || this.ParserRuleAlternativeList != parserRuleAlternativeList || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserRule(name, parserRuleBlock1, tColon, parserRuleAlternativeList, tSemicolon);
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
	public sealed class BlockRuleSyntax : RuleSyntax
	{
		private NameSyntax _name;
		private MetaDslx.CodeAnalysis.SyntaxNode _parserRuleAlternativeList;
	
	    public BlockRuleSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BlockRuleSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken IsBlock 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockRuleGreen)this.Green;
				var greenToken = green.IsBlock;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public NameSyntax Name => this.GetRed(ref this._name, 1);
	    public SyntaxToken TColon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockRuleGreen)this.Green;
				var greenToken = green.TColon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax> ParserRuleAlternativeList 
		{ 
			get
			{
				var red = this.GetRed(ref this._parserRuleAlternativeList, 3);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax>(red, this.GetChildIndex(3), reversed: false);
				}
				return default;
			} 
		}
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockRuleGreen)this.Green;
				var greenToken = green.TSemicolon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._name, 1);
				case 3: return this.GetRed(ref this._parserRuleAlternativeList, 3);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._name;
				case 3: return this._parserRuleAlternativeList;
				default: return null;
	        }
	    }
	
	    public BlockRuleSyntax WithIsBlock(SyntaxToken isBlock)
		{
			return this.Update(isBlock, this.Name, this.TColon, this.ParserRuleAlternativeList, this.TSemicolon);
		}
	
	    public BlockRuleSyntax WithName(NameSyntax name)
		{
			return this.Update(this.IsBlock, name, this.TColon, this.ParserRuleAlternativeList, this.TSemicolon);
		}
	
	    public BlockRuleSyntax WithTColon(SyntaxToken tColon)
		{
			return this.Update(this.IsBlock, this.Name, tColon, this.ParserRuleAlternativeList, this.TSemicolon);
		}
	
	    public BlockRuleSyntax WithParserRuleAlternativeList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax> parserRuleAlternativeList)
		{
			return this.Update(this.IsBlock, this.Name, this.TColon, parserRuleAlternativeList, this.TSemicolon);
		}
	
	    public BlockRuleSyntax AddParserRuleAlternativeList(params ParserRuleAlternativeSyntax[] parserRuleAlternativeList)
		{
			return this.WithParserRuleAlternativeList(this.ParserRuleAlternativeList.AddRange(parserRuleAlternativeList));
		}
	
	    public BlockRuleSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.IsBlock, this.Name, this.TColon, this.ParserRuleAlternativeList, tSemicolon);
		}
	
	    public BlockRuleSyntax Update(SyntaxToken isBlock, NameSyntax name, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax> parserRuleAlternativeList, SyntaxToken tSemicolon)
	    {
	        if (this.IsBlock != isBlock || this.Name != name || this.TColon != tColon || this.ParserRuleAlternativeList != parserRuleAlternativeList || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.BlockRule(isBlock, name, tColon, parserRuleAlternativeList, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (BlockRuleSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBlockRule(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBlockRule(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitBlockRule(this);
	    }
	
	}
	public sealed class ParserRuleAlternativeSyntax : CompilerSyntaxNode
	{
		private ParserRuleAlternativeBlock1Syntax _parserRuleAlternativeBlock1;
		private MetaDslx.CodeAnalysis.SyntaxNode _elements;
		private ParserRuleAlternativeBlock2Syntax _parserRuleAlternativeBlock2;
	
	    public ParserRuleAlternativeSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserRuleAlternativeSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public ParserRuleAlternativeBlock1Syntax ParserRuleAlternativeBlock1 => this.GetRed(ref this._parserRuleAlternativeBlock1, 0);
	    public MetaDslx.CodeAnalysis.SyntaxList<ParserRuleElementSyntax> Elements 
		{ 
			get
			{
				var red = this.GetRed(ref this._elements, 1);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<ParserRuleElementSyntax>(red);
				return default;
			} 
		}
	    public ParserRuleAlternativeBlock2Syntax ParserRuleAlternativeBlock2 => this.GetRed(ref this._parserRuleAlternativeBlock2, 2);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._parserRuleAlternativeBlock1, 0);
				case 1: return this.GetRed(ref this._elements, 1);
				case 2: return this.GetRed(ref this._parserRuleAlternativeBlock2, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._parserRuleAlternativeBlock1;
				case 1: return this._elements;
				case 2: return this._parserRuleAlternativeBlock2;
				default: return null;
	        }
	    }
	
	    public ParserRuleAlternativeSyntax WithParserRuleAlternativeBlock1(ParserRuleAlternativeBlock1Syntax parserRuleAlternativeBlock1)
		{
			return this.Update(parserRuleAlternativeBlock1, this.Elements, this.ParserRuleAlternativeBlock2);
		}
	
	    public ParserRuleAlternativeSyntax WithElements(MetaDslx.CodeAnalysis.SyntaxList<ParserRuleElementSyntax> elements)
		{
			return this.Update(this.ParserRuleAlternativeBlock1, elements, this.ParserRuleAlternativeBlock2);
		}
	
	    public ParserRuleAlternativeSyntax AddElements(params ParserRuleElementSyntax[] elements)
		{
			return this.WithElements(this.Elements.AddRange(elements));
		}
	
	    public ParserRuleAlternativeSyntax WithParserRuleAlternativeBlock2(ParserRuleAlternativeBlock2Syntax parserRuleAlternativeBlock2)
		{
			return this.Update(this.ParserRuleAlternativeBlock1, this.Elements, parserRuleAlternativeBlock2);
		}
	
	    public ParserRuleAlternativeSyntax Update(ParserRuleAlternativeBlock1Syntax parserRuleAlternativeBlock1, MetaDslx.CodeAnalysis.SyntaxList<ParserRuleElementSyntax> elements, ParserRuleAlternativeBlock2Syntax parserRuleAlternativeBlock2)
	    {
	        if (this.ParserRuleAlternativeBlock1 != parserRuleAlternativeBlock1 || this.Elements != elements || this.ParserRuleAlternativeBlock2 != parserRuleAlternativeBlock2)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserRuleAlternative(parserRuleAlternativeBlock1, elements, parserRuleAlternativeBlock2);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleAlternativeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserRuleAlternative(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserRuleAlternative(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserRuleAlternative(this);
	    }
	
	}
	public sealed class ParserRuleElementSyntax : CompilerSyntaxNode
	{
		private NameSyntax _name;
	
	    public ParserRuleElementSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserRuleElementSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public NameSyntax Name => this.GetRed(ref this._name, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._name, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._name;
				default: return null;
	        }
	    }
	
	    public ParserRuleElementSyntax WithName(NameSyntax name)
		{
			return this.Update(name);
		}
	
	    public ParserRuleElementSyntax Update(NameSyntax name)
	    {
	        if (this.Name != name)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserRuleElement(name);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleElementSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserRuleElement(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserRuleElement(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserRuleElement(this);
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
	
	public sealed class IntExpressionSyntax : ExpressionSyntax
	{
	
	    public IntExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public IntExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken IntValue 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.IntExpressionGreen)this.Green;
				var greenToken = green.IntValue;
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
	
	    public IntExpressionSyntax WithIntValue(SyntaxToken intValue)
		{
			return this.Update(intValue);
		}
	
	    public IntExpressionSyntax Update(SyntaxToken intValue)
	    {
	        if (this.IntValue != intValue)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.IntExpression(intValue);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (IntExpressionSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitIntExpression(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitIntExpression(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitIntExpression(this);
	    }
	
	}
	public sealed class StringExpressionSyntax : ExpressionSyntax
	{
	
	    public StringExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public StringExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken StringValue 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.StringExpressionGreen)this.Green;
				var greenToken = green.StringValue;
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
	
	    public StringExpressionSyntax WithStringValue(SyntaxToken stringValue)
		{
			return this.Update(stringValue);
		}
	
	    public StringExpressionSyntax Update(SyntaxToken stringValue)
	    {
	        if (this.StringValue != stringValue)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.StringExpression(stringValue);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (StringExpressionSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitStringExpression(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitStringExpression(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitStringExpression(this);
	    }
	
	}
	public sealed class ReferenceExpressionSyntax : ExpressionSyntax
	{
		private QualifierSyntax _qualifier;
	
	    public ReferenceExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ReferenceExpressionSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
	
	    public ReferenceExpressionSyntax WithQualifier(QualifierSyntax qualifier)
		{
			return this.Update(qualifier);
		}
	
	    public ReferenceExpressionSyntax Update(QualifierSyntax qualifier)
	    {
	        if (this.Qualifier != qualifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ReferenceExpression(qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ReferenceExpressionSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitReferenceExpression(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitReferenceExpression(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitReferenceExpression(this);
	    }
	
	}
	public sealed class ExpressionTokensSyntax : ExpressionSyntax
	{
	
	    public ExpressionTokensSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ExpressionTokensSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken Tokens 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ExpressionTokensGreen)this.Green;
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
	
	    public ExpressionTokensSyntax WithTokens(SyntaxToken tokens)
		{
			return this.Update(tokens);
		}
	
	    public ExpressionTokensSyntax Update(SyntaxToken tokens)
	    {
	        if (this.Tokens != tokens)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ExpressionTokens(tokens);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ExpressionTokensSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitExpressionTokens(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitExpressionTokens(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitExpressionTokens(this);
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
	public sealed class IdentifierSyntax : CompilerSyntaxNode
	{
	
	    public IdentifierSyntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public IdentifierSyntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.IdentifierGreen)this.Green;
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
	
	    public IdentifierSyntax WithTIdentifier(SyntaxToken tIdentifier)
		{
			return this.Update(tIdentifier);
		}
	
	    public IdentifierSyntax Update(SyntaxToken tIdentifier)
	    {
	        if (this.TIdentifier != tIdentifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Identifier(tIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (IdentifierSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitIdentifier(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitIdentifier(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitIdentifier(this);
	    }
	
	}
	public abstract class UsingBlock1Syntax : CompilerSyntaxNode
	{
	    protected UsingBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected UsingBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class UsingBlock1Alt1Syntax : UsingBlock1Syntax
	{
		private QualifierSyntax _namespaces;
	
	    public UsingBlock1Alt1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public UsingBlock1Alt1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public QualifierSyntax Namespaces => this.GetRed(ref this._namespaces, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._namespaces, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._namespaces;
				default: return null;
	        }
	    }
	
	    public UsingBlock1Alt1Syntax WithNamespaces(QualifierSyntax namespaces)
		{
			return this.Update(namespaces);
		}
	
	    public UsingBlock1Alt1Syntax Update(QualifierSyntax namespaces)
	    {
	        if (this.Namespaces != namespaces)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.UsingBlock1Alt1(namespaces);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (UsingBlock1Alt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitUsingBlock1Alt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitUsingBlock1Alt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitUsingBlock1Alt1(this);
	    }
	
	}
	public sealed class UsingBlock1Alt2Syntax : UsingBlock1Syntax
	{
		private QualifierSyntax _metaModels;
	
	    public UsingBlock1Alt2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public UsingBlock1Alt2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KMetamodel 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.UsingBlock1Alt2Green)this.Green;
				var greenToken = green.KMetamodel;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax MetaModels => this.GetRed(ref this._metaModels, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._metaModels, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._metaModels;
				default: return null;
	        }
	    }
	
	    public UsingBlock1Alt2Syntax WithKMetamodel(SyntaxToken kMetamodel)
		{
			return this.Update(kMetamodel, this.MetaModels);
		}
	
	    public UsingBlock1Alt2Syntax WithMetaModels(QualifierSyntax metaModels)
		{
			return this.Update(this.KMetamodel, metaModels);
		}
	
	    public UsingBlock1Alt2Syntax Update(SyntaxToken kMetamodel, QualifierSyntax metaModels)
	    {
	        if (this.KMetamodel != kMetamodel || this.MetaModels != metaModels)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.UsingBlock1Alt2(kMetamodel, metaModels);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (UsingBlock1Alt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitUsingBlock1Alt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitUsingBlock1Alt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitUsingBlock1Alt2(this);
	    }
	
	}
	public sealed class ParserRuleBlock1Syntax : CompilerSyntaxNode
	{
		private QualifierSyntax _returnType;
	
	    public ParserRuleBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserRuleBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KReturns 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserRuleBlock1Green)this.Green;
				var greenToken = green.KReturns;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax ReturnType => this.GetRed(ref this._returnType, 1);
	
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
	
	    public ParserRuleBlock1Syntax WithKReturns(SyntaxToken kReturns)
		{
			return this.Update(kReturns, this.ReturnType);
		}
	
	    public ParserRuleBlock1Syntax WithReturnType(QualifierSyntax returnType)
		{
			return this.Update(this.KReturns, returnType);
		}
	
	    public ParserRuleBlock1Syntax Update(SyntaxToken kReturns, QualifierSyntax returnType)
	    {
	        if (this.KReturns != kReturns || this.ReturnType != returnType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserRuleBlock1(kReturns, returnType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserRuleBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserRuleBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserRuleBlock1(this);
	    }
	
	}
	public sealed class ParserRuleBlock2Syntax : CompilerSyntaxNode
	{
		private ParserRuleAlternativeSyntax _alternatives;
	
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
	    public ParserRuleAlternativeSyntax Alternatives => this.GetRed(ref this._alternatives, 1);
	
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
	
	    public ParserRuleBlock2Syntax WithAlternatives(ParserRuleAlternativeSyntax alternatives)
		{
			return this.Update(this.TBar, alternatives);
		}
	
	    public ParserRuleBlock2Syntax Update(SyntaxToken tBar, ParserRuleAlternativeSyntax alternatives)
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
	public sealed class BlockRuleBlock1Syntax : CompilerSyntaxNode
	{
		private ParserRuleAlternativeSyntax _alternatives;
	
	    public BlockRuleBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BlockRuleBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TBar 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockRuleBlock1Green)this.Green;
				var greenToken = green.TBar;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public ParserRuleAlternativeSyntax Alternatives => this.GetRed(ref this._alternatives, 1);
	
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
	
	    public BlockRuleBlock1Syntax WithTBar(SyntaxToken tBar)
		{
			return this.Update(tBar, this.Alternatives);
		}
	
	    public BlockRuleBlock1Syntax WithAlternatives(ParserRuleAlternativeSyntax alternatives)
		{
			return this.Update(this.TBar, alternatives);
		}
	
	    public BlockRuleBlock1Syntax Update(SyntaxToken tBar, ParserRuleAlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.BlockRuleBlock1(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (BlockRuleBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBlockRuleBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBlockRuleBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitBlockRuleBlock1(this);
	    }
	
	}
	public sealed class ParserRuleAlternativeBlock1Syntax : CompilerSyntaxNode
	{
		private QualifierSyntax _returnType;
	
	    public ParserRuleAlternativeBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserRuleAlternativeBlock1Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TLBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserRuleAlternativeBlock1Green)this.Green;
				var greenToken = green.TLBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax ReturnType => this.GetRed(ref this._returnType, 1);
	    public SyntaxToken TRBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserRuleAlternativeBlock1Green)this.Green;
				var greenToken = green.TRBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
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
	
	    public ParserRuleAlternativeBlock1Syntax WithTLBrace(SyntaxToken tLBrace)
		{
			return this.Update(tLBrace, this.ReturnType, this.TRBrace);
		}
	
	    public ParserRuleAlternativeBlock1Syntax WithReturnType(QualifierSyntax returnType)
		{
			return this.Update(this.TLBrace, returnType, this.TRBrace);
		}
	
	    public ParserRuleAlternativeBlock1Syntax WithTRBrace(SyntaxToken tRBrace)
		{
			return this.Update(this.TLBrace, this.ReturnType, tRBrace);
		}
	
	    public ParserRuleAlternativeBlock1Syntax Update(SyntaxToken tLBrace, QualifierSyntax returnType, SyntaxToken tRBrace)
	    {
	        if (this.TLBrace != tLBrace || this.ReturnType != returnType || this.TRBrace != tRBrace)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserRuleAlternativeBlock1(tLBrace, returnType, tRBrace);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleAlternativeBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserRuleAlternativeBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserRuleAlternativeBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserRuleAlternativeBlock1(this);
	    }
	
	}
	public sealed class ParserRuleAlternativeBlock2Syntax : CompilerSyntaxNode
	{
		private ExpressionSyntax _returnValue;
	
	    public ParserRuleAlternativeBlock2Syntax(InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserRuleAlternativeBlock2Syntax(InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TEqGt 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserRuleAlternativeBlock2Green)this.Green;
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
	
	    public ParserRuleAlternativeBlock2Syntax WithTEqGt(SyntaxToken tEqGt)
		{
			return this.Update(tEqGt, this.ReturnValue);
		}
	
	    public ParserRuleAlternativeBlock2Syntax WithReturnValue(ExpressionSyntax returnValue)
		{
			return this.Update(this.TEqGt, returnValue);
		}
	
	    public ParserRuleAlternativeBlock2Syntax Update(SyntaxToken tEqGt, ExpressionSyntax returnValue)
	    {
	        if (this.TEqGt != tEqGt || this.ReturnValue != returnValue)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserRuleAlternativeBlock2(tEqGt, returnValue);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParserRuleAlternativeBlock2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserRuleAlternativeBlock2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserRuleAlternativeBlock2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserRuleAlternativeBlock2(this);
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
}
