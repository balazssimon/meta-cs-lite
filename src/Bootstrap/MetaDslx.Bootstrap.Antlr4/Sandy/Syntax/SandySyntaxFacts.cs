// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// WARNING: This is an auto-generated file. Any manual changes will be lost when the file is regenerated.
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using Roslyn.Utilities;

namespace MetaDslx.Bootstrap.Antlr4.Sandy.Syntax
{
	public enum SandyTokenKind : int
	{
		None = 0,
		ContextualKeyword,
		DocumentationCommentTrivia,
		ExternAliasDirective,
		FixedToken,
		GeneralCommentTrivia,
		Identifier,
		PreprocessorContextualKeyword,
		PreprocessorDirective,
		PreprocessorKeyword,
		ReservedKeyword,
		Token,
		Trivia
	}

	public enum SandyLexerMode : int
	{
		None = 0,
		DEFAULT_MODE = 0
	}

	public class SandySyntaxFacts : SyntaxFacts
	{
		public SandySyntaxKind DefaultWhitespaceKind => SandySyntaxKind.WS;
		public SandySyntaxKind DefaultEndOfLineKind => SandySyntaxKind.NEWLINE;
		public SandySyntaxKind DefaultSeparatorKind => SandySyntaxKind.COMMA;
		public SandySyntaxKind DefaultIdentifierKind => SandySyntaxKind.ID;
		public SandySyntaxKind CompilationUnitKind => SandySyntaxKind.Main;
		protected override int DefaultWhitespaceRawKind => (int)DefaultWhitespaceKind;
		protected override int DefaultEndOfLineRawKind => (int)DefaultEndOfLineKind;
		protected override int DefaultSeparatorRawKind => (int)DefaultSeparatorKind;
		protected override int DefaultIdentifierRawKind => (int)DefaultIdentifierKind;
		protected override int CompilationUnitRawKind => (int)CompilationUnitKind;

		public bool IsToken(SandySyntaxKind kind)
        {
			switch (kind)
			{
				case SandySyntaxKind.Eof:
				case SandySyntaxKind.NEWLINE:
				case SandySyntaxKind.WS:
				case SandySyntaxKind.VAR:
				case SandySyntaxKind.PRINT:
				case SandySyntaxKind.AS:
				case SandySyntaxKind.INT:
				case SandySyntaxKind.DECIMAL:
				case SandySyntaxKind.INTLIT:
				case SandySyntaxKind.DECLIT:
				case SandySyntaxKind.PLUS:
				case SandySyntaxKind.MINUS:
				case SandySyntaxKind.ASTERISK:
				case SandySyntaxKind.DIVISION:
				case SandySyntaxKind.ASSIGN:
				case SandySyntaxKind.LPAREN:
				case SandySyntaxKind.RPAREN:
				case SandySyntaxKind.COMMA:
				case SandySyntaxKind.ID:
					return true;
				default:
					return false;
			}
		}

		protected override bool IsToken(int kind)
		{
			return IsToken((SandySyntaxKind)kind);
		}

		public bool IsFixedToken(SandySyntaxKind kind)
		{
			switch (kind)
			{
				case SandySyntaxKind.VAR:
				case SandySyntaxKind.PRINT:
				case SandySyntaxKind.AS:
				case SandySyntaxKind.INT:
				case SandySyntaxKind.DECIMAL:
				case SandySyntaxKind.PLUS:
				case SandySyntaxKind.MINUS:
				case SandySyntaxKind.ASTERISK:
				case SandySyntaxKind.DIVISION:
				case SandySyntaxKind.ASSIGN:
				case SandySyntaxKind.LPAREN:
				case SandySyntaxKind.RPAREN:
				case SandySyntaxKind.COMMA:
					return true;
				default:
					return false;
			}
		}

        protected override bool IsFixedToken(int rawKind)
        {
			return IsFixedToken((SandySyntaxKind)rawKind);
        }

        public SandySyntaxKind GetFixedTokenKind(string text)
		{
			switch (text)
			{
				case "var":
					return SandySyntaxKind.VAR;
				case "print":
					return SandySyntaxKind.PRINT;
				case "as":
					return SandySyntaxKind.AS;
				case "Int":
					return SandySyntaxKind.INT;
				case "Decimal":
					return SandySyntaxKind.DECIMAL;
				case "+":
					return SandySyntaxKind.PLUS;
				case "-":
					return SandySyntaxKind.MINUS;
				case "*":
					return SandySyntaxKind.ASTERISK;
				case "/":
					return SandySyntaxKind.DIVISION;
				case "=":
					return SandySyntaxKind.ASSIGN;
				case "(":
					return SandySyntaxKind.LPAREN;
				case ")":
					return SandySyntaxKind.RPAREN;
				case ",":
					return SandySyntaxKind.COMMA;
				default:
					return SandySyntaxKind.None;
			}
		}

