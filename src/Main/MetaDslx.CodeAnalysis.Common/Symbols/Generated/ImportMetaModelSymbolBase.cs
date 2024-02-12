namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __MergedDeclaration = global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;
    using __Symbol = global::MetaDslx.CodeAnalysis.Symbols.Symbol;
    using __ErrorSymbolInfo = global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;
    using __CompletionGraph = global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;
    using __CompletionPart = global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;
    using __DiagnosticBag = global::MetaDslx.CodeAnalysis.DiagnosticBag;
    using __SourceLocation = global::MetaDslx.CodeAnalysis.SourceLocation;
    using __CancellationToken = global::System.Threading.CancellationToken;
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<ImportMetaModelSymbolImpl>;
    using __NotImplementedException = global::System.NotImplementedException;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    internal abstract class ImportMetaModelSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolBase, ImportMetaModelSymbol
    {
        protected ImportMetaModelSymbolBase() 
            : base()
        {
        }

        protected ImportMetaModelSymbolBase(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected ImportMetaModelSymbolBase(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        protected ImportMetaModelSymbolBase(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        protected ImportMetaModelSymbolBase(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        protected ImportMetaModelSymbolBase(Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
        }

        protected ImportMetaModelSymbolBase(Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, modelObject, name, metadataName, attributes)
        {
        }

        protected ImportMetaModelSymbolBase(Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
        }

        protected ImportMetaModelSymbolBase(Symbol container, __ErrorSymbolInfo errorInfo, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, errorInfo, name, metadataName, attributes)
        {
        }

        protected sealed override __CompletionGraph CompletionGraph => ImportMetaModelSymbol.CompletionParts.CompletionGraph;

        public abstract global::MetaDslx.CodeAnalysis.MetaSymbol MetaModelSymbols { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> MetaModels { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<string> Files { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Aliases { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Namespaces { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Symbols { get; }


        protected abstract global::MetaDslx.CodeAnalysis.MetaSymbol Complete_MetaModelSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> Complete_MetaModels(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<string> Complete_Files(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Complete_Aliases(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_Namespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Symbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }

    internal sealed class ImportMetaModelSymbolDefaultImpl : ImportMetaModelSymbolBase
    {
        private global::MetaDslx.CodeAnalysis.MetaSymbol _metaModelSymbols;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> _metaModels;
        private global::System.Collections.Immutable.ImmutableArray<string> _files;
        private global::System.Collections.Immutable.ImmutableArray<AliasSymbol> _aliases;
        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> _namespaces;
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _symbols;

        public ImportMetaModelSymbolDefaultImpl(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public ImportMetaModelSymbolDefaultImpl(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public ImportMetaModelSymbolDefaultImpl(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public ImportMetaModelSymbolDefaultImpl(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public ImportMetaModelSymbolDefaultImpl(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.MetaSymbol metaModelSymbols, global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> metaModels, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
            _metaModelSymbols = metaModelSymbols;
            _metaModels = metaModels;
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }

        public ImportMetaModelSymbolDefaultImpl(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.MetaSymbol metaModelSymbols, global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> metaModels, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, modelObject, name, metadataName, attributes)
        {
            _metaModelSymbols = metaModelSymbols;
            _metaModels = metaModels;
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }

        public ImportMetaModelSymbolDefaultImpl(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.MetaSymbol metaModelSymbols, global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> metaModels, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
            _metaModelSymbols = metaModelSymbols;
            _metaModels = metaModels;
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }

        public ImportMetaModelSymbolDefaultImpl(__Symbol container, __ErrorSymbolInfo errorInfo, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.MetaSymbol metaModelSymbols, global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> metaModels, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, errorInfo, name, metadataName, attributes)
        {
            _metaModelSymbols = metaModelSymbols;
            _metaModels = metaModels;
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }


        public override global::MetaDslx.CodeAnalysis.MetaSymbol MetaModelSymbols
        {
            get
            {
                this.ForceComplete(ImportMetaModelSymbol.CompletionParts.Finish_MetaModelSymbols, null, default);
                return _metaModelSymbols;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> MetaModels
        {
            get
            {
                this.ForceComplete(ImportMetaModelSymbol.CompletionParts.Finish_MetaModels, null, default);
                return _metaModels;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<string> Files
        {
            get
            {
                this.ForceComplete(ImportMetaModelSymbol.CompletionParts.Finish_Files, null, default);
                return _files;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Aliases
        {
            get
            {
                this.ForceComplete(ImportMetaModelSymbol.CompletionParts.Finish_Aliases, null, default);
                return _aliases;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Namespaces
        {
            get
            {
                this.ForceComplete(ImportMetaModelSymbol.CompletionParts.Finish_Namespaces, null, default);
                return _namespaces;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Symbols
        {
            get
            {
                this.ForceComplete(ImportMetaModelSymbol.CompletionParts.Finish_Symbols, null, default);
                return _symbols;
            }
        }

        protected sealed override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == ImportMetaModelSymbol.CompletionParts.Start_MetaModelSymbols || incompletePart == ImportMetaModelSymbol.CompletionParts.Finish_MetaModelSymbols)
            {
                if (NotePartComplete(ImportMetaModelSymbol.CompletionParts.Start_MetaModelSymbols))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_MetaModelSymbols(diagnostics, cancellationToken);
                    _metaModelSymbols = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportMetaModelSymbol.CompletionParts.Finish_MetaModelSymbols);
                }
                return true;
            }
            else if (incompletePart == ImportMetaModelSymbol.CompletionParts.Start_MetaModels || incompletePart == ImportMetaModelSymbol.CompletionParts.Finish_MetaModels)
            {
                if (NotePartComplete(ImportMetaModelSymbol.CompletionParts.Start_MetaModels))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_MetaModels(diagnostics, cancellationToken);
                    _metaModels = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportMetaModelSymbol.CompletionParts.Finish_MetaModels);
                }
                return true;
            }
            else if (incompletePart == ImportMetaModelSymbol.CompletionParts.Start_Files || incompletePart == ImportMetaModelSymbol.CompletionParts.Finish_Files)
            {
                if (NotePartComplete(ImportMetaModelSymbol.CompletionParts.Start_Files))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Files(diagnostics, cancellationToken);
                    _files = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportMetaModelSymbol.CompletionParts.Finish_Files);
                }
                return true;
            }
            else if (incompletePart == ImportMetaModelSymbol.CompletionParts.Start_Aliases || incompletePart == ImportMetaModelSymbol.CompletionParts.Finish_Aliases)
            {
                if (NotePartComplete(ImportMetaModelSymbol.CompletionParts.Start_Aliases))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Aliases(diagnostics, cancellationToken);
                    _aliases = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportMetaModelSymbol.CompletionParts.Finish_Aliases);
                }
                return true;
            }
            else if (incompletePart == ImportMetaModelSymbol.CompletionParts.Start_Namespaces || incompletePart == ImportMetaModelSymbol.CompletionParts.Finish_Namespaces)
            {
                if (NotePartComplete(ImportMetaModelSymbol.CompletionParts.Start_Namespaces))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Namespaces(diagnostics, cancellationToken);
                    _namespaces = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportMetaModelSymbol.CompletionParts.Finish_Namespaces);
                }
                return true;
            }
            else if (incompletePart == ImportMetaModelSymbol.CompletionParts.Start_Symbols || incompletePart == ImportMetaModelSymbol.CompletionParts.Finish_Symbols)
            {
                if (NotePartComplete(ImportMetaModelSymbol.CompletionParts.Start_Symbols))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Symbols(diagnostics, cancellationToken);
                    _symbols = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportMetaModelSymbol.CompletionParts.Finish_Symbols);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected override global::MetaDslx.CodeAnalysis.MetaSymbol Complete_MetaModelSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ImportMetaModelSymbolImpl.GetInstance(this);
            var result = impl.Complete_MetaModelSymbols(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> Complete_MetaModels(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ImportMetaModelSymbolImpl.GetInstance(this);
            var result = impl.Complete_MetaModels(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<string> Complete_Files(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ImportMetaModelSymbolImpl.GetInstance(this);
            var result = impl.Complete_Files(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Complete_Aliases(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ImportMetaModelSymbolImpl.GetInstance(this);
            var result = impl.Complete_Aliases(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_Namespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ImportMetaModelSymbolImpl.GetInstance(this);
            var result = impl.Complete_Namespaces(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Symbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ImportMetaModelSymbolImpl.GetInstance(this);
            var result = impl.Complete_Symbols(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }
    }

    internal sealed partial class ImportMetaModelSymbolImpl
    {
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new ImportMetaModelSymbolImpl(s_poolInstance), 32);

        private readonly __ObjectPool _pool;

        private ImportMetaModelSymbolImpl(__ObjectPool pool) 
            : base()
        {
            _pool = pool;
        }

        public static ImportMetaModelSymbolImpl GetInstance(ImportMetaModelSymbol wrapped)
        {
            var result = s_poolInstance.Allocate();
            global::System.Diagnostics.Debug.Assert(result.__WrappedInstance is null);
            __InitInstance(result, wrapped);
            return result;
        }

        public void Free()
        {
            this.__ClearInstance();
            _pool?.Free(this);
        }

        public override global::MetaDslx.CodeAnalysis.MetaSymbol MetaModelSymbols => ((ImportMetaModelSymbol)__WrappedInstance).MetaModelSymbols;
        public override global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> MetaModels => ((ImportMetaModelSymbol)__WrappedInstance).MetaModels;
        public override global::System.Collections.Immutable.ImmutableArray<string> Files => ((ImportMetaModelSymbol)__WrappedInstance).Files;
        public override global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Aliases => ((ImportMetaModelSymbol)__WrappedInstance).Aliases;
        public override global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Namespaces => ((ImportMetaModelSymbol)__WrappedInstance).Namespaces;
        public override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Symbols => ((ImportMetaModelSymbol)__WrappedInstance).Symbols;


        protected override global::MetaDslx.CodeAnalysis.MetaSymbol Complete_MetaModelSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }


        protected override global::System.Collections.Immutable.ImmutableArray<string> Complete_Files(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<string>.Empty;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Complete_Aliases(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<AliasSymbol>.Empty;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_Namespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol>.Empty;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Symbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
        }
    }
}
