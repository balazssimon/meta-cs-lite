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

    internal class ExtensionEnd_Impl : __MetaModelObject, ExtensionEnd
    {
        private ExtensionEnd_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Uml.Property_Aggregation)?.Add((global::MetaDslx.Languages.Uml.Model.AggregationKind)MetaDslx.Languages.Uml.Model.AggregationKind.None);
            ((__IModelObject)this).MGetSlot(Uml.Property_IsDerived)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.Property_IsDerivedUnion)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.Property_IsID)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.StructuralFeature_IsReadOnly)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.Feature_IsStatic)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.MultiplicityElement_IsOrdered)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.MultiplicityElement_IsUnique)?.Add((bool)true);
            ((__IModelObject)this).MGetSlot(Uml.RedefinableElement_IsLeaf)?.Add((bool)false);
            Uml.__CustomImpl.Element(this);
            Uml.__CustomImpl.NamedElement(this);
            Uml.__CustomImpl.TypedElement(this);
            Uml.__CustomImpl.RedefinableElement(this);
            Uml.__CustomImpl.MultiplicityElement(this);
            Uml.__CustomImpl.Feature(this);
            Uml.__CustomImpl.StructuralFeature(this);
            Uml.__CustomImpl.ParameterableElement(this);
            Uml.__CustomImpl.DeploymentTarget(this);
            Uml.__CustomImpl.ConnectableElement(this);
            Uml.__CustomImpl.Property(this);
            Uml.__CustomImpl.ExtensionEnd(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public int Lower
        {
            get => Uml.__CustomImpl.ExtensionEnd_Lower(this);
        }
    
        public Stereotype Type
        {
            get => MGet<Stereotype>(Uml.ExtensionEnd_Type);
            set => MSet<Stereotype>(Uml.ExtensionEnd_Type, value);
        }
    
        public global::MetaDslx.Languages.Uml.Model.AggregationKind Aggregation
        {
            get => MGet<global::MetaDslx.Languages.Uml.Model.AggregationKind>(Uml.Property_Aggregation);
            set => MSet<global::MetaDslx.Languages.Uml.Model.AggregationKind>(Uml.Property_Aggregation, value);
        }
    
        public Association Association
        {
            get => MGet<Association>(Uml.Property_Association);
            set => MSet<Association>(Uml.Property_Association, value);
        }
    
        public Property AssociationEnd
        {
            get => MGet<Property>(Uml.Property_AssociationEnd);
            set => MSet<Property>(Uml.Property_AssociationEnd, value);
        }
    
        public Class Class
        {
            get => MGet<Class>(Uml.Property_Class);
            set => MSet<Class>(Uml.Property_Class, value);
        }
    
        public DataType Datatype
        {
            get => MGet<DataType>(Uml.Property_Datatype);
            set => MSet<DataType>(Uml.Property_Datatype, value);
        }
    
        public ValueSpecification DefaultValue
        {
            get => MGet<ValueSpecification>(Uml.Property_DefaultValue);
            set => MSet<ValueSpecification>(Uml.Property_DefaultValue, value);
        }
    
        public Interface Interface
        {
            get => MGet<Interface>(Uml.Property_Interface);
            set => MSet<Interface>(Uml.Property_Interface, value);
        }
    
        public bool IsComposite
        {
            get => Uml.__CustomImpl.Property_IsComposite(this);
        }
    
        public bool IsDerived
        {
            get => MGet<bool>(Uml.Property_IsDerived);
            set => MSet<bool>(Uml.Property_IsDerived, value);
        }
    
        public bool IsDerivedUnion
        {
            get => MGet<bool>(Uml.Property_IsDerivedUnion);
            set => MSet<bool>(Uml.Property_IsDerivedUnion, value);
        }
    
        public bool IsID
        {
            get => MGet<bool>(Uml.Property_IsID);
            set => MSet<bool>(Uml.Property_IsID, value);
        }
    
        public Property Opposite
        {
            get => Uml.__CustomImpl.Property_Opposite(this);
        }
    
        public Association OwningAssociation
        {
            get => MGet<Association>(Uml.Property_OwningAssociation);
            set => MSet<Association>(Uml.Property_OwningAssociation, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Property> Qualifier
        {
            get => MGetCollection<Property>(Uml.Property_Qualifier);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Property> RedefinedProperty
        {
            get => MGetCollection<Property>(Uml.Property_RedefinedProperty);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Property> SubsettedProperty
        {
            get => MGetCollection<Property>(Uml.Property_SubsettedProperty);
        }
    
        public global::System.Collections.Generic.IList<ConnectorEnd> End
        {
            get => Uml.__CustomImpl.ConnectableElement_End(this);
        }
    
        public ConnectableElementTemplateParameter TemplateParameter
        {
            get => MGet<ConnectableElementTemplateParameter>(Uml.ConnectableElement_TemplateParameter);
            set => MSet<ConnectableElementTemplateParameter>(Uml.ConnectableElement_TemplateParameter, value);
        }
    
        public global::System.Collections.Generic.IList<PackageableElement> DeployedElement
        {
            get => Uml.__CustomImpl.DeploymentTarget_DeployedElement(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Deployment> Deployment
        {
            get => MGetCollection<Deployment>(Uml.DeploymentTarget_Deployment);
        }
    
        public TemplateParameter OwningTemplateParameter
        {
            get => MGet<TemplateParameter>(Uml.ParameterableElement_OwningTemplateParameter);
            set => MSet<TemplateParameter>(Uml.ParameterableElement_OwningTemplateParameter, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        TemplateParameter ParameterableElement.TemplateParameter
        {
            get => MGet<TemplateParameter>(Uml.ParameterableElement_TemplateParameter);
            set => MSet<TemplateParameter>(Uml.ParameterableElement_TemplateParameter, value);
        }
    
        public bool IsReadOnly
        {
            get => MGet<bool>(Uml.StructuralFeature_IsReadOnly);
            set => MSet<bool>(Uml.StructuralFeature_IsReadOnly, value);
        }
    
        public Classifier FeaturingClassifier
        {
            get => MGet<Classifier>(Uml.Feature_FeaturingClassifier);
            set => MSet<Classifier>(Uml.Feature_FeaturingClassifier, value);
        }
    
        public bool IsStatic
        {
            get => MGet<bool>(Uml.Feature_IsStatic);
            set => MSet<bool>(Uml.Feature_IsStatic, value);
        }
    
        public bool IsOrdered
        {
            get => MGet<bool>(Uml.MultiplicityElement_IsOrdered);
            set => MSet<bool>(Uml.MultiplicityElement_IsOrdered, value);
        }
    
        public bool IsUnique
        {
            get => MGet<bool>(Uml.MultiplicityElement_IsUnique);
            set => MSet<bool>(Uml.MultiplicityElement_IsUnique, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        int MultiplicityElement.Lower
        {
            get => Uml.__CustomImpl.ExtensionEnd_Lower(this);
        }
    
        public ValueSpecification LowerValue
        {
            get => MGet<ValueSpecification>(Uml.MultiplicityElement_LowerValue);
            set => MSet<ValueSpecification>(Uml.MultiplicityElement_LowerValue, value);
        }
    
        public int Upper
        {
            get => Uml.__CustomImpl.MultiplicityElement_Upper(this);
        }
    
        public ValueSpecification UpperValue
        {
            get => MGet<ValueSpecification>(Uml.MultiplicityElement_UpperValue);
            set => MSet<ValueSpecification>(Uml.MultiplicityElement_UpperValue, value);
        }
    
        public bool IsLeaf
        {
            get => MGet<bool>(Uml.RedefinableElement_IsLeaf);
            set => MSet<bool>(Uml.RedefinableElement_IsLeaf, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<RedefinableElement> RedefinedElement
        {
            get => MGetCollection<RedefinableElement>(Uml.RedefinableElement_RedefinedElement);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Classifier> RedefinitionContext
        {
            get => MGetCollection<Classifier>(Uml.RedefinableElement_RedefinitionContext);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        Type TypedElement.Type
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
    
        public global::MetaDslx.Languages.Uml.Model.VisibilityKind Visibility
        {
            get => MGet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.NamedElement_Visibility);
            set => MSet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.NamedElement_Visibility, value);
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
    
    
        int ExtensionEnd.LowerBound() => Uml.__CustomImpl.ExtensionEnd_LowerBound(this);
        bool Property.IsAttribute() => Uml.__CustomImpl.Property_IsAttribute(this);
        bool Property.IsCompatibleWith(ParameterableElement p) => Uml.__CustomImpl.Property_IsCompatibleWith(this, p);
        bool Property.IsConsistentWith(RedefinableElement redefiningElement) => Uml.__CustomImpl.Property_IsConsistentWith(this, redefiningElement);
        bool Property.IsNavigable() => Uml.__CustomImpl.Property_IsNavigable(this);
        global::System.Collections.Generic.IList<Type> Property.SubsettingContext() => Uml.__CustomImpl.Property_SubsettingContext(this);
        bool ParameterableElement.IsCompatibleWith(ParameterableElement p) => Uml.__CustomImpl.Property_IsCompatibleWith(this, p);
        bool ParameterableElement.IsTemplateParameter() => Uml.__CustomImpl.ParameterableElement_IsTemplateParameter(this);
        bool MultiplicityElement.CompatibleWith(MultiplicityElement other) => Uml.__CustomImpl.MultiplicityElement_CompatibleWith(this, other);
        bool MultiplicityElement.IncludesMultiplicity(MultiplicityElement M) => Uml.__CustomImpl.MultiplicityElement_IncludesMultiplicity(this, M);
        bool MultiplicityElement.Is(int lowerbound, int upperbound) => Uml.__CustomImpl.MultiplicityElement_Is(this, lowerbound, upperbound);
        bool MultiplicityElement.IsMultivalued() => Uml.__CustomImpl.MultiplicityElement_IsMultivalued(this);
        int MultiplicityElement.LowerBound() => Uml.__CustomImpl.ExtensionEnd_LowerBound(this);
        int MultiplicityElement.UpperBound() => Uml.__CustomImpl.MultiplicityElement_UpperBound(this);
        bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement) => Uml.__CustomImpl.Property_IsConsistentWith(this, redefiningElement);
        bool RedefinableElement.IsRedefinitionContextValid(RedefinableElement redefinedElement) => Uml.__CustomImpl.RedefinableElement_IsRedefinitionContextValid(this, redefinedElement);
        global::System.Collections.Generic.IList<Namespace> NamedElement.AllNamespaces() => Uml.__CustomImpl.NamedElement_AllNamespaces(this);
        global::System.Collections.Generic.IList<Package> NamedElement.AllOwningPackages() => Uml.__CustomImpl.NamedElement_AllOwningPackages(this);
        bool NamedElement.IsDistinguishableFrom(NamedElement n, Namespace ns) => Uml.__CustomImpl.NamedElement_IsDistinguishableFrom(this, n, ns);
        string NamedElement.Separator() => Uml.__CustomImpl.NamedElement_Separator(this);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.PropertyInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.PropertyInfo, Uml.ConnectableElementInfo, Uml.DeploymentTargetInfo, Uml.ParameterableElementInfo, Uml.StructuralFeatureInfo, Uml.FeatureInfo, Uml.MultiplicityElementInfo, Uml.RedefinableElementInfo, Uml.TypedElementInfo, Uml.NamedElementInfo, Uml.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.ExtensionEnd_Lower, Uml.ExtensionEnd_Type);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.ExtensionEnd_Lower, Uml.ExtensionEnd_Type, Uml.Property_Aggregation, Uml.Property_Association, Uml.Property_AssociationEnd, Uml.Property_Class, Uml.Property_Datatype, Uml.Property_DefaultValue, Uml.Property_Interface, Uml.Property_IsComposite, Uml.Property_IsDerived, Uml.Property_IsDerivedUnion, Uml.Property_IsID, Uml.Property_Opposite, Uml.Property_OwningAssociation, Uml.Property_Qualifier, Uml.Property_RedefinedProperty, Uml.Property_SubsettedProperty, Uml.ConnectableElement_End, Uml.ConnectableElement_TemplateParameter, Uml.DeploymentTarget_DeployedElement, Uml.DeploymentTarget_Deployment, Uml.ParameterableElement_OwningTemplateParameter, Uml.ParameterableElement_TemplateParameter, Uml.StructuralFeature_IsReadOnly, Uml.Feature_FeaturingClassifier, Uml.Feature_IsStatic, Uml.MultiplicityElement_IsOrdered, Uml.MultiplicityElement_IsUnique, Uml.MultiplicityElement_Lower, Uml.MultiplicityElement_LowerValue, Uml.MultiplicityElement_Upper, Uml.MultiplicityElement_UpperValue, Uml.RedefinableElement_IsLeaf, Uml.RedefinableElement_RedefinedElement, Uml.RedefinableElement_RedefinitionContext, Uml.TypedElement_Type, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Uml.ExtensionEnd_Lower, Uml.ExtensionEnd_Type, Uml.Property_Aggregation, Uml.Property_Association, Uml.Property_AssociationEnd, Uml.Property_Class, Uml.Property_Datatype, Uml.Property_DefaultValue, Uml.Property_Interface, Uml.Property_IsComposite, Uml.Property_IsDerived, Uml.Property_IsDerivedUnion, Uml.Property_IsID, Uml.Property_Opposite, Uml.Property_OwningAssociation, Uml.Property_Qualifier, Uml.Property_RedefinedProperty, Uml.Property_SubsettedProperty, Uml.ConnectableElement_End, Uml.ConnectableElement_TemplateParameter, Uml.DeploymentTarget_DeployedElement, Uml.DeploymentTarget_Deployment, Uml.ParameterableElement_OwningTemplateParameter, Uml.StructuralFeature_IsReadOnly, Uml.Feature_FeaturingClassifier, Uml.Feature_IsStatic, Uml.MultiplicityElement_IsOrdered, Uml.MultiplicityElement_IsUnique, Uml.MultiplicityElement_LowerValue, Uml.MultiplicityElement_Upper, Uml.MultiplicityElement_UpperValue, Uml.RedefinableElement_IsLeaf, Uml.RedefinableElement_RedefinedElement, Uml.RedefinableElement_RedefinitionContext, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Lower", Uml.ExtensionEnd_Lower);
                publicPropertiesByName.Add("Type", Uml.ExtensionEnd_Type);
                publicPropertiesByName.Add("Aggregation", Uml.Property_Aggregation);
                publicPropertiesByName.Add("Association", Uml.Property_Association);
                publicPropertiesByName.Add("AssociationEnd", Uml.Property_AssociationEnd);
                publicPropertiesByName.Add("Class", Uml.Property_Class);
                publicPropertiesByName.Add("Datatype", Uml.Property_Datatype);
                publicPropertiesByName.Add("DefaultValue", Uml.Property_DefaultValue);
                publicPropertiesByName.Add("Interface", Uml.Property_Interface);
                publicPropertiesByName.Add("IsComposite", Uml.Property_IsComposite);
                publicPropertiesByName.Add("IsDerived", Uml.Property_IsDerived);
                publicPropertiesByName.Add("IsDerivedUnion", Uml.Property_IsDerivedUnion);
                publicPropertiesByName.Add("IsID", Uml.Property_IsID);
                publicPropertiesByName.Add("Opposite", Uml.Property_Opposite);
                publicPropertiesByName.Add("OwningAssociation", Uml.Property_OwningAssociation);
                publicPropertiesByName.Add("Qualifier", Uml.Property_Qualifier);
                publicPropertiesByName.Add("RedefinedProperty", Uml.Property_RedefinedProperty);
                publicPropertiesByName.Add("SubsettedProperty", Uml.Property_SubsettedProperty);
                publicPropertiesByName.Add("End", Uml.ConnectableElement_End);
                publicPropertiesByName.Add("TemplateParameter", Uml.ConnectableElement_TemplateParameter);
                publicPropertiesByName.Add("DeployedElement", Uml.DeploymentTarget_DeployedElement);
                publicPropertiesByName.Add("Deployment", Uml.DeploymentTarget_Deployment);
                publicPropertiesByName.Add("OwningTemplateParameter", Uml.ParameterableElement_OwningTemplateParameter);
                publicPropertiesByName.Add("IsReadOnly", Uml.StructuralFeature_IsReadOnly);
                publicPropertiesByName.Add("FeaturingClassifier", Uml.Feature_FeaturingClassifier);
                publicPropertiesByName.Add("IsStatic", Uml.Feature_IsStatic);
                publicPropertiesByName.Add("IsOrdered", Uml.MultiplicityElement_IsOrdered);
                publicPropertiesByName.Add("IsUnique", Uml.MultiplicityElement_IsUnique);
                publicPropertiesByName.Add("LowerValue", Uml.MultiplicityElement_LowerValue);
                publicPropertiesByName.Add("Upper", Uml.MultiplicityElement_Upper);
                publicPropertiesByName.Add("UpperValue", Uml.MultiplicityElement_UpperValue);
                publicPropertiesByName.Add("IsLeaf", Uml.RedefinableElement_IsLeaf);
                publicPropertiesByName.Add("RedefinedElement", Uml.RedefinableElement_RedefinedElement);
                publicPropertiesByName.Add("RedefinitionContext", Uml.RedefinableElement_RedefinitionContext);
                publicPropertiesByName.Add("ClientDependency", Uml.NamedElement_ClientDependency);
                publicPropertiesByName.Add("Name", Uml.NamedElement_Name);
                publicPropertiesByName.Add("NameExpression", Uml.NamedElement_NameExpression);
                publicPropertiesByName.Add("Namespace", Uml.NamedElement_Namespace);
                publicPropertiesByName.Add("QualifiedName", Uml.NamedElement_QualifiedName);
                publicPropertiesByName.Add("Visibility", Uml.NamedElement_Visibility);
                publicPropertiesByName.Add("OwnedComment", Uml.Element_OwnedComment);
                publicPropertiesByName.Add("OwnedElement", Uml.Element_OwnedElement);
                publicPropertiesByName.Add("Owner", Uml.Element_Owner);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Uml.ExtensionEnd_Lower, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ExtensionEnd_Lower, __ImmutableArray.Create<__ModelProperty>(Uml.ExtensionEnd_Lower, Uml.MultiplicityElement_Lower), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_Lower), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_Lower), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ExtensionEnd_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ExtensionEnd_Type, __ImmutableArray.Create<__ModelProperty>(Uml.ExtensionEnd_Type, Uml.TypedElement_Type), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.TypedElement_Type), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.TypedElement_Type), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_Aggregation, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_Aggregation, __ImmutableArray.Create<__ModelProperty>(Uml.Property_Aggregation), MetaDslx.Languages.Uml.Model.AggregationKind.None, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_Association, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_Association, __ImmutableArray.Create<__ModelProperty>(Uml.Property_Association), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Association_MemberEnd), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Property_OwningAssociation), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_AssociationEnd, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_AssociationEnd, __ImmutableArray.Create<__ModelProperty>(Uml.Property_AssociationEnd), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Property_Qualifier), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_Class, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_Class, __ImmutableArray.Create<__ModelProperty>(Uml.Property_Class), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Class_OwnedAttribute), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_Datatype, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_Datatype, __ImmutableArray.Create<__ModelProperty>(Uml.Property_Datatype), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.DataType_OwnedAttribute), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_DefaultValue, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_DefaultValue, __ImmutableArray.Create<__ModelProperty>(Uml.Property_DefaultValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_Interface, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_Interface, __ImmutableArray.Create<__ModelProperty>(Uml.Property_Interface), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Interface_OwnedAttribute), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_IsComposite, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_IsComposite, __ImmutableArray.Create<__ModelProperty>(Uml.Property_IsComposite), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_IsDerived, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_IsDerived, __ImmutableArray.Create<__ModelProperty>(Uml.Property_IsDerived), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_IsDerivedUnion, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_IsDerivedUnion, __ImmutableArray.Create<__ModelProperty>(Uml.Property_IsDerivedUnion), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_IsID, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_IsID, __ImmutableArray.Create<__ModelProperty>(Uml.Property_IsID), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_Opposite, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_Opposite, __ImmutableArray.Create<__ModelProperty>(Uml.Property_Opposite), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_OwningAssociation, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_OwningAssociation, __ImmutableArray.Create<__ModelProperty>(Uml.Property_OwningAssociation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Association_OwnedEnd), __ImmutableArray.Create<__ModelProperty>(Uml.Feature_FeaturingClassifier, Uml.NamedElement_Namespace, Uml.Property_Association, Uml.RedefinableElement_RedefinitionContext), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_Qualifier, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_Qualifier, __ImmutableArray.Create<__ModelProperty>(Uml.Property_Qualifier), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Property_AssociationEnd), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_RedefinedProperty, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_RedefinedProperty, __ImmutableArray.Create<__ModelProperty>(Uml.Property_RedefinedProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Property_SubsettedProperty, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Property_SubsettedProperty, __ImmutableArray.Create<__ModelProperty>(Uml.Property_SubsettedProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ConnectableElement_End, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ConnectableElement_End, __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElement_End), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Uml.ConnectorEnd_Role), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ConnectableElement_TemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ConnectableElement_TemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElement_TemplateParameter, Uml.ParameterableElement_TemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElementTemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.DeploymentTarget_DeployedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.DeploymentTarget_DeployedElement, __ImmutableArray.Create<__ModelProperty>(Uml.DeploymentTarget_DeployedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.DeploymentTarget_Deployment, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.DeploymentTarget_Deployment, __ImmutableArray.Create<__ModelProperty>(Uml.DeploymentTarget_Deployment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Deployment_Location), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement, Uml.NamedElement_ClientDependency), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ParameterableElement_OwningTemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ParameterableElement_OwningTemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_OwnedParameteredElement), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner, Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ParameterableElement_TemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ConnectableElement_TemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElement_TemplateParameter, Uml.ParameterableElement_TemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElement_TemplateParameter)));
                modelPropertyInfos.Add(Uml.StructuralFeature_IsReadOnly, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuralFeature_IsReadOnly, __ImmutableArray.Create<__ModelProperty>(Uml.StructuralFeature_IsReadOnly), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Feature_FeaturingClassifier, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Feature_FeaturingClassifier, __ImmutableArray.Create<__ModelProperty>(Uml.Feature_FeaturingClassifier), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Feature), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Property_OwningAssociation), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Feature_IsStatic, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Feature_IsStatic, __ImmutableArray.Create<__ModelProperty>(Uml.Feature_IsStatic), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_IsOrdered, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_IsOrdered, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_IsOrdered), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_IsUnique, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_IsUnique, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_IsUnique), true, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_Lower, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ExtensionEnd_Lower, __ImmutableArray.Create<__ModelProperty>(Uml.ExtensionEnd_Lower, Uml.MultiplicityElement_Lower), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ExtensionEnd_Lower), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ExtensionEnd_Lower)));
                modelPropertyInfos.Add(Uml.MultiplicityElement_LowerValue, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_LowerValue, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_LowerValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_Upper, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_Upper, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_Upper), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_UpperValue, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_UpperValue, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_UpperValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_IsLeaf, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_IsLeaf, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_IsLeaf), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_RedefinedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_RedefinedElement, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Property_RedefinedProperty), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_RedefinitionContext, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_RedefinitionContext, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinitionContext), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Property_OwningAssociation), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.TypedElement_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ExtensionEnd_Type, __ImmutableArray.Create<__ModelProperty>(Uml.ExtensionEnd_Type, Uml.TypedElement_Type), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ExtensionEnd_Type), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ExtensionEnd_Type)));
                modelPropertyInfos.Add(Uml.NamedElement_ClientDependency, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_ClientDependency, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_ClientDependency), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Uml.Dependency_Client), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.DeploymentTarget_Deployment), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_NameExpression, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_NameExpression, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_NameExpression), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Namespace, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(Uml.Property_Class, Uml.Property_Datatype, Uml.Property_Interface, Uml.Property_OwningAssociation), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_QualifiedName, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_QualifiedName, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_QualifiedName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Visibility), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Property_DefaultValue, Uml.Property_Qualifier, Uml.DeploymentTarget_Deployment, Uml.MultiplicityElement_LowerValue, Uml.MultiplicityElement_UpperValue, Uml.NamedElement_NameExpression, Uml.Element_OwnedComment), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Property_AssociationEnd, Uml.ParameterableElement_OwningTemplateParameter, Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.ExtensionEnd_LowerBound);
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.ExtensionEnd_LowerBound, Uml.Property_IsAttribute, Uml.Property_IsCompatibleWith, Uml.Property_IsConsistentWith, Uml.Property_IsNavigable, Uml.Property_SubsettingContext, Uml.ParameterableElement_IsCompatibleWith, Uml.ParameterableElement_IsTemplateParameter, Uml.MultiplicityElement_CompatibleWith, Uml.MultiplicityElement_IncludesMultiplicity, Uml.MultiplicityElement_Is, Uml.MultiplicityElement_IsMultivalued, Uml.MultiplicityElement_LowerBound, Uml.MultiplicityElement_UpperBound, Uml.RedefinableElement_IsConsistentWith, Uml.RedefinableElement_IsRedefinitionContextValid, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Uml.ExtensionEnd_LowerBound, Uml.Property_IsAttribute, Uml.Property_IsCompatibleWith, Uml.Property_IsConsistentWith, Uml.Property_IsNavigable, Uml.Property_SubsettingContext, Uml.ParameterableElement_IsTemplateParameter, Uml.MultiplicityElement_CompatibleWith, Uml.MultiplicityElement_IncludesMultiplicity, Uml.MultiplicityElement_Is, Uml.MultiplicityElement_IsMultivalued, Uml.MultiplicityElement_UpperBound, Uml.RedefinableElement_IsRedefinitionContextValid, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Uml.ExtensionEnd_LowerBound, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.MultiplicityElement_LowerBound), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Property_IsAttribute, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Property_IsCompatibleWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.ParameterableElement_IsCompatibleWith), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Property_IsConsistentWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.RedefinableElement_IsConsistentWith), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Property_IsNavigable, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Property_SubsettingContext, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ParameterableElement_IsCompatibleWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.Property_IsCompatibleWith)));
                    modelOperationInfos.Add(Uml.ParameterableElement_IsTemplateParameter, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_CompatibleWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_IncludesMultiplicity, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_Is, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_IsMultivalued, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_LowerBound, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.ExtensionEnd_LowerBound)));
                    modelOperationInfos.Add(Uml.MultiplicityElement_UpperBound, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.RedefinableElement_IsConsistentWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.Property_IsConsistentWith)));
                    modelOperationInfos.Add(Uml.RedefinableElement_IsRedefinitionContextValid, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_AllNamespaces, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_AllOwningPackages, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_IsDistinguishableFrom, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_Separator, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_AllOwnedElements, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_MustBeOwned, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Uml.MInstance;
            public override __MetaType MetaType => typeof(ExtensionEnd);
    
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
                var result = new ExtensionEnd_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Uml.ExtensionEndInfo";
            }
        }
    }
}
