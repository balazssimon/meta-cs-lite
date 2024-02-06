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

    internal class Alternative_Impl : __MetaModelObject, Alternative
    {
        private Alternative_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.Alternative(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Element> Elements
        {
            get => MGetCollection<Element>(Compiler.Alternative_Elements);
        }
    
        public string GreenConstructorArguments
        {
            get => Compiler.__CustomImpl.Alternative_GreenConstructorArguments(this);
        }
    
        public string GreenConstructorParameters
        {
            get => Compiler.__CustomImpl.Alternative_GreenConstructorParameters(this);
        }
    
        public string GreenName
        {
            get => Compiler.__CustomImpl.Alternative_GreenName(this);
        }
    
        public string GreenUpdateArguments
        {
            get => Compiler.__CustomImpl.Alternative_GreenUpdateArguments(this);
        }
    
        public string GreenUpdateParameters
        {
            get => Compiler.__CustomImpl.Alternative_GreenUpdateParameters(this);
        }
    
        public bool HasRedToGreenOptionalArguments
        {
            get => Compiler.__CustomImpl.Alternative_HasRedToGreenOptionalArguments(this);
        }
    
        public string RedName
        {
            get => Compiler.__CustomImpl.Alternative_RedName(this);
        }
    
        public string RedOptionalUpdateParameters
        {
            get => Compiler.__CustomImpl.Alternative_RedOptionalUpdateParameters(this);
        }
    
        public string RedToGreenArgumentList
        {
            get => Compiler.__CustomImpl.Alternative_RedToGreenArgumentList(this);
        }
    
        public string RedToGreenOptionalArgumentList
        {
            get => Compiler.__CustomImpl.Alternative_RedToGreenOptionalArgumentList(this);
        }
    
        public string RedUpdateArguments
        {
            get => Compiler.__CustomImpl.Alternative_RedUpdateArguments(this);
        }
    
        public string RedUpdateParameters
        {
            get => Compiler.__CustomImpl.Alternative_RedUpdateParameters(this);
        }
    
        public __MetaType ReturnType
        {
            get => MGet<__MetaType>(Compiler.Alternative_ReturnType);
            set => MSet<__MetaType>(Compiler.Alternative_ReturnType, value);
        }
    
        public Expression ReturnValue
        {
            get => MGet<Expression>(Compiler.Alternative_ReturnValue);
            set => MSet<Expression>(Compiler.Alternative_ReturnValue, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public string AntlrName
        {
            get => MGet<string>(Compiler.CSharpElement_AntlrName);
            set => MSet<string>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
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
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
        }
    
        public string? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public string? Name
        {
            get => MGet<string?>(Compiler.Declaration_Name);
            set => MSet<string?>(Compiler.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Compiler.Declaration_Parent);
            set => MSet<Declaration?>(Compiler.Declaration_Parent, value);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo, Compiler.DeclarationInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo, Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_Elements, Compiler.Alternative_GreenConstructorArguments, Compiler.Alternative_GreenConstructorParameters, Compiler.Alternative_GreenName, Compiler.Alternative_GreenUpdateArguments, Compiler.Alternative_GreenUpdateParameters, Compiler.Alternative_HasRedToGreenOptionalArguments, Compiler.Alternative_RedName, Compiler.Alternative_RedOptionalUpdateParameters, Compiler.Alternative_RedToGreenArgumentList, Compiler.Alternative_RedToGreenOptionalArgumentList, Compiler.Alternative_RedUpdateArguments, Compiler.Alternative_RedUpdateParameters, Compiler.Alternative_ReturnType, Compiler.Alternative_ReturnValue);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_Elements, Compiler.Alternative_GreenConstructorArguments, Compiler.Alternative_GreenConstructorParameters, Compiler.Alternative_GreenName, Compiler.Alternative_GreenUpdateArguments, Compiler.Alternative_GreenUpdateParameters, Compiler.Alternative_HasRedToGreenOptionalArguments, Compiler.Alternative_RedName, Compiler.Alternative_RedOptionalUpdateParameters, Compiler.Alternative_RedToGreenArgumentList, Compiler.Alternative_RedToGreenOptionalArgumentList, Compiler.Alternative_RedUpdateArguments, Compiler.Alternative_RedUpdateParameters, Compiler.Alternative_ReturnType, Compiler.Alternative_ReturnValue, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_Elements, Compiler.Alternative_GreenConstructorArguments, Compiler.Alternative_GreenConstructorParameters, Compiler.Alternative_GreenName, Compiler.Alternative_GreenUpdateArguments, Compiler.Alternative_GreenUpdateParameters, Compiler.Alternative_HasRedToGreenOptionalArguments, Compiler.Alternative_RedName, Compiler.Alternative_RedOptionalUpdateParameters, Compiler.Alternative_RedToGreenArgumentList, Compiler.Alternative_RedToGreenOptionalArgumentList, Compiler.Alternative_RedUpdateArguments, Compiler.Alternative_RedUpdateParameters, Compiler.Alternative_ReturnType, Compiler.Alternative_ReturnValue, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Elements", Compiler.Alternative_Elements);
                publicPropertiesByName.Add("GreenConstructorArguments", Compiler.Alternative_GreenConstructorArguments);
                publicPropertiesByName.Add("GreenConstructorParameters", Compiler.Alternative_GreenConstructorParameters);
                publicPropertiesByName.Add("GreenName", Compiler.Alternative_GreenName);
                publicPropertiesByName.Add("GreenUpdateArguments", Compiler.Alternative_GreenUpdateArguments);
                publicPropertiesByName.Add("GreenUpdateParameters", Compiler.Alternative_GreenUpdateParameters);
                publicPropertiesByName.Add("HasRedToGreenOptionalArguments", Compiler.Alternative_HasRedToGreenOptionalArguments);
                publicPropertiesByName.Add("RedName", Compiler.Alternative_RedName);
                publicPropertiesByName.Add("RedOptionalUpdateParameters", Compiler.Alternative_RedOptionalUpdateParameters);
                publicPropertiesByName.Add("RedToGreenArgumentList", Compiler.Alternative_RedToGreenArgumentList);
                publicPropertiesByName.Add("RedToGreenOptionalArgumentList", Compiler.Alternative_RedToGreenOptionalArgumentList);
                publicPropertiesByName.Add("RedUpdateArguments", Compiler.Alternative_RedUpdateArguments);
                publicPropertiesByName.Add("RedUpdateParameters", Compiler.Alternative_RedUpdateParameters);
                publicPropertiesByName.Add("ReturnType", Compiler.Alternative_ReturnType);
                publicPropertiesByName.Add("ReturnValue", Compiler.Alternative_ReturnValue);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Alternative_Elements, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_Elements, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_Elements), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_GreenConstructorArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_GreenConstructorArguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_GreenConstructorArguments), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_GreenConstructorParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_GreenConstructorParameters, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_GreenConstructorParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_GreenName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_GreenName, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_GreenName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_GreenUpdateArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_GreenUpdateArguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_GreenUpdateArguments), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_GreenUpdateParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_GreenUpdateParameters, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_GreenUpdateParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_HasRedToGreenOptionalArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_HasRedToGreenOptionalArguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_HasRedToGreenOptionalArguments), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedName, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedOptionalUpdateParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedOptionalUpdateParameters, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedOptionalUpdateParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedToGreenArgumentList, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedToGreenArgumentList, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedToGreenArgumentList), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedToGreenOptionalArgumentList, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedToGreenOptionalArgumentList, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedToGreenOptionalArgumentList), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedUpdateArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedUpdateArguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedUpdateArguments), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedUpdateParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedUpdateParameters, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedUpdateParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_ReturnType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_ReturnValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_ReturnValue, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_ReturnValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Parent, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Alternative);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Languages.MetaCompiler.Symbols.PAlternativeSymbol);
            public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
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
                var result = new Alternative_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.AlternativeInfo";
            }
        }
    }
}
