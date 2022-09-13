// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// WARNING: This is an auto-generated file. Any manual changes will be lost when the file is regenerated.
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Antlr4;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;

namespace MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax
{
    public class SandySyntaxParser : Antlr4SyntaxParser
    {
        private readonly Antlr4ToRoslynVisitor _visitor;
        public SandySyntaxParser(
            SandySyntaxLexer lexer,
            SandySyntaxNode oldTree, 
			ParseData oldParseData,
            IEnumerable<TextChangeRange> changes,
            CancellationToken cancellationToken = default)
            : base(lexer, oldTree, oldParseData, changes, cancellationToken)
        {
            _visitor = new Antlr4ToRoslynVisitor(this);
        }
        protected new SandyParser Antlr4Parser => (SandyParser)base.Antlr4Parser;
		public override SyntaxNode Parse()
		{
			BeginRoot();
            ParserState state = null;
			var green = this.ParseMain(ref state);
			EndRoot(ref green);
			var red = (SandySyntaxNode)green.CreateRed();
			return red;
		}
		public GreenNode ParseMain(ref ParserState state)
		{
		    RestoreParserState(state);
			try
			{
		        var context = this.IsIncremental ? this.Antlr4Parser.main() : _Antlr4ParseMain();
		        if (TryGetGreenNode(context, out var green)) return green;
		        else return _visitor.Visit(context);
			}
			finally
			{
				state = this.State;
			}
		}
		
		protected virtual bool CanReuseMain(MainSyntax node)
		{
			return node != null;
		}
		
		internal SandyParser.MainContext _Antlr4ParseMain()
		{
			BeginNode();
		    bool cached = false;
		    SandyParser.MainContext context = null;
		    GreenNode green = null;
		    try
		    {
		        cached = IsIncremental && CanReuseMain(CurrentNode as MainSyntax);
				if (cached)
				{
					green = EatNode();
				}
				else
				{
					context = this.Antlr4Parser._DoParseMain();
					green = _visitor.Visit(context);
				}
		    }
		    finally
		    {
		        EndNode(ref green);
		        if (cached)
		        {
					context = new SandyParser.MainContext_Cached(this.Antlr4Parser.Context, this.Antlr4Parser.State, green);
					this.Antlr4Parser.Context.AddChild(context);
		        }
		        CacheGreenNode(context, green);
		    }
		    return context;
		}
		public GreenNode ParseLine(ref ParserState state)
		{
		    RestoreParserState(state);
			try
			{
				var context = this.Antlr4Parser.line();
		        if (TryGetGreenNode(context, out var green)) return green;
		        else return _visitor.Visit(context);
			}
			finally
			{
				state = this.State;
			}
		}
		
		protected virtual bool CanReuseLine(LineSyntax node)
		{
			return node != null;
		}
		
		internal SandyParser.LineContext _Antlr4ParseLine()
		{
			BeginNode();
		    bool cached = false;
		    SandyParser.LineContext context = null;
		    GreenNode green = null;
		    try
		    {
		        cached = IsIncremental && CanReuseLine(CurrentNode as LineSyntax);
				if (cached)
				{
					green = EatNode();
				}
				else
				{
					context = this.Antlr4Parser._DoParseLine();
					green = _visitor.Visit(context);
				}
		    }
		    finally
		    {
		        EndNode(ref green);
		        if (cached)
		        {
					context = new SandyParser.LineContext_Cached(this.Antlr4Parser.Context, this.Antlr4Parser.State, green);
					this.Antlr4Parser.Context.AddChild(context);
		        }
		        CacheGreenNode(context, green);
		    }
		    return context;
		}
		public GreenNode ParseStatement(ref ParserState state)
		{
		    RestoreParserState(state);
			try
			{
				var context = this.Antlr4Parser.statement();
		        if (TryGetGreenNode(context, out var green)) return green;
		        else return _visitor.Visit(context);
			}
			finally
			{
				state = this.State;
			}
		}
		
