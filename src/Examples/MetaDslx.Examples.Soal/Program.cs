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
foreach (var mobj in model.Objects)
{
    Console.WriteLine($"{mobj.MName}: {mobj.MInfo.MetaType}");
}
