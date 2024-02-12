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
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<AssemblySymbolImpl>;
    using __NotImplementedException = global::System.NotImplementedException;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    internal abstract class AssemblySymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolBase, AssemblySymbol
    {
        protected AssemblySymbolBase() 
            : base()
        {
        }

        protected AssemblySymbolBase(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected AssemblySymbolBase(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        protected AssemblySymbolBase(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        protected AssemblySymbolBase(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        protected AssemblySymbolBase(Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
        }

        protected AssemblySymbolBase(Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, modelObject, name, metadataName, attributes)
        {
        }

        protected AssemblySymbolBase(Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
        }

        protected AssemblySymbolBase(Symbol container, __ErrorSymbolInfo errorInfo, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, errorInfo, name, metadataName, attributes)
        {
        }

        protected sealed override __CompletionGraph CompletionGraph => AssemblySymbol.CompletionParts.CompletionGraph;

        public abstract bool IsCorLibrary { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Modules { get; }


        protected abstract bool Complete_IsCorLibrary(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Complete_Modules(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }

    internal sealed class AssemblySymbolDefaultImpl : AssemblySymbolBase
    {
        private bool _isCorLibrary;
        private global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> _modules;

        public AssemblySymbolDefaultImpl(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public AssemblySymbolDefaultImpl(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public AssemblySymbolDefaultImpl(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public AssemblySymbolDefaultImpl(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public AssemblySymbolDefaultImpl(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isCorLibrary, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
            _isCorLibrary = isCorLibrary;
            _modules = modules;
        }

        public AssemblySymbolDefaultImpl(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isCorLibrary, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules) 
            : base(container, modelObject, name, metadataName, attributes)
        {
            _isCorLibrary = isCorLibrary;
            _modules = modules;
        }

        public AssemblySymbolDefaultImpl(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isCorLibrary, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules) 
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
            _isCorLibrary = isCorLibrary;
            _modules = modules;
        }

        public AssemblySymbolDefaultImpl(__Symbol container, __ErrorSymbolInfo errorInfo, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isCorLibrary, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules) 
            : base(container, errorInfo, name, metadataName, attributes)
        {
            _isCorLibrary = isCorLibrary;
            _modules = modules;
        }


        public override bool IsCorLibrary
        {
            get
            {
                this.ForceComplete(AssemblySymbol.CompletionParts.Finish_IsCorLibrary, null, default);
                return _isCorLibrary;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Modules
        {
            get
            {
                this.ForceComplete(AssemblySymbol.CompletionParts.Finish_Modules, null, default);
                return _modules;
            }
        }

        protected sealed override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
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
            else if (incompletePart == AssemblySymbol.CompletionParts.Start_Modules || incompletePart == AssemblySymbol.CompletionParts.Finish_Modules)
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


        protected override bool Complete_IsCorLibrary(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            var result = impl.Complete_IsCorLibrary(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Complete_Modules(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AssemblySymbolImpl.GetInstance(this);
            var result = impl.Complete_Modules(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }
    }

    internal sealed partial class AssemblySymbolImpl
    {
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new AssemblySymbolImpl(s_poolInstance), 32);

        private readonly __ObjectPool _pool;

        private AssemblySymbolImpl(__ObjectPool pool) 
            : base()
        {
            _pool = pool;
        }

        public static AssemblySymbolImpl GetInstance(AssemblySymbol wrapped)
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

        public override bool IsCorLibrary => ((AssemblySymbol)__WrappedInstance).IsCorLibrary;
        public override global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Modules => ((AssemblySymbol)__WrappedInstance).Modules;


        protected override bool Complete_IsCorLibrary(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Complete_Modules(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<ModuleSymbol>.Empty;
        }
    }
}