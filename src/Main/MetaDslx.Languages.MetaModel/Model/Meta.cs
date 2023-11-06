namespace MetaDslx.Languages.MetaModel.Model
{
	using __Model = global::MetaDslx.Modeling.Model;
	using __MetaModel = global::MetaDslx.Modeling.MetaModel;
	using __IModelObject = global::MetaDslx.Modeling.IModelObject;
	using __ModelFactory = global::MetaDslx.Modeling.ModelFactory;
	using __MultiModelFactory = global::MetaDslx.Modeling.MultiModelFactory;
	using __ModelVersion = global::MetaDslx.Modeling.ModelVersion;
	using __ModelObjectInfo = global::MetaDslx.Modeling.ModelObjectInfo;
	using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
	using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
	using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
	using __Type = global::System.Type;

	public class Meta : __MetaModel
	{
		// If there is an error at the following line, create a new class called 'CustomMetaImplementation'
		// inheriting from the class 'CustomMetaImplementationBase' and provide the custom implementation
		// for the derived properties and operations defined in the metamodel
		internal static readonly CustomMetaImplementationBase __CustomImpl = new CustomMetaImplementation();
	
		private static readonly Meta _instance;
		public static Meta Instance => _instance;
	
		private static readonly __ModelProperty _MetaNamedElement_Name;
		private static readonly __ModelProperty _MetaDeclaration_Parent;
		private static readonly __ModelProperty _MetaDeclaration_Declarations;
		private static readonly __ModelProperty _MetaDeclaration_FullName;
		private static readonly __ModelProperty _MetaModel_NamespaceName;
		private static readonly __ModelProperty _MetaEnumType_Literals;
		private static readonly __ModelProperty _MetaArrayType_ItemType;
		private static readonly __ModelProperty _MetaClass_SymbolType;
		private static readonly __ModelProperty _MetaClass_IsAbstract;
		private static readonly __ModelProperty _MetaClass_BaseTypes;
		private static readonly __ModelProperty _MetaClass_Properties;
		private static readonly __ModelProperty _MetaClass_Operations;
		private static readonly __ModelProperty _MetaProperty_Type;
		private static readonly __ModelProperty _MetaProperty_SymbolProperty;
		private static readonly __ModelProperty _MetaProperty_IsContainment;
		private static readonly __ModelProperty _MetaProperty_IsDerived;
		private static readonly __ModelProperty _MetaProperty_Opposite;
		private static readonly __ModelProperty _MetaOperation_ReturnType;
		private static readonly __ModelProperty _MetaOperation_Parameters;
		private static readonly __ModelProperty _MetaParameter_Type;
	
		static Meta()
		{
			_MetaNamedElement_Name = new __ModelProperty(typeof(MetaNamedElement), "Name", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.Name, "Name");
			_MetaDeclaration_Parent = new __ModelProperty(typeof(MetaDeclaration), "Parent", typeof(MetaDeclaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_MetaDeclaration_Declarations = new __ModelProperty(typeof(MetaDeclaration), "Declarations", typeof(MetaDeclaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaDeclaration_FullName = new __ModelProperty(typeof(MetaDeclaration), "FullName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_MetaModel_NamespaceName = new __ModelProperty(typeof(MetaModel), "NamespaceName", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
			_MetaEnumType_Literals = new __ModelProperty(typeof(MetaEnumType), "Literals", typeof(MetaEnumLiteral), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaArrayType_ItemType = new __ModelProperty(typeof(MetaArrayType), "ItemType", typeof(MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_MetaClass_SymbolType = new __ModelProperty(typeof(MetaClass), "SymbolType", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.TypeSymbolType, null);
			_MetaClass_IsAbstract = new __ModelProperty(typeof(MetaClass), "IsAbstract", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaClass_BaseTypes = new __ModelProperty(typeof(MetaClass), "BaseTypes", typeof(MetaClass), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
			_MetaClass_Properties = new __ModelProperty(typeof(MetaClass), "Properties", typeof(MetaProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaClass_Operations = new __ModelProperty(typeof(MetaClass), "Operations", typeof(MetaOperation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaProperty_Type = new __ModelProperty(typeof(MetaProperty), "Type", typeof(MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_SymbolProperty = new __ModelProperty(typeof(MetaProperty), "SymbolProperty", typeof(string), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_IsContainment = new __ModelProperty(typeof(MetaProperty), "IsContainment", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_IsDerived = new __ModelProperty(typeof(MetaProperty), "IsDerived", typeof(bool), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem, null);
			_MetaProperty_Opposite = new __ModelProperty(typeof(MetaProperty), "Opposite", typeof(MetaProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_MetaOperation_ReturnType = new __ModelProperty(typeof(MetaOperation), "ReturnType", typeof(MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_MetaOperation_Parameters = new __ModelProperty(typeof(MetaOperation), "Parameters", typeof(MetaParameter), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
			_MetaParameter_Type = new __ModelProperty(typeof(MetaParameter), "Type", typeof(MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem, null);
			_instance = new Meta();
		}
	
		private readonly __Model _model;
		private readonly global::System.Collections.Immutable.ImmutableArray<__Type> _modelObjectTypes;
		private readonly global::System.Collections.Immutable.ImmutableArray<__ModelObjectInfo> _modelObjectInfos;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<__Type, __ModelObjectInfo> _modelObjectInfosByType;
		private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelObjectInfo> _modelObjectInfosByName;
	
		private Meta()
		{
			_modelObjectTypes = __ImmutableArray.Create<__Type>(typeof(MetaNamedElement), typeof(MetaDeclaration), typeof(MetaNamespace), typeof(MetaModel), typeof(MetaType), typeof(MetaPrimitiveType), typeof(MetaEnumType), typeof(MetaEnumLiteral), typeof(MetaArrayType), typeof(MetaClass), typeof(MetaProperty), typeof(MetaOperation), typeof(MetaParameter));
			_modelObjectInfos = __ImmutableArray.Create<__ModelObjectInfo>(MetaNamedElementInfo, MetaDeclarationInfo, MetaNamespaceInfo, MetaModelInfo, MetaTypeInfo, MetaPrimitiveTypeInfo, MetaEnumTypeInfo, MetaEnumLiteralInfo, MetaArrayTypeInfo, MetaClassInfo, MetaPropertyInfo, MetaOperationInfo, MetaParameterInfo);
			var modelObjectInfosByType = __ImmutableDictionary.CreateBuilder<__Type, __ModelObjectInfo>();
			modelObjectInfosByType.Add(typeof(MetaNamedElement), MetaNamedElementInfo);
			modelObjectInfosByType.Add(typeof(MetaDeclaration), MetaDeclarationInfo);
			modelObjectInfosByType.Add(typeof(MetaNamespace), MetaNamespaceInfo);
			modelObjectInfosByType.Add(typeof(MetaModel), MetaModelInfo);
			modelObjectInfosByType.Add(typeof(MetaType), MetaTypeInfo);
			modelObjectInfosByType.Add(typeof(MetaPrimitiveType), MetaPrimitiveTypeInfo);
			modelObjectInfosByType.Add(typeof(MetaEnumType), MetaEnumTypeInfo);
			modelObjectInfosByType.Add(typeof(MetaEnumLiteral), MetaEnumLiteralInfo);
			modelObjectInfosByType.Add(typeof(MetaArrayType), MetaArrayTypeInfo);
			modelObjectInfosByType.Add(typeof(MetaClass), MetaClassInfo);
			modelObjectInfosByType.Add(typeof(MetaProperty), MetaPropertyInfo);
			modelObjectInfosByType.Add(typeof(MetaOperation), MetaOperationInfo);
			modelObjectInfosByType.Add(typeof(MetaParameter), MetaParameterInfo);
			_modelObjectInfosByType = modelObjectInfosByType.ToImmutable();
			var modelObjectInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelObjectInfo>();
			modelObjectInfosByName.Add("MetaNamedElement", MetaNamedElementInfo);
			modelObjectInfosByName.Add("MetaDeclaration", MetaDeclarationInfo);
			modelObjectInfosByName.Add("MetaNamespace", MetaNamespaceInfo);
			modelObjectInfosByName.Add("MetaModel", MetaModelInfo);
			modelObjectInfosByName.Add("MetaType", MetaTypeInfo);
			modelObjectInfosByName.Add("MetaPrimitiveType", MetaPrimitiveTypeInfo);
			modelObjectInfosByName.Add("MetaEnumType", MetaEnumTypeInfo);
			modelObjectInfosByName.Add("MetaEnumLiteral", MetaEnumLiteralInfo);
			modelObjectInfosByName.Add("MetaArrayType", MetaArrayTypeInfo);
			modelObjectInfosByName.Add("MetaClass", MetaClassInfo);
			modelObjectInfosByName.Add("MetaProperty", MetaPropertyInfo);
			modelObjectInfosByName.Add("MetaOperation", MetaOperationInfo);
			modelObjectInfosByName.Add("MetaParameter", MetaParameterInfo);
			_modelObjectInfosByName = modelObjectInfosByName.ToImmutable();
			_model = new __Model();
			var f = new MetaModelFactory(_model);
			var boolType = f.MetaPrimitiveType();
			boolType.Name = "bool";
			var intType = f.MetaPrimitiveType();
			intType.Name = "int";
			var stringType = f.MetaPrimitiveType();
			stringType.Name = "string";
			var typeType = f.MetaPrimitiveType();
			typeType.Name = "type";
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
			var obj22 = f.MetaProperty();
			var obj23 = f.MetaProperty();
			var obj24 = f.MetaArrayType();
			var obj25 = f.MetaProperty();
			var obj26 = f.MetaProperty();
			var obj27 = f.MetaArrayType();
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
			var obj42 = f.MetaProperty();
			var obj43 = f.MetaProperty();
			var obj44 = f.MetaArrayType();
			var obj45 = f.MetaProperty();
			((__IModelObject)obj1).Children.Add((__IModelObject)obj2);
			((__IModelObject)obj2).Children.Add((__IModelObject)obj3);
			obj2.Name = "MetaDslx";
			obj2.Declarations.Add(obj3);
			((__IModelObject)obj3).Children.Add((__IModelObject)obj4);
			obj3.Name = "Languages";
			obj3.Parent = obj2;
			obj3.Declarations.Add(obj4);
			((__IModelObject)obj4).Children.Add((__IModelObject)obj5);
			obj4.Name = "MetaModel";
			obj4.Parent = obj3;
			obj4.Declarations.Add(obj5);
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
			obj5.Name = "Model";
			obj5.Parent = obj4;
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
			obj6.Name = "Meta";
			obj6.Parent = obj5;
			((__IModelObject)obj7).Children.Add((__IModelObject)obj20);
			obj7.SymbolType = "MetaDslx.CodeAnalysis.Symbols.Symbol";
			obj7.IsAbstract = false;
			obj7.Properties.Add(obj20);
			obj7.Name = "MetaNamedElement";
			obj7.Parent = obj5;
			obj7.Declarations.Add(obj20);
			((__IModelObject)obj8).Children.Add((__IModelObject)obj21);
			((__IModelObject)obj8).Children.Add((__IModelObject)obj22);
			((__IModelObject)obj8).Children.Add((__IModelObject)obj23);
			obj8.SymbolType = "MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol";
			obj8.IsAbstract = false;
			obj8.BaseTypes.Add(obj7);
			obj8.Properties.Add(obj21);
			obj8.Properties.Add(obj22);
			obj8.Properties.Add(obj23);
			obj8.Name = "MetaDeclaration";
			obj8.Parent = obj5;
			obj8.Declarations.Add(obj21);
			obj8.Declarations.Add(obj22);
			obj8.Declarations.Add(obj23);
			obj9.SymbolType = "MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol";
			obj9.IsAbstract = false;
			obj9.BaseTypes.Add(obj8);
			obj9.Name = "MetaNamespace";
			obj9.Parent = obj5;
			((__IModelObject)obj10).Children.Add((__IModelObject)obj25);
			obj10.IsAbstract = false;
			obj10.BaseTypes.Add(obj8);
			obj10.Properties.Add(obj25);
			obj10.Name = "MetaModel";
			obj10.Parent = obj5;
			obj10.Declarations.Add(obj25);
			obj11.SymbolType = "MetaDslx.CodeAnalysis.Symbols.TypeSymbol";
			obj11.IsAbstract = true;
			obj11.BaseTypes.Add(obj8);
			obj11.Name = "MetaType";
			obj11.Parent = obj5;
			obj12.IsAbstract = false;
			obj12.BaseTypes.Add(obj11);
			obj12.Name = "MetaPrimitiveType";
			obj12.Parent = obj5;
			((__IModelObject)obj13).Children.Add((__IModelObject)obj26);
			obj13.IsAbstract = false;
			obj13.BaseTypes.Add(obj11);
			obj13.Properties.Add(obj26);
			obj13.Name = "MetaEnumType";
			obj13.Parent = obj5;
			obj13.Declarations.Add(obj26);
			obj14.IsAbstract = false;
			obj14.BaseTypes.Add(obj8);
			obj14.Name = "MetaEnumLiteral";
			obj14.Parent = obj5;
			((__IModelObject)obj15).Children.Add((__IModelObject)obj28);
			obj15.IsAbstract = false;
			obj15.BaseTypes.Add(obj11);
			obj15.Properties.Add(obj28);
			obj15.Name = "MetaArrayType";
			obj15.Parent = obj5;
			obj15.Declarations.Add(obj28);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj29);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj30);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj31);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj32);
			((__IModelObject)obj16).Children.Add((__IModelObject)obj33);
			obj16.IsAbstract = false;
			obj16.BaseTypes.Add(obj11);
			obj16.Properties.Add(obj29);
			obj16.Properties.Add(obj30);
			obj16.Properties.Add(obj31);
			obj16.Properties.Add(obj32);
			obj16.Properties.Add(obj33);
			obj16.Name = "MetaClass";
			obj16.Parent = obj5;
			obj16.Declarations.Add(obj29);
			obj16.Declarations.Add(obj30);
			obj16.Declarations.Add(obj31);
			obj16.Declarations.Add(obj32);
			obj16.Declarations.Add(obj33);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj37);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj38);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj39);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj40);
			((__IModelObject)obj17).Children.Add((__IModelObject)obj41);
			obj17.IsAbstract = false;
			obj17.BaseTypes.Add(obj8);
			obj17.Properties.Add(obj37);
			obj17.Properties.Add(obj38);
			obj17.Properties.Add(obj39);
			obj17.Properties.Add(obj40);
			obj17.Properties.Add(obj41);
			obj17.Name = "MetaProperty";
			obj17.Parent = obj5;
			obj17.Declarations.Add(obj37);
			obj17.Declarations.Add(obj38);
			obj17.Declarations.Add(obj39);
			obj17.Declarations.Add(obj40);
			obj17.Declarations.Add(obj41);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj42);
			((__IModelObject)obj18).Children.Add((__IModelObject)obj43);
			obj18.IsAbstract = false;
			obj18.BaseTypes.Add(obj8);
			obj18.Properties.Add(obj42);
			obj18.Properties.Add(obj43);
			obj18.Name = "MetaOperation";
			obj18.Parent = obj5;
			obj18.Declarations.Add(obj42);
			obj18.Declarations.Add(obj43);
			((__IModelObject)obj19).Children.Add((__IModelObject)obj45);
			obj19.IsAbstract = false;
			obj19.BaseTypes.Add(obj8);
			obj19.Properties.Add(obj45);
			obj19.Name = "MetaParameter";
			obj19.Parent = obj5;
			obj19.Declarations.Add(obj45);
			obj20.Type = stringType;
			obj20.SymbolProperty = "Name";
			obj20.IsContainment = false;
			obj20.IsDerived = false;
			obj20.Name = "Name";
			obj20.Parent = obj7;
			obj21.Type = obj8;
			obj21.IsContainment = false;
			obj21.IsDerived = false;
			obj21.Opposite = obj22;
			obj21.Name = "Parent";
			obj21.Parent = obj8;
			((__IModelObject)obj22).Children.Add((__IModelObject)obj24);
			obj22.Type = obj24;
			obj22.IsContainment = true;
			obj22.IsDerived = false;
			obj22.Opposite = obj21;
			obj22.Name = "Declarations";
			obj22.Parent = obj8;
			obj23.Type = stringType;
			obj23.IsContainment = false;
			obj23.IsDerived = true;
			obj23.Name = "FullName";
			obj23.Parent = obj8;
			obj24.ItemType = obj8;
			obj25.Type = stringType;
			obj25.IsContainment = false;
			obj25.IsDerived = true;
			obj25.Name = "NamespaceName";
			obj25.Parent = obj10;
			((__IModelObject)obj26).Children.Add((__IModelObject)obj27);
			obj26.Type = obj27;
			obj26.IsContainment = true;
			obj26.IsDerived = false;
			obj26.Name = "Literals";
			obj26.Parent = obj13;
			obj27.ItemType = obj14;
			obj28.Type = obj11;
			obj28.IsContainment = false;
			obj28.IsDerived = false;
			obj28.Name = "ItemType";
			obj28.Parent = obj15;
			obj29.Type = typeType;
			obj29.IsContainment = false;
			obj29.IsDerived = false;
			obj29.Name = "SymbolType";
			obj29.Parent = obj16;
			obj30.Type = boolType;
			obj30.IsContainment = false;
			obj30.IsDerived = false;
			obj30.Name = "IsAbstract";
			obj30.Parent = obj16;
			((__IModelObject)obj31).Children.Add((__IModelObject)obj34);
			obj31.Type = obj34;
			obj31.IsContainment = false;
			obj31.IsDerived = false;
			obj31.Name = "BaseTypes";
			obj31.Parent = obj16;
			((__IModelObject)obj32).Children.Add((__IModelObject)obj35);
			obj32.Type = obj35;
			obj32.IsContainment = true;
			obj32.IsDerived = false;
			obj32.Name = "Properties";
			obj32.Parent = obj16;
			((__IModelObject)obj33).Children.Add((__IModelObject)obj36);
			obj33.Type = obj36;
			obj33.IsContainment = true;
			obj33.IsDerived = false;
			obj33.Name = "Operations";
			obj33.Parent = obj16;
			obj34.ItemType = obj16;
			obj35.ItemType = obj17;
			obj36.ItemType = obj18;
			obj37.Type = obj11;
			obj37.IsContainment = false;
			obj37.IsDerived = false;
			obj37.Name = "Type";
			obj37.Parent = obj17;
			obj38.Type = stringType;
			obj38.IsContainment = false;
			obj38.IsDerived = false;
			obj38.Name = "SymbolProperty";
			obj38.Parent = obj17;
			obj39.Type = boolType;
			obj39.IsContainment = false;
			obj39.IsDerived = false;
			obj39.Name = "IsContainment";
			obj39.Parent = obj17;
			obj40.Type = boolType;
			obj40.IsContainment = false;
			obj40.IsDerived = false;
			obj40.Name = "IsDerived";
			obj40.Parent = obj17;
			obj41.Type = obj17;
			obj41.IsContainment = false;
			obj41.IsDerived = false;
			obj41.Opposite = obj41;
			obj41.Name = "Opposite";
			obj41.Parent = obj17;
			obj42.Type = obj11;
			obj42.IsContainment = false;
			obj42.IsDerived = false;
			obj42.Name = "ReturnType";
			obj42.Parent = obj18;
			((__IModelObject)obj43).Children.Add((__IModelObject)obj44);
			obj43.Type = obj44;
			obj43.IsContainment = true;
			obj43.IsDerived = false;
			obj43.Name = "Parameters";
			obj43.Parent = obj18;
			obj44.ItemType = obj19;
			obj45.Type = obj11;
			obj45.IsContainment = false;
			obj45.IsDerived = false;
			obj45.Name = "Type";
			obj45.Parent = obj19;
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
	
	    public override bool TryGetInfo(__Type modelObjectType, out __ModelObjectInfo info) => _modelObjectInfosByType.TryGetValue(modelObjectType, out info);
	    public override bool TryGetInfo(string modelObjectTypeName, out __ModelObjectInfo info) => _modelObjectInfosByName.TryGetValue(modelObjectTypeName, out info);
	
		public static __ModelObjectInfo MetaNamedElementInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaNamedElement_Impl.__Info.Instance;
		public static __ModelProperty MetaNamedElement_Name => _MetaNamedElement_Name;
		public static __ModelObjectInfo MetaDeclarationInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaDeclaration_Impl.__Info.Instance;
		public static __ModelProperty MetaDeclaration_Parent => _MetaDeclaration_Parent;
		public static __ModelProperty MetaDeclaration_Declarations => _MetaDeclaration_Declarations;
		public static __ModelProperty MetaDeclaration_FullName => _MetaDeclaration_FullName;
		public static __ModelObjectInfo MetaNamespaceInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaNamespace_Impl.__Info.Instance;
		public static __ModelObjectInfo MetaModelInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaModel_Impl.__Info.Instance;
		public static __ModelProperty MetaModel_NamespaceName => _MetaModel_NamespaceName;
		public static __ModelObjectInfo MetaTypeInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaType_Impl.__Info.Instance;
		public static __ModelObjectInfo MetaPrimitiveTypeInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaPrimitiveType_Impl.__Info.Instance;
		public static __ModelObjectInfo MetaEnumTypeInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaEnumType_Impl.__Info.Instance;
		public static __ModelProperty MetaEnumType_Literals => _MetaEnumType_Literals;
		public static __ModelObjectInfo MetaEnumLiteralInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaEnumLiteral_Impl.__Info.Instance;
		public static __ModelObjectInfo MetaArrayTypeInfo => global::MetaDslx.Languages.MetaModel.Model.__Impl.MetaArrayType_Impl.__Info.Instance;
		public static __ModelProperty MetaArrayType_ItemType => _MetaArrayType_ItemType;
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
		public static __ModelProperty MetaProperty_Opposite => _MetaProperty_Opposite;
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
	
		public MetaNamedElement MetaNamedElement(string? id = null)
		{
			return (MetaNamedElement)Meta.MetaNamedElementInfo.Create(Model, id)!;
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
	
		public MetaPrimitiveType MetaPrimitiveType(string? id = null)
		{
			return (MetaPrimitiveType)Meta.MetaPrimitiveTypeInfo.Create(Model, id)!;
		}
	
		public MetaEnumType MetaEnumType(string? id = null)
		{
			return (MetaEnumType)Meta.MetaEnumTypeInfo.Create(Model, id)!;
		}
	
		public MetaEnumLiteral MetaEnumLiteral(string? id = null)
		{
			return (MetaEnumLiteral)Meta.MetaEnumLiteralInfo.Create(Model, id)!;
		}
	
		public MetaArrayType MetaArrayType(string? id = null)
		{
			return (MetaArrayType)Meta.MetaArrayTypeInfo.Create(Model, id)!;
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
	
		public MetaNamedElement MetaNamedElement(__Model model, string? id = null)
		{
			return (MetaNamedElement)Meta.MetaNamedElementInfo.Create(model, id)!;
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
	
		public MetaPrimitiveType MetaPrimitiveType(__Model model, string? id = null)
		{
			return (MetaPrimitiveType)Meta.MetaPrimitiveTypeInfo.Create(model, id)!;
		}
	
		public MetaEnumType MetaEnumType(__Model model, string? id = null)
		{
			return (MetaEnumType)Meta.MetaEnumTypeInfo.Create(model, id)!;
		}
	
		public MetaEnumLiteral MetaEnumLiteral(__Model model, string? id = null)
		{
			return (MetaEnumLiteral)Meta.MetaEnumLiteralInfo.Create(model, id)!;
		}
	
		public MetaArrayType MetaArrayType(__Model model, string? id = null)
		{
			return (MetaArrayType)Meta.MetaArrayTypeInfo.Create(model, id)!;
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
	

	public interface MetaNamedElement
	{
		string Name { get; set; }
	}

	public interface MetaDeclaration : global::MetaDslx.Languages.MetaModel.Model.MetaNamedElement
	{
		MetaDeclaration Parent { get; set; }
		global::System.Collections.Generic.IList<MetaDeclaration> Declarations { get; }
		string FullName { get; }
	}

	public interface MetaNamespace : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
	}

	public interface MetaModel : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		string NamespaceName { get; }
	}

	public interface MetaType : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
	}

	public interface MetaPrimitiveType : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
	}

	public interface MetaEnumType : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
		global::System.Collections.Generic.IList<MetaEnumLiteral> Literals { get; }
	}

	public interface MetaEnumLiteral : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
	}

	public interface MetaArrayType : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
		MetaType ItemType { get; set; }
	}

	public interface MetaClass : global::MetaDslx.Languages.MetaModel.Model.MetaType
	{
		string SymbolType { get; set; }
		bool IsAbstract { get; set; }
		global::System.Collections.Generic.IList<MetaClass> BaseTypes { get; }
		global::System.Collections.Generic.IList<MetaProperty> Properties { get; }
		global::System.Collections.Generic.IList<MetaOperation> Operations { get; }
	}

	public interface MetaProperty : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		MetaType Type { get; set; }
		string SymbolProperty { get; set; }
		bool IsContainment { get; set; }
		bool IsDerived { get; set; }
		MetaProperty Opposite { get; set; }
	}

	public interface MetaOperation : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		MetaType ReturnType { get; set; }
		global::System.Collections.Generic.IList<MetaParameter> Parameters { get; }
	}

	public interface MetaParameter : global::MetaDslx.Languages.MetaModel.Model.MetaDeclaration
	{
		MetaType Type { get; set; }
	}


	internal interface ICustomMetaImplementation
	{
		/// <summary>
		/// Constructor for the class MetaNamedElement
		/// </summary>
		void MetaNamedElement(MetaNamedElement _this);
	
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
		/// Constructor for the class MetaType
		/// </summary>
		void MetaType(MetaType _this);
	
		/// <summary>
		/// Constructor for the class MetaPrimitiveType
		/// </summary>
		void MetaPrimitiveType(MetaPrimitiveType _this);
	
		/// <summary>
		/// Constructor for the class MetaEnumType
		/// </summary>
		void MetaEnumType(MetaEnumType _this);
	
		/// <summary>
		/// Constructor for the class MetaEnumLiteral
		/// </summary>
		void MetaEnumLiteral(MetaEnumLiteral _this);
	
		/// <summary>
		/// Constructor for the class MetaArrayType
		/// </summary>
		void MetaArrayType(MetaArrayType _this);
	
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
		/// Constructor for the class MetaNamedElement
		/// </summary>
		public virtual void MetaNamedElement(MetaNamedElement _this)
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
	using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
	using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
	using __Type = global::System.Type;

	internal class MetaNamedElement_Impl : __MetaModelObject, MetaNamedElement
	{
		private MetaNamedElement_Impl(string? id)
			: base(id)
		{
			Meta.__CustomImpl.MetaNamedElement(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaNamedElement);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
			public override __IModelObject? Create(__Model? model = null, string? id = null)
			{
				var result = new MetaNamedElement_Impl(id);
				if (model is not null) model.AddObject(result);
				return result;
			}
	
			public override string ToString()
			{
				return "Meta.MetaNamedElementInfo";
			}
		}
	}

	internal class MetaDeclaration_Impl : __MetaModelObject, MetaDeclaration
	{
		private MetaDeclaration_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaDeclaration);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaNamespace(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaNamespace);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaModel(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string NamespaceName
		{
			get => Meta.__CustomImpl.MetaModel_NamespaceName(this);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("NamespaceName", Meta.MetaModel_NamespaceName);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaModel_NamespaceName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaModel_NamespaceName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaModel);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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

	internal class MetaType_Impl : __MetaModelObject, MetaType
	{
		private MetaType_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaType);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
			Meta.__CustomImpl.MetaPrimitiveType(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaPrimitiveType);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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

	internal class MetaEnumType_Impl : __MetaModelObject, MetaEnumType
	{
		private MetaEnumType_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaEnumType_Literals, new global::MetaDslx.Modeling.ModelObjectList<MetaEnumLiteral>(this, __Info.Instance.GetSlot(Meta.MetaEnumType_Literals)!));
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
			Meta.__CustomImpl.MetaEnumType(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public global::System.Collections.Generic.IList<MetaEnumLiteral> Literals
		{
			get => MGet<global::System.Collections.Generic.IList<MetaEnumLiteral>>(Meta.MetaEnumType_Literals);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnumType_Literals);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnumType_Literals, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnumType_Literals, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Literals", Meta.MetaEnumType_Literals);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaEnumType_Literals, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaEnumType_Literals, __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnumType_Literals), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaEnumType);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaEnumLiteral(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>();
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaEnumLiteral);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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

	internal class MetaArrayType_Impl : __MetaModelObject, MetaArrayType
	{
		private MetaArrayType_Impl(string? id)
			: base(id)
		{
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
			Meta.__CustomImpl.MetaArrayType(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public MetaType ItemType
		{
			get => MGet<MetaType>(Meta.MetaArrayType_ItemType);
			set => MAdd<MetaType>(Meta.MetaArrayType_ItemType, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaArrayType_ItemType);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaArrayType_ItemType, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaArrayType_ItemType, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("ItemType", Meta.MetaArrayType_ItemType);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaArrayType_ItemType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaArrayType_ItemType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaArrayType_ItemType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaArrayType);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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
			((__IModelObject)this).Init(Meta.MetaClass_Properties, new global::MetaDslx.Modeling.ModelObjectList<MetaProperty>(this, __Info.Instance.GetSlot(Meta.MetaClass_Properties)!));
			((__IModelObject)this).Init(Meta.MetaClass_Operations, new global::MetaDslx.Modeling.ModelObjectList<MetaOperation>(this, __Info.Instance.GetSlot(Meta.MetaClass_Operations)!));
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaType(this);
			Meta.__CustomImpl.MetaClass(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public string SymbolType
		{
			get => MGet<string>(Meta.MetaClass_SymbolType);
			set => MAdd<string>(Meta.MetaClass_SymbolType, value);
		}
	
		public bool IsAbstract
		{
			get => MGet<bool>(Meta.MetaClass_IsAbstract);
			set => MAdd<bool>(Meta.MetaClass_IsAbstract, value);
		}
	
		public global::System.Collections.Generic.IList<MetaClass> BaseTypes
		{
			get => MGet<global::System.Collections.Generic.IList<MetaClass>>(Meta.MetaClass_BaseTypes);
		}
	
		public global::System.Collections.Generic.IList<MetaProperty> Properties
		{
			get => MGet<global::System.Collections.Generic.IList<MetaProperty>>(Meta.MetaClass_Properties);
		}
	
		public global::System.Collections.Generic.IList<MetaOperation> Operations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaOperation>>(Meta.MetaClass_Operations);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_SymbolType, Meta.MetaClass_IsAbstract, Meta.MetaClass_BaseTypes, Meta.MetaClass_Properties, Meta.MetaClass_Operations);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_SymbolType, Meta.MetaClass_IsAbstract, Meta.MetaClass_BaseTypes, Meta.MetaClass_Properties, Meta.MetaClass_Operations, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_SymbolType, Meta.MetaClass_IsAbstract, Meta.MetaClass_BaseTypes, Meta.MetaClass_Properties, Meta.MetaClass_Operations, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("SymbolType", Meta.MetaClass_SymbolType);
				publicPropertiesByName.Add("IsAbstract", Meta.MetaClass_IsAbstract);
				publicPropertiesByName.Add("BaseTypes", Meta.MetaClass_BaseTypes);
				publicPropertiesByName.Add("Properties", Meta.MetaClass_Properties);
				publicPropertiesByName.Add("Operations", Meta.MetaClass_Operations);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaClass_SymbolType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_SymbolType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_SymbolType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaClass_IsAbstract, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_IsAbstract, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_IsAbstract), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaClass_BaseTypes, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_BaseTypes, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_BaseTypes), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaClass_Properties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_Properties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_Properties), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaClass_Operations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_Operations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_Operations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaClass);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaProperty(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public MetaType Type
		{
			get => MGet<MetaType>(Meta.MetaProperty_Type);
			set => MAdd<MetaType>(Meta.MetaProperty_Type, value);
		}
	
		public string SymbolProperty
		{
			get => MGet<string>(Meta.MetaProperty_SymbolProperty);
			set => MAdd<string>(Meta.MetaProperty_SymbolProperty, value);
		}
	
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
	
		public MetaProperty Opposite
		{
			get => MGet<MetaProperty>(Meta.MetaProperty_Opposite);
			set => MAdd<MetaProperty>(Meta.MetaProperty_Opposite, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_Type, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_Opposite);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_Type, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_Opposite, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_Type, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_Opposite, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Type", Meta.MetaProperty_Type);
				publicPropertiesByName.Add("SymbolProperty", Meta.MetaProperty_SymbolProperty);
				publicPropertiesByName.Add("IsContainment", Meta.MetaProperty_IsContainment);
				publicPropertiesByName.Add("IsDerived", Meta.MetaProperty_IsDerived);
				publicPropertiesByName.Add("Opposite", Meta.MetaProperty_Opposite);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaProperty_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_Type, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_Type), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaProperty_SymbolProperty, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_SymbolProperty, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_SymbolProperty), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaProperty_IsContainment, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_IsContainment, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsContainment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaProperty_IsDerived, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_IsDerived, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsDerived), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaProperty_Opposite, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_Opposite, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_Opposite), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_Opposite), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaProperty);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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
			((__IModelObject)this).Init(Meta.MetaDeclaration_Declarations, new global::MetaDslx.Modeling.ModelObjectList<MetaDeclaration>(this, __Info.Instance.GetSlot(Meta.MetaDeclaration_Declarations)!));
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaOperation(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public MetaType ReturnType
		{
			get => MGet<MetaType>(Meta.MetaOperation_ReturnType);
			set => MAdd<MetaType>(Meta.MetaOperation_ReturnType, value);
		}
	
		public global::System.Collections.Generic.IList<MetaParameter> Parameters
		{
			get => MGet<global::System.Collections.Generic.IList<MetaParameter>>(Meta.MetaOperation_Parameters);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_ReturnType, Meta.MetaOperation_Parameters);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_ReturnType, Meta.MetaOperation_Parameters, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_ReturnType, Meta.MetaOperation_Parameters, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("ReturnType", Meta.MetaOperation_ReturnType);
				publicPropertiesByName.Add("Parameters", Meta.MetaOperation_Parameters);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaOperation_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaOperation_ReturnType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaOperation_Parameters, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaOperation_Parameters, __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_Parameters), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaOperation);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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
			Meta.__CustomImpl.MetaNamedElement(this);
			Meta.__CustomImpl.MetaDeclaration(this);
			Meta.__CustomImpl.MetaParameter(this);
		}
	
		public override __ModelObjectInfo MInfo => __Info.Instance;
	
		public MetaType Type
		{
			get => MGet<MetaType>(Meta.MetaParameter_Type);
			set => MAdd<MetaType>(Meta.MetaParameter_Type, value);
		}
	
		public MetaDeclaration Parent
		{
			get => MGet<MetaDeclaration>(Meta.MetaDeclaration_Parent);
			set => MAdd<MetaDeclaration>(Meta.MetaDeclaration_Parent, value);
		}
	
		public global::System.Collections.Generic.IList<MetaDeclaration> Declarations
		{
			get => MGet<global::System.Collections.Generic.IList<MetaDeclaration>>(Meta.MetaDeclaration_Declarations);
		}
	
		public string FullName
		{
			get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
		}
	
		public string Name
		{
			get => MGet<string>(Meta.MetaNamedElement_Name);
			set => MAdd<string>(Meta.MetaNamedElement_Name, value);
		}
	
	
		internal class __Info : __ModelObjectInfo
		{
			public static readonly __Info Instance = new __Info();
	
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
			private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
	        private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
	
			private __Info() 
			{
				_declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaParameter_Type);
				_allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaParameter_Type, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				_publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaParameter_Type, Meta.MetaDeclaration_Parent, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaNamedElement_Name);
				var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
				publicPropertiesByName.Add("Type", Meta.MetaParameter_Type);
				publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
				publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
				publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
				publicPropertiesByName.Add("Name", Meta.MetaNamedElement_Name);
				_publicPropertiesByName = publicPropertiesByName.ToImmutable();
				var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
				modelPropertyInfos.Add(Meta.MetaParameter_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaParameter_Type, __ImmutableArray.Create<__ModelProperty>(Meta.MetaParameter_Type), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				modelPropertyInfos.Add(Meta.MetaNamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNamedElement_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.SingleItem), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
				_modelPropertyInfos = modelPropertyInfos.ToImmutable();
			}
	
	        public override __MetaModel MetaModel => Meta.Instance;
	        public override global::System.Type MetaType => typeof(MetaParameter);
	
	        public override __Type? SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol);
	        public override __ModelProperty? NameProperty => Meta.MetaNamedElement_Name;
	        public override __ModelProperty? TypeProperty => null;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
	        public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
	
	        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
	        protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
	
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
