using MetaDslx.CodeAnalysis.CodeGeneration;
using MetaDslx.CodeAnalysis.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Analyzers
{
    [Generator]
    public class MetaGeneratorGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext initContext)
        {
            IncrementalValuesProvider<AdditionalText> textFiles = initContext.AdditionalTextsProvider
                .Where(static file => file.Path.EndsWith(".mgen"));
            IncrementalValuesProvider<(string path, string content)> pathsAndContents = textFiles
                .Select((text, cancellationToken) => (path: text.Path, content: text.GetText(cancellationToken)!.ToString()));
            initContext.RegisterSourceOutput(pathsAndContents, (spc, pathAndContent) =>
            {
                var filePath = Path.GetFileNameWithoutExtension(pathAndContent.path);
                var csharpFilePath = $"MetaGenerator.{filePath}.g.cs";
                var mgenCompiler = new MetaGeneratorParser(pathAndContent.path, SourceText.From(pathAndContent.content));
                var csharpCode = mgenCompiler.Compile();
                if (mgenCompiler.Diagnostics.Length > 0)
                {
                    foreach (var diag in mgenCompiler.Diagnostics)
                    {
                        spc.ReportDiagnostic(diag.ToMicrosoft());
                    }
                }
                else
                {
                    spc.AddSource(csharpFilePath, csharpCode);
                }
            });
        }

    }
}
