using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class PlainAttribute : Attribute
    {
    }
}
