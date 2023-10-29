using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.Languages.MetaCompiler.Antlr;
using Antlr4.Runtime;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax
{
    public partial class MetaCoreInternalSyntaxFactory : IAntlrSyntaxFactory
    {
	    AntlrLexer IAntlrSyntaxFactory.CreateAntlrLexer(ICharStream input)
	    {
	        return new MetaCoreLexer(input);
	    }
	
	    AntlrParser IAntlrSyntaxFactory.CreateAntlrParser(ITokenStream input)
	    {
	        return new MetaCoreParser(input);
	    }
    }
}
