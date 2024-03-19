
#nullable enable

namespace MetaDslx.Examples.Soal.Compiler.Syntax
{
    using System.Linq;

    public class SoalSyntaxFacts : global::MetaDslx.CodeAnalysis.Syntax.SyntaxFacts
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

        public SoalSyntaxKind DefaultWhitespaceKind => SoalSyntaxKind.TWhitespace;
        public SoalSyntaxKind DefaultEndOfLineKind => SoalSyntaxKind.TLineEnd;
        public SoalSyntaxKind DefaultSeparatorKind => SoalSyntaxKind.TComma;
        public SoalSyntaxKind DefaultIdentifierKind => SoalSyntaxKind.TIdentifier;
        public SoalSyntaxKind CompilationUnitKind => SoalSyntaxKind.Main;

        protected override int DefaultWhitespaceRawKind => (int)DefaultWhitespaceKind;
        protected override int DefaultEndOfLineRawKind => (int)DefaultEndOfLineKind;
        protected override int DefaultSeparatorRawKind => (int)DefaultSeparatorKind;
        protected override int DefaultIdentifierRawKind => (int)DefaultIdentifierKind;
        protected override int CompilationUnitRawKind => (int)CompilationUnitKind;

        public global::MetaDslx.CodeAnalysis.Syntax.TokenKind? GetTokenKind(SoalSyntaxKind syntaxKind)
        {
            switch (syntaxKind)
            {
                case SoalSyntaxKind.KNull:
                case SoalSyntaxKind.KTrue:
                case SoalSyntaxKind.KFalse:
                case SoalSyntaxKind.KNamespace:
                case SoalSyntaxKind.KUsing:
                case SoalSyntaxKind.KEnum:
                case SoalSyntaxKind.KStruct:
                case SoalSyntaxKind.KInterface:
                case SoalSyntaxKind.KReadonly:
                case SoalSyntaxKind.KResource:
                case SoalSyntaxKind.KAsync:
                case SoalSyntaxKind.KVoid:
                case SoalSyntaxKind.KService:
                case SoalSyntaxKind.KBinding:
                case SoalSyntaxKind.KREST:
                case SoalSyntaxKind.KSOAP:
                case SoalSyntaxKind.KObject:
                case SoalSyntaxKind.KBinary:
                case SoalSyntaxKind.KBool:
                case SoalSyntaxKind.KString:
                case SoalSyntaxKind.KInt:
                case SoalSyntaxKind.KLong:
                case SoalSyntaxKind.KFloat:
                case SoalSyntaxKind.KDouble:
                case SoalSyntaxKind.KDate:
                case SoalSyntaxKind.KTime:
                case SoalSyntaxKind.KDatetime:
                case SoalSyntaxKind.KDuration:
                case SoalSyntaxKind.KThrows:
                return TK_Keyword;
                case SoalSyntaxKind.TComma:
                return TK_DefaultSeparator;
                case SoalSyntaxKind.TUtf8Bom:
                return TK_Whitespace;
                case SoalSyntaxKind.TInteger:
                case SoalSyntaxKind.TDecimal:
                return TK_Number;
                case SoalSyntaxKind.TIdentifier:
                return TK_DefaultIdentifier;
                case SoalSyntaxKind.TVerbatimIdentifier:
                return TK_Identifier;
                case SoalSyntaxKind.TString:
                return TK_String;
                case SoalSyntaxKind.TWhitespace:
                return TK_DefaultWhitespace;
                case SoalSyntaxKind.TLineEnd:
                return TK_DefaultEndOfLine;
                case SoalSyntaxKind.TSingleLineComment:
                return TK_SingleLineComment;
                case SoalSyntaxKind.TMultiLineComment:
                return TK_MultiLineComment;
                default:
                    return null;
            }
        }
            
        public override global::MetaDslx.CodeAnalysis.Syntax.TokenKind? GetTokenKind(int rawSyntaxKind)
        {
            return GetTokenKind((SoalSyntaxKind)rawSyntaxKind);
        }

