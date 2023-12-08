namespace MetaDslx.Bootstrap.MetaCompiler.Roslyn;

metamodel Roslyn;

class Binder
{
	string TypeName;
	contains BinderArgument[] Arguments;
	bool IsNegated;

	derived string ConstructorArguments;
}

class BinderArgument
{
	string Name;
	string TypeName;
	bool IsArray;
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

	Token? DefaultWhitespace;
	Token? DefaultEndOfLine;
	Token? DefaultSeparator;
	Token? DefaultIdentifier;
	Rule? MainRule;
	string? RootTypeName;
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
	bool ContainsBinders;

	string Name;
	contains Alternative[] Alternatives;

	derived string GreenName;
	derived string RedName;
}

class Alternative
{
	contains Binder[] Binders;
	bool ContainsBinders;

	string Name;
	contains Element[] Elements;

	derived string GreenName;
	derived string GreenConstructorParameters;
	derived string GreenConstructorArguments;
	derived string GreenUpdateParameters;
	derived string GreenUpdateArguments;

	derived string RedName;
	derived string RedUpdateParameters;
	derived string RedUpdateArguments;
	derived string RedOptionalUpdateParameters;
	derived string RedToGreenArgumentList;
	derived string RedToGreenOptionalArgumentList;
	derived bool HasRedToGreenOptionalArguments;
}

class Element
{
	contains Binder[] Binders;
	bool ContainsBinders;

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

	derived bool IsOptionalUpdateParameter;
	derived string RedFieldType;
	derived string RedParameterValue;
	derived string RedPropertyType;
	derived string RedPropertyValue;
	derived string RedToGreenArgument;
	derived string RedToGreenOptionalArgument;
	derived string? RedSyntaxNullCondition;
	derived string? RedSyntaxCondition;

	derived string? VisitCall;
}

abstract class ElementValue
{
	contains Binder[] Binders;
	bool ContainsBinders;

	derived string GreenType;
	derived string? GreenSyntaxCondition;

	derived string RedType;
}

class RuleRef : ElementValue
{
	Rule Rule;

	derived string GreenType;
	derived string? GreenSyntaxCondition;

	derived string RedType;
}

class TokenRef : ElementValue
{
	Token Token;

	derived string GreenType;
	derived string? GreenSyntaxCondition;

	derived string RedType;
}

class TokenAlts : ElementValue
{
	contains TokenRef[] Tokens;

	derived string GreenType;
	derived string? GreenSyntaxCondition;

	derived string RedType;
}

class Eof : ElementValue
{
	derived string GreenType;
	derived string? GreenSyntaxCondition;

	derived string RedType;
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

	derived string RedType;
}

