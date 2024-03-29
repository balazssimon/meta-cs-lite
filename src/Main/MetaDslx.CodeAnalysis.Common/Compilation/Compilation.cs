using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Declarations;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System.Threading;
using MetaDslx.CodeAnalysis.PooledObjects;
using System.Collections.Generic;
using System.Collections.Immutable;
using Roslyn.Utilities;
using System.Xml.Linq;
using MetaDslx.CodeAnalysis.Symbols;
using System.Linq;
using Microsoft.CodeAnalysis;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.Source;
using Autofac;
using MetaDslx.CodeAnalysis.Symbols.Errors;
using MetaDslx.CodeAnalysis.Binding.Lookup;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis.Symbols.Model;

namespace MetaDslx.CodeAnalysis
{
    using CSharpCompilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation;

    public partial class Compilation : IDisposable
    {
        private readonly SyntaxAndDeclarationManager _syntaxAndDeclarations;

        // When building symbols from the declaration table (lazily), or inside a type, or when
        // compiling a method body, we may not have a Binder in hand for the enclosing
        // scopes.  Therefore, we build them when needed (and cache them) using a BinderFactory.
        // Since a BinderFactory is only a cache, and the identity of the BinderFactories and
        // Binder have no semantic meaning, we can reuse them or rebuild them, whichever is
        // most convenient. We store them using weak references so that GC pressure will cause them
        // to be recycled.
        private WeakReference<BinderFactory>[]? _binderFactories;
        private WeakReference<BinderFactory>[]? _ignoreAccessibilityBinderFactories;

        private readonly string? _assemblyName;
        private readonly CompilationFactory _compilationFactory;
        private readonly ImmutableArray<Language> _languages;
        private readonly CompilationOptions _options;
        private readonly ImmutableArray<MetadataReference> _externalReferences;
        private readonly ScriptCompilationInfo? _scriptCompilationInfo;

        private ContainerBuilder _containerBuilder;
        private IContainer _serviceProvider;

        private CSharpCompilation _initialCompilation;
        internal ReferenceManager _referenceManager;
        internal AssemblySymbol? _lazyAssemblySymbol;

        private BuckStopsHereBinder? _buckStopsHereBinder;
        private DiagnosticBag? _binderDiagnostics;

        private AccessCheck? _accessCheck;
        private DefaultLookupValidator? _defaultLookupValidator;
        private SymbolValueConverter? _symbolValueConverter;

        private ImmutableArray<Diagnostic> _diagnostics;
        private ImmutableArray<Diagnostic> _parseDiagnostics;
        private ImmutableArray<Diagnostic> _declarationDiagnostics;
        private ImmutableArray<Diagnostic> _validationDiagnostics;
        private ImmutableArray<Diagnostic> _emitDiagnostics;
        private ImmutableArray<Diagnostic> _buildDiagnostics;

