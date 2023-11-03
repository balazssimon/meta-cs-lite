namespace MetaDslx.Bootstrap.MetaModel.CoreX;

using System;
using MetaDslx.CodeAnalysis.Symbols;

metamodel MetaCore;

class MetaDeclaration
{
	string Name;
}

class MetaNamespace : MetaDeclaration
{
	MetaDeclaration[] Declarations;
}

class MetaModel : MetaDeclaration
{
}

class MetaType : MetaDeclaration
{
}

class MetaPrimitiveType : MetaType
{
}

class MetaEnumType : MetaType
{
	MetaEnumLiteral[] Literals;
}

class MetaEnumLiteral
{
	string Name;
}

class MetaArrayType : MetaType
{
	MetaType ItemType;
}

class MetaClass : MetaType
{
	bool IsAbstract;
	MetaClass[] BaseTypes;
	MetaProperty[] Properties;
}

class MetaProperty
{
	string Name;
	MetaType Type;
	bool IsContainment;
	MetaProperty Opposite;
}
