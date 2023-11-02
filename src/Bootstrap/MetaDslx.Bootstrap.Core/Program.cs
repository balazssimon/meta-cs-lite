using MetaDslx.Modeling;
using System;
using System.Collections.Generic;

namespace MetaDslx.Bootstrap.Core
{
    using MetaDslx.Bootstrap.Core.TestModel;
    using MetaDslx.Modeling.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mm = ReflectionMetaModel.CreateFromNamespace(typeof(Husband).Assembly, "MetaDslx.Bootstrap.Core.TestModel");
            foreach (var type in mm.ModelObjectTypes)
            {
                Console.WriteLine(type);
                if (mm.TryGetInfo(type, out var info))
                {
                    Console.WriteLine(info);
                    foreach (var prop in info.PublicProperties)
                    {
                        Console.WriteLine($"  {prop.Name}");
                        Console.WriteLine($"    {info.GetSlot(prop)?.Flags}");
                    }
                }
            }
            var model = new Model();
            var f = mm.CreateFactory(model);
            var h = f.Create("Husband");
            var w = f.Create(typeof(Wife));
            h.Add(h.GetProperty("Wife"), w);
            h.Add(h.GetProperty("Dl"), 3.5);
            h.Add(h.GetProperty("Ds"), w);
            var ho = (Husband)h.UnderlyingObject;
            var wo = (Wife)w.UnderlyingObject;
            Console.WriteLine(ho.Wife);
            Console.WriteLine(wo.Husband);
            foreach (var obj in model.ModelObjects)
            {
                Console.WriteLine(obj);
            }
            foreach (var obj in model.Objects)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

namespace MetaDslx.Bootstrap.Core.TestModel
{
    public class Husband
    {
        [Opposite(typeof(Wife), "Husband")]
        public Wife? Wife { get; set; }
        public int Age { get; set; }
        public List<double> Dl { get; } = new List<double>();
        public HashSet<Wife?> Ds { get; } = new HashSet<Wife?>();
    }

    public class Wife
    {
        [Opposite(typeof(Husband), "Wife")]
        public Husband? Husband { get; set; }
    }
}
