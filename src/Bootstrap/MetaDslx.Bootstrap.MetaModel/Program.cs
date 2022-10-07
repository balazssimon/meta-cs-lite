// See https://aka.ms/new-console-template for more information
using MetaDslx.Bootstrap.MetaModel;
using MetaDslx.Modeling;

Console.WriteLine("Hello, World!");



var model = new Model();
var factory = new SimpleModelFactory(model);
var ifactory = SimpleModel.Instance.CreateFactory(model);
var ihusband = ifactory.Create("Husband");
var iwife = ifactory.Create(typeof(Wife));
ihusband.Add(Husband.MProperty_Husband_Wife, iwife);
var husband = factory.Husband();
var wife = factory.Wife();
husband.Wife = wife;

Console.WriteLine(SimpleModel.Husband1);
Console.WriteLine(husband.IsHusband());
Console.WriteLine(wife.IsHusband());

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
node.Parent = composite;

IModelObject muser = (IModelObject)user;
Console.WriteLine(muser);

Console.WriteLine();

var serializer = new XmiSerializer();
var savedModel = serializer.WriteModel(model);
Console.WriteLine(savedModel);
var loadedModel = serializer.ReadModel(savedModel, SimpleModel.Instance);
Console.WriteLine(loadedModel);
Console.WriteLine(serializer.WriteModel(loadedModel));
