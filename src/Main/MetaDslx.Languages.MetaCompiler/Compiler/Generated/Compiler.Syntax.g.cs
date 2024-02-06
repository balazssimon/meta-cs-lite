#nullable enable

namespace MetaDslx.Languages.MetaCompiler.Compiler.Syntax
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
                var slot = ((global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.GreenSkippedTokensTriviaSyntax)this.Green).Tokens;
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
        private QualifierSyntax _qualifier;
        private __SyntaxNode _block1;
        private MainBlock2Syntax _block2;
    
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
            var greenToken = green.TSemicolon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SyntaxList<MainBlock1Syntax> Block1 
        { 
            get
            {
            var red = this.GetRed(ref this._block1, 3);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SyntaxList<MainBlock1Syntax>(red);
            } 
        }
        public MainBlock2Syntax Block2 
        { 
            get
            {
            var red = this.GetRed(ref this._block2, 4);
            return red;
            } 
        }
        public __SyntaxToken EndOfFileToken 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.MainGreen)this.Green;
            var greenToken = green.EndOfFileToken;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(5), this.GetChildIndex(5));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._qualifier, 1);
                case 3: return this.GetRed(ref this._block1, 3);
                case 4: return this.GetRed(ref this._block2, 4);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._qualifier;
                case 3: return this._block1;
                case 4: return this._block2;
                default: return null;
            }
        }
    
        public MainSyntax WithKNamespace(__SyntaxToken kNamespace)
        {
            return this.Update(kNamespace, this.Qualifier, this.TSemicolon, this.Block1, this.Block2, this.EndOfFileToken);
        }
    
        public MainSyntax WithQualifier(QualifierSyntax qualifier)
        {
            return this.Update(this.KNamespace, qualifier, this.TSemicolon, this.Block1, this.Block2, this.EndOfFileToken);
        }
    
        public MainSyntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.KNamespace, this.Qualifier, tSemicolon, this.Block1, this.Block2, this.EndOfFileToken);
        }
    
        public MainSyntax WithBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<MainBlock1Syntax> block1)
        {
            return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, block1, this.Block2, this.EndOfFileToken);
        }
    
        public MainSyntax AddBlock1(params MainBlock1Syntax[] block1)
        {
            return this.WithBlock1(this.Block1.AddRange(block1));
        }
    
        public MainSyntax WithBlock2(MainBlock2Syntax block2)
        {
            return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, this.Block1, block2, this.EndOfFileToken);
        }
    
        public MainSyntax WithEndOfFileToken(__SyntaxToken endOfFileToken)
        {
            return this.Update(this.KNamespace, this.Qualifier, this.TSemicolon, this.Block1, this.Block2, endOfFileToken);
        }
    
    
        public MainSyntax Update(__SyntaxToken kNamespace, QualifierSyntax qualifier, __SyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.SyntaxList<MainBlock1Syntax> block1, MainBlock2Syntax block2, __SyntaxToken endOfFileToken)
        {
            if (this.KNamespace != kNamespace || this.Qualifier != qualifier || this.TSemicolon != tSemicolon || this.Block1 != block1 || this.Block2 != block2 || this.EndOfFileToken != endOfFileToken)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.Main(kNamespace, qualifier, tSemicolon, block1, block2, endOfFileToken);
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
    public abstract class UsingSyntax : CompilerSyntaxNode
    {
        protected UsingSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected UsingSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    
    public sealed class UsingMetaModelSyntax : UsingSyntax
    {
        private QualifierSyntax _metaModelSymbols;
    
        public UsingMetaModelSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public UsingMetaModelSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KMetamodel 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.UsingMetaModelGreen)this.Green;
            var greenToken = green.KMetamodel;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public QualifierSyntax MetaModelSymbols 
        { 
            get
            {
            var red = this.GetRed(ref this._metaModelSymbols, 1);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._metaModelSymbols, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._metaModelSymbols;
                default: return null;
            }
        }
    
        public UsingMetaModelSyntax WithKMetamodel(__SyntaxToken kMetamodel)
        {
            return this.Update(kMetamodel, this.MetaModelSymbols);
        }
    
        public UsingMetaModelSyntax WithMetaModelSymbols(QualifierSyntax metaModelSymbols)
        {
            return this.Update(this.KMetamodel, metaModelSymbols);
        }
    
    
        public UsingMetaModelSyntax Update(__SyntaxToken kMetamodel, QualifierSyntax metaModelSymbols)
        {
            if (this.KMetamodel != kMetamodel || this.MetaModelSymbols != metaModelSymbols)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.UsingMetaModel(kMetamodel, metaModelSymbols);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (UsingMetaModelSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitUsingMetaModel(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitUsingMetaModel(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitUsingMetaModel(this);
        }
    
    }
    public sealed class UsingAlt2Syntax : UsingSyntax
    {
        private QualifierSyntax _namespaces;
    
        public UsingAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public UsingAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public QualifierSyntax Namespaces 
        { 
            get
            {
            var red = this.GetRed(ref this._namespaces, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._namespaces, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._namespaces;
                default: return null;
            }
        }
    
        public UsingAlt2Syntax WithNamespaces(QualifierSyntax namespaces)
        {
            return this.Update(namespaces);
        }
    
    
        public UsingAlt2Syntax Update(QualifierSyntax namespaces)
        {
            if (this.Namespaces != namespaces)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.UsingAlt2(namespaces);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (UsingAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitUsingAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitUsingAlt2(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitUsingAlt2(this);
        }
    
    }
    
    public sealed class LanguageDeclarationSyntax : CompilerSyntaxNode
    {
        private NameSyntax _name;
        private LanguageDeclarationBlock1Syntax _block;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LanguageDeclarationGreen)this.Green;
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
        public LanguageDeclarationBlock1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 2);
            return red;
            } 
        }
        public __SyntaxToken TSemicolon 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LanguageDeclarationGreen)this.Green;
            var greenToken = green.TSemicolon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
            } 
        }
        public GrammarSyntax Grammar 
        { 
            get
            {
            var red = this.GetRed(ref this._grammar, 4);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._name, 1);
                case 2: return this.GetRed(ref this._block, 2);
                case 4: return this.GetRed(ref this._grammar, 4);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._name;
                case 2: return this._block;
                case 4: return this._grammar;
                default: return null;
            }
        }
    
        public LanguageDeclarationSyntax WithKLanguage(__SyntaxToken kLanguage)
        {
            return this.Update(kLanguage, this.Name, this.Block, this.TSemicolon, this.Grammar);
        }
    
        public LanguageDeclarationSyntax WithName(NameSyntax name)
        {
            return this.Update(this.KLanguage, name, this.Block, this.TSemicolon, this.Grammar);
        }
    
        public LanguageDeclarationSyntax WithBlock(LanguageDeclarationBlock1Syntax block)
        {
            return this.Update(this.KLanguage, this.Name, block, this.TSemicolon, this.Grammar);
        }
    
        public LanguageDeclarationSyntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.KLanguage, this.Name, this.Block, tSemicolon, this.Grammar);
        }
    
        public LanguageDeclarationSyntax WithGrammar(GrammarSyntax grammar)
        {
            return this.Update(this.KLanguage, this.Name, this.Block, this.TSemicolon, grammar);
        }
    
    
        public LanguageDeclarationSyntax Update(__SyntaxToken kLanguage, NameSyntax name, LanguageDeclarationBlock1Syntax block, __SyntaxToken tSemicolon, GrammarSyntax grammar)
        {
            if (this.KLanguage != kLanguage || this.Name != name || this.Block != block || this.TSemicolon != tSemicolon || this.Grammar != grammar)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LanguageDeclaration(kLanguage, name, block, tSemicolon, grammar);
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
        private GrammarBlock1Syntax _block;
    
        public GrammarSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public GrammarSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public GrammarBlock1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 0);
            return red;
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
    
        public GrammarSyntax WithBlock(GrammarBlock1Syntax block)
        {
            return this.Update(block);
        }
    
    
        public GrammarSyntax Update(GrammarBlock1Syntax block)
        {
            if (this.Block != block)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.Grammar(block);
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
    public sealed class GrammarRuleAlt2Syntax : GrammarRuleSyntax
    {
        private LexerRuleSyntax _lexerRule;
    
        public GrammarRuleAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public GrammarRuleAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public LexerRuleSyntax LexerRule 
        { 
            get
            {
            var red = this.GetRed(ref this._lexerRule, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._lexerRule, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._lexerRule;
                default: return null;
            }
        }
    
        public GrammarRuleAlt2Syntax WithLexerRule(LexerRuleSyntax lexerRule)
        {
            return this.Update(lexerRule);
        }
    
    
        public GrammarRuleAlt2Syntax Update(LexerRuleSyntax lexerRule)
        {
            if (this.LexerRule != lexerRule)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.GrammarRuleAlt2(lexerRule);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (GrammarRuleAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitGrammarRuleAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitGrammarRuleAlt2(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitGrammarRuleAlt2(this);
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleGreen)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleGreen)this.Green;
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
    
    public sealed class ElementValueAlt1Syntax : ElementValueSyntax
    {
        private BlockSyntax _block;
    
        public ElementValueAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ElementValueAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public BlockSyntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 0);
            return red;
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
    
        public ElementValueAlt1Syntax WithBlock(BlockSyntax block)
        {
            return this.Update(block);
        }
    
    
        public ElementValueAlt1Syntax Update(BlockSyntax block)
        {
            if (this.Block != block)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.ElementValueAlt1(block);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ElementValueAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitElementValueAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitElementValueAlt1(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitElementValueAlt1(this);
        }
    
    }
    public sealed class ElementValueAlt2Syntax : ElementValueSyntax
    {
        private Eof1Syntax _eof1;
    
        public ElementValueAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ElementValueAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public Eof1Syntax Eof1 
        { 
            get
            {
            var red = this.GetRed(ref this._eof1, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._eof1, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._eof1;
                default: return null;
            }
        }
    
        public ElementValueAlt2Syntax WithEof1(Eof1Syntax eof1)
        {
            return this.Update(eof1);
        }
    
    
        public ElementValueAlt2Syntax Update(Eof1Syntax eof1)
        {
            if (this.Eof1 != eof1)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.ElementValueAlt2(eof1);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ElementValueAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitElementValueAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitElementValueAlt2(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitElementValueAlt2(this);
        }
    
    }
    public sealed class ElementValueAlt3Syntax : ElementValueSyntax
    {
        private FixedSyntax _fixed;
    
        public ElementValueAlt3Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ElementValueAlt3Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public FixedSyntax Fixed 
        { 
            get
            {
            var red = this.GetRed(ref this._fixed, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._fixed, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._fixed;
                default: return null;
            }
        }
    
        public ElementValueAlt3Syntax WithFixed(FixedSyntax @fixed)
        {
            return this.Update(@fixed);
        }
    
    
        public ElementValueAlt3Syntax Update(FixedSyntax @fixed)
        {
            if (this.Fixed != @fixed)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.ElementValueAlt3(@fixed);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ElementValueAlt3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitElementValueAlt3(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitElementValueAlt3(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitElementValueAlt3(this);
        }
    
    }
    public sealed class ElementValueAlt4Syntax : ElementValueSyntax
    {
        private RuleRefSyntax _ruleRef;
    
        public ElementValueAlt4Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ElementValueAlt4Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public RuleRefSyntax RuleRef 
        { 
            get
            {
            var red = this.GetRed(ref this._ruleRef, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._ruleRef, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._ruleRef;
                default: return null;
            }
        }
    
        public ElementValueAlt4Syntax WithRuleRef(RuleRefSyntax ruleRef)
        {
            return this.Update(ruleRef);
        }
    
    
        public ElementValueAlt4Syntax Update(RuleRefSyntax ruleRef)
        {
            if (this.RuleRef != ruleRef)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.ElementValueAlt4(ruleRef);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ElementValueAlt4Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitElementValueAlt4(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitElementValueAlt4(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitElementValueAlt4(this);
        }
    
    }
    
    public sealed class BlockSyntax : CompilerSyntaxNode
    {
        private __SyntaxNode _annotations1;
        private __SyntaxNode _alternatives;
        private MultiplicitySyntax _multiplicity;
    
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
        public __SyntaxToken TLParen 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockGreen)this.Green;
            var greenToken = green.TLParen;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax> Alternatives 
        { 
            get
            {
            var red = this.GetRed(ref this._alternatives, 2);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax>(red, this.GetChildIndex(2), reversed: false);
            } 
        }
        public __SyntaxToken TRParen 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockGreen)this.Green;
            var greenToken = green.TRParen;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
            } 
        }
        public MultiplicitySyntax Multiplicity 
        { 
            get
            {
            var red = this.GetRed(ref this._multiplicity, 4);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._annotations1, 0);
                case 2: return this.GetRed(ref this._alternatives, 2);
                case 4: return this.GetRed(ref this._multiplicity, 4);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._annotations1;
                case 2: return this._alternatives;
                case 4: return this._multiplicity;
                default: return null;
            }
        }
    
        public BlockSyntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
        {
            return this.Update(annotations1, this.TLParen, this.Alternatives, this.TRParen, this.Multiplicity);
        }
    
        public BlockSyntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
        {
            return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
        }
    
        public BlockSyntax WithTLParen(__SyntaxToken tLParen)
        {
            return this.Update(this.Annotations1, tLParen, this.Alternatives, this.TRParen, this.Multiplicity);
        }
    
        public BlockSyntax WithAlternatives(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax> alternatives)
        {
            return this.Update(this.Annotations1, this.TLParen, alternatives, this.TRParen, this.Multiplicity);
        }
    
        public BlockSyntax AddAlternatives(params BlockAlternativeSyntax[] alternatives)
        {
            return this.WithAlternatives(this.Alternatives.AddRange(alternatives));
        }
    
        public BlockSyntax WithTRParen(__SyntaxToken tRParen)
        {
            return this.Update(this.Annotations1, this.TLParen, this.Alternatives, tRParen, this.Multiplicity);
        }
    
        public BlockSyntax WithMultiplicity(MultiplicitySyntax multiplicity)
        {
            return this.Update(this.Annotations1, this.TLParen, this.Alternatives, this.TRParen, multiplicity);
        }
    
    
        public BlockSyntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax> alternatives, __SyntaxToken tRParen, MultiplicitySyntax multiplicity)
        {
            if (this.Annotations1 != annotations1 || this.TLParen != tLParen || this.Alternatives != alternatives || this.TRParen != tRParen || this.Multiplicity != multiplicity)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.Block(annotations1, tLParen, alternatives, tRParen, multiplicity);
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
    public abstract class RuleRefSyntax : CompilerSyntaxNode
    {
        protected RuleRefSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected RuleRefSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    
    public sealed class RuleRefAlt1Syntax : RuleRefSyntax
    {
        private __SyntaxNode _annotations1;
        private IdentifierSyntax _grammarRule;
        private MultiplicitySyntax _multiplicity;
    
        public RuleRefAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public RuleRefAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
        public IdentifierSyntax GrammarRule 
        { 
            get
            {
            var red = this.GetRed(ref this._grammarRule, 1);
            return red;
            } 
        }
        public MultiplicitySyntax Multiplicity 
        { 
            get
            {
            var red = this.GetRed(ref this._multiplicity, 2);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._annotations1, 0);
                case 1: return this.GetRed(ref this._grammarRule, 1);
                case 2: return this.GetRed(ref this._multiplicity, 2);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._annotations1;
                case 1: return this._grammarRule;
                case 2: return this._multiplicity;
                default: return null;
            }
        }
    
        public RuleRefAlt1Syntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
        {
            return this.Update(annotations1, this.GrammarRule, this.Multiplicity);
        }
    
        public RuleRefAlt1Syntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
        {
            return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
        }
    
        public RuleRefAlt1Syntax WithGrammarRule(IdentifierSyntax grammarRule)
        {
            return this.Update(this.Annotations1, grammarRule, this.Multiplicity);
        }
    
        public RuleRefAlt1Syntax WithMultiplicity(MultiplicitySyntax multiplicity)
        {
            return this.Update(this.Annotations1, this.GrammarRule, multiplicity);
        }
    
    
        public RuleRefAlt1Syntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, IdentifierSyntax grammarRule, MultiplicitySyntax multiplicity)
        {
            if (this.Annotations1 != annotations1 || this.GrammarRule != grammarRule || this.Multiplicity != multiplicity)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleRefAlt1(annotations1, grammarRule, multiplicity);
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
    public sealed class RuleRefAlt2Syntax : RuleRefSyntax
    {
        private __SyntaxNode _annotations1;
        private TypeReferenceSyntax _referencedTypes;
        private MultiplicitySyntax _multiplicity;
    
        public RuleRefAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public RuleRefAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
        public __SyntaxToken THash 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleRefAlt2Green)this.Green;
            var greenToken = green.THash;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
            } 
        }
        public TypeReferenceSyntax ReferencedTypes 
        { 
            get
            {
            var red = this.GetRed(ref this._referencedTypes, 2);
            return red;
            } 
        }
        public MultiplicitySyntax Multiplicity 
        { 
            get
            {
            var red = this.GetRed(ref this._multiplicity, 3);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._annotations1, 0);
                case 2: return this.GetRed(ref this._referencedTypes, 2);
                case 3: return this.GetRed(ref this._multiplicity, 3);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._annotations1;
                case 2: return this._referencedTypes;
                case 3: return this._multiplicity;
                default: return null;
            }
        }
    
        public RuleRefAlt2Syntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
        {
            return this.Update(annotations1, this.THash, this.ReferencedTypes, this.Multiplicity);
        }
    
        public RuleRefAlt2Syntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
        {
            return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
        }
    
        public RuleRefAlt2Syntax WithTHash(__SyntaxToken tHash)
        {
            return this.Update(this.Annotations1, tHash, this.ReferencedTypes, this.Multiplicity);
        }
    
        public RuleRefAlt2Syntax WithReferencedTypes(TypeReferenceSyntax referencedTypes)
        {
            return this.Update(this.Annotations1, this.THash, referencedTypes, this.Multiplicity);
        }
    
        public RuleRefAlt2Syntax WithMultiplicity(MultiplicitySyntax multiplicity)
        {
            return this.Update(this.Annotations1, this.THash, this.ReferencedTypes, multiplicity);
        }
    
    
        public RuleRefAlt2Syntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken tHash, TypeReferenceSyntax referencedTypes, MultiplicitySyntax multiplicity)
        {
            if (this.Annotations1 != annotations1 || this.THash != tHash || this.ReferencedTypes != referencedTypes || this.Multiplicity != multiplicity)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleRefAlt2(annotations1, tHash, referencedTypes, multiplicity);
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
    public sealed class RuleRefAlt3Syntax : RuleRefSyntax
    {
        private __SyntaxNode _annotations1;
        private __SyntaxNode _referencedTypes;
        private RuleRefAlt3Block1Syntax _block;
        private MultiplicitySyntax _multiplicity;
    
        public RuleRefAlt3Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public RuleRefAlt3Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
        public __SyntaxToken THashLBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleRefAlt3Green)this.Green;
            var greenToken = green.THashLBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax> ReferencedTypes 
        { 
            get
            {
            var red = this.GetRed(ref this._referencedTypes, 2);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax>(red, this.GetChildIndex(2), reversed: false);
            } 
        }
        public RuleRefAlt3Block1Syntax Block 
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleRefAlt3Green)this.Green;
            var greenToken = green.TRBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(4), this.GetChildIndex(4));
            } 
        }
        public MultiplicitySyntax Multiplicity 
        { 
            get
            {
            var red = this.GetRed(ref this._multiplicity, 5);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._annotations1, 0);
                case 2: return this.GetRed(ref this._referencedTypes, 2);
                case 3: return this.GetRed(ref this._block, 3);
                case 5: return this.GetRed(ref this._multiplicity, 5);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._annotations1;
                case 2: return this._referencedTypes;
                case 3: return this._block;
                case 5: return this._multiplicity;
                default: return null;
            }
        }
    
        public RuleRefAlt3Syntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
        {
            return this.Update(annotations1, this.THashLBrace, this.ReferencedTypes, this.Block, this.TRBrace, this.Multiplicity);
        }
    
        public RuleRefAlt3Syntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
        {
            return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
        }
    
        public RuleRefAlt3Syntax WithTHashLBrace(__SyntaxToken tHashLBrace)
        {
            return this.Update(this.Annotations1, tHashLBrace, this.ReferencedTypes, this.Block, this.TRBrace, this.Multiplicity);
        }
    
        public RuleRefAlt3Syntax WithReferencedTypes(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax> referencedTypes)
        {
            return this.Update(this.Annotations1, this.THashLBrace, referencedTypes, this.Block, this.TRBrace, this.Multiplicity);
        }
    
        public RuleRefAlt3Syntax AddReferencedTypes(params TypeReferenceSyntax[] referencedTypes)
        {
            return this.WithReferencedTypes(this.ReferencedTypes.AddRange(referencedTypes));
        }
    
        public RuleRefAlt3Syntax WithBlock(RuleRefAlt3Block1Syntax block)
        {
            return this.Update(this.Annotations1, this.THashLBrace, this.ReferencedTypes, block, this.TRBrace, this.Multiplicity);
        }
    
        public RuleRefAlt3Syntax WithTRBrace(__SyntaxToken tRBrace)
        {
            return this.Update(this.Annotations1, this.THashLBrace, this.ReferencedTypes, this.Block, tRBrace, this.Multiplicity);
        }
    
        public RuleRefAlt3Syntax WithMultiplicity(MultiplicitySyntax multiplicity)
        {
            return this.Update(this.Annotations1, this.THashLBrace, this.ReferencedTypes, this.Block, this.TRBrace, multiplicity);
        }
    
    
        public RuleRefAlt3Syntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken tHashLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax> referencedTypes, RuleRefAlt3Block1Syntax block, __SyntaxToken tRBrace, MultiplicitySyntax multiplicity)
        {
            if (this.Annotations1 != annotations1 || this.THashLBrace != tHashLBrace || this.ReferencedTypes != referencedTypes || this.Block != block || this.TRBrace != tRBrace || this.Multiplicity != multiplicity)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleRefAlt3(annotations1, tHashLBrace, referencedTypes, block, tRBrace, multiplicity);
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
    
    public sealed class Eof1Syntax : CompilerSyntaxNode
    {
    
        public Eof1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public Eof1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KEof 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.Eof1Green)this.Green;
            var greenToken = green.KEof;
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
    
        public Eof1Syntax WithKEof(__SyntaxToken kEof)
        {
            return this.Update(kEof);
        }
    
    
        public Eof1Syntax Update(__SyntaxToken kEof)
        {
            if (this.KEof != kEof)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.Eof1(kEof);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (Eof1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitEof1(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitEof1(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitEof1(this);
        }
    
    }
    
    public sealed class FixedSyntax : CompilerSyntaxNode
    {
        private __SyntaxNode _annotations1;
        private MultiplicitySyntax _multiplicity;
    
        public FixedSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public FixedSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
        public __SyntaxToken Text 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.FixedGreen)this.Green;
            var greenToken = green.Text;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
            } 
        }
        public MultiplicitySyntax Multiplicity 
        { 
            get
            {
            var red = this.GetRed(ref this._multiplicity, 2);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._annotations1, 0);
                case 2: return this.GetRed(ref this._multiplicity, 2);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._annotations1;
                case 2: return this._multiplicity;
                default: return null;
            }
        }
    
        public FixedSyntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
        {
            return this.Update(annotations1, this.Text, this.Multiplicity);
        }
    
        public FixedSyntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
        {
            return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
        }
    
        public FixedSyntax WithText(__SyntaxToken text)
        {
            return this.Update(this.Annotations1, text, this.Multiplicity);
        }
    
        public FixedSyntax WithMultiplicity(MultiplicitySyntax multiplicity)
        {
            return this.Update(this.Annotations1, this.Text, multiplicity);
        }
    
    
        public FixedSyntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken text, MultiplicitySyntax multiplicity)
        {
            if (this.Annotations1 != annotations1 || this.Text != text || this.Multiplicity != multiplicity)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.Fixed(annotations1, text, multiplicity);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (FixedSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitFixed(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitFixed(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitFixed(this);
        }
    
    }
    public abstract class LexerRuleSyntax : CompilerSyntaxNode
    {
        protected LexerRuleSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected LexerRuleSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    
    public sealed class LexerRuleAlt1Syntax : LexerRuleSyntax
    {
        private TokenSyntax _token;
    
        public LexerRuleAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LexerRuleAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public TokenSyntax Token 
        { 
            get
            {
            var red = this.GetRed(ref this._token, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._token, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._token;
                default: return null;
            }
        }
    
        public LexerRuleAlt1Syntax WithToken(TokenSyntax token)
        {
            return this.Update(token);
        }
    
    
        public LexerRuleAlt1Syntax Update(TokenSyntax token)
        {
            if (this.Token != token)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerRuleAlt1(token);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (LexerRuleAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitLexerRuleAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitLexerRuleAlt1(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitLexerRuleAlt1(this);
        }
    
    }
    public sealed class LexerRuleAlt2Syntax : LexerRuleSyntax
    {
        private FragmentSyntax _fragment;
    
        public LexerRuleAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LexerRuleAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public FragmentSyntax Fragment 
        { 
            get
            {
            var red = this.GetRed(ref this._fragment, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._fragment, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._fragment;
                default: return null;
            }
        }
    
        public LexerRuleAlt2Syntax WithFragment(FragmentSyntax fragment)
        {
            return this.Update(fragment);
        }
    
    
        public LexerRuleAlt2Syntax Update(FragmentSyntax fragment)
        {
            if (this.Fragment != fragment)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerRuleAlt2(fragment);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (LexerRuleAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitLexerRuleAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitLexerRuleAlt2(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitLexerRuleAlt2(this);
        }
    
    }
    
    public sealed class TokenSyntax : CompilerSyntaxNode
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenGreen)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenGreen)this.Green;
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
    
    public sealed class FragmentSyntax : CompilerSyntaxNode
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.FragmentGreen)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.FragmentGreen)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.FragmentGreen)this.Green;
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
        private MultiplicitySyntax _multiplicity;
    
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LElementGreen)this.Green;
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
        public MultiplicitySyntax Multiplicity 
        { 
            get
            {
            var red = this.GetRed(ref this._multiplicity, 2);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._value, 1);
                case 2: return this.GetRed(ref this._multiplicity, 2);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._value;
                case 2: return this._multiplicity;
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
    
        public LElementSyntax WithMultiplicity(MultiplicitySyntax multiplicity)
        {
            return this.Update(this.IsNegated, this.Value, multiplicity);
        }
    
    
        public LElementSyntax Update(__SyntaxToken isNegated, LElementValueSyntax value, MultiplicitySyntax multiplicity)
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
    
    public sealed class LElementValueAlt1Syntax : LElementValueSyntax
    {
        private LBlockSyntax _lBlock;
    
        public LElementValueAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LElementValueAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public LBlockSyntax LBlock 
        { 
            get
            {
            var red = this.GetRed(ref this._lBlock, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._lBlock, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._lBlock;
                default: return null;
            }
        }
    
        public LElementValueAlt1Syntax WithLBlock(LBlockSyntax lBlock)
        {
            return this.Update(lBlock);
        }
    
    
        public LElementValueAlt1Syntax Update(LBlockSyntax lBlock)
        {
            if (this.LBlock != lBlock)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LElementValueAlt1(lBlock);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (LElementValueAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitLElementValueAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitLElementValueAlt1(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitLElementValueAlt1(this);
        }
    
    }
    public sealed class LElementValueAlt2Syntax : LElementValueSyntax
    {
        private LFixedSyntax _lFixed;
    
        public LElementValueAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LElementValueAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public LFixedSyntax LFixed 
        { 
            get
            {
            var red = this.GetRed(ref this._lFixed, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._lFixed, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._lFixed;
                default: return null;
            }
        }
    
        public LElementValueAlt2Syntax WithLFixed(LFixedSyntax lFixed)
        {
            return this.Update(lFixed);
        }
    
    
        public LElementValueAlt2Syntax Update(LFixedSyntax lFixed)
        {
            if (this.LFixed != lFixed)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LElementValueAlt2(lFixed);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (LElementValueAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitLElementValueAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitLElementValueAlt2(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitLElementValueAlt2(this);
        }
    
    }
    public sealed class LElementValueAlt3Syntax : LElementValueSyntax
    {
        private LWildCardSyntax _lWildCard;
    
        public LElementValueAlt3Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LElementValueAlt3Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public LWildCardSyntax LWildCard 
        { 
            get
            {
            var red = this.GetRed(ref this._lWildCard, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._lWildCard, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._lWildCard;
                default: return null;
            }
        }
    
        public LElementValueAlt3Syntax WithLWildCard(LWildCardSyntax lWildCard)
        {
            return this.Update(lWildCard);
        }
    
    
        public LElementValueAlt3Syntax Update(LWildCardSyntax lWildCard)
        {
            if (this.LWildCard != lWildCard)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LElementValueAlt3(lWildCard);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (LElementValueAlt3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitLElementValueAlt3(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitLElementValueAlt3(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitLElementValueAlt3(this);
        }
    
    }
    public sealed class LElementValueAlt4Syntax : LElementValueSyntax
    {
        private LRangeSyntax _lRange;
    
        public LElementValueAlt4Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LElementValueAlt4Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public LRangeSyntax LRange 
        { 
            get
            {
            var red = this.GetRed(ref this._lRange, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._lRange, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._lRange;
                default: return null;
            }
        }
    
        public LElementValueAlt4Syntax WithLRange(LRangeSyntax lRange)
        {
            return this.Update(lRange);
        }
    
    
        public LElementValueAlt4Syntax Update(LRangeSyntax lRange)
        {
            if (this.LRange != lRange)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LElementValueAlt4(lRange);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (LElementValueAlt4Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitLElementValueAlt4(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitLElementValueAlt4(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitLElementValueAlt4(this);
        }
    
    }
    public sealed class LElementValueAlt5Syntax : LElementValueSyntax
    {
        private LReferenceSyntax _lReference;
    
        public LElementValueAlt5Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LElementValueAlt5Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public LReferenceSyntax LReference 
        { 
            get
            {
            var red = this.GetRed(ref this._lReference, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._lReference, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._lReference;
                default: return null;
            }
        }
    
        public LElementValueAlt5Syntax WithLReference(LReferenceSyntax lReference)
        {
            return this.Update(lReference);
        }
    
    
        public LElementValueAlt5Syntax Update(LReferenceSyntax lReference)
        {
            if (this.LReference != lReference)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LElementValueAlt5(lReference);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (LElementValueAlt5Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitLElementValueAlt5(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitLElementValueAlt5(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitLElementValueAlt5(this);
        }
    
    }
    
    public sealed class LReferenceSyntax : CompilerSyntaxNode
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
    
    public sealed class LFixedSyntax : CompilerSyntaxNode
    {
    
        public LFixedSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LFixedSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken Text 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LFixedGreen)this.Green;
            var greenToken = green.Text;
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
    
        public LFixedSyntax WithText(__SyntaxToken text)
        {
            return this.Update(text);
        }
    
    
        public LFixedSyntax Update(__SyntaxToken text)
        {
            if (this.Text != text)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LFixed(text);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
    
    public sealed class LWildCardSyntax : CompilerSyntaxNode
    {
    
        public LWildCardSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LWildCardSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TDot 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LWildCardGreen)this.Green;
            var greenToken = green.TDot;
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
    
        public LWildCardSyntax WithTDot(__SyntaxToken tDot)
        {
            return this.Update(tDot);
        }
    
    
        public LWildCardSyntax Update(__SyntaxToken tDot)
        {
            if (this.TDot != tDot)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LWildCard(tDot);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
    
    public sealed class LRangeSyntax : CompilerSyntaxNode
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LRangeGreen)this.Green;
            var greenToken = green.StartChar;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public __SyntaxToken TDotDot 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LRangeGreen)this.Green;
            var greenToken = green.TDotDot;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
            } 
        }
        public __SyntaxToken EndChar 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LRangeGreen)this.Green;
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
    
    public sealed class LBlockSyntax : CompilerSyntaxNode
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LBlockGreen)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LBlockGreen)this.Green;
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
    public sealed class ExpressionAlt2Syntax : ExpressionSyntax
    {
        private ArrayExpressionSyntax _arrayExpression;
    
        public ExpressionAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ExpressionAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public ArrayExpressionSyntax ArrayExpression 
        { 
            get
            {
            var red = this.GetRed(ref this._arrayExpression, 0);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._arrayExpression, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._arrayExpression;
                default: return null;
            }
        }
    
        public ExpressionAlt2Syntax WithArrayExpression(ArrayExpressionSyntax arrayExpression)
        {
            return this.Update(arrayExpression);
        }
    
    
        public ExpressionAlt2Syntax Update(ArrayExpressionSyntax arrayExpression)
        {
            if (this.ArrayExpression != arrayExpression)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.ExpressionAlt2(arrayExpression);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ExpressionAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitExpressionAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitExpressionAlt2(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitExpressionAlt2(this);
        }
    
    }
    public abstract class SingleExpressionSyntax : CompilerSyntaxNode
    {
        protected SingleExpressionSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected SingleExpressionSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    
    public sealed class SingleExpressionAlt1Syntax : SingleExpressionSyntax
    {
        private SingleExpressionAlt1Block1Syntax _value;
    
        public SingleExpressionAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SingleExpressionAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public SingleExpressionAlt1Block1Syntax Value 
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
    
        public SingleExpressionAlt1Syntax WithValue(SingleExpressionAlt1Block1Syntax value)
        {
            return this.Update(value);
        }
    
    
        public SingleExpressionAlt1Syntax Update(SingleExpressionAlt1Block1Syntax value)
        {
            if (this.Value != value)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionAlt1(value);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SingleExpressionAlt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSingleExpressionAlt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSingleExpressionAlt1(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitSingleExpressionAlt1(this);
        }
    
    }
    public sealed class SingleExpressionAlt2Syntax : SingleExpressionSyntax
    {
        private QualifierSyntax _value;
    
        public SingleExpressionAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SingleExpressionAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public QualifierSyntax Value 
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
    
        public SingleExpressionAlt2Syntax WithValue(QualifierSyntax value)
        {
            return this.Update(value);
        }
    
    
        public SingleExpressionAlt2Syntax Update(QualifierSyntax value)
        {
            if (this.Value != value)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionAlt2(value);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SingleExpressionAlt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSingleExpressionAlt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSingleExpressionAlt2(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitSingleExpressionAlt2(this);
        }
    
    }
    
    public sealed class ArrayExpressionSyntax : CompilerSyntaxNode
    {
        private ArrayExpressionBlock1Syntax _block;
    
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.ArrayExpressionGreen)this.Green;
            var greenToken = green.TLBrace;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public ArrayExpressionBlock1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 1);
            return red;
            } 
        }
        public __SyntaxToken TRBrace 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.ArrayExpressionGreen)this.Green;
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
    
        public ArrayExpressionSyntax WithTLBrace(__SyntaxToken tLBrace)
        {
            return this.Update(tLBrace, this.Block, this.TRBrace);
        }
    
        public ArrayExpressionSyntax WithBlock(ArrayExpressionBlock1Syntax block)
        {
            return this.Update(this.TLBrace, block, this.TRBrace);
        }
    
        public ArrayExpressionSyntax WithTRBrace(__SyntaxToken tRBrace)
        {
            return this.Update(this.TLBrace, this.Block, tRBrace);
        }
    
    
        public ArrayExpressionSyntax Update(__SyntaxToken tLBrace, ArrayExpressionBlock1Syntax block, __SyntaxToken tRBrace)
        {
            if (this.TLBrace != tLBrace || this.Block != block || this.TRBrace != tRBrace)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.ArrayExpression(tLBrace, block, tRBrace);
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
    
    public sealed class ParserAnnotationSyntax : CompilerSyntaxNode
    {
        private QualifierSyntax _attributeClass;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationGreen)this.Green;
            var greenToken = green.TLBracket;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public QualifierSyntax AttributeClass 
        { 
            get
            {
            var red = this.GetRed(ref this._attributeClass, 1);
            return red;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationGreen)this.Green;
            var greenToken = green.TRBracket;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._attributeClass, 1);
                case 2: return this.GetRed(ref this._block, 2);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._attributeClass;
                case 2: return this._block;
                default: return null;
            }
        }
    
        public ParserAnnotationSyntax WithTLBracket(__SyntaxToken tLBracket)
        {
            return this.Update(tLBracket, this.AttributeClass, this.Block, this.TRBracket);
        }
    
        public ParserAnnotationSyntax WithAttributeClass(QualifierSyntax attributeClass)
        {
            return this.Update(this.TLBracket, attributeClass, this.Block, this.TRBracket);
        }
    
        public ParserAnnotationSyntax WithBlock(ParserAnnotationBlock1Syntax block)
        {
            return this.Update(this.TLBracket, this.AttributeClass, block, this.TRBracket);
        }
    
        public ParserAnnotationSyntax WithTRBracket(__SyntaxToken tRBracket)
        {
            return this.Update(this.TLBracket, this.AttributeClass, this.Block, tRBracket);
        }
    
    
        public ParserAnnotationSyntax Update(__SyntaxToken tLBracket, QualifierSyntax attributeClass, ParserAnnotationBlock1Syntax block, __SyntaxToken tRBracket)
        {
            if (this.TLBracket != tLBracket || this.AttributeClass != attributeClass || this.Block != block || this.TRBracket != tRBracket)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserAnnotation(tLBracket, attributeClass, block, tRBracket);
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
        private QualifierSyntax _attributeClass;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationGreen)this.Green;
            var greenToken = green.TLBracket;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public QualifierSyntax AttributeClass 
        { 
            get
            {
            var red = this.GetRed(ref this._attributeClass, 1);
            return red;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationGreen)this.Green;
            var greenToken = green.TRBracket;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._attributeClass, 1);
                case 2: return this.GetRed(ref this._block, 2);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._attributeClass;
                case 2: return this._block;
                default: return null;
            }
        }
    
        public LexerAnnotationSyntax WithTLBracket(__SyntaxToken tLBracket)
        {
            return this.Update(tLBracket, this.AttributeClass, this.Block, this.TRBracket);
        }
    
        public LexerAnnotationSyntax WithAttributeClass(QualifierSyntax attributeClass)
        {
            return this.Update(this.TLBracket, attributeClass, this.Block, this.TRBracket);
        }
    
        public LexerAnnotationSyntax WithBlock(LexerAnnotationBlock1Syntax block)
        {
            return this.Update(this.TLBracket, this.AttributeClass, block, this.TRBracket);
        }
    
        public LexerAnnotationSyntax WithTRBracket(__SyntaxToken tRBracket)
        {
            return this.Update(this.TLBracket, this.AttributeClass, this.Block, tRBracket);
        }
    
    
        public LexerAnnotationSyntax Update(__SyntaxToken tLBracket, QualifierSyntax attributeClass, LexerAnnotationBlock1Syntax block, __SyntaxToken tRBracket)
        {
            if (this.TLBracket != tLBracket || this.AttributeClass != attributeClass || this.Block != block || this.TRBracket != tRBracket)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerAnnotation(tLBracket, attributeClass, block, tRBracket);
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
    
    public sealed class AssignmentSyntax : CompilerSyntaxNode
    {
    
        public AssignmentSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public AssignmentSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken Token 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.AssignmentGreen)this.Green;
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
    
        public AssignmentSyntax WithToken(__SyntaxToken token)
        {
            return this.Update(token);
        }
    
    
        public AssignmentSyntax Update(__SyntaxToken token)
        {
            if (this.Token != token)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.Assignment(token);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (AssignmentSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitAssignment(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitAssignment(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitAssignment(this);
        }
    
    }
    
    public sealed class MultiplicitySyntax : CompilerSyntaxNode
    {
    
        public MultiplicitySyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MultiplicitySyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken Token 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.MultiplicityGreen)this.Green;
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
    
        public MultiplicitySyntax WithToken(__SyntaxToken token)
        {
            return this.Update(token);
        }
    
    
        public MultiplicitySyntax Update(__SyntaxToken token)
        {
            if (this.Token != token)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.Multiplicity(token);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MultiplicitySyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMultiplicity(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMultiplicity(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitMultiplicity(this);
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
        private PrimitiveTypeSyntax _primitiveType;
    
        public TypeReferenceIdentifierAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public TypeReferenceIdentifierAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
    
        public TypeReferenceIdentifierAlt1Syntax WithPrimitiveType(PrimitiveTypeSyntax primitiveType)
        {
            return this.Update(primitiveType);
        }
    
    
        public TypeReferenceIdentifierAlt1Syntax Update(PrimitiveTypeSyntax primitiveType)
        {
            if (this.PrimitiveType != primitiveType)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.TypeReferenceIdentifierAlt1(primitiveType);
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
        private PrimitiveTypeSyntax _primitiveType;
    
        public TypeReferenceAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public TypeReferenceAlt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
                var newNode = CompilerLanguage.Instance.SyntaxFactory.TypeReferenceAlt1(primitiveType);
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
        private QualifierSyntax _qualifier;
    
        public TypeReferenceAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public TypeReferenceAlt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
    
    public sealed class PrimitiveTypeSyntax : CompilerSyntaxNode
    {
    
        public PrimitiveTypeSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public PrimitiveTypeSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken Token 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.PrimitiveTypeGreen)this.Green;
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
                var newNode = CompilerLanguage.Instance.SyntaxFactory.PrimitiveType(token);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (PrimitiveTypeSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitPrimitiveType(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitPrimitiveType(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitPrimitiveType(this);
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
    
    public sealed class QualifierSyntax : CompilerSyntaxNode
    {
        private __SyntaxNode _identifier;
    
        public QualifierSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public QualifierSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
                var newNode = CompilerLanguage.Instance.SyntaxFactory.Qualifier(identifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.IdentifierGreen)this.Green;
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
        private UsingSyntax _using;
    
        public MainBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MainBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KUsing 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.MainBlock1Green)this.Green;
            var greenToken = green.KUsing;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public UsingSyntax Using 
        { 
            get
            {
            var red = this.GetRed(ref this._using, 1);
            return red;
            } 
        }
        public __SyntaxToken TSemicolon 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.MainBlock1Green)this.Green;
            var greenToken = green.TSemicolon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._using, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._using;
                default: return null;
            }
        }
    
        public MainBlock1Syntax WithKUsing(__SyntaxToken kUsing)
        {
            return this.Update(kUsing, this.Using, this.TSemicolon);
        }
    
        public MainBlock1Syntax WithUsing(UsingSyntax @using)
        {
            return this.Update(this.KUsing, @using, this.TSemicolon);
        }
    
        public MainBlock1Syntax WithTSemicolon(__SyntaxToken tSemicolon)
        {
            return this.Update(this.KUsing, this.Using, tSemicolon);
        }
    
    
        public MainBlock1Syntax Update(__SyntaxToken kUsing, UsingSyntax @using, __SyntaxToken tSemicolon)
        {
            if (this.KUsing != kUsing || this.Using != @using || this.TSemicolon != tSemicolon)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.MainBlock1(kUsing, @using, tSemicolon);
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
    
    public sealed class MainBlock2Syntax : CompilerSyntaxNode
    {
        private LanguageDeclarationSyntax _declarations;
    
        public MainBlock2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public MainBlock2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
    
        public MainBlock2Syntax WithDeclarations(LanguageDeclarationSyntax declarations)
        {
            return this.Update(declarations);
        }
    
    
        public MainBlock2Syntax Update(LanguageDeclarationSyntax declarations)
        {
            if (this.Declarations != declarations)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.MainBlock2(declarations);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (MainBlock2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitMainBlock2(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitMainBlock2(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitMainBlock2(this);
        }
    
    }
    
    public sealed class LanguageDeclarationBlock1Syntax : CompilerSyntaxNode
    {
        private __SyntaxNode _baseLanguages;
    
        public LanguageDeclarationBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LanguageDeclarationBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TColon 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LanguageDeclarationBlock1Green)this.Green;
            var greenToken = green.TColon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> BaseLanguages 
        { 
            get
            {
            var red = this.GetRed(ref this._baseLanguages, 1);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax>(red, this.GetChildIndex(1), reversed: false);
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._baseLanguages, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._baseLanguages;
                default: return null;
            }
        }
    
        public LanguageDeclarationBlock1Syntax WithTColon(__SyntaxToken tColon)
        {
            return this.Update(tColon, this.BaseLanguages);
        }
    
        public LanguageDeclarationBlock1Syntax WithBaseLanguages(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> baseLanguages)
        {
            return this.Update(this.TColon, baseLanguages);
        }
    
        public LanguageDeclarationBlock1Syntax AddBaseLanguages(params QualifierSyntax[] baseLanguages)
        {
            return this.WithBaseLanguages(this.BaseLanguages.AddRange(baseLanguages));
        }
    
    
        public LanguageDeclarationBlock1Syntax Update(__SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> baseLanguages)
        {
            if (this.TColon != tColon || this.BaseLanguages != baseLanguages)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LanguageDeclarationBlock1(tColon, baseLanguages);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (LanguageDeclarationBlock1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitLanguageDeclarationBlock1(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitLanguageDeclarationBlock1(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitLanguageDeclarationBlock1(this);
        }
    
    }
    
    public sealed class LanguageDeclarationBlock1baseLanguagesBlockSyntax : CompilerSyntaxNode
    {
        private QualifierSyntax _baseLanguages;
    
        public LanguageDeclarationBlock1baseLanguagesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LanguageDeclarationBlock1baseLanguagesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LanguageDeclarationBlock1baseLanguagesBlockGreen)this.Green;
            var greenToken = green.TComma;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
            } 
        }
        public QualifierSyntax BaseLanguages 
        { 
            get
            {
            var red = this.GetRed(ref this._baseLanguages, 1);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 1: return this.GetRed(ref this._baseLanguages, 1);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 1: return this._baseLanguages;
                default: return null;
            }
        }
    
        public LanguageDeclarationBlock1baseLanguagesBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.BaseLanguages);
        }
    
        public LanguageDeclarationBlock1baseLanguagesBlockSyntax WithBaseLanguages(QualifierSyntax baseLanguages)
        {
            return this.Update(this.TComma, baseLanguages);
        }
    
    
        public LanguageDeclarationBlock1baseLanguagesBlockSyntax Update(__SyntaxToken tComma, QualifierSyntax baseLanguages)
        {
            if (this.TComma != tComma || this.BaseLanguages != baseLanguages)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LanguageDeclarationBlock1baseLanguagesBlock(tComma, baseLanguages);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (LanguageDeclarationBlock1baseLanguagesBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitLanguageDeclarationBlock1baseLanguagesBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitLanguageDeclarationBlock1baseLanguagesBlock(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitLanguageDeclarationBlock1baseLanguagesBlock(this);
        }
    
    }
    
    public sealed class GrammarBlock1Syntax : CompilerSyntaxNode
    {
        private __SyntaxNode _grammarRules;
    
        public GrammarBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public GrammarBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
    
        public GrammarBlock1Syntax WithGrammarRules(global::MetaDslx.CodeAnalysis.SyntaxList<GrammarRuleSyntax> grammarRules)
        {
            return this.Update(grammarRules);
        }
    
        public GrammarBlock1Syntax AddGrammarRules(params GrammarRuleSyntax[] grammarRules)
        {
            return this.WithGrammarRules(this.GrammarRules.AddRange(grammarRules));
        }
    
    
        public GrammarBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<GrammarRuleSyntax> grammarRules)
        {
            if (this.GrammarRules != grammarRules)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.GrammarBlock1(grammarRules);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleBlock1Alt2Green)this.Green;
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
    
    public sealed class RulealternativesBlockSyntax : CompilerSyntaxNode
    {
        private AlternativeSyntax _alternatives;
    
        public RulealternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public RulealternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TBar 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.RulealternativesBlockGreen)this.Green;
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
    
        public RulealternativesBlockSyntax WithTBar(__SyntaxToken tBar)
        {
            return this.Update(tBar, this.Alternatives);
        }
    
        public RulealternativesBlockSyntax WithAlternatives(AlternativeSyntax alternatives)
        {
            return this.Update(this.TBar, alternatives);
        }
    
    
        public RulealternativesBlockSyntax Update(__SyntaxToken tBar, AlternativeSyntax alternatives)
        {
            if (this.TBar != tBar || this.Alternatives != alternatives)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.RulealternativesBlock(tBar, alternatives);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (RulealternativesBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitRulealternativesBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitRulealternativesBlock(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitRulealternativesBlock(this);
        }
    
    }
    
    public sealed class AlternativeBlock1Syntax : CompilerSyntaxNode
    {
        private __SyntaxNode _annotations1;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.AlternativeBlock1Green)this.Green;
            var greenToken = green.KAlt;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
            } 
        }
        public AlternativeBlock1Block1Syntax Block 
        { 
            get
            {
            var red = this.GetRed(ref this._block, 2);
            return red;
            } 
        }
        public __SyntaxToken TColon 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.AlternativeBlock1Green)this.Green;
            var greenToken = green.TColon;
            return new __SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._annotations1, 0);
                case 2: return this.GetRed(ref this._block, 2);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._annotations1;
                case 2: return this._block;
                default: return null;
            }
        }
    
        public AlternativeBlock1Syntax WithAnnotations1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1)
        {
            return this.Update(annotations1, this.KAlt, this.Block, this.TColon);
        }
    
        public AlternativeBlock1Syntax AddAnnotations1(params ParserAnnotationSyntax[] annotations1)
        {
            return this.WithAnnotations1(this.Annotations1.AddRange(annotations1));
        }
    
        public AlternativeBlock1Syntax WithKAlt(__SyntaxToken kAlt)
        {
            return this.Update(this.Annotations1, kAlt, this.Block, this.TColon);
        }
    
        public AlternativeBlock1Syntax WithBlock(AlternativeBlock1Block1Syntax block)
        {
            return this.Update(this.Annotations1, this.KAlt, block, this.TColon);
        }
    
        public AlternativeBlock1Syntax WithTColon(__SyntaxToken tColon)
        {
            return this.Update(this.Annotations1, this.KAlt, this.Block, tColon);
        }
    
    
        public AlternativeBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken kAlt, AlternativeBlock1Block1Syntax block, __SyntaxToken tColon)
        {
            if (this.Annotations1 != annotations1 || this.KAlt != kAlt || this.Block != block || this.TColon != tColon)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.AlternativeBlock1(annotations1, kAlt, block, tColon);
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
    public abstract class AlternativeBlock1Block1Syntax : CompilerSyntaxNode
    {
        protected AlternativeBlock1Block1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected AlternativeBlock1Block1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    
    public sealed class AlternativeBlock1Block1Alt1Syntax : AlternativeBlock1Block1Syntax
    {
        private TypeReferenceIdentifierSyntax _returnType;
    
        public AlternativeBlock1Block1Alt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public AlternativeBlock1Block1Alt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
    
        public AlternativeBlock1Block1Alt1Syntax WithReturnType(TypeReferenceIdentifierSyntax returnType)
        {
            return this.Update(returnType);
        }
    
    
        public AlternativeBlock1Block1Alt1Syntax Update(TypeReferenceIdentifierSyntax returnType)
        {
            if (this.ReturnType != returnType)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.AlternativeBlock1Block1Alt1(returnType);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (AlternativeBlock1Block1Alt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitAlternativeBlock1Block1Alt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitAlternativeBlock1Block1Alt1(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitAlternativeBlock1Block1Alt1(this);
        }
    
    }
    public sealed class AlternativeBlock1Block1Alt2Syntax : AlternativeBlock1Block1Syntax
    {
        private IdentifierSyntax _identifier;
        private TypeReferenceSyntax _returnType;
    
        public AlternativeBlock1Block1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public AlternativeBlock1Block1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.AlternativeBlock1Block1Alt2Green)this.Green;
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
    
        public AlternativeBlock1Block1Alt2Syntax WithIdentifier(IdentifierSyntax identifier)
        {
            return this.Update(identifier, this.KReturns, this.ReturnType);
        }
    
        public AlternativeBlock1Block1Alt2Syntax WithKReturns(__SyntaxToken kReturns)
        {
            return this.Update(this.Identifier, kReturns, this.ReturnType);
        }
    
        public AlternativeBlock1Block1Alt2Syntax WithReturnType(TypeReferenceSyntax returnType)
        {
            return this.Update(this.Identifier, this.KReturns, returnType);
        }
    
    
        public AlternativeBlock1Block1Alt2Syntax Update(IdentifierSyntax identifier, __SyntaxToken kReturns, TypeReferenceSyntax returnType)
        {
            if (this.Identifier != identifier || this.KReturns != kReturns || this.ReturnType != returnType)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.AlternativeBlock1Block1Alt2(identifier, kReturns, returnType);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (AlternativeBlock1Block1Alt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitAlternativeBlock1Block1Alt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitAlternativeBlock1Block1Alt2(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitAlternativeBlock1Block1Alt2(this);
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.AlternativeBlock2Green)this.Green;
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
        private AssignmentSyntax _assignment;
    
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
        public AssignmentSyntax Assignment 
        { 
            get
            {
            var red = this.GetRed(ref this._assignment, 2);
            return red;
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._annotations1, 0);
                case 1: return this.GetRed(ref this._name, 1);
                case 2: return this.GetRed(ref this._assignment, 2);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._annotations1;
                case 1: return this._name;
                case 2: return this._assignment;
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
    
        public ElementBlock1Syntax WithAssignment(AssignmentSyntax assignment)
        {
            return this.Update(this.Annotations1, this.Name, assignment);
        }
    
    
        public ElementBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name, AssignmentSyntax assignment)
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
    
    public sealed class BlockalternativesBlockSyntax : CompilerSyntaxNode
    {
        private BlockAlternativeSyntax _alternatives;
    
        public BlockalternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public BlockalternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TBar 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockalternativesBlockGreen)this.Green;
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
    
        public BlockalternativesBlockSyntax WithTBar(__SyntaxToken tBar)
        {
            return this.Update(tBar, this.Alternatives);
        }
    
        public BlockalternativesBlockSyntax WithAlternatives(BlockAlternativeSyntax alternatives)
        {
            return this.Update(this.TBar, alternatives);
        }
    
    
        public BlockalternativesBlockSyntax Update(__SyntaxToken tBar, BlockAlternativeSyntax alternatives)
        {
            if (this.TBar != tBar || this.Alternatives != alternatives)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.BlockalternativesBlock(tBar, alternatives);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (BlockalternativesBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitBlockalternativesBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitBlockalternativesBlock(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitBlockalternativesBlock(this);
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.BlockAlternativeBlock1Green)this.Green;
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
    
    public sealed class RuleRefAlt3referencedTypesBlockSyntax : CompilerSyntaxNode
    {
        private TypeReferenceSyntax _referencedTypes;
    
        public RuleRefAlt3referencedTypesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public RuleRefAlt3referencedTypesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleRefAlt3referencedTypesBlockGreen)this.Green;
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
    
        public RuleRefAlt3referencedTypesBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.ReferencedTypes);
        }
    
        public RuleRefAlt3referencedTypesBlockSyntax WithReferencedTypes(TypeReferenceSyntax referencedTypes)
        {
            return this.Update(this.TComma, referencedTypes);
        }
    
    
        public RuleRefAlt3referencedTypesBlockSyntax Update(__SyntaxToken tComma, TypeReferenceSyntax referencedTypes)
        {
            if (this.TComma != tComma || this.ReferencedTypes != referencedTypes)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.RuleRefAlt3referencedTypesBlock(tComma, referencedTypes);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (RuleRefAlt3referencedTypesBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitRuleRefAlt3referencedTypesBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitRuleRefAlt3referencedTypesBlock(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitRuleRefAlt3referencedTypesBlock(this);
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.RuleRefAlt3Block1Green)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenBlock1Alt1Green)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenBlock1Alt2Green)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenBlock1Alt1Block1Green)this.Green;
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
    
    public sealed class TokenalternativesBlockSyntax : CompilerSyntaxNode
    {
        private LAlternativeSyntax _alternatives;
    
        public TokenalternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public TokenalternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TBar 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.TokenalternativesBlockGreen)this.Green;
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
    
        public TokenalternativesBlockSyntax WithTBar(__SyntaxToken tBar)
        {
            return this.Update(tBar, this.Alternatives);
        }
    
        public TokenalternativesBlockSyntax WithAlternatives(LAlternativeSyntax alternatives)
        {
            return this.Update(this.TBar, alternatives);
        }
    
    
        public TokenalternativesBlockSyntax Update(__SyntaxToken tBar, LAlternativeSyntax alternatives)
        {
            if (this.TBar != tBar || this.Alternatives != alternatives)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.TokenalternativesBlock(tBar, alternatives);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (TokenalternativesBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitTokenalternativesBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitTokenalternativesBlock(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitTokenalternativesBlock(this);
        }
    
    }
    
    public sealed class FragmentalternativesBlockSyntax : CompilerSyntaxNode
    {
        private LAlternativeSyntax _alternatives;
    
        public FragmentalternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public FragmentalternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TBar 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.FragmentalternativesBlockGreen)this.Green;
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
    
        public FragmentalternativesBlockSyntax WithTBar(__SyntaxToken tBar)
        {
            return this.Update(tBar, this.Alternatives);
        }
    
        public FragmentalternativesBlockSyntax WithAlternatives(LAlternativeSyntax alternatives)
        {
            return this.Update(this.TBar, alternatives);
        }
    
    
        public FragmentalternativesBlockSyntax Update(__SyntaxToken tBar, LAlternativeSyntax alternatives)
        {
            if (this.TBar != tBar || this.Alternatives != alternatives)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.FragmentalternativesBlock(tBar, alternatives);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (FragmentalternativesBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitFragmentalternativesBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitFragmentalternativesBlock(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitFragmentalternativesBlock(this);
        }
    
    }
    
    public sealed class LBlockalternativesBlockSyntax : CompilerSyntaxNode
    {
        private LAlternativeSyntax _alternatives;
    
        public LBlockalternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LBlockalternativesBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TBar 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LBlockalternativesBlockGreen)this.Green;
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
    
        public LBlockalternativesBlockSyntax WithTBar(__SyntaxToken tBar)
        {
            return this.Update(tBar, this.Alternatives);
        }
    
        public LBlockalternativesBlockSyntax WithAlternatives(LAlternativeSyntax alternatives)
        {
            return this.Update(this.TBar, alternatives);
        }
    
    
        public LBlockalternativesBlockSyntax Update(__SyntaxToken tBar, LAlternativeSyntax alternatives)
        {
            if (this.TBar != tBar || this.Alternatives != alternatives)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LBlockalternativesBlock(tBar, alternatives);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (LBlockalternativesBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitLBlockalternativesBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitLBlockalternativesBlock(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitLBlockalternativesBlock(this);
        }
    
    }
    public abstract class SingleExpressionAlt1Block1Syntax : CompilerSyntaxNode
    {
        protected SingleExpressionAlt1Block1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        protected SingleExpressionAlt1Block1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    }
    
    public sealed class SingleExpressionAlt1Block1Alt1Syntax : SingleExpressionAlt1Block1Syntax
    {
    
        public SingleExpressionAlt1Block1Alt1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SingleExpressionAlt1Block1Alt1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KNull 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.SingleExpressionAlt1Block1Alt1Green)this.Green;
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
    
        public SingleExpressionAlt1Block1Alt1Syntax WithKNull(__SyntaxToken kNull)
        {
            return this.Update(kNull);
        }
    
    
        public SingleExpressionAlt1Block1Alt1Syntax Update(__SyntaxToken kNull)
        {
            if (this.KNull != kNull)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionAlt1Block1Alt1(kNull);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SingleExpressionAlt1Block1Alt1Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt1(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt1(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitSingleExpressionAlt1Block1Alt1(this);
        }
    
    }
    public sealed class SingleExpressionAlt1Block1Alt2Syntax : SingleExpressionAlt1Block1Syntax
    {
    
        public SingleExpressionAlt1Block1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SingleExpressionAlt1Block1Alt2Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KTrue 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.SingleExpressionAlt1Block1Alt2Green)this.Green;
            var greenToken = green.KTrue;
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
    
        public SingleExpressionAlt1Block1Alt2Syntax WithKTrue(__SyntaxToken kTrue)
        {
            return this.Update(kTrue);
        }
    
    
        public SingleExpressionAlt1Block1Alt2Syntax Update(__SyntaxToken kTrue)
        {
            if (this.KTrue != kTrue)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionAlt1Block1Alt2(kTrue);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SingleExpressionAlt1Block1Alt2Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt2(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt2(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitSingleExpressionAlt1Block1Alt2(this);
        }
    
    }
    public sealed class SingleExpressionAlt1Block1Alt3Syntax : SingleExpressionAlt1Block1Syntax
    {
    
        public SingleExpressionAlt1Block1Alt3Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SingleExpressionAlt1Block1Alt3Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken KFalse 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.SingleExpressionAlt1Block1Alt3Green)this.Green;
            var greenToken = green.KFalse;
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
    
        public SingleExpressionAlt1Block1Alt3Syntax WithKFalse(__SyntaxToken kFalse)
        {
            return this.Update(kFalse);
        }
    
    
        public SingleExpressionAlt1Block1Alt3Syntax Update(__SyntaxToken kFalse)
        {
            if (this.KFalse != kFalse)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionAlt1Block1Alt3(kFalse);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SingleExpressionAlt1Block1Alt3Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt3(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt3(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitSingleExpressionAlt1Block1Alt3(this);
        }
    
    }
    public sealed class SingleExpressionAlt1Block1Alt4Syntax : SingleExpressionAlt1Block1Syntax
    {
    
        public SingleExpressionAlt1Block1Alt4Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SingleExpressionAlt1Block1Alt4Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TString 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.SingleExpressionAlt1Block1Alt4Green)this.Green;
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
    
        public SingleExpressionAlt1Block1Alt4Syntax WithTString(__SyntaxToken tString)
        {
            return this.Update(tString);
        }
    
    
        public SingleExpressionAlt1Block1Alt4Syntax Update(__SyntaxToken tString)
        {
            if (this.TString != tString)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionAlt1Block1Alt4(tString);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SingleExpressionAlt1Block1Alt4Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt4(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt4(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitSingleExpressionAlt1Block1Alt4(this);
        }
    
    }
    public sealed class SingleExpressionAlt1Block1Alt5Syntax : SingleExpressionAlt1Block1Syntax
    {
    
        public SingleExpressionAlt1Block1Alt5Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SingleExpressionAlt1Block1Alt5Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TInteger 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.SingleExpressionAlt1Block1Alt5Green)this.Green;
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
    
        public SingleExpressionAlt1Block1Alt5Syntax WithTInteger(__SyntaxToken tInteger)
        {
            return this.Update(tInteger);
        }
    
    
        public SingleExpressionAlt1Block1Alt5Syntax Update(__SyntaxToken tInteger)
        {
            if (this.TInteger != tInteger)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionAlt1Block1Alt5(tInteger);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SingleExpressionAlt1Block1Alt5Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt5(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt5(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitSingleExpressionAlt1Block1Alt5(this);
        }
    
    }
    public sealed class SingleExpressionAlt1Block1Alt6Syntax : SingleExpressionAlt1Block1Syntax
    {
    
        public SingleExpressionAlt1Block1Alt6Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SingleExpressionAlt1Block1Alt6Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TDecimal 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.SingleExpressionAlt1Block1Alt6Green)this.Green;
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
    
        public SingleExpressionAlt1Block1Alt6Syntax WithTDecimal(__SyntaxToken tDecimal)
        {
            return this.Update(tDecimal);
        }
    
    
        public SingleExpressionAlt1Block1Alt6Syntax Update(__SyntaxToken tDecimal)
        {
            if (this.TDecimal != tDecimal)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionAlt1Block1Alt6(tDecimal);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SingleExpressionAlt1Block1Alt6Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt6(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt6(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitSingleExpressionAlt1Block1Alt6(this);
        }
    
    }
    public sealed class SingleExpressionAlt1Block1Alt7Syntax : SingleExpressionAlt1Block1Syntax
    {
        private PrimitiveTypeSyntax _primitiveType;
    
        public SingleExpressionAlt1Block1Alt7Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public SingleExpressionAlt1Block1Alt7Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
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
    
        public SingleExpressionAlt1Block1Alt7Syntax WithPrimitiveType(PrimitiveTypeSyntax primitiveType)
        {
            return this.Update(primitiveType);
        }
    
    
        public SingleExpressionAlt1Block1Alt7Syntax Update(PrimitiveTypeSyntax primitiveType)
        {
            if (this.PrimitiveType != primitiveType)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.SingleExpressionAlt1Block1Alt7(primitiveType);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (SingleExpressionAlt1Block1Alt7Syntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt7(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSingleExpressionAlt1Block1Alt7(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitSingleExpressionAlt1Block1Alt7(this);
        }
    
    }
    
    public sealed class ArrayExpressionBlock1Syntax : CompilerSyntaxNode
    {
        private __SyntaxNode _items;
    
        public ArrayExpressionBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ArrayExpressionBlock1Syntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> Items 
        { 
            get
            {
            var red = this.GetRed(ref this._items, 0);
            return red == null ? default : new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax>(red, this.GetChildIndex(0), reversed: false);
            } 
        }
    
        protected override __SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                case 0: return this.GetRed(ref this._items, 0);
                default: return null;
            }
        }
    
        protected override __SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                case 0: return this._items;
                default: return null;
            }
        }
    
        public ArrayExpressionBlock1Syntax WithItems(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> items)
        {
            return this.Update(items);
        }
    
        public ArrayExpressionBlock1Syntax AddItems(params SingleExpressionSyntax[] items)
        {
            return this.WithItems(this.Items.AddRange(items));
        }
    
    
        public ArrayExpressionBlock1Syntax Update(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> items)
        {
            if (this.Items != items)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.ArrayExpressionBlock1(items);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
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
    
    public sealed class ArrayExpressionBlock1itemsBlockSyntax : CompilerSyntaxNode
    {
        private SingleExpressionSyntax _items;
    
        public ArrayExpressionBlock1itemsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ArrayExpressionBlock1itemsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.ArrayExpressionBlock1itemsBlockGreen)this.Green;
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
    
        public ArrayExpressionBlock1itemsBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.Items);
        }
    
        public ArrayExpressionBlock1itemsBlockSyntax WithItems(SingleExpressionSyntax items)
        {
            return this.Update(this.TComma, items);
        }
    
    
        public ArrayExpressionBlock1itemsBlockSyntax Update(__SyntaxToken tComma, SingleExpressionSyntax items)
        {
            if (this.TComma != tComma || this.Items != items)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.ArrayExpressionBlock1itemsBlock(tComma, items);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ArrayExpressionBlock1itemsBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitArrayExpressionBlock1itemsBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitArrayExpressionBlock1itemsBlock(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitArrayExpressionBlock1itemsBlock(this);
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationBlock1Green)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationBlock1Green)this.Green;
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
    
    public sealed class ParserAnnotationBlock1argumentsBlockSyntax : CompilerSyntaxNode
    {
        private AnnotationArgumentSyntax _arguments;
    
        public ParserAnnotationBlock1argumentsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public ParserAnnotationBlock1argumentsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.ParserAnnotationBlock1argumentsBlockGreen)this.Green;
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
    
        public ParserAnnotationBlock1argumentsBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.Arguments);
        }
    
        public ParserAnnotationBlock1argumentsBlockSyntax WithArguments(AnnotationArgumentSyntax arguments)
        {
            return this.Update(this.TComma, arguments);
        }
    
    
        public ParserAnnotationBlock1argumentsBlockSyntax Update(__SyntaxToken tComma, AnnotationArgumentSyntax arguments)
        {
            if (this.TComma != tComma || this.Arguments != arguments)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.ParserAnnotationBlock1argumentsBlock(tComma, arguments);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (ParserAnnotationBlock1argumentsBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitParserAnnotationBlock1argumentsBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitParserAnnotationBlock1argumentsBlock(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitParserAnnotationBlock1argumentsBlock(this);
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationBlock1Green)this.Green;
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationBlock1Green)this.Green;
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
    
    public sealed class LexerAnnotationBlock1argumentsBlockSyntax : CompilerSyntaxNode
    {
        private AnnotationArgumentSyntax _arguments;
    
        public LexerAnnotationBlock1argumentsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public LexerAnnotationBlock1argumentsBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TComma 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.LexerAnnotationBlock1argumentsBlockGreen)this.Green;
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
    
        public LexerAnnotationBlock1argumentsBlockSyntax WithTComma(__SyntaxToken tComma)
        {
            return this.Update(tComma, this.Arguments);
        }
    
        public LexerAnnotationBlock1argumentsBlockSyntax WithArguments(AnnotationArgumentSyntax arguments)
        {
            return this.Update(this.TComma, arguments);
        }
    
    
        public LexerAnnotationBlock1argumentsBlockSyntax Update(__SyntaxToken tComma, AnnotationArgumentSyntax arguments)
        {
            if (this.TComma != tComma || this.Arguments != arguments)
            {
                var newNode = CompilerLanguage.Instance.SyntaxFactory.LexerAnnotationBlock1argumentsBlock(tComma, arguments);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (LexerAnnotationBlock1argumentsBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitLexerAnnotationBlock1argumentsBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitLexerAnnotationBlock1argumentsBlock(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitLexerAnnotationBlock1argumentsBlock(this);
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
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.AnnotationArgumentBlock1Green)this.Green;
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
    
    public sealed class QualifierIdentifierBlockSyntax : CompilerSyntaxNode
    {
        private IdentifierSyntax _identifier;
    
        public QualifierIdentifierBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }
    
        public QualifierIdentifierBlockSyntax(__InternalSyntaxNode green, CompilerSyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }
    
        public __SyntaxToken TDot 
        { 
            get
            {
            var green = (global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax.QualifierIdentifierBlockGreen)this.Green;
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
                var newNode = CompilerLanguage.Instance.SyntaxFactory.QualifierIdentifierBlock(tDot, identifier);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                   newNode = __SyntaxExtensions.WithAnnotations(newNode, annotations);
                return (QualifierIdentifierBlockSyntax)newNode;
            }
            return this;
        }
    
        public override TResult Accept<TArg, TResult>(ICompilerSyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            return visitor.VisitQualifierIdentifierBlock(this, argument);
        }
    
        public override TResult Accept<TResult>(ICompilerSyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitQualifierIdentifierBlock(this);
        }
    
        public override void Accept(ICompilerSyntaxVisitor visitor)
        {
            visitor.VisitQualifierIdentifierBlock(this);
        }
    
    }
}