		protected virtual bool CanReuseStatement(StatementSyntax node)
		{
			return node != null;
		}
		
		internal SandyParser.StatementContext _Antlr4ParseStatement()
		{
			BeginNode();
		    bool cached = false;
		    SandyParser.StatementContext context = null;
		    GreenNode green = null;
		    try
		    {
		        cached = IsIncremental && CanReuseStatement(CurrentNode as StatementSyntax);
				if (cached)
				{
					green = EatNode();
				}
				else
				{
					context = this.Antlr4Parser._DoParseStatement();
					green = _visitor.Visit(context);
				}
		    }
		    finally
		    {
		        EndNode(ref green);
		        if (cached)
		        {
					context = new SandyParser.StatementContext_Cached(this.Antlr4Parser.Context, this.Antlr4Parser.State, green);
					this.Antlr4Parser.Context.AddChild(context);
		        }
		        CacheGreenNode(context, green);
		    }
		    return context;
		}
		public GreenNode ParsePrint(ref ParserState state)
		{
		    RestoreParserState(state);
			try
			{
				var context = this.Antlr4Parser.print();
		        if (TryGetGreenNode(context, out var green)) return green;
		        else return _visitor.Visit(context);
			}
			finally
			{
				state = this.State;
			}
		}
		
		protected virtual bool CanReusePrint(PrintSyntax node)
		{
			return node != null;
		}
		
		internal SandyParser.PrintContext _Antlr4ParsePrint()
		{
			BeginNode();
		    bool cached = false;
		    SandyParser.PrintContext context = null;
		    GreenNode green = null;
		    try
		    {
		        cached = IsIncremental && CanReusePrint(CurrentNode as PrintSyntax);
				if (cached)
				{
					green = EatNode();
				}
				else
				{
					context = this.Antlr4Parser._DoParsePrint();
					green = _visitor.Visit(context);
				}
		    }
		    finally
		    {
		        EndNode(ref green);
		        if (cached)
		        {
					context = new SandyParser.PrintContext_Cached(this.Antlr4Parser.Context, this.Antlr4Parser.State, green);
					this.Antlr4Parser.Context.AddChild(context);
		        }
		        CacheGreenNode(context, green);
		    }
		    return context;
		}
		public GreenNode ParseVarDeclaration(ref ParserState state)
		{
		    RestoreParserState(state);
			try
			{
				var context = this.Antlr4Parser.varDeclaration();
		        if (TryGetGreenNode(context, out var green)) return green;
		        else return _visitor.Visit(context);
			}
			finally
			{
				state = this.State;
			}
		}
		
		protected virtual bool CanReuseVarDeclaration(VarDeclarationSyntax node)
		{
			return node != null;
		}
		
		internal SandyParser.VarDeclarationContext _Antlr4ParseVarDeclaration()
		{
			BeginNode();
		    bool cached = false;
		    SandyParser.VarDeclarationContext context = null;
		    GreenNode green = null;
		    try
		    {
		        cached = IsIncremental && CanReuseVarDeclaration(CurrentNode as VarDeclarationSyntax);
				if (cached)
				{
					green = EatNode();
				}
				else
				{
					context = this.Antlr4Parser._DoParseVarDeclaration();
					green = _visitor.Visit(context);
				}
		    }
		    finally
		    {
		        EndNode(ref green);
		        if (cached)
		        {
					context = new SandyParser.VarDeclarationContext_Cached(this.Antlr4Parser.Context, this.Antlr4Parser.State, green);
					this.Antlr4Parser.Context.AddChild(context);
		        }
		        CacheGreenNode(context, green);
		    }
		    return context;
		}
		public GreenNode ParseAssignment(ref ParserState state)
		{
		    RestoreParserState(state);
			try
			{
				var context = this.Antlr4Parser.assignment();
		        if (TryGetGreenNode(context, out var green)) return green;
		        else return _visitor.Visit(context);
			}
			finally
			{
				state = this.State;
			}
		}
		
		protected virtual bool CanReuseAssignment(AssignmentSyntax node)
		{
			return node != null;
		}
		
