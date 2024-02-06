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

    internal class Operation_Impl : __MetaModelObject, Operation
    {
        private Operation_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Uml.Operation_IsQuery)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.BehavioralFeature_Concurrency)?.Add((global::MetaDslx.Languages.Uml.Model.CallConcurrencyKind)MetaDslx.Languages.Uml.Model.CallConcurrencyKind.Sequential);
            ((__IModelObject)this).MGetSlot(Uml.BehavioralFeature_IsAbstract)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.Feature_IsStatic)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.RedefinableElement_IsLeaf)?.Add((bool)false);
            Uml.__CustomImpl.Element(this);
            Uml.__CustomImpl.TemplateableElement(this);
            Uml.__CustomImpl.NamedElement(this);
            Uml.__CustomImpl.RedefinableElement(this);
            Uml.__CustomImpl.ParameterableElement(this);
            Uml.__CustomImpl.Namespace(this);
            Uml.__CustomImpl.Feature(this);
            Uml.__CustomImpl.BehavioralFeature(this);
            Uml.__CustomImpl.Operation(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public Constraint BodyCondition
        {
            get => MGet<Constraint>(Uml.Operation_BodyCondition);
            set => MSet<Constraint>(Uml.Operation_BodyCondition, value);
        }
    
        public Class Class
        {
            get => MGet<Class>(Uml.Operation_Class);
            set => MSet<Class>(Uml.Operation_Class, value);
        }
    
        public DataType Datatype
        {
            get => MGet<DataType>(Uml.Operation_Datatype);
            set => MSet<DataType>(Uml.Operation_Datatype, value);
        }
    
        public Interface Interface
        {
            get => MGet<Interface>(Uml.Operation_Interface);
            set => MSet<Interface>(Uml.Operation_Interface, value);
        }
    
        public bool IsOrdered
        {
            get => Uml.__CustomImpl.Operation_IsOrdered(this);
        }
    
        public bool IsQuery
        {
            get => MGet<bool>(Uml.Operation_IsQuery);
            set => MSet<bool>(Uml.Operation_IsQuery, value);
        }
    
        public bool IsUnique
        {
            get => Uml.__CustomImpl.Operation_IsUnique(this);
        }
    
        public int Lower
        {
            get => Uml.__CustomImpl.Operation_Lower(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Parameter> OwnedParameter
        {
            get => MGetCollection<Parameter>(Uml.Operation_OwnedParameter);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Constraint> Postcondition
        {
            get => MGetCollection<Constraint>(Uml.Operation_Postcondition);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Constraint> Precondition
        {
            get => MGetCollection<Constraint>(Uml.Operation_Precondition);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Type> RaisedException
        {
            get => MGetCollection<Type>(Uml.Operation_RaisedException);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Operation> RedefinedOperation
        {
            get => MGetCollection<Operation>(Uml.Operation_RedefinedOperation);
        }
    
        public OperationTemplateParameter TemplateParameter
        {
            get => MGet<OperationTemplateParameter>(Uml.Operation_TemplateParameter);
            set => MSet<OperationTemplateParameter>(Uml.Operation_TemplateParameter, value);
        }
    
        public Type Type
        {
            get => Uml.__CustomImpl.Operation_Type(this);
        }
    
        public int Upper
        {
            get => Uml.__CustomImpl.Operation_Upper(this);
        }
    
        public global::MetaDslx.Languages.Uml.Model.CallConcurrencyKind Concurrency
        {
            get => MGet<global::MetaDslx.Languages.Uml.Model.CallConcurrencyKind>(Uml.BehavioralFeature_Concurrency);
            set => MSet<global::MetaDslx.Languages.Uml.Model.CallConcurrencyKind>(Uml.BehavioralFeature_Concurrency, value);
        }
    
        public bool IsAbstract
        {
            get => MGet<bool>(Uml.BehavioralFeature_IsAbstract);
            set => MSet<bool>(Uml.BehavioralFeature_IsAbstract, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Behavior> Method
        {
            get => MGetCollection<Behavior>(Uml.BehavioralFeature_Method);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::MetaDslx.Modeling.ICollectionSlot<Parameter> BehavioralFeature.OwnedParameter
        {
            get => MGetCollection<Parameter>(Uml.BehavioralFeature_OwnedParameter);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ParameterSet> OwnedParameterSet
        {
            get => MGetCollection<ParameterSet>(Uml.BehavioralFeature_OwnedParameterSet);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::MetaDslx.Modeling.ICollectionSlot<Type> BehavioralFeature.RaisedException
        {
            get => MGetCollection<Type>(Uml.BehavioralFeature_RaisedException);
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
    
        public global::MetaDslx.Modeling.ICollectionSlot<ElementImport> ElementImport
        {
            get => MGetCollection<ElementImport>(Uml.Namespace_ElementImport);
        }
    
        public global::System.Collections.Generic.IList<PackageableElement> ImportedMember
        {
            get => Uml.__CustomImpl.Namespace_ImportedMember(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<NamedElement> Member
        {
            get => MGetCollection<NamedElement>(Uml.Namespace_Member);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<NamedElement> OwnedMember
        {
            get => MGetCollection<NamedElement>(Uml.Namespace_OwnedMember);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Constraint> OwnedRule
        {
            get => MGetCollection<Constraint>(Uml.Namespace_OwnedRule);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<PackageImport> PackageImport
        {
            get => MGetCollection<PackageImport>(Uml.Namespace_PackageImport);
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
    
        public TemplateSignature OwnedTemplateSignature
        {
            get => MGet<TemplateSignature>(Uml.TemplateableElement_OwnedTemplateSignature);
            set => MSet<TemplateSignature>(Uml.TemplateableElement_OwnedTemplateSignature, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<TemplateBinding> TemplateBinding
        {
            get => MGetCollection<TemplateBinding>(Uml.TemplateableElement_TemplateBinding);
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
    
    
        bool Operation.IsConsistentWith(bool result, RedefinableElement redefiningElement) => Uml.__CustomImpl.Operation_IsConsistentWith(this, result, redefiningElement);
        global::System.Collections.Generic.IList<Parameter> Operation.ReturnResult(global::System.Collections.Generic.IList<Parameter> result) => Uml.__CustomImpl.Operation_ReturnResult(this, result);
        global::System.Collections.Generic.IList<Parameter> BehavioralFeature.InputParameters(global::System.Collections.Generic.IList<Parameter> result) => Uml.__CustomImpl.BehavioralFeature_InputParameters(this, result);
        bool BehavioralFeature.IsDistinguishableFrom(bool result, NamedElement n, Namespace ns) => Uml.__CustomImpl.BehavioralFeature_IsDistinguishableFrom(this, result, n, ns);
        global::System.Collections.Generic.IList<Parameter> BehavioralFeature.OutputParameters(global::System.Collections.Generic.IList<Parameter> result) => Uml.__CustomImpl.BehavioralFeature_OutputParameters(this, result);
        global::System.Collections.Generic.IList<PackageableElement> Namespace.ExcludeCollisions(global::System.Collections.Generic.IList<PackageableElement> result, global::System.Collections.Generic.IList<PackageableElement> imps) => Uml.__CustomImpl.Namespace_ExcludeCollisions(this, result, imps);
        global::System.Collections.Generic.IList<string> Namespace.GetNamesOfMember(global::System.Collections.Generic.IList<string> result, NamedElement element) => Uml.__CustomImpl.Namespace_GetNamesOfMember(this, result, element);
        global::System.Collections.Generic.IList<PackageableElement> Namespace.ImportMembers(global::System.Collections.Generic.IList<PackageableElement> result, global::System.Collections.Generic.IList<PackageableElement> imps) => Uml.__CustomImpl.Namespace_ImportMembers(this, result, imps);
        bool Namespace.MembersAreDistinguishable(bool result) => Uml.__CustomImpl.Namespace_MembersAreDistinguishable(this, result);
        bool ParameterableElement.IsCompatibleWith(bool result, ParameterableElement p) => Uml.__CustomImpl.ParameterableElement_IsCompatibleWith(this, result, p);
        bool ParameterableElement.IsTemplateParameter(bool result) => Uml.__CustomImpl.ParameterableElement_IsTemplateParameter(this, result);
        bool RedefinableElement.IsConsistentWith(bool result, RedefinableElement redefiningElement) => Uml.__CustomImpl.Operation_IsConsistentWith(this, result, redefiningElement);
        bool RedefinableElement.IsRedefinitionContextValid(bool result, RedefinableElement redefinedElement) => Uml.__CustomImpl.RedefinableElement_IsRedefinitionContextValid(this, result, redefinedElement);
        global::System.Collections.Generic.IList<Namespace> NamedElement.AllNamespaces(global::System.Collections.Generic.IList<Namespace> result) => Uml.__CustomImpl.NamedElement_AllNamespaces(this, result);
        global::System.Collections.Generic.IList<Package> NamedElement.AllOwningPackages(global::System.Collections.Generic.IList<Package> result) => Uml.__CustomImpl.NamedElement_AllOwningPackages(this, result);
        bool NamedElement.IsDistinguishableFrom(bool result, NamedElement n, Namespace ns) => Uml.__CustomImpl.BehavioralFeature_IsDistinguishableFrom(this, result, n, ns);
        string NamedElement.Separator(string result) => Uml.__CustomImpl.NamedElement_Separator(this, result);
        bool TemplateableElement.IsTemplate(bool result) => Uml.__CustomImpl.TemplateableElement_IsTemplate(this, result);
        global::System.Collections.Generic.IList<ParameterableElement> TemplateableElement.ParameterableElements(global::System.Collections.Generic.IList<ParameterableElement> result) => Uml.__CustomImpl.TemplateableElement_ParameterableElements(this, result);
        global::System.Collections.Generic.IList<Element> Element.AllOwnedElements(global::System.Collections.Generic.IList<Element> result) => Uml.__CustomImpl.Element_AllOwnedElements(this, result);
        bool Element.MustBeOwned(bool result) => Uml.__CustomImpl.Element_MustBeOwned(this, result);
    
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.BehavioralFeatureInfo, Uml.ParameterableElementInfo, Uml.TemplateableElementInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.BehavioralFeatureInfo, Uml.FeatureInfo, Uml.NamespaceInfo, Uml.ParameterableElementInfo, Uml.RedefinableElementInfo, Uml.NamedElementInfo, Uml.TemplateableElementInfo, Uml.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Operation_BodyCondition, Uml.Operation_Class, Uml.Operation_Datatype, Uml.Operation_Interface, Uml.Operation_IsOrdered, Uml.Operation_IsQuery, Uml.Operation_IsUnique, Uml.Operation_Lower, Uml.Operation_OwnedParameter, Uml.Operation_Postcondition, Uml.Operation_Precondition, Uml.Operation_RaisedException, Uml.Operation_RedefinedOperation, Uml.Operation_TemplateParameter, Uml.Operation_Type, Uml.Operation_Upper);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Operation_BodyCondition, Uml.Operation_Class, Uml.Operation_Datatype, Uml.Operation_Interface, Uml.Operation_IsOrdered, Uml.Operation_IsQuery, Uml.Operation_IsUnique, Uml.Operation_Lower, Uml.Operation_OwnedParameter, Uml.Operation_Postcondition, Uml.Operation_Precondition, Uml.Operation_RaisedException, Uml.Operation_RedefinedOperation, Uml.Operation_TemplateParameter, Uml.Operation_Type, Uml.Operation_Upper, Uml.BehavioralFeature_Concurrency, Uml.BehavioralFeature_IsAbstract, Uml.BehavioralFeature_Method, Uml.BehavioralFeature_OwnedParameter, Uml.BehavioralFeature_OwnedParameterSet, Uml.BehavioralFeature_RaisedException, Uml.Feature_FeaturingClassifier, Uml.Feature_IsStatic, Uml.Namespace_ElementImport, Uml.Namespace_ImportedMember, Uml.Namespace_Member, Uml.Namespace_OwnedMember, Uml.Namespace_OwnedRule, Uml.Namespace_PackageImport, Uml.ParameterableElement_OwningTemplateParameter, Uml.ParameterableElement_TemplateParameter, Uml.RedefinableElement_IsLeaf, Uml.RedefinableElement_RedefinedElement, Uml.RedefinableElement_RedefinitionContext, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.TemplateableElement_OwnedTemplateSignature, Uml.TemplateableElement_TemplateBinding, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Operation_BodyCondition, Uml.Operation_Class, Uml.Operation_Datatype, Uml.Operation_Interface, Uml.Operation_IsOrdered, Uml.Operation_IsQuery, Uml.Operation_IsUnique, Uml.Operation_Lower, Uml.Operation_OwnedParameter, Uml.Operation_Postcondition, Uml.Operation_Precondition, Uml.Operation_RaisedException, Uml.Operation_RedefinedOperation, Uml.Operation_TemplateParameter, Uml.Operation_Type, Uml.Operation_Upper, Uml.BehavioralFeature_Concurrency, Uml.BehavioralFeature_IsAbstract, Uml.BehavioralFeature_Method, Uml.BehavioralFeature_OwnedParameterSet, Uml.Feature_FeaturingClassifier, Uml.Feature_IsStatic, Uml.Namespace_ElementImport, Uml.Namespace_ImportedMember, Uml.Namespace_Member, Uml.Namespace_OwnedMember, Uml.Namespace_OwnedRule, Uml.Namespace_PackageImport, Uml.ParameterableElement_OwningTemplateParameter, Uml.RedefinableElement_IsLeaf, Uml.RedefinableElement_RedefinedElement, Uml.RedefinableElement_RedefinitionContext, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.TemplateableElement_OwnedTemplateSignature, Uml.TemplateableElement_TemplateBinding, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("BodyCondition", Uml.Operation_BodyCondition);
                publicPropertiesByName.Add("Class", Uml.Operation_Class);
                publicPropertiesByName.Add("Datatype", Uml.Operation_Datatype);
                publicPropertiesByName.Add("Interface", Uml.Operation_Interface);
                publicPropertiesByName.Add("IsOrdered", Uml.Operation_IsOrdered);
                publicPropertiesByName.Add("IsQuery", Uml.Operation_IsQuery);
                publicPropertiesByName.Add("IsUnique", Uml.Operation_IsUnique);
                publicPropertiesByName.Add("Lower", Uml.Operation_Lower);
                publicPropertiesByName.Add("OwnedParameter", Uml.Operation_OwnedParameter);
                publicPropertiesByName.Add("Postcondition", Uml.Operation_Postcondition);
                publicPropertiesByName.Add("Precondition", Uml.Operation_Precondition);
                publicPropertiesByName.Add("RaisedException", Uml.Operation_RaisedException);
                publicPropertiesByName.Add("RedefinedOperation", Uml.Operation_RedefinedOperation);
                publicPropertiesByName.Add("TemplateParameter", Uml.Operation_TemplateParameter);
                publicPropertiesByName.Add("Type", Uml.Operation_Type);
                publicPropertiesByName.Add("Upper", Uml.Operation_Upper);
                publicPropertiesByName.Add("Concurrency", Uml.BehavioralFeature_Concurrency);
                publicPropertiesByName.Add("IsAbstract", Uml.BehavioralFeature_IsAbstract);
                publicPropertiesByName.Add("Method", Uml.BehavioralFeature_Method);
                publicPropertiesByName.Add("OwnedParameterSet", Uml.BehavioralFeature_OwnedParameterSet);
                publicPropertiesByName.Add("FeaturingClassifier", Uml.Feature_FeaturingClassifier);
                publicPropertiesByName.Add("IsStatic", Uml.Feature_IsStatic);
                publicPropertiesByName.Add("ElementImport", Uml.Namespace_ElementImport);
                publicPropertiesByName.Add("ImportedMember", Uml.Namespace_ImportedMember);
                publicPropertiesByName.Add("Member", Uml.Namespace_Member);
                publicPropertiesByName.Add("OwnedMember", Uml.Namespace_OwnedMember);
                publicPropertiesByName.Add("OwnedRule", Uml.Namespace_OwnedRule);
                publicPropertiesByName.Add("PackageImport", Uml.Namespace_PackageImport);
                publicPropertiesByName.Add("OwningTemplateParameter", Uml.ParameterableElement_OwningTemplateParameter);
                publicPropertiesByName.Add("IsLeaf", Uml.RedefinableElement_IsLeaf);
                publicPropertiesByName.Add("RedefinedElement", Uml.RedefinableElement_RedefinedElement);
                publicPropertiesByName.Add("RedefinitionContext", Uml.RedefinableElement_RedefinitionContext);
                publicPropertiesByName.Add("ClientDependency", Uml.NamedElement_ClientDependency);
                publicPropertiesByName.Add("Name", Uml.NamedElement_Name);
                publicPropertiesByName.Add("NameExpression", Uml.NamedElement_NameExpression);
                publicPropertiesByName.Add("Namespace", Uml.NamedElement_Namespace);
                publicPropertiesByName.Add("QualifiedName", Uml.NamedElement_QualifiedName);
                publicPropertiesByName.Add("Visibility", Uml.NamedElement_Visibility);
                publicPropertiesByName.Add("OwnedTemplateSignature", Uml.TemplateableElement_OwnedTemplateSignature);
                publicPropertiesByName.Add("TemplateBinding", Uml.TemplateableElement_TemplateBinding);
                publicPropertiesByName.Add("OwnedComment", Uml.Element_OwnedComment);
                publicPropertiesByName.Add("OwnedElement", Uml.Element_OwnedElement);
                publicPropertiesByName.Add("Owner", Uml.Element_Owner);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Uml.Operation_BodyCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_BodyCondition, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_BodyCondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedRule), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_Class, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_Class, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Class), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Class_OwnedOperation), __ImmutableArray.Create<__ModelProperty>(Uml.Feature_FeaturingClassifier, Uml.NamedElement_Namespace, Uml.RedefinableElement_RedefinitionContext), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_Datatype, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_Datatype, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Datatype), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.DataType_OwnedOperation), __ImmutableArray.Create<__ModelProperty>(Uml.Feature_FeaturingClassifier, Uml.NamedElement_Namespace, Uml.RedefinableElement_RedefinitionContext), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_Interface, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_Interface, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Interface), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Interface_OwnedOperation), __ImmutableArray.Create<__ModelProperty>(Uml.Feature_FeaturingClassifier, Uml.NamedElement_Namespace, Uml.RedefinableElement_RedefinitionContext), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_IsOrdered, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_IsOrdered, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_IsOrdered), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_IsQuery, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_IsQuery, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_IsQuery), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_IsUnique, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_IsUnique, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_IsUnique), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_Lower, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_Lower, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Lower), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_OwnedParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_OwnedParameter, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_OwnedParameter, Uml.BehavioralFeature_OwnedParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Parameter_Operation), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.BehavioralFeature_OwnedParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.BehavioralFeature_OwnedParameter), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_Postcondition, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_Postcondition, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Postcondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedRule), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_Precondition, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_Precondition, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Precondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedRule), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_RaisedException, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_RaisedException, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_RaisedException, Uml.BehavioralFeature_RaisedException), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.BehavioralFeature_RaisedException), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.BehavioralFeature_RaisedException), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_RedefinedOperation, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_RedefinedOperation, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_RedefinedOperation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_TemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_TemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_TemplateParameter, Uml.ParameterableElement_TemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.OperationTemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_Type, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Type), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Operation_Upper, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_Upper, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Upper), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.BehavioralFeature_Concurrency, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.BehavioralFeature_Concurrency, __ImmutableArray.Create<__ModelProperty>(Uml.BehavioralFeature_Concurrency), MetaDslx.Languages.Uml.Model.CallConcurrencyKind.Sequential, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.BehavioralFeature_IsAbstract, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.BehavioralFeature_IsAbstract, __ImmutableArray.Create<__ModelProperty>(Uml.BehavioralFeature_IsAbstract), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.BehavioralFeature_Method, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.BehavioralFeature_Method, __ImmutableArray.Create<__ModelProperty>(Uml.BehavioralFeature_Method), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Behavior_Specification), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.BehavioralFeature_OwnedParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_OwnedParameter, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_OwnedParameter, Uml.BehavioralFeature_OwnedParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_OwnedParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_OwnedParameter)));
                modelPropertyInfos.Add(Uml.BehavioralFeature_OwnedParameterSet, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.BehavioralFeature_OwnedParameterSet, __ImmutableArray.Create<__ModelProperty>(Uml.BehavioralFeature_OwnedParameterSet), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.BehavioralFeature_RaisedException, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_RaisedException, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_RaisedException, Uml.BehavioralFeature_RaisedException), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_RaisedException), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_RaisedException)));
                modelPropertyInfos.Add(Uml.Feature_FeaturingClassifier, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Feature_FeaturingClassifier, __ImmutableArray.Create<__ModelProperty>(Uml.Feature_FeaturingClassifier), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Feature), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Class, Uml.Operation_Datatype, Uml.Operation_Interface), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Feature_IsStatic, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Feature_IsStatic, __ImmutableArray.Create<__ModelProperty>(Uml.Feature_IsStatic), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_ElementImport, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_ElementImport, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ElementImport), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ElementImport_ImportingNamespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_ImportedMember, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_ImportedMember, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ImportedMember), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_Member, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_Member, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_Member), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ImportedMember, Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_OwnedMember, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_OwnedMember, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement, Uml.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(Uml.BehavioralFeature_OwnedParameter, Uml.BehavioralFeature_OwnedParameterSet, Uml.Namespace_OwnedRule), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_OwnedRule, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_OwnedRule, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedRule), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Constraint_Context), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_BodyCondition, Uml.Operation_Postcondition, Uml.Operation_Precondition), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_PackageImport, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_PackageImport, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_PackageImport), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.PackageImport_ImportingNamespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ParameterableElement_OwningTemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ParameterableElement_OwningTemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_OwnedParameteredElement), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner, Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ParameterableElement_TemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Operation_TemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.Operation_TemplateParameter, Uml.ParameterableElement_TemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_TemplateParameter)));
                modelPropertyInfos.Add(Uml.RedefinableElement_IsLeaf, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_IsLeaf, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_IsLeaf), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_RedefinedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_RedefinedElement, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_RedefinedOperation), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_RedefinitionContext, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_RedefinitionContext, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinitionContext), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Class, Uml.Operation_Datatype, Uml.Operation_Interface), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_ClientDependency, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_ClientDependency, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_ClientDependency), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Uml.Dependency_Client), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_NameExpression, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_NameExpression, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_NameExpression), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Namespace, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Class, Uml.Operation_Datatype, Uml.Operation_Interface), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_QualifiedName, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_QualifiedName, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_QualifiedName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Visibility), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.TemplateableElement_OwnedTemplateSignature, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.TemplateableElement_OwnedTemplateSignature, __ImmutableArray.Create<__ModelProperty>(Uml.TemplateableElement_OwnedTemplateSignature), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateSignature_Template), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.TemplateableElement_TemplateBinding, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.TemplateableElement_TemplateBinding, __ImmutableArray.Create<__ModelProperty>(Uml.TemplateableElement_TemplateBinding), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateBinding_BoundElement), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ElementImport, Uml.Namespace_OwnedMember, Uml.Namespace_PackageImport, Uml.NamedElement_NameExpression, Uml.TemplateableElement_OwnedTemplateSignature, Uml.TemplateableElement_TemplateBinding, Uml.Element_OwnedComment), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter, Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.Operation_IsConsistentWith, Uml.Operation_ReturnResult);
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.Operation_IsConsistentWith, Uml.Operation_ReturnResult, Uml.BehavioralFeature_InputParameters, Uml.BehavioralFeature_IsDistinguishableFrom, Uml.BehavioralFeature_OutputParameters, Uml.Namespace_ExcludeCollisions, Uml.Namespace_GetNamesOfMember, Uml.Namespace_ImportMembers, Uml.Namespace_MembersAreDistinguishable, Uml.ParameterableElement_IsCompatibleWith, Uml.ParameterableElement_IsTemplateParameter, Uml.RedefinableElement_IsConsistentWith, Uml.RedefinableElement_IsRedefinitionContextValid, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.TemplateableElement_IsTemplate, Uml.TemplateableElement_ParameterableElements, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Uml.Operation_IsConsistentWith, Uml.Operation_ReturnResult, Uml.BehavioralFeature_InputParameters, Uml.BehavioralFeature_IsDistinguishableFrom, Uml.BehavioralFeature_OutputParameters, Uml.Namespace_ExcludeCollisions, Uml.Namespace_GetNamesOfMember, Uml.Namespace_ImportMembers, Uml.Namespace_MembersAreDistinguishable, Uml.ParameterableElement_IsCompatibleWith, Uml.ParameterableElement_IsTemplateParameter, Uml.RedefinableElement_IsRedefinitionContextValid, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_Separator, Uml.TemplateableElement_IsTemplate, Uml.TemplateableElement_ParameterableElements, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Uml.Operation_IsConsistentWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.RedefinableElement_IsConsistentWith), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Operation_ReturnResult, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.BehavioralFeature_InputParameters, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.BehavioralFeature_IsDistinguishableFrom, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.NamedElement_IsDistinguishableFrom), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.BehavioralFeature_OutputParameters, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_ExcludeCollisions, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_GetNamesOfMember, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_ImportMembers, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_MembersAreDistinguishable, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ParameterableElement_IsCompatibleWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ParameterableElement_IsTemplateParameter, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.RedefinableElement_IsConsistentWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.Operation_IsConsistentWith)));
                    modelOperationInfos.Add(Uml.RedefinableElement_IsRedefinitionContextValid, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_AllNamespaces, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_AllOwningPackages, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_IsDistinguishableFrom, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.BehavioralFeature_IsDistinguishableFrom)));
                    modelOperationInfos.Add(Uml.NamedElement_Separator, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.TemplateableElement_IsTemplate, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.TemplateableElement_ParameterableElements, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_AllOwnedElements, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_MustBeOwned, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Uml.MInstance;
            public override __MetaType MetaType => typeof(Operation);
    
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
                var result = new Operation_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Uml.OperationInfo";
            }
        }
    }
}
