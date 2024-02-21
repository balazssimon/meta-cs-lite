using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class BindException : Exception
    {
        private readonly SourceLocation _location;

        public BindException(string message, SourceLocation location)
        {
            _location = location;
        }

        public BindException(string message, SourceLocation location, Exception innerException)
            : base(message, innerException)
        {
            _location = location;
        }

        public SourceLocation Location => _location;
    }
}
