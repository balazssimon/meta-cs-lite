#pragma warning disable CS8669
#pragma warning disable CS0108

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
    public abstract partial class DeclarationSymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts
        {
            public static readonly __CompletionPart Start_DeclaredAccessibility = new __CompletionPart(nameof(Start_DeclaredAccessibility));
            public static readonly __CompletionPart Finish_DeclaredAccessibility = new __CompletionPart(nameof(Finish_DeclaredAccessibility));
            public static readonly __CompletionPart Start_IsStatic = new __CompletionPart(nameof(Start_IsStatic));
            public static readonly __CompletionPart Finish_IsStatic = new __CompletionPart(nameof(Finish_IsStatic));
            public static readonly __CompletionPart Start_IsExtern = new __CompletionPart(nameof(Start_IsExtern));
            public static readonly __CompletionPart Finish_IsExtern = new __CompletionPart(nameof(Finish_IsExtern));
            public static readonly __CompletionPart Start_OriginalDefinition = new __CompletionPart(nameof(Start_OriginalDefinition));
            public static readonly __CompletionPart Finish_OriginalDefinition = new __CompletionPart(nameof(Finish_OriginalDefinition));
            public static readonly __CompletionPart Start_TypeArguments = new __CompletionPart(nameof(Start_TypeArguments));
            public static readonly __CompletionPart Finish_TypeArguments = new __CompletionPart(nameof(Finish_TypeArguments));
            public static readonly __CompletionPart Start_Imports = new __CompletionPart(nameof(Start_Imports));
            public static readonly __CompletionPart Finish_Imports = new __CompletionPart(nameof(Finish_Imports));
            public static readonly __CompletionPart Start_MemberNames = new __CompletionPart(nameof(Start_MemberNames));
            public static readonly __CompletionPart Finish_MemberNames = new __CompletionPart(nameof(Finish_MemberNames));
            public static readonly __CompletionPart Start_Members = new __CompletionPart(nameof(Start_Members));
            public static readonly __CompletionPart Finish_Members = new __CompletionPart(nameof(Finish_Members));
            public static readonly __CompletionPart Start_TypeMembers = new __CompletionPart(nameof(Start_TypeMembers));
            public static readonly __CompletionPart Finish_TypeMembers = new __CompletionPart(nameof(Finish_TypeMembers));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts.CompletionGraph
                    , Start_DeclaredAccessibility, Finish_DeclaredAccessibility
                    , Start_IsStatic, Finish_IsStatic
                    , Start_IsExtern, Finish_IsExtern
                    , Start_OriginalDefinition, Finish_OriginalDefinition
                    , Start_TypeArguments, Finish_TypeArguments
                    , Start_Imports, Finish_Imports
                    , Start_MemberNames, Finish_MemberNames
                    , Start_Members, Finish_Members
                    , Start_TypeMembers, Finish_TypeMembers
                );
        }

        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_DeclaredAccessibility = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private bool _isStatic;
        private bool _isExtern;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, DeclarationSymbol> s_OriginalDefinition = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, DeclarationSymbol>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_TypeArguments = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_Imports = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_MemberNames = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_Members = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_TypeMembers = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>> s_GetMembers1 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>> s_GetMembers2 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>>> s_GetTypeMembers1 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>>> s_GetTypeMembers2 = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>>>();

        public DeclarationSymbol(__Symbol? container, __Compilation? compilation, __MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, __ErrorSymbolInfo? errorInfo) 
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        public override __Type SymbolType => typeof(DeclarationSymbol);
        protected override __CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        [__WeakAttribute]
        public global::MetaDslx.CodeAnalysis.Accessibility DeclaredAccessibility
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_DeclaredAccessibility, null, default);
                if (s_DeclaredAccessibility.TryGetValue(this, out var result)) return (global::MetaDslx.CodeAnalysis.Accessibility)result;
                else return default;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public bool IsStatic
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsStatic, null, default);
                return _isStatic;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public bool IsExtern
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsExtern, null, default);
                return _isExtern;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        [__WeakAttribute]
        public DeclarationSymbol OriginalDefinition
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_OriginalDefinition, null, default);
                if (s_OriginalDefinition.TryGetValue(this, out var result)) return (DeclarationSymbol)result;
                else return default;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        [__WeakAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol> TypeArguments
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_TypeArguments, null, default);
                if (s_TypeArguments.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>.Empty;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        [__WeakAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.ImportSymbol> Imports
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Imports, null, default);
                if (s_Imports.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.ImportSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.ImportSymbol>.Empty;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        [__WeakAttribute]
        public global::System.Collections.Immutable.ImmutableArray<string> MemberNames
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_MemberNames, null, default);
                if (s_MemberNames.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<string>)result;
                else return global::System.Collections.Immutable.ImmutableArray<string>.Empty;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        [__WeakAttribute]
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Members
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Members, null, default);
                if (s_Members.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        [__WeakAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol> TypeMembers
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_TypeMembers, null, default);
                if (s_TypeMembers.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>.Empty;
            }
        }


        [__DerivedAttribute(Cached=true, Condition="MemberNames.Contains(name)")]
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> GetMembers(string name)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
            var __cachedDictionary = s_GetMembers1.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>());
            return __cachedDictionary.GetOrAdd((name), __args => Compute_GetMembers(name));
        }

        protected abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Compute_GetMembers(string name);

        [__DerivedAttribute(Cached=true, Condition="MemberNames.Contains(name)")]
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> GetMembers(string name, string metadataName)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
            var __cachedDictionary = s_GetMembers2.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>>());
            return __cachedDictionary.GetOrAdd((name, metadataName), __args => Compute_GetMembers(name, metadataName));
        }

        protected abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Compute_GetMembers(string name, string metadataName);

        [__DerivedAttribute(Cached=true, Condition="MemberNames.Contains(name)")]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol> GetTypeMembers(string name)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>.Empty;
            var __cachedDictionary = s_GetTypeMembers1.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>>());
            return __cachedDictionary.GetOrAdd((name), __args => Compute_GetTypeMembers(name));
        }

        protected abstract global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol> Compute_GetTypeMembers(string name);

        [__DerivedAttribute(Cached=true, Condition="MemberNames.Contains(name)")]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol> GetTypeMembers(string name, string metadataName)
        {
            if (!(MemberNames.Contains(name))) return global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>.Empty;
            var __cachedDictionary = s_GetTypeMembers2.GetValue(this, __this => new global::System.Collections.Concurrent.ConcurrentDictionary<(string, string), global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>>());
            return __cachedDictionary.GetOrAdd((name, metadataName), __args => Compute_GetTypeMembers(name, metadataName));
        }

        protected abstract global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol> Compute_GetTypeMembers(string name, string metadataName);

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_DeclaredAccessibility || incompletePart == CompletionParts.Finish_DeclaredAccessibility)
            {
                if (NotePartComplete(CompletionParts.Start_DeclaredAccessibility))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_DeclaredAccessibility(diagnostics, cancellationToken);
                    if (result != default)
                    {
                        s_DeclaredAccessibility.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_DeclaredAccessibility);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_IsStatic || incompletePart == CompletionParts.Finish_IsStatic)
            {
                if (NotePartComplete(CompletionParts.Start_IsStatic))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_IsStatic(diagnostics, cancellationToken);
                    _isStatic = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_IsStatic);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_IsExtern || incompletePart == CompletionParts.Finish_IsExtern)
            {
                if (NotePartComplete(CompletionParts.Start_IsExtern))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_IsExtern(diagnostics, cancellationToken);
                    _isExtern = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_IsExtern);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_OriginalDefinition || incompletePart == CompletionParts.Finish_OriginalDefinition)
            {
                if (NotePartComplete(CompletionParts.Start_OriginalDefinition))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_OriginalDefinition(diagnostics, cancellationToken);
                    if (result != default)
                    {
                        s_OriginalDefinition.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_OriginalDefinition);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_TypeArguments || incompletePart == CompletionParts.Finish_TypeArguments)
            {
                if (NotePartComplete(CompletionParts.Start_TypeArguments))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_TypeArguments(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_TypeArguments.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_TypeArguments);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Imports || incompletePart == CompletionParts.Finish_Imports)
            {
                if (NotePartComplete(CompletionParts.Start_Imports))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Imports(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_Imports.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Imports);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_MemberNames || incompletePart == CompletionParts.Finish_MemberNames)
            {
                if (NotePartComplete(CompletionParts.Start_MemberNames))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_MemberNames(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_MemberNames.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_MemberNames);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Members || incompletePart == CompletionParts.Finish_Members)
            {
                if (NotePartComplete(CompletionParts.Start_Members))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Members(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_Members.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Members);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_TypeMembers || incompletePart == CompletionParts.Finish_TypeMembers)
            {
                if (NotePartComplete(CompletionParts.Start_TypeMembers))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_TypeMembers(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_TypeMembers.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_TypeMembers);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected virtual global::MetaDslx.CodeAnalysis.Accessibility Compute_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.CodeAnalysis.Accessibility>(this, nameof(DeclaredAccessibility), diagnostics, cancellationToken);
        }

        protected virtual bool Compute_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsStatic), diagnostics, cancellationToken);
        }

        protected virtual bool Compute_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsExtern), diagnostics, cancellationToken);
        }

        protected virtual DeclarationSymbol Compute_OriginalDefinition(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<DeclarationSymbol>(this, nameof(OriginalDefinition), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol> Compute_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol>(this, nameof(TypeArguments), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.ImportSymbol> Compute_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<global::MetaDslx.CodeAnalysis.Symbols.ImportSymbol>(this, nameof(Imports), diagnostics, cancellationToken);
        }

        protected abstract global::System.Collections.Immutable.ImmutableArray<string> Compute_MemberNames(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Compute_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol> Compute_TypeMembers(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