        public bool IsToken(SoalSyntaxKind kind)
        {
            switch (kind)
            {
                case SoalSyntaxKind.Eof:
                case SoalSyntaxKind.KNull:
                case SoalSyntaxKind.KTrue:
                case SoalSyntaxKind.KFalse:
                case SoalSyntaxKind.TComma:
                case SoalSyntaxKind.TUtf8Bom:
                case SoalSyntaxKind.KNamespace:
                case SoalSyntaxKind.TSemicolon:
                case SoalSyntaxKind.KUsing:
                case SoalSyntaxKind.KEnum:
                case SoalSyntaxKind.TLBrace:
                case SoalSyntaxKind.TRBrace:
                case SoalSyntaxKind.KStruct:
                case SoalSyntaxKind.KInterface:
                case SoalSyntaxKind.KReadonly:
                case SoalSyntaxKind.KResource:
                case SoalSyntaxKind.KAsync:
                case SoalSyntaxKind.TLParen:
                case SoalSyntaxKind.TRParen:
                case SoalSyntaxKind.KVoid:
                case SoalSyntaxKind.KService:
                case SoalSyntaxKind.TColon:
                case SoalSyntaxKind.KBinding:
                case SoalSyntaxKind.KREST:
                case SoalSyntaxKind.KSOAP:
                case SoalSyntaxKind.TQuestion:
                case SoalSyntaxKind.KObject:
                case SoalSyntaxKind.KBinary:
                case SoalSyntaxKind.KBool:
                case SoalSyntaxKind.KString:
                case SoalSyntaxKind.KInt:
                case SoalSyntaxKind.KLong:
                case SoalSyntaxKind.KFloat:
                case SoalSyntaxKind.KDouble:
                case SoalSyntaxKind.KDate:
                case SoalSyntaxKind.KTime:
                case SoalSyntaxKind.KDatetime:
                case SoalSyntaxKind.KDuration:
                case SoalSyntaxKind.KThrows:
                case SoalSyntaxKind.TLBracket:
                case SoalSyntaxKind.TRBracket:
                case SoalSyntaxKind.TDot:
                case SoalSyntaxKind.TInteger:
                case SoalSyntaxKind.TDecimal:
                case SoalSyntaxKind.TIdentifier:
                case SoalSyntaxKind.TVerbatimIdentifier:
                case SoalSyntaxKind.TString:
                case SoalSyntaxKind.TWhitespace:
                case SoalSyntaxKind.TLineEnd:
                case SoalSyntaxKind.TSingleLineComment:
                case SoalSyntaxKind.TMultiLineComment:
                case SoalSyntaxKind.TInvalidToken:
                    return true;
                default:
                    return false;
            }
        }

        protected override bool IsToken(int rawKind)
        {
            return IsToken((SoalSyntaxKind)rawKind);
        }

        public bool IsFixedToken(SoalSyntaxKind kind)
        {
            switch (kind)
            {
                case SoalSyntaxKind.KNull:
                case SoalSyntaxKind.KTrue:
                case SoalSyntaxKind.KFalse:
                case SoalSyntaxKind.TComma:
                case SoalSyntaxKind.TUtf8Bom:
                case SoalSyntaxKind.KNamespace:
                case SoalSyntaxKind.TSemicolon:
                case SoalSyntaxKind.KUsing:
                case SoalSyntaxKind.KEnum:
                case SoalSyntaxKind.TLBrace:
                case SoalSyntaxKind.TRBrace:
                case SoalSyntaxKind.KStruct:
                case SoalSyntaxKind.KInterface:
                case SoalSyntaxKind.KReadonly:
                case SoalSyntaxKind.KResource:
                case SoalSyntaxKind.KAsync:
                case SoalSyntaxKind.TLParen:
                case SoalSyntaxKind.TRParen:
                case SoalSyntaxKind.KVoid:
                case SoalSyntaxKind.KService:
                case SoalSyntaxKind.TColon:
                case SoalSyntaxKind.KBinding:
                case SoalSyntaxKind.KREST:
                case SoalSyntaxKind.KSOAP:
                case SoalSyntaxKind.TQuestion:
                case SoalSyntaxKind.KObject:
                case SoalSyntaxKind.KBinary:
                case SoalSyntaxKind.KBool:
                case SoalSyntaxKind.KString:
                case SoalSyntaxKind.KInt:
                case SoalSyntaxKind.KLong:
                case SoalSyntaxKind.KFloat:
                case SoalSyntaxKind.KDouble:
                case SoalSyntaxKind.KDate:
                case SoalSyntaxKind.KTime:
                case SoalSyntaxKind.KDatetime:
                case SoalSyntaxKind.KDuration:
                case SoalSyntaxKind.KThrows:
                case SoalSyntaxKind.TLBracket:
                case SoalSyntaxKind.TRBracket:
                case SoalSyntaxKind.TDot:
                    return true;
                default:
                    return false;
            }
        }

