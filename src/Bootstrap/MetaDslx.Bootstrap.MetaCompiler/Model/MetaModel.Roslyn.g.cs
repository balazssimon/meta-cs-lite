#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Roslyn
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

	internal interface IRoslyn
	{
	}
	
	public sealed class Roslyn : __MetaModel, IRoslyn
	{
		// If there is an error at the following line, create a new class called 'CustomRoslynImplementation'
		// inheriting from the class 'CustomRoslynImplementationBase' and provide the custom implementation
		// for the derived properties and operations defined in the metamodel
		internal static readonly CustomRoslynImplementationBase __CustomImpl = new CustomRoslynImplementation();
	
		private static readonly Roslyn _instance;
		public static Roslyn MInstance => _instance;
	
		private static readonly __ModelProperty _Binder_TypeName;
		private static readonly __ModelProperty _Binder_Arguments;
		private static readonly __ModelProperty _Binder_IsNegated;
		private static readonly __ModelProperty _Binder_ConstructorArguments;
		private static readonly __ModelProperty _BinderArgument_Name;
		private static readonly __ModelProperty _BinderArgument_TypeName;
		private static readonly __ModelProperty _BinderArgument_IsArray;
		private static readonly __ModelProperty _BinderArgument_Values;
		private static readonly __ModelProperty _TokenKind_Name;
		private static readonly __ModelProperty _TokenKind_TypeName;
		private static readonly __ModelProperty _Language_Name;
		private static readonly __ModelProperty _Language_Namespace;
		private static readonly __ModelProperty _Language_TokenKinds;
		private static readonly __ModelProperty _Language_Tokens;
		private static readonly __ModelProperty _Language_Rules;
		private static readonly __ModelProperty _Language_DefaultWhitespace;
		private static readonly __ModelProperty _Language_DefaultEndOfLine;
		private static readonly __ModelProperty _Language_DefaultSeparator;
		private static readonly __ModelProperty _Language_DefaultIdentifier;
		private static readonly __ModelProperty _Language_MainRule;
		private static readonly __ModelProperty _Language_RootTypeName;
		private static readonly __ModelProperty _Token_Name;
		private static readonly __ModelProperty _Token_TokenKind;
		private static readonly __ModelProperty _Token_IsTrivia;
		private static readonly __ModelProperty _Token_IsFixed;
		private static readonly __ModelProperty _Token_FixedText;
		private static readonly __ModelProperty _Rule_Binders;
		private static readonly __ModelProperty _Rule_ContainsBinders;
		private static readonly __ModelProperty _Rule_Name;
		private static readonly __ModelProperty _Rule_Alternatives;
		private static readonly __ModelProperty _Rule_GreenName;
		private static readonly __ModelProperty _Rule_RedName;
		private static readonly __ModelProperty _Alternative_Binders;
		private static readonly __ModelProperty _Alternative_ContainsBinders;
		private static readonly __ModelProperty _Alternative_Name;
		private static readonly __ModelProperty _Alternative_Elements;
		private static readonly __ModelProperty _Alternative_GreenName;
		private static readonly __ModelProperty _Alternative_GreenConstructorParameters;
		private static readonly __ModelProperty _Alternative_GreenConstructorArguments;
		private static readonly __ModelProperty _Alternative_GreenUpdateParameters;
		private static readonly __ModelProperty _Alternative_GreenUpdateArguments;
		private static readonly __ModelProperty _Alternative_RedName;
		private static readonly __ModelProperty _Alternative_RedUpdateParameters;
		private static readonly __ModelProperty _Alternative_RedUpdateArguments;
		private static readonly __ModelProperty _Alternative_RedOptionalUpdateParameters;
		private static readonly __ModelProperty _Alternative_RedToGreenArgumentList;
		private static readonly __ModelProperty _Alternative_RedToGreenOptionalArgumentList;
		private static readonly __ModelProperty _Alternative_HasRedToGreenOptionalArguments;
		private static readonly __ModelProperty _Element_Binders;
		private static readonly __ModelProperty _Element_ContainsBinders;
		private static readonly __ModelProperty _Element_Name;
		private static readonly __ModelProperty _Element_Assignment;
		private static readonly __ModelProperty _Element_Value;
		private static readonly __ModelProperty _Element_Multiplicity;
		private static readonly __ModelProperty _Element_FieldName;
		private static readonly __ModelProperty _Element_ParameterName;
		private static readonly __ModelProperty _Element_PropertyName;
		private static readonly __ModelProperty _Element_GreenFieldType;
		private static readonly __ModelProperty _Element_GreenParameterValue;
		private static readonly __ModelProperty _Element_GreenPropertyType;
		private static readonly __ModelProperty _Element_GreenPropertyValue;
		private static readonly __ModelProperty _Element_GreenSyntaxNullCondition;
		private static readonly __ModelProperty _Element_GreenSyntaxCondition;
		private static readonly __ModelProperty _Element_IsOptionalUpdateParameter;
		private static readonly __ModelProperty _Element_RedFieldType;
		private static readonly __ModelProperty _Element_RedParameterValue;
		private static readonly __ModelProperty _Element_RedPropertyType;
		private static readonly __ModelProperty _Element_RedPropertyValue;
		private static readonly __ModelProperty _Element_RedToGreenArgument;
		private static readonly __ModelProperty _Element_RedToGreenOptionalArgument;
		private static readonly __ModelProperty _Element_RedSyntaxNullCondition;
		private static readonly __ModelProperty _Element_RedSyntaxCondition;
		private static readonly __ModelProperty _Element_VisitCall;
		private static readonly __ModelProperty _ElementValue_Binders;
		private static readonly __ModelProperty _ElementValue_ContainsBinders;
		private static readonly __ModelProperty _ElementValue_GreenType;
		private static readonly __ModelProperty _ElementValue_GreenSyntaxCondition;
		private static readonly __ModelProperty _ElementValue_RedType;
		private static readonly __ModelProperty _RuleRef_Rule;
		private static readonly __ModelProperty _RuleRef_GreenType;
		private static readonly __ModelProperty _RuleRef_GreenSyntaxCondition;
		private static readonly __ModelProperty _RuleRef_RedType;
		private static readonly __ModelProperty _TokenRef_Token;
		private static readonly __ModelProperty _TokenRef_GreenType;
		private static readonly __ModelProperty _TokenRef_GreenSyntaxCondition;
		private static readonly __ModelProperty _TokenRef_RedType;
		private static readonly __ModelProperty _TokenAlts_Tokens;
		private static readonly __ModelProperty _TokenAlts_GreenType;
		private static readonly __ModelProperty _TokenAlts_GreenSyntaxCondition;
		private static readonly __ModelProperty _TokenAlts_RedType;
		private static readonly __ModelProperty _Eof_GreenType;
		private static readonly __ModelProperty _Eof_GreenSyntaxCondition;
		private static readonly __ModelProperty _Eof_RedType;
		private static readonly __ModelProperty _SeparatedList_SeparatorFirst;
		private static readonly __ModelProperty _SeparatedList_RepeatedSeparatorFirst;
		private static readonly __ModelProperty _SeparatedList_FirstItems;
		private static readonly __ModelProperty _SeparatedList_FirstSeparators;
		private static readonly __ModelProperty _SeparatedList_RepeatedBlock;
		private static readonly __ModelProperty _SeparatedList_RepeatedItem;
		private static readonly __ModelProperty _SeparatedList_RepeatedSeparator;
		private static readonly __ModelProperty _SeparatedList_LastItems;
		private static readonly __ModelProperty _SeparatedList_LastSeparators;
		private static readonly __ModelProperty _SeparatedList_GreenType;
		private static readonly __ModelProperty _SeparatedList_GreenSyntaxCondition;
		private static readonly __ModelProperty _SeparatedList_RedType;
	
		static Roslyn()
		{
			_Alternative_Binders = new __ModelProperty(typeof(Alternative), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Alternative_ContainsBinders = new __ModelProperty(typeof(Alternative), "ContainsBinders", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Alternative_Elements = new __ModelProperty(typeof(Alternative), "Elements", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Alternative_GreenConstructorArguments = new __ModelProperty(typeof(Alternative), "GreenConstructorArguments", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_GreenConstructorParameters = new __ModelProperty(typeof(Alternative), "GreenConstructorParameters", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_GreenName = new __ModelProperty(typeof(Alternative), "GreenName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_GreenUpdateArguments = new __ModelProperty(typeof(Alternative), "GreenUpdateArguments", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_GreenUpdateParameters = new __ModelProperty(typeof(Alternative), "GreenUpdateParameters", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_HasRedToGreenOptionalArguments = new __ModelProperty(typeof(Alternative), "HasRedToGreenOptionalArguments", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_Name = new __ModelProperty(typeof(Alternative), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Alternative_RedName = new __ModelProperty(typeof(Alternative), "RedName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_RedOptionalUpdateParameters = new __ModelProperty(typeof(Alternative), "RedOptionalUpdateParameters", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_RedToGreenArgumentList = new __ModelProperty(typeof(Alternative), "RedToGreenArgumentList", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_RedToGreenOptionalArgumentList = new __ModelProperty(typeof(Alternative), "RedToGreenOptionalArgumentList", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_RedUpdateArguments = new __ModelProperty(typeof(Alternative), "RedUpdateArguments", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_RedUpdateParameters = new __ModelProperty(typeof(Alternative), "RedUpdateParameters", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Binder_Arguments = new __ModelProperty(typeof(Binder), "Arguments", typeof(BinderArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Binder_ConstructorArguments = new __ModelProperty(typeof(Binder), "ConstructorArguments", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Binder_IsNegated = new __ModelProperty(typeof(Binder), "IsNegated", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Binder_TypeName = new __ModelProperty(typeof(Binder), "TypeName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_BinderArgument_IsArray = new __ModelProperty(typeof(BinderArgument), "IsArray", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_BinderArgument_Name = new __ModelProperty(typeof(BinderArgument), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_BinderArgument_TypeName = new __ModelProperty(typeof(BinderArgument), "TypeName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_BinderArgument_Values = new __ModelProperty(typeof(BinderArgument), "Values", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, null);
			_Element_Assignment = new __ModelProperty(typeof(Element), "Assignment", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType, null);
			_Element_Binders = new __ModelProperty(typeof(Element), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Element_ContainsBinders = new __ModelProperty(typeof(Element), "ContainsBinders", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Element_FieldName = new __ModelProperty(typeof(Element), "FieldName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenFieldType = new __ModelProperty(typeof(Element), "GreenFieldType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenParameterValue = new __ModelProperty(typeof(Element), "GreenParameterValue", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenPropertyType = new __ModelProperty(typeof(Element), "GreenPropertyType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenPropertyValue = new __ModelProperty(typeof(Element), "GreenPropertyValue", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenSyntaxCondition = new __ModelProperty(typeof(Element), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenSyntaxNullCondition = new __ModelProperty(typeof(Element), "GreenSyntaxNullCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_IsOptionalUpdateParameter = new __ModelProperty(typeof(Element), "IsOptionalUpdateParameter", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_Multiplicity = new __ModelProperty(typeof(Element), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType, null);
			_Element_Name = new __ModelProperty(typeof(Element), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Element_ParameterName = new __ModelProperty(typeof(Element), "ParameterName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_PropertyName = new __ModelProperty(typeof(Element), "PropertyName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_RedFieldType = new __ModelProperty(typeof(Element), "RedFieldType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_RedParameterValue = new __ModelProperty(typeof(Element), "RedParameterValue", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_RedPropertyType = new __ModelProperty(typeof(Element), "RedPropertyType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_RedPropertyValue = new __ModelProperty(typeof(Element), "RedPropertyValue", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_RedSyntaxCondition = new __ModelProperty(typeof(Element), "RedSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_RedSyntaxNullCondition = new __ModelProperty(typeof(Element), "RedSyntaxNullCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_RedToGreenArgument = new __ModelProperty(typeof(Element), "RedToGreenArgument", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_RedToGreenOptionalArgument = new __ModelProperty(typeof(Element), "RedToGreenOptionalArgument", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_Value = new __ModelProperty(typeof(Element), "Value", typeof(ElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_Element_VisitCall = new __ModelProperty(typeof(Element), "VisitCall", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_ElementValue_Binders = new __ModelProperty(typeof(ElementValue), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_ElementValue_ContainsBinders = new __ModelProperty(typeof(ElementValue), "ContainsBinders", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_ElementValue_GreenSyntaxCondition = new __ModelProperty(typeof(ElementValue), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_ElementValue_GreenType = new __ModelProperty(typeof(ElementValue), "GreenType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_ElementValue_RedType = new __ModelProperty(typeof(ElementValue), "RedType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Eof_GreenSyntaxCondition = new __ModelProperty(typeof(Eof), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Eof_GreenType = new __ModelProperty(typeof(Eof), "GreenType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Eof_RedType = new __ModelProperty(typeof(Eof), "RedType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Language_DefaultEndOfLine = new __ModelProperty(typeof(Language), "DefaultEndOfLine", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Language_DefaultIdentifier = new __ModelProperty(typeof(Language), "DefaultIdentifier", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Language_DefaultSeparator = new __ModelProperty(typeof(Language), "DefaultSeparator", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Language_DefaultWhitespace = new __ModelProperty(typeof(Language), "DefaultWhitespace", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Language_MainRule = new __ModelProperty(typeof(Language), "MainRule", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Language_Name = new __ModelProperty(typeof(Language), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Language_Namespace = new __ModelProperty(typeof(Language), "Namespace", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Language_RootTypeName = new __ModelProperty(typeof(Language), "RootTypeName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Language_Rules = new __ModelProperty(typeof(Language), "Rules", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Language_TokenKinds = new __ModelProperty(typeof(Language), "TokenKinds", typeof(TokenKind), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Language_Tokens = new __ModelProperty(typeof(Language), "Tokens", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Rule_Alternatives = new __ModelProperty(typeof(Rule), "Alternatives", typeof(Alternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Rule_Binders = new __ModelProperty(typeof(Rule), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Rule_ContainsBinders = new __ModelProperty(typeof(Rule), "ContainsBinders", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Rule_GreenName = new __ModelProperty(typeof(Rule), "GreenName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Rule_Name = new __ModelProperty(typeof(Rule), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Rule_RedName = new __ModelProperty(typeof(Rule), "RedName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_RuleRef_GreenSyntaxCondition = new __ModelProperty(typeof(RuleRef), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_RuleRef_GreenType = new __ModelProperty(typeof(RuleRef), "GreenType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_RuleRef_RedType = new __ModelProperty(typeof(RuleRef), "RedType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_RuleRef_Rule = new __ModelProperty(typeof(RuleRef), "Rule", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_SeparatedList_FirstItems = new __ModelProperty(typeof(SeparatedList), "FirstItems", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_SeparatedList_FirstSeparators = new __ModelProperty(typeof(SeparatedList), "FirstSeparators", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_SeparatedList_GreenSyntaxCondition = new __ModelProperty(typeof(SeparatedList), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_SeparatedList_GreenType = new __ModelProperty(typeof(SeparatedList), "GreenType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_SeparatedList_LastItems = new __ModelProperty(typeof(SeparatedList), "LastItems", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_SeparatedList_LastSeparators = new __ModelProperty(typeof(SeparatedList), "LastSeparators", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_SeparatedList_RedType = new __ModelProperty(typeof(SeparatedList), "RedType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_SeparatedList_RepeatedBlock = new __ModelProperty(typeof(SeparatedList), "RepeatedBlock", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_SeparatedList_RepeatedItem = new __ModelProperty(typeof(SeparatedList), "RepeatedItem", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_SeparatedList_RepeatedSeparator = new __ModelProperty(typeof(SeparatedList), "RepeatedSeparator", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_SeparatedList_RepeatedSeparatorFirst = new __ModelProperty(typeof(SeparatedList), "RepeatedSeparatorFirst", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_SeparatedList_SeparatorFirst = new __ModelProperty(typeof(SeparatedList), "SeparatorFirst", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_FixedText = new __ModelProperty(typeof(Token), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_IsFixed = new __ModelProperty(typeof(Token), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_IsTrivia = new __ModelProperty(typeof(Token), "IsTrivia", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_Name = new __ModelProperty(typeof(Token), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_TokenKind = new __ModelProperty(typeof(Token), "TokenKind", typeof(TokenKind), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_TokenAlts_GreenSyntaxCondition = new __ModelProperty(typeof(TokenAlts), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_TokenAlts_GreenType = new __ModelProperty(typeof(TokenAlts), "GreenType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_TokenAlts_RedType = new __ModelProperty(typeof(TokenAlts), "RedType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_TokenAlts_Tokens = new __ModelProperty(typeof(TokenAlts), "Tokens", typeof(TokenRef), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_TokenKind_Name = new __ModelProperty(typeof(TokenKind), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_TokenKind_TypeName = new __ModelProperty(typeof(TokenKind), "TypeName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_TokenRef_GreenSyntaxCondition = new __ModelProperty(typeof(TokenRef), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_TokenRef_GreenType = new __ModelProperty(typeof(TokenRef), "GreenType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_TokenRef_RedType = new __ModelProperty(typeof(TokenRef), "RedType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_TokenRef_Token = new __ModelProperty(typeof(TokenRef), "Token", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_instance = new Roslyn();
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
	
	
		private Roslyn()
		{
			_enumTypes = __ImmutableArray.Create<__MetaType>();
			_enumInfos = __ImmutableArray.Create<__ModelEnumInfo>();
			var enumInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelEnumInfo>();
			_enumInfosByType = enumInfosByType.ToImmutable();
			var enumInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelEnumInfo>();
			_enumInfosByName = enumInfosByName.ToImmutable();
	
			_classTypes = __ImmutableArray.Create<__MetaType>(typeof(Alternative), typeof(Binder), typeof(BinderArgument), typeof(Element), typeof(ElementValue), typeof(Eof), typeof(Language), typeof(Rule), typeof(RuleRef), typeof(SeparatedList), typeof(Token), typeof(TokenAlts), typeof(TokenKind), typeof(TokenRef));
			_classInfos = __ImmutableArray.Create<__ModelClassInfo>(AlternativeInfo, BinderInfo, BinderArgumentInfo, ElementInfo, ElementValueInfo, EofInfo, LanguageInfo, RuleInfo, RuleRefInfo, SeparatedListInfo, TokenInfo, TokenAltsInfo, TokenKindInfo, TokenRefInfo);
			var classInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelClassInfo>();
			classInfosByType.Add(typeof(Alternative), AlternativeInfo);
			classInfosByType.Add(typeof(Binder), BinderInfo);
			classInfosByType.Add(typeof(BinderArgument), BinderArgumentInfo);
			classInfosByType.Add(typeof(Element), ElementInfo);
			classInfosByType.Add(typeof(ElementValue), ElementValueInfo);
			classInfosByType.Add(typeof(Eof), EofInfo);
			classInfosByType.Add(typeof(Language), LanguageInfo);
			classInfosByType.Add(typeof(Rule), RuleInfo);
			classInfosByType.Add(typeof(RuleRef), RuleRefInfo);
			classInfosByType.Add(typeof(SeparatedList), SeparatedListInfo);
			classInfosByType.Add(typeof(Token), TokenInfo);
			classInfosByType.Add(typeof(TokenAlts), TokenAltsInfo);
			classInfosByType.Add(typeof(TokenKind), TokenKindInfo);
			classInfosByType.Add(typeof(TokenRef), TokenRefInfo);
			_classInfosByType = classInfosByType.ToImmutable();
			var classInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelClassInfo>();
			classInfosByName.Add("Alternative", AlternativeInfo);
			classInfosByName.Add("Binder", BinderInfo);
			classInfosByName.Add("BinderArgument", BinderArgumentInfo);
			classInfosByName.Add("Element", ElementInfo);
			classInfosByName.Add("ElementValue", ElementValueInfo);
			classInfosByName.Add("Eof", EofInfo);
			classInfosByName.Add("Language", LanguageInfo);
			classInfosByName.Add("Rule", RuleInfo);
			classInfosByName.Add("RuleRef", RuleRefInfo);
			classInfosByName.Add("SeparatedList", SeparatedListInfo);
			classInfosByName.Add("Token", TokenInfo);
			classInfosByName.Add("TokenAlts", TokenAltsInfo);
			classInfosByName.Add("TokenKind", TokenKindInfo);
			classInfosByName.Add("TokenRef", TokenRefInfo);
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
			var obj13 = f.MetaClass();
			var obj14 = f.MetaClass();
			var obj15 = f.MetaClass();
			var obj16 = f.MetaClass();
			var obj17 = f.MetaClass();
			var obj18 = f.MetaClass();
			var obj19 = f.MetaClass();
			var obj20 = f.MetaClass();
			var obj21 = f.MetaProperty();
			var obj22 = f.MetaProperty();
			var obj23 = f.MetaProperty();
			var obj24 = f.MetaProperty();
			var obj25 = f.MetaArrayType();
			var obj26 = f.MetaProperty();
			var obj27 = f.MetaProperty();
			var obj28 = f.MetaProperty();
			var obj29 = f.MetaProperty();
			var obj30 = f.MetaArrayType();
			var obj31 = f.MetaProperty();
			var obj32 = f.MetaProperty();
			var obj33 = f.MetaProperty();
			var obj34 = f.MetaProperty();
			var obj35 = f.MetaProperty();
			var obj36 = f.MetaProperty();
			var obj37 = f.MetaProperty();
			var obj38 = f.MetaProperty();
			var obj39 = f.MetaProperty();
			var obj40 = f.MetaProperty();
			var obj41 = f.MetaProperty();
			var obj42 = f.MetaProperty();
			var obj43 = f.MetaProperty();
			var obj44 = f.MetaArrayType();
			var obj45 = f.MetaArrayType();
			var obj46 = f.MetaArrayType();
			var obj47 = f.MetaNullableType();
			var obj48 = f.MetaNullableType();
			var obj49 = f.MetaNullableType();
			var obj50 = f.MetaNullableType();
			var obj51 = f.MetaNullableType();
			var obj52 = f.MetaNullableType();
			var obj53 = f.MetaProperty();
			var obj54 = f.MetaProperty();
			var obj55 = f.MetaProperty();
			var obj56 = f.MetaProperty();
			var obj57 = f.MetaProperty();
			var obj58 = f.MetaNullableType();
			var obj59 = f.MetaProperty();
			var obj60 = f.MetaProperty();
			var obj61 = f.MetaProperty();
			var obj62 = f.MetaProperty();
			var obj63 = f.MetaProperty();
			var obj64 = f.MetaProperty();
			var obj65 = f.MetaArrayType();
			var obj66 = f.MetaArrayType();
			var obj67 = f.MetaProperty();
			var obj68 = f.MetaProperty();
			var obj69 = f.MetaProperty();
			var obj70 = f.MetaProperty();
			var obj71 = f.MetaProperty();
			var obj72 = f.MetaProperty();
			var obj73 = f.MetaProperty();
			var obj74 = f.MetaProperty();
			var obj75 = f.MetaProperty();
			var obj76 = f.MetaProperty();
			var obj77 = f.MetaProperty();
			var obj78 = f.MetaProperty();
			var obj79 = f.MetaProperty();
			var obj80 = f.MetaProperty();
			var obj81 = f.MetaProperty();
			var obj82 = f.MetaProperty();
			var obj83 = f.MetaArrayType();
			var obj84 = f.MetaArrayType();
			var obj85 = f.MetaProperty();
			var obj86 = f.MetaProperty();
			var obj87 = f.MetaProperty();
			var obj88 = f.MetaProperty();
			var obj89 = f.MetaProperty();
			var obj90 = f.MetaProperty();
			var obj91 = f.MetaProperty();
			var obj92 = f.MetaProperty();
			var obj93 = f.MetaProperty();
			var obj94 = f.MetaProperty();
			var obj95 = f.MetaProperty();
			var obj96 = f.MetaProperty();
			var obj97 = f.MetaProperty();
			var obj98 = f.MetaProperty();
			var obj99 = f.MetaProperty();
			var obj100 = f.MetaProperty();
			var obj101 = f.MetaProperty();
			var obj102 = f.MetaProperty();
			var obj103 = f.MetaProperty();
			var obj104 = f.MetaProperty();
			var obj105 = f.MetaProperty();
			var obj106 = f.MetaProperty();
			var obj107 = f.MetaProperty();
			var obj108 = f.MetaProperty();
			var obj109 = f.MetaProperty();
			var obj110 = f.MetaArrayType();
			var obj111 = f.MetaNullableType();
			var obj112 = f.MetaNullableType();
			var obj113 = f.MetaNullableType();
			var obj114 = f.MetaNullableType();
			var obj115 = f.MetaNullableType();
			var obj116 = f.MetaNullableType();
			var obj117 = f.MetaProperty();
			var obj118 = f.MetaProperty();
			var obj119 = f.MetaProperty();
			var obj120 = f.MetaProperty();
			var obj121 = f.MetaProperty();
			var obj122 = f.MetaArrayType();
			var obj123 = f.MetaNullableType();
			var obj124 = f.MetaProperty();
			var obj125 = f.MetaProperty();
			var obj126 = f.MetaProperty();
			var obj127 = f.MetaProperty();
			var obj128 = f.MetaNullableType();
			var obj129 = f.MetaProperty();
			var obj130 = f.MetaProperty();
			var obj131 = f.MetaProperty();
			var obj132 = f.MetaProperty();
			var obj133 = f.MetaNullableType();
			var obj134 = f.MetaProperty();
			var obj135 = f.MetaProperty();
			var obj136 = f.MetaProperty();
			var obj137 = f.MetaProperty();
			var obj138 = f.MetaArrayType();
			var obj139 = f.MetaNullableType();
			var obj140 = f.MetaProperty();
			var obj141 = f.MetaProperty();
			var obj142 = f.MetaProperty();
			var obj143 = f.MetaNullableType();
			var obj144 = f.MetaProperty();
			var obj145 = f.MetaProperty();
			var obj146 = f.MetaProperty();
			var obj147 = f.MetaProperty();
			var obj148 = f.MetaProperty();
			var obj149 = f.MetaProperty();
			var obj150 = f.MetaProperty();
			var obj151 = f.MetaProperty();
			var obj152 = f.MetaProperty();
			var obj153 = f.MetaProperty();
			var obj154 = f.MetaProperty();
			var obj155 = f.MetaProperty();
			var obj156 = f.MetaArrayType();
			var obj157 = f.MetaArrayType();
			var obj158 = f.MetaArrayType();
			var obj159 = f.MetaArrayType();
			var obj160 = f.MetaNullableType();
			__CustomImpl.Roslyn(this);
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
			obj5.Name = "Roslyn";
			obj5.Parent = obj4;
			obj6.Name = "Roslyn";
			obj6.Parent = obj5;
			((__IModelObject)obj7).Children.Add((__IModelObject)obj21);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj22);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj23);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj24);
			obj7.Properties.Add(obj21);
			obj7.Properties.Add(obj22);
			obj7.Properties.Add(obj23);
			obj7.Properties.Add(obj24);
			obj7.Declarations.Add(obj21);
			obj7.Declarations.Add(obj22);
			obj7.Declarations.Add(obj23);
			obj7.Declarations.Add(obj24);
			obj7.Name = "Binder";
			obj7.Parent = obj5;
			((__IModelObject)obj8).Children.Add((__IModelObject)obj26);
			((__IModelObject)obj8).Children.Add((__IModelObject)obj27);
			((__IModelObject)obj8).Children.Add((__IModelObject)obj28);
			((__IModelObject)obj8).Children.Add((__IModelObject)obj29);
			obj8.Properties.Add(obj26);
			obj8.Properties.Add(obj27);
			obj8.Properties.Add(obj28);
			obj8.Properties.Add(obj29);
			obj8.Declarations.Add(obj26);
			obj8.Declarations.Add(obj27);
			obj8.Declarations.Add(obj28);
			obj8.Declarations.Add(obj29);
			obj8.Name = "BinderArgument";
			obj8.Parent = obj5;
			((__IModelObject)obj9).Children.Add((__IModelObject)obj31);
			((__IModelObject)obj9).Children.Add((__IModelObject)obj32);
			obj9.Properties.Add(obj31);
			obj9.Properties.Add(obj32);
			obj9.Declarations.Add(obj31);
			obj9.Declarations.Add(obj32);
			obj9.Name = "TokenKind";
			obj9.Parent = obj5;
			((__IModelObject)obj10).Children.Add((__IModelObject)obj33);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj34);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj35);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj36);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj37);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj38);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj39);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj40);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj41);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj42);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj43);
			obj10.Properties.Add(obj33);
			obj10.Properties.Add(obj34);
			obj10.Properties.Add(obj35);
			obj10.Properties.Add(obj36);
			obj10.Properties.Add(obj37);
			obj10.Properties.Add(obj38);
			obj10.Properties.Add(obj39);
			obj10.Properties.Add(obj40);
			obj10.Properties.Add(obj41);
			obj10.Properties.Add(obj42);
			obj10.Properties.Add(obj43);
			obj10.Declarations.Add(obj33);
			obj10.Declarations.Add(obj34);
			obj10.Declarations.Add(obj35);
			obj10.Declarations.Add(obj36);
			obj10.Declarations.Add(obj37);
			obj10.Declarations.Add(obj38);
			obj10.Declarations.Add(obj39);
			obj10.Declarations.Add(obj40);
			obj10.Declarations.Add(obj41);
			obj10.Declarations.Add(obj42);
			obj10.Declarations.Add(obj43);
			obj10.Name = "Language";
			obj10.Parent = obj5;
			((__IModelObject)obj11).Children.Add((__IModelObject)obj53);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj54);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj55);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj56);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj57);
			obj11.Properties.Add(obj53);
			obj11.Properties.Add(obj54);
			obj11.Properties.Add(obj55);
			obj11.Properties.Add(obj56);
			obj11.Properties.Add(obj57);
			obj11.Declarations.Add(obj53);
			obj11.Declarations.Add(obj54);
			obj11.Declarations.Add(obj55);
			obj11.Declarations.Add(obj56);
			obj11.Declarations.Add(obj57);
			obj11.Name = "Token";
			obj11.Parent = obj5;
			((__IModelObject)obj12).Children.Add((__IModelObject)obj59);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj60);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj61);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj62);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj63);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj64);
			obj12.Properties.Add(obj59);
			obj12.Properties.Add(obj60);
			obj12.Properties.Add(obj61);
			obj12.Properties.Add(obj62);
			obj12.Properties.Add(obj63);
			obj12.Properties.Add(obj64);
			obj12.Declarations.Add(obj59);
			obj12.Declarations.Add(obj60);
			obj12.Declarations.Add(obj61);
			obj12.Declarations.Add(obj62);
			obj12.Declarations.Add(obj63);
			obj12.Declarations.Add(obj64);
			obj12.Name = "Rule";
			obj12.Parent = obj5;
			((__IModelObject)obj13).Children.Add((__IModelObject)obj67);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj68);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj69);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj70);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj71);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj72);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj73);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj74);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj75);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj76);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj77);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj78);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj79);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj80);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj81);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj82);
			obj13.Properties.Add(obj67);
			obj13.Properties.Add(obj68);
			obj13.Properties.Add(obj69);
			obj13.Properties.Add(obj70);
			obj13.Properties.Add(obj71);
			obj13.Properties.Add(obj72);
			obj13.Properties.Add(obj73);
			obj13.Properties.Add(obj74);
			obj13.Properties.Add(obj75);
			obj13.Properties.Add(obj76);
			obj13.Properties.Add(obj77);
			obj13.Properties.Add(obj78);
			obj13.Properties.Add(obj79);
			obj13.Properties.Add(obj80);
			obj13.Properties.Add(obj81);
			obj13.Properties.Add(obj82);
			obj13.Declarations.Add(obj67);
			obj13.Declarations.Add(obj68);
			obj13.Declarations.Add(obj69);
			obj13.Declarations.Add(obj70);
			obj13.Declarations.Add(obj71);
			obj13.Declarations.Add(obj72);
			obj13.Declarations.Add(obj73);
			obj13.Declarations.Add(obj74);
			obj13.Declarations.Add(obj75);
			obj13.Declarations.Add(obj76);
			obj13.Declarations.Add(obj77);
			obj13.Declarations.Add(obj78);
			obj13.Declarations.Add(obj79);
			obj13.Declarations.Add(obj80);
			obj13.Declarations.Add(obj81);
			obj13.Declarations.Add(obj82);
			obj13.Name = "Alternative";
			obj13.Parent = obj5;
			((__IModelObject)obj14).Children.Add((__IModelObject)obj85);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj86);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj87);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj88);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj89);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj90);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj91);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj92);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj93);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj94);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj95);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj96);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj97);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj98);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj99);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj100);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj101);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj102);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj103);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj104);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj105);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj106);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj107);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj108);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj109);
			obj14.Properties.Add(obj85);
			obj14.Properties.Add(obj86);
			obj14.Properties.Add(obj87);
			obj14.Properties.Add(obj88);
			obj14.Properties.Add(obj89);
			obj14.Properties.Add(obj90);
			obj14.Properties.Add(obj91);
			obj14.Properties.Add(obj92);
			obj14.Properties.Add(obj93);
			obj14.Properties.Add(obj94);
			obj14.Properties.Add(obj95);
			obj14.Properties.Add(obj96);
			obj14.Properties.Add(obj97);
			obj14.Properties.Add(obj98);
			obj14.Properties.Add(obj99);
			obj14.Properties.Add(obj100);
			obj14.Properties.Add(obj101);
			obj14.Properties.Add(obj102);
			obj14.Properties.Add(obj103);
			obj14.Properties.Add(obj104);
			obj14.Properties.Add(obj105);
			obj14.Properties.Add(obj106);
			obj14.Properties.Add(obj107);
			obj14.Properties.Add(obj108);
			obj14.Properties.Add(obj109);
			obj14.Declarations.Add(obj85);
			obj14.Declarations.Add(obj86);
			obj14.Declarations.Add(obj87);
			obj14.Declarations.Add(obj88);
			obj14.Declarations.Add(obj89);
			obj14.Declarations.Add(obj90);
			obj14.Declarations.Add(obj91);
			obj14.Declarations.Add(obj92);
			obj14.Declarations.Add(obj93);
			obj14.Declarations.Add(obj94);
			obj14.Declarations.Add(obj95);
			obj14.Declarations.Add(obj96);
			obj14.Declarations.Add(obj97);
			obj14.Declarations.Add(obj98);
			obj14.Declarations.Add(obj99);
			obj14.Declarations.Add(obj100);
			obj14.Declarations.Add(obj101);
			obj14.Declarations.Add(obj102);
			obj14.Declarations.Add(obj103);
			obj14.Declarations.Add(obj104);
			obj14.Declarations.Add(obj105);
			obj14.Declarations.Add(obj106);
			obj14.Declarations.Add(obj107);
			obj14.Declarations.Add(obj108);
			obj14.Declarations.Add(obj109);
			obj14.Name = "Element";
			obj14.Parent = obj5;
			((__IModelObject)obj15).Children.Add((__IModelObject)obj117);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj118);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj119);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj120);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj121);
			obj15.IsAbstract = true;
			obj15.Properties.Add(obj117);
			obj15.Properties.Add(obj118);
			obj15.Properties.Add(obj119);
			obj15.Properties.Add(obj120);
			obj15.Properties.Add(obj121);
			obj15.Declarations.Add(obj117);
			obj15.Declarations.Add(obj118);
			obj15.Declarations.Add(obj119);
			obj15.Declarations.Add(obj120);
			obj15.Declarations.Add(obj121);
			obj15.Name = "ElementValue";
			obj15.Parent = obj5;
			((__IModelObject)obj16).Children.Add((__IModelObject)obj124);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj125);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj126);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj127);
			obj16.BaseTypes.Add(obj15);
			obj16.Properties.Add(obj124);
			obj16.Properties.Add(obj125);
			obj16.Properties.Add(obj126);
			obj16.Properties.Add(obj127);
			obj16.Declarations.Add(obj124);
			obj16.Declarations.Add(obj125);
			obj16.Declarations.Add(obj126);
			obj16.Declarations.Add(obj127);
			obj16.Name = "RuleRef";
			obj16.Parent = obj5;
			((__IModelObject)obj17).Children.Add((__IModelObject)obj129);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj130);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj131);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj132);
			obj17.BaseTypes.Add(obj15);
			obj17.Properties.Add(obj129);
			obj17.Properties.Add(obj130);
			obj17.Properties.Add(obj131);
			obj17.Properties.Add(obj132);
			obj17.Declarations.Add(obj129);
			obj17.Declarations.Add(obj130);
			obj17.Declarations.Add(obj131);
			obj17.Declarations.Add(obj132);
			obj17.Name = "TokenRef";
			obj17.Parent = obj5;
			((__IModelObject)obj18).Children.Add((__IModelObject)obj134);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj135);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj136);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj137);
			obj18.BaseTypes.Add(obj15);
			obj18.Properties.Add(obj134);
			obj18.Properties.Add(obj135);
			obj18.Properties.Add(obj136);
			obj18.Properties.Add(obj137);
			obj18.Declarations.Add(obj134);
			obj18.Declarations.Add(obj135);
			obj18.Declarations.Add(obj136);
			obj18.Declarations.Add(obj137);
			obj18.Name = "TokenAlts";
			obj18.Parent = obj5;
			((__IModelObject)obj19).Children.Add((__IModelObject)obj140);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj141);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj142);
			obj19.BaseTypes.Add(obj15);
			obj19.Properties.Add(obj140);
			obj19.Properties.Add(obj141);
			obj19.Properties.Add(obj142);
			obj19.Declarations.Add(obj140);
			obj19.Declarations.Add(obj141);
			obj19.Declarations.Add(obj142);
			obj19.Name = "Eof";
			obj19.Parent = obj5;
			((__IModelObject)obj20).Children.Add((__IModelObject)obj144);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj145);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj146);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj147);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj148);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj149);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj150);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj151);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj152);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj153);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj154);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj155);
			obj20.BaseTypes.Add(obj15);
			obj20.Properties.Add(obj144);
			obj20.Properties.Add(obj145);
			obj20.Properties.Add(obj146);
			obj20.Properties.Add(obj147);
			obj20.Properties.Add(obj148);
			obj20.Properties.Add(obj149);
			obj20.Properties.Add(obj150);
			obj20.Properties.Add(obj151);
			obj20.Properties.Add(obj152);
			obj20.Properties.Add(obj153);
			obj20.Properties.Add(obj154);
			obj20.Properties.Add(obj155);
			obj20.Declarations.Add(obj144);
			obj20.Declarations.Add(obj145);
			obj20.Declarations.Add(obj146);
			obj20.Declarations.Add(obj147);
			obj20.Declarations.Add(obj148);
			obj20.Declarations.Add(obj149);
			obj20.Declarations.Add(obj150);
			obj20.Declarations.Add(obj151);
			obj20.Declarations.Add(obj152);
			obj20.Declarations.Add(obj153);
			obj20.Declarations.Add(obj154);
			obj20.Declarations.Add(obj155);
			obj20.Name = "SeparatedList";
			obj20.Parent = obj5;
			obj21.Type = typeof(string);
			obj21.Name = "TypeName";
			obj21.Parent = obj7;
			((__IModelObject)obj22).Children.Add((__IModelObject)obj25);
			obj22.IsContainment = true;
			obj22.Type = __MetaType.FromModelObject((__IModelObject)obj25);
			obj22.Name = "Arguments";
			obj22.Parent = obj7;
			obj23.Type = typeof(bool);
			obj23.Name = "IsNegated";
			obj23.Parent = obj7;
			obj24.IsDerived = true;
			obj24.Type = typeof(string);
			obj24.Name = "ConstructorArguments";
			obj24.Parent = obj7;
			obj25.ItemType = __MetaType.FromModelObject((__IModelObject)obj8);
			obj26.Type = typeof(string);
			obj26.Name = "Name";
			obj26.Parent = obj8;
			obj27.Type = typeof(string);
			obj27.Name = "TypeName";
			obj27.Parent = obj8;
			obj28.Type = typeof(bool);
			obj28.Name = "IsArray";
			obj28.Parent = obj8;
			((__IModelObject)obj29).Children.Add((__IModelObject)obj30);
			obj29.Type = __MetaType.FromModelObject((__IModelObject)obj30);
			obj29.Name = "Values";
			obj29.Parent = obj8;
			obj30.ItemType = typeof(string);
			obj31.Type = typeof(string);
			obj31.Name = "Name";
			obj31.Parent = obj9;
			obj32.Type = typeof(string);
			obj32.Name = "TypeName";
			obj32.Parent = obj9;
			obj33.Type = typeof(string);
			obj33.Name = "Name";
			obj33.Parent = obj10;
			obj34.Type = typeof(string);
			obj34.Name = "Namespace";
			obj34.Parent = obj10;
			((__IModelObject)obj35).Children.Add((__IModelObject)obj44);
			obj35.IsContainment = true;
			obj35.Type = __MetaType.FromModelObject((__IModelObject)obj44);
			obj35.Name = "TokenKinds";
			obj35.Parent = obj10;
			((__IModelObject)obj36).Children.Add((__IModelObject)obj45);
			obj36.IsContainment = true;
			obj36.Type = __MetaType.FromModelObject((__IModelObject)obj45);
			obj36.Name = "Tokens";
			obj36.Parent = obj10;
			((__IModelObject)obj37).Children.Add((__IModelObject)obj46);
			obj37.IsContainment = true;
			obj37.Type = __MetaType.FromModelObject((__IModelObject)obj46);
			obj37.Name = "Rules";
			obj37.Parent = obj10;
			((__IModelObject)obj38).Children.Add((__IModelObject)obj47);
			obj38.Type = __MetaType.FromModelObject((__IModelObject)obj47);
			obj38.Name = "DefaultWhitespace";
			obj38.Parent = obj10;
			((__IModelObject)obj39).Children.Add((__IModelObject)obj48);
			obj39.Type = __MetaType.FromModelObject((__IModelObject)obj48);
			obj39.Name = "DefaultEndOfLine";
			obj39.Parent = obj10;
			((__IModelObject)obj40).Children.Add((__IModelObject)obj49);
			obj40.Type = __MetaType.FromModelObject((__IModelObject)obj49);
			obj40.Name = "DefaultSeparator";
			obj40.Parent = obj10;
			((__IModelObject)obj41).Children.Add((__IModelObject)obj50);
			obj41.Type = __MetaType.FromModelObject((__IModelObject)obj50);
			obj41.Name = "DefaultIdentifier";
			obj41.Parent = obj10;
			((__IModelObject)obj42).Children.Add((__IModelObject)obj51);
			obj42.Type = __MetaType.FromModelObject((__IModelObject)obj51);
			obj42.Name = "MainRule";
			obj42.Parent = obj10;
			((__IModelObject)obj43).Children.Add((__IModelObject)obj52);
			obj43.Type = __MetaType.FromModelObject((__IModelObject)obj52);
			obj43.Name = "RootTypeName";
			obj43.Parent = obj10;
			obj44.ItemType = __MetaType.FromModelObject((__IModelObject)obj9);
			obj45.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj46.ItemType = __MetaType.FromModelObject((__IModelObject)obj12);
			obj47.InnerType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj48.InnerType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj49.InnerType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj50.InnerType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj51.InnerType = __MetaType.FromModelObject((__IModelObject)obj12);
			obj52.InnerType = typeof(string);
			obj53.Type = typeof(string);
			obj53.Name = "Name";
			obj53.Parent = obj11;
			obj54.Type = __MetaType.FromModelObject((__IModelObject)obj9);
			obj54.Name = "TokenKind";
			obj54.Parent = obj11;
			obj55.Type = typeof(bool);
			obj55.Name = "IsTrivia";
			obj55.Parent = obj11;
			obj56.Type = typeof(bool);
			obj56.Name = "IsFixed";
			obj56.Parent = obj11;
			((__IModelObject)obj57).Children.Add((__IModelObject)obj58);
			obj57.Type = __MetaType.FromModelObject((__IModelObject)obj58);
			obj57.Name = "FixedText";
			obj57.Parent = obj11;
			obj58.InnerType = typeof(string);
			((__IModelObject)obj59).Children.Add((__IModelObject)obj65);
			obj59.IsContainment = true;
			obj59.Type = __MetaType.FromModelObject((__IModelObject)obj65);
			obj59.Name = "Binders";
			obj59.Parent = obj12;
			obj60.Type = typeof(bool);
			obj60.Name = "ContainsBinders";
			obj60.Parent = obj12;
			obj61.Type = typeof(string);
			obj61.Name = "Name";
			obj61.Parent = obj12;
			((__IModelObject)obj62).Children.Add((__IModelObject)obj66);
			obj62.IsContainment = true;
			obj62.Type = __MetaType.FromModelObject((__IModelObject)obj66);
			obj62.Name = "Alternatives";
			obj62.Parent = obj12;
			obj63.IsDerived = true;
			obj63.Type = typeof(string);
			obj63.Name = "GreenName";
			obj63.Parent = obj12;
			obj64.IsDerived = true;
			obj64.Type = typeof(string);
			obj64.Name = "RedName";
			obj64.Parent = obj12;
			obj65.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj66.ItemType = __MetaType.FromModelObject((__IModelObject)obj13);
			((__IModelObject)obj67).Children.Add((__IModelObject)obj83);
			obj67.IsContainment = true;
			obj67.Type = __MetaType.FromModelObject((__IModelObject)obj83);
			obj67.Name = "Binders";
			obj67.Parent = obj13;
			obj68.Type = typeof(bool);
			obj68.Name = "ContainsBinders";
			obj68.Parent = obj13;
			obj69.Type = typeof(string);
			obj69.Name = "Name";
			obj69.Parent = obj13;
			((__IModelObject)obj70).Children.Add((__IModelObject)obj84);
			obj70.IsContainment = true;
			obj70.Type = __MetaType.FromModelObject((__IModelObject)obj84);
			obj70.Name = "Elements";
			obj70.Parent = obj13;
			obj71.IsDerived = true;
			obj71.Type = typeof(string);
			obj71.Name = "GreenName";
			obj71.Parent = obj13;
			obj72.IsDerived = true;
			obj72.Type = typeof(string);
			obj72.Name = "GreenConstructorParameters";
			obj72.Parent = obj13;
			obj73.IsDerived = true;
			obj73.Type = typeof(string);
			obj73.Name = "GreenConstructorArguments";
			obj73.Parent = obj13;
			obj74.IsDerived = true;
			obj74.Type = typeof(string);
			obj74.Name = "GreenUpdateParameters";
			obj74.Parent = obj13;
			obj75.IsDerived = true;
			obj75.Type = typeof(string);
			obj75.Name = "GreenUpdateArguments";
			obj75.Parent = obj13;
			obj76.IsDerived = true;
			obj76.Type = typeof(string);
			obj76.Name = "RedName";
			obj76.Parent = obj13;
			obj77.IsDerived = true;
			obj77.Type = typeof(string);
			obj77.Name = "RedUpdateParameters";
			obj77.Parent = obj13;
			obj78.IsDerived = true;
			obj78.Type = typeof(string);
			obj78.Name = "RedUpdateArguments";
			obj78.Parent = obj13;
			obj79.IsDerived = true;
			obj79.Type = typeof(string);
			obj79.Name = "RedOptionalUpdateParameters";
			obj79.Parent = obj13;
			obj80.IsDerived = true;
			obj80.Type = typeof(string);
			obj80.Name = "RedToGreenArgumentList";
			obj80.Parent = obj13;
			obj81.IsDerived = true;
			obj81.Type = typeof(string);
			obj81.Name = "RedToGreenOptionalArgumentList";
			obj81.Parent = obj13;
			obj82.IsDerived = true;
			obj82.Type = typeof(bool);
			obj82.Name = "HasRedToGreenOptionalArguments";
			obj82.Parent = obj13;
			obj83.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj84.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			((__IModelObject)obj85).Children.Add((__IModelObject)obj110);
			obj85.IsContainment = true;
			obj85.Type = __MetaType.FromModelObject((__IModelObject)obj110);
			obj85.Name = "Binders";
			obj85.Parent = obj14;
			obj86.Type = typeof(bool);
			obj86.Name = "ContainsBinders";
			obj86.Parent = obj14;
			((__IModelObject)obj87).Children.Add((__IModelObject)obj111);
			obj87.Type = __MetaType.FromModelObject((__IModelObject)obj111);
			obj87.Name = "Name";
			obj87.Parent = obj14;
			obj88.Type = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment);
			obj88.Name = "Assignment";
			obj88.Parent = obj14;
			obj89.IsContainment = true;
			obj89.Type = __MetaType.FromModelObject((__IModelObject)obj15);
			obj89.Name = "Value";
			obj89.Parent = obj14;
			obj90.Type = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity);
			obj90.Name = "Multiplicity";
			obj90.Parent = obj14;
			obj91.IsDerived = true;
			obj91.Type = typeof(string);
			obj91.Name = "FieldName";
			obj91.Parent = obj14;
			obj92.IsDerived = true;
			obj92.Type = typeof(string);
			obj92.Name = "ParameterName";
			obj92.Parent = obj14;
			obj93.IsDerived = true;
			obj93.Type = typeof(string);
			obj93.Name = "PropertyName";
			obj93.Parent = obj14;
			obj94.IsDerived = true;
			obj94.Type = typeof(string);
			obj94.Name = "GreenFieldType";
			obj94.Parent = obj14;
			obj95.IsDerived = true;
			obj95.Type = typeof(string);
			obj95.Name = "GreenParameterValue";
			obj95.Parent = obj14;
			obj96.IsDerived = true;
			obj96.Type = typeof(string);
			obj96.Name = "GreenPropertyType";
			obj96.Parent = obj14;
			obj97.IsDerived = true;
			obj97.Type = typeof(string);
			obj97.Name = "GreenPropertyValue";
			obj97.Parent = obj14;
			((__IModelObject)obj98).Children.Add((__IModelObject)obj112);
			obj98.IsDerived = true;
			obj98.Type = __MetaType.FromModelObject((__IModelObject)obj112);
			obj98.Name = "GreenSyntaxNullCondition";
			obj98.Parent = obj14;
			((__IModelObject)obj99).Children.Add((__IModelObject)obj113);
			obj99.IsDerived = true;
			obj99.Type = __MetaType.FromModelObject((__IModelObject)obj113);
			obj99.Name = "GreenSyntaxCondition";
			obj99.Parent = obj14;
			obj100.IsDerived = true;
			obj100.Type = typeof(bool);
			obj100.Name = "IsOptionalUpdateParameter";
			obj100.Parent = obj14;
			obj101.IsDerived = true;
			obj101.Type = typeof(string);
			obj101.Name = "RedFieldType";
			obj101.Parent = obj14;
			obj102.IsDerived = true;
			obj102.Type = typeof(string);
			obj102.Name = "RedParameterValue";
			obj102.Parent = obj14;
			obj103.IsDerived = true;
			obj103.Type = typeof(string);
			obj103.Name = "RedPropertyType";
			obj103.Parent = obj14;
			obj104.IsDerived = true;
			obj104.Type = typeof(string);
			obj104.Name = "RedPropertyValue";
			obj104.Parent = obj14;
			obj105.IsDerived = true;
			obj105.Type = typeof(string);
			obj105.Name = "RedToGreenArgument";
			obj105.Parent = obj14;
			obj106.IsDerived = true;
			obj106.Type = typeof(string);
			obj106.Name = "RedToGreenOptionalArgument";
			obj106.Parent = obj14;
			((__IModelObject)obj107).Children.Add((__IModelObject)obj114);
			obj107.IsDerived = true;
			obj107.Type = __MetaType.FromModelObject((__IModelObject)obj114);
			obj107.Name = "RedSyntaxNullCondition";
			obj107.Parent = obj14;
			((__IModelObject)obj108).Children.Add((__IModelObject)obj115);
			obj108.IsDerived = true;
			obj108.Type = __MetaType.FromModelObject((__IModelObject)obj115);
			obj108.Name = "RedSyntaxCondition";
			obj108.Parent = obj14;
			((__IModelObject)obj109).Children.Add((__IModelObject)obj116);
			obj109.IsDerived = true;
			obj109.Type = __MetaType.FromModelObject((__IModelObject)obj116);
			obj109.Name = "VisitCall";
			obj109.Parent = obj14;
			obj110.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj111.InnerType = typeof(string);
			obj112.InnerType = typeof(string);
			obj113.InnerType = typeof(string);
			obj114.InnerType = typeof(string);
			obj115.InnerType = typeof(string);
			obj116.InnerType = typeof(string);
			((__IModelObject)obj117).Children.Add((__IModelObject)obj122);
			obj117.IsContainment = true;
			obj117.Type = __MetaType.FromModelObject((__IModelObject)obj122);
			obj117.Name = "Binders";
			obj117.Parent = obj15;
			obj118.Type = typeof(bool);
			obj118.Name = "ContainsBinders";
			obj118.Parent = obj15;
			obj119.IsDerived = true;
			obj119.Type = typeof(string);
			obj119.Name = "GreenType";
			obj119.Parent = obj15;
			((__IModelObject)obj120).Children.Add((__IModelObject)obj123);
			obj120.IsDerived = true;
			obj120.Type = __MetaType.FromModelObject((__IModelObject)obj123);
			obj120.Name = "GreenSyntaxCondition";
			obj120.Parent = obj15;
			obj121.IsDerived = true;
			obj121.Type = typeof(string);
			obj121.Name = "RedType";
			obj121.Parent = obj15;
			obj122.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj123.InnerType = typeof(string);
			obj124.Type = __MetaType.FromModelObject((__IModelObject)obj12);
			obj124.Name = "Rule";
			obj124.Parent = obj16;
			obj125.IsDerived = true;
			obj125.Type = typeof(string);
			obj125.Name = "GreenType";
			obj125.Parent = obj16;
			((__IModelObject)obj126).Children.Add((__IModelObject)obj128);
			obj126.IsDerived = true;
			obj126.Type = __MetaType.FromModelObject((__IModelObject)obj128);
			obj126.Name = "GreenSyntaxCondition";
			obj126.Parent = obj16;
			obj127.IsDerived = true;
			obj127.Type = typeof(string);
			obj127.Name = "RedType";
			obj127.Parent = obj16;
			obj128.InnerType = typeof(string);
			obj129.Type = __MetaType.FromModelObject((__IModelObject)obj11);
			obj129.Name = "Token";
			obj129.Parent = obj17;
			obj130.IsDerived = true;
			obj130.Type = typeof(string);
			obj130.Name = "GreenType";
			obj130.Parent = obj17;
			((__IModelObject)obj131).Children.Add((__IModelObject)obj133);
			obj131.IsDerived = true;
			obj131.Type = __MetaType.FromModelObject((__IModelObject)obj133);
			obj131.Name = "GreenSyntaxCondition";
			obj131.Parent = obj17;
			obj132.IsDerived = true;
			obj132.Type = typeof(string);
			obj132.Name = "RedType";
			obj132.Parent = obj17;
			obj133.InnerType = typeof(string);
			((__IModelObject)obj134).Children.Add((__IModelObject)obj138);
			obj134.IsContainment = true;
			obj134.Type = __MetaType.FromModelObject((__IModelObject)obj138);
			obj134.Name = "Tokens";
			obj134.Parent = obj18;
			obj135.IsDerived = true;
			obj135.Type = typeof(string);
			obj135.Name = "GreenType";
			obj135.Parent = obj18;
			((__IModelObject)obj136).Children.Add((__IModelObject)obj139);
			obj136.IsDerived = true;
			obj136.Type = __MetaType.FromModelObject((__IModelObject)obj139);
			obj136.Name = "GreenSyntaxCondition";
			obj136.Parent = obj18;
			obj137.IsDerived = true;
			obj137.Type = typeof(string);
			obj137.Name = "RedType";
			obj137.Parent = obj18;
			obj138.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
			obj139.InnerType = typeof(string);
			obj140.IsDerived = true;
			obj140.Type = typeof(string);
			obj140.Name = "GreenType";
			obj140.Parent = obj19;
			((__IModelObject)obj141).Children.Add((__IModelObject)obj143);
			obj141.IsDerived = true;
			obj141.Type = __MetaType.FromModelObject((__IModelObject)obj143);
			obj141.Name = "GreenSyntaxCondition";
			obj141.Parent = obj19;
			obj142.IsDerived = true;
			obj142.Type = typeof(string);
			obj142.Name = "RedType";
			obj142.Parent = obj19;
			obj143.InnerType = typeof(string);
			obj144.Type = typeof(bool);
			obj144.Name = "SeparatorFirst";
			obj144.Parent = obj20;
			obj145.Type = typeof(bool);
			obj145.Name = "RepeatedSeparatorFirst";
			obj145.Parent = obj20;
			((__IModelObject)obj146).Children.Add((__IModelObject)obj156);
			obj146.IsContainment = true;
			obj146.Type = __MetaType.FromModelObject((__IModelObject)obj156);
			obj146.Name = "FirstItems";
			obj146.Parent = obj20;
			((__IModelObject)obj147).Children.Add((__IModelObject)obj157);
			obj147.IsContainment = true;
			obj147.Type = __MetaType.FromModelObject((__IModelObject)obj157);
			obj147.Name = "FirstSeparators";
			obj147.Parent = obj20;
			obj148.IsContainment = true;
			obj148.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj148.Name = "RepeatedBlock";
			obj148.Parent = obj20;
			obj149.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj149.Name = "RepeatedItem";
			obj149.Parent = obj20;
			obj150.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj150.Name = "RepeatedSeparator";
			obj150.Parent = obj20;
			((__IModelObject)obj151).Children.Add((__IModelObject)obj158);
			obj151.IsContainment = true;
			obj151.Type = __MetaType.FromModelObject((__IModelObject)obj158);
			obj151.Name = "LastItems";
			obj151.Parent = obj20;
			((__IModelObject)obj152).Children.Add((__IModelObject)obj159);
			obj152.IsContainment = true;
			obj152.Type = __MetaType.FromModelObject((__IModelObject)obj159);
			obj152.Name = "LastSeparators";
			obj152.Parent = obj20;
			obj153.IsDerived = true;
			obj153.Type = typeof(string);
			obj153.Name = "GreenType";
			obj153.Parent = obj20;
			((__IModelObject)obj154).Children.Add((__IModelObject)obj160);
			obj154.IsDerived = true;
			obj154.Type = __MetaType.FromModelObject((__IModelObject)obj160);
			obj154.Name = "GreenSyntaxCondition";
			obj154.Parent = obj20;
			obj155.IsDerived = true;
			obj155.Type = typeof(string);
			obj155.Name = "RedType";
			obj155.Parent = obj20;
			obj156.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj157.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj158.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj159.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj160.InnerType = typeof(string);
			_model.IsSealed = true;
		}
	
	    public override string MName => nameof(Roslyn);
	    public override string MNamespace => "MetaDslx.Bootstrap.MetaCompiler.Roslyn";
	    public override __ModelVersion MVersion => default;
	    public override string MUri => "MetaDslx.Bootstrap.MetaCompiler.Roslyn.Roslyn";
	    public override string MPrefix => "r";
		public override __Model MModel => _model;
	
		public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelEnumInfo> MEnumInfosByType => _enumInfosByType;
		public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelEnumInfo> MEnumInfosByName => _enumInfosByName;
		public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelClassInfo> MClassInfosByType => _classInfosByType;
		public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelClassInfo> MClassInfosByName => _classInfosByName;
	
	    public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MEnumTypes => _enumTypes;
	    public override global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo> MEnumInfos => _enumInfos;
	    public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MClassTypes => _classTypes;
	    public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> MClassInfos => _classInfos;
	
	
	
		public static __ModelClassInfo AlternativeInfo => __Impl.Alternative_Impl.__Info.Instance;
		public static __ModelProperty Alternative_Binders => _Alternative_Binders;
		public static __ModelProperty Alternative_ContainsBinders => _Alternative_ContainsBinders;
		public static __ModelProperty Alternative_Name => _Alternative_Name;
		public static __ModelProperty Alternative_Elements => _Alternative_Elements;
		public static __ModelProperty Alternative_GreenName => _Alternative_GreenName;
		public static __ModelProperty Alternative_GreenConstructorParameters => _Alternative_GreenConstructorParameters;
		public static __ModelProperty Alternative_GreenConstructorArguments => _Alternative_GreenConstructorArguments;
		public static __ModelProperty Alternative_GreenUpdateParameters => _Alternative_GreenUpdateParameters;
		public static __ModelProperty Alternative_GreenUpdateArguments => _Alternative_GreenUpdateArguments;
		public static __ModelProperty Alternative_RedName => _Alternative_RedName;
		public static __ModelProperty Alternative_RedUpdateParameters => _Alternative_RedUpdateParameters;
		public static __ModelProperty Alternative_RedUpdateArguments => _Alternative_RedUpdateArguments;
		public static __ModelProperty Alternative_RedOptionalUpdateParameters => _Alternative_RedOptionalUpdateParameters;
		public static __ModelProperty Alternative_RedToGreenArgumentList => _Alternative_RedToGreenArgumentList;
		public static __ModelProperty Alternative_RedToGreenOptionalArgumentList => _Alternative_RedToGreenOptionalArgumentList;
		public static __ModelProperty Alternative_HasRedToGreenOptionalArguments => _Alternative_HasRedToGreenOptionalArguments;
		public static __ModelClassInfo BinderInfo => __Impl.Binder_Impl.__Info.Instance;
		public static __ModelProperty Binder_TypeName => _Binder_TypeName;
		public static __ModelProperty Binder_Arguments => _Binder_Arguments;
		public static __ModelProperty Binder_IsNegated => _Binder_IsNegated;
		public static __ModelProperty Binder_ConstructorArguments => _Binder_ConstructorArguments;
		public static __ModelClassInfo BinderArgumentInfo => __Impl.BinderArgument_Impl.__Info.Instance;
		public static __ModelProperty BinderArgument_Name => _BinderArgument_Name;
		public static __ModelProperty BinderArgument_TypeName => _BinderArgument_TypeName;
		public static __ModelProperty BinderArgument_IsArray => _BinderArgument_IsArray;
		public static __ModelProperty BinderArgument_Values => _BinderArgument_Values;
		public static __ModelClassInfo ElementInfo => __Impl.Element_Impl.__Info.Instance;
		public static __ModelProperty Element_Binders => _Element_Binders;
		public static __ModelProperty Element_ContainsBinders => _Element_ContainsBinders;
		public static __ModelProperty Element_Name => _Element_Name;
		public static __ModelProperty Element_Assignment => _Element_Assignment;
		public static __ModelProperty Element_Value => _Element_Value;
		public static __ModelProperty Element_Multiplicity => _Element_Multiplicity;
		public static __ModelProperty Element_FieldName => _Element_FieldName;
		public static __ModelProperty Element_ParameterName => _Element_ParameterName;
		public static __ModelProperty Element_PropertyName => _Element_PropertyName;
		public static __ModelProperty Element_GreenFieldType => _Element_GreenFieldType;
		public static __ModelProperty Element_GreenParameterValue => _Element_GreenParameterValue;
		public static __ModelProperty Element_GreenPropertyType => _Element_GreenPropertyType;
		public static __ModelProperty Element_GreenPropertyValue => _Element_GreenPropertyValue;
		public static __ModelProperty Element_GreenSyntaxNullCondition => _Element_GreenSyntaxNullCondition;
		public static __ModelProperty Element_GreenSyntaxCondition => _Element_GreenSyntaxCondition;
		public static __ModelProperty Element_IsOptionalUpdateParameter => _Element_IsOptionalUpdateParameter;
		public static __ModelProperty Element_RedFieldType => _Element_RedFieldType;
		public static __ModelProperty Element_RedParameterValue => _Element_RedParameterValue;
		public static __ModelProperty Element_RedPropertyType => _Element_RedPropertyType;
		public static __ModelProperty Element_RedPropertyValue => _Element_RedPropertyValue;
		public static __ModelProperty Element_RedToGreenArgument => _Element_RedToGreenArgument;
		public static __ModelProperty Element_RedToGreenOptionalArgument => _Element_RedToGreenOptionalArgument;
		public static __ModelProperty Element_RedSyntaxNullCondition => _Element_RedSyntaxNullCondition;
		public static __ModelProperty Element_RedSyntaxCondition => _Element_RedSyntaxCondition;
		public static __ModelProperty Element_VisitCall => _Element_VisitCall;
		public static __ModelClassInfo ElementValueInfo => __Impl.ElementValue_Impl.__Info.Instance;
		public static __ModelProperty ElementValue_Binders => _ElementValue_Binders;
		public static __ModelProperty ElementValue_ContainsBinders => _ElementValue_ContainsBinders;
		public static __ModelProperty ElementValue_GreenType => _ElementValue_GreenType;
		public static __ModelProperty ElementValue_GreenSyntaxCondition => _ElementValue_GreenSyntaxCondition;
		public static __ModelProperty ElementValue_RedType => _ElementValue_RedType;
		public static __ModelClassInfo EofInfo => __Impl.Eof_Impl.__Info.Instance;
		public static __ModelProperty Eof_GreenType => _Eof_GreenType;
		public static __ModelProperty Eof_GreenSyntaxCondition => _Eof_GreenSyntaxCondition;
		public static __ModelProperty Eof_RedType => _Eof_RedType;
		public static __ModelClassInfo LanguageInfo => __Impl.Language_Impl.__Info.Instance;
		public static __ModelProperty Language_Name => _Language_Name;
		public static __ModelProperty Language_Namespace => _Language_Namespace;
		public static __ModelProperty Language_TokenKinds => _Language_TokenKinds;
		public static __ModelProperty Language_Tokens => _Language_Tokens;
		public static __ModelProperty Language_Rules => _Language_Rules;
		public static __ModelProperty Language_DefaultWhitespace => _Language_DefaultWhitespace;
		public static __ModelProperty Language_DefaultEndOfLine => _Language_DefaultEndOfLine;
		public static __ModelProperty Language_DefaultSeparator => _Language_DefaultSeparator;
		public static __ModelProperty Language_DefaultIdentifier => _Language_DefaultIdentifier;
		public static __ModelProperty Language_MainRule => _Language_MainRule;
		public static __ModelProperty Language_RootTypeName => _Language_RootTypeName;
		public static __ModelClassInfo RuleInfo => __Impl.Rule_Impl.__Info.Instance;
		public static __ModelProperty Rule_Binders => _Rule_Binders;
		public static __ModelProperty Rule_ContainsBinders => _Rule_ContainsBinders;
		public static __ModelProperty Rule_Name => _Rule_Name;
		public static __ModelProperty Rule_Alternatives => _Rule_Alternatives;
		public static __ModelProperty Rule_GreenName => _Rule_GreenName;
		public static __ModelProperty Rule_RedName => _Rule_RedName;
		public static __ModelClassInfo RuleRefInfo => __Impl.RuleRef_Impl.__Info.Instance;
		public static __ModelProperty RuleRef_Rule => _RuleRef_Rule;
		public static __ModelProperty RuleRef_GreenType => _RuleRef_GreenType;
		public static __ModelProperty RuleRef_GreenSyntaxCondition => _RuleRef_GreenSyntaxCondition;
		public static __ModelProperty RuleRef_RedType => _RuleRef_RedType;
		public static __ModelClassInfo SeparatedListInfo => __Impl.SeparatedList_Impl.__Info.Instance;
		public static __ModelProperty SeparatedList_SeparatorFirst => _SeparatedList_SeparatorFirst;
		public static __ModelProperty SeparatedList_RepeatedSeparatorFirst => _SeparatedList_RepeatedSeparatorFirst;
		public static __ModelProperty SeparatedList_FirstItems => _SeparatedList_FirstItems;
		public static __ModelProperty SeparatedList_FirstSeparators => _SeparatedList_FirstSeparators;
		public static __ModelProperty SeparatedList_RepeatedBlock => _SeparatedList_RepeatedBlock;
		public static __ModelProperty SeparatedList_RepeatedItem => _SeparatedList_RepeatedItem;
		public static __ModelProperty SeparatedList_RepeatedSeparator => _SeparatedList_RepeatedSeparator;
		public static __ModelProperty SeparatedList_LastItems => _SeparatedList_LastItems;
		public static __ModelProperty SeparatedList_LastSeparators => _SeparatedList_LastSeparators;
		public static __ModelProperty SeparatedList_GreenType => _SeparatedList_GreenType;
		public static __ModelProperty SeparatedList_GreenSyntaxCondition => _SeparatedList_GreenSyntaxCondition;
		public static __ModelProperty SeparatedList_RedType => _SeparatedList_RedType;
		public static __ModelClassInfo TokenInfo => __Impl.Token_Impl.__Info.Instance;
		public static __ModelProperty Token_Name => _Token_Name;
		public static __ModelProperty Token_TokenKind => _Token_TokenKind;
		public static __ModelProperty Token_IsTrivia => _Token_IsTrivia;
		public static __ModelProperty Token_IsFixed => _Token_IsFixed;
		public static __ModelProperty Token_FixedText => _Token_FixedText;
		public static __ModelClassInfo TokenAltsInfo => __Impl.TokenAlts_Impl.__Info.Instance;
		public static __ModelProperty TokenAlts_Tokens => _TokenAlts_Tokens;
		public static __ModelProperty TokenAlts_GreenType => _TokenAlts_GreenType;
		public static __ModelProperty TokenAlts_GreenSyntaxCondition => _TokenAlts_GreenSyntaxCondition;
		public static __ModelProperty TokenAlts_RedType => _TokenAlts_RedType;
		public static __ModelClassInfo TokenKindInfo => __Impl.TokenKind_Impl.__Info.Instance;
		public static __ModelProperty TokenKind_Name => _TokenKind_Name;
		public static __ModelProperty TokenKind_TypeName => _TokenKind_TypeName;
		public static __ModelClassInfo TokenRefInfo => __Impl.TokenRef_Impl.__Info.Instance;
		public static __ModelProperty TokenRef_Token => _TokenRef_Token;
		public static __ModelProperty TokenRef_GreenType => _TokenRef_GreenType;
		public static __ModelProperty TokenRef_GreenSyntaxCondition => _TokenRef_GreenSyntaxCondition;
		public static __ModelProperty TokenRef_RedType => _TokenRef_RedType;
	}
	
	public class RoslynModelFactory : __ModelFactory
	{
		public RoslynModelFactory(__Model model)
			: base(model, Roslyn.MInstance)
		{
		}
	
		public Alternative Alternative(string? id = null)
		{
			return (Alternative)Roslyn.AlternativeInfo.Create(Model, id)!;
		}
	
		public Binder Binder(string? id = null)
		{
			return (Binder)Roslyn.BinderInfo.Create(Model, id)!;
		}
	
		public BinderArgument BinderArgument(string? id = null)
		{
			return (BinderArgument)Roslyn.BinderArgumentInfo.Create(Model, id)!;
		}
	
		public Element Element(string? id = null)
		{
			return (Element)Roslyn.ElementInfo.Create(Model, id)!;
		}
	
		public Eof Eof(string? id = null)
		{
			return (Eof)Roslyn.EofInfo.Create(Model, id)!;
		}
	
		public Language Language(string? id = null)
		{
			return (Language)Roslyn.LanguageInfo.Create(Model, id)!;
		}
	
		public Rule Rule(string? id = null)
		{
			return (Rule)Roslyn.RuleInfo.Create(Model, id)!;
		}
	
		public RuleRef RuleRef(string? id = null)
		{
			return (RuleRef)Roslyn.RuleRefInfo.Create(Model, id)!;
		}
	
		public SeparatedList SeparatedList(string? id = null)
		{
			return (SeparatedList)Roslyn.SeparatedListInfo.Create(Model, id)!;
		}
	
		public Token Token(string? id = null)
		{
			return (Token)Roslyn.TokenInfo.Create(Model, id)!;
		}
	
		public TokenAlts TokenAlts(string? id = null)
		{
			return (TokenAlts)Roslyn.TokenAltsInfo.Create(Model, id)!;
		}
	
		public TokenKind TokenKind(string? id = null)
		{
			return (TokenKind)Roslyn.TokenKindInfo.Create(Model, id)!;
		}
	
		public TokenRef TokenRef(string? id = null)
		{
			return (TokenRef)Roslyn.TokenRefInfo.Create(Model, id)!;
		}
	
	}
	
	public class RoslynModelMultiFactory : __MultiModelFactory
	{
		public RoslynModelMultiFactory()
			: base(new __MetaModel[] { Roslyn.MInstance })
		{
		}
	
		public Alternative Alternative(__Model model, string? id = null)
		{
			return (Alternative)Roslyn.AlternativeInfo.Create(model, id)!;
		}
	
		public Binder Binder(__Model model, string? id = null)
		{
			return (Binder)Roslyn.BinderInfo.Create(model, id)!;
		}
	
		public BinderArgument BinderArgument(__Model model, string? id = null)
		{
			return (BinderArgument)Roslyn.BinderArgumentInfo.Create(model, id)!;
		}
	
		public Element Element(__Model model, string? id = null)
		{
			return (Element)Roslyn.ElementInfo.Create(model, id)!;
		}
	
		public Eof Eof(__Model model, string? id = null)
		{
			return (Eof)Roslyn.EofInfo.Create(model, id)!;
		}
	
		public Language Language(__Model model, string? id = null)
		{
			return (Language)Roslyn.LanguageInfo.Create(model, id)!;
		}
	
		public Rule Rule(__Model model, string? id = null)
		{
			return (Rule)Roslyn.RuleInfo.Create(model, id)!;
		}
	
		public RuleRef RuleRef(__Model model, string? id = null)
		{
			return (RuleRef)Roslyn.RuleRefInfo.Create(model, id)!;
		}
	
		public SeparatedList SeparatedList(__Model model, string? id = null)
		{
			return (SeparatedList)Roslyn.SeparatedListInfo.Create(model, id)!;
		}
	
		public Token Token(__Model model, string? id = null)
		{
			return (Token)Roslyn.TokenInfo.Create(model, id)!;
		}
	
		public TokenAlts TokenAlts(__Model model, string? id = null)
		{
			return (TokenAlts)Roslyn.TokenAltsInfo.Create(model, id)!;
		}
	
		public TokenKind TokenKind(__Model model, string? id = null)
		{
			return (TokenKind)Roslyn.TokenKindInfo.Create(model, id)!;
		}
	
		public TokenRef TokenRef(__Model model, string? id = null)
		{
			return (TokenRef)Roslyn.TokenRefInfo.Create(model, id)!;
		}
	
	}
	


	public interface Alternative : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Binder> Binders { get; }
		bool ContainsBinders { get; set; }
		global::System.Collections.Generic.IList<Element> Elements { get; }
		string GreenConstructorArguments { get; }
		string GreenConstructorParameters { get; }
		string GreenName { get; }
		string GreenUpdateArguments { get; }
		string GreenUpdateParameters { get; }
		bool HasRedToGreenOptionalArguments { get; }
		string Name { get; set; }
		string RedName { get; }
		string RedOptionalUpdateParameters { get; }
		string RedToGreenArgumentList { get; }
		string RedToGreenOptionalArgumentList { get; }
		string RedUpdateArguments { get; }
		string RedUpdateParameters { get; }
	
	}

	public interface Binder : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<BinderArgument> Arguments { get; }
		string ConstructorArguments { get; }
		bool IsNegated { get; set; }
		string TypeName { get; set; }
	
	}

	public interface BinderArgument : __IModelObjectCore
	{
		bool IsArray { get; set; }
		string Name { get; set; }
		string TypeName { get; set; }
		global::System.Collections.Generic.IList<string> Values { get; }
	
	}

	public interface Element : __IModelObjectCore
	{
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment { get; set; }
		global::System.Collections.Generic.IList<Binder> Binders { get; }
		bool ContainsBinders { get; set; }
		string FieldName { get; }
		string GreenFieldType { get; }
		string GreenParameterValue { get; }
		string GreenPropertyType { get; }
		string GreenPropertyValue { get; }
		string? GreenSyntaxCondition { get; }
		string? GreenSyntaxNullCondition { get; }
		bool IsOptionalUpdateParameter { get; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
		string? Name { get; set; }
		string ParameterName { get; }
		string PropertyName { get; }
		string RedFieldType { get; }
		string RedParameterValue { get; }
		string RedPropertyType { get; }
		string RedPropertyValue { get; }
		string? RedSyntaxCondition { get; }
		string? RedSyntaxNullCondition { get; }
		string RedToGreenArgument { get; }
		string RedToGreenOptionalArgument { get; }
		ElementValue Value { get; set; }
		string? VisitCall { get; }
	
	}

	public interface ElementValue : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Binder> Binders { get; }
		bool ContainsBinders { get; set; }
		string? GreenSyntaxCondition { get; }
		string GreenType { get; }
		string RedType { get; }
	
	}

	public interface Eof : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		new string? GreenSyntaxCondition { get; }
		new string GreenType { get; }
		new string RedType { get; }
	
	}

	public interface Language : __IModelObjectCore
	{
		Token? DefaultEndOfLine { get; set; }
		Token? DefaultIdentifier { get; set; }
		Token? DefaultSeparator { get; set; }
		Token? DefaultWhitespace { get; set; }
		Rule? MainRule { get; set; }
		string Name { get; set; }
		string Namespace { get; set; }
		string? RootTypeName { get; set; }
		global::System.Collections.Generic.IList<Rule> Rules { get; }
		global::System.Collections.Generic.IList<TokenKind> TokenKinds { get; }
		global::System.Collections.Generic.IList<Token> Tokens { get; }
	
	}

	public interface Rule : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Alternative> Alternatives { get; }
		global::System.Collections.Generic.IList<Binder> Binders { get; }
		bool ContainsBinders { get; set; }
		string GreenName { get; }
		string Name { get; set; }
		string RedName { get; }
	
	}

	public interface RuleRef : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		new string? GreenSyntaxCondition { get; }
		new string GreenType { get; }
		new string RedType { get; }
		Rule Rule { get; set; }
	
	}

	public interface SeparatedList : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		global::System.Collections.Generic.IList<Element> FirstItems { get; }
		global::System.Collections.Generic.IList<Element> FirstSeparators { get; }
		new string? GreenSyntaxCondition { get; }
		new string GreenType { get; }
		global::System.Collections.Generic.IList<Element> LastItems { get; }
		global::System.Collections.Generic.IList<Element> LastSeparators { get; }
		new string RedType { get; }
		Element RepeatedBlock { get; set; }
		Element RepeatedItem { get; set; }
		Element RepeatedSeparator { get; set; }
		bool RepeatedSeparatorFirst { get; set; }
		bool SeparatorFirst { get; set; }
	
	}

	public interface Token : __IModelObjectCore
	{
		string? FixedText { get; set; }
		bool IsFixed { get; set; }
		bool IsTrivia { get; set; }
		string Name { get; set; }
		TokenKind TokenKind { get; set; }
	
	}

	public interface TokenAlts : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		new string? GreenSyntaxCondition { get; }
		new string GreenType { get; }
		new string RedType { get; }
		global::System.Collections.Generic.IList<TokenRef> Tokens { get; }
	
	}

	public interface TokenKind : __IModelObjectCore
	{
		string Name { get; set; }
		string TypeName { get; set; }
	
	}

	public interface TokenRef : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		new string? GreenSyntaxCondition { get; }
		new string GreenType { get; }
		new string RedType { get; }
		Token Token { get; set; }
	
	}


	internal interface ICustomRoslynImplementation
	{
		/// <summary>
		/// Constructor for the meta model Roslyn
		/// </summary>
		void Roslyn(IRoslyn _this);
	
		/// <summary>
		/// Constructor for the class Alternative
		/// </summary>
		void Alternative(Alternative _this);
	
		/// <summary>
		/// Constructor for the class Binder
		/// </summary>
		void Binder(Binder _this);
	
		/// <summary>
		/// Constructor for the class BinderArgument
		/// </summary>
		void BinderArgument(BinderArgument _this);
	
		/// <summary>
		/// Constructor for the class Element
		/// </summary>
		void Element(Element _this);
	
		/// <summary>
		/// Constructor for the class ElementValue
		/// </summary>
		void ElementValue(ElementValue _this);
	
		/// <summary>
		/// Constructor for the class Eof
		/// </summary>
		void Eof(Eof _this);
	
		/// <summary>
		/// Constructor for the class Language
		/// </summary>
		void Language(Language _this);
	
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
		/// Constructor for the class TokenRef
		/// </summary>
		void TokenRef(TokenRef _this);
	
	
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
		/// Computation of the derived property Binder.ConstructorArguments
		/// </summary>
		string Binder_ConstructorArguments(Binder _this);
	
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
		/// Computation of the derived property Rule.GreenName
		/// </summary>
		string Rule_GreenName(Rule _this);
	
		/// <summary>
		/// Computation of the derived property Rule.RedName
		/// </summary>
		string Rule_RedName(Rule _this);
	
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
	
		/// <summary>
		/// Computation of the derived property TokenRef.GreenType
		/// </summary>
		string TokenRef_GreenType(TokenRef _this);
	
		/// <summary>
		/// Computation of the derived property TokenRef.GreenSyntaxCondition
		/// </summary>
		string? TokenRef_GreenSyntaxCondition(TokenRef _this);
	
		/// <summary>
		/// Computation of the derived property TokenRef.RedType
		/// </summary>
		string TokenRef_RedType(TokenRef _this);
	
	
	}
	
	internal abstract class CustomRoslynImplementationBase : ICustomRoslynImplementation
	{
		/// <summary>
		/// Constructor for the meta model Roslyn
		/// </summary>
		public virtual void Roslyn(IRoslyn _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Alternative
		/// </summary>
		public virtual void Alternative(Alternative _this)
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
		/// Constructor for the class Element
		/// </summary>
		public virtual void Element(Element _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class ElementValue
		/// </summary>
		public virtual void ElementValue(ElementValue _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Eof
		/// </summary>
		public virtual void Eof(Eof _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class Language
		/// </summary>
		public virtual void Language(Language _this)
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
		/// Constructor for the class TokenRef
		/// </summary>
		public virtual void TokenRef(TokenRef _this)
		{
		}
	
	
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
		/// Computation of the derived property Binder.ConstructorArguments
		/// </summary>
		public abstract string Binder_ConstructorArguments(Binder _this);
	
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
		/// Computation of the derived property Rule.GreenName
		/// </summary>
		public abstract string Rule_GreenName(Rule _this);
	
		/// <summary>
		/// Computation of the derived property Rule.RedName
		/// </summary>
		public abstract string Rule_RedName(Rule _this);
	
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
	
		/// <summary>
		/// Computation of the derived property TokenRef.GreenType
		/// </summary>
		public abstract string TokenRef_GreenType(TokenRef _this);
	
		/// <summary>
		/// Computation of the derived property TokenRef.GreenSyntaxCondition
		/// </summary>
		public abstract string? TokenRef_GreenSyntaxCondition(TokenRef _this);
	
		/// <summary>
		/// Computation of the derived property TokenRef.RedType
		/// </summary>
		public abstract string TokenRef_RedType(TokenRef _this);
	
	
	}
}

namespace MetaDslx.Bootstrap.MetaCompiler.Roslyn.__Impl
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


	internal class Alternative_Impl : __MetaModelObject, Alternative
	{
		private Alternative_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.Alternative_Binders, new global::MetaDslx.Modeling.ModelObjectList<Binder>(this, __Info.Instance.GetSlot(Roslyn.Alternative_Binders)!));
			((__IModelObject)this).Init(Roslyn.Alternative_Elements, new global::MetaDslx.Modeling.ModelObjectList<Element>(this, __Info.Instance.GetSlot(Roslyn.Alternative_Elements)!));
			Roslyn.__CustomImpl.Alternative(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.Alternative_Binders);
		}
	
		public bool ContainsBinders
		{
			get => MGet<bool>(Roslyn.Alternative_ContainsBinders);
			set => MAdd<bool>(Roslyn.Alternative_ContainsBinders, value);
		}
	
		public global::System.Collections.Generic.IList<Element> Elements
		{
			get => MGetCollection<Element>(Roslyn.Alternative_Elements);
		}
	
		public string GreenConstructorArguments
		{
			get => Roslyn.__CustomImpl.Alternative_GreenConstructorArguments(this);
		}
	
		public string GreenConstructorParameters
		{
			get => Roslyn.__CustomImpl.Alternative_GreenConstructorParameters(this);
		}
	
		public string GreenName
		{
			get => Roslyn.__CustomImpl.Alternative_GreenName(this);
		}
	
		public string GreenUpdateArguments
		{
			get => Roslyn.__CustomImpl.Alternative_GreenUpdateArguments(this);
		}
	
		public string GreenUpdateParameters
		{
			get => Roslyn.__CustomImpl.Alternative_GreenUpdateParameters(this);
		}
	
		public bool HasRedToGreenOptionalArguments
		{
			get => Roslyn.__CustomImpl.Alternative_HasRedToGreenOptionalArguments(this);
		}
	
		public string Name
		{
			get => MGet<string>(Roslyn.Alternative_Name);
			set => MAdd<string>(Roslyn.Alternative_Name, value);
		}
	
		public string RedName
		{
			get => Roslyn.__CustomImpl.Alternative_RedName(this);
		}
	
		public string RedOptionalUpdateParameters
		{
			get => Roslyn.__CustomImpl.Alternative_RedOptionalUpdateParameters(this);
		}
	
		public string RedToGreenArgumentList
		{
			get => Roslyn.__CustomImpl.Alternative_RedToGreenArgumentList(this);
		}
	
		public string RedToGreenOptionalArgumentList
		{
			get => Roslyn.__CustomImpl.Alternative_RedToGreenOptionalArgumentList(this);
		}
	
		public string RedUpdateArguments
		{
			get => Roslyn.__CustomImpl.Alternative_RedUpdateArguments(this);
		}
	
		public string RedUpdateParameters
		{
			get => Roslyn.__CustomImpl.Alternative_RedUpdateParameters(this);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders, Roslyn.Alternative_ContainsBinders, Roslyn.Alternative_Elements, Roslyn.Alternative_GreenConstructorArguments, Roslyn.Alternative_GreenConstructorParameters, Roslyn.Alternative_GreenName, Roslyn.Alternative_GreenUpdateArguments, Roslyn.Alternative_GreenUpdateParameters, Roslyn.Alternative_HasRedToGreenOptionalArguments, Roslyn.Alternative_Name, Roslyn.Alternative_RedName, Roslyn.Alternative_RedOptionalUpdateParameters, Roslyn.Alternative_RedToGreenArgumentList, Roslyn.Alternative_RedToGreenOptionalArgumentList, Roslyn.Alternative_RedUpdateArguments, Roslyn.Alternative_RedUpdateParameters);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders, Roslyn.Alternative_ContainsBinders, Roslyn.Alternative_Elements, Roslyn.Alternative_GreenConstructorArguments, Roslyn.Alternative_GreenConstructorParameters, Roslyn.Alternative_GreenName, Roslyn.Alternative_GreenUpdateArguments, Roslyn.Alternative_GreenUpdateParameters, Roslyn.Alternative_HasRedToGreenOptionalArguments, Roslyn.Alternative_Name, Roslyn.Alternative_RedName, Roslyn.Alternative_RedOptionalUpdateParameters, Roslyn.Alternative_RedToGreenArgumentList, Roslyn.Alternative_RedToGreenOptionalArgumentList, Roslyn.Alternative_RedUpdateArguments, Roslyn.Alternative_RedUpdateParameters);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders, Roslyn.Alternative_ContainsBinders, Roslyn.Alternative_Elements, Roslyn.Alternative_GreenConstructorArguments, Roslyn.Alternative_GreenConstructorParameters, Roslyn.Alternative_GreenName, Roslyn.Alternative_GreenUpdateArguments, Roslyn.Alternative_GreenUpdateParameters, Roslyn.Alternative_HasRedToGreenOptionalArguments, Roslyn.Alternative_Name, Roslyn.Alternative_RedName, Roslyn.Alternative_RedOptionalUpdateParameters, Roslyn.Alternative_RedToGreenArgumentList, Roslyn.Alternative_RedToGreenOptionalArgumentList, Roslyn.Alternative_RedUpdateArguments, Roslyn.Alternative_RedUpdateParameters);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Binders", Roslyn.Alternative_Binders);
				publicPropertiesByName.Add("ContainsBinders", Roslyn.Alternative_ContainsBinders);
				publicPropertiesByName.Add("Elements", Roslyn.Alternative_Elements);
				publicPropertiesByName.Add("GreenConstructorArguments", Roslyn.Alternative_GreenConstructorArguments);
				publicPropertiesByName.Add("GreenConstructorParameters", Roslyn.Alternative_GreenConstructorParameters);
				publicPropertiesByName.Add("GreenName", Roslyn.Alternative_GreenName);
				publicPropertiesByName.Add("GreenUpdateArguments", Roslyn.Alternative_GreenUpdateArguments);
				publicPropertiesByName.Add("GreenUpdateParameters", Roslyn.Alternative_GreenUpdateParameters);
				publicPropertiesByName.Add("HasRedToGreenOptionalArguments", Roslyn.Alternative_HasRedToGreenOptionalArguments);
				publicPropertiesByName.Add("Name", Roslyn.Alternative_Name);
				publicPropertiesByName.Add("RedName", Roslyn.Alternative_RedName);
				publicPropertiesByName.Add("RedOptionalUpdateParameters", Roslyn.Alternative_RedOptionalUpdateParameters);
				publicPropertiesByName.Add("RedToGreenArgumentList", Roslyn.Alternative_RedToGreenArgumentList);
				publicPropertiesByName.Add("RedToGreenOptionalArgumentList", Roslyn.Alternative_RedToGreenOptionalArgumentList);
				publicPropertiesByName.Add("RedUpdateArguments", Roslyn.Alternative_RedUpdateArguments);
				publicPropertiesByName.Add("RedUpdateParameters", Roslyn.Alternative_RedUpdateParameters);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Alternative_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_Elements, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_Elements, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Elements), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_GreenConstructorArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_GreenConstructorArguments, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_GreenConstructorArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_GreenConstructorParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_GreenConstructorParameters, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_GreenConstructorParameters), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_GreenName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_GreenName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_GreenName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_GreenUpdateArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_GreenUpdateArguments, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_GreenUpdateArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_GreenUpdateParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_GreenUpdateParameters, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_GreenUpdateParameters), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_HasRedToGreenOptionalArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_HasRedToGreenOptionalArguments, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_HasRedToGreenOptionalArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_RedName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_RedName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_RedName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_RedOptionalUpdateParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_RedOptionalUpdateParameters, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_RedOptionalUpdateParameters), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_RedToGreenArgumentList, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_RedToGreenArgumentList, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_RedToGreenArgumentList), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_RedToGreenOptionalArgumentList, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_RedToGreenOptionalArgumentList, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_RedToGreenOptionalArgumentList), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_RedUpdateArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_RedUpdateArguments, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_RedUpdateArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_RedUpdateParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_RedUpdateParameters, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_RedUpdateParameters), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(Alternative);
	
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
				var result = new Alternative_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.AlternativeInfo";
			}
		}
	}

	internal class Binder_Impl : __MetaModelObject, Binder
	{
		private Binder_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.Binder_Arguments, new global::MetaDslx.Modeling.ModelObjectList<BinderArgument>(this, __Info.Instance.GetSlot(Roslyn.Binder_Arguments)!));
			Roslyn.__CustomImpl.Binder(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<BinderArgument> Arguments
		{
			get => MGetCollection<BinderArgument>(Roslyn.Binder_Arguments);
		}
	
		public string ConstructorArguments
		{
			get => Roslyn.__CustomImpl.Binder_ConstructorArguments(this);
		}
	
		public bool IsNegated
		{
			get => MGet<bool>(Roslyn.Binder_IsNegated);
			set => MAdd<bool>(Roslyn.Binder_IsNegated, value);
		}
	
		public string TypeName
		{
			get => MGet<string>(Roslyn.Binder_TypeName);
			set => MAdd<string>(Roslyn.Binder_TypeName, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Binder_Arguments, Roslyn.Binder_ConstructorArguments, Roslyn.Binder_IsNegated, Roslyn.Binder_TypeName);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Binder_Arguments, Roslyn.Binder_ConstructorArguments, Roslyn.Binder_IsNegated, Roslyn.Binder_TypeName);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Binder_Arguments, Roslyn.Binder_ConstructorArguments, Roslyn.Binder_IsNegated, Roslyn.Binder_TypeName);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Arguments", Roslyn.Binder_Arguments);
				publicPropertiesByName.Add("ConstructorArguments", Roslyn.Binder_ConstructorArguments);
				publicPropertiesByName.Add("IsNegated", Roslyn.Binder_IsNegated);
				publicPropertiesByName.Add("TypeName", Roslyn.Binder_TypeName);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Binder_Arguments, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Binder_Arguments, __ImmutableArray.Create<__ModelProperty>(Roslyn.Binder_Arguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Binder_ConstructorArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Binder_ConstructorArguments, __ImmutableArray.Create<__ModelProperty>(Roslyn.Binder_ConstructorArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Binder_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Binder_IsNegated, __ImmutableArray.Create<__ModelProperty>(Roslyn.Binder_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Binder_TypeName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Binder_TypeName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Binder_TypeName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(Binder);
	
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
				var result = new Binder_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.BinderInfo";
			}
		}
	}

	internal class BinderArgument_Impl : __MetaModelObject, BinderArgument
	{
		private BinderArgument_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.BinderArgument_Values, new global::MetaDslx.Modeling.ModelObjectList<string>(this, __Info.Instance.GetSlot(Roslyn.BinderArgument_Values)!));
			Roslyn.__CustomImpl.BinderArgument(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public bool IsArray
		{
			get => MGet<bool>(Roslyn.BinderArgument_IsArray);
			set => MAdd<bool>(Roslyn.BinderArgument_IsArray, value);
		}
	
		public string Name
		{
			get => MGet<string>(Roslyn.BinderArgument_Name);
			set => MAdd<string>(Roslyn.BinderArgument_Name, value);
		}
	
		public string TypeName
		{
			get => MGet<string>(Roslyn.BinderArgument_TypeName);
			set => MAdd<string>(Roslyn.BinderArgument_TypeName, value);
		}
	
		public global::System.Collections.Generic.IList<string> Values
		{
			get => MGetCollection<string>(Roslyn.BinderArgument_Values);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_IsArray, Roslyn.BinderArgument_Name, Roslyn.BinderArgument_TypeName, Roslyn.BinderArgument_Values);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_IsArray, Roslyn.BinderArgument_Name, Roslyn.BinderArgument_TypeName, Roslyn.BinderArgument_Values);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_IsArray, Roslyn.BinderArgument_Name, Roslyn.BinderArgument_TypeName, Roslyn.BinderArgument_Values);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("IsArray", Roslyn.BinderArgument_IsArray);
				publicPropertiesByName.Add("Name", Roslyn.BinderArgument_Name);
				publicPropertiesByName.Add("TypeName", Roslyn.BinderArgument_TypeName);
				publicPropertiesByName.Add("Values", Roslyn.BinderArgument_Values);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.BinderArgument_IsArray, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.BinderArgument_IsArray, __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_IsArray), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.BinderArgument_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.BinderArgument_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.BinderArgument_TypeName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.BinderArgument_TypeName, __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_TypeName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.BinderArgument_Values, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.BinderArgument_Values, __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_Values), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(BinderArgument);
	
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
				var result = new BinderArgument_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.BinderArgumentInfo";
			}
		}
	}

	internal class Element_Impl : __MetaModelObject, Element
	{
		private Element_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.Element_Binders, new global::MetaDslx.Modeling.ModelObjectList<Binder>(this, __Info.Instance.GetSlot(Roslyn.Element_Binders)!));
			Roslyn.__CustomImpl.Element(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment>(Roslyn.Element_Assignment);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment>(Roslyn.Element_Assignment, value);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.Element_Binders);
		}
	
		public bool ContainsBinders
		{
			get => MGet<bool>(Roslyn.Element_ContainsBinders);
			set => MAdd<bool>(Roslyn.Element_ContainsBinders, value);
		}
	
		public string FieldName
		{
			get => Roslyn.__CustomImpl.Element_FieldName(this);
		}
	
		public string GreenFieldType
		{
			get => Roslyn.__CustomImpl.Element_GreenFieldType(this);
		}
	
		public string GreenParameterValue
		{
			get => Roslyn.__CustomImpl.Element_GreenParameterValue(this);
		}
	
		public string GreenPropertyType
		{
			get => Roslyn.__CustomImpl.Element_GreenPropertyType(this);
		}
	
		public string GreenPropertyValue
		{
			get => Roslyn.__CustomImpl.Element_GreenPropertyValue(this);
		}
	
		public string? GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.Element_GreenSyntaxCondition(this);
		}
	
		public string? GreenSyntaxNullCondition
		{
			get => Roslyn.__CustomImpl.Element_GreenSyntaxNullCondition(this);
		}
	
		public bool IsOptionalUpdateParameter
		{
			get => Roslyn.__CustomImpl.Element_IsOptionalUpdateParameter(this);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Roslyn.Element_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Roslyn.Element_Multiplicity, value);
		}
	
		public string? Name
		{
			get => MGet<string?>(Roslyn.Element_Name);
			set => MAdd<string?>(Roslyn.Element_Name, value);
		}
	
		public string ParameterName
		{
			get => Roslyn.__CustomImpl.Element_ParameterName(this);
		}
	
		public string PropertyName
		{
			get => Roslyn.__CustomImpl.Element_PropertyName(this);
		}
	
		public string RedFieldType
		{
			get => Roslyn.__CustomImpl.Element_RedFieldType(this);
		}
	
		public string RedParameterValue
		{
			get => Roslyn.__CustomImpl.Element_RedParameterValue(this);
		}
	
		public string RedPropertyType
		{
			get => Roslyn.__CustomImpl.Element_RedPropertyType(this);
		}
	
		public string RedPropertyValue
		{
			get => Roslyn.__CustomImpl.Element_RedPropertyValue(this);
		}
	
		public string? RedSyntaxCondition
		{
			get => Roslyn.__CustomImpl.Element_RedSyntaxCondition(this);
		}
	
		public string? RedSyntaxNullCondition
		{
			get => Roslyn.__CustomImpl.Element_RedSyntaxNullCondition(this);
		}
	
		public string RedToGreenArgument
		{
			get => Roslyn.__CustomImpl.Element_RedToGreenArgument(this);
		}
	
		public string RedToGreenOptionalArgument
		{
			get => Roslyn.__CustomImpl.Element_RedToGreenOptionalArgument(this);
		}
	
		public ElementValue Value
		{
			get => MGet<ElementValue>(Roslyn.Element_Value);
			set => MAdd<ElementValue>(Roslyn.Element_Value, value);
		}
	
		public string? VisitCall
		{
			get => Roslyn.__CustomImpl.Element_VisitCall(this);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment, Roslyn.Element_Binders, Roslyn.Element_ContainsBinders, Roslyn.Element_FieldName, Roslyn.Element_GreenFieldType, Roslyn.Element_GreenParameterValue, Roslyn.Element_GreenPropertyType, Roslyn.Element_GreenPropertyValue, Roslyn.Element_GreenSyntaxCondition, Roslyn.Element_GreenSyntaxNullCondition, Roslyn.Element_IsOptionalUpdateParameter, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_ParameterName, Roslyn.Element_PropertyName, Roslyn.Element_RedFieldType, Roslyn.Element_RedParameterValue, Roslyn.Element_RedPropertyType, Roslyn.Element_RedPropertyValue, Roslyn.Element_RedSyntaxCondition, Roslyn.Element_RedSyntaxNullCondition, Roslyn.Element_RedToGreenArgument, Roslyn.Element_RedToGreenOptionalArgument, Roslyn.Element_Value, Roslyn.Element_VisitCall);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment, Roslyn.Element_Binders, Roslyn.Element_ContainsBinders, Roslyn.Element_FieldName, Roslyn.Element_GreenFieldType, Roslyn.Element_GreenParameterValue, Roslyn.Element_GreenPropertyType, Roslyn.Element_GreenPropertyValue, Roslyn.Element_GreenSyntaxCondition, Roslyn.Element_GreenSyntaxNullCondition, Roslyn.Element_IsOptionalUpdateParameter, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_ParameterName, Roslyn.Element_PropertyName, Roslyn.Element_RedFieldType, Roslyn.Element_RedParameterValue, Roslyn.Element_RedPropertyType, Roslyn.Element_RedPropertyValue, Roslyn.Element_RedSyntaxCondition, Roslyn.Element_RedSyntaxNullCondition, Roslyn.Element_RedToGreenArgument, Roslyn.Element_RedToGreenOptionalArgument, Roslyn.Element_Value, Roslyn.Element_VisitCall);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment, Roslyn.Element_Binders, Roslyn.Element_ContainsBinders, Roslyn.Element_FieldName, Roslyn.Element_GreenFieldType, Roslyn.Element_GreenParameterValue, Roslyn.Element_GreenPropertyType, Roslyn.Element_GreenPropertyValue, Roslyn.Element_GreenSyntaxCondition, Roslyn.Element_GreenSyntaxNullCondition, Roslyn.Element_IsOptionalUpdateParameter, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_ParameterName, Roslyn.Element_PropertyName, Roslyn.Element_RedFieldType, Roslyn.Element_RedParameterValue, Roslyn.Element_RedPropertyType, Roslyn.Element_RedPropertyValue, Roslyn.Element_RedSyntaxCondition, Roslyn.Element_RedSyntaxNullCondition, Roslyn.Element_RedToGreenArgument, Roslyn.Element_RedToGreenOptionalArgument, Roslyn.Element_Value, Roslyn.Element_VisitCall);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Assignment", Roslyn.Element_Assignment);
				publicPropertiesByName.Add("Binders", Roslyn.Element_Binders);
				publicPropertiesByName.Add("ContainsBinders", Roslyn.Element_ContainsBinders);
				publicPropertiesByName.Add("FieldName", Roslyn.Element_FieldName);
				publicPropertiesByName.Add("GreenFieldType", Roslyn.Element_GreenFieldType);
				publicPropertiesByName.Add("GreenParameterValue", Roslyn.Element_GreenParameterValue);
				publicPropertiesByName.Add("GreenPropertyType", Roslyn.Element_GreenPropertyType);
				publicPropertiesByName.Add("GreenPropertyValue", Roslyn.Element_GreenPropertyValue);
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.Element_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenSyntaxNullCondition", Roslyn.Element_GreenSyntaxNullCondition);
				publicPropertiesByName.Add("IsOptionalUpdateParameter", Roslyn.Element_IsOptionalUpdateParameter);
				publicPropertiesByName.Add("Multiplicity", Roslyn.Element_Multiplicity);
				publicPropertiesByName.Add("Name", Roslyn.Element_Name);
				publicPropertiesByName.Add("ParameterName", Roslyn.Element_ParameterName);
				publicPropertiesByName.Add("PropertyName", Roslyn.Element_PropertyName);
				publicPropertiesByName.Add("RedFieldType", Roslyn.Element_RedFieldType);
				publicPropertiesByName.Add("RedParameterValue", Roslyn.Element_RedParameterValue);
				publicPropertiesByName.Add("RedPropertyType", Roslyn.Element_RedPropertyType);
				publicPropertiesByName.Add("RedPropertyValue", Roslyn.Element_RedPropertyValue);
				publicPropertiesByName.Add("RedSyntaxCondition", Roslyn.Element_RedSyntaxCondition);
				publicPropertiesByName.Add("RedSyntaxNullCondition", Roslyn.Element_RedSyntaxNullCondition);
				publicPropertiesByName.Add("RedToGreenArgument", Roslyn.Element_RedToGreenArgument);
				publicPropertiesByName.Add("RedToGreenOptionalArgument", Roslyn.Element_RedToGreenOptionalArgument);
				publicPropertiesByName.Add("Value", Roslyn.Element_Value);
				publicPropertiesByName.Add("VisitCall", Roslyn.Element_VisitCall);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Element_Assignment, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Assignment, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_FieldName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_FieldName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_FieldName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenFieldType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenFieldType, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenFieldType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenParameterValue, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenParameterValue, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenParameterValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenPropertyType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenPropertyType, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenPropertyType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenPropertyValue, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenPropertyValue, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenPropertyValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenSyntaxNullCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenSyntaxNullCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenSyntaxNullCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_IsOptionalUpdateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_IsOptionalUpdateParameter, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_IsOptionalUpdateParameter), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_ParameterName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_ParameterName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_ParameterName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_PropertyName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_PropertyName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_PropertyName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_RedFieldType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_RedFieldType, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_RedFieldType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_RedParameterValue, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_RedParameterValue, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_RedParameterValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_RedPropertyType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_RedPropertyType, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_RedPropertyType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_RedPropertyValue, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_RedPropertyValue, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_RedPropertyValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_RedSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_RedSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_RedSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_RedSyntaxNullCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_RedSyntaxNullCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_RedSyntaxNullCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_RedToGreenArgument, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_RedToGreenArgument, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_RedToGreenArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_RedToGreenOptionalArgument, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_RedToGreenOptionalArgument, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_RedToGreenOptionalArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Value, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_VisitCall, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_VisitCall, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_VisitCall), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(Element);
	
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
				var result = new Element_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.ElementInfo";
			}
		}
	}

	internal class ElementValue_Impl : __MetaModelObject, ElementValue
	{
		private ElementValue_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.ElementValue_Binders, new global::MetaDslx.Modeling.ModelObjectList<Binder>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Binders)!));
			Roslyn.__CustomImpl.ElementValue(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
		}
	
		public bool ContainsBinders
		{
			get => MGet<bool>(Roslyn.ElementValue_ContainsBinders);
			set => MAdd<bool>(Roslyn.ElementValue_ContainsBinders, value);
		}
	
		public string? GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.ElementValue_GreenSyntaxCondition(this);
		}
	
		public string GreenType
		{
			get => Roslyn.__CustomImpl.ElementValue_GreenType(this);
		}
	
		public string RedType
		{
			get => Roslyn.__CustomImpl.ElementValue_RedType(this);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType, Roslyn.ElementValue_RedType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType, Roslyn.ElementValue_RedType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType, Roslyn.ElementValue_RedType);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				publicPropertiesByName.Add("ContainsBinders", Roslyn.ElementValue_ContainsBinders);
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.ElementValue_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.ElementValue_GreenType);
				publicPropertiesByName.Add("RedType", Roslyn.ElementValue_RedType);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(ElementValue);
	
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
				var result = new ElementValue_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.ElementValueInfo";
			}
		}
	}

	internal class Eof_Impl : __MetaModelObject, Eof
	{
		private Eof_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.ElementValue_Binders, new global::MetaDslx.Modeling.ModelObjectList<Binder>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Binders)!));
			Roslyn.__CustomImpl.ElementValue(this);
			Roslyn.__CustomImpl.Eof(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.Eof_GreenSyntaxCondition(this);
		}
	
		public string GreenType
		{
			get => Roslyn.__CustomImpl.Eof_GreenType(this);
		}
	
		public string RedType
		{
			get => Roslyn.__CustomImpl.Eof_RedType(this);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
		}
	
		public bool ContainsBinders
		{
			get => MGet<bool>(Roslyn.ElementValue_ContainsBinders);
			set => MAdd<bool>(Roslyn.ElementValue_ContainsBinders, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? ElementValue.GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.Eof_GreenSyntaxCondition(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string ElementValue.GreenType
		{
			get => Roslyn.__CustomImpl.Eof_GreenType(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string ElementValue.RedType
		{
			get => Roslyn.__CustomImpl.Eof_RedType(this);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Roslyn.ElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Roslyn.ElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenSyntaxCondition, Roslyn.Eof_GreenType, Roslyn.Eof_RedType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenSyntaxCondition, Roslyn.Eof_GreenType, Roslyn.Eof_RedType, Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType, Roslyn.ElementValue_RedType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenSyntaxCondition, Roslyn.Eof_GreenType, Roslyn.Eof_RedType, Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.Eof_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.Eof_GreenType);
				publicPropertiesByName.Add("RedType", Roslyn.Eof_RedType);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				publicPropertiesByName.Add("ContainsBinders", Roslyn.ElementValue_ContainsBinders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Eof_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Eof_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Eof_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Eof_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Eof_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Eof_RedType, __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_RedType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenSyntaxCondition)));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenType)));
				modelPropertyInfos.Add(Roslyn.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_RedType)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(Eof);
	
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
				var result = new Eof_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.EofInfo";
			}
		}
	}

	internal class Language_Impl : __MetaModelObject, Language
	{
		private Language_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.Language_Rules, new global::MetaDslx.Modeling.ModelObjectList<Rule>(this, __Info.Instance.GetSlot(Roslyn.Language_Rules)!));
			((__IModelObject)this).Init(Roslyn.Language_TokenKinds, new global::MetaDslx.Modeling.ModelObjectList<TokenKind>(this, __Info.Instance.GetSlot(Roslyn.Language_TokenKinds)!));
			((__IModelObject)this).Init(Roslyn.Language_Tokens, new global::MetaDslx.Modeling.ModelObjectList<Token>(this, __Info.Instance.GetSlot(Roslyn.Language_Tokens)!));
			Roslyn.__CustomImpl.Language(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public Token? DefaultEndOfLine
		{
			get => MGet<Token?>(Roslyn.Language_DefaultEndOfLine);
			set => MAdd<Token?>(Roslyn.Language_DefaultEndOfLine, value);
		}
	
		public Token? DefaultIdentifier
		{
			get => MGet<Token?>(Roslyn.Language_DefaultIdentifier);
			set => MAdd<Token?>(Roslyn.Language_DefaultIdentifier, value);
		}
	
		public Token? DefaultSeparator
		{
			get => MGet<Token?>(Roslyn.Language_DefaultSeparator);
			set => MAdd<Token?>(Roslyn.Language_DefaultSeparator, value);
		}
	
		public Token? DefaultWhitespace
		{
			get => MGet<Token?>(Roslyn.Language_DefaultWhitespace);
			set => MAdd<Token?>(Roslyn.Language_DefaultWhitespace, value);
		}
	
		public Rule? MainRule
		{
			get => MGet<Rule?>(Roslyn.Language_MainRule);
			set => MAdd<Rule?>(Roslyn.Language_MainRule, value);
		}
	
		public string Name
		{
			get => MGet<string>(Roslyn.Language_Name);
			set => MAdd<string>(Roslyn.Language_Name, value);
		}
	
		public string Namespace
		{
			get => MGet<string>(Roslyn.Language_Namespace);
			set => MAdd<string>(Roslyn.Language_Namespace, value);
		}
	
		public string? RootTypeName
		{
			get => MGet<string?>(Roslyn.Language_RootTypeName);
			set => MAdd<string?>(Roslyn.Language_RootTypeName, value);
		}
	
		public global::System.Collections.Generic.IList<Rule> Rules
		{
			get => MGetCollection<Rule>(Roslyn.Language_Rules);
		}
	
		public global::System.Collections.Generic.IList<TokenKind> TokenKinds
		{
			get => MGetCollection<TokenKind>(Roslyn.Language_TokenKinds);
		}
	
		public global::System.Collections.Generic.IList<Token> Tokens
		{
			get => MGetCollection<Token>(Roslyn.Language_Tokens);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_DefaultEndOfLine, Roslyn.Language_DefaultIdentifier, Roslyn.Language_DefaultSeparator, Roslyn.Language_DefaultWhitespace, Roslyn.Language_MainRule, Roslyn.Language_Name, Roslyn.Language_Namespace, Roslyn.Language_RootTypeName, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_DefaultEndOfLine, Roslyn.Language_DefaultIdentifier, Roslyn.Language_DefaultSeparator, Roslyn.Language_DefaultWhitespace, Roslyn.Language_MainRule, Roslyn.Language_Name, Roslyn.Language_Namespace, Roslyn.Language_RootTypeName, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_DefaultEndOfLine, Roslyn.Language_DefaultIdentifier, Roslyn.Language_DefaultSeparator, Roslyn.Language_DefaultWhitespace, Roslyn.Language_MainRule, Roslyn.Language_Name, Roslyn.Language_Namespace, Roslyn.Language_RootTypeName, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("DefaultEndOfLine", Roslyn.Language_DefaultEndOfLine);
				publicPropertiesByName.Add("DefaultIdentifier", Roslyn.Language_DefaultIdentifier);
				publicPropertiesByName.Add("DefaultSeparator", Roslyn.Language_DefaultSeparator);
				publicPropertiesByName.Add("DefaultWhitespace", Roslyn.Language_DefaultWhitespace);
				publicPropertiesByName.Add("MainRule", Roslyn.Language_MainRule);
				publicPropertiesByName.Add("Name", Roslyn.Language_Name);
				publicPropertiesByName.Add("Namespace", Roslyn.Language_Namespace);
				publicPropertiesByName.Add("RootTypeName", Roslyn.Language_RootTypeName);
				publicPropertiesByName.Add("Rules", Roslyn.Language_Rules);
				publicPropertiesByName.Add("TokenKinds", Roslyn.Language_TokenKinds);
				publicPropertiesByName.Add("Tokens", Roslyn.Language_Tokens);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Language_DefaultEndOfLine, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_DefaultEndOfLine, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_DefaultEndOfLine), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_DefaultIdentifier, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_DefaultIdentifier, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_DefaultIdentifier), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_DefaultSeparator, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_DefaultSeparator, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_DefaultSeparator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_DefaultWhitespace, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_DefaultWhitespace, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_DefaultWhitespace), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_MainRule, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_MainRule, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_MainRule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_Namespace, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Namespace), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_RootTypeName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_RootTypeName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_RootTypeName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_Rules, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_Rules, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Rules), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_TokenKinds, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_TokenKinds, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_TokenKinds), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_Tokens, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_Tokens, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Tokens), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(Language);
	
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
				var result = new Language_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.LanguageInfo";
			}
		}
	}

	internal class Rule_Impl : __MetaModelObject, Rule
	{
		private Rule_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.Rule_Alternatives, new global::MetaDslx.Modeling.ModelObjectList<Alternative>(this, __Info.Instance.GetSlot(Roslyn.Rule_Alternatives)!));
			((__IModelObject)this).Init(Roslyn.Rule_Binders, new global::MetaDslx.Modeling.ModelObjectList<Binder>(this, __Info.Instance.GetSlot(Roslyn.Rule_Binders)!));
			Roslyn.__CustomImpl.Rule(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Alternative> Alternatives
		{
			get => MGetCollection<Alternative>(Roslyn.Rule_Alternatives);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.Rule_Binders);
		}
	
		public bool ContainsBinders
		{
			get => MGet<bool>(Roslyn.Rule_ContainsBinders);
			set => MAdd<bool>(Roslyn.Rule_ContainsBinders, value);
		}
	
		public string GreenName
		{
			get => Roslyn.__CustomImpl.Rule_GreenName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Roslyn.Rule_Name);
			set => MAdd<string>(Roslyn.Rule_Name, value);
		}
	
		public string RedName
		{
			get => Roslyn.__CustomImpl.Rule_RedName(this);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Binders, Roslyn.Rule_ContainsBinders, Roslyn.Rule_GreenName, Roslyn.Rule_Name, Roslyn.Rule_RedName);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Binders, Roslyn.Rule_ContainsBinders, Roslyn.Rule_GreenName, Roslyn.Rule_Name, Roslyn.Rule_RedName);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Binders, Roslyn.Rule_ContainsBinders, Roslyn.Rule_GreenName, Roslyn.Rule_Name, Roslyn.Rule_RedName);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Roslyn.Rule_Alternatives);
				publicPropertiesByName.Add("Binders", Roslyn.Rule_Binders);
				publicPropertiesByName.Add("ContainsBinders", Roslyn.Rule_ContainsBinders);
				publicPropertiesByName.Add("GreenName", Roslyn.Rule_GreenName);
				publicPropertiesByName.Add("Name", Roslyn.Rule_Name);
				publicPropertiesByName.Add("RedName", Roslyn.Rule_RedName);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Rule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Rule_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Rule_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Rule_GreenName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_GreenName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_GreenName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Rule_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Rule_RedName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_RedName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_RedName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(Rule);
	
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
				var result = new Rule_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.RuleInfo";
			}
		}
	}

	internal class RuleRef_Impl : __MetaModelObject, RuleRef
	{
		private RuleRef_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.ElementValue_Binders, new global::MetaDslx.Modeling.ModelObjectList<Binder>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Binders)!));
			Roslyn.__CustomImpl.ElementValue(this);
			Roslyn.__CustomImpl.RuleRef(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.RuleRef_GreenSyntaxCondition(this);
		}
	
		public string GreenType
		{
			get => Roslyn.__CustomImpl.RuleRef_GreenType(this);
		}
	
		public string RedType
		{
			get => Roslyn.__CustomImpl.RuleRef_RedType(this);
		}
	
		public Rule Rule
		{
			get => MGet<Rule>(Roslyn.RuleRef_Rule);
			set => MAdd<Rule>(Roslyn.RuleRef_Rule, value);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
		}
	
		public bool ContainsBinders
		{
			get => MGet<bool>(Roslyn.ElementValue_ContainsBinders);
			set => MAdd<bool>(Roslyn.ElementValue_ContainsBinders, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? ElementValue.GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.RuleRef_GreenSyntaxCondition(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string ElementValue.GreenType
		{
			get => Roslyn.__CustomImpl.RuleRef_GreenType(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string ElementValue.RedType
		{
			get => Roslyn.__CustomImpl.RuleRef_RedType(this);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Roslyn.ElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Roslyn.ElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenSyntaxCondition, Roslyn.RuleRef_GreenType, Roslyn.RuleRef_RedType, Roslyn.RuleRef_Rule);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenSyntaxCondition, Roslyn.RuleRef_GreenType, Roslyn.RuleRef_RedType, Roslyn.RuleRef_Rule, Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType, Roslyn.ElementValue_RedType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenSyntaxCondition, Roslyn.RuleRef_GreenType, Roslyn.RuleRef_RedType, Roslyn.RuleRef_Rule, Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.RuleRef_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.RuleRef_GreenType);
				publicPropertiesByName.Add("RedType", Roslyn.RuleRef_RedType);
				publicPropertiesByName.Add("Rule", Roslyn.RuleRef_Rule);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				publicPropertiesByName.Add("ContainsBinders", Roslyn.ElementValue_ContainsBinders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.RuleRef_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.RuleRef_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.RuleRef_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.RuleRef_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.RuleRef_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.RuleRef_RedType, __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_RedType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.RuleRef_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.RuleRef_Rule, __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenSyntaxCondition)));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenType)));
				modelPropertyInfos.Add(Roslyn.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_RedType)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(RuleRef);
	
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
				var result = new RuleRef_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.RuleRefInfo";
			}
		}
	}

	internal class SeparatedList_Impl : __MetaModelObject, SeparatedList
	{
		private SeparatedList_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.SeparatedList_FirstItems, new global::MetaDslx.Modeling.ModelObjectList<Element>(this, __Info.Instance.GetSlot(Roslyn.SeparatedList_FirstItems)!));
			((__IModelObject)this).Init(Roslyn.SeparatedList_FirstSeparators, new global::MetaDslx.Modeling.ModelObjectList<Element>(this, __Info.Instance.GetSlot(Roslyn.SeparatedList_FirstSeparators)!));
			((__IModelObject)this).Init(Roslyn.SeparatedList_LastItems, new global::MetaDslx.Modeling.ModelObjectList<Element>(this, __Info.Instance.GetSlot(Roslyn.SeparatedList_LastItems)!));
			((__IModelObject)this).Init(Roslyn.SeparatedList_LastSeparators, new global::MetaDslx.Modeling.ModelObjectList<Element>(this, __Info.Instance.GetSlot(Roslyn.SeparatedList_LastSeparators)!));
			((__IModelObject)this).Init(Roslyn.ElementValue_Binders, new global::MetaDslx.Modeling.ModelObjectList<Binder>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Binders)!));
			Roslyn.__CustomImpl.ElementValue(this);
			Roslyn.__CustomImpl.SeparatedList(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Element> FirstItems
		{
			get => MGetCollection<Element>(Roslyn.SeparatedList_FirstItems);
		}
	
		public global::System.Collections.Generic.IList<Element> FirstSeparators
		{
			get => MGetCollection<Element>(Roslyn.SeparatedList_FirstSeparators);
		}
	
		public string? GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.SeparatedList_GreenSyntaxCondition(this);
		}
	
		public string GreenType
		{
			get => Roslyn.__CustomImpl.SeparatedList_GreenType(this);
		}
	
		public global::System.Collections.Generic.IList<Element> LastItems
		{
			get => MGetCollection<Element>(Roslyn.SeparatedList_LastItems);
		}
	
		public global::System.Collections.Generic.IList<Element> LastSeparators
		{
			get => MGetCollection<Element>(Roslyn.SeparatedList_LastSeparators);
		}
	
		public string RedType
		{
			get => Roslyn.__CustomImpl.SeparatedList_RedType(this);
		}
	
		public Element RepeatedBlock
		{
			get => MGet<Element>(Roslyn.SeparatedList_RepeatedBlock);
			set => MAdd<Element>(Roslyn.SeparatedList_RepeatedBlock, value);
		}
	
		public Element RepeatedItem
		{
			get => MGet<Element>(Roslyn.SeparatedList_RepeatedItem);
			set => MAdd<Element>(Roslyn.SeparatedList_RepeatedItem, value);
		}
	
		public Element RepeatedSeparator
		{
			get => MGet<Element>(Roslyn.SeparatedList_RepeatedSeparator);
			set => MAdd<Element>(Roslyn.SeparatedList_RepeatedSeparator, value);
		}
	
		public bool RepeatedSeparatorFirst
		{
			get => MGet<bool>(Roslyn.SeparatedList_RepeatedSeparatorFirst);
			set => MAdd<bool>(Roslyn.SeparatedList_RepeatedSeparatorFirst, value);
		}
	
		public bool SeparatorFirst
		{
			get => MGet<bool>(Roslyn.SeparatedList_SeparatorFirst);
			set => MAdd<bool>(Roslyn.SeparatedList_SeparatorFirst, value);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
		}
	
		public bool ContainsBinders
		{
			get => MGet<bool>(Roslyn.ElementValue_ContainsBinders);
			set => MAdd<bool>(Roslyn.ElementValue_ContainsBinders, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? ElementValue.GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.SeparatedList_GreenSyntaxCondition(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string ElementValue.GreenType
		{
			get => Roslyn.__CustomImpl.SeparatedList_GreenType(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string ElementValue.RedType
		{
			get => Roslyn.__CustomImpl.SeparatedList_RedType(this);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Roslyn.ElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Roslyn.ElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_FirstItems, Roslyn.SeparatedList_FirstSeparators, Roslyn.SeparatedList_GreenSyntaxCondition, Roslyn.SeparatedList_GreenType, Roslyn.SeparatedList_LastItems, Roslyn.SeparatedList_LastSeparators, Roslyn.SeparatedList_RedType, Roslyn.SeparatedList_RepeatedBlock, Roslyn.SeparatedList_RepeatedItem, Roslyn.SeparatedList_RepeatedSeparator, Roslyn.SeparatedList_RepeatedSeparatorFirst, Roslyn.SeparatedList_SeparatorFirst);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_FirstItems, Roslyn.SeparatedList_FirstSeparators, Roslyn.SeparatedList_GreenSyntaxCondition, Roslyn.SeparatedList_GreenType, Roslyn.SeparatedList_LastItems, Roslyn.SeparatedList_LastSeparators, Roslyn.SeparatedList_RedType, Roslyn.SeparatedList_RepeatedBlock, Roslyn.SeparatedList_RepeatedItem, Roslyn.SeparatedList_RepeatedSeparator, Roslyn.SeparatedList_RepeatedSeparatorFirst, Roslyn.SeparatedList_SeparatorFirst, Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType, Roslyn.ElementValue_RedType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_FirstItems, Roslyn.SeparatedList_FirstSeparators, Roslyn.SeparatedList_GreenSyntaxCondition, Roslyn.SeparatedList_GreenType, Roslyn.SeparatedList_LastItems, Roslyn.SeparatedList_LastSeparators, Roslyn.SeparatedList_RedType, Roslyn.SeparatedList_RepeatedBlock, Roslyn.SeparatedList_RepeatedItem, Roslyn.SeparatedList_RepeatedSeparator, Roslyn.SeparatedList_RepeatedSeparatorFirst, Roslyn.SeparatedList_SeparatorFirst, Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FirstItems", Roslyn.SeparatedList_FirstItems);
				publicPropertiesByName.Add("FirstSeparators", Roslyn.SeparatedList_FirstSeparators);
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.SeparatedList_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.SeparatedList_GreenType);
				publicPropertiesByName.Add("LastItems", Roslyn.SeparatedList_LastItems);
				publicPropertiesByName.Add("LastSeparators", Roslyn.SeparatedList_LastSeparators);
				publicPropertiesByName.Add("RedType", Roslyn.SeparatedList_RedType);
				publicPropertiesByName.Add("RepeatedBlock", Roslyn.SeparatedList_RepeatedBlock);
				publicPropertiesByName.Add("RepeatedItem", Roslyn.SeparatedList_RepeatedItem);
				publicPropertiesByName.Add("RepeatedSeparator", Roslyn.SeparatedList_RepeatedSeparator);
				publicPropertiesByName.Add("RepeatedSeparatorFirst", Roslyn.SeparatedList_RepeatedSeparatorFirst);
				publicPropertiesByName.Add("SeparatorFirst", Roslyn.SeparatedList_SeparatorFirst);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				publicPropertiesByName.Add("ContainsBinders", Roslyn.ElementValue_ContainsBinders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.SeparatedList_FirstItems, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_FirstItems, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_FirstItems), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_FirstSeparators, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_FirstSeparators, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_FirstSeparators), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_LastItems, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_LastItems, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_LastItems), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_LastSeparators, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_LastSeparators, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_LastSeparators), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_RedType, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_RedType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_RepeatedBlock, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_RepeatedBlock, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_RepeatedBlock), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_RepeatedItem, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_RepeatedItem, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_RepeatedItem), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_RepeatedSeparator, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_RepeatedSeparator, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_RepeatedSeparator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_RepeatedSeparatorFirst, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_RepeatedSeparatorFirst, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_RepeatedSeparatorFirst), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_SeparatorFirst, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_SeparatorFirst, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_SeparatorFirst), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_GreenSyntaxCondition)));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_GreenType)));
				modelPropertyInfos.Add(Roslyn.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_RedType)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(SeparatedList);
	
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
				var result = new SeparatedList_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.SeparatedListInfo";
			}
		}
	}

	internal class Token_Impl : __MetaModelObject, Token
	{
		private Token_Impl(string? id)
			: base(id)
		{
			Roslyn.__CustomImpl.Token(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? FixedText
		{
			get => MGet<string?>(Roslyn.Token_FixedText);
			set => MAdd<string?>(Roslyn.Token_FixedText, value);
		}
	
		public bool IsFixed
		{
			get => MGet<bool>(Roslyn.Token_IsFixed);
			set => MAdd<bool>(Roslyn.Token_IsFixed, value);
		}
	
		public bool IsTrivia
		{
			get => MGet<bool>(Roslyn.Token_IsTrivia);
			set => MAdd<bool>(Roslyn.Token_IsTrivia, value);
		}
	
		public string Name
		{
			get => MGet<string>(Roslyn.Token_Name);
			set => MAdd<string>(Roslyn.Token_Name, value);
		}
	
		public TokenKind TokenKind
		{
			get => MGet<TokenKind>(Roslyn.Token_TokenKind);
			set => MAdd<TokenKind>(Roslyn.Token_TokenKind, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_FixedText, Roslyn.Token_IsFixed, Roslyn.Token_IsTrivia, Roslyn.Token_Name, Roslyn.Token_TokenKind);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_FixedText, Roslyn.Token_IsFixed, Roslyn.Token_IsTrivia, Roslyn.Token_Name, Roslyn.Token_TokenKind);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_FixedText, Roslyn.Token_IsFixed, Roslyn.Token_IsTrivia, Roslyn.Token_Name, Roslyn.Token_TokenKind);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FixedText", Roslyn.Token_FixedText);
				publicPropertiesByName.Add("IsFixed", Roslyn.Token_IsFixed);
				publicPropertiesByName.Add("IsTrivia", Roslyn.Token_IsTrivia);
				publicPropertiesByName.Add("Name", Roslyn.Token_Name);
				publicPropertiesByName.Add("TokenKind", Roslyn.Token_TokenKind);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Token_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_FixedText, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Token_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_IsFixed, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Token_IsTrivia, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_IsTrivia, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_IsTrivia), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Token_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Token_TokenKind, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_TokenKind, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_TokenKind), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(Token);
	
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
				var result = new Token_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.TokenInfo";
			}
		}
	}

	internal class TokenAlts_Impl : __MetaModelObject, TokenAlts
	{
		private TokenAlts_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.TokenAlts_Tokens, new global::MetaDslx.Modeling.ModelObjectList<TokenRef>(this, __Info.Instance.GetSlot(Roslyn.TokenAlts_Tokens)!));
			((__IModelObject)this).Init(Roslyn.ElementValue_Binders, new global::MetaDslx.Modeling.ModelObjectList<Binder>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Binders)!));
			Roslyn.__CustomImpl.ElementValue(this);
			Roslyn.__CustomImpl.TokenAlts(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.TokenAlts_GreenSyntaxCondition(this);
		}
	
		public string GreenType
		{
			get => Roslyn.__CustomImpl.TokenAlts_GreenType(this);
		}
	
		public string RedType
		{
			get => Roslyn.__CustomImpl.TokenAlts_RedType(this);
		}
	
		public global::System.Collections.Generic.IList<TokenRef> Tokens
		{
			get => MGetCollection<TokenRef>(Roslyn.TokenAlts_Tokens);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
		}
	
		public bool ContainsBinders
		{
			get => MGet<bool>(Roslyn.ElementValue_ContainsBinders);
			set => MAdd<bool>(Roslyn.ElementValue_ContainsBinders, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? ElementValue.GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.TokenAlts_GreenSyntaxCondition(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string ElementValue.GreenType
		{
			get => Roslyn.__CustomImpl.TokenAlts_GreenType(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string ElementValue.RedType
		{
			get => Roslyn.__CustomImpl.TokenAlts_RedType(this);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Roslyn.ElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Roslyn.ElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenSyntaxCondition, Roslyn.TokenAlts_GreenType, Roslyn.TokenAlts_RedType, Roslyn.TokenAlts_Tokens);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenSyntaxCondition, Roslyn.TokenAlts_GreenType, Roslyn.TokenAlts_RedType, Roslyn.TokenAlts_Tokens, Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType, Roslyn.ElementValue_RedType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenSyntaxCondition, Roslyn.TokenAlts_GreenType, Roslyn.TokenAlts_RedType, Roslyn.TokenAlts_Tokens, Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.TokenAlts_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.TokenAlts_GreenType);
				publicPropertiesByName.Add("RedType", Roslyn.TokenAlts_RedType);
				publicPropertiesByName.Add("Tokens", Roslyn.TokenAlts_Tokens);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				publicPropertiesByName.Add("ContainsBinders", Roslyn.ElementValue_ContainsBinders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.TokenAlts_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenAlts_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.TokenAlts_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenAlts_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.TokenAlts_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenAlts_RedType, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_RedType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.TokenAlts_Tokens, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenAlts_Tokens, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_Tokens), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenSyntaxCondition)));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenType)));
				modelPropertyInfos.Add(Roslyn.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_RedType)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(TokenAlts);
	
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
				var result = new TokenAlts_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.TokenAltsInfo";
			}
		}
	}

	internal class TokenKind_Impl : __MetaModelObject, TokenKind
	{
		private TokenKind_Impl(string? id)
			: base(id)
		{
			Roslyn.__CustomImpl.TokenKind(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string Name
		{
			get => MGet<string>(Roslyn.TokenKind_Name);
			set => MAdd<string>(Roslyn.TokenKind_Name, value);
		}
	
		public string TypeName
		{
			get => MGet<string>(Roslyn.TokenKind_TypeName);
			set => MAdd<string>(Roslyn.TokenKind_TypeName, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenKind_Name, Roslyn.TokenKind_TypeName);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenKind_Name, Roslyn.TokenKind_TypeName);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenKind_Name, Roslyn.TokenKind_TypeName);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Name", Roslyn.TokenKind_Name);
				publicPropertiesByName.Add("TypeName", Roslyn.TokenKind_TypeName);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.TokenKind_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenKind_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenKind_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.TokenKind_TypeName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenKind_TypeName, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenKind_TypeName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(TokenKind);
	
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
				var result = new TokenKind_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.TokenKindInfo";
			}
		}
	}

	internal class TokenRef_Impl : __MetaModelObject, TokenRef
	{
		private TokenRef_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.ElementValue_Binders, new global::MetaDslx.Modeling.ModelObjectList<Binder>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Binders)!));
			Roslyn.__CustomImpl.ElementValue(this);
			Roslyn.__CustomImpl.TokenRef(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string? GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.TokenRef_GreenSyntaxCondition(this);
		}
	
		public string GreenType
		{
			get => Roslyn.__CustomImpl.TokenRef_GreenType(this);
		}
	
		public string RedType
		{
			get => Roslyn.__CustomImpl.TokenRef_RedType(this);
		}
	
		public Token Token
		{
			get => MGet<Token>(Roslyn.TokenRef_Token);
			set => MAdd<Token>(Roslyn.TokenRef_Token, value);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
		}
	
		public bool ContainsBinders
		{
			get => MGet<bool>(Roslyn.ElementValue_ContainsBinders);
			set => MAdd<bool>(Roslyn.ElementValue_ContainsBinders, value);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string? ElementValue.GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.TokenRef_GreenSyntaxCondition(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string ElementValue.GreenType
		{
			get => Roslyn.__CustomImpl.TokenRef_GreenType(this);
		}
	
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		string ElementValue.RedType
		{
			get => Roslyn.__CustomImpl.TokenRef_RedType(this);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Roslyn.ElementValueInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Roslyn.ElementValueInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenSyntaxCondition, Roslyn.TokenRef_GreenType, Roslyn.TokenRef_RedType, Roslyn.TokenRef_Token);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenSyntaxCondition, Roslyn.TokenRef_GreenType, Roslyn.TokenRef_RedType, Roslyn.TokenRef_Token, Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType, Roslyn.ElementValue_RedType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenSyntaxCondition, Roslyn.TokenRef_GreenType, Roslyn.TokenRef_RedType, Roslyn.TokenRef_Token, Roslyn.ElementValue_Binders, Roslyn.ElementValue_ContainsBinders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.TokenRef_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.TokenRef_GreenType);
				publicPropertiesByName.Add("RedType", Roslyn.TokenRef_RedType);
				publicPropertiesByName.Add("Token", Roslyn.TokenRef_Token);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				publicPropertiesByName.Add("ContainsBinders", Roslyn.ElementValue_ContainsBinders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.TokenRef_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenRef_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.TokenRef_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenRef_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.TokenRef_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenRef_RedType, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_RedType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.TokenRef_Token, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenRef_Token, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenSyntaxCondition)));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenType)));
				modelPropertyInfos.Add(Roslyn.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_RedType)));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(TokenRef);
	
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
				var result = new TokenRef_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.TokenRefInfo";
			}
		}
	}

}
