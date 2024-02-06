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

    internal class ClassifierTemplateParameter_Impl : __MetaModelObject, ClassifierTemplateParameter
    {
        private ClassifierTemplateParameter_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Uml.ClassifierTemplateParameter_AllowSubstitutable)?.Add((bool)true);
            Uml.__CustomImpl.Element(this);
            Uml.__CustomImpl.TemplateParameter(this);
            Uml.__CustomImpl.ClassifierTemplateParameter(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public bool AllowSubstitutable
        {
            get => MGet<bool>(Uml.ClassifierTemplateParameter_AllowSubstitutable);
            set => MSet<bool>(Uml.ClassifierTemplateParameter_AllowSubstitutable, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Classifier> ConstrainingClassifier
        {
            get => MGetCollection<Classifier>(Uml.ClassifierTemplateParameter_ConstrainingClassifier);
        }
    
        public Classifier ParameteredElement
        {
            get => MGet<Classifier>(Uml.ClassifierTemplateParameter_ParameteredElement);
            set => MSet<Classifier>(Uml.ClassifierTemplateParameter_ParameteredElement, value);
        }
    
        public ParameterableElement Default
        {
            get => MGet<ParameterableElement>(Uml.TemplateParameter_Default);
            set => MSet<ParameterableElement>(Uml.TemplateParameter_Default, value);
        }
    
        public ParameterableElement OwnedDefault
        {
            get => MGet<ParameterableElement>(Uml.TemplateParameter_OwnedDefault);
            set => MSet<ParameterableElement>(Uml.TemplateParameter_OwnedDefault, value);
        }
    
        public ParameterableElement OwnedParameteredElement
        {
            get => MGet<ParameterableElement>(Uml.TemplateParameter_OwnedParameteredElement);
            set => MSet<ParameterableElement>(Uml.TemplateParameter_OwnedParameteredElement, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        ParameterableElement TemplateParameter.ParameteredElement
        {
            get => MGet<ParameterableElement>(Uml.TemplateParameter_ParameteredElement);
            set => MSet<ParameterableElement>(Uml.TemplateParameter_ParameteredElement, value);
        }
    
        public TemplateSignature Signature
        {
            get => MGet<TemplateSignature>(Uml.TemplateParameter_Signature);
            set => MSet<TemplateSignature>(Uml.TemplateParameter_Signature, value);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.TemplateParameterInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.TemplateParameterInfo, Uml.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.ClassifierTemplateParameter_AllowSubstitutable, Uml.ClassifierTemplateParameter_ConstrainingClassifier, Uml.ClassifierTemplateParameter_ParameteredElement);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.ClassifierTemplateParameter_AllowSubstitutable, Uml.ClassifierTemplateParameter_ConstrainingClassifier, Uml.ClassifierTemplateParameter_ParameteredElement, Uml.TemplateParameter_Default, Uml.TemplateParameter_OwnedDefault, Uml.TemplateParameter_OwnedParameteredElement, Uml.TemplateParameter_ParameteredElement, Uml.TemplateParameter_Signature, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Uml.ClassifierTemplateParameter_AllowSubstitutable, Uml.ClassifierTemplateParameter_ConstrainingClassifier, Uml.ClassifierTemplateParameter_ParameteredElement, Uml.TemplateParameter_Default, Uml.TemplateParameter_OwnedDefault, Uml.TemplateParameter_OwnedParameteredElement, Uml.TemplateParameter_Signature, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("AllowSubstitutable", Uml.ClassifierTemplateParameter_AllowSubstitutable);
                publicPropertiesByName.Add("ConstrainingClassifier", Uml.ClassifierTemplateParameter_ConstrainingClassifier);
                publicPropertiesByName.Add("ParameteredElement", Uml.ClassifierTemplateParameter_ParameteredElement);
                publicPropertiesByName.Add("Default", Uml.TemplateParameter_Default);
                publicPropertiesByName.Add("OwnedDefault", Uml.TemplateParameter_OwnedDefault);
                publicPropertiesByName.Add("OwnedParameteredElement", Uml.TemplateParameter_OwnedParameteredElement);
                publicPropertiesByName.Add("Signature", Uml.TemplateParameter_Signature);
                publicPropertiesByName.Add("OwnedComment", Uml.Element_OwnedComment);
                publicPropertiesByName.Add("OwnedElement", Uml.Element_OwnedElement);
                publicPropertiesByName.Add("Owner", Uml.Element_Owner);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Uml.ClassifierTemplateParameter_AllowSubstitutable, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ClassifierTemplateParameter_AllowSubstitutable, __ImmutableArray.Create<__ModelProperty>(Uml.ClassifierTemplateParameter_AllowSubstitutable), true, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ClassifierTemplateParameter_ConstrainingClassifier, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ClassifierTemplateParameter_ConstrainingClassifier, __ImmutableArray.Create<__ModelProperty>(Uml.ClassifierTemplateParameter_ConstrainingClassifier), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ClassifierTemplateParameter_ParameteredElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ClassifierTemplateParameter_ParameteredElement, __ImmutableArray.Create<__ModelProperty>(Uml.ClassifierTemplateParameter_ParameteredElement, Uml.TemplateParameter_ParameteredElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.TemplateParameter_Default, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.TemplateParameter_Default, __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_Default), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_OwnedDefault), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.TemplateParameter_OwnedDefault, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.TemplateParameter_OwnedDefault, __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_OwnedDefault), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement, Uml.TemplateParameter_Default), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.TemplateParameter_OwnedParameteredElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.TemplateParameter_OwnedParameteredElement, __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_OwnedParameteredElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement, Uml.TemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.TemplateParameter_ParameteredElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ClassifierTemplateParameter_ParameteredElement, __ImmutableArray.Create<__ModelProperty>(Uml.ClassifierTemplateParameter_ParameteredElement, Uml.TemplateParameter_ParameteredElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_OwnedParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ClassifierTemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ClassifierTemplateParameter_ParameteredElement)));
                modelPropertyInfos.Add(Uml.TemplateParameter_Signature, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.TemplateParameter_Signature, __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_Signature), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateSignature_OwnedParameter), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_OwnedDefault, Uml.TemplateParameter_OwnedParameteredElement, Uml.Element_OwnedComment), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_Signature), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Uml.Element_AllOwnedElements, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_MustBeOwned, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Uml.MInstance;
            public override __MetaType MetaType => typeof(ClassifierTemplateParameter);
    
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
                var result = new ClassifierTemplateParameter_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Uml.ClassifierTemplateParameterInfo";
            }
        }
    }
}