        protected override bool IsFixedToken(int rawKind)
        {
            return IsFixedToken((SoalSyntaxKind)rawKind);
        }

        public SoalSyntaxKind GetFixedTokenKind(string text)
        {
            switch (text)
            {
                case "null": 
                    return SoalSyntaxKind.KNull;
                case "true": 
                    return SoalSyntaxKind.KTrue;
                case "false": 
                    return SoalSyntaxKind.KFalse;
                case ",": 
                    return SoalSyntaxKind.TComma;
                case "\u00ef\u00bb\u00bf": 
                    return SoalSyntaxKind.TUtf8Bom;
                case "namespace": 
                    return SoalSyntaxKind.KNamespace;
                case ";": 
                    return SoalSyntaxKind.TSemicolon;
                case "using": 
                    return SoalSyntaxKind.KUsing;
                case "enum": 
                    return SoalSyntaxKind.KEnum;
                case "{": 
                    return SoalSyntaxKind.TLBrace;
                case "}": 
                    return SoalSyntaxKind.TRBrace;
                case "struct": 
                    return SoalSyntaxKind.KStruct;
                case "interface": 
                    return SoalSyntaxKind.KInterface;
                case "readonly": 
                    return SoalSyntaxKind.KReadonly;
                case "resource": 
                    return SoalSyntaxKind.KResource;
                case "async": 
                    return SoalSyntaxKind.KAsync;
                case "(": 
                    return SoalSyntaxKind.TLParen;
                case ")": 
                    return SoalSyntaxKind.TRParen;
                case "void": 
                    return SoalSyntaxKind.KVoid;
                case "service": 
                    return SoalSyntaxKind.KService;
                case ":": 
                    return SoalSyntaxKind.TColon;
                case "binding": 
                    return SoalSyntaxKind.KBinding;
                case "REST": 
                    return SoalSyntaxKind.KREST;
                case "SOAP": 
                    return SoalSyntaxKind.KSOAP;
                case "?": 
                    return SoalSyntaxKind.TQuestion;
                case "object": 
                    return SoalSyntaxKind.KObject;
                case "binary": 
                    return SoalSyntaxKind.KBinary;
                case "bool": 
                    return SoalSyntaxKind.KBool;
                case "string": 
                    return SoalSyntaxKind.KString;
                case "int": 
                    return SoalSyntaxKind.KInt;
                case "long": 
                    return SoalSyntaxKind.KLong;
                case "float": 
                    return SoalSyntaxKind.KFloat;
                case "double": 
                    return SoalSyntaxKind.KDouble;
                case "date": 
                    return SoalSyntaxKind.KDate;
                case "time": 
                    return SoalSyntaxKind.KTime;
                case "datetime": 
                    return SoalSyntaxKind.KDatetime;
                case "duration": 
                    return SoalSyntaxKind.KDuration;
                case "throws": 
                    return SoalSyntaxKind.KThrows;
                case "[": 
                    return SoalSyntaxKind.TLBracket;
                case "]": 
                    return SoalSyntaxKind.TRBracket;
                case ".": 
                    return SoalSyntaxKind.TDot;
                default:
                    return SoalSyntaxKind.None;
            }
        }

        protected override int GetFixedTokenRawKind(string text)
        {
            return (int)GetFixedTokenKind(text);
        }


        public object? GetValue(SoalSyntaxKind kind)
        {
            return null;
        }

        protected override object? GetValue(int rawKind)
        {
            return GetValue((SoalSyntaxKind)rawKind);
        }

