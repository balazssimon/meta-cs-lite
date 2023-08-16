using MetaDslx.Modeling;
using System;

namespace MetaDslx.Examples.MetaModel.Model
{
    using Internal;
    using MetaDslx.Modeling;
    using MetaDslx.CodeAnalysis.Symbols;

    [MetaModel(MajorVersion = 1, MinorVersion = 0, Prefix = "mm", Uri = "http://metadslx/MetaModel")]
    public partial interface Meta
    {
        public static readonly Model Model;
        public static readonly MetaPrimitiveType String;
        public static readonly MetaPrimitiveType Int;
        public static readonly MetaPrimitiveType Bool;

        static Meta()
        {
            Model = new MetaDslx.Modeling.Model();
            var factory = new MetaFactory(Model);
            String = factory.MetaPrimitiveType();
            String.Name = "string";
            Int = factory.MetaPrimitiveType();
            Int.Name = "int";
            Bool = factory.MetaPrimitiveType();
            Bool.Name = "bool";
        }
    }

    [MetaClass]
    [Symbol(typeof(Symbol))]
    public partial interface MetaElement
    {
        public IList<MetaAttribute> Attributes { get; }
    }

    public partial interface MetaDocumentedElement : MetaElement
    {
        public string Documentation { get; set; }
    }

    public partial interface MetaNamedElement : MetaDocumentedElement
    {
        [SymbolProperty("Name")]
        [Name]
        public string Name { get; set; }
    }

    public partial interface MetaTypedElement : MetaElement
    {
        [Type]
        public MetaType Type { get; set; }
    }

    [Symbol(typeof(TypeSymbol))]
    public partial interface MetaType : MetaElement
    {
        public virtual bool ConformsTo(MetaType @type)
        {
            return object.ReferenceEquals(this, @type);
        }
    }

    [Symbol(typeof(TypeSymbol))]
    public partial interface MetaNamedType : MetaType, MetaDeclaration
    {
    }

    [Symbol(typeof(AttributeSymbol))]
    public partial interface MetaAttribute : MetaNamedElement, MetaTypedElement
    {
        [SymbolProperty("AttributeClass")]
        [Redefines(typeof(MetaTypedElement), "Type")]
        public new MetaNamedType Type { get; set; }
    }

    [Symbol(typeof(DeclaredSymbol))]
    public partial interface MetaDeclaration : MetaNamedElement
    {
        [Opposite(typeof(MetaNamespace), "Declarations")]
        public MetaNamespace? Namespace { get; set; }
        [Derived]
        public MetaModel? MetaModel => Namespace?.MetaModel;
        [Derived]
        public string FullName => $"{Namespace.FullName}{Name}";
    }

    [Symbol(typeof(NamespaceSymbol))]
    public partial interface MetaNamespace : MetaDeclaration
    {
        [Opposite(typeof(MetaModel), "Namespace")]
        [Containment]
        public MetaModel? DefinedMetaModel { get; set; }

        [Opposite(typeof(MetaDeclaration), "Namespace")]
        [Containment]
        public IList<MetaDeclaration> Declarations { get; }
    }

    [Symbol(typeof(DeclaredSymbol))]
    public partial interface MetaModel : MetaNamedElement
    {
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public string Uri { get; set; }
        public string Prefix { get; set; }
        [Opposite(typeof(MetaNamespace), "DefinedMetaModel")]
        MetaNamespace Namespace { get; set; }
    }

    public enum MetaCollectionKind
    {
        List,
        Set,
        MultiList,
        MultiSet,
        Enumerable
    }

    public partial interface MetaCollectionType : MetaType
    {
        public MetaCollectionKind Kind { get; set; }
        public MetaType InnerType { get; set; }
        public new bool ConformsTo(MetaType @type)
        {
            return type is MetaCollectionType collection && collection.Kind == this.Kind && collection.InnerType.ConformsTo(this.InnerType);
        }
    }

    public partial interface MetaNullableType : MetaType
    {
        public MetaType InnerType { get; set; }
        public new bool ConformsTo(MetaType @type)
        {
            return type is MetaNullableType nullable && nullable.InnerType.ConformsTo(this.InnerType);
        }
    }

    public partial interface MetaPrimitiveType : MetaNamedType
    {
        public string DotNetName { get; set; }
    }

    public partial interface MetaEnum : MetaNamedType
    {
        [Opposite(typeof(MetaEnumLiteral), "Enum")]
        [Containment]
        public IList<MetaEnumLiteral> EnumLiterals { get; }
    }

    [Symbol(typeof(DeclaredSymbol))]
    public partial interface MetaEnumLiteral : MetaNamedElement, MetaTypedElement
    {
        [Opposite(typeof(MetaEnum), "EnumLiterals")]
        [Redefines(typeof(MetaTypedElement), "Type")]
        public MetaEnum Enum { get; set; }
    }

    public partial interface MetaConstant : MetaDeclaration, MetaTypedElement
    {
        public object? Value { get; set; }
    }

    public partial interface MetaClass : MetaNamedType
    {
        public bool IsAbstract { get; set; }
        [SymbolProperty("BaseTypes")]
        public IList<MetaClass> BaseClasses { get; }

        [Opposite(typeof(MetaProperty), "Class")]
        [Containment]
        public IList<MetaProperty> Properties { get; }
    }

    public enum MetaPropertyKind
    {
        Normal,
        Readonly,
        Lazy,
        Derived,
        DerivedUnion
    }

    [Symbol(typeof(DeclaredSymbol))]
    public partial interface MetaProperty : MetaNamedElement, MetaTypedElement
    {
        public MetaPropertyKind Kind { get; set; }
        [Opposite(typeof(MetaClass), "Properties")]
        public MetaClass Class { get; set; }
        public string DefaultValue { get; set; }
        public bool IsContainment { get; set; }
        [Opposite(typeof(MetaProperty), "OppositeProperties")]
        public IList<MetaProperty> OppositeProperties { get; }
        [Opposite(typeof(MetaProperty), "SubsettingProperties")]
        public IList<MetaProperty> SubsettedProperties { get; }
        [Opposite(typeof(MetaProperty), "SubsettedProperties")]
        public IList<MetaProperty> SubsettingProperties { get; }
        [Opposite(typeof(MetaProperty), "RedefiningProperties")]
        public IList<MetaProperty> RedefinedProperties { get; }
        [Opposite(typeof(MetaProperty), "RedefinedProperties")]
        public IList<MetaProperty> RedefiningProperties { get; }
    }

}
