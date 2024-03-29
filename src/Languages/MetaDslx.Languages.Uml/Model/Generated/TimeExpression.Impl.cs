#nullable enable

namespace MetaDslx.Languages.Uml.Model.__Impl
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

    internal class TimeExpression_Impl : __MetaModelObject, TimeExpression
    {
        private TimeExpression_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Uml.PackageableElement_Visibility)?.Add((global::MetaDslx.Languages.Uml.Model.VisibilityKind)MetaDslx.Languages.Uml.Model.VisibilityKind.Public);
            Uml.__CustomImpl.Element(this);
            Uml.__CustomImpl.ParameterableElement(this);
            Uml.__CustomImpl.NamedElement(this);
            Uml.__CustomImpl.TypedElement(this);
            Uml.__CustomImpl.PackageableElement(this);
            Uml.__CustomImpl.ValueSpecification(this);
            Uml.__CustomImpl.TimeExpression(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public ValueSpecification Expr
        {
            get => MGet<ValueSpecification>(Uml.TimeExpression_Expr);
            set => MSet<ValueSpecification>(Uml.TimeExpression_Expr, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Observation> Observation
        {
            get => MGetCollection<Observation>(Uml.TimeExpression_Observation);
        }
    
        public global::MetaDslx.Languages.Uml.Model.VisibilityKind Visibility
        {
            get => MGet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.PackageableElement_Visibility);
            set => MSet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.PackageableElement_Visibility, value);
        }
    
        public Type Type
        {
            get => MGet<Type>(Uml.TypedElement_Type);
            set => MSet<Type>(Uml.TypedElement_Type, value);
        }
    
        public global::System.Collections.Generic.IList<Dependency> ClientDependency
        {
            get => Uml.__CustomImpl.NamedElement_ClientDependency(this);
        }
    
        public string Name
        {
            get => MGet<string>(Uml.NamedElement_Name);
            set => MSet<string>(Uml.NamedElement_Name, value);
        }
    
        public StringExpression NameExpression
        {
            get => MGet<StringExpression>(Uml.NamedElement_NameExpression);
            set => MSet<StringExpression>(Uml.NamedElement_NameExpression, value);
        }
    
        public Namespace Namespace
        {
            get => MGet<Namespace>(Uml.NamedElement_Namespace);
            set => MSet<Namespace>(Uml.NamedElement_Namespace, value);
        }
    
        public string QualifiedName
        {
            get => Uml.__CustomImpl.NamedElement_QualifiedName(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::MetaDslx.Languages.Uml.Model.VisibilityKind NamedElement.Visibility
        {
            get => MGet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.NamedElement_Visibility);
            set => MSet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.NamedElement_Visibility, value);
        }
    
        public TemplateParameter OwningTemplateParameter
        {
            get => MGet<TemplateParameter>(Uml.ParameterableElement_OwningTemplateParameter);
            set => MSet<TemplateParameter>(Uml.ParameterableElement_OwningTemplateParameter, value);
        }
    
        public TemplateParameter TemplateParameter
        {
            get => MGet<TemplateParameter>(Uml.ParameterableElement_TemplateParameter);
            set => MSet<TemplateParameter>(Uml.ParameterableElement_TemplateParameter, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Comment> OwnedComment
        {
            get => MGetCollection<Comment>(Uml.Element_OwnedComment);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Element> OwnedElement
        {
            get => MGetCollection<Element>(Uml.Element_OwnedElement);
        }
    
        public Element Owner
        {
            get => MGet<Element>(Uml.Element_Owner);
            set => MSet<Element>(Uml.Element_Owner, value);
        }
    
    
        bool ValueSpecification.BooleanValue() => Uml.__CustomImpl.ValueSpecification_BooleanValue(this);
        int ValueSpecification.IntegerValue() => Uml.__CustomImpl.ValueSpecification_IntegerValue(this);
        bool ValueSpecification.IsCompatibleWith(ParameterableElement p) => Uml.__CustomImpl.ValueSpecification_IsCompatibleWith(this, p);
        bool ValueSpecification.IsComputable() => Uml.__CustomImpl.ValueSpecification_IsComputable(this);
        bool ValueSpecification.IsNull() => Uml.__CustomImpl.ValueSpecification_IsNull(this);
        double ValueSpecification.RealValue() => Uml.__CustomImpl.ValueSpecification_RealValue(this);
        string ValueSpecification.StringValue() => Uml.__CustomImpl.ValueSpecification_StringValue(this);
        int ValueSpecification.UnlimitedValue() => Uml.__CustomImpl.ValueSpecification_UnlimitedValue(this);
        global::System.Collections.Generic.IList<Namespace> NamedElement.AllNamespaces() => Uml.__CustomImpl.NamedElement_AllNamespaces(this);
        global::System.Collections.Generic.IList<Package> NamedElement.AllOwningPackages() => Uml.__CustomImpl.NamedElement_AllOwningPackages(this);
        bool NamedElement.IsDistinguishableFrom(NamedElement n, Namespace ns) => Uml.__CustomImpl.NamedElement_IsDistinguishableFrom(this, n, ns);
        string NamedElement.Separator() => Uml.__CustomImpl.NamedElement_Separator(this);
        bool ParameterableElement.IsCompatibleWith(ParameterableElement p) => Uml.__CustomImpl.ValueSpecification_IsCompatibleWith(this, p);
        bool ParameterableElement.IsTemplateParameter() => Uml.__CustomImpl.ParameterableElement_IsTemplateParameter(this);
        global::System.Collections.Generic.IList<Element> Element.AllOwnedElements() => Uml.__CustomImpl.Element_AllOwnedElements(this);
        bool Element.MustBeOwned() => Uml.__CustomImpl.Element_MustBeOwned(this);
    
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.ValueSpecificationInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.ValueSpecificationInfo, Uml.PackageableElementInfo, Uml.TypedElementInfo, Uml.NamedElementInfo, Uml.ParameterableElementInfo, Uml.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.TimeExpression_Expr, Uml.TimeExpression_Observation);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.TimeExpression_Expr, Uml.TimeExpression_Observation, Uml.PackageableElement_Visibility, Uml.TypedElement_Type, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.ParameterableElement_OwningTemplateParameter, Uml.ParameterableElement_TemplateParameter, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Uml.TimeExpression_Expr, Uml.TimeExpression_Observation, Uml.PackageableElement_Visibility, Uml.TypedElement_Type, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.ParameterableElement_OwningTemplateParameter, Uml.ParameterableElement_TemplateParameter, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Expr", Uml.TimeExpression_Expr);
                publicPropertiesByName.Add("Observation", Uml.TimeExpression_Observation);
                publicPropertiesByName.Add("Visibility", Uml.PackageableElement_Visibility);
                publicPropertiesByName.Add("Type", Uml.TypedElement_Type);
                publicPropertiesByName.Add("ClientDependency", Uml.NamedElement_ClientDependency);
                publicPropertiesByName.Add("Name", Uml.NamedElement_Name);
                publicPropertiesByName.Add("NameExpression", Uml.NamedElement_NameExpression);
                publicPropertiesByName.Add("Namespace", Uml.NamedElement_Namespace);
                publicPropertiesByName.Add("QualifiedName", Uml.NamedElement_QualifiedName);
                publicPropertiesByName.Add("OwningTemplateParameter", Uml.ParameterableElement_OwningTemplateParameter);
                publicPropertiesByName.Add("TemplateParameter", Uml.ParameterableElement_TemplateParameter);
                publicPropertiesByName.Add("OwnedComment", Uml.Element_OwnedComment);
                publicPropertiesByName.Add("OwnedElement", Uml.Element_OwnedElement);
                publicPropertiesByName.Add("Owner", Uml.Element_Owner);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Uml.TimeExpression_Expr, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.TimeExpression_Expr, __ImmutableArray.Create<__ModelProperty>(Uml.TimeExpression_Expr), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.TimeExpression_Observation, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.TimeExpression_Observation, __ImmutableArray.Create<__ModelProperty>(Uml.TimeExpression_Observation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.PackageableElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.PackageableElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Uml.PackageableElement_Visibility, Uml.NamedElement_Visibility), MetaDslx.Languages.Uml.Model.VisibilityKind.Public, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Visibility), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Visibility), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.TypedElement_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.TypedElement_Type, __ImmutableArray.Create<__ModelProperty>(Uml.TypedElement_Type), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_ClientDependency, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_ClientDependency, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_ClientDependency), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Uml.Dependency_Client), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_NameExpression, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_NameExpression, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_NameExpression), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Namespace, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_QualifiedName, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_QualifiedName, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_QualifiedName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.PackageableElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Uml.PackageableElement_Visibility, Uml.NamedElement_Visibility), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.PackageableElement_Visibility), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.PackageableElement_Visibility)));
                modelPropertyInfos.Add(Uml.ParameterableElement_OwningTemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ParameterableElement_OwningTemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_OwnedParameteredElement), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner, Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ParameterableElement_TemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ParameterableElement_TemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_TemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.TimeExpression_Expr, Uml.NamedElement_NameExpression, Uml.Element_OwnedComment), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace, Uml.ParameterableElement_OwningTemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.ValueSpecification_BooleanValue, Uml.ValueSpecification_IntegerValue, Uml.ValueSpecification_IsCompatibleWith, Uml.ValueSpecification_IsComputable, Uml.ValueSpecification_IsNull, Uml.ValueSpecification_RealValue, Uml.ValueSpecification_StringValue, Uml.ValueSpecification_UnlimitedValue, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.ParameterableElement_IsCompatibleWith, Uml.ParameterableElement_IsTemplateParameter, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Uml.ValueSpecification_BooleanValue, Uml.ValueSpecification_IntegerValue, Uml.ValueSpecification_IsCompatibleWith, Uml.ValueSpecification_IsComputable, Uml.ValueSpecification_IsNull, Uml.ValueSpecification_RealValue, Uml.ValueSpecification_StringValue, Uml.ValueSpecification_UnlimitedValue, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.ParameterableElement_IsTemplateParameter, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Uml.ValueSpecification_BooleanValue, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ValueSpecification_IntegerValue, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ValueSpecification_IsCompatibleWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.ParameterableElement_IsCompatibleWith), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ValueSpecification_IsComputable, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ValueSpecification_IsNull, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ValueSpecification_RealValue, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ValueSpecification_StringValue, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ValueSpecification_UnlimitedValue, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_AllNamespaces, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_AllOwningPackages, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_IsDistinguishableFrom, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_Separator, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ParameterableElement_IsCompatibleWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.ValueSpecification_IsCompatibleWith)));
                    modelOperationInfos.Add(Uml.ParameterableElement_IsTemplateParameter, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_AllOwnedElements, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_MustBeOwned, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Uml.MInstance;
            public override __MetaType MetaType => typeof(TimeExpression);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Uml.NamedElement_Name;
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
                var result = new TimeExpression_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Uml.TimeExpressionInfo";
            }
        }
    }
}
