namespace MetaDslx.Bootstrap.MetaCompiler.Model;

using MetaDslx.CodeAnalysis.Symbols;

metamodel Compiler;

abstract class Declaration $Declared
{
	contains Annotation[] Annotations;
	string $Name;
	Declaration Parent opposite Declarations;
	contains Declaration[] Declarations opposite Parent;
	derived string FullName;
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

class Annotation
{
	TypeSymbol Type;
	contains AnnotationArgument[] Arguments;
}

class AnnotationArgument
{
	DeclaredSymbol Parameter;
	TypeSymbol Type;
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
	TypeSymbol ReturnType;
	bool IsHidden;
	bool IsFragment;

	derived bool IsFixed;
	derived string FixedText;

	contains LexerRuleAlternative[] Alternatives;
}

class LexerRuleAlternative
{
	derived bool IsFixed;
	derived string FixedText;

	contains LexerRuleElement[] Elements;
}

abstract class LexerRuleElement
{
	derived bool IsFixed;
	derived string FixedText;

	bool IsNegated;
	Multiplicity Multiplicity;
}

class LexerRuleReferenceElement : LexerRuleElement
{
	derived bool IsFixed;
	derived string FixedText;

	LexerRule Rule;
}

class LexerRuleFixedStringElement : LexerRuleElement
{
	derived bool IsFixed;
	derived string FixedText;

	string Text;
}

class LexerRuleWildCardElement : LexerRuleElement
{
	derived bool IsFixed;
	derived string FixedText;
}

class LexerRuleRangeElement : LexerRuleElement
{
	derived bool IsFixed;
	derived string FixedText;

	string StartChar;
	string EndChar;
}

class LexerRuleSetElement : LexerRuleElement
{
	derived bool IsFixed;
	derived string FixedText;

	contains LexerRuleSetItem[] Items;
}

abstract class LexerRuleSetItem
{
	derived bool IsFixed;
	derived string FixedText;
}

class LexerRuleSetFixedChar : LexerRuleSetItem
{
	derived bool IsFixed;
	derived string FixedText;

	string Char;
}

class LexerRuleSetRange : LexerRuleSetItem
{
	derived bool IsFixed;
	derived string FixedText;

	string StartChar;
	string EndChar;
}

class LexerRuleBlockElement : LexerRuleElement
{
	derived bool IsFixed;
	derived string FixedText;

	contains LexerRuleAlternative[] Alternatives;
}

abstract class ParserRule : Rule
{
	TypeSymbol ReturnType;
	bool IsBlock;

	contains ParserRuleAlternative[] Alternatives;
}

class ParserRuleAlternative : Declaration
{
	TypeSymbol ReturnType;
	contains Expression ReturnValue;

	contains ParserRuleElement[] Elements;
}

enum AssignmentOperator
{
    Assign,
    QuestionAssign,
    NegatedAssign,
    PlusAssign
}

abstract class ParserRuleElement
{
	contains Annotation[] NameAnnotations;
	contains Annotation[] ValueAnnotations;
	DeclaredSymbol Property;
	AssignmentOperator AssignmentOperator;
	Multiplicity Multiplicity;
}

class ParserRuleReferenceElement : ParserRuleElement
{
	Rule Rule;
	TypeSymbol[] ReferencedTypes;
}

class ParserRuleEofElement : ParserRuleElement
{
}

class ParserRuleFixedStringElement : ParserRuleElement
{
	string Text;
}

class ParserRuleBlockElement : ParserRuleElement
{
	contains ParserRuleAlternative[] Alternatives;
}

class Expression
{
	derived object Value;
}

class NullExpression
{
	derived object Value;
}

class BoolExpression
{
	derived object Value;
	bool BoolValue;
}

class IntExpression
{
	derived object Value;
	int IntValue;
}

class StringExpression
{
	derived object Value;
	string StringValue;
}

class ReferenceExpression
{
	derived object Value;
	DeclaredSymbol SymbolValue;
}
