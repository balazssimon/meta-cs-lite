// See https://aka.ms/new-console-template for more information
using MetaDslx.CodeAnalysis;
using MetaDslx.Examples.Soal.Compiler;
using MetaDslx.Examples.Soal.Model;
using MetaDslx.Modeling;

var path = @"..\..\..\HelloWorld.soal";
var code = File.ReadAllText(path);
var syntax = SoalSyntaxTree.ParseText(text: code, path: path);
var compilation = Compilation.Create(
        syntaxTrees: new[] 
        { 
            syntax 
        }, 
        references: new MetadataReference[] 
        {
            MetadataReference.CreateFromMetaModel(Soal.MInstance)
        });
compilation.Compile();
foreach (var diag in compilation.GetDiagnostics())
{
    Console.WriteLine(diag);
}
var model = compilation.SourceModule.Model;
var allObjs = model.Objects.ToList();
foreach (var mobj in allObjs)
{
    Console.WriteLine($"{mobj.MName}: {mobj.MInfo.MetaType}");
    if (mobj is NamedElement ne)
    {
        var doc = ne.Documentation;
        if (doc is not null)
        {
            Console.WriteLine("  " + doc.Tags.Count);
            Console.WriteLine(ne.HoverDocumentation);
        }
    }
}

var xmi = new XmiSerializer();
var opts = new XmiWriteOptions();
opts.ModelToUriMap.Add(Soal.MInstance.MModel, @"soal.xmi");
xmi.WriteModelToFile(@"..\..\..\HelloWorld.xmi", model, opts);
