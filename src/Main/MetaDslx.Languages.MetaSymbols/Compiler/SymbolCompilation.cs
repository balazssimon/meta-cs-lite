using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    public class SymbolCompilation : Compilation
    {
        protected internal SymbolCompilation(string? assemblyName, CompilationFactory compilationFactory, CompilationOptions options, CSharpCompilation? initialCompilation, ImmutableArray<MetadataReference> references, ScriptCompilationInfo? scriptCompilationInfo, ReferenceManager? referenceManager, bool reuseReferenceManager, SyntaxAndDeclarationManager syntaxAndDeclarations)
            : base(assemblyName, compilationFactory, options, initialCompilation, references, scriptCompilationInfo, referenceManager, reuseReferenceManager, syntaxAndDeclarations)
        {
        }

        protected override void RegisterServices()
        {
            base.RegisterServices();
            Register<CSharpSymbolFactory, SymbolCSharpSymbolFactory>();
        }
    }
}
