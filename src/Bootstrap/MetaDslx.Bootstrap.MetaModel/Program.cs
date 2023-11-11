﻿
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

//CompileMetaModel("Meta", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Model", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Model");
//CompileMetaCompiler("Meta", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Language", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Compiler");
//CompileMetaModel("Compiler", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Model", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Model");
//CompileMetaCompiler("Compiler", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Language", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Compiler");
//CompileWithMetaCompiler("Meta", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Language", @"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Compiler", Meta.MInstance);
CompileWithMetaCompiler("Compiler2", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Language", @"..\..\..\..\MetaDslx.Bootstrap.MetaCompiler\Compiler", MetaDslx.Bootstrap.MetaCompiler.Model.Compiler.MInstance);

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
    mlangCompilation.Compile();
    foreach (var diag in mlangCompilation.GetDiagnostics())
    {
        Console.WriteLine(diag);
    }
}

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
