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

    public partial class AttributeSymbolInst : global::MetaDslx.CodeAnalysis.Symbols.SymbolInst, AttributeSymbol
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

        public AttributeSymbolInst(__Symbol container, __Compilation compilation, __IModelObject? modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, TypeSymbol attributeClass) 
            : base(container, compilation, modelObject, name, metadataName, attributes)
        {
            _attributeClass = attributeClass;
        }

        public override __ISymbolFactory SymbolFactory => CallImpl<__ISymbolFactory, AttributeSymbol, AttributeSymbolImpl>(impl => impl.SymbolFactory);

        public override __AssemblySymbol? ContainingAssembly => CallImpl<__AssemblySymbol, AttributeSymbol, AttributeSymbolImpl>(impl => impl.ContainingAssembly);

        public override __Compilation? DeclaringCompilation => CallImpl<__Compilation, AttributeSymbol, AttributeSymbolImpl>(impl => impl.DeclaringCompilation);

        public override __ModuleSymbol? ContainingModule => CallImpl<__ModuleSymbol, AttributeSymbol, AttributeSymbolImpl>(impl => impl.ContainingModule);

        public override __DeclarationSymbol? ContainingDeclaration => CallImpl<__DeclarationSymbol, AttributeSymbol, AttributeSymbolImpl>(impl => impl.ContainingDeclaration);

        public override __TypeSymbol? ContainingType => CallImpl<__TypeSymbol, AttributeSymbol, AttributeSymbolImpl>(impl => impl.ContainingType);

        public override __NamespaceSymbol? ContainingNamespace => CallImpl<__NamespaceSymbol, AttributeSymbol, AttributeSymbolImpl>(impl => impl.ContainingNamespace);

        public override __LexicalSortKey GetLexicalSortKey()
        {
            return CallImpl<__LexicalSortKey, AttributeSymbol, AttributeSymbolImpl>(impl => impl.GetLexicalSortKey());
        }

        public override bool HasUnsupportedMetadata => CallImpl<bool, AttributeSymbol, AttributeSymbolImpl>(impl => impl.HasUnsupportedMetadata);

        public override string GetDocumentationCommentId()
        {
            return CallImpl<string, AttributeSymbol, AttributeSymbolImpl>(impl => impl.GetDocumentationCommentId());
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            return CallImpl<string, AttributeSymbol, AttributeSymbolImpl>(impl => impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken));
        }


        public TypeSymbol AttributeClass
        {
            get
            {
                this.ForceComplete(AttributeSymbol.CompletionParts.Finish_AttributeClass, null, default);
                return _attributeClass;
            }
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
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


        protected override void CompletePart_Initialize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<AttributeSymbol, AttributeSymbolImpl>(impl => impl.CompletePart_Initialize(diagnostics, cancellationToken));
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, AttributeSymbol, AttributeSymbolImpl>(impl => impl.Complete_Name(diagnostics, cancellationToken));
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, AttributeSymbol, AttributeSymbolImpl>(impl => impl.Complete_MetadataName(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__Symbol>, AttributeSymbol, AttributeSymbolImpl>(impl => impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>, AttributeSymbol, AttributeSymbolImpl>(impl => impl.Complete_Attributes(diagnostics, cancellationToken));
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<AttributeSymbol, AttributeSymbolImpl>(impl => impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<AttributeSymbol, AttributeSymbolImpl>(impl => impl.CompletePart_Finalize(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<AttributeSymbol, AttributeSymbolImpl>(impl => impl.CompletePart_Validate(diagnostics, cancellationToken));
        }


        protected virtual TypeSymbol Complete_AttributeClass(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<TypeSymbol, AttributeSymbol, AttributeSymbolImpl>(impl => impl.Complete_AttributeClass(diagnostics, cancellationToken));
        }
    }

    public abstract class AttributeSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl, AttributeSymbol
    {
        public TypeSymbol AttributeClass => ((AttributeSymbol)__Wrapped).AttributeClass;


        public virtual TypeSymbol Complete_AttributeClass(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return default;
        }
    }
}
