using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface IValueBinder
    {
        MetaType Type { get; }
        object? RawValue { get; }
    }
}