		internal SandyParser.AssignmentContext _Antlr4ParseAssignment()
		{
			BeginNode();
		    bool cached = false;
		    SandyParser.AssignmentContext context = null;
		    GreenNode green = null;
		    try
		    {
		        cached = IsIncremental && CanReuseAssignment(CurrentNode as AssignmentSyntax);
				if (cached)
				{
					green = EatNode();
				}
				else
				{
					context = this.Antlr4Parser._DoParseAssignment();
					green = _visitor.Visit(context);
				}
		    }
		    finally
		    {
		        EndNode(ref green);
		        if (cached)
		        {
					context = new SandyParser.AssignmentContext_Cached(this.Antlr4Parser.Context, this.Antlr4Parser.State, green);
					this.Antlr4Parser.Context.AddChild(context);
		        }
		        CacheGreenNode(context, green);
		    }
		    return context;
		}
		public GreenNode ParseExpression(ref ParserState state)
		{
		    RestoreParserState(state);
			try
			{
				var context = this.Antlr4Parser.expression();
		        if (TryGetGreenNode(context, out var green)) return green;
		        else return _visitor.Visit(context);
			}
			finally
			{
				state = this.State;
			}
		}
		
		protected virtual bool CanReuseExpression(ExpressionSyntax node)
		{
			return node != null;
		}
		
		internal SandyParser.ExpressionContext _Antlr4ParseExpression(int precedence)
		{
			BeginNode();
		    bool cached = false;
		    SandyParser.ExpressionContext context = null;
		    GreenNode green = null;
		    try
		    {
		        cached = IsIncremental && CanReuseExpression(CurrentNode as ExpressionSyntax);
				if (cached)
				{
					green = EatNode();
				}
				else
				{
					context = this.Antlr4Parser._DoParseExpression(precedence);
					green = _visitor.Visit(context);
				}
		    }
		    finally
		    {
		        EndNode(ref green);
		        if (cached)
		        {
					context = new SandyParser.ExpressionContext_Cached(this.Antlr4Parser.Context, this.Antlr4Parser.State, green);
					this.Antlr4Parser.Context.AddChild(context);
		        }
		        CacheGreenNode(context, green);
		    }
		    return context;
		}
		public GreenNode ParseType(ref ParserState state)
		{
		    RestoreParserState(state);
			try
			{
				var context = this.Antlr4Parser.type();
		        if (TryGetGreenNode(context, out var green)) return green;
		        else return _visitor.Visit(context);
			}
			finally
			{
				state = this.State;
			}
		}
		
		protected virtual bool CanReuseType(TypeSyntax node)
		{
			return node != null;
		}
		
