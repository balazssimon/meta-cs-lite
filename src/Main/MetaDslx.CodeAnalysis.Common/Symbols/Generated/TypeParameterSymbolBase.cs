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
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<TypeParameterSymbolImpl>;
    using __NotImplementedException = global::System.NotImplementedException;
    using __CultureInfo = global::System.Globalization.CultureInfo;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    public partial class TypeParameterSymbolInst : TypeSymbolInst, TypeParameterSymbol
    {

        public TypeParameterSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public TypeParameterSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public TypeParameterSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public TypeParameterSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public TypeParameterSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, declaration, modelObject, name, metadataName, attributes, isReferenceType, isValueType, typeParameters, baseTypes, allBaseTypes, declaredAccessibility, isStatic, isExtern, typeArguments, imports, members)
        {
        }

        public TypeParameterSymbolInst(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, modelObject, name, metadataName, attributes, isReferenceType, isValueType, typeParameters, baseTypes, allBaseTypes, declaredAccessibility, isStatic, isExtern, typeArguments, imports, members)
        {
        }

        public TypeParameterSymbolInst(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, csharpSymbol, name, metadataName, attributes, isReferenceType, isValueType, typeParameters, baseTypes, allBaseTypes, declaredAccessibility, isStatic, isExtern, typeArguments, imports, members)
        {
        }

        public TypeParameterSymbolInst(__Symbol container, __Compilation compilation, __IModelObject? modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, compilation, modelObject, name, metadataName, attributes, isReferenceType, isValueType, typeParameters, baseTypes, allBaseTypes, declaredAccessibility, isStatic, isExtern, typeArguments, imports, members)
        {
        }

        public override __ISymbolFactory SymbolFactory
        {
            get
            {
                var impl = TypeParameterSymbolImpl.GetInstance(this);
                var result = impl.SymbolFactory;
                impl.Free();
                return result;
            }
        }

        public override __AssemblySymbol? ContainingAssembly
        {
            get
            {
                var impl = TypeParameterSymbolImpl.GetInstance(this);
                var result = impl.ContainingAssembly;
                impl.Free();
                return result;
            }
        }

        public override __Compilation? DeclaringCompilation
        {
            get
            {
                var impl = TypeParameterSymbolImpl.GetInstance(this);
                var result = impl.DeclaringCompilation;
                impl.Free();
                return result;
            }
        }

        public override __ModuleSymbol? ContainingModule
        {
            get
            {
                var impl = TypeParameterSymbolImpl.GetInstance(this);
                var result = impl.ContainingModule;
                impl.Free();
                return result;
            }
        }

        public override __DeclarationSymbol? ContainingDeclaration
        {
            get
            {
                var impl = TypeParameterSymbolImpl.GetInstance(this);
                var result = impl.ContainingDeclaration;
                impl.Free();
                return result;
            }
        }

        public override __TypeSymbol? ContainingType
        {
            get
            {
                var impl = TypeParameterSymbolImpl.GetInstance(this);
                var result = impl.ContainingType;
                impl.Free();
                return result;
            }
        }

        public override __NamespaceSymbol? ContainingNamespace
        {
            get
            {
                var impl = TypeParameterSymbolImpl.GetInstance(this);
                var result = impl.ContainingNamespace;
                impl.Free();
                return result;
            }
        }

        public override __LexicalSortKey GetLexicalSortKey()
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.GetLexicalSortKey();
            impl.Free();
            return result;
        }

        public override bool HasUnsupportedMetadata
        {
            get
            {
                var impl = TypeParameterSymbolImpl.GetInstance(this);
                var result = impl.HasUnsupportedMetadata;
                impl.Free();
                return result;
            }
        }

        public override string GetDocumentationCommentId()
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.GetDocumentationCommentId();
            impl.Free();
            return result;
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
            impl.Free();
            return result;
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
        }


        protected override void CompletePart_Initialize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            impl.CompletePart_Initialize(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_Name(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_MetadataName(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_Attributes(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            impl.CompletePart_Finalize(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            impl.CompletePart_Validate(diagnostics, cancellationToken);
            impl.Free();
        }


        protected override bool Complete_IsReferenceType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsReferenceType(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override bool Complete_IsValueType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsValueType(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> Complete_TypeParameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_TypeParameters(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>) Complete_BaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_BaseTypes(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_AllBaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_AllBaseTypes(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_DeclaredAccessibility(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsStatic(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsExtern(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_TypeArguments(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_Imports(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_Members(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }
    }

    public abstract class TypeParameterSymbolBase : TypeSymbolImpl, TypeParameterSymbol
    {
        protected TypeParameterSymbolBase(__IObjectPool pool) 
            : base(pool)
        {
        }


    }

    public partial class TypeParameterSymbolImpl : TypeParameterSymbolBase
    {
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new TypeParameterSymbolImpl(s_poolInstance), 32);

        protected TypeParameterSymbolImpl(__IObjectPool pool) 
            : base(pool)
        {
        }

        public static new TypeParameterSymbolImpl GetInstance(TypeParameterSymbol wrapped)
        {
            var result = s_poolInstance.Allocate();
            global::System.Diagnostics.Debug.Assert(result.__Wrapped is null);
            result.__InitWrapped(wrapped);
            return result;
        }
    }
}
