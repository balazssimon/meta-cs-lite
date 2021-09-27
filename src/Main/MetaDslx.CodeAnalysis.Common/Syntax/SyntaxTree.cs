using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis
{
    public class SyntaxTree
    {
        public string? FilePath { get; }

        public FileLinePositionSpan GetLineSpan(TextSpan span)
        {
            throw new NotImplementedException();
        }

        public FileLinePositionSpan GetMappedLineSpan(TextSpan span)
        {
            throw new NotImplementedException();
        }

        public Location GetLocation(TextSpan span)
        {
            throw new NotImplementedException();
        }
    }
}
