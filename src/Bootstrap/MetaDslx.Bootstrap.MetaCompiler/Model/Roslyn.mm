namespace MetaDslx.Bootstrap.MetaCompiler.Roslyn;

metamodel Roslyn;

class Annotation
{
	string FullName;
	contains AnnotationArgument[] Arguments;
}

class AnnotationArgument
{
	string Name;
	string Value;
}

class Language
{
	contains Annotation[] Annotations;
	string Name;
	string[] TokenKinds;
	contains Token[] Tokens;
	contains Rule[] Rules;
}

class Token
{
	contains Annotation[] Annotations;
	string Name;
	string TokenKind;
	bool IsTrivia;
	bool IsFixed;
	string? FixedText;
}

class Rule
{
	contains Annotation[] Annotations;
	string Name;
	contains Alternative[] Alternatives;
}

class Alternative
{
	string Name;
	contains Annotation[] Annotations;
	contains Element[] Elements;
}

class Element
{
	contains Annotation[] Annotations;
	string Name;
	MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment;
	contains ElementValue Value;
	MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity;
}

abstract class ElementValue
{
	contains Annotation[] Annotations;
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

