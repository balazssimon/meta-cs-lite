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
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<ModuleSymbolImpl>;
    using __NotImplementedException = global::System.NotImplementedException;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    internal sealed class ModuleSymbolInst : global::MetaDslx.CodeAnalysis.Symbols.SymbolInst, ModuleSymbol
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

        public ModuleSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, NamespaceSymbol globalNamespace) 
            : base(container, errorInfo, name, metadataName, attributes)
        {
            _globalNamespace = globalNamespace;
        }


        public NamespaceSymbol GlobalNamespace
        {
            get
            {
                this.ForceComplete(ModuleSymbol.CompletionParts.Finish_GlobalNamespace, null, default);
                return _globalNamespace;
            }
        }

        protected sealed override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
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


        private NamespaceSymbol Complete_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = ModuleSymbolImpl.GetInstance(this);
            var result = impl.Complete_GlobalNamespace(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }
    }

    public abstract class ModuleSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl, ModuleSymbol
    {
        public NamespaceSymbol GlobalNamespace => ((ModuleSymbol)__WrappedInstance).]GlobalNamespace;


        public virtual NamespaceSymbol Complete_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }
    }

    public sealed partial class ModuleSymbolImpl : ModuleSymbolBase
    {
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new ModuleSymbolImpl(s_poolInstance), 32);

        private readonly __ObjectPool _pool;

        private ModuleSymbolImpl(__ObjectPool pool) 
            : base()
        {
            _pool = pool;
        }

        public static ModuleSymbolImpl GetInstance(ModuleSymbol wrapped)
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


        protected override NamespaceSymbol Complete_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }
    }
}
