using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.BuildTools
{
    internal class MetaCompilation : Compilation
    {
        protected internal MetaCompilation(string? assemblyName, CompilationFactory compilationFactory, CompilationOptions options, CSharpCompilation? initialCompilation, ImmutableArray<MetadataReference> references, ScriptCompilationInfo? scriptCompilationInfo, ReferenceManager? referenceManager, bool reuseReferenceManager, SyntaxAndDeclarationManager syntaxAndDeclarations) 
            : base(assemblyName, compilationFactory, options, initialCompilation, references, scriptCompilationInfo, referenceManager, reuseReferenceManager, syntaxAndDeclarations)
        {
        }

        protected override void RegisterServices()
        {
            base.RegisterServices();
            Register<CSharpSymbolFactory, MetaCSharpSymbolFactory>();
        }
    }
}
