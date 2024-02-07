#nullable enable

namespace MetaDslx.Languages.Ecore.Model.__Impl
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

    internal class EObject_Impl : __MetaModelObject, EObject
    {
        private EObject_Impl(string? id)
            : base(id)
        {
            Ecore.__CustomImpl.EObject(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
    
        global::System.Collections.Generic.IList<EObject> EObject.EAllContents() => Ecore.__CustomImpl.EObject_EAllContents(this);
        EClass EObject.EClass() => Ecore.__CustomImpl.EObject_EClass(this);
        EObject EObject.EContainer() => Ecore.__CustomImpl.EObject_EContainer(this);
        EStructuralFeature EObject.EContainingFeature() => Ecore.__CustomImpl.EObject_EContainingFeature(this);
        EReference EObject.EContainmentFeature() => Ecore.__CustomImpl.EObject_EContainmentFeature(this);
        global::System.Collections.Generic.IList<EObject> EObject.EContents() => Ecore.__CustomImpl.EObject_EContents(this);
        global::System.Collections.Generic.IList<EObject> EObject.ECrossReferences() => Ecore.__CustomImpl.EObject_ECrossReferences(this);
        __MetaSymbol EObject.EGet(EStructuralFeature feature, bool resolve) => Ecore.__CustomImpl.EObject_EGet(this, feature, resolve);
        __MetaSymbol EObject.EGet(EStructuralFeature feature) => Ecore.__CustomImpl.EObject_EGet(this, feature);
        __MetaSymbol EObject.EInvoke(EOperation operation, global::System.Collections.Generic.IList<object> arguments) => Ecore.__CustomImpl.EObject_EInvoke(this, operation, arguments);
        bool EObject.EIsProxy() => Ecore.__CustomImpl.EObject_EIsProxy(this);
        bool EObject.EIsSet(EStructuralFeature feature) => Ecore.__CustomImpl.EObject_EIsSet(this, feature);
        global::MetaDslx.Modeling.Model EObject.EResource() => Ecore.__CustomImpl.EObject_EResource(this);
        void EObject.ESet(EStructuralFeature feature, __MetaSymbol newValue) => Ecore.__CustomImpl.EObject_ESet(this, feature, newValue);
        void EObject.EUnset(EStructuralFeature feature) => Ecore.__CustomImpl.EObject_EUnset(this, feature);
    
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
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>();
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>();
                _publicProperties = __ImmutableArray.Create<__ModelProperty>();
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EObject_EAllContents, Ecore.EObject_EClass, Ecore.EObject_EContainer, Ecore.EObject_EContainingFeature, Ecore.EObject_EContainmentFeature, Ecore.EObject_EContents, Ecore.EObject_ECrossReferences, Ecore.EObject_EGet1, Ecore.EObject_EGet2, Ecore.EObject_EInvoke, Ecore.EObject_EIsProxy, Ecore.EObject_EIsSet, Ecore.EObject_EResource, Ecore.EObject_ESet, Ecore.EObject_EUnset);
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EObject_EAllContents, Ecore.EObject_EClass, Ecore.EObject_EContainer, Ecore.EObject_EContainingFeature, Ecore.EObject_EContainmentFeature, Ecore.EObject_EContents, Ecore.EObject_ECrossReferences, Ecore.EObject_EGet1, Ecore.EObject_EGet2, Ecore.EObject_EInvoke, Ecore.EObject_EIsProxy, Ecore.EObject_EIsSet, Ecore.EObject_EResource, Ecore.EObject_ESet, Ecore.EObject_EUnset);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EObject_EAllContents, Ecore.EObject_EClass, Ecore.EObject_EContainer, Ecore.EObject_EContainingFeature, Ecore.EObject_EContainmentFeature, Ecore.EObject_EContents, Ecore.EObject_ECrossReferences, Ecore.EObject_EGet1, Ecore.EObject_EGet2, Ecore.EObject_EInvoke, Ecore.EObject_EIsProxy, Ecore.EObject_EIsSet, Ecore.EObject_EResource, Ecore.EObject_ESet, Ecore.EObject_EUnset);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Ecore.EObject_EAllContents, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EClass, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EContainer, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EContainingFeature, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EContainmentFeature, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EContents, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_ECrossReferences, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EGet1, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EGet2, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EInvoke, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EIsProxy, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EIsSet, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EResource, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_ESet, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EObject_EUnset, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Ecore.MInstance;
            public override __MetaType MetaType => typeof(EObject);
    
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
                var result = new EObject_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Ecore.EObjectInfo";
            }
        }
    }
}
