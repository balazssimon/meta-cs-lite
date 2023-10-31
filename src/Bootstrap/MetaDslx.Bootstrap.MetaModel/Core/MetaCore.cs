using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel.Core
{
    [Symbol(typeof(DeclaredSymbol))]
    public class MetaDeclaration
    {
        [SymbolProperty("Name")]
        public string? Name { get; set; }
    }

    [Symbol(typeof(NamespaceSymbol))]
    public class MetaNamespace : MetaDeclaration
    {
        public MetaNamespace()
        {
            Declarations = new List<MetaDeclaration>();
        }

        public List<MetaDeclaration> Declarations { get; }
    }

    public class MetaModel : MetaDeclaration
    {
        public static MetaDslx.Modeling.MetaModel Instance = ReflectionMetaModel.CreateFromNamespace(typeof(MetaModel).Assembly, "MetaDslx.Bootstrap.MetaModel.Core");
        public static MetaPrimitiveType Bool => new MetaPrimitiveType() { Name = "bool" };
        public static MetaPrimitiveType Int => new MetaPrimitiveType() { Name = "int" };
        public static MetaPrimitiveType String => new MetaPrimitiveType() { Name = "string" };
    }

    [Symbol(typeof(TypeSymbol))]
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

    [Symbol(typeof(DeclaredSymbol))]
    public class MetaEnumLiteral
    {
        [SymbolProperty("Name")]
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

    [Symbol(typeof(DeclaredSymbol))]
    public class MetaProperty
    {
        [SymbolProperty("Name")]
        public string Name { get; set; }
        [SymbolProperty("Type")]
        public MetaType Type { get; set; }
        public bool IsContainment { get; set; }
        public MetaProperty? Opposite { get; set; }
    }
}
