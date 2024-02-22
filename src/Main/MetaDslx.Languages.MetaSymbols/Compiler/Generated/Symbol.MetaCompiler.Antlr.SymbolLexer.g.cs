//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SymbolLexer.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MetaDslx.Languages.MetaSymbols.Compiler {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public partial class SymbolLexer : global::MetaDslx.CodeAnalysis.Parsers.Antlr.AntlrLexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LR_KNull=1, LR_KTrue=2, LR_KFalse=3, LR_TComma=4, LR_TUtf8Bom=5, LR_KNamespace=6, 
		LR_KUsing=7, LR_KAbstract=8, LR_KSymbol=9, LR_KPlain=10, LR_KWeak=11, 
		LR_KPhase=12, LR_TLParen=13, LR_TRParen=14, LR_KCached=15, LR_KObject=16, 
		LR_KBool=17, LR_KChar=18, LR_KString=19, LR_KByte=20, LR_KSbyte=21, LR_KShort=22, 
		LR_KUshort=23, LR_KInt=24, LR_KUint=25, LR_KLong=26, LR_KUlong=27, LR_KFloat=28, 
		LR_KDouble=29, LR_KDecimal=30, LR_KType=31, LR_KVoid=32, LR_TColon=33, 
		LR_TLBrace=34, LR_TRBrace=35, LR_KDerived=36, LR_TEq=37, LR_KIf=38, LR_TQuestion=39, 
		LR_TLBracket=40, LR_TRBracket=41, LR_TDot=42, LR_TInteger=43, LR_TDecimal=44, 
		LR_TIdentifier=45, LR_TVerbatimIdentifier=46, LR_TString=47, LR_TWhitespace=48, 
		LR_TLineEnd=49, LR_TSingleLineComment=50, LR_TMultiLineComment=51, LR_TInvalidToken=52;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TComma", "LR_TUtf8Bom", "LR_KNamespace", 
		"LR_KUsing", "LR_KAbstract", "LR_KSymbol", "LR_KPlain", "LR_KWeak", "LR_KPhase", 
		"LR_TLParen", "LR_TRParen", "LR_KCached", "LR_KObject", "LR_KBool", "LR_KChar", 
		"LR_KString", "LR_KByte", "LR_KSbyte", "LR_KShort", "LR_KUshort", "LR_KInt", 
		"LR_KUint", "LR_KLong", "LR_KUlong", "LR_KFloat", "LR_KDouble", "LR_KDecimal", 
		"LR_KType", "LR_KVoid", "LR_TColon", "LR_TLBrace", "LR_TRBrace", "LR_KDerived", 
		"LR_TEq", "LR_KIf", "LR_TQuestion", "LR_TLBracket", "LR_TRBracket", "LR_TDot", 
		"LR_TInteger", "LR_TDecimal", "LR_TIdentifier", "LR_TVerbatimIdentifier", 
		"LR_TString", "LR_TWhitespace", "LR_TLineEnd", "LR_TSingleLineComment", 
		"LR_TMultiLineComment", "LR_TInvalidToken", "FR_DoubleQuoteTextCharacter", 
		"FR_DoubleQuoteTextSimple", "FR_SingleQuoteTextCharacter", "FR_SingleQuoteTextSimple", 
		"FR_CharacterEscapeSimple", "FR_CharacterEscapeSimpleCharacter", "FR_CharacterEscapeUnicode", 
		"FR_HexDigit"
	};


	public SymbolLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public SymbolLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'null'", "'true'", "'false'", "','", null, "'namespace'", "'using'", 
		"'abstract'", "'symbol'", "'plain'", "'weak'", "'phase'", "'('", "')'", 
		"'cached'", "'object'", "'bool'", "'char'", "'string'", "'byte'", "'sbyte'", 
		"'short'", "'ushort'", "'int'", "'uint'", "'long'", "'ulong'", "'float'", 
		"'double'", "'decimal'", "'type'", "'void'", "':'", "'{'", "'}'", "'derived'", 
		"'='", "'if'", "'?'", "'['", "']'", "'.'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TComma", "LR_TUtf8Bom", 
		"LR_KNamespace", "LR_KUsing", "LR_KAbstract", "LR_KSymbol", "LR_KPlain", 
		"LR_KWeak", "LR_KPhase", "LR_TLParen", "LR_TRParen", "LR_KCached", "LR_KObject", 
		"LR_KBool", "LR_KChar", "LR_KString", "LR_KByte", "LR_KSbyte", "LR_KShort", 
		"LR_KUshort", "LR_KInt", "LR_KUint", "LR_KLong", "LR_KUlong", "LR_KFloat", 
		"LR_KDouble", "LR_KDecimal", "LR_KType", "LR_KVoid", "LR_TColon", "LR_TLBrace", 
		"LR_TRBrace", "LR_KDerived", "LR_TEq", "LR_KIf", "LR_TQuestion", "LR_TLBracket", 
		"LR_TRBracket", "LR_TDot", "LR_TInteger", "LR_TDecimal", "LR_TIdentifier", 
		"LR_TVerbatimIdentifier", "LR_TString", "LR_TWhitespace", "LR_TLineEnd", 
		"LR_TSingleLineComment", "LR_TMultiLineComment", "LR_TInvalidToken"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "SymbolLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static SymbolLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,52,484,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,1,0,1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,
		1,1,1,2,1,2,1,2,1,2,1,2,1,2,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,
		5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,
		1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,
		9,1,10,1,10,1,10,1,10,1,10,1,11,1,11,1,11,1,11,1,11,1,11,1,12,1,12,1,13,
		1,13,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,15,1,15,1,15,1,15,1,15,1,15,
		1,15,1,16,1,16,1,16,1,16,1,16,1,17,1,17,1,17,1,17,1,17,1,18,1,18,1,18,
		1,18,1,18,1,18,1,18,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,20,
		1,20,1,21,1,21,1,21,1,21,1,21,1,21,1,22,1,22,1,22,1,22,1,22,1,22,1,22,
		1,23,1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,24,1,25,1,25,1,25,1,25,1,25,
		1,26,1,26,1,26,1,26,1,26,1,26,1,27,1,27,1,27,1,27,1,27,1,27,1,28,1,28,
		1,28,1,28,1,28,1,28,1,28,1,29,1,29,1,29,1,29,1,29,1,29,1,29,1,29,1,30,
		1,30,1,30,1,30,1,30,1,31,1,31,1,31,1,31,1,31,1,32,1,32,1,33,1,33,1,34,
		1,34,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,36,1,36,1,37,1,37,1,37,
		1,38,1,38,1,39,1,39,1,40,1,40,1,41,1,41,1,42,1,42,1,42,5,42,335,8,42,10,
		42,12,42,338,9,42,3,42,340,8,42,1,43,1,43,1,43,5,43,345,8,43,10,43,12,
		43,348,9,43,3,43,350,8,43,1,43,1,43,4,43,354,8,43,11,43,12,43,355,1,44,
		4,44,359,8,44,11,44,12,44,360,1,44,5,44,364,8,44,10,44,12,44,367,9,44,
		1,45,1,45,4,45,371,8,45,11,45,12,45,372,1,45,5,45,376,8,45,10,45,12,45,
		379,9,45,1,46,1,46,5,46,383,8,46,10,46,12,46,386,9,46,1,46,1,46,1,46,5,
		46,391,8,46,10,46,12,46,394,9,46,1,46,3,46,397,8,46,1,47,4,47,400,8,47,
		11,47,12,47,401,1,47,1,47,1,48,1,48,1,48,3,48,409,8,48,1,48,1,48,1,49,
		1,49,1,49,1,49,5,49,417,8,49,10,49,12,49,420,9,49,1,49,1,49,1,50,1,50,
		1,50,1,50,5,50,428,8,50,10,50,12,50,431,9,50,1,50,1,50,1,50,1,50,1,50,
		1,51,1,51,1,51,1,51,1,52,1,52,1,52,3,52,445,8,52,1,53,1,53,1,54,1,54,1,
		54,3,54,452,8,54,1,55,1,55,1,56,1,56,1,56,1,57,1,57,1,58,1,58,1,58,1,58,
		1,58,1,58,1,58,1,58,1,58,1,58,1,58,1,58,1,58,1,58,1,58,1,58,1,58,1,58,
		1,58,1,58,3,58,481,8,58,1,59,1,59,1,429,0,60,1,1,3,2,5,3,7,4,9,5,11,6,
		13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,
		19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,57,29,59,30,61,
		31,63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,39,79,40,81,41,83,42,85,
		43,87,44,89,45,91,46,93,47,95,48,97,49,99,50,101,51,103,52,105,0,107,0,
		109,0,111,0,113,0,115,0,117,0,119,0,1,0,8,3,0,65,90,95,95,97,122,4,0,48,
		57,65,90,95,95,97,122,2,0,9,9,32,32,2,0,10,10,13,13,6,0,10,10,13,13,34,
		34,92,92,133,133,8232,8233,6,0,10,10,13,13,39,39,92,92,133,133,8232,8233,
		10,0,34,34,39,39,48,48,92,92,97,98,102,102,110,110,114,114,116,116,118,
		118,3,0,48,57,65,70,97,102,496,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,
		1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,
		0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,
		1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,
		0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,
		1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,
		0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,
		1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,
		0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,
		1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,1,0,0,0,0,103,1,0,0,0,1,121,1,
		0,0,0,3,126,1,0,0,0,5,131,1,0,0,0,7,137,1,0,0,0,9,139,1,0,0,0,11,145,1,
		0,0,0,13,155,1,0,0,0,15,161,1,0,0,0,17,170,1,0,0,0,19,177,1,0,0,0,21,183,
		1,0,0,0,23,188,1,0,0,0,25,194,1,0,0,0,27,196,1,0,0,0,29,198,1,0,0,0,31,
		205,1,0,0,0,33,212,1,0,0,0,35,217,1,0,0,0,37,222,1,0,0,0,39,229,1,0,0,
		0,41,234,1,0,0,0,43,240,1,0,0,0,45,246,1,0,0,0,47,253,1,0,0,0,49,257,1,
		0,0,0,51,262,1,0,0,0,53,267,1,0,0,0,55,273,1,0,0,0,57,279,1,0,0,0,59,286,
		1,0,0,0,61,294,1,0,0,0,63,299,1,0,0,0,65,304,1,0,0,0,67,306,1,0,0,0,69,
		308,1,0,0,0,71,310,1,0,0,0,73,318,1,0,0,0,75,320,1,0,0,0,77,323,1,0,0,
		0,79,325,1,0,0,0,81,327,1,0,0,0,83,329,1,0,0,0,85,339,1,0,0,0,87,349,1,
		0,0,0,89,358,1,0,0,0,91,368,1,0,0,0,93,396,1,0,0,0,95,399,1,0,0,0,97,408,
		1,0,0,0,99,412,1,0,0,0,101,423,1,0,0,0,103,437,1,0,0,0,105,444,1,0,0,0,
		107,446,1,0,0,0,109,451,1,0,0,0,111,453,1,0,0,0,113,455,1,0,0,0,115,458,
		1,0,0,0,117,480,1,0,0,0,119,482,1,0,0,0,121,122,5,110,0,0,122,123,5,117,
		0,0,123,124,5,108,0,0,124,125,5,108,0,0,125,2,1,0,0,0,126,127,5,116,0,
		0,127,128,5,114,0,0,128,129,5,117,0,0,129,130,5,101,0,0,130,4,1,0,0,0,
		131,132,5,102,0,0,132,133,5,97,0,0,133,134,5,108,0,0,134,135,5,115,0,0,
		135,136,5,101,0,0,136,6,1,0,0,0,137,138,5,44,0,0,138,8,1,0,0,0,139,140,
		5,239,0,0,140,141,5,187,0,0,141,142,5,191,0,0,142,143,1,0,0,0,143,144,
		6,4,0,0,144,10,1,0,0,0,145,146,5,110,0,0,146,147,5,97,0,0,147,148,5,109,
		0,0,148,149,5,101,0,0,149,150,5,115,0,0,150,151,5,112,0,0,151,152,5,97,
		0,0,152,153,5,99,0,0,153,154,5,101,0,0,154,12,1,0,0,0,155,156,5,117,0,
		0,156,157,5,115,0,0,157,158,5,105,0,0,158,159,5,110,0,0,159,160,5,103,
		0,0,160,14,1,0,0,0,161,162,5,97,0,0,162,163,5,98,0,0,163,164,5,115,0,0,
		164,165,5,116,0,0,165,166,5,114,0,0,166,167,5,97,0,0,167,168,5,99,0,0,
		168,169,5,116,0,0,169,16,1,0,0,0,170,171,5,115,0,0,171,172,5,121,0,0,172,
		173,5,109,0,0,173,174,5,98,0,0,174,175,5,111,0,0,175,176,5,108,0,0,176,
		18,1,0,0,0,177,178,5,112,0,0,178,179,5,108,0,0,179,180,5,97,0,0,180,181,
		5,105,0,0,181,182,5,110,0,0,182,20,1,0,0,0,183,184,5,119,0,0,184,185,5,
		101,0,0,185,186,5,97,0,0,186,187,5,107,0,0,187,22,1,0,0,0,188,189,5,112,
		0,0,189,190,5,104,0,0,190,191,5,97,0,0,191,192,5,115,0,0,192,193,5,101,
		0,0,193,24,1,0,0,0,194,195,5,40,0,0,195,26,1,0,0,0,196,197,5,41,0,0,197,
		28,1,0,0,0,198,199,5,99,0,0,199,200,5,97,0,0,200,201,5,99,0,0,201,202,
		5,104,0,0,202,203,5,101,0,0,203,204,5,100,0,0,204,30,1,0,0,0,205,206,5,
		111,0,0,206,207,5,98,0,0,207,208,5,106,0,0,208,209,5,101,0,0,209,210,5,
		99,0,0,210,211,5,116,0,0,211,32,1,0,0,0,212,213,5,98,0,0,213,214,5,111,
		0,0,214,215,5,111,0,0,215,216,5,108,0,0,216,34,1,0,0,0,217,218,5,99,0,
		0,218,219,5,104,0,0,219,220,5,97,0,0,220,221,5,114,0,0,221,36,1,0,0,0,
		222,223,5,115,0,0,223,224,5,116,0,0,224,225,5,114,0,0,225,226,5,105,0,
		0,226,227,5,110,0,0,227,228,5,103,0,0,228,38,1,0,0,0,229,230,5,98,0,0,
		230,231,5,121,0,0,231,232,5,116,0,0,232,233,5,101,0,0,233,40,1,0,0,0,234,
		235,5,115,0,0,235,236,5,98,0,0,236,237,5,121,0,0,237,238,5,116,0,0,238,
		239,5,101,0,0,239,42,1,0,0,0,240,241,5,115,0,0,241,242,5,104,0,0,242,243,
		5,111,0,0,243,244,5,114,0,0,244,245,5,116,0,0,245,44,1,0,0,0,246,247,5,
		117,0,0,247,248,5,115,0,0,248,249,5,104,0,0,249,250,5,111,0,0,250,251,
		5,114,0,0,251,252,5,116,0,0,252,46,1,0,0,0,253,254,5,105,0,0,254,255,5,
		110,0,0,255,256,5,116,0,0,256,48,1,0,0,0,257,258,5,117,0,0,258,259,5,105,
		0,0,259,260,5,110,0,0,260,261,5,116,0,0,261,50,1,0,0,0,262,263,5,108,0,
		0,263,264,5,111,0,0,264,265,5,110,0,0,265,266,5,103,0,0,266,52,1,0,0,0,
		267,268,5,117,0,0,268,269,5,108,0,0,269,270,5,111,0,0,270,271,5,110,0,
		0,271,272,5,103,0,0,272,54,1,0,0,0,273,274,5,102,0,0,274,275,5,108,0,0,
		275,276,5,111,0,0,276,277,5,97,0,0,277,278,5,116,0,0,278,56,1,0,0,0,279,
		280,5,100,0,0,280,281,5,111,0,0,281,282,5,117,0,0,282,283,5,98,0,0,283,
		284,5,108,0,0,284,285,5,101,0,0,285,58,1,0,0,0,286,287,5,100,0,0,287,288,
		5,101,0,0,288,289,5,99,0,0,289,290,5,105,0,0,290,291,5,109,0,0,291,292,
		5,97,0,0,292,293,5,108,0,0,293,60,1,0,0,0,294,295,5,116,0,0,295,296,5,
		121,0,0,296,297,5,112,0,0,297,298,5,101,0,0,298,62,1,0,0,0,299,300,5,118,
		0,0,300,301,5,111,0,0,301,302,5,105,0,0,302,303,5,100,0,0,303,64,1,0,0,
		0,304,305,5,58,0,0,305,66,1,0,0,0,306,307,5,123,0,0,307,68,1,0,0,0,308,
		309,5,125,0,0,309,70,1,0,0,0,310,311,5,100,0,0,311,312,5,101,0,0,312,313,
		5,114,0,0,313,314,5,105,0,0,314,315,5,118,0,0,315,316,5,101,0,0,316,317,
		5,100,0,0,317,72,1,0,0,0,318,319,5,61,0,0,319,74,1,0,0,0,320,321,5,105,
		0,0,321,322,5,102,0,0,322,76,1,0,0,0,323,324,5,63,0,0,324,78,1,0,0,0,325,
		326,5,91,0,0,326,80,1,0,0,0,327,328,5,93,0,0,328,82,1,0,0,0,329,330,5,
		46,0,0,330,84,1,0,0,0,331,340,5,48,0,0,332,336,2,49,57,0,333,335,2,48,
		57,0,334,333,1,0,0,0,335,338,1,0,0,0,336,334,1,0,0,0,336,337,1,0,0,0,337,
		340,1,0,0,0,338,336,1,0,0,0,339,331,1,0,0,0,339,332,1,0,0,0,340,86,1,0,
		0,0,341,350,5,48,0,0,342,346,2,49,57,0,343,345,2,48,57,0,344,343,1,0,0,
		0,345,348,1,0,0,0,346,344,1,0,0,0,346,347,1,0,0,0,347,350,1,0,0,0,348,
		346,1,0,0,0,349,341,1,0,0,0,349,342,1,0,0,0,350,351,1,0,0,0,351,353,5,
		46,0,0,352,354,2,48,57,0,353,352,1,0,0,0,354,355,1,0,0,0,355,353,1,0,0,
		0,355,356,1,0,0,0,356,88,1,0,0,0,357,359,7,0,0,0,358,357,1,0,0,0,359,360,
		1,0,0,0,360,358,1,0,0,0,360,361,1,0,0,0,361,365,1,0,0,0,362,364,7,1,0,
		0,363,362,1,0,0,0,364,367,1,0,0,0,365,363,1,0,0,0,365,366,1,0,0,0,366,
		90,1,0,0,0,367,365,1,0,0,0,368,370,5,64,0,0,369,371,7,0,0,0,370,369,1,
		0,0,0,371,372,1,0,0,0,372,370,1,0,0,0,372,373,1,0,0,0,373,377,1,0,0,0,
		374,376,7,1,0,0,375,374,1,0,0,0,376,379,1,0,0,0,377,375,1,0,0,0,377,378,
		1,0,0,0,378,92,1,0,0,0,379,377,1,0,0,0,380,384,5,34,0,0,381,383,3,105,
		52,0,382,381,1,0,0,0,383,386,1,0,0,0,384,382,1,0,0,0,384,385,1,0,0,0,385,
		387,1,0,0,0,386,384,1,0,0,0,387,397,5,34,0,0,388,392,5,39,0,0,389,391,
		3,109,54,0,390,389,1,0,0,0,391,394,1,0,0,0,392,390,1,0,0,0,392,393,1,0,
		0,0,393,395,1,0,0,0,394,392,1,0,0,0,395,397,5,39,0,0,396,380,1,0,0,0,396,
		388,1,0,0,0,397,94,1,0,0,0,398,400,7,2,0,0,399,398,1,0,0,0,400,401,1,0,
		0,0,401,399,1,0,0,0,401,402,1,0,0,0,402,403,1,0,0,0,403,404,6,47,0,0,404,
		96,1,0,0,0,405,406,5,13,0,0,406,409,5,10,0,0,407,409,7,3,0,0,408,405,1,
		0,0,0,408,407,1,0,0,0,409,410,1,0,0,0,410,411,6,48,0,0,411,98,1,0,0,0,
		412,413,5,47,0,0,413,414,5,47,0,0,414,418,1,0,0,0,415,417,8,3,0,0,416,
		415,1,0,0,0,417,420,1,0,0,0,418,416,1,0,0,0,418,419,1,0,0,0,419,421,1,
		0,0,0,420,418,1,0,0,0,421,422,6,49,0,0,422,100,1,0,0,0,423,424,5,47,0,
		0,424,425,5,42,0,0,425,429,1,0,0,0,426,428,9,0,0,0,427,426,1,0,0,0,428,
		431,1,0,0,0,429,430,1,0,0,0,429,427,1,0,0,0,430,432,1,0,0,0,431,429,1,
		0,0,0,432,433,5,42,0,0,433,434,5,47,0,0,434,435,1,0,0,0,435,436,6,50,0,
		0,436,102,1,0,0,0,437,438,9,0,0,0,438,439,1,0,0,0,439,440,6,51,0,0,440,
		104,1,0,0,0,441,445,3,107,53,0,442,445,3,113,56,0,443,445,3,117,58,0,444,
		441,1,0,0,0,444,442,1,0,0,0,444,443,1,0,0,0,445,106,1,0,0,0,446,447,8,
		4,0,0,447,108,1,0,0,0,448,452,3,111,55,0,449,452,3,113,56,0,450,452,3,
		117,58,0,451,448,1,0,0,0,451,449,1,0,0,0,451,450,1,0,0,0,452,110,1,0,0,
		0,453,454,8,5,0,0,454,112,1,0,0,0,455,456,5,92,0,0,456,457,3,115,57,0,
		457,114,1,0,0,0,458,459,7,6,0,0,459,116,1,0,0,0,460,461,5,92,0,0,461,462,
		5,117,0,0,462,463,1,0,0,0,463,464,3,119,59,0,464,465,3,119,59,0,465,466,
		3,119,59,0,466,467,3,119,59,0,467,481,1,0,0,0,468,469,5,92,0,0,469,470,
		5,85,0,0,470,471,1,0,0,0,471,472,3,119,59,0,472,473,3,119,59,0,473,474,
		3,119,59,0,474,475,3,119,59,0,475,476,3,119,59,0,476,477,3,119,59,0,477,
		478,3,119,59,0,478,479,3,119,59,0,479,481,1,0,0,0,480,460,1,0,0,0,480,
		468,1,0,0,0,481,118,1,0,0,0,482,483,7,7,0,0,483,120,1,0,0,0,20,0,336,339,
		346,349,355,360,365,372,377,384,392,396,401,408,418,429,444,451,480,1,
		0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MetaDslx.Languages.MetaSymbols.Compiler
