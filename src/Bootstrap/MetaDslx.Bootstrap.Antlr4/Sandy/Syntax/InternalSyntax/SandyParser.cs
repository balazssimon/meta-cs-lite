//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from obj\Debug\net5.0\Syntax\InternalSyntax\SandyParser.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using global::Antlr4.Runtime;
using global::Antlr4.Runtime.Atn;
using global::Antlr4.Runtime.Misc;
using global::Antlr4.Runtime.Tree;
using DFA = global::Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public partial class SandyParser : global::MetaDslx.CodeAnalysis.Antlr4.Antlr4Parser {
    private SandySyntaxParser SyntaxParser => (SandySyntaxParser)this.IncrementalAntlr4Parser;
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		NEWLINE=1, WS=2, VAR=3, PRINT=4, AS=5, INT=6, DECIMAL=7, INTLIT=8, DECLIT=9, 
		PLUS=10, MINUS=11, ASTERISK=12, DIVISION=13, ASSIGN=14, LPAREN=15, RPAREN=16, 
		COMMA=17, ID=18;
	public const int
		RULE_main = 0, RULE_line = 1, RULE_statement = 2, RULE_print = 3, RULE_varDeclaration = 4, 
		RULE_assignment = 5, RULE_expression = 6, RULE_type = 7;
	public static readonly string[] ruleNames = {
		"main", "line", "statement", "print", "varDeclaration", "assignment", 
		"expression", "type"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, "'var'", "'print'", "'as'", "'Int'", "'Decimal'", null, 
		null, "'+'", "'-'", "'*'", "'/'", "'='", "'('", "')'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NEWLINE", "WS", "VAR", "PRINT", "AS", "INT", "DECIMAL", "INTLIT", 
		"DECLIT", "PLUS", "MINUS", "ASTERISK", "DIVISION", "ASSIGN", "LPAREN", 
		"RPAREN", "COMMA", "ID"
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

	public override string GrammarFileName { get { return "SandyParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static SandyParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public SandyParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public SandyParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class MainContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(SandyParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public LineContext[] line() {
			return GetRuleContexts<LineContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public LineContext line(int i) {
			return GetRuleContext<LineContext>(i);
		}
		public MainContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_main; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMain(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MainContext main() {
		return this.SyntaxParser != null ? this.SyntaxParser._Antlr4ParseMain() : _DoParseMain();
	}

	internal MainContext _DoParseMain() {
		MainContext _localctx = new MainContext(Context, State);
		EnterRule(_localctx, 0, RULE_main);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 19;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << VAR) | (1L << PRINT) | (1L << ID))) != 0)) {
				{
				{
				State = 16;
				line();
				}
				}
				State = 21;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 22;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LineContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(SandyParser.NEWLINE, 0); }
		public LineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_line; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLine(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LineContext line() {
		return this.SyntaxParser != null ? this.SyntaxParser._Antlr4ParseLine() : _DoParseLine();
	}

	internal LineContext _DoParseLine() {
		LineContext _localctx = new LineContext(Context, State);
		EnterRule(_localctx, 2, RULE_line);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 24;
			statement();
			State = 25;
			Match(NEWLINE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public VarDeclarationContext varDeclaration() {
			return GetRuleContext<VarDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentContext assignment() {
			return GetRuleContext<AssignmentContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrintContext print() {
			return GetRuleContext<PrintContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		return this.SyntaxParser != null ? this.SyntaxParser._Antlr4ParseStatement() : _DoParseStatement();
	}

	internal StatementContext _DoParseStatement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 4, RULE_statement);
		try {
			State = 30;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case VAR:
				EnterOuterAlt(_localctx, 1);
				{
				State = 27;
				varDeclaration();
				}
				break;
			case ID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 28;
				assignment();
				}
				break;
			case PRINT:
				EnterOuterAlt(_localctx, 3);
				{
				State = 29;
				print();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PrintContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRINT() { return GetToken(SandyParser.PRINT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(SandyParser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(SandyParser.RPAREN, 0); }
		public PrintContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_print; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrint(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PrintContext print() {
		return this.SyntaxParser != null ? this.SyntaxParser._Antlr4ParsePrint() : _DoParsePrint();
	}

	internal PrintContext _DoParsePrint() {
		PrintContext _localctx = new PrintContext(Context, State);
		EnterRule(_localctx, 6, RULE_print);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 32;
			Match(PRINT);
			State = 33;
			Match(LPAREN);
			State = 34;
			expression(0);
			State = 35;
			Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VarDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VAR() { return GetToken(SandyParser.VAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentContext assignment() {
			return GetRuleContext<AssignmentContext>(0);
		}
		public VarDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_varDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVarDeclaration(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VarDeclarationContext varDeclaration() {
		return this.SyntaxParser != null ? this.SyntaxParser._Antlr4ParseVarDeclaration() : _DoParseVarDeclaration();
	}

	internal VarDeclarationContext _DoParseVarDeclaration() {
		VarDeclarationContext _localctx = new VarDeclarationContext(Context, State);
		EnterRule(_localctx, 8, RULE_varDeclaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 37;
			Match(VAR);
			State = 38;
			assignment();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignmentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(SandyParser.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN() { return GetToken(SandyParser.ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public AssignmentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignment; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAssignment(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentContext assignment() {
		return this.SyntaxParser != null ? this.SyntaxParser._Antlr4ParseAssignment() : _DoParseAssignment();
	}

	internal AssignmentContext _DoParseAssignment() {
		AssignmentContext _localctx = new AssignmentContext(Context, State);
		EnterRule(_localctx, 10, RULE_assignment);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 40;
			Match(ID);
			State = 41;
			Match(ASSIGN);
			State = 42;
			expression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class BinaryMulOperationContext : ExpressionContext {
		public ExpressionContext left;
		public IToken op;
		public ExpressionContext right;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIVISION() { return GetToken(SandyParser.DIVISION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASTERISK() { return GetToken(SandyParser.ASTERISK, 0); }
		public BinaryMulOperationContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBinaryMulOperation(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DecimalLiteralContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DECLIT() { return GetToken(SandyParser.DECLIT, 0); }
		public DecimalLiteralContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDecimalLiteral(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BinaryAddOperationContext : ExpressionContext {
		public ExpressionContext left;
		public IToken op;
		public ExpressionContext right;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLUS() { return GetToken(SandyParser.PLUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(SandyParser.MINUS, 0); }
		public BinaryAddOperationContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBinaryAddOperation(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MinusExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(SandyParser.MINUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public MinusExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMinusExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IntLiteralContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTLIT() { return GetToken(SandyParser.INTLIT, 0); }
		public IntLiteralContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIntLiteral(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParenExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(SandyParser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(SandyParser.RPAREN, 0); }
		public ParenExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TypeConversionContext : ExpressionContext {
		public ExpressionContext value;
		public TypeContext targetType;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS() { return GetToken(SandyParser.AS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeContext type() {
			return GetRuleContext<TypeContext>(0);
		}
		public TypeConversionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTypeConversion(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class VarReferenceContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(SandyParser.ID, 0); }
		public VarReferenceContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVarReference(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		return this.SyntaxParser != null ? this.SyntaxParser._Antlr4ParseExpression(_p) : _DoParseExpression(_p);
	}

	internal ExpressionContext _DoParseExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 12;
		EnterRecursionRule(_localctx, 12, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 54;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LPAREN:
				{
				_localctx = new ParenExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 45;
				Match(LPAREN);
				State = 46;
				expression(0);
				State = 47;
				Match(RPAREN);
				}
				break;
			case ID:
				{
				_localctx = new VarReferenceContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 49;
				Match(ID);
				}
				break;
			case MINUS:
				{
				_localctx = new MinusExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 50;
				Match(MINUS);
				State = 51;
				expression(3);
				}
				break;
			case INTLIT:
				{
				_localctx = new IntLiteralContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 52;
				Match(INTLIT);
				}
				break;
			case DECLIT:
				{
				_localctx = new DecimalLiteralContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 53;
				Match(DECLIT);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 67;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 65;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
					case 1:
						{
						_localctx = new BinaryMulOperationContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryMulOperationContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 56;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 57;
						((BinaryMulOperationContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==ASTERISK || _la==DIVISION) ) {
							((BinaryMulOperationContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 58;
						((BinaryMulOperationContext)_localctx).right = expression(9);
						}
						break;
					case 2:
						{
						_localctx = new BinaryAddOperationContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryAddOperationContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 59;
						if (!(Precpred(Context, 7))) throw new FailedPredicateException(this, "Precpred(Context, 7)");
						State = 60;
						((BinaryAddOperationContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==PLUS || _la==MINUS) ) {
							((BinaryAddOperationContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 61;
						((BinaryAddOperationContext)_localctx).right = expression(8);
						}
						break;
					case 3:
						{
						_localctx = new TypeConversionContext(new ExpressionContext(_parentctx, _parentState));
						((TypeConversionContext)_localctx).value = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 62;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 63;
						Match(AS);
						State = 64;
						((TypeConversionContext)_localctx).targetType = type();
						}
						break;
					}
					} 
				}
				State = 69;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class TypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(SandyParser.INT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DECIMAL() { return GetToken(SandyParser.DECIMAL, 0); }
		public TypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISandyParserVisitor<TResult> typedVisitor = visitor as ISandyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitType(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TypeContext type() {
		return this.SyntaxParser != null ? this.SyntaxParser._Antlr4ParseType() : _DoParseType();
	}

	internal TypeContext _DoParseType() {
		TypeContext _localctx = new TypeContext(Context, State);
		EnterRule(_localctx, 14, RULE_type);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 70;
			_la = TokenStream.LA(1);
			if ( !(_la==INT || _la==DECIMAL) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 6: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 8);
		case 1: return Precpred(Context, 7);
		case 2: return Precpred(Context, 6);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x14', 'K', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x3', '\x2', '\a', '\x2', '\x14', '\n', '\x2', 
		'\f', '\x2', '\xE', '\x2', '\x17', '\v', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x5', '\x4', '!', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', '\x39', 
		'\n', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\a', '\b', 
		'\x44', '\n', '\b', '\f', '\b', '\xE', '\b', 'G', '\v', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x2', '\x3', '\xE', '\n', '\x2', '\x4', '\x6', 
		'\b', '\n', '\f', '\xE', '\x10', '\x2', '\x5', '\x3', '\x2', '\xE', '\xF', 
		'\x3', '\x2', '\f', '\r', '\x3', '\x2', '\b', '\t', '\x2', 'L', '\x2', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x4', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\x6', ' ', '\x3', '\x2', '\x2', '\x2', '\b', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\n', '\'', '\x3', '\x2', '\x2', '\x2', '\f', '*', '\x3', 
		'\x2', '\x2', '\x2', '\xE', '\x38', '\x3', '\x2', '\x2', '\x2', '\x10', 
		'H', '\x3', '\x2', '\x2', '\x2', '\x12', '\x14', '\x5', '\x4', '\x3', 
		'\x2', '\x13', '\x12', '\x3', '\x2', '\x2', '\x2', '\x14', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x15', '\x13', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'\x16', '\x3', '\x2', '\x2', '\x2', '\x16', '\x18', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x15', '\x3', '\x2', '\x2', '\x2', '\x18', '\x19', '\a', 
		'\x2', '\x2', '\x3', '\x19', '\x3', '\x3', '\x2', '\x2', '\x2', '\x1A', 
		'\x1B', '\x5', '\x6', '\x4', '\x2', '\x1B', '\x1C', '\a', '\x3', '\x2', 
		'\x2', '\x1C', '\x5', '\x3', '\x2', '\x2', '\x2', '\x1D', '!', '\x5', 
		'\n', '\x6', '\x2', '\x1E', '!', '\x5', '\f', '\a', '\x2', '\x1F', '!', 
		'\x5', '\b', '\x5', '\x2', ' ', '\x1D', '\x3', '\x2', '\x2', '\x2', ' ', 
		'\x1E', '\x3', '\x2', '\x2', '\x2', ' ', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '!', '\a', '\x3', '\x2', '\x2', '\x2', '\"', '#', '\a', '\x6', 
		'\x2', '\x2', '#', '$', '\a', '\x11', '\x2', '\x2', '$', '%', '\x5', '\xE', 
		'\b', '\x2', '%', '&', '\a', '\x12', '\x2', '\x2', '&', '\t', '\x3', '\x2', 
		'\x2', '\x2', '\'', '(', '\a', '\x5', '\x2', '\x2', '(', ')', '\x5', '\f', 
		'\a', '\x2', ')', '\v', '\x3', '\x2', '\x2', '\x2', '*', '+', '\a', '\x14', 
		'\x2', '\x2', '+', ',', '\a', '\x10', '\x2', '\x2', ',', '-', '\x5', '\xE', 
		'\b', '\x2', '-', '\r', '\x3', '\x2', '\x2', '\x2', '.', '/', '\b', '\b', 
		'\x1', '\x2', '/', '\x30', '\a', '\x11', '\x2', '\x2', '\x30', '\x31', 
		'\x5', '\xE', '\b', '\x2', '\x31', '\x32', '\a', '\x12', '\x2', '\x2', 
		'\x32', '\x39', '\x3', '\x2', '\x2', '\x2', '\x33', '\x39', '\a', '\x14', 
		'\x2', '\x2', '\x34', '\x35', '\a', '\r', '\x2', '\x2', '\x35', '\x39', 
		'\x5', '\xE', '\b', '\x5', '\x36', '\x39', '\a', '\n', '\x2', '\x2', '\x37', 
		'\x39', '\a', '\v', '\x2', '\x2', '\x38', '.', '\x3', '\x2', '\x2', '\x2', 
		'\x38', '\x33', '\x3', '\x2', '\x2', '\x2', '\x38', '\x34', '\x3', '\x2', 
		'\x2', '\x2', '\x38', '\x36', '\x3', '\x2', '\x2', '\x2', '\x38', '\x37', 
		'\x3', '\x2', '\x2', '\x2', '\x39', '\x45', '\x3', '\x2', '\x2', '\x2', 
		':', ';', '\f', '\n', '\x2', '\x2', ';', '<', '\t', '\x2', '\x2', '\x2', 
		'<', '\x44', '\x5', '\xE', '\b', '\v', '=', '>', '\f', '\t', '\x2', '\x2', 
		'>', '?', '\t', '\x3', '\x2', '\x2', '?', '\x44', '\x5', '\xE', '\b', 
		'\n', '@', '\x41', '\f', '\b', '\x2', '\x2', '\x41', '\x42', '\a', '\a', 
		'\x2', '\x2', '\x42', '\x44', '\x5', '\x10', '\t', '\x2', '\x43', ':', 
		'\x3', '\x2', '\x2', '\x2', '\x43', '=', '\x3', '\x2', '\x2', '\x2', '\x43', 
		'@', '\x3', '\x2', '\x2', '\x2', '\x44', 'G', '\x3', '\x2', '\x2', '\x2', 
		'\x45', '\x43', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\x3', '\x2', 
		'\x2', '\x2', '\x46', '\xF', '\x3', '\x2', '\x2', '\x2', 'G', '\x45', 
		'\x3', '\x2', '\x2', '\x2', 'H', 'I', '\t', '\x4', '\x2', '\x2', 'I', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\a', '\x15', ' ', '\x38', '\x43', 
		'\x45',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Antlr4Intellisense.Syntax.InternalSyntax
