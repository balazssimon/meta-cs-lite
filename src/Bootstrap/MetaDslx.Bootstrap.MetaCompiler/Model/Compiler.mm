namespace MetaDslx.Bootstrap.MetaCompiler.Model;

using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Bootstrap.MetaCompiler.Symbols;

metamodel Compiler;

abstract class $Declaration
{
	contains Annotation[] Annotations $Attributes;
	string? $Name;
	derived string? FullName;
	contains Declaration[] Declarations;
}

class $Namespace : Declaration
{
}

class Language : Declaration
{
	contains Grammar Grammar;
}

class $Grammar : Declaration
{
	Language Language;
	contains Rule[] Rules;
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

abstract class Rule : Declaration
{
	derived Language Language;
	Grammar Grammar;
}

class LexerRule : Rule
{
	type ReturnType;
	bool IsHidden;
	bool IsFragment;

	derived bool IsFixed;
	derived string? FixedText;

	contains LAlternative[] Alternatives;
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

abstract class $ParserRule : Rule
{
	type $ReturnType;

	contains PAlternative[] $Alternatives;
}

class $PAlternative : Declaration
{
	type $ReturnType;
	contains Expression $ReturnValue;

	contains PElement[] $Elements;
}

enum Assignment
{
    Assign,
    QuestionAssign,
    NegatedAssign,
    PlusAssign
}

class $PElement
{
	contains Annotation[] NameAnnotations;
	symbol[] $SymbolProperty;
	Assignment $Assignment;
	contains Annotation[] ValueAnnotations;
	contains PElementValue $Value;
	Multiplicity Multiplicity;
}

abstract class PElementValue $Symbol
{
}

class $PReference : PElementValue
{
	Rule $Rule;
	type[] $ReferencedTypes;
}

class PEof : PElementValue
{
}

class PKeyword : PElementValue
{
	string Text;
}

class $PBlock : Rule, PElementValue
{
	type $ReturnType;
	contains PAlternative[] $Alternatives;
}

class Expression $ExpressionSymbol
{
	symbol $Value;
}

class ArrayExpression : Expression
{
	Expression[] Items;
}
