namespace MetaDslx.CodeAnalysis.Symbols
{
    using __Type = global::System.Type;
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;
    using __SymbolAttribute = global::MetaDslx.CodeAnalysis.Symbols.SymbolAttribute;
    using __PhaseAttribute = global::MetaDslx.CodeAnalysis.Symbols.PhaseAttribute;
    using __DerivedAttribute = global::MetaDslx.CodeAnalysis.Symbols.DerivedAttribute;
    using __WeakAttribute = global::MetaDslx.CodeAnalysis.Symbols.WeakAttribute;
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
    using __ModelPropertyAttribute = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;
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

    [__SymbolAttribute]
    public abstract partial class TypeParameterSymbol: Impl.TypeSymbolImpl
    {
        public new class CompletionParts : Impl.TypeSymbolImpl.CompletionParts
        {

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    Impl.TypeSymbolImpl.CompletionParts.CompletionGraph
                );
        }


        public TypeParameterSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> attributes = default, bool isReferenceType = default, bool isValueType = default, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, DeclarationSymbol originalDefinition = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes, isReferenceType: isReferenceType, isValueType: isValueType, typeParameters: typeParameters, baseTypes: baseTypes, declaredAccessibility: declaredAccessibility, isStatic: isStatic, isExtern: isExtern, originalDefinition: originalDefinition, typeArguments: typeArguments, imports: imports)
        {
            if (fixedSymbol)
            {
            }
        }

        public override __Type SymbolType => typeof(TypeParameterSymbol);
        protected override __CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;



        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
        }

    }
}
