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
using static MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax.SandyParser;

namespace MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax
{
    public class SandySyntaxParser : Antlr4SyntaxParser
    {
        public SandySyntaxParser(
            SandySyntaxLexer lexer,
            SandySyntaxNode? oldTree,
            ParseData? oldParseData,
            IEnumerable<TextChangeRange>? changes,
            CancellationToken cancellationToken = default)
            : base(lexer, oldTree, oldParseData, changes, cancellationToken)
        {
        }

        public override SyntaxNode Parse()
        {
            ParserState state = null;
            var green = this.ParseMain(ref state);
            var red = (SandySyntaxNode)green.CreateRed();
            return red;
        }

        public override (SyntaxNode?, IncrementalNodeData) IncrementalParse()
        {
            throw new NotImplementedException();
        }

        public GreenNode ParseMain(ref ParserState state)
        {
            throw new NotImplementedException();
        }

        protected override ParserStateManager? CreateStateManager()
        {
            throw new NotImplementedException();
        }

        internal MainContext _Antlr4ParseMain()
        {
            throw new NotImplementedException();
        }

        internal LineContext _Antlr4ParseLine()
        {
            throw new NotImplementedException();
        }

        internal StatementContext _Antlr4ParseStatement()
        {
            throw new NotImplementedException();
        }

        internal PrintContext _Antlr4ParsePrint()
        {
            throw new NotImplementedException();
        }

        internal VarDeclarationContext _Antlr4ParseVarDeclaration()
        {
            throw new NotImplementedException();
        }

        internal AssignmentContext _Antlr4ParseAssignment()
        {
            throw new NotImplementedException();
        }

        internal ExpressionContext _Antlr4ParseExpression(int _p)
        {
            throw new NotImplementedException();
        }

        internal TypeContext _Antlr4ParseType()
        {
            throw new NotImplementedException();
        }

    }
}

