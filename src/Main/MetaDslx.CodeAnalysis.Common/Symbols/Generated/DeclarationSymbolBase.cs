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

    public partial class DeclarationSymbolInst : global::MetaDslx.CodeAnalysis.Symbols.SymbolInst, DeclarationSymbol
    {
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_DeclaredAccessibility = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private bool _isStatic;
        private bool _isExtern;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_TypeArguments = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_Imports = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _members;

        public DeclarationSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public DeclarationSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public DeclarationSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public DeclarationSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public DeclarationSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
            if (declaredAccessibility != default)
            {
                s_DeclaredAccessibility.Add(this, declaredAccessibility);
            }
            _isStatic = isStatic;
            _isExtern = isExtern;
            if (!typeArguments.IsDefaultOrEmpty)
            {
                s_TypeArguments.Add(this, typeArguments);
            }
            if (!imports.IsDefaultOrEmpty)
            {
                s_Imports.Add(this, imports);
            }
            _members = members;
        }

        public DeclarationSymbolInst(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, modelObject, name, metadataName, attributes)
        {
            if (declaredAccessibility != default)
            {
                s_DeclaredAccessibility.Add(this, declaredAccessibility);
            }
            _isStatic = isStatic;
            _isExtern = isExtern;
            if (!typeArguments.IsDefaultOrEmpty)
            {
                s_TypeArguments.Add(this, typeArguments);
            }
            if (!imports.IsDefaultOrEmpty)
            {
                s_Imports.Add(this, imports);
            }
            _members = members;
        }

        public DeclarationSymbolInst(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
            if (declaredAccessibility != default)
            {
                s_DeclaredAccessibility.Add(this, declaredAccessibility);
            }
            _isStatic = isStatic;
            _isExtern = isExtern;
            if (!typeArguments.IsDefaultOrEmpty)
            {
                s_TypeArguments.Add(this, typeArguments);
            }
            if (!imports.IsDefaultOrEmpty)
            {
                s_Imports.Add(this, imports);
            }
            _members = members;
        }

        public DeclarationSymbolInst(__Symbol container, __Compilation compilation, __IModelObject? modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, compilation, modelObject, name, metadataName, attributes)
        {
            if (declaredAccessibility != default)
            {
                s_DeclaredAccessibility.Add(this, declaredAccessibility);
            }
            _isStatic = isStatic;
            _isExtern = isExtern;
            if (!typeArguments.IsDefaultOrEmpty)
            {
                s_TypeArguments.Add(this, typeArguments);
            }
            if (!imports.IsDefaultOrEmpty)
            {
                s_Imports.Add(this, imports);
            }
            _members = members;
        }

        public override __ISymbolFactory SymbolFactory => CallImpl<__ISymbolFactory, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.SymbolFactory);

        public override __AssemblySymbol? ContainingAssembly => CallImpl<__AssemblySymbol, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.ContainingAssembly);

        public override __Compilation? DeclaringCompilation => CallImpl<__Compilation, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.DeclaringCompilation);

        public override __ModuleSymbol? ContainingModule => CallImpl<__ModuleSymbol, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.ContainingModule);

        public override __DeclarationSymbol? ContainingDeclaration => CallImpl<__DeclarationSymbol, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.ContainingDeclaration);

        public override __TypeSymbol? ContainingType => CallImpl<__TypeSymbol, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.ContainingType);

        public override __NamespaceSymbol? ContainingNamespace => CallImpl<__NamespaceSymbol, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.ContainingNamespace);

        public override __LexicalSortKey GetLexicalSortKey()
        {
            return CallImpl<__LexicalSortKey, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.GetLexicalSortKey());
        }

        public override bool HasUnsupportedMetadata => CallImpl<bool, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.HasUnsupportedMetadata);

        public override string GetDocumentationCommentId()
        {
            return CallImpl<string, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.GetDocumentationCommentId());
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            return CallImpl<string, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken));
        }


        public global::MetaDslx.CodeAnalysis.Accessibility DeclaredAccessibility
        {
            get
            {
                this.ForceComplete(DeclarationSymbol.CompletionParts.Finish_DeclaredAccessibility, null, default);
                if (s_DeclaredAccessibility.TryGetValue(this, out var result)) return (global::MetaDslx.CodeAnalysis.Accessibility)result;
                else return default;
            }
        }

        public bool IsStatic
        {
            get
            {
                this.ForceComplete(DeclarationSymbol.CompletionParts.Finish_IsStatic, null, default);
                return _isStatic;
            }
        }

        public bool IsExtern
        {
            get
            {
                this.ForceComplete(DeclarationSymbol.CompletionParts.Finish_IsExtern, null, default);
                return _isExtern;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> TypeArguments
        {
            get
            {
                this.ForceComplete(DeclarationSymbol.CompletionParts.Finish_TypeArguments, null, default);
                if (s_TypeArguments.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Imports
        {
            get
            {
                this.ForceComplete(DeclarationSymbol.CompletionParts.Finish_Imports, null, default);
                if (s_Imports.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<ImportSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<ImportSymbol>.Empty;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Members
        {
            get
            {
                this.ForceComplete(DeclarationSymbol.CompletionParts.Finish_Members, null, default);
                return _members;
            }
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == DeclarationSymbol.CompletionParts.Start_DeclaredAccessibility || incompletePart == DeclarationSymbol.CompletionParts.Finish_DeclaredAccessibility)
            {
                if (NotePartComplete(DeclarationSymbol.CompletionParts.Start_DeclaredAccessibility))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_DeclaredAccessibility(diagnostics, cancellationToken);
                    if (result != default)
                    {
                        s_DeclaredAccessibility.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(DeclarationSymbol.CompletionParts.Finish_DeclaredAccessibility);
                }
                return true;
            }
            else 
            if (incompletePart == DeclarationSymbol.CompletionParts.Start_IsStatic || incompletePart == DeclarationSymbol.CompletionParts.Finish_IsStatic)
            {
                if (NotePartComplete(DeclarationSymbol.CompletionParts.Start_IsStatic))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsStatic(diagnostics, cancellationToken);
                    _isStatic = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(DeclarationSymbol.CompletionParts.Finish_IsStatic);
                }
                return true;
            }
            else 
            if (incompletePart == DeclarationSymbol.CompletionParts.Start_IsExtern || incompletePart == DeclarationSymbol.CompletionParts.Finish_IsExtern)
            {
                if (NotePartComplete(DeclarationSymbol.CompletionParts.Start_IsExtern))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsExtern(diagnostics, cancellationToken);
                    _isExtern = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(DeclarationSymbol.CompletionParts.Finish_IsExtern);
                }
                return true;
            }
            else 
            if (incompletePart == DeclarationSymbol.CompletionParts.Start_TypeArguments || incompletePart == DeclarationSymbol.CompletionParts.Finish_TypeArguments)
            {
                if (NotePartComplete(DeclarationSymbol.CompletionParts.Start_TypeArguments))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_TypeArguments(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_TypeArguments.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(DeclarationSymbol.CompletionParts.Finish_TypeArguments);
                }
                return true;
            }
            else 
            if (incompletePart == DeclarationSymbol.CompletionParts.Start_Imports || incompletePart == DeclarationSymbol.CompletionParts.Finish_Imports)
            {
                if (NotePartComplete(DeclarationSymbol.CompletionParts.Start_Imports))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Imports(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_Imports.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(DeclarationSymbol.CompletionParts.Finish_Imports);
                }
                return true;
            }
            else 
            if (incompletePart == DeclarationSymbol.CompletionParts.Start_Members || incompletePart == DeclarationSymbol.CompletionParts.Finish_Members)
            {
                if (NotePartComplete(DeclarationSymbol.CompletionParts.Start_Members))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Members(diagnostics, cancellationToken);
                    _members = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(DeclarationSymbol.CompletionParts.Finish_Members);
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
            CallImpl<DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.CompletePart_Initialize(diagnostics, cancellationToken));
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.Complete_Name(diagnostics, cancellationToken));
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.Complete_MetadataName(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__Symbol>, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.Complete_Attributes(diagnostics, cancellationToken));
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.CompletePart_Finalize(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.CompletePart_Validate(diagnostics, cancellationToken));
        }


        protected virtual global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::MetaDslx.CodeAnalysis.Accessibility, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.Complete_DeclaredAccessibility(diagnostics, cancellationToken));
        }

        protected virtual bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.Complete_IsStatic(diagnostics, cancellationToken));
        }

        protected virtual bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<bool, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.Complete_IsExtern(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.Complete_TypeArguments(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<ImportSymbol>, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.Complete_Imports(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, DeclarationSymbol, DeclarationSymbolImpl>(impl => impl.Complete_Members(diagnostics, cancellationToken));
        }
    }

    public abstract class DeclarationSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl, DeclarationSymbol
    {
        public global::MetaDslx.CodeAnalysis.Accessibility DeclaredAccessibility => ((DeclarationSymbol)__Wrapped).DeclaredAccessibility;
        public bool IsStatic => ((DeclarationSymbol)__Wrapped).IsStatic;
        public bool IsExtern => ((DeclarationSymbol)__Wrapped).IsExtern;
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> TypeArguments => ((DeclarationSymbol)__Wrapped).TypeArguments;
        public global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Imports => ((DeclarationSymbol)__Wrapped).Imports;
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Members => ((DeclarationSymbol)__Wrapped).Members;


        public virtual global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return default;
        }

        public virtual bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return default;
        }

        public virtual bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return default;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return global::System.Collections.Immutable.ImmutableArray<ImportSymbol>.Empty;
        }

        public abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