        public string GetKindText(SoalSyntaxKind kind)
        {
            switch (kind)
            {
                case SoalSyntaxKind.List:
                    return "List";
                case SoalSyntaxKind.BadToken:
                    return "BadToken";
                case SoalSyntaxKind.MissingToken:
                    return "MissingToken";
                case SoalSyntaxKind.SkippedTokensTrivia:
                    return "SkippedTokensTrivia";
                case SoalSyntaxKind.DisabledTextTrivia:
                    return "DisabledTextTrivia";
                case SoalSyntaxKind.ConflictMarkerTrivia:
                    return "ConflictMarkerTrivia";
                case SoalSyntaxKind.Eof:
                    return "Eof";
                case SoalSyntaxKind.KNull: 
                    return "KNull";
                case SoalSyntaxKind.KTrue: 
                    return "KTrue";
                case SoalSyntaxKind.KFalse: 
                    return "KFalse";
                case SoalSyntaxKind.TComma: 
                    return "TComma";
                case SoalSyntaxKind.TUtf8Bom: 
                    return "TUtf8Bom";
                case SoalSyntaxKind.KNamespace: 
                    return "KNamespace";
                case SoalSyntaxKind.TSemicolon: 
                    return "TSemicolon";
                case SoalSyntaxKind.KUsing: 
                    return "KUsing";
                case SoalSyntaxKind.KEnum: 
                    return "KEnum";
                case SoalSyntaxKind.TLBrace: 
                    return "TLBrace";
                case SoalSyntaxKind.TRBrace: 
                    return "TRBrace";
                case SoalSyntaxKind.KStruct: 
                    return "KStruct";
                case SoalSyntaxKind.KInterface: 
                    return "KInterface";
                case SoalSyntaxKind.KReadonly: 
                    return "KReadonly";
                case SoalSyntaxKind.KResource: 
                    return "KResource";
                case SoalSyntaxKind.KAsync: 
                    return "KAsync";
                case SoalSyntaxKind.TLParen: 
                    return "TLParen";
                case SoalSyntaxKind.TRParen: 
                    return "TRParen";
                case SoalSyntaxKind.KVoid: 
                    return "KVoid";
                case SoalSyntaxKind.KService: 
                    return "KService";
                case SoalSyntaxKind.TColon: 
                    return "TColon";
                case SoalSyntaxKind.KBinding: 
                    return "KBinding";
                case SoalSyntaxKind.KREST: 
                    return "KREST";
                case SoalSyntaxKind.KSOAP: 
                    return "KSOAP";
                case SoalSyntaxKind.TQuestion: 
                    return "TQuestion";
                case SoalSyntaxKind.KObject: 
                    return "KObject";
                case SoalSyntaxKind.KBinary: 
                    return "KBinary";
                case SoalSyntaxKind.KBool: 
                    return "KBool";
                case SoalSyntaxKind.KString: 
                    return "KString";
                case SoalSyntaxKind.KInt: 
                    return "KInt";
                case SoalSyntaxKind.KLong: 
                    return "KLong";
                case SoalSyntaxKind.KFloat: 
                    return "KFloat";
                case SoalSyntaxKind.KDouble: 
                    return "KDouble";
                case SoalSyntaxKind.KDate: 
                    return "KDate";
                case SoalSyntaxKind.KTime: 
                    return "KTime";
                case SoalSyntaxKind.KDatetime: 
                    return "KDatetime";
                case SoalSyntaxKind.KDuration: 
                    return "KDuration";
                case SoalSyntaxKind.KThrows: 
                    return "KThrows";
                case SoalSyntaxKind.TLBracket: 
                    return "TLBracket";
                case SoalSyntaxKind.TRBracket: 
                    return "TRBracket";
                case SoalSyntaxKind.TDot: 
                    return "TDot";
                case SoalSyntaxKind.TInteger: 
                    return "TInteger";
                case SoalSyntaxKind.TDecimal: 
                    return "TDecimal";
                case SoalSyntaxKind.TIdentifier: 
                    return "TIdentifier";
                case SoalSyntaxKind.TVerbatimIdentifier: 
                    return "TVerbatimIdentifier";
                case SoalSyntaxKind.TString: 
                    return "TString";
                case SoalSyntaxKind.TWhitespace: 
                    return "TWhitespace";
                case SoalSyntaxKind.TLineEnd: 
                    return "TLineEnd";
                case SoalSyntaxKind.TSingleLineComment: 
                    return "TSingleLineComment";
                case SoalSyntaxKind.TMultiLineComment: 
                    return "TMultiLineComment";
                case SoalSyntaxKind.TInvalidToken: 
                    return "TInvalidToken";
                case SoalSyntaxKind.Main: 
                    return "Main";
                case SoalSyntaxKind.Using: 
                    return "Using";
                case SoalSyntaxKind.DeclarationAlt1: 
                    return "DeclarationAlt1";
                case SoalSyntaxKind.DeclarationAlt2: 
                    return "DeclarationAlt2";
                case SoalSyntaxKind.DeclarationAlt3: 
                    return "DeclarationAlt3";
                case SoalSyntaxKind.DeclarationAlt4: 
                    return "DeclarationAlt4";
                case SoalSyntaxKind.EnumType: 
                    return "EnumType";
                case SoalSyntaxKind.EnumLiteral: 
                    return "EnumLiteral";
                case SoalSyntaxKind.StructType: 
                    return "StructType";
                case SoalSyntaxKind.Property: 
                    return "Property";
                case SoalSyntaxKind.Interface: 
                    return "Interface";
                case SoalSyntaxKind.Resource: 
                    return "Resource";
                case SoalSyntaxKind.Operation: 
                    return "Operation";
                case SoalSyntaxKind.InputParameterList: 
                    return "InputParameterList";
                case SoalSyntaxKind.OutputParameterListAlt1: 
                    return "OutputParameterListAlt1";
                case SoalSyntaxKind.OutputParameterListAlt2: 
                    return "OutputParameterListAlt2";
                case SoalSyntaxKind.OutputParameterListAlt3: 
                    return "OutputParameterListAlt3";
                case SoalSyntaxKind.Parameter: 
                    return "Parameter";
                case SoalSyntaxKind.SingleReturnParameter: 
                    return "SingleReturnParameter";
                case SoalSyntaxKind.Service: 
                    return "Service";
                case SoalSyntaxKind.BindingKind: 
                    return "BindingKind";
                case SoalSyntaxKind.TypeReference: 
                    return "TypeReference";
                case SoalSyntaxKind.SimpleTypeAlt1: 
                    return "SimpleTypeAlt1";
                case SoalSyntaxKind.SimpleTypeAlt2: 
                    return "SimpleTypeAlt2";
                case SoalSyntaxKind.SimpleTypeAlt3: 
                    return "SimpleTypeAlt3";
                case SoalSyntaxKind.SimpleTypeAlt4: 
                    return "SimpleTypeAlt4";
                case SoalSyntaxKind.SimpleTypeAlt5: 
                    return "SimpleTypeAlt5";
                case SoalSyntaxKind.SimpleTypeAlt6: 
                    return "SimpleTypeAlt6";
                case SoalSyntaxKind.SimpleTypeAlt7: 
                    return "SimpleTypeAlt7";
                case SoalSyntaxKind.SimpleTypeAlt8: 
                    return "SimpleTypeAlt8";
                case SoalSyntaxKind.SimpleTypeAlt9: 
                    return "SimpleTypeAlt9";
                case SoalSyntaxKind.SimpleTypeAlt10: 
                    return "SimpleTypeAlt10";
                case SoalSyntaxKind.SimpleTypeAlt11: 
                    return "SimpleTypeAlt11";
                case SoalSyntaxKind.SimpleTypeAlt12: 
                    return "SimpleTypeAlt12";
                case SoalSyntaxKind.SimpleTypeAlt13: 
                    return "SimpleTypeAlt13";
                case SoalSyntaxKind.Name: 
                    return "Name";
                case SoalSyntaxKind.Qualifier: 
                    return "Qualifier";
                case SoalSyntaxKind.Identifier: 
                    return "Identifier";
                case SoalSyntaxKind.MainBlock1: 
                    return "MainBlock1";
                case SoalSyntaxKind.EnumTypeBlock1: 
                    return "EnumTypeBlock1";
                case SoalSyntaxKind.EnumTypeBlock1literalsBlock: 
                    return "EnumTypeBlock1literalsBlock";
                case SoalSyntaxKind.StructTypeBlock1: 
                    return "StructTypeBlock1";
                case SoalSyntaxKind.ResourceBlock1: 
                    return "ResourceBlock1";
                case SoalSyntaxKind.ResourceBlock1exceptionsBlock: 
                    return "ResourceBlock1exceptionsBlock";
                case SoalSyntaxKind.OperationBlock1: 
                    return "OperationBlock1";
                case SoalSyntaxKind.OperationBlock1exceptionsBlock: 
                    return "OperationBlock1exceptionsBlock";
                case SoalSyntaxKind.InputParameterListBlock1: 
                    return "InputParameterListBlock1";
                case SoalSyntaxKind.InputParameterListBlock1parametersBlock: 
                    return "InputParameterListBlock1parametersBlock";
                case SoalSyntaxKind.OutputParameterListAlt3parametersBlock: 
                    return "OutputParameterListAlt3parametersBlock";
                case SoalSyntaxKind.TypeReferenceBlock1: 
                    return "TypeReferenceBlock1";
                case SoalSyntaxKind.QualifierIdentifierBlock: 
                    return "QualifierIdentifierBlock";
                default:
                    return string.Empty;
            }
        }

