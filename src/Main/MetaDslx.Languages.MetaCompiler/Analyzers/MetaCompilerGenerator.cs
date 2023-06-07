using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Syntax;
using MetaDslx.Languages.MetaCompiler.Generators;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using MetaDslx.Languages.MetaGenerator.Syntax;
using System.Diagnostics;

namespace MetaDslx.Languages.MetaCompiler.Analyzers
{
    [Generator]
    public class MetaCompilerGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext initContext)
        {
            IncrementalValuesProvider<AdditionalText> textFiles = initContext.AdditionalTextsProvider
                .Where(static file => file.Path.EndsWith(".mtext"));
            IncrementalValuesProvider<(string path, string content)> pathsAndContents = textFiles
                .Select((text, cancellationToken) => (path: text.Path, content: text.GetText(cancellationToken)!.ToString()));
            initContext.RegisterSourceOutput(pathsAndContents, (spc, pathAndContent) =>
            {
                try
                {
                    var filePath = Path.GetFileNameWithoutExtension(pathAndContent.path);
                    var csharpFilePath = $"MetaCompiler.{filePath}.g.cs";
                    var mtextCompiler = new MetaCompilerParser(pathAndContent.path, SourceText.From(pathAndContent.content));
                    var language = mtextCompiler.Parse();
                    if (mtextCompiler.Diagnostics.Length > 0)
                    {
                        foreach (var diag in mtextCompiler.Diagnostics)
                        {
                            spc.ReportDiagnostic(diag.ToMicrosoft());
                        }
                    }
                    else
                    {
                        var generator = new RoslynApiGenerator();
                        var syntaxNodesCode = generator.GenerateSyntaxNodes(language);
                        spc.AddSource($"MetaCompiler.{filePath}.SyntaxNodes.g.cs", syntaxNodesCode);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            });
        }

    }
}
