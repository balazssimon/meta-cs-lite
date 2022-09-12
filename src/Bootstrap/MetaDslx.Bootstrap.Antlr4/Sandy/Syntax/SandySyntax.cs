// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// WARNING: This is an auto-generated file. Any manual changes will be lost when the file is regenerated.
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

namespace MetaDslx.Bootstrap.Antlr4.Sandy.Syntax
{
    public abstract class SandySyntaxNode : SyntaxNode
    {
        protected SandySyntaxNode(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
            : base(green, syntaxTree, position)
        {
        }

        protected SandySyntaxNode(InternalSyntaxNode green, SandySyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public override SandyLanguage Language => SandyLanguage.Instance;
        public SandySyntaxKind Kind => (SandySyntaxKind)this.RawKind;
		internal new GreenNode Green => base.Green;

        protected override SyntaxTree CreateSyntaxTreeForRoot()
        {
            return SandySyntaxTree.CreateWithoutClone(this, ParseData.Empty);
        }

        public override TResult Accept<TArg, TResult>(SyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            if (visitor is ISandySyntaxVisitor<TArg, TResult> typedVisitor) return this.Accept(typedVisitor, argument);
            else return visitor.DefaultVisit(this, argument);
        }

        public abstract TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument);

        public override TResult Accept<TResult>(SyntaxVisitor<TResult> visitor)
        {
            if (visitor is ISandySyntaxVisitor<TResult> typedVisitor) return this.Accept(typedVisitor);
            else return visitor.DefaultVisit(this);
        }

        public abstract TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor);

        public override void Accept(SyntaxVisitor visitor)
        {
            if (visitor is ISandySyntaxVisitor typedVisitor) this.Accept(typedVisitor);
            else visitor.DefaultVisit(this);
        }
        public abstract void Accept(ISandySyntaxVisitor visitor);
    }

    /// <summary>
    /// It's a non terminal Trivia SandySyntaxNode that has a tree underneath it.
    /// </summary>
    public abstract partial class SandyStructuredTriviaSyntax : SandySyntaxNode, IStructuredTriviaSyntax
    {
        private SyntaxTrivia _parent;
        internal SandyStructuredTriviaSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
            : base(green, parent == null ? null : (SandySyntaxTree)parent.SyntaxTree, position)
        {
            System.Diagnostics.Debug.Assert(parent == null || position >= 0);
        }
		internal static SandyStructuredTriviaSyntax Create(SyntaxTrivia trivia)
		{
			var red = (SandyStructuredTriviaSyntax)SandyLanguage.Instance.SyntaxFactory.CreateStructure(trivia);
			red._parent = trivia;
			return red;
		}
        /// <summary>
        /// Get parent trivia.
        /// </summary>
        public override SyntaxTrivia ParentTrivia => _parent;
    }

    public sealed partial class SandySkippedTokensTriviaSyntax : SandyStructuredTriviaSyntax
    {
        internal SandySkippedTokensTriviaSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
            : base(green, parent, position)
        {
        }

        public SyntaxTokenList Tokens 
        {
            get
            {
				var slot = ((global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.GreenSkippedTokensTriviaSyntax)this.Green).Tokens;
				if (slot != null)
				{
					return new SyntaxTokenList(this, slot.Node, this.GetChildPosition(0), this.GetChildIndex(0));
				}
                return default;
            }
        }

        protected override SyntaxNode GetNodeSlot(int index)
        {
            switch (index)
            {
                default: return null;
            }
        }

		protected override SyntaxNode GetCachedSlot(int index)
        {
            switch (index)
            {
                default: return null;
            }
        }

		public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
		{
			return visitor.VisitSkippedTokensTrivia(this, argument);
		}

		public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
        {
            return visitor.VisitSkippedTokensTrivia(this);
        }

        public override void Accept(ISandySyntaxVisitor visitor)
        {
            visitor.VisitSkippedTokensTrivia(this);
        }

        public SandySkippedTokensTriviaSyntax Update(SyntaxTokenList tokens)
        {
            if (tokens != this.Tokens)
            {
                var newNode = (SandySkippedTokensTriviaSyntax)Language.SyntaxFactory.SkippedTokensTrivia(tokens);
                var annotations = this.GetAnnotations();
                if (annotations != null && annotations.Length > 0)
                    return newNode.WithAnnotations(annotations);
                return newNode;
            }
            return this;
        }

        public SandySkippedTokensTriviaSyntax WithTokens(SyntaxTokenList tokens)
        {
            return this.Update(tokens);
        }

        public SandySkippedTokensTriviaSyntax AddTokens(params SyntaxToken[] items)
        {
            return this.WithTokens(this.Tokens.AddRange(items));
        }
    }

	
	public sealed class MainSyntax : SandySyntaxNode, ICompilationUnitSyntax
	{
	    private SyntaxNode line;
	