        protected override string GetKindText(int rawKind)
        {
            return GetKindText((SoalSyntaxKind)rawKind);
        }

        public string GetText(SoalSyntaxKind kind)
        {
            switch (kind)
            {
                case SoalSyntaxKind.KNull: 
                    return "null";
                case SoalSyntaxKind.KTrue: 
                    return "true";
                case SoalSyntaxKind.KFalse: 
                    return "false";
                case SoalSyntaxKind.TComma: 
                    return ",";
                case SoalSyntaxKind.TUtf8Bom: 
                    return "\u00ef\u00bb\u00bf";
                case SoalSyntaxKind.KNamespace: 
                    return "namespace";
                case SoalSyntaxKind.TSemicolon: 
                    return ";";
                case SoalSyntaxKind.KUsing: 
                    return "using";
                case SoalSyntaxKind.KEnum: 
                    return "enum";
                case SoalSyntaxKind.TLBrace: 
                    return "{";
                case SoalSyntaxKind.TRBrace: 
                    return "}";
                case SoalSyntaxKind.KStruct: 
                    return "struct";
                case SoalSyntaxKind.KInterface: 
                    return "interface";
                case SoalSyntaxKind.KReadonly: 
                    return "readonly";
                case SoalSyntaxKind.KResource: 
                    return "resource";
                case SoalSyntaxKind.KAsync: 
                    return "async";
                case SoalSyntaxKind.TLParen: 
                    return "(";
                case SoalSyntaxKind.TRParen: 
                    return ")";
                case SoalSyntaxKind.KVoid: 
                    return "void";
                case SoalSyntaxKind.KService: 
                    return "service";
                case SoalSyntaxKind.TColon: 
                    return ":";
                case SoalSyntaxKind.KBinding: 
                    return "binding";
                case SoalSyntaxKind.KREST: 
                    return "REST";
                case SoalSyntaxKind.KSOAP: 
                    return "SOAP";
                case SoalSyntaxKind.TQuestion: 
                    return "?";
                case SoalSyntaxKind.KObject: 
                    return "object";
                case SoalSyntaxKind.KBinary: 
                    return "binary";
                case SoalSyntaxKind.KBool: 
                    return "bool";
                case SoalSyntaxKind.KString: 
                    return "string";
                case SoalSyntaxKind.KInt: 
                    return "int";
                case SoalSyntaxKind.KLong: 
                    return "long";
                case SoalSyntaxKind.KFloat: 
                    return "float";
                case SoalSyntaxKind.KDouble: 
                    return "double";
                case SoalSyntaxKind.KDate: 
                    return "date";
                case SoalSyntaxKind.KTime: 
                    return "time";
                case SoalSyntaxKind.KDatetime: 
                    return "datetime";
                case SoalSyntaxKind.KDuration: 
                    return "duration";
                case SoalSyntaxKind.KThrows: 
                    return "throws";
                case SoalSyntaxKind.TLBracket: 
                    return "[";
                case SoalSyntaxKind.TRBracket: 
                    return "]";
                case SoalSyntaxKind.TDot: 
                    return ".";
                default:
                    return string.Empty;
            }
        }

        protected override string GetText(int rawKind)
        {
            return GetText((SoalSyntaxKind)rawKind);
        }

        public bool IsTrivia(SoalSyntaxKind kind)
        {
            switch(kind)
            {
                case SoalSyntaxKind.TUtf8Bom: 
                case SoalSyntaxKind.TWhitespace: 
                case SoalSyntaxKind.TLineEnd: 
                case SoalSyntaxKind.TSingleLineComment: 
                case SoalSyntaxKind.TMultiLineComment: 
                case SoalSyntaxKind.TInvalidToken: 
                    return true;
                default:
                    return false;
            }
        }

        protected override bool IsTrivia(int rawKind)
        {
            return IsTrivia((SoalSyntaxKind)rawKind);
        }

        public bool IsReservedKeyword(SoalSyntaxKind kind)
        {
            switch(kind)
            {
                case SoalSyntaxKind.KNull: 
                case SoalSyntaxKind.KTrue: 
                case SoalSyntaxKind.KFalse: 
                case SoalSyntaxKind.KNamespace: 
                case SoalSyntaxKind.KUsing: 
                case SoalSyntaxKind.KEnum: 
                case SoalSyntaxKind.KStruct: 
                case SoalSyntaxKind.KInterface: 
                case SoalSyntaxKind.KReadonly: 
                case SoalSyntaxKind.KResource: 
                case SoalSyntaxKind.KAsync: 
                case SoalSyntaxKind.KVoid: 
                case SoalSyntaxKind.KService: 
                case SoalSyntaxKind.KBinding: 
                case SoalSyntaxKind.KREST: 
                case SoalSyntaxKind.KSOAP: 
                case SoalSyntaxKind.KObject: 
                case SoalSyntaxKind.KBinary: 
                case SoalSyntaxKind.KBool: 
                case SoalSyntaxKind.KString: 
                case SoalSyntaxKind.KInt: 
                case SoalSyntaxKind.KLong: 
                case SoalSyntaxKind.KFloat: 
                case SoalSyntaxKind.KDouble: 
                case SoalSyntaxKind.KDate: 
                case SoalSyntaxKind.KTime: 
                case SoalSyntaxKind.KDatetime: 
                case SoalSyntaxKind.KDuration: 
                case SoalSyntaxKind.KThrows: 
                    return true;
                default:
                    return false;
            }
        }

