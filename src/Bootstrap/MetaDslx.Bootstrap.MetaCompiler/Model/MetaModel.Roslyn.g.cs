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
	
		private static readonly __ModelProperty _Annotation_FullName;
		private static readonly __ModelProperty _Annotation_Arguments;
		private static readonly __ModelProperty _AnnotationArgument_Name;
		private static readonly __ModelProperty _AnnotationArgument_Value;
		private static readonly __ModelProperty _Language_Annotations;
		private static readonly __ModelProperty _Language_Name;
		private static readonly __ModelProperty _Language_TokenKinds;
		private static readonly __ModelProperty _Language_Tokens;
		private static readonly __ModelProperty _Language_Rules;
		private static readonly __ModelProperty _Token_Annotations;
		private static readonly __ModelProperty _Token_Name;
		private static readonly __ModelProperty _Token_TokenKind;
		private static readonly __ModelProperty _Token_IsTrivia;
		private static readonly __ModelProperty _Token_IsFixed;
		private static readonly __ModelProperty _Token_FixedText;
		private static readonly __ModelProperty _Rule_Annotations;
		private static readonly __ModelProperty _Rule_Name;
		private static readonly __ModelProperty _Rule_Alternatives;
		private static readonly __ModelProperty _Alternative_Name;
		private static readonly __ModelProperty _Alternative_Annotations;
		private static readonly __ModelProperty _Alternative_Elements;
		private static readonly __ModelProperty _Element_Annotations;
		private static readonly __ModelProperty _Element_Name;
		private static readonly __ModelProperty _Element_Assignment;
		private static readonly __ModelProperty _Element_Value;
		private static readonly __ModelProperty _Element_Multiplicity;
		private static readonly __ModelProperty _ElementValue_Annotations;
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
			_Alternative_Annotations = new __ModelProperty(typeof(Alternative), "Annotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Alternative_Elements = new __ModelProperty(typeof(Alternative), "Elements", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Alternative_Name = new __ModelProperty(typeof(Alternative), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Annotation_Arguments = new __ModelProperty(typeof(Annotation), "Arguments", typeof(AnnotationArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Annotation_FullName = new __ModelProperty(typeof(Annotation), "FullName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_AnnotationArgument_Name = new __ModelProperty(typeof(AnnotationArgument), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_AnnotationArgument_Value = new __ModelProperty(typeof(AnnotationArgument), "Value", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Element_Annotations = new __ModelProperty(typeof(Element), "Annotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Element_Assignment = new __ModelProperty(typeof(Element), "Assignment", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType, null);
			_Element_Multiplicity = new __ModelProperty(typeof(Element), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType, null);
			_Element_Name = new __ModelProperty(typeof(Element), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Element_Value = new __ModelProperty(typeof(Element), "Value", typeof(ElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.SingleItem, null);
			_ElementValue_Annotations = new __ModelProperty(typeof(ElementValue), "Annotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Language_Annotations = new __ModelProperty(typeof(Language), "Annotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Language_Name = new __ModelProperty(typeof(Language), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Language_Rules = new __ModelProperty(typeof(Language), "Rules", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Language_TokenKinds = new __ModelProperty(typeof(Language), "TokenKinds", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, null);
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
			_Rule_Annotations = new __ModelProperty(typeof(Rule), "Annotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Rule_Name = new __ModelProperty(typeof(Rule), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_RuleRef_Rule = new __ModelProperty(typeof(RuleRef), "Rule", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_Token_Annotations = new __ModelProperty(typeof(Token), "Annotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_Token_FixedText = new __ModelProperty(typeof(Token), "FixedText", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_IsFixed = new __ModelProperty(typeof(Token), "IsFixed", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_IsTrivia = new __ModelProperty(typeof(Token), "IsTrivia", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_Name = new __ModelProperty(typeof(Token), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_Token_TokenKind = new __ModelProperty(typeof(Token), "TokenKind", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_TokenAlts_Tokens = new __ModelProperty(typeof(TokenAlts), "Tokens", typeof(TokenRef), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
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
	
			_classTypes = __ImmutableArray.Create<__MetaType>(typeof(Alternative), typeof(Annotation), typeof(AnnotationArgument), typeof(Element), typeof(ElementValue), typeof(Eof), typeof(Language), typeof(List), typeof(Rule), typeof(RuleRef), typeof(Token), typeof(TokenAlts), typeof(TokenRef));
			_classInfos = __ImmutableArray.Create<__ModelClassInfo>(AlternativeInfo, AnnotationInfo, AnnotationArgumentInfo, ElementInfo, ElementValueInfo, EofInfo, LanguageInfo, ListInfo, RuleInfo, RuleRefInfo, TokenInfo, TokenAltsInfo, TokenRefInfo);
			var classInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelClassInfo>();
			classInfosByType.Add(typeof(Alternative), AlternativeInfo);
			classInfosByType.Add(typeof(Annotation), AnnotationInfo);
			classInfosByType.Add(typeof(AnnotationArgument), AnnotationArgumentInfo);
			classInfosByType.Add(typeof(Element), ElementInfo);
			classInfosByType.Add(typeof(ElementValue), ElementValueInfo);
			classInfosByType.Add(typeof(Eof), EofInfo);
			classInfosByType.Add(typeof(Language), LanguageInfo);
			classInfosByType.Add(typeof(List), ListInfo);
			classInfosByType.Add(typeof(Rule), RuleInfo);
			classInfosByType.Add(typeof(RuleRef), RuleRefInfo);
			classInfosByType.Add(typeof(Token), TokenInfo);
			classInfosByType.Add(typeof(TokenAlts), TokenAltsInfo);
			classInfosByType.Add(typeof(TokenRef), TokenRefInfo);
			_classInfosByType = classInfosByType.ToImmutable();
			var classInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelClassInfo>();
			classInfosByName.Add("Alternative", AlternativeInfo);
			classInfosByName.Add("Annotation", AnnotationInfo);
			classInfosByName.Add("AnnotationArgument", AnnotationArgumentInfo);
			classInfosByName.Add("Element", ElementInfo);
			classInfosByName.Add("ElementValue", ElementValueInfo);
			classInfosByName.Add("Eof", EofInfo);
			classInfosByName.Add("Language", LanguageInfo);
			classInfosByName.Add("List", ListInfo);
			classInfosByName.Add("Rule", RuleInfo);
			classInfosByName.Add("RuleRef", RuleRefInfo);
			classInfosByName.Add("Token", TokenInfo);
			classInfosByName.Add("TokenAlts", TokenAltsInfo);
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
			var obj20 = f.MetaProperty();
			var obj21 = f.MetaProperty();
			var obj22 = f.MetaArrayType();
			var obj23 = f.MetaProperty();
			var obj24 = f.MetaProperty();
			var obj25 = f.MetaProperty();
			var obj26 = f.MetaProperty();
			var obj27 = f.MetaProperty();
			var obj28 = f.MetaProperty();
			var obj29 = f.MetaProperty();
			var obj30 = f.MetaArrayType();
			var obj31 = f.MetaArrayType();
			var obj32 = f.MetaArrayType();
			var obj33 = f.MetaArrayType();
			var obj34 = f.MetaProperty();
			var obj35 = f.MetaProperty();
			var obj36 = f.MetaProperty();
			var obj37 = f.MetaProperty();
			var obj38 = f.MetaProperty();
			var obj39 = f.MetaProperty();
			var obj40 = f.MetaArrayType();
			var obj41 = f.MetaNullableType();
			var obj42 = f.MetaProperty();
			var obj43 = f.MetaProperty();
			var obj44 = f.MetaProperty();
			var obj45 = f.MetaArrayType();
			var obj46 = f.MetaArrayType();
			var obj47 = f.MetaProperty();
			var obj48 = f.MetaProperty();
			var obj49 = f.MetaProperty();
			var obj50 = f.MetaArrayType();
			var obj51 = f.MetaArrayType();
			var obj52 = f.MetaProperty();
			var obj53 = f.MetaProperty();
			var obj54 = f.MetaProperty();
			var obj55 = f.MetaProperty();
			var obj56 = f.MetaProperty();
			var obj57 = f.MetaArrayType();
			var obj58 = f.MetaProperty();
			var obj59 = f.MetaArrayType();
			var obj60 = f.MetaProperty();
			var obj61 = f.MetaProperty();
			var obj62 = f.MetaProperty();
			var obj63 = f.MetaArrayType();
			var obj64 = f.MetaProperty();
			var obj65 = f.MetaProperty();
			var obj66 = f.MetaProperty();
			var obj67 = f.MetaProperty();
			var obj68 = f.MetaProperty();
			var obj69 = f.MetaProperty();
			var obj70 = f.MetaProperty();
			var obj71 = f.MetaProperty();
			var obj72 = f.MetaArrayType();
			var obj73 = f.MetaArrayType();
			var obj74 = f.MetaArrayType();
			var obj75 = f.MetaArrayType();
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
			obj5.Name = "Roslyn";
			obj5.Parent = obj4;
			obj6.Name = "Roslyn";
			obj6.Parent = obj5;
			((__IModelObject)obj7).Children.Add((__IModelObject)obj20);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj21);
			obj7.Properties.Add(obj20);
			obj7.Properties.Add(obj21);
			obj7.Declarations.Add(obj20);
			obj7.Declarations.Add(obj21);
			obj7.Name = "Annotation";
			obj7.Parent = obj5;
			((__IModelObject)obj8).Children.Add((__IModelObject)obj23);
			((__IModelObject)obj8).Children.Add((__IModelObject)obj24);
			obj8.Properties.Add(obj23);
			obj8.Properties.Add(obj24);
			obj8.Declarations.Add(obj23);
			obj8.Declarations.Add(obj24);
			obj8.Name = "AnnotationArgument";
			obj8.Parent = obj5;
			((__IModelObject)obj9).Children.Add((__IModelObject)obj25);
			((__IModelObject)obj9).Children.Add((__IModelObject)obj26);
			((__IModelObject)obj9).Children.Add((__IModelObject)obj27);
			((__IModelObject)obj9).Children.Add((__IModelObject)obj28);
			((__IModelObject)obj9).Children.Add((__IModelObject)obj29);
			obj9.Properties.Add(obj25);
			obj9.Properties.Add(obj26);
			obj9.Properties.Add(obj27);
			obj9.Properties.Add(obj28);
			obj9.Properties.Add(obj29);
			obj9.Declarations.Add(obj25);
			obj9.Declarations.Add(obj26);
			obj9.Declarations.Add(obj27);
			obj9.Declarations.Add(obj28);
			obj9.Declarations.Add(obj29);
			obj9.Name = "Language";
			obj9.Parent = obj5;
			((__IModelObject)obj10).Children.Add((__IModelObject)obj34);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj35);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj36);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj37);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj38);
			((__IModelObject)obj10).Children.Add((__IModelObject)obj39);
			obj10.Properties.Add(obj34);
			obj10.Properties.Add(obj35);
			obj10.Properties.Add(obj36);
			obj10.Properties.Add(obj37);
			obj10.Properties.Add(obj38);
			obj10.Properties.Add(obj39);
			obj10.Declarations.Add(obj34);
			obj10.Declarations.Add(obj35);
			obj10.Declarations.Add(obj36);
			obj10.Declarations.Add(obj37);
			obj10.Declarations.Add(obj38);
			obj10.Declarations.Add(obj39);
			obj10.Name = "Token";
			obj10.Parent = obj5;
			((__IModelObject)obj11).Children.Add((__IModelObject)obj42);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj43);
			((__IModelObject)obj11).Children.Add((__IModelObject)obj44);
			obj11.Properties.Add(obj42);
			obj11.Properties.Add(obj43);
			obj11.Properties.Add(obj44);
			obj11.Declarations.Add(obj42);
			obj11.Declarations.Add(obj43);
			obj11.Declarations.Add(obj44);
			obj11.Name = "Rule";
			obj11.Parent = obj5;
			((__IModelObject)obj12).Children.Add((__IModelObject)obj47);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj48);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj49);
			obj12.Properties.Add(obj47);
			obj12.Properties.Add(obj48);
			obj12.Properties.Add(obj49);
			obj12.Declarations.Add(obj47);
			obj12.Declarations.Add(obj48);
			obj12.Declarations.Add(obj49);
			obj12.Name = "Alternative";
			obj12.Parent = obj5;
			((__IModelObject)obj13).Children.Add((__IModelObject)obj52);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj53);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj54);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj55);
			((__IModelObject)obj13).Children.Add((__IModelObject)obj56);
			obj13.Properties.Add(obj52);
			obj13.Properties.Add(obj53);
			obj13.Properties.Add(obj54);
			obj13.Properties.Add(obj55);
			obj13.Properties.Add(obj56);
			obj13.Declarations.Add(obj52);
			obj13.Declarations.Add(obj53);
			obj13.Declarations.Add(obj54);
			obj13.Declarations.Add(obj55);
			obj13.Declarations.Add(obj56);
			obj13.Name = "Element";
			obj13.Parent = obj5;
			((__IModelObject)obj14).Children.Add((__IModelObject)obj58);
			obj14.IsAbstract = true;
			obj14.Properties.Add(obj58);
			obj14.Declarations.Add(obj58);
			obj14.Name = "ElementValue";
			obj14.Parent = obj5;
			((__IModelObject)obj15).Children.Add((__IModelObject)obj60);
			obj15.BaseTypes.Add(obj14);
			obj15.Properties.Add(obj60);
			obj15.Declarations.Add(obj60);
			obj15.Name = "RuleRef";
			obj15.Parent = obj5;
			((__IModelObject)obj16).Children.Add((__IModelObject)obj61);
			obj16.BaseTypes.Add(obj14);
			obj16.Properties.Add(obj61);
			obj16.Declarations.Add(obj61);
			obj16.Name = "TokenRef";
			obj16.Parent = obj5;
			((__IModelObject)obj17).Children.Add((__IModelObject)obj62);
			obj17.BaseTypes.Add(obj14);
			obj17.Properties.Add(obj62);
			obj17.Declarations.Add(obj62);
			obj17.Name = "TokenAlts";
			obj17.Parent = obj5;
			obj18.BaseTypes.Add(obj14);
			obj18.Name = "Eof";
			obj18.Parent = obj5;
			((__IModelObject)obj19).Children.Add((__IModelObject)obj64);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj65);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj66);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj67);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj68);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj69);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj70);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj71);
			obj19.BaseTypes.Add(obj14);
			obj19.Properties.Add(obj64);
			obj19.Properties.Add(obj65);
			obj19.Properties.Add(obj66);
			obj19.Properties.Add(obj67);
			obj19.Properties.Add(obj68);
			obj19.Properties.Add(obj69);
			obj19.Properties.Add(obj70);
			obj19.Properties.Add(obj71);
			obj19.Declarations.Add(obj64);
			obj19.Declarations.Add(obj65);
			obj19.Declarations.Add(obj66);
			obj19.Declarations.Add(obj67);
			obj19.Declarations.Add(obj68);
			obj19.Declarations.Add(obj69);
			obj19.Declarations.Add(obj70);
			obj19.Declarations.Add(obj71);
			obj19.Name = "List";
			obj19.Parent = obj5;
			obj20.Type = typeof(string);
			obj20.Name = "FullName";
			obj20.Parent = obj7;
			((__IModelObject)obj21).Children.Add((__IModelObject)obj22);
			obj21.IsContainment = true;
			obj21.Type = __MetaType.FromModelObject((__IModelObject)obj22);
			obj21.Name = "Arguments";
			obj21.Parent = obj7;
			obj22.ItemType = __MetaType.FromModelObject((__IModelObject)obj8);
			obj23.Type = typeof(string);
			obj23.Name = "Name";
			obj23.Parent = obj8;
			obj24.Type = typeof(string);
			obj24.Name = "Value";
			obj24.Parent = obj8;
			((__IModelObject)obj25).Children.Add((__IModelObject)obj30);
			obj25.IsContainment = true;
			obj25.Type = __MetaType.FromModelObject((__IModelObject)obj30);
			obj25.Name = "Annotations";
			obj25.Parent = obj9;
			obj26.Type = typeof(string);
			obj26.Name = "Name";
			obj26.Parent = obj9;
			((__IModelObject)obj27).Children.Add((__IModelObject)obj31);
			obj27.Type = __MetaType.FromModelObject((__IModelObject)obj31);
			obj27.Name = "TokenKinds";
			obj27.Parent = obj9;
			((__IModelObject)obj28).Children.Add((__IModelObject)obj32);
			obj28.IsContainment = true;
			obj28.Type = __MetaType.FromModelObject((__IModelObject)obj32);
			obj28.Name = "Tokens";
			obj28.Parent = obj9;
			((__IModelObject)obj29).Children.Add((__IModelObject)obj33);
			obj29.IsContainment = true;
			obj29.Type = __MetaType.FromModelObject((__IModelObject)obj33);
			obj29.Name = "Rules";
			obj29.Parent = obj9;
			obj30.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj31.ItemType = typeof(string);
			obj32.ItemType = __MetaType.FromModelObject((__IModelObject)obj10);
			obj33.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
			((__IModelObject)obj34).Children.Add((__IModelObject)obj40);
			obj34.IsContainment = true;
			obj34.Type = __MetaType.FromModelObject((__IModelObject)obj40);
			obj34.Name = "Annotations";
			obj34.Parent = obj10;
			obj35.Type = typeof(string);
			obj35.Name = "Name";
			obj35.Parent = obj10;
			obj36.Type = typeof(string);
			obj36.Name = "TokenKind";
			obj36.Parent = obj10;
			obj37.Type = typeof(bool);
			obj37.Name = "IsTrivia";
			obj37.Parent = obj10;
			obj38.Type = typeof(bool);
			obj38.Name = "IsFixed";
			obj38.Parent = obj10;
			((__IModelObject)obj39).Children.Add((__IModelObject)obj41);
			obj39.Type = __MetaType.FromModelObject((__IModelObject)obj41);
			obj39.Name = "FixedText";
			obj39.Parent = obj10;
			obj40.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj41.InnerType = typeof(string);
			((__IModelObject)obj42).Children.Add((__IModelObject)obj45);
			obj42.IsContainment = true;
			obj42.Type = __MetaType.FromModelObject((__IModelObject)obj45);
			obj42.Name = "Annotations";
			obj42.Parent = obj11;
			obj43.Type = typeof(string);
			obj43.Name = "Name";
			obj43.Parent = obj11;
			((__IModelObject)obj44).Children.Add((__IModelObject)obj46);
			obj44.IsContainment = true;
			obj44.Type = __MetaType.FromModelObject((__IModelObject)obj46);
			obj44.Name = "Alternatives";
			obj44.Parent = obj11;
			obj45.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj46.ItemType = __MetaType.FromModelObject((__IModelObject)obj12);
			obj47.Type = typeof(string);
			obj47.Name = "Name";
			obj47.Parent = obj12;
			((__IModelObject)obj48).Children.Add((__IModelObject)obj50);
			obj48.IsContainment = true;
			obj48.Type = __MetaType.FromModelObject((__IModelObject)obj50);
			obj48.Name = "Annotations";
			obj48.Parent = obj12;
			((__IModelObject)obj49).Children.Add((__IModelObject)obj51);
			obj49.IsContainment = true;
			obj49.Type = __MetaType.FromModelObject((__IModelObject)obj51);
			obj49.Name = "Elements";
			obj49.Parent = obj12;
			obj50.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj51.ItemType = __MetaType.FromModelObject((__IModelObject)obj13);
			((__IModelObject)obj52).Children.Add((__IModelObject)obj57);
			obj52.IsContainment = true;
			obj52.Type = __MetaType.FromModelObject((__IModelObject)obj57);
			obj52.Name = "Annotations";
			obj52.Parent = obj13;
			obj53.Type = typeof(string);
			obj53.Name = "Name";
			obj53.Parent = obj13;
			obj54.Type = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment);
			obj54.Name = "Assignment";
			obj54.Parent = obj13;
			obj55.IsContainment = true;
			obj55.Type = __MetaType.FromModelObject((__IModelObject)obj14);
			obj55.Name = "Value";
			obj55.Parent = obj13;
			obj56.Type = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity);
			obj56.Name = "Multiplicity";
			obj56.Parent = obj13;
			obj57.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			((__IModelObject)obj58).Children.Add((__IModelObject)obj59);
			obj58.IsContainment = true;
			obj58.Type = __MetaType.FromModelObject((__IModelObject)obj59);
			obj58.Name = "Annotations";
			obj58.Parent = obj14;
			obj59.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj60.Type = __MetaType.FromModelObject((__IModelObject)obj11);
			obj60.Name = "Rule";
			obj60.Parent = obj15;
			obj61.Type = __MetaType.FromModelObject((__IModelObject)obj10);
			obj61.Name = "Token";
			obj61.Parent = obj16;
			((__IModelObject)obj62).Children.Add((__IModelObject)obj63);
			obj62.Type = __MetaType.FromModelObject((__IModelObject)obj63);
			obj62.Name = "Tokens";
			obj62.Parent = obj17;
			obj63.ItemType = __MetaType.FromModelObject((__IModelObject)obj16);
			obj64.Type = typeof(bool);
			obj64.Name = "SeparatorFirst";
			obj64.Parent = obj19;
			((__IModelObject)obj65).Children.Add((__IModelObject)obj72);
			obj65.Type = __MetaType.FromModelObject((__IModelObject)obj72);
			obj65.Name = "FirstItems";
			obj65.Parent = obj19;
			((__IModelObject)obj66).Children.Add((__IModelObject)obj73);
			obj66.Type = __MetaType.FromModelObject((__IModelObject)obj73);
			obj66.Name = "FirstSeparators";
			obj66.Parent = obj19;
			obj67.Type = __MetaType.FromModelObject((__IModelObject)obj13);
			obj67.Name = "RepeatedBlock";
			obj67.Parent = obj19;
			obj68.Type = __MetaType.FromModelObject((__IModelObject)obj13);
			obj68.Name = "RepeatedItem";
			obj68.Parent = obj19;
			obj69.Type = __MetaType.FromModelObject((__IModelObject)obj13);
			obj69.Name = "RepeatedSeparator";
			obj69.Parent = obj19;
			((__IModelObject)obj70).Children.Add((__IModelObject)obj74);
			obj70.Type = __MetaType.FromModelObject((__IModelObject)obj74);
			obj70.Name = "LastItems";
			obj70.Parent = obj19;
			((__IModelObject)obj71).Children.Add((__IModelObject)obj75);
			obj71.Type = __MetaType.FromModelObject((__IModelObject)obj75);
			obj71.Name = "LastSeparators";
			obj71.Parent = obj19;
			obj72.ItemType = __MetaType.FromModelObject((__IModelObject)obj13);
			obj73.ItemType = __MetaType.FromModelObject((__IModelObject)obj13);
			obj74.ItemType = __MetaType.FromModelObject((__IModelObject)obj13);
			obj75.ItemType = __MetaType.FromModelObject((__IModelObject)obj13);
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
		public static __ModelProperty Alternative_Annotations => _Alternative_Annotations;
		public static __ModelProperty Alternative_Elements => _Alternative_Elements;
		public static __ModelClassInfo AnnotationInfo => __Impl.Annotation_Impl.__Info.Instance;
		public static __ModelProperty Annotation_FullName => _Annotation_FullName;
		public static __ModelProperty Annotation_Arguments => _Annotation_Arguments;
		public static __ModelClassInfo AnnotationArgumentInfo => __Impl.AnnotationArgument_Impl.__Info.Instance;
		public static __ModelProperty AnnotationArgument_Name => _AnnotationArgument_Name;
		public static __ModelProperty AnnotationArgument_Value => _AnnotationArgument_Value;
		public static __ModelClassInfo ElementInfo => __Impl.Element_Impl.__Info.Instance;
		public static __ModelProperty Element_Annotations => _Element_Annotations;
		public static __ModelProperty Element_Name => _Element_Name;
		public static __ModelProperty Element_Assignment => _Element_Assignment;
		public static __ModelProperty Element_Value => _Element_Value;
		public static __ModelProperty Element_Multiplicity => _Element_Multiplicity;
		public static __ModelClassInfo ElementValueInfo => __Impl.ElementValue_Impl.__Info.Instance;
		public static __ModelProperty ElementValue_Annotations => _ElementValue_Annotations;
		public static __ModelClassInfo EofInfo => __Impl.Eof_Impl.__Info.Instance;
		public static __ModelClassInfo LanguageInfo => __Impl.Language_Impl.__Info.Instance;
		public static __ModelProperty Language_Annotations => _Language_Annotations;
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
		public static __ModelProperty Rule_Annotations => _Rule_Annotations;
		public static __ModelProperty Rule_Name => _Rule_Name;
		public static __ModelProperty Rule_Alternatives => _Rule_Alternatives;
		public static __ModelClassInfo RuleRefInfo => __Impl.RuleRef_Impl.__Info.Instance;
		public static __ModelProperty RuleRef_Rule => _RuleRef_Rule;
		public static __ModelClassInfo TokenInfo => __Impl.Token_Impl.__Info.Instance;
		public static __ModelProperty Token_Annotations => _Token_Annotations;
		public static __ModelProperty Token_Name => _Token_Name;
		public static __ModelProperty Token_TokenKind => _Token_TokenKind;
		public static __ModelProperty Token_IsTrivia => _Token_IsTrivia;
		public static __ModelProperty Token_IsFixed => _Token_IsFixed;
		public static __ModelProperty Token_FixedText => _Token_FixedText;
		public static __ModelClassInfo TokenAltsInfo => __Impl.TokenAlts_Impl.__Info.Instance;
		public static __ModelProperty TokenAlts_Tokens => _TokenAlts_Tokens;
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
	
		public Annotation Annotation(string? id = null)
		{
			return (Annotation)Roslyn.AnnotationInfo.Create(Model, id)!;
		}
	
		public AnnotationArgument AnnotationArgument(string? id = null)
		{
			return (AnnotationArgument)Roslyn.AnnotationArgumentInfo.Create(Model, id)!;
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
	
		public Annotation Annotation(__Model model, string? id = null)
		{
			return (Annotation)Roslyn.AnnotationInfo.Create(model, id)!;
		}
	
		public AnnotationArgument AnnotationArgument(__Model model, string? id = null)
		{
			return (AnnotationArgument)Roslyn.AnnotationArgumentInfo.Create(model, id)!;
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
	
		public TokenRef TokenRef(__Model model, string? id = null)
		{
			return (TokenRef)Roslyn.TokenRefInfo.Create(model, id)!;
		}
	
	}
	


	public interface Alternative : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Annotation> Annotations { get; }
		global::System.Collections.Generic.IList<Element> Elements { get; }
		string Name { get; set; }
	
	}

	public interface Annotation : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<AnnotationArgument> Arguments { get; }
		string FullName { get; set; }
	
	}

	public interface AnnotationArgument : __IModelObjectCore
	{
		string Name { get; set; }
		string Value { get; set; }
	
	}

	public interface Element : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Annotation> Annotations { get; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment { get; set; }
		global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
		string Name { get; set; }
		ElementValue Value { get; set; }
	
	}

	public interface ElementValue : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Annotation> Annotations { get; }
	
	}

	public interface Eof : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
	
	}

	public interface Language : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Annotation> Annotations { get; }
		string Name { get; set; }
		global::System.Collections.Generic.IList<Rule> Rules { get; }
		global::System.Collections.Generic.IList<string> TokenKinds { get; }
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
		global::System.Collections.Generic.IList<Annotation> Annotations { get; }
		string Name { get; set; }
	
	}

	public interface RuleRef : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		Rule Rule { get; set; }
	
	}

	public interface Token : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<Annotation> Annotations { get; }
		string? FixedText { get; set; }
		bool IsFixed { get; set; }
		bool IsTrivia { get; set; }
		string Name { get; set; }
		string TokenKind { get; set; }
	
	}

	public interface TokenAlts : global::MetaDslx.Bootstrap.MetaCompiler.Roslyn.ElementValue
	{
		global::System.Collections.Generic.IList<TokenRef> Tokens { get; }
	
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
		/// Constructor for the class Annotation
		/// </summary>
		void Annotation(Annotation _this);
	
		/// <summary>
		/// Constructor for the class AnnotationArgument
		/// </summary>
		void AnnotationArgument(AnnotationArgument _this);
	
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
			((__IModelObject)this).Init(Roslyn.Alternative_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Roslyn.Alternative_Annotations)!));
			((__IModelObject)this).Init(Roslyn.Alternative_Elements, new global::MetaDslx.Modeling.ModelObjectList<Element>(this, __Info.Instance.GetSlot(Roslyn.Alternative_Elements)!));
			Roslyn.__CustomImpl.Alternative(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Roslyn.Alternative_Annotations);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Annotations, Roslyn.Alternative_Elements, Roslyn.Alternative_Name);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Annotations, Roslyn.Alternative_Elements, Roslyn.Alternative_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Annotations, Roslyn.Alternative_Elements, Roslyn.Alternative_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Annotations", Roslyn.Alternative_Annotations);
				publicPropertiesByName.Add("Elements", Roslyn.Alternative_Elements);
				publicPropertiesByName.Add("Name", Roslyn.Alternative_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Alternative_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Alternative_Annotations, __ImmutableArray.Create<__ModelProperty>(Roslyn.Alternative_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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

	internal class Annotation_Impl : __MetaModelObject, Annotation
	{
		private Annotation_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.Annotation_Arguments, new global::MetaDslx.Modeling.ModelObjectList<AnnotationArgument>(this, __Info.Instance.GetSlot(Roslyn.Annotation_Arguments)!));
			Roslyn.__CustomImpl.Annotation(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<AnnotationArgument> Arguments
		{
			get => MGetCollection<AnnotationArgument>(Roslyn.Annotation_Arguments);
		}
	
		public string FullName
		{
			get => MGet<string>(Roslyn.Annotation_FullName);
			set => MAdd<string>(Roslyn.Annotation_FullName, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Annotation_Arguments, Roslyn.Annotation_FullName);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Annotation_Arguments, Roslyn.Annotation_FullName);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Annotation_Arguments, Roslyn.Annotation_FullName);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Arguments", Roslyn.Annotation_Arguments);
				publicPropertiesByName.Add("FullName", Roslyn.Annotation_FullName);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Annotation_Arguments, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Annotation_Arguments, __ImmutableArray.Create<__ModelProperty>(Roslyn.Annotation_Arguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Annotation_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Annotation_FullName, __ImmutableArray.Create<__ModelProperty>(Roslyn.Annotation_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(Annotation);
	
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
				var result = new Annotation_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.AnnotationInfo";
			}
		}
	}

	internal class AnnotationArgument_Impl : __MetaModelObject, AnnotationArgument
	{
		private AnnotationArgument_Impl(string? id)
			: base(id)
		{
			Roslyn.__CustomImpl.AnnotationArgument(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string Name
		{
			get => MGet<string>(Roslyn.AnnotationArgument_Name);
			set => MAdd<string>(Roslyn.AnnotationArgument_Name, value);
		}
	
		public string Value
		{
			get => MGet<string>(Roslyn.AnnotationArgument_Value);
			set => MAdd<string>(Roslyn.AnnotationArgument_Value, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.AnnotationArgument_Name, Roslyn.AnnotationArgument_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.AnnotationArgument_Name, Roslyn.AnnotationArgument_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.AnnotationArgument_Name, Roslyn.AnnotationArgument_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Name", Roslyn.AnnotationArgument_Name);
				publicPropertiesByName.Add("Value", Roslyn.AnnotationArgument_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.AnnotationArgument_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.AnnotationArgument_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.AnnotationArgument_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.AnnotationArgument_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.AnnotationArgument_Value, __ImmutableArray.Create<__ModelProperty>(Roslyn.AnnotationArgument_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Roslyn.MInstance;
	        public override __MetaType MetaType => typeof(AnnotationArgument);
	
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
				var result = new AnnotationArgument_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Roslyn.AnnotationArgumentInfo";
			}
		}
	}

	internal class Element_Impl : __MetaModelObject, Element
	{
		private Element_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.Element_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Roslyn.Element_Annotations)!));
			Roslyn.__CustomImpl.Element(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Roslyn.Element_Annotations);
		}
	
		public global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment
		{
			get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment>(Roslyn.Element_Assignment);
			set => MAdd<global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment>(Roslyn.Element_Assignment, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Annotations, Roslyn.Element_Assignment, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_Value);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Annotations, Roslyn.Element_Assignment, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_Value);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Annotations, Roslyn.Element_Assignment, Roslyn.Element_Multiplicity, Roslyn.Element_Name, Roslyn.Element_Value);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Annotations", Roslyn.Element_Annotations);
				publicPropertiesByName.Add("Assignment", Roslyn.Element_Assignment);
				publicPropertiesByName.Add("Multiplicity", Roslyn.Element_Multiplicity);
				publicPropertiesByName.Add("Name", Roslyn.Element_Name);
				publicPropertiesByName.Add("Value", Roslyn.Element_Value);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Element_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Annotations, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Element_Assignment, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Element_Assignment, __ImmutableArray.Create<__ModelProperty>(Roslyn.Element_Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
			((__IModelObject)this).Init(Roslyn.ElementValue_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Annotations)!));
			Roslyn.__CustomImpl.ElementValue(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Roslyn.ElementValue_Annotations);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Annotations);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Annotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Annotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Annotations", Roslyn.ElementValue_Annotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.ElementValue_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Annotations, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
			((__IModelObject)this).Init(Roslyn.ElementValue_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Annotations)!));
			Roslyn.__CustomImpl.ElementValue(this);
			Roslyn.__CustomImpl.Eof(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Roslyn.ElementValue_Annotations);
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
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Annotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Annotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Annotations", Roslyn.ElementValue_Annotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.ElementValue_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Annotations, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
			((__IModelObject)this).Init(Roslyn.Language_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Roslyn.Language_Annotations)!));
			((__IModelObject)this).Init(Roslyn.Language_Rules, new global::MetaDslx.Modeling.ModelObjectList<Rule>(this, __Info.Instance.GetSlot(Roslyn.Language_Rules)!));
			((__IModelObject)this).Init(Roslyn.Language_TokenKinds, new global::MetaDslx.Modeling.ModelObjectList<string>(this, __Info.Instance.GetSlot(Roslyn.Language_TokenKinds)!));
			((__IModelObject)this).Init(Roslyn.Language_Tokens, new global::MetaDslx.Modeling.ModelObjectList<Token>(this, __Info.Instance.GetSlot(Roslyn.Language_Tokens)!));
			Roslyn.__CustomImpl.Language(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Roslyn.Language_Annotations);
		}
	
		public string Name
		{
			get => MGet<string>(Roslyn.Language_Name);
			set => MAdd<string>(Roslyn.Language_Name, value);
		}
	
		public global::System.Collections.Generic.IList<Rule> Rules
		{
			get => MGetCollection<Rule>(Roslyn.Language_Rules);
		}
	
		public global::System.Collections.Generic.IList<string> TokenKinds
		{
			get => MGetCollection<string>(Roslyn.Language_TokenKinds);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Annotations, Roslyn.Language_Name, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Annotations, Roslyn.Language_Name, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Annotations, Roslyn.Language_Name, Roslyn.Language_Rules, Roslyn.Language_TokenKinds, Roslyn.Language_Tokens);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Annotations", Roslyn.Language_Annotations);
				publicPropertiesByName.Add("Name", Roslyn.Language_Name);
				publicPropertiesByName.Add("Rules", Roslyn.Language_Rules);
				publicPropertiesByName.Add("TokenKinds", Roslyn.Language_TokenKinds);
				publicPropertiesByName.Add("Tokens", Roslyn.Language_Tokens);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Language_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_Annotations, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_Rules, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_Rules, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_Rules), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Language_TokenKinds, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Language_TokenKinds, __ImmutableArray.Create<__ModelProperty>(Roslyn.Language_TokenKinds), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
			((__IModelObject)this).Init(Roslyn.ElementValue_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Annotations)!));
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
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Roslyn.ElementValue_Annotations);
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
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.List_FirstItems, Roslyn.List_FirstSeparators, Roslyn.List_LastItems, Roslyn.List_LastSeparators, Roslyn.List_RepeatedBlock, Roslyn.List_RepeatedItem, Roslyn.List_RepeatedSeparator, Roslyn.List_SeparatorFirst, Roslyn.ElementValue_Annotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.List_FirstItems, Roslyn.List_FirstSeparators, Roslyn.List_LastItems, Roslyn.List_LastSeparators, Roslyn.List_RepeatedBlock, Roslyn.List_RepeatedItem, Roslyn.List_RepeatedSeparator, Roslyn.List_SeparatorFirst, Roslyn.ElementValue_Annotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("FirstItems", Roslyn.List_FirstItems);
				publicPropertiesByName.Add("FirstSeparators", Roslyn.List_FirstSeparators);
				publicPropertiesByName.Add("LastItems", Roslyn.List_LastItems);
				publicPropertiesByName.Add("LastSeparators", Roslyn.List_LastSeparators);
				publicPropertiesByName.Add("RepeatedBlock", Roslyn.List_RepeatedBlock);
				publicPropertiesByName.Add("RepeatedItem", Roslyn.List_RepeatedItem);
				publicPropertiesByName.Add("RepeatedSeparator", Roslyn.List_RepeatedSeparator);
				publicPropertiesByName.Add("SeparatorFirst", Roslyn.List_SeparatorFirst);
				publicPropertiesByName.Add("Annotations", Roslyn.ElementValue_Annotations);
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
				modelPropertyInfos.Add(Roslyn.ElementValue_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Annotations, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
			((__IModelObject)this).Init(Roslyn.Rule_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Roslyn.Rule_Annotations)!));
			Roslyn.__CustomImpl.Rule(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Alternative> Alternatives
		{
			get => MGetCollection<Alternative>(Roslyn.Rule_Alternatives);
		}
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Roslyn.Rule_Annotations);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Annotations, Roslyn.Rule_Name);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Annotations, Roslyn.Rule_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives, Roslyn.Rule_Annotations, Roslyn.Rule_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Alternatives", Roslyn.Rule_Alternatives);
				publicPropertiesByName.Add("Annotations", Roslyn.Rule_Annotations);
				publicPropertiesByName.Add("Name", Roslyn.Rule_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Rule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Rule_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Rule_Annotations, __ImmutableArray.Create<__ModelProperty>(Roslyn.Rule_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
			((__IModelObject)this).Init(Roslyn.ElementValue_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Annotations)!));
			Roslyn.__CustomImpl.ElementValue(this);
			Roslyn.__CustomImpl.RuleRef(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public Rule Rule
		{
			get => MGet<Rule>(Roslyn.RuleRef_Rule);
			set => MAdd<Rule>(Roslyn.RuleRef_Rule, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Roslyn.ElementValue_Annotations);
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
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_Rule, Roslyn.ElementValue_Annotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_Rule, Roslyn.ElementValue_Annotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Rule", Roslyn.RuleRef_Rule);
				publicPropertiesByName.Add("Annotations", Roslyn.ElementValue_Annotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.RuleRef_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.RuleRef_Rule, __ImmutableArray.Create<__ModelProperty>(Roslyn.RuleRef_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Annotations, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
			((__IModelObject)this).Init(Roslyn.Token_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Roslyn.Token_Annotations)!));
			Roslyn.__CustomImpl.Token(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Roslyn.Token_Annotations);
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
	
		public string TokenKind
		{
			get => MGet<string>(Roslyn.Token_TokenKind);
			set => MAdd<string>(Roslyn.Token_TokenKind, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_Annotations, Roslyn.Token_FixedText, Roslyn.Token_IsFixed, Roslyn.Token_IsTrivia, Roslyn.Token_Name, Roslyn.Token_TokenKind);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_Annotations, Roslyn.Token_FixedText, Roslyn.Token_IsFixed, Roslyn.Token_IsTrivia, Roslyn.Token_Name, Roslyn.Token_TokenKind);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_Annotations, Roslyn.Token_FixedText, Roslyn.Token_IsFixed, Roslyn.Token_IsTrivia, Roslyn.Token_Name, Roslyn.Token_TokenKind);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Annotations", Roslyn.Token_Annotations);
				publicPropertiesByName.Add("FixedText", Roslyn.Token_FixedText);
				publicPropertiesByName.Add("IsFixed", Roslyn.Token_IsFixed);
				publicPropertiesByName.Add("IsTrivia", Roslyn.Token_IsTrivia);
				publicPropertiesByName.Add("Name", Roslyn.Token_Name);
				publicPropertiesByName.Add("TokenKind", Roslyn.Token_TokenKind);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.Token_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_Annotations, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Token_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_FixedText, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Token_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_IsFixed, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Token_IsTrivia, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_IsTrivia, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_IsTrivia), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Token_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_Name, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.Token_TokenKind, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.Token_TokenKind, __ImmutableArray.Create<__ModelProperty>(Roslyn.Token_TokenKind), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
			((__IModelObject)this).Init(Roslyn.ElementValue_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Annotations)!));
			Roslyn.__CustomImpl.ElementValue(this);
			Roslyn.__CustomImpl.TokenAlts(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<TokenRef> Tokens
		{
			get => MGetCollection<TokenRef>(Roslyn.TokenAlts_Tokens);
		}
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Roslyn.ElementValue_Annotations);
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
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_Tokens, Roslyn.ElementValue_Annotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_Tokens, Roslyn.ElementValue_Annotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Tokens", Roslyn.TokenAlts_Tokens);
				publicPropertiesByName.Add("Annotations", Roslyn.ElementValue_Annotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.TokenAlts_Tokens, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenAlts_Tokens, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenAlts_Tokens), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Annotations, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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

	internal class TokenRef_Impl : __MetaModelObject, TokenRef
	{
		private TokenRef_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Roslyn.ElementValue_Annotations, new global::MetaDslx.Modeling.ModelObjectList<Annotation>(this, __Info.Instance.GetSlot(Roslyn.ElementValue_Annotations)!));
			Roslyn.__CustomImpl.ElementValue(this);
			Roslyn.__CustomImpl.TokenRef(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public Token Token
		{
			get => MGet<Token>(Roslyn.TokenRef_Token);
			set => MAdd<Token>(Roslyn.TokenRef_Token, value);
		}
	
		public global::System.Collections.Generic.IList<Annotation> Annotations
		{
			get => MGetCollection<Annotation>(Roslyn.ElementValue_Annotations);
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
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_Token, Roslyn.ElementValue_Annotations);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_Token, Roslyn.ElementValue_Annotations);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Token", Roslyn.TokenRef_Token);
				publicPropertiesByName.Add("Annotations", Roslyn.ElementValue_Annotations);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Roslyn.TokenRef_Token, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.TokenRef_Token, __ImmutableArray.Create<__ModelProperty>(Roslyn.TokenRef_Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Roslyn.ElementValue_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Roslyn.ElementValue_Annotations, __ImmutableArray.Create<__ModelProperty>(Roslyn.ElementValue_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
