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
using MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax
{

    public abstract class MetaSyntaxNode : SyntaxNode
    {
        protected MetaSyntaxNode(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }

        protected MetaSyntaxNode(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public override Language Language => MetaLanguage.Instance;
        public MetaSyntaxKind Kind => (MetaSyntaxKind)this.RawKind;
		internal new GreenNode Green => base.Green;

        protected override SyntaxTree CreateSyntaxTreeForRoot()
        {
            return MetaSyntaxTree.CreateWithoutClone(this, IncrementalParseData.Empty);
        }

        public override TResult Accept<TArg, TResult>(SyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            if (visitor is IMetaSyntaxVisitor<TArg, TResult> typedVisitor) return this.Accept(typedVisitor, argument);
            else return visitor.DefaultVisit(this, argument);
        }

        public abstract TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument);

        public override TResult Accept<TResult>(SyntaxVisitor<TResult> visitor)
        {
            if (visitor is IMetaSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor);

        public override void Accept(SyntaxVisitor visitor)
        {
            if (visitor is IMetaSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }
        public abstract void Accept(IMetaSyntaxVisitor visitor);
    }

    /// <summary>
    /// It's a non terminal Trivia MetaSyntaxNode that has a tree underneath it.
    /// </summary>
    public abstract partial class MetaStructuredTriviaSyntax : MetaSyntaxNode, IStructuredTriviaSyntax
    {
        private SyntaxTrivia _parent;
        internal MetaStructuredTriviaSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent == null ? null : (MetaSyntaxTree)parent.SyntaxTree, position)
        {
            System.Diagnostics.Debug.Assert(parent == null || position >= 0);
        }
		internal static MetaStructuredTriviaSyntax Create(SyntaxTrivia trivia)
		{
			var red = (MetaStructuredTriviaSyntax)MetaLanguage.Instance.SyntaxFactory.CreateStructure(trivia);
			red._parent = trivia;
			return red;
		}
        /// <summary>
        /// Get parent trivia.
        /// </summary>
        public override SyntaxTrivia ParentTrivia => _parent;
    }

    public sealed partial class MetaSkippedTokensTriviaSyntax : MetaStructuredTriviaSyntax
    {
        internal MetaSkippedTokensTriviaSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public SyntaxTokenList Tokens 
        {
            get
            {
				var slot = ((global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.GreenSkippedTokensTriviaSyntax)this.Green).Tokens;
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

        public MetaSkippedTokensTriviaSyntax Update(SyntaxTokenList tokens)
        {
            if (tokens != this.Tokens)
            {
                var newNode = (MetaSkippedTokensTriviaSyntax)Language.SyntaxFactory.SkippedTokensTrivia(tokens);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    return newNode.WithAnnotations(annotations);
                return newNode;
            }
            return this;
        }

        public MetaSkippedTokensTriviaSyntax WithTokens(SyntaxTokenList tokens)
        {
            return this.Update(tokens);
        }

        public MetaSkippedTokensTriviaSyntax AddTokens(params SyntaxToken[] items)
        {
            return this.WithTokens(this.Tokens.AddRange(items));
        }
    }

	public sealed class MainSyntax : MetaSyntaxNode, ICompilationUnitSyntax
	{
		private QualifierSyntax _name;
		private MetaDslx.CodeAnalysis.SyntaxNode _using;
		private DeclarationsSyntax _declarations;
	
	    public MainSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MainSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KNamespace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
				var greenToken = green.KNamespace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax Name => this.GetRed(ref this._name, 1);
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Main(kNamespace, name, tSemicolon, @using, declarations, eof);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	
	    public UsingSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public UsingSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KUsing 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
				var greenToken = green.KUsing;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax Namespaces => this.GetRed(ref this._namespaces, 1);
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
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
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Using(kUsing, namespaces, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
		private MetaDslx.CodeAnalysis.SyntaxNode _declarations;
	
	    public DeclarationsSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public DeclarationsSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> Declarations 
		{ 
			get
			{
				var red = this.GetRed(ref this._declarations, 0);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax>(red);
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._declarations, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._declarations;
				default: return null;
	        }
	    }
	
	    public DeclarationsSyntax WithDeclarations(MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> declarations)
		{
			return this.Update(declarations);
		}
	
	    public DeclarationsSyntax AddDeclarations(params MetaDeclarationSyntax[] declarations)
		{
			return this.WithDeclarations(this.Declarations.AddRange(declarations));
		}
	
	    public DeclarationsSyntax Update(MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> declarations)
	    {
	        if (this.Declarations != declarations)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Declarations(declarations);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	    protected MetaDeclarationSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected MetaDeclarationSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class MetaModelSyntax : MetaDeclarationSyntax
	{
		private NameSyntax _name;
	
	    public MetaModelSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaModelSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KMetamodel 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaModelGreen)this.Green;
				var greenToken = green.KMetamodel;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public NameSyntax Name => this.GetRed(ref this._name, 1);
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaModelGreen)this.Green;
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
	
	    public MetaModelSyntax WithKMetamodel(SyntaxToken kMetamodel)
		{
			return this.Update(kMetamodel, this.Name, this.TSemicolon);
		}
	
	    public MetaModelSyntax WithName(NameSyntax name)
		{
			return this.Update(this.KMetamodel, name, this.TSemicolon);
		}
	
	    public MetaModelSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.KMetamodel, this.Name, tSemicolon);
		}
	
	    public MetaModelSyntax Update(SyntaxToken kMetamodel, NameSyntax name, SyntaxToken tSemicolon)
	    {
	        if (this.KMetamodel != kMetamodel || this.Name != name || this.TSemicolon != tSemicolon)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaModel(kMetamodel, name, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	
	    public MetaConstantSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaConstantSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KConst 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaConstantGreen)this.Green;
				var greenToken = green.KConst;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public TypeReferenceSyntax Type => this.GetRed(ref this._type, 1);
	    public NameSyntax Name => this.GetRed(ref this._name, 2);
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaConstantGreen)this.Green;
				var greenToken = green.TSemicolon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._type, 1);
				case 2: return this.GetRed(ref this._name, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._type;
				case 2: return this._name;
				default: return null;
	        }
	    }
	
	    public MetaConstantSyntax WithKConst(SyntaxToken kConst)
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
	
	    public MetaConstantSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.KConst, this.Type, this.Name, tSemicolon);
		}
	
	    public MetaConstantSyntax Update(SyntaxToken kConst, TypeReferenceSyntax type, NameSyntax name, SyntaxToken tSemicolon)
	    {
	        if (this.KConst != kConst || this.Type != type || this.Name != name || this.TSemicolon != tSemicolon)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaConstant(kConst, type, name, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	public sealed class MetaEnumTypeSyntax : MetaDeclarationSyntax
	{
		private NameSyntax _name;
		private EnumBodySyntax _enumBody;
	
	    public MetaEnumTypeSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaEnumTypeSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KEnum 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaEnumTypeGreen)this.Green;
				var greenToken = green.KEnum;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public NameSyntax Name => this.GetRed(ref this._name, 1);
	    public EnumBodySyntax EnumBody => this.GetRed(ref this._enumBody, 2);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._name, 1);
				case 2: return this.GetRed(ref this._enumBody, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._name;
				case 2: return this._enumBody;
				default: return null;
	        }
	    }
	
	    public MetaEnumTypeSyntax WithKEnum(SyntaxToken kEnum)
		{
			return this.Update(kEnum, this.Name, this.EnumBody);
		}
	
	    public MetaEnumTypeSyntax WithName(NameSyntax name)
		{
			return this.Update(this.KEnum, name, this.EnumBody);
		}
	
	    public MetaEnumTypeSyntax WithEnumBody(EnumBodySyntax enumBody)
		{
			return this.Update(this.KEnum, this.Name, enumBody);
		}
	
	    public MetaEnumTypeSyntax Update(SyntaxToken kEnum, NameSyntax name, EnumBodySyntax enumBody)
	    {
	        if (this.KEnum != kEnum || this.Name != name || this.EnumBody != enumBody)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaEnumType(kEnum, name, enumBody);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MetaEnumTypeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaEnumType(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaEnumType(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaEnumType(this);
	    }
	
	}
	public sealed class MetaClassSyntax : MetaDeclarationSyntax
	{
		private ClassNameSyntax _name;
		private BaseClassesSyntax _baseClasses;
		private ClassBodySyntax _classBody;
	
	    public MetaClassSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaClassSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken IsAbstract 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaClassGreen)this.Green;
				var greenToken = green.IsAbstract;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public SyntaxToken KClass 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaClassGreen)this.Green;
				var greenToken = green.KClass;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public ClassNameSyntax Name => this.GetRed(ref this._name, 2);
	    public BaseClassesSyntax BaseClasses => this.GetRed(ref this._baseClasses, 3);
	    public ClassBodySyntax ClassBody => this.GetRed(ref this._classBody, 4);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 2: return this.GetRed(ref this._name, 2);
				case 3: return this.GetRed(ref this._baseClasses, 3);
				case 4: return this.GetRed(ref this._classBody, 4);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 2: return this._name;
				case 3: return this._baseClasses;
				case 4: return this._classBody;
				default: return null;
	        }
	    }
	
	    public MetaClassSyntax WithIsAbstract(SyntaxToken isAbstract)
		{
			return this.Update(isAbstract, this.KClass, this.Name, this.BaseClasses, this.ClassBody);
		}
	
	    public MetaClassSyntax WithKClass(SyntaxToken kClass)
		{
			return this.Update(this.IsAbstract, kClass, this.Name, this.BaseClasses, this.ClassBody);
		}
	
	    public MetaClassSyntax WithName(ClassNameSyntax name)
		{
			return this.Update(this.IsAbstract, this.KClass, name, this.BaseClasses, this.ClassBody);
		}
	
	    public MetaClassSyntax WithBaseClasses(BaseClassesSyntax baseClasses)
		{
			return this.Update(this.IsAbstract, this.KClass, this.Name, baseClasses, this.ClassBody);
		}
	
	    public MetaClassSyntax WithClassBody(ClassBodySyntax classBody)
		{
			return this.Update(this.IsAbstract, this.KClass, this.Name, this.BaseClasses, classBody);
		}
	
	    public MetaClassSyntax Update(SyntaxToken isAbstract, SyntaxToken kClass, ClassNameSyntax name, BaseClassesSyntax baseClasses, ClassBodySyntax classBody)
	    {
	        if (this.IsAbstract != isAbstract || this.KClass != kClass || this.Name != name || this.BaseClasses != baseClasses || this.ClassBody != classBody)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaClass(isAbstract, kClass, name, baseClasses, classBody);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
		private EnumLiteralsSyntax _enumLiterals;
	
	    public EnumBodySyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public EnumBodySyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TLBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.EnumBodyGreen)this.Green;
				var greenToken = green.TLBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public EnumLiteralsSyntax EnumLiterals => this.GetRed(ref this._enumLiterals, 1);
	    public SyntaxToken TRBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.EnumBodyGreen)this.Green;
				var greenToken = green.TRBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._enumLiterals, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._enumLiterals;
				default: return null;
	        }
	    }
	
	    public EnumBodySyntax WithTLBrace(SyntaxToken tLBrace)
		{
			return this.Update(tLBrace, this.EnumLiterals, this.TRBrace);
		}
	
	    public EnumBodySyntax WithEnumLiterals(EnumLiteralsSyntax enumLiterals)
		{
			return this.Update(this.TLBrace, enumLiterals, this.TRBrace);
		}
	
	    public EnumBodySyntax WithTRBrace(SyntaxToken tRBrace)
		{
			return this.Update(this.TLBrace, this.EnumLiterals, tRBrace);
		}
	
	    public EnumBodySyntax Update(SyntaxToken tLBrace, EnumLiteralsSyntax enumLiterals, SyntaxToken tRBrace)
	    {
	        if (this.TLBrace != tLBrace || this.EnumLiterals != enumLiterals || this.TRBrace != tRBrace)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.EnumBody(tLBrace, enumLiterals, tRBrace);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	public sealed class EnumLiteralsSyntax : MetaSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _metaEnumLiteralList;
	
	    public EnumLiteralsSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public EnumLiteralsSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> MetaEnumLiteralList 
		{ 
			get
			{
				var red = this.GetRed(ref this._metaEnumLiteralList, 0);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax>(red, this.GetChildIndex(0), reversed: false);
				}
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._metaEnumLiteralList, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._metaEnumLiteralList;
				default: return null;
	        }
	    }
	
	    public EnumLiteralsSyntax WithMetaEnumLiteralList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> metaEnumLiteralList)
		{
			return this.Update(metaEnumLiteralList);
		}
	
	    public EnumLiteralsSyntax AddMetaEnumLiteralList(params MetaEnumLiteralSyntax[] metaEnumLiteralList)
		{
			return this.WithMetaEnumLiteralList(this.MetaEnumLiteralList.AddRange(metaEnumLiteralList));
		}
	
	    public EnumLiteralsSyntax Update(MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> metaEnumLiteralList)
	    {
	        if (this.MetaEnumLiteralList != metaEnumLiteralList)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.EnumLiterals(metaEnumLiteralList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (EnumLiteralsSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitEnumLiterals(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitEnumLiterals(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitEnumLiterals(this);
	    }
	
	}
	public sealed class MetaEnumLiteralSyntax : MetaSyntaxNode
	{
		private NameSyntax _name;
	
	    public MetaEnumLiteralSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaEnumLiteralSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
	               newNode = newNode.WithAnnotations(annotations);
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
	    protected ClassNameSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ClassNameSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ClassNameAlt1Syntax : ClassNameSyntax
	{
		private IdentifierSyntax _symbolType;
	
	    public ClassNameAlt1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassNameAlt1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.ClassNameAlt1Green)this.Green;
				var greenToken = green.TIdentifier;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public SyntaxToken TDollar 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.ClassNameAlt1Green)this.Green;
				var greenToken = green.TDollar;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public IdentifierSyntax SymbolType => this.GetRed(ref this._symbolType, 2);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 2: return this.GetRed(ref this._symbolType, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 2: return this._symbolType;
				default: return null;
	        }
	    }
	
	    public ClassNameAlt1Syntax WithTIdentifier(SyntaxToken tIdentifier)
		{
			return this.Update(tIdentifier, this.TDollar, this.SymbolType);
		}
	
	    public ClassNameAlt1Syntax WithTDollar(SyntaxToken tDollar)
		{
			return this.Update(this.TIdentifier, tDollar, this.SymbolType);
		}
	
	    public ClassNameAlt1Syntax WithSymbolType(IdentifierSyntax symbolType)
		{
			return this.Update(this.TIdentifier, this.TDollar, symbolType);
		}
	
	    public ClassNameAlt1Syntax Update(SyntaxToken tIdentifier, SyntaxToken tDollar, IdentifierSyntax symbolType)
	    {
	        if (this.TIdentifier != tIdentifier || this.TDollar != tDollar || this.SymbolType != symbolType)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.ClassNameAlt1(tIdentifier, tDollar, symbolType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	
	    public ClassNameAlt2Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassNameAlt2Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.ClassNameAlt2Green)this.Green;
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
	
	    public ClassNameAlt2Syntax WithTIdentifier(SyntaxToken tIdentifier)
		{
			return this.Update(tIdentifier);
		}
	
	    public ClassNameAlt2Syntax Update(SyntaxToken tIdentifier)
	    {
	        if (this.TIdentifier != tIdentifier)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.ClassNameAlt2(tIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
		private BaseClassesBlock1Syntax _baseClassesBlock1;
	
	    public BaseClassesSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BaseClassesSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public BaseClassesBlock1Syntax BaseClassesBlock1 => this.GetRed(ref this._baseClassesBlock1, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._baseClassesBlock1, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._baseClassesBlock1;
				default: return null;
	        }
	    }
	
	    public BaseClassesSyntax WithBaseClassesBlock1(BaseClassesBlock1Syntax baseClassesBlock1)
		{
			return this.Update(baseClassesBlock1);
		}
	
	    public BaseClassesSyntax Update(BaseClassesBlock1Syntax baseClassesBlock1)
	    {
	        if (this.BaseClassesBlock1 != baseClassesBlock1)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.BaseClasses(baseClassesBlock1);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
		private MetaDslx.CodeAnalysis.SyntaxNode _classMember;
	
	    public ClassBodySyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassBodySyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TLBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.ClassBodyGreen)this.Green;
				var greenToken = green.TLBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax> ClassMember 
		{ 
			get
			{
				var red = this.GetRed(ref this._classMember, 1);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax>(red);
				return default;
			} 
		}
	    public SyntaxToken TRBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.ClassBodyGreen)this.Green;
				var greenToken = green.TRBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._classMember, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._classMember;
				default: return null;
	        }
	    }
	
	    public ClassBodySyntax WithTLBrace(SyntaxToken tLBrace)
		{
			return this.Update(tLBrace, this.ClassMember, this.TRBrace);
		}
	
	    public ClassBodySyntax WithClassMember(MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax> classMember)
		{
			return this.Update(this.TLBrace, classMember, this.TRBrace);
		}
	
	    public ClassBodySyntax AddClassMember(params ClassMemberSyntax[] classMember)
		{
			return this.WithClassMember(this.ClassMember.AddRange(classMember));
		}
	
	    public ClassBodySyntax WithTRBrace(SyntaxToken tRBrace)
		{
			return this.Update(this.TLBrace, this.ClassMember, tRBrace);
		}
	
	    public ClassBodySyntax Update(SyntaxToken tLBrace, MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax> classMember, SyntaxToken tRBrace)
	    {
	        if (this.TLBrace != tLBrace || this.ClassMember != classMember || this.TRBrace != tRBrace)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.ClassBody(tLBrace, classMember, tRBrace);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	    protected ClassMemberSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ClassMemberSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ClassMemberAlt1Syntax : ClassMemberSyntax
	{
		private MetaPropertySyntax _properties;
	
	    public ClassMemberAlt1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassMemberAlt1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaPropertySyntax Properties => this.GetRed(ref this._properties, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._properties, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
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
	               newNode = newNode.WithAnnotations(annotations);
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
	
	    public ClassMemberAlt2Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassMemberAlt2Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaOperationSyntax Operations => this.GetRed(ref this._operations, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._operations, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
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
	               newNode = newNode.WithAnnotations(annotations);
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
		private PropertyNameSyntax _name;
		private MetaDslx.CodeAnalysis.SyntaxNode _metaPropertyBlock2;
	
	    public MetaPropertySyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaPropertySyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken Element 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyGreen)this.Green;
				var greenToken = green.Element;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public TypeReferenceSyntax Type => this.GetRed(ref this._type, 1);
	    public PropertyNameSyntax Name => this.GetRed(ref this._name, 2);
	    public MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock2Syntax> MetaPropertyBlock2 
		{ 
			get
			{
				var red = this.GetRed(ref this._metaPropertyBlock2, 3);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock2Syntax>(red);
				return default;
			} 
		}
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyGreen)this.Green;
				var greenToken = green.TSemicolon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._type, 1);
				case 2: return this.GetRed(ref this._name, 2);
				case 3: return this.GetRed(ref this._metaPropertyBlock2, 3);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._type;
				case 2: return this._name;
				case 3: return this._metaPropertyBlock2;
				default: return null;
	        }
	    }
	
	    public MetaPropertySyntax WithElement(SyntaxToken element)
		{
			return this.Update(element, this.Type, this.Name, this.MetaPropertyBlock2, this.TSemicolon);
		}
	
	    public MetaPropertySyntax WithType(TypeReferenceSyntax type)
		{
			return this.Update(this.Element, type, this.Name, this.MetaPropertyBlock2, this.TSemicolon);
		}
	
	    public MetaPropertySyntax WithName(PropertyNameSyntax name)
		{
			return this.Update(this.Element, this.Type, name, this.MetaPropertyBlock2, this.TSemicolon);
		}
	
	    public MetaPropertySyntax WithMetaPropertyBlock2(MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock2Syntax> metaPropertyBlock2)
		{
			return this.Update(this.Element, this.Type, this.Name, metaPropertyBlock2, this.TSemicolon);
		}
	
	    public MetaPropertySyntax AddMetaPropertyBlock2(params MetaPropertyBlock2Syntax[] metaPropertyBlock2)
		{
			return this.WithMetaPropertyBlock2(this.MetaPropertyBlock2.AddRange(metaPropertyBlock2));
		}
	
	    public MetaPropertySyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.Element, this.Type, this.Name, this.MetaPropertyBlock2, tSemicolon);
		}
	
	    public MetaPropertySyntax Update(SyntaxToken element, TypeReferenceSyntax type, PropertyNameSyntax name, MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock2Syntax> metaPropertyBlock2, SyntaxToken tSemicolon)
	    {
	        if (this.Element != element || this.Type != type || this.Name != name || this.MetaPropertyBlock2 != metaPropertyBlock2 || this.TSemicolon != tSemicolon)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaProperty(element, type, name, metaPropertyBlock2, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	    protected PropertyNameSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected PropertyNameSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class PropertyNameAlt1Syntax : PropertyNameSyntax
	{
	
	    public PropertyNameAlt1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyNameAlt1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyNameAlt1Green)this.Green;
				var greenToken = green.TIdentifier;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public SyntaxToken TDollar 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyNameAlt1Green)this.Green;
				var greenToken = green.TDollar;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public SyntaxToken SymbolProperty 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyNameAlt1Green)this.Green;
				var greenToken = green.SymbolProperty;
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
	
	    public PropertyNameAlt1Syntax WithTIdentifier(SyntaxToken tIdentifier)
		{
			return this.Update(tIdentifier, this.TDollar, this.SymbolProperty);
		}
	
	    public PropertyNameAlt1Syntax WithTDollar(SyntaxToken tDollar)
		{
			return this.Update(this.TIdentifier, tDollar, this.SymbolProperty);
		}
	
	    public PropertyNameAlt1Syntax WithSymbolProperty(SyntaxToken symbolProperty)
		{
			return this.Update(this.TIdentifier, this.TDollar, symbolProperty);
		}
	
	    public PropertyNameAlt1Syntax Update(SyntaxToken tIdentifier, SyntaxToken tDollar, SyntaxToken symbolProperty)
	    {
	        if (this.TIdentifier != tIdentifier || this.TDollar != tDollar || this.SymbolProperty != symbolProperty)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyNameAlt1(tIdentifier, tDollar, symbolProperty);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	
	    public PropertyNameAlt2Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyNameAlt2Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyNameAlt2Green)this.Green;
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
	
	    public PropertyNameAlt2Syntax WithTIdentifier(SyntaxToken tIdentifier)
		{
			return this.Update(tIdentifier);
		}
	
	    public PropertyNameAlt2Syntax Update(SyntaxToken tIdentifier)
	    {
	        if (this.TIdentifier != tIdentifier)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyNameAlt2(tIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	public sealed class PropertyOppositeSyntax : MetaSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _qualifierList;
	
	    public PropertyOppositeSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyOppositeSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KOpposite 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyOppositeGreen)this.Green;
				var greenToken = green.KOpposite;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> QualifierList 
		{ 
			get
			{
				var red = this.GetRed(ref this._qualifierList, 1);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
				}
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._qualifierList, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._qualifierList;
				default: return null;
	        }
	    }
	
	    public PropertyOppositeSyntax WithKOpposite(SyntaxToken kOpposite)
		{
			return this.Update(kOpposite, this.QualifierList);
		}
	
	    public PropertyOppositeSyntax WithQualifierList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
		{
			return this.Update(this.KOpposite, qualifierList);
		}
	
	    public PropertyOppositeSyntax AddQualifierList(params QualifierSyntax[] qualifierList)
		{
			return this.WithQualifierList(this.QualifierList.AddRange(qualifierList));
		}
	
	    public PropertyOppositeSyntax Update(SyntaxToken kOpposite, MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
	    {
	        if (this.KOpposite != kOpposite || this.QualifierList != qualifierList)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyOpposite(kOpposite, qualifierList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	public sealed class PropertySubsetsSyntax : MetaSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _qualifierList;
	
	    public PropertySubsetsSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertySubsetsSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KSubsets 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertySubsetsGreen)this.Green;
				var greenToken = green.KSubsets;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> QualifierList 
		{ 
			get
			{
				var red = this.GetRed(ref this._qualifierList, 1);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
				}
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._qualifierList, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._qualifierList;
				default: return null;
	        }
	    }
	
	    public PropertySubsetsSyntax WithKSubsets(SyntaxToken kSubsets)
		{
			return this.Update(kSubsets, this.QualifierList);
		}
	
	    public PropertySubsetsSyntax WithQualifierList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
		{
			return this.Update(this.KSubsets, qualifierList);
		}
	
	    public PropertySubsetsSyntax AddQualifierList(params QualifierSyntax[] qualifierList)
		{
			return this.WithQualifierList(this.QualifierList.AddRange(qualifierList));
		}
	
	    public PropertySubsetsSyntax Update(SyntaxToken kSubsets, MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
	    {
	        if (this.KSubsets != kSubsets || this.QualifierList != qualifierList)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertySubsets(kSubsets, qualifierList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	public sealed class PropertyRedefinesSyntax : MetaSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _qualifierList;
	
	    public PropertyRedefinesSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyRedefinesSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KRedefines 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyRedefinesGreen)this.Green;
				var greenToken = green.KRedefines;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> QualifierList 
		{ 
			get
			{
				var red = this.GetRed(ref this._qualifierList, 1);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
				}
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._qualifierList, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._qualifierList;
				default: return null;
	        }
	    }
	
	    public PropertyRedefinesSyntax WithKRedefines(SyntaxToken kRedefines)
		{
			return this.Update(kRedefines, this.QualifierList);
		}
	
	    public PropertyRedefinesSyntax WithQualifierList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
		{
			return this.Update(this.KRedefines, qualifierList);
		}
	
	    public PropertyRedefinesSyntax AddQualifierList(params QualifierSyntax[] qualifierList)
		{
			return this.WithQualifierList(this.QualifierList.AddRange(qualifierList));
		}
	
	    public PropertyRedefinesSyntax Update(SyntaxToken kRedefines, MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
	    {
	        if (this.KRedefines != kRedefines || this.QualifierList != qualifierList)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyRedefines(kRedefines, qualifierList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	public sealed class MetaOperationSyntax : MetaSyntaxNode
	{
		private TypeReferenceSyntax _returnType;
		private NameSyntax _name;
		private ParameterListSyntax _parameterList;
	
	    public MetaOperationSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaOperationSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public TypeReferenceSyntax ReturnType => this.GetRed(ref this._returnType, 0);
	    public NameSyntax Name => this.GetRed(ref this._name, 1);
	    public SyntaxToken TLParen 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaOperationGreen)this.Green;
				var greenToken = green.TLParen;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	    public ParameterListSyntax ParameterList => this.GetRed(ref this._parameterList, 3);
	    public SyntaxToken TRParen 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaOperationGreen)this.Green;
				var greenToken = green.TRParen;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
			}
		}
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaOperationGreen)this.Green;
				var greenToken = green.TSemicolon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._returnType, 0);
				case 1: return this.GetRed(ref this._name, 1);
				case 3: return this.GetRed(ref this._parameterList, 3);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
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
	
	    public MetaOperationSyntax WithTLParen(SyntaxToken tLParen)
		{
			return this.Update(this.ReturnType, this.Name, tLParen, this.ParameterList, this.TRParen, this.TSemicolon);
		}
	
	    public MetaOperationSyntax WithParameterList(ParameterListSyntax parameterList)
		{
			return this.Update(this.ReturnType, this.Name, this.TLParen, parameterList, this.TRParen, this.TSemicolon);
		}
	
	    public MetaOperationSyntax WithTRParen(SyntaxToken tRParen)
		{
			return this.Update(this.ReturnType, this.Name, this.TLParen, this.ParameterList, tRParen, this.TSemicolon);
		}
	
	    public MetaOperationSyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.ReturnType, this.Name, this.TLParen, this.ParameterList, this.TRParen, tSemicolon);
		}
	
	    public MetaOperationSyntax Update(TypeReferenceSyntax returnType, NameSyntax name, SyntaxToken tLParen, ParameterListSyntax parameterList, SyntaxToken tRParen, SyntaxToken tSemicolon)
	    {
	        if (this.ReturnType != returnType || this.Name != name || this.TLParen != tLParen || this.ParameterList != parameterList || this.TRParen != tRParen || this.TSemicolon != tSemicolon)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaOperation(returnType, name, tLParen, parameterList, tRParen, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	public sealed class ParameterListSyntax : MetaSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _metaParameterList;
	
	    public ParameterListSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParameterListSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> MetaParameterList 
		{ 
			get
			{
				var red = this.GetRed(ref this._metaParameterList, 0);
				if (red != null)
				{
					return new MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax>(red, this.GetChildIndex(0), reversed: false);
				}
				return default;
			} 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._metaParameterList, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._metaParameterList;
				default: return null;
	        }
	    }
	
	    public ParameterListSyntax WithMetaParameterList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> metaParameterList)
		{
			return this.Update(metaParameterList);
		}
	
	    public ParameterListSyntax AddMetaParameterList(params MetaParameterSyntax[] metaParameterList)
		{
			return this.WithMetaParameterList(this.MetaParameterList.AddRange(metaParameterList));
		}
	
	    public ParameterListSyntax Update(MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> metaParameterList)
	    {
	        if (this.MetaParameterList != metaParameterList)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.ParameterList(metaParameterList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParameterListSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParameterList(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParameterList(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitParameterList(this);
	    }
	
	}
	public sealed class MetaParameterSyntax : MetaSyntaxNode
	{
		private TypeReferenceSyntax _type;
		private NameSyntax _name;
	
	    public MetaParameterSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaParameterSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public TypeReferenceSyntax Type => this.GetRed(ref this._type, 0);
	    public NameSyntax Name => this.GetRed(ref this._name, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._type, 0);
				case 1: return this.GetRed(ref this._name, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
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
	               newNode = newNode.WithAnnotations(annotations);
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
	    protected TypeReferenceSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected TypeReferenceSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class MetaArrayTypeSyntax : TypeReferenceSyntax
	{
		private TypeReferenceSyntax _itemType;
	
	    public MetaArrayTypeSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaArrayTypeSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public TypeReferenceSyntax ItemType => this.GetRed(ref this._itemType, 0);
	    public SyntaxToken TLBracket 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaArrayTypeGreen)this.Green;
				var greenToken = green.TLBracket;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public SyntaxToken TRBracket 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaArrayTypeGreen)this.Green;
				var greenToken = green.TRBracket;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._itemType, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
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
	
	    public MetaArrayTypeSyntax WithTLBracket(SyntaxToken tLBracket)
		{
			return this.Update(this.ItemType, tLBracket, this.TRBracket);
		}
	
	    public MetaArrayTypeSyntax WithTRBracket(SyntaxToken tRBracket)
		{
			return this.Update(this.ItemType, this.TLBracket, tRBracket);
		}
	
	    public MetaArrayTypeSyntax Update(TypeReferenceSyntax itemType, SyntaxToken tLBracket, SyntaxToken tRBracket)
	    {
	        if (this.ItemType != itemType || this.TLBracket != tLBracket || this.TRBracket != tRBracket)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaArrayType(itemType, tLBracket, tRBracket);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	public sealed class TypeReferenceAlt3Syntax : TypeReferenceSyntax
	{
		private QualifierSyntax _qualifier;
	
	    public TypeReferenceAlt3Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TypeReferenceAlt3Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
	
	    public TypeReferenceAlt3Syntax WithQualifier(QualifierSyntax qualifier)
		{
			return this.Update(qualifier);
		}
	
	    public TypeReferenceAlt3Syntax Update(QualifierSyntax qualifier)
	    {
	        if (this.Qualifier != qualifier)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.TypeReferenceAlt3(qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (TypeReferenceAlt3Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTypeReferenceAlt3(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTypeReferenceAlt3(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitTypeReferenceAlt3(this);
	    }
	
	}
	public sealed class TypeReferenceTokensSyntax : TypeReferenceSyntax
	{
	
	    public TypeReferenceTokensSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TypeReferenceTokensSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken Tokens 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.TypeReferenceTokensGreen)this.Green;
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
	
	    public TypeReferenceTokensSyntax WithTokens(SyntaxToken tokens)
		{
			return this.Update(tokens);
		}
	
	    public TypeReferenceTokensSyntax Update(SyntaxToken tokens)
	    {
	        if (this.Tokens != tokens)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.TypeReferenceTokens(tokens);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	public sealed class NameSyntax : MetaSyntaxNode
	{
		private IdentifierSyntax _identifier;
	
	    public NameSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public NameSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Name(identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
		private MetaDslx.CodeAnalysis.SyntaxNode _identifierList;
	
	    public QualifierSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Qualifier(identifierList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	public sealed class QualifierListSyntax : MetaSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _qualifierList;
	
	    public QualifierListSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierListSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
	            var newNode = MetaLanguage.Instance.SyntaxFactory.QualifierList(qualifierList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (QualifierListSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifierList(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifierList(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifierList(this);
	    }
	
	}
	public sealed class IdentifierSyntax : MetaSyntaxNode
	{
	
	    public IdentifierSyntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public IdentifierSyntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.IdentifierGreen)this.Green;
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
	            var newNode = MetaLanguage.Instance.SyntaxFactory.Identifier(tIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
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
	public sealed class EnumLiteralsBlock1Syntax : MetaSyntaxNode
	{
		private MetaEnumLiteralSyntax _literals;
	
	    public EnumLiteralsBlock1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public EnumLiteralsBlock1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.EnumLiteralsBlock1Green)this.Green;
				var greenToken = green.TComma;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public MetaEnumLiteralSyntax Literals => this.GetRed(ref this._literals, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._literals, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._literals;
				default: return null;
	        }
	    }
	
	    public EnumLiteralsBlock1Syntax WithTComma(SyntaxToken tComma)
		{
			return this.Update(tComma, this.Literals);
		}
	
	    public EnumLiteralsBlock1Syntax WithLiterals(MetaEnumLiteralSyntax literals)
		{
			return this.Update(this.TComma, literals);
		}
	
	    public EnumLiteralsBlock1Syntax Update(SyntaxToken tComma, MetaEnumLiteralSyntax literals)
	    {
	        if (this.TComma != tComma || this.Literals != literals)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.EnumLiteralsBlock1(tComma, literals);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (EnumLiteralsBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitEnumLiteralsBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitEnumLiteralsBlock1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitEnumLiteralsBlock1(this);
	    }
	
	}
	public sealed class BaseClassesBlock1Syntax : MetaSyntaxNode
	{
		private QualifierListSyntax _baseTypes;
	
	    public BaseClassesBlock1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BaseClassesBlock1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TColon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.BaseClassesBlock1Green)this.Green;
				var greenToken = green.TColon;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierListSyntax BaseTypes => this.GetRed(ref this._baseTypes, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._baseTypes, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._baseTypes;
				default: return null;
	        }
	    }
	
	    public BaseClassesBlock1Syntax WithTColon(SyntaxToken tColon)
		{
			return this.Update(tColon, this.BaseTypes);
		}
	
	    public BaseClassesBlock1Syntax WithBaseTypes(QualifierListSyntax baseTypes)
		{
			return this.Update(this.TColon, baseTypes);
		}
	
	    public BaseClassesBlock1Syntax Update(SyntaxToken tColon, QualifierListSyntax baseTypes)
	    {
	        if (this.TColon != tColon || this.BaseTypes != baseTypes)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.BaseClassesBlock1(tColon, baseTypes);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (BaseClassesBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBaseClassesBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBaseClassesBlock1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitBaseClassesBlock1(this);
	    }
	
	}
	public abstract class MetaPropertyBlock2Syntax : MetaSyntaxNode
	{
	    protected MetaPropertyBlock2Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected MetaPropertyBlock2Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class MetaPropertyBlock2Alt1Syntax : MetaPropertyBlock2Syntax
	{
		private PropertyOppositeSyntax _propertyOpposite;
	
	    public MetaPropertyBlock2Alt1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaPropertyBlock2Alt1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public PropertyOppositeSyntax PropertyOpposite => this.GetRed(ref this._propertyOpposite, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._propertyOpposite, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._propertyOpposite;
				default: return null;
	        }
	    }
	
	    public MetaPropertyBlock2Alt1Syntax WithPropertyOpposite(PropertyOppositeSyntax propertyOpposite)
		{
			return this.Update(propertyOpposite);
		}
	
	    public MetaPropertyBlock2Alt1Syntax Update(PropertyOppositeSyntax propertyOpposite)
	    {
	        if (this.PropertyOpposite != propertyOpposite)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock2Alt1(propertyOpposite);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MetaPropertyBlock2Alt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaPropertyBlock2Alt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaPropertyBlock2Alt1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaPropertyBlock2Alt1(this);
	    }
	
	}
	public sealed class MetaPropertyBlock2Alt2Syntax : MetaPropertyBlock2Syntax
	{
		private PropertySubsetsSyntax _propertySubsets;
	
	    public MetaPropertyBlock2Alt2Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaPropertyBlock2Alt2Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public PropertySubsetsSyntax PropertySubsets => this.GetRed(ref this._propertySubsets, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._propertySubsets, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._propertySubsets;
				default: return null;
	        }
	    }
	
	    public MetaPropertyBlock2Alt2Syntax WithPropertySubsets(PropertySubsetsSyntax propertySubsets)
		{
			return this.Update(propertySubsets);
		}
	
	    public MetaPropertyBlock2Alt2Syntax Update(PropertySubsetsSyntax propertySubsets)
	    {
	        if (this.PropertySubsets != propertySubsets)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock2Alt2(propertySubsets);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MetaPropertyBlock2Alt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaPropertyBlock2Alt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaPropertyBlock2Alt2(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaPropertyBlock2Alt2(this);
	    }
	
	}
	public sealed class MetaPropertyBlock2Alt3Syntax : MetaPropertyBlock2Syntax
	{
		private PropertyRedefinesSyntax _propertyRedefines;
	
	    public MetaPropertyBlock2Alt3Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaPropertyBlock2Alt3Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public PropertyRedefinesSyntax PropertyRedefines => this.GetRed(ref this._propertyRedefines, 0);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this._propertyRedefines, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this._propertyRedefines;
				default: return null;
	        }
	    }
	
	    public MetaPropertyBlock2Alt3Syntax WithPropertyRedefines(PropertyRedefinesSyntax propertyRedefines)
		{
			return this.Update(propertyRedefines);
		}
	
	    public MetaPropertyBlock2Alt3Syntax Update(PropertyRedefinesSyntax propertyRedefines)
	    {
	        if (this.PropertyRedefines != propertyRedefines)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock2Alt3(propertyRedefines);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MetaPropertyBlock2Alt3Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaPropertyBlock2Alt3(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaPropertyBlock2Alt3(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaPropertyBlock2Alt3(this);
	    }
	
	}
	public sealed class PropertyOppositeBlock1Syntax : MetaSyntaxNode
	{
		private QualifierSyntax _oppositeProperties;
	
	    public PropertyOppositeBlock1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyOppositeBlock1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyOppositeBlock1Green)this.Green;
				var greenToken = green.TComma;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax OppositeProperties => this.GetRed(ref this._oppositeProperties, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._oppositeProperties, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._oppositeProperties;
				default: return null;
	        }
	    }
	
	    public PropertyOppositeBlock1Syntax WithTComma(SyntaxToken tComma)
		{
			return this.Update(tComma, this.OppositeProperties);
		}
	
	    public PropertyOppositeBlock1Syntax WithOppositeProperties(QualifierSyntax oppositeProperties)
		{
			return this.Update(this.TComma, oppositeProperties);
		}
	
	    public PropertyOppositeBlock1Syntax Update(SyntaxToken tComma, QualifierSyntax oppositeProperties)
	    {
	        if (this.TComma != tComma || this.OppositeProperties != oppositeProperties)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyOppositeBlock1(tComma, oppositeProperties);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PropertyOppositeBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertyOppositeBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertyOppositeBlock1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertyOppositeBlock1(this);
	    }
	
	}
	public sealed class PropertySubsetsBlock1Syntax : MetaSyntaxNode
	{
		private QualifierSyntax _subsettedProperties;
	
	    public PropertySubsetsBlock1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertySubsetsBlock1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertySubsetsBlock1Green)this.Green;
				var greenToken = green.TComma;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax SubsettedProperties => this.GetRed(ref this._subsettedProperties, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._subsettedProperties, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._subsettedProperties;
				default: return null;
	        }
	    }
	
	    public PropertySubsetsBlock1Syntax WithTComma(SyntaxToken tComma)
		{
			return this.Update(tComma, this.SubsettedProperties);
		}
	
	    public PropertySubsetsBlock1Syntax WithSubsettedProperties(QualifierSyntax subsettedProperties)
		{
			return this.Update(this.TComma, subsettedProperties);
		}
	
	    public PropertySubsetsBlock1Syntax Update(SyntaxToken tComma, QualifierSyntax subsettedProperties)
	    {
	        if (this.TComma != tComma || this.SubsettedProperties != subsettedProperties)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertySubsetsBlock1(tComma, subsettedProperties);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PropertySubsetsBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertySubsetsBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertySubsetsBlock1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertySubsetsBlock1(this);
	    }
	
	}
	public sealed class PropertyRedefinesBlock1Syntax : MetaSyntaxNode
	{
		private QualifierSyntax _redefinedProperties;
	
	    public PropertyRedefinesBlock1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyRedefinesBlock1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PropertyRedefinesBlock1Green)this.Green;
				var greenToken = green.TComma;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax RedefinedProperties => this.GetRed(ref this._redefinedProperties, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._redefinedProperties, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._redefinedProperties;
				default: return null;
	        }
	    }
	
	    public PropertyRedefinesBlock1Syntax WithTComma(SyntaxToken tComma)
		{
			return this.Update(tComma, this.RedefinedProperties);
		}
	
	    public PropertyRedefinesBlock1Syntax WithRedefinedProperties(QualifierSyntax redefinedProperties)
		{
			return this.Update(this.TComma, redefinedProperties);
		}
	
	    public PropertyRedefinesBlock1Syntax Update(SyntaxToken tComma, QualifierSyntax redefinedProperties)
	    {
	        if (this.TComma != tComma || this.RedefinedProperties != redefinedProperties)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.PropertyRedefinesBlock1(tComma, redefinedProperties);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PropertyRedefinesBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertyRedefinesBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertyRedefinesBlock1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertyRedefinesBlock1(this);
	    }
	
	}
	public sealed class ParameterListBlock1Syntax : MetaSyntaxNode
	{
		private MetaParameterSyntax _parameters;
	
	    public ParameterListBlock1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParameterListBlock1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.ParameterListBlock1Green)this.Green;
				var greenToken = green.TComma;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public MetaParameterSyntax Parameters => this.GetRed(ref this._parameters, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._parameters, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._parameters;
				default: return null;
	        }
	    }
	
	    public ParameterListBlock1Syntax WithTComma(SyntaxToken tComma)
		{
			return this.Update(tComma, this.Parameters);
		}
	
	    public ParameterListBlock1Syntax WithParameters(MetaParameterSyntax parameters)
		{
			return this.Update(this.TComma, parameters);
		}
	
	    public ParameterListBlock1Syntax Update(SyntaxToken tComma, MetaParameterSyntax parameters)
	    {
	        if (this.TComma != tComma || this.Parameters != parameters)
	        {
	            var newNode = MetaLanguage.Instance.SyntaxFactory.ParameterListBlock1(tComma, parameters);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParameterListBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParameterListBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParameterListBlock1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitParameterListBlock1(this);
	    }
	
	}
	public sealed class QualifierBlock1Syntax : MetaSyntaxNode
	{
		private IdentifierSyntax _identifier;
	
	    public QualifierBlock1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierBlock1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TDot 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.QualifierBlock1Green)this.Green;
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
	            var newNode = MetaLanguage.Instance.SyntaxFactory.QualifierBlock1(tDot, identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (QualifierBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifierBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifierBlock1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifierBlock1(this);
	    }
	
	}
	public sealed class QualifierListBlock1Syntax : MetaSyntaxNode
	{
		private QualifierSyntax _qualifier;
	
	    public QualifierListBlock1Syntax(InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierListBlock1Syntax(InternalSyntaxNode green, MetaSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.QualifierListBlock1Green)this.Green;
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
	            var newNode = MetaLanguage.Instance.SyntaxFactory.QualifierListBlock1(tComma, qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (QualifierListBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifierListBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifierListBlock1(this);
	    }
	
	    public override void Accept(IMetaSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifierListBlock1(this);
	    }
	
	}
}
