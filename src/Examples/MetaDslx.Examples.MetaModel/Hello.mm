namespace MetaDslx.Examples.MetaModel.Model;

using MetaDslx.CodeAnalysis.Symbols;

metamodel Hello;

class HelloType $Symbol
{
	string Message;

	string SayHello(string name);
}
