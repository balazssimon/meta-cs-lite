using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Syntax;
using MetaDslx.Languages.MetaCompiler.Antlr.Generators;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices.ComTypes;
using System.Diagnostics;

namespace MetaDslx.Languages.MetaCompiler.Antlr.Analyzers
{
    using Language = MetaDslx.Languages.MetaCompiler.Model.Language;

    [Generator]
    public class AntlrCompilerGenerator : IIncrementalGenerator
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
                        GenerateAntlr(language, spc);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            });
        }

        private void GenerateAntlr(Language language, SourceProductionContext context)
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            try
            {
                Directory.CreateDirectory(tempDirectory);
                var generator = new AntlrGenerator();
                var lexerCode = generator.GenerateLexer(language);
                if (lexerCode is not null)
                {
                    var lexerFileName = $"{language.Name}Lexer.g4";
                    var lexerFilePath = Path.Combine(tempDirectory, lexerFileName);
                    File.WriteAllText(lexerFilePath, lexerCode);

                    var antlrTool = new AntlrTool();
                    antlrTool.GrammarFiles.Add(lexerFileName);
                    antlrTool.WorkingDirectory = tempDirectory;
                    antlrTool.Execute(context.CancellationToken);
                    foreach (var antlrFile in antlrTool.GeneratedFiles)
                    {
                        var fileName = Path.GetFileNameWithoutExtension(antlrFile);
                        var code = File.ReadAllText(Path.Combine(tempDirectory, antlrFile));
                        context.AddSource($"MetaCompiler.Antlr.{fileName}.g.cs", code);
                    }
                }
            }
            finally
            {
                try
                {
                    Directory.Delete(tempDirectory, true);
                }
                catch (Exception)
                {
                    // nop
                }
            }
        }
    }
}
