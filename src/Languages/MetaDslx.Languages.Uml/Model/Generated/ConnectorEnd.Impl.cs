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

    internal class ConnectorEnd_Impl : __MetaModelObject, ConnectorEnd
    {
        private ConnectorEnd_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Uml.MultiplicityElement_IsOrdered)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.MultiplicityElement_IsUnique)?.Add((bool)true);
            Uml.__CustomImpl.Element(this);
            Uml.__CustomImpl.MultiplicityElement(this);
            Uml.__CustomImpl.ConnectorEnd(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public Connector Connector
        {
            get => MGet<Connector>(Uml.ConnectorEnd_Connector);
            set => MSet<Connector>(Uml.ConnectorEnd_Connector, value);
        }
    
        public Property DefiningEnd
        {
            get => Uml.__CustomImpl.ConnectorEnd_DefiningEnd(this);
        }
    
        public Property PartWithPort
        {
            get => MGet<Property>(Uml.ConnectorEnd_PartWithPort);
            set => MSet<Property>(Uml.ConnectorEnd_PartWithPort, value);
        }
    
        public ConnectableElement Role
        {
            get => MGet<ConnectableElement>(Uml.ConnectorEnd_Role);
            set => MSet<ConnectableElement>(Uml.ConnectorEnd_Role, value);
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
    
        public int Lower
        {
            get => Uml.__CustomImpl.MultiplicityElement_Lower(this);
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
    
    
        bool MultiplicityElement.CompatibleWith(MultiplicityElement other) => Uml.__CustomImpl.MultiplicityElement_CompatibleWith(this, other);
        bool MultiplicityElement.IncludesMultiplicity(MultiplicityElement M) => Uml.__CustomImpl.MultiplicityElement_IncludesMultiplicity(this, M);
        bool MultiplicityElement.Is(int lowerbound, int upperbound) => Uml.__CustomImpl.MultiplicityElement_Is(this, lowerbound, upperbound);
        bool MultiplicityElement.IsMultivalued() => Uml.__CustomImpl.MultiplicityElement_IsMultivalued(this);
        int MultiplicityElement.LowerBound() => Uml.__CustomImpl.MultiplicityElement_LowerBound(this);
        int MultiplicityElement.UpperBound() => Uml.__CustomImpl.MultiplicityElement_UpperBound(this);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.MultiplicityElementInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.MultiplicityElementInfo, Uml.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.ConnectorEnd_Connector, Uml.ConnectorEnd_DefiningEnd, Uml.ConnectorEnd_PartWithPort, Uml.ConnectorEnd_Role);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.ConnectorEnd_Connector, Uml.ConnectorEnd_DefiningEnd, Uml.ConnectorEnd_PartWithPort, Uml.ConnectorEnd_Role, Uml.MultiplicityElement_IsOrdered, Uml.MultiplicityElement_IsUnique, Uml.MultiplicityElement_Lower, Uml.MultiplicityElement_LowerValue, Uml.MultiplicityElement_Upper, Uml.MultiplicityElement_UpperValue, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Uml.ConnectorEnd_Connector, Uml.ConnectorEnd_DefiningEnd, Uml.ConnectorEnd_PartWithPort, Uml.ConnectorEnd_Role, Uml.MultiplicityElement_IsOrdered, Uml.MultiplicityElement_IsUnique, Uml.MultiplicityElement_Lower, Uml.MultiplicityElement_LowerValue, Uml.MultiplicityElement_Upper, Uml.MultiplicityElement_UpperValue, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Connector", Uml.ConnectorEnd_Connector);
                publicPropertiesByName.Add("DefiningEnd", Uml.ConnectorEnd_DefiningEnd);
                publicPropertiesByName.Add("PartWithPort", Uml.ConnectorEnd_PartWithPort);
                publicPropertiesByName.Add("Role", Uml.ConnectorEnd_Role);
                publicPropertiesByName.Add("IsOrdered", Uml.MultiplicityElement_IsOrdered);
                publicPropertiesByName.Add("IsUnique", Uml.MultiplicityElement_IsUnique);
                publicPropertiesByName.Add("Lower", Uml.MultiplicityElement_Lower);
                publicPropertiesByName.Add("LowerValue", Uml.MultiplicityElement_LowerValue);
                publicPropertiesByName.Add("Upper", Uml.MultiplicityElement_Upper);
                publicPropertiesByName.Add("UpperValue", Uml.MultiplicityElement_UpperValue);
                publicPropertiesByName.Add("OwnedComment", Uml.Element_OwnedComment);
                publicPropertiesByName.Add("OwnedElement", Uml.Element_OwnedElement);
                publicPropertiesByName.Add("Owner", Uml.Element_Owner);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Uml.ConnectorEnd_Connector, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ConnectorEnd_Connector, __ImmutableArray.Create<__ModelProperty>(Uml.ConnectorEnd_Connector), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Connector_End), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ConnectorEnd_DefiningEnd, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ConnectorEnd_DefiningEnd, __ImmutableArray.Create<__ModelProperty>(Uml.ConnectorEnd_DefiningEnd), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ConnectorEnd_PartWithPort, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ConnectorEnd_PartWithPort, __ImmutableArray.Create<__ModelProperty>(Uml.ConnectorEnd_PartWithPort), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ConnectorEnd_Role, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ConnectorEnd_Role, __ImmutableArray.Create<__ModelProperty>(Uml.ConnectorEnd_Role), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElement_End), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_IsOrdered, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_IsOrdered, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_IsOrdered), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_IsUnique, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_IsUnique, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_IsUnique), true, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_Lower, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_Lower, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_Lower), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_LowerValue, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_LowerValue, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_LowerValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_Upper, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_Upper, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_Upper), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_UpperValue, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_UpperValue, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_UpperValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_LowerValue, Uml.MultiplicityElement_UpperValue, Uml.Element_OwnedComment), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ConnectorEnd_Connector), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.MultiplicityElement_CompatibleWith, Uml.MultiplicityElement_IncludesMultiplicity, Uml.MultiplicityElement_Is, Uml.MultiplicityElement_IsMultivalued, Uml.MultiplicityElement_LowerBound, Uml.MultiplicityElement_UpperBound, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Uml.MultiplicityElement_CompatibleWith, Uml.MultiplicityElement_IncludesMultiplicity, Uml.MultiplicityElement_Is, Uml.MultiplicityElement_IsMultivalued, Uml.MultiplicityElement_LowerBound, Uml.MultiplicityElement_UpperBound, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Uml.MultiplicityElement_CompatibleWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_IncludesMultiplicity, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_Is, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_IsMultivalued, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_LowerBound, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_UpperBound, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_AllOwnedElements, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_MustBeOwned, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Uml.MInstance;
            public override __MetaType MetaType => typeof(ConnectorEnd);
    
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
                var result = new ConnectorEnd_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Uml.ConnectorEndInfo";
            }
        }
    }
}
