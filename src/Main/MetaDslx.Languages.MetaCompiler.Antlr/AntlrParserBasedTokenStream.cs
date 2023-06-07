using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Antlr
{
    public class AntlrParserBasedTokenStream : ITokenStream
    {
        private readonly AntlrSyntaxParser _parser;

        public AntlrParserBasedTokenStream(AntlrSyntaxParser parser)
        {
            _parser = parser;
        }

        public ITokenSource TokenSource => throw new NotImplementedException();

        public int Index => throw new NotImplementedException();

        public int Size => throw new NotImplementedException();

        public string SourceName => throw new NotImplementedException();

        public void Consume()
        {
            throw new NotImplementedException();
        }

        [return: NotNull]
        public IToken Get(int i)
        {
            throw new NotImplementedException();
        }

        [return: NotNull]
        public string GetText(Interval interval)
        {
            throw new NotImplementedException();
        }

        [return: NotNull]
        public string GetText()
        {
            throw new NotImplementedException();
        }

        [return: NotNull]
        public string GetText(RuleContext ctx)
        {
            throw new NotImplementedException();
        }

        [return: NotNull]
        public string GetText(IToken start, IToken stop)
        {
            throw new NotImplementedException();
        }

        public int LA(int i)
        {
            throw new NotImplementedException();
        }

        [return: NotNull]
        public IToken LT(int k)
        {
            throw new NotImplementedException();
        }

        public int Mark()
        {
            throw new NotImplementedException();
        }

        public void Release(int marker)
        {
            throw new NotImplementedException();
        }

        public void Seek(int index)
        {
            throw new NotImplementedException();
        }
    }
}
