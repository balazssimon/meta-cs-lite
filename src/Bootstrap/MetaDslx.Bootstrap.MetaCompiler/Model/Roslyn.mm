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
	string Namespace;
	contains TokenKind[] TokenKinds;
	contains Token[] Tokens;
	contains Rule[] Rules;
}

class Token
{
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

	derived string GreenName;
}

class Alternative
{
	string Name;
	contains Binder[] Binders;
	contains Element[] Elements;

	derived string GreenName;
	derived string GreenConstructorParameters;
	derived string GreenConstructorArguments;
	derived string GreenUpdateParameters;
	derived string GreenUpdateArguments;

	derived string RedName;
}

class Element
{
	contains Binder[] Binders;
	string? Name;
	MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment;
	contains ElementValue Value;
	MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity;

	derived string FieldName;
	derived string ParameterName;
	derived string PropertyName;

	derived string GreenFieldType;
	derived string GreenParameterValue;
	derived string GreenPropertyType;
	derived string GreenPropertyValue;
	derived string? GreenSyntaxNullCondition;
	derived string? GreenSyntaxCondition;
}

abstract class ElementValue
{
	contains Binder[] Binders;

	derived string GreenType;
	derived string? GreenSyntaxCondition;
}

class RuleRef : ElementValue
{
	Rule Rule;

	derived string GreenType;
	derived string? GreenSyntaxCondition;
}

class TokenRef : ElementValue
{
	Token Token;

	derived string GreenType;
	derived string? GreenSyntaxCondition;
}

class TokenAlts : ElementValue
{
	contains TokenRef[] Tokens;

	derived string GreenType;
	derived string? GreenSyntaxCondition;
}

class Eof : ElementValue
{
	derived string GreenType;
	derived string? GreenSyntaxCondition;
}

class SeparatedList : ElementValue
{
	bool SeparatorFirst;
	bool RepeatedSeparatorFirst;
	contains Element[] FirstItems;
	contains Element[] FirstSeparators;
	contains Element RepeatedBlock;
	Element RepeatedItem;
	Element RepeatedSeparator;
	contains Element[] LastItems;
	contains Element[] LastSeparators;

	derived string GreenType;
	derived string? GreenSyntaxCondition;
}

