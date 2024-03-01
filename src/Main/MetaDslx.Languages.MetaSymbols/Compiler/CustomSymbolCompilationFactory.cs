using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    public class CustomSymbolCompilationFactory : CompilationFactory
    {
        public override Compilation CreateCompilation(string? assemblyName, CompilationFactory compilationFactory, CompilationOptions options, CSharpCompilation? initialCompilation, ImmutableArray<MetadataReference> references, ScriptCompilationInfo? scriptCompilationInfo, ReferenceManager? referenceManager, bool reuseReferenceManager, SyntaxAndDeclarationManager syntaxAndDeclarations)
        {
            return new SymbolCompilation(assemblyName, compilationFactory, options, initialCompilation, references, scriptCompilationInfo, referenceManager, reuseReferenceManager, syntaxAndDeclarations);
        }
    }
}
