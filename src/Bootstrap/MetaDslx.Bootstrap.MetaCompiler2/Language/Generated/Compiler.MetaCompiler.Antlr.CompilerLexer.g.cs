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

namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler {
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
		LR_TComma=1, LR_TUtf8Bom=2, LR_KNamespace=3, LR_TSemicolon=4, LR_KMetamodel=5, 
		LR_KLanguage=6, LR_TColon=7, LR_TLParen=8, LR_TRParen=9, LR_THash=10, 
		LR_THashLBrace=11, LR_TRBrace=12, LR_KEof=13, LR_KFragment=14, LR_TTilde=15, 
		LR_TDot=16, LR_TDotDot=17, LR_TLBrace=18, LR_TLBracket=19, LR_TRBracket=20, 
		LR_TEq=21, LR_TQuestionEq=22, LR_TExclEq=23, LR_TPlusEq=24, LR_TQuestion=25, 
		LR_TAsterisk=26, LR_TPlus=27, LR_TQuestionQuestion=28, LR_TAsteriskQuestion=29, 
		LR_TPlusQuestion=30, LR_KBool=31, LR_KInt=32, LR_KDouble=33, LR_KString=34, 
		LR_KType=35, LR_KSymbol=36, LR_KObject=37, LR_KVoid=38, LR_KUsing=39, 
		LR_KReturns=40, LR_TBar=41, LR_KAlt=42, LR_TEqGt=43, LR_KToken=44, LR_KHidden=45, 
		LR_KNull=46, LR_KTrue=47, LR_KFalse=48, LR_TInteger=49, LR_TDecimal=50, 
		LR_TIdentifier=51, LR_TVerbatimIdentifier=52, LR_TString=53, LR_TWhitespace=54, 
		LR_TLineEnd=55, LR_TSingleLineComment=56, LR_TMultiLineComment=57, LR_TInvalidToken=58;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LR_TComma", "LR_TUtf8Bom", "LR_KNamespace", "LR_TSemicolon", "LR_KMetamodel", 
		"LR_KLanguage", "LR_TColon", "LR_TLParen", "LR_TRParen", "LR_THash", "LR_THashLBrace", 
		"LR_TRBrace", "LR_KEof", "LR_KFragment", "LR_TTilde", "LR_TDot", "LR_TDotDot", 
		"LR_TLBrace", "LR_TLBracket", "LR_TRBracket", "LR_TEq", "LR_TQuestionEq", 
		"LR_TExclEq", "LR_TPlusEq", "LR_TQuestion", "LR_TAsterisk", "LR_TPlus", 
		"LR_TQuestionQuestion", "LR_TAsteriskQuestion", "LR_TPlusQuestion", "LR_KBool", 
		"LR_KInt", "LR_KDouble", "LR_KString", "LR_KType", "LR_KSymbol", "LR_KObject", 
		"LR_KVoid", "LR_KUsing", "LR_KReturns", "LR_TBar", "LR_KAlt", "LR_TEqGt", 
		"LR_KToken", "LR_KHidden", "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TInteger", 
		"LR_TDecimal", "LR_TIdentifier", "LR_TVerbatimIdentifier", "LR_TString", 
		"LR_TWhitespace", "LR_TLineEnd", "LR_TSingleLineComment", "LR_TMultiLineComment", 
		"LR_TInvalidToken", "FR_DoubleQuoteTextCharacter", "FR_DoubleQuoteTextSimple", 
		"FR_SingleQuoteTextCharacter", "FR_SingleQuoteTextSimple", "FR_CharacterEscapeSimple", 
		"FR_CharacterEscapeSimpleCharacter", "FR_CharacterEscapeUnicode", "FR_HexDigit"
	};


	public CompilerLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CompilerLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "','", null, "'namespace'", "';'", "'metamodel'", "'language'", 
		"':'", "'('", "')'", "'#'", "'#{'", "'}'", "'eof'", "'fragment'", "'~'", 
		"'.'", "'..'", "'{'", "'['", "']'", "'='", "'?='", "'!='", "'+='", "'?'", 
		"'*'", "'+'", "'??'", "'*?'", "'+?'", "'bool'", "'int'", "'double'", "'string'", 
		"'type'", "'symbol'", "'object'", "'void'", "'using'", "'returns'", "'|'", 
		"'alt'", "'=>'", "'token'", "'hidden'", "'null'", "'true'", "'false'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LR_TComma", "LR_TUtf8Bom", "LR_KNamespace", "LR_TSemicolon", "LR_KMetamodel", 
		"LR_KLanguage", "LR_TColon", "LR_TLParen", "LR_TRParen", "LR_THash", "LR_THashLBrace", 
		"LR_TRBrace", "LR_KEof", "LR_KFragment", "LR_TTilde", "LR_TDot", "LR_TDotDot", 
		"LR_TLBrace", "LR_TLBracket", "LR_TRBracket", "LR_TEq", "LR_TQuestionEq", 
		"LR_TExclEq", "LR_TPlusEq", "LR_TQuestion", "LR_TAsterisk", "LR_TPlus", 
		"LR_TQuestionQuestion", "LR_TAsteriskQuestion", "LR_TPlusQuestion", "LR_KBool", 
		"LR_KInt", "LR_KDouble", "LR_KString", "LR_KType", "LR_KSymbol", "LR_KObject", 
		"LR_KVoid", "LR_KUsing", "LR_KReturns", "LR_TBar", "LR_KAlt", "LR_TEqGt", 
		"LR_KToken", "LR_KHidden", "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TInteger", 
		"LR_TDecimal", "LR_TIdentifier", "LR_TVerbatimIdentifier", "LR_TString", 
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
		4,0,58,489,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,
		7,63,2,64,7,64,2,65,7,65,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,2,1,2,1,
		2,1,2,1,2,1,2,1,2,1,2,1,2,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,
		1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,7,1,7,1,8,1,8,1,9,1,
		9,1,10,1,10,1,10,1,11,1,11,1,12,1,12,1,12,1,12,1,13,1,13,1,13,1,13,1,13,
		1,13,1,13,1,13,1,13,1,14,1,14,1,15,1,15,1,16,1,16,1,16,1,17,1,17,1,18,
		1,18,1,19,1,19,1,20,1,20,1,21,1,21,1,21,1,22,1,22,1,22,1,23,1,23,1,23,
		1,24,1,24,1,25,1,25,1,26,1,26,1,27,1,27,1,27,1,28,1,28,1,28,1,29,1,29,
		1,29,1,30,1,30,1,30,1,30,1,30,1,31,1,31,1,31,1,31,1,32,1,32,1,32,1,32,
		1,32,1,32,1,32,1,33,1,33,1,33,1,33,1,33,1,33,1,33,1,34,1,34,1,34,1,34,
		1,34,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,36,1,36,1,36,1,36,1,36,1,36,
		1,36,1,37,1,37,1,37,1,37,1,37,1,38,1,38,1,38,1,38,1,38,1,38,1,39,1,39,
		1,39,1,39,1,39,1,39,1,39,1,39,1,40,1,40,1,41,1,41,1,41,1,41,1,42,1,42,
		1,42,1,43,1,43,1,43,1,43,1,43,1,43,1,44,1,44,1,44,1,44,1,44,1,44,1,44,
		1,45,1,45,1,45,1,45,1,45,1,46,1,46,1,46,1,46,1,46,1,47,1,47,1,47,1,47,
		1,47,1,47,1,48,1,48,1,48,5,48,340,8,48,10,48,12,48,343,9,48,3,48,345,8,
		48,1,49,1,49,1,49,5,49,350,8,49,10,49,12,49,353,9,49,3,49,355,8,49,1,49,
		1,49,4,49,359,8,49,11,49,12,49,360,1,50,4,50,364,8,50,11,50,12,50,365,
		1,50,5,50,369,8,50,10,50,12,50,372,9,50,1,51,1,51,4,51,376,8,51,11,51,
		12,51,377,1,51,5,51,381,8,51,10,51,12,51,384,9,51,1,52,1,52,5,52,388,8,
		52,10,52,12,52,391,9,52,1,52,1,52,1,52,5,52,396,8,52,10,52,12,52,399,9,
		52,1,52,3,52,402,8,52,1,53,4,53,405,8,53,11,53,12,53,406,1,53,1,53,1,54,
		1,54,1,54,3,54,414,8,54,1,54,1,54,1,55,1,55,1,55,1,55,5,55,422,8,55,10,
		55,12,55,425,9,55,1,55,1,55,1,56,1,56,1,56,1,56,5,56,433,8,56,10,56,12,
		56,436,9,56,1,56,1,56,1,56,1,56,1,56,1,57,1,57,1,57,1,57,1,58,1,58,1,58,
		3,58,450,8,58,1,59,1,59,1,60,1,60,1,60,3,60,457,8,60,1,61,1,61,1,62,1,
		62,1,62,1,63,1,63,1,64,1,64,1,64,1,64,1,64,1,64,1,64,1,64,1,64,1,64,1,
		64,1,64,1,64,1,64,1,64,1,64,1,64,1,64,1,64,1,64,3,64,486,8,64,1,65,1,65,
		1,434,0,66,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,
		13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,
		25,51,26,53,27,55,28,57,29,59,30,61,31,63,32,65,33,67,34,69,35,71,36,73,
		37,75,38,77,39,79,40,81,41,83,42,85,43,87,44,89,45,91,46,93,47,95,48,97,
		49,99,50,101,51,103,52,105,53,107,54,109,55,111,56,113,57,115,58,117,0,
		119,0,121,0,123,0,125,0,127,0,129,0,131,0,1,0,8,3,0,65,90,95,95,97,122,
		4,0,48,57,65,90,95,95,97,122,2,0,9,9,32,32,2,0,10,10,13,13,6,0,10,10,13,
		13,34,34,92,92,133,133,8232,8233,6,0,10,10,13,13,39,39,92,92,133,133,8232,
		8233,10,0,34,34,39,39,48,48,92,92,97,98,102,102,110,110,114,114,116,116,
		118,118,3,0,48,57,65,70,97,102,501,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,
		0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,
		0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,
		0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,
		1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,
		0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,
		1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,
		0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,
		1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,
		0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,1,0,0,0,0,103,1,0,0,0,0,
		105,1,0,0,0,0,107,1,0,0,0,0,109,1,0,0,0,0,111,1,0,0,0,0,113,1,0,0,0,0,
		115,1,0,0,0,1,133,1,0,0,0,3,135,1,0,0,0,5,141,1,0,0,0,7,151,1,0,0,0,9,
		153,1,0,0,0,11,163,1,0,0,0,13,172,1,0,0,0,15,174,1,0,0,0,17,176,1,0,0,
		0,19,178,1,0,0,0,21,180,1,0,0,0,23,183,1,0,0,0,25,185,1,0,0,0,27,189,1,
		0,0,0,29,198,1,0,0,0,31,200,1,0,0,0,33,202,1,0,0,0,35,205,1,0,0,0,37,207,
		1,0,0,0,39,209,1,0,0,0,41,211,1,0,0,0,43,213,1,0,0,0,45,216,1,0,0,0,47,
		219,1,0,0,0,49,222,1,0,0,0,51,224,1,0,0,0,53,226,1,0,0,0,55,228,1,0,0,
		0,57,231,1,0,0,0,59,234,1,0,0,0,61,237,1,0,0,0,63,242,1,0,0,0,65,246,1,
		0,0,0,67,253,1,0,0,0,69,260,1,0,0,0,71,265,1,0,0,0,73,272,1,0,0,0,75,279,
		1,0,0,0,77,284,1,0,0,0,79,290,1,0,0,0,81,298,1,0,0,0,83,300,1,0,0,0,85,
		304,1,0,0,0,87,307,1,0,0,0,89,313,1,0,0,0,91,320,1,0,0,0,93,325,1,0,0,
		0,95,330,1,0,0,0,97,344,1,0,0,0,99,354,1,0,0,0,101,363,1,0,0,0,103,373,
		1,0,0,0,105,401,1,0,0,0,107,404,1,0,0,0,109,413,1,0,0,0,111,417,1,0,0,
		0,113,428,1,0,0,0,115,442,1,0,0,0,117,449,1,0,0,0,119,451,1,0,0,0,121,
		456,1,0,0,0,123,458,1,0,0,0,125,460,1,0,0,0,127,463,1,0,0,0,129,485,1,
		0,0,0,131,487,1,0,0,0,133,134,5,44,0,0,134,2,1,0,0,0,135,136,5,239,0,0,
		136,137,5,187,0,0,137,138,5,191,0,0,138,139,1,0,0,0,139,140,6,1,0,0,140,
		4,1,0,0,0,141,142,5,110,0,0,142,143,5,97,0,0,143,144,5,109,0,0,144,145,
		5,101,0,0,145,146,5,115,0,0,146,147,5,112,0,0,147,148,5,97,0,0,148,149,
		5,99,0,0,149,150,5,101,0,0,150,6,1,0,0,0,151,152,5,59,0,0,152,8,1,0,0,
		0,153,154,5,109,0,0,154,155,5,101,0,0,155,156,5,116,0,0,156,157,5,97,0,
		0,157,158,5,109,0,0,158,159,5,111,0,0,159,160,5,100,0,0,160,161,5,101,
		0,0,161,162,5,108,0,0,162,10,1,0,0,0,163,164,5,108,0,0,164,165,5,97,0,
		0,165,166,5,110,0,0,166,167,5,103,0,0,167,168,5,117,0,0,168,169,5,97,0,
		0,169,170,5,103,0,0,170,171,5,101,0,0,171,12,1,0,0,0,172,173,5,58,0,0,
		173,14,1,0,0,0,174,175,5,40,0,0,175,16,1,0,0,0,176,177,5,41,0,0,177,18,
		1,0,0,0,178,179,5,35,0,0,179,20,1,0,0,0,180,181,5,35,0,0,181,182,5,123,
		0,0,182,22,1,0,0,0,183,184,5,125,0,0,184,24,1,0,0,0,185,186,5,101,0,0,
		186,187,5,111,0,0,187,188,5,102,0,0,188,26,1,0,0,0,189,190,5,102,0,0,190,
		191,5,114,0,0,191,192,5,97,0,0,192,193,5,103,0,0,193,194,5,109,0,0,194,
		195,5,101,0,0,195,196,5,110,0,0,196,197,5,116,0,0,197,28,1,0,0,0,198,199,
		5,126,0,0,199,30,1,0,0,0,200,201,5,46,0,0,201,32,1,0,0,0,202,203,5,46,
		0,0,203,204,5,46,0,0,204,34,1,0,0,0,205,206,5,123,0,0,206,36,1,0,0,0,207,
		208,5,91,0,0,208,38,1,0,0,0,209,210,5,93,0,0,210,40,1,0,0,0,211,212,5,
		61,0,0,212,42,1,0,0,0,213,214,5,63,0,0,214,215,5,61,0,0,215,44,1,0,0,0,
		216,217,5,33,0,0,217,218,5,61,0,0,218,46,1,0,0,0,219,220,5,43,0,0,220,
		221,5,61,0,0,221,48,1,0,0,0,222,223,5,63,0,0,223,50,1,0,0,0,224,225,5,
		42,0,0,225,52,1,0,0,0,226,227,5,43,0,0,227,54,1,0,0,0,228,229,5,63,0,0,
		229,230,5,63,0,0,230,56,1,0,0,0,231,232,5,42,0,0,232,233,5,63,0,0,233,
		58,1,0,0,0,234,235,5,43,0,0,235,236,5,63,0,0,236,60,1,0,0,0,237,238,5,
		98,0,0,238,239,5,111,0,0,239,240,5,111,0,0,240,241,5,108,0,0,241,62,1,
		0,0,0,242,243,5,105,0,0,243,244,5,110,0,0,244,245,5,116,0,0,245,64,1,0,
		0,0,246,247,5,100,0,0,247,248,5,111,0,0,248,249,5,117,0,0,249,250,5,98,
		0,0,250,251,5,108,0,0,251,252,5,101,0,0,252,66,1,0,0,0,253,254,5,115,0,
		0,254,255,5,116,0,0,255,256,5,114,0,0,256,257,5,105,0,0,257,258,5,110,
		0,0,258,259,5,103,0,0,259,68,1,0,0,0,260,261,5,116,0,0,261,262,5,121,0,
		0,262,263,5,112,0,0,263,264,5,101,0,0,264,70,1,0,0,0,265,266,5,115,0,0,
		266,267,5,121,0,0,267,268,5,109,0,0,268,269,5,98,0,0,269,270,5,111,0,0,
		270,271,5,108,0,0,271,72,1,0,0,0,272,273,5,111,0,0,273,274,5,98,0,0,274,
		275,5,106,0,0,275,276,5,101,0,0,276,277,5,99,0,0,277,278,5,116,0,0,278,
		74,1,0,0,0,279,280,5,118,0,0,280,281,5,111,0,0,281,282,5,105,0,0,282,283,
		5,100,0,0,283,76,1,0,0,0,284,285,5,117,0,0,285,286,5,115,0,0,286,287,5,
		105,0,0,287,288,5,110,0,0,288,289,5,103,0,0,289,78,1,0,0,0,290,291,5,114,
		0,0,291,292,5,101,0,0,292,293,5,116,0,0,293,294,5,117,0,0,294,295,5,114,
		0,0,295,296,5,110,0,0,296,297,5,115,0,0,297,80,1,0,0,0,298,299,5,124,0,
		0,299,82,1,0,0,0,300,301,5,97,0,0,301,302,5,108,0,0,302,303,5,116,0,0,
		303,84,1,0,0,0,304,305,5,61,0,0,305,306,5,62,0,0,306,86,1,0,0,0,307,308,
		5,116,0,0,308,309,5,111,0,0,309,310,5,107,0,0,310,311,5,101,0,0,311,312,
		5,110,0,0,312,88,1,0,0,0,313,314,5,104,0,0,314,315,5,105,0,0,315,316,5,
		100,0,0,316,317,5,100,0,0,317,318,5,101,0,0,318,319,5,110,0,0,319,90,1,
		0,0,0,320,321,5,110,0,0,321,322,5,117,0,0,322,323,5,108,0,0,323,324,5,
		108,0,0,324,92,1,0,0,0,325,326,5,116,0,0,326,327,5,114,0,0,327,328,5,117,
		0,0,328,329,5,101,0,0,329,94,1,0,0,0,330,331,5,102,0,0,331,332,5,97,0,
		0,332,333,5,108,0,0,333,334,5,115,0,0,334,335,5,101,0,0,335,96,1,0,0,0,
		336,345,5,48,0,0,337,341,2,49,57,0,338,340,2,48,57,0,339,338,1,0,0,0,340,
		343,1,0,0,0,341,339,1,0,0,0,341,342,1,0,0,0,342,345,1,0,0,0,343,341,1,
		0,0,0,344,336,1,0,0,0,344,337,1,0,0,0,345,98,1,0,0,0,346,355,5,48,0,0,
		347,351,2,49,57,0,348,350,2,48,57,0,349,348,1,0,0,0,350,353,1,0,0,0,351,
		349,1,0,0,0,351,352,1,0,0,0,352,355,1,0,0,0,353,351,1,0,0,0,354,346,1,
		0,0,0,354,347,1,0,0,0,355,356,1,0,0,0,356,358,5,46,0,0,357,359,2,48,57,
		0,358,357,1,0,0,0,359,360,1,0,0,0,360,358,1,0,0,0,360,361,1,0,0,0,361,
		100,1,0,0,0,362,364,7,0,0,0,363,362,1,0,0,0,364,365,1,0,0,0,365,363,1,
		0,0,0,365,366,1,0,0,0,366,370,1,0,0,0,367,369,7,1,0,0,368,367,1,0,0,0,
		369,372,1,0,0,0,370,368,1,0,0,0,370,371,1,0,0,0,371,102,1,0,0,0,372,370,
		1,0,0,0,373,375,5,64,0,0,374,376,7,0,0,0,375,374,1,0,0,0,376,377,1,0,0,
		0,377,375,1,0,0,0,377,378,1,0,0,0,378,382,1,0,0,0,379,381,7,1,0,0,380,
		379,1,0,0,0,381,384,1,0,0,0,382,380,1,0,0,0,382,383,1,0,0,0,383,104,1,
		0,0,0,384,382,1,0,0,0,385,389,5,34,0,0,386,388,3,117,58,0,387,386,1,0,
		0,0,388,391,1,0,0,0,389,387,1,0,0,0,389,390,1,0,0,0,390,392,1,0,0,0,391,
		389,1,0,0,0,392,402,5,34,0,0,393,397,5,39,0,0,394,396,3,121,60,0,395,394,
		1,0,0,0,396,399,1,0,0,0,397,395,1,0,0,0,397,398,1,0,0,0,398,400,1,0,0,
		0,399,397,1,0,0,0,400,402,5,39,0,0,401,385,1,0,0,0,401,393,1,0,0,0,402,
		106,1,0,0,0,403,405,7,2,0,0,404,403,1,0,0,0,405,406,1,0,0,0,406,404,1,
		0,0,0,406,407,1,0,0,0,407,408,1,0,0,0,408,409,6,53,0,0,409,108,1,0,0,0,
		410,411,5,13,0,0,411,414,5,10,0,0,412,414,7,3,0,0,413,410,1,0,0,0,413,
		412,1,0,0,0,414,415,1,0,0,0,415,416,6,54,0,0,416,110,1,0,0,0,417,418,5,
		47,0,0,418,419,5,47,0,0,419,423,1,0,0,0,420,422,8,3,0,0,421,420,1,0,0,
		0,422,425,1,0,0,0,423,421,1,0,0,0,423,424,1,0,0,0,424,426,1,0,0,0,425,
		423,1,0,0,0,426,427,6,55,0,0,427,112,1,0,0,0,428,429,5,47,0,0,429,430,
		5,42,0,0,430,434,1,0,0,0,431,433,9,0,0,0,432,431,1,0,0,0,433,436,1,0,0,
		0,434,435,1,0,0,0,434,432,1,0,0,0,435,437,1,0,0,0,436,434,1,0,0,0,437,
		438,5,42,0,0,438,439,5,47,0,0,439,440,1,0,0,0,440,441,6,56,0,0,441,114,
		1,0,0,0,442,443,9,0,0,0,443,444,1,0,0,0,444,445,6,57,0,0,445,116,1,0,0,
		0,446,450,3,119,59,0,447,450,3,125,62,0,448,450,3,129,64,0,449,446,1,0,
		0,0,449,447,1,0,0,0,449,448,1,0,0,0,450,118,1,0,0,0,451,452,8,4,0,0,452,
		120,1,0,0,0,453,457,3,123,61,0,454,457,3,125,62,0,455,457,3,129,64,0,456,
		453,1,0,0,0,456,454,1,0,0,0,456,455,1,0,0,0,457,122,1,0,0,0,458,459,8,
		5,0,0,459,124,1,0,0,0,460,461,5,92,0,0,461,462,3,127,63,0,462,126,1,0,
		0,0,463,464,7,6,0,0,464,128,1,0,0,0,465,466,5,92,0,0,466,467,5,117,0,0,
		467,468,1,0,0,0,468,469,3,131,65,0,469,470,3,131,65,0,470,471,3,131,65,
		0,471,472,3,131,65,0,472,486,1,0,0,0,473,474,5,92,0,0,474,475,5,85,0,0,
		475,476,1,0,0,0,476,477,3,131,65,0,477,478,3,131,65,0,478,479,3,131,65,
		0,479,480,3,131,65,0,480,481,3,131,65,0,481,482,3,131,65,0,482,483,3,131,
		65,0,483,484,3,131,65,0,484,486,1,0,0,0,485,465,1,0,0,0,485,473,1,0,0,
		0,486,130,1,0,0,0,487,488,7,7,0,0,488,132,1,0,0,0,20,0,341,344,351,354,
		360,365,370,377,382,389,397,401,406,413,423,434,449,456,485,1,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler
