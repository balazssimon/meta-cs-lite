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
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<ModuleSymbolImpl>;
    using __NotImplementedException = global::System.NotImplementedException;
    using __CultureInfo = global::System.Globalization.CultureInfo;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    public partial class ModuleSymbolInst : global::MetaDslx.CodeAnalysis.Symbols.SymbolInst, ModuleSymbol
    {
        private NamespaceSymbol _globalNamespace;

        public ModuleSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public ModuleSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public ModuleSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public ModuleSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public ModuleSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, NamespaceSymbol globalNamespace) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
            _globalNamespace = globalNamespace;
        }

        public ModuleSymbolInst(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, NamespaceSymbol globalNamespace) 
            : base(container, modelObject, name, metadataName, attributes)
        {
            _globalNamespace = globalNamespace;
        }

        public ModuleSymbolInst(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, NamespaceSymbol globalNamespace) 
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
            _globalNamespace = globalNamespace;
        }

        public ModuleSymbolInst(__Symbol container, __Compilation compilation, __IModelObject? modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, NamespaceSymbol globalNamespace) 
            : base(container, compilation, modelObject, name, metadataName, attributes)
        {
            _globalNamespace = globalNamespace;
        }

        public override __ISymbolFactory SymbolFactory
        {
            get
            {
                var impl = ModuleSymbolImpl.GetInstance(this);
                var result = impl.SymbolFactory;
                impl.Free();
                return result;
            }
        }

        public override __AssemblySymbol? ContainingAssembly
        {
            get
            {
                var impl = ModuleSymbolImpl.GetInstance(this);
                var result = impl.ContainingAssembly;
                impl.Free();
                return result;
            }
        }

        public override __Compilation? DeclaringCompilation
        {
            get
            {
                var impl = ModuleSymbolImpl.GetInstance(this);
                var result = impl.DeclaringCompilation;
                impl.Free();
                return result;
            }
        }

        public override __ModuleSymbol? ContainingModule
        {
            get
            {
                var impl = ModuleSymbolImpl.GetInstance(this);
                var result = impl.ContainingModule;
                impl.Free();
                return result;
            }
        }

        public override __DeclarationSymbol? ContainingDeclaration
        {
            get
            {
                var impl = ModuleSymbolImpl.GetInstance(this);
                var result = impl.ContainingDeclaration;
                impl.Free();
                return result;
            }
        }

        public override __TypeSymbol? ContainingType
        {
            get
            {
                var impl = ModuleSymbolImpl.GetInstance(this);
                var result = impl.ContainingType;
                impl.Free();
                return result;
            }
        }

        public override __NamespaceSymbol? ContainingNamespace
        {
            get
            {
                var impl = ModuleSymbolImpl.GetInstance(this);
                var result = impl.ContainingNamespace;
                impl.Free();
                return result;
            }
        }

        public override __LexicalSortKey GetLexicalSortKey()
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            var result = impl.GetLexicalSortKey();
            impl.Free();
            return result;
        }

        public override bool HasUnsupportedMetadata
        {
            get
            {
                var impl = ModuleSymbolImpl.GetInstance(this);
                var result = impl.HasUnsupportedMetadata;
                impl.Free();
                return result;
            }
        }

        public override string GetDocumentationCommentId()
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            var result = impl.GetDocumentationCommentId();
            impl.Free();
            return result;
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            var result = impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
            impl.Free();
            return result;
        }


        public NamespaceSymbol GlobalNamespace
        {
            get
            {
                this.ForceComplete(ModuleSymbol.CompletionParts.Finish_GlobalNamespace, null, default);
                return _globalNamespace;
            }
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == ModuleSymbol.CompletionParts.Start_GlobalNamespace || incompletePart == ModuleSymbol.CompletionParts.Finish_GlobalNamespace)
            {
                if (NotePartComplete(ModuleSymbol.CompletionParts.Start_GlobalNamespace))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_GlobalNamespace(diagnostics, cancellationToken);
                    _globalNamespace = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ModuleSymbol.CompletionParts.Finish_GlobalNamespace);
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
            var impl = ModuleSymbolImpl.GetInstance(this);
            impl.CompletePart_Initialize(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            var result = impl.Complete_Name(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            var result = impl.Complete_MetadataName(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            var result = impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            var result = impl.Complete_Attributes(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            impl.CompletePart_Finalize(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            impl.CompletePart_Validate(diagnostics, cancellationToken);
            impl.Free();
        }


        protected virtual NamespaceSymbol Complete_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            var result = impl.Complete_GlobalNamespace(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }
    }

    public abstract class ModuleSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl, ModuleSymbol
    {
        protected ModuleSymbolBase(__IObjectPool pool) 
            : base(pool)
        {
        }

        public NamespaceSymbol GlobalNamespace => ((ModuleSymbol)__Wrapped).GlobalNamespace;


        public virtual NamespaceSymbol Complete_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return default;
        }
    }

    public partial class ModuleSymbolImpl : ModuleSymbolBase
    {
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new ModuleSymbolImpl(s_poolInstance), 32);

        protected ModuleSymbolImpl(__IObjectPool pool) 
            : base(pool)
        {
        }

        public static new ModuleSymbolImpl GetInstance(ModuleSymbol wrapped)
        {
            var result = s_poolInstance.Allocate();
            global::System.Diagnostics.Debug.Assert(result.__Wrapped is null);
            result.__InitWrapped(wrapped);
            return result;
        }
    }
}
