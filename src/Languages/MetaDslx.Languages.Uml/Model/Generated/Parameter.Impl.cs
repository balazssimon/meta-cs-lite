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

    internal class Parameter_Impl : __MetaModelObject, Parameter
    {
        private Parameter_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Uml.Parameter_Direction)?.Add((global::MetaDslx.Languages.Uml.Model.ParameterDirectionKind)MetaDslx.Languages.Uml.Model.ParameterDirectionKind.In);
            ((__IModelObject)this).MGetSlot(Uml.Parameter_IsException)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.Parameter_IsStream)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.MultiplicityElement_IsOrdered)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.MultiplicityElement_IsUnique)?.Add((bool)true);
            Uml.__CustomImpl.Element(this);
            Uml.__CustomImpl.NamedElement(this);
            Uml.__CustomImpl.TypedElement(this);
            Uml.__CustomImpl.ParameterableElement(this);
            Uml.__CustomImpl.MultiplicityElement(this);
            Uml.__CustomImpl.ConnectableElement(this);
            Uml.__CustomImpl.Parameter(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public string Default
        {
            get => Uml.__CustomImpl.Parameter_Default(this);
        }
    
        public ValueSpecification DefaultValue
        {
            get => MGet<ValueSpecification>(Uml.Parameter_DefaultValue);
            set => MSet<ValueSpecification>(Uml.Parameter_DefaultValue, value);
        }
    
        public global::MetaDslx.Languages.Uml.Model.ParameterDirectionKind Direction
        {
            get => MGet<global::MetaDslx.Languages.Uml.Model.ParameterDirectionKind>(Uml.Parameter_Direction);
            set => MSet<global::MetaDslx.Languages.Uml.Model.ParameterDirectionKind>(Uml.Parameter_Direction, value);
        }
    
        public global::MetaDslx.Languages.Uml.Model.ParameterEffectKind Effect
        {
            get => MGet<global::MetaDslx.Languages.Uml.Model.ParameterEffectKind>(Uml.Parameter_Effect);
            set => MSet<global::MetaDslx.Languages.Uml.Model.ParameterEffectKind>(Uml.Parameter_Effect, value);
        }
    
        public bool IsException
        {
            get => MGet<bool>(Uml.Parameter_IsException);
            set => MSet<bool>(Uml.Parameter_IsException, value);
        }
    
        public bool IsStream
        {
            get => MGet<bool>(Uml.Parameter_IsStream);
            set => MSet<bool>(Uml.Parameter_IsStream, value);
        }
    
        public Operation Operation
        {
            get => MGet<Operation>(Uml.Parameter_Operation);
            set => MSet<Operation>(Uml.Parameter_Operation, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ParameterSet> ParameterSet
        {
            get => MGetCollection<ParameterSet>(Uml.Parameter_ParameterSet);
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
    
    
        bool MultiplicityElement.CompatibleWith(MultiplicityElement other) => Uml.__CustomImpl.MultiplicityElement_CompatibleWith(this, other);
        bool MultiplicityElement.IncludesMultiplicity(MultiplicityElement M) => Uml.__CustomImpl.MultiplicityElement_IncludesMultiplicity(this, M);
        bool MultiplicityElement.Is(int lowerbound, int upperbound) => Uml.__CustomImpl.MultiplicityElement_Is(this, lowerbound, upperbound);
        bool MultiplicityElement.IsMultivalued() => Uml.__CustomImpl.MultiplicityElement_IsMultivalued(this);
        int MultiplicityElement.LowerBound() => Uml.__CustomImpl.MultiplicityElement_LowerBound(this);
        int MultiplicityElement.UpperBound() => Uml.__CustomImpl.MultiplicityElement_UpperBound(this);
        bool ParameterableElement.IsCompatibleWith(ParameterableElement p) => Uml.__CustomImpl.ParameterableElement_IsCompatibleWith(this, p);
        bool ParameterableElement.IsTemplateParameter() => Uml.__CustomImpl.ParameterableElement_IsTemplateParameter(this);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.ConnectableElementInfo, Uml.MultiplicityElementInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.ConnectableElementInfo, Uml.MultiplicityElementInfo, Uml.ParameterableElementInfo, Uml.TypedElementInfo, Uml.NamedElementInfo, Uml.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_Default, Uml.Parameter_DefaultValue, Uml.Parameter_Direction, Uml.Parameter_Effect, Uml.Parameter_IsException, Uml.Parameter_IsStream, Uml.Parameter_Operation, Uml.Parameter_ParameterSet);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_Default, Uml.Parameter_DefaultValue, Uml.Parameter_Direction, Uml.Parameter_Effect, Uml.Parameter_IsException, Uml.Parameter_IsStream, Uml.Parameter_Operation, Uml.Parameter_ParameterSet, Uml.ConnectableElement_End, Uml.ConnectableElement_TemplateParameter, Uml.MultiplicityElement_IsOrdered, Uml.MultiplicityElement_IsUnique, Uml.MultiplicityElement_Lower, Uml.MultiplicityElement_LowerValue, Uml.MultiplicityElement_Upper, Uml.MultiplicityElement_UpperValue, Uml.ParameterableElement_OwningTemplateParameter, Uml.ParameterableElement_TemplateParameter, Uml.TypedElement_Type, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_Default, Uml.Parameter_DefaultValue, Uml.Parameter_Direction, Uml.Parameter_Effect, Uml.Parameter_IsException, Uml.Parameter_IsStream, Uml.Parameter_Operation, Uml.Parameter_ParameterSet, Uml.ConnectableElement_End, Uml.ConnectableElement_TemplateParameter, Uml.MultiplicityElement_IsOrdered, Uml.MultiplicityElement_IsUnique, Uml.MultiplicityElement_Lower, Uml.MultiplicityElement_LowerValue, Uml.MultiplicityElement_Upper, Uml.MultiplicityElement_UpperValue, Uml.ParameterableElement_OwningTemplateParameter, Uml.TypedElement_Type, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Default", Uml.Parameter_Default);
                publicPropertiesByName.Add("DefaultValue", Uml.Parameter_DefaultValue);
                publicPropertiesByName.Add("Direction", Uml.Parameter_Direction);
                publicPropertiesByName.Add("Effect", Uml.Parameter_Effect);
                publicPropertiesByName.Add("IsException", Uml.Parameter_IsException);
                publicPropertiesByName.Add("IsStream", Uml.Parameter_IsStream);
                publicPropertiesByName.Add("Operation", Uml.Parameter_Operation);
                publicPropertiesByName.Add("ParameterSet", Uml.Parameter_ParameterSet);
                publicPropertiesByName.Add("End", Uml.ConnectableElement_End);
                publicPropertiesByName.Add("TemplateParameter", Uml.ConnectableElement_TemplateParameter);
                publicPropertiesByName.Add("IsOrdered", Uml.MultiplicityElement_IsOrdered);
                publicPropertiesByName.Add("IsUnique", Uml.MultiplicityElement_IsUnique);
                publicPropertiesByName.Add("Lower", Uml.MultiplicityElement_Lower);
                publicPropertiesByName.Add("LowerValue", Uml.MultiplicityElement_LowerValue);
                publicPropertiesByName.Add("Upper", Uml.MultiplicityElement_Upper);
                publicPropertiesByName.Add("UpperValue", Uml.MultiplicityElement_UpperValue);
                publicPropertiesByName.Add("OwningTemplateParameter", Uml.ParameterableElement_OwningTemplateParameter);
                publicPropertiesByName.Add("Type", Uml.TypedElement_Type);
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
                modelPropertyInfos.Add(Uml.Parameter_Default, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Parameter_Default, __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_Default), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Parameter_DefaultValue, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Parameter_DefaultValue, __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_DefaultValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Parameter_Direction, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Parameter_Direction, __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_Direction), MetaDslx.Languages.Uml.Model.ParameterDirectionKind.In, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Parameter_Effect, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Parameter_Effect, __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_Effect), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Parameter_IsException, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Parameter_IsException, __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_IsException), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Parameter_IsStream, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Parameter_IsStream, __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_IsStream), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Parameter_Operation, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Parameter_Operation, __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_Operation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_OwnedParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Parameter_ParameterSet, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Parameter_ParameterSet, __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_ParameterSet), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterSet_Parameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ConnectableElement_End, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ConnectableElement_End, __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElement_End), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Uml.ConnectorEnd_Role), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ConnectableElement_TemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ConnectableElement_TemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElement_TemplateParameter, Uml.ParameterableElement_TemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElementTemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_IsOrdered, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_IsOrdered, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_IsOrdered), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_IsUnique, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_IsUnique, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_IsUnique), true, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_Lower, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_Lower, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_Lower), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_LowerValue, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_LowerValue, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_LowerValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_Upper, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_Upper, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_Upper), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.MultiplicityElement_UpperValue, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.MultiplicityElement_UpperValue, __ImmutableArray.Create<__ModelProperty>(Uml.MultiplicityElement_UpperValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ParameterableElement_OwningTemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ParameterableElement_OwningTemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_OwnedParameteredElement), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner, Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ParameterableElement_TemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ConnectableElement_TemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElement_TemplateParameter, Uml.ParameterableElement_TemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ConnectableElement_TemplateParameter)));
                modelPropertyInfos.Add(Uml.TypedElement_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.TypedElement_Type, __ImmutableArray.Create<__ModelProperty>(Uml.TypedElement_Type), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_ClientDependency, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_ClientDependency, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_ClientDependency), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Uml.Dependency_Client), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_NameExpression, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_NameExpression, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_NameExpression), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Namespace, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_QualifiedName, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_QualifiedName, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_QualifiedName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Visibility), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_DefaultValue, Uml.MultiplicityElement_LowerValue, Uml.MultiplicityElement_UpperValue, Uml.NamedElement_NameExpression, Uml.Element_OwnedComment), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter, Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.MultiplicityElement_CompatibleWith, Uml.MultiplicityElement_IncludesMultiplicity, Uml.MultiplicityElement_Is, Uml.MultiplicityElement_IsMultivalued, Uml.MultiplicityElement_LowerBound, Uml.MultiplicityElement_UpperBound, Uml.ParameterableElement_IsCompatibleWith, Uml.ParameterableElement_IsTemplateParameter, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Uml.MultiplicityElement_CompatibleWith, Uml.MultiplicityElement_IncludesMultiplicity, Uml.MultiplicityElement_Is, Uml.MultiplicityElement_IsMultivalued, Uml.MultiplicityElement_LowerBound, Uml.MultiplicityElement_UpperBound, Uml.ParameterableElement_IsCompatibleWith, Uml.ParameterableElement_IsTemplateParameter, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Uml.MultiplicityElement_CompatibleWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_IncludesMultiplicity, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_Is, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_IsMultivalued, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_LowerBound, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.MultiplicityElement_UpperBound, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ParameterableElement_IsCompatibleWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ParameterableElement_IsTemplateParameter, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_AllNamespaces, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_AllOwningPackages, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_IsDistinguishableFrom, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_Separator, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_AllOwnedElements, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_MustBeOwned, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Uml.MInstance;
            public override __MetaType MetaType => typeof(Parameter);
    
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
                var result = new Parameter_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Uml.ParameterInfo";
            }
        }
    }
}
