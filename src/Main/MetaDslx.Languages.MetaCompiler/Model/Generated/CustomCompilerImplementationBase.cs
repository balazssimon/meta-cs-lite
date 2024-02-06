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

    internal abstract class CustomCompilerImplementationBase : ICustomCompilerImplementation
    {
        /// <summary>
        /// Constructor for the meta model Compiler
        /// </summary>
        public virtual void Compiler(ICompiler _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Annotation
        /// </summary>
        public virtual void Annotation(Annotation _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class AnnotationArgument
        /// </summary>
        public virtual void AnnotationArgument(AnnotationArgument _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ArrayExpression
        /// </summary>
        public virtual void ArrayExpression(ArrayExpression _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Binder
        /// </summary>
        public virtual void Binder(Binder _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class BinderArgument
        /// </summary>
        public virtual void BinderArgument(BinderArgument _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CSharpElement
        /// </summary>
        public virtual void CSharpElement(CSharpElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Declaration
        /// </summary>
        public virtual void Declaration(Declaration _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Alternative
        /// </summary>
        public virtual void Alternative(Alternative _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ElementValue
        /// </summary>
        public virtual void ElementValue(ElementValue _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Block
        /// </summary>
        public virtual void Block(Block _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Element
        /// </summary>
        public virtual void Element(Element _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Eof
        /// </summary>
        public virtual void Eof(Eof _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Expression
        /// </summary>
        public virtual void Expression(Expression _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Fixed
        /// </summary>
        public virtual void Fixed(Fixed _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class GrammarRule
        /// </summary>
        public virtual void GrammarRule(GrammarRule _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Language
        /// </summary>
        public virtual void Language(Language _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LexerRule
        /// </summary>
        public virtual void LexerRule(LexerRule _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Fragment
        /// </summary>
        public virtual void Fragment(Fragment _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Grammar
        /// </summary>
        public virtual void Grammar(Grammar _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LAlternative
        /// </summary>
        public virtual void LAlternative(LAlternative _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LElement
        /// </summary>
        public virtual void LElement(LElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LElementValue
        /// </summary>
        public virtual void LElementValue(LElementValue _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LBlock
        /// </summary>
        public virtual void LBlock(LBlock _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LFixed
        /// </summary>
        public virtual void LFixed(LFixed _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LRange
        /// </summary>
        public virtual void LRange(LRange _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LReference
        /// </summary>
        public virtual void LReference(LReference _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LSet
        /// </summary>
        public virtual void LSet(LSet _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LSetItem
        /// </summary>
        public virtual void LSetItem(LSetItem _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LSetChar
        /// </summary>
        public virtual void LSetChar(LSetChar _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LSetRange
        /// </summary>
        public virtual void LSetRange(LSetRange _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LWildCard
        /// </summary>
        public virtual void LWildCard(LWildCard _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Namespace
        /// </summary>
        public virtual void Namespace(Namespace _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Rule
        /// </summary>
        public virtual void Rule(Rule _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class RuleRef
        /// </summary>
        public virtual void RuleRef(RuleRef _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class SeparatedList
        /// </summary>
        public virtual void SeparatedList(SeparatedList _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Token
        /// </summary>
        public virtual void Token(Token _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TokenAlts
        /// </summary>
        public virtual void TokenAlts(TokenAlts _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TokenKind
        /// </summary>
        public virtual void TokenKind(TokenKind _this)
        {
        }
    
    
        /// <summary>
        /// Computation of the derived property Binder.ConstructorArguments
        /// </summary>
        public abstract string Binder_ConstructorArguments(Binder _this);
    
        /// <summary>
        /// Computation of the derived property Declaration.FullName
        /// </summary>
        public abstract string? Declaration_FullName(Declaration _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenName
        /// </summary>
        public abstract string Alternative_GreenName(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenConstructorParameters
        /// </summary>
        public abstract string Alternative_GreenConstructorParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenConstructorArguments
        /// </summary>
        public abstract string Alternative_GreenConstructorArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenUpdateParameters
        /// </summary>
        public abstract string Alternative_GreenUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenUpdateArguments
        /// </summary>
        public abstract string Alternative_GreenUpdateArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedName
        /// </summary>
        public abstract string Alternative_RedName(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedUpdateParameters
        /// </summary>
        public abstract string Alternative_RedUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedUpdateArguments
        /// </summary>
        public abstract string Alternative_RedUpdateArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedOptionalUpdateParameters
        /// </summary>
        public abstract string Alternative_RedOptionalUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedToGreenArgumentList
        /// </summary>
        public abstract string Alternative_RedToGreenArgumentList(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedToGreenOptionalArgumentList
        /// </summary>
        public abstract string Alternative_RedToGreenOptionalArgumentList(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.HasRedToGreenOptionalArguments
        /// </summary>
        public abstract bool Alternative_HasRedToGreenOptionalArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.GreenType
        /// </summary>
        public abstract string ElementValue_GreenType(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.GreenSyntaxCondition
        /// </summary>
        public abstract string? ElementValue_GreenSyntaxCondition(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.RedType
        /// </summary>
        public abstract string ElementValue_RedType(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property Block.GreenType
        /// </summary>
        public abstract string Block_GreenType(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.GreenSyntaxCondition
        /// </summary>
        public abstract string? Block_GreenSyntaxCondition(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.RedType
        /// </summary>
        public abstract string Block_RedType(Block _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsToken
        /// </summary>
        public abstract bool Element_IsToken(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsList
        /// </summary>
        public abstract bool Element_IsList(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.FieldName
        /// </summary>
        public abstract string Element_FieldName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.ParameterName
        /// </summary>
        public abstract string Element_ParameterName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.PropertyName
        /// </summary>
        public abstract string Element_PropertyName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenFieldType
        /// </summary>
        public abstract string Element_GreenFieldType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenParameterValue
        /// </summary>
        public abstract string Element_GreenParameterValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenPropertyType
        /// </summary>
        public abstract string Element_GreenPropertyType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenPropertyValue
        /// </summary>
        public abstract string Element_GreenPropertyValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenSyntaxNullCondition
        /// </summary>
        public abstract string? Element_GreenSyntaxNullCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenSyntaxCondition
        /// </summary>
        public abstract string? Element_GreenSyntaxCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsOptionalUpdateParameter
        /// </summary>
        public abstract bool Element_IsOptionalUpdateParameter(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedFieldType
        /// </summary>
        public abstract string Element_RedFieldType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedParameterValue
        /// </summary>
        public abstract string Element_RedParameterValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedPropertyType
        /// </summary>
        public abstract string Element_RedPropertyType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedPropertyValue
        /// </summary>
        public abstract string Element_RedPropertyValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedToGreenArgument
        /// </summary>
        public abstract string Element_RedToGreenArgument(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedToGreenOptionalArgument
        /// </summary>
        public abstract string Element_RedToGreenOptionalArgument(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedSyntaxNullCondition
        /// </summary>
        public abstract string? Element_RedSyntaxNullCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedSyntaxCondition
        /// </summary>
        public abstract string? Element_RedSyntaxCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.VisitCall
        /// </summary>
        public abstract string? Element_VisitCall(Element _this);
    
        /// <summary>
        /// Computation of the derived property Eof.GreenType
        /// </summary>
        public abstract string Eof_GreenType(Eof _this);
    
        /// <summary>
        /// Computation of the derived property Eof.GreenSyntaxCondition
        /// </summary>
        public abstract string? Eof_GreenSyntaxCondition(Eof _this);
    
        /// <summary>
        /// Computation of the derived property Eof.RedType
        /// </summary>
        public abstract string Eof_RedType(Eof _this);
    
        /// <summary>
        /// Computation of the derived property GrammarRule.Language
        /// </summary>
        public abstract Language GrammarRule_Language(GrammarRule _this);
    
        /// <summary>
        /// Computation of the derived property Language.Namespace
        /// </summary>
        public abstract string Language_Namespace(Language _this);
    
        /// <summary>
        /// Computation of the derived property LexerRule.IsFixed
        /// </summary>
        public abstract bool LexerRule_IsFixed(LexerRule _this);
    
        /// <summary>
        /// Computation of the derived property LexerRule.FixedText
        /// </summary>
        public abstract string? LexerRule_FixedText(LexerRule _this);
    
        /// <summary>
        /// Computation of the derived property LAlternative.IsFixed
        /// </summary>
        public abstract bool LAlternative_IsFixed(LAlternative _this);
    
        /// <summary>
        /// Computation of the derived property LAlternative.FixedText
        /// </summary>
        public abstract string? LAlternative_FixedText(LAlternative _this);
    
        /// <summary>
        /// Computation of the derived property LElement.IsFixed
        /// </summary>
        public abstract bool LElement_IsFixed(LElement _this);
    
        /// <summary>
        /// Computation of the derived property LElement.FixedText
        /// </summary>
        public abstract string? LElement_FixedText(LElement _this);
    
        /// <summary>
        /// Computation of the derived property LElementValue.IsFixed
        /// </summary>
        public abstract bool LElementValue_IsFixed(LElementValue _this);
    
        /// <summary>
        /// Computation of the derived property LElementValue.FixedText
        /// </summary>
        public abstract string? LElementValue_FixedText(LElementValue _this);
    
        /// <summary>
        /// Computation of the derived property LBlock.IsFixed
        /// </summary>
        public abstract bool LBlock_IsFixed(LBlock _this);
    
        /// <summary>
        /// Computation of the derived property LBlock.FixedText
        /// </summary>
        public abstract string? LBlock_FixedText(LBlock _this);
    
        /// <summary>
        /// Computation of the derived property LFixed.IsFixed
        /// </summary>
        public abstract bool LFixed_IsFixed(LFixed _this);
    
        /// <summary>
        /// Computation of the derived property LFixed.FixedText
        /// </summary>
        public abstract string? LFixed_FixedText(LFixed _this);
    
        /// <summary>
        /// Computation of the derived property LRange.IsFixed
        /// </summary>
        public abstract bool LRange_IsFixed(LRange _this);
    
        /// <summary>
        /// Computation of the derived property LRange.FixedText
        /// </summary>
        public abstract string? LRange_FixedText(LRange _this);
    
        /// <summary>
        /// Computation of the derived property LReference.IsFixed
        /// </summary>
        public abstract bool LReference_IsFixed(LReference _this);
    
        /// <summary>
        /// Computation of the derived property LReference.FixedText
        /// </summary>
        public abstract string? LReference_FixedText(LReference _this);
    
        /// <summary>
        /// Computation of the derived property LSet.IsFixed
        /// </summary>
        public abstract bool LSet_IsFixed(LSet _this);
    
        /// <summary>
        /// Computation of the derived property LSet.FixedText
        /// </summary>
        public abstract string? LSet_FixedText(LSet _this);
    
        /// <summary>
        /// Computation of the derived property LSetItem.IsFixed
        /// </summary>
        public abstract bool LSetItem_IsFixed(LSetItem _this);
    
        /// <summary>
        /// Computation of the derived property LSetItem.FixedText
        /// </summary>
        public abstract string? LSetItem_FixedText(LSetItem _this);
    
        /// <summary>
        /// Computation of the derived property LSetChar.IsFixed
        /// </summary>
        public abstract bool LSetChar_IsFixed(LSetChar _this);
    
        /// <summary>
        /// Computation of the derived property LSetChar.FixedText
        /// </summary>
        public abstract string? LSetChar_FixedText(LSetChar _this);
    
        /// <summary>
        /// Computation of the derived property LSetRange.IsFixed
        /// </summary>
        public abstract bool LSetRange_IsFixed(LSetRange _this);
    
        /// <summary>
        /// Computation of the derived property LSetRange.FixedText
        /// </summary>
        public abstract string? LSetRange_FixedText(LSetRange _this);
    
        /// <summary>
        /// Computation of the derived property LWildCard.IsFixed
        /// </summary>
        public abstract bool LWildCard_IsFixed(LWildCard _this);
    
        /// <summary>
        /// Computation of the derived property LWildCard.FixedText
        /// </summary>
        public abstract string? LWildCard_FixedText(LWildCard _this);
    
        /// <summary>
        /// Computation of the derived property Rule.GreenName
        /// </summary>
        public abstract string Rule_GreenName(Rule _this);
    
        /// <summary>
        /// Computation of the derived property Rule.RedName
        /// </summary>
        public abstract string Rule_RedName(Rule _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.Token
        /// </summary>
        public abstract Token? RuleRef_Token(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.Rule
        /// </summary>
        public abstract Rule? RuleRef_Rule(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.GreenType
        /// </summary>
        public abstract string RuleRef_GreenType(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.GreenSyntaxCondition
        /// </summary>
        public abstract string? RuleRef_GreenSyntaxCondition(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.RedType
        /// </summary>
        public abstract string RuleRef_RedType(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.GreenType
        /// </summary>
        public abstract string SeparatedList_GreenType(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.GreenSyntaxCondition
        /// </summary>
        public abstract string? SeparatedList_GreenSyntaxCondition(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.RedType
        /// </summary>
        public abstract string SeparatedList_RedType(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.GreenType
        /// </summary>
        public abstract string TokenAlts_GreenType(TokenAlts _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.GreenSyntaxCondition
        /// </summary>
        public abstract string? TokenAlts_GreenSyntaxCondition(TokenAlts _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.RedType
        /// </summary>
        public abstract string TokenAlts_RedType(TokenAlts _this);
    
    
    }
}
