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
		LR_TSemicolon=7, LR_KUsing=8, LR_KAbstract=9, LR_KSymbol=10, LR_KPhase=11, 
		LR_TLParen=12, LR_TRParen=13, LR_KCached=14, LR_KObject=15, LR_KBool=16, 
		LR_KChar=17, LR_KString=18, LR_KByte=19, LR_KSbyte=20, LR_KShort=21, LR_KUshort=22, 
		LR_KInt=23, LR_KUint=24, LR_KLong=25, LR_KUlong=26, LR_KFloat=27, LR_KDouble=28, 
		LR_KDecimal=29, LR_KType=30, LR_KVoid=31, LR_TColon=32, LR_TLBrace=33, 
		LR_TRBrace=34, LR_KPlain=35, LR_KDerived=36, LR_KWeak=37, LR_TEq=38, LR_KIf=39, 
		LR_TQuestion=40, LR_TLBracket=41, LR_TRBracket=42, LR_TDot=43, LR_TInteger=44, 
		LR_TDecimal=45, LR_TIdentifier=46, LR_TVerbatimIdentifier=47, LR_TString=48, 
		LR_TWhitespace=49, LR_TLineEnd=50, LR_TSingleLineComment=51, LR_TMultiLineComment=52, 
		LR_TInvalidToken=53;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TComma", "LR_TUtf8Bom", "LR_KNamespace", 
		"LR_TSemicolon", "LR_KUsing", "LR_KAbstract", "LR_KSymbol", "LR_KPhase", 
		"LR_TLParen", "LR_TRParen", "LR_KCached", "LR_KObject", "LR_KBool", "LR_KChar", 
		"LR_KString", "LR_KByte", "LR_KSbyte", "LR_KShort", "LR_KUshort", "LR_KInt", 
		"LR_KUint", "LR_KLong", "LR_KUlong", "LR_KFloat", "LR_KDouble", "LR_KDecimal", 
		"LR_KType", "LR_KVoid", "LR_TColon", "LR_TLBrace", "LR_TRBrace", "LR_KPlain", 
		"LR_KDerived", "LR_KWeak", "LR_TEq", "LR_KIf", "LR_TQuestion", "LR_TLBracket", 
		"LR_TRBracket", "LR_TDot", "LR_TInteger", "LR_TDecimal", "LR_TIdentifier", 
		"LR_TVerbatimIdentifier", "LR_TString", "LR_TWhitespace", "LR_TLineEnd", 
		"LR_TSingleLineComment", "LR_TMultiLineComment", "LR_TInvalidToken", "FR_DoubleQuoteTextCharacter", 
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
		null, "'null'", "'true'", "'false'", "','", null, "'namespace'", "';'", 
		"'using'", "'abstract'", "'symbol'", "'phase'", "'('", "')'", "'cached'", 
		"'object'", "'bool'", "'char'", "'string'", "'byte'", "'sbyte'", "'short'", 
		"'ushort'", "'int'", "'uint'", "'long'", "'ulong'", "'float'", "'double'", 
		"'decimal'", "'type'", "'void'", "':'", "'{'", "'}'", "'plain'", "'derived'", 
		"'weak'", "'='", "'if'", "'?'", "'['", "']'", "'.'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TComma", "LR_TUtf8Bom", 
		"LR_KNamespace", "LR_TSemicolon", "LR_KUsing", "LR_KAbstract", "LR_KSymbol", 
		"LR_KPhase", "LR_TLParen", "LR_TRParen", "LR_KCached", "LR_KObject", "LR_KBool", 
		"LR_KChar", "LR_KString", "LR_KByte", "LR_KSbyte", "LR_KShort", "LR_KUshort", 
		"LR_KInt", "LR_KUint", "LR_KLong", "LR_KUlong", "LR_KFloat", "LR_KDouble", 
		"LR_KDecimal", "LR_KType", "LR_KVoid", "LR_TColon", "LR_TLBrace", "LR_TRBrace", 
		"LR_KPlain", "LR_KDerived", "LR_KWeak", "LR_TEq", "LR_KIf", "LR_TQuestion", 
		"LR_TLBracket", "LR_TRBracket", "LR_TDot", "LR_TInteger", "LR_TDecimal", 
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
		4,0,53,488,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,1,0,1,0,1,0,1,0,1,0,1,1,1,
		1,1,1,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,2,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,
		1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,
		7,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,10,
		1,10,1,10,1,10,1,10,1,10,1,11,1,11,1,12,1,12,1,13,1,13,1,13,1,13,1,13,
		1,13,1,13,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,15,1,15,1,15,1,15,1,15,
		1,16,1,16,1,16,1,16,1,16,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,18,1,18,
		1,18,1,18,1,18,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,20,
		1,20,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,22,1,22,1,22,1,22,1,23,1,23,
		1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,24,1,25,1,25,1,25,1,25,1,25,1,25,
		1,26,1,26,1,26,1,26,1,26,1,26,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,28,
		1,28,1,28,1,28,1,28,1,28,1,28,1,28,1,29,1,29,1,29,1,29,1,29,1,30,1,30,
		1,30,1,30,1,30,1,31,1,31,1,32,1,32,1,33,1,33,1,34,1,34,1,34,1,34,1,34,
		1,34,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,36,1,36,1,36,1,36,1,36,
		1,37,1,37,1,38,1,38,1,38,1,39,1,39,1,40,1,40,1,41,1,41,1,42,1,42,1,43,
		1,43,1,43,5,43,339,8,43,10,43,12,43,342,9,43,3,43,344,8,43,1,44,1,44,1,
		44,5,44,349,8,44,10,44,12,44,352,9,44,3,44,354,8,44,1,44,1,44,4,44,358,
		8,44,11,44,12,44,359,1,45,4,45,363,8,45,11,45,12,45,364,1,45,5,45,368,
		8,45,10,45,12,45,371,9,45,1,46,1,46,4,46,375,8,46,11,46,12,46,376,1,46,
		5,46,380,8,46,10,46,12,46,383,9,46,1,47,1,47,5,47,387,8,47,10,47,12,47,
		390,9,47,1,47,1,47,1,47,5,47,395,8,47,10,47,12,47,398,9,47,1,47,3,47,401,
		8,47,1,48,4,48,404,8,48,11,48,12,48,405,1,48,1,48,1,49,1,49,1,49,3,49,
		413,8,49,1,49,1,49,1,50,1,50,1,50,1,50,5,50,421,8,50,10,50,12,50,424,9,
		50,1,50,1,50,1,51,1,51,1,51,1,51,5,51,432,8,51,10,51,12,51,435,9,51,1,
		51,1,51,1,51,1,51,1,51,1,52,1,52,1,52,1,52,1,53,1,53,1,53,3,53,449,8,53,
		1,54,1,54,1,55,1,55,1,55,3,55,456,8,55,1,56,1,56,1,57,1,57,1,57,1,58,1,
		58,1,59,1,59,1,59,1,59,1,59,1,59,1,59,1,59,1,59,1,59,1,59,1,59,1,59,1,
		59,1,59,1,59,1,59,1,59,1,59,1,59,3,59,485,8,59,1,60,1,60,1,433,0,61,1,
		1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,
		15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,
		27,55,28,57,29,59,30,61,31,63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,
		39,79,40,81,41,83,42,85,43,87,44,89,45,91,46,93,47,95,48,97,49,99,50,101,
		51,103,52,105,53,107,0,109,0,111,0,113,0,115,0,117,0,119,0,121,0,1,0,8,
		3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,97,122,2,0,9,9,32,32,2,0,
		10,10,13,13,6,0,10,10,13,13,34,34,92,92,133,133,8232,8233,6,0,10,10,13,
		13,39,39,92,92,133,133,8232,8233,10,0,34,34,39,39,48,48,92,92,97,98,102,
		102,110,110,114,114,116,116,118,118,3,0,48,57,65,70,97,102,500,0,1,1,0,
		0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,
		1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,
		0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,
		1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,
		0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,
		1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,
		0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,
		1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,
		0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,
		1,0,0,0,0,103,1,0,0,0,0,105,1,0,0,0,1,123,1,0,0,0,3,128,1,0,0,0,5,133,
		1,0,0,0,7,139,1,0,0,0,9,141,1,0,0,0,11,147,1,0,0,0,13,157,1,0,0,0,15,159,
		1,0,0,0,17,165,1,0,0,0,19,174,1,0,0,0,21,181,1,0,0,0,23,187,1,0,0,0,25,
		189,1,0,0,0,27,191,1,0,0,0,29,198,1,0,0,0,31,205,1,0,0,0,33,210,1,0,0,
		0,35,215,1,0,0,0,37,222,1,0,0,0,39,227,1,0,0,0,41,233,1,0,0,0,43,239,1,
		0,0,0,45,246,1,0,0,0,47,250,1,0,0,0,49,255,1,0,0,0,51,260,1,0,0,0,53,266,
		1,0,0,0,55,272,1,0,0,0,57,279,1,0,0,0,59,287,1,0,0,0,61,292,1,0,0,0,63,
		297,1,0,0,0,65,299,1,0,0,0,67,301,1,0,0,0,69,303,1,0,0,0,71,309,1,0,0,
		0,73,317,1,0,0,0,75,322,1,0,0,0,77,324,1,0,0,0,79,327,1,0,0,0,81,329,1,
		0,0,0,83,331,1,0,0,0,85,333,1,0,0,0,87,343,1,0,0,0,89,353,1,0,0,0,91,362,
		1,0,0,0,93,372,1,0,0,0,95,400,1,0,0,0,97,403,1,0,0,0,99,412,1,0,0,0,101,
		416,1,0,0,0,103,427,1,0,0,0,105,441,1,0,0,0,107,448,1,0,0,0,109,450,1,
		0,0,0,111,455,1,0,0,0,113,457,1,0,0,0,115,459,1,0,0,0,117,462,1,0,0,0,
		119,484,1,0,0,0,121,486,1,0,0,0,123,124,5,110,0,0,124,125,5,117,0,0,125,
		126,5,108,0,0,126,127,5,108,0,0,127,2,1,0,0,0,128,129,5,116,0,0,129,130,
		5,114,0,0,130,131,5,117,0,0,131,132,5,101,0,0,132,4,1,0,0,0,133,134,5,
		102,0,0,134,135,5,97,0,0,135,136,5,108,0,0,136,137,5,115,0,0,137,138,5,
		101,0,0,138,6,1,0,0,0,139,140,5,44,0,0,140,8,1,0,0,0,141,142,5,239,0,0,
		142,143,5,187,0,0,143,144,5,191,0,0,144,145,1,0,0,0,145,146,6,4,0,0,146,
		10,1,0,0,0,147,148,5,110,0,0,148,149,5,97,0,0,149,150,5,109,0,0,150,151,
		5,101,0,0,151,152,5,115,0,0,152,153,5,112,0,0,153,154,5,97,0,0,154,155,
		5,99,0,0,155,156,5,101,0,0,156,12,1,0,0,0,157,158,5,59,0,0,158,14,1,0,
		0,0,159,160,5,117,0,0,160,161,5,115,0,0,161,162,5,105,0,0,162,163,5,110,
		0,0,163,164,5,103,0,0,164,16,1,0,0,0,165,166,5,97,0,0,166,167,5,98,0,0,
		167,168,5,115,0,0,168,169,5,116,0,0,169,170,5,114,0,0,170,171,5,97,0,0,
		171,172,5,99,0,0,172,173,5,116,0,0,173,18,1,0,0,0,174,175,5,115,0,0,175,
		176,5,121,0,0,176,177,5,109,0,0,177,178,5,98,0,0,178,179,5,111,0,0,179,
		180,5,108,0,0,180,20,1,0,0,0,181,182,5,112,0,0,182,183,5,104,0,0,183,184,
		5,97,0,0,184,185,5,115,0,0,185,186,5,101,0,0,186,22,1,0,0,0,187,188,5,
		40,0,0,188,24,1,0,0,0,189,190,5,41,0,0,190,26,1,0,0,0,191,192,5,99,0,0,
		192,193,5,97,0,0,193,194,5,99,0,0,194,195,5,104,0,0,195,196,5,101,0,0,
		196,197,5,100,0,0,197,28,1,0,0,0,198,199,5,111,0,0,199,200,5,98,0,0,200,
		201,5,106,0,0,201,202,5,101,0,0,202,203,5,99,0,0,203,204,5,116,0,0,204,
		30,1,0,0,0,205,206,5,98,0,0,206,207,5,111,0,0,207,208,5,111,0,0,208,209,
		5,108,0,0,209,32,1,0,0,0,210,211,5,99,0,0,211,212,5,104,0,0,212,213,5,
		97,0,0,213,214,5,114,0,0,214,34,1,0,0,0,215,216,5,115,0,0,216,217,5,116,
		0,0,217,218,5,114,0,0,218,219,5,105,0,0,219,220,5,110,0,0,220,221,5,103,
		0,0,221,36,1,0,0,0,222,223,5,98,0,0,223,224,5,121,0,0,224,225,5,116,0,
		0,225,226,5,101,0,0,226,38,1,0,0,0,227,228,5,115,0,0,228,229,5,98,0,0,
		229,230,5,121,0,0,230,231,5,116,0,0,231,232,5,101,0,0,232,40,1,0,0,0,233,
		234,5,115,0,0,234,235,5,104,0,0,235,236,5,111,0,0,236,237,5,114,0,0,237,
		238,5,116,0,0,238,42,1,0,0,0,239,240,5,117,0,0,240,241,5,115,0,0,241,242,
		5,104,0,0,242,243,5,111,0,0,243,244,5,114,0,0,244,245,5,116,0,0,245,44,
		1,0,0,0,246,247,5,105,0,0,247,248,5,110,0,0,248,249,5,116,0,0,249,46,1,
		0,0,0,250,251,5,117,0,0,251,252,5,105,0,0,252,253,5,110,0,0,253,254,5,
		116,0,0,254,48,1,0,0,0,255,256,5,108,0,0,256,257,5,111,0,0,257,258,5,110,
		0,0,258,259,5,103,0,0,259,50,1,0,0,0,260,261,5,117,0,0,261,262,5,108,0,
		0,262,263,5,111,0,0,263,264,5,110,0,0,264,265,5,103,0,0,265,52,1,0,0,0,
		266,267,5,102,0,0,267,268,5,108,0,0,268,269,5,111,0,0,269,270,5,97,0,0,
		270,271,5,116,0,0,271,54,1,0,0,0,272,273,5,100,0,0,273,274,5,111,0,0,274,
		275,5,117,0,0,275,276,5,98,0,0,276,277,5,108,0,0,277,278,5,101,0,0,278,
		56,1,0,0,0,279,280,5,100,0,0,280,281,5,101,0,0,281,282,5,99,0,0,282,283,
		5,105,0,0,283,284,5,109,0,0,284,285,5,97,0,0,285,286,5,108,0,0,286,58,
		1,0,0,0,287,288,5,116,0,0,288,289,5,121,0,0,289,290,5,112,0,0,290,291,
		5,101,0,0,291,60,1,0,0,0,292,293,5,118,0,0,293,294,5,111,0,0,294,295,5,
		105,0,0,295,296,5,100,0,0,296,62,1,0,0,0,297,298,5,58,0,0,298,64,1,0,0,
		0,299,300,5,123,0,0,300,66,1,0,0,0,301,302,5,125,0,0,302,68,1,0,0,0,303,
		304,5,112,0,0,304,305,5,108,0,0,305,306,5,97,0,0,306,307,5,105,0,0,307,
		308,5,110,0,0,308,70,1,0,0,0,309,310,5,100,0,0,310,311,5,101,0,0,311,312,
		5,114,0,0,312,313,5,105,0,0,313,314,5,118,0,0,314,315,5,101,0,0,315,316,
		5,100,0,0,316,72,1,0,0,0,317,318,5,119,0,0,318,319,5,101,0,0,319,320,5,
		97,0,0,320,321,5,107,0,0,321,74,1,0,0,0,322,323,5,61,0,0,323,76,1,0,0,
		0,324,325,5,105,0,0,325,326,5,102,0,0,326,78,1,0,0,0,327,328,5,63,0,0,
		328,80,1,0,0,0,329,330,5,91,0,0,330,82,1,0,0,0,331,332,5,93,0,0,332,84,
		1,0,0,0,333,334,5,46,0,0,334,86,1,0,0,0,335,344,5,48,0,0,336,340,2,49,
		57,0,337,339,2,48,57,0,338,337,1,0,0,0,339,342,1,0,0,0,340,338,1,0,0,0,
		340,341,1,0,0,0,341,344,1,0,0,0,342,340,1,0,0,0,343,335,1,0,0,0,343,336,
		1,0,0,0,344,88,1,0,0,0,345,354,5,48,0,0,346,350,2,49,57,0,347,349,2,48,
		57,0,348,347,1,0,0,0,349,352,1,0,0,0,350,348,1,0,0,0,350,351,1,0,0,0,351,
		354,1,0,0,0,352,350,1,0,0,0,353,345,1,0,0,0,353,346,1,0,0,0,354,355,1,
		0,0,0,355,357,5,46,0,0,356,358,2,48,57,0,357,356,1,0,0,0,358,359,1,0,0,
		0,359,357,1,0,0,0,359,360,1,0,0,0,360,90,1,0,0,0,361,363,7,0,0,0,362,361,
		1,0,0,0,363,364,1,0,0,0,364,362,1,0,0,0,364,365,1,0,0,0,365,369,1,0,0,
		0,366,368,7,1,0,0,367,366,1,0,0,0,368,371,1,0,0,0,369,367,1,0,0,0,369,
		370,1,0,0,0,370,92,1,0,0,0,371,369,1,0,0,0,372,374,5,64,0,0,373,375,7,
		0,0,0,374,373,1,0,0,0,375,376,1,0,0,0,376,374,1,0,0,0,376,377,1,0,0,0,
		377,381,1,0,0,0,378,380,7,1,0,0,379,378,1,0,0,0,380,383,1,0,0,0,381,379,
		1,0,0,0,381,382,1,0,0,0,382,94,1,0,0,0,383,381,1,0,0,0,384,388,5,34,0,
		0,385,387,3,107,53,0,386,385,1,0,0,0,387,390,1,0,0,0,388,386,1,0,0,0,388,
		389,1,0,0,0,389,391,1,0,0,0,390,388,1,0,0,0,391,401,5,34,0,0,392,396,5,
		39,0,0,393,395,3,111,55,0,394,393,1,0,0,0,395,398,1,0,0,0,396,394,1,0,
		0,0,396,397,1,0,0,0,397,399,1,0,0,0,398,396,1,0,0,0,399,401,5,39,0,0,400,
		384,1,0,0,0,400,392,1,0,0,0,401,96,1,0,0,0,402,404,7,2,0,0,403,402,1,0,
		0,0,404,405,1,0,0,0,405,403,1,0,0,0,405,406,1,0,0,0,406,407,1,0,0,0,407,
		408,6,48,0,0,408,98,1,0,0,0,409,410,5,13,0,0,410,413,5,10,0,0,411,413,
		7,3,0,0,412,409,1,0,0,0,412,411,1,0,0,0,413,414,1,0,0,0,414,415,6,49,0,
		0,415,100,1,0,0,0,416,417,5,47,0,0,417,418,5,47,0,0,418,422,1,0,0,0,419,
		421,8,3,0,0,420,419,1,0,0,0,421,424,1,0,0,0,422,420,1,0,0,0,422,423,1,
		0,0,0,423,425,1,0,0,0,424,422,1,0,0,0,425,426,6,50,0,0,426,102,1,0,0,0,
		427,428,5,47,0,0,428,429,5,42,0,0,429,433,1,0,0,0,430,432,9,0,0,0,431,
		430,1,0,0,0,432,435,1,0,0,0,433,434,1,0,0,0,433,431,1,0,0,0,434,436,1,
		0,0,0,435,433,1,0,0,0,436,437,5,42,0,0,437,438,5,47,0,0,438,439,1,0,0,
		0,439,440,6,51,0,0,440,104,1,0,0,0,441,442,9,0,0,0,442,443,1,0,0,0,443,
		444,6,52,0,0,444,106,1,0,0,0,445,449,3,109,54,0,446,449,3,115,57,0,447,
		449,3,119,59,0,448,445,1,0,0,0,448,446,1,0,0,0,448,447,1,0,0,0,449,108,
		1,0,0,0,450,451,8,4,0,0,451,110,1,0,0,0,452,456,3,113,56,0,453,456,3,115,
		57,0,454,456,3,119,59,0,455,452,1,0,0,0,455,453,1,0,0,0,455,454,1,0,0,
		0,456,112,1,0,0,0,457,458,8,5,0,0,458,114,1,0,0,0,459,460,5,92,0,0,460,
		461,3,117,58,0,461,116,1,0,0,0,462,463,7,6,0,0,463,118,1,0,0,0,464,465,
		5,92,0,0,465,466,5,117,0,0,466,467,1,0,0,0,467,468,3,121,60,0,468,469,
		3,121,60,0,469,470,3,121,60,0,470,471,3,121,60,0,471,485,1,0,0,0,472,473,
		5,92,0,0,473,474,5,85,0,0,474,475,1,0,0,0,475,476,3,121,60,0,476,477,3,
		121,60,0,477,478,3,121,60,0,478,479,3,121,60,0,479,480,3,121,60,0,480,
		481,3,121,60,0,481,482,3,121,60,0,482,483,3,121,60,0,483,485,1,0,0,0,484,
		464,1,0,0,0,484,472,1,0,0,0,485,120,1,0,0,0,486,487,7,7,0,0,487,122,1,
		0,0,0,20,0,340,343,350,353,359,364,369,376,381,388,396,400,405,412,422,
		433,448,455,484,1,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MetaDslx.Languages.MetaSymbols.Compiler