        protected override bool IsReservedKeyword(int rawKind)
        {
            return IsReservedKeyword((SoalSyntaxKind)rawKind);
        }

        public global::System.Collections.Generic.IEnumerable<SoalSyntaxKind> GetReservedKeywordKinds()
        {
            yield return SoalSyntaxKind.KNull;
            yield return SoalSyntaxKind.KTrue;
            yield return SoalSyntaxKind.KFalse;
            yield return SoalSyntaxKind.KNamespace;
            yield return SoalSyntaxKind.KUsing;
            yield return SoalSyntaxKind.KEnum;
            yield return SoalSyntaxKind.KStruct;
            yield return SoalSyntaxKind.KInterface;
            yield return SoalSyntaxKind.KReadonly;
            yield return SoalSyntaxKind.KResource;
            yield return SoalSyntaxKind.KAsync;
            yield return SoalSyntaxKind.KVoid;
            yield return SoalSyntaxKind.KService;
            yield return SoalSyntaxKind.KBinding;
            yield return SoalSyntaxKind.KREST;
            yield return SoalSyntaxKind.KSOAP;
            yield return SoalSyntaxKind.KObject;
            yield return SoalSyntaxKind.KBinary;
            yield return SoalSyntaxKind.KBool;
            yield return SoalSyntaxKind.KString;
            yield return SoalSyntaxKind.KInt;
            yield return SoalSyntaxKind.KLong;
            yield return SoalSyntaxKind.KFloat;
            yield return SoalSyntaxKind.KDouble;
            yield return SoalSyntaxKind.KDate;
            yield return SoalSyntaxKind.KTime;
            yield return SoalSyntaxKind.KDatetime;
            yield return SoalSyntaxKind.KDuration;
            yield return SoalSyntaxKind.KThrows;
            yield break;
        }

        protected override global::System.Collections.Generic.IEnumerable<int> GetReservedKeywordRawKinds()
        {
            return GetReservedKeywordKinds().Select(kind => (int)kind);
        }

