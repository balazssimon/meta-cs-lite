using MetaDslx.CodeAnalysis.Text;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using MetaDslx.Languages.MetaGenerator.Syntax;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp;
using MetaDslx.Languages.MetaModel.Compiler;
using MetaDslx.CodeAnalysis.Symbols;
using System.Linq;

namespace MetaDslx.Languages.MetaCompiler.Analyzers
{
    [Generator]
    public class MetaModelSourceGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext initContext)
        {
            IncrementalValuesProvider<AdditionalText> textFiles = initContext.AdditionalTextsProvider
                .Where(static file => file.Path.EndsWith(".mm"));
            IncrementalValuesProvider<(string path, string content)> pathsAndContents = textFiles
                .Select((text, cancellationToken) => (path: text.Path, content: text.GetText(cancellationToken)!.ToString()));
            IncrementalValueProvider<(Compilation Compilation, ImmutableArray<(string path, string content)> PathsAndContents)> compilationAndContent =
                initContext.CompilationProvider.Combine(pathsAndContents.Collect());
            initContext.RegisterSourceOutput(compilationAndContent, (spc, compilationAndContent) =>
            {
                try
                {
                    var compilation = compilationAndContent.Compilation;
                    var compDiags = compilation.GetDiagnostics();
                    foreach (var pathAndContent in compilationAndContent.PathsAndContents)
                    {
                        try
                        {
                            var fileName = Path.GetFileNameWithoutExtension(pathAndContent.path);
                            var mmCode = pathAndContent.content;
                            var syntaxTree = MetaSyntaxTree.ParseText(mmCode, path: pathAndContent.path, cancellationToken: spc.CancellationToken);
                            var mmCompiler = MetaDslx.CodeAnalysis.Compilation.Create("Meta",
                                syntaxTrees: new[] { syntaxTree },
                                references: new[]
                                {
                                    MetaDslx.CodeAnalysis.MetadataReference.CreateFromMetaModel(MetaDslx.Languages.MetaModel.Model.Meta.Instance),
                                    MetaDslx.CodeAnalysis.MetadataReference.CreateFromFile(typeof(string).Assembly.Location),
                                    MetaDslx.CodeAnalysis.MetadataReference.CreateFromFile(typeof(Symbol).Assembly.Location),
                                },
                                options: MetaDslx.CodeAnalysis.CompilationOptions.Default.WithConcurrentBuild(false));
                            mmCompiler.Compile(spc.CancellationToken);
                            var model = mmCompiler.SourceModule.Model;
                            var mm = model.Objects.OfType<MetaDslx.Languages.MetaModel.Model.MetaModel>().FirstOrDefault();
                            var diagnostics = mmCompiler.GetDiagnostics();
                            if (diagnostics.Length > 0)
                            {
                                foreach (var diag in diagnostics)
                                {
                                    spc.ReportDiagnostic(diag.ToMicrosoft());
                                }
                            }
                            else if (mm is not null)
                            {
                                var graph = new MetaDslx.Languages.MetaModel.Meta.MetaMetaGraph(model.Objects.OfType<MetaDslx.Languages.MetaModel.Model.MetaClass>());
                                graph.Compute();
                                var generator = new MetaDslx.Languages.MetaModel.Generators.MetaModelGenerator(model, mm, graph);
                                var output = generator.Generate();
                                var csharpFilePath = $"MetaModel.{fileName}.g.cs";
                                spc.AddSource(csharpFilePath, output);
                            }
                        }
                        catch (Exception ex)
                        {
                            var exLocation = MetaDslx.CodeAnalysis.ExternalFileLocation.Create(pathAndContent.path, TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                            var exDiag = MetaDslx.CodeAnalysis.Diagnostic.Create(MetaDslx.CodeAnalysis.ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString());
                            spc.ReportDiagnostic(exDiag.ToMicrosoft());
                            Debug.WriteLine(ex);
                        }
                    }
                }
                catch (Exception ex)
                {
                    var exLocation = MetaDslx.CodeAnalysis.ExternalFileLocation.Create(compilationAndContent.PathsAndContents[0].path, TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                    var exDiag = MetaDslx.CodeAnalysis.Diagnostic.Create(MetaDslx.CodeAnalysis.ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString());
                    spc.ReportDiagnostic(exDiag.ToMicrosoft());
                    Debug.WriteLine(ex);
                }
            });
        }

    }
}
