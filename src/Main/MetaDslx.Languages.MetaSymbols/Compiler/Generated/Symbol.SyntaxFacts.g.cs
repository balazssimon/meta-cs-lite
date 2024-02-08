
#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler.Syntax
{
    using System.Linq;

    public class SymbolSyntaxFacts : global::MetaDslx.CodeAnalysis.Syntax.SyntaxFacts
    {
        private MetaDslx.CodeAnalysis.Syntax.KeywordTokenKind TK_Keyword = new MetaDslx.CodeAnalysis.Syntax.KeywordTokenKind();
        private MetaDslx.CodeAnalysis.Syntax.DefaultSeparatorTokenKind TK_DefaultSeparator = new MetaDslx.CodeAnalysis.Syntax.DefaultSeparatorTokenKind();
        private MetaDslx.CodeAnalysis.Syntax.WhitespaceTokenKind TK_Whitespace = new MetaDslx.CodeAnalysis.Syntax.WhitespaceTokenKind();
        private MetaDslx.CodeAnalysis.Syntax.NumberTokenKind TK_Number = new MetaDslx.CodeAnalysis.Syntax.NumberTokenKind();
        private MetaDslx.CodeAnalysis.Syntax.DefaultIdentifierTokenKind TK_DefaultIdentifier = new MetaDslx.CodeAnalysis.Syntax.DefaultIdentifierTokenKind();
        private MetaDslx.CodeAnalysis.Syntax.IdentifierTokenKind TK_Identifier = new MetaDslx.CodeAnalysis.Syntax.IdentifierTokenKind();
        private MetaDslx.CodeAnalysis.Syntax.StringTokenKind TK_String = new MetaDslx.CodeAnalysis.Syntax.StringTokenKind();
        private MetaDslx.CodeAnalysis.Syntax.DefaultWhitespaceTokenKind TK_DefaultWhitespace = new MetaDslx.CodeAnalysis.Syntax.DefaultWhitespaceTokenKind();
        private MetaDslx.CodeAnalysis.Syntax.DefaultEndOfLineTokenKind TK_DefaultEndOfLine = new MetaDslx.CodeAnalysis.Syntax.DefaultEndOfLineTokenKind();
        private MetaDslx.CodeAnalysis.Syntax.SingleLineCommentTokenKind TK_SingleLineComment = new MetaDslx.CodeAnalysis.Syntax.SingleLineCommentTokenKind();
        private MetaDslx.CodeAnalysis.Syntax.MultiLineCommentTokenKind TK_MultiLineComment = new MetaDslx.CodeAnalysis.Syntax.MultiLineCommentTokenKind();

        public SymbolSyntaxKind DefaultWhitespaceKind => SymbolSyntaxKind.TWhitespace;
        public SymbolSyntaxKind DefaultEndOfLineKind => SymbolSyntaxKind.TLineEnd;
        public SymbolSyntaxKind DefaultSeparatorKind => SymbolSyntaxKind.TComma;
        public SymbolSyntaxKind DefaultIdentifierKind => SymbolSyntaxKind.TIdentifier;
        public SymbolSyntaxKind CompilationUnitKind => SymbolSyntaxKind.Main;

        protected override int DefaultWhitespaceRawKind => (int)DefaultWhitespaceKind;
        protected override int DefaultEndOfLineRawKind => (int)DefaultEndOfLineKind;
        protected override int DefaultSeparatorRawKind => (int)DefaultSeparatorKind;
        protected override int DefaultIdentifierRawKind => (int)DefaultIdentifierKind;
        protected override int CompilationUnitRawKind => (int)CompilationUnitKind;

        public global::MetaDslx.CodeAnalysis.Syntax.TokenKind? GetTokenKind(SymbolSyntaxKind syntaxKind)
        {
            switch (syntaxKind)
            {
                case SymbolSyntaxKind.KNull:
                case SymbolSyntaxKind.KTrue:
                case SymbolSyntaxKind.KFalse:
                case SymbolSyntaxKind.KNamespace:
                case SymbolSyntaxKind.KUsing:
                case SymbolSyntaxKind.KAbstract:
                case SymbolSyntaxKind.KSymbol:
                case SymbolSyntaxKind.KObject:
                case SymbolSyntaxKind.KBool:
                case SymbolSyntaxKind.KChar:
                case SymbolSyntaxKind.KString:
                case SymbolSyntaxKind.KByte:
                case SymbolSyntaxKind.KSbyte:
                case SymbolSyntaxKind.KShort:
                case SymbolSyntaxKind.KUshort:
                case SymbolSyntaxKind.KInt:
                case SymbolSyntaxKind.KUint:
                case SymbolSyntaxKind.KLong:
                case SymbolSyntaxKind.KUlong:
                case SymbolSyntaxKind.KFloat:
                case SymbolSyntaxKind.KDouble:
                case SymbolSyntaxKind.KDecimal:
                case SymbolSyntaxKind.KType:
                case SymbolSyntaxKind.KVoid:
                case SymbolSyntaxKind.KWeak:
                case SymbolSyntaxKind.KDerived:
                return TK_Keyword;
                case SymbolSyntaxKind.TComma:
                return TK_DefaultSeparator;
                case SymbolSyntaxKind.TUtf8Bom:
                return TK_Whitespace;
                case SymbolSyntaxKind.TInteger:
                case SymbolSyntaxKind.TDecimal:
                return TK_Number;
                case SymbolSyntaxKind.TIdentifier:
                return TK_DefaultIdentifier;
                case SymbolSyntaxKind.TVerbatimIdentifier:
                return TK_Identifier;
                case SymbolSyntaxKind.TString:
                return TK_String;
                case SymbolSyntaxKind.TWhitespace:
                return TK_DefaultWhitespace;
                case SymbolSyntaxKind.TLineEnd:
                return TK_DefaultEndOfLine;
                case SymbolSyntaxKind.TSingleLineComment:
                return TK_SingleLineComment;
                case SymbolSyntaxKind.TMultiLineComment:
                return TK_MultiLineComment;
                default:
                    return null;
            }
        }
            
        public override global::MetaDslx.CodeAnalysis.Syntax.TokenKind? GetTokenKind(int rawSyntaxKind)
        {
            return GetTokenKind((SymbolSyntaxKind)rawSyntaxKind);
        }

        public bool IsToken(SymbolSyntaxKind kind)
        {
            switch (kind)
            {
                case SymbolSyntaxKind.Eof:
                case SymbolSyntaxKind.KNull:
                case SymbolSyntaxKind.KTrue:
                case SymbolSyntaxKind.KFalse:
                case SymbolSyntaxKind.TComma:
                case SymbolSyntaxKind.TUtf8Bom:
                case SymbolSyntaxKind.KNamespace:
                case SymbolSyntaxKind.KUsing:
                case SymbolSyntaxKind.KAbstract:
                case SymbolSyntaxKind.KSymbol:
                case SymbolSyntaxKind.TLParen:
                case SymbolSyntaxKind.TRParen:
                case SymbolSyntaxKind.KObject:
                case SymbolSyntaxKind.KBool:
                case SymbolSyntaxKind.KChar:
                case SymbolSyntaxKind.KString:
                case SymbolSyntaxKind.KByte:
                case SymbolSyntaxKind.KSbyte:
                case SymbolSyntaxKind.KShort:
                case SymbolSyntaxKind.KUshort:
                case SymbolSyntaxKind.KInt:
                case SymbolSyntaxKind.KUint:
                case SymbolSyntaxKind.KLong:
                case SymbolSyntaxKind.KUlong:
                case SymbolSyntaxKind.KFloat:
                case SymbolSyntaxKind.KDouble:
                case SymbolSyntaxKind.KDecimal:
                case SymbolSyntaxKind.KType:
                case SymbolSyntaxKind.KVoid:
                case SymbolSyntaxKind.TColon:
                case SymbolSyntaxKind.TLBrace:
                case SymbolSyntaxKind.TRBrace:
                case SymbolSyntaxKind.KWeak:
                case SymbolSyntaxKind.KDerived:
                case SymbolSyntaxKind.TEq:
                case SymbolSyntaxKind.TQuestion:
                case SymbolSyntaxKind.TLBracket:
                case SymbolSyntaxKind.TRBracket:
                case SymbolSyntaxKind.TDot:
                case SymbolSyntaxKind.TInteger:
                case SymbolSyntaxKind.TDecimal:
                case SymbolSyntaxKind.TIdentifier:
                case SymbolSyntaxKind.TVerbatimIdentifier:
                case SymbolSyntaxKind.TString:
                case SymbolSyntaxKind.TWhitespace:
                case SymbolSyntaxKind.TLineEnd:
                case SymbolSyntaxKind.TSingleLineComment:
                case SymbolSyntaxKind.TMultiLineComment:
                case SymbolSyntaxKind.TInvalidToken:
                    return true;
                default:
                    return false;
            }
        }

        protected override bool IsToken(int rawKind)
        {
            return IsToken((SymbolSyntaxKind)rawKind);
        }

        public bool IsFixedToken(SymbolSyntaxKind kind)
        {
            switch (kind)
            {
                case SymbolSyntaxKind.KNull:
                case SymbolSyntaxKind.KTrue:
                case SymbolSyntaxKind.KFalse:
                case SymbolSyntaxKind.TComma:
                case SymbolSyntaxKind.TUtf8Bom:
                case SymbolSyntaxKind.KNamespace:
                case SymbolSyntaxKind.KUsing:
                case SymbolSyntaxKind.KAbstract:
                case SymbolSyntaxKind.KSymbol:
                case SymbolSyntaxKind.TLParen:
                case SymbolSyntaxKind.TRParen:
                case SymbolSyntaxKind.KObject:
                case SymbolSyntaxKind.KBool:
                case SymbolSyntaxKind.KChar:
                case SymbolSyntaxKind.KString:
                case SymbolSyntaxKind.KByte:
                case SymbolSyntaxKind.KSbyte:
                case SymbolSyntaxKind.KShort:
                case SymbolSyntaxKind.KUshort:
                case SymbolSyntaxKind.KInt:
                case SymbolSyntaxKind.KUint:
                case SymbolSyntaxKind.KLong:
                case SymbolSyntaxKind.KUlong:
                case SymbolSyntaxKind.KFloat:
                case SymbolSyntaxKind.KDouble:
                case SymbolSyntaxKind.KDecimal:
                case SymbolSyntaxKind.KType:
                case SymbolSyntaxKind.KVoid:
                case SymbolSyntaxKind.TColon:
                case SymbolSyntaxKind.TLBrace:
                case SymbolSyntaxKind.TRBrace:
                case SymbolSyntaxKind.KWeak:
                case SymbolSyntaxKind.KDerived:
                case SymbolSyntaxKind.TEq:
                case SymbolSyntaxKind.TQuestion:
                case SymbolSyntaxKind.TLBracket:
                case SymbolSyntaxKind.TRBracket:
                case SymbolSyntaxKind.TDot:
                    return true;
                default:
                    return false;
            }
        }

        protected override bool IsFixedToken(int rawKind)
        {
            return IsFixedToken((SymbolSyntaxKind)rawKind);
        }

        public SymbolSyntaxKind GetFixedTokenKind(string text)
        {
            switch (text)
            {
                case "null": 
                    return SymbolSyntaxKind.KNull;
                case "true": 
                    return SymbolSyntaxKind.KTrue;
                case "false": 
                    return SymbolSyntaxKind.KFalse;
                case ",": 
                    return SymbolSyntaxKind.TComma;
                case "\u00ef\u00bb\u00bf": 
                    return SymbolSyntaxKind.TUtf8Bom;
                case "namespace": 
                    return SymbolSyntaxKind.KNamespace;
                case "using": 
                    return SymbolSyntaxKind.KUsing;
                case "abstract": 
                    return SymbolSyntaxKind.KAbstract;
                case "symbol": 
                    return SymbolSyntaxKind.KSymbol;
                case "(": 
                    return SymbolSyntaxKind.TLParen;
                case ")": 
                    return SymbolSyntaxKind.TRParen;
                case "object": 
                    return SymbolSyntaxKind.KObject;
                case "bool": 
                    return SymbolSyntaxKind.KBool;
                case "char": 
                    return SymbolSyntaxKind.KChar;
                case "string": 
                    return SymbolSyntaxKind.KString;
                case "byte": 
                    return SymbolSyntaxKind.KByte;
                case "sbyte": 
                    return SymbolSyntaxKind.KSbyte;
                case "short": 
                    return SymbolSyntaxKind.KShort;
                case "ushort": 
                    return SymbolSyntaxKind.KUshort;
                case "int": 
                    return SymbolSyntaxKind.KInt;
                case "uint": 
                    return SymbolSyntaxKind.KUint;
                case "long": 
                    return SymbolSyntaxKind.KLong;
                case "ulong": 
                    return SymbolSyntaxKind.KUlong;
                case "float": 
                    return SymbolSyntaxKind.KFloat;
                case "double": 
                    return SymbolSyntaxKind.KDouble;
                case "decimal": 
                    return SymbolSyntaxKind.KDecimal;
                case "type": 
                    return SymbolSyntaxKind.KType;
                case "void": 
                    return SymbolSyntaxKind.KVoid;
                case ":": 
                    return SymbolSyntaxKind.TColon;
                case "{": 
                    return SymbolSyntaxKind.TLBrace;
                case "}": 
                    return SymbolSyntaxKind.TRBrace;
                case "weak": 
                    return SymbolSyntaxKind.KWeak;
                case "derived": 
                    return SymbolSyntaxKind.KDerived;
                case "=": 
                    return SymbolSyntaxKind.TEq;
                case "?": 
                    return SymbolSyntaxKind.TQuestion;
                case "[": 
                    return SymbolSyntaxKind.TLBracket;
                case "]": 
                    return SymbolSyntaxKind.TRBracket;
                case ".": 
                    return SymbolSyntaxKind.TDot;
                default:
                    return SymbolSyntaxKind.None;
            }
        }

        protected override int GetFixedTokenRawKind(string text)
        {
            return (int)GetFixedTokenKind(text);
        }


        public object? GetValue(SymbolSyntaxKind kind)
        {
            return null;
        }

        protected override object? GetValue(int rawKind)
        {
            return GetValue((SymbolSyntaxKind)rawKind);
        }

        public string GetKindText(SymbolSyntaxKind kind)
        {
            switch (kind)
            {
                case SymbolSyntaxKind.List:
                    return "List";
                case SymbolSyntaxKind.BadToken:
                    return "BadToken";
                case SymbolSyntaxKind.MissingToken:
                    return "MissingToken";
                case SymbolSyntaxKind.SkippedTokensTrivia:
                    return "SkippedTokensTrivia";
                case SymbolSyntaxKind.DisabledTextTrivia:
                    return "DisabledTextTrivia";
                case SymbolSyntaxKind.ConflictMarkerTrivia:
                    return "ConflictMarkerTrivia";
                case SymbolSyntaxKind.Eof:
                    return "Eof";
                case SymbolSyntaxKind.KNull: 
                    return "KNull";
                case SymbolSyntaxKind.KTrue: 
                    return "KTrue";
                case SymbolSyntaxKind.KFalse: 
                    return "KFalse";
                case SymbolSyntaxKind.TComma: 
                    return "TComma";
                case SymbolSyntaxKind.TUtf8Bom: 
                    return "TUtf8Bom";
                case SymbolSyntaxKind.KNamespace: 
                    return "KNamespace";
                case SymbolSyntaxKind.KUsing: 
                    return "KUsing";
                case SymbolSyntaxKind.KAbstract: 
                    return "KAbstract";
                case SymbolSyntaxKind.KSymbol: 
                    return "KSymbol";
                case SymbolSyntaxKind.TLParen: 
                    return "TLParen";
                case SymbolSyntaxKind.TRParen: 
                    return "TRParen";
                case SymbolSyntaxKind.KObject: 
                    return "KObject";
                case SymbolSyntaxKind.KBool: 
                    return "KBool";
                case SymbolSyntaxKind.KChar: 
                    return "KChar";
                case SymbolSyntaxKind.KString: 
                    return "KString";
                case SymbolSyntaxKind.KByte: 
                    return "KByte";
                case SymbolSyntaxKind.KSbyte: 
                    return "KSbyte";
                case SymbolSyntaxKind.KShort: 
                    return "KShort";
                case SymbolSyntaxKind.KUshort: 
                    return "KUshort";
                case SymbolSyntaxKind.KInt: 
                    return "KInt";
                case SymbolSyntaxKind.KUint: 
                    return "KUint";
                case SymbolSyntaxKind.KLong: 
                    return "KLong";
                case SymbolSyntaxKind.KUlong: 
                    return "KUlong";
                case SymbolSyntaxKind.KFloat: 
                    return "KFloat";
                case SymbolSyntaxKind.KDouble: 
                    return "KDouble";
                case SymbolSyntaxKind.KDecimal: 
                    return "KDecimal";
                case SymbolSyntaxKind.KType: 
                    return "KType";
                case SymbolSyntaxKind.KVoid: 
                    return "KVoid";
                case SymbolSyntaxKind.TColon: 
                    return "TColon";
                case SymbolSyntaxKind.TLBrace: 
                    return "TLBrace";
                case SymbolSyntaxKind.TRBrace: 
                    return "TRBrace";
                case SymbolSyntaxKind.KWeak: 
                    return "KWeak";
                case SymbolSyntaxKind.KDerived: 
                    return "KDerived";
                case SymbolSyntaxKind.TEq: 
                    return "TEq";
                case SymbolSyntaxKind.TQuestion: 
                    return "TQuestion";
                case SymbolSyntaxKind.TLBracket: 
                    return "TLBracket";
                case SymbolSyntaxKind.TRBracket: 
                    return "TRBracket";
                case SymbolSyntaxKind.TDot: 
                    return "TDot";
                case SymbolSyntaxKind.TInteger: 
                    return "TInteger";
                case SymbolSyntaxKind.TDecimal: 
                    return "TDecimal";
                case SymbolSyntaxKind.TIdentifier: 
                    return "TIdentifier";
                case SymbolSyntaxKind.TVerbatimIdentifier: 
                    return "TVerbatimIdentifier";
                case SymbolSyntaxKind.TString: 
                    return "TString";
                case SymbolSyntaxKind.TWhitespace: 
                    return "TWhitespace";
                case SymbolSyntaxKind.TLineEnd: 
                    return "TLineEnd";
                case SymbolSyntaxKind.TSingleLineComment: 
                    return "TSingleLineComment";
                case SymbolSyntaxKind.TMultiLineComment: 
                    return "TMultiLineComment";
                case SymbolSyntaxKind.TInvalidToken: 
                    return "TInvalidToken";
                case SymbolSyntaxKind.Main: 
                    return "Main";
                case SymbolSyntaxKind.Using: 
                    return "Using";
                case SymbolSyntaxKind.Symbol: 
                    return "Symbol";
                case SymbolSyntaxKind.Property: 
                    return "Property";
                case SymbolSyntaxKind.Operation: 
                    return "Operation";
                case SymbolSyntaxKind.Parameter: 
                    return "Parameter";
                case SymbolSyntaxKind.TypeReference: 
                    return "TypeReference";
                case SymbolSyntaxKind.ArrayDimensions: 
                    return "ArrayDimensions";
                case SymbolSyntaxKind.SimpleTypeReferenceAlt1: 
                    return "SimpleTypeReferenceAlt1";
                case SymbolSyntaxKind.SimpleTypeReferenceAlt2: 
                    return "SimpleTypeReferenceAlt2";
                case SymbolSyntaxKind.PrimitiveType: 
                    return "PrimitiveType";
                case SymbolSyntaxKind.ValueAlt1: 
                    return "ValueAlt1";
                case SymbolSyntaxKind.ValueAlt2: 
                    return "ValueAlt2";
                case SymbolSyntaxKind.ValueAlt3: 
                    return "ValueAlt3";
                case SymbolSyntaxKind.ValueAlt4: 
                    return "ValueAlt4";
                case SymbolSyntaxKind.ValueAlt5: 
                    return "ValueAlt5";
                case SymbolSyntaxKind.ValueAlt6: 
                    return "ValueAlt6";
                case SymbolSyntaxKind.Name: 
                    return "Name";
                case SymbolSyntaxKind.Qualifier: 
                    return "Qualifier";
                case SymbolSyntaxKind.Identifier: 
                    return "Identifier";
                case SymbolSyntaxKind.TBoolean: 
                    return "TBoolean";
                case SymbolSyntaxKind.MainBlock1: 
                    return "MainBlock1";
                case SymbolSyntaxKind.SymbolBlock1: 
                    return "SymbolBlock1";
                case SymbolSyntaxKind.SymbolBlock1baseTypesBlock: 
                    return "SymbolBlock1baseTypesBlock";
                case SymbolSyntaxKind.SymbolBlock2: 
                    return "SymbolBlock2";
                case SymbolSyntaxKind.SymbolBlock2Block1Alt1: 
                    return "SymbolBlock2Block1Alt1";
                case SymbolSyntaxKind.SymbolBlock2Block1Alt2: 
                    return "SymbolBlock2Block1Alt2";
                case SymbolSyntaxKind.PropertyBlock1Alt1: 
                    return "PropertyBlock1Alt1";
                case SymbolSyntaxKind.PropertyBlock1Alt2: 
                    return "PropertyBlock1Alt2";
                case SymbolSyntaxKind.PropertyBlock2: 
                    return "PropertyBlock2";
                case SymbolSyntaxKind.OperationBlock1: 
                    return "OperationBlock1";
                case SymbolSyntaxKind.OperationBlock1parametersBlock: 
                    return "OperationBlock1parametersBlock";
                case SymbolSyntaxKind.TypeReferenceBlock1: 
                    return "TypeReferenceBlock1";
                case SymbolSyntaxKind.ArrayDimensionsBlock1: 
                    return "ArrayDimensionsBlock1";
                case SymbolSyntaxKind.QualifierIdentifierBlock: 
                    return "QualifierIdentifierBlock";
                default:
                    return string.Empty;
            }
        }

        protected override string GetKindText(int rawKind)
        {
            return GetKindText((SymbolSyntaxKind)rawKind);
        }

        public string GetText(SymbolSyntaxKind kind)
        {
            switch (kind)
            {
                case SymbolSyntaxKind.KNull: 
                    return "null";
                case SymbolSyntaxKind.KTrue: 
                    return "true";
                case SymbolSyntaxKind.KFalse: 
                    return "false";
                case SymbolSyntaxKind.TComma: 
                    return ",";
                case SymbolSyntaxKind.TUtf8Bom: 
                    return "\u00ef\u00bb\u00bf";
                case SymbolSyntaxKind.KNamespace: 
                    return "namespace";
                case SymbolSyntaxKind.KUsing: 
                    return "using";
                case SymbolSyntaxKind.KAbstract: 
                    return "abstract";
                case SymbolSyntaxKind.KSymbol: 
                    return "symbol";
                case SymbolSyntaxKind.TLParen: 
                    return "(";
                case SymbolSyntaxKind.TRParen: 
                    return ")";
                case SymbolSyntaxKind.KObject: 
                    return "object";
                case SymbolSyntaxKind.KBool: 
                    return "bool";
                case SymbolSyntaxKind.KChar: 
                    return "char";
                case SymbolSyntaxKind.KString: 
                    return "string";
                case SymbolSyntaxKind.KByte: 
                    return "byte";
                case SymbolSyntaxKind.KSbyte: 
                    return "sbyte";
                case SymbolSyntaxKind.KShort: 
                    return "short";
                case SymbolSyntaxKind.KUshort: 
                    return "ushort";
                case SymbolSyntaxKind.KInt: 
                    return "int";
                case SymbolSyntaxKind.KUint: 
                    return "uint";
                case SymbolSyntaxKind.KLong: 
                    return "long";
                case SymbolSyntaxKind.KUlong: 
                    return "ulong";
                case SymbolSyntaxKind.KFloat: 
                    return "float";
                case SymbolSyntaxKind.KDouble: 
                    return "double";
                case SymbolSyntaxKind.KDecimal: 
                    return "decimal";
                case SymbolSyntaxKind.KType: 
                    return "type";
                case SymbolSyntaxKind.KVoid: 
                    return "void";
                case SymbolSyntaxKind.TColon: 
                    return ":";
                case SymbolSyntaxKind.TLBrace: 
                    return "{";
                case SymbolSyntaxKind.TRBrace: 
                    return "}";
                case SymbolSyntaxKind.KWeak: 
                    return "weak";
                case SymbolSyntaxKind.KDerived: 
                    return "derived";
                case SymbolSyntaxKind.TEq: 
                    return "=";
                case SymbolSyntaxKind.TQuestion: 
                    return "?";
                case SymbolSyntaxKind.TLBracket: 
                    return "[";
                case SymbolSyntaxKind.TRBracket: 
                    return "]";
                case SymbolSyntaxKind.TDot: 
                    return ".";
                default:
                    return string.Empty;
            }
        }

        protected override string GetText(int rawKind)
        {
            return GetText((SymbolSyntaxKind)rawKind);
        }

        public bool IsTrivia(SymbolSyntaxKind kind)
        {
            switch(kind)
            {
                case SymbolSyntaxKind.TUtf8Bom: 
                case SymbolSyntaxKind.TWhitespace: 
                case SymbolSyntaxKind.TLineEnd: 
                case SymbolSyntaxKind.TSingleLineComment: 
                case SymbolSyntaxKind.TMultiLineComment: 
                case SymbolSyntaxKind.TInvalidToken: 
                    return true;
                default:
                    return false;
            }
        }

        protected override bool IsTrivia(int rawKind)
        {
            return IsTrivia((SymbolSyntaxKind)rawKind);
        }

        public bool IsReservedKeyword(SymbolSyntaxKind kind)
        {
            switch(kind)
            {
                case SymbolSyntaxKind.KNull: 
                case SymbolSyntaxKind.KTrue: 
                case SymbolSyntaxKind.KFalse: 
                case SymbolSyntaxKind.KNamespace: 
                case SymbolSyntaxKind.KUsing: 
                case SymbolSyntaxKind.KAbstract: 
                case SymbolSyntaxKind.KSymbol: 
                case SymbolSyntaxKind.KObject: 
                case SymbolSyntaxKind.KBool: 
                case SymbolSyntaxKind.KChar: 
                case SymbolSyntaxKind.KString: 
                case SymbolSyntaxKind.KByte: 
                case SymbolSyntaxKind.KSbyte: 
                case SymbolSyntaxKind.KShort: 
                case SymbolSyntaxKind.KUshort: 
                case SymbolSyntaxKind.KInt: 
                case SymbolSyntaxKind.KUint: 
                case SymbolSyntaxKind.KLong: 
                case SymbolSyntaxKind.KUlong: 
                case SymbolSyntaxKind.KFloat: 
                case SymbolSyntaxKind.KDouble: 
                case SymbolSyntaxKind.KDecimal: 
                case SymbolSyntaxKind.KType: 
                case SymbolSyntaxKind.KVoid: 
                case SymbolSyntaxKind.KWeak: 
                case SymbolSyntaxKind.KDerived: 
                    return true;
                default:
                    return false;
            }
        }

        protected override bool IsReservedKeyword(int rawKind)
        {
            return IsReservedKeyword((SymbolSyntaxKind)rawKind);
        }

        public global::System.Collections.Generic.IEnumerable<SymbolSyntaxKind> GetReservedKeywordKinds()
        {
            yield return SymbolSyntaxKind.KNull;
            yield return SymbolSyntaxKind.KTrue;
            yield return SymbolSyntaxKind.KFalse;
            yield return SymbolSyntaxKind.KNamespace;
            yield return SymbolSyntaxKind.KUsing;
            yield return SymbolSyntaxKind.KAbstract;
            yield return SymbolSyntaxKind.KSymbol;
            yield return SymbolSyntaxKind.KObject;
            yield return SymbolSyntaxKind.KBool;
            yield return SymbolSyntaxKind.KChar;
            yield return SymbolSyntaxKind.KString;
            yield return SymbolSyntaxKind.KByte;
            yield return SymbolSyntaxKind.KSbyte;
            yield return SymbolSyntaxKind.KShort;
            yield return SymbolSyntaxKind.KUshort;
            yield return SymbolSyntaxKind.KInt;
            yield return SymbolSyntaxKind.KUint;
            yield return SymbolSyntaxKind.KLong;
            yield return SymbolSyntaxKind.KUlong;
            yield return SymbolSyntaxKind.KFloat;
            yield return SymbolSyntaxKind.KDouble;
            yield return SymbolSyntaxKind.KDecimal;
            yield return SymbolSyntaxKind.KType;
            yield return SymbolSyntaxKind.KVoid;
            yield return SymbolSyntaxKind.KWeak;
            yield return SymbolSyntaxKind.KDerived;
            yield break;
        }

        protected override global::System.Collections.Generic.IEnumerable<int> GetReservedKeywordRawKinds()
        {
            return GetReservedKeywordKinds().Select(kind => (int)kind);
        }

        public SymbolSyntaxKind GetReservedKeywordKind(string text)
        {
            switch(text)
            {
                case "null": 
                    return SymbolSyntaxKind.KNull;
                case "true": 
                    return SymbolSyntaxKind.KTrue;
                case "false": 
                    return SymbolSyntaxKind.KFalse;
                case "namespace": 
                    return SymbolSyntaxKind.KNamespace;
                case "using": 
                    return SymbolSyntaxKind.KUsing;
                case "abstract": 
                    return SymbolSyntaxKind.KAbstract;
                case "symbol": 
                    return SymbolSyntaxKind.KSymbol;
                case "object": 
                    return SymbolSyntaxKind.KObject;
                case "bool": 
                    return SymbolSyntaxKind.KBool;
                case "char": 
                    return SymbolSyntaxKind.KChar;
                case "string": 
                    return SymbolSyntaxKind.KString;
                case "byte": 
                    return SymbolSyntaxKind.KByte;
                case "sbyte": 
                    return SymbolSyntaxKind.KSbyte;
                case "short": 
                    return SymbolSyntaxKind.KShort;
                case "ushort": 
                    return SymbolSyntaxKind.KUshort;
                case "int": 
                    return SymbolSyntaxKind.KInt;
                case "uint": 
                    return SymbolSyntaxKind.KUint;
                case "long": 
                    return SymbolSyntaxKind.KLong;
                case "ulong": 
                    return SymbolSyntaxKind.KUlong;
                case "float": 
                    return SymbolSyntaxKind.KFloat;
                case "double": 
                    return SymbolSyntaxKind.KDouble;
                case "decimal": 
                    return SymbolSyntaxKind.KDecimal;
                case "type": 
                    return SymbolSyntaxKind.KType;
                case "void": 
                    return SymbolSyntaxKind.KVoid;
                case "weak": 
                    return SymbolSyntaxKind.KWeak;
                case "derived": 
                    return SymbolSyntaxKind.KDerived;
                default:
                    return SymbolSyntaxKind.None;
            }
        }

        protected override int GetReservedKeywordRawKind(string text)
        {
            return (int)GetReservedKeywordKind(text);
        }

        public bool IsContextualKeyword(SymbolSyntaxKind kind)
        {
            switch(kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsContextualKeyword(int rawKind)
        {
            return IsContextualKeyword((SymbolSyntaxKind)rawKind);
        }

        public global::System.Collections.Generic.IEnumerable<SymbolSyntaxKind> GetContextualKeywordKinds()
        {
            yield break;
        }

        protected override global::System.Collections.Generic.IEnumerable<int> GetContextualKeywordRawKinds()
        {
            return GetContextualKeywordKinds().Select(kind => (int)kind);
        }

        public SymbolSyntaxKind GetContextualKeywordKind(string text)
        {
            switch(text)
            {
                default:
                    return SymbolSyntaxKind.None;
            }
        }

        protected override int GetContextualKeywordRawKind(string text)
        {
            return (int)GetContextualKeywordKind(text);
        }

        public bool IsPreprocessorKeyword(SymbolSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsPreprocessorKeyword(int rawKind)
        {
            return IsPreprocessorKeyword((SymbolSyntaxKind)rawKind);
        }

        public bool IsPreprocessorContextualKeyword(SymbolSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsPreprocessorContextualKeyword(int rawKind)
        {
            return IsPreprocessorContextualKeyword((SymbolSyntaxKind)rawKind);
        }

        public bool IsPreprocessorDirective(SymbolSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsPreprocessorDirective(int rawKind)
        {
            return IsPreprocessorDirective((SymbolSyntaxKind)rawKind);
        }

        public bool IsIdentifier(SymbolSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsIdentifier(int rawKind)
        {
            return IsIdentifier((SymbolSyntaxKind)rawKind);
        }

        public bool IsGeneralCommentTrivia(SymbolSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsGeneralCommentTrivia(int rawKind)
        {
            return IsGeneralCommentTrivia((SymbolSyntaxKind)rawKind);
        }

        public bool IsDocumentationCommentTrivia(SymbolSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsDocumentationCommentTrivia(int rawKind)
        {
            return IsDocumentationCommentTrivia((SymbolSyntaxKind)rawKind);
        }

        public SymbolLanguageVersion GetRequiredLanguageVersion(string feature)
        {
            return SymbolLanguageVersion.Version1;
        }
    }
}
