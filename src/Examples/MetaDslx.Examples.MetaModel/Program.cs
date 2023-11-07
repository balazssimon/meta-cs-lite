// See https://aka.ms/new-console-template for more information
using MetaDslx.Languages.MetaModel;
using MetaDslx.Languages.MetaModel.Compiler;
//using MetaDslx.Bootstrap.MetaModel.CoreX;
using MetaDslx.Languages.MetaModel.Generators;
using MetaDslx.Languages.MetaModel.Meta;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Reflection;
using System.Collections.Immutable;

var code = File.ReadAllText(@"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Model\Meta.mm");
var syntaxTree = MetaSyntaxTree.ParseText(SourceText.From(code), path: "Meta.mm");

Console.WriteLine("----");
var syntaxTreeDiagnostics = syntaxTree.GetDiagnostics().ToList();
foreach (var diag in syntaxTreeDiagnostics)
{
    Console.WriteLine(diag);
}
if (syntaxTreeDiagnostics.Count > 0) return;

var cmp = Compilation.Create("Meta",
    syntaxTrees: new[] { syntaxTree },
    references: new[]
    {
        //MetadataReference.CreateFromMetaModel(ReflectionMetaModel.CreateFromNamespace(typeof(MetaDslx.Languages.MetaModel.Model.Meta).Assembly, "MetaDslx.Languages.MetaModel.Model")),
        MetadataReference.CreateFromMetaModel(MetaDslx.Languages.MetaModel.Model.Meta.Instance),
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
var mm = model.Objects.OfType<MetaDslx.Languages.MetaModel.Model.MetaModel>().First();
Console.WriteLine(mm);
//*/
//*/
var graph = new MetaMetaGraph(model.Objects.OfType<MetaDslx.Languages.MetaModel.Model.MetaClass>());
graph.Compute();
var generator = new MetaModelGenerator(model, mm, graph);
var output = generator.Generate();
File.WriteAllText($@"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Model\{mm.Name}.cs2", output);
//*/
