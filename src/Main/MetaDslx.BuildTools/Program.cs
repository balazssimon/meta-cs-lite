using Antlr4.Runtime;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Parsers.Antlr;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Text;
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
                    compilation = compilation.AddReferences(PackageReferences);
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
                foreach (var diag in mgenCompiler.Diagnostics)
                {
                    await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
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
                                    MetadataReference.CreateFromMetaModel(MetaDslx.Languages.MetaModel.Model.Meta.MInstance)
                                },
                                options: CompilationOptions.Default.WithConcurrentBuild(false));
                mmCompiler.Compile();
                var diagnostics = mmCompiler.GetDiagnostics();
                var mmDiagnostics = diagnostics.Where(diag => filePaths.Contains(diag.Location?.GetLineSpan().Path ?? string.Empty)).ToImmutableArray();
                foreach (var diag in mmDiagnostics)
                {
                    await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
                }
                var model = mmCompiler.SourceModule.Model;
                foreach (var mm in model.Objects.OfType<MetaDslx.Languages.MetaModel.Model.MetaModel>())
                {
                    var modelFilePath = mm.MSourceLocation?.GetLineSpan().Path;
                    if (!mmDiagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error && diag.Location?.GetLineSpan().Path == modelFilePath))
                    {
                        var generator = new MetaDslx.Languages.MetaModel.Generators.MetaModelGenerator(Bootstrap, model, mm);
                        var csharpCode = generator.Generate();
                        var csharpFilePath = $"{modelFilePath}.cs";
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

