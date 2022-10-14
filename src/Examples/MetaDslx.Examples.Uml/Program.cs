
using MetaDslx.CodeAnalysis;
using MetaDslx.Languages.Uml.CodeGeneration;
using MetaDslx.Languages.Uml.MetaModel;
using MetaDslx.Languages.Uml.Serialization;
using System.Collections.Immutable;

var umlSerializer = new WhiteStarUmlSerializer();
var model = umlSerializer.ReadModelFromFile("../../../Pacman.uml", out var diagnostics);

DiagnosticFormatter df = new DiagnosticFormatter();
if (diagnostics.Any(d => d.Severity == DiagnosticSeverity.Error))
{
    diagnostics = diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToImmutableArray();
}
for (int i = 0; i < 10 && i < diagnostics.Length; i++)
{
    Console.WriteLine(df.Format(diagnostics[i]));
}

foreach (var cls in model.Objects.OfType<Classifier>())
{
    Console.WriteLine(cls);
}

var xmiSerializer = new UmlXmiSerializer();
xmiSerializer.WriteModelToFile("../../../pacman.xmi", model);

var umlMetaModel = xmiSerializer.ReadModelFromFile("../../../UML.xmi");
var options = new UmlXmiWriteOptions();
var mi = 0;
foreach (var m in umlMetaModel.ModelGroup.Models)
{
    options.ModelToFileMap.Add(m, $"../../../output{mi}.xmi");
    ++mi;
}
xmiSerializer.WriteModelGroupToFile(umlMetaModel.ModelGroup, options);
var generator = new UmlModelToMetaModelGenerator(umlMetaModel);
generator.Namespace = "MetaDslx.Languages.Uml.MetaModel";
generator.Uri = "http://www.omg.org/spec/UML/";
generator.Prefix = "uml";
generator.ModelName = "UmlMetaModel";
File.WriteAllText("../../../Uml-intf.txt", generator.GenerateInterface());
File.WriteAllText("../../../Uml-impl.txt", generator.GenerateImplementation());
