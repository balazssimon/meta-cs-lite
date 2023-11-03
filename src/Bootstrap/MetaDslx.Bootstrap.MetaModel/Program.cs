// See https://aka.ms/new-console-template for more information
using MetaDslx.Bootstrap.MetaModel;
using MetaDslx.Bootstrap.MetaModel.Compiler;
using MetaDslx.Bootstrap.MetaModel.Core;
using MetaDslx.Bootstrap.MetaModel.Generators;
using MetaDslx.Bootstrap.MetaModel.Meta;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Modeling.Reflection;
using System.Collections.Immutable;

Console.WriteLine("Hello, World!");
//*/
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
        MetadataReference.CreateFromMetaModel(ReflectionMetaModel.CreateFromNamespace(typeof(MetaModel).Assembly, "MetaDslx.Bootstrap.MetaModel.Core")),
        MetadataReference.CreateFromFile(typeof(string).Assembly.Location),
        MetadataReference.CreateFromFile(typeof(Symbol).Assembly.Location),
    },
    options: CompilationOptions.Default.WithConcurrentBuild(false));

var rootBinder = cmp.GetRootBinder(syntaxTree);
rootBinder.CompleteBind(default, true);
Console.WriteLine(rootBinder.PrintBinderTree());

cmp.Compile();

Console.WriteLine("----");
foreach (var diag in cmp.GetDiagnostics())
{
    Console.WriteLine(diag);
}
Console.WriteLine("----");
//*/
//*/
var model = cmp.SourceModule.Model;
var mm = model.Objects.OfType<MetaModel>().First();
Console.WriteLine(mm);
//*/
//*/
var graph = new MetaMetaGraph(model.Objects.OfType<MetaClass>());
graph.Compute();
var generator = new MetaModelGenerator(mm, graph);
var output = generator.Generate();
File.WriteAllText($@"..\..\..\{mm.Name}X.cs", output);
//*/

//*/
//MetaDslx.Bootstrap.MetaModel.CoreX.MetaCore.MetaArrayTypeInfo.
//*/
