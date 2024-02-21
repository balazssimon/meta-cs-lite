namespace MetaDslx.CodeAnalysis.Symbols.__Impl
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;
    using __Symbol = global::MetaDslx.CodeAnalysis.Symbols.Symbol;
    using __AttributeSymbol = global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol;
    using __AssemblySymbol = global::MetaDslx.CodeAnalysis.Symbols.AssemblySymbol;
    using __ModuleSymbol = global::MetaDslx.CodeAnalysis.Symbols.ModuleSymbol;
    using __DeclarationSymbol = global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol;
    using __NamespaceSymbol = global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol;
    using __TypeSymbol = global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol;
    using __ISymbolFactory = global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory;
    using __LexicalSortKey = global::MetaDslx.CodeAnalysis.Symbols.LexicalSortKey;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __Model = global::MetaDslx.Modeling.Model;
    using __ErrorSymbolInfo = global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;
    using __CompletionGraph = global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;
    using __CompletionPart = global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;
    using __MergedDeclaration = global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;
    using __DiagnosticBag = global::MetaDslx.CodeAnalysis.DiagnosticBag;
    using __Compilation = global::MetaDslx.CodeAnalysis.Compilation;
    using __SourceLocation = global::MetaDslx.CodeAnalysis.SourceLocation;
    using __CancellationToken = global::System.Threading.CancellationToken;
    using __NotImplementedException = global::System.NotImplementedException;
    using __CultureInfo = global::System.Globalization.CultureInfo;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    public partial class AliasSymbolInst : DeclarationSymbolInst, AliasSymbol
    {
        private Symbol _target;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>> s_GetMembers1 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>> s_GetMembers2 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>> s_GetTypeMembers1 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>> s_GetTypeMembers2 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>>();

        public AliasSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public AliasSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public AliasSymbolInst(__Symbol container, __Model model) 
            : base(container, model)
        {
        }

        public AliasSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public AliasSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public AliasSymbolInst(__Symbol container, __Compilation compilation) 
            : base(container, compilation)
        {
        }

        public AliasSymbolInst(__Symbol container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, string? name = default, string? metadataName = default, __ImmutableAttributeSymbols attributes = default, Symbol target = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, name, metadataName, attributes, declaredAccessibility: declaredAccessibility, isStatic: isStatic, isExtern: isExtern, typeArguments: typeArguments, imports: imports)
        {
            _target = target;
            NotePartComplete(AliasSymbol.CompletionParts.Finish_Target);
        }

        public override __AssemblySymbol? ContainingAssembly => CallImpl<__AssemblySymbol, AliasSymbol, AliasSymbolImpl>(impl => impl.ContainingAssembly);

        public override __Compilation? DeclaringCompilation => CallImpl<__Compilation, AliasSymbol, AliasSymbolImpl>(impl => impl.DeclaringCompilation);

        public override __ModuleSymbol? ContainingModule => CallImpl<__ModuleSymbol, AliasSymbol, AliasSymbolImpl>(impl => impl.ContainingModule);

        public override __DeclarationSymbol? ContainingDeclaration => CallImpl<__DeclarationSymbol, AliasSymbol, AliasSymbolImpl>(impl => impl.ContainingDeclaration);

        public override __TypeSymbol? ContainingType => CallImpl<__TypeSymbol, AliasSymbol, AliasSymbolImpl>(impl => impl.ContainingType);

        public override __NamespaceSymbol? ContainingNamespace => CallImpl<__NamespaceSymbol, AliasSymbol, AliasSymbolImpl>(impl => impl.ContainingNamespace);

        public Symbol Target
        {
            get
            {
                this.ForceComplete(AliasSymbol.CompletionParts.Finish_Target, null, default);
                return _target;
            }
        }

        public override __LexicalSortKey GetLexicalSortKey()
        {
            return CallImpl<__LexicalSortKey, AliasSymbol, AliasSymbolImpl>(impl => impl.GetLexicalSortKey());
        }

        public override bool HasUnsupportedMetadata => CallImpl<bool, AliasSymbol, AliasSymbolImpl>(impl => impl.HasUnsupportedMetadata);

        public override string GetDocumentationCommentId()
        {
            return CallImpl<string, AliasSymbol, AliasSymbolImpl>(impl => impl.GetDocumentationCommentId());
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            return CallImpl<string, AliasSymbol, AliasSymbolImpl>(impl => impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken));
        }

        public override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> GetMembers(string name)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
            var __cachedDictionary = s_GetMembers1.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>());
            return __cachedDictionary.GetOrAdd((name), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, AliasSymbol, AliasSymbolImpl>(impl => impl.GetMembers(name)));
        }

        public override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> GetMembers(string name, string metadataName)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
            var __cachedDictionary = s_GetMembers2.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>());
            return __cachedDictionary.GetOrAdd((name, metadataName), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, AliasSymbol, AliasSymbolImpl>(impl => impl.GetMembers(name, metadataName)));
        }

        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> GetTypeMembers(string name)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            var __cachedDictionary = s_GetTypeMembers1.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>());
            return __cachedDictionary.GetOrAdd((name), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, AliasSymbol, AliasSymbolImpl>(impl => impl.GetTypeMembers(name)));
        }

        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> GetTypeMembers(string name, string metadataName)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            var __cachedDictionary = s_GetTypeMembers2.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>());
            return __cachedDictionary.GetOrAdd((name, metadataName), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, AliasSymbol, AliasSymbolImpl>(impl => impl.GetTypeMembers(name, metadataName)));
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == AliasSymbol.CompletionParts.Start_Target || incompletePart == AliasSymbol.CompletionParts.Finish_Target)
            {
                if (NotePartComplete(AliasSymbol.CompletionParts.Start_Target))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Target(diagnostics, cancellationToken);
                    _target = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(AliasSymbol.CompletionParts.Finish_Target);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected override void CompletePart_Initialize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<AliasSymbol, AliasSymbolImpl>(impl => impl.CompletePart_Initialize(diagnostics, cancellationToken));
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_Name(diagnostics, cancellationToken));
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_MetadataName(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__Symbol>, AliasSymbol, AliasSymbolImpl>(impl => impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_Attributes(diagnostics, cancellationToken));
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<AliasSymbol, AliasSymbolImpl>(impl => impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<AliasSymbol, AliasSymbolImpl>(impl => impl.CompletePart_Finalize(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<AliasSymbol, AliasSymbolImpl>(impl => impl.CompletePart_Validate(diagnostics, cancellationToken));
        }


        protected virtual Symbol Complete_Target(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<Symbol, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_Target(diagnostics, cancellationToken));
        }

        protected override global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::MetaDslx.CodeAnalysis.Accessibility, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_DeclaredAccessibility(diagnostics, cancellationToken));
        }

        protected override bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_IsStatic(diagnostics, cancellationToken));
        }

        protected override bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_IsExtern(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_TypeArguments(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<ImportSymbol>, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_Imports(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<string> Complete_MemberNames(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<string>, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_MemberNames(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_Members(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeMembers(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, AliasSymbol, AliasSymbolImpl>(impl => impl.Complete_TypeMembers(diagnostics, cancellationToken));
        }
    }

    public abstract class AliasSymbolBase : DeclarationSymbolImpl, AliasSymbol
    {
        public Symbol Target => ((AliasSymbol)__Wrapped).Target;



        public virtual Symbol Complete_Target(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<Symbol>(this, nameof(Target), diagnostics, cancellationToken);
        }
    }
}
