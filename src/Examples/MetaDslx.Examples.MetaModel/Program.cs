
using MetaDslx.CodeAnalysis;
using MetaDslx.Examples.MetaModel;
using MetaDslx.Examples.MetaModel.Model;

var mmCode = File.ReadAllText(@"..\..\..\ImmutableMetaModel.txt");

var mmTree = MetaModelSyntaxTree.ParseText(mmCode);

foreach (var diag in mmTree.GetDiagnostics())
{
    Console.WriteLine(diag);
}

var mmComp = Compilation.Create("ImmutableMetaModel", new[] {mmTree}, new[] { MetadataReference.CreateFromMetaModel(Meta.Instance), MetadataReference.CreateFromFile(typeof(string).Assembly.Location) } );

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

/*/
var bf = mmComp.GetBinderFactory(mmTree);
if (mmTree.TryGetRoot(out var root) && root is not null)
{
    bf.BuildBinderTree(root);
    Console.WriteLine(bf.BuckStopsHereBinder);
}
//*/


