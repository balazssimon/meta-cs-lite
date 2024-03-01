#nullable enable

namespace MetaDslx.Languages.MetaCompiler.Model.__Impl
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

    internal class Element_Impl : __MetaModelObject, Element
    {
        private Element_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.Element(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public MetaDslx.Languages.MetaCompiler.Model.Assignment Assignment
        {
            get => MGet<MetaDslx.Languages.MetaCompiler.Model.Assignment>(Compiler.Element_Assignment);
            set => MSet<MetaDslx.Languages.MetaCompiler.Model.Assignment>(Compiler.Element_Assignment, value);
        }
    
        public string FieldName
        {
            get => Compiler.__CustomImpl.Element_FieldName(this);
        }
    
        public string GreenFieldType
        {
            get => Compiler.__CustomImpl.Element_GreenFieldType(this);
        }
    
        public string GreenParameterValue
        {
            get => Compiler.__CustomImpl.Element_GreenParameterValue(this);
        }
    
        public string GreenPropertyType
        {
            get => Compiler.__CustomImpl.Element_GreenPropertyType(this);
        }
    
        public string GreenPropertyValue
        {
            get => Compiler.__CustomImpl.Element_GreenPropertyValue(this);
        }
    
        public string? GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.Element_GreenSyntaxCondition(this);
        }
    
        public string? GreenSyntaxNullCondition
        {
            get => Compiler.__CustomImpl.Element_GreenSyntaxNullCondition(this);
        }
    
        public bool IsList
        {
            get => Compiler.__CustomImpl.Element_IsList(this);
        }
    
        public bool IsOptionalUpdateParameter
        {
            get => Compiler.__CustomImpl.Element_IsOptionalUpdateParameter(this);
        }
    
        public bool IsToken
        {
            get => Compiler.__CustomImpl.Element_IsToken(this);
        }
    
        public string? Name
        {
            get => MGet<string?>(Compiler.Element_Name);
            set => MSet<string?>(Compiler.Element_Name, value);
        }
    
        public string ParameterName
        {
            get => Compiler.__CustomImpl.Element_ParameterName(this);
        }
    
        public string PropertyName
        {
            get => Compiler.__CustomImpl.Element_PropertyName(this);
        }
    
        public string RedFieldType
        {
            get => Compiler.__CustomImpl.Element_RedFieldType(this);
        }
    
        public string RedParameterValue
        {
            get => Compiler.__CustomImpl.Element_RedParameterValue(this);
        }
    
        public string RedPropertyType
        {
            get => Compiler.__CustomImpl.Element_RedPropertyType(this);
        }
    
        public string RedPropertyValue
        {
            get => Compiler.__CustomImpl.Element_RedPropertyValue(this);
        }
    
        public string? RedSyntaxCondition
        {
            get => Compiler.__CustomImpl.Element_RedSyntaxCondition(this);
        }
    
        public string? RedSyntaxNullCondition
        {
            get => Compiler.__CustomImpl.Element_RedSyntaxNullCondition(this);
        }
    
        public string RedToGreenArgument
        {
            get => Compiler.__CustomImpl.Element_RedToGreenArgument(this);
        }
    
        public string RedToGreenOptionalArgument
        {
            get => Compiler.__CustomImpl.Element_RedToGreenOptionalArgument(this);
        }
    
        public MetaDslx.Languages.MetaCompiler.Model.ElementValue Value
        {
            get => MGet<MetaDslx.Languages.MetaCompiler.Model.ElementValue>(Compiler.Element_Value);
            set => MSet<MetaDslx.Languages.MetaCompiler.Model.ElementValue>(Compiler.Element_Value, value);
        }
    
        public string? VisitCall
        {
            get => Compiler.__CustomImpl.Element_VisitCall(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public string AntlrName
        {
            get => MGet<string>(Compiler.CSharpElement_AntlrName);
            set => MSet<string>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public bool ContainsBinders
        {
            get => MGet<bool>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<bool>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public string CSharpName
        {
            get => MGet<string>(Compiler.CSharpElement_CSharpName);
            set => MSet<string>(Compiler.CSharpElement_CSharpName, value);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Assignment, Compiler.Element_FieldName, Compiler.Element_GreenFieldType, Compiler.Element_GreenParameterValue, Compiler.Element_GreenPropertyType, Compiler.Element_GreenPropertyValue, Compiler.Element_GreenSyntaxCondition, Compiler.Element_GreenSyntaxNullCondition, Compiler.Element_IsList, Compiler.Element_IsOptionalUpdateParameter, Compiler.Element_IsToken, Compiler.Element_Name, Compiler.Element_ParameterName, Compiler.Element_PropertyName, Compiler.Element_RedFieldType, Compiler.Element_RedParameterValue, Compiler.Element_RedPropertyType, Compiler.Element_RedPropertyValue, Compiler.Element_RedSyntaxCondition, Compiler.Element_RedSyntaxNullCondition, Compiler.Element_RedToGreenArgument, Compiler.Element_RedToGreenOptionalArgument, Compiler.Element_Value, Compiler.Element_VisitCall);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Assignment, Compiler.Element_FieldName, Compiler.Element_GreenFieldType, Compiler.Element_GreenParameterValue, Compiler.Element_GreenPropertyType, Compiler.Element_GreenPropertyValue, Compiler.Element_GreenSyntaxCondition, Compiler.Element_GreenSyntaxNullCondition, Compiler.Element_IsList, Compiler.Element_IsOptionalUpdateParameter, Compiler.Element_IsToken, Compiler.Element_Name, Compiler.Element_ParameterName, Compiler.Element_PropertyName, Compiler.Element_RedFieldType, Compiler.Element_RedParameterValue, Compiler.Element_RedPropertyType, Compiler.Element_RedPropertyValue, Compiler.Element_RedSyntaxCondition, Compiler.Element_RedSyntaxNullCondition, Compiler.Element_RedToGreenArgument, Compiler.Element_RedToGreenOptionalArgument, Compiler.Element_Value, Compiler.Element_VisitCall, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Assignment, Compiler.Element_FieldName, Compiler.Element_GreenFieldType, Compiler.Element_GreenParameterValue, Compiler.Element_GreenPropertyType, Compiler.Element_GreenPropertyValue, Compiler.Element_GreenSyntaxCondition, Compiler.Element_GreenSyntaxNullCondition, Compiler.Element_IsList, Compiler.Element_IsOptionalUpdateParameter, Compiler.Element_IsToken, Compiler.Element_Name, Compiler.Element_ParameterName, Compiler.Element_PropertyName, Compiler.Element_RedFieldType, Compiler.Element_RedParameterValue, Compiler.Element_RedPropertyType, Compiler.Element_RedPropertyValue, Compiler.Element_RedSyntaxCondition, Compiler.Element_RedSyntaxNullCondition, Compiler.Element_RedToGreenArgument, Compiler.Element_RedToGreenOptionalArgument, Compiler.Element_Value, Compiler.Element_VisitCall, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Assignment", Compiler.Element_Assignment);
                publicPropertiesByName.Add("FieldName", Compiler.Element_FieldName);
                publicPropertiesByName.Add("GreenFieldType", Compiler.Element_GreenFieldType);
                publicPropertiesByName.Add("GreenParameterValue", Compiler.Element_GreenParameterValue);
                publicPropertiesByName.Add("GreenPropertyType", Compiler.Element_GreenPropertyType);
                publicPropertiesByName.Add("GreenPropertyValue", Compiler.Element_GreenPropertyValue);
                publicPropertiesByName.Add("GreenSyntaxCondition", Compiler.Element_GreenSyntaxCondition);
                publicPropertiesByName.Add("GreenSyntaxNullCondition", Compiler.Element_GreenSyntaxNullCondition);
                publicPropertiesByName.Add("IsList", Compiler.Element_IsList);
                publicPropertiesByName.Add("IsOptionalUpdateParameter", Compiler.Element_IsOptionalUpdateParameter);
                publicPropertiesByName.Add("IsToken", Compiler.Element_IsToken);
                publicPropertiesByName.Add("Name", Compiler.Element_Name);
                publicPropertiesByName.Add("ParameterName", Compiler.Element_ParameterName);
                publicPropertiesByName.Add("PropertyName", Compiler.Element_PropertyName);
                publicPropertiesByName.Add("RedFieldType", Compiler.Element_RedFieldType);
                publicPropertiesByName.Add("RedParameterValue", Compiler.Element_RedParameterValue);
                publicPropertiesByName.Add("RedPropertyType", Compiler.Element_RedPropertyType);
                publicPropertiesByName.Add("RedPropertyValue", Compiler.Element_RedPropertyValue);
                publicPropertiesByName.Add("RedSyntaxCondition", Compiler.Element_RedSyntaxCondition);
                publicPropertiesByName.Add("RedSyntaxNullCondition", Compiler.Element_RedSyntaxNullCondition);
                publicPropertiesByName.Add("RedToGreenArgument", Compiler.Element_RedToGreenArgument);
                publicPropertiesByName.Add("RedToGreenOptionalArgument", Compiler.Element_RedToGreenOptionalArgument);
                publicPropertiesByName.Add("Value", Compiler.Element_Value);
                publicPropertiesByName.Add("VisitCall", Compiler.Element_VisitCall);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Element_Assignment, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_Assignment, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Assignment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_FieldName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_FieldName, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_FieldName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenFieldType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenFieldType, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenFieldType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenParameterValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenParameterValue, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenParameterValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenPropertyType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenPropertyType, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenPropertyType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenPropertyValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenPropertyValue, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenPropertyValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenSyntaxCondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenSyntaxNullCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenSyntaxNullCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenSyntaxNullCondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_IsList, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_IsList, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_IsList), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_IsOptionalUpdateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_IsOptionalUpdateParameter, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_IsOptionalUpdateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_IsToken, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_IsToken, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_IsToken), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_ParameterName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_ParameterName, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_ParameterName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_PropertyName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_PropertyName, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_PropertyName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedFieldType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedFieldType, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedFieldType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedParameterValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedParameterValue, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedParameterValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedPropertyType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedPropertyType, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedPropertyType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedPropertyValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedPropertyValue, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedPropertyValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedSyntaxCondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedSyntaxNullCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedSyntaxNullCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedSyntaxNullCondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedToGreenArgument, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedToGreenArgument, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedToGreenArgument), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedToGreenOptionalArgument, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedToGreenOptionalArgument, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedToGreenOptionalArgument), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Value), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_VisitCall, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_VisitCall, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_VisitCall), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Element);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Languages.MetaCompiler.Symbols.PElementSymbol);
            public override __ModelProperty? NameProperty => Compiler.Element_Name;
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
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.ElementInfo";
            }
        }
    }
}
