
using MetaDslx.Languages.Uml.Model;
using MetaDslx.Languages.Uml.Serialization;
using UmlGenerator;

var xmiSerializer = new UmlXmiSerializer();
var model = xmiSerializer.ReadModelFromFile("../../../UML.xmi");
foreach (var primitiveType in model.Objects.OfType<PrimitiveType>())
{
    Console.WriteLine(primitiveType.MName);
}

var generator = new UmlModelToMetaModelGenerator(model.Objects);
File.WriteAllText("../../../output-intf.txt", generator.GenerateInterface());
File.WriteAllText("../../../output-impl.txt", generator.GenerateImplementation());
