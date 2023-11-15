using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis.Analyzers
{
    using MetaDslx.CodeAnalysis.Text;
    using MetaDslx.Languages.MetaCompiler.Syntax;
    using MetaDslx.Languages.MetaModel.Compiler;
    using MetaDslx.Languages.MetaModel.Model;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices.ComTypes;
    using static System.Net.Mime.MediaTypeNames;

    [Generator]
    public class MetaDslxSourceGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext initContext)
        {
            IncrementalValuesProvider<AdditionalText> textFiles = initContext.AdditionalTextsProvider
                .Where(static file => file.Path.EndsWith(".mm") || file.Path.EndsWith(".mlang") || file.Path.EndsWith(".mgen"));
            IncrementalValuesProvider<(string path, string content)> pathsAndContents = textFiles
                .Select((text, cancellationToken) => (path: text.Path, content: text.GetText(cancellationToken)!.ToString()));
            /*IncrementalValuesProvider<(string path, MetaDslx.CodeAnalysis.SyntaxTree syntaxTree, MetaDslx.CodeAnalysis.Diagnostic? error)> pathsAndSyntaxTrees = pathsAndContents.Select(
                (pc, cancellationToken) =>
                {
                    MetaDslx.CodeAnalysis.SyntaxTree? syntaxTree = null;
                    if (pc.path.EndsWith(".mm")) syntaxTree = MetaSyntaxTree.ParseText(pc.content, path: pc.path, cancellationToken: cancellationToken);
                    else if (pc.path.EndsWith(".mlang")) syntaxTree = MetaSyntaxTree.ParseText(pc.content, path: pc.path, cancellationToken: cancellationToken);
                    else if (pc.path.EndsWith(".mgen")) syntaxTree = MetaSyntaxTree.ParseText(pc.content, path: pc.path, cancellationToken: cancellationToken);
                    return (path: pc.path, syntaxTree: text.GetText(cancellationToken)!.ToString())
                });*/
            IncrementalValueProvider<(Compilation Compilation, ImmutableArray<(string path, string content)> PathsAndContents)> compilationAndContent =
                initContext.CompilationProvider.Combine(pathsAndContents.Collect());
            initContext.RegisterSourceOutput(compilationAndContent, (spc, compilationAndContent) =>
            {
                try
                {
                    var compilation = compilationAndContent.Compilation;
                    var mmFiles = compilationAndContent.PathsAndContents.Where(f => f.path.EndsWith(".mm"));
                    var mmCSharpTrees = new List<SyntaxTree>();
                    try
                    {
                        var mmTrees = mmFiles.Select(f => MetaSyntaxTree.ParseText(f.content, path: f.path, cancellationToken: spc.CancellationToken)).ToImmutableArray();
                        var mmCompiler = MetaDslx.CodeAnalysis.Compilation.Create("Meta",
                            syntaxTrees: mmTrees,
                            initialCompilation: compilationAndContent.Compilation as CSharpCompilation,
                            references: new[]
                            {
                                MetaDslx.CodeAnalysis.MetadataReference.CreateFromMetaModel(MetaDslx.Languages.MetaModel.Model.Meta.Instance)
                            },
                            options: MetaDslx.CodeAnalysis.CompilationOptions.Default.WithConcurrentBuild(false));
                        mmCompiler.Compile(spc.CancellationToken);
                        var model = mmCompiler.SourceModule.Model;
                        var mmMetaModels = model.Objects.OfType<MetaDslx.Languages.MetaModel.Model.MetaModel>().ToImmutableArray();
                        var diagnostics = mmCompiler.GetDiagnostics();
                        if (diagnostics.Length > 0)
                        {
                            foreach (var diag in diagnostics)
                            {
                                spc.ReportDiagnostic(diag.ToMicrosoft());
                            }
                        }
                        else 
                        {
                            foreach (var metaModel in mmMetaModels)
                            {
                                var generator = new MetaDslx.Languages.MetaModel.Generators.MetaModelGenerator(true, model, metaModel);
                                var output = generator.Generate();
                                var csharpFilePath = $"MetaModel.{metaModel.Name}.g.cs";
                                spc.AddSource(csharpFilePath, output);
                                mmCSharpTrees.Add(CSharpSyntaxTree.ParseText(output, path: csharpFilePath, cancellationToken: spc.CancellationToken));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        var exLocation = MetaDslx.CodeAnalysis.ExternalFileLocation.Create(compilationAndContent.PathsAndContents[0].path, TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                        var exDiag = MetaDslx.CodeAnalysis.Diagnostic.Create(MetaDslx.CodeAnalysis.ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
                        spc.ReportDiagnostic(exDiag.ToMicrosoft());
                        Debug.WriteLine(ex);
                    }
                    var mmCompilation = compilation.AddSyntaxTrees(mmCSharpTrees);
                    var mlangFiles = compilationAndContent.PathsAndContents.Where(f => f.path.EndsWith(".mlang"));
                    try
                    {
                        foreach (var mlangFile in mlangFiles)
                        {
                            var fileName = Path.GetFileNameWithoutExtension(mlangFile.path);
                            var mlangCompiler = new MetaCompilerParser((CSharpCompilation)compilation, mlangFile.path, SourceText.From(mlangFile.content));
                            var language = mlangCompiler.Parse(resolveAnnotations: true);
                            if (mlangCompiler.Diagnostics.Length > 0)
                            {
                                foreach (var diag in mlangCompiler.Diagnostics)
                                {
                                    spc.ReportDiagnostic(diag.ToMicrosoft());
                                }
                            }
                            else
                            {
                                var generator = new Languages.MetaCompiler.Generators.RoslynApiGenerator();
                                var languageCode = generator.GenerateLanguage(language);
                                spc.AddSource($"{fileName}.MetaCompiler.Language.g.cs", languageCode);
                                var languageVersionCode = generator.GenerateLanguageVersion(language);
                                spc.AddSource($"{fileName}.MetaCompiler.LanguageVersion.g.cs", languageVersionCode);
                                var parseOptionsCode = generator.GenerateParseOptions(language);
                                spc.AddSource($"{fileName}.MetaCompiler.ParseOptions.g.cs", parseOptionsCode);
                                var syntaxKindCode = generator.GenerateSyntaxKind(language);
                                spc.AddSource($"{fileName}.MetaCompiler.SyntaxKind.g.cs", syntaxKindCode);
                                var syntaxFactsCode = generator.GenerateSyntaxFacts(language);
                                spc.AddSource($"{fileName}.MetaCompiler.SyntaxFacts.g.cs", syntaxFactsCode);
                                var internalSyntaxCode = generator.GenerateInternalSyntax(language);
                                spc.AddSource($"{fileName}.MetaCompiler.InternalSyntax.g.cs", internalSyntaxCode);
                                var internalSyntaxVisitorCode = generator.GenerateInternalSyntaxVisitor(language);
                                spc.AddSource($"{fileName}.MetaCompiler.InternalSyntaxVisitor.g.cs", internalSyntaxVisitorCode);
                                var internalSyntaxFactoryCode = generator.GenerateInternalSyntaxFactory(language);
                                spc.AddSource($"{fileName}.MetaCompiler.InternalSyntaxFactory.g.cs", internalSyntaxFactoryCode);
                                var syntaxCode = generator.GenerateSyntax(language);
                                spc.AddSource($"{fileName}.MetaCompiler.Syntax.g.cs", syntaxCode);
                                var syntaxTreeCode = generator.GenerateSyntaxTree(language);
                                spc.AddSource($"{fileName}.MetaCompiler.SyntaxTree.g.cs", syntaxTreeCode);
                                var syntaxVisitorCode = generator.GenerateSyntaxVisitor(language);
                                spc.AddSource($"{fileName}.MetaCompiler.SyntaxVisitor.g.cs", syntaxVisitorCode);
                                var syntaxFactoryCode = generator.GenerateSyntaxFactory(language);
                                spc.AddSource($"{fileName}.MetaCompiler.SyntaxFactory.g.cs", syntaxFactoryCode);
                                var binderFactoryVisitorCode = generator.GenerateBinderFactoryVisitor(language);
                                spc.AddSource($"{fileName}.MetaCompiler.BinderFactoryVisitor.g.cs", binderFactoryVisitorCode);
                                var semanticsFactoryCode = generator.GenerateSemanticsFactory(language);
                                spc.AddSource($"{fileName}.MetaCompiler.SemanticsFactory.g.cs", semanticsFactoryCode);
                                var compilationFactoryCode = generator.GenerateCompilationFactory(language);
                                spc.AddSource($"{fileName}.MetaCompiler.CompilationFactory.g.cs", compilationFactoryCode);
                                //var compilationCode = generator.GenerateCompilation(language);
                                //spc.AddSource($"{fileName}.MetaCompiler.Compilation.g.cs", compilationCode);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        var exLocation = MetaDslx.CodeAnalysis.ExternalFileLocation.Create(compilationAndContent.PathsAndContents[0].path, TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                        var exDiag = MetaDslx.CodeAnalysis.Diagnostic.Create(MetaDslx.CodeAnalysis.ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
                        spc.ReportDiagnostic(exDiag.ToMicrosoft());
                        Debug.WriteLine(ex);
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
