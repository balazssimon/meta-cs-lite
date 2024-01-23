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
		private DeclarationsSyntax _declarations;
	
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
	public DeclarationsSyntax Declarations 
		{ 
		get
		{
				var red = this.GetRed(ref this._declarations, 4);
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
			case 4: return this.GetRed(ref this._declarations, 4);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._qualifier;
			case 3: return this._usingList;
			case 4: return this._declarations;
			default: return null;
	        }
	    }
	
	public MainSyntax WithKNamespace(__SyntaxToken kNamespace)
		{
		return this.Update(kNamespace, this.Qualifier, this.TSemicolon, this.UsingList, this.Declarations, this.EndOfFileToken);
	}
	
	public MainSyntax WithQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
		{
		return this.Update(this.KNamespace, qualifier, this.TSemicolon, this.UsingList, this.Declarations, this.EndOfFileToken);
	}
	
	public MainSyntax AddQualifier(params IdentifierSyntax[] qualifier)
		{
		return this.WithQualifier(this.Qualifier.AddRange(qualifier));
	}
	
	public MainSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.KNamespace, this.Qualifier, tSemicolon, this.UsingList, this.Declarations, this.EndOfFileToken);
	}
	
	public MainSyntax WithUsingList(global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList)
		{
		return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, usingList, this.Declarations, this.EndOfFileToken);
	}
	
	public MainSyntax AddUsingList(params UsingSyntax[] usingList)
		{
		return this.WithUsingList(this.UsingList.AddRange(usingList));
	}
	
	public MainSyntax WithDeclarations(DeclarationsSyntax declarations)
		{
		return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, this.UsingList, declarations, this.EndOfFileToken);
	}
	
	public MainSyntax WithEndOfFileToken(__SyntaxToken endOfFileToken)
		{
		return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, this.UsingList, this.Declarations, endOfFileToken);
	}
	
	    public MainSyntax Update(__SyntaxToken kNamespace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, __SyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, DeclarationsSyntax declarations, __SyntaxToken endOfFileToken)
	    {
	        if (this.KNamespace != kNamespace || this.Qualifier != qualifier || this.TSemicolon != tSemicolon || this.UsingList != usingList || this.Declarations != declarations || this.EndOfFileToken != endOfFileToken)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Main(kNamespace, qualifier, tSemicolon, usingList, declarations, endOfFileToken);
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
	
	public sealed class DeclarationsSyntax : CompilerSyntaxNode
	{
		private LanguageDeclarationSyntax _declarations1;
		private __SyntaxNode _declarations2;
	
	    public DeclarationsSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public DeclarationsSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public LanguageDeclarationSyntax Declarations1 
		{ 
		get
		{
				var red = this.GetRed(ref this._declarations1, 0);
	return red;
	} 
	}
	public global::MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> Declarations2 
		{ 
		get
		{
				var red = this.GetRed(ref this._declarations2, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax>(red);
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._declarations1, 0);
			case 1: return this.GetRed(ref this._declarations2, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._declarations1;
			case 1: return this._declarations2;
			default: return null;
	        }
	    }
	
	public DeclarationsSyntax WithDeclarations1(LanguageDeclarationSyntax declarations1)
		{
		return this.Update(declarations1, this.Declarations2);
	}
	
	public DeclarationsSyntax WithDeclarations2(global::MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> declarations2)
		{
		return this.Update(this.Declarations1, declarations2);
	}
	
	public DeclarationsSyntax AddDeclarations2(params RuleSyntax[] declarations2)
		{
		return this.WithDeclarations2(this.Declarations2.AddRange(declarations2));
	}
	
	    public DeclarationsSyntax Update(LanguageDeclarationSyntax declarations1, global::MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> declarations2)
	    {
	        if (this.Declarations1 != declarations1 || this.Declarations2 != declarations2)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Declarations(declarations1, declarations2);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	
	public sealed class GrammarRuleAlt1Syntax : GrammarRuleSyntax
	{
		private RuleSyntax _rule;
	
	    public GrammarRuleAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public GrammarRuleAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public RuleSyntax Rule 
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
	
	public GrammarRuleAlt1Syntax WithRule(RuleSyntax rule)
		{
		return this.Update(rule);
	}
	
	    public GrammarRuleAlt1Syntax Update(RuleSyntax rule)
	    {
	        if (this.Rule != rule)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.GrammarRuleAlt1(rule);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (GrammarRuleAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitGrammarRuleAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitGrammarRuleAlt1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitGrammarRuleAlt1(this);
	    }
	
	}
	public sealed class BlockSyntax : GrammarRuleSyntax
	{
		private __SyntaxNode _annotations1;
		private NameSyntax _name;
		private BlockBlock1Syntax _block;
		private __SyntaxNode _alternatives;
	
	    public BlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
	public __SyntaxToken KBlock 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockGreen)this.Green;
	var greenToken = green.KBlock;
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
	public BlockBlock1Syntax Block 
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
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockGreen)this.Green;
	var greenToken = green.TColon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 5);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax>(red, this.GetChildIndex(5), reversed: false);
	} 
	}
	public __SyntaxToken TSemicolon 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(6), this.GetChildIndex(6));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._annotations1, 0);
			case 2: return this.GetRed(ref this._name, 2);
			case 3: return this.GetRed(ref this._block, 3);
			case 5: return this.GetRed(ref this._alternatives, 5);
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
			case 5: return this._alternatives;
			default: return null;
	        }
	    }
	
	public BlockSyntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
		{
		return this.Update(annotations1, this.KBlock, this.Name, this.Block, this.TColon, this.Alternatives, this.TSemicolon);
	}
	
	public BlockSyntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
		{
		return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
	}
	
	public BlockSyntax WithKBlock(__SyntaxToken kBlock)
		{
		return this.Update(this.Annotations1, kBlock, this.Name, this.Block, this.TColon, this.Alternatives, this.TSemicolon);
	}
	
	public BlockSyntax WithName(NameSyntax name)
		{
		return this.Update(this.Annotations1, this.KBlock, name, this.Block, this.TColon, this.Alternatives, this.TSemicolon);
	}
	
	public BlockSyntax WithBlock(BlockBlock1Syntax block)
		{
		return this.Update(this.Annotations1, this.KBlock, this.Name, block, this.TColon, this.Alternatives, this.TSemicolon);
	}
	
	public BlockSyntax WithTColon(__SyntaxToken tColon)
		{
		return this.Update(this.Annotations1, this.KBlock, this.Name, this.Block, tColon, this.Alternatives, this.TSemicolon);
	}
	
	public BlockSyntax WithAlternatives(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives)
		{
		return this.Update(this.Annotations1, this.KBlock, this.Name, this.Block, this.TColon, alternatives, this.TSemicolon);
	}
	
	public BlockSyntax AddAlternatives(params AlternativeSyntax[] alternatives)
		{
		return this.WithAlternatives(this.Alternatives.AddRange(alternatives));
	}
	
	public BlockSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.Annotations1, this.KBlock, this.Name, this.Block, this.TColon, this.Alternatives, tSemicolon);
	}
	
	    public BlockSyntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken kBlock, NameSyntax name, BlockBlock1Syntax block, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
	    {
	        if (this.Annotations1 != annotations1 || this.KBlock != kBlock || this.Name != name || this.Block != block || this.TColon != tColon || this.Alternatives != alternatives || this.TSemicolon != tSemicolon)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Block(annotations1, kBlock, name, block, tColon, alternatives, tSemicolon);
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
	
	public sealed class RuleSyntax : CompilerSyntaxNode
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
		private __SyntaxNode _valueAnnotations;
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
	public global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> ValueAnnotations 
		{ 
		get
		{
				var red = this.GetRed(ref this._valueAnnotations, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax>(red);
	} 
	}
	public ElementValueSyntax Value 
		{ 
		get
		{
				var red = this.GetRed(ref this._value, 2);
	return red;
	} 
	}
	public __SyntaxToken Multiplicity 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ElementGreen)this.Green;
	var greenToken = green.Multiplicity;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._block, 0);
			case 1: return this.GetRed(ref this._valueAnnotations, 1);
			case 2: return this.GetRed(ref this._value, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._block;
			case 1: return this._valueAnnotations;
			case 2: return this._value;
			default: return null;
	        }
	    }
	
	public ElementSyntax WithBlock(ElementBlock1Syntax block)
		{
		return this.Update(block, this.ValueAnnotations, this.Value, this.Multiplicity);
	}
	
	public ElementSyntax WithValueAnnotations(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> valueAnnotations)
		{
		return this.Update(this.Block, valueAnnotations, this.Value, this.Multiplicity);
	}
	
	public ElementSyntax AddValueAnnotations(params ParserAnnotationSyntax[] valueAnnotations)
		{
		return this.WithValueAnnotations(this.ValueAnnotations.AddRange(valueAnnotations));
	}
	
	public ElementSyntax WithValue(ElementValueSyntax value)
		{
		return this.Update(this.Block, this.ValueAnnotations, value, this.Multiplicity);
	}
	
	public ElementSyntax WithMultiplicity(__SyntaxToken multiplicity)
		{
		return this.Update(this.Block, this.ValueAnnotations, this.Value, multiplicity);
	}
	
	    public ElementSyntax Update(ElementBlock1Syntax block, global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> valueAnnotations, ElementValueSyntax value, __SyntaxToken multiplicity)
	    {
	        if (this.Block != block || this.ValueAnnotations != valueAnnotations || this.Value != value || this.Multiplicity != multiplicity)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.Element(block, valueAnnotations, value, multiplicity);
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
	public abstract class ElementValueSyntax : CompilerSyntaxNode
	{
	    protected ElementValueSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ElementValueSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ElementValueTokensSyntax : ElementValueSyntax
	{
	
	    public ElementValueTokensSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ElementValueTokensSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Token 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ElementValueTokensGreen)this.Green;
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
	
	public ElementValueTokensSyntax WithToken(__SyntaxToken token)
		{
		return this.Update(token);
	}
	
	    public ElementValueTokensSyntax Update(__SyntaxToken token)
	    {
	        if (this.Token != token)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ElementValueTokens(token);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ElementValueTokensSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitElementValueTokens(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitElementValueTokens(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitElementValueTokens(this);
	    }
	
	}
	public sealed class BlockInlineSyntax : ElementValueSyntax
	{
		private __SyntaxNode _alternatives;
	
	    public BlockInlineSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BlockInlineSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TLParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockInlineGreen)this.Green;
	var greenToken = green.TLParen;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> Alternatives 
		{ 
		get
		{
				var red = this.GetRed(ref this._alternatives, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public __SyntaxToken TRParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockInlineGreen)this.Green;
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
	
	public BlockInlineSyntax WithTLParen(__SyntaxToken tLParen)
		{
		return this.Update(tLParen, this.Alternatives, this.TRParen);
	}
	
	public BlockInlineSyntax WithAlternatives(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives)
		{
		return this.Update(this.TLParen, alternatives, this.TRParen);
	}
	
	public BlockInlineSyntax AddAlternatives(params AlternativeSyntax[] alternatives)
		{
		return this.WithAlternatives(this.Alternatives.AddRange(alternatives));
	}
	
	public BlockInlineSyntax WithTRParen(__SyntaxToken tRParen)
		{
		return this.Update(this.TLParen, this.Alternatives, tRParen);
	}
	
	    public BlockInlineSyntax Update(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives, __SyntaxToken tRParen)
	    {
	        if (this.TLParen != tLParen || this.Alternatives != alternatives || this.TRParen != tRParen)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.BlockInline(tLParen, alternatives, tRParen);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (BlockInlineSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBlockInline(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBlockInline(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitBlockInline(this);
	    }
	
	}
	public sealed class RuleRefAlt1Syntax : ElementValueSyntax
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
	public sealed class RuleRefAlt2Syntax : ElementValueSyntax
	{
		private ReturnTypeQualifierSyntax _referencedTypes;
	
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
	public ReturnTypeQualifierSyntax ReferencedTypes 
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
	
	public RuleRefAlt2Syntax WithReferencedTypes(ReturnTypeQualifierSyntax referencedTypes)
		{
		return this.Update(this.THash, referencedTypes);
	}
	
	    public RuleRefAlt2Syntax Update(__SyntaxToken tHash, ReturnTypeQualifierSyntax referencedTypes)
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
	public sealed class RuleRefAlt3Syntax : ElementValueSyntax
	{
		private __SyntaxNode _referencedTypes;
	
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
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> ReferencedTypes 
		{ 
		get
		{
				var red = this.GetRed(ref this._referencedTypes, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public __SyntaxToken TRBrace 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleRefAlt3Green)this.Green;
	var greenToken = green.TRBrace;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
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
	
	public RuleRefAlt3Syntax WithTHashLBrace(__SyntaxToken tHashLBrace)
		{
		return this.Update(tHashLBrace, this.ReferencedTypes, this.TRBrace);
	}
	
	public RuleRefAlt3Syntax WithReferencedTypes(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> referencedTypes)
		{
		return this.Update(this.THashLBrace, referencedTypes, this.TRBrace);
	}
	
	public RuleRefAlt3Syntax AddReferencedTypes(params ReturnTypeQualifierSyntax[] referencedTypes)
		{
		return this.WithReferencedTypes(this.ReferencedTypes.AddRange(referencedTypes));
	}
	
	public RuleRefAlt3Syntax WithTRBrace(__SyntaxToken tRBrace)
		{
		return this.Update(this.THashLBrace, this.ReferencedTypes, tRBrace);
	}
	
	    public RuleRefAlt3Syntax Update(__SyntaxToken tHashLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> referencedTypes, __SyntaxToken tRBrace)
	    {
	        if (this.THashLBrace != tHashLBrace || this.ReferencedTypes != referencedTypes || this.TRBrace != tRBrace)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleRefAlt3(tHashLBrace, referencedTypes, tRBrace);
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
		private AnnotationArgumentsSyntax _annotationArguments;
	
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
	public AnnotationArgumentsSyntax AnnotationArguments 
		{ 
		get
		{
				var red = this.GetRed(ref this._annotationArguments, 2);
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
			case 2: return this.GetRed(ref this._annotationArguments, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._qualifier;
			case 2: return this._annotationArguments;
			default: return null;
	        }
	    }
	
	public ParserAnnotationSyntax WithTLBracket(__SyntaxToken tLBracket)
		{
		return this.Update(tLBracket, this.Qualifier, this.AnnotationArguments, this.TRBracket);
	}
	
	public ParserAnnotationSyntax WithQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
		{
		return this.Update(this.TLBracket, qualifier, this.AnnotationArguments, this.TRBracket);
	}
	
	public ParserAnnotationSyntax AddQualifier(params IdentifierSyntax[] qualifier)
		{
		return this.WithQualifier(this.Qualifier.AddRange(qualifier));
	}
	
	public ParserAnnotationSyntax WithAnnotationArguments(AnnotationArgumentsSyntax annotationArguments)
		{
		return this.Update(this.TLBracket, this.Qualifier, annotationArguments, this.TRBracket);
	}
	
	public ParserAnnotationSyntax WithTRBracket(__SyntaxToken tRBracket)
		{
		return this.Update(this.TLBracket, this.Qualifier, this.AnnotationArguments, tRBracket);
	}
	
	    public ParserAnnotationSyntax Update(__SyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, AnnotationArgumentsSyntax annotationArguments, __SyntaxToken tRBracket)
	    {
	        if (this.TLBracket != tLBracket || this.Qualifier != qualifier || this.AnnotationArguments != annotationArguments || this.TRBracket != tRBracket)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserAnnotation(tLBracket, qualifier, annotationArguments, tRBracket);
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
		private AnnotationArgumentsSyntax _annotationArguments;
	
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
	public AnnotationArgumentsSyntax AnnotationArguments 
		{ 
		get
		{
				var red = this.GetRed(ref this._annotationArguments, 2);
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
			case 2: return this.GetRed(ref this._annotationArguments, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._qualifier;
			case 2: return this._annotationArguments;
			default: return null;
	        }
	    }
	
	public LexerAnnotationSyntax WithTLBracket(__SyntaxToken tLBracket)
		{
		return this.Update(tLBracket, this.Qualifier, this.AnnotationArguments, this.TRBracket);
	}
	
	public LexerAnnotationSyntax WithQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
		{
		return this.Update(this.TLBracket, qualifier, this.AnnotationArguments, this.TRBracket);
	}
	
	public LexerAnnotationSyntax AddQualifier(params IdentifierSyntax[] qualifier)
		{
		return this.WithQualifier(this.Qualifier.AddRange(qualifier));
	}
	
	public LexerAnnotationSyntax WithAnnotationArguments(AnnotationArgumentsSyntax annotationArguments)
		{
		return this.Update(this.TLBracket, this.Qualifier, annotationArguments, this.TRBracket);
	}
	
	public LexerAnnotationSyntax WithTRBracket(__SyntaxToken tRBracket)
		{
		return this.Update(this.TLBracket, this.Qualifier, this.AnnotationArguments, tRBracket);
	}
	
	    public LexerAnnotationSyntax Update(__SyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, AnnotationArgumentsSyntax annotationArguments, __SyntaxToken tRBracket)
	    {
	        if (this.TLBracket != tLBracket || this.Qualifier != qualifier || this.AnnotationArguments != annotationArguments || this.TRBracket != tRBracket)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerAnnotation(tLBracket, qualifier, annotationArguments, tRBracket);
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
	
	public sealed class AnnotationArgumentsSyntax : CompilerSyntaxNode
	{
		private __SyntaxNode _arguments;
	
	    public AnnotationArgumentsSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AnnotationArgumentsSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TLParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AnnotationArgumentsGreen)this.Green;
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
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AnnotationArgumentsGreen)this.Green;
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
	
	public AnnotationArgumentsSyntax WithTLParen(__SyntaxToken tLParen)
		{
		return this.Update(tLParen, this.Arguments, this.TRParen);
	}
	
	public AnnotationArgumentsSyntax WithArguments(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments)
		{
		return this.Update(this.TLParen, arguments, this.TRParen);
	}
	
	public AnnotationArgumentsSyntax AddArguments(params AnnotationArgumentSyntax[] arguments)
		{
		return this.WithArguments(this.Arguments.AddRange(arguments));
	}
	
	public AnnotationArgumentsSyntax WithTRParen(__SyntaxToken tRParen)
		{
		return this.Update(this.TLParen, this.Arguments, tRParen);
	}
	
	    public AnnotationArgumentsSyntax Update(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments, __SyntaxToken tRParen)
	    {
	        if (this.TLParen != tLParen || this.Arguments != arguments || this.TRParen != tRParen)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.AnnotationArguments(tLParen, arguments, tRParen);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	public abstract class ReturnTypeIdentifierSyntax : CompilerSyntaxNode
	{
	    protected ReturnTypeIdentifierSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ReturnTypeIdentifierSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ReturnTypeIdentifierAlt1Syntax : ReturnTypeIdentifierSyntax
	{
	
	    public ReturnTypeIdentifierAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ReturnTypeIdentifierAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Tokens 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ReturnTypeIdentifierAlt1Green)this.Green;
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
	
	public ReturnTypeIdentifierAlt1Syntax WithTokens(__SyntaxToken tokens)
		{
		return this.Update(tokens);
	}
	
	    public ReturnTypeIdentifierAlt1Syntax Update(__SyntaxToken tokens)
	    {
	        if (this.Tokens != tokens)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ReturnTypeIdentifierAlt1(tokens);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	
	    public ReturnTypeIdentifierAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ReturnTypeIdentifierAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	    protected ReturnTypeQualifierSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ReturnTypeQualifierSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ReturnTypeQualifierAlt1Syntax : ReturnTypeQualifierSyntax
	{
	
	    public ReturnTypeQualifierAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ReturnTypeQualifierAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Tokens 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.ReturnTypeQualifierAlt1Green)this.Green;
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
	
	public ReturnTypeQualifierAlt1Syntax WithTokens(__SyntaxToken tokens)
		{
		return this.Update(tokens);
	}
	
	    public ReturnTypeQualifierAlt1Syntax Update(__SyntaxToken tokens)
	    {
	        if (this.Tokens != tokens)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ReturnTypeQualifierAlt1(tokens);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
		private __SyntaxNode _qualifier;
	
	    public ReturnTypeQualifierAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ReturnTypeQualifierAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
	
	public ReturnTypeQualifierAlt2Syntax WithQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
		{
		return this.Update(qualifier);
	}
	
	public ReturnTypeQualifierAlt2Syntax AddQualifier(params IdentifierSyntax[] qualifier)
		{
		return this.WithQualifier(this.Qualifier.AddRange(qualifier));
	}
	
	    public ReturnTypeQualifierAlt2Syntax Update(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
	    {
	        if (this.Qualifier != qualifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ReturnTypeQualifierAlt2(qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
	
	public sealed class SimpleIdentifierSyntax : CompilerSyntaxNode
	{
	
	    public SimpleIdentifierSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SimpleIdentifierSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TIdentifier 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.SimpleIdentifierGreen)this.Green;
	var greenToken = green.TIdentifier;
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
	
	public SimpleIdentifierSyntax WithTIdentifier(__SyntaxToken tIdentifier)
		{
		return this.Update(tIdentifier);
	}
	
	    public SimpleIdentifierSyntax Update(__SyntaxToken tIdentifier)
	    {
	        if (this.TIdentifier != tIdentifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SimpleIdentifier(tIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
		private ReturnTypeIdentifierSyntax _returnType;
	
	    public RuleBlock1Alt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public RuleBlock1Alt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public ReturnTypeIdentifierSyntax ReturnType 
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
	
	public RuleBlock1Alt1Syntax WithReturnType(ReturnTypeIdentifierSyntax returnType)
		{
		return this.Update(returnType);
	}
	
	    public RuleBlock1Alt1Syntax Update(ReturnTypeIdentifierSyntax returnType)
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
		private ReturnTypeQualifierSyntax _returnType;
	
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
	public ReturnTypeQualifierSyntax ReturnType 
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
	
	public RuleBlock1Alt2Syntax WithReturnType(ReturnTypeQualifierSyntax returnType)
		{
		return this.Update(this.Identifier, this.KReturns, returnType);
	}
	
	    public RuleBlock1Alt2Syntax Update(IdentifierSyntax identifier, __SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
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
	
	public sealed class BlockBlock1Syntax : CompilerSyntaxNode
	{
		private ReturnTypeQualifierSyntax _returnType;
	
	    public BlockBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BlockBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KReturns 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockBlock1Green)this.Green;
	var greenToken = green.KReturns;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public ReturnTypeQualifierSyntax ReturnType 
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
	
	public BlockBlock1Syntax WithKReturns(__SyntaxToken kReturns)
		{
		return this.Update(kReturns, this.ReturnType);
	}
	
	public BlockBlock1Syntax WithReturnType(ReturnTypeQualifierSyntax returnType)
		{
		return this.Update(this.KReturns, returnType);
	}
	
	    public BlockBlock1Syntax Update(__SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
	    {
	        if (this.KReturns != kReturns || this.ReturnType != returnType)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.BlockBlock1(kReturns, returnType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (BlockBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBlockBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBlockBlock1(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitBlockBlock1(this);
	    }
	
	}
	
	public sealed class BlockAlternativesBlockSyntax : CompilerSyntaxNode
	{
		private AlternativeSyntax _alternatives;
	
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
	
	public BlockAlternativesBlockSyntax WithTBar(__SyntaxToken tBar)
		{
		return this.Update(tBar, this.Alternatives);
	}
	
	public BlockAlternativesBlockSyntax WithAlternatives(AlternativeSyntax alternatives)
		{
		return this.Update(this.TBar, alternatives);
	}
	
	    public BlockAlternativesBlockSyntax Update(__SyntaxToken tBar, AlternativeSyntax alternatives)
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
	
	public sealed class BlockInlineAlternativesBlockSyntax : CompilerSyntaxNode
	{
		private AlternativeSyntax _alternatives;
	
	    public BlockInlineAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BlockInlineAlternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TBar 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockInlineAlternativesBlockGreen)this.Green;
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
	
	public BlockInlineAlternativesBlockSyntax WithTBar(__SyntaxToken tBar)
		{
		return this.Update(tBar, this.Alternatives);
	}
	
	public BlockInlineAlternativesBlockSyntax WithAlternatives(AlternativeSyntax alternatives)
		{
		return this.Update(this.TBar, alternatives);
	}
	
	    public BlockInlineAlternativesBlockSyntax Update(__SyntaxToken tBar, AlternativeSyntax alternatives)
	    {
	        if (this.TBar != tBar || this.Alternatives != alternatives)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.BlockInlineAlternativesBlock(tBar, alternatives);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (BlockInlineAlternativesBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBlockInlineAlternativesBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBlockInlineAlternativesBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitBlockInlineAlternativesBlock(this);
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
	
	public sealed class AlternativeBlock1Block1Syntax : CompilerSyntaxNode
	{
		private ReturnTypeQualifierSyntax _returnType;
	
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
	public ReturnTypeQualifierSyntax ReturnType 
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
	
	public AlternativeBlock1Block1Syntax WithReturnType(ReturnTypeQualifierSyntax returnType)
		{
		return this.Update(this.KReturns, returnType);
	}
	
	    public AlternativeBlock1Block1Syntax Update(__SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
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
		private __SyntaxNode _nameAnnotations;
		private IdentifierSyntax _symbolProperty;
	
	    public ElementBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ElementBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> NameAnnotations 
		{ 
		get
		{
				var red = this.GetRed(ref this._nameAnnotations, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax>(red);
	} 
	}
	public IdentifierSyntax SymbolProperty 
		{ 
		get
		{
				var red = this.GetRed(ref this._symbolProperty, 1);
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
			case 0: return this.GetRed(ref this._nameAnnotations, 0);
			case 1: return this.GetRed(ref this._symbolProperty, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._nameAnnotations;
			case 1: return this._symbolProperty;
			default: return null;
	        }
	    }
	
	public ElementBlock1Syntax WithNameAnnotations(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> nameAnnotations)
		{
		return this.Update(nameAnnotations, this.SymbolProperty, this.Assignment);
	}
	
	public ElementBlock1Syntax AddNameAnnotations(params ParserAnnotationSyntax[] nameAnnotations)
		{
		return this.WithNameAnnotations(this.NameAnnotations.AddRange(nameAnnotations));
	}
	
	public ElementBlock1Syntax WithSymbolProperty(IdentifierSyntax symbolProperty)
		{
		return this.Update(this.NameAnnotations, symbolProperty, this.Assignment);
	}
	
	public ElementBlock1Syntax WithAssignment(__SyntaxToken assignment)
		{
		return this.Update(this.NameAnnotations, this.SymbolProperty, assignment);
	}
	
	    public ElementBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> nameAnnotations, IdentifierSyntax symbolProperty, __SyntaxToken assignment)
	    {
	        if (this.NameAnnotations != nameAnnotations || this.SymbolProperty != symbolProperty || this.Assignment != assignment)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.ElementBlock1(nameAnnotations, symbolProperty, assignment);
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
	
	public sealed class RuleRefAlt3ReferencedTypesBlockSyntax : CompilerSyntaxNode
	{
		private ReturnTypeQualifierSyntax _referencedTypes;
	
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
	public ReturnTypeQualifierSyntax ReferencedTypes 
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
	
	public RuleRefAlt3ReferencedTypesBlockSyntax WithReferencedTypes(ReturnTypeQualifierSyntax referencedTypes)
		{
		return this.Update(this.TComma, referencedTypes);
	}
	
	    public RuleRefAlt3ReferencedTypesBlockSyntax Update(__SyntaxToken tComma, ReturnTypeQualifierSyntax referencedTypes)
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
	
	public sealed class TokenBlock1Alt1Block1Syntax : CompilerSyntaxNode
	{
		private ReturnTypeQualifierSyntax _returnType;
	
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
	public ReturnTypeQualifierSyntax ReturnType 
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
	
	public TokenBlock1Alt1Block1Syntax WithReturnType(ReturnTypeQualifierSyntax returnType)
		{
		return this.Update(this.KReturns, returnType);
	}
	
	    public TokenBlock1Alt1Block1Syntax Update(__SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
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
	
	public sealed class TokensSyntax : SingleExpressionBlock1Syntax
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
	public sealed class SingleExpressionBlock1Alt2Syntax : SingleExpressionBlock1Syntax
	{
		private __SyntaxNode _simpleQualifier;
	
	    public SingleExpressionBlock1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SingleExpressionBlock1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SimpleIdentifierSyntax> SimpleQualifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._simpleQualifier, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SimpleIdentifierSyntax>(red, this.GetChildIndex(0), reversed: false);
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._simpleQualifier, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._simpleQualifier;
			default: return null;
	        }
	    }
	
	public SingleExpressionBlock1Alt2Syntax WithSimpleQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SimpleIdentifierSyntax> simpleQualifier)
		{
		return this.Update(simpleQualifier);
	}
	
	public SingleExpressionBlock1Alt2Syntax AddSimpleQualifier(params SimpleIdentifierSyntax[] simpleQualifier)
		{
		return this.WithSimpleQualifier(this.SimpleQualifier.AddRange(simpleQualifier));
	}
	
	    public SingleExpressionBlock1Alt2Syntax Update(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SimpleIdentifierSyntax> simpleQualifier)
	    {
	        if (this.SimpleQualifier != simpleQualifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionBlock1Alt2(simpleQualifier);
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
	
	public sealed class AnnotationArgumentsArgumentsBlockSyntax : CompilerSyntaxNode
	{
		private AnnotationArgumentSyntax _arguments;
	
	    public AnnotationArgumentsArgumentsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AnnotationArgumentsArgumentsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TComma 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.AnnotationArgumentsArgumentsBlockGreen)this.Green;
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
	
	public AnnotationArgumentsArgumentsBlockSyntax WithTComma(__SyntaxToken tComma)
		{
		return this.Update(tComma, this.Arguments);
	}
	
	public AnnotationArgumentsArgumentsBlockSyntax WithArguments(AnnotationArgumentSyntax arguments)
		{
		return this.Update(this.TComma, arguments);
	}
	
	    public AnnotationArgumentsArgumentsBlockSyntax Update(__SyntaxToken tComma, AnnotationArgumentSyntax arguments)
	    {
	        if (this.TComma != tComma || this.Arguments != arguments)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.AnnotationArgumentsArgumentsBlock(tComma, arguments);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (AnnotationArgumentsArgumentsBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitAnnotationArgumentsArgumentsBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitAnnotationArgumentsArgumentsBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitAnnotationArgumentsArgumentsBlock(this);
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
	
	public sealed class SingleExpressionBlock1Alt2SimpleQualifierBlockSyntax : CompilerSyntaxNode
	{
		private SimpleIdentifierSyntax _simpleIdentifier;
	
	    public SingleExpressionBlock1Alt2SimpleQualifierBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SingleExpressionBlock1Alt2SimpleQualifierBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TDot 
		{ 
		get
		{
				var green = (global::MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax.SingleExpressionBlock1Alt2SimpleQualifierBlockGreen)this.Green;
	var greenToken = green.TDot;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public SimpleIdentifierSyntax SimpleIdentifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._simpleIdentifier, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._simpleIdentifier, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._simpleIdentifier;
			default: return null;
	        }
	    }
	
	public SingleExpressionBlock1Alt2SimpleQualifierBlockSyntax WithTDot(__SyntaxToken tDot)
		{
		return this.Update(tDot, this.SimpleIdentifier);
	}
	
	public SingleExpressionBlock1Alt2SimpleQualifierBlockSyntax WithSimpleIdentifier(SimpleIdentifierSyntax simpleIdentifier)
		{
		return this.Update(this.TDot, simpleIdentifier);
	}
	
	    public SingleExpressionBlock1Alt2SimpleQualifierBlockSyntax Update(__SyntaxToken tDot, SimpleIdentifierSyntax simpleIdentifier)
	    {
	        if (this.TDot != tDot || this.SimpleIdentifier != simpleIdentifier)
	        {
	            var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionBlock1Alt2SimpleQualifierBlock(tDot, simpleIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (SingleExpressionBlock1Alt2SimpleQualifierBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt2SimpleQualifierBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSingleExpressionBlock1Alt2SimpleQualifierBlock(this);
	    }
	
	    public override void Accept(ICompilerSyntaxVisitor visitor)
	    {
	        visitor.VisitSingleExpressionBlock1Alt2SimpleQualifierBlock(this);
	    }
	
	}
}
