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
using MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax
{

    public abstract class MetaCoreSyntaxNode : SyntaxNode
    {
        protected MetaCoreSyntaxNode(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }

        protected MetaCoreSyntaxNode(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public override MetaCoreLanguage Language => MetaCoreLanguage.Instance;
        public MetaCoreSyntaxKind Kind => (MetaCoreSyntaxKind)this.RawKind;
		internal new GreenNode Green => base.Green;

        protected override SyntaxTree CreateSyntaxTreeForRoot()
        {
            return MetaCoreSyntaxTree.CreateWithoutClone(this, IncrementalParseData.Empty);
        }

        public override TResult Accept<TArg, TResult>(SyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            if (visitor is IMetaCoreSyntaxVisitor<TArg, TResult> typedVisitor) return this.Accept(typedVisitor, argument);
            else return visitor.DefaultVisit(this, argument);
        }

        public abstract TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument);

        public override TResult Accept<TResult>(SyntaxVisitor<TResult> visitor)
        {
            if (visitor is IMetaCoreSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor);

        public override void Accept(SyntaxVisitor visitor)
        {
            if (visitor is IMetaCoreSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }
        public abstract void Accept(IMetaCoreSyntaxVisitor visitor);
    }

    /// <summary>
    /// It's a non terminal Trivia MetaCoreSyntaxNode that has a tree underneath it.
    /// </summary>
    public abstract partial class MetaCoreStructuredTriviaSyntax : MetaCoreSyntaxNode, IStructuredTriviaSyntax
    {
        private SyntaxTrivia _parent;
        internal MetaCoreStructuredTriviaSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
            : base(green, parent == null ? null : (MetaCoreSyntaxTree)parent.SyntaxTree, position)
        {
            System.Diagnostics.Debug.Assert(parent == null || position >= 0);
        }
		internal static MetaCoreStructuredTriviaSyntax Create(SyntaxTrivia trivia)
		{
			var red = (MetaCoreStructuredTriviaSyntax)MetaCoreLanguage.Instance.SyntaxFactory.CreateStructure(trivia);
			red._parent = trivia;
			return red;
		}
        /// <summary>
        /// Get parent trivia.
        /// </summary>
        public override SyntaxTrivia ParentTrivia => _parent;
    }

    public sealed partial class MetaCoreSkippedTokensTriviaSyntax : MetaCoreStructuredTriviaSyntax
    {
        internal MetaCoreSkippedTokensTriviaSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public SyntaxTokenList Tokens 
        {
            get
            {
				var slot = ((global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.GreenSkippedTokensTriviaSyntax)this.Green).Tokens;
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

		public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
		{
			return visitor.VisitSkippedTokensTrivia(this, argument);
		}

		public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSkippedTokensTrivia(this);
        }

        public override void Accept(IMetaCoreSyntaxVisitor visitor)
        {
            visitor.VisitSkippedTokensTrivia(this);
        }

        public MetaCoreSkippedTokensTriviaSyntax Update(SyntaxTokenList tokens)
        {
            if (tokens != this.Tokens)
            {
                var newNode = (MetaCoreSkippedTokensTriviaSyntax)Language.SyntaxFactory.SkippedTokensTrivia(tokens);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    return newNode.WithAnnotations(annotations);
                return newNode;
            }
            return this;
        }

        public MetaCoreSkippedTokensTriviaSyntax WithTokens(SyntaxTokenList tokens)
        {
            return this.Update(tokens);
        }

        public MetaCoreSkippedTokensTriviaSyntax AddTokens(params SyntaxToken[] items)
        {
            return this.WithTokens(this.Tokens.AddRange(items));
        }
    }

	public sealed class MainSyntax : MetaCoreSyntaxNode, ICompilationUnitSyntax
	{
		private QualifierSyntax _name;
		private MetaDslx.CodeAnalysis.SyntaxNode _using;
		private DeclarationsSyntax _declarations;
	
	    public MainSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MainSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KNamespace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
				var greenToken = green.KNamespace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax Name => this.GetRed(ref this._name, 1);
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.Main(kNamespace, name, tSemicolon, @using, declarations, eof);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MainSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMain(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMain(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitMain(this);
	    }
	
	}
	public sealed class UsingSyntax : MetaCoreSyntaxNode
	{
		private QualifierSyntax _namespaces;
	
	    public UsingSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public UsingSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KUsing 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
				var greenToken = green.KUsing;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax Namespaces => this.GetRed(ref this._namespaces, 1);
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.Using(kUsing, namespaces, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (UsingSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitUsing(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitUsing(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitUsing(this);
	    }
	
	}
	public sealed class DeclarationsSyntax : MetaCoreSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _declarations;
	
	    public DeclarationsSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public DeclarationsSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.Declarations(declarations);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (DeclarationsSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitDeclarations(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitDeclarations(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitDeclarations(this);
	    }
	
	}
	public abstract class MetaDeclarationSyntax : MetaCoreSyntaxNode
	{
	    protected MetaDeclarationSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected MetaDeclarationSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class MetaModelSyntax : MetaDeclarationSyntax
	{
		private NameSyntax _name;
	
	    public MetaModelSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaModelSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KMetamodel 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MetaModelGreen)this.Green;
				var greenToken = green.KMetamodel;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public NameSyntax Name => this.GetRed(ref this._name, 1);
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MetaModelGreen)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.MetaModel(kMetamodel, name, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MetaModelSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaModel(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaModel(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaModel(this);
	    }
	
	}
	public sealed class MetaEnumTypeSyntax : MetaDeclarationSyntax
	{
		private NameSyntax _name;
		private EnumBodySyntax _enumBody;
	
	    public MetaEnumTypeSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaEnumTypeSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KEnum 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MetaEnumTypeGreen)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.MetaEnumType(kEnum, name, enumBody);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MetaEnumTypeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaEnumType(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaEnumType(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaEnumType(this);
	    }
	
	}
	public sealed class MetaClassSyntax : MetaDeclarationSyntax
	{
		private ClassNameSyntax _name;
		private BaseClassesSyntax _baseClasses;
		private ClassBodySyntax _classBody;
	
	    public MetaClassSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaClassSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken IsAbstract 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MetaClassGreen)this.Green;
				var greenToken = green.IsAbstract;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public SyntaxToken KClass 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MetaClassGreen)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.MetaClass(isAbstract, kClass, name, baseClasses, classBody);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MetaClassSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaClass(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaClass(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaClass(this);
	    }
	
	}
	public sealed class EnumBodySyntax : MetaCoreSyntaxNode
	{
		private EnumLiteralsSyntax _enumLiterals;
	
	    public EnumBodySyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public EnumBodySyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TLBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.EnumBodyGreen)this.Green;
				var greenToken = green.TLBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public EnumLiteralsSyntax EnumLiterals => this.GetRed(ref this._enumLiterals, 1);
	    public SyntaxToken TRBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.EnumBodyGreen)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.EnumBody(tLBrace, enumLiterals, tRBrace);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (EnumBodySyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitEnumBody(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitEnumBody(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitEnumBody(this);
	    }
	
	}
	public sealed class EnumLiteralsSyntax : MetaCoreSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _metaEnumLiteralList;
	
	    public EnumLiteralsSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public EnumLiteralsSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.EnumLiterals(metaEnumLiteralList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (EnumLiteralsSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitEnumLiterals(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitEnumLiterals(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitEnumLiterals(this);
	    }
	
	}
	public sealed class MetaEnumLiteralSyntax : MetaCoreSyntaxNode
	{
		private NameSyntax _name;
	
	    public MetaEnumLiteralSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaEnumLiteralSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.MetaEnumLiteral(name);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MetaEnumLiteralSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaEnumLiteral(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaEnumLiteral(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaEnumLiteral(this);
	    }
	
	}
	public abstract class ClassNameSyntax : MetaCoreSyntaxNode
	{
	    protected ClassNameSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ClassNameSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class ClassNameAlt1Syntax : ClassNameSyntax
	{
		private IdentifierSyntax _identifier;
	
	    public ClassNameAlt1Syntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassNameAlt1Syntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.ClassNameAlt1Green)this.Green;
				var greenToken = green.TIdentifier;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public SyntaxToken THash 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.ClassNameAlt1Green)this.Green;
				var greenToken = green.THash;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public IdentifierSyntax Identifier => this.GetRed(ref this._identifier, 2);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 2: return this.GetRed(ref this._identifier, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 2: return this._identifier;
				default: return null;
	        }
	    }
	
	    public ClassNameAlt1Syntax WithTIdentifier(SyntaxToken tIdentifier)
		{
			return this.Update(tIdentifier, this.THash, this.Identifier);
		}
	
	    public ClassNameAlt1Syntax WithTHash(SyntaxToken tHash)
		{
			return this.Update(this.TIdentifier, tHash, this.Identifier);
		}
	
	    public ClassNameAlt1Syntax WithIdentifier(IdentifierSyntax identifier)
		{
			return this.Update(this.TIdentifier, this.THash, identifier);
		}
	
	    public ClassNameAlt1Syntax Update(SyntaxToken tIdentifier, SyntaxToken tHash, IdentifierSyntax identifier)
	    {
	        if (this.TIdentifier != tIdentifier || this.THash != tHash || this.Identifier != identifier)
	        {
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.ClassNameAlt1(tIdentifier, tHash, identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ClassNameAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitClassNameAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitClassNameAlt1(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitClassNameAlt1(this);
	    }
	
	}
	public sealed class ClassNameAlt2Syntax : ClassNameSyntax
	{
	
	    public ClassNameAlt2Syntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassNameAlt2Syntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.ClassNameAlt2Green)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.ClassNameAlt2(tIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ClassNameAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitClassNameAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitClassNameAlt2(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitClassNameAlt2(this);
	    }
	
	}
	public sealed class BaseClassesSyntax : MetaCoreSyntaxNode
	{
		private BaseClassesBlock1Syntax _baseClassesBlock1;
	
	    public BaseClassesSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BaseClassesSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.BaseClasses(baseClassesBlock1);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (BaseClassesSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBaseClasses(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBaseClasses(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitBaseClasses(this);
	    }
	
	}
	public sealed class ClassBodySyntax : MetaCoreSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _properties;
	
	    public ClassBodySyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ClassBodySyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TLBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.ClassBodyGreen)this.Green;
				var greenToken = green.TLBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public MetaDslx.CodeAnalysis.SyntaxList<MetaPropertySyntax> Properties 
		{ 
			get
			{
				var red = this.GetRed(ref this._properties, 1);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<MetaPropertySyntax>(red);
				return default;
			} 
		}
	    public SyntaxToken TRBrace 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.ClassBodyGreen)this.Green;
				var greenToken = green.TRBrace;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._properties, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._properties;
				default: return null;
	        }
	    }
	
	    public ClassBodySyntax WithTLBrace(SyntaxToken tLBrace)
		{
			return this.Update(tLBrace, this.Properties, this.TRBrace);
		}
	
	    public ClassBodySyntax WithProperties(MetaDslx.CodeAnalysis.SyntaxList<MetaPropertySyntax> properties)
		{
			return this.Update(this.TLBrace, properties, this.TRBrace);
		}
	
	    public ClassBodySyntax AddProperties(params MetaPropertySyntax[] properties)
		{
			return this.WithProperties(this.Properties.AddRange(properties));
		}
	
	    public ClassBodySyntax WithTRBrace(SyntaxToken tRBrace)
		{
			return this.Update(this.TLBrace, this.Properties, tRBrace);
		}
	
	    public ClassBodySyntax Update(SyntaxToken tLBrace, MetaDslx.CodeAnalysis.SyntaxList<MetaPropertySyntax> properties, SyntaxToken tRBrace)
	    {
	        if (this.TLBrace != tLBrace || this.Properties != properties || this.TRBrace != tRBrace)
	        {
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.ClassBody(tLBrace, properties, tRBrace);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ClassBodySyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitClassBody(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitClassBody(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitClassBody(this);
	    }
	
	}
	public sealed class MetaPropertySyntax : MetaCoreSyntaxNode
	{
		private TypeReferenceSyntax _type;
		private PropertyNameSyntax _name;
		private PropertyOppositeSyntax _propertyOpposite;
	
	    public MetaPropertySyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaPropertySyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken Element 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyGreen)this.Green;
				var greenToken = green.Element;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public TypeReferenceSyntax Type => this.GetRed(ref this._type, 1);
	    public PropertyNameSyntax Name => this.GetRed(ref this._name, 2);
	    public PropertyOppositeSyntax PropertyOpposite => this.GetRed(ref this._propertyOpposite, 3);
	    public SyntaxToken TSemicolon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyGreen)this.Green;
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
				case 3: return this.GetRed(ref this._propertyOpposite, 3);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._type;
				case 2: return this._name;
				case 3: return this._propertyOpposite;
				default: return null;
	        }
	    }
	
	    public MetaPropertySyntax WithElement(SyntaxToken element)
		{
			return this.Update(element, this.Type, this.Name, this.PropertyOpposite, this.TSemicolon);
		}
	
	    public MetaPropertySyntax WithType(TypeReferenceSyntax type)
		{
			return this.Update(this.Element, type, this.Name, this.PropertyOpposite, this.TSemicolon);
		}
	
	    public MetaPropertySyntax WithName(PropertyNameSyntax name)
		{
			return this.Update(this.Element, this.Type, name, this.PropertyOpposite, this.TSemicolon);
		}
	
	    public MetaPropertySyntax WithPropertyOpposite(PropertyOppositeSyntax propertyOpposite)
		{
			return this.Update(this.Element, this.Type, this.Name, propertyOpposite, this.TSemicolon);
		}
	
	    public MetaPropertySyntax WithTSemicolon(SyntaxToken tSemicolon)
		{
			return this.Update(this.Element, this.Type, this.Name, this.PropertyOpposite, tSemicolon);
		}
	
	    public MetaPropertySyntax Update(SyntaxToken element, TypeReferenceSyntax type, PropertyNameSyntax name, PropertyOppositeSyntax propertyOpposite, SyntaxToken tSemicolon)
	    {
	        if (this.Element != element || this.Type != type || this.Name != name || this.PropertyOpposite != propertyOpposite || this.TSemicolon != tSemicolon)
	        {
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.MetaProperty(element, type, name, propertyOpposite, tSemicolon);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MetaPropertySyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaProperty(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaProperty(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaProperty(this);
	    }
	
	}
	public abstract class PropertyNameSyntax : MetaCoreSyntaxNode
	{
	    protected PropertyNameSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected PropertyNameSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class PropertyNameAlt1Syntax : PropertyNameSyntax
	{
	
	    public PropertyNameAlt1Syntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyNameAlt1Syntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.PropertyNameAlt1Green)this.Green;
				var greenToken = green.TIdentifier;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public SyntaxToken THash 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.PropertyNameAlt1Green)this.Green;
				var greenToken = green.THash;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public SyntaxToken TIdentifier1 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.PropertyNameAlt1Green)this.Green;
				var greenToken = green.TIdentifier1;
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
			return this.Update(tIdentifier, this.THash, this.TIdentifier1);
		}
	
	    public PropertyNameAlt1Syntax WithTHash(SyntaxToken tHash)
		{
			return this.Update(this.TIdentifier, tHash, this.TIdentifier1);
		}
	
	    public PropertyNameAlt1Syntax WithTIdentifier1(SyntaxToken tIdentifier1)
		{
			return this.Update(this.TIdentifier, this.THash, tIdentifier1);
		}
	
	    public PropertyNameAlt1Syntax Update(SyntaxToken tIdentifier, SyntaxToken tHash, SyntaxToken tIdentifier1)
	    {
	        if (this.TIdentifier != tIdentifier || this.THash != tHash || this.TIdentifier1 != tIdentifier1)
	        {
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.PropertyNameAlt1(tIdentifier, tHash, tIdentifier1);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PropertyNameAlt1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertyNameAlt1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertyNameAlt1(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertyNameAlt1(this);
	    }
	
	}
	public sealed class PropertyNameAlt2Syntax : PropertyNameSyntax
	{
	
	    public PropertyNameAlt2Syntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyNameAlt2Syntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.PropertyNameAlt2Green)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.PropertyNameAlt2(tIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PropertyNameAlt2Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertyNameAlt2(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertyNameAlt2(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertyNameAlt2(this);
	    }
	
	}
	public sealed class PropertyOppositeSyntax : MetaCoreSyntaxNode
	{
		private QualifierSyntax _opposite;
	
	    public PropertyOppositeSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PropertyOppositeSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken KOpposite 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.PropertyOppositeGreen)this.Green;
				var greenToken = green.KOpposite;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public QualifierSyntax Opposite => this.GetRed(ref this._opposite, 1);
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this._opposite, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this._opposite;
				default: return null;
	        }
	    }
	
	    public PropertyOppositeSyntax WithKOpposite(SyntaxToken kOpposite)
		{
			return this.Update(kOpposite, this.Opposite);
		}
	
	    public PropertyOppositeSyntax WithOpposite(QualifierSyntax opposite)
		{
			return this.Update(this.KOpposite, opposite);
		}
	
	    public PropertyOppositeSyntax Update(SyntaxToken kOpposite, QualifierSyntax opposite)
	    {
	        if (this.KOpposite != kOpposite || this.Opposite != opposite)
	        {
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.PropertyOpposite(kOpposite, opposite);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PropertyOppositeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPropertyOpposite(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPropertyOpposite(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitPropertyOpposite(this);
	    }
	
	}
	public abstract class TypeReferenceSyntax : MetaCoreSyntaxNode
	{
	    protected TypeReferenceSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected TypeReferenceSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class MetaArrayTypeSyntax : TypeReferenceSyntax
	{
		private TypeReferenceSyntax _itemType;
	
	    public MetaArrayTypeSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MetaArrayTypeSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public TypeReferenceSyntax ItemType => this.GetRed(ref this._itemType, 0);
	    public SyntaxToken TLBracket 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MetaArrayTypeGreen)this.Green;
				var greenToken = green.TLBracket;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public SyntaxToken TRBracket 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.MetaArrayTypeGreen)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.MetaArrayType(itemType, tLBracket, tRBracket);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MetaArrayTypeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMetaArrayType(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMetaArrayType(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitMetaArrayType(this);
	    }
	
	}
	public sealed class TypeReferenceAlt3Syntax : TypeReferenceSyntax
	{
		private QualifierSyntax _qualifier;
	
	    public TypeReferenceAlt3Syntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TypeReferenceAlt3Syntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.TypeReferenceAlt3(qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (TypeReferenceAlt3Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTypeReferenceAlt3(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTypeReferenceAlt3(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitTypeReferenceAlt3(this);
	    }
	
	}
	public sealed class TypeReferenceTokensSyntax : TypeReferenceSyntax
	{
	
	    public TypeReferenceTokensSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TypeReferenceTokensSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken Tokens 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.TypeReferenceTokensGreen)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.TypeReferenceTokens(tokens);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (TypeReferenceTokensSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTypeReferenceTokens(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTypeReferenceTokens(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitTypeReferenceTokens(this);
	    }
	
	}
	public sealed class NameSyntax : MetaCoreSyntaxNode
	{
		private IdentifierSyntax _identifier;
	
	    public NameSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public NameSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.Name(identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (NameSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitName(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitName(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitName(this);
	    }
	
	}
	public sealed class QualifierSyntax : MetaCoreSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _identifierList;
	
	    public QualifierSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.Qualifier(identifierList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (QualifierSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifier(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifier(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifier(this);
	    }
	
	}
	public sealed class QualifierListSyntax : MetaCoreSyntaxNode
	{
		private MetaDslx.CodeAnalysis.SyntaxNode _qualifierList;
	
	    public QualifierListSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierListSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.QualifierList(qualifierList);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (QualifierListSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifierList(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifierList(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifierList(this);
	    }
	
	}
	public sealed class IdentifierSyntax : MetaCoreSyntaxNode
	{
	
	    public IdentifierSyntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public IdentifierSyntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TIdentifier 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.IdentifierGreen)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.Identifier(tIdentifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (IdentifierSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitIdentifier(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitIdentifier(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitIdentifier(this);
	    }
	
	}
	public sealed class EnumLiteralsBlock1Syntax : MetaCoreSyntaxNode
	{
		private MetaEnumLiteralSyntax _literals;
	
	    public EnumLiteralsBlock1Syntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public EnumLiteralsBlock1Syntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.EnumLiteralsBlock1Green)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.EnumLiteralsBlock1(tComma, literals);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (EnumLiteralsBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitEnumLiteralsBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitEnumLiteralsBlock1(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitEnumLiteralsBlock1(this);
	    }
	
	}
	public sealed class BaseClassesBlock1Syntax : MetaCoreSyntaxNode
	{
		private QualifierListSyntax _baseTypes;
	
	    public BaseClassesBlock1Syntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BaseClassesBlock1Syntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TColon 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.BaseClassesBlock1Green)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.BaseClassesBlock1(tColon, baseTypes);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (BaseClassesBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBaseClassesBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBaseClassesBlock1(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitBaseClassesBlock1(this);
	    }
	
	}
	public sealed class QualifierBlock1Syntax : MetaCoreSyntaxNode
	{
		private IdentifierSyntax _identifier;
	
	    public QualifierBlock1Syntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierBlock1Syntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TDot 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.QualifierBlock1Green)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.QualifierBlock1(tDot, identifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (QualifierBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifierBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifierBlock1(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifierBlock1(this);
	    }
	
	}
	public sealed class QualifierListBlock1Syntax : MetaCoreSyntaxNode
	{
		private QualifierSyntax _qualifier;
	
	    public QualifierListBlock1Syntax(InternalSyntaxNode green, MetaCoreSyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public QualifierListBlock1Syntax(InternalSyntaxNode green, MetaCoreSyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken TComma 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax.QualifierListBlock1Green)this.Green;
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
	            var newNode = MetaCoreLanguage.Instance.SyntaxFactory.QualifierListBlock1(tComma, qualifier);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (QualifierListBlock1Syntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(IMetaCoreSyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitQualifierListBlock1(this, argument);
	    }
	
	    public override TResult Accept<TResult>(IMetaCoreSyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitQualifierListBlock1(this);
	    }
	
	    public override void Accept(IMetaCoreSyntaxVisitor visitor)
	    {
	        visitor.VisitQualifierListBlock1(this);
	    }
	
	}
}
