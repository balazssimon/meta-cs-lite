#nullable enable

namespace MetaDslx.Languages.MetaCompiler.Model
{
    using __MetaMetaModel = global::MetaDslx.Languages.MetaModel.Model.Meta;
    using __MetaModelFactory = global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __ModelFactory = global::MetaDslx.Modeling.ModelFactory;
    using __MultiModelFactory = global::MetaDslx.Modeling.MultiModelFactory;
    using __ModelVersion = global::MetaDslx.Modeling.ModelVersion;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    public class CompilerModelFactory : __ModelFactory
    {
        public CompilerModelFactory(__Model model)
            : base(model, Compiler.MInstance)
        {
        }
    
        internal CompilerModelFactory(__Model model, Compiler metaModel)
            : base(model, metaModel)
        {
        }
    
        public Alternative Alternative(string? id = null)
        {
            return (Alternative)Compiler.AlternativeInfo.Create(base.Model, id)!;
        }
    
        public Annotation Annotation(string? id = null)
        {
            return (Annotation)Compiler.AnnotationInfo.Create(base.Model, id)!;
        }
    
        public AnnotationArgument AnnotationArgument(string? id = null)
        {
            return (AnnotationArgument)Compiler.AnnotationArgumentInfo.Create(base.Model, id)!;
        }
    
        public ArrayExpression ArrayExpression(string? id = null)
        {
            return (ArrayExpression)Compiler.ArrayExpressionInfo.Create(base.Model, id)!;
        }
    
        public Binder Binder(string? id = null)
        {
            return (Binder)Compiler.BinderInfo.Create(base.Model, id)!;
        }
    
        public BinderArgument BinderArgument(string? id = null)
        {
            return (BinderArgument)Compiler.BinderArgumentInfo.Create(base.Model, id)!;
        }
    
        public Block Block(string? id = null)
        {
            return (Block)Compiler.BlockInfo.Create(base.Model, id)!;
        }
    
        public CSharpElement CSharpElement(string? id = null)
        {
            return (CSharpElement)Compiler.CSharpElementInfo.Create(base.Model, id)!;
        }
    
        public Declaration Declaration(string? id = null)
        {
            return (Declaration)Compiler.DeclarationInfo.Create(base.Model, id)!;
        }
    
        public Element Element(string? id = null)
        {
            return (Element)Compiler.ElementInfo.Create(base.Model, id)!;
        }
    
        public Eof Eof(string? id = null)
        {
            return (Eof)Compiler.EofInfo.Create(base.Model, id)!;
        }
    
        public Expression Expression(string? id = null)
        {
            return (Expression)Compiler.ExpressionInfo.Create(base.Model, id)!;
        }
    
        public Fixed Fixed(string? id = null)
        {
            return (Fixed)Compiler.FixedInfo.Create(base.Model, id)!;
        }
    
        public Fragment Fragment(string? id = null)
        {
            return (Fragment)Compiler.FragmentInfo.Create(base.Model, id)!;
        }
    
        public Grammar Grammar(string? id = null)
        {
            return (Grammar)Compiler.GrammarInfo.Create(base.Model, id)!;
        }
    
        public LAlternative LAlternative(string? id = null)
        {
            return (LAlternative)Compiler.LAlternativeInfo.Create(base.Model, id)!;
        }
    
        public Language Language(string? id = null)
        {
            return (Language)Compiler.LanguageInfo.Create(base.Model, id)!;
        }
    
        public LBlock LBlock(string? id = null)
        {
            return (LBlock)Compiler.LBlockInfo.Create(base.Model, id)!;
        }
    
        public LElement LElement(string? id = null)
        {
            return (LElement)Compiler.LElementInfo.Create(base.Model, id)!;
        }
    
        public LFixed LFixed(string? id = null)
        {
            return (LFixed)Compiler.LFixedInfo.Create(base.Model, id)!;
        }
    
        public LRange LRange(string? id = null)
        {
            return (LRange)Compiler.LRangeInfo.Create(base.Model, id)!;
        }
    
        public LReference LReference(string? id = null)
        {
            return (LReference)Compiler.LReferenceInfo.Create(base.Model, id)!;
        }
    
        public LSet LSet(string? id = null)
        {
            return (LSet)Compiler.LSetInfo.Create(base.Model, id)!;
        }
    
        public LSetChar LSetChar(string? id = null)
        {
            return (LSetChar)Compiler.LSetCharInfo.Create(base.Model, id)!;
        }
    
        public LSetRange LSetRange(string? id = null)
        {
            return (LSetRange)Compiler.LSetRangeInfo.Create(base.Model, id)!;
        }
    
        public LWildCard LWildCard(string? id = null)
        {
            return (LWildCard)Compiler.LWildCardInfo.Create(base.Model, id)!;
        }
    
        public Rule Rule(string? id = null)
        {
            return (Rule)Compiler.RuleInfo.Create(base.Model, id)!;
        }
    
        public RuleRef RuleRef(string? id = null)
        {
            return (RuleRef)Compiler.RuleRefInfo.Create(base.Model, id)!;
        }
    
        public SeparatedList SeparatedList(string? id = null)
        {
            return (SeparatedList)Compiler.SeparatedListInfo.Create(base.Model, id)!;
        }
    
        public Token Token(string? id = null)
        {
            return (Token)Compiler.TokenInfo.Create(base.Model, id)!;
        }
    
        public TokenAlts TokenAlts(string? id = null)
        {
            return (TokenAlts)Compiler.TokenAltsInfo.Create(base.Model, id)!;
        }
    
        public TokenKind TokenKind(string? id = null)
        {
            return (TokenKind)Compiler.TokenKindInfo.Create(base.Model, id)!;
        }
    
    }
    
