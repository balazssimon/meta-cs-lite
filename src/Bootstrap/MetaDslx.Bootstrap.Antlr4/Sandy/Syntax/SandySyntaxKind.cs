// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// WARNING: This is an auto-generated file. Any manual changes will be lost when the file is regenerated.
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using Roslyn.Utilities;

namespace MetaDslx.Bootstrap.Antlr4.Sandy.Syntax
{
	public enum SandySyntaxKind
	{
		__FirstToken = NEWLINE,
		__LastToken = ID,
		__FirstFixedToken = VAR,
		__LastFixedToken = COMMA,
		__FirstRule = Main,
		__LastRule = Type,

		// Built-in:
		None = InternalSyntaxKind.None,
		List = InternalSyntaxKind.List,
		BadToken = InternalSyntaxKind.BadToken,
		MissingToken = InternalSyntaxKind.MissingToken,
		SkippedTokensTrivia = InternalSyntaxKind.SkippedTokensTrivia,
		DisabledTextTrivia = InternalSyntaxKind.DisabledTextTrivia,
		ConflictMarkerTrivia = InternalSyntaxKind.ConflictMarkerTrivia,
		Eof = InternalSyntaxKind.Eof,

		// Tokens:
		NEWLINE,
		WS,
		VAR,
		PRINT,
		AS,
		INT,
		DECIMAL,
		INTLIT,
		DECLIT,
		PLUS,
		MINUS,
		ASTERISK,
		DIVISION,
		ASSIGN,
		LPAREN,
		RPAREN,
		COMMA,
		ID,

		// Rules:
		Main,
		Line,
		Statement,
		Print,
		VarDeclaration,
		Assignment,
		BinaryMulOperation,
		BinaryAddOperation,
		TypeConversion,
		ParenExpression,
		VarReference,
		MinusExpression,
		IntLiteral,
		DecimalLiteral,
		Type
	}
}

