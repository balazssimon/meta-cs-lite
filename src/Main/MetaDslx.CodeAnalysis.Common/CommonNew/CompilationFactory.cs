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

        public virtual ModelGroup CreateModelGroup()
        {
            return new ModelGroup();
        }

        public virtual Model CreateModel(ModuleSymbol moduleSymbol)
        {
            return new Model();
        }

        public virtual ModelSymbolFactory CreateModelSymbolFactory(Compilation compilation)
        {
            return new ModelSymbolFactory(compilation);
        }

        public virtual SourceSymbolFactory CreateSourceSymbolFactory(Compilation compilation)
        {
            return new SourceSymbolFactory(compilation);
        }

        public virtual ErrorSymbolFactory CreateErrorSymbolFactory()
        {
            return new ErrorSymbolFactory();
        }

        public virtual CSharpSymbolFactory CreateCSharpSymbolFactory()
        {
            return new CSharpSymbolFactory(ImmutableArray<CSharpModelFactory>.Empty);
        }

        public virtual SymbolValueConverter SymbolValueConverter(Compilation compilation)
        {
            return new SymbolValueConverter(compilation);
        }
    }
}
