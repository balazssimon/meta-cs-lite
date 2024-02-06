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
    
        /// <summary>
        /// Constructor for the class Annotation
        /// </summary>
        void Annotation(Annotation _this);
    
        /// <summary>
        /// Constructor for the class AnnotationArgument
        /// </summary>
        void AnnotationArgument(AnnotationArgument _this);
    
        /// <summary>
        /// Constructor for the class ArrayExpression
        /// </summary>
        void ArrayExpression(ArrayExpression _this);
    
        /// <summary>
        /// Constructor for the class Binder
        /// </summary>
        void Binder(Binder _this);
    
        /// <summary>
        /// Constructor for the class BinderArgument
        /// </summary>
        void BinderArgument(BinderArgument _this);
    
        /// <summary>
        /// Constructor for the class CSharpElement
        /// </summary>
        void CSharpElement(CSharpElement _this);
    
        /// <summary>
        /// Constructor for the class Declaration
        /// </summary>
        void Declaration(Declaration _this);
    
        /// <summary>
        /// Constructor for the class Alternative
        /// </summary>
        void Alternative(Alternative _this);
    
        /// <summary>
        /// Constructor for the class ElementValue
        /// </summary>
        void ElementValue(ElementValue _this);
    
        /// <summary>
        /// Constructor for the class Block
        /// </summary>
        void Block(Block _this);
    
        /// <summary>
        /// Constructor for the class Element
        /// </summary>
        void Element(Element _this);
    
        /// <summary>
        /// Constructor for the class Eof
        /// </summary>
        void Eof(Eof _this);
    
        /// <summary>
        /// Constructor for the class Expression
        /// </summary>
        void Expression(Expression _this);
    
        /// <summary>
        /// Constructor for the class Fixed
        /// </summary>
        void Fixed(Fixed _this);
    
        /// <summary>
        /// Constructor for the class GrammarRule
        /// </summary>
        void GrammarRule(GrammarRule _this);
    
        /// <summary>
        /// Constructor for the class Language
        /// </summary>
        void Language(Language _this);
    
        /// <summary>
        /// Constructor for the class LexerRule
        /// </summary>
        void LexerRule(LexerRule _this);
    
        /// <summary>
        /// Constructor for the class Fragment
        /// </summary>
        void Fragment(Fragment _this);
    
        /// <summary>
        /// Constructor for the class Grammar
        /// </summary>
        void Grammar(Grammar _this);
    
        /// <summary>
        /// Constructor for the class LAlternative
        /// </summary>
        void LAlternative(LAlternative _this);
    
        /// <summary>
        /// Constructor for the class LElement
        /// </summary>
        void LElement(LElement _this);
    
        /// <summary>
        /// Constructor for the class LElementValue
        /// </summary>
        void LElementValue(LElementValue _this);
    
        /// <summary>
        /// Constructor for the class LBlock
        /// </summary>
        void LBlock(LBlock _this);
    
        /// <summary>
        /// Constructor for the class LFixed
        /// </summary>
        void LFixed(LFixed _this);
    
        /// <summary>
        /// Constructor for the class LRange
        /// </summary>
        void LRange(LRange _this);
    
        /// <summary>
        /// Constructor for the class LReference
        /// </summary>
        void LReference(LReference _this);
    
        /// <summary>
        /// Constructor for the class LSet
        /// </summary>
        void LSet(LSet _this);
    
        /// <summary>
        /// Constructor for the class LSetItem
        /// </summary>
        void LSetItem(LSetItem _this);
    
        /// <summary>
        /// Constructor for the class LSetChar
        /// </summary>
        void LSetChar(LSetChar _this);
    
        /// <summary>
        /// Constructor for the class LSetRange
        /// </summary>
        void LSetRange(LSetRange _this);
    
        /// <summary>
        /// Constructor for the class LWildCard
        /// </summary>
        void LWildCard(LWildCard _this);
    
        /// <summary>
        /// Constructor for the class Namespace
        /// </summary>
        void Namespace(Namespace _this);
    
        /// <summary>
        /// Constructor for the class Rule
        /// </summary>
        void Rule(Rule _this);
    
        /// <summary>
        /// Constructor for the class RuleRef
        /// </summary>
        void RuleRef(RuleRef _this);
    
        /// <summary>
        /// Constructor for the class SeparatedList
        /// </summary>
        void SeparatedList(SeparatedList _this);
    
        /// <summary>
        /// Constructor for the class Token
        /// </summary>
        void Token(Token _this);
    
        /// <summary>
        /// Constructor for the class TokenAlts
        /// </summary>
        void TokenAlts(TokenAlts _this);
    
        /// <summary>
        /// Constructor for the class TokenKind
        /// </summary>
        void TokenKind(TokenKind _this);
    
    
        /// <summary>
        /// Computation of the derived property Binder.ConstructorArguments
        /// </summary>
        string Binder_ConstructorArguments(Binder _this);
    
        /// <summary>
        /// Computation of the derived property Declaration.FullName
        /// </summary>
        string? Declaration_FullName(Declaration _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenName
        /// </summary>
        string Alternative_GreenName(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenConstructorParameters
        /// </summary>
        string Alternative_GreenConstructorParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenConstructorArguments
        /// </summary>
        string Alternative_GreenConstructorArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenUpdateParameters
        /// </summary>
        string Alternative_GreenUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenUpdateArguments
        /// </summary>
        string Alternative_GreenUpdateArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedName
        /// </summary>
        string Alternative_RedName(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedUpdateParameters
        /// </summary>
        string Alternative_RedUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedUpdateArguments
        /// </summary>
        string Alternative_RedUpdateArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedOptionalUpdateParameters
        /// </summary>
        string Alternative_RedOptionalUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedToGreenArgumentList
        /// </summary>
        string Alternative_RedToGreenArgumentList(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedToGreenOptionalArgumentList
        /// </summary>
        string Alternative_RedToGreenOptionalArgumentList(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.HasRedToGreenOptionalArguments
        /// </summary>
        bool Alternative_HasRedToGreenOptionalArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.GreenType
        /// </summary>
        string ElementValue_GreenType(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.GreenSyntaxCondition
        /// </summary>
        string? ElementValue_GreenSyntaxCondition(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.RedType
        /// </summary>
        string ElementValue_RedType(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property Block.GreenType
        /// </summary>
        string Block_GreenType(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.GreenSyntaxCondition
        /// </summary>
        string? Block_GreenSyntaxCondition(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.RedType
        /// </summary>
        string Block_RedType(Block _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsToken
        /// </summary>
        bool Element_IsToken(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsList
        /// </summary>
        bool Element_IsList(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.FieldName
        /// </summary>
        string Element_FieldName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.ParameterName
        /// </summary>
        string Element_ParameterName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.PropertyName
        /// </summary>
        string Element_PropertyName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenFieldType
        /// </summary>
        string Element_GreenFieldType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenParameterValue
        /// </summary>
        string Element_GreenParameterValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenPropertyType
        /// </summary>
        string Element_GreenPropertyType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenPropertyValue
        /// </summary>
        string Element_GreenPropertyValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenSyntaxNullCondition
        /// </summary>
        string? Element_GreenSyntaxNullCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenSyntaxCondition
        /// </summary>
        string? Element_GreenSyntaxCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsOptionalUpdateParameter
        /// </summary>
        bool Element_IsOptionalUpdateParameter(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedFieldType
        /// </summary>
        string Element_RedFieldType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedParameterValue
        /// </summary>
        string Element_RedParameterValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedPropertyType
        /// </summary>
        string Element_RedPropertyType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedPropertyValue
        /// </summary>
        string Element_RedPropertyValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedToGreenArgument
        /// </summary>
        string Element_RedToGreenArgument(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedToGreenOptionalArgument
        /// </summary>
        string Element_RedToGreenOptionalArgument(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedSyntaxNullCondition
        /// </summary>
        string? Element_RedSyntaxNullCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedSyntaxCondition
        /// </summary>
        string? Element_RedSyntaxCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.VisitCall
        /// </summary>
        string? Element_VisitCall(Element _this);
    
        /// <summary>
        /// Computation of the derived property Eof.GreenType
        /// </summary>
        string Eof_GreenType(Eof _this);
    
        /// <summary>
        /// Computation of the derived property Eof.GreenSyntaxCondition
        /// </summary>
        string? Eof_GreenSyntaxCondition(Eof _this);
    
        /// <summary>
        /// Computation of the derived property Eof.RedType
        /// </summary>
        string Eof_RedType(Eof _this);
    
        /// <summary>
        /// Computation of the derived property GrammarRule.Language
        /// </summary>
        Language GrammarRule_Language(GrammarRule _this);
    
        /// <summary>
        /// Computation of the derived property Language.Namespace
        /// </summary>
        string Language_Namespace(Language _this);
    
        /// <summary>
        /// Computation of the derived property LexerRule.IsFixed
        /// </summary>
        bool LexerRule_IsFixed(LexerRule _this);
    
        /// <summary>
        /// Computation of the derived property LexerRule.FixedText
        /// </summary>
        string? LexerRule_FixedText(LexerRule _this);
    
        /// <summary>
        /// Computation of the derived property LAlternative.IsFixed
        /// </summary>
        bool LAlternative_IsFixed(LAlternative _this);
    
        /// <summary>
        /// Computation of the derived property LAlternative.FixedText
        /// </summary>
        string? LAlternative_FixedText(LAlternative _this);
    
        /// <summary>
        /// Computation of the derived property LElement.IsFixed
        /// </summary>
        bool LElement_IsFixed(LElement _this);
    
        /// <summary>
        /// Computation of the derived property LElement.FixedText
        /// </summary>
        string? LElement_FixedText(LElement _this);
    
        /// <summary>
        /// Computation of the derived property LElementValue.IsFixed
        /// </summary>
        bool LElementValue_IsFixed(LElementValue _this);
    
        /// <summary>
        /// Computation of the derived property LElementValue.FixedText
        /// </summary>
        string? LElementValue_FixedText(LElementValue _this);
    
        /// <summary>
        /// Computation of the derived property LBlock.IsFixed
        /// </summary>
        bool LBlock_IsFixed(LBlock _this);
    
        /// <summary>
        /// Computation of the derived property LBlock.FixedText
        /// </summary>
        string? LBlock_FixedText(LBlock _this);
    
        /// <summary>
        /// Computation of the derived property LFixed.IsFixed
        /// </summary>
        bool LFixed_IsFixed(LFixed _this);
    
        /// <summary>
        /// Computation of the derived property LFixed.FixedText
        /// </summary>
        string? LFixed_FixedText(LFixed _this);
    
        /// <summary>
        /// Computation of the derived property LRange.IsFixed
        /// </summary>
        bool LRange_IsFixed(LRange _this);
    
        /// <summary>
        /// Computation of the derived property LRange.FixedText
        /// </summary>
        string? LRange_FixedText(LRange _this);
    
        /// <summary>
        /// Computation of the derived property LReference.IsFixed
        /// </summary>
        bool LReference_IsFixed(LReference _this);
    
        /// <summary>
        /// Computation of the derived property LReference.FixedText
        /// </summary>
        string? LReference_FixedText(LReference _this);
    
        /// <summary>
        /// Computation of the derived property LSet.IsFixed
        /// </summary>
        bool LSet_IsFixed(LSet _this);
    
        /// <summary>
        /// Computation of the derived property LSet.FixedText
        /// </summary>
        string? LSet_FixedText(LSet _this);
    
        /// <summary>
        /// Computation of the derived property LSetItem.IsFixed
        /// </summary>
        bool LSetItem_IsFixed(LSetItem _this);
    
        /// <summary>
        /// Computation of the derived property LSetItem.FixedText
        /// </summary>
        string? LSetItem_FixedText(LSetItem _this);
    
        /// <summary>
        /// Computation of the derived property LSetChar.IsFixed
        /// </summary>
        bool LSetChar_IsFixed(LSetChar _this);
    
        /// <summary>
        /// Computation of the derived property LSetChar.FixedText
        /// </summary>
        string? LSetChar_FixedText(LSetChar _this);
    
        /// <summary>
        /// Computation of the derived property LSetRange.IsFixed
        /// </summary>
        bool LSetRange_IsFixed(LSetRange _this);
    
        /// <summary>
        /// Computation of the derived property LSetRange.FixedText
        /// </summary>
        string? LSetRange_FixedText(LSetRange _this);
    
        /// <summary>
        /// Computation of the derived property LWildCard.IsFixed
        /// </summary>
        bool LWildCard_IsFixed(LWildCard _this);
    
        /// <summary>
        /// Computation of the derived property LWildCard.FixedText
        /// </summary>
        string? LWildCard_FixedText(LWildCard _this);
    
        /// <summary>
        /// Computation of the derived property Rule.GreenName
        /// </summary>
        string Rule_GreenName(Rule _this);
    
        /// <summary>
        /// Computation of the derived property Rule.RedName
        /// </summary>
        string Rule_RedName(Rule _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.Token
        /// </summary>
        Token? RuleRef_Token(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.Rule
        /// </summary>
        Rule? RuleRef_Rule(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.GreenType
        /// </summary>
        string RuleRef_GreenType(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.GreenSyntaxCondition
        /// </summary>
        string? RuleRef_GreenSyntaxCondition(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.RedType
        /// </summary>
        string RuleRef_RedType(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.GreenType
        /// </summary>
        string SeparatedList_GreenType(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.GreenSyntaxCondition
        /// </summary>
        string? SeparatedList_GreenSyntaxCondition(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.RedType
        /// </summary>
        string SeparatedList_RedType(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.GreenType
        /// </summary>
        string TokenAlts_GreenType(TokenAlts _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.GreenSyntaxCondition
        /// </summary>
        string? TokenAlts_GreenSyntaxCondition(TokenAlts _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.RedType
        /// </summary>
        string TokenAlts_RedType(TokenAlts _this);
    
    
    }
}
