#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax
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

    public abstract class MetaSyntaxNode : __SyntaxNode
    {
        protected MetaSyntaxNode(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }

        protected MetaSyntaxNode(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public override __Language Language => MetaLanguage.Instance;
        public MetaSyntaxKind Kind => (MetaSyntaxKind)this.RawKind;
		internal new __GreenNode Green => base.Green;

        protected override __SyntaxTree CreateSyntaxTreeForRoot()
        {
            return MetaSyntaxTree.CreateWithoutClone(this, __IncrementalParseData.Empty);
        }

        public override TResult Accept<TArg, TResult>(global::MetaDslx.CodeAnalysis.SyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            if (visitor is IMetaSyntaxVisitor<TArg, TResult> typedVisitor) return this.Accept(typedVisitor, argument);
            else return visitor.DefaultVisit(this, argument);
        }

        public abstract TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument);

        public override TResult Accept<TResult>(global::MetaDslx.CodeAnalysis.SyntaxVisitor<TResult> visitor)
        {
            if (visitor is IMetaSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor);

        public override void Accept(global::MetaDslx.CodeAnalysis.SyntaxVisitor visitor)
        {
            if (visitor is IMetaSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }
        public abstract void Accept(IMetaSyntaxVisitor visitor);
    }

    /// <summary>
    /// It's a non terminal Trivia MetaSyntaxNode that has a tree underneath it.
    /// </summary>
    public abstract partial class MetaStructuredTriviaSyntax : MetaSyntaxNode, global::MetaDslx.CodeAnalysis.IStructuredTriviaSyntax
    {
        private __SyntaxTrivia _parent;
        internal MetaStructuredTriviaSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent == null ? null : (MetaSyntaxTree)parent.SyntaxTree, position)
        {
            System.Diagnostics.Debug.Assert(parent == null || position >= 0);
        }
		internal static MetaStructuredTriviaSyntax Create(__SyntaxTrivia trivia)
		{
			var red = (MetaStructuredTriviaSyntax)MetaLanguage.Instance.SyntaxFactory.CreateStructure(trivia);
			red._parent = trivia;
			return red;
		}
        /// <summary>
        /// Get parent trivia.
        /// </summary>
        public override __SyntaxTrivia ParentTrivia => _parent;
    }

    public sealed partial class MetaSkippedTokensTriviaSyntax : MetaStructuredTriviaSyntax
    {
        internal MetaSkippedTokensTriviaSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public __SyntaxTokenList Tokens 
        {
            get
            {
				var slot = ((global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.GreenSkippedTokensTriviaSyntax)this.Green).Tokens;
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

		public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
		{
			return visitor.VisitSkippedTokensTrivia(this, argument);
		}

		public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSkippedTokensTrivia(this);
        }

        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitSkippedTokensTrivia(this);
        }

        public MetaSkippedTokensTriviaSyntax Update(__SyntaxTokenList tokens)
        {
            if (tokens != this.Tokens)
            {
                var newNode = (MetaSkippedTokensTriviaSyntax)Language.SyntaxFactory.SkippedTokensTrivia(tokens);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    return __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return newNode;
            }
            return this;
        }

        public MetaSkippedTokensTriviaSyntax WithTokens(__SyntaxTokenList tokens)
        {
            return this.Update(tokens);
        }

        public MetaSkippedTokensTriviaSyntax AddTokens(params __SyntaxToken[] items)
        {
            return this.WithTokens(this.Tokens.AddRange(items));
        }
    }

	
	public sealed class MainSyntax : MetaSyntaxNode, global::MetaDslx.CodeAnalysis.ICompilationUnitSyntax
	{
		private QualifierSyntax _name;
		private __SyntaxNode _usingList;
		private DeclarationsSyntax _declarations;
	
	    public MainSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MainSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KNamespace 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
	var greenToken = green.KNamespace;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public QualifierSyntax Name 
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
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
	var greenToken = green.EndOfFileToken;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._name, 1);
			case 3: return this.GetRed(ref this._usingList, 3);
			case 4: return this.GetRed(ref this._declarations, 4);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._name;
			case 3: return this._usingList;
			case 4: return this._declarations;
			default: return null;
	        }
	    }
	
	public MainSyntax WithKNamespace(__SyntaxToken kNamespace)
		{
		return this.Update(kNamespace, this.Name, this.TSemicolon, this.UsingList, this.Declarations, this.EndOfFileToken);
	}
	
	public MainSyntax WithName(QualifierSyntax name)
		{
		return this.Update(this.KNamespace, name, this.TSemicolon, this.UsingList, this.Declarations, this.EndOfFileToken);
	}
	
	public MainSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.KNamespace, this.Name, tSemicolon, this.UsingList, this.Declarations, this.EndOfFileToken);
	}
	
	public MainSyntax WithUsingList(global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList)
		{
		return this.Update(this.KNamespace, this.Name, this.TSemicolon, usingList, this.Declarations, this.EndOfFileToken);
	}
	
	public MainSyntax AddUsingList(params UsingSyntax[] usingList)
		{
		return this.WithUsingList(this.UsingList.AddRange(usingList));
	}
	
	public MainSyntax WithDeclarations(DeclarationsSyntax declarations)
		{
		return this.Update(this.KNamespace, this.Name, this.TSemicolon, this.UsingList, declarations, this.EndOfFileToken);
	}
	
	public MainSyntax WithEndOfFileToken(__SyntaxToken endOfFileToken)
		{
		return this.Update(this.KNamespace, this.Name, this.TSemicolon, this.UsingList, this.Declarations, endOfFileToken);
	}
	
	    public MainSyntax Update(__SyntaxToken kNamespace, QualifierSyntax name, __SyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, DeclarationsSyntax declarations, __SyntaxToken endOfFileToken)
	    {
	        if (this.KNamespace != kNamespace || this.Name != name || this.TSemicolon != tSemicolon || this.UsingList != usingList || this.Declarations != declarations || this.EndOfFileToken != endOfFileToken)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Main(kNamespace, name, tSemicolon, usingList, declarations, endOfFileToken);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MainSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMain(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMain(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMain(this);
	    }
	
	}
	
	public sealed class UsingSyntax : MetaSyntaxNode
	{
		private QualifierSyntax _namespaces;
	
	    public UsingSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public UsingSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KUsing 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
	var greenToken = green.KUsing;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public QualifierSyntax Namespaces 
		{ 
		get
		{
				var red = this.GetRed(ref this._namespaces, 1);
	return red;
	} 
	}
	public __SyntaxToken TSemicolon 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._namespaces, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._namespaces;
			default: return null;
	        }
	    }
	
	public UsingSyntax WithKUsing(__SyntaxToken kUsing)
		{
		return this.Update(kUsing, this.Namespaces, this.TSemicolon);
	}
	
	public UsingSyntax WithNamespaces(QualifierSyntax namespaces)
		{
		return this.Update(this.KUsing, namespaces, this.TSemicolon);
	}
	
	public UsingSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.KUsing, this.Namespaces, tSemicolon);
	}
	
	    public UsingSyntax Update(__SyntaxToken kUsing, QualifierSyntax namespaces, __SyntaxToken tSemicolon)
	    {
	        if (this.KUsing != kUsing || this.Namespaces != namespaces || this.TSemicolon != tSemicolon)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Using(kUsing, namespaces, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (UsingSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitUsing(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitUsing(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitUsing(this);
	    }
	
	}
	
	public sealed class DeclarationsSyntax : MetaSyntaxNode
	{
		private __SyntaxNode _declarations;
	
	    public DeclarationsSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public DeclarationsSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public global::MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> Declarations 
		{ 
		get
		{
				var red = this.GetRed(ref this._declarations, 0);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax>(red);
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
	
	public DeclarationsSyntax WithDeclarations(global::MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> declarations)
		{
		return this.Update(declarations);
	}
	
	public DeclarationsSyntax AddDeclarations(params MetaDeclarationSyntax[] declarations)
		{
		return this.WithDeclarations(this.Declarations.AddRange(declarations));
	}
	
	    public DeclarationsSyntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> declarations)
	    {
	        if (this.Declarations != declarations)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Declarations(declarations);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (DeclarationsSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitDeclarations(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitDeclarations(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitDeclarations(this);
	    }
	
	}
	public abstract class MetaDeclarationSyntax : MetaSyntaxNode
	{
	    protected MetaDeclarationSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected MetaDeclarationSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class MetaModelSyntax : MetaDeclarationSyntax
	{
		private NameSyntax _name;
	
	    public MetaModelSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaModelSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KMetamodel 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaModelGreen)this.Green;
	var greenToken = green.KMetamodel;
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
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaModelGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
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
	
	public MetaModelSyntax WithKMetamodel(__SyntaxToken kMetamodel)
		{
		return this.Update(kMetamodel, this.Name, this.TSemicolon);
	}
	
	public MetaModelSyntax WithName(NameSyntax name)
		{
		return this.Update(this.KMetamodel, name, this.TSemicolon);
	}
	
	public MetaModelSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.KMetamodel, this.Name, tSemicolon);
	}
	
	    public MetaModelSyntax Update(__SyntaxToken kMetamodel, NameSyntax name, __SyntaxToken tSemicolon)
	    {
	        if (this.KMetamodel != kMetamodel || this.Name != name || this.TSemicolon != tSemicolon)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaModel(kMetamodel, name, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MetaModelSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaModel(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaModel(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaModel(this);
	    }
	
	}
	public sealed class MetaConstantSyntax : MetaDeclarationSyntax
	{
		private TypeReferenceSyntax _type;
		private NameSyntax _name;
	
	    public MetaConstantSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaConstantSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KConst 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaConstantGreen)this.Green;
	var greenToken = green.KConst;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public TypeReferenceSyntax Type 
		{ 
		get
		{
				var red = this.GetRed(ref this._type, 1);
	return red;
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
	public __SyntaxToken TSemicolon 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaConstantGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._type, 1);
			case 2: return this.GetRed(ref this._name, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._type;
			case 2: return this._name;
			default: return null;
	        }
	    }
	
	public MetaConstantSyntax WithKConst(__SyntaxToken kConst)
		{
		return this.Update(kConst, this.Type, this.Name, this.TSemicolon);
	}
	
	public MetaConstantSyntax WithType(TypeReferenceSyntax type)
		{
		return this.Update(this.KConst, type, this.Name, this.TSemicolon);
	}
	
	public MetaConstantSyntax WithName(NameSyntax name)
		{
		return this.Update(this.KConst, this.Type, name, this.TSemicolon);
	}
	
	public MetaConstantSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.KConst, this.Type, this.Name, tSemicolon);
	}
	
	    public MetaConstantSyntax Update(__SyntaxToken kConst, TypeReferenceSyntax type, NameSyntax name, __SyntaxToken tSemicolon)
	    {
	        if (this.KConst != kConst || this.Type != type || this.Name != name || this.TSemicolon != tSemicolon)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaConstant(kConst, type, name, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MetaConstantSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaConstant(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaConstant(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaConstant(this);
	    }
	
	}
	public sealed class MetaEnumSyntax : MetaDeclarationSyntax
	{
		private NameSyntax _name;
		private EnumBodySyntax _enumBody;
	
	    public MetaEnumSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaEnumSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KEnum 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaEnumGreen)this.Green;
	var greenToken = green.KEnum;
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
	public EnumBodySyntax EnumBody 
		{ 
		get
		{
				var red = this.GetRed(ref this._enumBody, 2);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._name, 1);
			case 2: return this.GetRed(ref this._enumBody, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._name;
			case 2: return this._enumBody;
			default: return null;
	        }
	    }
	
	public MetaEnumSyntax WithKEnum(__SyntaxToken kEnum)
		{
		return this.Update(kEnum, this.Name, this.EnumBody);
	}
	
	public MetaEnumSyntax WithName(NameSyntax name)
		{
		return this.Update(this.KEnum, name, this.EnumBody);
	}
	
	public MetaEnumSyntax WithEnumBody(EnumBodySyntax enumBody)
		{
		return this.Update(this.KEnum, this.Name, enumBody);
	}
	
	    public MetaEnumSyntax Update(__SyntaxToken kEnum, NameSyntax name, EnumBodySyntax enumBody)
	    {
	        if (this.KEnum != kEnum || this.Name != name || this.EnumBody != enumBody)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaEnum(kEnum, name, enumBody);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MetaEnumSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaEnum(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaEnum(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaEnum(this);
	    }
	
	}
	public sealed class MetaClassSyntax : MetaDeclarationSyntax
	{
		private ClassNameSyntax _className;
		private BaseClassesSyntax _baseClasses;
		private ClassBodySyntax _classBody;
	
	    public MetaClassSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaClassSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken IsAbstract 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaClassGreen)this.Green;
	var greenToken = green.IsAbstract;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public __SyntaxToken KClass 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaClassGreen)this.Green;
	var greenToken = green.KClass;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
	} 
	}
	public ClassNameSyntax ClassName 
		{ 
		get
		{
				var red = this.GetRed(ref this._className, 2);
	return red;
	} 
	}
	public BaseClassesSyntax BaseClasses 
		{ 
		get
		{
				var red = this.GetRed(ref this._baseClasses, 3);
	return red;
	} 
	}
	public ClassBodySyntax ClassBody 
		{ 
		get
		{
				var red = this.GetRed(ref this._classBody, 4);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 2: return this.GetRed(ref this._className, 2);
			case 3: return this.GetRed(ref this._baseClasses, 3);
			case 4: return this.GetRed(ref this._classBody, 4);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 2: return this._className;
			case 3: return this._baseClasses;
			case 4: return this._classBody;
			default: return null;
	        }
	    }
	
	public MetaClassSyntax WithIsAbstract(__SyntaxToken isAbstract)
		{
		return this.Update(isAbstract, this.KClass, this.ClassName, this.BaseClasses, this.ClassBody);
	}
	
	public MetaClassSyntax WithKClass(__SyntaxToken kClass)
		{
		return this.Update(this.IsAbstract, kClass, this.ClassName, this.BaseClasses, this.ClassBody);
	}
	
	public MetaClassSyntax WithClassName(ClassNameSyntax className)
		{
		return this.Update(this.IsAbstract, this.KClass, className, this.BaseClasses, this.ClassBody);
	}
	
	public MetaClassSyntax WithBaseClasses(BaseClassesSyntax baseClasses)
		{
		return this.Update(this.IsAbstract, this.KClass, this.ClassName, baseClasses, this.ClassBody);
	}
	
	public MetaClassSyntax WithClassBody(ClassBodySyntax classBody)
		{
		return this.Update(this.IsAbstract, this.KClass, this.ClassName, this.BaseClasses, classBody);
	}
	
	    public MetaClassSyntax Update(__SyntaxToken isAbstract, __SyntaxToken kClass, ClassNameSyntax className, BaseClassesSyntax baseClasses, ClassBodySyntax classBody)
	    {
	        if (this.IsAbstract != isAbstract || this.KClass != kClass || this.ClassName != className || this.BaseClasses != baseClasses || this.ClassBody != classBody)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaClass(isAbstract, kClass, className, baseClasses, classBody);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MetaClassSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaClass(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaClass(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaClass(this);
	    }
	
	}
	
	public sealed class EnumBodySyntax : MetaSyntaxNode
	{
		private __SyntaxNode _enumLiterals;
	
	    public EnumBodySyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public EnumBodySyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TLBrace 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.EnumBodyGreen)this.Green;
	var greenToken = green.TLBrace;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> EnumLiterals 
		{ 
		get
		{
				var red = this.GetRed(ref this._enumLiterals, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	public __SyntaxToken TRBrace 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.EnumBodyGreen)this.Green;
	var greenToken = green.TRBrace;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._enumLiterals, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._enumLiterals;
			default: return null;
	        }
	    }
	
	public EnumBodySyntax WithTLBrace(__SyntaxToken tLBrace)
		{
		return this.Update(tLBrace, this.EnumLiterals, this.TRBrace);
	}
	
	public EnumBodySyntax WithEnumLiterals(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> enumLiterals)
		{
		return this.Update(this.TLBrace, enumLiterals, this.TRBrace);
	}
	
	public EnumBodySyntax AddEnumLiterals(params MetaEnumLiteralSyntax[] enumLiterals)
		{
		return this.WithEnumLiterals(this.EnumLiterals.AddRange(enumLiterals));
	}
	
	public EnumBodySyntax WithTRBrace(__SyntaxToken tRBrace)
		{
		return this.Update(this.TLBrace, this.EnumLiterals, tRBrace);
	}
	
	    public EnumBodySyntax Update(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> enumLiterals, __SyntaxToken tRBrace)
	    {
	        if (this.TLBrace != tLBrace || this.EnumLiterals != enumLiterals || this.TRBrace != tRBrace)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.EnumBody(tLBrace, enumLiterals, tRBrace);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (EnumBodySyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitEnumBody(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitEnumBody(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitEnumBody(this);
	    }
	
	}
	
	public sealed class MetaEnumLiteralSyntax : MetaSyntaxNode
	{
		private NameSyntax _name;
	
	    public MetaEnumLiteralSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaEnumLiteralSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public NameSyntax Name 
		{ 
		get
		{
				var red = this.GetRed(ref this._name, 0);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._name, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._name;
			default: return null;
	        }
	    }
	
	public MetaEnumLiteralSyntax WithName(NameSyntax name)
		{
		return this.Update(name);
	}
	
	    public MetaEnumLiteralSyntax Update(NameSyntax name)
	    {
	        if (this.Name != name)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaEnumLiteral(name);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MetaEnumLiteralSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaEnumLiteral(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaEnumLiteral(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaEnumLiteral(this);
	    }
	
	}
	public abstract class ClassNameSyntax : MetaSyntaxNode
	{
	    protected ClassNameSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ClassNameSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ClassNameAlt1Syntax : ClassNameSyntax
	{
		private IdentifierSyntax _identifier;
		private IdentifierSyntax _symbolType;
	
	    public ClassNameAlt1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassNameAlt1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
	public __SyntaxToken TDollar 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.ClassNameAlt1Green)this.Green;
	var greenToken = green.TDollar;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
	} 
	}
	public IdentifierSyntax SymbolType 
		{ 
		get
		{
				var red = this.GetRed(ref this._symbolType, 2);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._identifier, 0);
			case 2: return this.GetRed(ref this._symbolType, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._identifier;
			case 2: return this._symbolType;
			default: return null;
	        }
	    }
	
	public ClassNameAlt1Syntax WithIdentifier(IdentifierSyntax identifier)
		{
		return this.Update(identifier, this.TDollar, this.SymbolType);
	}
	
	public ClassNameAlt1Syntax WithTDollar(__SyntaxToken tDollar)
		{
		return this.Update(this.Identifier, tDollar, this.SymbolType);
	}
	
	public ClassNameAlt1Syntax WithSymbolType(IdentifierSyntax symbolType)
		{
		return this.Update(this.Identifier, this.TDollar, symbolType);
	}
	
	    public ClassNameAlt1Syntax Update(IdentifierSyntax identifier, __SyntaxToken tDollar, IdentifierSyntax symbolType)
	    {
	        if (this.Identifier != identifier || this.TDollar != tDollar || this.SymbolType != symbolType)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.ClassNameAlt1(identifier, tDollar, symbolType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ClassNameAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitClassNameAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitClassNameAlt1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitClassNameAlt1(this);
	    }
	
	}
	public sealed class ClassNameAlt2Syntax : ClassNameSyntax
	{
		private IdentifierSyntax _identifier;
	
	    public ClassNameAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassNameAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
	
	public ClassNameAlt2Syntax WithIdentifier(IdentifierSyntax identifier)
		{
		return this.Update(identifier);
	}
	
	    public ClassNameAlt2Syntax Update(IdentifierSyntax identifier)
	    {
	        if (this.Identifier != identifier)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.ClassNameAlt2(identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ClassNameAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitClassNameAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitClassNameAlt2(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitClassNameAlt2(this);
	    }
	
	}
	
	public sealed class BaseClassesSyntax : MetaSyntaxNode
	{
		private __SyntaxNode _baseTypes;
	
	    public BaseClassesSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BaseClassesSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TColon 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.BaseClassesGreen)this.Green;
	var greenToken = green.TColon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> BaseTypes 
		{ 
		get
		{
				var red = this.GetRed(ref this._baseTypes, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._baseTypes, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._baseTypes;
			default: return null;
	        }
	    }
	
	public BaseClassesSyntax WithTColon(__SyntaxToken tColon)
		{
		return this.Update(tColon, this.BaseTypes);
	}
	
	public BaseClassesSyntax WithBaseTypes(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> baseTypes)
		{
		return this.Update(this.TColon, baseTypes);
	}
	
	public BaseClassesSyntax AddBaseTypes(params QualifierSyntax[] baseTypes)
		{
		return this.WithBaseTypes(this.BaseTypes.AddRange(baseTypes));
	}
	
	    public BaseClassesSyntax Update(__SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> baseTypes)
	    {
	        if (this.TColon != tColon || this.BaseTypes != baseTypes)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.BaseClasses(tColon, baseTypes);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (BaseClassesSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBaseClasses(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBaseClasses(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitBaseClasses(this);
	    }
	
	}
	
	public sealed class ClassBodySyntax : MetaSyntaxNode
	{
		private __SyntaxNode _classMemberList;
	
	    public ClassBodySyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassBodySyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TLBrace 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.ClassBodyGreen)this.Green;
	var greenToken = green.TLBrace;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax> ClassMemberList 
		{ 
		get
		{
				var red = this.GetRed(ref this._classMemberList, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax>(red);
	} 
	}
	public __SyntaxToken TRBrace 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.ClassBodyGreen)this.Green;
	var greenToken = green.TRBrace;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._classMemberList, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._classMemberList;
			default: return null;
	        }
	    }
	
	public ClassBodySyntax WithTLBrace(__SyntaxToken tLBrace)
		{
		return this.Update(tLBrace, this.ClassMemberList, this.TRBrace);
	}
	
	public ClassBodySyntax WithClassMemberList(global::MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax> classMemberList)
		{
		return this.Update(this.TLBrace, classMemberList, this.TRBrace);
	}
	
	public ClassBodySyntax AddClassMemberList(params ClassMemberSyntax[] classMemberList)
		{
		return this.WithClassMemberList(this.ClassMemberList.AddRange(classMemberList));
	}
	
	public ClassBodySyntax WithTRBrace(__SyntaxToken tRBrace)
		{
		return this.Update(this.TLBrace, this.ClassMemberList, tRBrace);
	}
	
	    public ClassBodySyntax Update(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax> classMemberList, __SyntaxToken tRBrace)
	    {
	        if (this.TLBrace != tLBrace || this.ClassMemberList != classMemberList || this.TRBrace != tRBrace)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.ClassBody(tLBrace, classMemberList, tRBrace);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ClassBodySyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitClassBody(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitClassBody(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitClassBody(this);
	    }
	
	}
	public abstract class ClassMemberSyntax : MetaSyntaxNode
	{
	    protected ClassMemberSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ClassMemberSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ClassMemberAlt1Syntax : ClassMemberSyntax
	{
		private MetaPropertySyntax _properties;
	
	    public ClassMemberAlt1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassMemberAlt1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public MetaPropertySyntax Properties 
		{ 
		get
		{
				var red = this.GetRed(ref this._properties, 0);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._properties, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._properties;
			default: return null;
	        }
	    }
	
	public ClassMemberAlt1Syntax WithProperties(MetaPropertySyntax properties)
		{
		return this.Update(properties);
	}
	
	    public ClassMemberAlt1Syntax Update(MetaPropertySyntax properties)
	    {
	        if (this.Properties != properties)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.ClassMemberAlt1(properties);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ClassMemberAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitClassMemberAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitClassMemberAlt1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitClassMemberAlt1(this);
	    }
	
	}
	public sealed class ClassMemberAlt2Syntax : ClassMemberSyntax
	{
		private MetaOperationSyntax _operations;
	
	    public ClassMemberAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassMemberAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public MetaOperationSyntax Operations 
		{ 
		get
		{
				var red = this.GetRed(ref this._operations, 0);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._operations, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._operations;
			default: return null;
	        }
	    }
	
	public ClassMemberAlt2Syntax WithOperations(MetaOperationSyntax operations)
		{
		return this.Update(operations);
	}
	
	    public ClassMemberAlt2Syntax Update(MetaOperationSyntax operations)
	    {
	        if (this.Operations != operations)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.ClassMemberAlt2(operations);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (ClassMemberAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitClassMemberAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitClassMemberAlt2(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitClassMemberAlt2(this);
	    }
	
	}
	
	public sealed class MetaPropertySyntax : MetaSyntaxNode
	{
		private TypeReferenceSyntax _type;
		private PropertyNameSyntax _propertyName;
		private __SyntaxNode _block;
	
	    public MetaPropertySyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaPropertySyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Tokens 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyGreen)this.Green;
	var greenToken = green.Tokens;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public TypeReferenceSyntax Type 
		{ 
		get
		{
				var red = this.GetRed(ref this._type, 1);
	return red;
	} 
	}
	public PropertyNameSyntax PropertyName 
		{ 
		get
		{
				var red = this.GetRed(ref this._propertyName, 2);
	return red;
	} 
	}
	public global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock1Syntax> Block 
		{ 
		get
		{
				var red = this.GetRed(ref this._block, 3);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock1Syntax>(red);
	} 
	}
	public __SyntaxToken TSemicolon 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._type, 1);
			case 2: return this.GetRed(ref this._propertyName, 2);
			case 3: return this.GetRed(ref this._block, 3);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._type;
			case 2: return this._propertyName;
			case 3: return this._block;
			default: return null;
	        }
	    }
	
	public MetaPropertySyntax WithTokens(__SyntaxToken tokens)
		{
		return this.Update(tokens, this.Type, this.PropertyName, this.Block, this.TSemicolon);
	}
	
	public MetaPropertySyntax WithType(TypeReferenceSyntax type)
		{
		return this.Update(this.Tokens, type, this.PropertyName, this.Block, this.TSemicolon);
	}
	
	public MetaPropertySyntax WithPropertyName(PropertyNameSyntax propertyName)
		{
		return this.Update(this.Tokens, this.Type, propertyName, this.Block, this.TSemicolon);
	}
	
	public MetaPropertySyntax WithBlock(global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock1Syntax> block)
		{
		return this.Update(this.Tokens, this.Type, this.PropertyName, block, this.TSemicolon);
	}
	
	public MetaPropertySyntax AddBlock(params MetaPropertyBlock1Syntax[] block)
		{
		return this.WithBlock(this.Block.AddRange(block));
	}
	
	public MetaPropertySyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.Tokens, this.Type, this.PropertyName, this.Block, tSemicolon);
	}
	
	    public MetaPropertySyntax Update(__SyntaxToken tokens, TypeReferenceSyntax type, PropertyNameSyntax propertyName, global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock1Syntax> block, __SyntaxToken tSemicolon)
	    {
	        if (this.Tokens != tokens || this.Type != type || this.PropertyName != propertyName || this.Block != block || this.TSemicolon != tSemicolon)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaProperty(tokens, type, propertyName, block, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MetaPropertySyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaProperty(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaProperty(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaProperty(this);
	    }
	
	}
	public abstract class PropertyNameSyntax : MetaSyntaxNode
	{
	    protected PropertyNameSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected PropertyNameSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class PropertyNameAlt1Syntax : PropertyNameSyntax
	{
		private IdentifierSyntax _identifier;
		private IdentifierSyntax _symbolProperty;
	
	    public PropertyNameAlt1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyNameAlt1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
	public __SyntaxToken TDollar 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyNameAlt1Green)this.Green;
	var greenToken = green.TDollar;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
	} 
	}
	public IdentifierSyntax SymbolProperty 
		{ 
		get
		{
				var red = this.GetRed(ref this._symbolProperty, 2);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._identifier, 0);
			case 2: return this.GetRed(ref this._symbolProperty, 2);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._identifier;
			case 2: return this._symbolProperty;
			default: return null;
	        }
	    }
	
	public PropertyNameAlt1Syntax WithIdentifier(IdentifierSyntax identifier)
		{
		return this.Update(identifier, this.TDollar, this.SymbolProperty);
	}
	
	public PropertyNameAlt1Syntax WithTDollar(__SyntaxToken tDollar)
		{
		return this.Update(this.Identifier, tDollar, this.SymbolProperty);
	}
	
	public PropertyNameAlt1Syntax WithSymbolProperty(IdentifierSyntax symbolProperty)
		{
		return this.Update(this.Identifier, this.TDollar, symbolProperty);
	}
	
	    public PropertyNameAlt1Syntax Update(IdentifierSyntax identifier, __SyntaxToken tDollar, IdentifierSyntax symbolProperty)
	    {
	        if (this.Identifier != identifier || this.TDollar != tDollar || this.SymbolProperty != symbolProperty)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyNameAlt1(identifier, tDollar, symbolProperty);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (PropertyNameAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertyNameAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertyNameAlt1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertyNameAlt1(this);
	    }
	
	}
	public sealed class PropertyNameAlt2Syntax : PropertyNameSyntax
	{
		private IdentifierSyntax _identifier;
	
	    public PropertyNameAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyNameAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
	
	public PropertyNameAlt2Syntax WithIdentifier(IdentifierSyntax identifier)
		{
		return this.Update(identifier);
	}
	
	    public PropertyNameAlt2Syntax Update(IdentifierSyntax identifier)
	    {
	        if (this.Identifier != identifier)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyNameAlt2(identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (PropertyNameAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertyNameAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertyNameAlt2(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertyNameAlt2(this);
	    }
	
	}
	
	public sealed class MetaOperationSyntax : MetaSyntaxNode
	{
		private TypeReferenceSyntax _returnType;
		private NameSyntax _name;
		private __SyntaxNode _parameterList;
	
	    public MetaOperationSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaOperationSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public TypeReferenceSyntax ReturnType 
		{ 
		get
		{
				var red = this.GetRed(ref this._returnType, 0);
	return red;
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
	public __SyntaxToken TLParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaOperationGreen)this.Green;
	var greenToken = green.TLParen;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> ParameterList 
		{ 
		get
		{
				var red = this.GetRed(ref this._parameterList, 3);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax>(red, this.GetChildIndex(3), reversed: false);
	} 
	}
	public __SyntaxToken TRParen 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaOperationGreen)this.Green;
	var greenToken = green.TRParen;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
	} 
	}
	public __SyntaxToken TSemicolon 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaOperationGreen)this.Green;
	var greenToken = green.TSemicolon;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._returnType, 0);
			case 1: return this.GetRed(ref this._name, 1);
			case 3: return this.GetRed(ref this._parameterList, 3);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._returnType;
			case 1: return this._name;
			case 3: return this._parameterList;
			default: return null;
	        }
	    }
	
	public MetaOperationSyntax WithReturnType(TypeReferenceSyntax returnType)
		{
		return this.Update(returnType, this.Name, this.TLParen, this.ParameterList, this.TRParen, this.TSemicolon);
	}
	
	public MetaOperationSyntax WithName(NameSyntax name)
		{
		return this.Update(this.ReturnType, name, this.TLParen, this.ParameterList, this.TRParen, this.TSemicolon);
	}
	
	public MetaOperationSyntax WithTLParen(__SyntaxToken tLParen)
		{
		return this.Update(this.ReturnType, this.Name, tLParen, this.ParameterList, this.TRParen, this.TSemicolon);
	}
	
	public MetaOperationSyntax WithParameterList(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> parameterList)
		{
		return this.Update(this.ReturnType, this.Name, this.TLParen, parameterList, this.TRParen, this.TSemicolon);
	}
	
	public MetaOperationSyntax AddParameterList(params MetaParameterSyntax[] parameterList)
		{
		return this.WithParameterList(this.ParameterList.AddRange(parameterList));
	}
	
	public MetaOperationSyntax WithTRParen(__SyntaxToken tRParen)
		{
		return this.Update(this.ReturnType, this.Name, this.TLParen, this.ParameterList, tRParen, this.TSemicolon);
	}
	
	public MetaOperationSyntax WithTSemicolon(__SyntaxToken tSemicolon)
		{
		return this.Update(this.ReturnType, this.Name, this.TLParen, this.ParameterList, this.TRParen, tSemicolon);
	}
	
	    public MetaOperationSyntax Update(TypeReferenceSyntax returnType, NameSyntax name, __SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> parameterList, __SyntaxToken tRParen, __SyntaxToken tSemicolon)
	    {
	        if (this.ReturnType != returnType || this.Name != name || this.TLParen != tLParen || this.ParameterList != parameterList || this.TRParen != tRParen || this.TSemicolon != tSemicolon)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaOperation(returnType, name, tLParen, parameterList, tRParen, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MetaOperationSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaOperation(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaOperation(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaOperation(this);
	    }
	
	}
	
	public sealed class MetaParameterSyntax : MetaSyntaxNode
	{
		private TypeReferenceSyntax _type;
		private NameSyntax _name;
	
	    public MetaParameterSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaParameterSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public TypeReferenceSyntax Type 
		{ 
		get
		{
				var red = this.GetRed(ref this._type, 0);
	return red;
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
			case 0: return this.GetRed(ref this._type, 0);
			case 1: return this.GetRed(ref this._name, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._type;
			case 1: return this._name;
			default: return null;
	        }
	    }
	
	public MetaParameterSyntax WithType(TypeReferenceSyntax type)
		{
		return this.Update(type, this.Name);
	}
	
	public MetaParameterSyntax WithName(NameSyntax name)
		{
		return this.Update(this.Type, name);
	}
	
	    public MetaParameterSyntax Update(TypeReferenceSyntax type, NameSyntax name)
	    {
	        if (this.Type != type || this.Name != name)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaParameter(type, name);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MetaParameterSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaParameter(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaParameter(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaParameter(this);
	    }
	
	}
	public abstract class TypeReferenceSyntax : MetaSyntaxNode
	{
	    protected TypeReferenceSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected TypeReferenceSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class TypeReferenceTokensSyntax : TypeReferenceSyntax
	{
	
	    public TypeReferenceTokensSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TypeReferenceTokensSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Token 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.TypeReferenceTokensGreen)this.Green;
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
	
	public TypeReferenceTokensSyntax WithToken(__SyntaxToken token)
		{
		return this.Update(token);
	}
	
	    public TypeReferenceTokensSyntax Update(__SyntaxToken token)
	    {
	        if (this.Token != token)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.TypeReferenceTokens(token);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (TypeReferenceTokensSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTypeReferenceTokens(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTypeReferenceTokens(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitTypeReferenceTokens(this);
	    }
	
	}
	public sealed class SimpleTypeReferenceAlt2Syntax : TypeReferenceSyntax
	{
		private QualifierSyntax _qualifier;
	
	    public SimpleTypeReferenceAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public SimpleTypeReferenceAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public QualifierSyntax Qualifier 
		{ 
		get
		{
				var red = this.GetRed(ref this._qualifier, 0);
	return red;
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
	
	public SimpleTypeReferenceAlt2Syntax WithQualifier(QualifierSyntax qualifier)
		{
		return this.Update(qualifier);
	}
	
	    public SimpleTypeReferenceAlt2Syntax Update(QualifierSyntax qualifier)
	    {
	        if (this.Qualifier != qualifier)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.SimpleTypeReferenceAlt2(qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (SimpleTypeReferenceAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitSimpleTypeReferenceAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitSimpleTypeReferenceAlt2(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitSimpleTypeReferenceAlt2(this);
	    }
	
	}
	public sealed class MetaArrayTypeSyntax : TypeReferenceSyntax
	{
		private TypeReferenceSyntax _itemType;
	
	    public MetaArrayTypeSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaArrayTypeSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public TypeReferenceSyntax ItemType 
		{ 
		get
		{
				var red = this.GetRed(ref this._itemType, 0);
	return red;
	} 
	}
	public __SyntaxToken TLBracket 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaArrayTypeGreen)this.Green;
	var greenToken = green.TLBracket;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
	} 
	}
	public __SyntaxToken TRBracket 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaArrayTypeGreen)this.Green;
	var greenToken = green.TRBracket;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._itemType, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._itemType;
			default: return null;
	        }
	    }
	
	public MetaArrayTypeSyntax WithItemType(TypeReferenceSyntax itemType)
		{
		return this.Update(itemType, this.TLBracket, this.TRBracket);
	}
	
	public MetaArrayTypeSyntax WithTLBracket(__SyntaxToken tLBracket)
		{
		return this.Update(this.ItemType, tLBracket, this.TRBracket);
	}
	
	public MetaArrayTypeSyntax WithTRBracket(__SyntaxToken tRBracket)
		{
		return this.Update(this.ItemType, this.TLBracket, tRBracket);
	}
	
	    public MetaArrayTypeSyntax Update(TypeReferenceSyntax itemType, __SyntaxToken tLBracket, __SyntaxToken tRBracket)
	    {
	        if (this.ItemType != itemType || this.TLBracket != tLBracket || this.TRBracket != tRBracket)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaArrayType(itemType, tLBracket, tRBracket);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MetaArrayTypeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaArrayType(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaArrayType(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaArrayType(this);
	    }
	
	}
	public sealed class MetaNullableTypeSyntax : TypeReferenceSyntax
	{
		private TypeReferenceSyntax _innerType;
	
	    public MetaNullableTypeSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaNullableTypeSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public TypeReferenceSyntax InnerType 
		{ 
		get
		{
				var red = this.GetRed(ref this._innerType, 0);
	return red;
	} 
	}
	public __SyntaxToken TQuestion 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaNullableTypeGreen)this.Green;
	var greenToken = green.TQuestion;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this.GetRed(ref this._innerType, 0);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 0: return this._innerType;
			default: return null;
	        }
	    }
	
	public MetaNullableTypeSyntax WithInnerType(TypeReferenceSyntax innerType)
		{
		return this.Update(innerType, this.TQuestion);
	}
	
	public MetaNullableTypeSyntax WithTQuestion(__SyntaxToken tQuestion)
		{
		return this.Update(this.InnerType, tQuestion);
	}
	
	    public MetaNullableTypeSyntax Update(TypeReferenceSyntax innerType, __SyntaxToken tQuestion)
	    {
	        if (this.InnerType != innerType || this.TQuestion != tQuestion)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaNullableType(innerType, tQuestion);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MetaNullableTypeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaNullableType(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaNullableType(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaNullableType(this);
	    }
	
	}
	
	public sealed class NameSyntax : MetaSyntaxNode
	{
		private IdentifierSyntax _identifier;
	
	    public NameSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public NameSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Name(identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (NameSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitName(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitName(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitName(this);
	    }
	
	}
	
	public sealed class QualifierSyntax : MetaSyntaxNode
	{
		private __SyntaxNode _qualifier;
	
	    public QualifierSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
	
	public QualifierSyntax WithQualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
		{
		return this.Update(qualifier);
	}
	
	public QualifierSyntax AddQualifier(params IdentifierSyntax[] qualifier)
		{
		return this.WithQualifier(this.Qualifier.AddRange(qualifier));
	}
	
	    public QualifierSyntax Update(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
	    {
	        if (this.Qualifier != qualifier)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Qualifier(qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (QualifierSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifier(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifier(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifier(this);
	    }
	
	}
	
	public sealed class IdentifierSyntax : MetaSyntaxNode
	{
	
	    public IdentifierSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public IdentifierSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken Token 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.IdentifierGreen)this.Green;
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
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Identifier(token);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (IdentifierSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitIdentifier(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitIdentifier(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitIdentifier(this);
	    }
	
	}
	
	public sealed class EnumBodyEnumLiteralsBlockSyntax : MetaSyntaxNode
	{
		private MetaEnumLiteralSyntax _literals;
	
	    public EnumBodyEnumLiteralsBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public EnumBodyEnumLiteralsBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TComma 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.EnumBodyEnumLiteralsBlockGreen)this.Green;
	var greenToken = green.TComma;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public MetaEnumLiteralSyntax Literals 
		{ 
		get
		{
				var red = this.GetRed(ref this._literals, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._literals, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._literals;
			default: return null;
	        }
	    }
	
	public EnumBodyEnumLiteralsBlockSyntax WithTComma(__SyntaxToken tComma)
		{
		return this.Update(tComma, this.Literals);
	}
	
	public EnumBodyEnumLiteralsBlockSyntax WithLiterals(MetaEnumLiteralSyntax literals)
		{
		return this.Update(this.TComma, literals);
	}
	
	    public EnumBodyEnumLiteralsBlockSyntax Update(__SyntaxToken tComma, MetaEnumLiteralSyntax literals)
	    {
	        if (this.TComma != tComma || this.Literals != literals)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.EnumBodyEnumLiteralsBlock(tComma, literals);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (EnumBodyEnumLiteralsBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitEnumBodyEnumLiteralsBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitEnumBodyEnumLiteralsBlock(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitEnumBodyEnumLiteralsBlock(this);
	    }
	
	}
	
	public sealed class BaseClassesBaseTypesBlockSyntax : MetaSyntaxNode
	{
		private QualifierSyntax _baseTypes;
	
	    public BaseClassesBaseTypesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BaseClassesBaseTypesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TComma 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.BaseClassesBaseTypesBlockGreen)this.Green;
	var greenToken = green.TComma;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public QualifierSyntax BaseTypes 
		{ 
		get
		{
				var red = this.GetRed(ref this._baseTypes, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._baseTypes, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._baseTypes;
			default: return null;
	        }
	    }
	
	public BaseClassesBaseTypesBlockSyntax WithTComma(__SyntaxToken tComma)
		{
		return this.Update(tComma, this.BaseTypes);
	}
	
	public BaseClassesBaseTypesBlockSyntax WithBaseTypes(QualifierSyntax baseTypes)
		{
		return this.Update(this.TComma, baseTypes);
	}
	
	    public BaseClassesBaseTypesBlockSyntax Update(__SyntaxToken tComma, QualifierSyntax baseTypes)
	    {
	        if (this.TComma != tComma || this.BaseTypes != baseTypes)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.BaseClassesBaseTypesBlock(tComma, baseTypes);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (BaseClassesBaseTypesBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBaseClassesBaseTypesBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBaseClassesBaseTypesBlock(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitBaseClassesBaseTypesBlock(this);
	    }
	
	}
	public abstract class MetaPropertyBlock1Syntax : MetaSyntaxNode
	{
	    protected MetaPropertyBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected MetaPropertyBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class PropertyOppositeSyntax : MetaPropertyBlock1Syntax
	{
		private __SyntaxNode _oppositeProperties;
	
	    public PropertyOppositeSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyOppositeSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KOpposite 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyOppositeGreen)this.Green;
	var greenToken = green.KOpposite;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> OppositeProperties 
		{ 
		get
		{
				var red = this.GetRed(ref this._oppositeProperties, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._oppositeProperties, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._oppositeProperties;
			default: return null;
	        }
	    }
	
	public PropertyOppositeSyntax WithKOpposite(__SyntaxToken kOpposite)
		{
		return this.Update(kOpposite, this.OppositeProperties);
	}
	
	public PropertyOppositeSyntax WithOppositeProperties(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> oppositeProperties)
		{
		return this.Update(this.KOpposite, oppositeProperties);
	}
	
	public PropertyOppositeSyntax AddOppositeProperties(params QualifierSyntax[] oppositeProperties)
		{
		return this.WithOppositeProperties(this.OppositeProperties.AddRange(oppositeProperties));
	}
	
	    public PropertyOppositeSyntax Update(__SyntaxToken kOpposite, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> oppositeProperties)
	    {
	        if (this.KOpposite != kOpposite || this.OppositeProperties != oppositeProperties)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyOpposite(kOpposite, oppositeProperties);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (PropertyOppositeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertyOpposite(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertyOpposite(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertyOpposite(this);
	    }
	
	}
	public sealed class PropertySubsetsSyntax : MetaPropertyBlock1Syntax
	{
		private __SyntaxNode _subsettedProperties;
	
	    public PropertySubsetsSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertySubsetsSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KSubsets 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertySubsetsGreen)this.Green;
	var greenToken = green.KSubsets;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> SubsettedProperties 
		{ 
		get
		{
				var red = this.GetRed(ref this._subsettedProperties, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._subsettedProperties, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._subsettedProperties;
			default: return null;
	        }
	    }
	
	public PropertySubsetsSyntax WithKSubsets(__SyntaxToken kSubsets)
		{
		return this.Update(kSubsets, this.SubsettedProperties);
	}
	
	public PropertySubsetsSyntax WithSubsettedProperties(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> subsettedProperties)
		{
		return this.Update(this.KSubsets, subsettedProperties);
	}
	
	public PropertySubsetsSyntax AddSubsettedProperties(params QualifierSyntax[] subsettedProperties)
		{
		return this.WithSubsettedProperties(this.SubsettedProperties.AddRange(subsettedProperties));
	}
	
	    public PropertySubsetsSyntax Update(__SyntaxToken kSubsets, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> subsettedProperties)
	    {
	        if (this.KSubsets != kSubsets || this.SubsettedProperties != subsettedProperties)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertySubsets(kSubsets, subsettedProperties);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (PropertySubsetsSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertySubsets(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertySubsets(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertySubsets(this);
	    }
	
	}
	public sealed class PropertyRedefinesSyntax : MetaPropertyBlock1Syntax
	{
		private __SyntaxNode _redefinedProperties;
	
	    public PropertyRedefinesSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyRedefinesSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken KRedefines 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyRedefinesGreen)this.Green;
	var greenToken = green.KRedefines;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> RedefinedProperties 
		{ 
		get
		{
				var red = this.GetRed(ref this._redefinedProperties, 1);
				return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._redefinedProperties, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._redefinedProperties;
			default: return null;
	        }
	    }
	
	public PropertyRedefinesSyntax WithKRedefines(__SyntaxToken kRedefines)
		{
		return this.Update(kRedefines, this.RedefinedProperties);
	}
	
	public PropertyRedefinesSyntax WithRedefinedProperties(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> redefinedProperties)
		{
		return this.Update(this.KRedefines, redefinedProperties);
	}
	
	public PropertyRedefinesSyntax AddRedefinedProperties(params QualifierSyntax[] redefinedProperties)
		{
		return this.WithRedefinedProperties(this.RedefinedProperties.AddRange(redefinedProperties));
	}
	
	    public PropertyRedefinesSyntax Update(__SyntaxToken kRedefines, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> redefinedProperties)
	    {
	        if (this.KRedefines != kRedefines || this.RedefinedProperties != redefinedProperties)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyRedefines(kRedefines, redefinedProperties);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (PropertyRedefinesSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertyRedefines(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertyRedefines(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertyRedefines(this);
	    }
	
	}
	
	public sealed class PropertyOppositeOppositePropertiesBlockSyntax : MetaSyntaxNode
	{
		private QualifierSyntax _oppositeProperties;
	
	    public PropertyOppositeOppositePropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyOppositeOppositePropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TComma 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyOppositeOppositePropertiesBlockGreen)this.Green;
	var greenToken = green.TComma;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public QualifierSyntax OppositeProperties 
		{ 
		get
		{
				var red = this.GetRed(ref this._oppositeProperties, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._oppositeProperties, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._oppositeProperties;
			default: return null;
	        }
	    }
	
	public PropertyOppositeOppositePropertiesBlockSyntax WithTComma(__SyntaxToken tComma)
		{
		return this.Update(tComma, this.OppositeProperties);
	}
	
	public PropertyOppositeOppositePropertiesBlockSyntax WithOppositeProperties(QualifierSyntax oppositeProperties)
		{
		return this.Update(this.TComma, oppositeProperties);
	}
	
	    public PropertyOppositeOppositePropertiesBlockSyntax Update(__SyntaxToken tComma, QualifierSyntax oppositeProperties)
	    {
	        if (this.TComma != tComma || this.OppositeProperties != oppositeProperties)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyOppositeOppositePropertiesBlock(tComma, oppositeProperties);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (PropertyOppositeOppositePropertiesBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertyOppositeOppositePropertiesBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertyOppositeOppositePropertiesBlock(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertyOppositeOppositePropertiesBlock(this);
	    }
	
	}
	
	public sealed class PropertySubsetsSubsettedPropertiesBlockSyntax : MetaSyntaxNode
	{
		private QualifierSyntax _subsettedProperties;
	
	    public PropertySubsetsSubsettedPropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertySubsetsSubsettedPropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TComma 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertySubsetsSubsettedPropertiesBlockGreen)this.Green;
	var greenToken = green.TComma;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public QualifierSyntax SubsettedProperties 
		{ 
		get
		{
				var red = this.GetRed(ref this._subsettedProperties, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._subsettedProperties, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._subsettedProperties;
			default: return null;
	        }
	    }
	
	public PropertySubsetsSubsettedPropertiesBlockSyntax WithTComma(__SyntaxToken tComma)
		{
		return this.Update(tComma, this.SubsettedProperties);
	}
	
	public PropertySubsetsSubsettedPropertiesBlockSyntax WithSubsettedProperties(QualifierSyntax subsettedProperties)
		{
		return this.Update(this.TComma, subsettedProperties);
	}
	
	    public PropertySubsetsSubsettedPropertiesBlockSyntax Update(__SyntaxToken tComma, QualifierSyntax subsettedProperties)
	    {
	        if (this.TComma != tComma || this.SubsettedProperties != subsettedProperties)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertySubsetsSubsettedPropertiesBlock(tComma, subsettedProperties);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (PropertySubsetsSubsettedPropertiesBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertySubsetsSubsettedPropertiesBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertySubsetsSubsettedPropertiesBlock(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertySubsetsSubsettedPropertiesBlock(this);
	    }
	
	}
	
	public sealed class PropertyRedefinesRedefinedPropertiesBlockSyntax : MetaSyntaxNode
	{
		private QualifierSyntax _redefinedProperties;
	
	    public PropertyRedefinesRedefinedPropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyRedefinesRedefinedPropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TComma 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyRedefinesRedefinedPropertiesBlockGreen)this.Green;
	var greenToken = green.TComma;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public QualifierSyntax RedefinedProperties 
		{ 
		get
		{
				var red = this.GetRed(ref this._redefinedProperties, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._redefinedProperties, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._redefinedProperties;
			default: return null;
	        }
	    }
	
	public PropertyRedefinesRedefinedPropertiesBlockSyntax WithTComma(__SyntaxToken tComma)
		{
		return this.Update(tComma, this.RedefinedProperties);
	}
	
	public PropertyRedefinesRedefinedPropertiesBlockSyntax WithRedefinedProperties(QualifierSyntax redefinedProperties)
		{
		return this.Update(this.TComma, redefinedProperties);
	}
	
	    public PropertyRedefinesRedefinedPropertiesBlockSyntax Update(__SyntaxToken tComma, QualifierSyntax redefinedProperties)
	    {
	        if (this.TComma != tComma || this.RedefinedProperties != redefinedProperties)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyRedefinesRedefinedPropertiesBlock(tComma, redefinedProperties);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (PropertyRedefinesRedefinedPropertiesBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertyRedefinesRedefinedPropertiesBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertyRedefinesRedefinedPropertiesBlock(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertyRedefinesRedefinedPropertiesBlock(this);
	    }
	
	}
	
	public sealed class MetaOperationParameterListBlockSyntax : MetaSyntaxNode
	{
		private MetaParameterSyntax _parameters;
	
	    public MetaOperationParameterListBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaOperationParameterListBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TComma 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaOperationParameterListBlockGreen)this.Green;
	var greenToken = green.TComma;
				return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
	} 
	}
	public MetaParameterSyntax Parameters 
		{ 
		get
		{
				var red = this.GetRed(ref this._parameters, 1);
	return red;
	} 
	}
	
	    protected override __SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this.GetRed(ref this._parameters, 1);
			default: return null;
	        }
	    }
	
	    protected override __SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
			case 1: return this._parameters;
			default: return null;
	        }
	    }
	
	public MetaOperationParameterListBlockSyntax WithTComma(__SyntaxToken tComma)
		{
		return this.Update(tComma, this.Parameters);
	}
	
	public MetaOperationParameterListBlockSyntax WithParameters(MetaParameterSyntax parameters)
		{
		return this.Update(this.TComma, parameters);
	}
	
	    public MetaOperationParameterListBlockSyntax Update(__SyntaxToken tComma, MetaParameterSyntax parameters)
	    {
	        if (this.TComma != tComma || this.Parameters != parameters)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaOperationParameterListBlock(tComma, parameters);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (MetaOperationParameterListBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaOperationParameterListBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaOperationParameterListBlock(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaOperationParameterListBlock(this);
	    }
	
	}
	
	public sealed class QualifierQualifierBlockSyntax : MetaSyntaxNode
	{
		private IdentifierSyntax _identifier;
	
	    public QualifierQualifierBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierQualifierBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	public __SyntaxToken TDot 
		{ 
		get
		{
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.QualifierQualifierBlockGreen)this.Green;
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
	
	public QualifierQualifierBlockSyntax WithTDot(__SyntaxToken tDot)
		{
		return this.Update(tDot, this.Identifier);
	}
	
	public QualifierQualifierBlockSyntax WithIdentifier(IdentifierSyntax identifier)
		{
		return this.Update(this.TDot, identifier);
	}
	
	    public QualifierQualifierBlockSyntax Update(__SyntaxToken tDot, IdentifierSyntax identifier)
	    {
	        if (this.TDot != tDot || this.Identifier != identifier)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.QualifierQualifierBlock(tDot, identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
			return (QualifierQualifierBlockSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifierQualifierBlock(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifierQualifierBlock(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifierQualifierBlock(this);
	    }
	
	}
}
