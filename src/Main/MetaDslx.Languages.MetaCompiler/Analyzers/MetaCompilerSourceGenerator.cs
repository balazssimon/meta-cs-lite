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
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp;

namespace MetaDslx.Languages.MetaCompiler.Analyzers
{
    [Generator]
    public class MetaCompilerSourceGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext initContext)
        {
            IncrementalValuesProvider<AdditionalText> textFiles = initContext.AdditionalTextsProvider
                .Where(static file => file.Path.EndsWith(".mlang"));
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
                            var csharpFilePath = $"MetaCompiler.{fileName}.g.cs";
                            var mlangCompiler = new MetaCompilerParser((CSharpCompilation)compilation, pathAndContent.path, SourceText.From(pathAndContent.content));
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
                                var generator = new RoslynApiGenerator();
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
                        catch (Exception ex)
                        {
                            var exLocation = MetaDslx.CodeAnalysis.ExternalFileLocation.Create(pathAndContent.path, TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                            var exDiag = MetaDslx.CodeAnalysis.Diagnostic.Create(MetaDslx.CodeAnalysis.ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
                            spc.ReportDiagnostic(exDiag.ToMicrosoft());
                            Debug.WriteLine(ex);
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
            });
        }

    }
}
