#nullable enable

namespace MetaDslx.Examples.Soal.Compiler.Syntax
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

    public abstract class SoalSyntaxNode : __SyntaxNode
    {
        protected SoalSyntaxNode(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }

        protected SoalSyntaxNode(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public override __Language Language => SoalLanguage.Instance;
        public SoalSyntaxKind Kind => (SoalSyntaxKind)this.RawKind;
        internal new __GreenNode Green => base.Green;

        protected override __SyntaxTree CreateSyntaxTreeForRoot()
        {
            return SoalSyntaxTree.CreateWithoutClone(this, __IncrementalParseData.Empty);
        }

        public override TResult Accept<TArg, TResult>(global::MetaDslx.CodeAnalysis.SyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            if (visitor is ISoalSyntaxVisitor<TArg, TResult> typedVisitor) return this.Accept(typedVisitor, argument);
            else return visitor.DefaultVisit(this, argument);
        }

        public abstract TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument);

        public override TResult Accept<TResult>(global::MetaDslx.CodeAnalysis.SyntaxVisitor<TResult> visitor)
        {
            if (visitor is ISoalSyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor);

        public override void Accept(global::MetaDslx.CodeAnalysis.SyntaxVisitor visitor)
        {
            if (visitor is ISoalSyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }
        public abstract void Accept(ISoalSyntaxVisitor visitor);
    }

    /// <summary>
    /// It's a non terminal Trivia SoalSyntaxNode that has a tree underneath it.
    /// </summary>
    public abstract partial class SoalStructuredTriviaSyntax : SoalSyntaxNode, global::MetaDslx.CodeAnalysis.IStructuredTriviaSyntax
    {
        private __SyntaxTrivia _parent;
        internal SoalStructuredTriviaSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent == null ? null : (SoalSyntaxTree)parent.SyntaxTree, position)
        {
            System.Diagnostics.Debug.Assert(parent == null || position >= 0);
        }
        internal static SoalStructuredTriviaSyntax Create(__SyntaxTrivia trivia)
        {
            var red = (SoalStructuredTriviaSyntax)SoalLanguage.Instance.SyntaxFactory.CreateStructure(trivia);
            red._parent = trivia;
            return red;
        }
        /// <summary>
        /// Get parent trivia.
        /// </summary>
        public override __SyntaxTrivia ParentTrivia => _parent;
    }

    public sealed partial class SoalSkippedTokensTriviaSyntax : SoalStructuredTriviaSyntax
    {
        internal SoalSkippedTokensTriviaSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public __SyntaxTokenList Tokens 
        {
            get
            {
                var slot = ((global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.GreenSkippedTokensTriviaSyntax)this.Green).Tokens;
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

        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSkippedTokensTrivia(this, argument);
        }

        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSkippedTokensTrivia(this);
        }

        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSkippedTokensTrivia(this);
        }

        public SoalSkippedTokensTriviaSyntax Update(__SyntaxTokenList tokens)
        {
            if (tokens != this.Tokens)
            {
                var newNode = (SoalSkippedTokensTriviaSyntax)Language.SyntaxFactory.SkippedTokensTrivia(tokens);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    return __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return newNode;
            }
            return this;
        }

        public SoalSkippedTokensTriviaSyntax WithTokens(__SyntaxTokenList tokens)
        {
            return this.Update(tokens);
        }

        public SoalSkippedTokensTriviaSyntax AddTokens(params __SyntaxToken[] items)
        {
            return this.WithTokens(this.Tokens.AddRange(items));
        }
    }

    public sealed class MainSyntax : SoalSyntaxNode, global::MetaDslx.CodeAnalysis.ICompilationUnitSyntax
    {
        private QualifierSyntax _qualifier;
        private __SyntaxNode _usingList;
        private MainBlock1Syntax _block;
    
        public MainSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MainSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KNamespace 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
                var newNode = SoalLanguage.Instance.SyntaxFactory.Main(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MainSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMain(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMain(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitMain(this);
        }
    
    }
    public sealed class UsingSyntax : SoalSyntaxNode
    {
        private QualifierSyntax _namespaces;
    
        public UsingSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public UsingSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KUsing 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
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
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.UsingGreen)this.Green;
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
                var newNode = SoalLanguage.Instance.SyntaxFactory.Using(kUsing, namespaces, tSemicolon);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (UsingSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitUsing(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitUsing(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitUsing(this);
        }
    
    }
    public abstract class DeclarationSyntax : SoalSyntaxNode
    {
        protected DeclarationSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected DeclarationSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    public sealed class DeclarationAlt1Syntax : DeclarationSyntax
    {
        private EnumTypeSyntax _enumType;
    
        public DeclarationAlt1Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public DeclarationAlt1Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public EnumTypeSyntax EnumType 
        { 
            get
            {
            var red = this.GetRed(ref this._enumType, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._enumType, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._enumType;
                default: return null;
            }
        }
    
        public DeclarationAlt1Syntax WithEnumType(EnumTypeSyntax enumType)
        {
            return this.Update(enumType);
        }
    
    
        public DeclarationAlt1Syntax Update(EnumTypeSyntax enumType)
        {
            if (this.EnumType != enumType)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.DeclarationAlt1(enumType);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (DeclarationAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitDeclarationAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitDeclarationAlt1(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitDeclarationAlt1(this);
        }
    
    }
    public sealed class DeclarationAlt2Syntax : DeclarationSyntax
    {
        private StructTypeSyntax _structType;
    
        public DeclarationAlt2Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public DeclarationAlt2Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public StructTypeSyntax StructType 
        { 
            get
            {
            var red = this.GetRed(ref this._structType, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._structType, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._structType;
                default: return null;
            }
        }
    
        public DeclarationAlt2Syntax WithStructType(StructTypeSyntax structType)
        {
            return this.Update(structType);
        }
    
    
        public DeclarationAlt2Syntax Update(StructTypeSyntax structType)
        {
            if (this.StructType != structType)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.DeclarationAlt2(structType);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (DeclarationAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitDeclarationAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitDeclarationAlt2(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitDeclarationAlt2(this);
        }
    
    }
    public sealed class DeclarationAlt3Syntax : DeclarationSyntax
    {
        private InterfaceSyntax _interface;
    
        public DeclarationAlt3Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public DeclarationAlt3Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public InterfaceSyntax Interface 
        { 
            get
            {
            var red = this.GetRed(ref this._interface, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._interface, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._interface;
                default: return null;
            }
        }
    
        public DeclarationAlt3Syntax WithInterface(InterfaceSyntax @interface)
        {
            return this.Update(@interface);
        }
    
    
        public DeclarationAlt3Syntax Update(InterfaceSyntax @interface)
        {
            if (this.Interface != @interface)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.DeclarationAlt3(@interface);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (DeclarationAlt3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitDeclarationAlt3(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitDeclarationAlt3(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitDeclarationAlt3(this);
        }
    
    }
    public sealed class DeclarationAlt4Syntax : DeclarationSyntax
    {
        private ServiceSyntax _service;
    
        public DeclarationAlt4Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public DeclarationAlt4Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public ServiceSyntax Service 
        { 
            get
            {
            var red = this.GetRed(ref this._service, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._service, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._service;
                default: return null;
            }
        }
    
        public DeclarationAlt4Syntax WithService(ServiceSyntax service)
        {
            return this.Update(service);
        }
    
    
        public DeclarationAlt4Syntax Update(ServiceSyntax service)
        {
            if (this.Service != service)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.DeclarationAlt4(service);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (DeclarationAlt4Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitDeclarationAlt4(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitDeclarationAlt4(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitDeclarationAlt4(this);
        }
    
    }
    public sealed class EnumTypeSyntax : SoalSyntaxNode
    {
        private NameSyntax _name;
        private EnumTypeBlock1Syntax _block;
    
        public EnumTypeSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public EnumTypeSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KEnum 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.EnumTypeGreen)this.Green;
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
        public __SyntaxToken TLBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.EnumTypeGreen)this.Green;
            var greenToken = green.TLBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
            } 
        }
        public EnumTypeBlock1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 3);
            return red;
            } 
        }
        public __SyntaxToken TRBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.EnumTypeGreen)this.Green;
            var greenToken = green.TRBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
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
    
        public EnumTypeSyntax WithKEnum(__SyntaxToken kEnum)
        {
            return this.Update(kEnum, this.Name, this.TLBrace, this.Block, this.TRBrace);
        }
    
        public EnumTypeSyntax WithName(NameSyntax name)
        {
            return this.Update(this.KEnum, name, this.TLBrace, this.Block, this.TRBrace);
        }
    
        public EnumTypeSyntax WithTLBrace(__SyntaxToken tLBrace)
        {
            return this.Update(this.KEnum, this.Name, tLBrace, this.Block, this.TRBrace);
        }
    
        public EnumTypeSyntax WithBlock(EnumTypeBlock1Syntax block)
        {
            return this.Update(this.KEnum, this.Name, this.TLBrace, block, this.TRBrace);
        }
    
        public EnumTypeSyntax WithTRBrace(__SyntaxToken tRBrace)
        {
            return this.Update(this.KEnum, this.Name, this.TLBrace, this.Block, tRBrace);
        }
    
    
        public EnumTypeSyntax Update(__SyntaxToken kEnum, NameSyntax name, __SyntaxToken tLBrace, EnumTypeBlock1Syntax block, __SyntaxToken tRBrace)
        {
            if (this.KEnum != kEnum || this.Name != name || this.TLBrace != tLBrace || this.Block != block || this.TRBrace != tRBrace)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.EnumType(kEnum, name, tLBrace, block, tRBrace);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (EnumTypeSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitEnumType(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitEnumType(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitEnumType(this);
        }
    
    }
    public sealed class EnumLiteralSyntax : SoalSyntaxNode
    {
        private NameSyntax _name;
    
        public EnumLiteralSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public EnumLiteralSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
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
    
        public EnumLiteralSyntax WithName(NameSyntax name)
        {
            return this.Update(name);
        }
    
    
        public EnumLiteralSyntax Update(NameSyntax name)
        {
            if (this.Name != name)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.EnumLiteral(name);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (EnumLiteralSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitEnumLiteral(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitEnumLiteral(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitEnumLiteral(this);
        }
    
    }
    public sealed class StructTypeSyntax : SoalSyntaxNode
    {
        private NameSyntax _name;
        private StructTypeBlock1Syntax _block;
        private __SyntaxNode _fields;
    
        public StructTypeSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public StructTypeSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KStruct 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.StructTypeGreen)this.Green;
            var greenToken = green.KStruct;
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
        public StructTypeBlock1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 2);
            return red;
            } 
        }
        public __SyntaxToken TLBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.StructTypeGreen)this.Green;
            var greenToken = green.TLBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SyntaxList<PropertySyntax> Fields 
        { 
            get
            {
            var red = this.GetRed(ref this._fields, 4);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<PropertySyntax>(red);
            } 
        }
        public __SyntaxToken TRBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.StructTypeGreen)this.Green;
            var greenToken = green.TRBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._name, 1);
                case 2: return this.GetRed(ref this._block, 2);
                case 4: return this.GetRed(ref this._fields, 4);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._name;
                case 2: return this._block;
                case 4: return this._fields;
                default: return null;
            }
        }
    
        public StructTypeSyntax WithKStruct(__SyntaxToken kStruct)
        {
            return this.Update(kStruct, this.Name, this.Block, this.TLBrace, this.Fields, this.TRBrace);
        }
    
        public StructTypeSyntax WithName(NameSyntax name)
        {
            return this.Update(this.KStruct, name, this.Block, this.TLBrace, this.Fields, this.TRBrace);
        }
    
        public StructTypeSyntax WithBlock(StructTypeBlock1Syntax block)
        {
            return this.Update(this.KStruct, this.Name, block, this.TLBrace, this.Fields, this.TRBrace);
        }
    
        public StructTypeSyntax WithTLBrace(__SyntaxToken tLBrace)
        {
            return this.Update(this.KStruct, this.Name, this.Block, tLBrace, this.Fields, this.TRBrace);
        }
    
        public StructTypeSyntax WithFields(global::MetaDslx.CodeAnalysis.SyntaxList<PropertySyntax> fields)
        {
            return this.Update(this.KStruct, this.Name, this.Block, this.TLBrace, fields, this.TRBrace);
        }
    
        public StructTypeSyntax AddFields(params PropertySyntax[] fields)
        {
            return this.WithFields(this.Fields.AddRange(fields));
        }
    
        public StructTypeSyntax WithTRBrace(__SyntaxToken tRBrace)
        {
            return this.Update(this.KStruct, this.Name, this.Block, this.TLBrace, this.Fields, tRBrace);
        }
    
    
        public StructTypeSyntax Update(__SyntaxToken kStruct, NameSyntax name, StructTypeBlock1Syntax block, __SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SyntaxList<PropertySyntax> fields, __SyntaxToken tRBrace)
        {
            if (this.KStruct != kStruct || this.Name != name || this.Block != block || this.TLBrace != tLBrace || this.Fields != fields || this.TRBrace != tRBrace)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.StructType(kStruct, name, block, tLBrace, fields, tRBrace);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (StructTypeSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitStructType(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitStructType(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitStructType(this);
        }
    
    }
    public sealed class PropertySyntax : SoalSyntaxNode
    {
        private TypeReferenceSyntax _type;
        private NameSyntax _name;
    
        public PropertySyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PropertySyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
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
        public __SyntaxToken TSemicolon 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.PropertyGreen)this.Green;
            var greenToken = green.TSemicolon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
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
    
        public PropertySyntax WithType(TypeReferenceSyntax type)
        {
            return this.Update(type, this.Name, this.TSemicolon);
        }
    
        public PropertySyntax WithName(NameSyntax name)
        {
            return this.Update(this.Type, name, this.TSemicolon);
        }
    
        public PropertySyntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.Type, this.Name, tSemicolon);
        }
    
    
        public PropertySyntax Update(TypeReferenceSyntax type, NameSyntax name, __SyntaxToken tSemicolon)
        {
            if (this.Type != type || this.Name != name || this.TSemicolon != tSemicolon)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.Property(type, name, tSemicolon);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PropertySyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitProperty(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitProperty(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitProperty(this);
        }
    
    }
    public sealed class InterfaceSyntax : SoalSyntaxNode
    {
        private NameSyntax _name;
        private __SyntaxNode _resources;
        private __SyntaxNode _operations;
    
        public InterfaceSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public InterfaceSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KInterface 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.InterfaceGreen)this.Green;
            var greenToken = green.KInterface;
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
        public __SyntaxToken TLBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.InterfaceGreen)this.Green;
            var greenToken = green.TLBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SyntaxList<ResourceSyntax> Resources 
        { 
            get
            {
            var red = this.GetRed(ref this._resources, 3);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<ResourceSyntax>(red);
            } 
        }
        public global::MetaDslx.CodeAnalysis.SyntaxList<OperationSyntax> Operations 
        { 
            get
            {
            var red = this.GetRed(ref this._operations, 4);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<OperationSyntax>(red);
            } 
        }
        public __SyntaxToken TRBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.InterfaceGreen)this.Green;
            var greenToken = green.TRBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._name, 1);
                case 3: return this.GetRed(ref this._resources, 3);
                case 4: return this.GetRed(ref this._operations, 4);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._name;
                case 3: return this._resources;
                case 4: return this._operations;
                default: return null;
            }
        }
    
        public InterfaceSyntax WithKInterface(__SyntaxToken kInterface)
        {
            return this.Update(kInterface, this.Name, this.TLBrace, this.Resources, this.Operations, this.TRBrace);
        }
    
        public InterfaceSyntax WithName(NameSyntax name)
        {
            return this.Update(this.KInterface, name, this.TLBrace, this.Resources, this.Operations, this.TRBrace);
        }
    
        public InterfaceSyntax WithTLBrace(__SyntaxToken tLBrace)
        {
            return this.Update(this.KInterface, this.Name, tLBrace, this.Resources, this.Operations, this.TRBrace);
        }
    
        public InterfaceSyntax WithResources(global::MetaDslx.CodeAnalysis.SyntaxList<ResourceSyntax> resources)
        {
            return this.Update(this.KInterface, this.Name, this.TLBrace, resources, this.Operations, this.TRBrace);
        }
    
        public InterfaceSyntax AddResources(params ResourceSyntax[] resources)
        {
            return this.WithResources(this.Resources.AddRange(resources));
        }
    
        public InterfaceSyntax WithOperations(global::MetaDslx.CodeAnalysis.SyntaxList<OperationSyntax> operations)
        {
            return this.Update(this.KInterface, this.Name, this.TLBrace, this.Resources, operations, this.TRBrace);
        }
    
        public InterfaceSyntax AddOperations(params OperationSyntax[] operations)
        {
            return this.WithOperations(this.Operations.AddRange(operations));
        }
    
        public InterfaceSyntax WithTRBrace(__SyntaxToken tRBrace)
        {
            return this.Update(this.KInterface, this.Name, this.TLBrace, this.Resources, this.Operations, tRBrace);
        }
    
    
        public InterfaceSyntax Update(__SyntaxToken kInterface, NameSyntax name, __SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SyntaxList<ResourceSyntax> resources, global::MetaDslx.CodeAnalysis.SyntaxList<OperationSyntax> operations, __SyntaxToken tRBrace)
        {
            if (this.KInterface != kInterface || this.Name != name || this.TLBrace != tLBrace || this.Resources != resources || this.Operations != operations || this.TRBrace != tRBrace)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.Interface(kInterface, name, tLBrace, resources, operations, tRBrace);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (InterfaceSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitInterface(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitInterface(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitInterface(this);
        }
    
    }
    public sealed class ResourceSyntax : SoalSyntaxNode
    {
        private QualifierSyntax _entity;
        private ResourceBlock1Syntax _block;
    
        public ResourceSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ResourceSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsReadOnly 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.ResourceGreen)this.Green;
            var greenToken = green.IsReadOnly;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public __SyntaxToken KResource 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.ResourceGreen)this.Green;
            var greenToken = green.KResource;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
            } 
        }
        public QualifierSyntax Entity 
        { 
            get
            {
            var red = this.GetRed(ref this._entity, 2);
            return red;
            } 
        }
        public ResourceBlock1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 3);
            return red;
            } 
        }
        public __SyntaxToken TSemicolon 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.ResourceGreen)this.Green;
            var greenToken = green.TSemicolon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 2: return this.GetRed(ref this._entity, 2);
                case 3: return this.GetRed(ref this._block, 3);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 2: return this._entity;
                case 3: return this._block;
                default: return null;
            }
        }
    
        public ResourceSyntax WithIsReadOnly(__SyntaxToken isReadOnly)
        {
            return this.Update(isReadOnly, this.KResource, this.Entity, this.Block, this.TSemicolon);
        }
    
        public ResourceSyntax WithKResource(__SyntaxToken kResource)
        {
            return this.Update(this.IsReadOnly, kResource, this.Entity, this.Block, this.TSemicolon);
        }
    
        public ResourceSyntax WithEntity(QualifierSyntax entity)
        {
            return this.Update(this.IsReadOnly, this.KResource, entity, this.Block, this.TSemicolon);
        }
    
        public ResourceSyntax WithBlock(ResourceBlock1Syntax block)
        {
            return this.Update(this.IsReadOnly, this.KResource, this.Entity, block, this.TSemicolon);
        }
    
        public ResourceSyntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.IsReadOnly, this.KResource, this.Entity, this.Block, tSemicolon);
        }
    
    
        public ResourceSyntax Update(__SyntaxToken isReadOnly, __SyntaxToken kResource, QualifierSyntax entity, ResourceBlock1Syntax block, __SyntaxToken tSemicolon)
        {
            if (this.IsReadOnly != isReadOnly || this.KResource != kResource || this.Entity != entity || this.Block != block || this.TSemicolon != tSemicolon)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.Resource(isReadOnly, kResource, entity, block, tSemicolon);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ResourceSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitResource(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitResource(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitResource(this);
        }
    
    }
    public sealed class OperationSyntax : SoalSyntaxNode
    {
        private OutputParameterListSyntax _responseParameters;
        private NameSyntax _name;
        private InputParameterListSyntax _requestParameters;
        private OperationBlock1Syntax _block;
    
        public OperationSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OperationSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken IsAsync 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.OperationGreen)this.Green;
            var greenToken = green.IsAsync;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public OutputParameterListSyntax ResponseParameters 
        { 
            get
            {
            var red = this.GetRed(ref this._responseParameters, 1);
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
        public InputParameterListSyntax RequestParameters 
        { 
            get
            {
            var red = this.GetRed(ref this._requestParameters, 3);
            return red;
            } 
        }
        public OperationBlock1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 4);
            return red;
            } 
        }
        public __SyntaxToken TSemicolon 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.OperationGreen)this.Green;
            var greenToken = green.TSemicolon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._responseParameters, 1);
                case 2: return this.GetRed(ref this._name, 2);
                case 3: return this.GetRed(ref this._requestParameters, 3);
                case 4: return this.GetRed(ref this._block, 4);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._responseParameters;
                case 2: return this._name;
                case 3: return this._requestParameters;
                case 4: return this._block;
                default: return null;
            }
        }
    
        public OperationSyntax WithIsAsync(__SyntaxToken isAsync)
        {
            return this.Update(isAsync, this.ResponseParameters, this.Name, this.RequestParameters, this.Block, this.TSemicolon);
        }
    
        public OperationSyntax WithResponseParameters(OutputParameterListSyntax responseParameters)
        {
            return this.Update(this.IsAsync, responseParameters, this.Name, this.RequestParameters, this.Block, this.TSemicolon);
        }
    
        public OperationSyntax WithName(NameSyntax name)
        {
            return this.Update(this.IsAsync, this.ResponseParameters, name, this.RequestParameters, this.Block, this.TSemicolon);
        }
    
        public OperationSyntax WithRequestParameters(InputParameterListSyntax requestParameters)
        {
            return this.Update(this.IsAsync, this.ResponseParameters, this.Name, requestParameters, this.Block, this.TSemicolon);
        }
    
        public OperationSyntax WithBlock(OperationBlock1Syntax block)
        {
            return this.Update(this.IsAsync, this.ResponseParameters, this.Name, this.RequestParameters, block, this.TSemicolon);
        }
    
        public OperationSyntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.IsAsync, this.ResponseParameters, this.Name, this.RequestParameters, this.Block, tSemicolon);
        }
    
    
        public OperationSyntax Update(__SyntaxToken isAsync, OutputParameterListSyntax responseParameters, NameSyntax name, InputParameterListSyntax requestParameters, OperationBlock1Syntax block, __SyntaxToken tSemicolon)
        {
            if (this.IsAsync != isAsync || this.ResponseParameters != responseParameters || this.Name != name || this.RequestParameters != requestParameters || this.Block != block || this.TSemicolon != tSemicolon)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.Operation(isAsync, responseParameters, name, requestParameters, block, tSemicolon);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OperationSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOperation(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOperation(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitOperation(this);
        }
    
    }
    public sealed class InputParameterListSyntax : SoalSyntaxNode
    {
        private InputParameterListBlock1Syntax _block;
    
        public InputParameterListSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public InputParameterListSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TLParen 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.InputParameterListGreen)this.Green;
            var greenToken = green.TLParen;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public InputParameterListBlock1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 1);
            return red;
            } 
        }
        public __SyntaxToken TRParen 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.InputParameterListGreen)this.Green;
            var greenToken = green.TRParen;
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
    
        public InputParameterListSyntax WithTLParen(__SyntaxToken tLParen)
        {
            return this.Update(tLParen, this.Block, this.TRParen);
        }
    
        public InputParameterListSyntax WithBlock(InputParameterListBlock1Syntax block)
        {
            return this.Update(this.TLParen, block, this.TRParen);
        }
    
        public InputParameterListSyntax WithTRParen(__SyntaxToken tRParen)
        {
            return this.Update(this.TLParen, this.Block, tRParen);
        }
    
    
        public InputParameterListSyntax Update(__SyntaxToken tLParen, InputParameterListBlock1Syntax block, __SyntaxToken tRParen)
        {
            if (this.TLParen != tLParen || this.Block != block || this.TRParen != tRParen)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.InputParameterList(tLParen, block, tRParen);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (InputParameterListSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitInputParameterList(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitInputParameterList(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitInputParameterList(this);
        }
    
    }
    public abstract class OutputParameterListSyntax : SoalSyntaxNode
    {
        protected OutputParameterListSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected OutputParameterListSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    public sealed class OutputParameterListAlt1Syntax : OutputParameterListSyntax
    {
    
        public OutputParameterListAlt1Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OutputParameterListAlt1Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KVoid 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.OutputParameterListAlt1Green)this.Green;
            var greenToken = green.KVoid;
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
    
        public OutputParameterListAlt1Syntax WithKVoid(__SyntaxToken kVoid)
        {
            return this.Update(kVoid);
        }
    
    
        public OutputParameterListAlt1Syntax Update(__SyntaxToken kVoid)
        {
            if (this.KVoid != kVoid)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.OutputParameterListAlt1(kVoid);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OutputParameterListAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOutputParameterListAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOutputParameterListAlt1(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitOutputParameterListAlt1(this);
        }
    
    }
    public sealed class OutputParameterListAlt2Syntax : OutputParameterListSyntax
    {
        private SingleReturnParameterSyntax _parameters;
    
        public OutputParameterListAlt2Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OutputParameterListAlt2Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public SingleReturnParameterSyntax Parameters 
        { 
            get
            {
            var red = this.GetRed(ref this._parameters, 0);
            return red;
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
    
        public OutputParameterListAlt2Syntax WithParameters(SingleReturnParameterSyntax parameters)
        {
            return this.Update(parameters);
        }
    
    
        public OutputParameterListAlt2Syntax Update(SingleReturnParameterSyntax parameters)
        {
            if (this.Parameters != parameters)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.OutputParameterListAlt2(parameters);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OutputParameterListAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOutputParameterListAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOutputParameterListAlt2(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitOutputParameterListAlt2(this);
        }
    
    }
    public sealed class OutputParameterListAlt3Syntax : OutputParameterListSyntax
    {
        private __SyntaxNode _parameters;
    
        public OutputParameterListAlt3Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OutputParameterListAlt3Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TLParen 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.OutputParameterListAlt3Green)this.Green;
            var greenToken = green.TLParen;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> Parameters 
        { 
            get
            {
            var red = this.GetRed(ref this._parameters, 1);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax>(red, this.GetChildIndex(1), reversed: false);
            } 
        }
        public __SyntaxToken TRParen 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.OutputParameterListAlt3Green)this.Green;
            var greenToken = green.TRParen;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
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
    
        public OutputParameterListAlt3Syntax WithTLParen(__SyntaxToken tLParen)
        {
            return this.Update(tLParen, this.Parameters, this.TRParen);
        }
    
        public OutputParameterListAlt3Syntax WithParameters(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> parameters)
        {
            return this.Update(this.TLParen, parameters, this.TRParen);
        }
    
        public OutputParameterListAlt3Syntax AddParameters(params ParameterSyntax[] parameters)
        {
            return this.WithParameters(this.Parameters.AddRange(parameters));
        }
    
        public OutputParameterListAlt3Syntax WithTRParen(__SyntaxToken tRParen)
        {
            return this.Update(this.TLParen, this.Parameters, tRParen);
        }
    
    
        public OutputParameterListAlt3Syntax Update(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> parameters, __SyntaxToken tRParen)
        {
            if (this.TLParen != tLParen || this.Parameters != parameters || this.TRParen != tRParen)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.OutputParameterListAlt3(tLParen, parameters, tRParen);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OutputParameterListAlt3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOutputParameterListAlt3(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOutputParameterListAlt3(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitOutputParameterListAlt3(this);
        }
    
    }
    public sealed class ParameterSyntax : SoalSyntaxNode
    {
        private TypeReferenceSyntax _type;
        private NameSyntax _name;
    
        public ParameterSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ParameterSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
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
                var newNode = SoalLanguage.Instance.SyntaxFactory.Parameter(type, name);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ParameterSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitParameter(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitParameter(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitParameter(this);
        }
    
    }
    public sealed class SingleReturnParameterSyntax : SoalSyntaxNode
    {
        private TypeReferenceSyntax _type;
    
        public SingleReturnParameterSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SingleReturnParameterSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
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
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._type, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._type;
                default: return null;
            }
        }
    
        public SingleReturnParameterSyntax WithType(TypeReferenceSyntax type)
        {
            return this.Update(type);
        }
    
    
        public SingleReturnParameterSyntax Update(TypeReferenceSyntax type)
        {
            if (this.Type != type)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SingleReturnParameter(type);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SingleReturnParameterSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSingleReturnParameter(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSingleReturnParameter(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSingleReturnParameter(this);
        }
    
    }
    public sealed class ServiceSyntax : SoalSyntaxNode
    {
        private NameSyntax _name;
        private QualifierSyntax _interface;
        private BindingKindSyntax _binding;
    
        public ServiceSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ServiceSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KService 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.ServiceGreen)this.Green;
            var greenToken = green.KService;
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
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.ServiceGreen)this.Green;
            var greenToken = green.TColon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
            } 
        }
        public QualifierSyntax Interface 
        { 
            get
            {
            var red = this.GetRed(ref this._interface, 3);
            return red;
            } 
        }
        public __SyntaxToken TLBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.ServiceGreen)this.Green;
            var greenToken = green.TLBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
            } 
        }
        public __SyntaxToken KBinding 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.ServiceGreen)this.Green;
            var greenToken = green.KBinding;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
            } 
        }
        public BindingKindSyntax Binding 
        { 
            get
            {
            var red = this.GetRed(ref this._binding, 6);
            return red;
            } 
        }
        public __SyntaxToken TSemicolon 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.ServiceGreen)this.Green;
            var greenToken = green.TSemicolon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(7), this.GetChildIndex(7));
            } 
        }
        public __SyntaxToken TRBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.ServiceGreen)this.Green;
            var greenToken = green.TRBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(8), this.GetChildIndex(8));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._name, 1);
                case 3: return this.GetRed(ref this._interface, 3);
                case 6: return this.GetRed(ref this._binding, 6);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._name;
                case 3: return this._interface;
                case 6: return this._binding;
                default: return null;
            }
        }
    
        public ServiceSyntax WithKService(__SyntaxToken kService)
        {
            return this.Update(kService, this.Name, this.TColon, this.Interface, this.TLBrace, this.KBinding, this.Binding, this.TSemicolon, this.TRBrace);
        }
    
        public ServiceSyntax WithName(NameSyntax name)
        {
            return this.Update(this.KService, name, this.TColon, this.Interface, this.TLBrace, this.KBinding, this.Binding, this.TSemicolon, this.TRBrace);
        }
    
        public ServiceSyntax WithTColon(__SyntaxToken tColon)
        {
            return this.Update(this.KService, this.Name, tColon, this.Interface, this.TLBrace, this.KBinding, this.Binding, this.TSemicolon, this.TRBrace);
        }
    
        public ServiceSyntax WithInterface(QualifierSyntax @interface)
        {
            return this.Update(this.KService, this.Name, this.TColon, @interface, this.TLBrace, this.KBinding, this.Binding, this.TSemicolon, this.TRBrace);
        }
    
        public ServiceSyntax WithTLBrace(__SyntaxToken tLBrace)
        {
            return this.Update(this.KService, this.Name, this.TColon, this.Interface, tLBrace, this.KBinding, this.Binding, this.TSemicolon, this.TRBrace);
        }
    
        public ServiceSyntax WithKBinding(__SyntaxToken kBinding)
        {
            return this.Update(this.KService, this.Name, this.TColon, this.Interface, this.TLBrace, kBinding, this.Binding, this.TSemicolon, this.TRBrace);
        }
    
        public ServiceSyntax WithBinding(BindingKindSyntax binding)
        {
            return this.Update(this.KService, this.Name, this.TColon, this.Interface, this.TLBrace, this.KBinding, binding, this.TSemicolon, this.TRBrace);
        }
    
        public ServiceSyntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.KService, this.Name, this.TColon, this.Interface, this.TLBrace, this.KBinding, this.Binding, tSemicolon, this.TRBrace);
        }
    
        public ServiceSyntax WithTRBrace(__SyntaxToken tRBrace)
        {
            return this.Update(this.KService, this.Name, this.TColon, this.Interface, this.TLBrace, this.KBinding, this.Binding, this.TSemicolon, tRBrace);
        }
    
    
        public ServiceSyntax Update(__SyntaxToken kService, NameSyntax name, __SyntaxToken tColon, QualifierSyntax @interface, __SyntaxToken tLBrace, __SyntaxToken kBinding, BindingKindSyntax binding, __SyntaxToken tSemicolon, __SyntaxToken tRBrace)
        {
            if (this.KService != kService || this.Name != name || this.TColon != tColon || this.Interface != @interface || this.TLBrace != tLBrace || this.KBinding != kBinding || this.Binding != binding || this.TSemicolon != tSemicolon || this.TRBrace != tRBrace)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.Service(kService, name, tColon, @interface, tLBrace, kBinding, binding, tSemicolon, tRBrace);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ServiceSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitService(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitService(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitService(this);
        }
    
    }
    public sealed class BindingKindSyntax : SoalSyntaxNode
    {
    
        public BindingKindSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public BindingKindSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken Token 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.BindingKindGreen)this.Green;
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
    
        public BindingKindSyntax WithToken(__SyntaxToken token)
        {
            return this.Update(token);
        }
    
    
        public BindingKindSyntax Update(__SyntaxToken token)
        {
            if (this.Token != token)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.BindingKind(token);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (BindingKindSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitBindingKind(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitBindingKind(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitBindingKind(this);
        }
    
    }
    public sealed class TypeReferenceSyntax : SoalSyntaxNode
    {
        private SimpleTypeSyntax _simpleType;
        private TypeReferenceBlock1Syntax _isArray;
    
        public TypeReferenceSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public TypeReferenceSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public SimpleTypeSyntax SimpleType 
        { 
            get
            {
            var red = this.GetRed(ref this._simpleType, 0);
            return red;
            } 
        }
        public __SyntaxToken IsNullable 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.TypeReferenceGreen)this.Green;
            var greenToken = green.IsNullable;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
            } 
        }
        public TypeReferenceBlock1Syntax IsArray 
        { 
            get
            {
            var red = this.GetRed(ref this._isArray, 2);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._simpleType, 0);
                case 2: return this.GetRed(ref this._isArray, 2);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._simpleType;
                case 2: return this._isArray;
                default: return null;
            }
        }
    
        public TypeReferenceSyntax WithSimpleType(SimpleTypeSyntax simpleType)
        {
            return this.Update(simpleType, this.IsNullable, this.IsArray);
        }
    
        public TypeReferenceSyntax WithIsNullable(__SyntaxToken isNullable)
        {
            return this.Update(this.SimpleType, isNullable, this.IsArray);
        }
    
        public TypeReferenceSyntax WithIsArray(TypeReferenceBlock1Syntax isArray)
        {
            return this.Update(this.SimpleType, this.IsNullable, isArray);
        }
    
    
        public TypeReferenceSyntax Update(SimpleTypeSyntax simpleType, __SyntaxToken isNullable, TypeReferenceBlock1Syntax isArray)
        {
            if (this.SimpleType != simpleType || this.IsNullable != isNullable || this.IsArray != isArray)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.TypeReference(simpleType, isNullable, isArray);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (TypeReferenceSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitTypeReference(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitTypeReference(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitTypeReference(this);
        }
    
    }
    public abstract class SimpleTypeSyntax : SoalSyntaxNode
    {
        protected SimpleTypeSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected SimpleTypeSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    public sealed class SimpleTypeAlt1Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt1Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt1Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KObject 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt1Green)this.Green;
            var greenToken = green.KObject;
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
    
        public SimpleTypeAlt1Syntax WithKObject(__SyntaxToken kObject)
        {
            return this.Update(kObject);
        }
    
    
        public SimpleTypeAlt1Syntax Update(__SyntaxToken kObject)
        {
            if (this.KObject != kObject)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt1(kObject);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt1(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt1(this);
        }
    
    }
    public sealed class SimpleTypeAlt2Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt2Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt2Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KBinary 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt2Green)this.Green;
            var greenToken = green.KBinary;
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
    
        public SimpleTypeAlt2Syntax WithKBinary(__SyntaxToken kBinary)
        {
            return this.Update(kBinary);
        }
    
    
        public SimpleTypeAlt2Syntax Update(__SyntaxToken kBinary)
        {
            if (this.KBinary != kBinary)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt2(kBinary);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt2(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt2(this);
        }
    
    }
    public sealed class SimpleTypeAlt3Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt3Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt3Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KBool 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt3Green)this.Green;
            var greenToken = green.KBool;
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
    
        public SimpleTypeAlt3Syntax WithKBool(__SyntaxToken kBool)
        {
            return this.Update(kBool);
        }
    
    
        public SimpleTypeAlt3Syntax Update(__SyntaxToken kBool)
        {
            if (this.KBool != kBool)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt3(kBool);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt3(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt3(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt3(this);
        }
    
    }
    public sealed class SimpleTypeAlt4Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt4Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt4Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KString 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt4Green)this.Green;
            var greenToken = green.KString;
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
    
        public SimpleTypeAlt4Syntax WithKString(__SyntaxToken kString)
        {
            return this.Update(kString);
        }
    
    
        public SimpleTypeAlt4Syntax Update(__SyntaxToken kString)
        {
            if (this.KString != kString)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt4(kString);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt4Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt4(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt4(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt4(this);
        }
    
    }
    public sealed class SimpleTypeAlt5Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt5Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt5Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KInt 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt5Green)this.Green;
            var greenToken = green.KInt;
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
    
        public SimpleTypeAlt5Syntax WithKInt(__SyntaxToken kInt)
        {
            return this.Update(kInt);
        }
    
    
        public SimpleTypeAlt5Syntax Update(__SyntaxToken kInt)
        {
            if (this.KInt != kInt)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt5(kInt);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt5Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt5(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt5(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt5(this);
        }
    
    }
    public sealed class SimpleTypeAlt6Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt6Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt6Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KLong 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt6Green)this.Green;
            var greenToken = green.KLong;
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
    
        public SimpleTypeAlt6Syntax WithKLong(__SyntaxToken kLong)
        {
            return this.Update(kLong);
        }
    
    
        public SimpleTypeAlt6Syntax Update(__SyntaxToken kLong)
        {
            if (this.KLong != kLong)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt6(kLong);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt6Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt6(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt6(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt6(this);
        }
    
    }
    public sealed class SimpleTypeAlt7Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt7Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt7Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KFloat 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt7Green)this.Green;
            var greenToken = green.KFloat;
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
    
        public SimpleTypeAlt7Syntax WithKFloat(__SyntaxToken kFloat)
        {
            return this.Update(kFloat);
        }
    
    
        public SimpleTypeAlt7Syntax Update(__SyntaxToken kFloat)
        {
            if (this.KFloat != kFloat)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt7(kFloat);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt7Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt7(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt7(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt7(this);
        }
    
    }
    public sealed class SimpleTypeAlt8Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt8Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt8Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KDouble 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt8Green)this.Green;
            var greenToken = green.KDouble;
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
    
        public SimpleTypeAlt8Syntax WithKDouble(__SyntaxToken kDouble)
        {
            return this.Update(kDouble);
        }
    
    
        public SimpleTypeAlt8Syntax Update(__SyntaxToken kDouble)
        {
            if (this.KDouble != kDouble)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt8(kDouble);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt8Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt8(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt8(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt8(this);
        }
    
    }
    public sealed class SimpleTypeAlt9Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt9Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt9Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KDate 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt9Green)this.Green;
            var greenToken = green.KDate;
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
    
        public SimpleTypeAlt9Syntax WithKDate(__SyntaxToken kDate)
        {
            return this.Update(kDate);
        }
    
    
        public SimpleTypeAlt9Syntax Update(__SyntaxToken kDate)
        {
            if (this.KDate != kDate)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt9(kDate);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt9Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt9(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt9(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt9(this);
        }
    
    }
    public sealed class SimpleTypeAlt10Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt10Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt10Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KTime 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt10Green)this.Green;
            var greenToken = green.KTime;
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
    
        public SimpleTypeAlt10Syntax WithKTime(__SyntaxToken kTime)
        {
            return this.Update(kTime);
        }
    
    
        public SimpleTypeAlt10Syntax Update(__SyntaxToken kTime)
        {
            if (this.KTime != kTime)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt10(kTime);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt10Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt10(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt10(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt10(this);
        }
    
    }
    public sealed class SimpleTypeAlt11Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt11Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt11Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KDatetime 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt11Green)this.Green;
            var greenToken = green.KDatetime;
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
    
        public SimpleTypeAlt11Syntax WithKDatetime(__SyntaxToken kDatetime)
        {
            return this.Update(kDatetime);
        }
    
    
        public SimpleTypeAlt11Syntax Update(__SyntaxToken kDatetime)
        {
            if (this.KDatetime != kDatetime)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt11(kDatetime);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt11Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt11(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt11(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt11(this);
        }
    
    }
    public sealed class SimpleTypeAlt12Syntax : SimpleTypeSyntax
    {
    
        public SimpleTypeAlt12Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt12Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KDuration 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.SimpleTypeAlt12Green)this.Green;
            var greenToken = green.KDuration;
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
    
        public SimpleTypeAlt12Syntax WithKDuration(__SyntaxToken kDuration)
        {
            return this.Update(kDuration);
        }
    
    
        public SimpleTypeAlt12Syntax Update(__SyntaxToken kDuration)
        {
            if (this.KDuration != kDuration)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt12(kDuration);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt12Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt12(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt12(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt12(this);
        }
    
    }
    public sealed class SimpleTypeAlt13Syntax : SimpleTypeSyntax
    {
        private QualifierSyntax _qualifier;
    
        public SimpleTypeAlt13Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SimpleTypeAlt13Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
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
    
        public SimpleTypeAlt13Syntax WithQualifier(QualifierSyntax qualifier)
        {
            return this.Update(qualifier);
        }
    
    
        public SimpleTypeAlt13Syntax Update(QualifierSyntax qualifier)
        {
            if (this.Qualifier != qualifier)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.SimpleTypeAlt13(qualifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SimpleTypeAlt13Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSimpleTypeAlt13(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSimpleTypeAlt13(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitSimpleTypeAlt13(this);
        }
    
    }
    public sealed class NameSyntax : SoalSyntaxNode
    {
        private IdentifierSyntax _identifier;
    
        public NameSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public NameSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
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
                var newNode = SoalLanguage.Instance.SyntaxFactory.Name(identifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (NameSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitName(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitName(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitName(this);
        }
    
    }
    public sealed class QualifierSyntax : SoalSyntaxNode
    {
        private __SyntaxNode _identifier;
    
        public QualifierSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public QualifierSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
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
                var newNode = SoalLanguage.Instance.SyntaxFactory.Qualifier(identifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (QualifierSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitQualifier(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitQualifier(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitQualifier(this);
        }
    
    }
    public sealed class IdentifierSyntax : SoalSyntaxNode
    {
    
        public IdentifierSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public IdentifierSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken Token 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.IdentifierGreen)this.Green;
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
                var newNode = SoalLanguage.Instance.SyntaxFactory.Identifier(token);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (IdentifierSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitIdentifier(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitIdentifier(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitIdentifier(this);
        }
    
    }
    public sealed class MainBlock1Syntax : SoalSyntaxNode
    {
        private __SyntaxNode _declarationList;
    
        public MainBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MainBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public global::MetaDslx.CodeAnalysis.SyntaxList<DeclarationSyntax> DeclarationList 
        { 
            get
            {
            var red = this.GetRed(ref this._declarationList, 0);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<DeclarationSyntax>(red);
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._declarationList, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._declarationList;
                default: return null;
            }
        }
    
        public MainBlock1Syntax WithDeclarationList(global::MetaDslx.CodeAnalysis.SyntaxList<DeclarationSyntax> declarationList)
        {
            return this.Update(declarationList);
        }
    
        public MainBlock1Syntax AddDeclarationList(params DeclarationSyntax[] declarationList)
        {
            return this.WithDeclarationList(this.DeclarationList.AddRange(declarationList));
        }
    
    
        public MainBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<DeclarationSyntax> declarationList)
        {
            if (this.DeclarationList != declarationList)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.MainBlock1(declarationList);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MainBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMainBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMainBlock1(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitMainBlock1(this);
        }
    
    }
    public sealed class EnumTypeBlock1Syntax : SoalSyntaxNode
    {
        private __SyntaxNode _literals;
    
        public EnumTypeBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public EnumTypeBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<EnumLiteralSyntax> Literals 
        { 
            get
            {
            var red = this.GetRed(ref this._literals, 0);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<EnumLiteralSyntax>(red, this.GetChildIndex(0), reversed: false);
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._literals, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._literals;
                default: return null;
            }
        }
    
        public EnumTypeBlock1Syntax WithLiterals(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<EnumLiteralSyntax> literals)
        {
            return this.Update(literals);
        }
    
        public EnumTypeBlock1Syntax AddLiterals(params EnumLiteralSyntax[] literals)
        {
            return this.WithLiterals(this.Literals.AddRange(literals));
        }
    
    
        public EnumTypeBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<EnumLiteralSyntax> literals)
        {
            if (this.Literals != literals)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.EnumTypeBlock1(literals);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (EnumTypeBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitEnumTypeBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitEnumTypeBlock1(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitEnumTypeBlock1(this);
        }
    
    }
    public sealed class EnumTypeBlock1literalsBlockSyntax : SoalSyntaxNode
    {
        private EnumLiteralSyntax _literals;
    
        public EnumTypeBlock1literalsBlockSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public EnumTypeBlock1literalsBlockSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.EnumTypeBlock1literalsBlockGreen)this.Green;
            var greenToken = green.TComma;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public EnumLiteralSyntax Literals 
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
    
        public EnumTypeBlock1literalsBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.Literals);
        }
    
        public EnumTypeBlock1literalsBlockSyntax WithLiterals(EnumLiteralSyntax literals)
        {
            return this.Update(this.TComma, literals);
        }
    
    
        public EnumTypeBlock1literalsBlockSyntax Update(__SyntaxToken tComma, EnumLiteralSyntax literals)
        {
            if (this.TComma != tComma || this.Literals != literals)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.EnumTypeBlock1literalsBlock(tComma, literals);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (EnumTypeBlock1literalsBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitEnumTypeBlock1literalsBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitEnumTypeBlock1literalsBlock(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitEnumTypeBlock1literalsBlock(this);
        }
    
    }
    public sealed class StructTypeBlock1Syntax : SoalSyntaxNode
    {
        private QualifierSyntax _baseType;
    
        public StructTypeBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public StructTypeBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TColon 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.StructTypeBlock1Green)this.Green;
            var greenToken = green.TColon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public QualifierSyntax BaseType 
        { 
            get
            {
            var red = this.GetRed(ref this._baseType, 1);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._baseType, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._baseType;
                default: return null;
            }
        }
    
        public StructTypeBlock1Syntax WithTColon(__SyntaxToken tColon)
        {
            return this.Update(tColon, this.BaseType);
        }
    
        public StructTypeBlock1Syntax WithBaseType(QualifierSyntax baseType)
        {
            return this.Update(this.TColon, baseType);
        }
    
    
        public StructTypeBlock1Syntax Update(__SyntaxToken tColon, QualifierSyntax baseType)
        {
            if (this.TColon != tColon || this.BaseType != baseType)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.StructTypeBlock1(tColon, baseType);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (StructTypeBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitStructTypeBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitStructTypeBlock1(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitStructTypeBlock1(this);
        }
    
    }
    public sealed class ResourceBlock1Syntax : SoalSyntaxNode
    {
        private __SyntaxNode _exceptions;
    
        public ResourceBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ResourceBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KThrows 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.ResourceBlock1Green)this.Green;
            var greenToken = green.KThrows;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> Exceptions 
        { 
            get
            {
            var red = this.GetRed(ref this._exceptions, 1);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._exceptions, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._exceptions;
                default: return null;
            }
        }
    
        public ResourceBlock1Syntax WithKThrows(__SyntaxToken kThrows)
        {
            return this.Update(kThrows, this.Exceptions);
        }
    
        public ResourceBlock1Syntax WithExceptions(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> exceptions)
        {
            return this.Update(this.KThrows, exceptions);
        }
    
        public ResourceBlock1Syntax AddExceptions(params QualifierSyntax[] exceptions)
        {
            return this.WithExceptions(this.Exceptions.AddRange(exceptions));
        }
    
    
        public ResourceBlock1Syntax Update(__SyntaxToken kThrows, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> exceptions)
        {
            if (this.KThrows != kThrows || this.Exceptions != exceptions)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.ResourceBlock1(kThrows, exceptions);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ResourceBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitResourceBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitResourceBlock1(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitResourceBlock1(this);
        }
    
    }
    public sealed class ResourceBlock1exceptionsBlockSyntax : SoalSyntaxNode
    {
        private QualifierSyntax _exceptions;
    
        public ResourceBlock1exceptionsBlockSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ResourceBlock1exceptionsBlockSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.ResourceBlock1exceptionsBlockGreen)this.Green;
            var greenToken = green.TComma;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public QualifierSyntax Exceptions 
        { 
            get
            {
            var red = this.GetRed(ref this._exceptions, 1);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._exceptions, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._exceptions;
                default: return null;
            }
        }
    
        public ResourceBlock1exceptionsBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.Exceptions);
        }
    
        public ResourceBlock1exceptionsBlockSyntax WithExceptions(QualifierSyntax exceptions)
        {
            return this.Update(this.TComma, exceptions);
        }
    
    
        public ResourceBlock1exceptionsBlockSyntax Update(__SyntaxToken tComma, QualifierSyntax exceptions)
        {
            if (this.TComma != tComma || this.Exceptions != exceptions)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.ResourceBlock1exceptionsBlock(tComma, exceptions);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ResourceBlock1exceptionsBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitResourceBlock1exceptionsBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitResourceBlock1exceptionsBlock(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitResourceBlock1exceptionsBlock(this);
        }
    
    }
    public sealed class OperationBlock1Syntax : SoalSyntaxNode
    {
        private __SyntaxNode _exceptions;
    
        public OperationBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OperationBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KThrows 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.OperationBlock1Green)this.Green;
            var greenToken = green.KThrows;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> Exceptions 
        { 
            get
            {
            var red = this.GetRed(ref this._exceptions, 1);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._exceptions, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._exceptions;
                default: return null;
            }
        }
    
        public OperationBlock1Syntax WithKThrows(__SyntaxToken kThrows)
        {
            return this.Update(kThrows, this.Exceptions);
        }
    
        public OperationBlock1Syntax WithExceptions(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> exceptions)
        {
            return this.Update(this.KThrows, exceptions);
        }
    
        public OperationBlock1Syntax AddExceptions(params QualifierSyntax[] exceptions)
        {
            return this.WithExceptions(this.Exceptions.AddRange(exceptions));
        }
    
    
        public OperationBlock1Syntax Update(__SyntaxToken kThrows, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> exceptions)
        {
            if (this.KThrows != kThrows || this.Exceptions != exceptions)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.OperationBlock1(kThrows, exceptions);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OperationBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOperationBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOperationBlock1(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitOperationBlock1(this);
        }
    
    }
    public sealed class OperationBlock1exceptionsBlockSyntax : SoalSyntaxNode
    {
        private QualifierSyntax _exceptions;
    
        public OperationBlock1exceptionsBlockSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OperationBlock1exceptionsBlockSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.OperationBlock1exceptionsBlockGreen)this.Green;
            var greenToken = green.TComma;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public QualifierSyntax Exceptions 
        { 
            get
            {
            var red = this.GetRed(ref this._exceptions, 1);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._exceptions, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._exceptions;
                default: return null;
            }
        }
    
        public OperationBlock1exceptionsBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.Exceptions);
        }
    
        public OperationBlock1exceptionsBlockSyntax WithExceptions(QualifierSyntax exceptions)
        {
            return this.Update(this.TComma, exceptions);
        }
    
    
        public OperationBlock1exceptionsBlockSyntax Update(__SyntaxToken tComma, QualifierSyntax exceptions)
        {
            if (this.TComma != tComma || this.Exceptions != exceptions)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.OperationBlock1exceptionsBlock(tComma, exceptions);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OperationBlock1exceptionsBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOperationBlock1exceptionsBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOperationBlock1exceptionsBlock(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitOperationBlock1exceptionsBlock(this);
        }
    
    }
    public sealed class InputParameterListBlock1Syntax : SoalSyntaxNode
    {
        private __SyntaxNode _parameters;
    
        public InputParameterListBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public InputParameterListBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
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
    
        public InputParameterListBlock1Syntax WithParameters(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> parameters)
        {
            return this.Update(parameters);
        }
    
        public InputParameterListBlock1Syntax AddParameters(params ParameterSyntax[] parameters)
        {
            return this.WithParameters(this.Parameters.AddRange(parameters));
        }
    
    
        public InputParameterListBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> parameters)
        {
            if (this.Parameters != parameters)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.InputParameterListBlock1(parameters);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (InputParameterListBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitInputParameterListBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitInputParameterListBlock1(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitInputParameterListBlock1(this);
        }
    
    }
    public sealed class InputParameterListBlock1parametersBlockSyntax : SoalSyntaxNode
    {
        private ParameterSyntax _parameters;
    
        public InputParameterListBlock1parametersBlockSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public InputParameterListBlock1parametersBlockSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.InputParameterListBlock1parametersBlockGreen)this.Green;
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
    
        public InputParameterListBlock1parametersBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.Parameters);
        }
    
        public InputParameterListBlock1parametersBlockSyntax WithParameters(ParameterSyntax parameters)
        {
            return this.Update(this.TComma, parameters);
        }
    
    
        public InputParameterListBlock1parametersBlockSyntax Update(__SyntaxToken tComma, ParameterSyntax parameters)
        {
            if (this.TComma != tComma || this.Parameters != parameters)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.InputParameterListBlock1parametersBlock(tComma, parameters);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (InputParameterListBlock1parametersBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitInputParameterListBlock1parametersBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitInputParameterListBlock1parametersBlock(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitInputParameterListBlock1parametersBlock(this);
        }
    
    }
    public sealed class OutputParameterListAlt3parametersBlockSyntax : SoalSyntaxNode
    {
        private ParameterSyntax _parameters;
    
        public OutputParameterListAlt3parametersBlockSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public OutputParameterListAlt3parametersBlockSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.OutputParameterListAlt3parametersBlockGreen)this.Green;
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
    
        public OutputParameterListAlt3parametersBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.Parameters);
        }
    
        public OutputParameterListAlt3parametersBlockSyntax WithParameters(ParameterSyntax parameters)
        {
            return this.Update(this.TComma, parameters);
        }
    
    
        public OutputParameterListAlt3parametersBlockSyntax Update(__SyntaxToken tComma, ParameterSyntax parameters)
        {
            if (this.TComma != tComma || this.Parameters != parameters)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.OutputParameterListAlt3parametersBlock(tComma, parameters);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (OutputParameterListAlt3parametersBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitOutputParameterListAlt3parametersBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitOutputParameterListAlt3parametersBlock(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitOutputParameterListAlt3parametersBlock(this);
        }
    
    }
    public sealed class TypeReferenceBlock1Syntax : SoalSyntaxNode
    {
    
        public TypeReferenceBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public TypeReferenceBlock1Syntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TLBracket 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.TypeReferenceBlock1Green)this.Green;
            var greenToken = green.TLBracket;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public __SyntaxToken TRBracket 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.TypeReferenceBlock1Green)this.Green;
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
    
        public TypeReferenceBlock1Syntax WithTLBracket(__SyntaxToken tLBracket)
        {
            return this.Update(tLBracket, this.TRBracket);
        }
    
        public TypeReferenceBlock1Syntax WithTRBracket(__SyntaxToken tRBracket)
        {
            return this.Update(this.TLBracket, tRBracket);
        }
    
    
        public TypeReferenceBlock1Syntax Update(__SyntaxToken tLBracket, __SyntaxToken tRBracket)
        {
            if (this.TLBracket != tLBracket || this.TRBracket != tRBracket)
            {
                var newNode = SoalLanguage.Instance.SyntaxFactory.TypeReferenceBlock1(tLBracket, tRBracket);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (TypeReferenceBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitTypeReferenceBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitTypeReferenceBlock1(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitTypeReferenceBlock1(this);
        }
    
    }
    public sealed class QualifierIdentifierBlockSyntax : SoalSyntaxNode
    {
        private IdentifierSyntax _identifier;
    
        public QualifierIdentifierBlockSyntax(__InternalSyntaxNode green, SoalSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public QualifierIdentifierBlockSyntax(__InternalSyntaxNode green, SoalSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TDot 
        { 
            get
            {
            var green = (global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax.QualifierIdentifierBlockGreen)this.Green;
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
                var newNode = SoalLanguage.Instance.SyntaxFactory.QualifierIdentifierBlock(tDot, identifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (QualifierIdentifierBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ISoalSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitQualifierIdentifierBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ISoalSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitQualifierIdentifierBlock(this);
        }
    
        public override void Accept(ISoalSyntaxVisitor visitor)
        {
            visitor.VisitQualifierIdentifierBlock(this);
        }
    
    }
}
