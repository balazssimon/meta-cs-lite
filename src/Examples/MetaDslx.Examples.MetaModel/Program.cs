
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Symbols;
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
    //MetaModelLanguage.Instance,
    syntaxTrees: new[] 
    {
        mmTree
    }, 
    references: new[] 
    {
        MetadataReference.CreateFromMetaModel(Meta.Instance),
        MetadataReference.CreateFromModel(Meta.Model),
        MetadataReference.CreateFromFile(typeof(string).Assembly.Location),
        MetadataReference.CreateFromFile(typeof(Compilation).Assembly.Location),
    });

//*/
var rootDecl = mmComp.RootDeclaration;
Console.WriteLine(rootDecl.Name);
Console.WriteLine(rootDecl.Children.Length);
//*/

Console.WriteLine(mmComp.HasCodeToEmit());
Console.WriteLine(mmComp.Name);
Console.WriteLine(mmComp.SourceModule.GlobalNamespace.Name);

/*/
foreach (var module in mmComp.SourceAssembly.Modules)
{
    PrintSymbols(string.Empty, module);
}
//*/

var root = mmTree.GetRoot();
var rootBinder = mmComp.GetBinder(root);
rootBinder.CompleteBind(default, true);
PrintBinders(string.Empty, rootBinder);

static void PrintSymbols(string indent, Symbol symbol)
{
    Console.WriteLine($"{indent}{symbol}");
    foreach (var child in symbol.ContainedSymbols)
    {
        PrintSymbols(indent+"  ", child);
    }
}

static void PrintBinders(string indent, Binder binder)
{
    Console.WriteLine($"{indent}{binder}");
    foreach (var child in binder.GetChildBinders(resolveLazy: true))
    {
        PrintBinders(indent + "  ", child);
    }
}
/*/
var bf = mmComp.GetBinderFactory(mmTree);
if (mmTree.TryGetRoot(out var root) && root is not null)
{
    bf.BuildBinderTree(root);
    Console.WriteLine(bf.BuckStopsHereBinder);
}
//*/


