namespace MetaDslx.CodeAnalysis.Symbols.__Impl
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
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<ImportSymbolImpl>;
    using __NotImplementedException = global::System.NotImplementedException;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    internal sealed class ImportSymbolInst : global::MetaDslx.CodeAnalysis.Symbols.SymbolInst, ImportSymbol
    {
        private global::System.Collections.Immutable.ImmutableArray<string> _files;
        private global::System.Collections.Immutable.ImmutableArray<AliasSymbol> _aliases;
        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> _namespaces;
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _symbols;

        public ImportSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public ImportSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public ImportSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public ImportSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public ImportSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }

        public ImportSymbolInst(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, modelObject, name, metadataName, attributes)
        {
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }

        public ImportSymbolInst(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }

        public ImportSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, errorInfo, name, metadataName, attributes)
        {
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }


        public global::System.Collections.Immutable.ImmutableArray<string> Files
        {
            get
            {
                this.ForceComplete(ImportSymbol.CompletionParts.Finish_Files, null, default);
                return _files;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Aliases
        {
            get
            {
                this.ForceComplete(ImportSymbol.CompletionParts.Finish_Aliases, null, default);
                return _aliases;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Namespaces
        {
            get
            {
                this.ForceComplete(ImportSymbol.CompletionParts.Finish_Namespaces, null, default);
                return _namespaces;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Symbols
        {
            get
            {
                this.ForceComplete(ImportSymbol.CompletionParts.Finish_Symbols, null, default);
                return _symbols;
            }
        }

        protected sealed override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == ImportSymbol.CompletionParts.Start_Files || incompletePart == ImportSymbol.CompletionParts.Finish_Files)
            {
                if (NotePartComplete(ImportSymbol.CompletionParts.Start_Files))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Files(diagnostics, cancellationToken);
                    _files = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportSymbol.CompletionParts.Finish_Files);
                }
                return true;
            }
            else if (incompletePart == ImportSymbol.CompletionParts.Start_Aliases || incompletePart == ImportSymbol.CompletionParts.Finish_Aliases)
            {
                if (NotePartComplete(ImportSymbol.CompletionParts.Start_Aliases))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Aliases(diagnostics, cancellationToken);
                    _aliases = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportSymbol.CompletionParts.Finish_Aliases);
                }
                return true;
            }
            else if (incompletePart == ImportSymbol.CompletionParts.Start_Namespaces || incompletePart == ImportSymbol.CompletionParts.Finish_Namespaces)
            {
                if (NotePartComplete(ImportSymbol.CompletionParts.Start_Namespaces))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Namespaces(diagnostics, cancellationToken);
                    _namespaces = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportSymbol.CompletionParts.Finish_Namespaces);
                }
                return true;
            }
            else if (incompletePart == ImportSymbol.CompletionParts.Start_Symbols || incompletePart == ImportSymbol.CompletionParts.Finish_Symbols)
            {
                if (NotePartComplete(ImportSymbol.CompletionParts.Start_Symbols))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Symbols(diagnostics, cancellationToken);
                    _symbols = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportSymbol.CompletionParts.Finish_Symbols);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        private global::System.Collections.Immutable.ImmutableArray<string> Complete_Files(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ImportSymbolImpl.GetInstance(this);
            var result = impl.Complete_Files(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Complete_Aliases(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ImportSymbolImpl.GetInstance(this);
            var result = impl.Complete_Aliases(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_Namespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ImportSymbolImpl.GetInstance(this);
            var result = impl.Complete_Namespaces(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Symbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ImportSymbolImpl.GetInstance(this);
            var result = impl.Complete_Symbols(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }
    }

    public abstract class ImportSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl, ImportSymbol
    {
        public global::System.Collections.Immutable.ImmutableArray<string> Files => ((ImportSymbol)__WrappedInstance).]Files;
        public global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Aliases => ((ImportSymbol)__WrappedInstance).]Aliases;
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Namespaces => ((ImportSymbol)__WrappedInstance).]Namespaces;
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Symbols => ((ImportSymbol)__WrappedInstance).]Symbols;


        public virtual global::System.Collections.Immutable.ImmutableArray<string> Complete_Files(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<string>.Empty;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Complete_Aliases(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<AliasSymbol>.Empty;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_Namespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol>.Empty;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Symbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
        }
    }

    public sealed partial class ImportSymbolImpl : ImportSymbolBase
    {
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new ImportSymbolImpl(s_poolInstance), 32);

        private readonly __ObjectPool _pool;

        private ImportSymbolImpl(__ObjectPool pool) 
            : base()
        {
            _pool = pool;
        }

        public static ImportSymbolImpl GetInstance(ImportSymbol wrapped)
        {
            var result = s_poolInstance.Allocate();
            global::System.Diagnostics.Debug.Assert(result.__WrappedInstance is null);
            result.__InitInstance(wrapped);
            return result;
        }

        public void Free()
        {
            this.__ClearInstance();
            _pool?.Free(this);
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