        public SoalSyntaxKind GetReservedKeywordKind(string text)
        {
            switch(text)
            {
                case "null": 
                    return SoalSyntaxKind.KNull;
                case "true": 
                    return SoalSyntaxKind.KTrue;
                case "false": 
                    return SoalSyntaxKind.KFalse;
                case "namespace": 
                    return SoalSyntaxKind.KNamespace;
                case "using": 
                    return SoalSyntaxKind.KUsing;
                case "enum": 
                    return SoalSyntaxKind.KEnum;
                case "struct": 
                    return SoalSyntaxKind.KStruct;
                case "interface": 
                    return SoalSyntaxKind.KInterface;
                case "readonly": 
                    return SoalSyntaxKind.KReadonly;
                case "resource": 
                    return SoalSyntaxKind.KResource;
                case "async": 
                    return SoalSyntaxKind.KAsync;
                case "void": 
                    return SoalSyntaxKind.KVoid;
                case "service": 
                    return SoalSyntaxKind.KService;
                case "binding": 
                    return SoalSyntaxKind.KBinding;
                case "REST": 
                    return SoalSyntaxKind.KREST;
                case "SOAP": 
                    return SoalSyntaxKind.KSOAP;
                case "object": 
                    return SoalSyntaxKind.KObject;
                case "binary": 
                    return SoalSyntaxKind.KBinary;
                case "bool": 
                    return SoalSyntaxKind.KBool;
                case "string": 
                    return SoalSyntaxKind.KString;
                case "int": 
                    return SoalSyntaxKind.KInt;
                case "long": 
                    return SoalSyntaxKind.KLong;
                case "float": 
                    return SoalSyntaxKind.KFloat;
                case "double": 
                    return SoalSyntaxKind.KDouble;
                case "date": 
                    return SoalSyntaxKind.KDate;
                case "time": 
                    return SoalSyntaxKind.KTime;
                case "datetime": 
                    return SoalSyntaxKind.KDatetime;
                case "duration": 
                    return SoalSyntaxKind.KDuration;
                case "throws": 
                    return SoalSyntaxKind.KThrows;
                default:
                    return SoalSyntaxKind.None;
            }
        }

        protected override int GetReservedKeywordRawKind(string text)
        {
            return (int)GetReservedKeywordKind(text);
        }

        public bool IsContextualKeyword(SoalSyntaxKind kind)
        {
            switch(kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsContextualKeyword(int rawKind)
        {
            return IsContextualKeyword((SoalSyntaxKind)rawKind);
        }

        public global::System.Collections.Generic.IEnumerable<SoalSyntaxKind> GetContextualKeywordKinds()
        {
            yield break;
        }

        protected override global::System.Collections.Generic.IEnumerable<int> GetContextualKeywordRawKinds()
        {
            return GetContextualKeywordKinds().Select(kind => (int)kind);
        }

        public SoalSyntaxKind GetContextualKeywordKind(string text)
        {
            switch(text)
            {
                default:
                    return SoalSyntaxKind.None;
            }
        }

        protected override int GetContextualKeywordRawKind(string text)
        {
            return (int)GetContextualKeywordKind(text);
        }

        public bool IsPreprocessorKeyword(SoalSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsPreprocessorKeyword(int rawKind)
        {
            return IsPreprocessorKeyword((SoalSyntaxKind)rawKind);
        }

        public bool IsPreprocessorContextualKeyword(SoalSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsPreprocessorContextualKeyword(int rawKind)
        {
            return IsPreprocessorContextualKeyword((SoalSyntaxKind)rawKind);
        }

        public bool IsPreprocessorDirective(SoalSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsPreprocessorDirective(int rawKind)
        {
            return IsPreprocessorDirective((SoalSyntaxKind)rawKind);
        }

        public bool IsIdentifier(SoalSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsIdentifier(int rawKind)
        {
            return IsIdentifier((SoalSyntaxKind)rawKind);
        }

        public bool IsGeneralCommentTrivia(SoalSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsGeneralCommentTrivia(int rawKind)
        {
            return IsGeneralCommentTrivia((SoalSyntaxKind)rawKind);
        }

        public bool IsDocumentationCommentTrivia(SoalSyntaxKind kind)
        {
            switch (kind)
            {
                default:
                    return false;
            }
        }

        protected override bool IsDocumentationCommentTrivia(int rawKind)
        {
            return IsDocumentationCommentTrivia((SoalSyntaxKind)rawKind);
        }

        public SoalLanguageVersion GetRequiredLanguageVersion(string feature)
        {
            return SoalLanguageVersion.Version1;
        }
    }
}
