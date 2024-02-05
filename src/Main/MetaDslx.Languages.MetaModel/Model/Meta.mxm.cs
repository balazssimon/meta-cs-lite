#nullable enable

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
        private static readonly __ModelProperty _MetaModel_Uri;
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
        private static readonly __ModelProperty _MetaProperty_IsReadOnly;
        private static readonly __ModelProperty _MetaProperty_DefaultValue;
        private static readonly __ModelProperty _MetaProperty_OppositeProperties;
        private static readonly __ModelProperty _MetaProperty_SubsettedProperties;
        private static readonly __ModelProperty _MetaProperty_RedefinedProperties;
        private static readonly __ModelProperty _MetaOperation_ReturnType;
        private static readonly __ModelProperty _MetaOperation_Parameters;
        private static readonly __ModelProperty _MetaParameter_Type;
    
        static Meta()
        {
            _MetaDeclaration_Declarations = new __ModelProperty(typeof(MetaDeclaration), "Declarations", typeof(MetaDeclaration), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _MetaDeclaration_FullName = new __ModelProperty(typeof(MetaDeclaration), "FullName", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _MetaDeclaration_Name = new __ModelProperty(typeof(MetaDeclaration), "Name", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.Name, "Name");
            _MetaDeclaration_Parent = new __ModelProperty(typeof(MetaDeclaration), "Parent", typeof(MetaDeclaration), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _MetaConstant_Type = new __ModelProperty(typeof(MetaConstant), "Type", typeof(__MetaType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaModel_NamespaceName = new __ModelProperty(typeof(MetaModel), "NamespaceName", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _MetaModel_Uri = new __ModelProperty(typeof(MetaModel), "Uri", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaArrayType_ItemType = new __ModelProperty(typeof(MetaArrayType), "ItemType", typeof(__MetaType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaClass_BaseTypes = new __ModelProperty(typeof(MetaClass), "BaseTypes", typeof(MetaClass), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, "BaseTypes");
            _MetaClass_IsAbstract = new __ModelProperty(typeof(MetaClass), "IsAbstract", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaClass_Operations = new __ModelProperty(typeof(MetaClass), "Operations", typeof(MetaOperation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _MetaClass_Properties = new __ModelProperty(typeof(MetaClass), "Properties", typeof(MetaProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _MetaClass_SymbolType = new __ModelProperty(typeof(MetaClass), "SymbolType", typeof(__MetaType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaEnum_Literals = new __ModelProperty(typeof(MetaEnum), "Literals", typeof(MetaEnumLiteral), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _MetaNullableType_InnerType = new __ModelProperty(typeof(MetaNullableType), "InnerType", typeof(__MetaType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaOperation_Parameters = new __ModelProperty(typeof(MetaOperation), "Parameters", typeof(MetaParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _MetaOperation_ReturnType = new __ModelProperty(typeof(MetaOperation), "ReturnType", typeof(__MetaType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaParameter_Type = new __ModelProperty(typeof(MetaParameter), "Type", typeof(__MetaType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_DefaultValue = new __ModelProperty(typeof(MetaProperty), "DefaultValue", typeof(object), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_IsContainment = new __ModelProperty(typeof(MetaProperty), "IsContainment", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_IsDerived = new __ModelProperty(typeof(MetaProperty), "IsDerived", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_IsReadOnly = new __ModelProperty(typeof(MetaProperty), "IsReadOnly", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_OppositeProperties = new __ModelProperty(typeof(MetaProperty), "OppositeProperties", typeof(MetaProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
            _MetaProperty_RedefinedProperties = new __ModelProperty(typeof(MetaProperty), "RedefinedProperties", typeof(MetaProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
            _MetaProperty_SubsettedProperties = new __ModelProperty(typeof(MetaProperty), "SubsettedProperties", typeof(MetaProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
            _MetaProperty_SymbolProperty = new __ModelProperty(typeof(MetaProperty), "SymbolProperty", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_Type = new __ModelProperty(typeof(MetaProperty), "Type", typeof(__MetaType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
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
            var cf = new MetaModelFactory(_model, this);
            var f = new __MetaModelFactory(_model, this);
            var obj1 = f.MetaNamespace();
            var obj2 = f.MetaNamespace();
            var obj3 = f.MetaNamespace();
            var obj4 = f.MetaNamespace();
            var obj5 = f.MetaModel();
            var obj6 = f.MetaClass();
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
            var obj24 = f.MetaNullableType();
            var obj25 = f.MetaNullableType();
            var obj26 = f.MetaArrayType();
            var obj27 = f.MetaNullableType();
            var obj28 = f.MetaProperty();
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
            var obj51 = f.MetaProperty();
            var obj52 = f.MetaProperty();
            var obj53 = f.MetaNullableType();
            var obj54 = f.MetaNullableType();
            var obj55 = f.MetaArrayType();
            var obj56 = f.MetaArrayType();
            var obj57 = f.MetaArrayType();
            var obj58 = f.MetaProperty();
            var obj59 = f.MetaProperty();
            var obj60 = f.MetaArrayType();
            var obj61 = f.MetaProperty();
            __CustomImpl.Meta(this);
            obj1.MChildren.Add(obj2);
            obj1.Declarations.Add(obj2);
            obj1.Name = "MetaDslx";
            obj2.MChildren.Add(obj3);
            obj2.Declarations.Add(obj3);
            obj2.Name = "Languages";
            obj2.Parent = obj1;
            obj3.MChildren.Add(obj4);
            obj3.Declarations.Add(obj4);
            obj3.Name = "MetaModel";
            obj3.Parent = obj2;
            obj4.MChildren.Add(obj5);
            obj4.MChildren.Add(obj6);
            obj4.MChildren.Add(obj7);
            obj4.MChildren.Add(obj8);
            obj4.MChildren.Add(obj9);
            obj4.MChildren.Add(obj10);
            obj4.MChildren.Add(obj11);
            obj4.MChildren.Add(obj12);
            obj4.MChildren.Add(obj13);
            obj4.MChildren.Add(obj14);
            obj4.MChildren.Add(obj15);
            obj4.MChildren.Add(obj16);
            obj4.MChildren.Add(obj17);
            obj4.MChildren.Add(obj18);
            obj4.MChildren.Add(obj19);
            obj4.Declarations.Add(obj5);
            obj4.Declarations.Add(obj6);
            obj4.Declarations.Add(obj7);
            obj4.Declarations.Add(obj8);
            obj4.Declarations.Add(obj9);
            obj4.Declarations.Add(obj10);
            obj4.Declarations.Add(obj11);
            obj4.Declarations.Add(obj12);
            obj4.Declarations.Add(obj13);
            obj4.Declarations.Add(obj14);
            obj4.Declarations.Add(obj15);
            obj4.Declarations.Add(obj16);
            obj4.Declarations.Add(obj17);
            obj4.Declarations.Add(obj18);
            obj4.Declarations.Add(obj19);
            obj4.Name = "Model";
            obj4.Parent = obj3;
            obj5.Name = "Meta";
            obj5.Parent = obj4;
            obj6.MChildren.Add(obj20);
            obj6.MChildren.Add(obj21);
            obj6.MChildren.Add(obj22);
            obj6.MChildren.Add(obj23);
            obj6.Properties.Add(obj20);
            obj6.Properties.Add(obj21);
            obj6.Properties.Add(obj22);
            obj6.Properties.Add(obj23);
            obj6.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            obj6.Declarations.Add(obj20);
            obj6.Declarations.Add(obj21);
            obj6.Declarations.Add(obj22);
            obj6.Declarations.Add(obj23);
            obj6.Name = "MetaDeclaration";
            obj6.Parent = obj4;
            obj7.BaseTypes.Add(obj6);
            obj7.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
            obj7.Name = "MetaNamespace";
            obj7.Parent = obj4;
            obj8.MChildren.Add(obj28);
            obj8.MChildren.Add(obj29);
            obj8.BaseTypes.Add(obj6);
            obj8.Properties.Add(obj28);
            obj8.Properties.Add(obj29);
            obj8.Declarations.Add(obj28);
            obj8.Declarations.Add(obj29);
            obj8.Name = "MetaModel";
            obj8.Parent = obj4;
            obj9.MChildren.Add(obj30);
            obj9.BaseTypes.Add(obj6);
            obj9.Properties.Add(obj30);
            obj9.Declarations.Add(obj30);
            obj9.Name = "MetaConstant";
            obj9.Parent = obj4;
            obj10.BaseTypes.Add(obj6);
            obj10.IsAbstract = true;
            obj10.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
            obj10.Name = "MetaType";
            obj10.Parent = obj4;
            obj11.BaseTypes.Add(obj10);
            obj11.Name = "MetaPrimitiveType";
            obj11.Parent = obj4;
            obj12.MChildren.Add(obj31);
            obj12.BaseTypes.Add(obj10);
            obj12.Properties.Add(obj31);
            obj12.Declarations.Add(obj31);
            obj12.Name = "MetaNullableType";
            obj12.Parent = obj4;
            obj13.MChildren.Add(obj32);
            obj13.BaseTypes.Add(obj10);
            obj13.Properties.Add(obj32);
            obj13.Declarations.Add(obj32);
            obj13.Name = "MetaArrayType";
            obj13.Parent = obj4;
            obj14.MChildren.Add(obj33);
            obj14.BaseTypes.Add(obj10);
            obj14.Properties.Add(obj33);
            obj14.Declarations.Add(obj33);
            obj14.Name = "MetaEnum";
            obj14.Parent = obj4;
            obj15.BaseTypes.Add(obj6);
            obj15.Name = "MetaEnumLiteral";
            obj15.Parent = obj4;
            obj16.MChildren.Add(obj35);
            obj16.MChildren.Add(obj36);
            obj16.MChildren.Add(obj37);
            obj16.MChildren.Add(obj38);
            obj16.MChildren.Add(obj39);
            obj16.BaseTypes.Add(obj10);
            obj16.Properties.Add(obj35);
            obj16.Properties.Add(obj36);
            obj16.Properties.Add(obj37);
            obj16.Properties.Add(obj38);
            obj16.Properties.Add(obj39);
            obj16.Declarations.Add(obj35);
            obj16.Declarations.Add(obj36);
            obj16.Declarations.Add(obj37);
            obj16.Declarations.Add(obj38);
            obj16.Declarations.Add(obj39);
            obj16.Name = "MetaClass";
            obj16.Parent = obj4;
            obj17.MChildren.Add(obj44);
            obj17.MChildren.Add(obj45);
            obj17.MChildren.Add(obj46);
            obj17.MChildren.Add(obj47);
            obj17.MChildren.Add(obj48);
            obj17.MChildren.Add(obj49);
            obj17.MChildren.Add(obj50);
            obj17.MChildren.Add(obj51);
            obj17.MChildren.Add(obj52);
            obj17.BaseTypes.Add(obj6);
            obj17.Properties.Add(obj44);
            obj17.Properties.Add(obj45);
            obj17.Properties.Add(obj46);
            obj17.Properties.Add(obj47);
            obj17.Properties.Add(obj48);
            obj17.Properties.Add(obj49);
            obj17.Properties.Add(obj50);
            obj17.Properties.Add(obj51);
            obj17.Properties.Add(obj52);
            obj17.Declarations.Add(obj44);
            obj17.Declarations.Add(obj45);
            obj17.Declarations.Add(obj46);
            obj17.Declarations.Add(obj47);
            obj17.Declarations.Add(obj48);
            obj17.Declarations.Add(obj49);
            obj17.Declarations.Add(obj50);
            obj17.Declarations.Add(obj51);
            obj17.Declarations.Add(obj52);
            obj17.Name = "MetaProperty";
            obj17.Parent = obj4;
            obj18.MChildren.Add(obj58);
            obj18.MChildren.Add(obj59);
            obj18.BaseTypes.Add(obj6);
            obj18.Properties.Add(obj58);
            obj18.Properties.Add(obj59);
            obj18.Declarations.Add(obj58);
            obj18.Declarations.Add(obj59);
            obj18.Name = "MetaOperation";
            obj18.Parent = obj4;
            obj19.MChildren.Add(obj61);
            obj19.BaseTypes.Add(obj6);
            obj19.Properties.Add(obj61);
            obj19.Declarations.Add(obj61);
            obj19.Name = "MetaParameter";
            obj19.Parent = obj4;
            obj20.MChildren.Add(obj24);
            obj20.SymbolProperty = "Name";
            obj20.Type = __MetaType.FromModelObject((__IModelObject)obj24);
            obj20.Name = "Name";
            obj20.Parent = obj6;
            obj21.MChildren.Add(obj25);
            obj21.OppositeProperties.Add(obj22);
            obj21.Type = __MetaType.FromModelObject((__IModelObject)obj25);
            obj21.Name = "Parent";
            obj21.Parent = obj6;
            obj22.MChildren.Add(obj26);
            obj22.IsContainment = true;
            obj22.OppositeProperties.Add(obj21);
            obj22.Type = __MetaType.FromModelObject((__IModelObject)obj26);
            obj22.Name = "Declarations";
            obj22.Parent = obj6;
            obj23.MChildren.Add(obj27);
            obj23.IsDerived = true;
            obj23.Type = __MetaType.FromModelObject((__IModelObject)obj27);
            obj23.Name = "FullName";
            obj23.Parent = obj6;
            obj24.InnerType = typeof(string);
            obj25.InnerType = __MetaType.FromModelObject((__IModelObject)obj6);
            obj26.ItemType = __MetaType.FromModelObject((__IModelObject)obj6);
            obj27.InnerType = typeof(string);
            obj28.IsDerived = true;
            obj28.Type = typeof(string);
            obj28.Name = "NamespaceName";
            obj28.Parent = obj8;
            obj29.Type = typeof(string);
            obj29.Name = "Uri";
            obj29.Parent = obj8;
            obj30.Type = typeof(__MetaType);
            obj30.Name = "Type";
            obj30.Parent = obj9;
            obj31.Type = typeof(__MetaType);
            obj31.Name = "InnerType";
            obj31.Parent = obj12;
            obj32.Type = typeof(__MetaType);
            obj32.Name = "ItemType";
            obj32.Parent = obj13;
            obj33.MChildren.Add(obj34);
            obj33.IsContainment = true;
            obj33.SubsettedProperties.Add(obj22);
            obj33.Type = __MetaType.FromModelObject((__IModelObject)obj34);
            obj33.Name = "Literals";
            obj33.Parent = obj14;
            obj34.ItemType = __MetaType.FromModelObject((__IModelObject)obj15);
            obj35.MChildren.Add(obj40);
            obj35.Type = __MetaType.FromModelObject((__IModelObject)obj40);
            obj35.Name = "SymbolType";
            obj35.Parent = obj16;
            obj36.Type = typeof(bool);
            obj36.Name = "IsAbstract";
            obj36.Parent = obj16;
            obj37.MChildren.Add(obj41);
            obj37.SymbolProperty = "BaseTypes";
            obj37.Type = __MetaType.FromModelObject((__IModelObject)obj41);
            obj37.Name = "BaseTypes";
            obj37.Parent = obj16;
            obj38.MChildren.Add(obj42);
            obj38.IsContainment = true;
            obj38.SubsettedProperties.Add(obj22);
            obj38.Type = __MetaType.FromModelObject((__IModelObject)obj42);
            obj38.Name = "Properties";
            obj38.Parent = obj16;
            obj39.MChildren.Add(obj43);
            obj39.IsContainment = true;
            obj39.SubsettedProperties.Add(obj22);
            obj39.Type = __MetaType.FromModelObject((__IModelObject)obj43);
            obj39.Name = "Operations";
            obj39.Parent = obj16;
            obj40.InnerType = typeof(__MetaType);
            obj41.ItemType = __MetaType.FromModelObject((__IModelObject)obj16);
            obj42.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
            obj43.ItemType = __MetaType.FromModelObject((__IModelObject)obj18);
            obj44.Type = typeof(__MetaType);
            obj44.Name = "Type";
            obj44.Parent = obj17;
            obj45.MChildren.Add(obj53);
            obj45.Type = __MetaType.FromModelObject((__IModelObject)obj53);
            obj45.Name = "SymbolProperty";
            obj45.Parent = obj17;
            obj46.Type = typeof(bool);
            obj46.Name = "IsContainment";
            obj46.Parent = obj17;
            obj47.Type = typeof(bool);
            obj47.Name = "IsDerived";
            obj47.Parent = obj17;
            obj48.Type = typeof(bool);
            obj48.Name = "IsReadOnly";
            obj48.Parent = obj17;
            obj49.MChildren.Add(obj54);
            obj49.Type = __MetaType.FromModelObject((__IModelObject)obj54);
            obj49.Name = "DefaultValue";
            obj49.Parent = obj17;
            obj50.MChildren.Add(obj55);
            obj50.OppositeProperties.Add(obj50);
            obj50.Type = __MetaType.FromModelObject((__IModelObject)obj55);
            obj50.Name = "OppositeProperties";
            obj50.Parent = obj17;
            obj51.MChildren.Add(obj56);
            obj51.Type = __MetaType.FromModelObject((__IModelObject)obj56);
            obj51.Name = "SubsettedProperties";
            obj51.Parent = obj17;
            obj52.MChildren.Add(obj57);
            obj52.Type = __MetaType.FromModelObject((__IModelObject)obj57);
            obj52.Name = "RedefinedProperties";
            obj52.Parent = obj17;
            obj53.InnerType = typeof(string);
            obj54.InnerType = typeof(object);
            obj55.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
            obj56.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
            obj57.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
            obj58.Type = typeof(__MetaType);
            obj58.Name = "ReturnType";
            obj58.Parent = obj18;
            obj59.MChildren.Add(obj60);
            obj59.IsContainment = true;
            obj59.RedefinedProperties.Add(obj22);
            obj59.Type = __MetaType.FromModelObject((__IModelObject)obj60);
            obj59.Name = "Parameters";
            obj59.Parent = obj18;
            obj60.ItemType = __MetaType.FromModelObject((__IModelObject)obj19);
            obj61.Type = typeof(__MetaType);
            obj61.Name = "Type";
            obj61.Parent = obj19;
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
        public static __ModelProperty MetaModel_Uri => _MetaModel_Uri;
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
        public static __ModelProperty MetaProperty_IsReadOnly => _MetaProperty_IsReadOnly;
        public static __ModelProperty MetaProperty_DefaultValue => _MetaProperty_DefaultValue;
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
    
        internal MetaModelFactory(__Model model, Meta metaModel)
            : base(model, metaModel)
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
    


    public interface MetaDeclaration : __IModelObject
    {
        global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations { get; }
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
        string Uri { get; set; }
    
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
        global::MetaDslx.Modeling.ICollectionSlot<MetaClass> BaseTypes { get; }
        bool IsAbstract { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaOperation> Operations { get; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaProperty> Properties { get; }
        __MetaType SymbolType { get; set; }
    
    }

    public interface MetaEnum : global::MetaDslx.Languages.MetaModel.Model.MetaType
    {
        global::MetaDslx.Modeling.ICollectionSlot<MetaEnumLiteral> Literals { get; }
    
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
        global::MetaDslx.Modeling.ICollectionSlot<MetaParameter> Parameters { get; }
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
        object? DefaultValue { get; set; }
        bool IsContainment { get; set; }
        bool IsDerived { get; set; }
        bool IsReadOnly { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaProperty> OppositeProperties { get; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaProperty> RedefinedProperties { get; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaProperty> SubsettedProperties { get; }
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
            Meta.__CustomImpl.MetaDeclaration(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Meta.MInstance;
            public override __MetaType MetaType => typeof(MetaDeclaration);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaConstant(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public __MetaType Type
        {
            get => MGet<__MetaType>(Meta.MetaConstant_Type);
            set => MSet<__MetaType>(Meta.MetaConstant_Type, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaConstant_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaConstant_Type, __ImmutableArray.Create<__ModelProperty>(Meta.MetaConstant_Type), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Meta.MInstance;
            public override __MetaType MetaType => typeof(MetaConstant);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaModel(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public string NamespaceName
        {
            get => Meta.__CustomImpl.MetaModel_NamespaceName(this);
        }
    
        public string Uri
        {
            get => MGet<string>(Meta.MetaModel_Uri);
            set => MSet<string>(Meta.MetaModel_Uri, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName, Meta.MetaModel_Uri);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName, Meta.MetaModel_Uri, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName, Meta.MetaModel_Uri, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("NamespaceName", Meta.MetaModel_NamespaceName);
                publicPropertiesByName.Add("Uri", Meta.MetaModel_Uri);
                publicPropertiesByName.Add("Declarations", Meta.MetaDeclaration_Declarations);
                publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
                publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
                publicPropertiesByName.Add("Parent", Meta.MetaDeclaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Meta.MetaModel_NamespaceName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaModel_NamespaceName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_NamespaceName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaModel_Uri, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaModel_Uri, __ImmutableArray.Create<__ModelProperty>(Meta.MetaModel_Uri), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Meta.MInstance;
            public override __MetaType MetaType => typeof(MetaModel);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaNamespace(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaType(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaType(this);
            Meta.__CustomImpl.MetaArrayType(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public __MetaType ItemType
        {
            get => MGet<__MetaType>(Meta.MetaArrayType_ItemType);
            set => MSet<__MetaType>(Meta.MetaArrayType_ItemType, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaArrayType_ItemType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaArrayType_ItemType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaArrayType_ItemType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaType(this);
            Meta.__CustomImpl.MetaClass(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaClass> BaseTypes
        {
            get => MGetCollection<MetaClass>(Meta.MetaClass_BaseTypes);
        }
    
        public bool IsAbstract
        {
            get => MGet<bool>(Meta.MetaClass_IsAbstract);
            set => MSet<bool>(Meta.MetaClass_IsAbstract, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaOperation> Operations
        {
            get => MGetCollection<MetaOperation>(Meta.MetaClass_Operations);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaProperty> Properties
        {
            get => MGetCollection<MetaProperty>(Meta.MetaClass_Properties);
        }
    
        public __MetaType SymbolType
        {
            get => MGet<__MetaType>(Meta.MetaClass_SymbolType);
            set => MSet<__MetaType>(Meta.MetaClass_SymbolType, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaClass_BaseTypes, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_BaseTypes, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_BaseTypes), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaClass_IsAbstract, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_IsAbstract, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_IsAbstract), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaClass_Operations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_Operations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_Operations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaClass_Properties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_Properties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_Properties), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaClass_SymbolType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaClass_SymbolType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_SymbolType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaClass_Operations, Meta.MetaClass_Properties), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaType(this);
            Meta.__CustomImpl.MetaEnum(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaEnumLiteral> Literals
        {
            get => MGetCollection<MetaEnumLiteral>(Meta.MetaEnum_Literals);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaEnum_Literals, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaEnum_Literals, __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnum_Literals), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaEnum_Literals), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaEnumLiteral(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Meta.MInstance;
            public override __MetaType MetaType => typeof(MetaEnumLiteral);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaType(this);
            Meta.__CustomImpl.MetaNullableType(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public __MetaType InnerType
        {
            get => MGet<__MetaType>(Meta.MetaNullableType_InnerType);
            set => MSet<__MetaType>(Meta.MetaNullableType_InnerType, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaNullableType_InnerType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaNullableType_InnerType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaNullableType_InnerType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaOperation(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaParameter> Parameters
        {
            get => MGetCollection<MetaParameter>(Meta.MetaOperation_Parameters);
        }
    
        public __MetaType ReturnType
        {
            get => MGet<__MetaType>(Meta.MetaOperation_ReturnType);
            set => MSet<__MetaType>(Meta.MetaOperation_ReturnType, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaOperation_Parameters, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaOperation_Parameters, __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_Parameters, Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaOperation_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaOperation_ReturnType, __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_ReturnType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaOperation_Parameters, __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_Parameters, Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Meta.MetaOperation_Parameters), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Meta.MInstance;
            public override __MetaType MetaType => typeof(MetaOperation);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaParameter(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public __MetaType Type
        {
            get => MGet<__MetaType>(Meta.MetaParameter_Type);
            set => MSet<__MetaType>(Meta.MetaParameter_Type, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaParameter_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaParameter_Type, __ImmutableArray.Create<__ModelProperty>(Meta.MetaParameter_Type), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Meta.MInstance;
            public override __MetaType MetaType => typeof(MetaParameter);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaType(this);
            Meta.__CustomImpl.MetaPrimitiveType(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
                if (model is not null) model.AttachObject(result);
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
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaProperty(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public object? DefaultValue
        {
            get => MGet<object?>(Meta.MetaProperty_DefaultValue);
            set => MSet<object?>(Meta.MetaProperty_DefaultValue, value);
        }
    
        public bool IsContainment
        {
            get => MGet<bool>(Meta.MetaProperty_IsContainment);
            set => MSet<bool>(Meta.MetaProperty_IsContainment, value);
        }
    
        public bool IsDerived
        {
            get => MGet<bool>(Meta.MetaProperty_IsDerived);
            set => MSet<bool>(Meta.MetaProperty_IsDerived, value);
        }
    
        public bool IsReadOnly
        {
            get => MGet<bool>(Meta.MetaProperty_IsReadOnly);
            set => MSet<bool>(Meta.MetaProperty_IsReadOnly, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaProperty> OppositeProperties
        {
            get => MGetCollection<MetaProperty>(Meta.MetaProperty_OppositeProperties);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaProperty> RedefinedProperties
        {
            get => MGetCollection<MetaProperty>(Meta.MetaProperty_RedefinedProperties);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaProperty> SubsettedProperties
        {
            get => MGetCollection<MetaProperty>(Meta.MetaProperty_SubsettedProperties);
        }
    
        public string? SymbolProperty
        {
            get => MGet<string?>(Meta.MetaProperty_SymbolProperty);
            set => MSet<string?>(Meta.MetaProperty_SymbolProperty, value);
        }
    
        public __MetaType Type
        {
            get => MGet<__MetaType>(Meta.MetaProperty_Type);
            set => MSet<__MetaType>(Meta.MetaProperty_Type, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDeclaration> Declarations
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
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public MetaDeclaration? Parent
        {
            get => MGet<MetaDeclaration?>(Meta.MetaDeclaration_Parent);
            set => MSet<MetaDeclaration?>(Meta.MetaDeclaration_Parent, value);
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
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_DefaultValue, Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_IsReadOnly, Meta.MetaProperty_OppositeProperties, Meta.MetaProperty_RedefinedProperties, Meta.MetaProperty_SubsettedProperties, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_Type);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_DefaultValue, Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_IsReadOnly, Meta.MetaProperty_OppositeProperties, Meta.MetaProperty_RedefinedProperties, Meta.MetaProperty_SubsettedProperties, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_Type, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_DefaultValue, Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_IsReadOnly, Meta.MetaProperty_OppositeProperties, Meta.MetaProperty_RedefinedProperties, Meta.MetaProperty_SubsettedProperties, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_Type, Meta.MetaDeclaration_Declarations, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("DefaultValue", Meta.MetaProperty_DefaultValue);
                publicPropertiesByName.Add("IsContainment", Meta.MetaProperty_IsContainment);
                publicPropertiesByName.Add("IsDerived", Meta.MetaProperty_IsDerived);
                publicPropertiesByName.Add("IsReadOnly", Meta.MetaProperty_IsReadOnly);
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
                modelPropertyInfos.Add(Meta.MetaProperty_DefaultValue, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_DefaultValue, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_DefaultValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_IsContainment, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_IsContainment, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsContainment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_IsDerived, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_IsDerived, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsDerived), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_IsReadOnly, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_IsReadOnly, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsReadOnly), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_OppositeProperties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_OppositeProperties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_OppositeProperties), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_OppositeProperties), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_RedefinedProperties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_RedefinedProperties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_RedefinedProperties), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_SubsettedProperties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_SubsettedProperties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_SubsettedProperties), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_SymbolProperty, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_SymbolProperty, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_SymbolProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_Type, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_Type), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Parent, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Meta.MInstance;
            public override __MetaType MetaType => typeof(MetaProperty);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
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
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Meta.MetaPropertyInfo";
            }
        }
    }

}
