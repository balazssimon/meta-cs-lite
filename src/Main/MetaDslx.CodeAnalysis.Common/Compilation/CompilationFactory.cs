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
            CompilationFactory compilationFactory,
            CompilationOptions options,
            CSharpCompilation? initialCompilation,
            ImmutableArray<MetadataReference> references,
            ScriptCompilationInfo? scriptCompilationInfo,
            ReferenceManager? referenceManager,
            bool reuseReferenceManager,
            SyntaxAndDeclarationManager syntaxAndDeclarations)
        {
            return new Compilation(assemblyName, compilationFactory, options, initialCompilation, references, scriptCompilationInfo,
                    referenceManager, reuseReferenceManager, syntaxAndDeclarations);
        }

    }
}
