using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SymbolAttribute : Attribute
    {
    }
}
