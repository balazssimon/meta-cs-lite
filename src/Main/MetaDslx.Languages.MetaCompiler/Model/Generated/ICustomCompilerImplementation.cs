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

    internal interface ICustomCompilerImplementation
    {
        /// <summary>
        /// Constructor for the meta model Compiler
        /// </summary>
        void Compiler(ICompiler _this);
    
        void Annotation(Annotation _this);
    
        void AnnotationArgument(AnnotationArgument _this);
    
        void ArrayExpression(ArrayExpression _this);
    
        void Binder(Binder _this);
    
        void BinderArgument(BinderArgument _this);
    
        void CSharpElement(CSharpElement _this);
    
        void Declaration(Declaration _this);
    
        void Alternative(Alternative _this);
    
        void ElementValue(ElementValue _this);
    
        void Block(Block _this);
    
        void Element(Element _this);
    
        void Eof(Eof _this);
    
        void Expression(Expression _this);
    
        void Fixed(Fixed _this);
    
        void GrammarRule(GrammarRule _this);
    
        void Language(Language _this);
    
        void LexerRule(LexerRule _this);
    
        void Fragment(Fragment _this);
    
        void Grammar(Grammar _this);
    
        void LAlternative(LAlternative _this);
    
        void LElement(LElement _this);
    
        void LElementValue(LElementValue _this);
    
        void LBlock(LBlock _this);
    
        void LFixed(LFixed _this);
    
        void LRange(LRange _this);
    
        void LReference(LReference _this);
    
        void LSet(LSet _this);
    
        void LSetItem(LSetItem _this);
    
        void LSetChar(LSetChar _this);
    
        void LSetRange(LSetRange _this);
    
        void LWildCard(LWildCard _this);
    
        void Namespace(Namespace _this);
    
        void Rule(Rule _this);
    
        void RuleRef(RuleRef _this);
    
        void SeparatedList(SeparatedList _this);
    
        void Token(Token _this);
    
        void TokenAlts(TokenAlts _this);
    
        void TokenKind(TokenKind _this);
    
    
        string Binder_ConstructorArguments(Binder _this);
    
        string? Declaration_FullName(Declaration _this);
    
        string Alternative_GreenName(Alternative _this);
    
        string Alternative_GreenConstructorParameters(Alternative _this);
    
        string Alternative_GreenConstructorArguments(Alternative _this);
    
        string Alternative_GreenUpdateParameters(Alternative _this);
    
        string Alternative_GreenUpdateArguments(Alternative _this);
    
        string Alternative_RedName(Alternative _this);
    
        string Alternative_RedUpdateParameters(Alternative _this);
    
        string Alternative_RedUpdateArguments(Alternative _this);
    
        string Alternative_RedOptionalUpdateParameters(Alternative _this);
    
        string Alternative_RedToGreenArgumentList(Alternative _this);
    
        string Alternative_RedToGreenOptionalArgumentList(Alternative _this);
    
        bool Alternative_HasRedToGreenOptionalArguments(Alternative _this);
    
        string ElementValue_GreenType(ElementValue _this);
    
        string? ElementValue_GreenSyntaxCondition(ElementValue _this);
    
        string ElementValue_RedType(ElementValue _this);
    
        string Block_GreenType(Block _this);
    
        string? Block_GreenSyntaxCondition(Block _this);
    
        string Block_RedType(Block _this);
    
        bool Element_IsToken(Element _this);
    
        bool Element_IsList(Element _this);
    
        string Element_FieldName(Element _this);
    
        string Element_ParameterName(Element _this);
    
        string Element_PropertyName(Element _this);
    
        string Element_GreenFieldType(Element _this);
    
        string Element_GreenParameterValue(Element _this);
    
        string Element_GreenPropertyType(Element _this);
    
        string Element_GreenPropertyValue(Element _this);
    
        string? Element_GreenSyntaxNullCondition(Element _this);
    
        string? Element_GreenSyntaxCondition(Element _this);
    
        bool Element_IsOptionalUpdateParameter(Element _this);
    
        string Element_RedFieldType(Element _this);
    
        string Element_RedParameterValue(Element _this);
    
        string Element_RedPropertyType(Element _this);
    
        string Element_RedPropertyValue(Element _this);
    
        string Element_RedToGreenArgument(Element _this);
    
        string Element_RedToGreenOptionalArgument(Element _this);
    
        string? Element_RedSyntaxNullCondition(Element _this);
    
        string? Element_RedSyntaxCondition(Element _this);
    
        string? Element_VisitCall(Element _this);
    
        string Eof_GreenType(Eof _this);
    
        string? Eof_GreenSyntaxCondition(Eof _this);
    
        string Eof_RedType(Eof _this);
    
        Language GrammarRule_Language(GrammarRule _this);
    
        string Language_Namespace(Language _this);
    
        bool LexerRule_IsFixed(LexerRule _this);
    
        string? LexerRule_FixedText(LexerRule _this);
    
        bool LAlternative_IsFixed(LAlternative _this);
    
        string? LAlternative_FixedText(LAlternative _this);
    
        bool LElement_IsFixed(LElement _this);
    
        string? LElement_FixedText(LElement _this);
    
        bool LElementValue_IsFixed(LElementValue _this);
    
        string? LElementValue_FixedText(LElementValue _this);
    
        bool LBlock_IsFixed(LBlock _this);
    
        string? LBlock_FixedText(LBlock _this);
    
        bool LFixed_IsFixed(LFixed _this);
    
        string? LFixed_FixedText(LFixed _this);
    
        bool LRange_IsFixed(LRange _this);
    
        string? LRange_FixedText(LRange _this);
    
        bool LReference_IsFixed(LReference _this);
    
        string? LReference_FixedText(LReference _this);
    
        bool LSet_IsFixed(LSet _this);
    
        string? LSet_FixedText(LSet _this);
    
        bool LSetItem_IsFixed(LSetItem _this);
    
        string? LSetItem_FixedText(LSetItem _this);
    
        bool LSetChar_IsFixed(LSetChar _this);
    
        string? LSetChar_FixedText(LSetChar _this);
    
        bool LSetRange_IsFixed(LSetRange _this);
    
        string? LSetRange_FixedText(LSetRange _this);
    
        bool LWildCard_IsFixed(LWildCard _this);
    
        string? LWildCard_FixedText(LWildCard _this);
    
        string Rule_GreenName(Rule _this);
    
        string Rule_RedName(Rule _this);
    
        Token? RuleRef_Token(RuleRef _this);
    
        Rule? RuleRef_Rule(RuleRef _this);
    
        string RuleRef_GreenType(RuleRef _this);
    
        string? RuleRef_GreenSyntaxCondition(RuleRef _this);
    
        string RuleRef_RedType(RuleRef _this);
    
        string SeparatedList_GreenType(SeparatedList _this);
    
        string? SeparatedList_GreenSyntaxCondition(SeparatedList _this);
    
        string SeparatedList_RedType(SeparatedList _this);
    
        string TokenAlts_GreenType(TokenAlts _this);
    
        string? TokenAlts_GreenSyntaxCondition(TokenAlts _this);
    
        string TokenAlts_RedType(TokenAlts _this);
    
    
    }
}
