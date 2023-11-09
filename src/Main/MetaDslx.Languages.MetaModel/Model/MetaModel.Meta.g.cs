namespace MetaDslx.Languages.MetaModel.Model
{
	using __MetaMetaModel = global::MetaDslx.Languages.MetaModel.Model.Meta;
	using __MetaModelFactory = global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;
	using __Model = global::MetaDslx.Modeling.Model;
	using __MetaModel = global::MetaDslx.Modeling.MetaModel;
	using __IModelObject = global::MetaDslx.Modeling.IModelObject;
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

	internal interface IMeta
	{
		MetaPrimitiveType VoidType { get; }
		MetaPrimitiveType BoolType { get; }
		MetaPrimitiveType IntType { get; }
		MetaPrimitiveType StringType { get; }
		MetaPrimitiveType TypeType { get; }
	}
	
	public sealed class Meta : __MetaModel, IMeta
	{
		// If there is an error at the following line, create a new class called 'CustomMetaImplementation'
		// inheriting from the class 'CustomMetaImplementationBase' and provide the custom implementation
		// for the derived properties and operations defined in the metamodel
		internal static readonly CustomMetaImplementationBase __CustomImpl = new CustomMetaImplementation();
	
		private static readonly Meta _instance;
		public static Meta Instance => _instance;
	
		private static readonly __ModelProperty _MetaDeclaration_Name;
		private static readonly __ModelProperty _MetaDeclaration_Parent;
		private static readonly __ModelProperty _MetaDeclaration_Declarations;
		private static readonly __ModelProperty _MetaDeclaration_FullName;
		private static readonly __ModelProperty _MetaModel_NamespaceName;
		private static readonly __ModelProperty _MetaConstant_Type;
		private static readonly __ModelProperty _MetaNullableType_InnerType;
		private static readonly __ModelProperty _MetaArrayType_ItemType;
		private static readonly __ModelProperty _MetaEnumType_Literals;
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
			_MetaDeclaration_FullName = new __ModelProperty(typeof(MetaDeclaration), "FullName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_MetaDeclaration_Name = new __ModelProperty(typeof(MetaDeclaration), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.Name, "Name");
			_MetaDeclaration_Parent = new __ModelProperty(typeof(MetaDeclaration), "Parent", typeof(MetaDeclaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_MetaModel_NamespaceName = new __ModelProperty(typeof(MetaModel), "NamespaceName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_MetaConstant_Type = new __ModelProperty(typeof(MetaConstant), "Type", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaNullableType_InnerType = new __ModelProperty(typeof(MetaNullableType), "InnerType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaArrayType_ItemType = new __ModelProperty(typeof(MetaArrayType), "ItemType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaEnumType_Literals = new __ModelProperty(typeof(MetaEnumType), "Literals", typeof(MetaEnumLiteral), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaClass_BaseTypes = new __ModelProperty(typeof(MetaClass), "BaseTypes", typeof(MetaClass), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_MetaClass_IsAbstract = new __ModelProperty(typeof(MetaClass), "IsAbstract", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaClass_Operations = new __ModelProperty(typeof(MetaClass), "Operations", typeof(MetaOperation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaClass_Properties = new __ModelProperty(typeof(MetaClass), "Properties", typeof(MetaProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaClass_SymbolType = new __ModelProperty(typeof(MetaClass), "SymbolType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_IsContainment = new __ModelProperty(typeof(MetaProperty), "IsContainment", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_IsDerived = new __ModelProperty(typeof(MetaProperty), "IsDerived", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_OppositeProperties = new __ModelProperty(typeof(MetaProperty), "OppositeProperties", typeof(MetaProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_MetaProperty_RedefinedProperties = new __ModelProperty(typeof(MetaProperty), "RedefinedProperties", typeof(MetaProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_MetaProperty_SubsettedProperties = new __ModelProperty(typeof(MetaProperty), "SubsettedProperties", typeof(MetaProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_MetaProperty_SymbolProperty = new __ModelProperty(typeof(MetaProperty), "SymbolProperty", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_Type = new __ModelProperty(typeof(MetaProperty), "Type", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaOperation_Parameters = new __ModelProperty(typeof(MetaOperation), "Parameters", typeof(MetaParameter), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaOperation_ReturnType = new __ModelProperty(typeof(MetaOperation), "ReturnType", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaParameter_Type = new __ModelProperty(typeof(MetaParameter), "Type", typeof(__MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_instance = new Meta();
		}
	
		private readonly __Model _model;
		private readonly global::System.Collections.Immutable.ImmutableArray<__Type> _modelObjectTypes;
		private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _modelObjectInfos;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<__Type, __ModelObjectInfo> _modelObjectInfosByType;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelObjectInfo> _modelObjectInfosByName;
	
		private readonly MetaPrimitiveType _voidType;
		private readonly MetaPrimitiveType _boolType;
		private readonly MetaPrimitiveType _intType;
		private readonly MetaPrimitiveType _stringType;
		private readonly MetaPrimitiveType _typeType;
	
		private Meta()
		{
			_modelObjectTypes = __ImmutableArray.Create<__Type>(typeof(MetaDeclaration), typeof(MetaNamespace), typeof(MetaModel), typeof(MetaConstant), typeof(MetaType), typeof(MetaPrimitiveType), typeof(MetaNullableType), typeof(MetaArrayType), typeof(MetaEnumType), typeof(MetaEnumLiteral), typeof(MetaClass), typeof(MetaProperty), typeof(MetaOperation), typeof(MetaParameter));
			_modelObjectInfos = __ImmutableArray.Create<__ModelObjectInfo>(MetaDeclarationInfo, MetaNamespaceInfo, MetaModelInfo, MetaConstantInfo, MetaTypeInfo, MetaPrimitiveTypeInfo, MetaNullableTypeInfo, MetaArrayTypeInfo, MetaEnumTypeInfo, MetaEnumLiteralInfo, MetaClassInfo, MetaPropertyInfo, MetaOperationInfo, MetaParameterInfo);
			var modelObjectInfosByType = __ImmutableDictionary.CreateBuilder<__Type, __ModelObjectInfo>();
			modelObjectInfosByType.Add(typeof(MetaDeclaration), MetaDeclarationInfo);
			modelObjectInfosByType.Add(typeof(MetaNamespace), MetaNamespaceInfo);
			modelObjectInfosByType.Add(typeof(MetaModel), MetaModelInfo);
			modelObjectInfosByType.Add(typeof(MetaConstant), MetaConstantInfo);
			modelObjectInfosByType.Add(typeof(MetaType), MetaTypeInfo);
			modelObjectInfosByType.Add(typeof(MetaPrimitiveType), MetaPrimitiveTypeInfo);
			modelObjectInfosByType.Add(typeof(MetaNullableType), MetaNullableTypeInfo);
			modelObjectInfosByType.Add(typeof(MetaArrayType), MetaArrayTypeInfo);
			modelObjectInfosByType.Add(typeof(MetaEnumType), MetaEnumTypeInfo);
			modelObjectInfosByType.Add(typeof(MetaEnumLiteral), MetaEnumLiteralInfo);
			modelObjectInfosByType.Add(typeof(MetaClass), MetaClassInfo);
			modelObjectInfosByType.Add(typeof(MetaProperty), MetaPropertyInfo);
			modelObjectInfosByType.Add(typeof(MetaOperation), MetaOperationInfo);
			modelObjectInfosByType.Add(typeof(MetaParameter), MetaParameterInfo);
			_modelObjectInfosByType = modelObjectInfosByType.ToImmutable();
			var modelObjectInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelObjectInfo>();
			modelObjectInfosByName.Add("MetaDeclaration", MetaDeclarationInfo);
			modelObjectInfosByName.Add("MetaNamespace", MetaNamespaceInfo);
			modelObjectInfosByName.Add("MetaModel", MetaModelInfo);
			modelObjectInfosByName.Add("MetaConstant", MetaConstantInfo);
			modelObjectInfosByName.Add("MetaType", MetaTypeInfo);
			modelObjectInfosByName.Add("MetaPrimitiveType", MetaPrimitiveTypeInfo);
			modelObjectInfosByName.Add("MetaNullableType", MetaNullableTypeInfo);
			modelObjectInfosByName.Add("MetaArrayType", MetaArrayTypeInfo);
			modelObjectInfosByName.Add("MetaEnumType", MetaEnumTypeInfo);
			modelObjectInfosByName.Add("MetaEnumLiteral", MetaEnumLiteralInfo);
			modelObjectInfosByName.Add("MetaClass", MetaClassInfo);
			modelObjectInfosByName.Add("MetaProperty", MetaPropertyInfo);
			modelObjectInfosByName.Add("MetaOperation", MetaOperationInfo);
			modelObjectInfosByName.Add("MetaParameter", MetaParameterInfo);
			_modelObjectInfosByName = modelObjectInfosByName.ToImmutable();
			_model = new __Model();
			var f = new __MetaModelFactory(_model);
			_voidType = f.MetaPrimitiveType();
			_boolType = f.MetaPrimitiveType();
			_intType = f.MetaPrimitiveType();
			_stringType = f.MetaPrimitiveType();
			_typeType = f.MetaPrimitiveType();
			var obj1 = f.MetaNamespace();
			var obj2 = f.MetaNamespace();
			var obj3 = f.MetaNamespace();
			var obj4 = f.MetaNamespace();
			var obj5 = f.MetaNamespace();
			var obj6 = f.MetaModel();
			var obj7 = f.MetaConstant();
			var obj8 = f.MetaConstant();
			var obj9 = f.MetaConstant();
			var obj10 = f.MetaConstant();
			var obj11 = f.MetaConstant();
			var obj12 = f.MetaClass();
			var obj13 = f.MetaClass();
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
			var obj36 = f.MetaArrayType();
			var obj37 = f.MetaProperty();
			var obj38 = f.MetaProperty();
			var obj39 = f.MetaProperty();
			var obj40 = f.MetaProperty();
			var obj41 = f.MetaProperty();
			var obj42 = f.MetaArrayType();
			var obj43 = f.MetaArrayType();
			var obj44 = f.MetaArrayType();
			var obj45 = f.MetaProperty();
			var obj46 = f.MetaProperty();
			var obj47 = f.MetaProperty();
			var obj48 = f.MetaProperty();
			var obj49 = f.MetaProperty();
			var obj50 = f.MetaProperty();
			var obj51 = f.MetaProperty();
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
			((__IModelObject)obj5).Children.Add((__IModelObject)obj21);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj22);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj23);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj24);
			((__IModelObject)obj5).Children.Add((__IModelObject)obj25);
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
			obj5.Name = "Model";
			obj5.Parent = obj4;
			obj6.Name = "Meta";
			obj6.Parent = obj5;
			obj7.Type = __MetaType.FromModelObject((__IModelObject)obj17);
			obj7.Name = "VoidType";
			obj7.Parent = obj5;
			obj8.Type = __MetaType.FromModelObject((__IModelObject)obj17);
			obj8.Name = "BoolType";
			obj8.Parent = obj5;
			obj9.Type = __MetaType.FromModelObject((__IModelObject)obj17);
			obj9.Name = "IntType";
			obj9.Parent = obj5;
			obj10.Type = __MetaType.FromModelObject((__IModelObject)obj17);
			obj10.Name = "StringType";
			obj10.Parent = obj5;
			obj11.Type = __MetaType.FromModelObject((__IModelObject)obj17);
			obj11.Name = "TypeType";
			obj11.Parent = obj5;
			((__IModelObject)obj12).Children.Add((__IModelObject)obj26);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj27);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj28);
			((__IModelObject)obj12).Children.Add((__IModelObject)obj29);
			obj12.Properties.Add(obj26);
			obj12.Properties.Add(obj27);
			obj12.Properties.Add(obj28);
			obj12.Properties.Add(obj29);
			obj12.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
			obj12.Declarations.Add(obj26);
			obj12.Declarations.Add(obj27);
			obj12.Declarations.Add(obj28);
			obj12.Declarations.Add(obj29);
			obj12.Name = "MetaDeclaration";
			obj12.Parent = obj5;
			obj13.BaseTypes.Add(obj12);
			obj13.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
			obj13.Name = "MetaNamespace";
			obj13.Parent = obj5;
			((__IModelObject)obj14).Children.Add((__IModelObject)obj31);
			obj14.BaseTypes.Add(obj12);
			obj14.Properties.Add(obj31);
			obj14.Declarations.Add(obj31);
			obj14.Name = "MetaModel";
			obj14.Parent = obj5;
			((__IModelObject)obj15).Children.Add((__IModelObject)obj32);
			obj15.BaseTypes.Add(obj12);
			obj15.Properties.Add(obj32);
			obj15.Declarations.Add(obj32);
			obj15.Name = "MetaConstant";
			obj15.Parent = obj5;
			obj16.BaseTypes.Add(obj12);
			obj16.IsAbstract = true;
			obj16.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
			obj16.Name = "MetaType";
			obj16.Parent = obj5;
			obj17.BaseTypes.Add(obj16);
			obj17.Name = "MetaPrimitiveType";
			obj17.Parent = obj5;
			((__IModelObject)obj18).Children.Add((__IModelObject)obj33);
			obj18.BaseTypes.Add(obj16);
			obj18.Properties.Add(obj33);
			obj18.Declarations.Add(obj33);
			obj18.Name = "MetaNullableType";
			obj18.Parent = obj5;
			((__IModelObject)obj19).Children.Add((__IModelObject)obj34);
			obj19.BaseTypes.Add(obj16);
			obj19.Properties.Add(obj34);
			obj19.Declarations.Add(obj34);
			obj19.Name = "MetaArrayType";
			obj19.Parent = obj5;
			((__IModelObject)obj20).Children.Add((__IModelObject)obj35);
			obj20.BaseTypes.Add(obj16);
			obj20.Properties.Add(obj35);
			obj20.Declarations.Add(obj35);
			obj20.Name = "MetaEnumType";
			obj20.Parent = obj5;
			obj21.BaseTypes.Add(obj12);
			obj21.Name = "MetaEnumLiteral";
			obj21.Parent = obj5;
			((__IModelObject)obj22).Children.Add((__IModelObject)obj37);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj38);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj39);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj40);
			((__IModelObject)obj22).Children.Add((__IModelObject)obj41);
			obj22.BaseTypes.Add(obj16);
			obj22.Properties.Add(obj37);
			obj22.Properties.Add(obj38);
			obj22.Properties.Add(obj39);
			obj22.Properties.Add(obj40);
			obj22.Properties.Add(obj41);
			obj22.Declarations.Add(obj37);
			obj22.Declarations.Add(obj38);
			obj22.Declarations.Add(obj39);
			obj22.Declarations.Add(obj40);
			obj22.Declarations.Add(obj41);
			obj22.Name = "MetaClass";
			obj22.Parent = obj5;
			((__IModelObject)obj23).Children.Add((__IModelObject)obj45);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj46);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj47);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj48);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj49);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj50);
			((__IModelObject)obj23).Children.Add((__IModelObject)obj51);
			obj23.BaseTypes.Add(obj12);
			obj23.Properties.Add(obj45);
			obj23.Properties.Add(obj46);
			obj23.Properties.Add(obj47);
			obj23.Properties.Add(obj48);
			obj23.Properties.Add(obj49);
			obj23.Properties.Add(obj50);
			obj23.Properties.Add(obj51);
			obj23.Declarations.Add(obj45);
			obj23.Declarations.Add(obj46);
			obj23.Declarations.Add(obj47);
			obj23.Declarations.Add(obj48);
			obj23.Declarations.Add(obj49);
			obj23.Declarations.Add(obj50);
			obj23.Declarations.Add(obj51);
			obj23.Name = "MetaProperty";
			obj23.Parent = obj5;
			((__IModelObject)obj24).Children.Add((__IModelObject)obj55);
			((__IModelObject)obj24).Children.Add((__IModelObject)obj56);
			obj24.BaseTypes.Add(obj12);
			obj24.Properties.Add(obj55);
			obj24.Properties.Add(obj56);
			obj24.Declarations.Add(obj55);
			obj24.Declarations.Add(obj56);
			obj24.Name = "MetaOperation";
			obj24.Parent = obj5;
			((__IModelObject)obj25).Children.Add((__IModelObject)obj58);
			obj25.BaseTypes.Add(obj12);
			obj25.Properties.Add(obj58);
			obj25.Declarations.Add(obj58);
			obj25.Name = "MetaParameter";
			obj25.Parent = obj5;
			obj26.SymbolProperty = "Name";
			obj26.Type = typeof(string);
			obj26.Name = "Name";
			obj26.Parent = obj12;
			obj27.OppositeProperties.Add(obj28);
			obj27.Type = __MetaType.FromModelObject((__IModelObject)obj12);
			obj27.Name = "Parent";
			obj27.Parent = obj12;
			((__IModelObject)obj28).Children.Add((__IModelObject)obj30);
			obj28.IsContainment = true;
			obj28.OppositeProperties.Add(obj27);
			obj28.Type = __MetaType.FromModelObject((__IModelObject)obj30);
			obj28.Name = "Declarations";
			obj28.Parent = obj12;
			obj29.IsDerived = true;
			obj29.Type = typeof(string);
			obj29.Name = "FullName";
			obj29.Parent = obj12;
			obj30.ItemType = __MetaType.FromModelObject((__IModelObject)obj12);
			obj31.IsDerived = true;
			obj31.Type = typeof(string);
			obj31.Name = "NamespaceName";
			obj31.Parent = obj14;
			obj32.Type = typeof(__MetaType);
			obj32.Name = "Type";
			obj32.Parent = obj15;
			obj33.Type = typeof(__MetaType);
			obj33.Name = "InnerType";
			obj33.Parent = obj18;
			obj34.Type = typeof(__MetaType);
			obj34.Name = "ItemType";
			obj34.Parent = obj19;
			((__IModelObject)obj35).Children.Add((__IModelObject)obj36);
			obj35.IsContainment = true;
			obj35.SubsettedProperties.Add(obj28);
			obj35.Type = __MetaType.FromModelObject((__IModelObject)obj36);
			obj35.Name = "Literals";
			obj35.Parent = obj20;
			obj36.ItemType = __MetaType.FromModelObject((__IModelObject)obj21);
			obj37.Type = typeof(__MetaType);
			obj37.Name = "SymbolType";
			obj37.Parent = obj22;
			obj38.Type = typeof(bool);
			obj38.Name = "IsAbstract";
			obj38.Parent = obj22;
			((__IModelObject)obj39).Children.Add((__IModelObject)obj42);
			obj39.Type = __MetaType.FromModelObject((__IModelObject)obj42);
			obj39.Name = "BaseTypes";
			obj39.Parent = obj22;
			((__IModelObject)obj40).Children.Add((__IModelObject)obj43);
			obj40.IsContainment = true;
			obj40.SubsettedProperties.Add(obj28);
			obj40.Type = __MetaType.FromModelObject((__IModelObject)obj43);
			obj40.Name = "Properties";
			obj40.Parent = obj22;
			((__IModelObject)obj41).Children.Add((__IModelObject)obj44);
			obj41.IsContainment = true;
			obj41.SubsettedProperties.Add(obj28);
			obj41.Type = __MetaType.FromModelObject((__IModelObject)obj44);
			obj41.Name = "Operations";
			obj41.Parent = obj22;
			obj42.ItemType = __MetaType.FromModelObject((__IModelObject)obj22);
			obj43.ItemType = __MetaType.FromModelObject((__IModelObject)obj23);
			obj44.ItemType = __MetaType.FromModelObject((__IModelObject)obj24);
			obj45.Type = typeof(__MetaType);
			obj45.Name = "Type";
			obj45.Parent = obj23;
			obj46.Type = typeof(string);
			obj46.Name = "SymbolProperty";
			obj46.Parent = obj23;
			obj47.Type = typeof(bool);
			obj47.Name = "IsContainment";
			obj47.Parent = obj23;
			obj48.Type = typeof(bool);
			obj48.Name = "IsDerived";
			obj48.Parent = obj23;
			((__IModelObject)obj49).Children.Add((__IModelObject)obj52);
			obj49.OppositeProperties.Add(obj49);
			obj49.Type = __MetaType.FromModelObject((__IModelObject)obj52);
			obj49.Name = "OppositeProperties";
			obj49.Parent = obj23;
			((__IModelObject)obj50).Children.Add((__IModelObject)obj53);
			obj50.Type = __MetaType.FromModelObject((__IModelObject)obj53);
			obj50.Name = "SubsettedProperties";
			obj50.Parent = obj23;
			((__IModelObject)obj51).Children.Add((__IModelObject)obj54);
			obj51.Type = __MetaType.FromModelObject((__IModelObject)obj54);
			obj51.Name = "RedefinedProperties";
			obj51.Parent = obj23;
			obj52.ItemType = __MetaType.FromModelObject((__IModelObject)obj23);
			obj53.ItemType = __MetaType.FromModelObject((__IModelObject)obj23);
			obj54.ItemType = __MetaType.FromModelObject((__IModelObject)obj23);
			obj55.Type = typeof(__MetaType);
			obj55.Name = "ReturnType";
			obj55.Parent = obj24;
			((__IModelObject)obj56).Children.Add((__IModelObject)obj57);
			obj56.IsContainment = true;
			obj56.RedefinedProperties.Add(obj28);
			obj56.Type = __MetaType.FromModelObject((__IModelObject)obj57);
			obj56.Name = "Parameters";
			obj56.Parent = obj24;
			obj57.ItemType = __MetaType.FromModelObject((__IModelObject)obj25);
			obj58.Type = typeof(__MetaType);
			obj58.Name = "Type";
			obj58.Parent = obj25;
			_model.IsSealed = true;
		}
	
	    public override string Name => nameof(Meta);
	    public override string Namespace => "MetaDslx.Languages.MetaModel.Model";
	    public override __ModelVersion Version => default;
	    public override string Uri => "MetaDslx.Languages.MetaModel.Model.Meta";
	    public override string Prefix => "m";
		public override __Model Model => _model;
	
		public override global::System.Collections.Immutable.ImmutableArray<__Type> ModelObjectTypes => _modelObjectTypes;
		public override global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> ModelObjectInfos => _modelObjectInfos;
	
	    public override bool Contains(__Type modelObjectType) => _modelObjectInfosByType.ContainsKey(modelObjectType);
	    public override bool Contains(string modelObjectTypeName) => _modelObjectInfosByName.ContainsKey(modelObjectTypeName);
	
	    public override bool TryGetInfo(__Type modelObjectType, out __ModelObjectInfo? info) => _modelObjectInfosByType.TryGetValue(modelObjectType, out info);
	    public override bool TryGetInfo(string modelObjectTypeName, out __ModelObjectInfo? info) => _modelObjectInfosByName.TryGetValue(modelObjectTypeName, out info);
	
		MetaPrimitiveType IMeta.VoidType => _voidType;
		MetaPrimitiveType IMeta.BoolType => _boolType;
		MetaPrimitiveType IMeta.IntType => _intType;
		MetaPrimitiveType IMeta.StringType => _stringType;
		MetaPrimitiveType IMeta.TypeType => _typeType;
	
		public static MetaPrimitiveType VoidType => ((IMeta)Instance).VoidType;
		public static MetaPrimitiveType BoolType => ((IMeta)Instance).BoolType;
		public static MetaPrimitiveType IntType => ((IMeta)Instance).IntType;
		public static MetaPrimitiveType StringType => ((IMeta)Instance).StringType;
		public static MetaPrimitiveType TypeType => ((IMeta)Instance).TypeType;
	
		public static __ModelObjectInfo MetaDeclarationInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaDeclaration_Impl.__Info.Instance;
		public static __ModelProperty MetaDeclaration_Name => _MetaDeclaration_Name;
		public static __ModelProperty MetaDeclaration_Parent => _MetaDeclaration_Parent;
		public static __ModelProperty MetaDeclaration_Declarations => _MetaDeclaration_Declarations;
		public static __ModelProperty MetaDeclaration_FullName => _MetaDeclaration_FullName;
		public static __ModelObjectInfo MetaNamespaceInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaNamespace_Impl.__Info.Instance;
		public static __ModelObjectInfo MetaModelInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaModel_Impl.__Info.Instance;
		public static __ModelProperty MetaModel_NamespaceName => _MetaModel_NamespaceName;
		public static __ModelObjectInfo MetaConstantInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaConstant_Impl.__Info.Instance;
		public static __ModelProperty MetaConstant_Type => _MetaConstant_Type;
		public static __ModelObjectInfo MetaTypeInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaType_Impl.__Info.Instance;
		public static __ModelObjectInfo MetaPrimitiveTypeInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaPrimitiveType_Impl.__Info.Instance;
		public static __ModelObjectInfo MetaNullableTypeInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaNullableType_Impl.__Info.Instance;
		public static __ModelProperty MetaNullableType_InnerType => _MetaNullableType_InnerType;
		public static __ModelObjectInfo MetaArrayTypeInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaArrayType_Impl.__Info.Instance;
		public static __ModelProperty MetaArrayType_ItemType => _MetaArrayType_ItemType;
		public static __ModelObjectInfo MetaEnumTypeInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaEnumType_Impl.__Info.Instance;
		public static __ModelProperty MetaEnumType_Literals => _MetaEnumType_Literals;
		public static __ModelObjectInfo MetaEnumLiteralInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaEnumLiteral_Impl.__Info.Instance;
		public static __ModelObjectInfo MetaClassInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaClass_Impl.__Info.Instance;
		public static __ModelProperty MetaClass_SymbolType => _MetaClass_SymbolType;
		public static __ModelProperty MetaClass_IsAbstract => _MetaClass_IsAbstract;
		public static __ModelProperty MetaClass_BaseTypes => _MetaClass_BaseTypes;
		public static __ModelProperty MetaClass_Properties => _MetaClass_Properties;
		public static __ModelProperty MetaClass_Operations => _MetaClass_Operations;
		public static __ModelObjectInfo MetaPropertyInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaProperty_Impl.__Info.Instance;
		public static __ModelProperty MetaProperty_Type => _MetaProperty_Type;
		public static __ModelProperty MetaProperty_SymbolProperty => _MetaProperty_SymbolProperty;
		public static __ModelProperty MetaProperty_IsContainment => _MetaProperty_IsContainment;
		public static __ModelProperty MetaProperty_IsDerived => _MetaProperty_IsDerived;
		public static __ModelProperty MetaProperty_OppositeProperties => _MetaProperty_OppositeProperties;
		public static __ModelProperty MetaProperty_SubsettedProperties => _MetaProperty_SubsettedProperties;
		public static __ModelProperty MetaProperty_RedefinedProperties => _MetaProperty_RedefinedProperties;
		public static __ModelObjectInfo MetaOperationInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaOperation_Impl.__Info.Instance;
		public static __ModelProperty MetaOperation_ReturnType => _MetaOperation_ReturnType;
		public static __ModelProperty MetaOperation_Parameters => _MetaOperation_Parameters;
		public static __ModelObjectInfo MetaParameterInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaParameter_Impl.__Info.Instance;
		public static __ModelProperty MetaParameter_Type => _MetaParameter_Type;
	}
	
	public class MetaModelFactory : __ModelFactory
	{
		public MetaModelFactory(__Model model)
			: base(model, Meta.Instance)
		{
		}
	
		public MetaDeclaration MetaDeclaration(string? id = null)
		{
			return (MetaDeclaration)Meta.MetaDeclarationInfo.Create(Model, id)!;
		}
	
		public MetaNamespace MetaNamespace(string? id = null)
		{
			return (MetaNamespace)Meta.MetaNamespaceInfo.Create(Model, id)!;
		}
	
		public MetaModel MetaModel(string? id = null)
		{
			return (MetaModel)Meta.MetaModelInfo.Create(Model, id)!;
		}
	
		public MetaConstant MetaConstant(string? id = null)
		{
			return (MetaConstant)Meta.MetaConstantInfo.Create(Model, id)!;
		}
	
		public MetaPrimitiveType MetaPrimitiveType(string? id = null)
		{
			return (MetaPrimitiveType)Meta.MetaPrimitiveTypeInfo.Create(Model, id)!;
		}
	
		public MetaNullableType MetaNullableType(string? id = null)
		{
			return (MetaNullableType)Meta.MetaNullableTypeInfo.Create(Model, id)!;
		}
	
		public MetaArrayType MetaArrayType(string? id = null)
		{
			return (MetaArrayType)Meta.MetaArrayTypeInfo.Create(Model, id)!;
		}
	
		public MetaEnumType MetaEnumType(string? id = null)
		{
			return (MetaEnumType)Meta.MetaEnumTypeInfo.Create(Model, id)!;
		}
	
		public MetaEnumLiteral MetaEnumLiteral(string? id = null)
		{
			return (MetaEnumLiteral)Meta.MetaEnumLiteralInfo.Create(Model, id)!;
		}
	
		public MetaClass MetaClass(string? id = null)
		{
			return (MetaClass)Meta.MetaClassInfo.Create(Model, id)!;
		}
	
		public MetaProperty MetaProperty(string? id = null)
		{
			return (MetaProperty)Meta.MetaPropertyInfo.Create(Model, id)!;
		}
	
		public MetaOperation MetaOperation(string? id = null)
		{
			return (MetaOperation)Meta.MetaOperationInfo.Create(Model, id)!;
		}
	
		public MetaParameter MetaParameter(string? id = null)
		{
			return (MetaParameter)Meta.MetaParameterInfo.Create(Model, id)!;
		}
	
	}
	
	public class MetaModelMultiFactory : __MultiModelFactory
	{
		public MetaModelMultiFactory()
			: base(new __MetaModel[] { Meta.Instance })
		{
		}
	
		public MetaDeclaration MetaDeclaration(__Model model, string? id = null)
		{
			return (MetaDeclaration)Meta.MetaDeclarationInfo.Create(model, id)!;
		}
	
		public MetaNamespace MetaNamespace(__Model model, string? id = null)
		{
			return (MetaNamespace)Meta.MetaNamespaceInfo.Create(model, id)!;
		}
	
		public MetaModel MetaModel(__Model model, string? id = null)
		{
			return (MetaModel)Meta.MetaModelInfo.Create(model, id)!;
		}
	
		public MetaConstant MetaConstant(__Model model, string? id = null)
		{
			return (MetaConstant)Meta.MetaConstantInfo.Create(model, id)!;
		}
	
		public MetaPrimitiveType MetaPrimitiveType(__Model model, string? id = null)
		{
			return (MetaPrimitiveType)Meta.MetaPrimitiveTypeInfo.Create(model, id)!;
		}
	
		public MetaNullableType MetaNullableType(__Model model, string? id = null)
		{
			return (MetaNullableType)Meta.MetaNullableTypeInfo.Create(model, id)!;
		}
	
		public MetaArrayType MetaArrayType(__Model model, string? id = null)
		{
			return (MetaArrayType)Meta.MetaArrayTypeInfo.Create(model, id)!;
		}
	
		public MetaEnumType MetaEnumType(__Model model, string? id = null)
		{
			return (MetaEnumType)Meta.MetaEnumTypeInfo.Create(model, id)!;
		}
	
		public MetaEnumLiteral MetaEnumLiteral(__Model model, string? id = null)
		{
			return (MetaEnumLiteral)Meta.MetaEnumLiteralInfo.Create(model, id)!;
		}
	
		public MetaClass MetaClass(__Model model, string? id = null)
		{
			return (MetaClass)Meta.MetaClassInfo.Create(model, id)!;
		}
	
		public MetaProperty MetaProperty(__Model model, string? id = null)
		{
			return (MetaProperty)Meta.MetaPropertyInfo.Create(model, id)!;
		}
	
		public MetaOperation MetaOperation(__Model model, string? id = null)
		{
			return (MetaOperation)Meta.MetaOperationInfo.Create(model, id)!;
		}
	
		public MetaParameter MetaParameter(__Model model, string? id = null)
		{
			return (MetaParameter)Meta.MetaParameterInfo.Create(model, id)!;
		}
	
	}
	


	public interface MetaDeclaration
	{
		global::System.Collections.Generic.IList<MetaDeclaration> Declarations { get; }
		string FullName { get; }
		string Name { get; set; }
		MetaDeclaration Parent { get; set; }
	
	}

	public interface MetaNamespace : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
	
	}

	public interface MetaModel : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		string NamespaceName { get; }
	
	}

	public interface MetaConstant : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		__MetaType Type { get; set; }
	
	}

	public interface MetaType : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
	
	}

	public interface MetaPrimitiveType : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
	
	}

	public interface MetaNullableType : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
		__MetaType InnerType { get; set; }
	
	}

	public interface MetaArrayType : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
		__MetaType ItemType { get; set; }
	
	}

	public interface MetaEnumType : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
		global::System.Collections.Generic.IList<MetaEnumLiteral> Literals { get; }
	
	}

	public interface MetaEnumLiteral : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
	
	}

	public interface MetaClass : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
		global::System.Collections.Generic.IList<MetaClass> BaseTypes { get; }
		bool IsAbstract { get; set; }
		global::System.Collections.Generic.IList<MetaOperation> Operations { get; }
		global::System.Collections.Generic.IList<MetaProperty> Properties { get; }
		__MetaType SymbolType { get; set; }
	
	}

	public interface MetaProperty : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		bool IsContainment { get; set; }
		bool IsDerived { get; set; }
		global::System.Collections.Generic.IList<MetaProperty> OppositeProperties { get; }
		global::System.Collections.Generic.IList<MetaProperty> RedefinedProperties { get; }
		global::System.Collections.Generic.IList<MetaProperty> SubsettedProperties { get; }
		string SymbolProperty { get; set; }
		__MetaType Type { get; set; }
	
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
		/// Constructor for the class MetaNamespace
		/// </summary>
		void MetaNamespace(MetaNamespace _this);
	
		/// <summary>
		/// Constructor for the class MetaModel
		/// </summary>
		void MetaModel(MetaModel _this);
	
		/// <summary>
		/// Constructor for the class MetaConstant
		/// </summary>
		void MetaConstant(MetaConstant _this);
	
		/// <summary>
		/// Constructor for the class MetaType
		/// </summary>
		void MetaType(MetaType _this);
	
		/// <summary>
		/// Constructor for the class MetaPrimitiveType
		/// </summary>
		void MetaPrimitiveType(MetaPrimitiveType _this);
	
		/// <summary>
		/// Constructor for the class MetaNullableType
		/// </summary>
		void MetaNullableType(MetaNullableType _this);
	
		/// <summary>
		/// Constructor for the class MetaArrayType
		/// </summary>
		void MetaArrayType(MetaArrayType _this);
	
		/// <summary>
		/// Constructor for the class MetaEnumType
		/// </summary>
		void MetaEnumType(MetaEnumType _this);
	
		/// <summary>
		/// Constructor for the class MetaEnumLiteral
		/// </summary>
		void MetaEnumLiteral(MetaEnumLiteral _this);
	
		/// <summary>
		/// Constructor for the class MetaClass
		/// </summary>
		void MetaClass(MetaClass _this);
	
		/// <summary>
		/// Constructor for the class MetaProperty
		/// </summary>
		void MetaProperty(MetaProperty _this);
	
		/// <summary>
		/// Constructor for the class MetaOperation
		/// </summary>
		void MetaOperation(MetaOperation _this);
	
		/// <summary>
		/// Constructor for the class MetaParameter
		/// </summary>
		void MetaParameter(MetaParameter _this);
	
	
		/// <summary>
		/// Computation of the derived property MetaDeclaration.FullName
		/// </summary>
		string MetaDeclaration_FullName(MetaDeclaration _this);
	
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
		/// Constructor for the class MetaNamespace
		/// </summary>
		public virtual void MetaNamespace(MetaNamespace _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaModel
		/// </summary>
		public virtual void MetaModel(MetaModel _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaConstant
		/// </summary>
		public virtual void MetaConstant(MetaConstant _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaType
		/// </summary>
		public virtual void MetaType(MetaType _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaPrimitiveType
		/// </summary>
		public virtual void MetaPrimitiveType(MetaPrimitiveType _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaNullableType
		/// </summary>
		public virtual void MetaNullableType(MetaNullableType _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaArrayType
		/// </summary>
		public virtual void MetaArrayType(MetaArrayType _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaEnumType
		/// </summary>
		public virtual void MetaEnumType(MetaEnumType _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaEnumLiteral
		/// </summary>
		public virtual void MetaEnumLiteral(MetaEnumLiteral _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaClass
		/// </summary>
		public virtual void MetaClass(MetaClass _this)
		{
		}
	
		/// <summary>
		/// Constructor for the class MetaProperty
		/// </summary>
		public virtual void MetaProperty(MetaProperty _this)
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
		/// Computation of the derived property MetaDeclaration.FullName
		/// </summary>
		public abstract string MetaDeclaration_FullName(MetaDeclaration _this);
	
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

	internal class MetaDeclaration_Impl : __MetaModelObject, MetaDeclaration
	{
		private MetaDeclaration_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaDeclaration);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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

	internal class MetaNamespace_Impl : __MetaModelObject, MetaNamespace
	{
		private MetaNamespace_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaNamespace(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaNamespace);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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

	internal class MetaModel_Impl : __MetaModelObject, MetaModel
	{
		private MetaModel_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaModel(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string NamespaceName
		{
			get => Meta.__CustomImpl.MetaModel_NamespaceName(this);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaModel);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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

	internal class MetaConstant_Impl : __MetaModelObject, MetaConstant
	{
		private MetaConstant_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaConstant(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public __MetaType Type
		{
			get => MGet<__MetaType>(Meta.MetaConstant_Type);
			set => MAdd<__MetaType>(Meta.MetaConstant_Type, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaConstant);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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

	internal class MetaType_Impl : __MetaModelObject, MetaType
	{
		private MetaType_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaType);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaTypeInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaTypeInfo, Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaPrimitiveType);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public __MetaType InnerType
		{
			get => MGet<__MetaType>(Meta.MetaNullableType_InnerType);
			set => MAdd<__MetaType>(Meta.MetaNullableType_InnerType, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaTypeInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaTypeInfo, Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaNullableType);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public __MetaType ItemType
		{
			get => MGet<__MetaType>(Meta.MetaArrayType_ItemType);
			set => MAdd<__MetaType>(Meta.MetaArrayType_ItemType, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaTypeInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaTypeInfo, Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaArrayType);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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

	internal class MetaEnumType_Impl : __MetaModelObject, MetaEnumType
	{
		private MetaEnumType_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaEnumType_Literals, new global::MetaDslx.Modeling.ModelObjectList<MetaEnumLiteral>(this, __Info.Instance.GetSlot(Meta.MetaEnumType_Literals)!));
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
			Meta.__CustomImpl.MetaEnumType(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaEnumLiteral> Literals
		{
			get => MGetCollection<MetaEnumLiteral>(Meta.MetaEnumType_Literals);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaTypeInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaTypeInfo, Meta.MetaDeclarationInfo);
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnumType_Literals);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnumType_Literals, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnumType_Literals, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Literals", Meta.MetaEnumType_Literals);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaEnumType_Literals, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaEnumType_Literals, __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnumType_Literals), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnumType_Literals), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaEnumType);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
				var result = new MetaEnumType_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaEnumTypeInfo";
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaEnumLiteral);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
	
		public __MetaType SymbolType
		{
			get => MGet<__MetaType>(Meta.MetaClass_SymbolType);
			set => MAdd<__MetaType>(Meta.MetaClass_SymbolType, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaTypeInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaTypeInfo, Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaClass_SymbolType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_SymbolType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_SymbolType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_Operations, Meta.MetaClass_Properties), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaClass);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
	
		public string SymbolProperty
		{
			get => MGet<string>(Meta.MetaProperty_SymbolProperty);
			set => MAdd<string>(Meta.MetaProperty_SymbolProperty, value);
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
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaProperty_SymbolProperty, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_SymbolProperty, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_SymbolProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaProperty_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_Type, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_Type), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaProperty);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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

	internal class MetaOperation_Impl : __MetaModelObject, MetaOperation
	{
		private MetaOperation_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaOperation_Parameters, new global::MetaDslx.Modeling.ModelObjectList<MetaParameter>(this, __Info.Instance.GetSlot(Meta.MetaOperation_Parameters)!));
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaOperation(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
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
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaOperation);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public __MetaType Type
		{
			get => MGet<__MetaType>(Meta.MetaParameter_Type);
			set => MAdd<__MetaType>(Meta.MetaParameter_Type, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGetCollection<MetaDeclaration>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaDeclaration_Name);
			set => MAdd<string>(Meta.MetaDeclaration_Name, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
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
				_baseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
				_allBaseTypes = __ImmutableArray.Create<__ModelObjectInfo>(Meta.MetaDeclarationInfo);
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
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
	
				_declaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
				_publicOperations = __ImmutableArray.Create<__ModelOperation>();
				var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
				_modelOperationInfos = modelOperationInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaParameter);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
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

}
