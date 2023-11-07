
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
//using MetaDslx.Bootstrap.MetaModel.Core;
using MetaDslx.Languages.MetaModel.Model;

Compilation inputCompilation = CreateCompilation(@"
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

var mmCode = File.ReadAllText(@"..\..\..\Hello.mm");
var mmLang = new AdditionalTextFile("Hello.mm", mmCode);

driver = driver.AddAdditionalTexts(ImmutableArray.Create<AdditionalText>(mmLang));
driver = driver.RunGeneratorsAndUpdateCompilation(inputCompilation, out var outputCompilation, out var diagnostics);
GeneratorDriverRunResult runResult = driver.GetRunResult();
Console.WriteLine(runResult.GeneratedTrees.Length);
foreach (var diag in runResult.Diagnostics)
{
    Console.WriteLine(diag);
}
//var outputDir = @"..\..\..\..\MetaDslx.Bootstrap.MetaModel\Compiler";
//var outputDir = @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Compiler";
var outputDir = @"..\..\..";
foreach (var tree in runResult.GeneratedTrees)
{
    File.WriteAllText(Path.Combine(outputDir, Path.GetFileName(tree.FilePath)), tree.GetText().ToString());
}

static Compilation CreateCompilation(string source)
    => CSharpCompilation.Create("Hello",
        new[] { CSharpSyntaxTree.ParseText(source) },
        new[]
        {
            MetadataReference.CreateFromFile(typeof(object).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(List<>).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Attribute).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Binder).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(CodeBuilder).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(MetaDslx.CodeAnalysis.SyntaxTree).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(MetaModel).GetTypeInfo().Assembly.Location),
        },
        new CSharpCompilationOptions(OutputKind.ConsoleApplication));