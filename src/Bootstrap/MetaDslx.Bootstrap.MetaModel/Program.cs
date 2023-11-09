
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Antlr.Analyzers;
using MetaDslx.Languages.MetaCompiler.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Reflection.Emit;
using System.Collections.Immutable;
using MetaDslx.CodeGeneration;
using System.Reflection;
using MetaDslx.Languages.MetaCompiler.Analyzers;
using System.Diagnostics.CodeAnalysis;
using MetaDslx.Languages.MetaModel.Model;
using MetaDslx.CodeAnalysis.Symbols;

//CompileMetaModel("Meta", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Model", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Model");
//CompileMetaCompiler("Meta", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Language", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Compiler");
CompileMetaModel("Compiler", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Model", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Model");

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

static Compilation CreateCompilation(string name, string source)
{
    return CSharpCompilation.Create(name,
        new[] { CSharpSyntaxTree.ParseText(source) },
        new[]
        {
            MetadataReference.CreateFromFile(typeof(object).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(List<>).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Attribute).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Symbol).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(CodeBuilder).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(MetaDslx.CodeAnalysis.SyntaxTree).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(MetaModel).GetTypeInfo().Assembly.Location),
        },
        new CSharpCompilationOptions(OutputKind.ConsoleApplication));
}
