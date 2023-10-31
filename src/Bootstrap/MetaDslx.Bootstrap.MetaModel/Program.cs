// See https://aka.ms/new-console-template for more information
using MetaDslx.Bootstrap.MetaModel;
using MetaDslx.Bootstrap.MetaModel.Compiler;
using MetaDslx.Bootstrap.MetaModel.Core;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Text;

Console.WriteLine("Hello, World!");

var code = File.ReadAllText(@"..\..\..\Core\MetaCore.mm");
var syntaxTree = MetaCoreSyntaxTree.ParseText(SourceText.From(code), path: "MetaCore.mm");

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
        MetadataReference.CreateFromMetaModel(MetaDslx.Modeling.ReflectionMetaModel.CreateFromNamespace(typeof(MetaModel).Assembly, "MetaDslx.Bootstrap.MetaModel.Core")) 
    },
    options: CompilationOptions.Default.WithConcurrentBuild(false));
cmp.Compile();

foreach (var diag in cmp.GetDiagnostics())
{
    Console.WriteLine(diag);
}
