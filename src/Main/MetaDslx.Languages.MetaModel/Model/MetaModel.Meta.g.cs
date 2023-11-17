#nullable enable

namespace MetaDslx.Languages.MetaModel.Model
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

	internal interface IMeta
	{
	}
	
	public sealed class Meta : __MetaModel, IMeta
	{
		// If there is an error at the following line, create a new class called 'CustomMetaImplementation'
		// inheriting from the class 'CustomMetaImplementationBase' and provide the custom implementation
		// for the derived properties and operations defined in the metamodel
		internal static readonly CustomMetaImplementationBase __CustomImpl = new CustomMetaImplementation();
	
		private static readonly Meta _instance;
		public static Meta MInstance => _instance;
	
		private static readonly __ModelProperty _MetaDeclaration_Name;
		private static readonly __ModelProperty _MetaDeclaration_Parent;
		private static readonly __ModelProperty _MetaDeclaration_Declarations;
		private static readonly __ModelProperty _MetaDeclaration_FullName;
		private static readonly __ModelProperty _MetaModel_NamespaceName;
		private static readonly __ModelProperty _MetaConstant_Type;
		private static readonly __ModelProperty _MetaNullableType_InnerType;
		private static readonly __ModelProperty _MetaArrayType_ItemType;
		private static readonly __ModelProperty _MetaEnum_Literals;
		private static readonly __ModelProperty _MetaClass_SymbolType;
		private static readonly __ModelProperty _MetaClass_IsAbstract;
		private static readonly __ModelProperty _MetaClass_BaseTypes;
		private static readonly __ModelProperty _MetaClass_Properties;
		private static readonly __ModelProperty _MetaClass_Operations;
		private static readonly __ModelProperty _MetaProperty_Type;
		private static readonly __ModelProperty _MetaProperty_SymbolProperty;
		private static readonly __ModelProperty _MetaProperty_IsContainment;
		private static readonly __ModelProperty _MetaProperty_IsDerived;
		private static readonly __ModelProperty _MetaProperty_OppositeProperties;
		private static readonly __ModelProperty _MetaProperty_SubsettedProperties;
		private static readonly __ModelProperty _MetaProperty_RedefinedProperties;
		private static readonly __ModelProperty _MetaOperation_ReturnType;
		private static readonly __ModelProperty _MetaOperation_Parameters;
		private static readonly __ModelProperty _MetaParameter_Type;
	
		static Meta()
		{
			_MetaDeclaration_Declarations = new __ModelProperty(typeof(MetaDeclaration), "Declarations", typeof(MetaDeclaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaDeclaration_FullName = new __ModelProperty(typeof(MetaDeclaration), "FullName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_MetaDeclaration_Name = new __ModelProperty(typeof(MetaDeclaration), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.Name, "Name");
			_MetaDeclaration_Parent = new __ModelProperty(typeof(MetaDeclaration), "Parent", typeof(MetaDeclaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_MetaConstant_Type = new __ModelProperty(typeof(MetaConstant), "Type", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaModel_NamespaceName = new __ModelProperty(typeof(MetaModel), "NamespaceName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_MetaArrayType_ItemType = new __ModelProperty(typeof(MetaArrayType), "ItemType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaClass_BaseTypes = new __ModelProperty(typeof(MetaClass), "BaseTypes", typeof(MetaClass), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_MetaClass_IsAbstract = new __ModelProperty(typeof(MetaClass), "IsAbstract", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaClass_Operations = new __ModelProperty(typeof(MetaClass), "Operations", typeof(MetaOperation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaClass_Properties = new __ModelProperty(typeof(MetaClass), "Properties", typeof(MetaProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaClass_SymbolType = new __ModelProperty(typeof(MetaClass), "SymbolType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaEnum_Literals = new __ModelProperty(typeof(MetaEnum), "Literals", typeof(MetaEnumLiteral), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaNullableType_InnerType = new __ModelProperty(typeof(MetaNullableType), "InnerType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaOperation_Parameters = new __ModelProperty(typeof(MetaOperation), "Parameters", typeof(MetaParameter), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaOperation_ReturnType = new __ModelProperty(typeof(MetaOperation), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaParameter_Type = new __ModelProperty(typeof(MetaParameter), "Type", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_IsContainment = new __ModelProperty(typeof(MetaProperty), "IsContainment", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_IsDerived = new __ModelProperty(typeof(MetaProperty), "IsDerived", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_OppositeProperties = new __ModelProperty(typeof(MetaProperty), "OppositeProperties", typeof(MetaProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_MetaProperty_RedefinedProperties = new __ModelProperty(typeof(MetaProperty), "RedefinedProperties", typeof(MetaProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_MetaProperty_SubsettedProperties = new __ModelProperty(typeof(MetaProperty), "SubsettedProperties", typeof(MetaProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_MetaProperty_SymbolProperty = new __ModelProperty(typeof(MetaProperty), "SymbolProperty", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_Type = new __ModelProperty(typeof(MetaProperty), "Type", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_instance = new Meta();
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
	
	
		private Meta()
		{
			_enumTypes = __ImmutableArray.Create<__MetaType>();
			_enumInfos = __ImmutableArray.Create<__ModelEnumInfo>();
			var enumInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelEnumInfo>();
			_enumInfosByType = enumInfosByType.ToImmutable();
			var enumInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelEnumInfo>();
			_enumInfosByName = enumInfosByName.ToImmutable();
	
			_classTypes = __ImmutableArray.Create<__MetaType>(typeof(MetaDeclaration), typeof(MetaConstant), typeof(MetaModel), typeof(MetaNamespace), typeof(MetaType), typeof(MetaArrayType), typeof(MetaClass), typeof(MetaEnum), typeof(MetaEnumLiteral), typeof(MetaNullableType), typeof(MetaOperation), typeof(MetaParameter), typeof(MetaPrimitiveType), typeof(MetaProperty));
			_classInfos = __ImmutableArray.Create<__ModelClassInfo>(MetaDeclarationInfo, MetaConstantInfo, MetaModelInfo, MetaNamespaceInfo, MetaTypeInfo, MetaArrayTypeInfo, MetaClassInfo, MetaEnumInfo, MetaEnumLiteralInfo, MetaNullableTypeInfo, MetaOperationInfo, MetaParameterInfo, MetaPrimitiveTypeInfo, MetaPropertyInfo);
			var classInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelClassInfo>();
			classInfosByType.Add(typeof(MetaDeclaration), MetaDeclarationInfo);
			classInfosByType.Add(typeof(MetaConstant), MetaConstantInfo);
			classInfosByType.Add(typeof(MetaModel), MetaModelInfo);
			classInfosByType.Add(typeof(MetaNamespace), MetaNamespaceInfo);
			classInfosByType.Add(typeof(MetaType), MetaTypeInfo);
			classInfosByType.Add(typeof(MetaArrayType), MetaArrayTypeInfo);
			classInfosByType.Add(typeof(MetaClass), MetaClassInfo);
			classInfosByType.Add(typeof(MetaEnum), MetaEnumInfo);
			classInfosByType.Add(typeof(MetaEnumLiteral), MetaEnumLiteralInfo);
			classInfosByType.Add(typeof(MetaNullableType), MetaNullableTypeInfo);
			classInfosByType.Add(typeof(MetaOperation), MetaOperationInfo);
			classInfosByType.Add(typeof(MetaParameter), MetaParameterInfo);
			classInfosByType.Add(typeof(MetaPrimitiveType), MetaPrimitiveTypeInfo);
			classInfosByType.Add(typeof(MetaProperty), MetaPropertyInfo);
			_classInfosByType = classInfosByType.ToImmutable();
			var classInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelClassInfo>();
			classInfosByName.Add("MetaDeclaration", MetaDeclarationInfo);
			classInfosByName.Add("MetaConstant", MetaConstantInfo);
			classInfosByName.Add("MetaModel", MetaModelInfo);
			classInfosByName.Add("MetaNamespace", MetaNamespaceInfo);
			classInfosByName.Add("MetaType", MetaTypeInfo);
			classInfosByName.Add("MetaArrayType", MetaArrayTypeInfo);
			classInfosByName.Add("MetaClass", MetaClassInfo);
			classInfosByName.Add("MetaEnum", MetaEnumInfo);
			classInfosByName.Add("MetaEnumLiteral", MetaEnumLiteralInfo);
			classInfosByName.Add("MetaNullableType", MetaNullableTypeInfo);
			classInfosByName.Add("MetaOperation", MetaOperationInfo);
			classInfosByName.Add("MetaParameter", MetaParameterInfo);
			classInfosByName.Add("MetaPrimitiveType", MetaPrimitiveTypeInfo);
			classInfosByName.Add("MetaProperty", MetaPropertyInfo);
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
			var obj25 = f.MetaNullableType();
			var obj26 = f.MetaNullableType();
			var obj27 = f.MetaArrayType();
			var obj28 = f.MetaNullableType();
			var obj29 = f.MetaProperty();
			var obj30 = f.MetaProperty();
			var obj31 = f.MetaProperty();
			var obj32 = f.MetaProperty();
			var obj33 = f.MetaProperty();
			var obj34 = f.MetaArrayType();
			var obj35 = f.MetaProperty();
			var obj36 = f.MetaProperty();
			var obj37 = f.MetaProperty();
			var obj38 = f.MetaProperty();
			var obj39 = f.MetaProperty();
			var obj40 = f.MetaNullableType();
			var obj41 = f.MetaArrayType();
			var obj42 = f.MetaArrayType();
			var obj43 = f.MetaArrayType();
			var obj44 = f.MetaProperty();
			var obj45 = f.MetaProperty();
			var obj46 = f.MetaProperty();
			var obj47 = f.MetaProperty();
			var obj48 = f.MetaProperty();
			var obj49 = f.MetaProperty();
			var obj50 = f.MetaProperty();
			var obj51 = f.MetaNullableType();
			var obj52 = f.MetaArrayType();
			var obj53 = f.MetaArrayType();
			var obj54 = f.MetaArrayType();
			var obj55 = f.MetaProperty();
			var obj56 = f.MetaProperty();
			var obj57 = f.MetaArrayType();
			var obj58 = f.MetaProperty();
			__CustomImpl.Meta(this);
			((__IModelObject)obj1).Children.Add((__IModelObject)obj2);
			((__IModelObject)obj2).Children.Add((__IModelObject)obj3);
			obj2.Declarations.Add(obj3);
			obj2.Name = "MetaDslx";
			((__IModelObject)obj3).Children.Add((__IModelObject)obj4);
			obj3.Declarations.Add(obj4);
			obj3.Name = "Languages";
			obj3.Parent = obj2;
			((__IModelObject)obj4).Children.Add((__IModelObject)obj5);
			obj4.Declarations.Add(obj5);
			obj4.Name = "MetaModel";
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
			obj5.Name = "Model";
			obj5.Parent = obj4;
			obj6.Name = "Meta";
			obj6.Parent = obj5;
			((__IModelObject)obj7).Children.Add((__IModelObject)obj21);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj22);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj23);
			((__IModelObject)obj7).Children.Add((__IModelObject)obj24);
			obj7.Properties.Add(obj21);
			obj7.Properties.Add(obj22);
			obj7.Properties.Add(obj23);
			obj7.Properties.Add(obj24);
			obj7.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
			obj7.Declarations.Add(obj21);
			obj7.Declarations.Add(obj22);
			obj7.Declarations.Add(obj23);
			obj7.Declarations.Add(obj24);
			obj7.Name = "MetaDeclaration";
			obj7.Parent = obj5;
			obj8.BaseTypes.Add(obj7);
			obj8.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
			obj8.Name = "MetaNamespace";
			obj8.Parent = obj5;
			((__IModelObject)obj9).Children.Add((__IModelObject)obj29);
			obj9.BaseTypes.Add(obj7);
			obj9.Properties.Add(obj29);
			obj9.Declarations.Add(obj29);
			obj9.Name = "MetaModel";
			obj9.Parent = obj5;
			((__IModelObject)obj10).Children.Add((__IModelObject)obj30);
			obj10.BaseTypes.Add(obj7);
			obj10.Properties.Add(obj30);
			obj10.Declarations.Add(obj30);
			obj10.Name = "MetaConstant";
			obj10.Parent = obj5;
			obj11.BaseTypes.Add(obj7);
			obj11.IsAbstract = true;
			obj11.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
			obj11.Name = "MetaType";
			obj11.Parent = obj5;
			obj12.BaseTypes.Add(obj11);
			obj12.Name = "MetaPrimitiveType";
			obj12.Parent = obj5;
			((__IModelObject)obj13).Children.Add((__IModelObject)obj31);
			obj13.BaseTypes.Add(obj11);
			obj13.Properties.Add(obj31);
			obj13.Declarations.Add(obj31);
			obj13.Name = "MetaNullableType";
			obj13.Parent = obj5;
			((__IModelObject)obj14).Children.Add((__IModelObject)obj32);
			obj14.BaseTypes.Add(obj11);
			obj14.Properties.Add(obj32);
			obj14.Declarations.Add(obj32);
			obj14.Name = "MetaArrayType";
			obj14.Parent = obj5;
			((__IModelObject)obj15).Children.Add((__IModelObject)obj33);
			obj15.BaseTypes.Add(obj11);
			obj15.Properties.Add(obj33);
			obj15.Declarations.Add(obj33);
			obj15.Name = "MetaEnum";
			obj15.Parent = obj5;
			obj16.BaseTypes.Add(obj7);
			obj16.Name = "MetaEnumLiteral";
			obj16.Parent = obj5;
			((__IModelObject)obj17).Children.Add((__IModelObject)obj35);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj36);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj37);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj38);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj39);
			obj17.BaseTypes.Add(obj11);
			obj17.Properties.Add(obj35);
			obj17.Properties.Add(obj36);
			obj17.Properties.Add(obj37);
			obj17.Properties.Add(obj38);
			obj17.Properties.Add(obj39);
			obj17.Declarations.Add(obj35);
			obj17.Declarations.Add(obj36);
			obj17.Declarations.Add(obj37);
			obj17.Declarations.Add(obj38);
			obj17.Declarations.Add(obj39);
			obj17.Name = "MetaClass";
			obj17.Parent = obj5;
			((__IModelObject)obj18).Children.Add((__IModelObject)obj44);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj45);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj46);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj47);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj48);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj49);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj50);
			obj18.BaseTypes.Add(obj7);
			obj18.Properties.Add(obj44);
			obj18.Properties.Add(obj45);
			obj18.Properties.Add(obj46);
			obj18.Properties.Add(obj47);
			obj18.Properties.Add(obj48);
			obj18.Properties.Add(obj49);
			obj18.Properties.Add(obj50);
			obj18.Declarations.Add(obj44);
			obj18.Declarations.Add(obj45);
			obj18.Declarations.Add(obj46);
			obj18.Declarations.Add(obj47);
			obj18.Declarations.Add(obj48);
			obj18.Declarations.Add(obj49);
			obj18.Declarations.Add(obj50);
			obj18.Name = "MetaProperty";
			obj18.Parent = obj5;
			((__IModelObject)obj19).Children.Add((__IModelObject)obj55);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj56);
			obj19.BaseTypes.Add(obj7);
			obj19.Properties.Add(obj55);
			obj19.Properties.Add(obj56);
			obj19.Declarations.Add(obj55);
			obj19.Declarations.Add(obj56);
			obj19.Name = "MetaOperation";
			obj19.Parent = obj5;
			((__IModelObject)obj20).Children.Add((__IModelObject)obj58);
			obj20.BaseTypes.Add(obj7);
			obj20.Properties.Add(obj58);
			obj20.Declarations.Add(obj58);
			obj20.Name = "MetaParameter";
			obj20.Parent = obj5;
			((__IModelObject)obj21).Children.Add((__IModelObject)obj25);
			obj21.SymbolProperty = "Name";
			obj21.Type = __MetaType.FromModelObject((__IModelObject)obj25);
			obj21.Name = "Name";
			obj21.Parent = obj7;
			((__IModelObject)obj22).Children.Add((__IModelObject)obj26);
			obj22.OppositeProperties.Add(obj23);
			obj22.Type = __MetaType.FromModelObject((__IModelObject)obj26);
			obj22.Name = "Parent";
			obj22.Parent = obj7;
			((__IModelObject)obj23).Children.Add((__IModelObject)obj27);
			obj23.IsContainment = true;
			obj23.OppositeProperties.Add(obj22);
			obj23.Type = __MetaType.FromModelObject((__IModelObject)obj27);
			obj23.Name = "Declarations";
			obj23.Parent = obj7;
			((__IModelObject)obj24).Children.Add((__IModelObject)obj28);
			obj24.IsDerived = true;
			obj24.Type = __MetaType.FromModelObject((__IModelObject)obj28);
			obj24.Name = "FullName";
			obj24.Parent = obj7;
			obj25.InnerType = typeof(string);
			obj26.InnerType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj27.ItemType = __MetaType.FromModelObject((__IModelObject)obj7);
			obj28.InnerType = typeof(string);
			obj29.IsDerived = true;
			obj29.Type = typeof(string);
			obj29.Name = "NamespaceName";
			obj29.Parent = obj9;
			obj30.Type = typeof(__MetaType);
			obj30.Name = "Type";
			obj30.Parent = obj10;
			obj31.Type = typeof(__MetaType);
			obj31.Name = "InnerType";
			obj31.Parent = obj13;
			obj32.Type = typeof(__MetaType);
			obj32.Name = "ItemType";
			obj32.Parent = obj14;
			((__IModelObject)obj33).Children.Add((__IModelObject)obj34);
			obj33.IsContainment = true;
			obj33.SubsettedProperties.Add(obj23);
			obj33.Type = __MetaType.FromModelObject((__IModelObject)obj34);
			obj33.Name = "Literals";
			obj33.Parent = obj15;
			obj34.ItemType = __MetaType.FromModelObject((__IModelObject)obj16);
			((__IModelObject)obj35).Children.Add((__IModelObject)obj40);
			obj35.Type = __MetaType.FromModelObject((__IModelObject)obj40);
			obj35.Name = "SymbolType";
			obj35.Parent = obj17;
			obj36.Type = typeof(bool);
			obj36.Name = "IsAbstract";
			obj36.Parent = obj17;
			((__IModelObject)obj37).Children.Add((__IModelObject)obj41);
			obj37.Type = __MetaType.FromModelObject((__IModelObject)obj41);
			obj37.Name = "BaseTypes";
			obj37.Parent = obj17;
			((__IModelObject)obj38).Children.Add((__IModelObject)obj42);
			obj38.IsContainment = true;
			obj38.SubsettedProperties.Add(obj23);
			obj38.Type = __MetaType.FromModelObject((__IModelObject)obj42);
			obj38.Name = "Properties";
			obj38.Parent = obj17;
			((__IModelObject)obj39).Children.Add((__IModelObject)obj43);
			obj39.IsContainment = true;
			obj39.SubsettedProperties.Add(obj23);
			obj39.Type = __MetaType.FromModelObject((__IModelObject)obj43);
			obj39.Name = "Operations";
			obj39.Parent = obj17;
			obj40.InnerType = typeof(__MetaType);
			obj41.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
			obj42.ItemType = __MetaType.FromModelObject((__IModelObject)obj18);
			obj43.ItemType = __MetaType.FromModelObject((__IModelObject)obj19);
			obj44.Type = typeof(__MetaType);
			obj44.Name = "Type";
			obj44.Parent = obj18;
			((__IModelObject)obj45).Children.Add((__IModelObject)obj51);
			obj45.Type = __MetaType.FromModelObject((__IModelObject)obj51);
			obj45.Name = "SymbolProperty";
			obj45.Parent = obj18;
			obj46.Type = typeof(bool);
			obj46.Name = "IsContainment";
			obj46.Parent = obj18;
			obj47.Type = typeof(bool);
			obj47.Name = "IsDerived";
			obj47.Parent = obj18;
			((__IModelObject)obj48).Children.Add((__IModelObject)obj52);
			obj48.OppositeProperties.Add(obj48);
			obj48.Type = __MetaType.FromModelObject((__IModelObject)obj52);
			obj48.Name = "OppositeProperties";
			obj48.Parent = obj18;
			((__IModelObject)obj49).Children.Add((__IModelObject)obj53);
			obj49.Type = __MetaType.FromModelObject((__IModelObject)obj53);
			obj49.Name = "SubsettedProperties";
			obj49.Parent = obj18;
			((__IModelObject)obj50).Children.Add((__IModelObject)obj54);
			obj50.Type = __MetaType.FromModelObject((__IModelObject)obj54);
			obj50.Name = "RedefinedProperties";
			obj50.Parent = obj18;
			obj51.InnerType = typeof(string);
			obj52.ItemType = __MetaType.FromModelObject((__IModelObject)obj18);
			obj53.ItemType = __MetaType.FromModelObject((__IModelObject)obj18);
			obj54.ItemType = __MetaType.FromModelObject((__IModelObject)obj18);
			obj55.Type = typeof(__MetaType);
			obj55.Name = "ReturnType";
			obj55.Parent = obj19;
			((__IModelObject)obj56).Children.Add((__IModelObject)obj57);
			obj56.IsContainment = true;
			obj56.RedefinedProperties.Add(obj23);
			obj56.Type = __MetaType.FromModelObject((__IModelObject)obj57);
			obj56.Name = "Parameters";
			obj56.Parent = obj19;
			obj57.ItemType = __MetaType.FromModelObject((__IModelObject)obj20);
			obj58.Type = typeof(__MetaType);
			obj58.Name = "Type";
			obj58.Parent = obj20;
			_model.IsSealed = true;
		}
	
	    public override string MName => nameof(Meta);
	    public override string MNamespace => "MetaDslx.Languages.MetaModel.Model";
	    public override __ModelVersion MVersion => default;
	    public override string MUri => "MetaDslx.Languages.MetaModel.Model.Meta";
	    public override string MPrefix => "m";
		public override __Model MModel => _model;
	
		public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelEnumInfo> MEnumInfosByType => _enumInfosByType;
		public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelEnumInfo> MEnumInfosByName => _enumInfosByName;
		public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelClassInfo> MClassInfosByType => _classInfosByType;
		public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelClassInfo> MClassInfosByName => _classInfosByName;
	
	    public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MEnumTypes => _enumTypes;
	    public override global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo> MEnumInfos => _enumInfos;
	    public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MClassTypes => _classTypes;
	    public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> MClassInfos => _classInfos;
	
	
	
		public static __ModelClassInfo MetaDeclarationInfo => __Impl.MetaDeclaration_Impl.__Info.Instance;
		public static __ModelProperty MetaDeclaration_Name => _MetaDeclaration_Name;
		public static __ModelProperty MetaDeclaration_Parent => _MetaDeclaration_Parent;
		public static __ModelProperty MetaDeclaration_Declarations => _MetaDeclaration_Declarations;
		public static __ModelProperty MetaDeclaration_FullName => _MetaDeclaration_FullName;
		public static __ModelClassInfo MetaConstantInfo => __Impl.MetaConstant_Impl.__Info.Instance;
		public static __ModelProperty MetaConstant_Type => _MetaConstant_Type;
		public static __ModelClassInfo MetaModelInfo => __Impl.MetaModel_Impl.__Info.Instance;
		public static __ModelProperty MetaModel_NamespaceName => _MetaModel_NamespaceName;
		public static __ModelClassInfo MetaNamespaceInfo => __Impl.MetaNamespace_Impl.__Info.Instance;
		public static __ModelClassInfo MetaTypeInfo => __Impl.MetaType_Impl.__Info.Instance;
		public static __ModelClassInfo MetaArrayTypeInfo => __Impl.MetaArrayType_Impl.__Info.Instance;
		public static __ModelProperty MetaArrayType_ItemType => _MetaArrayType_ItemType;
		public static __ModelClassInfo MetaClassInfo => __Impl.MetaClass_Impl.__Info.Instance;
		public static __ModelProperty MetaClass_SymbolType => _MetaClass_SymbolType;
		public static __ModelProperty MetaClass_IsAbstract => _MetaClass_IsAbstract;
		public static __ModelProperty MetaClass_BaseTypes => _MetaClass_BaseTypes;
		public static __ModelProperty MetaClass_Properties => _MetaClass_Properties;
		public static __ModelProperty MetaClass_Operations => _MetaClass_Operations;
		public static __ModelClassInfo MetaEnumInfo => __Impl.MetaEnum_Impl.__Info.Instance;
		public static __ModelProperty MetaEnum_Literals => _MetaEnum_Literals;
		public static __ModelClassInfo MetaEnumLiteralInfo => __Impl.MetaEnumLiteral_Impl.__Info.Instance;
		public static __ModelClassInfo MetaNullableTypeInfo => __Impl.MetaNullableType_Impl.__Info.Instance;
		public static __ModelProperty MetaNullableType_InnerType => _MetaNullableType_InnerType;
		public static __ModelClassInfo MetaOperationInfo => __Impl.MetaOperation_Impl.__Info.Instance;
		public static __ModelProperty MetaOperation_ReturnType => _MetaOperation_ReturnType;
		public static __ModelProperty MetaOperation_Parameters => _MetaOperation_Parameters;
		public static __ModelClassInfo MetaParameterInfo => __Impl.MetaParameter_Impl.__Info.Instance;
		public static __ModelProperty MetaParameter_Type => _MetaParameter_Type;
		public static __ModelClassInfo MetaPrimitiveTypeInfo => __Impl.MetaPrimitiveType_Impl.__Info.Instance;
		public static __ModelClassInfo MetaPropertyInfo => __Impl.MetaProperty_Impl.__Info.Instance;
		public static __ModelProperty MetaProperty_Type => _MetaProperty_Type;
		public static __ModelProperty MetaProperty_SymbolProperty => _MetaProperty_SymbolProperty;
		public static __ModelProperty MetaProperty_IsContainment => _MetaProperty_IsContainment;
		public static __ModelProperty MetaProperty_IsDerived => _MetaProperty_IsDerived;
		public static __ModelProperty MetaProperty_OppositeProperties => _MetaProperty_OppositeProperties;
		public static __ModelProperty MetaProperty_SubsettedProperties => _MetaProperty_SubsettedProperties;
		public static __ModelProperty MetaProperty_RedefinedProperties => _MetaProperty_RedefinedProperties;
	}
	
	public class MetaModelFactory : __ModelFactory
	{
		public MetaModelFactory(__Model model)
			: base(model, Meta.MInstance)
		{
		}
	
		public MetaDeclaration MetaDeclaration(string? id = null)
		{
			return (MetaDeclaration)Meta.MetaDeclarationInfo.Create(Model, id)!;
		}
	
		public MetaConstant MetaConstant(string? id = null)
		{
			return (MetaConstant)Meta.MetaConstantInfo.Create(Model, id)!;
		}
	
		public MetaModel MetaModel(string? id = null)
		{
			return (MetaModel)Meta.MetaModelInfo.Create(Model, id)!;
		}
	
		public MetaNamespace MetaNamespace(string? id = null)
		{
			return (MetaNamespace)Meta.MetaNamespaceInfo.Create(Model, id)!;
		}
	
		public MetaArrayType MetaArrayType(string? id = null)
		{
			return (MetaArrayType)Meta.MetaArrayTypeInfo.Create(Model, id)!;
		}
	
		public MetaClass MetaClass(string? id = null)
		{
			return (MetaClass)Meta.MetaClassInfo.Create(Model, id)!;
		}
	
		public MetaEnum MetaEnum(string? id = null)
		{
			return (MetaEnum)Meta.MetaEnumInfo.Create(Model, id)!;
		}
	
		public MetaEnumLiteral MetaEnumLiteral(string? id = null)
		{
			return (MetaEnumLiteral)Meta.MetaEnumLiteralInfo.Create(Model, id)!;
		}
	
		public MetaNullableType MetaNullableType(string? id = null)
		{
			return (MetaNullableType)Meta.MetaNullableTypeInfo.Create(Model, id)!;
		}
	
		public MetaOperation MetaOperation(string? id = null)
		{
			return (MetaOperation)Meta.MetaOperationInfo.Create(Model, id)!;
		}
	
		public MetaParameter MetaParameter(string? id = null)
		{
			return (MetaParameter)Meta.MetaParameterInfo.Create(Model, id)!;
		}
	
		public MetaPrimitiveType MetaPrimitiveType(string? id = null)
		{
			return (MetaPrimitiveType)Meta.MetaPrimitiveTypeInfo.Create(Model, id)!;
		}
	
		public MetaProperty MetaProperty(string? id = null)
		{
			return (MetaProperty)Meta.MetaPropertyInfo.Create(Model, id)!;
		}
	
	}
	
	public class MetaModelMultiFactory : __MultiModelFactory
	{
		public MetaModelMultiFactory()
			: base(new __MetaModel[] { Meta.MInstance })
		{
		}
	
		public MetaDeclaration MetaDeclaration(__Model model, string? id = null)
		{
			return (MetaDeclaration)Meta.MetaDeclarationInfo.Create(model, id)!;
		}
	
		public MetaConstant MetaConstant(__Model model, string? id = null)
		{
			return (MetaConstant)Meta.MetaConstantInfo.Create(model, id)!;
		}
	
		public MetaModel MetaModel(__Model model, string? id = null)
		{
			return (MetaModel)Meta.MetaModelInfo.Create(model, id)!;
		}
	
		public MetaNamespace MetaNamespace(__Model model, string? id = null)
		{
			return (MetaNamespace)Meta.MetaNamespaceInfo.Create(model, id)!;
		}
	
		public MetaArrayType MetaArrayType(__Model model, string? id = null)
		{
			return (MetaArrayType)Meta.MetaArrayTypeInfo.Create(model, id)!;
		}
	
		public MetaClass MetaClass(__Model model, string? id = null)
		{
			return (MetaClass)Meta.MetaClassInfo.Create(model, id)!;
		}
	
		public MetaEnum MetaEnum(__Model model, string? id = null)
		{
			return (MetaEnum)Meta.MetaEnumInfo.Create(model, id)!;
		}
	
		public MetaEnumLiteral MetaEnumLiteral(__Model model, string? id = null)
		{
			return (MetaEnumLiteral)Meta.MetaEnumLiteralInfo.Create(model, id)!;
		}
	
		public MetaNullableType MetaNullableType(__Model model, string? id = null)
		{
			return (MetaNullableType)Meta.MetaNullableTypeInfo.Create(model, id)!;
		}
	
		public MetaOperation MetaOperation(__Model model, string? id = null)
		{
			return (MetaOperation)Meta.MetaOperationInfo.Create(model, id)!;
		}
	
		public MetaParameter MetaParameter(__Model model, string? id = null)
		{
			return (MetaParameter)Meta.MetaParameterInfo.Create(model, id)!;
		}
	
		public MetaPrimitiveType MetaPrimitiveType(__Model model, string? id = null)
		{
			return (MetaPrimitiveType)Meta.MetaPrimitiveTypeInfo.Create(model, id)!;
		}
	
		public MetaProperty MetaProperty(__Model model, string? id = null)
		{
			return (MetaProperty)Meta.MetaPropertyInfo.Create(model, id)!;
		}
	
	}
	


	public interface MetaDeclaration : __IModelObjectCore
	{
		global::System.Collections.Generic.IList<MetaDeclaration> Declarations { get; }
		string? FullName { get; }
		string? Name { get; set; }
		MetaDeclaration? Parent { get; set; }
	
	}

	public interface MetaConstant : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		__MetaType Type { get; set; }
	
	}

	public interface MetaModel : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		string NamespaceName { get; }
	
	}

	public interface MetaNamespace : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
	
	}

	public interface MetaType : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
	
	}

	public interface MetaArrayType : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
		__MetaType ItemType { get; set; }
	
	}

	public interface MetaClass : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
		global::System.Collections.Generic.IList<MetaClass> BaseTypes { get; }
		bool IsAbstract { get; set; }
		global::System.Collections.Generic.IList<MetaOperation> Operations { get; }
		global::System.Collections.Generic.IList<MetaProperty> Properties { get; }
		__MetaType? SymbolType { get; set; }
	
	}

	public interface MetaEnum : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
		global::System.Collections.Generic.IList<MetaEnumLiteral> Literals { get; }
	
	}

	public interface MetaEnumLiteral : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
	
	}

	public interface MetaNullableType : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
		__MetaType InnerType { get; set; }
	
	}

	public interface MetaOperation : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		global::System.Collections.Generic.IList<MetaParameter> Parameters { get; }
		__MetaType ReturnType { get; set; }
	
	}

	public interface MetaParameter : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		__MetaType Type { get; set; }
	
	}

	public interface MetaPrimitiveType : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
	
	}

	public interface MetaProperty : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		bool IsContainment { get; set; }
		bool IsDerived { get; set; }
		global::System.Collections.Generic.IList<MetaProperty> OppositeProperties { get; }
		global::System.Collections.Generic.IList<MetaProperty> RedefinedProperties { get; }
		global::System.Collections.Generic.IList<MetaProperty> SubsettedProperties { get; }
		string? SymbolProperty { get; set; }
		__MetaType Type { get; set; }
	
	}


	internal interface ICustomMetaImplementation
	{
		/// <summary>
		/// Constructor for the meta model Meta
		/// </summary>
		void Meta(IMeta _this);
	
		/// <summary>
		/// Constructor for the class MetaDeclaration
		/// </summary>
		void MetaDeclaration(MetaDeclaration _this);
	
		/// <summary>
		/// Constructor for the class MetaConstant
		/// </summary>
		void MetaConstant(MetaConstant _this);
	
		/// <summary>
		/// Constructor for the class MetaModel
		/// </summary>
		void MetaModel(MetaModel _this);
	
		/// <summary>
		/// Constructor for the class MetaNamespace
		/// </summary>
		void MetaNamespace(MetaNamespace _this);
	
		/// <summary>
		/// Constructor for the class MetaType
		/// </summary>
		void MetaType(MetaType _this);
	
		/// <summary>
		/// Constructor for the class MetaArrayType
		/// </summary>
		void MetaArrayType(MetaArrayType _this);
	
		/// <summary>
		/// Constructor for the class MetaClass
		/// </summary>
		void MetaClass(MetaClass _this);
	
		/// <summary>
		/// Constructor for the class MetaEnum
		/// </summary>
		void MetaEnum(MetaEnum _this);
	
		/// <summary>
		/// Constructor for the class MetaEnumLiteral
		/// </summary>
		void MetaEnumLiteral(MetaEnumLiteral _this);
	
		/// <summary>
		/// Constructor for the class MetaNullableType
		/// </summary>
		void MetaNullableType(MetaNullableType _this);
	
		/// <summary>
		/// Constructor for the class MetaOperation
		/// </summary>
		void MetaOperation(MetaOperation _this);
	
		/// <summary>
		/// Constructor for the class MetaParameter
		/// </summary>
		void MetaParameter(MetaParameter _this);
	
		/// <summary>
		/// Constructor for the class MetaPrimitiveType
		/// </summary>
		void MetaPrimitiveType(MetaPrimitiveType _this);
	
		/// <summary>
		/// Constructor for the class MetaProperty
		/// </summary>
		void MetaProperty(MetaProperty _this);
	
	
		/// <summary>
		/// Computation of the derived property MetaDeclaration.FullName
		/// </summary>
		string? MetaDeclaration_FullName(MetaDeclaration _this);
	
		/// <summary>
		/// Computation of the derived property MetaModel.NamespaceName
		/// </summary>
		string MetaModel_NamespaceName(MetaModel _this);
	
	
	}
	
	internal abstract class CustomMetaImplementationBase : ICustomMetaImplementation
	{
		/// <summary>
		/// Constructor for the meta model Meta
		/// </summary>
		public virtual void Meta(IMeta _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaDeclaration
		/// </summary>
		public virtual void MetaDeclaration(MetaDeclaration _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaConstant
		/// </summary>
		public virtual void MetaConstant(MetaConstant _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaModel
		/// </summary>
		public virtual void MetaModel(MetaModel _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaNamespace
		/// </summary>
		public virtual void MetaNamespace(MetaNamespace _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaType
		/// </summary>
		public virtual void MetaType(MetaType _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaArrayType
		/// </summary>
		public virtual void MetaArrayType(MetaArrayType _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaClass
		/// </summary>
		public virtual void MetaClass(MetaClass _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaEnum
		/// </summary>
		public virtual void MetaEnum(MetaEnum _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaEnumLiteral
		/// </summary>
		public virtual void MetaEnumLiteral(MetaEnumLiteral _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaNullableType
		/// </summary>
		public virtual void MetaNullableType(MetaNullableType _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaOperation
		/// </summary>
		public virtual void MetaOperation(MetaOperation _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaParameter
		/// </summary>
		public virtual void MetaParameter(MetaParameter _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaPrimitiveType
		/// </summary>
		public virtual void MetaPrimitiveType(MetaPrimitiveType _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaProperty
		/// </summary>
		public virtual void MetaProperty(MetaProperty _this)
		{
		}
	
	
		/// <summary>
		/// Computation of the derived property MetaDeclaration.FullName
		/// </summary>
		public abstract string? MetaDeclaration_FullName(MetaDeclaration _this);
	
		/// <summary>
		/// Computation of the derived property MetaModel.NamespaceName
		/// </summary>
		public abstract string MetaModel_NamespaceName(MetaModel _this);
	
	
	}
}

namespace MetaDslx.Languages.MetaModel.Model.__Impl
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


	internal class MetaDeclaration_Impl : __MetaModelObject, MetaDeclaration
	{
		private MetaDeclaration_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaDeclaration);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaDeclaration_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaDeclarationInfo";
			}
		}
	}

	internal class MetaConstant_Impl : __MetaModelObject, MetaConstant
	{
		private MetaConstant_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaConstant(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public __MetaType Type
		{
			get => MGet<__MetaType>(Meta.MetaConstant_Type);
			set => MAdd<__MetaType>(Meta.MetaConstant_Type, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaConstant_Type);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaConstant_Type, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaConstant_Type, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Type", Meta.MetaConstant_Type);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaConstant_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaConstant_Type, __ImmutableArray.Create<__ModelProperty>(Meta.MetaConstant_Type), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaConstant);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaConstant_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaConstantInfo";
			}
		}
	}

	internal class MetaModel_Impl : __MetaModelObject, MetaModel
	{
		private MetaModel_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaModel(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public string NamespaceName
		{
			get => Meta.__CustomImpl.MetaModel_NamespaceName(this);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("NamespaceName", Meta.MetaModel_NamespaceName);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaModel_NamespaceName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaModel_NamespaceName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaModel);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaModel_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaModelInfo";
			}
		}
	}

	internal class MetaNamespace_Impl : __MetaModelObject, MetaNamespace
	{
		private MetaNamespace_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaNamespace(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaNamespace);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaNamespace_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaNamespaceInfo";
			}
		}
	}

	internal class MetaType_Impl : __MetaModelObject, MetaType
	{
		private MetaType_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaType);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaType_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaTypeInfo";
			}
		}
	}

	internal class MetaArrayType_Impl : __MetaModelObject, MetaArrayType
	{
		private MetaArrayType_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
			Meta.__CustomImpl.MetaArrayType(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public __MetaType ItemType
		{
			get => MGet<__MetaType>(Meta.MetaArrayType_ItemType);
			set => MAdd<__MetaType>(Meta.MetaArrayType_ItemType, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaTypeInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaTypeInfo, Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaArrayType_ItemType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaArrayType_ItemType, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaArrayType_ItemType, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("ItemType", Meta.MetaArrayType_ItemType);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaArrayType_ItemType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaArrayType_ItemType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaArrayType_ItemType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaArrayType);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaArrayType_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaArrayTypeInfo";
			}
		}
	}

	internal class MetaClass_Impl : __MetaModelObject, MetaClass
	{
		private MetaClass_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaClass_BaseTypes, new global::MetaDslx.Modeling.ModelObjectList<MetaClass>(this, __Info.Instance.GetSlot(Meta.MetaClass_BaseTypes)!));
			((__IModelObject)this).Init(Meta.MetaClass_Operations, new global::MetaDslx.Modeling.ModelObjectList<MetaOperation>(this, __Info.Instance.GetSlot(Meta.MetaClass_Operations)!));
			((__IModelObject)this).Init(Meta.MetaClass_Properties, new global::MetaDslx.Modeling.ModelObjectList<MetaProperty>(this, __Info.Instance.GetSlot(Meta.MetaClass_Properties)!));
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
			Meta.__CustomImpl.MetaClass(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaClass> BaseTypes
		{
			get => MGetCollection<MetaClass>(Meta.MetaClass_BaseTypes);
		}
	
		public bool IsAbstract
		{
			get => MGet<bool>(Meta.MetaClass_IsAbstract);
			set => MAdd<bool>(Meta.MetaClass_IsAbstract, value);
		}
	
		public global::System.Collections.Generic.IList<MetaOperation> Operations
		{
			get => MGetCollection<MetaOperation>(Meta.MetaClass_Operations);
		}
	
		public global::System.Collections.Generic.IList<MetaProperty> Properties
		{
			get => MGetCollection<MetaProperty>(Meta.MetaClass_Properties);
		}
	
		public __MetaType? SymbolType
		{
			get => MGet<__MetaType?>(Meta.MetaClass_SymbolType);
			set => MAdd<__MetaType?>(Meta.MetaClass_SymbolType, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaTypeInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaTypeInfo, Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_BaseTypes, Meta.MetaClass_IsAbstract, Meta.MetaClass_Operations, Meta.MetaClass_Properties, Meta.MetaClass_SymbolType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_BaseTypes, Meta.MetaClass_IsAbstract, Meta.MetaClass_Operations, Meta.MetaClass_Properties, Meta.MetaClass_SymbolType, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_BaseTypes, Meta.MetaClass_IsAbstract, Meta.MetaClass_Operations, Meta.MetaClass_Properties, Meta.MetaClass_SymbolType, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("BaseTypes", Meta.MetaClass_BaseTypes);
				publicPropertiesByName.Add("IsAbstract", Meta.MetaClass_IsAbstract);
				publicPropertiesByName.Add("Operations", Meta.MetaClass_Operations);
				publicPropertiesByName.Add("Properties", Meta.MetaClass_Properties);
				publicPropertiesByName.Add("SymbolType", Meta.MetaClass_SymbolType);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaClass_BaseTypes, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_BaseTypes, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_BaseTypes), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaClass_IsAbstract, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_IsAbstract, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_IsAbstract), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaClass_Operations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_Operations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_Operations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaClass_Properties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_Properties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_Properties), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaClass_SymbolType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_SymbolType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_SymbolType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_Operations, Meta.MetaClass_Properties), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaClass);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaClass_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaClassInfo";
			}
		}
	}

	internal class MetaEnum_Impl : __MetaModelObject, MetaEnum
	{
		private MetaEnum_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaEnum_Literals, new global::MetaDslx.Modeling.ModelObjectList<MetaEnumLiteral>(this, __Info.Instance.GetSlot(Meta.MetaEnum_Literals)!));
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
			Meta.__CustomImpl.MetaEnum(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaEnumLiteral> Literals
		{
			get => MGetCollection<MetaEnumLiteral>(Meta.MetaEnum_Literals);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaTypeInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaTypeInfo, Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnum_Literals);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnum_Literals, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnum_Literals, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Literals", Meta.MetaEnum_Literals);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaEnum_Literals, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaEnum_Literals, __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnum_Literals), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnum_Literals), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaEnum);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaEnum_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaEnumInfo";
			}
		}
	}

	internal class MetaEnumLiteral_Impl : __MetaModelObject, MetaEnumLiteral
	{
		private MetaEnumLiteral_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaEnumLiteral(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaEnumLiteral);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaEnumLiteral_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaEnumLiteralInfo";
			}
		}
	}

	internal class MetaNullableType_Impl : __MetaModelObject, MetaNullableType
	{
		private MetaNullableType_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
			Meta.__CustomImpl.MetaNullableType(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public __MetaType InnerType
		{
			get => MGet<__MetaType>(Meta.MetaNullableType_InnerType);
			set => MAdd<__MetaType>(Meta.MetaNullableType_InnerType, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaTypeInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaTypeInfo, Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaNullableType_InnerType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaNullableType_InnerType, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaNullableType_InnerType, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("InnerType", Meta.MetaNullableType_InnerType);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaNullableType_InnerType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNullableType_InnerType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNullableType_InnerType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaNullableType);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaNullableType_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaNullableTypeInfo";
			}
		}
	}

	internal class MetaOperation_Impl : __MetaModelObject, MetaOperation
	{
		private MetaOperation_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaOperation_Parameters, new global::MetaDslx.Modeling.ModelObjectList<MetaParameter>(this, __Info.Instance.GetSlot(Meta.MetaOperation_Parameters)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaOperation(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaParameter> Parameters
		{
			get => MGetCollection<MetaParameter>(Meta.MetaOperation_Parameters);
		}
	
		public __MetaType ReturnType
		{
			get => MGet<__MetaType>(Meta.MetaOperation_ReturnType);
			set => MAdd<__MetaType>(Meta.MetaOperation_ReturnType, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_Parameters, Meta.MetaOperation_ReturnType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_Parameters, Meta.MetaOperation_ReturnType, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_Parameters, Meta.MetaOperation_ReturnType, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Parameters", Meta.MetaOperation_Parameters);
				publicPropertiesByName.Add("ReturnType", Meta.MetaOperation_ReturnType);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaOperation_Parameters, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaOperation_Parameters, __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_Parameters, Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaOperation_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaOperation_ReturnType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaOperation_Parameters, __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_Parameters, Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_Parameters), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaOperation);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaOperation_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaOperationInfo";
			}
		}
	}

	internal class MetaParameter_Impl : __MetaModelObject, MetaParameter
	{
		private MetaParameter_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaParameter(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public __MetaType Type
		{
			get => MGet<__MetaType>(Meta.MetaParameter_Type);
			set => MAdd<__MetaType>(Meta.MetaParameter_Type, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaParameter_Type);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaParameter_Type, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaParameter_Type, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Type", Meta.MetaParameter_Type);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaParameter_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaParameter_Type, __ImmutableArray.Create<__ModelProperty>(Meta.MetaParameter_Type), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaParameter);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaParameter_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaParameterInfo";
			}
		}
	}

	internal class MetaPrimitiveType_Impl : __MetaModelObject, MetaPrimitiveType
	{
		private MetaPrimitiveType_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
			Meta.__CustomImpl.MetaPrimitiveType(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaTypeInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaTypeInfo, Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaPrimitiveType);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaPrimitiveType_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaPrimitiveTypeInfo";
			}
		}
	}

	internal class MetaProperty_Impl : __MetaModelObject, MetaProperty
	{
		private MetaProperty_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaProperty_OppositeProperties, new global::MetaDslx.Modeling.ModelObjectList<MetaProperty>(this, __Info.Instance.GetSlot(Meta.MetaProperty_OppositeProperties)!));
			((__IModelObject)this).Init(Meta.MetaProperty_RedefinedProperties, new global::MetaDslx.Modeling.ModelObjectList<MetaProperty>(this, __Info.Instance.GetSlot(Meta.MetaProperty_RedefinedProperties)!));
			((__IModelObject)this).Init(Meta.MetaProperty_SubsettedProperties, new global::MetaDslx.Modeling.ModelObjectList<MetaProperty>(this, __Info.Instance.GetSlot(Meta.MetaProperty_SubsettedProperties)!));
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaProperty(this);
		}
	
		public override __ModelClassInfo MInfo => __Info.Instance;
	
		public bool IsContainment
		{
			get => MGet<bool>(Meta.MetaProperty_IsContainment);
			set => MAdd<bool>(Meta.MetaProperty_IsContainment, value);
		}
	
		public bool IsDerived
		{
			get => MGet<bool>(Meta.MetaProperty_IsDerived);
			set => MAdd<bool>(Meta.MetaProperty_IsDerived, value);
		}
	
		public global::System.Collections.Generic.IList<MetaProperty> OppositeProperties
		{
			get => MGetCollection<MetaProperty>(Meta.MetaProperty_OppositeProperties);
		}
	
		public global::System.Collections.Generic.IList<MetaProperty> RedefinedProperties
		{
			get => MGetCollection<MetaProperty>(Meta.MetaProperty_RedefinedProperties);
		}
	
		public global::System.Collections.Generic.IList<MetaProperty> SubsettedProperties
		{
			get => MGetCollection<MetaProperty>(Meta.MetaProperty_SubsettedProperties);
		}
	
		public string? SymbolProperty
		{
			get => MGet<string?>(Meta.MetaProperty_SymbolProperty);
			set => MAdd<string?>(Meta.MetaProperty_SymbolProperty, value);
		}
	
		public __MetaType Type
		{
			get => MGet<__MetaType>(Meta.MetaProperty_Type);
			set => MAdd<__MetaType>(Meta.MetaProperty_Type, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string? FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string? Name
		{
			get => MGet<string?>(Meta.MetaDeclaration_Name);
			set => MAdd<string?>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration? Parent
		{
			get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_OppositeProperties, Meta.MetaProperty_RedefinedProperties, Meta.MetaProperty_SubsettedProperties, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_Type);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_OppositeProperties, Meta.MetaProperty_RedefinedProperties, Meta.MetaProperty_SubsettedProperties, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_Type, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_OppositeProperties, Meta.MetaProperty_RedefinedProperties, Meta.MetaProperty_SubsettedProperties, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_Type, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("IsContainment", Meta.MetaProperty_IsContainment);
				publicPropertiesByName.Add("IsDerived", Meta.MetaProperty_IsDerived);
				publicPropertiesByName.Add("OppositeProperties", Meta.MetaProperty_OppositeProperties);
				publicPropertiesByName.Add("RedefinedProperties", Meta.MetaProperty_RedefinedProperties);
				publicPropertiesByName.Add("SubsettedProperties", Meta.MetaProperty_SubsettedProperties);
				publicPropertiesByName.Add("SymbolProperty", Meta.MetaProperty_SymbolProperty);
				publicPropertiesByName.Add("Type", Meta.MetaProperty_Type);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaProperty_IsContainment, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_IsContainment, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsContainment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaProperty_IsDerived, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_IsDerived, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsDerived), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaProperty_OppositeProperties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_OppositeProperties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_OppositeProperties), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_OppositeProperties), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaProperty_RedefinedProperties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_RedefinedProperties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_RedefinedProperties), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaProperty_SubsettedProperties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_SubsettedProperties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_SubsettedProperties), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaProperty_SymbolProperty, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_SymbolProperty, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_SymbolProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaProperty_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_Type, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_Type), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.MInstance;
	        public override __MetaType MetaType => typeof(MetaProperty);
	
	        public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaProperty_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaPropertyInfo";
			}
		}
	}

}
