using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Reflection;
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
        public MetaDeclaration()
        {
            Declarations = new List<MetaDeclaration>();
        }

        [SymbolProperty("Name")]
        public string? Name { get; set; }

        [Opposite(typeof(MetaDeclaration), "Declarations")]
        public MetaDeclaration? Parent { get; set; }

        [Containment]
        [Opposite(typeof(MetaDeclaration), "Parent")]
        public List<MetaDeclaration> Declarations { get; }

        [Derived]
        public string? FullName
        {
            get
            {
                var result = this.Name;
                var parent = this.Parent;
                while (parent?.Name is not null)
                {
                    result = $"{parent.Name}.{result}";
                    parent = parent.Parent;
                }
                return result;
            }
        }
    }

    [Symbol(typeof(NamespaceSymbol))]
    public class MetaNamespace : MetaDeclaration
    {
    }

    public class MetaModel : MetaDeclaration
    {
        public static Modeling.MetaModel Instance = ReflectionMetaModel.CreateFromNamespace(typeof(MetaModel).Assembly, "MetaDslx.Bootstrap.MetaModel.Core");
        public static MetaPrimitiveType Bool => new MetaPrimitiveType() { Name = "bool" };
        public static MetaPrimitiveType Int => new MetaPrimitiveType() { Name = "int" };
        public static MetaPrimitiveType String => new MetaPrimitiveType() { Name = "string" };
        public static MetaPrimitiveType Type => new MetaPrimitiveType() { Name = "type" };

        [Derived]
        public string? NamespaceName => this.Parent?.FullName;
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

        [Containment]
        [Subsets(typeof(MetaDeclaration), "Declarations")]
        public List<MetaEnumLiteral> Literals { get; }
    }

    [Symbol(typeof(DeclaredSymbol))]
    public class MetaEnumLiteral : MetaDeclaration
    {
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
        
        [TypeSymbolType]
        public string? SymbolType { get; set; }
        public bool IsAbstract { get; set; }
        public List<MetaClass> BaseTypes { get; set; }
        [Containment]
        [Subsets(typeof(MetaDeclaration), "Declarations")]
        public List<MetaProperty> Properties { get; set; }
    }

    [Symbol(typeof(DeclaredSymbol))]
    public class MetaProperty : MetaDeclaration
    {
        public MetaType Type { get; set; }
        public string? SymbolProperty { get; set; }
        public bool IsContainment { get; set; }
        public bool IsDerived { get; set; }
        [Opposite(typeof(MetaProperty), "Opposite")]
        public MetaProperty? Opposite { get; set; }
    }
}
