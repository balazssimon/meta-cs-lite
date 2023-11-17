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
		LR_TComma=1, LR_Utf8Bom=2, LR_KNamespace=3, LR_TSemicolon=4, LR_KUsing=5, 
		LR_KLanguage=6, LR_KBlock=7, LR_KReturns=8, LR_TColon=9, LR_TBar=10, LR_TExclLBrace=11, 
		LR_TRBrace=12, LR_TEqGt=13, LR_THash=14, LR_THashLBrace=15, LR_KEof=16, 
		LR_TLParen=17, LR_TRParen=18, LR_KToken=19, LR_KHidden=20, LR_KFragment=21, 
		LR_TTilde=22, LR_TDot=23, LR_TDotDot=24, LR_KNull=25, LR_KTrue=26, LR_KFalse=27, 
		LR_TLBrace=28, LR_TLBracket=29, LR_TRBracket=30, LR_TEq=31, LR_TQuestionEq=32, 
		LR_TExclEq=33, LR_TPlusEq=34, LR_TQuestion=35, LR_TAsterisk=36, LR_TPlus=37, 
		LR_TQuestionQuestion=38, LR_TAsteriskQuestion=39, LR_TPlusQuestion=40, 
		LR_TInteger=41, LR_TDecimal=42, LR_TIdentifier=43, LR_TString=44, LR_TWhitespace=45, 
		LR_TLineEnd=46, LR_TSingleLineComment=47, LR_TMultiLineComment=48, LR_TInvalidToken=49;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LR_TComma", "LR_Utf8Bom", "LR_KNamespace", "LR_TSemicolon", "LR_KUsing", 
		"LR_KLanguage", "LR_KBlock", "LR_KReturns", "LR_TColon", "LR_TBar", "LR_TExclLBrace", 
		"LR_TRBrace", "LR_TEqGt", "LR_THash", "LR_THashLBrace", "LR_KEof", "LR_TLParen", 
		"LR_TRParen", "LR_KToken", "LR_KHidden", "LR_KFragment", "LR_TTilde", 
		"LR_TDot", "LR_TDotDot", "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TLBrace", 
		"LR_TLBracket", "LR_TRBracket", "LR_TEq", "LR_TQuestionEq", "LR_TExclEq", 
		"LR_TPlusEq", "LR_TQuestion", "LR_TAsterisk", "LR_TPlus", "LR_TQuestionQuestion", 
		"LR_TAsteriskQuestion", "LR_TPlusQuestion", "LR_TInteger", "LR_TDecimal", 
		"LR_TIdentifier", "LR_TString", "LR_DoubleQuoteTextCharacter", "LR_DoubleQuoteTextSimple", 
		"LR_SingleQuoteTextCharacter", "LR_SingleQuoteTextSimple", "LR_CharacterEscapeSimple", 
		"LR_CharacterEscapeSimpleCharacter", "LR_CharacterEscapeUnicode", "LR_HexDigit", 
		"LR_TWhitespace", "LR_TLineEnd", "LR_TSingleLineComment", "LR_TMultiLineComment", 
		"LR_TInvalidToken"
	};


	public CompilerLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CompilerLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "','", null, "'namespace'", "';'", "'using'", "'language'", "'block'", 
		"'returns'", "':'", "'|'", "'!{'", "'}'", "'=>'", "'#'", "'#{'", "'eof'", 
		"'('", "')'", "'token'", "'hidden'", "'fragment'", "'~'", "'.'", "'..'", 
		"'null'", "'true'", "'false'", "'{'", "'['", "']'", "'='", "'?='", "'!='", 
		"'+='", "'?'", "'*'", "'+'", "'??'", "'*?'", "'+?'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LR_TComma", "LR_Utf8Bom", "LR_KNamespace", "LR_TSemicolon", "LR_KUsing", 
		"LR_KLanguage", "LR_KBlock", "LR_KReturns", "LR_TColon", "LR_TBar", "LR_TExclLBrace", 
		"LR_TRBrace", "LR_TEqGt", "LR_THash", "LR_THashLBrace", "LR_KEof", "LR_TLParen", 
		"LR_TRParen", "LR_KToken", "LR_KHidden", "LR_KFragment", "LR_TTilde", 
		"LR_TDot", "LR_TDotDot", "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TLBrace", 
		"LR_TLBracket", "LR_TRBracket", "LR_TEq", "LR_TQuestionEq", "LR_TExclEq", 
		"LR_TPlusEq", "LR_TQuestion", "LR_TAsterisk", "LR_TPlus", "LR_TQuestionQuestion", 
		"LR_TAsteriskQuestion", "LR_TPlusQuestion", "LR_TInteger", "LR_TDecimal", 
		"LR_TIdentifier", "LR_TString", "LR_TWhitespace", "LR_TLineEnd", "LR_TSingleLineComment", 
		"LR_TMultiLineComment", "LR_TInvalidToken"
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
		4,0,49,405,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,
		2,1,2,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,
		1,5,1,6,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,
		9,1,9,1,10,1,10,1,10,1,11,1,11,1,12,1,12,1,12,1,13,1,13,1,14,1,14,1,14,
		1,15,1,15,1,15,1,15,1,16,1,16,1,17,1,17,1,18,1,18,1,18,1,18,1,18,1,18,
		1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,20,1,20,1,20,
		1,20,1,20,1,21,1,21,1,22,1,22,1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,24,
		1,25,1,25,1,25,1,25,1,25,1,26,1,26,1,26,1,26,1,26,1,26,1,27,1,27,1,28,
		1,28,1,29,1,29,1,30,1,30,1,31,1,31,1,31,1,32,1,32,1,32,1,33,1,33,1,33,
		1,34,1,34,1,35,1,35,1,36,1,36,1,37,1,37,1,37,1,38,1,38,1,38,1,39,1,39,
		1,39,1,40,1,40,1,40,5,40,270,8,40,10,40,12,40,273,9,40,3,40,275,8,40,1,
		41,1,41,1,41,5,41,280,8,41,10,41,12,41,283,9,41,3,41,285,8,41,1,41,1,41,
		4,41,289,8,41,11,41,12,41,290,1,42,4,42,294,8,42,11,42,12,42,295,1,42,
		5,42,299,8,42,10,42,12,42,302,9,42,1,43,1,43,5,43,306,8,43,10,43,12,43,
		309,9,43,1,43,1,43,1,43,5,43,314,8,43,10,43,12,43,317,9,43,1,43,3,43,320,
		8,43,1,44,1,44,1,44,3,44,325,8,44,1,45,1,45,1,46,1,46,1,46,3,46,332,8,
		46,1,47,1,47,1,48,1,48,1,48,1,49,1,49,1,50,1,50,1,50,1,50,1,50,1,50,1,
		50,1,50,1,50,1,50,1,50,1,50,1,50,1,50,1,50,1,50,1,50,1,50,1,50,1,50,3,
		50,361,8,50,1,51,1,51,1,52,4,52,366,8,52,11,52,12,52,367,1,52,1,52,1,53,
		1,53,1,53,3,53,375,8,53,1,53,1,53,1,54,1,54,1,54,1,54,5,54,383,8,54,10,
		54,12,54,386,9,54,1,54,1,54,1,55,1,55,1,55,1,55,5,55,394,8,55,10,55,12,
		55,397,9,55,1,55,1,55,1,55,1,55,1,55,1,56,1,56,1,395,0,57,1,1,3,2,5,3,
		7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,
		33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,
		57,29,59,30,61,31,63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,39,79,40,
		81,41,83,42,85,43,87,44,89,0,91,0,93,0,95,0,97,0,99,0,101,0,103,0,105,
		45,107,46,109,47,111,48,113,49,1,0,8,3,0,65,90,95,95,97,122,4,0,48,57,
		65,90,95,95,97,122,6,0,10,10,13,13,34,34,92,92,133,133,8232,8233,6,0,10,
		10,13,13,39,39,92,92,133,133,8232,8233,10,0,34,34,39,39,48,48,92,92,97,
		98,102,102,110,110,114,114,116,116,118,118,3,0,48,57,65,70,97,102,2,0,
		9,9,32,32,2,0,10,10,13,13,415,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,
		1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,
		0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,
		1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,
		0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,
		1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,
		0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,
		1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,
		0,0,85,1,0,0,0,0,87,1,0,0,0,0,105,1,0,0,0,0,107,1,0,0,0,0,109,1,0,0,0,
		0,111,1,0,0,0,0,113,1,0,0,0,1,115,1,0,0,0,3,117,1,0,0,0,5,123,1,0,0,0,
		7,133,1,0,0,0,9,135,1,0,0,0,11,141,1,0,0,0,13,150,1,0,0,0,15,156,1,0,0,
		0,17,164,1,0,0,0,19,166,1,0,0,0,21,168,1,0,0,0,23,171,1,0,0,0,25,173,1,
		0,0,0,27,176,1,0,0,0,29,178,1,0,0,0,31,181,1,0,0,0,33,185,1,0,0,0,35,187,
		1,0,0,0,37,189,1,0,0,0,39,195,1,0,0,0,41,202,1,0,0,0,43,211,1,0,0,0,45,
		213,1,0,0,0,47,215,1,0,0,0,49,218,1,0,0,0,51,223,1,0,0,0,53,228,1,0,0,
		0,55,234,1,0,0,0,57,236,1,0,0,0,59,238,1,0,0,0,61,240,1,0,0,0,63,242,1,
		0,0,0,65,245,1,0,0,0,67,248,1,0,0,0,69,251,1,0,0,0,71,253,1,0,0,0,73,255,
		1,0,0,0,75,257,1,0,0,0,77,260,1,0,0,0,79,263,1,0,0,0,81,274,1,0,0,0,83,
		284,1,0,0,0,85,293,1,0,0,0,87,319,1,0,0,0,89,324,1,0,0,0,91,326,1,0,0,
		0,93,331,1,0,0,0,95,333,1,0,0,0,97,335,1,0,0,0,99,338,1,0,0,0,101,360,
		1,0,0,0,103,362,1,0,0,0,105,365,1,0,0,0,107,374,1,0,0,0,109,378,1,0,0,
		0,111,389,1,0,0,0,113,403,1,0,0,0,115,116,5,44,0,0,116,2,1,0,0,0,117,118,
		5,239,0,0,118,119,5,187,0,0,119,120,5,191,0,0,120,121,1,0,0,0,121,122,
		6,1,0,0,122,4,1,0,0,0,123,124,5,110,0,0,124,125,5,97,0,0,125,126,5,109,
		0,0,126,127,5,101,0,0,127,128,5,115,0,0,128,129,5,112,0,0,129,130,5,97,
		0,0,130,131,5,99,0,0,131,132,5,101,0,0,132,6,1,0,0,0,133,134,5,59,0,0,
		134,8,1,0,0,0,135,136,5,117,0,0,136,137,5,115,0,0,137,138,5,105,0,0,138,
		139,5,110,0,0,139,140,5,103,0,0,140,10,1,0,0,0,141,142,5,108,0,0,142,143,
		5,97,0,0,143,144,5,110,0,0,144,145,5,103,0,0,145,146,5,117,0,0,146,147,
		5,97,0,0,147,148,5,103,0,0,148,149,5,101,0,0,149,12,1,0,0,0,150,151,5,
		98,0,0,151,152,5,108,0,0,152,153,5,111,0,0,153,154,5,99,0,0,154,155,5,
		107,0,0,155,14,1,0,0,0,156,157,5,114,0,0,157,158,5,101,0,0,158,159,5,116,
		0,0,159,160,5,117,0,0,160,161,5,114,0,0,161,162,5,110,0,0,162,163,5,115,
		0,0,163,16,1,0,0,0,164,165,5,58,0,0,165,18,1,0,0,0,166,167,5,124,0,0,167,
		20,1,0,0,0,168,169,5,33,0,0,169,170,5,123,0,0,170,22,1,0,0,0,171,172,5,
		125,0,0,172,24,1,0,0,0,173,174,5,61,0,0,174,175,5,62,0,0,175,26,1,0,0,
		0,176,177,5,35,0,0,177,28,1,0,0,0,178,179,5,35,0,0,179,180,5,123,0,0,180,
		30,1,0,0,0,181,182,5,101,0,0,182,183,5,111,0,0,183,184,5,102,0,0,184,32,
		1,0,0,0,185,186,5,40,0,0,186,34,1,0,0,0,187,188,5,41,0,0,188,36,1,0,0,
		0,189,190,5,116,0,0,190,191,5,111,0,0,191,192,5,107,0,0,192,193,5,101,
		0,0,193,194,5,110,0,0,194,38,1,0,0,0,195,196,5,104,0,0,196,197,5,105,0,
		0,197,198,5,100,0,0,198,199,5,100,0,0,199,200,5,101,0,0,200,201,5,110,
		0,0,201,40,1,0,0,0,202,203,5,102,0,0,203,204,5,114,0,0,204,205,5,97,0,
		0,205,206,5,103,0,0,206,207,5,109,0,0,207,208,5,101,0,0,208,209,5,110,
		0,0,209,210,5,116,0,0,210,42,1,0,0,0,211,212,5,126,0,0,212,44,1,0,0,0,
		213,214,5,46,0,0,214,46,1,0,0,0,215,216,5,46,0,0,216,217,5,46,0,0,217,
		48,1,0,0,0,218,219,5,110,0,0,219,220,5,117,0,0,220,221,5,108,0,0,221,222,
		5,108,0,0,222,50,1,0,0,0,223,224,5,116,0,0,224,225,5,114,0,0,225,226,5,
		117,0,0,226,227,5,101,0,0,227,52,1,0,0,0,228,229,5,102,0,0,229,230,5,97,
		0,0,230,231,5,108,0,0,231,232,5,115,0,0,232,233,5,101,0,0,233,54,1,0,0,
		0,234,235,5,123,0,0,235,56,1,0,0,0,236,237,5,91,0,0,237,58,1,0,0,0,238,
		239,5,93,0,0,239,60,1,0,0,0,240,241,5,61,0,0,241,62,1,0,0,0,242,243,5,
		63,0,0,243,244,5,61,0,0,244,64,1,0,0,0,245,246,5,33,0,0,246,247,5,61,0,
		0,247,66,1,0,0,0,248,249,5,43,0,0,249,250,5,61,0,0,250,68,1,0,0,0,251,
		252,5,63,0,0,252,70,1,0,0,0,253,254,5,42,0,0,254,72,1,0,0,0,255,256,5,
		43,0,0,256,74,1,0,0,0,257,258,5,63,0,0,258,259,5,63,0,0,259,76,1,0,0,0,
		260,261,5,42,0,0,261,262,5,63,0,0,262,78,1,0,0,0,263,264,5,43,0,0,264,
		265,5,63,0,0,265,80,1,0,0,0,266,275,5,48,0,0,267,271,2,49,57,0,268,270,
		2,48,57,0,269,268,1,0,0,0,270,273,1,0,0,0,271,269,1,0,0,0,271,272,1,0,
		0,0,272,275,1,0,0,0,273,271,1,0,0,0,274,266,1,0,0,0,274,267,1,0,0,0,275,
		82,1,0,0,0,276,285,5,48,0,0,277,281,2,49,57,0,278,280,2,48,57,0,279,278,
		1,0,0,0,280,283,1,0,0,0,281,279,1,0,0,0,281,282,1,0,0,0,282,285,1,0,0,
		0,283,281,1,0,0,0,284,276,1,0,0,0,284,277,1,0,0,0,285,286,1,0,0,0,286,
		288,5,46,0,0,287,289,2,48,57,0,288,287,1,0,0,0,289,290,1,0,0,0,290,288,
		1,0,0,0,290,291,1,0,0,0,291,84,1,0,0,0,292,294,7,0,0,0,293,292,1,0,0,0,
		294,295,1,0,0,0,295,293,1,0,0,0,295,296,1,0,0,0,296,300,1,0,0,0,297,299,
		7,1,0,0,298,297,1,0,0,0,299,302,1,0,0,0,300,298,1,0,0,0,300,301,1,0,0,
		0,301,86,1,0,0,0,302,300,1,0,0,0,303,307,5,34,0,0,304,306,3,89,44,0,305,
		304,1,0,0,0,306,309,1,0,0,0,307,305,1,0,0,0,307,308,1,0,0,0,308,310,1,
		0,0,0,309,307,1,0,0,0,310,320,5,34,0,0,311,315,5,39,0,0,312,314,3,93,46,
		0,313,312,1,0,0,0,314,317,1,0,0,0,315,313,1,0,0,0,315,316,1,0,0,0,316,
		318,1,0,0,0,317,315,1,0,0,0,318,320,5,39,0,0,319,303,1,0,0,0,319,311,1,
		0,0,0,320,88,1,0,0,0,321,325,3,91,45,0,322,325,3,97,48,0,323,325,3,101,
		50,0,324,321,1,0,0,0,324,322,1,0,0,0,324,323,1,0,0,0,325,90,1,0,0,0,326,
		327,8,2,0,0,327,92,1,0,0,0,328,332,3,95,47,0,329,332,3,97,48,0,330,332,
		3,101,50,0,331,328,1,0,0,0,331,329,1,0,0,0,331,330,1,0,0,0,332,94,1,0,
		0,0,333,334,8,3,0,0,334,96,1,0,0,0,335,336,5,92,0,0,336,337,3,99,49,0,
		337,98,1,0,0,0,338,339,7,4,0,0,339,100,1,0,0,0,340,341,5,92,0,0,341,342,
		5,117,0,0,342,343,1,0,0,0,343,344,3,103,51,0,344,345,3,103,51,0,345,346,
		3,103,51,0,346,347,3,103,51,0,347,361,1,0,0,0,348,349,5,92,0,0,349,350,
		5,85,0,0,350,351,1,0,0,0,351,352,3,103,51,0,352,353,3,103,51,0,353,354,
		3,103,51,0,354,355,3,103,51,0,355,356,3,103,51,0,356,357,3,103,51,0,357,
		358,3,103,51,0,358,359,3,103,51,0,359,361,1,0,0,0,360,340,1,0,0,0,360,
		348,1,0,0,0,361,102,1,0,0,0,362,363,7,5,0,0,363,104,1,0,0,0,364,366,7,
		6,0,0,365,364,1,0,0,0,366,367,1,0,0,0,367,365,1,0,0,0,367,368,1,0,0,0,
		368,369,1,0,0,0,369,370,6,52,0,0,370,106,1,0,0,0,371,372,5,13,0,0,372,
		375,5,10,0,0,373,375,7,7,0,0,374,371,1,0,0,0,374,373,1,0,0,0,375,376,1,
		0,0,0,376,377,6,53,0,0,377,108,1,0,0,0,378,379,5,47,0,0,379,380,5,47,0,
		0,380,384,1,0,0,0,381,383,8,7,0,0,382,381,1,0,0,0,383,386,1,0,0,0,384,
		382,1,0,0,0,384,385,1,0,0,0,385,387,1,0,0,0,386,384,1,0,0,0,387,388,6,
		54,0,0,388,110,1,0,0,0,389,390,5,47,0,0,390,391,5,42,0,0,391,395,1,0,0,
		0,392,394,9,0,0,0,393,392,1,0,0,0,394,397,1,0,0,0,395,396,1,0,0,0,395,
		393,1,0,0,0,396,398,1,0,0,0,397,395,1,0,0,0,398,399,5,42,0,0,399,400,5,
		47,0,0,400,401,1,0,0,0,401,402,6,55,0,0,402,112,1,0,0,0,403,404,9,0,0,
		0,404,114,1,0,0,0,18,0,271,274,281,284,290,295,300,307,315,319,324,331,
		360,367,374,384,395,1,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MetaDslx.Bootstrap.MetaCompiler.Compiler
