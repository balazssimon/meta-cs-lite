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
		public static Compiler MInstance => _instance;
	
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
		private static readonly __ModelProperty _AnnotationArgument_NamedParameter;
		private static readonly __ModelProperty _AnnotationArgument_Value;
		private static readonly __ModelProperty _Rule_Language;
		private static readonly __ModelProperty _Rule_Grammar;
		private static readonly __ModelProperty _LexerRule_ReturnType;
		private static readonly __ModelProperty _LexerRule_IsHidden;
		private static readonly __ModelProperty _LexerRule_IsFragment;
		private static readonly __ModelProperty _LexerRule_IsFixed;
		private static readonly __ModelProperty _LexerRule_FixedText;
		private static readonly __ModelProperty _LexerRule_Alternatives;
		private static readonly __ModelProperty _LAlternative_IsFixed;
		private static readonly __ModelProperty _LAlternative_FixedText;
		private static readonly __ModelProperty _LAlternative_Elements;
		private static readonly __ModelProperty _LElement_IsFixed;
		private static readonly __ModelProperty _LElement_FixedText;
		private static readonly __ModelProperty _LElement_IsNegated;
		private static readonly __ModelProperty _LElement_Value;
		private static readonly __ModelProperty _LElement_Multiplicity;
		private static readonly __ModelProperty _LElementValue_IsFixed;
		private static readonly __ModelProperty _LElementValue_FixedText;
		private static readonly __ModelProperty _LReference_IsFixed;
		private static readonly __ModelProperty _LReference_FixedText;
		private static readonly __ModelProperty _LReference_Rule;
		private static readonly __ModelProperty _LFixed_IsFixed;
		private static readonly __ModelProperty _LFixed_FixedText;
		private static readonly __ModelProperty _LFixed_Text;
		private static readonly __ModelProperty _LWildCard_IsFixed;
		private static readonly __ModelProperty _LWildCard_FixedText;
		private static readonly __ModelProperty _LRange_IsFixed;
		private static readonly __ModelProperty _LRange_FixedText;
		private static readonly __ModelProperty _LRange_StartChar;
		private static readonly __ModelProperty _LRange_EndChar;
		private static readonly __ModelProperty _LSet_IsFixed;
		private static readonly __ModelProperty _LSet_FixedText;
		private static readonly __ModelProperty _LSet_Items;
		private static readonly __ModelProperty _LSetItem_IsFixed;
		private static readonly __ModelProperty _LSetItem_FixedText;
		private static readonly __ModelProperty _LSetChar_IsFixed;
		private static readonly __ModelProperty _LSetChar_FixedText;
		private static readonly __ModelProperty _LSetChar_Char;
		private static readonly __ModelProperty _LSetRange_IsFixed;
		private static readonly __ModelProperty _LSetRange_FixedText;
		private static readonly __ModelProperty _LSetRange_StartChar;
		private static readonly __ModelProperty _LSetRange_EndChar;
		private static readonly __ModelProperty _LBlock_IsFixed;
		private static readonly __ModelProperty _LBlock_FixedText;
		private static readonly __ModelProperty _LBlock_Alternatives;
		private static readonly __ModelProperty _ParserRule_ReturnType;
		private static readonly __ModelProperty _ParserRule_IsBlock;
		private static readonly __ModelProperty _ParserRule_Alternatives;
		private static readonly __ModelProperty _PAlternative_ReturnType;
		private static readonly __ModelProperty _PAlternative_ReturnValue;
		private static readonly __ModelProperty _PAlternative_Elements;
		private static readonly __ModelProperty _PElement_NameAnnotations;
		private static readonly __ModelProperty _PElement_SymbolProperty;
		private static readonly __ModelProperty _PElement_Assignment;
		private static readonly __ModelProperty _PElement_ValueAnnotations;
		private static readonly __ModelProperty _PElement_Value;
		private static readonly __ModelProperty _PElement_Multiplicity;
		private static readonly __ModelProperty _PReference_Rule;
		private static readonly __ModelProperty _PReference_ReferencedTypes;
		private static readonly __ModelProperty _PKeyword_Text;
		private static readonly __ModelProperty _PBlock_Alternatives;
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
		private static readonly __ModelProperty _ArrayExpression_Value;
		private static readonly __ModelProperty _ArrayExpression_Items;
	
		static Compiler()
		{
			_Annotation_Arguments = new __ModelProperty(typeof(Annotation), "Arguments", typeof(AnnotationArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Arguments");
			_Annotation_Type = new __ModelProperty(typeof(Annotation), "Type", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.Type, "Type");
			_AnnotationArgument_NamedParameter = new __ModelProperty(typeof(AnnotationArgument), "NamedParameter", typeof(__MetaSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, "NamedParameter");
			_AnnotationArgument_Value = new __ModelProperty(typeof(AnnotationArgument), "Value", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, "Value");
			_ArrayExpression_Items = new __ModelProperty(typeof(ArrayExpression), "Items", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_ArrayExpression_Value = new __ModelProperty(typeof(ArrayExpression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_BoolExpression_BoolValue = new __ModelProperty(typeof(BoolExpression), "BoolValue", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_BoolExpression_Value = new __ModelProperty(typeof(BoolExpression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Declaration_Annotations = new __ModelProperty(typeof(Declaration), "Annotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Declaration_Declarations = new __ModelProperty(typeof(Declaration), "Declarations", typeof(Declaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Declaration_FullName = new __ModelProperty(typeof(Declaration), "FullName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Declaration_Name = new __ModelProperty(typeof(Declaration), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.Name, "Name");
			_Declaration_Parent = new __ModelProperty(typeof(Declaration), "Parent", typeof(Declaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Expression_Value = new __ModelProperty(typeof(Expression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Grammar_Language = new __ModelProperty(typeof(Grammar), "Language", typeof(Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Grammar_Rules = new __ModelProperty(typeof(Grammar), "Rules", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_IntExpression_IntValue = new __ModelProperty(typeof(IntExpression), "IntValue", typeof(int), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_IntExpression_Value = new __ModelProperty(typeof(IntExpression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LAlternative_Elements = new __ModelProperty(typeof(LAlternative), "Elements", typeof(LElement), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LAlternative_FixedText = new __ModelProperty(typeof(LAlternative), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LAlternative_IsFixed = new __ModelProperty(typeof(LAlternative), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Language_Grammar = new __ModelProperty(typeof(Language), "Grammar", typeof(Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_LElementValue_FixedText = new __ModelProperty(typeof(LElementValue), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElementValue_IsFixed = new __ModelProperty(typeof(LElementValue), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LBlock_Alternatives = new __ModelProperty(typeof(LBlock), "Alternatives", typeof(LAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LBlock_FixedText = new __ModelProperty(typeof(LBlock), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LBlock_IsFixed = new __ModelProperty(typeof(LBlock), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElement_FixedText = new __ModelProperty(typeof(LElement), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElement_IsFixed = new __ModelProperty(typeof(LElement), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElement_IsNegated = new __ModelProperty(typeof(LElement), "IsNegated", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LElement_Multiplicity = new __ModelProperty(typeof(LElement), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.SingleItem, null);
			_LElement_Value = new __ModelProperty(typeof(LElement), "Value", typeof(LElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_LexerRule_Alternatives = new __ModelProperty(typeof(LexerRule), "Alternatives", typeof(LAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LexerRule_FixedText = new __ModelProperty(typeof(LexerRule), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRule_IsFixed = new __ModelProperty(typeof(LexerRule), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRule_IsFragment = new __ModelProperty(typeof(LexerRule), "IsFragment", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRule_IsHidden = new __ModelProperty(typeof(LexerRule), "IsHidden", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRule_ReturnType = new __ModelProperty(typeof(LexerRule), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LFixed_FixedText = new __ModelProperty(typeof(LFixed), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LFixed_IsFixed = new __ModelProperty(typeof(LFixed), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LFixed_Text = new __ModelProperty(typeof(LFixed), "Text", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LRange_EndChar = new __ModelProperty(typeof(LRange), "EndChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LRange_FixedText = new __ModelProperty(typeof(LRange), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LRange_IsFixed = new __ModelProperty(typeof(LRange), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LRange_StartChar = new __ModelProperty(typeof(LRange), "StartChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LReference_FixedText = new __ModelProperty(typeof(LReference), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LReference_IsFixed = new __ModelProperty(typeof(LReference), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LReference_Rule = new __ModelProperty(typeof(LReference), "Rule", typeof(LexerRule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_LSet_FixedText = new __ModelProperty(typeof(LSet), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSet_IsFixed = new __ModelProperty(typeof(LSet), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSet_Items = new __ModelProperty(typeof(LSet), "Items", typeof(LSetItem), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LSetItem_FixedText = new __ModelProperty(typeof(LSetItem), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetItem_IsFixed = new __ModelProperty(typeof(LSetItem), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetChar_Char = new __ModelProperty(typeof(LSetChar), "Char", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LSetChar_FixedText = new __ModelProperty(typeof(LSetChar), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetChar_IsFixed = new __ModelProperty(typeof(LSetChar), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetRange_EndChar = new __ModelProperty(typeof(LSetRange), "EndChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LSetRange_FixedText = new __ModelProperty(typeof(LSetRange), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetRange_IsFixed = new __ModelProperty(typeof(LSetRange), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetRange_StartChar = new __ModelProperty(typeof(LSetRange), "StartChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LWildCard_FixedText = new __ModelProperty(typeof(LWildCard), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LWildCard_IsFixed = new __ModelProperty(typeof(LWildCard), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_NullExpression_Value = new __ModelProperty(typeof(NullExpression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_PAlternative_Elements = new __ModelProperty(typeof(PAlternative), "Elements", typeof(PElement), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Elements");
			_PAlternative_ReturnType = new __ModelProperty(typeof(PAlternative), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, "ReturnType");
			_PAlternative_ReturnValue = new __ModelProperty(typeof(PAlternative), "ReturnValue", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_ParserRule_Alternatives = new __ModelProperty(typeof(ParserRule), "Alternatives", typeof(PAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Alternatives");
			_ParserRule_IsBlock = new __ModelProperty(typeof(ParserRule), "IsBlock", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, "IsBlock");
			_ParserRule_ReturnType = new __ModelProperty(typeof(ParserRule), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, "ReturnType");
			_PBlock_Alternatives = new __ModelProperty(typeof(PBlock), "Alternatives", typeof(PAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Alternatives");
			_PElement_Assignment = new __ModelProperty(typeof(PElement), "Assignment", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.SingleItem, null);
			_PElement_Multiplicity = new __ModelProperty(typeof(PElement), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.SingleItem, null);
			_PElement_NameAnnotations = new __ModelProperty(typeof(PElement), "NameAnnotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_PElement_SymbolProperty = new __ModelProperty(typeof(PElement), "SymbolProperty", typeof(__MetaSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, "SymbolProperty");
			_PElement_Value = new __ModelProperty(typeof(PElement), "Value", typeof(PElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, "Value");
			_PElement_ValueAnnotations = new __ModelProperty(typeof(PElement), "ValueAnnotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_PKeyword_Text = new __ModelProperty(typeof(PKeyword), "Text", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_PReference_ReferencedTypes = new __ModelProperty(typeof(PReference), "ReferencedTypes", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, null);
			_PReference_Rule = new __ModelProperty(typeof(PReference), "Rule", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, "Rule");
			_ReferenceExpression_SymbolValue = new __ModelProperty(typeof(ReferenceExpression), "SymbolValue", typeof(__MetaSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_ReferenceExpression_Value = new __ModelProperty(typeof(ReferenceExpression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Rule_Grammar = new __ModelProperty(typeof(Rule), "Grammar", typeof(Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Rule_Language = new __ModelProperty(typeof(Rule), "Language", typeof(Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_StringExpression_StringValue = new __ModelProperty(typeof(StringExpression), "StringValue", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_StringExpression_Value = new __ModelProperty(typeof(StringExpression), "Value", typeof(object), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_instance = new Compiler();
		}
	
		private readonly __Model _model;
	
		private readonly global::System.Collections.Immutable.ImmutableArray<__MetaType> _enumTypes;
		private readonly global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo> _enumInfos;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelEnumInfo> _enumInfosByType;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelEnumInfo> _enumInfosByName;
	
		private readonly global::System.Collections.Immutable.ImmutableArray<__MetaType> _classTypes;
		private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _classInfos;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelClassInfo> _classInfosByType;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelClassInfo> _classInfosByName;
	
	
		private Compiler()
		{
			_enumTypes = __ImmutableArray.Create<__MetaType>(typeof(Assignment), typeof(Multiplicity));
			_enumInfos = __ImmutableArray.Create<__ModelEnumInfo>(AssignmentInfo, MultiplicityInfo);
			var enumInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelEnumInfo>();
			enumInfosByType.Add(typeof(Assignment), AssignmentInfo);
			enumInfosByType.Add(typeof(Multiplicity), MultiplicityInfo);
			_enumInfosByType = enumInfosByType.ToImmutable();
			var enumInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelEnumInfo>();
			enumInfosByName.Add("Assignment", AssignmentInfo);
			enumInfosByName.Add("Multiplicity", MultiplicityInfo);
			_enumInfosByName = enumInfosByName.ToImmutable();
	
			_classTypes = __ImmutableArray.Create<__MetaType>(typeof(Annotation), typeof(AnnotationArgument), typeof(ArrayExpression), typeof(BoolExpression), typeof(Declaration), typeof(Expression), typeof(Grammar), typeof(IntExpression), typeof(LAlternative), typeof(Language), typeof(LElementValue), typeof(LBlock), typeof(LElement), typeof(LexerRule), typeof(LFixed), typeof(LRange), typeof(LReference), typeof(LSet), typeof(LSetItem), typeof(LSetChar), typeof(LSetRange), typeof(LWildCard), typeof(Namespace), typeof(NullExpression), typeof(PAlternative), typeof(ParserRule), typeof(PBlock), typeof(PElement), typeof(PElementValue), typeof(PEof), typeof(PKeyword), typeof(PReference), typeof(ReferenceExpression), typeof(Rule), typeof(StringExpression));
			_classInfos = __ImmutableArray.Create<__ModelClassInfo>(AnnotationInfo, AnnotationArgumentInfo, ArrayExpressionInfo, BoolExpressionInfo, DeclarationInfo, ExpressionInfo, GrammarInfo, IntExpressionInfo, LAlternativeInfo, LanguageInfo, LElementValueInfo, LBlockInfo, LElementInfo, LexerRuleInfo, LFixedInfo, LRangeInfo, LReferenceInfo, LSetInfo, LSetItemInfo, LSetCharInfo, LSetRangeInfo, LWildCardInfo, NamespaceInfo, NullExpressionInfo, PAlternativeInfo, ParserRuleInfo, PBlockInfo, PElementInfo, PElementValueInfo, PEofInfo, PKeywordInfo, PReferenceInfo, ReferenceExpressionInfo, RuleInfo, StringExpressionInfo);
			var classInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelClassInfo>();
			classInfosByType.Add(typeof(Annotation), AnnotationInfo);
			classInfosByType.Add(typeof(AnnotationArgument), AnnotationArgumentInfo);
			classInfosByType.Add(typeof(ArrayExpression), ArrayExpressionInfo);
			classInfosByType.Add(typeof(BoolExpression), BoolExpressionInfo);
			classInfosByType.Add(typeof(Declaration), DeclarationInfo);
			classInfosByType.Add(typeof(Expression), ExpressionInfo);
			classInfosByType.Add(typeof(Grammar), GrammarInfo);
			classInfosByType.Add(typeof(IntExpression), IntExpressionInfo);
			classInfosByType.Add(typeof(LAlternative), LAlternativeInfo);
			classInfosByType.Add(typeof(Language), LanguageInfo);
			classInfosByType.Add(typeof(LElementValue), LElementValueInfo);
			classInfosByType.Add(typeof(LBlock), LBlockInfo);
			classInfosByType.Add(typeof(LElement), LElementInfo);
			classInfosByType.Add(typeof(LexerRule), LexerRuleInfo);
			classInfosByType.Add(typeof(LFixed), LFixedInfo);
			classInfosByType.Add(typeof(LRange), LRangeInfo);
			classInfosByType.Add(typeof(LReference), LReferenceInfo);
			classInfosByType.Add(typeof(LSet), LSetInfo);
			classInfosByType.Add(typeof(LSetItem), LSetItemInfo);
			classInfosByType.Add(typeof(LSetChar), LSetCharInfo);
			classInfosByType.Add(typeof(LSetRange), LSetRangeInfo);
			classInfosByType.Add(typeof(LWildCard), LWildCardInfo);
			classInfosByType.Add(typeof(Namespace), NamespaceInfo);
			classInfosByType.Add(typeof(NullExpression), NullExpressionInfo);
			classInfosByType.Add(typeof(PAlternative), PAlternativeInfo);
			classInfosByType.Add(typeof(ParserRule), ParserRuleInfo);
			classInfosByType.Add(typeof(PBlock), PBlockInfo);
			classInfosByType.Add(typeof(PElement), PElementInfo);
			classInfosByType.Add(typeof(PElementValue), PElementValueInfo);
			classInfosByType.Add(typeof(PEof), PEofInfo);
			classInfosByType.Add(typeof(PKeyword), PKeywordInfo);
			classInfosByType.Add(typeof(PReference), PReferenceInfo);
			classInfosByType.Add(typeof(ReferenceExpression), ReferenceExpressionInfo);
			classInfosByType.Add(typeof(Rule), RuleInfo);
			classInfosByType.Add(typeof(StringExpression), StringExpressionInfo);
			_classInfosByType = classInfosByType.ToImmutable();
			var classInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelClassInfo>();
			classInfosByName.Add("Annotation", AnnotationInfo);
			classInfosByName.Add("AnnotationArgument", AnnotationArgumentInfo);
			classInfosByName.Add("ArrayExpression", ArrayExpressionInfo);
			classInfosByName.Add("BoolExpression", BoolExpressionInfo);
			classInfosByName.Add("Declaration", DeclarationInfo);
			classInfosByName.Add("Expression", ExpressionInfo);
			classInfosByName.Add("Grammar", GrammarInfo);
			classInfosByName.Add("IntExpression", IntExpressionInfo);
			classInfosByName.Add("LAlternative", LAlternativeInfo);
			classInfosByName.Add("Language", LanguageInfo);
			classInfosByName.Add("LElementValue", LElementValueInfo);
			classInfosByName.Add("LBlock", LBlockInfo);
			classInfosByName.Add("LElement", LElementInfo);
			classInfosByName.Add("LexerRule", LexerRuleInfo);
			classInfosByName.Add("LFixed", LFixedInfo);
			classInfosByName.Add("LRange", LRangeInfo);
			classInfosByName.Add("LReference", LReferenceInfo);
			classInfosByName.Add("LSet", LSetInfo);
			classInfosByName.Add("LSetItem", LSetItemInfo);
			classInfosByName.Add("LSetChar", LSetCharInfo);
			classInfosByName.Add("LSetRange", LSetRangeInfo);
			classInfosByName.Add("LWildCard", LWildCardInfo);
			classInfosByName.Add("Namespace", NamespaceInfo);
			classInfosByName.Add("NullExpression", NullExpressionInfo);
			classInfosByName.Add("PAlternative", PAlternativeInfo);
			classInfosByName.Add("ParserRule", ParserRuleInfo);
			classInfosByName.Add("PBlock", PBlockInfo);
			classInfosByName.Add("PElement", PElementInfo);
			classInfosByName.Add("PElementValue", PElementValueInfo);
			classInfosByName.Add("PEof", PEofInfo);
			classInfosByName.Add("PKeyword", PKeywordInfo);
			classInfosByName.Add("PReference", PReferenceInfo);
			classInfosByName.Add("ReferenceExpression", ReferenceExpressionInfo);
			classInfosByName.Add("Rule", RuleInfo);
			classInfosByName.Add("StringExpression", StringExpressionInfo);
			_classInfosByName = classInfosByName.ToImmutable();
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
			var obj13 = f.MetaEnum();
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
			var obj29 = f.MetaClass();
			var obj30 = f.MetaEnum();
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
			var obj41 = f.MetaClass();
			var obj42 = f.MetaClass();
			var obj43 = f.MetaClass();
			var obj44 = f.MetaProperty();
			var obj45 = f.MetaProperty();
			var obj46 = f.MetaProperty();
			var obj47 = f.MetaProperty();
			var obj48 = f.MetaProperty();
			var obj49 = f.MetaArrayType();
			var obj50 = f.MetaNullableType();
			var obj51 = f.MetaNullableType();
			var obj52 = f.MetaArrayType();
			var obj53 = f.MetaNullableType();
			var obj54 = f.MetaProperty();
			var obj55 = f.MetaProperty();
			var obj56 = f.MetaProperty();
			var obj57 = f.MetaArrayType();
			var obj58 = f.MetaProperty();
			var obj59 = f.MetaProperty();
			var obj60 = f.MetaArrayType();
			var obj61 = f.MetaProperty();
			var obj62 = f.MetaProperty();
			var obj63 = f.MetaArrayType();
			var obj64 = f.MetaEnumLiteral();
			var obj65 = f.MetaEnumLiteral();
			var obj66 = f.MetaEnumLiteral();
			var obj67 = f.MetaEnumLiteral();
			var obj68 = f.MetaEnumLiteral();
			var obj69 = f.MetaEnumLiteral();
			var obj70 = f.MetaEnumLiteral();
			var obj71 = f.MetaProperty();
			var obj72 = f.MetaProperty();
			var obj73 = f.MetaProperty();
			var obj74 = f.MetaProperty();
			var obj75 = f.MetaProperty();
			var obj76 = f.MetaProperty();
			var obj77 = f.MetaProperty();
			var obj78 = f.MetaProperty();
			var obj79 = f.MetaNullableType();
			var obj80 = f.MetaArrayType();
			var obj81 = f.MetaProperty();
			var obj82 = f.MetaProperty();
			var obj83 = f.MetaProperty();
			var obj84 = f.MetaNullableType();
			var obj85 = f.MetaArrayType();
			var obj86 = f.MetaProperty();
			var obj87 = f.MetaProperty();
			var obj88 = f.MetaProperty();
			var obj89 = f.MetaProperty();
			var obj90 = f.MetaProperty();
			var obj91 = f.MetaNullableType();
			var obj92 = f.MetaProperty();
			var obj93 = f.MetaProperty();
			var obj94 = f.MetaNullableType();
			var obj95 = f.MetaProperty();
			var obj96 = f.MetaProperty();
			var obj97 = f.MetaProperty();
			var obj98 = f.MetaNullableType();
			var obj99 = f.MetaProperty();
			var obj100 = f.MetaProperty();
			var obj101 = f.MetaProperty();
			var obj102 = f.MetaNullableType();
			var obj103 = f.MetaProperty();
			var obj104 = f.MetaProperty();
			var obj105 = f.MetaNullableType();
			var obj106 = f.MetaProperty();
			var obj107 = f.MetaProperty();
			var obj108 = f.MetaProperty();
			var obj109 = f.MetaProperty();
			var obj110 = f.MetaNullableType();
			var obj111 = f.MetaProperty();
			var obj112 = f.MetaProperty();
			var obj113 = f.MetaProperty();
			var obj114 = f.MetaNullableType();
			var obj115 = f.MetaArrayType();
			var obj116 = f.MetaProperty();
			var obj117 = f.MetaProperty();
			var obj118 = f.MetaNullableType();
			var obj119 = f.MetaProperty();
			var obj120 = f.MetaProperty();
			var obj121 = f.MetaProperty();
			var obj122 = f.MetaNullableType();
			var obj123 = f.MetaProperty();
			var obj124 = f.MetaProperty();
			var obj125 = f.MetaProperty();
			var obj126 = f.MetaProperty();
			var obj127 = f.MetaNullableType();
			var obj128 = f.MetaProperty();
			var obj129 = f.MetaProperty();
			var obj130 = f.MetaProperty();
			var obj131 = f.MetaNullableType();
			var obj132 = f.MetaArrayType();
			var obj133 = f.MetaProperty();
			var obj134 = f.MetaProperty();
			var obj135 = f.MetaProperty();
			var obj136 = f.MetaNullableType();
			var obj137 = f.MetaArrayType();
			var obj138 = f.MetaProperty();
			var obj139 = f.MetaProperty();
			var obj140 = f.MetaProperty();
			var obj141 = f.MetaNullableType();
			var obj142 = f.MetaArrayType();
			var obj143 = f.MetaEnumLiteral();
			var obj144 = f.MetaEnumLiteral();
			var obj145 = f.MetaEnumLiteral();
			var obj146 = f.MetaEnumLiteral();
			var obj147 = f.MetaProperty();
			var obj148 = f.MetaProperty();
			var obj149 = f.MetaProperty();
			var obj150 = f.MetaProperty();
			var obj151 = f.MetaProperty();
			var obj152 = f.MetaProperty();
			var obj153 = f.MetaArrayType();
			var obj154 = f.MetaArrayType();
			var obj155 = f.MetaArrayType();
			var obj156 = f.MetaProperty();
			var obj157 = f.MetaProperty();
			var obj158 = f.MetaArrayType();
			var obj159 = f.MetaProperty();
			var obj160 = f.MetaProperty();
			var obj161 = f.MetaArrayType();
			var obj162 = f.MetaProperty();
			var obj163 = f.MetaNullableType();
			var obj164 = f.MetaProperty();
			var obj165 = f.MetaNullableType();
			var obj166 = f.MetaProperty();
			var obj167 = f.MetaProperty();
			var obj168 = f.MetaNullableType();
			var obj169 = f.MetaProperty();
			var obj170 = f.MetaProperty();
			var obj171 = f.MetaNullableType();
			var obj172 = f.MetaProperty();
			var obj173 = f.MetaProperty();
			var obj174 = f.MetaNullableType();
			var obj175 = f.MetaProperty();
			var obj176 = f.MetaProperty();
			var obj177 = f.MetaNullableType();
			var obj178 = f.MetaNullableType();
			var obj179 = f.MetaProperty();
			var obj180 = f.MetaProperty();
			var obj181 = f.MetaNullableType();
			var obj182 = f.MetaArrayType();
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
			((__IModelObject)obj5).Children.Add((__IModelObject)obj41);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj42);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj43);
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
			obj5.Declarations.Add(obj41);
			obj5.Declarations.Add(obj42);
			obj5.Declarations.Add(obj43);
			obj5.Name = "Model";
			obj5.Parent = obj4;
			obj6.Name = "Compiler";
			obj6.Parent = obj5;
			((__IModelObject)obj7).Children.Add((__IModelObject)obj44);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj45);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj46);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj47);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj48);
			obj7.IsAbstract = true;
			obj7.Properties.Add(obj44);
			obj7.Properties.Add(obj45);
			obj7.Properties.Add(obj46);
			obj7.Properties.Add(obj47);
			obj7.Properties.Add(obj48);
			obj7.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
			obj7.Declarations.Add(obj44);
			obj7.Declarations.Add(obj45);
			obj7.Declarations.Add(obj46);
			obj7.Declarations.Add(obj47);
			obj7.Declarations.Add(obj48);
			obj7.Name = "Declaration";
			obj7.Parent = obj5;
			obj8.BaseTypes.Add(obj7);
			obj8.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
			obj8.Name = "Namespace";
			obj8.Parent = obj5;
			((__IModelObject)obj9).Children.Add((__IModelObject)obj54);
			obj9.BaseTypes.Add(obj7);
			obj9.Properties.Add(obj54);
			obj9.Declarations.Add(obj54);
			obj9.Name = "Language";
			obj9.Parent = obj5;
			((__IModelObject)obj10).Children.Add((__IModelObject)obj55);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj56);
			obj10.BaseTypes.Add(obj7);
			obj10.Properties.Add(obj55);
			obj10.Properties.Add(obj56);
			obj10.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.GrammarSymbol);
			obj10.Declarations.Add(obj55);
			obj10.Declarations.Add(obj56);
			obj10.Name = "Grammar";
			obj10.Parent = obj5;
			((__IModelObject)obj11).Children.Add((__IModelObject)obj58);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj59);
			obj11.Properties.Add(obj58);
			obj11.Properties.Add(obj59);
			obj11.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.AnnotationSymbol);
			obj11.Declarations.Add(obj58);
			obj11.Declarations.Add(obj59);
			obj11.Name = "Annotation";
			obj11.Parent = obj5;
			((__IModelObject)obj12).Children.Add((__IModelObject)obj61);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj62);
			obj12.Properties.Add(obj61);
			obj12.Properties.Add(obj62);
			obj12.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.AnnotationArgumentSymbol);
			obj12.Declarations.Add(obj61);
			obj12.Declarations.Add(obj62);
			obj12.Name = "AnnotationArgument";
			obj12.Parent = obj5;
			((__IModelObject)obj13).Children.Add((__IModelObject)obj64);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj65);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj66);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj67);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj68);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj69);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj70);
			obj13.Literals.Add(obj64);
			obj13.Literals.Add(obj65);
			obj13.Literals.Add(obj66);
			obj13.Literals.Add(obj67);
			obj13.Literals.Add(obj68);
			obj13.Literals.Add(obj69);
			obj13.Literals.Add(obj70);
			obj13.Declarations.Add(obj64);
			obj13.Declarations.Add(obj65);
			obj13.Declarations.Add(obj66);
			obj13.Declarations.Add(obj67);
			obj13.Declarations.Add(obj68);
			obj13.Declarations.Add(obj69);
			obj13.Declarations.Add(obj70);
			obj13.Name = "Multiplicity";
			obj13.Parent = obj5;
			((__IModelObject)obj14).Children.Add((__IModelObject)obj71);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj72);
			obj14.BaseTypes.Add(obj7);
			obj14.IsAbstract = true;
			obj14.Properties.Add(obj71);
			obj14.Properties.Add(obj72);
			obj14.Declarations.Add(obj71);
			obj14.Declarations.Add(obj72);
			obj14.Name = "Rule";
			obj14.Parent = obj5;
			((__IModelObject)obj15).Children.Add((__IModelObject)obj73);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj74);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj75);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj76);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj77);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj78);
			obj15.BaseTypes.Add(obj14);
			obj15.Properties.Add(obj73);
			obj15.Properties.Add(obj74);
			obj15.Properties.Add(obj75);
			obj15.Properties.Add(obj76);
			obj15.Properties.Add(obj77);
			obj15.Properties.Add(obj78);
			obj15.Declarations.Add(obj73);
			obj15.Declarations.Add(obj74);
			obj15.Declarations.Add(obj75);
			obj15.Declarations.Add(obj76);
			obj15.Declarations.Add(obj77);
			obj15.Declarations.Add(obj78);
			obj15.Name = "LexerRule";
			obj15.Parent = obj5;
			((__IModelObject)obj16).Children.Add((__IModelObject)obj81);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj82);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj83);
			obj16.Properties.Add(obj81);
			obj16.Properties.Add(obj82);
			obj16.Properties.Add(obj83);
			obj16.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj16.Declarations.Add(obj81);
			obj16.Declarations.Add(obj82);
			obj16.Declarations.Add(obj83);
			obj16.Name = "LAlternative";
			obj16.Parent = obj5;
			((__IModelObject)obj17).Children.Add((__IModelObject)obj86);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj87);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj88);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj89);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj90);
			obj17.Properties.Add(obj86);
			obj17.Properties.Add(obj87);
			obj17.Properties.Add(obj88);
			obj17.Properties.Add(obj89);
			obj17.Properties.Add(obj90);
			obj17.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj17.Declarations.Add(obj86);
			obj17.Declarations.Add(obj87);
			obj17.Declarations.Add(obj88);
			obj17.Declarations.Add(obj89);
			obj17.Declarations.Add(obj90);
			obj17.Name = "LElement";
			obj17.Parent = obj5;
			((__IModelObject)obj18).Children.Add((__IModelObject)obj92);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj93);
			obj18.IsAbstract = true;
			obj18.Properties.Add(obj92);
			obj18.Properties.Add(obj93);
			obj18.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj18.Declarations.Add(obj92);
			obj18.Declarations.Add(obj93);
			obj18.Name = "LElementValue";
			obj18.Parent = obj5;
			((__IModelObject)obj19).Children.Add((__IModelObject)obj95);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj96);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj97);
			obj19.BaseTypes.Add(obj18);
			obj19.Properties.Add(obj95);
			obj19.Properties.Add(obj96);
			obj19.Properties.Add(obj97);
			obj19.Declarations.Add(obj95);
			obj19.Declarations.Add(obj96);
			obj19.Declarations.Add(obj97);
			obj19.Name = "LReference";
			obj19.Parent = obj5;
			((__IModelObject)obj20).Children.Add((__IModelObject)obj99);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj100);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj101);
			obj20.BaseTypes.Add(obj18);
			obj20.Properties.Add(obj99);
			obj20.Properties.Add(obj100);
			obj20.Properties.Add(obj101);
			obj20.Declarations.Add(obj99);
			obj20.Declarations.Add(obj100);
			obj20.Declarations.Add(obj101);
			obj20.Name = "LFixed";
			obj20.Parent = obj5;
			((__IModelObject)obj21).Children.Add((__IModelObject)obj103);
			((__IModelObject)obj21).Children.Add((__IModelObject)obj104);
			obj21.BaseTypes.Add(obj18);
			obj21.Properties.Add(obj103);
			obj21.Properties.Add(obj104);
			obj21.Declarations.Add(obj103);
			obj21.Declarations.Add(obj104);
			obj21.Name = "LWildCard";
			obj21.Parent = obj5;
			((__IModelObject)obj22).Children.Add((__IModelObject)obj106);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj107);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj108);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj109);
			obj22.BaseTypes.Add(obj18);
			obj22.Properties.Add(obj106);
			obj22.Properties.Add(obj107);
			obj22.Properties.Add(obj108);
			obj22.Properties.Add(obj109);
			obj22.Declarations.Add(obj106);
			obj22.Declarations.Add(obj107);
			obj22.Declarations.Add(obj108);
			obj22.Declarations.Add(obj109);
			obj22.Name = "LRange";
			obj22.Parent = obj5;
			((__IModelObject)obj23).Children.Add((__IModelObject)obj111);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj112);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj113);
			obj23.BaseTypes.Add(obj18);
			obj23.Properties.Add(obj111);
			obj23.Properties.Add(obj112);
			obj23.Properties.Add(obj113);
			obj23.Declarations.Add(obj111);
			obj23.Declarations.Add(obj112);
			obj23.Declarations.Add(obj113);
			obj23.Name = "LSet";
			obj23.Parent = obj5;
			((__IModelObject)obj24).Children.Add((__IModelObject)obj116);
			((__IModelObject)obj24).Children.Add((__IModelObject)obj117);
			obj24.IsAbstract = true;
			obj24.Properties.Add(obj116);
			obj24.Properties.Add(obj117);
			obj24.Declarations.Add(obj116);
			obj24.Declarations.Add(obj117);
			obj24.Name = "LSetItem";
			obj24.Parent = obj5;
			((__IModelObject)obj25).Children.Add((__IModelObject)obj119);
			((__IModelObject)obj25).Children.Add((__IModelObject)obj120);
			((__IModelObject)obj25).Children.Add((__IModelObject)obj121);
			obj25.BaseTypes.Add(obj24);
			obj25.Properties.Add(obj119);
			obj25.Properties.Add(obj120);
			obj25.Properties.Add(obj121);
			obj25.Declarations.Add(obj119);
			obj25.Declarations.Add(obj120);
			obj25.Declarations.Add(obj121);
			obj25.Name = "LSetChar";
			obj25.Parent = obj5;
			((__IModelObject)obj26).Children.Add((__IModelObject)obj123);
			((__IModelObject)obj26).Children.Add((__IModelObject)obj124);
			((__IModelObject)obj26).Children.Add((__IModelObject)obj125);
			((__IModelObject)obj26).Children.Add((__IModelObject)obj126);
			obj26.BaseTypes.Add(obj24);
			obj26.Properties.Add(obj123);
			obj26.Properties.Add(obj124);
			obj26.Properties.Add(obj125);
			obj26.Properties.Add(obj126);
			obj26.Declarations.Add(obj123);
			obj26.Declarations.Add(obj124);
			obj26.Declarations.Add(obj125);
			obj26.Declarations.Add(obj126);
			obj26.Name = "LSetRange";
			obj26.Parent = obj5;
			((__IModelObject)obj27).Children.Add((__IModelObject)obj128);
			((__IModelObject)obj27).Children.Add((__IModelObject)obj129);
			((__IModelObject)obj27).Children.Add((__IModelObject)obj130);
			obj27.BaseTypes.Add(obj18);
			obj27.Properties.Add(obj128);
			obj27.Properties.Add(obj129);
			obj27.Properties.Add(obj130);
			obj27.Declarations.Add(obj128);
			obj27.Declarations.Add(obj129);
			obj27.Declarations.Add(obj130);
			obj27.Name = "LBlock";
			obj27.Parent = obj5;
			((__IModelObject)obj28).Children.Add((__IModelObject)obj133);
			((__IModelObject)obj28).Children.Add((__IModelObject)obj134);
			((__IModelObject)obj28).Children.Add((__IModelObject)obj135);
			obj28.BaseTypes.Add(obj14);
			obj28.IsAbstract = true;
			obj28.Properties.Add(obj133);
			obj28.Properties.Add(obj134);
			obj28.Properties.Add(obj135);
			obj28.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ParserRuleSymbol);
			obj28.Declarations.Add(obj133);
			obj28.Declarations.Add(obj134);
			obj28.Declarations.Add(obj135);
			obj28.Name = "ParserRule";
			obj28.Parent = obj5;
			((__IModelObject)obj29).Children.Add((__IModelObject)obj138);
			((__IModelObject)obj29).Children.Add((__IModelObject)obj139);
			((__IModelObject)obj29).Children.Add((__IModelObject)obj140);
			obj29.BaseTypes.Add(obj7);
			obj29.Properties.Add(obj138);
			obj29.Properties.Add(obj139);
			obj29.Properties.Add(obj140);
			obj29.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PAlternativeSymbol);
			obj29.Declarations.Add(obj138);
			obj29.Declarations.Add(obj139);
			obj29.Declarations.Add(obj140);
			obj29.Name = "PAlternative";
			obj29.Parent = obj5;
			((__IModelObject)obj30).Children.Add((__IModelObject)obj143);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj144);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj145);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj146);
			obj30.Literals.Add(obj143);
			obj30.Literals.Add(obj144);
			obj30.Literals.Add(obj145);
			obj30.Literals.Add(obj146);
			obj30.Declarations.Add(obj143);
			obj30.Declarations.Add(obj144);
			obj30.Declarations.Add(obj145);
			obj30.Declarations.Add(obj146);
			obj30.Name = "Assignment";
			obj30.Parent = obj5;
			((__IModelObject)obj31).Children.Add((__IModelObject)obj147);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj148);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj149);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj150);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj151);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj152);
			obj31.Properties.Add(obj147);
			obj31.Properties.Add(obj148);
			obj31.Properties.Add(obj149);
			obj31.Properties.Add(obj150);
			obj31.Properties.Add(obj151);
			obj31.Properties.Add(obj152);
			obj31.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PElementSymbol);
			obj31.Declarations.Add(obj147);
			obj31.Declarations.Add(obj148);
			obj31.Declarations.Add(obj149);
			obj31.Declarations.Add(obj150);
			obj31.Declarations.Add(obj151);
			obj31.Declarations.Add(obj152);
			obj31.Name = "PElement";
			obj31.Parent = obj5;
			obj32.IsAbstract = true;
			obj32.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj32.Name = "PElementValue";
			obj32.Parent = obj5;
			((__IModelObject)obj33).Children.Add((__IModelObject)obj156);
			((__IModelObject)obj33).Children.Add((__IModelObject)obj157);
			obj33.BaseTypes.Add(obj32);
			obj33.Properties.Add(obj156);
			obj33.Properties.Add(obj157);
			obj33.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PReferenceSymbol);
			obj33.Declarations.Add(obj156);
			obj33.Declarations.Add(obj157);
			obj33.Name = "PReference";
			obj33.Parent = obj5;
			obj34.BaseTypes.Add(obj32);
			obj34.Name = "PEof";
			obj34.Parent = obj5;
			((__IModelObject)obj35).Children.Add((__IModelObject)obj159);
			obj35.BaseTypes.Add(obj32);
			obj35.Properties.Add(obj159);
			obj35.Declarations.Add(obj159);
			obj35.Name = "PKeyword";
			obj35.Parent = obj5;
			((__IModelObject)obj36).Children.Add((__IModelObject)obj160);
			obj36.BaseTypes.Add(obj32);
			obj36.Properties.Add(obj160);
			obj36.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PBlockSymbol);
			obj36.Declarations.Add(obj160);
			obj36.Name = "PBlock";
			obj36.Parent = obj5;
			((__IModelObject)obj37).Children.Add((__IModelObject)obj162);
			obj37.IsAbstract = true;
			obj37.Properties.Add(obj162);
			obj37.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
			obj37.Declarations.Add(obj162);
			obj37.Name = "Expression";
			obj37.Parent = obj5;
			((__IModelObject)obj38).Children.Add((__IModelObject)obj164);
			obj38.BaseTypes.Add(obj37);
			obj38.Properties.Add(obj164);
			obj38.Declarations.Add(obj164);
			obj38.Name = "NullExpression";
			obj38.Parent = obj5;
			((__IModelObject)obj39).Children.Add((__IModelObject)obj166);
			((__IModelObject)obj39).Children.Add((__IModelObject)obj167);
			obj39.BaseTypes.Add(obj37);
			obj39.Properties.Add(obj166);
			obj39.Properties.Add(obj167);
			obj39.Declarations.Add(obj166);
			obj39.Declarations.Add(obj167);
			obj39.Name = "BoolExpression";
			obj39.Parent = obj5;
			((__IModelObject)obj40).Children.Add((__IModelObject)obj169);
			((__IModelObject)obj40).Children.Add((__IModelObject)obj170);
			obj40.BaseTypes.Add(obj37);
			obj40.Properties.Add(obj169);
			obj40.Properties.Add(obj170);
			obj40.Declarations.Add(obj169);
			obj40.Declarations.Add(obj170);
			obj40.Name = "IntExpression";
			obj40.Parent = obj5;
			((__IModelObject)obj41).Children.Add((__IModelObject)obj172);
			((__IModelObject)obj41).Children.Add((__IModelObject)obj173);
			obj41.BaseTypes.Add(obj37);
			obj41.Properties.Add(obj172);
			obj41.Properties.Add(obj173);
			obj41.Declarations.Add(obj172);
			obj41.Declarations.Add(obj173);
			obj41.Name = "StringExpression";
			obj41.Parent = obj5;
			((__IModelObject)obj42).Children.Add((__IModelObject)obj175);
			((__IModelObject)obj42).Children.Add((__IModelObject)obj176);
			obj42.BaseTypes.Add(obj37);
			obj42.Properties.Add(obj175);
			obj42.Properties.Add(obj176);
			obj42.Declarations.Add(obj175);
			obj42.Declarations.Add(obj176);
			obj42.Name = "ReferenceExpression";
			obj42.Parent = obj5;
			((__IModelObject)obj43).Children.Add((__IModelObject)obj179);
			((__IModelObject)obj43).Children.Add((__IModelObject)obj180);
			obj43.BaseTypes.Add(obj37);
			obj43.Properties.Add(obj179);
			obj43.Properties.Add(obj180);
			obj43.Declarations.Add(obj179);
			obj43.Declarations.Add(obj180);
			obj43.Name = "ArrayExpression";
			obj43.Parent = obj5;
			((__IModelObject)obj44).Children.Add((__IModelObject)obj49);
			obj44.IsContainment = true;
			obj44.Type = __MetaType.FromModelObject((__IModelObject)obj49);
			obj44.Name = "Annotations";
			obj44.Parent = obj7;
			((__IModelObject)obj45).Children.Add((__IModelObject)obj50);
			obj45.SymbolProperty = "Name";
			obj45.Type = __MetaType.FromModelObject((__IModelObject)obj50);
			obj45.Name = "Name";
			obj45.Parent = obj7;
			((__IModelObject)obj46).Children.Add((__IModelObject)obj51);
			obj46.OppositeProperties.Add(obj47);
			obj46.Type = __MetaType.FromModelObject((__IModelObject)obj51);
			obj46.Name = "Parent";
			obj46.Parent = obj7;
			((__IModelObject)obj47).Children.Add((__IModelObject)obj52);
			obj47.IsContainment = true;
			obj47.OppositeProperties.Add(obj46);
			obj47.Type = __MetaType.FromModelObject((__IModelObject)obj52);
			obj47.Name = "Declarations";
			obj47.Parent = obj7;
			((__IModelObject)obj48).Children.Add((__IModelObject)obj53);
			obj48.IsDerived = true;
			obj48.Type = __MetaType.FromModelObject((__IModelObject)obj53);
			obj48.Name = "FullName";
			obj48.Parent = obj7;
			obj49.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj50.InnerType = typeof(string);
			obj51.InnerType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj52.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj53.InnerType = typeof(string);
			obj54.IsContainment = true;
			obj54.SubsettedProperties.Add(obj47);
			obj54.Type = __MetaType.FromModelObject((__IModelObject)obj10);
			obj54.Name = "Grammar";
			obj54.Parent = obj9;
			obj55.RedefinedProperties.Add(obj46);
			obj55.Type = __MetaType.FromModelObject((__IModelObject)obj9);
			obj55.Name = "Language";
			obj55.Parent = obj10;
			((__IModelObject)obj56).Children.Add((__IModelObject)obj57);
			obj56.IsContainment = true;
			obj56.Type = __MetaType.FromModelObject((__IModelObject)obj57);
			obj56.Name = "Rules";
			obj56.Parent = obj10;
			obj57.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj58.SymbolProperty = "Type";
			obj58.Type = typeof(__MetaType);
			obj58.Name = "Type";
			obj58.Parent = obj11;
			((__IModelObject)obj59).Children.Add((__IModelObject)obj60);
			obj59.IsContainment = true;
			obj59.SymbolProperty = "Arguments";
			obj59.Type = __MetaType.FromModelObject((__IModelObject)obj60);
			obj59.Name = "Arguments";
			obj59.Parent = obj11;
			obj60.ItemType = __MetaType.FromModelObject((__IModelObject)obj12);
			((__IModelObject)obj61).Children.Add((__IModelObject)obj63);
			obj61.SymbolProperty = "NamedParameter";
			obj61.Type = __MetaType.FromModelObject((__IModelObject)obj63);
			obj61.Name = "NamedParameter";
			obj61.Parent = obj12;
			obj62.IsContainment = true;
			obj62.SymbolProperty = "Value";
			obj62.Type = __MetaType.FromModelObject((__IModelObject)obj37);
			obj62.Name = "Value";
			obj62.Parent = obj12;
			obj63.ItemType = typeof(__MetaSymbol);
			obj64.Name = "ExactlyOne";
			obj64.Parent = obj13;
			obj65.Name = "ZeroOrOne";
			obj65.Parent = obj13;
			obj66.Name = "ZeroOrMore";
			obj66.Parent = obj13;
			obj67.Name = "OneOrMore";
			obj67.Parent = obj13;
			obj68.Name = "NonGreedyZeroOrOne";
			obj68.Parent = obj13;
			obj69.Name = "NonGreedyZeroOrMore";
			obj69.Parent = obj13;
			obj70.Name = "NonGreedyOneOrMore";
			obj70.Parent = obj13;
			obj71.IsDerived = true;
			obj71.Type = __MetaType.FromModelObject((__IModelObject)obj9);
			obj71.Name = "Language";
			obj71.Parent = obj14;
			obj72.RedefinedProperties.Add(obj46);
			obj72.Type = __MetaType.FromModelObject((__IModelObject)obj10);
			obj72.Name = "Grammar";
			obj72.Parent = obj14;
			obj73.Type = typeof(__MetaType);
			obj73.Name = "ReturnType";
			obj73.Parent = obj15;
			obj74.Type = typeof(bool);
			obj74.Name = "IsHidden";
			obj74.Parent = obj15;
			obj75.Type = typeof(bool);
			obj75.Name = "IsFragment";
			obj75.Parent = obj15;
			obj76.IsDerived = true;
			obj76.Type = typeof(bool);
			obj76.Name = "IsFixed";
			obj76.Parent = obj15;
			((__IModelObject)obj77).Children.Add((__IModelObject)obj79);
			obj77.IsDerived = true;
			obj77.Type = __MetaType.FromModelObject((__IModelObject)obj79);
			obj77.Name = "FixedText";
			obj77.Parent = obj15;
			((__IModelObject)obj78).Children.Add((__IModelObject)obj80);
			obj78.IsContainment = true;
			obj78.Type = __MetaType.FromModelObject((__IModelObject)obj80);
			obj78.Name = "Alternatives";
			obj78.Parent = obj15;
			obj79.InnerType = typeof(string);
			obj80.ItemType = __MetaType.FromModelObject((__IModelObject)obj16);
			obj81.IsDerived = true;
			obj81.Type = typeof(bool);
			obj81.Name = "IsFixed";
			obj81.Parent = obj16;
			((__IModelObject)obj82).Children.Add((__IModelObject)obj84);
			obj82.IsDerived = true;
			obj82.Type = __MetaType.FromModelObject((__IModelObject)obj84);
			obj82.Name = "FixedText";
			obj82.Parent = obj16;
			((__IModelObject)obj83).Children.Add((__IModelObject)obj85);
			obj83.IsContainment = true;
			obj83.Type = __MetaType.FromModelObject((__IModelObject)obj85);
			obj83.Name = "Elements";
			obj83.Parent = obj16;
			obj84.InnerType = typeof(string);
			obj85.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
			obj86.IsDerived = true;
			obj86.Type = typeof(bool);
			obj86.Name = "IsFixed";
			obj86.Parent = obj17;
			((__IModelObject)obj87).Children.Add((__IModelObject)obj91);
			obj87.IsDerived = true;
			obj87.Type = __MetaType.FromModelObject((__IModelObject)obj91);
			obj87.Name = "FixedText";
			obj87.Parent = obj17;
			obj88.Type = typeof(bool);
			obj88.Name = "IsNegated";
			obj88.Parent = obj17;
			obj89.IsContainment = true;
			obj89.Type = __MetaType.FromModelObject((__IModelObject)obj18);
			obj89.Name = "Value";
			obj89.Parent = obj17;
			obj90.Type = __MetaType.FromModelObject((__IModelObject)obj13);
			obj90.Name = "Multiplicity";
			obj90.Parent = obj17;
			obj91.InnerType = typeof(string);
			obj92.IsDerived = true;
			obj92.Type = typeof(bool);
			obj92.Name = "IsFixed";
			obj92.Parent = obj18;
			((__IModelObject)obj93).Children.Add((__IModelObject)obj94);
			obj93.IsDerived = true;
			obj93.Type = __MetaType.FromModelObject((__IModelObject)obj94);
			obj93.Name = "FixedText";
			obj93.Parent = obj18;
			obj94.InnerType = typeof(string);
			obj95.IsDerived = true;
			obj95.Type = typeof(bool);
			obj95.Name = "IsFixed";
			obj95.Parent = obj19;
			((__IModelObject)obj96).Children.Add((__IModelObject)obj98);
			obj96.IsDerived = true;
			obj96.Type = __MetaType.FromModelObject((__IModelObject)obj98);
			obj96.Name = "FixedText";
			obj96.Parent = obj19;
			obj97.Type = __MetaType.FromModelObject((__IModelObject)obj15);
			obj97.Name = "Rule";
			obj97.Parent = obj19;
			obj98.InnerType = typeof(string);
			obj99.IsDerived = true;
			obj99.Type = typeof(bool);
			obj99.Name = "IsFixed";
			obj99.Parent = obj20;
			((__IModelObject)obj100).Children.Add((__IModelObject)obj102);
			obj100.IsDerived = true;
			obj100.Type = __MetaType.FromModelObject((__IModelObject)obj102);
			obj100.Name = "FixedText";
			obj100.Parent = obj20;
			obj101.Type = typeof(string);
			obj101.Name = "Text";
			obj101.Parent = obj20;
			obj102.InnerType = typeof(string);
			obj103.IsDerived = true;
			obj103.Type = typeof(bool);
			obj103.Name = "IsFixed";
			obj103.Parent = obj21;
			((__IModelObject)obj104).Children.Add((__IModelObject)obj105);
			obj104.IsDerived = true;
			obj104.Type = __MetaType.FromModelObject((__IModelObject)obj105);
			obj104.Name = "FixedText";
			obj104.Parent = obj21;
			obj105.InnerType = typeof(string);
			obj106.IsDerived = true;
			obj106.Type = typeof(bool);
			obj106.Name = "IsFixed";
			obj106.Parent = obj22;
			((__IModelObject)obj107).Children.Add((__IModelObject)obj110);
			obj107.IsDerived = true;
			obj107.Type = __MetaType.FromModelObject((__IModelObject)obj110);
			obj107.Name = "FixedText";
			obj107.Parent = obj22;
			obj108.Type = typeof(string);
			obj108.Name = "StartChar";
			obj108.Parent = obj22;
			obj109.Type = typeof(string);
			obj109.Name = "EndChar";
			obj109.Parent = obj22;
			obj110.InnerType = typeof(string);
			obj111.IsDerived = true;
			obj111.Type = typeof(bool);
			obj111.Name = "IsFixed";
			obj111.Parent = obj23;
			((__IModelObject)obj112).Children.Add((__IModelObject)obj114);
			obj112.IsDerived = true;
			obj112.Type = __MetaType.FromModelObject((__IModelObject)obj114);
			obj112.Name = "FixedText";
			obj112.Parent = obj23;
			((__IModelObject)obj113).Children.Add((__IModelObject)obj115);
			obj113.IsContainment = true;
			obj113.Type = __MetaType.FromModelObject((__IModelObject)obj115);
			obj113.Name = "Items";
			obj113.Parent = obj23;
			obj114.InnerType = typeof(string);
			obj115.ItemType = __MetaType.FromModelObject((__IModelObject)obj24);
			obj116.IsDerived = true;
			obj116.Type = typeof(bool);
			obj116.Name = "IsFixed";
			obj116.Parent = obj24;
			((__IModelObject)obj117).Children.Add((__IModelObject)obj118);
			obj117.IsDerived = true;
			obj117.Type = __MetaType.FromModelObject((__IModelObject)obj118);
			obj117.Name = "FixedText";
			obj117.Parent = obj24;
			obj118.InnerType = typeof(string);
			obj119.IsDerived = true;
			obj119.Type = typeof(bool);
			obj119.Name = "IsFixed";
			obj119.Parent = obj25;
			((__IModelObject)obj120).Children.Add((__IModelObject)obj122);
			obj120.IsDerived = true;
			obj120.Type = __MetaType.FromModelObject((__IModelObject)obj122);
			obj120.Name = "FixedText";
			obj120.Parent = obj25;
			obj121.Type = typeof(string);
			obj121.Name = "Char";
			obj121.Parent = obj25;
			obj122.InnerType = typeof(string);
			obj123.IsDerived = true;
			obj123.Type = typeof(bool);
			obj123.Name = "IsFixed";
			obj123.Parent = obj26;
			((__IModelObject)obj124).Children.Add((__IModelObject)obj127);
			obj124.IsDerived = true;
			obj124.Type = __MetaType.FromModelObject((__IModelObject)obj127);
			obj124.Name = "FixedText";
			obj124.Parent = obj26;
			obj125.Type = typeof(string);
			obj125.Name = "StartChar";
			obj125.Parent = obj26;
			obj126.Type = typeof(string);
			obj126.Name = "EndChar";
			obj126.Parent = obj26;
			obj127.InnerType = typeof(string);
			obj128.IsDerived = true;
			obj128.Type = typeof(bool);
			obj128.Name = "IsFixed";
			obj128.Parent = obj27;
			((__IModelObject)obj129).Children.Add((__IModelObject)obj131);
			obj129.IsDerived = true;
			obj129.Type = __MetaType.FromModelObject((__IModelObject)obj131);
			obj129.Name = "FixedText";
			obj129.Parent = obj27;
			((__IModelObject)obj130).Children.Add((__IModelObject)obj132);
			obj130.IsContainment = true;
			obj130.Type = __MetaType.FromModelObject((__IModelObject)obj132);
			obj130.Name = "Alternatives";
			obj130.Parent = obj27;
			obj131.InnerType = typeof(string);
			obj132.ItemType = __MetaType.FromModelObject((__IModelObject)obj16);
			((__IModelObject)obj133).Children.Add((__IModelObject)obj136);
			obj133.SymbolProperty = "ReturnType";
			obj133.Type = __MetaType.FromModelObject((__IModelObject)obj136);
			obj133.Name = "ReturnType";
			obj133.Parent = obj28;
			obj134.SymbolProperty = "IsBlock";
			obj134.Type = typeof(bool);
			obj134.Name = "IsBlock";
			obj134.Parent = obj28;
			((__IModelObject)obj135).Children.Add((__IModelObject)obj137);
			obj135.IsContainment = true;
			obj135.SymbolProperty = "Alternatives";
			obj135.Type = __MetaType.FromModelObject((__IModelObject)obj137);
			obj135.Name = "Alternatives";
			obj135.Parent = obj28;
			obj136.InnerType = typeof(__MetaType);
			obj137.ItemType = __MetaType.FromModelObject((__IModelObject)obj29);
			((__IModelObject)obj138).Children.Add((__IModelObject)obj141);
			obj138.SymbolProperty = "ReturnType";
			obj138.Type = __MetaType.FromModelObject((__IModelObject)obj141);
			obj138.Name = "ReturnType";
			obj138.Parent = obj29;
			obj139.IsContainment = true;
			obj139.Type = __MetaType.FromModelObject((__IModelObject)obj37);
			obj139.Name = "ReturnValue";
			obj139.Parent = obj29;
			((__IModelObject)obj140).Children.Add((__IModelObject)obj142);
			obj140.IsContainment = true;
			obj140.SymbolProperty = "Elements";
			obj140.Type = __MetaType.FromModelObject((__IModelObject)obj142);
			obj140.Name = "Elements";
			obj140.Parent = obj29;
			obj141.InnerType = typeof(__MetaType);
			obj142.ItemType = __MetaType.FromModelObject((__IModelObject)obj31);
			obj143.Name = "Assign";
			obj143.Parent = obj30;
			obj144.Name = "QuestionAssign";
			obj144.Parent = obj30;
			obj145.Name = "NegatedAssign";
			obj145.Parent = obj30;
			obj146.Name = "PlusAssign";
			obj146.Parent = obj30;
			((__IModelObject)obj147).Children.Add((__IModelObject)obj153);
			obj147.IsContainment = true;
			obj147.Type = __MetaType.FromModelObject((__IModelObject)obj153);
			obj147.Name = "NameAnnotations";
			obj147.Parent = obj31;
			((__IModelObject)obj148).Children.Add((__IModelObject)obj154);
			obj148.SymbolProperty = "SymbolProperty";
			obj148.Type = __MetaType.FromModelObject((__IModelObject)obj154);
			obj148.Name = "SymbolProperty";
			obj148.Parent = obj31;
			obj149.Type = __MetaType.FromModelObject((__IModelObject)obj30);
			obj149.Name = "Assignment";
			obj149.Parent = obj31;
			((__IModelObject)obj150).Children.Add((__IModelObject)obj155);
			obj150.IsContainment = true;
			obj150.Type = __MetaType.FromModelObject((__IModelObject)obj155);
			obj150.Name = "ValueAnnotations";
			obj150.Parent = obj31;
			obj151.IsContainment = true;
			obj151.SymbolProperty = "Value";
			obj151.Type = __MetaType.FromModelObject((__IModelObject)obj32);
			obj151.Name = "Value";
			obj151.Parent = obj31;
			obj152.Type = __MetaType.FromModelObject((__IModelObject)obj13);
			obj152.Name = "Multiplicity";
			obj152.Parent = obj31;
			obj153.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj154.ItemType = typeof(__MetaSymbol);
			obj155.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj156.SymbolProperty = "Rule";
			obj156.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj156.Name = "Rule";
			obj156.Parent = obj33;
			((__IModelObject)obj157).Children.Add((__IModelObject)obj158);
			obj157.Type = __MetaType.FromModelObject((__IModelObject)obj158);
			obj157.Name = "ReferencedTypes";
			obj157.Parent = obj33;
			obj158.ItemType = typeof(__MetaType);
			obj159.Type = typeof(string);
			obj159.Name = "Text";
			obj159.Parent = obj35;
			((__IModelObject)obj160).Children.Add((__IModelObject)obj161);
			obj160.IsContainment = true;
			obj160.SymbolProperty = "Alternatives";
			obj160.Type = __MetaType.FromModelObject((__IModelObject)obj161);
			obj160.Name = "Alternatives";
			obj160.Parent = obj36;
			obj161.ItemType = __MetaType.FromModelObject((__IModelObject)obj29);
			((__IModelObject)obj162).Children.Add((__IModelObject)obj163);
			obj162.IsDerived = true;
			obj162.Type = __MetaType.FromModelObject((__IModelObject)obj163);
			obj162.Name = "Value";
			obj162.Parent = obj37;
			obj163.InnerType = typeof(object);
			((__IModelObject)obj164).Children.Add((__IModelObject)obj165);
			obj164.IsDerived = true;
			obj164.Type = __MetaType.FromModelObject((__IModelObject)obj165);
			obj164.Name = "Value";
			obj164.Parent = obj38;
			obj165.InnerType = typeof(object);
			((__IModelObject)obj166).Children.Add((__IModelObject)obj168);
			obj166.IsDerived = true;
			obj166.Type = __MetaType.FromModelObject((__IModelObject)obj168);
			obj166.Name = "Value";
			obj166.Parent = obj39;
			obj167.Type = typeof(bool);
			obj167.Name = "BoolValue";
			obj167.Parent = obj39;
			obj168.InnerType = typeof(object);
			((__IModelObject)obj169).Children.Add((__IModelObject)obj171);
			obj169.IsDerived = true;
			obj169.Type = __MetaType.FromModelObject((__IModelObject)obj171);
			obj169.Name = "Value";
			obj169.Parent = obj40;
			obj170.Type = typeof(int);
			obj170.Name = "IntValue";
			obj170.Parent = obj40;
			obj171.InnerType = typeof(object);
			((__IModelObject)obj172).Children.Add((__IModelObject)obj174);
			obj172.IsDerived = true;
			obj172.Type = __MetaType.FromModelObject((__IModelObject)obj174);
			obj172.Name = "Value";
			obj172.Parent = obj41;
			obj173.Type = typeof(string);
			obj173.Name = "StringValue";
			obj173.Parent = obj41;
			obj174.InnerType = typeof(object);
			((__IModelObject)obj175).Children.Add((__IModelObject)obj177);
			obj175.IsDerived = true;
			obj175.Type = __MetaType.FromModelObject((__IModelObject)obj177);
			obj175.Name = "Value";
			obj175.Parent = obj42;
			((__IModelObject)obj176).Children.Add((__IModelObject)obj178);
			obj176.Type = __MetaType.FromModelObject((__IModelObject)obj178);
			obj176.Name = "SymbolValue";
			obj176.Parent = obj42;
			obj177.InnerType = typeof(object);
			obj178.InnerType = typeof(__MetaSymbol);
			((__IModelObject)obj179).Children.Add((__IModelObject)obj181);
			obj179.IsDerived = true;
			obj179.Type = __MetaType.FromModelObject((__IModelObject)obj181);
			obj179.Name = "Value";
			obj179.Parent = obj43;
			((__IModelObject)obj180).Children.Add((__IModelObject)obj182);
			obj180.Type = __MetaType.FromModelObject((__IModelObject)obj182);
			obj180.Name = "Items";
			obj180.Parent = obj43;
			obj181.InnerType = typeof(object);
			obj182.ItemType = __MetaType.FromModelObject((__IModelObject)obj37);
			_model.IsSealed = true;
		}
	
	    public override string MName => nameof(Compiler);
	    public override string MNamespace => "MetaDslx.Bootstrap.MetaCompiler.Model";
	    public override __ModelVersion MVersion => default;
	    public override string MUri => "MetaDslx.Bootstrap.MetaCompiler.Model.Compiler";
	    public override string MPrefix => "c";
		public override __Model MModel => _model;
	
		public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelEnumInfo> MEnumInfosByType => _enumInfosByType;
		public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelEnumInfo> MEnumInfosByName => _enumInfosByName;
		public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelClassInfo> MClassInfosByType => _classInfosByType;
		public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelClassInfo> MClassInfosByName => _classInfosByName;
	
	    public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MEnumTypes => _enumTypes;
	    public override global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo> MEnumInfos => _enumInfos;
	    public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MClassTypes => _classTypes;
	    public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> MClassInfos => _classInfos;
	
	
	
		public static __ModelEnumInfo AssignmentInfo => __Impl.__Assignment_Info.Instance;
		public static __ModelEnumInfo MultiplicityInfo => __Impl.__Multiplicity_Info.Instance;
		public static __ModelClassInfo AnnotationInfo => __Impl.Annotation_Impl.__Info.Instance;
		public static __ModelProperty Annotation_Type => _Annotation_Type;
		public static __ModelProperty Annotation_Arguments => _Annotation_Arguments;
		public static __ModelClassInfo AnnotationArgumentInfo => __Impl.AnnotationArgument_Impl.__Info.Instance;
		public static __ModelProperty AnnotationArgument_NamedParameter => _AnnotationArgument_NamedParameter;
		public static __ModelProperty AnnotationArgument_Value => _AnnotationArgument_Value;
		public static __ModelClassInfo ArrayExpressionInfo => __Impl.ArrayExpression_Impl.__Info.Instance;
		public static __ModelProperty ArrayExpression_Value => _ArrayExpression_Value;
		public static __ModelProperty ArrayExpression_Items => _ArrayExpression_Items;
		public static __ModelClassInfo BoolExpressionInfo => __Impl.BoolExpression_Impl.__Info.Instance;
		public static __ModelProperty BoolExpression_Value => _BoolExpression_Value;
		public static __ModelProperty BoolExpression_BoolValue => _BoolExpression_BoolValue;
		public static __ModelClassInfo DeclarationInfo => __Impl.Declaration_Impl.__Info.Instance;
		public static __ModelProperty Declaration_Annotations => _Declaration_Annotations;
		public static __ModelProperty Declaration_Name => _Declaration_Name;
		public static __ModelProperty Declaration_Parent => _Declaration_Parent;
		public static __ModelProperty Declaration_Declarations => _Declaration_Declarations;
		public static __ModelProperty Declaration_FullName => _Declaration_FullName;
		public static __ModelClassInfo ExpressionInfo => __Impl.Expression_Impl.__Info.Instance;
		public static __ModelProperty Expression_Value => _Expression_Value;
		public static __ModelClassInfo GrammarInfo => __Impl.Grammar_Impl.__Info.Instance;
		public static __ModelProperty Grammar_Language => _Grammar_Language;
		public static __ModelProperty Grammar_Rules => _Grammar_Rules;
		public static __ModelClassInfo IntExpressionInfo => __Impl.IntExpression_Impl.__Info.Instance;
		public static __ModelProperty IntExpression_Value => _IntExpression_Value;
		public static __ModelProperty IntExpression_IntValue => _IntExpression_IntValue;
		public static __ModelClassInfo LAlternativeInfo => __Impl.LAlternative_Impl.__Info.Instance;
		public static __ModelProperty LAlternative_IsFixed => _LAlternative_IsFixed;
		public static __ModelProperty LAlternative_FixedText => _LAlternative_FixedText;
		public static __ModelProperty LAlternative_Elements => _LAlternative_Elements;
		public static __ModelClassInfo LanguageInfo => __Impl.Language_Impl.__Info.Instance;
		public static __ModelProperty Language_Grammar => _Language_Grammar;
		public static __ModelClassInfo LElementValueInfo => __Impl.LElementValue_Impl.__Info.Instance;
		public static __ModelProperty LElementValue_IsFixed => _LElementValue_IsFixed;
		public static __ModelProperty LElementValue_FixedText => _LElementValue_FixedText;
		public static __ModelClassInfo LBlockInfo => __Impl.LBlock_Impl.__Info.Instance;
		public static __ModelProperty LBlock_IsFixed => _LBlock_IsFixed;
		public static __ModelProperty LBlock_FixedText => _LBlock_FixedText;
		public static __ModelProperty LBlock_Alternatives => _LBlock_Alternatives;
		public static __ModelClassInfo LElementInfo => __Impl.LElement_Impl.__Info.Instance;
		public static __ModelProperty LElement_IsFixed => _LElement_IsFixed;
		public static __ModelProperty LElement_FixedText => _LElement_FixedText;
		public static __ModelProperty LElement_IsNegated => _LElement_IsNegated;
		public static __ModelProperty LElement_Value => _LElement_Value;
		public static __ModelProperty LElement_Multiplicity => _LElement_Multiplicity;
		public static __ModelClassInfo LexerRuleInfo => __Impl.LexerRule_Impl.__Info.Instance;
		public static __ModelProperty LexerRule_ReturnType => _LexerRule_ReturnType;
		public static __ModelProperty LexerRule_IsHidden => _LexerRule_IsHidden;
		public static __ModelProperty LexerRule_IsFragment => _LexerRule_IsFragment;
		public static __ModelProperty LexerRule_IsFixed => _LexerRule_IsFixed;
		public static __ModelProperty LexerRule_FixedText => _LexerRule_FixedText;
		public static __ModelProperty LexerRule_Alternatives => _LexerRule_Alternatives;
		public static __ModelClassInfo LFixedInfo => __Impl.LFixed_Impl.__Info.Instance;
		public static __ModelProperty LFixed_IsFixed => _LFixed_IsFixed;
		public static __ModelProperty LFixed_FixedText => _LFixed_FixedText;
		public static __ModelProperty LFixed_Text => _LFixed_Text;
		public static __ModelClassInfo LRangeInfo => __Impl.LRange_Impl.__Info.Instance;
		public static __ModelProperty LRange_IsFixed => _LRange_IsFixed;
		public static __ModelProperty LRange_FixedText => _LRange_FixedText;
		public static __ModelProperty LRange_StartChar => _LRange_StartChar;
		public static __ModelProperty LRange_EndChar => _LRange_EndChar;
		public static __ModelClassInfo LReferenceInfo => __Impl.LReference_Impl.__Info.Instance;
		public static __ModelProperty LReference_IsFixed => _LReference_IsFixed;
		public static __ModelProperty LReference_FixedText => _LReference_FixedText;
		public static __ModelProperty LReference_Rule => _LReference_Rule;
		public static __ModelClassInfo LSetInfo => __Impl.LSet_Impl.__Info.Instance;
		public static __ModelProperty LSet_IsFixed => _LSet_IsFixed;
		public static __ModelProperty LSet_FixedText => _LSet_FixedText;
		public static __ModelProperty LSet_Items => _LSet_Items;
		public static __ModelClassInfo LSetItemInfo => __Impl.LSetItem_Impl.__Info.Instance;
		public static __ModelProperty LSetItem_IsFixed => _LSetItem_IsFixed;
		public static __ModelProperty LSetItem_FixedText => _LSetItem_FixedText;
		public static __ModelClassInfo LSetCharInfo => __Impl.LSetChar_Impl.__Info.Instance;
		public static __ModelProperty LSetChar_IsFixed => _LSetChar_IsFixed;
		public static __ModelProperty LSetChar_FixedText => _LSetChar_FixedText;
		public static __ModelProperty LSetChar_Char => _LSetChar_Char;
		public static __ModelClassInfo LSetRangeInfo => __Impl.LSetRange_Impl.__Info.Instance;
		public static __ModelProperty LSetRange_IsFixed => _LSetRange_IsFixed;
		public static __ModelProperty LSetRange_FixedText => _LSetRange_FixedText;
		public static __ModelProperty LSetRange_StartChar => _LSetRange_StartChar;
		public static __ModelProperty LSetRange_EndChar => _LSetRange_EndChar;
		public static __ModelClassInfo LWildCardInfo => __Impl.LWildCard_Impl.__Info.Instance;
		public static __ModelProperty LWildCard_IsFixed => _LWildCard_IsFixed;
		public static __ModelProperty LWildCard_FixedText => _LWildCard_FixedText;
		public static __ModelClassInfo NamespaceInfo => __Impl.Namespace_Impl.__Info.Instance;
		public static __ModelClassInfo NullExpressionInfo => __Impl.NullExpression_Impl.__Info.Instance;
		public static __ModelProperty NullExpression_Value => _NullExpression_Value;
		public static __ModelClassInfo PAlternativeInfo => __Impl.PAlternative_Impl.__Info.Instance;
		public static __ModelProperty PAlternative_ReturnType => _PAlternative_ReturnType;
		public static __ModelProperty PAlternative_ReturnValue => _PAlternative_ReturnValue;
		public static __ModelProperty PAlternative_Elements => _PAlternative_Elements;
		public static __ModelClassInfo ParserRuleInfo => __Impl.ParserRule_Impl.__Info.Instance;
		public static __ModelProperty ParserRule_ReturnType => _ParserRule_ReturnType;
		public static __ModelProperty ParserRule_IsBlock => _ParserRule_IsBlock;
		public static __ModelProperty ParserRule_Alternatives => _ParserRule_Alternatives;
		public static __ModelClassInfo PBlockInfo => __Impl.PBlock_Impl.__Info.Instance;
		public static __ModelProperty PBlock_Alternatives => _PBlock_Alternatives;
		public static __ModelClassInfo PElementInfo => __Impl.PElement_Impl.__Info.Instance;
		public static __ModelProperty PElement_NameAnnotations => _PElement_NameAnnotations;
		public static __ModelProperty PElement_SymbolProperty => _PElement_SymbolProperty;
		public static __ModelProperty PElement_Assignment => _PElement_Assignment;
		public static __ModelProperty PElement_ValueAnnotations => _PElement_ValueAnnotations;
		public static __ModelProperty PElement_Value => _PElement_Value;
		public static __ModelProperty PElement_Multiplicity => _PElement_Multiplicity;
		public static __ModelClassInfo PElementValueInfo => __Impl.PElementValue_Impl.__Info.Instance;
		public static __ModelClassInfo PEofInfo => __Impl.PEof_Impl.__Info.Instance;
		public static __ModelClassInfo PKeywordInfo => __Impl.PKeyword_Impl.__Info.Instance;
		public static __ModelProperty PKeyword_Text => _PKeyword_Text;
		public static __ModelClassInfo PReferenceInfo => __Impl.PReference_Impl.__Info.Instance;
		public static __ModelProperty PReference_Rule => _PReference_Rule;
		public static __ModelProperty PReference_ReferencedTypes => _PReference_ReferencedTypes;
		public static __ModelClassInfo ReferenceExpressionInfo => __Impl.ReferenceExpression_Impl.__Info.Instance;
		public static __ModelProperty ReferenceExpression_Value => _ReferenceExpression_Value;
		public static __ModelProperty ReferenceExpression_SymbolValue => _ReferenceExpression_SymbolValue;
		public static __ModelClassInfo RuleInfo => __Impl.Rule_Impl.__Info.Instance;
		public static __ModelProperty Rule_Language => _Rule_Language;
		public static __ModelProperty Rule_Grammar => _Rule_Grammar;
		public static __ModelClassInfo StringExpressionInfo => __Impl.StringExpression_Impl.__Info.Instance;
		public static __ModelProperty StringExpression_Value => _StringExpression_Value;
		public static __ModelProperty StringExpression_StringValue => _StringExpression_StringValue;
	}
	
	public class CompilerModelFactory : __ModelFactory
	{
		public CompilerModelFactory(__Model model)
			: base(model, Compiler.MInstance)
		{
		}
	
		public Annotation Annotation(string? id = null)
		{
			return (Annotation)Compiler.AnnotationInfo.Create(Model, id)!;
		}
	
		public AnnotationArgument AnnotationArgument(string? id = null)
		{
			return (AnnotationArgument)Compiler.AnnotationArgumentInfo.Create(Model, id)!;
		}
	
		public ArrayExpression ArrayExpression(string? id = null)
		{
			return (ArrayExpression)Compiler.ArrayExpressionInfo.Create(Model, id)!;
		}
	
		public BoolExpression BoolExpression(string? id = null)
		{
			return (BoolExpression)Compiler.BoolExpressionInfo.Create(Model, id)!;
		}
	
		public Grammar Grammar(string? id = null)
		{
			return (Grammar)Compiler.GrammarInfo.Create(Model, id)!;
		}
	
		public IntExpression IntExpression(string? id = null)
		{
			return (IntExpression)Compiler.IntExpressionInfo.Create(Model, id)!;
		}
	
		public LAlternative LAlternative(string? id = null)
		{
			return (LAlternative)Compiler.LAlternativeInfo.Create(Model, id)!;
		}
	
		public Language Language(string? id = null)
		{
			return (Language)Compiler.LanguageInfo.Create(Model, id)!;
		}
	
		public LBlock LBlock(string? id = null)
		{
			return (LBlock)Compiler.LBlockInfo.Create(Model, id)!;
		}
	
		public LElement LElement(string? id = null)
		{
			return (LElement)Compiler.LElementInfo.Create(Model, id)!;
		}
	
		public LexerRule LexerRule(string? id = null)
		{
			return (LexerRule)Compiler.LexerRuleInfo.Create(Model, id)!;
		}
	
		public LFixed LFixed(string? id = null)
		{
			return (LFixed)Compiler.LFixedInfo.Create(Model, id)!;
		}
	
		public LRange LRange(string? id = null)
		{
			return (LRange)Compiler.LRangeInfo.Create(Model, id)!;
		}
	
		public LReference LReference(string? id = null)
		{
			return (LReference)Compiler.LReferenceInfo.Create(Model, id)!;
		}
	
		public LSet LSet(string? id = null)
		{
			return (LSet)Compiler.LSetInfo.Create(Model, id)!;
		}
	
		public LSetChar LSetChar(string? id = null)
		{
			return (LSetChar)Compiler.LSetCharInfo.Create(Model, id)!;
		}
	
		public LSetRange LSetRange(string? id = null)
		{
			return (LSetRange)Compiler.LSetRangeInfo.Create(Model, id)!;
		}
	
		public LWildCard LWildCard(string? id = null)
		{
			return (LWildCard)Compiler.LWildCardInfo.Create(Model, id)!;
		}
	
		public Namespace Namespace(string? id = null)
		{
			return (Namespace)Compiler.NamespaceInfo.Create(Model, id)!;
		}
	
		public NullExpression NullExpression(string? id = null)
		{
			return (NullExpression)Compiler.NullExpressionInfo.Create(Model, id)!;
		}
	
		public PAlternative PAlternative(string? id = null)
		{
			return (PAlternative)Compiler.PAlternativeInfo.Create(Model, id)!;
		}
	
		public PBlock PBlock(string? id = null)
		{
			return (PBlock)Compiler.PBlockInfo.Create(Model, id)!;
		}
	
		public PElement PElement(string? id = null)
		{
			return (PElement)Compiler.PElementInfo.Create(Model, id)!;
		}
	
		public PEof PEof(string? id = null)
		{
			return (PEof)Compiler.PEofInfo.Create(Model, id)!;
		}
	
		public PKeyword PKeyword(string? id = null)
		{
			return (PKeyword)Compiler.PKeywordInfo.Create(Model, id)!;
		}
	
		public PReference PReference(string? id = null)
		{
			return (PReference)Compiler.PReferenceInfo.Create(Model, id)!;
		}
	
		public ReferenceExpression ReferenceExpression(string? id = null)
		{
			return (ReferenceExpression)Compiler.ReferenceExpressionInfo.Create(Model, id)!;
		}
	
		public StringExpression StringExpression(string? id = null)
		{
			return (StringExpression)Compiler.StringExpressionInfo.Create(Model, id)!;
		}
	
	}
	
	public class CompilerModelMultiFactory : __MultiModelFactory
	{
		public CompilerModelMultiFactory()
			: base(new __MetaModel[] { Compiler.MInstance })
		{
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
	
		public BoolExpression BoolExpression(__Model model, string? id = null)
		{
			return (BoolExpression)Compiler.BoolExpressionInfo.Create(model, id)!;
		}
	
		public Grammar Grammar(__Model model, string? id = null)
		{
			return (Grammar)Compiler.GrammarInfo.Create(model, id)!;
		}
	
		public IntExpression IntExpression(__Model model, string? id = null)
		{
			return (IntExpression)Compiler.IntExpressionInfo.Create(model, id)!;
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
	
		public LexerRule LexerRule(__Model model, string? id = null)
		{
			return (LexerRule)Compiler.LexerRuleInfo.Create(model, id)!;
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
	
		public Namespace Namespace(__Model model, string? id = null)
		{
			return (Namespace)Compiler.NamespaceInfo.Create(model, id)!;
		}
	
		public NullExpression NullExpression(__Model model, string? id = null)
		{
			return (NullExpression)Compiler.NullExpressionInfo.Create(model, id)!;
		}
	
		public PAlternative PAlternative(__Model model, string? id = null)
		{
			return (PAlternative)Compiler.PAlternativeInfo.Create(model, id)!;
		}
	
		public PBlock PBlock(__Model model, string? id = null)
		{
			return (PBlock)Compiler.PBlockInfo.Create(model, id)!;
		}
	
		public PElement PElement(__Model model, string? id = null)
		{
			return (PElement)Compiler.PElementInfo.Create(model, id)!;
		}
	
		public PEof PEof(__Model model, string? id = null)
		{
			return (PEof)Compiler.PEofInfo.Create(model, id)!;
		}
	
		public PKeyword PKeyword(__Model model, string? id = null)
		{
			return (PKeyword)Compiler.PKeywordInfo.Create(model, id)!;
		}
	
		public PReference PReference(__Model model, string? id = null)
		{
			return (PReference)Compiler.PReferenceInfo.Create(model, id)!;
		}
	
		public ReferenceExpression ReferenceExpression(__Model model, string? id = null)
		{
			return (ReferenceExpression)Compiler.ReferenceExpressionInfo.Create(model, id)!;
		}
	
		public StringExpression StringExpression(__Model model, string? id = null)
		{
			return (StringExpression)Compiler.StringExpressionInfo.Create(model, id)!;
		}
	
	}
	

	public enum Assignment
	{
		Assign,
		QuestionAssign,
		NegatedAssign,
		PlusAssign,
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


	public interface Annotation : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<AnnotationArgument> Arguments { get; }
		__MetaType Type { get; set; }
	
	}

	public interface AnnotationArgument : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<__MetaSymbol> NamedParameter { get; }
		Expression Value { get; set; }
	
	}

	public interface ArrayExpression : global::MetaDslx.Bootstrap.MetaCompiler.Model.Expression
	{
		global::System.Collections.Generic.IList<Expression> Items { get; }
		new object? Value { get; }
	
	}

	public interface BoolExpression : global::MetaDslx.Bootstrap.MetaCompiler.Model.Expression
	{
		bool BoolValue { get; set; }
		new object? Value { get; }
	
	}

	public interface Declaration : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Annotation> Annotations { get; }
		global::System.Collections.Generic.IList<Declaration> Declarations { get; }
		string? FullName { get; }
		string? Name { get; set; }
		Declaration? Parent { get; set; }
	
	}

	public interface Expression : __IModelObjectCore
	{
		object? Value { get; }
	
	}

	public interface Grammar : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		Language Language { get; set; }
		global::System.Collections.Generic.IList<Rule> Rules { get; }
	
	}

	public interface IntExpression : global::MetaDslx.Bootstrap.MetaCompiler.Model.Expression
	{
		int IntValue { get; set; }
		new object? Value { get; }
	
	}

	public interface LAlternative : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<LElement> Elements { get; }
		string? FixedText { get; }
		bool IsFixed { get; }
	
	}

	public interface Language : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		Grammar Grammar { get; set; }
	
	}

	public interface LElementValue : __IModelObjectCore
	{
		string? FixedText { get; }
		bool IsFixed { get; }
	
	}

	public interface LBlock : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		global::System.Collections.Generic.IList<LAlternative> Alternatives { get; }
		new string? FixedText { get; }
		new bool IsFixed { get; }
	
	}

	public interface LElement : __IModelObjectCore
	{
		string? FixedText { get; }
		bool IsFixed { get; }
		bool IsNegated { get; set; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
		LElementValue Value { get; set; }
	
	}

	public interface LexerRule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Rule
	{
		global::System.Collections.Generic.IList<LAlternative> Alternatives { get; }
		string? FixedText { get; }
		bool IsFixed { get; }
		bool IsFragment { get; set; }
		bool IsHidden { get; set; }
		__MetaType ReturnType { get; set; }
	
	}

	public interface LFixed : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		new string? FixedText { get; }
		new bool IsFixed { get; }
		string Text { get; set; }
	
	}

	public interface LRange : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		string EndChar { get; set; }
		new string? FixedText { get; }
		new bool IsFixed { get; }
		string StartChar { get; set; }
	
	}

	public interface LReference : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		new string? FixedText { get; }
		new bool IsFixed { get; }
		LexerRule Rule { get; set; }
	
	}

	public interface LSet : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		new string? FixedText { get; }
		new bool IsFixed { get; }
		global::System.Collections.Generic.IList<LSetItem> Items { get; }
	
	}

	public interface LSetItem : __IModelObjectCore
	{
		string? FixedText { get; }
		bool IsFixed { get; }
	
	}

	public interface LSetChar : global::MetaDslx.Bootstrap.MetaCompiler.Model.LSetItem
	{
		string Char { get; set; }
		new string? FixedText { get; }
		new bool IsFixed { get; }
	
	}

	public interface LSetRange : global::MetaDslx.Bootstrap.MetaCompiler.Model.LSetItem
	{
		string EndChar { get; set; }
		new string? FixedText { get; }
		new bool IsFixed { get; }
		string StartChar { get; set; }
	
	}

	public interface LWildCard : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		new string? FixedText { get; }
		new bool IsFixed { get; }
	
	}

	public interface Namespace : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
	
	}

	public interface NullExpression : global::MetaDslx.Bootstrap.MetaCompiler.Model.Expression
	{
		new object? Value { get; }
	
	}

	public interface PAlternative : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		global::System.Collections.Generic.IList<PElement> Elements { get; }
		__MetaType? ReturnType { get; set; }
		Expression ReturnValue { get; set; }
	
	}

	public interface ParserRule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Rule
	{
		global::System.Collections.Generic.IList<PAlternative> Alternatives { get; }
		bool IsBlock { get; set; }
		__MetaType? ReturnType { get; set; }
	
	}

	public interface PBlock : global::MetaDslx.Bootstrap.MetaCompiler.Model.PElementValue
	{
		global::System.Collections.Generic.IList<PAlternative> Alternatives { get; }
	
	}

	public interface PElement : __IModelObjectCore
	{
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment { get; set; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
		global::System.Collections.Generic.IList<Annotation> NameAnnotations { get; }
		global::System.Collections.Generic.IList<__MetaSymbol> SymbolProperty { get; }
		PElementValue Value { get; set; }
		global::System.Collections.Generic.IList<Annotation> ValueAnnotations { get; }
	
	}

	public interface PElementValue : __IModelObjectCore
	{
	
	}

	public interface PEof : global::MetaDslx.Bootstrap.MetaCompiler.Model.PElementValue
	{
	
	}

	public interface PKeyword : global::MetaDslx.Bootstrap.MetaCompiler.Model.PElementValue
	{
		string Text { get; set; }
	
	}

	public interface PReference : global::MetaDslx.Bootstrap.MetaCompiler.Model.PElementValue
	{
		global::System.Collections.Generic.IList<__MetaType> ReferencedTypes { get; }
		Rule Rule { get; set; }
	
	}

	public interface ReferenceExpression : global::MetaDslx.Bootstrap.MetaCompiler.Model.Expression
	{
		__MetaSymbol? SymbolValue { get; set; }
		new object? Value { get; }
	
	}

	public interface Rule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		Grammar Grammar { get; set; }
		Language Language { get; }
	
	}

	public interface StringExpression : global::MetaDslx.Bootstrap.MetaCompiler.Model.Expression
	{
		string StringValue { get; set; }
		new object? Value { get; }
	
	}


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
		/// Constructor for the class BoolExpression
		/// </summary>
		void BoolExpression(BoolExpression _this);
	
		/// <summary>
		/// Constructor for the class Declaration
		/// </summary>
		void Declaration(Declaration _this);
	
		/// <summary>
		/// Constructor for the class Expression
		/// </summary>
		void Expression(Expression _this);
	
		/// <summary>
		/// Constructor for the class Grammar
		/// </summary>
		void Grammar(Grammar _this);
	
		/// <summary>
		/// Constructor for the class IntExpression
		/// </summary>
		void IntExpression(IntExpression _this);
	
		/// <summary>
		/// Constructor for the class LAlternative
		/// </summary>
		void LAlternative(LAlternative _this);
	
		/// <summary>
		/// Constructor for the class Language
		/// </summary>
		void Language(Language _this);
	
		/// <summary>
		/// Constructor for the class LElementValue
		/// </summary>
		void LElementValue(LElementValue _this);
	
		/// <summary>
		/// Constructor for the class LBlock
		/// </summary>
		void LBlock(LBlock _this);
	
		/// <summary>
		/// Constructor for the class LElement
		/// </summary>
		void LElement(LElement _this);
	
		/// <summary>
		/// Constructor for the class LexerRule
		/// </summary>
		void LexerRule(LexerRule _this);
	
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
		/// Constructor for the class NullExpression
		/// </summary>
		void NullExpression(NullExpression _this);
	
		/// <summary>
		/// Constructor for the class PAlternative
		/// </summary>
		void PAlternative(PAlternative _this);
	
		/// <summary>
		/// Constructor for the class ParserRule
		/// </summary>
		void ParserRule(ParserRule _this);
	
		/// <summary>
		/// Constructor for the class PBlock
		/// </summary>
		void PBlock(PBlock _this);
	
		/// <summary>
		/// Constructor for the class PElement
		/// </summary>
		void PElement(PElement _this);
	
		/// <summary>
		/// Constructor for the class PElementValue
		/// </summary>
		void PElementValue(PElementValue _this);
	
		/// <summary>
		/// Constructor for the class PEof
		/// </summary>
		void PEof(PEof _this);
	
		/// <summary>
		/// Constructor for the class PKeyword
		/// </summary>
		void PKeyword(PKeyword _this);
	
		/// <summary>
		/// Constructor for the class PReference
		/// </summary>
		void PReference(PReference _this);
	
		/// <summary>
		/// Constructor for the class ReferenceExpression
		/// </summary>
		void ReferenceExpression(ReferenceExpression _this);
	
		/// <summary>
		/// Constructor for the class Rule
		/// </summary>
		void Rule(Rule _this);
	
		/// <summary>
		/// Constructor for the class StringExpression
		/// </summary>
		void StringExpression(StringExpression _this);
	
	
		/// <summary>
		/// Computation of the derived property ArrayExpression.Value
		/// </summary>
		object? ArrayExpression_Value(ArrayExpression _this);
	
		/// <summary>
		/// Computation of the derived property BoolExpression.Value
		/// </summary>
		object? BoolExpression_Value(BoolExpression _this);
	
		/// <summary>
		/// Computation of the derived property Declaration.FullName
		/// </summary>
		string? Declaration_FullName(Declaration _this);
	
		/// <summary>
		/// Computation of the derived property Expression.Value
		/// </summary>
		object? Expression_Value(Expression _this);
	
		/// <summary>
		/// Computation of the derived property IntExpression.Value
		/// </summary>
		object? IntExpression_Value(IntExpression _this);
	
		/// <summary>
		/// Computation of the derived property LAlternative.IsFixed
		/// </summary>
		bool LAlternative_IsFixed(LAlternative _this);
	
		/// <summary>
		/// Computation of the derived property LAlternative.FixedText
		/// </summary>
		string? LAlternative_FixedText(LAlternative _this);
	
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
		/// Computation of the derived property LElement.IsFixed
		/// </summary>
		bool LElement_IsFixed(LElement _this);
	
		/// <summary>
		/// Computation of the derived property LElement.FixedText
		/// </summary>
		string? LElement_FixedText(LElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRule.IsFixed
		/// </summary>
		bool LexerRule_IsFixed(LexerRule _this);
	
		/// <summary>
		/// Computation of the derived property LexerRule.FixedText
		/// </summary>
		string? LexerRule_FixedText(LexerRule _this);
	
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
		/// Computation of the derived property NullExpression.Value
		/// </summary>
		object? NullExpression_Value(NullExpression _this);
	
		/// <summary>
		/// Computation of the derived property ReferenceExpression.Value
		/// </summary>
		object? ReferenceExpression_Value(ReferenceExpression _this);
	
		/// <summary>
		/// Computation of the derived property Rule.Language
		/// </summary>
		Language Rule_Language(Rule _this);
	
		/// <summary>
		/// Computation of the derived property StringExpression.Value
		/// </summary>
		object? StringExpression_Value(StringExpression _this);
	
	
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
		/// Constructor for the class BoolExpression
		/// </summary>
		public virtual void BoolExpression(BoolExpression _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Declaration
		/// </summary>
		public virtual void Declaration(Declaration _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Expression
		/// </summary>
		public virtual void Expression(Expression _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Grammar
		/// </summary>
		public virtual void Grammar(Grammar _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class IntExpression
		/// </summary>
		public virtual void IntExpression(IntExpression _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LAlternative
		/// </summary>
		public virtual void LAlternative(LAlternative _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Language
		/// </summary>
		public virtual void Language(Language _this)
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
		/// Constructor for the class LElement
		/// </summary>
		public virtual void LElement(LElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LexerRule
		/// </summary>
		public virtual void LexerRule(LexerRule _this)
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
		/// Constructor for the class NullExpression
		/// </summary>
		public virtual void NullExpression(NullExpression _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class PAlternative
		/// </summary>
		public virtual void PAlternative(PAlternative _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ParserRule
		/// </summary>
		public virtual void ParserRule(ParserRule _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class PBlock
		/// </summary>
		public virtual void PBlock(PBlock _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class PElement
		/// </summary>
		public virtual void PElement(PElement _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class PElementValue
		/// </summary>
		public virtual void PElementValue(PElementValue _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class PEof
		/// </summary>
		public virtual void PEof(PEof _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class PKeyword
		/// </summary>
		public virtual void PKeyword(PKeyword _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class PReference
		/// </summary>
		public virtual void PReference(PReference _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ReferenceExpression
		/// </summary>
		public virtual void ReferenceExpression(ReferenceExpression _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Rule
		/// </summary>
		public virtual void Rule(Rule _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class StringExpression
		/// </summary>
		public virtual void StringExpression(StringExpression _this)
		{
		}
	
	
		/// <summary>
		/// Computation of the derived property ArrayExpression.Value
		/// </summary>
		public abstract object? ArrayExpression_Value(ArrayExpression _this);
	
		/// <summary>
		/// Computation of the derived property BoolExpression.Value
		/// </summary>
		public abstract object? BoolExpression_Value(BoolExpression _this);
	
		/// <summary>
		/// Computation of the derived property Declaration.FullName
		/// </summary>
		public abstract string? Declaration_FullName(Declaration _this);
	
		/// <summary>
		/// Computation of the derived property Expression.Value
		/// </summary>
		public abstract object? Expression_Value(Expression _this);
	
		/// <summary>
		/// Computation of the derived property IntExpression.Value
		/// </summary>
		public abstract object? IntExpression_Value(IntExpression _this);
	
		/// <summary>
		/// Computation of the derived property LAlternative.IsFixed
		/// </summary>
		public abstract bool LAlternative_IsFixed(LAlternative _this);
	
		/// <summary>
		/// Computation of the derived property LAlternative.FixedText
		/// </summary>
		public abstract string? LAlternative_FixedText(LAlternative _this);
	
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
		/// Computation of the derived property LElement.IsFixed
		/// </summary>
		public abstract bool LElement_IsFixed(LElement _this);
	
		/// <summary>
		/// Computation of the derived property LElement.FixedText
		/// </summary>
		public abstract string? LElement_FixedText(LElement _this);
	
		/// <summary>
		/// Computation of the derived property LexerRule.IsFixed
		/// </summary>
		public abstract bool LexerRule_IsFixed(LexerRule _this);
	
		/// <summary>
		/// Computation of the derived property LexerRule.FixedText
		/// </summary>
		public abstract string? LexerRule_FixedText(LexerRule _this);
	
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
		/// Computation of the derived property NullExpression.Value
		/// </summary>
		public abstract object? NullExpression_Value(NullExpression _this);
	
		/// <summary>
		/// Computation of the derived property ReferenceExpression.Value
		/// </summary>
		public abstract object? ReferenceExpression_Value(ReferenceExpression _this);
	
		/// <summary>
		/// Computation of the derived property Rule.Language
		/// </summary>
		public abstract Language Rule_Language(Rule _this);
	
		/// <summary>
		/// Computation of the derived property StringExpression.Value
		/// </summary>
		public abstract object? StringExpression_Value(StringExpression _this);
	
	
	}
}

namespace MetaDslx.Bootstrap.MetaCompiler.Model.__Impl
{
	using __Model = global::MetaDslx.Modeling.Model;
	using __MetaModel = global::MetaDslx.Modeling.MetaModel;
	using __IModelObject = global::MetaDslx.Modeling.IModelObject;
	using __IModelObjectCore = global::MetaDslx.Modeling.IModelObjectCore;
	using __MetaModelObject = global::MetaDslx.Modeling.MetaModelObject;
	using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
	using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
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
	using __Enum = global::System.Enum;

	internal class __Assignment_Info : __ModelEnumInfo
	{
		public static readonly __Assignment_Info Instance = new __Assignment_Info();
	
		private readonly global::System.Collections.Immutable.ImmutableArray<string> _literals;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> _literalsByName;
	
		private __Assignment_Info()
		{
			_literals = __ImmutableArray.Create<string>("Assign", "QuestionAssign", "NegatedAssign", "PlusAssign");
			var literalsByName = __ImmutableDictionary.CreateBuilder<string, __MetaSymbol>();
			literalsByName.Add("Assign", __MetaSymbol.FromValue(Assignment.Assign));
			literalsByName.Add("QuestionAssign", __MetaSymbol.FromValue(Assignment.QuestionAssign));
			literalsByName.Add("NegatedAssign", __MetaSymbol.FromValue(Assignment.NegatedAssign));
			literalsByName.Add("PlusAssign", __MetaSymbol.FromValue(Assignment.PlusAssign));
			_literalsByName = literalsByName.ToImmutable();
		}
	
	    public override __MetaModel MetaModel => Compiler.MInstance;
	    public override __MetaType MetaType => typeof(Assignment);
		public override global::System.Collections.Immutable.ImmutableArray<string> Literals => _literals;
		protected override global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> LiteralsByName => _literalsByName;
	}

	internal class __Multiplicity_Info : __ModelEnumInfo
	{
		public static readonly __Multiplicity_Info Instance = new __Multiplicity_Info();
	
		private readonly global::System.Collections.Immutable.ImmutableArray<string> _literals;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> _literalsByName;
	
		private __Multiplicity_Info()
		{
			_literals = __ImmutableArray.Create<string>("ExactlyOne", "ZeroOrOne", "ZeroOrMore", "OneOrMore", "NonGreedyZeroOrOne", "NonGreedyZeroOrMore", "NonGreedyOneOrMore");
			var literalsByName = __ImmutableDictionary.CreateBuilder<string, __MetaSymbol>();
			literalsByName.Add("ExactlyOne", __MetaSymbol.FromValue(Multiplicity.ExactlyOne));
			literalsByName.Add("ZeroOrOne", __MetaSymbol.FromValue(Multiplicity.ZeroOrOne));
			literalsByName.Add("ZeroOrMore", __MetaSymbol.FromValue(Multiplicity.ZeroOrMore));
			literalsByName.Add("OneOrMore", __MetaSymbol.FromValue(Multiplicity.OneOrMore));
			literalsByName.Add("NonGreedyZeroOrOne", __MetaSymbol.FromValue(Multiplicity.NonGreedyZeroOrOne));
			literalsByName.Add("NonGreedyZeroOrMore", __MetaSymbol.FromValue(Multiplicity.NonGreedyZeroOrMore));
			literalsByName.Add("NonGreedyOneOrMore", __MetaSymbol.FromValue(Multiplicity.NonGreedyOneOrMore));
			_literalsByName = literalsByName.ToImmutable();
		}
	
	    public override __MetaModel MetaModel => Compiler.MInstance;
	    public override __MetaType MetaType => typeof(Multiplicity);
		public override global::System.Collections.Immutable.ImmutableArray<string> Literals => _literals;
		protected override global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> LiteralsByName => _literalsByName;
	}


	internal class Annotation_Impl : __MetaModelObject, Annotation
	{
		private Annotation_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.Annotation_Arguments, new global::MetaDslx.Modeling.ModelObjectList<AnnotationArgument>(this, __Info.Instance.GetSlot(Compiler.Annotation_Arguments)!));
			Compiler.__CustomImpl.Annotation(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<AnnotationArgument> Arguments
		{
			get => MGetCollection<AnnotationArgument>(Compiler.Annotation_Arguments);
		}
	
		public __MetaType Type
		{
			get => MGet<__MetaType>(Compiler.Annotation_Type);
			set => MAdd<__MetaType>(Compiler.Annotation_Type, value);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
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
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(Annotation);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.AnnotationSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => Compiler.Annotation_Type;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
			((__IModelObject)this).Init(Compiler.AnnotationArgument_NamedParameter, new global::MetaDslx.Modeling.ModelObjectList<__MetaSymbol>(this, __Info.Instance.GetSlot(Compiler.AnnotationArgument_NamedParameter)!));
			Compiler.__CustomImpl.AnnotationArgument(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<__MetaSymbol> NamedParameter
		{
			get => MGetCollection<__MetaSymbol>(Compiler.AnnotationArgument_NamedParameter);
		}
	
		public Expression Value
		{
			get => MGet<Expression>(Compiler.AnnotationArgument_Value);
			set => MAdd<Expression>(Compiler.AnnotationArgument_Value, value);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("NamedParameter", Compiler.AnnotationArgument_NamedParameter);
				publicPropertiesByName.Add("Value", Compiler.AnnotationArgument_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.AnnotationArgument_NamedParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_NamedParameter, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.AnnotationArgument_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(AnnotationArgument);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.AnnotationArgumentSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

	internal class ArrayExpression_Impl : __MetaModelObject, ArrayExpression
	{
		private ArrayExpression_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.ArrayExpression_Items, new global::MetaDslx.Modeling.ModelObjectList<Expression>(this, __Info.Instance.GetSlot(Compiler.ArrayExpression_Items)!));
			Compiler.__CustomImpl.Expression(this);
			Compiler.__CustomImpl.ArrayExpression(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Expression> Items
		{
			get => MGetCollection<Expression>(Compiler.ArrayExpression_Items);
		}
	
		public object? Value
		{
			get => Compiler.__CustomImpl.ArrayExpression_Value(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		object? Expression.Value
		{
			get => Compiler.__CustomImpl.ArrayExpression_Value(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items, Compiler.ArrayExpression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items, Compiler.ArrayExpression_Value, Compiler.Expression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items, Compiler.ArrayExpression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Items", Compiler.ArrayExpression_Items);
				publicPropertiesByName.Add("Value", Compiler.ArrayExpression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ArrayExpression_Items, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ArrayExpression_Items, __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ArrayExpression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ArrayExpression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Expression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Expression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Value)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(ArrayExpression);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new ArrayExpression_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ArrayExpressionInfo";
			}
		}
	}

	internal class BoolExpression_Impl : __MetaModelObject, BoolExpression
	{
		private BoolExpression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Expression(this);
			Compiler.__CustomImpl.BoolExpression(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public bool BoolValue
		{
			get => MGet<bool>(Compiler.BoolExpression_BoolValue);
			set => MAdd<bool>(Compiler.BoolExpression_BoolValue, value);
		}
	
		public object? Value
		{
			get => Compiler.__CustomImpl.BoolExpression_Value(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		object? Expression.Value
		{
			get => Compiler.__CustomImpl.BoolExpression_Value(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.BoolExpression_BoolValue, Compiler.BoolExpression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.BoolExpression_BoolValue, Compiler.BoolExpression_Value, Compiler.Expression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.BoolExpression_BoolValue, Compiler.BoolExpression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("BoolValue", Compiler.BoolExpression_BoolValue);
				publicPropertiesByName.Add("Value", Compiler.BoolExpression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.BoolExpression_BoolValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.BoolExpression_BoolValue, __ImmutableArray.Create<__ModelProperty>(Compiler.BoolExpression_BoolValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.BoolExpression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.BoolExpression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.BoolExpression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Expression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Expression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.BoolExpression_Value)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(BoolExpression);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

	internal class Declaration_Impl : __MetaModelObject, Declaration
	{
		private Declaration_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
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
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
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
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(Declaration);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

	internal class Expression_Impl : __MetaModelObject, Expression
	{
		private Expression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Expression(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public object? Value
		{
			get => Compiler.__CustomImpl.Expression_Value(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
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
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(Expression);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
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
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(Grammar);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.GrammarSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

	internal class IntExpression_Impl : __MetaModelObject, IntExpression
	{
		private IntExpression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Expression(this);
			Compiler.__CustomImpl.IntExpression(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public int IntValue
		{
			get => MGet<int>(Compiler.IntExpression_IntValue);
			set => MAdd<int>(Compiler.IntExpression_IntValue, value);
		}
	
		public object? Value
		{
			get => Compiler.__CustomImpl.IntExpression_Value(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		object? Expression.Value
		{
			get => Compiler.__CustomImpl.IntExpression_Value(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.IntExpression_IntValue, Compiler.IntExpression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.IntExpression_IntValue, Compiler.IntExpression_Value, Compiler.Expression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.IntExpression_IntValue, Compiler.IntExpression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("IntValue", Compiler.IntExpression_IntValue);
				publicPropertiesByName.Add("Value", Compiler.IntExpression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.IntExpression_IntValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.IntExpression_IntValue, __ImmutableArray.Create<__ModelProperty>(Compiler.IntExpression_IntValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.IntExpression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.IntExpression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.IntExpression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Expression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Expression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.IntExpression_Value)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(IntExpression);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

	internal class LAlternative_Impl : __MetaModelObject, LAlternative
	{
		private LAlternative_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.LAlternative_Elements, new global::MetaDslx.Modeling.ModelObjectList<LElement>(this, __Info.Instance.GetSlot(Compiler.LAlternative_Elements)!));
			Compiler.__CustomImpl.LAlternative(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<LElement> Elements
		{
			get => MGetCollection<LElement>(Compiler.LAlternative_Elements);
		}
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LAlternative_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LAlternative_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_Elements, Compiler.LAlternative_FixedText, Compiler.LAlternative_IsFixed);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_Elements, Compiler.LAlternative_FixedText, Compiler.LAlternative_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_Elements, Compiler.LAlternative_FixedText, Compiler.LAlternative_IsFixed);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Elements", Compiler.LAlternative_Elements);
				publicPropertiesByName.Add("FixedText", Compiler.LAlternative_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LAlternative_IsFixed);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LAlternative_Elements, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LAlternative_Elements, __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_Elements), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LAlternative_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LAlternative_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LAlternative_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LAlternative_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LAlternative);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LAlternative_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LAlternativeInfo";
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
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
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
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(Language);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

	internal class LElementValue_Impl : __MetaModelObject, LElementValue
	{
		private LElementValue_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElementValue(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LElementValue_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LElementValue_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LElementValue_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LElementValue_IsFixed);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LElementValue);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LElementValue_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LElementValueInfo";
			}
		}
	}

	internal class LBlock_Impl : __MetaModelObject, LBlock
	{
		private LBlock_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.LBlock_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<LAlternative>(this, __Info.Instance.GetSlot(Compiler.LBlock_Alternatives)!));
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LBlock(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<LAlternative> Alternatives
		{
			get => MGetCollection<LAlternative>(Compiler.LBlock_Alternatives);
		}
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LBlock_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LBlock_IsFixed(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LElementValue.FixedText
		{
			get => Compiler.__CustomImpl.LBlock_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LElementValue.IsFixed
		{
			get => Compiler.__CustomImpl.LBlock_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_Alternatives, Compiler.LBlock_FixedText, Compiler.LBlock_IsFixed);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_Alternatives, Compiler.LBlock_FixedText, Compiler.LBlock_IsFixed, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_Alternatives, Compiler.LBlock_FixedText, Compiler.LBlock_IsFixed);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Compiler.LBlock_Alternatives);
				publicPropertiesByName.Add("FixedText", Compiler.LBlock_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LBlock_IsFixed);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LBlock_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LBlock_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LBlock_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LBlock_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LBlock_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LBlock_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_IsFixed)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LBlock);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LBlock_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LBlockInfo";
			}
		}
	}

	internal class LElement_Impl : __MetaModelObject, LElement
	{
		private LElement_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElement(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LElement_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LElement_IsFixed(this);
		}
	
		public bool IsNegated
		{
			get => MGet<bool>(Compiler.LElement_IsNegated);
			set => MAdd<bool>(Compiler.LElement_IsNegated, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LElement_Multiplicity, value);
		}
	
		public LElementValue Value
		{
			get => MGet<LElementValue>(Compiler.LElement_Value);
			set => MAdd<LElementValue>(Compiler.LElement_Value, value);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_FixedText, Compiler.LElement_IsFixed, Compiler.LElement_IsNegated, Compiler.LElement_Multiplicity, Compiler.LElement_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_FixedText, Compiler.LElement_IsFixed, Compiler.LElement_IsNegated, Compiler.LElement_Multiplicity, Compiler.LElement_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_FixedText, Compiler.LElement_IsFixed, Compiler.LElement_IsNegated, Compiler.LElement_Multiplicity, Compiler.LElement_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LElement_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LElement_IsFixed);
				publicPropertiesByName.Add("IsNegated", Compiler.LElement_IsNegated);
				publicPropertiesByName.Add("Multiplicity", Compiler.LElement_Multiplicity);
				publicPropertiesByName.Add("Value", Compiler.LElement_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElement_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_IsNegated, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElement_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LElement);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LElementInfo";
			}
		}
	}

	internal class LexerRule_Impl : __MetaModelObject, LexerRule
	{
		private LexerRule_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.LexerRule_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<LAlternative>(this, __Info.Instance.GetSlot(Compiler.LexerRule_Alternatives)!));
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Rule(this);
			Compiler.__CustomImpl.LexerRule(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<LAlternative> Alternatives
		{
			get => MGetCollection<LAlternative>(Compiler.LexerRule_Alternatives);
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
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.RuleInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.RuleInfo, Compiler.DeclarationInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LexerRule);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

	internal class LFixed_Impl : __MetaModelObject, LFixed
	{
		private LFixed_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LFixed(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LFixed_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LFixed_IsFixed(this);
		}
	
		public string Text
		{
			get => MGet<string>(Compiler.LFixed_Text);
			set => MAdd<string>(Compiler.LFixed_Text, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LElementValue.FixedText
		{
			get => Compiler.__CustomImpl.LFixed_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LElementValue.IsFixed
		{
			get => Compiler.__CustomImpl.LFixed_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText, Compiler.LFixed_IsFixed, Compiler.LFixed_Text);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText, Compiler.LFixed_IsFixed, Compiler.LFixed_Text, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText, Compiler.LFixed_IsFixed, Compiler.LFixed_Text);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LFixed_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LFixed_IsFixed);
				publicPropertiesByName.Add("Text", Compiler.LFixed_Text);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LFixed_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LFixed_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LFixed_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LFixed_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LFixed_Text, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LFixed_Text, __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_Text), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_IsFixed)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LFixed);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LFixed_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LFixedInfo";
			}
		}
	}

	internal class LRange_Impl : __MetaModelObject, LRange
	{
		private LRange_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LRange(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string EndChar
		{
			get => MGet<string>(Compiler.LRange_EndChar);
			set => MAdd<string>(Compiler.LRange_EndChar, value);
		}
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LRange_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LRange_IsFixed(this);
		}
	
		public string StartChar
		{
			get => MGet<string>(Compiler.LRange_StartChar);
			set => MAdd<string>(Compiler.LRange_StartChar, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LElementValue.FixedText
		{
			get => Compiler.__CustomImpl.LRange_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LElementValue.IsFixed
		{
			get => Compiler.__CustomImpl.LRange_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar, Compiler.LRange_FixedText, Compiler.LRange_IsFixed, Compiler.LRange_StartChar);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar, Compiler.LRange_FixedText, Compiler.LRange_IsFixed, Compiler.LRange_StartChar, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar, Compiler.LRange_FixedText, Compiler.LRange_IsFixed, Compiler.LRange_StartChar);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("EndChar", Compiler.LRange_EndChar);
				publicPropertiesByName.Add("FixedText", Compiler.LRange_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LRange_IsFixed);
				publicPropertiesByName.Add("StartChar", Compiler.LRange_StartChar);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LRange_EndChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_EndChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LRange_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LRange_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LRange_StartChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_StartChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_StartChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_IsFixed)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LRange);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LRange_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LRangeInfo";
			}
		}
	}

	internal class LReference_Impl : __MetaModelObject, LReference
	{
		private LReference_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LReference(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LReference_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LReference_IsFixed(this);
		}
	
		public LexerRule Rule
		{
			get => MGet<LexerRule>(Compiler.LReference_Rule);
			set => MAdd<LexerRule>(Compiler.LReference_Rule, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LElementValue.FixedText
		{
			get => Compiler.__CustomImpl.LReference_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LElementValue.IsFixed
		{
			get => Compiler.__CustomImpl.LReference_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText, Compiler.LReference_IsFixed, Compiler.LReference_Rule);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText, Compiler.LReference_IsFixed, Compiler.LReference_Rule, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText, Compiler.LReference_IsFixed, Compiler.LReference_Rule);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LReference_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LReference_IsFixed);
				publicPropertiesByName.Add("Rule", Compiler.LReference_Rule);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LReference_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LReference_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LReference_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LReference_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LReference_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LReference_Rule, __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_IsFixed)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LReference);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LReference_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LReferenceInfo";
			}
		}
	}

	internal class LSet_Impl : __MetaModelObject, LSet
	{
		private LSet_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.LSet_Items, new global::MetaDslx.Modeling.ModelObjectList<LSetItem>(this, __Info.Instance.GetSlot(Compiler.LSet_Items)!));
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LSet(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LSet_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LSet_IsFixed(this);
		}
	
		public global::System.Collections.Generic.IList<LSetItem> Items
		{
			get => MGetCollection<LSetItem>(Compiler.LSet_Items);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LElementValue.FixedText
		{
			get => Compiler.__CustomImpl.LSet_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LElementValue.IsFixed
		{
			get => Compiler.__CustomImpl.LSet_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText, Compiler.LSet_IsFixed, Compiler.LSet_Items);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText, Compiler.LSet_IsFixed, Compiler.LSet_Items, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText, Compiler.LSet_IsFixed, Compiler.LSet_Items);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LSet_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LSet_IsFixed);
				publicPropertiesByName.Add("Items", Compiler.LSet_Items);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LSet_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSet_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSet_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSet_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSet_Items, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSet_Items, __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_Items), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_IsFixed)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LSet);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LSet_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LSetInfo";
			}
		}
	}

	internal class LSetItem_Impl : __MetaModelObject, LSetItem
	{
		private LSetItem_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LSetItem(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LSetItem_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LSetItem_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText, Compiler.LSetItem_IsFixed);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText, Compiler.LSetItem_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText, Compiler.LSetItem_IsFixed);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LSetItem_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LSetItem_IsFixed);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LSetItem);
	
	        public override __MetaType SymbolType => default;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LSetItem_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LSetItemInfo";
			}
		}
	}

	internal class LSetChar_Impl : __MetaModelObject, LSetChar
	{
		private LSetChar_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LSetItem(this);
			Compiler.__CustomImpl.LSetChar(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string Char
		{
			get => MGet<string>(Compiler.LSetChar_Char);
			set => MAdd<string>(Compiler.LSetChar_Char, value);
		}
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LSetChar_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LSetChar_IsFixed(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LSetItem.FixedText
		{
			get => Compiler.__CustomImpl.LSetChar_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LSetItem.IsFixed
		{
			get => Compiler.__CustomImpl.LSetChar_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LSetItemInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LSetItemInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_Char, Compiler.LSetChar_FixedText, Compiler.LSetChar_IsFixed);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_Char, Compiler.LSetChar_FixedText, Compiler.LSetChar_IsFixed, Compiler.LSetItem_FixedText, Compiler.LSetItem_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_Char, Compiler.LSetChar_FixedText, Compiler.LSetChar_IsFixed);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Char", Compiler.LSetChar_Char);
				publicPropertiesByName.Add("FixedText", Compiler.LSetChar_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LSetChar_IsFixed);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LSetChar_Char, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetChar_Char, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_Char), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetChar_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetChar_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetChar_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetChar_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_FixedText)));
				modelPropertyInfos.Add(Compiler.LSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_IsFixed)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LSetChar);
	
	        public override __MetaType SymbolType => default;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LSetChar_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LSetCharInfo";
			}
		}
	}

	internal class LSetRange_Impl : __MetaModelObject, LSetRange
	{
		private LSetRange_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LSetItem(this);
			Compiler.__CustomImpl.LSetRange(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string EndChar
		{
			get => MGet<string>(Compiler.LSetRange_EndChar);
			set => MAdd<string>(Compiler.LSetRange_EndChar, value);
		}
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LSetRange_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LSetRange_IsFixed(this);
		}
	
		public string StartChar
		{
			get => MGet<string>(Compiler.LSetRange_StartChar);
			set => MAdd<string>(Compiler.LSetRange_StartChar, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LSetItem.FixedText
		{
			get => Compiler.__CustomImpl.LSetRange_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LSetItem.IsFixed
		{
			get => Compiler.__CustomImpl.LSetRange_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LSetItemInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LSetItemInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_EndChar, Compiler.LSetRange_FixedText, Compiler.LSetRange_IsFixed, Compiler.LSetRange_StartChar);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_EndChar, Compiler.LSetRange_FixedText, Compiler.LSetRange_IsFixed, Compiler.LSetRange_StartChar, Compiler.LSetItem_FixedText, Compiler.LSetItem_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_EndChar, Compiler.LSetRange_FixedText, Compiler.LSetRange_IsFixed, Compiler.LSetRange_StartChar);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("EndChar", Compiler.LSetRange_EndChar);
				publicPropertiesByName.Add("FixedText", Compiler.LSetRange_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LSetRange_IsFixed);
				publicPropertiesByName.Add("StartChar", Compiler.LSetRange_StartChar);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LSetRange_EndChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_EndChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_EndChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetRange_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetRange_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetRange_StartChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_StartChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_StartChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_FixedText)));
				modelPropertyInfos.Add(Compiler.LSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_IsFixed)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LSetRange);
	
	        public override __MetaType SymbolType => default;
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LSetRange_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LSetRangeInfo";
			}
		}
	}

	internal class LWildCard_Impl : __MetaModelObject, LWildCard
	{
		private LWildCard_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LWildCard(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LWildCard_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LWildCard_IsFixed(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? LElementValue.FixedText
		{
			get => Compiler.__CustomImpl.LWildCard_FixedText(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		bool LElementValue.IsFixed
		{
			get => Compiler.__CustomImpl.LWildCard_IsFixed(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText, Compiler.LWildCard_IsFixed);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText, Compiler.LWildCard_IsFixed, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText, Compiler.LWildCard_IsFixed);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Compiler.LWildCard_FixedText);
				publicPropertiesByName.Add("IsFixed", Compiler.LWildCard_IsFixed);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LWildCard_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LWildCard_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LWildCard_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LWildCard_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_IsFixed)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(LWildCard);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new LWildCard_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LWildCardInfo";
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
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
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
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(Namespace);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

	internal class NullExpression_Impl : __MetaModelObject, NullExpression
	{
		private NullExpression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Expression(this);
			Compiler.__CustomImpl.NullExpression(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public object? Value
		{
			get => Compiler.__CustomImpl.NullExpression_Value(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		object? Expression.Value
		{
			get => Compiler.__CustomImpl.NullExpression_Value(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.NullExpression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.NullExpression_Value, Compiler.Expression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.NullExpression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Value", Compiler.NullExpression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.NullExpression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.NullExpression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.NullExpression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Expression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Expression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.NullExpression_Value)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(NullExpression);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

	internal class PAlternative_Impl : __MetaModelObject, PAlternative
	{
		private PAlternative_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.PAlternative_Elements, new global::MetaDslx.Modeling.ModelObjectList<PElement>(this, __Info.Instance.GetSlot(Compiler.PAlternative_Elements)!));
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.PAlternative(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<PElement> Elements
		{
			get => MGetCollection<PElement>(Compiler.PAlternative_Elements);
		}
	
		public __MetaType? ReturnType
		{
			get => MGet<__MetaType?>(Compiler.PAlternative_ReturnType);
			set => MAdd<__MetaType?>(Compiler.PAlternative_ReturnType, value);
		}
	
		public Expression ReturnValue
		{
			get => MGet<Expression>(Compiler.PAlternative_ReturnValue);
			set => MAdd<Expression>(Compiler.PAlternative_ReturnValue, value);
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
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PAlternative_Elements, Compiler.PAlternative_ReturnType, Compiler.PAlternative_ReturnValue);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PAlternative_Elements, Compiler.PAlternative_ReturnType, Compiler.PAlternative_ReturnValue, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PAlternative_Elements, Compiler.PAlternative_ReturnType, Compiler.PAlternative_ReturnValue, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Elements", Compiler.PAlternative_Elements);
				publicPropertiesByName.Add("ReturnType", Compiler.PAlternative_ReturnType);
				publicPropertiesByName.Add("ReturnValue", Compiler.PAlternative_ReturnValue);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.PAlternative_Elements, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PAlternative_Elements, __ImmutableArray.Create<__ModelProperty>(Compiler.PAlternative_Elements), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PAlternative_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PAlternative_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.PAlternative_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PAlternative_ReturnValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PAlternative_ReturnValue, __ImmutableArray.Create<__ModelProperty>(Compiler.PAlternative_ReturnValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(PAlternative);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PAlternativeSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new PAlternative_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.PAlternativeInfo";
			}
		}
	}

	internal class ParserRule_Impl : __MetaModelObject, ParserRule
	{
		private ParserRule_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.ParserRule_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<PAlternative>(this, __Info.Instance.GetSlot(Compiler.ParserRule_Alternatives)!));
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Rule(this);
			Compiler.__CustomImpl.ParserRule(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<PAlternative> Alternatives
		{
			get => MGetCollection<PAlternative>(Compiler.ParserRule_Alternatives);
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
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.RuleInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.RuleInfo, Compiler.DeclarationInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(ParserRule);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ParserRuleSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

	internal class PBlock_Impl : __MetaModelObject, PBlock
	{
		private PBlock_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.PBlock_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<PAlternative>(this, __Info.Instance.GetSlot(Compiler.PBlock_Alternatives)!));
			Compiler.__CustomImpl.PElementValue(this);
			Compiler.__CustomImpl.PBlock(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<PAlternative> Alternatives
		{
			get => MGetCollection<PAlternative>(Compiler.PBlock_Alternatives);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.PElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.PElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PBlock_Alternatives);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PBlock_Alternatives);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PBlock_Alternatives);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Compiler.PBlock_Alternatives);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.PBlock_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PBlock_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.PBlock_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(PBlock);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PBlockSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new PBlock_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.PBlockInfo";
			}
		}
	}

	internal class PElement_Impl : __MetaModelObject, PElement
	{
		private PElement_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.PElement_NameAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.PElement_NameAnnotations)!));
			((__IModelObject)this).Init(Compiler.PElement_SymbolProperty, new global::MetaDslx.Modeling.ModelObjectList<__MetaSymbol>(this, __Info.Instance.GetSlot(Compiler.PElement_SymbolProperty)!));
			((__IModelObject)this).Init(Compiler.PElement_ValueAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.PElement_ValueAnnotations)!));
			Compiler.__CustomImpl.PElement(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment>(Compiler.PElement_Assignment);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment>(Compiler.PElement_Assignment, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.PElement_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.PElement_Multiplicity, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> NameAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.PElement_NameAnnotations);
		}
	
		public global::System.Collections.Generic.IList<__MetaSymbol> SymbolProperty
		{
			get => MGetCollection<__MetaSymbol>(Compiler.PElement_SymbolProperty);
		}
	
		public PElementValue Value
		{
			get => MGet<PElementValue>(Compiler.PElement_Value);
			set => MAdd<PElementValue>(Compiler.PElement_Value, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> ValueAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.PElement_ValueAnnotations);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Assignment, Compiler.PElement_Multiplicity, Compiler.PElement_NameAnnotations, Compiler.PElement_SymbolProperty, Compiler.PElement_Value, Compiler.PElement_ValueAnnotations);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Assignment, Compiler.PElement_Multiplicity, Compiler.PElement_NameAnnotations, Compiler.PElement_SymbolProperty, Compiler.PElement_Value, Compiler.PElement_ValueAnnotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Assignment, Compiler.PElement_Multiplicity, Compiler.PElement_NameAnnotations, Compiler.PElement_SymbolProperty, Compiler.PElement_Value, Compiler.PElement_ValueAnnotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Assignment", Compiler.PElement_Assignment);
				publicPropertiesByName.Add("Multiplicity", Compiler.PElement_Multiplicity);
				publicPropertiesByName.Add("NameAnnotations", Compiler.PElement_NameAnnotations);
				publicPropertiesByName.Add("SymbolProperty", Compiler.PElement_SymbolProperty);
				publicPropertiesByName.Add("Value", Compiler.PElement_Value);
				publicPropertiesByName.Add("ValueAnnotations", Compiler.PElement_ValueAnnotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.PElement_Assignment, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_Assignment, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_NameAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_NameAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_NameAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_SymbolProperty, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_SymbolProperty, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_SymbolProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_ValueAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_ValueAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_ValueAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(PElement);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PElementSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new PElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.PElementInfo";
			}
		}
	}

	internal class PElementValue_Impl : __MetaModelObject, PElementValue
	{
		private PElementValue_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.PElementValue(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_publicProperties = __ImmutableArray.Create<__ModelProperty>();
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(PElementValue);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new PElementValue_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.PElementValueInfo";
			}
		}
	}

	internal class PEof_Impl : __MetaModelObject, PEof
	{
		private PEof_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.PElementValue(this);
			Compiler.__CustomImpl.PEof(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.PElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.PElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_publicProperties = __ImmutableArray.Create<__ModelProperty>();
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(PEof);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new PEof_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.PEofInfo";
			}
		}
	}

	internal class PKeyword_Impl : __MetaModelObject, PKeyword
	{
		private PKeyword_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.PElementValue(this);
			Compiler.__CustomImpl.PKeyword(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string Text
		{
			get => MGet<string>(Compiler.PKeyword_Text);
			set => MAdd<string>(Compiler.PKeyword_Text, value);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.PElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.PElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PKeyword_Text);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PKeyword_Text);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PKeyword_Text);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Text", Compiler.PKeyword_Text);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.PKeyword_Text, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PKeyword_Text, __ImmutableArray.Create<__ModelProperty>(Compiler.PKeyword_Text), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(PKeyword);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new PKeyword_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.PKeywordInfo";
			}
		}
	}

	internal class PReference_Impl : __MetaModelObject, PReference
	{
		private PReference_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.PReference_ReferencedTypes, new global::MetaDslx.Modeling.ModelObjectList<__MetaType>(this, __Info.Instance.GetSlot(Compiler.PReference_ReferencedTypes)!));
			Compiler.__CustomImpl.PElementValue(this);
			Compiler.__CustomImpl.PReference(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<__MetaType> ReferencedTypes
		{
			get => MGetCollection<__MetaType>(Compiler.PReference_ReferencedTypes);
		}
	
		public Rule Rule
		{
			get => MGet<Rule>(Compiler.PReference_Rule);
			set => MAdd<Rule>(Compiler.PReference_Rule, value);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.PElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.PElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PReference_ReferencedTypes, Compiler.PReference_Rule);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PReference_ReferencedTypes, Compiler.PReference_Rule);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PReference_ReferencedTypes, Compiler.PReference_Rule);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("ReferencedTypes", Compiler.PReference_ReferencedTypes);
				publicPropertiesByName.Add("Rule", Compiler.PReference_Rule);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.PReference_ReferencedTypes, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PReference_ReferencedTypes, __ImmutableArray.Create<__ModelProperty>(Compiler.PReference_ReferencedTypes), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PReference_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PReference_Rule, __ImmutableArray.Create<__ModelProperty>(Compiler.PReference_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(PReference);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PReferenceSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
				var result = new PReference_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.PReferenceInfo";
			}
		}
	}

	internal class ReferenceExpression_Impl : __MetaModelObject, ReferenceExpression
	{
		private ReferenceExpression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Expression(this);
			Compiler.__CustomImpl.ReferenceExpression(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public __MetaSymbol? SymbolValue
		{
			get => MGet<__MetaSymbol?>(Compiler.ReferenceExpression_SymbolValue);
			set => MAdd<__MetaSymbol?>(Compiler.ReferenceExpression_SymbolValue, value);
		}
	
		public object? Value
		{
			get => Compiler.__CustomImpl.ReferenceExpression_Value(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		object? Expression.Value
		{
			get => Compiler.__CustomImpl.ReferenceExpression_Value(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ReferenceExpression_SymbolValue, Compiler.ReferenceExpression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ReferenceExpression_SymbolValue, Compiler.ReferenceExpression_Value, Compiler.Expression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ReferenceExpression_SymbolValue, Compiler.ReferenceExpression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("SymbolValue", Compiler.ReferenceExpression_SymbolValue);
				publicPropertiesByName.Add("Value", Compiler.ReferenceExpression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ReferenceExpression_SymbolValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ReferenceExpression_SymbolValue, __ImmutableArray.Create<__ModelProperty>(Compiler.ReferenceExpression_SymbolValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ReferenceExpression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ReferenceExpression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.ReferenceExpression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Expression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Expression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ReferenceExpression_Value)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(ReferenceExpression);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
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
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(Rule);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

	internal class StringExpression_Impl : __MetaModelObject, StringExpression
	{
		private StringExpression_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Expression(this);
			Compiler.__CustomImpl.StringExpression(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string StringValue
		{
			get => MGet<string>(Compiler.StringExpression_StringValue);
			set => MAdd<string>(Compiler.StringExpression_StringValue, value);
		}
	
		public object? Value
		{
			get => Compiler.__CustomImpl.StringExpression_Value(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		object? Expression.Value
		{
			get => Compiler.__CustomImpl.StringExpression_Value(this);
		}
	
	
	
		internal class __Info : __ModelClassInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.StringExpression_StringValue, Compiler.StringExpression_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.StringExpression_StringValue, Compiler.StringExpression_Value, Compiler.Expression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.StringExpression_StringValue, Compiler.StringExpression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("StringValue", Compiler.StringExpression_StringValue);
				publicPropertiesByName.Add("Value", Compiler.StringExpression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.StringExpression_StringValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.StringExpression_StringValue, __ImmutableArray.Create<__ModelProperty>(Compiler.StringExpression_StringValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.StringExpression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.StringExpression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.StringExpression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Expression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Expression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.StringExpression_Value)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.MInstance;
	        public override __MetaType MetaType => typeof(StringExpression);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
	        public override __ModelProperty? NameProperty => null;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
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

}
