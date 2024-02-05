// See https://aka.ms/new-console-template for more information
using MetaDslx.Languages.Mof.Model;

Console.WriteLine("Hello, World!");

var xmi = new MofXmiSerializer();
var model = xmi.ReadModelFromFile(@"..\..\..\StandardProfile.xmi", Mof.MInstance);

foreach (var mobj in model.Objects)
{
    Console.WriteLine(mobj.MName);
}

xmi.WriteModelToFile(@"..\..\..\StandardProfile2.xmi", model);