    public class CompilerModelMultiFactory : __MultiModelFactory
    {
        public CompilerModelMultiFactory()
            : base(new __MetaModel[] { Compiler.MInstance })
        {
        }
    
        public Alternative Alternative(__Model model, string? id = null)
        {
            return (Alternative)Compiler.AlternativeInfo.Create(model, id)!;
        }
    
        public Annotation Annotation(__Model model, string? id = null)
        {
            return (Annotation)Compiler.AnnotationInfo.Create(model, id)!;
        }
    
        public AnnotationArgument AnnotationArgument(__Model model, string? id = null)
        {
            return (AnnotationArgument)Compiler.AnnotationArgumentInfo.Create(model, id)!;
        }
    
        public ArrayExpression ArrayExpression(__Model model, string? id = null)
        {
            return (ArrayExpression)Compiler.ArrayExpressionInfo.Create(model, id)!;
        }
    
        public Binder Binder(__Model model, string? id = null)
        {
            return (Binder)Compiler.BinderInfo.Create(model, id)!;
        }
    
        public BinderArgument BinderArgument(__Model model, string? id = null)
        {
            return (BinderArgument)Compiler.BinderArgumentInfo.Create(model, id)!;
        }
    
        public Block Block(__Model model, string? id = null)
        {
            return (Block)Compiler.BlockInfo.Create(model, id)!;
        }
    
        public CSharpElement CSharpElement(__Model model, string? id = null)
        {
            return (CSharpElement)Compiler.CSharpElementInfo.Create(model, id)!;
        }
    
        public Declaration Declaration(__Model model, string? id = null)
        {
            return (Declaration)Compiler.DeclarationInfo.Create(model, id)!;
        }
    
        public Element Element(__Model model, string? id = null)
        {
            return (Element)Compiler.ElementInfo.Create(model, id)!;
        }
    
        public Eof Eof(__Model model, string? id = null)
        {
            return (Eof)Compiler.EofInfo.Create(model, id)!;
        }
    
        public Expression Expression(__Model model, string? id = null)
        {
            return (Expression)Compiler.ExpressionInfo.Create(model, id)!;
        }
    
        public Fixed Fixed(__Model model, string? id = null)
        {
            return (Fixed)Compiler.FixedInfo.Create(model, id)!;
        }
    
        public Fragment Fragment(__Model model, string? id = null)
        {
            return (Fragment)Compiler.FragmentInfo.Create(model, id)!;
        }
    
        public Grammar Grammar(__Model model, string? id = null)
        {
            return (Grammar)Compiler.GrammarInfo.Create(model, id)!;
        }
    
        public LAlternative LAlternative(__Model model, string? id = null)
        {
            return (LAlternative)Compiler.LAlternativeInfo.Create(model, id)!;
        }
    
        public Language Language(__Model model, string? id = null)
        {
            return (Language)Compiler.LanguageInfo.Create(model, id)!;
        }
    
        public LBlock LBlock(__Model model, string? id = null)
        {
            return (LBlock)Compiler.LBlockInfo.Create(model, id)!;
        }
    
        public LElement LElement(__Model model, string? id = null)
        {
            return (LElement)Compiler.LElementInfo.Create(model, id)!;
        }
    
        public LFixed LFixed(__Model model, string? id = null)
        {
            return (LFixed)Compiler.LFixedInfo.Create(model, id)!;
        }
    
        public LRange LRange(__Model model, string? id = null)
        {
            return (LRange)Compiler.LRangeInfo.Create(model, id)!;
        }
    
        public LReference LReference(__Model model, string? id = null)
        {
            return (LReference)Compiler.LReferenceInfo.Create(model, id)!;
        }
    
        public LSet LSet(__Model model, string? id = null)
        {
            return (LSet)Compiler.LSetInfo.Create(model, id)!;
        }
    
        public LSetChar LSetChar(__Model model, string? id = null)
        {
            return (LSetChar)Compiler.LSetCharInfo.Create(model, id)!;
        }
    
        public LSetRange LSetRange(__Model model, string? id = null)
        {
            return (LSetRange)Compiler.LSetRangeInfo.Create(model, id)!;
        }
    
        public LWildCard LWildCard(__Model model, string? id = null)
        {
            return (LWildCard)Compiler.LWildCardInfo.Create(model, id)!;
        }
    
        public Rule Rule(__Model model, string? id = null)
        {
            return (Rule)Compiler.RuleInfo.Create(model, id)!;
        }
    
        public RuleRef RuleRef(__Model model, string? id = null)
        {
            return (RuleRef)Compiler.RuleRefInfo.Create(model, id)!;
        }
    
        public SeparatedList SeparatedList(__Model model, string? id = null)
        {
            return (SeparatedList)Compiler.SeparatedListInfo.Create(model, id)!;
        }
    
        public Token Token(__Model model, string? id = null)
        {
            return (Token)Compiler.TokenInfo.Create(model, id)!;
        }
    
        public TokenAlts TokenAlts(__Model model, string? id = null)
        {
            return (TokenAlts)Compiler.TokenAltsInfo.Create(model, id)!;
        }
    
        public TokenKind TokenKind(__Model model, string? id = null)
        {
            return (TokenKind)Compiler.TokenKindInfo.Create(model, id)!;
        }
    
    }
}
