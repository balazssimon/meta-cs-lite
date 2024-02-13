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
using System.Collections.Concurrent;

namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;

    public abstract class SymbolInst : SymbolBase
    {
        internal static readonly ConditionalWeakTable<Symbol, DiagnosticBag> s_diagnostics = new ConditionalWeakTable<Symbol, DiagnosticBag>();
        internal static readonly ConditionalWeakTable<Symbol, DiagnosticBag> s_useSiteDiagnostics = new ConditionalWeakTable<Symbol, DiagnosticBag>();
        internal static readonly ConditionalWeakTable<Symbol, string> s_names = new ConditionalWeakTable<Symbol, string>();
        internal static readonly ConditionalWeakTable<Symbol, string> s_metadataNames = new ConditionalWeakTable<Symbol, string>();
        internal static readonly ConditionalWeakTable<Symbol, object> s_attributes = new ConditionalWeakTable<Symbol, object>();
        internal static readonly ConditionalWeakTable<Symbol, MergedDeclaration> s_declarations = new ConditionalWeakTable<Symbol, MergedDeclaration>();
        internal static readonly ConditionalWeakTable<Symbol, Compilation> s_compilations = new ConditionalWeakTable<Symbol, Compilation>();

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

        private readonly Symbol _container;
        private ImmutableArray<Symbol> _containedSymbols;

        internal readonly object? _underlyingObject;

        protected SymbolInst()
        {
            _completeParts = -1;
            _container = null;
        }

        protected SymbolInst(Symbol container)
        {
            _completeParts = -1;
            _container = container;
        }

        protected SymbolInst(Symbol container, string? name, string? metadataName, ImmutableArray<AttributeSymbol> attributes)
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

        protected SymbolInst(Symbol container, MergedDeclaration declaration, IModelObject modelObject) 
            : this(container)
        {
            _underlyingObject = modelObject;
            s_declarations.Add(this, declaration);
        }

        protected SymbolInst(Symbol container, IModelObject modelObject)
            : this(container)
        {
            _underlyingObject = modelObject;
        }

        protected SymbolInst(Symbol container, __ISymbol csharpSymbol)
            : this(container)
        {
            _underlyingObject = csharpSymbol;
        }

        protected SymbolInst(Symbol container, ErrorSymbolInfo errorInfo)
            : this(container)
        {
            _underlyingObject = errorInfo;
        }

        protected SymbolInst(Symbol container, MergedDeclaration declaration, IModelObject modelObject, string? name, string? metadataName, ImmutableArray<AttributeSymbol> attributes)
            : this(container, name, metadataName, attributes)
        {
            _underlyingObject = modelObject;
            s_declarations.Add(this, declaration);
        }

        protected SymbolInst(Symbol container, IModelObject modelObject, string? name, string? metadataName, ImmutableArray<AttributeSymbol> attributes)
            : this(container, name, metadataName, attributes)
        {
            _underlyingObject = modelObject;
        }

        protected SymbolInst(Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, ImmutableArray<AttributeSymbol> attributes)
            : this(container, name, metadataName, attributes)
        {
            _underlyingObject = csharpSymbol;
        }

        protected SymbolInst(Symbol container, Compilation compilation, IModelObject? modelObject, string? name, string? metadataName, ImmutableArray<AttributeSymbol> attributes)
            : this(container, name, metadataName, attributes)
        {
            _underlyingObject = modelObject;
            s_compilations.Add(this, compilation);
        }

        public sealed override bool IsErrorSymbol => _underlyingObject is ErrorSymbolInfo;
        public sealed override bool IsSourceSymbol => s_declarations.TryGetValue(this, out _) || s_compilations.TryGetValue(this, out _);
        public sealed override bool IsModelSymbol => _underlyingObject is IModelObject;
        public sealed override bool IsCSharpSymbol => _underlyingObject is __ISymbol;

        public sealed override bool IsImplicitlyDeclared => s_compilations.TryGetValue(this, out _);

        public sealed override Symbol ContainingSymbol => _container;

        public sealed override ImmutableArray<Symbol> ContainedSymbols
        {
            get
            {
                this.ForceComplete(CompletionGraph.FinishCreatingContainedSymbols, null, default);
                return _containedSymbols;
            }
        }

        public sealed override string Kind
        {
            get
            {
                var typeName = this.GetType().Name;
                if (typeName.EndsWith("SymbolInst") || typeName.EndsWith("SymbolImpl")) typeName = typeName.Substring(0, typeName.Length - 10);
                if (string.IsNullOrEmpty(typeName)) return "Symbol";
                return typeName;
            }
        }

        public sealed override string DisplayKind
        {
            get
            {
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
                var mobjType = this.ModelObjectType;
                if (mobjType is not null)
                {
                    sb.Append(" (");
                    sb.Append(mobjType.Name);
                    sb.Append(")");
                }
                return builder.ToStringAndFree();
            }
        }

        public sealed override string Name
        {
            get
            {
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

        public sealed override string MetadataName
        {
            get
            {
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

        public sealed override bool MangleName => this.Name != this.MetadataName;

        public sealed override ImmutableArray<AttributeSymbol> Attributes
        {
            get
            {
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
        public override AssemblySymbol? ContainingAssembly
        {
            get
            {
                var impl = SymbolImpl.GetInstance(this);
                var result = impl.ContainingAssembly;
                impl.Free();
                return result;
            }
        }

        public override Compilation? DeclaringCompilation
        {
            get
            {
                var impl = SymbolImpl.GetInstance(this);
                var result = impl.DeclaringCompilation;
                impl.Free();
                return result;
            }
        }

        public override ModuleSymbol? ContainingModule
        {
            get
            {
                var impl = SymbolImpl.GetInstance(this);
                var result = impl.ContainingModule;
                impl.Free();
                return result;
            }
        }

        public override DeclarationSymbol? ContainingDeclaration
        {
            get
            {
                var impl = SymbolImpl.GetInstance(this);
                var result = impl.ContainingDeclaration;
                impl.Free();
                return result;
            }
        }

        public override TypeSymbol? ContainingType
        {
            get
            {
                var impl = SymbolImpl.GetInstance(this);
                var result = impl.ContainingType;
                impl.Free();
                return result;
            }
        }

        public override NamespaceSymbol? ContainingNamespace
        {
            get
            {
                var impl = SymbolImpl.GetInstance(this);
                var result = impl.ContainingNamespace;
                impl.Free();
                return result;
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
        public override LexicalSortKey GetLexicalSortKey()
        {
            var impl = SymbolImpl.GetInstance(this);
            var result = impl.GetLexicalSortKey();
            impl.Free();
            return result;
        }

        public sealed override MergedDeclaration? MergedDeclaration
        {
            get
            {
                if (s_declarations.TryGetValue(this, out var decl)) return decl;
                else return null;
            }
        }

        public sealed override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences
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
        public sealed override ImmutableArray<Location> Locations
        {
            get
            {
                return MergedDeclaration?.NameLocations.Cast<SourceLocation, Location>() ?? this.ContainingModule?.Locations ?? ImmutableArray<Location>.Empty;
            }
        }

        public sealed override Location Location => Locations.FirstOrDefault() ?? Location.None;

        public sealed override IModelObject? ModelObject => _underlyingObject as IModelObject;

        public sealed override Type? ModelObjectType
        {
            get
            {
                var decl = MergedDeclaration;
                if (decl is not null) return decl.ModelObjectType;
                if (_underlyingObject is IModelObject mobj) return mobj.MInfo.MetaType.AsType();
                return null;
            }
        }

        public sealed override __ISymbol? CSharpSymbol => _underlyingObject as __ISymbol;

        #region Diagnostics

        public sealed override ImmutableArray<Diagnostic> Diagnostics
        {
            get
            {
                if (s_diagnostics.TryGetValue(this, out var diagnostics)) return diagnostics.ToReadOnly();
                else return ImmutableArray<Diagnostic>.Empty;
            }
        }

        public sealed override bool HasAnyErrors
        {
            get
            {
                if (s_diagnostics.TryGetValue(this, out var diagnostics)) return diagnostics.HasAnyErrors();
                else return false;
            }
        }

        protected bool AddSymbolDiagnostics(Diagnostic diagnostic)
        {
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

        protected bool AddUseSiteDiagnostics(Diagnostic diagnostic)
        {
            if (diagnostic is not null)
            {
                var symbolDiagnostics = s_useSiteDiagnostics.GetOrCreateValue(this);
                symbolDiagnostics.Add(diagnostic);
                return true;
            }
            return false;
        }

        protected bool AddUseSiteDiagnostics(DiagnosticBag diagnostics)
        {
            if (!diagnostics.IsEmptyWithoutResolution)
            {
                var symbolDiagnostics = s_useSiteDiagnostics.GetOrCreateValue(this);
                symbolDiagnostics.AddRange(diagnostics);
                return true;
            }
            return false;
        }

        protected bool AddUseSiteDiagnostics(HashSet<DiagnosticInfo>? diagnostics)
        {
            if (diagnostics is not null && diagnostics.Count > 0)
            {
                var symbolDiagnostics = s_useSiteDiagnostics.GetOrCreateValue(this);
                symbolDiagnostics.AddRange(diagnostics.Select(diag => Diagnostic.Create(diag, this.Locations.FirstOrNone())));
                return true;
            }
            return false;
        }

        /// <summary>
        /// True if the symbol has a use-site diagnostic with error severity.
        /// </summary>
        public sealed override bool HasUseSiteError
        {
            get
            {
                if (s_useSiteDiagnostics.TryGetValue(this, out var diagnostics))
                {
                    return diagnostics.HasAnyErrors();
                }
                return false;
            }
        }

        /// <summary>
        /// Returns diagnostic info that should be reported at the use site of the symbol, or null if there is none.
        /// </summary>
        public virtual DiagnosticInfo GetUseSiteDiagnostic()
        {
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
        public override bool HasUnsupportedMetadata
        {
            get
            {
                var impl = SymbolImpl.GetInstance(this);
                var result = impl.HasUnsupportedMetadata;
                impl.Free();
                return result;
            }
        }

        /// <summary>
        /// Merges given diagnostic to the existing result diagnostic.
        /// </summary>
        internal bool MergeUseSiteDiagnostics(ref DiagnosticInfo result, DiagnosticInfo info)
        {
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
        public sealed override string ToString()
        {
            return SymbolDisplayFormat.Default.ToString(this);
        }

        /// <summary>
        /// Returns the Documentation Comment ID for the symbol, or null if the symbol doesn't
        /// support documentation comments.
        /// </summary>
        public override string GetDocumentationCommentId()
        {
            var impl = SymbolImpl.GetInstance(this);
            var result = impl.GetDocumentationCommentId();
            impl.Free();
            return result;
        }

        /// <summary>
        /// Fetches the documentation comment for this element with a cancellation token.
        /// </summary>
        /// <param name="preferredCulture">Optionally, retrieve the comments formatted for a particular culture. No impact on source documentation comments.</param>
        /// <param name="expandIncludes">Optionally, expand <![CDATA[<include>]]> elements. No impact on non-source documentation comments.</param>
        /// <param name="cancellationToken">Optionally, allow cancellation of documentation comment retrieval.</param>
        /// <returns>The XML that would be written to the documentation file for the symbol.</returns>
        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
        {
            var impl = SymbolImpl.GetInstance(this);
            var result = impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
            impl.Free();
            return result;
        }

        #region Completion graph

        protected virtual CompletionGraph CompletionGraph => Symbol.CompletionParts.CompletionGraph;

        public sealed override void ForceComplete(CompletionPart completionPart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
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

        public sealed override bool HasComplete(CompletionPart part)
        {
            return CompletionGraph.HasComplete(part, _completeParts);
        }

        protected bool NotePartComplete(CompletionPart part)
        {
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

        public sealed override bool IsFromCompilation(Compilation compilation)
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

        public sealed override bool IsDefinedInSourceTree(SyntaxTree tree, TextSpan? definedWithinSpan, CancellationToken cancellationToken = default)
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

        public sealed override bool IsDefinedBySyntax(SyntaxNodeOrToken syntax, CancellationToken cancellationToken = default)
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

        private void CompletePart_Initialize(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var impl = SymbolImpl.GetInstance(this);
            impl.CompletePart_Initialize(diagnostics, cancellationToken);
            impl.Free();
        }

        private string? Complete_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var impl = SymbolImpl.GetInstance(this);
            var result = impl.Complete_Name(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private string? Complete_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var impl = SymbolImpl.GetInstance(this);
            var result = impl.Complete_MetadataName(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var impl = SymbolImpl.GetInstance(this);
            var result = impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private ImmutableArray<AttributeSymbol> Complete_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var impl = SymbolImpl.GetInstance(this);
            var result = impl.Complete_Attributes(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private void CompletePart_ComputeNonSymbolProperties(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var impl = SymbolImpl.GetInstance(this);
            impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken);
            impl.Free();
        }

        private void CompletePart_Finalize(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var impl = SymbolImpl.GetInstance(this);
            impl.CompletePart_Finalize(diagnostics, cancellationToken);
            impl.Free();
        }

        private void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var impl = SymbolImpl.GetInstance(this);
            impl.CompletePart_Validate(diagnostics, cancellationToken);
            impl.Free();
        }

        #endregion
    }
}
