namespace MetaDslx.Languages.MetaModel.Model;

using MetaDslx.CodeAnalysis.Symbols;

metamodel Meta;

const MetaPrimitiveType VoidType;
const MetaPrimitiveType BoolType;
const MetaPrimitiveType IntType;
const MetaPrimitiveType StringType;
const MetaPrimitiveType TypeType;

class MetaDeclaration $Declared : MetaNamedElement
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

class MetaConstant : MetaDeclaration
{
	MetaType Type;
}

abstract class MetaType $Type : MetaDeclaration
{
}

class MetaPrimitiveType : MetaType
{
}

class MetaNullableType : MetaType
{
	MetaType InnerType;
}

class MetaArrayType : MetaType
{
	MetaType ItemType;
}

class MetaEnumType : MetaType
{
	contains MetaEnumLiteral[] Literals subsets MetaDeclaration.Declarations;
}

class MetaEnumLiteral : MetaDeclaration
{
}

class MetaClass : MetaType
{
	type SymbolType;
	bool IsAbstract;
	MetaClass[] BaseTypes;
	contains MetaProperty[] Properties subsets MetaDeclaration.Declarations;
	contains MetaOperation[] Operations subsets MetaDeclaration.Declarations;
}

class MetaProperty : MetaDeclaration
{
	MetaType Type;
	string SymbolProperty;
	bool IsContainment;
	bool IsDerived;
	MetaProperty[] OppositeProperties opposite OppositeProperties;
	MetaProperty[] SubsettedProperties;
	MetaProperty[] RedefinedProperties;
}

class MetaOperation: MetaDeclaration
{
	MetaType ReturnType;
	contains MetaParameter[] Parameters subsets MetaDeclaration.Declarations;
}

class MetaParameter : MetaDeclaration
{
	MetaType Type;
}