		internal SandyParser.TypeContext _Antlr4ParseType()
		{
			BeginNode();
		    bool cached = false;
		    SandyParser.TypeContext context = null;
		    GreenNode green = null;
		    try
		    {
		        cached = IsIncremental && CanReuseType(CurrentNode as TypeSyntax);
				if (cached)
				{
					green = EatNode();
				}
				else
				{
					context = this.Antlr4Parser._DoParseType();
					green = _visitor.Visit(context);
				}
		    }
		    finally
		    {
		        EndNode(ref green);
		        if (cached)
		        {
					context = new SandyParser.TypeContext_Cached(this.Antlr4Parser.Context, this.Antlr4Parser.State, green);
					this.Antlr4Parser.Context.AddChild(context);
		        }
		        CacheGreenNode(context, green);
		    }
		    return context;
		}
        private class Antlr4ToRoslynVisitor : SandyParserBaseVisitor<GreenNode>
        {
			// list pools - allocators for lists that are used to build sequences of nodes. The lists
			// can be reused (hence pooled) since the syntax factory methods don't keep references to
			// them
			private readonly SyntaxListPool _pool = new SyntaxListPool(); // Don't need to reset this.
			private readonly SandyInternalSyntaxFactory _factory;
            private readonly SandySyntaxParser _syntaxParser;
            public Antlr4ToRoslynVisitor(SandySyntaxParser syntaxParser)
            {
				_factory = (SandyInternalSyntaxFactory)syntaxParser.Language.InternalSyntaxFactory;
                _syntaxParser = syntaxParser;
            }
            private GreenNode VisitTerminal(IToken token, SandySyntaxKind kind)
            {
				if (token != null)
				{
					var green = ((Antlr4SyntaxToken)token).Green;
					Debug.Assert(kind == null || green.RawKind == (int)kind);
					return ConsumeRealToken((Antlr4SyntaxToken)token);
				}
				throw new NotImplementedException("Should not reach this point.");
			}
            public GreenNode VisitTerminal(IToken token)
            {
				return ConsumeRealToken((Antlr4SyntaxToken)token);
			}
            private GreenNode VisitTerminal(ITerminalNode node, SandySyntaxKind kind)
            {
				if (node?.Symbol != null)
                {
					var green = ((Antlr4SyntaxToken)node.Symbol).Green;
					Debug.Assert(kind == null || green.RawKind == (int)kind);
					return ConsumeRealToken((Antlr4SyntaxToken)node.Symbol);
				}
				throw new NotImplementedException("Should not reach this point.");
			}
			public override GreenNode VisitTerminal(ITerminalNode node)
            {
				return ConsumeRealToken((Antlr4SyntaxToken)node.Symbol);
			}
			private InternalSyntaxToken ConsumeRealToken(Antlr4SyntaxToken token)
            {
				return _syntaxParser.ConsumeRealToken(token);
            }
			public override GreenNode Visit(IParseTree tree)
			{
                if (tree is ICachedRuleContext cached)
                {
                    return cached.CachedNode;
                }
				else if (tree is ParserRuleContext context)
                {
                    if (_syntaxParser.TryGetGreenNode(context, out var existingGreenNode)) return existingGreenNode;
    				return base.Visit(tree);
                }
                else
                {
                    return base.Visit(tree);
                }
			}
			
			public override GreenNode VisitMain(SandyParser.MainContext context)
			{
				if (context == null) return MainGreen.__Missing;
			    SandyParser.LineContext[] lineContext = context.line();
			    var lineBuilder = _pool.Allocate<LineGreen>();
			    for (int i = 0; i < lineContext.Length; i++)
			    {
			        lineBuilder.Add((LineGreen)this.Visit(lineContext[i]));
			    }
				var line = lineBuilder.ToList();
				_pool.Free(lineBuilder);
				InternalSyntaxToken eOF = (InternalSyntaxToken)this.VisitTerminal(context.Eof(), SandySyntaxKind.Eof);
				return _factory.Main(line, eOF);
			}
			
			public override GreenNode VisitLine(SandyParser.LineContext context)
			{
				if (context == null) return LineGreen.__Missing;
				SandyParser.StatementContext statementContext = context.statement();
				StatementGreen statement = null;
				if (statementContext != null) statement = (StatementGreen)this.Visit(statementContext);
				if (statement == null) statement = StatementGreen.__Missing;
				return _factory.Line(statement);
			}
			
			public override GreenNode VisitStatement(SandyParser.StatementContext context)
			{
				if (context == null) return StatementGreen.__Missing;
				SandyParser.VarDeclarationContext varDeclarationContext = context.varDeclaration();
				if (varDeclarationContext != null) 
				{
					return _factory.Statement((VarDeclarationGreen)this.Visit(varDeclarationContext));
				}
				SandyParser.AssignmentContext assignmentContext = context.assignment();
				if (assignmentContext != null) 
				{
					return _factory.Statement((AssignmentGreen)this.Visit(assignmentContext));
				}
				SandyParser.PrintContext printContext = context.print();
				if (printContext != null) 
				{
					return _factory.Statement((PrintGreen)this.Visit(printContext));
				}
				return StatementGreen.__Missing;
			}
			
