
using MetaDslx.CodeAnalysis;
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
