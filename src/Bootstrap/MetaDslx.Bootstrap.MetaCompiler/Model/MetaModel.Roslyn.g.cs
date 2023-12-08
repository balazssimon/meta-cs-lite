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
		private static readonly __ModelProperty _BinderArgument_Name;
		private static readonly __ModelProperty _BinderArgument_Values;
		private static readonly __ModelProperty _TokenKind_Name;
		private static readonly __ModelProperty _TokenKind_TypeName;
		private static readonly __ModelProperty _Language_Name;
		private static readonly __ModelProperty _Language_Namespace;
		private static readonly __ModelProperty _Language_TokenKinds;
		private static readonly __ModelProperty _Language_Tokens;
		private static readonly __ModelProperty _Language_Rules;
		private static readonly __ModelProperty _Token_Name;
		private static readonly __ModelProperty _Token_TokenKind;
		private static readonly __ModelProperty _Token_IsTrivia;
		private static readonly __ModelProperty _Token_IsFixed;
		private static readonly __ModelProperty _Token_FixedText;
		private static readonly __ModelProperty _Rule_Binders;
		private static readonly __ModelProperty _Rule_Name;
		private static readonly __ModelProperty _Rule_Alternatives;
		private static readonly __ModelProperty _Rule_GreenName;
		private static readonly __ModelProperty _Alternative_Name;
		private static readonly __ModelProperty _Alternative_Binders;
		private static readonly __ModelProperty _Alternative_Elements;
		private static readonly __ModelProperty _Alternative_GreenName;
		private static readonly __ModelProperty _Alternative_GreenConstructorParameters;
		private static readonly __ModelProperty _Alternative_GreenConstructorArguments;
		private static readonly __ModelProperty _Alternative_GreenUpdateParameters;
		private static readonly __ModelProperty _Alternative_GreenUpdateArguments;
		private static readonly __ModelProperty _Alternative_RedName;
		private static readonly __ModelProperty _Element_Binders;
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
		private static readonly __ModelProperty _ElementValue_Binders;
		private static readonly __ModelProperty _ElementValue_GreenType;
		private static readonly __ModelProperty _ElementValue_GreenSyntaxCondition;
		private static readonly __ModelProperty _RuleRef_Rule;
		private static readonly __ModelProperty _RuleRef_GreenType;
		private static readonly __ModelProperty _RuleRef_GreenSyntaxCondition;
		private static readonly __ModelProperty _TokenRef_Token;
		private static readonly __ModelProperty _TokenRef_GreenType;
		private static readonly __ModelProperty _TokenRef_GreenSyntaxCondition;
		private static readonly __ModelProperty _TokenAlts_Tokens;
		private static readonly __ModelProperty _TokenAlts_GreenType;
		private static readonly __ModelProperty _TokenAlts_GreenSyntaxCondition;
		private static readonly __ModelProperty _Eof_GreenType;
		private static readonly __ModelProperty _Eof_GreenSyntaxCondition;
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
	
		static Roslyn()
		{
			_Alternative_Binders = new __ModelProperty(typeof(Alternative), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Alternative_Elements = new __ModelProperty(typeof(Alternative), "Elements", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Alternative_GreenConstructorArguments = new __ModelProperty(typeof(Alternative), "GreenConstructorArguments", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_GreenConstructorParameters = new __ModelProperty(typeof(Alternative), "GreenConstructorParameters", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_GreenName = new __ModelProperty(typeof(Alternative), "GreenName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_GreenUpdateArguments = new __ModelProperty(typeof(Alternative), "GreenUpdateArguments", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_GreenUpdateParameters = new __ModelProperty(typeof(Alternative), "GreenUpdateParameters", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Alternative_Name = new __ModelProperty(typeof(Alternative), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Alternative_RedName = new __ModelProperty(typeof(Alternative), "RedName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Binder_Arguments = new __ModelProperty(typeof(Binder), "Arguments", typeof(BinderArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Binder_TypeName = new __ModelProperty(typeof(Binder), "TypeName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_BinderArgument_Name = new __ModelProperty(typeof(BinderArgument), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_BinderArgument_Values = new __ModelProperty(typeof(BinderArgument), "Values", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, null);
			_Element_Assignment = new __ModelProperty(typeof(Element), "Assignment", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType, null);
			_Element_Binders = new __ModelProperty(typeof(Element), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Element_FieldName = new __ModelProperty(typeof(Element), "FieldName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenFieldType = new __ModelProperty(typeof(Element), "GreenFieldType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenParameterValue = new __ModelProperty(typeof(Element), "GreenParameterValue", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenPropertyType = new __ModelProperty(typeof(Element), "GreenPropertyType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenPropertyValue = new __ModelProperty(typeof(Element), "GreenPropertyValue", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenSyntaxCondition = new __ModelProperty(typeof(Element), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_GreenSyntaxNullCondition = new __ModelProperty(typeof(Element), "GreenSyntaxNullCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_Multiplicity = new __ModelProperty(typeof(Element), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType, null);
			_Element_Name = new __ModelProperty(typeof(Element), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Element_ParameterName = new __ModelProperty(typeof(Element), "ParameterName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_PropertyName = new __ModelProperty(typeof(Element), "PropertyName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Element_Value = new __ModelProperty(typeof(Element), "Value", typeof(ElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_ElementValue_Binders = new __ModelProperty(typeof(ElementValue), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_ElementValue_GreenSyntaxCondition = new __ModelProperty(typeof(ElementValue), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_ElementValue_GreenType = new __ModelProperty(typeof(ElementValue), "GreenType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Eof_GreenSyntaxCondition = new __ModelProperty(typeof(Eof), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Eof_GreenType = new __ModelProperty(typeof(Eof), "GreenType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Language_Name = new __ModelProperty(typeof(Language), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Language_Namespace = new __ModelProperty(typeof(Language), "Namespace", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Language_Rules = new __ModelProperty(typeof(Language), "Rules", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Language_TokenKinds = new __ModelProperty(typeof(Language), "TokenKinds", typeof(TokenKind), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Language_Tokens = new __ModelProperty(typeof(Language), "Tokens", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Rule_Alternatives = new __ModelProperty(typeof(Rule), "Alternatives", typeof(Alternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Rule_Binders = new __ModelProperty(typeof(Rule), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Rule_GreenName = new __ModelProperty(typeof(Rule), "GreenName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_Rule_Name = new __ModelProperty(typeof(Rule), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_RuleRef_GreenSyntaxCondition = new __ModelProperty(typeof(RuleRef), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_RuleRef_GreenType = new __ModelProperty(typeof(RuleRef), "GreenType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_RuleRef_Rule = new __ModelProperty(typeof(RuleRef), "Rule", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_SeparatedList_FirstItems = new __ModelProperty(typeof(SeparatedList), "FirstItems", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_SeparatedList_FirstSeparators = new __ModelProperty(typeof(SeparatedList), "FirstSeparators", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_SeparatedList_GreenSyntaxCondition = new __ModelProperty(typeof(SeparatedList), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_SeparatedList_GreenType = new __ModelProperty(typeof(SeparatedList), "GreenType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_SeparatedList_LastItems = new __ModelProperty(typeof(SeparatedList), "LastItems", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_SeparatedList_LastSeparators = new __ModelProperty(typeof(SeparatedList), "LastSeparators", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
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
			_TokenAlts_Tokens = new __ModelProperty(typeof(TokenAlts), "Tokens", typeof(TokenRef), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_TokenKind_Name = new __ModelProperty(typeof(TokenKind), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_TokenKind_TypeName = new __ModelProperty(typeof(TokenKind), "TypeName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_TokenRef_GreenSyntaxCondition = new __ModelProperty(typeof(TokenRef), "GreenSyntaxCondition", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_TokenRef_GreenType = new __ModelProperty(typeof(TokenRef), "GreenType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
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
			var obj23 = f.MetaArrayType();
			var obj24 = f.MetaProperty();
			var obj25 = f.MetaProperty();
			var obj26 = f.MetaArrayType();
			var obj27 = f.MetaProperty();
			var obj28 = f.MetaProperty();
			var obj29 = f.MetaProperty();
			var obj30 = f.MetaProperty();
			var obj31 = f.MetaProperty();
			var obj32 = f.MetaProperty();
			var obj33 = f.MetaProperty();
			var obj34 = f.MetaArrayType();
			var obj35 = f.MetaArrayType();
			var obj36 = f.MetaArrayType();
			var obj37 = f.MetaProperty();
			var obj38 = f.MetaProperty();
			var obj39 = f.MetaProperty();
			var obj40 = f.MetaProperty();
			var obj41 = f.MetaProperty();
			var obj42 = f.MetaNullableType();
			var obj43 = f.MetaProperty();
			var obj44 = f.MetaProperty();
			var obj45 = f.MetaProperty();
			var obj46 = f.MetaProperty();
			var obj47 = f.MetaArrayType();
			var obj48 = f.MetaArrayType();
			var obj49 = f.MetaProperty();
			var obj50 = f.MetaProperty();
			var obj51 = f.MetaProperty();
			var obj52 = f.MetaProperty();
			var obj53 = f.MetaProperty();
			var obj54 = f.MetaProperty();
			var obj55 = f.MetaProperty();
			var obj56 = f.MetaProperty();
			var obj57 = f.MetaProperty();
			var obj58 = f.MetaArrayType();
			var obj59 = f.MetaArrayType();
			var obj60 = f.MetaProperty();
			var obj61 = f.MetaProperty();
			var obj62 = f.MetaProperty();
			var obj63 = f.MetaProperty();
			var obj64 = f.MetaProperty();
			var obj65 = f.MetaProperty();
			var obj66 = f.MetaProperty();
			var obj67 = f.MetaProperty();
			var obj68 = f.MetaProperty();
			var obj69 = f.MetaProperty();
			var obj70 = f.MetaProperty();
			var obj71 = f.MetaProperty();
			var obj72 = f.MetaProperty();
			var obj73 = f.MetaProperty();
			var obj74 = f.MetaArrayType();
			var obj75 = f.MetaNullableType();
			var obj76 = f.MetaNullableType();
			var obj77 = f.MetaNullableType();
			var obj78 = f.MetaProperty();
			var obj79 = f.MetaProperty();
			var obj80 = f.MetaProperty();
			var obj81 = f.MetaArrayType();
			var obj82 = f.MetaNullableType();
			var obj83 = f.MetaProperty();
			var obj84 = f.MetaProperty();
			var obj85 = f.MetaProperty();
			var obj86 = f.MetaNullableType();
			var obj87 = f.MetaProperty();
			var obj88 = f.MetaProperty();
			var obj89 = f.MetaProperty();
			var obj90 = f.MetaNullableType();
			var obj91 = f.MetaProperty();
			var obj92 = f.MetaProperty();
			var obj93 = f.MetaProperty();
			var obj94 = f.MetaArrayType();
			var obj95 = f.MetaNullableType();
			var obj96 = f.MetaProperty();
			var obj97 = f.MetaProperty();
			var obj98 = f.MetaNullableType();
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
			var obj111 = f.MetaArrayType();
			var obj112 = f.MetaArrayType();
			var obj113 = f.MetaArrayType();
			var obj114 = f.MetaNullableType();
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
			obj7.Properties.Add(obj21);
			obj7.Properties.Add(obj22);
			obj7.Declarations.Add(obj21);
			obj7.Declarations.Add(obj22);
			obj7.Name = "Binder";
			obj7.Parent = obj5;
			((__IModelObject)obj8).Children.Add((__IModelObject)obj24);
			((__IModelObject)obj8).Children.Add((__IModelObject)obj25);
			obj8.Properties.Add(obj24);
			obj8.Properties.Add(obj25);
			obj8.Declarations.Add(obj24);
			obj8.Declarations.Add(obj25);
			obj8.Name = "BinderArgument";
			obj8.Parent = obj5;
			((__IModelObject)obj9).Children.Add((__IModelObject)obj27);
			((__IModelObject)obj9).Children.Add((__IModelObject)obj28);
			obj9.Properties.Add(obj27);
			obj9.Properties.Add(obj28);
			obj9.Declarations.Add(obj27);
			obj9.Declarations.Add(obj28);
			obj9.Name = "TokenKind";
			obj9.Parent = obj5;
			((__IModelObject)obj10).Children.Add((__IModelObject)obj29);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj30);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj31);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj32);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj33);
			obj10.Properties.Add(obj29);
			obj10.Properties.Add(obj30);
			obj10.Properties.Add(obj31);
			obj10.Properties.Add(obj32);
			obj10.Properties.Add(obj33);
			obj10.Declarations.Add(obj29);
			obj10.Declarations.Add(obj30);
			obj10.Declarations.Add(obj31);
			obj10.Declarations.Add(obj32);
			obj10.Declarations.Add(obj33);
			obj10.Name = "Language";
			obj10.Parent = obj5;
			((__IModelObject)obj11).Children.Add((__IModelObject)obj37);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj38);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj39);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj40);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj41);
			obj11.Properties.Add(obj37);
			obj11.Properties.Add(obj38);
			obj11.Properties.Add(obj39);
			obj11.Properties.Add(obj40);
			obj11.Properties.Add(obj41);
			obj11.Declarations.Add(obj37);
			obj11.Declarations.Add(obj38);
			obj11.Declarations.Add(obj39);
			obj11.Declarations.Add(obj40);
			obj11.Declarations.Add(obj41);
			obj11.Name = "Token";
			obj11.Parent = obj5;
			((__IModelObject)obj12).Children.Add((__IModelObject)obj43);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj44);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj45);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj46);
			obj12.Properties.Add(obj43);
			obj12.Properties.Add(obj44);
			obj12.Properties.Add(obj45);
			obj12.Properties.Add(obj46);
			obj12.Declarations.Add(obj43);
			obj12.Declarations.Add(obj44);
			obj12.Declarations.Add(obj45);
			obj12.Declarations.Add(obj46);
			obj12.Name = "Rule";
			obj12.Parent = obj5;
			((__IModelObject)obj13).Children.Add((__IModelObject)obj49);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj50);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj51);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj52);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj53);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj54);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj55);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj56);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj57);
			obj13.Properties.Add(obj49);
			obj13.Properties.Add(obj50);
			obj13.Properties.Add(obj51);
			obj13.Properties.Add(obj52);
			obj13.Properties.Add(obj53);
			obj13.Properties.Add(obj54);
			obj13.Properties.Add(obj55);
			obj13.Properties.Add(obj56);
			obj13.Properties.Add(obj57);
			obj13.Declarations.Add(obj49);
			obj13.Declarations.Add(obj50);
			obj13.Declarations.Add(obj51);
			obj13.Declarations.Add(obj52);
			obj13.Declarations.Add(obj53);
			obj13.Declarations.Add(obj54);
			obj13.Declarations.Add(obj55);
			obj13.Declarations.Add(obj56);
			obj13.Declarations.Add(obj57);
			obj13.Name = "Alternative";
			obj13.Parent = obj5;
			((__IModelObject)obj14).Children.Add((__IModelObject)obj60);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj61);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj62);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj63);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj64);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj65);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj66);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj67);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj68);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj69);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj70);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj71);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj72);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj73);
			obj14.Properties.Add(obj60);
			obj14.Properties.Add(obj61);
			obj14.Properties.Add(obj62);
			obj14.Properties.Add(obj63);
			obj14.Properties.Add(obj64);
			obj14.Properties.Add(obj65);
			obj14.Properties.Add(obj66);
			obj14.Properties.Add(obj67);
			obj14.Properties.Add(obj68);
			obj14.Properties.Add(obj69);
			obj14.Properties.Add(obj70);
			obj14.Properties.Add(obj71);
			obj14.Properties.Add(obj72);
			obj14.Properties.Add(obj73);
			obj14.Declarations.Add(obj60);
			obj14.Declarations.Add(obj61);
			obj14.Declarations.Add(obj62);
			obj14.Declarations.Add(obj63);
			obj14.Declarations.Add(obj64);
			obj14.Declarations.Add(obj65);
			obj14.Declarations.Add(obj66);
			obj14.Declarations.Add(obj67);
			obj14.Declarations.Add(obj68);
			obj14.Declarations.Add(obj69);
			obj14.Declarations.Add(obj70);
			obj14.Declarations.Add(obj71);
			obj14.Declarations.Add(obj72);
			obj14.Declarations.Add(obj73);
			obj14.Name = "Element";
			obj14.Parent = obj5;
			((__IModelObject)obj15).Children.Add((__IModelObject)obj78);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj79);
			((__IModelObject)obj15).Children.Add((__IModelObject)obj80);
			obj15.IsAbstract = true;
			obj15.Properties.Add(obj78);
			obj15.Properties.Add(obj79);
			obj15.Properties.Add(obj80);
			obj15.Declarations.Add(obj78);
			obj15.Declarations.Add(obj79);
			obj15.Declarations.Add(obj80);
			obj15.Name = "ElementValue";
			obj15.Parent = obj5;
			((__IModelObject)obj16).Children.Add((__IModelObject)obj83);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj84);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj85);
			obj16.BaseTypes.Add(obj15);
			obj16.Properties.Add(obj83);
			obj16.Properties.Add(obj84);
			obj16.Properties.Add(obj85);
			obj16.Declarations.Add(obj83);
			obj16.Declarations.Add(obj84);
			obj16.Declarations.Add(obj85);
			obj16.Name = "RuleRef";
			obj16.Parent = obj5;
			((__IModelObject)obj17).Children.Add((__IModelObject)obj87);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj88);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj89);
			obj17.BaseTypes.Add(obj15);
			obj17.Properties.Add(obj87);
			obj17.Properties.Add(obj88);
			obj17.Properties.Add(obj89);
			obj17.Declarations.Add(obj87);
			obj17.Declarations.Add(obj88);
			obj17.Declarations.Add(obj89);
			obj17.Name = "TokenRef";
			obj17.Parent = obj5;
			((__IModelObject)obj18).Children.Add((__IModelObject)obj91);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj92);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj93);
			obj18.BaseTypes.Add(obj15);
			obj18.Properties.Add(obj91);
			obj18.Properties.Add(obj92);
			obj18.Properties.Add(obj93);
			obj18.Declarations.Add(obj91);
			obj18.Declarations.Add(obj92);
			obj18.Declarations.Add(obj93);
			obj18.Name = "TokenAlts";
			obj18.Parent = obj5;
			((__IModelObject)obj19).Children.Add((__IModelObject)obj96);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj97);
			obj19.BaseTypes.Add(obj15);
			obj19.Properties.Add(obj96);
			obj19.Properties.Add(obj97);
			obj19.Declarations.Add(obj96);
			obj19.Declarations.Add(obj97);
			obj19.Name = "Eof";
			obj19.Parent = obj5;
			((__IModelObject)obj20).Children.Add((__IModelObject)obj99);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj100);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj101);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj102);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj103);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj104);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj105);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj106);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj107);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj108);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj109);
			obj20.BaseTypes.Add(obj15);
			obj20.Properties.Add(obj99);
			obj20.Properties.Add(obj100);
			obj20.Properties.Add(obj101);
			obj20.Properties.Add(obj102);
			obj20.Properties.Add(obj103);
			obj20.Properties.Add(obj104);
			obj20.Properties.Add(obj105);
			obj20.Properties.Add(obj106);
			obj20.Properties.Add(obj107);
			obj20.Properties.Add(obj108);
			obj20.Properties.Add(obj109);
			obj20.Declarations.Add(obj99);
			obj20.Declarations.Add(obj100);
			obj20.Declarations.Add(obj101);
			obj20.Declarations.Add(obj102);
			obj20.Declarations.Add(obj103);
			obj20.Declarations.Add(obj104);
			obj20.Declarations.Add(obj105);
			obj20.Declarations.Add(obj106);
			obj20.Declarations.Add(obj107);
			obj20.Declarations.Add(obj108);
			obj20.Declarations.Add(obj109);
			obj20.Name = "SeparatedList";
			obj20.Parent = obj5;
			obj21.Type = typeof(string);
			obj21.Name = "TypeName";
			obj21.Parent = obj7;
			((__IModelObject)obj22).Children.Add((__IModelObject)obj23);
			obj22.IsContainment = true;
			obj22.Type = __MetaType.FromModelObject((__IModelObject)obj23);
			obj22.Name = "Arguments";
			obj22.Parent = obj7;
			obj23.ItemType = __MetaType.FromModelObject((__IModelObject)obj8);
			obj24.Type = typeof(string);
			obj24.Name = "Name";
			obj24.Parent = obj8;
			((__IModelObject)obj25).Children.Add((__IModelObject)obj26);
			obj25.Type = __MetaType.FromModelObject((__IModelObject)obj26);
			obj25.Name = "Values";
			obj25.Parent = obj8;
			obj26.ItemType = typeof(string);
			obj27.Type = typeof(string);
			obj27.Name = "Name";
			obj27.Parent = obj9;
			obj28.Type = typeof(string);
			obj28.Name = "TypeName";
			obj28.Parent = obj9;
			obj29.Type = typeof(string);
			obj29.Name = "Name";
			obj29.Parent = obj10;
			obj30.Type = typeof(string);
			obj30.Name = "Namespace";
			obj30.Parent = obj10;
			((__IModelObject)obj31).Children.Add((__IModelObject)obj34);
			obj31.IsContainment = true;
			obj31.Type = __MetaType.FromModelObject((__IModelObject)obj34);
			obj31.Name = "TokenKinds";
			obj31.Parent = obj10;
			((__IModelObject)obj32).Children.Add((__IModelObject)obj35);
			obj32.IsContainment = true;
			obj32.Type = __MetaType.FromModelObject((__IModelObject)obj35);
			obj32.Name = "Tokens";
			obj32.Parent = obj10;
			((__IModelObject)obj33).Children.Add((__IModelObject)obj36);
			obj33.IsContainment = true;
			obj33.Type = __MetaType.FromModelObject((__IModelObject)obj36);
			obj33.Name = "Rules";
			obj33.Parent = obj10;
			obj34.ItemType = __MetaType.FromModelObject((__IModelObject)obj9);
			obj35.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj36.ItemType = __MetaType.FromModelObject((__IModelObject)obj12);
			obj37.Type = typeof(string);
			obj37.Name = "Name";
			obj37.Parent = obj11;
			obj38.Type = __MetaType.FromModelObject((__IModelObject)obj9);
			obj38.Name = "TokenKind";
			obj38.Parent = obj11;
			obj39.Type = typeof(bool);
			obj39.Name = "IsTrivia";
			obj39.Parent = obj11;
			obj40.Type = typeof(bool);
			obj40.Name = "IsFixed";
			obj40.Parent = obj11;
			((__IModelObject)obj41).Children.Add((__IModelObject)obj42);
			obj41.Type = __MetaType.FromModelObject((__IModelObject)obj42);
			obj41.Name = "FixedText";
			obj41.Parent = obj11;
			obj42.InnerType = typeof(string);
			((__IModelObject)obj43).Children.Add((__IModelObject)obj47);
			obj43.IsContainment = true;
			obj43.Type = __MetaType.FromModelObject((__IModelObject)obj47);
			obj43.Name = "Binders";
			obj43.Parent = obj12;
			obj44.Type = typeof(string);
			obj44.Name = "Name";
			obj44.Parent = obj12;
			((__IModelObject)obj45).Children.Add((__IModelObject)obj48);
			obj45.IsContainment = true;
			obj45.Type = __MetaType.FromModelObject((__IModelObject)obj48);
			obj45.Name = "Alternatives";
			obj45.Parent = obj12;
			obj46.IsDerived = true;
			obj46.Type = typeof(string);
			obj46.Name = "GreenName";
			obj46.Parent = obj12;
			obj47.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj48.ItemType = __MetaType.FromModelObject((__IModelObject)obj13);
			obj49.Type = typeof(string);
			obj49.Name = "Name";
			obj49.Parent = obj13;
			((__IModelObject)obj50).Children.Add((__IModelObject)obj58);
			obj50.IsContainment = true;
			obj50.Type = __MetaType.FromModelObject((__IModelObject)obj58);
			obj50.Name = "Binders";
			obj50.Parent = obj13;
			((__IModelObject)obj51).Children.Add((__IModelObject)obj59);
			obj51.IsContainment = true;
			obj51.Type = __MetaType.FromModelObject((__IModelObject)obj59);
			obj51.Name = "Elements";
			obj51.Parent = obj13;
			obj52.IsDerived = true;
			obj52.Type = typeof(string);
			obj52.Name = "GreenName";
			obj52.Parent = obj13;
			obj53.IsDerived = true;
			obj53.Type = typeof(string);
			obj53.Name = "GreenConstructorParameters";
			obj53.Parent = obj13;
			obj54.IsDerived = true;
			obj54.Type = typeof(string);
			obj54.Name = "GreenConstructorArguments";
			obj54.Parent = obj13;
			obj55.IsDerived = true;
			obj55.Type = typeof(string);
			obj55.Name = "GreenUpdateParameters";
			obj55.Parent = obj13;
			obj56.IsDerived = true;
			obj56.Type = typeof(string);
			obj56.Name = "GreenUpdateArguments";
			obj56.Parent = obj13;
			obj57.IsDerived = true;
			obj57.Type = typeof(string);
			obj57.Name = "RedName";
			obj57.Parent = obj13;
			obj58.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj59.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			((__IModelObject)obj60).Children.Add((__IModelObject)obj74);
			obj60.IsContainment = true;
			obj60.Type = __MetaType.FromModelObject((__IModelObject)obj74);
			obj60.Name = "Binders";
			obj60.Parent = obj14;
			((__IModelObject)obj61).Children.Add((__IModelObject)obj75);
			obj61.Type = __MetaType.FromModelObject((__IModelObject)obj75);
			obj61.Name = "Name";
			obj61.Parent = obj14;
			obj62.Type = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment);
			obj62.Name = "Assignment";
			obj62.Parent = obj14;
			obj63.IsContainment = true;
			obj63.Type = __MetaType.FromModelObject((__IModelObject)obj15);
			obj63.Name = "Value";
			obj63.Parent = obj14;
			obj64.Type = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity);
			obj64.Name = "Multiplicity";
			obj64.Parent = obj14;
			obj65.IsDerived = true;
			obj65.Type = typeof(string);
			obj65.Name = "FieldName";
			obj65.Parent = obj14;
			obj66.IsDerived = true;
			obj66.Type = typeof(string);
			obj66.Name = "ParameterName";
			obj66.Parent = obj14;
			obj67.IsDerived = true;
			obj67.Type = typeof(string);
			obj67.Name = "PropertyName";
			obj67.Parent = obj14;
			obj68.IsDerived = true;
			obj68.Type = typeof(string);
			obj68.Name = "GreenFieldType";
			obj68.Parent = obj14;
			obj69.IsDerived = true;
			obj69.Type = typeof(string);
			obj69.Name = "GreenParameterValue";
			obj69.Parent = obj14;
			obj70.IsDerived = true;
			obj70.Type = typeof(string);
			obj70.Name = "GreenPropertyType";
			obj70.Parent = obj14;
			obj71.IsDerived = true;
			obj71.Type = typeof(string);
			obj71.Name = "GreenPropertyValue";
			obj71.Parent = obj14;
			((__IModelObject)obj72).Children.Add((__IModelObject)obj76);
			obj72.IsDerived = true;
			obj72.Type = __MetaType.FromModelObject((__IModelObject)obj76);
			obj72.Name = "GreenSyntaxNullCondition";
			obj72.Parent = obj14;
			((__IModelObject)obj73).Children.Add((__IModelObject)obj77);
			obj73.IsDerived = true;
			obj73.Type = __MetaType.FromModelObject((__IModelObject)obj77);
			obj73.Name = "GreenSyntaxCondition";
			obj73.Parent = obj14;
			obj74.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj75.InnerType = typeof(string);
			obj76.InnerType = typeof(string);
			obj77.InnerType = typeof(string);
			((__IModelObject)obj78).Children.Add((__IModelObject)obj81);
			obj78.IsContainment = true;
			obj78.Type = __MetaType.FromModelObject((__IModelObject)obj81);
			obj78.Name = "Binders";
			obj78.Parent = obj15;
			obj79.IsDerived = true;
			obj79.Type = typeof(string);
			obj79.Name = "GreenType";
			obj79.Parent = obj15;
			((__IModelObject)obj80).Children.Add((__IModelObject)obj82);
			obj80.IsDerived = true;
			obj80.Type = __MetaType.FromModelObject((__IModelObject)obj82);
			obj80.Name = "GreenSyntaxCondition";
			obj80.Parent = obj15;
			obj81.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj82.InnerType = typeof(string);
			obj83.Type = __MetaType.FromModelObject((__IModelObject)obj12);
			obj83.Name = "Rule";
			obj83.Parent = obj16;
			obj84.IsDerived = true;
			obj84.Type = typeof(string);
			obj84.Name = "GreenType";
			obj84.Parent = obj16;
			((__IModelObject)obj85).Children.Add((__IModelObject)obj86);
			obj85.IsDerived = true;
			obj85.Type = __MetaType.FromModelObject((__IModelObject)obj86);
			obj85.Name = "GreenSyntaxCondition";
			obj85.Parent = obj16;
			obj86.InnerType = typeof(string);
			obj87.Type = __MetaType.FromModelObject((__IModelObject)obj11);
			obj87.Name = "Token";
			obj87.Parent = obj17;
			obj88.IsDerived = true;
			obj88.Type = typeof(string);
			obj88.Name = "GreenType";
			obj88.Parent = obj17;
			((__IModelObject)obj89).Children.Add((__IModelObject)obj90);
			obj89.IsDerived = true;
			obj89.Type = __MetaType.FromModelObject((__IModelObject)obj90);
			obj89.Name = "GreenSyntaxCondition";
			obj89.Parent = obj17;
			obj90.InnerType = typeof(string);
			((__IModelObject)obj91).Children.Add((__IModelObject)obj94);
			obj91.IsContainment = true;
			obj91.Type = __MetaType.FromModelObject((__IModelObject)obj94);
			obj91.Name = "Tokens";
			obj91.Parent = obj18;
			obj92.IsDerived = true;
			obj92.Type = typeof(string);
			obj92.Name = "GreenType";
			obj92.Parent = obj18;
			((__IModelObject)obj93).Children.Add((__IModelObject)obj95);
			obj93.IsDerived = true;
			obj93.Type = __MetaType.FromModelObject((__IModelObject)obj95);
			obj93.Name = "GreenSyntaxCondition";
			obj93.Parent = obj18;
			obj94.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
			obj95.InnerType = typeof(string);
			obj96.IsDerived = true;
			obj96.Type = typeof(string);
			obj96.Name = "GreenType";
			obj96.Parent = obj19;
			((__IModelObject)obj97).Children.Add((__IModelObject)obj98);
			obj97.IsDerived = true;
			obj97.Type = __MetaType.FromModelObject((__IModelObject)obj98);
			obj97.Name = "GreenSyntaxCondition";
			obj97.Parent = obj19;
			obj98.InnerType = typeof(string);
			obj99.Type = typeof(bool);
			obj99.Name = "SeparatorFirst";
			obj99.Parent = obj20;
			obj100.Type = typeof(bool);
			obj100.Name = "RepeatedSeparatorFirst";
			obj100.Parent = obj20;
			((__IModelObject)obj101).Children.Add((__IModelObject)obj110);
			obj101.IsContainment = true;
			obj101.Type = __MetaType.FromModelObject((__IModelObject)obj110);
			obj101.Name = "FirstItems";
			obj101.Parent = obj20;
			((__IModelObject)obj102).Children.Add((__IModelObject)obj111);
			obj102.IsContainment = true;
			obj102.Type = __MetaType.FromModelObject((__IModelObject)obj111);
			obj102.Name = "FirstSeparators";
			obj102.Parent = obj20;
			obj103.IsContainment = true;
			obj103.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj103.Name = "RepeatedBlock";
			obj103.Parent = obj20;
			obj104.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj104.Name = "RepeatedItem";
			obj104.Parent = obj20;
			obj105.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj105.Name = "RepeatedSeparator";
			obj105.Parent = obj20;
			((__IModelObject)obj106).Children.Add((__IModelObject)obj112);
			obj106.IsContainment = true;
			obj106.Type = __MetaType.FromModelObject((__IModelObject)obj112);
			obj106.Name = "LastItems";
			obj106.Parent = obj20;
			((__IModelObject)obj107).Children.Add((__IModelObject)obj113);
			obj107.IsContainment = true;
			obj107.Type = __MetaType.FromModelObject((__IModelObject)obj113);
			obj107.Name = "LastSeparators";
			obj107.Parent = obj20;
			obj108.IsDerived = true;
			obj108.Type = typeof(string);
			obj108.Name = "GreenType";
			obj108.Parent = obj20;
			((__IModelObject)obj109).Children.Add((__IModelObject)obj114);
			obj109.IsDerived = true;
			obj109.Type = __MetaType.FromModelObject((__IModelObject)obj114);
			obj109.Name = "GreenSyntaxCondition";
			obj109.Parent = obj20;
			obj110.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj111.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj112.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj113.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj114.InnerType = typeof(string);
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
		public static __ModelProperty Alternative_Name => _Alternative_Name;
		public static __ModelProperty Alternative_Binders => _Alternative_Binders;
		public static __ModelProperty Alternative_Elements => _Alternative_Elements;
		public static __ModelProperty Alternative_GreenName => _Alternative_GreenName;
		public static __ModelProperty Alternative_GreenConstructorParameters => _Alternative_GreenConstructorParameters;
		public static __ModelProperty Alternative_GreenConstructorArguments => _Alternative_GreenConstructorArguments;
		public static __ModelProperty Alternative_GreenUpdateParameters => _Alternative_GreenUpdateParameters;
		public static __ModelProperty Alternative_GreenUpdateArguments => _Alternative_GreenUpdateArguments;
		public static __ModelProperty Alternative_RedName => _Alternative_RedName;
		public static __ModelClassInfo BinderInfo => __Impl.Binder_Impl.__Info.Instance;
		public static __ModelProperty Binder_TypeName => _Binder_TypeName;
		public static __ModelProperty Binder_Arguments => _Binder_Arguments;
		public static __ModelClassInfo BinderArgumentInfo => __Impl.BinderArgument_Impl.__Info.Instance;
		public static __ModelProperty BinderArgument_Name => _BinderArgument_Name;
		public static __ModelProperty BinderArgument_Values => _BinderArgument_Values;
		public static __ModelClassInfo ElementInfo => __Impl.Element_Impl.__Info.Instance;
		public static __ModelProperty Element_Binders => _Element_Binders;
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
		public static __ModelClassInfo ElementValueInfo => __Impl.ElementValue_Impl.__Info.Instance;
		public static __ModelProperty ElementValue_Binders => _ElementValue_Binders;
		public static __ModelProperty ElementValue_GreenType => _ElementValue_GreenType;
		public static __ModelProperty ElementValue_GreenSyntaxCondition => _ElementValue_GreenSyntaxCondition;
		public static __ModelClassInfo EofInfo => __Impl.Eof_Impl.__Info.Instance;
		public static __ModelProperty Eof_GreenType => _Eof_GreenType;
		public static __ModelProperty Eof_GreenSyntaxCondition => _Eof_GreenSyntaxCondition;
		public static __ModelClassInfo LanguageInfo => __Impl.Language_Impl.__Info.Instance;
		public static __ModelProperty Language_Name => _Language_Name;
		public static __ModelProperty Language_Namespace => _Language_Namespace;
		public static __ModelProperty Language_TokenKinds => _Language_TokenKinds;
		public static __ModelProperty Language_Tokens => _Language_Tokens;
		public static __ModelProperty Language_Rules => _Language_Rules;
		public static __ModelClassInfo RuleInfo => __Impl.Rule_Impl.__Info.Instance;
		public static __ModelProperty Rule_Binders => _Rule_Binders;
		public static __ModelProperty Rule_Name => _Rule_Name;
		public static __ModelProperty Rule_Alternatives => _Rule_Alternatives;
		public static __ModelProperty Rule_GreenName => _Rule_GreenName;
		public static __ModelClassInfo RuleRefInfo => __Impl.RuleRef_Impl.__Info.Instance;
		public static __ModelProperty RuleRef_Rule => _RuleRef_Rule;
		public static __ModelProperty RuleRef_GreenType => _RuleRef_GreenType;
		public static __ModelProperty RuleRef_GreenSyntaxCondition => _RuleRef_GreenSyntaxCondition;
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
		public static __ModelClassInfo TokenKindInfo => __Impl.TokenKind_Impl.__Info.Instance;
		public static __ModelProperty TokenKind_Name => _TokenKind_Name;
		public static __ModelProperty TokenKind_TypeName => _TokenKind_TypeName;
		public static __ModelClassInfo TokenRefInfo => __Impl.TokenRef_Impl.__Info.Instance;
		public static __ModelProperty TokenRef_Token => _TokenRef_Token;
		public static __ModelProperty TokenRef_GreenType => _TokenRef_GreenType;
		public static __ModelProperty TokenRef_GreenSyntaxCondition => _TokenRef_GreenSyntaxCondition;
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
		global::System.Collections.Generic.IList<Element> Elements { get; }
		string GreenConstructorArguments { get; }
		string GreenConstructorParameters { get; }
		string GreenName { get; }
		string GreenUpdateArguments { get; }
		string GreenUpdateParameters { get; }
		string Name { get; set; }
		string RedName { get; }
	
	}

	public interface Binder : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<BinderArgument> Arguments { get; }
		string TypeName { get; set; }
	
	}

	public interface BinderArgument : __IModelObjectCore
	{
		string Name { get; set; }
		global::System.Collections.Generic.IList<string> Values { get; }
	
	}

	public interface Element : __IModelObjectCore
	{
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment { get; set; }
		global::System.Collections.Generic.IList<Binder> Binders { get; }
		string FieldName { get; }
		string GreenFieldType { get; }
		string GreenParameterValue { get; }
		string GreenPropertyType { get; }
		string GreenPropertyValue { get; }
		string? GreenSyntaxCondition { get; }
		string? GreenSyntaxNullCondition { get; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
		string? Name { get; set; }
		string ParameterName { get; }
		string PropertyName { get; }
		ElementValue Value { get; set; }
	
	}

	public interface ElementValue : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Binder> Binders { get; }
		string? GreenSyntaxCondition { get; }
		string GreenType { get; }
	
	}

	public interface Eof : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		new string? GreenSyntaxCondition { get; }
		new string GreenType { get; }
	
	}

	public interface Language : __IModelObjectCore
	{
		string Name { get; set; }
		string Namespace { get; set; }
		global::System.Collections.Generic.IList<Rule> Rules { get; }
		global::System.Collections.Generic.IList<TokenKind> TokenKinds { get; }
		global::System.Collections.Generic.IList<Token> Tokens { get; }
	
	}

	public interface Rule : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Alternative> Alternatives { get; }
		global::System.Collections.Generic.IList<Binder> Binders { get; }
		string GreenName { get; }
		string Name { get; set; }
	
	}

	public interface RuleRef : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		new string? GreenSyntaxCondition { get; }
		new string GreenType { get; }
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
		/// Computation of the derived property ElementValue.GreenType
		/// </summary>
		string ElementValue_GreenType(ElementValue _this);
	
		/// <summary>
		/// Computation of the derived property ElementValue.GreenSyntaxCondition
		/// </summary>
		string? ElementValue_GreenSyntaxCondition(ElementValue _this);
	
		/// <summary>
		/// Computation of the derived property Eof.GreenType
		/// </summary>
		string Eof_GreenType(Eof _this);
	
		/// <summary>
		/// Computation of the derived property Eof.GreenSyntaxCondition
		/// </summary>
		string? Eof_GreenSyntaxCondition(Eof _this);
	
		/// <summary>
		/// Computation of the derived property Rule.GreenName
		/// </summary>
		string Rule_GreenName(Rule _this);
	
		/// <summary>
		/// Computation of the derived property RuleRef.GreenType
		/// </summary>
		string RuleRef_GreenType(RuleRef _this);
	
		/// <summary>
		/// Computation of the derived property RuleRef.GreenSyntaxCondition
		/// </summary>
		string? RuleRef_GreenSyntaxCondition(RuleRef _this);
	
		/// <summary>
		/// Computation of the derived property SeparatedList.GreenType
		/// </summary>
		string SeparatedList_GreenType(SeparatedList _this);
	
		/// <summary>
		/// Computation of the derived property SeparatedList.GreenSyntaxCondition
		/// </summary>
		string? SeparatedList_GreenSyntaxCondition(SeparatedList _this);
	
		/// <summary>
		/// Computation of the derived property TokenAlts.GreenType
		/// </summary>
		string TokenAlts_GreenType(TokenAlts _this);
	
		/// <summary>
		/// Computation of the derived property TokenAlts.GreenSyntaxCondition
		/// </summary>
		string? TokenAlts_GreenSyntaxCondition(TokenAlts _this);
	
		/// <summary>
		/// Computation of the derived property TokenRef.GreenType
		/// </summary>
		string TokenRef_GreenType(TokenRef _this);
	
		/// <summary>
		/// Computation of the derived property TokenRef.GreenSyntaxCondition
		/// </summary>
		string? TokenRef_GreenSyntaxCondition(TokenRef _this);
	
	
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
		/// Computation of the derived property ElementValue.GreenType
		/// </summary>
		public abstract string ElementValue_GreenType(ElementValue _this);
	
		/// <summary>
		/// Computation of the derived property ElementValue.GreenSyntaxCondition
		/// </summary>
		public abstract string? ElementValue_GreenSyntaxCondition(ElementValue _this);
	
		/// <summary>
		/// Computation of the derived property Eof.GreenType
		/// </summary>
		public abstract string Eof_GreenType(Eof _this);
	
		/// <summary>
		/// Computation of the derived property Eof.GreenSyntaxCondition
		/// </summary>
		public abstract string? Eof_GreenSyntaxCondition(Eof _this);
	
		/// <summary>
		/// Computation of the derived property Rule.GreenName
		/// </summary>
		public abstract string Rule_GreenName(Rule _this);
	
		/// <summary>
		/// Computation of the derived property RuleRef.GreenType
		/// </summary>
		public abstract string RuleRef_GreenType(RuleRef _this);
	
		/// <summary>
		/// Computation of the derived property RuleRef.GreenSyntaxCondition
		/// </summary>
		public abstract string? RuleRef_GreenSyntaxCondition(RuleRef _this);
	
		/// <summary>
		/// Computation of the derived property SeparatedList.GreenType
		/// </summary>
		public abstract string SeparatedList_GreenType(SeparatedList _this);
	
		/// <summary>
		/// Computation of the derived property SeparatedList.GreenSyntaxCondition
		/// </summary>
		public abstract string? SeparatedList_GreenSyntaxCondition(SeparatedList _this);
	
		/// <summary>
		/// Computation of the derived property TokenAlts.GreenType
		/// </summary>
		public abstract string TokenAlts_GreenType(TokenAlts _this);
	
		/// <summary>
		/// Computation of the derived property TokenAlts.GreenSyntaxCondition
		/// </summary>
		public abstract string? TokenAlts_GreenSyntaxCondition(TokenAlts _this);
	
		/// <summary>
		/// Computation of the derived property TokenRef.GreenType
		/// </summary>
		public abstract string TokenRef_GreenType(TokenRef _this);
	
		/// <summary>
		/// Computation of the derived property TokenRef.GreenSyntaxCondition
		/// </summary>
		public abstract string? TokenRef_GreenSyntaxCondition(TokenRef _this);
	
	
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
	
		public string Name
		{
			get => MGet<string>(Roslyn.Alternative_Name);
			set => MAdd<string>(Roslyn.Alternative_Name, value);
		}
	
		public string RedName
		{
			get => Roslyn.__CustomImpl.Alternative_RedName(this);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders, Roslyn.Alternative_Elements, Roslyn.Alternative_GreenConstructorArguments, Roslyn.Alternative_GreenConstructorParameters, Roslyn.Alternative_GreenName, Roslyn.Alternative_GreenUpdateArguments, Roslyn.Alternative_GreenUpdateParameters, Roslyn.Alternative_Name, Roslyn.Alternative_RedName);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders, Roslyn.Alternative_Elements, Roslyn.Alternative_GreenConstructorArguments, Roslyn.Alternative_GreenConstructorParameters, Roslyn.Alternative_GreenName, Roslyn.Alternative_GreenUpdateArguments, Roslyn.Alternative_GreenUpdateParameters, Roslyn.Alternative_Name, Roslyn.Alternative_RedName);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders, Roslyn.Alternative_Elements, Roslyn.Alternative_GreenConstructorArguments, Roslyn.Alternative_GreenConstructorParameters, Roslyn.Alternative_GreenName, Roslyn.Alternative_GreenUpdateArguments, Roslyn.Alternative_GreenUpdateParameters, Roslyn.Alternative_Name, Roslyn.Alternative_RedName);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Binders", Roslyn.Alternative_Binders);
				publicPropertiesByName.Add("Elements", Roslyn.Alternative_Elements);
				publicPropertiesByName.Add("GreenConstructorArguments", Roslyn.Alternative_GreenConstructorArguments);
				publicPropertiesByName.Add("GreenConstructorParameters", Roslyn.Alternative_GreenConstructorParameters);
				publicPropertiesByName.Add("GreenName", Roslyn.Alternative_GreenName);
				publicPropertiesByName.Add("GreenUpdateArguments", Roslyn.Alternative_GreenUpdateArguments);
				publicPropertiesByName.Add("GreenUpdateParameters", Roslyn.Alternative_GreenUpdateParameters);
				publicPropertiesByName.Add("Name", Roslyn.Alternative_Name);
				publicPropertiesByName.Add("RedName", Roslyn.Alternative_RedName);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Alternative_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_Elements, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_Elements, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Elements), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_GreenConstructorArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_GreenConstructorArguments, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_GreenConstructorArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_GreenConstructorParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_GreenConstructorParameters, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_GreenConstructorParameters), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_GreenName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_GreenName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_GreenName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_GreenUpdateArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_GreenUpdateArguments, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_GreenUpdateArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_GreenUpdateParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_GreenUpdateParameters, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_GreenUpdateParameters), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_RedName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_RedName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_RedName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Binder_Arguments, Roslyn.Binder_TypeName);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Binder_Arguments, Roslyn.Binder_TypeName);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Binder_Arguments, Roslyn.Binder_TypeName);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Arguments", Roslyn.Binder_Arguments);
				publicPropertiesByName.Add("TypeName", Roslyn.Binder_TypeName);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Binder_Arguments, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Binder_Arguments, __ImmutableArray.Create<__ModelProperty>(Roslyn.Binder_Arguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
		public string Name
		{
			get => MGet<string>(Roslyn.BinderArgument_Name);
			set => MAdd<string>(Roslyn.BinderArgument_Name, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_Name, Roslyn.BinderArgument_Values);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_Name, Roslyn.BinderArgument_Values);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_Name, Roslyn.BinderArgument_Values);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Name", Roslyn.BinderArgument_Name);
				publicPropertiesByName.Add("Values", Roslyn.BinderArgument_Values);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.BinderArgument_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.BinderArgument_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
		public ElementValue Value
		{
			get => MGet<ElementValue>(Roslyn.Element_Value);
			set => MAdd<ElementValue>(Roslyn.Element_Value, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment, Roslyn.Element_Binders, Roslyn.Element_FieldName, Roslyn.Element_GreenFieldType, Roslyn.Element_GreenParameterValue, Roslyn.Element_GreenPropertyType, Roslyn.Element_GreenPropertyValue, Roslyn.Element_GreenSyntaxCondition, Roslyn.Element_GreenSyntaxNullCondition, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_ParameterName, Roslyn.Element_PropertyName, Roslyn.Element_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment, Roslyn.Element_Binders, Roslyn.Element_FieldName, Roslyn.Element_GreenFieldType, Roslyn.Element_GreenParameterValue, Roslyn.Element_GreenPropertyType, Roslyn.Element_GreenPropertyValue, Roslyn.Element_GreenSyntaxCondition, Roslyn.Element_GreenSyntaxNullCondition, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_ParameterName, Roslyn.Element_PropertyName, Roslyn.Element_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment, Roslyn.Element_Binders, Roslyn.Element_FieldName, Roslyn.Element_GreenFieldType, Roslyn.Element_GreenParameterValue, Roslyn.Element_GreenPropertyType, Roslyn.Element_GreenPropertyValue, Roslyn.Element_GreenSyntaxCondition, Roslyn.Element_GreenSyntaxNullCondition, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_ParameterName, Roslyn.Element_PropertyName, Roslyn.Element_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Assignment", Roslyn.Element_Assignment);
				publicPropertiesByName.Add("Binders", Roslyn.Element_Binders);
				publicPropertiesByName.Add("FieldName", Roslyn.Element_FieldName);
				publicPropertiesByName.Add("GreenFieldType", Roslyn.Element_GreenFieldType);
				publicPropertiesByName.Add("GreenParameterValue", Roslyn.Element_GreenParameterValue);
				publicPropertiesByName.Add("GreenPropertyType", Roslyn.Element_GreenPropertyType);
				publicPropertiesByName.Add("GreenPropertyValue", Roslyn.Element_GreenPropertyValue);
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.Element_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenSyntaxNullCondition", Roslyn.Element_GreenSyntaxNullCondition);
				publicPropertiesByName.Add("Multiplicity", Roslyn.Element_Multiplicity);
				publicPropertiesByName.Add("Name", Roslyn.Element_Name);
				publicPropertiesByName.Add("ParameterName", Roslyn.Element_ParameterName);
				publicPropertiesByName.Add("PropertyName", Roslyn.Element_PropertyName);
				publicPropertiesByName.Add("Value", Roslyn.Element_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Element_Assignment, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Assignment, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_FieldName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_FieldName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_FieldName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenFieldType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenFieldType, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenFieldType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenParameterValue, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenParameterValue, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenParameterValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenPropertyType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenPropertyType, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenPropertyType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenPropertyValue, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenPropertyValue, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenPropertyValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_GreenSyntaxNullCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_GreenSyntaxNullCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_GreenSyntaxNullCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_ParameterName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_ParameterName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_ParameterName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_PropertyName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_PropertyName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_PropertyName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Value, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
		public string? GreenSyntaxCondition
		{
			get => Roslyn.__CustomImpl.ElementValue_GreenSyntaxCondition(this);
		}
	
		public string GreenType
		{
			get => Roslyn.__CustomImpl.ElementValue_GreenType(this);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.ElementValue_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.ElementValue_GreenType);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenSyntaxCondition, Roslyn.Eof_GreenType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenSyntaxCondition, Roslyn.Eof_GreenType, Roslyn.ElementValue_Binders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenSyntaxCondition, Roslyn.Eof_GreenType, Roslyn.ElementValue_Binders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.Eof_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.Eof_GreenType);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Eof_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Eof_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Eof_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Eof_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenSyntaxCondition)));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.Eof_GreenType)));
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Name, Roslyn.Language_Namespace, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Name, Roslyn.Language_Namespace, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Name, Roslyn.Language_Namespace, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Name", Roslyn.Language_Name);
				publicPropertiesByName.Add("Namespace", Roslyn.Language_Namespace);
				publicPropertiesByName.Add("Rules", Roslyn.Language_Rules);
				publicPropertiesByName.Add("TokenKinds", Roslyn.Language_TokenKinds);
				publicPropertiesByName.Add("Tokens", Roslyn.Language_Tokens);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Language_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_Namespace, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Namespace), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
		public string GreenName
		{
			get => Roslyn.__CustomImpl.Rule_GreenName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Roslyn.Rule_Name);
			set => MAdd<string>(Roslyn.Rule_Name, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Binders, Roslyn.Rule_GreenName, Roslyn.Rule_Name);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Binders, Roslyn.Rule_GreenName, Roslyn.Rule_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Binders, Roslyn.Rule_GreenName, Roslyn.Rule_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Roslyn.Rule_Alternatives);
				publicPropertiesByName.Add("Binders", Roslyn.Rule_Binders);
				publicPropertiesByName.Add("GreenName", Roslyn.Rule_GreenName);
				publicPropertiesByName.Add("Name", Roslyn.Rule_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Rule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Rule_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Rule_GreenName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_GreenName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_GreenName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Rule_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
		public Rule Rule
		{
			get => MGet<Rule>(Roslyn.RuleRef_Rule);
			set => MAdd<Rule>(Roslyn.RuleRef_Rule, value);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenSyntaxCondition, Roslyn.RuleRef_GreenType, Roslyn.RuleRef_Rule);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenSyntaxCondition, Roslyn.RuleRef_GreenType, Roslyn.RuleRef_Rule, Roslyn.ElementValue_Binders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenSyntaxCondition, Roslyn.RuleRef_GreenType, Roslyn.RuleRef_Rule, Roslyn.ElementValue_Binders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.RuleRef_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.RuleRef_GreenType);
				publicPropertiesByName.Add("Rule", Roslyn.RuleRef_Rule);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.RuleRef_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.RuleRef_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.RuleRef_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.RuleRef_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.RuleRef_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.RuleRef_Rule, __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenSyntaxCondition)));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_GreenType)));
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_FirstItems, Roslyn.SeparatedList_FirstSeparators, Roslyn.SeparatedList_GreenSyntaxCondition, Roslyn.SeparatedList_GreenType, Roslyn.SeparatedList_LastItems, Roslyn.SeparatedList_LastSeparators, Roslyn.SeparatedList_RepeatedBlock, Roslyn.SeparatedList_RepeatedItem, Roslyn.SeparatedList_RepeatedSeparator, Roslyn.SeparatedList_RepeatedSeparatorFirst, Roslyn.SeparatedList_SeparatorFirst);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_FirstItems, Roslyn.SeparatedList_FirstSeparators, Roslyn.SeparatedList_GreenSyntaxCondition, Roslyn.SeparatedList_GreenType, Roslyn.SeparatedList_LastItems, Roslyn.SeparatedList_LastSeparators, Roslyn.SeparatedList_RepeatedBlock, Roslyn.SeparatedList_RepeatedItem, Roslyn.SeparatedList_RepeatedSeparator, Roslyn.SeparatedList_RepeatedSeparatorFirst, Roslyn.SeparatedList_SeparatorFirst, Roslyn.ElementValue_Binders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_FirstItems, Roslyn.SeparatedList_FirstSeparators, Roslyn.SeparatedList_GreenSyntaxCondition, Roslyn.SeparatedList_GreenType, Roslyn.SeparatedList_LastItems, Roslyn.SeparatedList_LastSeparators, Roslyn.SeparatedList_RepeatedBlock, Roslyn.SeparatedList_RepeatedItem, Roslyn.SeparatedList_RepeatedSeparator, Roslyn.SeparatedList_RepeatedSeparatorFirst, Roslyn.SeparatedList_SeparatorFirst, Roslyn.ElementValue_Binders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FirstItems", Roslyn.SeparatedList_FirstItems);
				publicPropertiesByName.Add("FirstSeparators", Roslyn.SeparatedList_FirstSeparators);
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.SeparatedList_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.SeparatedList_GreenType);
				publicPropertiesByName.Add("LastItems", Roslyn.SeparatedList_LastItems);
				publicPropertiesByName.Add("LastSeparators", Roslyn.SeparatedList_LastSeparators);
				publicPropertiesByName.Add("RepeatedBlock", Roslyn.SeparatedList_RepeatedBlock);
				publicPropertiesByName.Add("RepeatedItem", Roslyn.SeparatedList_RepeatedItem);
				publicPropertiesByName.Add("RepeatedSeparator", Roslyn.SeparatedList_RepeatedSeparator);
				publicPropertiesByName.Add("RepeatedSeparatorFirst", Roslyn.SeparatedList_RepeatedSeparatorFirst);
				publicPropertiesByName.Add("SeparatorFirst", Roslyn.SeparatedList_SeparatorFirst);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.SeparatedList_FirstItems, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_FirstItems, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_FirstItems), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_FirstSeparators, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_FirstSeparators, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_FirstSeparators), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_LastItems, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_LastItems, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_LastItems), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_LastSeparators, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_LastSeparators, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_LastSeparators), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_RepeatedBlock, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_RepeatedBlock, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_RepeatedBlock), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_RepeatedItem, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_RepeatedItem, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_RepeatedItem), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_RepeatedSeparator, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_RepeatedSeparator, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_RepeatedSeparator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_RepeatedSeparatorFirst, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_RepeatedSeparatorFirst, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_RepeatedSeparatorFirst), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.SeparatedList_SeparatorFirst, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.SeparatedList_SeparatorFirst, __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_SeparatorFirst), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_GreenSyntaxCondition)));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.SeparatedList_GreenType)));
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
	
		public global::System.Collections.Generic.IList<TokenRef> Tokens
		{
			get => MGetCollection<TokenRef>(Roslyn.TokenAlts_Tokens);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenSyntaxCondition, Roslyn.TokenAlts_GreenType, Roslyn.TokenAlts_Tokens);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenSyntaxCondition, Roslyn.TokenAlts_GreenType, Roslyn.TokenAlts_Tokens, Roslyn.ElementValue_Binders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenSyntaxCondition, Roslyn.TokenAlts_GreenType, Roslyn.TokenAlts_Tokens, Roslyn.ElementValue_Binders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.TokenAlts_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.TokenAlts_GreenType);
				publicPropertiesByName.Add("Tokens", Roslyn.TokenAlts_Tokens);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.TokenAlts_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenAlts_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.TokenAlts_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenAlts_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.TokenAlts_Tokens, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenAlts_Tokens, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_Tokens), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenSyntaxCondition)));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_GreenType)));
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
	
		public Token Token
		{
			get => MGet<Token>(Roslyn.TokenRef_Token);
			set => MAdd<Token>(Roslyn.TokenRef_Token, value);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenSyntaxCondition, Roslyn.TokenRef_GreenType, Roslyn.TokenRef_Token);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenSyntaxCondition, Roslyn.TokenRef_GreenType, Roslyn.TokenRef_Token, Roslyn.ElementValue_Binders, Roslyn.ElementValue_GreenSyntaxCondition, Roslyn.ElementValue_GreenType);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenSyntaxCondition, Roslyn.TokenRef_GreenType, Roslyn.TokenRef_Token, Roslyn.ElementValue_Binders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("GreenSyntaxCondition", Roslyn.TokenRef_GreenSyntaxCondition);
				publicPropertiesByName.Add("GreenType", Roslyn.TokenRef_GreenType);
				publicPropertiesByName.Add("Token", Roslyn.TokenRef_Token);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.TokenRef_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenRef_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.TokenRef_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenRef_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.TokenRef_Token, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenRef_Token, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenSyntaxCondition)));
				modelPropertyInfos.Add(Roslyn.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_GreenType)));
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
