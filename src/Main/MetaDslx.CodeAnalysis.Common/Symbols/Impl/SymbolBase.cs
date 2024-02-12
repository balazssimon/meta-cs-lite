using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.CodeAnalysis.Symbols.Source;
using Roslyn.Utilities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System;
using MetaDslx.CodeAnalysis.Text;
using System.Xml.Linq;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;

namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;

    internal abstract class SymbolBase : Symbol
    {
        /// <summary>
        /// This field keeps track of the <see cref="CompletionPart"/>s for which we already retrieved
        /// diagnostics. We shouldn't return from ForceComplete (i.e. indicate that diagnostics are
        /// available) until this is equal to <see cref="CompletionPart.All"/>, except that when completing
        /// with a given position, we might not complete <see cref="CompletionPart"/>.Member*.
        /// 
        /// Since completeParts is used as a flag indicating completion of other assignments 
        /// it must be volatile to ensure the read is not reordered/optimized to happen 
        /// before the writes.
        /// </summary>
        private volatile int _completeParts;

        private Symbol _container;
        private ImmutableArray<Symbol> _containedSymbols;

        private object? _wrapped;

        private static ConditionalWeakTable<Symbol, DiagnosticBag> s_diagnostics = new ConditionalWeakTable<Symbol, DiagnosticBag>();
        private static ConditionalWeakTable<Symbol, string> s_names = new ConditionalWeakTable<Symbol, string>();
        private static ConditionalWeakTable<Symbol, string> s_metadataNames = new ConditionalWeakTable<Symbol, string>();
        private static ConditionalWeakTable<Symbol, object> s_attributes = new ConditionalWeakTable<Symbol, object>();
        private static ConditionalWeakTable<Symbol, MergedDeclaration> s_declarations = new ConditionalWeakTable<Symbol, MergedDeclaration>();

        protected SymbolBase()
        {
            _completeParts = -1;
            _container = null;
        }

        protected SymbolBase(Symbol container)
        {
            _completeParts = -1;
            _container = container;
        }

        protected SymbolBase(Symbol container, string? name, string? metadataName, ImmutableArray<AttributeSymbol> attributes)
        {
            _completeParts = -1;
            _container = container;
            _containedSymbols = ImmutableArray<Symbol>.Empty;
            if (!string.IsNullOrEmpty(name))
            {
                s_names.Add(this, name);
            }
            if (!string.IsNullOrEmpty(metadataName) && metadataName != name)
            {
                s_metadataNames.Add(this, metadataName);
            }
            if (!attributes.IsDefaultOrEmpty)
            {
                s_attributes.Add(this, attributes);
            }
            NotePartComplete(CompletionGraph.ContainedSymbolsCompleted);
        }

        protected SymbolBase(Symbol container, MergedDeclaration declaration, IModelObject modelObject) 
            : this(container)
        {
            _wrapped = modelObject;
            s_declarations.Add(this, declaration);
        }

        protected SymbolBase(Symbol container, IModelObject modelObject)
            : this(container)
        {
            _wrapped = modelObject;
        }

        protected SymbolBase(Symbol container, __ISymbol csharpSymbol)
            : this(container)
        {
            _wrapped = csharpSymbol;
        }

        protected SymbolBase(Symbol container, ErrorSymbolInfo errorInfo)
            : this(container)
        {
            _wrapped = errorInfo;
        }

        protected SymbolBase(Symbol container, MergedDeclaration declaration, IModelObject modelObject, string? name, string? metadataName, ImmutableArray<AttributeSymbol> attributes)
            : this(container, name, metadataName, attributes)
        {
            _wrapped = modelObject;
            s_declarations.Add(this, declaration);
        }

        protected SymbolBase(Symbol container, IModelObject modelObject, string? name, string? metadataName, ImmutableArray<AttributeSymbol> attributes)
            : this(container, name, metadataName, attributes)
        {
            _wrapped = modelObject;
        }

        protected SymbolBase(Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, ImmutableArray<AttributeSymbol> attributes)
            : this(container, name, metadataName, attributes)
        {
            _wrapped = csharpSymbol;
        }

        protected SymbolBase(Symbol container, ErrorSymbolInfo errorInfo, string? name, string? metadataName, ImmutableArray<AttributeSymbol> attributes)
            : this(container, name, metadataName, attributes)
        {
            _wrapped = errorInfo;
        }

        protected static void __InitInstance(SymbolBase impl, Symbol wrapped)
        {
            var ws = (SymbolBase)wrapped;
            impl._container = ws._container;
            impl._wrapped = ws._wrapped is Symbol wss ? wss : wrapped;
        }

        protected void __ClearInstance()
        {
            _wrapped = null;
        }

        protected SymbolBase? __WrappedInstance => _wrapped as SymbolBase;

        /// <summary>
        /// Returns true if the symbol could not be resolved, 
        /// and this symbol serves as a placeholder, instead.
        /// </summary>
        public bool IsErrorSymbol => _wrapped is ErrorSymbolInfo;
        public bool IsSourceSymbol => s_declarations.TryGetValue(this, out _);
        public bool IsModelSymbol => _wrapped is IModelObject;
        public bool IsCSharpSymbol => _wrapped is __ISymbol;

        /// <summary>
        /// Returns true if this symbol was automatically created by the compiler, and does not
        /// have an explicit corresponding source code declaration.  
        /// 
        /// This is intended for symbols that are ordinary symbols in the language sense,
        /// and may be used by code, but that are simply declared implicitly rather than
        /// with explicit language syntax.
        /// 
        /// Examples include (this list is not exhaustive):
        ///   the default constructor for a class or struct that is created if one is not provided,
        ///   the BeginInvoke/Invoke/EndInvoke methods for a delegate,
        ///   the generated backing field for an auto property or a field-like event,
        ///   the "this" parameter for non-static methods,
        ///   the "value" parameter for a property setter,
        ///   the parameters on indexer accessor methods (not on the indexer itself),
        ///   methods in anonymous types,
        ///   anonymous functions
        /// </summary>
        public virtual bool IsImplicitlyDeclared => false;

        /// <summary>
        /// Get the symbol that directly contains this symbol. 
        /// </summary>
        public Symbol ContainingSymbol => _container;

        /// <summary>
        /// Get the symbols that are directly contained by this symbol. 
        /// </summary>
        public ImmutableArray<Symbol> ContainedSymbols
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.ContainedSymbols;
                this.ForceComplete(CompletionGraph.FinishCreatingContainedSymbols, null, default);
                return _containedSymbols;
            }
        }

        public virtual string Kind
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.Kind;
                var typeName = this.GetType().Name;
                if (typeName.EndsWith("SymbolBase") || typeName.EndsWith("SymbolImpl")) typeName = typeName.Substring(0, typeName.Length - 10);
                return typeName;
            }
        }

        public virtual string DisplayKind
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.DisplayKind;
                var kind = this.Kind;
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                foreach (var ch in kind)
                {
                    if (ch >= 'A' && ch <= 'Z')
                    {
                        if (sb.Length > 0) sb.Append(' ');
                        sb.Append(char.ToLower(ch));
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                }
                if (this is IModelSymbol modelSymbol)
                {
                    sb.Append("[");
                    sb.Append(modelSymbol.ModelObjectType?.Name);
                    sb.Append("]");
                }
                return builder.ToStringAndFree();
            }
        }

        /// <summary>
        /// Gets the name of this symbol. Symbols without a name return the empty string; 
        /// null is never returned.
        /// </summary>
        public string Name
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.Name;
                this.ForceComplete(CompletionGraph.FinishInitializing, null, default);
                if (s_names.TryGetValue(this, out var name))
                {
                    return name;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Gets the name of a symbol as it appears in metadata. Most of the time, this
        /// is the same as the Name property, with the following exceptions:
        /// 1) The metadata name of generic types includes the "`1", "`2" etc. suffix that
        /// indicates the number of type parameters (it does not include, however, names of
        /// containing types or namespaces).
        /// 2) The metadata name of explicit interface names have spaces removed, compared to
        /// the name property.
        /// </summary>
        public string MetadataName
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.MetadataName;
                this.ForceComplete(CompletionGraph.FinishInitializing, null, default);
                if (s_metadataNames.TryGetValue(this, out var metadataName))
                {
                    return metadataName;
                }
                else
                {
                    return this.Name;
                }
            }
        }

        /// <summary>
        /// Should the name returned by Name property be mangled with any suffix in order to get metadata name.
        /// </summary>
        public bool MangleName => this.Name != this.MetadataName;

        [ModelProperty]
        public ImmutableArray<AttributeSymbol> Attributes
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.Attributes;
                this.ForceComplete(Symbol.CompletionParts.Finish_Attributes, null, default);
                if (s_attributes.TryGetValue(this, out var attributes))
                {
                    return (ImmutableArray<AttributeSymbol>)attributes;
                }
                else
                {
                    return ImmutableArray<AttributeSymbol>.Empty;
                }
            }
        }

        /// <summary>
        /// Returns the assembly containing this symbol. If this symbol is shared across multiple
        /// assemblies, or doesn't belong to an assembly, returns null.
        /// </summary>
        public virtual AssemblySymbol? ContainingAssembly
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.ContainingAssembly;
                // Default implementation gets the container's assembly.
                var container = this.ContainingSymbol;
                return container?.ContainingAssembly;
            }
        }

        /// <summary>
        /// For a source assembly, the associated compilation.
        /// For any other assembly, null.
        /// For a source module and modules from embedded references, 
        /// the DeclaringCompilation of the associated source assembly.
        /// For any other module, null.
        /// For any other symbol, the DeclaringCompilation of the associated module.
        /// </summary>
        /// <remarks>
        /// We're going through the containing module, rather than the containing assembly,
        /// because of /addmodule (symbols in such modules should return null).
        /// 
        /// Remarks, not "ContainingCompilation" because it isn't transitive.
        /// </remarks>
        public virtual Compilation? DeclaringCompilation
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.DeclaringCompilation;
                if (this.IsErrorSymbol) return null;
                if (this is AssemblySymbol)
                {
                    Debug.Assert(!this.IsSourceSymbol, "SourceAssemblySymbol must override DeclaringCompilation");
                }
                if (this is ModuleSymbol)
                {
                    Debug.Assert(!this.IsSourceSymbol, "SourceModuleSymbol must override DeclaringCompilation");
                }
                return this.ContainingModule.DeclaringCompilation;
            }
        }

        /// <summary>
        /// Returns the module containing this symbol. If this symbol is shared across multiple
        /// modules, or doesn't belong to a module, returns null.
        /// </summary>
        public virtual ModuleSymbol? ContainingModule
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.ContainingModule;
                // Default implementation gets the container's module.
                var container = this.ContainingSymbol;
                if (container is ModuleSymbol moduleSymbol) return moduleSymbol;
                return container?.ContainingModule;
            }
        }

        /// <summary>
        /// Returns the nearest lexically enclosing named declaration, or null if there is none.
        /// </summary>
        public virtual DeclarationSymbol? ContainingDeclaration
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.ContainingDeclaration;
                Symbol container = this.ContainingSymbol;
                while (container is not null)
                {
                    if (container is DeclarationSymbol result)
                    {
                        return result;
                    }
                    container = container.ContainingSymbol;
                }
                return null;
            }
        }

        /// <summary>
        /// Returns the nearest lexically enclosing named type, or null if there is none.
        /// </summary>
        public virtual TypeSymbol? ContainingType
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.ContainingType;
                Symbol container = this.ContainingSymbol;
                while (container is not null)
                {
                    if (container is TypeSymbol result)
                    {
                        return result;
                    }
                    container = container.ContainingSymbol;
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the nearest enclosing namespace for this symbol. For a nested type,
        /// returns the namespace that contains its container.
        /// </summary>
        public virtual NamespaceSymbol? ContainingNamespace
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.ContainingNamespace;
                Symbol container = this.ContainingSymbol;
                while (container is not null)
                {
                    if (container is NamespaceSymbol result)
                    {
                        return result;
                    }
                    container = container.ContainingSymbol;
                }
                return null;
            }
        }

        /// <summary>
        /// <para>
        /// Get a source location key for sorting. For performance, it's important that this
        /// be able to be returned from a symbol without doing any additional allocations (even
        /// if nothing is cached yet.)
        /// </para>
        /// <para>
        /// Only (original) source symbols and namespaces that can be merged
        /// need implement this function if they want to do so for efficiency.
        /// </para>
        /// </summary>
        public virtual LexicalSortKey GetLexicalSortKey()
        {
            if (_wrapped is Symbol ws) return ws.GetLexicalSortKey();
            var declaringCompilation = this.DeclaringCompilation;
            if (declaringCompilation is null) return LexicalSortKey.NotInSource;
            var sourceLocation = this.Locations.OfType<SourceLocation>().FirstOrDefault();
            if (sourceLocation is null) return LexicalSortKey.NotInSource;
            else return new LexicalSortKey(sourceLocation, declaringCompilation);
        }

        public MergedDeclaration? MergedDeclaration
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.MergedDeclaration;
                if (s_declarations.TryGetValue(this, out var decl)) return decl;
                else return null;
            }
        }

        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences
        {
            get
            {
                return MergedDeclaration?.SyntaxReferences ?? ImmutableArray<SyntaxNodeOrToken>.Empty;
            }
        }

        /// <summary>
        /// Gets the locations where this symbol was originally defined, either in source or
        /// metadata. Some symbols (for example, partial classes) may be defined in more than one
        /// location.
        /// </summary>
        public virtual ImmutableArray<Location> Locations
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.Locations;
                return MergedDeclaration?.NameLocations.Cast<SourceLocation, Location>() ?? this.ContainingModule?.Locations ?? ImmutableArray<Location>.Empty;
            }
        }

        public Location Location => Locations.FirstOrDefault() ?? Location.None;

        public IModelObject? ModelObject
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.ModelObject;
                return _wrapped as IModelObject;
            }
        }

        public Type? ModelObjectType
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.ModelObjectType;
                var decl = MergedDeclaration;
                if (decl is not null) return decl.ModelObjectType;
                if (_wrapped is IModelObject mobj) return mobj.MInfo.MetaType.AsType();
                return null;
            }
        }

        public __ISymbol? CSharpSymbol
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.CSharpSymbol;
                return _wrapped as __ISymbol;
            }
        }

        #region Diagnostics

        public ImmutableArray<Diagnostic> Diagnostics
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.Diagnostics;
                if (s_diagnostics.TryGetValue(this, out var diagnostics)) return diagnostics.ToReadOnly();
                else return ImmutableArray<Diagnostic>.Empty;
            }
        }

        public bool HasAnyErrors
        {
            get
            {
                if (_wrapped is Symbol ws) return ws.HasAnyErrors;
                if (s_diagnostics.TryGetValue(this, out var diagnostics)) return diagnostics.HasAnyErrors();
                else return false;
            }
        }

        protected bool AddSymbolDiagnostics(Diagnostic diagnostic)
        {
            if (_wrapped is SymbolBase ws) return ws.AddSymbolDiagnostics(diagnostic);
            if (diagnostic is not null)
            {
                var symbolDiagnostics = s_diagnostics.GetOrCreateValue(this);
                symbolDiagnostics.Add(diagnostic);
                return true;
            }
            return false;
        }

        protected bool AddSymbolDiagnostics(DiagnosticBag diagnostics)
        {
            if (_wrapped is SymbolBase ws) return ws.AddSymbolDiagnostics(diagnostics);
            if (!diagnostics.IsEmptyWithoutResolution)
            {
                var symbolDiagnostics = s_diagnostics.GetOrCreateValue(this);
                symbolDiagnostics.AddRange(diagnostics);
                return true;
            }
            return false;
        }

        protected bool AddSymbolDiagnostics(HashSet<DiagnosticInfo>? diagnostics)
        {
            if (_wrapped is SymbolBase ws) return ws.AddSymbolDiagnostics(diagnostics);
            if (diagnostics is not null && diagnostics.Count > 0)
            {
                var symbolDiagnostics = s_diagnostics.GetOrCreateValue(this);
                symbolDiagnostics.AddRange(diagnostics.Select(diag => Diagnostic.Create(diag, this.Locations.FirstOrNone())));
                return true;
            }
            return false;
        }

        #endregion

        #region Use-Site Diagnostics

        /// <summary>
        /// True if the symbol has a use-site diagnostic with error severity.
        /// </summary>
        internal bool HasUseSiteError
        {
            get
            {
                if (_wrapped is SymbolBase ws) return ws.HasUseSiteError;
                var diagnostic = GetUseSiteDiagnostic();
                return diagnostic != null && diagnostic.Severity == DiagnosticSeverity.Error;
            }
        }

        /// <summary>
        /// Returns diagnostic info that should be reported at the use site of the symbol, or null if there is none.
        /// </summary>
        public virtual DiagnosticInfo GetUseSiteDiagnostic()
        {
            if (_wrapped is SymbolBase ws) return ws.GetUseSiteDiagnostic();
            return null;
        }

        /// <summary>
        /// Return error code that has highest priority while calculating use site error for this symbol. 
        /// </summary>
        protected virtual DiagnosticDescriptor HighestPriorityUseSiteError => null;

        /// <summary>
        /// Indicates that this symbol uses metadata that cannot be supported by the language.
        /// 
        /// Examples include:
        ///    - Pointer types in VB
        ///    - ByRef return type
        ///    - Required custom modifiers
        ///    
        /// This is distinguished from, for example, references to metadata symbols defined in assemblies that weren't referenced.
        /// Symbols where this returns true can never be used successfully, and thus should never appear in any IDE feature.
        /// 
        /// This is set for metadata symbols, as follows:
        /// Type - if a type is unsupported (e.g., a pointer type, etc.)
        /// Method - parameter or return type is unsupported
        /// Field - type is unsupported
        /// Event - type is unsupported
        /// Property - type is unsupported
        /// Parameter - type is unsupported
        /// </summary>
        public virtual bool HasUnsupportedMetadata => false;

        /// <summary>
        /// Merges given diagnostic to the existing result diagnostic.
        /// </summary>
        internal bool MergeUseSiteDiagnostics(ref DiagnosticInfo result, DiagnosticInfo info)
        {
            if (_wrapped is SymbolBase ws) return ws.MergeUseSiteDiagnostics(ref result, info);

            if (info == null)
            {
                return false;
            }

            if (info.Severity == DiagnosticSeverity.Error && (info.Descriptor == HighestPriorityUseSiteError || HighestPriorityUseSiteError == null))
            {
                // this error is final, no other error can override it:
                result = info;
                return true;
            }

            if (result == null || result.Severity == DiagnosticSeverity.Warning && info.Severity == DiagnosticSeverity.Error)
            {
                // there could be an error of higher-priority
                result = info;
                return false;
            }

            // we have a second low-pri error, continue looking for a higher priority one
            return false;
        }

        /// <summary>
        /// Reports specified use-site diagnostic to given diagnostic bag. 
        /// </summary>
        /// <remarks>
        /// This method should be the only method adding use-site diagnostics to a diagnostic bag. 
        /// It performs additional adjustments of the location for unification related diagnostics and 
        /// may be the place where to add more use-site location post-processing.
        /// </remarks>
        /// <returns>True if the diagnostic has error severity.</returns>
        internal static bool ReportUseSiteDiagnostic(DiagnosticInfo info, DiagnosticBag diagnostics, Location location)
        {
            diagnostics.Add(Diagnostic.Create(info, location));
            return info.Severity == DiagnosticSeverity.Error;
        }

        #endregion

        /// <summary>
        /// Returns a string representation of this symbol, suitable for debugging purposes, or
        /// for placing in an error message.
        /// </summary>
        public override string ToString()
        {
            if (_wrapped is SymbolBase ws) return ws.ToString();
            return SymbolDisplayFormat.Default.ToString(this);
        }

        /// <summary>
        /// Returns the Documentation Comment ID for the symbol, or null if the symbol doesn't
        /// support documentation comments.
        /// </summary>
        public virtual string GetDocumentationCommentId()
        {
            if (_wrapped is SymbolBase ws) return ws.GetDocumentationCommentId();
            return "";
        }

        /// <summary>
        /// Fetches the documentation comment for this element with a cancellation token.
        /// </summary>
        /// <param name="preferredCulture">Optionally, retrieve the comments formatted for a particular culture. No impact on source documentation comments.</param>
        /// <param name="expandIncludes">Optionally, expand <![CDATA[<include>]]> elements. No impact on non-source documentation comments.</param>
        /// <param name="cancellationToken">Optionally, allow cancellation of documentation comment retrieval.</param>
        /// <returns>The XML that would be written to the documentation file for the symbol.</returns>
        public virtual string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
        {
            if (_wrapped is SymbolBase ws) return ws.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
            return "";
        }

        #region Completion graph

        protected virtual CompletionGraph CompletionGraph
        {
            get
            {
                if (_wrapped is SymbolBase ws) return ws.CompletionGraph;
                return Symbol.CompletionParts.CompletionGraph;
            }
        }

        public virtual void ForceComplete(CompletionPart completionPart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (_wrapped is SymbolBase ws)
            {
                ws.ForceComplete(completionPart, locationOpt, cancellationToken);
                return;
            }
            if (completionPart != null && HasComplete(completionPart)) return;
            if (completionPart != null && !CompletionGraph.Contains(completionPart)) throw new ArgumentException(nameof(completionPart));
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var incompletePart = NextIncompletePart;
                if (incompletePart == CompletionGraph.StartInitializing || incompletePart == CompletionGraph.FinishInitializing)
                {
                    if (NotePartComplete(CompletionGraph.StartInitializing))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        CompletePart_Initialize(diagnostics, cancellationToken);
                        var name = Complete_Name(diagnostics, cancellationToken);
                        var metadataName = Complete_MetadataName(diagnostics, cancellationToken);
                        if (!string.IsNullOrEmpty(name))
                        {
                            s_names.Add(this, name);
                            var mobj = this.ModelObject;
                            if (mobj is not null) mobj.MName = name;
                        }
                        if (!string.IsNullOrEmpty(metadataName) && metadataName != name)
                        {
                            s_metadataNames.Add(this, metadataName);
                        }
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        NotePartComplete(CompletionGraph.FinishInitializing);
                    }
                }
                else if (incompletePart == CompletionGraph.StartCreatingContainedSymbols || incompletePart == CompletionGraph.FinishCreatingContainedSymbols)
                {
                    if (NotePartComplete(CompletionGraph.StartCreatingContainedSymbols))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        _containedSymbols = CompletePart_CreateContainedSymbols(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        NotePartComplete(CompletionGraph.FinishCreatingContainedSymbols);
                    }
                }
                else if (incompletePart == CompletionGraph.ContainedSymbolsFinalized)
                {
                    bool allCompleted = true;
                    if (locationOpt == null)
                    {
                        foreach (var child in _containedSymbols)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                            child.ForceComplete(CompletionGraph.FinishFinalizing, locationOpt, cancellationToken);
                        }
                    }
                    else
                    {
                        foreach (var child in _containedSymbols)
                        {
                            ForceCompleteChildByLocation(CompletionGraph.FinishFinalizing, locationOpt, child, cancellationToken);
                            allCompleted = allCompleted && child.HasComplete(CompletionGraph.FinishFinalizing);
                        }
                    }
                    if (!allCompleted)
                    {
                        // We did not complete all members, so just kick out now.
                        var allParts = CompletionGraph.AllPartsBeforeContainedSymbolsFinalized;
                        SpinWaitComplete(allParts, cancellationToken);
                        return;
                    }
                    // We've completed all members, proceed to the next iteration.
                    NotePartComplete(CompletionGraph.ContainedSymbolsFinalized);
                }
                else if (incompletePart == CompletionGraph.StartFinalizing || incompletePart == CompletionGraph.FinishFinalizing)
                {
                    if (NotePartComplete(CompletionGraph.StartFinalizing))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        CompletePart_Finalize(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        NotePartComplete(CompletionGraph.FinishFinalizing);
                    }
                }
                else if (incompletePart == CompletionGraph.ContainedSymbolsCompleted)
                {
                    bool allCompleted = true;
                    if (locationOpt == null)
                    {
                        foreach (var child in _containedSymbols)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                            child.ForceComplete(null, locationOpt, cancellationToken);
                        }
                    }
                    else
                    {
                        foreach (var child in _containedSymbols)
                        {
                            ForceCompleteChildByLocation(null, locationOpt, child, cancellationToken);
                            allCompleted = allCompleted && child.HasComplete(CompletionGraph.All);
                        }
                    }
                    if (!allCompleted)
                    {
                        // We did not complete all members, so just kick out now.
                        var allParts = CompletionGraph.AllPartsBeforeContainedSymbolsCompleted;
                        SpinWaitComplete(allParts, cancellationToken);
                        return;
                    }
                    // We've completed all members, proceed to the next iteration.
                    NotePartComplete(CompletionGraph.ContainedSymbolsCompleted);
                }
                else if (incompletePart == CompletionGraph.StartValidating || incompletePart == CompletionGraph.FinishValidating)
                {
                    _container?.ForceComplete(CompletionGraph.ContainedSymbolsFinalized, locationOpt, cancellationToken);
                    if (NotePartComplete(CompletionGraph.StartValidating))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        CompletePart_Validate(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        NotePartComplete(CompletionGraph.FinishValidating);
                    }
                }
                else if (incompletePart == CompletionGraph.StartComputingNonSymbolProperties || incompletePart == CompletionGraph.FinishComputingNonSymbolProperties)
                {
                    if (NotePartComplete(CompletionGraph.StartComputingNonSymbolProperties))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        NotePartComplete(CompletionGraph.FinishComputingNonSymbolProperties);
                    }
                }
                else if (ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
                {
                    // incompletePart was handled by ForceCompletePart()
                }
                else if (incompletePart == null)
                {
                    // if the next incompletePart is null, it means we have completed everything
                    return;
                }
                else
                {
                    // This assert will trigger if we forgot to handle any of the completion parts
                    Debug.Assert(!CompletionGraph.Contains(incompletePart));
                    // any other values are completion parts intended for other kinds of symbols
                    NotePartComplete(incompletePart);
                }
                if (completionPart != null && HasComplete(completionPart)) return;
                SpinWaitComplete(incompletePart, cancellationToken);
            }
            throw ExceptionUtilities.Unreachable;
        }

        public bool HasComplete(CompletionPart part)
        {
            return CompletionGraph.HasComplete(part, _completeParts);
        }

        protected bool NotePartComplete(CompletionPart part)
        {
            if (_wrapped is SymbolBase ws) return ws.NotePartComplete(part);
            // passing volatile completeParts byref is ok here.
            // ThreadSafeFlagOperations.Set performs interlocked assignments
            int index = CompletionGraph.IndexOf(part);
            if (index <= _completeParts) return false;
            int oldIndex = _completeParts;
            return Interlocked.CompareExchange(ref _completeParts, index, oldIndex) == oldIndex;
        }

        /// <summary>
        /// Produce the next (i.e. lowest) CompletionPart (bit) that is not set.
        /// </summary>
        protected CompletionPart NextIncompletePart
        {
            get
            {
                // NOTE: It's very important to store this value in a local.
                // If we were to inline the field access, the value of the
                // field could change between the two accesses and the formula
                // might not produce a result with a single 1-bit.
                return CompletionGraph.NextIncompletePart(_completeParts);
            }
        }

        private void SpinWaitComplete(CompletionPart part, CancellationToken cancellationToken)
        {
            if (HasComplete(part))
            {
                return;
            }

            // Don't return until we've seen all of the requested CompletionParts. This ensures all
            // diagnostics have been reported (not necessarily on this thread).
            var spinWait = new SpinWait();
            while (!HasComplete(part))
            {
                cancellationToken.ThrowIfCancellationRequested();
                spinWait.SpinOnce();
            }
        }

        private void SpinWaitComplete(IEnumerable<CompletionPart> parts, CancellationToken cancellationToken)
        {
            if (!parts.Any()) return;
            int index = parts.Select(p => CompletionGraph.IndexOf(p)).Max();
            if (index < 0) return;
            CompletionPart part = CompletionGraph.Parts[index];
            this.SpinWaitComplete(part, cancellationToken);
        }

        protected virtual bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == Symbol.CompletionParts.Start_Attributes || incompletePart == Symbol.CompletionParts.Finish_Attributes)
            {
                if (NotePartComplete(Symbol.CompletionParts.Start_Attributes))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var attributes = Complete_Attributes(diagnostics, cancellationToken);
                    if (!attributes.IsDefaultOrEmpty)
                    {
                        s_attributes.Add(this, attributes);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(Symbol.CompletionParts.Finish_Attributes);
                }
                return true;
            }
            return false;
        }


        internal bool IsFromCompilation(Compilation compilation)
        {
            Debug.Assert(compilation != null);
            return compilation == this.DeclaringCompilation;
        }

        public virtual ImmutableArray<SingleDeclaration> GetSingleDeclarations(CancellationToken cancellationToken = default)
        {
            if (this is ISourceSymbol sourceSymbol) return sourceSymbol.Declaration.Declarations;
            else return ImmutableArray<SingleDeclaration>.Empty;
        }

        public ImmutableArray<SingleDeclaration> GetSingleDeclarations(SyntaxNodeOrToken syntax, CancellationToken cancellationToken = default)
        {
            var result = ArrayBuilder<SingleDeclaration>.GetInstance();
            foreach (var decl in this.GetSingleDeclarations(cancellationToken))
            {
                if (decl.SyntaxReference == syntax) result.Add(decl);
            }
            return result.ToImmutableAndFree();
        }

        public bool IsDefinedInSourceTree(SyntaxTree tree, TextSpan? definedWithinSpan, CancellationToken cancellationToken = default)
        {
            foreach (var decl in this.GetSingleDeclarations(cancellationToken))
            {
                var syntaxRef = decl.SyntaxReference;
                if (syntaxRef.SyntaxTree == tree &&
                    (!definedWithinSpan.HasValue || syntaxRef.Span.IntersectsWith(definedWithinSpan.Value)))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsDefinedBySyntax(SyntaxNodeOrToken syntax, CancellationToken cancellationToken = default)
        {
            foreach (var decl in this.GetSingleDeclarations(cancellationToken))
            {
                var syntaxRef = decl.SyntaxReference;
                if (syntaxRef == syntax)
                {
                    return true;
                }
            }
            return false;
        }

        public static void ForceCompleteChildByLocation(CompletionPart part, SourceLocation locationOpt, Symbol member, CancellationToken cancellationToken)
        {
            if (locationOpt == null || member.IsDefinedInSourceTree(locationOpt.SourceTree, locationOpt.SourceSpan, cancellationToken))
            {
                cancellationToken.ThrowIfCancellationRequested();
                member.ForceComplete(part, locationOpt, cancellationToken);
            }
        }

        protected virtual void CompletePart_Initialize(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
        }

        protected virtual string? Complete_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return null;
        }

        protected virtual string? Complete_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return null;
        }

        protected virtual ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<Symbol>.Empty;
        }

        protected virtual ImmutableArray<AttributeSymbol> Complete_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<AttributeSymbol>.Empty;
        }

        protected virtual void CompletePart_ComputeNonSymbolProperties(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
        }

        protected virtual void CompletePart_Finalize(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
        }

        protected virtual void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
        }

        #endregion
    }
}
