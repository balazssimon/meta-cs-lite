using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel.Core
{
    public class MetaDeclaration
    {
        public string? Name { get; set; }
    }

    public class MetaNamespace : MetaDeclaration
    {
        public MetaNamespace()
        {
            Declarations = new List<MetaDeclaration>();
        }

        public string Name { get; set; }
        public List<MetaDeclaration> Declarations { get; }
    }

    public class MetaModel : MetaDeclaration
    {
        public static MetaDslx.Modeling.MetaModel Instance = ReflectionMetaModel.CreateFromNamespace(typeof(MetaModel).Assembly, "MetaDslx.Bootstrap.MetaModel.Core");
        public static MetaPrimitiveType Bool => new MetaPrimitiveType() { Name = "bool" };
        public static MetaPrimitiveType Int => new MetaPrimitiveType() { Name = "int" };
        public static MetaPrimitiveType String => new MetaPrimitiveType() { Name = "string" };
    }

    public class MetaType : MetaDeclaration
    {
    }

    public class MetaPrimitiveType : MetaType
    {
    }

    public class MetaEnumType : MetaType
    {
        public MetaEnumType()
        {
            Literals = new List<MetaEnumLiteral>();
        }

        public List<MetaEnumLiteral> Literals { get; }
    }

    public class MetaEnumLiteral
    {
        public string Name { get; set; }
    }

    public class MetaArrayType : MetaType
    {
        public MetaType ItemType { get; set; }
    }

    public class MetaClass : MetaType
    {
        public MetaClass()
        {
            BaseTypes = new List<MetaClass>();
            Properties = new List<MetaProperty>();
        }

        public Type? SymbolType { get; set; }
        public bool IsAbstract { get; set; }
        public List<MetaClass> BaseTypes { get; set; }
        public List<MetaProperty> Properties { get; set; }
    }

    public class MetaProperty
    {
        public string Name { get; set; }
        public MetaType Type { get; set; }
        public bool IsContainment { get; set; }
        public MetaProperty? Opposite { get; set; }
    }
}
