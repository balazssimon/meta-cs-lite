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
    using __IObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.IObjectPool;
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<AssemblySymbolImpl>;
    using __NotImplementedException = global::System.NotImplementedException;
    using __CultureInfo = global::System.Globalization.CultureInfo;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    public partial class AssemblySymbolInst : global::MetaDslx.CodeAnalysis.Symbols.SymbolInst, AssemblySymbol
    {
        private bool _isCorLibrary;
        private global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> _modules;

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

        public AssemblySymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isCorLibrary, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
            _isCorLibrary = isCorLibrary;
            _modules = modules;
        }

        public AssemblySymbolInst(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isCorLibrary, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules) 
            : base(container, modelObject, name, metadataName, attributes)
        {
            _isCorLibrary = isCorLibrary;
            _modules = modules;
        }

        public AssemblySymbolInst(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isCorLibrary, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules) 
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
            _isCorLibrary = isCorLibrary;
            _modules = modules;
        }

        public AssemblySymbolInst(__Symbol container, __Compilation compilation, __IModelObject? modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isCorLibrary, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules) 
            : base(container, compilation, modelObject, name, metadataName, attributes)
        {
            _isCorLibrary = isCorLibrary;
            _modules = modules;
        }

        public override __ISymbolFactory SymbolFactory
        {
            get
            {
                var impl = AssemblySymbolImpl.GetInstance(this);
                var result = impl.SymbolFactory;
                impl.Free();
                return result;
            }
        }

        public override __AssemblySymbol? ContainingAssembly
        {
            get
            {
                var impl = AssemblySymbolImpl.GetInstance(this);
                var result = impl.ContainingAssembly;
                impl.Free();
                return result;
            }
        }

        public override __Compilation? DeclaringCompilation
        {
            get
            {
                var impl = AssemblySymbolImpl.GetInstance(this);
                var result = impl.DeclaringCompilation;
                impl.Free();
                return result;
            }
        }

        public override __ModuleSymbol? ContainingModule
        {
            get
            {
                var impl = AssemblySymbolImpl.GetInstance(this);
                var result = impl.ContainingModule;
                impl.Free();
                return result;
            }
        }

        public override __DeclarationSymbol? ContainingDeclaration
        {
            get
            {
                var impl = AssemblySymbolImpl.GetInstance(this);
                var result = impl.ContainingDeclaration;
                impl.Free();
                return result;
            }
        }

        public override __TypeSymbol? ContainingType
        {
            get
            {
                var impl = AssemblySymbolImpl.GetInstance(this);
                var result = impl.ContainingType;
                impl.Free();
                return result;
            }
        }

        public override __NamespaceSymbol? ContainingNamespace
        {
            get
            {
                var impl = AssemblySymbolImpl.GetInstance(this);
                var result = impl.ContainingNamespace;
                impl.Free();
                return result;
            }
        }

        public override __LexicalSortKey GetLexicalSortKey()
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            var result = impl.GetLexicalSortKey();
            impl.Free();
            return result;
        }

        public override bool HasUnsupportedMetadata
        {
            get
            {
                var impl = AssemblySymbolImpl.GetInstance(this);
                var result = impl.HasUnsupportedMetadata;
                impl.Free();
                return result;
            }
        }

        public override string GetDocumentationCommentId()
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            var result = impl.GetDocumentationCommentId();
            impl.Free();
            return result;
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            var result = impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
            impl.Free();
            return result;
        }


        public bool IsCorLibrary
        {
            get
            {
                this.ForceComplete(AssemblySymbol.CompletionParts.Finish_IsCorLibrary, null, default);
                return _isCorLibrary;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Modules
        {
            get
            {
                this.ForceComplete(AssemblySymbol.CompletionParts.Finish_Modules, null, default);
                return _modules;
            }
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
            if (incompletePart == AssemblySymbol.CompletionParts.Start_Modules || incompletePart == AssemblySymbol.CompletionParts.Finish_Modules)
            {
                if (NotePartComplete(AssemblySymbol.CompletionParts.Start_Modules))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Modules(diagnostics, cancellationToken);
                    _modules = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(AssemblySymbol.CompletionParts.Finish_Modules);
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
            var impl = AssemblySymbolImpl.GetInstance(this);
            impl.CompletePart_Initialize(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            var result = impl.Complete_Name(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            var result = impl.Complete_MetadataName(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            var result = impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            var result = impl.Complete_Attributes(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            impl.CompletePart_Finalize(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            impl.CompletePart_Validate(diagnostics, cancellationToken);
            impl.Free();
        }


        protected virtual bool Complete_IsCorLibrary(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            var result = impl.Complete_IsCorLibrary(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Complete_Modules(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            var result = impl.Complete_Modules(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }
    }

    public abstract class AssemblySymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl, AssemblySymbol
    {
        protected AssemblySymbolBase(__IObjectPool pool) 
            : base(pool)
        {
        }

        public bool IsCorLibrary => ((AssemblySymbol)__Wrapped).IsCorLibrary;
        public global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Modules => ((AssemblySymbol)__Wrapped).Modules;


        public virtual bool Complete_IsCorLibrary(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return default;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Complete_Modules(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return global::System.Collections.Immutable.ImmutableArray<ModuleSymbol>.Empty;
        }
    }

    public partial class AssemblySymbolImpl : AssemblySymbolBase
    {
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new AssemblySymbolImpl(s_poolInstance), 32);

        protected AssemblySymbolImpl(__IObjectPool pool) 
            : base(pool)
        {
        }

        public static new AssemblySymbolImpl GetInstance(AssemblySymbol wrapped)
        {
            var result = s_poolInstance.Allocate();
            global::System.Diagnostics.Debug.Assert(result.__Wrapped is null);
            result.__InitWrapped(wrapped);
            return result;
        }
    }
}