			public override GreenNode VisitPrint(SandyParser.PrintContext context)
			{
				if (context == null) return PrintGreen.__Missing;
				InternalSyntaxToken pRINT = (InternalSyntaxToken)this.VisitTerminal(context.PRINT(), SandySyntaxKind.PRINT);
				InternalSyntaxToken lPAREN = (InternalSyntaxToken)this.VisitTerminal(context.LPAREN(), SandySyntaxKind.LPAREN);
				SandyParser.ExpressionContext expressionContext = context.expression();
				ExpressionGreen expression = null;
				if (expressionContext != null) expression = (ExpressionGreen)this.Visit(expressionContext);
				if (expression == null) expression = ExpressionGreen.__Missing;
				InternalSyntaxToken rPAREN = (InternalSyntaxToken)this.VisitTerminal(context.RPAREN(), SandySyntaxKind.RPAREN);
				return _factory.Print(pRINT, lPAREN, expression, rPAREN);
			}
			
			public override GreenNode VisitVarDeclaration(SandyParser.VarDeclarationContext context)
			{
				if (context == null) return VarDeclarationGreen.__Missing;
				InternalSyntaxToken vAR = (InternalSyntaxToken)this.VisitTerminal(context.VAR(), SandySyntaxKind.VAR);
				SandyParser.AssignmentContext assignmentContext = context.assignment();
				AssignmentGreen assignment = null;
				if (assignmentContext != null) assignment = (AssignmentGreen)this.Visit(assignmentContext);
				if (assignment == null) assignment = AssignmentGreen.__Missing;
				return _factory.VarDeclaration(vAR, assignment);
			}
			
			public override GreenNode VisitAssignment(SandyParser.AssignmentContext context)
			{
				if (context == null) return AssignmentGreen.__Missing;
				InternalSyntaxToken iD = (InternalSyntaxToken)this.VisitTerminal(context.ID(), SandySyntaxKind.ID);
				InternalSyntaxToken aSSIGN = (InternalSyntaxToken)this.VisitTerminal(context.ASSIGN(), SandySyntaxKind.ASSIGN);
				SandyParser.ExpressionContext expressionContext = context.expression();
				ExpressionGreen expression = null;
				if (expressionContext != null) expression = (ExpressionGreen)this.Visit(expressionContext);
				if (expression == null) expression = ExpressionGreen.__Missing;
				return _factory.Assignment(iD, aSSIGN, expression);
			}
			
			public override GreenNode VisitBinaryMulOperation(SandyParser.BinaryMulOperationContext context)
			{
				if (context == null) return BinaryMulOperationGreen.__Missing;
				SandyParser.ExpressionContext leftContext = context.left;
				ExpressionGreen left = null;
				if (leftContext != null) left = (ExpressionGreen)this.Visit(leftContext);
				if (left == null) left = ExpressionGreen.__Missing;
				InternalSyntaxToken op = null;
				if (context.DIVISION() != null)
				{
					op = (InternalSyntaxToken)this.VisitTerminal(context.DIVISION());
				}
				else 	if (context.ASTERISK() != null)
				{
					op = (InternalSyntaxToken)this.VisitTerminal(context.ASTERISK());
				}
				else
				{
					op = _factory.MissingToken(SandySyntaxKind.MissingToken);
				}
				SandyParser.ExpressionContext rightContext = context.right;
				ExpressionGreen right = null;
				if (rightContext != null) right = (ExpressionGreen)this.Visit(rightContext);
				if (right == null) right = ExpressionGreen.__Missing;
				return _factory.BinaryMulOperation(left, op, right);
			}
			
