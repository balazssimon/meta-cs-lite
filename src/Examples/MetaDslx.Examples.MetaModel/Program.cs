
using MetaDslx.CodeAnalysis;
using MetaDslx.Examples.MetaModel;
using MetaDslx.Examples.MetaModel.Model;

var mmCode = File.ReadAllText(@"..\..\..\ImmutableMetaModel.txt");

var mmTree = MetaModelSyntaxTree.ParseText(mmCode);

foreach (var diag in mmTree.GetDiagnostics())
{
    Console.WriteLine(diag);
}

var mmComp = Compilation.Create(
    "ImmutableMetaModel", 
    syntaxTrees: new[] 
    {
        mmTree
    }, 
    references: new[] 
    {
        MetadataReference.CreateFromMetaModel(Meta.Instance),
        MetadataReference.CreateFromFile(typeof(string).Assembly.Location) 
    });

var root = mmTree.GetRoot();
var rootBinder = mmComp.GetBinder(root);
Console.WriteLine(rootBinder);

//*/
var rootDecl = mmComp.RootDeclaration;
Console.WriteLine(rootDecl.Name);
Console.WriteLine(rootDecl.Children.Length);
//*/

Console.WriteLine(mmComp.HasCodeToEmit());
Console.WriteLine(mmComp.Name);
Console.WriteLine(mmComp.SourceModule.GlobalNamespace.Name);

foreach (var decl in mmComp.SourceModule.GlobalNamespace.ContainedSymbols)
{
    Console.WriteLine(decl.Name);
}

/*/
var bf = mmComp.GetBinderFactory(mmTree);
if (mmTree.TryGetRoot(out var root) && root is not null)
{
    bf.BuildBinderTree(root);
    Console.WriteLine(bf.BuckStopsHereBinder);
}
//*/


