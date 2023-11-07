using System.Collections.Generic;
using System.Linq;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax
{
	public class MetaCoreSyntaxFacts : SyntaxFacts
	{
		public MetaCoreSyntaxKind DefaultWhitespaceKind => MetaCoreSyntaxKind.TWhitespace;
		public MetaCoreSyntaxKind DefaultEndOfLineKind => MetaCoreSyntaxKind.TLineEnd;
		public MetaCoreSyntaxKind DefaultSeparatorKind => MetaCoreSyntaxKind.TComma;
		public MetaCoreSyntaxKind DefaultIdentifierKind => MetaCoreSyntaxKind.TIdentifier;
		public MetaCoreSyntaxKind CompilationUnitKind => MetaCoreSyntaxKind.Main;

		protected override int DefaultWhitespaceRawKind => (int)DefaultWhitespaceKind;
		protected override int DefaultEndOfLineRawKind => (int)DefaultEndOfLineKind;
		protected override int DefaultSeparatorRawKind => (int)DefaultSeparatorKind;
		protected override int DefaultIdentifierRawKind => (int)DefaultIdentifierKind;
		protected override int CompilationUnitRawKind => (int)CompilationUnitKind;

		public bool IsToken(MetaCoreSyntaxKind kind)
        {
			switch (kind)
			{
				case MetaCoreSyntaxKind.Eof:
				case MetaCoreSyntaxKind.TComma:
				case MetaCoreSyntaxKind.KNamespace:
				case MetaCoreSyntaxKind.TSemicolon:
				case MetaCoreSyntaxKind.KUsing:
				case MetaCoreSyntaxKind.KMetamodel:
				case MetaCoreSyntaxKind.KEnum:
				case MetaCoreSyntaxKind.TLBrace:
				case MetaCoreSyntaxKind.TRBrace:
				case MetaCoreSyntaxKind.KAbstract:
				case MetaCoreSyntaxKind.KClass:
				case MetaCoreSyntaxKind.TDollar:
				case MetaCoreSyntaxKind.TColon:
				case MetaCoreSyntaxKind.KContains:
				case MetaCoreSyntaxKind.KDerived:
				case MetaCoreSyntaxKind.KOpposite:
				case MetaCoreSyntaxKind.KSubsets:
				case MetaCoreSyntaxKind.KRedefines:
				case MetaCoreSyntaxKind.KBool:
				case MetaCoreSyntaxKind.KInt:
				case MetaCoreSyntaxKind.KString:
				case MetaCoreSyntaxKind.KType:
				case MetaCoreSyntaxKind.TLBracket:
				case MetaCoreSyntaxKind.TRBracket:
				case MetaCoreSyntaxKind.TDot:
				case MetaCoreSyntaxKind.TInteger:
				case MetaCoreSyntaxKind.TDecimal:
				case MetaCoreSyntaxKind.TIdentifier:
				case MetaCoreSyntaxKind.TString:
				case MetaCoreSyntaxKind.TWhitespace:
				case MetaCoreSyntaxKind.TLineEnd:
				case MetaCoreSyntaxKind.TSingleLineComment:
				case MetaCoreSyntaxKind.TMultiLineComment:
					return true;
				default:
					return false;
			}
		}

		protected override bool IsToken(int rawKind)
		{
			return IsToken((MetaCoreSyntaxKind)rawKind);
		}

		public bool IsFixedToken(MetaCoreSyntaxKind kind)
        {
			switch (kind)
			{
				case MetaCoreSyntaxKind.TComma:
				case MetaCoreSyntaxKind.KNamespace:
				case MetaCoreSyntaxKind.TSemicolon:
				case MetaCoreSyntaxKind.KUsing:
				case MetaCoreSyntaxKind.KMetamodel:
				case MetaCoreSyntaxKind.KEnum:
				case MetaCoreSyntaxKind.TLBrace:
				case MetaCoreSyntaxKind.TRBrace:
				case MetaCoreSyntaxKind.KAbstract:
				case MetaCoreSyntaxKind.KClass:
				case MetaCoreSyntaxKind.TDollar:
				case MetaCoreSyntaxKind.TColon:
				case MetaCoreSyntaxKind.KContains:
				case MetaCoreSyntaxKind.KDerived:
				case MetaCoreSyntaxKind.KOpposite:
				case MetaCoreSyntaxKind.KSubsets:
				case MetaCoreSyntaxKind.KRedefines:
				case MetaCoreSyntaxKind.KBool:
				case MetaCoreSyntaxKind.KInt:
				case MetaCoreSyntaxKind.KString:
				case MetaCoreSyntaxKind.KType:
				case MetaCoreSyntaxKind.TLBracket:
				case MetaCoreSyntaxKind.TRBracket:
				case MetaCoreSyntaxKind.TDot:
					return true;
				default:
					return false;
			}
		}

		protected override bool IsFixedToken(int rawKind)
		{
			return IsFixedToken((MetaCoreSyntaxKind)rawKind);
		}

        public MetaCoreSyntaxKind GetFixedTokenKind(string text)
		{
			switch (text)
			{
				case ",": 
					return MetaCoreSyntaxKind.TComma;
				case "namespace": 
					return MetaCoreSyntaxKind.KNamespace;
				case ";": 
					return MetaCoreSyntaxKind.TSemicolon;
				case "using": 
					return MetaCoreSyntaxKind.KUsing;
				case "metamodel": 
					return MetaCoreSyntaxKind.KMetamodel;
				case "enum": 
					return MetaCoreSyntaxKind.KEnum;
				case "{": 
					return MetaCoreSyntaxKind.TLBrace;
				case "}": 
					return MetaCoreSyntaxKind.TRBrace;
				case "abstract": 
					return MetaCoreSyntaxKind.KAbstract;
				case "class": 
					return MetaCoreSyntaxKind.KClass;
				case "$": 
					return MetaCoreSyntaxKind.TDollar;
				case ":": 
					return MetaCoreSyntaxKind.TColon;
				case "contains": 
					return MetaCoreSyntaxKind.KContains;
				case "derived": 
					return MetaCoreSyntaxKind.KDerived;
				case "opposite": 
					return MetaCoreSyntaxKind.KOpposite;
				case "subsets": 
					return MetaCoreSyntaxKind.KSubsets;
				case "redefines": 
					return MetaCoreSyntaxKind.KRedefines;
				case "bool": 
					return MetaCoreSyntaxKind.KBool;
				case "int": 
					return MetaCoreSyntaxKind.KInt;
				case "string": 
					return MetaCoreSyntaxKind.KString;
				case "type": 
					return MetaCoreSyntaxKind.KType;
				case "[": 
					return MetaCoreSyntaxKind.TLBracket;
				case "]": 
					return MetaCoreSyntaxKind.TRBracket;
				case ".": 
					return MetaCoreSyntaxKind.TDot;
				default:
					return MetaCoreSyntaxKind.None;
			}
		}

        protected override int GetFixedTokenRawKind(string text)
        {
			return (int)GetFixedTokenKind(text);
        }


        public object? GetValue(MetaCoreSyntaxKind kind)
        {
			return null;
        }

        protected override object? GetValue(int rawKind)
		{
			return GetValue((MetaCoreSyntaxKind)rawKind);
		}

		public string GetKindText(MetaCoreSyntaxKind kind)
		{
			switch (kind)
			{
				case MetaCoreSyntaxKind.List:
					return "List";
				case MetaCoreSyntaxKind.BadToken:
					return "BadToken";
				case MetaCoreSyntaxKind.MissingToken:
					return "MissingToken";
				case MetaCoreSyntaxKind.SkippedTokensTrivia:
					return "SkippedTokensTrivia";
				case MetaCoreSyntaxKind.DisabledTextTrivia:
					return "DisabledTextTrivia";
				case MetaCoreSyntaxKind.ConflictMarkerTrivia:
					return "ConflictMarkerTrivia";
				case MetaCoreSyntaxKind.Eof:
					return "Eof";
				case MetaCoreSyntaxKind.TComma: 
					return "TComma";
				case MetaCoreSyntaxKind.KNamespace: 
					return "KNamespace";
				case MetaCoreSyntaxKind.TSemicolon: 
					return "TSemicolon";
				case MetaCoreSyntaxKind.KUsing: 
					return "KUsing";
				case MetaCoreSyntaxKind.KMetamodel: 
					return "KMetamodel";
				case MetaCoreSyntaxKind.KEnum: 
					return "KEnum";
				case MetaCoreSyntaxKind.TLBrace: 
					return "TLBrace";
				case MetaCoreSyntaxKind.TRBrace: 
					return "TRBrace";
				case MetaCoreSyntaxKind.KAbstract: 
					return "KAbstract";
				case MetaCoreSyntaxKind.KClass: 
					return "KClass";
				case MetaCoreSyntaxKind.TDollar: 
					return "TDollar";
				case MetaCoreSyntaxKind.TColon: 
					return "TColon";
				case MetaCoreSyntaxKind.KContains: 
					return "KContains";
				case MetaCoreSyntaxKind.KDerived: 
					return "KDerived";
				case MetaCoreSyntaxKind.KOpposite: 
					return "KOpposite";
				case MetaCoreSyntaxKind.KSubsets: 
					return "KSubsets";
				case MetaCoreSyntaxKind.KRedefines: 
					return "KRedefines";
				case MetaCoreSyntaxKind.KBool: 
					return "KBool";
				case MetaCoreSyntaxKind.KInt: 
					return "KInt";
				case MetaCoreSyntaxKind.KString: 
					return "KString";
				case MetaCoreSyntaxKind.KType: 
					return "KType";
				case MetaCoreSyntaxKind.TLBracket: 
					return "TLBracket";
				case MetaCoreSyntaxKind.TRBracket: 
					return "TRBracket";
				case MetaCoreSyntaxKind.TDot: 
					return "TDot";
				case MetaCoreSyntaxKind.TInteger: 
					return "TInteger";
				case MetaCoreSyntaxKind.TDecimal: 
					return "TDecimal";
				case MetaCoreSyntaxKind.TIdentifier: 
					return "TIdentifier";
				case MetaCoreSyntaxKind.TString: 
					return "TString";
				case MetaCoreSyntaxKind.TWhitespace: 
					return "TWhitespace";
				case MetaCoreSyntaxKind.TLineEnd: 
					return "TLineEnd";
				case MetaCoreSyntaxKind.TSingleLineComment: 
					return "TSingleLineComment";
				case MetaCoreSyntaxKind.TMultiLineComment: 
					return "TMultiLineComment";
				case MetaCoreSyntaxKind.Main: 
					return "Main";
				case MetaCoreSyntaxKind.Using: 
					return "Using";
				case MetaCoreSyntaxKind.Declarations: 
					return "Declarations";
				case MetaCoreSyntaxKind.MetaModel: 
					return "MetaModel";
				case MetaCoreSyntaxKind.MetaEnumType: 
					return "MetaEnumType";
				case MetaCoreSyntaxKind.MetaClass: 
					return "MetaClass";
				case MetaCoreSyntaxKind.EnumBody: 
					return "EnumBody";
				case MetaCoreSyntaxKind.EnumLiterals: 
					return "EnumLiterals";
				case MetaCoreSyntaxKind.MetaEnumLiteral: 
					return "MetaEnumLiteral";
				case MetaCoreSyntaxKind.ClassNameAlt1: 
					return "ClassNameAlt1";
				case MetaCoreSyntaxKind.ClassNameAlt2: 
					return "ClassNameAlt2";
				case MetaCoreSyntaxKind.BaseClasses: 
					return "BaseClasses";
				case MetaCoreSyntaxKind.ClassBody: 
					return "ClassBody";
				case MetaCoreSyntaxKind.MetaProperty: 
					return "MetaProperty";
				case MetaCoreSyntaxKind.PropertyNameAlt1: 
					return "PropertyNameAlt1";
				case MetaCoreSyntaxKind.PropertyNameAlt2: 
					return "PropertyNameAlt2";
				case MetaCoreSyntaxKind.PropertyOpposite: 
					return "PropertyOpposite";
				case MetaCoreSyntaxKind.PropertySubsets: 
					return "PropertySubsets";
				case MetaCoreSyntaxKind.PropertyRedefines: 
					return "PropertyRedefines";
				case MetaCoreSyntaxKind.MetaArrayType: 
					return "MetaArrayType";
				case MetaCoreSyntaxKind.TypeReferenceAlt3: 
					return "TypeReferenceAlt3";
				case MetaCoreSyntaxKind.TypeReferenceTokens: 
					return "TypeReferenceTokens";
				case MetaCoreSyntaxKind.Name: 
					return "Name";
				case MetaCoreSyntaxKind.Qualifier: 
					return "Qualifier";
				case MetaCoreSyntaxKind.QualifierList: 
					return "QualifierList";
				case MetaCoreSyntaxKind.Identifier: 
					return "Identifier";
				case MetaCoreSyntaxKind.EnumLiteralsBlock1: 
					return "EnumLiteralsBlock1";
				case MetaCoreSyntaxKind.BaseClassesBlock1: 
					return "BaseClassesBlock1";
				case MetaCoreSyntaxKind.MetaPropertyBlock2Alt1: 
					return "MetaPropertyBlock2Alt1";
				case MetaCoreSyntaxKind.MetaPropertyBlock2Alt2: 
					return "MetaPropertyBlock2Alt2";
				case MetaCoreSyntaxKind.MetaPropertyBlock2Alt3: 
					return "MetaPropertyBlock2Alt3";
				case MetaCoreSyntaxKind.PropertyOppositeBlock1: 
					return "PropertyOppositeBlock1";
				case MetaCoreSyntaxKind.PropertySubsetsBlock1: 
					return "PropertySubsetsBlock1";
				case MetaCoreSyntaxKind.PropertyRedefinesBlock1: 
					return "PropertyRedefinesBlock1";
				case MetaCoreSyntaxKind.QualifierBlock1: 
					return "QualifierBlock1";
				case MetaCoreSyntaxKind.QualifierListBlock1: 
					return "QualifierListBlock1";
				default:
					return string.Empty;
			}
		}

		protected override string GetKindText(int rawKind)
		{
			return GetKindText((MetaCoreSyntaxKind)rawKind);
		}

		public string GetText(MetaCoreSyntaxKind kind)
		{
			switch (kind)
			{
				case MetaCoreSyntaxKind.TComma: 
					return ",";
				case MetaCoreSyntaxKind.KNamespace: 
					return "namespace";
				case MetaCoreSyntaxKind.TSemicolon: 
					return ";";
				case MetaCoreSyntaxKind.KUsing: 
					return "using";
				case MetaCoreSyntaxKind.KMetamodel: 
					return "metamodel";
				case MetaCoreSyntaxKind.KEnum: 
					return "enum";
				case MetaCoreSyntaxKind.TLBrace: 
					return "{";
				case MetaCoreSyntaxKind.TRBrace: 
					return "}";
				case MetaCoreSyntaxKind.KAbstract: 
					return "abstract";
				case MetaCoreSyntaxKind.KClass: 
					return "class";
				case MetaCoreSyntaxKind.TDollar: 
					return "$";
				case MetaCoreSyntaxKind.TColon: 
					return ":";
				case MetaCoreSyntaxKind.KContains: 
					return "contains";
				case MetaCoreSyntaxKind.KDerived: 
					return "derived";
				case MetaCoreSyntaxKind.KOpposite: 
					return "opposite";
				case MetaCoreSyntaxKind.KSubsets: 
					return "subsets";
				case MetaCoreSyntaxKind.KRedefines: 
					return "redefines";
				case MetaCoreSyntaxKind.KBool: 
					return "bool";
				case MetaCoreSyntaxKind.KInt: 
					return "int";
				case MetaCoreSyntaxKind.KString: 
					return "string";
				case MetaCoreSyntaxKind.KType: 
					return "type";
				case MetaCoreSyntaxKind.TLBracket: 
					return "[";
				case MetaCoreSyntaxKind.TRBracket: 
					return "]";
				case MetaCoreSyntaxKind.TDot: 
					return ".";
				default:
					return string.Empty;
			}
		}

		protected override string GetText(int rawKind)
        {
			return GetText((MetaCoreSyntaxKind)rawKind);
        }

		public bool IsTrivia(MetaCoreSyntaxKind kind)
		{
			switch(kind)
			{
				case MetaCoreSyntaxKind.TWhitespace: 
				case MetaCoreSyntaxKind.TLineEnd: 
				case MetaCoreSyntaxKind.TSingleLineComment: 
				case MetaCoreSyntaxKind.TMultiLineComment: 
					return true;
				default:
					return false;
			}
		}

        protected override bool IsTrivia(int rawKind)
        {
			return IsTrivia((MetaCoreSyntaxKind)rawKind);
        }

        public bool IsReservedKeyword(MetaCoreSyntaxKind kind)
		{
			switch(kind)
			{
				case MetaCoreSyntaxKind.KNamespace: 
				case MetaCoreSyntaxKind.KUsing: 
				case MetaCoreSyntaxKind.KMetamodel: 
				case MetaCoreSyntaxKind.KEnum: 
				case MetaCoreSyntaxKind.KAbstract: 
				case MetaCoreSyntaxKind.KClass: 
				case MetaCoreSyntaxKind.KContains: 
				case MetaCoreSyntaxKind.KDerived: 
				case MetaCoreSyntaxKind.KOpposite: 
				case MetaCoreSyntaxKind.KSubsets: 
				case MetaCoreSyntaxKind.KRedefines: 
				case MetaCoreSyntaxKind.KBool: 
				case MetaCoreSyntaxKind.KInt: 
				case MetaCoreSyntaxKind.KString: 
				case MetaCoreSyntaxKind.KType: 
					return true;
				default:
					return false;
			}
		}

        protected override bool IsReservedKeyword(int rawKind)
        {
			return IsReservedKeyword((MetaCoreSyntaxKind)rawKind);
        }

        public IEnumerable<MetaCoreSyntaxKind> GetReservedKeywordKinds()
        {
			yield return MetaCoreSyntaxKind.KNamespace;
			yield return MetaCoreSyntaxKind.KUsing;
			yield return MetaCoreSyntaxKind.KMetamodel;
			yield return MetaCoreSyntaxKind.KEnum;
			yield return MetaCoreSyntaxKind.KAbstract;
			yield return MetaCoreSyntaxKind.KClass;
			yield return MetaCoreSyntaxKind.KContains;
			yield return MetaCoreSyntaxKind.KDerived;
			yield return MetaCoreSyntaxKind.KOpposite;
			yield return MetaCoreSyntaxKind.KSubsets;
			yield return MetaCoreSyntaxKind.KRedefines;
			yield return MetaCoreSyntaxKind.KBool;
			yield return MetaCoreSyntaxKind.KInt;
			yield return MetaCoreSyntaxKind.KString;
			yield return MetaCoreSyntaxKind.KType;
			yield break;
        }

        protected override IEnumerable<int> GetReservedKeywordRawKinds()
        {
			return GetReservedKeywordKinds().Select(kind => (int)kind);
        }

        public MetaCoreSyntaxKind GetReservedKeywordKind(string text)
        {
			switch(text)
			{
				case "namespace": 
					return MetaCoreSyntaxKind.KNamespace;
				case "using": 
					return MetaCoreSyntaxKind.KUsing;
				case "metamodel": 
					return MetaCoreSyntaxKind.KMetamodel;
				case "enum": 
					return MetaCoreSyntaxKind.KEnum;
				case "abstract": 
					return MetaCoreSyntaxKind.KAbstract;
				case "class": 
					return MetaCoreSyntaxKind.KClass;
				case "contains": 
					return MetaCoreSyntaxKind.KContains;
				case "derived": 
					return MetaCoreSyntaxKind.KDerived;
				case "opposite": 
					return MetaCoreSyntaxKind.KOpposite;
				case "subsets": 
					return MetaCoreSyntaxKind.KSubsets;
				case "redefines": 
					return MetaCoreSyntaxKind.KRedefines;
				case "bool": 
					return MetaCoreSyntaxKind.KBool;
				case "int": 
					return MetaCoreSyntaxKind.KInt;
				case "string": 
					return MetaCoreSyntaxKind.KString;
				case "type": 
					return MetaCoreSyntaxKind.KType;
				default:
					return MetaCoreSyntaxKind.None;
			}
        }

        protected override int GetReservedKeywordRawKind(string text)
        {
			return (int)GetReservedKeywordKind(text);
        }

        public bool IsContextualKeyword(MetaCoreSyntaxKind kind)
		{
			switch(kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsContextualKeyword(int rawKind)
        {
			return IsContextualKeyword((MetaCoreSyntaxKind)rawKind);
        }

        public IEnumerable<MetaCoreSyntaxKind> GetContextualKeywordKinds()
        {
			yield break;
        }

		protected override IEnumerable<int> GetContextualKeywordRawKinds()
		{
			return GetContextualKeywordKinds().Select(kind => (int)kind);
		}

		public MetaCoreSyntaxKind GetContextualKeywordKind(string text)
        {
			switch(text)
			{
				default:
					return MetaCoreSyntaxKind.None;
			}
        }

        protected override int GetContextualKeywordRawKind(string text)
        {
			return (int)GetContextualKeywordKind(text);
        }

        public bool IsPreprocessorKeyword(MetaCoreSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorKeyword(int rawKind)
        {
			return IsPreprocessorKeyword((MetaCoreSyntaxKind)rawKind);
        }

        public bool IsPreprocessorContextualKeyword(MetaCoreSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorContextualKeyword(int rawKind)
        {
			return IsPreprocessorContextualKeyword((MetaCoreSyntaxKind)rawKind);
        }

        public bool IsPreprocessorDirective(MetaCoreSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorDirective(int rawKind)
        {
			return IsPreprocessorDirective((MetaCoreSyntaxKind)rawKind);
        }

        public bool IsIdentifier(MetaCoreSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsIdentifier(int rawKind)
        {
            return IsIdentifier((MetaCoreSyntaxKind)rawKind);
        }

        public bool IsGeneralCommentTrivia(MetaCoreSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsGeneralCommentTrivia(int rawKind)
        {
            return IsGeneralCommentTrivia((MetaCoreSyntaxKind)rawKind);
        }

        public bool IsDocumentationCommentTrivia(MetaCoreSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsDocumentationCommentTrivia(int rawKind)
        {
			return IsDocumentationCommentTrivia((MetaCoreSyntaxKind)rawKind);
        }

        public MetaCoreLanguageVersion GetRequiredLanguageVersion(string feature)
        {
			return MetaCoreLanguageVersion.Version1;
        }
	}
}