	    public MainSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MainSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public MetaDslx.CodeAnalysis.SyntaxList<LineSyntax> Line 
		{ 
			get
			{
				var red = this.GetRed(ref this.line, 0);
				if (red != null) return new MetaDslx.CodeAnalysis.SyntaxList<LineSyntax>(red);
				return default;
			} 
		}
	    public SyntaxToken EndOfFileToken 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.MainGreen)this.Green;
				var greenToken = green.EndOfFileToken;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this.line, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.line;
				default: return null;
	        }
	    }
	
	    public MainSyntax WithLine(MetaDslx.CodeAnalysis.SyntaxList<LineSyntax> line)
		{
			return this.Update(Line, this.EndOfFileToken);
		}
	
	    public MainSyntax AddLine(params LineSyntax[] line)
		{
			return this.WithLine(this.Line.AddRange(line));
		}
	
	    public MainSyntax WithEndOfFileToken(SyntaxToken eOF)
		{
			return this.Update(this.Line, EndOfFileToken);
		}
	
	    public MainSyntax Update(MetaDslx.CodeAnalysis.SyntaxList<LineSyntax> line, SyntaxToken eOF)
	    {
	        if (this.Line != line ||
				this.EndOfFileToken != eOF)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.Main(line, eOF);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MainSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMain(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMain(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitMain(this);
	    }
	}
	
	public sealed class LineSyntax : SandySyntaxNode
	{
	    private StatementSyntax statement;
	
	    public LineSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public LineSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public StatementSyntax Statement 
		{ 
			get { return this.GetRed(ref this.statement, 0); } 
		}
	    public SyntaxToken NEWLINE 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.LineGreen)this.Green;
				var greenToken = green.NEWLINE;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this.statement, 0);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.statement;
				default: return null;
	        }
	    }
	
	    public LineSyntax WithStatement(StatementSyntax statement)
		{
			return this.Update(Statement, this.NEWLINE);
		}
	
	    public LineSyntax WithNEWLINE(SyntaxToken nEWLINE)
		{
			return this.Update(this.Statement, NEWLINE);
		}
	
	    public LineSyntax Update(StatementSyntax statement, SyntaxToken nEWLINE)
	    {
	        if (this.Statement != statement ||
				this.NEWLINE != nEWLINE)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.Line(statement, nEWLINE);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (LineSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitLine(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitLine(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitLine(this);
	    }
	}
	
	public sealed class StatementSyntax : SandySyntaxNode
	{
	    private VarDeclarationSyntax varDeclaration;
	    private AssignmentSyntax assignment;
	    private PrintSyntax print;
	
	    public StatementSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public StatementSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public VarDeclarationSyntax VarDeclaration 
		{ 
			get { return this.GetRed(ref this.varDeclaration, 0); } 
		}
	    public AssignmentSyntax Assignment 
		{ 
			get { return this.GetRed(ref this.assignment, 1); } 
		}
	    public PrintSyntax Print 
		{ 
			get { return this.GetRed(ref this.print, 2); } 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this.varDeclaration, 0);
				case 1: return this.GetRed(ref this.assignment, 1);
				case 2: return this.GetRed(ref this.print, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.varDeclaration;
				case 1: return this.assignment;
				case 2: return this.print;
				default: return null;
	        }
	    }
	
	    public StatementSyntax WithVarDeclaration(VarDeclarationSyntax varDeclaration)
		{
			return this.Update(varDeclaration);
		}
	
	    public StatementSyntax WithAssignment(AssignmentSyntax assignment)
		{
			return this.Update(assignment);
		}
	
	    public StatementSyntax WithPrint(PrintSyntax print)
		{
			return this.Update(print);
		}
	
	    public StatementSyntax Update(VarDeclarationSyntax varDeclaration)
	    {
	        if (this.VarDeclaration != varDeclaration)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.Statement(varDeclaration);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (StatementSyntax)newNode;
	        }
	        return this;
	    }
	
	    public StatementSyntax Update(AssignmentSyntax assignment)
	    {
	        if (this.Assignment != assignment)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.Statement(assignment);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (StatementSyntax)newNode;
	        }
	        return this;
	    }
	
	    public StatementSyntax Update(PrintSyntax print)
	    {
	        if (this.Print != print)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.Statement(print);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (StatementSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitStatement(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitStatement(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitStatement(this);
	    }
	}
	
	public sealed class PrintSyntax : SandySyntaxNode
	{
	    private ExpressionSyntax expression;
	
	    public PrintSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public PrintSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken PRINT 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.PrintGreen)this.Green;
				var greenToken = green.PRINT;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public SyntaxToken LPAREN 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.PrintGreen)this.Green;
				var greenToken = green.LPAREN;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public ExpressionSyntax Expression 
		{ 
			get { return this.GetRed(ref this.expression, 2); } 
		}
	    public SyntaxToken RPAREN 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.PrintGreen)this.Green;
				var greenToken = green.RPAREN;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(3), this.GetChildIndex(3));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 2: return this.GetRed(ref this.expression, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 2: return this.expression;
				default: return null;
	        }
	    }
	
	    public PrintSyntax WithPRINT(SyntaxToken pRINT)
		{
			return this.Update(PRINT, this.LPAREN, this.Expression, this.RPAREN);
		}
	
	    public PrintSyntax WithLPAREN(SyntaxToken lPAREN)
		{
			return this.Update(this.PRINT, LPAREN, this.Expression, this.RPAREN);
		}
	
	    public PrintSyntax WithExpression(ExpressionSyntax expression)
		{
			return this.Update(this.PRINT, this.LPAREN, Expression, this.RPAREN);
		}
	
	    public PrintSyntax WithRPAREN(SyntaxToken rPAREN)
		{
			return this.Update(this.PRINT, this.LPAREN, this.Expression, RPAREN);
		}
	
	    public PrintSyntax Update(SyntaxToken pRINT, SyntaxToken lPAREN, ExpressionSyntax expression, SyntaxToken rPAREN)
	    {
	        if (this.PRINT != pRINT ||
				this.LPAREN != lPAREN ||
				this.Expression != expression ||
				this.RPAREN != rPAREN)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.Print(pRINT, lPAREN, expression, rPAREN);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (PrintSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitPrint(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitPrint(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitPrint(this);
	    }
	}
	
	public sealed class VarDeclarationSyntax : SandySyntaxNode
	{
	    private AssignmentSyntax assignment;
	
	    public VarDeclarationSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public VarDeclarationSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken VAR 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.VarDeclarationGreen)this.Green;
				var greenToken = green.VAR;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public AssignmentSyntax Assignment 
		{ 
			get { return this.GetRed(ref this.assignment, 1); } 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this.assignment, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.assignment;
				default: return null;
	        }
	    }
	
	    public VarDeclarationSyntax WithVAR(SyntaxToken vAR)
		{
			return this.Update(VAR, this.Assignment);
		}
	
	    public VarDeclarationSyntax WithAssignment(AssignmentSyntax assignment)
		{
			return this.Update(this.VAR, Assignment);
		}
	
	    public VarDeclarationSyntax Update(SyntaxToken vAR, AssignmentSyntax assignment)
	    {
	        if (this.VAR != vAR ||
				this.Assignment != assignment)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.VarDeclaration(vAR, assignment);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (VarDeclarationSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitVarDeclaration(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitVarDeclaration(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitVarDeclaration(this);
	    }
	}
	
	public sealed class AssignmentSyntax : SandySyntaxNode
	{
	    private ExpressionSyntax expression;
	
	    public AssignmentSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public AssignmentSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken ID 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.AssignmentGreen)this.Green;
				var greenToken = green.ID;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public SyntaxToken ASSIGN 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.AssignmentGreen)this.Green;
				var greenToken = green.ASSIGN;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public ExpressionSyntax Expression 
		{ 
			get { return this.GetRed(ref this.expression, 2); } 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 2: return this.GetRed(ref this.expression, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 2: return this.expression;
				default: return null;
	        }
	    }
	
	    public AssignmentSyntax WithID(SyntaxToken iD)
		{
			return this.Update(ID, this.ASSIGN, this.Expression);
		}
	
	    public AssignmentSyntax WithASSIGN(SyntaxToken aSSIGN)
		{
			return this.Update(this.ID, ASSIGN, this.Expression);
		}
	
	    public AssignmentSyntax WithExpression(ExpressionSyntax expression)
		{
			return this.Update(this.ID, this.ASSIGN, Expression);
		}
	
	    public AssignmentSyntax Update(SyntaxToken iD, SyntaxToken aSSIGN, ExpressionSyntax expression)
	    {
	        if (this.ID != iD ||
				this.ASSIGN != aSSIGN ||
				this.Expression != expression)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.Assignment(iD, aSSIGN, expression);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (AssignmentSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitAssignment(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitAssignment(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitAssignment(this);
	    }
	}
	
	public abstract class ExpressionSyntax : SandySyntaxNode
	{
	    protected ExpressionSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    protected ExpressionSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	}
	
	public sealed class BinaryMulOperationSyntax : ExpressionSyntax
	{
	    private ExpressionSyntax left;
	    private ExpressionSyntax right;
	
	    public BinaryMulOperationSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BinaryMulOperationSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public ExpressionSyntax Left 
		{ 
			get { return this.GetRed(ref this.left, 0); } 
		}
	    public SyntaxToken Op 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.BinaryMulOperationGreen)this.Green;
				var greenToken = green.Op;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public ExpressionSyntax Right 
		{ 
			get { return this.GetRed(ref this.right, 2); } 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this.left, 0);
				case 2: return this.GetRed(ref this.right, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.left;
				case 2: return this.right;
				default: return null;
	        }
	    }
	
	    public BinaryMulOperationSyntax WithLeft(ExpressionSyntax left)
		{
			return this.Update(Left, this.Op, this.Right);
		}
	
	    public BinaryMulOperationSyntax WithOp(SyntaxToken op)
		{
			return this.Update(this.Left, Op, this.Right);
		}
	
	    public BinaryMulOperationSyntax WithRight(ExpressionSyntax right)
		{
			return this.Update(this.Left, this.Op, Right);
		}
	
	    public BinaryMulOperationSyntax Update(ExpressionSyntax left, SyntaxToken op, ExpressionSyntax right)
	    {
	        if (this.Left != left ||
				this.Op != op ||
				this.Right != right)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.BinaryMulOperation(left, op, right);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (BinaryMulOperationSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBinaryMulOperation(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBinaryMulOperation(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitBinaryMulOperation(this);
	    }
	}
	
	public sealed class BinaryAddOperationSyntax : ExpressionSyntax
	{
	    private ExpressionSyntax left;
	    private ExpressionSyntax right;
	
	    public BinaryAddOperationSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public BinaryAddOperationSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public ExpressionSyntax Left 
		{ 
			get { return this.GetRed(ref this.left, 0); } 
		}
	    public SyntaxToken Op 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.BinaryAddOperationGreen)this.Green;
				var greenToken = green.Op;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public ExpressionSyntax Right 
		{ 
			get { return this.GetRed(ref this.right, 2); } 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this.left, 0);
				case 2: return this.GetRed(ref this.right, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.left;
				case 2: return this.right;
				default: return null;
	        }
	    }
	
	    public BinaryAddOperationSyntax WithLeft(ExpressionSyntax left)
		{
			return this.Update(Left, this.Op, this.Right);
		}
	
	    public BinaryAddOperationSyntax WithOp(SyntaxToken op)
		{
			return this.Update(this.Left, Op, this.Right);
		}
	
	    public BinaryAddOperationSyntax WithRight(ExpressionSyntax right)
		{
			return this.Update(this.Left, this.Op, Right);
		}
	
	    public BinaryAddOperationSyntax Update(ExpressionSyntax left, SyntaxToken op, ExpressionSyntax right)
	    {
	        if (this.Left != left ||
				this.Op != op ||
				this.Right != right)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.BinaryAddOperation(left, op, right);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (BinaryAddOperationSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitBinaryAddOperation(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitBinaryAddOperation(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitBinaryAddOperation(this);
	    }
	}
	
	public sealed class TypeConversionSyntax : ExpressionSyntax
	{
	    private ExpressionSyntax value;
	    private TypeSyntax targetType;
	
	    public TypeConversionSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TypeConversionSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public ExpressionSyntax Value 
		{ 
			get { return this.GetRed(ref this.value, 0); } 
		}
	    public SyntaxToken AS 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.TypeConversionGreen)this.Green;
				var greenToken = green.AS;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(1), this.GetChildIndex(1));
			}
		}
	    public TypeSyntax TargetType 
		{ 
			get { return this.GetRed(ref this.targetType, 2); } 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.GetRed(ref this.value, 0);
				case 2: return this.GetRed(ref this.targetType, 2);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 0: return this.value;
				case 2: return this.targetType;
				default: return null;
	        }
	    }
	
	    public TypeConversionSyntax WithValue(ExpressionSyntax value)
		{
			return this.Update(Value, this.AS, this.TargetType);
		}
	
	    public TypeConversionSyntax WithAS(SyntaxToken aS)
		{
			return this.Update(this.Value, AS, this.TargetType);
		}
	
	    public TypeConversionSyntax WithTargetType(TypeSyntax targetType)
		{
			return this.Update(this.Value, this.AS, TargetType);
		}
	
	    public TypeConversionSyntax Update(ExpressionSyntax value, SyntaxToken aS, TypeSyntax targetType)
	    {
	        if (this.Value != value ||
				this.AS != aS ||
				this.TargetType != targetType)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.TypeConversion(value, aS, targetType);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (TypeConversionSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitTypeConversion(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitTypeConversion(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitTypeConversion(this);
	    }
	}
	
	public sealed class ParenExpressionSyntax : ExpressionSyntax
	{
	    private ExpressionSyntax expression;
	
	    public ParenExpressionSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public ParenExpressionSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken LPAREN 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.ParenExpressionGreen)this.Green;
				var greenToken = green.LPAREN;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public ExpressionSyntax Expression 
		{ 
			get { return this.GetRed(ref this.expression, 1); } 
		}
	    public SyntaxToken RPAREN 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.ParenExpressionGreen)this.Green;
				var greenToken = green.RPAREN;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(2), this.GetChildIndex(2));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this.expression, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.expression;
				default: return null;
	        }
	    }
	
	    public ParenExpressionSyntax WithLPAREN(SyntaxToken lPAREN)
		{
			return this.Update(LPAREN, this.Expression, this.RPAREN);
		}
	
	    public ParenExpressionSyntax WithExpression(ExpressionSyntax expression)
		{
			return this.Update(this.LPAREN, Expression, this.RPAREN);
		}
	
	    public ParenExpressionSyntax WithRPAREN(SyntaxToken rPAREN)
		{
			return this.Update(this.LPAREN, this.Expression, RPAREN);
		}
	
	    public ParenExpressionSyntax Update(SyntaxToken lPAREN, ExpressionSyntax expression, SyntaxToken rPAREN)
	    {
	        if (this.LPAREN != lPAREN ||
				this.Expression != expression ||
				this.RPAREN != rPAREN)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.ParenExpression(lPAREN, expression, rPAREN);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (ParenExpressionSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitParenExpression(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitParenExpression(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitParenExpression(this);
	    }
	}
	
	public sealed class VarReferenceSyntax : ExpressionSyntax
	{
	
	    public VarReferenceSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public VarReferenceSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken ID 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.VarReferenceGreen)this.Green;
				var greenToken = green.ID;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public VarReferenceSyntax WithID(SyntaxToken iD)
		{
			return this.Update(ID);
		}
	
	    public VarReferenceSyntax Update(SyntaxToken iD)
	    {
	        if (this.ID != iD)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.VarReference(iD);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (VarReferenceSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitVarReference(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitVarReference(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitVarReference(this);
	    }
	}
	
	public sealed class MinusExpressionSyntax : ExpressionSyntax
	{
	    private ExpressionSyntax expression;
	
	    public MinusExpressionSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public MinusExpressionSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken MINUS 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.MinusExpressionGreen)this.Green;
				var greenToken = green.MINUS;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	    public ExpressionSyntax Expression 
		{ 
			get { return this.GetRed(ref this.expression, 1); } 
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.GetRed(ref this.expression, 1);
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				case 1: return this.expression;
				default: return null;
	        }
	    }
	
	    public MinusExpressionSyntax WithMINUS(SyntaxToken mINUS)
		{
			return this.Update(MINUS, this.Expression);
		}
	
	    public MinusExpressionSyntax WithExpression(ExpressionSyntax expression)
		{
			return this.Update(this.MINUS, Expression);
		}
	
	    public MinusExpressionSyntax Update(SyntaxToken mINUS, ExpressionSyntax expression)
	    {
	        if (this.MINUS != mINUS ||
				this.Expression != expression)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.MinusExpression(mINUS, expression);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (MinusExpressionSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitMinusExpression(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitMinusExpression(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitMinusExpression(this);
	    }
	}
	
	public sealed class IntLiteralSyntax : ExpressionSyntax
	{
	
	    public IntLiteralSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public IntLiteralSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken INTLIT 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.IntLiteralGreen)this.Green;
				var greenToken = green.INTLIT;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public IntLiteralSyntax WithINTLIT(SyntaxToken iNTLIT)
		{
			return this.Update(INTLIT);
		}
	
	    public IntLiteralSyntax Update(SyntaxToken iNTLIT)
	    {
	        if (this.INTLIT != iNTLIT)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.IntLiteral(iNTLIT);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (IntLiteralSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitIntLiteral(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitIntLiteral(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitIntLiteral(this);
	    }
	}
	
	public sealed class DecimalLiteralSyntax : ExpressionSyntax
	{
	
	    public DecimalLiteralSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public DecimalLiteralSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken DECLIT 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.DecimalLiteralGreen)this.Green;
				var greenToken = green.DECLIT;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public DecimalLiteralSyntax WithDECLIT(SyntaxToken dECLIT)
		{
			return this.Update(DECLIT);
		}
	
	    public DecimalLiteralSyntax Update(SyntaxToken dECLIT)
	    {
	        if (this.DECLIT != dECLIT)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.DecimalLiteral(dECLIT);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (DecimalLiteralSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitDecimalLiteral(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitDecimalLiteral(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitDecimalLiteral(this);
	    }
	}
	
	public sealed class TypeSyntax : SandySyntaxNode
	{
	
	    public TypeSyntax(InternalSyntaxNode green, SandySyntaxTree syntaxTree, int position)
	        : base(green, syntaxTree, position)
	    {
	    }
	
	    public TypeSyntax(InternalSyntaxNode green, SandySyntaxNode parent, int position)
	        : base(green, parent, position)
	    {
	    }
	
	    public SyntaxToken Type 
		{ 
			get 
			{ 
				var green = (global::MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.TypeGreen)this.Green;
				var greenToken = green.Type;
				return new SyntaxToken(this, greenToken, this.GetChildPosition(0), this.GetChildIndex(0));
			}
		}
	
	    protected override SyntaxNode GetNodeSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    protected override SyntaxNode GetCachedSlot(int index)
	    {
	        switch (index)
	        {
				default: return null;
	        }
	    }
	
	    public TypeSyntax WithType(SyntaxToken type)
		{
			return this.Update(Type);
		}
	
	    public TypeSyntax Update(SyntaxToken type)
	    {
	        if (this.Type != type)
	        {
	            var newNode = SandyLanguage.Instance.SyntaxFactory.Type(type);
	            var annotations = this.GetAnnotations();
	            if (annotations != null && annotations.Length > 0)
	               newNode = newNode.WithAnnotations(annotations);
				return (TypeSyntax)newNode;
	        }
	        return this;
	    }
	
	    public override TResult Accept<TArg, TResult>(ISandySyntaxVisitor<TArg, TResult> visitor, TArg argument)
	    {
	        return visitor.VisitType(this, argument);
	    }
	
	    public override TResult Accept<TResult>(ISandySyntaxVisitor<TResult> visitor)
	    {
	        return visitor.VisitType(this);
	    }
	
	    public override void Accept(ISandySyntaxVisitor visitor)
	    {
	        visitor.VisitType(this);
	    }
	}
}

namespace MetaDslx.Bootstrap.Antlr4.Sandy.Syntax
{
    using System.Threading;
    using MetaDslx.CodeAnalysis.Text;
    using MetaDslx.Bootstrap.Antlr4.Sandy;
	using MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax;

	public interface ISandySyntaxVisitor
	{
	    void VisitSkippedTokensTrivia(SandySkippedTokensTriviaSyntax node);
		
		void VisitMain(MainSyntax node);
		
		void VisitLine(LineSyntax node);
		
		void VisitStatement(StatementSyntax node);
		
		void VisitPrint(PrintSyntax node);
		
		void VisitVarDeclaration(VarDeclarationSyntax node);
		
		void VisitAssignment(AssignmentSyntax node);
		
		void VisitBinaryMulOperation(BinaryMulOperationSyntax node);
		
		void VisitBinaryAddOperation(BinaryAddOperationSyntax node);
		
		void VisitTypeConversion(TypeConversionSyntax node);
		
		void VisitParenExpression(ParenExpressionSyntax node);
		
		void VisitVarReference(VarReferenceSyntax node);
		
		void VisitMinusExpression(MinusExpressionSyntax node);
		
		void VisitIntLiteral(IntLiteralSyntax node);
		
		void VisitDecimalLiteral(DecimalLiteralSyntax node);
		
		void VisitType(TypeSyntax node);
	}
	
	public class SandySyntaxVisitor : SyntaxVisitor, ISandySyntaxVisitor
	{
	    public virtual void VisitSkippedTokensTrivia(SandySkippedTokensTriviaSyntax node)
	    {
	        this.DefaultVisit(node);
	    }
		
		public virtual void VisitMain(MainSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitLine(LineSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitStatement(StatementSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitPrint(PrintSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitVarDeclaration(VarDeclarationSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitAssignment(AssignmentSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitBinaryMulOperation(BinaryMulOperationSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitBinaryAddOperation(BinaryAddOperationSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitTypeConversion(TypeConversionSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitParenExpression(ParenExpressionSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitVarReference(VarReferenceSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitMinusExpression(MinusExpressionSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitIntLiteral(IntLiteralSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitDecimalLiteral(DecimalLiteralSyntax node)
		{
		    this.DefaultVisit(node);
		}
		
		public virtual void VisitType(TypeSyntax node)
		{
		    this.DefaultVisit(node);
		}
	}

	//GenerateDetailedSyntaxVisitor()

	public interface ISandySyntaxVisitor<TArg, TResult> 
	{
	    TResult VisitSkippedTokensTrivia(SandySkippedTokensTriviaSyntax node, TArg argument);
		
		TResult VisitMain(MainSyntax node, TArg argument);
		
		TResult VisitLine(LineSyntax node, TArg argument);
		
		TResult VisitStatement(StatementSyntax node, TArg argument);
		
		TResult VisitPrint(PrintSyntax node, TArg argument);
		
		TResult VisitVarDeclaration(VarDeclarationSyntax node, TArg argument);
		
		TResult VisitAssignment(AssignmentSyntax node, TArg argument);
		
		TResult VisitBinaryMulOperation(BinaryMulOperationSyntax node, TArg argument);
		
		TResult VisitBinaryAddOperation(BinaryAddOperationSyntax node, TArg argument);
		
		TResult VisitTypeConversion(TypeConversionSyntax node, TArg argument);
		
		TResult VisitParenExpression(ParenExpressionSyntax node, TArg argument);
		
		TResult VisitVarReference(VarReferenceSyntax node, TArg argument);
		
		TResult VisitMinusExpression(MinusExpressionSyntax node, TArg argument);
		
		TResult VisitIntLiteral(IntLiteralSyntax node, TArg argument);
		
		TResult VisitDecimalLiteral(DecimalLiteralSyntax node, TArg argument);
		
		TResult VisitType(TypeSyntax node, TArg argument);
	}
	
	public class SandySyntaxVisitor<TArg, TResult> : SyntaxVisitor<TArg, TResult>, ISandySyntaxVisitor<TArg, TResult>
	{
	    public virtual TResult VisitSkippedTokensTrivia(SandySkippedTokensTriviaSyntax node, TArg argument)
	    {
	        return this.DefaultVisit(node, argument);
	    }
		
		public virtual TResult VisitMain(MainSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitLine(LineSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitStatement(StatementSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitPrint(PrintSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitVarDeclaration(VarDeclarationSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitAssignment(AssignmentSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitBinaryMulOperation(BinaryMulOperationSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitBinaryAddOperation(BinaryAddOperationSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitTypeConversion(TypeConversionSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitParenExpression(ParenExpressionSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitVarReference(VarReferenceSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitMinusExpression(MinusExpressionSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitIntLiteral(IntLiteralSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitDecimalLiteral(DecimalLiteralSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
		
		public virtual TResult VisitType(TypeSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
	}

	public interface ISandySyntaxVisitor<TResult> 
	{
	    TResult VisitSkippedTokensTrivia(SandySkippedTokensTriviaSyntax node);
		
		TResult VisitMain(MainSyntax node);
		
		TResult VisitLine(LineSyntax node);
		
		TResult VisitStatement(StatementSyntax node);
		
		TResult VisitPrint(PrintSyntax node);
		
		TResult VisitVarDeclaration(VarDeclarationSyntax node);
		
		TResult VisitAssignment(AssignmentSyntax node);
		
		TResult VisitBinaryMulOperation(BinaryMulOperationSyntax node);
		
		TResult VisitBinaryAddOperation(BinaryAddOperationSyntax node);
		
		TResult VisitTypeConversion(TypeConversionSyntax node);
		
		TResult VisitParenExpression(ParenExpressionSyntax node);
		
		TResult VisitVarReference(VarReferenceSyntax node);
		
		TResult VisitMinusExpression(MinusExpressionSyntax node);
		
		TResult VisitIntLiteral(IntLiteralSyntax node);
		
		TResult VisitDecimalLiteral(DecimalLiteralSyntax node);
		
		TResult VisitType(TypeSyntax node);
	}
	
	public class SandySyntaxVisitor<TResult> : SyntaxVisitor<TResult>, ISandySyntaxVisitor<TResult>
	{
	    public virtual TResult VisitSkippedTokensTrivia(SandySkippedTokensTriviaSyntax node)
	    {
	        return this.DefaultVisit(node);
	    }
		
		public virtual TResult VisitMain(MainSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitLine(LineSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitStatement(StatementSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitPrint(PrintSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitVarDeclaration(VarDeclarationSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitAssignment(AssignmentSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitBinaryMulOperation(BinaryMulOperationSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitBinaryAddOperation(BinaryAddOperationSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitTypeConversion(TypeConversionSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitParenExpression(ParenExpressionSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitVarReference(VarReferenceSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitMinusExpression(MinusExpressionSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitIntLiteral(IntLiteralSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitDecimalLiteral(DecimalLiteralSyntax node)
		{
		    return this.DefaultVisit(node);
		}
		
		public virtual TResult VisitType(TypeSyntax node)
		{
		    return this.DefaultVisit(node);
		}
	}

	public class SandySyntaxRewriter : SyntaxRewriter, ISandySyntaxVisitor<SyntaxNode>
	{
	    public SandySyntaxRewriter(bool visitIntoStructuredTrivia = false)
			: base(SandyLanguage.Instance, visitIntoStructuredTrivia)
	    {
	    }
	
	    public virtual SyntaxNode VisitSkippedTokensTrivia(SandySkippedTokensTriviaSyntax node)
	    {
	      var tokens = this.VisitList(node.Tokens);
	      return node.Update(tokens);
	    }
		
		public virtual SyntaxNode VisitMain(MainSyntax node)
		{
		    var line = this.VisitList(node.Line);
		    var eOF = this.VisitToken(node.EndOfFileToken);
			return node.Update(line, eOF);
		}
		
		public virtual SyntaxNode VisitLine(LineSyntax node)
		{
		    var statement = (StatementSyntax)this.Visit(node.Statement);
		    var nEWLINE = this.VisitToken(node.NEWLINE);
			return node.Update(statement, nEWLINE);
		}
		
		public virtual SyntaxNode VisitStatement(StatementSyntax node)
		{
			var oldVarDeclaration = node.VarDeclaration;
			if (oldVarDeclaration != null)
			{
			    var newVarDeclaration = (VarDeclarationSyntax)this.Visit(oldVarDeclaration);
				return node.Update(newVarDeclaration);
			}
			var oldAssignment = node.Assignment;
			if (oldAssignment != null)
			{
			    var newAssignment = (AssignmentSyntax)this.Visit(oldAssignment);
				return node.Update(newAssignment);
			}
			var oldPrint = node.Print;
			if (oldPrint != null)
			{
			    var newPrint = (PrintSyntax)this.Visit(oldPrint);
				return node.Update(newPrint);
			}
			return node;   
		}
		
		public virtual SyntaxNode VisitPrint(PrintSyntax node)
		{
		    var pRINT = this.VisitToken(node.PRINT);
		    var lPAREN = this.VisitToken(node.LPAREN);
		    var expression = (ExpressionSyntax)this.Visit(node.Expression);
		    var rPAREN = this.VisitToken(node.RPAREN);
			return node.Update(pRINT, lPAREN, expression, rPAREN);
		}
		
		public virtual SyntaxNode VisitVarDeclaration(VarDeclarationSyntax node)
		{
		    var vAR = this.VisitToken(node.VAR);
		    var assignment = (AssignmentSyntax)this.Visit(node.Assignment);
			return node.Update(vAR, assignment);
		}
		
		public virtual SyntaxNode VisitAssignment(AssignmentSyntax node)
		{
		    var iD = this.VisitToken(node.ID);
		    var aSSIGN = this.VisitToken(node.ASSIGN);
		    var expression = (ExpressionSyntax)this.Visit(node.Expression);
			return node.Update(iD, aSSIGN, expression);
		}
		
		public virtual SyntaxNode VisitBinaryMulOperation(BinaryMulOperationSyntax node)
		{
		    var left = (ExpressionSyntax)this.Visit(node.Left);
		    var op = this.VisitToken(node.Op);
		    var right = (ExpressionSyntax)this.Visit(node.Right);
			return node.Update(left, op, right);
		}
		
		public virtual SyntaxNode VisitBinaryAddOperation(BinaryAddOperationSyntax node)
		{
		    var left = (ExpressionSyntax)this.Visit(node.Left);
		    var op = this.VisitToken(node.Op);
		    var right = (ExpressionSyntax)this.Visit(node.Right);
			return node.Update(left, op, right);
		}
		
		public virtual SyntaxNode VisitTypeConversion(TypeConversionSyntax node)
		{
		    var value = (ExpressionSyntax)this.Visit(node.Value);
		    var aS = this.VisitToken(node.AS);
		    var targetType = (TypeSyntax)this.Visit(node.TargetType);
			return node.Update(value, aS, targetType);
		}
		
		public virtual SyntaxNode VisitParenExpression(ParenExpressionSyntax node)
		{
		    var lPAREN = this.VisitToken(node.LPAREN);
		    var expression = (ExpressionSyntax)this.Visit(node.Expression);
		    var rPAREN = this.VisitToken(node.RPAREN);
			return node.Update(lPAREN, expression, rPAREN);
		}
		
		public virtual SyntaxNode VisitVarReference(VarReferenceSyntax node)
		{
		    var iD = this.VisitToken(node.ID);
			return node.Update(iD);
		}
		
		public virtual SyntaxNode VisitMinusExpression(MinusExpressionSyntax node)
		{
		    var mINUS = this.VisitToken(node.MINUS);
		    var expression = (ExpressionSyntax)this.Visit(node.Expression);
			return node.Update(mINUS, expression);
		}
		
		public virtual SyntaxNode VisitIntLiteral(IntLiteralSyntax node)
		{
		    var iNTLIT = this.VisitToken(node.INTLIT);
			return node.Update(iNTLIT);
		}
		
		public virtual SyntaxNode VisitDecimalLiteral(DecimalLiteralSyntax node)
		{
		    var dECLIT = this.VisitToken(node.DECLIT);
			return node.Update(dECLIT);
		}
		
		public virtual SyntaxNode VisitType(TypeSyntax node)
		{
		    var type = this.VisitToken(node.Type);
			return node.Update(type);
		}
	}

	public class SandySyntaxFactory : SyntaxFactory
	{
		internal SandySyntaxFactory(SandyInternalSyntaxFactory internalSyntaxFactory) 
			: base(internalSyntaxFactory)
		{
		}
	    public override SandyLanguage Language => SandyLanguage.Instance;
	    public override SandyParseOptions DefaultParseOptions => SandyParseOptions.Default;
		/// <summary>
		/// Create a new syntax tree from a syntax node.
		/// </summary>
		public SandySyntaxTree SyntaxTree(SyntaxNode root, SandyParseOptions? options = null, string? path = "", Encoding? encoding = null)
		{
			return SandySyntaxTree.Create((SandySyntaxNode)root, ParseData.Empty, options, path, null, encoding);
		}
		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public SandySyntaxTree ParseSyntaxTree(
			string text,
			SandyParseOptions options = null,
			string path = "",
			Encoding encoding = null,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return (SandySyntaxTree)this.ParseSyntaxTreeCore(SourceText.From(text, encoding), options, path, cancellationToken);
		}
		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public SandySyntaxTree ParseSyntaxTree(
			SourceText text,
			SandyParseOptions? options = null,
			string path = "",
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return (SandySyntaxTree)this.ParseSyntaxTreeCore(text, options, path, cancellationToken);
		}

		protected override SyntaxTree ParseSyntaxTreeCore(
			SourceText text,
			ParseOptions? options = null,
			string path = "",
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return SandySyntaxTree.ParseText(text, (SandyParseOptions?)options, path, cancellationToken);
		}
	
		public override SandySyntaxTree MakeSyntaxTree(SyntaxNode root, ParseOptions? options = null, string path = "", Encoding? encoding = null)
		{
			return SandySyntaxTree.Create((SandySyntaxNode)root, ParseData.Empty, (SandyParseOptions)options, path, null, encoding);
		}
	
		public SyntaxToken Token(SandySyntaxKind kind)
        {
			return base.Token((int)kind);
        }

	    public SyntaxToken NEWLINE(string text)
	    {
	        return new SyntaxToken(SandyLanguage.Instance.InternalSyntaxFactory.NEWLINE(text));
	    }
	
	    public SyntaxToken NEWLINE(string text, object value)
	    {
	        return new SyntaxToken(SandyLanguage.Instance.InternalSyntaxFactory.NEWLINE(text, value));
	    }
	
	    public SyntaxToken WS(string text)
	    {
	        return new SyntaxToken(SandyLanguage.Instance.InternalSyntaxFactory.WS(text));
	    }
	
	    public SyntaxToken WS(string text, object value)
	    {
	        return new SyntaxToken(SandyLanguage.Instance.InternalSyntaxFactory.WS(text, value));
	    }
	
	    public SyntaxToken INTLIT(string text)
	    {
	        return new SyntaxToken(SandyLanguage.Instance.InternalSyntaxFactory.INTLIT(text));
	    }
	
	    public SyntaxToken INTLIT(string text, object value)
	    {
	        return new SyntaxToken(SandyLanguage.Instance.InternalSyntaxFactory.INTLIT(text, value));
	    }
	
	    public SyntaxToken DECLIT(string text)
	    {
	        return new SyntaxToken(SandyLanguage.Instance.InternalSyntaxFactory.DECLIT(text));
	    }
	
	    public SyntaxToken DECLIT(string text, object value)
	    {
	        return new SyntaxToken(SandyLanguage.Instance.InternalSyntaxFactory.DECLIT(text, value));
	    }
	
	    public SyntaxToken ID(string text)
	    {
	        return new SyntaxToken(SandyLanguage.Instance.InternalSyntaxFactory.ID(text));
	    }
	
	    public SyntaxToken ID(string text, object value)
	    {
	        return new SyntaxToken(SandyLanguage.Instance.InternalSyntaxFactory.ID(text, value));
	    }
		
		public MainSyntax Main(MetaDslx.CodeAnalysis.SyntaxList<LineSyntax> line, SyntaxToken eOF)
		{
		    if (eOF == null) throw new ArgumentNullException(nameof(eOF));
		    if (eOF.RawKind != (int)SandySyntaxKind.Eof) throw new ArgumentException(nameof(eOF));
		    return (MainSyntax)SandyLanguage.Instance.InternalSyntaxFactory.Main(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.GreenNodeExtensions.ToGreenList<LineGreen>(line.Node), (InternalSyntaxToken)eOF.Node).CreateRed();
		}
		
		public MainSyntax Main(SyntaxToken eOF)
		{
			return this.Main(default, eOF);
		}
		
		public LineSyntax Line(StatementSyntax statement, SyntaxToken nEWLINE)
		{
		    if (statement == null) throw new ArgumentNullException(nameof(statement));
		    if (nEWLINE == null) throw new ArgumentNullException(nameof(nEWLINE));
		    if (nEWLINE.RawKind != (int)SandySyntaxKind.NEWLINE) throw new ArgumentException(nameof(nEWLINE));
		    return (LineSyntax)SandyLanguage.Instance.InternalSyntaxFactory.Line((Syntax.InternalSyntax.StatementGreen)statement.Green, (InternalSyntaxToken)nEWLINE.Node).CreateRed();
		}
		
		public StatementSyntax Statement(VarDeclarationSyntax varDeclaration)
		{
		    if (varDeclaration == null) throw new ArgumentNullException(nameof(varDeclaration));
		    return (StatementSyntax)SandyLanguage.Instance.InternalSyntaxFactory.Statement((Syntax.InternalSyntax.VarDeclarationGreen)varDeclaration.Green).CreateRed();
		}
		
		public StatementSyntax Statement(AssignmentSyntax assignment)
		{
		    if (assignment == null) throw new ArgumentNullException(nameof(assignment));
		    return (StatementSyntax)SandyLanguage.Instance.InternalSyntaxFactory.Statement((Syntax.InternalSyntax.AssignmentGreen)assignment.Green).CreateRed();
		}
		
		public StatementSyntax Statement(PrintSyntax print)
		{
		    if (print == null) throw new ArgumentNullException(nameof(print));
		    return (StatementSyntax)SandyLanguage.Instance.InternalSyntaxFactory.Statement((Syntax.InternalSyntax.PrintGreen)print.Green).CreateRed();
		}
		
		public PrintSyntax Print(SyntaxToken pRINT, SyntaxToken lPAREN, ExpressionSyntax expression, SyntaxToken rPAREN)
		{
		    if (pRINT == null) throw new ArgumentNullException(nameof(pRINT));
		    if (pRINT.RawKind != (int)SandySyntaxKind.PRINT) throw new ArgumentException(nameof(pRINT));
		    if (lPAREN == null) throw new ArgumentNullException(nameof(lPAREN));
		    if (lPAREN.RawKind != (int)SandySyntaxKind.LPAREN) throw new ArgumentException(nameof(lPAREN));
		    if (expression == null) throw new ArgumentNullException(nameof(expression));
		    if (rPAREN == null) throw new ArgumentNullException(nameof(rPAREN));
		    if (rPAREN.RawKind != (int)SandySyntaxKind.RPAREN) throw new ArgumentException(nameof(rPAREN));
		    return (PrintSyntax)SandyLanguage.Instance.InternalSyntaxFactory.Print((InternalSyntaxToken)pRINT.Node, (InternalSyntaxToken)lPAREN.Node, (Syntax.InternalSyntax.ExpressionGreen)expression.Green, (InternalSyntaxToken)rPAREN.Node).CreateRed();
		}
		
		public PrintSyntax Print(ExpressionSyntax expression)
		{
			return this.Print(this.Token(SandySyntaxKind.PRINT), this.Token(SandySyntaxKind.LPAREN), expression, this.Token(SandySyntaxKind.RPAREN));
		}
		
		public VarDeclarationSyntax VarDeclaration(SyntaxToken vAR, AssignmentSyntax assignment)
		{
		    if (vAR == null) throw new ArgumentNullException(nameof(vAR));
		    if (vAR.RawKind != (int)SandySyntaxKind.VAR) throw new ArgumentException(nameof(vAR));
		    if (assignment == null) throw new ArgumentNullException(nameof(assignment));
		    return (VarDeclarationSyntax)SandyLanguage.Instance.InternalSyntaxFactory.VarDeclaration((InternalSyntaxToken)vAR.Node, (Syntax.InternalSyntax.AssignmentGreen)assignment.Green).CreateRed();
		}
		
		public VarDeclarationSyntax VarDeclaration(AssignmentSyntax assignment)
		{
			return this.VarDeclaration(this.Token(SandySyntaxKind.VAR), assignment);
		}
		
		public AssignmentSyntax Assignment(SyntaxToken iD, SyntaxToken aSSIGN, ExpressionSyntax expression)
		{
		    if (iD == null) throw new ArgumentNullException(nameof(iD));
		    if (iD.RawKind != (int)SandySyntaxKind.ID) throw new ArgumentException(nameof(iD));
		    if (aSSIGN == null) throw new ArgumentNullException(nameof(aSSIGN));
		    if (aSSIGN.RawKind != (int)SandySyntaxKind.ASSIGN) throw new ArgumentException(nameof(aSSIGN));
		    if (expression == null) throw new ArgumentNullException(nameof(expression));
		    return (AssignmentSyntax)SandyLanguage.Instance.InternalSyntaxFactory.Assignment((InternalSyntaxToken)iD.Node, (InternalSyntaxToken)aSSIGN.Node, (Syntax.InternalSyntax.ExpressionGreen)expression.Green).CreateRed();
		}
		
		public AssignmentSyntax Assignment(SyntaxToken iD, ExpressionSyntax expression)
		{
			return this.Assignment(iD, this.Token(SandySyntaxKind.ASSIGN), expression);
		}
		
		public BinaryMulOperationSyntax BinaryMulOperation(ExpressionSyntax left, SyntaxToken op, ExpressionSyntax right)
		{
		    if (left == null) throw new ArgumentNullException(nameof(left));
		    if (op == null) throw new ArgumentNullException(nameof(op));
		    if (right == null) throw new ArgumentNullException(nameof(right));
		    return (BinaryMulOperationSyntax)SandyLanguage.Instance.InternalSyntaxFactory.BinaryMulOperation((Syntax.InternalSyntax.ExpressionGreen)left.Green, (InternalSyntaxToken)op.Node, (Syntax.InternalSyntax.ExpressionGreen)right.Green).CreateRed();
		}
		
		public BinaryAddOperationSyntax BinaryAddOperation(ExpressionSyntax left, SyntaxToken op, ExpressionSyntax right)
		{
		    if (left == null) throw new ArgumentNullException(nameof(left));
		    if (op == null) throw new ArgumentNullException(nameof(op));
		    if (right == null) throw new ArgumentNullException(nameof(right));
		    return (BinaryAddOperationSyntax)SandyLanguage.Instance.InternalSyntaxFactory.BinaryAddOperation((Syntax.InternalSyntax.ExpressionGreen)left.Green, (InternalSyntaxToken)op.Node, (Syntax.InternalSyntax.ExpressionGreen)right.Green).CreateRed();
		}
		
		public TypeConversionSyntax TypeConversion(ExpressionSyntax value, SyntaxToken aS, TypeSyntax targetType)
		{
		    if (value == null) throw new ArgumentNullException(nameof(value));
		    if (aS == null) throw new ArgumentNullException(nameof(aS));
		    if (aS.RawKind != (int)SandySyntaxKind.AS) throw new ArgumentException(nameof(aS));
		    if (targetType == null) throw new ArgumentNullException(nameof(targetType));
		    return (TypeConversionSyntax)SandyLanguage.Instance.InternalSyntaxFactory.TypeConversion((Syntax.InternalSyntax.ExpressionGreen)value.Green, (InternalSyntaxToken)aS.Node, (Syntax.InternalSyntax.TypeGreen)targetType.Green).CreateRed();
		}
		
		public TypeConversionSyntax TypeConversion(ExpressionSyntax value, TypeSyntax targetType)
		{
			return this.TypeConversion(value, this.Token(SandySyntaxKind.AS), targetType);
		}
		
		public ParenExpressionSyntax ParenExpression(SyntaxToken lPAREN, ExpressionSyntax expression, SyntaxToken rPAREN)
		{
		    if (lPAREN == null) throw new ArgumentNullException(nameof(lPAREN));
		    if (lPAREN.RawKind != (int)SandySyntaxKind.LPAREN) throw new ArgumentException(nameof(lPAREN));
		    if (expression == null) throw new ArgumentNullException(nameof(expression));
		    if (rPAREN == null) throw new ArgumentNullException(nameof(rPAREN));
		    if (rPAREN.RawKind != (int)SandySyntaxKind.RPAREN) throw new ArgumentException(nameof(rPAREN));
		    return (ParenExpressionSyntax)SandyLanguage.Instance.InternalSyntaxFactory.ParenExpression((InternalSyntaxToken)lPAREN.Node, (Syntax.InternalSyntax.ExpressionGreen)expression.Green, (InternalSyntaxToken)rPAREN.Node).CreateRed();
		}
		
		public ParenExpressionSyntax ParenExpression(ExpressionSyntax expression)
		{
			return this.ParenExpression(this.Token(SandySyntaxKind.LPAREN), expression, this.Token(SandySyntaxKind.RPAREN));
		}
		
		public VarReferenceSyntax VarReference(SyntaxToken iD)
		{
		    if (iD == null) throw new ArgumentNullException(nameof(iD));
		    if (iD.RawKind != (int)SandySyntaxKind.ID) throw new ArgumentException(nameof(iD));
		    return (VarReferenceSyntax)SandyLanguage.Instance.InternalSyntaxFactory.VarReference((InternalSyntaxToken)iD.Node).CreateRed();
		}
		
		public MinusExpressionSyntax MinusExpression(SyntaxToken mINUS, ExpressionSyntax expression)
		{
		    if (mINUS == null) throw new ArgumentNullException(nameof(mINUS));
		    if (mINUS.RawKind != (int)SandySyntaxKind.MINUS) throw new ArgumentException(nameof(mINUS));
		    if (expression == null) throw new ArgumentNullException(nameof(expression));
		    return (MinusExpressionSyntax)SandyLanguage.Instance.InternalSyntaxFactory.MinusExpression((InternalSyntaxToken)mINUS.Node, (Syntax.InternalSyntax.ExpressionGreen)expression.Green).CreateRed();
		}
		
		public MinusExpressionSyntax MinusExpression(ExpressionSyntax expression)
		{
			return this.MinusExpression(this.Token(SandySyntaxKind.MINUS), expression);
		}
		
		public IntLiteralSyntax IntLiteral(SyntaxToken iNTLIT)
		{
		    if (iNTLIT == null) throw new ArgumentNullException(nameof(iNTLIT));
		    if (iNTLIT.RawKind != (int)SandySyntaxKind.INTLIT) throw new ArgumentException(nameof(iNTLIT));
		    return (IntLiteralSyntax)SandyLanguage.Instance.InternalSyntaxFactory.IntLiteral((InternalSyntaxToken)iNTLIT.Node).CreateRed();
		}
		
		public DecimalLiteralSyntax DecimalLiteral(SyntaxToken dECLIT)
		{
		    if (dECLIT == null) throw new ArgumentNullException(nameof(dECLIT));
		    if (dECLIT.RawKind != (int)SandySyntaxKind.DECLIT) throw new ArgumentException(nameof(dECLIT));
		    return (DecimalLiteralSyntax)SandyLanguage.Instance.InternalSyntaxFactory.DecimalLiteral((InternalSyntaxToken)dECLIT.Node).CreateRed();
		}
		
		public TypeSyntax Type(SyntaxToken type)
		{
		    if (type == null) throw new ArgumentNullException(nameof(type));
		    return (TypeSyntax)SandyLanguage.Instance.InternalSyntaxFactory.Type((InternalSyntaxToken)type.Node).CreateRed();
		}
	
	    internal static IEnumerable<Type> GetNodeTypes()
	    {
	        return new Type[] {
				typeof(MainSyntax),
				typeof(LineSyntax),
				typeof(StatementSyntax),
				typeof(PrintSyntax),
				typeof(VarDeclarationSyntax),
				typeof(AssignmentSyntax),
				typeof(BinaryMulOperationSyntax),
				typeof(BinaryAddOperationSyntax),
				typeof(TypeConversionSyntax),
				typeof(ParenExpressionSyntax),
				typeof(VarReferenceSyntax),
				typeof(MinusExpressionSyntax),
				typeof(IntLiteralSyntax),
				typeof(DecimalLiteralSyntax),
				typeof(TypeSyntax),
			};
		}
	}
}