			public override GreenNode VisitBinaryAddOperation(SandyParser.BinaryAddOperationContext context)
			{
				if (context == null) return BinaryAddOperationGreen.__Missing;
				SandyParser.ExpressionContext leftContext = context.left;
				ExpressionGreen left = null;
				if (leftContext != null) left = (ExpressionGreen)this.Visit(leftContext);
				if (left == null) left = ExpressionGreen.__Missing;
				InternalSyntaxToken op = null;
				if (context.PLUS() != null)
				{
					op = (InternalSyntaxToken)this.VisitTerminal(context.PLUS());
				}
				else 	if (context.MINUS() != null)
				{
					op = (InternalSyntaxToken)this.VisitTerminal(context.MINUS());
				}
				else
				{
					op = _factory.MissingToken(SandySyntaxKind.MissingToken);
				}
				SandyParser.ExpressionContext rightContext = context.right;
				ExpressionGreen right = null;
				if (rightContext != null) right = (ExpressionGreen)this.Visit(rightContext);
				if (right == null) right = ExpressionGreen.__Missing;
				return _factory.BinaryAddOperation(left, op, right);
			}
			
			public override GreenNode VisitTypeConversion(SandyParser.TypeConversionContext context)
			{
				if (context == null) return TypeConversionGreen.__Missing;
				SandyParser.ExpressionContext valueContext = context.value;
				ExpressionGreen value = null;
				if (valueContext != null) value = (ExpressionGreen)this.Visit(valueContext);
				if (value == null) value = ExpressionGreen.__Missing;
				InternalSyntaxToken aS = (InternalSyntaxToken)this.VisitTerminal(context.AS(), SandySyntaxKind.AS);
				SandyParser.TypeContext targetTypeContext = context.targetType;
				TypeGreen targetType = null;
				if (targetTypeContext != null) targetType = (TypeGreen)this.Visit(targetTypeContext);
				if (targetType == null) targetType = TypeGreen.__Missing;
				return _factory.TypeConversion(value, aS, targetType);
			}
			
			public override GreenNode VisitParenExpression(SandyParser.ParenExpressionContext context)
			{
				if (context == null) return ParenExpressionGreen.__Missing;
				InternalSyntaxToken lPAREN = (InternalSyntaxToken)this.VisitTerminal(context.LPAREN(), SandySyntaxKind.LPAREN);
				SandyParser.ExpressionContext expressionContext = context.expression();
				ExpressionGreen expression = null;
				if (expressionContext != null) expression = (ExpressionGreen)this.Visit(expressionContext);
				if (expression == null) expression = ExpressionGreen.__Missing;
				InternalSyntaxToken rPAREN = (InternalSyntaxToken)this.VisitTerminal(context.RPAREN(), SandySyntaxKind.RPAREN);
				return _factory.ParenExpression(lPAREN, expression, rPAREN);
			}
			
			public override GreenNode VisitVarReference(SandyParser.VarReferenceContext context)
			{
				if (context == null) return VarReferenceGreen.__Missing;
				InternalSyntaxToken iD = (InternalSyntaxToken)this.VisitTerminal(context.ID(), SandySyntaxKind.ID);
				return _factory.VarReference(iD);
			}
			
			public override GreenNode VisitMinusExpression(SandyParser.MinusExpressionContext context)
			{
				if (context == null) return MinusExpressionGreen.__Missing;
				InternalSyntaxToken mINUS = (InternalSyntaxToken)this.VisitTerminal(context.MINUS(), SandySyntaxKind.MINUS);
				SandyParser.ExpressionContext expressionContext = context.expression();
				ExpressionGreen expression = null;
				if (expressionContext != null) expression = (ExpressionGreen)this.Visit(expressionContext);
				if (expression == null) expression = ExpressionGreen.__Missing;
				return _factory.MinusExpression(mINUS, expression);
			}
			
			public override GreenNode VisitIntLiteral(SandyParser.IntLiteralContext context)
			{
				if (context == null) return IntLiteralGreen.__Missing;
				InternalSyntaxToken iNTLIT = (InternalSyntaxToken)this.VisitTerminal(context.INTLIT(), SandySyntaxKind.INTLIT);
				return _factory.IntLiteral(iNTLIT);
			}
			
			public override GreenNode VisitDecimalLiteral(SandyParser.DecimalLiteralContext context)
			{
				if (context == null) return DecimalLiteralGreen.__Missing;
				InternalSyntaxToken dECLIT = (InternalSyntaxToken)this.VisitTerminal(context.DECLIT(), SandySyntaxKind.DECLIT);
				return _factory.DecimalLiteral(dECLIT);
			}
			
