#pragma warning disable CS8669

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

    internal abstract class CustomCompilerImplementationBase : ICustomCompilerImplementation
    {
        /// <summary>
        /// Constructor for the meta model Compiler
        /// </summary>
        public virtual void Compiler(ICompiler _this)
        {
        }
    
        public virtual void Alternative(Alternative _this)
        {
        }
    
        public virtual void Annotation(Annotation _this)
        {
        }
    
        public virtual void AnnotationArgument(AnnotationArgument _this)
        {
        }
    
        public virtual void ArrayExpression(ArrayExpression _this)
        {
        }
    
        public virtual void Binder(Binder _this)
        {
        }
    
        public virtual void BinderArgument(BinderArgument _this)
        {
        }
    
        public virtual void Block(Block _this)
        {
        }
    
        public virtual void CSharpElement(CSharpElement _this)
        {
        }
    
        public virtual void Declaration(Declaration _this)
        {
        }
    
        public virtual void Element(Element _this)
        {
        }
    
        public virtual void ElementValue(ElementValue _this)
        {
        }
    
        public virtual void Eof(Eof _this)
        {
        }
    
        public virtual void Expression(Expression _this)
        {
        }
    
        public virtual void Fixed(Fixed _this)
        {
        }
    
        public virtual void Fragment(Fragment _this)
        {
        }
    
        public virtual void Grammar(Grammar _this)
        {
        }
    
        public virtual void GrammarRule(GrammarRule _this)
        {
        }
    
        public virtual void LAlternative(LAlternative _this)
        {
        }
    
        public virtual void Language(Language _this)
        {
        }
    
        public virtual void LBlock(LBlock _this)
        {
        }
    
        public virtual void LElement(LElement _this)
        {
        }
    
        public virtual void LElementValue(LElementValue _this)
        {
        }
    
        public virtual void LexerRule(LexerRule _this)
        {
        }
    
        public virtual void LFixed(LFixed _this)
        {
        }
    
        public virtual void LRange(LRange _this)
        {
        }
    
        public virtual void LReference(LReference _this)
        {
        }
    
        public virtual void LSet(LSet _this)
        {
        }
    
        public virtual void LSetChar(LSetChar _this)
        {
        }
    
        public virtual void LSetItem(LSetItem _this)
        {
        }
    
        public virtual void LSetRange(LSetRange _this)
        {
        }
    
        public virtual void LWildCard(LWildCard _this)
        {
        }
    
        public virtual void Rule(Rule _this)
        {
        }
    
        public virtual void RuleRef(RuleRef _this)
        {
        }
    
        public virtual void SeparatedList(SeparatedList _this)
        {
        }
    
        public virtual void Token(Token _this)
        {
        }
    
        public virtual void TokenAlts(TokenAlts _this)
        {
        }
    
        public virtual void TokenKind(TokenKind _this)
        {
        }
    
    
        public abstract string Alternative_GreenName(Alternative _this);
    
        public abstract string Alternative_GreenConstructorParameters(Alternative _this);
    
        public abstract string Alternative_GreenConstructorArguments(Alternative _this);
    
        public abstract string Alternative_GreenUpdateParameters(Alternative _this);
    
        public abstract string Alternative_GreenUpdateArguments(Alternative _this);
    
        public abstract string Alternative_RedName(Alternative _this);
    
        public abstract string Alternative_RedUpdateParameters(Alternative _this);
    
        public abstract string Alternative_RedUpdateArguments(Alternative _this);
    
        public abstract string Alternative_RedOptionalUpdateParameters(Alternative _this);
    
        public abstract string Alternative_RedToGreenArgumentList(Alternative _this);
    
        public abstract string Alternative_RedToGreenOptionalArgumentList(Alternative _this);
    
        public abstract bool Alternative_HasRedToGreenOptionalArguments(Alternative _this);
    
        public abstract string Binder_ConstructorArguments(Binder _this);
    
        public abstract string Block_GreenType(Block _this);
    
        public abstract string? Block_GreenSyntaxCondition(Block _this);
    
        public abstract string Block_RedType(Block _this);
    
        public abstract string Declaration_Namespace(Declaration _this);
    
        public abstract string? Declaration_FullName(Declaration _this);
    
        public abstract bool Element_IsToken(Element _this);
    
        public abstract bool Element_IsList(Element _this);
    
        public abstract string Element_FieldName(Element _this);
    
        public abstract string Element_ParameterName(Element _this);
    
        public abstract string Element_PropertyName(Element _this);
    
        public abstract string Element_GreenFieldType(Element _this);
    
        public abstract string Element_GreenParameterValue(Element _this);
    
        public abstract string Element_GreenPropertyType(Element _this);
    
        public abstract string Element_GreenPropertyValue(Element _this);
    
        public abstract string? Element_GreenSyntaxNullCondition(Element _this);
    
        public abstract string? Element_GreenSyntaxCondition(Element _this);
    
        public abstract bool Element_IsOptionalUpdateParameter(Element _this);
    
        public abstract string Element_RedFieldType(Element _this);
    
        public abstract string Element_RedParameterValue(Element _this);
    
        public abstract string Element_RedPropertyType(Element _this);
    
        public abstract string Element_RedPropertyValue(Element _this);
    
        public abstract string Element_RedToGreenArgument(Element _this);
    
        public abstract string Element_RedToGreenOptionalArgument(Element _this);
    
        public abstract string? Element_RedSyntaxNullCondition(Element _this);
    
        public abstract string? Element_RedSyntaxCondition(Element _this);
    
        public abstract string? Element_VisitCall(Element _this);
    
        public abstract string ElementValue_GreenType(ElementValue _this);
    
        public abstract string? ElementValue_GreenSyntaxCondition(ElementValue _this);
    
        public abstract string ElementValue_RedType(ElementValue _this);
    
        public abstract string Eof_GreenType(Eof _this);
    
        public abstract string? Eof_GreenSyntaxCondition(Eof _this);
    
        public abstract string Eof_RedType(Eof _this);
    
        public abstract MetaDslx.Languages.MetaCompiler.Model.Language Grammar_Language(Grammar _this);
    
        public abstract MetaDslx.Languages.MetaCompiler.Model.Language GrammarRule_Language(GrammarRule _this);
    
        public abstract MetaDslx.Languages.MetaCompiler.Model.Grammar GrammarRule_Grammar(GrammarRule _this);
    
        public abstract bool LAlternative_IsFixed(LAlternative _this);
    
        public abstract string? LAlternative_FixedText(LAlternative _this);
    
        public abstract bool LBlock_IsFixed(LBlock _this);
    
        public abstract string? LBlock_FixedText(LBlock _this);
    
        public abstract bool LElement_IsFixed(LElement _this);
    
        public abstract string? LElement_FixedText(LElement _this);
    
        public abstract bool LElementValue_IsFixed(LElementValue _this);
    
        public abstract string? LElementValue_FixedText(LElementValue _this);
    
        public abstract bool LexerRule_IsFixed(LexerRule _this);
    
        public abstract string? LexerRule_FixedText(LexerRule _this);
    
        public abstract bool LFixed_IsFixed(LFixed _this);
    
        public abstract string? LFixed_FixedText(LFixed _this);
    
        public abstract bool LRange_IsFixed(LRange _this);
    
        public abstract string? LRange_FixedText(LRange _this);
    
        public abstract bool LReference_IsFixed(LReference _this);
    
        public abstract string? LReference_FixedText(LReference _this);
    
        public abstract bool LSet_IsFixed(LSet _this);
    
        public abstract string? LSet_FixedText(LSet _this);
    
        public abstract bool LSetChar_IsFixed(LSetChar _this);
    
        public abstract string? LSetChar_FixedText(LSetChar _this);
    
        public abstract bool LSetItem_IsFixed(LSetItem _this);
    
        public abstract string? LSetItem_FixedText(LSetItem _this);
    
        public abstract bool LSetRange_IsFixed(LSetRange _this);
    
        public abstract string? LSetRange_FixedText(LSetRange _this);
    
        public abstract bool LWildCard_IsFixed(LWildCard _this);
    
        public abstract string? LWildCard_FixedText(LWildCard _this);
    
        public abstract string Rule_GreenName(Rule _this);
    
        public abstract string Rule_RedName(Rule _this);
    
        public abstract MetaDslx.Languages.MetaCompiler.Model.Token? RuleRef_Token(RuleRef _this);
    
        public abstract MetaDslx.Languages.MetaCompiler.Model.Rule? RuleRef_Rule(RuleRef _this);
    
        public abstract string RuleRef_GreenType(RuleRef _this);
    
        public abstract string? RuleRef_GreenSyntaxCondition(RuleRef _this);
    
        public abstract string RuleRef_RedType(RuleRef _this);
    
        public abstract string SeparatedList_GreenType(SeparatedList _this);
    
        public abstract string? SeparatedList_GreenSyntaxCondition(SeparatedList _this);
    
        public abstract string SeparatedList_RedType(SeparatedList _this);
    
        public abstract string TokenAlts_GreenType(TokenAlts _this);
    
        public abstract string? TokenAlts_GreenSyntaxCondition(TokenAlts _this);
    
        public abstract string TokenAlts_RedType(TokenAlts _this);
    
    
    }
}
