#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler.Syntax
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

    public abstract class SymbolSyntaxNode : __SyntaxNode
    {
        protected SymbolSyntaxNode(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }

        protected SymbolSyntaxNode(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public override __Language Language => SymbolLanguage.Instance;
        public SymbolSyntaxKind Kind => (SymbolSyntaxKind)this.RawKind;
        internal new __GreenNode Green => base.Green;

        protected override __SyntaxTree CreateSyntaxTreeForRoot()
        {
            return SymbolSyntaxTree.CreateWithoutClone(this, __IncrementalParseData.Empty);
        }

        public override TResult Accept<TArg, TResult>(global::MetaDslx.CodeAnalysis.SyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            if (visitor is ISymbolSyntaxVisitor<TArg, TResult> typedVisitor) return this.Accept(typedVisitor, argument);
            else return visitor.DefaultVisit(this, argument);
        }

        public abstract TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument);

        public override TResult Accept<TResult>(global::MetaDslx.CodeAnalysis.SyntaxVisitor<TResult> visitor)
        {
            if (visitor is ISymbolSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor);

        public override void Accept(global::MetaDslx.CodeAnalysis.SyntaxVisitor visitor)
        {
            if (visitor is ISymbolSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }
        public abstract void Accept(ISymbolSyntaxVisitor visitor);
    }

    /// <summary>
    /// It's a non terminal Trivia SymbolSyntaxNode that has a tree underneath it.
    /// </summary>
    public abstract partial class SymbolStructuredTriviaSyntax : SymbolSyntaxNode, global::MetaDslx.CodeAnalysis.IStructuredTriviaSyntax
    {
        private __SyntaxTrivia _parent;
        internal SymbolStructuredTriviaSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent == null ? null : (SymbolSyntaxTree)parent.SyntaxTree, position)
        {
            System.Diagnostics.Debug.Assert(parent == null || position >= 0);
        }
        internal static SymbolStructuredTriviaSyntax Create(__SyntaxTrivia trivia)
        {
            var red = (SymbolStructuredTriviaSyntax)SymbolLanguage.Instance.SyntaxFactory.CreateStructure(trivia);
            red._parent = trivia;
            return red;
        }
        /// <summary>
        /// Get parent trivia.
        /// </summary>
        public override __SyntaxTrivia ParentTrivia => _parent;
    }

    public sealed partial class SymbolSkippedTokensTriviaSyntax : SymbolStructuredTriviaSyntax
    {
        internal SymbolSkippedTokensTriviaSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public __SyntaxTokenList Tokens 
        {
            get
            {
                var slot = ((global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.GreenSkippedTokensTriviaSyntax)this.Green).Tokens;
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

        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSkippedTokensTrivia(this, argument);
        }

        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSkippedTokensTrivia(this);
        }

        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitSkippedTokensTrivia(this);
        }

        public SymbolSkippedTokensTriviaSyntax Update(__SyntaxTokenList tokens)
        {
            if (tokens != this.Tokens)
            {
                var newNode = (SymbolSkippedTokensTriviaSyntax)Language.SyntaxFactory.SkippedTokensTrivia(tokens);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    return __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return newNode;
            }
            return this;
        }

        public SymbolSkippedTokensTriviaSyntax WithTokens(__SyntaxTokenList tokens)
        {
            return this.Update(tokens);
        }

        public SymbolSkippedTokensTriviaSyntax AddTokens(params __SyntaxToken[] items)
        {
            return this.WithTokens(this.Tokens.AddRange(items));
        }
    }

    public sealed class MainSyntax : SymbolSyntaxNode, global::MetaDslx.CodeAnalysis.ICompilationUnitSyntax
    {
        private QualifierSyntax _qualifier;
        private __SyntaxNode _usingList;
        private MainBlock1Syntax _block;
    
        public MainSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MainSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KNamespace 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
                var newNode = SymbolLanguage.Instance.SyntaxFactory.Main(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MainSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMain(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMain(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitMain(this);
        }
    
    }
    public sealed class UsingSyntax : SymbolSyntaxNode
    {
        private QualifierSyntax _namespaces;
    
        public UsingSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public UsingSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KUsing 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
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
                var newNode = SymbolLanguage.Instance.SyntaxFactory.Using(kUsing, namespaces, tSemicolon);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (UsingSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitUsing(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitUsing(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitUsing(this);
        }
    
    }
    public sealed class SymbolSyntax : SymbolSyntaxNode
    {
        private NameSyntax _name;
        private SymbolBlock1Syntax _block1;
        private SymbolBlock2Syntax _block2;
    
        public SymbolSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SymbolSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsAbstract 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.SymbolGreen)this.Green;
            var greenToken = green.IsAbstract;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public __SyntaxToken KSymbol 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.SymbolGreen)this.Green;
            var greenToken = green.KSymbol;
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
        public SymbolBlock1Syntax Block1 
        { 
            get
            {
            var red = this.GetRed(ref this._block1, 3);
            return red;
            } 
        }
        public SymbolBlock2Syntax Block2 
        { 
            get
            {
            var red = this.GetRed(ref this._block2, 4);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 2: return this.GetRed(ref this._name, 2);
                case 3: return this.GetRed(ref this._block1, 3);
                case 4: return this.GetRed(ref this._block2, 4);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 2: return this._name;
                case 3: return this._block1;
                case 4: return this._block2;
                default: return null;
            }
        }
    
        public SymbolSyntax WithIsAbstract(__SyntaxToken isAbstract)
        {
            return this.Update(isAbstract, this.KSymbol, this.Name, this.Block1, this.Block2);
        }
    
        public SymbolSyntax WithKSymbol(__SyntaxToken kSymbol)
        {
            return this.Update(this.IsAbstract, kSymbol, this.Name, this.Block1, this.Block2);
        }
    
        public SymbolSyntax WithName(NameSyntax name)
        {
            return this.Update(this.IsAbstract, this.KSymbol, name, this.Block1, this.Block2);
        }
    
        public SymbolSyntax WithBlock1(SymbolBlock1Syntax block1)
        {
            return this.Update(this.IsAbstract, this.KSymbol, this.Name, block1, this.Block2);
        }
    
        public SymbolSyntax WithBlock2(SymbolBlock2Syntax block2)
        {
            return this.Update(this.IsAbstract, this.KSymbol, this.Name, this.Block1, block2);
        }
    
    
        public SymbolSyntax Update(__SyntaxToken isAbstract, __SyntaxToken kSymbol, NameSyntax name, SymbolBlock1Syntax block1, SymbolBlock2Syntax block2)
        {
            if (this.IsAbstract != isAbstract || this.KSymbol != kSymbol || this.Name != name || this.Block1 != block1 || this.Block2 != block2)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.Symbol(isAbstract, kSymbol, name, block1, block2);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SymbolSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSymbol(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSymbol(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitSymbol(this);
        }
    
    }
    public sealed class PropertySyntax : SymbolSyntaxNode
    {
        private PropertyBlock1Syntax _block1;
        private TypeReferenceSyntax _type;
        private NameSyntax _name;
        private PropertyBlock2Syntax _block2;
        private PropertyBlock3Syntax _block3;
    
        public PropertySyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PropertySyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public PropertyBlock1Syntax Block1 
        { 
            get
            {
            var red = this.GetRed(ref this._block1, 0);
            return red;
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
        public PropertyBlock2Syntax Block2 
        { 
            get
            {
            var red = this.GetRed(ref this._block2, 3);
            return red;
            } 
        }
        public PropertyBlock3Syntax Block3 
        { 
            get
            {
            var red = this.GetRed(ref this._block3, 4);
            return red;
            } 
        }
        public __SyntaxToken TSemicolon 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.PropertyGreen)this.Green;
            var greenToken = green.TSemicolon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._block1, 0);
                case 1: return this.GetRed(ref this._type, 1);
                case 2: return this.GetRed(ref this._name, 2);
                case 3: return this.GetRed(ref this._block2, 3);
                case 4: return this.GetRed(ref this._block3, 4);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._block1;
                case 1: return this._type;
                case 2: return this._name;
                case 3: return this._block2;
                case 4: return this._block3;
                default: return null;
            }
        }
    
        public PropertySyntax WithBlock1(PropertyBlock1Syntax block1)
        {
            return this.Update(block1, this.Type, this.Name, this.Block2, this.Block3, this.TSemicolon);
        }
    
        public PropertySyntax WithType(TypeReferenceSyntax type)
        {
            return this.Update(this.Block1, type, this.Name, this.Block2, this.Block3, this.TSemicolon);
        }
    
        public PropertySyntax WithName(NameSyntax name)
        {
            return this.Update(this.Block1, this.Type, name, this.Block2, this.Block3, this.TSemicolon);
        }
    
        public PropertySyntax WithBlock2(PropertyBlock2Syntax block2)
        {
            return this.Update(this.Block1, this.Type, this.Name, block2, this.Block3, this.TSemicolon);
        }
    
        public PropertySyntax WithBlock3(PropertyBlock3Syntax block3)
        {
            return this.Update(this.Block1, this.Type, this.Name, this.Block2, block3, this.TSemicolon);
        }
    
        public PropertySyntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.Block1, this.Type, this.Name, this.Block2, this.Block3, tSemicolon);
        }
    
    
        public PropertySyntax Update(PropertyBlock1Syntax block1, TypeReferenceSyntax type, NameSyntax name, PropertyBlock2Syntax block2, PropertyBlock3Syntax block3, __SyntaxToken tSemicolon)
        {
            if (this.Block1 != block1 || this.Type != type || this.Name != name || this.Block2 != block2 || this.Block3 != block3 || this.TSemicolon != tSemicolon)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.Property(block1, type, name, block2, block3, tSemicolon);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PropertySyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitProperty(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitProperty(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitProperty(this);
        }
    
    }
    public abstract class OperationSyntax : SymbolSyntaxNode
    {
        protected OperationSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected OperationSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    public sealed class OperationAlt1Syntax : OperationSyntax
    {
        private NameSyntax _name;
    
        public OperationAlt1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OperationAlt1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsPhase 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.OperationAlt1Green)this.Green;
            var greenToken = green.IsPhase;
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
        public __SyntaxToken TLParen 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.OperationAlt1Green)this.Green;
            var greenToken = green.TLParen;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
            } 
        }
        public __SyntaxToken TRParen 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.OperationAlt1Green)this.Green;
            var greenToken = green.TRParen;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
            } 
        }
        public __SyntaxToken TSemicolon 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.OperationAlt1Green)this.Green;
            var greenToken = green.TSemicolon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
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
    
        public OperationAlt1Syntax WithIsPhase(__SyntaxToken isPhase)
        {
            return this.Update(isPhase, this.Name, this.TLParen, this.TRParen, this.TSemicolon);
        }
    
        public OperationAlt1Syntax WithName(NameSyntax name)
        {
            return this.Update(this.IsPhase, name, this.TLParen, this.TRParen, this.TSemicolon);
        }
    
        public OperationAlt1Syntax WithTLParen(__SyntaxToken tLParen)
        {
            return this.Update(this.IsPhase, this.Name, tLParen, this.TRParen, this.TSemicolon);
        }
    
        public OperationAlt1Syntax WithTRParen(__SyntaxToken tRParen)
        {
            return this.Update(this.IsPhase, this.Name, this.TLParen, tRParen, this.TSemicolon);
        }
    
        public OperationAlt1Syntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.IsPhase, this.Name, this.TLParen, this.TRParen, tSemicolon);
        }
    
    
        public OperationAlt1Syntax Update(__SyntaxToken isPhase, NameSyntax name, __SyntaxToken tLParen, __SyntaxToken tRParen, __SyntaxToken tSemicolon)
        {
            if (this.IsPhase != isPhase || this.Name != name || this.TLParen != tLParen || this.TRParen != tRParen || this.TSemicolon != tSemicolon)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.OperationAlt1(isPhase, name, tLParen, tRParen, tSemicolon);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OperationAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOperationAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOperationAlt1(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitOperationAlt1(this);
        }
    
    }
    public sealed class OperationAlt2Syntax : OperationSyntax
    {
        private TypeReferenceSyntax _returnType;
        private NameSyntax _name;
        private OperationAlt2Block1Syntax _block1;
        private OperationAlt2Block2Syntax _block2;
    
        public OperationAlt2Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OperationAlt2Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsCached 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.OperationAlt2Green)this.Green;
            var greenToken = green.IsCached;
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
        public NameSyntax Name 
        { 
            get
            {
            var red = this.GetRed(ref this._name, 2);
            return red;
            } 
        }
        public __SyntaxToken TLParen 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.OperationAlt2Green)this.Green;
            var greenToken = green.TLParen;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
            } 
        }
        public OperationAlt2Block1Syntax Block1 
        { 
            get
            {
            var red = this.GetRed(ref this._block1, 4);
            return red;
            } 
        }
        public __SyntaxToken TRParen 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.OperationAlt2Green)this.Green;
            var greenToken = green.TRParen;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
            } 
        }
        public OperationAlt2Block2Syntax Block2 
        { 
            get
            {
            var red = this.GetRed(ref this._block2, 6);
            return red;
            } 
        }
        public __SyntaxToken TSemicolon 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.OperationAlt2Green)this.Green;
            var greenToken = green.TSemicolon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(7), this.GetChildIndex(7));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._returnType, 1);
                case 2: return this.GetRed(ref this._name, 2);
                case 4: return this.GetRed(ref this._block1, 4);
                case 6: return this.GetRed(ref this._block2, 6);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._returnType;
                case 2: return this._name;
                case 4: return this._block1;
                case 6: return this._block2;
                default: return null;
            }
        }
    
        public OperationAlt2Syntax WithIsCached(__SyntaxToken isCached)
        {
            return this.Update(isCached, this.ReturnType, this.Name, this.TLParen, this.Block1, this.TRParen, this.Block2, this.TSemicolon);
        }
    
        public OperationAlt2Syntax WithReturnType(TypeReferenceSyntax returnType)
        {
            return this.Update(this.IsCached, returnType, this.Name, this.TLParen, this.Block1, this.TRParen, this.Block2, this.TSemicolon);
        }
    
        public OperationAlt2Syntax WithName(NameSyntax name)
        {
            return this.Update(this.IsCached, this.ReturnType, name, this.TLParen, this.Block1, this.TRParen, this.Block2, this.TSemicolon);
        }
    
        public OperationAlt2Syntax WithTLParen(__SyntaxToken tLParen)
        {
            return this.Update(this.IsCached, this.ReturnType, this.Name, tLParen, this.Block1, this.TRParen, this.Block2, this.TSemicolon);
        }
    
        public OperationAlt2Syntax WithBlock1(OperationAlt2Block1Syntax block1)
        {
            return this.Update(this.IsCached, this.ReturnType, this.Name, this.TLParen, block1, this.TRParen, this.Block2, this.TSemicolon);
        }
    
        public OperationAlt2Syntax WithTRParen(__SyntaxToken tRParen)
        {
            return this.Update(this.IsCached, this.ReturnType, this.Name, this.TLParen, this.Block1, tRParen, this.Block2, this.TSemicolon);
        }
    
        public OperationAlt2Syntax WithBlock2(OperationAlt2Block2Syntax block2)
        {
            return this.Update(this.IsCached, this.ReturnType, this.Name, this.TLParen, this.Block1, this.TRParen, block2, this.TSemicolon);
        }
    
        public OperationAlt2Syntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.IsCached, this.ReturnType, this.Name, this.TLParen, this.Block1, this.TRParen, this.Block2, tSemicolon);
        }
    
    
        public OperationAlt2Syntax Update(__SyntaxToken isCached, TypeReferenceSyntax returnType, NameSyntax name, __SyntaxToken tLParen, OperationAlt2Block1Syntax block1, __SyntaxToken tRParen, OperationAlt2Block2Syntax block2, __SyntaxToken tSemicolon)
        {
            if (this.IsCached != isCached || this.ReturnType != returnType || this.Name != name || this.TLParen != tLParen || this.Block1 != block1 || this.TRParen != tRParen || this.Block2 != block2 || this.TSemicolon != tSemicolon)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.OperationAlt2(isCached, returnType, name, tLParen, block1, tRParen, block2, tSemicolon);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OperationAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOperationAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOperationAlt2(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitOperationAlt2(this);
        }
    
    }
    public sealed class ParameterSyntax : SymbolSyntaxNode
    {
        private TypeReferenceSyntax _type;
        private NameSyntax _name;
    
        public ParameterSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ParameterSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
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
    
        public ParameterSyntax WithType(TypeReferenceSyntax type)
        {
            return this.Update(type, this.Name);
        }
    
        public ParameterSyntax WithName(NameSyntax name)
        {
            return this.Update(this.Type, name);
        }
    
    
        public ParameterSyntax Update(TypeReferenceSyntax type, NameSyntax name)
        {
            if (this.Type != type || this.Name != name)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.Parameter(type, name);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ParameterSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitParameter(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitParameter(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitParameter(this);
        }
    
    }
    public sealed class TypeReferenceSyntax : SymbolSyntaxNode
    {
        private SimpleTypeReferenceSyntax _type;
        private TypeReferenceBlock1Syntax _block;
        private ArrayDimensionsSyntax _dimensions;
    
        public TypeReferenceSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public TypeReferenceSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public SimpleTypeReferenceSyntax Type 
        { 
            get
            {
            var red = this.GetRed(ref this._type, 0);
            return red;
            } 
        }
        public TypeReferenceBlock1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 1);
            return red;
            } 
        }
        public ArrayDimensionsSyntax Dimensions 
        { 
            get
            {
            var red = this.GetRed(ref this._dimensions, 2);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._type, 0);
                case 1: return this.GetRed(ref this._block, 1);
                case 2: return this.GetRed(ref this._dimensions, 2);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._type;
                case 1: return this._block;
                case 2: return this._dimensions;
                default: return null;
            }
        }
    
        public TypeReferenceSyntax WithType(SimpleTypeReferenceSyntax type)
        {
            return this.Update(type, this.Block, this.Dimensions);
        }
    
        public TypeReferenceSyntax WithBlock(TypeReferenceBlock1Syntax block)
        {
            return this.Update(this.Type, block, this.Dimensions);
        }
    
        public TypeReferenceSyntax WithDimensions(ArrayDimensionsSyntax dimensions)
        {
            return this.Update(this.Type, this.Block, dimensions);
        }
    
    
        public TypeReferenceSyntax Update(SimpleTypeReferenceSyntax type, TypeReferenceBlock1Syntax block, ArrayDimensionsSyntax dimensions)
        {
            if (this.Type != type || this.Block != block || this.Dimensions != dimensions)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.TypeReference(type, block, dimensions);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (TypeReferenceSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitTypeReference(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitTypeReference(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitTypeReference(this);
        }
    
    }
    public sealed class ArrayDimensionsSyntax : SymbolSyntaxNode
    {
        private __SyntaxNode _block;
    
        public ArrayDimensionsSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ArrayDimensionsSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public global::MetaDslx.CodeAnalysis.SyntaxList<ArrayDimensionsBlock1Syntax> Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 0);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<ArrayDimensionsBlock1Syntax>(red);
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._block, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._block;
                default: return null;
            }
        }
    
        public ArrayDimensionsSyntax WithBlock(global::MetaDslx.CodeAnalysis.SyntaxList<ArrayDimensionsBlock1Syntax> block)
        {
            return this.Update(block);
        }
    
        public ArrayDimensionsSyntax AddBlock(params ArrayDimensionsBlock1Syntax[] block)
        {
            return this.WithBlock(this.Block.AddRange(block));
        }
    
    
        public ArrayDimensionsSyntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ArrayDimensionsBlock1Syntax> block)
        {
            if (this.Block != block)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.ArrayDimensions(block);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ArrayDimensionsSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitArrayDimensions(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitArrayDimensions(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitArrayDimensions(this);
        }
    
    }
    public abstract class SimpleTypeReferenceSyntax : SymbolSyntaxNode
    {
        protected SimpleTypeReferenceSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected SimpleTypeReferenceSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    public sealed class SimpleTypeReferenceAlt1Syntax : SimpleTypeReferenceSyntax
    {
        private PrimitiveTypeSyntax _primitiveType;
    
        public SimpleTypeReferenceAlt1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeReferenceAlt1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
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
    
        public SimpleTypeReferenceAlt1Syntax WithPrimitiveType(PrimitiveTypeSyntax primitiveType)
        {
            return this.Update(primitiveType);
        }
    
    
        public SimpleTypeReferenceAlt1Syntax Update(PrimitiveTypeSyntax primitiveType)
        {
            if (this.PrimitiveType != primitiveType)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.SimpleTypeReferenceAlt1(primitiveType);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeReferenceAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeReferenceAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeReferenceAlt1(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeReferenceAlt1(this);
        }
    
    }
    public sealed class SimpleTypeReferenceAlt2Syntax : SimpleTypeReferenceSyntax
    {
        private QualifierSyntax _qualifier;
    
        public SimpleTypeReferenceAlt2Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeReferenceAlt2Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
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
                var newNode = SymbolLanguage.Instance.SyntaxFactory.SimpleTypeReferenceAlt2(qualifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeReferenceAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeReferenceAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeReferenceAlt2(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeReferenceAlt2(this);
        }
    
    }
    public sealed class PrimitiveTypeSyntax : SymbolSyntaxNode
    {
    
        public PrimitiveTypeSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PrimitiveTypeSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken Token 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.PrimitiveTypeGreen)this.Green;
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
                var newNode = SymbolLanguage.Instance.SyntaxFactory.PrimitiveType(token);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PrimitiveTypeSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitPrimitiveType(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitPrimitiveType(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitPrimitiveType(this);
        }
    
    }
    public abstract class ValueSyntax : SymbolSyntaxNode
    {
        protected ValueSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected ValueSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    public sealed class ValueAlt1Syntax : ValueSyntax
    {
    
        public ValueAlt1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ValueAlt1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TString 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.ValueAlt1Green)this.Green;
            var greenToken = green.TString;
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
    
        public ValueAlt1Syntax WithTString(__SyntaxToken tString)
        {
            return this.Update(tString);
        }
    
    
        public ValueAlt1Syntax Update(__SyntaxToken tString)
        {
            if (this.TString != tString)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.ValueAlt1(tString);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ValueAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitValueAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitValueAlt1(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitValueAlt1(this);
        }
    
    }
    public sealed class ValueAlt2Syntax : ValueSyntax
    {
    
        public ValueAlt2Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ValueAlt2Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TInteger 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.ValueAlt2Green)this.Green;
            var greenToken = green.TInteger;
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
    
        public ValueAlt2Syntax WithTInteger(__SyntaxToken tInteger)
        {
            return this.Update(tInteger);
        }
    
    
        public ValueAlt2Syntax Update(__SyntaxToken tInteger)
        {
            if (this.TInteger != tInteger)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.ValueAlt2(tInteger);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ValueAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitValueAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitValueAlt2(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitValueAlt2(this);
        }
    
    }
    public sealed class ValueAlt3Syntax : ValueSyntax
    {
    
        public ValueAlt3Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ValueAlt3Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TDecimal 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.ValueAlt3Green)this.Green;
            var greenToken = green.TDecimal;
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
    
        public ValueAlt3Syntax WithTDecimal(__SyntaxToken tDecimal)
        {
            return this.Update(tDecimal);
        }
    
    
        public ValueAlt3Syntax Update(__SyntaxToken tDecimal)
        {
            if (this.TDecimal != tDecimal)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.ValueAlt3(tDecimal);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ValueAlt3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitValueAlt3(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitValueAlt3(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitValueAlt3(this);
        }
    
    }
    public sealed class ValueAlt4Syntax : ValueSyntax
    {
        private TBooleanSyntax _tBoolean;
    
        public ValueAlt4Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ValueAlt4Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public TBooleanSyntax TBoolean 
        { 
            get
            {
            var red = this.GetRed(ref this._tBoolean, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._tBoolean, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._tBoolean;
                default: return null;
            }
        }
    
        public ValueAlt4Syntax WithTBoolean(TBooleanSyntax tBoolean)
        {
            return this.Update(tBoolean);
        }
    
    
        public ValueAlt4Syntax Update(TBooleanSyntax tBoolean)
        {
            if (this.TBoolean != tBoolean)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.ValueAlt4(tBoolean);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ValueAlt4Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitValueAlt4(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitValueAlt4(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitValueAlt4(this);
        }
    
    }
    public sealed class ValueAlt5Syntax : ValueSyntax
    {
    
        public ValueAlt5Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ValueAlt5Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KNull 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.ValueAlt5Green)this.Green;
            var greenToken = green.KNull;
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
    
        public ValueAlt5Syntax WithKNull(__SyntaxToken kNull)
        {
            return this.Update(kNull);
        }
    
    
        public ValueAlt5Syntax Update(__SyntaxToken kNull)
        {
            if (this.KNull != kNull)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.ValueAlt5(kNull);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ValueAlt5Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitValueAlt5(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitValueAlt5(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitValueAlt5(this);
        }
    
    }
    public sealed class ValueAlt6Syntax : ValueSyntax
    {
        private QualifierSyntax _qualifier;
    
        public ValueAlt6Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ValueAlt6Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
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
    
        public ValueAlt6Syntax WithQualifier(QualifierSyntax qualifier)
        {
            return this.Update(qualifier);
        }
    
    
        public ValueAlt6Syntax Update(QualifierSyntax qualifier)
        {
            if (this.Qualifier != qualifier)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.ValueAlt6(qualifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ValueAlt6Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitValueAlt6(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitValueAlt6(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitValueAlt6(this);
        }
    
    }
    public sealed class NameSyntax : SymbolSyntaxNode
    {
        private IdentifierSyntax _identifier;
    
        public NameSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public NameSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
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
                var newNode = SymbolLanguage.Instance.SyntaxFactory.Name(identifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (NameSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitName(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitName(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitName(this);
        }
    
    }
    public sealed class QualifierSyntax : SymbolSyntaxNode
    {
        private __SyntaxNode _identifier;
    
        public QualifierSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public QualifierSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
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
                var newNode = SymbolLanguage.Instance.SyntaxFactory.Qualifier(identifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (QualifierSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitQualifier(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitQualifier(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitQualifier(this);
        }
    
    }
    public sealed class IdentifierSyntax : SymbolSyntaxNode
    {
    
        public IdentifierSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public IdentifierSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken Token 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.IdentifierGreen)this.Green;
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
                var newNode = SymbolLanguage.Instance.SyntaxFactory.Identifier(token);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (IdentifierSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitIdentifier(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitIdentifier(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitIdentifier(this);
        }
    
    }
    public sealed class TBooleanSyntax : SymbolSyntaxNode
    {
    
        public TBooleanSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public TBooleanSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken Token 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.TBooleanGreen)this.Green;
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
    
        public TBooleanSyntax WithToken(__SyntaxToken token)
        {
            return this.Update(token);
        }
    
    
        public TBooleanSyntax Update(__SyntaxToken token)
        {
            if (this.Token != token)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.TBoolean(token);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (TBooleanSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitTBoolean(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitTBoolean(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitTBoolean(this);
        }
    
    }
    public sealed class MainBlock1Syntax : SymbolSyntaxNode
    {
        private __SyntaxNode _symbolList;
    
        public MainBlock1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MainBlock1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public global::MetaDslx.CodeAnalysis.SyntaxList<SymbolSyntax> SymbolList 
        { 
            get
            {
            var red = this.GetRed(ref this._symbolList, 0);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<SymbolSyntax>(red);
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._symbolList, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._symbolList;
                default: return null;
            }
        }
    
        public MainBlock1Syntax WithSymbolList(global::MetaDslx.CodeAnalysis.SyntaxList<SymbolSyntax> symbolList)
        {
            return this.Update(symbolList);
        }
    
        public MainBlock1Syntax AddSymbolList(params SymbolSyntax[] symbolList)
        {
            return this.WithSymbolList(this.SymbolList.AddRange(symbolList));
        }
    
    
        public MainBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<SymbolSyntax> symbolList)
        {
            if (this.SymbolList != symbolList)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.MainBlock1(symbolList);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MainBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMainBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMainBlock1(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitMainBlock1(this);
        }
    
    }
    public sealed class SymbolBlock1Syntax : SymbolSyntaxNode
    {
        private QualifierSyntax _baseTypes;
    
        public SymbolBlock1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SymbolBlock1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TColon 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.SymbolBlock1Green)this.Green;
            var greenToken = green.TColon;
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
    
        public SymbolBlock1Syntax WithTColon(__SyntaxToken tColon)
        {
            return this.Update(tColon, this.BaseTypes);
        }
    
        public SymbolBlock1Syntax WithBaseTypes(QualifierSyntax baseTypes)
        {
            return this.Update(this.TColon, baseTypes);
        }
    
    
        public SymbolBlock1Syntax Update(__SyntaxToken tColon, QualifierSyntax baseTypes)
        {
            if (this.TColon != tColon || this.BaseTypes != baseTypes)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.SymbolBlock1(tColon, baseTypes);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SymbolBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSymbolBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSymbolBlock1(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitSymbolBlock1(this);
        }
    
    }
    public sealed class SymbolBlock2Syntax : SymbolSyntaxNode
    {
        private __SyntaxNode _block;
    
        public SymbolBlock2Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SymbolBlock2Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TLBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.SymbolBlock2Green)this.Green;
            var greenToken = green.TLBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SyntaxList<SymbolBlock2Block1Syntax> Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 1);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<SymbolBlock2Block1Syntax>(red);
            } 
        }
        public __SyntaxToken TRBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.SymbolBlock2Green)this.Green;
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
    
        public SymbolBlock2Syntax WithTLBrace(__SyntaxToken tLBrace)
        {
            return this.Update(tLBrace, this.Block, this.TRBrace);
        }
    
        public SymbolBlock2Syntax WithBlock(global::MetaDslx.CodeAnalysis.SyntaxList<SymbolBlock2Block1Syntax> block)
        {
            return this.Update(this.TLBrace, block, this.TRBrace);
        }
    
        public SymbolBlock2Syntax AddBlock(params SymbolBlock2Block1Syntax[] block)
        {
            return this.WithBlock(this.Block.AddRange(block));
        }
    
        public SymbolBlock2Syntax WithTRBrace(__SyntaxToken tRBrace)
        {
            return this.Update(this.TLBrace, this.Block, tRBrace);
        }
    
    
        public SymbolBlock2Syntax Update(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SyntaxList<SymbolBlock2Block1Syntax> block, __SyntaxToken tRBrace)
        {
            if (this.TLBrace != tLBrace || this.Block != block || this.TRBrace != tRBrace)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.SymbolBlock2(tLBrace, block, tRBrace);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SymbolBlock2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSymbolBlock2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSymbolBlock2(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitSymbolBlock2(this);
        }
    
    }
    public abstract class SymbolBlock2Block1Syntax : SymbolSyntaxNode
    {
        protected SymbolBlock2Block1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected SymbolBlock2Block1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    public sealed class SymbolBlock2Block1Alt1Syntax : SymbolBlock2Block1Syntax
    {
        private PropertySyntax _properties;
    
        public SymbolBlock2Block1Alt1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SymbolBlock2Block1Alt1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public PropertySyntax Properties 
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
    
        public SymbolBlock2Block1Alt1Syntax WithProperties(PropertySyntax properties)
        {
            return this.Update(properties);
        }
    
    
        public SymbolBlock2Block1Alt1Syntax Update(PropertySyntax properties)
        {
            if (this.Properties != properties)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.SymbolBlock2Block1Alt1(properties);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SymbolBlock2Block1Alt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSymbolBlock2Block1Alt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSymbolBlock2Block1Alt1(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitSymbolBlock2Block1Alt1(this);
        }
    
    }
    public sealed class SymbolBlock2Block1Alt2Syntax : SymbolBlock2Block1Syntax
    {
        private OperationSyntax _operations;
    
        public SymbolBlock2Block1Alt2Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SymbolBlock2Block1Alt2Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public OperationSyntax Operations 
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
    
        public SymbolBlock2Block1Alt2Syntax WithOperations(OperationSyntax operations)
        {
            return this.Update(operations);
        }
    
    
        public SymbolBlock2Block1Alt2Syntax Update(OperationSyntax operations)
        {
            if (this.Operations != operations)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.SymbolBlock2Block1Alt2(operations);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SymbolBlock2Block1Alt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSymbolBlock2Block1Alt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSymbolBlock2Block1Alt2(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitSymbolBlock2Block1Alt2(this);
        }
    
    }
    public abstract class PropertyBlock1Syntax : SymbolSyntaxNode
    {
        protected PropertyBlock1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected PropertyBlock1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    public sealed class PropertyBlock1Alt1Syntax : PropertyBlock1Syntax
    {
        private PropertyBlock1Alt1Block1Syntax _block;
    
        public PropertyBlock1Alt1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PropertyBlock1Alt1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsPlain 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.PropertyBlock1Alt1Green)this.Green;
            var greenToken = green.IsPlain;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public PropertyBlock1Alt1Block1Syntax Block 
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
    
        public PropertyBlock1Alt1Syntax WithIsPlain(__SyntaxToken isPlain)
        {
            return this.Update(isPlain, this.Block);
        }
    
        public PropertyBlock1Alt1Syntax WithBlock(PropertyBlock1Alt1Block1Syntax block)
        {
            return this.Update(this.IsPlain, block);
        }
    
    
        public PropertyBlock1Alt1Syntax Update(__SyntaxToken isPlain, PropertyBlock1Alt1Block1Syntax block)
        {
            if (this.IsPlain != isPlain || this.Block != block)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.PropertyBlock1Alt1(isPlain, block);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PropertyBlock1Alt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitPropertyBlock1Alt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitPropertyBlock1Alt1(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitPropertyBlock1Alt1(this);
        }
    
    }
    public sealed class PropertyBlock1Alt2Syntax : PropertyBlock1Syntax
    {
    
        public PropertyBlock1Alt2Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PropertyBlock1Alt2Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsDerived 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.PropertyBlock1Alt2Green)this.Green;
            var greenToken = green.IsDerived;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public __SyntaxToken IsCached 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.PropertyBlock1Alt2Green)this.Green;
            var greenToken = green.IsCached;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
            } 
        }
        public __SyntaxToken IsWeak 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.PropertyBlock1Alt2Green)this.Green;
            var greenToken = green.IsWeak;
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
    
        public PropertyBlock1Alt2Syntax WithIsDerived(__SyntaxToken isDerived)
        {
            return this.Update(isDerived, this.IsCached, this.IsWeak);
        }
    
        public PropertyBlock1Alt2Syntax WithIsCached(__SyntaxToken isCached)
        {
            return this.Update(this.IsDerived, isCached, this.IsWeak);
        }
    
        public PropertyBlock1Alt2Syntax WithIsWeak(__SyntaxToken isWeak)
        {
            return this.Update(this.IsDerived, this.IsCached, isWeak);
        }
    
    
        public PropertyBlock1Alt2Syntax Update(__SyntaxToken isDerived, __SyntaxToken isCached, __SyntaxToken isWeak)
        {
            if (this.IsDerived != isDerived || this.IsCached != isCached || this.IsWeak != isWeak)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.PropertyBlock1Alt2(isDerived, isCached, isWeak);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PropertyBlock1Alt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitPropertyBlock1Alt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitPropertyBlock1Alt2(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitPropertyBlock1Alt2(this);
        }
    
    }
    public sealed class PropertyBlock1Alt3Syntax : PropertyBlock1Syntax
    {
    
        public PropertyBlock1Alt3Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PropertyBlock1Alt3Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsWeak 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.PropertyBlock1Alt3Green)this.Green;
            var greenToken = green.IsWeak;
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
    
        public PropertyBlock1Alt3Syntax WithIsWeak(__SyntaxToken isWeak)
        {
            return this.Update(isWeak);
        }
    
    
        public PropertyBlock1Alt3Syntax Update(__SyntaxToken isWeak)
        {
            if (this.IsWeak != isWeak)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.PropertyBlock1Alt3(isWeak);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PropertyBlock1Alt3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitPropertyBlock1Alt3(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitPropertyBlock1Alt3(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitPropertyBlock1Alt3(this);
        }
    
    }
    public abstract class PropertyBlock1Alt1Block1Syntax : SymbolSyntaxNode
    {
        protected PropertyBlock1Alt1Block1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected PropertyBlock1Alt1Block1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    public sealed class PropertyBlock1Alt1Block1Alt1Syntax : PropertyBlock1Alt1Block1Syntax
    {
    
        public PropertyBlock1Alt1Block1Alt1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PropertyBlock1Alt1Block1Alt1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsAbstract 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.PropertyBlock1Alt1Block1Alt1Green)this.Green;
            var greenToken = green.IsAbstract;
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
    
        public PropertyBlock1Alt1Block1Alt1Syntax WithIsAbstract(__SyntaxToken isAbstract)
        {
            return this.Update(isAbstract);
        }
    
    
        public PropertyBlock1Alt1Block1Alt1Syntax Update(__SyntaxToken isAbstract)
        {
            if (this.IsAbstract != isAbstract)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.PropertyBlock1Alt1Block1Alt1(isAbstract);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PropertyBlock1Alt1Block1Alt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitPropertyBlock1Alt1Block1Alt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitPropertyBlock1Alt1Block1Alt1(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitPropertyBlock1Alt1Block1Alt1(this);
        }
    
    }
    public sealed class PropertyBlock1Alt1Block1Alt2Syntax : PropertyBlock1Alt1Block1Syntax
    {
    
        public PropertyBlock1Alt1Block1Alt2Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PropertyBlock1Alt1Block1Alt2Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsWeak 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.PropertyBlock1Alt1Block1Alt2Green)this.Green;
            var greenToken = green.IsWeak;
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
    
        public PropertyBlock1Alt1Block1Alt2Syntax WithIsWeak(__SyntaxToken isWeak)
        {
            return this.Update(isWeak);
        }
    
    
        public PropertyBlock1Alt1Block1Alt2Syntax Update(__SyntaxToken isWeak)
        {
            if (this.IsWeak != isWeak)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.PropertyBlock1Alt1Block1Alt2(isWeak);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PropertyBlock1Alt1Block1Alt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitPropertyBlock1Alt1Block1Alt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitPropertyBlock1Alt1Block1Alt2(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitPropertyBlock1Alt1Block1Alt2(this);
        }
    
    }
    public sealed class PropertyBlock2Syntax : SymbolSyntaxNode
    {
        private ValueSyntax _defaultValue;
    
        public PropertyBlock2Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PropertyBlock2Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TEq 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.PropertyBlock2Green)this.Green;
            var greenToken = green.TEq;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public ValueSyntax DefaultValue 
        { 
            get
            {
            var red = this.GetRed(ref this._defaultValue, 1);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._defaultValue, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._defaultValue;
                default: return null;
            }
        }
    
        public PropertyBlock2Syntax WithTEq(__SyntaxToken tEq)
        {
            return this.Update(tEq, this.DefaultValue);
        }
    
        public PropertyBlock2Syntax WithDefaultValue(ValueSyntax defaultValue)
        {
            return this.Update(this.TEq, defaultValue);
        }
    
    
        public PropertyBlock2Syntax Update(__SyntaxToken tEq, ValueSyntax defaultValue)
        {
            if (this.TEq != tEq || this.DefaultValue != defaultValue)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.PropertyBlock2(tEq, defaultValue);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PropertyBlock2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitPropertyBlock2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitPropertyBlock2(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitPropertyBlock2(this);
        }
    
    }
    public sealed class PropertyBlock3Syntax : SymbolSyntaxNode
    {
        private IdentifierSyntax _phase;
    
        public PropertyBlock3Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PropertyBlock3Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KPhase 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.PropertyBlock3Green)this.Green;
            var greenToken = green.KPhase;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public IdentifierSyntax Phase 
        { 
            get
            {
            var red = this.GetRed(ref this._phase, 1);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._phase, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._phase;
                default: return null;
            }
        }
    
        public PropertyBlock3Syntax WithKPhase(__SyntaxToken kPhase)
        {
            return this.Update(kPhase, this.Phase);
        }
    
        public PropertyBlock3Syntax WithPhase(IdentifierSyntax phase)
        {
            return this.Update(this.KPhase, phase);
        }
    
    
        public PropertyBlock3Syntax Update(__SyntaxToken kPhase, IdentifierSyntax phase)
        {
            if (this.KPhase != kPhase || this.Phase != phase)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.PropertyBlock3(kPhase, phase);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PropertyBlock3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitPropertyBlock3(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitPropertyBlock3(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitPropertyBlock3(this);
        }
    
    }
    public sealed class OperationAlt2Block1Syntax : SymbolSyntaxNode
    {
        private __SyntaxNode _parameters;
    
        public OperationAlt2Block1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OperationAlt2Block1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> Parameters 
        { 
            get
            {
            var red = this.GetRed(ref this._parameters, 0);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax>(red, this.GetChildIndex(0), reversed: false);
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
    
        public OperationAlt2Block1Syntax WithParameters(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> parameters)
        {
            return this.Update(parameters);
        }
    
        public OperationAlt2Block1Syntax AddParameters(params ParameterSyntax[] parameters)
        {
            return this.WithParameters(this.Parameters.AddRange(parameters));
        }
    
    
        public OperationAlt2Block1Syntax Update(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> parameters)
        {
            if (this.Parameters != parameters)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.OperationAlt2Block1(parameters);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OperationAlt2Block1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOperationAlt2Block1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOperationAlt2Block1(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitOperationAlt2Block1(this);
        }
    
    }
    public sealed class OperationAlt2Block1parametersBlockSyntax : SymbolSyntaxNode
    {
        private ParameterSyntax _parameters;
    
        public OperationAlt2Block1parametersBlockSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OperationAlt2Block1parametersBlockSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.OperationAlt2Block1parametersBlockGreen)this.Green;
            var greenToken = green.TComma;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public ParameterSyntax Parameters 
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
    
        public OperationAlt2Block1parametersBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.Parameters);
        }
    
        public OperationAlt2Block1parametersBlockSyntax WithParameters(ParameterSyntax parameters)
        {
            return this.Update(this.TComma, parameters);
        }
    
    
        public OperationAlt2Block1parametersBlockSyntax Update(__SyntaxToken tComma, ParameterSyntax parameters)
        {
            if (this.TComma != tComma || this.Parameters != parameters)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.OperationAlt2Block1parametersBlock(tComma, parameters);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OperationAlt2Block1parametersBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOperationAlt2Block1parametersBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOperationAlt2Block1parametersBlock(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitOperationAlt2Block1parametersBlock(this);
        }
    
    }
    public sealed class OperationAlt2Block2Syntax : SymbolSyntaxNode
    {
    
        public OperationAlt2Block2Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OperationAlt2Block2Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KIf 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.OperationAlt2Block2Green)this.Green;
            var greenToken = green.KIf;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public __SyntaxToken CacheCondition 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.OperationAlt2Block2Green)this.Green;
            var greenToken = green.CacheCondition;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
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
    
        public OperationAlt2Block2Syntax WithKIf(__SyntaxToken kIf)
        {
            return this.Update(kIf, this.CacheCondition);
        }
    
        public OperationAlt2Block2Syntax WithCacheCondition(__SyntaxToken cacheCondition)
        {
            return this.Update(this.KIf, cacheCondition);
        }
    
    
        public OperationAlt2Block2Syntax Update(__SyntaxToken kIf, __SyntaxToken cacheCondition)
        {
            if (this.KIf != kIf || this.CacheCondition != cacheCondition)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.OperationAlt2Block2(kIf, cacheCondition);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OperationAlt2Block2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOperationAlt2Block2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOperationAlt2Block2(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitOperationAlt2Block2(this);
        }
    
    }
    public sealed class TypeReferenceBlock1Syntax : SymbolSyntaxNode
    {
    
        public TypeReferenceBlock1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public TypeReferenceBlock1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsNullable 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.TypeReferenceBlock1Green)this.Green;
            var greenToken = green.IsNullable;
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
    
        public TypeReferenceBlock1Syntax WithIsNullable(__SyntaxToken isNullable)
        {
            return this.Update(isNullable);
        }
    
    
        public TypeReferenceBlock1Syntax Update(__SyntaxToken isNullable)
        {
            if (this.IsNullable != isNullable)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.TypeReferenceBlock1(isNullable);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (TypeReferenceBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitTypeReferenceBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitTypeReferenceBlock1(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitTypeReferenceBlock1(this);
        }
    
    }
    public sealed class ArrayDimensionsBlock1Syntax : SymbolSyntaxNode
    {
    
        public ArrayDimensionsBlock1Syntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ArrayDimensionsBlock1Syntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TLBracket 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.ArrayDimensionsBlock1Green)this.Green;
            var greenToken = green.TLBracket;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public __SyntaxToken TRBracket 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.ArrayDimensionsBlock1Green)this.Green;
            var greenToken = green.TRBracket;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
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
    
        public ArrayDimensionsBlock1Syntax WithTLBracket(__SyntaxToken tLBracket)
        {
            return this.Update(tLBracket, this.TRBracket);
        }
    
        public ArrayDimensionsBlock1Syntax WithTRBracket(__SyntaxToken tRBracket)
        {
            return this.Update(this.TLBracket, tRBracket);
        }
    
    
        public ArrayDimensionsBlock1Syntax Update(__SyntaxToken tLBracket, __SyntaxToken tRBracket)
        {
            if (this.TLBracket != tLBracket || this.TRBracket != tRBracket)
            {
                var newNode = SymbolLanguage.Instance.SyntaxFactory.ArrayDimensionsBlock1(tLBracket, tRBracket);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ArrayDimensionsBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitArrayDimensionsBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitArrayDimensionsBlock1(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitArrayDimensionsBlock1(this);
        }
    
    }
    public sealed class QualifierIdentifierBlockSyntax : SymbolSyntaxNode
    {
        private IdentifierSyntax _identifier;
    
        public QualifierIdentifierBlockSyntax(__InternalSyntaxNode green, SymbolSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public QualifierIdentifierBlockSyntax(__InternalSyntaxNode green, SymbolSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TDot 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax.QualifierIdentifierBlockGreen)this.Green;
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
                var newNode = SymbolLanguage.Instance.SyntaxFactory.QualifierIdentifierBlock(tDot, identifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (QualifierIdentifierBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISymbolSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitQualifierIdentifierBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ISymbolSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitQualifierIdentifierBlock(this);
        }
    
        public override void Accept(ISymbolSyntaxVisitor visitor)
        {
            visitor.VisitQualifierIdentifierBlock(this);
        }
    
    }
}
