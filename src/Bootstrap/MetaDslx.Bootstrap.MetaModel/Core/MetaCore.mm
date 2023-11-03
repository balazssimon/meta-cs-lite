namespace MetaDslx.Bootstrap.MetaModel.CoreX;

using MetaDslx.CodeAnalysis.Symbols;

metamodel MetaCore;

class MetaDeclaration $Declared
{
	string $Name;
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
}

class MetaProperty : MetaDeclaration
{
	MetaType Type;
	string SymbolProperty;
	bool IsContainment;
	MetaProperty Opposite opposite Opposite;
}
