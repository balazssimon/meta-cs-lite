#pragma warning disable CS8669

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

    internal class Token_Impl : __MetaModelObject, Token
    {
        private Token_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.GrammarRule(this);
            Compiler.__CustomImpl.LexerRule(this);
            Compiler.__CustomImpl.Token(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public bool IsTrivia
        {
            get => MGet<bool>(Compiler.Token_IsTrivia);
            set => MSet<bool>(Compiler.Token_IsTrivia, value);
        }
    
        public MetaDslx.CodeAnalysis.MetaType ReturnType
        {
            get => MGet<MetaDslx.CodeAnalysis.MetaType>(Compiler.Token_ReturnType);
            set => MSet<MetaDslx.CodeAnalysis.MetaType>(Compiler.Token_ReturnType, value);
        }
    
        public MetaDslx.Languages.MetaCompiler.Model.TokenKind? TokenKind
        {
            get => MGet<MetaDslx.Languages.MetaCompiler.Model.TokenKind?>(Compiler.Token_TokenKind);
            set => MSet<MetaDslx.Languages.MetaCompiler.Model.TokenKind?>(Compiler.Token_TokenKind, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.LAlternative> Alternatives
        {
            get => MGetCollection<LAlternative>(Compiler.LexerRule_Alternatives);
        }
    
        public string? FixedText
        {
            get => Compiler.__CustomImpl.LexerRule_FixedText(this);
        }
    
        public bool IsFixed
        {
            get => Compiler.__CustomImpl.LexerRule_IsFixed(this);
        }
    
        public MetaDslx.Languages.MetaCompiler.Model.Grammar Grammar
        {
            get => Compiler.__CustomImpl.GrammarRule_Grammar(this);
        }
    
        public MetaDslx.Languages.MetaCompiler.Model.Language Language
        {
            get => Compiler.__CustomImpl.GrammarRule_Language(this);
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
    
        public string? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public string? Name
        {
            get => MGet<string?>(Compiler.Declaration_Name);
            set => MSet<string?>(Compiler.Declaration_Name, value);
        }
    
        public string Namespace
        {
            get => Compiler.__CustomImpl.Declaration_Namespace(this);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LexerRuleInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LexerRuleInfo, Compiler.GrammarRuleInfo, Compiler.CSharpElementInfo, Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Token_IsTrivia, Compiler.Token_ReturnType, Compiler.Token_TokenKind);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Token_IsTrivia, Compiler.Token_ReturnType, Compiler.Token_TokenKind, Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Namespace);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Token_IsTrivia, Compiler.Token_ReturnType, Compiler.Token_TokenKind, Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Namespace);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("IsTrivia", Compiler.Token_IsTrivia);
                publicPropertiesByName.Add("ReturnType", Compiler.Token_ReturnType);
                publicPropertiesByName.Add("TokenKind", Compiler.Token_TokenKind);
                publicPropertiesByName.Add("Alternatives", Compiler.LexerRule_Alternatives);
                publicPropertiesByName.Add("FixedText", Compiler.LexerRule_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LexerRule_IsFixed);
                publicPropertiesByName.Add("Grammar", Compiler.GrammarRule_Grammar);
                publicPropertiesByName.Add("Language", Compiler.GrammarRule_Language);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Namespace", Compiler.Declaration_Namespace);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Token_IsTrivia, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Token_IsTrivia, __ImmutableArray.Create<__ModelProperty>(Compiler.Token_IsTrivia), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Token_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Token_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.Token_ReturnType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Token_TokenKind, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Token_TokenKind, __ImmutableArray.Create<__ModelProperty>(Compiler.Token_TokenKind), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LexerRule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LexerRule_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_FixedText), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LexerRule_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_IsFixed), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.GrammarRule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.GrammarRule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Language), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Namespace, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Token);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Languages.MetaCompiler.Symbols.TokenSymbol);
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
                var result = new Token_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.TokenInfo";
            }
        }
    }
}
