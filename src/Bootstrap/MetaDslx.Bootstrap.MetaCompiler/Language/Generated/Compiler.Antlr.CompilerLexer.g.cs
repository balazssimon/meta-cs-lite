//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CompilerLexer.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public partial class CompilerLexer : global::MetaDslx.CodeAnalysis.Parsers.Antlr.AntlrLexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LR_TComma=1, LR_TUtf8Bom=2, LR_KNamespace=3, LR_TSemicolon=4, LR_KUsing=5, 
		LR_KLanguage=6, LR_TColon=7, LR_TLParen=8, LR_TRParen=9, LR_THash=10, 
		LR_THashLBrace=11, LR_TRBrace=12, LR_KEof=13, LR_KFragment=14, LR_TTilde=15, 
		LR_TDot=16, LR_TDotDot=17, LR_TLBrace=18, LR_TLBracket=19, LR_TRBracket=20, 
		LR_TEq=21, LR_TQuestionEq=22, LR_TExclEq=23, LR_TPlusEq=24, LR_TQuestion=25, 
		LR_TAsterisk=26, LR_TPlus=27, LR_TQuestionQuestion=28, LR_TAsteriskQuestion=29, 
		LR_TPlusQuestion=30, LR_KBool=31, LR_KInt=32, LR_KDouble=33, LR_KString=34, 
		LR_KType=35, LR_KSymbol=36, LR_KObject=37, LR_KVoid=38, LR_KReturns=39, 
		LR_TBar=40, LR_KAlt=41, LR_TEqGt=42, LR_KToken=43, LR_KHidden=44, LR_KNull=45, 
		LR_KTrue=46, LR_KFalse=47, LR_TInteger=48, LR_TDecimal=49, LR_TIdentifier=50, 
		LR_TVerbatimIdentifier=51, LR_TString=52, LR_TWhitespace=53, LR_TLineEnd=54, 
		LR_TSingleLineComment=55, LR_TMultiLineComment=56, LR_TInvalidToken=57;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LR_TComma", "LR_TUtf8Bom", "LR_KNamespace", "LR_TSemicolon", "LR_KUsing", 
		"LR_KLanguage", "LR_TColon", "LR_TLParen", "LR_TRParen", "LR_THash", "LR_THashLBrace", 
		"LR_TRBrace", "LR_KEof", "LR_KFragment", "LR_TTilde", "LR_TDot", "LR_TDotDot", 
		"LR_TLBrace", "LR_TLBracket", "LR_TRBracket", "LR_TEq", "LR_TQuestionEq", 
		"LR_TExclEq", "LR_TPlusEq", "LR_TQuestion", "LR_TAsterisk", "LR_TPlus", 
		"LR_TQuestionQuestion", "LR_TAsteriskQuestion", "LR_TPlusQuestion", "LR_KBool", 
		"LR_KInt", "LR_KDouble", "LR_KString", "LR_KType", "LR_KSymbol", "LR_KObject", 
		"LR_KVoid", "LR_KReturns", "LR_TBar", "LR_KAlt", "LR_TEqGt", "LR_KToken", 
		"LR_KHidden", "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TInteger", "LR_TDecimal", 
		"LR_TIdentifier", "LR_TVerbatimIdentifier", "LR_TString", "LR_TWhitespace", 
		"LR_TLineEnd", "LR_TSingleLineComment", "LR_TMultiLineComment", "LR_TInvalidToken", 
		"FR_DoubleQuoteTextCharacter", "FR_DoubleQuoteTextSimple", "FR_SingleQuoteTextCharacter", 
		"FR_SingleQuoteTextSimple", "FR_CharacterEscapeSimple", "FR_CharacterEscapeSimpleCharacter", 
		"FR_CharacterEscapeUnicode", "FR_HexDigit"
	};


	public CompilerLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CompilerLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "','", null, "'namespace'", "';'", "'using'", "'language'", "':'", 
		"'('", "')'", "'#'", "'#{'", "'}'", "'eof'", "'fragment'", "'~'", "'.'", 
		"'..'", "'{'", "'['", "']'", "'='", "'?='", "'!='", "'+='", "'?'", "'*'", 
		"'+'", "'??'", "'*?'", "'+?'", "'bool'", "'int'", "'double'", "'string'", 
		"'type'", "'symbol'", "'object'", "'void'", "'returns'", "'|'", "'alt'", 
		"'=>'", "'token'", "'hidden'", "'null'", "'true'", "'false'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LR_TComma", "LR_TUtf8Bom", "LR_KNamespace", "LR_TSemicolon", "LR_KUsing", 
		"LR_KLanguage", "LR_TColon", "LR_TLParen", "LR_TRParen", "LR_THash", "LR_THashLBrace", 
		"LR_TRBrace", "LR_KEof", "LR_KFragment", "LR_TTilde", "LR_TDot", "LR_TDotDot", 
		"LR_TLBrace", "LR_TLBracket", "LR_TRBracket", "LR_TEq", "LR_TQuestionEq", 
		"LR_TExclEq", "LR_TPlusEq", "LR_TQuestion", "LR_TAsterisk", "LR_TPlus", 
		"LR_TQuestionQuestion", "LR_TAsteriskQuestion", "LR_TPlusQuestion", "LR_KBool", 
		"LR_KInt", "LR_KDouble", "LR_KString", "LR_KType", "LR_KSymbol", "LR_KObject", 
		"LR_KVoid", "LR_KReturns", "LR_TBar", "LR_KAlt", "LR_TEqGt", "LR_KToken", 
		"LR_KHidden", "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TInteger", "LR_TDecimal", 
		"LR_TIdentifier", "LR_TVerbatimIdentifier", "LR_TString", "LR_TWhitespace", 
		"LR_TLineEnd", "LR_TSingleLineComment", "LR_TMultiLineComment", "LR_TInvalidToken"
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

	public override string GrammarFileName { get { return "CompilerLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static CompilerLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,57,477,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,
		7,63,2,64,7,64,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,2,
		1,2,1,2,1,2,1,2,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,
		5,1,5,1,5,1,5,1,6,1,6,1,7,1,7,1,8,1,8,1,9,1,9,1,10,1,10,1,10,1,11,1,11,
		1,12,1,12,1,12,1,12,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,14,
		1,14,1,15,1,15,1,16,1,16,1,16,1,17,1,17,1,18,1,18,1,19,1,19,1,20,1,20,
		1,21,1,21,1,21,1,22,1,22,1,22,1,23,1,23,1,23,1,24,1,24,1,25,1,25,1,26,
		1,26,1,27,1,27,1,27,1,28,1,28,1,28,1,29,1,29,1,29,1,30,1,30,1,30,1,30,
		1,30,1,31,1,31,1,31,1,31,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,33,1,33,
		1,33,1,33,1,33,1,33,1,33,1,34,1,34,1,34,1,34,1,34,1,35,1,35,1,35,1,35,
		1,35,1,35,1,35,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,37,1,37,1,37,1,37,
		1,37,1,38,1,38,1,38,1,38,1,38,1,38,1,38,1,38,1,39,1,39,1,40,1,40,1,40,
		1,40,1,41,1,41,1,41,1,42,1,42,1,42,1,42,1,42,1,42,1,43,1,43,1,43,1,43,
		1,43,1,43,1,43,1,44,1,44,1,44,1,44,1,44,1,45,1,45,1,45,1,45,1,45,1,46,
		1,46,1,46,1,46,1,46,1,46,1,47,1,47,1,47,5,47,328,8,47,10,47,12,47,331,
		9,47,3,47,333,8,47,1,48,1,48,1,48,5,48,338,8,48,10,48,12,48,341,9,48,3,
		48,343,8,48,1,48,1,48,4,48,347,8,48,11,48,12,48,348,1,49,4,49,352,8,49,
		11,49,12,49,353,1,49,5,49,357,8,49,10,49,12,49,360,9,49,1,50,1,50,4,50,
		364,8,50,11,50,12,50,365,1,50,5,50,369,8,50,10,50,12,50,372,9,50,1,51,
		1,51,5,51,376,8,51,10,51,12,51,379,9,51,1,51,1,51,1,51,5,51,384,8,51,10,
		51,12,51,387,9,51,1,51,3,51,390,8,51,1,52,4,52,393,8,52,11,52,12,52,394,
		1,52,1,52,1,53,1,53,1,53,3,53,402,8,53,1,53,1,53,1,54,1,54,1,54,1,54,5,
		54,410,8,54,10,54,12,54,413,9,54,1,54,1,54,1,55,1,55,1,55,1,55,5,55,421,
		8,55,10,55,12,55,424,9,55,1,55,1,55,1,55,1,55,1,55,1,56,1,56,1,56,1,56,
		1,57,1,57,1,57,3,57,438,8,57,1,58,1,58,1,59,1,59,1,59,3,59,445,8,59,1,
		60,1,60,1,61,1,61,1,61,1,62,1,62,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,
		63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,3,63,474,
		8,63,1,64,1,64,1,422,0,65,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,
		21,11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,
		45,23,47,24,49,25,51,26,53,27,55,28,57,29,59,30,61,31,63,32,65,33,67,34,
		69,35,71,36,73,37,75,38,77,39,79,40,81,41,83,42,85,43,87,44,89,45,91,46,
		93,47,95,48,97,49,99,50,101,51,103,52,105,53,107,54,109,55,111,56,113,
		57,115,0,117,0,119,0,121,0,123,0,125,0,127,0,129,0,1,0,8,3,0,65,90,95,
		95,97,122,4,0,48,57,65,90,95,95,97,122,2,0,9,9,32,32,2,0,10,10,13,13,6,
		0,10,10,13,13,34,34,92,92,133,133,8232,8233,6,0,10,10,13,13,39,39,92,92,
		133,133,8232,8233,10,0,34,34,39,39,48,48,92,92,97,98,102,102,110,110,114,
		114,116,116,118,118,3,0,48,57,65,70,97,102,489,0,1,1,0,0,0,0,3,1,0,0,0,
		0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,
		0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,
		27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,
		0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,
		0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,
		1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,
		0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,
		1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,
		0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,1,0,0,0,0,
		103,1,0,0,0,0,105,1,0,0,0,0,107,1,0,0,0,0,109,1,0,0,0,0,111,1,0,0,0,0,
		113,1,0,0,0,1,131,1,0,0,0,3,133,1,0,0,0,5,139,1,0,0,0,7,149,1,0,0,0,9,
		151,1,0,0,0,11,157,1,0,0,0,13,166,1,0,0,0,15,168,1,0,0,0,17,170,1,0,0,
		0,19,172,1,0,0,0,21,174,1,0,0,0,23,177,1,0,0,0,25,179,1,0,0,0,27,183,1,
		0,0,0,29,192,1,0,0,0,31,194,1,0,0,0,33,196,1,0,0,0,35,199,1,0,0,0,37,201,
		1,0,0,0,39,203,1,0,0,0,41,205,1,0,0,0,43,207,1,0,0,0,45,210,1,0,0,0,47,
		213,1,0,0,0,49,216,1,0,0,0,51,218,1,0,0,0,53,220,1,0,0,0,55,222,1,0,0,
		0,57,225,1,0,0,0,59,228,1,0,0,0,61,231,1,0,0,0,63,236,1,0,0,0,65,240,1,
		0,0,0,67,247,1,0,0,0,69,254,1,0,0,0,71,259,1,0,0,0,73,266,1,0,0,0,75,273,
		1,0,0,0,77,278,1,0,0,0,79,286,1,0,0,0,81,288,1,0,0,0,83,292,1,0,0,0,85,
		295,1,0,0,0,87,301,1,0,0,0,89,308,1,0,0,0,91,313,1,0,0,0,93,318,1,0,0,
		0,95,332,1,0,0,0,97,342,1,0,0,0,99,351,1,0,0,0,101,361,1,0,0,0,103,389,
		1,0,0,0,105,392,1,0,0,0,107,401,1,0,0,0,109,405,1,0,0,0,111,416,1,0,0,
		0,113,430,1,0,0,0,115,437,1,0,0,0,117,439,1,0,0,0,119,444,1,0,0,0,121,
		446,1,0,0,0,123,448,1,0,0,0,125,451,1,0,0,0,127,473,1,0,0,0,129,475,1,
		0,0,0,131,132,5,44,0,0,132,2,1,0,0,0,133,134,5,239,0,0,134,135,5,187,0,
		0,135,136,5,191,0,0,136,137,1,0,0,0,137,138,6,1,0,0,138,4,1,0,0,0,139,
		140,5,110,0,0,140,141,5,97,0,0,141,142,5,109,0,0,142,143,5,101,0,0,143,
		144,5,115,0,0,144,145,5,112,0,0,145,146,5,97,0,0,146,147,5,99,0,0,147,
		148,5,101,0,0,148,6,1,0,0,0,149,150,5,59,0,0,150,8,1,0,0,0,151,152,5,117,
		0,0,152,153,5,115,0,0,153,154,5,105,0,0,154,155,5,110,0,0,155,156,5,103,
		0,0,156,10,1,0,0,0,157,158,5,108,0,0,158,159,5,97,0,0,159,160,5,110,0,
		0,160,161,5,103,0,0,161,162,5,117,0,0,162,163,5,97,0,0,163,164,5,103,0,
		0,164,165,5,101,0,0,165,12,1,0,0,0,166,167,5,58,0,0,167,14,1,0,0,0,168,
		169,5,40,0,0,169,16,1,0,0,0,170,171,5,41,0,0,171,18,1,0,0,0,172,173,5,
		35,0,0,173,20,1,0,0,0,174,175,5,35,0,0,175,176,5,123,0,0,176,22,1,0,0,
		0,177,178,5,125,0,0,178,24,1,0,0,0,179,180,5,101,0,0,180,181,5,111,0,0,
		181,182,5,102,0,0,182,26,1,0,0,0,183,184,5,102,0,0,184,185,5,114,0,0,185,
		186,5,97,0,0,186,187,5,103,0,0,187,188,5,109,0,0,188,189,5,101,0,0,189,
		190,5,110,0,0,190,191,5,116,0,0,191,28,1,0,0,0,192,193,5,126,0,0,193,30,
		1,0,0,0,194,195,5,46,0,0,195,32,1,0,0,0,196,197,5,46,0,0,197,198,5,46,
		0,0,198,34,1,0,0,0,199,200,5,123,0,0,200,36,1,0,0,0,201,202,5,91,0,0,202,
		38,1,0,0,0,203,204,5,93,0,0,204,40,1,0,0,0,205,206,5,61,0,0,206,42,1,0,
		0,0,207,208,5,63,0,0,208,209,5,61,0,0,209,44,1,0,0,0,210,211,5,33,0,0,
		211,212,5,61,0,0,212,46,1,0,0,0,213,214,5,43,0,0,214,215,5,61,0,0,215,
		48,1,0,0,0,216,217,5,63,0,0,217,50,1,0,0,0,218,219,5,42,0,0,219,52,1,0,
		0,0,220,221,5,43,0,0,221,54,1,0,0,0,222,223,5,63,0,0,223,224,5,63,0,0,
		224,56,1,0,0,0,225,226,5,42,0,0,226,227,5,63,0,0,227,58,1,0,0,0,228,229,
		5,43,0,0,229,230,5,63,0,0,230,60,1,0,0,0,231,232,5,98,0,0,232,233,5,111,
		0,0,233,234,5,111,0,0,234,235,5,108,0,0,235,62,1,0,0,0,236,237,5,105,0,
		0,237,238,5,110,0,0,238,239,5,116,0,0,239,64,1,0,0,0,240,241,5,100,0,0,
		241,242,5,111,0,0,242,243,5,117,0,0,243,244,5,98,0,0,244,245,5,108,0,0,
		245,246,5,101,0,0,246,66,1,0,0,0,247,248,5,115,0,0,248,249,5,116,0,0,249,
		250,5,114,0,0,250,251,5,105,0,0,251,252,5,110,0,0,252,253,5,103,0,0,253,
		68,1,0,0,0,254,255,5,116,0,0,255,256,5,121,0,0,256,257,5,112,0,0,257,258,
		5,101,0,0,258,70,1,0,0,0,259,260,5,115,0,0,260,261,5,121,0,0,261,262,5,
		109,0,0,262,263,5,98,0,0,263,264,5,111,0,0,264,265,5,108,0,0,265,72,1,
		0,0,0,266,267,5,111,0,0,267,268,5,98,0,0,268,269,5,106,0,0,269,270,5,101,
		0,0,270,271,5,99,0,0,271,272,5,116,0,0,272,74,1,0,0,0,273,274,5,118,0,
		0,274,275,5,111,0,0,275,276,5,105,0,0,276,277,5,100,0,0,277,76,1,0,0,0,
		278,279,5,114,0,0,279,280,5,101,0,0,280,281,5,116,0,0,281,282,5,117,0,
		0,282,283,5,114,0,0,283,284,5,110,0,0,284,285,5,115,0,0,285,78,1,0,0,0,
		286,287,5,124,0,0,287,80,1,0,0,0,288,289,5,97,0,0,289,290,5,108,0,0,290,
		291,5,116,0,0,291,82,1,0,0,0,292,293,5,61,0,0,293,294,5,62,0,0,294,84,
		1,0,0,0,295,296,5,116,0,0,296,297,5,111,0,0,297,298,5,107,0,0,298,299,
		5,101,0,0,299,300,5,110,0,0,300,86,1,0,0,0,301,302,5,104,0,0,302,303,5,
		105,0,0,303,304,5,100,0,0,304,305,5,100,0,0,305,306,5,101,0,0,306,307,
		5,110,0,0,307,88,1,0,0,0,308,309,5,110,0,0,309,310,5,117,0,0,310,311,5,
		108,0,0,311,312,5,108,0,0,312,90,1,0,0,0,313,314,5,116,0,0,314,315,5,114,
		0,0,315,316,5,117,0,0,316,317,5,101,0,0,317,92,1,0,0,0,318,319,5,102,0,
		0,319,320,5,97,0,0,320,321,5,108,0,0,321,322,5,115,0,0,322,323,5,101,0,
		0,323,94,1,0,0,0,324,333,5,48,0,0,325,329,2,49,57,0,326,328,2,48,57,0,
		327,326,1,0,0,0,328,331,1,0,0,0,329,327,1,0,0,0,329,330,1,0,0,0,330,333,
		1,0,0,0,331,329,1,0,0,0,332,324,1,0,0,0,332,325,1,0,0,0,333,96,1,0,0,0,
		334,343,5,48,0,0,335,339,2,49,57,0,336,338,2,48,57,0,337,336,1,0,0,0,338,
		341,1,0,0,0,339,337,1,0,0,0,339,340,1,0,0,0,340,343,1,0,0,0,341,339,1,
		0,0,0,342,334,1,0,0,0,342,335,1,0,0,0,343,344,1,0,0,0,344,346,5,46,0,0,
		345,347,2,48,57,0,346,345,1,0,0,0,347,348,1,0,0,0,348,346,1,0,0,0,348,
		349,1,0,0,0,349,98,1,0,0,0,350,352,7,0,0,0,351,350,1,0,0,0,352,353,1,0,
		0,0,353,351,1,0,0,0,353,354,1,0,0,0,354,358,1,0,0,0,355,357,7,1,0,0,356,
		355,1,0,0,0,357,360,1,0,0,0,358,356,1,0,0,0,358,359,1,0,0,0,359,100,1,
		0,0,0,360,358,1,0,0,0,361,363,5,64,0,0,362,364,7,0,0,0,363,362,1,0,0,0,
		364,365,1,0,0,0,365,363,1,0,0,0,365,366,1,0,0,0,366,370,1,0,0,0,367,369,
		7,1,0,0,368,367,1,0,0,0,369,372,1,0,0,0,370,368,1,0,0,0,370,371,1,0,0,
		0,371,102,1,0,0,0,372,370,1,0,0,0,373,377,5,34,0,0,374,376,3,115,57,0,
		375,374,1,0,0,0,376,379,1,0,0,0,377,375,1,0,0,0,377,378,1,0,0,0,378,380,
		1,0,0,0,379,377,1,0,0,0,380,390,5,34,0,0,381,385,5,39,0,0,382,384,3,119,
		59,0,383,382,1,0,0,0,384,387,1,0,0,0,385,383,1,0,0,0,385,386,1,0,0,0,386,
		388,1,0,0,0,387,385,1,0,0,0,388,390,5,39,0,0,389,373,1,0,0,0,389,381,1,
		0,0,0,390,104,1,0,0,0,391,393,7,2,0,0,392,391,1,0,0,0,393,394,1,0,0,0,
		394,392,1,0,0,0,394,395,1,0,0,0,395,396,1,0,0,0,396,397,6,52,0,0,397,106,
		1,0,0,0,398,399,5,13,0,0,399,402,5,10,0,0,400,402,7,3,0,0,401,398,1,0,
		0,0,401,400,1,0,0,0,402,403,1,0,0,0,403,404,6,53,0,0,404,108,1,0,0,0,405,
		406,5,47,0,0,406,407,5,47,0,0,407,411,1,0,0,0,408,410,8,3,0,0,409,408,
		1,0,0,0,410,413,1,0,0,0,411,409,1,0,0,0,411,412,1,0,0,0,412,414,1,0,0,
		0,413,411,1,0,0,0,414,415,6,54,0,0,415,110,1,0,0,0,416,417,5,47,0,0,417,
		418,5,42,0,0,418,422,1,0,0,0,419,421,9,0,0,0,420,419,1,0,0,0,421,424,1,
		0,0,0,422,423,1,0,0,0,422,420,1,0,0,0,423,425,1,0,0,0,424,422,1,0,0,0,
		425,426,5,42,0,0,426,427,5,47,0,0,427,428,1,0,0,0,428,429,6,55,0,0,429,
		112,1,0,0,0,430,431,9,0,0,0,431,432,1,0,0,0,432,433,6,56,0,0,433,114,1,
		0,0,0,434,438,3,117,58,0,435,438,3,123,61,0,436,438,3,127,63,0,437,434,
		1,0,0,0,437,435,1,0,0,0,437,436,1,0,0,0,438,116,1,0,0,0,439,440,8,4,0,
		0,440,118,1,0,0,0,441,445,3,121,60,0,442,445,3,123,61,0,443,445,3,127,
		63,0,444,441,1,0,0,0,444,442,1,0,0,0,444,443,1,0,0,0,445,120,1,0,0,0,446,
		447,8,5,0,0,447,122,1,0,0,0,448,449,5,92,0,0,449,450,3,125,62,0,450,124,
		1,0,0,0,451,452,7,6,0,0,452,126,1,0,0,0,453,454,5,92,0,0,454,455,5,117,
		0,0,455,456,1,0,0,0,456,457,3,129,64,0,457,458,3,129,64,0,458,459,3,129,
		64,0,459,460,3,129,64,0,460,474,1,0,0,0,461,462,5,92,0,0,462,463,5,85,
		0,0,463,464,1,0,0,0,464,465,3,129,64,0,465,466,3,129,64,0,466,467,3,129,
		64,0,467,468,3,129,64,0,468,469,3,129,64,0,469,470,3,129,64,0,470,471,
		3,129,64,0,471,472,3,129,64,0,472,474,1,0,0,0,473,453,1,0,0,0,473,461,
		1,0,0,0,474,128,1,0,0,0,475,476,7,7,0,0,476,130,1,0,0,0,20,0,329,332,339,
		342,348,353,358,365,370,377,385,389,394,401,411,422,437,444,473,1,0,1,
		0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MetaDslx.Bootstrap.MetaCompiler.Compiler
