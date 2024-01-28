using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Bootstrap.MetaCompiler2.Generators
{
    public class AntlrToolMessage
    {
        public readonly DiagnosticSeverity Severity;
        public readonly int ErrorCode;
        public readonly string FilePath;
        public readonly int Line;
        public readonly int Column;
        public readonly string Message;

        public AntlrToolMessage(DiagnosticSeverity severity, int errorCode, string filePath, int line, int column, string message)
        {
            Severity = severity;
            ErrorCode = errorCode;
            FilePath = filePath;
            Line = line;
            Column = column;
            Message = message;
        }
    }
}
