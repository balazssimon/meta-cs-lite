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
		private static readonly __ModelProperty _AnnotationArgument_Name;
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
		private static readonly __ModelProperty _PElement_Name;
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
			_AnnotationArgument_Name = new __ModelProperty(typeof(AnnotationArgument), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_AnnotationArgument_Value = new __ModelProperty(typeof(AnnotationArgument), "Value", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_Rule_Grammar = new __ModelProperty(typeof(Rule), "Grammar", typeof(Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Rule_Language = new __ModelProperty(typeof(Rule), "Language", typeof(Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRule_Alternatives = new __ModelProperty(typeof(LexerRule), "Alternatives", typeof(LAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LexerRule_FixedText = new __ModelProperty(typeof(LexerRule), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRule_IsFixed = new __ModelProperty(typeof(LexerRule), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRule_IsFragment = new __ModelProperty(typeof(LexerRule), "IsFragment", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRule_IsHidden = new __ModelProperty(typeof(LexerRule), "IsHidden", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LexerRule_ReturnType = new __ModelProperty(typeof(LexerRule), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LAlternative_Elements = new __ModelProperty(typeof(LAlternative), "Elements", typeof(LElement), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LAlternative_FixedText = new __ModelProperty(typeof(LAlternative), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LAlternative_IsFixed = new __ModelProperty(typeof(LAlternative), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElement_FixedText = new __ModelProperty(typeof(LElement), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElement_IsFixed = new __ModelProperty(typeof(LElement), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElement_IsNegated = new __ModelProperty(typeof(LElement), "IsNegated", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LElement_Multiplicity = new __ModelProperty(typeof(LElement), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.SingleItem, null);
			_LElement_Value = new __ModelProperty(typeof(LElement), "Value", typeof(LElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_LElementValue_FixedText = new __ModelProperty(typeof(LElementValue), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElementValue_IsFixed = new __ModelProperty(typeof(LElementValue), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LReference_FixedText = new __ModelProperty(typeof(LReference), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LReference_IsFixed = new __ModelProperty(typeof(LReference), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LReference_Rule = new __ModelProperty(typeof(LReference), "Rule", typeof(LexerRule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_LFixed_FixedText = new __ModelProperty(typeof(LFixed), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LFixed_IsFixed = new __ModelProperty(typeof(LFixed), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LFixed_Text = new __ModelProperty(typeof(LFixed), "Text", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LWildCard_FixedText = new __ModelProperty(typeof(LWildCard), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LWildCard_IsFixed = new __ModelProperty(typeof(LWildCard), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LRange_EndChar = new __ModelProperty(typeof(LRange), "EndChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_LRange_FixedText = new __ModelProperty(typeof(LRange), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LRange_IsFixed = new __ModelProperty(typeof(LRange), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LRange_StartChar = new __ModelProperty(typeof(LRange), "StartChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
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
			_LBlock_Alternatives = new __ModelProperty(typeof(LBlock), "Alternatives", typeof(LAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LBlock_FixedText = new __ModelProperty(typeof(LBlock), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LBlock_IsFixed = new __ModelProperty(typeof(LBlock), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_ParserRule_Alternatives = new __ModelProperty(typeof(ParserRule), "Alternatives", typeof(PAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_ParserRule_IsBlock = new __ModelProperty(typeof(ParserRule), "IsBlock", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_ParserRule_ReturnType = new __ModelProperty(typeof(ParserRule), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_PAlternative_Elements = new __ModelProperty(typeof(PAlternative), "Elements", typeof(PElement), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_PAlternative_ReturnType = new __ModelProperty(typeof(PAlternative), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_PAlternative_ReturnValue = new __ModelProperty(typeof(PAlternative), "ReturnValue", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_PElement_Assignment = new __ModelProperty(typeof(PElement), "Assignment", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.SingleItem, null);
			_PElement_Multiplicity = new __ModelProperty(typeof(PElement), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.SingleItem, null);
			_PElement_Name = new __ModelProperty(typeof(PElement), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.Name, "Name");
			_PElement_NameAnnotations = new __ModelProperty(typeof(PElement), "NameAnnotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_PElement_Value = new __ModelProperty(typeof(PElement), "Value", typeof(PElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_PElement_ValueAnnotations = new __ModelProperty(typeof(PElement), "ValueAnnotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_PReference_ReferencedTypes = new __ModelProperty(typeof(PReference), "ReferencedTypes", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, null);
			_PReference_Rule = new __ModelProperty(typeof(PReference), "Rule", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_PKeyword_Text = new __ModelProperty(typeof(PKeyword), "Text", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_PBlock_Alternatives = new __ModelProperty(typeof(PBlock), "Alternatives", typeof(PAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
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
			_modelObjectTypes = __ImmutableArray.Create<__Type>(typeof(Declaration), typeof(Namespace), typeof(Language), typeof(Grammar), typeof(Annotation), typeof(AnnotationArgument), typeof(Rule), typeof(LexerRule), typeof(LAlternative), typeof(LElement), typeof(LElementValue), typeof(LReference), typeof(LFixed), typeof(LWildCard), typeof(LRange), typeof(LSet), typeof(LSetItem), typeof(LSetChar), typeof(LSetRange), typeof(LBlock), typeof(ParserRule), typeof(PAlternative), typeof(PElement), typeof(PElementValue), typeof(PReference), typeof(PEof), typeof(PKeyword), typeof(PBlock), typeof(Expression), typeof(NullExpression), typeof(BoolExpression), typeof(IntExpression), typeof(StringExpression), typeof(ReferenceExpression));
			_modelObjectInfos = __ImmutableArray.Create<__ModelObjectInfo>(DeclarationInfo, NamespaceInfo, LanguageInfo, GrammarInfo, AnnotationInfo, AnnotationArgumentInfo, RuleInfo, LexerRuleInfo, LAlternativeInfo, LElementInfo, LElementValueInfo, LReferenceInfo, LFixedInfo, LWildCardInfo, LRangeInfo, LSetInfo, LSetItemInfo, LSetCharInfo, LSetRangeInfo, LBlockInfo, ParserRuleInfo, PAlternativeInfo, PElementInfo, PElementValueInfo, PReferenceInfo, PEofInfo, PKeywordInfo, PBlockInfo, ExpressionInfo, NullExpressionInfo, BoolExpressionInfo, IntExpressionInfo, StringExpressionInfo, ReferenceExpressionInfo);
			var modelObjectInfosByType = __ImmutableDictionary.CreateBuilder<__Type, __ModelObjectInfo>();
			modelObjectInfosByType.Add(typeof(Declaration), DeclarationInfo);
			modelObjectInfosByType.Add(typeof(Namespace), NamespaceInfo);
			modelObjectInfosByType.Add(typeof(Language), LanguageInfo);
			modelObjectInfosByType.Add(typeof(Grammar), GrammarInfo);
			modelObjectInfosByType.Add(typeof(Annotation), AnnotationInfo);
			modelObjectInfosByType.Add(typeof(AnnotationArgument), AnnotationArgumentInfo);
			modelObjectInfosByType.Add(typeof(Rule), RuleInfo);
			modelObjectInfosByType.Add(typeof(LexerRule), LexerRuleInfo);
			modelObjectInfosByType.Add(typeof(LAlternative), LAlternativeInfo);
			modelObjectInfosByType.Add(typeof(LElement), LElementInfo);
			modelObjectInfosByType.Add(typeof(LElementValue), LElementValueInfo);
			modelObjectInfosByType.Add(typeof(LReference), LReferenceInfo);
			modelObjectInfosByType.Add(typeof(LFixed), LFixedInfo);
			modelObjectInfosByType.Add(typeof(LWildCard), LWildCardInfo);
			modelObjectInfosByType.Add(typeof(LRange), LRangeInfo);
			modelObjectInfosByType.Add(typeof(LSet), LSetInfo);
			modelObjectInfosByType.Add(typeof(LSetItem), LSetItemInfo);
			modelObjectInfosByType.Add(typeof(LSetChar), LSetCharInfo);
			modelObjectInfosByType.Add(typeof(LSetRange), LSetRangeInfo);
			modelObjectInfosByType.Add(typeof(LBlock), LBlockInfo);
			modelObjectInfosByType.Add(typeof(ParserRule), ParserRuleInfo);
			modelObjectInfosByType.Add(typeof(PAlternative), PAlternativeInfo);
			modelObjectInfosByType.Add(typeof(PElement), PElementInfo);
			modelObjectInfosByType.Add(typeof(PElementValue), PElementValueInfo);
			modelObjectInfosByType.Add(typeof(PReference), PReferenceInfo);
			modelObjectInfosByType.Add(typeof(PEof), PEofInfo);
			modelObjectInfosByType.Add(typeof(PKeyword), PKeywordInfo);
			modelObjectInfosByType.Add(typeof(PBlock), PBlockInfo);
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
			modelObjectInfosByName.Add("LAlternative", LAlternativeInfo);
			modelObjectInfosByName.Add("LElement", LElementInfo);
			modelObjectInfosByName.Add("LElementValue", LElementValueInfo);
			modelObjectInfosByName.Add("LReference", LReferenceInfo);
			modelObjectInfosByName.Add("LFixed", LFixedInfo);
			modelObjectInfosByName.Add("LWildCard", LWildCardInfo);
			modelObjectInfosByName.Add("LRange", LRangeInfo);
			modelObjectInfosByName.Add("LSet", LSetInfo);
			modelObjectInfosByName.Add("LSetItem", LSetItemInfo);
			modelObjectInfosByName.Add("LSetChar", LSetCharInfo);
			modelObjectInfosByName.Add("LSetRange", LSetRangeInfo);
			modelObjectInfosByName.Add("LBlock", LBlockInfo);
			modelObjectInfosByName.Add("ParserRule", ParserRuleInfo);
			modelObjectInfosByName.Add("PAlternative", PAlternativeInfo);
			modelObjectInfosByName.Add("PElement", PElementInfo);
			modelObjectInfosByName.Add("PElementValue", PElementValueInfo);
			modelObjectInfosByName.Add("PReference", PReferenceInfo);
			modelObjectInfosByName.Add("PEof", PEofInfo);
			modelObjectInfosByName.Add("PKeyword", PKeywordInfo);
			modelObjectInfosByName.Add("PBlock", PBlockInfo);
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
			var obj29 = f.MetaClass();
			var obj30 = f.MetaEnumType();
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
			var obj43 = f.MetaProperty();
			var obj44 = f.MetaProperty();
			var obj45 = f.MetaProperty();
			var obj46 = f.MetaProperty();
			var obj47 = f.MetaProperty();
			var obj48 = f.MetaArrayType();
			var obj49 = f.MetaNullableType();
			var obj50 = f.MetaNullableType();
			var obj51 = f.MetaArrayType();
			var obj52 = f.MetaNullableType();
			var obj53 = f.MetaProperty();
			var obj54 = f.MetaProperty();
			var obj55 = f.MetaProperty();
			var obj56 = f.MetaArrayType();
			var obj57 = f.MetaProperty();
			var obj58 = f.MetaProperty();
			var obj59 = f.MetaArrayType();
			var obj60 = f.MetaProperty();
			var obj61 = f.MetaProperty();
			var obj62 = f.MetaEnumLiteral();
			var obj63 = f.MetaEnumLiteral();
			var obj64 = f.MetaEnumLiteral();
			var obj65 = f.MetaEnumLiteral();
			var obj66 = f.MetaEnumLiteral();
			var obj67 = f.MetaEnumLiteral();
			var obj68 = f.MetaEnumLiteral();
			var obj69 = f.MetaProperty();
			var obj70 = f.MetaProperty();
			var obj71 = f.MetaProperty();
			var obj72 = f.MetaProperty();
			var obj73 = f.MetaProperty();
			var obj74 = f.MetaProperty();
			var obj75 = f.MetaProperty();
			var obj76 = f.MetaProperty();
			var obj77 = f.MetaNullableType();
			var obj78 = f.MetaArrayType();
			var obj79 = f.MetaProperty();
			var obj80 = f.MetaProperty();
			var obj81 = f.MetaProperty();
			var obj82 = f.MetaNullableType();
			var obj83 = f.MetaArrayType();
			var obj84 = f.MetaProperty();
			var obj85 = f.MetaProperty();
			var obj86 = f.MetaProperty();
			var obj87 = f.MetaProperty();
			var obj88 = f.MetaProperty();
			var obj89 = f.MetaNullableType();
			var obj90 = f.MetaProperty();
			var obj91 = f.MetaProperty();
			var obj92 = f.MetaNullableType();
			var obj93 = f.MetaProperty();
			var obj94 = f.MetaProperty();
			var obj95 = f.MetaProperty();
			var obj96 = f.MetaNullableType();
			var obj97 = f.MetaProperty();
			var obj98 = f.MetaProperty();
			var obj99 = f.MetaProperty();
			var obj100 = f.MetaNullableType();
			var obj101 = f.MetaProperty();
			var obj102 = f.MetaProperty();
			var obj103 = f.MetaNullableType();
			var obj104 = f.MetaProperty();
			var obj105 = f.MetaProperty();
			var obj106 = f.MetaProperty();
			var obj107 = f.MetaProperty();
			var obj108 = f.MetaNullableType();
			var obj109 = f.MetaProperty();
			var obj110 = f.MetaProperty();
			var obj111 = f.MetaProperty();
			var obj112 = f.MetaNullableType();
			var obj113 = f.MetaArrayType();
			var obj114 = f.MetaProperty();
			var obj115 = f.MetaProperty();
			var obj116 = f.MetaNullableType();
			var obj117 = f.MetaProperty();
			var obj118 = f.MetaProperty();
			var obj119 = f.MetaProperty();
			var obj120 = f.MetaNullableType();
			var obj121 = f.MetaProperty();
			var obj122 = f.MetaProperty();
			var obj123 = f.MetaProperty();
			var obj124 = f.MetaProperty();
			var obj125 = f.MetaNullableType();
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
			var obj136 = f.MetaProperty();
			var obj137 = f.MetaProperty();
			var obj138 = f.MetaProperty();
			var obj139 = f.MetaNullableType();
			var obj140 = f.MetaArrayType();
			var obj141 = f.MetaEnumLiteral();
			var obj142 = f.MetaEnumLiteral();
			var obj143 = f.MetaEnumLiteral();
			var obj144 = f.MetaEnumLiteral();
			var obj145 = f.MetaProperty();
			var obj146 = f.MetaProperty();
			var obj147 = f.MetaProperty();
			var obj148 = f.MetaProperty();
			var obj149 = f.MetaProperty();
			var obj150 = f.MetaProperty();
			var obj151 = f.MetaArrayType();
			var obj152 = f.MetaNullableType();
			var obj153 = f.MetaArrayType();
			var obj154 = f.MetaProperty();
			var obj155 = f.MetaProperty();
			var obj156 = f.MetaArrayType();
			var obj157 = f.MetaProperty();
			var obj158 = f.MetaProperty();
			var obj159 = f.MetaArrayType();
			var obj160 = f.MetaProperty();
			var obj161 = f.MetaNullableType();
			var obj162 = f.MetaProperty();
			var obj163 = f.MetaNullableType();
			var obj164 = f.MetaProperty();
			var obj165 = f.MetaProperty();
			var obj166 = f.MetaNullableType();
			var obj167 = f.MetaProperty();
			var obj168 = f.MetaProperty();
			var obj169 = f.MetaNullableType();
			var obj170 = f.MetaProperty();
			var obj171 = f.MetaProperty();
			var obj172 = f.MetaNullableType();
			var obj173 = f.MetaProperty();
			var obj174 = f.MetaProperty();
			var obj175 = f.MetaNullableType();
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
			obj5.Name = "Model";
			obj5.Parent = obj4;
			obj6.Name = "Compiler";
			obj6.Parent = obj5;
			((__IModelObject)obj7).Children.Add((__IModelObject)obj43);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj44);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj45);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj46);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj47);
			obj7.IsAbstract = true;
			obj7.Properties.Add(obj43);
			obj7.Properties.Add(obj44);
			obj7.Properties.Add(obj45);
			obj7.Properties.Add(obj46);
			obj7.Properties.Add(obj47);
			obj7.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
			obj7.Declarations.Add(obj43);
			obj7.Declarations.Add(obj44);
			obj7.Declarations.Add(obj45);
			obj7.Declarations.Add(obj46);
			obj7.Declarations.Add(obj47);
			obj7.Name = "Declaration";
			obj7.Parent = obj5;
			obj8.BaseTypes.Add(obj7);
			obj8.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
			obj8.Name = "Namespace";
			obj8.Parent = obj5;
			((__IModelObject)obj9).Children.Add((__IModelObject)obj53);
			obj9.BaseTypes.Add(obj7);
			obj9.Properties.Add(obj53);
			obj9.Declarations.Add(obj53);
			obj9.Name = "Language";
			obj9.Parent = obj5;
			((__IModelObject)obj10).Children.Add((__IModelObject)obj54);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj55);
			obj10.BaseTypes.Add(obj7);
			obj10.Properties.Add(obj54);
			obj10.Properties.Add(obj55);
			obj10.Declarations.Add(obj54);
			obj10.Declarations.Add(obj55);
			obj10.Name = "Grammar";
			obj10.Parent = obj5;
			((__IModelObject)obj11).Children.Add((__IModelObject)obj57);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj58);
			obj11.Properties.Add(obj57);
			obj11.Properties.Add(obj58);
			obj11.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj11.Declarations.Add(obj57);
			obj11.Declarations.Add(obj58);
			obj11.Name = "Annotation";
			obj11.Parent = obj5;
			((__IModelObject)obj12).Children.Add((__IModelObject)obj60);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj61);
			obj12.Properties.Add(obj60);
			obj12.Properties.Add(obj61);
			obj12.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj12.Declarations.Add(obj60);
			obj12.Declarations.Add(obj61);
			obj12.Name = "AnnotationArgument";
			obj12.Parent = obj5;
			((__IModelObject)obj13).Children.Add((__IModelObject)obj62);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj63);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj64);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj65);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj66);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj67);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj68);
			obj13.Literals.Add(obj62);
			obj13.Literals.Add(obj63);
			obj13.Literals.Add(obj64);
			obj13.Literals.Add(obj65);
			obj13.Literals.Add(obj66);
			obj13.Literals.Add(obj67);
			obj13.Literals.Add(obj68);
			obj13.Declarations.Add(obj62);
			obj13.Declarations.Add(obj63);
			obj13.Declarations.Add(obj64);
			obj13.Declarations.Add(obj65);
			obj13.Declarations.Add(obj66);
			obj13.Declarations.Add(obj67);
			obj13.Declarations.Add(obj68);
			obj13.Name = "Multiplicity";
			obj13.Parent = obj5;
			((__IModelObject)obj14).Children.Add((__IModelObject)obj69);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj70);
			obj14.BaseTypes.Add(obj7);
			obj14.IsAbstract = true;
			obj14.Properties.Add(obj69);
			obj14.Properties.Add(obj70);
			obj14.Declarations.Add(obj69);
			obj14.Declarations.Add(obj70);
			obj14.Name = "Rule";
			obj14.Parent = obj5;
			((__IModelObject)obj15).Children.Add((__IModelObject)obj71);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj72);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj73);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj74);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj75);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj76);
			obj15.BaseTypes.Add(obj14);
			obj15.Properties.Add(obj71);
			obj15.Properties.Add(obj72);
			obj15.Properties.Add(obj73);
			obj15.Properties.Add(obj74);
			obj15.Properties.Add(obj75);
			obj15.Properties.Add(obj76);
			obj15.Declarations.Add(obj71);
			obj15.Declarations.Add(obj72);
			obj15.Declarations.Add(obj73);
			obj15.Declarations.Add(obj74);
			obj15.Declarations.Add(obj75);
			obj15.Declarations.Add(obj76);
			obj15.Name = "LexerRule";
			obj15.Parent = obj5;
			((__IModelObject)obj16).Children.Add((__IModelObject)obj79);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj80);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj81);
			obj16.Properties.Add(obj79);
			obj16.Properties.Add(obj80);
			obj16.Properties.Add(obj81);
			obj16.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj16.Declarations.Add(obj79);
			obj16.Declarations.Add(obj80);
			obj16.Declarations.Add(obj81);
			obj16.Name = "LAlternative";
			obj16.Parent = obj5;
			((__IModelObject)obj17).Children.Add((__IModelObject)obj84);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj85);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj86);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj87);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj88);
			obj17.Properties.Add(obj84);
			obj17.Properties.Add(obj85);
			obj17.Properties.Add(obj86);
			obj17.Properties.Add(obj87);
			obj17.Properties.Add(obj88);
			obj17.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj17.Declarations.Add(obj84);
			obj17.Declarations.Add(obj85);
			obj17.Declarations.Add(obj86);
			obj17.Declarations.Add(obj87);
			obj17.Declarations.Add(obj88);
			obj17.Name = "LElement";
			obj17.Parent = obj5;
			((__IModelObject)obj18).Children.Add((__IModelObject)obj90);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj91);
			obj18.IsAbstract = true;
			obj18.Properties.Add(obj90);
			obj18.Properties.Add(obj91);
			obj18.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj18.Declarations.Add(obj90);
			obj18.Declarations.Add(obj91);
			obj18.Name = "LElementValue";
			obj18.Parent = obj5;
			((__IModelObject)obj19).Children.Add((__IModelObject)obj93);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj94);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj95);
			obj19.BaseTypes.Add(obj18);
			obj19.Properties.Add(obj93);
			obj19.Properties.Add(obj94);
			obj19.Properties.Add(obj95);
			obj19.Declarations.Add(obj93);
			obj19.Declarations.Add(obj94);
			obj19.Declarations.Add(obj95);
			obj19.Name = "LReference";
			obj19.Parent = obj5;
			((__IModelObject)obj20).Children.Add((__IModelObject)obj97);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj98);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj99);
			obj20.BaseTypes.Add(obj18);
			obj20.Properties.Add(obj97);
			obj20.Properties.Add(obj98);
			obj20.Properties.Add(obj99);
			obj20.Declarations.Add(obj97);
			obj20.Declarations.Add(obj98);
			obj20.Declarations.Add(obj99);
			obj20.Name = "LFixed";
			obj20.Parent = obj5;
			((__IModelObject)obj21).Children.Add((__IModelObject)obj101);
			((__IModelObject)obj21).Children.Add((__IModelObject)obj102);
			obj21.BaseTypes.Add(obj18);
			obj21.Properties.Add(obj101);
			obj21.Properties.Add(obj102);
			obj21.Declarations.Add(obj101);
			obj21.Declarations.Add(obj102);
			obj21.Name = "LWildCard";
			obj21.Parent = obj5;
			((__IModelObject)obj22).Children.Add((__IModelObject)obj104);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj105);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj106);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj107);
			obj22.BaseTypes.Add(obj18);
			obj22.Properties.Add(obj104);
			obj22.Properties.Add(obj105);
			obj22.Properties.Add(obj106);
			obj22.Properties.Add(obj107);
			obj22.Declarations.Add(obj104);
			obj22.Declarations.Add(obj105);
			obj22.Declarations.Add(obj106);
			obj22.Declarations.Add(obj107);
			obj22.Name = "LRange";
			obj22.Parent = obj5;
			((__IModelObject)obj23).Children.Add((__IModelObject)obj109);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj110);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj111);
			obj23.BaseTypes.Add(obj18);
			obj23.Properties.Add(obj109);
			obj23.Properties.Add(obj110);
			obj23.Properties.Add(obj111);
			obj23.Declarations.Add(obj109);
			obj23.Declarations.Add(obj110);
			obj23.Declarations.Add(obj111);
			obj23.Name = "LSet";
			obj23.Parent = obj5;
			((__IModelObject)obj24).Children.Add((__IModelObject)obj114);
			((__IModelObject)obj24).Children.Add((__IModelObject)obj115);
			obj24.IsAbstract = true;
			obj24.Properties.Add(obj114);
			obj24.Properties.Add(obj115);
			obj24.Declarations.Add(obj114);
			obj24.Declarations.Add(obj115);
			obj24.Name = "LSetItem";
			obj24.Parent = obj5;
			((__IModelObject)obj25).Children.Add((__IModelObject)obj117);
			((__IModelObject)obj25).Children.Add((__IModelObject)obj118);
			((__IModelObject)obj25).Children.Add((__IModelObject)obj119);
			obj25.BaseTypes.Add(obj24);
			obj25.Properties.Add(obj117);
			obj25.Properties.Add(obj118);
			obj25.Properties.Add(obj119);
			obj25.Declarations.Add(obj117);
			obj25.Declarations.Add(obj118);
			obj25.Declarations.Add(obj119);
			obj25.Name = "LSetChar";
			obj25.Parent = obj5;
			((__IModelObject)obj26).Children.Add((__IModelObject)obj121);
			((__IModelObject)obj26).Children.Add((__IModelObject)obj122);
			((__IModelObject)obj26).Children.Add((__IModelObject)obj123);
			((__IModelObject)obj26).Children.Add((__IModelObject)obj124);
			obj26.BaseTypes.Add(obj24);
			obj26.Properties.Add(obj121);
			obj26.Properties.Add(obj122);
			obj26.Properties.Add(obj123);
			obj26.Properties.Add(obj124);
			obj26.Declarations.Add(obj121);
			obj26.Declarations.Add(obj122);
			obj26.Declarations.Add(obj123);
			obj26.Declarations.Add(obj124);
			obj26.Name = "LSetRange";
			obj26.Parent = obj5;
			((__IModelObject)obj27).Children.Add((__IModelObject)obj126);
			((__IModelObject)obj27).Children.Add((__IModelObject)obj127);
			((__IModelObject)obj27).Children.Add((__IModelObject)obj128);
			obj27.BaseTypes.Add(obj18);
			obj27.Properties.Add(obj126);
			obj27.Properties.Add(obj127);
			obj27.Properties.Add(obj128);
			obj27.Declarations.Add(obj126);
			obj27.Declarations.Add(obj127);
			obj27.Declarations.Add(obj128);
			obj27.Name = "LBlock";
			obj27.Parent = obj5;
			((__IModelObject)obj28).Children.Add((__IModelObject)obj131);
			((__IModelObject)obj28).Children.Add((__IModelObject)obj132);
			((__IModelObject)obj28).Children.Add((__IModelObject)obj133);
			obj28.BaseTypes.Add(obj14);
			obj28.IsAbstract = true;
			obj28.Properties.Add(obj131);
			obj28.Properties.Add(obj132);
			obj28.Properties.Add(obj133);
			obj28.Declarations.Add(obj131);
			obj28.Declarations.Add(obj132);
			obj28.Declarations.Add(obj133);
			obj28.Name = "ParserRule";
			obj28.Parent = obj5;
			((__IModelObject)obj29).Children.Add((__IModelObject)obj136);
			((__IModelObject)obj29).Children.Add((__IModelObject)obj137);
			((__IModelObject)obj29).Children.Add((__IModelObject)obj138);
			obj29.BaseTypes.Add(obj7);
			obj29.Properties.Add(obj136);
			obj29.Properties.Add(obj137);
			obj29.Properties.Add(obj138);
			obj29.Declarations.Add(obj136);
			obj29.Declarations.Add(obj137);
			obj29.Declarations.Add(obj138);
			obj29.Name = "PAlternative";
			obj29.Parent = obj5;
			((__IModelObject)obj30).Children.Add((__IModelObject)obj141);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj142);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj143);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj144);
			obj30.Literals.Add(obj141);
			obj30.Literals.Add(obj142);
			obj30.Literals.Add(obj143);
			obj30.Literals.Add(obj144);
			obj30.Declarations.Add(obj141);
			obj30.Declarations.Add(obj142);
			obj30.Declarations.Add(obj143);
			obj30.Declarations.Add(obj144);
			obj30.Name = "Assignment";
			obj30.Parent = obj5;
			((__IModelObject)obj31).Children.Add((__IModelObject)obj145);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj146);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj147);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj148);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj149);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj150);
			obj31.Properties.Add(obj145);
			obj31.Properties.Add(obj146);
			obj31.Properties.Add(obj147);
			obj31.Properties.Add(obj148);
			obj31.Properties.Add(obj149);
			obj31.Properties.Add(obj150);
			obj31.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj31.Declarations.Add(obj145);
			obj31.Declarations.Add(obj146);
			obj31.Declarations.Add(obj147);
			obj31.Declarations.Add(obj148);
			obj31.Declarations.Add(obj149);
			obj31.Declarations.Add(obj150);
			obj31.Name = "PElement";
			obj31.Parent = obj5;
			obj32.IsAbstract = true;
			obj32.Name = "PElementValue";
			obj32.Parent = obj5;
			((__IModelObject)obj33).Children.Add((__IModelObject)obj154);
			((__IModelObject)obj33).Children.Add((__IModelObject)obj155);
			obj33.BaseTypes.Add(obj32);
			obj33.Properties.Add(obj154);
			obj33.Properties.Add(obj155);
			obj33.Declarations.Add(obj154);
			obj33.Declarations.Add(obj155);
			obj33.Name = "PReference";
			obj33.Parent = obj5;
			obj34.BaseTypes.Add(obj32);
			obj34.Name = "PEof";
			obj34.Parent = obj5;
			((__IModelObject)obj35).Children.Add((__IModelObject)obj157);
			obj35.BaseTypes.Add(obj32);
			obj35.Properties.Add(obj157);
			obj35.Declarations.Add(obj157);
			obj35.Name = "PKeyword";
			obj35.Parent = obj5;
			((__IModelObject)obj36).Children.Add((__IModelObject)obj158);
			obj36.BaseTypes.Add(obj32);
			obj36.Properties.Add(obj158);
			obj36.Declarations.Add(obj158);
			obj36.Name = "PBlock";
			obj36.Parent = obj5;
			((__IModelObject)obj37).Children.Add((__IModelObject)obj160);
			obj37.IsAbstract = true;
			obj37.Properties.Add(obj160);
			obj37.Declarations.Add(obj160);
			obj37.Name = "Expression";
			obj37.Parent = obj5;
			((__IModelObject)obj38).Children.Add((__IModelObject)obj162);
			obj38.Properties.Add(obj162);
			obj38.Declarations.Add(obj162);
			obj38.Name = "NullExpression";
			obj38.Parent = obj5;
			((__IModelObject)obj39).Children.Add((__IModelObject)obj164);
			((__IModelObject)obj39).Children.Add((__IModelObject)obj165);
			obj39.Properties.Add(obj164);
			obj39.Properties.Add(obj165);
			obj39.Declarations.Add(obj164);
			obj39.Declarations.Add(obj165);
			obj39.Name = "BoolExpression";
			obj39.Parent = obj5;
			((__IModelObject)obj40).Children.Add((__IModelObject)obj167);
			((__IModelObject)obj40).Children.Add((__IModelObject)obj168);
			obj40.Properties.Add(obj167);
			obj40.Properties.Add(obj168);
			obj40.Declarations.Add(obj167);
			obj40.Declarations.Add(obj168);
			obj40.Name = "IntExpression";
			obj40.Parent = obj5;
			((__IModelObject)obj41).Children.Add((__IModelObject)obj170);
			((__IModelObject)obj41).Children.Add((__IModelObject)obj171);
			obj41.Properties.Add(obj170);
			obj41.Properties.Add(obj171);
			obj41.Declarations.Add(obj170);
			obj41.Declarations.Add(obj171);
			obj41.Name = "StringExpression";
			obj41.Parent = obj5;
			((__IModelObject)obj42).Children.Add((__IModelObject)obj173);
			((__IModelObject)obj42).Children.Add((__IModelObject)obj174);
			obj42.Properties.Add(obj173);
			obj42.Properties.Add(obj174);
			obj42.Declarations.Add(obj173);
			obj42.Declarations.Add(obj174);
			obj42.Name = "ReferenceExpression";
			obj42.Parent = obj5;
			((__IModelObject)obj43).Children.Add((__IModelObject)obj48);
			obj43.IsContainment = true;
			obj43.Type = __MetaType.FromModelObject((__IModelObject)obj48);
			obj43.Name = "Annotations";
			obj43.Parent = obj7;
			((__IModelObject)obj44).Children.Add((__IModelObject)obj49);
			obj44.SymbolProperty = "Name";
			obj44.Type = __MetaType.FromModelObject((__IModelObject)obj49);
			obj44.Name = "Name";
			obj44.Parent = obj7;
			((__IModelObject)obj45).Children.Add((__IModelObject)obj50);
			obj45.OppositeProperties.Add(obj46);
			obj45.Type = __MetaType.FromModelObject((__IModelObject)obj50);
			obj45.Name = "Parent";
			obj45.Parent = obj7;
			((__IModelObject)obj46).Children.Add((__IModelObject)obj51);
			obj46.IsContainment = true;
			obj46.OppositeProperties.Add(obj45);
			obj46.Type = __MetaType.FromModelObject((__IModelObject)obj51);
			obj46.Name = "Declarations";
			obj46.Parent = obj7;
			((__IModelObject)obj47).Children.Add((__IModelObject)obj52);
			obj47.IsDerived = true;
			obj47.Type = __MetaType.FromModelObject((__IModelObject)obj52);
			obj47.Name = "FullName";
			obj47.Parent = obj7;
			obj48.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj49.InnerType = typeof(string);
			obj50.InnerType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj51.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj52.InnerType = typeof(string);
			obj53.IsContainment = true;
			obj53.SubsettedProperties.Add(obj46);
			obj53.Type = __MetaType.FromModelObject((__IModelObject)obj10);
			obj53.Name = "Grammar";
			obj53.Parent = obj9;
			obj54.RedefinedProperties.Add(obj45);
			obj54.Type = __MetaType.FromModelObject((__IModelObject)obj9);
			obj54.Name = "Language";
			obj54.Parent = obj10;
			((__IModelObject)obj55).Children.Add((__IModelObject)obj56);
			obj55.IsContainment = true;
			obj55.Type = __MetaType.FromModelObject((__IModelObject)obj56);
			obj55.Name = "Rules";
			obj55.Parent = obj10;
			obj56.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj57.Type = typeof(__MetaType);
			obj57.Name = "Type";
			obj57.Parent = obj11;
			((__IModelObject)obj58).Children.Add((__IModelObject)obj59);
			obj58.IsContainment = true;
			obj58.Type = __MetaType.FromModelObject((__IModelObject)obj59);
			obj58.Name = "Arguments";
			obj58.Parent = obj11;
			obj59.ItemType = __MetaType.FromModelObject((__IModelObject)obj12);
			obj60.Type = typeof(string);
			obj60.Name = "Name";
			obj60.Parent = obj12;
			obj61.IsContainment = true;
			obj61.Type = __MetaType.FromModelObject((__IModelObject)obj37);
			obj61.Name = "Value";
			obj61.Parent = obj12;
			obj62.Name = "ExactlyOne";
			obj62.Parent = obj13;
			obj63.Name = "ZeroOrOne";
			obj63.Parent = obj13;
			obj64.Name = "ZeroOrMore";
			obj64.Parent = obj13;
			obj65.Name = "OneOrMore";
			obj65.Parent = obj13;
			obj66.Name = "NonGreedyZeroOrOne";
			obj66.Parent = obj13;
			obj67.Name = "NonGreedyZeroOrMore";
			obj67.Parent = obj13;
			obj68.Name = "NonGreedyOneOrMore";
			obj68.Parent = obj13;
			obj69.IsDerived = true;
			obj69.Type = __MetaType.FromModelObject((__IModelObject)obj9);
			obj69.Name = "Language";
			obj69.Parent = obj14;
			obj70.RedefinedProperties.Add(obj45);
			obj70.Type = __MetaType.FromModelObject((__IModelObject)obj10);
			obj70.Name = "Grammar";
			obj70.Parent = obj14;
			obj71.Type = typeof(__MetaType);
			obj71.Name = "ReturnType";
			obj71.Parent = obj15;
			obj72.Type = typeof(bool);
			obj72.Name = "IsHidden";
			obj72.Parent = obj15;
			obj73.Type = typeof(bool);
			obj73.Name = "IsFragment";
			obj73.Parent = obj15;
			obj74.IsDerived = true;
			obj74.Type = typeof(bool);
			obj74.Name = "IsFixed";
			obj74.Parent = obj15;
			((__IModelObject)obj75).Children.Add((__IModelObject)obj77);
			obj75.IsDerived = true;
			obj75.Type = __MetaType.FromModelObject((__IModelObject)obj77);
			obj75.Name = "FixedText";
			obj75.Parent = obj15;
			((__IModelObject)obj76).Children.Add((__IModelObject)obj78);
			obj76.IsContainment = true;
			obj76.Type = __MetaType.FromModelObject((__IModelObject)obj78);
			obj76.Name = "Alternatives";
			obj76.Parent = obj15;
			obj77.InnerType = typeof(string);
			obj78.ItemType = __MetaType.FromModelObject((__IModelObject)obj16);
			obj79.IsDerived = true;
			obj79.Type = typeof(bool);
			obj79.Name = "IsFixed";
			obj79.Parent = obj16;
			((__IModelObject)obj80).Children.Add((__IModelObject)obj82);
			obj80.IsDerived = true;
			obj80.Type = __MetaType.FromModelObject((__IModelObject)obj82);
			obj80.Name = "FixedText";
			obj80.Parent = obj16;
			((__IModelObject)obj81).Children.Add((__IModelObject)obj83);
			obj81.IsContainment = true;
			obj81.Type = __MetaType.FromModelObject((__IModelObject)obj83);
			obj81.Name = "Elements";
			obj81.Parent = obj16;
			obj82.InnerType = typeof(string);
			obj83.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
			obj84.IsDerived = true;
			obj84.Type = typeof(bool);
			obj84.Name = "IsFixed";
			obj84.Parent = obj17;
			((__IModelObject)obj85).Children.Add((__IModelObject)obj89);
			obj85.IsDerived = true;
			obj85.Type = __MetaType.FromModelObject((__IModelObject)obj89);
			obj85.Name = "FixedText";
			obj85.Parent = obj17;
			obj86.Type = typeof(bool);
			obj86.Name = "IsNegated";
			obj86.Parent = obj17;
			obj87.Type = __MetaType.FromModelObject((__IModelObject)obj18);
			obj87.Name = "Value";
			obj87.Parent = obj17;
			obj88.Type = __MetaType.FromModelObject((__IModelObject)obj13);
			obj88.Name = "Multiplicity";
			obj88.Parent = obj17;
			obj89.InnerType = typeof(string);
			obj90.IsDerived = true;
			obj90.Type = typeof(bool);
			obj90.Name = "IsFixed";
			obj90.Parent = obj18;
			((__IModelObject)obj91).Children.Add((__IModelObject)obj92);
			obj91.IsDerived = true;
			obj91.Type = __MetaType.FromModelObject((__IModelObject)obj92);
			obj91.Name = "FixedText";
			obj91.Parent = obj18;
			obj92.InnerType = typeof(string);
			obj93.IsDerived = true;
			obj93.Type = typeof(bool);
			obj93.Name = "IsFixed";
			obj93.Parent = obj19;
			((__IModelObject)obj94).Children.Add((__IModelObject)obj96);
			obj94.IsDerived = true;
			obj94.Type = __MetaType.FromModelObject((__IModelObject)obj96);
			obj94.Name = "FixedText";
			obj94.Parent = obj19;
			obj95.Type = __MetaType.FromModelObject((__IModelObject)obj15);
			obj95.Name = "Rule";
			obj95.Parent = obj19;
			obj96.InnerType = typeof(string);
			obj97.IsDerived = true;
			obj97.Type = typeof(bool);
			obj97.Name = "IsFixed";
			obj97.Parent = obj20;
			((__IModelObject)obj98).Children.Add((__IModelObject)obj100);
			obj98.IsDerived = true;
			obj98.Type = __MetaType.FromModelObject((__IModelObject)obj100);
			obj98.Name = "FixedText";
			obj98.Parent = obj20;
			obj99.Type = typeof(string);
			obj99.Name = "Text";
			obj99.Parent = obj20;
			obj100.InnerType = typeof(string);
			obj101.IsDerived = true;
			obj101.Type = typeof(bool);
			obj101.Name = "IsFixed";
			obj101.Parent = obj21;
			((__IModelObject)obj102).Children.Add((__IModelObject)obj103);
			obj102.IsDerived = true;
			obj102.Type = __MetaType.FromModelObject((__IModelObject)obj103);
			obj102.Name = "FixedText";
			obj102.Parent = obj21;
			obj103.InnerType = typeof(string);
			obj104.IsDerived = true;
			obj104.Type = typeof(bool);
			obj104.Name = "IsFixed";
			obj104.Parent = obj22;
			((__IModelObject)obj105).Children.Add((__IModelObject)obj108);
			obj105.IsDerived = true;
			obj105.Type = __MetaType.FromModelObject((__IModelObject)obj108);
			obj105.Name = "FixedText";
			obj105.Parent = obj22;
			obj106.Type = typeof(string);
			obj106.Name = "StartChar";
			obj106.Parent = obj22;
			obj107.Type = typeof(string);
			obj107.Name = "EndChar";
			obj107.Parent = obj22;
			obj108.InnerType = typeof(string);
			obj109.IsDerived = true;
			obj109.Type = typeof(bool);
			obj109.Name = "IsFixed";
			obj109.Parent = obj23;
			((__IModelObject)obj110).Children.Add((__IModelObject)obj112);
			obj110.IsDerived = true;
			obj110.Type = __MetaType.FromModelObject((__IModelObject)obj112);
			obj110.Name = "FixedText";
			obj110.Parent = obj23;
			((__IModelObject)obj111).Children.Add((__IModelObject)obj113);
			obj111.IsContainment = true;
			obj111.Type = __MetaType.FromModelObject((__IModelObject)obj113);
			obj111.Name = "Items";
			obj111.Parent = obj23;
			obj112.InnerType = typeof(string);
			obj113.ItemType = __MetaType.FromModelObject((__IModelObject)obj24);
			obj114.IsDerived = true;
			obj114.Type = typeof(bool);
			obj114.Name = "IsFixed";
			obj114.Parent = obj24;
			((__IModelObject)obj115).Children.Add((__IModelObject)obj116);
			obj115.IsDerived = true;
			obj115.Type = __MetaType.FromModelObject((__IModelObject)obj116);
			obj115.Name = "FixedText";
			obj115.Parent = obj24;
			obj116.InnerType = typeof(string);
			obj117.IsDerived = true;
			obj117.Type = typeof(bool);
			obj117.Name = "IsFixed";
			obj117.Parent = obj25;
			((__IModelObject)obj118).Children.Add((__IModelObject)obj120);
			obj118.IsDerived = true;
			obj118.Type = __MetaType.FromModelObject((__IModelObject)obj120);
			obj118.Name = "FixedText";
			obj118.Parent = obj25;
			obj119.Type = typeof(string);
			obj119.Name = "Char";
			obj119.Parent = obj25;
			obj120.InnerType = typeof(string);
			obj121.IsDerived = true;
			obj121.Type = typeof(bool);
			obj121.Name = "IsFixed";
			obj121.Parent = obj26;
			((__IModelObject)obj122).Children.Add((__IModelObject)obj125);
			obj122.IsDerived = true;
			obj122.Type = __MetaType.FromModelObject((__IModelObject)obj125);
			obj122.Name = "FixedText";
			obj122.Parent = obj26;
			obj123.Type = typeof(string);
			obj123.Name = "StartChar";
			obj123.Parent = obj26;
			obj124.Type = typeof(string);
			obj124.Name = "EndChar";
			obj124.Parent = obj26;
			obj125.InnerType = typeof(string);
			obj126.IsDerived = true;
			obj126.Type = typeof(bool);
			obj126.Name = "IsFixed";
			obj126.Parent = obj27;
			((__IModelObject)obj127).Children.Add((__IModelObject)obj129);
			obj127.IsDerived = true;
			obj127.Type = __MetaType.FromModelObject((__IModelObject)obj129);
			obj127.Name = "FixedText";
			obj127.Parent = obj27;
			((__IModelObject)obj128).Children.Add((__IModelObject)obj130);
			obj128.IsContainment = true;
			obj128.Type = __MetaType.FromModelObject((__IModelObject)obj130);
			obj128.Name = "Alternatives";
			obj128.Parent = obj27;
			obj129.InnerType = typeof(string);
			obj130.ItemType = __MetaType.FromModelObject((__IModelObject)obj16);
			((__IModelObject)obj131).Children.Add((__IModelObject)obj134);
			obj131.Type = __MetaType.FromModelObject((__IModelObject)obj134);
			obj131.Name = "ReturnType";
			obj131.Parent = obj28;
			obj132.Type = typeof(bool);
			obj132.Name = "IsBlock";
			obj132.Parent = obj28;
			((__IModelObject)obj133).Children.Add((__IModelObject)obj135);
			obj133.IsContainment = true;
			obj133.Type = __MetaType.FromModelObject((__IModelObject)obj135);
			obj133.Name = "Alternatives";
			obj133.Parent = obj28;
			obj134.InnerType = typeof(__MetaType);
			obj135.ItemType = __MetaType.FromModelObject((__IModelObject)obj29);
			((__IModelObject)obj136).Children.Add((__IModelObject)obj139);
			obj136.Type = __MetaType.FromModelObject((__IModelObject)obj139);
			obj136.Name = "ReturnType";
			obj136.Parent = obj29;
			obj137.IsContainment = true;
			obj137.Type = __MetaType.FromModelObject((__IModelObject)obj37);
			obj137.Name = "ReturnValue";
			obj137.Parent = obj29;
			((__IModelObject)obj138).Children.Add((__IModelObject)obj140);
			obj138.IsContainment = true;
			obj138.Type = __MetaType.FromModelObject((__IModelObject)obj140);
			obj138.Name = "Elements";
			obj138.Parent = obj29;
			obj139.InnerType = typeof(__MetaType);
			obj140.ItemType = __MetaType.FromModelObject((__IModelObject)obj31);
			obj141.Name = "Assign";
			obj141.Parent = obj30;
			obj142.Name = "QuestionAssign";
			obj142.Parent = obj30;
			obj143.Name = "NegatedAssign";
			obj143.Parent = obj30;
			obj144.Name = "PlusAssign";
			obj144.Parent = obj30;
			((__IModelObject)obj145).Children.Add((__IModelObject)obj151);
			obj145.IsContainment = true;
			obj145.Type = __MetaType.FromModelObject((__IModelObject)obj151);
			obj145.Name = "NameAnnotations";
			obj145.Parent = obj31;
			((__IModelObject)obj146).Children.Add((__IModelObject)obj152);
			obj146.SymbolProperty = "Name";
			obj146.Type = __MetaType.FromModelObject((__IModelObject)obj152);
			obj146.Name = "Name";
			obj146.Parent = obj31;
			obj147.Type = __MetaType.FromModelObject((__IModelObject)obj30);
			obj147.Name = "Assignment";
			obj147.Parent = obj31;
			((__IModelObject)obj148).Children.Add((__IModelObject)obj153);
			obj148.IsContainment = true;
			obj148.Type = __MetaType.FromModelObject((__IModelObject)obj153);
			obj148.Name = "ValueAnnotations";
			obj148.Parent = obj31;
			obj149.Type = __MetaType.FromModelObject((__IModelObject)obj32);
			obj149.Name = "Value";
			obj149.Parent = obj31;
			obj150.Type = __MetaType.FromModelObject((__IModelObject)obj13);
			obj150.Name = "Multiplicity";
			obj150.Parent = obj31;
			obj151.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj152.InnerType = typeof(string);
			obj153.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj154.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj154.Name = "Rule";
			obj154.Parent = obj33;
			((__IModelObject)obj155).Children.Add((__IModelObject)obj156);
			obj155.Type = __MetaType.FromModelObject((__IModelObject)obj156);
			obj155.Name = "ReferencedTypes";
			obj155.Parent = obj33;
			obj156.ItemType = typeof(__MetaType);
			obj157.Type = typeof(string);
			obj157.Name = "Text";
			obj157.Parent = obj35;
			((__IModelObject)obj158).Children.Add((__IModelObject)obj159);
			obj158.IsContainment = true;
			obj158.Type = __MetaType.FromModelObject((__IModelObject)obj159);
			obj158.Name = "Alternatives";
			obj158.Parent = obj36;
			obj159.ItemType = __MetaType.FromModelObject((__IModelObject)obj29);
			((__IModelObject)obj160).Children.Add((__IModelObject)obj161);
			obj160.IsDerived = true;
			obj160.Type = __MetaType.FromModelObject((__IModelObject)obj161);
			obj160.Name = "Value";
			obj160.Parent = obj37;
			obj161.InnerType = typeof(object);
			((__IModelObject)obj162).Children.Add((__IModelObject)obj163);
			obj162.IsDerived = true;
			obj162.Type = __MetaType.FromModelObject((__IModelObject)obj163);
			obj162.Name = "Value";
			obj162.Parent = obj38;
			obj163.InnerType = typeof(object);
			((__IModelObject)obj164).Children.Add((__IModelObject)obj166);
			obj164.IsDerived = true;
			obj164.Type = __MetaType.FromModelObject((__IModelObject)obj166);
			obj164.Name = "Value";
			obj164.Parent = obj39;
			obj165.Type = typeof(bool);
			obj165.Name = "BoolValue";
			obj165.Parent = obj39;
			obj166.InnerType = typeof(object);
			((__IModelObject)obj167).Children.Add((__IModelObject)obj169);
			obj167.IsDerived = true;
			obj167.Type = __MetaType.FromModelObject((__IModelObject)obj169);
			obj167.Name = "Value";
			obj167.Parent = obj40;
			obj168.Type = typeof(int);
			obj168.Name = "IntValue";
			obj168.Parent = obj40;
			obj169.InnerType = typeof(object);
			((__IModelObject)obj170).Children.Add((__IModelObject)obj172);
			obj170.IsDerived = true;
			obj170.Type = __MetaType.FromModelObject((__IModelObject)obj172);
			obj170.Name = "Value";
			obj170.Parent = obj41;
			obj171.Type = typeof(string);
			obj171.Name = "StringValue";
			obj171.Parent = obj41;
			obj172.InnerType = typeof(object);
			((__IModelObject)obj173).Children.Add((__IModelObject)obj175);
			obj173.IsDerived = true;
			obj173.Type = __MetaType.FromModelObject((__IModelObject)obj175);
			obj173.Name = "Value";
			obj173.Parent = obj42;
			obj174.Type = typeof(__MetaSymbol);
			obj174.Name = "SymbolValue";
			obj174.Parent = obj42;
			obj175.InnerType = typeof(object);
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
		public static __ModelProperty AnnotationArgument_Name => _AnnotationArgument_Name;
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
		public static __ModelObjectInfo LAlternativeInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LAlternative_Impl.__Info.Instance;
		public static __ModelProperty LAlternative_IsFixed => _LAlternative_IsFixed;
		public static __ModelProperty LAlternative_FixedText => _LAlternative_FixedText;
		public static __ModelProperty LAlternative_Elements => _LAlternative_Elements;
		public static __ModelObjectInfo LElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LElement_Impl.__Info.Instance;
		public static __ModelProperty LElement_IsFixed => _LElement_IsFixed;
		public static __ModelProperty LElement_FixedText => _LElement_FixedText;
		public static __ModelProperty LElement_IsNegated => _LElement_IsNegated;
		public static __ModelProperty LElement_Value => _LElement_Value;
		public static __ModelProperty LElement_Multiplicity => _LElement_Multiplicity;
		public static __ModelObjectInfo LElementValueInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LElementValue_Impl.__Info.Instance;
		public static __ModelProperty LElementValue_IsFixed => _LElementValue_IsFixed;
		public static __ModelProperty LElementValue_FixedText => _LElementValue_FixedText;
		public static __ModelObjectInfo LReferenceInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LReference_Impl.__Info.Instance;
		public static __ModelProperty LReference_IsFixed => _LReference_IsFixed;
		public static __ModelProperty LReference_FixedText => _LReference_FixedText;
		public static __ModelProperty LReference_Rule => _LReference_Rule;
		public static __ModelObjectInfo LFixedInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LFixed_Impl.__Info.Instance;
		public static __ModelProperty LFixed_IsFixed => _LFixed_IsFixed;
		public static __ModelProperty LFixed_FixedText => _LFixed_FixedText;
		public static __ModelProperty LFixed_Text => _LFixed_Text;
		public static __ModelObjectInfo LWildCardInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LWildCard_Impl.__Info.Instance;
		public static __ModelProperty LWildCard_IsFixed => _LWildCard_IsFixed;
		public static __ModelProperty LWildCard_FixedText => _LWildCard_FixedText;
		public static __ModelObjectInfo LRangeInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LRange_Impl.__Info.Instance;
		public static __ModelProperty LRange_IsFixed => _LRange_IsFixed;
		public static __ModelProperty LRange_FixedText => _LRange_FixedText;
		public static __ModelProperty LRange_StartChar => _LRange_StartChar;
		public static __ModelProperty LRange_EndChar => _LRange_EndChar;
		public static __ModelObjectInfo LSetInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LSet_Impl.__Info.Instance;
		public static __ModelProperty LSet_IsFixed => _LSet_IsFixed;
		public static __ModelProperty LSet_FixedText => _LSet_FixedText;
		public static __ModelProperty LSet_Items => _LSet_Items;
		public static __ModelObjectInfo LSetItemInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LSetItem_Impl.__Info.Instance;
		public static __ModelProperty LSetItem_IsFixed => _LSetItem_IsFixed;
		public static __ModelProperty LSetItem_FixedText => _LSetItem_FixedText;
		public static __ModelObjectInfo LSetCharInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LSetChar_Impl.__Info.Instance;
		public static __ModelProperty LSetChar_IsFixed => _LSetChar_IsFixed;
		public static __ModelProperty LSetChar_FixedText => _LSetChar_FixedText;
		public static __ModelProperty LSetChar_Char => _LSetChar_Char;
		public static __ModelObjectInfo LSetRangeInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LSetRange_Impl.__Info.Instance;
		public static __ModelProperty LSetRange_IsFixed => _LSetRange_IsFixed;
		public static __ModelProperty LSetRange_FixedText => _LSetRange_FixedText;
		public static __ModelProperty LSetRange_StartChar => _LSetRange_StartChar;
		public static __ModelProperty LSetRange_EndChar => _LSetRange_EndChar;
		public static __ModelObjectInfo LBlockInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.LBlock_Impl.__Info.Instance;
		public static __ModelProperty LBlock_IsFixed => _LBlock_IsFixed;
		public static __ModelProperty LBlock_FixedText => _LBlock_FixedText;
		public static __ModelProperty LBlock_Alternatives => _LBlock_Alternatives;
		public static __ModelObjectInfo ParserRuleInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.ParserRule_Impl.__Info.Instance;
		public static __ModelProperty ParserRule_ReturnType => _ParserRule_ReturnType;
		public static __ModelProperty ParserRule_IsBlock => _ParserRule_IsBlock;
		public static __ModelProperty ParserRule_Alternatives => _ParserRule_Alternatives;
		public static __ModelObjectInfo PAlternativeInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.PAlternative_Impl.__Info.Instance;
		public static __ModelProperty PAlternative_ReturnType => _PAlternative_ReturnType;
		public static __ModelProperty PAlternative_ReturnValue => _PAlternative_ReturnValue;
		public static __ModelProperty PAlternative_Elements => _PAlternative_Elements;
		public static __ModelObjectInfo PElementInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.PElement_Impl.__Info.Instance;
		public static __ModelProperty PElement_NameAnnotations => _PElement_NameAnnotations;
		public static __ModelProperty PElement_Name => _PElement_Name;
		public static __ModelProperty PElement_Assignment => _PElement_Assignment;
		public static __ModelProperty PElement_ValueAnnotations => _PElement_ValueAnnotations;
		public static __ModelProperty PElement_Value => _PElement_Value;
		public static __ModelProperty PElement_Multiplicity => _PElement_Multiplicity;
		public static __ModelObjectInfo PElementValueInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.PElementValue_Impl.__Info.Instance;
		public static __ModelObjectInfo PReferenceInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.PReference_Impl.__Info.Instance;
		public static __ModelProperty PReference_Rule => _PReference_Rule;
		public static __ModelProperty PReference_ReferencedTypes => _PReference_ReferencedTypes;
		public static __ModelObjectInfo PEofInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.PEof_Impl.__Info.Instance;
		public static __ModelObjectInfo PKeywordInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.PKeyword_Impl.__Info.Instance;
		public static __ModelProperty PKeyword_Text => _PKeyword_Text;
		public static __ModelObjectInfo PBlockInfo => global::MetaDslx.Bootstrap.MetaCompiler.Model.__Impl.PBlock_Impl.__Info.Instance;
		public static __ModelProperty PBlock_Alternatives => _PBlock_Alternatives;
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
	
		public LAlternative LAlternative(string? id = null)
		{
			return (LAlternative)Compiler.LAlternativeInfo.Create(Model, id)!;
		}
	
		public LElement LElement(string? id = null)
		{
			return (LElement)Compiler.LElementInfo.Create(Model, id)!;
		}
	
		public LReference LReference(string? id = null)
		{
			return (LReference)Compiler.LReferenceInfo.Create(Model, id)!;
		}
	
		public LFixed LFixed(string? id = null)
		{
			return (LFixed)Compiler.LFixedInfo.Create(Model, id)!;
		}
	
		public LWildCard LWildCard(string? id = null)
		{
			return (LWildCard)Compiler.LWildCardInfo.Create(Model, id)!;
		}
	
		public LRange LRange(string? id = null)
		{
			return (LRange)Compiler.LRangeInfo.Create(Model, id)!;
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
	
		public LBlock LBlock(string? id = null)
		{
			return (LBlock)Compiler.LBlockInfo.Create(Model, id)!;
		}
	
		public PAlternative PAlternative(string? id = null)
		{
			return (PAlternative)Compiler.PAlternativeInfo.Create(Model, id)!;
		}
	
		public PElement PElement(string? id = null)
		{
			return (PElement)Compiler.PElementInfo.Create(Model, id)!;
		}
	
		public PReference PReference(string? id = null)
		{
			return (PReference)Compiler.PReferenceInfo.Create(Model, id)!;
		}
	
		public PEof PEof(string? id = null)
		{
			return (PEof)Compiler.PEofInfo.Create(Model, id)!;
		}
	
		public PKeyword PKeyword(string? id = null)
		{
			return (PKeyword)Compiler.PKeywordInfo.Create(Model, id)!;
		}
	
		public PBlock PBlock(string? id = null)
		{
			return (PBlock)Compiler.PBlockInfo.Create(Model, id)!;
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
	
		public LAlternative LAlternative(__Model model, string? id = null)
		{
			return (LAlternative)Compiler.LAlternativeInfo.Create(model, id)!;
		}
	
		public LElement LElement(__Model model, string? id = null)
		{
			return (LElement)Compiler.LElementInfo.Create(model, id)!;
		}
	
		public LReference LReference(__Model model, string? id = null)
		{
			return (LReference)Compiler.LReferenceInfo.Create(model, id)!;
		}
	
		public LFixed LFixed(__Model model, string? id = null)
		{
			return (LFixed)Compiler.LFixedInfo.Create(model, id)!;
		}
	
		public LWildCard LWildCard(__Model model, string? id = null)
		{
			return (LWildCard)Compiler.LWildCardInfo.Create(model, id)!;
		}
	
		public LRange LRange(__Model model, string? id = null)
		{
			return (LRange)Compiler.LRangeInfo.Create(model, id)!;
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
	
		public LBlock LBlock(__Model model, string? id = null)
		{
			return (LBlock)Compiler.LBlockInfo.Create(model, id)!;
		}
	
		public PAlternative PAlternative(__Model model, string? id = null)
		{
			return (PAlternative)Compiler.PAlternativeInfo.Create(model, id)!;
		}
	
		public PElement PElement(__Model model, string? id = null)
		{
			return (PElement)Compiler.PElementInfo.Create(model, id)!;
		}
	
		public PReference PReference(__Model model, string? id = null)
		{
			return (PReference)Compiler.PReferenceInfo.Create(model, id)!;
		}
	
		public PEof PEof(__Model model, string? id = null)
		{
			return (PEof)Compiler.PEofInfo.Create(model, id)!;
		}
	
		public PKeyword PKeyword(__Model model, string? id = null)
		{
			return (PKeyword)Compiler.PKeywordInfo.Create(model, id)!;
		}
	
		public PBlock PBlock(__Model model, string? id = null)
		{
			return (PBlock)Compiler.PBlockInfo.Create(model, id)!;
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

	public enum Assignment
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
		string Name { get; set; }
		Expression Value { get; set; }
	
	}

	public interface Rule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		Grammar Grammar { get; set; }
		Language Language { get; }
	
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

	public interface LAlternative : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<LElement> Elements { get; }
		string? FixedText { get; }
		bool IsFixed { get; }
	
	}

	public interface LElement : __IModelObjectCore
	{
		string? FixedText { get; }
		bool IsFixed { get; }
		bool IsNegated { get; set; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
		LElementValue Value { get; set; }
	
	}

	public interface LElementValue : __IModelObjectCore
	{
		string? FixedText { get; }
		bool IsFixed { get; }
	
	}

	public interface LReference : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		new string? FixedText { get; }
		new bool IsFixed { get; }
		LexerRule Rule { get; set; }
	
	}

	public interface LFixed : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		new string? FixedText { get; }
		new bool IsFixed { get; }
		string Text { get; set; }
	
	}

	public interface LWildCard : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		new string? FixedText { get; }
		new bool IsFixed { get; }
	
	}

	public interface LRange : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		string EndChar { get; set; }
		new string? FixedText { get; }
		new bool IsFixed { get; }
		string StartChar { get; set; }
	
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

	public interface LBlock : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		global::System.Collections.Generic.IList<LAlternative> Alternatives { get; }
		new string? FixedText { get; }
		new bool IsFixed { get; }
	
	}

	public interface ParserRule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Rule
	{
		global::System.Collections.Generic.IList<PAlternative> Alternatives { get; }
		bool IsBlock { get; set; }
		__MetaType? ReturnType { get; set; }
	
	}

	public interface PAlternative : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		global::System.Collections.Generic.IList<PElement> Elements { get; }
		__MetaType? ReturnType { get; set; }
		Expression ReturnValue { get; set; }
	
	}

	public interface PElement : __IModelObjectCore
	{
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment { get; set; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
		string? Name { get; set; }
		global::System.Collections.Generic.IList<Annotation> NameAnnotations { get; }
		PElementValue Value { get; set; }
		global::System.Collections.Generic.IList<Annotation> ValueAnnotations { get; }
	
	}

	public interface PElementValue : __IModelObjectCore
	{
	
	}

	public interface PReference : global::MetaDslx.Bootstrap.MetaCompiler.Model.PElementValue
	{
		global::System.Collections.Generic.IList<__MetaType> ReferencedTypes { get; }
		Rule Rule { get; set; }
	
	}

	public interface PEof : global::MetaDslx.Bootstrap.MetaCompiler.Model.PElementValue
	{
	
	}

	public interface PKeyword : global::MetaDslx.Bootstrap.MetaCompiler.Model.PElementValue
	{
		string Text { get; set; }
	
	}

	public interface PBlock : global::MetaDslx.Bootstrap.MetaCompiler.Model.PElementValue
	{
		global::System.Collections.Generic.IList<PAlternative> Alternatives { get; }
	
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
		/// Constructor for the class LReference
		/// </summary>
		void LReference(LReference _this);
	
		/// <summary>
		/// Constructor for the class LFixed
		/// </summary>
		void LFixed(LFixed _this);
	
		/// <summary>
		/// Constructor for the class LWildCard
		/// </summary>
		void LWildCard(LWildCard _this);
	
		/// <summary>
		/// Constructor for the class LRange
		/// </summary>
		void LRange(LRange _this);
	
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
		/// Constructor for the class LBlock
		/// </summary>
		void LBlock(LBlock _this);
	
		/// <summary>
		/// Constructor for the class ParserRule
		/// </summary>
		void ParserRule(ParserRule _this);
	
		/// <summary>
		/// Constructor for the class PAlternative
		/// </summary>
		void PAlternative(PAlternative _this);
	
		/// <summary>
		/// Constructor for the class PElement
		/// </summary>
		void PElement(PElement _this);
	
		/// <summary>
		/// Constructor for the class PElementValue
		/// </summary>
		void PElementValue(PElementValue _this);
	
		/// <summary>
		/// Constructor for the class PReference
		/// </summary>
		void PReference(PReference _this);
	
		/// <summary>
		/// Constructor for the class PEof
		/// </summary>
		void PEof(PEof _this);
	
		/// <summary>
		/// Constructor for the class PKeyword
		/// </summary>
		void PKeyword(PKeyword _this);
	
		/// <summary>
		/// Constructor for the class PBlock
		/// </summary>
		void PBlock(PBlock _this);
	
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
		/// Computation of the derived property LReference.IsFixed
		/// </summary>
		bool LReference_IsFixed(LReference _this);
	
		/// <summary>
		/// Computation of the derived property LReference.FixedText
		/// </summary>
		string? LReference_FixedText(LReference _this);
	
		/// <summary>
		/// Computation of the derived property LFixed.IsFixed
		/// </summary>
		bool LFixed_IsFixed(LFixed _this);
	
		/// <summary>
		/// Computation of the derived property LFixed.FixedText
		/// </summary>
		string? LFixed_FixedText(LFixed _this);
	
		/// <summary>
		/// Computation of the derived property LWildCard.IsFixed
		/// </summary>
		bool LWildCard_IsFixed(LWildCard _this);
	
		/// <summary>
		/// Computation of the derived property LWildCard.FixedText
		/// </summary>
		string? LWildCard_FixedText(LWildCard _this);
	
		/// <summary>
		/// Computation of the derived property LRange.IsFixed
		/// </summary>
		bool LRange_IsFixed(LRange _this);
	
		/// <summary>
		/// Computation of the derived property LRange.FixedText
		/// </summary>
		string? LRange_FixedText(LRange _this);
	
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
		/// Computation of the derived property LBlock.IsFixed
		/// </summary>
		bool LBlock_IsFixed(LBlock _this);
	
		/// <summary>
		/// Computation of the derived property LBlock.FixedText
		/// </summary>
		string? LBlock_FixedText(LBlock _this);
	
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
		/// Constructor for the class LReference
		/// </summary>
		public virtual void LReference(LReference _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LFixed
		/// </summary>
		public virtual void LFixed(LFixed _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LWildCard
		/// </summary>
		public virtual void LWildCard(LWildCard _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class LRange
		/// </summary>
		public virtual void LRange(LRange _this)
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
		/// Constructor for the class LBlock
		/// </summary>
		public virtual void LBlock(LBlock _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ParserRule
		/// </summary>
		public virtual void ParserRule(ParserRule _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class PAlternative
		/// </summary>
		public virtual void PAlternative(PAlternative _this)
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
		/// Constructor for the class PReference
		/// </summary>
		public virtual void PReference(PReference _this)
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
		/// Constructor for the class PBlock
		/// </summary>
		public virtual void PBlock(PBlock _this)
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
		/// Computation of the derived property LReference.IsFixed
		/// </summary>
		public abstract bool LReference_IsFixed(LReference _this);
	
		/// <summary>
		/// Computation of the derived property LReference.FixedText
		/// </summary>
		public abstract string? LReference_FixedText(LReference _this);
	
		/// <summary>
		/// Computation of the derived property LFixed.IsFixed
		/// </summary>
		public abstract bool LFixed_IsFixed(LFixed _this);
	
		/// <summary>
		/// Computation of the derived property LFixed.FixedText
		/// </summary>
		public abstract string? LFixed_FixedText(LFixed _this);
	
		/// <summary>
		/// Computation of the derived property LWildCard.IsFixed
		/// </summary>
		public abstract bool LWildCard_IsFixed(LWildCard _this);
	
		/// <summary>
		/// Computation of the derived property LWildCard.FixedText
		/// </summary>
		public abstract string? LWildCard_FixedText(LWildCard _this);
	
		/// <summary>
		/// Computation of the derived property LRange.IsFixed
		/// </summary>
		public abstract bool LRange_IsFixed(LRange _this);
	
		/// <summary>
		/// Computation of the derived property LRange.FixedText
		/// </summary>
		public abstract string? LRange_FixedText(LRange _this);
	
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
		/// Computation of the derived property LBlock.IsFixed
		/// </summary>
		public abstract bool LBlock_IsFixed(LBlock _this);
	
		/// <summary>
		/// Computation of the derived property LBlock.FixedText
		/// </summary>
		public abstract string? LBlock_FixedText(LBlock _this);
	
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
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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
	
		public string Name
		{
			get => MGet<string>(Compiler.AnnotationArgument_Name);
			set => MAdd<string>(Compiler.AnnotationArgument_Name, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Name, Compiler.AnnotationArgument_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Name, Compiler.AnnotationArgument_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Name, Compiler.AnnotationArgument_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Name", Compiler.AnnotationArgument_Name);
				publicPropertiesByName.Add("Value", Compiler.AnnotationArgument_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.AnnotationArgument_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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
			((__IModelObject)this).Init(Compiler.LexerRule_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<LAlternative>(this, __Info.Instance.GetSlot(Compiler.LexerRule_Alternatives)!));
			((__IModelObject)this).Init(Compiler.Declaration_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.Declaration_Annotations)!));
			((__IModelObject)this).Init(Compiler.Declaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<Declaration>(this, __Info.Instance.GetSlot(Compiler.Declaration_Declarations)!));
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Rule(this);
			Compiler.__CustomImpl.LexerRule(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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

	internal class LAlternative_Impl : __MetaModelObject, LAlternative
	{
		private LAlternative_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.LAlternative_Elements, new global::MetaDslx.Modeling.ModelObjectList<LElement>(this, __Info.Instance.GetSlot(Compiler.LAlternative_Elements)!));
			Compiler.__CustomImpl.LAlternative(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LAlternative);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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

	internal class LElement_Impl : __MetaModelObject, LElement
	{
		private LElement_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
				modelPropertyInfos.Add(Compiler.LElement_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LElement);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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

	internal class LElementValue_Impl : __MetaModelObject, LElementValue
	{
		private LElementValue_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElementValue(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LElementValue_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LElementValue_IsFixed(this);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LElementValue);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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

	internal class LReference_Impl : __MetaModelObject, LReference
	{
		private LReference_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LReference(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LReference);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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

	internal class LFixed_Impl : __MetaModelObject, LFixed
	{
		private LFixed_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LFixed(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LFixed);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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

	internal class LWildCard_Impl : __MetaModelObject, LWildCard
	{
		private LWildCard_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LWildCard(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LWildCard);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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

	internal class LRange_Impl : __MetaModelObject, LRange
	{
		private LRange_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LRange(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LRange);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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

	internal class LSet_Impl : __MetaModelObject, LSet
	{
		private LSet_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.LSet_Items, new global::MetaDslx.Modeling.ModelObjectList<LSetItem>(this, __Info.Instance.GetSlot(Compiler.LSet_Items)!));
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LSet(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LSet);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => Compiler.__CustomImpl.LSetItem_FixedText(this);
		}
	
		public bool IsFixed
		{
			get => Compiler.__CustomImpl.LSetItem_IsFixed(this);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LSetItem);
	
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LSetItemInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LSetItemInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LSetChar);
	
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LSetItemInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LSetItemInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LSetRange);
	
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

	internal class LBlock_Impl : __MetaModelObject, LBlock
	{
		private LBlock_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.LBlock_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<LAlternative>(this, __Info.Instance.GetSlot(Compiler.LBlock_Alternatives)!));
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LBlock(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.LElementValueInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(LBlock);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(PAlternative);
	
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

	internal class PElement_Impl : __MetaModelObject, PElement
	{
		private PElement_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.PElement_NameAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.PElement_NameAnnotations)!));
			((__IModelObject)this).Init(Compiler.PElement_ValueAnnotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Compiler.PElement_ValueAnnotations)!));
			Compiler.__CustomImpl.PElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
	
		public string? Name
		{
			get => MGet<string?>(Compiler.PElement_Name);
			set => MAdd<string?>(Compiler.PElement_Name, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> NameAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.PElement_NameAnnotations);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Assignment, Compiler.PElement_Multiplicity, Compiler.PElement_Name, Compiler.PElement_NameAnnotations, Compiler.PElement_Value, Compiler.PElement_ValueAnnotations);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Assignment, Compiler.PElement_Multiplicity, Compiler.PElement_Name, Compiler.PElement_NameAnnotations, Compiler.PElement_Value, Compiler.PElement_ValueAnnotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Assignment, Compiler.PElement_Multiplicity, Compiler.PElement_Name, Compiler.PElement_NameAnnotations, Compiler.PElement_Value, Compiler.PElement_ValueAnnotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Assignment", Compiler.PElement_Assignment);
				publicPropertiesByName.Add("Multiplicity", Compiler.PElement_Multiplicity);
				publicPropertiesByName.Add("Name", Compiler.PElement_Name);
				publicPropertiesByName.Add("NameAnnotations", Compiler.PElement_NameAnnotations);
				publicPropertiesByName.Add("Value", Compiler.PElement_Value);
				publicPropertiesByName.Add("ValueAnnotations", Compiler.PElement_ValueAnnotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.PElement_Assignment, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_Assignment, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_NameAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_NameAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_NameAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_ValueAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_ValueAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_ValueAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(PElement);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => Compiler.PElement_Name;
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
	
	
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(PElementValue);
	
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

	internal class PReference_Impl : __MetaModelObject, PReference
	{
		private PReference_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.PReference_ReferencedTypes, new global::MetaDslx.Modeling.ModelObjectList<__MetaType>(this, __Info.Instance.GetSlot(Compiler.PReference_ReferencedTypes)!));
			Compiler.__CustomImpl.PElementValue(this);
			Compiler.__CustomImpl.PReference(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<__MetaType> ReferencedTypes
		{
			get => MGetCollection<__MetaType>(Compiler.PReference_ReferencedTypes);
		}
	
		public Rule Rule
		{
			get => MGet<Rule>(Compiler.PReference_Rule);
			set => MAdd<Rule>(Compiler.PReference_Rule, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.PElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.PElementValueInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(PReference);
	
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

	internal class PEof_Impl : __MetaModelObject, PEof
	{
		private PEof_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.PElementValue(this);
			Compiler.__CustomImpl.PEof(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
	
	
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.PElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.PElementValueInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(PEof);
	
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string Text
		{
			get => MGet<string>(Compiler.PKeyword_Text);
			set => MAdd<string>(Compiler.PKeyword_Text, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.PElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.PElementValueInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(PKeyword);
	
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

	internal class PBlock_Impl : __MetaModelObject, PBlock
	{
		private PBlock_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Compiler.PBlock_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<PAlternative>(this, __Info.Instance.GetSlot(Compiler.PBlock_Alternatives)!));
			Compiler.__CustomImpl.PElementValue(this);
			Compiler.__CustomImpl.PBlock(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<PAlternative> Alternatives
		{
			get => MGetCollection<PAlternative>(Compiler.PBlock_Alternatives);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.PElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Compiler.PElementValueInfo);
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
	
	        public override __MetaModel MetaModel => Compiler.Instance;
	        public override global::System.Type MetaType => typeof(PBlock);
	
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
