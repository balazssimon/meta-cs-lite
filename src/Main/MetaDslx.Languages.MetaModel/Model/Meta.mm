namespace MetaDslx.Languages.MetaModel.Model;

using MetaDslx.CodeAnalysis.Symbols;

metamodel Meta;

class MetaNamedElement $Symbol
{
	string $Name;
}

class MetaDeclaration $Declared : MetaNamedElement
{
	MetaDeclaration Parent opposite Declarations;
	contains MetaDeclaration[] Declarations opposite Parent;
	derived string FullName;
}

class MetaNamespace $Namespace : MetaDeclaration
{
}

class MetaModel : MetaDeclaration
{
	derived string NamespaceName;
}

abstract class MetaType $Type : MetaDeclaration
{
}

class MetaPrimitiveType : MetaType
{
}

class MetaEnumType : MetaType
{
	contains MetaEnumLiteral[] Literals;
}

class MetaEnumLiteral : MetaDeclaration
{
}

class MetaArrayType : MetaType
{
	MetaType ItemType;
}

class MetaClass : MetaType
{
	type SymbolType;
	bool IsAbstract;
	MetaClass[] BaseTypes;
	contains MetaProperty[] Properties;
	contains MetaOperation[] Operations;
}

class MetaProperty : MetaDeclaration
{
	MetaType Type;
	string SymbolProperty;
	bool IsContainment;
	bool IsDerived;
	MetaProperty Opposite opposite Opposite;
}

class MetaOperation: MetaDeclaration
{
	MetaType ReturnType;
	contains MetaParameter[] Parameters;
}

class MetaParameter : MetaDeclaration
{
	MetaType Type;
}
