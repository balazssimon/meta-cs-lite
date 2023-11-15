using System.Collections.Generic;
using System.Linq;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;

#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax
{
	public class MetaSyntaxFacts : SyntaxFacts
	{
		public MetaSyntaxKind DefaultWhitespaceKind => MetaSyntaxKind.TWhitespace;
		public MetaSyntaxKind DefaultEndOfLineKind => MetaSyntaxKind.TLineEnd;
		public MetaSyntaxKind DefaultSeparatorKind => MetaSyntaxKind.TComma;
		public MetaSyntaxKind DefaultIdentifierKind => MetaSyntaxKind.TIdentifier;
		public MetaSyntaxKind CompilationUnitKind => MetaSyntaxKind.Main;

		protected override int DefaultWhitespaceRawKind => (int)DefaultWhitespaceKind;
		protected override int DefaultEndOfLineRawKind => (int)DefaultEndOfLineKind;
		protected override int DefaultSeparatorRawKind => (int)DefaultSeparatorKind;
		protected override int DefaultIdentifierRawKind => (int)DefaultIdentifierKind;
		protected override int CompilationUnitRawKind => (int)CompilationUnitKind;

		public bool IsToken(MetaSyntaxKind kind)
        {
			switch (kind)
			{
				case MetaSyntaxKind.Eof:
				case MetaSyntaxKind.TComma:
				case MetaSyntaxKind.KNamespace:
				case MetaSyntaxKind.TSemicolon:
				case MetaSyntaxKind.KUsing:
				case MetaSyntaxKind.KMetamodel:
				case MetaSyntaxKind.KConst:
				case MetaSyntaxKind.KEnum:
				case MetaSyntaxKind.TLBrace:
				case MetaSyntaxKind.TRBrace:
				case MetaSyntaxKind.KAbstract:
				case MetaSyntaxKind.KClass:
				case MetaSyntaxKind.TDollar:
				case MetaSyntaxKind.TColon:
				case MetaSyntaxKind.KContains:
				case MetaSyntaxKind.KDerived:
				case MetaSyntaxKind.KOpposite:
				case MetaSyntaxKind.KSubsets:
				case MetaSyntaxKind.KRedefines:
				case MetaSyntaxKind.TLParen:
				case MetaSyntaxKind.TRParen:
				case MetaSyntaxKind.KBool:
				case MetaSyntaxKind.KInt:
				case MetaSyntaxKind.KString:
				case MetaSyntaxKind.KType:
				case MetaSyntaxKind.KSymbol:
				case MetaSyntaxKind.KObject:
				case MetaSyntaxKind.KVoid:
				case MetaSyntaxKind.TLBracket:
				case MetaSyntaxKind.TRBracket:
				case MetaSyntaxKind.TQuestion:
				case MetaSyntaxKind.TDot:
				case MetaSyntaxKind.TInteger:
				case MetaSyntaxKind.TDecimal:
				case MetaSyntaxKind.TIdentifier:
				case MetaSyntaxKind.TString:
				case MetaSyntaxKind.TWhitespace:
				case MetaSyntaxKind.TLineEnd:
				case MetaSyntaxKind.TSingleLineComment:
				case MetaSyntaxKind.TMultiLineComment:
					return true;
				default:
					return false;
			}
		}

		protected override bool IsToken(int rawKind)
		{
			return IsToken((MetaSyntaxKind)rawKind);
		}

		public bool IsFixedToken(MetaSyntaxKind kind)
        {
			switch (kind)
			{
				case MetaSyntaxKind.TComma:
				case MetaSyntaxKind.KNamespace:
				case MetaSyntaxKind.TSemicolon:
				case MetaSyntaxKind.KUsing:
				case MetaSyntaxKind.KMetamodel:
				case MetaSyntaxKind.KConst:
				case MetaSyntaxKind.KEnum:
				case MetaSyntaxKind.TLBrace:
				case MetaSyntaxKind.TRBrace:
				case MetaSyntaxKind.KAbstract:
				case MetaSyntaxKind.KClass:
				case MetaSyntaxKind.TDollar:
				case MetaSyntaxKind.TColon:
				case MetaSyntaxKind.KContains:
				case MetaSyntaxKind.KDerived:
				case MetaSyntaxKind.KOpposite:
				case MetaSyntaxKind.KSubsets:
				case MetaSyntaxKind.KRedefines:
				case MetaSyntaxKind.TLParen:
				case MetaSyntaxKind.TRParen:
				case MetaSyntaxKind.KBool:
				case MetaSyntaxKind.KInt:
				case MetaSyntaxKind.KString:
				case MetaSyntaxKind.KType:
				case MetaSyntaxKind.KSymbol:
				case MetaSyntaxKind.KObject:
				case MetaSyntaxKind.KVoid:
				case MetaSyntaxKind.TLBracket:
				case MetaSyntaxKind.TRBracket:
				case MetaSyntaxKind.TQuestion:
				case MetaSyntaxKind.TDot:
					return true;
				default:
					return false;
			}
		}

		protected override bool IsFixedToken(int rawKind)
		{
			return IsFixedToken((MetaSyntaxKind)rawKind);
		}

        public MetaSyntaxKind GetFixedTokenKind(string text)
		{
			switch (text)
			{
				case ",": 
					return MetaSyntaxKind.TComma;
				case "namespace": 
					return MetaSyntaxKind.KNamespace;
				case ";": 
					return MetaSyntaxKind.TSemicolon;
				case "using": 
					return MetaSyntaxKind.KUsing;
				case "metamodel": 
					return MetaSyntaxKind.KMetamodel;
				case "const": 
					return MetaSyntaxKind.KConst;
				case "enum": 
					return MetaSyntaxKind.KEnum;
				case "{": 
					return MetaSyntaxKind.TLBrace;
				case "}": 
					return MetaSyntaxKind.TRBrace;
				case "abstract": 
					return MetaSyntaxKind.KAbstract;
				case "class": 
					return MetaSyntaxKind.KClass;
				case "$": 
					return MetaSyntaxKind.TDollar;
				case ":": 
					return MetaSyntaxKind.TColon;
				case "contains": 
					return MetaSyntaxKind.KContains;
				case "derived": 
					return MetaSyntaxKind.KDerived;
				case "opposite": 
					return MetaSyntaxKind.KOpposite;
				case "subsets": 
					return MetaSyntaxKind.KSubsets;
				case "redefines": 
					return MetaSyntaxKind.KRedefines;
				case "(": 
					return MetaSyntaxKind.TLParen;
				case ")": 
					return MetaSyntaxKind.TRParen;
				case "bool": 
					return MetaSyntaxKind.KBool;
				case "int": 
					return MetaSyntaxKind.KInt;
				case "string": 
					return MetaSyntaxKind.KString;
				case "type": 
					return MetaSyntaxKind.KType;
				case "symbol": 
					return MetaSyntaxKind.KSymbol;
				case "object": 
					return MetaSyntaxKind.KObject;
				case "void": 
					return MetaSyntaxKind.KVoid;
				case "[": 
					return MetaSyntaxKind.TLBracket;
				case "]": 
					return MetaSyntaxKind.TRBracket;
				case "?": 
					return MetaSyntaxKind.TQuestion;
				case ".": 
					return MetaSyntaxKind.TDot;
				default:
					return MetaSyntaxKind.None;
			}
		}

        protected override int GetFixedTokenRawKind(string text)
        {
			return (int)GetFixedTokenKind(text);
        }


        public object? GetValue(MetaSyntaxKind kind)
        {
			return null;
        }

        protected override object? GetValue(int rawKind)
		{
			return GetValue((MetaSyntaxKind)rawKind);
		}

		public string GetKindText(MetaSyntaxKind kind)
		{
			switch (kind)
			{
				case MetaSyntaxKind.List:
					return "List";
				case MetaSyntaxKind.BadToken:
					return "BadToken";
				case MetaSyntaxKind.MissingToken:
					return "MissingToken";
				case MetaSyntaxKind.SkippedTokensTrivia:
					return "SkippedTokensTrivia";
				case MetaSyntaxKind.DisabledTextTrivia:
					return "DisabledTextTrivia";
				case MetaSyntaxKind.ConflictMarkerTrivia:
					return "ConflictMarkerTrivia";
				case MetaSyntaxKind.Eof:
					return "Eof";
				case MetaSyntaxKind.TComma: 
					return "TComma";
				case MetaSyntaxKind.KNamespace: 
					return "KNamespace";
				case MetaSyntaxKind.TSemicolon: 
					return "TSemicolon";
				case MetaSyntaxKind.KUsing: 
					return "KUsing";
				case MetaSyntaxKind.KMetamodel: 
					return "KMetamodel";
				case MetaSyntaxKind.KConst: 
					return "KConst";
				case MetaSyntaxKind.KEnum: 
					return "KEnum";
				case MetaSyntaxKind.TLBrace: 
					return "TLBrace";
				case MetaSyntaxKind.TRBrace: 
					return "TRBrace";
				case MetaSyntaxKind.KAbstract: 
					return "KAbstract";
				case MetaSyntaxKind.KClass: 
					return "KClass";
				case MetaSyntaxKind.TDollar: 
					return "TDollar";
				case MetaSyntaxKind.TColon: 
					return "TColon";
				case MetaSyntaxKind.KContains: 
					return "KContains";
				case MetaSyntaxKind.KDerived: 
					return "KDerived";
				case MetaSyntaxKind.KOpposite: 
					return "KOpposite";
				case MetaSyntaxKind.KSubsets: 
					return "KSubsets";
				case MetaSyntaxKind.KRedefines: 
					return "KRedefines";
				case MetaSyntaxKind.TLParen: 
					return "TLParen";
				case MetaSyntaxKind.TRParen: 
					return "TRParen";
				case MetaSyntaxKind.KBool: 
					return "KBool";
				case MetaSyntaxKind.KInt: 
					return "KInt";
				case MetaSyntaxKind.KString: 
					return "KString";
				case MetaSyntaxKind.KType: 
					return "KType";
				case MetaSyntaxKind.KSymbol: 
					return "KSymbol";
				case MetaSyntaxKind.KObject: 
					return "KObject";
				case MetaSyntaxKind.KVoid: 
					return "KVoid";
				case MetaSyntaxKind.TLBracket: 
					return "TLBracket";
				case MetaSyntaxKind.TRBracket: 
					return "TRBracket";
				case MetaSyntaxKind.TQuestion: 
					return "TQuestion";
				case MetaSyntaxKind.TDot: 
					return "TDot";
				case MetaSyntaxKind.TInteger: 
					return "TInteger";
				case MetaSyntaxKind.TDecimal: 
					return "TDecimal";
				case MetaSyntaxKind.TIdentifier: 
					return "TIdentifier";
				case MetaSyntaxKind.TString: 
					return "TString";
				case MetaSyntaxKind.TWhitespace: 
					return "TWhitespace";
				case MetaSyntaxKind.TLineEnd: 
					return "TLineEnd";
				case MetaSyntaxKind.TSingleLineComment: 
					return "TSingleLineComment";
				case MetaSyntaxKind.TMultiLineComment: 
					return "TMultiLineComment";
				case MetaSyntaxKind.Main: 
					return "Main";
				case MetaSyntaxKind.Using: 
					return "Using";
				case MetaSyntaxKind.Declarations: 
					return "Declarations";
				case MetaSyntaxKind.MetaModel: 
					return "MetaModel";
				case MetaSyntaxKind.MetaConstant: 
					return "MetaConstant";
				case MetaSyntaxKind.MetaEnum: 
					return "MetaEnum";
				case MetaSyntaxKind.MetaClass: 
					return "MetaClass";
				case MetaSyntaxKind.EnumBody: 
					return "EnumBody";
				case MetaSyntaxKind.EnumLiterals: 
					return "EnumLiterals";
				case MetaSyntaxKind.MetaEnumLiteral: 
					return "MetaEnumLiteral";
				case MetaSyntaxKind.ClassNameAlt1: 
					return "ClassNameAlt1";
				case MetaSyntaxKind.ClassNameAlt2: 
					return "ClassNameAlt2";
				case MetaSyntaxKind.BaseClasses: 
					return "BaseClasses";
				case MetaSyntaxKind.ClassBody: 
					return "ClassBody";
				case MetaSyntaxKind.ClassMemberAlt1: 
					return "ClassMemberAlt1";
				case MetaSyntaxKind.ClassMemberAlt2: 
					return "ClassMemberAlt2";
				case MetaSyntaxKind.MetaProperty: 
					return "MetaProperty";
				case MetaSyntaxKind.PropertyNameAlt1: 
					return "PropertyNameAlt1";
				case MetaSyntaxKind.PropertyNameAlt2: 
					return "PropertyNameAlt2";
				case MetaSyntaxKind.PropertyOpposite: 
					return "PropertyOpposite";
				case MetaSyntaxKind.PropertySubsets: 
					return "PropertySubsets";
				case MetaSyntaxKind.PropertyRedefines: 
					return "PropertyRedefines";
				case MetaSyntaxKind.MetaOperation: 
					return "MetaOperation";
				case MetaSyntaxKind.ParameterList: 
					return "ParameterList";
				case MetaSyntaxKind.MetaParameter: 
					return "MetaParameter";
				case MetaSyntaxKind.MetaArrayType: 
					return "MetaArrayType";
				case MetaSyntaxKind.MetaNullableType: 
					return "MetaNullableType";
				case MetaSyntaxKind.TypeReferenceAlt4: 
					return "TypeReferenceAlt4";
				case MetaSyntaxKind.TypeReferenceTokens: 
					return "TypeReferenceTokens";
				case MetaSyntaxKind.Name: 
					return "Name";
				case MetaSyntaxKind.Qualifier: 
					return "Qualifier";
				case MetaSyntaxKind.QualifierList: 
					return "QualifierList";
				case MetaSyntaxKind.Identifier: 
					return "Identifier";
				case MetaSyntaxKind.EnumLiteralsBlock1: 
					return "EnumLiteralsBlock1";
				case MetaSyntaxKind.BaseClassesBlock1: 
					return "BaseClassesBlock1";
				case MetaSyntaxKind.MetaPropertyBlock2Alt1: 
					return "MetaPropertyBlock2Alt1";
				case MetaSyntaxKind.MetaPropertyBlock2Alt2: 
					return "MetaPropertyBlock2Alt2";
				case MetaSyntaxKind.MetaPropertyBlock2Alt3: 
					return "MetaPropertyBlock2Alt3";
				case MetaSyntaxKind.PropertyOppositeBlock1: 
					return "PropertyOppositeBlock1";
				case MetaSyntaxKind.PropertySubsetsBlock1: 
					return "PropertySubsetsBlock1";
				case MetaSyntaxKind.PropertyRedefinesBlock1: 
					return "PropertyRedefinesBlock1";
				case MetaSyntaxKind.ParameterListBlock1: 
					return "ParameterListBlock1";
				case MetaSyntaxKind.QualifierBlock1: 
					return "QualifierBlock1";
				case MetaSyntaxKind.QualifierListBlock1: 
					return "QualifierListBlock1";
				default:
					return string.Empty;
			}
		}

		protected override string GetKindText(int rawKind)
		{
			return GetKindText((MetaSyntaxKind)rawKind);
		}

		public string GetText(MetaSyntaxKind kind)
		{
			switch (kind)
			{
				case MetaSyntaxKind.TComma: 
					return ",";
				case MetaSyntaxKind.KNamespace: 
					return "namespace";
				case MetaSyntaxKind.TSemicolon: 
					return ";";
				case MetaSyntaxKind.KUsing: 
					return "using";
				case MetaSyntaxKind.KMetamodel: 
					return "metamodel";
				case MetaSyntaxKind.KConst: 
					return "const";
				case MetaSyntaxKind.KEnum: 
					return "enum";
				case MetaSyntaxKind.TLBrace: 
					return "{";
				case MetaSyntaxKind.TRBrace: 
					return "}";
				case MetaSyntaxKind.KAbstract: 
					return "abstract";
				case MetaSyntaxKind.KClass: 
					return "class";
				case MetaSyntaxKind.TDollar: 
					return "$";
				case MetaSyntaxKind.TColon: 
					return ":";
				case MetaSyntaxKind.KContains: 
					return "contains";
				case MetaSyntaxKind.KDerived: 
					return "derived";
				case MetaSyntaxKind.KOpposite: 
					return "opposite";
				case MetaSyntaxKind.KSubsets: 
					return "subsets";
				case MetaSyntaxKind.KRedefines: 
					return "redefines";
				case MetaSyntaxKind.TLParen: 
					return "(";
				case MetaSyntaxKind.TRParen: 
					return ")";
				case MetaSyntaxKind.KBool: 
					return "bool";
				case MetaSyntaxKind.KInt: 
					return "int";
				case MetaSyntaxKind.KString: 
					return "string";
				case MetaSyntaxKind.KType: 
					return "type";
				case MetaSyntaxKind.KSymbol: 
					return "symbol";
				case MetaSyntaxKind.KObject: 
					return "object";
				case MetaSyntaxKind.KVoid: 
					return "void";
				case MetaSyntaxKind.TLBracket: 
					return "[";
				case MetaSyntaxKind.TRBracket: 
					return "]";
				case MetaSyntaxKind.TQuestion: 
					return "?";
				case MetaSyntaxKind.TDot: 
					return ".";
				default:
					return string.Empty;
			}
		}

		protected override string GetText(int rawKind)
        {
			return GetText((MetaSyntaxKind)rawKind);
        }

		public bool IsTrivia(MetaSyntaxKind kind)
		{
			switch(kind)
			{
				case MetaSyntaxKind.TWhitespace: 
				case MetaSyntaxKind.TLineEnd: 
				case MetaSyntaxKind.TSingleLineComment: 
				case MetaSyntaxKind.TMultiLineComment: 
					return true;
				default:
					return false;
			}
		}

        protected override bool IsTrivia(int rawKind)
        {
			return IsTrivia((MetaSyntaxKind)rawKind);
        }

        public bool IsReservedKeyword(MetaSyntaxKind kind)
		{
			switch(kind)
			{
				case MetaSyntaxKind.KNamespace: 
				case MetaSyntaxKind.KUsing: 
				case MetaSyntaxKind.KMetamodel: 
				case MetaSyntaxKind.KConst: 
				case MetaSyntaxKind.KEnum: 
				case MetaSyntaxKind.KAbstract: 
				case MetaSyntaxKind.KClass: 
				case MetaSyntaxKind.KContains: 
				case MetaSyntaxKind.KDerived: 
				case MetaSyntaxKind.KOpposite: 
				case MetaSyntaxKind.KSubsets: 
				case MetaSyntaxKind.KRedefines: 
				case MetaSyntaxKind.KBool: 
				case MetaSyntaxKind.KInt: 
				case MetaSyntaxKind.KString: 
				case MetaSyntaxKind.KType: 
				case MetaSyntaxKind.KSymbol: 
				case MetaSyntaxKind.KObject: 
				case MetaSyntaxKind.KVoid: 
					return true;
				default:
					return false;
			}
		}

        protected override bool IsReservedKeyword(int rawKind)
        {
			return IsReservedKeyword((MetaSyntaxKind)rawKind);
        }

        public IEnumerable<MetaSyntaxKind> GetReservedKeywordKinds()
        {
			yield return MetaSyntaxKind.KNamespace;
			yield return MetaSyntaxKind.KUsing;
			yield return MetaSyntaxKind.KMetamodel;
			yield return MetaSyntaxKind.KConst;
			yield return MetaSyntaxKind.KEnum;
			yield return MetaSyntaxKind.KAbstract;
			yield return MetaSyntaxKind.KClass;
			yield return MetaSyntaxKind.KContains;
			yield return MetaSyntaxKind.KDerived;
			yield return MetaSyntaxKind.KOpposite;
			yield return MetaSyntaxKind.KSubsets;
			yield return MetaSyntaxKind.KRedefines;
			yield return MetaSyntaxKind.KBool;
			yield return MetaSyntaxKind.KInt;
			yield return MetaSyntaxKind.KString;
			yield return MetaSyntaxKind.KType;
			yield return MetaSyntaxKind.KSymbol;
			yield return MetaSyntaxKind.KObject;
			yield return MetaSyntaxKind.KVoid;
			yield break;
        }

        protected override IEnumerable<int> GetReservedKeywordRawKinds()
        {
			return GetReservedKeywordKinds().Select(kind => (int)kind);
        }

        public MetaSyntaxKind GetReservedKeywordKind(string text)
        {
			switch(text)
			{
				case "namespace": 
					return MetaSyntaxKind.KNamespace;
				case "using": 
					return MetaSyntaxKind.KUsing;
				case "metamodel": 
					return MetaSyntaxKind.KMetamodel;
				case "const": 
					return MetaSyntaxKind.KConst;
				case "enum": 
					return MetaSyntaxKind.KEnum;
				case "abstract": 
					return MetaSyntaxKind.KAbstract;
				case "class": 
					return MetaSyntaxKind.KClass;
				case "contains": 
					return MetaSyntaxKind.KContains;
				case "derived": 
					return MetaSyntaxKind.KDerived;
				case "opposite": 
					return MetaSyntaxKind.KOpposite;
				case "subsets": 
					return MetaSyntaxKind.KSubsets;
				case "redefines": 
					return MetaSyntaxKind.KRedefines;
				case "bool": 
					return MetaSyntaxKind.KBool;
				case "int": 
					return MetaSyntaxKind.KInt;
				case "string": 
					return MetaSyntaxKind.KString;
				case "type": 
					return MetaSyntaxKind.KType;
				case "symbol": 
					return MetaSyntaxKind.KSymbol;
				case "object": 
					return MetaSyntaxKind.KObject;
				case "void": 
					return MetaSyntaxKind.KVoid;
				default:
					return MetaSyntaxKind.None;
			}
        }

        protected override int GetReservedKeywordRawKind(string text)
        {
			return (int)GetReservedKeywordKind(text);
        }

        public bool IsContextualKeyword(MetaSyntaxKind kind)
		{
			switch(kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsContextualKeyword(int rawKind)
        {
			return IsContextualKeyword((MetaSyntaxKind)rawKind);
        }

        public IEnumerable<MetaSyntaxKind> GetContextualKeywordKinds()
        {
			yield break;
        }

		protected override IEnumerable<int> GetContextualKeywordRawKinds()
		{
			return GetContextualKeywordKinds().Select(kind => (int)kind);
		}

		public MetaSyntaxKind GetContextualKeywordKind(string text)
        {
			switch(text)
			{
				default:
					return MetaSyntaxKind.None;
			}
        }

        protected override int GetContextualKeywordRawKind(string text)
        {
			return (int)GetContextualKeywordKind(text);
        }

        public bool IsPreprocessorKeyword(MetaSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorKeyword(int rawKind)
        {
			return IsPreprocessorKeyword((MetaSyntaxKind)rawKind);
        }

        public bool IsPreprocessorContextualKeyword(MetaSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorContextualKeyword(int rawKind)
        {
			return IsPreprocessorContextualKeyword((MetaSyntaxKind)rawKind);
        }

        public bool IsPreprocessorDirective(MetaSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsPreprocessorDirective(int rawKind)
        {
			return IsPreprocessorDirective((MetaSyntaxKind)rawKind);
        }

        public bool IsIdentifier(MetaSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsIdentifier(int rawKind)
        {
            return IsIdentifier((MetaSyntaxKind)rawKind);
        }

        public bool IsGeneralCommentTrivia(MetaSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsGeneralCommentTrivia(int rawKind)
        {
            return IsGeneralCommentTrivia((MetaSyntaxKind)rawKind);
        }

        public bool IsDocumentationCommentTrivia(MetaSyntaxKind kind)
		{
			switch (kind)
			{
				default:
					return false;
			}
		}

        protected override bool IsDocumentationCommentTrivia(int rawKind)
        {
			return IsDocumentationCommentTrivia((MetaSyntaxKind)rawKind);
        }

        public MetaLanguageVersion GetRequiredLanguageVersion(string feature)
        {
			return MetaLanguageVersion.Version1;
        }
	}
}
