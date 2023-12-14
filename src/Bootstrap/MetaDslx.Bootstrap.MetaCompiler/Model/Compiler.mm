namespace MetaDslx.Bootstrap.MetaCompiler.Model;

using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Bootstrap.MetaCompiler.Symbols;

metamodel Compiler;

abstract class $Declaration
{
	contains Annotation[] Annotations $Attributes;
	string? $Name;
	Declaration? Parent opposite Declarations;
	contains Declaration[] Declarations opposite Parent;
	derived string? FullName;
}

class $Namespace : Declaration
{
}

class Language : Declaration
{
	derived string Namespace;

	contains Grammar Grammar subsets Declaration.Declarations;
}

class $Grammar : Declaration
{
	Language Language redefines Declaration.Parent;
	contains GrammarRule[] GrammarRules redefines Declaration.Declarations;

	contains TokenKind[] TokenKinds;
	contains Token[] Tokens subsets GrammarRules;
	contains Rule[] Rules subsets GrammarRules;

	Token? DefaultWhitespace;
	Token? DefaultEndOfLine;
	Token? DefaultSeparator;
	Token? DefaultIdentifier;
	Rule? MainRule;
	string? RootTypeName;
}

class $Annotation
{
	type $AttributeClass;
	contains AnnotationArgument[] $Arguments;
}

class $AnnotationArgument
{
	symbol[] $NamedParameter;
	DeclarationSymbol Parameter;
	type ParameterType;
	contains Expression $Value;
}

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

enum Multiplicity
{
	ExactlyOne,
	ZeroOrOne,
	ZeroOrMore,
	OneOrMore,
	NonGreedyZeroOrOne,
	NonGreedyZeroOrMore,
	NonGreedyOneOrMore
}

abstract class GrammarRule : Declaration
{
	derived Language Language;
	Grammar Grammar redefines Declaration.Parent;
}

abstract class LexerRule : GrammarRule
{
	contains LAlternative[] Alternatives;

	derived bool IsFixed;
	derived string? FixedText;
}

class Token : LexerRule
{
	type ReturnType;
	bool IsTrivia;

	TokenKind? TokenKind;
}

class Fragment : LexerRule
{
}

class LAlternative $Symbol
{
	derived bool IsFixed;
	derived string? FixedText;

	contains LElement[] Elements;
}

class LElement $Symbol
{
	derived bool IsFixed;
	derived string? FixedText;

	bool IsNegated;
	contains LElementValue Value;
	Multiplicity Multiplicity;
}

abstract class LElementValue $Symbol
{
	derived bool IsFixed;
	derived string? FixedText;
}

class LReference : LElementValue
{
	derived bool IsFixed;
	derived string? FixedText;

	LexerRule Rule;
}

class LFixed : LElementValue
{
	derived bool IsFixed;
	derived string? FixedText;

	string Text;
}

class LWildCard : LElementValue
{
	derived bool IsFixed;
	derived string? FixedText;
}

class LRange : LElementValue
{
	derived bool IsFixed;
	derived string? FixedText;

	string StartChar;
	string EndChar;
}

class LSet : LElementValue
{
	derived bool IsFixed;
	derived string? FixedText;

	contains LSetItem[] Items;
}

abstract class LSetItem
{
	derived bool IsFixed;
	derived string? FixedText;
}

class LSetChar : LSetItem
{
	derived bool IsFixed;
	derived string? FixedText;

	string Char;
}

class LSetRange : LSetItem
{
	derived bool IsFixed;
	derived string? FixedText;

	string StartChar;
	string EndChar;
}

class LBlock : LElementValue
{
	derived bool IsFixed;
	derived string? FixedText;

	contains LAlternative[] Alternatives;
}

abstract class Rule $ParserRule : GrammarRule
{
	type $ReturnType;
	contains Alternative[] $Alternatives;

	contains Binder[] Binders;
	bool ContainsBinders;

	derived string GreenName;
	derived string RedName;
}

class Alternative $PAlternative : Declaration
{
	type $ReturnType;
	contains Expression $ReturnValue;

	contains Element[] $Elements;

	contains Binder[] Binders;
	bool ContainsBinders;

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

enum Assignment
{
    Assign,
    QuestionAssign,
    NegatedAssign,
    PlusAssign
}

class Element $PElement
{
	contains Annotation[] NameAnnotations;
	symbol[] $SymbolProperty;
	Assignment $Assignment;
	contains Annotation[] ValueAnnotations;
	contains ElementValue $Value;
	Multiplicity Multiplicity;

	string Name;
	contains Binder[] Binders;
	bool ContainsBinders;

	derived bool IsToken;
	derived bool IsList;

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

abstract class ElementValue $Symbol
{
	contains Binder[] Binders;
	bool ContainsBinders;

	derived string GreenType;
	derived string? GreenSyntaxCondition;

	derived string RedType;
}

class RuleRef $PReference : ElementValue
{
	GrammarRule GrammarRule $Rule;
	type[] $ReferencedTypes;

	derived Token? Token;
	derived Rule? Rule;

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

class Keyword : ElementValue
{
	string Text;
}

class TokenAlts : ElementValue
{
	contains RuleRef[] Tokens;

	derived string GreenType;
	derived string? GreenSyntaxCondition;

	derived string RedType;
}

class Block $PBlock : Rule, ElementValue
{
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

class Expression $ExpressionSymbol
{
	symbol $Value;
}

class ArrayExpression : Expression
{
	Expression[] Items;
}
