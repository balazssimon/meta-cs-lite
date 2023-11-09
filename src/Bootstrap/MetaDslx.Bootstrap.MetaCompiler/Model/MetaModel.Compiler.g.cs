#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Model
{
	using __MetaMetaModel = global::MetaDslx.Languages.MetaModel.Model.Meta;
	using __MetaModelFactory = global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;
	using __Model = global::MetaDslx.Modeling.Model;
	using __MetaModel = global::MetaDslx.Modeling.MetaModel;
	using __IModelObject = global::MetaDslx.Modeling.IModelObject;
	using __IModelObjectCore = global::MetaDslx.Modeling.IModelObjectCore;
	using __ModelFactory = global::MetaDslx.Modeling.ModelFactory;
	using __MultiModelFactory = global::MetaDslx.Modeling.MultiModelFactory;
	using __ModelVersion = global::MetaDslx.Modeling.ModelVersion;
	using __ModelObjectInfo = global::MetaDslx.Modeling.ModelObjectInfo;
	using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
	using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
	using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
	using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
	using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
	using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
	using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
	using __Type = global::System.Type;

	internal interface ICompiler
	{
	}
	
	public sealed class Compiler : __MetaModel, ICompiler
	{
		// If there is an error at the following line, create a new class called 'CustomCompilerImplementation'
		// inheriting from the class 'CustomCompilerImplementationBase' and provide the custom implementation
		// for the derived properties and operations defined in the metamodel
		internal static readonly CustomCompilerImplementationBase __CustomImpl = new CustomCompilerImplementation();
	
		private static readonly Compiler _instance;
		public static Compiler Instance => _instance;
	
		private static readonly __ModelProperty _Declaration_Annotations;
		private static readonly __ModelProperty _Declaration_Name;
		private static readonly __ModelProperty _Declaration_Parent;
		private static readonly __ModelProperty _Declaration_Declarations;
		private static readonly __ModelProperty _Declaration_FullName;
		private static readonly __ModelProperty _Language_Grammar;
		private static readonly __ModelProperty _Grammar_Language;
		private static readonly __ModelProperty _Grammar_Rules;
		private static readonly __ModelProperty _Annotation_Type;
		private static readonly __ModelProperty _Annotation_Arguments;
		private static readonly __ModelProperty _AnnotationArgument_Parameter;
		private static readonly __ModelProperty _AnnotationArgument_Type;
		private static readonly __ModelProperty _AnnotationArgument_Value;
		private static readonly __ModelProperty _Rule_Language;
		private static readonly __ModelProperty _Rule_Grammar;
		private static readonly __ModelProperty _LexerRule_ReturnType;
		private static readonly __ModelProperty _LexerRule_IsHidden;
		private static readonly __ModelProperty _LexerRule_IsFragment;
		private static readonly __ModelProperty _LexerRule_IsFixed;
		private static readonly __ModelProperty _LexerRule_FixedText;
		private static readonly __ModelProperty _LexerRule_Alternatives;
		private static readonly __ModelProperty _LexerRuleAlternative_IsFixed;
		private static readonly __ModelProperty _LexerRuleAlternative_FixedText;
		private static readonly __ModelProperty _LexerRuleAlternative_Elements;
		private static readonly __ModelProperty _LexerRuleElement_IsFixed;
		private static readonly __ModelProperty _LexerRuleElement_FixedText;
		private static readonly __ModelProperty _LexerRuleElement_IsNegated;
		private static readonly __ModelProperty _LexerRuleElement_Multiplicity;
		private static readonly __ModelProperty _LexerRuleReferenceElement_IsFixed;
		private static readonly __ModelProperty _LexerRuleReferenceElement_FixedText;
		private static readonly __ModelProperty _LexerRuleReferenceElement_Rule;
		private static readonly __ModelProperty _LexerRuleFixedStringElement_IsFixed;
		private static readonly __ModelProperty _LexerRuleFixedStringElement_FixedText;
		private static readonly __ModelProperty _LexerRuleFixedStringElement_Text;
		private static readonly __ModelProperty _LexerRuleWildCardElement_IsFixed;
		private static readonly __ModelProperty _LexerRuleWildCardElement_FixedText;
		private static readonly __ModelProperty _LexerRuleRangeElement_IsFixed;
		private static readonly __ModelProperty _LexerRuleRangeElement_FixedText;
		private static readonly __ModelProperty _LexerRuleRangeElement_StartChar;
		private static readonly __ModelProperty _LexerRuleRangeElement_EndChar;
		private static readonly __ModelProperty _LexerRuleSetElement_IsFixed;
		private static readonly __ModelProperty _LexerRuleSetElement_FixedText;
		private static readonly __ModelProperty _LexerRuleSetElement_Items;
		private static readonly __ModelProperty _LexerRuleSetItem_IsFixed;
		private static readonly __ModelProperty _LexerRuleSetItem_FixedText;
		private static readonly __ModelProperty _LexerRuleSetFixedChar_IsFixed;
		private static readonly __ModelProperty _LexerRuleSetFixedChar_FixedText;
		private static readonly __ModelProperty _LexerRuleSetFixedChar_Char;
		private static readonly __ModelProperty _LexerRuleSetRange_IsFixed;
		private static readonly __ModelProperty _LexerRuleSetRange_FixedText;
		private static readonly __ModelProperty _LexerRuleSetRange_StartChar;
		private static readonly __ModelProperty _LexerRuleSetRange_EndChar;
		private static readonly __ModelProperty _LexerRuleBlockElement_IsFixed;
		private static readonly __ModelProperty _LexerRuleBlockElement_FixedText;
		private static readonly __ModelProperty _LexerRuleBlockElement_Alternatives;
		private static readonly __ModelProperty _ParserRule_ReturnType;
		private static readonly __ModelProperty _ParserRule_IsBlock;
		private static readonly __ModelProperty _ParserRule_Alternatives;
		private static readonly __ModelProperty _ParserRuleAlternative_ReturnType;
		private static readonly __ModelProperty _ParserRuleAlternative_ReturnValue;
		private static readonly __ModelProperty _ParserRuleAlternative_Elements;
		private static readonly __ModelProperty _ParserRuleElement_NameAnnotations;
		private static readonly __ModelProperty _ParserRuleElement_ValueAnnotations;
		private static readonly __ModelProperty _ParserRuleElement_Property;
		private static readonly __ModelProperty _ParserRuleElement_AssignmentOperator;
		private static readonly __ModelProperty _ParserRuleElement_Multiplicity;
		private static readonly __ModelProperty _ParserRuleReferenceElement_Rule;
		private static readonly __ModelProperty _ParserRuleReferenceElement_ReferencedTypes;
		private static readonly __ModelProperty _ParserRuleFixedStringElement_Text;
		private static readonly __ModelProperty _ParserRuleBlockElement_Alternatives;
		private static readonly __ModelProperty _Expression_Value;
		private static readonly __ModelProperty _NullExpression_Value;
		private static readonly __ModelProperty _BoolExpression_Value;
		private static readonly __ModelProperty _BoolExpression_BoolValue;
		private static readonly __ModelProperty _IntExpression_Value;
		private static readonly __ModelProperty _IntExpression_IntValue;
		private static readonly __ModelProperty _StringExpression_Value;
		private static readonly __ModelProperty _StringExpression_StringValue;
		private static readonly __ModelProperty _ReferenceExpression_Value;
		private static readonly __ModelProperty _ReferenceExpression_SymbolValue;
	
		static Compiler()
		{
			_Declaration_Annotations = new __ModelProperty(typeof(Declaration), "Annotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Declaration_Declarations = new __ModelProperty(typeof(Declaration), "Declarations", typeof(Declaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Declaration_FullName = new __ModelProperty(typeof(Declaration), "FullName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Declaration_Name = new __ModelProperty(typeof(Declaration), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.Name, "Name");
			_Declaration_Parent = new __ModelProperty(typeof(Declaration), "Parent", typeof(Declaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Language_Grammar = new __ModelProperty(typeof(Language), "Grammar", typeof(Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_Grammar_Language = new __ModelProperty(typeof(Grammar), "Language", typeof(Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Grammar_Rules = new __ModelProperty(typeof(Grammar), "Rules", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Annotation_Arguments = new __ModelProperty(typeof(Annotation), "Arguments", typeof(AnnotationArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Annotation_Type = new __ModelProperty(typeof(Annotation), "Type", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_AnnotationArgument_Parameter = new __ModelProperty(typeof(AnnotationArgument), "Parameter", typeof(__MetaSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_AnnotationArgument_Type = new __ModelProperty(typeof(AnnotationArgument), "Type", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_AnnotationArgument_Value = new __ModelProperty(typeof(AnnotationArgument), "Value", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_Rule_Grammar = new __ModelProperty(typeof(Rule), "Grammar", typeof(Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Rule_Language = new __ModelProperty(typeof(Rule), "Language", typeof(Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRule_Alternatives = new __ModelProperty(typeof(LexerRule), "Alternatives", typeof(LexerRuleAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LexerRule_FixedText = new __ModelProperty(typeof(LexerRule), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRule_IsFixed = new __ModelProperty(typeof(LexerRule), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRule_IsFragment = new __ModelProperty(typeof(LexerRule), "IsFragment", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRule_IsHidden = new __ModelProperty(typeof(LexerRule), "IsHidden", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRule_ReturnType = new __ModelProperty(typeof(LexerRule), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRuleAlternative_Elements = new __ModelProperty(typeof(LexerRuleAlternative), "Elements", typeof(LexerRuleElement), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LexerRuleAlternative_FixedText = new __ModelProperty(typeof(LexerRuleAlternative), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleAlternative_IsFixed = new __ModelProperty(typeof(LexerRuleAlternative), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleElement_FixedText = new __ModelProperty(typeof(LexerRuleElement), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleElement_IsFixed = new __ModelProperty(typeof(LexerRuleElement), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleElement_IsNegated = new __ModelProperty(typeof(LexerRuleElement), "IsNegated", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRuleElement_Multiplicity = new __ModelProperty(typeof(LexerRuleElement), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.SingleItem, null);
			_LexerRuleReferenceElement_FixedText = new __ModelProperty(typeof(LexerRuleReferenceElement), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleReferenceElement_IsFixed = new __ModelProperty(typeof(LexerRuleReferenceElement), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleReferenceElement_Rule = new __ModelProperty(typeof(LexerRuleReferenceElement), "Rule", typeof(LexerRule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_LexerRuleFixedStringElement_FixedText = new __ModelProperty(typeof(LexerRuleFixedStringElement), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleFixedStringElement_IsFixed = new __ModelProperty(typeof(LexerRuleFixedStringElement), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleFixedStringElement_Text = new __ModelProperty(typeof(LexerRuleFixedStringElement), "Text", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRuleWildCardElement_FixedText = new __ModelProperty(typeof(LexerRuleWildCardElement), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleWildCardElement_IsFixed = new __ModelProperty(typeof(LexerRuleWildCardElement), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleRangeElement_EndChar = new __ModelProperty(typeof(LexerRuleRangeElement), "EndChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRuleRangeElement_FixedText = new __ModelProperty(typeof(LexerRuleRangeElement), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleRangeElement_IsFixed = new __ModelProperty(typeof(LexerRuleRangeElement), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleRangeElement_StartChar = new __ModelProperty(typeof(LexerRuleRangeElement), "StartChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRuleSetElement_FixedText = new __ModelProperty(typeof(LexerRuleSetElement), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleSetElement_IsFixed = new __ModelProperty(typeof(LexerRuleSetElement), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleSetElement_Items = new __ModelProperty(typeof(LexerRuleSetElement), "Items", typeof(LexerRuleSetItem), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LexerRuleSetItem_FixedText = new __ModelProperty(typeof(LexerRuleSetItem), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleSetItem_IsFixed = new __ModelProperty(typeof(LexerRuleSetItem), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleSetFixedChar_Char = new __ModelProperty(typeof(LexerRuleSetFixedChar), "Char", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRuleSetFixedChar_FixedText = new __ModelProperty(typeof(LexerRuleSetFixedChar), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleSetFixedChar_IsFixed = new __ModelProperty(typeof(LexerRuleSetFixedChar), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleSetRange_EndChar = new __ModelProperty(typeof(LexerRuleSetRange), "EndChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRuleSetRange_FixedText = new __ModelProperty(typeof(LexerRuleSetRange), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleSetRange_IsFixed = new __ModelProperty(typeof(LexerRuleSetRange), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleSetRange_StartChar = new __ModelProperty(typeof(LexerRuleSetRange), "StartChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRuleBlockElement_Alternatives = new __ModelProperty(typeof(LexerRuleBlockElement), "Alternatives", typeof(LexerRuleAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LexerRuleBlockElement_FixedText = new __ModelProperty(typeof(LexerRuleBlockElement), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRuleBlockElement_IsFixed = new __ModelProperty(typeof(LexerRuleBlockElement), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_ParserRule_Alternatives = new __ModelProperty(typeof(ParserRule), "Alternatives", typeof(ParserRuleAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_ParserRule_IsBlock = new __ModelProperty(typeof(ParserRule), "IsBlock", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_ParserRule_ReturnType = new __ModelProperty(typeof(ParserRule), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_ParserRuleAlternative_Elements = new __ModelProperty(typeof(ParserRuleAlternative), "Elements", typeof(ParserRuleElement), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_ParserRuleAlternative_ReturnType = new __ModelProperty(typeof(ParserRuleAlternative), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_ParserRuleAlternative_ReturnValue = new __ModelProperty(typeof(ParserRuleAlternative), "ReturnValue", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_ParserRuleElement_AssignmentOperator = new __ModelProperty(typeof(ParserRuleElement), "AssignmentOperator", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.SingleItem, null);
			_ParserRuleElement_Multiplicity = new __ModelProperty(typeof(ParserRuleElement), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.SingleItem, null);
			_ParserRuleElement_NameAnnotations = new __ModelProperty(typeof(ParserRuleElement), "NameAnnotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_ParserRuleElement_Property = new __ModelProperty(typeof(ParserRuleElement), "Property", typeof(__MetaSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_ParserRuleElement_ValueAnnotations = new __ModelProperty(typeof(ParserRuleElement), "ValueAnnotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_ParserRuleReferenceElement_ReferencedTypes = new __ModelProperty(typeof(ParserRuleReferenceElement), "ReferencedTypes", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, null);
			_ParserRuleReferenceElement_Rule = new __ModelProperty(typeof(ParserRuleReferenceElement), "Rule", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_ParserRuleFixedStringElement_Text = new __ModelProperty(typeof(ParserRuleFixedStringElement), "Text", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_ParserRuleBlockElement_Alternatives = new __ModelProperty(typeof(ParserRuleBlockElement), "Alternatives", typeof(ParserRuleAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Expression_Value = new __ModelProperty(typeof(Expression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_NullExpression_Value = new __ModelProperty(typeof(NullExpression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_BoolExpression_BoolValue = new __ModelProperty(typeof(BoolExpression), "BoolValue", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_BoolExpression_Value = new __ModelProperty(typeof(BoolExpression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_IntExpression_IntValue = new __ModelProperty(typeof(IntExpression), "IntValue", typeof(int), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_IntExpression_Value = new __ModelProperty(typeof(IntExpression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_StringExpression_StringValue = new __ModelProperty(typeof(StringExpression), "StringValue", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_StringExpression_Value = new __ModelProperty(typeof(StringExpression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_ReferenceExpression_SymbolValue = new __ModelProperty(typeof(ReferenceExpression), "SymbolValue", typeof(__MetaSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_ReferenceExpression_Value = new __ModelProperty(typeof(ReferenceExpression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_instance = new Compiler();
		}
	
		private readonly __Model _model;
		private readonly global::System.Collections.Immutable.ImmutableArray<__Type> _modelObjectTypes;
		private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _modelObjectInfos;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<__Type, __ModelObjectInfo> _modelObjectInfosByType;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelObjectInfo> _modelObjectInfosByName;
	
	
		private Compiler()
		{
			_modelObjectTypes = __ImmutableArray.Create<__Type>(typeof(Declaration), typeof(Namespace), typeof(Language), typeof(Grammar), typeof(Annotation), typeof(AnnotationArgument), typeof(Rule), typeof(LexerRule), typeof(LexerRuleAlternative), typeof(LexerRuleElement), typeof(LexerRuleReferenceElement), typeof(LexerRuleFixedStringElement), typeof(LexerRuleWildCardElement), typeof(LexerRuleRangeElement), typeof(LexerRuleSetElement), typeof(LexerRuleSetItem), typeof(LexerRuleSetFixedChar), typeof(LexerRuleSetRange), typeof(LexerRuleBlockElement), typeof(ParserRule), typeof(ParserRuleAlternative), typeof(ParserRuleElement), typeof(ParserRuleReferenceElement), typeof(ParserRuleEofElement), typeof(ParserRuleFixedStringElement), typeof(ParserRuleBlockElement), typeof(Expression), typeof(NullExpression), typeof(BoolExpression), typeof(IntExpression), typeof(StringExpression), typeof(ReferenceExpression));
			_modelObjectInfos = __ImmutableArray.Create<__ModelObjectInfo>(DeclarationInfo, NamespaceInfo, LanguageInfo, GrammarInfo, AnnotationInfo, AnnotationArgumentInfo, RuleInfo, LexerRuleInfo, LexerRuleAlternativeInfo, LexerRuleElementInfo, LexerRuleReferenceElementInfo, LexerRuleFixedStringElementInfo, LexerRuleWildCardElementInfo, LexerRuleRangeElementInfo, LexerRuleSetElementInfo, LexerRuleSetItemInfo, LexerRuleSetFixedCharInfo, LexerRuleSetRangeInfo, LexerRuleBlockElementInfo, ParserRuleInfo, ParserRuleAlternativeInfo, ParserRuleElementInfo, ParserRuleReferenceElementInfo, ParserRuleEofElementInfo, ParserRuleFixedStringElementInfo, ParserRuleBlockElementInfo, ExpressionInfo, NullExpressionInfo, BoolExpressionInfo, IntExpressionInfo, StringExpressionInfo, ReferenceExpressionInfo);
			var modelObjectInfosByType = __ImmutableDictionary.CreateBuilder<__Type, __ModelObjectInfo>();
			modelObjectInfosByType.Add(typeof(Declaration), DeclarationInfo);
			modelObjectInfosByType.Add(typeof(Namespace), NamespaceInfo);
			modelObjectInfosByType.Add(typeof(Language), LanguageInfo);
			modelObjectInfosByType.Add(typeof(Grammar), GrammarInfo);
			modelObjectInfosByType.Add(typeof(Annotation), AnnotationInfo);
			modelObjectInfosByType.Add(typeof(AnnotationArgument), AnnotationArgumentInfo);
			modelObjectInfosByType.Add(typeof(Rule), RuleInfo);
			modelObjectInfosByType.Add(typeof(LexerRule), LexerRuleInfo);
			modelObjectInfosByType.Add(typeof(LexerRuleAlternative), LexerRuleAlternativeInfo);
			modelObjectInfosByType.Add(typeof(LexerRuleElement), LexerRuleElementInfo);
			modelObjectInfosByType.Add(typeof(LexerRuleReferenceElement), LexerRuleReferenceElementInfo);
			modelObjectInfosByType.Add(typeof(LexerRuleFixedStringElement), LexerRuleFixedStringElementInfo);
			modelObjectInfosByType.Add(typeof(LexerRuleWildCardElement), LexerRuleWildCardElementInfo);
			modelObjectInfosByType.Add(typeof(LexerRuleRangeElement), LexerRuleRangeElementInfo);
			modelObjectInfosByType.Add(typeof(LexerRuleSetElement), LexerRuleSetElementInfo);
			modelObjectInfosByType.Add(typeof(LexerRuleSetItem), LexerRuleSetItemInfo);
			modelObjectInfosByType.Add(typeof(LexerRuleSetFixedChar), LexerRuleSetFixedCharInfo);
			modelObjectInfosByType.Add(typeof(LexerRuleSetRange), LexerRuleSetRangeInfo);
			modelObjectInfosByType.Add(typeof(LexerRuleBlockElement), LexerRuleBlockElementInfo);
			modelObjectInfosByType.Add(typeof(ParserRule), ParserRuleInfo);
			modelObjectInfosByType.Add(typeof(ParserRuleAlternative), ParserRuleAlternativeInfo);
			modelObjectInfosByType.Add(typeof(ParserRuleElement), ParserRuleElementInfo);
			modelObjectInfosByType.Add(typeof(ParserRuleReferenceElement), ParserRuleReferenceElementInfo);
			modelObjectInfosByType.Add(typeof(ParserRuleEofElement), ParserRuleEofElementInfo);
			modelObjectInfosByType.Add(typeof(ParserRuleFixedStringElement), ParserRuleFixedStringElementInfo);
			modelObjectInfosByType.Add(typeof(ParserRuleBlockElement), ParserRuleBlockElementInfo);
			modelObjectInfosByType.Add(typeof(Expression), ExpressionInfo);
			modelObjectInfosByType.Add(typeof(NullExpression), NullExpressionInfo);
			modelObjectInfosByType.Add(typeof(BoolExpression), BoolExpressionInfo);
			modelObjectInfosByType.Add(typeof(IntExpression), IntExpressionInfo);
			modelObjectInfosByType.Add(typeof(StringExpression), StringExpressionInfo);
			modelObjectInfosByType.Add(typeof(ReferenceExpression), ReferenceExpressionInfo);
			_modelObjectInfosByType = modelObjectInfosByType.ToImmutable();
			var modelObjectInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelObjectInfo>();
			modelObjectInfosByName.Add("Declaration", DeclarationInfo);
			modelObjectInfosByName.Add("Namespace", NamespaceInfo);
			modelObjectInfosByName.Add("Language", LanguageInfo);
			modelObjectInfosByName.Add("Grammar", GrammarInfo);
			modelObjectInfosByName.Add("Annotation", AnnotationInfo);
			modelObjectInfosByName.Add("AnnotationArgument", AnnotationArgumentInfo);
			modelObjectInfosByName.Add("Rule", RuleInfo);
			modelObjectInfosByName.Add("LexerRule", LexerRuleInfo);
			modelObjectInfosByName.Add("LexerRuleAlternative", LexerRuleAlternativeInfo);
			modelObjectInfosByName.Add("LexerRuleElement", LexerRuleElementInfo);
			modelObjectInfosByName.Add("LexerRuleReferenceElement", LexerRuleReferenceElementInfo);
			modelObjectInfosByName.Add("LexerRuleFixedStringElement", LexerRuleFixedStringElementInfo);
			modelObjectInfosByName.Add("LexerRuleWildCardElement", LexerRuleWildCardElementInfo);
			modelObjectInfosByName.Add("LexerRuleRangeElement", LexerRuleRangeElementInfo);
			modelObjectInfosByName.Add("LexerRuleSetElement", LexerRuleSetElementInfo);
			modelObjectInfosByName.Add("LexerRuleSetItem", LexerRuleSetItemInfo);
			modelObjectInfosByName.Add("LexerRuleSetFixedChar", LexerRuleSetFixedCharInfo);
			modelObjectInfosByName.Add("LexerRuleSetRange", LexerRuleSetRangeInfo);
			modelObjectInfosByName.Add("LexerRuleBlockElement", LexerRuleBlockElementInfo);
			modelObjectInfosByName.Add("ParserRule", ParserRuleInfo);
			modelObjectInfosByName.Add("ParserRuleAlternative", ParserRuleAlternativeInfo);
			modelObjectInfosByName.Add("ParserRuleElement", ParserRuleElementInfo);
			modelObjectInfosByName.Add("ParserRuleReferenceElement", ParserRuleReferenceElementInfo);
			modelObjectInfosByName.Add("ParserRuleEofElement", ParserRuleEofElementInfo);
			modelObjectInfosByName.Add("ParserRuleFixedStringElement", ParserRuleFixedStringElementInfo);
			modelObjectInfosByName.Add("ParserRuleBlockElement", ParserRuleBlockElementInfo);
			modelObjectInfosByName.Add("Expression", ExpressionInfo);
			modelObjectInfosByName.Add("NullExpression", NullExpressionInfo);
			modelObjectInfosByName.Add("BoolExpression", BoolExpressionInfo);
			modelObjectInfosByName.Add("IntExpression", IntExpressionInfo);
			modelObjectInfosByName.Add("StringExpression", StringExpressionInfo);
			modelObjectInfosByName.Add("ReferenceExpression", ReferenceExpressionInfo);
			_modelObjectInfosByName = modelObjectInfosByName.ToImmutable();
			_model = new __Model();
			var f = new __MetaModelFactory(_model);
			var obj1 = f.MetaNamespace();
			var obj2 = f.MetaNamespace();
			var obj3 = f.MetaNamespace();
			var obj4 = f.MetaNamespace();
			var obj5 = f.MetaNamespace();
			var obj6 = f.MetaModel();
			var obj7 = f.MetaClass();
			var obj8 = f.MetaClass();
			var obj9 = f.MetaClass();
			var obj10 = f.MetaClass();
			var obj11 = f.MetaClass();
			var obj12 = f.MetaClass();
			var obj13 = f.MetaEnumType();
			var obj14 = f.MetaClass();
			var obj15 = f.MetaClass();
			var obj16 = f.MetaClass();
			var obj17 = f.MetaClass();
			var obj18 = f.MetaClass();
			var obj19 = f.MetaClass();
			var obj20 = f.MetaClass();
			var obj21 = f.MetaClass();
			var obj22 = f.MetaClass();
			var obj23 = f.MetaClass();
			var obj24 = f.MetaClass();
			var obj25 = f.MetaClass();
			var obj26 = f.MetaClass();
			var obj27 = f.MetaClass();
			var obj28 = f.MetaClass();
			var obj29 = f.MetaEnumType();
			var obj30 = f.MetaClass();
			var obj31 = f.MetaClass();
			var obj32 = f.MetaClass();
			var obj33 = f.MetaClass();
			var obj34 = f.MetaClass();
			var obj35 = f.MetaClass();
			var obj36 = f.MetaClass();
			var obj37 = f.MetaClass();
			var obj38 = f.MetaClass();
			var obj39 = f.MetaClass();
			var obj40 = f.MetaClass();
			var obj41 = f.MetaProperty();
			var obj42 = f.MetaProperty();
			var obj43 = f.MetaProperty();
			var obj44 = f.MetaProperty();
			var obj45 = f.MetaProperty();
			var obj46 = f.MetaArrayType();
			var obj47 = f.MetaNullableType();
			var obj48 = f.MetaNullableType();
			var obj49 = f.MetaArrayType();
			var obj50 = f.MetaNullableType();
			var obj51 = f.MetaProperty();
			var obj52 = f.MetaProperty();
			var obj53 = f.MetaProperty();
			var obj54 = f.MetaArrayType();
			var obj55 = f.MetaProperty();
			var obj56 = f.MetaProperty();
			var obj57 = f.MetaArrayType();
			var obj58 = f.MetaProperty();
			var obj59 = f.MetaProperty();
			var obj60 = f.MetaProperty();
			var obj61 = f.MetaEnumLiteral();
			var obj62 = f.MetaEnumLiteral();
			var obj63 = f.MetaEnumLiteral();
			var obj64 = f.MetaEnumLiteral();
			var obj65 = f.MetaEnumLiteral();
			var obj66 = f.MetaEnumLiteral();
			var obj67 = f.MetaEnumLiteral();
			var obj68 = f.MetaProperty();
			var obj69 = f.MetaProperty();
			var obj70 = f.MetaProperty();
			var obj71 = f.MetaProperty();
			var obj72 = f.MetaProperty();
			var obj73 = f.MetaProperty();
			var obj74 = f.MetaProperty();
			var obj75 = f.MetaProperty();
			var obj76 = f.MetaNullableType();
			var obj77 = f.MetaArrayType();
			var obj78 = f.MetaProperty();
			var obj79 = f.MetaProperty();
			var obj80 = f.MetaProperty();
			var obj81 = f.MetaNullableType();
			var obj82 = f.MetaArrayType();
			var obj83 = f.MetaProperty();
			var obj84 = f.MetaProperty();
			var obj85 = f.MetaProperty();
			var obj86 = f.MetaProperty();
			var obj87 = f.MetaNullableType();
			var obj88 = f.MetaProperty();
			var obj89 = f.MetaProperty();
			var obj90 = f.MetaProperty();
			var obj91 = f.MetaNullableType();
			var obj92 = f.MetaProperty();
			var obj93 = f.MetaProperty();
			var obj94 = f.MetaProperty();
			var obj95 = f.MetaNullableType();
			var obj96 = f.MetaProperty();
			var obj97 = f.MetaProperty();
			var obj98 = f.MetaNullableType();
			var obj99 = f.MetaProperty();
			var obj100 = f.MetaProperty();
			var obj101 = f.MetaProperty();
			var obj102 = f.MetaProperty();
			var obj103 = f.MetaNullableType();
			var obj104 = f.MetaProperty();
			var obj105 = f.MetaProperty();
			var obj106 = f.MetaProperty();
			var obj107 = f.MetaNullableType();
			var obj108 = f.MetaArrayType();
			var obj109 = f.MetaProperty();
			var obj110 = f.MetaProperty();
			var obj111 = f.MetaNullableType();
			var obj112 = f.MetaProperty();
			var obj113 = f.MetaProperty();
			var obj114 = f.MetaProperty();
			var obj115 = f.MetaNullableType();
			var obj116 = f.MetaProperty();
			var obj117 = f.MetaProperty();
			var obj118 = f.MetaProperty();
			var obj119 = f.MetaProperty();
			var obj120 = f.MetaNullableType();
			var obj121 = f.MetaProperty();
			var obj122 = f.MetaProperty();
			var obj123 = f.MetaProperty();
			var obj124 = f.MetaNullableType();
			var obj125 = f.MetaArrayType();
			var obj126 = f.MetaProperty();
			var obj127 = f.MetaProperty();
			var obj128 = f.MetaProperty();
			var obj129 = f.MetaNullableType();
			var obj130 = f.MetaArrayType();
			var obj131 = f.MetaProperty();
			var obj132 = f.MetaProperty();
			var obj133 = f.MetaProperty();
			var obj134 = f.MetaNullableType();
			var obj135 = f.MetaArrayType();
			var obj136 = f.MetaEnumLiteral();
			var obj137 = f.MetaEnumLiteral();
			var obj138 = f.MetaEnumLiteral();
			var obj139 = f.MetaEnumLiteral();
			var obj140 = f.MetaProperty();
			var obj141 = f.MetaProperty();
			var obj142 = f.MetaProperty();
			var obj143 = f.MetaProperty();
			var obj144 = f.MetaProperty();
			var obj145 = f.MetaArrayType();
			var obj146 = f.MetaArrayType();
			var obj147 = f.MetaNullableType();
			var obj148 = f.MetaProperty();
			var obj149 = f.MetaProperty();
			var obj150 = f.MetaArrayType();
			var obj151 = f.MetaProperty();
			var obj152 = f.MetaProperty();
			var obj153 = f.MetaArrayType();
			var obj154 = f.MetaProperty();
			var obj155 = f.MetaNullableType();
			var obj156 = f.MetaProperty();
			var obj157 = f.MetaNullableType();
			var obj158 = f.MetaProperty();
			var obj159 = f.MetaProperty();
			var obj160 = f.MetaNullableType();
			var obj161 = f.MetaProperty();
			var obj162 = f.MetaProperty();
			var obj163 = f.MetaNullableType();
			var obj164 = f.MetaProperty();
			var obj165 = f.MetaProperty();
			var obj166 = f.MetaNullableType();
			var obj167 = f.MetaProperty();
			var obj168 = f.MetaProperty();
			var obj169 = f.MetaNullableType();
			__CustomImpl.Compiler(this);
			((__IModelObject)obj1).Children.Add((__IModelObject)obj2);
			((__IModelObject)obj2).Children.Add((__IModelObject)obj3);
			obj2.Declarations.Add(obj3);
			obj2.Name = "MetaDslx";
			((__IModelObject)obj3).Children.Add((__IModelObject)obj4);
			obj3.Declarations.Add(obj4);
			obj3.Name = "Bootstrap";
			obj3.Parent = obj2;
			((__IModelObject)obj4).Children.Add((__IModelObject)obj5);
			obj4.Declarations.Add(obj5);
			obj4.Name = "MetaCompiler";
			obj4.Parent = obj3;
			((__IModelObject)obj5).Children.Add((__IModelObject)obj6);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj7);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj8);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj9);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj10);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj11);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj12);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj13);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj14);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj15);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj16);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj17);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj18);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj19);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj20);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj21);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj22);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj23);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj24);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj25);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj26);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj27);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj28);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj29);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj30);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj31);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj32);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj33);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj34);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj35);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj36);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj37);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj38);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj39);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj40);
			obj5.Declarations.Add(obj6);
			obj5.Declarations.Add(obj7);
			obj5.Declarations.Add(obj8);
			obj5.Declarations.Add(obj9);
			obj5.Declarations.Add(obj10);
			obj5.Declarations.Add(obj11);
			obj5.Declarations.Add(obj12);
			obj5.Declarations.Add(obj13);
			obj5.Declarations.Add(obj14);
			obj5.Declarations.Add(obj15);
			obj5.Declarations.Add(obj16);
			obj5.Declarations.Add(obj17);
			obj5.Declarations.Add(obj18);
			obj5.Declarations.Add(obj19);
			obj5.Declarations.Add(obj20);
			obj5.Declarations.Add(obj21);
			obj5.Declarations.Add(obj22);
			obj5.Declarations.Add(obj23);
			obj5.Declarations.Add(obj24);
			obj5.Declarations.Add(obj25);
			obj5.Declarations.Add(obj26);
			obj5.Declarations.Add(obj27);
			obj5.Declarations.Add(obj28);
			obj5.Declarations.Add(obj29);
			obj5.Declarations.Add(obj30);
			obj5.Declarations.Add(obj31);
			obj5.Declarations.Add(obj32);
			obj5.Declarations.Add(obj33);
			obj5.Declarations.Add(obj34);
			obj5.Declarations.Add(obj35);
			obj5.Declarations.Add(obj36);
			obj5.Declarations.Add(obj37);
			obj5.Declarations.Add(obj38);
			obj5.Declarations.Add(obj39);
			obj5.Declarations.Add(obj40);
			obj5.Name = "Model";
			obj5.Parent = obj4;
			obj6.Name = "Compiler";
			obj6.Parent = obj5;
			((__IModelObject)obj7).Children.Add((__IModelObject)obj41);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj42);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj43);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj44);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj45);
			obj7.IsAbstract = true;
			obj7.Properties.Add(obj41);
			obj7.Properties.Add(obj42);
			obj7.Properties.Add(obj43);
			obj7.Properties.Add(obj44);
			obj7.Properties.Add(obj45);
			obj7.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
			obj7.Declarations.Add(obj41);
			obj7.Declarations.Add(obj42);
			obj7.Declarations.Add(obj43);
			obj7.Declarations.Add(obj44);
			obj7.Declarations.Add(obj45);
			obj7.Name = "Declaration";
			obj7.Parent = obj5;
			obj8.BaseTypes.Add(obj7);
			obj8.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
			obj8.Name = "Namespace";
			obj8.Parent = obj5;
			((__IModelObject)obj9).Children.Add((__IModelObject)obj51);
			obj9.BaseTypes.Add(obj7);
			obj9.Properties.Add(obj51);
			obj9.Declarations.Add(obj51);
			obj9.Name = "Language";
			obj9.Parent = obj5;
			((__IModelObject)obj10).Children.Add((__IModelObject)obj52);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj53);
			obj10.BaseTypes.Add(obj7);
			obj10.Properties.Add(obj52);
			obj10.Properties.Add(obj53);
			obj10.Declarations.Add(obj52);
			obj10.Declarations.Add(obj53);
			obj10.Name = "Grammar";
			obj10.Parent = obj5;
			((__IModelObject)obj11).Children.Add((__IModelObject)obj55);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj56);
			obj11.Properties.Add(obj55);
			obj11.Properties.Add(obj56);
			obj11.Declarations.Add(obj55);
			obj11.Declarations.Add(obj56);
			obj11.Name = "Annotation";
			obj11.Parent = obj5;
			((__IModelObject)obj12).Children.Add((__IModelObject)obj58);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj59);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj60);
			obj12.Properties.Add(obj58);
			obj12.Properties.Add(obj59);
			obj12.Properties.Add(obj60);
			obj12.Declarations.Add(obj58);
			obj12.Declarations.Add(obj59);
			obj12.Declarations.Add(obj60);
			obj12.Name = "AnnotationArgument";
			obj12.Parent = obj5;
			((__IModelObject)obj13).Children.Add((__IModelObject)obj61);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj62);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj63);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj64);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj65);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj66);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj67);
			obj13.Literals.Add(obj61);
			obj13.Literals.Add(obj62);
			obj13.Literals.Add(obj63);
			obj13.Literals.Add(obj64);
			obj13.Literals.Add(obj65);
			obj13.Literals.Add(obj66);
			obj13.Literals.Add(obj67);
			obj13.Declarations.Add(obj61);
			obj13.Declarations.Add(obj62);
			obj13.Declarations.Add(obj63);
			obj13.Declarations.Add(obj64);
			obj13.Declarations.Add(obj65);
			obj13.Declarations.Add(obj66);
			obj13.Declarations.Add(obj67);
			obj13.Name = "Multiplicity";
			obj13.Parent = obj5;
			((__IModelObject)obj14).Children.Add((__IModelObject)obj68);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj69);
			obj14.BaseTypes.Add(obj7);
			obj14.IsAbstract = true;
			obj14.Properties.Add(obj68);
			obj14.Properties.Add(obj69);
			obj14.Declarations.Add(obj68);
			obj14.Declarations.Add(obj69);
			obj14.Name = "Rule";
			obj14.Parent = obj5;
			((__IModelObject)obj15).Children.Add((__IModelObject)obj70);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj71);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj72);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj73);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj74);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj75);
			obj15.BaseTypes.Add(obj14);
			obj15.Properties.Add(obj70);
			obj15.Properties.Add(obj71);
			obj15.Properties.Add(obj72);
			obj15.Properties.Add(obj73);
			obj15.Properties.Add(obj74);
			obj15.Properties.Add(obj75);
			obj15.Declarations.Add(obj70);
			obj15.Declarations.Add(obj71);
			obj15.Declarations.Add(obj72);
			obj15.Declarations.Add(obj73);
			obj15.Declarations.Add(obj74);
			obj15.Declarations.Add(obj75);
			obj15.Name = "LexerRule";
			obj15.Parent = obj5;
			((__IModelObject)obj16).Children.Add((__IModelObject)obj78);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj79);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj80);
			obj16.Properties.Add(obj78);
			obj16.Properties.Add(obj79);
			obj16.Properties.Add(obj80);
			obj16.Declarations.Add(obj78);
			obj16.Declarations.Add(obj79);
			obj16.Declarations.Add(obj80);
			obj16.Name = "LexerRuleAlternative";
			obj16.Parent = obj5;
			((__IModelObject)obj17).Children.Add((__IModelObject)obj83);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj84);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj85);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj86);
			obj17.IsAbstract = true;
			obj17.Properties.Add(obj83);
			obj17.Properties.Add(obj84);
			obj17.Properties.Add(obj85);
			obj17.Properties.Add(obj86);
			obj17.Declarations.Add(obj83);
			obj17.Declarations.Add(obj84);
			obj17.Declarations.Add(obj85);
			obj17.Declarations.Add(obj86);
			obj17.Name = "LexerRuleElement";
			obj17.Parent = obj5;
			((__IModelObject)obj18).Children.Add((__IModelObject)obj88);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj89);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj90);
			obj18.BaseTypes.Add(obj17);
			obj18.Properties.Add(obj88);
			obj18.Properties.Add(obj89);
			obj18.Properties.Add(obj90);
			obj18.Declarations.Add(obj88);
			obj18.Declarations.Add(obj89);
			obj18.Declarations.Add(obj90);
			obj18.Name = "LexerRuleReferenceElement";
			obj18.Parent = obj5;
			((__IModelObject)obj19).Children.Add((__IModelObject)obj92);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj93);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj94);
			obj19.BaseTypes.Add(obj17);
			obj19.Properties.Add(obj92);
			obj19.Properties.Add(obj93);
			obj19.Properties.Add(obj94);
			obj19.Declarations.Add(obj92);
			obj19.Declarations.Add(obj93);
			obj19.Declarations.Add(obj94);
			obj19.Name = "LexerRuleFixedStringElement";
			obj19.Parent = obj5;
			((__IModelObject)obj20).Children.Add((__IModelObject)obj96);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj97);
			obj20.BaseTypes.Add(obj17);
			obj20.Properties.Add(obj96);
			obj20.Properties.Add(obj97);
			obj20.Declarations.Add(obj96);
			obj20.Declarations.Add(obj97);
			obj20.Name = "LexerRuleWildCardElement";
			obj20.Parent = obj5;
			((__IModelObject)obj21).Children.Add((__IModelObject)obj99);
			((__IModelObject)obj21).Children.Add((__IModelObject)obj100);
			((__IModelObject)obj21).Children.Add((__IModelObject)obj101);
			((__IModelObject)obj21).Children.Add((__IModelObject)obj102);
			obj21.BaseTypes.Add(obj17);
			obj21.Properties.Add(obj99);
			obj21.Properties.Add(obj100);
			obj21.Properties.Add(obj101);
			obj21.Properties.Add(obj102);
			obj21.Declarations.Add(obj99);
			obj21.Declarations.Add(obj100);
			obj21.Declarations.Add(obj101);
			obj21.Declarations.Add(obj102);
			obj21.Name = "LexerRuleRangeElement";
			obj21.Parent = obj5;
			((__IModelObject)obj22).Children.Add((__IModelObject)obj104);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj105);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj106);
			obj22.BaseTypes.Add(obj17);
			obj22.Properties.Add(obj104);
			obj22.Properties.Add(obj105);
			obj22.Properties.Add(obj106);
			obj22.Declarations.Add(obj104);
			obj22.Declarations.Add(obj105);
			obj22.Declarations.Add(obj106);
			obj22.Name = "LexerRuleSetElement";
			obj22.Parent = obj5;
			((__IModelObject)obj23).Children.Add((__IModelObject)obj109);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj110);
			obj23.IsAbstract = true;
			obj23.Properties.Add(obj109);
			obj23.Properties.Add(obj110);
			obj23.Declarations.Add(obj109);
			obj23.Declarations.Add(obj110);
			obj23.Name = "LexerRuleSetItem";
			obj23.Parent = obj5;
			((__IModelObject)obj24).Children.Add((__IModelObject)obj112);
			((__IModelObject)obj24).Children.Add((__IModelObject)obj113);
			((__IModelObject)obj24).Children.Add((__IModelObject)obj114);
			obj24.BaseTypes.Add(obj23);
			obj24.Properties.Add(obj112);
			obj24.Properties.Add(obj113);
			obj24.Properties.Add(obj114);
			obj24.Declarations.Add(obj112);
			obj24.Declarations.Add(obj113);
			obj24.Declarations.Add(obj114);
			obj24.Name = "LexerRuleSetFixedChar";
			obj24.Parent = obj5;
			((__IModelObject)obj25).Children.Add((__IModelObject)obj116);
			((__IModelObject)obj25).Children.Add((__IModelObject)obj117);
			((__IModelObject)obj25).Children.Add((__IModelObject)obj118);
			((__IModelObject)obj25).Children.Add((__IModelObject)obj119);
			obj25.BaseTypes.Add(obj23);
			obj25.Properties.Add(obj116);
			obj25.Properties.Add(obj117);
			obj25.Properties.Add(obj118);
			obj25.Properties.Add(obj119);
			obj25.Declarations.Add(obj116);
			obj25.Declarations.Add(obj117);
			obj25.Declarations.Add(obj118);
			obj25.Declarations.Add(obj119);
			obj25.Name = "LexerRuleSetRange";
			obj25.Parent = obj5;
			((__IModelObject)obj26).Children.Add((__IModelObject)obj121);
			((__IModelObject)obj26).Children.Add((__IModelObject)obj122);
			((__IModelObject)obj26).Children.Add((__IModelObject)obj123);
			obj26.BaseTypes.Add(obj17);
			obj26.Properties.Add(obj121);
			obj26.Properties.Add(obj122);
			obj26.Properties.Add(obj123);
			obj26.Declarations.Add(obj121);
			obj26.Declarations.Add(obj122);
			obj26.Declarations.Add(obj123);
			obj26.Name = "LexerRuleBlockElement";
			obj26.Parent = obj5;
			((__IModelObject)obj27).Children.Add((__IModelObject)obj126);
			((__IModelObject)obj27).Children.Add((__IModelObject)obj127);
			((__IModelObject)obj27).Children.Add((__IModelObject)obj128);
			obj27.BaseTypes.Add(obj14);
			obj27.IsAbstract = true;
			obj27.Properties.Add(obj126);
			obj27.Properties.Add(obj127);
			obj27.Properties.Add(obj128);
			obj27.Declarations.Add(obj126);
			obj27.Declarations.Add(obj127);
			obj27.Declarations.Add(obj128);
			obj27.Name = "ParserRule";
			obj27.Parent = obj5;
			((__IModelObject)obj28).Children.Add((__IModelObject)obj131);
			((__IModelObject)obj28).Children.Add((__IModelObject)obj132);
			((__IModelObject)obj28).Children.Add((__IModelObject)obj133);
			obj28.BaseTypes.Add(obj7);
			obj28.Properties.Add(obj131);
			obj28.Properties.Add(obj132);
			obj28.Properties.Add(obj133);
			obj28.Declarations.Add(obj131);
			obj28.Declarations.Add(obj132);
			obj28.Declarations.Add(obj133);
			obj28.Name = "ParserRuleAlternative";
			obj28.Parent = obj5;
			((__IModelObject)obj29).Children.Add((__IModelObject)obj136);
			((__IModelObject)obj29).Children.Add((__IModelObject)obj137);
			((__IModelObject)obj29).Children.Add((__IModelObject)obj138);
			((__IModelObject)obj29).Children.Add((__IModelObject)obj139);
			obj29.Literals.Add(obj136);
			obj29.Literals.Add(obj137);
			obj29.Literals.Add(obj138);
			obj29.Literals.Add(obj139);
			obj29.Declarations.Add(obj136);
			obj29.Declarations.Add(obj137);
			obj29.Declarations.Add(obj138);
			obj29.Declarations.Add(obj139);
			obj29.Name = "AssignmentOperator";
			obj29.Parent = obj5;
			((__IModelObject)obj30).Children.Add((__IModelObject)obj140);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj141);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj142);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj143);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj144);
			obj30.IsAbstract = true;
			obj30.Properties.Add(obj140);
			obj30.Properties.Add(obj141);
			obj30.Properties.Add(obj142);
			obj30.Properties.Add(obj143);
			obj30.Properties.Add(obj144);
			obj30.Declarations.Add(obj140);
			obj30.Declarations.Add(obj141);
			obj30.Declarations.Add(obj142);
			obj30.Declarations.Add(obj143);
			obj30.Declarations.Add(obj144);
			obj30.Name = "ParserRuleElement";
			obj30.Parent = obj5;
			((__IModelObject)obj31).Children.Add((__IModelObject)obj148);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj149);
			obj31.BaseTypes.Add(obj30);
			obj31.Properties.Add(obj148);
			obj31.Properties.Add(obj149);
			obj31.Declarations.Add(obj148);
			obj31.Declarations.Add(obj149);
			obj31.Name = "ParserRuleReferenceElement";
			obj31.Parent = obj5;
			obj32.BaseTypes.Add(obj30);
			obj32.Name = "ParserRuleEofElement";
			obj32.Parent = obj5;
			((__IModelObject)obj33).Children.Add((__IModelObject)obj151);
			obj33.BaseTypes.Add(obj30);
			obj33.Properties.Add(obj151);
			obj33.Declarations.Add(obj151);
			obj33.Name = "ParserRuleFixedStringElement";
			obj33.Parent = obj5;
			((__IModelObject)obj34).Children.Add((__IModelObject)obj152);
			obj34.BaseTypes.Add(obj30);
			obj34.Properties.Add(obj152);
			obj34.Declarations.Add(obj152);
			obj34.Name = "ParserRuleBlockElement";
			obj34.Parent = obj5;
			((__IModelObject)obj35).Children.Add((__IModelObject)obj154);
			obj35.IsAbstract = true;
			obj35.Properties.Add(obj154);
			obj35.Declarations.Add(obj154);
			obj35.Name = "Expression";
			obj35.Parent = obj5;
			((__IModelObject)obj36).Children.Add((__IModelObject)obj156);
			obj36.Properties.Add(obj156);
			obj36.Declarations.Add(obj156);
			obj36.Name = "NullExpression";
			obj36.Parent = obj5;
			((__IModelObject)obj37).Children.Add((__IModelObject)obj158);
			((__IModelObject)obj37).Children.Add((__IModelObject)obj159);
			obj37.Properties.Add(obj158);
			obj37.Properties.Add(obj159);
			obj37.Declarations.Add(obj158);
			obj37.Declarations.Add(obj159);
			obj37.Name = "BoolExpression";
			obj37.Parent = obj5;
			((__IModelObject)obj38).Children.Add((__IModelObject)obj161);
			((__IModelObject)obj38).Children.Add((__IModelObject)obj162);
			obj38.Properties.Add(obj161);
			obj38.Properties.Add(obj162);
			obj38.Declarations.Add(obj161);
			obj38.Declarations.Add(obj162);
			obj38.Name = "IntExpression";
			obj38.Parent = obj5;
			((__IModelObject)obj39).Children.Add((__IModelObject)obj164);
			((__IModelObject)obj39).Children.Add((__IModelObject)obj165);
			obj39.Properties.Add(obj164);
			obj39.Properties.Add(obj165);
			obj39.Declarations.Add(obj164);
			obj39.Declarations.Add(obj165);
			obj39.Name = "StringExpression";
			obj39.Parent = obj5;
			((__IModelObject)obj40).Children.Add((__IModelObject)obj167);
			((__IModelObject)obj40).Children.Add((__IModelObject)obj168);
			obj40.Properties.Add(obj167);
			obj40.Properties.Add(obj168);
			obj40.Declarations.Add(obj167);
			obj40.Declarations.Add(obj168);
			obj40.Name = "ReferenceExpression";
			obj40.Parent = obj5;
			((__IModelObject)obj41).Children.Add((__IModelObject)obj46);
			obj41.IsContainment = true;
			obj41.Type = __MetaType.FromModelObject((__IModelObject)obj46);
			obj41.Name = "Annotations";
			obj41.Parent = obj7;
			((__IModelObject)obj42).Children.Add((__IModelObject)obj47);
			obj42.SymbolProperty = "Name";
			obj42.Type = __MetaType.FromModelObject((__IModelObject)obj47);
			obj42.Name = "Name";
			obj42.Parent = obj7;
			((__IModelObject)obj43).Children.Add((__IModelObject)obj48);
			obj43.OppositeProperties.Add(obj44);
			obj43.Type = __MetaType.FromModelObject((__IModelObject)obj48);
			obj43.Name = "Parent";
			obj43.Parent = obj7;
			((__IModelObject)obj44).Children.Add((__IModelObject)obj49);
			obj44.IsContainment = true;
			obj44.OppositeProperties.Add(obj43);
			obj44.Type = __MetaType.FromModelObject((__IModelObject)obj49);
			obj44.Name = "Declarations";
			obj44.Parent = obj7;
			((__IModelObject)obj45).Children.Add((__IModelObject)obj50);
			obj45.IsDerived = true;
			obj45.Type = __MetaType.FromModelObject((__IModelObject)obj50);
			obj45.Name = "FullName";
			obj45.Parent = obj7;
			obj46.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj47.InnerType = typeof(string);
			obj48.InnerType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj49.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj50.InnerType = typeof(string);
			obj51.IsContainment = true;
			obj51.SubsettedProperties.Add(obj44);
			obj51.Type = __MetaType.FromModelObject((__IModelObject)obj10);
			obj51.Name = "Grammar";
			obj51.Parent = obj9;
			obj52.RedefinedProperties.Add(obj43);
			obj52.Type = __MetaType.FromModelObject((__IModelObject)obj9);
			obj52.Name = "Language";
			obj52.Parent = obj10;
			((__IModelObject)obj53).Children.Add((__IModelObject)obj54);
			obj53.IsContainment = true;
			obj53.Type = __MetaType.FromModelObject((__IModelObject)obj54);
			obj53.Name = "Rules";
			obj53.Parent = obj10;
			obj54.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj55.Type = typeof(__MetaType);
			obj55.Name = "Type";
			obj55.Parent = obj11;
			((__IModelObject)obj56).Children.Add((__IModelObject)obj57);
			obj56.IsContainment = true;
			obj56.Type = __MetaType.FromModelObject((__IModelObject)obj57);
			obj56.Name = "Arguments";
			obj56.Parent = obj11;
			obj57.ItemType = __MetaType.FromModelObject((__IModelObject)obj12);
			obj58.Type = typeof(__MetaSymbol);
			obj58.Name = "Parameter";
			obj58.Parent = obj12;
			obj59.Type = typeof(__MetaType);
			obj59.Name = "Type";
			obj59.Parent = obj12;
			obj60.IsContainment = true;
			obj60.Type = __MetaType.FromModelObject((__IModelObject)obj35);
			obj60.Name = "Value";
			obj60.Parent = obj12;
			obj61.Name = "ExactlyOne";
			obj61.Parent = obj13;
			obj62.Name = "ZeroOrOne";
			obj62.Parent = obj13;
			obj63.Name = "ZeroOrMore";
			obj63.Parent = obj13;
			obj64.Name = "OneOrMore";
			obj64.Parent = obj13;
			obj65.Name = "NonGreedyZeroOrOne";
			obj65.Parent = obj13;
			obj66.Name = "NonGreedyZeroOrMore";
			obj66.Parent = obj13;
			obj67.Name = "NonGreedyOneOrMore";
			obj67.Parent = obj13;
			obj68.IsDerived = true;
			obj68.Type = __MetaType.FromModelObject((__IModelObject)obj9);
			obj68.Name = "Language";
			obj68.Parent = obj14;
			obj69.RedefinedProperties.Add(obj43);
			obj69.Type = __MetaType.FromModelObject((__IModelObject)obj10);
			obj69.Name = "Grammar";
			obj69.Parent = obj14;
			obj70.Type = typeof(__MetaType);
			obj70.Name = "ReturnType";
			obj70.Parent = obj15;
			obj71.Type = typeof(bool);
			obj71.Name = "IsHidden";
			obj71.Parent = obj15;
			obj72.Type = typeof(bool);
			obj72.Name = "IsFragment";
			obj72.Parent = obj15;
			obj73.IsDerived = true;
			obj73.Type = typeof(bool);
			obj73.Name = "IsFixed";
			obj73.Parent = obj15;
			((__IModelObject)obj74).Children.Add((__IModelObject)obj76);
			obj74.IsDerived = true;
			obj74.Type = __MetaType.FromModelObject((__IModelObject)obj76);
			obj74.Name = "FixedText";
			obj74.Parent = obj15;
			((__IModelObject)obj75).Children.Add((__IModelObject)obj77);
			obj75.IsContainment = true;
			obj75.Type = __MetaType.FromModelObject((__IModelObject)obj77);
			obj75.Name = "Alternatives";
			obj75.Parent = obj15;
			obj76.InnerType = typeof(string);
			obj77.ItemType = __MetaType.FromModelObject((__IModelObject)obj16);
			obj78.IsDerived = true;
			obj78.Type = typeof(bool);
			obj78.Name = "IsFixed";
			obj78.Parent = obj16;
			((__IModelObject)obj79).Children.Add((__IModelObject)obj81);
			obj79.IsDerived = true;
			obj79.Type = __MetaType.FromModelObject((__IModelObject)obj81);
			obj79.Name = "FixedText";
			obj79.Parent = obj16;
			((__IModelObject)obj80).Children.Add((__IModelObject)obj82);
			obj80.IsContainment = true;
			obj80.Type = __MetaType.FromModelObject((__IModelObject)obj82);
			obj80.Name = "Elements";
			obj80.Parent = obj16;
			obj81.InnerType = typeof(string);
			obj82.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
			obj83.IsDerived = true;
			obj83.Type = typeof(bool);
			obj83.Name = "IsFixed";
			obj83.Parent = obj17;
			((__IModelObject)obj84).Children.Add((__IModelObject)obj87);
			obj84.IsDerived = true;
			obj84.Type = __MetaType.FromModelObject((__IModelObject)obj87);
			obj84.Name = "FixedText";
			obj84.Parent = obj17;
			obj85.Type = typeof(bool);
			obj85.Name = "IsNegated";
			obj85.Parent = obj17;
			obj86.Type = __MetaType.FromModelObject((__IModelObject)obj13);
			obj86.Name = "Multiplicity";
			obj86.Parent = obj17;
			obj87.InnerType = typeof(string);
			obj88.IsDerived = true;
			obj88.Type = typeof(bool);
			obj88.Name = "IsFixed";
			obj88.Parent = obj18;
			((__IModelObject)obj89).Children.Add((__IModelObject)obj91);
			obj89.IsDerived = true;
			obj89.Type = __MetaType.FromModelObject((__IModelObject)obj91);
			obj89.Name = "FixedText";
			obj89.Parent = obj18;
			obj90.Type = __MetaType.FromModelObject((__IModelObject)obj15);
			obj90.Name = "Rule";
			obj90.Parent = obj18;
			obj91.InnerType = typeof(string);
			obj92.IsDerived = true;
			obj92.Type = typeof(bool);
			obj92.Name = "IsFixed";
			obj92.Parent = obj19;
			((__IModelObject)obj93).Children.Add((__IModelObject)obj95);
			obj93.IsDerived = true;
			obj93.Type = __MetaType.FromModelObject((__IModelObject)obj95);
			obj93.Name = "FixedText";
			obj93.Parent = obj19;
			obj94.Type = typeof(string);
			obj94.Name = "Text";
			obj94.Parent = obj19;
			obj95.InnerType = typeof(string);
			obj96.IsDerived = true;
			obj96.Type = typeof(bool);
			obj96.Name = "IsFixed";
			obj96.Parent = obj20;
			((__IModelObject)obj97).Children.Add((__IModelObject)obj98);
			obj97.IsDerived = true;
			obj97.Type = __MetaType.FromModelObject((__IModelObject)obj98);
			obj97.Name = "FixedText";
			obj97.Parent = obj20;
			obj98.InnerType = typeof(string);
			obj99.IsDerived = true;
			obj99.Type = typeof(bool);
			obj99.Name = "IsFixed";
			obj99.Parent = obj21;
			((__IModelObject)obj100).Children.Add((__IModelObject)obj103);
			obj100.IsDerived = true;
			obj100.Type = __MetaType.FromModelObject((__IModelObject)obj103);
			obj100.Name = "FixedText";
			obj100.Parent = obj21;
			obj101.Type = typeof(string);
			obj101.Name = "StartChar";
			obj101.Parent = obj21;
			obj102.Type = typeof(string);
			obj102.Name = "EndChar";
			obj102.Parent = obj21;
			obj103.InnerType = typeof(string);
			obj104.IsDerived = true;
			obj104.Type = typeof(bool);
			obj104.Name = "IsFixed";
			obj104.Parent = obj22;
			((__IModelObject)obj105).Children.Add((__IModelObject)obj107);
			obj105.IsDerived = true;
			obj105.Type = __MetaType.FromModelObject((__IModelObject)obj107);
			obj105.Name = "FixedText";
			obj105.Parent = obj22;
			((__IModelObject)obj106).Children.Add((__IModelObject)obj108);
			obj106.IsContainment = true;
			obj106.Type = __MetaType.FromModelObject((__IModelObject)obj108);
			obj106.Name = "Items";
			obj106.Parent = obj22;
			obj107.InnerType = typeof(string);
			obj108.ItemType = __MetaType.FromModelObject((__IModelObject)obj23);
			obj109.IsDerived = true;
			obj109.Type = typeof(bool);
			obj109.Name = "IsFixed";
			obj109.Parent = obj23;
			((__IModelObject)obj110).Children.Add((__IModelObject)obj111);
			obj110.IsDerived = true;
			obj110.Type = __MetaType.FromModelObject((__IModelObject)obj111);
			obj110.Name = "FixedText";
			obj110.Parent = obj23;
			obj111.InnerType = typeof(string);
			obj112.IsDerived = true;
			obj112.Type = typeof(bool);
			obj112.Name = "IsFixed";
			obj112.Parent = obj24;
			((__IModelObject)obj113).Children.Add((__IModelObject)obj115);
			obj113.IsDerived = true;
			obj113.Type = __MetaType.FromModelObject((__IModelObject)obj115);
			obj113.Name = "FixedText";
			obj113.Parent = obj24;
			obj114.Type = typeof(string);
			obj114.Name = "Char";
			obj114.Parent = obj24;
			obj115.InnerType = typeof(string);
			obj116.IsDerived = true;
			obj116.Type = typeof(bool);
			obj116.Name = "IsFixed";
			obj116.Parent = obj25;
			((__IModelObject)obj117).Children.Add((__IModelObject)obj120);
			obj117.IsDerived = true;
			obj117.Type = __MetaType.FromModelObject((__IModelObject)obj120);
			obj117.Name = "FixedText";
			obj117.Parent = obj25;
			obj118.Type = typeof(string);
			obj118.Name = "StartChar";
			obj118.Parent = obj25;
			obj119.Type = typeof(string);
			obj119.Name = "EndChar";
			obj119.Parent = obj25;
			obj120.InnerType = typeof(string);
			obj121.IsDerived = true;
			obj121.Type = typeof(bool);
			obj121.Name = "IsFixed";
			obj121.Parent = obj26;
			((__IModelObject)obj122).Children.Add((__IModelObject)obj124);
			obj122.IsDerived = true;
			obj122.Type = __MetaType.FromModelObject((__IModelObject)obj124);
			obj122.Name = "FixedText";
			obj122.Parent = obj26;
			((__IModelObject)obj123).Children.Add((__IModelObject)obj125);
			obj123.IsContainment = true;
			obj123.Type = __MetaType.FromModelObject((__IModelObject)obj125);
			obj123.Name = "Alternatives";
			obj123.Parent = obj26;
			obj124.InnerType = typeof(string);
			obj125.ItemType = __MetaType.FromModelObject((__IModelObject)obj16);
			((__IModelObject)obj126).Children.Add((__IModelObject)obj129);
			obj126.Type = __MetaType.FromModelObject((__IModelObject)obj129);
			obj126.Name = "ReturnType";
			obj126.Parent = obj27;
			obj127.Type = typeof(bool);
			obj127.Name = "IsBlock";
			obj127.Parent = obj27;
			((__IModelObject)obj128).Children.Add((__IModelObject)obj130);
			obj128.IsContainment = true;
			obj128.Type = __MetaType.FromModelObject((__IModelObject)obj130);
			obj128.Name = "Alternatives";
			obj128.Parent = obj27;
			obj129.InnerType = typeof(__MetaType);
			obj130.ItemType = __MetaType.FromModelObject((__IModelObject)obj28);
			((__IModelObject)obj131).Children.Add((__IModelObject)obj134);
			obj131.Type = __MetaType.FromModelObject((__IModelObject)obj134);
			obj131.Name = "ReturnType";
			obj131.Parent = obj28;
			obj132.IsContainment = true;
			obj132.Type = __MetaType.FromModelObject((__IModelObject)obj35);
			obj132.Name = "ReturnValue";
			obj132.Parent = obj28;
			((__IModelObject)obj133).Children.Add((__IModelObject)obj135);
			obj133.IsContainment = true;
			obj133.Type = __MetaType.FromModelObject((__IModelObject)obj135);
			obj133.Name = "Elements";
			obj133.Parent = obj28;
			obj134.InnerType = typeof(__MetaType);
			obj135.ItemType = __MetaType.FromModelObject((__IModelObject)obj30);
			obj136.Name = "Assign";
			obj136.Parent = obj29;
			obj137.Name = "QuestionAssign";
			obj137.Parent = obj29;
			obj138.Name = "NegatedAssign";
			obj138.Parent = obj29;
			obj139.Name = "PlusAssign";
			obj139.Parent = obj29;
			((__IModelObject)obj140).Children.Add((__IModelObject)obj145);
			obj140.IsContainment = true;
			obj140.Type = __MetaType.FromModelObject((__IModelObject)obj145);
			obj140.Name = "NameAnnotations";
			obj140.Parent = obj30;
			((__IModelObject)obj141).Children.Add((__IModelObject)obj146);
			obj141.IsContainment = true;
			obj141.Type = __MetaType.FromModelObject((__IModelObject)obj146);
			obj141.Name = "ValueAnnotations";
			obj141.Parent = obj30;
			((__IModelObject)obj142).Children.Add((__IModelObject)obj147);
			obj142.Type = __MetaType.FromModelObject((__IModelObject)obj147);
			obj142.Name = "Property";
			obj142.Parent = obj30;
			obj143.Type = __MetaType.FromModelObject((__IModelObject)obj29);
			obj143.Name = "AssignmentOperator";
			obj143.Parent = obj30;
			obj144.Type = __MetaType.FromModelObject((__IModelObject)obj13);
			obj144.Name = "Multiplicity";
			obj144.Parent = obj30;
			obj145.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj146.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj147.InnerType = typeof(__MetaSymbol);
			obj148.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj148.Name = "Rule";
			obj148.Parent = obj31;
			((__IModelObject)obj149).Children.Add((__IModelObject)obj150);
			obj149.Type = __MetaType.FromModelObject((__IModelObject)obj150);
			obj149.Name = "ReferencedTypes";
			obj149.Parent = obj31;
			obj150.ItemType = typeof(__MetaType);
			obj151.Type = typeof(string);
			obj151.Name = "Text";
			obj151.Parent = obj33;
			((__IModelObject)obj152).Children.Add((__IModelObject)obj153);
			obj152.IsContainment = true;
			obj152.Type = __MetaType.FromModelObject((__IModelObject)obj153);
			obj152.Name = "Alternatives";
			obj152.Parent = obj34;
			obj153.ItemType = __MetaType.FromModelObject((__IModelObject)obj28);
			((__IModelObject)obj154).Children.Add((__IModelObject)obj155);
			obj154.IsDerived = true;
			obj154.Type = __MetaType.FromModelObject((__IModelObject)obj155);
			obj154.Name = "Value";
			obj154.Parent = obj35;
			obj155.InnerType = typeof(object);
			((__IModelObject)obj156).Children.Add((__IModelObject)obj157);
			obj156.IsDerived = true;
			obj156.Type = __MetaType.FromModelObject((__IModelObject)obj157);
			obj156.Name = "Value";
			obj156.Parent = obj36;
			obj157.InnerType = typeof(object);
			((__IModelObject)obj158).Children.Add((__IModelObject)obj160);
			obj158.IsDerived = true;
			obj158.Type = __MetaType.FromModelObject((__IModelObject)obj160);
			obj158.Name = "Value";
			obj158.Parent = obj37;
			obj159.Type = typeof(bool);
			obj159.Name = "BoolValue";
			obj159.Parent = obj37;
			obj160.InnerType = typeof(object);
			((__IModelObject)obj161).Children.Add((__IModelObject)obj163);
			obj161.IsDerived = true;
			obj161.Type = __MetaType.FromModelObject((__IModelObject)obj163);
			obj161.Name = "Value";
			obj161.Parent = obj38;
			obj162.Type = typeof(int);
			obj162.Name = "IntValue";
			obj162.Parent = obj38;
			obj163.InnerType = typeof(object);
			((__IModelObject)obj164).Children.Add((__IModelObject)obj166);
			obj164.IsDerived = true;
			obj164.Type = __MetaType.FromModelObject((__IModelObject)obj166);
			obj164.Name = "Value";
			obj164.Parent = obj39;
			obj165.Type = typeof(string);
			obj165.Name = "StringValue";
			obj165.Parent = obj39;
			obj166.InnerType = typeof(object);
			((__IModelObject)obj167).Children.Add((__IModelObject)obj169);
			obj167.IsDerived = true;
			obj167.Type = __MetaType.FromModelObject((__IModelObject)obj169);
			obj167.Name = "Value";
			obj167.Parent = obj40;
			obj168.Type = typeof(__MetaSymbol);
			obj168.Name = "SymbolValue";
			obj168.Parent = obj40;
			obj169.InnerType = typeof(object);
			_model.IsSealed = true;
		}
	
	    public override string Name => nameof(Compiler);
	    public override string Namespace => "MetaDslx.Bootstrap.MetaCompiler.Model";
	    public override __ModelVersion Version => default;
	    public override string Uri => "MetaDslx.Bootstrap.MetaCompiler.Model.Compiler";
	    public override string Prefix => "c";
		public override __Model Model => _model;
	
		public override global::System.Collections.Immutable.ImmutableArray<__Type> ModelObjectTypes => _modelObjectTypes;
		public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> ModelObjectInfos => _modelObjectInfos;
	
	    public override bool Contains(__Type modelObjectType) => _modelObjectInfosByType.ContainsKey(modelObjectType);
	    public override bool Contains(string modelObjectTypeName) => _modelObjectInfosByName.ContainsKey(modelObjectTypeName);
	
	    public override bool TryGetInfo(__Type modelObjectType, out __ModelObjectInfo? info) => _modelObjectInfosByType.TryGetValue(modelObjectType, out info);
	    public override bool TryGetInfo(string modelObjectTypeName, out __ModelObjectInfo? info) => _modelObjectInfosByName.TryGetValue(modelObjectTypeName, out info);
	
	
	
		public static __ModelObjectInfo DeclarationInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.Declaration_Impl.__Info.Instance;
		public static __ModelProperty Declaration_Annotations => _Declaration_Annotations;
		public static __ModelProperty Declaration_Name => _Declaration_Name;
		public static __ModelProperty Declaration_Parent => _Declaration_Parent;
		public static __ModelProperty Declaration_Declarations => _Declaration_Declarations;
		public static __ModelProperty Declaration_FullName => _Declaration_FullName;
		public static __ModelObjectInfo NamespaceInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.Namespace_Impl.__Info.Instance;
		public static __ModelObjectInfo LanguageInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.Language_Impl.__Info.Instance;
		public static __ModelProperty Language_Grammar => _Language_Grammar;
		public static __ModelObjectInfo GrammarInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.Grammar_Impl.__Info.Instance;
		public static __ModelProperty Grammar_Language => _Grammar_Language;
		public static __ModelProperty Grammar_Rules => _Grammar_Rules;
		public static __ModelObjectInfo AnnotationInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.Annotation_Impl.__Info.Instance;
		public static __ModelProperty Annotation_Type => _Annotation_Type;
		public static __ModelProperty Annotation_Arguments => _Annotation_Arguments;
		public static __ModelObjectInfo AnnotationArgumentInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.AnnotationArgument_Impl.__Info.Instance;
		public static __ModelProperty AnnotationArgument_Parameter => _AnnotationArgument_Parameter;
		public static __ModelProperty AnnotationArgument_Type => _AnnotationArgument_Type;
		public static __ModelProperty AnnotationArgument_Value => _AnnotationArgument_Value;
		public static __ModelObjectInfo RuleInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.Rule_Impl.__Info.Instance;
		public static __ModelProperty Rule_Language => _Rule_Language;
		public static __ModelProperty Rule_Grammar => _Rule_Grammar;
		public static __ModelObjectInfo LexerRuleInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRule_Impl.__Info.Instance;
		public static __ModelProperty LexerRule_ReturnType => _LexerRule_ReturnType;
		public static __ModelProperty LexerRule_IsHidden => _LexerRule_IsHidden;
		public static __ModelProperty LexerRule_IsFragment => _LexerRule_IsFragment;
		public static __ModelProperty LexerRule_IsFixed => _LexerRule_IsFixed;
		public static __ModelProperty LexerRule_FixedText => _LexerRule_FixedText;
		public static __ModelProperty LexerRule_Alternatives => _LexerRule_Alternatives;
		public static __ModelObjectInfo LexerRuleAlternativeInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRuleAlternative_Impl.__Info.Instance;
		public static __ModelProperty LexerRuleAlternative_IsFixed => _LexerRuleAlternative_IsFixed;
		public static __ModelProperty LexerRuleAlternative_FixedText => _LexerRuleAlternative_FixedText;
		public static __ModelProperty LexerRuleAlternative_Elements => _LexerRuleAlternative_Elements;
		public static __ModelObjectInfo LexerRuleElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRuleElement_Impl.__Info.Instance;
		public static __ModelProperty LexerRuleElement_IsFixed => _LexerRuleElement_IsFixed;
		public static __ModelProperty LexerRuleElement_FixedText => _LexerRuleElement_FixedText;
		public static __ModelProperty LexerRuleElement_IsNegated => _LexerRuleElement_IsNegated;
		public static __ModelProperty LexerRuleElement_Multiplicity => _LexerRuleElement_Multiplicity;
		public static __ModelObjectInfo LexerRuleReferenceElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRuleReferenceElement_Impl.__Info.Instance;
		public static __ModelProperty LexerRuleReferenceElement_IsFixed => _LexerRuleReferenceElement_IsFixed;
		public static __ModelProperty LexerRuleReferenceElement_FixedText => _LexerRuleReferenceElement_FixedText;
		public static __ModelProperty LexerRuleReferenceElement_Rule => _LexerRuleReferenceElement_Rule;
		public static __ModelObjectInfo LexerRuleFixedStringElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRuleFixedStringElement_Impl.__Info.Instance;
		public static __ModelProperty LexerRuleFixedStringElement_IsFixed => _LexerRuleFixedStringElement_IsFixed;
		public static __ModelProperty LexerRuleFixedStringElement_FixedText => _LexerRuleFixedStringElement_FixedText;
		public static __ModelProperty LexerRuleFixedStringElement_Text => _LexerRuleFixedStringElement_Text;
		public static __ModelObjectInfo LexerRuleWildCardElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRuleWildCardElement_Impl.__Info.Instance;
		public static __ModelProperty LexerRuleWildCardElement_IsFixed => _LexerRuleWildCardElement_IsFixed;
		public static __ModelProperty LexerRuleWildCardElement_FixedText => _LexerRuleWildCardElement_FixedText;
		public static __ModelObjectInfo LexerRuleRangeElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRuleRangeElement_Impl.__Info.Instance;
		public static __ModelProperty LexerRuleRangeElement_IsFixed => _LexerRuleRangeElement_IsFixed;
		public static __ModelProperty LexerRuleRangeElement_FixedText => _LexerRuleRangeElement_FixedText;
		public static __ModelProperty LexerRuleRangeElement_StartChar => _LexerRuleRangeElement_StartChar;
		public static __ModelProperty LexerRuleRangeElement_EndChar => _LexerRuleRangeElement_EndChar;
		public static __ModelObjectInfo LexerRuleSetElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRuleSetElement_Impl.__Info.Instance;
		public static __ModelProperty LexerRuleSetElement_IsFixed => _LexerRuleSetElement_IsFixed;
		public static __ModelProperty LexerRuleSetElement_FixedText => _LexerRuleSetElement_FixedText;
		public static __ModelProperty LexerRuleSetElement_Items => _LexerRuleSetElement_Items;
		public static __ModelObjectInfo LexerRuleSetItemInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRuleSetItem_Impl.__Info.Instance;
		public static __ModelProperty LexerRuleSetItem_IsFixed => _LexerRuleSetItem_IsFixed;
		public static __ModelProperty LexerRuleSetItem_FixedText => _LexerRuleSetItem_FixedText;
		public static __ModelObjectInfo LexerRuleSetFixedCharInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRuleSetFixedChar_Impl.__Info.Instance;
		public static __ModelProperty LexerRuleSetFixedChar_IsFixed => _LexerRuleSetFixedChar_IsFixed;
		public static __ModelProperty LexerRuleSetFixedChar_FixedText => _LexerRuleSetFixedChar_FixedText;
		public static __ModelProperty LexerRuleSetFixedChar_Char => _LexerRuleSetFixedChar_Char;
		public static __ModelObjectInfo LexerRuleSetRangeInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRuleSetRange_Impl.__Info.Instance;
		public static __ModelProperty LexerRuleSetRange_IsFixed => _LexerRuleSetRange_IsFixed;
		public static __ModelProperty LexerRuleSetRange_FixedText => _LexerRuleSetRange_FixedText;
		public static __ModelProperty LexerRuleSetRange_StartChar => _LexerRuleSetRange_StartChar;
		public static __ModelProperty LexerRuleSetRange_EndChar => _LexerRuleSetRange_EndChar;
		public static __ModelObjectInfo LexerRuleBlockElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LexerRuleBlockElement_Impl.__Info.Instance;
		public static __ModelProperty LexerRuleBlockElement_IsFixed => _LexerRuleBlockElement_IsFixed;
		public static __ModelProperty LexerRuleBlockElement_FixedText => _LexerRuleBlockElement_FixedText;
		public static __ModelProperty LexerRuleBlockElement_Alternatives => _LexerRuleBlockElement_Alternatives;
		public static __ModelObjectInfo ParserRuleInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.ParserRule_Impl.__Info.Instance;
		public static __ModelProperty ParserRule_ReturnType => _ParserRule_ReturnType;
		public static __ModelProperty ParserRule_IsBlock => _ParserRule_IsBlock;
		public static __ModelProperty ParserRule_Alternatives => _ParserRule_Alternatives;
		public static __ModelObjectInfo ParserRuleAlternativeInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.ParserRuleAlternative_Impl.__Info.Instance;
		public static __ModelProperty ParserRuleAlternative_ReturnType => _ParserRuleAlternative_ReturnType;
		public static __ModelProperty ParserRuleAlternative_ReturnValue => _ParserRuleAlternative_ReturnValue;
		public static __ModelProperty ParserRuleAlternative_Elements => _ParserRuleAlternative_Elements;
		public static __ModelObjectInfo ParserRuleElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.ParserRuleElement_Impl.__Info.Instance;
		public static __ModelProperty ParserRuleElement_NameAnnotations => _ParserRuleElement_NameAnnotations;
		public static __ModelProperty ParserRuleElement_ValueAnnotations => _ParserRuleElement_ValueAnnotations;
		public static __ModelProperty ParserRuleElement_Property => _ParserRuleElement_Property;
		public static __ModelProperty ParserRuleElement_AssignmentOperator => _ParserRuleElement_AssignmentOperator;
		public static __ModelProperty ParserRuleElement_Multiplicity => _ParserRuleElement_Multiplicity;
		public static __ModelObjectInfo ParserRuleReferenceElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.ParserRuleReferenceElement_Impl.__Info.Instance;
		public static __ModelProperty ParserRuleReferenceElement_Rule => _ParserRuleReferenceElement_Rule;
		public static __ModelProperty ParserRuleReferenceElement_ReferencedTypes => _ParserRuleReferenceElement_ReferencedTypes;
		public static __ModelObjectInfo ParserRuleEofElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.ParserRuleEofElement_Impl.__Info.Instance;
		public static __ModelObjectInfo ParserRuleFixedStringElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.ParserRuleFixedStringElement_Impl.__Info.Instance;
		public static __ModelProperty ParserRuleFixedStringElement_Text => _ParserRuleFixedStringElement_Text;
		public static __ModelObjectInfo ParserRuleBlockElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.ParserRuleBlockElement_Impl.__Info.Instance;
		public static __ModelProperty ParserRuleBlockElement_Alternatives => _ParserRuleBlockElement_Alternatives;
		public static __ModelObjectInfo ExpressionInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.Expression_Impl.__Info.Instance;
		public static __ModelProperty Expression_Value => _Expression_Value;
		public static __ModelObjectInfo NullExpressionInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.NullExpression_Impl.__Info.Instance;
		public static __ModelProperty NullExpression_Value => _NullExpression_Value;
		public static __ModelObjectInfo BoolExpressionInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.BoolExpression_Impl.__Info.Instance;
		public static __ModelProperty BoolExpression_Value => _BoolExpression_Value;
		public static __ModelProperty BoolExpression_BoolValue => _BoolExpression_BoolValue;
		public static __ModelObjectInfo IntExpressionInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.IntExpression_Impl.__Info.Instance;
		public static __ModelProperty IntExpression_Value => _IntExpression_Value;
		public static __ModelProperty IntExpression_IntValue => _IntExpression_IntValue;
		public static __ModelObjectInfo StringExpressionInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.StringExpression_Impl.__Info.Instance;
		public static __ModelProperty StringExpression_Value => _StringExpression_Value;
		public static __ModelProperty StringExpression_StringValue => _StringExpression_StringValue;
		public static __ModelObjectInfo ReferenceExpressionInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.ReferenceExpression_Impl.__Info.Instance;
		public static __ModelProperty ReferenceExpression_Value => _ReferenceExpression_Value;
		public static __ModelProperty ReferenceExpression_SymbolValue => _ReferenceExpression_SymbolValue;
	}
	
	public class CompilerModelFactory : __ModelFactory
	{
		public CompilerModelFactory(__Model model)
			: base(model, Compiler.Instance)
		{
		}
	
		public Namespace Namespace(string? id = null)
		{
			return (Namespace)Compiler.NamespaceInfo.Create(Model, id)!;
		}
	
		public Language Language(string? id = null)
		{
			return (Language)Compiler.LanguageInfo.Create(Model, id)!;
		}
	
		public Grammar Grammar(string? id = null)
		{
			return (Grammar)Compiler.GrammarInfo.Create(Model, id)!;
		}
	
		public Annotation Annotation(string? id = null)
		{
			return (Annotation)Compiler.AnnotationInfo.Create(Model, id)!;
		}
	
		public AnnotationArgument AnnotationArgument(string? id = null)
		{
			return (AnnotationArgument)Compiler.AnnotationArgumentInfo.Create(Model, id)!;
		}
	
		public LexerRule LexerRule(string? id = null)
		{
			return (LexerRule)Compiler.LexerRuleInfo.Create(Model, id)!;
		}
	
		public LexerRuleAlternative LexerRuleAlternative(string? id = null)
		{
			return (LexerRuleAlternative)Compiler.LexerRuleAlternativeInfo.Create(Model, id)!;
		}
	
		public LexerRuleReferenceElement LexerRuleReferenceElement(string? id = null)
		{
			return (LexerRuleReferenceElement)Compiler.LexerRuleReferenceElementInfo.Create(Model, id)!;
		}
	
		public LexerRuleFixedStringElement LexerRuleFixedStringElement(string? id = null)
		{
			return (LexerRuleFixedStringElement)Compiler.LexerRuleFixedStringElementInfo.Create(Model, id)!;
		}
	
		public LexerRuleWildCardElement LexerRuleWildCardElement(string? id = null)
		{
			return (LexerRuleWildCardElement)Compiler.LexerRuleWildCardElementInfo.Create(Model, id)!;
		}
	
		public LexerRuleRangeElement LexerRuleRangeElement(string? id = null)
		{
			return (LexerRuleRangeElement)Compiler.LexerRuleRangeElementInfo.Create(Model, id)!;
		}
	
		public LexerRuleSetElement LexerRuleSetElement(string? id = null)
		{
			return (LexerRuleSetElement)Compiler.LexerRuleSetElementInfo.Create(Model, id)!;
		}
	
		public LexerRuleSetFixedChar LexerRuleSetFixedChar(string? id = null)
		{
			return (LexerRuleSetFixedChar)Compiler.LexerRuleSetFixedCharInfo.Create(Model, id)!;
		}
	
		public LexerRuleSetRange LexerRuleSetRange(string? id = null)
		{
			return (LexerRuleSetRange)Compiler.LexerRuleSetRangeInfo.Create(Model, id)!;
		}
	
		public LexerRuleBlockElement LexerRuleBlockElement(string? id = null)
		{
			return (LexerRuleBlockElement)Compiler.LexerRuleBlockElementInfo.Create(Model, id)!;
		}
	
		public ParserRuleAlternative ParserRuleAlternative(string? id = null)
		{
			return (ParserRuleAlternative)Compiler.ParserRuleAlternativeInfo.Create(Model, id)!;
		}
	
		public ParserRuleReferenceElement ParserRuleReferenceElement(string? id = null)
		{
			return (ParserRuleReferenceElement)Compiler.ParserRuleReferenceElementInfo.Create(Model, id)!;
		}
	
		public ParserRuleEofElement ParserRuleEofElement(string? id = null)
		{
			return (ParserRuleEofElement)Compiler.ParserRuleEofElementInfo.Create(Model, id)!;
		}
	
		public ParserRuleFixedStringElement ParserRuleFixedStringElement(string? id = null)
		{
			return (ParserRuleFixedStringElement)Compiler.ParserRuleFixedStringElementInfo.Create(Model, id)!;
		}
	
		public ParserRuleBlockElement ParserRuleBlockElement(string? id = null)
		{
			return (ParserRuleBlockElement)Compiler.ParserRuleBlockElementInfo.Create(Model, id)!;
		}
	
		public NullExpression NullExpression(string? id = null)
		{
			return (NullExpression)Compiler.NullExpressionInfo.Create(Model, id)!;
		}
	
		public BoolExpression BoolExpression(string? id = null)
		{
			return (BoolExpression)Compiler.BoolExpressionInfo.Create(Model, id)!;
		}
	
		public IntExpression IntExpression(string? id = null)
		{
			return (IntExpression)Compiler.IntExpressionInfo.Create(Model, id)!;
		}
	
		public StringExpression StringExpression(string? id = null)
		{
			return (StringExpression)Compiler.StringExpressionInfo.Create(Model, id)!;
		}
	
		public ReferenceExpression ReferenceExpression(string? id = null)
		{
			return (ReferenceExpression)Compiler.ReferenceExpressionInfo.Create(Model, id)!;
		}
	
	}
	
	public class CompilerModelMultiFactory : __MultiModelFactory
	{
		public CompilerModelMultiFactory()
			: base(new __MetaModel[] { Compiler.Instance })
		{
		}
	
		public Namespace Namespace(__Model model, string? id = null)
		{
			return (Namespace)Compiler.NamespaceInfo.Create(model, id)!;
		}
	
		public Language Language(__Model model, string? id = null)
		{
			return (Language)Compiler.LanguageInfo.Create(model, id)!;
		}
	
		public Grammar Grammar(__Model model, string? id = null)
		{
			return (Grammar)Compiler.GrammarInfo.Create(model, id)!;
		}
	
		public Annotation Annotation(__Model model, string? id = null)
		{
			return (Annotation)Compiler.AnnotationInfo.Create(model, id)!;
		}
	
		public AnnotationArgument AnnotationArgument(__Model model, string? id = null)
		{
			return (AnnotationArgument)Compiler.AnnotationArgumentInfo.Create(model, id)!;
		}
	
		public LexerRule LexerRule(__Model model, string? id = null)
		{
			return (LexerRule)Compiler.LexerRuleInfo.Create(model, id)!;
		}
	
		public LexerRuleAlternative LexerRuleAlternative(__Model model, string? id = null)
		{
			return (LexerRuleAlternative)Compiler.LexerRuleAlternativeInfo.Create(model, id)!;
		}
	
		public LexerRuleReferenceElement LexerRuleReferenceElement(__Model model, string? id = null)
		{
			return (LexerRuleReferenceElement)Compiler.LexerRuleReferenceElementInfo.Create(model, id)!;
		}
	
		public LexerRuleFixedStringElement LexerRuleFixedStringElement(__Model model, string? id = null)
		{
			return (LexerRuleFixedStringElement)Compiler.LexerRuleFixedStringElementInfo.Create(model, id)!;
		}
	
		public LexerRuleWildCardElement LexerRuleWildCardElement(__Model model, string? id = null)
		{
			return (LexerRuleWildCardElement)Compiler.LexerRuleWildCardElementInfo.Create(model, id)!;
		}
	
		public LexerRuleRangeElement LexerRuleRangeElement(__Model model, string? id = null)
		{
			return (LexerRuleRangeElement)Compiler.LexerRuleRangeElementInfo.Create(model, id)!;
		}
	
		public LexerRuleSetElement LexerRuleSetElement(__Model model, string? id = null)
		{
			return (LexerRuleSetElement)Compiler.LexerRuleSetElementInfo.Create(model, id)!;
		}
	
		public LexerRuleSetFixedChar LexerRuleSetFixedChar(__Model model, string? id = null)
		{
			return (LexerRuleSetFixedChar)Compiler.LexerRuleSetFixedCharInfo.Create(model, id)!;
		}
	
		public LexerRuleSetRange LexerRuleSetRange(__Model model, string? id = null)
		{
			return (LexerRuleSetRange)Compiler.LexerRuleSetRangeInfo.Create(model, id)!;
		}
	
		public LexerRuleBlockElement LexerRuleBlockElement(__Model model, string? id = null)
		{
			return (LexerRuleBlockElement)Compiler.LexerRuleBlockElementInfo.Create(model, id)!;
		}
	
		public ParserRuleAlternative ParserRuleAlternative(__Model model, string? id = null)
		{
			return (ParserRuleAlternative)Compiler.ParserRuleAlternativeInfo.Create(model, id)!;
		}
	
		public ParserRuleReferenceElement ParserRuleReferenceElement(__Model model, string? id = null)
		{
			return (ParserRuleReferenceElement)Compiler.ParserRuleReferenceElementInfo.Create(model, id)!;
		}
	
		public ParserRuleEofElement ParserRuleEofElement(__Model model, string? id = null)
		{
			return (ParserRuleEofElement)Compiler.ParserRuleEofElementInfo.Create(model, id)!;
		}
	
		public ParserRuleFixedStringElement ParserRuleFixedStringElement(__Model model, string? id = null)
		{
			return (ParserRuleFixedStringElement)Compiler.ParserRuleFixedStringElementInfo.Create(model, id)!;
		}
	
		public ParserRuleBlockElement ParserRuleBlockElement(__Model model, string? id = null)
		{
			return (ParserRuleBlockElement)Compiler.ParserRuleBlockElementInfo.Create(model, id)!;
		}
	
		public NullExpression NullExpression(__Model model, string? id = null)
		{
			return (NullExpression)Compiler.NullExpressionInfo.Create(model, id)!;
		}
	
		public BoolExpression BoolExpression(__Model model, string? id = null)
		{
			return (BoolExpression)Compiler.BoolExpressionInfo.Create(model, id)!;
		}
	
		public IntExpression IntExpression(__Model model, string? id = null)
		{
			return (IntExpression)Compiler.IntExpressionInfo.Create(model, id)!;
		}
	
		public StringExpression StringExpression(__Model model, string? id = null)
		{
			return (StringExpression)Compiler.StringExpressionInfo.Create(model, id)!;
		}
	
		public ReferenceExpression ReferenceExpression(__Model model, string? id = null)
		{
			return (ReferenceExpression)Compiler.ReferenceExpressionInfo.Create(model, id)!;
		}
	
	}
	

	public enum Multiplicity
	{
		ExactlyOne,
		ZeroOrOne,
		ZeroOrMore,
		OneOrMore,
		NonGreedyZeroOrOne,
		NonGreedyZeroOrMore,
		NonGreedyOneOrMore,
	}

	public enum AssignmentOperator
	{
		Assign,
		QuestionAssign,
		NegatedAssign,
		PlusAssign,
	}


	public interface Declaration : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Annotation> Annotations { get; }
		global::System.Collections.Generic.IList<Declaration> Declarations { get; }
		string? FullName { get; }
		string? Name { get; set; }
		Declaration? Parent { get; set; }
	
	}

	public interface Namespace : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
	
	}

	public interface Language : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		Grammar Grammar { get; set; }
	
	}

	public interface Grammar : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		Language Language { get; set; }
		global::System.Collections.Generic.IList<Rule> Rules { get; }
	
	}

	public interface Annotation : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<AnnotationArgument> Arguments { get; }
		__MetaType Type { get; set; }
	
	}

	public interface AnnotationArgument : __IModelObjectCore
	{
		__MetaSymbol Parameter { get; set; }
		__MetaType Type { get; set; }
		Expression Value { get; set; }
	
	}

	public interface Rule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		Grammar Grammar { get; set; }
		Language Language { get; }
	
	}

	public interface LexerRule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Rule
	{
		global::System.Collections.Generic.IList<LexerRuleAlternative> Alternatives { get; }
		string? FixedText { get; }
		bool IsFixed { get; }
		bool IsFragment { get; set; }
		bool IsHidden { get; set; }
		__MetaType ReturnType { get; set; }
	
	}

	public interface LexerRuleAlternative : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<LexerRuleElement> Elements { get; }
		string? FixedText { get; }
		bool IsFixed { get; }
	
	}

	public interface LexerRuleElement : __IModelObjectCore
	{
		string? FixedText { get; }
		bool IsFixed { get; }
		bool IsNegated { get; set; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
	
	}

	public interface LexerRuleReferenceElement : global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRuleElement
	{
		new string? FixedText { get; }
		new bool IsFixed { get; }
		LexerRule Rule { get; set; }
	
	}

	public interface LexerRuleFixedStringElement : global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRuleElement
	{
		new string? FixedText { get; }
		new bool IsFixed { get; }
		string Text { get; set; }
	
	}

	public interface LexerRuleWildCardElement : global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRuleElement
	{
		new string? FixedText { get; }
		new bool IsFixed { get; }
	
	}

	public interface LexerRuleRangeElement : global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRuleElement
	{
		string EndChar { get; set; }
		new string? FixedText { get; }
		new bool IsFixed { get; }
		string StartChar { get; set; }
	
	}

	public interface LexerRuleSetElement : global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRuleElement
	{
		new string? FixedText { get; }
		new bool IsFixed { get; }
		global::System.Collections.Generic.IList<LexerRuleSetItem> Items { get; }
	
	}

	public interface LexerRuleSetItem : __IModelObjectCore
	{
		string? FixedText { get; }
		bool IsFixed { get; }
	
	}

	public interface LexerRuleSetFixedChar : global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRuleSetItem
	{
		string Char { get; set; }
		new string? FixedText { get; }
		new bool IsFixed { get; }
	
	}

	public interface LexerRuleSetRange : global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRuleSetItem
	{
		string EndChar { get; set; }
		new string? FixedText { get; }
		new bool IsFixed { get; }
		string StartChar { get; set; }
	
	}

	public interface LexerRuleBlockElement : global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRuleElement
	{
		global::System.Collections.Generic.IList<LexerRuleAlternative> Alternatives { get; }
		new string? FixedText { get; }
		new bool IsFixed { get; }
	
	}

	public interface ParserRule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Rule
	{
		global::System.Collections.Generic.IList<ParserRuleAlternative> Alternatives { get; }
		bool IsBlock { get; set; }
		__MetaType? ReturnType { get; set; }
	
	}

	public interface ParserRuleAlternative : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		global::System.Collections.Generic.IList<ParserRuleElement> Elements { get; }
		__MetaType? ReturnType { get; set; }
		Expression ReturnValue { get; set; }
	
	}

	public interface ParserRuleElement : __IModelObjectCore
	{
		global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator AssignmentOperator { get; set; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
		global::System.Collections.Generic.IList<Annotation> NameAnnotations { get; }
		__MetaSymbol? Property { get; set; }
		global::System.Collections.Generic.IList<Annotation> ValueAnnotations { get; }
	
	}

	public interface ParserRuleReferenceElement : global::MetaDslx.Bootstrap.MetaCompiler.Model.ParserRuleElement
	{
		global::System.Collections.Generic.IList<__MetaType> ReferencedTypes { get; }
		Rule Rule { get; set; }
	
	}

	public interface ParserRuleEofElement : global::MetaDslx.Bootstrap.MetaCompiler.Model.ParserRuleElement
	{
	
	}

	public interface ParserRuleFixedStringElement : global::MetaDslx.Bootstrap.MetaCompiler.Model.ParserRuleElement
	{
		string Text { get; set; }
	
	}

	public interface ParserRuleBlockElement : global::MetaDslx.Bootstrap.MetaCompiler.Model.ParserRuleElement
	{
		global::System.Collections.Generic.IList<ParserRuleAlternative> Alternatives { get; }
	
	}

	public interface Expression : __IModelObjectCore
	{
		object? Value { get; }
	
	}

	public interface NullExpression : __IModelObjectCore
	{
		object? Value { get; }
	
	}

	public interface BoolExpression : __IModelObjectCore
	{
		bool BoolValue { get; set; }
		object? Value { get; }
	
	}

	public interface IntExpression : __IModelObjectCore
	{
		int IntValue { get; set; }
		object? Value { get; }
	
	}

	public interface StringExpression : __IModelObjectCore
	{
		string StringValue { get; set; }
		object? Value { get; }
	
	}

	public interface ReferenceExpression : __IModelObjectCore
	{
		__MetaSymbol SymbolValue { get; set; }
		object? Value { get; }
	
	}


	internal interface ICustomCompilerImplementation
	{
		/// <summary>
		/// Constructor for the meta model Compiler
		/// </summary>
		void Compiler(ICompiler _this);
	
		/// <summary>
		/// Constructor for the class Declaration
		/// </summary>
		void Declaration(Declaration _this);
	
		/// <summary>
		/// Constructor for the class Namespace
		/// </summary>
		void Namespace(Namespace _this);
	
		/// <summary>
		/// Constructor for the class Language
		/// </summary>
		void Language(Language _this);
	
		/// <summary>
		/// Constructor for the class Grammar
		/// </summary>
		void Grammar(Grammar _this);
	
		/// <summary>
		/// Constructor for the class Annotation
		/// </summary>
		void Annotation(Annotation _this);
	
		/// <summary>
		/// Constructor for the class AnnotationArgument
		/// </summary>
		void AnnotationArgument(AnnotationArgument _this);
	
		/// <summary>
		/// Constructor for the class Rule
		/// </summary>
		void Rule(Rule _this);
	
		/// <summary>
		/// Constructor for the class LexerRule
		/// </summary>
		void LexerRule(LexerRule _this);
	
		/// <summary>
		/// Constructor for the class LexerRuleAlternative
		/// </summary>
		void LexerRuleAlternative(LexerRuleAlternative _this);
	
		/// <summary>
		/// Constructor for the class LexerRuleElement
		/// </summary>
		void LexerRuleElement(LexerRuleElement _this);
	
		/// <summary>
		/// Constructor for the class LexerRuleReferenceElement
		/// </summary>
		void LexerRuleReferenceElement(LexerRuleReferenceElement _this);
	
		/// <summary>
		/// Constructor for the class LexerRuleFixedStringElement
		/// </summary>
		void LexerRuleFixedStringElement(LexerRuleFixedStringElement _this);
	
		/// <summary>
		/// Constructor for the class LexerRuleWildCardElement
		/// </summary>
		void LexerRuleWildCardElement(LexerRuleWildCardElement _this);
	
		/// <summary>
		/// Constructor for the class LexerRuleRangeElement
		/// </summary>
		void LexerRuleRangeElement(LexerRuleRangeElement _this);
	
		/// <summary>
		/// Constructor for the class LexerRuleSetElement
		/// </summary>
		void LexerRuleSetElement(LexerRuleSetElement _this);
	
		/// <summary>
		/// Constructor for the class LexerRuleSetItem
		/// </summary>
		void LexerRuleSetItem(LexerRuleSetItem _this);
	
		/// <summary>
		/// Constructor for the class LexerRuleSetFixedChar
		/// </summary>
		void LexerRuleSetFixedChar(LexerRuleSetFixedChar _this);
	
		/// <summary>
		/// Constructor for the class LexerRuleSetRange
		/// </summary>
		void LexerRuleSetRange(LexerRuleSetRange _this);
	
		/// <summary>
		/// Constructor for the class LexerRuleBlockElement
		/// </summary>
		void LexerRuleBlockElement(LexerRuleBlockElement _this);
	
		/// <summary>
		/// Constructor for the class ParserRule
		/// </summary>
		void ParserRule(ParserRule _this);
	
		/// <summary>
		/// Constructor for the class ParserRuleAlternative
		/// </summary>
		void ParserRuleAlternative(ParserRuleAlternative _this);
	
		/// <summary>
		/// Constructor for the class ParserRuleElement
		/// </summary>
		void ParserRuleElement(ParserRuleElement _this);
	
		/// <summary>
		/// Constructor for the class ParserRuleReferenceElement
		/// </summary>
		void ParserRuleReferenceElement(ParserRuleReferenceElement _this);
	
		/// <summary>
		/// Constructor for the class ParserRuleEofElement
		/// </summary>
		void ParserRuleEofElement(ParserRuleEofElement _this);
	
		/// <summary>
		/// Constructor for the class ParserRuleFixedStringElement
		/// </summary>
		void ParserRuleFixedStringElement(ParserRuleFixedStringElement _this);
	
		/// <summary>
		/// Constructor for the class ParserRuleBlockElement
		/// </summary>
		void ParserRuleBlockElement(ParserRuleBlockElement _this);
	
		/// <summary>
		/// Constructor for the class Expression
		/// </summary>
		void Expression(Expression _this);
	
		/// <summary>
		/// Constructor for the class NullExpression
		/// </summary>
		void NullExpression(NullExpression _this);
	
		/// <summary>
		/// Constructor for the class BoolExpression
		/// </summary>
		void BoolExpression(BoolExpression _this);
	
		/// <summary>
		/// Constructor for the class IntExpression
		/// </summary>
		void IntExpression(IntExpression _this);
	
		/// <summary>
		/// Constructor for the class StringExpression
		/// </summary>
		void StringExpression(StringExpression _this);
	
		/// <summary>
		/// Constructor for the class ReferenceExpression
		/// </summary>
		void ReferenceExpression(ReferenceExpression _this);
	
	
		/// <summary>
		/// Computation of the derived property Declaration.FullName
		/// </summary>
		string? Declaration_FullName(Declaration _this);
	
		/// <summary>
		/// Computation of the derived property Rule.Language
		/// </summary>
		Language Rule_Language(Rule _this);
	
		/// <summary>
		/// Computation of the derived property LexerRule.IsFixed
		/// </summary>
		bool LexerRule_IsFixed(LexerRule _this);
	
		/// <summary>
		/// Computation of the derived property LexerRule.FixedText
		/// </summary>
		string? LexerRule_FixedText(LexerRule _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleAlternative.IsFixed
		/// </summary>
		bool LexerRuleAlternative_IsFixed(LexerRuleAlternative _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleAlternative.FixedText
		/// </summary>
		string? LexerRuleAlternative_FixedText(LexerRuleAlternative _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleElement.IsFixed
		/// </summary>
		bool LexerRuleElement_IsFixed(LexerRuleElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleElement.FixedText
		/// </summary>
		string? LexerRuleElement_FixedText(LexerRuleElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleReferenceElement.IsFixed
		/// </summary>
		bool LexerRuleReferenceElement_IsFixed(LexerRuleReferenceElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleReferenceElement.FixedText
		/// </summary>
		string? LexerRuleReferenceElement_FixedText(LexerRuleReferenceElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleFixedStringElement.IsFixed
		/// </summary>
		bool LexerRuleFixedStringElement_IsFixed(LexerRuleFixedStringElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleFixedStringElement.FixedText
		/// </summary>
		string? LexerRuleFixedStringElement_FixedText(LexerRuleFixedStringElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleWildCardElement.IsFixed
		/// </summary>
		bool LexerRuleWildCardElement_IsFixed(LexerRuleWildCardElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleWildCardElement.FixedText
		/// </summary>
		string? LexerRuleWildCardElement_FixedText(LexerRuleWildCardElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleRangeElement.IsFixed
		/// </summary>
		bool LexerRuleRangeElement_IsFixed(LexerRuleRangeElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleRangeElement.FixedText
		/// </summary>
		string? LexerRuleRangeElement_FixedText(LexerRuleRangeElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetElement.IsFixed
		/// </summary>
		bool LexerRuleSetElement_IsFixed(LexerRuleSetElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetElement.FixedText
		/// </summary>
		string? LexerRuleSetElement_FixedText(LexerRuleSetElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetItem.IsFixed
		/// </summary>
		bool LexerRuleSetItem_IsFixed(LexerRuleSetItem _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetItem.FixedText
		/// </summary>
		string? LexerRuleSetItem_FixedText(LexerRuleSetItem _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetFixedChar.IsFixed
		/// </summary>
		bool LexerRuleSetFixedChar_IsFixed(LexerRuleSetFixedChar _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetFixedChar.FixedText
		/// </summary>
		string? LexerRuleSetFixedChar_FixedText(LexerRuleSetFixedChar _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetRange.IsFixed
		/// </summary>
		bool LexerRuleSetRange_IsFixed(LexerRuleSetRange _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetRange.FixedText
		/// </summary>
		string? LexerRuleSetRange_FixedText(LexerRuleSetRange _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleBlockElement.IsFixed
		/// </summary>
		bool LexerRuleBlockElement_IsFixed(LexerRuleBlockElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleBlockElement.FixedText
		/// </summary>
		string? LexerRuleBlockElement_FixedText(LexerRuleBlockElement _this);
	
		/// <summary>
		/// Computation of the derived property Expression.Value
		/// </summary>
		object? Expression_Value(Expression _this);
	
		/// <summary>
		/// Computation of the derived property NullExpression.Value
		/// </summary>
		object? NullExpression_Value(NullExpression _this);
	
		/// <summary>
		/// Computation of the derived property BoolExpression.Value
		/// </summary>
		object? BoolExpression_Value(BoolExpression _this);
	
		/// <summary>
		/// Computation of the derived property IntExpression.Value
		/// </summary>
		object? IntExpression_Value(IntExpression _this);
	
		/// <summary>
		/// Computation of the derived property StringExpression.Value
		/// </summary>
		object? StringExpression_Value(StringExpression _this);
	
		/// <summary>
		/// Computation of the derived property ReferenceExpression.Value
		/// </summary>
		object? ReferenceExpression_Value(ReferenceExpression _this);
	
	
	}
	
	internal abstract class CustomCompilerImplementationBase : ICustomCompilerImplementation
	{
		/// <summary>
		/// Constructor for the meta model Compiler
		/// </summary>
		public virtual void Compiler(ICompiler _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Declaration
		/// </summary>
		public virtual void Declaration(Declaration _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Namespace
		/// </summary>
		public virtual void Namespace(Namespace _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Language
		/// </summary>
		public virtual void Language(Language _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Grammar
		/// </summary>
		public virtual void Grammar(Grammar _this)
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
		/// Constructor for the class Rule
		/// </summary>
		public virtual void Rule(Rule _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRule
		/// </summary>
		public virtual void LexerRule(LexerRule _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRuleAlternative
		/// </summary>
		public virtual void LexerRuleAlternative(LexerRuleAlternative _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRuleElement
		/// </summary>
		public virtual void LexerRuleElement(LexerRuleElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRuleReferenceElement
		/// </summary>
		public virtual void LexerRuleReferenceElement(LexerRuleReferenceElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRuleFixedStringElement
		/// </summary>
		public virtual void LexerRuleFixedStringElement(LexerRuleFixedStringElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRuleWildCardElement
		/// </summary>
		public virtual void LexerRuleWildCardElement(LexerRuleWildCardElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRuleRangeElement
		/// </summary>
		public virtual void LexerRuleRangeElement(LexerRuleRangeElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRuleSetElement
		/// </summary>
		public virtual void LexerRuleSetElement(LexerRuleSetElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRuleSetItem
		/// </summary>
		public virtual void LexerRuleSetItem(LexerRuleSetItem _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRuleSetFixedChar
		/// </summary>
		public virtual void LexerRuleSetFixedChar(LexerRuleSetFixedChar _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRuleSetRange
		/// </summary>
		public virtual void LexerRuleSetRange(LexerRuleSetRange _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRuleBlockElement
		/// </summary>
		public virtual void LexerRuleBlockElement(LexerRuleBlockElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ParserRule
		/// </summary>
		public virtual void ParserRule(ParserRule _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ParserRuleAlternative
		/// </summary>
		public virtual void ParserRuleAlternative(ParserRuleAlternative _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ParserRuleElement
		/// </summary>
		public virtual void ParserRuleElement(ParserRuleElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ParserRuleReferenceElement
		/// </summary>
		public virtual void ParserRuleReferenceElement(ParserRuleReferenceElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ParserRuleEofElement
		/// </summary>
		public virtual void ParserRuleEofElement(ParserRuleEofElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ParserRuleFixedStringElement
		/// </summary>
		public virtual void ParserRuleFixedStringElement(ParserRuleFixedStringElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ParserRuleBlockElement
		/// </summary>
		public virtual void ParserRuleBlockElement(ParserRuleBlockElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Expression
		/// </summary>
		public virtual void Expression(Expression _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class NullExpression
		/// </summary>
		public virtual void NullExpression(NullExpression _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class BoolExpression
		/// </summary>
		public virtual void BoolExpression(BoolExpression _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class IntExpression
		/// </summary>
		public virtual void IntExpression(IntExpression _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class StringExpression
		/// </summary>
		public virtual void StringExpression(StringExpression _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ReferenceExpression
		/// </summary>
		public virtual void ReferenceExpression(ReferenceExpression _this)
		{
		}
	
	
		/// <summary>
		/// Computation of the derived property Declaration.FullName
		/// </summary>
		public abstract string? Declaration_FullName(Declaration _this);
	
		/// <summary>
		/// Computation of the derived property Rule.Language
		/// </summary>
		public abstract Language Rule_Language(Rule _this);
	
		/// <summary>
		/// Computation of the derived property LexerRule.IsFixed
		/// </summary>
		public abstract bool LexerRule_IsFixed(LexerRule _this);
	
		/// <summary>
		/// Computation of the derived property LexerRule.FixedText
		/// </summary>
		public abstract string? LexerRule_FixedText(LexerRule _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleAlternative.IsFixed
		/// </summary>
		public abstract bool LexerRuleAlternative_IsFixed(LexerRuleAlternative _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleAlternative.FixedText
		/// </summary>
		public abstract string? LexerRuleAlternative_FixedText(LexerRuleAlternative _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleElement.IsFixed
		/// </summary>
		public abstract bool LexerRuleElement_IsFixed(LexerRuleElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleElement.FixedText
		/// </summary>
		public abstract string? LexerRuleElement_FixedText(LexerRuleElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleReferenceElement.IsFixed
		/// </summary>
		public abstract bool LexerRuleReferenceElement_IsFixed(LexerRuleReferenceElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleReferenceElement.FixedText
		/// </summary>
		public abstract string? LexerRuleReferenceElement_FixedText(LexerRuleReferenceElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleFixedStringElement.IsFixed
		/// </summary>
		public abstract bool LexerRuleFixedStringElement_IsFixed(LexerRuleFixedStringElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleFixedStringElement.FixedText
		/// </summary>
		public abstract string? LexerRuleFixedStringElement_FixedText(LexerRuleFixedStringElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleWildCardElement.IsFixed
		/// </summary>
		public abstract bool LexerRuleWildCardElement_IsFixed(LexerRuleWildCardElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleWildCardElement.FixedText
		/// </summary>
		public abstract string? LexerRuleWildCardElement_FixedText(LexerRuleWildCardElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleRangeElement.IsFixed
		/// </summary>
		public abstract bool LexerRuleRangeElement_IsFixed(LexerRuleRangeElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleRangeElement.FixedText
		/// </summary>
		public abstract string? LexerRuleRangeElement_FixedText(LexerRuleRangeElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetElement.IsFixed
		/// </summary>
		public abstract bool LexerRuleSetElement_IsFixed(LexerRuleSetElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetElement.FixedText
		/// </summary>
		public abstract string? LexerRuleSetElement_FixedText(LexerRuleSetElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetItem.IsFixed
		/// </summary>
		public abstract bool LexerRuleSetItem_IsFixed(LexerRuleSetItem _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetItem.FixedText
		/// </summary>
		public abstract string? LexerRuleSetItem_FixedText(LexerRuleSetItem _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetFixedChar.IsFixed
		/// </summary>
		public abstract bool LexerRuleSetFixedChar_IsFixed(LexerRuleSetFixedChar _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetFixedChar.FixedText
		/// </summary>
		public abstract string? LexerRuleSetFixedChar_FixedText(LexerRuleSetFixedChar _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetRange.IsFixed
		/// </summary>
		public abstract bool LexerRuleSetRange_IsFixed(LexerRuleSetRange _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleSetRange.FixedText
		/// </summary>
		public abstract string? LexerRuleSetRange_FixedText(LexerRuleSetRange _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleBlockElement.IsFixed
		/// </summary>
		public abstract bool LexerRuleBlockElement_IsFixed(LexerRuleBlockElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRuleBlockElement.FixedText
		/// </summary>
		public abstract string? LexerRuleBlockElement_FixedText(LexerRuleBlockElement _this);
	
		/// <summary>
		/// Computation of the derived property Expression.Value
		/// </summary>
		public abstract object? Expression_Value(Expression _this);
	
		/// <summary>
		/// Computation of the derived property NullExpression.Value
		/// </summary>
		public abstract object? NullExpression_Value(NullExpression _this);
	
		/// <summary>
		/// Computation of the derived property BoolExpression.Value
		/// </summary>
		public abstract object? BoolExpression_Value(BoolExpression _this);
	
		/// <summary>
		/// Computation of the derived property IntExpression.Value
		/// </summary>
		public abstract object? IntExpression_Value(IntExpression _this);
	
		/// <summary>
		/// Computation of the derived property StringExpression.Value
		/// </summary>
		public abstract object? StringExpression_Value(StringExpression _this);
	
		/// <summary>
		/// Computation of the derived property ReferenceExpression.Value
		/// </summary>
		public abstract object? ReferenceExpression_Value(ReferenceExpression _this);
	
	
	}
}

namespace MetaDslx.Bootstrap.MetaCompiler.Model.__Impl
{
	using __Model = global::MetaDslx.Modeling.Model;
	using __MetaModel = global::MetaDslx.Modeling.MetaModel;
	using __IModelObject = global::MetaDslx.Modeling.IModelObject;
	using __IModelObjectCore = global::MetaDslx.Modeling.IModelObjectCore;
	using __MetaModelObject = global::MetaDslx.Modeling.MetaModelObject;
	using __ModelObjectInfo = global::MetaDslx.Modeling.ModelObjectInfo;
	using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
	using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
	using __ModelPropertyInfo = global::MetaDslx.Modeling.ModelPropertyInfo;
	using __ModelPropertySlot = global::MetaDslx.Modeling.ModelPropertySlot;
	using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
	using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
	using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
	using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
	using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
	using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
	using __Type = global::System.Type;

	internal class Declaration_Impl : __MetaModelObject, Declaration
	{
		private Declaration_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::System.Collections.Generic.IList<Declaration> Declarations
		{
			get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
		}
	
		public string? FullName
		{
			get => Compiler.__CustomImpl.Declaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Compiler.Declaration_Name);
			set => MAdd<string?>(Compiler.Declaration_Name, value);
		}
	
		public Declaration? Parent
		{
			get => MGet<Declaration?>(Compiler.Declaration_Parent);
			set => MAdd<Declaration?>(Compiler.Declaration_Parent, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Parent, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(Declaration);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new Declaration_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.DeclarationInfo";
			}
		}
	}

	internal class Namespace_Impl : __MetaModelObject, Namespace
	{
		private Namespace_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Namespace(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::System.Collections.Generic.IList<Declaration> Declarations
		{
			get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
		}
	
		public string? FullName
		{
			get => Compiler.__CustomImpl.Declaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Compiler.Declaration_Name);
			set => MAdd<string?>(Compiler.Declaration_Name, value);
		}
	
		public Declaration? Parent
		{
			get => MGet<Declaration?>(Compiler.Declaration_Parent);
			set => MAdd<Declaration?>(Compiler.Declaration_Parent, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.DeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.DeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Parent, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(Namespace);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new Namespace_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.NamespaceInfo";
			}
		}
	}

	internal class Language_Impl : __MetaModelObject, Language
	{
		private Language_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Language(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public Grammar Grammar
		{
			get => MGet<Grammar>(Compiler.Language_Grammar);
			set => MAdd<Grammar>(Compiler.Language_Grammar, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::System.Collections.Generic.IList<Declaration> Declarations
		{
			get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
		}
	
		public string? FullName
		{
			get => Compiler.__CustomImpl.Declaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Compiler.Declaration_Name);
			set => MAdd<string?>(Compiler.Declaration_Name, value);
		}
	
		public Declaration? Parent
		{
			get => MGet<Declaration?>(Compiler.Declaration_Parent);
			set => MAdd<Declaration?>(Compiler.Declaration_Parent, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.DeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.DeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Grammar", Compiler.Language_Grammar);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Language_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Language_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Parent, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(Language);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new Language_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LanguageInfo";
			}
		}
	}

	internal class Grammar_Impl : __MetaModelObject, Grammar
	{
		private Grammar_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.Grammar_Rules, new global::MetaDslx.Modeling.ModelObjectList<Rule>(this, __Info.Instance.GetSlot(Compiler.Grammar_Rules)!));
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Grammar(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public Language Language
		{
			get => MGet<Language>(Compiler.Grammar_Language);
			set => MAdd<Language>(Compiler.Grammar_Language, value);
		}
	
		public global::System.Collections.Generic.IList<Rule> Rules
		{
			get => MGetCollection<Rule>(Compiler.Grammar_Rules);
		}
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::System.Collections.Generic.IList<Declaration> Declarations
		{
			get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
		}
	
		public string? FullName
		{
			get => Compiler.__CustomImpl.Declaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Compiler.Declaration_Name);
			set => MAdd<string?>(Compiler.Declaration_Name, value);
		}
	
		public Declaration? Parent
		{
			get => MGet<Declaration?>(Compiler.Declaration_Parent);
			set => MAdd<Declaration?>(Compiler.Declaration_Parent, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.DeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.DeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language, Compiler.Grammar_Rules);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language, Compiler.Grammar_Rules, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language, Compiler.Grammar_Rules, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Language", Compiler.Grammar_Language);
				publicPropertiesByName.Add("Rules", Compiler.Grammar_Rules);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Grammar_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Grammar_Rules, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Rules, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Rules), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(Grammar);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new Grammar_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.GrammarInfo";
			}
		}
	}

	internal class Annotation_Impl : __MetaModelObject, Annotation
	{
		private Annotation_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.Annotation_Arguments, new global::MetaDslx.Modeling.ModelObjectList<AnnotationArgument>(this, __Info.Instance.GetSlot(Compiler.Annotation_Arguments)!));
			Compiler.__CustomImpl.Annotation(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<AnnotationArgument> Arguments
		{
			get => MGetCollection<AnnotationArgument>(Compiler.Annotation_Arguments);
		}
	
		public __MetaType Type
		{
			get => MGet<__MetaType>(Compiler.Annotation_Type);
			set => MAdd<__MetaType>(Compiler.Annotation_Type, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments, Compiler.Annotation_Type);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments, Compiler.Annotation_Type);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments, Compiler.Annotation_Type);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Arguments", Compiler.Annotation_Arguments);
				publicPropertiesByName.Add("Type", Compiler.Annotation_Type);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Annotation_Arguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Annotation_Arguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Annotation_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Annotation_Type, __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Type), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(Annotation);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new Annotation_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.AnnotationInfo";
			}
		}
	}

	internal class AnnotationArgument_Impl : __MetaModelObject, AnnotationArgument
	{
		private AnnotationArgument_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.AnnotationArgument(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public __MetaSymbol Parameter
		{
			get => MGet<__MetaSymbol>(Compiler.AnnotationArgument_Parameter);
			set => MAdd<__MetaSymbol>(Compiler.AnnotationArgument_Parameter, value);
		}
	
		public __MetaType Type
		{
			get => MGet<__MetaType>(Compiler.AnnotationArgument_Type);
			set => MAdd<__MetaType>(Compiler.AnnotationArgument_Type, value);
		}
	
		public Expression Value
		{
			get => MGet<Expression>(Compiler.AnnotationArgument_Value);
			set => MAdd<Expression>(Compiler.AnnotationArgument_Value, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_Type, Compiler.AnnotationArgument_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_Type, Compiler.AnnotationArgument_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_Type, Compiler.AnnotationArgument_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Parameter", Compiler.AnnotationArgument_Parameter);
				publicPropertiesByName.Add("Type", Compiler.AnnotationArgument_Type);
				publicPropertiesByName.Add("Value", Compiler.AnnotationArgument_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.AnnotationArgument_Parameter, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_Parameter, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Parameter), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.AnnotationArgument_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_Type, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Type), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.AnnotationArgument_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(AnnotationArgument);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new AnnotationArgument_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.AnnotationArgumentInfo";
			}
		}
	}

	internal class Rule_Impl : __MetaModelObject, Rule
	{
		private Rule_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Rule(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public Grammar Grammar
		{
			get => MGet<Grammar>(Compiler.Rule_Grammar);
			set => MAdd<Grammar>(Compiler.Rule_Grammar, value);
		}
	
		public Language Language
		{
			get => Compiler.__CustomImpl.Rule_Language(this);
		}
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::System.Collections.Generic.IList<Declaration> Declarations
		{
			get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
		}
	
		public string? FullName
		{
			get => Compiler.__CustomImpl.Declaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Compiler.Declaration_Name);
			set => MAdd<string?>(Compiler.Declaration_Name, value);
		}
	
		public Declaration? Parent
		{
			get => MGet<Declaration?>(Compiler.Declaration_Parent);
			set => MAdd<Declaration?>(Compiler.Declaration_Parent, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.DeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.DeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar, Compiler.Rule_Language);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Grammar", Compiler.Rule_Grammar);
				publicPropertiesByName.Add("Language", Compiler.Rule_Language);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Rule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(Rule);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new Rule_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.RuleInfo";
			}
		}
	}

	internal class LexerRule_Impl : __MetaModelObject, LexerRule
	{
		private LexerRule_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.LexerRule_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<LexerRuleAlternative>(this, __Info.Instance.GetSlot(Compiler.LexerRule_Alternatives)!));
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Rule(this);
			Compiler.__CustomImpl.LexerRule(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<LexerRuleAlternative> Alternatives
		{
			get => MGetCollection<LexerRuleAlternative>(Compiler.LexerRule_Alternatives);
		}
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRule_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRule_IsFixed(this);
		}
	
		public bool IsFragment
		{
			get => MGet<bool>(Compiler.LexerRule_IsFragment);
			set => MAdd<bool>(Compiler.LexerRule_IsFragment, value);
		}
	
		public bool IsHidden
		{
			get => MGet<bool>(Compiler.LexerRule_IsHidden);
			set => MAdd<bool>(Compiler.LexerRule_IsHidden, value);
		}
	
		public __MetaType ReturnType
		{
			get => MGet<__MetaType>(Compiler.LexerRule_ReturnType);
			set => MAdd<__MetaType>(Compiler.LexerRule_ReturnType, value);
		}
	
		public Grammar Grammar
		{
			get => MGet<Grammar>(Compiler.Rule_Grammar);
			set => MAdd<Grammar>(Compiler.Rule_Grammar, value);
		}
	
		public Language Language
		{
			get => Compiler.__CustomImpl.Rule_Language(this);
		}
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::System.Collections.Generic.IList<Declaration> Declarations
		{
			get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
		}
	
		public string? FullName
		{
			get => Compiler.__CustomImpl.Declaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Compiler.Declaration_Name);
			set => MAdd<string?>(Compiler.Declaration_Name, value);
		}
	
		public Declaration? Parent
		{
			get => MGet<Declaration?>(Compiler.Declaration_Parent);
			set => MAdd<Declaration?>(Compiler.Declaration_Parent, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.RuleInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.RuleInfo, Compiler.DeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.LexerRule_IsFragment, Compiler.LexerRule_IsHidden, Compiler.LexerRule_ReturnType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.LexerRule_IsFragment, Compiler.LexerRule_IsHidden, Compiler.LexerRule_ReturnType, Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.LexerRule_IsFragment, Compiler.LexerRule_IsHidden, Compiler.LexerRule_ReturnType, Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Compiler.LexerRule_Alternatives);
				publicPropertiesByName.Add("FixedText", Compiler.LexerRule_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRule_IsFixed);
				publicPropertiesByName.Add("IsFragment", Compiler.LexerRule_IsFragment);
				publicPropertiesByName.Add("IsHidden", Compiler.LexerRule_IsHidden);
				publicPropertiesByName.Add("ReturnType", Compiler.LexerRule_ReturnType);
				publicPropertiesByName.Add("Grammar", Compiler.Rule_Grammar);
				publicPropertiesByName.Add("Language", Compiler.Rule_Language);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRule_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRule_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRule_IsFragment, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_IsFragment, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_IsFragment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRule_IsHidden, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_IsHidden, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_IsHidden), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRule_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRule);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRule_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleInfo";
			}
		}
	}

	internal class LexerRuleAlternative_Impl : __MetaModelObject, LexerRuleAlternative
	{
		private LexerRuleAlternative_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.LexerRuleAlternative_Elements, new global::MetaDslx.Modeling.ModelObjectList<LexerRuleElement>(this, __Info.Instance.GetSlot(Compiler.LexerRuleAlternative_Elements)!));
			Compiler.__CustomImpl.LexerRuleAlternative(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<LexerRuleElement> Elements
		{
			get => MGetCollection<LexerRuleElement>(Compiler.LexerRuleAlternative_Elements);
		}
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleAlternative_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleAlternative_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleAlternative_Elements, Compiler.LexerRuleAlternative_FixedText, Compiler.LexerRuleAlternative_IsFixed);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleAlternative_Elements, Compiler.LexerRuleAlternative_FixedText, Compiler.LexerRuleAlternative_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleAlternative_Elements, Compiler.LexerRuleAlternative_FixedText, Compiler.LexerRuleAlternative_IsFixed);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Elements", Compiler.LexerRuleAlternative_Elements);
				publicPropertiesByName.Add("FixedText", Compiler.LexerRuleAlternative_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRuleAlternative_IsFixed);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRuleAlternative_Elements, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleAlternative_Elements, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleAlternative_Elements), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleAlternative_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleAlternative_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleAlternative_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleAlternative_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleAlternative_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleAlternative_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRuleAlternative);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRuleAlternative_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleAlternativeInfo";
			}
		}
	}

	internal class LexerRuleElement_Impl : __MetaModelObject, LexerRuleElement
	{
		private LexerRuleElement_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LexerRuleElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleElement_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleElement_IsFixed(this);
		}
	
		public bool IsNegated
		{
			get => MGet<bool>(Compiler.LexerRuleElement_IsNegated);
			set => MAdd<bool>(Compiler.LexerRuleElement_IsNegated, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText, Compiler.LexerRuleElement_IsFixed, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText, Compiler.LexerRuleElement_IsFixed, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText, Compiler.LexerRuleElement_IsFixed, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LexerRuleElement_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRuleElement_IsFixed);
				publicPropertiesByName.Add("IsNegated", Compiler.LexerRuleElement_IsNegated);
				publicPropertiesByName.Add("Multiplicity", Compiler.LexerRuleElement_Multiplicity);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRuleElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsNegated, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRuleElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRuleElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleElementInfo";
			}
		}
	}

	internal class LexerRuleReferenceElement_Impl : __MetaModelObject, LexerRuleReferenceElement
	{
		private LexerRuleReferenceElement_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LexerRuleElement(this);
			Compiler.__CustomImpl.LexerRuleReferenceElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleReferenceElement_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleReferenceElement_IsFixed(this);
		}
	
		public LexerRule Rule
		{
			get => MGet<LexerRule>(Compiler.LexerRuleReferenceElement_Rule);
			set => MAdd<LexerRule>(Compiler.LexerRuleReferenceElement_Rule, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LexerRuleElement.FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleReferenceElement_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LexerRuleElement.IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleReferenceElement_IsFixed(this);
		}
	
		public bool IsNegated
		{
			get => MGet<bool>(Compiler.LexerRuleElement_IsNegated);
			set => MAdd<bool>(Compiler.LexerRuleElement_IsNegated, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleReferenceElement_FixedText, Compiler.LexerRuleReferenceElement_IsFixed, Compiler.LexerRuleReferenceElement_Rule);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleReferenceElement_FixedText, Compiler.LexerRuleReferenceElement_IsFixed, Compiler.LexerRuleReferenceElement_Rule, Compiler.LexerRuleElement_FixedText, Compiler.LexerRuleElement_IsFixed, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleReferenceElement_FixedText, Compiler.LexerRuleReferenceElement_IsFixed, Compiler.LexerRuleReferenceElement_Rule, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LexerRuleReferenceElement_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRuleReferenceElement_IsFixed);
				publicPropertiesByName.Add("Rule", Compiler.LexerRuleReferenceElement_Rule);
				publicPropertiesByName.Add("IsNegated", Compiler.LexerRuleElement_IsNegated);
				publicPropertiesByName.Add("Multiplicity", Compiler.LexerRuleElement_Multiplicity);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRuleReferenceElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleReferenceElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleReferenceElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleReferenceElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleReferenceElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleReferenceElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleReferenceElement_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleReferenceElement_Rule, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleReferenceElement_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleReferenceElement_FixedText)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleReferenceElement_IsFixed)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsNegated, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRuleReferenceElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRuleReferenceElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleReferenceElementInfo";
			}
		}
	}

	internal class LexerRuleFixedStringElement_Impl : __MetaModelObject, LexerRuleFixedStringElement
	{
		private LexerRuleFixedStringElement_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LexerRuleElement(this);
			Compiler.__CustomImpl.LexerRuleFixedStringElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleFixedStringElement_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleFixedStringElement_IsFixed(this);
		}
	
		public string Text
		{
			get => MGet<string>(Compiler.LexerRuleFixedStringElement_Text);
			set => MAdd<string>(Compiler.LexerRuleFixedStringElement_Text, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LexerRuleElement.FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleFixedStringElement_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LexerRuleElement.IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleFixedStringElement_IsFixed(this);
		}
	
		public bool IsNegated
		{
			get => MGet<bool>(Compiler.LexerRuleElement_IsNegated);
			set => MAdd<bool>(Compiler.LexerRuleElement_IsNegated, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleFixedStringElement_FixedText, Compiler.LexerRuleFixedStringElement_IsFixed, Compiler.LexerRuleFixedStringElement_Text);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleFixedStringElement_FixedText, Compiler.LexerRuleFixedStringElement_IsFixed, Compiler.LexerRuleFixedStringElement_Text, Compiler.LexerRuleElement_FixedText, Compiler.LexerRuleElement_IsFixed, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleFixedStringElement_FixedText, Compiler.LexerRuleFixedStringElement_IsFixed, Compiler.LexerRuleFixedStringElement_Text, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LexerRuleFixedStringElement_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRuleFixedStringElement_IsFixed);
				publicPropertiesByName.Add("Text", Compiler.LexerRuleFixedStringElement_Text);
				publicPropertiesByName.Add("IsNegated", Compiler.LexerRuleElement_IsNegated);
				publicPropertiesByName.Add("Multiplicity", Compiler.LexerRuleElement_Multiplicity);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRuleFixedStringElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleFixedStringElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleFixedStringElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleFixedStringElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleFixedStringElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleFixedStringElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleFixedStringElement_Text, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleFixedStringElement_Text, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleFixedStringElement_Text), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleFixedStringElement_FixedText)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleFixedStringElement_IsFixed)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsNegated, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRuleFixedStringElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRuleFixedStringElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleFixedStringElementInfo";
			}
		}
	}

	internal class LexerRuleWildCardElement_Impl : __MetaModelObject, LexerRuleWildCardElement
	{
		private LexerRuleWildCardElement_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LexerRuleElement(this);
			Compiler.__CustomImpl.LexerRuleWildCardElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleWildCardElement_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleWildCardElement_IsFixed(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LexerRuleElement.FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleWildCardElement_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LexerRuleElement.IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleWildCardElement_IsFixed(this);
		}
	
		public bool IsNegated
		{
			get => MGet<bool>(Compiler.LexerRuleElement_IsNegated);
			set => MAdd<bool>(Compiler.LexerRuleElement_IsNegated, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleWildCardElement_FixedText, Compiler.LexerRuleWildCardElement_IsFixed);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleWildCardElement_FixedText, Compiler.LexerRuleWildCardElement_IsFixed, Compiler.LexerRuleElement_FixedText, Compiler.LexerRuleElement_IsFixed, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleWildCardElement_FixedText, Compiler.LexerRuleWildCardElement_IsFixed, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LexerRuleWildCardElement_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRuleWildCardElement_IsFixed);
				publicPropertiesByName.Add("IsNegated", Compiler.LexerRuleElement_IsNegated);
				publicPropertiesByName.Add("Multiplicity", Compiler.LexerRuleElement_Multiplicity);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRuleWildCardElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleWildCardElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleWildCardElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleWildCardElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleWildCardElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleWildCardElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleWildCardElement_FixedText)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleWildCardElement_IsFixed)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsNegated, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRuleWildCardElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRuleWildCardElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleWildCardElementInfo";
			}
		}
	}

	internal class LexerRuleRangeElement_Impl : __MetaModelObject, LexerRuleRangeElement
	{
		private LexerRuleRangeElement_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LexerRuleElement(this);
			Compiler.__CustomImpl.LexerRuleRangeElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string EndChar
		{
			get => MGet<string>(Compiler.LexerRuleRangeElement_EndChar);
			set => MAdd<string>(Compiler.LexerRuleRangeElement_EndChar, value);
		}
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleRangeElement_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleRangeElement_IsFixed(this);
		}
	
		public string StartChar
		{
			get => MGet<string>(Compiler.LexerRuleRangeElement_StartChar);
			set => MAdd<string>(Compiler.LexerRuleRangeElement_StartChar, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LexerRuleElement.FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleRangeElement_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LexerRuleElement.IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleRangeElement_IsFixed(this);
		}
	
		public bool IsNegated
		{
			get => MGet<bool>(Compiler.LexerRuleElement_IsNegated);
			set => MAdd<bool>(Compiler.LexerRuleElement_IsNegated, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleRangeElement_EndChar, Compiler.LexerRuleRangeElement_FixedText, Compiler.LexerRuleRangeElement_IsFixed, Compiler.LexerRuleRangeElement_StartChar);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleRangeElement_EndChar, Compiler.LexerRuleRangeElement_FixedText, Compiler.LexerRuleRangeElement_IsFixed, Compiler.LexerRuleRangeElement_StartChar, Compiler.LexerRuleElement_FixedText, Compiler.LexerRuleElement_IsFixed, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleRangeElement_EndChar, Compiler.LexerRuleRangeElement_FixedText, Compiler.LexerRuleRangeElement_IsFixed, Compiler.LexerRuleRangeElement_StartChar, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("EndChar", Compiler.LexerRuleRangeElement_EndChar);
				publicPropertiesByName.Add("FixedText", Compiler.LexerRuleRangeElement_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRuleRangeElement_IsFixed);
				publicPropertiesByName.Add("StartChar", Compiler.LexerRuleRangeElement_StartChar);
				publicPropertiesByName.Add("IsNegated", Compiler.LexerRuleElement_IsNegated);
				publicPropertiesByName.Add("Multiplicity", Compiler.LexerRuleElement_Multiplicity);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRuleRangeElement_EndChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleRangeElement_EndChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleRangeElement_EndChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleRangeElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleRangeElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleRangeElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleRangeElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleRangeElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleRangeElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleRangeElement_StartChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleRangeElement_StartChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleRangeElement_StartChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleRangeElement_FixedText)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleRangeElement_IsFixed)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsNegated, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRuleRangeElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRuleRangeElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleRangeElementInfo";
			}
		}
	}

	internal class LexerRuleSetElement_Impl : __MetaModelObject, LexerRuleSetElement
	{
		private LexerRuleSetElement_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.LexerRuleSetElement_Items, new global::MetaDslx.Modeling.ModelObjectList<LexerRuleSetItem>(this, __Info.Instance.GetSlot(Compiler.LexerRuleSetElement_Items)!));
			Compiler.__CustomImpl.LexerRuleElement(this);
			Compiler.__CustomImpl.LexerRuleSetElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleSetElement_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleSetElement_IsFixed(this);
		}
	
		public global::System.Collections.Generic.IList<LexerRuleSetItem> Items
		{
			get => MGetCollection<LexerRuleSetItem>(Compiler.LexerRuleSetElement_Items);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LexerRuleElement.FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleSetElement_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LexerRuleElement.IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleSetElement_IsFixed(this);
		}
	
		public bool IsNegated
		{
			get => MGet<bool>(Compiler.LexerRuleElement_IsNegated);
			set => MAdd<bool>(Compiler.LexerRuleElement_IsNegated, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetElement_FixedText, Compiler.LexerRuleSetElement_IsFixed, Compiler.LexerRuleSetElement_Items);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetElement_FixedText, Compiler.LexerRuleSetElement_IsFixed, Compiler.LexerRuleSetElement_Items, Compiler.LexerRuleElement_FixedText, Compiler.LexerRuleElement_IsFixed, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetElement_FixedText, Compiler.LexerRuleSetElement_IsFixed, Compiler.LexerRuleSetElement_Items, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LexerRuleSetElement_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRuleSetElement_IsFixed);
				publicPropertiesByName.Add("Items", Compiler.LexerRuleSetElement_Items);
				publicPropertiesByName.Add("IsNegated", Compiler.LexerRuleElement_IsNegated);
				publicPropertiesByName.Add("Multiplicity", Compiler.LexerRuleElement_Multiplicity);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRuleSetElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleSetElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleSetElement_Items, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetElement_Items, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetElement_Items), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetElement_FixedText)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetElement_IsFixed)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsNegated, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRuleSetElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRuleSetElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleSetElementInfo";
			}
		}
	}

	internal class LexerRuleSetItem_Impl : __MetaModelObject, LexerRuleSetItem
	{
		private LexerRuleSetItem_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LexerRuleSetItem(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleSetItem_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleSetItem_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_FixedText, Compiler.LexerRuleSetItem_IsFixed);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_FixedText, Compiler.LexerRuleSetItem_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_FixedText, Compiler.LexerRuleSetItem_IsFixed);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LexerRuleSetItem_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRuleSetItem_IsFixed);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRuleSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRuleSetItem);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRuleSetItem_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleSetItemInfo";
			}
		}
	}

	internal class LexerRuleSetFixedChar_Impl : __MetaModelObject, LexerRuleSetFixedChar
	{
		private LexerRuleSetFixedChar_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LexerRuleSetItem(this);
			Compiler.__CustomImpl.LexerRuleSetFixedChar(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string Char
		{
			get => MGet<string>(Compiler.LexerRuleSetFixedChar_Char);
			set => MAdd<string>(Compiler.LexerRuleSetFixedChar_Char, value);
		}
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleSetFixedChar_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleSetFixedChar_IsFixed(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LexerRuleSetItem.FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleSetFixedChar_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LexerRuleSetItem.IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleSetFixedChar_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleSetItemInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleSetItemInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetFixedChar_Char, Compiler.LexerRuleSetFixedChar_FixedText, Compiler.LexerRuleSetFixedChar_IsFixed);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetFixedChar_Char, Compiler.LexerRuleSetFixedChar_FixedText, Compiler.LexerRuleSetFixedChar_IsFixed, Compiler.LexerRuleSetItem_FixedText, Compiler.LexerRuleSetItem_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetFixedChar_Char, Compiler.LexerRuleSetFixedChar_FixedText, Compiler.LexerRuleSetFixedChar_IsFixed);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Char", Compiler.LexerRuleSetFixedChar_Char);
				publicPropertiesByName.Add("FixedText", Compiler.LexerRuleSetFixedChar_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRuleSetFixedChar_IsFixed);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRuleSetFixedChar_Char, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetFixedChar_Char, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetFixedChar_Char), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleSetFixedChar_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetFixedChar_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetFixedChar_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleSetFixedChar_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetFixedChar_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetFixedChar_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetFixedChar_FixedText)));
				modelPropertyInfos.Add(Compiler.LexerRuleSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetFixedChar_IsFixed)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRuleSetFixedChar);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRuleSetFixedChar_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleSetFixedCharInfo";
			}
		}
	}

	internal class LexerRuleSetRange_Impl : __MetaModelObject, LexerRuleSetRange
	{
		private LexerRuleSetRange_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LexerRuleSetItem(this);
			Compiler.__CustomImpl.LexerRuleSetRange(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string EndChar
		{
			get => MGet<string>(Compiler.LexerRuleSetRange_EndChar);
			set => MAdd<string>(Compiler.LexerRuleSetRange_EndChar, value);
		}
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleSetRange_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleSetRange_IsFixed(this);
		}
	
		public string StartChar
		{
			get => MGet<string>(Compiler.LexerRuleSetRange_StartChar);
			set => MAdd<string>(Compiler.LexerRuleSetRange_StartChar, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LexerRuleSetItem.FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleSetRange_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LexerRuleSetItem.IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleSetRange_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleSetItemInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleSetItemInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetRange_EndChar, Compiler.LexerRuleSetRange_FixedText, Compiler.LexerRuleSetRange_IsFixed, Compiler.LexerRuleSetRange_StartChar);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetRange_EndChar, Compiler.LexerRuleSetRange_FixedText, Compiler.LexerRuleSetRange_IsFixed, Compiler.LexerRuleSetRange_StartChar, Compiler.LexerRuleSetItem_FixedText, Compiler.LexerRuleSetItem_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetRange_EndChar, Compiler.LexerRuleSetRange_FixedText, Compiler.LexerRuleSetRange_IsFixed, Compiler.LexerRuleSetRange_StartChar);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("EndChar", Compiler.LexerRuleSetRange_EndChar);
				publicPropertiesByName.Add("FixedText", Compiler.LexerRuleSetRange_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRuleSetRange_IsFixed);
				publicPropertiesByName.Add("StartChar", Compiler.LexerRuleSetRange_StartChar);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRuleSetRange_EndChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetRange_EndChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetRange_EndChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleSetRange_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetRange_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetRange_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleSetRange_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetRange_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetRange_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleSetRange_StartChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetRange_StartChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetRange_StartChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetRange_FixedText)));
				modelPropertyInfos.Add(Compiler.LexerRuleSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleSetRange_IsFixed)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRuleSetRange);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRuleSetRange_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleSetRangeInfo";
			}
		}
	}

	internal class LexerRuleBlockElement_Impl : __MetaModelObject, LexerRuleBlockElement
	{
		private LexerRuleBlockElement_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.LexerRuleBlockElement_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<LexerRuleAlternative>(this, __Info.Instance.GetSlot(Compiler.LexerRuleBlockElement_Alternatives)!));
			Compiler.__CustomImpl.LexerRuleElement(this);
			Compiler.__CustomImpl.LexerRuleBlockElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<LexerRuleAlternative> Alternatives
		{
			get => MGetCollection<LexerRuleAlternative>(Compiler.LexerRuleBlockElement_Alternatives);
		}
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleBlockElement_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleBlockElement_IsFixed(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LexerRuleElement.FixedText
		{
			get => Compiler.__CustomImpl.LexerRuleBlockElement_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LexerRuleElement.IsFixed
		{
			get => Compiler.__CustomImpl.LexerRuleBlockElement_IsFixed(this);
		}
	
		public bool IsNegated
		{
			get => MGet<bool>(Compiler.LexerRuleElement_IsNegated);
			set => MAdd<bool>(Compiler.LexerRuleElement_IsNegated, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LexerRuleElement_Multiplicity, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LexerRuleElementInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleBlockElement_Alternatives, Compiler.LexerRuleBlockElement_FixedText, Compiler.LexerRuleBlockElement_IsFixed);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleBlockElement_Alternatives, Compiler.LexerRuleBlockElement_FixedText, Compiler.LexerRuleBlockElement_IsFixed, Compiler.LexerRuleElement_FixedText, Compiler.LexerRuleElement_IsFixed, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleBlockElement_Alternatives, Compiler.LexerRuleBlockElement_FixedText, Compiler.LexerRuleBlockElement_IsFixed, Compiler.LexerRuleElement_IsNegated, Compiler.LexerRuleElement_Multiplicity);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Compiler.LexerRuleBlockElement_Alternatives);
				publicPropertiesByName.Add("FixedText", Compiler.LexerRuleBlockElement_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LexerRuleBlockElement_IsFixed);
				publicPropertiesByName.Add("IsNegated", Compiler.LexerRuleElement_IsNegated);
				publicPropertiesByName.Add("Multiplicity", Compiler.LexerRuleElement_Multiplicity);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRuleBlockElement_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleBlockElement_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleBlockElement_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleBlockElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleBlockElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleBlockElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleBlockElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleBlockElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleBlockElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleBlockElement_FixedText)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleBlockElement_IsFixed)));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_IsNegated, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LexerRuleBlockElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new LexerRuleBlockElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LexerRuleBlockElementInfo";
			}
		}
	}

	internal class ParserRule_Impl : __MetaModelObject, ParserRule
	{
		private ParserRule_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.ParserRule_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<ParserRuleAlternative>(this, __Info.Instance.GetSlot(Compiler.ParserRule_Alternatives)!));
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Rule(this);
			Compiler.__CustomImpl.ParserRule(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<ParserRuleAlternative> Alternatives
		{
			get => MGetCollection<ParserRuleAlternative>(Compiler.ParserRule_Alternatives);
		}
	
		public bool IsBlock
		{
			get => MGet<bool>(Compiler.ParserRule_IsBlock);
			set => MAdd<bool>(Compiler.ParserRule_IsBlock, value);
		}
	
		public __MetaType? ReturnType
		{
			get => MGet<__MetaType?>(Compiler.ParserRule_ReturnType);
			set => MAdd<__MetaType?>(Compiler.ParserRule_ReturnType, value);
		}
	
		public Grammar Grammar
		{
			get => MGet<Grammar>(Compiler.Rule_Grammar);
			set => MAdd<Grammar>(Compiler.Rule_Grammar, value);
		}
	
		public Language Language
		{
			get => Compiler.__CustomImpl.Rule_Language(this);
		}
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::System.Collections.Generic.IList<Declaration> Declarations
		{
			get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
		}
	
		public string? FullName
		{
			get => Compiler.__CustomImpl.Declaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Compiler.Declaration_Name);
			set => MAdd<string?>(Compiler.Declaration_Name, value);
		}
	
		public Declaration? Parent
		{
			get => MGet<Declaration?>(Compiler.Declaration_Parent);
			set => MAdd<Declaration?>(Compiler.Declaration_Parent, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.RuleInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.RuleInfo, Compiler.DeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRule_Alternatives, Compiler.ParserRule_IsBlock, Compiler.ParserRule_ReturnType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRule_Alternatives, Compiler.ParserRule_IsBlock, Compiler.ParserRule_ReturnType, Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRule_Alternatives, Compiler.ParserRule_IsBlock, Compiler.ParserRule_ReturnType, Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Compiler.ParserRule_Alternatives);
				publicPropertiesByName.Add("IsBlock", Compiler.ParserRule_IsBlock);
				publicPropertiesByName.Add("ReturnType", Compiler.ParserRule_ReturnType);
				publicPropertiesByName.Add("Grammar", Compiler.Rule_Grammar);
				publicPropertiesByName.Add("Language", Compiler.Rule_Language);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ParserRule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRule_IsBlock, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRule_IsBlock, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRule_IsBlock), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRule_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRule_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRule_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(ParserRule);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new ParserRule_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ParserRuleInfo";
			}
		}
	}

	internal class ParserRuleAlternative_Impl : __MetaModelObject, ParserRuleAlternative
	{
		private ParserRuleAlternative_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.ParserRuleAlternative_Elements, new global::MetaDslx.Modeling.ModelObjectList<ParserRuleElement>(this, __Info.Instance.GetSlot(Compiler.ParserRuleAlternative_Elements)!));
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.ParserRuleAlternative(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<ParserRuleElement> Elements
		{
			get => MGetCollection<ParserRuleElement>(Compiler.ParserRuleAlternative_Elements);
		}
	
		public __MetaType? ReturnType
		{
			get => MGet<__MetaType?>(Compiler.ParserRuleAlternative_ReturnType);
			set => MAdd<__MetaType?>(Compiler.ParserRuleAlternative_ReturnType, value);
		}
	
		public Expression ReturnValue
		{
			get => MGet<Expression>(Compiler.ParserRuleAlternative_ReturnValue);
			set => MAdd<Expression>(Compiler.ParserRuleAlternative_ReturnValue, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::System.Collections.Generic.IList<Declaration> Declarations
		{
			get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
		}
	
		public string? FullName
		{
			get => Compiler.__CustomImpl.Declaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Compiler.Declaration_Name);
			set => MAdd<string?>(Compiler.Declaration_Name, value);
		}
	
		public Declaration? Parent
		{
			get => MGet<Declaration?>(Compiler.Declaration_Parent);
			set => MAdd<Declaration?>(Compiler.Declaration_Parent, value);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.DeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.DeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleAlternative_Elements, Compiler.ParserRuleAlternative_ReturnType, Compiler.ParserRuleAlternative_ReturnValue);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleAlternative_Elements, Compiler.ParserRuleAlternative_ReturnType, Compiler.ParserRuleAlternative_ReturnValue, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleAlternative_Elements, Compiler.ParserRuleAlternative_ReturnType, Compiler.ParserRuleAlternative_ReturnValue, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Elements", Compiler.ParserRuleAlternative_Elements);
				publicPropertiesByName.Add("ReturnType", Compiler.ParserRuleAlternative_ReturnType);
				publicPropertiesByName.Add("ReturnValue", Compiler.ParserRuleAlternative_ReturnValue);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ParserRuleAlternative_Elements, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleAlternative_Elements, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleAlternative_Elements), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleAlternative_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleAlternative_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleAlternative_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleAlternative_ReturnValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleAlternative_ReturnValue, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleAlternative_ReturnValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Parent, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(ParserRuleAlternative);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new ParserRuleAlternative_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ParserRuleAlternativeInfo";
			}
		}
	}

	internal class ParserRuleElement_Impl : __MetaModelObject, ParserRuleElement
	{
		private ParserRuleElement_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.ParserRuleElement_NameAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.ParserRuleElement_NameAnnotations)!));
			((__IModelObject)this).Init(Compiler.ParserRuleElement_ValueAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.ParserRuleElement_ValueAnnotations)!));
			Compiler.__CustomImpl.ParserRuleElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator AssignmentOperator
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator>(Compiler.ParserRuleElement_AssignmentOperator);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator>(Compiler.ParserRuleElement_AssignmentOperator, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ParserRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ParserRuleElement_Multiplicity, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> NameAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.ParserRuleElement_NameAnnotations);
		}
	
		public __MetaSymbol? Property
		{
			get => MGet<__MetaSymbol?>(Compiler.ParserRuleElement_Property);
			set => MAdd<__MetaSymbol?>(Compiler.ParserRuleElement_Property, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> ValueAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.ParserRuleElement_ValueAnnotations);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_AssignmentOperator, Compiler.ParserRuleElement_Multiplicity, Compiler.ParserRuleElement_NameAnnotations, Compiler.ParserRuleElement_Property, Compiler.ParserRuleElement_ValueAnnotations);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_AssignmentOperator, Compiler.ParserRuleElement_Multiplicity, Compiler.ParserRuleElement_NameAnnotations, Compiler.ParserRuleElement_Property, Compiler.ParserRuleElement_ValueAnnotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_AssignmentOperator, Compiler.ParserRuleElement_Multiplicity, Compiler.ParserRuleElement_NameAnnotations, Compiler.ParserRuleElement_Property, Compiler.ParserRuleElement_ValueAnnotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("AssignmentOperator", Compiler.ParserRuleElement_AssignmentOperator);
				publicPropertiesByName.Add("Multiplicity", Compiler.ParserRuleElement_Multiplicity);
				publicPropertiesByName.Add("NameAnnotations", Compiler.ParserRuleElement_NameAnnotations);
				publicPropertiesByName.Add("Property", Compiler.ParserRuleElement_Property);
				publicPropertiesByName.Add("ValueAnnotations", Compiler.ParserRuleElement_ValueAnnotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ParserRuleElement_AssignmentOperator, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_AssignmentOperator, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_AssignmentOperator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_NameAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_NameAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_NameAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_Property, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_Property, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_Property), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_ValueAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_ValueAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_ValueAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(ParserRuleElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new ParserRuleElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ParserRuleElementInfo";
			}
		}
	}

	internal class ParserRuleReferenceElement_Impl : __MetaModelObject, ParserRuleReferenceElement
	{
		private ParserRuleReferenceElement_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.ParserRuleReferenceElement_ReferencedTypes, new global::MetaDslx.Modeling.ModelObjectList<__MetaType>(this, __Info.Instance.GetSlot(Compiler.ParserRuleReferenceElement_ReferencedTypes)!));
			((__IModelObject)this).Init(Compiler.ParserRuleElement_NameAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.ParserRuleElement_NameAnnotations)!));
			((__IModelObject)this).Init(Compiler.ParserRuleElement_ValueAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.ParserRuleElement_ValueAnnotations)!));
			Compiler.__CustomImpl.ParserRuleElement(this);
			Compiler.__CustomImpl.ParserRuleReferenceElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<__MetaType> ReferencedTypes
		{
			get => MGetCollection<__MetaType>(Compiler.ParserRuleReferenceElement_ReferencedTypes);
		}
	
		public Rule Rule
		{
			get => MGet<Rule>(Compiler.ParserRuleReferenceElement_Rule);
			set => MAdd<Rule>(Compiler.ParserRuleReferenceElement_Rule, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator AssignmentOperator
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator>(Compiler.ParserRuleElement_AssignmentOperator);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator>(Compiler.ParserRuleElement_AssignmentOperator, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ParserRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ParserRuleElement_Multiplicity, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> NameAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.ParserRuleElement_NameAnnotations);
		}
	
		public __MetaSymbol? Property
		{
			get => MGet<__MetaSymbol?>(Compiler.ParserRuleElement_Property);
			set => MAdd<__MetaSymbol?>(Compiler.ParserRuleElement_Property, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> ValueAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.ParserRuleElement_ValueAnnotations);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.ParserRuleElementInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.ParserRuleElementInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleReferenceElement_ReferencedTypes, Compiler.ParserRuleReferenceElement_Rule);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleReferenceElement_ReferencedTypes, Compiler.ParserRuleReferenceElement_Rule, Compiler.ParserRuleElement_AssignmentOperator, Compiler.ParserRuleElement_Multiplicity, Compiler.ParserRuleElement_NameAnnotations, Compiler.ParserRuleElement_Property, Compiler.ParserRuleElement_ValueAnnotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleReferenceElement_ReferencedTypes, Compiler.ParserRuleReferenceElement_Rule, Compiler.ParserRuleElement_AssignmentOperator, Compiler.ParserRuleElement_Multiplicity, Compiler.ParserRuleElement_NameAnnotations, Compiler.ParserRuleElement_Property, Compiler.ParserRuleElement_ValueAnnotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("ReferencedTypes", Compiler.ParserRuleReferenceElement_ReferencedTypes);
				publicPropertiesByName.Add("Rule", Compiler.ParserRuleReferenceElement_Rule);
				publicPropertiesByName.Add("AssignmentOperator", Compiler.ParserRuleElement_AssignmentOperator);
				publicPropertiesByName.Add("Multiplicity", Compiler.ParserRuleElement_Multiplicity);
				publicPropertiesByName.Add("NameAnnotations", Compiler.ParserRuleElement_NameAnnotations);
				publicPropertiesByName.Add("Property", Compiler.ParserRuleElement_Property);
				publicPropertiesByName.Add("ValueAnnotations", Compiler.ParserRuleElement_ValueAnnotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ParserRuleReferenceElement_ReferencedTypes, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleReferenceElement_ReferencedTypes, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleReferenceElement_ReferencedTypes), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleReferenceElement_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleReferenceElement_Rule, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleReferenceElement_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_AssignmentOperator, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_AssignmentOperator, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_AssignmentOperator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_NameAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_NameAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_NameAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_Property, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_Property, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_Property), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_ValueAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_ValueAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_ValueAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(ParserRuleReferenceElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new ParserRuleReferenceElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ParserRuleReferenceElementInfo";
			}
		}
	}

	internal class ParserRuleEofElement_Impl : __MetaModelObject, ParserRuleEofElement
	{
		private ParserRuleEofElement_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.ParserRuleElement_NameAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.ParserRuleElement_NameAnnotations)!));
			((__IModelObject)this).Init(Compiler.ParserRuleElement_ValueAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.ParserRuleElement_ValueAnnotations)!));
			Compiler.__CustomImpl.ParserRuleElement(this);
			Compiler.__CustomImpl.ParserRuleEofElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator AssignmentOperator
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator>(Compiler.ParserRuleElement_AssignmentOperator);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator>(Compiler.ParserRuleElement_AssignmentOperator, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ParserRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ParserRuleElement_Multiplicity, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> NameAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.ParserRuleElement_NameAnnotations);
		}
	
		public __MetaSymbol? Property
		{
			get => MGet<__MetaSymbol?>(Compiler.ParserRuleElement_Property);
			set => MAdd<__MetaSymbol?>(Compiler.ParserRuleElement_Property, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> ValueAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.ParserRuleElement_ValueAnnotations);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.ParserRuleElementInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.ParserRuleElementInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_AssignmentOperator, Compiler.ParserRuleElement_Multiplicity, Compiler.ParserRuleElement_NameAnnotations, Compiler.ParserRuleElement_Property, Compiler.ParserRuleElement_ValueAnnotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_AssignmentOperator, Compiler.ParserRuleElement_Multiplicity, Compiler.ParserRuleElement_NameAnnotations, Compiler.ParserRuleElement_Property, Compiler.ParserRuleElement_ValueAnnotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("AssignmentOperator", Compiler.ParserRuleElement_AssignmentOperator);
				publicPropertiesByName.Add("Multiplicity", Compiler.ParserRuleElement_Multiplicity);
				publicPropertiesByName.Add("NameAnnotations", Compiler.ParserRuleElement_NameAnnotations);
				publicPropertiesByName.Add("Property", Compiler.ParserRuleElement_Property);
				publicPropertiesByName.Add("ValueAnnotations", Compiler.ParserRuleElement_ValueAnnotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ParserRuleElement_AssignmentOperator, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_AssignmentOperator, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_AssignmentOperator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_NameAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_NameAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_NameAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_Property, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_Property, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_Property), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_ValueAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_ValueAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_ValueAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(ParserRuleEofElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new ParserRuleEofElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ParserRuleEofElementInfo";
			}
		}
	}

	internal class ParserRuleFixedStringElement_Impl : __MetaModelObject, ParserRuleFixedStringElement
	{
		private ParserRuleFixedStringElement_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.ParserRuleElement_NameAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.ParserRuleElement_NameAnnotations)!));
			((__IModelObject)this).Init(Compiler.ParserRuleElement_ValueAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.ParserRuleElement_ValueAnnotations)!));
			Compiler.__CustomImpl.ParserRuleElement(this);
			Compiler.__CustomImpl.ParserRuleFixedStringElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string Text
		{
			get => MGet<string>(Compiler.ParserRuleFixedStringElement_Text);
			set => MAdd<string>(Compiler.ParserRuleFixedStringElement_Text, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator AssignmentOperator
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator>(Compiler.ParserRuleElement_AssignmentOperator);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator>(Compiler.ParserRuleElement_AssignmentOperator, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ParserRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ParserRuleElement_Multiplicity, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> NameAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.ParserRuleElement_NameAnnotations);
		}
	
		public __MetaSymbol? Property
		{
			get => MGet<__MetaSymbol?>(Compiler.ParserRuleElement_Property);
			set => MAdd<__MetaSymbol?>(Compiler.ParserRuleElement_Property, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> ValueAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.ParserRuleElement_ValueAnnotations);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.ParserRuleElementInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.ParserRuleElementInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleFixedStringElement_Text);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleFixedStringElement_Text, Compiler.ParserRuleElement_AssignmentOperator, Compiler.ParserRuleElement_Multiplicity, Compiler.ParserRuleElement_NameAnnotations, Compiler.ParserRuleElement_Property, Compiler.ParserRuleElement_ValueAnnotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleFixedStringElement_Text, Compiler.ParserRuleElement_AssignmentOperator, Compiler.ParserRuleElement_Multiplicity, Compiler.ParserRuleElement_NameAnnotations, Compiler.ParserRuleElement_Property, Compiler.ParserRuleElement_ValueAnnotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Text", Compiler.ParserRuleFixedStringElement_Text);
				publicPropertiesByName.Add("AssignmentOperator", Compiler.ParserRuleElement_AssignmentOperator);
				publicPropertiesByName.Add("Multiplicity", Compiler.ParserRuleElement_Multiplicity);
				publicPropertiesByName.Add("NameAnnotations", Compiler.ParserRuleElement_NameAnnotations);
				publicPropertiesByName.Add("Property", Compiler.ParserRuleElement_Property);
				publicPropertiesByName.Add("ValueAnnotations", Compiler.ParserRuleElement_ValueAnnotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ParserRuleFixedStringElement_Text, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleFixedStringElement_Text, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleFixedStringElement_Text), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_AssignmentOperator, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_AssignmentOperator, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_AssignmentOperator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_NameAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_NameAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_NameAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_Property, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_Property, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_Property), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_ValueAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_ValueAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_ValueAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(ParserRuleFixedStringElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new ParserRuleFixedStringElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ParserRuleFixedStringElementInfo";
			}
		}
	}

	internal class ParserRuleBlockElement_Impl : __MetaModelObject, ParserRuleBlockElement
	{
		private ParserRuleBlockElement_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.ParserRuleBlockElement_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<ParserRuleAlternative>(this, __Info.Instance.GetSlot(Compiler.ParserRuleBlockElement_Alternatives)!));
			((__IModelObject)this).Init(Compiler.ParserRuleElement_NameAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.ParserRuleElement_NameAnnotations)!));
			((__IModelObject)this).Init(Compiler.ParserRuleElement_ValueAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.ParserRuleElement_ValueAnnotations)!));
			Compiler.__CustomImpl.ParserRuleElement(this);
			Compiler.__CustomImpl.ParserRuleBlockElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<ParserRuleAlternative> Alternatives
		{
			get => MGetCollection<ParserRuleAlternative>(Compiler.ParserRuleBlockElement_Alternatives);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator AssignmentOperator
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator>(Compiler.ParserRuleElement_AssignmentOperator);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.AssignmentOperator>(Compiler.ParserRuleElement_AssignmentOperator, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ParserRuleElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ParserRuleElement_Multiplicity, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> NameAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.ParserRuleElement_NameAnnotations);
		}
	
		public __MetaSymbol? Property
		{
			get => MGet<__MetaSymbol?>(Compiler.ParserRuleElement_Property);
			set => MAdd<__MetaSymbol?>(Compiler.ParserRuleElement_Property, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> ValueAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.ParserRuleElement_ValueAnnotations);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.ParserRuleElementInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.ParserRuleElementInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleBlockElement_Alternatives);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleBlockElement_Alternatives, Compiler.ParserRuleElement_AssignmentOperator, Compiler.ParserRuleElement_Multiplicity, Compiler.ParserRuleElement_NameAnnotations, Compiler.ParserRuleElement_Property, Compiler.ParserRuleElement_ValueAnnotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleBlockElement_Alternatives, Compiler.ParserRuleElement_AssignmentOperator, Compiler.ParserRuleElement_Multiplicity, Compiler.ParserRuleElement_NameAnnotations, Compiler.ParserRuleElement_Property, Compiler.ParserRuleElement_ValueAnnotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Compiler.ParserRuleBlockElement_Alternatives);
				publicPropertiesByName.Add("AssignmentOperator", Compiler.ParserRuleElement_AssignmentOperator);
				publicPropertiesByName.Add("Multiplicity", Compiler.ParserRuleElement_Multiplicity);
				publicPropertiesByName.Add("NameAnnotations", Compiler.ParserRuleElement_NameAnnotations);
				publicPropertiesByName.Add("Property", Compiler.ParserRuleElement_Property);
				publicPropertiesByName.Add("ValueAnnotations", Compiler.ParserRuleElement_ValueAnnotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ParserRuleBlockElement_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleBlockElement_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleBlockElement_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_AssignmentOperator, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_AssignmentOperator, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_AssignmentOperator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_NameAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_NameAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_NameAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_Property, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_Property, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_Property), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRuleElement_ValueAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRuleElement_ValueAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRuleElement_ValueAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(ParserRuleBlockElement);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new ParserRuleBlockElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ParserRuleBlockElementInfo";
			}
		}
	}

	internal class Expression_Impl : __MetaModelObject, Expression
	{
		private Expression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Expression(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public object? Value
		{
			get => Compiler.__CustomImpl.Expression_Value(this);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Value", Compiler.Expression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Expression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Expression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(Expression);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new Expression_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ExpressionInfo";
			}
		}
	}

	internal class NullExpression_Impl : __MetaModelObject, NullExpression
	{
		private NullExpression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.NullExpression(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public object? Value
		{
			get => Compiler.__CustomImpl.NullExpression_Value(this);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.NullExpression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.NullExpression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.NullExpression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Value", Compiler.NullExpression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.NullExpression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.NullExpression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.NullExpression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(NullExpression);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new NullExpression_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.NullExpressionInfo";
			}
		}
	}

	internal class BoolExpression_Impl : __MetaModelObject, BoolExpression
	{
		private BoolExpression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.BoolExpression(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public bool BoolValue
		{
			get => MGet<bool>(Compiler.BoolExpression_BoolValue);
			set => MAdd<bool>(Compiler.BoolExpression_BoolValue, value);
		}
	
		public object? Value
		{
			get => Compiler.__CustomImpl.BoolExpression_Value(this);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.BoolExpression_BoolValue, Compiler.BoolExpression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.BoolExpression_BoolValue, Compiler.BoolExpression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.BoolExpression_BoolValue, Compiler.BoolExpression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("BoolValue", Compiler.BoolExpression_BoolValue);
				publicPropertiesByName.Add("Value", Compiler.BoolExpression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.BoolExpression_BoolValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.BoolExpression_BoolValue, __ImmutableArray.Create<__ModelProperty>(Compiler.BoolExpression_BoolValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.BoolExpression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.BoolExpression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.BoolExpression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(BoolExpression);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new BoolExpression_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.BoolExpressionInfo";
			}
		}
	}

	internal class IntExpression_Impl : __MetaModelObject, IntExpression
	{
		private IntExpression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.IntExpression(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public int IntValue
		{
			get => MGet<int>(Compiler.IntExpression_IntValue);
			set => MAdd<int>(Compiler.IntExpression_IntValue, value);
		}
	
		public object? Value
		{
			get => Compiler.__CustomImpl.IntExpression_Value(this);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.IntExpression_IntValue, Compiler.IntExpression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.IntExpression_IntValue, Compiler.IntExpression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.IntExpression_IntValue, Compiler.IntExpression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("IntValue", Compiler.IntExpression_IntValue);
				publicPropertiesByName.Add("Value", Compiler.IntExpression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.IntExpression_IntValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.IntExpression_IntValue, __ImmutableArray.Create<__ModelProperty>(Compiler.IntExpression_IntValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.IntExpression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.IntExpression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.IntExpression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(IntExpression);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new IntExpression_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.IntExpressionInfo";
			}
		}
	}

	internal class StringExpression_Impl : __MetaModelObject, StringExpression
	{
		private StringExpression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.StringExpression(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string StringValue
		{
			get => MGet<string>(Compiler.StringExpression_StringValue);
			set => MAdd<string>(Compiler.StringExpression_StringValue, value);
		}
	
		public object? Value
		{
			get => Compiler.__CustomImpl.StringExpression_Value(this);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.StringExpression_StringValue, Compiler.StringExpression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.StringExpression_StringValue, Compiler.StringExpression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.StringExpression_StringValue, Compiler.StringExpression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("StringValue", Compiler.StringExpression_StringValue);
				publicPropertiesByName.Add("Value", Compiler.StringExpression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.StringExpression_StringValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.StringExpression_StringValue, __ImmutableArray.Create<__ModelProperty>(Compiler.StringExpression_StringValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.StringExpression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.StringExpression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.StringExpression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(StringExpression);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new StringExpression_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.StringExpressionInfo";
			}
		}
	}

	internal class ReferenceExpression_Impl : __MetaModelObject, ReferenceExpression
	{
		private ReferenceExpression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.ReferenceExpression(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public __MetaSymbol SymbolValue
		{
			get => MGet<__MetaSymbol>(Compiler.ReferenceExpression_SymbolValue);
			set => MAdd<__MetaSymbol>(Compiler.ReferenceExpression_SymbolValue, value);
		}
	
		public object? Value
		{
			get => Compiler.__CustomImpl.ReferenceExpression_Value(this);
		}
	
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _allBaseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
	
			private __Info() 
			{
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ReferenceExpression_SymbolValue, Compiler.ReferenceExpression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ReferenceExpression_SymbolValue, Compiler.ReferenceExpression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ReferenceExpression_SymbolValue, Compiler.ReferenceExpression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("SymbolValue", Compiler.ReferenceExpression_SymbolValue);
				publicPropertiesByName.Add("Value", Compiler.ReferenceExpression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ReferenceExpression_SymbolValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ReferenceExpression_SymbolValue, __ImmutableArray.Create<__ModelProperty>(Compiler.ReferenceExpression_SymbolValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ReferenceExpression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ReferenceExpression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.ReferenceExpression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(ReferenceExpression);
	
	        public override __Type? SymbolType => null;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> AllBaseTypes => _allBaseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new ReferenceExpression_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ReferenceExpressionInfo";
			}
		}
	}

}
