namespace MetaDslx.Bootstrap.MetaModel.CoreX;

using System;
using MetaDslx.CodeAnalysis.Symbols;

metamodel MetaCore;

class MetaDeclaration#Declared
{
	string #Name;
	MetaDeclaration Parent opposite Declarations;
	contains MetaDeclaration[] Declarations opposite Parent;
	derived string FullName;
}

class MetaNamespace#Namespace : MetaDeclaration
{
}

class MetaModel : MetaDeclaration
{
	derived string NamespaceName;
}

class MetaType#TypeSymbol : MetaDeclaration
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
	string Name;
	MetaType Type;
	string SymbolProperty;
	bool IsContainment;
	MetaProperty Opposite opposite Opposite;
}
