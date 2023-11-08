// See https://aka.ms/new-console-template for more information

using MetaDslx.Modeling;
using MetaDslx.Examples.MetaModel.Model;

var model = new Model();
var f = new HelloModelFactory(model);
var h = f.HelloType();
h.Message = "Hello";
Console.WriteLine(h.SayHello("Alice"));

