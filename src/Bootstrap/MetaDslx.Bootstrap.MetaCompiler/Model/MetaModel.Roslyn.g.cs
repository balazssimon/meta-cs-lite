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
		private static readonly __ModelProperty _BinderArgument_Value;
		private static readonly __ModelProperty _TokenKind_Name;
		private static readonly __ModelProperty _TokenKind_TypeName;
		private static readonly __ModelProperty _Language_Name;
		private static readonly __ModelProperty _Language_TokenKinds;
		private static readonly __ModelProperty _Language_Tokens;
		private static readonly __ModelProperty _Language_Rules;
		private static readonly __ModelProperty _Token_Binders;
		private static readonly __ModelProperty _Token_Name;
		private static readonly __ModelProperty _Token_TokenKind;
		private static readonly __ModelProperty _Token_IsTrivia;
		private static readonly __ModelProperty _Token_IsFixed;
		private static readonly __ModelProperty _Token_FixedText;
		private static readonly __ModelProperty _Rule_Binders;
		private static readonly __ModelProperty _Rule_Name;
		private static readonly __ModelProperty _Rule_Alternatives;
		private static readonly __ModelProperty _Alternative_Name;
		private static readonly __ModelProperty _Alternative_Binders;
		private static readonly __ModelProperty _Alternative_Elements;
		private static readonly __ModelProperty _Element_Binders;
		private static readonly __ModelProperty _Element_Name;
		private static readonly __ModelProperty _Element_Assignment;
		private static readonly __ModelProperty _Element_Value;
		private static readonly __ModelProperty _Element_Multiplicity;
		private static readonly __ModelProperty _ElementValue_Binders;
		private static readonly __ModelProperty _RuleRef_Rule;
		private static readonly __ModelProperty _TokenRef_Token;
		private static readonly __ModelProperty _TokenAlts_Tokens;
		private static readonly __ModelProperty _List_SeparatorFirst;
		private static readonly __ModelProperty _List_FirstItems;
		private static readonly __ModelProperty _List_FirstSeparators;
		private static readonly __ModelProperty _List_RepeatedBlock;
		private static readonly __ModelProperty _List_RepeatedItem;
		private static readonly __ModelProperty _List_RepeatedSeparator;
		private static readonly __ModelProperty _List_LastItems;
		private static readonly __ModelProperty _List_LastSeparators;
	
		static Roslyn()
		{
			_Alternative_Binders = new __ModelProperty(typeof(Alternative), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Alternative_Elements = new __ModelProperty(typeof(Alternative), "Elements", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Alternative_Name = new __ModelProperty(typeof(Alternative), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Binder_Arguments = new __ModelProperty(typeof(Binder), "Arguments", typeof(BinderArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Binder_TypeName = new __ModelProperty(typeof(Binder), "TypeName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_BinderArgument_Name = new __ModelProperty(typeof(BinderArgument), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_BinderArgument_Value = new __ModelProperty(typeof(BinderArgument), "Value", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Element_Assignment = new __ModelProperty(typeof(Element), "Assignment", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType, null);
			_Element_Binders = new __ModelProperty(typeof(Element), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Element_Multiplicity = new __ModelProperty(typeof(Element), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType, null);
			_Element_Name = new __ModelProperty(typeof(Element), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Element_Value = new __ModelProperty(typeof(Element), "Value", typeof(ElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_ElementValue_Binders = new __ModelProperty(typeof(ElementValue), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Language_Name = new __ModelProperty(typeof(Language), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Language_Rules = new __ModelProperty(typeof(Language), "Rules", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Language_TokenKinds = new __ModelProperty(typeof(Language), "TokenKinds", typeof(TokenKind), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Language_Tokens = new __ModelProperty(typeof(Language), "Tokens", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_List_FirstItems = new __ModelProperty(typeof(List), "FirstItems", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_List_FirstSeparators = new __ModelProperty(typeof(List), "FirstSeparators", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_List_LastItems = new __ModelProperty(typeof(List), "LastItems", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_List_LastSeparators = new __ModelProperty(typeof(List), "LastSeparators", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_List_RepeatedBlock = new __ModelProperty(typeof(List), "RepeatedBlock", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_List_RepeatedItem = new __ModelProperty(typeof(List), "RepeatedItem", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_List_RepeatedSeparator = new __ModelProperty(typeof(List), "RepeatedSeparator", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_List_SeparatorFirst = new __ModelProperty(typeof(List), "SeparatorFirst", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Rule_Alternatives = new __ModelProperty(typeof(Rule), "Alternatives", typeof(Alternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Rule_Binders = new __ModelProperty(typeof(Rule), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Rule_Name = new __ModelProperty(typeof(Rule), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_RuleRef_Rule = new __ModelProperty(typeof(RuleRef), "Rule", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Token_Binders = new __ModelProperty(typeof(Token), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Token_FixedText = new __ModelProperty(typeof(Token), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_IsFixed = new __ModelProperty(typeof(Token), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_IsTrivia = new __ModelProperty(typeof(Token), "IsTrivia", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_Name = new __ModelProperty(typeof(Token), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_TokenKind = new __ModelProperty(typeof(Token), "TokenKind", typeof(TokenKind), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_TokenAlts_Tokens = new __ModelProperty(typeof(TokenAlts), "Tokens", typeof(TokenRef), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_TokenKind_Name = new __ModelProperty(typeof(TokenKind), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_TokenKind_TypeName = new __ModelProperty(typeof(TokenKind), "TypeName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
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
	
			_classTypes = __ImmutableArray.Create<__MetaType>(typeof(Alternative), typeof(Binder), typeof(BinderArgument), typeof(Element), typeof(ElementValue), typeof(Eof), typeof(Language), typeof(List), typeof(Rule), typeof(RuleRef), typeof(Token), typeof(TokenAlts), typeof(TokenKind), typeof(TokenRef));
			_classInfos = __ImmutableArray.Create<__ModelClassInfo>(AlternativeInfo, BinderInfo, BinderArgumentInfo, ElementInfo, ElementValueInfo, EofInfo, LanguageInfo, ListInfo, RuleInfo, RuleRefInfo, TokenInfo, TokenAltsInfo, TokenKindInfo, TokenRefInfo);
			var classInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelClassInfo>();
			classInfosByType.Add(typeof(Alternative), AlternativeInfo);
			classInfosByType.Add(typeof(Binder), BinderInfo);
			classInfosByType.Add(typeof(BinderArgument), BinderArgumentInfo);
			classInfosByType.Add(typeof(Element), ElementInfo);
			classInfosByType.Add(typeof(ElementValue), ElementValueInfo);
			classInfosByType.Add(typeof(Eof), EofInfo);
			classInfosByType.Add(typeof(Language), LanguageInfo);
			classInfosByType.Add(typeof(List), ListInfo);
			classInfosByType.Add(typeof(Rule), RuleInfo);
			classInfosByType.Add(typeof(RuleRef), RuleRefInfo);
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
			classInfosByName.Add("List", ListInfo);
			classInfosByName.Add("Rule", RuleInfo);
			classInfosByName.Add("RuleRef", RuleRefInfo);
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
			var obj26 = f.MetaProperty();
			var obj27 = f.MetaProperty();
			var obj28 = f.MetaProperty();
			var obj29 = f.MetaProperty();
			var obj30 = f.MetaProperty();
			var obj31 = f.MetaProperty();
			var obj32 = f.MetaArrayType();
			var obj33 = f.MetaArrayType();
			var obj34 = f.MetaArrayType();
			var obj35 = f.MetaProperty();
			var obj36 = f.MetaProperty();
			var obj37 = f.MetaProperty();
			var obj38 = f.MetaProperty();
			var obj39 = f.MetaProperty();
			var obj40 = f.MetaProperty();
			var obj41 = f.MetaArrayType();
			var obj42 = f.MetaNullableType();
			var obj43 = f.MetaProperty();
			var obj44 = f.MetaProperty();
			var obj45 = f.MetaProperty();
			var obj46 = f.MetaArrayType();
			var obj47 = f.MetaArrayType();
			var obj48 = f.MetaProperty();
			var obj49 = f.MetaProperty();
			var obj50 = f.MetaProperty();
			var obj51 = f.MetaArrayType();
			var obj52 = f.MetaArrayType();
			var obj53 = f.MetaProperty();
			var obj54 = f.MetaProperty();
			var obj55 = f.MetaProperty();
			var obj56 = f.MetaProperty();
			var obj57 = f.MetaProperty();
			var obj58 = f.MetaArrayType();
			var obj59 = f.MetaProperty();
			var obj60 = f.MetaArrayType();
			var obj61 = f.MetaProperty();
			var obj62 = f.MetaProperty();
			var obj63 = f.MetaProperty();
			var obj64 = f.MetaArrayType();
			var obj65 = f.MetaProperty();
			var obj66 = f.MetaProperty();
			var obj67 = f.MetaProperty();
			var obj68 = f.MetaProperty();
			var obj69 = f.MetaProperty();
			var obj70 = f.MetaProperty();
			var obj71 = f.MetaProperty();
			var obj72 = f.MetaProperty();
			var obj73 = f.MetaArrayType();
			var obj74 = f.MetaArrayType();
			var obj75 = f.MetaArrayType();
			var obj76 = f.MetaArrayType();
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
			((__IModelObject)obj9).Children.Add((__IModelObject)obj26);
			((__IModelObject)obj9).Children.Add((__IModelObject)obj27);
			obj9.Properties.Add(obj26);
			obj9.Properties.Add(obj27);
			obj9.Declarations.Add(obj26);
			obj9.Declarations.Add(obj27);
			obj9.Name = "TokenKind";
			obj9.Parent = obj5;
			((__IModelObject)obj10).Children.Add((__IModelObject)obj28);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj29);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj30);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj31);
			obj10.Properties.Add(obj28);
			obj10.Properties.Add(obj29);
			obj10.Properties.Add(obj30);
			obj10.Properties.Add(obj31);
			obj10.Declarations.Add(obj28);
			obj10.Declarations.Add(obj29);
			obj10.Declarations.Add(obj30);
			obj10.Declarations.Add(obj31);
			obj10.Name = "Language";
			obj10.Parent = obj5;
			((__IModelObject)obj11).Children.Add((__IModelObject)obj35);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj36);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj37);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj38);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj39);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj40);
			obj11.Properties.Add(obj35);
			obj11.Properties.Add(obj36);
			obj11.Properties.Add(obj37);
			obj11.Properties.Add(obj38);
			obj11.Properties.Add(obj39);
			obj11.Properties.Add(obj40);
			obj11.Declarations.Add(obj35);
			obj11.Declarations.Add(obj36);
			obj11.Declarations.Add(obj37);
			obj11.Declarations.Add(obj38);
			obj11.Declarations.Add(obj39);
			obj11.Declarations.Add(obj40);
			obj11.Name = "Token";
			obj11.Parent = obj5;
			((__IModelObject)obj12).Children.Add((__IModelObject)obj43);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj44);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj45);
			obj12.Properties.Add(obj43);
			obj12.Properties.Add(obj44);
			obj12.Properties.Add(obj45);
			obj12.Declarations.Add(obj43);
			obj12.Declarations.Add(obj44);
			obj12.Declarations.Add(obj45);
			obj12.Name = "Rule";
			obj12.Parent = obj5;
			((__IModelObject)obj13).Children.Add((__IModelObject)obj48);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj49);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj50);
			obj13.Properties.Add(obj48);
			obj13.Properties.Add(obj49);
			obj13.Properties.Add(obj50);
			obj13.Declarations.Add(obj48);
			obj13.Declarations.Add(obj49);
			obj13.Declarations.Add(obj50);
			obj13.Name = "Alternative";
			obj13.Parent = obj5;
			((__IModelObject)obj14).Children.Add((__IModelObject)obj53);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj54);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj55);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj56);
			((__IModelObject)obj14).Children.Add((__IModelObject)obj57);
			obj14.Properties.Add(obj53);
			obj14.Properties.Add(obj54);
			obj14.Properties.Add(obj55);
			obj14.Properties.Add(obj56);
			obj14.Properties.Add(obj57);
			obj14.Declarations.Add(obj53);
			obj14.Declarations.Add(obj54);
			obj14.Declarations.Add(obj55);
			obj14.Declarations.Add(obj56);
			obj14.Declarations.Add(obj57);
			obj14.Name = "Element";
			obj14.Parent = obj5;
			((__IModelObject)obj15).Children.Add((__IModelObject)obj59);
			obj15.IsAbstract = true;
			obj15.Properties.Add(obj59);
			obj15.Declarations.Add(obj59);
			obj15.Name = "ElementValue";
			obj15.Parent = obj5;
			((__IModelObject)obj16).Children.Add((__IModelObject)obj61);
			obj16.BaseTypes.Add(obj15);
			obj16.Properties.Add(obj61);
			obj16.Declarations.Add(obj61);
			obj16.Name = "RuleRef";
			obj16.Parent = obj5;
			((__IModelObject)obj17).Children.Add((__IModelObject)obj62);
			obj17.BaseTypes.Add(obj15);
			obj17.Properties.Add(obj62);
			obj17.Declarations.Add(obj62);
			obj17.Name = "TokenRef";
			obj17.Parent = obj5;
			((__IModelObject)obj18).Children.Add((__IModelObject)obj63);
			obj18.BaseTypes.Add(obj15);
			obj18.Properties.Add(obj63);
			obj18.Declarations.Add(obj63);
			obj18.Name = "TokenAlts";
			obj18.Parent = obj5;
			obj19.BaseTypes.Add(obj15);
			obj19.Name = "Eof";
			obj19.Parent = obj5;
			((__IModelObject)obj20).Children.Add((__IModelObject)obj65);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj66);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj67);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj68);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj69);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj70);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj71);
			((__IModelObject)obj20).Children.Add((__IModelObject)obj72);
			obj20.BaseTypes.Add(obj15);
			obj20.Properties.Add(obj65);
			obj20.Properties.Add(obj66);
			obj20.Properties.Add(obj67);
			obj20.Properties.Add(obj68);
			obj20.Properties.Add(obj69);
			obj20.Properties.Add(obj70);
			obj20.Properties.Add(obj71);
			obj20.Properties.Add(obj72);
			obj20.Declarations.Add(obj65);
			obj20.Declarations.Add(obj66);
			obj20.Declarations.Add(obj67);
			obj20.Declarations.Add(obj68);
			obj20.Declarations.Add(obj69);
			obj20.Declarations.Add(obj70);
			obj20.Declarations.Add(obj71);
			obj20.Declarations.Add(obj72);
			obj20.Name = "List";
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
			obj25.Type = typeof(string);
			obj25.Name = "Value";
			obj25.Parent = obj8;
			obj26.Type = typeof(string);
			obj26.Name = "Name";
			obj26.Parent = obj9;
			obj27.Type = typeof(string);
			obj27.Name = "TypeName";
			obj27.Parent = obj9;
			obj28.Type = typeof(string);
			obj28.Name = "Name";
			obj28.Parent = obj10;
			((__IModelObject)obj29).Children.Add((__IModelObject)obj32);
			obj29.IsContainment = true;
			obj29.Type = __MetaType.FromModelObject((__IModelObject)obj32);
			obj29.Name = "TokenKinds";
			obj29.Parent = obj10;
			((__IModelObject)obj30).Children.Add((__IModelObject)obj33);
			obj30.IsContainment = true;
			obj30.Type = __MetaType.FromModelObject((__IModelObject)obj33);
			obj30.Name = "Tokens";
			obj30.Parent = obj10;
			((__IModelObject)obj31).Children.Add((__IModelObject)obj34);
			obj31.IsContainment = true;
			obj31.Type = __MetaType.FromModelObject((__IModelObject)obj34);
			obj31.Name = "Rules";
			obj31.Parent = obj10;
			obj32.ItemType = __MetaType.FromModelObject((__IModelObject)obj9);
			obj33.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			obj34.ItemType = __MetaType.FromModelObject((__IModelObject)obj12);
			((__IModelObject)obj35).Children.Add((__IModelObject)obj41);
			obj35.IsContainment = true;
			obj35.Type = __MetaType.FromModelObject((__IModelObject)obj41);
			obj35.Name = "Binders";
			obj35.Parent = obj11;
			obj36.Type = typeof(string);
			obj36.Name = "Name";
			obj36.Parent = obj11;
			obj37.Type = __MetaType.FromModelObject((__IModelObject)obj9);
			obj37.Name = "TokenKind";
			obj37.Parent = obj11;
			obj38.Type = typeof(bool);
			obj38.Name = "IsTrivia";
			obj38.Parent = obj11;
			obj39.Type = typeof(bool);
			obj39.Name = "IsFixed";
			obj39.Parent = obj11;
			((__IModelObject)obj40).Children.Add((__IModelObject)obj42);
			obj40.Type = __MetaType.FromModelObject((__IModelObject)obj42);
			obj40.Name = "FixedText";
			obj40.Parent = obj11;
			obj41.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj42.InnerType = typeof(string);
			((__IModelObject)obj43).Children.Add((__IModelObject)obj46);
			obj43.IsContainment = true;
			obj43.Type = __MetaType.FromModelObject((__IModelObject)obj46);
			obj43.Name = "Binders";
			obj43.Parent = obj12;
			obj44.Type = typeof(string);
			obj44.Name = "Name";
			obj44.Parent = obj12;
			((__IModelObject)obj45).Children.Add((__IModelObject)obj47);
			obj45.IsContainment = true;
			obj45.Type = __MetaType.FromModelObject((__IModelObject)obj47);
			obj45.Name = "Alternatives";
			obj45.Parent = obj12;
			obj46.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj47.ItemType = __MetaType.FromModelObject((__IModelObject)obj13);
			obj48.Type = typeof(string);
			obj48.Name = "Name";
			obj48.Parent = obj13;
			((__IModelObject)obj49).Children.Add((__IModelObject)obj51);
			obj49.IsContainment = true;
			obj49.Type = __MetaType.FromModelObject((__IModelObject)obj51);
			obj49.Name = "Binders";
			obj49.Parent = obj13;
			((__IModelObject)obj50).Children.Add((__IModelObject)obj52);
			obj50.IsContainment = true;
			obj50.Type = __MetaType.FromModelObject((__IModelObject)obj52);
			obj50.Name = "Elements";
			obj50.Parent = obj13;
			obj51.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj52.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			((__IModelObject)obj53).Children.Add((__IModelObject)obj58);
			obj53.IsContainment = true;
			obj53.Type = __MetaType.FromModelObject((__IModelObject)obj58);
			obj53.Name = "Binders";
			obj53.Parent = obj14;
			obj54.Type = typeof(string);
			obj54.Name = "Name";
			obj54.Parent = obj14;
			obj55.Type = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment);
			obj55.Name = "Assignment";
			obj55.Parent = obj14;
			obj56.IsContainment = true;
			obj56.Type = __MetaType.FromModelObject((__IModelObject)obj15);
			obj56.Name = "Value";
			obj56.Parent = obj14;
			obj57.Type = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity);
			obj57.Name = "Multiplicity";
			obj57.Parent = obj14;
			obj58.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			((__IModelObject)obj59).Children.Add((__IModelObject)obj60);
			obj59.IsContainment = true;
			obj59.Type = __MetaType.FromModelObject((__IModelObject)obj60);
			obj59.Name = "Binders";
			obj59.Parent = obj15;
			obj60.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj61.Type = __MetaType.FromModelObject((__IModelObject)obj12);
			obj61.Name = "Rule";
			obj61.Parent = obj16;
			obj62.Type = __MetaType.FromModelObject((__IModelObject)obj11);
			obj62.Name = "Token";
			obj62.Parent = obj17;
			((__IModelObject)obj63).Children.Add((__IModelObject)obj64);
			obj63.Type = __MetaType.FromModelObject((__IModelObject)obj64);
			obj63.Name = "Tokens";
			obj63.Parent = obj18;
			obj64.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
			obj65.Type = typeof(bool);
			obj65.Name = "SeparatorFirst";
			obj65.Parent = obj20;
			((__IModelObject)obj66).Children.Add((__IModelObject)obj73);
			obj66.Type = __MetaType.FromModelObject((__IModelObject)obj73);
			obj66.Name = "FirstItems";
			obj66.Parent = obj20;
			((__IModelObject)obj67).Children.Add((__IModelObject)obj74);
			obj67.Type = __MetaType.FromModelObject((__IModelObject)obj74);
			obj67.Name = "FirstSeparators";
			obj67.Parent = obj20;
			obj68.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj68.Name = "RepeatedBlock";
			obj68.Parent = obj20;
			obj69.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj69.Name = "RepeatedItem";
			obj69.Parent = obj20;
			obj70.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj70.Name = "RepeatedSeparator";
			obj70.Parent = obj20;
			((__IModelObject)obj71).Children.Add((__IModelObject)obj75);
			obj71.Type = __MetaType.FromModelObject((__IModelObject)obj75);
			obj71.Name = "LastItems";
			obj71.Parent = obj20;
			((__IModelObject)obj72).Children.Add((__IModelObject)obj76);
			obj72.Type = __MetaType.FromModelObject((__IModelObject)obj76);
			obj72.Name = "LastSeparators";
			obj72.Parent = obj20;
			obj73.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj74.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj75.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
			obj76.ItemType = __MetaType.FromModelObject((__IModelObject)obj14);
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
		public static __ModelClassInfo BinderInfo => __Impl.Binder_Impl.__Info.Instance;
		public static __ModelProperty Binder_TypeName => _Binder_TypeName;
		public static __ModelProperty Binder_Arguments => _Binder_Arguments;
		public static __ModelClassInfo BinderArgumentInfo => __Impl.BinderArgument_Impl.__Info.Instance;
		public static __ModelProperty BinderArgument_Name => _BinderArgument_Name;
		public static __ModelProperty BinderArgument_Value => _BinderArgument_Value;
		public static __ModelClassInfo ElementInfo => __Impl.Element_Impl.__Info.Instance;
		public static __ModelProperty Element_Binders => _Element_Binders;
		public static __ModelProperty Element_Name => _Element_Name;
		public static __ModelProperty Element_Assignment => _Element_Assignment;
		public static __ModelProperty Element_Value => _Element_Value;
		public static __ModelProperty Element_Multiplicity => _Element_Multiplicity;
		public static __ModelClassInfo ElementValueInfo => __Impl.ElementValue_Impl.__Info.Instance;
		public static __ModelProperty ElementValue_Binders => _ElementValue_Binders;
		public static __ModelClassInfo EofInfo => __Impl.Eof_Impl.__Info.Instance;
		public static __ModelClassInfo LanguageInfo => __Impl.Language_Impl.__Info.Instance;
		public static __ModelProperty Language_Name => _Language_Name;
		public static __ModelProperty Language_TokenKinds => _Language_TokenKinds;
		public static __ModelProperty Language_Tokens => _Language_Tokens;
		public static __ModelProperty Language_Rules => _Language_Rules;
		public static __ModelClassInfo ListInfo => __Impl.List_Impl.__Info.Instance;
		public static __ModelProperty List_SeparatorFirst => _List_SeparatorFirst;
		public static __ModelProperty List_FirstItems => _List_FirstItems;
		public static __ModelProperty List_FirstSeparators => _List_FirstSeparators;
		public static __ModelProperty List_RepeatedBlock => _List_RepeatedBlock;
		public static __ModelProperty List_RepeatedItem => _List_RepeatedItem;
		public static __ModelProperty List_RepeatedSeparator => _List_RepeatedSeparator;
		public static __ModelProperty List_LastItems => _List_LastItems;
		public static __ModelProperty List_LastSeparators => _List_LastSeparators;
		public static __ModelClassInfo RuleInfo => __Impl.Rule_Impl.__Info.Instance;
		public static __ModelProperty Rule_Binders => _Rule_Binders;
		public static __ModelProperty Rule_Name => _Rule_Name;
		public static __ModelProperty Rule_Alternatives => _Rule_Alternatives;
		public static __ModelClassInfo RuleRefInfo => __Impl.RuleRef_Impl.__Info.Instance;
		public static __ModelProperty RuleRef_Rule => _RuleRef_Rule;
		public static __ModelClassInfo TokenInfo => __Impl.Token_Impl.__Info.Instance;
		public static __ModelProperty Token_Binders => _Token_Binders;
		public static __ModelProperty Token_Name => _Token_Name;
		public static __ModelProperty Token_TokenKind => _Token_TokenKind;
		public static __ModelProperty Token_IsTrivia => _Token_IsTrivia;
		public static __ModelProperty Token_IsFixed => _Token_IsFixed;
		public static __ModelProperty Token_FixedText => _Token_FixedText;
		public static __ModelClassInfo TokenAltsInfo => __Impl.TokenAlts_Impl.__Info.Instance;
		public static __ModelProperty TokenAlts_Tokens => _TokenAlts_Tokens;
		public static __ModelClassInfo TokenKindInfo => __Impl.TokenKind_Impl.__Info.Instance;
		public static __ModelProperty TokenKind_Name => _TokenKind_Name;
		public static __ModelProperty TokenKind_TypeName => _TokenKind_TypeName;
		public static __ModelClassInfo TokenRefInfo => __Impl.TokenRef_Impl.__Info.Instance;
		public static __ModelProperty TokenRef_Token => _TokenRef_Token;
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
	
		public List List(string? id = null)
		{
			return (List)Roslyn.ListInfo.Create(Model, id)!;
		}
	
		public Rule Rule(string? id = null)
		{
			return (Rule)Roslyn.RuleInfo.Create(Model, id)!;
		}
	
		public RuleRef RuleRef(string? id = null)
		{
			return (RuleRef)Roslyn.RuleRefInfo.Create(Model, id)!;
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
	
		public List List(__Model model, string? id = null)
		{
			return (List)Roslyn.ListInfo.Create(model, id)!;
		}
	
		public Rule Rule(__Model model, string? id = null)
		{
			return (Rule)Roslyn.RuleInfo.Create(model, id)!;
		}
	
		public RuleRef RuleRef(__Model model, string? id = null)
		{
			return (RuleRef)Roslyn.RuleRefInfo.Create(model, id)!;
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
		string Name { get; set; }
	
	}

	public interface Binder : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<BinderArgument> Arguments { get; }
		string TypeName { get; set; }
	
	}

	public interface BinderArgument : __IModelObjectCore
	{
		string Name { get; set; }
		string Value { get; set; }
	
	}

	public interface Element : __IModelObjectCore
	{
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment { get; set; }
		global::System.Collections.Generic.IList<Binder> Binders { get; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
		string Name { get; set; }
		ElementValue Value { get; set; }
	
	}

	public interface ElementValue : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Binder> Binders { get; }
	
	}

	public interface Eof : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
	
	}

	public interface Language : __IModelObjectCore
	{
		string Name { get; set; }
		global::System.Collections.Generic.IList<Rule> Rules { get; }
		global::System.Collections.Generic.IList<TokenKind> TokenKinds { get; }
		global::System.Collections.Generic.IList<Token> Tokens { get; }
	
	}

	public interface List : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		global::System.Collections.Generic.IList<Element> FirstItems { get; }
		global::System.Collections.Generic.IList<Element> FirstSeparators { get; }
		global::System.Collections.Generic.IList<Element> LastItems { get; }
		global::System.Collections.Generic.IList<Element> LastSeparators { get; }
		Element RepeatedBlock { get; set; }
		Element RepeatedItem { get; set; }
		Element RepeatedSeparator { get; set; }
		bool SeparatorFirst { get; set; }
	
	}

	public interface Rule : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Alternative> Alternatives { get; }
		global::System.Collections.Generic.IList<Binder> Binders { get; }
		string Name { get; set; }
	
	}

	public interface RuleRef : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		Rule Rule { get; set; }
	
	}

	public interface Token : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Binder> Binders { get; }
		string? FixedText { get; set; }
		bool IsFixed { get; set; }
		bool IsTrivia { get; set; }
		string Name { get; set; }
		TokenKind TokenKind { get; set; }
	
	}

	public interface TokenAlts : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		global::System.Collections.Generic.IList<TokenRef> Tokens { get; }
	
	}

	public interface TokenKind : __IModelObjectCore
	{
		string Name { get; set; }
		string TypeName { get; set; }
	
	}

	public interface TokenRef : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
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
		/// Constructor for the class List
		/// </summary>
		void List(List _this);
	
		/// <summary>
		/// Constructor for the class Rule
		/// </summary>
		void Rule(Rule _this);
	
		/// <summary>
		/// Constructor for the class RuleRef
		/// </summary>
		void RuleRef(RuleRef _this);
	
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
		/// Constructor for the class List
		/// </summary>
		public virtual void List(List _this)
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
	
		public string Name
		{
			get => MGet<string>(Roslyn.Alternative_Name);
			set => MAdd<string>(Roslyn.Alternative_Name, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders, Roslyn.Alternative_Elements, Roslyn.Alternative_Name);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders, Roslyn.Alternative_Elements, Roslyn.Alternative_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders, Roslyn.Alternative_Elements, Roslyn.Alternative_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Binders", Roslyn.Alternative_Binders);
				publicPropertiesByName.Add("Elements", Roslyn.Alternative_Elements);
				publicPropertiesByName.Add("Name", Roslyn.Alternative_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Alternative_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_Elements, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_Elements, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Elements), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Alternative_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
			Roslyn.__CustomImpl.BinderArgument(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string Name
		{
			get => MGet<string>(Roslyn.BinderArgument_Name);
			set => MAdd<string>(Roslyn.BinderArgument_Name, value);
		}
	
		public string Value
		{
			get => MGet<string>(Roslyn.BinderArgument_Value);
			set => MAdd<string>(Roslyn.BinderArgument_Value, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_Name, Roslyn.BinderArgument_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_Name, Roslyn.BinderArgument_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_Name, Roslyn.BinderArgument_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Name", Roslyn.BinderArgument_Name);
				publicPropertiesByName.Add("Value", Roslyn.BinderArgument_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.BinderArgument_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.BinderArgument_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.BinderArgument_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.BinderArgument_Value, __ImmutableArray.Create<__ModelProperty>(Roslyn.BinderArgument_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Roslyn.Element_Multiplicity);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Roslyn.Element_Multiplicity, value);
		}
	
		public string Name
		{
			get => MGet<string>(Roslyn.Element_Name);
			set => MAdd<string>(Roslyn.Element_Name, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment, Roslyn.Element_Binders, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment, Roslyn.Element_Binders, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment, Roslyn.Element_Binders, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Assignment", Roslyn.Element_Assignment);
				publicPropertiesByName.Add("Binders", Roslyn.Element_Binders);
				publicPropertiesByName.Add("Multiplicity", Roslyn.Element_Multiplicity);
				publicPropertiesByName.Add("Name", Roslyn.Element_Name);
				publicPropertiesByName.Add("Value", Roslyn.Element_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Element_Assignment, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Assignment, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Name, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Name, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Name, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Name", Roslyn.Language_Name);
				publicPropertiesByName.Add("Rules", Roslyn.Language_Rules);
				publicPropertiesByName.Add("TokenKinds", Roslyn.Language_TokenKinds);
				publicPropertiesByName.Add("Tokens", Roslyn.Language_Tokens);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Language_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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

	internal class List_Impl : __MetaModelObject, List
	{
		private List_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.List_FirstItems, new global::MetaDslx.Modeling.ModelObjectList<Element>(this, __Info.Instance.GetSlot(Roslyn.List_FirstItems)!));
			((__IModelObject)this).Init(Roslyn.List_FirstSeparators, new global::MetaDslx.Modeling.ModelObjectList<Element>(this, __Info.Instance.GetSlot(Roslyn.List_FirstSeparators)!));
			((__IModelObject)this).Init(Roslyn.List_LastItems, new global::MetaDslx.Modeling.ModelObjectList<Element>(this, __Info.Instance.GetSlot(Roslyn.List_LastItems)!));
			((__IModelObject)this).Init(Roslyn.List_LastSeparators, new global::MetaDslx.Modeling.ModelObjectList<Element>(this, __Info.Instance.GetSlot(Roslyn.List_LastSeparators)!));
			((__IModelObject)this).Init(Roslyn.ElementValue_Binders, new global::MetaDslx.Modeling.ModelObjectList<Binder>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Binders)!));
			Roslyn.__CustomImpl.ElementValue(this);
			Roslyn.__CustomImpl.List(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Element> FirstItems
		{
			get => MGetCollection<Element>(Roslyn.List_FirstItems);
		}
	
		public global::System.Collections.Generic.IList<Element> FirstSeparators
		{
			get => MGetCollection<Element>(Roslyn.List_FirstSeparators);
		}
	
		public global::System.Collections.Generic.IList<Element> LastItems
		{
			get => MGetCollection<Element>(Roslyn.List_LastItems);
		}
	
		public global::System.Collections.Generic.IList<Element> LastSeparators
		{
			get => MGetCollection<Element>(Roslyn.List_LastSeparators);
		}
	
		public Element RepeatedBlock
		{
			get => MGet<Element>(Roslyn.List_RepeatedBlock);
			set => MAdd<Element>(Roslyn.List_RepeatedBlock, value);
		}
	
		public Element RepeatedItem
		{
			get => MGet<Element>(Roslyn.List_RepeatedItem);
			set => MAdd<Element>(Roslyn.List_RepeatedItem, value);
		}
	
		public Element RepeatedSeparator
		{
			get => MGet<Element>(Roslyn.List_RepeatedSeparator);
			set => MAdd<Element>(Roslyn.List_RepeatedSeparator, value);
		}
	
		public bool SeparatorFirst
		{
			get => MGet<bool>(Roslyn.List_SeparatorFirst);
			set => MAdd<bool>(Roslyn.List_SeparatorFirst, value);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.List_FirstItems, Roslyn.List_FirstSeparators, Roslyn.List_LastItems, Roslyn.List_LastSeparators, Roslyn.List_RepeatedBlock, Roslyn.List_RepeatedItem, Roslyn.List_RepeatedSeparator, Roslyn.List_SeparatorFirst);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.List_FirstItems, Roslyn.List_FirstSeparators, Roslyn.List_LastItems, Roslyn.List_LastSeparators, Roslyn.List_RepeatedBlock, Roslyn.List_RepeatedItem, Roslyn.List_RepeatedSeparator, Roslyn.List_SeparatorFirst, Roslyn.ElementValue_Binders);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.List_FirstItems, Roslyn.List_FirstSeparators, Roslyn.List_LastItems, Roslyn.List_LastSeparators, Roslyn.List_RepeatedBlock, Roslyn.List_RepeatedItem, Roslyn.List_RepeatedSeparator, Roslyn.List_SeparatorFirst, Roslyn.ElementValue_Binders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FirstItems", Roslyn.List_FirstItems);
				publicPropertiesByName.Add("FirstSeparators", Roslyn.List_FirstSeparators);
				publicPropertiesByName.Add("LastItems", Roslyn.List_LastItems);
				publicPropertiesByName.Add("LastSeparators", Roslyn.List_LastSeparators);
				publicPropertiesByName.Add("RepeatedBlock", Roslyn.List_RepeatedBlock);
				publicPropertiesByName.Add("RepeatedItem", Roslyn.List_RepeatedItem);
				publicPropertiesByName.Add("RepeatedSeparator", Roslyn.List_RepeatedSeparator);
				publicPropertiesByName.Add("SeparatorFirst", Roslyn.List_SeparatorFirst);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.List_FirstItems, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.List_FirstItems, __ImmutableArray.Create<__ModelProperty>(Roslyn.List_FirstItems), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.List_FirstSeparators, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.List_FirstSeparators, __ImmutableArray.Create<__ModelProperty>(Roslyn.List_FirstSeparators), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.List_LastItems, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.List_LastItems, __ImmutableArray.Create<__ModelProperty>(Roslyn.List_LastItems), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.List_LastSeparators, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.List_LastSeparators, __ImmutableArray.Create<__ModelProperty>(Roslyn.List_LastSeparators), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.List_RepeatedBlock, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.List_RepeatedBlock, __ImmutableArray.Create<__ModelProperty>(Roslyn.List_RepeatedBlock), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.List_RepeatedItem, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.List_RepeatedItem, __ImmutableArray.Create<__ModelProperty>(Roslyn.List_RepeatedItem), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.List_RepeatedSeparator, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.List_RepeatedSeparator, __ImmutableArray.Create<__ModelProperty>(Roslyn.List_RepeatedSeparator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.List_SeparatorFirst, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.List_SeparatorFirst, __ImmutableArray.Create<__ModelProperty>(Roslyn.List_SeparatorFirst), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(List);
	
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
				var result = new List_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.ListInfo";
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Binders, Roslyn.Rule_Name);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Binders, Roslyn.Rule_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Binders, Roslyn.Rule_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Roslyn.Rule_Alternatives);
				publicPropertiesByName.Add("Binders", Roslyn.Rule_Binders);
				publicPropertiesByName.Add("Name", Roslyn.Rule_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Rule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Rule_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
		public Rule Rule
		{
			get => MGet<Rule>(Roslyn.RuleRef_Rule);
			set => MAdd<Rule>(Roslyn.RuleRef_Rule, value);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_Rule);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_Rule, Roslyn.ElementValue_Binders);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_Rule, Roslyn.ElementValue_Binders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Rule", Roslyn.RuleRef_Rule);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.RuleRef_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.RuleRef_Rule, __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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

	internal class Token_Impl : __MetaModelObject, Token
	{
		private Token_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.Token_Binders, new global::MetaDslx.Modeling.ModelObjectList<Binder>(this, __Info.Instance.GetSlot(Roslyn.Token_Binders)!));
			Roslyn.__CustomImpl.Token(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.Token_Binders);
		}
	
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_Binders, Roslyn.Token_FixedText, Roslyn.Token_IsFixed, Roslyn.Token_IsTrivia, Roslyn.Token_Name, Roslyn.Token_TokenKind);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_Binders, Roslyn.Token_FixedText, Roslyn.Token_IsFixed, Roslyn.Token_IsTrivia, Roslyn.Token_Name, Roslyn.Token_TokenKind);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_Binders, Roslyn.Token_FixedText, Roslyn.Token_IsFixed, Roslyn.Token_IsTrivia, Roslyn.Token_Name, Roslyn.Token_TokenKind);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Binders", Roslyn.Token_Binders);
				publicPropertiesByName.Add("FixedText", Roslyn.Token_FixedText);
				publicPropertiesByName.Add("IsFixed", Roslyn.Token_IsFixed);
				publicPropertiesByName.Add("IsTrivia", Roslyn.Token_IsTrivia);
				publicPropertiesByName.Add("Name", Roslyn.Token_Name);
				publicPropertiesByName.Add("TokenKind", Roslyn.Token_TokenKind);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Token_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
		public global::System.Collections.Generic.IList<TokenRef> Tokens
		{
			get => MGetCollection<TokenRef>(Roslyn.TokenAlts_Tokens);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_Tokens);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_Tokens, Roslyn.ElementValue_Binders);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_Tokens, Roslyn.ElementValue_Binders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Tokens", Roslyn.TokenAlts_Tokens);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.TokenAlts_Tokens, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenAlts_Tokens, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_Tokens), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
	
		public Token Token
		{
			get => MGet<Token>(Roslyn.TokenRef_Token);
			set => MAdd<Token>(Roslyn.TokenRef_Token, value);
		}
	
		public global::System.Collections.Generic.IList<Binder> Binders
		{
			get => MGetCollection<Binder>(Roslyn.ElementValue_Binders);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_Token);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_Token, Roslyn.ElementValue_Binders);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_Token, Roslyn.ElementValue_Binders);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Token", Roslyn.TokenRef_Token);
				publicPropertiesByName.Add("Binders", Roslyn.ElementValue_Binders);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.TokenRef_Token, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenRef_Token, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Binders, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
