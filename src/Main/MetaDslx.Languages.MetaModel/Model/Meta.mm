namespace MetaDslx.Languages.MetaModel.Model;

using MetaDslx.CodeAnalysis.Symbols;

metamodel Meta;

class MetaDeclaration $Declaration
{
	string? $Name;
	MetaDeclaration? Parent opposite Declarations;
	contains MetaDeclaration[] Declarations opposite Parent;
	derived string? FullName;
}

class MetaNamespace $Namespace : MetaDeclaration
{
}

class MetaModel : MetaDeclaration
{
	derived string NamespaceName;
}

class MetaConstant : MetaDeclaration
{
	type Type;
}

abstract class MetaType $Type : MetaDeclaration
{
}

class MetaPrimitiveType : MetaType
{
}

class MetaNullableType : MetaType
{
	type InnerType;
}

class MetaArrayType : MetaType
{
	type ItemType;
}

class MetaEnum : MetaType
{
	contains MetaEnumLiteral[] Literals subsets MetaDeclaration.Declarations;
}

class MetaEnumLiteral : MetaDeclaration
{
}

class MetaClass : MetaType
{
	type? SymbolType;
	bool IsAbstract;
	MetaClass[] BaseTypes;
	contains MetaProperty[] Properties subsets MetaDeclaration.Declarations;
	contains MetaOperation[] Operations subsets MetaDeclaration.Declarations;
}

class MetaProperty : MetaDeclaration
{
	type Type;
	string? SymbolProperty;
	bool IsContainment;
	bool IsDerived;
	MetaProperty[] OppositeProperties opposite OppositeProperties;
	MetaProperty[] SubsettedProperties;
	MetaProperty[] RedefinedProperties;
}

class MetaOperation: MetaDeclaration
{
	type ReturnType;
	contains MetaParameter[] Parameters redefines MetaDeclaration.Declarations;
}

class MetaParameter : MetaDeclaration
{
	type Type;
}
