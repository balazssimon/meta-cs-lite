
#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax
{
    using System.Linq;

    public class MetaSyntaxFacts : global::MetaDslx.CodeAnalysis.Syntax.SyntaxFacts
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

        public global::MetaDslx.CodeAnalysis.Syntax.TokenKind? GetTokenKind(MetaSyntaxKind syntaxKind)
        {
            switch (syntaxKind)
            {
                case MetaSyntaxKind.KNull:
                case MetaSyntaxKind.KTrue:
                case MetaSyntaxKind.KFalse:
                case MetaSyntaxKind.KNamespace:
                case MetaSyntaxKind.KUsing:
                case MetaSyntaxKind.KMetamodel:
                case MetaSyntaxKind.KConst:
                case MetaSyntaxKind.KEnum:
                case MetaSyntaxKind.KAbstract:
                case MetaSyntaxKind.KClass:
                case MetaSyntaxKind.KObject:
                case MetaSyntaxKind.KBool:
                case MetaSyntaxKind.KChar:
                case MetaSyntaxKind.KString:
                case MetaSyntaxKind.KByte:
                case MetaSyntaxKind.KSbyte:
                case MetaSyntaxKind.KShort:
                case MetaSyntaxKind.KUshort:
                case MetaSyntaxKind.KInt:
                case MetaSyntaxKind.KUint:
                case MetaSyntaxKind.KLong:
                case MetaSyntaxKind.KUlong:
                case MetaSyntaxKind.KFloat:
                case MetaSyntaxKind.KDouble:
                case MetaSyntaxKind.KDecimal:
                case MetaSyntaxKind.KType:
                case MetaSyntaxKind.KSymbol:
                case MetaSyntaxKind.KVoid:
                case MetaSyntaxKind.KContains:
                case MetaSyntaxKind.KDerived:
                case MetaSyntaxKind.KUnion:
                case MetaSyntaxKind.KReadonly:
                case MetaSyntaxKind.KOpposite:
                case MetaSyntaxKind.KSubsets:
                case MetaSyntaxKind.KRedefines:
                return TK_Keyword;
                case MetaSyntaxKind.TComma:
                return TK_DefaultSeparator;
                case MetaSyntaxKind.TUtf8Bom:
                return TK_Whitespace;
                case MetaSyntaxKind.TInteger:
                case MetaSyntaxKind.TDecimal:
                return TK_Number;
                case MetaSyntaxKind.TIdentifier:
                return TK_DefaultIdentifier;
                case MetaSyntaxKind.TVerbatimIdentifier:
                return TK_Identifier;
                case MetaSyntaxKind.TString:
                return TK_String;
                case MetaSyntaxKind.TWhitespace:
                return TK_DefaultWhitespace;
                case MetaSyntaxKind.TLineEnd:
                return TK_DefaultEndOfLine;
                case MetaSyntaxKind.TSingleLineComment:
                return TK_SingleLineComment;
                case MetaSyntaxKind.TMultiLineComment:
                return TK_MultiLineComment;
                default:
                    return null;
            }
        }
            
        public override global::MetaDslx.CodeAnalysis.Syntax.TokenKind? GetTokenKind(int rawSyntaxKind)
        {
            return GetTokenKind((MetaSyntaxKind)rawSyntaxKind);
        }

        public bool IsToken(MetaSyntaxKind kind)
        {
            switch (kind)
            {
                case MetaSyntaxKind.Eof:
                case MetaSyntaxKind.KNull:
                case MetaSyntaxKind.KTrue:
                case MetaSyntaxKind.KFalse:
                case MetaSyntaxKind.TComma:
                case MetaSyntaxKind.TUtf8Bom:
                case MetaSyntaxKind.KNamespace:
                case MetaSyntaxKind.TSemicolon:
                case MetaSyntaxKind.KUsing:
                case MetaSyntaxKind.KMetamodel:
                case MetaSyntaxKind.KConst:
                case MetaSyntaxKind.KEnum:
                case MetaSyntaxKind.KAbstract:
                case MetaSyntaxKind.KClass:
                case MetaSyntaxKind.TLParen:
                case MetaSyntaxKind.TRParen:
                case MetaSyntaxKind.KObject:
                case MetaSyntaxKind.KBool:
                case MetaSyntaxKind.KChar:
                case MetaSyntaxKind.KString:
                case MetaSyntaxKind.KByte:
                case MetaSyntaxKind.KSbyte:
                case MetaSyntaxKind.KShort:
                case MetaSyntaxKind.KUshort:
                case MetaSyntaxKind.KInt:
                case MetaSyntaxKind.KUint:
                case MetaSyntaxKind.KLong:
                case MetaSyntaxKind.KUlong:
                case MetaSyntaxKind.KFloat:
                case MetaSyntaxKind.KDouble:
                case MetaSyntaxKind.KDecimal:
                case MetaSyntaxKind.KType:
                case MetaSyntaxKind.KSymbol:
                case MetaSyntaxKind.KVoid:
                case MetaSyntaxKind.TEq:
                case MetaSyntaxKind.TLBrace:
                case MetaSyntaxKind.TRBrace:
                case MetaSyntaxKind.TDollar:
                case MetaSyntaxKind.TColon:
                case MetaSyntaxKind.KContains:
                case MetaSyntaxKind.KDerived:
                case MetaSyntaxKind.KUnion:
                case MetaSyntaxKind.KReadonly:
                case MetaSyntaxKind.KOpposite:
                case MetaSyntaxKind.KSubsets:
                case MetaSyntaxKind.KRedefines:
                case MetaSyntaxKind.TQuestion:
                case MetaSyntaxKind.TLBracket:
                case MetaSyntaxKind.TRBracket:
                case MetaSyntaxKind.TDot:
                case MetaSyntaxKind.TInteger:
                case MetaSyntaxKind.TDecimal:
                case MetaSyntaxKind.TIdentifier:
                case MetaSyntaxKind.TVerbatimIdentifier:
                case MetaSyntaxKind.TString:
                case MetaSyntaxKind.TWhitespace:
                case MetaSyntaxKind.TLineEnd:
                case MetaSyntaxKind.TSingleLineComment:
                case MetaSyntaxKind.TMultiLineComment:
                case MetaSyntaxKind.TInvalidToken:
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
                case MetaSyntaxKind.KNull:
                case MetaSyntaxKind.KTrue:
                case MetaSyntaxKind.KFalse:
                case MetaSyntaxKind.TComma:
                case MetaSyntaxKind.TUtf8Bom:
                case MetaSyntaxKind.KNamespace:
                case MetaSyntaxKind.TSemicolon:
                case MetaSyntaxKind.KUsing:
                case MetaSyntaxKind.KMetamodel:
                case MetaSyntaxKind.KConst:
                case MetaSyntaxKind.KEnum:
                case MetaSyntaxKind.KAbstract:
                case MetaSyntaxKind.KClass:
                case MetaSyntaxKind.TLParen:
                case MetaSyntaxKind.TRParen:
                case MetaSyntaxKind.KObject:
                case MetaSyntaxKind.KBool:
                case MetaSyntaxKind.KChar:
                case MetaSyntaxKind.KString:
                case MetaSyntaxKind.KByte:
                case MetaSyntaxKind.KSbyte:
                case MetaSyntaxKind.KShort:
                case MetaSyntaxKind.KUshort:
                case MetaSyntaxKind.KInt:
                case MetaSyntaxKind.KUint:
                case MetaSyntaxKind.KLong:
                case MetaSyntaxKind.KUlong:
                case MetaSyntaxKind.KFloat:
                case MetaSyntaxKind.KDouble:
                case MetaSyntaxKind.KDecimal:
                case MetaSyntaxKind.KType:
                case MetaSyntaxKind.KSymbol:
                case MetaSyntaxKind.KVoid:
                case MetaSyntaxKind.TEq:
                case MetaSyntaxKind.TLBrace:
                case MetaSyntaxKind.TRBrace:
                case MetaSyntaxKind.TDollar:
                case MetaSyntaxKind.TColon:
                case MetaSyntaxKind.KContains:
                case MetaSyntaxKind.KDerived:
                case MetaSyntaxKind.KUnion:
                case MetaSyntaxKind.KReadonly:
                case MetaSyntaxKind.KOpposite:
                case MetaSyntaxKind.KSubsets:
                case MetaSyntaxKind.KRedefines:
                case MetaSyntaxKind.TQuestion:
                case MetaSyntaxKind.TLBracket:
                case MetaSyntaxKind.TRBracket:
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
                case "null": 
                    return MetaSyntaxKind.KNull;
                case "true": 
                    return MetaSyntaxKind.KTrue;
                case "false": 
                    return MetaSyntaxKind.KFalse;
                case ",": 
                    return MetaSyntaxKind.TComma;
                case "\u00ef\u00bb\u00bf": 
                    return MetaSyntaxKind.TUtf8Bom;
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
                case "abstract": 
                    return MetaSyntaxKind.KAbstract;
                case "class": 
                    return MetaSyntaxKind.KClass;
                case "(": 
                    return MetaSyntaxKind.TLParen;
                case ")": 
                    return MetaSyntaxKind.TRParen;
                case "object": 
                    return MetaSyntaxKind.KObject;
                case "bool": 
                    return MetaSyntaxKind.KBool;
                case "char": 
                    return MetaSyntaxKind.KChar;
                case "string": 
                    return MetaSyntaxKind.KString;
                case "byte": 
                    return MetaSyntaxKind.KByte;
                case "sbyte": 
                    return MetaSyntaxKind.KSbyte;
                case "short": 
                    return MetaSyntaxKind.KShort;
                case "ushort": 
                    return MetaSyntaxKind.KUshort;
                case "int": 
                    return MetaSyntaxKind.KInt;
                case "uint": 
                    return MetaSyntaxKind.KUint;
                case "long": 
                    return MetaSyntaxKind.KLong;
                case "ulong": 
                    return MetaSyntaxKind.KUlong;
                case "float": 
                    return MetaSyntaxKind.KFloat;
                case "double": 
                    return MetaSyntaxKind.KDouble;
                case "decimal": 
                    return MetaSyntaxKind.KDecimal;
                case "type": 
                    return MetaSyntaxKind.KType;
                case "symbol": 
                    return MetaSyntaxKind.KSymbol;
                case "void": 
                    return MetaSyntaxKind.KVoid;
                case "=": 
                    return MetaSyntaxKind.TEq;
                case "{": 
                    return MetaSyntaxKind.TLBrace;
                case "}": 
                    return MetaSyntaxKind.TRBrace;
                case "$": 
                    return MetaSyntaxKind.TDollar;
                case ":": 
                    return MetaSyntaxKind.TColon;
                case "contains": 
                    return MetaSyntaxKind.KContains;
                case "derived": 
                    return MetaSyntaxKind.KDerived;
                case "union": 
                    return MetaSyntaxKind.KUnion;
                case "readonly": 
                    return MetaSyntaxKind.KReadonly;
                case "opposite": 
                    return MetaSyntaxKind.KOpposite;
                case "subsets": 
                    return MetaSyntaxKind.KSubsets;
                case "redefines": 
                    return MetaSyntaxKind.KRedefines;
                case "?": 
                    return MetaSyntaxKind.TQuestion;
                case "[": 
                    return MetaSyntaxKind.TLBracket;
                case "]": 
                    return MetaSyntaxKind.TRBracket;
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
                case MetaSyntaxKind.KNull: 
                    return "KNull";
                case MetaSyntaxKind.KTrue: 
                    return "KTrue";
                case MetaSyntaxKind.KFalse: 
                    return "KFalse";
                case MetaSyntaxKind.TComma: 
                    return "TComma";
                case MetaSyntaxKind.TUtf8Bom: 
                    return "TUtf8Bom";
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
                case MetaSyntaxKind.KAbstract: 
                    return "KAbstract";
                case MetaSyntaxKind.KClass: 
                    return "KClass";
                case MetaSyntaxKind.TLParen: 
                    return "TLParen";
                case MetaSyntaxKind.TRParen: 
                    return "TRParen";
                case MetaSyntaxKind.KObject: 
                    return "KObject";
                case MetaSyntaxKind.KBool: 
                    return "KBool";
                case MetaSyntaxKind.KChar: 
                    return "KChar";
                case MetaSyntaxKind.KString: 
                    return "KString";
                case MetaSyntaxKind.KByte: 
                    return "KByte";
                case MetaSyntaxKind.KSbyte: 
                    return "KSbyte";
                case MetaSyntaxKind.KShort: 
                    return "KShort";
                case MetaSyntaxKind.KUshort: 
                    return "KUshort";
                case MetaSyntaxKind.KInt: 
                    return "KInt";
                case MetaSyntaxKind.KUint: 
                    return "KUint";
                case MetaSyntaxKind.KLong: 
                    return "KLong";
                case MetaSyntaxKind.KUlong: 
                    return "KUlong";
                case MetaSyntaxKind.KFloat: 
                    return "KFloat";
                case MetaSyntaxKind.KDouble: 
                    return "KDouble";
                case MetaSyntaxKind.KDecimal: 
                    return "KDecimal";
                case MetaSyntaxKind.KType: 
                    return "KType";
                case MetaSyntaxKind.KSymbol: 
                    return "KSymbol";
                case MetaSyntaxKind.KVoid: 
                    return "KVoid";
                case MetaSyntaxKind.TEq: 
                    return "TEq";
                case MetaSyntaxKind.TLBrace: 
                    return "TLBrace";
                case MetaSyntaxKind.TRBrace: 
                    return "TRBrace";
                case MetaSyntaxKind.TDollar: 
                    return "TDollar";
                case MetaSyntaxKind.TColon: 
                    return "TColon";
                case MetaSyntaxKind.KContains: 
                    return "KContains";
                case MetaSyntaxKind.KDerived: 
                    return "KDerived";
                case MetaSyntaxKind.KUnion: 
                    return "KUnion";
                case MetaSyntaxKind.KReadonly: 
                    return "KReadonly";
                case MetaSyntaxKind.KOpposite: 
                    return "KOpposite";
                case MetaSyntaxKind.KSubsets: 
                    return "KSubsets";
                case MetaSyntaxKind.KRedefines: 
                    return "KRedefines";
                case MetaSyntaxKind.TQuestion: 
                    return "TQuestion";
                case MetaSyntaxKind.TLBracket: 
                    return "TLBracket";
                case MetaSyntaxKind.TRBracket: 
                    return "TRBracket";
                case MetaSyntaxKind.TDot: 
                    return "TDot";
                case MetaSyntaxKind.TInteger: 
                    return "TInteger";
                case MetaSyntaxKind.TDecimal: 
                    return "TDecimal";
                case MetaSyntaxKind.TIdentifier: 
                    return "TIdentifier";
                case MetaSyntaxKind.TVerbatimIdentifier: 
                    return "TVerbatimIdentifier";
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
                case MetaSyntaxKind.TInvalidToken: 
                    return "TInvalidToken";
                case MetaSyntaxKind.Main: 
                    return "Main";
                case MetaSyntaxKind.Using: 
                    return "Using";
                case MetaSyntaxKind.MetaModel: 
                    return "MetaModel";
                case MetaSyntaxKind.MetaDeclarationAlt1: 
                    return "MetaDeclarationAlt1";
                case MetaSyntaxKind.MetaDeclarationAlt2: 
                    return "MetaDeclarationAlt2";
                case MetaSyntaxKind.MetaDeclarationAlt3: 
                    return "MetaDeclarationAlt3";
                case MetaSyntaxKind.MetaConstant: 
                    return "MetaConstant";
                case MetaSyntaxKind.MetaEnum: 
                    return "MetaEnum";
                case MetaSyntaxKind.MetaEnumLiteral: 
                    return "MetaEnumLiteral";
                case MetaSyntaxKind.MetaClass: 
                    return "MetaClass";
                case MetaSyntaxKind.MetaProperty: 
                    return "MetaProperty";
                case MetaSyntaxKind.MetaOperation: 
                    return "MetaOperation";
                case MetaSyntaxKind.MetaParameter: 
                    return "MetaParameter";
                case MetaSyntaxKind.MetaTypeReference: 
                    return "MetaTypeReference";
                case MetaSyntaxKind.TypeReferenceAlt1: 
                    return "TypeReferenceAlt1";
                case MetaSyntaxKind.TypeReferenceAlt2: 
                    return "TypeReferenceAlt2";
                case MetaSyntaxKind.PrimitiveType: 
                    return "PrimitiveType";
                case MetaSyntaxKind.ValueAlt1: 
                    return "ValueAlt1";
                case MetaSyntaxKind.ValueAlt2: 
                    return "ValueAlt2";
                case MetaSyntaxKind.ValueAlt3: 
                    return "ValueAlt3";
                case MetaSyntaxKind.ValueAlt4: 
                    return "ValueAlt4";
                case MetaSyntaxKind.ValueAlt5: 
                    return "ValueAlt5";
                case MetaSyntaxKind.ValueAlt6: 
                    return "ValueAlt6";
                case MetaSyntaxKind.Name: 
                    return "Name";
                case MetaSyntaxKind.Qualifier: 
                    return "Qualifier";
                case MetaSyntaxKind.Identifier: 
                    return "Identifier";
                case MetaSyntaxKind.TBoolean: 
                    return "TBoolean";
                case MetaSyntaxKind.MainBlock1: 
                    return "MainBlock1";
                case MetaSyntaxKind.MetaModelBlock1: 
                    return "MetaModelBlock1";
                case MetaSyntaxKind.MetaEnumBlock1: 
                    return "MetaEnumBlock1";
                case MetaSyntaxKind.MetaEnumBlock1literalsBlock: 
                    return "MetaEnumBlock1literalsBlock";
                case MetaSyntaxKind.MetaClassBlock1Alt1: 
                    return "MetaClassBlock1Alt1";
                case MetaSyntaxKind.MetaClassBlock1Alt2: 
                    return "MetaClassBlock1Alt2";
                case MetaSyntaxKind.MetaClassBlock2: 
                    return "MetaClassBlock2";
                case MetaSyntaxKind.MetaClassBlock2baseTypesBlock: 
                    return "MetaClassBlock2baseTypesBlock";
                case MetaSyntaxKind.MetaClassBlock3: 
                    return "MetaClassBlock3";
                case MetaSyntaxKind.MetaClassBlock3Block1Alt1: 
                    return "MetaClassBlock3Block1Alt1";
                case MetaSyntaxKind.MetaClassBlock3Block1Alt2: 
                    return "MetaClassBlock3Block1Alt2";
                case MetaSyntaxKind.MetaPropertyBlock1Alt1: 
                    return "MetaPropertyBlock1Alt1";
                case MetaSyntaxKind.MetaPropertyBlock1Alt2: 
                    return "MetaPropertyBlock1Alt2";
                case MetaSyntaxKind.MetaPropertyBlock1Alt3: 
                    return "MetaPropertyBlock1Alt3";
                case MetaSyntaxKind.MetaPropertyBlock1Alt4: 
                    return "MetaPropertyBlock1Alt4";
                case MetaSyntaxKind.MetaPropertyBlock2Alt1: 
                    return "MetaPropertyBlock2Alt1";
                case MetaSyntaxKind.MetaPropertyBlock2Alt2: 
                    return "MetaPropertyBlock2Alt2";
                case MetaSyntaxKind.MetaPropertyBlock3: 
                    return "MetaPropertyBlock3";
                case MetaSyntaxKind.MetaPropertyBlock4Alt1: 
                    return "MetaPropertyBlock4Alt1";
                case MetaSyntaxKind.MetaPropertyBlock4Alt2: 
                    return "MetaPropertyBlock4Alt2";
                case MetaSyntaxKind.MetaPropertyBlock4Alt3: 
                    return "MetaPropertyBlock4Alt3";
                case MetaSyntaxKind.MetaPropertyBlock4Alt1oppositePropertiesBlock: 
                    return "MetaPropertyBlock4Alt1oppositePropertiesBlock";
                case MetaSyntaxKind.MetaPropertyBlock4Alt2subsettedPropertiesBlock: 
                    return "MetaPropertyBlock4Alt2subsettedPropertiesBlock";
                case MetaSyntaxKind.MetaPropertyBlock4Alt3redefinedPropertiesBlock: 
                    return "MetaPropertyBlock4Alt3redefinedPropertiesBlock";
                case MetaSyntaxKind.MetaOperationBlock1: 
                    return "MetaOperationBlock1";
                case MetaSyntaxKind.MetaOperationBlock1parametersBlock: 
                    return "MetaOperationBlock1parametersBlock";
                case MetaSyntaxKind.MetaTypeReferenceBlock1: 
                    return "MetaTypeReferenceBlock1";
                case MetaSyntaxKind.MetaTypeReferenceBlock2: 
                    return "MetaTypeReferenceBlock2";
                case MetaSyntaxKind.QualifierIdentifierBlock: 
                    return "QualifierIdentifierBlock";
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
                case MetaSyntaxKind.KNull: 
                    return "null";
                case MetaSyntaxKind.KTrue: 
                    return "true";
                case MetaSyntaxKind.KFalse: 
                    return "false";
                case MetaSyntaxKind.TComma: 
                    return ",";
                case MetaSyntaxKind.TUtf8Bom: 
                    return "\u00ef\u00bb\u00bf";
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
                case MetaSyntaxKind.KAbstract: 
                    return "abstract";
                case MetaSyntaxKind.KClass: 
                    return "class";
                case MetaSyntaxKind.TLParen: 
                    return "(";
                case MetaSyntaxKind.TRParen: 
                    return ")";
                case MetaSyntaxKind.KObject: 
                    return "object";
                case MetaSyntaxKind.KBool: 
                    return "bool";
                case MetaSyntaxKind.KChar: 
                    return "char";
                case MetaSyntaxKind.KString: 
                    return "string";
                case MetaSyntaxKind.KByte: 
                    return "byte";
                case MetaSyntaxKind.KSbyte: 
                    return "sbyte";
                case MetaSyntaxKind.KShort: 
                    return "short";
                case MetaSyntaxKind.KUshort: 
                    return "ushort";
                case MetaSyntaxKind.KInt: 
                    return "int";
                case MetaSyntaxKind.KUint: 
                    return "uint";
                case MetaSyntaxKind.KLong: 
                    return "long";
                case MetaSyntaxKind.KUlong: 
                    return "ulong";
                case MetaSyntaxKind.KFloat: 
                    return "float";
                case MetaSyntaxKind.KDouble: 
                    return "double";
                case MetaSyntaxKind.KDecimal: 
                    return "decimal";
                case MetaSyntaxKind.KType: 
                    return "type";
                case MetaSyntaxKind.KSymbol: 
                    return "symbol";
                case MetaSyntaxKind.KVoid: 
                    return "void";
                case MetaSyntaxKind.TEq: 
                    return "=";
                case MetaSyntaxKind.TLBrace: 
                    return "{";
                case MetaSyntaxKind.TRBrace: 
                    return "}";
                case MetaSyntaxKind.TDollar: 
                    return "$";
                case MetaSyntaxKind.TColon: 
                    return ":";
                case MetaSyntaxKind.KContains: 
                    return "contains";
                case MetaSyntaxKind.KDerived: 
                    return "derived";
                case MetaSyntaxKind.KUnion: 
                    return "union";
                case MetaSyntaxKind.KReadonly: 
                    return "readonly";
                case MetaSyntaxKind.KOpposite: 
                    return "opposite";
                case MetaSyntaxKind.KSubsets: 
                    return "subsets";
                case MetaSyntaxKind.KRedefines: 
                    return "redefines";
                case MetaSyntaxKind.TQuestion: 
                    return "?";
                case MetaSyntaxKind.TLBracket: 
                    return "[";
                case MetaSyntaxKind.TRBracket: 
                    return "]";
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
                case MetaSyntaxKind.TUtf8Bom: 
                case MetaSyntaxKind.TWhitespace: 
                case MetaSyntaxKind.TLineEnd: 
                case MetaSyntaxKind.TSingleLineComment: 
                case MetaSyntaxKind.TMultiLineComment: 
                case MetaSyntaxKind.TInvalidToken: 
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
                case MetaSyntaxKind.KNull: 
                case MetaSyntaxKind.KTrue: 
                case MetaSyntaxKind.KFalse: 
                case MetaSyntaxKind.KNamespace: 
                case MetaSyntaxKind.KUsing: 
                case MetaSyntaxKind.KMetamodel: 
                case MetaSyntaxKind.KConst: 
                case MetaSyntaxKind.KEnum: 
                case MetaSyntaxKind.KAbstract: 
                case MetaSyntaxKind.KClass: 
                case MetaSyntaxKind.KObject: 
                case MetaSyntaxKind.KBool: 
                case MetaSyntaxKind.KChar: 
                case MetaSyntaxKind.KString: 
                case MetaSyntaxKind.KByte: 
                case MetaSyntaxKind.KSbyte: 
                case MetaSyntaxKind.KShort: 
                case MetaSyntaxKind.KUshort: 
                case MetaSyntaxKind.KInt: 
                case MetaSyntaxKind.KUint: 
                case MetaSyntaxKind.KLong: 
                case MetaSyntaxKind.KUlong: 
                case MetaSyntaxKind.KFloat: 
                case MetaSyntaxKind.KDouble: 
                case MetaSyntaxKind.KDecimal: 
                case MetaSyntaxKind.KType: 
                case MetaSyntaxKind.KSymbol: 
                case MetaSyntaxKind.KVoid: 
                case MetaSyntaxKind.KContains: 
                case MetaSyntaxKind.KDerived: 
                case MetaSyntaxKind.KUnion: 
                case MetaSyntaxKind.KReadonly: 
                case MetaSyntaxKind.KOpposite: 
                case MetaSyntaxKind.KSubsets: 
                case MetaSyntaxKind.KRedefines: 
                    return true;
                default:
                    return false;
            }
        }

        protected override bool IsReservedKeyword(int rawKind)
        {
            return IsReservedKeyword((MetaSyntaxKind)rawKind);
        }

        public global::System.Collections.Generic.IEnumerable<MetaSyntaxKind> GetReservedKeywordKinds()
        {
            yield return MetaSyntaxKind.KNull;
            yield return MetaSyntaxKind.KTrue;
            yield return MetaSyntaxKind.KFalse;
            yield return MetaSyntaxKind.KNamespace;
            yield return MetaSyntaxKind.KUsing;
            yield return MetaSyntaxKind.KMetamodel;
            yield return MetaSyntaxKind.KConst;
            yield return MetaSyntaxKind.KEnum;
            yield return MetaSyntaxKind.KAbstract;
            yield return MetaSyntaxKind.KClass;
            yield return MetaSyntaxKind.KObject;
            yield return MetaSyntaxKind.KBool;
            yield return MetaSyntaxKind.KChar;
            yield return MetaSyntaxKind.KString;
            yield return MetaSyntaxKind.KByte;
            yield return MetaSyntaxKind.KSbyte;
            yield return MetaSyntaxKind.KShort;
            yield return MetaSyntaxKind.KUshort;
            yield return MetaSyntaxKind.KInt;
            yield return MetaSyntaxKind.KUint;
            yield return MetaSyntaxKind.KLong;
            yield return MetaSyntaxKind.KUlong;
            yield return MetaSyntaxKind.KFloat;
            yield return MetaSyntaxKind.KDouble;
            yield return MetaSyntaxKind.KDecimal;
            yield return MetaSyntaxKind.KType;
            yield return MetaSyntaxKind.KSymbol;
            yield return MetaSyntaxKind.KVoid;
            yield return MetaSyntaxKind.KContains;
            yield return MetaSyntaxKind.KDerived;
            yield return MetaSyntaxKind.KUnion;
            yield return MetaSyntaxKind.KReadonly;
            yield return MetaSyntaxKind.KOpposite;
            yield return MetaSyntaxKind.KSubsets;
            yield return MetaSyntaxKind.KRedefines;
            yield break;
        }

        protected override global::System.Collections.Generic.IEnumerable<int> GetReservedKeywordRawKinds()
        {
            return GetReservedKeywordKinds().Select(kind => (int)kind);
        }

        public MetaSyntaxKind GetReservedKeywordKind(string text)
        {
            switch(text)
            {
                case "null": 
                    return MetaSyntaxKind.KNull;
                case "true": 
                    return MetaSyntaxKind.KTrue;
                case "false": 
                    return MetaSyntaxKind.KFalse;
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
                case "object": 
                    return MetaSyntaxKind.KObject;
                case "bool": 
                    return MetaSyntaxKind.KBool;
                case "char": 
                    return MetaSyntaxKind.KChar;
                case "string": 
                    return MetaSyntaxKind.KString;
                case "byte": 
                    return MetaSyntaxKind.KByte;
                case "sbyte": 
                    return MetaSyntaxKind.KSbyte;
                case "short": 
                    return MetaSyntaxKind.KShort;
                case "ushort": 
                    return MetaSyntaxKind.KUshort;
                case "int": 
                    return MetaSyntaxKind.KInt;
                case "uint": 
                    return MetaSyntaxKind.KUint;
                case "long": 
                    return MetaSyntaxKind.KLong;
                case "ulong": 
                    return MetaSyntaxKind.KUlong;
                case "float": 
                    return MetaSyntaxKind.KFloat;
                case "double": 
                    return MetaSyntaxKind.KDouble;
                case "decimal": 
                    return MetaSyntaxKind.KDecimal;
                case "type": 
                    return MetaSyntaxKind.KType;
                case "symbol": 
                    return MetaSyntaxKind.KSymbol;
                case "void": 
                    return MetaSyntaxKind.KVoid;
                case "contains": 
                    return MetaSyntaxKind.KContains;
                case "derived": 
                    return MetaSyntaxKind.KDerived;
                case "union": 
                    return MetaSyntaxKind.KUnion;
                case "readonly": 
                    return MetaSyntaxKind.KReadonly;
                case "opposite": 
                    return MetaSyntaxKind.KOpposite;
                case "subsets": 
                    return MetaSyntaxKind.KSubsets;
                case "redefines": 
                    return MetaSyntaxKind.KRedefines;
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

        public global::System.Collections.Generic.IEnumerable<MetaSyntaxKind> GetContextualKeywordKinds()
        {
            yield break;
        }

        protected override global::System.Collections.Generic.IEnumerable<int> GetContextualKeywordRawKinds()
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
