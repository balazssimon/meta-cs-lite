// See https://aka.ms/new-console-template for more information
using MetaDslx.Bootstrap.MetaModel;
using MetaDslx.Modeling;

Console.WriteLine("Hello, World!");

var model = new Model();
var factory = new SimpleModelFactory(model);
var husband = factory.Husband();
var wife = factory.Wife();
husband.Wife = wife;

var user = factory.User();
var role = factory.Role();
user.Roles.Add(role);
user.Name = "Alice";
role.Name = "Admin";

var composite = factory.Composite();
var node = factory.Node();
composite.Children.Add(node);
node.Parent = null;
node.Parent = composite;
composite.Children.Remove(node);

IModelObject muser = (IModelObject)user;
Console.WriteLine(muser);
