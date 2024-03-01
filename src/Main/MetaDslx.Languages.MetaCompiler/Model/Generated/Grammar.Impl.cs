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

    internal class Grammar_Impl : __MetaModelObject, Grammar
    {
        private Grammar_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.Grammar(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.Block> Blocks
        {
            get => MGetCollection<Block>(Compiler.Grammar_Blocks);
        }
    
        public MetaDslx.Languages.MetaCompiler.Model.Token? DefaultEndOfLine
        {
            get => MGet<MetaDslx.Languages.MetaCompiler.Model.Token?>(Compiler.Grammar_DefaultEndOfLine);
            set => MSet<MetaDslx.Languages.MetaCompiler.Model.Token?>(Compiler.Grammar_DefaultEndOfLine, value);
        }
    
        public MetaDslx.Languages.MetaCompiler.Model.Token? DefaultIdentifier
        {
            get => MGet<MetaDslx.Languages.MetaCompiler.Model.Token?>(Compiler.Grammar_DefaultIdentifier);
            set => MSet<MetaDslx.Languages.MetaCompiler.Model.Token?>(Compiler.Grammar_DefaultIdentifier, value);
        }
    
        public MetaDslx.Languages.MetaCompiler.Model.Token? DefaultSeparator
        {
            get => MGet<MetaDslx.Languages.MetaCompiler.Model.Token?>(Compiler.Grammar_DefaultSeparator);
            set => MSet<MetaDslx.Languages.MetaCompiler.Model.Token?>(Compiler.Grammar_DefaultSeparator, value);
        }
    
        public MetaDslx.Languages.MetaCompiler.Model.Token? DefaultWhitespace
        {
            get => MGet<MetaDslx.Languages.MetaCompiler.Model.Token?>(Compiler.Grammar_DefaultWhitespace);
            set => MSet<MetaDslx.Languages.MetaCompiler.Model.Token?>(Compiler.Grammar_DefaultWhitespace, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.GrammarRule> GrammarRules
        {
            get => MGetCollection<GrammarRule>(Compiler.Grammar_GrammarRules);
        }
    
        public MetaDslx.Languages.MetaCompiler.Model.Language Language
        {
            get => Compiler.__CustomImpl.Grammar_Language(this);
        }
    
        public MetaDslx.Languages.MetaCompiler.Model.Rule? MainRule
        {
            get => MGet<MetaDslx.Languages.MetaCompiler.Model.Rule?>(Compiler.Grammar_MainRule);
            set => MSet<MetaDslx.Languages.MetaCompiler.Model.Rule?>(Compiler.Grammar_MainRule, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.Rule> Rules
        {
            get => MGetCollection<Rule>(Compiler.Grammar_Rules);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.TokenKind> TokenKinds
        {
            get => MGetCollection<TokenKind>(Compiler.Grammar_TokenKinds);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.Token> Tokens
        {
            get => MGetCollection<Token>(Compiler.Grammar_Tokens);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Blocks, Compiler.Grammar_DefaultEndOfLine, Compiler.Grammar_DefaultIdentifier, Compiler.Grammar_DefaultSeparator, Compiler.Grammar_DefaultWhitespace, Compiler.Grammar_GrammarRules, Compiler.Grammar_Language, Compiler.Grammar_MainRule, Compiler.Grammar_Rules, Compiler.Grammar_TokenKinds, Compiler.Grammar_Tokens);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Blocks, Compiler.Grammar_DefaultEndOfLine, Compiler.Grammar_DefaultIdentifier, Compiler.Grammar_DefaultSeparator, Compiler.Grammar_DefaultWhitespace, Compiler.Grammar_GrammarRules, Compiler.Grammar_Language, Compiler.Grammar_MainRule, Compiler.Grammar_Rules, Compiler.Grammar_TokenKinds, Compiler.Grammar_Tokens, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Namespace);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Blocks, Compiler.Grammar_DefaultEndOfLine, Compiler.Grammar_DefaultIdentifier, Compiler.Grammar_DefaultSeparator, Compiler.Grammar_DefaultWhitespace, Compiler.Grammar_GrammarRules, Compiler.Grammar_Language, Compiler.Grammar_MainRule, Compiler.Grammar_Rules, Compiler.Grammar_TokenKinds, Compiler.Grammar_Tokens, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Namespace);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Blocks", Compiler.Grammar_Blocks);
                publicPropertiesByName.Add("DefaultEndOfLine", Compiler.Grammar_DefaultEndOfLine);
                publicPropertiesByName.Add("DefaultIdentifier", Compiler.Grammar_DefaultIdentifier);
                publicPropertiesByName.Add("DefaultSeparator", Compiler.Grammar_DefaultSeparator);
                publicPropertiesByName.Add("DefaultWhitespace", Compiler.Grammar_DefaultWhitespace);
                publicPropertiesByName.Add("GrammarRules", Compiler.Grammar_GrammarRules);
                publicPropertiesByName.Add("Language", Compiler.Grammar_Language);
                publicPropertiesByName.Add("MainRule", Compiler.Grammar_MainRule);
                publicPropertiesByName.Add("Rules", Compiler.Grammar_Rules);
                publicPropertiesByName.Add("TokenKinds", Compiler.Grammar_TokenKinds);
                publicPropertiesByName.Add("Tokens", Compiler.Grammar_Tokens);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Namespace", Compiler.Declaration_Namespace);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Grammar_Blocks, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Blocks, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Blocks), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_DefaultEndOfLine, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_DefaultEndOfLine, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_DefaultEndOfLine), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_DefaultIdentifier, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_DefaultIdentifier, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_DefaultIdentifier), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_DefaultSeparator, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_DefaultSeparator, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_DefaultSeparator), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_DefaultWhitespace, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_DefaultWhitespace, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_DefaultWhitespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_GrammarRules, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_GrammarRules, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_GrammarRules), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Rules, Compiler.Grammar_Tokens), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_MainRule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_MainRule, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_MainRule), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_Rules, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Rules, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Rules), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_GrammarRules), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_TokenKinds, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_TokenKinds, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_TokenKinds), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_Tokens, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Tokens, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Tokens), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_GrammarRules), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
            public override __MetaType MetaType => typeof(Grammar);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
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
                var result = new Grammar_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.GrammarInfo";
            }
        }
    }
}
