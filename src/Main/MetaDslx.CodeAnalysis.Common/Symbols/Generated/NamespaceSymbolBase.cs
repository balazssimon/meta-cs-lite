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

    public partial class NamespaceSymbolInst : DeclarationSymbolInst, NamespaceSymbol
    {
        private global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent _extent;
        private bool _isGlobalNamespace;
        private global::MetaDslx.CodeAnalysis.NamespaceKind _namespaceKind;
        private global::MetaDslx.CodeAnalysis.Compilation? _containingCompilation;
        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> _constituentNamespaces;
        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> _namespaceMembers;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>> s_GetMembers1 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>> s_GetMembers2 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>> s_GetTypeMembers1 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>> s_GetTypeMembers2 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>>();

        public NamespaceSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public NamespaceSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public NamespaceSymbolInst(__Symbol container, __Model model) 
            : base(container, model)
        {
        }

        public NamespaceSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public NamespaceSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public NamespaceSymbolInst(__Symbol container, __Compilation compilation) 
            : base(container, compilation)
        {
        }

        public NamespaceSymbolInst(__Symbol container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, string? name = default, string? metadataName = default, __ImmutableAttributeSymbols attributes = default, global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent extent = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, name, metadataName, attributes, declaredAccessibility: declaredAccessibility, isStatic: isStatic, isExtern: isExtern, typeArguments: typeArguments, imports: imports)
        {
            _extent = extent;
            NotePartComplete(NamespaceSymbol.CompletionParts.Finish_Extent);
        }

        public override __AssemblySymbol? ContainingAssembly => CallImpl<__AssemblySymbol, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.ContainingAssembly);

        public override __Compilation? DeclaringCompilation => CallImpl<__Compilation, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.DeclaringCompilation);

        public override __ModuleSymbol? ContainingModule => CallImpl<__ModuleSymbol, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.ContainingModule);

        public override __DeclarationSymbol? ContainingDeclaration => CallImpl<__DeclarationSymbol, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.ContainingDeclaration);

        public override __TypeSymbol? ContainingType => CallImpl<__TypeSymbol, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.ContainingType);

        public override __NamespaceSymbol? ContainingNamespace => CallImpl<__NamespaceSymbol, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.ContainingNamespace);

        public global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent Extent
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_Extent, null, default);
                return _extent;
            }
        }
        public bool IsGlobalNamespace
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_IsGlobalNamespace, null, default);
                return _isGlobalNamespace;
            }
        }
        public global::MetaDslx.CodeAnalysis.NamespaceKind NamespaceKind
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_NamespaceKind, null, default);
                return _namespaceKind;
            }
        }
        public global::MetaDslx.CodeAnalysis.Compilation? ContainingCompilation
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_ContainingCompilation, null, default);
                return _containingCompilation;
            }
        }
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> ConstituentNamespaces
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_ConstituentNamespaces, null, default);
                return _constituentNamespaces;
            }
        }
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> NamespaceMembers
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_NamespaceMembers, null, default);
                return _namespaceMembers;
            }
        }

        public override __LexicalSortKey GetLexicalSortKey()
        {
            return CallImpl<__LexicalSortKey, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.GetLexicalSortKey());
        }

        public override bool HasUnsupportedMetadata => CallImpl<bool, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.HasUnsupportedMetadata);

        public override string GetDocumentationCommentId()
        {
            return CallImpl<string, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.GetDocumentationCommentId());
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            return CallImpl<string, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken));
        }

        public virtual NamespaceSymbol? LookupNestedNamespace(global::System.Collections.Immutable.ImmutableArray<string> names)
        {
            return CallImpl<NamespaceSymbol?, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.LookupNestedNamespace(names));
        }

        public virtual NamespaceSymbol? LookupNestedNamespace(string name)
        {
            return CallImpl<NamespaceSymbol?, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.LookupNestedNamespace(name));
        }

        public override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> GetMembers(string name)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
            var __cachedDictionary = s_GetMembers1.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>());
            return __cachedDictionary.GetOrAdd((name), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.GetMembers(name)));
        }

        public override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> GetMembers(string name, string metadataName)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
            var __cachedDictionary = s_GetMembers2.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>());
            return __cachedDictionary.GetOrAdd((name, metadataName), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.GetMembers(name, metadataName)));
        }

        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> GetTypeMembers(string name)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            var __cachedDictionary = s_GetTypeMembers1.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>());
            return __cachedDictionary.GetOrAdd((name), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.GetTypeMembers(name)));
        }

        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> GetTypeMembers(string name, string metadataName)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            var __cachedDictionary = s_GetTypeMembers2.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>());
            return __cachedDictionary.GetOrAdd((name, metadataName), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.GetTypeMembers(name, metadataName)));
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == NamespaceSymbol.CompletionParts.Start_Extent || incompletePart == NamespaceSymbol.CompletionParts.Finish_Extent)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_Extent))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Extent(diagnostics, cancellationToken);
                    _extent = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_Extent);
                }
                return true;
            }
            else 
            if (incompletePart == NamespaceSymbol.CompletionParts.Start_IsGlobalNamespace || incompletePart == NamespaceSymbol.CompletionParts.Finish_IsGlobalNamespace)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_IsGlobalNamespace))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsGlobalNamespace(diagnostics, cancellationToken);
                    _isGlobalNamespace = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_IsGlobalNamespace);
                }
                return true;
            }
            else 
            if (incompletePart == NamespaceSymbol.CompletionParts.Start_NamespaceKind || incompletePart == NamespaceSymbol.CompletionParts.Finish_NamespaceKind)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_NamespaceKind))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_NamespaceKind(diagnostics, cancellationToken);
                    _namespaceKind = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_NamespaceKind);
                }
                return true;
            }
            else 
            if (incompletePart == NamespaceSymbol.CompletionParts.Start_ContainingCompilation || incompletePart == NamespaceSymbol.CompletionParts.Finish_ContainingCompilation)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_ContainingCompilation))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_ContainingCompilation(diagnostics, cancellationToken);
                    _containingCompilation = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_ContainingCompilation);
                }
                return true;
            }
            else 
            if (incompletePart == NamespaceSymbol.CompletionParts.Start_ConstituentNamespaces || incompletePart == NamespaceSymbol.CompletionParts.Finish_ConstituentNamespaces)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_ConstituentNamespaces))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_ConstituentNamespaces(diagnostics, cancellationToken);
                    _constituentNamespaces = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_ConstituentNamespaces);
                }
                return true;
            }
            else 
            if (incompletePart == NamespaceSymbol.CompletionParts.Start_NamespaceMembers || incompletePart == NamespaceSymbol.CompletionParts.Finish_NamespaceMembers)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_NamespaceMembers))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_NamespaceMembers(diagnostics, cancellationToken);
                    _namespaceMembers = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_NamespaceMembers);
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
            CallImpl<NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.CompletePart_Initialize(diagnostics, cancellationToken));
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_Name(diagnostics, cancellationToken));
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_MetadataName(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__Symbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_Attributes(diagnostics, cancellationToken));
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.CompletePart_Finalize(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.CompletePart_Validate(diagnostics, cancellationToken));
        }


        protected virtual global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent Complete_Extent(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_Extent(diagnostics, cancellationToken));
        }

        protected override global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::MetaDslx.CodeAnalysis.Accessibility, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_DeclaredAccessibility(diagnostics, cancellationToken));
        }

        protected override bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_IsStatic(diagnostics, cancellationToken));
        }

        protected override bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_IsExtern(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_TypeArguments(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<ImportSymbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_Imports(diagnostics, cancellationToken));
        }

        protected virtual bool Complete_IsGlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_IsGlobalNamespace(diagnostics, cancellationToken));
        }

        protected virtual global::MetaDslx.CodeAnalysis.NamespaceKind Complete_NamespaceKind(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::MetaDslx.CodeAnalysis.NamespaceKind, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_NamespaceKind(diagnostics, cancellationToken));
        }

        protected virtual global::MetaDslx.CodeAnalysis.Compilation? Complete_ContainingCompilation(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::MetaDslx.CodeAnalysis.Compilation?, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_ContainingCompilation(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_ConstituentNamespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_ConstituentNamespaces(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_NamespaceMembers(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_NamespaceMembers(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<string> Complete_MemberNames(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<string>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_MemberNames(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_Members(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeMembers(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, NamespaceSymbol, NamespaceSymbolImpl>(impl => impl.Complete_TypeMembers(diagnostics, cancellationToken));
        }
    }

    public abstract class NamespaceSymbolBase : DeclarationSymbolImpl, NamespaceSymbol
    {
        public global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent Extent => ((NamespaceSymbol)__Wrapped).Extent;
        public bool IsGlobalNamespace => ((NamespaceSymbol)__Wrapped).IsGlobalNamespace;
        public global::MetaDslx.CodeAnalysis.NamespaceKind NamespaceKind => ((NamespaceSymbol)__Wrapped).NamespaceKind;
        public global::MetaDslx.CodeAnalysis.Compilation? ContainingCompilation => ((NamespaceSymbol)__Wrapped).ContainingCompilation;
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> ConstituentNamespaces => ((NamespaceSymbol)__Wrapped).ConstituentNamespaces;
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> NamespaceMembers => ((NamespaceSymbol)__Wrapped).NamespaceMembers;

        public abstract NamespaceSymbol? LookupNestedNamespace(global::System.Collections.Immutable.ImmutableArray<string> names);
        public abstract NamespaceSymbol? LookupNestedNamespace(string name);


        public virtual global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent Complete_Extent(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent>(this, nameof(Extent), diagnostics, cancellationToken);
        }

        public abstract bool Complete_IsGlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        public abstract global::MetaDslx.CodeAnalysis.NamespaceKind Complete_NamespaceKind(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        public abstract global::MetaDslx.CodeAnalysis.Compilation? Complete_ContainingCompilation(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        public abstract global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_ConstituentNamespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        public abstract global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_NamespaceMembers(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