        protected override int GetFixedTokenRawKind(string text)
        {
			return (int)GetFixedTokenKind(text);
        }

        public object? GetValue(SandySyntaxKind kind)
        {
			return null;
        }

        protected override object? GetValue(int rawKind)
		{
			return GetValue((SandySyntaxKind)rawKind);
		}

		public string GetText(SandySyntaxKind kind)
		{
			switch (kind)
			{
				case SandySyntaxKind.VAR:
					return "var";
				case SandySyntaxKind.PRINT:
					return "print";
				case SandySyntaxKind.AS:
					return "as";
				case SandySyntaxKind.INT:
					return "Int";
				case SandySyntaxKind.DECIMAL:
					return "Decimal";
				case SandySyntaxKind.PLUS:
					return "+";
				case SandySyntaxKind.MINUS:
					return "-";
				case SandySyntaxKind.ASTERISK:
					return "*";
				case SandySyntaxKind.DIVISION:
					return "/";
				case SandySyntaxKind.ASSIGN:
					return "=";
				case SandySyntaxKind.LPAREN:
					return "(";
				case SandySyntaxKind.RPAREN:
					return ")";
				case SandySyntaxKind.COMMA:
					return ",";
				default:
					return string.Empty;
			}
		}

        protected override string GetText(int rawKind)
        {
			return GetText((SandySyntaxKind)rawKind);
        }

        public SandyTokenKind GetTokenKind(SandySyntaxKind kind)
		{
			switch(kind)
			{
				default:
					return SandyTokenKind.None;
			}
		}

		public SandyTokenKind GetModeTokenKind(int rawKind)
		{
			return this.GetModeTokenKind((SandyLexerMode)rawKind);
		}

		public SandyTokenKind GetModeTokenKind(SandyLexerMode kind)
		{
			switch(kind)
			{
				default:
					return SandyTokenKind.None;
			}
		}

		public bool IsTrivia(SandySyntaxKind kind)
		{
			switch(kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsTrivia(int rawKind)
        {
			return IsTrivia((SandySyntaxKind)rawKind);
        }

        public bool IsReservedKeyword(SandySyntaxKind kind)
		{
			switch(kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsReservedKeyword(int rawKind)
        {
			return IsReservedKeyword((SandySyntaxKind)rawKind);
        }

        public IEnumerable<SandySyntaxKind> GetReservedKeywordKinds()
        {
			yield break;
        }

        protected override IEnumerable<int> GetReservedKeywordRawKinds()
        {
			return GetReservedKeywordKinds().Select(kind => (int)kind);
        }

        public SandySyntaxKind GetReservedKeywordKind(string text)
        {
			switch(text)
			{
				default:
					return SandySyntaxKind.None;
			}
        }

        protected override int GetReservedKeywordRawKind(string text)
        {
			return (int)GetReservedKeywordKind(text);
        }

        public bool IsContextualKeyword(SandySyntaxKind kind)
		{
			switch(kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsContextualKeyword(int rawKind)
        {
			return IsContextualKeyword((SandySyntaxKind)rawKind);
        }

        public IEnumerable<SandySyntaxKind> GetContextualKeywordKinds()
        {
			yield break;
        }

		protected override IEnumerable<int> GetContextualKeywordRawKinds()
		{
			return GetContextualKeywordKinds().Select(kind => (int)kind);
		}

		public SandySyntaxKind GetContextualKeywordKind(string text)
        {
			switch(text)
			{
				default:
					return SandySyntaxKind.None;
			}
        }

        protected override int GetContextualKeywordRawKind(string text)
        {
			return (int)GetContextualKeywordKind(text);
        }

        public bool IsPreprocessorKeyword(SandySyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorKeyword(int rawKind)
        {
			return IsPreprocessorKeyword((SandySyntaxKind)rawKind);
        }

        public bool IsPreprocessorContextualKeyword(SandySyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorContextualKeyword(int rawKind)
        {
			return IsPreprocessorContextualKeyword((SandySyntaxKind)rawKind);
        }

        public bool IsPreprocessorDirective(SandySyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorDirective(int rawKind)
        {
			return IsPreprocessorDirective((SandySyntaxKind)rawKind);
        }

        public bool IsIdentifier(SandySyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsIdentifier(int rawKind)
        {
            return IsIdentifier((SandySyntaxKind)rawKind);
        }

        public bool IsGeneralCommentTrivia(SandySyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsGeneralCommentTrivia(int rawKind)
        {
            return IsGeneralCommentTrivia((SandySyntaxKind)rawKind);
        }

        public bool IsDocumentationCommentTrivia(SandySyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsDocumentationCommentTrivia(int rawKind)
        {
			return IsDocumentationCommentTrivia((SandySyntaxKind)rawKind);
        }

        public SandyLanguageVersion GetRequiredLanguageVersion(string feature)
        {
			return SandyLanguageVersion.Version1;
        }
	}
}

