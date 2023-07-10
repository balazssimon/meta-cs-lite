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
using System.Reflection;
using MetaDslx.CodeAnalysis.Symbols;
using System.Linq;

namespace MetaDslx.CodeAnalysis
{
    using CSharpCompilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation;
    using MetadataReference = Microsoft.CodeAnalysis.MetadataReference;

    public class Compilation
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

        private readonly string _assemblyName;
        private readonly CompilationOptions _options;
        private readonly ImmutableArray<MetadataReference> _externalReferences;
        private readonly ScriptCompilationInfo? _scriptCompilationInfo;
        private readonly CSharpCompilation _referenceManager;

        private AssemblySymbol? _lazyAssemblySymbol;

        protected Compilation(
            string? assemblyName,
            CompilationOptions options,
            ImmutableArray<MetadataReference> references,
            ScriptCompilationInfo? scriptCompilationInfo,
            CSharpCompilation? referenceManager, 
            bool reuseReferenceManager,
            SyntaxAndDeclarationManager syntaxAndDeclarations)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));
            if (references.IsDefault) throw new ArgumentNullException(nameof(references));
            Debug.Assert(scriptCompilationInfo is not null || options.ReferencesSupersedeLowerVersions);

            _assemblyName = assemblyName;
            _options = options;
            _externalReferences = references;
            _scriptCompilationInfo = scriptCompilationInfo;
            _lazySubmissionSlotIndex = scriptCompilationInfo is not null ? SubmissionSlotIndexToBeAllocated : SubmissionSlotIndexNotApplicable;

            Debug.Assert(_scriptCompilationInfo?.PreviousSubmission is null || _scriptCompilationInfo.PreviousSubmission.HostObjectType == _scriptCompilationInfo.HostObjectType);

            //_scriptClass = new Lazy<ScriptSymbol?>(BindScriptClass);
            //_globalImports = new Lazy<Imports>(BindGlobalImports);
            //_previousSubmissionImports = new Lazy<Imports>(ExpandPreviousSubmissionImports);
            //_globalNamespaceAlias = new Lazy<AliasSymbol>(CreateGlobalNamespaceAlias);
            //_anonymousTypeManager = new AnonymousTypeManager(this);
            //
            //var csharpReferences = ReferenceManager.CSharpReferences(references);
            //CSharpCompilationForReferenceManager = CSharpCompilation.Create(assemblyName, null, csharpReferences, options.ToCSharp());
            //
            //// Can't reuse reference manager if there are embedded references
            //var customReferences = ReferenceManager.CustomReferences(references);
            //if (customReferences.Any(cr => cr.EmbedInCompilation)) reuseReferenceManager = false;
            //
            //if (reuseReferenceManager)
            //{
            //    if (referenceManager is null)
            //    {
            //        throw new ArgumentNullException(nameof(referenceManager));
            //    }
            //
            //    referenceManager.AssertCanReuseForCompilation(this);
            //    _referenceManager = referenceManager;
            //}
            //else
            //{
            //    _referenceManager = new ReferenceManager(MakeSourceAssemblySimpleName());
            //}

            if (reuseReferenceManager)
            {
                if (referenceManager is null) throw new ArgumentNullException(nameof(referenceManager));
                _referenceManager = referenceManager;
            }
            else
            {
                _referenceManager = CSharpCompilation.Create(assemblyName, references: references);
            }

            _syntaxAndDeclarations = syntaxAndDeclarations;

            Debug.Assert(_lazyAssemblySymbol is null);
            //if (EventQueue != null) EventQueue.TryEnqueue(new CompilationStartedEvent(this));
        }

        public string? Name => _assemblyName;
        public CompilationOptions Options => _options;
        public CSharpCompilation ReferenceManager => _referenceManager;
        public ScriptCompilationInfo? ScriptCompilationInfo => _scriptCompilationInfo;

        protected virtual Compilation Update(
            string? assemblyName,
            CompilationOptions options,
            ImmutableArray<MetadataReference> externalReferences,
            ScriptCompilationInfo? scriptCompilationInfo,
            CSharpCompilation? referenceManager,
            bool reuseReferenceManager,
            SyntaxAndDeclarationManager syntaxAndDeclarations)
        {
            if (_assemblyName != assemblyName || _options != options || _externalReferences != externalReferences ||
                _scriptCompilationInfo != scriptCompilationInfo || _referenceManager != referenceManager ||
                !reuseReferenceManager || _syntaxAndDeclarations != syntaxAndDeclarations)
            {
                return new Compilation(assemblyName, options, externalReferences, scriptCompilationInfo,
                    referenceManager, reuseReferenceManager, syntaxAndDeclarations);
            }
            else
            {
                return this;
            }
        }

        public static Compilation Create(
            string? assemblyName = null, 
            IEnumerable<SyntaxTree>? syntaxTrees = null, 
            IEnumerable<MetadataReference>? references = null, 
            CompilationOptions? options = null)
        {
            var externalReferences = references is null ? ImmutableArray<MetadataReference>.Empty : references.ToImmutableArray();
            var externalSyntaxTrees = syntaxTrees is null ? ImmutableArray<SyntaxTree>.Empty : syntaxTrees.ToImmutableArray();
            var declarationManager = new SyntaxAndDeclarationManager(ImmutableArray<SyntaxTree>.Empty, null, null, false, null).AddSyntaxTrees(externalSyntaxTrees);
            return new Compilation(assemblyName, options ?? CompilationOptions.Default, externalReferences, null, null, false, declarationManager);
        }

        public static Compilation CreateScriptCompilation(
            string assemblyName,
            SyntaxTree? syntaxTree = null,
            IEnumerable<MetadataReference>? references = null,
            CompilationOptions? options = null,
            Compilation? previousScriptCompilation = null,
            Type? returnType = null,
            Type? globalsType = null)
        {
            var externalReferences = references is null ? ImmutableArray<MetadataReference>.Empty : references.ToImmutableArray();
            var externalSyntaxTrees = syntaxTree is null ? ImmutableArray<SyntaxTree>.Empty : ImmutableArray.Create(syntaxTree);
            var declarationManager = new SyntaxAndDeclarationManager(ImmutableArray<SyntaxTree>.Empty, null, null, false, null).AddSyntaxTrees(externalSyntaxTrees);
            var scriptCompilationInfo = new ScriptCompilationInfo(previousScriptCompilation, returnType, globalsType);
            return new Compilation(assemblyName, options ?? CompilationOptions.Default, externalReferences, scriptCompilationInfo, null, false, declarationManager);
        }

        internal int CompareSourceLocations(Location location1, Location location2)
        {
            throw new NotImplementedException();
        }

        internal int CompareSourceLocations(SyntaxReference location1, SyntaxReference location2)
        {
            throw new NotImplementedException();
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
            return !(type == typeof(void) || type.IsByRef || type.GetTypeInfo().ContainsGenericParameters);
        }

        /// <summary>
        /// The type of the globals object or null if not specified for this compilation.
        /// </summary>
        internal Type? HostObjectType => ScriptCompilationInfo?.HostObjectType;

        internal static bool IsValidHostObjectType(Type type)
        {
            var info = type.GetTypeInfo();
            return !(info.IsValueType || info.IsPointer || info.IsByRef || info.ContainsGenericParameters);
        }

        public Compilation WithScriptCompilationInfo(ScriptCompilationInfo? info)
        {
            return this.Update(_assemblyName, _options, _externalReferences, info, _referenceManager, true, _syntaxAndDeclarations);
        }

        #endregion

        #region Syntax Trees (maintain an ordered list)

        /// <summary>
        /// The syntax trees (parsed from source code) that this compilation was created with.
        /// </summary>
        public ImmutableArray<SyntaxTree> SyntaxTrees
        {
            get { return _syntaxAndDeclarations.GetLazyState().SyntaxTrees; }
        }

        /// <summary>
        /// Returns true if this compilation contains the specified tree.  False otherwise.
        /// </summary>
        public bool ContainsSyntaxTree(SyntaxTree? syntaxTree)
        {
            return syntaxTree != null && _syntaxAndDeclarations.GetLazyState().RootNamespaces.ContainsKey(syntaxTree);
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

            return Update(_assemblyName, _options, _externalReferences, _scriptCompilationInfo, _referenceManager, reuseReferenceManager, syntaxAndDeclarations);
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
                    var loadedSyntaxTreeMap = syntaxAndDeclarations.GetLazyState().LoadedSyntaxTreeMap;
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

            return Update(_assemblyName, _options, _externalReferences, _scriptCompilationInfo, _referenceManager,
                reuseReferenceManager, syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation without any syntax trees. Preserves metadata info
        /// from this compilation for use with trees added later.
        /// </summary>
        public Compilation RemoveAllSyntaxTrees()
        {
            var syntaxAndDeclarations = _syntaxAndDeclarations;
            return Update(_assemblyName, _options, _externalReferences, _scriptCompilationInfo, _referenceManager,
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
                var loadedSyntaxTreeMap = syntaxAndDeclarations.GetLazyState().LoadedSyntaxTreeMap;
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

            return Update(_assemblyName, _options, _externalReferences, _scriptCompilationInfo, _referenceManager,
                reuseReferenceManager, syntaxAndDeclarations);
        }

        internal int GetSyntaxTreeOrdinal(SyntaxTree tree)
        {
            Debug.Assert(this.ContainsSyntaxTree(tree));
            return _syntaxAndDeclarations.GetLazyState().OrdinalMap[tree];
        }

        #endregion


        #region References

        // TODO

        /// <summary>
        /// Creates a new compilation with additional metadata references.
        /// </summary>
        public Compilation AddReferences(params MetadataReference[] references)
        {
            if (references.Length == 0) return this;
            return this.Update(_assemblyName, _options, _externalReferences.AddRange(references), _scriptCompilationInfo,
                _referenceManager, false, _syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation with additional metadata references.
        /// </summary>
        public Compilation AddReferences(IEnumerable<MetadataReference> references)
        {
            if (!references.Any()) return this;
            return this.Update(_assemblyName, _options, _externalReferences.AddRange(references), _scriptCompilationInfo,
                _referenceManager, false, _syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation without the specified metadata references.
        /// </summary>
        public Compilation RemoveReferences(params MetadataReference[] references)
        {
            if (references.Length == 0) return this;
            return this.Update(_assemblyName, _options, _externalReferences.RemoveRange(references), _scriptCompilationInfo,
                _referenceManager, false, _syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation without the specified metadata references.
        /// </summary>
        public Compilation RemoveReferences(IEnumerable<MetadataReference> references)
        {
            if (!references.Any()) return this;
            return this.Update(_assemblyName, _options, _externalReferences.RemoveRange(references), _scriptCompilationInfo,
                _referenceManager, false, _syntaxAndDeclarations);
        }

        /// <summary>
        /// Creates a new compilation without any metadata references
        /// </summary>
        public Compilation RemoveAllReferences()
        {
            if (_externalReferences.Length == 0) return this;
            return this.Update(_assemblyName, _options, ImmutableArray<MetadataReference>.Empty, _scriptCompilationInfo,
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
            return this.Update(_assemblyName, _options, builder.ToImmutableAndFree(), _scriptCompilationInfo,
                _referenceManager, !replaced, _syntaxAndDeclarations);
        }

        #endregion


        #region Declarations

        internal protected DeclarationTable DeclarationTable => _syntaxAndDeclarations.GetLazyState().DeclarationTable;

        public MergedDeclaration RootDeclaration => DeclarationTable.GetMergedRoot(this);


        #endregion


        #region Binding

        public BinderFactory GetBinderFactory(SyntaxTree syntaxTree, bool ignoreAccessibility = false)
        {
            return GetBinderFactory(syntaxTree, ignoreAccessibility: false, ref _binderFactories);
        }

        private BinderFactory GetBinderFactory(SyntaxTree syntaxTree, bool ignoreAccessibility, ref WeakReference<BinderFactory>[]? cachedBinderFactories)
        {
            Debug.Assert(System.Runtime.CompilerServices.Unsafe.AreSame(ref cachedBinderFactories, ref ignoreAccessibility ? ref _ignoreAccessibilityBinderFactories : ref _binderFactories));

            var treeNum = GetSyntaxTreeOrdinal(syntaxTree);
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

        /*public Binder GetBinder(SyntaxNodeOrToken syntax)
        {
            return GetBinderFactory(syntax.SyntaxTree).GetBinder(syntax);
        }*/

        #endregion

        #region Semantic Analysis

        public bool HasCodeToEmit()
        {
            return true;
        }

        #endregion


    }
}