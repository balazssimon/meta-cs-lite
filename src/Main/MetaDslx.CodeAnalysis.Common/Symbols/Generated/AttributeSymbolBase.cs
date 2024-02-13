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
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<AttributeSymbolImpl>;
    using __NotImplementedException = global::System.NotImplementedException;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    internal sealed class AttributeSymbolInst : global::MetaDslx.CodeAnalysis.Symbols.SymbolInst, AttributeSymbol
    {
        private TypeSymbol _attributeClass;

        public AttributeSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public AttributeSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public AttributeSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public AttributeSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public AttributeSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, TypeSymbol attributeClass) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
            _attributeClass = attributeClass;
        }

        public AttributeSymbolInst(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, TypeSymbol attributeClass) 
            : base(container, modelObject, name, metadataName, attributes)
        {
            _attributeClass = attributeClass;
        }

        public AttributeSymbolInst(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, TypeSymbol attributeClass) 
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
            _attributeClass = attributeClass;
        }

        public AttributeSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, TypeSymbol attributeClass) 
            : base(container, errorInfo, name, metadataName, attributes)
        {
            _attributeClass = attributeClass;
        }


        public TypeSymbol AttributeClass
        {
            get
            {
                this.ForceComplete(AttributeSymbol.CompletionParts.Finish_AttributeClass, null, default);
                return _attributeClass;
            }
        }

        protected sealed override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == AttributeSymbol.CompletionParts.Start_AttributeClass || incompletePart == AttributeSymbol.CompletionParts.Finish_AttributeClass)
            {
                if (NotePartComplete(AttributeSymbol.CompletionParts.Start_AttributeClass))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_AttributeClass(diagnostics, cancellationToken);
                    _attributeClass = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(AttributeSymbol.CompletionParts.Finish_AttributeClass);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        private TypeSymbol Complete_AttributeClass(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = AttributeSymbolImpl.GetInstance(this);
            var result = impl.Complete_AttributeClass(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }
    }

    public abstract class AttributeSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl, AttributeSymbol
    {
        public TypeSymbol AttributeClass => ((AttributeSymbol)__WrappedInstance).]AttributeClass;


        public virtual TypeSymbol Complete_AttributeClass(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }
    }

    public sealed partial class AttributeSymbolImpl : AttributeSymbolBase
    {
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new AttributeSymbolImpl(s_poolInstance), 32);

        private readonly __ObjectPool _pool;

        private AttributeSymbolImpl(__ObjectPool pool) 
            : base()
        {
            _pool = pool;
        }

        public static AttributeSymbolImpl GetInstance(AttributeSymbol wrapped)
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


        protected override TypeSymbol Complete_AttributeClass(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }
    }
}
