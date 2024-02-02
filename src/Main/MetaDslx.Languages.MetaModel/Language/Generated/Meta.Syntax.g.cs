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
        private QualifierSyntax _qualifier;
        private __SyntaxNode _usingList;
        private MainBlock1Syntax _block;
    
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
        public QualifierSyntax Qualifier 
        { 
            get
            {
            var red = this.GetRed(ref this._qualifier, 1);
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
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
    
        public MainSyntax WithQualifier(QualifierSyntax qualifier)
        {
            return this.Update(this.KNamespace, qualifier, this.TSemicolon, this.UsingList, this.Block, this.EndOfFileToken);
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
    
    
        public MainSyntax Update(__SyntaxToken kNamespace, QualifierSyntax qualifier, __SyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MainBlock1Syntax block, __SyntaxToken endOfFileToken)
        {
            if (this.KNamespace != kNamespace || this.Qualifier != qualifier || this.TSemicolon != tSemicolon || this.UsingList != usingList || this.Block != block || this.EndOfFileToken != endOfFileToken)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.Main(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
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
    
    public sealed class MetaModelSyntax : MetaSyntaxNode
    {
        private NameSyntax _name;
        private MetaModelBlock1Syntax _block;
    
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
        public MetaModelBlock1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 3);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._name, 1);
                case 3: return this.GetRed(ref this._block, 3);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._name;
                case 3: return this._block;
                default: return null;
            }
        }
    
        public MetaModelSyntax WithKMetamodel(__SyntaxToken kMetamodel)
        {
            return this.Update(kMetamodel, this.Name, this.TSemicolon, this.Block);
        }
    
        public MetaModelSyntax WithName(NameSyntax name)
        {
            return this.Update(this.KMetamodel, name, this.TSemicolon, this.Block);
        }
    
        public MetaModelSyntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.KMetamodel, this.Name, tSemicolon, this.Block);
        }
    
        public MetaModelSyntax WithBlock(MetaModelBlock1Syntax block)
        {
            return this.Update(this.KMetamodel, this.Name, this.TSemicolon, block);
        }
    
    
        public MetaModelSyntax Update(__SyntaxToken kMetamodel, NameSyntax name, __SyntaxToken tSemicolon, MetaModelBlock1Syntax block)
        {
            if (this.KMetamodel != kMetamodel || this.Name != name || this.TSemicolon != tSemicolon || this.Block != block)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaModel(kMetamodel, name, tSemicolon, block);
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
    
    public sealed class MetaDeclarationAlt1Syntax : MetaDeclarationSyntax
    {
        private MetaConstantSyntax _metaConstant;
    
        public MetaDeclarationAlt1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaDeclarationAlt1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public MetaConstantSyntax MetaConstant 
        { 
            get
            {
            var red = this.GetRed(ref this._metaConstant, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._metaConstant, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._metaConstant;
                default: return null;
            }
        }
    
        public MetaDeclarationAlt1Syntax WithMetaConstant(MetaConstantSyntax metaConstant)
        {
            return this.Update(metaConstant);
        }
    
    
        public MetaDeclarationAlt1Syntax Update(MetaConstantSyntax metaConstant)
        {
            if (this.MetaConstant != metaConstant)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaDeclarationAlt1(metaConstant);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaDeclarationAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaDeclarationAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaDeclarationAlt1(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaDeclarationAlt1(this);
        }
    
    }
    public sealed class MetaDeclarationAlt2Syntax : MetaDeclarationSyntax
    {
        private MetaEnumSyntax _metaEnum;
    
        public MetaDeclarationAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaDeclarationAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public MetaEnumSyntax MetaEnum 
        { 
            get
            {
            var red = this.GetRed(ref this._metaEnum, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._metaEnum, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._metaEnum;
                default: return null;
            }
        }
    
        public MetaDeclarationAlt2Syntax WithMetaEnum(MetaEnumSyntax metaEnum)
        {
            return this.Update(metaEnum);
        }
    
    
        public MetaDeclarationAlt2Syntax Update(MetaEnumSyntax metaEnum)
        {
            if (this.MetaEnum != metaEnum)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaDeclarationAlt2(metaEnum);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaDeclarationAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaDeclarationAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaDeclarationAlt2(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaDeclarationAlt2(this);
        }
    
    }
    public sealed class MetaDeclarationAlt3Syntax : MetaDeclarationSyntax
    {
        private MetaClassSyntax _metaClass;
    
        public MetaDeclarationAlt3Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaDeclarationAlt3Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public MetaClassSyntax MetaClass 
        { 
            get
            {
            var red = this.GetRed(ref this._metaClass, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._metaClass, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._metaClass;
                default: return null;
            }
        }
    
        public MetaDeclarationAlt3Syntax WithMetaClass(MetaClassSyntax metaClass)
        {
            return this.Update(metaClass);
        }
    
    
        public MetaDeclarationAlt3Syntax Update(MetaClassSyntax metaClass)
        {
            if (this.MetaClass != metaClass)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaDeclarationAlt3(metaClass);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaDeclarationAlt3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaDeclarationAlt3(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaDeclarationAlt3(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaDeclarationAlt3(this);
        }
    
    }
    
    public sealed class MetaConstantSyntax : MetaSyntaxNode
    {
        private MetaTypeReferenceSyntax _type;
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
        public MetaTypeReferenceSyntax Type 
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
    
        public MetaConstantSyntax WithType(MetaTypeReferenceSyntax type)
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
    
    
        public MetaConstantSyntax Update(__SyntaxToken kConst, MetaTypeReferenceSyntax type, NameSyntax name, __SyntaxToken tSemicolon)
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
    
    public sealed class MetaEnumSyntax : MetaSyntaxNode
    {
        private NameSyntax _name;
        private MetaEnumBlock1Syntax _block;
    
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
        public MetaEnumBlock1Syntax Block 
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
    
        public MetaEnumSyntax WithKEnum(__SyntaxToken kEnum)
        {
            return this.Update(kEnum, this.Name, this.Block);
        }
    
        public MetaEnumSyntax WithName(NameSyntax name)
        {
            return this.Update(this.KEnum, name, this.Block);
        }
    
        public MetaEnumSyntax WithBlock(MetaEnumBlock1Syntax block)
        {
            return this.Update(this.KEnum, this.Name, block);
        }
    
    
        public MetaEnumSyntax Update(__SyntaxToken kEnum, NameSyntax name, MetaEnumBlock1Syntax block)
        {
            if (this.KEnum != kEnum || this.Name != name || this.Block != block)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaEnum(kEnum, name, block);
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
    
    public sealed class MetaClassSyntax : MetaSyntaxNode
    {
        private MetaClassBlock1Syntax _block1;
        private MetaClassBlock2Syntax _block2;
        private MetaClassBlock3Syntax _block3;
    
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
        public MetaClassBlock1Syntax Block1 
        { 
            get
            {
            var red = this.GetRed(ref this._block1, 2);
            return red;
            } 
        }
        public MetaClassBlock2Syntax Block2 
        { 
            get
            {
            var red = this.GetRed(ref this._block2, 3);
            return red;
            } 
        }
        public MetaClassBlock3Syntax Block3 
        { 
            get
            {
            var red = this.GetRed(ref this._block3, 4);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 2: return this.GetRed(ref this._block1, 2);
                case 3: return this.GetRed(ref this._block2, 3);
                case 4: return this.GetRed(ref this._block3, 4);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 2: return this._block1;
                case 3: return this._block2;
                case 4: return this._block3;
                default: return null;
            }
        }
    
        public MetaClassSyntax WithIsAbstract(__SyntaxToken isAbstract)
        {
            return this.Update(isAbstract, this.KClass, this.Block1, this.Block2, this.Block3);
        }
    
        public MetaClassSyntax WithKClass(__SyntaxToken kClass)
        {
            return this.Update(this.IsAbstract, kClass, this.Block1, this.Block2, this.Block3);
        }
    
        public MetaClassSyntax WithBlock1(MetaClassBlock1Syntax block1)
        {
            return this.Update(this.IsAbstract, this.KClass, block1, this.Block2, this.Block3);
        }
    
        public MetaClassSyntax WithBlock2(MetaClassBlock2Syntax block2)
        {
            return this.Update(this.IsAbstract, this.KClass, this.Block1, block2, this.Block3);
        }
    
        public MetaClassSyntax WithBlock3(MetaClassBlock3Syntax block3)
        {
            return this.Update(this.IsAbstract, this.KClass, this.Block1, this.Block2, block3);
        }
    
    
        public MetaClassSyntax Update(__SyntaxToken isAbstract, __SyntaxToken kClass, MetaClassBlock1Syntax block1, MetaClassBlock2Syntax block2, MetaClassBlock3Syntax block3)
        {
            if (this.IsAbstract != isAbstract || this.KClass != kClass || this.Block1 != block1 || this.Block2 != block2 || this.Block3 != block3)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaClass(isAbstract, kClass, block1, block2, block3);
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
    
    public sealed class MetaPropertySyntax : MetaSyntaxNode
    {
        private MetaPropertyBlock1Syntax _block1;
        private MetaTypeReferenceSyntax _type;
        private MetaPropertyBlock2Syntax _block2;
        private __SyntaxNode _block3;
    
        public MetaPropertySyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaPropertySyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public MetaPropertyBlock1Syntax Block1 
        { 
            get
            {
            var red = this.GetRed(ref this._block1, 0);
            return red;
            } 
        }
        public MetaTypeReferenceSyntax Type 
        { 
            get
            {
            var red = this.GetRed(ref this._type, 1);
            return red;
            } 
        }
        public MetaPropertyBlock2Syntax Block2 
        { 
            get
            {
            var red = this.GetRed(ref this._block2, 2);
            return red;
            } 
        }
        public global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock3Syntax> Block3 
        { 
            get
            {
            var red = this.GetRed(ref this._block3, 3);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock3Syntax>(red);
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
                case 0: return this.GetRed(ref this._block1, 0);
                case 1: return this.GetRed(ref this._type, 1);
                case 2: return this.GetRed(ref this._block2, 2);
                case 3: return this.GetRed(ref this._block3, 3);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._block1;
                case 1: return this._type;
                case 2: return this._block2;
                case 3: return this._block3;
                default: return null;
            }
        }
    
        public MetaPropertySyntax WithBlock1(MetaPropertyBlock1Syntax block1)
        {
            return this.Update(block1, this.Type, this.Block2, this.Block3, this.TSemicolon);
        }
    
        public MetaPropertySyntax WithType(MetaTypeReferenceSyntax type)
        {
            return this.Update(this.Block1, type, this.Block2, this.Block3, this.TSemicolon);
        }
    
        public MetaPropertySyntax WithBlock2(MetaPropertyBlock2Syntax block2)
        {
            return this.Update(this.Block1, this.Type, block2, this.Block3, this.TSemicolon);
        }
    
        public MetaPropertySyntax WithBlock3(global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock3Syntax> block3)
        {
            return this.Update(this.Block1, this.Type, this.Block2, block3, this.TSemicolon);
        }
    
        public MetaPropertySyntax AddBlock3(params MetaPropertyBlock3Syntax[] block3)
        {
            return this.WithBlock3(this.Block3.AddRange(block3));
        }
    
        public MetaPropertySyntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.Block1, this.Type, this.Block2, this.Block3, tSemicolon);
        }
    
    
        public MetaPropertySyntax Update(MetaPropertyBlock1Syntax block1, MetaTypeReferenceSyntax type, MetaPropertyBlock2Syntax block2, global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock3Syntax> block3, __SyntaxToken tSemicolon)
        {
            if (this.Block1 != block1 || this.Type != type || this.Block2 != block2 || this.Block3 != block3 || this.TSemicolon != tSemicolon)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaProperty(block1, type, block2, block3, tSemicolon);
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
    
    public sealed class MetaOperationSyntax : MetaSyntaxNode
    {
        private MetaTypeReferenceSyntax _returnType;
        private NameSyntax _name;
        private MetaOperationBlock1Syntax _block;
    
        public MetaOperationSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaOperationSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public MetaTypeReferenceSyntax ReturnType 
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
        public MetaOperationBlock1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 3);
            return red;
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
                case 3: return this.GetRed(ref this._block, 3);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._returnType;
                case 1: return this._name;
                case 3: return this._block;
                default: return null;
            }
        }
    
        public MetaOperationSyntax WithReturnType(MetaTypeReferenceSyntax returnType)
        {
            return this.Update(returnType, this.Name, this.TLParen, this.Block, this.TRParen, this.TSemicolon);
        }
    
        public MetaOperationSyntax WithName(NameSyntax name)
        {
            return this.Update(this.ReturnType, name, this.TLParen, this.Block, this.TRParen, this.TSemicolon);
        }
    
        public MetaOperationSyntax WithTLParen(__SyntaxToken tLParen)
        {
            return this.Update(this.ReturnType, this.Name, tLParen, this.Block, this.TRParen, this.TSemicolon);
        }
    
        public MetaOperationSyntax WithBlock(MetaOperationBlock1Syntax block)
        {
            return this.Update(this.ReturnType, this.Name, this.TLParen, block, this.TRParen, this.TSemicolon);
        }
    
        public MetaOperationSyntax WithTRParen(__SyntaxToken tRParen)
        {
            return this.Update(this.ReturnType, this.Name, this.TLParen, this.Block, tRParen, this.TSemicolon);
        }
    
        public MetaOperationSyntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.ReturnType, this.Name, this.TLParen, this.Block, this.TRParen, tSemicolon);
        }
    
    
        public MetaOperationSyntax Update(MetaTypeReferenceSyntax returnType, NameSyntax name, __SyntaxToken tLParen, MetaOperationBlock1Syntax block, __SyntaxToken tRParen, __SyntaxToken tSemicolon)
        {
            if (this.ReturnType != returnType || this.Name != name || this.TLParen != tLParen || this.Block != block || this.TRParen != tRParen || this.TSemicolon != tSemicolon)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaOperation(returnType, name, tLParen, block, tRParen, tSemicolon);
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
        private MetaTypeReferenceSyntax _type;
        private NameSyntax _name;
    
        public MetaParameterSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaParameterSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public MetaTypeReferenceSyntax Type 
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
    
        public MetaParameterSyntax WithType(MetaTypeReferenceSyntax type)
        {
            return this.Update(type, this.Name);
        }
    
        public MetaParameterSyntax WithName(NameSyntax name)
        {
            return this.Update(this.Type, name);
        }
    
    
        public MetaParameterSyntax Update(MetaTypeReferenceSyntax type, NameSyntax name)
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
    public abstract class MetaTypeReferenceSyntax : MetaSyntaxNode
    {
        protected MetaTypeReferenceSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected MetaTypeReferenceSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    
    public sealed class SimpleTypeReferenceSyntax : MetaTypeReferenceSyntax
    {
        private TypeReferenceSyntax _typeReference;
    
        public SimpleTypeReferenceSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeReferenceSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public TypeReferenceSyntax TypeReference 
        { 
            get
            {
            var red = this.GetRed(ref this._typeReference, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._typeReference, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._typeReference;
                default: return null;
            }
        }
    
        public SimpleTypeReferenceSyntax WithTypeReference(TypeReferenceSyntax typeReference)
        {
            return this.Update(typeReference);
        }
    
    
        public SimpleTypeReferenceSyntax Update(TypeReferenceSyntax typeReference)
        {
            if (this.TypeReference != typeReference)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.SimpleTypeReference(typeReference);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeReferenceSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeReference(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeReference(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeReference(this);
        }
    
    }
    public sealed class MetaArrayTypeSyntax : MetaTypeReferenceSyntax
    {
        private MetaTypeReferenceSyntax _itemType;
    
        public MetaArrayTypeSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaArrayTypeSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public MetaTypeReferenceSyntax ItemType 
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
    
        public MetaArrayTypeSyntax WithItemType(MetaTypeReferenceSyntax itemType)
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
    
    
        public MetaArrayTypeSyntax Update(MetaTypeReferenceSyntax itemType, __SyntaxToken tLBracket, __SyntaxToken tRBracket)
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
    public sealed class MetaNullableTypeSyntax : MetaTypeReferenceSyntax
    {
        private MetaTypeReferenceSyntax _innerType;
    
        public MetaNullableTypeSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaNullableTypeSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public MetaTypeReferenceSyntax InnerType 
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
    
        public MetaNullableTypeSyntax WithInnerType(MetaTypeReferenceSyntax innerType)
        {
            return this.Update(innerType, this.TQuestion);
        }
    
        public MetaNullableTypeSyntax WithTQuestion(__SyntaxToken tQuestion)
        {
            return this.Update(this.InnerType, tQuestion);
        }
    
    
        public MetaNullableTypeSyntax Update(MetaTypeReferenceSyntax innerType, __SyntaxToken tQuestion)
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
    
    public sealed class TypeReferenceAlt1Syntax : TypeReferenceSyntax
    {
        private PrimitiveTypeSyntax _primitiveType;
    
        public TypeReferenceAlt1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public TypeReferenceAlt1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public PrimitiveTypeSyntax PrimitiveType 
        { 
            get
            {
            var red = this.GetRed(ref this._primitiveType, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._primitiveType, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._primitiveType;
                default: return null;
            }
        }
    
        public TypeReferenceAlt1Syntax WithPrimitiveType(PrimitiveTypeSyntax primitiveType)
        {
            return this.Update(primitiveType);
        }
    
    
        public TypeReferenceAlt1Syntax Update(PrimitiveTypeSyntax primitiveType)
        {
            if (this.PrimitiveType != primitiveType)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.TypeReferenceAlt1(primitiveType);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (TypeReferenceAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitTypeReferenceAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitTypeReferenceAlt1(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitTypeReferenceAlt1(this);
        }
    
    }
    public sealed class TypeReferenceAlt2Syntax : TypeReferenceSyntax
    {
        private QualifierSyntax _qualifier;
    
        public TypeReferenceAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public TypeReferenceAlt2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
    
        public TypeReferenceAlt2Syntax WithQualifier(QualifierSyntax qualifier)
        {
            return this.Update(qualifier);
        }
    
    
        public TypeReferenceAlt2Syntax Update(QualifierSyntax qualifier)
        {
            if (this.Qualifier != qualifier)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.TypeReferenceAlt2(qualifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (TypeReferenceAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitTypeReferenceAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitTypeReferenceAlt2(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitTypeReferenceAlt2(this);
        }
    
    }
    
    public sealed class PrimitiveTypeSyntax : MetaSyntaxNode
    {
    
        public PrimitiveTypeSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PrimitiveTypeSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken Token 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.PrimitiveTypeGreen)this.Green;
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
    
        public PrimitiveTypeSyntax WithToken(__SyntaxToken token)
        {
            return this.Update(token);
        }
    
    
        public PrimitiveTypeSyntax Update(__SyntaxToken token)
        {
            if (this.Token != token)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.PrimitiveType(token);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PrimitiveTypeSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitPrimitiveType(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitPrimitiveType(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitPrimitiveType(this);
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
        private __SyntaxNode _identifier;
    
        public QualifierSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public QualifierSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> Identifier 
        { 
            get
            {
            var red = this.GetRed(ref this._identifier, 0);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax>(red, this.GetChildIndex(0), reversed: false);
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
    
        public QualifierSyntax WithIdentifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifier)
        {
            return this.Update(identifier);
        }
    
        public QualifierSyntax AddIdentifier(params IdentifierSyntax[] identifier)
        {
            return this.WithIdentifier(this.Identifier.AddRange(identifier));
        }
    
    
        public QualifierSyntax Update(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifier)
        {
            if (this.Identifier != identifier)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.Qualifier(identifier);
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
    
    public sealed class MainBlock1Syntax : MetaSyntaxNode
    {
        private MetaModelSyntax _declarations1;
        private __SyntaxNode _declarations2;
    
        public MainBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MainBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public MetaModelSyntax Declarations1 
        { 
            get
            {
            var red = this.GetRed(ref this._declarations1, 0);
            return red;
            } 
        }
        public global::MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> Declarations2 
        { 
            get
            {
            var red = this.GetRed(ref this._declarations2, 1);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax>(red);
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
    
        public MainBlock1Syntax WithDeclarations1(MetaModelSyntax declarations1)
        {
            return this.Update(declarations1, this.Declarations2);
        }
    
        public MainBlock1Syntax WithDeclarations2(global::MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> declarations2)
        {
            return this.Update(this.Declarations1, declarations2);
        }
    
        public MainBlock1Syntax AddDeclarations2(params MetaDeclarationSyntax[] declarations2)
        {
            return this.WithDeclarations2(this.Declarations2.AddRange(declarations2));
        }
    
    
        public MainBlock1Syntax Update(MetaModelSyntax declarations1, global::MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> declarations2)
        {
            if (this.Declarations1 != declarations1 || this.Declarations2 != declarations2)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MainBlock1(declarations1, declarations2);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MainBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMainBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMainBlock1(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMainBlock1(this);
        }
    
    }
    
    public sealed class MetaModelBlock1Syntax : MetaSyntaxNode
    {
    
        public MetaModelBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaModelBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KUri 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaModelBlock1Green)this.Green;
            var greenToken = green.KUri;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public __SyntaxToken Uri 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaModelBlock1Green)this.Green;
            var greenToken = green.Uri;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
            } 
        }
        public __SyntaxToken TSemicolon 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaModelBlock1Green)this.Green;
            var greenToken = green.TSemicolon;
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
    
        public MetaModelBlock1Syntax WithKUri(__SyntaxToken kUri)
        {
            return this.Update(kUri, this.Uri, this.TSemicolon);
        }
    
        public MetaModelBlock1Syntax WithUri(__SyntaxToken uri)
        {
            return this.Update(this.KUri, uri, this.TSemicolon);
        }
    
        public MetaModelBlock1Syntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.KUri, this.Uri, tSemicolon);
        }
    
    
        public MetaModelBlock1Syntax Update(__SyntaxToken kUri, __SyntaxToken uri, __SyntaxToken tSemicolon)
        {
            if (this.KUri != kUri || this.Uri != uri || this.TSemicolon != tSemicolon)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaModelBlock1(kUri, uri, tSemicolon);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaModelBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaModelBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaModelBlock1(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaModelBlock1(this);
        }
    
    }
    
    public sealed class MetaEnumBlock1Syntax : MetaSyntaxNode
    {
        private __SyntaxNode _literals;
    
        public MetaEnumBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaEnumBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TLBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaEnumBlock1Green)this.Green;
            var greenToken = green.TLBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> Literals 
        { 
            get
            {
            var red = this.GetRed(ref this._literals, 1);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax>(red, this.GetChildIndex(1), reversed: false);
            } 
        }
        public __SyntaxToken TRBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaEnumBlock1Green)this.Green;
            var greenToken = green.TRBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
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
    
        public MetaEnumBlock1Syntax WithTLBrace(__SyntaxToken tLBrace)
        {
            return this.Update(tLBrace, this.Literals, this.TRBrace);
        }
    
        public MetaEnumBlock1Syntax WithLiterals(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> literals)
        {
            return this.Update(this.TLBrace, literals, this.TRBrace);
        }
    
        public MetaEnumBlock1Syntax AddLiterals(params MetaEnumLiteralSyntax[] literals)
        {
            return this.WithLiterals(this.Literals.AddRange(literals));
        }
    
        public MetaEnumBlock1Syntax WithTRBrace(__SyntaxToken tRBrace)
        {
            return this.Update(this.TLBrace, this.Literals, tRBrace);
        }
    
    
        public MetaEnumBlock1Syntax Update(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> literals, __SyntaxToken tRBrace)
        {
            if (this.TLBrace != tLBrace || this.Literals != literals || this.TRBrace != tRBrace)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaEnumBlock1(tLBrace, literals, tRBrace);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaEnumBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaEnumBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaEnumBlock1(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaEnumBlock1(this);
        }
    
    }
    
    public sealed class MetaEnumBlock1literalsBlockSyntax : MetaSyntaxNode
    {
        private MetaEnumLiteralSyntax _literals;
    
        public MetaEnumBlock1literalsBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaEnumBlock1literalsBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaEnumBlock1literalsBlockGreen)this.Green;
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
    
        public MetaEnumBlock1literalsBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.Literals);
        }
    
        public MetaEnumBlock1literalsBlockSyntax WithLiterals(MetaEnumLiteralSyntax literals)
        {
            return this.Update(this.TComma, literals);
        }
    
    
        public MetaEnumBlock1literalsBlockSyntax Update(__SyntaxToken tComma, MetaEnumLiteralSyntax literals)
        {
            if (this.TComma != tComma || this.Literals != literals)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaEnumBlock1literalsBlock(tComma, literals);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaEnumBlock1literalsBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaEnumBlock1literalsBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaEnumBlock1literalsBlock(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaEnumBlock1literalsBlock(this);
        }
    
    }
    public abstract class MetaClassBlock1Syntax : MetaSyntaxNode
    {
        protected MetaClassBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected MetaClassBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    
    public sealed class MetaClassBlock1Alt1Syntax : MetaClassBlock1Syntax
    {
        private IdentifierSyntax _identifier;
        private IdentifierSyntax _symbolType;
    
        public MetaClassBlock1Alt1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaClassBlock1Alt1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaClassBlock1Alt1Green)this.Green;
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
    
        public MetaClassBlock1Alt1Syntax WithIdentifier(IdentifierSyntax identifier)
        {
            return this.Update(identifier, this.TDollar, this.SymbolType);
        }
    
        public MetaClassBlock1Alt1Syntax WithTDollar(__SyntaxToken tDollar)
        {
            return this.Update(this.Identifier, tDollar, this.SymbolType);
        }
    
        public MetaClassBlock1Alt1Syntax WithSymbolType(IdentifierSyntax symbolType)
        {
            return this.Update(this.Identifier, this.TDollar, symbolType);
        }
    
    
        public MetaClassBlock1Alt1Syntax Update(IdentifierSyntax identifier, __SyntaxToken tDollar, IdentifierSyntax symbolType)
        {
            if (this.Identifier != identifier || this.TDollar != tDollar || this.SymbolType != symbolType)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaClassBlock1Alt1(identifier, tDollar, symbolType);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaClassBlock1Alt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaClassBlock1Alt1(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaClassBlock1Alt1(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaClassBlock1Alt1(this);
        }
    
    }
    public sealed class MetaClassBlock1Alt2Syntax : MetaClassBlock1Syntax
    {
        private IdentifierSyntax _identifier;
    
        public MetaClassBlock1Alt2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaClassBlock1Alt2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
    
        public MetaClassBlock1Alt2Syntax WithIdentifier(IdentifierSyntax identifier)
        {
            return this.Update(identifier);
        }
    
    
        public MetaClassBlock1Alt2Syntax Update(IdentifierSyntax identifier)
        {
            if (this.Identifier != identifier)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaClassBlock1Alt2(identifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaClassBlock1Alt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaClassBlock1Alt2(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaClassBlock1Alt2(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaClassBlock1Alt2(this);
        }
    
    }
    
    public sealed class MetaClassBlock2Syntax : MetaSyntaxNode
    {
        private __SyntaxNode _baseTypes;
    
        public MetaClassBlock2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaClassBlock2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TColon 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaClassBlock2Green)this.Green;
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
    
        public MetaClassBlock2Syntax WithTColon(__SyntaxToken tColon)
        {
            return this.Update(tColon, this.BaseTypes);
        }
    
        public MetaClassBlock2Syntax WithBaseTypes(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> baseTypes)
        {
            return this.Update(this.TColon, baseTypes);
        }
    
        public MetaClassBlock2Syntax AddBaseTypes(params QualifierSyntax[] baseTypes)
        {
            return this.WithBaseTypes(this.BaseTypes.AddRange(baseTypes));
        }
    
    
        public MetaClassBlock2Syntax Update(__SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> baseTypes)
        {
            if (this.TColon != tColon || this.BaseTypes != baseTypes)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaClassBlock2(tColon, baseTypes);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaClassBlock2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaClassBlock2(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaClassBlock2(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaClassBlock2(this);
        }
    
    }
    
    public sealed class MetaClassBlock2baseTypesBlockSyntax : MetaSyntaxNode
    {
        private QualifierSyntax _baseTypes;
    
        public MetaClassBlock2baseTypesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaClassBlock2baseTypesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaClassBlock2baseTypesBlockGreen)this.Green;
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
    
        public MetaClassBlock2baseTypesBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.BaseTypes);
        }
    
        public MetaClassBlock2baseTypesBlockSyntax WithBaseTypes(QualifierSyntax baseTypes)
        {
            return this.Update(this.TComma, baseTypes);
        }
    
    
        public MetaClassBlock2baseTypesBlockSyntax Update(__SyntaxToken tComma, QualifierSyntax baseTypes)
        {
            if (this.TComma != tComma || this.BaseTypes != baseTypes)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaClassBlock2baseTypesBlock(tComma, baseTypes);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaClassBlock2baseTypesBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaClassBlock2baseTypesBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaClassBlock2baseTypesBlock(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaClassBlock2baseTypesBlock(this);
        }
    
    }
    
    public sealed class MetaClassBlock3Syntax : MetaSyntaxNode
    {
        private __SyntaxNode _block;
    
        public MetaClassBlock3Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaClassBlock3Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TLBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaClassBlock3Green)this.Green;
            var greenToken = green.TLBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SyntaxList<MetaClassBlock3Block1Syntax> Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 1);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<MetaClassBlock3Block1Syntax>(red);
            } 
        }
        public __SyntaxToken TRBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaClassBlock3Green)this.Green;
            var greenToken = green.TRBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._block, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._block;
                default: return null;
            }
        }
    
        public MetaClassBlock3Syntax WithTLBrace(__SyntaxToken tLBrace)
        {
            return this.Update(tLBrace, this.Block, this.TRBrace);
        }
    
        public MetaClassBlock3Syntax WithBlock(global::MetaDslx.CodeAnalysis.SyntaxList<MetaClassBlock3Block1Syntax> block)
        {
            return this.Update(this.TLBrace, block, this.TRBrace);
        }
    
        public MetaClassBlock3Syntax AddBlock(params MetaClassBlock3Block1Syntax[] block)
        {
            return this.WithBlock(this.Block.AddRange(block));
        }
    
        public MetaClassBlock3Syntax WithTRBrace(__SyntaxToken tRBrace)
        {
            return this.Update(this.TLBrace, this.Block, tRBrace);
        }
    
    
        public MetaClassBlock3Syntax Update(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SyntaxList<MetaClassBlock3Block1Syntax> block, __SyntaxToken tRBrace)
        {
            if (this.TLBrace != tLBrace || this.Block != block || this.TRBrace != tRBrace)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaClassBlock3(tLBrace, block, tRBrace);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaClassBlock3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaClassBlock3(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaClassBlock3(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaClassBlock3(this);
        }
    
    }
    public abstract class MetaClassBlock3Block1Syntax : MetaSyntaxNode
    {
        protected MetaClassBlock3Block1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected MetaClassBlock3Block1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    
    public sealed class MetaClassBlock3Block1Alt1Syntax : MetaClassBlock3Block1Syntax
    {
        private MetaPropertySyntax _properties;
    
        public MetaClassBlock3Block1Alt1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaClassBlock3Block1Alt1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
    
        public MetaClassBlock3Block1Alt1Syntax WithProperties(MetaPropertySyntax properties)
        {
            return this.Update(properties);
        }
    
    
        public MetaClassBlock3Block1Alt1Syntax Update(MetaPropertySyntax properties)
        {
            if (this.Properties != properties)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaClassBlock3Block1Alt1(properties);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaClassBlock3Block1Alt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaClassBlock3Block1Alt1(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaClassBlock3Block1Alt1(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaClassBlock3Block1Alt1(this);
        }
    
    }
    public sealed class MetaClassBlock3Block1Alt2Syntax : MetaClassBlock3Block1Syntax
    {
        private MetaOperationSyntax _operations;
    
        public MetaClassBlock3Block1Alt2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaClassBlock3Block1Alt2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
    
        public MetaClassBlock3Block1Alt2Syntax WithOperations(MetaOperationSyntax operations)
        {
            return this.Update(operations);
        }
    
    
        public MetaClassBlock3Block1Alt2Syntax Update(MetaOperationSyntax operations)
        {
            if (this.Operations != operations)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaClassBlock3Block1Alt2(operations);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaClassBlock3Block1Alt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaClassBlock3Block1Alt2(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaClassBlock3Block1Alt2(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaClassBlock3Block1Alt2(this);
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
    
    public sealed class MetaPropertyBlock1Alt1Syntax : MetaPropertyBlock1Syntax
    {
    
        public MetaPropertyBlock1Alt1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaPropertyBlock1Alt1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsContainment 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyBlock1Alt1Green)this.Green;
            var greenToken = green.IsContainment;
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
    
        public MetaPropertyBlock1Alt1Syntax WithIsContainment(__SyntaxToken isContainment)
        {
            return this.Update(isContainment);
        }
    
    
        public MetaPropertyBlock1Alt1Syntax Update(__SyntaxToken isContainment)
        {
            if (this.IsContainment != isContainment)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock1Alt1(isContainment);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaPropertyBlock1Alt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaPropertyBlock1Alt1(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaPropertyBlock1Alt1(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaPropertyBlock1Alt1(this);
        }
    
    }
    public sealed class MetaPropertyBlock1Alt2Syntax : MetaPropertyBlock1Syntax
    {
    
        public MetaPropertyBlock1Alt2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaPropertyBlock1Alt2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsDerived 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyBlock1Alt2Green)this.Green;
            var greenToken = green.IsDerived;
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
    
        public MetaPropertyBlock1Alt2Syntax WithIsDerived(__SyntaxToken isDerived)
        {
            return this.Update(isDerived);
        }
    
    
        public MetaPropertyBlock1Alt2Syntax Update(__SyntaxToken isDerived)
        {
            if (this.IsDerived != isDerived)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock1Alt2(isDerived);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaPropertyBlock1Alt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaPropertyBlock1Alt2(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaPropertyBlock1Alt2(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaPropertyBlock1Alt2(this);
        }
    
    }
    public abstract class MetaPropertyBlock2Syntax : MetaSyntaxNode
    {
        protected MetaPropertyBlock2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected MetaPropertyBlock2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    
    public sealed class MetaPropertyBlock2Alt1Syntax : MetaPropertyBlock2Syntax
    {
        private IdentifierSyntax _identifier;
        private IdentifierSyntax _symbolProperty;
    
        public MetaPropertyBlock2Alt1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaPropertyBlock2Alt1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyBlock2Alt1Green)this.Green;
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
    
        public MetaPropertyBlock2Alt1Syntax WithIdentifier(IdentifierSyntax identifier)
        {
            return this.Update(identifier, this.TDollar, this.SymbolProperty);
        }
    
        public MetaPropertyBlock2Alt1Syntax WithTDollar(__SyntaxToken tDollar)
        {
            return this.Update(this.Identifier, tDollar, this.SymbolProperty);
        }
    
        public MetaPropertyBlock2Alt1Syntax WithSymbolProperty(IdentifierSyntax symbolProperty)
        {
            return this.Update(this.Identifier, this.TDollar, symbolProperty);
        }
    
    
        public MetaPropertyBlock2Alt1Syntax Update(IdentifierSyntax identifier, __SyntaxToken tDollar, IdentifierSyntax symbolProperty)
        {
            if (this.Identifier != identifier || this.TDollar != tDollar || this.SymbolProperty != symbolProperty)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock2Alt1(identifier, tDollar, symbolProperty);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
        private IdentifierSyntax _identifier;
    
        public MetaPropertyBlock2Alt2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaPropertyBlock2Alt2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
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
    
        public MetaPropertyBlock2Alt2Syntax WithIdentifier(IdentifierSyntax identifier)
        {
            return this.Update(identifier);
        }
    
    
        public MetaPropertyBlock2Alt2Syntax Update(IdentifierSyntax identifier)
        {
            if (this.Identifier != identifier)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock2Alt2(identifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
    public abstract class MetaPropertyBlock3Syntax : MetaSyntaxNode
    {
        protected MetaPropertyBlock3Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected MetaPropertyBlock3Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    
    public sealed class MetaPropertyBlock3Alt1Syntax : MetaPropertyBlock3Syntax
    {
        private __SyntaxNode _oppositeProperties;
    
        public MetaPropertyBlock3Alt1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaPropertyBlock3Alt1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KOpposite 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyBlock3Alt1Green)this.Green;
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
    
        public MetaPropertyBlock3Alt1Syntax WithKOpposite(__SyntaxToken kOpposite)
        {
            return this.Update(kOpposite, this.OppositeProperties);
        }
    
        public MetaPropertyBlock3Alt1Syntax WithOppositeProperties(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> oppositeProperties)
        {
            return this.Update(this.KOpposite, oppositeProperties);
        }
    
        public MetaPropertyBlock3Alt1Syntax AddOppositeProperties(params QualifierSyntax[] oppositeProperties)
        {
            return this.WithOppositeProperties(this.OppositeProperties.AddRange(oppositeProperties));
        }
    
    
        public MetaPropertyBlock3Alt1Syntax Update(__SyntaxToken kOpposite, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> oppositeProperties)
        {
            if (this.KOpposite != kOpposite || this.OppositeProperties != oppositeProperties)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock3Alt1(kOpposite, oppositeProperties);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaPropertyBlock3Alt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaPropertyBlock3Alt1(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaPropertyBlock3Alt1(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaPropertyBlock3Alt1(this);
        }
    
    }
    public sealed class MetaPropertyBlock3Alt2Syntax : MetaPropertyBlock3Syntax
    {
        private __SyntaxNode _subsettedProperties;
    
        public MetaPropertyBlock3Alt2Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaPropertyBlock3Alt2Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KSubsets 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyBlock3Alt2Green)this.Green;
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
    
        public MetaPropertyBlock3Alt2Syntax WithKSubsets(__SyntaxToken kSubsets)
        {
            return this.Update(kSubsets, this.SubsettedProperties);
        }
    
        public MetaPropertyBlock3Alt2Syntax WithSubsettedProperties(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> subsettedProperties)
        {
            return this.Update(this.KSubsets, subsettedProperties);
        }
    
        public MetaPropertyBlock3Alt2Syntax AddSubsettedProperties(params QualifierSyntax[] subsettedProperties)
        {
            return this.WithSubsettedProperties(this.SubsettedProperties.AddRange(subsettedProperties));
        }
    
    
        public MetaPropertyBlock3Alt2Syntax Update(__SyntaxToken kSubsets, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> subsettedProperties)
        {
            if (this.KSubsets != kSubsets || this.SubsettedProperties != subsettedProperties)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock3Alt2(kSubsets, subsettedProperties);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaPropertyBlock3Alt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaPropertyBlock3Alt2(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaPropertyBlock3Alt2(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaPropertyBlock3Alt2(this);
        }
    
    }
    public sealed class MetaPropertyBlock3Alt3Syntax : MetaPropertyBlock3Syntax
    {
        private __SyntaxNode _redefinedProperties;
    
        public MetaPropertyBlock3Alt3Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaPropertyBlock3Alt3Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KRedefines 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyBlock3Alt3Green)this.Green;
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
    
        public MetaPropertyBlock3Alt3Syntax WithKRedefines(__SyntaxToken kRedefines)
        {
            return this.Update(kRedefines, this.RedefinedProperties);
        }
    
        public MetaPropertyBlock3Alt3Syntax WithRedefinedProperties(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> redefinedProperties)
        {
            return this.Update(this.KRedefines, redefinedProperties);
        }
    
        public MetaPropertyBlock3Alt3Syntax AddRedefinedProperties(params QualifierSyntax[] redefinedProperties)
        {
            return this.WithRedefinedProperties(this.RedefinedProperties.AddRange(redefinedProperties));
        }
    
    
        public MetaPropertyBlock3Alt3Syntax Update(__SyntaxToken kRedefines, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> redefinedProperties)
        {
            if (this.KRedefines != kRedefines || this.RedefinedProperties != redefinedProperties)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock3Alt3(kRedefines, redefinedProperties);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaPropertyBlock3Alt3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaPropertyBlock3Alt3(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaPropertyBlock3Alt3(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaPropertyBlock3Alt3(this);
        }
    
    }
    
    public sealed class MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax : MetaSyntaxNode
    {
        private QualifierSyntax _oppositeProperties;
    
        public MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyBlock3Alt1oppositePropertiesBlockGreen)this.Green;
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
    
        public MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.OppositeProperties);
        }
    
        public MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax WithOppositeProperties(QualifierSyntax oppositeProperties)
        {
            return this.Update(this.TComma, oppositeProperties);
        }
    
    
        public MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax Update(__SyntaxToken tComma, QualifierSyntax oppositeProperties)
        {
            if (this.TComma != tComma || this.OppositeProperties != oppositeProperties)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock3Alt1oppositePropertiesBlock(tComma, oppositeProperties);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaPropertyBlock3Alt1oppositePropertiesBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaPropertyBlock3Alt1oppositePropertiesBlock(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaPropertyBlock3Alt1oppositePropertiesBlock(this);
        }
    
    }
    
    public sealed class MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax : MetaSyntaxNode
    {
        private QualifierSyntax _subsettedProperties;
    
        public MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyBlock3Alt2subsettedPropertiesBlockGreen)this.Green;
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
    
        public MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.SubsettedProperties);
        }
    
        public MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax WithSubsettedProperties(QualifierSyntax subsettedProperties)
        {
            return this.Update(this.TComma, subsettedProperties);
        }
    
    
        public MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax Update(__SyntaxToken tComma, QualifierSyntax subsettedProperties)
        {
            if (this.TComma != tComma || this.SubsettedProperties != subsettedProperties)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock3Alt2subsettedPropertiesBlock(tComma, subsettedProperties);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaPropertyBlock3Alt2subsettedPropertiesBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaPropertyBlock3Alt2subsettedPropertiesBlock(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaPropertyBlock3Alt2subsettedPropertiesBlock(this);
        }
    
    }
    
    public sealed class MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax : MetaSyntaxNode
    {
        private QualifierSyntax _redefinedProperties;
    
        public MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaPropertyBlock3Alt3redefinedPropertiesBlockGreen)this.Green;
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
    
        public MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.RedefinedProperties);
        }
    
        public MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax WithRedefinedProperties(QualifierSyntax redefinedProperties)
        {
            return this.Update(this.TComma, redefinedProperties);
        }
    
    
        public MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax Update(__SyntaxToken tComma, QualifierSyntax redefinedProperties)
        {
            if (this.TComma != tComma || this.RedefinedProperties != redefinedProperties)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaPropertyBlock3Alt3redefinedPropertiesBlock(tComma, redefinedProperties);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaPropertyBlock3Alt3redefinedPropertiesBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaPropertyBlock3Alt3redefinedPropertiesBlock(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaPropertyBlock3Alt3redefinedPropertiesBlock(this);
        }
    
    }
    
    public sealed class MetaOperationBlock1Syntax : MetaSyntaxNode
    {
        private __SyntaxNode _parameters;
    
        public MetaOperationBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaOperationBlock1Syntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> Parameters 
        { 
            get
            {
            var red = this.GetRed(ref this._parameters, 0);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax>(red, this.GetChildIndex(0), reversed: false);
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._parameters, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._parameters;
                default: return null;
            }
        }
    
        public MetaOperationBlock1Syntax WithParameters(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> parameters)
        {
            return this.Update(parameters);
        }
    
        public MetaOperationBlock1Syntax AddParameters(params MetaParameterSyntax[] parameters)
        {
            return this.WithParameters(this.Parameters.AddRange(parameters));
        }
    
    
        public MetaOperationBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> parameters)
        {
            if (this.Parameters != parameters)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaOperationBlock1(parameters);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaOperationBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaOperationBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaOperationBlock1(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaOperationBlock1(this);
        }
    
    }
    
    public sealed class MetaOperationBlock1parametersBlockSyntax : MetaSyntaxNode
    {
        private MetaParameterSyntax _parameters;
    
        public MetaOperationBlock1parametersBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MetaOperationBlock1parametersBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.MetaOperationBlock1parametersBlockGreen)this.Green;
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
    
        public MetaOperationBlock1parametersBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.Parameters);
        }
    
        public MetaOperationBlock1parametersBlockSyntax WithParameters(MetaParameterSyntax parameters)
        {
            return this.Update(this.TComma, parameters);
        }
    
    
        public MetaOperationBlock1parametersBlockSyntax Update(__SyntaxToken tComma, MetaParameterSyntax parameters)
        {
            if (this.TComma != tComma || this.Parameters != parameters)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.MetaOperationBlock1parametersBlock(tComma, parameters);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MetaOperationBlock1parametersBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMetaOperationBlock1parametersBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMetaOperationBlock1parametersBlock(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitMetaOperationBlock1parametersBlock(this);
        }
    
    }
    
    public sealed class QualifierIdentifierBlockSyntax : MetaSyntaxNode
    {
        private IdentifierSyntax _identifier;
    
        public QualifierIdentifierBlockSyntax(__InternalSyntaxNode green, MetaSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public QualifierIdentifierBlockSyntax(__InternalSyntaxNode green, MetaSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TDot 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax.QualifierIdentifierBlockGreen)this.Green;
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
    
        public QualifierIdentifierBlockSyntax WithTDot(__SyntaxToken tDot)
        {
            return this.Update(tDot, this.Identifier);
        }
    
        public QualifierIdentifierBlockSyntax WithIdentifier(IdentifierSyntax identifier)
        {
            return this.Update(this.TDot, identifier);
        }
    
    
        public QualifierIdentifierBlockSyntax Update(__SyntaxToken tDot, IdentifierSyntax identifier)
        {
            if (this.TDot != tDot || this.Identifier != identifier)
            {
                var newNode = MetaLanguage.Instance.SyntaxFactory.QualifierIdentifierBlock(tDot, identifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (QualifierIdentifierBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(IMetaSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitQualifierIdentifierBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(IMetaSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitQualifierIdentifierBlock(this);
        }
    
        public override void Accept(IMetaSyntaxVisitor visitor)
        {
            visitor.VisitQualifierIdentifierBlock(this);
        }
    
    }
}
