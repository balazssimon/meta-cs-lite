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
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<TypeSymbolImpl>;
    using __NotImplementedException = global::System.NotImplementedException;
    using __CultureInfo = global::System.Globalization.CultureInfo;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    public partial class TypeSymbolInst : DeclarationSymbolInst, TypeSymbol
    {
        private bool _isReferenceType;
        private bool _isValueType;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_TypeParameters = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_BaseTypes = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private global::System.Collections.Immutable.ImmutableArray<TypeSymbol> _allBaseTypes;

        public TypeSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public TypeSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public TypeSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public TypeSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public TypeSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, declaration, modelObject, name, metadataName, attributes, declaredAccessibility, isStatic, isExtern, typeArguments, imports, members)
        {
            _isReferenceType = isReferenceType;
            _isValueType = isValueType;
            if (!typeParameters.IsDefaultOrEmpty)
            {
                s_TypeParameters.Add(this, typeParameters);
            }
            if (!baseTypes.IsDefaultOrEmpty)
            {
                s_BaseTypes.Add(this, baseTypes);
            }
            _allBaseTypes = allBaseTypes;
        }

        public TypeSymbolInst(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, modelObject, name, metadataName, attributes, declaredAccessibility, isStatic, isExtern, typeArguments, imports, members)
        {
            _isReferenceType = isReferenceType;
            _isValueType = isValueType;
            if (!typeParameters.IsDefaultOrEmpty)
            {
                s_TypeParameters.Add(this, typeParameters);
            }
            if (!baseTypes.IsDefaultOrEmpty)
            {
                s_BaseTypes.Add(this, baseTypes);
            }
            _allBaseTypes = allBaseTypes;
        }

        public TypeSymbolInst(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, csharpSymbol, name, metadataName, attributes, declaredAccessibility, isStatic, isExtern, typeArguments, imports, members)
        {
            _isReferenceType = isReferenceType;
            _isValueType = isValueType;
            if (!typeParameters.IsDefaultOrEmpty)
            {
                s_TypeParameters.Add(this, typeParameters);
            }
            if (!baseTypes.IsDefaultOrEmpty)
            {
                s_BaseTypes.Add(this, baseTypes);
            }
            _allBaseTypes = allBaseTypes;
        }

        public TypeSymbolInst(__Symbol container, __Compilation compilation, __IModelObject? modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, compilation, modelObject, name, metadataName, attributes, declaredAccessibility, isStatic, isExtern, typeArguments, imports, members)
        {
            _isReferenceType = isReferenceType;
            _isValueType = isValueType;
            if (!typeParameters.IsDefaultOrEmpty)
            {
                s_TypeParameters.Add(this, typeParameters);
            }
            if (!baseTypes.IsDefaultOrEmpty)
            {
                s_BaseTypes.Add(this, baseTypes);
            }
            _allBaseTypes = allBaseTypes;
        }

        public override __ISymbolFactory SymbolFactory
        {
            get
            {
                var impl = TypeSymbolImpl.GetInstance(this);
                var result = impl.SymbolFactory;
                impl.Free();
                return result;
            }
        }

        public override __AssemblySymbol? ContainingAssembly
        {
            get
            {
                var impl = TypeSymbolImpl.GetInstance(this);
                var result = impl.ContainingAssembly;
                impl.Free();
                return result;
            }
        }

        public override __Compilation? DeclaringCompilation
        {
            get
            {
                var impl = TypeSymbolImpl.GetInstance(this);
                var result = impl.DeclaringCompilation;
                impl.Free();
                return result;
            }
        }

        public override __ModuleSymbol? ContainingModule
        {
            get
            {
                var impl = TypeSymbolImpl.GetInstance(this);
                var result = impl.ContainingModule;
                impl.Free();
                return result;
            }
        }

        public override __DeclarationSymbol? ContainingDeclaration
        {
            get
            {
                var impl = TypeSymbolImpl.GetInstance(this);
                var result = impl.ContainingDeclaration;
                impl.Free();
                return result;
            }
        }

        public override __TypeSymbol? ContainingType
        {
            get
            {
                var impl = TypeSymbolImpl.GetInstance(this);
                var result = impl.ContainingType;
                impl.Free();
                return result;
            }
        }

        public override __NamespaceSymbol? ContainingNamespace
        {
            get
            {
                var impl = TypeSymbolImpl.GetInstance(this);
                var result = impl.ContainingNamespace;
                impl.Free();
                return result;
            }
        }

        public override __LexicalSortKey GetLexicalSortKey()
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.GetLexicalSortKey();
            impl.Free();
            return result;
        }

        public override bool HasUnsupportedMetadata
        {
            get
            {
                var impl = TypeSymbolImpl.GetInstance(this);
                var result = impl.HasUnsupportedMetadata;
                impl.Free();
                return result;
            }
        }

        public override string GetDocumentationCommentId()
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.GetDocumentationCommentId();
            impl.Free();
            return result;
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
            impl.Free();
            return result;
        }


        public bool IsReferenceType
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_IsReferenceType, null, default);
                return _isReferenceType;
            }
        }

        public bool IsValueType
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_IsValueType, null, default);
                return _isValueType;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_TypeParameters, null, default);
                if (s_TypeParameters.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>.Empty;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> BaseTypes
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_BaseTypes, null, default);
                if (s_BaseTypes.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> AllBaseTypes
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_AllBaseTypes, null, default);
                return _allBaseTypes;
            }
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == TypeSymbol.CompletionParts.Start_IsReferenceType || incompletePart == TypeSymbol.CompletionParts.Finish_IsReferenceType)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_IsReferenceType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsReferenceType(diagnostics, cancellationToken);
                    _isReferenceType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_IsReferenceType);
                }
                return true;
            }
            else 
            if (incompletePart == TypeSymbol.CompletionParts.Start_IsValueType || incompletePart == TypeSymbol.CompletionParts.Finish_IsValueType)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_IsValueType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsValueType(diagnostics, cancellationToken);
                    _isValueType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_IsValueType);
                }
                return true;
            }
            else 
            if (incompletePart == TypeSymbol.CompletionParts.Start_TypeParameters || incompletePart == TypeSymbol.CompletionParts.Finish_TypeParameters)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_TypeParameters))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_TypeParameters(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_TypeParameters.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_TypeParameters);
                }
                return true;
            }
            else 
            if (incompletePart == TypeSymbol.CompletionParts.Start_BaseTypes || incompletePart == TypeSymbol.CompletionParts.Finish_BaseTypes)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_BaseTypes))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_BaseTypes(diagnostics, cancellationToken);
                    if (!result.BaseTypes.IsDefaultOrEmpty)
                    {
                        s_BaseTypes.Add(this, result.BaseTypes);
                    }
                    _allBaseTypes = result.AllBaseTypes;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_BaseTypes);
                }
                return true;
            }
            else 
            if (incompletePart == TypeSymbol.CompletionParts.Start_AllBaseTypes || incompletePart == TypeSymbol.CompletionParts.Finish_AllBaseTypes)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_AllBaseTypes))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_AllBaseTypes(diagnostics, cancellationToken);
                    _allBaseTypes = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_AllBaseTypes);
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
            var impl = TypeSymbolImpl.GetInstance(this);
            impl.CompletePart_Initialize(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_Name(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_MetadataName(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_Attributes(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            impl.CompletePart_Finalize(diagnostics, cancellationToken);
            impl.Free();
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            impl.CompletePart_Validate(diagnostics, cancellationToken);
            impl.Free();
        }


        protected virtual bool Complete_IsReferenceType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsReferenceType(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected virtual bool Complete_IsValueType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsValueType(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> Complete_TypeParameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_TypeParameters(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected virtual (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>) Complete_BaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_BaseTypes(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_AllBaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_AllBaseTypes(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_DeclaredAccessibility(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsStatic(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsExtern(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_TypeArguments(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_Imports(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeSymbolImpl.GetInstance(this);
            var result = impl.Complete_Members(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }
    }

    public abstract class TypeSymbolBase : DeclarationSymbolImpl, TypeSymbol
    {
        protected TypeSymbolBase(__IObjectPool pool) 
            : base(pool)
        {
        }

        public bool IsReferenceType => ((TypeSymbol)__Wrapped).IsReferenceType;
        public bool IsValueType => ((TypeSymbol)__Wrapped).IsValueType;
        public global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> TypeParameters => ((TypeSymbol)__Wrapped).TypeParameters;
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> BaseTypes => ((TypeSymbol)__Wrapped).BaseTypes;
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> AllBaseTypes => ((TypeSymbol)__Wrapped).AllBaseTypes;


        public virtual bool Complete_IsReferenceType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return default;
        }

        public virtual bool Complete_IsValueType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return default;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> Complete_TypeParameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>.Empty;
        }

        public abstract (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>) Complete_BaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        public abstract global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_AllBaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }

    public partial class TypeSymbolImpl : TypeSymbolBase
    {
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new TypeSymbolImpl(s_poolInstance), 32);

        protected TypeSymbolImpl(__IObjectPool pool) 
            : base(pool)
        {
        }

        public static new TypeSymbolImpl GetInstance(TypeSymbol wrapped)
        {
            var result = s_poolInstance.Allocate();
            global::System.Diagnostics.Debug.Assert(result.__Wrapped is null);
            result.__InitWrapped(wrapped);
            return result;
        }
    }
}
