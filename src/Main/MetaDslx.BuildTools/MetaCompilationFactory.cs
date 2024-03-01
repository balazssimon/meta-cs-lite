using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.BuildTools
{
    internal class MetaCompilationFactory : CompilationFactory
    {
        public override Compilation CreateCompilation(string? assemblyName, CompilationFactory compilationFactory, CompilationOptions options, CSharpCompilation? initialCompilation, ImmutableArray<MetadataReference> references, ScriptCompilationInfo? scriptCompilationInfo, ReferenceManager? referenceManager, bool reuseReferenceManager, SyntaxAndDeclarationManager syntaxAndDeclarations)
        {
            return new MetaCompilation(assemblyName, compilationFactory, options, initialCompilation, references, scriptCompilationInfo, referenceManager, reuseReferenceManager, syntaxAndDeclarations);
        }
    }
}
