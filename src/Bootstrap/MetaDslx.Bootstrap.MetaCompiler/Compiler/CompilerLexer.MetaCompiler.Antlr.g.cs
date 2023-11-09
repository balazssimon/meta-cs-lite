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
		LR_TComma=1, LR_KNamespace=2, LR_TSemicolon=3, LR_KUsing=4, LR_KLanguage=5, 
		LR_KReturns=6, LR_TColon=7, LR_TBar=8, LR_KBlock=9, LR_TLBrace=10, LR_TRBrace=11, 
		LR_TEqGt=12, LR_KNull=13, LR_KTrue=14, LR_KFalse=15, LR_TDot=16, LR_TInteger=17, 
		LR_TDecimal=18, LR_TIdentifier=19, LR_TString=20, LR_TWhitespace=21, LR_TLineEnd=22, 
		LR_TSingleLineComment=23, LR_TMultiLineComment=24;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LR_TComma", "LR_KNamespace", "LR_TSemicolon", "LR_KUsing", "LR_KLanguage", 
		"LR_KReturns", "LR_TColon", "LR_TBar", "LR_KBlock", "LR_TLBrace", "LR_TRBrace", 
		"LR_TEqGt", "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TDot", "LR_TInteger", 
		"LR_TDecimal", "LR_TIdentifier", "LR_TString", "LR_TWhitespace", "LR_TLineEnd", 
		"LR_TSingleLineComment", "LR_TMultiLineComment"
	};


	public CompilerLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CompilerLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "','", "'namespace'", "';'", "'using'", "'language'", "'returns'", 
		"':'", "'|'", "'block'", "'{'", "'}'", "'=>'", "'null'", "'true'", "'false'", 
		"'.'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LR_TComma", "LR_KNamespace", "LR_TSemicolon", "LR_KUsing", "LR_KLanguage", 
		"LR_KReturns", "LR_TColon", "LR_TBar", "LR_KBlock", "LR_TLBrace", "LR_TRBrace", 
		"LR_TEqGt", "LR_KNull", "LR_KTrue", "LR_KFalse", "LR_TDot", "LR_TInteger", 
		"LR_TDecimal", "LR_TIdentifier", "LR_TString", "LR_TWhitespace", "LR_TLineEnd", 
		"LR_TSingleLineComment", "LR_TMultiLineComment"
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
		4,0,24,206,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
		1,1,2,1,2,1,3,1,3,1,3,1,3,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,
		1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,7,1,7,1,8,1,8,1,8,1,8,1,8,1,
		8,1,9,1,9,1,10,1,10,1,11,1,11,1,11,1,12,1,12,1,12,1,12,1,12,1,13,1,13,
		1,13,1,13,1,13,1,14,1,14,1,14,1,14,1,14,1,14,1,15,1,15,1,16,1,16,1,16,
		5,16,125,8,16,10,16,12,16,128,9,16,3,16,130,8,16,1,17,1,17,1,17,5,17,135,
		8,17,10,17,12,17,138,9,17,3,17,140,8,17,1,17,1,17,4,17,144,8,17,11,17,
		12,17,145,1,18,4,18,149,8,18,11,18,12,18,150,1,18,5,18,154,8,18,10,18,
		12,18,157,9,18,1,19,1,19,5,19,161,8,19,10,19,12,19,164,9,19,1,19,1,19,
		1,20,4,20,169,8,20,11,20,12,20,170,1,20,1,20,1,21,1,21,1,21,3,21,178,8,
		21,1,21,1,21,1,22,1,22,1,22,1,22,5,22,186,8,22,10,22,12,22,189,9,22,1,
		22,1,22,1,23,1,23,1,23,1,23,5,23,197,8,23,10,23,12,23,200,9,23,1,23,1,
		23,1,23,1,23,1,23,2,162,198,0,24,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,
		9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,
		21,43,22,45,23,47,24,1,0,4,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,
		97,122,2,0,9,9,32,32,2,0,10,10,13,13,217,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,
		0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,
		17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,
		0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,
		0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,1,49,
		1,0,0,0,3,51,1,0,0,0,5,61,1,0,0,0,7,63,1,0,0,0,9,69,1,0,0,0,11,78,1,0,
		0,0,13,86,1,0,0,0,15,88,1,0,0,0,17,90,1,0,0,0,19,96,1,0,0,0,21,98,1,0,
		0,0,23,100,1,0,0,0,25,103,1,0,0,0,27,108,1,0,0,0,29,113,1,0,0,0,31,119,
		1,0,0,0,33,129,1,0,0,0,35,139,1,0,0,0,37,148,1,0,0,0,39,158,1,0,0,0,41,
		168,1,0,0,0,43,177,1,0,0,0,45,181,1,0,0,0,47,192,1,0,0,0,49,50,5,44,0,
		0,50,2,1,0,0,0,51,52,5,110,0,0,52,53,5,97,0,0,53,54,5,109,0,0,54,55,5,
		101,0,0,55,56,5,115,0,0,56,57,5,112,0,0,57,58,5,97,0,0,58,59,5,99,0,0,
		59,60,5,101,0,0,60,4,1,0,0,0,61,62,5,59,0,0,62,6,1,0,0,0,63,64,5,117,0,
		0,64,65,5,115,0,0,65,66,5,105,0,0,66,67,5,110,0,0,67,68,5,103,0,0,68,8,
		1,0,0,0,69,70,5,108,0,0,70,71,5,97,0,0,71,72,5,110,0,0,72,73,5,103,0,0,
		73,74,5,117,0,0,74,75,5,97,0,0,75,76,5,103,0,0,76,77,5,101,0,0,77,10,1,
		0,0,0,78,79,5,114,0,0,79,80,5,101,0,0,80,81,5,116,0,0,81,82,5,117,0,0,
		82,83,5,114,0,0,83,84,5,110,0,0,84,85,5,115,0,0,85,12,1,0,0,0,86,87,5,
		58,0,0,87,14,1,0,0,0,88,89,5,124,0,0,89,16,1,0,0,0,90,91,5,98,0,0,91,92,
		5,108,0,0,92,93,5,111,0,0,93,94,5,99,0,0,94,95,5,107,0,0,95,18,1,0,0,0,
		96,97,5,123,0,0,97,20,1,0,0,0,98,99,5,125,0,0,99,22,1,0,0,0,100,101,5,
		61,0,0,101,102,5,62,0,0,102,24,1,0,0,0,103,104,5,110,0,0,104,105,5,117,
		0,0,105,106,5,108,0,0,106,107,5,108,0,0,107,26,1,0,0,0,108,109,5,116,0,
		0,109,110,5,114,0,0,110,111,5,117,0,0,111,112,5,101,0,0,112,28,1,0,0,0,
		113,114,5,102,0,0,114,115,5,97,0,0,115,116,5,108,0,0,116,117,5,115,0,0,
		117,118,5,101,0,0,118,30,1,0,0,0,119,120,5,46,0,0,120,32,1,0,0,0,121,130,
		5,48,0,0,122,126,2,49,57,0,123,125,2,48,57,0,124,123,1,0,0,0,125,128,1,
		0,0,0,126,124,1,0,0,0,126,127,1,0,0,0,127,130,1,0,0,0,128,126,1,0,0,0,
		129,121,1,0,0,0,129,122,1,0,0,0,130,34,1,0,0,0,131,140,5,48,0,0,132,136,
		2,49,57,0,133,135,2,48,57,0,134,133,1,0,0,0,135,138,1,0,0,0,136,134,1,
		0,0,0,136,137,1,0,0,0,137,140,1,0,0,0,138,136,1,0,0,0,139,131,1,0,0,0,
		139,132,1,0,0,0,140,141,1,0,0,0,141,143,5,46,0,0,142,144,2,48,57,0,143,
		142,1,0,0,0,144,145,1,0,0,0,145,143,1,0,0,0,145,146,1,0,0,0,146,36,1,0,
		0,0,147,149,7,0,0,0,148,147,1,0,0,0,149,150,1,0,0,0,150,148,1,0,0,0,150,
		151,1,0,0,0,151,155,1,0,0,0,152,154,7,1,0,0,153,152,1,0,0,0,154,157,1,
		0,0,0,155,153,1,0,0,0,155,156,1,0,0,0,156,38,1,0,0,0,157,155,1,0,0,0,158,
		162,5,34,0,0,159,161,9,0,0,0,160,159,1,0,0,0,161,164,1,0,0,0,162,163,1,
		0,0,0,162,160,1,0,0,0,163,165,1,0,0,0,164,162,1,0,0,0,165,166,5,34,0,0,
		166,40,1,0,0,0,167,169,7,2,0,0,168,167,1,0,0,0,169,170,1,0,0,0,170,168,
		1,0,0,0,170,171,1,0,0,0,171,172,1,0,0,0,172,173,6,20,0,0,173,42,1,0,0,
		0,174,175,5,13,0,0,175,178,5,10,0,0,176,178,7,3,0,0,177,174,1,0,0,0,177,
		176,1,0,0,0,178,179,1,0,0,0,179,180,6,21,0,0,180,44,1,0,0,0,181,182,5,
		47,0,0,182,183,5,47,0,0,183,187,1,0,0,0,184,186,8,3,0,0,185,184,1,0,0,
		0,186,189,1,0,0,0,187,185,1,0,0,0,187,188,1,0,0,0,188,190,1,0,0,0,189,
		187,1,0,0,0,190,191,6,22,0,0,191,46,1,0,0,0,192,193,5,47,0,0,193,194,5,
		42,0,0,194,198,1,0,0,0,195,197,9,0,0,0,196,195,1,0,0,0,197,200,1,0,0,0,
		198,199,1,0,0,0,198,196,1,0,0,0,199,201,1,0,0,0,200,198,1,0,0,0,201,202,
		5,42,0,0,202,203,5,47,0,0,203,204,1,0,0,0,204,205,6,23,0,0,205,48,1,0,
		0,0,13,0,126,129,136,139,145,150,155,162,170,177,187,198,1,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MetaDslx.Bootstrap.MetaCompiler.Compiler
