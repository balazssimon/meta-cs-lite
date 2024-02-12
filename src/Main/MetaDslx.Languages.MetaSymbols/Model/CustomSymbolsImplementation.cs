using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaSymbols.Model
{
    internal class CustomSymbolsImplementation : CustomSymbolsImplementationBase
    {
        public override string? Declaration_FullName(Declaration _this)
        {
            var parent = _this.Parent;
            if (parent is null || string.IsNullOrEmpty(parent.Name)) return _this.Name;
            else return $"{parent.FullName}.{_this.Name}";
        }

        public override string Symbol_NamespaceName(Symbol _this)
        {
            return _this.Parent?.FullName ?? string.Empty;
        }
    }

    public interface AAA
    {
        public static class BBB
        {
            public static readonly string S = "s";
        }
    }
}
