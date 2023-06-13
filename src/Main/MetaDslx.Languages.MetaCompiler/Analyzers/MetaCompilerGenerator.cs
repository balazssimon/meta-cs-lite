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
                .Where(static file => file.Path.EndsWith(".mlang"));
            IncrementalValuesProvider<(string path, string content)> pathsAndContents = textFiles
                .Select((text, cancellationToken) => (path: text.Path, content: text.GetText(cancellationToken)!.ToString()));
            initContext.RegisterSourceOutput(pathsAndContents, (spc, pathAndContent) =>
            {
                try
                {
                    var fileName = Path.GetFileNameWithoutExtension(pathAndContent.path);
                    var csharpFilePath = $"MetaCompiler.{fileName}.g.cs";
                    var mlangCompiler = new MetaCompilerParser(pathAndContent.path, SourceText.From(pathAndContent.content));
                    var language = mlangCompiler.Parse();
                    if (mlangCompiler.Diagnostics.Length > 0)
                    {
                        foreach (var diag in mlangCompiler.Diagnostics)
                        {
                            spc.ReportDiagnostic(diag.ToMicrosoft());
                        }
                    }
                    else
                    {
                        var generator = new RoslynApiGenerator();
                        var syntaxKindCode = generator.GenerateSyntaxKind(language);
                        spc.AddSource($"{fileName}.MetaCompiler.SyntaxKind.g.cs", syntaxKindCode);
                        var syntaxFactsCode = generator.GenerateSyntaxFacts(language);
                        spc.AddSource($"{fileName}.MetaCompiler.SyntaxFacts.g.cs", syntaxFactsCode);
                        var languageVersionCode = generator.GenerateLanguageVersion(language);
                        spc.AddSource($"{fileName}.MetaCompiler.LanguageVersion.g.cs", languageVersionCode);
                        var parseOptionsCode = generator.GenerateParseOptions(language);
                        spc.AddSource($"{fileName}.MetaCompiler.ParseOptions.g.cs", parseOptionsCode);
                        var internalSyntaxCode = generator.GenerateInternalSyntax(language);
                        spc.AddSource($"{fileName}.MetaCompiler.InternalSyntax.g.cs", internalSyntaxCode);
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
