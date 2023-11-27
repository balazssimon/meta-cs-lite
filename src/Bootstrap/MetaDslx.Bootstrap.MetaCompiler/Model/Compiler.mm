namespace MetaDslx.Bootstrap.MetaCompiler.Model;

using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Bootstrap.MetaCompiler.Symbols;

metamodel Compiler;

abstract class Declaration $Declared
{
	contains Annotation[] Annotations $Attributes;
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

class Grammar $GrammarSymbol : Declaration
{
	Language Language redefines Declaration.Parent;
	contains Rule[] Rules;
}

class Annotation $AnnotationSymbol
{
	TypeSymbol $AttributeClass;
	contains AnnotationArgument[] $Arguments;
}

class AnnotationArgument $AnnotationArgumentSymbol
{
	symbol[] $NamedParameter;
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

abstract class ParserRule $ParserRuleSymbol : Rule
{
	type $ReturnType;

	contains PAlternative[] $Alternatives;
}

class PAlternative $PAlternativeSymbol : Declaration
{
	type $ReturnType;
	contains Expression ReturnValue;

	contains PElement[] $Elements;
}

enum Assignment
{
    Assign,
    QuestionAssign,
    NegatedAssign,
    PlusAssign
}

class PElement $PElementSymbol
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

class PReference $PReferenceSymbol : PElementValue
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

class PBlock $PBlockSymbol : Rule, PElementValue
{
	type $ReturnType;
	contains PAlternative[] $Alternatives;
}

abstract class Expression $ExpressionSymbol
{
	derived object? Value;
}

class NullExpression : Expression
{
	derived object? Value;
}

class BoolExpression : Expression
{
	derived object? Value;
	bool BoolValue;
}

class IntExpression : Expression
{
	derived object? Value;
	int IntValue;
}

class StringExpression : Expression
{
	derived object? Value;
	string StringValue;
}

class ReferenceExpression : Expression
{
	derived object? Value;
	symbol? SymbolValue;
}

class ArrayExpression : Expression
{
	derived object? Value;
	Expression[] Items;
}