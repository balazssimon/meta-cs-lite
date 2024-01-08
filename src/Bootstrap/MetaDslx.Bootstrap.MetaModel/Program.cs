
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Antlr.Analyzers;
using MetaDslx.Languages.MetaCompiler.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Reflection.Emit;
using System.Collections.Immutable;
using System.Reflection;
using MetaDslx.Languages.MetaCompiler.Analyzers;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using MetaDslx.Languages.MetaModel.Model;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Bootstrap.MetaCompiler.Model;
using MetaDslx.Modeling;

//CompileMetaModel("Meta", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Model", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Model");
//CompileMetaCompiler("Meta", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Language", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Compiler");
//CompileWithMetaCompiler("Meta", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Language", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Compiler", Meta.MInstance);

//CompileMetaModel("Compiler", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Model", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Model");
//CompileMetaCompiler("Compiler", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Language", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Compiler");
CompileWithMetaCompiler("Compiler2", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Language", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Compiler2", MetaDslx.Bootstrap.MetaCompiler.Model.Compiler.MInstance);

//CompileMetaModel("Roslyn", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Model", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Model");

/*/
var model = Meta.MInstance.MModel;
var mc = model.Objects.OfType<MetaClass>().FirstOrDefault();
var mobj = mc as IModelObject;
mobj.Tag = "hello";
Console.WriteLine(mobj.Tag);
var decls = mc.Declarations;
var box = decls.BoxAt(0);
box.Tag = "box tag";
Console.WriteLine(box.Tag);
//*/

