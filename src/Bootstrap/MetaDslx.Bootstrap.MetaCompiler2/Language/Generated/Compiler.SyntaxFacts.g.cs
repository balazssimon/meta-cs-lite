
#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler.Syntax
{
    using System.Linq;

    public class CompilerSyntaxFacts : global::MetaDslx.CodeAnalysis.Syntax.SyntaxFacts
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
                case CompilerSyntaxKind.TUtf8Bom:
                case CompilerSyntaxKind.KNamespace:
                case CompilerSyntaxKind.TSemicolon:
                case CompilerSyntaxKind.KUsing:
                case CompilerSyntaxKind.KLanguage:
                case CompilerSyntaxKind.TColon:
                case CompilerSyntaxKind.TLParen:
                case CompilerSyntaxKind.TRParen:
                case CompilerSyntaxKind.THash:
                case CompilerSyntaxKind.THashLBrace:
                case CompilerSyntaxKind.TRBrace:
                case CompilerSyntaxKind.KEof:
                case CompilerSyntaxKind.KFragment:
                case CompilerSyntaxKind.TTilde:
                case CompilerSyntaxKind.TDot:
                case CompilerSyntaxKind.TDotDot:
                case CompilerSyntaxKind.TLBrace:
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
                case CompilerSyntaxKind.KBool:
                case CompilerSyntaxKind.KInt:
                case CompilerSyntaxKind.KDouble:
                case CompilerSyntaxKind.KString:
                case CompilerSyntaxKind.KType:
                case CompilerSyntaxKind.KSymbol:
                case CompilerSyntaxKind.KObject:
                case CompilerSyntaxKind.KVoid:
                case CompilerSyntaxKind.KReturns:
                case CompilerSyntaxKind.TBar:
                case CompilerSyntaxKind.KAlt:
                case CompilerSyntaxKind.TEqGt:
                case CompilerSyntaxKind.KToken:
                case CompilerSyntaxKind.KHidden:
                case CompilerSyntaxKind.KNull:
                case CompilerSyntaxKind.KTrue:
                case CompilerSyntaxKind.KFalse:
                case CompilerSyntaxKind.TInteger:
                case CompilerSyntaxKind.TDecimal:
                case CompilerSyntaxKind.TIdentifier:
                case CompilerSyntaxKind.TVerbatimIdentifier:
                case CompilerSyntaxKind.TString:
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
                case CompilerSyntaxKind.TUtf8Bom:
                case CompilerSyntaxKind.KNamespace:
                case CompilerSyntaxKind.TSemicolon:
                case CompilerSyntaxKind.KUsing:
                case CompilerSyntaxKind.KLanguage:
                case CompilerSyntaxKind.TColon:
                case CompilerSyntaxKind.TLParen:
                case CompilerSyntaxKind.TRParen:
                case CompilerSyntaxKind.THash:
                case CompilerSyntaxKind.THashLBrace:
                case CompilerSyntaxKind.TRBrace:
                case CompilerSyntaxKind.KEof:
                case CompilerSyntaxKind.KFragment:
                case CompilerSyntaxKind.TTilde:
                case CompilerSyntaxKind.TDot:
                case CompilerSyntaxKind.TDotDot:
                case CompilerSyntaxKind.TLBrace:
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
                case CompilerSyntaxKind.KBool:
                case CompilerSyntaxKind.KInt:
                case CompilerSyntaxKind.KDouble:
                case CompilerSyntaxKind.KString:
                case CompilerSyntaxKind.KType:
                case CompilerSyntaxKind.KSymbol:
                case CompilerSyntaxKind.KObject:
                case CompilerSyntaxKind.KVoid:
                case CompilerSyntaxKind.KReturns:
                case CompilerSyntaxKind.TBar:
                case CompilerSyntaxKind.KAlt:
                case CompilerSyntaxKind.TEqGt:
                case CompilerSyntaxKind.KToken:
                case CompilerSyntaxKind.KHidden:
                case CompilerSyntaxKind.KNull:
                case CompilerSyntaxKind.KTrue:
                case CompilerSyntaxKind.KFalse:
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
                    return CompilerSyntaxKind.TUtf8Bom;
                case "namespace": 
                    return CompilerSyntaxKind.KNamespace;
                case ";": 
                    return CompilerSyntaxKind.TSemicolon;
                case "using": 
                    return CompilerSyntaxKind.KUsing;
                case "language": 
                    return CompilerSyntaxKind.KLanguage;
                case ":": 
                    return CompilerSyntaxKind.TColon;
                case "(": 
                    return CompilerSyntaxKind.TLParen;
                case ")": 
                    return CompilerSyntaxKind.TRParen;
                case "#": 
                    return CompilerSyntaxKind.THash;
                case "#{": 
                    return CompilerSyntaxKind.THashLBrace;
                case "}": 
                    return CompilerSyntaxKind.TRBrace;
                case "eof": 
                    return CompilerSyntaxKind.KEof;
                case "fragment": 
                    return CompilerSyntaxKind.KFragment;
                case "~": 
                    return CompilerSyntaxKind.TTilde;
                case ".": 
                    return CompilerSyntaxKind.TDot;
                case "..": 
                    return CompilerSyntaxKind.TDotDot;
                case "{": 
                    return CompilerSyntaxKind.TLBrace;
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
                case "bool": 
                    return CompilerSyntaxKind.KBool;
                case "int": 
                    return CompilerSyntaxKind.KInt;
                case "double": 
                    return CompilerSyntaxKind.KDouble;
                case "string": 
                    return CompilerSyntaxKind.KString;
                case "type": 
                    return CompilerSyntaxKind.KType;
                case "symbol": 
                    return CompilerSyntaxKind.KSymbol;
                case "object": 
                    return CompilerSyntaxKind.KObject;
                case "void": 
                    return CompilerSyntaxKind.KVoid;
                case "returns": 
                    return CompilerSyntaxKind.KReturns;
                case "|": 
                    return CompilerSyntaxKind.TBar;
                case "alt": 
                    return CompilerSyntaxKind.KAlt;
                case "=>": 
                    return CompilerSyntaxKind.TEqGt;
                case "token": 
                    return CompilerSyntaxKind.KToken;
                case "hidden": 
                    return CompilerSyntaxKind.KHidden;
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
                case CompilerSyntaxKind.TUtf8Bom: 
                    return "TUtf8Bom";
                case CompilerSyntaxKind.KNamespace: 
                    return "KNamespace";
                case CompilerSyntaxKind.TSemicolon: 
                    return "TSemicolon";
                case CompilerSyntaxKind.KUsing: 
                    return "KUsing";
                case CompilerSyntaxKind.KLanguage: 
                    return "KLanguage";
                case CompilerSyntaxKind.TColon: 
                    return "TColon";
                case CompilerSyntaxKind.TLParen: 
                    return "TLParen";
                case CompilerSyntaxKind.TRParen: 
                    return "TRParen";
                case CompilerSyntaxKind.THash: 
                    return "THash";
                case CompilerSyntaxKind.THashLBrace: 
                    return "THashLBrace";
                case CompilerSyntaxKind.TRBrace: 
                    return "TRBrace";
                case CompilerSyntaxKind.KEof: 
                    return "KEof";
                case CompilerSyntaxKind.KFragment: 
                    return "KFragment";
                case CompilerSyntaxKind.TTilde: 
                    return "TTilde";
                case CompilerSyntaxKind.TDot: 
                    return "TDot";
                case CompilerSyntaxKind.TDotDot: 
                    return "TDotDot";
                case CompilerSyntaxKind.TLBrace: 
                    return "TLBrace";
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
                case CompilerSyntaxKind.KBool: 
                    return "KBool";
                case CompilerSyntaxKind.KInt: 
                    return "KInt";
                case CompilerSyntaxKind.KDouble: 
                    return "KDouble";
                case CompilerSyntaxKind.KString: 
                    return "KString";
                case CompilerSyntaxKind.KType: 
                    return "KType";
                case CompilerSyntaxKind.KSymbol: 
                    return "KSymbol";
                case CompilerSyntaxKind.KObject: 
                    return "KObject";
                case CompilerSyntaxKind.KVoid: 
                    return "KVoid";
                case CompilerSyntaxKind.KReturns: 
                    return "KReturns";
                case CompilerSyntaxKind.TBar: 
                    return "TBar";
                case CompilerSyntaxKind.KAlt: 
                    return "KAlt";
                case CompilerSyntaxKind.TEqGt: 
                    return "TEqGt";
                case CompilerSyntaxKind.KToken: 
                    return "KToken";
                case CompilerSyntaxKind.KHidden: 
                    return "KHidden";
                case CompilerSyntaxKind.KNull: 
                    return "KNull";
                case CompilerSyntaxKind.KTrue: 
                    return "KTrue";
                case CompilerSyntaxKind.KFalse: 
                    return "KFalse";
                case CompilerSyntaxKind.TInteger: 
                    return "TInteger";
                case CompilerSyntaxKind.TDecimal: 
                    return "TDecimal";
                case CompilerSyntaxKind.TIdentifier: 
                    return "TIdentifier";
                case CompilerSyntaxKind.TVerbatimIdentifier: 
                    return "TVerbatimIdentifier";
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
                case CompilerSyntaxKind.TInvalidToken: 
                    return "TInvalidToken";
                case CompilerSyntaxKind.Main: 
                    return "Main";
                case CompilerSyntaxKind.Using: 
                    return "Using";
                case CompilerSyntaxKind.LanguageDeclaration: 
                    return "LanguageDeclaration";
                case CompilerSyntaxKind.Grammar: 
                    return "Grammar";
                case CompilerSyntaxKind.GrammarRuleAlt1: 
                    return "GrammarRuleAlt1";
                case CompilerSyntaxKind.GrammarRuleAlt2: 
                    return "GrammarRuleAlt2";
                case CompilerSyntaxKind.Rule: 
                    return "Rule";
                case CompilerSyntaxKind.Alternative: 
                    return "Alternative";
                case CompilerSyntaxKind.Element: 
                    return "Element";
                case CompilerSyntaxKind.ElementValueAlt1: 
                    return "ElementValueAlt1";
                case CompilerSyntaxKind.ElementValueAlt2: 
                    return "ElementValueAlt2";
                case CompilerSyntaxKind.ElementValueAlt3: 
                    return "ElementValueAlt3";
                case CompilerSyntaxKind.ElementValueAlt4: 
                    return "ElementValueAlt4";
                case CompilerSyntaxKind.Block: 
                    return "Block";
                case CompilerSyntaxKind.BlockAlternative: 
                    return "BlockAlternative";
                case CompilerSyntaxKind.RuleRefAlt1: 
                    return "RuleRefAlt1";
                case CompilerSyntaxKind.RuleRefAlt2: 
                    return "RuleRefAlt2";
                case CompilerSyntaxKind.RuleRefAlt3: 
                    return "RuleRefAlt3";
                case CompilerSyntaxKind.Eof1: 
                    return "Eof1";
                case CompilerSyntaxKind.Fixed: 
                    return "Fixed";
                case CompilerSyntaxKind.LexerRuleAlt1: 
                    return "LexerRuleAlt1";
                case CompilerSyntaxKind.LexerRuleAlt2: 
                    return "LexerRuleAlt2";
                case CompilerSyntaxKind.Token: 
                    return "Token";
                case CompilerSyntaxKind.Fragment: 
                    return "Fragment";
                case CompilerSyntaxKind.LAlternative: 
                    return "LAlternative";
                case CompilerSyntaxKind.LElement: 
                    return "LElement";
                case CompilerSyntaxKind.LElementValueAlt1: 
                    return "LElementValueAlt1";
                case CompilerSyntaxKind.LElementValueAlt2: 
                    return "LElementValueAlt2";
                case CompilerSyntaxKind.LElementValueAlt3: 
                    return "LElementValueAlt3";
                case CompilerSyntaxKind.LElementValueAlt4: 
                    return "LElementValueAlt4";
                case CompilerSyntaxKind.LElementValueAlt5: 
                    return "LElementValueAlt5";
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
                case CompilerSyntaxKind.ExpressionAlt1: 
                    return "ExpressionAlt1";
                case CompilerSyntaxKind.ExpressionAlt2: 
                    return "ExpressionAlt2";
                case CompilerSyntaxKind.SingleExpressionAlt1: 
                    return "SingleExpressionAlt1";
                case CompilerSyntaxKind.SingleExpressionAlt2: 
                    return "SingleExpressionAlt2";
                case CompilerSyntaxKind.ArrayExpression: 
                    return "ArrayExpression";
                case CompilerSyntaxKind.ParserAnnotation: 
                    return "ParserAnnotation";
                case CompilerSyntaxKind.LexerAnnotation: 
                    return "LexerAnnotation";
                case CompilerSyntaxKind.AnnotationArgument: 
                    return "AnnotationArgument";
                case CompilerSyntaxKind.Assignment: 
                    return "Assignment";
                case CompilerSyntaxKind.Multiplicity: 
                    return "Multiplicity";
                case CompilerSyntaxKind.TypeReferenceIdentifierAlt1: 
                    return "TypeReferenceIdentifierAlt1";
                case CompilerSyntaxKind.TypeReferenceIdentifierAlt2: 
                    return "TypeReferenceIdentifierAlt2";
                case CompilerSyntaxKind.TypeReferenceAlt1: 
                    return "TypeReferenceAlt1";
                case CompilerSyntaxKind.TypeReferenceAlt2: 
                    return "TypeReferenceAlt2";
                case CompilerSyntaxKind.PrimitiveType: 
                    return "PrimitiveType";
                case CompilerSyntaxKind.Name: 
                    return "Name";
                case CompilerSyntaxKind.Qualifier: 
                    return "Qualifier";
                case CompilerSyntaxKind.Identifier: 
                    return "Identifier";
                case CompilerSyntaxKind.MainBlock1: 
                    return "MainBlock1";
                case CompilerSyntaxKind.GrammarBlock1: 
                    return "GrammarBlock1";
                case CompilerSyntaxKind.RuleBlock1Alt1: 
                    return "RuleBlock1Alt1";
                case CompilerSyntaxKind.RuleBlock1Alt2: 
                    return "RuleBlock1Alt2";
                case CompilerSyntaxKind.RulealternativesBlock: 
                    return "RulealternativesBlock";
                case CompilerSyntaxKind.AlternativeBlock1: 
                    return "AlternativeBlock1";
                case CompilerSyntaxKind.AlternativeBlock1Block1: 
                    return "AlternativeBlock1Block1";
                case CompilerSyntaxKind.AlternativeBlock2: 
                    return "AlternativeBlock2";
                case CompilerSyntaxKind.ElementBlock1: 
                    return "ElementBlock1";
                case CompilerSyntaxKind.BlockalternativesBlock: 
                    return "BlockalternativesBlock";
                case CompilerSyntaxKind.BlockAlternativeBlock1: 
                    return "BlockAlternativeBlock1";
                case CompilerSyntaxKind.RuleRefAlt3referencedTypesBlock: 
                    return "RuleRefAlt3referencedTypesBlock";
                case CompilerSyntaxKind.RuleRefAlt3Block1: 
                    return "RuleRefAlt3Block1";
                case CompilerSyntaxKind.TokenBlock1Alt1: 
                    return "TokenBlock1Alt1";
                case CompilerSyntaxKind.TokenBlock1Alt2: 
                    return "TokenBlock1Alt2";
                case CompilerSyntaxKind.TokenBlock1Alt1Block1: 
                    return "TokenBlock1Alt1Block1";
                case CompilerSyntaxKind.TokenalternativesBlock: 
                    return "TokenalternativesBlock";
                case CompilerSyntaxKind.FragmentalternativesBlock: 
                    return "FragmentalternativesBlock";
                case CompilerSyntaxKind.LBlockalternativesBlock: 
                    return "LBlockalternativesBlock";
                case CompilerSyntaxKind.SingleExpressionAlt1Block1Alt1: 
                    return "SingleExpressionAlt1Block1Alt1";
                case CompilerSyntaxKind.SingleExpressionAlt1Block1Alt2: 
                    return "SingleExpressionAlt1Block1Alt2";
                case CompilerSyntaxKind.SingleExpressionAlt1Block1Alt3: 
                    return "SingleExpressionAlt1Block1Alt3";
                case CompilerSyntaxKind.SingleExpressionAlt1Block1Alt4: 
                    return "SingleExpressionAlt1Block1Alt4";
                case CompilerSyntaxKind.SingleExpressionAlt1Block1Alt5: 
                    return "SingleExpressionAlt1Block1Alt5";
                case CompilerSyntaxKind.SingleExpressionAlt1Block1Alt6: 
                    return "SingleExpressionAlt1Block1Alt6";
                case CompilerSyntaxKind.SingleExpressionAlt1Block1Alt7: 
                    return "SingleExpressionAlt1Block1Alt7";
                case CompilerSyntaxKind.ArrayExpressionBlock1: 
                    return "ArrayExpressionBlock1";
                case CompilerSyntaxKind.ArrayExpressionBlock1itemsBlock: 
                    return "ArrayExpressionBlock1itemsBlock";
                case CompilerSyntaxKind.ParserAnnotationBlock1: 
                    return "ParserAnnotationBlock1";
                case CompilerSyntaxKind.ParserAnnotationBlock1argumentsBlock: 
                    return "ParserAnnotationBlock1argumentsBlock";
                case CompilerSyntaxKind.LexerAnnotationBlock1: 
                    return "LexerAnnotationBlock1";
                case CompilerSyntaxKind.LexerAnnotationBlock1argumentsBlock: 
                    return "LexerAnnotationBlock1argumentsBlock";
                case CompilerSyntaxKind.AnnotationArgumentBlock1: 
                    return "AnnotationArgumentBlock1";
                case CompilerSyntaxKind.QualifierIdentifierBlock: 
                    return "QualifierIdentifierBlock";
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
                case CompilerSyntaxKind.TUtf8Bom: 
                    return "\u00ef\u00bb\u00bf";
                case CompilerSyntaxKind.KNamespace: 
                    return "namespace";
                case CompilerSyntaxKind.TSemicolon: 
                    return ";";
                case CompilerSyntaxKind.KUsing: 
                    return "using";
                case CompilerSyntaxKind.KLanguage: 
                    return "language";
                case CompilerSyntaxKind.TColon: 
                    return ":";
                case CompilerSyntaxKind.TLParen: 
                    return "(";
                case CompilerSyntaxKind.TRParen: 
                    return ")";
                case CompilerSyntaxKind.THash: 
                    return "#";
                case CompilerSyntaxKind.THashLBrace: 
                    return "#{";
                case CompilerSyntaxKind.TRBrace: 
                    return "}";
                case CompilerSyntaxKind.KEof: 
                    return "eof";
                case CompilerSyntaxKind.KFragment: 
                    return "fragment";
                case CompilerSyntaxKind.TTilde: 
                    return "~";
                case CompilerSyntaxKind.TDot: 
                    return ".";
                case CompilerSyntaxKind.TDotDot: 
                    return "..";
                case CompilerSyntaxKind.TLBrace: 
                    return "{";
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
                case CompilerSyntaxKind.KBool: 
                    return "bool";
                case CompilerSyntaxKind.KInt: 
                    return "int";
                case CompilerSyntaxKind.KDouble: 
                    return "double";
                case CompilerSyntaxKind.KString: 
                    return "string";
                case CompilerSyntaxKind.KType: 
                    return "type";
                case CompilerSyntaxKind.KSymbol: 
                    return "symbol";
                case CompilerSyntaxKind.KObject: 
                    return "object";
                case CompilerSyntaxKind.KVoid: 
                    return "void";
                case CompilerSyntaxKind.KReturns: 
                    return "returns";
                case CompilerSyntaxKind.TBar: 
                    return "|";
                case CompilerSyntaxKind.KAlt: 
                    return "alt";
                case CompilerSyntaxKind.TEqGt: 
                    return "=>";
                case CompilerSyntaxKind.KToken: 
                    return "token";
                case CompilerSyntaxKind.KHidden: 
                    return "hidden";
                case CompilerSyntaxKind.KNull: 
                    return "null";
                case CompilerSyntaxKind.KTrue: 
                    return "true";
                case CompilerSyntaxKind.KFalse: 
                    return "false";
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
                case CompilerSyntaxKind.TUtf8Bom: 
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
                case CompilerSyntaxKind.KEof: 
                case CompilerSyntaxKind.KFragment: 
                case CompilerSyntaxKind.KBool: 
                case CompilerSyntaxKind.KInt: 
                case CompilerSyntaxKind.KDouble: 
                case CompilerSyntaxKind.KString: 
                case CompilerSyntaxKind.KType: 
                case CompilerSyntaxKind.KSymbol: 
                case CompilerSyntaxKind.KObject: 
                case CompilerSyntaxKind.KVoid: 
                case CompilerSyntaxKind.KReturns: 
                case CompilerSyntaxKind.KAlt: 
                case CompilerSyntaxKind.KToken: 
                case CompilerSyntaxKind.KHidden: 
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

        public global::System.Collections.Generic.IEnumerable<CompilerSyntaxKind> GetReservedKeywordKinds()
        {
            yield return CompilerSyntaxKind.KNamespace;
            yield return CompilerSyntaxKind.KUsing;
            yield return CompilerSyntaxKind.KLanguage;
            yield return CompilerSyntaxKind.KEof;
            yield return CompilerSyntaxKind.KFragment;
            yield return CompilerSyntaxKind.KBool;
            yield return CompilerSyntaxKind.KInt;
            yield return CompilerSyntaxKind.KDouble;
            yield return CompilerSyntaxKind.KString;
            yield return CompilerSyntaxKind.KType;
            yield return CompilerSyntaxKind.KSymbol;
            yield return CompilerSyntaxKind.KObject;
            yield return CompilerSyntaxKind.KVoid;
            yield return CompilerSyntaxKind.KReturns;
            yield return CompilerSyntaxKind.KAlt;
            yield return CompilerSyntaxKind.KToken;
            yield return CompilerSyntaxKind.KHidden;
            yield return CompilerSyntaxKind.KNull;
            yield return CompilerSyntaxKind.KTrue;
            yield return CompilerSyntaxKind.KFalse;
            yield break;
        }

        protected override global::System.Collections.Generic.IEnumerable<int> GetReservedKeywordRawKinds()
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
                case "eof": 
                    return CompilerSyntaxKind.KEof;
                case "fragment": 
                    return CompilerSyntaxKind.KFragment;
                case "bool": 
                    return CompilerSyntaxKind.KBool;
                case "int": 
                    return CompilerSyntaxKind.KInt;
                case "double": 
                    return CompilerSyntaxKind.KDouble;
                case "string": 
                    return CompilerSyntaxKind.KString;
                case "type": 
                    return CompilerSyntaxKind.KType;
                case "symbol": 
                    return CompilerSyntaxKind.KSymbol;
                case "object": 
                    return CompilerSyntaxKind.KObject;
                case "void": 
                    return CompilerSyntaxKind.KVoid;
                case "returns": 
                    return CompilerSyntaxKind.KReturns;
                case "alt": 
                    return CompilerSyntaxKind.KAlt;
                case "token": 
                    return CompilerSyntaxKind.KToken;
                case "hidden": 
                    return CompilerSyntaxKind.KHidden;
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

        public global::System.Collections.Generic.IEnumerable<CompilerSyntaxKind> GetContextualKeywordKinds()
        {
            yield break;
        }

        protected override global::System.Collections.Generic.IEnumerable<int> GetContextualKeywordRawKinds()
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
