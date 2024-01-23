using Antlr4.Runtime;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Parsers.Antlr;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Compiler;
using MetaDslx.Languages.MetaGenerator.Syntax;
using MetaDslx.Languages.MetaModel.Compiler;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.MSBuild;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.BuildTools
{

    public class Program
    {
        private const bool Bootstrap = true;
        private static readonly string[] BootstrapProjects =
        [
            //@"..\..\..\..\MetaDslx.Languages.MetaModel",
            //@"..\..\..\..\MetaDslx.Languages.MetaCompiler",
            //@"..\..\..\..\MetaDslx.Languages.MetaCompiler.Antlr",
            @"..\..\..\..\..\Bootstrap\MetaDslx.Bootstrap.MetaCompiler"
        ];
        private static Microsoft.CodeAnalysis.MetadataReference[] PackageReferences;

        public static async Task Main(string[] args)
        {
            MSBuildLocator.RegisterDefaults();
            await Console.Out.WriteLineAsync($"Current directory is: {Directory.GetCurrentDirectory()}");
            var coreLocation = typeof(object).GetTypeInfo().Assembly.Location;
            var coreDir = Directory.GetParent(coreLocation)?.FullName ?? RuntimeEnvironment.GetRuntimeDirectory();
            var netstandardPath = Path.Combine(coreDir, "netstandard.dll");
            var mscorlibPath = Path.Combine(coreDir, "mscorlib.dll");
            var systemRuntimePath = Path.Combine(coreDir, "System.Runtime.dll");
            var systemReflectionMetadataPath = Path.Combine(coreDir, "System.Reflection.Metadata.dll");
            var systemCorePath = Path.Combine(coreDir, "System.Core.dll");
            var systemMemoryPath = Path.Combine(coreDir, "System.Memory.dll");
            var systemBuffersPath = Path.Combine(coreDir, "System.Buffers.dll");
            var systemThreadingPath = Path.Combine(coreDir, "System.Threading.dll");
            var systemThreadingTasksPath = Path.Combine(coreDir, "System.Threading.Tasks.dll");
            var systemThreadingTasksExtensionsPath = Path.Combine(coreDir, "System.Threading.Tasks.Extensions.dll");
            var systemCollectionsPath = Path.Combine(coreDir, "System.Collections.dll");
            var systemCollectionsImmutablePath = Path.Combine(coreDir, "System.Collections.Immutable.dll");
            var systemLinqPath = Path.Combine(coreDir, "System.Linq.dll");
            var systemLinqExpressionsPath = Path.Combine(coreDir, "System.Linq.Expressions.dll");
            var systemLinqQueryablePath = Path.Combine(coreDir, "System.Linq.Queryable.dll");
            var systemTextEncodingCodePagesPath = Path.Combine(coreDir, "System.Text.Encoding.CodePages.dll");
            var systemRuntimeCompilerServicesUnsafePath = Path.Combine(coreDir, "System.Runtime.CompilerServices.Unsafe.dll");
            var systemDiagnosticsDiagnosticSourcePath = Path.Combine(coreDir, "System.Diagnostics.DiagnosticSource.dll");
            PackageReferences = [
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(netstandardPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(mscorlibPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemRuntimePath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemReflectionMetadataPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemCorePath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemMemoryPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemBuffersPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemThreadingPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemThreadingTasksPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemThreadingTasksExtensionsPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemCollectionsPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemCollectionsImmutablePath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemLinqPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemLinqExpressionsPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemLinqQueryablePath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemTextEncodingCodePagesPath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemRuntimeCompilerServicesUnsafePath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(systemDiagnosticsDiagnosticSourcePath),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(typeof(object).GetTypeInfo().Assembly.Location),
                //Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(typeof(Attribute).GetTypeInfo().Assembly.Location),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(typeof(Microsoft.CodeAnalysis.Compilation).GetTypeInfo().Assembly.Location),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(typeof(Microsoft.CodeAnalysis.CSharp.CSharpCompilation).GetTypeInfo().Assembly.Location),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(typeof(IToken).GetTypeInfo().Assembly.Location),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(typeof(AntlrParser).GetTypeInfo().Assembly.Location),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(typeof(Autofac.IContainer).GetTypeInfo().Assembly.Location),
                Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(typeof(DynamicAttribute).GetTypeInfo().Assembly.Location),
            ];
            if (Bootstrap)
            {
                foreach (string project in BootstrapProjects)
                {
                    await GenerateFiles(project);
                }
            }
            else
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                await GenerateFiles(currentDirectory);
            }
        }

        public static async Task GenerateFiles(string projectDirectory)
        {
            var directoryInfo = new DirectoryInfo(projectDirectory);
            if (!Directory.Exists(projectDirectory))
            {
                await Console.Out.WriteLineAsync($"ERROR: Directory '{projectDirectory}' does not exist.");
                return;
            }
            var csprojFiles = directoryInfo.GetFiles("*.csproj");
            if (csprojFiles.Length == 0)
            {
                await Console.Out.WriteLineAsync($"ERROR: No .csproj files found in '{projectDirectory}'.");
                return;
            }
            if (csprojFiles.Length >= 2)
            {
                await Console.Out.WriteLineAsync($"ERROR: More than .csproj files found in '{projectDirectory}'.");
                return;
            }
            var projectFile = Path.Combine(projectDirectory, csprojFiles[0].Name);
            using (var workspace = MSBuildWorkspace.Create())
            {
                var project = await workspace.OpenProjectAsync(projectFile);
                var mxgFiles = project.AdditionalDocuments.Where(doc => Path.GetExtension(doc.FilePath) == ".mxg").ToImmutableArray();
                var mxmFiles = project.AdditionalDocuments.Where(doc => Path.GetExtension(doc.FilePath) == ".mxm").ToImmutableArray();
                var mxlFiles = project.AdditionalDocuments.Where(doc => Path.GetExtension(doc.FilePath) == ".mxl").ToImmutableArray();
                /*foreach (var mxgFile in mxgFiles)
                {
                    await CompileMetaGenerator(mxgFile);
                }*/
                var compilation = await project.GetCompilationAsync() as CSharpCompilation;
                if (compilation is not null)
                {
                    compilation = compilation.AddReferences(PackageReferences);
                    //await CompileMetaModels(compilation, mxmFiles);
                    await CompileMetaLanguages(compilation, mxlFiles);
                }
                // Perform analysis...
            }
        }

        private static async Task CompileMetaGenerator(Microsoft.CodeAnalysis.TextDocument mxgFile)
        {
            var filePath = mxgFile.FilePath;
            if (!File.Exists(filePath)) 
            {
                await Console.Out.WriteLineAsync($"{filePath}(1,1,1,1): error: File '{filePath}' does not exist.");
                return;
            }
            try
            {
                var csharpFilePath = filePath + ".cs";
                var mxgCode = await File.ReadAllTextAsync(filePath);
                var mxgCompiler = new MetaGeneratorParser(filePath, SourceText.From(mxgCode));
                var csharpCode = mxgCompiler.Compile();
                foreach (var diag in mxgCompiler.Diagnostics)
                {
                    await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
                }
                if (!mxgCompiler.Diagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error))
                {
                    await AddGeneratedFile(csharpFilePath, csharpCode);
                }
            }
            catch (Exception ex)
            {
                var exLocation = ExternalFileLocation.Create(filePath, TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                var exDiag = Diagnostic.Create(ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
                await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(exDiag));
            }
        }

        private static async Task CompileMetaModels(CSharpCompilation initialCompilation, ImmutableArray<Microsoft.CodeAnalysis.TextDocument> mxmFiles)
        {
            var filePaths = ArrayBuilder<string>.GetInstance();
            foreach (var mxmFile in mxmFiles)
            {
                var filePath = mxmFile.FilePath;
                if (File.Exists(filePath))
                {
                    filePaths.Add(filePath);
                }
                else
                {
                    await Console.Out.WriteLineAsync($"{filePath}(1,1,1,1): error: File '{filePath}' does not exist.");
                }
            }
            if (filePaths.Count == 0) return;
            try
            {
                var mxmTrees = ArrayBuilder<SyntaxTree>.GetInstance();
                foreach (var filePath in filePaths)
                {
                    var mxmCode = await File.ReadAllTextAsync(filePath);
                    var mxmTree = MetaSyntaxTree.ParseText(mxmCode, path: filePath);
                    mxmTrees.Add(mxmTree);
                }
                var mxmCompiler = Compilation.Create("Meta",
                                syntaxTrees: mxmTrees,
                                initialCompilation: initialCompilation,
                                references: new[]
                                {
                                    MetadataReference.CreateFromMetaModel(MetaDslx.Languages.MetaModel.Model.Meta.MInstance)
                                },
                                options: CompilationOptions.Default.WithConcurrentBuild(false));
                mxmCompiler.Compile();
                var diagnostics = mxmCompiler.GetDiagnostics();
                var mxmDiagnostics = diagnostics.Where(diag => filePaths.Contains(diag.Location?.GetLineSpan().Path ?? string.Empty)).ToImmutableArray();
                foreach (var diag in mxmDiagnostics)
                {
                    await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
                }
                var model = mxmCompiler.SourceModule.Model;
                foreach (var mxm in model.Objects.OfType<MetaDslx.Languages.MetaModel.Model.MetaModel>())
                {
                    var modelFilePath = mxm.MSourceLocation?.GetLineSpan().Path;
                    if (!mxmDiagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error && diag.Location?.GetLineSpan().Path == modelFilePath))
                    {
                        var generator = new MetaDslx.Languages.MetaModel.Generators.MetaModelGenerator(Bootstrap, model, mxm);
                        var csharpCode = generator.Generate();
                        var csharpFilePath = $"{modelFilePath}.cs";
                        await AddGeneratedFile(csharpFilePath, csharpCode);
                    }
                }
                mxmTrees.Free();
            }
            catch (Exception ex)
            {
                var exLocation = ExternalFileLocation.Create(filePaths[0], TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                var exDiag = Diagnostic.Create(ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
                await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(exDiag));
            }
            filePaths.Free();
        }

        private static async Task CompileMetaLanguages(CSharpCompilation initialCompilation, ImmutableArray<Microsoft.CodeAnalysis.TextDocument> mxlFiles)
        {
            var filePaths = ArrayBuilder<string>.GetInstance();
            foreach (var mxlFile in mxlFiles)
            {
                var filePath = mxlFile.FilePath;
                if (File.Exists(filePath))
                {
                    filePaths.Add(filePath);
                }
                else
                {
                    await Console.Out.WriteLineAsync($"{filePath}(1,1,1,1): error: File '{filePath}' does not exist.");
                }
            }
            if (filePaths.Count == 0) return;
            try
            {
                var mxlTrees = ArrayBuilder<SyntaxTree>.GetInstance();
                foreach (var filePath in filePaths)
                {
                    var mxlCode = await File.ReadAllTextAsync(filePath);
                    var mxlTree = CompilerSyntaxTree.ParseText(mxlCode, path: filePath);
                    mxlTrees.Add(mxlTree);
                }
                var mxlCompiler = Compilation.Create("Meta",
                                syntaxTrees: mxlTrees,
                                initialCompilation: initialCompilation,
                                references: new[]
                                {
                                    MetadataReference.CreateFromMetaModel(MetaDslx.Languages.MetaCompiler.Model.Compiler.MInstance)
                                },
                                options: CompilationOptions.Default.WithConcurrentBuild(false));
                mxlCompiler.Compile();
                var diagnostics = mxlCompiler.GetDiagnostics();
                var mxlDiagnostics = diagnostics.Where(diag => filePaths.Contains(diag.Location?.GetLineSpan().Path ?? string.Empty)).ToImmutableArray();
                foreach (var diag in mxlDiagnostics)
                {
                    await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
                }
                var model = mxlCompiler.SourceModule.Model;
                foreach (var language in model.Objects.OfType<MetaDslx.Languages.MetaCompiler.Model.Language>())
                {
                    var modelFilePath = language.MSourceLocation?.GetLineSpan().Path;
                    if (!mxlDiagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error && diag.Location?.GetLineSpan().Path == modelFilePath))
                    {
                        await GenerateCompilerFiles(modelFilePath, language);
                    }
                }
                mxlTrees.Free();
            }
            catch (Exception ex)
            {
                var exLocation = ExternalFileLocation.Create(filePaths[0], TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                var exDiag = Diagnostic.Create(ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
                await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(exDiag));
            }
            filePaths.Free();
        }

        private static async Task GenerateCompilerFiles(string originalFilePath, MetaDslx.Languages.MetaCompiler.Model.Language language)
        {
            var generator = new MetaDslx.Languages.MetaCompiler.Generators.RoslynApiGenerator(language);
            var languageCode = generator.GenerateLanguage();
            File.WriteAllText($"{originalFilePath}.Language.g.cs", languageCode);
            var languageVersionCode = generator.GenerateLanguageVersion();
            File.WriteAllText($"{originalFilePath}.LanguageVersion.g.cs", languageVersionCode);
            var parseOptionsCode = generator.GenerateParseOptions();
            File.WriteAllText($"{originalFilePath}.ParseOptions.g.cs", parseOptionsCode);
            var syntaxKindCode = generator.GenerateSyntaxKind();
            File.WriteAllText($"{originalFilePath}.SyntaxKind.g.cs", syntaxKindCode);
            var syntaxFactsCode = generator.GenerateSyntaxFacts();
            File.WriteAllText($"{originalFilePath}.SyntaxFacts.g.cs", syntaxFactsCode);
            var internalSyntaxCode = generator.GenerateInternalSyntax();
            File.WriteAllText($"{originalFilePath}.InternalSyntax.g.cs", internalSyntaxCode);
            var internalSyntaxVisitorCode = generator.GenerateInternalSyntaxVisitor();
            File.WriteAllText($"{originalFilePath}.InternalSyntaxVisitor.g.cs", internalSyntaxVisitorCode);
            var internalSyntaxFactoryCode = generator.GenerateInternalSyntaxFactory();
            File.WriteAllText($"{originalFilePath}.InternalSyntaxFactory.g.cs", internalSyntaxFactoryCode);
            var syntaxCode = generator.GenerateSyntax();
            File.WriteAllText($"{originalFilePath}.Syntax.g.cs", syntaxCode);
            var syntaxTreeCode = generator.GenerateSyntaxTree();
            File.WriteAllText($"{originalFilePath}.SyntaxTree.g.cs", syntaxTreeCode);
            var syntaxVisitorCode = generator.GenerateSyntaxVisitor();
            File.WriteAllText($"{originalFilePath}.SyntaxVisitor.g.cs", syntaxVisitorCode);
            var syntaxFactoryCode = generator.GenerateSyntaxFactory();
            File.WriteAllText($"{originalFilePath}.SyntaxFactory.g.cs", syntaxFactoryCode);
            var binderFactoryVisitorCode = generator.GenerateBinderFactoryVisitor();
            File.WriteAllText($"{originalFilePath}.BinderFactoryVisitor.g.cs", binderFactoryVisitorCode);
            var semanticsFactoryCode = generator.GenerateSemanticsFactory();
            File.WriteAllText($"{originalFilePath}.SemanticsFactory.g.cs", semanticsFactoryCode);
            var compilationFactoryCode = generator.GenerateCompilationFactory();
            File.WriteAllText($"{originalFilePath}.CompilationFactory.g.cs", compilationFactoryCode);
            var antlrDiagnostics = MetaDslx.CodeAnalysis.DiagnosticBag.GetInstance();
            var antlrCodes = generator.GenerateAntlr(originalFilePath, antlrDiagnostics, default);
            if (antlrDiagnostics.HasAnyErrors())
            {
                foreach (var diag in antlrDiagnostics.ToReadOnly())
                {
                    Console.WriteLine(diag);
                }
            }
            else
            {
                foreach (var antlrCode in antlrCodes)
                {
                    File.WriteAllText($"{originalFilePath}.{antlrCode.FileName}", antlrCode.Content);
                }
            }
            antlrDiagnostics.Free();
        }

        private static async Task AddGeneratedFile(string filePath, string content)
        {
            await File.WriteAllTextAsync(filePath, content);
            await Console.Out.WriteLineAsync($"generated file: {filePath}");
        }
    }
}