static void CompileMetaModel(string name, string inputDir, string outputDir)
{
    Compilation inputCompilation = CreateCompilation(name, @"
namespace MyCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
");
    var formatter = new DiagnosticFormatter();
    foreach (var diag in inputCompilation.GetDiagnostics())
    {
        Console.WriteLine(formatter.Format(diag));
    }
    var generator = new MetaModelSourceGenerator();
    GeneratorDriver driver = CSharpGeneratorDriver.Create(generator);

    var mmCode = File.ReadAllText(Path.Combine(inputDir, $"{name}.mm"));
    var mmLang = new AdditionalTextFile($"{name}.mm", mmCode);

    driver = driver.AddAdditionalTexts(ImmutableArray.Create<AdditionalText>(mmLang));
    driver = driver.RunGeneratorsAndUpdateCompilation(inputCompilation, out var outputCompilation, out var diagnostics);
    GeneratorDriverRunResult runResult = driver.GetRunResult();
    Console.WriteLine(runResult.GeneratedTrees.Length);
    foreach (var diag in runResult.Diagnostics)
    {
        Console.WriteLine(diag);
    }
    foreach (var tree in runResult.GeneratedTrees)
    {
        File.WriteAllText(Path.Combine(outputDir, Path.GetFileName(tree.FilePath)), tree.GetText().ToString());
    }
}

static void CompileMetaCompiler(string name, string inputDir, string outputDir)
{
    Compilation inputCompilation = CreateCompilation(name, @"
namespace MyCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
");
    var formatter = new DiagnosticFormatter();
    foreach (var diag in inputCompilation.GetDiagnostics())
    {
        Console.WriteLine(formatter.Format(diag));
    }
    var compilerGenerator = new MetaCompilerSourceGenerator();
    var antlrGenerator = new AntlrCompilerSourceGenerator();
    GeneratorDriver driver = CSharpGeneratorDriver.Create(compilerGenerator, antlrGenerator);

    var mmCode = File.ReadAllText(Path.Combine(inputDir, $"{name}.mlang"));
    var mmLang = new AdditionalTextFile($"{name}.mlang", mmCode);

    driver = driver.AddAdditionalTexts(ImmutableArray.Create<AdditionalText>(mmLang));
    driver = driver.RunGeneratorsAndUpdateCompilation(inputCompilation, out var outputCompilation, out var diagnostics);
    GeneratorDriverRunResult runResult = driver.GetRunResult();
    Console.WriteLine(runResult.GeneratedTrees.Length);
    foreach (var diag in runResult.Diagnostics)
    {
        Console.WriteLine(diag);
    }
    foreach (var tree in runResult.GeneratedTrees)
    {
        File.WriteAllText(Path.Combine(outputDir, Path.GetFileName(tree.FilePath)), tree.GetText().ToString());
    }
}
//*/
static void CompileWithMetaCompiler(string name, string inputDir, string outputDir, MetaDslx.Modeling.MetaModel metaModel)
{
    Compilation inputCompilation = CreateCompilation(name, @"
namespace MyCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
");
    var formatter = new DiagnosticFormatter();
    foreach (var diag in inputCompilation.GetDiagnostics())
    {
        Console.WriteLine(formatter.Format(diag));
    }
    var mlangCode = File.ReadAllText(Path.Combine(inputDir, $"{name}.mlang"));
    var mlangTree = MetaDslx.Bootstrap.MetaCompiler.Compiler.CompilerSyntaxTree.ParseText(mlangCode, path: $"{name}.mlang");
    var mlangCompilation = MetaDslx.CodeAnalysis.Compilation.Create(name, syntaxTrees: new[] { mlangTree }, initialCompilation: (CSharpCompilation)inputCompilation,
        references: new[] { MetaDslx.CodeAnalysis.MetadataReference.CreateFromMetaModel(metaModel) }, options: MetaDslx.CodeAnalysis.CompilationOptions.Default.WithConcurrentBuild(false));
    var rootBinder = mlangCompilation.GetRootBinder(mlangTree);
    rootBinder.CompleteBind(true);
    File.WriteAllText("../../../root-binder.txt", rootBinder.PrintBinderTree());
    mlangCompilation.Compile();
    var diags1 = mlangCompilation.GetDiagnostics();
    foreach (var diag in diags1)
    {
        Console.WriteLine(diag);
    }
    if (diags1.Where(d => d.Severity == MetaDslx.CodeAnalysis.DiagnosticSeverity.Error).Any()) return;
    var mlangModel = mlangCompilation.SourceModule.Model;
    var c2r = new CompilerModelPostProcessor(mlangModel);
    c2r.Execute(default);
    var diags2 = c2r.GetDiagnostics();
    foreach (var diag in diags2)
    {
        Console.WriteLine(diag);
    }
    if (diags2.Where(d => d.Severity == MetaDslx.CodeAnalysis.DiagnosticSeverity.Error).Any()) return;
    Console.WriteLine(mlangModel);
    var xmi = new XmiSerializer();
    xmi.WriteModelToFile($@"..\..\..\{name}.xmi", mlangModel);
    var language = mlangModel.Objects.OfType<MetaDslx.Bootstrap.MetaCompiler.Model.Language>().FirstOrDefault();
    var generator = new MetaDslx.Bootstrap.MetaCompiler.Generators.RoslynApiGenerator(language);
    var languageCode = generator.GenerateLanguage();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.Language.g.cs"), languageCode);
    var languageVersionCode = generator.GenerateLanguageVersion();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.LanguageVersion.g.cs"), languageVersionCode);
    var parseOptionsCode = generator.GenerateParseOptions();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.ParseOptions.g.cs"), parseOptionsCode);
    var syntaxKindCode = generator.GenerateSyntaxKind();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.SyntaxKind.g.cs"), syntaxKindCode);
    var syntaxFactsCode = generator.GenerateSyntaxFacts();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.SyntaxFacts.g.cs"), syntaxFactsCode);
    var internalSyntaxCode = generator.GenerateInternalSyntax();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.InternalSyntax.g.cs"), internalSyntaxCode);
    var internalSyntaxVisitorCode = generator.GenerateInternalSyntaxVisitor();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.InternalSyntaxVisitor.g.cs"), internalSyntaxVisitorCode);
    var internalSyntaxFactoryCode = generator.GenerateInternalSyntaxFactory();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.InternalSyntaxFactory.g.cs"), internalSyntaxFactoryCode);
    var syntaxCode = generator.GenerateSyntax();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.Syntax.g.cs"), syntaxCode);
    var syntaxTreeCode = generator.GenerateSyntaxTree();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.SyntaxTree.g.cs"), syntaxTreeCode);
    var syntaxVisitorCode = generator.GenerateSyntaxVisitor();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.SyntaxVisitor.g.cs"), syntaxVisitorCode);
    var syntaxFactoryCode = generator.GenerateSyntaxFactory();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.SyntaxFactory.g.cs"), syntaxFactoryCode);
    var binderFactoryVisitorCode = generator.GenerateBinderFactoryVisitor();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.BinderFactoryVisitor.g.cs"), binderFactoryVisitorCode);
    var semanticsFactoryCode = generator.GenerateSemanticsFactory();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.SemanticsFactory.g.cs"), semanticsFactoryCode);
    var compilationFactoryCode = generator.GenerateCompilationFactory();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.MetaCompiler.CompilationFactory.g.cs"), compilationFactoryCode);
    var antlrLexerCode = generator.GenerateLexer();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.Antlr.Lexer.g4"), antlrLexerCode);
    var antlrParserCode = generator.GenerateParser();
    File.WriteAllText(Path.Combine(outputDir, $"{name}.Antlr.Parser.g4"), antlrParserCode);
}
//*/
static void CompileAll(string mmName, string mmInputDir, string mmOutputDir, string mlangName, string mlangInputDir, string mlangOutputDir)
{
    Compilation mmInputCompilation = CreateCompilation(mmName, @"
namespace MyCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
");
    var formatter = new DiagnosticFormatter();
    foreach (var diag in mmInputCompilation.GetDiagnostics())
    {
        Console.WriteLine(formatter.Format(diag));
    }
    var mmGenerator = new MetaModelSourceGenerator();
    GeneratorDriver mmDriver = CSharpGeneratorDriver.Create(mmGenerator);

    var mmCode = File.ReadAllText(Path.Combine(mmInputDir, $"{mmName}.mm"));
    var mmFile = new AdditionalTextFile($"{mmName}.mm", mmCode);

    mmDriver = mmDriver.AddAdditionalTexts(ImmutableArray.Create<AdditionalText>(mmFile));
    mmDriver = mmDriver.RunGeneratorsAndUpdateCompilation(mmInputCompilation, out var mmOutputCompilation, out var mmDiagnostics);
    GeneratorDriverRunResult mmRunResult = mmDriver.GetRunResult();
    Console.WriteLine(mmRunResult.GeneratedTrees.Length);
    foreach (var diag in mmRunResult.Diagnostics)
    {
        Console.WriteLine(diag);
    }
    foreach (var tree in mmRunResult.GeneratedTrees)
    {
        File.WriteAllText(Path.Combine(mmOutputDir, Path.GetFileName(tree.FilePath)), tree.GetText().ToString());
    }

    var compilerGenerator = new MetaCompilerSourceGenerator();
    var antlrGenerator = new AntlrCompilerSourceGenerator();
    GeneratorDriver mlangDriver = CSharpGeneratorDriver.Create(compilerGenerator, antlrGenerator);

    var mlangCode = File.ReadAllText(Path.Combine(mlangInputDir, $"{mlangName}.mlang"));
    var mlangFile = new AdditionalTextFile($"{mlangName}.mlang", mlangCode);

    mlangDriver = mlangDriver.AddAdditionalTexts(ImmutableArray.Create<AdditionalText>(mlangFile));
    mlangDriver = mlangDriver.RunGeneratorsAndUpdateCompilation(mmOutputCompilation, out var mlangOutputCompilation, out var mlangDiagnostics);
    GeneratorDriverRunResult mlangRunResult = mlangDriver.GetRunResult();
    Console.WriteLine(mlangRunResult.GeneratedTrees.Length);
    foreach (var diag in mlangRunResult.Diagnostics)
    {
        Console.WriteLine(diag);
    }
    foreach (var tree in mlangRunResult.GeneratedTrees)
    {
        File.WriteAllText(Path.Combine(mlangOutputDir, Path.GetFileName(tree.FilePath)), tree.GetText().ToString());
    }
}

static Compilation CreateCompilation(string name, string source)
{
    return CSharpCompilation.Create(name,
        new[] { CSharpSyntaxTree.ParseText(source) },
        new[]
        {
            MetadataReference.CreateFromFile(typeof(object).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(List<>).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Attribute).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(MetaDslx.CodeGeneration.CodeBuilder).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(MetaDslx.Modeling.MetaModel).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(MetaDslx.CodeAnalysis.Compilation).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(MetaDslx.Languages.MetaModel.Model.MetaDeclaration).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(MetaDslx.Bootstrap.MetaCompiler.Model.Compiler).GetTypeInfo().Assembly.Location),
        },
        new CSharpCompilationOptions(OutputKind.ConsoleApplication));
}
