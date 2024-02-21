using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.Errors;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
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
            CSharpCompilation? initialCompilation,
            ImmutableArray<MetadataReference> references,
            ScriptCompilationInfo? scriptCompilationInfo,
            ReferenceManager? referenceManager,
            bool reuseReferenceManager,
            SyntaxAndDeclarationManager syntaxAndDeclarations)
        {
            return new Compilation(assemblyName, mainLanguage, options, initialCompilation, references, scriptCompilationInfo,
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

        public virtual Model CreateSourceModel(Compilation compilation)
        {
            return new Model();
        }

        public virtual ModelSymbolFactory CreateModelSymbolFactory()
        {
            return new ModelSymbolFactory();
        }

        public virtual SourceSymbolFactory CreateSourceSymbolFactory()
        {
            return new SourceSymbolFactory();
        }

        public virtual ErrorSymbolFactory CreateErrorSymbolFactory()
        {
            return new ErrorSymbolFactory();
        }

        internal virtual CSharpSymbolFactory CreateCSharpSymbolFactory()
        {
            return new CSharpSymbolFactory();
        }

        public virtual SymbolValueConverter SymbolValueConverter(Compilation compilation)
        {
            return new SymbolValueConverter(compilation);
        }
    }
}
