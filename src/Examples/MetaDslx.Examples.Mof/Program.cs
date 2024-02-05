// See https://aka.ms/new-console-template for more information
using MetaDslx.Languages.Mof.Model;

Console.WriteLine("Hello, World!");

var xmi = new MofXmiSerializer();
var readOptions = new MofXmiReadOptions();
readOptions.UriToFileMap.Add("http://www.omg.org/spec/UML/20161101/UML.xmi", @"UML.xmi");
readOptions.UriToFileMap.Add("http://www.omg.org/spec/UML/20131001/PrimitiveTypes.xmi", @"PrimitiveTypes.xmi");
var modelGroup = xmi.ReadModelGroupFromFile(@"..\..\..\UML.xmi", readOptions, out var diagnostics);
var models = modelGroup.Models.ToArray();
var uml = models[0];
var primitiveTypes = models[1];

foreach (var diag in diagnostics)
{
    Console.WriteLine(diag);
}

if (diagnostics.Length == 0)
{
    foreach (var mobj in uml.Objects)
    {
        Console.WriteLine(mobj.MName);
    }
}

var writeOptions = new MofXmiWriteOptions();
writeOptions.ModelToFileMap.Add(uml, @"..\..\..\UML2.xmi");
writeOptions.ModelToFileMap.Add(primitiveTypes, @"..\..\..\PrimitiveTypes2.xmi");
xmi.WriteModelGroupToFile(modelGroup, writeOptions);
