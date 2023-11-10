using System.Collections.Generic;
using System.Linq;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
{
	public class CompilerSyntaxFacts : SyntaxFacts
	{
		public CompilerSyntaxKind DefaultWhitespaceKind => CompilerSyntaxKind.TWhitespace;
		public CompilerSyntaxKind DefaultEndOfLineKind => CompilerSyntaxKind.TLineEnd;
		public CompilerSyntaxKind DefaultSeparatorKind => CompilerSyntaxKind.TComma;
		public CompilerSyntaxKind DefaultIdentifierKind => CompilerSyntaxKind.TIdentifier;
		public CompilerSyntaxKind CompilationUnitKind => CompilerSyntaxKind.Main;

		protected override int DefaultWhitespaceRawKind => (int)DefaultWhitespaceKind;
		protected override int DefaultEndOfLineRawKind => (int)DefaultEndOfLineKind;
		protected override int DefaultSeparatorRawKind => (int)DefaultSeparatorKind;
		protected override int DefaultIdentifierRawKind => (int)DefaultIdentifierKind;
		protected override int CompilationUnitRawKind => (int)CompilationUnitKind;

		public bool IsToken(CompilerSyntaxKind kind)
        {
			switch (kind)
			{
				case CompilerSyntaxKind.Eof:
				case CompilerSyntaxKind.TComma:
				case CompilerSyntaxKind.Utf8Bom:
				case CompilerSyntaxKind.KNamespace:
				case CompilerSyntaxKind.TSemicolon:
				case CompilerSyntaxKind.KUsing:
				case CompilerSyntaxKind.KMetamodel:
				case CompilerSyntaxKind.KLanguage:
				case CompilerSyntaxKind.KBlock:
				case CompilerSyntaxKind.KReturns:
				case CompilerSyntaxKind.TColon:
				case CompilerSyntaxKind.TBar:
				case CompilerSyntaxKind.TLBrace:
				case CompilerSyntaxKind.TRBrace:
				case CompilerSyntaxKind.TEqGt:
				case CompilerSyntaxKind.THash:
				case CompilerSyntaxKind.THashLBrace:
				case CompilerSyntaxKind.KEof:
				case CompilerSyntaxKind.TLParen:
				case CompilerSyntaxKind.TRParen:
				case CompilerSyntaxKind.KToken:
				case CompilerSyntaxKind.KHidden:
				case CompilerSyntaxKind.KFragment:
				case CompilerSyntaxKind.TTilde:
				case CompilerSyntaxKind.TDot:
				case CompilerSyntaxKind.TDotDot:
				case CompilerSyntaxKind.KNull:
				case CompilerSyntaxKind.KTrue:
				case CompilerSyntaxKind.KFalse:
				case CompilerSyntaxKind.TLBracket:
				case CompilerSyntaxKind.TRBracket:
				case CompilerSyntaxKind.TEq:
				case CompilerSyntaxKind.TQuestionEq:
				case CompilerSyntaxKind.TExclEq:
				case CompilerSyntaxKind.TPlusEq:
				case CompilerSyntaxKind.TQuestion:
				case CompilerSyntaxKind.TAsterisk:
				case CompilerSyntaxKind.TPlus:
				case CompilerSyntaxKind.TQuestionQuestion:
				case CompilerSyntaxKind.TAsteriskQuestion:
				case CompilerSyntaxKind.TPlusQuestion:
				case CompilerSyntaxKind.TInteger:
				case CompilerSyntaxKind.TDecimal:
				case CompilerSyntaxKind.TIdentifier:
				case CompilerSyntaxKind.TString:
				case CompilerSyntaxKind.DoubleQuoteTextCharacter:
				case CompilerSyntaxKind.DoubleQuoteTextSimple:
				case CompilerSyntaxKind.SingleQuoteTextCharacter:
				case CompilerSyntaxKind.SingleQuoteTextSimple:
				case CompilerSyntaxKind.CharacterEscapeSimple:
				case CompilerSyntaxKind.CharacterEscapeSimpleCharacter:
				case CompilerSyntaxKind.CharacterEscapeUnicode:
				case CompilerSyntaxKind.HexDigit:
				case CompilerSyntaxKind.TWhitespace:
				case CompilerSyntaxKind.TLineEnd:
				case CompilerSyntaxKind.TSingleLineComment:
				case CompilerSyntaxKind.TMultiLineComment:
				case CompilerSyntaxKind.TInvalidToken:
					return true;
				default:
					return false;
			}
		}

		protected override bool IsToken(int rawKind)
		{
			return IsToken((CompilerSyntaxKind)rawKind);
		}

		public bool IsFixedToken(CompilerSyntaxKind kind)
        {
			switch (kind)
			{
				case CompilerSyntaxKind.TComma:
				case CompilerSyntaxKind.Utf8Bom:
				case CompilerSyntaxKind.KNamespace:
				case CompilerSyntaxKind.TSemicolon:
				case CompilerSyntaxKind.KUsing:
				case CompilerSyntaxKind.KMetamodel:
				case CompilerSyntaxKind.KLanguage:
				case CompilerSyntaxKind.KBlock:
				case CompilerSyntaxKind.KReturns:
				case CompilerSyntaxKind.TColon:
				case CompilerSyntaxKind.TBar:
				case CompilerSyntaxKind.TLBrace:
				case CompilerSyntaxKind.TRBrace:
				case CompilerSyntaxKind.TEqGt:
				case CompilerSyntaxKind.THash:
				case CompilerSyntaxKind.THashLBrace:
				case CompilerSyntaxKind.KEof:
				case CompilerSyntaxKind.TLParen:
				case CompilerSyntaxKind.TRParen:
				case CompilerSyntaxKind.KToken:
				case CompilerSyntaxKind.KHidden:
				case CompilerSyntaxKind.KFragment:
				case CompilerSyntaxKind.TTilde:
				case CompilerSyntaxKind.TDot:
				case CompilerSyntaxKind.TDotDot:
				case CompilerSyntaxKind.KNull:
				case CompilerSyntaxKind.KTrue:
				case CompilerSyntaxKind.KFalse:
				case CompilerSyntaxKind.TLBracket:
				case CompilerSyntaxKind.TRBracket:
				case CompilerSyntaxKind.TEq:
				case CompilerSyntaxKind.TQuestionEq:
				case CompilerSyntaxKind.TExclEq:
				case CompilerSyntaxKind.TPlusEq:
				case CompilerSyntaxKind.TQuestion:
				case CompilerSyntaxKind.TAsterisk:
				case CompilerSyntaxKind.TPlus:
				case CompilerSyntaxKind.TQuestionQuestion:
				case CompilerSyntaxKind.TAsteriskQuestion:
				case CompilerSyntaxKind.TPlusQuestion:
					return true;
				default:
					return false;
			}
		}

		protected override bool IsFixedToken(int rawKind)
		{
			return IsFixedToken((CompilerSyntaxKind)rawKind);
		}

        public CompilerSyntaxKind GetFixedTokenKind(string text)
		{
			switch (text)
			{
				case ",": 
					return CompilerSyntaxKind.TComma;
				case "\u00ef\u00bb\u00bf": 
					return CompilerSyntaxKind.Utf8Bom;
				case "namespace": 
					return CompilerSyntaxKind.KNamespace;
				case ";": 
					return CompilerSyntaxKind.TSemicolon;
				case "using": 
					return CompilerSyntaxKind.KUsing;
				case "metamodel": 
					return CompilerSyntaxKind.KMetamodel;
				case "language": 
					return CompilerSyntaxKind.KLanguage;
				case "block": 
					return CompilerSyntaxKind.KBlock;
				case "returns": 
					return CompilerSyntaxKind.KReturns;
				case ":": 
					return CompilerSyntaxKind.TColon;
				case "|": 
					return CompilerSyntaxKind.TBar;
				case "{": 
					return CompilerSyntaxKind.TLBrace;
				case "}": 
					return CompilerSyntaxKind.TRBrace;
				case "=>": 
					return CompilerSyntaxKind.TEqGt;
				case "#": 
					return CompilerSyntaxKind.THash;
				case "#{": 
					return CompilerSyntaxKind.THashLBrace;
				case "eof": 
					return CompilerSyntaxKind.KEof;
				case "(": 
					return CompilerSyntaxKind.TLParen;
				case ")": 
					return CompilerSyntaxKind.TRParen;
				case "token": 
					return CompilerSyntaxKind.KToken;
				case "hidden": 
					return CompilerSyntaxKind.KHidden;
				case "fragment": 
					return CompilerSyntaxKind.KFragment;
				case "~": 
					return CompilerSyntaxKind.TTilde;
				case ".": 
					return CompilerSyntaxKind.TDot;
				case "..": 
					return CompilerSyntaxKind.TDotDot;
				case "null": 
					return CompilerSyntaxKind.KNull;
				case "true": 
					return CompilerSyntaxKind.KTrue;
				case "false": 
					return CompilerSyntaxKind.KFalse;
				case "[": 
					return CompilerSyntaxKind.TLBracket;
				case "]": 
					return CompilerSyntaxKind.TRBracket;
				case "=": 
					return CompilerSyntaxKind.TEq;
				case "?=": 
					return CompilerSyntaxKind.TQuestionEq;
				case "!=": 
					return CompilerSyntaxKind.TExclEq;
				case "+=": 
					return CompilerSyntaxKind.TPlusEq;
				case "?": 
					return CompilerSyntaxKind.TQuestion;
				case "*": 
					return CompilerSyntaxKind.TAsterisk;
				case "+": 
					return CompilerSyntaxKind.TPlus;
				case "??": 
					return CompilerSyntaxKind.TQuestionQuestion;
				case "*?": 
					return CompilerSyntaxKind.TAsteriskQuestion;
				case "+?": 
					return CompilerSyntaxKind.TPlusQuestion;
				default:
					return CompilerSyntaxKind.None;
			}
		}

        protected override int GetFixedTokenRawKind(string text)
        {
			return (int)GetFixedTokenKind(text);
        }


        public object? GetValue(CompilerSyntaxKind kind)
        {
			return null;
        }

        protected override object? GetValue(int rawKind)
		{
			return GetValue((CompilerSyntaxKind)rawKind);
		}

		public string GetKindText(CompilerSyntaxKind kind)
		{
			switch (kind)
			{
				case CompilerSyntaxKind.List:
					return "List";
				case CompilerSyntaxKind.BadToken:
					return "BadToken";
				case CompilerSyntaxKind.MissingToken:
					return "MissingToken";
				case CompilerSyntaxKind.SkippedTokensTrivia:
					return "SkippedTokensTrivia";
				case CompilerSyntaxKind.DisabledTextTrivia:
					return "DisabledTextTrivia";
				case CompilerSyntaxKind.ConflictMarkerTrivia:
					return "ConflictMarkerTrivia";
				case CompilerSyntaxKind.Eof:
					return "Eof";
				case CompilerSyntaxKind.TComma: 
					return "TComma";
				case CompilerSyntaxKind.Utf8Bom: 
					return "Utf8Bom";
				case CompilerSyntaxKind.KNamespace: 
					return "KNamespace";
				case CompilerSyntaxKind.TSemicolon: 
					return "TSemicolon";
				case CompilerSyntaxKind.KUsing: 
					return "KUsing";
				case CompilerSyntaxKind.KMetamodel: 
					return "KMetamodel";
				case CompilerSyntaxKind.KLanguage: 
					return "KLanguage";
				case CompilerSyntaxKind.KBlock: 
					return "KBlock";
				case CompilerSyntaxKind.KReturns: 
					return "KReturns";
				case CompilerSyntaxKind.TColon: 
					return "TColon";
				case CompilerSyntaxKind.TBar: 
					return "TBar";
				case CompilerSyntaxKind.TLBrace: 
					return "TLBrace";
				case CompilerSyntaxKind.TRBrace: 
					return "TRBrace";
				case CompilerSyntaxKind.TEqGt: 
					return "TEqGt";
				case CompilerSyntaxKind.THash: 
					return "THash";
				case CompilerSyntaxKind.THashLBrace: 
					return "THashLBrace";
				case CompilerSyntaxKind.KEof: 
					return "KEof";
				case CompilerSyntaxKind.TLParen: 
					return "TLParen";
				case CompilerSyntaxKind.TRParen: 
					return "TRParen";
				case CompilerSyntaxKind.KToken: 
					return "KToken";
				case CompilerSyntaxKind.KHidden: 
					return "KHidden";
				case CompilerSyntaxKind.KFragment: 
					return "KFragment";
				case CompilerSyntaxKind.TTilde: 
					return "TTilde";
				case CompilerSyntaxKind.TDot: 
					return "TDot";
				case CompilerSyntaxKind.TDotDot: 
					return "TDotDot";
				case CompilerSyntaxKind.KNull: 
					return "KNull";
				case CompilerSyntaxKind.KTrue: 
					return "KTrue";
				case CompilerSyntaxKind.KFalse: 
					return "KFalse";
				case CompilerSyntaxKind.TLBracket: 
					return "TLBracket";
				case CompilerSyntaxKind.TRBracket: 
					return "TRBracket";
				case CompilerSyntaxKind.TEq: 
					return "TEq";
				case CompilerSyntaxKind.TQuestionEq: 
					return "TQuestionEq";
				case CompilerSyntaxKind.TExclEq: 
					return "TExclEq";
				case CompilerSyntaxKind.TPlusEq: 
					return "TPlusEq";
				case CompilerSyntaxKind.TQuestion: 
					return "TQuestion";
				case CompilerSyntaxKind.TAsterisk: 
					return "TAsterisk";
				case CompilerSyntaxKind.TPlus: 
					return "TPlus";
				case CompilerSyntaxKind.TQuestionQuestion: 
					return "TQuestionQuestion";
				case CompilerSyntaxKind.TAsteriskQuestion: 
					return "TAsteriskQuestion";
				case CompilerSyntaxKind.TPlusQuestion: 
					return "TPlusQuestion";
				case CompilerSyntaxKind.TInteger: 
					return "TInteger";
				case CompilerSyntaxKind.TDecimal: 
					return "TDecimal";
				case CompilerSyntaxKind.TIdentifier: 
					return "TIdentifier";
				case CompilerSyntaxKind.TString: 
					return "TString";
				case CompilerSyntaxKind.DoubleQuoteTextCharacter: 
					return "DoubleQuoteTextCharacter";
				case CompilerSyntaxKind.DoubleQuoteTextSimple: 
					return "DoubleQuoteTextSimple";
				case CompilerSyntaxKind.SingleQuoteTextCharacter: 
					return "SingleQuoteTextCharacter";
				case CompilerSyntaxKind.SingleQuoteTextSimple: 
					return "SingleQuoteTextSimple";
				case CompilerSyntaxKind.CharacterEscapeSimple: 
					return "CharacterEscapeSimple";
				case CompilerSyntaxKind.CharacterEscapeSimpleCharacter: 
					return "CharacterEscapeSimpleCharacter";
				case CompilerSyntaxKind.CharacterEscapeUnicode: 
					return "CharacterEscapeUnicode";
				case CompilerSyntaxKind.HexDigit: 
					return "HexDigit";
				case CompilerSyntaxKind.TWhitespace: 
					return "TWhitespace";
				case CompilerSyntaxKind.TLineEnd: 
					return "TLineEnd";
				case CompilerSyntaxKind.TSingleLineComment: 
					return "TSingleLineComment";
				case CompilerSyntaxKind.TMultiLineComment: 
					return "TMultiLineComment";
				case CompilerSyntaxKind.TInvalidToken: 
					return "TInvalidToken";
				case CompilerSyntaxKind.Main: 
					return "Main";
				case CompilerSyntaxKind.Using: 
					return "Using";
				case CompilerSyntaxKind.Declarations: 
					return "Declarations";
				case CompilerSyntaxKind.LanguageDeclaration: 
					return "LanguageDeclaration";
				case CompilerSyntaxKind.ParserRule: 
					return "ParserRule";
				case CompilerSyntaxKind.LexerRule: 
					return "LexerRule";
				case CompilerSyntaxKind.PAlternative: 
					return "PAlternative";
				case CompilerSyntaxKind.PElement: 
					return "PElement";
				case CompilerSyntaxKind.PReferenceAlt1: 
					return "PReferenceAlt1";
				case CompilerSyntaxKind.PReferenceAlt2: 
					return "PReferenceAlt2";
				case CompilerSyntaxKind.PReferenceAlt3: 
					return "PReferenceAlt3";
				case CompilerSyntaxKind.PEof: 
					return "PEof";
				case CompilerSyntaxKind.PKeyword: 
					return "PKeyword";
				case CompilerSyntaxKind.PBlock: 
					return "PBlock";
				case CompilerSyntaxKind.LAlternative: 
					return "LAlternative";
				case CompilerSyntaxKind.LElement: 
					return "LElement";
				case CompilerSyntaxKind.LReference: 
					return "LReference";
				case CompilerSyntaxKind.LFixed: 
					return "LFixed";
				case CompilerSyntaxKind.LWildCard: 
					return "LWildCard";
				case CompilerSyntaxKind.LRange: 
					return "LRange";
				case CompilerSyntaxKind.LBlock: 
					return "LBlock";
				case CompilerSyntaxKind.IntExpression: 
					return "IntExpression";
				case CompilerSyntaxKind.StringExpression: 
					return "StringExpression";
				case CompilerSyntaxKind.ReferenceExpression: 
					return "ReferenceExpression";
				case CompilerSyntaxKind.ExpressionTokens: 
					return "ExpressionTokens";
				case CompilerSyntaxKind.Annotation: 
					return "Annotation";
				case CompilerSyntaxKind.AnnotationArguments: 
					return "AnnotationArguments";
				case CompilerSyntaxKind.AnnotationArgument: 
					return "AnnotationArgument";
				case CompilerSyntaxKind.Name: 
					return "Name";
				case CompilerSyntaxKind.Qualifier: 
					return "Qualifier";
				case CompilerSyntaxKind.QualifierList: 
					return "QualifierList";
				case CompilerSyntaxKind.Identifier: 
					return "Identifier";
				case CompilerSyntaxKind.UsingBlock1Alt1: 
					return "UsingBlock1Alt1";
				case CompilerSyntaxKind.UsingBlock1Alt2: 
					return "UsingBlock1Alt2";
				case CompilerSyntaxKind.ParserRuleBlock1Alt1: 
					return "ParserRuleBlock1Alt1";
				case CompilerSyntaxKind.ParserRuleBlock1Alt2: 
					return "ParserRuleBlock1Alt2";
				case CompilerSyntaxKind.ParserRuleBlock2: 
					return "ParserRuleBlock2";
				case CompilerSyntaxKind.PAlternativeBlock1: 
					return "PAlternativeBlock1";
				case CompilerSyntaxKind.PAlternativeBlock2: 
					return "PAlternativeBlock2";
				case CompilerSyntaxKind.PElementBlock1: 
					return "PElementBlock1";
				case CompilerSyntaxKind.PReferenceAlt3Block1: 
					return "PReferenceAlt3Block1";
				case CompilerSyntaxKind.PBlockBlock1: 
					return "PBlockBlock1";
				case CompilerSyntaxKind.LexerRuleBlock1Alt1: 
					return "LexerRuleBlock1Alt1";
				case CompilerSyntaxKind.LexerRuleBlock1Alt2: 
					return "LexerRuleBlock1Alt2";
				case CompilerSyntaxKind.LexerRuleBlock1Alt3: 
					return "LexerRuleBlock1Alt3";
				case CompilerSyntaxKind.LexerRuleBlock2: 
					return "LexerRuleBlock2";
				case CompilerSyntaxKind.LBlockBlock1: 
					return "LBlockBlock1";
				case CompilerSyntaxKind.AnnotationArgumentsBlock1: 
					return "AnnotationArgumentsBlock1";
				case CompilerSyntaxKind.AnnotationArgumentBlock1: 
					return "AnnotationArgumentBlock1";
				case CompilerSyntaxKind.QualifierBlock1: 
					return "QualifierBlock1";
				case CompilerSyntaxKind.QualifierListBlock1: 
					return "QualifierListBlock1";
				case CompilerSyntaxKind.ParserRuleBlock1Alt2Block1: 
					return "ParserRuleBlock1Alt2Block1";
				case CompilerSyntaxKind.LexerRuleBlock1Alt1Block1: 
					return "LexerRuleBlock1Alt1Block1";
				default:
					return string.Empty;
			}
		}

		protected override string GetKindText(int rawKind)
		{
			return GetKindText((CompilerSyntaxKind)rawKind);
		}

		public string GetText(CompilerSyntaxKind kind)
		{
			switch (kind)
			{
				case CompilerSyntaxKind.TComma: 
					return ",";
				case CompilerSyntaxKind.Utf8Bom: 
					return "\u00ef\u00bb\u00bf";
				case CompilerSyntaxKind.KNamespace: 
					return "namespace";
				case CompilerSyntaxKind.TSemicolon: 
					return ";";
				case CompilerSyntaxKind.KUsing: 
					return "using";
				case CompilerSyntaxKind.KMetamodel: 
					return "metamodel";
				case CompilerSyntaxKind.KLanguage: 
					return "language";
				case CompilerSyntaxKind.KBlock: 
					return "block";
				case CompilerSyntaxKind.KReturns: 
					return "returns";
				case CompilerSyntaxKind.TColon: 
					return ":";
				case CompilerSyntaxKind.TBar: 
					return "|";
				case CompilerSyntaxKind.TLBrace: 
					return "{";
				case CompilerSyntaxKind.TRBrace: 
					return "}";
				case CompilerSyntaxKind.TEqGt: 
					return "=>";
				case CompilerSyntaxKind.THash: 
					return "#";
				case CompilerSyntaxKind.THashLBrace: 
					return "#{";
				case CompilerSyntaxKind.KEof: 
					return "eof";
				case CompilerSyntaxKind.TLParen: 
					return "(";
				case CompilerSyntaxKind.TRParen: 
					return ")";
				case CompilerSyntaxKind.KToken: 
					return "token";
				case CompilerSyntaxKind.KHidden: 
					return "hidden";
				case CompilerSyntaxKind.KFragment: 
					return "fragment";
				case CompilerSyntaxKind.TTilde: 
					return "~";
				case CompilerSyntaxKind.TDot: 
					return ".";
				case CompilerSyntaxKind.TDotDot: 
					return "..";
				case CompilerSyntaxKind.KNull: 
					return "null";
				case CompilerSyntaxKind.KTrue: 
					return "true";
				case CompilerSyntaxKind.KFalse: 
					return "false";
				case CompilerSyntaxKind.TLBracket: 
					return "[";
				case CompilerSyntaxKind.TRBracket: 
					return "]";
				case CompilerSyntaxKind.TEq: 
					return "=";
				case CompilerSyntaxKind.TQuestionEq: 
					return "?=";
				case CompilerSyntaxKind.TExclEq: 
					return "!=";
				case CompilerSyntaxKind.TPlusEq: 
					return "+=";
				case CompilerSyntaxKind.TQuestion: 
					return "?";
				case CompilerSyntaxKind.TAsterisk: 
					return "*";
				case CompilerSyntaxKind.TPlus: 
					return "+";
				case CompilerSyntaxKind.TQuestionQuestion: 
					return "??";
				case CompilerSyntaxKind.TAsteriskQuestion: 
					return "*?";
				case CompilerSyntaxKind.TPlusQuestion: 
					return "+?";
				default:
					return string.Empty;
			}
		}

		protected override string GetText(int rawKind)
        {
			return GetText((CompilerSyntaxKind)rawKind);
        }

		public bool IsTrivia(CompilerSyntaxKind kind)
		{
			switch(kind)
			{
				case CompilerSyntaxKind.Utf8Bom: 
				case CompilerSyntaxKind.TWhitespace: 
				case CompilerSyntaxKind.TLineEnd: 
				case CompilerSyntaxKind.TSingleLineComment: 
				case CompilerSyntaxKind.TMultiLineComment: 
					return true;
				default:
					return false;
			}
		}

        protected override bool IsTrivia(int rawKind)
        {
			return IsTrivia((CompilerSyntaxKind)rawKind);
        }

        public bool IsReservedKeyword(CompilerSyntaxKind kind)
		{
			switch(kind)
			{
				case CompilerSyntaxKind.KNamespace: 
				case CompilerSyntaxKind.KUsing: 
				case CompilerSyntaxKind.KMetamodel: 
				case CompilerSyntaxKind.KLanguage: 
				case CompilerSyntaxKind.KBlock: 
				case CompilerSyntaxKind.KReturns: 
				case CompilerSyntaxKind.KEof: 
				case CompilerSyntaxKind.KToken: 
				case CompilerSyntaxKind.KHidden: 
				case CompilerSyntaxKind.KFragment: 
				case CompilerSyntaxKind.KNull: 
				case CompilerSyntaxKind.KTrue: 
				case CompilerSyntaxKind.KFalse: 
					return true;
				default:
					return false;
			}
		}

        protected override bool IsReservedKeyword(int rawKind)
        {
			return IsReservedKeyword((CompilerSyntaxKind)rawKind);
        }

        public IEnumerable<CompilerSyntaxKind> GetReservedKeywordKinds()
        {
			yield return CompilerSyntaxKind.KNamespace;
			yield return CompilerSyntaxKind.KUsing;
			yield return CompilerSyntaxKind.KMetamodel;
			yield return CompilerSyntaxKind.KLanguage;
			yield return CompilerSyntaxKind.KBlock;
			yield return CompilerSyntaxKind.KReturns;
			yield return CompilerSyntaxKind.KEof;
			yield return CompilerSyntaxKind.KToken;
			yield return CompilerSyntaxKind.KHidden;
			yield return CompilerSyntaxKind.KFragment;
			yield return CompilerSyntaxKind.KNull;
			yield return CompilerSyntaxKind.KTrue;
			yield return CompilerSyntaxKind.KFalse;
			yield break;
        }

        protected override IEnumerable<int> GetReservedKeywordRawKinds()
        {
			return GetReservedKeywordKinds().Select(kind => (int)kind);
        }

        public CompilerSyntaxKind GetReservedKeywordKind(string text)
        {
			switch(text)
			{
				case "namespace": 
					return CompilerSyntaxKind.KNamespace;
				case "using": 
					return CompilerSyntaxKind.KUsing;
				case "metamodel": 
					return CompilerSyntaxKind.KMetamodel;
				case "language": 
					return CompilerSyntaxKind.KLanguage;
				case "block": 
					return CompilerSyntaxKind.KBlock;
				case "returns": 
					return CompilerSyntaxKind.KReturns;
				case "eof": 
					return CompilerSyntaxKind.KEof;
				case "token": 
					return CompilerSyntaxKind.KToken;
				case "hidden": 
					return CompilerSyntaxKind.KHidden;
				case "fragment": 
					return CompilerSyntaxKind.KFragment;
				case "null": 
					return CompilerSyntaxKind.KNull;
				case "true": 
					return CompilerSyntaxKind.KTrue;
				case "false": 
					return CompilerSyntaxKind.KFalse;
				default:
					return CompilerSyntaxKind.None;
			}
        }

        protected override int GetReservedKeywordRawKind(string text)
        {
			return (int)GetReservedKeywordKind(text);
        }

        public bool IsContextualKeyword(CompilerSyntaxKind kind)
		{
			switch(kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsContextualKeyword(int rawKind)
        {
			return IsContextualKeyword((CompilerSyntaxKind)rawKind);
        }

        public IEnumerable<CompilerSyntaxKind> GetContextualKeywordKinds()
        {
			yield break;
        }

		protected override IEnumerable<int> GetContextualKeywordRawKinds()
		{
			return GetContextualKeywordKinds().Select(kind => (int)kind);
		}

		public CompilerSyntaxKind GetContextualKeywordKind(string text)
        {
			switch(text)
			{
				default:
					return CompilerSyntaxKind.None;
			}
        }

        protected override int GetContextualKeywordRawKind(string text)
        {
			return (int)GetContextualKeywordKind(text);
        }

        public bool IsPreprocessorKeyword(CompilerSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorKeyword(int rawKind)
        {
			return IsPreprocessorKeyword((CompilerSyntaxKind)rawKind);
        }

        public bool IsPreprocessorContextualKeyword(CompilerSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorContextualKeyword(int rawKind)
        {
			return IsPreprocessorContextualKeyword((CompilerSyntaxKind)rawKind);
        }

        public bool IsPreprocessorDirective(CompilerSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorDirective(int rawKind)
        {
			return IsPreprocessorDirective((CompilerSyntaxKind)rawKind);
        }

        public bool IsIdentifier(CompilerSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsIdentifier(int rawKind)
        {
            return IsIdentifier((CompilerSyntaxKind)rawKind);
        }

        public bool IsGeneralCommentTrivia(CompilerSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsGeneralCommentTrivia(int rawKind)
        {
            return IsGeneralCommentTrivia((CompilerSyntaxKind)rawKind);
        }

        public bool IsDocumentationCommentTrivia(CompilerSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsDocumentationCommentTrivia(int rawKind)
        {
			return IsDocumentationCommentTrivia((CompilerSyntaxKind)rawKind);
        }

        public CompilerLanguageVersion GetRequiredLanguageVersion(string feature)
        {
			return CompilerLanguageVersion.Version1;
        }
	}
}
