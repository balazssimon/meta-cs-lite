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
    using __Model = global::MetaDslx.Modeling.Model;
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

    public partial class TypeSymbolInst : DeclarationSymbolInst, TypeSymbol
    {
        private bool _isReferenceType;
        private bool _isValueType;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_TypeParameters = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_BaseTypes = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private global::System.Collections.Immutable.ImmutableArray<TypeSymbol> _allBaseTypes;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>> s_GetMembers1 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>> s_GetMembers2 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>> s_GetTypeMembers1 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>> s_GetTypeMembers2 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>>();

        public TypeSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public TypeSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public TypeSymbolInst(__Symbol container, __Model model) 
            : base(container, model)
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

        public TypeSymbolInst(__Symbol container, __Compilation compilation) 
            : base(container, compilation)
        {
        }

        public TypeSymbolInst(__Symbol container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, string? name = default, string? metadataName = default, __ImmutableAttributeSymbols attributes = default, bool isReferenceType = default, bool isValueType = default, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, name, metadataName, attributes, declaredAccessibility: declaredAccessibility, isStatic: isStatic, isExtern: isExtern, typeArguments: typeArguments, imports: imports)
        {
            _isReferenceType = isReferenceType;
            NotePartComplete(TypeSymbol.CompletionParts.Finish_IsReferenceType);
            _isValueType = isValueType;
            NotePartComplete(TypeSymbol.CompletionParts.Finish_IsValueType);
            if (!typeParameters.IsDefaultOrEmpty)
            {
                s_TypeParameters.Add(this, typeParameters);
            }
            NotePartComplete(TypeSymbol.CompletionParts.Finish_TypeParameters);
            if (!baseTypes.IsDefaultOrEmpty)
            {
                s_BaseTypes.Add(this, baseTypes);
            }
            NotePartComplete(TypeSymbol.CompletionParts.Finish_BaseTypes);
        }

        public override __AssemblySymbol? ContainingAssembly => CallImpl<__AssemblySymbol, TypeSymbol, TypeSymbolImpl>(impl => impl.ContainingAssembly);

        public override __Compilation? DeclaringCompilation => CallImpl<__Compilation, TypeSymbol, TypeSymbolImpl>(impl => impl.DeclaringCompilation);

        public override __ModuleSymbol? ContainingModule => CallImpl<__ModuleSymbol, TypeSymbol, TypeSymbolImpl>(impl => impl.ContainingModule);

        public override __DeclarationSymbol? ContainingDeclaration => CallImpl<__DeclarationSymbol, TypeSymbol, TypeSymbolImpl>(impl => impl.ContainingDeclaration);

        public override __TypeSymbol? ContainingType => CallImpl<__TypeSymbol, TypeSymbol, TypeSymbolImpl>(impl => impl.ContainingType);

        public override __NamespaceSymbol? ContainingNamespace => CallImpl<__NamespaceSymbol, TypeSymbol, TypeSymbolImpl>(impl => impl.ContainingNamespace);

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

        public override __LexicalSortKey GetLexicalSortKey()
        {
            return CallImpl<__LexicalSortKey, TypeSymbol, TypeSymbolImpl>(impl => impl.GetLexicalSortKey());
        }

        public override bool HasUnsupportedMetadata => CallImpl<bool, TypeSymbol, TypeSymbolImpl>(impl => impl.HasUnsupportedMetadata);

        public override string GetDocumentationCommentId()
        {
            return CallImpl<string, TypeSymbol, TypeSymbolImpl>(impl => impl.GetDocumentationCommentId());
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            return CallImpl<string, TypeSymbol, TypeSymbolImpl>(impl => impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken));
        }

        public virtual bool IsDerivedFrom(TypeSymbol type, global::MetaDslx.CodeAnalysis.Symbols.TypeEqualityComparer comparison)
        {
            return CallImpl<bool, TypeSymbol, TypeSymbolImpl>(impl => impl.IsDerivedFrom(type, comparison));
        }

        public virtual bool IsEqualToOrDerivedFrom(TypeSymbol type, global::MetaDslx.CodeAnalysis.Symbols.TypeEqualityComparer comparison)
        {
            return CallImpl<bool, TypeSymbol, TypeSymbolImpl>(impl => impl.IsEqualToOrDerivedFrom(type, comparison));
        }

        public override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> GetMembers(string name)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
            var __cachedDictionary = s_GetMembers1.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>());
            return __cachedDictionary.GetOrAdd((name), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.GetMembers(name)));
        }

        public override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> GetMembers(string name, string metadataName)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
            var __cachedDictionary = s_GetMembers2.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>());
            return __cachedDictionary.GetOrAdd((name, metadataName), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.GetMembers(name, metadataName)));
        }

        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> GetTypeMembers(string name)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            var __cachedDictionary = s_GetTypeMembers1.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>());
            return __cachedDictionary.GetOrAdd((name), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.GetTypeMembers(name)));
        }

        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> GetTypeMembers(string name, string metadataName)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            var __cachedDictionary = s_GetTypeMembers2.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>());
            return __cachedDictionary.GetOrAdd((name, metadataName), __args => CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.GetTypeMembers(name, metadataName)));
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
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_BaseTypes.Add(this, result);
                    }
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
            CallImpl<TypeSymbol, TypeSymbolImpl>(impl => impl.CompletePart_Initialize(diagnostics, cancellationToken));
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_Name(diagnostics, cancellationToken));
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_MetadataName(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__Symbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_Attributes(diagnostics, cancellationToken));
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<TypeSymbol, TypeSymbolImpl>(impl => impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<TypeSymbol, TypeSymbolImpl>(impl => impl.CompletePart_Finalize(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<TypeSymbol, TypeSymbolImpl>(impl => impl.CompletePart_Validate(diagnostics, cancellationToken));
        }


        protected virtual bool Complete_IsReferenceType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_IsReferenceType(diagnostics, cancellationToken));
        }

        protected virtual bool Complete_IsValueType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_IsValueType(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> Complete_TypeParameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_TypeParameters(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_BaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_BaseTypes(diagnostics, cancellationToken));
        }

        protected override global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::MetaDslx.CodeAnalysis.Accessibility, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_DeclaredAccessibility(diagnostics, cancellationToken));
        }

        protected override bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_IsStatic(diagnostics, cancellationToken));
        }

        protected override bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_IsExtern(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_TypeArguments(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<ImportSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_Imports(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_AllBaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_AllBaseTypes(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<string> Complete_MemberNames(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<string>, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_MemberNames(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_Members(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeMembers(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, TypeSymbol, TypeSymbolImpl>(impl => impl.Complete_TypeMembers(diagnostics, cancellationToken));
        }
    }

    public abstract class TypeSymbolBase : DeclarationSymbolImpl, TypeSymbol
    {
        public bool IsReferenceType => ((TypeSymbol)__Wrapped).IsReferenceType;
        public bool IsValueType => ((TypeSymbol)__Wrapped).IsValueType;
        public global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> TypeParameters => ((TypeSymbol)__Wrapped).TypeParameters;
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> BaseTypes => ((TypeSymbol)__Wrapped).BaseTypes;
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> AllBaseTypes => ((TypeSymbol)__Wrapped).AllBaseTypes;

        public abstract bool IsDerivedFrom(TypeSymbol type, global::MetaDslx.CodeAnalysis.Symbols.TypeEqualityComparer comparison);
        public abstract bool IsEqualToOrDerivedFrom(TypeSymbol type, global::MetaDslx.CodeAnalysis.Symbols.TypeEqualityComparer comparison);


        public virtual bool Complete_IsReferenceType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsReferenceType), diagnostics, cancellationToken);
        }

        public virtual bool Complete_IsValueType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsValueType), diagnostics, cancellationToken);
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> Complete_TypeParameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValues<TypeParameterSymbol>(this, nameof(TypeParameters), diagnostics, cancellationToken);
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_BaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValues<TypeSymbol>(this, nameof(BaseTypes), diagnostics, cancellationToken);
        }

        public abstract global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_AllBaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
