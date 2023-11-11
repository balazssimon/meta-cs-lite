using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public class ModelException : Exception
    {
        public ModelException()
            : base()
        {
        }

        public ModelException(string message)
            : base(message)
        {
        }

        public ModelException(string message, Exception innerException)
            : base($"{message} -> {innerException.Message}", innerException)
        {
        }

    }
}