        internal protected Compilation(
            string? assemblyName,
            CompilationFactory compilationFactory,
            CompilationOptions options,
            CSharpCompilation? initialCompilation,
            ImmutableArray<MetadataReference> references,
            ScriptCompilationInfo? scriptCompilationInfo,
            ReferenceManager? referenceManager, 
            bool reuseReferenceManager,
            SyntaxAndDeclarationManager syntaxAndDeclarations)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));
            if (references.IsDefault) throw new ArgumentNullException(nameof(references));
            Debug.Assert(scriptCompilationInfo is not null || options.ReferencesSupersedeLowerVersions);

            _compilationFactory = compilationFactory;

            _containerBuilder = new ContainerBuilder();
            _containerBuilder.RegisterInstance<Compilation>(this).SingleInstance();

            _assemblyName = assemblyName;

            var languagesBuilder = ArrayBuilder<Language>.GetInstance();
            foreach (var language in syntaxAndDeclarations.ExternalSyntaxTrees.Select(st => st.Language).Distinct().OrderBy(l => l.Name))
            {
                if (!languagesBuilder.Contains(language)) languagesBuilder.Add(language);
            }
            _languages = languagesBuilder.ToImmutableAndFree();

            _options = options;
            _initialCompilation = initialCompilation;
            _externalReferences = references;
            _scriptCompilationInfo = scriptCompilationInfo;
            _lazySubmissionSlotIndex = scriptCompilationInfo is not null ? SubmissionSlotIndexToBeAllocated : SubmissionSlotIndexNotApplicable;

            Debug.Assert(_scriptCompilationInfo?.PreviousSubmission is null || _scriptCompilationInfo.PreviousSubmission.HostObjectType == _scriptCompilationInfo.HostObjectType);

            //_scriptClass = new Lazy<ScriptSymbol?>(BindScriptClass);
            //_globalImports = new Lazy<Imports>(BindGlobalImports);
            //_previousSubmissionImports = new Lazy<Imports>(ExpandPreviousSubmissionImports);
            //_globalNamespaceAlias = new Lazy<AliasSymbol>(CreateGlobalNamespaceAlias);
            //_anonymousTypeManager = new AnonymousTypeManager(this);

            if (reuseReferenceManager)
            {
                if (referenceManager is null)
                {
                    throw new ArgumentNullException(nameof(referenceManager));
                }
            
                referenceManager.AssertCanReuseForCompilation(this);
                _referenceManager = referenceManager;
                _containerBuilder.RegisterInstance<ReferenceManager>(_referenceManager).SingleInstance();
            }
            else
            {
                _referenceManager = new ReferenceManager();
                _referenceManager._simpleAssemblyName = assemblyName;
                _containerBuilder.RegisterInstance<ReferenceManager>(_referenceManager).SingleInstance();
            }

            _syntaxAndDeclarations = syntaxAndDeclarations;

            RegisterServicesCore();
            _serviceProvider = _containerBuilder.Build();

            Debug.Assert(_lazyAssemblySymbol is null);
            //if (EventQueue != null) EventQueue.TryEnqueue(new CompilationStartedEvent(this));
        }

        public void Dispose()
        {

        }

        private void RegisterServicesCore()
        {
            RegisterServices();
            TryRegister<AccessCheck, AccessCheck>();
            TryRegister<ModelSymbolFactory, ModelSymbolFactory>();
            TryRegister<SourceSymbolFactory, SourceSymbolFactory>();
            TryRegister<ErrorSymbolFactory, ErrorSymbolFactory>();
            TryRegister<CSharpSymbolFactory, CSharpSymbolFactory>();
            TryRegister<SymbolValueConverter, SymbolValueConverter>();
            TryRegister<DefaultLookupValidator, DefaultLookupValidator>();
        }

        protected virtual void RegisterServices()
        {
        }

        protected void Register<TService, TCustomService>() where TCustomService : class, TService
        {
            _containerBuilder.RegisterType<TCustomService>().As<TService>().SingleInstance();
        }

        protected void TryRegister<TService, TCustomService>() where TCustomService : class, TService
        {
            _containerBuilder.RegisterType<TCustomService>().As<TService>().SingleInstance().IfNotRegistered(typeof(TService));
        }

        public string? Name => _assemblyName;
        public IContainer ServiceProvider => _serviceProvider;
        public CompilationFactory CompilationFactory => _compilationFactory;
        public ImmutableArray<Language> Languages => _languages;
        public CompilationOptions Options => _options;
        public ScriptCompilationInfo? ScriptCompilationInfo => _scriptCompilationInfo;
        public ReferenceManager ReferenceManager => _referenceManager;
        public ImmutableArray<MetadataReference> ExternalReferences => _externalReferences;

        protected virtual Compilation Update(
            string? assemblyName,
            CompilationFactory compilationFactory,
            CompilationOptions options,
            CSharpCompilation? initialCompilation,
            ImmutableArray<MetadataReference> externalReferences,
            ScriptCompilationInfo? scriptCompilationInfo,
            ReferenceManager? referenceManager,
            bool reuseReferenceManager,
            SyntaxAndDeclarationManager syntaxAndDeclarations)
        {
            return compilationFactory.CreateCompilation(assemblyName, compilationFactory, options, initialCompilation, externalReferences, scriptCompilationInfo,
                    referenceManager, reuseReferenceManager, syntaxAndDeclarations);
        }

        public static Compilation Create(
            string? assemblyName = null,
            CompilationFactory? compilationFactory = null,
            Language? mainLanguage = null,
            IEnumerable<SyntaxTree>? syntaxTrees = null,
            CSharpCompilation? initialCompilation = null,
            IEnumerable<MetadataReference>? references = null, 
            CompilationOptions? options = null)
        {
            var factory = compilationFactory ?? (mainLanguage ?? Language.NoLanguage).CompilationFactory;
            var externalReferences = references is null ? ImmutableArray<MetadataReference>.Empty : references.ToImmutableArray();
            var externalSyntaxTrees = syntaxTrees is null ? ImmutableArray<SyntaxTree>.Empty : syntaxTrees.ToImmutableArray();
            var declarationManager = new SyntaxAndDeclarationManager(externalSyntaxTrees, null, null, false, null);
            return factory.CreateCompilation(assemblyName, factory, options ?? CompilationOptions.Default, initialCompilation, externalReferences, null, null, false, declarationManager);
        }

        public static Compilation CreateScriptCompilation(
            string assemblyName,
            CompilationFactory? compilationFactory = null,
            Language? mainLanguage = null,
            SyntaxTree? syntaxTree = null,
            CSharpCompilation? initialCompilation = null,
            IEnumerable<MetadataReference>? references = null,
            CompilationOptions? options = null,
            Compilation? previousScriptCompilation = null,
            Type? returnType = null,
            Type? globalsType = null)
        {
            var factory = compilationFactory ?? (mainLanguage ?? Language.NoLanguage).CompilationFactory;
            var externalReferences = references is null ? ImmutableArray<MetadataReference>.Empty : references.ToImmutableArray();
            var externalSyntaxTrees = syntaxTree is null ? ImmutableArray<SyntaxTree>.Empty : ImmutableArray.Create(syntaxTree);
            var declarationManager = new SyntaxAndDeclarationManager(externalSyntaxTrees, null, null, false, null);
            var scriptCompilationInfo = new ScriptCompilationInfo(previousScriptCompilation, returnType, globalsType);
            return factory.CreateCompilation(assemblyName, factory, options ?? CompilationOptions.Default, initialCompilation, externalReferences, scriptCompilationInfo, null, false, declarationManager);
        }

        internal int CompareSourceLocations(Location location1, Location location2)
        {
            Debug.Assert(location1.Kind == LocationKind.SourceFile);
            Debug.Assert(location2.Kind == LocationKind.SourceFile);
            if (location1 is SourceLocation sloc1 && location2 is SourceLocation sloc2)
            {
                var comparison = CompareSyntaxTreeOrdering(sloc1.SourceTree!, sloc2.SourceTree!);
                if (comparison != 0)
                {
                    return comparison;
                }
                return sloc1.SourceSpan.Start - sloc2.SourceSpan.Start;
            }
            return 0;
        }

        internal int CompareSourceLocations(SyntaxReference location1, SyntaxReference location2)
        {
            var comparison = CompareSyntaxTreeOrdering(location1.SyntaxTree, location2.SyntaxTree);
            if (comparison != 0)
            {
                return comparison;
            }

            return location1.Span.Start - location2.Span.Start;
        }

        internal int CompareSourceLocations(SyntaxNodeOrToken location1, SyntaxNodeOrToken location2)
        {
            var comparison = CompareSyntaxTreeOrdering(location1.SyntaxTree, location2.SyntaxTree);
            if (comparison != 0)
            {
                return comparison;
            }

            return location1.Span.Start - location2.Span.Start;
        }


        #region Submissions

        // An index in the submission slot array. Allocated lazily in compilation phase based upon the slot index of the previous submission.
        // Special values:
        // -1 ... neither this nor previous submissions in the chain allocated a slot (the submissions don't contain code)
        // -2 ... the slot of this submission hasn't been determined yet
        // -3 ... this is not a submission compilation
        private int _lazySubmissionSlotIndex;
        private const int SubmissionSlotIndexNotApplicable = -3;
        private const int SubmissionSlotIndexToBeAllocated = -2;

        /// <summary>
        /// True if the compilation represents an interactive submission.
        /// </summary>
        internal bool IsSubmission
        {
            get
            {
                return _lazySubmissionSlotIndex != SubmissionSlotIndexNotApplicable;
            }
        }

        /// <summary>
        /// The previous submission, if any, or null.
        /// </summary>
        private Compilation? PreviousSubmission
        {
            get
            {
                return ScriptCompilationInfo?.PreviousSubmission;
            }
        }

        /// <summary>
        /// Gets or allocates a runtime submission slot index for this compilation.
        /// </summary>
        /// <returns>Non-negative integer if this is a submission and it or a previous submission contains code, negative integer otherwise.</returns>
        internal int GetSubmissionSlotIndex()
        {
            if (_lazySubmissionSlotIndex == SubmissionSlotIndexToBeAllocated)
            {
                // TODO (tomat): remove recursion
                int lastSlotIndex = ScriptCompilationInfo!.PreviousSubmission?.GetSubmissionSlotIndex() ?? 0;
                _lazySubmissionSlotIndex = HasCodeToEmit() ? lastSlotIndex + 1 : lastSlotIndex;
            }

            return _lazySubmissionSlotIndex;
        }

        // The type of interactive submission result requested by the host, or null if this compilation doesn't represent a submission.
        //
        // The type is resolved to a symbol when the Script's instance ctor symbol is constructed. The symbol needs to be resolved against
        // the references of this compilation.
        //
        // Consider (tomat): As an alternative to Reflection Type we could hold onto any piece of information that lets us
        // resolve the type symbol when needed.

        /// <summary>
        /// The type object that represents the type of submission result the host requested.
        /// </summary>
        internal Type? SubmissionReturnType => ScriptCompilationInfo?.SubmissionReturnType;

        internal static bool IsValidSubmissionReturnType(Type type)
        {
            var info = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
            return !(type == typeof(void) || type.IsByRef || info.ContainsGenericParameters);
        }

        /// <summary>
        /// The type of the globals object or null if not specified for this compilation.
        /// </summary>
        internal Type? HostObjectType => ScriptCompilationInfo?.HostObjectType;

        internal static bool IsValidHostObjectType(Type type)
        {
            var info = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
            return !(info.IsValueType || info.IsPointer || info.IsByRef || info.ContainsGenericParameters);
        }

        public Compilation WithScriptCompilationInfo(ScriptCompilationInfo? info)
        {
            return this.Update(_assemblyName, _compilationFactory, _options, _initialCompilation, _externalReferences, info, _referenceManager, true, _syntaxAndDeclarations);
        }

        #endregion

        #region Syntax Trees (maintain an ordered list)

        /// <summary>
        /// The syntax trees (parsed from source code) that this compilation was created with.
        /// </summary>
        public ImmutableArray<SyntaxTree> SyntaxTrees
        {
            get { return _syntaxAndDeclarations.GetLazyState(this).SyntaxTrees; }
        }

        /// <summary>
        /// Returns true if this compilation contains the specified tree.  False otherwise.
        /// </summary>
        public bool ContainsSyntaxTree(SyntaxTree? syntaxTree)
        {
            return syntaxTree != null && _syntaxAndDeclarations.GetLazyState(this).RootNamespaces.ContainsKey(syntaxTree);
        }

        /// <summary>
        /// Creates a new compilation with additional syntax trees.
        /// </summary>
        public Compilation AddSyntaxTrees(params SyntaxTree[] trees)
        {
            return AddSyntaxTrees((IEnumerable<SyntaxTree>)trees);
        }

        /// <summary>
        /// Creates a new compilation with additional syntax trees.
        /// </summary>
        public Compilation AddSyntaxTrees(IEnumerable<SyntaxTree> trees)
        {
            if (trees == null)
            {
                throw new ArgumentNullException(nameof(trees));
            }

            if (trees.IsEmpty())
            {
                return this;
            }

            // This HashSet is needed so that we don't allow adding the same tree twice
            // with a single call to AddSyntaxTrees.  Rather than using a separate HashSet,
            // ReplaceSyntaxTrees can just check against ExternalSyntaxTrees, because we
            // only allow replacing a single tree at a time.
            var externalSyntaxTrees = PooledHashSet<SyntaxTree>.GetInstance();
            var syntaxAndDeclarations = _syntaxAndDeclarations;
            externalSyntaxTrees.AddAll(syntaxAndDeclarations.ExternalSyntaxTrees);
            bool reuseReferenceManager = true;
            int i = 0;
            foreach (var tree in trees)
            {
                if (tree == null)
                {
                    throw new ArgumentNullException($"{nameof(trees)}[{i}]");
                }

                if (!tree.HasCompilationUnitRoot)
                {
                    throw new ArgumentException("tree must have a root node with SyntaxKind.CompilationUnit", $"{nameof(trees)}[{i}]");
                }

                if (externalSyntaxTrees.Contains(tree))
                {
                    throw new ArgumentException("Syntax tree already present", $"{nameof(trees)}[{i}]");
                }

                if (this.IsSubmission && tree.Options.Kind == SourceCodeKind.Regular)
                {
                    throw new ArgumentException("Submission can only include script code.", $"{nameof(trees)}[{i}]");
                }

                externalSyntaxTrees.Add(tree);
                reuseReferenceManager &= !tree.HasReferenceOrLoadDirectives;

                i++;
            }
            externalSyntaxTrees.Free();

            if (this.IsSubmission && i > 1)
            {
                throw new ArgumentException("Submission can have at most one syntax tree.", nameof(trees));
            }

            syntaxAndDeclarations = syntaxAndDeclarations.AddSyntaxTrees(trees);

            return Update(_assemblyName, _compilationFactory, _options, _initialCompilation, _externalReferences, _scriptCompilationInfo, _referenceManager, reuseReferenceManager, syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation without the specified syntax trees. Preserves metadata info for use with trees
        /// added later.
        /// </summary>
        public Compilation RemoveSyntaxTrees(params SyntaxTree[] trees)
        {
            return RemoveSyntaxTrees((IEnumerable<SyntaxTree>)trees);
        }

        /// <summary>
        /// Creates a new compilation without the specified syntax trees. Preserves metadata info for use with trees
        /// added later.
        /// </summary>
        public Compilation RemoveSyntaxTrees(IEnumerable<SyntaxTree> trees)
        {
            if (trees == null)
            {
                throw new ArgumentNullException(nameof(trees));
            }

            if (trees.IsEmpty())
            {
                return this;
            }

            var removeSet = PooledHashSet<SyntaxTree>.GetInstance();
            // This HashSet is needed so that we don't allow adding the same tree twice
            // with a single call to AddSyntaxTrees.  Rather than using a separate HashSet,
            // ReplaceSyntaxTrees can just check against ExternalSyntaxTrees, because we
            // only allow replacing a single tree at a time.
            var externalSyntaxTrees = PooledHashSet<SyntaxTree>.GetInstance();
            var syntaxAndDeclarations = _syntaxAndDeclarations;
            externalSyntaxTrees.AddAll(syntaxAndDeclarations.ExternalSyntaxTrees);
            bool reuseReferenceManager = true;
            int i = 0;
            foreach (var tree in trees)
            {
                if (!externalSyntaxTrees.Contains(tree))
                {
                    // Check to make sure this is not a #load'ed tree.
                    var loadedSyntaxTreeMap = syntaxAndDeclarations.GetLazyState(this).LoadedSyntaxTreeMap;
                    if (SyntaxAndDeclarationManager.IsLoadedSyntaxTree(tree, loadedSyntaxTreeMap))
                    {
                        throw new ArgumentException("SyntaxTree resulted from a #load directive and cannot be removed or replaced directly.", $"{nameof(trees)}[{i}]");
                    }

                    throw new ArgumentException("SyntaxTree is not part of the compilation, so it cannot be removed", $"{nameof(trees)}[{i}]");
                }

                removeSet.Add(tree);
                reuseReferenceManager &= !tree.HasReferenceOrLoadDirectives;

                i++;
            }
            externalSyntaxTrees.Free();

            syntaxAndDeclarations = syntaxAndDeclarations.RemoveSyntaxTrees(removeSet);
            removeSet.Free();

            return Update(_assemblyName, _compilationFactory, _options, _initialCompilation, _externalReferences, _scriptCompilationInfo, _referenceManager,
                reuseReferenceManager, syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation without any syntax trees. Preserves metadata info
        /// from this compilation for use with trees added later.
        /// </summary>
        public Compilation RemoveAllSyntaxTrees()
        {
            var syntaxAndDeclarations = _syntaxAndDeclarations;
            return Update(_assemblyName, _compilationFactory, _options, _initialCompilation, _externalReferences, _scriptCompilationInfo, _referenceManager,
                reuseReferenceManager: !syntaxAndDeclarations.MayHaveReferenceDirectives(),
                syntaxAndDeclarations: syntaxAndDeclarations.WithExternalSyntaxTrees(ImmutableArray<SyntaxTree>.Empty));
        }

        /// <summary>
        /// Creates a new compilation without the old tree but with the new tree.
        /// </summary>
        public Compilation ReplaceSyntaxTree(SyntaxTree oldTree, SyntaxTree? newTree)
        {
            if (oldTree == null)
            {
                throw new ArgumentNullException(nameof(oldTree));
            }

            if (newTree == null)
            {
                return this.RemoveSyntaxTrees(oldTree);
            }
            else if (newTree == oldTree)
            {
                return this;
            }

            if (!newTree.HasCompilationUnitRoot)
            {
                throw new ArgumentException("tree must have a root node with SyntaxKind.CompilationUnit", nameof(newTree));
            }

            var syntaxAndDeclarations = _syntaxAndDeclarations;
            var externalSyntaxTrees = syntaxAndDeclarations.ExternalSyntaxTrees;
            if (!externalSyntaxTrees.Contains(oldTree))
            {
                // Check to see if this is a #load'ed tree.
                var loadedSyntaxTreeMap = syntaxAndDeclarations.GetLazyState(this).LoadedSyntaxTreeMap;
                if (SyntaxAndDeclarationManager.IsLoadedSyntaxTree(oldTree, loadedSyntaxTreeMap))
                {
                    throw new ArgumentException("SyntaxTree resulted from a #load directive and cannot be removed or replaced directly.", nameof(oldTree));
                }

                throw new ArgumentException("SyntaxTree is not part of the compilation, so it cannot be removed", nameof(oldTree));
            }

            if (externalSyntaxTrees.Contains(newTree))
            {
                throw new ArgumentException("Syntax tree already present", nameof(newTree));
            }

            // TODO(tomat): Consider comparing #r's of the old and the new tree. If they are exactly the same we could still reuse.
            // This could be a perf win when editing a script file in the IDE. The services create a new compilation every keystroke
            // that replaces the tree with a new one.
            // https://github.com/dotnet/roslyn/issues/43397
            var reuseReferenceManager = !oldTree.HasReferenceOrLoadDirectives && !newTree.HasReferenceOrLoadDirectives;
            syntaxAndDeclarations = syntaxAndDeclarations.ReplaceSyntaxTree(oldTree, newTree);

            return Update(_assemblyName, _compilationFactory, _options, _initialCompilation, _externalReferences, _scriptCompilationInfo, _referenceManager,
                reuseReferenceManager, syntaxAndDeclarations);
        }

        internal int GetSyntaxTreeOrdinal(SyntaxTree tree)
        {
            Debug.Assert(this.ContainsSyntaxTree(tree));
            return _syntaxAndDeclarations.GetLazyState(this).OrdinalMap[tree];
        }

        /// <summary>
        /// The compiler needs to define an ordering among different partial class in different syntax trees
        /// in some cases, because emit order for fields in structures, for example, is semantically important.
        /// This function defines an ordering among syntax trees in this compilation.
        /// </summary>
        internal int CompareSyntaxTreeOrdering(SyntaxTree tree1, SyntaxTree tree2)
        {
            if (tree1 == tree2)
            {
                return 0;
            }
            if (tree1 == null) return -1;
            if (tree2 == null) return 1;

            Debug.Assert(this.ContainsSyntaxTree(tree1));
            Debug.Assert(this.ContainsSyntaxTree(tree2));

            return this.GetSyntaxTreeOrdinal(tree1) - this.GetSyntaxTreeOrdinal(tree2);
        }

        #endregion

        #region References

        // TODO

        internal ReferenceManager GetBoundReferenceManager()
        {
            if (_lazyAssemblySymbol is null)
            {
                _referenceManager.CreateSourceAssemblyForCompilation(this, _initialCompilation);
                Debug.Assert(_lazyAssemblySymbol is object);
            }

            // referenceManager can only be accessed after we initialized the lazyAssemblySymbol.
            // In fact, initialization of the assembly symbol might change the reference manager.
            return _referenceManager;
        }

        public Compilation WithInitialCompilation(CSharpCompilation? initialCompilation)
        {
            if (initialCompilation == _initialCompilation) return this;
            return this.Update(_assemblyName, _compilationFactory, _options, initialCompilation, _externalReferences, _scriptCompilationInfo,
                _referenceManager, false, _syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation with additional metadata references.
        /// </summary>
        public Compilation AddReferences(params MetadataReference[] references)
        {
            if (references.Length == 0) return this;
            return this.Update(_assemblyName, _compilationFactory, _options, _initialCompilation, _externalReferences.AddRange(references), _scriptCompilationInfo,
                _referenceManager, false, _syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation with additional metadata references.
        /// </summary>
        public Compilation AddReferences(IEnumerable<MetadataReference> references)
        {
            if (!references.Any()) return this;
            return this.Update(_assemblyName, _compilationFactory, _options, _initialCompilation, _externalReferences.AddRange(references), _scriptCompilationInfo,
                _referenceManager, false, _syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation without the specified metadata references.
        /// </summary>
        public Compilation RemoveReferences(params MetadataReference[] references)
        {
            if (references.Length == 0) return this;
            return this.Update(_assemblyName, _compilationFactory, _options, _initialCompilation, _externalReferences.RemoveRange(references), _scriptCompilationInfo,
                _referenceManager, false, _syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation without the specified metadata references.
        /// </summary>
        public Compilation RemoveReferences(IEnumerable<MetadataReference> references)
        {
            if (!references.Any()) return this;
            return this.Update(_assemblyName, _compilationFactory, _options, _initialCompilation, _externalReferences.RemoveRange(references), _scriptCompilationInfo,
                _referenceManager, false, _syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation without any metadata references
        /// </summary>
        public Compilation RemoveAllReferences()
        {
            if (_externalReferences.Length == 0) return this;
            return this.Update(_assemblyName, _compilationFactory, _options, _initialCompilation, ImmutableArray<MetadataReference>.Empty, _scriptCompilationInfo,
                _referenceManager, false, _syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation with an old metadata reference replaced with a new metadata reference.
        /// </summary>
        public Compilation ReplaceReference(MetadataReference oldReference, MetadataReference newReference)
        {
            var builder = ArrayBuilder<MetadataReference>.GetInstance();
            var replaced = false;
            foreach (var oldRef in _externalReferences)
            {
                if (oldRef == oldReference)
                {
                    builder.Add(newReference);
                    replaced = true;
                }
                else
                {
                    builder.Add(oldRef);
                }
            }
            return this.Update(_assemblyName, _compilationFactory, _options, _initialCompilation, builder.ToImmutableAndFree(), _scriptCompilationInfo,
                _referenceManager, !replaced, _syntaxAndDeclarations);
        }

        #endregion


        #region Declarations

        internal protected DeclarationTable DeclarationTable => _syntaxAndDeclarations.GetLazyState(this).DeclarationTable;

        public MergedDeclaration RootDeclaration => DeclarationTable.GetMergedRoot(this);

        #endregion


        #region Binding

        internal DiagnosticBag BinderDiagnostics
        {
            get
            {
                if (_binderDiagnostics is null)
                {
                    Interlocked.CompareExchange(ref _binderDiagnostics, new DiagnosticBag(), null);
                }
                return _binderDiagnostics;
            }
        }

        internal protected BuckStopsHereBinder BuckStopsHereBinder
        {
            get
            {
                if (_buckStopsHereBinder is null)
                {
                    Interlocked.CompareExchange(ref _buckStopsHereBinder, new BuckStopsHereBinder(this), null);
                }
                return _buckStopsHereBinder;
            }
        }

        internal BinderFactory GetBinderFactoryForDeclarationTable(SyntaxTree syntaxTree, int treeNum)
        {
            return GetBinderFactory(syntaxTree, true, treeNum, ref _ignoreAccessibilityBinderFactories);
        }

        public BinderFactory GetBinderFactory(SyntaxTree syntaxTree, bool ignoreAccessibility = false)
        {
            var treeNum = GetSyntaxTreeOrdinal(syntaxTree);
            if (ignoreAccessibility) return GetBinderFactory(syntaxTree, ignoreAccessibility, treeNum, ref _ignoreAccessibilityBinderFactories);
            else return GetBinderFactory(syntaxTree, ignoreAccessibility, treeNum, ref _binderFactories);
        }

        private BinderFactory GetBinderFactory(SyntaxTree syntaxTree, bool ignoreAccessibility, int treeNum, ref WeakReference<BinderFactory>[]? cachedBinderFactories)
        {
            Debug.Assert(System.Runtime.CompilerServices.Unsafe.AreSame(ref cachedBinderFactories, ref ignoreAccessibility ? ref _ignoreAccessibilityBinderFactories : ref _binderFactories));

            WeakReference<BinderFactory>[]? binderFactories = cachedBinderFactories;
            if (binderFactories == null)
            {
                binderFactories = new WeakReference<BinderFactory>[this.SyntaxTrees.Length];
                binderFactories = Interlocked.CompareExchange(ref cachedBinderFactories, binderFactories, null) ?? binderFactories;
            }

            BinderFactory? previousFactory;
            var previousWeakReference = binderFactories[treeNum];
            if (previousWeakReference != null && previousWeakReference.TryGetTarget(out previousFactory))
            {
                return previousFactory;
            }

            return AddNewFactory(syntaxTree, ignoreAccessibility, ref binderFactories[treeNum]);
        }

        private BinderFactory AddNewFactory(SyntaxTree syntaxTree, bool ignoreAccessibility, [NotNull] ref WeakReference<BinderFactory>? slot)
        {
            var newFactory = new BinderFactory(this, syntaxTree);
            var newWeakReference = new WeakReference<BinderFactory>(newFactory);

            while (true)
            {
                BinderFactory? previousFactory;
                WeakReference<BinderFactory>? previousWeakReference = slot;
                if (previousWeakReference != null && previousWeakReference.TryGetTarget(out previousFactory))
                {
                    Debug.Assert(slot is object);
                    return previousFactory;
                }

                if (Interlocked.CompareExchange(ref slot!, newWeakReference, previousWeakReference) == previousWeakReference)
                {
                    return newFactory;
                }
            }
        }

        public RootBinder? GetRootBinder(SyntaxTree syntaxTree)
        {
            var factory = GetBinderFactory(syntaxTree);
            return factory.RootBinder;
        }

        public Binder GetBinder(SyntaxNodeOrToken syntax)
        {
            var factory = GetBinderFactory(syntax.SyntaxTree);
            return factory.GetBinder(syntax);
        }

        public Binder GetEnclosingBinder(SyntaxNodeOrToken syntax)
        {
            var factory = GetBinderFactory(syntax.SyntaxTree);
            return factory.GetEnclosingBinder(syntax);
        }

        public Binder GetEnclosingBinder(SyntaxTree syntaxTree, TextSpan span)
        {
            var factory = GetBinderFactory(syntaxTree);
            return factory.GetEnclosingBinder(span);
        }

        #endregion

        #region Symbols

        /// <summary>
        /// The AssemblySymbol that represents the assembly being created.
        /// </summary>
        public AssemblySymbol SourceAssembly
        {
            get
            {
                GetBoundReferenceManager();
                Debug.Assert(_lazyAssemblySymbol is object);
                return _lazyAssemblySymbol;
            }
        }

        /// <summary>
        /// Get a ModuleSymbol that refers to the module being created by compiling all of the code.
        /// By getting the GlobalNamespace property of that module, all of the namespaces and types
        /// defined in source code can be obtained.
        /// </summary>
        public ModuleSymbol SourceModule
        {
            get
            {
                return SourceAssembly.Modules[0];
            }
        }

        public NamespaceSymbol GlobalNamespace => SourceAssembly.GlobalNamespace;

        public NamespaceSymbol GetRootNamespace(SyntaxTree syntaxTree)
        {
            return SourceModule.GetRootNamespace(syntaxTree);
        }

        #endregion

        #region Semantic Analysis

        public void Compile(CancellationToken cancellationToken = default)
        {
            this.GetDiagnostics(cancellationToken);
        }

        public ImmutableArray<Diagnostic> GetDiagnostics(CancellationToken cancellationToken = default)
        {
            if (_diagnostics.IsDefault)
            {
                DiagnosticBag? builder = DiagnosticBag.GetInstance();
                this.ForceComplete(CompilationStage.Build, builder, cancellationToken);
                ImmutableInterlocked.InterlockedInitialize(ref _diagnostics, builder.ToReadOnlyAndFree());
            }
            return _diagnostics;
        }

        internal void ForceComplete(CompilationStage stage, DiagnosticBag diagnostics, CancellationToken cancellationToken = default)
        {
            var syntaxTrees = this.SyntaxTrees;
            if (stage >= CompilationStage.Parse)
            {
                if (_parseDiagnostics.IsDefault)
                {
                    DiagnosticBag? builder = DiagnosticBag.GetInstance();
                    if (this.Options.ConcurrentBuild)
                    {
                        RoslynParallel.For(
                            0,
                            syntaxTrees.Length,
                            UICultureUtilities.WithCurrentUICulture<int>(i =>
                            {
                                var syntaxTree = syntaxTrees[i];
                                AppendLoadDirectiveDiagnostics(builder, _syntaxAndDeclarations, syntaxTree);
                                builder.AddRange(syntaxTree.GetDiagnostics(cancellationToken));
                            }),
                            cancellationToken);
                    }
                    else
                    {
                        foreach (var syntaxTree in syntaxTrees)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                            AppendLoadDirectiveDiagnostics(builder, _syntaxAndDeclarations, syntaxTree);

                            cancellationToken.ThrowIfCancellationRequested();
                            builder.AddRange(syntaxTree.GetDiagnostics(cancellationToken));
                        }
                    }
                    var parseOptionsReported = new HashSet<ParseOptions>();
                    foreach (var syntaxTree in syntaxTrees)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        if (!syntaxTree.Options.Errors.IsDefaultOrEmpty && parseOptionsReported.Add(syntaxTree.Options))
                        {
                            var location = syntaxTree.GetLocation(TextSpan.FromBounds(0, 0));
                            foreach (var error in syntaxTree.Options.Errors)
                            {
                                builder.Add(error.WithLocation(location));
                            }
                        }
                    }
                    ImmutableInterlocked.InterlockedInitialize(ref _parseDiagnostics, builder.ToReadOnlyAndFree());
                }
                diagnostics.AddRange(_parseDiagnostics);
            }
            if (stage >= CompilationStage.Declaration)
            {
                if (_declarationDiagnostics.IsDefault)
                {
                    DiagnosticBag? builder = DiagnosticBag.GetInstance();
                    builder.AddRange(Options.Errors);

                    cancellationToken.ThrowIfCancellationRequested();

                    // the set of diagnostics related to establishing references.
                    var csharpDiagnostics = GetBoundReferenceManager().CSharpCompilation.GetDeclarationDiagnostics(cancellationToken);
                    builder.AddRange(csharpDiagnostics.Select(d => d.ToMetaDslx()));

                    cancellationToken.ThrowIfCancellationRequested();

                    ImmutableInterlocked.InterlockedInitialize(ref _declarationDiagnostics, builder.ToReadOnlyAndFree());
                }
                diagnostics.AddRange(_declarationDiagnostics);
            }
            if (stage >= CompilationStage.Validation)
            {
                if (_validationDiagnostics.IsDefault)
                {
                    DiagnosticBag? builder = DiagnosticBag.GetInstance();
                    if (this.Options.ConcurrentBuild)
                    {
                        RoslynParallel.For(
                            0,
                            syntaxTrees.Length,
                            UICultureUtilities.WithCurrentUICulture<int>(i =>
                            {
                                var syntaxTree = syntaxTrees[i];
                                var rootBinder = GetRootBinder(syntaxTree);
                                rootBinder.CompleteBind(resolveLazy: true, cancellationToken);
                            }),
                            cancellationToken);
                    }
                    else
                    {
                        foreach (var syntaxTree in syntaxTrees)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                            var rootBinder = GetRootBinder(syntaxTree);
                            rootBinder.CompleteBind(resolveLazy: true, cancellationToken);
                        }
                    }
                    //this.GlobalNamespace.ForceComplete(null, null, cancellationToken);
                    SourceModule.GlobalNamespace.ForceComplete(null, null, cancellationToken);
                    AppendDiagnosticsForAllSymbols(builder, cancellationToken);
                    ImmutableInterlocked.InterlockedInitialize(ref _validationDiagnostics, builder.ToReadOnlyAndFree());
                }
                diagnostics.AddRange(_validationDiagnostics);
            }
            if (stage >= CompilationStage.Emit)
            {
                if (_emitDiagnostics.IsDefault)
                {
                    DiagnosticBag? builder = DiagnosticBag.GetInstance();
                    ImmutableInterlocked.InterlockedInitialize(ref _emitDiagnostics, builder.ToReadOnlyAndFree());
                }
                diagnostics.AddRange(_emitDiagnostics);
            }
            if (stage >= CompilationStage.Build)
            {
                if (_buildDiagnostics.IsDefault)
                {
                    DiagnosticBag? builder = DiagnosticBag.GetInstance();
                    ImmutableInterlocked.InterlockedInitialize(ref _buildDiagnostics, builder.ToReadOnlyAndFree());
                }
                diagnostics.AddRange(_buildDiagnostics);
            }
        }

        private void AppendLoadDirectiveDiagnostics(DiagnosticBag builder, SyntaxAndDeclarationManager syntaxAndDeclarations, SyntaxTree syntaxTree, Func<IEnumerable<Diagnostic>, IEnumerable<Diagnostic>>? locationFilterOpt = null)
        {
            ImmutableArray<DeclarationLoadDirective> loadDirectives;
            if (syntaxAndDeclarations.GetLazyState(this).LoadDirectiveMap.TryGetValue(syntaxTree, out loadDirectives))
            {
                Debug.Assert(!loadDirectives.IsEmpty);
                foreach (var directive in loadDirectives)
                {
                    IEnumerable<Diagnostic> diagnostics = directive.Diagnostics;
                    if (locationFilterOpt != null)
                    {
                        diagnostics = locationFilterOpt(diagnostics);
                    }
                    builder.AddRange(diagnostics);
                }
            }
        }

        private void AppendDiagnosticsForAllSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            diagnostics.AddRange(SourceAssembly.Diagnostics);
            if (_binderDiagnostics is not null) diagnostics.AddRange(_binderDiagnostics);
            var rootSymbol = SourceModule;
            var queue = new List<Symbol>();
            queue.Add(rootSymbol);
            int index = 0;
            while (index < queue.Count)
            {
                var symbol = queue[index];
                diagnostics.AddRange(symbol.Diagnostics);
                foreach (var child in symbol.ContainedSymbols)
                {
                    if (!queue.Contains(child)) queue.Add(child);
                }
                ++index;
            }
        }

        #endregion

        #region Emit

        public bool HasCodeToEmit()
        {
            GetBoundReferenceManager();
            return true;
        }

        #endregion

        public AccessCheck AccessCheck
        {
            get
            {
                if (_accessCheck is null)
                {
                    var accessCheck = _serviceProvider.Resolve<AccessCheck>();
                    Interlocked.CompareExchange(ref _accessCheck, accessCheck, null);
                }
                return _accessCheck;
            }
        }

        public DefaultLookupValidator DefaultLookupValidator
        {
            get
            {
                if (_defaultLookupValidator is null)
                {
                    var defaultLookupValidator = _serviceProvider.Resolve<DefaultLookupValidator>();
                    Interlocked.CompareExchange(ref _defaultLookupValidator, defaultLookupValidator, null);
                }
                return _defaultLookupValidator;
            }
        }

        public SymbolValueConverter SymbolValueConverter
        {
            get
            {
                if (_symbolValueConverter is null)
                {
                    var symbolValueConverter = _serviceProvider.Resolve<SymbolValueConverter>();
                    Interlocked.CompareExchange(ref _symbolValueConverter, symbolValueConverter, null);
                }
                return _symbolValueConverter;
            }
        }

        public TypeSymbol? ResolveType(string? fullName)
        {
            if (fullName is null) return null;
            var qualifiedName = fullName.Split('.').ToImmutableArray();
            var context = BuckStopsHereBinder.AllocateLookupContext(qualifier: GlobalNamespace, validators: new[] { LookupValidators.TypeOnly });
            var result = BuckStopsHereBinder.BindQualifiedName(context, qualifiedName);
            if (result.Length > 0 && result.Length == qualifiedName.Length) return result[result.Length - 1] as TypeSymbol;
            else return null;
        }

        public Symbol? ResolveModelObject(IModelObject modelObject)
        {
            throw new NotImplementedException();
        }
    }
}