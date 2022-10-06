// See https://aka.ms/new-console-template for more information
using MetaDslx.Bootstrap.MetaModel;
using MetaDslx.Modeling;

Console.WriteLine("Hello, World!");

var model = new Model();
var factory = new SimpleModelFactory(model);
var husband = factory.Husband();
var wife = factory.Wife();
husband.Wife = wife;

var user = factory.User2();
var role = factory.Role();
user.Roles.Add(role);
user.Name = "Alice";
role.Name = "Admin";
role.Users.Remove(user);
user.Roles2.Add(role);
user.Roles2.Remove(role);
user.Roles.Add(role);
var role2 = factory.Role();
role2.Name = "Engineer";
user.Roles5 = role2;
//user.Roles2.Add(role);
Console.WriteLine(user.Roles5);

var composite = factory.Composite();
var node = factory.Node();
composite.Children.Add(node);
node.Parent = null;
node.Parent = composite;
composite.Children.Remove(node);

IModelObject muser = (IModelObject)user;
Console.WriteLine(muser);