			public override GreenNode VisitType(SandyParser.TypeContext context)
			{
				if (context == null) return TypeGreen.__Missing;
				InternalSyntaxToken type = null;
				if (context.INT() != null)
				{
					type = (InternalSyntaxToken)this.VisitTerminal(context.INT());
				}
				else 	if (context.DECIMAL() != null)
				{
					type = (InternalSyntaxToken)this.VisitTerminal(context.DECIMAL());
				}
				else
				{
					type = _factory.MissingToken(SandySyntaxKind.MissingToken);
				}
				return _factory.Type(type);
			}
        }
    }
    public partial class SandyParser
    {
		
		internal class MainContext_Cached : MainContext, ICachedRuleContext
		{
		    private GreenNode _cachedNode;
		    public MainContext_Cached(ParserRuleContext parent, int invokingState, GreenNode cachedNode)
				: base(parent, invokingState)
		    {
		        _cachedNode = cachedNode;
		    }
		    public GreenNode CachedNode => _cachedNode;
		}
		
		internal class LineContext_Cached : LineContext, ICachedRuleContext
		{
		    private GreenNode _cachedNode;
		    public LineContext_Cached(ParserRuleContext parent, int invokingState, GreenNode cachedNode)
				: base(parent, invokingState)
		    {
		        _cachedNode = cachedNode;
		    }
		    public GreenNode CachedNode => _cachedNode;
		}
		
		internal class StatementContext_Cached : StatementContext, ICachedRuleContext
		{
		    private GreenNode _cachedNode;
		    public StatementContext_Cached(ParserRuleContext parent, int invokingState, GreenNode cachedNode)
				: base(parent, invokingState)
		    {
		        _cachedNode = cachedNode;
		    }
		    public GreenNode CachedNode => _cachedNode;
		}
		
		internal class PrintContext_Cached : PrintContext, ICachedRuleContext
		{
		    private GreenNode _cachedNode;
		    public PrintContext_Cached(ParserRuleContext parent, int invokingState, GreenNode cachedNode)
				: base(parent, invokingState)
		    {
		        _cachedNode = cachedNode;
		    }
		    public GreenNode CachedNode => _cachedNode;
		}
		
		internal class VarDeclarationContext_Cached : VarDeclarationContext, ICachedRuleContext
		{
		    private GreenNode _cachedNode;
		    public VarDeclarationContext_Cached(ParserRuleContext parent, int invokingState, GreenNode cachedNode)
				: base(parent, invokingState)
		    {
		        _cachedNode = cachedNode;
		    }
		    public GreenNode CachedNode => _cachedNode;
		}
		
		internal class AssignmentContext_Cached : AssignmentContext, ICachedRuleContext
		{
		    private GreenNode _cachedNode;
		    public AssignmentContext_Cached(ParserRuleContext parent, int invokingState, GreenNode cachedNode)
				: base(parent, invokingState)
		    {
		        _cachedNode = cachedNode;
		    }
		    public GreenNode CachedNode => _cachedNode;
		}
		
		internal class ExpressionContext_Cached : ExpressionContext, ICachedRuleContext
		{
		    private GreenNode _cachedNode;
		    public ExpressionContext_Cached(ParserRuleContext parent, int invokingState, GreenNode cachedNode)
				: base(parent, invokingState)
		    {
		        _cachedNode = cachedNode;
		    }
		    public GreenNode CachedNode => _cachedNode;
		}
		
		internal class TypeContext_Cached : TypeContext, ICachedRuleContext
		{
		    private GreenNode _cachedNode;
		    public TypeContext_Cached(ParserRuleContext parent, int invokingState, GreenNode cachedNode)
				: base(parent, invokingState)
		    {
		        _cachedNode = cachedNode;
		    }
		    public GreenNode CachedNode => _cachedNode;
		}
    }
}

