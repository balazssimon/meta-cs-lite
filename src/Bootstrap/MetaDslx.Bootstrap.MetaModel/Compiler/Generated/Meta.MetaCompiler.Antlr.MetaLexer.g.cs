//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from MetaLexer.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MetaDslx.Bootstrap.MetaModel.Compiler {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public partial class MetaLexer : global::MetaDslx.CodeAnalysis.Parsers.Antlr.AntlrLexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LR_KNull=1, LR_KTrue=2, LR_KFalse=3, LR_TComma=4, LR_TUtf8Bom=5, LR_KNamespace=6, 
		LR_TSemicolon=7, LR_KUsing=8, LR_KMetamodel=9, LR_KConst=10, LR_KEnum=11, 
		LR_KAbstract=12, LR_KClass=13, LR_TLParen=14, LR_TRParen=15, LR_KObject=16, 
		LR_KBool=17, LR_KChar=18, LR_KString=19, LR_KByte=20, LR_KSbyte=21, LR_KShort=22, 
		LR_KUshort=23, LR_KInt=24, LR_KUint=25, LR_KLong=26, LR_KUlong=27, LR_KFloat=28, 
		LR_KDouble=29, LR_KDecimal=30, LR_KType=31, LR_KSymbol=32, LR_KVoid=33, 
		LR_TEq=34, LR_TLBrace=35, LR_TRBrace=36, LR_TDollar=37, LR_TColon=38, 
		LR_KContains=39, LR_KDerived=40, LR_KUnion=41, LR_KReadonly=42, LR_KOpposite=43, 
		LR_KSubsets=44, LR_KRedefines=45, LR_TQuestion=46, LR_TLBracket=47, LR_TRBracket=48, 
		LR_TDot=49, LR_TInteger=50, LR_TDecimal=51, LR_TIdentifier=52, LR_TVerbatimIdentifier=53, 
		LR_TString=54, LR_TWhitespace=55, LR_TLineEnd=56, LR_TSingleLineComment=57, 
		LR_TMultiLineComment=58, LR_TInvalidToken=59;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TComma", "LR_TUtf8Bom", "LR_KNamespace", 
		"LR_TSemicolon", "LR_KUsing", "LR_KMetamodel", "LR_KConst", "LR_KEnum", 
		"LR_KAbstract", "LR_KClass", "LR_TLParen", "LR_TRParen", "LR_KObject", 
		"LR_KBool", "LR_KChar", "LR_KString", "LR_KByte", "LR_KSbyte", "LR_KShort", 
		"LR_KUshort", "LR_KInt", "LR_KUint", "LR_KLong", "LR_KUlong", "LR_KFloat", 
		"LR_KDouble", "LR_KDecimal", "LR_KType", "LR_KSymbol", "LR_KVoid", "LR_TEq", 
		"LR_TLBrace", "LR_TRBrace", "LR_TDollar", "LR_TColon", "LR_KContains", 
		"LR_KDerived", "LR_KUnion", "LR_KReadonly", "LR_KOpposite", "LR_KSubsets", 
		"LR_KRedefines", "LR_TQuestion", "LR_TLBracket", "LR_TRBracket", "LR_TDot", 
		"LR_TInteger", "LR_TDecimal", "LR_TIdentifier", "LR_TVerbatimIdentifier", 
		"LR_TString", "LR_TWhitespace", "LR_TLineEnd", "LR_TSingleLineComment", 
		"LR_TMultiLineComment", "LR_TInvalidToken", "FR_DoubleQuoteTextCharacter", 
		"FR_DoubleQuoteTextSimple", "FR_SingleQuoteTextCharacter", "FR_SingleQuoteTextSimple", 
		"FR_CharacterEscapeSimple", "FR_CharacterEscapeSimpleCharacter", "FR_CharacterEscapeUnicode", 
		"FR_HexDigit"
	};


	public MetaLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MetaLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'null'", "'true'", "'false'", "','", null, "'namespace'", "';'", 
		"'using'", "'metamodel'", "'const'", "'enum'", "'abstract'", "'class'", 
		"'('", "')'", "'object'", "'bool'", "'char'", "'string'", "'byte'", "'sbyte'", 
		"'short'", "'ushort'", "'int'", "'uint'", "'long'", "'ulong'", "'float'", 
		"'double'", "'decimal'", "'type'", "'symbol'", "'void'", "'='", "'{'", 
		"'}'", "'$'", "':'", "'contains'", "'derived'", "'union'", "'readonly'", 
		"'opposite'", "'subsets'", "'redefines'", "'?'", "'['", "']'", "'.'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TComma", "LR_TUtf8Bom", 
		"LR_KNamespace", "LR_TSemicolon", "LR_KUsing", "LR_KMetamodel", "LR_KConst", 
		"LR_KEnum", "LR_KAbstract", "LR_KClass", "LR_TLParen", "LR_TRParen", "LR_KObject", 
		"LR_KBool", "LR_KChar", "LR_KString", "LR_KByte", "LR_KSbyte", "LR_KShort", 
		"LR_KUshort", "LR_KInt", "LR_KUint", "LR_KLong", "LR_KUlong", "LR_KFloat", 
		"LR_KDouble", "LR_KDecimal", "LR_KType", "LR_KSymbol", "LR_KVoid", "LR_TEq", 
		"LR_TLBrace", "LR_TRBrace", "LR_TDollar", "LR_TColon", "LR_KContains", 
		"LR_KDerived", "LR_KUnion", "LR_KReadonly", "LR_KOpposite", "LR_KSubsets", 
		"LR_KRedefines", "LR_TQuestion", "LR_TLBracket", "LR_TRBracket", "LR_TDot", 
		"LR_TInteger", "LR_TDecimal", "LR_TIdentifier", "LR_TVerbatimIdentifier", 
		"LR_TString", "LR_TWhitespace", "LR_TLineEnd", "LR_TSingleLineComment", 
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

	public override string GrammarFileName { get { return "MetaLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MetaLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,59,553,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,
		7,63,2,64,7,64,2,65,7,65,2,66,7,66,1,0,1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,
		1,1,1,2,1,2,1,2,1,2,1,2,1,2,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,
		5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,
		1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,10,1,10,1,10,
		1,10,1,10,1,11,1,11,1,11,1,11,1,11,1,11,1,11,1,11,1,11,1,12,1,12,1,12,
		1,12,1,12,1,12,1,13,1,13,1,14,1,14,1,15,1,15,1,15,1,15,1,15,1,15,1,15,
		1,16,1,16,1,16,1,16,1,16,1,17,1,17,1,17,1,17,1,17,1,18,1,18,1,18,1,18,
		1,18,1,18,1,18,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,20,1,20,
		1,21,1,21,1,21,1,21,1,21,1,21,1,22,1,22,1,22,1,22,1,22,1,22,1,22,1,23,
		1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,24,1,25,1,25,1,25,1,25,1,25,1,26,
		1,26,1,26,1,26,1,26,1,26,1,27,1,27,1,27,1,27,1,27,1,27,1,28,1,28,1,28,
		1,28,1,28,1,28,1,28,1,29,1,29,1,29,1,29,1,29,1,29,1,29,1,29,1,30,1,30,
		1,30,1,30,1,30,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,32,1,32,1,32,1,32,
		1,32,1,33,1,33,1,34,1,34,1,35,1,35,1,36,1,36,1,37,1,37,1,38,1,38,1,38,
		1,38,1,38,1,38,1,38,1,38,1,38,1,39,1,39,1,39,1,39,1,39,1,39,1,39,1,39,
		1,40,1,40,1,40,1,40,1,40,1,40,1,41,1,41,1,41,1,41,1,41,1,41,1,41,1,41,
		1,41,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,43,1,43,1,43,1,43,
		1,43,1,43,1,43,1,43,1,44,1,44,1,44,1,44,1,44,1,44,1,44,1,44,1,44,1,44,
		1,45,1,45,1,46,1,46,1,47,1,47,1,48,1,48,1,49,1,49,1,49,5,49,404,8,49,10,
		49,12,49,407,9,49,3,49,409,8,49,1,50,1,50,1,50,5,50,414,8,50,10,50,12,
		50,417,9,50,3,50,419,8,50,1,50,1,50,4,50,423,8,50,11,50,12,50,424,1,51,
		4,51,428,8,51,11,51,12,51,429,1,51,5,51,433,8,51,10,51,12,51,436,9,51,
		1,52,1,52,4,52,440,8,52,11,52,12,52,441,1,52,5,52,445,8,52,10,52,12,52,
		448,9,52,1,53,1,53,5,53,452,8,53,10,53,12,53,455,9,53,1,53,1,53,1,53,5,
		53,460,8,53,10,53,12,53,463,9,53,1,53,3,53,466,8,53,1,54,4,54,469,8,54,
		11,54,12,54,470,1,54,1,54,1,55,1,55,1,55,3,55,478,8,55,1,55,1,55,1,56,
		1,56,1,56,1,56,5,56,486,8,56,10,56,12,56,489,9,56,1,56,1,56,1,57,1,57,
		1,57,1,57,5,57,497,8,57,10,57,12,57,500,9,57,1,57,1,57,1,57,1,57,1,57,
		1,58,1,58,1,58,1,58,1,59,1,59,1,59,3,59,514,8,59,1,60,1,60,1,61,1,61,1,
		61,3,61,521,8,61,1,62,1,62,1,63,1,63,1,63,1,64,1,64,1,65,1,65,1,65,1,65,
		1,65,1,65,1,65,1,65,1,65,1,65,1,65,1,65,1,65,1,65,1,65,1,65,1,65,1,65,
		1,65,1,65,3,65,550,8,65,1,66,1,66,1,498,0,67,1,1,3,2,5,3,7,4,9,5,11,6,
		13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,
		19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,57,29,59,30,61,
		31,63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,39,79,40,81,41,83,42,85,
		43,87,44,89,45,91,46,93,47,95,48,97,49,99,50,101,51,103,52,105,53,107,
		54,109,55,111,56,113,57,115,58,117,59,119,0,121,0,123,0,125,0,127,0,129,
		0,131,0,133,0,1,0,8,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,97,122,
		2,0,9,9,32,32,2,0,10,10,13,13,6,0,10,10,13,13,34,34,92,92,133,133,8232,
		8233,6,0,10,10,13,13,39,39,92,92,133,133,8232,8233,10,0,34,34,39,39,48,
		48,92,92,97,98,102,102,110,110,114,114,116,116,118,118,3,0,48,57,65,70,
		97,102,565,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,
		0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,
		1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,
		0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,
		1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,
		0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,
		1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,
		0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,
		1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,1,0,0,
		0,0,99,1,0,0,0,0,101,1,0,0,0,0,103,1,0,0,0,0,105,1,0,0,0,0,107,1,0,0,0,
		0,109,1,0,0,0,0,111,1,0,0,0,0,113,1,0,0,0,0,115,1,0,0,0,0,117,1,0,0,0,
		1,135,1,0,0,0,3,140,1,0,0,0,5,145,1,0,0,0,7,151,1,0,0,0,9,153,1,0,0,0,
		11,159,1,0,0,0,13,169,1,0,0,0,15,171,1,0,0,0,17,177,1,0,0,0,19,187,1,0,
		0,0,21,193,1,0,0,0,23,198,1,0,0,0,25,207,1,0,0,0,27,213,1,0,0,0,29,215,
		1,0,0,0,31,217,1,0,0,0,33,224,1,0,0,0,35,229,1,0,0,0,37,234,1,0,0,0,39,
		241,1,0,0,0,41,246,1,0,0,0,43,252,1,0,0,0,45,258,1,0,0,0,47,265,1,0,0,
		0,49,269,1,0,0,0,51,274,1,0,0,0,53,279,1,0,0,0,55,285,1,0,0,0,57,291,1,
		0,0,0,59,298,1,0,0,0,61,306,1,0,0,0,63,311,1,0,0,0,65,318,1,0,0,0,67,323,
		1,0,0,0,69,325,1,0,0,0,71,327,1,0,0,0,73,329,1,0,0,0,75,331,1,0,0,0,77,
		333,1,0,0,0,79,342,1,0,0,0,81,350,1,0,0,0,83,356,1,0,0,0,85,365,1,0,0,
		0,87,374,1,0,0,0,89,382,1,0,0,0,91,392,1,0,0,0,93,394,1,0,0,0,95,396,1,
		0,0,0,97,398,1,0,0,0,99,408,1,0,0,0,101,418,1,0,0,0,103,427,1,0,0,0,105,
		437,1,0,0,0,107,465,1,0,0,0,109,468,1,0,0,0,111,477,1,0,0,0,113,481,1,
		0,0,0,115,492,1,0,0,0,117,506,1,0,0,0,119,513,1,0,0,0,121,515,1,0,0,0,
		123,520,1,0,0,0,125,522,1,0,0,0,127,524,1,0,0,0,129,527,1,0,0,0,131,549,
		1,0,0,0,133,551,1,0,0,0,135,136,5,110,0,0,136,137,5,117,0,0,137,138,5,
		108,0,0,138,139,5,108,0,0,139,2,1,0,0,0,140,141,5,116,0,0,141,142,5,114,
		0,0,142,143,5,117,0,0,143,144,5,101,0,0,144,4,1,0,0,0,145,146,5,102,0,
		0,146,147,5,97,0,0,147,148,5,108,0,0,148,149,5,115,0,0,149,150,5,101,0,
		0,150,6,1,0,0,0,151,152,5,44,0,0,152,8,1,0,0,0,153,154,5,239,0,0,154,155,
		5,187,0,0,155,156,5,191,0,0,156,157,1,0,0,0,157,158,6,4,0,0,158,10,1,0,
		0,0,159,160,5,110,0,0,160,161,5,97,0,0,161,162,5,109,0,0,162,163,5,101,
		0,0,163,164,5,115,0,0,164,165,5,112,0,0,165,166,5,97,0,0,166,167,5,99,
		0,0,167,168,5,101,0,0,168,12,1,0,0,0,169,170,5,59,0,0,170,14,1,0,0,0,171,
		172,5,117,0,0,172,173,5,115,0,0,173,174,5,105,0,0,174,175,5,110,0,0,175,
		176,5,103,0,0,176,16,1,0,0,0,177,178,5,109,0,0,178,179,5,101,0,0,179,180,
		5,116,0,0,180,181,5,97,0,0,181,182,5,109,0,0,182,183,5,111,0,0,183,184,
		5,100,0,0,184,185,5,101,0,0,185,186,5,108,0,0,186,18,1,0,0,0,187,188,5,
		99,0,0,188,189,5,111,0,0,189,190,5,110,0,0,190,191,5,115,0,0,191,192,5,
		116,0,0,192,20,1,0,0,0,193,194,5,101,0,0,194,195,5,110,0,0,195,196,5,117,
		0,0,196,197,5,109,0,0,197,22,1,0,0,0,198,199,5,97,0,0,199,200,5,98,0,0,
		200,201,5,115,0,0,201,202,5,116,0,0,202,203,5,114,0,0,203,204,5,97,0,0,
		204,205,5,99,0,0,205,206,5,116,0,0,206,24,1,0,0,0,207,208,5,99,0,0,208,
		209,5,108,0,0,209,210,5,97,0,0,210,211,5,115,0,0,211,212,5,115,0,0,212,
		26,1,0,0,0,213,214,5,40,0,0,214,28,1,0,0,0,215,216,5,41,0,0,216,30,1,0,
		0,0,217,218,5,111,0,0,218,219,5,98,0,0,219,220,5,106,0,0,220,221,5,101,
		0,0,221,222,5,99,0,0,222,223,5,116,0,0,223,32,1,0,0,0,224,225,5,98,0,0,
		225,226,5,111,0,0,226,227,5,111,0,0,227,228,5,108,0,0,228,34,1,0,0,0,229,
		230,5,99,0,0,230,231,5,104,0,0,231,232,5,97,0,0,232,233,5,114,0,0,233,
		36,1,0,0,0,234,235,5,115,0,0,235,236,5,116,0,0,236,237,5,114,0,0,237,238,
		5,105,0,0,238,239,5,110,0,0,239,240,5,103,0,0,240,38,1,0,0,0,241,242,5,
		98,0,0,242,243,5,121,0,0,243,244,5,116,0,0,244,245,5,101,0,0,245,40,1,
		0,0,0,246,247,5,115,0,0,247,248,5,98,0,0,248,249,5,121,0,0,249,250,5,116,
		0,0,250,251,5,101,0,0,251,42,1,0,0,0,252,253,5,115,0,0,253,254,5,104,0,
		0,254,255,5,111,0,0,255,256,5,114,0,0,256,257,5,116,0,0,257,44,1,0,0,0,
		258,259,5,117,0,0,259,260,5,115,0,0,260,261,5,104,0,0,261,262,5,111,0,
		0,262,263,5,114,0,0,263,264,5,116,0,0,264,46,1,0,0,0,265,266,5,105,0,0,
		266,267,5,110,0,0,267,268,5,116,0,0,268,48,1,0,0,0,269,270,5,117,0,0,270,
		271,5,105,0,0,271,272,5,110,0,0,272,273,5,116,0,0,273,50,1,0,0,0,274,275,
		5,108,0,0,275,276,5,111,0,0,276,277,5,110,0,0,277,278,5,103,0,0,278,52,
		1,0,0,0,279,280,5,117,0,0,280,281,5,108,0,0,281,282,5,111,0,0,282,283,
		5,110,0,0,283,284,5,103,0,0,284,54,1,0,0,0,285,286,5,102,0,0,286,287,5,
		108,0,0,287,288,5,111,0,0,288,289,5,97,0,0,289,290,5,116,0,0,290,56,1,
		0,0,0,291,292,5,100,0,0,292,293,5,111,0,0,293,294,5,117,0,0,294,295,5,
		98,0,0,295,296,5,108,0,0,296,297,5,101,0,0,297,58,1,0,0,0,298,299,5,100,
		0,0,299,300,5,101,0,0,300,301,5,99,0,0,301,302,5,105,0,0,302,303,5,109,
		0,0,303,304,5,97,0,0,304,305,5,108,0,0,305,60,1,0,0,0,306,307,5,116,0,
		0,307,308,5,121,0,0,308,309,5,112,0,0,309,310,5,101,0,0,310,62,1,0,0,0,
		311,312,5,115,0,0,312,313,5,121,0,0,313,314,5,109,0,0,314,315,5,98,0,0,
		315,316,5,111,0,0,316,317,5,108,0,0,317,64,1,0,0,0,318,319,5,118,0,0,319,
		320,5,111,0,0,320,321,5,105,0,0,321,322,5,100,0,0,322,66,1,0,0,0,323,324,
		5,61,0,0,324,68,1,0,0,0,325,326,5,123,0,0,326,70,1,0,0,0,327,328,5,125,
		0,0,328,72,1,0,0,0,329,330,5,36,0,0,330,74,1,0,0,0,331,332,5,58,0,0,332,
		76,1,0,0,0,333,334,5,99,0,0,334,335,5,111,0,0,335,336,5,110,0,0,336,337,
		5,116,0,0,337,338,5,97,0,0,338,339,5,105,0,0,339,340,5,110,0,0,340,341,
		5,115,0,0,341,78,1,0,0,0,342,343,5,100,0,0,343,344,5,101,0,0,344,345,5,
		114,0,0,345,346,5,105,0,0,346,347,5,118,0,0,347,348,5,101,0,0,348,349,
		5,100,0,0,349,80,1,0,0,0,350,351,5,117,0,0,351,352,5,110,0,0,352,353,5,
		105,0,0,353,354,5,111,0,0,354,355,5,110,0,0,355,82,1,0,0,0,356,357,5,114,
		0,0,357,358,5,101,0,0,358,359,5,97,0,0,359,360,5,100,0,0,360,361,5,111,
		0,0,361,362,5,110,0,0,362,363,5,108,0,0,363,364,5,121,0,0,364,84,1,0,0,
		0,365,366,5,111,0,0,366,367,5,112,0,0,367,368,5,112,0,0,368,369,5,111,
		0,0,369,370,5,115,0,0,370,371,5,105,0,0,371,372,5,116,0,0,372,373,5,101,
		0,0,373,86,1,0,0,0,374,375,5,115,0,0,375,376,5,117,0,0,376,377,5,98,0,
		0,377,378,5,115,0,0,378,379,5,101,0,0,379,380,5,116,0,0,380,381,5,115,
		0,0,381,88,1,0,0,0,382,383,5,114,0,0,383,384,5,101,0,0,384,385,5,100,0,
		0,385,386,5,101,0,0,386,387,5,102,0,0,387,388,5,105,0,0,388,389,5,110,
		0,0,389,390,5,101,0,0,390,391,5,115,0,0,391,90,1,0,0,0,392,393,5,63,0,
		0,393,92,1,0,0,0,394,395,5,91,0,0,395,94,1,0,0,0,396,397,5,93,0,0,397,
		96,1,0,0,0,398,399,5,46,0,0,399,98,1,0,0,0,400,409,5,48,0,0,401,405,2,
		49,57,0,402,404,2,48,57,0,403,402,1,0,0,0,404,407,1,0,0,0,405,403,1,0,
		0,0,405,406,1,0,0,0,406,409,1,0,0,0,407,405,1,0,0,0,408,400,1,0,0,0,408,
		401,1,0,0,0,409,100,1,0,0,0,410,419,5,48,0,0,411,415,2,49,57,0,412,414,
		2,48,57,0,413,412,1,0,0,0,414,417,1,0,0,0,415,413,1,0,0,0,415,416,1,0,
		0,0,416,419,1,0,0,0,417,415,1,0,0,0,418,410,1,0,0,0,418,411,1,0,0,0,419,
		420,1,0,0,0,420,422,5,46,0,0,421,423,2,48,57,0,422,421,1,0,0,0,423,424,
		1,0,0,0,424,422,1,0,0,0,424,425,1,0,0,0,425,102,1,0,0,0,426,428,7,0,0,
		0,427,426,1,0,0,0,428,429,1,0,0,0,429,427,1,0,0,0,429,430,1,0,0,0,430,
		434,1,0,0,0,431,433,7,1,0,0,432,431,1,0,0,0,433,436,1,0,0,0,434,432,1,
		0,0,0,434,435,1,0,0,0,435,104,1,0,0,0,436,434,1,0,0,0,437,439,5,64,0,0,
		438,440,7,0,0,0,439,438,1,0,0,0,440,441,1,0,0,0,441,439,1,0,0,0,441,442,
		1,0,0,0,442,446,1,0,0,0,443,445,7,1,0,0,444,443,1,0,0,0,445,448,1,0,0,
		0,446,444,1,0,0,0,446,447,1,0,0,0,447,106,1,0,0,0,448,446,1,0,0,0,449,
		453,5,34,0,0,450,452,3,119,59,0,451,450,1,0,0,0,452,455,1,0,0,0,453,451,
		1,0,0,0,453,454,1,0,0,0,454,456,1,0,0,0,455,453,1,0,0,0,456,466,5,34,0,
		0,457,461,5,39,0,0,458,460,3,123,61,0,459,458,1,0,0,0,460,463,1,0,0,0,
		461,459,1,0,0,0,461,462,1,0,0,0,462,464,1,0,0,0,463,461,1,0,0,0,464,466,
		5,39,0,0,465,449,1,0,0,0,465,457,1,0,0,0,466,108,1,0,0,0,467,469,7,2,0,
		0,468,467,1,0,0,0,469,470,1,0,0,0,470,468,1,0,0,0,470,471,1,0,0,0,471,
		472,1,0,0,0,472,473,6,54,0,0,473,110,1,0,0,0,474,475,5,13,0,0,475,478,
		5,10,0,0,476,478,7,3,0,0,477,474,1,0,0,0,477,476,1,0,0,0,478,479,1,0,0,
		0,479,480,6,55,0,0,480,112,1,0,0,0,481,482,5,47,0,0,482,483,5,47,0,0,483,
		487,1,0,0,0,484,486,8,3,0,0,485,484,1,0,0,0,486,489,1,0,0,0,487,485,1,
		0,0,0,487,488,1,0,0,0,488,490,1,0,0,0,489,487,1,0,0,0,490,491,6,56,0,0,
		491,114,1,0,0,0,492,493,5,47,0,0,493,494,5,42,0,0,494,498,1,0,0,0,495,
		497,9,0,0,0,496,495,1,0,0,0,497,500,1,0,0,0,498,499,1,0,0,0,498,496,1,
		0,0,0,499,501,1,0,0,0,500,498,1,0,0,0,501,502,5,42,0,0,502,503,5,47,0,
		0,503,504,1,0,0,0,504,505,6,57,0,0,505,116,1,0,0,0,506,507,9,0,0,0,507,
		508,1,0,0,0,508,509,6,58,0,0,509,118,1,0,0,0,510,514,3,121,60,0,511,514,
		3,127,63,0,512,514,3,131,65,0,513,510,1,0,0,0,513,511,1,0,0,0,513,512,
		1,0,0,0,514,120,1,0,0,0,515,516,8,4,0,0,516,122,1,0,0,0,517,521,3,125,
		62,0,518,521,3,127,63,0,519,521,3,131,65,0,520,517,1,0,0,0,520,518,1,0,
		0,0,520,519,1,0,0,0,521,124,1,0,0,0,522,523,8,5,0,0,523,126,1,0,0,0,524,
		525,5,92,0,0,525,526,3,129,64,0,526,128,1,0,0,0,527,528,7,6,0,0,528,130,
		1,0,0,0,529,530,5,92,0,0,530,531,5,117,0,0,531,532,1,0,0,0,532,533,3,133,
		66,0,533,534,3,133,66,0,534,535,3,133,66,0,535,536,3,133,66,0,536,550,
		1,0,0,0,537,538,5,92,0,0,538,539,5,85,0,0,539,540,1,0,0,0,540,541,3,133,
		66,0,541,542,3,133,66,0,542,543,3,133,66,0,543,544,3,133,66,0,544,545,
		3,133,66,0,545,546,3,133,66,0,546,547,3,133,66,0,547,548,3,133,66,0,548,
		550,1,0,0,0,549,529,1,0,0,0,549,537,1,0,0,0,550,132,1,0,0,0,551,552,7,
		7,0,0,552,134,1,0,0,0,20,0,405,408,415,418,424,429,434,441,446,453,461,
		465,470,477,487,498,513,520,549,1,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MetaDslx.Bootstrap.MetaModel.Compiler