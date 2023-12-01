namespace MetaDslx.Bootstrap.MetaCompiler.Roslyn;

metamodel Roslyn;

class Binder
{
	string TypeName;
	contains BinderArgument[] Arguments;
}

class BinderArgument
{
	string Name;
	string[] Values;
}

class TokenKind
{
	string Name;
	string TypeName;
}

class Language
{
	string Name;
	contains TokenKind[] TokenKinds;
	contains Token[] Tokens;
	contains Rule[] Rules;
}

class Token
{
	contains Binder[] Binders;
	string Name;
	TokenKind TokenKind;
	bool IsTrivia;
	bool IsFixed;
	string? FixedText;
}

class Rule
{
	contains Binder[] Binders;
	string Name;
	contains Alternative[] Alternatives;
}

class Alternative
{
	string Name;
	contains Binder[] Binders;
	contains Element[] Elements;
}

class Element
{
	contains Binder[] Binders;
	string Name;
	MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment;
	contains ElementValue Value;
	MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity;
}

abstract class ElementValue
{
	contains Binder[] Binders;
}

class RuleRef : ElementValue
{
	Rule Rule;
}

class TokenRef : ElementValue
{
	Token Token;
}

class TokenAlts : ElementValue
{
	TokenRef[] Tokens;
}

class Eof : ElementValue
{
}

class List : ElementValue
{
	bool SeparatorFirst;
	Element[] FirstItems;
	Element[] FirstSeparators;
	Element RepeatedBlock;
	Element RepeatedItem;
	Element RepeatedSeparator;
	Element[] LastItems;
	Element[] LastSeparators;
}

