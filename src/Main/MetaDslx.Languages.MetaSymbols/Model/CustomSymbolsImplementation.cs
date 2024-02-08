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
    }
}
