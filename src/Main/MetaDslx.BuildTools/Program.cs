using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaGenerator.Syntax;
using MetaDslx.Languages.MetaModel.Compiler;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.MSBuild;
using System.Collections.Immutable;
using System.Diagnostics;

namespace MetaDslx.BuildTools
{

    public class Program
    {
        private const bool Bootstrap = true;
        private static readonly string[] BootstrapProjects =
        [
            @"..\..\..\..\MetaDslx.Languages.MetaModel"
        ];

        public static async Task Main(string[] args)
        {
            MSBuildLocator.RegisterDefaults();
            await Console.Out.WriteLineAsync($"Current directory is: {Directory.GetCurrentDirectory()}");
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
                var mgenFiles = project.AdditionalDocuments.Where(doc => Path.GetExtension(doc.FilePath) == ".mgen").ToImmutableArray();
                var mmFiles = project.AdditionalDocuments.Where(doc => Path.GetExtension(doc.FilePath) == ".mm").ToImmutableArray();
                var mlangFiles = project.AdditionalDocuments.Where(doc => Path.GetExtension(doc.FilePath) == ".mlang").ToImmutableArray();
                foreach (var mgenFile in mgenFiles)
                {
                    await CompileMetaGenerator(mgenFile);
                }
                var compilation = await project.GetCompilationAsync() as CSharpCompilation;
                if (compilation is not null)
                {
                    await CompileMetaModels(compilation, mmFiles);
                }
                // Perform analysis...
            }
        }

        private static async Task CompileMetaGenerator(Microsoft.CodeAnalysis.TextDocument mgenFile)
        {
            var filePath = mgenFile.FilePath;
            if (!File.Exists(filePath)) 
            {
                await Console.Out.WriteLineAsync($"{filePath}(1,1,1,1): error: File '{filePath}' does not exist.");
                return;
            }
            try
            {
                var csharpFilePath = filePath + ".cs";
                var mgenCode = await File.ReadAllTextAsync(filePath);
                var mgenCompiler = new MetaGeneratorParser(filePath, SourceText.From(mgenCode));
                var csharpCode = mgenCompiler.Compile();
                if (mgenCompiler.Diagnostics.Length > 0)
                {
                    foreach (var diag in mgenCompiler.Diagnostics)
                    {
                        await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
                    }
                }
                if (!mgenCompiler.Diagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error))
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

        private static async Task CompileMetaModels(CSharpCompilation initialCompilation, ImmutableArray<Microsoft.CodeAnalysis.TextDocument> mmFiles)
        {
            var filePaths = ArrayBuilder<string>.GetInstance();
            foreach (var mmFile in mmFiles)
            {
                var filePath = mmFile.FilePath;
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
                var mmTrees = ArrayBuilder<SyntaxTree>.GetInstance();
                foreach (var filePath in filePaths)
                {
                    var mmCode = await File.ReadAllTextAsync(filePath);
                    var mmTree = MetaSyntaxTree.ParseText(mmCode, path: filePath);
                    mmTrees.Add(mmTree);
                }
                var mmCompiler = Compilation.Create("Meta",
                                syntaxTrees: mmTrees,
                                initialCompilation: initialCompilation,
                                references: new[]
                                {
                                    MetaDslx.CodeAnalysis.MetadataReference.CreateFromMetaModel(MetaDslx.Languages.MetaModel.Model.Meta.MInstance)
                                },
                                options: MetaDslx.CodeAnalysis.CompilationOptions.Default.WithConcurrentBuild(false));
                mmCompiler.Compile();
                var diagnostics = mmCompiler.GetDiagnostics();
                if (diagnostics.Length > 0)
                {
                    foreach (var diag in diagnostics)
                    {
                        await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
                    }
                }
                if (!diagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error))
                {
                    var model = mmCompiler.SourceModule.Model;
                    foreach (var mm in model.Objects.OfType<MetaDslx.Languages.MetaModel.Model.MetaModel>())
                    {
                        var generator = new MetaDslx.Languages.MetaModel.Generators.MetaModelGenerator(Bootstrap, model, mm);
                        var csharpCode = generator.Generate();
                        var csharpFilePath = $"{mm.MSourceLocation?.GetLineSpan().Path}.cs";
                        await AddGeneratedFile(csharpFilePath, csharpCode);
                    }
                }
                mmTrees.Free();
            }
            catch (Exception ex)
            {
                var exLocation = ExternalFileLocation.Create(filePaths[0], TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                var exDiag = Diagnostic.Create(ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
                await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(exDiag));
            }
            filePaths.Free();
        }

        private static async Task AddGeneratedFile(string filePath, string content)
        {
            await File.WriteAllTextAsync(filePath, content);
            await Console.Out.WriteLineAsync($"generated file: {filePath}");
        }
    }
}

