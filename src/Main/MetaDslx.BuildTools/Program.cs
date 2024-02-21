using Antlr4.Runtime;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Parsers.Antlr;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Text;
#if MetaDslxBootstrap
using MetaDslx.Bootstrap.MetaCompiler2.Compiler;
using MetaDslx.Bootstrap.MetaCompiler2.Model;
#else
using MetaDslx.Languages.MetaCompiler.Compiler;
using MetaDslx.Languages.MetaCompiler.Model;
#endif
using MetaDslx.Languages.MetaGenerator.Syntax;
using MetaDslx.Languages.MetaModel.Compiler;
using MetaDslx.Languages.MetaModel.Generators;
using MetaDslx.Languages.MetaSymbols.Compiler;
using MetaDslx.Languages.MetaSymbols.Generators;
using MetaDslx.Modeling;
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
#if MetaDslxBootstrap
    using MetaCompiler = MetaDslx.Bootstrap.MetaCompiler2;
#else
    using MetaCompiler = MetaDslx.Languages.MetaCompiler;
#endif

    public class Program
    {
        private const bool GenerateSeparateMetaModelFiles = true;
        private const bool EraseOutputDirectory = true;
        private static readonly string[] BootstrapProjects =
        [
#if MetaDslxBootstrap
            //@"..\..\..\..\MetaDslx.Languages.MetaModel",
            @"..\..\..\..\..\Bootstrap\MetaDslx.Bootstrap.MetaCompiler3"
#else
            //@"..\..\..\..\MetaDslx.CodeAnalysis.Common",
            //@"..\..\..\..\MetaDslx.Languages.MetaSymbols",
            //@"..\..\..\..\MetaDslx.Languages.MetaModel",
            //@"..\..\..\..\MetaDslx.Languages.MetaCompiler",
            @"..\..\..\..\..\Bootstrap\MetaDslx.Bootstrap.MetaCompiler3"
            //@"..\..\..\..\..\Languages\MetaDslx.Languages.Mof",
            //@"..\..\..\..\..\Languages\MetaDslx.Languages.Uml",
            //@"..\..\..\..\..\Languages\MetaDslx.Languages.Emf",
#endif
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
            if (BootstrapProjects.Length > 0)
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
                var mxsFiles = project.AdditionalDocuments.Where(doc => Path.GetExtension(doc.FilePath) == ".mxs").ToImmutableArray();
                /*/
                foreach (var mxgFile in mxgFiles)
                {
                    await CompileMetaGenerator(mxgFile);
                }
                //*/
                var compilation = await project.GetCompilationAsync() as CSharpCompilation;
                if (compilation is not null)
                {
                    compilation = compilation.AddReferences(PackageReferences);
                    //await CompileMetaSymbols(compilation, mxsFiles);
                    await CompileMetaModels(compilation, mxmFiles);
                    //await CompileMetaLanguages(compilation, mxlFiles);
                }
                //*/
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


        private static async Task CompileMetaSymbols(CSharpCompilation initialCompilation, ImmutableArray<Microsoft.CodeAnalysis.TextDocument> mxsFiles)
        {
            var filePaths = ArrayBuilder<string>.GetInstance();
            foreach (var mxsFile in mxsFiles)
            {
                var filePath = mxsFile.FilePath;
                if (File.Exists(filePath))
                {
                    filePaths.Add(filePath);
                    var outputDir = Path.Combine(Path.GetDirectoryName(filePath), "Generated");
                    Directory.CreateDirectory(outputDir);
                    if (EraseOutputDirectory)
                    {
                        var dirInfo = new DirectoryInfo(outputDir);
                        foreach (FileInfo file in dirInfo.EnumerateFiles())
                        {
                            file.Delete();
                        }
                        foreach (DirectoryInfo dir in dirInfo.EnumerateDirectories())
                        {
                            dir.Delete(true);
                        }
                    }
                }
                else
                {
                    await Console.Out.WriteLineAsync($"{filePath}(1,1,1,1): error: File '{filePath}' does not exist.");
                }
            }
            if (filePaths.Count == 0) return;
            try
            {
                var mxsTrees = ArrayBuilder<SyntaxTree>.GetInstance();
                foreach (var filePath in filePaths)
                {
                    var mxsCode = await File.ReadAllTextAsync(filePath);
                    var mxsTree = SymbolSyntaxTree.ParseText(mxsCode, path: filePath);
                    mxsTrees.Add(mxsTree);
                }
                var mxsCompiler = Compilation.Create("Meta",
                                syntaxTrees: mxsTrees,
                                initialCompilation: initialCompilation,
                                references: new[]
                                {
                                    MetadataReference.CreateFromMetaModel(MetaDslx.Languages.MetaSymbols.Model.Symbols.MInstance)
                                },
                                options: CompilationOptions.Default.WithConcurrentBuild(false));
                mxsCompiler.Compile();
                var diagnostics = mxsCompiler.GetDiagnostics();
                var mxsDiagnostics = diagnostics.Where(diag => filePaths.Contains(diag.Location?.GetLineSpan().Path ?? string.Empty)).ToImmutableArray();
                foreach (var diag in mxsDiagnostics)
                {
                    await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
                }
                var model = mxsCompiler.SourceModule.Model;
                var generator = new SymbolGenerator();
                foreach (var symbol in model.Objects.OfType<MetaDslx.Languages.MetaSymbols.Model.Symbol>())
                {
                    var modelFilePath = symbol.MSourceLocation?.GetLineSpan().Path;
                    //var xmi = new XmiSerializer();
                    //xmi.WriteModelToFile(Path.Combine(modelFilePath + ".xmi"), model);
                    if (!mxsDiagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error && diag.Location?.GetLineSpan().Path == modelFilePath))
                    {
                        await GenerateMetaSymbolFiles(generator, modelFilePath, symbol);
                    }
                }
                var genDiagnostics = generator.Diagnostics;
                foreach (var diag in genDiagnostics)
                {
                    await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
                }
                mxsTrees.Free();
            }
            catch (Exception ex)
            {
                var exLocation = ExternalFileLocation.Create(filePaths[0], TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                var exDiag = Diagnostic.Create(ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
                await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(exDiag));
            }
            filePaths.Free();
        }

        private static async Task GenerateMetaSymbolFiles(SymbolGenerator generator, string originalFilePath, MetaDslx.Languages.MetaSymbols.Model.Symbol symbol)
        {
            if (symbol.FullName == "MetaDslx.CodeAnalysis.Symbols.Symbol") return;
            var implDir = Path.Combine(Path.GetDirectoryName(originalFilePath), "Custom");
            Directory.CreateDirectory(implDir);
            var outputDir = Path.Combine(Path.GetDirectoryName(originalFilePath), "Generated");
            Directory.CreateDirectory(outputDir);
            var intfCode = generator.GenerateInterface(symbol);
            await AddGeneratedFile(Path.Combine(outputDir, $"{symbol.Name}Symbol.cs"), intfCode);
            var baseCode = generator.GenerateBase(symbol);
            await AddGeneratedFile(Path.Combine(outputDir, $"{symbol.Name}SymbolBase.cs"), baseCode);
            var implCode = generator.GenerateImplementation(symbol);
            await AddGeneratedFile(Path.Combine(implDir, $"{symbol.Name}Symbol.cs"), implCode, overwrite: false);
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
                    //var xmi = new XmiSerializer();
                    //xmi.WriteModelToFile(Path.Combine(modelFilePath + ".xmi"), model);
                    if (!mxmDiagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error && diag.Location?.GetLineSpan().Path == modelFilePath))
                    {
                        var isMetaMetaModel = modelFilePath?.Contains("MetaDslx.Languages.MetaModel") ?? false;
                        var generator = new MetaModelGenerator(isMetaMetaModel, model, mxm);
                        var genDiagnostics = generator.Diagnostics;
                        if (!genDiagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error))
                        {
                            if (GenerateSeparateMetaModelFiles)
                            {
                                await GenerateMetaModelFiles(generator, modelFilePath);
                                genDiagnostics = generator.Diagnostics;
                            }
                            else
                            {
                                var csharpCode = generator.Generate();
                                var csharpFilePath = $"{modelFilePath}.cs";
                                genDiagnostics = generator.Diagnostics;
                                if (!genDiagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error))
                                {
                                    await AddGeneratedFile(csharpFilePath, csharpCode);
                                }
                            }
                        }
                        foreach (var diag in genDiagnostics)
                        {
                            await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
                        }
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

        private static async Task GenerateMetaModelFiles(MetaModelGenerator generator, string originalFilePath)
        {
            var outputDir = Path.Combine(Path.GetDirectoryName(originalFilePath), "Generated");
            Directory.CreateDirectory(outputDir);
            if (EraseOutputDirectory)
            {
                var dirInfo = new DirectoryInfo(outputDir);
                foreach (FileInfo file in dirInfo.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in dirInfo.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
            }
            var metaModelCode = generator.GenerateSeparateIntf(generator.GenerateMetaModel());
            await AddGeneratedFile(Path.Combine(outputDir, $"{generator.MetaModel.Name}.cs"), metaModelCode);
            var modelFactoryCode = generator.GenerateSeparateIntf(generator.GenerateFactory());
            await AddGeneratedFile(Path.Combine(outputDir, $"{generator.MetaModel.Name}ModelFactory.cs"), modelFactoryCode);
            var customIntfCode = generator.GenerateSeparateIntf(generator.GenerateCustomInterface());
            await AddGeneratedFile(Path.Combine(outputDir, $"ICustom{generator.MetaModel.Name}Implementation.cs"), customIntfCode);
            var customImplCode = generator.GenerateSeparateIntf(generator.GenerateCustomImplementation());
            await AddGeneratedFile(Path.Combine(outputDir, $"Custom{generator.MetaModel.Name}ImplementationBase.cs"), customImplCode);
            foreach (var enm in generator.Enums)
            {
                var enumCode = generator.GenerateSeparateIntf(generator.GenerateEnum(enm));
                await AddGeneratedFile(Path.Combine(outputDir, $"{enm.Name}.cs"), enumCode);
            }
            foreach (var cls in generator.Classes)
            {
                var clsCode = generator.GenerateSeparateIntf(generator.GenerateInterface(cls));
                await AddGeneratedFile(Path.Combine(outputDir, $"{cls.Name}.cs"), clsCode);
            }
            foreach (var enm in generator.Enums)
            {
                var enumCode = generator.GenerateSeparateImpl(generator.GenerateEnumInfo(enm));
                await AddGeneratedFile(Path.Combine(outputDir, $"{enm.Name}.Impl.cs"), enumCode);
            }
            foreach (var cls in generator.Classes)
            {
                var clsCode = generator.GenerateSeparateImpl(generator.GenerateClass(cls));
                await AddGeneratedFile(Path.Combine(outputDir, $"{cls.Name}.Impl.cs"), clsCode);
            }
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
                    var mxlCode = new StringBuilder();
                    var inheritsFromCommon = false;
                    using (var reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = await reader.ReadLineAsync();
                            if (line == null) break;
                            mxlCode.AppendLine(line);
                            if (line.Contains("language") && line.Contains(":") && (line.Contains("Common") || line.Contains("CommonLanguage")))
                            {
                                inheritsFromCommon = true;
                            }
                        }
                    }
                    if (inheritsFromCommon)
                    {
                        mxlCode.AppendLine(CommonLanguage.Rules);
                    }
                    var mxlTree = CompilerSyntaxTree.ParseText(mxlCode.ToString(), path: filePath);
                    mxlTrees.Add(mxlTree);
                }
                var mxlCompiler = Compilation.Create("Meta",
                                syntaxTrees: mxlTrees,
                                initialCompilation: initialCompilation,
                                references: new[]
                                {
#if MetaDslxBootstrap
                                    MetadataReference.CreateFromMetaModel(MetaDslx.Bootstrap.MetaCompiler2.Model.Compiler.MInstance)
#else
                                    MetadataReference.CreateFromMetaModel(MetaDslx.Languages.MetaCompiler.Model.Compiler.MInstance)
#endif
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
                var languages = model.Objects.OfType<MetaCompiler.Model.Language>().ToImmutableArray();
                foreach (var language in languages)
                {
                    var modelFilePath = language.MSourceLocation?.GetLineSpan().Path;
                    //var xmi = new XmiSerializer();
                    //xmi.WriteModelToFile(Path.Combine(Path.Combine(Path.GetDirectoryName(modelFilePath), "Generated"), Path.GetFileNameWithoutExtension(modelFilePath) + ".Raw.xmi"), language.MModel);
                    if (!mxlDiagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error && diag.Location?.GetLineSpan().Path == modelFilePath))
                    {
                        var pp = new CompilerModelPostProcessor(language);
                        pp.Execute(default);
                        var ppDiagnostics = pp.GetDiagnostics();
                        foreach (var diag in ppDiagnostics)
                        {
                            await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
                        }
                        if (!ppDiagnostics.Any(diag => diag.Severity == DiagnosticSeverity.Error))
                        {
                            await GenerateCompilerFiles(language, modelFilePath);
                        }
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

        private static async Task GenerateCompilerFiles(MetaCompiler.Model.Language language, string originalFilePath)
        {
            var outputDir = Path.Combine(Path.GetDirectoryName(originalFilePath), "Generated");
            var langFileName = Path.GetFileNameWithoutExtension(originalFilePath);
            Directory.CreateDirectory(outputDir);
            //var xmi = new XmiSerializer();
            //xmi.WriteModelToFile(Path.Combine(outputDir, langFileName + ".xmi"), language.MModel);
            var generator = new MetaCompiler.Generators.RoslynApiGenerator(language);
            var antlrDiagnostics = MetaDslx.CodeAnalysis.DiagnosticBag.GetInstance();
            var antlrCodes = generator.GenerateAntlr(originalFilePath, antlrDiagnostics, default);
            if (antlrDiagnostics.HasAnyErrors())
            {
                foreach (var diag in antlrDiagnostics.ToReadOnly())
                {
                    await Console.Out.WriteLineAsync(DiagnosticFormatter.MSBuild.Format(diag));
                }
                foreach (var antlrCode in antlrCodes.Where(ac => ac.FileName.EndsWith(".g4")))
                {
                    await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.{antlrCode.FileName}"), antlrCode.Content);
                }
            }
            else
            {
                if (EraseOutputDirectory)
                {
                    var dirInfo = new DirectoryInfo(outputDir);
                    foreach (FileInfo file in dirInfo.EnumerateFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in dirInfo.EnumerateDirectories())
                    {
                        dir.Delete(true);
                    }
                }
                foreach (var antlrCode in antlrCodes)
                {
                    await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.{antlrCode.FileName}"), antlrCode.Content);
                }
                var languageCode = generator.GenerateLanguage();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.Language.g.cs"), languageCode);
                var languageVersionCode = generator.GenerateLanguageVersion();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.LanguageVersion.g.cs"), languageVersionCode);
                var parseOptionsCode = generator.GenerateParseOptions();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.ParseOptions.g.cs"), parseOptionsCode);
                var syntaxKindCode = generator.GenerateSyntaxKind();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.SyntaxKind.g.cs"), syntaxKindCode);
                var syntaxFactsCode = generator.GenerateSyntaxFacts();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.SyntaxFacts.g.cs"), syntaxFactsCode);
                var internalSyntaxCode = generator.GenerateInternalSyntax();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.InternalSyntax.g.cs"), internalSyntaxCode);
                var internalSyntaxVisitorCode = generator.GenerateInternalSyntaxVisitor();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.InternalSyntaxVisitor.g.cs"), internalSyntaxVisitorCode);
                var internalSyntaxFactoryCode = generator.GenerateInternalSyntaxFactory();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.InternalSyntaxFactory.g.cs"), internalSyntaxFactoryCode);
                var syntaxCode = generator.GenerateSyntax();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.Syntax.g.cs"), syntaxCode);
                var syntaxTreeCode = generator.GenerateSyntaxTree();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.SyntaxTree.g.cs"), syntaxTreeCode);
                var syntaxVisitorCode = generator.GenerateSyntaxVisitor();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.SyntaxVisitor.g.cs"), syntaxVisitorCode);
                var syntaxFactoryCode = generator.GenerateSyntaxFactory();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.SyntaxFactory.g.cs"), syntaxFactoryCode);
                var binderFactoryVisitorCode = generator.GenerateBinderFactoryVisitor();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.BinderFactoryVisitor.g.cs"), binderFactoryVisitorCode);
                var semanticsFactoryCode = generator.GenerateSemanticsFactory();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.SemanticsFactory.g.cs"), semanticsFactoryCode);
                var compilationFactoryCode = generator.GenerateCompilationFactory();
                await AddGeneratedFile(Path.Combine(outputDir, $"{langFileName}.CompilationFactory.g.cs"), compilationFactoryCode);
            }
            antlrDiagnostics.Free();
        }

        private static async Task AddGeneratedFile(string filePath, string content, bool overwrite = true)
        {
            if (overwrite || !File.Exists(filePath))
            {
                await File.WriteAllTextAsync(filePath, content);
                await Console.Out.WriteLineAsync($"generated file: {filePath}");
            }
        }
    }
}

