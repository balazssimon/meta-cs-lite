using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.Errors;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public class CompilationFactory
    {
        public CompilationFactory()
        {
        }

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

        public virtual MultiModelFactory CreateModelFactory(Compilation compilation)
        {
            var metaModels = new List<MetaModel>();
            foreach (var reference in compilation.ExternalReferences.OfType<MetaModelReference>())
            {
                metaModels.Add(reference.MetaModel);
            }
            return new MultiModelFactory(metaModels);
        }

        public virtual ModelGroup CreateModelGroup(Compilation compilation)
        {
            return new ModelGroup();
        }

        public virtual Model CreateModel(Compilation compilation)
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

        public virtual ErrorSymbolFactory CreateErrorSymbolFactory(Compilation compilation)
        {
            return new ErrorSymbolFactory();
        }

        internal virtual CSharpSymbolFactory CreateCSharpSymbolFactory(Compilation compilation)
        {
            return new CSharpSymbolFactory();
        }
    }
}
