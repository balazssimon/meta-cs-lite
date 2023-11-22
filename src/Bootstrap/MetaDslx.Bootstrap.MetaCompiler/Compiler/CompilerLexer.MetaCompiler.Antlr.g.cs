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
		LR_KLanguage=6, LR_KBlock=7, LR_KReturns=8, LR_TColon=9, LR_TBar=10, LR_KAlt=11, 
		LR_TEqGt=12, LR_THash=13, LR_THashLBrace=14, LR_TRBrace=15, LR_KEof=16, 
		LR_TLParen=17, LR_TRParen=18, LR_KToken=19, LR_KHidden=20, LR_KFragment=21, 
		LR_TTilde=22, LR_TDot=23, LR_TDotDot=24, LR_KNull=25, LR_KTrue=26, LR_KFalse=27, 
		LR_TLBrace=28, LR_TLBracket=29, LR_TRBracket=30, LR_TEq=31, LR_TQuestionEq=32, 
		LR_TExclEq=33, LR_TPlusEq=34, LR_TQuestion=35, LR_TAsterisk=36, LR_TPlus=37, 
		LR_TQuestionQuestion=38, LR_TAsteriskQuestion=39, LR_TPlusQuestion=40, 
		LR_TInteger=41, LR_TDecimal=42, LR_TPrimitiveType=43, LR_TIdentifier=44, 
		LR_TVerbatimIdentifier=45, LR_TString=46, LR_TWhitespace=47, LR_TLineEnd=48, 
		LR_TSingleLineComment=49, LR_TMultiLineComment=50, LR_TInvalidToken=51;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LR_TComma", "LR_Utf8Bom", "LR_KNamespace", "LR_TSemicolon", "LR_KUsing", 
		"LR_KLanguage", "LR_KBlock", "LR_KReturns", "LR_TColon", "LR_TBar", "LR_KAlt", 
		"LR_TEqGt", "LR_THash", "LR_THashLBrace", "LR_TRBrace", "LR_KEof", "LR_TLParen", 
		"LR_TRParen", "LR_KToken", "LR_KHidden", "LR_KFragment", "LR_TTilde", 
		"LR_TDot", "LR_TDotDot", "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TLBrace", 
		"LR_TLBracket", "LR_TRBracket", "LR_TEq", "LR_TQuestionEq", "LR_TExclEq", 
		"LR_TPlusEq", "LR_TQuestion", "LR_TAsterisk", "LR_TPlus", "LR_TQuestionQuestion", 
		"LR_TAsteriskQuestion", "LR_TPlusQuestion", "LR_TInteger", "LR_TDecimal", 
		"LR_TPrimitiveType", "LR_TIdentifier", "LR_TVerbatimIdentifier", "LR_TString", 
		"LR_DoubleQuoteTextCharacter", "LR_DoubleQuoteTextSimple", "LR_SingleQuoteTextCharacter", 
		"LR_SingleQuoteTextSimple", "LR_CharacterEscapeSimple", "LR_CharacterEscapeSimpleCharacter", 
		"LR_CharacterEscapeUnicode", "LR_HexDigit", "LR_TWhitespace", "LR_TLineEnd", 
		"LR_TSingleLineComment", "LR_TMultiLineComment", "LR_TInvalidToken"
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
		"'returns'", "':'", "'|'", "'alt'", "'=>'", "'#'", "'#{'", "'}'", "'eof'", 
		"'('", "')'", "'token'", "'hidden'", "'fragment'", "'~'", "'.'", "'..'", 
		"'null'", "'true'", "'false'", "'{'", "'['", "']'", "'='", "'?='", "'!='", 
		"'+='", "'?'", "'*'", "'+'", "'??'", "'*?'", "'+?'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LR_TComma", "LR_Utf8Bom", "LR_KNamespace", "LR_TSemicolon", "LR_KUsing", 
		"LR_KLanguage", "LR_KBlock", "LR_KReturns", "LR_TColon", "LR_TBar", "LR_KAlt", 
		"LR_TEqGt", "LR_THash", "LR_THashLBrace", "LR_TRBrace", "LR_KEof", "LR_TLParen", 
		"LR_TRParen", "LR_KToken", "LR_KHidden", "LR_KFragment", "LR_TTilde", 
		"LR_TDot", "LR_TDotDot", "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TLBrace", 
		"LR_TLBracket", "LR_TRBracket", "LR_TEq", "LR_TQuestionEq", "LR_TExclEq", 
		"LR_TPlusEq", "LR_TQuestion", "LR_TAsterisk", "LR_TPlus", "LR_TQuestionQuestion", 
		"LR_TAsteriskQuestion", "LR_TPlusQuestion", "LR_TInteger", "LR_TDecimal", 
		"LR_TPrimitiveType", "LR_TIdentifier", "LR_TVerbatimIdentifier", "LR_TString", 
		"LR_TWhitespace", "LR_TLineEnd", "LR_TSingleLineComment", "LR_TMultiLineComment", 
		"LR_TInvalidToken"
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
		4,0,51,457,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,2,1,2,1,
		2,1,2,1,2,1,2,1,2,1,2,1,2,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,5,
		1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,
		7,1,7,1,7,1,8,1,8,1,9,1,9,1,10,1,10,1,10,1,10,1,11,1,11,1,11,1,12,1,12,
		1,13,1,13,1,13,1,14,1,14,1,15,1,15,1,15,1,15,1,16,1,16,1,17,1,17,1,18,
		1,18,1,18,1,18,1,18,1,18,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,
		1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,21,1,21,1,22,1,22,1,23,1,23,1,23,
		1,24,1,24,1,24,1,24,1,24,1,25,1,25,1,25,1,25,1,25,1,26,1,26,1,26,1,26,
		1,26,1,26,1,27,1,27,1,28,1,28,1,29,1,29,1,30,1,30,1,31,1,31,1,31,1,32,
		1,32,1,32,1,33,1,33,1,33,1,34,1,34,1,35,1,35,1,36,1,36,1,37,1,37,1,37,
		1,38,1,38,1,38,1,39,1,39,1,39,1,40,1,40,1,40,5,40,275,8,40,10,40,12,40,
		278,9,40,3,40,280,8,40,1,41,1,41,1,41,5,41,285,8,41,10,41,12,41,288,9,
		41,3,41,290,8,41,1,41,1,41,4,41,294,8,41,11,41,12,41,295,1,42,1,42,1,42,
		1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,
		1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,
		1,42,1,42,3,42,331,8,42,1,43,4,43,334,8,43,11,43,12,43,335,1,43,5,43,339,
		8,43,10,43,12,43,342,9,43,1,44,1,44,4,44,346,8,44,11,44,12,44,347,1,44,
		5,44,351,8,44,10,44,12,44,354,9,44,1,45,1,45,5,45,358,8,45,10,45,12,45,
		361,9,45,1,45,1,45,1,45,5,45,366,8,45,10,45,12,45,369,9,45,1,45,3,45,372,
		8,45,1,46,1,46,1,46,3,46,377,8,46,1,47,1,47,1,48,1,48,1,48,3,48,384,8,
		48,1,49,1,49,1,50,1,50,1,50,1,51,1,51,1,52,1,52,1,52,1,52,1,52,1,52,1,
		52,1,52,1,52,1,52,1,52,1,52,1,52,1,52,1,52,1,52,1,52,1,52,1,52,1,52,3,
		52,413,8,52,1,53,1,53,1,54,4,54,418,8,54,11,54,12,54,419,1,54,1,54,1,55,
		1,55,1,55,3,55,427,8,55,1,55,1,55,1,56,1,56,1,56,1,56,5,56,435,8,56,10,
		56,12,56,438,9,56,1,56,1,56,1,57,1,57,1,57,1,57,5,57,446,8,57,10,57,12,
		57,449,9,57,1,57,1,57,1,57,1,57,1,57,1,58,1,58,1,447,0,59,1,1,3,2,5,3,
		7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,
		33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,
		57,29,59,30,61,31,63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,39,79,40,
		81,41,83,42,85,43,87,44,89,45,91,46,93,0,95,0,97,0,99,0,101,0,103,0,105,
		0,107,0,109,47,111,48,113,49,115,50,117,51,1,0,8,3,0,65,90,95,95,97,122,
		4,0,48,57,65,90,95,95,97,122,6,0,10,10,13,13,34,34,92,92,133,133,8232,
		8233,6,0,10,10,13,13,39,39,92,92,133,133,8232,8233,10,0,34,34,39,39,48,
		48,92,92,97,98,102,102,110,110,114,114,116,116,118,118,3,0,48,57,65,70,
		97,102,2,0,9,9,32,32,2,0,10,10,13,13,475,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,
		0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,
		17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,
		0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,
		0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,
		1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,
		0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,
		1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,
		0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,0,0,109,
		1,0,0,0,0,111,1,0,0,0,0,113,1,0,0,0,0,115,1,0,0,0,0,117,1,0,0,0,1,119,
		1,0,0,0,3,121,1,0,0,0,5,127,1,0,0,0,7,137,1,0,0,0,9,139,1,0,0,0,11,145,
		1,0,0,0,13,154,1,0,0,0,15,160,1,0,0,0,17,168,1,0,0,0,19,170,1,0,0,0,21,
		172,1,0,0,0,23,176,1,0,0,0,25,179,1,0,0,0,27,181,1,0,0,0,29,184,1,0,0,
		0,31,186,1,0,0,0,33,190,1,0,0,0,35,192,1,0,0,0,37,194,1,0,0,0,39,200,1,
		0,0,0,41,207,1,0,0,0,43,216,1,0,0,0,45,218,1,0,0,0,47,220,1,0,0,0,49,223,
		1,0,0,0,51,228,1,0,0,0,53,233,1,0,0,0,55,239,1,0,0,0,57,241,1,0,0,0,59,
		243,1,0,0,0,61,245,1,0,0,0,63,247,1,0,0,0,65,250,1,0,0,0,67,253,1,0,0,
		0,69,256,1,0,0,0,71,258,1,0,0,0,73,260,1,0,0,0,75,262,1,0,0,0,77,265,1,
		0,0,0,79,268,1,0,0,0,81,279,1,0,0,0,83,289,1,0,0,0,85,330,1,0,0,0,87,333,
		1,0,0,0,89,343,1,0,0,0,91,371,1,0,0,0,93,376,1,0,0,0,95,378,1,0,0,0,97,
		383,1,0,0,0,99,385,1,0,0,0,101,387,1,0,0,0,103,390,1,0,0,0,105,412,1,0,
		0,0,107,414,1,0,0,0,109,417,1,0,0,0,111,426,1,0,0,0,113,430,1,0,0,0,115,
		441,1,0,0,0,117,455,1,0,0,0,119,120,5,44,0,0,120,2,1,0,0,0,121,122,5,239,
		0,0,122,123,5,187,0,0,123,124,5,191,0,0,124,125,1,0,0,0,125,126,6,1,0,
		0,126,4,1,0,0,0,127,128,5,110,0,0,128,129,5,97,0,0,129,130,5,109,0,0,130,
		131,5,101,0,0,131,132,5,115,0,0,132,133,5,112,0,0,133,134,5,97,0,0,134,
		135,5,99,0,0,135,136,5,101,0,0,136,6,1,0,0,0,137,138,5,59,0,0,138,8,1,
		0,0,0,139,140,5,117,0,0,140,141,5,115,0,0,141,142,5,105,0,0,142,143,5,
		110,0,0,143,144,5,103,0,0,144,10,1,0,0,0,145,146,5,108,0,0,146,147,5,97,
		0,0,147,148,5,110,0,0,148,149,5,103,0,0,149,150,5,117,0,0,150,151,5,97,
		0,0,151,152,5,103,0,0,152,153,5,101,0,0,153,12,1,0,0,0,154,155,5,98,0,
		0,155,156,5,108,0,0,156,157,5,111,0,0,157,158,5,99,0,0,158,159,5,107,0,
		0,159,14,1,0,0,0,160,161,5,114,0,0,161,162,5,101,0,0,162,163,5,116,0,0,
		163,164,5,117,0,0,164,165,5,114,0,0,165,166,5,110,0,0,166,167,5,115,0,
		0,167,16,1,0,0,0,168,169,5,58,0,0,169,18,1,0,0,0,170,171,5,124,0,0,171,
		20,1,0,0,0,172,173,5,97,0,0,173,174,5,108,0,0,174,175,5,116,0,0,175,22,
		1,0,0,0,176,177,5,61,0,0,177,178,5,62,0,0,178,24,1,0,0,0,179,180,5,35,
		0,0,180,26,1,0,0,0,181,182,5,35,0,0,182,183,5,123,0,0,183,28,1,0,0,0,184,
		185,5,125,0,0,185,30,1,0,0,0,186,187,5,101,0,0,187,188,5,111,0,0,188,189,
		5,102,0,0,189,32,1,0,0,0,190,191,5,40,0,0,191,34,1,0,0,0,192,193,5,41,
		0,0,193,36,1,0,0,0,194,195,5,116,0,0,195,196,5,111,0,0,196,197,5,107,0,
		0,197,198,5,101,0,0,198,199,5,110,0,0,199,38,1,0,0,0,200,201,5,104,0,0,
		201,202,5,105,0,0,202,203,5,100,0,0,203,204,5,100,0,0,204,205,5,101,0,
		0,205,206,5,110,0,0,206,40,1,0,0,0,207,208,5,102,0,0,208,209,5,114,0,0,
		209,210,5,97,0,0,210,211,5,103,0,0,211,212,5,109,0,0,212,213,5,101,0,0,
		213,214,5,110,0,0,214,215,5,116,0,0,215,42,1,0,0,0,216,217,5,126,0,0,217,
		44,1,0,0,0,218,219,5,46,0,0,219,46,1,0,0,0,220,221,5,46,0,0,221,222,5,
		46,0,0,222,48,1,0,0,0,223,224,5,110,0,0,224,225,5,117,0,0,225,226,5,108,
		0,0,226,227,5,108,0,0,227,50,1,0,0,0,228,229,5,116,0,0,229,230,5,114,0,
		0,230,231,5,117,0,0,231,232,5,101,0,0,232,52,1,0,0,0,233,234,5,102,0,0,
		234,235,5,97,0,0,235,236,5,108,0,0,236,237,5,115,0,0,237,238,5,101,0,0,
		238,54,1,0,0,0,239,240,5,123,0,0,240,56,1,0,0,0,241,242,5,91,0,0,242,58,
		1,0,0,0,243,244,5,93,0,0,244,60,1,0,0,0,245,246,5,61,0,0,246,62,1,0,0,
		0,247,248,5,63,0,0,248,249,5,61,0,0,249,64,1,0,0,0,250,251,5,33,0,0,251,
		252,5,61,0,0,252,66,1,0,0,0,253,254,5,43,0,0,254,255,5,61,0,0,255,68,1,
		0,0,0,256,257,5,63,0,0,257,70,1,0,0,0,258,259,5,42,0,0,259,72,1,0,0,0,
		260,261,5,43,0,0,261,74,1,0,0,0,262,263,5,63,0,0,263,264,5,63,0,0,264,
		76,1,0,0,0,265,266,5,42,0,0,266,267,5,63,0,0,267,78,1,0,0,0,268,269,5,
		43,0,0,269,270,5,63,0,0,270,80,1,0,0,0,271,280,5,48,0,0,272,276,2,49,57,
		0,273,275,2,48,57,0,274,273,1,0,0,0,275,278,1,0,0,0,276,274,1,0,0,0,276,
		277,1,0,0,0,277,280,1,0,0,0,278,276,1,0,0,0,279,271,1,0,0,0,279,272,1,
		0,0,0,280,82,1,0,0,0,281,290,5,48,0,0,282,286,2,49,57,0,283,285,2,48,57,
		0,284,283,1,0,0,0,285,288,1,0,0,0,286,284,1,0,0,0,286,287,1,0,0,0,287,
		290,1,0,0,0,288,286,1,0,0,0,289,281,1,0,0,0,289,282,1,0,0,0,290,291,1,
		0,0,0,291,293,5,46,0,0,292,294,2,48,57,0,293,292,1,0,0,0,294,295,1,0,0,
		0,295,293,1,0,0,0,295,296,1,0,0,0,296,84,1,0,0,0,297,298,5,98,0,0,298,
		299,5,111,0,0,299,300,5,111,0,0,300,331,5,108,0,0,301,302,5,105,0,0,302,
		303,5,110,0,0,303,331,5,116,0,0,304,305,5,115,0,0,305,306,5,116,0,0,306,
		307,5,114,0,0,307,308,5,105,0,0,308,309,5,110,0,0,309,331,5,103,0,0,310,
		311,5,116,0,0,311,312,5,121,0,0,312,313,5,112,0,0,313,331,5,101,0,0,314,
		315,5,115,0,0,315,316,5,121,0,0,316,317,5,109,0,0,317,318,5,98,0,0,318,
		319,5,111,0,0,319,331,5,108,0,0,320,321,5,111,0,0,321,322,5,98,0,0,322,
		323,5,106,0,0,323,324,5,101,0,0,324,325,5,99,0,0,325,331,5,116,0,0,326,
		327,5,118,0,0,327,328,5,111,0,0,328,329,5,105,0,0,329,331,5,100,0,0,330,
		297,1,0,0,0,330,301,1,0,0,0,330,304,1,0,0,0,330,310,1,0,0,0,330,314,1,
		0,0,0,330,320,1,0,0,0,330,326,1,0,0,0,331,86,1,0,0,0,332,334,7,0,0,0,333,
		332,1,0,0,0,334,335,1,0,0,0,335,333,1,0,0,0,335,336,1,0,0,0,336,340,1,
		0,0,0,337,339,7,1,0,0,338,337,1,0,0,0,339,342,1,0,0,0,340,338,1,0,0,0,
		340,341,1,0,0,0,341,88,1,0,0,0,342,340,1,0,0,0,343,345,5,64,0,0,344,346,
		7,0,0,0,345,344,1,0,0,0,346,347,1,0,0,0,347,345,1,0,0,0,347,348,1,0,0,
		0,348,352,1,0,0,0,349,351,7,1,0,0,350,349,1,0,0,0,351,354,1,0,0,0,352,
		350,1,0,0,0,352,353,1,0,0,0,353,90,1,0,0,0,354,352,1,0,0,0,355,359,5,34,
		0,0,356,358,3,93,46,0,357,356,1,0,0,0,358,361,1,0,0,0,359,357,1,0,0,0,
		359,360,1,0,0,0,360,362,1,0,0,0,361,359,1,0,0,0,362,372,5,34,0,0,363,367,
		5,39,0,0,364,366,3,97,48,0,365,364,1,0,0,0,366,369,1,0,0,0,367,365,1,0,
		0,0,367,368,1,0,0,0,368,370,1,0,0,0,369,367,1,0,0,0,370,372,5,39,0,0,371,
		355,1,0,0,0,371,363,1,0,0,0,372,92,1,0,0,0,373,377,3,95,47,0,374,377,3,
		101,50,0,375,377,3,105,52,0,376,373,1,0,0,0,376,374,1,0,0,0,376,375,1,
		0,0,0,377,94,1,0,0,0,378,379,8,2,0,0,379,96,1,0,0,0,380,384,3,99,49,0,
		381,384,3,101,50,0,382,384,3,105,52,0,383,380,1,0,0,0,383,381,1,0,0,0,
		383,382,1,0,0,0,384,98,1,0,0,0,385,386,8,3,0,0,386,100,1,0,0,0,387,388,
		5,92,0,0,388,389,3,103,51,0,389,102,1,0,0,0,390,391,7,4,0,0,391,104,1,
		0,0,0,392,393,5,92,0,0,393,394,5,117,0,0,394,395,1,0,0,0,395,396,3,107,
		53,0,396,397,3,107,53,0,397,398,3,107,53,0,398,399,3,107,53,0,399,413,
		1,0,0,0,400,401,5,92,0,0,401,402,5,85,0,0,402,403,1,0,0,0,403,404,3,107,
		53,0,404,405,3,107,53,0,405,406,3,107,53,0,406,407,3,107,53,0,407,408,
		3,107,53,0,408,409,3,107,53,0,409,410,3,107,53,0,410,411,3,107,53,0,411,
		413,1,0,0,0,412,392,1,0,0,0,412,400,1,0,0,0,413,106,1,0,0,0,414,415,7,
		5,0,0,415,108,1,0,0,0,416,418,7,6,0,0,417,416,1,0,0,0,418,419,1,0,0,0,
		419,417,1,0,0,0,419,420,1,0,0,0,420,421,1,0,0,0,421,422,6,54,0,0,422,110,
		1,0,0,0,423,424,5,13,0,0,424,427,5,10,0,0,425,427,7,7,0,0,426,423,1,0,
		0,0,426,425,1,0,0,0,427,428,1,0,0,0,428,429,6,55,0,0,429,112,1,0,0,0,430,
		431,5,47,0,0,431,432,5,47,0,0,432,436,1,0,0,0,433,435,8,7,0,0,434,433,
		1,0,0,0,435,438,1,0,0,0,436,434,1,0,0,0,436,437,1,0,0,0,437,439,1,0,0,
		0,438,436,1,0,0,0,439,440,6,56,0,0,440,114,1,0,0,0,441,442,5,47,0,0,442,
		443,5,42,0,0,443,447,1,0,0,0,444,446,9,0,0,0,445,444,1,0,0,0,446,449,1,
		0,0,0,447,448,1,0,0,0,447,445,1,0,0,0,448,450,1,0,0,0,449,447,1,0,0,0,
		450,451,5,42,0,0,451,452,5,47,0,0,452,453,1,0,0,0,453,454,6,57,0,0,454,
		116,1,0,0,0,455,456,9,0,0,0,456,118,1,0,0,0,21,0,276,279,286,289,295,330,
		335,340,347,352,359,367,371,376,383,412,419,426,436,447,1,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MetaDslx.Bootstrap.MetaCompiler.Compiler
