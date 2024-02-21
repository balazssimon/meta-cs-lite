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

    public partial class AssemblySymbolInst : global::MetaDslx.CodeAnalysis.Symbols.SymbolInst, AssemblySymbol
    {
        private global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory _symbolFactory;
        private global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> _modules;
        private bool _isCorLibrary;
        private NamespaceSymbol _globalNamespace;

        public AssemblySymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public AssemblySymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public AssemblySymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public AssemblySymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public AssemblySymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name = default, string? metadataName = default, __ImmutableAttributeSymbols attributes = default, global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory symbolFactory = default, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules = default, bool isCorLibrary = default) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
            _symbolFactory = symbolFactory;
            _modules = modules;
            _isCorLibrary = isCorLibrary;
            NotePartComplete(AssemblySymbol.CompletionParts.Finish_IsCorLibrary);
        }

        public AssemblySymbolInst(__Symbol container, __IModelObject modelObject, string? name = default, string? metadataName = default, __ImmutableAttributeSymbols attributes = default, global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory symbolFactory = default, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules = default, bool isCorLibrary = default) 
            : base(container, modelObject, name, metadataName, attributes)
        {
            _symbolFactory = symbolFactory;
            _modules = modules;
            _isCorLibrary = isCorLibrary;
            NotePartComplete(AssemblySymbol.CompletionParts.Finish_IsCorLibrary);
        }

        public AssemblySymbolInst(__Symbol container, __ISymbol csharpSymbol, string? name = default, string? metadataName = default, __ImmutableAttributeSymbols attributes = default, global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory symbolFactory = default, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules = default, bool isCorLibrary = default) 
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
            _symbolFactory = symbolFactory;
            _modules = modules;
            _isCorLibrary = isCorLibrary;
            NotePartComplete(AssemblySymbol.CompletionParts.Finish_IsCorLibrary);
        }

        public AssemblySymbolInst(__Symbol container, __Compilation compilation, __IModelObject? modelObject = default, string? name = default, string? metadataName = default, __ImmutableAttributeSymbols attributes = default, global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory symbolFactory = default, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules = default, bool isCorLibrary = default) 
            : base(container, compilation, modelObject, name, metadataName, attributes)
        {
            _symbolFactory = symbolFactory;
            _modules = modules;
            _isCorLibrary = isCorLibrary;
            NotePartComplete(AssemblySymbol.CompletionParts.Finish_IsCorLibrary);
        }

        public AssemblySymbolInst(__Symbol container, __Compilation compilation, __MergedDeclaration declaration, __IModelObject? modelObject = default, string? name = null, string? metadataName = null, __ImmutableAttributeSymbols attributes = default, global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory symbolFactory = default, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules = default, bool isCorLibrary = default) 
            : base(container, compilation, declaration, modelObject, name, metadataName, attributes)
        {
            _symbolFactory = symbolFactory;
            _modules = modules;
            _isCorLibrary = isCorLibrary;
            NotePartComplete(AssemblySymbol.CompletionParts.Finish_IsCorLibrary);
        }

        public override __AssemblySymbol? ContainingAssembly => CallImpl<__AssemblySymbol, AssemblySymbol, AssemblySymbolImpl>(impl => impl.ContainingAssembly);

        public override __Compilation? DeclaringCompilation => CallImpl<__Compilation, AssemblySymbol, AssemblySymbolImpl>(impl => impl.DeclaringCompilation);

        public override __ModuleSymbol? ContainingModule => CallImpl<__ModuleSymbol, AssemblySymbol, AssemblySymbolImpl>(impl => impl.ContainingModule);

        public override __DeclarationSymbol? ContainingDeclaration => CallImpl<__DeclarationSymbol, AssemblySymbol, AssemblySymbolImpl>(impl => impl.ContainingDeclaration);

        public override __TypeSymbol? ContainingType => CallImpl<__TypeSymbol, AssemblySymbol, AssemblySymbolImpl>(impl => impl.ContainingType);

        public override __NamespaceSymbol? ContainingNamespace => CallImpl<__NamespaceSymbol, AssemblySymbol, AssemblySymbolImpl>(impl => impl.ContainingNamespace);

        public virtual global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory SymbolFactory
        {
            get => _symbolFactory;
            protected set => _symbolFactory = value;
        }
        public virtual global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Modules
        {
            get => _modules;
            protected set => _modules = value;
        }
        public bool IsCorLibrary
        {
            get
            {
                this.ForceComplete(AssemblySymbol.CompletionParts.Finish_IsCorLibrary, null, default);
                return _isCorLibrary;
            }
        }
        public NamespaceSymbol GlobalNamespace
        {
            get
            {
                this.ForceComplete(AssemblySymbol.CompletionParts.Finish_GlobalNamespace, null, default);
                return _globalNamespace;
            }
        }

        public override __LexicalSortKey GetLexicalSortKey()
        {
            return CallImpl<__LexicalSortKey, AssemblySymbol, AssemblySymbolImpl>(impl => impl.GetLexicalSortKey());
        }

        public override bool HasUnsupportedMetadata => CallImpl<bool, AssemblySymbol, AssemblySymbolImpl>(impl => impl.HasUnsupportedMetadata);

        public override string GetDocumentationCommentId()
        {
            return CallImpl<string, AssemblySymbol, AssemblySymbolImpl>(impl => impl.GetDocumentationCommentId());
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            return CallImpl<string, AssemblySymbol, AssemblySymbolImpl>(impl => impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken));
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == AssemblySymbol.CompletionParts.Start_IsCorLibrary || incompletePart == AssemblySymbol.CompletionParts.Finish_IsCorLibrary)
            {
                if (NotePartComplete(AssemblySymbol.CompletionParts.Start_IsCorLibrary))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsCorLibrary(diagnostics, cancellationToken);
                    _isCorLibrary = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(AssemblySymbol.CompletionParts.Finish_IsCorLibrary);
                }
                return true;
            }
            else 
            if (incompletePart == AssemblySymbol.CompletionParts.Start_GlobalNamespace || incompletePart == AssemblySymbol.CompletionParts.Finish_GlobalNamespace)
            {
                if (NotePartComplete(AssemblySymbol.CompletionParts.Start_GlobalNamespace))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_GlobalNamespace(diagnostics, cancellationToken);
                    _globalNamespace = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(AssemblySymbol.CompletionParts.Finish_GlobalNamespace);
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
            CallImpl<AssemblySymbol, AssemblySymbolImpl>(impl => impl.CompletePart_Initialize(diagnostics, cancellationToken));
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, AssemblySymbol, AssemblySymbolImpl>(impl => impl.Complete_Name(diagnostics, cancellationToken));
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, AssemblySymbol, AssemblySymbolImpl>(impl => impl.Complete_MetadataName(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__Symbol>, AssemblySymbol, AssemblySymbolImpl>(impl => impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>, AssemblySymbol, AssemblySymbolImpl>(impl => impl.Complete_Attributes(diagnostics, cancellationToken));
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<AssemblySymbol, AssemblySymbolImpl>(impl => impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<AssemblySymbol, AssemblySymbolImpl>(impl => impl.CompletePart_Finalize(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<AssemblySymbol, AssemblySymbolImpl>(impl => impl.CompletePart_Validate(diagnostics, cancellationToken));
        }


        protected virtual bool Complete_IsCorLibrary(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, AssemblySymbol, AssemblySymbolImpl>(impl => impl.Complete_IsCorLibrary(diagnostics, cancellationToken));
        }

        protected virtual NamespaceSymbol Complete_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<NamespaceSymbol, AssemblySymbol, AssemblySymbolImpl>(impl => impl.Complete_GlobalNamespace(diagnostics, cancellationToken));
        }
    }

    public abstract class AssemblySymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl, AssemblySymbol
    {
        public global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory SymbolFactory => ((AssemblySymbol)__Wrapped).SymbolFactory;
        public global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Modules => ((AssemblySymbol)__Wrapped).Modules;
        public bool IsCorLibrary => ((AssemblySymbol)__Wrapped).IsCorLibrary;
        public NamespaceSymbol GlobalNamespace => ((AssemblySymbol)__Wrapped).GlobalNamespace;



        public virtual bool Complete_IsCorLibrary(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsCorLibrary), diagnostics, cancellationToken);
        }

        public abstract NamespaceSymbol Complete_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
