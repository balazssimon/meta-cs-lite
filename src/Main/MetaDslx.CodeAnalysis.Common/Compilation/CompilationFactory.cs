using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Modeling;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public class CompilationFactory
    {
        private ObjectPool<LookupContext> _lookupContextPool;

        public CompilationFactory()
        {
            _lookupContextPool = new ObjectPool<LookupContext>(() => CreateLookupContext(_lookupContextPool), 128); 
        }

        internal ObjectPool<LookupContext> LookupContextPool => _lookupContextPool;

        public virtual Compilation CreateCompilation(
            string? assemblyName,
            Language? mainLanguage,
            CompilationOptions options,
            ImmutableArray<MetadataReference> references,
            ScriptCompilationInfo? scriptCompilationInfo,
            ReferenceManager? referenceManager,
            bool reuseReferenceManager,
            SyntaxAndDeclarationManager syntaxAndDeclarations)
        {
            return new Compilation(assemblyName, mainLanguage, options, references, scriptCompilationInfo,
                    referenceManager, reuseReferenceManager, syntaxAndDeclarations);
        }

        public virtual ReferenceManager CreateReferenceManager(Compilation compilation)
        {
            return new ReferenceManager();
        }

        public virtual AccessCheck CreateAccessCheck(Compilation compilation)
        {
            return new AccessCheck();
        }

        public virtual IMultiModelFactory CreateModelFactory(Compilation compilation)
        {
            var metaModels = ArrayBuilder<IMetaModel>.GetInstance();
            foreach (var reference in compilation.ExternalReferences.OfType<MetaModelReference>())
            {
                metaModels.Add(reference.MetaModel);
            }
            return new MultiModelFactory(metaModels.ToImmutableAndFree());
        }

        public virtual IModelGroup CreateModelGroup(Compilation compilation)
        {
            return new ModelGroup();
        }

        public virtual IModel CreateModel(Compilation compilation)
        {
            return new Model();
        }

        public virtual ModelSymbolFactory CreateModelSymbolFactory(Compilation compilation)
        {
            return new ModelSymbolFactory();
        }

        public virtual SourceSymbolFactory CreateSourceSymbolFactory(Compilation compilation, SourceModuleSymbol sourceModule)
        {
            return new SourceSymbolFactory(sourceModule);
        }

        internal virtual CSharpSymbolFactory CreateCSharpSymbolFactory(Compilation compilation)
        {
            return new CSharpSymbolFactory();
        }

        public virtual LookupContext CreateLookupContext(ObjectPool<LookupContext> pool)
        {
            return new LookupContext(pool);
        }

        public virtual ILookupValidator CreateDefaultLookupValidator(Compilation compilation)
        {
            return new DefaultLookupValidator();
        }
    }
}
