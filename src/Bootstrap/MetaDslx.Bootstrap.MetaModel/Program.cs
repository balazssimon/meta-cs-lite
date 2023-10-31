// See https://aka.ms/new-console-template for more information
using MetaDslx.Bootstrap.MetaModel;
using MetaDslx.Bootstrap.MetaModel.Compiler;
using MetaDslx.Bootstrap.MetaModel.Core;
using MetaDslx.Bootstrap.MetaModel.Generators;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Text;

Console.WriteLine("Hello, World!");

var code = File.ReadAllText(@"..\..\..\Core\MetaCore.mm");
var syntaxTree = MetaCoreSyntaxTree.ParseText(SourceText.From(code), path: "MetaCore.mm");

Console.WriteLine("----");
var syntaxTreeDiagnostics = syntaxTree.GetDiagnostics().ToList();
foreach (var diag in syntaxTreeDiagnostics)
{
    Console.WriteLine(diag);
}
if (syntaxTreeDiagnostics.Count > 0) return;

var cmp = Compilation.Create("MetaCore", 
    syntaxTrees: new[] { syntaxTree }, 
    references: new[] 
    { 
        MetadataReference.CreateFromMetaModel(MetaDslx.Modeling.ReflectionMetaModel.CreateFromNamespace(typeof(MetaModel).Assembly, "MetaDslx.Bootstrap.MetaModel.Core")),
        MetadataReference.CreateFromFile(typeof(string).Assembly.Location),
        MetadataReference.CreateFromFile(typeof(Symbol).Assembly.Location),
    },
    options: CompilationOptions.Default.WithConcurrentBuild(false));
cmp.Compile();

Console.WriteLine("----");
foreach (var diag in cmp.GetDiagnostics())
{
    Console.WriteLine(diag);
}
Console.WriteLine("----");

var generator = new MetaModelGenerator();
foreach (var mm in cmp.SourceModule.Model.Objects.OfType<MetaModel>())
{
    var output = generator.Generate(mm);
    File.WriteAllText($@"..\..\..\{mm.Name}X.cs", output);
}

//*/
//MetaDslx.Bootstrap.MetaModel.CoreX.MetaCore.MetaArrayTypeInfo.
//*/
