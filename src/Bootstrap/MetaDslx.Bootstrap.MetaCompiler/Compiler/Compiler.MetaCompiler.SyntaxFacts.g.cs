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
				case CompilerSyntaxKind.KNamespace:
				case CompilerSyntaxKind.TSemicolon:
				case CompilerSyntaxKind.KUsing:
				case CompilerSyntaxKind.KLanguage:
				case CompilerSyntaxKind.KReturns:
				case CompilerSyntaxKind.TColon:
				case CompilerSyntaxKind.TBar:
				case CompilerSyntaxKind.KBlock:
				case CompilerSyntaxKind.TLBrace:
				case CompilerSyntaxKind.TRBrace:
				case CompilerSyntaxKind.TEqGt:
				case CompilerSyntaxKind.KNull:
				case CompilerSyntaxKind.KTrue:
				case CompilerSyntaxKind.KFalse:
				case CompilerSyntaxKind.TDot:
				case CompilerSyntaxKind.TInteger:
				case CompilerSyntaxKind.TDecimal:
				case CompilerSyntaxKind.TIdentifier:
				case CompilerSyntaxKind.TString:
				case CompilerSyntaxKind.TWhitespace:
				case CompilerSyntaxKind.TLineEnd:
				case CompilerSyntaxKind.TSingleLineComment:
				case CompilerSyntaxKind.TMultiLineComment:
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
				case CompilerSyntaxKind.KNamespace:
				case CompilerSyntaxKind.TSemicolon:
				case CompilerSyntaxKind.KUsing:
				case CompilerSyntaxKind.KLanguage:
				case CompilerSyntaxKind.KReturns:
				case CompilerSyntaxKind.TColon:
				case CompilerSyntaxKind.TBar:
				case CompilerSyntaxKind.KBlock:
				case CompilerSyntaxKind.TLBrace:
				case CompilerSyntaxKind.TRBrace:
				case CompilerSyntaxKind.TEqGt:
				case CompilerSyntaxKind.KNull:
				case CompilerSyntaxKind.KTrue:
				case CompilerSyntaxKind.KFalse:
				case CompilerSyntaxKind.TDot:
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
				case "namespace": 
					return CompilerSyntaxKind.KNamespace;
				case ";": 
					return CompilerSyntaxKind.TSemicolon;
				case "using": 
					return CompilerSyntaxKind.KUsing;
				case "language": 
					return CompilerSyntaxKind.KLanguage;
				case "returns": 
					return CompilerSyntaxKind.KReturns;
				case ":": 
					return CompilerSyntaxKind.TColon;
				case "|": 
					return CompilerSyntaxKind.TBar;
				case "block": 
					return CompilerSyntaxKind.KBlock;
				case "{": 
					return CompilerSyntaxKind.TLBrace;
				case "}": 
					return CompilerSyntaxKind.TRBrace;
				case "=>": 
					return CompilerSyntaxKind.TEqGt;
				case "null": 
					return CompilerSyntaxKind.KNull;
				case "true": 
					return CompilerSyntaxKind.KTrue;
				case "false": 
					return CompilerSyntaxKind.KFalse;
				case ".": 
					return CompilerSyntaxKind.TDot;
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
				case CompilerSyntaxKind.KNamespace: 
					return "KNamespace";
				case CompilerSyntaxKind.TSemicolon: 
					return "TSemicolon";
				case CompilerSyntaxKind.KUsing: 
					return "KUsing";
				case CompilerSyntaxKind.KLanguage: 
					return "KLanguage";
				case CompilerSyntaxKind.KReturns: 
					return "KReturns";
				case CompilerSyntaxKind.TColon: 
					return "TColon";
				case CompilerSyntaxKind.TBar: 
					return "TBar";
				case CompilerSyntaxKind.KBlock: 
					return "KBlock";
				case CompilerSyntaxKind.TLBrace: 
					return "TLBrace";
				case CompilerSyntaxKind.TRBrace: 
					return "TRBrace";
				case CompilerSyntaxKind.TEqGt: 
					return "TEqGt";
				case CompilerSyntaxKind.KNull: 
					return "KNull";
				case CompilerSyntaxKind.KTrue: 
					return "KTrue";
				case CompilerSyntaxKind.KFalse: 
					return "KFalse";
				case CompilerSyntaxKind.TDot: 
					return "TDot";
				case CompilerSyntaxKind.TInteger: 
					return "TInteger";
				case CompilerSyntaxKind.TDecimal: 
					return "TDecimal";
				case CompilerSyntaxKind.TIdentifier: 
					return "TIdentifier";
				case CompilerSyntaxKind.TString: 
					return "TString";
				case CompilerSyntaxKind.TWhitespace: 
					return "TWhitespace";
				case CompilerSyntaxKind.TLineEnd: 
					return "TLineEnd";
				case CompilerSyntaxKind.TSingleLineComment: 
					return "TSingleLineComment";
				case CompilerSyntaxKind.TMultiLineComment: 
					return "TMultiLineComment";
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
				case CompilerSyntaxKind.BlockRule: 
					return "BlockRule";
				case CompilerSyntaxKind.ParserRuleAlternative: 
					return "ParserRuleAlternative";
				case CompilerSyntaxKind.ParserRuleElement: 
					return "ParserRuleElement";
				case CompilerSyntaxKind.IntExpression: 
					return "IntExpression";
				case CompilerSyntaxKind.StringExpression: 
					return "StringExpression";
				case CompilerSyntaxKind.ReferenceExpression: 
					return "ReferenceExpression";
				case CompilerSyntaxKind.ExpressionTokens: 
					return "ExpressionTokens";
				case CompilerSyntaxKind.Name: 
					return "Name";
				case CompilerSyntaxKind.Qualifier: 
					return "Qualifier";
				case CompilerSyntaxKind.QualifierList: 
					return "QualifierList";
				case CompilerSyntaxKind.Identifier: 
					return "Identifier";
				case CompilerSyntaxKind.ParserRuleBlock1: 
					return "ParserRuleBlock1";
				case CompilerSyntaxKind.ParserRuleBlock2: 
					return "ParserRuleBlock2";
				case CompilerSyntaxKind.BlockRuleBlock1: 
					return "BlockRuleBlock1";
				case CompilerSyntaxKind.ParserRuleAlternativeBlock1: 
					return "ParserRuleAlternativeBlock1";
				case CompilerSyntaxKind.ParserRuleAlternativeBlock2: 
					return "ParserRuleAlternativeBlock2";
				case CompilerSyntaxKind.QualifierBlock1: 
					return "QualifierBlock1";
				case CompilerSyntaxKind.QualifierListBlock1: 
					return "QualifierListBlock1";
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
				case CompilerSyntaxKind.KNamespace: 
					return "namespace";
				case CompilerSyntaxKind.TSemicolon: 
					return ";";
				case CompilerSyntaxKind.KUsing: 
					return "using";
				case CompilerSyntaxKind.KLanguage: 
					return "language";
				case CompilerSyntaxKind.KReturns: 
					return "returns";
				case CompilerSyntaxKind.TColon: 
					return ":";
				case CompilerSyntaxKind.TBar: 
					return "|";
				case CompilerSyntaxKind.KBlock: 
					return "block";
				case CompilerSyntaxKind.TLBrace: 
					return "{";
				case CompilerSyntaxKind.TRBrace: 
					return "}";
				case CompilerSyntaxKind.TEqGt: 
					return "=>";
				case CompilerSyntaxKind.KNull: 
					return "null";
				case CompilerSyntaxKind.KTrue: 
					return "true";
				case CompilerSyntaxKind.KFalse: 
					return "false";
				case CompilerSyntaxKind.TDot: 
					return ".";
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
				case CompilerSyntaxKind.KLanguage: 
				case CompilerSyntaxKind.KReturns: 
				case CompilerSyntaxKind.KBlock: 
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
			yield return CompilerSyntaxKind.KLanguage;
			yield return CompilerSyntaxKind.KReturns;
			yield return CompilerSyntaxKind.KBlock;
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
				case "language": 
					return CompilerSyntaxKind.KLanguage;
				case "returns": 
					return CompilerSyntaxKind.KReturns;
				case "block": 
					return CompilerSyntaxKind.KBlock;
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
