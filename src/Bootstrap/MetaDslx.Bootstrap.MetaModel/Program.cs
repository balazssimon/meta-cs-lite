// See https://aka.ms/new-console-template for more information
using MetaDslx.Bootstrap.MetaModel;
using MetaDslx.Bootstrap.MetaModel.Compiler;
//using MetaDslx.Bootstrap.MetaModel.CoreX;
using MetaDslx.Bootstrap.MetaModel.Generators;
using MetaDslx.Bootstrap.MetaModel.Meta;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Reflection;
using System.Collections.Immutable;

Console.WriteLine("Hello, World!");
//*/
var code = File.ReadAllText(@"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Model\Meta.mm");
var syntaxTree = MetaCoreSyntaxTree.ParseText(SourceText.From(code), path: "Meta.mm");

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
        MetadataReference.CreateFromMetaModel(ReflectionMetaModel.CreateFromNamespace(typeof(MetaDslx.Bootstrap.MetaModel.Core.MetaModel).Assembly, "MetaDslx.Bootstrap.MetaModel.Core")),
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
var mm = model.Objects.OfType<MetaDslx.Bootstrap.MetaModel.Core.MetaModel>().First();
Console.WriteLine(mm);
//*/
//*/
var graph = new MetaMetaGraph(model.Objects.OfType<MetaDslx.Bootstrap.MetaModel.Core.MetaClass>());
graph.Compute();
var generator = new MetaModelGenerator(true, model, mm, graph);
var output = generator.Generate();
File.WriteAllText($@"..\..\..\..\..\Main\MetaDslx.Languages.MetaModel\Model\{mm.Name}.cs", output);
//*/

/*/
var mx = new Model();
var fx = new MetaDslx.Bootstrap.MetaModel.CoreX.MetaCoreModelFactory(mx);
var c1 = fx.MetaClass();
c1.Name = "Foo";
var p1 = fx.MetaProperty();
p1.Name = "Bar";
p1.Type = c1;
c1.Declarations.Add(p1);
Console.WriteLine(c1.Declarations.Count);
//*/

/*/
foreach (var mobj in MetaDslx.Bootstrap.MetaModel.CoreX.MetaCore.Instance.Model.Objects)
{
    Console.WriteLine(mobj);
}
//*/
