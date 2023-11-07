using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaGenerator.Syntax;
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
using Roslyn.Utilities;

namespace MetaDslx.Languages.MetaGenerator.Analyzers
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
                try
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
                }
                catch (Exception ex)
                {
                    var exLocation = MetaDslx.CodeAnalysis.ExternalFileLocation.Create(pathAndContent.path, TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                    var exDiag = MetaDslx.CodeAnalysis.Diagnostic.Create(MetaDslx.CodeAnalysis.ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
                    spc.ReportDiagnostic(exDiag.ToMicrosoft());
                    Debug.WriteLine(ex);
                }
            });
        }

    }
}
