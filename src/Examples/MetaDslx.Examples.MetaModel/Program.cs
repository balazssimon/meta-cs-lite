﻿
using MetaDslx.CodeAnalysis;
using MetaDslx.Examples.MetaModel;

var mmCode = File.ReadAllText(@"..\..\..\ImmutableMetaModel.txt");

var mmTree = MetaModelSyntaxTree.ParseText(mmCode);

foreach (var diag in mmTree.GetDiagnostics())
{
    Console.WriteLine(diag);
}

var mmComp = Compilation.Create("ImmutableMetaModel", new[] {mmTree});

var root = mmTree.GetRoot();
var rootBinder = mmComp.GetBinder(root);
Console.WriteLine(rootBinder);

//*/
var rootDecl = mmComp.RootDeclaration;
Console.WriteLine(rootDecl.Name);
Console.WriteLine(rootDecl.Children.Length);
//*/

/*/
var bf = mmComp.GetBinderFactory(mmTree);
if (mmTree.TryGetRoot(out var root) && root is not null)
{
    bf.BuildBinderTree(root);
    Console.WriteLine(bf.BuckStopsHereBinder);
}
//*/


