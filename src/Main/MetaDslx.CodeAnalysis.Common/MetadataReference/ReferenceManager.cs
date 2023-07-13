using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.MetaModel;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.CodeAnalysis.Symbols.Source;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis
{
    public class ReferenceManager
    {
        /// <summary>
        /// Must be acquired whenever the following data are about to be modified:
        /// - Compilation.lazyAssemblySymbol
        /// - Compilation.referenceManager
        /// - ReferenceManager state
        /// - <see cref="AssemblyMetadata.CachedSymbols"/>
        /// - <see cref="Compilation.RetargetingAssemblySymbols"/>
        /// 
        /// All the above data should be updated at once while holding this lock.
        /// Once lazyAssemblySymbol is set the Compilation.referenceManager field and ReferenceManager
        /// state should not change.
        /// </summary>
        private static object SymbolCacheAndReferenceManagerStateGuard = new object();

        /// <summary>
        /// If the compilation being built represents an assembly its assembly name.
        /// If the compilation being built represents a module, the name of the 
        /// containing assembly or <see cref="Compilation.UnspecifiedModuleAssemblyName"/>
        /// if not specified (/moduleassemblyname command line option).
        /// </summary>
        internal string _simpleAssemblyName;

        private CSharpCompilation? _lazyCSharpCompilation;

        /// <summary>
        /// Maps C# symbols to MetaDslx symbols
        /// </summary>
        private CSharpSymbolMap? _lazyCSharpSymbolMap;

        private ImmutableArray<ModuleSymbol> _lazyReferencedModules;

        /// <summary>
        /// Once this is non-zero the state of the manager is fully initialized and immutable.
        /// </summary>
        private int _isBound;

        /// <summary>
        /// True if the compilation has a reference that refers back to the assembly being compiled.
        /// </summary>
        /// <remarks>
        /// If we have a circular reference the bound references can't be shared with other compilations.
        /// </remarks>
        private ThreeState _lazyHasCircularReference;

        public ReferenceManager()
        {
        }

        public bool IsBound => _isBound != 0;

        public bool HasCircularReference
        {
            get
            {
                AssertBound();
                return _lazyHasCircularReference == ThreeState.True;
            }
        }

        public CSharpCompilation CSharpCompilation
        {
            get
            {
                AssertBound();
                return _lazyCSharpCompilation;
            }
        }

        internal CSharpSymbolMap CSharpSymbolMap
        {
            get
            {
                AssertBound();
                return _lazyCSharpSymbolMap;
            }
        }

        internal void CreateSourceAssemblyForCompilation(Compilation compilation)
        {
            // We are reading the Reference Manager state outside of a lock by accessing 
            // IsBound and HasCircularReference properties.
            // Once isBound flag is flipped the state of the manager is available and doesn't change.
            // 
            // If two threads are building SourceAssemblySymbol and the first just updated 
            // set isBound flag to 1 but not yet set lazySourceAssemblySymbol,
            // the second thread may end up reusing the Reference Manager data the first thread calculated. 
            // That's ok since 
            // 1) the second thread would produce the same data,
            // 2) all results calculated by the second thread will be thrown away since the first thread 
            //    already acquired SymbolCacheAndReferenceManagerStateGuard that is needed to publish the data.

            // The given compilation is the first compilation that shares this manager and its symbols are requested.
            // Perform full reference resolution and binding.
            if (!IsBound && CreateAndSetSourceAssemblyFullBind(compilation))
            {
                // we have successfully bound the references for the compilation
            }
            else if (!HasCircularReference)
            {
                // Another compilation that shares the manager with the given compilation
                // already bound its references and produced tables that we can use to construct 
                // source assembly symbol faster. Unless we encountered a circular reference.
                CreateAndSetSourceAssemblyReuseData(compilation);
            }
            else
            {
                // We encountered a circular reference while binding the previous compilation.
                // This compilation can't share bound references with other compilations. Create a new manager.

                // NOTE: The CreateSourceAssemblyFullBind is going to replace compilation's reference manager with newManager.

                var newManager = new ReferenceManager();
                newManager._simpleAssemblyName = _simpleAssemblyName;
                var successful = newManager.CreateAndSetSourceAssemblyFullBind(compilation);

                // The new manager isn't shared with any other compilation so there is no other 
                // thread but the current one could have initialized it.
                Debug.Assert(successful);

                newManager.AssertBound();
            }

            AssertBound();
            Debug.Assert((object)compilation._lazyAssemblySymbol != null);
        }

        /// <summary>
        /// Call only while holding <see cref="CommonReferenceManager.SymbolCacheAndReferenceManagerStateGuard"/>.
        /// </summary>
        [Conditional("DEBUG")]
        internal void AssertUnbound()
        {
            Debug.Assert(_isBound == 0);
            Debug.Assert(_lazyHasCircularReference == ThreeState.Unknown);
            Debug.Assert(_lazyCSharpCompilation == null);
            Debug.Assert(_lazyCSharpSymbolMap == null);
            Debug.Assert(_lazyReferencedModules.IsDefault);
        }

        [Conditional("DEBUG")]
        internal void AssertBound()
        {
            Debug.Assert(_isBound != 0);
            Debug.Assert(_lazyHasCircularReference != ThreeState.Unknown);
            Debug.Assert(_lazyCSharpCompilation != null);
            Debug.Assert(_lazyCSharpSymbolMap != null);
            Debug.Assert(!_lazyReferencedModules.IsDefault);
        }

        [Conditional("DEBUG")]
        internal void AssertCanReuseForCompilation(Compilation compilation)
        {
            Debug.Assert(compilation.Name == _simpleAssemblyName);
        }

        /// <summary>
        /// Call only while holding <see cref="CommonReferenceManager.SymbolCacheAndReferenceManagerStateGuard"/>.
        /// </summary>
        internal void InitializeNoLock(CSharpCompilation csharpCompilation, bool containsCircularReferences, ImmutableArray<ModuleSymbol> referencedModules)
        {
            AssertUnbound();

            _lazyCSharpCompilation = csharpCompilation;
            _lazyHasCircularReference = containsCircularReferences.ToThreeState();
            _lazyCSharpSymbolMap = new CSharpSymbolMap();
            _lazyReferencedModules = referencedModules;

            // once we flip this bit the state of the manager is immutable and available to any readers:
            Interlocked.Exchange(ref _isBound, 1);
        }

        private void CreateAndSetSourceAssemblyReuseData(Compilation compilation)
        {
            AssertBound();

            // If the compilation has a reference from metadata to source assembly we can't share the referenced PE symbols.
            Debug.Assert(!HasCircularReference);

            var assemblySymbol = new SourceAssemblySymbol(compilation, _lazyCSharpCompilation.SourceModule.ContainingAssembly.Name, _lazyCSharpCompilation.SourceModule.Name, _lazyReferencedModules);
            if ((object)compilation._lazyAssemblySymbol == null)
            {
                lock (SymbolCacheAndReferenceManagerStateGuard)
                {
                    if ((object)compilation._lazyAssemblySymbol == null)
                    {
                        compilation._lazyAssemblySymbol = assemblySymbol;
                        Debug.Assert(ReferenceEquals(compilation._referenceManager, this));
                    }
                }
            }
        }

        // Returns false if another compilation sharing this manager finished binding earlier and we should reuse its results.
        private bool CreateAndSetSourceAssemblyFullBind(Compilation compilation)
        {
            var csharpReferences = ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>.GetInstance();
            foreach (var reference in compilation.ExternalReferences.OfType<CSharpMetadataReference>())
            {
                csharpReferences.Add(reference.CSharpReference);
            }
            var csharpCompilation = CSharpCompilation.Create(_simpleAssemblyName, references: csharpReferences.ToImmutableAndFree());
            var referencedModulesBuilder = ArrayBuilder<ModuleSymbol>.GetInstance();
            foreach (var csharpAssembly in csharpCompilation.SourceModule.ReferencedAssemblySymbols)
            {
                foreach (var csharpModule in csharpAssembly.Modules)
                {
                    referencedModulesBuilder.Add(new CSharpModuleSymbol(csharpModule));
                }
            }
            foreach (var reference in compilation.ExternalReferences.OfType<MetaModelReference>())
            {
                referencedModulesBuilder.Add(new MetaModelModuleSymbol(reference.MetaModel));
            }
            foreach (var reference in compilation.ExternalReferences.OfType<ModelReference>())
            {
                referencedModulesBuilder.Add(new ModelModuleSymbol(reference.Model));
            }
            // TODO: provide extension point for custom module symbols
            var referencedModules = referencedModulesBuilder.ToImmutableAndFree();
            var assemblySymbol = new SourceAssemblySymbol(compilation, csharpCompilation.SourceModule.ContainingAssembly.Name, csharpCompilation.SourceModule.Name, referencedModules);
            if ((object)compilation._lazyAssemblySymbol == null)
            {
                lock (SymbolCacheAndReferenceManagerStateGuard)
                {
                    if ((object)compilation._lazyAssemblySymbol == null)
                    {
                        if (IsBound)
                        {
                            // Another thread has finished constructing AssemblySymbol for another compilation that shares this manager.
                            // Drop the results and reuse the symbols that were created for the other compilation.
                            return false;
                        }

                        InitializeNoLock(csharpCompilation, false, referencedModules);

                        // Make sure that the given compilation holds on this instance of reference manager.
                        Debug.Assert(ReferenceEquals(compilation._referenceManager, this) || HasCircularReference);
                        compilation._referenceManager = this;

                        // Finally, publish the source symbol after all data have been written.
                        // Once lazyAssemblySymbol is non-null other readers might start reading the data written above.
                        compilation._lazyAssemblySymbol = assemblySymbol;
                    }
                }
            }
            return true;
        }

        protected virtual ImmutableArray<ModuleSymbol> CreateModules(Compilation compilation)
        {
            return ImmutableArray<ModuleSymbol>.Empty;
        }
    }
}
