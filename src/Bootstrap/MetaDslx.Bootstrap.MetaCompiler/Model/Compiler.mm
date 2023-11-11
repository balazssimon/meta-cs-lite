namespace MetaDslx.Bootstrap.MetaCompiler.Model;

using MetaDslx.CodeAnalysis.Symbols;

metamodel Compiler;

abstract class Declaration $Declared
{
	contains Annotation[] Annotations;
	string? $Name;
	Declaration? Parent opposite Declarations;
	contains Declaration[] Declarations opposite Parent;
	derived string? FullName;
}

class Namespace $NamespaceSymbol : Declaration
{
}

class Language : Declaration
{
	contains Grammar Grammar subsets Declaration.Declarations;
}

class Grammar : Declaration
{
	Language Language redefines Declaration.Parent;
	contains Rule[] Rules;
}

class Annotation $Symbol
{
	type Type;
	contains AnnotationArgument[] Arguments;
}

class AnnotationArgument $Symbol
{
	string Name;
	contains Expression Value;
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
	Grammar Grammar redefines Declaration.Parent;
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

abstract class ParserRule : Rule
{
	type? ReturnType;
	bool IsBlock;

	contains PAlternative[] Alternatives;
}

class PAlternative : Declaration
{
	type? ReturnType;
	contains Expression ReturnValue;

	contains PElement[] Elements;
}

enum Assignment
{
    Assign,
    QuestionAssign,
    NegatedAssign,
    PlusAssign
}

class PElement $Symbol
{
	contains Annotation[] NameAnnotations;
	string? $Name;
	Assignment Assignment;
	contains Annotation[] ValueAnnotations;
	contains PElementValue Value;
	Multiplicity Multiplicity;
}

abstract class PElementValue
{
}

class PReference : PElementValue
{
	Rule Rule;
	type[] ReferencedTypes;
}

class PEof : PElementValue
{
}

class PKeyword : PElementValue
{
	string Text;
}

class PBlock : PElementValue
{
	contains PAlternative[] Alternatives;
}

abstract class Expression
{
	derived object? Value;
}

class NullExpression
{
	derived object? Value;
}

class BoolExpression
{
	derived object? Value;
	bool BoolValue;
}

class IntExpression
{
	derived object? Value;
	int IntValue;
}

class StringExpression
{
	derived object? Value;
	string StringValue;
}

class ReferenceExpression
{
	derived object? Value;
	symbol SymbolValue;
}
