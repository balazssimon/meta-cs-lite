using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public class CompilationFactory
    {
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

        public virtual ReferenceManager CreateReferenceManager()
        {
            return new ReferenceManager();
        }

    }
}
