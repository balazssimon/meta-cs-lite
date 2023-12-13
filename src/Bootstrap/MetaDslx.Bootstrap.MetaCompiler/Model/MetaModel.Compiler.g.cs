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
		private static readonly __ModelProperty _Declaration_FullName;
		private static readonly __ModelProperty _Declaration_Declarations;
		private static readonly __ModelProperty _Language_Grammar;
		private static readonly __ModelProperty _Grammar_Language;
		private static readonly __ModelProperty _Grammar_Rules;
		private static readonly __ModelProperty _Annotation_AttributeClass;
		private static readonly __ModelProperty _Annotation_Arguments;
		private static readonly __ModelProperty _AnnotationArgument_NamedParameter;
		private static readonly __ModelProperty _AnnotationArgument_Parameter;
		private static readonly __ModelProperty _AnnotationArgument_ParameterType;
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
		private static readonly __ModelProperty _PBlock_ReturnType;
		private static readonly __ModelProperty _PBlock_Alternatives;
		private static readonly __ModelProperty _Expression_Value;
		private static readonly __ModelProperty _ArrayExpression_Items;
	
		static Compiler()
		{
			_Annotation_Arguments = new __ModelProperty(typeof(Annotation), "Arguments", typeof(AnnotationArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Arguments");
			_Annotation_AttributeClass = new __ModelProperty(typeof(Annotation), "AttributeClass", typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType, "AttributeClass");
			_AnnotationArgument_NamedParameter = new __ModelProperty(typeof(AnnotationArgument), "NamedParameter", typeof(__MetaSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, "NamedParameter");
			_AnnotationArgument_Parameter = new __ModelProperty(typeof(AnnotationArgument), "Parameter", typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType, null);
			_AnnotationArgument_ParameterType = new __ModelProperty(typeof(AnnotationArgument), "ParameterType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_AnnotationArgument_Value = new __ModelProperty(typeof(AnnotationArgument), "Value", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single, "Value");
			_ArrayExpression_Items = new __ModelProperty(typeof(ArrayExpression), "Items", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_Declaration_Annotations = new __ModelProperty(typeof(Declaration), "Annotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Attributes");
			_Declaration_Declarations = new __ModelProperty(typeof(Declaration), "Declarations", typeof(Declaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Declaration_FullName = new __ModelProperty(typeof(Declaration), "FullName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Declaration_Name = new __ModelProperty(typeof(Declaration), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.Name, "Name");
			_Expression_Value = new __ModelProperty(typeof(Expression), "Value", typeof(__MetaSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, "Value");
			_Grammar_Language = new __ModelProperty(typeof(Grammar), "Language", typeof(Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
			_Grammar_Rules = new __ModelProperty(typeof(Grammar), "Rules", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LAlternative_Elements = new __ModelProperty(typeof(LAlternative), "Elements", typeof(LElement), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LAlternative_FixedText = new __ModelProperty(typeof(LAlternative), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LAlternative_IsFixed = new __ModelProperty(typeof(LAlternative), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Language_Grammar = new __ModelProperty(typeof(Language), "Grammar", typeof(Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single, null);
			_LBlock_Alternatives = new __ModelProperty(typeof(LBlock), "Alternatives", typeof(LAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LBlock_FixedText = new __ModelProperty(typeof(LBlock), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LBlock_IsFixed = new __ModelProperty(typeof(LBlock), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElement_FixedText = new __ModelProperty(typeof(LElement), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElement_IsFixed = new __ModelProperty(typeof(LElement), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElement_IsNegated = new __ModelProperty(typeof(LElement), "IsNegated", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_LElement_Multiplicity = new __ModelProperty(typeof(LElement), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.Single, null);
			_LElement_Value = new __ModelProperty(typeof(LElement), "Value", typeof(LElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single, null);
			_LElementValue_FixedText = new __ModelProperty(typeof(LElementValue), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LElementValue_IsFixed = new __ModelProperty(typeof(LElementValue), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRule_Alternatives = new __ModelProperty(typeof(LexerRule), "Alternatives", typeof(LAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LexerRule_FixedText = new __ModelProperty(typeof(LexerRule), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRule_IsFixed = new __ModelProperty(typeof(LexerRule), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LexerRule_IsFragment = new __ModelProperty(typeof(LexerRule), "IsFragment", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_LexerRule_IsHidden = new __ModelProperty(typeof(LexerRule), "IsHidden", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_LexerRule_ReturnType = new __ModelProperty(typeof(LexerRule), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_LFixed_FixedText = new __ModelProperty(typeof(LFixed), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LFixed_IsFixed = new __ModelProperty(typeof(LFixed), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LFixed_Text = new __ModelProperty(typeof(LFixed), "Text", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_LRange_EndChar = new __ModelProperty(typeof(LRange), "EndChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_LRange_FixedText = new __ModelProperty(typeof(LRange), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LRange_IsFixed = new __ModelProperty(typeof(LRange), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LRange_StartChar = new __ModelProperty(typeof(LRange), "StartChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_LReference_FixedText = new __ModelProperty(typeof(LReference), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LReference_IsFixed = new __ModelProperty(typeof(LReference), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LReference_Rule = new __ModelProperty(typeof(LReference), "Rule", typeof(LexerRule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
			_LSet_FixedText = new __ModelProperty(typeof(LSet), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSet_IsFixed = new __ModelProperty(typeof(LSet), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSet_Items = new __ModelProperty(typeof(LSet), "Items", typeof(LSetItem), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_LSetItem_FixedText = new __ModelProperty(typeof(LSetItem), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetItem_IsFixed = new __ModelProperty(typeof(LSetItem), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetChar_Char = new __ModelProperty(typeof(LSetChar), "Char", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_LSetChar_FixedText = new __ModelProperty(typeof(LSetChar), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetChar_IsFixed = new __ModelProperty(typeof(LSetChar), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetRange_EndChar = new __ModelProperty(typeof(LSetRange), "EndChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_LSetRange_FixedText = new __ModelProperty(typeof(LSetRange), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetRange_IsFixed = new __ModelProperty(typeof(LSetRange), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LSetRange_StartChar = new __ModelProperty(typeof(LSetRange), "StartChar", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_LWildCard_FixedText = new __ModelProperty(typeof(LWildCard), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_LWildCard_IsFixed = new __ModelProperty(typeof(LWildCard), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_PAlternative_Elements = new __ModelProperty(typeof(PAlternative), "Elements", typeof(PElement), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Elements");
			_PAlternative_ReturnType = new __ModelProperty(typeof(PAlternative), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, "ReturnType");
			_PAlternative_ReturnValue = new __ModelProperty(typeof(PAlternative), "ReturnValue", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single, "ReturnValue");
			_Rule_Grammar = new __ModelProperty(typeof(Rule), "Grammar", typeof(Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
			_Rule_Language = new __ModelProperty(typeof(Rule), "Language", typeof(Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_ParserRule_Alternatives = new __ModelProperty(typeof(ParserRule), "Alternatives", typeof(PAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Alternatives");
			_ParserRule_ReturnType = new __ModelProperty(typeof(ParserRule), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, "ReturnType");
			_PElement_Assignment = new __ModelProperty(typeof(PElement), "Assignment", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.Single, "Assignment");
			_PElement_Multiplicity = new __ModelProperty(typeof(PElement), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.Single, null);
			_PElement_NameAnnotations = new __ModelProperty(typeof(PElement), "NameAnnotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_PElement_SymbolProperty = new __ModelProperty(typeof(PElement), "SymbolProperty", typeof(__MetaSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, "SymbolProperty");
			_PElement_Value = new __ModelProperty(typeof(PElement), "Value", typeof(PElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single, "Value");
			_PElement_ValueAnnotations = new __ModelProperty(typeof(PElement), "ValueAnnotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_PBlock_Alternatives = new __ModelProperty(typeof(PBlock), "Alternatives", typeof(PAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Alternatives");
			_PBlock_ReturnType = new __ModelProperty(typeof(PBlock), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, "ReturnType");
			_PKeyword_Text = new __ModelProperty(typeof(PKeyword), "Text", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
			_PReference_ReferencedTypes = new __ModelProperty(typeof(PReference), "ReferencedTypes", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, "ReferencedTypes");
			_PReference_Rule = new __ModelProperty(typeof(PReference), "Rule", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, "Rule");
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
	
			_classTypes = __ImmutableArray.Create<__MetaType>(typeof(Annotation), typeof(AnnotationArgument), typeof(ArrayExpression), typeof(Declaration), typeof(Expression), typeof(Grammar), typeof(LAlternative), typeof(Language), typeof(LBlock), typeof(LElement), typeof(LElementValue), typeof(LexerRule), typeof(LFixed), typeof(LRange), typeof(LReference), typeof(LSet), typeof(LSetItem), typeof(LSetChar), typeof(LSetRange), typeof(LWildCard), typeof(Namespace), typeof(PAlternative), typeof(Rule), typeof(ParserRule), typeof(PElement), typeof(PElementValue), typeof(PBlock), typeof(PEof), typeof(PKeyword), typeof(PReference));
			_classInfos = __ImmutableArray.Create<__ModelClassInfo>(AnnotationInfo, AnnotationArgumentInfo, ArrayExpressionInfo, DeclarationInfo, ExpressionInfo, GrammarInfo, LAlternativeInfo, LanguageInfo, LBlockInfo, LElementInfo, LElementValueInfo, LexerRuleInfo, LFixedInfo, LRangeInfo, LReferenceInfo, LSetInfo, LSetItemInfo, LSetCharInfo, LSetRangeInfo, LWildCardInfo, NamespaceInfo, PAlternativeInfo, RuleInfo, ParserRuleInfo, PElementInfo, PElementValueInfo, PBlockInfo, PEofInfo, PKeywordInfo, PReferenceInfo);
			var classInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelClassInfo>();
			classInfosByType.Add(typeof(Annotation), AnnotationInfo);
			classInfosByType.Add(typeof(AnnotationArgument), AnnotationArgumentInfo);
			classInfosByType.Add(typeof(ArrayExpression), ArrayExpressionInfo);
			classInfosByType.Add(typeof(Declaration), DeclarationInfo);
			classInfosByType.Add(typeof(Expression), ExpressionInfo);
			classInfosByType.Add(typeof(Grammar), GrammarInfo);
			classInfosByType.Add(typeof(LAlternative), LAlternativeInfo);
			classInfosByType.Add(typeof(Language), LanguageInfo);
			classInfosByType.Add(typeof(LBlock), LBlockInfo);
			classInfosByType.Add(typeof(LElement), LElementInfo);
			classInfosByType.Add(typeof(LElementValue), LElementValueInfo);
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
			classInfosByType.Add(typeof(PAlternative), PAlternativeInfo);
			classInfosByType.Add(typeof(Rule), RuleInfo);
			classInfosByType.Add(typeof(ParserRule), ParserRuleInfo);
			classInfosByType.Add(typeof(PElement), PElementInfo);
			classInfosByType.Add(typeof(PElementValue), PElementValueInfo);
			classInfosByType.Add(typeof(PBlock), PBlockInfo);
			classInfosByType.Add(typeof(PEof), PEofInfo);
			classInfosByType.Add(typeof(PKeyword), PKeywordInfo);
			classInfosByType.Add(typeof(PReference), PReferenceInfo);
			_classInfosByType = classInfosByType.ToImmutable();
			var classInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelClassInfo>();
			classInfosByName.Add("Annotation", AnnotationInfo);
			classInfosByName.Add("AnnotationArgument", AnnotationArgumentInfo);
			classInfosByName.Add("ArrayExpression", ArrayExpressionInfo);
			classInfosByName.Add("Declaration", DeclarationInfo);
			classInfosByName.Add("Expression", ExpressionInfo);
			classInfosByName.Add("Grammar", GrammarInfo);
			classInfosByName.Add("LAlternative", LAlternativeInfo);
			classInfosByName.Add("Language", LanguageInfo);
			classInfosByName.Add("LBlock", LBlockInfo);
			classInfosByName.Add("LElement", LElementInfo);
			classInfosByName.Add("LElementValue", LElementValueInfo);
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
			classInfosByName.Add("PAlternative", PAlternativeInfo);
			classInfosByName.Add("Rule", RuleInfo);
			classInfosByName.Add("ParserRule", ParserRuleInfo);
			classInfosByName.Add("PElement", PElementInfo);
			classInfosByName.Add("PElementValue", PElementValueInfo);
			classInfosByName.Add("PBlock", PBlockInfo);
			classInfosByName.Add("PEof", PEofInfo);
			classInfosByName.Add("PKeyword", PKeywordInfo);
			classInfosByName.Add("PReference", PReferenceInfo);
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
			var obj39 = f.MetaProperty();
			var obj40 = f.MetaProperty();
			var obj41 = f.MetaProperty();
			var obj42 = f.MetaProperty();
			var obj43 = f.MetaArrayType();
			var obj44 = f.MetaNullableType();
			var obj45 = f.MetaNullableType();
			var obj46 = f.MetaArrayType();
			var obj47 = f.MetaProperty();
			var obj48 = f.MetaProperty();
			var obj49 = f.MetaProperty();
			var obj50 = f.MetaArrayType();
			var obj51 = f.MetaProperty();
			var obj52 = f.MetaProperty();
			var obj53 = f.MetaArrayType();
			var obj54 = f.MetaProperty();
			var obj55 = f.MetaProperty();
			var obj56 = f.MetaProperty();
			var obj57 = f.MetaProperty();
			var obj58 = f.MetaArrayType();
			var obj59 = f.MetaEnumLiteral();
			var obj60 = f.MetaEnumLiteral();
			var obj61 = f.MetaEnumLiteral();
			var obj62 = f.MetaEnumLiteral();
			var obj63 = f.MetaEnumLiteral();
			var obj64 = f.MetaEnumLiteral();
			var obj65 = f.MetaEnumLiteral();
			var obj66 = f.MetaProperty();
			var obj67 = f.MetaProperty();
			var obj68 = f.MetaProperty();
			var obj69 = f.MetaProperty();
			var obj70 = f.MetaProperty();
			var obj71 = f.MetaProperty();
			var obj72 = f.MetaProperty();
			var obj73 = f.MetaProperty();
			var obj74 = f.MetaNullableType();
			var obj75 = f.MetaArrayType();
			var obj76 = f.MetaProperty();
			var obj77 = f.MetaProperty();
			var obj78 = f.MetaProperty();
			var obj79 = f.MetaNullableType();
			var obj80 = f.MetaArrayType();
			var obj81 = f.MetaProperty();
			var obj82 = f.MetaProperty();
			var obj83 = f.MetaProperty();
			var obj84 = f.MetaProperty();
			var obj85 = f.MetaProperty();
			var obj86 = f.MetaNullableType();
			var obj87 = f.MetaProperty();
			var obj88 = f.MetaProperty();
			var obj89 = f.MetaNullableType();
			var obj90 = f.MetaProperty();
			var obj91 = f.MetaProperty();
			var obj92 = f.MetaProperty();
			var obj93 = f.MetaNullableType();
			var obj94 = f.MetaProperty();
			var obj95 = f.MetaProperty();
			var obj96 = f.MetaProperty();
			var obj97 = f.MetaNullableType();
			var obj98 = f.MetaProperty();
			var obj99 = f.MetaProperty();
			var obj100 = f.MetaNullableType();
			var obj101 = f.MetaProperty();
			var obj102 = f.MetaProperty();
			var obj103 = f.MetaProperty();
			var obj104 = f.MetaProperty();
			var obj105 = f.MetaNullableType();
			var obj106 = f.MetaProperty();
			var obj107 = f.MetaProperty();
			var obj108 = f.MetaProperty();
			var obj109 = f.MetaNullableType();
			var obj110 = f.MetaArrayType();
			var obj111 = f.MetaProperty();
			var obj112 = f.MetaProperty();
			var obj113 = f.MetaNullableType();
			var obj114 = f.MetaProperty();
			var obj115 = f.MetaProperty();
			var obj116 = f.MetaProperty();
			var obj117 = f.MetaNullableType();
			var obj118 = f.MetaProperty();
			var obj119 = f.MetaProperty();
			var obj120 = f.MetaProperty();
			var obj121 = f.MetaProperty();
			var obj122 = f.MetaNullableType();
			var obj123 = f.MetaProperty();
			var obj124 = f.MetaProperty();
			var obj125 = f.MetaProperty();
			var obj126 = f.MetaNullableType();
			var obj127 = f.MetaArrayType();
			var obj128 = f.MetaProperty();
			var obj129 = f.MetaProperty();
			var obj130 = f.MetaArrayType();
			var obj131 = f.MetaProperty();
			var obj132 = f.MetaProperty();
			var obj133 = f.MetaProperty();
			var obj134 = f.MetaArrayType();
			var obj135 = f.MetaEnumLiteral();
			var obj136 = f.MetaEnumLiteral();
			var obj137 = f.MetaEnumLiteral();
			var obj138 = f.MetaEnumLiteral();
			var obj139 = f.MetaProperty();
			var obj140 = f.MetaProperty();
			var obj141 = f.MetaProperty();
			var obj142 = f.MetaProperty();
			var obj143 = f.MetaProperty();
			var obj144 = f.MetaProperty();
			var obj145 = f.MetaArrayType();
			var obj146 = f.MetaArrayType();
			var obj147 = f.MetaArrayType();
			var obj148 = f.MetaProperty();
			var obj149 = f.MetaProperty();
			var obj150 = f.MetaArrayType();
			var obj151 = f.MetaProperty();
			var obj152 = f.MetaProperty();
			var obj153 = f.MetaProperty();
			var obj154 = f.MetaArrayType();
			var obj155 = f.MetaProperty();
			var obj156 = f.MetaProperty();
			var obj157 = f.MetaArrayType();
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
			obj5.Name = "Model";
			obj5.Parent = obj4;
			obj6.Name = "Compiler";
			obj6.Parent = obj5;
			((__IModelObject)obj7).Children.Add((__IModelObject)obj39);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj40);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj41);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj42);
			obj7.IsAbstract = true;
			obj7.Properties.Add(obj39);
			obj7.Properties.Add(obj40);
			obj7.Properties.Add(obj41);
			obj7.Properties.Add(obj42);
			obj7.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
			obj7.Declarations.Add(obj39);
			obj7.Declarations.Add(obj40);
			obj7.Declarations.Add(obj41);
			obj7.Declarations.Add(obj42);
			obj7.Name = "Declaration";
			obj7.Parent = obj5;
			obj8.BaseTypes.Add(obj7);
			obj8.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
			obj8.Name = "Namespace";
			obj8.Parent = obj5;
			((__IModelObject)obj9).Children.Add((__IModelObject)obj47);
			obj9.BaseTypes.Add(obj7);
			obj9.Properties.Add(obj47);
			obj9.Declarations.Add(obj47);
			obj9.Name = "Language";
			obj9.Parent = obj5;
			((__IModelObject)obj10).Children.Add((__IModelObject)obj48);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj49);
			obj10.BaseTypes.Add(obj7);
			obj10.Properties.Add(obj48);
			obj10.Properties.Add(obj49);
			obj10.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.GrammarSymbol);
			obj10.Declarations.Add(obj48);
			obj10.Declarations.Add(obj49);
			obj10.Name = "Grammar";
			obj10.Parent = obj5;
			((__IModelObject)obj11).Children.Add((__IModelObject)obj51);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj52);
			obj11.Properties.Add(obj51);
			obj11.Properties.Add(obj52);
			obj11.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.AnnotationSymbol);
			obj11.Declarations.Add(obj51);
			obj11.Declarations.Add(obj52);
			obj11.Name = "Annotation";
			obj11.Parent = obj5;
			((__IModelObject)obj12).Children.Add((__IModelObject)obj54);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj55);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj56);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj57);
			obj12.Properties.Add(obj54);
			obj12.Properties.Add(obj55);
			obj12.Properties.Add(obj56);
			obj12.Properties.Add(obj57);
			obj12.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.AnnotationArgumentSymbol);
			obj12.Declarations.Add(obj54);
			obj12.Declarations.Add(obj55);
			obj12.Declarations.Add(obj56);
			obj12.Declarations.Add(obj57);
			obj12.Name = "AnnotationArgument";
			obj12.Parent = obj5;
			((__IModelObject)obj13).Children.Add((__IModelObject)obj59);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj60);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj61);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj62);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj63);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj64);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj65);
			obj13.Literals.Add(obj59);
			obj13.Literals.Add(obj60);
			obj13.Literals.Add(obj61);
			obj13.Literals.Add(obj62);
			obj13.Literals.Add(obj63);
			obj13.Literals.Add(obj64);
			obj13.Literals.Add(obj65);
			obj13.Declarations.Add(obj59);
			obj13.Declarations.Add(obj60);
			obj13.Declarations.Add(obj61);
			obj13.Declarations.Add(obj62);
			obj13.Declarations.Add(obj63);
			obj13.Declarations.Add(obj64);
			obj13.Declarations.Add(obj65);
			obj13.Name = "Multiplicity";
			obj13.Parent = obj5;
			((__IModelObject)obj14).Children.Add((__IModelObject)obj66);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj67);
			obj14.BaseTypes.Add(obj7);
			obj14.IsAbstract = true;
			obj14.Properties.Add(obj66);
			obj14.Properties.Add(obj67);
			obj14.Declarations.Add(obj66);
			obj14.Declarations.Add(obj67);
			obj14.Name = "Rule";
			obj14.Parent = obj5;
			((__IModelObject)obj15).Children.Add((__IModelObject)obj68);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj69);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj70);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj71);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj72);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj73);
			obj15.BaseTypes.Add(obj14);
			obj15.Properties.Add(obj68);
			obj15.Properties.Add(obj69);
			obj15.Properties.Add(obj70);
			obj15.Properties.Add(obj71);
			obj15.Properties.Add(obj72);
			obj15.Properties.Add(obj73);
			obj15.Declarations.Add(obj68);
			obj15.Declarations.Add(obj69);
			obj15.Declarations.Add(obj70);
			obj15.Declarations.Add(obj71);
			obj15.Declarations.Add(obj72);
			obj15.Declarations.Add(obj73);
			obj15.Name = "LexerRule";
			obj15.Parent = obj5;
			((__IModelObject)obj16).Children.Add((__IModelObject)obj76);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj77);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj78);
			obj16.Properties.Add(obj76);
			obj16.Properties.Add(obj77);
			obj16.Properties.Add(obj78);
			obj16.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj16.Declarations.Add(obj76);
			obj16.Declarations.Add(obj77);
			obj16.Declarations.Add(obj78);
			obj16.Name = "LAlternative";
			obj16.Parent = obj5;
			((__IModelObject)obj17).Children.Add((__IModelObject)obj81);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj82);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj83);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj84);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj85);
			obj17.Properties.Add(obj81);
			obj17.Properties.Add(obj82);
			obj17.Properties.Add(obj83);
			obj17.Properties.Add(obj84);
			obj17.Properties.Add(obj85);
			obj17.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj17.Declarations.Add(obj81);
			obj17.Declarations.Add(obj82);
			obj17.Declarations.Add(obj83);
			obj17.Declarations.Add(obj84);
			obj17.Declarations.Add(obj85);
			obj17.Name = "LElement";
			obj17.Parent = obj5;
			((__IModelObject)obj18).Children.Add((__IModelObject)obj87);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj88);
			obj18.IsAbstract = true;
			obj18.Properties.Add(obj87);
			obj18.Properties.Add(obj88);
			obj18.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj18.Declarations.Add(obj87);
			obj18.Declarations.Add(obj88);
			obj18.Name = "LElementValue";
			obj18.Parent = obj5;
			((__IModelObject)obj19).Children.Add((__IModelObject)obj90);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj91);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj92);
			obj19.BaseTypes.Add(obj18);
			obj19.Properties.Add(obj90);
			obj19.Properties.Add(obj91);
			obj19.Properties.Add(obj92);
			obj19.Declarations.Add(obj90);
			obj19.Declarations.Add(obj91);
			obj19.Declarations.Add(obj92);
			obj19.Name = "LReference";
			obj19.Parent = obj5;
			((__IModelObject)obj20).Children.Add((__IModelObject)obj94);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj95);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj96);
			obj20.BaseTypes.Add(obj18);
			obj20.Properties.Add(obj94);
			obj20.Properties.Add(obj95);
			obj20.Properties.Add(obj96);
			obj20.Declarations.Add(obj94);
			obj20.Declarations.Add(obj95);
			obj20.Declarations.Add(obj96);
			obj20.Name = "LFixed";
			obj20.Parent = obj5;
			((__IModelObject)obj21).Children.Add((__IModelObject)obj98);
			((__IModelObject)obj21).Children.Add((__IModelObject)obj99);
			obj21.BaseTypes.Add(obj18);
			obj21.Properties.Add(obj98);
			obj21.Properties.Add(obj99);
			obj21.Declarations.Add(obj98);
			obj21.Declarations.Add(obj99);
			obj21.Name = "LWildCard";
			obj21.Parent = obj5;
			((__IModelObject)obj22).Children.Add((__IModelObject)obj101);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj102);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj103);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj104);
			obj22.BaseTypes.Add(obj18);
			obj22.Properties.Add(obj101);
			obj22.Properties.Add(obj102);
			obj22.Properties.Add(obj103);
			obj22.Properties.Add(obj104);
			obj22.Declarations.Add(obj101);
			obj22.Declarations.Add(obj102);
			obj22.Declarations.Add(obj103);
			obj22.Declarations.Add(obj104);
			obj22.Name = "LRange";
			obj22.Parent = obj5;
			((__IModelObject)obj23).Children.Add((__IModelObject)obj106);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj107);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj108);
			obj23.BaseTypes.Add(obj18);
			obj23.Properties.Add(obj106);
			obj23.Properties.Add(obj107);
			obj23.Properties.Add(obj108);
			obj23.Declarations.Add(obj106);
			obj23.Declarations.Add(obj107);
			obj23.Declarations.Add(obj108);
			obj23.Name = "LSet";
			obj23.Parent = obj5;
			((__IModelObject)obj24).Children.Add((__IModelObject)obj111);
			((__IModelObject)obj24).Children.Add((__IModelObject)obj112);
			obj24.IsAbstract = true;
			obj24.Properties.Add(obj111);
			obj24.Properties.Add(obj112);
			obj24.Declarations.Add(obj111);
			obj24.Declarations.Add(obj112);
			obj24.Name = "LSetItem";
			obj24.Parent = obj5;
			((__IModelObject)obj25).Children.Add((__IModelObject)obj114);
			((__IModelObject)obj25).Children.Add((__IModelObject)obj115);
			((__IModelObject)obj25).Children.Add((__IModelObject)obj116);
			obj25.BaseTypes.Add(obj24);
			obj25.Properties.Add(obj114);
			obj25.Properties.Add(obj115);
			obj25.Properties.Add(obj116);
			obj25.Declarations.Add(obj114);
			obj25.Declarations.Add(obj115);
			obj25.Declarations.Add(obj116);
			obj25.Name = "LSetChar";
			obj25.Parent = obj5;
			((__IModelObject)obj26).Children.Add((__IModelObject)obj118);
			((__IModelObject)obj26).Children.Add((__IModelObject)obj119);
			((__IModelObject)obj26).Children.Add((__IModelObject)obj120);
			((__IModelObject)obj26).Children.Add((__IModelObject)obj121);
			obj26.BaseTypes.Add(obj24);
			obj26.Properties.Add(obj118);
			obj26.Properties.Add(obj119);
			obj26.Properties.Add(obj120);
			obj26.Properties.Add(obj121);
			obj26.Declarations.Add(obj118);
			obj26.Declarations.Add(obj119);
			obj26.Declarations.Add(obj120);
			obj26.Declarations.Add(obj121);
			obj26.Name = "LSetRange";
			obj26.Parent = obj5;
			((__IModelObject)obj27).Children.Add((__IModelObject)obj123);
			((__IModelObject)obj27).Children.Add((__IModelObject)obj124);
			((__IModelObject)obj27).Children.Add((__IModelObject)obj125);
			obj27.BaseTypes.Add(obj18);
			obj27.Properties.Add(obj123);
			obj27.Properties.Add(obj124);
			obj27.Properties.Add(obj125);
			obj27.Declarations.Add(obj123);
			obj27.Declarations.Add(obj124);
			obj27.Declarations.Add(obj125);
			obj27.Name = "LBlock";
			obj27.Parent = obj5;
			((__IModelObject)obj28).Children.Add((__IModelObject)obj128);
			((__IModelObject)obj28).Children.Add((__IModelObject)obj129);
			obj28.BaseTypes.Add(obj14);
			obj28.IsAbstract = true;
			obj28.Properties.Add(obj128);
			obj28.Properties.Add(obj129);
			obj28.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ParserRuleSymbol);
			obj28.Declarations.Add(obj128);
			obj28.Declarations.Add(obj129);
			obj28.Name = "ParserRule";
			obj28.Parent = obj5;
			((__IModelObject)obj29).Children.Add((__IModelObject)obj131);
			((__IModelObject)obj29).Children.Add((__IModelObject)obj132);
			((__IModelObject)obj29).Children.Add((__IModelObject)obj133);
			obj29.BaseTypes.Add(obj7);
			obj29.Properties.Add(obj131);
			obj29.Properties.Add(obj132);
			obj29.Properties.Add(obj133);
			obj29.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PAlternativeSymbol);
			obj29.Declarations.Add(obj131);
			obj29.Declarations.Add(obj132);
			obj29.Declarations.Add(obj133);
			obj29.Name = "PAlternative";
			obj29.Parent = obj5;
			((__IModelObject)obj30).Children.Add((__IModelObject)obj135);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj136);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj137);
			((__IModelObject)obj30).Children.Add((__IModelObject)obj138);
			obj30.Literals.Add(obj135);
			obj30.Literals.Add(obj136);
			obj30.Literals.Add(obj137);
			obj30.Literals.Add(obj138);
			obj30.Declarations.Add(obj135);
			obj30.Declarations.Add(obj136);
			obj30.Declarations.Add(obj137);
			obj30.Declarations.Add(obj138);
			obj30.Name = "Assignment";
			obj30.Parent = obj5;
			((__IModelObject)obj31).Children.Add((__IModelObject)obj139);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj140);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj141);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj142);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj143);
			((__IModelObject)obj31).Children.Add((__IModelObject)obj144);
			obj31.Properties.Add(obj139);
			obj31.Properties.Add(obj140);
			obj31.Properties.Add(obj141);
			obj31.Properties.Add(obj142);
			obj31.Properties.Add(obj143);
			obj31.Properties.Add(obj144);
			obj31.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PElementSymbol);
			obj31.Declarations.Add(obj139);
			obj31.Declarations.Add(obj140);
			obj31.Declarations.Add(obj141);
			obj31.Declarations.Add(obj142);
			obj31.Declarations.Add(obj143);
			obj31.Declarations.Add(obj144);
			obj31.Name = "PElement";
			obj31.Parent = obj5;
			obj32.IsAbstract = true;
			obj32.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
			obj32.Name = "PElementValue";
			obj32.Parent = obj5;
			((__IModelObject)obj33).Children.Add((__IModelObject)obj148);
			((__IModelObject)obj33).Children.Add((__IModelObject)obj149);
			obj33.BaseTypes.Add(obj32);
			obj33.Properties.Add(obj148);
			obj33.Properties.Add(obj149);
			obj33.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PReferenceSymbol);
			obj33.Declarations.Add(obj148);
			obj33.Declarations.Add(obj149);
			obj33.Name = "PReference";
			obj33.Parent = obj5;
			obj34.BaseTypes.Add(obj32);
			obj34.Name = "PEof";
			obj34.Parent = obj5;
			((__IModelObject)obj35).Children.Add((__IModelObject)obj151);
			obj35.BaseTypes.Add(obj32);
			obj35.Properties.Add(obj151);
			obj35.Declarations.Add(obj151);
			obj35.Name = "PKeyword";
			obj35.Parent = obj5;
			((__IModelObject)obj36).Children.Add((__IModelObject)obj152);
			((__IModelObject)obj36).Children.Add((__IModelObject)obj153);
			obj36.BaseTypes.Add(obj14);
			obj36.BaseTypes.Add(obj32);
			obj36.Properties.Add(obj152);
			obj36.Properties.Add(obj153);
			obj36.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PBlockSymbol);
			obj36.Declarations.Add(obj152);
			obj36.Declarations.Add(obj153);
			obj36.Name = "PBlock";
			obj36.Parent = obj5;
			((__IModelObject)obj37).Children.Add((__IModelObject)obj155);
			obj37.Properties.Add(obj155);
			obj37.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
			obj37.Declarations.Add(obj155);
			obj37.Name = "Expression";
			obj37.Parent = obj5;
			((__IModelObject)obj38).Children.Add((__IModelObject)obj156);
			obj38.BaseTypes.Add(obj37);
			obj38.Properties.Add(obj156);
			obj38.Declarations.Add(obj156);
			obj38.Name = "ArrayExpression";
			obj38.Parent = obj5;
			((__IModelObject)obj39).Children.Add((__IModelObject)obj43);
			obj39.IsContainment = true;
			obj39.SymbolProperty = "Attributes";
			obj39.Type = __MetaType.FromModelObject((__IModelObject)obj43);
			obj39.Name = "Annotations";
			obj39.Parent = obj7;
			((__IModelObject)obj40).Children.Add((__IModelObject)obj44);
			obj40.SymbolProperty = "Name";
			obj40.Type = __MetaType.FromModelObject((__IModelObject)obj44);
			obj40.Name = "Name";
			obj40.Parent = obj7;
			((__IModelObject)obj41).Children.Add((__IModelObject)obj45);
			obj41.IsDerived = true;
			obj41.Type = __MetaType.FromModelObject((__IModelObject)obj45);
			obj41.Name = "FullName";
			obj41.Parent = obj7;
			((__IModelObject)obj42).Children.Add((__IModelObject)obj46);
			obj42.IsContainment = true;
			obj42.Type = __MetaType.FromModelObject((__IModelObject)obj46);
			obj42.Name = "Declarations";
			obj42.Parent = obj7;
			obj43.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj44.InnerType = typeof(string);
			obj45.InnerType = typeof(string);
			obj46.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj47.IsContainment = true;
			obj47.Type = __MetaType.FromModelObject((__IModelObject)obj10);
			obj47.Name = "Grammar";
			obj47.Parent = obj9;
			obj48.Type = __MetaType.FromModelObject((__IModelObject)obj9);
			obj48.Name = "Language";
			obj48.Parent = obj10;
			((__IModelObject)obj49).Children.Add((__IModelObject)obj50);
			obj49.IsContainment = true;
			obj49.Type = __MetaType.FromModelObject((__IModelObject)obj50);
			obj49.Name = "Rules";
			obj49.Parent = obj10;
			obj50.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj51.SymbolProperty = "AttributeClass";
			obj51.Type = typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
			obj51.Name = "AttributeClass";
			obj51.Parent = obj11;
			((__IModelObject)obj52).Children.Add((__IModelObject)obj53);
			obj52.IsContainment = true;
			obj52.SymbolProperty = "Arguments";
			obj52.Type = __MetaType.FromModelObject((__IModelObject)obj53);
			obj52.Name = "Arguments";
			obj52.Parent = obj11;
			obj53.ItemType = __MetaType.FromModelObject((__IModelObject)obj12);
			((__IModelObject)obj54).Children.Add((__IModelObject)obj58);
			obj54.SymbolProperty = "NamedParameter";
			obj54.Type = __MetaType.FromModelObject((__IModelObject)obj58);
			obj54.Name = "NamedParameter";
			obj54.Parent = obj12;
			obj55.Type = typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
			obj55.Name = "Parameter";
			obj55.Parent = obj12;
			obj56.Type = typeof(__MetaType);
			obj56.Name = "ParameterType";
			obj56.Parent = obj12;
			obj57.IsContainment = true;
			obj57.SymbolProperty = "Value";
			obj57.Type = __MetaType.FromModelObject((__IModelObject)obj37);
			obj57.Name = "Value";
			obj57.Parent = obj12;
			obj58.ItemType = typeof(__MetaSymbol);
			obj59.Name = "ExactlyOne";
			obj59.Parent = obj13;
			obj60.Name = "ZeroOrOne";
			obj60.Parent = obj13;
			obj61.Name = "ZeroOrMore";
			obj61.Parent = obj13;
			obj62.Name = "OneOrMore";
			obj62.Parent = obj13;
			obj63.Name = "NonGreedyZeroOrOne";
			obj63.Parent = obj13;
			obj64.Name = "NonGreedyZeroOrMore";
			obj64.Parent = obj13;
			obj65.Name = "NonGreedyOneOrMore";
			obj65.Parent = obj13;
			obj66.IsDerived = true;
			obj66.Type = __MetaType.FromModelObject((__IModelObject)obj9);
			obj66.Name = "Language";
			obj66.Parent = obj14;
			obj67.Type = __MetaType.FromModelObject((__IModelObject)obj10);
			obj67.Name = "Grammar";
			obj67.Parent = obj14;
			obj68.Type = typeof(__MetaType);
			obj68.Name = "ReturnType";
			obj68.Parent = obj15;
			obj69.Type = typeof(bool);
			obj69.Name = "IsHidden";
			obj69.Parent = obj15;
			obj70.Type = typeof(bool);
			obj70.Name = "IsFragment";
			obj70.Parent = obj15;
			obj71.IsDerived = true;
			obj71.Type = typeof(bool);
			obj71.Name = "IsFixed";
			obj71.Parent = obj15;
			((__IModelObject)obj72).Children.Add((__IModelObject)obj74);
			obj72.IsDerived = true;
			obj72.Type = __MetaType.FromModelObject((__IModelObject)obj74);
			obj72.Name = "FixedText";
			obj72.Parent = obj15;
			((__IModelObject)obj73).Children.Add((__IModelObject)obj75);
			obj73.IsContainment = true;
			obj73.Type = __MetaType.FromModelObject((__IModelObject)obj75);
			obj73.Name = "Alternatives";
			obj73.Parent = obj15;
			obj74.InnerType = typeof(string);
			obj75.ItemType = __MetaType.FromModelObject((__IModelObject)obj16);
			obj76.IsDerived = true;
			obj76.Type = typeof(bool);
			obj76.Name = "IsFixed";
			obj76.Parent = obj16;
			((__IModelObject)obj77).Children.Add((__IModelObject)obj79);
			obj77.IsDerived = true;
			obj77.Type = __MetaType.FromModelObject((__IModelObject)obj79);
			obj77.Name = "FixedText";
			obj77.Parent = obj16;
			((__IModelObject)obj78).Children.Add((__IModelObject)obj80);
			obj78.IsContainment = true;
			obj78.Type = __MetaType.FromModelObject((__IModelObject)obj80);
			obj78.Name = "Elements";
			obj78.Parent = obj16;
			obj79.InnerType = typeof(string);
			obj80.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
			obj81.IsDerived = true;
			obj81.Type = typeof(bool);
			obj81.Name = "IsFixed";
			obj81.Parent = obj17;
			((__IModelObject)obj82).Children.Add((__IModelObject)obj86);
			obj82.IsDerived = true;
			obj82.Type = __MetaType.FromModelObject((__IModelObject)obj86);
			obj82.Name = "FixedText";
			obj82.Parent = obj17;
			obj83.Type = typeof(bool);
			obj83.Name = "IsNegated";
			obj83.Parent = obj17;
			obj84.IsContainment = true;
			obj84.Type = __MetaType.FromModelObject((__IModelObject)obj18);
			obj84.Name = "Value";
			obj84.Parent = obj17;
			obj85.Type = __MetaType.FromModelObject((__IModelObject)obj13);
			obj85.Name = "Multiplicity";
			obj85.Parent = obj17;
			obj86.InnerType = typeof(string);
			obj87.IsDerived = true;
			obj87.Type = typeof(bool);
			obj87.Name = "IsFixed";
			obj87.Parent = obj18;
			((__IModelObject)obj88).Children.Add((__IModelObject)obj89);
			obj88.IsDerived = true;
			obj88.Type = __MetaType.FromModelObject((__IModelObject)obj89);
			obj88.Name = "FixedText";
			obj88.Parent = obj18;
			obj89.InnerType = typeof(string);
			obj90.IsDerived = true;
			obj90.Type = typeof(bool);
			obj90.Name = "IsFixed";
			obj90.Parent = obj19;
			((__IModelObject)obj91).Children.Add((__IModelObject)obj93);
			obj91.IsDerived = true;
			obj91.Type = __MetaType.FromModelObject((__IModelObject)obj93);
			obj91.Name = "FixedText";
			obj91.Parent = obj19;
			obj92.Type = __MetaType.FromModelObject((__IModelObject)obj15);
			obj92.Name = "Rule";
			obj92.Parent = obj19;
			obj93.InnerType = typeof(string);
			obj94.IsDerived = true;
			obj94.Type = typeof(bool);
			obj94.Name = "IsFixed";
			obj94.Parent = obj20;
			((__IModelObject)obj95).Children.Add((__IModelObject)obj97);
			obj95.IsDerived = true;
			obj95.Type = __MetaType.FromModelObject((__IModelObject)obj97);
			obj95.Name = "FixedText";
			obj95.Parent = obj20;
			obj96.Type = typeof(string);
			obj96.Name = "Text";
			obj96.Parent = obj20;
			obj97.InnerType = typeof(string);
			obj98.IsDerived = true;
			obj98.Type = typeof(bool);
			obj98.Name = "IsFixed";
			obj98.Parent = obj21;
			((__IModelObject)obj99).Children.Add((__IModelObject)obj100);
			obj99.IsDerived = true;
			obj99.Type = __MetaType.FromModelObject((__IModelObject)obj100);
			obj99.Name = "FixedText";
			obj99.Parent = obj21;
			obj100.InnerType = typeof(string);
			obj101.IsDerived = true;
			obj101.Type = typeof(bool);
			obj101.Name = "IsFixed";
			obj101.Parent = obj22;
			((__IModelObject)obj102).Children.Add((__IModelObject)obj105);
			obj102.IsDerived = true;
			obj102.Type = __MetaType.FromModelObject((__IModelObject)obj105);
			obj102.Name = "FixedText";
			obj102.Parent = obj22;
			obj103.Type = typeof(string);
			obj103.Name = "StartChar";
			obj103.Parent = obj22;
			obj104.Type = typeof(string);
			obj104.Name = "EndChar";
			obj104.Parent = obj22;
			obj105.InnerType = typeof(string);
			obj106.IsDerived = true;
			obj106.Type = typeof(bool);
			obj106.Name = "IsFixed";
			obj106.Parent = obj23;
			((__IModelObject)obj107).Children.Add((__IModelObject)obj109);
			obj107.IsDerived = true;
			obj107.Type = __MetaType.FromModelObject((__IModelObject)obj109);
			obj107.Name = "FixedText";
			obj107.Parent = obj23;
			((__IModelObject)obj108).Children.Add((__IModelObject)obj110);
			obj108.IsContainment = true;
			obj108.Type = __MetaType.FromModelObject((__IModelObject)obj110);
			obj108.Name = "Items";
			obj108.Parent = obj23;
			obj109.InnerType = typeof(string);
			obj110.ItemType = __MetaType.FromModelObject((__IModelObject)obj24);
			obj111.IsDerived = true;
			obj111.Type = typeof(bool);
			obj111.Name = "IsFixed";
			obj111.Parent = obj24;
			((__IModelObject)obj112).Children.Add((__IModelObject)obj113);
			obj112.IsDerived = true;
			obj112.Type = __MetaType.FromModelObject((__IModelObject)obj113);
			obj112.Name = "FixedText";
			obj112.Parent = obj24;
			obj113.InnerType = typeof(string);
			obj114.IsDerived = true;
			obj114.Type = typeof(bool);
			obj114.Name = "IsFixed";
			obj114.Parent = obj25;
			((__IModelObject)obj115).Children.Add((__IModelObject)obj117);
			obj115.IsDerived = true;
			obj115.Type = __MetaType.FromModelObject((__IModelObject)obj117);
			obj115.Name = "FixedText";
			obj115.Parent = obj25;
			obj116.Type = typeof(string);
			obj116.Name = "Char";
			obj116.Parent = obj25;
			obj117.InnerType = typeof(string);
			obj118.IsDerived = true;
			obj118.Type = typeof(bool);
			obj118.Name = "IsFixed";
			obj118.Parent = obj26;
			((__IModelObject)obj119).Children.Add((__IModelObject)obj122);
			obj119.IsDerived = true;
			obj119.Type = __MetaType.FromModelObject((__IModelObject)obj122);
			obj119.Name = "FixedText";
			obj119.Parent = obj26;
			obj120.Type = typeof(string);
			obj120.Name = "StartChar";
			obj120.Parent = obj26;
			obj121.Type = typeof(string);
			obj121.Name = "EndChar";
			obj121.Parent = obj26;
			obj122.InnerType = typeof(string);
			obj123.IsDerived = true;
			obj123.Type = typeof(bool);
			obj123.Name = "IsFixed";
			obj123.Parent = obj27;
			((__IModelObject)obj124).Children.Add((__IModelObject)obj126);
			obj124.IsDerived = true;
			obj124.Type = __MetaType.FromModelObject((__IModelObject)obj126);
			obj124.Name = "FixedText";
			obj124.Parent = obj27;
			((__IModelObject)obj125).Children.Add((__IModelObject)obj127);
			obj125.IsContainment = true;
			obj125.Type = __MetaType.FromModelObject((__IModelObject)obj127);
			obj125.Name = "Alternatives";
			obj125.Parent = obj27;
			obj126.InnerType = typeof(string);
			obj127.ItemType = __MetaType.FromModelObject((__IModelObject)obj16);
			obj128.SymbolProperty = "ReturnType";
			obj128.Type = typeof(__MetaType);
			obj128.Name = "ReturnType";
			obj128.Parent = obj28;
			((__IModelObject)obj129).Children.Add((__IModelObject)obj130);
			obj129.IsContainment = true;
			obj129.SymbolProperty = "Alternatives";
			obj129.Type = __MetaType.FromModelObject((__IModelObject)obj130);
			obj129.Name = "Alternatives";
			obj129.Parent = obj28;
			obj130.ItemType = __MetaType.FromModelObject((__IModelObject)obj29);
			obj131.SymbolProperty = "ReturnType";
			obj131.Type = typeof(__MetaType);
			obj131.Name = "ReturnType";
			obj131.Parent = obj29;
			obj132.IsContainment = true;
			obj132.SymbolProperty = "ReturnValue";
			obj132.Type = __MetaType.FromModelObject((__IModelObject)obj37);
			obj132.Name = "ReturnValue";
			obj132.Parent = obj29;
			((__IModelObject)obj133).Children.Add((__IModelObject)obj134);
			obj133.IsContainment = true;
			obj133.SymbolProperty = "Elements";
			obj133.Type = __MetaType.FromModelObject((__IModelObject)obj134);
			obj133.Name = "Elements";
			obj133.Parent = obj29;
			obj134.ItemType = __MetaType.FromModelObject((__IModelObject)obj31);
			obj135.Name = "Assign";
			obj135.Parent = obj30;
			obj136.Name = "QuestionAssign";
			obj136.Parent = obj30;
			obj137.Name = "NegatedAssign";
			obj137.Parent = obj30;
			obj138.Name = "PlusAssign";
			obj138.Parent = obj30;
			((__IModelObject)obj139).Children.Add((__IModelObject)obj145);
			obj139.IsContainment = true;
			obj139.Type = __MetaType.FromModelObject((__IModelObject)obj145);
			obj139.Name = "NameAnnotations";
			obj139.Parent = obj31;
			((__IModelObject)obj140).Children.Add((__IModelObject)obj146);
			obj140.SymbolProperty = "SymbolProperty";
			obj140.Type = __MetaType.FromModelObject((__IModelObject)obj146);
			obj140.Name = "SymbolProperty";
			obj140.Parent = obj31;
			obj141.SymbolProperty = "Assignment";
			obj141.Type = __MetaType.FromModelObject((__IModelObject)obj30);
			obj141.Name = "Assignment";
			obj141.Parent = obj31;
			((__IModelObject)obj142).Children.Add((__IModelObject)obj147);
			obj142.IsContainment = true;
			obj142.Type = __MetaType.FromModelObject((__IModelObject)obj147);
			obj142.Name = "ValueAnnotations";
			obj142.Parent = obj31;
			obj143.IsContainment = true;
			obj143.SymbolProperty = "Value";
			obj143.Type = __MetaType.FromModelObject((__IModelObject)obj32);
			obj143.Name = "Value";
			obj143.Parent = obj31;
			obj144.Type = __MetaType.FromModelObject((__IModelObject)obj13);
			obj144.Name = "Multiplicity";
			obj144.Parent = obj31;
			obj145.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj146.ItemType = typeof(__MetaSymbol);
			obj147.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj148.SymbolProperty = "Rule";
			obj148.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj148.Name = "Rule";
			obj148.Parent = obj33;
			((__IModelObject)obj149).Children.Add((__IModelObject)obj150);
			obj149.SymbolProperty = "ReferencedTypes";
			obj149.Type = __MetaType.FromModelObject((__IModelObject)obj150);
			obj149.Name = "ReferencedTypes";
			obj149.Parent = obj33;
			obj150.ItemType = typeof(__MetaType);
			obj151.Type = typeof(string);
			obj151.Name = "Text";
			obj151.Parent = obj35;
			obj152.SymbolProperty = "ReturnType";
			obj152.Type = typeof(__MetaType);
			obj152.Name = "ReturnType";
			obj152.Parent = obj36;
			((__IModelObject)obj153).Children.Add((__IModelObject)obj154);
			obj153.IsContainment = true;
			obj153.SymbolProperty = "Alternatives";
			obj153.Type = __MetaType.FromModelObject((__IModelObject)obj154);
			obj153.Name = "Alternatives";
			obj153.Parent = obj36;
			obj154.ItemType = __MetaType.FromModelObject((__IModelObject)obj29);
			obj155.SymbolProperty = "Value";
			obj155.Type = typeof(__MetaSymbol);
			obj155.Name = "Value";
			obj155.Parent = obj37;
			((__IModelObject)obj156).Children.Add((__IModelObject)obj157);
			obj156.Type = __MetaType.FromModelObject((__IModelObject)obj157);
			obj156.Name = "Items";
			obj156.Parent = obj38;
			obj157.ItemType = __MetaType.FromModelObject((__IModelObject)obj37);
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
		public static __ModelProperty Annotation_AttributeClass => _Annotation_AttributeClass;
		public static __ModelProperty Annotation_Arguments => _Annotation_Arguments;
		public static __ModelClassInfo AnnotationArgumentInfo => __Impl.AnnotationArgument_Impl.__Info.Instance;
		public static __ModelProperty AnnotationArgument_NamedParameter => _AnnotationArgument_NamedParameter;
		public static __ModelProperty AnnotationArgument_Parameter => _AnnotationArgument_Parameter;
		public static __ModelProperty AnnotationArgument_ParameterType => _AnnotationArgument_ParameterType;
		public static __ModelProperty AnnotationArgument_Value => _AnnotationArgument_Value;
		public static __ModelClassInfo ArrayExpressionInfo => __Impl.ArrayExpression_Impl.__Info.Instance;
		public static __ModelProperty ArrayExpression_Items => _ArrayExpression_Items;
		public static __ModelClassInfo DeclarationInfo => __Impl.Declaration_Impl.__Info.Instance;
		public static __ModelProperty Declaration_Annotations => _Declaration_Annotations;
		public static __ModelProperty Declaration_Name => _Declaration_Name;
		public static __ModelProperty Declaration_FullName => _Declaration_FullName;
		public static __ModelProperty Declaration_Declarations => _Declaration_Declarations;
		public static __ModelClassInfo ExpressionInfo => __Impl.Expression_Impl.__Info.Instance;
		public static __ModelProperty Expression_Value => _Expression_Value;
		public static __ModelClassInfo GrammarInfo => __Impl.Grammar_Impl.__Info.Instance;
		public static __ModelProperty Grammar_Language => _Grammar_Language;
		public static __ModelProperty Grammar_Rules => _Grammar_Rules;
		public static __ModelClassInfo LAlternativeInfo => __Impl.LAlternative_Impl.__Info.Instance;
		public static __ModelProperty LAlternative_IsFixed => _LAlternative_IsFixed;
		public static __ModelProperty LAlternative_FixedText => _LAlternative_FixedText;
		public static __ModelProperty LAlternative_Elements => _LAlternative_Elements;
		public static __ModelClassInfo LanguageInfo => __Impl.Language_Impl.__Info.Instance;
		public static __ModelProperty Language_Grammar => _Language_Grammar;
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
		public static __ModelClassInfo LElementValueInfo => __Impl.LElementValue_Impl.__Info.Instance;
		public static __ModelProperty LElementValue_IsFixed => _LElementValue_IsFixed;
		public static __ModelProperty LElementValue_FixedText => _LElementValue_FixedText;
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
		public static __ModelClassInfo PAlternativeInfo => __Impl.PAlternative_Impl.__Info.Instance;
		public static __ModelProperty PAlternative_ReturnType => _PAlternative_ReturnType;
		public static __ModelProperty PAlternative_ReturnValue => _PAlternative_ReturnValue;
		public static __ModelProperty PAlternative_Elements => _PAlternative_Elements;
		public static __ModelClassInfo RuleInfo => __Impl.Rule_Impl.__Info.Instance;
		public static __ModelProperty Rule_Language => _Rule_Language;
		public static __ModelProperty Rule_Grammar => _Rule_Grammar;
		public static __ModelClassInfo ParserRuleInfo => __Impl.ParserRule_Impl.__Info.Instance;
		public static __ModelProperty ParserRule_ReturnType => _ParserRule_ReturnType;
		public static __ModelProperty ParserRule_Alternatives => _ParserRule_Alternatives;
		public static __ModelClassInfo PElementInfo => __Impl.PElement_Impl.__Info.Instance;
		public static __ModelProperty PElement_NameAnnotations => _PElement_NameAnnotations;
		public static __ModelProperty PElement_SymbolProperty => _PElement_SymbolProperty;
		public static __ModelProperty PElement_Assignment => _PElement_Assignment;
		public static __ModelProperty PElement_ValueAnnotations => _PElement_ValueAnnotations;
		public static __ModelProperty PElement_Value => _PElement_Value;
		public static __ModelProperty PElement_Multiplicity => _PElement_Multiplicity;
		public static __ModelClassInfo PElementValueInfo => __Impl.PElementValue_Impl.__Info.Instance;
		public static __ModelClassInfo PBlockInfo => __Impl.PBlock_Impl.__Info.Instance;
		public static __ModelProperty PBlock_ReturnType => _PBlock_ReturnType;
		public static __ModelProperty PBlock_Alternatives => _PBlock_Alternatives;
		public static __ModelClassInfo PEofInfo => __Impl.PEof_Impl.__Info.Instance;
		public static __ModelClassInfo PKeywordInfo => __Impl.PKeyword_Impl.__Info.Instance;
		public static __ModelProperty PKeyword_Text => _PKeyword_Text;
		public static __ModelClassInfo PReferenceInfo => __Impl.PReference_Impl.__Info.Instance;
		public static __ModelProperty PReference_Rule => _PReference_Rule;
		public static __ModelProperty PReference_ReferencedTypes => _PReference_ReferencedTypes;
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
	
		public Expression Expression(string? id = null)
		{
			return (Expression)Compiler.ExpressionInfo.Create(Model, id)!;
		}
	
		public Grammar Grammar(string? id = null)
		{
			return (Grammar)Compiler.GrammarInfo.Create(Model, id)!;
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
	
		public PAlternative PAlternative(string? id = null)
		{
			return (PAlternative)Compiler.PAlternativeInfo.Create(Model, id)!;
		}
	
		public PElement PElement(string? id = null)
		{
			return (PElement)Compiler.PElementInfo.Create(Model, id)!;
		}
	
		public PBlock PBlock(string? id = null)
		{
			return (PBlock)Compiler.PBlockInfo.Create(Model, id)!;
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
	
		public Expression Expression(__Model model, string? id = null)
		{
			return (Expression)Compiler.ExpressionInfo.Create(model, id)!;
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
	
		public PAlternative PAlternative(__Model model, string? id = null)
		{
			return (PAlternative)Compiler.PAlternativeInfo.Create(model, id)!;
		}
	
		public PElement PElement(__Model model, string? id = null)
		{
			return (PElement)Compiler.PElementInfo.Create(model, id)!;
		}
	
		public PBlock PBlock(__Model model, string? id = null)
		{
			return (PBlock)Compiler.PBlockInfo.Create(model, id)!;
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
		global::MetaDslx.Modeling.ICollectionSlot<AnnotationArgument> Arguments { get; }
		global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol AttributeClass { get; set; }
	
	}

	public interface AnnotationArgument : __IModelObjectCore
	{
		global::MetaDslx.Modeling.ICollectionSlot<__MetaSymbol> NamedParameter { get; }
		global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol Parameter { get; set; }
		__MetaType ParameterType { get; set; }
		Expression Value { get; set; }
	
	}

	public interface ArrayExpression : global::MetaDslx.Bootstrap.MetaCompiler.Model.Expression
	{
		global::MetaDslx.Modeling.ICollectionSlot<Expression> Items { get; }
	
	}

	public interface Declaration : __IModelObjectCore
	{
		global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations { get; }
		global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations { get; }
		string? FullName { get; }
		string? Name { get; set; }
	
	}

	public interface Expression : __IModelObjectCore
	{
		__MetaSymbol Value { get; set; }
	
	}

	public interface Grammar : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		Language Language { get; set; }
		global::MetaDslx.Modeling.ICollectionSlot<Rule> Rules { get; }
	
	}

	public interface LAlternative : __IModelObjectCore
	{
		global::MetaDslx.Modeling.ICollectionSlot<LElement> Elements { get; }
		string? FixedText { get; }
		bool IsFixed { get; }
	
	}

	public interface Language : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		Grammar Grammar { get; set; }
	
	}

	public interface LBlock : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
	{
		global::MetaDslx.Modeling.ICollectionSlot<LAlternative> Alternatives { get; }
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

	public interface LElementValue : __IModelObjectCore
	{
		string? FixedText { get; }
		bool IsFixed { get; }
	
	}

	public interface LexerRule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Rule
	{
		global::MetaDslx.Modeling.ICollectionSlot<LAlternative> Alternatives { get; }
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
		global::MetaDslx.Modeling.ICollectionSlot<LSetItem> Items { get; }
	
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

	public interface PAlternative : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		global::MetaDslx.Modeling.ICollectionSlot<PElement> Elements { get; }
		__MetaType ReturnType { get; set; }
		Expression ReturnValue { get; set; }
	
	}

	public interface Rule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
	{
		Grammar Grammar { get; set; }
		Language Language { get; }
	
	}

	public interface ParserRule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Rule
	{
		global::MetaDslx.Modeling.ICollectionSlot<PAlternative> Alternatives { get; }
		__MetaType ReturnType { get; set; }
	
	}

	public interface PElement : __IModelObjectCore
	{
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment { get; set; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
		global::MetaDslx.Modeling.ICollectionSlot<Annotation> NameAnnotations { get; }
		global::MetaDslx.Modeling.ICollectionSlot<__MetaSymbol> SymbolProperty { get; }
		PElementValue Value { get; set; }
		global::MetaDslx.Modeling.ICollectionSlot<Annotation> ValueAnnotations { get; }
	
	}

	public interface PElementValue : __IModelObjectCore
	{
	
	}

	public interface PBlock : global::MetaDslx.Bootstrap.MetaCompiler.Model.Rule, global::MetaDslx.Bootstrap.MetaCompiler.Model.PElementValue
	{
		global::MetaDslx.Modeling.ICollectionSlot<PAlternative> Alternatives { get; }
		__MetaType ReturnType { get; set; }
	
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
		global::MetaDslx.Modeling.ICollectionSlot<__MetaType> ReferencedTypes { get; }
		Rule Rule { get; set; }
	
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
		/// Constructor for the class LAlternative
		/// </summary>
		void LAlternative(LAlternative _this);
	
		/// <summary>
		/// Constructor for the class Language
		/// </summary>
		void Language(Language _this);
	
		/// <summary>
		/// Constructor for the class LBlock
		/// </summary>
		void LBlock(LBlock _this);
	
		/// <summary>
		/// Constructor for the class LElement
		/// </summary>
		void LElement(LElement _this);
	
		/// <summary>
		/// Constructor for the class LElementValue
		/// </summary>
		void LElementValue(LElementValue _this);
	
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
		/// Constructor for the class PAlternative
		/// </summary>
		void PAlternative(PAlternative _this);
	
		/// <summary>
		/// Constructor for the class Rule
		/// </summary>
		void Rule(Rule _this);
	
		/// <summary>
		/// Constructor for the class ParserRule
		/// </summary>
		void ParserRule(ParserRule _this);
	
		/// <summary>
		/// Constructor for the class PElement
		/// </summary>
		void PElement(PElement _this);
	
		/// <summary>
		/// Constructor for the class PElementValue
		/// </summary>
		void PElementValue(PElementValue _this);
	
		/// <summary>
		/// Constructor for the class PBlock
		/// </summary>
		void PBlock(PBlock _this);
	
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
		/// Computation of the derived property Declaration.FullName
		/// </summary>
		string? Declaration_FullName(Declaration _this);
	
		/// <summary>
		/// Computation of the derived property LAlternative.IsFixed
		/// </summary>
		bool LAlternative_IsFixed(LAlternative _this);
	
		/// <summary>
		/// Computation of the derived property LAlternative.FixedText
		/// </summary>
		string? LAlternative_FixedText(LAlternative _this);
	
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
		/// Computation of the derived property LElementValue.IsFixed
		/// </summary>
		bool LElementValue_IsFixed(LElementValue _this);
	
		/// <summary>
		/// Computation of the derived property LElementValue.FixedText
		/// </summary>
		string? LElementValue_FixedText(LElementValue _this);
	
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
		/// Computation of the derived property Rule.Language
		/// </summary>
		Language Rule_Language(Rule _this);
	
	
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
		/// Constructor for the class LElementValue
		/// </summary>
		public virtual void LElementValue(LElementValue _this)
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
		/// Constructor for the class PAlternative
		/// </summary>
		public virtual void PAlternative(PAlternative _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Rule
		/// </summary>
		public virtual void Rule(Rule _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ParserRule
		/// </summary>
		public virtual void ParserRule(ParserRule _this)
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
		/// Constructor for the class PBlock
		/// </summary>
		public virtual void PBlock(PBlock _this)
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
		/// Computation of the derived property Declaration.FullName
		/// </summary>
		public abstract string? Declaration_FullName(Declaration _this);
	
		/// <summary>
		/// Computation of the derived property LAlternative.IsFixed
		/// </summary>
		public abstract bool LAlternative_IsFixed(LAlternative _this);
	
		/// <summary>
		/// Computation of the derived property LAlternative.FixedText
		/// </summary>
		public abstract string? LAlternative_FixedText(LAlternative _this);
	
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
		/// Computation of the derived property LElementValue.IsFixed
		/// </summary>
		public abstract bool LElementValue_IsFixed(LElementValue _this);
	
		/// <summary>
		/// Computation of the derived property LElementValue.FixedText
		/// </summary>
		public abstract string? LElementValue_FixedText(LElementValue _this);
	
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
		/// Computation of the derived property Rule.Language
		/// </summary>
		public abstract Language Rule_Language(Rule _this);
	
	
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
			Compiler.__CustomImpl.Annotation(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<AnnotationArgument> Arguments
		{
			get => MGetCollection<AnnotationArgument>(Compiler.Annotation_Arguments);
		}
	
		public global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol AttributeClass
		{
			get => MGet<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>(Compiler.Annotation_AttributeClass);
			set => MSet<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>(Compiler.Annotation_AttributeClass, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments, Compiler.Annotation_AttributeClass);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments, Compiler.Annotation_AttributeClass);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments, Compiler.Annotation_AttributeClass);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Arguments", Compiler.Annotation_Arguments);
				publicPropertiesByName.Add("AttributeClass", Compiler.Annotation_AttributeClass);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Annotation_Arguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Annotation_Arguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Annotation_AttributeClass, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Annotation_AttributeClass, __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_AttributeClass), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				var result = new Annotation_Impl(id);
				if (model is not null) model.AttachObject(result);
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
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<__MetaSymbol> NamedParameter
		{
			get => MGetCollection<__MetaSymbol>(Compiler.AnnotationArgument_NamedParameter);
		}
	
		public global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol Parameter
		{
			get => MGet<global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol>(Compiler.AnnotationArgument_Parameter);
			set => MSet<global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol>(Compiler.AnnotationArgument_Parameter, value);
		}
	
		public __MetaType ParameterType
		{
			get => MGet<__MetaType>(Compiler.AnnotationArgument_ParameterType);
			set => MSet<__MetaType>(Compiler.AnnotationArgument_ParameterType, value);
		}
	
		public Expression Value
		{
			get => MGet<Expression>(Compiler.AnnotationArgument_Value);
			set => MSet<Expression>(Compiler.AnnotationArgument_Value, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_ParameterType, Compiler.AnnotationArgument_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_ParameterType, Compiler.AnnotationArgument_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_ParameterType, Compiler.AnnotationArgument_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("NamedParameter", Compiler.AnnotationArgument_NamedParameter);
				publicPropertiesByName.Add("Parameter", Compiler.AnnotationArgument_Parameter);
				publicPropertiesByName.Add("ParameterType", Compiler.AnnotationArgument_ParameterType);
				publicPropertiesByName.Add("Value", Compiler.AnnotationArgument_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.AnnotationArgument_NamedParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_NamedParameter, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.AnnotationArgument_Parameter, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_Parameter, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Parameter), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.AnnotationArgument_ParameterType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_ParameterType, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_ParameterType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.AnnotationArgument_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
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
			Compiler.__CustomImpl.Expression(this);
			Compiler.__CustomImpl.ArrayExpression(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<Expression> Items
		{
			get => MGetCollection<Expression>(Compiler.ArrayExpression_Items);
		}
	
		public __MetaSymbol Value
		{
			get => MGet<__MetaSymbol>(Compiler.Expression_Value);
			set => MSet<__MetaSymbol>(Compiler.Expression_Value, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items, Compiler.Expression_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items, Compiler.Expression_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Items", Compiler.ArrayExpression_Items);
				publicPropertiesByName.Add("Value", Compiler.Expression_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ArrayExpression_Items, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ArrayExpression_Items, __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Expression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Expression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ArrayExpressionInfo";
			}
		}
	}

	internal class Declaration_Impl : __MetaModelObject, Declaration
	{
		private Declaration_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Declaration(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
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
			set => MSet<string?>(Compiler.Declaration_Name, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
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
	
		public __MetaSymbol Value
		{
			get => MGet<__MetaSymbol>(Compiler.Expression_Value);
			set => MSet<__MetaSymbol>(Compiler.Expression_Value, value);
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
				modelPropertyInfos.Add(Compiler.Expression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Expression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
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
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Grammar(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public Language Language
		{
			get => MGet<Language>(Compiler.Grammar_Language);
			set => MSet<Language>(Compiler.Grammar_Language, value);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Rule> Rules
		{
			get => MGetCollection<Rule>(Compiler.Grammar_Rules);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
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
			set => MSet<string?>(Compiler.Declaration_Name, value);
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
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language, Compiler.Grammar_Rules, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language, Compiler.Grammar_Rules, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Language", Compiler.Grammar_Language);
				publicPropertiesByName.Add("Rules", Compiler.Grammar_Rules);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Grammar_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Grammar_Rules, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Rules, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Rules), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.GrammarInfo";
			}
		}
	}

	internal class LAlternative_Impl : __MetaModelObject, LAlternative
	{
		private LAlternative_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LAlternative(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<LElement> Elements
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
				modelPropertyInfos.Add(Compiler.LAlternative_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LAlternative_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LAlternative_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LAlternative_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
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
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Language(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public Grammar Grammar
		{
			get => MGet<Grammar>(Compiler.Language_Grammar);
			set => MSet<Grammar>(Compiler.Language_Grammar, value);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
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
			set => MSet<string?>(Compiler.Declaration_Name, value);
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
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Grammar", Compiler.Language_Grammar);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Language_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Language_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LanguageInfo";
			}
		}
	}

	internal class LBlock_Impl : __MetaModelObject, LBlock
	{
		private LBlock_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.LElementValue(this);
			Compiler.__CustomImpl.LBlock(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<LAlternative> Alternatives
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
				modelPropertyInfos.Add(Compiler.LBlock_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LBlock_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LBlock_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LBlock_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_IsFixed)));
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
				if (model is not null) model.AttachObject(result);
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
			set => MSet<bool>(Compiler.LElement_IsNegated, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LElement_Multiplicity);
			set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LElement_Multiplicity, value);
		}
	
		public LElementValue Value
		{
			get => MGet<LElementValue>(Compiler.LElement_Value);
			set => MSet<LElementValue>(Compiler.LElement_Value, value);
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
				modelPropertyInfos.Add(Compiler.LElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElement_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_IsNegated, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElement_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
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
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.LElementValueInfo";
			}
		}
	}

	internal class LexerRule_Impl : __MetaModelObject, LexerRule
	{
		private LexerRule_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Rule(this);
			Compiler.__CustomImpl.LexerRule(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<LAlternative> Alternatives
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
			set => MSet<bool>(Compiler.LexerRule_IsFragment, value);
		}
	
		public bool IsHidden
		{
			get => MGet<bool>(Compiler.LexerRule_IsHidden);
			set => MSet<bool>(Compiler.LexerRule_IsHidden, value);
		}
	
		public __MetaType ReturnType
		{
			get => MGet<__MetaType>(Compiler.LexerRule_ReturnType);
			set => MSet<__MetaType>(Compiler.LexerRule_ReturnType, value);
		}
	
		public Grammar Grammar
		{
			get => MGet<Grammar>(Compiler.Rule_Grammar);
			set => MSet<Grammar>(Compiler.Rule_Grammar, value);
		}
	
		public Language Language
		{
			get => Compiler.__CustomImpl.Rule_Language(this);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
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
			set => MSet<string?>(Compiler.Declaration_Name, value);
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
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.LexerRule_IsFragment, Compiler.LexerRule_IsHidden, Compiler.LexerRule_ReturnType, Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.LexerRule_IsFragment, Compiler.LexerRule_IsHidden, Compiler.LexerRule_ReturnType, Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
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
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.LexerRule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRule_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRule_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRule_IsFragment, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_IsFragment, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_IsFragment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRule_IsHidden, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_IsHidden, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_IsHidden), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LexerRule_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
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
			set => MSet<string>(Compiler.LFixed_Text, value);
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
				modelPropertyInfos.Add(Compiler.LFixed_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LFixed_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LFixed_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LFixed_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LFixed_Text, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LFixed_Text, __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_Text), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_IsFixed)));
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
				if (model is not null) model.AttachObject(result);
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
			set => MSet<string>(Compiler.LRange_EndChar, value);
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
			set => MSet<string>(Compiler.LRange_StartChar, value);
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
				modelPropertyInfos.Add(Compiler.LRange_EndChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_EndChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LRange_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LRange_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LRange_StartChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_StartChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_StartChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_IsFixed)));
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
				if (model is not null) model.AttachObject(result);
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
			set => MSet<LexerRule>(Compiler.LReference_Rule, value);
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
				modelPropertyInfos.Add(Compiler.LReference_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LReference_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LReference_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LReference_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LReference_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LReference_Rule, __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_IsFixed)));
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
				if (model is not null) model.AttachObject(result);
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
	
		public global::MetaDslx.Modeling.ICollectionSlot<LSetItem> Items
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
				modelPropertyInfos.Add(Compiler.LSet_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSet_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSet_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSet_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSet_Items, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSet_Items, __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_Items), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_IsFixed)));
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
				if (model is not null) model.AttachObject(result);
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
				modelPropertyInfos.Add(Compiler.LSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
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
			set => MSet<string>(Compiler.LSetChar_Char, value);
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
				modelPropertyInfos.Add(Compiler.LSetChar_Char, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetChar_Char, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_Char), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetChar_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetChar_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetChar_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetChar_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_FixedText)));
				modelPropertyInfos.Add(Compiler.LSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_IsFixed)));
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
				if (model is not null) model.AttachObject(result);
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
			set => MSet<string>(Compiler.LSetRange_EndChar, value);
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
			set => MSet<string>(Compiler.LSetRange_StartChar, value);
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
				modelPropertyInfos.Add(Compiler.LSetRange_EndChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_EndChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_EndChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetRange_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetRange_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetRange_StartChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_StartChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_StartChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_FixedText)));
				modelPropertyInfos.Add(Compiler.LSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_IsFixed)));
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
				if (model is not null) model.AttachObject(result);
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
				modelPropertyInfos.Add(Compiler.LWildCard_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LWildCard_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LWildCard_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LWildCard_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText)));
				modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_IsFixed)));
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
				if (model is not null) model.AttachObject(result);
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
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Namespace(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
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
			set => MSet<string?>(Compiler.Declaration_Name, value);
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
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.NamespaceInfo";
			}
		}
	}

	internal class PAlternative_Impl : __MetaModelObject, PAlternative
	{
		private PAlternative_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.PAlternative(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<PElement> Elements
		{
			get => MGetCollection<PElement>(Compiler.PAlternative_Elements);
		}
	
		public __MetaType ReturnType
		{
			get => MGet<__MetaType>(Compiler.PAlternative_ReturnType);
			set => MSet<__MetaType>(Compiler.PAlternative_ReturnType, value);
		}
	
		public Expression ReturnValue
		{
			get => MGet<Expression>(Compiler.PAlternative_ReturnValue);
			set => MSet<Expression>(Compiler.PAlternative_ReturnValue, value);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
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
			set => MSet<string?>(Compiler.Declaration_Name, value);
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
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PAlternative_Elements, Compiler.PAlternative_ReturnType, Compiler.PAlternative_ReturnValue, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PAlternative_Elements, Compiler.PAlternative_ReturnType, Compiler.PAlternative_ReturnValue, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Elements", Compiler.PAlternative_Elements);
				publicPropertiesByName.Add("ReturnType", Compiler.PAlternative_ReturnType);
				publicPropertiesByName.Add("ReturnValue", Compiler.PAlternative_ReturnValue);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.PAlternative_Elements, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PAlternative_Elements, __ImmutableArray.Create<__ModelProperty>(Compiler.PAlternative_Elements), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PAlternative_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PAlternative_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.PAlternative_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PAlternative_ReturnValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PAlternative_ReturnValue, __ImmutableArray.Create<__ModelProperty>(Compiler.PAlternative_ReturnValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.PAlternativeInfo";
			}
		}
	}

	internal class Rule_Impl : __MetaModelObject, Rule
	{
		private Rule_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Rule(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public Grammar Grammar
		{
			get => MGet<Grammar>(Compiler.Rule_Grammar);
			set => MSet<Grammar>(Compiler.Rule_Grammar, value);
		}
	
		public Language Language
		{
			get => Compiler.__CustomImpl.Rule_Language(this);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
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
			set => MSet<string?>(Compiler.Declaration_Name, value);
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
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Grammar", Compiler.Rule_Grammar);
				publicPropertiesByName.Add("Language", Compiler.Rule_Language);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.Rule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.RuleInfo";
			}
		}
	}

	internal class ParserRule_Impl : __MetaModelObject, ParserRule
	{
		private ParserRule_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.Rule(this);
			Compiler.__CustomImpl.ParserRule(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<PAlternative> Alternatives
		{
			get => MGetCollection<PAlternative>(Compiler.ParserRule_Alternatives);
		}
	
		public __MetaType ReturnType
		{
			get => MGet<__MetaType>(Compiler.ParserRule_ReturnType);
			set => MSet<__MetaType>(Compiler.ParserRule_ReturnType, value);
		}
	
		public Grammar Grammar
		{
			get => MGet<Grammar>(Compiler.Rule_Grammar);
			set => MSet<Grammar>(Compiler.Rule_Grammar, value);
		}
	
		public Language Language
		{
			get => Compiler.__CustomImpl.Rule_Language(this);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
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
			set => MSet<string?>(Compiler.Declaration_Name, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRule_Alternatives, Compiler.ParserRule_ReturnType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRule_Alternatives, Compiler.ParserRule_ReturnType, Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRule_Alternatives, Compiler.ParserRule_ReturnType, Compiler.Rule_Grammar, Compiler.Rule_Language, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Compiler.ParserRule_Alternatives);
				publicPropertiesByName.Add("ReturnType", Compiler.ParserRule_ReturnType);
				publicPropertiesByName.Add("Grammar", Compiler.Rule_Grammar);
				publicPropertiesByName.Add("Language", Compiler.Rule_Language);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.ParserRule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.ParserRule_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ParserRule_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.ParserRule_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.ParserRuleInfo";
			}
		}
	}

	internal class PElement_Impl : __MetaModelObject, PElement
	{
		private PElement_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.PElement(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment>(Compiler.PElement_Assignment);
			set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment>(Compiler.PElement_Assignment, value);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.PElement_Multiplicity);
			set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.PElement_Multiplicity, value);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Annotation> NameAnnotations
		{
			get => MGetCollection<Annotation>(Compiler.PElement_NameAnnotations);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<__MetaSymbol> SymbolProperty
		{
			get => MGetCollection<__MetaSymbol>(Compiler.PElement_SymbolProperty);
		}
	
		public PElementValue Value
		{
			get => MGet<PElementValue>(Compiler.PElement_Value);
			set => MSet<PElementValue>(Compiler.PElement_Value, value);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Annotation> ValueAnnotations
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
				modelPropertyInfos.Add(Compiler.PElement_Assignment, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_Assignment, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_NameAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_NameAnnotations, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_NameAnnotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_SymbolProperty, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_SymbolProperty, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_SymbolProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PElement_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PElement_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.PElement_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
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
				if (model is not null) model.AttachObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.PElementValueInfo";
			}
		}
	}

	internal class PBlock_Impl : __MetaModelObject, PBlock
	{
		private PBlock_Impl(string? id)
			: base(id)
		{
			Compiler.__CustomImpl.Rule(this);
			Compiler.__CustomImpl.PElementValue(this);
			Compiler.__CustomImpl.Declaration(this);
			Compiler.__CustomImpl.PBlock(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<PAlternative> Alternatives
		{
			get => MGetCollection<PAlternative>(Compiler.PBlock_Alternatives);
		}
	
		public __MetaType ReturnType
		{
			get => MGet<__MetaType>(Compiler.PBlock_ReturnType);
			set => MSet<__MetaType>(Compiler.PBlock_ReturnType, value);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Compiler.Declaration_Annotations);
		}
	
		public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
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
			set => MSet<string?>(Compiler.Declaration_Name, value);
		}
	
		public Grammar Grammar
		{
			get => MGet<Grammar>(Compiler.Rule_Grammar);
			set => MSet<Grammar>(Compiler.Rule_Grammar, value);
		}
	
		public Language Language
		{
			get => Compiler.__CustomImpl.Rule_Language(this);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.PElementValueInfo, Compiler.RuleInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo, Compiler.PElementValueInfo, Compiler.RuleInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PBlock_Alternatives, Compiler.PBlock_ReturnType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PBlock_Alternatives, Compiler.PBlock_ReturnType, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Rule_Grammar, Compiler.Rule_Language);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.PBlock_Alternatives, Compiler.PBlock_ReturnType, Compiler.Declaration_Annotations, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Rule_Grammar, Compiler.Rule_Language);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Compiler.PBlock_Alternatives);
				publicPropertiesByName.Add("ReturnType", Compiler.PBlock_ReturnType);
				publicPropertiesByName.Add("Annotations", Compiler.Declaration_Annotations);
				publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
				publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
				publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
				publicPropertiesByName.Add("Grammar", Compiler.Rule_Grammar);
				publicPropertiesByName.Add("Language", Compiler.Rule_Language);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Compiler.PBlock_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PBlock_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.PBlock_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.PBlock_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PBlock_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.PBlock_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Compiler.Rule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				var result = new PBlock_Impl(id);
				if (model is not null) model.AttachObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.PBlockInfo";
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
				if (model is not null) model.AttachObject(result);
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
			set => MSet<string>(Compiler.PKeyword_Text, value);
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
				modelPropertyInfos.Add(Compiler.PKeyword_Text, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PKeyword_Text, __ImmutableArray.Create<__ModelProperty>(Compiler.PKeyword_Text), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
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
			Compiler.__CustomImpl.PElementValue(this);
			Compiler.__CustomImpl.PReference(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Modeling.ICollectionSlot<__MetaType> ReferencedTypes
		{
			get => MGetCollection<__MetaType>(Compiler.PReference_ReferencedTypes);
		}
	
		public Rule Rule
		{
			get => MGet<Rule>(Compiler.PReference_Rule);
			set => MSet<Rule>(Compiler.PReference_Rule, value);
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
				modelPropertyInfos.Add(Compiler.PReference_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.PReference_Rule, __ImmutableArray.Create<__ModelProperty>(Compiler.PReference_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				if (model is not null) model.AttachObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Compiler.PReferenceInfo";
			}
		}
	}

}
