#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
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
	using __IncrementalParseData = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.IncrementalParseData;
	using __SyntaxTree = global::MetaDslx.CodeAnalysis.SyntaxTree;
	using __SyntaxToken = global::MetaDslx.CodeAnalysis.SyntaxToken;
	using __SyntaxTrivia = global::MetaDslx.CodeAnalysis.SyntaxTrivia;
	using __SyntaxNode = global::MetaDslx.CodeAnalysis.SyntaxNode;
    using __SyntaxTokenList = global::MetaDslx.CodeAnalysis.SyntaxTokenList;
    using __SyntaxExtensions = global::MetaDslx.CodeAnalysis.SyntaxExtensions;

    public abstract class CompilerSyntaxNode : __SyntaxNode
    {
        protected CompilerSyntaxNode(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }

        protected CompilerSyntaxNode(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public override __Language Language => CompilerLanguage.Instance;
        public CompilerSyntaxKind Kind => (CompilerSyntaxKind)this.RawKind;
		internal new __GreenNode Green => base.Green;

        protected override __SyntaxTree CreateSyntaxTreeForRoot()
        {
            return CompilerSyntaxTree.CreateWithoutClone(this, __IncrementalParseData.Empty);
        }

        public override TResult Accept<TArg, TResult>(global::MetaDslx.CodeAnalysis.SyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            if (visitor is ICompilerSyntaxVisitor<TArg, TResult> typedVisitor) return this.Accept(typedVisitor, argument);
            else return visitor.DefaultVisit(this, argument);
        }

        public abstract TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument);

        public override TResult Accept<TResult>(global::MetaDslx.CodeAnalysis.SyntaxVisitor<TResult> visitor)
        {
            if (visitor is ICompilerSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor);

        public override void Accept(global::MetaDslx.CodeAnalysis.SyntaxVisitor visitor)
        {
            if (visitor is ICompilerSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }
        public abstract void Accept(ICompilerSyntaxVisitor visitor);
    }

    /// <summary>
    /// It's a non terminal Trivia CompilerSyntaxNode that has a tree underneath it.
    /// </summary>
    public abstract partial class CompilerStructuredTriviaSyntax : CompilerSyntaxNode, global::MetaDslx.CodeAnalysis.IStructuredTriviaSyntax
    {
        private __SyntaxTrivia _parent;
        internal CompilerStructuredTriviaSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent == null ? null : (CompilerSyntaxTree)parent.SyntaxTree, position)
        {
            System.Diagnostics.Debug.Assert(parent == null || position >= 0);
        }
		internal static CompilerStructuredTriviaSyntax Create(__SyntaxTrivia trivia)
		{
			var red = (CompilerStructuredTriviaSyntax)CompilerLanguage.Instance.SyntaxFactory.CreateStructure(trivia);
			red._parent = trivia;
			return red;
		}
        /// <summary>
        /// Get parent trivia.
        /// </summary>
        public override __SyntaxTrivia ParentTrivia => _parent;
    }

    public sealed partial class CompilerSkippedTokensTriviaSyntax : CompilerStructuredTriviaSyntax
    {
        internal CompilerSkippedTokensTriviaSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public __SyntaxTokenList Tokens 
        {
            get
            {
				var slot = ((global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.GreenSkippedTokensTriviaSyntax)this.Green).Tokens;
				if (slot != null)
				{
					return new __SyntaxTokenList(this, slot.Node, this.GetChildPosition(0), this.GetChildIndex(0));
				}
                return default;
            }
        }

        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                default: return null;
            }
        }

		protected override __SyntaxNode GetCachedSlot(int index)
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

        public CompilerSkippedTokensTriviaSyntax Update(__SyntaxTokenList tokens)
        {
            if (tokens != this.Tokens)
            {
                var newNode = (CompilerSkippedTokensTriviaSyntax)Language.SyntaxFactory.SkippedTokensTrivia(tokens);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    return __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return newNode;
            }
            return this;
        }

        public CompilerSkippedTokensTriviaSyntax WithTokens(__SyntaxTokenList tokens)
        {
            return this.Update(tokens);
        }

        public CompilerSkippedTokensTriviaSyntax AddTokens(params __SyntaxToken[] items)
        {
            return this.WithTokens(this.Tokens.AddRange(items));
        }
    }

	
	public sealed class MainSyntax : CompilerSyntaxNode, global::MetaDslx.CodeAnalysis.ICompilationUnitSyntax
	{
		private __SyntaxNode _qualifier;
		private __SyntaxNode _usingList;
		private MainBlock1Syntax _block;
	
	    public MainSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MainSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KNamespace 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
	var greenToken = green.KNamespace;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> Qualifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._qualifier, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public __SyntaxToken TSemicolon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> UsingList 
		{ 
		get
		{
				var red = this.GetRed(ref this._usingList, 3);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax>(red);
	} 
	}
	public MainBlock1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 4);
	return red;
	} 
	}
	public __SyntaxToken EndOfFileToken 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
	var greenToken = green.EndOfFileToken;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._qualifier, 1);
			case 3: return this.GetRed(ref this._usingList, 3);
			case 4: return this.GetRed(ref this._block, 4);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._qualifier;
			case 3: return this._usingList;
			case 4: return this._block;
			default: return null;
	        }
	    }
	
	public MainSyntax WithKNamespace(__SyntaxToken kNamespace)
		{
		return this.Update(kNamespace, this.Qualifier, this.TSemicolon, this.UsingList, this.Block, this.EndOfFileToken);
	}
	
	public MainSyntax WithQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
		{
		return this.Update(this.KNamespace, qualifier, this.TSemicolon, this.UsingList, this.Block, this.EndOfFileToken);
	}
	
	public MainSyntax AddQualifier(params IdentifierSyntax[] qualifier)
		{
		return this.WithQualifier(this.Qualifier.AddRange(qualifier));
	}
	
	public MainSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.KNamespace, this.Qualifier, tSemicolon, this.UsingList, this.Block, this.EndOfFileToken);
	}
	
	public MainSyntax WithUsingList(global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList)
		{
		return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, usingList, this.Block, this.EndOfFileToken);
	}
	
	public MainSyntax AddUsingList(params UsingSyntax[] usingList)
		{
		return this.WithUsingList(this.UsingList.AddRange(usingList));
	}
	
	public MainSyntax WithBlock(MainBlock1Syntax block)
		{
		return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, this.UsingList, block, this.EndOfFileToken);
	}
	
	public MainSyntax WithEndOfFileToken(__SyntaxToken endOfFileToken)
		{
		return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, this.UsingList, this.Block, endOfFileToken);
	}
	
	    public MainSyntax Update(__SyntaxToken kNamespace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, __SyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MainBlock1Syntax block, __SyntaxToken endOfFileToken)
	    {
	        if (this.KNamespace != kNamespace || this.Qualifier != qualifier || this.TSemicolon != tSemicolon || this.UsingList != usingList || this.Block != block || this.EndOfFileToken != endOfFileToken)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Main(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
		private __SyntaxNode _qualifier;
	
	    public UsingSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public UsingSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KUsing 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
	var greenToken = green.KUsing;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> Qualifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._qualifier, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public __SyntaxToken TSemicolon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._qualifier, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._qualifier;
			default: return null;
	        }
	    }
	
	public UsingSyntax WithKUsing(__SyntaxToken kUsing)
		{
		return this.Update(kUsing, this.Qualifier, this.TSemicolon);
	}
	
	public UsingSyntax WithQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
		{
		return this.Update(this.KUsing, qualifier, this.TSemicolon);
	}
	
	public UsingSyntax AddQualifier(params IdentifierSyntax[] qualifier)
		{
		return this.WithQualifier(this.Qualifier.AddRange(qualifier));
	}
	
	public UsingSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.KUsing, this.Qualifier, tSemicolon);
	}
	
	    public UsingSyntax Update(__SyntaxToken kUsing, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, __SyntaxToken tSemicolon)
	    {
	        if (this.KUsing != kUsing || this.Qualifier != qualifier || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Using(kUsing, qualifier, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	
	public sealed class LanguageDeclarationSyntax : CompilerSyntaxNode
	{
		private NameSyntax _name;
		private GrammarSyntax _grammar;
	
	    public LanguageDeclarationSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LanguageDeclarationSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KLanguage 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LanguageDeclarationGreen)this.Green;
	var greenToken = green.KLanguage;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public NameSyntax Name 
		{ 
		get
		{
				var red = this.GetRed(ref this._name, 1);
	return red;
	} 
	}
	public __SyntaxToken TSemicolon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LanguageDeclarationGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	public GrammarSyntax Grammar 
		{ 
		get
		{
				var red = this.GetRed(ref this._grammar, 3);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._name, 1);
			case 3: return this.GetRed(ref this._grammar, 3);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._name;
			case 3: return this._grammar;
			default: return null;
	        }
	    }
	
	public LanguageDeclarationSyntax WithKLanguage(__SyntaxToken kLanguage)
		{
		return this.Update(kLanguage, this.Name, this.TSemicolon, this.Grammar);
	}
	
	public LanguageDeclarationSyntax WithName(NameSyntax name)
		{
		return this.Update(this.KLanguage, name, this.TSemicolon, this.Grammar);
	}
	
	public LanguageDeclarationSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.KLanguage, this.Name, tSemicolon, this.Grammar);
	}
	
	public LanguageDeclarationSyntax WithGrammar(GrammarSyntax grammar)
		{
		return this.Update(this.KLanguage, this.Name, this.TSemicolon, grammar);
	}
	
	    public LanguageDeclarationSyntax Update(__SyntaxToken kLanguage, NameSyntax name, __SyntaxToken tSemicolon, GrammarSyntax grammar)
	    {
	        if (this.KLanguage != kLanguage || this.Name != name || this.TSemicolon != tSemicolon || this.Grammar != grammar)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LanguageDeclaration(kLanguage, name, tSemicolon, grammar);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
		private __SyntaxNode _grammarRules;
	
	    public GrammarSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public GrammarSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SyntaxList<GrammarRuleSyntax> GrammarRules 
		{ 
		get
		{
				var red = this.GetRed(ref this._grammarRules, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<GrammarRuleSyntax>(red);
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._grammarRules, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._grammarRules;
			default: return null;
	        }
	    }
	
	public GrammarSyntax WithGrammarRules(global::MetaDslx.CodeAnalysis.SyntaxList<GrammarRuleSyntax> grammarRules)
		{
		return this.Update(grammarRules);
	}
	
	public GrammarSyntax AddGrammarRules(params GrammarRuleSyntax[] grammarRules)
		{
		return this.WithGrammarRules(this.GrammarRules.AddRange(grammarRules));
	}
	
	    public GrammarSyntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<GrammarRuleSyntax> grammarRules)
	    {
	        if (this.GrammarRules != grammarRules)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Grammar(grammarRules);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	public abstract class GrammarRuleSyntax : CompilerSyntaxNode
	{
	    protected GrammarRuleSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected GrammarRuleSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class RuleSyntax : GrammarRuleSyntax
	{
		private __SyntaxNode _annotations1;
		private RuleBlock1Syntax _block;
		private __SyntaxNode _alternatives;
	
	    public RuleSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public RuleSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> Annotations1 
		{ 
		get
		{
				var red = this.GetRed(ref this._annotations1, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax>(red);
	} 
	}
	public RuleBlock1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 1);
	return red;
	} 
	}
	public __SyntaxToken TColon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleGreen)this.Green;
	var greenToken = green.TColon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 3);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax>(red, this.GetChildIndex(3), reversed: false);
	} 
	}
	public __SyntaxToken TSemicolon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._annotations1, 0);
			case 1: return this.GetRed(ref this._block, 1);
			case 3: return this.GetRed(ref this._alternatives, 3);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._annotations1;
			case 1: return this._block;
			case 3: return this._alternatives;
			default: return null;
	        }
	    }
	
	public RuleSyntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
		{
		return this.Update(annotations1, this.Block, this.TColon, this.Alternatives, this.TSemicolon);
	}
	
	public RuleSyntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
		{
		return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
	}
	
	public RuleSyntax WithBlock(RuleBlock1Syntax block)
		{
		return this.Update(this.Annotations1, block, this.TColon, this.Alternatives, this.TSemicolon);
	}
	
	public RuleSyntax WithTColon(__SyntaxToken tColon)
		{
		return this.Update(this.Annotations1, this.Block, tColon, this.Alternatives, this.TSemicolon);
	}
	
	public RuleSyntax WithAlternatives(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives)
		{
		return this.Update(this.Annotations1, this.Block, this.TColon, alternatives, this.TSemicolon);
	}
	
	public RuleSyntax AddAlternatives(params AlternativeSyntax[] alternatives)
		{
		return this.WithAlternatives(this.Alternatives.AddRange(alternatives));
	}
	
	public RuleSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.Annotations1, this.Block, this.TColon, this.Alternatives, tSemicolon);
	}
	
	    public RuleSyntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, RuleBlock1Syntax block, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
	    {
	        if (this.Annotations1 != annotations1 || this.Block != block || this.TColon != tColon || this.Alternatives != alternatives || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Rule(annotations1, block, tColon, alternatives, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (RuleSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitRule(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitRule(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitRule(this);
	    }
	
	}
	public sealed class TokenSyntax : GrammarRuleSyntax
	{
		private __SyntaxNode _annotations1;
		private TokenBlock1Syntax _block;
		private __SyntaxNode _alternatives;
	
	    public TokenSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TokenSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> Annotations1 
		{ 
		get
		{
				var red = this.GetRed(ref this._annotations1, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax>(red);
	} 
	}
	public TokenBlock1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 1);
	return red;
	} 
	}
	public __SyntaxToken TColon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenGreen)this.Green;
	var greenToken = green.TColon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 3);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax>(red, this.GetChildIndex(3), reversed: false);
	} 
	}
	public __SyntaxToken TSemicolon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._annotations1, 0);
			case 1: return this.GetRed(ref this._block, 1);
			case 3: return this.GetRed(ref this._alternatives, 3);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._annotations1;
			case 1: return this._block;
			case 3: return this._alternatives;
			default: return null;
	        }
	    }
	
	public TokenSyntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1)
		{
		return this.Update(annotations1, this.Block, this.TColon, this.Alternatives, this.TSemicolon);
	}
	
	public TokenSyntax AddAnnotations1(params LexerAnnotationSyntax[] annotations1)
		{
		return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
	}
	
	public TokenSyntax WithBlock(TokenBlock1Syntax block)
		{
		return this.Update(this.Annotations1, block, this.TColon, this.Alternatives, this.TSemicolon);
	}
	
	public TokenSyntax WithTColon(__SyntaxToken tColon)
		{
		return this.Update(this.Annotations1, this.Block, tColon, this.Alternatives, this.TSemicolon);
	}
	
	public TokenSyntax WithAlternatives(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
		{
		return this.Update(this.Annotations1, this.Block, this.TColon, alternatives, this.TSemicolon);
	}
	
	public TokenSyntax AddAlternatives(params LAlternativeSyntax[] alternatives)
		{
		return this.WithAlternatives(this.Alternatives.AddRange(alternatives));
	}
	
	public TokenSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.Annotations1, this.Block, this.TColon, this.Alternatives, tSemicolon);
	}
	
	    public TokenSyntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, TokenBlock1Syntax block, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
	    {
	        if (this.Annotations1 != annotations1 || this.Block != block || this.TColon != tColon || this.Alternatives != alternatives || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Token(annotations1, block, tColon, alternatives, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (TokenSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitToken(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitToken(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitToken(this);
	    }
	
	}
	public sealed class FragmentSyntax : GrammarRuleSyntax
	{
		private NameSyntax _name;
		private __SyntaxNode _alternatives;
	
	    public FragmentSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public FragmentSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KFragment 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.FragmentGreen)this.Green;
	var greenToken = green.KFragment;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public NameSyntax Name 
		{ 
		get
		{
				var red = this.GetRed(ref this._name, 1);
	return red;
	} 
	}
	public __SyntaxToken TColon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.FragmentGreen)this.Green;
	var greenToken = green.TColon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 3);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax>(red, this.GetChildIndex(3), reversed: false);
	} 
	}
	public __SyntaxToken TSemicolon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.FragmentGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._name, 1);
			case 3: return this.GetRed(ref this._alternatives, 3);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._name;
			case 3: return this._alternatives;
			default: return null;
	        }
	    }
	
	public FragmentSyntax WithKFragment(__SyntaxToken kFragment)
		{
		return this.Update(kFragment, this.Name, this.TColon, this.Alternatives, this.TSemicolon);
	}
	
	public FragmentSyntax WithName(NameSyntax name)
		{
		return this.Update(this.KFragment, name, this.TColon, this.Alternatives, this.TSemicolon);
	}
	
	public FragmentSyntax WithTColon(__SyntaxToken tColon)
		{
		return this.Update(this.KFragment, this.Name, tColon, this.Alternatives, this.TSemicolon);
	}
	
	public FragmentSyntax WithAlternatives(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
		{
		return this.Update(this.KFragment, this.Name, this.TColon, alternatives, this.TSemicolon);
	}
	
	public FragmentSyntax AddAlternatives(params LAlternativeSyntax[] alternatives)
		{
		return this.WithAlternatives(this.Alternatives.AddRange(alternatives));
	}
	
	public FragmentSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.KFragment, this.Name, this.TColon, this.Alternatives, tSemicolon);
	}
	
	    public FragmentSyntax Update(__SyntaxToken kFragment, NameSyntax name, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
	    {
	        if (this.KFragment != kFragment || this.Name != name || this.TColon != tColon || this.Alternatives != alternatives || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Fragment(kFragment, name, tColon, alternatives, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (FragmentSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitFragment(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitFragment(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitFragment(this);
	    }
	
	}
	
	public sealed class AlternativeSyntax : CompilerSyntaxNode
	{
		private AlternativeBlock1Syntax _block1;
		private __SyntaxNode _elements;
		private AlternativeBlock2Syntax _block2;
	
	    public AlternativeSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AlternativeSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public AlternativeBlock1Syntax Block1 
		{ 
		get
		{
				var red = this.GetRed(ref this._block1, 0);
	return red;
	} 
	}
	public global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> Elements 
		{ 
		get
		{
				var red = this.GetRed(ref this._elements, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax>(red);
	} 
	}
	public AlternativeBlock2Syntax Block2 
		{ 
		get
		{
				var red = this.GetRed(ref this._block2, 2);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._block1, 0);
			case 1: return this.GetRed(ref this._elements, 1);
			case 2: return this.GetRed(ref this._block2, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._block1;
			case 1: return this._elements;
			case 2: return this._block2;
			default: return null;
	        }
	    }
	
	public AlternativeSyntax WithBlock1(AlternativeBlock1Syntax block1)
		{
		return this.Update(block1, this.Elements, this.Block2);
	}
	
	public AlternativeSyntax WithElements(global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements)
		{
		return this.Update(this.Block1, elements, this.Block2);
	}
	
	public AlternativeSyntax AddElements(params ElementSyntax[] elements)
		{
		return this.WithElements(this.Elements.AddRange(elements));
	}
	
	public AlternativeSyntax WithBlock2(AlternativeBlock2Syntax block2)
		{
		return this.Update(this.Block1, this.Elements, block2);
	}
	
	    public AlternativeSyntax Update(AlternativeBlock1Syntax block1, global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements, AlternativeBlock2Syntax block2)
	    {
	        if (this.Block1 != block1 || this.Elements != elements || this.Block2 != block2)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Alternative(block1, elements, block2);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (AlternativeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitAlternative(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitAlternative(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitAlternative(this);
	    }
	
	}
	
	public sealed class ElementSyntax : CompilerSyntaxNode
	{
		private ElementBlock1Syntax _block;
		private ElementValueSyntax _value;
	
	    public ElementSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ElementSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public ElementBlock1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 0);
	return red;
	} 
	}
	public ElementValueSyntax Value 
		{ 
		get
		{
				var red = this.GetRed(ref this._value, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._block, 0);
			case 1: return this.GetRed(ref this._value, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._block;
			case 1: return this._value;
			default: return null;
	        }
	    }
	
	public ElementSyntax WithBlock(ElementBlock1Syntax block)
		{
		return this.Update(block, this.Value);
	}
	
	public ElementSyntax WithValue(ElementValueSyntax value)
		{
		return this.Update(this.Block, value);
	}
	
	    public ElementSyntax Update(ElementBlock1Syntax block, ElementValueSyntax value)
	    {
	        if (this.Block != block || this.Value != value)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Element(block, value);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ElementSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitElement(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitElement(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitElement(this);
	    }
	
	}
	
	public sealed class ElementValueSyntax : CompilerSyntaxNode
	{
		private __SyntaxNode _annotations1;
		private ElementValueBlock1Syntax _block;
	
	    public ElementValueSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ElementValueSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> Annotations1 
		{ 
		get
		{
				var red = this.GetRed(ref this._annotations1, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax>(red);
	} 
	}
	public ElementValueBlock1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 1);
	return red;
	} 
	}
	public __SyntaxToken Multiplicity 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ElementValueGreen)this.Green;
	var greenToken = green.Multiplicity;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._annotations1, 0);
			case 1: return this.GetRed(ref this._block, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._annotations1;
			case 1: return this._block;
			default: return null;
	        }
	    }
	
	public ElementValueSyntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
		{
		return this.Update(annotations1, this.Block, this.Multiplicity);
	}
	
	public ElementValueSyntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
		{
		return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
	}
	
	public ElementValueSyntax WithBlock(ElementValueBlock1Syntax block)
		{
		return this.Update(this.Annotations1, block, this.Multiplicity);
	}
	
	public ElementValueSyntax WithMultiplicity(__SyntaxToken multiplicity)
		{
		return this.Update(this.Annotations1, this.Block, multiplicity);
	}
	
	    public ElementValueSyntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, ElementValueBlock1Syntax block, __SyntaxToken multiplicity)
	    {
	        if (this.Annotations1 != annotations1 || this.Block != block || this.Multiplicity != multiplicity)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ElementValue(annotations1, block, multiplicity);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ElementValueSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitElementValue(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitElementValue(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitElementValue(this);
	    }
	
	}
	
	public sealed class BlockAlternativeSyntax : CompilerSyntaxNode
	{
		private __SyntaxNode _elements;
		private BlockAlternativeBlock1Syntax _block;
	
	    public BlockAlternativeSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BlockAlternativeSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> Elements 
		{ 
		get
		{
				var red = this.GetRed(ref this._elements, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax>(red);
	} 
	}
	public BlockAlternativeBlock1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._elements, 0);
			case 1: return this.GetRed(ref this._block, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._elements;
			case 1: return this._block;
			default: return null;
	        }
	    }
	
	public BlockAlternativeSyntax WithElements(global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements)
		{
		return this.Update(elements, this.Block);
	}
	
	public BlockAlternativeSyntax AddElements(params ElementSyntax[] elements)
		{
		return this.WithElements(this.Elements.AddRange(elements));
	}
	
	public BlockAlternativeSyntax WithBlock(BlockAlternativeBlock1Syntax block)
		{
		return this.Update(this.Elements, block);
	}
	
	    public BlockAlternativeSyntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements, BlockAlternativeBlock1Syntax block)
	    {
	        if (this.Elements != elements || this.Block != block)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.BlockAlternative(elements, block);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (BlockAlternativeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBlockAlternative(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBlockAlternative(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitBlockAlternative(this);
	    }
	
	}
	
	public sealed class LAlternativeSyntax : CompilerSyntaxNode
	{
		private __SyntaxNode _elements;
	
	    public LAlternativeSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LAlternativeSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax> Elements 
		{ 
		get
		{
				var red = this.GetRed(ref this._elements, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax>(red);
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._elements, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._elements;
			default: return null;
	        }
	    }
	
	public LAlternativeSyntax WithElements(global::MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax> elements)
		{
		return this.Update(elements);
	}
	
	public LAlternativeSyntax AddElements(params LElementSyntax[] elements)
		{
		return this.WithElements(this.Elements.AddRange(elements));
	}
	
	    public LAlternativeSyntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax> elements)
	    {
	        if (this.Elements != elements)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LAlternative(elements);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	
	    public LElementSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LElementSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken IsNegated 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LElementGreen)this.Green;
	var greenToken = green.IsNegated;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public LElementValueSyntax Value 
		{ 
		get
		{
				var red = this.GetRed(ref this._value, 1);
	return red;
	} 
	}
	public __SyntaxToken Multiplicity 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LElementGreen)this.Green;
	var greenToken = green.Multiplicity;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._value, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._value;
			default: return null;
	        }
	    }
	
	public LElementSyntax WithIsNegated(__SyntaxToken isNegated)
		{
		return this.Update(isNegated, this.Value, this.Multiplicity);
	}
	
	public LElementSyntax WithValue(LElementValueSyntax value)
		{
		return this.Update(this.IsNegated, value, this.Multiplicity);
	}
	
	public LElementSyntax WithMultiplicity(__SyntaxToken multiplicity)
		{
		return this.Update(this.IsNegated, this.Value, multiplicity);
	}
	
	    public LElementSyntax Update(__SyntaxToken isNegated, LElementValueSyntax value, __SyntaxToken multiplicity)
	    {
	        if (this.IsNegated != isNegated || this.Value != value || this.Multiplicity != multiplicity)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LElement(isNegated, value, multiplicity);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	    protected LElementValueSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected LElementValueSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class LElementValueTokensSyntax : LElementValueSyntax
	{
	
	    public LElementValueTokensSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LElementValueTokensSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Token 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LElementValueTokensGreen)this.Green;
	var greenToken = green.Token;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	public LElementValueTokensSyntax WithToken(__SyntaxToken token)
		{
		return this.Update(token);
	}
	
	    public LElementValueTokensSyntax Update(__SyntaxToken token)
	    {
	        if (this.Token != token)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LElementValueTokens(token);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (LElementValueTokensSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLElementValueTokens(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLElementValueTokens(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLElementValueTokens(this);
	    }
	
	}
	public sealed class LBlockSyntax : LElementValueSyntax
	{
		private __SyntaxNode _alternatives;
	
	    public LBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TLParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LBlockGreen)this.Green;
	var greenToken = green.TLParen;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public __SyntaxToken TRParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LBlockGreen)this.Green;
	var greenToken = green.TRParen;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._alternatives, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._alternatives;
			default: return null;
	        }
	    }
	
	public LBlockSyntax WithTLParen(__SyntaxToken tLParen)
		{
		return this.Update(tLParen, this.Alternatives, this.TRParen);
	}
	
	public LBlockSyntax WithAlternatives(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
		{
		return this.Update(this.TLParen, alternatives, this.TRParen);
	}
	
	public LBlockSyntax AddAlternatives(params LAlternativeSyntax[] alternatives)
		{
		return this.WithAlternatives(this.Alternatives.AddRange(alternatives));
	}
	
	public LBlockSyntax WithTRParen(__SyntaxToken tRParen)
		{
		return this.Update(this.TLParen, this.Alternatives, tRParen);
	}
	
	    public LBlockSyntax Update(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tRParen)
	    {
	        if (this.TLParen != tLParen || this.Alternatives != alternatives || this.TRParen != tRParen)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LBlock(tLParen, alternatives, tRParen);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	public sealed class LRangeSyntax : LElementValueSyntax
	{
	
	    public LRangeSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LRangeSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken StartChar 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LRangeGreen)this.Green;
	var greenToken = green.StartChar;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public __SyntaxToken TDotDot 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LRangeGreen)this.Green;
	var greenToken = green.TDotDot;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
	} 
	}
	public __SyntaxToken EndChar 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LRangeGreen)this.Green;
	var greenToken = green.EndChar;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	public LRangeSyntax WithStartChar(__SyntaxToken startChar)
		{
		return this.Update(startChar, this.TDotDot, this.EndChar);
	}
	
	public LRangeSyntax WithTDotDot(__SyntaxToken tDotDot)
		{
		return this.Update(this.StartChar, tDotDot, this.EndChar);
	}
	
	public LRangeSyntax WithEndChar(__SyntaxToken endChar)
		{
		return this.Update(this.StartChar, this.TDotDot, endChar);
	}
	
	    public LRangeSyntax Update(__SyntaxToken startChar, __SyntaxToken tDotDot, __SyntaxToken endChar)
	    {
	        if (this.StartChar != startChar || this.TDotDot != tDotDot || this.EndChar != endChar)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LRange(startChar, tDotDot, endChar);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	
	    public LReferenceSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LReferenceSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public IdentifierSyntax Rule 
		{ 
		get
		{
				var red = this.GetRed(ref this._rule, 0);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._rule, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
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
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	    protected ExpressionSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ExpressionSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ExpressionAlt1Syntax : ExpressionSyntax
	{
		private SingleExpressionSyntax _singleExpression;
	
	    public ExpressionAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ExpressionAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public SingleExpressionSyntax SingleExpression 
		{ 
		get
		{
				var red = this.GetRed(ref this._singleExpression, 0);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._singleExpression, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
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
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
		private __SyntaxNode _items;
	
	    public ArrayExpressionSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ArrayExpressionSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TLBrace 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ArrayExpressionGreen)this.Green;
	var greenToken = green.TLBrace;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> Items 
		{ 
		get
		{
				var red = this.GetRed(ref this._items, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public __SyntaxToken TRBrace 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ArrayExpressionGreen)this.Green;
	var greenToken = green.TRBrace;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._items, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._items;
			default: return null;
	        }
	    }
	
	public ArrayExpressionSyntax WithTLBrace(__SyntaxToken tLBrace)
		{
		return this.Update(tLBrace, this.Items, this.TRBrace);
	}
	
	public ArrayExpressionSyntax WithItems(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> items)
		{
		return this.Update(this.TLBrace, items, this.TRBrace);
	}
	
	public ArrayExpressionSyntax AddItems(params SingleExpressionSyntax[] items)
		{
		return this.WithItems(this.Items.AddRange(items));
	}
	
	public ArrayExpressionSyntax WithTRBrace(__SyntaxToken tRBrace)
		{
		return this.Update(this.TLBrace, this.Items, tRBrace);
	}
	
	    public ArrayExpressionSyntax Update(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> items, __SyntaxToken tRBrace)
	    {
	        if (this.TLBrace != tLBrace || this.Items != items || this.TRBrace != tRBrace)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ArrayExpression(tLBrace, items, tRBrace);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	
	    public SingleExpressionSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SingleExpressionSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public SingleExpressionBlock1Syntax Value 
		{ 
		get
		{
				var red = this.GetRed(ref this._value, 0);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._value, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
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
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
		private __SyntaxNode _qualifier;
		private ParserAnnotationBlock1Syntax _block;
	
	    public ParserAnnotationSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserAnnotationSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TLBracket 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationGreen)this.Green;
	var greenToken = green.TLBracket;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> Qualifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._qualifier, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public ParserAnnotationBlock1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 2);
	return red;
	} 
	}
	public __SyntaxToken TRBracket 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationGreen)this.Green;
	var greenToken = green.TRBracket;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._qualifier, 1);
			case 2: return this.GetRed(ref this._block, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._qualifier;
			case 2: return this._block;
			default: return null;
	        }
	    }
	
	public ParserAnnotationSyntax WithTLBracket(__SyntaxToken tLBracket)
		{
		return this.Update(tLBracket, this.Qualifier, this.Block, this.TRBracket);
	}
	
	public ParserAnnotationSyntax WithQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
		{
		return this.Update(this.TLBracket, qualifier, this.Block, this.TRBracket);
	}
	
	public ParserAnnotationSyntax AddQualifier(params IdentifierSyntax[] qualifier)
		{
		return this.WithQualifier(this.Qualifier.AddRange(qualifier));
	}
	
	public ParserAnnotationSyntax WithBlock(ParserAnnotationBlock1Syntax block)
		{
		return this.Update(this.TLBracket, this.Qualifier, block, this.TRBracket);
	}
	
	public ParserAnnotationSyntax WithTRBracket(__SyntaxToken tRBracket)
		{
		return this.Update(this.TLBracket, this.Qualifier, this.Block, tRBracket);
	}
	
	    public ParserAnnotationSyntax Update(__SyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, ParserAnnotationBlock1Syntax block, __SyntaxToken tRBracket)
	    {
	        if (this.TLBracket != tLBracket || this.Qualifier != qualifier || this.Block != block || this.TRBracket != tRBracket)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserAnnotation(tLBracket, qualifier, block, tRBracket);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
		private __SyntaxNode _qualifier;
		private LexerAnnotationBlock1Syntax _block;
	
	    public LexerAnnotationSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LexerAnnotationSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TLBracket 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationGreen)this.Green;
	var greenToken = green.TLBracket;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> Qualifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._qualifier, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public LexerAnnotationBlock1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 2);
	return red;
	} 
	}
	public __SyntaxToken TRBracket 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationGreen)this.Green;
	var greenToken = green.TRBracket;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._qualifier, 1);
			case 2: return this.GetRed(ref this._block, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._qualifier;
			case 2: return this._block;
			default: return null;
	        }
	    }
	
	public LexerAnnotationSyntax WithTLBracket(__SyntaxToken tLBracket)
		{
		return this.Update(tLBracket, this.Qualifier, this.Block, this.TRBracket);
	}
	
	public LexerAnnotationSyntax WithQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
		{
		return this.Update(this.TLBracket, qualifier, this.Block, this.TRBracket);
	}
	
	public LexerAnnotationSyntax AddQualifier(params IdentifierSyntax[] qualifier)
		{
		return this.WithQualifier(this.Qualifier.AddRange(qualifier));
	}
	
	public LexerAnnotationSyntax WithBlock(LexerAnnotationBlock1Syntax block)
		{
		return this.Update(this.TLBracket, this.Qualifier, block, this.TRBracket);
	}
	
	public LexerAnnotationSyntax WithTRBracket(__SyntaxToken tRBracket)
		{
		return this.Update(this.TLBracket, this.Qualifier, this.Block, tRBracket);
	}
	
	    public LexerAnnotationSyntax Update(__SyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, LexerAnnotationBlock1Syntax block, __SyntaxToken tRBracket)
	    {
	        if (this.TLBracket != tLBracket || this.Qualifier != qualifier || this.Block != block || this.TRBracket != tRBracket)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerAnnotation(tLBracket, qualifier, block, tRBracket);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	
	public sealed class AnnotationArgumentSyntax : CompilerSyntaxNode
	{
		private AnnotationArgumentBlock1Syntax _block;
		private ExpressionSyntax _value;
	
	    public AnnotationArgumentSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AnnotationArgumentSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public AnnotationArgumentBlock1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 0);
	return red;
	} 
	}
	public ExpressionSyntax Value 
		{ 
		get
		{
				var red = this.GetRed(ref this._value, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._block, 0);
			case 1: return this.GetRed(ref this._value, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._block;
			case 1: return this._value;
			default: return null;
	        }
	    }
	
	public AnnotationArgumentSyntax WithBlock(AnnotationArgumentBlock1Syntax block)
		{
		return this.Update(block, this.Value);
	}
	
	public AnnotationArgumentSyntax WithValue(ExpressionSyntax value)
		{
		return this.Update(this.Block, value);
	}
	
	    public AnnotationArgumentSyntax Update(AnnotationArgumentBlock1Syntax block, ExpressionSyntax value)
	    {
	        if (this.Block != block || this.Value != value)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.AnnotationArgument(block, value);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	public abstract class TypeReferenceIdentifierSyntax : CompilerSyntaxNode
	{
	    protected TypeReferenceIdentifierSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected TypeReferenceIdentifierSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class TypeReferenceIdentifierAlt1Syntax : TypeReferenceIdentifierSyntax
	{
	
	    public TypeReferenceIdentifierAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TypeReferenceIdentifierAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Tokens 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.TypeReferenceIdentifierAlt1Green)this.Green;
	var greenToken = green.Tokens;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	public TypeReferenceIdentifierAlt1Syntax WithTokens(__SyntaxToken tokens)
		{
		return this.Update(tokens);
	}
	
	    public TypeReferenceIdentifierAlt1Syntax Update(__SyntaxToken tokens)
	    {
	        if (this.Tokens != tokens)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.TypeReferenceIdentifierAlt1(tokens);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (TypeReferenceIdentifierAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTypeReferenceIdentifierAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTypeReferenceIdentifierAlt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitTypeReferenceIdentifierAlt1(this);
	    }
	
	}
	public sealed class TypeReferenceIdentifierAlt2Syntax : TypeReferenceIdentifierSyntax
	{
		private IdentifierSyntax _identifier;
	
	    public TypeReferenceIdentifierAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TypeReferenceIdentifierAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public IdentifierSyntax Identifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._identifier, 0);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._identifier, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._identifier;
			default: return null;
	        }
	    }
	
	public TypeReferenceIdentifierAlt2Syntax WithIdentifier(IdentifierSyntax identifier)
		{
		return this.Update(identifier);
	}
	
	    public TypeReferenceIdentifierAlt2Syntax Update(IdentifierSyntax identifier)
	    {
	        if (this.Identifier != identifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.TypeReferenceIdentifierAlt2(identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (TypeReferenceIdentifierAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTypeReferenceIdentifierAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTypeReferenceIdentifierAlt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitTypeReferenceIdentifierAlt2(this);
	    }
	
	}
	public abstract class TypeReferenceSyntax : CompilerSyntaxNode
	{
	    protected TypeReferenceSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected TypeReferenceSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class TypeReferenceAlt1Syntax : TypeReferenceSyntax
	{
	
	    public TypeReferenceAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TypeReferenceAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Tokens 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.TypeReferenceAlt1Green)this.Green;
	var greenToken = green.Tokens;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	public TypeReferenceAlt1Syntax WithTokens(__SyntaxToken tokens)
		{
		return this.Update(tokens);
	}
	
	    public TypeReferenceAlt1Syntax Update(__SyntaxToken tokens)
	    {
	        if (this.Tokens != tokens)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.TypeReferenceAlt1(tokens);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (TypeReferenceAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTypeReferenceAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTypeReferenceAlt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitTypeReferenceAlt1(this);
	    }
	
	}
	public sealed class TypeReferenceAlt2Syntax : TypeReferenceSyntax
	{
		private __SyntaxNode _qualifier;
	
	    public TypeReferenceAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TypeReferenceAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> Qualifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._qualifier, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax>(red, this.GetChildIndex(0), reversed: false);
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._qualifier, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._qualifier;
			default: return null;
	        }
	    }
	
	public TypeReferenceAlt2Syntax WithQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
		{
		return this.Update(qualifier);
	}
	
	public TypeReferenceAlt2Syntax AddQualifier(params IdentifierSyntax[] qualifier)
		{
		return this.WithQualifier(this.Qualifier.AddRange(qualifier));
	}
	
	    public TypeReferenceAlt2Syntax Update(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
	    {
	        if (this.Qualifier != qualifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.TypeReferenceAlt2(qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (TypeReferenceAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTypeReferenceAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTypeReferenceAlt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitTypeReferenceAlt2(this);
	    }
	
	}
	
	public sealed class NameSyntax : CompilerSyntaxNode
	{
		private IdentifierSyntax _identifier;
	
	    public NameSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public NameSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public IdentifierSyntax Identifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._identifier, 0);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._identifier, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
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
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	
	public sealed class IdentifierSyntax : CompilerSyntaxNode
	{
	
	    public IdentifierSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public IdentifierSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Token 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.IdentifierGreen)this.Green;
	var greenToken = green.Token;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	public IdentifierSyntax WithToken(__SyntaxToken token)
		{
		return this.Update(token);
	}
	
	    public IdentifierSyntax Update(__SyntaxToken token)
	    {
	        if (this.Token != token)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Identifier(token);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	
	public sealed class MainBlock1Syntax : CompilerSyntaxNode
	{
		private LanguageDeclarationSyntax _declarations;
	
	    public MainBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MainBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public LanguageDeclarationSyntax Declarations 
		{ 
		get
		{
				var red = this.GetRed(ref this._declarations, 0);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._declarations, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._declarations;
			default: return null;
	        }
	    }
	
	public MainBlock1Syntax WithDeclarations(LanguageDeclarationSyntax declarations)
		{
		return this.Update(declarations);
	}
	
	    public MainBlock1Syntax Update(LanguageDeclarationSyntax declarations)
	    {
	        if (this.Declarations != declarations)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.MainBlock1(declarations);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MainBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMainBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMainBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitMainBlock1(this);
	    }
	
	}
	public abstract class RuleBlock1Syntax : CompilerSyntaxNode
	{
	    protected RuleBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected RuleBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class RuleBlock1Alt1Syntax : RuleBlock1Syntax
	{
		private TypeReferenceIdentifierSyntax _returnType;
	
	    public RuleBlock1Alt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public RuleBlock1Alt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public TypeReferenceIdentifierSyntax ReturnType 
		{ 
		get
		{
				var red = this.GetRed(ref this._returnType, 0);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._returnType, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._returnType;
			default: return null;
	        }
	    }
	
	public RuleBlock1Alt1Syntax WithReturnType(TypeReferenceIdentifierSyntax returnType)
		{
		return this.Update(returnType);
	}
	
	    public RuleBlock1Alt1Syntax Update(TypeReferenceIdentifierSyntax returnType)
	    {
	        if (this.ReturnType != returnType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleBlock1Alt1(returnType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (RuleBlock1Alt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitRuleBlock1Alt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitRuleBlock1Alt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitRuleBlock1Alt1(this);
	    }
	
	}
	public sealed class RuleBlock1Alt2Syntax : RuleBlock1Syntax
	{
		private IdentifierSyntax _identifier;
		private TypeReferenceSyntax _returnType;
	
	    public RuleBlock1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public RuleBlock1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public IdentifierSyntax Identifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._identifier, 0);
	return red;
	} 
	}
	public __SyntaxToken KReturns 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleBlock1Alt2Green)this.Green;
	var greenToken = green.KReturns;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
	} 
	}
	public TypeReferenceSyntax ReturnType 
		{ 
		get
		{
				var red = this.GetRed(ref this._returnType, 2);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._identifier, 0);
			case 2: return this.GetRed(ref this._returnType, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._identifier;
			case 2: return this._returnType;
			default: return null;
	        }
	    }
	
	public RuleBlock1Alt2Syntax WithIdentifier(IdentifierSyntax identifier)
		{
		return this.Update(identifier, this.KReturns, this.ReturnType);
	}
	
	public RuleBlock1Alt2Syntax WithKReturns(__SyntaxToken kReturns)
		{
		return this.Update(this.Identifier, kReturns, this.ReturnType);
	}
	
	public RuleBlock1Alt2Syntax WithReturnType(TypeReferenceSyntax returnType)
		{
		return this.Update(this.Identifier, this.KReturns, returnType);
	}
	
	    public RuleBlock1Alt2Syntax Update(IdentifierSyntax identifier, __SyntaxToken kReturns, TypeReferenceSyntax returnType)
	    {
	        if (this.Identifier != identifier || this.KReturns != kReturns || this.ReturnType != returnType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleBlock1Alt2(identifier, kReturns, returnType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (RuleBlock1Alt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitRuleBlock1Alt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitRuleBlock1Alt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitRuleBlock1Alt2(this);
	    }
	
	}
	
	public sealed class RuleAlternativesBlockSyntax : CompilerSyntaxNode
	{
		private AlternativeSyntax _alternatives;
	
	    public RuleAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public RuleAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TBar 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleAlternativesBlockGreen)this.Green;
	var greenToken = green.TBar;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public AlternativeSyntax Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._alternatives, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._alternatives;
			default: return null;
	        }
	    }
	
	public RuleAlternativesBlockSyntax WithTBar(__SyntaxToken tBar)
		{
		return this.Update(tBar, this.Alternatives);
	}
	
	public RuleAlternativesBlockSyntax WithAlternatives(AlternativeSyntax alternatives)
		{
		return this.Update(this.TBar, alternatives);
	}
	
	    public RuleAlternativesBlockSyntax Update(__SyntaxToken tBar, AlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleAlternativesBlock(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (RuleAlternativesBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitRuleAlternativesBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitRuleAlternativesBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitRuleAlternativesBlock(this);
	    }
	
	}
	
	public sealed class AlternativeBlock1Syntax : CompilerSyntaxNode
	{
		private __SyntaxNode _annotations1;
		private NameSyntax _name;
		private AlternativeBlock1Block1Syntax _block;
	
	    public AlternativeBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AlternativeBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> Annotations1 
		{ 
		get
		{
				var red = this.GetRed(ref this._annotations1, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax>(red);
	} 
	}
	public __SyntaxToken KAlt 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AlternativeBlock1Green)this.Green;
	var greenToken = green.KAlt;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
	} 
	}
	public NameSyntax Name 
		{ 
		get
		{
				var red = this.GetRed(ref this._name, 2);
	return red;
	} 
	}
	public AlternativeBlock1Block1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 3);
	return red;
	} 
	}
	public __SyntaxToken TColon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AlternativeBlock1Green)this.Green;
	var greenToken = green.TColon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._annotations1, 0);
			case 2: return this.GetRed(ref this._name, 2);
			case 3: return this.GetRed(ref this._block, 3);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._annotations1;
			case 2: return this._name;
			case 3: return this._block;
			default: return null;
	        }
	    }
	
	public AlternativeBlock1Syntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
		{
		return this.Update(annotations1, this.KAlt, this.Name, this.Block, this.TColon);
	}
	
	public AlternativeBlock1Syntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
		{
		return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
	}
	
	public AlternativeBlock1Syntax WithKAlt(__SyntaxToken kAlt)
		{
		return this.Update(this.Annotations1, kAlt, this.Name, this.Block, this.TColon);
	}
	
	public AlternativeBlock1Syntax WithName(NameSyntax name)
		{
		return this.Update(this.Annotations1, this.KAlt, name, this.Block, this.TColon);
	}
	
	public AlternativeBlock1Syntax WithBlock(AlternativeBlock1Block1Syntax block)
		{
		return this.Update(this.Annotations1, this.KAlt, this.Name, block, this.TColon);
	}
	
	public AlternativeBlock1Syntax WithTColon(__SyntaxToken tColon)
		{
		return this.Update(this.Annotations1, this.KAlt, this.Name, this.Block, tColon);
	}
	
	    public AlternativeBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken kAlt, NameSyntax name, AlternativeBlock1Block1Syntax block, __SyntaxToken tColon)
	    {
	        if (this.Annotations1 != annotations1 || this.KAlt != kAlt || this.Name != name || this.Block != block || this.TColon != tColon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.AlternativeBlock1(annotations1, kAlt, name, block, tColon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (AlternativeBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitAlternativeBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitAlternativeBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitAlternativeBlock1(this);
	    }
	
	}
	
	public sealed class AlternativeBlock2Syntax : CompilerSyntaxNode
	{
		private ExpressionSyntax _returnValue;
	
	    public AlternativeBlock2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AlternativeBlock2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TEqGt 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AlternativeBlock2Green)this.Green;
	var greenToken = green.TEqGt;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public ExpressionSyntax ReturnValue 
		{ 
		get
		{
				var red = this.GetRed(ref this._returnValue, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._returnValue, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._returnValue;
			default: return null;
	        }
	    }
	
	public AlternativeBlock2Syntax WithTEqGt(__SyntaxToken tEqGt)
		{
		return this.Update(tEqGt, this.ReturnValue);
	}
	
	public AlternativeBlock2Syntax WithReturnValue(ExpressionSyntax returnValue)
		{
		return this.Update(this.TEqGt, returnValue);
	}
	
	    public AlternativeBlock2Syntax Update(__SyntaxToken tEqGt, ExpressionSyntax returnValue)
	    {
	        if (this.TEqGt != tEqGt || this.ReturnValue != returnValue)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.AlternativeBlock2(tEqGt, returnValue);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (AlternativeBlock2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitAlternativeBlock2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitAlternativeBlock2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitAlternativeBlock2(this);
	    }
	
	}
	
	public sealed class ElementBlock1Syntax : CompilerSyntaxNode
	{
		private __SyntaxNode _annotations1;
		private NameSyntax _name;
	
	    public ElementBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ElementBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> Annotations1 
		{ 
		get
		{
				var red = this.GetRed(ref this._annotations1, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax>(red);
	} 
	}
	public NameSyntax Name 
		{ 
		get
		{
				var red = this.GetRed(ref this._name, 1);
	return red;
	} 
	}
	public __SyntaxToken Assignment 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ElementBlock1Green)this.Green;
	var greenToken = green.Assignment;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._annotations1, 0);
			case 1: return this.GetRed(ref this._name, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._annotations1;
			case 1: return this._name;
			default: return null;
	        }
	    }
	
	public ElementBlock1Syntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
		{
		return this.Update(annotations1, this.Name, this.Assignment);
	}
	
	public ElementBlock1Syntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
		{
		return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
	}
	
	public ElementBlock1Syntax WithName(NameSyntax name)
		{
		return this.Update(this.Annotations1, name, this.Assignment);
	}
	
	public ElementBlock1Syntax WithAssignment(__SyntaxToken assignment)
		{
		return this.Update(this.Annotations1, this.Name, assignment);
	}
	
	    public ElementBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name, __SyntaxToken assignment)
	    {
	        if (this.Annotations1 != annotations1 || this.Name != name || this.Assignment != assignment)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ElementBlock1(annotations1, name, assignment);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ElementBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitElementBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitElementBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitElementBlock1(this);
	    }
	
	}
	public abstract class ElementValueBlock1Syntax : CompilerSyntaxNode
	{
	    protected ElementValueBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ElementValueBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class TokensSyntax : ElementValueBlock1Syntax
	{
	
	    public TokensSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TokensSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Token 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.TokensGreen)this.Green;
	var greenToken = green.Token;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	public TokensSyntax WithToken(__SyntaxToken token)
		{
		return this.Update(token);
	}
	
	    public TokensSyntax Update(__SyntaxToken token)
	    {
	        if (this.Token != token)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Tokens(token);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (TokensSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTokens(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTokens(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitTokens(this);
	    }
	
	}
	public sealed class BlockSyntax : ElementValueBlock1Syntax
	{
		private __SyntaxNode _alternatives;
	
	    public BlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TLParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockGreen)this.Green;
	var greenToken = green.TLParen;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax> Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public __SyntaxToken TRParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockGreen)this.Green;
	var greenToken = green.TRParen;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._alternatives, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._alternatives;
			default: return null;
	        }
	    }
	
	public BlockSyntax WithTLParen(__SyntaxToken tLParen)
		{
		return this.Update(tLParen, this.Alternatives, this.TRParen);
	}
	
	public BlockSyntax WithAlternatives(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax> alternatives)
		{
		return this.Update(this.TLParen, alternatives, this.TRParen);
	}
	
	public BlockSyntax AddAlternatives(params BlockAlternativeSyntax[] alternatives)
		{
		return this.WithAlternatives(this.Alternatives.AddRange(alternatives));
	}
	
	public BlockSyntax WithTRParen(__SyntaxToken tRParen)
		{
		return this.Update(this.TLParen, this.Alternatives, tRParen);
	}
	
	    public BlockSyntax Update(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax> alternatives, __SyntaxToken tRParen)
	    {
	        if (this.TLParen != tLParen || this.Alternatives != alternatives || this.TRParen != tRParen)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Block(tLParen, alternatives, tRParen);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (BlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitBlock(this);
	    }
	
	}
	public sealed class RuleRefAlt1Syntax : ElementValueBlock1Syntax
	{
		private IdentifierSyntax _grammarRule;
	
	    public RuleRefAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public RuleRefAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public IdentifierSyntax GrammarRule 
		{ 
		get
		{
				var red = this.GetRed(ref this._grammarRule, 0);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._grammarRule, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._grammarRule;
			default: return null;
	        }
	    }
	
	public RuleRefAlt1Syntax WithGrammarRule(IdentifierSyntax grammarRule)
		{
		return this.Update(grammarRule);
	}
	
	    public RuleRefAlt1Syntax Update(IdentifierSyntax grammarRule)
	    {
	        if (this.GrammarRule != grammarRule)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleRefAlt1(grammarRule);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (RuleRefAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitRuleRefAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitRuleRefAlt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitRuleRefAlt1(this);
	    }
	
	}
	public sealed class RuleRefAlt2Syntax : ElementValueBlock1Syntax
	{
		private TypeReferenceSyntax _referencedTypes;
	
	    public RuleRefAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public RuleRefAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken THash 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleRefAlt2Green)this.Green;
	var greenToken = green.THash;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public TypeReferenceSyntax ReferencedTypes 
		{ 
		get
		{
				var red = this.GetRed(ref this._referencedTypes, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._referencedTypes, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._referencedTypes;
			default: return null;
	        }
	    }
	
	public RuleRefAlt2Syntax WithTHash(__SyntaxToken tHash)
		{
		return this.Update(tHash, this.ReferencedTypes);
	}
	
	public RuleRefAlt2Syntax WithReferencedTypes(TypeReferenceSyntax referencedTypes)
		{
		return this.Update(this.THash, referencedTypes);
	}
	
	    public RuleRefAlt2Syntax Update(__SyntaxToken tHash, TypeReferenceSyntax referencedTypes)
	    {
	        if (this.THash != tHash || this.ReferencedTypes != referencedTypes)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleRefAlt2(tHash, referencedTypes);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (RuleRefAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitRuleRefAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitRuleRefAlt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitRuleRefAlt2(this);
	    }
	
	}
	public sealed class RuleRefAlt3Syntax : ElementValueBlock1Syntax
	{
		private __SyntaxNode _referencedTypes;
		private RuleRefAlt3Block1Syntax _block;
	
	    public RuleRefAlt3Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public RuleRefAlt3Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken THashLBrace 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleRefAlt3Green)this.Green;
	var greenToken = green.THashLBrace;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax> ReferencedTypes 
		{ 
		get
		{
				var red = this.GetRed(ref this._referencedTypes, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public RuleRefAlt3Block1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 2);
	return red;
	} 
	}
	public __SyntaxToken TRBrace 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleRefAlt3Green)this.Green;
	var greenToken = green.TRBrace;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._referencedTypes, 1);
			case 2: return this.GetRed(ref this._block, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._referencedTypes;
			case 2: return this._block;
			default: return null;
	        }
	    }
	
	public RuleRefAlt3Syntax WithTHashLBrace(__SyntaxToken tHashLBrace)
		{
		return this.Update(tHashLBrace, this.ReferencedTypes, this.Block, this.TRBrace);
	}
	
	public RuleRefAlt3Syntax WithReferencedTypes(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax> referencedTypes)
		{
		return this.Update(this.THashLBrace, referencedTypes, this.Block, this.TRBrace);
	}
	
	public RuleRefAlt3Syntax AddReferencedTypes(params TypeReferenceSyntax[] referencedTypes)
		{
		return this.WithReferencedTypes(this.ReferencedTypes.AddRange(referencedTypes));
	}
	
	public RuleRefAlt3Syntax WithBlock(RuleRefAlt3Block1Syntax block)
		{
		return this.Update(this.THashLBrace, this.ReferencedTypes, block, this.TRBrace);
	}
	
	public RuleRefAlt3Syntax WithTRBrace(__SyntaxToken tRBrace)
		{
		return this.Update(this.THashLBrace, this.ReferencedTypes, this.Block, tRBrace);
	}
	
	    public RuleRefAlt3Syntax Update(__SyntaxToken tHashLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax> referencedTypes, RuleRefAlt3Block1Syntax block, __SyntaxToken tRBrace)
	    {
	        if (this.THashLBrace != tHashLBrace || this.ReferencedTypes != referencedTypes || this.Block != block || this.TRBrace != tRBrace)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleRefAlt3(tHashLBrace, referencedTypes, block, tRBrace);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (RuleRefAlt3Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitRuleRefAlt3(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitRuleRefAlt3(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitRuleRefAlt3(this);
	    }
	
	}
	
	public sealed class BlockAlternativesBlockSyntax : CompilerSyntaxNode
	{
		private BlockAlternativeSyntax _alternatives;
	
	    public BlockAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BlockAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TBar 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockAlternativesBlockGreen)this.Green;
	var greenToken = green.TBar;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public BlockAlternativeSyntax Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._alternatives, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._alternatives;
			default: return null;
	        }
	    }
	
	public BlockAlternativesBlockSyntax WithTBar(__SyntaxToken tBar)
		{
		return this.Update(tBar, this.Alternatives);
	}
	
	public BlockAlternativesBlockSyntax WithAlternatives(BlockAlternativeSyntax alternatives)
		{
		return this.Update(this.TBar, alternatives);
	}
	
	    public BlockAlternativesBlockSyntax Update(__SyntaxToken tBar, BlockAlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.BlockAlternativesBlock(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (BlockAlternativesBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBlockAlternativesBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBlockAlternativesBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitBlockAlternativesBlock(this);
	    }
	
	}
	
	public sealed class BlockAlternativeBlock1Syntax : CompilerSyntaxNode
	{
		private ExpressionSyntax _returnValue;
	
	    public BlockAlternativeBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BlockAlternativeBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TEqGt 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockAlternativeBlock1Green)this.Green;
	var greenToken = green.TEqGt;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public ExpressionSyntax ReturnValue 
		{ 
		get
		{
				var red = this.GetRed(ref this._returnValue, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._returnValue, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._returnValue;
			default: return null;
	        }
	    }
	
	public BlockAlternativeBlock1Syntax WithTEqGt(__SyntaxToken tEqGt)
		{
		return this.Update(tEqGt, this.ReturnValue);
	}
	
	public BlockAlternativeBlock1Syntax WithReturnValue(ExpressionSyntax returnValue)
		{
		return this.Update(this.TEqGt, returnValue);
	}
	
	    public BlockAlternativeBlock1Syntax Update(__SyntaxToken tEqGt, ExpressionSyntax returnValue)
	    {
	        if (this.TEqGt != tEqGt || this.ReturnValue != returnValue)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.BlockAlternativeBlock1(tEqGt, returnValue);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (BlockAlternativeBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBlockAlternativeBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBlockAlternativeBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitBlockAlternativeBlock1(this);
	    }
	
	}
	
	public sealed class RuleRefAlt3ReferencedTypesBlockSyntax : CompilerSyntaxNode
	{
		private TypeReferenceSyntax _referencedTypes;
	
	    public RuleRefAlt3ReferencedTypesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public RuleRefAlt3ReferencedTypesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TComma 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleRefAlt3ReferencedTypesBlockGreen)this.Green;
	var greenToken = green.TComma;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public TypeReferenceSyntax ReferencedTypes 
		{ 
		get
		{
				var red = this.GetRed(ref this._referencedTypes, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._referencedTypes, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._referencedTypes;
			default: return null;
	        }
	    }
	
	public RuleRefAlt3ReferencedTypesBlockSyntax WithTComma(__SyntaxToken tComma)
		{
		return this.Update(tComma, this.ReferencedTypes);
	}
	
	public RuleRefAlt3ReferencedTypesBlockSyntax WithReferencedTypes(TypeReferenceSyntax referencedTypes)
		{
		return this.Update(this.TComma, referencedTypes);
	}
	
	    public RuleRefAlt3ReferencedTypesBlockSyntax Update(__SyntaxToken tComma, TypeReferenceSyntax referencedTypes)
	    {
	        if (this.TComma != tComma || this.ReferencedTypes != referencedTypes)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleRefAlt3ReferencedTypesBlock(tComma, referencedTypes);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (RuleRefAlt3ReferencedTypesBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitRuleRefAlt3ReferencedTypesBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitRuleRefAlt3ReferencedTypesBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitRuleRefAlt3ReferencedTypesBlock(this);
	    }
	
	}
	
	public sealed class RuleRefAlt3Block1Syntax : CompilerSyntaxNode
	{
		private IdentifierSyntax _grammarRule;
	
	    public RuleRefAlt3Block1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public RuleRefAlt3Block1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TBar 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleRefAlt3Block1Green)this.Green;
	var greenToken = green.TBar;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public IdentifierSyntax GrammarRule 
		{ 
		get
		{
				var red = this.GetRed(ref this._grammarRule, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._grammarRule, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._grammarRule;
			default: return null;
	        }
	    }
	
	public RuleRefAlt3Block1Syntax WithTBar(__SyntaxToken tBar)
		{
		return this.Update(tBar, this.GrammarRule);
	}
	
	public RuleRefAlt3Block1Syntax WithGrammarRule(IdentifierSyntax grammarRule)
		{
		return this.Update(this.TBar, grammarRule);
	}
	
	    public RuleRefAlt3Block1Syntax Update(__SyntaxToken tBar, IdentifierSyntax grammarRule)
	    {
	        if (this.TBar != tBar || this.GrammarRule != grammarRule)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleRefAlt3Block1(tBar, grammarRule);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (RuleRefAlt3Block1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitRuleRefAlt3Block1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitRuleRefAlt3Block1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitRuleRefAlt3Block1(this);
	    }
	
	}
	public abstract class TokenBlock1Syntax : CompilerSyntaxNode
	{
	    protected TokenBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected TokenBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class TokenBlock1Alt1Syntax : TokenBlock1Syntax
	{
		private NameSyntax _name;
		private TokenBlock1Alt1Block1Syntax _block;
	
	    public TokenBlock1Alt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TokenBlock1Alt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KToken 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenBlock1Alt1Green)this.Green;
	var greenToken = green.KToken;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public NameSyntax Name 
		{ 
		get
		{
				var red = this.GetRed(ref this._name, 1);
	return red;
	} 
	}
	public TokenBlock1Alt1Block1Syntax Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 2);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._name, 1);
			case 2: return this.GetRed(ref this._block, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._name;
			case 2: return this._block;
			default: return null;
	        }
	    }
	
	public TokenBlock1Alt1Syntax WithKToken(__SyntaxToken kToken)
		{
		return this.Update(kToken, this.Name, this.Block);
	}
	
	public TokenBlock1Alt1Syntax WithName(NameSyntax name)
		{
		return this.Update(this.KToken, name, this.Block);
	}
	
	public TokenBlock1Alt1Syntax WithBlock(TokenBlock1Alt1Block1Syntax block)
		{
		return this.Update(this.KToken, this.Name, block);
	}
	
	    public TokenBlock1Alt1Syntax Update(__SyntaxToken kToken, NameSyntax name, TokenBlock1Alt1Block1Syntax block)
	    {
	        if (this.KToken != kToken || this.Name != name || this.Block != block)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.TokenBlock1Alt1(kToken, name, block);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (TokenBlock1Alt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTokenBlock1Alt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTokenBlock1Alt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitTokenBlock1Alt1(this);
	    }
	
	}
	public sealed class TokenBlock1Alt2Syntax : TokenBlock1Syntax
	{
		private NameSyntax _name;
	
	    public TokenBlock1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TokenBlock1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken IsTrivia 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenBlock1Alt2Green)this.Green;
	var greenToken = green.IsTrivia;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public NameSyntax Name 
		{ 
		get
		{
				var red = this.GetRed(ref this._name, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._name, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._name;
			default: return null;
	        }
	    }
	
	public TokenBlock1Alt2Syntax WithIsTrivia(__SyntaxToken isTrivia)
		{
		return this.Update(isTrivia, this.Name);
	}
	
	public TokenBlock1Alt2Syntax WithName(NameSyntax name)
		{
		return this.Update(this.IsTrivia, name);
	}
	
	    public TokenBlock1Alt2Syntax Update(__SyntaxToken isTrivia, NameSyntax name)
	    {
	        if (this.IsTrivia != isTrivia || this.Name != name)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.TokenBlock1Alt2(isTrivia, name);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (TokenBlock1Alt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTokenBlock1Alt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTokenBlock1Alt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitTokenBlock1Alt2(this);
	    }
	
	}
	
	public sealed class TokenAlternativesBlockSyntax : CompilerSyntaxNode
	{
		private LAlternativeSyntax _alternatives;
	
	    public TokenAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TokenAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TBar 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenAlternativesBlockGreen)this.Green;
	var greenToken = green.TBar;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public LAlternativeSyntax Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._alternatives, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._alternatives;
			default: return null;
	        }
	    }
	
	public TokenAlternativesBlockSyntax WithTBar(__SyntaxToken tBar)
		{
		return this.Update(tBar, this.Alternatives);
	}
	
	public TokenAlternativesBlockSyntax WithAlternatives(LAlternativeSyntax alternatives)
		{
		return this.Update(this.TBar, alternatives);
	}
	
	    public TokenAlternativesBlockSyntax Update(__SyntaxToken tBar, LAlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.TokenAlternativesBlock(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (TokenAlternativesBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTokenAlternativesBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTokenAlternativesBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitTokenAlternativesBlock(this);
	    }
	
	}
	
	public sealed class FragmentAlternativesBlockSyntax : CompilerSyntaxNode
	{
		private LAlternativeSyntax _alternatives;
	
	    public FragmentAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public FragmentAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TBar 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.FragmentAlternativesBlockGreen)this.Green;
	var greenToken = green.TBar;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public LAlternativeSyntax Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._alternatives, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._alternatives;
			default: return null;
	        }
	    }
	
	public FragmentAlternativesBlockSyntax WithTBar(__SyntaxToken tBar)
		{
		return this.Update(tBar, this.Alternatives);
	}
	
	public FragmentAlternativesBlockSyntax WithAlternatives(LAlternativeSyntax alternatives)
		{
		return this.Update(this.TBar, alternatives);
	}
	
	    public FragmentAlternativesBlockSyntax Update(__SyntaxToken tBar, LAlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.FragmentAlternativesBlock(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (FragmentAlternativesBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitFragmentAlternativesBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitFragmentAlternativesBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitFragmentAlternativesBlock(this);
	    }
	
	}
	
	public sealed class LBlockAlternativesBlockSyntax : CompilerSyntaxNode
	{
		private LAlternativeSyntax _alternatives;
	
	    public LBlockAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LBlockAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TBar 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LBlockAlternativesBlockGreen)this.Green;
	var greenToken = green.TBar;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public LAlternativeSyntax Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._alternatives, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._alternatives;
			default: return null;
	        }
	    }
	
	public LBlockAlternativesBlockSyntax WithTBar(__SyntaxToken tBar)
		{
		return this.Update(tBar, this.Alternatives);
	}
	
	public LBlockAlternativesBlockSyntax WithAlternatives(LAlternativeSyntax alternatives)
		{
		return this.Update(this.TBar, alternatives);
	}
	
	    public LBlockAlternativesBlockSyntax Update(__SyntaxToken tBar, LAlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LBlockAlternativesBlock(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (LBlockAlternativesBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLBlockAlternativesBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLBlockAlternativesBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLBlockAlternativesBlock(this);
	    }
	
	}
	public abstract class SingleExpressionBlock1Syntax : CompilerSyntaxNode
	{
	    protected SingleExpressionBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected SingleExpressionBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class Tokens1Syntax : SingleExpressionBlock1Syntax
	{
	
	    public Tokens1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public Tokens1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Token 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.Tokens1Green)this.Green;
	var greenToken = green.Token;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	public Tokens1Syntax WithToken(__SyntaxToken token)
		{
		return this.Update(token);
	}
	
	    public Tokens1Syntax Update(__SyntaxToken token)
	    {
	        if (this.Token != token)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Tokens1(token);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (Tokens1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTokens1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTokens1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitTokens1(this);
	    }
	
	}
	public sealed class SingleExpressionBlock1Alt2Syntax : SingleExpressionBlock1Syntax
	{
	
	    public SingleExpressionBlock1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SingleExpressionBlock1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Tokens 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.SingleExpressionBlock1Alt2Green)this.Green;
	var greenToken = green.Tokens;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			default: return null;
	        }
	    }
	
	public SingleExpressionBlock1Alt2Syntax WithTokens(__SyntaxToken tokens)
		{
		return this.Update(tokens);
	}
	
	    public SingleExpressionBlock1Alt2Syntax Update(__SyntaxToken tokens)
	    {
	        if (this.Tokens != tokens)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionBlock1Alt2(tokens);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (SingleExpressionBlock1Alt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt2(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitSingleExpressionBlock1Alt2(this);
	    }
	
	}
	public sealed class SingleExpressionBlock1Alt3Syntax : SingleExpressionBlock1Syntax
	{
		private __SyntaxNode _qualifier;
	
	    public SingleExpressionBlock1Alt3Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SingleExpressionBlock1Alt3Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> Qualifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._qualifier, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax>(red, this.GetChildIndex(0), reversed: false);
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._qualifier, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._qualifier;
			default: return null;
	        }
	    }
	
	public SingleExpressionBlock1Alt3Syntax WithQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
		{
		return this.Update(qualifier);
	}
	
	public SingleExpressionBlock1Alt3Syntax AddQualifier(params IdentifierSyntax[] qualifier)
		{
		return this.WithQualifier(this.Qualifier.AddRange(qualifier));
	}
	
	    public SingleExpressionBlock1Alt3Syntax Update(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
	    {
	        if (this.Qualifier != qualifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionBlock1Alt3(qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (SingleExpressionBlock1Alt3Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt3(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt3(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitSingleExpressionBlock1Alt3(this);
	    }
	
	}
	
	public sealed class ParserAnnotationBlock1Syntax : CompilerSyntaxNode
	{
		private __SyntaxNode _arguments;
	
	    public ParserAnnotationBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserAnnotationBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TLParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationBlock1Green)this.Green;
	var greenToken = green.TLParen;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> Arguments 
		{ 
		get
		{
				var red = this.GetRed(ref this._arguments, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public __SyntaxToken TRParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationBlock1Green)this.Green;
	var greenToken = green.TRParen;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._arguments, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._arguments;
			default: return null;
	        }
	    }
	
	public ParserAnnotationBlock1Syntax WithTLParen(__SyntaxToken tLParen)
		{
		return this.Update(tLParen, this.Arguments, this.TRParen);
	}
	
	public ParserAnnotationBlock1Syntax WithArguments(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments)
		{
		return this.Update(this.TLParen, arguments, this.TRParen);
	}
	
	public ParserAnnotationBlock1Syntax AddArguments(params AnnotationArgumentSyntax[] arguments)
		{
		return this.WithArguments(this.Arguments.AddRange(arguments));
	}
	
	public ParserAnnotationBlock1Syntax WithTRParen(__SyntaxToken tRParen)
		{
		return this.Update(this.TLParen, this.Arguments, tRParen);
	}
	
	    public ParserAnnotationBlock1Syntax Update(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments, __SyntaxToken tRParen)
	    {
	        if (this.TLParen != tLParen || this.Arguments != arguments || this.TRParen != tRParen)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserAnnotationBlock1(tLParen, arguments, tRParen);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ParserAnnotationBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserAnnotationBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserAnnotationBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserAnnotationBlock1(this);
	    }
	
	}
	
	public sealed class LexerAnnotationBlock1Syntax : CompilerSyntaxNode
	{
		private __SyntaxNode _arguments;
	
	    public LexerAnnotationBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LexerAnnotationBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TLParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationBlock1Green)this.Green;
	var greenToken = green.TLParen;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> Arguments 
		{ 
		get
		{
				var red = this.GetRed(ref this._arguments, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public __SyntaxToken TRParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationBlock1Green)this.Green;
	var greenToken = green.TRParen;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._arguments, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._arguments;
			default: return null;
	        }
	    }
	
	public LexerAnnotationBlock1Syntax WithTLParen(__SyntaxToken tLParen)
		{
		return this.Update(tLParen, this.Arguments, this.TRParen);
	}
	
	public LexerAnnotationBlock1Syntax WithArguments(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments)
		{
		return this.Update(this.TLParen, arguments, this.TRParen);
	}
	
	public LexerAnnotationBlock1Syntax AddArguments(params AnnotationArgumentSyntax[] arguments)
		{
		return this.WithArguments(this.Arguments.AddRange(arguments));
	}
	
	public LexerAnnotationBlock1Syntax WithTRParen(__SyntaxToken tRParen)
		{
		return this.Update(this.TLParen, this.Arguments, tRParen);
	}
	
	    public LexerAnnotationBlock1Syntax Update(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments, __SyntaxToken tRParen)
	    {
	        if (this.TLParen != tLParen || this.Arguments != arguments || this.TRParen != tRParen)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerAnnotationBlock1(tLParen, arguments, tRParen);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (LexerAnnotationBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLexerAnnotationBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLexerAnnotationBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLexerAnnotationBlock1(this);
	    }
	
	}
	
	public sealed class AnnotationArgumentBlock1Syntax : CompilerSyntaxNode
	{
		private IdentifierSyntax _namedParameter;
	
	    public AnnotationArgumentBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AnnotationArgumentBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public IdentifierSyntax NamedParameter 
		{ 
		get
		{
				var red = this.GetRed(ref this._namedParameter, 0);
	return red;
	} 
	}
	public __SyntaxToken TColon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AnnotationArgumentBlock1Green)this.Green;
	var greenToken = green.TColon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._namedParameter, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
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
	
	public AnnotationArgumentBlock1Syntax WithTColon(__SyntaxToken tColon)
		{
		return this.Update(this.NamedParameter, tColon);
	}
	
	    public AnnotationArgumentBlock1Syntax Update(IdentifierSyntax namedParameter, __SyntaxToken tColon)
	    {
	        if (this.NamedParameter != namedParameter || this.TColon != tColon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.AnnotationArgumentBlock1(namedParameter, tColon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	
	public sealed class MainQualifierBlockSyntax : CompilerSyntaxNode
	{
		private IdentifierSyntax _identifier;
	
	    public MainQualifierBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MainQualifierBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TDot 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.MainQualifierBlockGreen)this.Green;
	var greenToken = green.TDot;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public IdentifierSyntax Identifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._identifier, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._identifier, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._identifier;
			default: return null;
	        }
	    }
	
	public MainQualifierBlockSyntax WithTDot(__SyntaxToken tDot)
		{
		return this.Update(tDot, this.Identifier);
	}
	
	public MainQualifierBlockSyntax WithIdentifier(IdentifierSyntax identifier)
		{
		return this.Update(this.TDot, identifier);
	}
	
	    public MainQualifierBlockSyntax Update(__SyntaxToken tDot, IdentifierSyntax identifier)
	    {
	        if (this.TDot != tDot || this.Identifier != identifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.MainQualifierBlock(tDot, identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MainQualifierBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMainQualifierBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMainQualifierBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitMainQualifierBlock(this);
	    }
	
	}
	
	public sealed class AlternativeBlock1Block1Syntax : CompilerSyntaxNode
	{
		private TypeReferenceSyntax _returnType;
	
	    public AlternativeBlock1Block1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AlternativeBlock1Block1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KReturns 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AlternativeBlock1Block1Green)this.Green;
	var greenToken = green.KReturns;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public TypeReferenceSyntax ReturnType 
		{ 
		get
		{
				var red = this.GetRed(ref this._returnType, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._returnType, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._returnType;
			default: return null;
	        }
	    }
	
	public AlternativeBlock1Block1Syntax WithKReturns(__SyntaxToken kReturns)
		{
		return this.Update(kReturns, this.ReturnType);
	}
	
	public AlternativeBlock1Block1Syntax WithReturnType(TypeReferenceSyntax returnType)
		{
		return this.Update(this.KReturns, returnType);
	}
	
	    public AlternativeBlock1Block1Syntax Update(__SyntaxToken kReturns, TypeReferenceSyntax returnType)
	    {
	        if (this.KReturns != kReturns || this.ReturnType != returnType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.AlternativeBlock1Block1(kReturns, returnType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (AlternativeBlock1Block1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitAlternativeBlock1Block1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitAlternativeBlock1Block1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitAlternativeBlock1Block1(this);
	    }
	
	}
	
	public sealed class TokenBlock1Alt1Block1Syntax : CompilerSyntaxNode
	{
		private TypeReferenceSyntax _returnType;
	
	    public TokenBlock1Alt1Block1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TokenBlock1Alt1Block1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KReturns 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenBlock1Alt1Block1Green)this.Green;
	var greenToken = green.KReturns;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public TypeReferenceSyntax ReturnType 
		{ 
		get
		{
				var red = this.GetRed(ref this._returnType, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._returnType, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._returnType;
			default: return null;
	        }
	    }
	
	public TokenBlock1Alt1Block1Syntax WithKReturns(__SyntaxToken kReturns)
		{
		return this.Update(kReturns, this.ReturnType);
	}
	
	public TokenBlock1Alt1Block1Syntax WithReturnType(TypeReferenceSyntax returnType)
		{
		return this.Update(this.KReturns, returnType);
	}
	
	    public TokenBlock1Alt1Block1Syntax Update(__SyntaxToken kReturns, TypeReferenceSyntax returnType)
	    {
	        if (this.KReturns != kReturns || this.ReturnType != returnType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.TokenBlock1Alt1Block1(kReturns, returnType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (TokenBlock1Alt1Block1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTokenBlock1Alt1Block1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTokenBlock1Alt1Block1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitTokenBlock1Alt1Block1(this);
	    }
	
	}
	
	public sealed class ArrayExpressionItemsBlockSyntax : CompilerSyntaxNode
	{
		private SingleExpressionSyntax _items;
	
	    public ArrayExpressionItemsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ArrayExpressionItemsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TComma 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ArrayExpressionItemsBlockGreen)this.Green;
	var greenToken = green.TComma;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public SingleExpressionSyntax Items 
		{ 
		get
		{
				var red = this.GetRed(ref this._items, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._items, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._items;
			default: return null;
	        }
	    }
	
	public ArrayExpressionItemsBlockSyntax WithTComma(__SyntaxToken tComma)
		{
		return this.Update(tComma, this.Items);
	}
	
	public ArrayExpressionItemsBlockSyntax WithItems(SingleExpressionSyntax items)
		{
		return this.Update(this.TComma, items);
	}
	
	    public ArrayExpressionItemsBlockSyntax Update(__SyntaxToken tComma, SingleExpressionSyntax items)
	    {
	        if (this.TComma != tComma || this.Items != items)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ArrayExpressionItemsBlock(tComma, items);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ArrayExpressionItemsBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitArrayExpressionItemsBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitArrayExpressionItemsBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitArrayExpressionItemsBlock(this);
	    }
	
	}
	
	public sealed class ParserAnnotationBlock1ArgumentsBlockSyntax : CompilerSyntaxNode
	{
		private AnnotationArgumentSyntax _arguments;
	
	    public ParserAnnotationBlock1ArgumentsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParserAnnotationBlock1ArgumentsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TComma 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationBlock1ArgumentsBlockGreen)this.Green;
	var greenToken = green.TComma;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public AnnotationArgumentSyntax Arguments 
		{ 
		get
		{
				var red = this.GetRed(ref this._arguments, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._arguments, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._arguments;
			default: return null;
	        }
	    }
	
	public ParserAnnotationBlock1ArgumentsBlockSyntax WithTComma(__SyntaxToken tComma)
		{
		return this.Update(tComma, this.Arguments);
	}
	
	public ParserAnnotationBlock1ArgumentsBlockSyntax WithArguments(AnnotationArgumentSyntax arguments)
		{
		return this.Update(this.TComma, arguments);
	}
	
	    public ParserAnnotationBlock1ArgumentsBlockSyntax Update(__SyntaxToken tComma, AnnotationArgumentSyntax arguments)
	    {
	        if (this.TComma != tComma || this.Arguments != arguments)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserAnnotationBlock1ArgumentsBlock(tComma, arguments);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ParserAnnotationBlock1ArgumentsBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParserAnnotationBlock1ArgumentsBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParserAnnotationBlock1ArgumentsBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitParserAnnotationBlock1ArgumentsBlock(this);
	    }
	
	}
	
	public sealed class LexerAnnotationBlock1ArgumentsBlockSyntax : CompilerSyntaxNode
	{
		private AnnotationArgumentSyntax _arguments;
	
	    public LexerAnnotationBlock1ArgumentsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LexerAnnotationBlock1ArgumentsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TComma 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationBlock1ArgumentsBlockGreen)this.Green;
	var greenToken = green.TComma;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public AnnotationArgumentSyntax Arguments 
		{ 
		get
		{
				var red = this.GetRed(ref this._arguments, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._arguments, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._arguments;
			default: return null;
	        }
	    }
	
	public LexerAnnotationBlock1ArgumentsBlockSyntax WithTComma(__SyntaxToken tComma)
		{
		return this.Update(tComma, this.Arguments);
	}
	
	public LexerAnnotationBlock1ArgumentsBlockSyntax WithArguments(AnnotationArgumentSyntax arguments)
		{
		return this.Update(this.TComma, arguments);
	}
	
	    public LexerAnnotationBlock1ArgumentsBlockSyntax Update(__SyntaxToken tComma, AnnotationArgumentSyntax arguments)
	    {
	        if (this.TComma != tComma || this.Arguments != arguments)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerAnnotationBlock1ArgumentsBlock(tComma, arguments);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (LexerAnnotationBlock1ArgumentsBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLexerAnnotationBlock1ArgumentsBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLexerAnnotationBlock1ArgumentsBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitLexerAnnotationBlock1ArgumentsBlock(this);
	    }
	
	}
}
