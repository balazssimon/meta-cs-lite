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
        private static readonly __ModelProperty _MetaProperty_IsUnion;
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
            _MetaProperty_IsUnion = new __ModelProperty(typeof(MetaProperty), "IsUnion", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_OppositeProperties = new __ModelProperty(typeof(MetaProperty), "OppositeProperties", typeof(MetaProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
            _MetaProperty_RedefinedProperties = new __ModelProperty(typeof(MetaProperty), "RedefinedProperties", typeof(MetaProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
            _MetaProperty_SubsettedProperties = new __ModelProperty(typeof(MetaProperty), "SubsettedProperties", typeof(MetaProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
            _MetaProperty_SymbolProperty = new __ModelProperty(typeof(MetaProperty), "SymbolProperty", typeof(__MetaSymbol), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
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
            var obj53 = f.MetaProperty();
            var obj54 = f.MetaNullableType();
            var obj55 = f.MetaNullableType();
            var obj56 = f.MetaArrayType();
            var obj57 = f.MetaArrayType();
            var obj58 = f.MetaArrayType();
            var obj59 = f.MetaProperty();
            var obj60 = f.MetaProperty();
            var obj61 = f.MetaArrayType();
            var obj62 = f.MetaProperty();
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
            obj17.MChildren.Add(obj53);
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
            obj17.Properties.Add(obj53);
            obj17.Declarations.Add(obj44);
            obj17.Declarations.Add(obj45);
            obj17.Declarations.Add(obj46);
            obj17.Declarations.Add(obj47);
            obj17.Declarations.Add(obj48);
            obj17.Declarations.Add(obj49);
            obj17.Declarations.Add(obj50);
            obj17.Declarations.Add(obj51);
            obj17.Declarations.Add(obj52);
            obj17.Declarations.Add(obj53);
            obj17.Name = "MetaProperty";
            obj17.Parent = obj4;
            obj18.MChildren.Add(obj59);
            obj18.MChildren.Add(obj60);
            obj18.BaseTypes.Add(obj6);
            obj18.Properties.Add(obj59);
            obj18.Properties.Add(obj60);
            obj18.Declarations.Add(obj59);
            obj18.Declarations.Add(obj60);
            obj18.Name = "MetaOperation";
            obj18.Parent = obj4;
            obj19.MChildren.Add(obj62);
            obj19.BaseTypes.Add(obj6);
            obj19.Properties.Add(obj62);
            obj19.Declarations.Add(obj62);
            obj19.Name = "MetaParameter";
            obj19.Parent = obj4;
            obj20.MChildren.Add(obj24);
            obj20.SymbolProperty = __MetaSymbol.FromValue("Name");
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
            obj37.SymbolProperty = __MetaSymbol.FromValue("BaseTypes");
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
            obj45.MChildren.Add(obj54);
            obj45.Type = __MetaType.FromModelObject((__IModelObject)obj54);
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
            obj49.Type = typeof(bool);
            obj49.Name = "IsUnion";
            obj49.Parent = obj17;
            obj50.MChildren.Add(obj55);
            obj50.Type = __MetaType.FromModelObject((__IModelObject)obj55);
            obj50.Name = "DefaultValue";
            obj50.Parent = obj17;
            obj51.MChildren.Add(obj56);
            obj51.Type = __MetaType.FromModelObject((__IModelObject)obj56);
            obj51.Name = "OppositeProperties";
            obj51.Parent = obj17;
            obj52.MChildren.Add(obj57);
            obj52.Type = __MetaType.FromModelObject((__IModelObject)obj57);
            obj52.Name = "SubsettedProperties";
            obj52.Parent = obj17;
            obj53.MChildren.Add(obj58);
            obj53.Type = __MetaType.FromModelObject((__IModelObject)obj58);
            obj53.Name = "RedefinedProperties";
            obj53.Parent = obj17;
            obj54.InnerType = typeof(string);
            obj55.InnerType = typeof(object);
            obj56.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
            obj57.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
            obj58.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
            obj59.Type = typeof(__MetaType);
            obj59.Name = "ReturnType";
            obj59.Parent = obj18;
            obj60.MChildren.Add(obj61);
            obj60.IsContainment = true;
            obj60.RedefinedProperties.Add(obj22);
            obj60.Type = __MetaType.FromModelObject((__IModelObject)obj61);
            obj60.Name = "Parameters";
            obj60.Parent = obj18;
            obj61.ItemType = __MetaType.FromModelObject((__IModelObject)obj19);
            obj62.Type = typeof(__MetaType);
            obj62.Name = "Type";
            obj62.Parent = obj19;
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
        public static __ModelProperty MetaProperty_IsUnion => _MetaProperty_IsUnion;
        public static __ModelProperty MetaProperty_DefaultValue => _MetaProperty_DefaultValue;
        public static __ModelProperty MetaProperty_OppositeProperties => _MetaProperty_OppositeProperties;
        public static __ModelProperty MetaProperty_SubsettedProperties => _MetaProperty_SubsettedProperties;
        public static __ModelProperty MetaProperty_RedefinedProperties => _MetaProperty_RedefinedProperties;
    }
}
